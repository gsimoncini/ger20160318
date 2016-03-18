using System;
using System.Data;
using mz.erp.commontypes.data;
using System.Collections;

namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Descripción breve de ComprobanteDeAjusteCuentaCorriente.
	/// </summary>
	public class ComprobanteDeAjusteCuentaCorriente:Comprobante, ITask, IPersistentTask 
	{
	
		#region Metodos Publicos

		public ComprobanteDeAjusteCuentaCorriente()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public string FillNumberWithZeros(string txt)
		{
			string separator = Variables.GetValueString("Comprobante.TiposDeComprobante.Numeracion.Separador");
			int cant1 = (int) ( Variables.GetValueLong("Comprobante.TiposDeComprobante.Numeracion.Seccion1.Longitud") );
			int cant2 = (int) ( Variables.GetValueLong("Comprobante.TiposDeComprobante.Numeracion.Seccion2.Longitud") );
			return mz.erp.systemframework.Util.FillNumberWithZeros(txt, separator, cant1, cant2);
		}

		#endregion 

		#region Variables Privadas
		
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processManager;
		private mz.erp.commontypes.SentenciasReplicacion _replication;

		private DataTable _tableTiposDeComprobantes;
		private bool _allowEditTipoDeComprobante = false;
		private bool _allowEditCuenta = true;
		private bool _allowEditFecha = true;
		private bool _allowEditResponsableEmision = true;
		private bool _allowEditNumeration = false;
		private bool _numeracionManual = false;
		private bool _preguntarAlCancelar = false;

		private mz.erp.businessrules.Cuenta _cuenta = null;
		private string _observaciones = string.Empty;

		private DataSet _dataComprobantes = new mz.erp.commontypes.data.tsa_ComprobantesDataset();
		private DataSet _dataComprobantesDetalleDeuda = new mz.erp.commontypes.data.tsa_ComprobanteDetalleDeudaDataset();
        //German 20120222 -  Tarea 0000247
        private DataSet _dataAplicacionPagos = new mz.erp.commontypes.data.tsa_AplicacionPagosDataset();
        //Fin German 20120222 -  Tarea 0000247
		
		

		#endregion

		#region Propiedades
		
		public string Observaciones
		{
			get{return _observaciones;}
			set{_observaciones = value;}
		}

		public string CodigoCuenta
		{
			get
				{
					if(_cuenta != null)	
						return _cuenta.Codigo;
					return string.Empty;
				}
			set
			{
				
				if( _cuenta == null || _cuenta.Codigo != value)
				{
					
					if( value != null && !value.Equals(string.Empty))
					{
						string idCuenta = mz.erp.businessrules.tsa_Cuentas.GetPkByUk(value);
						_cuenta = new mz.erp.businessrules.Cuenta(idCuenta);
						this._tipoComprobanteDestino = ComprobanteDeVentaSugerido();
						if(this._tipoComprobanteDestino != string.Empty)
						{
							this._mascara = tsy_TiposDeComprobantes.Mascara(this._tipoComprobanteDestino);
							this._numero = this._mascara.Replace('#','0');
							this._signoCuentaCorriente = Convert.ToInt16(mz.erp.businessrules.tsy_TiposDeComprobantes.GetByPk(this._tipoComprobanteDestino).signo);
						}
						else
						{
							this._numero = string.Empty;
							this._mascara = string.Empty;
							this._signoCuentaCorriente = 0;
						}
					}
					
					else
					{
						this._numero = string.Empty;
						this._mascara = string.Empty;
						this._signoCuentaCorriente = 0;
					}
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
			}
		}

		private string TipoComprobanteDestino
		{
			get{return _tipoComprobanteDestino;}
			set
			{
				if(value != _tipoComprobanteDestino)
				{
					if(this._tipoComprobanteDestino != string.Empty)
					{
						this._mascara = tsy_TiposDeComprobantes.Mascara(this._tipoComprobanteDestino);
						this._numero = this._mascara.Replace('#','0');
						this._signoCuentaCorriente = Convert.ToInt16(mz.erp.businessrules.tsy_TiposDeComprobantes.GetByPk(this._tipoComprobanteDestino).signo);
					}
					else
					{
						this._numero = string.Empty;
						this._mascara = string.Empty;
						this._signoCuentaCorriente = 0;
					}
				}
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
			}
		}

		public DataTable TableTiposDeComprobantes
		{
			get{ return _tableTiposDeComprobantes;}
		}

		public bool AllowEditTipoDeComprobante
		{
			set { _allowEditTipoDeComprobante = value; }
			get { return _allowEditTipoDeComprobante; }
		}

		public bool PreguntarAlCancelar
		{
			get {return _preguntarAlCancelar ;}
		}

		public bool AllowEditCuenta
		{
			set { _allowEditCuenta = value; }
			get { return _allowEditCuenta; }
		}


		public bool AllowEditFecha
		{
			set { _allowEditFecha = value; }
			get { return _allowEditFecha; }
		}

		
		public bool AllowEditResponsableEmision
		{
			set { _allowEditResponsableEmision = value; }
			get { return _allowEditResponsableEmision; }
		}
		
		public bool AllowEditNumeration
		{
			set { _allowEditNumeration = value;}
			get { return _allowEditNumeration; }
		}



		#endregion

		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;

		public event System.EventHandler OnTaskAfterPrevious;

		public void ListenerTaskDependentChanged(object sender)
		{
			
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
            //German 20120223 -  Tarea 0000247
            if (sender.GetType() == typeof(mz.erp.businessrules.comprobantes.ComprobanteDeVenta) &&
                (this._processManager.Process.ProcessName.Equals("ProcesoPrevenderVenderAcopio")
                || this._processManager.Process.ProcessName.Equals("ProcesoPreprestarPrestarAcopio")
                )
              )

            {
                ComprobanteDeVenta comp = (ComprobanteDeVenta)sender;
                this.CodigoCuenta = comp.CodigoCuenta;
                this.Total = comp.Total;
                this.Observaciones = "Crédito por Factura de Acopio. Comprobante Aumático para saldar la factura de Acopio.";
            }
            //Fin German 20120223 -  Tarea 0000247
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}

		public void Init()
		{
			InitData();
			InitEventHandlers();
			SetEditablesProperty();
		}

		
		private void SetEditablesProperty()
		{
			AllowEditTipoDeComprobante = ComprobantesRules.Momentos_Parametros_Bool( this._taskName, this._processManager.Process.ProcessName, "Emision.Editar.TComp");
			AllowEditCuenta = ComprobantesRules.Momentos_Parametros_Bool( this._taskName, this._processManager.Process.ProcessName, "Emision.Editar.Cuenta");
			AllowEditFecha = ComprobantesRules.Momentos_Parametros_Bool( this._taskName, this._processManager.Process.ProcessName, "Emision.Editar.Fecha");
			AllowEditResponsableEmision = ComprobantesRules.Momentos_Parametros_Bool( this._taskName, this._processManager.Process.ProcessName,"Emision.Editar.REmision");
			AllowEditNumeration = ComprobantesRules.Momentos_Parametros_Bool( this._taskName, this._processManager.Process.ProcessName, "Emision.Editar.Numeracion");
			_numeracionManual = AllowEditNumeration;
		}

		private void InitEventHandlers()
		{
			
		}

		private string ComprobanteDeVentaSugerido()
		{
		
			 //German 20120416 -  Tarea 0000247
            ArrayList arrayComprobantesPorCategoria = ComprobantesRules.CategoriaImpositiva_Comprobantes_Por_Tipo(this._cuenta.CategoriaImpositiva);;
            if (this._processManager.Process.ProcessName.Equals("ProcesoPrevenderVenderAcopio"))
            {

            
                if (arrayComprobantesPorCategoria.Contains("CREACOPA"))
                    return "CREACOPA";
                else return "CREACOPB";
            }
            else
                if (this._processManager.Process.ProcessName.Equals("ProcesoPreprestarPrestarAcopio"))
                {
                    if (arrayComprobantesPorCategoria.Contains("CREACOPAN"))
                        return "CREACOPAN";
                    else return "CREACOPBN";
                }
                else
                {

                    foreach (DataRow row in _tableTiposDeComprobantes.Rows)
                    {
                        //for (int f=0;f<=(arrayComprobantesPorCategoria.Length -1) ;f++)
                        foreach (string IdComp in arrayComprobantesPorCategoria)
                        {
                            if (Convert.ToString(row["IdTipoDeComprobante"]).Trim().ToUpper() == IdComp.Trim().ToUpper())
                                return Convert.ToString(row["IdTipoDeComprobante"]).Trim().ToUpper();
                        }
                    }
                }
            //Fin German 20120416 -  Tarea 0000247
			return string.Empty;

		}

		private void InitData()
		{
			this._tipoComprobanteDestino = string.Empty;
			this._observaciones = string.Empty;
			this._IdResponsable = Security.IdPersona;
            //German 20120606 -  Tarea 0000247
            if ( this._processManager.Process.ProcessName.Equals("ProcesoPrevenderVenderAcopio"))
                this._tableTiposDeComprobantes = mz.erp.dataaccess.tsy_TiposDeComprobantes.GetList(null, null, true, int.MinValue, "CREACOPA,CREACOPB", null).Tables[0];
            else
                if(this._processManager.Process.ProcessName.Equals("ProcesoPreprestarPrestarAcopio"))
                    this._tableTiposDeComprobantes = mz.erp.dataaccess.tsy_TiposDeComprobantes.GetList(null, null, true, int.MinValue, "CREACOPAN,CREACOPBN", null).Tables[0];
                else
                    this._tableTiposDeComprobantes = Workflow.GetComprobantesAsociados(Workflow.GetIdTakByName(this._taskName)).Tables[0];
            //Fin German 20120606 -  Tarea 0000247
			string codigoCuenta = Variables.GetValueString(this._processManager.Process.ProcessName, this._taskName, "Cuenta.Default");
			if(this._codigoCuenta != null && !this._codigoCuenta.Equals(string.Empty))
			{
				string idCuenta = mz.erp.businessrules.tsa_Cuentas.GetPkByUk(codigoCuenta);
				_cuenta = new mz.erp.businessrules.Cuenta(idCuenta);
				this._tipoComprobanteDestino = ComprobanteDeVentaSugerido();
				if(this._tipoComprobanteDestino != string.Empty)
				{
					this._mascara = tsy_TiposDeComprobantes.Mascara(this._tipoComprobanteDestino);
					this._signoCuentaCorriente = Convert.ToInt16(mz.erp.businessrules.tsy_TiposDeComprobantes.GetByPk(this._tipoComprobanteDestino).signo);
					this._numero = this._mascara.Replace('#','0');
				}
			}
			if(this._tipoComprobanteDestino == string.Empty)
			{
				this._tipoComprobanteDestino = Variables.GetValueString(this._processManager.Process.ProcessName, this._taskName, "Comprobantes.Default");
				if(this._tipoComprobanteDestino != string.Empty)
				{
					this._mascara = tsy_TiposDeComprobantes.Mascara(this._tipoComprobanteDestino);
					this._signoCuentaCorriente = Convert.ToInt16(mz.erp.businessrules.tsy_TiposDeComprobantes.GetByPk(this._tipoComprobanteDestino).signo);
					this._numero = this._mascara.Replace('#','0');
				}
				else
				{
					this._mascara = string.Empty;
					this._numero = string.Empty;
					this._signoCuentaCorriente = 0;
				}
			}

			this._idComprobante = mz.erp.systemframework.Util.NewStringId();
			this._fechaComprobante = mz.erp.businessrules.Sistema.DateTime.Now;
			this._total = 0;
			_preguntarAlCancelar = Variables.GetValueBool(_processManager.Process.ProcessName,_taskName,"PreguntarAlCancelar");

			
		}
	
		
		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processManager.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}


		public bool IsValid()
		{
			bool IsValid = true;
			_errores.Clear();
			
			if(this._cuenta == null || this._cuenta.Equals(string.Empty)){
				_errores.Add( new ItemDatasetError( "Error en Cliente","Número de cuenta","Debe ingresar el número de cuenta"));
				IsValid = false;
			}

			return IsValid;
		}

		
		public bool AllowShow()
		{
			return true;
		}
		public void FormHasClosed() 
		{
		}
		public ItemsDatasetErrors GetErrors()
		{
			
			return _errores;
		}

		public string GetWarnings()
		{
			return null;
		}

		public ProcessManager GetProcessManagerParent()
		{
			return _processManager;
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_processManager = processManager;
		}

		public string GetTaskName()
		{
			return _taskName;
		}

		public void SetTaskName(string taskName)
		{
			_taskName = taskName;
		}

		public void Execute()
		{
			if(OnTaskBeforeExecute != null)
				OnTaskBeforeExecute(this, new EventArgs());			

			this.IsValid();

			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}

		public bool AllowPrevious()
		{
			return true;
		}

		public void Previous()
		{
			
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public void ListenerAfterPreviousDependentTask(object sender)
		{
			
		}

		public void ListenerBeforePreviousDependentTask(object sender)
		{
			
		}

		#endregion

		#region Miembros de IPersistentTask

		public event System.EventHandler OnTaskBeforeFlush;

		public event System.EventHandler OnTaskAfterFlush;

		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();
			_dataComprobantes.DataSetName= "tsa_CompbrobantesDataset";
			data.Add(_dataComprobantes);
			_dataComprobantesDetalleDeuda.DataSetName = "tsa_ComprobantesDetalleDeuda";
			data.Add(_dataComprobantesDetalleDeuda);
			return data;
		}

		
		private void CommitComprobante()
		{
			tsa_ComprobantesDataset.tsa_ComprobantesRow row = ((tsa_ComprobantesDataset) _dataComprobantes).tsa_Comprobantes.Newtsa_ComprobantesRow();

			DateTime now = mz.erp.businessrules.Sistema.DateTime.Now;
			DateTime fc = this.FechaComprobante;
			DateTime fecha = new DateTime(fc.Year, fc.Month, fc.Day, now.Hour,now.Minute, now.Second);
			row.Fecha = fecha;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdComprobante = this.IdComprobante;
			row.IdCuenta = this._cuenta.IdCuenta;
			row.IdResponsable = this._IdResponsable;								

			row.IdTipoDeComprobante = this.TipoComprobanteDestino;
			//row.Numero = "";//Util.NewStringId();
			row.IdCotizacionCierre = ComprobantesRules.Contabilidad_CotizacionReferencia;
			row.Total = this.Total;
			row.IdCondicionDeVenta = "1";

			row.IdConexionCreacion = Security.IdConexion;
			row.IdConexionUltimaModificacion = Security.IdConexion;
		
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
		
			row.IdInstanciaCaja = string.Empty;
			row.IdMonedaCierre = ComprobantesRules.Contabilidad_MonedaReferencia;
			row.IdReservado = 0;
		
			//this.Numero = row.Numero;
			row.Numero = this.Numero; //ORL. Le paso al row el valor de comprobante.Numero para que no reviente en los items si es nulo.
			
			//cargo los datos adicionles del cliente
			row.Cliente = this._cuenta.Nombre;
			row.Domicilio = this._cuenta.Domicilio;
			row.TipoDocumento = this._cuenta.TipoDocumento;
			row.Documento = this._cuenta.Documento;
			row.Observaciones = this._observaciones;//this.InfoObservaciones;
			row.Aux1 = string.Empty;
			row.Aux1 = string.Empty;
			row.Aux1 = string.Empty;

			((tsa_ComprobantesDataset) _dataComprobantes).tsa_Comprobantes.Addtsa_ComprobantesRow( row );
		}


		private void CommitComprobanteDetalleDeuda()
		{
			tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow row = ((tsa_ComprobanteDetalleDeudaDataset)_dataComprobantesDetalleDeuda).tsa_ComprobanteDetalleDeuda.Newtsa_ComprobanteDetalleDeudaRow();
			row.IdComprobante = mz.erp.systemframework.Util.NewStringId();
			row.IdTipoDeComprobante = this.TipoComprobanteDestino;
			row.Numero= this.Numero;
			row.FechaEmision= mz.erp.systemframework.Util.AddTime(this.FechaComprobante, mz.erp.businessrules.Sistema.DateTime.Now);
			row.Cuota= 1;
			row.FechaVencimiento= row.FechaEmision ;
			row.Importe= this._total * this._signoCuentaCorriente;
			row.Saldo= this._total * this._signoCuentaCorriente;
			row.IdMonedaCierre= Variables.GetValueString("Contabilidad.MonedaReferencia");
			row.IdCotizacionCierre= Variables.GetValueString("Contabilidad.CotizacionReferencia");
			row.IdSucursal = Security.IdSucursal;
			row.IdEmpresa = Security.IdEmpresa;
			((tsa_ComprobanteDetalleDeudaDataset)_dataComprobantesDetalleDeuda).tsa_ComprobanteDetalleDeuda.Rows.Add(row);
		
			string IdCuenta = this._cuenta.IdCuenta;
			decimal Importe = row.Importe;
			string IdTipoDeComprobante = this.TipoComprobanteDestino;
			GuardarSaldoCuentaCorriente.GetInstance().CommitSaldoCuentaCorriente(this.GetProcessManagerParent().Process,IdCuenta, Importe, IdTipoDeComprobante);
		}

		public void Commit()
		{
			CommitComprobante();
			CommitComprobanteDetalleDeuda();
		}

		private string UpdateNumero(DataRow  row, string IdTransaction)
		{
			if (!this._numeracionManual) 
			{
					string numeracion = Variables.GetValueStringWithoutCache("Comprobantes.Numeracion." + (string)row["IdTipoDeComprobante"],IdTransaction);
					string Numero = mz.erp.systemframework.Util.StcZero(numeracion,8);
					row["Numero"]= Numero;
					sy_VariablesDataset.sy_VariablesRow rowVar = mz.erp.businessrules.sy_Variables.GetByPk("Comprobantes.Numeracion." + row["IdTipoDeComprobante"],IdTransaction);
					return rowVar.IdVariable;
			}
			return null;
		}

		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());
			string IdVariable = UpdateNumero(this._dataComprobantes.Tables[0].Rows[0],IdTransaction);
			_replication = GenerateReplication();
			mz.erp.dataaccess.tsa_Comprobantes.Update( _dataComprobantes.Tables["tsa_Comprobantes"], IdTransaction, _replication);	
			this.IdComprobante = (string)_dataComprobantes.Tables["tsa_Comprobantes"].Rows[0]["IdComprobante"];		
			mz.erp.dataaccess.sy_Variables.Update(IdVariable,(string) _dataComprobantes.Tables["tsa_Comprobantes"].Rows[0]["Numero"],IdTransaction);				
			foreach(DataRow row in _dataComprobantesDetalleDeuda.Tables[0].Rows)
			{
				row["IdComprobante"] = this.IdComprobante;
                //German 20120222 -  Tarea 0000247
                if(_processManager.Process.ProcessName.Equals("ProcesoPrevenderVenderAcopio")
                    || this._processManager.Process.ProcessName.Equals("ProcesoPreprestarPrestarAcopio"))
                    row["Saldo"] = 0;
                //German 20120222 -  Tarea 0000247
			}
			mz.erp.dataaccess.tsa_ComprobanteDetalleDeuda.Update( _dataComprobantesDetalleDeuda.Tables["tsa_ComprobanteDetalleDeuda"],IdTransaction, _replication); 				
             //German 20120222 -  Tarea 0000247
            foreach(DataRow row in _dataAplicacionPagos.Tables[0].Rows)
			{
				row["IdComprobanteDestino"] = this.IdComprobante;
               
                
			}
            mz.erp.dataaccess.tsa_AplicacionPagos.Update(_dataAplicacionPagos.Tables[0], IdTransaction);
            //German 20120222 -  Tarea 0000247
			GuardarSaldoCuentaCorriente.GetInstance().FlushSaldoCuentaCorriente(this.GetProcessManagerParent().Process, IdTransaction, _replication);
			
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
            //German 20120222 -  Tarea 0000247
            foreach (TaskCollectionData _collectionTask in _processCollectionData)
            {
                if ( (_collectionTask.TaskName.Equals("Vender") && this._processManager.Process.ProcessName.Equals("ProcesoPrevenderVenderAcopio"))
                    || (_collectionTask.TaskName.Equals("Prestar") && this._processManager.Process.ProcessName.Equals("ProcesoPreprestarPrestarAcopio"))
                    )
                {
                    foreach (System.Data.DataSet dataventas in _collectionTask)
                    {
                        if (dataventas.DataSetName.Equals("tsa_ComprobantesExDataset"))
                        {
                            if (dataventas.Tables["tsa_ComprobanteDetalleDeuda"].Rows.Count == 1)
                            {
                               dataventas.Tables["tsa_ComprobanteDetalleDeuda"].Rows[0]["Saldo"] = 0;
                                
                            }

                        }
                    }
                }
            }
            //Fin German 20120222 -  Tarea 0000247
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{


            //German 20120222 -  Tarea 0000247
            foreach (TaskCollectionData _collectionTask in _processCollectionData)
            {
                if ((_collectionTask.TaskName.Equals("Vender") && this._processManager.Process.ProcessName.Equals("ProcesoPrevenderVenderAcopio"))
                    || (_collectionTask.TaskName.Equals("Prestar") && this._processManager.Process.ProcessName.Equals("ProcesoPreprestarPrestarAcopio"))
                    )
                {
                    foreach (System.Data.DataSet dataventas in _collectionTask)
                    {
                        if (dataventas.DataSetName.Equals("tsa_ComprobantesExDataset"))
                        {
                            if (dataventas.Tables["tsa_comprobantes"].Rows.Count == 1)
                            {
                                string IdComprobanteFacturaAcopio = Convert.ToString(dataventas.Tables["tsa_comprobantes"].Rows[0]["IdComprobante"]);
                                string IdTipoDeComp= Convert.ToString(dataventas.Tables["tsa_comprobantes"].Rows[0]["IdTipoDeComprobante"]);
                                
                                
                                _dataAplicacionPagos.Clear();


                                mz.erp.commontypes.data.tsa_AplicacionPagosDataset.tsa_AplicacionPagosRow row = ((mz.erp.commontypes.data.tsa_AplicacionPagosDataset)_dataAplicacionPagos).tsa_AplicacionPagos.Newtsa_AplicacionPagosRow();
					
					            row.IdComprobanteOrigen =IdComprobanteFacturaAcopio; 
					            row.CuotaOrigen =1 ; 
					            row.IdComprobanteDestino = this.IdComprobante; 
					            row.IdTipoComprobanteOrigen = IdTipoDeComp;
					            row.Importe = this.Total;
					            row.IdTipoDeComprobanteDestino = this.TipoComprobanteDestino;
					            row.CuotaDestino = 1;
					            row.IdEmpresa = Security.IdEmpresa;
					            row.IdSucursal = Security.IdSucursal;
					            row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
					            row.IdConexionCreacion = Security.IdConexion;
					            row.IdConexionUltimaModificacion = Security.IdConexion;
					            row.IdReservado = 0;
					            row.RowId = Guid.Empty;	
					            ((mz.erp.commontypes.data.tsa_AplicacionPagosDataset)_dataAplicacionPagos).tsa_AplicacionPagos.Addtsa_AplicacionPagosRow(row);


                                
                            }

                        }
                    }
                }
            }
            //Fin German 20120222 -  Tarea 0000247
		}

		
		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			return _replication;
		}
		private mz.erp.commontypes.SentenciasReplicacion GenerateReplication()
		{
			mz.erp.commontypes.SentenciasReplicacion replication = new mz.erp.commontypes.SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tpu_Comprobantes";
			return replication;
		}

		public bool GetHasSaved()
		{
			return false;
		}

		#endregion
	}
}

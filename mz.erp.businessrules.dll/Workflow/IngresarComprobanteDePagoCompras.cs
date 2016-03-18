using System;
using System.Data;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.businessrules.comprobantes;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de IngresarComprobanteDePagoCompras.
	/// </summary>
	public class IngresarComprobanteDePagoCompras: ITask, IPersistentTask
	{
		
		#region Constructores

		public IngresarComprobanteDePagoCompras()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#endregion

		#region Variables Privadas

			private ComprobanteDePagoCompras _comprobante = new ComprobanteDePagoCompras();
			private bool _allowEditTipoDeComprobante = true;
			private bool _allowEditProveedor = true;
			private bool _allowEditFecha = true;
			private bool _allowEditResponsableEmision = true;
			private bool _allowEditNumeration = false;
			private bool _actualizaNumeracion = true;
			private bool _allowEditImputacion = true;
			private bool _allowEditValores = true;
			private bool _allowEditInstanciaDeCaja = true;
			private bool _allowValidarNumeracion = false;
			private bool _askForPasswordResponsableEmision = false;
			private bool _allowSearchValores = false;

			private string _textoBotonAnterior = "Anterior";
			private string _textoBotonSiguiente = "Siguiente";

			private DataTable _tiposDeComprobantesDePago = new DataTable();
			private string _listaTiposDeComprobantesValidos = string.Empty;
			private string _idComprobantePrevio = string.Empty;
			

			private bool _permiteImputacionesParciales = false;
			private bool _validarMontoIgualImputaciones = false;
			private bool _preguntarAlCancelar = false;

			private bool _visualizaVentana = true;

		#endregion

		#region Variables Privadas ITask

		protected string _taskName = string.Empty;		
		protected ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		protected ProcessManager _processParent;

		#endregion

		#region Propiedades

		public string IdComprobante
		{
			get{return _comprobante.IdComprobanteDestino;}
		}

		public string Proveedor
		{
			get{return _comprobante.Proveedor;}
		}


		public string Numero
		{
			get{return _comprobante.Numero;}
			set{_comprobante.Numero = value;}
		}

		public ArrayList Valores
		{
			get{return _comprobante.Valores;}
		}

		public string Observaciones
		{
			get{return _comprobante.Observaciones;}
			set{_comprobante.Observaciones = value;}
		}

		public string TipoComprobanteDestino
		{
			get{return _comprobante.TipoComprobanteDestino;}
			set{_comprobante.TipoComprobanteDestino = value;}
		}


		public decimal Total
		{
			get{return _comprobante.Total;}
		}

		public decimal Saldo
		{
			get{return _comprobante.Saldo;}
		}

		public string Mascara 
		{
			get{return _comprobante.Mascara;}
		}

		public DateTime FechaComprobante
		{
			get{return _comprobante.FechaComprobante;}
			set{_comprobante.FechaComprobante = value;}
		}

		public DataTable TiposDeComprobantesDePago
		{
			get{return _tiposDeComprobantesDePago;}
		}

		public bool AllowSearchValores
		{
			get{return _allowSearchValores;}
		}

		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonAnterior";
				valor = Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonAnterior";
					valor = Variables.GetValueString(variable);		
				}
				if (valor == String.Empty) 
				{
					return _textoBotonAnterior;
				}
				else 
				{
					return valor;
				}							
			}
		}
		
		public string TextoBotonSiguiente
		{
			get 
			{		
				string valor = String.Empty;				
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonSiguiente";
				valor = Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonSiguiente";
					valor = Variables.GetValueString(variable);				
				}									
				if (valor == String.Empty) 
				{
					return _textoBotonSiguiente;
				}
				else 
				{
					return valor;
				}
			}
		}

		
		public bool PreguntarAlCancelar
		{
			get {return _preguntarAlCancelar ;}
			set {_preguntarAlCancelar =value;}
		}
		
		public bool AskForPasswordResponsableEmision
		{
			get {return _askForPasswordResponsableEmision; }
		}

		public DataTable InstanciasCajasAbiertas
		{
			get{return _comprobante.InstanciasCajasAbiertas;}
		}

		public bool AllowEditInstanciaDeCaja
		{
			get{return _allowEditInstanciaDeCaja && _comprobante.AllowEditInstanciaDeCaja;}
		}

		public bool AllowEditValores
		{
			get{return _allowEditValores;}
		}

		public bool AllowEditImputacion
		{
			get{return _allowEditImputacion;}
		}

		public bool AllowEditTipoDeComprobante
		{
			get{ return _allowEditTipoDeComprobante;}
		}

		public bool AllowEditProveedor
		{
			get{ return _allowEditProveedor; }
		}

		public bool AllowEditFecha
		{
			get {return _allowEditFecha;}
		}

		public bool AllowEditResponsableEmision
		{
			get{ return _allowEditResponsableEmision; }
		}

		public bool AllowEditNumeration
		{
			get{ return _allowEditNumeration; }
		}

		public string IdProveedor
		{
			get{return _comprobante.IdProveedor;}
		}

		public string IdInstanciaCaja
		{
			get{return _comprobante.IdInstanciaCaja;}
			set{_comprobante.IdInstanciaCaja = value;}
		}

		public string IdResponsable
		{
			get{return _comprobante.IdResponsable;}
			set{_comprobante.IdResponsable = value;}
		}

		public string CodigoProveedor
		{
			get
			{
				return _comprobante.CodigoProveedor;
			}
			set
			{
				//_comprobante.CodigoProveedor = value;
				if(value != null && !value.Equals(string.Empty))
				{	_comprobante.CodigoProveedor = value;
					Proveedor proveedor = new Proveedor();
					proveedor.GetCuenta_CodigoProveedor(_comprobante.CodigoProveedor);
					_comprobante.IdProveedor = proveedor.IdProveedor;
				}else
					_comprobante.IdProveedor = string.Empty;

			}
		}

		public string NombreProveedor
		{
			get
			{
				Proveedor proveedor = new Proveedor();
				proveedor.GetCuenta_CodigoProveedor(_comprobante.CodigoProveedor);
				return proveedor.Nombre;
			}
		}
		public decimal TotalImputado
		{
			get
			{
				return _comprobante.TotalImputado;
			}
		}

		public mz.erp.businessrules.CuentaCorriente CuentaCorriente
		{
			get
			{
				return _comprobante.CuentaCorriente;
			}
			
		}

		public bool VisualizaVentana
		{
			get{return _visualizaVentana;}
		}

        //Sabrina: Tarea 1120. 20110817
        public bool AllowEditImputaAutomaticamente
        {
            get { return _comprobante.AllowEditImputaAutomaticamente; }
        }

        public bool ImputaAutomaticamente
        {
            get { return _comprobante.ImputaAutomaticamente; }
            set { _comprobante.ImputaAutomaticamente = value; }
        }
        //Fin Sabrina: Tarea 1120. 20110817
        
        #endregion

		#region Eventos
			
			public event EventHandler TotalChanged;
			public event EventHandler TotalImputadoChanged;
		
		#endregion

		#region Metodos Privados

        private void SetEditablesProperty()
		{
			string processName = this.GetProcessManagerParent().Process.ProcessName;
			_allowEditTipoDeComprobante = ComprobantesRules.Momentos_Parametros_Bool(this._taskName,  processName,  "Emision.Editar.TComp");
			_allowEditProveedor = ComprobantesRules.Momentos_Parametros_Bool(  this._taskName,  processName, "Emision.Editar.Proveedor");
			_allowEditFecha = ComprobantesRules.Momentos_Parametros_Bool(  this._taskName,  processName, "Emision.Editar.Fecha");
			_allowEditResponsableEmision = ComprobantesRules.Momentos_Parametros_Bool(  this._taskName,  processName, "Emision.Editar.REmision");
			_allowEditNumeration = ComprobantesRules.Momentos_Parametros_Bool(  this._taskName,  processName, "Emision.Editar.Numeracion");
			_actualizaNumeracion = !ComprobantesRules.Momentos_Parametros_Bool(  this._taskName,  processName, "Emision.Editar.Numeracion");
			_allowValidarNumeracion = ComprobantesRules.Momentos_Parametros_Bool(  this._taskName,  processName, "Emision.Validar.Numeracion");
			_askForPasswordResponsableEmision = Variables.GetValueBool(  this._taskName,  processName, "Emision.HabilitarContraseña.REmision");
			_allowEditInstanciaDeCaja = Variables.GetValueBool(  this._taskName,  processName, "Emision.Editar.IdInstanciaCaja", _allowEditInstanciaDeCaja);
		}

		private void _comprobante_TotalChanged(object sender, EventArgs e)
		{
			if(TotalChanged != null)
				TotalChanged(this, new EventArgs());
		}

		private void _comprobante_PagoChanged(object sender, EventArgs e)
		{
			if(TotalImputadoChanged != null)
				TotalImputadoChanged(this, new EventArgs());
		}

		#endregion

		#region Metodos Publicos

		public bool IsRemovable(object selectedItem)
		{
			return !_comprobante.PertenceRetenciones((Valor)selectedItem);
		}

		public bool HayRetenciones(string IdTipoDeRetencion)
		{
			return _comprobante.HayRetenciones(IdTipoDeRetencion);
		}

		public bool ContainsValor(Valor valor)
		{
			return _comprobante.ContainsValor(valor);
		}


		public void AddValor(Valor valor)
		{
			_comprobante.AddValor(valor);
		}

		public void Recalcular()
		{
			_comprobante.Recalcular();
		}

		public void UpdatePago(object selectedRow)
		{
			ItemCuentaCorriente dcc = (ItemCuentaCorriente) selectedRow;
			_comprobante.CuentaCorriente.UpdatePago(dcc);
		}

		public void CalcularRetenciones()
		{
			_comprobante.CalcularRetenciones();
		}

		public string FillNumberWithZeros(string txt)
		{
			string separator = Variables.GetValueString("Comprobante.TiposDeComprobante.Numeracion.Separador");
			int cant1 = (int) ( Variables.GetValueLong("Comprobante.TiposDeComprobante.Numeracion.Seccion1.Longitud") );
			int cant2 = (int) ( Variables.GetValueLong("Comprobante.TiposDeComprobante.Numeracion.Seccion2.Longitud") );
			return mz.erp.systemframework.Util.FillNumberWithZeros(txt, separator, cant1, cant2);
		}

		#endregion
        
		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;

		public event System.EventHandler OnTaskAfterPrevious;

		public  void ListenerTaskDependentChanged(object sender)
		{
			
		}

		public  void ListenerAfterExecuteDependentTask(object sender)
		{
			if (sender.GetType() == typeof( mz.erp.businessrules.SeleccionarComprobantesDeCompraPendientes ))
			{
				SeleccionarComprobantesDeCompraPendientes pend = (SeleccionarComprobantesDeCompraPendientes)sender;
				_idComprobantePrevio = Convert.ToString(pend.ArrayComprobantesPendientes[0]);
				Step();
			}	
			if (sender.GetType() == typeof( mz.erp.businessrules.SolicitarAutorizacion ))
			{
				SolicitarAutorizacion solicitar = (SolicitarAutorizacion) sender;
				_comprobante.IdAutorizacion = solicitar.IdAutorizacion;
				
			}
			// ---- Matias - Tarea 282 - 20090724
			if (sender.GetType() == typeof( mz.erp.businessrules.IngresarComprobanteDeCompraCabecera ))
			{
				IngresarComprobanteDeCompraCabecera comprobanteDeCompraCabecera = (IngresarComprobanteDeCompraCabecera) sender;
				StepDesdeComprobanteDeCompraCabecera(comprobanteDeCompraCabecera);
				
				
			}
			// ---- FinMatias.
		}

		private void Step()
		{
			_comprobante.Step(_idComprobantePrevio);
		}

		private void StepDesdeComprobanteDeCompraCabecera(IngresarComprobanteDeCompraCabecera comprobanteDeCompraCabecera)
		{
			_comprobante.StepDesdeComprobanteDeCompraCabecera(comprobanteDeCompraCabecera);
		}

		public  void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}

		public  void Init()
		{
			_comprobante.Init(this._processParent.Process.ProcessName, this._taskName, this._processParent);
			_comprobante.TotalChanged +=new EventHandler(_comprobante_TotalChanged);
			_comprobante.PagoChanged +=new EventHandler(_comprobante_PagoChanged);
			_allowSearchValores = Variables.GetValueBool(this._processParent.Process.ProcessName,_taskName, "PermiteBuscarValores");
			this._listaTiposDeComprobantesValidos = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "Comprobantes");
			this._tiposDeComprobantesDePago = mz.erp.businessrules.tsy_TiposDeComprobantes.GetList(null,null,true,int.MinValue,_listaTiposDeComprobantesValidos).tsy_TiposDeComprobantes;
			SetEditablesProperty();
			_permiteImputacionesParciales = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "PermiteImputacionesParciales");
			_validarMontoIgualImputaciones = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "Validar.MontoIgualImputaciones");
			_preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar");
            _visualizaVentana = Variables.GetValueBool(_processParent.Process.ProcessName, _taskName, "VisualizaVentana", true);
		}

		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}

		public bool IsValidNumeration
		{
			get
			{
				if (this._allowValidarNumeracion )
				{  
					if (_comprobante.Numero== null || _comprobante.Numero.EndsWith("-") || (_comprobante.Numero == string.Empty)) 
					{
						return false;
					}
				}
				return true;
			}
		}



		public bool IsValidProveedor
		{
			get 
			{
				return _comprobante.IsValidProveedor;
			}
		}
		public bool IsValidResponsable
		{
			get
			{
				return _comprobante.IsValidResponsable;
			}
		}

		public bool IsValidInstanciaDeCaja
		{
			get
			{
				return _comprobante.IsValidInstanciaDeCaja;
				
			}
		}

		public bool IsValidMontoConImputacion
		{
			get
			{
				if(_validarMontoIgualImputaciones)
					return _comprobante.IsValidMontoConImputacion;
				return true;
			}
		}	

		public bool IsValidImputaciones
		{
			get
			{
				if(!_permiteImputacionesParciales)
                    return _comprobante.IsValidImputaciones;
				return true;
			}
		}

		public bool IsValidMonto
		{
			get
			{
				return _comprobante.IsValidMonto;
			}
		}

		public  bool IsValid()
		{
			bool isvalid = true;
			_errores.Clear();
			if (_comprobante.IdInstanciaCaja != null && _comprobante.IdInstanciaCaja != string.Empty)
			{

				if(true)// Variable q indica si se realiza la validacion
				{
					Hashtable table = new Hashtable();
					foreach ( Valor valor in this._comprobante.Valores )  
					{	
						if(valor.Agrupado)
						{
							string key = valor.IdTDCompTesoreria + '-' + valor.IdMoneda +'-' + valor.Comprobante + '-' + valor.Moneda;
							if(!table.ContainsKey(key)) table.Add(key, 0);
							decimal monto  = Convert.ToDecimal(table[key]);
							monto = monto + valor.Monto;
							table[key] = monto;

						}
					}
					foreach(string key in table.Keys)
					{
						string[] partes = key.Split( new char[]{'-'});
						string IdTDcomp = partes[0];
						string IdM = partes[1];
						string Comp = partes[2];
						string Mon = partes[3];
						decimal total = Convert.ToDecimal(table[key]);
						//decimal totalPorTDComp = tfi_Cajas.GetImportePorTipoDeComprobanteAnterior( dvm.IdTDCompTesoreria, dvm.IdMoneda , tfi_InstanciasCaja.GetByPk(IdCaja).IdCaja);
						decimal totalPorTDComp = tfi_Cajas.GetImportePorTipoDeComprobante( IdTDcomp, IdM , _comprobante.IdInstanciaCaja);
						if (totalPorTDComp < total) //dvm.MontoCotizado)
						{
							_errores.Add( new ItemDatasetError( this.GetProcessManagerParent().Process.ProcessName,"Valor","El importe ingresado en "+ Comp + " "+ Mon + " supera el saldo disponible." +
								"El Monto actual en la caja es de " + totalPorTDComp));
							isvalid = false;
						}
					}
							
						
				}

			}
			if (!IsValidProveedor)
			{
				ItemDatasetError error = new ItemDatasetError("Proveedor","Proveedor Seleccionado","El Proveedor seleccionado no puede ser nulo");
				_errores.Add( error );
				isvalid = false;
			}
			if (!IsValidResponsable)
			{
				ItemDatasetError error = new ItemDatasetError("Responsable","Responsable de Emision","El responsable de emisión no puede ser nulo");
				_errores.Add( error );
				isvalid = false;
			}
			if (!IsValidInstanciaDeCaja)
			{
				string _errorCaja = string.Empty;
				string msj = _errorCaja.Equals(string.Empty)? "Debe seleccionar una caja abierta en donde imputar el pago" : _errorCaja;
				ItemDatasetError error = new ItemDatasetError("Caja","Instancia de Caja",msj);
				_errores.Add( error );
				isvalid = false;
			}
			if(!IsValidMonto)
			{
				ItemDatasetError error = new ItemDatasetError("Total","Total","El Total del comprobante debe ser mayor que 0");
				_errores.Add( error );
				isvalid = false;				
			}
			if(!IsValidMontoConImputacion)
			{
				ItemDatasetError error = new ItemDatasetError("Total","Total","El Total del comprobante debe ser mayor o igual que el monto imputado a el/los comprobante/s a imputar");
				_errores.Add( error );
				isvalid = false;				
			}
			if (!this.IsValidNumeration)
			{
				isvalid = false;
				_errores.Add( new ItemDatasetError( "Comprobante","Numeración","La numeración del comprobante no es válida o ya existe"));
			}
			/*
			if(_validarValoresExistentes)
			{
				foreach(Valor valor in this.Valores.MisValores)
				{
					if (!valor.Agrupado && ((valor.IdInstanciaCaja != _idInstanciaCaja && valor.State.ToUpper().Equals("EDIT"))|| valor.State.ToUpper().Equals("NEW")))
					{
						string message = "El valor " + valor.Comprobante + " Nro " + valor.Numero + " No pertenece a la caja de la cual se desea hacer el egreso. Debe transferirlo.";
						_errores.Add( new ItemDatasetError( this._processParent.Process.ProcessName,"Valor",message));	
						isvalid = false;	
					}
				}
			}
			if(_validarSignoValoresExistentes)
			{
				int signo = int.MinValue;
				DataRow rowTC = mz.erp.businessrules.tsy_TiposDeComprobantes.GetByPk(this._tipoComprobanteDestino);
				if(rowTC != null)
					signo = Convert.ToInt32(rowTC["Signo"]);
				foreach(Valor valor in this.Valores.MisValores)
				{
					if (!valor.Agrupado && valor.State.ToUpper().Equals("EDIT") && valor.Signo.Equals(signo))
					{
						string message = "El valor " + valor.Comprobante + " Nro " + valor.Numero + " No puede usarse en este tipo de comprobante";
						_errores.Add( new ItemDatasetError( this._processParent.Process.ProcessName,"Valor",message));	
						isvalid = false;	
					}
				}
			}
			*/

			if (!this._comprobante.IsValidRetencionesAplicadas)
			{
				isvalid = false;
				_errores.Add( new ItemDatasetError( "Retenciones","Retenciones","Se deben recalcular las retenciones"));
			}
			//German 20091120
			if(!this._comprobante.IsValidCajaAbierta())
			{
				_errores.Add( new ItemDatasetError("Caja","Caja","La Caja seleccionada para este proceso ha sido cerrada. Debe reiniciar el proceso."));						
				isvalid = false;
			}
			//Fin German 20091120

			return isvalid;
		}

		public  bool AllowShow() 
		{
			return  _visualizaVentana; // Default = true;
		}
		public void FormHasClosed() 
		{
		}

		public ItemsDatasetErrors GetErrors()
		{
			return _errores;			
		}

		public  string GetWarnings()
		{
			return null;			
		}

		public ProcessManager GetProcessManagerParent()
		{
			return _processParent;
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_processParent = processManager;
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

		public  void Previous()
		{
			
		}

		public  void ListenerAfterPreviousDependentTask(object sender)
		{
			
		}

		public  void ListenerBeforePreviousDependentTask(object sender)
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
			return data;;
		}

		public void Commit()
		{
			_comprobante.Commit();
		}

		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());
			SentenciasReplicacion _replicacion = GetSentenceReplication();
			_comprobante.Flush(IdTransaction, _replicacion, _actualizaNumeracion);
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());	
		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
			foreach( TaskCollectionData taskData in _processCollectionData)
			{
				if ( taskData.TaskName.Equals("IngresarComprobanteDeCompraCabecera") )
				{
					foreach ( DataSet data in taskData )
					{
						foreach ( System.Data.DataTable table in data.Tables )
						{
							if ( table.TableName.Equals("tpu_Comprobantes") )
							{
								if (table.Rows.Count>0)
								{
									string idComprobante = Convert.ToString(table.Rows[0]["IdComprobante"]);
									string idTipoComprobante = Convert.ToString(table.Rows[0]["IdTipoDeComprobante"]);
									_comprobante.UpdateComprobanteDestino(idComprobante, idTipoComprobante);
								}
							}
						}
					}
				}
			}
		}

		public SentenciasReplicacion GetSentenceReplication()
		{
			mz.erp.commontypes.SentenciasReplicacion replication = new mz.erp.commontypes.SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tpu_comprobantes";			
			return replication;
		}

		public bool GetHasSaved()
		{
			return false;
		}

		#endregion

		
	}
}

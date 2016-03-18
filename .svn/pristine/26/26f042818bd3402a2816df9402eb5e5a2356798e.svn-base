using System;
using System.Data;
using System.Collections;
using mz.erp.systemframework;
using System.Data.SqlClient;
using mz.erp.dataaccess;
using mz.erp.commontypes;
using mz.erp.commontypes.data;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de TransferenciasValoresCaja.
	/// </summary>
	public class TransferenciasValoresCaja: ITask, IPersistentTask
	{
		public TransferenciasValoresCaja()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;
		public event System.EventHandler OnTaskAfterPrevious;

		public void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			this.AllowPrevious();
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public bool AllowPrevious()
		{
			return true;
		}
		public void ListenerAfterPreviousDependentTask( object sender )
		{
		}
		public void ListenerBeforePreviousDependentTask( object sender )
		{
		}
			
		public void ListenerTaskDependentChanged(object sender)
		{		
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
			/*if (sender.GetType() == typeof(mz.erp.businessrules.comprobantes.ComprobanteDeVenta))
			{
				ComprobanteDeVenta _comprobante = (ComprobanteDeVenta)sender;
				LoadDataFromComprobanteDeVenta( _comprobante );
			}*/
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
		}

		public void Init()
		{			
			_cajasOrigenDisponibles = tfi_Cajas.GetInstanciaAbiertaDeCaja(Security.IdPersona);//Devolver todas las cajas abiertas según Security.IdPersona
			_cajasDestinoDisponibles = tfi_Cajas.GetInstanciaAbiertaDeCaja();
			_agrupaValores = Variables.GetValueBoolWithoutCache("Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "AgrupaValores");
			string TipoMovO = Variables.GetValueString("Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TipoDeMovimientoOrigen");
			if (TipoMovO != null) 
			{
				_idTipoDeMovimientoDeCajaOrigen = TipoMovO;
			}
			string TipoMovD = Variables.GetValueString("Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TipoDeMovimientoDestino");
			if (TipoMovD != null) 
			{
				_idTipoDeMovimientoDeCajaDestino = TipoMovD;
			}
		}

		public bool IsValid()
		{
			bool IsValid = true;
			_errores.Clear();
			
			foreach (DetalleValorMovimiento valor in this._valoresATransferir)  
			{
				if (valor.ValorDestino > valor.ValorOrigen) 
				{
					IsValid = true;	
					_errores.Add( new ItemDatasetError( this._processParent.Process.ProcessName,"Valor","Ha ocurrido un error en el ingreso manual de valores."));
				}
				if (valor.ValorOrigen != valor.ValorDestino && !valor.Agrupado) 
				{
					IsValid = true;	
					_errores.Add( new ItemDatasetError( this._processParent.Process.ProcessName,"Valor","Ha ocurrido un error en el ingreso manual de valores."));
				}
			}
			if (this._valoresATransferir.Count == 0) 
			{
				IsValid = true;	
				_errores.Add( new ItemDatasetError( this._processParent.Process.ProcessName,"Valores","No hay valores seleccionados para transferir."));
			}
			if (this._idInstanciaDeCajaOrigen == this._idInstanciaDeCajaDestino) 
			{
				IsValid = true;	
				_errores.Add( new ItemDatasetError( this._processParent.Process.ProcessName,"Cajas","Las instancias de caja deben ser distintas."));
			}
			return IsValid;
		}
		public bool AllowShow() 
		{
			return true;
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


		#endregion

		#region Miembros de IPersistentTask
		public event System.EventHandler OnTaskBeforeFlush;
		public event System.EventHandler OnTaskAfterFlush;

		public void Commit() 
		{						
			BeforeCommit();

			
			//COMMIT DE MOVIMIENTOS DE ORIGEN		
			dataMovimientosO = new mz.erp.commontypes.data.tfi_MovimientosDeCajaDataset();
			dataPagosMovimientosO = new tfi_PagosMovimientosCajasDataset();

			tfi_MovimientosDeCajaDataset.tfi_MovimientosDeCajaRow rowMO = dataMovimientosO.tfi_MovimientosDeCaja.Newtfi_MovimientosDeCajaRow();
			rowMO = tfi_MovimientosDeCaja.SetRowDefaultValues(rowMO);

			rowMO.IdInstanciaCaja = this._idInstanciaDeCajaOrigen;
			rowMO.IdTipoDeMovimiento = this._idTipoDeMovimientoDeCajaOrigen;			
			rowMO.IdResponsable = Security.IdUsuario;		
			
			string cajaDestino = Convert.ToString(tfi_Cajas.GetByPk(Convert.ToString((tfi_InstanciasCaja.GetByPk(_idInstanciaDeCajaDestino))["idCaja"]))["Descripcion"]);
			rowMO.Observaciones = this._observaciones + "Egreso hacia la caja: " + cajaDestino +" a cargo de: "+ _responsableCajaDestino; 
			decimal Total = 0;
			tsy_TiposMovimientosDataset.tsy_TiposMovimientosRow tp = tsy_TiposMovimientos.GetByPk(this._idTipoDeMovimientoDeCajaOrigen);	
			int Signo = tp.signo;			
			
			foreach (DetalleValorMovimiento valorATransferir in this._valoresATransferir) 
			{					
					tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasRow rowP = dataPagosMovimientosO.tfi_PagosMovimientosCajas.Newtfi_PagosMovimientosCajasRow();
					rowP = tfi_PagosMovimientosCajas.SetRowDefaultValues(rowP);				

					rowP.IdValor = valorATransferir.IdValor;

					rowP.IdInstanciaCaja = this._idInstanciaDeCajaOrigen;
					rowP.IdTipoDeMovimiento = this._idTipoDeMovimientoDeCajaOrigen;
					rowP.Numero = valorATransferir.Numero;				
					dataPagosMovimientosO.tfi_PagosMovimientosCajas.Addtfi_PagosMovimientosCajasRow(rowP);
				
					Total = Total + valorATransferir.ValorDestino;				
			}			
			rowMO.Total =  Signo * Total;
			dataMovimientosO.tfi_MovimientosDeCaja.Addtfi_MovimientosDeCajaRow(rowMO);
			
			//COMMIT DE MOVIMIENTOS DE DESTINO	
			dataMovimientosD = new mz.erp.commontypes.data.tfi_MovimientosDeCajaDataset();
			dataPagosMovimientosD = new tfi_PagosMovimientosCajasDataset();

			tfi_MovimientosDeCajaDataset.tfi_MovimientosDeCajaRow rowMD = dataMovimientosD.tfi_MovimientosDeCaja.Newtfi_MovimientosDeCajaRow();
			rowMD = tfi_MovimientosDeCaja.SetRowDefaultValues(rowMD);
			
			string cajaOrigen = Convert.ToString(tfi_Cajas.GetByPk(Convert.ToString((tfi_InstanciasCaja.GetByPk(_idInstanciaDeCajaOrigen))["idCaja"]))["Descripcion"]);
			rowMD.IdInstanciaCaja = this._idInstanciaDeCajaDestino;
			rowMD.IdTipoDeMovimiento = this._idTipoDeMovimientoDeCajaDestino;			
			rowMD.IdResponsable = Security.IdUsuario;			
			rowMD.Observaciones = this._observaciones+ "Ingreso desde la caja: " + cajaOrigen +" a cargo de: " + _responsableCajaOrigen;
			Total = 0;
			tp = tsy_TiposMovimientos.GetByPk(this._idTipoDeMovimientoDeCajaDestino);	
			Signo = tp.signo;			
			
			foreach (DetalleValorMovimiento valorATransferir in this._valoresATransferir) 
			{	
					tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasRow rowP = dataPagosMovimientosD.tfi_PagosMovimientosCajas.Newtfi_PagosMovimientosCajasRow();
					rowP = tfi_PagosMovimientosCajas.SetRowDefaultValues(rowP);							
					

					rowP.IdValor = valorATransferir.IdValor;
	
					rowP.IdInstanciaCaja = this._idInstanciaDeCajaDestino;
					rowP.IdTipoDeMovimiento = this._idTipoDeMovimientoDeCajaDestino;
					rowP.Numero = valorATransferir.Numero;				
					dataPagosMovimientosD.tfi_PagosMovimientosCajas.Addtfi_PagosMovimientosCajasRow(rowP);
	
					Total = Total + valorATransferir.ValorDestino;
			}			
			rowMD.Total =  Signo * Total;
			dataMovimientosD.tfi_MovimientosDeCaja.Addtfi_MovimientosDeCajaRow(rowMD);

		}

		private mz.erp.commontypes.SentenciasReplicacion _replication;
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
			replication.NombreTabla = "dataaccess.tfi_movimientosdecaja";
			return replication;
		}

		private bool _hasSaved = false;
		public bool GetHasSaved()
		{
			return _hasSaved;
		}
			 
		public void PutExtraData( ProcessCollectionData _processCollectionData )
		{
			foreach( TaskCollectionData _collectionTask in _processCollectionData)
			{
				#region Aceptacion
				if (_collectionTask.TaskName.Equals("Aceptacion")) 
				{
					string idAceptacion = null;
					//obtengo el idaceptacion real
					foreach (System.Data.DataSet dataAceptacion in _collectionTask )
					{
						idAceptacion = Convert.ToString(dataAceptacion.Tables["tsh_Aceptacion"].Rows[0]["IdAceptacion"]);
					}
					//guardo el id aceptacion para el movimiento origen
					foreach (System.Data.DataRow row in  this.dataMovimientosO.tfi_MovimientosDeCaja.Rows)
					{
						row["IdAceptacion"]= idAceptacion;
						//row.AcceptChanges();
					}
					//guardo el id de acepptacion para el movimiento destino
					foreach (System.Data.DataRow row in  this.dataMovimientosD.tfi_MovimientosDeCaja.Rows)
					{
						row["IdAceptacion"]= idAceptacion;
						//row.AcceptChanges();
					}
				}
				#endregion
			}
		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			
		}

		public ArrayList GetDataList()
		{
			ArrayList array = new ArrayList();
			//array.Add( (DataSet) this.DatasetComprobante);
			return array;
		}
		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();
			//data.Add( this.DatasetComprobante );
			return data;
		}

		/// <summary>
		/// Envia el dataset e información adicional a la capa de acceso a datos para ejecutar la grabación de datos
		/// en el RDBM.
		/// </summary>
		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());

			_replication = GenerateReplication();
			//SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);

			
			tfi_MovimientosDeCaja.Update(dataMovimientosO, IdTransaction, _replication);
			tfi_MovimientosDeCaja.Update(dataMovimientosD, IdTransaction, _replication);
			

			_IdMovimientoOrigen = Convert.ToString(dataMovimientosO.tfi_MovimientosDeCaja.Rows[0]["IdMovimiento"]);
			foreach (DataRow row in dataPagosMovimientosO.tfi_PagosMovimientosCajas.Rows) 
			{
				row["IdMovimiento"] = _IdMovimientoOrigen;
			}
			_IdMovimientoDestino = Convert.ToString(dataMovimientosD.tfi_MovimientosDeCaja.Rows[0]["IdMovimiento"]);
			foreach (DataRow row in dataPagosMovimientosD.tfi_PagosMovimientosCajas.Rows) 
			{
				row["IdMovimiento"] = _IdMovimientoDestino;
			}

			mz.erp.dataaccess.tfi_PagosMovimientosCajas.Update(dataPagosMovimientosO.Tables[0], IdTransaction, _replication);			
			mz.erp.dataaccess.tfi_PagosMovimientosCajas.Update(dataPagosMovimientosD.Tables[0], IdTransaction, _replication);

			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}
		
		#endregion
		
		#region Clases auxiliares

		public class ValoresVariablesAuxiliares: ArrayList 
		{
			public ValoresVariablesAuxiliares() 
			{
			}
			public int Add( string IdValor, string DescripcionVariable, string Valor)
			{
				return base.Add(new object[] {IdValor, DescripcionVariable, Valor});				
			}

		}
		public class DetalleValorMovimiento 
		{
			private string _idValor;
			public string IdValor 
			{
				get {return _idValor;}
				set {_idValor = value;}
			}
			private string _idTDCompTesoreria;
			public string IdTDCompTesoreria
			{
				get {return _idTDCompTesoreria;}
				set {_idTDCompTesoreria = value;}
			}
			private string _descripcion;
			public string Descripcion
			{
				get {return _descripcion;}
				set {_descripcion = value;}
			}
			private string _numero;
			public string Numero
			{
				get {return _numero;}
				set {_numero = value;}
			}
			private string _entidad;
			public string Entidad
			{
				get {return _entidad;}
				set {_entidad = value;}
			}
			private DateTime _fechaVencimiento;
			public DateTime FechaVencimiento
			{
				get {return _fechaVencimiento;}
				set {_fechaVencimiento = value;}
			}
			private decimal _valorOrigen;
			public decimal ValorOrigen
			{
				get {return _valorOrigen;}
				set {_valorOrigen = value;}
			}
			private decimal _valorDestino;
			public decimal ValorDestino
			{
				get {return _valorDestino;}
				set {_valorDestino = value;}
			}
			private string _moneda;
			public string Moneda
			{
				get {return _moneda;}
				set {_moneda = value;}
			}
			private string _idMoneda;
			public string IdMoneda
			{
				get {return _idMoneda;}
				set {_idMoneda = value;}
			}
			private string _idCotizacionMoneda;
			public string IdCotizacionMoneda
			{
				get {return _idCotizacionMoneda;}
				set {_idCotizacionMoneda = value;}
			}

			private bool _agrupado = false;
			public bool Agrupado
			{
				get {return _agrupado;}
				set {_agrupado = value;}
			}
			private bool _enabled = false;
			public bool Enabled
			{
				get {return _enabled;}
				set {_enabled = value;}
			}
			private bool _editableValorDestino = false;
			public bool EditableValorDestino
			{
				get {return _editableValorDestino;}
				set {_editableValorDestino = value;}
			}

			public DetalleValorMovimiento ShallowClone()
			{
				return (DetalleValorMovimiento)this.MemberwiseClone();
			}


			public ValoresVariablesAuxiliares VariablesAuxiliares;

			public DetalleValorMovimiento()
			{
			}
		}

		public class DetallesValoresMovimientos: ArrayList, IEnumerator
		{
			public int Add(DetalleValorMovimiento item) 
			{
				return base.Add(item);
			}
			public override int Add(Object item) 
			{
				return base.Add((DetalleValorMovimiento) item);
			}
			public int IndexOf(string IdValor)
			{
				this.Reset();
				foreach (DetalleValorMovimiento item in this) 
				{
					this.MoveNext();					
					//if (item.IdValor.CompareTo(IdValor) != 0) 
					if (item.IdValor.Equals(IdValor))
					{
						return  _index;
					}
				}
				return -1;
			}			
			#region miembros de IEnumerable
			private int _index = -1;
			public void Reset() 
			{
				_index = -1;
			}
			public object Current 
			{
				get {return base[_index];}
			}
			public bool MoveNext() 
			{
				_index ++;
				return _index < this.Count;
			}
			#endregion
		}
			
	
		#endregion

		#region Variables privadas	
		private string _idInstanciaDeCajaOrigen = "";
		private string _idInstanciaDeCajaDestino = "";
		private string _responsableCajaOrigen;
		private string _responsableCajaDestino;		
		//private decimal _totalATransferir = 0;
		private string _idTipoDeMovimientoDeCajaOrigen = Constantes.IdTipoDeMovimientoOrigen;
		private string _idTipoDeMovimientoDeCajaDestino = Constantes.IdTipoDeMovimientoDestino;
		private bool _editing = false;
		private tfi_MovimientosDeCajaDataset dataMovimientosO = null;
		private tfi_PagosMovimientosCajasDataset dataPagosMovimientosO = null;
		private tfi_MovimientosDeCajaDataset dataMovimientosD = null;
		private tfi_PagosMovimientosCajasDataset dataPagosMovimientosD = null;

		private string _taskName = string.Empty;
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;
	
		#endregion

		#region Métodos privados

		private void RefreshDataDestino() 
		{						
			_responsableCajaDestino = tfi_InstanciasCaja.GetResponsableXInstanciaDeCaja(_idInstanciaDeCajaDestino);	
			this._valoresATransferir.Clear();
		}
		
		private void SearchValoresDisponibles() 
		{
			this._valoresDisponibles.Clear();
			this._valores.Clear();
			_responsableCajaOrigen = tfi_InstanciasCaja.GetResponsableXInstanciaDeCaja(_idInstanciaDeCajaOrigen);	
			DataTable table = tfi_InstanciasCaja.GetListXInstancia(_idInstanciaDeCajaOrigen);
			foreach(DataRow row in table.Rows) 
			{
				DetalleValorMovimiento vm = new DetalleValorMovimiento();
				vm.IdValor = row["IdValor"].ToString();
				vm.ValorOrigen = Convert.ToDecimal(row["Valor"]);
				vm.ValorDestino = Convert.ToDecimal(row["Valor"]);
				vm.IdTDCompTesoreria = row["IdTDCompTesoreria"].ToString();
				vm.Agrupado = Convert.ToBoolean(row["Agrupado"]);
				vm.Descripcion = row["Descripcion"].ToString();
				vm.Numero = row["Numero"].ToString();
				vm.FechaVencimiento = Convert.ToDateTime(row["FechaVencimiento"]);
				vm.Entidad = row["Entidad"].ToString();
				vm.Moneda = row["Moneda"].ToString();
				vm.IdMoneda = row["IdMoneda"].ToString();
				vm.IdCotizacionMoneda = row["IdCotizacionMoneda"].ToString();								
					
				if (_agrupaValores) 
				{
					if (vm.Agrupado == true)  
					{
						DetalleValorMovimiento vmDisp = GetValorDisponible(vm.Moneda, vm.IdTDCompTesoreria);
						if (vmDisp == null) //Significa que es el primer valor agrupado disponible
						{
							this._valoresDisponibles.Add(vm);
						}
						else 
						{					
							ArrayList ar = Util.Parse(vmDisp.IdValor,",");
							if (! ar.Contains(vm.IdValor)) 
							{
								vmDisp.ValorOrigen = vmDisp.ValorOrigen + vm.ValorOrigen;
								vmDisp.ValorDestino = vmDisp.ValorOrigen;
								vmDisp.IdValor = vmDisp.IdValor + "," + vm.IdValor;
							}					
						}
					}
					else 
					{
						this._valoresDisponibles.Add(vm);
					}
				}
				else 
				{
					this._valoresDisponibles.Add(vm);
				}				
				//this._valores.Add(vm.ShallowClone()); //En este objeto nunca agrupo tengo todos los valores (para sacar los totales individuales) cuando haga commit
			}
		}

		private void BeforeCommit() 
		{
			//Recorre los valores a tranferrir
			string IdValorNuevo;
			foreach (DetalleValorMovimiento valorATransferir in this._valoresATransferir) 
			{
				if (valorATransferir.IdValor == null || valorATransferir.IdValor == String.Empty) 
				{
					tfi_ValoresDataset data = new tfi_ValoresDataset();
					tfi_ValoresDataset.tfi_ValoresRow row = data.tfi_Valores.Newtfi_ValoresRow();
					row = tfi_Valores.SetRowDefaultValues(row);
					row.IdTDCompTesoreria = valorATransferir.IdTDCompTesoreria;
					row.Valor = valorATransferir.ValorDestino;
					row.IdMoneda = valorATransferir.IdMoneda;
					row.IdCotizacionMoneda = valorATransferir.IdCotizacionMoneda;
					
					data.tfi_Valores.Addtfi_ValoresRow(row);
					tfi_Valores.Update(data);
					IdValorNuevo = Convert.ToString(data.tfi_Valores.Rows[0]["IdValor"]);
					//tfi_Valores.Update(rowValor);
					//IdValorNuevo = rowValor.IdValor;
					valorATransferir.IdValor = IdValorNuevo;
				}			
			}					
		}

		private decimal GetTotalATransferir()
		{
			decimal Total = 0;
			foreach (DetalleValorMovimiento valor in this._valoresATransferir) 
			{
				Total = Total + valor.ValorDestino;
			}
			return Total;
		}

		public void RefreshDataOrigen() 
		{
			if (_idInstanciaDeCajaOrigen != null && _idInstanciaDeCajaOrigen != String.Empty) 
			{
				SearchValoresDisponibles();
				this._valoresATransferir.Clear();
			}
		}

		public void Transferir(ArrayList array) 
		{
			_editing = true;
			int CantValoresATransferir = array.Count;
			foreach (string IdValor in array) 
			{
				int index = _valoresDisponibles.IndexOf(IdValor);
				Transferir(index);
			}
			
			
			_editing = false;
			if (CantValoresATransferir > 0) 
			{				
				if (this.OnObjectHasChanged != null && !_editing)
					OnObjectHasChanged(this, new System.EventArgs());
			}	
		}

		public void Transferir(int[] indice) 
		{
			_editing = true;
			int CantValoresATransferir = indice.Length;
			for (int index = 0; index < indice.Length; index++) 
			{
				Transferir(index);
			}
			_editing = false;
			if (CantValoresATransferir > 0) 
			{				
				if (this.OnObjectHasChanged != null && !_editing)
					OnObjectHasChanged(this, new System.EventArgs());
			}	
		}
		public void TransferirTodo() 
		{
			_editing = true;
			int CantValoresATransferir = _valoresDisponibles.Count;
			for (int index = 0; index < CantValoresATransferir; index++) 
			{
				Transferir(index);
			}
			_editing = false;
			if (CantValoresATransferir > 0) 
			{
				if (this.OnObjectHasChanged != null && !_editing)
					OnObjectHasChanged(this, new System.EventArgs());
			}			
		}
		public void Transferir(int indexOrigen) 
		{
			DetalleValorMovimiento vm = (DetalleValorMovimiento) _valoresDisponibles[indexOrigen];			
			
			if (this._valoresATransferir.IndexOf(vm.IdValor) == -1)
			{							
				if (vm.ValorOrigen != vm.ValorDestino && !vm.Agrupado) 
				{
					vm.ValorDestino = vm.ValorOrigen;
				}
				vm.Enabled = false;	
				this._valoresATransferir.Add( vm );
			}			
		}

		private DetalleValorMovimiento GetValorDisponible(string Moneda, string IdTDCompTesoreria) 
		{
			foreach (DetalleValorMovimiento valor in this._valoresDisponibles)  
			{
				if (valor.Moneda == Moneda && valor.IdTDCompTesoreria == IdTDCompTesoreria) 
				{
					return valor;
				}
			}			
			return null;
		}
		private DetalleValorMovimiento GetValor(string IdValor) 
		{
			foreach (DetalleValorMovimiento valor in this._valores)  
			{
				if (valor.IdValor == IdValor) 
				{
					return valor;
				}
			}			
			return null;
		}


		public void Remover(ArrayList array) 
		{
			_editing = true;
			int CantValoresARemover = array.Count;
			foreach (string IdValor in array) 
			{
				int index = _valoresATransferir.IndexOf(IdValor);
				Remover(index);
			}
			_editing = false;
			if (CantValoresARemover > 0) 
			{
				if (this.OnObjectHasChanged != null && !_editing)
					OnObjectHasChanged(this, new System.EventArgs());
			}	
		}
		public void Remover(int[] indice) 
		{			
			_editing = true;
			int CantValoresATransferir = indice.Length;
			for (int index = 0; index < indice.Length; index++) 				
			{ 
				Remover(index);
			}
			_editing = false;
			if (CantValoresATransferir > 0) 
			{
				if (this.OnObjectHasChanged != null && !_editing)
					OnObjectHasChanged(this, new System.EventArgs());
			}			
		}

		public void RemoverTodo() 
		{
			int CantValoresATransferir = _valoresATransferir.Count;
			_valoresATransferir.Clear();			
			if (CantValoresATransferir > 0) 
			{
				if (this.OnObjectHasChanged != null )
					OnObjectHasChanged(this, new System.EventArgs());
			}
		}
		public void Remover(int indexdestino) 
		{
			if (indexdestino >= 0 && indexdestino < this._valoresATransferir.Count) 
			{
				this._valoresATransferir.RemoveAt(indexdestino);
				if (this.OnObjectHasChanged != null && !_editing)
					OnObjectHasChanged(this, new System.EventArgs());													
			}
		}

		#endregion

		#region Propiedades públicas
		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonAnterior";
				valor = Variables.GetValueString(variable);
				
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
		private string _textoBotonSiguiente = "Siguiente";
		public string TextoBotonSiguiente
		{
			get 
			{		
				string valor = String.Empty;				
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonSiguiente";
				valor = Variables.GetValueString(variable);
				
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

		bool _agrupaValores = true;

		private DateTime _fechaEmision;
		public DateTime FechaEmision
		{
			get {return _fechaEmision;}
			set {_fechaEmision = value;}				
		}
		private DateTime _fechaAceptacion;
		public DateTime FechaAceptacion
		{
			get {return _fechaAceptacion;}
			set {_fechaAceptacion = value;}				
		}
		private string _observaciones;
		public string Observaciones 
		{
			get {return _observaciones;}
			set {_observaciones = value;}				
		}

		private DetallesValoresMovimientos _valores = new DetallesValoresMovimientos();
		private DetallesValoresMovimientos _valoresDisponibles = new DetallesValoresMovimientos();
		public ArrayList ValoresDisponibles 
		{
			get {return (ArrayList) _valoresDisponibles;}
		}
		private DetallesValoresMovimientos _valoresATransferir = new DetallesValoresMovimientos();
		public ArrayList ValoresATransferir 
		{
			get {return (ArrayList) _valoresATransferir;}
		}

		private Hashtable _cajasOrigenDisponibles = null;
		public Hashtable CajasOrigenDisponibles 
		{
			get {return (Hashtable) _cajasOrigenDisponibles;}
		}
		private Hashtable _cajasDestinoDisponibles = null;
		public Hashtable CajasDestinoDisponibles 
		{
			get {return (Hashtable) _cajasDestinoDisponibles;}
		}

		public string KeyValueCajaOrigen 
		{
			get 
			{
				return _idInstanciaDeCajaOrigen;
			}
			set 
			{
				if (!_idInstanciaDeCajaOrigen.Equals(value))
				{
					_idInstanciaDeCajaOrigen = value;
					RefreshDataOrigen();
					if (this.OnObjectHasChanged != null)
						OnObjectHasChanged(this, new System.EventArgs());
				}
			}
		}
		public string KeyValueCajaDestino
		{
			get 
			{
				return _idInstanciaDeCajaDestino;
			}
			set 
			{
				if (!_idInstanciaDeCajaDestino.Equals(value))
				{
					_idInstanciaDeCajaDestino = value;
					RefreshDataDestino();					
					if (this.OnObjectHasChanged != null)
						OnObjectHasChanged(this, new System.EventArgs());
				}
			}
		}
		public string ResponsableCajaOrigen
		{
			get 
			{
				return _responsableCajaOrigen;
			}
			set 
			{
				if (_responsableCajaOrigen.CompareTo(value) != 0 )
				{
					_responsableCajaOrigen = value;

					if (this.OnObjectHasChanged != null)
						OnObjectHasChanged(this, new System.EventArgs());
				}
			}
		}

		public string ResponsableCajaDestino
		{
			get 
			{
				return _responsableCajaDestino;
			}
			set 
			{
				if (_responsableCajaDestino.CompareTo(value) != 0 )
				{
					_responsableCajaDestino = value;

					if (this.OnObjectHasChanged != null)
						OnObjectHasChanged(this, new System.EventArgs());
				}
			}
		}

		public decimal TotalATransferir
		{
			get 
			{
				return GetTotalATransferir();
			}
		}
		

		public int SelectedIndexValoresDisponibles
		{
			/*get 
			{
				return _responsableCajaDestino;
			}*/
			set 
			{
				Transferir(value);				
			}
		}

		public int SelectedIndexValoresATransferir
		{
			/*get 
			{
				return _responsableCajaDestino;
			}*/
			set 
			{
				Transferir(value);				
			}
		}


		private string _IdMovimientoOrigen = String.Empty;
		public string IdMovimientoOrigen
		{
			get 
			{
				return _IdMovimientoOrigen;
			}
		}		

		private string _IdMovimientoDestino = String.Empty;
		public string IdMovimientoDestino
		{
			get 
			{
				return _IdMovimientoDestino;
			}
		}		

		#endregion

		#region Eventos y delegados
		public event System.EventHandler OnObjectHasChanged;
		#endregion
	}
}

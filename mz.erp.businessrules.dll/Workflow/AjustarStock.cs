using System;
using System.Collections;
using System.Data;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.businessrules.comprobantes;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de AjustarStock.
	/// </summary>
	
	#region Clase ItemAjuste
	public class ItemAjuste
	{			
		
		
		#region Constructores
		
		public ItemAjuste() 
		{
		}

		#endregion

		#region Variables Privadas
			string _idProducto = String.Empty;
			string _descripcion = String.Empty;
			string _codigo = String.Empty;
			string _codigoSecundario = String.Empty;		
			decimal _cantidad = 0;
			decimal _cantidadPendiente = 0;
			decimal _cantidadPedida = 0;
			decimal _cantidadReservada = 0;
			decimal _stockDisponible = 0;

		#endregion

		#region Propiedades

		public decimal CantidadReservada
		{
			get{return _cantidadReservada;}
			set{_cantidadReservada = value;}
		}


		public decimal StockDisponible
		{
			get{return _stockDisponible;}
			set{_stockDisponible = value;}
		}
		
		public string IdProducto
		{
			get 
			{
				return _idProducto;
			}
			set 		
			{
				_idProducto = value;
			}
		}

		
		public string Descripcion
		{
			get 
			{
				return _descripcion;
			}
			set 		
			{
				_descripcion = value;
			}
		}

		
		public string Codigo
		{
			get 
			{
				return _codigo;
			}
			set 		
			{
				_codigo = value;
			}
		}

		public string CodigoSecundario
		{
			get 
			{
				return _codigoSecundario;
			}
			set 		
			{
				_codigoSecundario = value;
			}
		}	
		public decimal Cantidad 
		{
			get 
			{
				return _cantidad;
			}
			set 
			{
				_cantidad = value;
			}
		}

		
		public decimal CantidadPendiente
		{
			get{return _cantidadPendiente;}
			set{_cantidadPendiente = value;}
		}

		
		public decimal CantidadPedida
		{
			get{return _cantidadPedida;}
			set{_cantidadPedida = value;}
		}

		#endregion
	}

	#endregion
	
	public class AjustarStock : IPersistentTask, ITask
		//DefaultTask, 
	{		
		
		#region Variables Privadas

		private DataTable _listaTipoDeAjuste = businessrules.tlg_TiposDeAjuste.GetList().tlg_TiposDeAjuste;
		private DataTable _listaDeposito = (DataTable) businessrules.tlg_Depositos.GetList(null,null,null, true).tlg_Depositos;
		private DataTable _listaSeccion = (DataTable) businessrules.tlg_Secciones.GetList(null, null, null, true).tlg_Secciones;	
		private DataSet _data = new mz.erp.commontypes.data.tlg_MovimientosDeStockDataset();
		private tlg_MovimientosDeStockAjustesDatosAuxiliaresDataset.tlg_MovimientosDeStockAjustesDatosAuxiliaresRow rowAjusteDA;
		private tlg_MovimientosDeStockAjustesDatosAuxiliaresDataset dataAjustesDA;	
		private string IdMovimientoDeStockAjustesDatosAuxiliares = "";
		
		private string _view = string.Empty; //"Sistema = false";
		private int _widthSearchForm = Convert.ToInt16(Variables.GetValue("Productos.Busquedas.Ancho"));

		private bool _allowEditAjusteDeStock = true;
		private bool _allowAddItems = true;
		private bool _allowEditItems = true;
		private bool _allowEditDeposito = true;
		private bool _allowEditSeccion = true;
		private bool _allowShow = true;
		private string _idEstadoDeStock = string.Empty;
		private string _estadoDeStock = string.Empty;
		private string _idTipoDeAjuste = string.Empty;
		private string _observaciones = string.Empty;
		private string _idDeposito = string.Empty;
		private string _idSeccion = string.Empty;
		private string _idDepositoDefault = string.Empty;
		private string _idSeccionDefault = string.Empty;
		private ArrayList _items;
		private DataRow _row = null;
		private string _textoBotonAnterior = "Anterior";
		private string _textoBotonSiguiente = "Siguiente";
		private string _signo = string.Empty;
		private string _ordenReparacion = string.Empty;

		#endregion

		#region Eventos
		
			public event EventHandler IdTipoDeAjusteChanged;
		#endregion

		#region Propiedades
		
		public DataTable ListaTipoDeAjuste
		{
			get { return _listaTipoDeAjuste ; }
		}		

		public int WidthSearchForm
		{
			get { return _widthSearchForm ; }			
		}
		
		public bool Contains(string codigo)
		{
			foreach(ItemAjuste item in this._items)
			{
				if(item.Codigo.Equals(codigo))
					return true;
			}
			return false;
		}

		public DataTable ListaDeposito
		{
			get 
			{
				if (_listaDeposito.Rows.Count  > 0) 
				{
					_idDeposito = _listaDeposito.Rows[0]["IdDeposito"].ToString();
				}
				else 
				{
					_idDeposito = string.Empty;
				}
				return _listaDeposito ; 
			}
		}		

		public DataTable ListaSeccion
		{
			get 
			{ 				
				if (_listaSeccion.Rows.Count > 0) 
				{
					_idSeccion = _listaSeccion.Rows[0]["IdSeccion"].ToString();
				}
				else 
				{
					_idSeccion = string.Empty;
				}
				return _listaSeccion ; 
			}
		}		

		
		public string View
		{
			get {return _view;}
		}
		

		public string IdEstadoDeStock
		{
			get{return _idEstadoDeStock;}
		}

		public string EstadoDeStock
		{
			get{return _estadoDeStock;}
		}

		
		public string Observaciones
		{
			get {return _observaciones;}
			set {_observaciones = value;}
		}

		public string IdTipoDeAjuste
		{
			get 
			{	
				return _idTipoDeAjuste; 
			}
			set 
			{ 
				if(_idTipoDeAjuste != value)
				{
					_idTipoDeAjuste = value ; 
					if(_idTipoDeAjuste != null )
					{
						DataRow row = mz.erp.businessrules.tlg_TiposDeAjuste.GetByPk(_idTipoDeAjuste);
						if(row != null)
						{
							_idEstadoDeStock = Convert.ToString(row["IdEstadoDeStock"]);
							if(_idEstadoDeStock != null && !_idEstadoDeStock.Equals(string.Empty))
							{
								row = mz.erp.businessrules.tlg_EstadosDeStock.GetByPk(_idEstadoDeStock);
								if(row != null)
									_estadoDeStock = Convert.ToString(row["Descripcion"]);
								else _estadoDeStock = string.Empty;
							}
							else _estadoDeStock = string.Empty;
							
						}
					}
					else 
					{	
						_idEstadoDeStock = string.Empty;
						_estadoDeStock = string.Empty;
					}
					if(IdTipoDeAjusteChanged != null)
						IdTipoDeAjusteChanged(this, new EventArgs());
				}
			}
		}

		
		public string IdDeposito
		{
			get { return _idDeposito; }
			set { _idDeposito = value ; }
		}

		
		public string IdSeccion
		{
			get { return _idSeccion; }
			set { _idSeccion = value ; }
		}

		
		public ArrayList Items 
		{
			get { return _items;}
			set {_items = value;}
		}

		
		public DataRow Row
		{
			get { return _row;}			
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
		
		public bool PreguntarAlCancelar
		{
			get {
				bool _preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;
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

		public string Signo 
		{
			get{return _signo;}
		}
		
		public string OrdenReparacion 
		{
			get{return _ordenReparacion;}
			set{ _ordenReparacion = value;}
		}



		public bool AllowEditItems
		{
			get{return _allowEditItems;}
		}

		public bool AllowAddItems
		{
			get{return _allowAddItems;}
		}

		public bool AllowEditAjusteDeStock
		{
			get{return _allowEditAjusteDeStock;}
		}

		public bool AllowEditSeccion
		{
			get{return _allowEditSeccion;}
		}

		public bool AllowEditDeposito
		{
			get{return _allowEditDeposito;}
		}

		#endregion

		#region Construtores

		public AjustarStock()
		{
		}

		#endregion
 
		#region Miembros de IPersistentTask

		private  static SentenciasReplicacion  GenerateReplication()
		{
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdEmpresa;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tlg_Stock";
			return replication;
		}

		public event System.EventHandler OnTaskBeforeFlush;

		public event System.EventHandler OnTaskAfterFlush;

		private mz.erp.commontypes.SentenciasReplicacion _replication;

		private bool _hasSaved = false;

		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();
			data.Add( (DataSet) this._data);
			data.Add( (DataSet) this.dataAjustesDA);				
			return data;
		}
	/*	public string GetTaskName()
		{
			return _taskName;
		}
		public void SetTaskName(string taskName)
		{
			_taskName = taskName;
		}
*/

		public void Commit()
		{			
				int operacion;
				string IdEstadoStock;
				mz.erp.commontypes.data.tlg_TiposDeAjusteDataset.tlg_TiposDeAjusteRow rowAjuste = mz.erp.businessrules.tlg_TiposDeAjuste.GetByPk(_idTipoDeAjuste);
				if(rowAjuste != null)
				{					
					operacion = Convert.ToInt32(rowAjuste.Operacion);
					_idEstadoDeStock = rowAjuste.IdEstadoDeStock;
					
					mz.erp.businessrules.GenerarMovimientosDeStock _movimientos = new GenerarMovimientosDeStock( IdDeposito, IdSeccion );
					foreach (mz.erp.businessrules.ItemAjuste _item in this.Items)
					{						
						decimal CantPendiente = _item.Cantidad;
						if(_item.Cantidad != 0 &&_item.CantidadReservada != 0 && this._taskName.Equals("AjustarStockOrigen"))
						{
							string IdAjusteEgresoReserva = Variables.GetValueString(this._processParent.Process.ProcessName,this._taskName, "AjusteEgresoDeReservado");
							mz.erp.commontypes.data.tlg_TiposDeAjusteDataset.tlg_TiposDeAjusteRow rowAjusteAux = mz.erp.businessrules.tlg_TiposDeAjuste.GetByPk(IdAjusteEgresoReserva);
							string IdEstadoDeStockAux = rowAjusteAux.IdEstadoDeStock;
							int operacionAux = Convert.ToInt32(rowAjusteAux.Operacion);
							_movimientos.Add( IdEstadoDeStockAux, rowAjusteAux.IdTipoAjuste ,operacionAux , _item.IdProducto, _item.CantidadReservada);
							CantPendiente = CantPendiente - _item.CantidadReservada;
						}
						if (CantPendiente != 0) 
						{
							_movimientos.Add( _idEstadoDeStock, rowAjuste.IdTipoAjuste ,operacion , _item.IdProducto, CantPendiente);
						}						
					}
			
					mz.erp.commontypes.data.tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockDataTable _table = Stock.GetDataTableStock( _movimientos );		
					_data.Merge(_table);						
					dataAjustesDA = new tlg_MovimientosDeStockAjustesDatosAuxiliaresDataset();
					rowAjusteDA = businessrules.tlg_MovimientosDeStockAjustesDatosAuxiliares.NewRow();				
					rowAjusteDA.Observaciones = _observaciones;
					dataAjustesDA.tlg_MovimientosDeStockAjustesDatosAuxiliares.LoadDataRow(rowAjusteDA.ItemArray,false);					
				}	
		}

		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());
			_replication = GenerateReplication();
			mz.erp.dataaccess.tlg_MovimientosDeStock.Update( this._data,IdTransaction,_replication);														

			if (IdMovimientoDeStockAjustesDatosAuxiliares == "")
			{
				mz.erp.dataaccess.tlg_MovimientosDeStockAjustesDatosAuxiliares.Update(( DataTable) dataAjustesDA.tlg_MovimientosDeStockAjustesDatosAuxiliares, IdTransaction, _replication);
				IdMovimientoDeStockAjustesDatosAuxiliares = dataAjustesDA.tlg_MovimientosDeStockAjustesDatosAuxiliares[0].IdMovimientoDeStockAjustesDatosAuxiliares;
			}				

			//Genera registro en tabla de relación intermedia
			foreach( DataRow row in _data.Tables[0].Rows)
			{
				string IdMovimientoDeStock = Convert.ToString(row["IdMovimientoDeStock"]);

				tlg_MovimientosDeStockAjustesDataset MovStockAjusteDA = new tlg_MovimientosDeStockAjustesDataset();
				tlg_MovimientosDeStockAjustesDataset.tlg_MovimientosDeStockAjustesRow rowAj = businessrules.tlg_MovimientosDeStockAjustes.NewRow();
				rowAj.IdMovimientoDeStockAjustesDatosAuxiliares = IdMovimientoDeStockAjustesDatosAuxiliares;
				rowAj.IdMovimientoDeStock = IdMovimientoDeStock;
				MovStockAjusteDA.tlg_MovimientosDeStockAjustes.LoadDataRow(rowAj.ItemArray,false);													
				mz.erp.dataaccess.tlg_MovimientosDeStockAjustes.Update((DataTable) MovStockAjusteDA.tlg_MovimientosDeStockAjustes, IdTransaction, _replication);				
			}						

			_hasSaved = true;
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
			foreach( TaskCollectionData data in _processCollectionData )
			{			
				if (data.TaskName.Equals("AjustarStockOrigen") )
				{										
					foreach( DataSet dataset in data )
					{
						//dataAjustesDA.tlg_MovimientosDeStockAjustesDatosAuxiliares[0].IdMovimientoDeStockAjustesDatosAuxiliares;
						if (dataset.DataSetName.Equals("tlg_MovimientosDeStockAjustesDatosAuxiliaresDataset"))
						{
							DataTable table = dataset.Tables[0];
							DataRow row = table.Rows[0];
							IdMovimientoDeStockAjustesDatosAuxiliares = (string)row["IdMovimientoDeStockAjustesDatosAuxiliares"];

							//IdMovimientoDeStockAjustesDatosAuxiliares = dataset.tlg_MovimientosDeStockAjustesDatosAuxiliares[0].IdMovimientoDeStockAjustesDatosAuxiliares;
							
							/*foreach( DataRow row2 in this._comprobanteDeVenta.DatasetComprobante.tsa_ComprobantesRelacionOrigenDestino.Rows)
							{
								row2["IdComprobanteOrigen"] = idComprobante;
							}*/
						}
					}
					/*System.Console.WriteLine( idComprobante );*/
				 
				}
			}
		}

		public SentenciasReplicacion GetSentenceReplication()
		{
			return _replication;
		}
	
		public bool GetHasSaved()
		{
			
			return _hasSaved;
		}

		#endregion

		#region Variables Privadas ITask

		protected string _taskName = string.Empty;		
		protected ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		protected ProcessManager _processParent;

		#endregion

		#region Miembros de ITask


		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}

		private bool _isValid = true;
		public bool IsValid() 
		{			
			bool IsValid = true;
			_errores.Clear();
			if(_idTipoDeAjuste == null || _idTipoDeAjuste.Equals(string.Empty))
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Tipo de Ajuste","Tipo de Ajuste","Debe seleccionar el tipo de Ajuste"));
			}
			if (this.Items.Count == 0) 
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Ajuste de stock","Items","No hay ítems seleccionados"));
			}
			if(MustValidateCantidad())
			{
				if(!IsValidCantidad())
				{
					IsValid = false;
					_errores.Add( new ItemDatasetError( "Ajuste de stock","Cantidad","La Cantidad no puede ser mayor a la Cantidad Pendiente"));
				}
			}
			return IsValid;
		}
		
		private bool IsValidCantidad()
		{
			foreach(ItemAjuste item in _items)
			{
				if(item.Cantidad > item.CantidadPendiente)	
					return false;
			}
			return true;
		}

		private bool MustValidateCantidad()
		{
			return _processParent.Process.ProcessName.Equals("ProcesoTransferenciaMercaderiaAST");
		}

		public void Init()
		{
			//base.Init ();
			
			this._signo = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "SignoAjuste");
			this._idDepositoDefault = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "Deposito.Default");
			this._idSeccionDefault = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "Seccion.Default");
			bool perfilSuperior = mz.erp.businessrules.Security.PerteneceAPerfilSuperior;

			if(this._signo.Equals("-"))
			{
				_listaTipoDeAjuste = (DataTable) businessrules.tlg_TiposDeAjuste.GetListSigno("-1",perfilSuperior).tlg_TiposDeAjuste;					
			}
			else
			{
				_listaTipoDeAjuste = (DataTable) businessrules.tlg_TiposDeAjuste.GetListSigno("1",perfilSuperior).tlg_TiposDeAjuste;					
			}

			IdTipoDeAjuste = Variables.GetValueString( _processParent.Process.ProcessName,this._taskName ,"TipoDeAjusteDefault");
			if(IdTipoDeAjuste != null && IdTipoDeAjuste.Equals(string.Empty))
				if(_listaTipoDeAjuste != null && _listaTipoDeAjuste.Rows.Count > 0)
					IdTipoDeAjuste = _listaTipoDeAjuste.Rows[0]["IdTipoAjuste"].ToString();
			DataRow row = mz.erp.businessrules.tlg_TiposDeAjuste.GetByPk(_idTipoDeAjuste);
			if(row != null)
				_idEstadoDeStock = Convert.ToString(row["IdEstadoDeStock"]);
			if(_idEstadoDeStock != null && !_idEstadoDeStock.Equals(string.Empty))
			{
				row = mz.erp.businessrules.tlg_EstadosDeStock.GetByPk(_idEstadoDeStock);
				if(row != null)
					_estadoDeStock = Convert.ToString(row["Descripcion"]);
			}
			if(_listaSeccion != null && _listaSeccion.Rows.Count > 0)
				if(this._idSeccionDefault != null && this._idSeccionDefault != string.Empty)
					_idSeccion = _idSeccionDefault;
				else
                    _idSeccion = _listaSeccion.Rows[0]["IdSeccion"].ToString();
			if(_listaDeposito != null && _listaDeposito.Rows.Count > 0)
				if(this._idDepositoDefault != null && this._idDepositoDefault != string.Empty)
					_idDeposito = _idDepositoDefault;
				else
					_idDeposito= _listaDeposito.Rows[0]["IdDeposito"].ToString();
			this._items = new ArrayList();
			_allowAddItems = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "AllowAddItems");
			
			/*if(!_allowAddItems)
				_allowAddItems = Variables.GetValueBool("Momentos." + this._taskName+ "." + this._processParent.Process.ProcessName + ".AllowAddItems");
			*/
			_allowEditItems = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "AllowEditItems");
			/*
			if(!_allowEditItems)
				_allowEditItems = Variables.GetValueBool("Momentos." + this._taskName+ "." + this._processParent.Process.ProcessName + ".AllowEditItems");
			*/
			_allowEditAjusteDeStock = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "AllowEditAjusteDeStock");
			/*
			if(!_allowEditAjusteDeStock)
				_allowEditAjusteDeStock = Variables.GetValueBool("Momentos." + this._taskName+ "." + this._processParent.Process.ProcessName + ".AllowEditAjusteDeStock");
			*/
			_allowEditDeposito = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "AllowEditDeposito");
			/*
			if(!_allowEditDeposito)
				_allowEditDeposito = Variables.GetValueBool("Momentos." + this._taskName+ "." + this._processParent.Process.ProcessName + ".AllowEditDeposito");
			*/
			_allowEditSeccion = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "AllowEditSeccion");
			/*
			if(!_allowEditSeccion)
				_allowEditSeccion = Variables.GetValueBool("Momentos." + this._taskName+ "." + this._processParent.Process.ProcessName + ".AllowEditSeccion");
			*/
			_allowShow = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "AllowShowForm", true);
		}

		

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;

		public event System.EventHandler OnTaskAfterPrevious;

		public virtual void ListenerTaskDependentChanged(object sender)
		{
			
		}

		public virtual void ListenerAfterExecuteDependentTask(object sender)
		{
			
			if (sender.GetType() == typeof( mz.erp.businessrules.SeleccionReparacionAjustes ))
			{
			
				SeleccionReparacionAjustes comprobantesAjustes = (SeleccionReparacionAjustes)sender;
				if(this._processParent.Process.ProcessName.Equals("ProcesoTransferenciaMercaderiaAST"))
					this._ordenReparacion = comprobantesAjustes.ArrayIdComporbantesPendientes[0].ToString();
					//this._ordenesReparacion = comprobantesAjustes.ArrayIdComporbantesPendientes;
				/*
				if(comprobantesPendientes.RelacionesComprobanteOrigenDestino != null && comprobantesPendientes.RelacionesComprobanteOrigenDestino.Count > 0)
				{				
					this.Step(comprobantesPendientes.RelacionesComprobanteOrigenDestino);
					//this.OnRecalcularComprobante(this, new EventArgs());
				}
				*/
			}
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.ComprobantesPendientes)))
			{
				ComprobantesPendientes ins = (ComprobantesPendientes) sender;
				LoadFromComprobantesPendientes(ins);
			}
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.SeleccionarInstanciaOrdenReparacion)))
			{
				SeleccionarInstanciaOrdenReparacion ins = (SeleccionarInstanciaOrdenReparacion) sender;
				LoadFromSeleccionarInstanciaOrdenReparacion(ins);
			}
			
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.RegistrarNumerosDeSerie)))
			{
				if(this._processParent.Process.ProcessName.Equals("ProcesoDevolucionMercaderiaAST")) 
				{
					RegistrarNumerosDeSerie rns = (RegistrarNumerosDeSerie) sender;
					LoadFromSeleccionarInstanciaOrdenReparacionNS(rns);
				}				
			}
			
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.AjustarStock)))
			{
				if(sender != this)
				{
					AjustarStock aj = (AjustarStock) sender;
					LoadFromAjustarStock(aj);
				}
			}
		}

		private void LoadFromComprobantesPendientes (ComprobantesPendientes comp)
		{
			this._items.Clear();
			ArrayList compPendientes = comp.ArrayIdComprobantesPendientes;
			foreach(string IdComp in compPendientes)
			{
				//DataTable table = mz.erp.businessrules.tsa_ComprobantesDet.GetList(IdComp, DateTime.MinValue, null, null, long.MinValue).Tables[0];
				DataTable table = mz.erp.businessrules.tsa_ComprobantesDet.GetByPk(IdComp).Tables[0];
				foreach(DataRow row in table.Rows)
				{
				
					ItemAjuste item = new ItemAjuste();
					item.IdProducto = Convert.ToString(row["IdProducto"]);
					item.Cantidad = Convert.ToInt64(row["Cantidad"]);
					this._items.Add(item);
			
				}
			}
			if(this._items.Count > 0)
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
		}

		private void LoadFromAjustarStock(AjustarStock ajuste)
		{
			this._items = ajuste.Items;
			this._observaciones = ajuste.Observaciones;
			if(this._items.Count > 0)
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());

		}

		private void LoadFromSeleccionarInstanciaOrdenReparacion(SeleccionarInstanciaOrdenReparacion ins)
		{
			this._items.Clear();
			foreach(Repuesto rep in ins.Repuestos)
			{
				ItemAjuste item = new ItemAjuste();
				item.IdProducto = rep.IdProducto;
				DataRow row = mz.erp.businessrules.tsh_Productos.GetByPk(item.IdProducto);
				item.Codigo = Convert.ToString(row["Codigo"]);
				item.Descripcion = Convert.ToString(row["Descripcion"]);
				item.CantidadPendiente = rep.CantidadPedida - rep.CantidadEntregada;
				item.CantidadPedida = rep.CantidadPedida;
				item.CantidadReservada = rep.CantidadReservada;
				DataRow rowAux = mz.erp.businessrules.tsh_ProductosSucursales.GetByPk(rep.IdProducto, Security.IdSucursal, Security.IdEmpresa);
				if(rowAux != null)
					item.StockDisponible = Convert.ToDecimal(rowAux["StockDisponible"]);
				else item.StockDisponible =0;
				this._items.Add(item);
			}
			if(this._items.Count > 0)
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
		}

		private void LoadFromSeleccionarInstanciaOrdenReparacionNS(RegistrarNumerosDeSerie rns)
		{
			this._items.Clear();			
			foreach (RegistrarNumerosDeSerie.ItemNumeroDeSerie itemNS in rns.Detalle)
			{				
				//if (itemNS.NumeroDeSerie.CompareTo( string.Empty ) != 0 && itemNS.Seleccion == true)
				if (itemNS.Seleccion == true)
				{					
					ItemAjuste item = new ItemAjuste();
					item.IdProducto = itemNS.IdProducto;					
					item.Codigo = itemNS.Codigo;
					item.Descripcion = itemNS.Descripcion;
					item.CantidadPendiente = 1;
					item.CantidadPedida = 1;
					item.Cantidad = 1;
					DataRow row = mz.erp.businessrules.tsh_ProductosSucursales.GetByPk(item.IdProducto, Security.IdSucursal, Security.IdEmpresa);
					if(row != null)
						item.StockDisponible = Convert.ToDecimal(row["StockDisponible"]);
					else item.StockDisponible =0;
					this._items.Add(item);
				}
			}			
			if(this._items.Count > 0)
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
		}

		public virtual void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}


		public virtual bool AllowShow() 
		{
			return _allowShow;
		}
		public void FormHasClosed() 
		{
		}
		public ItemsDatasetErrors GetErrors()
		{
			return _errores;			
		}

		public virtual string GetWarnings()
		{
			if(!MustAjustar())
				return "Las Cantidades son = 0. No se efectuaran Ajustes";
			if( StockCritico())
				return "Lo/s Producto/s " + _msjWarningStockCritico + " Tienen Stock Disponible < a la Cantidad solicitada. Desea Continuar de todos modos?";
			return "";
			    
			return null;			
		}
		string _msjWarningStockCritico = string.Empty;
		private bool StockCritico()
		{
			_msjWarningStockCritico = string.Empty;
			bool ok = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "Warnings.StockCritico");
			bool result = false;
			if(ok)
			{
				foreach(ItemAjuste item in this._items)
				{
					if(item.Cantidad > 0)
						if(item.Cantidad > item.StockDisponible)
						{
							result = true;
							_msjWarningStockCritico = _msjWarningStockCritico + item.Codigo + " ";
						}

				}
			}
			return result;
		}

		private bool MustAjustar()
		{
			foreach(ItemAjuste item in this._items)
			{
				if(item.Cantidad > 0)
					return true;
			}
			return false;
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

		public virtual void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			this.AllowPrevious();
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
			
		}

		public virtual void ListenerAfterPreviousDependentTask(object sender)
		{
			
		}

		public virtual void ListenerBeforePreviousDependentTask(object sender)
		{
			
		}

		#endregion
	}


	#region Clase MAPProcessSign
	
	/*Deprecated*/
	public sealed class MAPProcessSign
	{
		private static Hashtable _table = new Hashtable();

		private static void GenerateTable()
		{
			_table.Add("ProcesoAjustarStockNegativo", "-");
			_table.Add("ProcesoAjustarStockPositivo", "+");
			_table.Add("ProcesoDevolucionMercaderiaAST.AjustarStockDestino", "+");
			_table.Add("ProcesoDevolucionMercaderiaAST.AjustarStockOrigen", "-");
			_table.Add("ProcesoTransferenciaInternaDeStock.AjustarStockOrigen", "-");
			_table.Add("ProcesoTransferenciaInternaDeStock.AjustarStockDestino", "+");
			_table.Add("ProcesoTransferenciaMercaderiaAST.AjustarStockOrigen", "-");
			_table.Add("ProcesoTransferenciaMercaderiaAST.AjustarStockDestino", "+");

		}

		public static string GetSign(string keyProcess, string keyTask)
		{
			if (_table.Count == 0)
			{
				GenerateTable();
			}
			if (_table.Contains(keyProcess))
			{
				return Convert.ToString(_table[keyProcess]);
			}
			else
				{
				if(_table.Contains(keyProcess + "." + keyTask))
					return Convert.ToString(_table[keyProcess + "." + keyTask]);
				else
					return null;
				}
		}
		
	}
	#endregion
}

using System;
using System.Collections;
using System.Data;
using mz.erp.businessrules.comprobantes;
using mz.erp.businessrules;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// CLASE AUXILIAR Q MANTIENE INFORMACION SOBRE CADA ITEM SELECCIONADO (en la venta)
	/// </summary>
	public class EstadoItem
	{
		#region constructor
             //German 20120302 -  Tarea 0000247
			private EstadoItem()
			{
			}

            public EstadoItem(ItemComprobante item)
            {
                _item = item;
            }

            //Fin German 20120302 -  Tarea 0000247
		#endregion

		#region variables
            //German 20120302 -  Tarea 0000247
            ItemComprobante _item = null;
            //Fin German 20120302 -  Tarea 0000247
		string _idProducto = string.Empty;
		string _codigo = string.Empty;
		string _descripcion = string.Empty;
		string _descripcionLarga = string.Empty;
		bool _tieneDescripcionDetallada = false;
		decimal _cantidad = 0;
		string _idEstado = string.Empty;  //mantiene el idEstado de la forma de entrega seleccionada
		DateTime _fechaDeEntrega;
		string _idComprobanteOrigen = string.Empty;
		long _ordinal = 0;
		long _ordinalOrigen = 0;
		string _idTipoDeComprobanteOrigen = string.Empty;
		bool _visible = true;

		// ---- Matias - Tarea 204 - 20090722
		private string _campoAuxiliar1 = string.Empty;
		private string _campoAuxiliar2 = string.Empty;
		private string _campoAuxiliar3 = string.Empty;
		private string _campoAuxiliar4 = string.Empty;
		private string _campoAuxiliar5 = string.Empty;
		private string _campoAuxiliar6 = string.Empty;
		private string _observaciones = string.Empty;
		// ---- FinMatias

		#endregion
		
		#region setters y getters

        //German 20120302 -  Tarea 0000247
        public ItemComprobante Item
        {
            get { return _item; }
        }
        //Fin German 20120302 -  Tarea 0000247

		public bool TieneDescripcionDetallada
		{
			get{return _tieneDescripcionDetallada;}
			set{_tieneDescripcionDetallada = value;}
		}

		public bool Visible
		{
			get{return _visible;}
			set{_visible = value;}
		}
		public string IdProducto
		{
			set { _idProducto = value; }
			get { return _idProducto ;}
		}
		public string Codigo
		{
			set { _codigo = value; }
			get { return _codigo ;}
		}
		public string Descripcion
		{
			set { _descripcion = value; }
			get { return _descripcion ;}
		}
		public string DescripcionLarga
		{
			set { _descripcionLarga = value; }
			get { return _descripcionLarga ;}
		}
		public decimal Cantidad
		{
			set { _cantidad = value; }
			get { return _cantidad ;}
		}
		
		public string IdEstado
		{
			set {
				_idEstado = value;
			}
			get {
				return _idEstado;
			}
		}
	
		public DateTime FechaDeEntrega
		{
			get
			{
				return _fechaDeEntrega;
			}
			set
			{
				_fechaDeEntrega = value;
			}

		}
		public string IdComprobanteOrigen
		{
			get { return _idComprobanteOrigen ; }
			set { _idComprobanteOrigen = value ;}
		}
	/*
		public long OrdinalOrigen
		{
			get { return _ordinalOrigen ; }
			set { _ordinalOrigen = value ;}
		}
		*/
		public long Ordinal
		{
			get { return _ordinal ; }
			set { _ordinal = value ;}
		}
		public string IdTipoDeComprobanteOrigen
		{
			get { return _idTipoDeComprobanteOrigen ;}
			set { _idTipoDeComprobanteOrigen = value ; }
		}

		// ---- Matias - Tarea 204 - 20090722
		public string CampoAuxiliar1
		{
			get	{return _campoAuxiliar1;}
			set	{_campoAuxiliar1=value;}
		}
		public string CampoAuxiliar2
		{
			get	{return _campoAuxiliar2;}
			set	{_campoAuxiliar2=value;}
		}
		public string CampoAuxiliar3
		{
			get	{return _campoAuxiliar3;}
			set	{_campoAuxiliar3=value;}
		}
		public string CampoAuxiliar4
		{
			get	{return _campoAuxiliar4;}
			set	{_campoAuxiliar4=value;}
		}
		public string CampoAuxiliar5
		{
			get	{return _campoAuxiliar5;}
			set	{_campoAuxiliar5=value;}
		}
		public string CampoAuxiliar6
		{
			get	{return _campoAuxiliar6;}
			set	{_campoAuxiliar6=value;}
		}
		public string Observaciones
		{
			get	{return _observaciones;}
			set	{_observaciones=value;}
		}
		// ---- FinMatias

		#endregion

		public bool Equals(EstadoItem item)
		{
		
			return this._idProducto.Equals(item._idProducto) && this._idEstado.Equals(item.IdEstado);
		}

	}
	

	public class SeleccionEstadoDeItem : ITask, IPersistentTask
	{
		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				string variable = "Momentos." + this.GetTaskName() + "." + this._processManager.Process.ProcessName + "." + "TextoBotonAnterior";
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
		private string _textoBotonSiguiente = "Siguiente";
		public string TextoBotonSiguiente
		{
			get 
			{		
				string valor = String.Empty;
				string variable = "Momentos." + this.GetTaskName() + "." + this._processManager.Process.ProcessName + "." + "TextoBotonSiguiente";
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


		#region Constructores
	
			public SeleccionEstadoDeItem()
			{
			}

	
		#endregion

		#region Variables Privadas
		
			private ProcessManager _processManager;
			private string _taskName;
			private long _idTask;
			private ArrayList _arrayItems = new ArrayList();
			private bool _hasShow = true;
			private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
			private bool _preSetData = false;
			private string _estadoItemDefault  = string.Empty;
			private bool _mostrarDatosAuxiliares = false;

			
			
		
		#endregion

		#region Métodos de Variables Privadas
			
			public bool HasShow
			{
				get
				{
					return _hasShow;
				}
			}
					
			public ArrayList ArrayItems
			{
				get
				{
					return _arrayItems;
				}
				set
				{
					if(value != _arrayItems)
					{
						_arrayItems = value;
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
				}
			}
		
		public string EstadoItemDefault
		{
			get{return _estadoItemDefault;}
			set{_estadoItemDefault = value;}
		}

		public bool MostrarDatosAuxiliares
		{
			get{return _mostrarDatosAuxiliares;}
			set{_mostrarDatosAuxiliares=value;}
		}
		

		#endregion
	
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
	
			public void ListenerAfterExecuteDependentTask( object sender )
			{
				if(sender.GetType().Equals(typeof(mz.erp.businessrules.comprobantes.ComprobanteDeVenta)))
				{	
					ComprobanteDeVenta comprobanteDeVenta = (ComprobanteDeVenta) sender;
					LoadDataFromComprobanteDeVenta( comprobanteDeVenta );
					LoadDataFromComprobanteDeVentaSaved( comprobanteDeVenta );
									
				}	
			}

		private bool DebeEntregar(string IdProducto, string IdTipoProducto)
		{
			string TiposDeProductosExcluidosEntrega = string.Empty;
			TiposDeProductosExcluidosEntrega = Variables.GetValueString(this._processManager.Process.ProcessName, this._taskName, "TiposProductosSinEntrega");
			ArrayList TiposDeProductosExcluidosEntregaList = mz.erp.systemframework.Util.Parse(TiposDeProductosExcluidosEntrega, ",");
			return !TiposDeProductosExcluidosEntregaList.Contains(IdTipoProducto);
			
		}

		private void LoadDataFromComprobanteDeVentaSaved(ComprobanteDeVenta comprobante)
		{
			ProcessManager _process = comprobante.GetProcessManagerParent();
			if (_process.Process.MainTask.TaskInstance.Equals( comprobante ))
			{
				foreach( RelacionComprobanteOrigenDestino rol in comprobante.RelacionesComprobantesOrigenDestino)
				{
					string idComprobante = rol.IdComprobante;
					long idordinal = rol.OrdinalOrigen;
                    mz.erp.commontypes.data.tsa_ComprobanteDetalleEstadoItemsDataset data = tsa_ComprobanteDetalleEstadoItems.GetList( idComprobante, idordinal, decimal.MinValue, System.DateTime.MinValue, null );
					if (data.tsa_ComprobanteDetalleEstadoItems.Rows.Count > 0)
					{
						mz.erp.commontypes.data.tsa_ComprobanteDetalleEstadoItemsDataset.tsa_ComprobanteDetalleEstadoItemsRow row = (mz.erp.commontypes.data.tsa_ComprobanteDetalleEstadoItemsDataset.tsa_ComprobanteDetalleEstadoItemsRow )data.tsa_ComprobanteDetalleEstadoItems.Rows[0];
						
						if(rol.Visible && rol.Entregar && this.DebeEntregar(rol.IdProducto, rol.IdTipoProducto))
						{

							if(this.Contains( rol.IdProducto, rol.OrdinalOrigen))
							{

							EstadoItem miitem = this.GetItem(rol.IdProducto, rol.OrdinalOrigen);
							miitem.FechaDeEntrega = row.Fecha;
							miitem.IdEstado = row.IdEstado;
							miitem.IdTipoDeComprobanteOrigen = comprobante.TipoComprobanteDestino;

							
							}
						}
							/*
						else
						{
							if(rol.Entregar)
							{
								if(!this.Contains( rol.IdProducto, rol.OrdinalOrigen, rol.Visible))
								{
									DataRow rowP = mz.erp.businessrules.tsh_Productos.GetByPk(rol.IdProducto);
									EstadoItem miitem = new EstadoItem();
									miitem.IdProducto = rol.IdProducto;
									miitem.Codigo = Convert.ToString(row["Codigo"]);
									miitem.Descripcion = rol.Descripcion;
									miitem.DescripcionLarga = rol.Descripcion;
									miitem.Cantidad = rol.CantidadOrigen;
									miitem.FechaDeEntrega = mz.erp.businessrules.Sistema.DateTime.Now;
									EstadosCollection estadosCol = (new EstadosCollection()).GenerateFormaDeEntrega();
									string id = estadosCol.KeyOfValue(_estadoItemDefault);
									miitem.IdEstado = id;  
									miitem.Ordinal = rol.OrdinalOrigen;
									miitem.Visible = false;
									this.ArrayItems.Add(miitem);
								}
							}
						}	*/
						
					}
					_preSetData = true;
						
				}
				if (ObjectHasChanged != null )
					this.ObjectHasChanged(this, new EventArgs());
			}

		}

		private bool Contains(string idProducto, long ordinal)
		{
			foreach(EstadoItem it in this.ArrayItems)
			{
				if(it.IdProducto.Equals(idProducto) && it.Ordinal.Equals(ordinal))
					return true;
			}
			return false;
		}

		private bool Contains(string idProducto, long ordinal, bool Visible)
		{
			foreach(EstadoItem it in this.ArrayItems)
			{
				if(it.IdProducto.Equals(idProducto) && it.Ordinal.Equals(ordinal)&& it.Visible.Equals(Visible))
					return true;
			}
			return false;
		}

		private EstadoItem GetItem(string idProducto, long ordinal)
		{
			foreach(EstadoItem it in this.ArrayItems)
			{
				if(it.IdProducto.Equals(idProducto) && it.Ordinal.Equals(ordinal))
					return it;
			}
			return null;
		}

		private EstadoItem CreateItem(ItemComprobante item)
		{
            //German 20120302 -  Tarea 0000247
			EstadoItem miitem = new EstadoItem(item);
            //Fin German 20120302 -  Tarea 0000247
			miitem.IdProducto = item.IdProducto;
			miitem.Codigo = item.Codigo;
			miitem.Descripcion = item.Descripcion;
			miitem.DescripcionLarga = item.DescripcionLarga;
			miitem.TieneDescripcionDetallada = item.TieneDescripcionPersonalizada ;
			miitem.Cantidad = item.Cantidad;
			miitem.FechaDeEntrega = mz.erp.businessrules.Sistema.DateTime.Now;
			EstadosCollection estadosCol = (new EstadosCollection()).GenerateFormaDeEntrega();
			string id = estadosCol.KeyOfValue(_estadoItemDefault);
			miitem.IdEstado = id;  
			miitem.Ordinal = item.Ordinal;
			miitem.Visible = item.Visible;
			miitem.IdTipoDeComprobanteOrigen = item.ItemsComprobantes.ComprobanteDeVenta.TipoComprobanteDestino;
			miitem.IdComprobanteOrigen = item.ItemsComprobantes.ComprobanteDeVenta.IdComprobante;

			// ---- Matias - Tarea 204 - 20090722
			miitem.CampoAuxiliar1 = item.CampoAuxiliar1;
			miitem.CampoAuxiliar2 = item.CampoAuxiliar2;
			miitem.CampoAuxiliar3 = item.CampoAuxiliar3;
			miitem.CampoAuxiliar4 = item.CampoAuxiliar4;
			miitem.CampoAuxiliar5 = item.CampoAuxiliar5;
			miitem.CampoAuxiliar6 = string.Empty;
			miitem.Observaciones = string.Empty;
			// ---- FinMatias

			return miitem;

		}
		
		private void LoadDataFromComprobanteDeVenta(ComprobanteDeVenta comprobante)
		{
			if(this.ArrayItems.Count > 0) _preSetData = true;
			ArrayList aux = new ArrayList();
			foreach (ItemComprobante item in comprobante.Items)
			{   
				if(item.Entregar && this.DebeEntregar(item.IdProducto, item.IdTipoProducto))
				{
					if(!this.Contains(item.IdProducto,item.Ordinal))
					{
					
						aux.Add(this.CreateItem(item));
					}
				}
				
			}
			foreach (ItemComprobante item in comprobante.Items.ItemsNoVisibles)
			{   
				if(item.Entregar && this.DebeEntregar(item.IdProducto, item.IdTipoProducto))
				{
					aux.Add(this.CreateItem(item));
					
				}
				
			}
			
			foreach(EstadoItem estadoItem in this.ArrayItems)
			{
				
				foreach (ItemComprobante item in comprobante.Items)
				{
					if(item.Entregar && this.DebeEntregar(item.IdProducto, item.IdTipoProducto))
					{
						if(estadoItem.IdProducto.Equals(item.IdProducto) && estadoItem.Ordinal.Equals(item.Ordinal))
						{
                            /* Silvina 20101118 - Tarea 938 */
                            estadoItem.Cantidad = item.Cantidad;
                            /* Fin Silvina */
							aux.Add(estadoItem);
							break;
						}
					}
				}
				
			}
			this.ArrayItems = aux;

		}


		
		public void ListenerBeforeExecuteDependentTask( object sender )
		{ 
		}

		
		public void Init()
		{
			this._idTask = Workflow.GetIdTakByName(this._taskName);
			string estadoDefault = Variables.GetValueString("Momentos." + this._processManager.Process.MainTask.KeyTask + ".FormaDeEntrega.EstadoDefault" );
			if(estadoDefault.Equals(string.Empty))
				estadoDefault = Variables.GetValueString("Momentos.FormaDeEntrega.EstadoDefault" );
			_estadoItemDefault = estadoDefault;
			_mostrarDatosAuxiliares = Variables.GetValueBool(this._processManager.Process.ProcessName, this._taskName, "MostrarDatosAuxiliares");
		}

			
		/// <summary>
		/// verifica si todos los items seleccionados tienen algúna forma de entrega
		/// y que la fecha de entrega es >= a la fecha actual
		/// </summary>
		/// <returns></returns>
		public bool IsValid()
		{
			bool valido = true;
			foreach (EstadoItem item in ArrayItems)
			{   
				valido = valido && (item.IdEstado != string.Empty) && (item.IdEstado != null)
					&& (item.FechaDeEntrega >=  mz.erp.businessrules.Sistema.DateTime.Now);
			}
			return valido;
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


		public bool AllowShow() 
		{
			string momento = this._processManager.Process.MainTask.KeyTask;
			string nombreTarea = 	this.GetTaskName();
			bool allowShow = Variables.GetValueBool(this._processManager.Process.ProcessName, this._taskName, "VisualizaVentana");
			if( !allowShow )
				return Variables.GetValueBool("Momentos.FormaDeEntrega.VisualizaVentana");
			return allowShow && this._arrayItems.Count > 0;
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
			return this._processManager;
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			this._processManager = processManager;
		}

		public string GetTaskName()
		{
			return this._taskName;
		}

		public void SetTaskName(string taskName)
		{
			this._taskName = taskName;
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

		/// <summary>
		/// asigna un valor determinado a todos los itmes
		/// </summary>
		/// <param name="str">debe ser un str que exista en EstadosCollecion</param>
		public void AsignarEstadoAItems(string str)
		{	
			//obtengo el nuevo id para los items
			EstadosCollection estadosCol = (new EstadosCollection()).GenerateFormaDeEntrega();
			string id = estadosCol.KeyOfValue(str);
			//le seteo ese id a cada item
			foreach (EstadoItem item in ArrayItems)
			{   
				item.IdEstado = id; 
			}
			if (ObjectHasChanged != null )
				this.ObjectHasChanged(this, new EventArgs());

		}
		public bool PreSetData
		{
			get { return _preSetData; }
		}
		#region Miembros de IPersistentTask

		public event System.EventHandler OnTaskBeforeFlush;

		public event System.EventHandler OnTaskAfterFlush;

		private bool _hasSaved = false;
		public bool GetHasSaved()
		{
			return _hasSaved;
		}
		public DataSet Data
		{
			get { return (DataSet)_data ;}
		}
		
		private mz.erp.commontypes.data.tsa_ComprobanteDetalleEstadoItemsDataset _data = new tsa_ComprobanteDetalleEstadoItemsDataset(); 
		public ArrayList GetDataList()
		{
			ArrayList array = new ArrayList();
			array.Add((DataSet)this.Data);
			return array;
		}

		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();
			data.Add( this.Data ); //el Data agregado es el DatasetExtendido.
			return data;
		}
		
		private TaskCollectionData _arrData = new TaskCollectionData();

		public void Commit()
		{
			
			foreach( EstadoItem item in this._arrayItems )
			{
				tsa_ComprobanteDetalleEstadoItemsDataset.tsa_ComprobanteDetalleEstadoItemsRow row = mz.erp.businessrules.tsa_ComprobanteDetalleEstadoItems.NewRow(_data);
				row.Ordinal = item.Ordinal;
				row.Cantidad = item.Cantidad;
				row.Fecha = item.FechaDeEntrega;
				row.IdEstado = item.IdEstado;
				row.Observaciones = string.Empty;
				try
				{
					_data.tsa_ComprobanteDetalleEstadoItems.Addtsa_ComprobanteDetalleEstadoItemsRow(row);
				}
				catch (Exception e)
				{
					System.Console.WriteLine(e.ToString());
				}
			}
		}
		private SentenciasReplicacion _replication;
		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());
			_replication = GenerateReplication();
			mz.erp.businessrules.tsa_ComprobanteDetalleEstadoItems.Update( ( tsa_ComprobanteDetalleEstadoItemsDataset )this._data, _replication, IdTransaction);
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this, new EventArgs());

		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
			//falta la info del flete, 1º se debe guardar el comprobanteCargoAdicional
			foreach( TaskCollectionData data in  _processCollectionData)
			{
				if (data.TaskName.Equals("Vender") || data.TaskName.Equals("VenderManual") || data.TaskName.Equals("Prestar") || data.TaskName.Equals("Prevender"))
				{
					foreach( DataSet dataset in data )
					{
						if (dataset.DataSetName.Equals("tsa_ComprobantesExDataset"))
						{
							DataTable table = dataset.Tables["tsa_ComprobantesDet"];
							DataRow row = table.Rows[0];
							string idComprobante = (string)row["IdComprobante"];
							foreach( DataRow row2 in _data.Tables["tsa_ComprobanteDetalleEstadoItems"].Rows )
							{
								row2["IdComprobante"] = idComprobante;
							}
						}
					}
				}
			}
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
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsa_ComprobanteDetalleEstadoItems";
			return replication;
		}

		#endregion

		public bool PreguntarAlCancelar
		{
			get 
			{
				bool _preguntarAlCancelar = Variables.GetValueBool(_processManager.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;}
		}
	}
	
}

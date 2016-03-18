using System;
using System.Data;
using System.Collections;
using mz.erp.commontypes.data;
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.businessrules.comprobantes;

namespace mz.erp.businessrules
{
	
	/// <summary>
	/// Descripción breve de ConceptosAdicionales.
	/// </summary>
	public class ConceptosAdicionales : ITask, IPersistentTask
	{
		
		private static SentenciasReplicacion _replication;

		#region Contrusctores
		public ConceptosAdicionales()
		{
		}
	
		#endregion 
	
		#region Variables Privadas
		
		private ProcessManager _processManager;
		private string _taskName;
		private long _idTask;
		private bool _hasShow = true;

		private ArrayList _arrayItems = new ArrayList();
		
		private string _tipo= "Flete";
		private string _descripcion = string.Empty;
		private DateTime _fecha = mz.erp.businessrules.Sistema.DateTime.Now;
		private decimal _monto = 0;
		private string _idPersona= string.Empty;
		private string _estado = string.Empty;
		private string _idTransporte =string.Empty;
		private string _idCargoAdicional =Util.NewStringId();


		private tsa_ComprobanteCargoAdicionalDataset DatasetCargoAdicional = new mz.erp.commontypes.data.tsa_ComprobanteCargoAdicionalDataset();
		private tlg_FleteDataset DatasetFlete = new mz.erp.commontypes.data.tlg_FleteDataset();
				
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		
		private DataSet _data; //aca guardo los datos yo ( es un DatasetExtendido )
		private TaskCollectionData _arrData = new TaskCollectionData();
		

		public DataSet Data
		{
			set { _data = value; }
			get { return _data ;}
		}
		
		public bool AllowShow()
		{
			if (this.ArrayItems.Count == 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		
		public void FormHasClosed() 
		{
		}
		#endregion

		#region Métodos de Variables Privadas
			
		public bool HasShow
		{
			get
			{
				return this.ArrayItems.Count == 0;
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
		public string IdPersona
		{
			get
			{	
				return _idPersona;
			}
			set
			{
				if(_idPersona!= value){	_idPersona = value; }
			}
		}
		public string IdTransporte
		{
			get
			{	
				return _idTransporte;
			}
			set
			{
				if(_idTransporte!= value){	_idTransporte = value;	}
			}
		
		}
		public string Descripcion
		{
			get
			{	
				return _descripcion;
			}
			set
			{	if(_descripcion!= value){	_descripcion = value;	}
			}
		}

		public decimal Monto
		{
			get
			{	
				return _monto;
			}
			set
			{
				_monto = value;
			}
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
			bool lHasChanged = false;			
			if (sender.GetType().Equals( typeof(mz.erp.businessrules.SeleccionEstadoDeItem)))
			{
				ArrayList estadoDeItems = ((SeleccionEstadoDeItem)sender).ArrayItems;
				LoadDataFromClassSeleccionEstadoDeItem( estadoDeItems );
				this._tipo = "Flete";
				lHasChanged = true;			
			}
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.comprobantes.ComprobanteDeEntrega)))
			{
				ComprobanteDeEntrega ce = (ComprobanteDeEntrega)sender;
				LoadDataFromComprobanteDeEntrega(ce);
				this._tipo = "Flete";
				lHasChanged = true;		
			}
			if (ObjectHasChanged != null && lHasChanged)
				this.ObjectHasChanged(this, new EventArgs());
		}
		
		public void ListenerBeforeExecuteDependentTask( object sender )
		{ 
			
		}

		private void LoadDataFromComprobanteDeEntrega(ComprobanteDeEntrega entrega)
		{
			this.ArrayItems.Clear();
			foreach ( ItemComprobante item in entrega.Items )
			{
                //German 20120302 -  Tarea 0000247
                EstadoItem miitem = new EstadoItem(item);
                //Fin German 20120302 -  Tarea 0000247
				miitem.IdProducto = item.IdProducto;
				miitem.Codigo = item.Codigo;
				miitem.Descripcion = item.Descripcion;
				miitem.DescripcionLarga = item.DescripcionLarga;
				miitem.Cantidad = item.Cantidad;
				miitem.FechaDeEntrega = entrega.FechaVencimiento;
				miitem.IdEstado = string.Empty;
				miitem.Ordinal = item.Ordinal;
				this.ArrayItems.Add(miitem);
			}
		}
		
		public void Init()
		{
			this._idTask = Workflow.GetIdTakByName(this._taskName);
			string momento = this.GetProcessManagerParent().Process.MainTask.KeyTask;
			this._idPersona = Security.IdPersona;
			string IdTransporte = Variables.GetValueString("Momentos." + momento + ".Flete.TransporteDefault");
			if(IdTransporte.Equals(string.Empty))
                 IdTransporte = Variables.GetValueString("Momentos.Flete.TransporteDefault");
			this._idTransporte = IdTransporte;
			_data = new tlg_FleteExDataset();
			if (ObjectHasChanged != null)
				this.ObjectHasChanged(this, new EventArgs());
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
			_errores.Clear();
			bool isvalid = true;
			if (!IsValidPersona())
			{
				ItemDatasetError error = new ItemDatasetError("Responsable","Responsable","Debe selccionar el Responsable");
				_errores.Add( error );
				isvalid = false;
			}
			if(!IsValidDescripcion())
			{
				ItemDatasetError error = new ItemDatasetError("Descripcion","Descripcion","La descripcion no puede ser vacia");
				_errores.Add( error );
				isvalid = false;
			}
			if(!IsValidTransporte())
			{
				ItemDatasetError error = new ItemDatasetError("Transporte","Transporte","Debe seleccionar el transporte");
				_errores.Add( error );
				isvalid = false;
			}
			return isvalid;
		}

		public bool IsValidPersona()
		{
			return true;
		}
		public bool IsValidDescripcion()
		{
			return true;
		}
		public bool IsValidTransporte()
		{
			if(this._arrayItems.Count > 0)
				return !_idTransporte.Equals(string.Empty);
			else return true;
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

		private void LoadDataFromClassSeleccionEstadoDeItem( ArrayList estadodeItems )
		{
			this.ArrayItems.Clear();
			EstadosCollection estadosentrega = new EstadosCollection().GenerateFormaDeEntrega();
			string idBuscado = estadosentrega.KeyOfValue("Enviar");
			foreach ( mz.erp.businessrules.EstadoItem unestadoItem in estadodeItems )
			{
				if (unestadoItem.IdEstado == idBuscado) //"1" es el enviar
				{
                    //German 20120302 -  Tarea 0000247
					EstadoItem miitem = new EstadoItem(unestadoItem.Item);
                    //Fin German 20120302 -  Tarea 0000247
					miitem.IdProducto = unestadoItem.IdProducto;
					miitem.Codigo = unestadoItem.Codigo;
					miitem.Descripcion = unestadoItem.Descripcion;
					miitem.DescripcionLarga = unestadoItem.DescripcionLarga;
					miitem.Cantidad = unestadoItem.Cantidad;
					miitem.FechaDeEntrega = unestadoItem.FechaDeEntrega;
					miitem.IdEstado = unestadoItem.IdEstado;
					miitem.Ordinal = unestadoItem.Ordinal;
					this.ArrayItems.Add(miitem);
				}
			}
		}

		


		#endregion

		#region Miembros de IPersistentTask

		private bool _hasSaved = false;
		public bool GetHasSaved()
		{
			return _hasSaved;
		}
		public event System.EventHandler OnTaskBeforeFlush;
		public event System.EventHandler OnTaskAfterFlush;
		

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


		public void CommitCargoAdicional()
		{			
			tlg_FleteExDataset data = (tlg_FleteExDataset) _data;
			foreach ( mz.erp.businessrules.EstadoItem unestadoItem in _arrayItems)
			{
				tlg_FleteExDataset.tsa_ComprobanteCargoAdicionalRow row = data.tsa_ComprobanteCargoAdicional.Newtsa_ComprobanteCargoAdicionalRow();		
				row.IdComprobanteCargoAdicional = Util.NewStringId();
				row.IdComprobante = Util.NewStringId();  
				//le asigno un valor default q será tapado por el putExtraData.
				row.Ordinal = unestadoItem.Ordinal;
				row.Tipo = this._tipo;
				row.Descripcion = this._descripcion;
				row.Fecha = this._fecha;
				row.Monto = this._monto;
				row.IdPersona = this._idPersona;
				row.Estado = this._estado;
				row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
				row.IdConexionCreacion = Security.IdConexion;
				row.IdConexionUltimaModificacion = Security.IdConexion;
				data.tsa_ComprobanteCargoAdicional.Addtsa_ComprobanteCargoAdicionalRow(row);
				this.CommitFlete(row.IdComprobanteCargoAdicional);
			}		
		}


		public void Commit()
		{	

			this.CommitCargoAdicional();
			this._arrData.Add( (DataSet)this.Data );
			this._arrData.TaskName = this.GetTaskName();
		}

		public void CommitFlete(string IdCargoAdiciional)
		{
			tlg_FleteExDataset data = (tlg_FleteExDataset) _data;  // es el Dataset extendido
			tlg_FleteExDataset.tlg_FleteRow row = data.tlg_Flete.Newtlg_FleteRow();
			row.IdComprobanteCargoAdicional = IdCargoAdiciional;
			row.IdTransporte = this._idTransporte;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			data.tlg_Flete.Addtlg_FleteRow( row );
		}


		public void Flush (string IdTransaction)
		{

			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());
			_replication = GenerateReplication();
			mz.erp.dataaccess.tsa_CargoAdicionalEx.Update( ( tlg_FleteExDataset )this._data, _replication, IdTransaction);
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this, new EventArgs());

		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
			//falta la info del flete, 1º se debe guardar el comprobanteCargoAdicional
			foreach( TaskCollectionData data in  _processCollectionData)
			{
				if (data.TaskName.Equals("Vender") || data.TaskName.Equals("VenderManual") 
					|| data.TaskName.Equals("Prestar") || data.TaskName.Equals("Entregar") )
				{
					foreach( DataSet dataset in data )
					{
						if (dataset.DataSetName.Equals("tsa_ComprobantesExDataset"))
						{
							DataTable table = dataset.Tables["tsa_ComprobantesDet"];
							DataRow row = table.Rows[0];
							string idComprobante = (string)row["IdComprobante"];
							foreach( DataRow row2 in _data.Tables["tsa_ComprobanteCargoAdicional"].Rows )
							{	//le asigno a todos los items el idComprobante que les faltaba
								row2["IdComprobante"] = idComprobante;
							}
						}
					}
				}
			}
		}


		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
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
			replication.NombreTabla = "dataaccess.tsa_ComprobanteCargoAdicional";
			return replication;
		}

		#endregion

		public bool PreguntarAlCancelar
		{
			get {
				bool _preguntarAlCancelar = Variables.GetValueBool(_processManager.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;}
		}
	}
}

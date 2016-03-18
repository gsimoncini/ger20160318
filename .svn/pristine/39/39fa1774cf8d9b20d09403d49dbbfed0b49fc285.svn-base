using System;
using System.Data;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de AbmProductos.
	/// </summary>
	public class AbmProductos: ITask, IPersistentTask
	{
		/// <summary>
		/// Tarea primaria de un grupo de ABMs
		/// </summary>
		public AbmProductos()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#region Variables Privadas
		
		private ProcessManager _parentProcess;
		private string _taskName;
		private ItemsDatasetErrors _errors = new ItemsDatasetErrors();
		private mz.erp.commontypes.SentenciasReplicacion _sentencia;

		private string _leyendaFormulario = string.Empty;
		private bool _preguntarAlCancelar = false;
		
		#endregion



		#region Variables Publicas
		private mz.erp.commontypes.BRTypes.ABMState _state;

		public string LeyendaFormulario
		{
			get{return _leyendaFormulario;}
		}
		public bool PreguntarAlCancelar
		{
			get {return _preguntarAlCancelar ;}
			set {_preguntarAlCancelar =value;}
		}
		public mz.erp.commontypes.BRTypes.ABMState State
		{
			get { return _state ; }
		}
		private string _idProducto;
		public string IdProducto
		{
			get { return _idProducto ;}
			set { _idProducto = value ;}
		}
		
		private string _codigo;
		public string Codigo
		{
			get { return _codigo ; }
			set { _codigo = value ; }
		}
		private string _codigoSecundario;
		public string CodigoSecundario
		{
			get { return _codigoSecundario ;}
			set { _codigoSecundario = value ; }
		}
		private string _descripcion;
		public string Descripcion
		{
			get { return _descripcion ; }
			set { _descripcion  = value ;}
		}
		private string _descripcionCorta;
		public string DescripcionCorta
		{
			get { return _descripcionCorta; }
			set { _descripcionCorta = value ;}
		}
		private string _descripcionLarga;
		public string DescripcionLarga
		{
			get { return _descripcionLarga ; }
			set { _descripcionLarga = value ; }
		}
		private bool _activo;
		public bool Activo
		{
			get { return _activo ; }
			set { _activo = value ; }
		}
		private string _idTipoDeProducto;
		public string IdTipoDeProducto
		{
			get { return _idTipoDeProducto ;}
			set { _idTipoDeProducto = value ;}
		}
		private DataTable _tiposDeProductos = new DataTable();
		public DataTable TiposDeProductos
		{
			get { return _tiposDeProductos ; }
		}
		private bool _obligaCodigoBarras;
		public bool ObligaCodigoBarras
		{
			get { return _obligaCodigoBarras; }
			set { _obligaCodigoBarras = value ; }
		}
		private bool _obligaNumeroDeSerie;
		public bool ObligaNumeroDeSerie
		{
			get { return _obligaNumeroDeSerie; }
			set { _obligaNumeroDeSerie = value ; }
		}
		private string _observaciones;
		public string Observaciones
		{
			get { return _observaciones; }
			set { _observaciones = value ; }
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
			// TODO: agregar la implementación AbmProductos.ListenerTaskDependentChanged
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
			/*Cuando escuche de una determinada tarea se dara cuenta en q estado va a quedar*/
			if (_codigo.CompareTo(_codigo) != 0)
			{
				EditData( _codigo );
			}
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación AbmProductos.ListenerBeforeExecuteDependentTask
		}

		public void Init()
		{
			InitializeData();
			NewData();
		}

		public bool IsValidForStartProcess()
		{
			_errors.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._parentProcess.Process.IdProcess,IdTarea, this);
			_errors.AddAll(validator.GetErrors());
			return IsValid;
		}

		public bool IsValid()
		{
			if (_errors.Count > 0)
				return false;
			else
				return true;
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
			return _errors;
		}

		public string GetWarnings()
		{
			return null;
		}
		
		public ProcessManager GetProcessManagerParent()
		{
			return _parentProcess;
		}
		
		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_parentProcess = processManager;
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
			if (OnTaskBeforeExecute != null)
			{
				this.OnTaskBeforeExecute(this,new System.EventArgs() );
			}
			ValidarDatos();
			if (OnTaskAfterExecute != null)
			{
				this.OnTaskAfterExecute(this,new System.EventArgs() );
			}
		}
		private void ValidarDatos()
		{
			_errors.Clear();
			if (_state == BRTypes.ABMState.Modificacion || _state == BRTypes.ABMState.Alta)
			{
				if (_codigo.CompareTo(string.Empty) == 0 && !Variables.GetValueBool("Productos.CodigoAutomatico"))
				{
					_errors.Add( new ItemDatasetError( "Productos","Codigo","El campo no puede estar vacío") );
				}
				if (_descripcion.CompareTo(string.Empty) == 0)
				{
					_errors.Add( new ItemDatasetError( "Productos","Descripcion","El campo no puede estar vacío") );
				}
				if (_descripcionCorta.CompareTo(string.Empty) == 0)
				{
					_errors.Add( new ItemDatasetError( "Productos","Descripcion Corta","El campo no puede estar vacío") );
				}
				if (_descripcionLarga.CompareTo(string.Empty) == 0)
				{
					_errors.Add( new ItemDatasetError( "Productos","Descripcion Larga","El campo no puede estar vacío") );
				}
			}

		}

		public bool AllowPrevious()
		{
			// TODO: agregar la implementación AbmProductos.AllowPrevious
			return false;
		}

		public void Previous()
		{
			// TODO: agregar la implementación AbmProductos.Previous
		}


		public void ListenerAfterPreviousDependentTask(object sender)
		{
			// TODO: agregar la implementación AbmProductos.ListenerAfterPreviousDependentTask
		}

		public void ListenerBeforePreviousDependentTask(object sender)
		{
			// TODO: agregar la implementación AbmProductos.ListenerBeforePreviousDependentTask
		}

		#endregion

		#region Miembros de IPersistentTask

		public event System.EventHandler OnTaskBeforeFlush;

		public event System.EventHandler OnTaskAfterFlush;

		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = _taskName;
			data.Add(_rowProductos.Table.DataSet);
			return data;
		}

		/// <summary>
		/// Deshabilitada, el procesamiento es en el flush y en el PutExtraData
		/// </summary>
		public void Commit()
		{
			if (_state != BRTypes.ABMState.Consulta)
			{
				if (_state == BRTypes.ABMState.Baja) 
				{
					_rowProductos.Delete();
				}
				else
				{
					_rowProductos.IdProducto = _idProducto;
					_rowProductos.Codigo = _codigo;
					_rowProductos.CodigoSecundario = _codigoSecundario;
					_rowProductos.IdTipoProducto = _idTipoDeProducto;
					_rowProductos.Activo = _activo;
					_rowProductos.Descripcion = _descripcion;
					_rowProductos.DescripcionCorta = _descripcionCorta;
					_rowProductos.DescripcionLarga = _descripcionLarga;
					_rowProductos.ObligaCodigoBarra = _obligaCodigoBarras;
					_rowProductos.ObligaNumeroSerie = _obligaNumeroDeSerie;
					_rowProductos.Observaciones = _observaciones;
				}
				
			}
		}

		public void Flush(string IdTransaction)
		{
			if (_state != BRTypes.ABMState.Consulta)
			{
				mz.erp.businessrules.tsh_Productos.Update( _rowProductos, IdTransaction, new SentenciasReplicacion() );
				_sentencia = GenerateReplication();
				PutErrorOnDataSet(_rowProductos);
			}
		}
		private mz.erp.commontypes.SentenciasReplicacion GenerateReplication()
		{
			mz.erp.commontypes.SentenciasReplicacion replication = new mz.erp.commontypes.SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsh_Productos";
			return replication;
		}

		public void PutErrorOnDataSet(System.Data.DataRow row)
		{
			_errors.Clear();
			if (_rowProductos.HasErrors)
			{
				System.Data.DataColumn[] columnasConError = row.GetColumnsInError();
				for(int i=0;columnasConError.Length<i;i++)
				{
					ItemDatasetError error = new ItemDatasetError( ((System.Data.DataColumn)columnasConError[i]).Table.TableName,  ((System.Data.DataColumn)columnasConError[i]).ColumnName, row.GetColumnError( columnasConError[i] ) );
					_errors.Add( error );
				}
			}
		}
		
		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			// TODO: agregar la implementación AbmProductos.PutExtraDataOnCommit
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
			// TODO: agregar la implementación AbmProductos.PutExtraData
		}

		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			return _sentencia;
			
		}

		public bool GetHasSaved()
		{
			// TODO: agregar la implementación AbmProductos.GetHasSaved
			return false;
		}

		#endregion
		#region Custom Members
		private mz.erp.commontypes.data.tsh_ProductosDataset.tsh_ProductosRow _rowProductos;

		private void GetDataProductos()
		{
			_idProducto = _rowProductos.IdProducto;
			_codigo = _rowProductos.Codigo;
			_codigoSecundario = _rowProductos.CodigoSecundario;
			_idTipoDeProducto = _rowProductos.IdTipoProducto;
			_activo = _rowProductos.Activo;
			_descripcion = _rowProductos.Descripcion;
			_descripcionCorta = _rowProductos.DescripcionCorta;
			_descripcionLarga = _rowProductos.DescripcionLarga;
			_obligaCodigoBarras = _rowProductos.ObligaCodigoBarra;
			_obligaNumeroDeSerie = _rowProductos.ObligaNumeroSerie;
			_observaciones = _rowProductos.Observaciones;
		}
		private void NewData()
		{
			_rowProductos = mz.erp.businessrules.tsh_Productos.NewRow();
			GetDataProductos();	
			_state = BRTypes.ABMState.Alta;
		}
		private void EditData( string codigo )
		{
			string IdProducto = mz.erp.businessrules.tsh_Productos.GetPkByCodigo( codigo );
			_rowProductos = mz.erp.businessrules.tsh_Productos.GetByPk( IdProducto );
			GetDataProductos();	
			_state = BRTypes.ABMState.Modificacion;
		}
		private void DeleteData( string codigo )
		{
			string IdProducto = mz.erp.businessrules.tsh_Productos.GetPkByCodigo( codigo );
			_rowProductos = mz.erp.businessrules.tsh_Productos.GetByPk( IdProducto );
			GetDataProductos();	
			_state = BRTypes.ABMState.Baja;
		}
		private void ViewData( string codigo )
		{
			string IdProducto = mz.erp.businessrules.tsh_Productos.GetPkByCodigo( codigo );
			_rowProductos = mz.erp.businessrules.tsh_Productos.GetByPk( IdProducto );
			GetDataProductos();	
			_state = BRTypes.ABMState.Consulta;
		}
		private void InitializeData()
		{
			_tiposDeProductos = mz.erp.businessrules.tsy_TipoProducto.GetList().tsy_TipoProducto;
			SetLeyendaFormulario();
		}

		private void SetLeyendaFormulario()
		{	
			switch (_state)
			{	  
				case mz.erp.commontypes.BRTypes.ABMState.Alta :
					_leyendaFormulario = "Alta Producto";
					break;
				case mz.erp.commontypes.BRTypes.ABMState.Modificacion :
					_leyendaFormulario = "Modificacion de Producto";
					break;

			}
		}
		#endregion
	}
}

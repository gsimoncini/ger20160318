using System;
using System.Collections;
using System.Data;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using System.Data.SqlClient;
using mz.erp.dataaccess;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de CierreMasivoOrdenReparacion.
	/// </summary>
	public class CierreMasivoOrdenReparacion: ITask, IPersistentTask
	{

		#region Constructores

		public CierreMasivoOrdenReparacion()
		{
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
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.ListenerTaskDependentChanged
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.ListenerBeforeExecuteDependentTask
		}

		public void Init()
		{
			string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "CodigosEstadosOrdenReparacionACerrar";
			_codigosEstadosOrdenReparacionACerrar = Variables.GetValueString(variable);

			string variable1 = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "CodigosEstadosOrdenReparacionAAbrir";
			_codigosEstadosOrdenReparacionAAbrir = Variables.GetValueString(variable1);
			
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

		public bool IsValid()
		{
			ValidarDatos();
			if (_errores.Count > 0)
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
			bool cerrado = this._processParent.Process.ProcessName.Equals("ProcesoCierreMasivoOrdenReparacion");
			//foreach(EstadisticaOrdenReparacionView orden in _result)
			foreach(DataRow row in _resultAsTable.Rows)
			{
				//if(orden.Marca)
				if((bool)row["Marca"])
				{

					long IdOrdenReparacion = Convert.ToInt64(row["IdOrdenReparacion"]);
					st_EstadisticaOrdenReparacionDataset.st_EstadisticaOrdenReparacionRow rowEstOR = st_EstadisticaOrdenReparacion.GetByPk(IdOrdenReparacion);
					if(rowEstOR != null)
					{
						rowEstOR.Cerrado = cerrado;
						if(cerrado)
                            rowEstOR.FechaCierre = DateTime.Now;
						_dataEstadisticaOrdenReparacion.st_EstadisticaOrdenReparacion.ImportRow(rowEstOR);
					}
					else //No existe la fila
					{
						rowEstOR = _dataEstadisticaOrdenReparacion.st_EstadisticaOrdenReparacion.Newst_EstadisticaOrdenReparacionRow();
						rowEstOR.IdOrdenReparacion = IdOrdenReparacion;
						rowEstOR.Cerrado = cerrado;
						if(cerrado)
							rowEstOR.FechaCierre = DateTime.Now;
						rowEstOR["NumeroRemito"] = System.DBNull.Value;
						rowEstOR["TiempoDeEspera"] = System.DBNull.Value;
						rowEstOR.FechaCreacion = DateTime.Now;
						rowEstOR.IdConexionCreacion = Security.IdConexion;
						_dataEstadisticaOrdenReparacion.st_EstadisticaOrdenReparacion.Addst_EstadisticaOrdenReparacionRow(rowEstOR);
					}
				}

			}
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
			replication.NombreTabla = "dataaccess.st_EstadisticaOrdenReparacion";			
			return replication;
		}

		private bool _hasSaved = false;
		public bool GetHasSaved()
		{
			return _hasSaved;
		}
			 
		public void PutExtraData( ProcessCollectionData _processCollectionData )
		{

		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			
		}

		public ArrayList GetDataList()
		{
			ArrayList array = new ArrayList();			
			return array;
		}

		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();			
			data.Add(_dataEstadisticaOrdenReparacion);
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
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			dataaccess.st_EstadisticaOrdenReparacion.Update(_dataEstadisticaOrdenReparacion.st_EstadisticaOrdenReparacion, trx);
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}
		
		#endregion

		#region Variables privadas
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;		
		private st_EstadisticaOrdenReparacionDataset _dataEstadisticaOrdenReparacion = new st_EstadisticaOrdenReparacionDataset();
		private string _codigosEstadosOrdenReparacionACerrar;
		private string _codigosEstadosOrdenReparacionAAbrir;
		#endregion

		#region Eventos y Delegados
		#endregion

		#region Propiedades
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

		private string _leyendaFormulario = "Configuración de Menues";
		public string LeyendaFormulario
		{
			get 
			{		
				string valor = String.Empty;				
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "LeyendaFormulario";
				valor = Variables.GetValueString(variable);
				
				if (valor == String.Empty) 
				{
					return _leyendaFormulario;
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
				return _preguntarAlCancelar ;}
		}

		private ArrayList _result = new ArrayList();
		public ArrayList Result
		{
			get
			{
				return _result;
			}
		}

		private DataTable _resultAsTable = new DataTable();
		public DataTable ResultAsTable
		{
			get
			{
				return _resultAsTable;
			}
		}


		#endregion

		#region Métodos públicos
		public void RefreshData()
		{
			//_result = new ArrayList();
			if (this._processParent.Process.ProcessName.Equals("ProcesoCierreMasivoOrdenReparacion"))
                _resultAsTable = st_EstadisticaOrdenReparacion.ListarOrdenesACerrar(_codigosEstadosOrdenReparacionACerrar).Tables[0];
			else
				_resultAsTable = st_EstadisticaOrdenReparacion.ListarOrdenesAAbrir(_codigosEstadosOrdenReparacionAAbrir).Tables[0];
			_resultAsTable = AddColumn.AddColumnToTable(_resultAsTable, "Marca", true);
			_resultAsTable = AddColumn.AddColumnToTable(_resultAsTable, "Resultado", 0);
			foreach(DataRow row in _resultAsTable.Rows)
			{   
				decimal Diferencia = Convert.ToDecimal(row["Diferencia"]);
				int resultado = 0;
				if(Diferencia > 0)
					resultado = -1;
				else if(Diferencia < 0)
					resultado = 1;
				row["Resultado"] = resultado;

			}
		}
		#endregion

		#region Métodos Privados
		private void ValidarDatos()
		{
			_errores.Clear();
		}


		#endregion

	}

	public class EstadisticaOrdenReparacionView
	{
		public EstadisticaOrdenReparacionView(long IdOrdenReparacion, bool Cerrado, DateTime FechaCierre, string Cliente, string EstadoOrdenReparacion, bool Marca/*, string Estado*/)
		{
			_idOrdenReparacion = IdOrdenReparacion;
			_cerrado = Cerrado;
			_fechaCierre = FechaCierre;
			_cliente = Cliente;
			_estadoOrdenReparacion = EstadoOrdenReparacion;
			_marca = Marca;
			//_estado = Estado;
		}

		private long _idOrdenReparacion;
		public long IdOrdenReparacion 
		{
			get {return _idOrdenReparacion;}
		}

		private bool _cerrado;
		public bool Cerrado 
		{
			get {return _cerrado;}
			set {_cerrado = value;}
		}

		private DateTime _fechaCierre;
		public DateTime FechaCierre 
		{
			get {return _fechaCierre;}
			set {_fechaCierre = value;}
		}

		private string _cliente;
		public string Cliente 
		{
			get {return _cliente;}
		}
		
		private string _estadoOrdenReparacion;
		public string EstadoOrdenReparacion 
		{
			get {return _estadoOrdenReparacion;}
		}

		private bool _marca;
		public bool Marca 
		{
			get {return _marca;}
			set{_marca = value;}
		}

		private string _estado;
		public string Estado 
		{
			get {return _estado;}
			set {_estado = value;}
		}


	}


}

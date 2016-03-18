using System;
using mz.erp.dataaccess;
using System.Collections;
using mz.erp.commontypes.data;
using System.Data.SqlClient;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de AbmDomicilios.
	/// </summary>
	public class AbmDomicilios: ITask, IPersistentTask
	{
		#region Constructores
		public AbmDomicilios()
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
			PreguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar");
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
			_data = _domicilio.Commit(_data);
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
			replication.NombreTabla = "dataaccess.tcs_Domicilios";			
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
			data.Add(_data);
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
			dataaccess.tcs_Domicilios.Update(_data.tcs_Domicilios, trx);

			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}
		
		#endregion

		#region Variables privadas
		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;		
		private tcs_DomiciliosDataset _data = new tcs_DomiciliosDataset();		
		private DomicilioCuenta _domicilio;
		#endregion

		#region Eventos y delegados	
		#endregion

		#region Métodos públicos		
		
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

		private string _leyendaFormulario = "Modificar y Agregar Domicilios";
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
		private bool _preguntarAlCancelar = false;
		public bool PreguntarAlCancelar
		{
			get {return _preguntarAlCancelar ;}
			set {_preguntarAlCancelar =value;}
		}
		public DomicilioCuenta Domicilio
		{
			get{return _domicilio;}
			set{_domicilio = value;}
		}

		#endregion

		#region Métodos Privados
		#endregion
	}
}

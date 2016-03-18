using System;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ComprobanteDeCompraCabecera.
	/// </summary>
	public class ComprobanteDeCompraCabecera: ITask, IPersistentTask
	{
		public ComprobanteDeCompraCabecera()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#region Variables Privadas

			private string _taskName = string.Empty;
			private bool _isValid = false;		
			private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
			private ProcessManager _processParent;
			private mz.erp.commontypes.SentenciasReplicacion _replication;

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
			bool IsValid = true;
			_errores.Clear();			
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

		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();
			return data;
		}

		public void Commit()
		{
			// TODO: agregar la implementación ComprobanteDeCompraCabecera.Commit
		}

		public void Flush(string IdTransaction)
		{
			// TODO: agregar la implementación ComprobanteDeCompraCabecera.Flush
		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			// TODO: agregar la implementación ComprobanteDeCompraCabecera.PutExtraDataOnCommit
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
			// TODO: agregar la implementación ComprobanteDeCompraCabecera.PutExtraData
		}

		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			// TODO: agregar la implementación ComprobanteDeCompraCabecera.GetSentenceReplication
			return null;
		}

		public bool GetHasSaved()
		{
			// TODO: agregar la implementación ComprobanteDeCompraCabecera.GetHasSaved
			return false;
		}

		#endregion
	}
}

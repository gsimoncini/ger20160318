using System;
using System.Collections;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de SeleccionComprobanteDestino.
	/// </summary>
	public class SeleccionComprobanteDestino : ITask
	{
		public SeleccionComprobanteDestino()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		
		#region Variables Privadas

			private ProcessManager _processManager;
			private string _taskName;
			private long _idTask;
			private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
			

		#endregion

		#region Variables Publicas
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
		public void ListenerAfterExecuteDependentTask( object sender ){}
		public void ListenerBeforeExecuteDependentTask( object sender ){}
		public void Init()
		{
				this._idTask = Workflow.GetIdTakByName(this._taskName);
		}

		public bool IsValid()
		{
			// TODO: agregar la implementación SeleccionComprobanteDestino.IsValid
			return false;
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
			return true;
		}
		public void FormHasClosed() 
		{
		}

		public ItemsDatasetErrors GetErrors()
		{
			// TODO: agregar la implementación SeleccionComprobanteDestino.GetErrors
			return null;
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
	}
}

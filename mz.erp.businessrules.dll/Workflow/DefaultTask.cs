using System;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de DefaultTask.
	/// </summary>
	public class DefaultTask : ITask
	{
		public DefaultTask()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#region Variables Privadas ITask

		protected string _taskName = string.Empty;		
		protected ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		protected ProcessManager _processParent;

		#endregion


		#region Miembros de ITask

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
			
		}

		public virtual void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}

		public virtual void Init()
		{
			
		}

		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			return true;
		}

		public virtual bool IsValid()
		{
			_errores.Clear();
			return true;
		}

		public virtual bool AllowShow() 
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

		public virtual string GetWarnings()
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

		public virtual void Previous()
		{
			
		}

		public virtual void ListenerAfterPreviousDependentTask(object sender)
		{
			
		}

		public virtual void ListenerBeforePreviousDependentTask(object sender)
		{
			
		}

		#endregion
	}
}

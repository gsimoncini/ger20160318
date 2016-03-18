using System;
using mz.erp.businessrules;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de DefaultController.
	/// </summary>
	public class DefaultController : ITaskController	
	{
		public DefaultController(ITask task)
		{
			_task = task;
			Init();

		}

		private void Init()
		{
			InitEvents();
		}

		private void InitEvents()
		{
			this._task.OnTaskAfterExecute +=new EventHandler(AfterExecute);
		}

		private ITask _task;

		public event EventHandler OnTaskAfterExecute;

		#region Miembros de ITaskController

		public bool IsFlushedState()
		{
			return this._processManager.ProcessFlushed;
		}

		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_task.GetTaskName());
		}

		private ProcessControllerManager _processManager;
		public void SetProcessManager(ProcessControllerManager processManager)
		{
			_processManager = processManager;
		}
		public ProcessControllerManager GetProcessManager()
		{
			return _processManager;
		}

		public string GetTaskName()
		{
			return _task.GetTaskName();
		}


		public bool AllowPrevious()
		{
			return _task.AllowPrevious();
		}

		public void Previous()
		{
			_task.Previous();
		}


		public mz.erp.businessrules.ItemsDatasetErrors GetErrors()
		{
			return _task.GetErrors();
		}
		public string GetWarnings()
		{
			return null;
		}
		public void Continue()
		{
		}


		public void Execute()
		{
			this._task.Execute();
		}

		public bool AllowShow()
		{
			
			return false;
		}

		#endregion

		private void AfterExecute(object sender, EventArgs e)
		{
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}

		public bool IsNextState()
		{
			return this._processManager.IsNextState();	
		}

		public bool IsBackState()
		{	
			return this._processManager.IsBackState();
		}
	}
}

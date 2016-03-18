using System;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ITask.
	/// </summary>
	public interface ITask
	{
		#region Eventos
			event System.EventHandler ObjectHasChanged;
			event System.EventHandler OnTaskBeforeExecute;
			event System.EventHandler OnTaskAfterExecute;
			event System.EventHandler OnTaskBeforePrevious;
			event System.EventHandler OnTaskAfterPrevious;
		
			
		#endregion
		

		#region Metodos
			void ListenerTaskDependentChanged(object sender);
			void ListenerAfterExecuteDependentTask( object sender );
			void ListenerBeforeExecuteDependentTask( object sender );
			void Init();
			bool IsValid();
			bool IsValidForStartProcess();
			bool AllowShow();
			ItemsDatasetErrors GetErrors();
		    string GetWarnings();
			ProcessManager GetProcessManagerParent();
			void SetProcessManagerParent(ProcessManager processManager);
			string GetTaskName();
			void SetTaskName(string taskName);
			void Execute();
			bool AllowPrevious();
			void Previous();
			void FormHasClosed();
			void ListenerAfterPreviousDependentTask( object sender );
			void ListenerBeforePreviousDependentTask( object sender );
			
			
		#endregion

	}
	
	
}

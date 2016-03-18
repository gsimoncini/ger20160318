using System;
using mz.erp.businessrules;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ITaskController.
	/// </summary>
	public interface ITaskController
	{
		
		/// <summary>
		/// </summary>
		/// <returns> Retorna un String q es el mensaje a mostrar en el Warning</returns>
		string GetWarnings();
		/// <summary>
		/// Se llama a este método solo despues de mostrar un warning (al precionar aceptar)
		/// </summary>
		void Continue();
		ItemsDatasetErrors GetErrors();
		void Execute();
		bool AllowShow();
		bool AllowPrevious();
		void Previous();
		void SetProcessManager(ProcessControllerManager processManager);
		ProcessControllerManager GetProcessManager();
		bool IsFirstTask();
		bool IsNextState();
		bool IsBackState();
		bool IsFlushedState();
		string GetTaskName();

		
	}
}

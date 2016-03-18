using System;
using mz.erp.commontypes;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de IObservableController.
	/// </summary>
	public interface IObservableController: IObservable
	{
		void AddTaskController(ITaskController controller);
	}
}

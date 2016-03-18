using System;

namespace mz.erp.commontypes
{
	/// <summary>
	/// Descripción breve de IObservable.
	/// </summary>
	public interface IObservable
	{
		void AddObjectListener(IObserver observer);
		void ProcessObjectsObserver();

	}
}

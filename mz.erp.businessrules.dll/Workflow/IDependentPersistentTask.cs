using System;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de IDependentPersistentTask.
	/// </summary>
	public interface IDependentPersistentTask
	{
	
		void ListenerAfterFlush(object sender);
		void ListenerBeforeFlush(object sender);

	}
}

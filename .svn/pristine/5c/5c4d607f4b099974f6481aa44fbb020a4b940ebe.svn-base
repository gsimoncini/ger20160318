using System;
using System.Text;
using System.Collections;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de IDependentPersistentTask.
	/// </summary>
	public interface IValidateAfterFlush
	{
	
		ItemsDatasetErrors GetFlushErrors();
		StringBuilder GetMailContent();
		StringBuilder GetExceptionContent();
		bool IsValidFlush(ArrayList Tasks);

	}
}

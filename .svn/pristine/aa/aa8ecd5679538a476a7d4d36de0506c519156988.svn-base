using System;
using System.Collections;
using System.Data;
using mz.erp.commontypes;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de IPersistentTask.
	/// </summary>
	public interface IPersistentTask: ITaskBeforeFlush
	{
		
		#region Eventos

			event System.EventHandler OnTaskBeforeFlush;
			event System.EventHandler OnTaskAfterFlush;

		#endregion
		
		#region Metodos
			
			//ArrayList GetDataList();
			TaskCollectionData GetData();
			void Commit();
			void Flush(string IdTransaction);
			void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData);
			void PutExtraData( ProcessCollectionData _processCollectionData );
			mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication();
			bool GetHasSaved();

		#endregion
	}
}

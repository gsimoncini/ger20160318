using System;
using mz.erp.commontypes;

namespace mz.erp.businessrules.transactionmanager
{
	/// <summary>
	/// Descripci�n breve de SentenciasReplicacion.
	/// </summary>
	public class SentenciasReplicacion
	{
		public SentenciasReplicacion()
		{
			//
			// TODO: agregar aqu� la l�gica del constructor
			//
		}

		public static void Flush(string IdTransaction, mz.erp.commontypes.SentenciasReplicacion replicacion)
		{	
			replicacion.Update();
			mz.erp.dataaccess.sy_SentenciasReplicacion.Update(replicacion.Data.sy_SentenciasReplicacion,IdTransaction);
		}
	}
}

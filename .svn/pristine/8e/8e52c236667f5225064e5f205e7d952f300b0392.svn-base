using System;
using mz.erp.commontypes;

namespace mz.erp.businessrules.transactionmanager
{
	/// <summary>
	/// Descripción breve de SentenciasReplicacion.
	/// </summary>
	public class SentenciasReplicacion
	{
		public SentenciasReplicacion()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static void Flush(string IdTransaction, mz.erp.commontypes.SentenciasReplicacion replicacion)
		{	
			replicacion.Update();
			mz.erp.dataaccess.sy_SentenciasReplicacion.Update(replicacion.Data.sy_SentenciasReplicacion,IdTransaction);
		}
	}
}

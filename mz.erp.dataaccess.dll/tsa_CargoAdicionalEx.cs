using System;
using System.Data.SqlClient;
using mz.erp.commontypes;


namespace mz.erp.dataaccess
{
	/// <summary>
	/// Descripción breve de tsa_CargoAdicionalEx.
	/// </summary>
	public class tsa_CargoAdicionalEx
	{
		public tsa_CargoAdicionalEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		private static SentenciasReplicacion _replication;

		public static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
		{
			try
			{
		
				StatementSQLForReplicationFactory.GetSqlStatement(e.Command, _replication.Sentence);
				if(_replication.IdTipoDeSentencia == null || _replication.IdTipoDeSentencia.Equals(string.Empty))
					_replication.IdTipoDeSentencia = e.StatementType.ToString().ToUpper();
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			
			
		}

		public static void Update( mz.erp.commontypes.data.tlg_FleteExDataset data , SentenciasReplicacion replicacion, string IdTransaction)
		{
			try
			{
				SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
				Update( data , trx , replicacion);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				//data.tsa_Comprobantes.Rows[0].SetColumnError("IdComprobante","No se ha podido realizar la grabación por un error en los datos");
			}
		}

		public static void Update( mz.erp.commontypes.data.tlg_FleteExDataset data , SqlTransaction trx , SentenciasReplicacion replicacion)
		{
			tsa_ComprobanteCargoAdicional.Update( data.Tables["tsa_ComprobanteCargoAdicional"], trx, replicacion);	
			tlg_Flete.Update( data.Tables["tlg_Flete"], trx, replicacion);							
		}
	}
}

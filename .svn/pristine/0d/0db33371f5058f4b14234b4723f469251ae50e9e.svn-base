using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.dataaccess;
using mz.erp.systemframework;


namespace mz.erp.dataaccess
{
	/// <summary>
	/// Descripción breve de tsh_ConversionesEx.
	/// </summary>
	public class tsh_ConversionesEx
	{
		public tsh_ConversionesEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		private static SentenciasReplicacion _replicacion;

		public static SentenciasReplicacion Replicacion
		{
			set
			{
				_replicacion = value;
			}
		}

		public static void Update( DataSet data ,SentenciasReplicacion Replicacion)
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				tsh_Conversiones.Update( data.Tables["tsh_Conversiones"], trx, Replicacion);
				tsh_DetalleConversiones.Update(data.Tables["tsh_DetalleConversiones"], trx,Replicacion);
				Replicacion.Update();
				mz.erp.dataaccess.sy_SentenciasReplicacion.Update(Replicacion.Data.sy_SentenciasReplicacion, trx);
				trx.Commit();
			}
			catch(Exception re)
			{
				trx.Rollback();
			}
			finally
			{
				cnx.Close();
			}
		}

		public static void Update(DataSet data, SqlTransaction trx)
		{
		
			tsh_Conversiones.Update( data.Tables["tsh_Conversiones"], trx, _replicacion);
			tsh_DetalleConversiones.Update(data.Tables["tsh_DetalleConversiones"], trx, _replicacion);

		}


	}
}

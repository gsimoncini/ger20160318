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
	/// Descripción breve de tsa_CondicionesDeVentasEx.
	/// </summary>
	public class tsa_CondicionesDeVentasEx
	{
		public tsa_CondicionesDeVentasEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

	/*	
		private static SentenciasReplicacion _replicacion;

		public static SentenciasReplicacion Replicacion
		{
			set
			{
				_replicacion = value;
			}
		}
	*/	

		public static void Update( DataSet data ,SentenciasReplicacion Replicacion)
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();
			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );
			try
			{		
				tsa_CondicionesDeVentas.Update( (System.Data.DataTable)data.Tables["tsa_CondicionesDeVentas"], trx);
				tsa_CondicionesDeVentaDet.Update((System.Data.DataTable)data.Tables["tsa_CondicionesDeVentaDet"], trx);
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
		
			tsa_CondicionesDeVentas.Update( data.Tables["tsa_CondicionesDeVentas"], trx);
			tsa_CondicionesDeVentaDet.Update(data.Tables["tsa_CondicionesDeVentaDet"], trx);

		}

	}
}

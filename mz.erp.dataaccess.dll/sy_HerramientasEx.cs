using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
    
using mz.erp.dbhelper;
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

namespace mz.erp.dataaccess
{
	/// <summary>
	/// Descripción breve de sy_HerramientasEx.
	/// </summary>
	public class sy_HerramientasEx
	{
		public sy_HerramientasEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

				
		public static void Update(sy_HerramientasExDataset data )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				mz.erp.dataaccess.sy_Herramientas.Update( data.sy_Herramientas, trx );
				mz.erp.dataaccess.sy_PerfilesHerramientas.Update(data.sy_PerfilesHerramientas,trx);
				mz.erp.dataaccess.sy_BarrasHerramientasHerramientas.Update(data.sy_BarrasHerramientasHerramientas,trx);
				mz.erp.dataaccess.sy_Recursos.Update(data.sy_Recursos,trx);
				mz.erp.dataaccess.sy_HerramientasRecursosIdiomas.Update(data.sy_HerramientasRecursosIdiomas,trx);

				trx.Commit();
			}
			catch(Exception e)
			{
				trx.Rollback();
				//Debug.WriteLine(e.Message);
			}
			finally
			{
				cnx.Close();
			}
		}

		public static void Update(sy_HerramientasExDataset data , SentenciasReplicacion replicacion )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				mz.erp.dataaccess.sy_Herramientas.Update( data.sy_Herramientas, trx, replicacion );
				mz.erp.dataaccess.sy_PerfilesHerramientas.Update(data.sy_PerfilesHerramientas,trx, replicacion );
				mz.erp.dataaccess.sy_BarrasHerramientasHerramientas.Update(data.sy_BarrasHerramientasHerramientas,trx, replicacion );
				mz.erp.dataaccess.sy_Recursos.Update(data.sy_Recursos,trx, replicacion );
				mz.erp.dataaccess.sy_HerramientasRecursosIdiomas.Update(data.sy_HerramientasRecursosIdiomas,trx, replicacion );

				trx.Commit();
			}
			catch(Exception e)
			{
				trx.Rollback();
				//Debug.WriteLine(e.Message);
			}
			finally
			{
				cnx.Close();
			}
		}
	}
}

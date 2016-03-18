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
	/// Descripción breve de tui_ConfiguracionGrillaEstilosAplicablesPerfilesEx.
	/// </summary>
	public class tui_ConfiguracionGrillaEstilosAplicablesPerfilesEx
	{
		public tui_ConfiguracionGrillaEstilosAplicablesPerfilesEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static void Update( tui_ConfiguracionGrillaEstilosAplicablesPerfilesExDataset data , SentenciasReplicacion replicacion)
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				tui_ConfiguracionGrillaEstilosCondicionalesPerfiles.Update( data.Tables["tui_ConfiguracionGrillaEstilosCondicionalesPerfiles"], trx, replicacion);							
				tui_ConfiguracionGrillaEstilosCondicionalesDetPerfiles.Update( data.Tables["tui_ConfiguracionGrillaEstilosCondicionalesDetPerfiles"], trx, replicacion);							
				tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfiles.Update(data.Tables["tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosPerfiles"], trx, replicacion);				
				tui_ConfiguracionGrillaEstilosAplicablesPerfiles.Update(data.Tables["tui_ConfiguracionGrillaEstilosAplicablesPerfiles"], trx, replicacion);
				replicacion.Update();
				mz.erp.dataaccess.sy_SentenciasReplicacion.Update(replicacion.Data.sy_SentenciasReplicacion, trx);
			
				trx.Commit();
			}
			catch (System.Exception e )
			{
				trx.Rollback();
				//Logger.ApplicationLog.WriteError(e.ToString());
				data.tui_ConfiguracionGrillaEstilosCondicionalesPerfiles.Rows[0].SetColumnError("IdConfiguracion","No se ha podido realizar la grabación por un error en los datos");
			}
			finally
			{
				cnx.Close();				
			}
		}


	}
}

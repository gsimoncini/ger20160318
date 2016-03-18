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
	/// Descripción breve de tui_ConfiguracionGrillaEstilosAplicablesUsuariosEx.
	/// </summary>
	public class tui_ConfiguracionGrillaEstilosAplicablesUsuariosEx
	{
		public tui_ConfiguracionGrillaEstilosAplicablesUsuariosEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static void Update( tui_ConfiguracionGrillaEstilosAplicablesUsuariosExDataset data , SentenciasReplicacion replicacion)
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.Update( data.Tables["tui_ConfiguracionGrillaEstilosCondicionalesUsuarios"], trx, replicacion);							
				tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.Update( data.Tables["tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios"], trx, replicacion);							
				tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.Update(data.Tables["tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios"], trx, replicacion);				
				tui_ConfiguracionGrillaEstilosAplicablesUsuarios.Update(data.Tables["tui_ConfiguracionGrillaEstilosAplicablesUsuarios"], trx, replicacion);
				replicacion.Update();
				mz.erp.dataaccess.sy_SentenciasReplicacion.Update(replicacion.Data.sy_SentenciasReplicacion, trx);
			
				trx.Commit();
			}
			catch (System.Exception e )
			{
				trx.Rollback();
				//Logger.ApplicationLog.WriteError(e.ToString());
				data.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.Rows[0].SetColumnError("IdConfiguracion","No se ha podido realizar la grabación por un error en los datos");
			}
			finally
			{
				cnx.Close();				
			}
		}


	}
}

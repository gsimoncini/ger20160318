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
	/// Descripción breve de tui_ConfiguracionGrillaEstiloAplicadoEx.
	/// </summary>
	public class tui_ConfiguracionGrillaEstiloAplicadoEx
	{

		public tui_ConfiguracionGrillaEstiloAplicadoEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static void Update( tui_ConfiguracinGrillaEstiloAplicadoExDataset data , SentenciasReplicacion replicacion)
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				tui_ConfiguracionGrillaEstilosCondicionales.Update( data.Tables["tui_ConfiguracionGrillaEstilosCondicionales"], trx, replicacion);							
				tui_ConfiguracionGrillaEstiloAplicado.Update( data.Tables["tui_ConfiguracionGrillaEstiloAplicado"], trx, replicacion);
				tui_ConfiguracionGrillaEstilosCondicionalesDet.Update( data.Tables["tui_ConfiguracionGrillaEstilosCondicionalesDet"], trx, replicacion);							
				tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados.Update(data.Tables["tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicados"], trx, replicacion);				
				tui_ConfiguracionGrillaEstilosAplicables.Update(data.Tables["tui_ConfiguracionGrillaEstilosAplicables"], trx, replicacion);
				replicacion.Update();
				mz.erp.dataaccess.sy_SentenciasReplicacion.Update(replicacion.Data.sy_SentenciasReplicacion, trx);
			
				trx.Commit();
			}
			catch (System.Exception e )
			{
				trx.Rollback();
				//Logger.ApplicationLog.WriteError(e.ToString());
				data.tui_ConfiguracionGrillaEstilosCondicionales.Rows[0].SetColumnError("IdConfiguracion","No se ha podido realizar la grabación por un error en los datos");
			}
			finally
			{
				cnx.Close();				
			}
		}
	}
}

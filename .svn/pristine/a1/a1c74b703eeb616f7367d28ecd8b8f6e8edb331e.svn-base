using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace mz.erp.dataaccess
{
	/// <summary>
	/// Descripción breve de Util.
	/// </summary>
	public class Sistema
	{
		public Sistema()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		

		public static System.Data.DataTable GetStoredProcedureColumnsList(string SPName)
		{
			System.Data.DataSet data = new DataSet();
			SqlCommand cmd = new SqlCommand( "Pr_GetStoreProcedureColumns", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@StoredProcedure", SqlDbType.VarChar ));
			cmd.Parameters[ "@StoredProcedure"].Value = SPName;
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Pr_GetStoreProcedureColumns" );
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			return data.Tables[0];
		}

		public static System.Data.DataTable ExecuteSQLStatement (string SQL) 
		{
			System.Data.DataSet data = new DataSet();
			SqlCommand cmd = new SqlCommand( SQL, dbhelper.Connection.GetConnection() );			
			cmd.CommandType = CommandType.Text;			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Columns" );
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			return data.Tables[0];
		}


		public static System.Data.DataTable GetStoredProceduresList()
		{
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_GetStoredProcedures", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
		
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_GetStoredProcedures" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data );
				return data.Tables[0];
		}

		
		public static System.Data.DataRow GetBDCurrentVersion()
		{
			try
			{
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_sy_Versiones_GetCurrent", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
		
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_sy_Versiones_GetCurrent" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data );

				if (data.Tables[0].Rows.Count > 0)
				{
					return data.Tables[0].Rows[0];
				}
				else
				{
					return null;
				}
					
			}
			catch(Exception e){;return null;}
		

		}

		public static System.Data.DataRow GetLastProcessedInfo()
		{
			try
			{
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_sy_ReplicationMonitor_GetLastProcessed", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
		
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_sy_ReplicationMonitor" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data );

				if (data.Tables[0].Rows.Count > 0)
				{
					return data.Tables[0].Rows[0];
				}
				else
				{
					return null;
				}
					
			}
			catch(Exception e){;return null;}


		}

		public static void SetApplicationState(int levelError)
		{
			try
			{
				SqlCommand cmd = new SqlCommand( "Pr_sy_ApplicationState_Update", dbhelper.Connection.GetConnection()  );
				cmd.Connection.Open();
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add( new SqlParameter( "@FechaUltimaModificacion", SqlDbType.DateTime ));
				cmd.Parameters[ "@FechaUltimaModificacion"].Value = DateTime.Now;
				cmd.Parameters.Add( new SqlParameter( "@IdLevelError", SqlDbType.BigInt ));
				cmd.Parameters[ "@IdLevelError"].Value = levelError;
				cmd.ExecuteNonQuery();
				
				
			}
			catch(Exception e){System.Console.WriteLine(e.Message);}

		}

		public static DateTime GetLastProcessed()
		{
			System.Data.DataSet data = new DataSet();
			SqlCommand cmd = new SqlCommand( "Pr_sy_ReplicationMonitorLastProcessed", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Pr_sy_ReplicationMonitor" );
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			if(data.Tables[0].Rows.Count > 0 )
				return (DateTime) data.Tables[0].Rows[0][0];
			else return DateTime.MinValue;

		}

		public static DateTime GetDbTime()
		{
			System.Data.DataSet data = new DataSet();
			SqlCommand cmd = new SqlCommand( "Select GetDate() as Fecha", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.Text;
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "SystemTime" );
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			if (data.Tables.Count>0)
			{
				if(data.Tables[0].Rows.Count > 0 )
					return (DateTime) data.Tables[0].Rows[0][0];
				else return DateTime.MinValue;
			}
			else return DateTime.MinValue;
		}

		public static Int32 GetTimeout(string StoredProcedure)
		{
			Int32 timeout = 30;			
			Int32 timeoutVar = Variables.GetValueInt("Sistema.Timeout." + StoredProcedure);								
			if (timeoutVar == Int32.MinValue)
			{
				timeoutVar = Variables.GetValueInt("Sistema.Timeout.Default");
			}				
			if (timeoutVar == Int32.MinValue)
				return timeout;			
			else 			
				return timeoutVar;
		}
	}
}

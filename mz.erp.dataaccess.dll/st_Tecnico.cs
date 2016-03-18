using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

using mz.erp.dbhelper;
using mz.erp.systemframework;
using mz.erp.commontypes.data;

namespace mz.erp.dataaccess
{
	/// <summary>
	/// Descripción breve de st_Tecnico.
	/// </summary>
	public class st_Tecnico
	{

		#region Custom Members
		public static st_TecnicoDataset GetList(string Habilitado)
		{
			st_TecnicoDataset data = new st_TecnicoDataset();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "st_Tecnico" );

			
			SqlCommand cmd = new SqlCommand( "Pr_st_Tecnico_SearchByHabilitado", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@Habilitado", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Habilitado" ].Value = Habilitado;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}
	
		#endregion

		public st_Tecnico()
		{
		}

		public static st_TecnicoDataset GetList()
		{
			st_TecnicoDataset data = new st_TecnicoDataset();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "st_Tecnico" );

			
			SqlCommand cmd = new SqlCommand( "Pr_st_Tecnico_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

	}
}

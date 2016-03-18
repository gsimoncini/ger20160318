using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

using mz.erp.dbhelper;
using mz.erp.systemframework;

namespace mz.erp.dataaccess
{
	/// <summary>
	/// Descripción breve de st_EstadoOrdenReparacion.
	/// </summary>
	public class st_EstadoOrdenReparacion
	{
		public st_EstadoOrdenReparacion()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		
		
		public static DataRow GetByPk(string IdEstado)
		{
			
				DataSet data = new DataSet();

				SqlCommand cmd = new SqlCommand( "sp_st_EstadoOrdenReparacion_Get", dbhelper.Connection.GetConnection()  );
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@IdEstadoOrdenReparacion", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdEstadoOrdenReparacion" ].Value = IdEstado;
			
				SqlDataAdapter adapter = new SqlDataAdapter( cmd );
				adapter.TableMappings.Add( "Table", "st_Estados" );

				adapter.Fill( data );

				if ( data.Tables[0].Rows.Count == 1 )
				{
					return data.Tables[0].Rows[ 0 ];
				}
			
				return null;
			
		}

		public static DataSet GetList(string IdEstados)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "st_EstadosFiltrados" );

			
			SqlCommand cmd = new SqlCommand( "sp_st_EstadoOrdenReparacion_GetListFilter", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@IdEstadosPermitidos", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdEstadosPermitidos" ].Value = IdEstados;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static DataSet GetList()
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "st_EstadoOrdenReparacion" );

			
			SqlCommand cmd = new SqlCommand( "Pr_st_EstadoOrdenReparacion_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}
	}
}

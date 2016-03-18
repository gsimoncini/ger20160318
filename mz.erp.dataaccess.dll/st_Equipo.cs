using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Text;
    
using mz.erp.dbhelper;
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

namespace mz.erp.dataaccess
{
	/// <summary>
	/// Descripción breve de st_Equipo.
	/// </summary>
	public class st_Equipo
	{
		public st_Equipo()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static DataRow GetByPk( string IdEquipo )
		{
			DataSet data = new DataSet();

			SqlCommand cmd = new SqlCommand( "sp_st_Equipo_Get", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdEquipo", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdEquipo" ].Value = IdEquipo;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "st_Equipo" );

			adapter.Fill( data );

			if ( data.Tables[0].Rows.Count == 1 )
			{
				return data.Tables[0].Rows[ 0 ];
			}
			
			return null;
		}

	}
}

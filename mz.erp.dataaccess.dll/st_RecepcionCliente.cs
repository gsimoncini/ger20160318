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
	/// Descripción breve de st_RecepcionCliente.
	/// </summary>
	public class st_RecepcionCliente
	{
		public st_RecepcionCliente()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static DataRow GetByPk( string IdRecepcionCliente )
		{
			DataSet data = new DataSet();

			SqlCommand cmd = new SqlCommand( "sp_st_RecepcionCliente_Get", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdRecepcionCliente", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdRecepcionCliente" ].Value = Convert.ToInt32(IdRecepcionCliente);
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "st_RecepcionCliente" );

			adapter.Fill( data );

			if ( data.Tables[0].Rows.Count == 1 )
			{
				return data.Tables[0].Rows[ 0 ];
			}
			
			return null;
		}
	}
}

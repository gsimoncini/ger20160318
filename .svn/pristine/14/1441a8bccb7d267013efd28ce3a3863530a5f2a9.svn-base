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
	/// Descripción breve de st_InstanciaOrdenReparacion.
	/// </summary>
	public class st_InstanciaOrdenReparacion
	{
		public st_InstanciaOrdenReparacion()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static DataSet GetList(long IdOrdenReparacion)
		{
			DataSet data = new DataSet();

			SqlCommand cmd = new SqlCommand( "sp_st_InstanciaOrdenReparacion_GetList", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdOrdenReparacion" ].Value = Convert.ToInt32(IdOrdenReparacion);
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "st_OrdenReparacion" );

			adapter.Fill( data );

			return data;
		}

	}
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace mz.erp.dataaccess.reportes
{
	/// <summary>
	/// Descripción breve de rep_ListadoDeArtDesacConStock.
	/// </summary>
	public class rep_ListadoDeArtDesacConStock
	{
		public rep_ListadoDeArtDesacConStock()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public static System.Data.DataSet GetList( long IdEmpresa, long IdSucursal )
		{		
			System.Data.DataSet data = new System.Data.DataSet();
			try
			{
				SqlCommand cmd = new SqlCommand( "Pr_ArticulosDesactivadosConStock", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
				
				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
				cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
				
				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
				cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;
				
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "RP_tsh_ReporteActualizacionPrecios" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);

				return data;
			}
			catch(Exception e){;return null;}
			return null;
		}
	}
}

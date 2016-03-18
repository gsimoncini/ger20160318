using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace mz.erp.dataaccess.reportes
{
	/// <summary>
	/// Descripción breve de rep_DetalleListadoDeComprasPorArt.
	/// </summary>
	public class rep_DetalleListadoDeComprasPorArt
	{
		public rep_DetalleListadoDeComprasPorArt()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static System.Data.DataSet GetList( string  IdComprobante, string IdProducto )
		{		
			System.Data.DataSet data = new System.Data.DataSet();
			try
			{
				SqlCommand cmd = new SqlCommand( "PR_Compras_DetalleListadoDeComprasPorArticulo", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
				
				cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ));
				if (IdComprobante != null && IdComprobante.Equals(String.Empty)) cmd.Parameters[ "@IdComprobante"].Value = System.DBNull.Value; 
				else {cmd.Parameters[ "@IdComprobante"].Value = IdComprobante;}		
				
				cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ));
				if (IdProducto != null && IdProducto.Equals(String.Empty)) cmd.Parameters[ "@IdProducto"].Value = System.DBNull.Value; 
				else {cmd.Parameters[ "@IdProducto"].Value = IdProducto;}		

				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Table" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);

				return data;
			}
			catch(Exception e){;return null;}
			return null;
		}
	}
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace mz.erp.dataaccess.reportes
{
	/// <summary>
	/// Descripción breve de rep_ListadoDeComprasPorArt.
	/// </summary>
	public class rep_ListadoDeComprasPorArt
	{
		public rep_ListadoDeComprasPorArt()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static System.Data.DataSet GetList( DateTime FechaDesde, DateTime FechaHasta, string Producto, long IdEmpresa, long IdSucursal )
		{//ST 		
			System.Data.DataSet data = new System.Data.DataSet();
			try
			{
				SqlCommand cmd = new SqlCommand( "PR_Compras_ListadoDeComprasPorArticulo", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
				
				cmd.Parameters.Add( new SqlParameter( "@FechaIni", SqlDbType.DateTime ));
				if (FechaDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@FechaIni"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(FechaDesde.Year,FechaDesde.Month,FechaDesde.Day,0, 0, 0, 0);
					cmd.Parameters[ "@FechaIni"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@FechaFin", SqlDbType.DateTime ));
				if (FechaHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@FechaFin"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(FechaHasta.Year,FechaHasta.Month,FechaHasta.Day,23,59,0,0);
					cmd.Parameters[ "@FechaFin"].Value = h;
				}
				
				cmd.Parameters.Add( new SqlParameter( "@idarticulo", SqlDbType.VarChar ));
				if (Producto != null && Producto.Equals(String.Empty)) cmd.Parameters[ "@Idarticulo"].Value = System.DBNull.Value; 
				else {cmd.Parameters[ "@IdArticulo"].Value = Producto;}				
				
				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
				cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
				
				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
				cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;
				
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "RP_Compras_ListadoDeComprasPorArticulo" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);

				return data;
			}
			catch(Exception e)
			{
				return null;
			}
		}

	}
}

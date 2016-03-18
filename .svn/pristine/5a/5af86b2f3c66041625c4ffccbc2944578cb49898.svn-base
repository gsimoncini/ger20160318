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

		public static System.Data.DataSet GetList( DateTime FechaDesde, DateTime FechaHasta, string Producto, string IdProveedor,string Numero, string Aux1,string IdTiposDeComprobantes, long IdEmpresa, long IdSucursal )
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
		
				cmd.Parameters.Add( new SqlParameter( "@idProveedor", SqlDbType.VarChar ));
				if (IdProveedor != null && IdProveedor.Equals(String.Empty)) cmd.Parameters[ "@IdProveedor"].Value = System.DBNull.Value; 
				else {cmd.Parameters[ "@IdProveedor"].Value = IdProveedor;}	
	
				cmd.Parameters.Add( new SqlParameter( "@Numero", SqlDbType.VarChar ));
				if (Numero != null && Numero.Equals(String.Empty)) cmd.Parameters[ "@Numero"].Value = System.DBNull.Value; 
				else {cmd.Parameters[ "@Numero"].Value = Numero;}
	
				cmd.Parameters.Add( new SqlParameter( "@Aux1", SqlDbType.VarChar ));
				if (Aux1 != null && Aux1.Equals(String.Empty)) cmd.Parameters[ "@Aux1"].Value = System.DBNull.Value; 
				else {cmd.Parameters[ "@Aux1"].Value = Aux1;}	
				
				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
				cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
				
				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
				cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;

				cmd.Parameters.Add( new SqlParameter( "@IdTiposDeComprobantes", SqlDbType.VarChar ));
				if (IdTiposDeComprobantes != null && IdTiposDeComprobantes.Equals(String.Empty)) cmd.Parameters[ "@IdTiposDeComprobantes"].Value = System.DBNull.Value; 
				else {cmd.Parameters[ "@IdTiposDeComprobantes"].Value = IdTiposDeComprobantes;}				
				
				
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

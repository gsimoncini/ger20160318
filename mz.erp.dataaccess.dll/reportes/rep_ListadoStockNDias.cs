using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace mz.erp.dataaccess.reportes
{
	/// <summary>
	/// Descripción breve de rep_ListadoStockNDias.
	/// </summary>
	public class rep_ListadoStockNDias
	{
		public rep_ListadoStockNDias()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}


		public static DataTable GetList(string IdProducto,  string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, string IdJerarquia4,string IdJerarquia5, string IdJerarquia6, string IdJerarquia7,string IdJerarquia8,DateTime FechaDesde, DateTime FechaHasta, int Dias, string IdProveedor, bool PrecioUltimaCompra, bool PrecioUltimaCompraProveedor, bool PrecioDeListaProveedor)
		{
			try
			{
				DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_tlg_Stock_StockANDias", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);

				cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
				if (IdProducto =="") cmd.Parameters[ "@IdProducto" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
				
				cmd.Parameters.Add( new SqlParameter( "@Jerarquia1", SqlDbType.VarChar ) );
				if(IdJerarquia1=="")cmd.Parameters[ "@Jerarquia1" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Jerarquia1" ].Value = IdJerarquia1;

				cmd.Parameters.Add( new SqlParameter( "@Jerarquia2", SqlDbType.VarChar ) );
				if(IdJerarquia2=="")cmd.Parameters[ "@Jerarquia2" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Jerarquia2" ].Value = IdJerarquia2;

			
				cmd.Parameters.Add( new SqlParameter( "@Jerarquia3", SqlDbType.VarChar ) );
				if(IdJerarquia3=="")cmd.Parameters[ "@Jerarquia3" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Jerarquia3" ].Value = IdJerarquia3;
				
				cmd.Parameters.Add( new SqlParameter( "@Jerarquia4", SqlDbType.VarChar ) );
				if(IdJerarquia4=="")cmd.Parameters[ "@Jerarquia4" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Jerarquia4" ].Value = IdJerarquia4;

				
				cmd.Parameters.Add( new SqlParameter( "@Jerarquia5", SqlDbType.VarChar ) );
				if(IdJerarquia5=="")cmd.Parameters[ "@Jerarquia5" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Jerarquia5" ].Value = IdJerarquia5;

				cmd.Parameters.Add( new SqlParameter( "@Jerarquia6", SqlDbType.VarChar ) );
				if(IdJerarquia6=="")cmd.Parameters[ "@Jerarquia6" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Jerarquia6" ].Value = IdJerarquia6;

				cmd.Parameters.Add( new SqlParameter( "@Jerarquia7", SqlDbType.VarChar ) );
				if(IdJerarquia7=="")cmd.Parameters[ "@Jerarquia7" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Jerarquia7" ].Value = IdJerarquia7;

				cmd.Parameters.Add( new SqlParameter( "@Jerarquia8", SqlDbType.VarChar ) );
				if(IdJerarquia8=="")cmd.Parameters[ "@Jerarquia8" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Jerarquia8" ].Value = IdJerarquia8;


				


				cmd.Parameters.Add( new SqlParameter( "@FechaDesde", SqlDbType.DateTime ));
				if (FechaDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@FechaDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(FechaDesde.Year,FechaDesde.Month,FechaDesde.Day,0,0,0,0);
					cmd.Parameters[ "@FechaDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@FechaHasta", SqlDbType.DateTime ));
				if (FechaHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@FechaHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(FechaHasta.Year,FechaHasta.Month,FechaHasta.Day,23,59,0,0);
				
					cmd.Parameters[ "@FechaHasta"].Value = h;
				}

				cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar));
				if(IdProveedor =="")cmd.Parameters[ "@IdProveedor"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@IdProveedor"].Value = IdProveedor;
				
				cmd.Parameters.Add( new SqlParameter( "@Dias", SqlDbType.BigInt ));
				cmd.Parameters[ "@Dias"].Value = Dias;

				cmd.Parameters.Add( new SqlParameter( "@PrecioUltimaCompra", SqlDbType.Bit ));
				cmd.Parameters[ "@PrecioUltimaCompra"].Value = PrecioUltimaCompra;
				
				cmd.Parameters.Add( new SqlParameter( "@PrecioUltimaCompraProveedor", SqlDbType.Bit ));
				cmd.Parameters[ "@PrecioUltimaCompraProveedor"].Value = PrecioUltimaCompraProveedor;

				cmd.Parameters.Add( new SqlParameter( "@PrecioDeListaProveedor", SqlDbType.Bit ));
				cmd.Parameters[ "@PrecioDeListaProveedor"].Value = PrecioDeListaProveedor;

				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Table" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);

				


				return data.Tables[0];
			}
			catch(Exception e){;return null;}

		}
	}
}

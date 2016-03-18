using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace mz.erp.dataaccess.reportes
{
	/// <summary>
	/// Descripción breve de tsh_ReporteActualizacionPrecios.
	/// </summary>
	public class tsh_ReporteActualizacionPrecios
	{
		public tsh_ReporteActualizacionPrecios()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
	
		public static DataSet GetList( DateTime FechaDesde, DateTime FechaHasta, long IdEmpresa, long IdSucursal )
		{//ST 		
			System.Data.DataSet data = new DataSet();
			try
			{
				SqlCommand cmd = new SqlCommand( "Pr_tsh_Productos_Search", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add( new SqlParameter( "@FechaDesde", SqlDbType.DateTime ));
				if (FechaDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@FechaDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(FechaDesde.Year,FechaDesde.Month,FechaDesde.Day,0, 0, 0, 0);
					cmd.Parameters[ "@FechaDesde"].Value = d;
				}
				cmd.Parameters.Add( new SqlParameter( "@FechaHasta", SqlDbType.DateTime ));
				if (FechaHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@FechaHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(FechaHasta.Year,FechaHasta.Month,FechaHasta.Day,23,59,0,0);
					cmd.Parameters[ "@FechaHasta"].Value = h;
				}
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
		}

	}
	
}

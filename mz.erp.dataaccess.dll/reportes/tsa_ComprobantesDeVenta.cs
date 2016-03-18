using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace mz.erp.dataaccess.Reportes
{
	/// <summary>
	/// Descripción breve de tsa_ComprobantesDeVenta.
	/// </summary>
	public class tsa_ComprobantesDeVenta
	{
		public tsa_ComprobantesDeVenta()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static DataSet GetList( string IdTipoDeComprobante, string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, long IdEmpresa, long IdSucursal )
		{
			DataSet data = new DataSet();
			return GetList(data,IdTipoDeComprobante, IdCuenta, FechaDesde, FechaHasta, IdResponsable, IdEmpresa, IdSucursal );
		}
		public static DataSet GetList( DataSet data, string IdTipoDeComprobante, string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, long IdEmpresa, long IdSucursal )
		{
			
			SqlCommand cmd = new SqlCommand( "RP_tsa_ComprobantesDeVenta", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTipoDeComprobante" ].Value = IdTipoDeComprobante;

			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;

			cmd.Parameters.Add( new SqlParameter( "@FechaDesde", SqlDbType.DateTime ));
			cmd.Parameters[ "@FechaDesde"].Value = FechaDesde;

			cmd.Parameters.Add( new SqlParameter( "@FechaHasta", SqlDbType.DateTime ));
			cmd.Parameters[ "@FechaHasta"].Value = FechaHasta;

			cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.DateTime ));
			cmd.Parameters[ "@IdResponsable"].Value = IdResponsable;

			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
			cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;

			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
			cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
			
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			adapter.TableMappings.Add( "Table", "RP_tsa_ComprobantesDeVenta" );
			adapter.Fill( data, "ResultadoConsulta" );

			adapter.SelectCommand = cmd;


			return data;
		}

	}
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace mz.erp.dataaccess.reportes
{
	/// <summary>
	/// Descripción breve de tlg_ReporteDetalleComprobantesDeEntrega.
	/// </summary>
	public class tlg_ReporteDetalleComprobantesDeEntrega
	{
		public tlg_ReporteDetalleComprobantesDeEntrega()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static DataSet GetList( DataSet data, string IdTipoDeComprobante, string IdCuenta, 
			DateTime FechaEmisionDesde, DateTime FechaEmisionHasta, DateTime FechaConvDesde, DateTime FechaConvHasta, DateTime FechaVtoDesde, DateTime FechaVtoHasta,
			string IdResponsable, long IdEmpresa, long IdSucursal, 
			string IdComprobante, string IdProducto, string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, 
			string IdJerarquia4,string IdJerarquia5, string IdJerarquia6, string IdJerarquia7, string IdJerarquia8,
			string NumeroDesde, string NumeroHasta, string Observaciones, string CampoAuxiliar1, 
			string CampoAuxiliar2, string CampoAuxiliar3, string CampoAuxiliar4, string CampoAuxiliar5)
		{			
			try
			{
				SqlCommand cmd = new SqlCommand( "Pr_tlg_DetalleComprobantesDeEntrega", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);

				cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar ) );
				if (IdTipoDeComprobante =="") cmd.Parameters[ "@IdTipoDeComprobante" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdTipoDeComprobante" ].Value = IdTipoDeComprobante;
				
				
				cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
				if(IdCuenta=="")cmd.Parameters[ "@IdCuenta" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;
			
				cmd.Parameters.Add( new SqlParameter( "@FechaEmisionDesde", SqlDbType.DateTime ));
				if (FechaEmisionDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@FechaEmisionDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(FechaEmisionDesde.Year,FechaEmisionDesde.Month,FechaEmisionDesde.Day,0,0,0,0);
					cmd.Parameters[ "@FechaEmisionDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@FechaEmisionHasta", SqlDbType.DateTime ));
				if (FechaEmisionHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@FechaEmisionHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(FechaEmisionHasta.Year,FechaEmisionHasta.Month,FechaEmisionHasta.Day,23,59,0,0);
				
					cmd.Parameters[ "@FechaEmisionHasta"].Value = h;
				}

				cmd.Parameters.Add( new SqlParameter( "@FechaConvDesde", SqlDbType.DateTime ));
				if (FechaConvDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@FechaConvDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(FechaConvDesde.Year,FechaConvDesde.Month,FechaConvDesde.Day,0,0,0,0);
					cmd.Parameters[ "@FechaConvDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@FechaConvHasta", SqlDbType.DateTime ));
				if (FechaConvHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@FechaConvHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(FechaConvHasta.Year,FechaConvHasta.Month,FechaConvHasta.Day,23,59,0,0);
				
					cmd.Parameters[ "@FechaConvHasta"].Value = h;
				}

				cmd.Parameters.Add( new SqlParameter( "@FechaVtoDesde", SqlDbType.DateTime ));
				if (FechaVtoDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@FechaVtoDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(FechaVtoDesde.Year,FechaVtoDesde.Month,FechaVtoDesde.Day,0,0,0,0);
					cmd.Parameters[ "@FechaVtoDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@FechaVtoHasta", SqlDbType.DateTime ));
				if (FechaVtoHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@FechaVtoHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(FechaVtoHasta.Year,FechaVtoHasta.Month,FechaVtoHasta.Day,23,59,0,0);
				
					cmd.Parameters[ "@FechaVtoHasta"].Value = h;
				}

				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar));
				if(IdResponsable =="")cmd.Parameters[ "@IdResponsable"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@IdResponsable"].Value = IdResponsable;

				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
				cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;

				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
				cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
			
				cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ));
				cmd.Parameters[ "@IdComprobante"].Value = IdComprobante;
			

				cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
				if (IdProducto =="") cmd.Parameters[ "@IdProducto" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
				
				
				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia1", SqlDbType.VarChar ) );
				if(IdJerarquia1=="")cmd.Parameters[ "@IdJerarquia1" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia1" ].Value = IdJerarquia1;

				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia2", SqlDbType.VarChar ) );
				if(IdJerarquia2=="")cmd.Parameters[ "@IdJerarquia2" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia2" ].Value = IdJerarquia2;

			
				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia3", SqlDbType.VarChar ) );
				if(IdJerarquia3=="")cmd.Parameters[ "@IdJerarquia3" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia3" ].Value = IdJerarquia3;
				
				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia4", SqlDbType.VarChar ) );
				if(IdJerarquia4=="")cmd.Parameters[ "@IdJerarquia4" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia4" ].Value = IdJerarquia4;

				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia5", SqlDbType.VarChar ) );
				if(IdJerarquia5=="")cmd.Parameters[ "@IdJerarquia5" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia5" ].Value = IdJerarquia5;


				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia6", SqlDbType.VarChar ) );
				if(IdJerarquia6=="")cmd.Parameters[ "@IdJerarquia6" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia6" ].Value = IdJerarquia6;


				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia7", SqlDbType.VarChar ) );
				if(IdJerarquia7=="")cmd.Parameters[ "@IdJerarquia7" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia7" ].Value = IdJerarquia7;


				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia8", SqlDbType.VarChar ) );
				if(IdJerarquia8=="")cmd.Parameters[ "@IdJerarquia8" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia8" ].Value = IdJerarquia8;

				cmd.Parameters.Add( new SqlParameter( "@NumeroDesde", SqlDbType.VarChar ) );
				if (NumeroDesde =="") cmd.Parameters[ "@NumeroDesde" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@NumeroDesde" ].Value = NumeroDesde;

				cmd.Parameters.Add( new SqlParameter( "@NumeroHasta", SqlDbType.VarChar ) );
				if (NumeroHasta =="") cmd.Parameters[ "@NumeroHasta" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@NumeroHasta" ].Value = NumeroHasta;		
		
				cmd.Parameters.Add( new SqlParameter( "@Observaciones", SqlDbType.VarChar ) );
				if (Observaciones == "") {	cmd.Parameters[ "@Observaciones" ].Value = System.DBNull.Value;}
				else {cmd.Parameters[ "@Observaciones" ].Value = Observaciones;}

				cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar1", SqlDbType.VarChar ) );
				if (CampoAuxiliar1 == "") {	cmd.Parameters[ "@CampoAuxiliar1" ].Value = System.DBNull.Value;}
				else {cmd.Parameters[ "@CampoAuxiliar1" ].Value = CampoAuxiliar1;}

				cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar2", SqlDbType.VarChar ) );
				if (CampoAuxiliar2 == "") {	cmd.Parameters[ "@CampoAuxiliar2" ].Value = System.DBNull.Value;}
				else {cmd.Parameters[ "@CampoAuxiliar2" ].Value = CampoAuxiliar2;}

				cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar3", SqlDbType.VarChar ) );
				if (CampoAuxiliar3 == "") {	cmd.Parameters[ "@CampoAuxiliar3" ].Value = System.DBNull.Value;}
				else {cmd.Parameters[ "@CampoAuxiliar3" ].Value = CampoAuxiliar3;}

				cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar4", SqlDbType.VarChar ) );
				if (CampoAuxiliar4 == "") {	cmd.Parameters[ "@CampoAuxiliar4" ].Value = System.DBNull.Value;}
				else {cmd.Parameters[ "@CampoAuxiliar4" ].Value = CampoAuxiliar4;}

				cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar5", SqlDbType.VarChar ) );
				if (CampoAuxiliar5 == "") {	cmd.Parameters[ "@CampoAuxiliar5" ].Value = System.DBNull.Value;}
				else {cmd.Parameters[ "@CampoAuxiliar5" ].Value = CampoAuxiliar5;}
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "RP_tsa_DetalleComprobantesDeVenta" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);

				


				return data;
			}
			catch(Exception e){;return null;}
		}

	}
}

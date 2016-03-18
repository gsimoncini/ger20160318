using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace mz.erp.dataaccess.reportes
{
	/// <summary>
	/// Descripci�n breve de tsa_ReporteDetalleComprobantesDeVenta.
	/// </summary>
	public class tsa_ReporteDetalleComprobantesDeVenta
	{
		public tsa_ReporteDetalleComprobantesDeVenta()
		{
			//
			// TODO: agregar aqu� la l�gica del constructor
			//
		}
		public static DataSet GetList( string IdTipoDeComprobante, string IdCuenta, DateTime FechaDesde, 
			DateTime FechaHasta, string IdResponsable, long IdEmpresa, long IdSucursal )
		{
			return GetList(  IdTipoDeComprobante,  IdCuenta,  FechaDesde,  FechaHasta,  IdResponsable,  
				IdEmpresa,  IdSucursal, null);
		}
		public static DataSet GetList( string IdTipoDeComprobante, string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, long IdEmpresa, long IdSucursal, string IdComprobante )
		{
			DataSet data = new DataSet();
			return GetList(data, IdTipoDeComprobante, IdCuenta, FechaDesde, FechaHasta, IdResponsable, 
				IdEmpresa, IdSucursal,IdComprobante,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null);		
		}

		public static DataSet GetList( DataSet data, string IdTipoDeComprobante, string IdCuenta, DateTime FechaDesde, 
			DateTime FechaHasta, string IdResponsable, long IdEmpresa, long IdSucursal)
		{
			return GetList( data, IdTipoDeComprobante, IdCuenta, FechaDesde, FechaHasta, IdResponsable, IdEmpresa, IdSucursal,null,null, null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null);
		}

		public static DataSet GetList( DataSet data, string IdTipoDeComprobante, string IdCuenta, 
			DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, long IdEmpresa, long IdSucursal, 
			string IdComprobante, string IdProducto, string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, 
			string IdJerarquia4,string IdJerarquia5, string IdJerarquia6, string IdJerarquia7, string IdJerarquia8,
			string IdJerarquia9, string IdJerarquia10, string IdJerarquia11, string IdJerarquia12,
			string IdJerarquia13, string IdJerarquia14, string IdJerarquia15, string IdJerarquia16,
			string NumeroDesde, string NumeroHasta)
		{			
			try
			{
				SqlCommand cmd = new SqlCommand( "Pr_tsa_DetalleComprobantesDeVenta", dbhelper.Connection.GetConnection() );
				//SqlCommand cmd = new SqlCommand( "Pr_tsa_DetalleComprobantesDeVenta", dbhelper.Connection.GetConnection() );
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

				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia9", SqlDbType.VarChar ) );
				if(IdJerarquia9=="")cmd.Parameters[ "@IdJerarquia9" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia9" ].Value = IdJerarquia9;

				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia10", SqlDbType.VarChar ) );
				if(IdJerarquia10=="")cmd.Parameters[ "@IdJerarquia10" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia10" ].Value = IdJerarquia10;

				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia11", SqlDbType.VarChar ) );
				if(IdJerarquia11=="")cmd.Parameters[ "@IdJerarquia11" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia11" ].Value = IdJerarquia11;

				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia12", SqlDbType.VarChar ) );
				if(IdJerarquia12=="")cmd.Parameters[ "@IdJerarquia12" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia12" ].Value = IdJerarquia12;

				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia13", SqlDbType.VarChar ) );
				if(IdJerarquia13=="")cmd.Parameters[ "@IdJerarquia13" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia13" ].Value = IdJerarquia13;

				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia14", SqlDbType.VarChar ) );
				if(IdJerarquia14=="")cmd.Parameters[ "@IdJerarquia14" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia14" ].Value = IdJerarquia14;

				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia15", SqlDbType.VarChar ) );
				if(IdJerarquia15=="")cmd.Parameters[ "@IdJerarquia15" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia15" ].Value = IdJerarquia15;

				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia16", SqlDbType.VarChar ) );
				if(IdJerarquia16=="")cmd.Parameters[ "@IdJerarquia16" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia16" ].Value = IdJerarquia16;


				cmd.Parameters.Add( new SqlParameter( "@NumeroDesde", SqlDbType.VarChar ) );
				if (NumeroDesde =="") cmd.Parameters[ "@NumeroDesde" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@NumeroDesde" ].Value = NumeroDesde;

				cmd.Parameters.Add( new SqlParameter( "@NumeroHasta", SqlDbType.VarChar ) );
				if (NumeroHasta =="") cmd.Parameters[ "@NumeroHasta" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@NumeroHasta" ].Value = NumeroHasta;				

			
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

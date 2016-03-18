using System;
using System.Data;
using System.Data.SqlClient;

namespace mz.erp.dataaccess.reportes
{
	/// <summary>
	/// Descripción breve de rep_ConsultarComprobantesDeCompra.
	/// </summary>
	public class rep_ConsultarComprobantesDeCompra
	{
		public rep_ConsultarComprobantesDeCompra()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//		
		}

        //Cristian Tarea 836
		public static DataSet GetList( DataSet data, string IdTipoDeComprobante, string IdProveedor,
            DateTime FechaDesde, DateTime FechaHasta, DateTime CreacionDesde, DateTime CreacionHasta, string IdResponsable, long IdEmpresa, long IdSucursal,
			string TiposDeComprobanteDestinoExcluidos)
		{			
			try
			{
				SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesPendientesDePreNotaDeCredito", dbhelper.Connection.GetConnection() );
					
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);

				cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar ) );
				if (IdTipoDeComprobante =="") cmd.Parameters[ "@IdTipoDeComprobante" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdTipoDeComprobante" ].Value = IdTipoDeComprobante;
				
				
				cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
				if(IdProveedor=="")cmd.Parameters[ "@IdProveedor" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdProveedor" ].Value = IdProveedor;
			
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

                //Cristiah Tarea 836
                cmd.Parameters.Add(new SqlParameter("@CreacionDesde", SqlDbType.DateTime));
                if (CreacionDesde.Equals(DateTime.MinValue)) cmd.Parameters["@CreacionDesde"].Value = System.DBNull.Value;
                else
                {
                    DateTime d = new DateTime(CreacionDesde.Year, CreacionDesde.Month, CreacionDesde.Day, 0, 0, 0, 0);
                    cmd.Parameters["@CreacionDesde"].Value = d;
                }

                cmd.Parameters.Add(new SqlParameter("@CreacionHasta", SqlDbType.DateTime));
                if (CreacionHasta.Equals(DateTime.MinValue)) cmd.Parameters["@CreacionHasta"].Value = System.DBNull.Value;
                else
                {
                    DateTime h = new DateTime(CreacionHasta.Year, CreacionHasta.Month, CreacionHasta.Day, 23, 59, 0, 0);

                    cmd.Parameters["@CreacionHasta"].Value = h;
                }
                //Fin tarea 836

				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar));
				if(IdResponsable =="")cmd.Parameters[ "@IdResponsable"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@IdResponsable"].Value = IdResponsable;

				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
				cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;

				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
				cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
			
				cmd.Parameters.Add( new SqlParameter( "@TiposDeComprobanteDestinoExcluidos", SqlDbType.VarChar));
				if (IdResponsable == "")
					cmd.Parameters[ "@TiposDeComprobanteDestinoExcluidos"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposDeComprobanteDestinoExcluidos"].Value = TiposDeComprobanteDestinoExcluidos;
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "ComprobantesDeCompraPendientes" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);

	

				return data;
			}
			catch(Exception e){;return null;}
		}
        //Fin Tarea 836
	
        //Cristian tarea 836
		public static DataSet GetListComprobantesPendientesDePreNotaDeDebito( DataSet data, string IdTipoDeComprobante, string IdProveedor, 
			DateTime FechaDesde, DateTime FechaHasta, DateTime CreacionDesde, DateTime CreacionHasta, string IdResponsable, long IdEmpresa, long IdSucursal,
			string TiposDeComprobanteDestinoExcluidos)
		{			
			try
			{
				SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesPendientesDePreNotaDeDebito", dbhelper.Connection.GetConnection() );
					
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);

				cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar ) );
				if (IdTipoDeComprobante =="") cmd.Parameters[ "@IdTipoDeComprobante" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdTipoDeComprobante" ].Value = IdTipoDeComprobante;
				
				
				cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
				if(IdProveedor=="")cmd.Parameters[ "@IdProveedor" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdProveedor" ].Value = IdProveedor;
			
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

                //Cristian Tarea 836
                cmd.Parameters.Add(new SqlParameter("@CreacionDesde", SqlDbType.DateTime));
                if (CreacionDesde.Equals(DateTime.MinValue)) cmd.Parameters["@CreacionDesde"].Value = System.DBNull.Value;
                else
                {
                    DateTime d = new DateTime(CreacionDesde.Year, CreacionDesde.Month, CreacionDesde.Day, 0, 0, 0, 0);
                    cmd.Parameters["@CreacionDesde"].Value = d;
                }

                cmd.Parameters.Add(new SqlParameter("@CreacionHasta", SqlDbType.DateTime));
                if (CreacionHasta.Equals(DateTime.MinValue)) cmd.Parameters["@CreacionHasta"].Value = System.DBNull.Value;
                else
                {
                    DateTime h = new DateTime(CreacionHasta.Year, CreacionHasta.Month, CreacionHasta.Day, 23, 59, 0, 0);
                    cmd.Parameters["@CreacionHasta"].Value = h;
                }
                //Fin Tarea 836

				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar));
				if(IdResponsable =="")cmd.Parameters[ "@IdResponsable"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@IdResponsable"].Value = IdResponsable;

				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
				cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;

				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
				cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
			
				cmd.Parameters.Add( new SqlParameter( "@TiposDeComprobanteDestinoExcluidos", SqlDbType.VarChar));
				if (IdResponsable == "")
					cmd.Parameters[ "@TiposDeComprobanteDestinoExcluidos"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposDeComprobanteDestinoExcluidos"].Value = TiposDeComprobanteDestinoExcluidos;
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "ComprobantesDeCompraPendientes" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);

	

				return data;
			}
			catch(Exception e){;return null;}
		}
        //Fin tarea 836
	}
}

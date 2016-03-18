using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace mz.erp.dataaccess.reportes
{
	/// <summary>
	/// Descripción breve de rep_ListadoDeVentasPorProducto.
	/// </summary>
	public class rep_ListadoDeVentasPorProducto
	{
		public rep_ListadoDeVentasPorProducto()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}


		public static System.Data.DataTable GetList( string IdProducto, string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, string IdJerarquia4,string IdJerarquia5, string IdJerarquia6, string IdJerarquia7, string IdJerarquia8, DateTime FechaDesde, DateTime FechaHasta, string IdMonedaReferencia ,string IdMonedaVisualizacion, string IdFuenteDeCambioVisualizacion, string ListaTiposDeComprobantes)
		{//ST 		
			System.Data.DataSet data = new System.Data.DataSet();
			try
			{
				//SqlCommand cmd = new SqlCommand( "Pr_Compras_VentasPorArticulo", dbhelper.Connection.GetConnection() );
				SqlCommand cmd = new SqlCommand( "Pr_Compras_VentasPorArticuloNUEVO", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);
				
				
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


				
				
				
				cmd.Parameters.Add( new SqlParameter( "@ListaTiposDeComprobantes", SqlDbType.VarChar ));
				if (ListaTiposDeComprobantes == null || ListaTiposDeComprobantes.Equals(String.Empty)) 
					cmd.Parameters[ "@ListaTiposDeComprobantes"].Value = System.DBNull.Value; 
				else 
					cmd.Parameters[ "@ListaTiposDeComprobantes"].Value = ListaTiposDeComprobantes;

				
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

				cmd.Parameters.Add( new SqlParameter( "@IdMonedaReferencia", SqlDbType.VarChar ));
				if (IdMonedaReferencia == null || IdMonedaReferencia.Equals(String.Empty)) 
					cmd.Parameters[ "@IdMonedaReferencia"].Value = System.DBNull.Value; 
				else 
					cmd.Parameters[ "@IdMonedaReferencia"].Value = IdMonedaReferencia;

				cmd.Parameters.Add( new SqlParameter( "@idMonedaVisualizacion", SqlDbType.VarChar ));
				if (IdMonedaVisualizacion == null || IdMonedaVisualizacion.Equals(String.Empty)) 
					cmd.Parameters[ "@idMonedaVisualizacion"].Value = System.DBNull.Value; 
				else 
					cmd.Parameters[ "@idMonedaVisualizacion"].Value = IdMonedaVisualizacion;
				
				cmd.Parameters.Add( new SqlParameter( "@IdFuenteDeCambioVisualizacion", SqlDbType.VarChar ));
				if (IdFuenteDeCambioVisualizacion == null || IdFuenteDeCambioVisualizacion.Equals(String.Empty)) 
					cmd.Parameters[ "@IdFuenteDeCambioVisualizacion"].Value = System.DBNull.Value; 
				else 
					cmd.Parameters[ "@IdFuenteDeCambioVisualizacion"].Value = IdFuenteDeCambioVisualizacion;	
		
		

				
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "RP_Compras_ListadoDeVentasPorProducto" );
				adapter.SelectCommand = cmd;
				
				adapter.Fill( data);
				
				return data.Tables[0];
			}
			catch(Exception e)
			{
				return null;
			}
	
			/*  HABILITAR ACA CUANDO SE PASE TB LA JERARQUIA!
			 * 

					public static System.Data.DataSet GetList( DateTime FechaDesde, DateTime FechaHasta, string Jerarquia, string Moneda, long IdEmpresa, long IdSucursal )
					{//ST 		
						System.Data.DataSet data = new System.Data.DataSet();
						try
						{
							SqlCommand cmd = new SqlCommand( "Pr_Compras_VentasPorArticulo", dbhelper.Connection.GetConnection() );
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
				
							if (Jerarquia != null && Jerarquia.Equals(String.Empty)) cmd.Parameters[ "@Jerarquia"].Value = System.DBNull.Value; 
							else { cmd.Parameters[ "@Jerarquia"].Value = jerarquia; }
	
							cmd.Parameters.Add( new SqlParameter( "@idMoneda", SqlDbType.VarChar ));
							if (Moneda != null && Moneda.Equals(String.Empty)) cmd.Parameters[ "@IdMoneda"].Value = System.DBNull.Value; 
							else {cmd.Parameters[ "@idMoneda"].Value = Moneda;}				
					
							cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
							cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
					
							cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
							cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;
					
							SqlDataAdapter adapter = new SqlDataAdapter();
							adapter.TableMappings.Add( "Table", "RP_Compras_ListadoDeVentasPorProducto" );
							adapter.SelectCommand = cmd;
							adapter.Fill( data);

							return data;
						}
						catch(Exception e)
					{
						return null;
					}
	 
			*/
		}
	}
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
    
using mz.erp.dbhelper;
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
//using Logger;

namespace mz.erp.dataaccess
{
	/// <summary>
	/// Descripción breve de tpu_ComprobantesEx.
	/// </summary>
	public class tpu_ComprobantesEx
	{
		public tpu_ComprobantesEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static System.Data.DataSet GetSinAutorizar ( string tiposComprobantesOrigen, string IdProveedor, DateTime EmisionDesde, DateTime EmisionHasta, DateTime VencimientoDesde, DateTime VencimientoHasta, DateTime RecepcionDesde, DateTime RecepcionHasta, string IdResponsable, long IdSucursal, long IdEmpresa, bool VerHTML, string IdCuentaImputacion, string IdSubCuentaImputacion)
		{

			try
			{
				SqlConnection cnx = dbhelper.Connection.GetConnection();
				cnx.Open();
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_ListarComprobantesComprasCabeceraSinAutorizar", cnx );
				
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesOrigen", SqlDbType.VarChar ) );
				/*	if (tiposComprobantesOrigen =="" || tiposComprobantesOrigen == null) cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = System.DBNull.Value;
				else*/
					cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = tiposComprobantesOrigen;
				
				
			
				cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
				if(IdProveedor=="" || IdProveedor==null)cmd.Parameters[ "@IdProveedor" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdProveedor" ].Value = IdProveedor;

				cmd.Parameters.Add( new SqlParameter( "@IdCuentaImputacion", SqlDbType.VarChar ) );
				if(IdCuentaImputacion=="" || IdCuentaImputacion==null)cmd.Parameters[ "@IdCuentaImputacion" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdCuentaImputacion" ].Value = IdCuentaImputacion;

				cmd.Parameters.Add( new SqlParameter( "@IdSubCuentaImputacion", SqlDbType.VarChar ) );
				if(IdSubCuentaImputacion=="" || IdSubCuentaImputacion==null)cmd.Parameters[ "@IdSubCuentaImputacion" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdSubCuentaImputacion" ].Value = IdSubCuentaImputacion;
			
				cmd.Parameters.Add( new SqlParameter( "@EmisionDesde", SqlDbType.DateTime ));
				if (EmisionDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@EmisionDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(EmisionDesde.Year,EmisionDesde.Month,EmisionDesde.Day,0,0,0,0);
					cmd.Parameters[ "@EmisionDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@EmisionHasta", SqlDbType.DateTime ));
				if (EmisionHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@EmisionHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(EmisionHasta.Year,EmisionHasta.Month,EmisionHasta.Day,23,59,0,0);
				
					cmd.Parameters[ "@EmisionHasta"].Value = h;
				}

				cmd.Parameters.Add( new SqlParameter( "@VencimientoDesde", SqlDbType.DateTime ));
				if (VencimientoDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@VencimientoDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(VencimientoDesde.Year,VencimientoDesde.Month,VencimientoDesde.Day,0,0,0,0);
					cmd.Parameters[ "@VencimientoDesde"].Value = d;
				}


				cmd.Parameters.Add( new SqlParameter( "@VencimientoHasta", SqlDbType.DateTime ));
				if (VencimientoHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@VencimientoHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(VencimientoHasta.Year,VencimientoHasta.Month,VencimientoHasta.Day,23,59,0,0);
				
					cmd.Parameters[ "@VencimientoHasta"].Value = h;
				}

				cmd.Parameters.Add( new SqlParameter( "@RecepcionDesde", SqlDbType.DateTime ));
				if (RecepcionDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@RecepcionDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(RecepcionDesde.Year,RecepcionDesde.Month,RecepcionDesde.Day,0,0,0,0);
					cmd.Parameters[ "@RecepcionDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@RecepcionHasta", SqlDbType.DateTime ));
				if (RecepcionHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@RecepcionHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(RecepcionHasta.Year,RecepcionHasta.Month,RecepcionHasta.Day,23,59,0,0);
				
					cmd.Parameters[ "@RecepcionHasta"].Value = h;
				}

				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar));
				if(IdResponsable =="" || IdResponsable == null)cmd.Parameters[ "@IdResponsable"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@IdResponsable"].Value = IdResponsable;
			
				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
				if (IdSucursal != long.MinValue)
				{
					cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;
				}
				else
				{
					cmd.Parameters[ "@IdSucursal"].Value = System.DBNull.Value;
				}
				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
				if (IdEmpresa != long.MinValue)
				{
					cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
				}
				else
				{
					cmd.Parameters[ "@IdEmpresa"].Value = System.DBNull.Value;
				}
				
				

				cmd.Parameters.Add( new SqlParameter( "@VerHTML", SqlDbType.Bit ));
				cmd.Parameters[ "@VerHTML"].Value = VerHTML;
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tpu_ComprobantesCompras" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);
				//cnx.Close();
				return data;
			}
			catch(Exception e){;return null;}
			
		}


		public static System.Data.DataSet GetPedidoAbierto( System.Data.DataSet data )
		{
			
			SqlConnection cnx = dbhelper.Connection.GetConnection();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_Comprobantes" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_Comprobantes_GetPedidoAbierto", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cnx.Open();
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
			cnx.Close();
         
			return data;
		}


/*		public static System.Data.DataSet ComprobantesPendientes( string tiposComprobantesOrigen, string tiposComprobantesDestino, string IdProveedor, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, long IdSucursal, long IdEmpresa, bool VerHTML)
		{
			string TiposComprobantesDestinoExcluidos = "";
			return ComprobantesPendientes(tiposComprobantesOrigen, tiposComprobantesDestino, IdProveedor, FechaDesde, FechaHasta, IdResponsable, IdSucursal, IdEmpresa, VerHTML, TiposComprobantesDestinoExcluidos);
		}
*/
        // Cristian 20100920 Tarea 836
		public static System.Data.DataSet ComprobantesPendientes( string tiposComprobantesOrigen, string tiposComprobantesDestino, string IdProveedor, DateTime FechaDesde, DateTime FechaHasta,DateTime DesdeRecepcion,DateTime HastaRecepcion,DateTime DesdeRegistracion,DateTime HastaRegistracion, string IdResponsable, long IdSucursal, long IdEmpresa, bool VerHTML, string TiposComprobantesDestinoExcluidos)
		{			
			try
			{
				SqlConnection cnx = dbhelper.Connection.GetConnection();
				cnx.Open();
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_ComprobantesDeCompraPendientes", cnx );
				
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesOrigen", SqlDbType.VarChar ) );
				if (tiposComprobantesOrigen =="" || tiposComprobantesOrigen == null) cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = tiposComprobantesOrigen;
				
				
				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesDestino", SqlDbType.VarChar ) );
				if (tiposComprobantesDestino =="" || tiposComprobantesDestino == null) cmd.Parameters[ "@TiposComprobantesDestino" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposComprobantesDestino" ].Value = tiposComprobantesDestino;
				

				cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
				if(IdProveedor=="" || IdProveedor==null)cmd.Parameters[ "@IdProveedor" ].Value = System.DBNull.Value;
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



				cmd.Parameters.Add( new SqlParameter( "@FechaDesdeRecepcionMercaderia", SqlDbType.DateTime ));
				if (DesdeRecepcion.Equals(DateTime.MinValue))cmd.Parameters[ "@FechaDesdeRecepcionMercaderia"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(DesdeRecepcion.Year,DesdeRecepcion.Month,DesdeRecepcion.Day,0,0,0,0);
					cmd.Parameters[ "@FechaDesdeRecepcionMercaderia"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@FechaHastaRecepcionMercaderia", SqlDbType.DateTime ));
				if (HastaRecepcion.Equals(DateTime.MinValue)) cmd.Parameters[ "@FechaHastaRecepcionMercaderia"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(HastaRecepcion.Year,HastaRecepcion.Month,HastaRecepcion.Day,23,59,0,0);
				
					cmd.Parameters[ "@FechaHastaRecepcionMercaderia"].Value = h;
				}

                //Cristian 20100920 Tarea 836
                cmd.Parameters.Add(new SqlParameter("@FechaDesdeCreacion", SqlDbType.DateTime));
                if (DesdeRegistracion.Equals(DateTime.MinValue)) cmd.Parameters["@FechaDesdeCreacion"].Value = System.DBNull.Value;
                else
                {
                    DateTime d = new DateTime(DesdeRegistracion.Year, DesdeRegistracion.Month, DesdeRegistracion.Day, 0, 0, 0, 0);
                    cmd.Parameters["@FechaDesdeCreacion"].Value = d;
                }

                cmd.Parameters.Add(new SqlParameter("@FechaHastaCreacion", SqlDbType.DateTime));
                if (HastaRegistracion.Equals(DateTime.MinValue)) cmd.Parameters["@FechaHastaCreacion"].Value = System.DBNull.Value;
                else
                {
                    DateTime h = new DateTime(HastaRegistracion.Year, HastaRegistracion.Month, HastaRegistracion.Day, 23, 59, 0, 0);

                    cmd.Parameters["@FechaHastaCreacion"].Value = h;
                }
                //Fin Cristian tarea 836

				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar));
				if(IdResponsable =="" || IdResponsable == null)cmd.Parameters[ "@IdResponsable"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@IdResponsable"].Value = IdResponsable;
			
				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
				if (IdSucursal != long.MinValue)
				{
					cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;
				}
				else
				{
					cmd.Parameters[ "@IdSucursal"].Value = System.DBNull.Value;
				}
				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
				if (IdEmpresa != long.MinValue)
				{
					cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
				}
				else
				{
					cmd.Parameters[ "@IdEmpresa"].Value = System.DBNull.Value;
				}
				
				cmd.Parameters.Add( new SqlParameter( "@TiposDeComprobanteDestinoExcluidos", SqlDbType.VarChar));
				if(TiposComprobantesDestinoExcluidos =="")cmd.Parameters[ "@TiposDeComprobanteDestinoExcluidos"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposDeComprobanteDestinoExcluidos"].Value = TiposComprobantesDestinoExcluidos;


				cmd.Parameters.Add( new SqlParameter( "@VerHTML", SqlDbType.Bit ));
				cmd.Parameters[ "@VerHTML"].Value = VerHTML;
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tpu_ComprobantesPendientes" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);
				//cnx.Close();

				return data;
			}
			catch(Exception e){;return null;}
		}
        //Fin Cristian Tarea 836

        //Cristian Tarea 836
		public static System.Data.DataSet ListarComprobantesDeCompraPendientesPago( string tiposComprobantesOrigen, string IdProveedor, DateTime FechaDesde, DateTime FechaHasta, DateTime fechaVencimientoDesde, DateTime fechaVencimientoHasta,DateTime CreacionDesde, DateTime CreacionHasta , string IdResponsable, long IdSucursal, long IdEmpresa, bool VerHTML, string IdCuentaImputacion, string IdSubCuentaImputacion)
		{			
			try
			{
				SqlConnection cnx = dbhelper.Connection.GetConnection();
				cnx.Open();
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_ComprobantesComprasPendientesPago", cnx );
				
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesOrigen", SqlDbType.VarChar ) );
				if (tiposComprobantesOrigen =="" || tiposComprobantesOrigen == null) cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = tiposComprobantesOrigen;
				
				
			
				cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
				if(IdProveedor=="" || IdProveedor==null)cmd.Parameters[ "@IdProveedor" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdProveedor" ].Value = IdProveedor;
			
				cmd.Parameters.Add( new SqlParameter( "@FechaEmisionDesde", SqlDbType.DateTime ));
				if (FechaDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@FechaEmisionDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(FechaDesde.Year,FechaDesde.Month,FechaDesde.Day,0,0,0,0);
					cmd.Parameters[ "@FechaEmisionDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@FechaEmisionHasta", SqlDbType.DateTime ));
				if (FechaHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@FechaEmisionHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(FechaHasta.Year,FechaHasta.Month,FechaHasta.Day,23,59,0,0);
				
					cmd.Parameters[ "@FechaEmisionHasta"].Value = h;
				}

				cmd.Parameters.Add( new SqlParameter( "@FechaVencimientoDesde", SqlDbType.DateTime ));
				if (fechaVencimientoDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@FechaVencimientoDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(fechaVencimientoDesde.Year,fechaVencimientoDesde.Month,fechaVencimientoDesde.Day,0,0,0,0);
					cmd.Parameters[ "@FechaVencimientoDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@FechaVencimientoHasta", SqlDbType.DateTime ));
				if (fechaVencimientoHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@FechaVencimientoHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(fechaVencimientoHasta.Year,fechaVencimientoHasta.Month,fechaVencimientoHasta.Day,23,59,0,0);
				
					cmd.Parameters[ "@FechaVencimientoHasta"].Value = h;
				}

                //Cristian Tarea 836
                cmd.Parameters.Add(new SqlParameter("@FechaCreacionDesde", SqlDbType.DateTime));
                if (CreacionDesde.Equals(DateTime.MinValue)) cmd.Parameters["@FechaCreacionDesde"].Value = System.DBNull.Value;
                else
                {
                    DateTime d = new DateTime(CreacionDesde.Year, CreacionDesde.Month, CreacionDesde.Day, 0, 0, 0, 0);
                    cmd.Parameters["@FechaCreacionDesde"].Value = d;
                }

                cmd.Parameters.Add(new SqlParameter("@FechaCreacionHasta", SqlDbType.DateTime));
                if (CreacionHasta.Equals(DateTime.MinValue)) cmd.Parameters["@FechaCreacionHasta"].Value = System.DBNull.Value;
                else
                {
                    DateTime h = new DateTime(CreacionHasta.Year, CreacionHasta.Month, CreacionHasta.Day, 23, 59, 0, 0);

                    cmd.Parameters["@FechaCreacionHasta"].Value = h;
                }
                //Fin Cristian Tarea 836

				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar));
				if(IdResponsable =="" || IdResponsable == null)cmd.Parameters[ "@IdResponsable"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@IdResponsable"].Value = IdResponsable;
			
				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
				if (IdSucursal != long.MinValue)
				{
					cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;
				}
				else
				{
					cmd.Parameters[ "@IdSucursal"].Value = System.DBNull.Value;
				}
				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
				if (IdEmpresa != long.MinValue)
				{
					cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
				}
				else
				{
					cmd.Parameters[ "@IdEmpresa"].Value = System.DBNull.Value;
				}
				
				
				cmd.Parameters.Add( new SqlParameter( "@VerHTML", SqlDbType.Bit ));
				cmd.Parameters[ "@VerHTML"].Value = VerHTML;

				cmd.Parameters.Add( new SqlParameter( "@IdTipoMovimiento", SqlDbType.VarChar ) );
				if (IdCuentaImputacion =="" || IdCuentaImputacion == null) 
					cmd.Parameters[ "@IdTipoMovimiento" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdTipoMovimiento" ].Value = IdCuentaImputacion;

				cmd.Parameters.Add( new SqlParameter( "@IdSubTipoMovimiento", SqlDbType.VarChar ) );
				if (IdSubCuentaImputacion =="" || IdSubCuentaImputacion == null) 
					cmd.Parameters[ "@IdSubTipoMovimiento" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdSubTipoMovimiento" ].Value = IdSubCuentaImputacion;


			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tpu_ComprobantesPendientes" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);
				//cnx.Close();

				return data;
			}
			catch(Exception e){;return null;}
		}
        //Fin Cristian Tarea 836

        //Cristian 20100920 Tarea 836
        public static System.Data.DataSet ListarComprobantesDeCompraCabeceraPendienteItems(string tiposComprobantesOrigen, string IdProveedor, DateTime EmisionDesde, DateTime EmisionHasta, DateTime VencimientoDesde, DateTime VencimientoHasta, DateTime RecepcionDesde, DateTime RecepcionHasta, DateTime CreacionDesde, DateTime CreacionHasta, string IdResponsable, long IdSucursal, long IdEmpresa, bool VerHTML, string IdCuentaImputacion, string IdSubCuentaImputacion)
		{

			try
			{
				SqlConnection cnx = dbhelper.Connection.GetConnection();
				cnx.Open();
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesDeCompra_PendienteItems", cnx );
				
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesOrigen", SqlDbType.VarChar ) );
				/*	if (tiposComprobantesOrigen =="" || tiposComprobantesOrigen == null) cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = System.DBNull.Value;
					else*/
				cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = tiposComprobantesOrigen;
				
				
			
				cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
				if(IdProveedor=="" || IdProveedor==null)cmd.Parameters[ "@IdProveedor" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdProveedor" ].Value = IdProveedor;

				cmd.Parameters.Add( new SqlParameter( "@IdCuentaImputacion", SqlDbType.VarChar ) );
				if(IdCuentaImputacion=="" || IdCuentaImputacion==null)cmd.Parameters[ "@IdCuentaImputacion" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdCuentaImputacion" ].Value = IdCuentaImputacion;

				cmd.Parameters.Add( new SqlParameter( "@IdSubCuentaImputacion", SqlDbType.VarChar ) );
				if(IdSubCuentaImputacion=="" || IdSubCuentaImputacion==null)cmd.Parameters[ "@IdSubCuentaImputacion" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdSubCuentaImputacion" ].Value = IdSubCuentaImputacion;
			
				cmd.Parameters.Add( new SqlParameter( "@EmisionDesde", SqlDbType.DateTime ));
				if (EmisionDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@EmisionDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(EmisionDesde.Year,EmisionDesde.Month,EmisionDesde.Day,0,0,0,0);
					cmd.Parameters[ "@EmisionDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@EmisionHasta", SqlDbType.DateTime ));
				if (EmisionHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@EmisionHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(EmisionHasta.Year,EmisionHasta.Month,EmisionHasta.Day,23,59,0,0);
				
					cmd.Parameters[ "@EmisionHasta"].Value = h;
				}

				cmd.Parameters.Add( new SqlParameter( "@VencimientoDesde", SqlDbType.DateTime ));
				if (VencimientoDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@VencimientoDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(VencimientoDesde.Year,VencimientoDesde.Month,VencimientoDesde.Day,0,0,0,0);
					cmd.Parameters[ "@VencimientoDesde"].Value = d;
				}


				cmd.Parameters.Add( new SqlParameter( "@VencimientoHasta", SqlDbType.DateTime ));
				if (VencimientoHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@VencimientoHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(VencimientoHasta.Year,VencimientoHasta.Month,VencimientoHasta.Day,23,59,0,0);
				
					cmd.Parameters[ "@VencimientoHasta"].Value = h;
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
                //Fin Cristian tarea 836

				cmd.Parameters.Add( new SqlParameter( "@RecepcionDesde", SqlDbType.DateTime ));
				if (RecepcionDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@RecepcionDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(RecepcionDesde.Year,RecepcionDesde.Month,RecepcionDesde.Day,0,0,0,0);
					cmd.Parameters[ "@RecepcionDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@RecepcionHasta", SqlDbType.DateTime ));
				if (RecepcionHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@RecepcionHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(RecepcionHasta.Year,RecepcionHasta.Month,RecepcionHasta.Day,23,59,0,0);
				
					cmd.Parameters[ "@RecepcionHasta"].Value = h;
				}

				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar));
				if(IdResponsable =="" || IdResponsable == null)cmd.Parameters[ "@IdResponsable"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@IdResponsable"].Value = IdResponsable;
			
				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
				if (IdSucursal != long.MinValue)
				{
					cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;
				}
				else
				{
					cmd.Parameters[ "@IdSucursal"].Value = System.DBNull.Value;
				}
				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
				if (IdEmpresa != long.MinValue)
				{
					cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
				}
				else
				{
					cmd.Parameters[ "@IdEmpresa"].Value = System.DBNull.Value;
				}
				
				

				cmd.Parameters.Add( new SqlParameter( "@VerHTML", SqlDbType.Bit ));
				cmd.Parameters[ "@VerHTML"].Value = VerHTML;
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tpu_ComprobantesPendientes" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);
				//cnx.Close();
				return data;
			}
			catch(Exception e){;return null;}
			
		}


        //Cristian Tarea 836
		public static System.Data.DataSet ListarComprobantesDeCompraCabecera( string tiposComprobantesOrigen, string IdProveedor, DateTime EmisionDesde, DateTime EmisionHasta, DateTime VencimientoDesde, DateTime VencimientoHasta, DateTime RecepcionDesde, DateTime RecepcionHasta, DateTime CreacionDesde, DateTime CreacionHasta, string IdResponsable, long IdSucursal, long IdEmpresa, bool VerHTML, string IdCuentaImputacion, string IdSubCuentaImputacion)
		{

			try
			{
				SqlConnection cnx = dbhelper.Connection.GetConnection();
				cnx.Open();
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_ListarComprobantesComprasCabecera", cnx );
				
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesOrigen", SqlDbType.VarChar ) );
			/*	if (tiposComprobantesOrigen =="" || tiposComprobantesOrigen == null) cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = System.DBNull.Value;
				else*/
					cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = tiposComprobantesOrigen;
				
				
			
				cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
				if(IdProveedor=="" || IdProveedor==null)cmd.Parameters[ "@IdProveedor" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdProveedor" ].Value = IdProveedor;

				cmd.Parameters.Add( new SqlParameter( "@IdCuentaImputacion", SqlDbType.VarChar ) );
				if(IdCuentaImputacion=="" || IdCuentaImputacion==null)cmd.Parameters[ "@IdCuentaImputacion" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdCuentaImputacion" ].Value = IdCuentaImputacion;

				cmd.Parameters.Add( new SqlParameter( "@IdSubCuentaImputacion", SqlDbType.VarChar ) );
				if(IdSubCuentaImputacion=="" || IdSubCuentaImputacion==null)cmd.Parameters[ "@IdSubCuentaImputacion" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdSubCuentaImputacion" ].Value = IdSubCuentaImputacion;
			
				cmd.Parameters.Add( new SqlParameter( "@EmisionDesde", SqlDbType.DateTime ));
				if (EmisionDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@EmisionDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(EmisionDesde.Year,EmisionDesde.Month,EmisionDesde.Day,0,0,0,0);
					cmd.Parameters[ "@EmisionDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@EmisionHasta", SqlDbType.DateTime ));
				if (EmisionHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@EmisionHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(EmisionHasta.Year,EmisionHasta.Month,EmisionHasta.Day,23,59,0,0);
				
					cmd.Parameters[ "@EmisionHasta"].Value = h;
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
                //Fin Tarea

				cmd.Parameters.Add( new SqlParameter( "@VencimientoDesde", SqlDbType.DateTime ));
				if (VencimientoDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@VencimientoDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(VencimientoDesde.Year,VencimientoDesde.Month,VencimientoDesde.Day,0,0,0,0);
					cmd.Parameters[ "@VencimientoDesde"].Value = d;
				}


				cmd.Parameters.Add( new SqlParameter( "@VencimientoHasta", SqlDbType.DateTime ));
				if (VencimientoHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@VencimientoHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(VencimientoHasta.Year,VencimientoHasta.Month,VencimientoHasta.Day,23,59,0,0);
				
					cmd.Parameters[ "@VencimientoHasta"].Value = h;
				}

				cmd.Parameters.Add( new SqlParameter( "@RecepcionDesde", SqlDbType.DateTime ));
				if (RecepcionDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@RecepcionDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(RecepcionDesde.Year,RecepcionDesde.Month,RecepcionDesde.Day,0,0,0,0);
					cmd.Parameters[ "@RecepcionDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@RecepcionHasta", SqlDbType.DateTime ));
				if (RecepcionHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@RecepcionHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(RecepcionHasta.Year,RecepcionHasta.Month,RecepcionHasta.Day,23,59,0,0);
				
					cmd.Parameters[ "@RecepcionHasta"].Value = h;
				}

				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar));
				if(IdResponsable =="" || IdResponsable == null)cmd.Parameters[ "@IdResponsable"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@IdResponsable"].Value = IdResponsable;
			
				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
				if (IdSucursal != long.MinValue)
				{
					cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;
				}
				else
				{
					cmd.Parameters[ "@IdSucursal"].Value = System.DBNull.Value;
				}
				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
				if (IdEmpresa != long.MinValue)
				{
					cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
				}
				else
				{
					cmd.Parameters[ "@IdEmpresa"].Value = System.DBNull.Value;
				}
				
				

				cmd.Parameters.Add( new SqlParameter( "@VerHTML", SqlDbType.Bit ));
				cmd.Parameters[ "@VerHTML"].Value = VerHTML;
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tpu_ComprobantesPendientes" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);
				//cnx.Close();
				return data;
			}
			catch(Exception e){;return null;}
			
		}
        //Fin Tarea 836

        //Cristian Tarea 836
        public static System.Data.DataSet ListarPreOrdenesDeCompraEditables(string IdProveedor, DateTime FechaDesde, DateTime FechaHasta, DateTime CreacionDesde, DateTime CreacionHasta, string IdResponsable, long IdSucursal, long IdEmpresa)
		{			
			try
			{
				SqlConnection cnx = dbhelper.Connection.GetConnection();
				cnx.Open();
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_ListarPreOrdenesDeCompraEditables", cnx );
				
				cmd.CommandType = CommandType.StoredProcedure;

			
				cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
				if(IdProveedor=="" || IdProveedor==null)cmd.Parameters[ "@IdProveedor" ].Value = System.DBNull.Value;
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
                cmd.Parameters.Add(new SqlParameter("@FechaCreacionDesde", SqlDbType.DateTime));
                if (CreacionDesde.Equals(DateTime.MinValue)) cmd.Parameters["@FechaCreacionDesde"].Value = System.DBNull.Value;
                else
                {
                    DateTime d = new DateTime(CreacionDesde.Year, CreacionDesde.Month, CreacionDesde.Day, 0, 0, 0, 0);
                    cmd.Parameters["@FechaCreacionDesde"].Value = d;
                }

                cmd.Parameters.Add(new SqlParameter("@FechaCreacionHasta", SqlDbType.DateTime));
                if (CreacionHasta.Equals(DateTime.MinValue)) cmd.Parameters["@FechaCreacionHasta"].Value = System.DBNull.Value;
                else
                {
                    DateTime h = new DateTime(CreacionHasta.Year, CreacionHasta.Month, CreacionHasta.Day, 23, 59, 0, 0);

                    cmd.Parameters["@FechaCreacionHasta"].Value = h;
                }
                //Fin Cristian Tarea 836

				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar));
				if(IdResponsable =="" || IdResponsable == null)cmd.Parameters[ "@IdResponsable"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@IdResponsable"].Value = IdResponsable;
			
				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
				if (IdSucursal != long.MinValue)
				{
					cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;
				}
				else
				{
					cmd.Parameters[ "@IdSucursal"].Value = System.DBNull.Value;
				}
				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
				if (IdEmpresa != long.MinValue)
				{
					cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
				}
				else
				{
					cmd.Parameters[ "@IdEmpresa"].Value = System.DBNull.Value;
				}
				
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tpu_ComprobantesPendientes" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);
				//cnx.Close();

				return data;
			}
			catch(Exception e){;return null;}
		}
        //Fin Cristian - tarea 836

        //Cristian 20100920 Tarea 836
        public static System.Data.DataSet ListarComprobanteDeCompraCabeceraEditables(string tiposComprobantesOrigen, string IdProveedor, DateTime EmisionDesde, DateTime EmisionHasta, DateTime VencimientoDesde, DateTime VencimientoHasta, DateTime RecepcionDesde, DateTime RecepcionHasta, DateTime CreacionDesde, DateTime CreacionHasta, string IdResponsable, long IdSucursal, long IdEmpresa)
		{

			try
			{
				SqlConnection cnx = dbhelper.Connection.GetConnection();
				cnx.Open();
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_ListarComprobantesComprasCabeceraEditables", cnx );
				
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesOrigen", SqlDbType.VarChar ) );
				/*	if (tiposComprobantesOrigen =="" || tiposComprobantesOrigen == null) cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = System.DBNull.Value;
					else*/
				cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = tiposComprobantesOrigen;
				
				
			
				cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
				if(IdProveedor=="" || IdProveedor==null)cmd.Parameters[ "@IdProveedor" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdProveedor" ].Value = IdProveedor;

			
				cmd.Parameters.Add( new SqlParameter( "@EmisionDesde", SqlDbType.DateTime ));
				if (EmisionDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@EmisionDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(EmisionDesde.Year,EmisionDesde.Month,EmisionDesde.Day,0,0,0,0);
					cmd.Parameters[ "@EmisionDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@EmisionHasta", SqlDbType.DateTime ));
				if (EmisionHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@EmisionHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(EmisionHasta.Year,EmisionHasta.Month,EmisionHasta.Day,23,59,0,0);
				
					cmd.Parameters[ "@EmisionHasta"].Value = h;
				}

				cmd.Parameters.Add( new SqlParameter( "@VencimientoDesde", SqlDbType.DateTime ));
				if (VencimientoDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@VencimientoDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(VencimientoDesde.Year,VencimientoDesde.Month,VencimientoDesde.Day,0,0,0,0);
					cmd.Parameters[ "@VencimientoDesde"].Value = d;
				}


				cmd.Parameters.Add( new SqlParameter( "@VencimientoHasta", SqlDbType.DateTime ));
				if (VencimientoHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@VencimientoHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(VencimientoHasta.Year,VencimientoHasta.Month,VencimientoHasta.Day,23,59,0,0);
				
					cmd.Parameters[ "@VencimientoHasta"].Value = h;
				}

				cmd.Parameters.Add( new SqlParameter( "@RecepcionDesde", SqlDbType.DateTime ));
				if (RecepcionDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@RecepcionDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(RecepcionDesde.Year,RecepcionDesde.Month,RecepcionDesde.Day,0,0,0,0);
					cmd.Parameters[ "@RecepcionDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@RecepcionHasta", SqlDbType.DateTime ));
				if (RecepcionHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@RecepcionHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(RecepcionHasta.Year,RecepcionHasta.Month,RecepcionHasta.Day,23,59,0,0);
				
					cmd.Parameters[ "@RecepcionHasta"].Value = h;
				}

                //Cristian 20100920 Tarea 836
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
				if(IdResponsable =="" || IdResponsable == null)cmd.Parameters[ "@IdResponsable"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@IdResponsable"].Value = IdResponsable;
			
				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
				if (IdSucursal != long.MinValue)
				{
					cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;
				}
				else
				{
					cmd.Parameters[ "@IdSucursal"].Value = System.DBNull.Value;
				}
				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
				if (IdEmpresa != long.MinValue)
				{
					cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
				}
				else
				{
					cmd.Parameters[ "@IdEmpresa"].Value = System.DBNull.Value;
				}
				
				
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tpu_ComprobantesPendientes" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);
				//cnx.Close();
				return data;
			}
			catch(Exception e){;return null;}
			
		}
        //Fin Cristian tarea 836


		public static tpu_ComprobantesRelacionOrigenDestinoDataset GetRelacionOrigenDestinoPreOrdenDeCompra( string IdComprobanteDestino, long IdOrdinalDestino)
		{			
			try
			{
				SqlConnection cnx = dbhelper.Connection.GetConnection();
				cnx.Open();
				tpu_ComprobantesRelacionOrigenDestinoDataset data = new tpu_ComprobantesRelacionOrigenDestinoDataset();
				SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_ListarRelacionOrigenDestinoPreOrdenDeCompra", cnx );
				
				cmd.CommandType = CommandType.StoredProcedure;

			
				cmd.Parameters.Add( new SqlParameter( "@IdComprobanteDestino", SqlDbType.VarChar ) );
				if(IdComprobanteDestino=="" || IdComprobanteDestino==null)cmd.Parameters[ "@IdComprobanteDestino" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdComprobanteDestino" ].Value = IdComprobanteDestino;
			
				cmd.Parameters.Add( new SqlParameter( "@IdOrdinalDestino", SqlDbType.BigInt));
				if(IdOrdinalDestino ==long.MinValue)
					cmd.Parameters[ "@IdOrdinalDestino"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@IdOrdinalDestino"].Value = IdOrdinalDestino;
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "tpu_ComprobantesRelacionOrigenDestino" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);
				//cnx.Close();

				return data;
			}
			catch(Exception e){;return null;}
		}

/*
				return data;
			}
			catch(Exception e){;return null;}
			
		}

*/
		
		public static System.Data.DataSet ListarComprobantesDeCompraPendienteItems( string tiposComprobantesOrigen, string IdProveedor, DateTime EmisionDesde, DateTime EmisionHasta, DateTime RecepcionDesde, DateTime RecepcionHasta, string IdResponsable, long IdSucursal, long IdEmpresa, bool VerHTML, string Estados)
		{

			try
			{
				SqlConnection cnx = dbhelper.Connection.GetConnection();
				cnx.Open();
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesDeCompra_PendienteItems", cnx );
				
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesOrigen", SqlDbType.VarChar ) );
				/*	if (tiposComprobantesOrigen =="" || tiposComprobantesOrigen == null) cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = System.DBNull.Value;
					else*/
				cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = tiposComprobantesOrigen;
				
				
			
				cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
				if(IdProveedor=="" || IdProveedor==null)cmd.Parameters[ "@IdProveedor" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdProveedor" ].Value = IdProveedor;

				
				cmd.Parameters.Add( new SqlParameter( "@EmisionDesde", SqlDbType.DateTime ));
				if (EmisionDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@EmisionDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(EmisionDesde.Year,EmisionDesde.Month,EmisionDesde.Day,0,0,0,0);
					cmd.Parameters[ "@EmisionDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@EmisionHasta", SqlDbType.DateTime ));
				if (EmisionHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@EmisionHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(EmisionHasta.Year,EmisionHasta.Month,EmisionHasta.Day,23,59,0,0);
				
					cmd.Parameters[ "@EmisionHasta"].Value = h;
				}

				

				cmd.Parameters.Add( new SqlParameter( "@RecepcionDesde", SqlDbType.DateTime ));
				if (RecepcionDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@RecepcionDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(RecepcionDesde.Year,RecepcionDesde.Month,RecepcionDesde.Day,0,0,0,0);
					cmd.Parameters[ "@RecepcionDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@RecepcionHasta", SqlDbType.DateTime ));
				if (RecepcionHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@RecepcionHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(RecepcionHasta.Year,RecepcionHasta.Month,RecepcionHasta.Day,23,59,0,0);
				
					cmd.Parameters[ "@RecepcionHasta"].Value = h;
				}

				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar));
				if(IdResponsable =="" || IdResponsable == null)cmd.Parameters[ "@IdResponsable"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@IdResponsable"].Value = IdResponsable;
			
				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
				if (IdSucursal != long.MinValue)
				{
					cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;
				}
				else
				{
					cmd.Parameters[ "@IdSucursal"].Value = System.DBNull.Value;
				}
				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
				if (IdEmpresa != long.MinValue)
				{
					cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
				}
				else
				{
					cmd.Parameters[ "@IdEmpresa"].Value = System.DBNull.Value;
				}

				cmd.Parameters.Add( new SqlParameter( "@Estados", SqlDbType.VarChar ) );
				if(Estados=="" || Estados==null)cmd.Parameters[ "@Estados" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Estados" ].Value = Estados;
				
				

				cmd.Parameters.Add( new SqlParameter( "@VerHTML", SqlDbType.Bit ));
				cmd.Parameters[ "@VerHTML"].Value = VerHTML;
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tpu_ComprobantesPendientes" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);
				//cnx.Close();

				return data;
			}
			catch(Exception e){;return null;}
			
		}


		// Cristian 20100920 Tarea 836
        public static System.Data.DataSet ListarComprobantesDeCompra(string tiposComprobantesOrigen, string IdProveedor, DateTime EmisionDesde, DateTime EmisionHasta, DateTime RecepcionDesde, DateTime RecepcionHasta, DateTime CreacionDesde, DateTime CreacionHasta, string IdResponsable, long IdSucursal, long IdEmpresa, bool VerHTML, string Estados)
		{

			try
			{
				SqlConnection cnx = dbhelper.Connection.GetConnection();
				cnx.Open();
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_ListarComprobantesCompras", cnx );
				
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesOrigen", SqlDbType.VarChar ) );
				/*	if (tiposComprobantesOrigen =="" || tiposComprobantesOrigen == null) cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = System.DBNull.Value;
					else*/
				cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = tiposComprobantesOrigen;
				
				
			
				cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
				if(IdProveedor=="" || IdProveedor==null)cmd.Parameters[ "@IdProveedor" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdProveedor" ].Value = IdProveedor;

				
				cmd.Parameters.Add( new SqlParameter( "@EmisionDesde", SqlDbType.DateTime ));
				if (EmisionDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@EmisionDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(EmisionDesde.Year,EmisionDesde.Month,EmisionDesde.Day,0,0,0,0);
					cmd.Parameters[ "@EmisionDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@EmisionHasta", SqlDbType.DateTime ));
				if (EmisionHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@EmisionHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(EmisionHasta.Year,EmisionHasta.Month,EmisionHasta.Day,23,59,0,0);
				
					cmd.Parameters[ "@EmisionHasta"].Value = h;
				}

                //Cristian 20100920 Tarea 836

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
                //Fin Cristian Tarea 836
				

				cmd.Parameters.Add( new SqlParameter( "@RecepcionDesde", SqlDbType.DateTime ));
				if (RecepcionDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@RecepcionDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(RecepcionDesde.Year,RecepcionDesde.Month,RecepcionDesde.Day,0,0,0,0);
					cmd.Parameters[ "@RecepcionDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@RecepcionHasta", SqlDbType.DateTime ));
				if (RecepcionHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@RecepcionHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(RecepcionHasta.Year,RecepcionHasta.Month,RecepcionHasta.Day,23,59,0,0);
				
					cmd.Parameters[ "@RecepcionHasta"].Value = h;
				}

				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar));
				if(IdResponsable =="" || IdResponsable == null)cmd.Parameters[ "@IdResponsable"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@IdResponsable"].Value = IdResponsable;
			
				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
				if (IdSucursal != long.MinValue)
				{
					cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;
				}
				else
				{
					cmd.Parameters[ "@IdSucursal"].Value = System.DBNull.Value;
				}
				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
				if (IdEmpresa != long.MinValue)
				{
					cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
				}
				else
				{
					cmd.Parameters[ "@IdEmpresa"].Value = System.DBNull.Value;
				}

				cmd.Parameters.Add( new SqlParameter( "@Estados", SqlDbType.VarChar ) );
				if(Estados=="" || Estados==null)cmd.Parameters[ "@Estados" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Estados" ].Value = Estados;
				
				

				cmd.Parameters.Add( new SqlParameter( "@VerHTML", SqlDbType.Bit ));
				cmd.Parameters[ "@VerHTML"].Value = VerHTML;
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tpu_ComprobantesPendientes" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);
				//cnx.Close();

				return data;
			}
			catch(Exception e){;return null;}
			
		}
        //Fin Cristian Tarea 836

		public static System.Data.DataSet ListarComprobantesDeCompraPendientes( string IdProveedor, DateTime FechaDesde, DateTime FechaHasta, long IdSucursal, long IdEmpresa, bool VerHTML)
		{

			try
			{
				SqlConnection cnx = dbhelper.Connection.GetConnection();
				cnx.Open();
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_tpu_Comprobantes_SeguimientoCompras", cnx );
				
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
				if(IdProveedor=="" || IdProveedor==null)
					cmd.Parameters[ "@IdProveedor" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdProveedor" ].Value = IdProveedor;

				
				cmd.Parameters.Add( new SqlParameter( "@FechaDesde", SqlDbType.DateTime ));
				if (FechaDesde.Equals(DateTime.MinValue))
					cmd.Parameters[ "@FechaDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(FechaDesde.Year,FechaDesde.Month,FechaDesde.Day,0,0,0,0);
					cmd.Parameters[ "@FechaDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@FechaHasta", SqlDbType.DateTime ));
				if (FechaHasta.Equals(DateTime.MinValue)) 
					cmd.Parameters[ "@FechaHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(FechaHasta.Year,FechaHasta.Month,FechaHasta.Day,23,59,0,0);
				
					cmd.Parameters[ "@FechaHasta"].Value = h;
				}

				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
				if (IdSucursal != long.MinValue)
				{
					cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;
				}
				else
				{
					cmd.Parameters[ "@IdSucursal"].Value = System.DBNull.Value;
				}
				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
				if (IdEmpresa != long.MinValue)
				{
					cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
				}
				else
				{
					cmd.Parameters[ "@IdEmpresa"].Value = System.DBNull.Value;
				}

				cmd.Parameters.Add( new SqlParameter( "@VerHTML", SqlDbType.Bit ));
				cmd.Parameters[ "@VerHTML"].Value = VerHTML;
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tpu_Comprobantes_SeguimientoCompras" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);
				//cnx.Close();

				return data;
			}
			catch(Exception e){;return null;}
			
		}

        //Cristian Tarea 836
        public static System.Data.DataSet ListarDetalleComprobantesDeCompra(string tiposComprobantesOrigen, string IdProveedor, DateTime EmisionDesde, DateTime EmisionHasta, DateTime RecepcionDesde, DateTime RecepcionHasta, DateTime CreacionDesde, DateTime CreacionHasta, string IdResponsable, long IdSucursal, long IdEmpresa, bool VerHTML, string Estados, string IdProducto, string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, string IdJerarquia4, string IdJerarquia5, string IdJerarquia6, string IdJerarquia7, string IdJerarquia8)
		{

			try
			{
				SqlConnection cnx = dbhelper.Connection.GetConnection();
				cnx.Open();
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_tpu_DetalleComprobantesDeCompra", cnx );
				
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesOrigen", SqlDbType.VarChar ) );
				/*	if (tiposComprobantesOrigen =="" || tiposComprobantesOrigen == null) cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = System.DBNull.Value;
					else*/
				cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = tiposComprobantesOrigen;
				
				
			
				cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
				if(IdProveedor=="" || IdProveedor==null)cmd.Parameters[ "@IdProveedor" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdProveedor" ].Value = IdProveedor;

				
				cmd.Parameters.Add( new SqlParameter( "@EmisionDesde", SqlDbType.DateTime ));
				if (EmisionDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@EmisionDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(EmisionDesde.Year,EmisionDesde.Month,EmisionDesde.Day,0,0,0,0);
					cmd.Parameters[ "@EmisionDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@EmisionHasta", SqlDbType.DateTime ));
				if (EmisionHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@EmisionHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(EmisionHasta.Year,EmisionHasta.Month,EmisionHasta.Day,23,59,0,0);
				
					cmd.Parameters[ "@EmisionHasta"].Value = h;
				}

				

				cmd.Parameters.Add( new SqlParameter( "@RecepcionDesde", SqlDbType.DateTime ));
				if (RecepcionDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@RecepcionDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(RecepcionDesde.Year,RecepcionDesde.Month,RecepcionDesde.Day,0,0,0,0);
					cmd.Parameters[ "@RecepcionDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@RecepcionHasta", SqlDbType.DateTime ));
				if (RecepcionHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@RecepcionHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(RecepcionHasta.Year,RecepcionHasta.Month,RecepcionHasta.Day,23,59,0,0);
				
					cmd.Parameters[ "@RecepcionHasta"].Value = h;
				}

                //Cristian 20100920 Tarea 836
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
				if(IdResponsable =="" || IdResponsable == null)cmd.Parameters[ "@IdResponsable"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@IdResponsable"].Value = IdResponsable;
			
				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
				if (IdSucursal != long.MinValue)
				{
					cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;
				}
				else
				{
					cmd.Parameters[ "@IdSucursal"].Value = System.DBNull.Value;
				}
				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
				if (IdEmpresa != long.MinValue)
				{
					cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
				}
				else
				{
					cmd.Parameters[ "@IdEmpresa"].Value = System.DBNull.Value;
				}

				cmd.Parameters.Add( new SqlParameter( "@Estados", SqlDbType.VarChar ) );
				if(Estados=="" || Estados==null)cmd.Parameters[ "@Estados" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Estados" ].Value = Estados;
				
				

				cmd.Parameters.Add( new SqlParameter( "@VerHTML", SqlDbType.Bit ));
				cmd.Parameters[ "@VerHTML"].Value = VerHTML;

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


			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tpu_ComprobantesPendientes" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);
				//cnx.Close();

				return data;
			}
			catch(Exception e){;return null;}
			
		}
        // Fin Tarea 836

    //Cristian Tarea 836
	public static System.Data.DataSet ListarComprobantesDeCompraPendientes( string tiposComprobantesOrigen, string IdProveedor, DateTime FechaDesde, DateTime FechaHasta,DateTime CreacionDesde,DateTime CreacionHasta, string IdResponsable, long IdSucursal, long IdEmpresa, bool VerHTML, string TiposComprobantesDestinoExcluidos)
		{			
			try
			{
				SqlConnection cnx = dbhelper.Connection.GetConnection();
				cnx.Open();
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_ListarComprobantesComprasPendientes", cnx );
				
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesOrigen", SqlDbType.VarChar ) );
				if (tiposComprobantesOrigen =="" || tiposComprobantesOrigen == null) cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = tiposComprobantesOrigen;
				
				
			
				cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
				if(IdProveedor=="" || IdProveedor==null)cmd.Parameters[ "@IdProveedor" ].Value = System.DBNull.Value;
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
                cmd.Parameters.Add(new SqlParameter("@FechaCreacionDesde", SqlDbType.DateTime));
                if (CreacionDesde.Equals(DateTime.MinValue)) cmd.Parameters["@FechaCreacionDesde"].Value = System.DBNull.Value;
                else
                {
                    DateTime d = new DateTime(CreacionDesde.Year, CreacionDesde.Month, FechaDesde.Day, 0, 0, 0, 0);
                    cmd.Parameters["@FechaCreacionDesde"].Value = d;
                }

                cmd.Parameters.Add(new SqlParameter("@FechaCreacionHasta", SqlDbType.DateTime));
                if (CreacionHasta.Equals(DateTime.MinValue)) cmd.Parameters["@FechaCreacionHasta"].Value = System.DBNull.Value;
                else
                {
                    DateTime h = new DateTime(CreacionHasta.Year, CreacionHasta.Month, CreacionHasta.Day, 23, 59, 0, 0);

                    cmd.Parameters["@FechaCreacionHasta"].Value = h;
                }
                //Fin Tarea 836

				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar));
				if(IdResponsable =="" || IdResponsable == null)cmd.Parameters[ "@IdResponsable"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@IdResponsable"].Value = IdResponsable;
			
				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
				if (IdSucursal != long.MinValue)
				{
					cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;
				}
				else
				{
					cmd.Parameters[ "@IdSucursal"].Value = System.DBNull.Value;
				}
				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
				if (IdEmpresa != long.MinValue)
				{
					cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
				}
				else
				{
					cmd.Parameters[ "@IdEmpresa"].Value = System.DBNull.Value;
				}
				
				cmd.Parameters.Add( new SqlParameter( "@TiposDeComprobanteDestinoExcluidos", SqlDbType.VarChar));
				if(TiposComprobantesDestinoExcluidos =="")cmd.Parameters[ "@TiposDeComprobanteDestinoExcluidos"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposDeComprobanteDestinoExcluidos"].Value = TiposComprobantesDestinoExcluidos;


				cmd.Parameters.Add( new SqlParameter( "@VerHTML", SqlDbType.Bit ));
				cmd.Parameters[ "@VerHTML"].Value = VerHTML;
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tpu_ComprobantesPendientes" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);
				//cnx.Close();

				return data;
			}
			catch(Exception e){;return null;}
		}
        //Fin Tarea 836

		public static System.Data.DataSet DetalleComprobantesDeCompra( string IdTipoDeComprobante, string IdProveedor, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, long IdSucursal, long IdEmpresa)
		{			
			try
			{
				SqlConnection cnx = dbhelper.Connection.GetConnection();
				cnx.Open();
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_tpu_DetalleComprobantesDeCompra", cnx );
				
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar ) );
				if (IdTipoDeComprobante =="" || IdTipoDeComprobante == null) cmd.Parameters[ "@IdTipoDeComprobante" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdTipoDeComprobante" ].Value = IdTipoDeComprobante;
				
				
				cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
				if(IdProveedor=="" || IdProveedor==null)cmd.Parameters[ "@IdProveedor" ].Value = System.DBNull.Value;
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

				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar));
				if(IdResponsable =="" || IdResponsable == null)cmd.Parameters[ "@IdResponsable"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@IdResponsable"].Value = IdResponsable;
			
				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
				if (IdSucursal != long.MinValue)
				{
					cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;
				}
				else
				{
					cmd.Parameters[ "@IdSucursal"].Value = System.DBNull.Value;
				}
				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
				if (IdEmpresa != long.MinValue)
				{
					cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
				}
				else
				{
					cmd.Parameters[ "@IdEmpresa"].Value = System.DBNull.Value;
				}
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tpu_ComprobantesPendientes" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);
				//cnx.Close();

				return data;
			}
			catch(Exception e){;return null;}
		}


		public static void Update( tpu_ComprobantesExDataset data , string IdVariable, SentenciasReplicacion replicacion)
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				tpu_Comprobantes.Update( data.Tables["tpu_Comprobantes"], trx, replicacion);
				sy_Variables.Update(IdVariable,(string) data.Tables["tpu_Comprobantes"].Rows[0]["Numero"],trx);				
				tpu_ComprobantesDet.Update( data.Tables["tpu_ComprobantesDet"], trx, replicacion);							
				tlg_MovimientosDeStock.Update(data.Tables["tlg_MovimientosDeStock"], trx, replicacion);				
				tpu_ComprobantesRelacionOrigenDestino.Update( data.Tables["tpu_ComprobantesRelacionOrigenDestino"], trx, replicacion, (string)data.Tables["tpu_Comprobantes"].Rows[0]["IdComprobante"] );
				replicacion.Update();
				mz.erp.dataaccess.sy_SentenciasReplicacion.Update(replicacion.Data.sy_SentenciasReplicacion, trx);
			
				trx.Commit();
			}
			catch (System.Exception e )
			{
				trx.Rollback();
				//Logger.ApplicationLog.WriteError(e.ToString());
				data.tpu_Comprobantes.Rows[0].SetColumnError("IdComprobante","No se ha podido realizar la grabación por un error en los datos");
			}
			finally
			{
				cnx.Close();				
			}
		}


		#region Workflow


		public static void Update( tpu_ComprobantesDataset dataComprobantes, tpu_ComprobantesDetDataset dataComprobantesDet,
			tlg_MovimientosDeStockDataset dataMov, tpu_ComprobantesRelacionOrigenDestinoDataset dataRel,
			string IdVariable , SentenciasReplicacion replicacion, string IdTransaction, DataSet dataGeneral, string claveTabla)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			try
			{
				tpu_Comprobantes.Update( dataComprobantes.Tables["tpu_Comprobantes"], trx, replicacion);
				UpdateIdComprobante( dataComprobantes.Tables["tpu_Comprobantes"], dataComprobantesDet.Tables["tpu_ComprobantesDet"],dataRel.Tables["tpu_ComprobantesRelacionOrigenDestino"]);
				sy_Variables.Update(IdVariable,(string) dataComprobantes.Tables["tpu_Comprobantes"].Rows[0]["Numero"],trx);				
				tpu_ComprobantesDet.Update( dataComprobantesDet.Tables["tpu_ComprobantesDet"], trx, replicacion);							
				tlg_MovimientosDeStock.Update( dataMov.Tables["tlg_MovimientosDeStock"],trx,replicacion);
				tpu_ComprobantesMovimientosDeStockDataset dataCompMov = new tpu_ComprobantesMovimientosDeStockDataset();
				string IdComprobante = Convert.ToString(dataComprobantes.Tables["tpu_Comprobantes"].Rows[0]["IdComprobante"]);
				foreach( System.Data.DataRow _row in dataMov.Tables["tlg_MovimientosDeStock"].Rows )
				{
					tpu_ComprobantesMovimientosDeStockDataset.tpu_ComprobantesMovimientosDeStockRow _rowMovimiento = dataCompMov.tpu_ComprobantesMovimientosDeStock.Newtpu_ComprobantesMovimientosDeStockRow();
					_rowMovimiento["IdComprobante"] = IdComprobante;
					_rowMovimiento["IdMovimientoDeStock"] = _row["IdMovimientoDeStock"];
					dataCompMov.tpu_ComprobantesMovimientosDeStock.Addtpu_ComprobantesMovimientosDeStockRow ( _rowMovimiento );
				}
				mz.erp.dataaccess.tpu_ComprobantesMovimientosDeStock.Update( dataCompMov.Tables["tpu_ComprobantesMovimientosDeStock"], trx );
				tpu_ComprobantesRelacionOrigenDestino.Update( dataRel.Tables["tpu_ComprobantesRelacionOrigenDestino"], trx, replicacion, (string)dataComprobantes.Tables["tpu_Comprobantes"].Rows[0]["IdComprobante"] );
				if(claveTabla != null && claveTabla != string.Empty) 
					UpdateRelaciones(trx,IdComprobante, dataGeneral, claveTabla);
				replicacion.Update();
				mz.erp.dataaccess.sy_SentenciasReplicacion.Update(replicacion.Data.sy_SentenciasReplicacion, trx);
				//trx.Commit();
			}
			catch (System.Exception e )
			{
				dataComprobantes.tpu_Comprobantes.Rows[0].SetColumnError("IdComprobante","No se ha podido realizar la grabación por un error en los datos");
				throw e;
			}
			
		}

		private static void UpdateRelaciones(SqlTransaction trx, string IdComprobante, DataSet dataGeneral, string claveTabla)
		{
			foreach(DataRow row in dataGeneral.Tables[0].Rows)
			{
				row["IdComprobanteDestino"] = IdComprobante;
			}
			switch (claveTabla)
			{
					//OCRMX, OCFA, POCOC, FANC, RMXNC
				case "OCRMX" : mz.erp.dataaccess.tpu_OrdenesDeComprasRemitos.Update(dataGeneral.Tables[0], trx);break;

			}
		}

		private static void UpdateIdComprobante(DataTable comp, DataTable compDet, DataTable relacion)
		{
			string IdComprobante = Convert.ToString(comp.Rows[0]["IdComprobante"]);
			foreach(DataRow row in compDet.Rows)
			{
				if(!row.RowState.Equals(DataRowState.Deleted))
                    row["IdComprobante"] = IdComprobante;
			}
			string IdComprobanteDestino  = string.Empty;
			if(relacion.Rows.Count > 0 && !relacion.Rows[0].RowState.Equals(DataRowState.Deleted))
				IdComprobanteDestino = Convert.ToString(relacion.Rows[0]["IdComprobanteDestino"]);
			foreach(DataRow row in relacion.Rows)
			{
				if(!row.RowState.Equals(DataRowState.Deleted))
				{
					string IdCompAux = Convert.ToString(row["IdComprobanteOrigen"]);
					if(IdComprobanteDestino != IdCompAux)
						row["IdComprobanteDestino"] = IdComprobante;
					else row["IdComprobanteOrigen"] = IdComprobante;
				}
			}
		}

		public static System.Data.DataTable ComprobantesPendientesDet( string TiposComprobantesDestino,string TiposComprobantesDestinoExcluidos, string IdComprobante, long Ordinal)
		{			
			try
			{
				System.Data.DataTable data = new DataTable();
				SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_ComprobantesCompraPendientesDet", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;


				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesDestino", SqlDbType.VarChar));
				if(TiposComprobantesDestino =="")cmd.Parameters[ "@TiposComprobantesDestino"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposComprobantesDestino"].Value = TiposComprobantesDestino;


				cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar));
				if(IdComprobante =="")cmd.Parameters[ "@IdComprobante"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@IdComprobante"].Value = IdComprobante;

				cmd.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt ));
				cmd.Parameters[ "@Ordinal"].Value = Ordinal;

				cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ));
				cmd.Parameters[ "@IdProducto"].Value = System.DBNull.Value;

				
				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesDestinoExcluidos", SqlDbType.VarChar));
				if(TiposComprobantesDestinoExcluidos =="")cmd.Parameters[ "@TiposComprobantesDestinoExcluidos"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposComprobantesDestinoExcluidos"].Value = TiposComprobantesDestinoExcluidos;
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tsa_ComprobantesPendientesDet" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);

				return data;
			}
			catch(Exception e)
			{
				return null;
			}
		}


		#endregion

	}
}

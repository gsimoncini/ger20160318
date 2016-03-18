using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Text;
    
using mz.erp.dbhelper;
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

namespace mz.erp.dataaccess
{
	/// <summary>
	/// Descripción breve de st_OrdenReparacion.
	/// </summary>
	public class st_OrdenReparacion
	{
		public st_OrdenReparacion()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		
		public static DataSet GetByComprobanteAsociado(string IdComprobante, long Ordinal)
		{
			DataSet data = new DataSet();

			SqlCommand cmd = new SqlCommand( "st_OrdenReparacion_GetByComprobanteAsociado", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt ) );
			cmd.Parameters[ "@Ordinal" ].Value = Ordinal;

			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "st_OrdenRepracion" );

			adapter.Fill( data );

			
			return data;
		}

		public static st_OrdenReparacionDataset.st_OrdenReparacionRow GetByPk( string IdOrdenReparacion )
		{
			st_OrdenReparacionDataset data = new st_OrdenReparacionDataset();

			SqlCommand cmd = new SqlCommand( "sp_st_OrdenReparacion_Get", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdOrdenReparacion" ].Value = Convert.ToInt32(IdOrdenReparacion);
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "st_OrdenReparacion" );

			adapter.Fill( data );

			if ( data.Tables[0].Rows.Count == 1 )
			{
				return (st_OrdenReparacionDataset.st_OrdenReparacionRow)data.Tables[0].Rows[ 0 ];
			}
			
			return null;
		}

		public static DataSet GetDetalleTareasByPk(string IdOrdenReparacion)
		{
			DataSet data = new DataSet();

			SqlCommand cmd = new SqlCommand( "sp_st_OrdenReparacion_GetDetalleTareasByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdOrdenReparacion" ].Value = IdOrdenReparacion;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "st_OrdenRepracion" );

			adapter.Fill( data );

			
			return data;
		}

		public static DataSet GetDetalleRepuestosByPk(string IdOrdenReparacion)
		{
			DataSet data = new DataSet();

			SqlCommand cmd = new SqlCommand( "sp_st_OrdenReparacion_GetDetalleRepuestosByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdOrdenReparacion" ].Value = IdOrdenReparacion;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "st_OrdenRepracion" );

			adapter.Fill( data );

			
			return data;
		}

		public static DataTable IncluyeProducto(string IdComprobante, long OrdinalOrigen, string IdProducto)
		{
			DataSet data = new DataSet();

			SqlCommand cmd = new SqlCommand( "sp_st_OrdenReparacion_IncluyeProducto", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			cmd.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt ) );
			cmd.Parameters[ "@Ordinal" ].Value = OrdinalOrigen;
		
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "st_OrdenRepracion" );

			adapter.Fill( data );

			
			return data.Tables[0];
		}

		public static DataSet GetProductosParaDevolver(string IdOrdenReparacion, long IdInstanciaOrdenReparacion, string IdEstadosDeStock) 
		{
			DataSet data = new DataSet();

			SqlCommand cmd = new SqlCommand( "Pr_st_DevolucionProductosOR", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdOrdenReparacion" ].Value = IdOrdenReparacion;
			cmd.Parameters.Add( new SqlParameter( "@IdInstanciaOrdenReparacion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdInstanciaOrdenReparacion" ].Value = IdInstanciaOrdenReparacion;

			cmd.Parameters.Add( new SqlParameter( "@IdEstadosDeStock", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdEstadosDeStock" ].Value = IdEstadosDeStock;
		
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "st_OrdenRepracion" );

			adapter.Fill( data );			
			return data;
		}
		
		public static DataSet GetNumerosDeSeriesParaDevolver(long IdOrdenReparacion, long IdInstanciaOrdenReparacion, string IdEstadosDeStock) 
		{
			DataSet data = new DataSet();

			SqlCommand cmd = new SqlCommand( "Pr_st_DevolucionNumerosDeSeriesOR", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdOrdenReparacion" ].Value = IdOrdenReparacion;
			cmd.Parameters.Add( new SqlParameter( "@IdInstanciaOrdenReparacion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdInstanciaOrdenReparacion" ].Value = IdInstanciaOrdenReparacion;

			cmd.Parameters.Add( new SqlParameter( "@IdEstadosDeStock", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdEstadosDeStock" ].Value = IdEstadosDeStock;
		
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "st_OrdenRepracion" );

			adapter.Fill( data );			
			return data;
		}

		
		public static DataSet ListarTareasRealizadas(long IdOrdenReparacion, string IdPersona)
		{
			DataSet data = new DataSet();

			SqlCommand cmd = new SqlCommand( "Pr_st_OrdenReparacion_ListarTareasRealizadas", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdOrdenReparacion" ].Value = IdOrdenReparacion;
			cmd.Parameters.Add( new SqlParameter( "@IdPersona", SqlDbType.VarChar ) );
			if(IdPersona.Equals(string.Empty))
				cmd.Parameters[ "@IdPersona" ].Value = System.DBNull.Value;
			else
                cmd.Parameters[ "@IdPersona" ].Value = IdPersona;

			SqlDataAdapter adapter = new SqlDataAdapter( cmd );			
			//adapter.TableMappings.Add( "Table", "st_InstanciaOrdenReparacion" );

			adapter.Fill( data );			
			return data;
		}

		
		public static DataSet GetComentarios(long IdOrdenReparacion)
		{
			DataSet data = new DataSet();

			SqlCommand cmd = new SqlCommand( "Pr_st_OrdenReparacion_GetComentarios", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdOrdenReparacion" ].Value = IdOrdenReparacion;

			SqlDataAdapter adapter = new SqlDataAdapter( cmd );			
			//adapter.TableMappings.Add( "Table", "st_InstanciaOrdenReparacion" );

			adapter.Fill( data );			
			return data;
		}

		public static DataSet GetFallas(long IdOrdenReparacion)
		{
			DataSet data = new DataSet();

			SqlCommand cmd = new SqlCommand( "Pr_st_OrdenReparacion_GetFallas", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdOrdenReparacion" ].Value = IdOrdenReparacion;

			SqlDataAdapter adapter = new SqlDataAdapter( cmd );			

			adapter.Fill( data );			
			return data;
		}


        public static void Update(DataTable dataTable, string IdTransaction)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			Update(dataTable, trx);
		}
		
		public static void Update(DataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
   
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "st_OrdenReparacion", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdOrdenReparacion", "IdOrdenReparacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdEquipo", "IdEquipo" ),
																											 new System.Data.Common.DataColumnMapping( "IdEstadoOrdenReparacion", "IdEstadoOrdenReparacion" ),
																											 new System.Data.Common.DataColumnMapping( "FechaComprometida", "FechaComprometida" ),
																											 new System.Data.Common.DataColumnMapping( "PeriodoPostReparacion", "PeriodoPostReparacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdRecepcionCliente", "IdRecepcionCliente" ),
																											 new System.Data.Common.DataColumnMapping( "IdUsuarioAlta", "IdUsuarioAlta" ),
																											 new System.Data.Common.DataColumnMapping( "EsGarantia", "EsGarantia" ),
																											 new System.Data.Common.DataColumnMapping( "IdOrdenReparacionAnterior", "IdOrdenReparacionAnterior" ),
																											 new System.Data.Common.DataColumnMapping( "DescripcionFalla", "DescripcionFalla" ),
																											 new System.Data.Common.DataColumnMapping( "IdMotivoSinReparar", "IdMotivoSinReparar" ),
																											 new System.Data.Common.DataColumnMapping( "NumeroFactura", "NumeroFactura" ),
																											 new System.Data.Common.DataColumnMapping( "FechaFactura", "FechaFactura" ),
																											 new System.Data.Common.DataColumnMapping( "FechaEntregaEquipo", "FechaEntregaEquipo" ),
																											 new System.Data.Common.DataColumnMapping( "NombrePersonaQueRetiraEquipo", "NombrePersonaQueRetiraEquipo" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "SinReparar", "SinReparar" ),
																											 new System.Data.Common.DataColumnMapping( "id_falla", "id_falla" ),
																											 new System.Data.Common.DataColumnMapping( "IdFalla", "IdFalla" ),
																											 new System.Data.Common.DataColumnMapping( "IdDeposito", "IdDeposito" ),
																											 new System.Data.Common.DataColumnMapping( "IdSeccion", "IdSeccion" ),
																											 new System.Data.Common.DataColumnMapping( "IdEstanteria", "IdEstanteria" ),
																											 new System.Data.Common.DataColumnMapping( "IdFila", "IdFila" ),
																											 new System.Data.Common.DataColumnMapping( "IdColumna", "IdColumna" ),
																											 new System.Data.Common.DataColumnMapping( "UbicacionTransitoria", "UbicacionTransitoria" ),
                                                                                                             //German 20100825 - Tarea 813
                                                                                                             //new System.Data.Common.DataColumnMapping( "TotalTareasInformado", "TotalTareasInformado" ),
                                                                                                             //Fin German 20100825 - Tarea 813
																											 new System.Data.Common.DataColumnMapping( "IdTipoGarantia", "IdTipoGarantia" ),
																											 new System.Data.Common.DataColumnMapping( "FechaPrefactura", "FechaPrefactura" ),
                                                                                                             							new System.Data.Common.DataColumnMapping( "Origen", "Origen" ),

                                                                                                            //German 20100825 - Tarea 813
					                                                                                        new System.Data.Common.DataColumnMapping( "TipoServicio", "TipoServicio" ),
					                                                                                        new System.Data.Common.DataColumnMapping( "MontoLimite", "MontoLimite" ),
					                                                                                        new System.Data.Common.DataColumnMapping( "TotalAFacturar", "TotalAFacturar" ),
					                                                                                        new System.Data.Common.DataColumnMapping( "Total", "Total" ),
					                                                                                        new System.Data.Common.DataColumnMapping( "TotalTareasAFacturar", "TotalTareasAFacturar" ),
					                                                                                        new System.Data.Common.DataColumnMapping( "TotalTareas", "TotalTareas" ),
					                                                                                        new System.Data.Common.DataColumnMapping( "TotalRepuestos", "TotalRepuestos" ),
					                                                                                        new System.Data.Common.DataColumnMapping( "TotalServicios", "TotalServicios" ),
					                                                                                        new System.Data.Common.DataColumnMapping( "TotalServiciosAFacturar", "TotalServiciosAFacturar" ),
					                                                                                        new System.Data.Common.DataColumnMapping( "TotalTareasAdicionales", "TotalTareasAdicionales" ),
					                                                                                        new System.Data.Common.DataColumnMapping( "TotalTareasAdicionalesAFacturar", "TotalTareasAdicionalesAFacturar" ),
                                                                                                            new System.Data.Common.DataColumnMapping( "ObservacionesEquipo", "ObservacionesEquipo" ),
                                                                                                            new System.Data.Common.DataColumnMapping( "IdComprobanteFactura", "IdComprobanteFactura" ),
                                                                                                            new System.Data.Common.DataColumnMapping( "IdComprobantePrefactura", "IdComprobantePrefactura" )
                                                                                                            
                                                                                                            //Fin German 20100825 - Tarea 813
																											 
																										 }
															  )
														  }
				);
   
			SqlCommand sqlCommandUpdate = new SqlCommand( "sp_st_OrdenReparacion_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;

			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdOrdenReparacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEquipo", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEquipo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEstadoOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEstadoOrdenReparacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaComprometida", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaComprometida", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PeriodoPostReparacion", SqlDbType.Int, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PeriodoPostReparacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdRecepcionCliente", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdRecepcionCliente", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdUsuarioAlta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdUsuarioAlta", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@EsGarantia", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "EsGarantia", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdOrdenReparacionAnterior", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdOrdenReparacionAnterior", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@DescripcionFalla", SqlDbType.VarChar, 2000, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "DescripcionFalla", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdMotivoSinReparar", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdMotivoSinReparar", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@NumeroFactura", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "NumeroFactura", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaFactura", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaFactura", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaEntregaEquipo", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaEntregaEquipo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@NombrePersonaQueRetiraEquipo", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "NombrePersonaQueRetiraEquipo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@SinReparar", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "SinReparar", DataRowVersion.Current, null ) );
			
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdFalla", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdFalla", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdDeposito", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdDeposito", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSeccion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSeccion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEstanteria", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEstanteria", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdFila", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdFila", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdColumna", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdColumna", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UbicacionTransitoria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UbicacionTransitoria", DataRowVersion.Current, null ) );
            //German 20100825 - Tarea 813
			//sqlCommandUpdate.Parameters.Add( new SqlParameter( "@TotalTareasInformado", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "TotalTareasInformado", DataRowVersion.Current, null ) );
            //Fin German 20100825 - Tarea 813
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTipoGarantia", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTipoGarantia", DataRowVersion.Current, null ) );
	
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@NumeroReclamo", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "NumeroReclamo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Accesorios", SqlDbType.VarChar, 250, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Accesorios", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Perifericos", SqlDbType.VarChar, 250, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Perifericos", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Datos", SqlDbType.VarChar, 250, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Datos", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Voltaje", SqlDbType.VarChar, 5, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Voltaje", DataRowVersion.Current, null ) );
            //German 20100825 - Tarea 813
            //sqlCommandUpdate.Parameters.Add( new SqlParameter( "@TotalFallasTipicas", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "TotalFallasTipicas", DataRowVersion.Current, null ) );
            //Fin German 20100825 - Tarea 813
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaPrefactura", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaPrefactura", DataRowVersion.Current, null ) );


            //German 20100825 - Tarea 813
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@Origen", SqlDbType.TinyInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Origen", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@TipoServicio", SqlDbType.TinyInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TipoServicio", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@MontoLimite", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "MontoLimite", DataRowVersion.Current, null));
            /*
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@TotalAFacturar", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TotalAFacturar", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@Total", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@TotalTareasAFacturar", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TotalTareasAFacturar", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@TotalTareas", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TotalTareas", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@TotalRepuestos", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TotalRepuestos", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@TotalServicios", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TotalServicios", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@TotalServiciosAFacturar", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TotalServiciosAFacturar", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@TotalTareasAdicionales", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TotalTareasAdicionales", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@TotalTareasAdicionalesAFacturar", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TotalTareasAdicionalesAFacturar", DataRowVersion.Current, null));
            */
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@ObservacionesEquipo", SqlDbType.VarChar, 8000, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ObservacionesEquipo", DataRowVersion.Current, null));

            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdComprobanteFactura", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobanteFactura", DataRowVersion.Current, null));
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@IdComprobantePrefactura", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobantePrefactura", DataRowVersion.Current, null));
            //Fin German 20100825 - Tarea 813
			
			//sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdOrdenReparacion", DataRowVersion.Original, null ) );
   
			SqlCommand sqlCommandDelete = new SqlCommand( "sp_st_OrdenReparacion_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdOrdenReparacion", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
   
			SqlCommand sqlCommandInsert = new SqlCommand("sp_st_OrdenReparacion_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEquipo", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEquipo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEstadoOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEstadoOrdenReparacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaComprometida", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaComprometida", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PeriodoPostReparacion", SqlDbType.Int, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "PeriodoPostReparacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdRecepcionCliente", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdRecepcionCliente", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdUsuarioAlta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdUsuarioAlta", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@EsGarantia", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "EsGarantia", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdOrdenReparacionAnterior", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdOrdenReparacionAnterior", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@DescripcionFalla", SqlDbType.VarChar, 2000, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "DescripcionFalla", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMotivoSinReparar", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMotivoSinReparar", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@NumeroFactura", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "NumeroFactura", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaFactura", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaFactura", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaEntregaEquipo", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaEntregaEquipo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@NombrePersonaQueRetiraEquipo", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "NombrePersonaQueRetiraEquipo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@SinReparar", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "SinReparar", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@id_falla", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "id_falla", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdFalla", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdFalla", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdDeposito", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdDeposito", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSeccion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSeccion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEstanteria", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEstanteria", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdFila", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdFila", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdColumna", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdColumna", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@UbicacionTransitoria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UbicacionTransitoria", DataRowVersion.Current, null ) );
            //German 20100825 - Tarea 813
			//sqlCommandInsert.Parameters.Add( new SqlParameter( "@TotalTareasInformado", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "TotalTareasInformado", DataRowVersion.Current, null ) );
            //FIn German 20100825 - Tarea 813
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdOrdenReparacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaPrefactura", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaPrefactura", DataRowVersion.Current, null ) );

			adapter.UpdateCommand = sqlCommandUpdate;
			adapter.DeleteCommand = sqlCommandDelete;
			adapter.InsertCommand = sqlCommandInsert;
			adapter.Update ( dataTable );
		}
  
		public void Dispose()
		{
		}
 
  
	}



		
		
	}


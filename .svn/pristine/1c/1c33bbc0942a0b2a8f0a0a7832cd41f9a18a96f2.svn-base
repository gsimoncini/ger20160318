namespace mz.erp.dataaccess 
{
	using System;
	using System.Data;
	using System.Data.SqlClient;
	using System.Text.RegularExpressions;
    
	using mz.erp.dbhelper;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class tpu_ComprobantesCompra : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_ComprobantesCompra()
		{
		}

		public static tpu_ComprobantesCompraDataset GetList()
		{
			tpu_ComprobantesCompraDataset data = new tpu_ComprobantesCompraDataset();

			return ( tpu_ComprobantesCompraDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ComprobantesCompra" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesCompra_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_ComprobantesCompraDataset GetList( long IdComprobanteCompra, long IdProveedor, DateTime Fecha, string Tipo, string Numero, string Comentario, DateTime FechaIngreso, string PeriodoFiscal, decimal NetoBruto, decimal Descuento, decimal SubtotalNeto, decimal IvaInscripto, decimal MontosNoGravados, decimal PrecepcionIB, decimal PrecepcionGanancias, decimal PercepcionIva, decimal ImpuestosInternos, decimal TotalGeneral, decimal DescuentoGlobal, decimal Total, DateTime FechaVencimiento, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			tpu_ComprobantesCompraDataset data = new tpu_ComprobantesCompraDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ComprobantesCompra" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesCompra_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdComprobanteCompra", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdComprobanteCompra" ].Value = IdComprobanteCompra;
			
			cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdProveedor" ].Value = IdProveedor;
			
			cmd.Parameters.Add( new SqlParameter( "@Fecha", SqlDbType.DateTime ) );
			cmd.Parameters[ "@Fecha" ].Value = Fecha;
			
			cmd.Parameters.Add( new SqlParameter( "@Tipo", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Tipo" ].Value = Tipo;
			
			cmd.Parameters.Add( new SqlParameter( "@Numero", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Numero" ].Value = Numero;
			
			cmd.Parameters.Add( new SqlParameter( "@Comentario", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Comentario" ].Value = Comentario;
			
			cmd.Parameters.Add( new SqlParameter( "@FechaIngreso", SqlDbType.DateTime ) );
			cmd.Parameters[ "@FechaIngreso" ].Value = FechaIngreso;
			
			cmd.Parameters.Add( new SqlParameter( "@PeriodoFiscal", SqlDbType.VarChar ) );
			cmd.Parameters[ "@PeriodoFiscal" ].Value = PeriodoFiscal;
			
			cmd.Parameters.Add( new SqlParameter( "@NetoBruto", SqlDbType.Decimal ) );
			cmd.Parameters[ "@NetoBruto" ].Value = NetoBruto;
			
			cmd.Parameters.Add( new SqlParameter( "@Descuento", SqlDbType.Decimal ) );
			cmd.Parameters[ "@Descuento" ].Value = Descuento;
			
			cmd.Parameters.Add( new SqlParameter( "@SubtotalNeto", SqlDbType.Decimal ) );
			cmd.Parameters[ "@SubtotalNeto" ].Value = SubtotalNeto;
			
			cmd.Parameters.Add( new SqlParameter( "@IvaInscripto", SqlDbType.Decimal ) );
			cmd.Parameters[ "@IvaInscripto" ].Value = IvaInscripto;
			
			cmd.Parameters.Add( new SqlParameter( "@MontosNoGravados", SqlDbType.Decimal ) );
			cmd.Parameters[ "@MontosNoGravados" ].Value = MontosNoGravados;
			
			cmd.Parameters.Add( new SqlParameter( "@PrecepcionIB", SqlDbType.Decimal ) );
			cmd.Parameters[ "@PrecepcionIB" ].Value = PrecepcionIB;
			
			cmd.Parameters.Add( new SqlParameter( "@PrecepcionGanancias", SqlDbType.Decimal ) );
			cmd.Parameters[ "@PrecepcionGanancias" ].Value = PrecepcionGanancias;
			
			cmd.Parameters.Add( new SqlParameter( "@PercepcionIva", SqlDbType.Decimal ) );
			cmd.Parameters[ "@PercepcionIva" ].Value = PercepcionIva;
			
			cmd.Parameters.Add( new SqlParameter( "@ImpuestosInternos", SqlDbType.Decimal ) );
			cmd.Parameters[ "@ImpuestosInternos" ].Value = ImpuestosInternos;
			
			cmd.Parameters.Add( new SqlParameter( "@TotalGeneral", SqlDbType.Decimal ) );
			cmd.Parameters[ "@TotalGeneral" ].Value = TotalGeneral;
			
			cmd.Parameters.Add( new SqlParameter( "@DescuentoGlobal", SqlDbType.Decimal ) );
			cmd.Parameters[ "@DescuentoGlobal" ].Value = DescuentoGlobal;
			
			cmd.Parameters.Add( new SqlParameter( "@Total", SqlDbType.Decimal ) );
			cmd.Parameters[ "@Total" ].Value = Total;
			
			cmd.Parameters.Add( new SqlParameter( "@FechaVencimiento", SqlDbType.DateTime ) );
			cmd.Parameters[ "@FechaVencimiento" ].Value = FechaVencimiento;
			
			cmd.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime ) );
			cmd.Parameters[ "@FechaCreacion" ].Value = FechaCreacion;
			
			cmd.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdConexionCreacion" ].Value = IdConexionCreacion;
			
			cmd.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp ) );
			cmd.Parameters[ "@UltimaModificacion" ].Value = UltimaModificacion;
			
			cmd.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdConexionUltimaModificacion" ].Value = IdConexionUltimaModificacion;
			
			cmd.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdReservado" ].Value = IdReservado;
			
			cmd.Parameters.Add( new SqlParameter( "@RowId", SqlDbType.UniqueIdentifier ) );
			cmd.Parameters[ "@RowId" ].Value = RowId;
			
			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;
			
			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;
			

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_ComprobantesCompraDataset.tpu_ComprobantesCompraRow NewRow()
		{
			return ( new tpu_ComprobantesCompraDataset() ).tpu_ComprobantesCompra.Newtpu_ComprobantesCompraRow();
		}
	
		public static tpu_ComprobantesCompraDataset.tpu_ComprobantesCompraRow GetByPk( long IdComprobanteCompra )
		{
			tpu_ComprobantesCompraDataset data = new tpu_ComprobantesCompraDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesCompra_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdComprobanteCompra", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdComprobanteCompra" ].Value = IdComprobanteCompra;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tpu_ComprobantesCompra" );

			adapter.Fill( data );

			if ( data.tpu_ComprobantesCompra.Rows.Count == 1 )
			{
				return ( tpu_ComprobantesCompraDataset.tpu_ComprobantesCompraRow )data.tpu_ComprobantesCompra.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tpu_ComprobantesCompraDataset.tpu_ComprobantesCompraRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tpu_ComprobantesCompraDataset.tpu_ComprobantesCompraDataTable )row.Table ).Addtpu_ComprobantesCompraRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tpu_ComprobantesCompraDataset dataSet )
		{
			Update( dataSet.tpu_ComprobantesCompra );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tpu_ComprobantesCompraDataset.tpu_ComprobantesCompraDataTable )dataTable, trx );
				trx.Commit();
			}
			catch
			{
				trx.Rollback();
			}
			finally
			{
				cnx.Close();
			}
		}

		public static void Update( DataTable dataTable, SqlTransaction trx )
		{
			Update( ( tpu_ComprobantesCompraDataset.tpu_ComprobantesCompraDataTable )dataTable, trx );
		}
				

		public static void Update( tpu_ComprobantesCompraDataset.tpu_ComprobantesCompraDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
					new System.Data.Common.DataTableMapping( "Table", "tpu_ComprobantesCompra", 
						new System.Data.Common.DataColumnMapping[] {
							new System.Data.Common.DataColumnMapping( "IdComprobanteCompra", "IdComprobanteCompra" ),
							new System.Data.Common.DataColumnMapping( "IdProveedor", "IdProveedor" ),
							new System.Data.Common.DataColumnMapping( "Fecha", "Fecha" ),
							new System.Data.Common.DataColumnMapping( "Tipo", "Tipo" ),
							new System.Data.Common.DataColumnMapping( "Numero", "Numero" ),
							new System.Data.Common.DataColumnMapping( "Comentario", "Comentario" ),
							new System.Data.Common.DataColumnMapping( "FechaIngreso", "FechaIngreso" ),
							new System.Data.Common.DataColumnMapping( "PeriodoFiscal", "PeriodoFiscal" ),
							new System.Data.Common.DataColumnMapping( "NetoBruto", "NetoBruto" ),
							new System.Data.Common.DataColumnMapping( "Descuento", "Descuento" ),
							new System.Data.Common.DataColumnMapping( "SubtotalNeto", "SubtotalNeto" ),
							new System.Data.Common.DataColumnMapping( "IvaInscripto", "IvaInscripto" ),
							new System.Data.Common.DataColumnMapping( "MontosNoGravados", "MontosNoGravados" ),
							new System.Data.Common.DataColumnMapping( "PrecepcionIB", "PrecepcionIB" ),
							new System.Data.Common.DataColumnMapping( "PrecepcionGanancias", "PrecepcionGanancias" ),
							new System.Data.Common.DataColumnMapping( "PercepcionIva", "PercepcionIva" ),
							new System.Data.Common.DataColumnMapping( "ImpuestosInternos", "ImpuestosInternos" ),
							new System.Data.Common.DataColumnMapping( "TotalGeneral", "TotalGeneral" ),
							new System.Data.Common.DataColumnMapping( "DescuentoGlobal", "DescuentoGlobal" ),
							new System.Data.Common.DataColumnMapping( "Total", "Total" ),
							new System.Data.Common.DataColumnMapping( "FechaVencimiento", "FechaVencimiento" ),
							new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
							new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
							new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
							new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
							new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
							new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
							new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
							new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" )
						}
					)
				}
			);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tpu_ComprobantesCompra_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdComprobanteCompra", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdComprobanteCompra", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProveedor", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Fecha", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Fecha", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Tipo", SqlDbType.VarChar, 2, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Tipo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Numero", SqlDbType.VarChar, 15, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Numero", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Comentario", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Comentario", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaIngreso", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaIngreso", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PeriodoFiscal", SqlDbType.VarChar, 10, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PeriodoFiscal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@NetoBruto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "NetoBruto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descuento", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descuento", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@SubtotalNeto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "SubtotalNeto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IvaInscripto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IvaInscripto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@MontosNoGravados", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "MontosNoGravados", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PrecepcionIB", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecepcionIB", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PrecepcionGanancias", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecepcionGanancias", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PercepcionIva", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PercepcionIva", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ImpuestosInternos", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "ImpuestosInternos", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@TotalGeneral", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "TotalGeneral", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@DescuentoGlobal", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "DescuentoGlobal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Total", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Total", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaVencimiento", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaVencimiento", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdComprobanteCompra", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobanteCompra", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tpu_ComprobantesCompra_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdComprobanteCompra", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobanteCompra", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tpu_ComprobantesCompra_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProveedor", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Fecha", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Fecha", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Tipo", SqlDbType.VarChar, 2, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Tipo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Numero", SqlDbType.VarChar, 15, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Numero", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Comentario", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Comentario", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaIngreso", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaIngreso", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PeriodoFiscal", SqlDbType.VarChar, 10, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "PeriodoFiscal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@NetoBruto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "NetoBruto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descuento", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descuento", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@SubtotalNeto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "SubtotalNeto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IvaInscripto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IvaInscripto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@MontosNoGravados", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "MontosNoGravados", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PrecepcionIB", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "PrecepcionIB", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PrecepcionGanancias", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "PrecepcionGanancias", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PercepcionIva", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "PercepcionIva", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@ImpuestosInternos", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "ImpuestosInternos", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@TotalGeneral", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "TotalGeneral", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@DescuentoGlobal", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "DescuentoGlobal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Total", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Total", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaVencimiento", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaVencimiento", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdComprobanteCompra", SqlDbType.BigInt, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobanteCompra", DataRowVersion.Current, null ) );

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


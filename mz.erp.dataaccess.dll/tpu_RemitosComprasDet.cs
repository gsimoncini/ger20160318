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

	public class tpu_RemitosComprasDet : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_RemitosComprasDet()
		{
		}

		public static tpu_RemitosComprasDetDataset GetList()
		{
			tpu_RemitosComprasDetDataset data = new tpu_RemitosComprasDetDataset();

			return ( tpu_RemitosComprasDetDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_RemitosComprasDet" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tpu_RemitosComprasDet_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_RemitosComprasDetDataset GetList( long IdRemitoCompra, short Renglon, string IdProducto, decimal Cantidad, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			tpu_RemitosComprasDetDataset data = new tpu_RemitosComprasDetDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_RemitosComprasDet" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_RemitosComprasDet_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdRemitoCompra", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdRemitoCompra" ].Value = IdRemitoCompra;
			
			cmd.Parameters.Add( new SqlParameter( "@Renglon", SqlDbType.SmallInt ) );
			cmd.Parameters[ "@Renglon" ].Value = Renglon;
			
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			
			cmd.Parameters.Add( new SqlParameter( "@Cantidad", SqlDbType.Decimal ) );
			cmd.Parameters[ "@Cantidad" ].Value = Cantidad;
			
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

		public static tpu_RemitosComprasDetDataset.tpu_RemitosComprasDetRow NewRow()
		{
			return ( new tpu_RemitosComprasDetDataset() ).tpu_RemitosComprasDet.Newtpu_RemitosComprasDetRow();
		}
	
		public static tpu_RemitosComprasDetDataset.tpu_RemitosComprasDetRow GetByPk( long IdRemitoCompra, short Renglon )
		{
			tpu_RemitosComprasDetDataset data = new tpu_RemitosComprasDetDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tpu_RemitosComprasDet_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdRemitoCompra", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdRemitoCompra" ].Value = IdRemitoCompra;
			
			cmd.Parameters.Add( new SqlParameter( "@Renglon", SqlDbType.SmallInt ) );
			cmd.Parameters[ "@Renglon" ].Value = Renglon;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tpu_RemitosComprasDet" );

			adapter.Fill( data );

			if ( data.tpu_RemitosComprasDet.Rows.Count == 1 )
			{
				return ( tpu_RemitosComprasDetDataset.tpu_RemitosComprasDetRow )data.tpu_RemitosComprasDet.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tpu_RemitosComprasDetDataset.tpu_RemitosComprasDetRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tpu_RemitosComprasDetDataset.tpu_RemitosComprasDetDataTable )row.Table ).Addtpu_RemitosComprasDetRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tpu_RemitosComprasDetDataset dataSet )
		{
			Update( dataSet.tpu_RemitosComprasDet );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tpu_RemitosComprasDetDataset.tpu_RemitosComprasDetDataTable )dataTable, trx );
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
			Update( ( tpu_RemitosComprasDetDataset.tpu_RemitosComprasDetDataTable )dataTable, trx );
		}
				

		public static void Update( tpu_RemitosComprasDetDataset.tpu_RemitosComprasDetDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
					new System.Data.Common.DataTableMapping( "Table", "tpu_RemitosComprasDet", 
						new System.Data.Common.DataColumnMapping[] {
							new System.Data.Common.DataColumnMapping( "IdRemitoCompra", "IdRemitoCompra" ),
							new System.Data.Common.DataColumnMapping( "Renglon", "Renglon" ),
							new System.Data.Common.DataColumnMapping( "IdProducto", "IdProducto" ),
							new System.Data.Common.DataColumnMapping( "Cantidad", "Cantidad" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tpu_RemitosComprasDet_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdRemitoCompra", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdRemitoCompra", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Renglon", SqlDbType.SmallInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Renglon", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Cantidad", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Cantidad", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdRemitoCompra", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdRemitoCompra", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldRenglon", SqlDbType.SmallInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Renglon", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tpu_RemitosComprasDet_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdRemitoCompra", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdRemitoCompra", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@Renglon", SqlDbType.SmallInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Renglon", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tpu_RemitosComprasDet_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdRemitoCompra", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdRemitoCompra", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Renglon", SqlDbType.SmallInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Renglon", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Cantidad", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Cantidad", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );

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


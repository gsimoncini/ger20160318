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

	public class tpu_ComprobantesMovimientosDeStock : IDisposable
	{
	
		#region Custom Members
		
		public static DataTable GetProductosPendientesDeNumeroDeSerie(string IdComprobante)
		{
			DataSet data = new DataSet();

			SqlCommand cmd = new SqlCommand( "Pr_tpu_Comprobantes_GetProductosPendientesDeNumeroDeSerie", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
			
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tpu_ComprobantesMovimientosDeStock" );

			adapter.Fill( data );

			
			
			return data.Tables[0];		
		}

		public static DataSet GetList( string IdComprobante, string IdMovimientoDeStock )
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ComprobantesMovimientosDeStock" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesMovimientosDeStock_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdMovimientoDeStock", SqlDbType.VarChar ) );
			if(IdMovimientoDeStock != null && !IdMovimientoDeStock.Equals(string.Empty))
				cmd.Parameters[ "@IdMovimientoDeStock" ].Value = IdMovimientoDeStock;
			else cmd.Parameters[ "@IdMovimientoDeStock" ].Value = System.DBNull.Value;
			
			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			if(IdComprobante != null && !IdComprobante.Equals(string.Empty))
				cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
			else cmd.Parameters[ "@IdComprobante" ].Value = System.DBNull.Value;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static DataSet GetNumerosDeSerieByComprobante(string IdComprobante)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesMovimientosDeStock_GetNumerosDeSerieByComprobante", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			
			
			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			if(IdComprobante != null && !IdComprobante.Equals(string.Empty))
				cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
			else cmd.Parameters[ "@IdComprobante" ].Value = System.DBNull.Value;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}


		#endregion
		
		public tpu_ComprobantesMovimientosDeStock()
		{
		}

		public static tpu_ComprobantesMovimientosDeStockDataset GetList()
		{
			tpu_ComprobantesMovimientosDeStockDataset data = new tpu_ComprobantesMovimientosDeStockDataset();

			return ( tpu_ComprobantesMovimientosDeStockDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ComprobantesMovimientosDeStock" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesMovimientosDeStock_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}


		public static tpu_ComprobantesMovimientosDeStockDataset.tpu_ComprobantesMovimientosDeStockRow NewRow()
		{
			return ( new tpu_ComprobantesMovimientosDeStockDataset() ).tpu_ComprobantesMovimientosDeStock.Newtpu_ComprobantesMovimientosDeStockRow();
		}
	
		public static tpu_ComprobantesMovimientosDeStockDataset.tpu_ComprobantesMovimientosDeStockRow GetByPk( string IdMovimientoDeStock, string IdComprobante )
		{
			tpu_ComprobantesMovimientosDeStockDataset data = new tpu_ComprobantesMovimientosDeStockDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesMovimientosDeStock_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdMovimientoDeStock", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdMovimientoDeStock" ].Value = IdMovimientoDeStock;
			
			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tpu_ComprobantesMovimientosDeStock" );

			adapter.Fill( data );

			if ( data.tpu_ComprobantesMovimientosDeStock.Rows.Count == 1 )
			{
				return ( tpu_ComprobantesMovimientosDeStockDataset.tpu_ComprobantesMovimientosDeStockRow )data.tpu_ComprobantesMovimientosDeStock.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tpu_ComprobantesMovimientosDeStockDataset.tpu_ComprobantesMovimientosDeStockRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tpu_ComprobantesMovimientosDeStockDataset.tpu_ComprobantesMovimientosDeStockDataTable )row.Table ).Addtpu_ComprobantesMovimientosDeStockRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tpu_ComprobantesMovimientosDeStockDataset dataSet )
		{
			Update( dataSet.tpu_ComprobantesMovimientosDeStock );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( dataTable, trx );
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
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tpu_ComprobantesMovimientosDeStock", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdComprobante", "IdComprobante" ),
																											 new System.Data.Common.DataColumnMapping( "IdMovimientoDeStock", "IdMovimientoDeStock" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tpu_ComprobantesMovimientosDeStock_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdComprobante", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdMovimientoDeStock", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdMovimientoDeStock", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdMovimientoDeStock", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdMovimientoDeStock", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobante", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tpu_ComprobantesMovimientosDeStock_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdMovimientoDeStock", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMovimientoDeStock", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobante", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tpu_ComprobantesMovimientosDeStock_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobante", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMovimientoDeStock", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMovimientoDeStock", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );

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


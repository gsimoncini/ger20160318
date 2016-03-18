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

	public class tfi_TDCompTesoreria_TipoMovimiento : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tfi_TDCompTesoreria_TipoMovimiento()
		{
		}

		public static tfi_TDCompTesoreria_TipoMovimientoDataset GetList()
		{
			tfi_TDCompTesoreria_TipoMovimientoDataset data = new tfi_TDCompTesoreria_TipoMovimientoDataset();

			return ( tfi_TDCompTesoreria_TipoMovimientoDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_TDCompTesoreria_TipoMovimiento" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tfi_TDCompTesoreria_TipoMovimiento_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tfi_TDCompTesoreria_TipoMovimientoDataset GetList( string IdTipoMovimiento, string IdTdCompTesoreria)
		{
			tfi_TDCompTesoreria_TipoMovimientoDataset data = new tfi_TDCompTesoreria_TipoMovimientoDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_TDCompTesoreria_TipoMovimiento" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_TDCompTesoreria_TipoMovimiento_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@IdTipoMovimiento", SqlDbType.VarChar ) );
			if(IdTipoMovimiento.Equals(string.Empty))
				cmd.Parameters[ "@IdTipoMovimiento" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdTipoMovimiento" ].Value = IdTipoMovimiento;
			cmd.Parameters.Add( new SqlParameter( "@IdTdCompTesoreria", SqlDbType.VarChar ) );
			if(IdTdCompTesoreria.Equals(string.Empty))
				cmd.Parameters[ "@IdTdCompTesoreria" ].Value =  System.DBNull.Value;
			else
				cmd.Parameters[ "@IdTdCompTesoreria" ].Value = IdTdCompTesoreria;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tfi_TDCompTesoreria_TipoMovimientoDataset.tfi_TDCompTesoreria_TipoMovimientoRow NewRow()
		{
			return ( new tfi_TDCompTesoreria_TipoMovimientoDataset() ).tfi_TDCompTesoreria_TipoMovimiento.Newtfi_TDCompTesoreria_TipoMovimientoRow();
		}
	
		public static tfi_TDCompTesoreria_TipoMovimientoDataset.tfi_TDCompTesoreria_TipoMovimientoRow GetByPk( string Id )
		{
			tfi_TDCompTesoreria_TipoMovimientoDataset data = new tfi_TDCompTesoreria_TipoMovimientoDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tfi_TDCompTesoreria_TipoMovimiento_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@Id", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Id" ].Value = Id;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tfi_TDCompTesoreria_TipoMovimiento" );

			adapter.Fill( data );

			if ( data.tfi_TDCompTesoreria_TipoMovimiento.Rows.Count == 1 )
			{
				return ( tfi_TDCompTesoreria_TipoMovimientoDataset.tfi_TDCompTesoreria_TipoMovimientoRow )data.tfi_TDCompTesoreria_TipoMovimiento.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tfi_TDCompTesoreria_TipoMovimientoDataset.tfi_TDCompTesoreria_TipoMovimientoRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tfi_TDCompTesoreria_TipoMovimientoDataset.tfi_TDCompTesoreria_TipoMovimientoDataTable )row.Table ).Addtfi_TDCompTesoreria_TipoMovimientoRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tfi_TDCompTesoreria_TipoMovimientoDataset dataSet )
		{
			Update( dataSet.tfi_TDCompTesoreria_TipoMovimiento );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tfi_TDCompTesoreria_TipoMovimientoDataset.tfi_TDCompTesoreria_TipoMovimientoDataTable )dataTable, trx );
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
			Update( ( tfi_TDCompTesoreria_TipoMovimientoDataset.tfi_TDCompTesoreria_TipoMovimientoDataTable )dataTable, trx );
		}
				

		public static void Update( tfi_TDCompTesoreria_TipoMovimientoDataset.tfi_TDCompTesoreria_TipoMovimientoDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tfi_TDCompTesoreria_TipoMovimiento", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "Id", "Id" ),
																											 new System.Data.Common.DataColumnMapping( "IdTipoMovimiento", "IdTipoMovimiento" ),
																											 new System.Data.Common.DataColumnMapping( "IdTdCompTesoreria", "IdTdCompTesoreria" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tfi_TDCompTesoreria_TipoMovimiento_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Id", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Id", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTipoMovimiento", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTipoMovimiento", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTdCompTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTdCompTesoreria", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldId", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Id", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tfi_TDCompTesoreria_TipoMovimiento_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@Id", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Id", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tfi_TDCompTesoreria_TipoMovimiento_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Id", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Id", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTipoMovimiento", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoMovimiento", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTdCompTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTdCompTesoreria", DataRowVersion.Current, null ) );
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


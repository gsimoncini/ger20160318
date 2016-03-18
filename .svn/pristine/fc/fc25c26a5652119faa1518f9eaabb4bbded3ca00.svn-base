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

	public class tlg_MovimientosDeStockAjustesDatosAuxiliares : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tlg_MovimientosDeStockAjustesDatosAuxiliares()
		{
		}

		public static tlg_MovimientosDeStockAjustesDatosAuxiliaresDataset GetList()
		{
			tlg_MovimientosDeStockAjustesDatosAuxiliaresDataset data = new tlg_MovimientosDeStockAjustesDatosAuxiliaresDataset();

			return ( tlg_MovimientosDeStockAjustesDatosAuxiliaresDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tlg_MovimientosDeStockAjustesDatosAuxiliares" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tlg_MovimientosDeStockAjustesDatosAuxiliares_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		/*public static tlg_MovimientosDeStockAjustesDatosAuxiliaresDataset GetList(  )
		{
			tlg_MovimientosDeStockAjustesDatosAuxiliaresDataset data = new tlg_MovimientosDeStockAjustesDatosAuxiliaresDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tlg_MovimientosDeStockAjustesDatosAuxiliares" );

			SqlCommand cmd = new SqlCommand( "Pr_tlg_MovimientosDeStockAjustesDatosAuxiliares_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}*/

		public static tlg_MovimientosDeStockAjustesDatosAuxiliaresDataset.tlg_MovimientosDeStockAjustesDatosAuxiliaresRow NewRow()
		{
			return ( new tlg_MovimientosDeStockAjustesDatosAuxiliaresDataset() ).tlg_MovimientosDeStockAjustesDatosAuxiliares.Newtlg_MovimientosDeStockAjustesDatosAuxiliaresRow();
		}
	
		public static tlg_MovimientosDeStockAjustesDatosAuxiliaresDataset.tlg_MovimientosDeStockAjustesDatosAuxiliaresRow GetByPk( string IdMovimientoDeStockAjustesDatosAuxiliares )
		{
			tlg_MovimientosDeStockAjustesDatosAuxiliaresDataset data = new tlg_MovimientosDeStockAjustesDatosAuxiliaresDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tlg_MovimientosDeStockAjustesDatosAuxiliares_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdMovimientoDeStockAjustesDatosAuxiliares", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdMovimientoDeStockAjustesDatosAuxiliares" ].Value = IdMovimientoDeStockAjustesDatosAuxiliares;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tlg_MovimientosDeStockAjustesDatosAuxiliares" );

			adapter.Fill( data );

			if ( data.tlg_MovimientosDeStockAjustesDatosAuxiliares.Rows.Count == 1 )
			{
				return ( tlg_MovimientosDeStockAjustesDatosAuxiliaresDataset.tlg_MovimientosDeStockAjustesDatosAuxiliaresRow )data.tlg_MovimientosDeStockAjustesDatosAuxiliares.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tlg_MovimientosDeStockAjustesDatosAuxiliaresDataset.tlg_MovimientosDeStockAjustesDatosAuxiliaresRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tlg_MovimientosDeStockAjustesDatosAuxiliaresDataset.tlg_MovimientosDeStockAjustesDatosAuxiliaresDataTable )row.Table ).Addtlg_MovimientosDeStockAjustesDatosAuxiliaresRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tlg_MovimientosDeStockAjustesDatosAuxiliaresDataset dataSet )
		{
			Update( dataSet.tlg_MovimientosDeStockAjustesDatosAuxiliares );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				SentenciasReplicacion replicacion = new SentenciasReplicacion();
				Update( dataTable, trx, replicacion);
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

		public static void Update( DataTable dataTable, string IdTransaction, SentenciasReplicacion replicacion )
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById( IdTransaction );
			Update( dataTable, trx, replicacion);

		}

		public static void Update( DataTable dataTable, SqlTransaction trx, SentenciasReplicacion replicacion  )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tlg_MovimientosDeStockAjustesDatosAuxiliares", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdMovimientoDeStockAjustesDatosAuxiliares", "IdMovimientoDeStockAjustesDatosAuxiliares" ),
																											 new System.Data.Common.DataColumnMapping( "Observaciones", "Observaciones" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tlg_MovimientosDeStockAjustesDatosAuxiliares_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdMovimientoDeStockAjustesDatosAuxiliares", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdMovimientoDeStockAjustesDatosAuxiliares", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Observaciones", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Observaciones", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdMovimientoDeStockAjustesDatosAuxiliares", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdMovimientoDeStockAjustesDatosAuxiliares", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tlg_MovimientosDeStockAjustesDatosAuxiliares_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdMovimientoDeStockAjustesDatosAuxiliares", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMovimientoDeStockAjustesDatosAuxiliares", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tlg_MovimientosDeStockAjustesDatosAuxiliares_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMovimientoDeStockAjustesDatosAuxiliares", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMovimientoDeStockAjustesDatosAuxiliares", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Observaciones", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Observaciones", DataRowVersion.Current, null ) );
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


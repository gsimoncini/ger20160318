using System;

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

	public class tfi_MovimientosDeCajaAjustes : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tfi_MovimientosDeCajaAjustes()
		{
		}

		public static tfi_MovimientosDeCajaAjustesDataset GetList()
		{
			tfi_MovimientosDeCajaAjustesDataset data = new tfi_MovimientosDeCajaAjustesDataset();

			return ( tfi_MovimientosDeCajaAjustesDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_MovimientosDeCajaAjustes" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tfi_MovimientosDeCajaAjustes_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tfi_MovimientosDeCajaAjustesDataset GetList( string IdMovimientoOrigen, string IdMovimientoAjuste )
		{
				tfi_MovimientosDeCajaAjustesDataset data = new tfi_MovimientosDeCajaAjustesDataset();
			try
			{
			
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "tfi_MovimientosDeCajaAjustes" );

				SqlCommand cmd = new SqlCommand( "Pr_tfi_MovimientosDeCajaAjustes_Search", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@IdMovimientoDeCaja", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdMovimientoDeCaja" ].Value = IdMovimientoOrigen;
			
				cmd.Parameters.Add( new SqlParameter( "@IdMovimientoDeCajaAjuste", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdMovimientoDeCajaAjuste" ].Value = IdMovimientoAjuste;
						
				adapter.SelectCommand = cmd;

				adapter.Fill( data );
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
			}
			return data;
		}
	

		public static tfi_MovimientosDeCajaAjustesDataset.tfi_MovimientosDeCajaAjustesRow NewRow()
		{
			return ( new tfi_MovimientosDeCajaAjustesDataset() ).tfi_MovimientosDeCajaAjustes.Newtfi_MovimientosDeCajaAjustesRow();
		}
	
		public static tfi_MovimientosDeCajaAjustesDataset.tfi_MovimientosDeCajaAjustesRow GetByPk( string IdMovimientoDeCaja, string IdMovimientoDeCajaAjuste )
		{
			tfi_MovimientosDeCajaAjustesDataset data = new tfi_MovimientosDeCajaAjustesDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tfi_MovimientosDeCajaAjustes_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdMovimientoDeCaja", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdMovimientoDeCaja" ].Value = IdMovimientoDeCaja;
			
			cmd.Parameters.Add( new SqlParameter( "@IdMovimientoDeCajaAjuste", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdMovimientoDeCajaAjuste" ].Value = IdMovimientoDeCajaAjuste;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tfi_MovimientosDeCajaAjustes" );

			adapter.Fill( data );

			if ( data.tfi_MovimientosDeCajaAjustes.Rows.Count == 1 )
			{
				return ( tfi_MovimientosDeCajaAjustesDataset.tfi_MovimientosDeCajaAjustesRow )data.tfi_MovimientosDeCajaAjustes.Rows[ 0 ];
			}
			
			return null;
		}
		


		public static void Update(System.Data.DataTable dataTable, string  IdTransaction , SentenciasReplicacion replication)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			Update(dataTable, trx, replication);
		}


		public static void Update( tfi_MovimientosDeCajaAjustesDataset.tfi_MovimientosDeCajaAjustesRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tfi_MovimientosDeCajaAjustesDataset.tfi_MovimientosDeCajaAjustesDataTable )row.Table ).Addtfi_MovimientosDeCajaAjustesRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tfi_MovimientosDeCajaAjustesDataset dataSet )
		{
			Update( dataSet.tfi_MovimientosDeCajaAjustes );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tfi_MovimientosDeCajaAjustesDataset.tfi_MovimientosDeCajaAjustesDataTable )dataTable, trx );
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
			Update( ( tfi_MovimientosDeCajaAjustesDataset.tfi_MovimientosDeCajaAjustesDataTable )dataTable, trx );
		}
				

		public static void Update( System.Data.DataTable dataTable, SqlTransaction trx , SentenciasReplicacion replication)
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tfi_MovimientosDeCajaAjustes", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdMovimientoDeCaja", "IdMovimientoDeCaja" ),
																											 new System.Data.Common.DataColumnMapping( "IdMovimientoDeCajaAjuste", "IdMovimientoDeCajaAjuste" ),
																											 new System.Data.Common.DataColumnMapping( "aux1", "aux1" ),
																											 new System.Data.Common.DataColumnMapping( "aux2", "aux2" ),
																											 new System.Data.Common.DataColumnMapping( "aux3", "aux3" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tfi_MovimientosDeCajaAjustes_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdMovimientoDeCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdMovimientoDeCaja", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdMovimientoDeCajaAjuste", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdMovimientoDeCajaAjuste", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@aux1", SqlDbType.Char, 10, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "aux1", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@aux2", SqlDbType.Char, 10, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "aux2", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@aux3", SqlDbType.Char, 10, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "aux3", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdMovimientoDeCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdMovimientoDeCaja", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdMovimientoDeCajaAjuste", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdMovimientoDeCajaAjuste", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tfi_MovimientosDeCajaAjustes_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdMovimientoDeCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMovimientoDeCaja", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdMovimientoDeCajaAjuste", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMovimientoDeCajaAjuste", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tfi_MovimientosDeCajaAjustes_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMovimientoDeCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMovimientoDeCaja", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMovimientoDeCajaAjuste", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMovimientoDeCajaAjuste", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@aux1", SqlDbType.Char, 10, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "aux1", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@aux2", SqlDbType.Char, 10, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "aux2", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@aux3", SqlDbType.Char, 10, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "aux3", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );

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
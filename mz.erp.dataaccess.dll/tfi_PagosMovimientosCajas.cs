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

	public class tfi_PagosMovimientosCajas : IDisposable
	{
	
		#region Custom Members

		public static void Update(System.Data.DataTable dataTable, string  IdTransaction , SentenciasReplicacion replication)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			Update(dataTable, trx, replication);
		}

		
		#endregion
		
		public tfi_PagosMovimientosCajas()
		{
		}


		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_PagosMovimientosCajas" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tfi_PagosMovimientosCajas_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tfi_PagosMovimientosCajasDataset GetList(  )
		{
			tfi_PagosMovimientosCajasDataset data = new tfi_PagosMovimientosCajasDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_PagosMovimientosCajas" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_PagosMovimientosCajas_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tfi_PagosMovimientosCajasDataset GetList(string IdMovimiento, string IdValor)
		{
			return GetList(IdMovimiento, IdValor, null, null, null);
		}

		public static tfi_PagosMovimientosCajasDataset GetList(string IdMovimiento, string IdValor, string IdInstanciaCaja, string Numero, string IdTipoDeMovimiento)
		{
			tfi_PagosMovimientosCajasDataset data = new tfi_PagosMovimientosCajasDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_PagosMovimientosCajas" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_PagosMovimientosCajas_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

 		    cmd.Parameters.Add( new SqlParameter( "@IdTipoDeMovimiento", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTipoDeMovimiento" ].Value = IdTipoDeMovimiento ;

			cmd.Parameters.Add( new SqlParameter( "@Numero", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Numero" ].Value = Numero;

			cmd.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdInstanciaCaja" ].Value = IdInstanciaCaja ;

			cmd.Parameters.Add( new SqlParameter( "@IdMovimiento", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdMovimiento" ].Value = IdMovimiento;
			
			cmd.Parameters.Add( new SqlParameter( "@IdValor", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdValor" ].Value = IdValor;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasRow NewRow()
		{
			return ( new tfi_PagosMovimientosCajasDataset() ).tfi_PagosMovimientosCajas.Newtfi_PagosMovimientosCajasRow();
		}
	
		public static tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasRow GetByPk( string IdMovimiento, string IdValor )
		{
			tfi_PagosMovimientosCajasDataset data = new tfi_PagosMovimientosCajasDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tfi_PagosMovimientosCajas_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdMovimiento", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdMovimiento" ].Value = IdMovimiento;
			
			cmd.Parameters.Add( new SqlParameter( "@IdValor", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdValor" ].Value = IdValor;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tfi_PagosMovimientosCajas" );

			adapter.Fill( data );

			if ( data.tfi_PagosMovimientosCajas.Rows.Count == 1 )
			{
				return ( tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasRow )data.tfi_PagosMovimientosCajas.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasDataTable )row.Table ).Addtfi_PagosMovimientosCajasRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tfi_PagosMovimientosCajasDataset dataSet )
		{
			Update( dataSet.tfi_PagosMovimientosCajas );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );
			SentenciasReplicacion replication = null;
			try
			{
				Update( ( tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasDataTable )dataTable, trx, replication );
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



		public static void Update(System.Data.DataTable dataTable, SqlTransaction trx , SentenciasReplicacion replication)
		{
			
			SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.AddRange(
					new System.Data.Common.DataTableMapping[] {
																  new System.Data.Common.DataTableMapping( "Table", "tfi_PagosMovimientosCajas", 
																  new System.Data.Common.DataColumnMapping[] {
																												 new System.Data.Common.DataColumnMapping( "IdMovimiento", "IdMovimiento" ),
																												 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																												 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
																												 new System.Data.Common.DataColumnMapping( "IdInstanciaCaja", "IdInstanciaCaja" ),
																												 new System.Data.Common.DataColumnMapping( "IdTipoDeMovimiento", "IdTipoDeMovimiento" ),
																												 new System.Data.Common.DataColumnMapping( "Numero", "Numero" ),
																												 new System.Data.Common.DataColumnMapping( "IdValor", "IdValor" ),
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
			
				SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tfi_PagosMovimientosCajas_Update", trx.Connection );
				sqlCommandUpdate.Transaction = trx;
				sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdMovimiento", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdMovimiento", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdInstanciaCaja", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTipoDeMovimiento", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTipoDeMovimiento", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Numero", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Numero", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdValor", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdValor", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdMovimiento", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdMovimiento", DataRowVersion.Original, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdValor", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdValor", DataRowVersion.Original, null ) );
			
				SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tfi_PagosMovimientosCajas_Delete", trx.Connection );
				sqlCommandDelete.Transaction = trx;
				sqlCommandDelete.CommandType = CommandType.StoredProcedure;
				sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdMovimiento", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMovimiento", DataRowVersion.Original, null ) );
				sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdValor", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdValor", DataRowVersion.Original, null ) );
				sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
				SqlCommand sqlCommandInsert = new SqlCommand("Pr_tfi_PagosMovimientosCajas_Insert", trx.Connection );
				sqlCommandInsert.Transaction = trx;
				sqlCommandInsert.CommandType = CommandType.StoredProcedure;
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMovimiento", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMovimiento", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdInstanciaCaja", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTipoDeMovimiento", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoDeMovimiento", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@Numero", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Numero", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdValor", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdValor", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );

				#region Replicacion

				_replication = replication;
				adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);

				#endregion
				adapter.UpdateCommand = sqlCommandUpdate;
				adapter.DeleteCommand = sqlCommandDelete;
				adapter.InsertCommand = sqlCommandInsert;
				adapter.Update ( dataTable );
		}
		

		private static SentenciasReplicacion _replication;

		public static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
		{
			try
			{
		
				StatementSQLForReplicationFactory.GetSqlStatement(e.Command, _replication.Sentence);
				if(_replication.IdTipoDeSentencia == null || _replication.IdTipoDeSentencia.Equals(string.Empty))
					_replication.IdTipoDeSentencia = e.StatementType.ToString().ToUpper();
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}					
		}
		public void Dispose()
		{
		}

		
	}
}


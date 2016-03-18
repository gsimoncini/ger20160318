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

	public class tsh_ProductosListasDePreciosAplicadas : IDisposable
	{
	
		#region Custom Members
		private static SentenciasReplicacion _replication;

		public static tsh_ProductosListasDePreciosAplicadasDataset GetList(string IdProducto)
		{

			return GetList(IdProducto, "", long.MinValue, long.MinValue, long.MinValue);
		}

		#endregion
		
		public tsh_ProductosListasDePreciosAplicadas()
		{
		}

		public static tsh_ProductosListasDePreciosAplicadasDataset GetList()
		{
			tsh_ProductosListasDePreciosAplicadasDataset data = new tsh_ProductosListasDePreciosAplicadasDataset();

			return ( tsh_ProductosListasDePreciosAplicadasDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_ProductosListasDePreciosAplicadas" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsh_ProductosListasDePreciosAplicadas_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsh_ProductosListasDePreciosAplicadasDataset GetList( string IdProducto, string IdListaDePrecio, decimal Coeficiente, long IdEmpresa, long IdSucursal )
		{
			tsh_ProductosListasDePreciosAplicadasDataset data = new tsh_ProductosListasDePreciosAplicadasDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_ProductosListasDePreciosAplicadas" );

			SqlCommand cmd = new SqlCommand( "Pr_tsh_ProductosListasDePreciosAplicadas_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			if(IdProducto.Equals(string.Empty))
				cmd.Parameters[ "@IdProducto" ].Value = System.DBNull.Value;
			else
                cmd.Parameters[ "@IdProducto" ].Value = IdProducto;

			cmd.Parameters.Add( new SqlParameter( "@IdListaDePrecio", SqlDbType.VarChar ) );
			if(IdListaDePrecio.Equals(string.Empty))
				cmd.Parameters[ "@IdListaDePrecio" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdListaDePrecio" ].Value = IdListaDePrecio;
			
			cmd.Parameters.Add( new SqlParameter( "@Coeficiente", SqlDbType.Decimal ) );
			if(Coeficiente == long.MinValue)
				cmd.Parameters[ "@Coeficiente" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Coeficiente" ].Value = Coeficiente;

			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
			if ( IdEmpresa == long.MinValue )
			{
				cmd.Parameters[ "@IdEmpresa" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			if ( IdSucursal == long.MinValue )
			{
				cmd.Parameters[ "@IdSucursal" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;
			}
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsh_ProductosListasDePreciosAplicadasDataset.tsh_ProductosListasDePreciosAplicadasRow NewRow()
		{
			return ( new tsh_ProductosListasDePreciosAplicadasDataset() ).tsh_ProductosListasDePreciosAplicadas.Newtsh_ProductosListasDePreciosAplicadasRow();
		}
	
		public static tsh_ProductosListasDePreciosAplicadasDataset.tsh_ProductosListasDePreciosAplicadasRow GetByPk( string IdProducto, string IdListaDePrecio )
		{
			tsh_ProductosListasDePreciosAplicadasDataset data = new tsh_ProductosListasDePreciosAplicadasDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsh_ProductosListasDePreciosAplicadas_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			
			cmd.Parameters.Add( new SqlParameter( "@IdListaDePrecio", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdListaDePrecio" ].Value = IdListaDePrecio;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsh_ProductosListasDePreciosAplicadas" );

			adapter.Fill( data );

			if ( data.tsh_ProductosListasDePreciosAplicadas.Rows.Count == 1 )
			{
				return ( tsh_ProductosListasDePreciosAplicadasDataset.tsh_ProductosListasDePreciosAplicadasRow )data.tsh_ProductosListasDePreciosAplicadas.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tsh_ProductosListasDePreciosAplicadasDataset.tsh_ProductosListasDePreciosAplicadasRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsh_ProductosListasDePreciosAplicadasDataset.tsh_ProductosListasDePreciosAplicadasDataTable )row.Table ).Addtsh_ProductosListasDePreciosAplicadasRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tsh_ProductosListasDePreciosAplicadasDataset dataSet )
		{
			Update( dataSet.tsh_ProductosListasDePreciosAplicadas );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tsh_ProductosListasDePreciosAplicadasDataset.tsh_ProductosListasDePreciosAplicadasDataTable )dataTable, trx );
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

				
		public static void Update( tsh_ProductosListasDePreciosAplicadasDataset.tsh_ProductosListasDePreciosAplicadasDataTable dataTable, SqlTransaction trx)
		{
			SentenciasReplicacion replicacion = new SentenciasReplicacion();
			Update(dataTable, trx, replicacion );
		}

		public static void Update( DataTable dataTable, SqlTransaction trx, SentenciasReplicacion replicacion )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsh_ProductosListasDePreciosAplicadas", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdProducto", "IdProducto" ),
																											 new System.Data.Common.DataColumnMapping( "IdListaDePrecio", "IdListaDePrecio" ),
																											 new System.Data.Common.DataColumnMapping( "Coeficiente", "Coeficiente" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsh_ProductosListasDePreciosAplicadas_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdListaDePrecio", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdListaDePrecio", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Coeficiente", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Coeficiente", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProducto", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdListaDePrecio", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdListaDePrecio", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsh_ProductosListasDePreciosAplicadas_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdListaDePrecio", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdListaDePrecio", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsh_ProductosListasDePreciosAplicadas_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdListaDePrecio", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdListaDePrecio", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Coeficiente", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Coeficiente", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );

			#region Replicacion

			_replication = replicacion;
			adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);

			#endregion

			adapter.UpdateCommand = sqlCommandUpdate;
			adapter.DeleteCommand = sqlCommandDelete;
			adapter.InsertCommand = sqlCommandInsert;
			adapter.Update ( dataTable );
		}
		
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


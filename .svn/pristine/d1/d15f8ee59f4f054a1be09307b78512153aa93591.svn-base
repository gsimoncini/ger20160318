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

	public class tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios : IDisposable
	{
	
		#region Custom Members
		private static SentenciasReplicacion _replication;
		public static tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosRow GetCondicion(long IdConfiguracion, string Columna, string Condicion, string Valor, string ValorColumna)
		{
			tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset data = GetList(string.Empty, IdConfiguracion, long.MinValue, Columna, Condicion, Valor, ValorColumna, long.MinValue, long.MinValue);
			if ( data.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.Rows.Count > 0 )
			{
				return ( tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosRow )data.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.Rows[ 0 ];
			}
			
			return null;
		}

		public static tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosRow GetCondicion(string IdUsuario, long IdConfiguracion, string Columna, string Condicion, string Valor, string ValorColumna)
		{
			tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset data = GetList(IdUsuario, IdConfiguracion, long.MinValue, Columna, Condicion, Valor, ValorColumna, long.MinValue, long.MinValue);
			if ( data.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.Rows.Count == 1 )
			{
				return ( tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosRow )data.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.Rows[ 0 ];
			}
			
			return null;
		}

		#endregion
		
		public tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios()
		{
		}

		public static tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset GetList()
		{
			tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset data = new tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset();

			return ( tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset GetList( string IdUsuario, long IdConfiguracion, long IdCondicion, string Columna, string Condicion, string Valor, string ValorColumna, long IdEmpresa, long IdSucursal )
		{
			tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset data = new tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios" );

			SqlCommand cmd = new SqlCommand( "Pr_tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar ) );
			if(IdUsuario.Equals(string.Empty))
				cmd.Parameters[ "@IdUsuario" ].Value = System.DBNull.Value;
			else
                cmd.Parameters[ "@IdUsuario" ].Value = IdUsuario;

			cmd.Parameters.Add( new SqlParameter( "@IdConfiguracion", SqlDbType.BigInt ) );
			if(IdConfiguracion.Equals(long.MinValue))
				cmd.Parameters[ "@IdConfiguracion" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdConfiguracion" ].Value = IdConfiguracion;

			cmd.Parameters.Add( new SqlParameter( "@IdCondicion", SqlDbType.BigInt ) );
			if(IdCondicion.Equals(long.MinValue))
				cmd.Parameters[ "@IdCondicion" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdCondicion" ].Value = IdCondicion;

			cmd.Parameters.Add( new SqlParameter( "@Columna", SqlDbType.VarChar ) );
			if(Columna.Equals(string.Empty))
				cmd.Parameters[ "@Columna" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Columna" ].Value = Columna;

			cmd.Parameters.Add( new SqlParameter( "@Condicion", SqlDbType.VarChar ) );
			if(Condicion.Equals(string.Empty))
				cmd.Parameters[ "@Condicion" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Condicion" ].Value = Condicion;

			cmd.Parameters.Add( new SqlParameter( "@Valor", SqlDbType.VarChar ) );
			if(Valor.Equals(string.Empty))
				cmd.Parameters[ "@Valor" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Valor" ].Value = Valor;

			cmd.Parameters.Add( new SqlParameter( "@ValorColumna", SqlDbType.VarChar ) );
			if(ValorColumna.Equals(string.Empty))
				cmd.Parameters[ "@ValorColumna" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@ValorColumna" ].Value = ValorColumna;

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

		public static tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosRow NewRow()
		{
			return ( new tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset() ).tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.Newtui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosRow();
		}
	
		public static tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosRow GetByPk( string IdUsuario, long IdConfiguracion, long IdCondicion )
		{
			tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset data = new tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdUsuario" ].Value = IdUsuario;
			
			cmd.Parameters.Add( new SqlParameter( "@IdConfiguracion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdConfiguracion" ].Value = IdConfiguracion;
			
			cmd.Parameters.Add( new SqlParameter( "@IdCondicion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdCondicion" ].Value = IdCondicion;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios" );

			adapter.Fill( data );

			if ( data.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.Rows.Count == 1 )
			{
				return ( tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosRow )data.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataTable )row.Table ).Addtui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset dataSet )
		{
			Update( dataSet.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataTable )dataTable, trx );
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

		public static void Update( DataTable data, SqlTransaction trx )
		{
			SentenciasReplicacion replicacion = new SentenciasReplicacion();
			Update( data, trx, replicacion );
		}
				

		public static void Update( DataTable dataTable, SqlTransaction trx, SentenciasReplicacion replicacion )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdUsuario", "IdUsuario" ),
																											 new System.Data.Common.DataColumnMapping( "IdConfiguracion", "IdConfiguracion" ),
																											 new System.Data.Common.DataColumnMapping( "IdCondicion", "IdCondicion" ),
																											 new System.Data.Common.DataColumnMapping( "Columna", "Columna" ),
																											 new System.Data.Common.DataColumnMapping( "Condicion", "Condicion" ),
																											 new System.Data.Common.DataColumnMapping( "Valor", "Valor" ),
																											 new System.Data.Common.DataColumnMapping( "ValorColumna", "ValorColumna" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdUsuario", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConfiguracion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConfiguracion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCondicion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCondicion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Columna", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Columna", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Condicion", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Condicion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Valor", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Valor", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ValorColumna", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "ValorColumna", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdUsuario", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdUsuario", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdConfiguracion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdConfiguracion", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdCondicion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdCondicion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdUsuario", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdConfiguracion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConfiguracion", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdCondicion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCondicion", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdUsuario", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConfiguracion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConfiguracion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCondicion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCondicion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Columna", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Columna", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Condicion", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Condicion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Valor", SqlDbType.VarChar, 200, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Valor", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@ValorColumna", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "ValorColumna", DataRowVersion.Current, null ) );
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
		
		public void Dispose()
		{
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

		
	}
}


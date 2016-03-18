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

	public class tui_ConfiguracionGrillaEstilosCondicionalesUsuarios : IDisposable
	{
	
		#region Custom Members
		private static SentenciasReplicacion _replication;

		public static tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow GetByName( string Nombre)
		{
			tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset data = GetList(string.Empty, long.MinValue, Nombre,string.Empty, long.MinValue, long.MinValue );

			if ( data.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.Rows.Count > 0 )
			{
				return ( tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow )data.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.Rows[ 0 ];
			}
			
			return null;
		}


		public static tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow GetByName( string Nombre, string IdUsuario )
		{
			tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset data = GetList(IdUsuario, long.MinValue, Nombre,string.Empty, long.MinValue, long.MinValue );

			if ( data.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.Rows.Count == 1 )
			{
				return ( tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow )data.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.Rows[ 0 ];
			}
			
			return null;
		}

		public static tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow GetByIdConfiguracion( long IdConfiguracion)
		{
			tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset data = GetList(string.Empty, IdConfiguracion, string.Empty,string.Empty, long.MinValue, long.MinValue );

			if ( data.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.Rows.Count > 0 )
			{
				return ( tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow )data.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.Rows[ 0 ];
			}
			
			return null;
		}
		#endregion
		
		public tui_ConfiguracionGrillaEstilosCondicionalesUsuarios()
		{
		}

		public static tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset GetList()
		{
			tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset data = new tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset();

			return ( tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tui_ConfiguracionGrillaEstilosCondicionalesUsuarios" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tui_ConfiguracionGrillaEstilosCondicionalesUsuarios_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset GetList( string IdUsuario, long IdConfiguracion, string Nombre, string IdUsuarioCreador, long IdEmpresa, long IdSucursal )
		{
			tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset data = new tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tui_ConfiguracionGrillaEstilosCondicionalesUsuarios" );

			SqlCommand cmd = new SqlCommand( "Pr_tui_ConfiguracionGrillaEstilosCondicionalesUsuarios_Search", dbhelper.Connection.GetConnection() );
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

			cmd.Parameters.Add( new SqlParameter( "@Nombre", SqlDbType.VarChar ) );
			if(Nombre.Equals(string.Empty))
				cmd.Parameters[ "@Nombre" ].Value = System.DBNull.Value;
			else
                cmd.Parameters[ "@Nombre" ].Value = Nombre;

			cmd.Parameters.Add( new SqlParameter( "@IdUsuarioCreador", SqlDbType.VarChar ) );
			if(IdUsuarioCreador.Equals(string.Empty))
				cmd.Parameters[ "@IdUsuarioCreador" ].Value = System.DBNull.Value;
			else
                cmd.Parameters[ "@IdUsuarioCreador" ].Value = IdUsuarioCreador;

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

		public static tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow NewRow()
		{
			return ( new tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset() ).tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.Newtui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow();
		}
	
		public static tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow GetByPk( string IdUsuario, long IdConfiguracion )
		{
			tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset data = new tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tui_ConfiguracionGrillaEstilosCondicionalesUsuarios_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdUsuario" ].Value = IdUsuario;
			
			cmd.Parameters.Add( new SqlParameter( "@IdConfiguracion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdConfiguracion" ].Value = IdConfiguracion;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tui_ConfiguracionGrillaEstilosCondicionalesUsuarios" );

			adapter.Fill( data );

			if ( data.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.Rows.Count == 1 )
			{
				return ( tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow )data.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataTable )row.Table ).Addtui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset dataSet )
		{
			Update( dataSet.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataTable )dataTable, trx );
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
															  new System.Data.Common.DataTableMapping( "Table", "tui_ConfiguracionGrillaEstilosCondicionalesUsuarios", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdUsuario", "IdUsuario" ),
																											 new System.Data.Common.DataColumnMapping( "IdConfiguracion", "IdConfiguracion" ),
																											 new System.Data.Common.DataColumnMapping( "Nombre", "Nombre" ),
																											 new System.Data.Common.DataColumnMapping( "IdUsuarioCreador", "IdUsuarioCreador" ),
																											 new System.Data.Common.DataColumnMapping( "Activo", "Activo" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tui_ConfiguracionGrillaEstilosCondicionalesUsuarios_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdUsuario", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConfiguracion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConfiguracion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Nombre", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Nombre", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdUsuarioCreador", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdUsuarioCreador", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdUsuario", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdUsuario", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdConfiguracion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdConfiguracion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tui_ConfiguracionGrillaEstilosCondicionalesUsuarios_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdUsuario", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdConfiguracion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConfiguracion", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tui_ConfiguracionGrillaEstilosCondicionalesUsuarios_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdUsuario", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConfiguracion", SqlDbType.BigInt, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConfiguracion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Nombre", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Nombre", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdUsuarioCreador", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdUsuarioCreador", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
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


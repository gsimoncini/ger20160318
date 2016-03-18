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

	public class tui_ConfiguracionGrillaEstilosAplicablesPerfiles : IDisposable
	{
	
		#region Custom Members
		private static SentenciasReplicacion _replication;
		#endregion
		
		public tui_ConfiguracionGrillaEstilosAplicablesPerfiles()
		{
		}

		public static tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset GetList()
		{
			tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset data = new tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset();

			return ( tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tui_ConfiguracionGrillaEstilosAplicablesPerfiles" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tui_ConfiguracionGrillaEstilosAplicablesPerfiles_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset GetList( long IdProceso, long IdTarea, string Grilla, string Formulario, long IdPerfil, long IdConfiguracion, DateTime FechaCreacion, long IdEmpresa, long IdSucursal )
		{
			tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset data = new tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tui_ConfiguracionGrillaEstilosAplicablesPerfiles" );

			SqlCommand cmd = new SqlCommand( "Pr_tui_ConfiguracionGrillaEstilosAplicablesPerfiles_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdProceso", SqlDbType.BigInt ) );
			if ( IdProceso == long.MinValue )
			{
				cmd.Parameters[ "@IdProceso" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdProceso" ].Value = IdProceso;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt ) );
			if ( IdTarea == long.MinValue )
			{
				cmd.Parameters[ "@IdTarea" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdTarea" ].Value = IdTarea;
			}
			cmd.Parameters.Add( new SqlParameter( "@Grilla", SqlDbType.VarChar ) );
			if(Grilla.Equals(string.Empty))
				cmd.Parameters[ "@Grilla" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Grilla" ].Value = Grilla;

			cmd.Parameters.Add( new SqlParameter( "@Formulario", SqlDbType.VarChar ) );
			if(Formulario.Equals(string.Empty))
				cmd.Parameters[ "@Formulario" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Formulario" ].Value = Formulario;

			cmd.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt ) );
			if ( IdPerfil == long.MinValue )
			{
				cmd.Parameters[ "@IdPerfil" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdPerfil" ].Value = IdPerfil;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdConfiguracion", SqlDbType.BigInt ) );
			if ( IdConfiguracion == long.MinValue )
			{
				cmd.Parameters[ "@IdConfiguracion" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdConfiguracion" ].Value = IdConfiguracion;
			}
			cmd.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime ) );
			if(FechaCreacion == DateTime.MinValue)
				cmd.Parameters[ "@FechaCreacion" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaCreacion" ].Value = FechaCreacion;

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

		public static tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset.tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow NewRow()
		{
			return ( new tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset() ).tui_ConfiguracionGrillaEstilosAplicablesPerfiles.Newtui_ConfiguracionGrillaEstilosAplicablesPerfilesRow();
		}
	
		public static tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset.tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow GetByPk( long IdProceso, long IdTarea, string Grilla, long IdPerfil, long IdConfiguracion )
		{
			tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset data = new tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tui_ConfiguracionGrillaEstilosAplicablesPerfiles_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdProceso", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdProceso" ].Value = IdProceso;
			
			cmd.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdTarea" ].Value = IdTarea;
			
			cmd.Parameters.Add( new SqlParameter( "@Grilla", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Grilla" ].Value = Grilla;
			
			cmd.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdPerfil" ].Value = IdPerfil;
			
			cmd.Parameters.Add( new SqlParameter( "@IdConfiguracion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdConfiguracion" ].Value = IdConfiguracion;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tui_ConfiguracionGrillaEstilosAplicablesPerfiles" );

			adapter.Fill( data );

			if ( data.tui_ConfiguracionGrillaEstilosAplicablesPerfiles.Rows.Count == 1 )
			{
				return ( tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset.tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow )data.tui_ConfiguracionGrillaEstilosAplicablesPerfiles.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset.tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset.tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataTable )row.Table ).Addtui_ConfiguracionGrillaEstilosAplicablesPerfilesRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset dataSet )
		{
			Update( dataSet.tui_ConfiguracionGrillaEstilosAplicablesPerfiles );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset.tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataTable )dataTable, trx );
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
				

		public static void Update( DataTable dataTable, SqlTransaction trx, SentenciasReplicacion replicacion  )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tui_ConfiguracionGrillaEstilosAplicablesPerfiles", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdProceso", "IdProceso" ),
																											 new System.Data.Common.DataColumnMapping( "IdTarea", "IdTarea" ),
																											 new System.Data.Common.DataColumnMapping( "Grilla", "Grilla" ),
																											 new System.Data.Common.DataColumnMapping( "Formulario", "Formulario" ),
																											 new System.Data.Common.DataColumnMapping( "IdPerfil", "IdPerfil" ),
																											 new System.Data.Common.DataColumnMapping( "IdConfiguracion", "IdConfiguracion" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tui_ConfiguracionGrillaEstilosAplicablesPerfiles_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProceso", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProceso", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTarea", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Grilla", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Grilla", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Formulario", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Formulario", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdPerfil", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConfiguracion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConfiguracion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdProceso", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProceso", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTarea", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldGrilla", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Grilla", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdPerfil", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdPerfil", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdConfiguracion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdConfiguracion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tui_ConfiguracionGrillaEstilosAplicablesPerfiles_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdProceso", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProceso", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTarea", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@Grilla", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Grilla", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdPerfil", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdConfiguracion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConfiguracion", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tui_ConfiguracionGrillaEstilosAplicablesPerfiles_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProceso", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProceso", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTarea", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Grilla", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Grilla", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Formulario", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Formulario", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdPerfil", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConfiguracion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConfiguracion", DataRowVersion.Current, null ) );
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


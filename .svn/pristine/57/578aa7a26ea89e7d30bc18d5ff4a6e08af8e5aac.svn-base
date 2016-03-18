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

	public class tui_ConfiguracionGrillaEstilosCondicionales : IDisposable
	{
	
		#region Custom Members
		private static SentenciasReplicacion _replication;

		public static tui_ConfiguracionGrillaEstilosCondicionalesDataset.tui_ConfiguracionGrillaEstilosCondicionalesRow GetByName( string Nombre )
		{
			tui_ConfiguracionGrillaEstilosCondicionalesDataset data = GetList(long.MinValue, Nombre,string.Empty, DateTime.MinValue, long.MinValue, long.MinValue );

			if ( data.tui_ConfiguracionGrillaEstilosCondicionales.Rows.Count == 1 )
			{
				return ( tui_ConfiguracionGrillaEstilosCondicionalesDataset.tui_ConfiguracionGrillaEstilosCondicionalesRow )data.tui_ConfiguracionGrillaEstilosCondicionales.Rows[ 0 ];
			}
			
			return null;
		}
		
		#endregion
		
		public tui_ConfiguracionGrillaEstilosCondicionales()
		{
		}

		public static tui_ConfiguracionGrillaEstilosCondicionalesDataset GetList()
		{
			tui_ConfiguracionGrillaEstilosCondicionalesDataset data = new tui_ConfiguracionGrillaEstilosCondicionalesDataset();

			return ( tui_ConfiguracionGrillaEstilosCondicionalesDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tui_ConfiguracionGrillaEstilosCondicionales" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tui_ConfiguracionGrillaEstilosCondicionales_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tui_ConfiguracionGrillaEstilosCondicionalesDataset GetList( long IdConfiguracion, string Nombre, string IdUsuarioCreador, DateTime FechaCreacion, long IdEmpresa, long IdSucursal )
		{
			tui_ConfiguracionGrillaEstilosCondicionalesDataset data = new tui_ConfiguracionGrillaEstilosCondicionalesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tui_ConfiguracionGrillaEstilosCondicionales" );

			SqlCommand cmd = new SqlCommand( "Pr_tui_ConfiguracionGrillaEstilosCondicionales_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdConfiguracion", SqlDbType.BigInt ) );
			if(IdConfiguracion== long.MinValue)
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

			cmd.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime ) );
			if(FechaCreacion.Equals(DateTime.MinValue))
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

		public static tui_ConfiguracionGrillaEstilosCondicionalesDataset.tui_ConfiguracionGrillaEstilosCondicionalesRow NewRow()
		{
			return ( new tui_ConfiguracionGrillaEstilosCondicionalesDataset() ).tui_ConfiguracionGrillaEstilosCondicionales.Newtui_ConfiguracionGrillaEstilosCondicionalesRow();
		}
	
		public static tui_ConfiguracionGrillaEstilosCondicionalesDataset.tui_ConfiguracionGrillaEstilosCondicionalesRow GetByPk( long IdConfiguracion )
		{
			tui_ConfiguracionGrillaEstilosCondicionalesDataset data = new tui_ConfiguracionGrillaEstilosCondicionalesDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tui_ConfiguracionGrillaEstilosCondicionales_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdConfiguracion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdConfiguracion" ].Value = IdConfiguracion;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tui_ConfiguracionGrillaEstilosCondicionales" );

			adapter.Fill( data );

			if ( data.tui_ConfiguracionGrillaEstilosCondicionales.Rows.Count == 1 )
			{
				return ( tui_ConfiguracionGrillaEstilosCondicionalesDataset.tui_ConfiguracionGrillaEstilosCondicionalesRow )data.tui_ConfiguracionGrillaEstilosCondicionales.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tui_ConfiguracionGrillaEstilosCondicionalesDataset.tui_ConfiguracionGrillaEstilosCondicionalesRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tui_ConfiguracionGrillaEstilosCondicionalesDataset.tui_ConfiguracionGrillaEstilosCondicionalesDataTable )row.Table ).Addtui_ConfiguracionGrillaEstilosCondicionalesRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tui_ConfiguracionGrillaEstilosCondicionalesDataset dataSet )
		{
			Update( dataSet.tui_ConfiguracionGrillaEstilosCondicionales );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tui_ConfiguracionGrillaEstilosCondicionalesDataset.tui_ConfiguracionGrillaEstilosCondicionalesDataTable )dataTable, trx );
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
															  new System.Data.Common.DataTableMapping( "Table", "tui_ConfiguracionGrillaEstilosCondicionales", 
															  new System.Data.Common.DataColumnMapping[] {
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tui_ConfiguracionGrillaEstilosCondicionales_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConfiguracion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConfiguracion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Nombre", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Nombre", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdUsuarioCreador", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdUsuarioCreador", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdConfiguracion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdConfiguracion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tui_ConfiguracionGrillaEstilosCondicionales_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdConfiguracion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConfiguracion", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tui_ConfiguracionGrillaEstilosCondicionales_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
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


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

	public class tsh_ProvinciasLocalidades : IDisposable
	{
	
		#region Custom Members

		public static DataSet GetListByIdLocalidad( string IdLocalidad)
		{
			DataSet data = new DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_ProvinciasLocalidades" );

			SqlCommand cmd = new SqlCommand( "Pr_tsh_ProvinciasLocalidades_GetByIdLocalidad", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdLocalidad", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdLocalidad" ].Value = IdLocalidad;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}
		


		private static SentenciasReplicacion _replicacion;
		public static SentenciasReplicacion Replicacion
		{
			get{return _replicacion;}
			set{_replicacion = value;}
		}
		public static tsh_ProvinciasLocalidadesDataset GetList( long IdProvincia)
		{
			return GetList(IdProvincia, "", long.MinValue, long.MinValue);
		}

		public static tsh_LocalidadesDataset GetListLocalidades( long IdProvincia)
		{
			tsh_LocalidadesDataset data = new tsh_LocalidadesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_Localidades" );

			SqlCommand cmd = new SqlCommand( "Pr_tsh_ProvinciasLocalidades_SearchLocalidades", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdProvincia", SqlDbType.BigInt ) );
			if ( IdProvincia == long.MinValue )
			{
				cmd.Parameters[ "@IdProvincia" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdProvincia" ].Value = IdProvincia;
			}
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		#endregion
		
		public tsh_ProvinciasLocalidades()
		{
		}

		public static tsh_ProvinciasLocalidadesDataset GetList()
		{
			tsh_ProvinciasLocalidadesDataset data = new tsh_ProvinciasLocalidadesDataset();

			return ( tsh_ProvinciasLocalidadesDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_ProvinciasLocalidades" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsh_ProvinciasLocalidades_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsh_ProvinciasLocalidadesDataset GetList( long IdProvincia, string IdLocalidad, long IdEmpresa, long IdSucursal )
		{
			tsh_ProvinciasLocalidadesDataset data = new tsh_ProvinciasLocalidadesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_ProvinciasLocalidades" );

			SqlCommand cmd = new SqlCommand( "Pr_tsh_ProvinciasLocalidades_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdProvincia", SqlDbType.BigInt ) );
			if ( IdProvincia == long.MinValue )
			{
				cmd.Parameters[ "@IdProvincia" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdProvincia" ].Value = IdProvincia;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdLocalidad", SqlDbType.VarChar ) );
			if(IdLocalidad.Equals(string.Empty))
				cmd.Parameters[ "@IdLocalidad" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdLocalidad" ].Value = IdLocalidad;
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

		public static tsh_ProvinciasLocalidadesDataset.tsh_ProvinciasLocalidadesRow NewRow()
		{
			return ( new tsh_ProvinciasLocalidadesDataset() ).tsh_ProvinciasLocalidades.Newtsh_ProvinciasLocalidadesRow();
		}
	
		public static tsh_ProvinciasLocalidadesDataset.tsh_ProvinciasLocalidadesRow GetByPk( long IdProvincia, string IdLocalidad )
		{
			tsh_ProvinciasLocalidadesDataset data = new tsh_ProvinciasLocalidadesDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsh_ProvinciasLocalidades_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdProvincia", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdProvincia" ].Value = IdProvincia;
			
			cmd.Parameters.Add( new SqlParameter( "@IdLocalidad", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdLocalidad" ].Value = IdLocalidad;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsh_ProvinciasLocalidades" );

			adapter.Fill( data );

			if ( data.tsh_ProvinciasLocalidades.Rows.Count == 1 )
			{
				return ( tsh_ProvinciasLocalidadesDataset.tsh_ProvinciasLocalidadesRow )data.tsh_ProvinciasLocalidades.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tsh_ProvinciasLocalidadesDataset.tsh_ProvinciasLocalidadesRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsh_ProvinciasLocalidadesDataset.tsh_ProvinciasLocalidadesDataTable )row.Table ).Addtsh_ProvinciasLocalidadesRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tsh_ProvinciasLocalidadesDataset dataSet )
		{
			Update( dataSet.tsh_ProvinciasLocalidades );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tsh_ProvinciasLocalidadesDataset.tsh_ProvinciasLocalidadesDataTable )dataTable, trx );
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
		public static void Update( DataTable dataTable, SentenciasReplicacion replicacion )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Replicacion = replicacion;
				Update( ( tsh_ProvinciasLocalidadesDataset.tsh_ProvinciasLocalidadesDataTable )dataTable, trx );
				Replicacion.Update();
				//_replication = replication;
				mz.erp.dataaccess.sy_SentenciasReplicacion.Update(Replicacion.Data.sy_SentenciasReplicacion, trx);
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
			Update( ( tsh_ProvinciasLocalidadesDataset.tsh_ProvinciasLocalidadesDataTable )dataTable, trx );
		}
				
		public static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
		{
			
		
			StatementSQLForReplicationFactory.GetSqlStatement(e.Command, Replicacion.Sentence);
			if(Replicacion.IdTipoDeSentencia == null || Replicacion.IdTipoDeSentencia.Equals(string.Empty))
				Replicacion.IdTipoDeSentencia = e.StatementType.ToString().ToUpper();
			
			
			
		}
		public static void Update( tsh_ProvinciasLocalidadesDataset.tsh_ProvinciasLocalidadesDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsh_ProvinciasLocalidades", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdProvincia", "IdProvincia" ),
																											 new System.Data.Common.DataColumnMapping( "IdLocalidad", "IdLocalidad" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsh_ProvinciasLocalidades_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProvincia", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProvincia", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdLocalidad", SqlDbType.VarChar, 30, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdLocalidad", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdProvincia", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProvincia", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdLocalidad", SqlDbType.VarChar, 30, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdLocalidad", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsh_ProvinciasLocalidades_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdProvincia", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProvincia", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdLocalidad", SqlDbType.VarChar, 30, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdLocalidad", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsh_ProvinciasLocalidades_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProvincia", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProvincia", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdLocalidad", SqlDbType.VarChar, 30, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdLocalidad", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );

			adapter.UpdateCommand = sqlCommandUpdate;
			adapter.DeleteCommand = sqlCommandDelete;
			adapter.InsertCommand = sqlCommandInsert;

			adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);

			adapter.Update ( dataTable );
		}
		
		public void Dispose()
		{
		}

		
	}
}


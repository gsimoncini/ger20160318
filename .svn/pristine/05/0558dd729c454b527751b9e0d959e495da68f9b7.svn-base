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

	public class sy_Herramientas : IDisposable
	{
	
		#region Custom Members

		public static sy_HerramientasDataset GetList( long IdBarraHerramienta, long IdPerfil )
		{
			sy_HerramientasDataset data = new sy_HerramientasDataset();

			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_Herramientas" );
			
			SqlCommand cmd = new SqlCommand( "Pr_sy_Herramientas_GetList_By_BarraHerramienta_Peril", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdBarraHerramienta", SqlDbType.BigInt, 8 ) );
			cmd.Parameters[ "@IdBarraHerramienta" ].Value = IdBarraHerramienta;

			cmd.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt, 8 ) );
			cmd.Parameters[ "@IdPerfil" ].Value = IdPerfil;

			adapter.SelectCommand = cmd;

			try
			{
				adapter.Fill( data );
			}
			catch ( Exception ex )
			{
				System.Diagnostics.Debug.WriteLine( ex.ToString() );
			}
         
			return data;

		}

	

		public static DataSet GetListPadres( long IdBarraHerramienta)
		{
			DataSet data = new DataSet();

			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_Herramientas" );
			
			SqlCommand cmd = new SqlCommand( "Pr_sy_Herramientas_GetListPadres_By_BarraHerramienta", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdBarraHerramienta", SqlDbType.BigInt, 8 ) );
			cmd.Parameters[ "@IdBarraHerramienta" ].Value = IdBarraHerramienta;

			adapter.SelectCommand = cmd;

			try
			{
				adapter.Fill( data );
			}
			catch ( Exception ex )
			{
				System.Diagnostics.Debug.WriteLine( ex.ToString() );
			}
         
			return data;

		}

		public static DataSet GetListHijos( long IdBarraHerramienta, long IdHerramientaPadre)
		{
			DataSet data = new DataSet();

			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_Herramientas" );
			
			SqlCommand cmd = new SqlCommand( "Pr_sy_Herramientas_GetListHijos_By_BarraHerramienta", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdBarraHerramienta", SqlDbType.BigInt, 8 ) );
			cmd.Parameters[ "@IdBarraHerramienta" ].Value = IdBarraHerramienta;

			cmd.Parameters.Add( new SqlParameter( "@IdHerramientaPadre", SqlDbType.BigInt, 8 ) );
			cmd.Parameters[ "@IdHerramientaPadre" ].Value = IdHerramientaPadre;

			adapter.SelectCommand = cmd;

			try
			{
				adapter.Fill( data );
			}
			catch ( Exception ex )
			{
				System.Diagnostics.Debug.WriteLine( ex.ToString() );
			}
         
			return data;

		}

		public static DataRow GetHerramientaEx_By_IdHerramientaIdRecurso(long IdHerramienta, long IdRecurso)
		{
			DataSet data = new DataSet();

			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_Herramientas" );
			
			SqlCommand cmd = new SqlCommand( "Pr_sy_Herramientas_GetHerramientaEx_By_IdHerramientaIdRecurso", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdHerramienta", SqlDbType.BigInt, 8 ) );
			cmd.Parameters[ "@IdHerramienta" ].Value = IdHerramienta;

			cmd.Parameters.Add( new SqlParameter( "@IdRecurso", SqlDbType.BigInt, 8 ) );
			cmd.Parameters[ "@IdRecurso" ].Value = IdRecurso;

			adapter.SelectCommand = cmd;

			try
			{
				adapter.Fill( data );
				if ( data.Tables[0].Rows.Count == 1 )
				{
					return data.Tables[0].Rows[ 0 ];
				}
			
			}
			catch ( Exception ex )
			{
				System.Diagnostics.Debug.WriteLine( ex.ToString() );
			}
         
			return null;

		}

		public static DataRow GetImagen_By_IdHerramienta(long IdHerramienta)
		{
			DataSet data = new DataSet();

			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_Herramientas" );
			
			SqlCommand cmd = new SqlCommand( "Pr_sy_Herramientas_GetImagen_By_IdHerramienta", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdHerramienta", SqlDbType.BigInt, 8 ) );
			cmd.Parameters[ "@IdHerramienta" ].Value = IdHerramienta;

			adapter.SelectCommand = cmd;

			try
			{
				adapter.Fill( data );
				if ( data.Tables[0].Rows.Count == 1 )
				{
					return data.Tables[0].Rows[ 0 ];
				}
			
			}
			catch ( Exception ex )
			{
				System.Diagnostics.Debug.WriteLine( ex.ToString() );
			}
         
			return null;

		}

		public static void AddSeparator(string Id, long IdherramientaPadre)
		{
			DataSet data = new DataSet();

			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_Herramientas" );
			
			SqlCommand cmd = new SqlCommand( "Pr_sy_Herramientas_AddSeparator", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@Id", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Id" ].Value = Id;

			cmd.Parameters.Add( new SqlParameter( "@IdherramientaPadre", SqlDbType.BigInt, 8 ) );
			cmd.Parameters[ "@IdherramientaPadre" ].Value = IdherramientaPadre;

			adapter.SelectCommand = cmd;

			try
			{
				adapter.Fill( data );
			
			}
			catch ( Exception ex )
			{
				System.Diagnostics.Debug.WriteLine( ex.ToString() );
			}
         

		}

		public static bool IncluirHerramientasDe(string idTransaction, string PerfilesNuevos, string PerfilesACopiar)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(idTransaction);
			
			SqlCommand cmd = new SqlCommand( "Pr_sy_herramientas_IncluirHerramientasDe");
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Connection = trx.Connection;
			cmd.Transaction = trx;

			cmd.Parameters.Add( new SqlParameter( "@PerfilesPadres", SqlDbType.VarChar ) );
			cmd.Parameters[ "@PerfilesPadres" ].Value = PerfilesNuevos;
			cmd.Parameters.Add( new SqlParameter( "@PerfilesHijos", SqlDbType.VarChar ) );
			cmd.Parameters[ "@PerfilesHijos" ].Value = PerfilesACopiar;

			cmd.ExecuteNonQuery();
			return true;			
		}

		private static SentenciasReplicacion _replication;

		#endregion
		
		public sy_Herramientas()
		{
		}

		public static sy_HerramientasDataset GetList()
		{
			sy_HerramientasDataset data = new sy_HerramientasDataset();

			return ( sy_HerramientasDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_Herramientas" );
			
			SqlCommand cmd = new SqlCommand( "Pr_sy_Herramientas_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static sy_HerramientasDataset GetList( long IdHerramienta, long IdHerramientaPadre, string Id, string ShortCut, short orden, bool Habilitado)
		{
			sy_HerramientasDataset data = new sy_HerramientasDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_Herramientas" );

			SqlCommand cmd = new SqlCommand( "Pr_sy_Herramientas_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdHerramienta", SqlDbType.BigInt ) );
			if ( IdHerramienta == long.MinValue )
			{
				cmd.Parameters[ "@IdHerramienta" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdHerramienta" ].Value = IdHerramienta;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdHerramientaPadre", SqlDbType.BigInt ) );
			if ( IdHerramientaPadre == long.MinValue )
			{
				cmd.Parameters[ "@IdHerramientaPadre" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdHerramientaPadre" ].Value = IdHerramientaPadre;
			}

			cmd.Parameters.Add( new SqlParameter( "@Id", SqlDbType.VarChar ) );
			if ( Id.Equals(string.Empty))
				cmd.Parameters[ "@Id" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Id" ].Value = Id;

			cmd.Parameters.Add( new SqlParameter( "@ShortCut", SqlDbType.VarChar ) );
			if ( ShortCut.Equals(string.Empty))
				cmd.Parameters[ "@ShortCut" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@ShortCut" ].Value = ShortCut;

			cmd.Parameters.Add( new SqlParameter( "@orden", SqlDbType.SmallInt ) );
			if ( orden == short.MinValue)
			{
				cmd.Parameters[ "@orden" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@orden" ].Value = orden;
			}

			cmd.Parameters.Add( new SqlParameter( "@Habilitado", SqlDbType.Bit ) );
			cmd.Parameters[ "@Habilitado" ].Value = Habilitado;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static sy_HerramientasDataset.sy_HerramientasRow NewRow()
		{
			return ( new sy_HerramientasDataset() ).sy_Herramientas.Newsy_HerramientasRow();
		}
	
		public static sy_HerramientasDataset.sy_HerramientasRow GetByPk( long IdHerramienta )
		{
			sy_HerramientasDataset data = new sy_HerramientasDataset();

			SqlCommand cmd = new SqlCommand( "Pr_sy_Herramientas_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdHerramienta", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdHerramienta" ].Value = IdHerramienta;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "sy_Herramientas" );

			adapter.Fill( data );

			if ( data.sy_Herramientas.Rows.Count == 1 )
			{
				return ( sy_HerramientasDataset.sy_HerramientasRow )data.sy_Herramientas.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( sy_HerramientasDataset.sy_HerramientasRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( sy_HerramientasDataset.sy_HerramientasDataTable )row.Table ).Addsy_HerramientasRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( sy_HerramientasDataset dataSet )
		{
			Update( dataSet.sy_Herramientas );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( sy_HerramientasDataset.sy_HerramientasDataTable )dataTable, trx );
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


				

		public static void Update( System.Data.DataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "sy_Herramientas", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdHerramienta", "IdHerramienta" ),
																											 new System.Data.Common.DataColumnMapping( "IdHerramientaPadre", "IdHerramientaPadre" ),
																											 new System.Data.Common.DataColumnMapping( "Id", "Id" ),
																											 new System.Data.Common.DataColumnMapping( "orden", "orden" ),
																											 new System.Data.Common.DataColumnMapping( "Habilitado", "Habilitado" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexion", "IdConexion" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "Shortcut", "Shortcut" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_sy_Herramientas_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdHerramienta", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdHerramienta", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdHerramientaPadre", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdHerramientaPadre", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Id", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Id", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@orden", SqlDbType.SmallInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "orden", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Habilitado", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Habilitado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Shortcut", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Shortcut", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdHerramienta", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdHerramienta", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_sy_Herramientas_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdHerramienta", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdHerramienta", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_sy_Herramientas_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdHerramientaPadre", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdHerramientaPadre", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Id", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Id", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@orden", SqlDbType.SmallInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "orden", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Habilitado", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Habilitado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Shortcut", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Shortcut", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdHerramienta", SqlDbType.BigInt, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdHerramienta", DataRowVersion.Current, null ) );

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

		public static void Update( System.Data.DataTable dataTable, SqlTransaction trx , SentenciasReplicacion replicacion )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "sy_Herramientas", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdHerramienta", "IdHerramienta" ),
																											 new System.Data.Common.DataColumnMapping( "IdHerramientaPadre", "IdHerramientaPadre" ),
																											 new System.Data.Common.DataColumnMapping( "Id", "Id" ),
																											 new System.Data.Common.DataColumnMapping( "orden", "orden" ),
																											 new System.Data.Common.DataColumnMapping( "Habilitado", "Habilitado" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexion", "IdConexion" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "Shortcut", "Shortcut" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_sy_Herramientas_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdHerramienta", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdHerramienta", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdHerramientaPadre", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdHerramientaPadre", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Id", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Id", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@orden", SqlDbType.SmallInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "orden", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Habilitado", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Habilitado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Shortcut", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Shortcut", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdHerramienta", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdHerramienta", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_sy_Herramientas_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdHerramienta", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdHerramienta", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_sy_Herramientas_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdHerramientaPadre", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdHerramientaPadre", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Id", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Id", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@orden", SqlDbType.SmallInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "orden", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Habilitado", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Habilitado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Shortcut", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Shortcut", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdHerramienta", SqlDbType.BigInt, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdHerramienta", DataRowVersion.Current, null ) );

			#region Replicacion

			_replication = replicacion;
			adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);

			#endregion

			adapter.UpdateCommand = sqlCommandUpdate;
			adapter.DeleteCommand = sqlCommandDelete;
			adapter.InsertCommand = sqlCommandInsert;
			adapter.RowUpdating +=new SqlRowUpdatingEventHandler(adapter_RowUpdating);
			adapter.Update ( dataTable );
			
		}

		private static void adapter_RowUpdating(object sender, SqlRowUpdatingEventArgs e)
		{			
			foreach(SqlParameter param in e.Command.Parameters)
			{
				if (param.ParameterName == "@FechaUltimaCompra") 
				{
					if ( e.Row["FechaUltimaCompra"].Equals(DateTime.MinValue))
					{
						e.Command.Parameters[ "@FechaUltimaCompra" ].Value = System.DBNull.Value;
					}
				}
			}
		}

		public void Dispose()
		{
		}

		
	}
}


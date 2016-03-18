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

	public class tlg_Flete : IDisposable
	{
		private static SentenciasReplicacion _replication;


		#region Custom Members
		
		#endregion
		
		#region Contructores
		public tlg_Flete()
		{
		}
		#endregion

		/*public static tlg_FleteDataset GetList()
		{
			tlg_FleteDataset data = new tlg_FleteDataset();

			return ( tlg_FleteDataset )GetList( data );
		}*/

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tlg_Flete" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tlg_Flete_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tlg_FleteDataset GetList(  )
		{
			tlg_FleteDataset data = new tlg_FleteDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tlg_Flete" );

			SqlCommand cmd = new SqlCommand( "Pr_tlg_Flete_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tlg_FleteDataset.tlg_FleteRow NewRow()
		{
			return ( new tlg_FleteDataset() ).tlg_Flete.Newtlg_FleteRow();
		}
	
		public static tlg_FleteDataset.tlg_FleteRow GetByPk( string IdComprobanteCargoAdicional, string IdTransporte )
		{
			tlg_FleteDataset data = new tlg_FleteDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tlg_Flete_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdComprobanteCargoAdicional", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobanteCargoAdicional" ].Value = IdComprobanteCargoAdicional;
			
			cmd.Parameters.Add( new SqlParameter( "@IdTransporte", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTransporte" ].Value = IdTransporte;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tlg_Flete" );

			adapter.Fill( data );

			if ( data.tlg_Flete.Rows.Count == 1 )
			{
				return ( tlg_FleteDataset.tlg_FleteRow )data.tlg_Flete.Rows[ 0 ];
			}
			
			return null;
		}
		

		
		public static void Update( tlg_FleteDataset.tlg_FleteRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tlg_FleteDataset.tlg_FleteDataTable )row.Table ).Addtlg_FleteRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tlg_FleteDataset dataSet )
		{
			Update( dataSet.tlg_Flete );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tlg_FleteDataset.tlg_FleteDataTable )dataTable, trx );
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
			Update( ( tlg_FleteDataset.tlg_FleteDataTable )dataTable, trx );
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



		//public static void Update( tlg_FleteDataset.tlg_FleteDataTable dataTable, SqlTransaction trx )
		public static void Update( DataTable dataTable, SqlTransaction trx, SentenciasReplicacion replication)
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
					new System.Data.Common.DataTableMapping( "Table", "tlg_Flete", 
						new System.Data.Common.DataColumnMapping[] {
							new System.Data.Common.DataColumnMapping( "IdComprobanteCargoAdicional", "IdComprobanteCargoAdicional" ),
							new System.Data.Common.DataColumnMapping( "IdTransporte", "IdTransporte" ),
							new System.Data.Common.DataColumnMapping( "CampoAuxiliar1", "CampoAuxiliar1" ),
							new System.Data.Common.DataColumnMapping( "CampoAuxiliar2", "CampoAuxiliar2" ),
							new System.Data.Common.DataColumnMapping( "CampoAuxiliar3", "CampoAuxiliar3" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tlg_Flete_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdComprobanteCargoAdicional", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdComprobanteCargoAdicional", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTransporte", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTransporte", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar1", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CampoAuxiliar1", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar2", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CampoAuxiliar2", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar3", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CampoAuxiliar3", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdComprobanteCargoAdicional", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobanteCargoAdicional", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdTransporte", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTransporte", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tlg_Flete_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdComprobanteCargoAdicional", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobanteCargoAdicional", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdTransporte", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTransporte", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tlg_Flete_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdComprobanteCargoAdicional", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobanteCargoAdicional", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTransporte", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTransporte", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar1", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar1", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar2", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar2", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar3", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar3", DataRowVersion.Current, null ) );
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
		
		public void Dispose()
		{
		}

		
	}
}


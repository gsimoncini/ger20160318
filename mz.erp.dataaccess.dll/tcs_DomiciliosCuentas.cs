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

	public class tcs_DomiciliosCuentas : IDisposable
	{
	
		#region Custom Members
		private static SentenciasReplicacion _replication;
		public static string GetIdDomicilioDefault(string IdCuenta, long IdTipoDomicilio)
		{
			
			try
			{
				System.Data.DataSet data = new DataSet();
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				//adapter.TableMappings.Add( "Table", "tcs_DomiciliosCuentas" );

				SqlCommand cmd = new SqlCommand( "fn_getIdDomicilio", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@idTipoDomicilio", SqlDbType.BigInt ) );
				if (IdTipoDomicilio ==long.MinValue) 
				{cmd.Parameters[ "@idTipoDomicilio" ].Value = System.DBNull.Value;}
				else 
				{cmd.Parameters[ "@idTipoDomicilio" ].Value = IdTipoDomicilio;}	
			
				cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;

				SqlParameter sqlpar = new SqlParameter();
				sqlpar.SqlDbType = SqlDbType.VarChar;
				//sqlpar.Precision = 200;
				sqlpar.Direction = ParameterDirection.ReturnValue;
				//sqlpar.SourceColumn="returnvalue";
				cmd.Parameters.Add(sqlpar);
			
			
				adapter.SelectCommand = cmd;
				cmd.Connection.Open();
			

			
				//string aux = Convert.ToString(cmd.ExecuteScalar());
				cmd.ExecuteNonQuery();
				cmd.Connection.Close();
				//adapter.Fill( data );
				return (string)sqlpar.Value;
			}
			catch(Exception e)
			{
				return null;
			}
			//return (string)data.Tables[0].Rows[0][0];



		}

		//German 20100118 SP6 647
		public static DataSet GetListNuevo( string IdCuenta)
		{
			DataSet data = new DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tcs_DomiciliosCuentasEx" );

			SqlCommand cmd = new SqlCommand( "Pr_tcs_DomiciliosCuentas_SearchNuevo", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;
			
			adapter.SelectCommand = cmd;
			adapter.Fill( data );         
			return data;
		}
		//Fin German 20100118 SP6 647
		
		public static DataSet GetListEx( string IdCuenta)
		{
			DataSet data = new DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tcs_DomiciliosCuentasEx" );

			SqlCommand cmd = new SqlCommand( "Pr_tcs_DomiciliosCuentas_SearchEx", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;
			
			adapter.SelectCommand = cmd;
			adapter.Fill( data );         
			return data;
		}
	
		#endregion
		
		public tcs_DomiciliosCuentas()
		{
		}

		public static tcs_DomiciliosCuentasDataset GetList()
		{
			tcs_DomiciliosCuentasDataset data = new tcs_DomiciliosCuentasDataset();

			return ( tcs_DomiciliosCuentasDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tcs_DomiciliosCuentas" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tcs_DomiciliosCuentas_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tcs_DomiciliosCuentasDataset GetList( string idDomicilio, string IdCuenta)
		{
			tcs_DomiciliosCuentasDataset data = new tcs_DomiciliosCuentasDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tcs_DomiciliosCuentas" );

			SqlCommand cmd = new SqlCommand( "Pr_tcs_DomiciliosCuentas_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@idDomicilio", SqlDbType.VarChar ) );
			if (idDomicilio == String.Empty) 
			{cmd.Parameters[ "@idDomicilio" ].Value = System.DBNull.Value;}
			else 
			{cmd.Parameters[ "@idDomicilio" ].Value = idDomicilio;}	
			
			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tcs_DomiciliosCuentasDataset.tcs_DomiciliosCuentasRow NewRow()
		{
			return ( new tcs_DomiciliosCuentasDataset() ).tcs_DomiciliosCuentas.Newtcs_DomiciliosCuentasRow();
		}
	
		public static tcs_DomiciliosCuentasDataset.tcs_DomiciliosCuentasRow GetByPk( string idDomicilio, string IdCuenta )
		{
			tcs_DomiciliosCuentasDataset data = new tcs_DomiciliosCuentasDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tcs_DomiciliosCuentas_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@idDomicilio", SqlDbType.VarChar ) );
			cmd.Parameters[ "@idDomicilio" ].Value = idDomicilio;
			
			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tcs_DomiciliosCuentas" );

			adapter.Fill( data );

			if ( data.tcs_DomiciliosCuentas.Rows.Count == 1 )
			{
				return ( tcs_DomiciliosCuentasDataset.tcs_DomiciliosCuentasRow )data.tcs_DomiciliosCuentas.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tcs_DomiciliosCuentasDataset.tcs_DomiciliosCuentasRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tcs_DomiciliosCuentasDataset.tcs_DomiciliosCuentasDataTable )row.Table ).Addtcs_DomiciliosCuentasRow( row );
			}
			
			//Update( row.Table );
		}

		public static void Update( tcs_DomiciliosCuentasDataset dataSet )
		{
			//Update( dataSet.tcs_DomiciliosCuentas );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				//Update( ( tcs_DomiciliosCuentasDataset.tcs_DomiciliosCuentasDataTable )dataTable, trx );
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
			//Update( ( tcs_DomiciliosCuentasDataset.tcs_DomiciliosCuentasDataTable )dataTable, trx );
		}
			
	
		public static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
		{
			
		
			StatementSQLForReplicationFactory.GetSqlStatement(e.Command, _replication.Sentence);
			if(_replication.IdTipoDeSentencia == null || _replication.IdTipoDeSentencia.Equals(string.Empty))
				_replication.IdTipoDeSentencia = e.StatementType.ToString().ToUpper();
			
			
		}

		public static void Update( DataTable dataTable, SqlTransaction trx, SentenciasReplicacion replication )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tcs_DomiciliosCuentas", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "idDomicilio", "idDomicilio" ),
																											 new System.Data.Common.DataColumnMapping( "IdCuenta", "IdCuenta" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "RowIdGenerado", "RowIdGenerado" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tcs_DomiciliosCuentas_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@idDomicilio", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "idDomicilio", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCuenta", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldidDomicilio", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "idDomicilio", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdCuenta", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tcs_DomiciliosCuentas_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@idDomicilio", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "idDomicilio", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCuenta", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tcs_DomiciliosCuentas_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@idDomicilio", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "idDomicilio", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCuenta", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@RowIdGenerado", SqlDbType.UniqueIdentifier, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "RowIdGenerado", DataRowVersion.Current, null ) );

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



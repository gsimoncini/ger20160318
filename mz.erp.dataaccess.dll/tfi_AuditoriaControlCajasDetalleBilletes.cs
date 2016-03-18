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

	public class tfi_AuditoriaControlCajasDetalleBilletes : IDisposable
	{
	
		#region Custom Members
		private static SentenciasReplicacion _replication;
		#endregion
		
		public tfi_AuditoriaControlCajasDetalleBilletes()
		{
		}

		public static tfi_AuditoriaControlCajasDetalleBilletesDataset GetList()
		{
			tfi_AuditoriaControlCajasDetalleBilletesDataset data = new tfi_AuditoriaControlCajasDetalleBilletesDataset();

			return ( tfi_AuditoriaControlCajasDetalleBilletesDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_AuditoriaControlCajasDetalleBilletes" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tfi_AuditoriaControlCajasDetalleBilletes_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tfi_AuditoriaControlCajasDetalleBilletesDataset GetList( long IdAuditoria, long Ordinal, long IdTipoBillete, long CantidadInformada, decimal MontoInformado, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId )
		{
			tfi_AuditoriaControlCajasDetalleBilletesDataset data = new tfi_AuditoriaControlCajasDetalleBilletesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_AuditoriaControlCajasDetalleBilletes" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_AuditoriaControlCajasDetalleBilletes_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdAuditoria", SqlDbType.BigInt ) );
			if ( IdAuditoria == long.MinValue )
			{
				cmd.Parameters[ "@IdAuditoria" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdAuditoria" ].Value = IdAuditoria;
			}
			cmd.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt ) );
			if ( Ordinal == long.MinValue )
			{
				cmd.Parameters[ "@Ordinal" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@Ordinal" ].Value = Ordinal;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdTipoBillete", SqlDbType.BigInt ) );
			if ( IdTipoBillete == long.MinValue )
			{
				cmd.Parameters[ "@IdTipoBillete" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdTipoBillete" ].Value = IdTipoBillete;
			}
			cmd.Parameters.Add( new SqlParameter( "@CantidadInformada", SqlDbType.BigInt ) );
			if ( CantidadInformada == long.MinValue )
			{
				cmd.Parameters[ "@CantidadInformada" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@CantidadInformada" ].Value = CantidadInformada;
			}
			cmd.Parameters.Add( new SqlParameter( "@MontoInformado", SqlDbType.Decimal ) );
			cmd.Parameters[ "@MontoInformado" ].Value = MontoInformado;
			cmd.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime ) );
			cmd.Parameters[ "@FechaCreacion" ].Value = FechaCreacion;
			cmd.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt ) );
			if ( IdConexionCreacion == long.MinValue )
			{
				cmd.Parameters[ "@IdConexionCreacion" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdConexionCreacion" ].Value = IdConexionCreacion;
			}
			cmd.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp ) );
			cmd.Parameters[ "@UltimaModificacion" ].Value = UltimaModificacion;
			cmd.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt ) );
			if ( IdConexionUltimaModificacion == long.MinValue )
			{
				cmd.Parameters[ "@IdConexionUltimaModificacion" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdConexionUltimaModificacion" ].Value = IdConexionUltimaModificacion;
			}
			cmd.Parameters.Add( new SqlParameter( "@RowId", SqlDbType.UniqueIdentifier ) );
			cmd.Parameters[ "@RowId" ].Value = RowId;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tfi_AuditoriaControlCajasDetalleBilletesDataset.tfi_AuditoriaControlCajasDetalleBilletesRow NewRow()
		{
			return ( new tfi_AuditoriaControlCajasDetalleBilletesDataset() ).tfi_AuditoriaControlCajasDetalleBilletes.Newtfi_AuditoriaControlCajasDetalleBilletesRow();
		}
	
		public static tfi_AuditoriaControlCajasDetalleBilletesDataset.tfi_AuditoriaControlCajasDetalleBilletesRow GetByPk( long IdAuditoria, long Ordinal, long IdTipoBillete )
		{
			tfi_AuditoriaControlCajasDetalleBilletesDataset data = new tfi_AuditoriaControlCajasDetalleBilletesDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tfi_AuditoriaControlCajasDetalleBilletes_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdAuditoria", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdAuditoria" ].Value = IdAuditoria;
			
			cmd.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt ) );
			cmd.Parameters[ "@Ordinal" ].Value = Ordinal;
			
			cmd.Parameters.Add( new SqlParameter( "@IdTipoBillete", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdTipoBillete" ].Value = IdTipoBillete;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tfi_AuditoriaControlCajasDetalleBilletes" );

			adapter.Fill( data );

			if ( data.tfi_AuditoriaControlCajasDetalleBilletes.Rows.Count == 1 )
			{
				return ( tfi_AuditoriaControlCajasDetalleBilletesDataset.tfi_AuditoriaControlCajasDetalleBilletesRow )data.tfi_AuditoriaControlCajasDetalleBilletes.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tfi_AuditoriaControlCajasDetalleBilletesDataset.tfi_AuditoriaControlCajasDetalleBilletesRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tfi_AuditoriaControlCajasDetalleBilletesDataset.tfi_AuditoriaControlCajasDetalleBilletesDataTable )row.Table ).Addtfi_AuditoriaControlCajasDetalleBilletesRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tfi_AuditoriaControlCajasDetalleBilletesDataset dataSet )
		{
			Update( dataSet.tfi_AuditoriaControlCajasDetalleBilletes );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tfi_AuditoriaControlCajasDetalleBilletesDataset.tfi_AuditoriaControlCajasDetalleBilletesDataTable )dataTable, trx );
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
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tfi_AuditoriaControlCajasDetalleBilletes", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdAuditoria", "IdAuditoria" ),
																											 new System.Data.Common.DataColumnMapping( "Ordinal", "Ordinal" ),
																											 new System.Data.Common.DataColumnMapping( "IdTipoBillete", "IdTipoBillete" ),
																											 new System.Data.Common.DataColumnMapping( "CantidadInformada", "CantidadInformada" ),
																											 new System.Data.Common.DataColumnMapping( "MontoInformado", "MontoInformado" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tfi_AuditoriaControlCajasDetalleBilletes_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdAuditoria", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdAuditoria", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Ordinal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTipoBillete", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTipoBillete", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CantidadInformada", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CantidadInformada", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@MontoInformado", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "MontoInformado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdAuditoria", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdAuditoria", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldOrdinal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ordinal", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdTipoBillete", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTipoBillete", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tfi_AuditoriaControlCajasDetalleBilletes_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdAuditoria", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdAuditoria", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Ordinal", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdTipoBillete", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoBillete", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tfi_AuditoriaControlCajasDetalleBilletes_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdAuditoria", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdAuditoria", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Ordinal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTipoBillete", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoBillete", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CantidadInformada", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CantidadInformada", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@MontoInformado", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "MontoInformado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );

			adapter.UpdateCommand = sqlCommandUpdate;
			adapter.DeleteCommand = sqlCommandDelete;
			adapter.InsertCommand = sqlCommandInsert;
			adapter.Update ( dataTable );
		}
		

		
		public static void Update( DataTable dataTable, SqlTransaction trx, SentenciasReplicacion replicacion )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tfi_AuditoriaControlCajasDetalleBilletes", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdAuditoria", "IdAuditoria" ),
																											 new System.Data.Common.DataColumnMapping( "Ordinal", "Ordinal" ),
																											 new System.Data.Common.DataColumnMapping( "IdTipoBillete", "IdTipoBillete" ),
																											 new System.Data.Common.DataColumnMapping( "CantidadInformada", "CantidadInformada" ),
																											 new System.Data.Common.DataColumnMapping( "MontoInformado", "MontoInformado" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tfi_AuditoriaControlCajasDetalleBilletes_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdAuditoria", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdAuditoria", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Ordinal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTipoBillete", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTipoBillete", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CantidadInformada", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CantidadInformada", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@MontoInformado", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "MontoInformado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdAuditoria", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdAuditoria", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldOrdinal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ordinal", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdTipoBillete", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTipoBillete", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tfi_AuditoriaControlCajasDetalleBilletes_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdAuditoria", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdAuditoria", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Ordinal", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdTipoBillete", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoBillete", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tfi_AuditoriaControlCajasDetalleBilletes_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdAuditoria", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdAuditoria", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Ordinal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTipoBillete", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoBillete", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CantidadInformada", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CantidadInformada", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@MontoInformado", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "MontoInformado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );

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


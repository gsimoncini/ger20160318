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

	public class tsh_Autorizaciones : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsh_Autorizaciones()
		{
		}

		public static tsh_AutorizacionesDataset GetList()
		{
			tsh_AutorizacionesDataset data = new tsh_AutorizacionesDataset();

			return ( tsh_AutorizacionesDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_Autorizaciones" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsh_Autorizaciones_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static DataSet GetList( string IdAutorizacion, string IdResponsable, string Motivo, string IdResponsableDeAutorizacion, long IdEmpresa, long IdSucursal )
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_Autorizaciones" );

			SqlCommand cmd = new SqlCommand( "Pr_tsh_Autorizaciones_SearchPendientes", dbhelper.Connection.GetConnection() );

			cmd.Parameters.Add( new SqlParameter( "@IdAutorizacion", SqlDbType.VarChar ) );			
			cmd.Parameters[ "@IdAutorizacion" ].Value = IdAutorizacion;

			cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar ) );			
			cmd.Parameters[ "@IdResponsable" ].Value = IdResponsable;
		
			cmd.Parameters.Add( new SqlParameter( "@Motivo", SqlDbType.VarChar ) );			
			cmd.Parameters[ "@Motivo" ].Value = Motivo;

			/*cmd.Parameters.Add( new SqlParameter( "@Estado", SqlDbType.VarChar ) );			
			cmd.Parameters[ "@Estado" ].Value = Estado;*/

			cmd.Parameters.Add( new SqlParameter( "@IdResponsableDeAutorizacion", SqlDbType.VarChar ) );			
			cmd.Parameters[ "@IdResponsableDeAutorizacion" ].Value = IdResponsableDeAutorizacion;

			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.VarChar ) );			
			cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;

			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.VarChar ) );			
			cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;

			cmd.CommandType = CommandType.StoredProcedure;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;

		}	


		public static tsh_AutorizacionesDataset.tsh_AutorizacionesRow NewRow()
		{
			return ( new tsh_AutorizacionesDataset() ).tsh_Autorizaciones.Newtsh_AutorizacionesRow();
		}
	
		public static tsh_AutorizacionesDataset.tsh_AutorizacionesRow GetByPk( string IdAutorizacion )
		{
			tsh_AutorizacionesDataset data = new tsh_AutorizacionesDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsh_Autorizaciones_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdAutorizacion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdAutorizacion" ].Value = IdAutorizacion;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsh_Autorizaciones" );

			adapter.Fill( data );

			if ( data.tsh_Autorizaciones.Rows.Count == 1 )
			{
				return ( tsh_AutorizacionesDataset.tsh_AutorizacionesRow )data.tsh_Autorizaciones.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tsh_AutorizacionesDataset.tsh_AutorizacionesRow row, SentenciasReplicacion Replicacion, SqlTransaction trx)
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsh_AutorizacionesDataset.tsh_AutorizacionesDataTable )row.Table ).Addtsh_AutorizacionesRow( row );
			}
			
			Update( row.Table, trx, Replicacion);
		}

		public static void Update( tsh_AutorizacionesDataset.tsh_AutorizacionesRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsh_AutorizacionesDataset.tsh_AutorizacionesDataTable )row.Table ).Addtsh_AutorizacionesRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tsh_AutorizacionesDataset dataSet )
		{
			Update( dataSet.tsh_Autorizaciones );
		}

		public static void Update( DataTable dataTable)
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SentenciasReplicacion Replicacion = null;
			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tsh_AutorizacionesDataset.tsh_AutorizacionesDataTable )dataTable, trx, Replicacion);
				trx.Commit();
			}
			catch (Exception e)
			{
				trx.Rollback();
			}
			finally
			{
				cnx.Close();
			}
		}
		
		public static void Update( DataTable dataTable, SentenciasReplicacion Replicacion)
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tsh_AutorizacionesDataset.tsh_AutorizacionesDataTable )dataTable, trx, Replicacion);
				trx.Commit();
			}
			catch (Exception e)
			{
				trx.Rollback();
			}
			finally
			{
				cnx.Close();
			}
		}


		public static void Update( DataTable dataTable, SqlTransaction trx, SentenciasReplicacion Replicacion)
		{
			Update( ( tsh_AutorizacionesDataset.tsh_AutorizacionesDataTable )dataTable, trx, Replicacion);
		}
				

		public static void Update( tsh_AutorizacionesDataset.tsh_AutorizacionesDataTable dataTable, SqlTransaction trx, SentenciasReplicacion Replicacion)
		{
			SqlDataAdapter adapter = new SqlDataAdapter();						
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsh_Autorizaciones", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdAutorizacion", "IdAutorizacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdResponsable", "IdResponsable" ),
																											 new System.Data.Common.DataColumnMapping( "Motivo", "Motivo" ),
																											 new System.Data.Common.DataColumnMapping( "Datos", "Datos" ),
																											 new System.Data.Common.DataColumnMapping( "DatosBinarios", "DatosBinarios" ),
																											 new System.Data.Common.DataColumnMapping( "TipoDatosBinarios", "TipoDatosBinarios" ),
																											 new System.Data.Common.DataColumnMapping( "Estado", "Estado" ),
																											 new System.Data.Common.DataColumnMapping( "IdResponsableDeAutorizacion", "IdResponsableDeAutorizacion" ),
																											 new System.Data.Common.DataColumnMapping( "Observaciones", "Observaciones" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsh_Autorizaciones_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdAutorizacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdAutorizacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdResponsable", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Motivo", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Motivo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Datos", SqlDbType.VarChar, 7500, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Datos", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@DatosBinarios", SqlDbType.Binary, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "DatosBinarios", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@TipoDatosBinarios", SqlDbType.VarChar, 30, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "TipoDatosBinarios", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Estado", SqlDbType.VarChar, 3, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Estado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdResponsableDeAutorizacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdResponsableDeAutorizacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Observaciones", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Observaciones", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdAutorizacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdAutorizacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsh_Autorizaciones_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdAutorizacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdAutorizacion", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsh_Autorizaciones_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;			
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdAutorizacion", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdAutorizacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdResponsable", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Motivo", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Motivo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Datos", SqlDbType.VarChar, 7500, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Datos", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@DatosBinarios", SqlDbType.Binary, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "DatosBinarios", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@TipoDatosBinarios", SqlDbType.VarChar, 30, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "TipoDatosBinarios", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Estado", SqlDbType.VarChar, 3, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Estado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdResponsableDeAutorizacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdResponsableDeAutorizacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Observaciones", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Observaciones", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );			
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@RowId", SqlDbType.UniqueIdentifier, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "RowId", DataRowVersion.Current, null ) );


			#region Replicacion

			_replication = Replicacion;
			adapter.RowUpdated += new SqlRowUpdatedEventHandler(adapter_RowUpdated);

			#endregion


			adapter.UpdateCommand = sqlCommandUpdate;
			adapter.DeleteCommand = sqlCommandDelete;
			adapter.InsertCommand = sqlCommandInsert;

			adapter.Update ( dataTable );			
		}
		
		public void Dispose()
		{
		}
		
		private static SentenciasReplicacion _replication;

		private static void adapter_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
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


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

	public class tpu_Retenciones : IDisposable
	{
	
		#region Custom Members
		private static SentenciasReplicacion _replication;
	
		#endregion
		
		public tpu_Retenciones()
		{
		}

		public static tpu_RetencionesDataset GetList()
		{
			tpu_RetencionesDataset data = new tpu_RetencionesDataset();

			return ( tpu_RetencionesDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_Retenciones" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tpu_Retenciones_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static DataSet GetList( long IdRetencion, string IdTipoDeRetencion, decimal MontoNeto, decimal MontoRetencion, string NumeroRetencion, DateTime FechaRetencion, string NumeroRecibo )
		{
			DataSet data = new DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_Retenciones" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_Retenciones_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdRetencion", SqlDbType.BigInt ) );
			if ( IdRetencion == long.MinValue )
			{
				cmd.Parameters[ "@IdRetencion" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdRetencion" ].Value = IdRetencion;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdTipoDeRetencion", SqlDbType.VarChar ) );
			if(IdTipoDeRetencion.Equals(string.Empty))
				cmd.Parameters[ "@IdTipoDeRetencion" ].Value = System.DBNull.Value;
			else
                cmd.Parameters[ "@IdTipoDeRetencion" ].Value = IdTipoDeRetencion;

			cmd.Parameters.Add( new SqlParameter( "@MontoNeto", SqlDbType.Decimal ) );
			if(MontoNeto.Equals(decimal.MinValue))
				cmd.Parameters[ "@MontoNeto" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@MontoNeto" ].Value = MontoNeto;

			cmd.Parameters.Add( new SqlParameter( "@MontoRetencion", SqlDbType.Decimal ) );
			if(MontoRetencion.Equals(decimal.MinValue))
				cmd.Parameters[ "@MontoRetencion" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@MontoRetencion" ].Value = MontoRetencion;

			cmd.Parameters.Add( new SqlParameter( "@NumeroRetencion", SqlDbType.VarChar ) );
			if(NumeroRetencion.Equals(string.Empty))
				cmd.Parameters[ "@NumeroRetencion" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@NumeroRetencion" ].Value = NumeroRetencion;

			cmd.Parameters.Add( new SqlParameter( "@FechaRetencion", SqlDbType.DateTime ) );
			if(FechaRetencion.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaRetencion" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaRetencion" ].Value = FechaRetencion;

			cmd.Parameters.Add( new SqlParameter( "@NumeroRecibo", SqlDbType.VarChar ) );
			if(NumeroRecibo.Equals(string.Empty))
				cmd.Parameters[ "@NumeroRecibo" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@NumeroRecibo" ].Value = NumeroRecibo;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_RetencionesDataset.tpu_RetencionesRow NewRow()
		{
			return ( new tpu_RetencionesDataset() ).tpu_Retenciones.Newtpu_RetencionesRow();
		}
	
		public static tpu_RetencionesDataset.tpu_RetencionesRow GetByPk( long IdRetencion )
		{
			tpu_RetencionesDataset data = new tpu_RetencionesDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tpu_Retenciones_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdRetencion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdRetencion" ].Value = IdRetencion;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tpu_Retenciones" );

			adapter.Fill( data );

			if ( data.tpu_Retenciones.Rows.Count == 1 )
			{
				return ( tpu_RetencionesDataset.tpu_RetencionesRow )data.tpu_Retenciones.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tpu_RetencionesDataset.tpu_RetencionesRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tpu_RetencionesDataset.tpu_RetencionesDataTable )row.Table ).Addtpu_RetencionesRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tpu_RetencionesDataset dataSet )
		{
			Update( dataSet.tpu_Retenciones );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tpu_RetencionesDataset.tpu_RetencionesDataTable )dataTable, trx );
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
			Update( ( tpu_RetencionesDataset.tpu_RetencionesDataTable )dataTable, trx );
		}
				
		public static void Update( tpu_RetencionesDataset.tpu_RetencionesDataTable data, SqlTransaction trx )
		{
			SentenciasReplicacion replicacion = new SentenciasReplicacion();
			Update( data, trx, replicacion );
		}


		public static void Update( DataTable dataTable, SqlTransaction trx, SentenciasReplicacion replicacion)
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tpu_Retenciones", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdRetencion", "IdRetencion" ),
																											 new System.Data.Common.DataColumnMapping( "IdTipoDeRetencion", "IdTipoDeRetencion" ),
																											 new System.Data.Common.DataColumnMapping( "MontoNeto", "MontoNeto" ),
																											 new System.Data.Common.DataColumnMapping( "MontoRetencion", "MontoRetencion" ),
																											 new System.Data.Common.DataColumnMapping( "NumeroRetencion", "NumeroRetencion" ),
																											 new System.Data.Common.DataColumnMapping( "FechaRetencion", "FechaRetencion" ),
																											 new System.Data.Common.DataColumnMapping( "NumeroRecibo", "NumeroRecibo" ),
																											 new System.Data.Common.DataColumnMapping( "IdComprobante", "IdComprobante" ),
																											 new System.Data.Common.DataColumnMapping( "IdProveedor", "IdProveedor" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tpu_Retenciones_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdRetencion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdRetencion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTipoDeRetencion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTipoDeRetencion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@MontoNeto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "MontoNeto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@MontoRetencion", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "MontoRetencion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@NumeroRetencion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "NumeroRetencion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaRetencion", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaRetencion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@NumeroRecibo", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "NumeroRecibo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdComprobante", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProveedor", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdRetencion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdRetencion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tpu_Retenciones_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdRetencion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdRetencion", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tpu_Retenciones_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTipoDeRetencion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoDeRetencion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@MontoNeto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "MontoNeto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@MontoRetencion", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "MontoRetencion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@NumeroRetencion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "NumeroRetencion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaRetencion", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaRetencion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@NumeroRecibo", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "NumeroRecibo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobante", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProveedor", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdRetencion", SqlDbType.BigInt, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdRetencion", DataRowVersion.Current, null ) );
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



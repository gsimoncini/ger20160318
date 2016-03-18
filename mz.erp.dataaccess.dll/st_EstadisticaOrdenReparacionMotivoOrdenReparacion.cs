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

	public class st_EstadisticaOrdenReparacionMotivoOrdenReparacion : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public st_EstadisticaOrdenReparacionMotivoOrdenReparacion()
		{
		}

		public static st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset GetList()
		{
			st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset data = new st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset();

			return ( st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "st_EstadisticaOrdenReparacionMotivoOrdenReparacion" );
			
			SqlCommand cmd = new SqlCommand( "Pr_st_EstadisticaOrdenReparacionMotivoOrdenReparacion_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset GetList( long IdOrdenReparacion, long IdMotivo, bool EsVerdadero, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId )
		{
			st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset data = new st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "st_EstadisticaOrdenReparacionMotivoOrdenReparacion" );

			SqlCommand cmd = new SqlCommand( "Pr_st_EstadisticaOrdenReparacionMotivoOrdenReparacion_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt ) );
			if ( IdOrdenReparacion == long.MinValue )
			{
				cmd.Parameters[ "@IdOrdenReparacion" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdOrdenReparacion" ].Value = IdOrdenReparacion;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdMotivo", SqlDbType.BigInt ) );
			if ( IdMotivo == long.MinValue )
			{
				cmd.Parameters[ "@IdMotivo" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdMotivo" ].Value = IdMotivo;
			}
			cmd.Parameters.Add( new SqlParameter( "@EsVerdadero", SqlDbType.Bit ) );
			cmd.Parameters[ "@EsVerdadero" ].Value = EsVerdadero;
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

		public static st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionRow NewRow()
		{
			return ( new st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset() ).st_EstadisticaOrdenReparacionMotivoOrdenReparacion.Newst_EstadisticaOrdenReparacionMotivoOrdenReparacionRow();
		}
	
		public static st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionRow GetByPk( long IdOrdenReparacion, long IdMotivo )
		{
			st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset data = new st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset();

			SqlCommand cmd = new SqlCommand( "Pr_st_EstadisticaOrdenReparacionMotivoOrdenReparacion_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdOrdenReparacion" ].Value = IdOrdenReparacion;
			
			cmd.Parameters.Add( new SqlParameter( "@IdMotivo", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdMotivo" ].Value = IdMotivo;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "st_EstadisticaOrdenReparacionMotivoOrdenReparacion" );

			adapter.Fill( data );

			if ( data.st_EstadisticaOrdenReparacionMotivoOrdenReparacion.Rows.Count == 1 )
			{
				return ( st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionRow )data.st_EstadisticaOrdenReparacionMotivoOrdenReparacion.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataTable )row.Table ).Addst_EstadisticaOrdenReparacionMotivoOrdenReparacionRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset dataSet )
		{
			Update( dataSet.st_EstadisticaOrdenReparacionMotivoOrdenReparacion );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataTable )dataTable, trx );
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
			Update( ( st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataTable )dataTable, trx );
		}
				

		public static void Update( st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "st_EstadisticaOrdenReparacionMotivoOrdenReparacion", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdOrdenReparacion", "IdOrdenReparacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdMotivo", "IdMotivo" ),
																											 new System.Data.Common.DataColumnMapping( "EsVerdadero", "EsVerdadero" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_st_EstadisticaOrdenReparacionMotivoOrdenReparacion_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdOrdenReparacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdMotivo", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdMotivo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@EsVerdadero", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "EsVerdadero", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdOrdenReparacion", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdMotivo", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdMotivo", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_st_EstadisticaOrdenReparacionMotivoOrdenReparacion_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdOrdenReparacion", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdMotivo", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMotivo", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_st_EstadisticaOrdenReparacionMotivoOrdenReparacion_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdOrdenReparacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMotivo", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMotivo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@EsVerdadero", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "EsVerdadero", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );

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


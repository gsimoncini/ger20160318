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

	public class st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet()
		{
		}

		public static st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset GetList()
		{
			st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset data = new st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset();

			return ( st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet" );
			
			SqlCommand cmd = new SqlCommand( "Pr_st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset GetList( long IdOrdenReparacion, long IdInstanciaOrdenReparacion, long IdTarea, long IdMotivo, bool EsVerdadero )
		{
			st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset data = new st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet" );

			SqlCommand cmd = new SqlCommand( "Pr_st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet_Search", dbhelper.Connection.GetConnection() );
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
			cmd.Parameters.Add( new SqlParameter( "@IdInstanciaOrdenReparacion", SqlDbType.BigInt ) );
			if ( IdInstanciaOrdenReparacion == long.MinValue )
			{
				cmd.Parameters[ "@IdInstanciaOrdenReparacion" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdInstanciaOrdenReparacion" ].Value = IdInstanciaOrdenReparacion;
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
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow NewRow()
		{
			return ( new st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset() ).st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet.Newst_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow();
		}
	
		public static st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow GetByPk( long IdOrdenReparacion, long IdInstanciaOrdenReparacion, long IdTarea, long IdMotivo )
		{
			st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset data = new st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset();

			SqlCommand cmd = new SqlCommand( "Pr_st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdOrdenReparacion" ].Value = IdOrdenReparacion;
			
			cmd.Parameters.Add( new SqlParameter( "@IdInstanciaOrdenReparacion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdInstanciaOrdenReparacion" ].Value = IdInstanciaOrdenReparacion;
			
			cmd.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdTarea" ].Value = IdTarea;
			
			cmd.Parameters.Add( new SqlParameter( "@IdMotivo", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdMotivo" ].Value = IdMotivo;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet" );

			adapter.Fill( data );

			if ( data.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet.Rows.Count == 1 )
			{
				return ( st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow )data.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataTable )row.Table ).Addst_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset dataSet )
		{
			Update( dataSet.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataTable )dataTable, trx );
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
			Update( ( st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataTable )dataTable, trx );
		}
				

		public static void Update( st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdOrdenReparacion", "IdOrdenReparacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdInstanciaOrdenReparacion", "IdInstanciaOrdenReparacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdTarea", "IdTarea" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdOrdenReparacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdInstanciaOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdInstanciaOrdenReparacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTarea", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdMotivo", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdMotivo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@EsVerdadero", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "EsVerdadero", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdOrdenReparacion", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdInstanciaOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdInstanciaOrdenReparacion", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTarea", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdMotivo", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdMotivo", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdOrdenReparacion", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdInstanciaOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdInstanciaOrdenReparacion", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTarea", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdMotivo", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMotivo", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdOrdenReparacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdInstanciaOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdInstanciaOrdenReparacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTarea", DataRowVersion.Current, null ) );
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


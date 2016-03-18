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

	public class st_EstadisticaOrdenReparacionModificacionTecnico : IDisposable
	{
	
		#region Custom Members
		
		public static long GetIdTecnicoByIdPersona( string IdPersona )
		{
			DataSet data = new DataSet();

			SqlCommand cmd = new SqlCommand( "Pr_st_EstadisticaOrdenReparacionModificacionTecnico_GetIdTecnicoByIdPersona", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdPersona", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdPersona" ].Value = IdPersona;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "st_Tecnico" );

			adapter.Fill( data );

			if ( data.Tables[0].Rows.Count == 1 )
			{
				return Convert.ToInt64((data.Tables[0].Rows[ 0 ])["IdTecnico"]);
			}
			
			return long.MinValue;
		}
		#endregion
		
		public st_EstadisticaOrdenReparacionModificacionTecnico()
		{
		}

		public static st_EstadisticaOrdenReparacionModificacionTecnicoDataset GetList()
		{
			st_EstadisticaOrdenReparacionModificacionTecnicoDataset data = new st_EstadisticaOrdenReparacionModificacionTecnicoDataset();

			return ( st_EstadisticaOrdenReparacionModificacionTecnicoDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "st_EstadisticaOrdenReparacionModificacionTecnico" );
			
			SqlCommand cmd = new SqlCommand( "Pr_st_EstadisticaOrdenReparacionModificacionTecnico_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static st_EstadisticaOrdenReparacionModificacionTecnicoDataset GetList( long IdOrdenReparacion, long IdTecnico )
		{
			st_EstadisticaOrdenReparacionModificacionTecnicoDataset data = new st_EstadisticaOrdenReparacionModificacionTecnicoDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "st_EstadisticaOrdenReparacionModificacionTecnico" );

			SqlCommand cmd = new SqlCommand( "Pr_st_EstadisticaOrdenReparacionModificacionTecnico_Search", dbhelper.Connection.GetConnection() );
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
			cmd.Parameters.Add( new SqlParameter( "@IdTecnico", SqlDbType.BigInt ) );
			if ( IdTecnico == long.MinValue )
			{
				cmd.Parameters[ "@IdTecnico" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdTecnico" ].Value = IdTecnico;
			}
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static st_EstadisticaOrdenReparacionModificacionTecnicoDataset.st_EstadisticaOrdenReparacionModificacionTecnicoRow NewRow()
		{
			return ( new st_EstadisticaOrdenReparacionModificacionTecnicoDataset() ).st_EstadisticaOrdenReparacionModificacionTecnico.Newst_EstadisticaOrdenReparacionModificacionTecnicoRow();
		}
	
		public static st_EstadisticaOrdenReparacionModificacionTecnicoDataset.st_EstadisticaOrdenReparacionModificacionTecnicoRow GetByPk( long IdOrdenReparacion, long IdTecnico )
		{
			st_EstadisticaOrdenReparacionModificacionTecnicoDataset data = new st_EstadisticaOrdenReparacionModificacionTecnicoDataset();

			SqlCommand cmd = new SqlCommand( "Pr_st_EstadisticaOrdenReparacionModificacionTecnico_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdOrdenReparacion" ].Value = IdOrdenReparacion;
			
			cmd.Parameters.Add( new SqlParameter( "@IdTecnico", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdTecnico" ].Value = IdTecnico;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "st_EstadisticaOrdenReparacionModificacionTecnico" );

			adapter.Fill( data );

			if ( data.st_EstadisticaOrdenReparacionModificacionTecnico.Rows.Count == 1 )
			{
				return ( st_EstadisticaOrdenReparacionModificacionTecnicoDataset.st_EstadisticaOrdenReparacionModificacionTecnicoRow )data.st_EstadisticaOrdenReparacionModificacionTecnico.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( st_EstadisticaOrdenReparacionModificacionTecnicoDataset.st_EstadisticaOrdenReparacionModificacionTecnicoRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( st_EstadisticaOrdenReparacionModificacionTecnicoDataset.st_EstadisticaOrdenReparacionModificacionTecnicoDataTable )row.Table ).Addst_EstadisticaOrdenReparacionModificacionTecnicoRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( st_EstadisticaOrdenReparacionModificacionTecnicoDataset dataSet )
		{
			Update( dataSet.st_EstadisticaOrdenReparacionModificacionTecnico );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( st_EstadisticaOrdenReparacionModificacionTecnicoDataset.st_EstadisticaOrdenReparacionModificacionTecnicoDataTable )dataTable, trx );
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
			Update( ( st_EstadisticaOrdenReparacionModificacionTecnicoDataset.st_EstadisticaOrdenReparacionModificacionTecnicoDataTable )dataTable, trx );
		}
				

		public static void Update( st_EstadisticaOrdenReparacionModificacionTecnicoDataset.st_EstadisticaOrdenReparacionModificacionTecnicoDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "st_EstadisticaOrdenReparacionModificacionTecnico", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdOrdenReparacion", "IdOrdenReparacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdTecnico", "IdTecnico" ),
																											 new System.Data.Common.DataColumnMapping( "FechaUltimaModificacion", "FechaUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_st_EstadisticaOrdenReparacionModificacionTecnico_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdOrdenReparacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTecnico", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTecnico", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaUltimaModificacion", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdOrdenReparacion", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdTecnico", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTecnico", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_st_EstadisticaOrdenReparacionModificacionTecnico_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdOrdenReparacion", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdTecnico", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTecnico", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_st_EstadisticaOrdenReparacionModificacionTecnico_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdOrdenReparacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTecnico", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTecnico", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaUltimaModificacion", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaUltimaModificacion", DataRowVersion.Current, null ) );
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


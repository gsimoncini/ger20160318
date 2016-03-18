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

	public class twf_ProcesosTareasValidaciones : IDisposable
	{
	
		#region Custom Members

		public static DataSet GetValidacionesForStartProcess(long IdProceso,long IdTarea, long IdPerfil)
		{
			twf_ProcesosTareasValidacionesDataset data = new twf_ProcesosTareasValidacionesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "twf_ProcesosTareasValidaciones" );

			SqlCommand cmd = new SqlCommand( "Pr_twf_ProcesosTareasValidaciones_GetValidacionesForStartProcess", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@IdProceso", SqlDbType.BigInt ) );
			if ( IdProceso == long.MinValue )
			{
				cmd.Parameters[ "@IdProceso" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdProceso" ].Value = IdProceso;
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
			cmd.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt ) );
			if ( IdPerfil == long.MinValue )
			{
				cmd.Parameters[ "@IdPerfil" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdPerfil" ].Value = IdPerfil;
			}
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			return data;
		
		}
		
		#endregion
		
		public twf_ProcesosTareasValidaciones()
		{
		}

		public static twf_ProcesosTareasValidacionesDataset GetList()
		{
			twf_ProcesosTareasValidacionesDataset data = new twf_ProcesosTareasValidacionesDataset();

			return ( twf_ProcesosTareasValidacionesDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "twf_ProcesosTareasValidaciones" );
			
			SqlCommand cmd = new SqlCommand( "Pr_twf_ProcesosTareasValidaciones_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static twf_ProcesosTareasValidacionesDataset GetList( string IdProcesoTareaValidacion, string IdValidacion, long IdProceso, long IdTarea, long IdPerfil )
		{
			twf_ProcesosTareasValidacionesDataset data = new twf_ProcesosTareasValidacionesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "twf_ProcesosTareasValidaciones" );

			SqlCommand cmd = new SqlCommand( "Pr_twf_ProcesosTareasValidaciones_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdProcesoTareaValidacion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProcesoTareaValidacion" ].Value = IdProcesoTareaValidacion;
			cmd.Parameters.Add( new SqlParameter( "@IdValidacion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdValidacion" ].Value = IdValidacion;
			cmd.Parameters.Add( new SqlParameter( "@IdProceso", SqlDbType.BigInt ) );
			if ( IdProceso == long.MinValue )
			{
				cmd.Parameters[ "@IdProceso" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdProceso" ].Value = IdProceso;
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
			cmd.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt ) );
			if ( IdPerfil == long.MinValue )
			{
				cmd.Parameters[ "@IdPerfil" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdPerfil" ].Value = IdPerfil;
			}
			adapter.SelectCommand = cmd;
			try
			{
				adapter.Fill( data );
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
         
			return data;
		}

		public static twf_ProcesosTareasValidacionesDataset.twf_ProcesosTareasValidacionesRow NewRow()
		{
			return ( new twf_ProcesosTareasValidacionesDataset() ).twf_ProcesosTareasValidaciones.Newtwf_ProcesosTareasValidacionesRow();
		}
	
		public static twf_ProcesosTareasValidacionesDataset.twf_ProcesosTareasValidacionesRow GetByPk( string IdProcesoTareaValidacion )
		{
			twf_ProcesosTareasValidacionesDataset data = new twf_ProcesosTareasValidacionesDataset();

			SqlCommand cmd = new SqlCommand( "Pr_twf_ProcesosTareasValidaciones_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdProcesoTareaValidacion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProcesoTareaValidacion" ].Value = IdProcesoTareaValidacion;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "twf_ProcesosTareasValidaciones" );

			adapter.Fill( data );

			if ( data.twf_ProcesosTareasValidaciones.Rows.Count == 1 )
			{
				return ( twf_ProcesosTareasValidacionesDataset.twf_ProcesosTareasValidacionesRow )data.twf_ProcesosTareasValidaciones.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( twf_ProcesosTareasValidacionesDataset.twf_ProcesosTareasValidacionesRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( twf_ProcesosTareasValidacionesDataset.twf_ProcesosTareasValidacionesDataTable )row.Table ).Addtwf_ProcesosTareasValidacionesRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( twf_ProcesosTareasValidacionesDataset dataSet )
		{
			Update( dataSet.twf_ProcesosTareasValidaciones );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( twf_ProcesosTareasValidacionesDataset.twf_ProcesosTareasValidacionesDataTable )dataTable, trx );
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
			Update( ( twf_ProcesosTareasValidacionesDataset.twf_ProcesosTareasValidacionesDataTable )dataTable, trx );
		}
				

		public static void Update( twf_ProcesosTareasValidacionesDataset.twf_ProcesosTareasValidacionesDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "twf_ProcesosTareasValidaciones", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdProcesoTareaValidacion", "IdProcesoTareaValidacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdValidacion", "IdValidacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdProceso", "IdProceso" ),
																											 new System.Data.Common.DataColumnMapping( "IdTarea", "IdTarea" ),
																											 new System.Data.Common.DataColumnMapping( "IdPerfil", "IdPerfil" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_twf_ProcesosTareasValidaciones_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProcesoTareaValidacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProcesoTareaValidacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdValidacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdValidacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProceso", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProceso", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTarea", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdPerfil", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdProcesoTareaValidacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProcesoTareaValidacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_twf_ProcesosTareasValidaciones_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdProcesoTareaValidacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProcesoTareaValidacion", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_twf_ProcesosTareasValidaciones_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProcesoTareaValidacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProcesoTareaValidacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdValidacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdValidacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProceso", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProceso", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTarea", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdPerfil", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );

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


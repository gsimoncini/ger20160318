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

	public class sy_PerfilesFuncionalidades : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public sy_PerfilesFuncionalidades()
		{
		}

		public static sy_PerfilesFuncionalidadesDataset GetList()
		{
			sy_PerfilesFuncionalidadesDataset data = new sy_PerfilesFuncionalidadesDataset();

			return ( sy_PerfilesFuncionalidadesDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_PerfilesFuncionalidades" );
			
			SqlCommand cmd = new SqlCommand( "Pr_sy_PerfilesFuncionalidades_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static sy_PerfilesFuncionalidadesDataset.sy_PerfilesFuncionalidadesRow NewRow()
		{
			return ( new sy_PerfilesFuncionalidadesDataset() ).sy_PerfilesFuncionalidades.Newsy_PerfilesFuncionalidadesRow();
		}
	
		public static sy_PerfilesFuncionalidadesDataset.sy_PerfilesFuncionalidadesRow GetByPk( long IdPerfil, long IdFuncionalidad )
		{
			sy_PerfilesFuncionalidadesDataset data = new sy_PerfilesFuncionalidadesDataset();

			SqlCommand cmd = new SqlCommand( "Pr_sy_PerfilesFuncionalidades_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdPerfil" ].Value = IdPerfil;
			
			cmd.Parameters.Add( new SqlParameter( "@IdFuncionalidad", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdFuncionalidad" ].Value = IdFuncionalidad;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "sy_PerfilesFuncionalidades" );

			adapter.Fill( data );

			if ( data.sy_PerfilesFuncionalidades.Rows.Count == 1 )
			{
				return ( sy_PerfilesFuncionalidadesDataset.sy_PerfilesFuncionalidadesRow )data.sy_PerfilesFuncionalidades.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( sy_PerfilesFuncionalidadesDataset.sy_PerfilesFuncionalidadesRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( sy_PerfilesFuncionalidadesDataset.sy_PerfilesFuncionalidadesDataTable )row.Table ).Addsy_PerfilesFuncionalidadesRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( sy_PerfilesFuncionalidadesDataset dataSet )
		{
			Update( dataSet.sy_PerfilesFuncionalidades );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( sy_PerfilesFuncionalidadesDataset.sy_PerfilesFuncionalidadesDataTable )dataTable, trx );
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
			Update( ( sy_PerfilesFuncionalidadesDataset.sy_PerfilesFuncionalidadesDataTable )dataTable, trx );
		}
				

		public static void Update( sy_PerfilesFuncionalidadesDataset.sy_PerfilesFuncionalidadesDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
					new System.Data.Common.DataTableMapping( "Table", "sy_PerfilesFuncionalidades", 
						new System.Data.Common.DataColumnMapping[] {
							new System.Data.Common.DataColumnMapping( "IdPerfil", "IdPerfil" ),
							new System.Data.Common.DataColumnMapping( "IdFuncionalidad", "IdFuncionalidad" ),
							new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
							new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
							new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
							new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
							new System.Data.Common.DataColumnMapping( "RowId", "RowId" )
						}
					)
				}
			);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_sy_PerfilesFuncionalidades_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdPerfil", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdFuncionalidad", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdFuncionalidad", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdPerfil", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdPerfil", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdFuncionalidad", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdFuncionalidad", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_sy_PerfilesFuncionalidades_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdPerfil", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdFuncionalidad", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdFuncionalidad", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_sy_PerfilesFuncionalidades_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdPerfil", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdFuncionalidad", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdFuncionalidad", DataRowVersion.Current, null ) );
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


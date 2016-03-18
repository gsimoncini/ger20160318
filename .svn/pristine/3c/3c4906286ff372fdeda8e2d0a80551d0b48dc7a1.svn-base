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

	public class sy_PerfilesUsuariosEmpresas : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public sy_PerfilesUsuariosEmpresas()
		{
		}

		public static sy_PerfilesUsuariosEmpresasDataset GetList()
		{
			sy_PerfilesUsuariosEmpresasDataset data = new sy_PerfilesUsuariosEmpresasDataset();

			return ( sy_PerfilesUsuariosEmpresasDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_PerfilesUsuariosEmpresas" );
			
			SqlCommand cmd = new SqlCommand( "Pr_sy_PerfilesUsuariosEmpresas_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static sy_PerfilesUsuariosEmpresasDataset GetList( string IdUsuario, long IdPerfil, long IdEmpresa )
		{
			
			sy_PerfilesUsuariosEmpresasDataset data = new sy_PerfilesUsuariosEmpresasDataset();
			
			try
			{			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "sy_PerfilesUsuariosEmpresas" );

				SqlCommand cmd = new SqlCommand( "Pr_sy_PerfilesUsuariosEmpresas_Search", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
			
				cmd.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar ) );				
				if (IdUsuario.Equals(string.Empty))
					cmd.Parameters[ "@IdUsuario" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdUsuario" ].Value = IdUsuario;

				cmd.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt ) );
				if ( IdPerfil == long.MinValue )
					cmd.Parameters[ "@IdPerfil" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdPerfil" ].Value = IdPerfil;
				
				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
				if ( IdEmpresa == long.MinValue )
					cmd.Parameters[ "@IdEmpresa" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;
				
				adapter.SelectCommand = cmd;
				adapter.Fill( data );
			}
			catch(Exception e)
			{
				//Debug.WriteLine(e.Message);
			}
         
			return data;
		}

		public static sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasRow NewRow()
		{
			return ( new sy_PerfilesUsuariosEmpresasDataset() ).sy_PerfilesUsuariosEmpresas.Newsy_PerfilesUsuariosEmpresasRow();
		}
	
		public static sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasRow GetByPk( string IdUsuario, long IdPerfil, long IdEmpresa )
		{
			sy_PerfilesUsuariosEmpresasDataset data = new sy_PerfilesUsuariosEmpresasDataset();

			SqlCommand cmd = new SqlCommand( "Pr_sy_PerfilesUsuariosEmpresas_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar ) );
			if(IdUsuario.Equals(string.Empty))
				cmd.Parameters[ "@IdUsuario" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdUsuario" ].Value = IdUsuario;
			
			cmd.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt ) );
			if(IdPerfil.Equals(long.MinValue))
				cmd.Parameters[ "@IdPerfil" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdPerfil" ].Value = IdPerfil;
			
			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
			if(IdEmpresa.Equals(long.MinValue))
				cmd.Parameters[ "@IdEmpresa" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "sy_PerfilesUsuariosEmpresas" );

			adapter.Fill( data );

			if ( data.sy_PerfilesUsuariosEmpresas.Rows.Count == 1 )
			{
				return ( sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasRow )data.sy_PerfilesUsuariosEmpresas.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasDataTable )row.Table ).Addsy_PerfilesUsuariosEmpresasRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( sy_PerfilesUsuariosEmpresasDataset dataSet )
		{
			Update( dataSet.sy_PerfilesUsuariosEmpresas );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( dataTable, trx );
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
					new System.Data.Common.DataTableMapping( "Table", "sy_PerfilesUsuariosEmpresas", 
						new System.Data.Common.DataColumnMapping[] {
							new System.Data.Common.DataColumnMapping( "IdUsuario", "IdUsuario" ),
							new System.Data.Common.DataColumnMapping( "IdPerfil", "IdPerfil" ),
							new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
							new System.Data.Common.DataColumnMapping( "ConexionDefault", "ConexionDefault" ),
							new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
							new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
							new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
							new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
							new System.Data.Common.DataColumnMapping( "RowId", "RowId" )
						}
					)
				}
			);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_sy_PerfilesUsuariosEmpresas_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdUsuario", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdPerfil", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ConexionDefault", SqlDbType.TinyInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "ConexionDefault", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdUsuario", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdUsuario", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdPerfil", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdPerfil", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdEmpresa", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_sy_PerfilesUsuariosEmpresas_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdUsuario", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdPerfil", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_sy_PerfilesUsuariosEmpresas_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdUsuario", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdPerfil", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@ConexionDefault", SqlDbType.TinyInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "ConexionDefault", DataRowVersion.Current, null ) );
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


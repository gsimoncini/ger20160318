
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

	public class sy_Perfiles : IDisposable
	{
	
		#region Custom Members
		public static sy_PerfilesDataset GetList( long IdEmpresa, string IdUsuario )
		{
			sy_PerfilesDataset data = new sy_PerfilesDataset();

			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_Perfiles" );
			
			SqlCommand cmd = new SqlCommand( "Pr_sy_Perfiles_GetList_By_Empresa_Usuario", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;

			cmd.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdUsuario" ].Value = IdUsuario;


			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;

		}
		#endregion
		
		public sy_Perfiles()
		{
		}

//		public static sy_PerfilesDataset GetList()
//		{
//			sy_PerfilesDataset data = new sy_PerfilesDataset();
//
//			return ( sy_PerfilesDataset )GetList( data );
//		}
//
//		public static DataSet GetList( DataSet data )
//		{
//			SqlDataAdapter adapter = new SqlDataAdapter();
//			adapter.TableMappings.Add( "Table", "sy_Perfiles" );
//			
//			SqlCommand cmd = new SqlCommand( "Pr_sy_Perfiles_GetList", dbhelper.Connection.GetConnection() );
//			cmd.CommandType = CommandType.StoredProcedure;
//
//			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
//			cmd.Parameters[ "@Activo" ].Value = 1;
//
//			adapter.SelectCommand = cmd;
//
//			adapter.Fill( data );
//         
//			return data;
//		}
		
		public static sy_PerfilesDataset GetList()
		{
			return ( sy_PerfilesDataset )GetList( true );
		}

		public static DataSet GetList( bool activo )
		{
			sy_PerfilesDataset data = new sy_PerfilesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_Perfiles" );
			
			SqlCommand cmd = new SqlCommand( "Pr_sy_Perfiles_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = activo;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static sy_PerfilesDataset GetList( long IdPerfil, string Descripcion, bool Activo, string Comentario, long IdConexion, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId )
		{
			sy_PerfilesDataset data = new sy_PerfilesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_Perfiles" );

			SqlCommand cmd = new SqlCommand( "Pr_sy_Perfiles_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
   			cmd.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt ) );
			if ( IdPerfil == long.MinValue )
		  	{
               		cmd.Parameters[ "@IdPerfil" ].Value = System.DBNull.Value;
		   	}
		   	else
		   	{
               		cmd.Parameters[ "@IdPerfil" ].Value = IdPerfil;
		   	}
   			cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
               		cmd.Parameters[ "@Descripcion" ].Value = Descripcion;
   			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
               		cmd.Parameters[ "@Activo" ].Value = Activo;
   			cmd.Parameters.Add( new SqlParameter( "@Comentario", SqlDbType.VarChar ) );
               		cmd.Parameters[ "@Comentario" ].Value = Comentario;
   			cmd.Parameters.Add( new SqlParameter( "@IdConexion", SqlDbType.BigInt ) );
			if ( IdConexion == long.MinValue )
		  	{
               		cmd.Parameters[ "@IdConexion" ].Value = System.DBNull.Value;
		   	}
		   	else
		   	{
               		cmd.Parameters[ "@IdConexion" ].Value = IdConexion;
		   	}
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

		public static sy_PerfilesDataset.sy_PerfilesRow NewRow()
		{
			return ( new sy_PerfilesDataset() ).sy_Perfiles.Newsy_PerfilesRow();
		}
	
		public static sy_PerfilesDataset.sy_PerfilesRow GetByPk( long IdPerfil )
		{
			sy_PerfilesDataset data = new sy_PerfilesDataset();

			SqlCommand cmd = new SqlCommand( "Pr_sy_Perfiles_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdPerfil" ].Value = IdPerfil;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "sy_Perfiles" );

			adapter.Fill( data );

			if ( data.sy_Perfiles.Rows.Count == 1 )
			{
				return ( sy_PerfilesDataset.sy_PerfilesRow )data.sy_Perfiles.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( sy_PerfilesDataset.sy_PerfilesRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( sy_PerfilesDataset.sy_PerfilesDataTable )row.Table ).Addsy_PerfilesRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( sy_PerfilesDataset dataSet )
		{
			Update( dataSet.sy_Perfiles );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( sy_PerfilesDataset.sy_PerfilesDataTable )dataTable, trx );
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

		public static void Update( DataTable dataTable, string transaction )
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(transaction);
			Update( ( sy_PerfilesDataset.sy_PerfilesDataTable )dataTable, trx );
		}
		
		public static void Update( DataTable dataTable, SqlTransaction trx )
		{
			Update( ( sy_PerfilesDataset.sy_PerfilesDataTable )dataTable, trx );
		}
				

		public static void Update( sy_PerfilesDataset.sy_PerfilesDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
					new System.Data.Common.DataTableMapping( "Table", "sy_Perfiles", 
						new System.Data.Common.DataColumnMapping[] {
							new System.Data.Common.DataColumnMapping( "IdPerfil", "IdPerfil" ),
							new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" ),
							new System.Data.Common.DataColumnMapping( "Activo", "Activo" ),
							new System.Data.Common.DataColumnMapping( "Comentario", "Comentario" ),
							new System.Data.Common.DataColumnMapping( "IdConexion", "IdConexion" ),
							new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
							new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
							new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
							new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
							new System.Data.Common.DataColumnMapping( "RowId", "RowId" )
						}
					)
				}
			);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_sy_Perfiles_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdPerfil", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Comentario", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Comentario", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdPerfil", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdPerfil", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_sy_Perfiles_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdPerfil", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_sy_Perfiles_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Comentario", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Comentario", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.BigInt, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdPerfil", DataRowVersion.Current, null ) );

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


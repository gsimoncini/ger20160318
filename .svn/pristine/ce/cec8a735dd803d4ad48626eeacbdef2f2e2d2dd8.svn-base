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

	public class sy_SentenciasReplicacion : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public sy_SentenciasReplicacion()
		{
		}

		/*public static sy_SentenciasReplicacionDataset GetList()
		{
			sy_SentenciasReplicacionDataset data = new sy_SentenciasReplicacionDataset();

			return ( sy_SentenciasReplicacionDataset )GetList( data );
		}*/

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_SentenciasReplicacion" );
			
			SqlCommand cmd = new SqlCommand( "Pr_sy_SentenciasReplicacion_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static sy_SentenciasReplicacionDataset GetList(  )
		{
			sy_SentenciasReplicacionDataset data = new sy_SentenciasReplicacionDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_SentenciasReplicacion" );

			SqlCommand cmd = new SqlCommand( "Pr_sy_SentenciasReplicacion_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static sy_SentenciasReplicacionDataset.sy_SentenciasReplicacionRow NewRow()
		{
			return ( new sy_SentenciasReplicacionDataset() ).sy_SentenciasReplicacion.Newsy_SentenciasReplicacionRow();
		}
	
		public static sy_SentenciasReplicacionDataset.sy_SentenciasReplicacionRow GetByPk( long IdSentenciaReplicacion )
		{
			sy_SentenciasReplicacionDataset data = new sy_SentenciasReplicacionDataset();

			SqlCommand cmd = new SqlCommand( "Pr_sy_SentenciasReplicacion_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdSentenciaReplicacion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdSentenciaReplicacion" ].Value = IdSentenciaReplicacion;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "sy_SentenciasReplicacion" );

			adapter.Fill( data );

			if ( data.sy_SentenciasReplicacion.Rows.Count == 1 )
			{
				return ( sy_SentenciasReplicacionDataset.sy_SentenciasReplicacionRow )data.sy_SentenciasReplicacion.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( sy_SentenciasReplicacionDataset.sy_SentenciasReplicacionRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( sy_SentenciasReplicacionDataset.sy_SentenciasReplicacionDataTable )row.Table ).Addsy_SentenciasReplicacionRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( sy_SentenciasReplicacionDataset dataSet )
		{
			Update( dataSet.sy_SentenciasReplicacion );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( sy_SentenciasReplicacionDataset.sy_SentenciasReplicacionDataTable )dataTable, trx );
				trx.Commit();
			}
			catch(Exception e)
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
			Update( ( sy_SentenciasReplicacionDataset.sy_SentenciasReplicacionDataTable )dataTable, trx );
		}


		public static void Update( sy_SentenciasReplicacionDataset.sy_SentenciasReplicacionDataTable dataTable, string IdTransaction )
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			Update(dataTable, trx);
		}


		public static void Update( sy_SentenciasReplicacionDataset.sy_SentenciasReplicacionDataTable dataTable, SqlTransaction trx )
		{
            //German 20110301 - Tarea 0000079
            /*
            SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "sy_SentenciasReplicacion", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdSentenciaReplicacion", "IdSentenciaReplicacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdTabla", "IdTabla" ),
																											 new System.Data.Common.DataColumnMapping( "IdTipoSentencia", "IdTipoSentencia" ),
																											 new System.Data.Common.DataColumnMapping( "Sentencia", "Sentencia" ),
																											 new System.Data.Common.DataColumnMapping( "SentenciaRowId", "SentenciaRowId" ),
																											 new System.Data.Common.DataColumnMapping( "NombreArchivo", "NombreArchivo" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursalGeneradora", "IdSucursalGeneradora" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexion", "IdConexion" ),
																											 new System.Data.Common.DataColumnMapping( "Destino", "Destino" ),
																											 new System.Data.Common.DataColumnMapping( "VersionBD", "VersionBD" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_sy_SentenciasReplicacion_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSentenciaReplicacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSentenciaReplicacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTabla", SqlDbType.VarChar, 300, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTabla", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTipoSentencia", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTipoSentencia", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Sentencia", SqlDbType.Text, 2147483647, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Sentencia", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@SentenciaRowId", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "SentenciaRowId", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@NombreArchivo", SqlDbType.VarChar, 250, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "NombreArchivo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursalGeneradora", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursalGeneradora", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Destino", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Destino", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@VersionBD", SqlDbType.VarBinary, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "VersionBD", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdSentenciaReplicacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdSentenciaReplicacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_sy_SentenciasReplicacion_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdSentenciaReplicacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSentenciaReplicacion", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_sy_SentenciasReplicacion_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTabla", SqlDbType.VarChar, 300, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTabla", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTipoSentencia", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoSentencia", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Sentencia", SqlDbType.Text, 2147483647, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Sentencia", DataRowVersion.Current, null ) );
			//sqlCommandInsert.Parameters.Add( new SqlParameter( "@SentenciaRowId", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "SentenciaRowId", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@NombreArchivo", SqlDbType.VarChar, 250, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "NombreArchivo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursalGeneradora", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursalGeneradora", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Destino", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Destino", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@VersionBD", SqlDbType.VarBinary, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "VersionBD", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSentenciaReplicacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSentenciaReplicacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add("@SentenciaRowId", SqlDbType.UniqueIdentifier).Value = System.DBNull.Value;

			adapter.UpdateCommand = sqlCommandUpdate;
			adapter.DeleteCommand = sqlCommandDelete;
			adapter.InsertCommand = sqlCommandInsert;
			
			System.Diagnostics.Debug.WriteLine((string)dataTable.Rows[0]["Sentencia"]);

			adapter.Update ( dataTable );
             */
            //Fin German 20110301 - Tarea 0000079
		}
		
		public void Dispose()
		{
		}

		
	}
}



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

	public class twf_TareasTiposDeComprobantes : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public twf_TareasTiposDeComprobantes()
		{
		}

		public static twf_TareasTiposDeComprobantesDataset GetList()
		{
			twf_TareasTiposDeComprobantesDataset data = new twf_TareasTiposDeComprobantesDataset();

			return ( twf_TareasTiposDeComprobantesDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "twf_TareasTiposDeComprobantes" );
			
			SqlCommand cmd = new SqlCommand( "Pr_twf_TareasTiposDeComprobantes_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static twf_TareasTiposDeComprobantesDataset GetList( long IdTarea, string IdTipoDeComprobante, long IdConexion, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId, string Observaciones )
		{
			twf_TareasTiposDeComprobantesDataset data = new twf_TareasTiposDeComprobantesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "twf_TareasTiposDeComprobantes" );

			SqlCommand cmd = new SqlCommand( "Pr_twf_TareasTiposDeComprobantes_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt ) );
			if ( IdTarea == long.MinValue )
			{
				cmd.Parameters[ "@IdTarea" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdTarea" ].Value = IdTarea;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTipoDeComprobante" ].Value = IdTipoDeComprobante;
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
			cmd.Parameters.Add( new SqlParameter( "@Observaciones", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Observaciones" ].Value = Observaciones;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static twf_TareasTiposDeComprobantesDataset.twf_TareasTiposDeComprobantesRow NewRow()
		{
			return ( new twf_TareasTiposDeComprobantesDataset() ).twf_TareasTiposDeComprobantes.Newtwf_TareasTiposDeComprobantesRow();
		}
	
		public static twf_TareasTiposDeComprobantesDataset.twf_TareasTiposDeComprobantesRow GetByPk( long IdTarea, string IdTipoDeComprobante )
		{
			twf_TareasTiposDeComprobantesDataset data = new twf_TareasTiposDeComprobantesDataset();

			SqlCommand cmd = new SqlCommand( "Pr_twf_TareasTiposDeComprobantes_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdTarea" ].Value = IdTarea;
			
			cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTipoDeComprobante" ].Value = IdTipoDeComprobante;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "twf_TareasTiposDeComprobantes" );

			adapter.Fill( data );

			if ( data.twf_TareasTiposDeComprobantes.Rows.Count == 1 )
			{
				return ( twf_TareasTiposDeComprobantesDataset.twf_TareasTiposDeComprobantesRow )data.twf_TareasTiposDeComprobantes.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( twf_TareasTiposDeComprobantesDataset.twf_TareasTiposDeComprobantesRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( twf_TareasTiposDeComprobantesDataset.twf_TareasTiposDeComprobantesDataTable )row.Table ).Addtwf_TareasTiposDeComprobantesRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( twf_TareasTiposDeComprobantesDataset dataSet )
		{
			Update( dataSet.twf_TareasTiposDeComprobantes );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( twf_TareasTiposDeComprobantesDataset.twf_TareasTiposDeComprobantesDataTable )dataTable, trx );
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
			Update( ( twf_TareasTiposDeComprobantesDataset.twf_TareasTiposDeComprobantesDataTable )dataTable, trx );
		}
				

		public static void Update( twf_TareasTiposDeComprobantesDataset.twf_TareasTiposDeComprobantesDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "twf_TareasTiposDeComprobantes", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdTarea", "IdTarea" ),
																											 new System.Data.Common.DataColumnMapping( "IdTipoDeComprobante", "IdTipoDeComprobante" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexion", "IdConexion" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "Observaciones", "Observaciones" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_twf_TareasTiposDeComprobantes_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTarea", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTipoDeComprobante", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Observaciones", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Observaciones", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTarea", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdTipoDeComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTipoDeComprobante", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_twf_TareasTiposDeComprobantes_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTarea", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoDeComprobante", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_twf_TareasTiposDeComprobantes_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTarea", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoDeComprobante", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Observaciones", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Observaciones", DataRowVersion.Current, null ) );

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


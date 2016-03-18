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

	public class tsa_ComprobantesAutorizaciones : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsa_ComprobantesAutorizaciones()
		{
		}

		public static tsa_ComprobantesAutorizacionesDataset GetList()
		{
			tsa_ComprobantesAutorizacionesDataset data = new tsa_ComprobantesAutorizacionesDataset();

			return ( tsa_ComprobantesAutorizacionesDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_ComprobantesAutorizaciones" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsa_ComprobantesAutorizaciones_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		/*public static tsa_ComprobantesAutorizacionesDataset GetList(  )
		{
			tsa_ComprobantesAutorizacionesDataset data = new tsa_ComprobantesAutorizacionesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_ComprobantesAutorizaciones" );

			SqlCommand cmd = new SqlCommand( "Pr_tsa_ComprobantesAutorizaciones_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}*/

		public static tsa_ComprobantesAutorizacionesDataset.tsa_ComprobantesAutorizacionesRow NewRow()
		{
			return ( new tsa_ComprobantesAutorizacionesDataset() ).tsa_ComprobantesAutorizaciones.Newtsa_ComprobantesAutorizacionesRow();
		}
	
		public static tsa_ComprobantesAutorizacionesDataset.tsa_ComprobantesAutorizacionesRow GetByPk( string IdComprobante )
		{
			tsa_ComprobantesAutorizacionesDataset data = new tsa_ComprobantesAutorizacionesDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsa_ComprobantesAutorizaciones_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsa_ComprobantesAutorizaciones" );

			adapter.Fill( data );

			if ( data.tsa_ComprobantesAutorizaciones.Rows.Count == 1 )
			{
				return ( tsa_ComprobantesAutorizacionesDataset.tsa_ComprobantesAutorizacionesRow )data.tsa_ComprobantesAutorizaciones.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tsa_ComprobantesAutorizacionesDataset.tsa_ComprobantesAutorizacionesRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsa_ComprobantesAutorizacionesDataset.tsa_ComprobantesAutorizacionesDataTable )row.Table ).Addtsa_ComprobantesAutorizacionesRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tsa_ComprobantesAutorizacionesDataset dataSet )
		{
			Update( dataSet.tsa_ComprobantesAutorizaciones );
		}
		

		public static void Update(DataTable table, string IdTransaction)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			Update(table, trx);
		}

		public static void Update( DataTable dataTable)
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

		/*public static void Update( DataTable dataTable, SqlTransaction trx )
		{
			Update( dataTable, trx );
		}*/
				

		public static void Update( DataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsa_ComprobantesAutorizaciones", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdComprobanteAutorizacion", "IdComprobanteAutorizacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdComprobante", "IdComprobante" ),
																											 new System.Data.Common.DataColumnMapping( "IdAutorizacion", "IdAutorizacion" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsa_ComprobantesAutorizaciones_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdComprobanteAutorizacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdComprobanteAutorizacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdComprobante", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdAutorizacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdAutorizacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobante", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsa_ComprobantesAutorizaciones_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobante", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsa_ComprobantesAutorizaciones_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdComprobanteAutorizacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobanteAutorizacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobante", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdAutorizacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdAutorizacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );

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


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

	public class tpu_ComprobantesPago : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_ComprobantesPago()
		{
		}

		public static tpu_ComprobantesPagoDataset GetList()
		{
			tpu_ComprobantesPagoDataset data = new tpu_ComprobantesPagoDataset();

			return ( tpu_ComprobantesPagoDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ComprobantesPago" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesPago_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_ComprobantesPagoDataset GetList( string IdComprobantePago, string IdResponsable, string IdAutorizacion )
		{
			tpu_ComprobantesPagoDataset data = new tpu_ComprobantesPagoDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ComprobantesPago" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesPago_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdComprobantePago", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobantePago" ].Value = IdComprobantePago;
			cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdResponsable" ].Value = IdResponsable;
			cmd.Parameters.Add( new SqlParameter( "@IdAutorizacion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdAutorizacion" ].Value = IdAutorizacion;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_ComprobantesPagoDataset.tpu_ComprobantesPagoRow NewRow()
		{
			return ( new tpu_ComprobantesPagoDataset() ).tpu_ComprobantesPago.Newtpu_ComprobantesPagoRow();
		}
	
		public static tpu_ComprobantesPagoDataset.tpu_ComprobantesPagoRow GetByPk( string IdComprobantePago )
		{
			tpu_ComprobantesPagoDataset data = new tpu_ComprobantesPagoDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tpu_ComprobantesPago_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdComprobantePago", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobantePago" ].Value = IdComprobantePago;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tpu_ComprobantesPago" );

			adapter.Fill( data );

			if ( data.tpu_ComprobantesPago.Rows.Count == 1 )
			{
				return ( tpu_ComprobantesPagoDataset.tpu_ComprobantesPagoRow )data.tpu_ComprobantesPago.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tpu_ComprobantesPagoDataset.tpu_ComprobantesPagoRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tpu_ComprobantesPagoDataset.tpu_ComprobantesPagoDataTable )row.Table ).Addtpu_ComprobantesPagoRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tpu_ComprobantesPagoDataset dataSet )
		{
			Update( dataSet.tpu_ComprobantesPago );
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

		public static void Update( DataTable dataTable, string IdTransaction)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			Update(dataTable, trx);
		}

		public static void Update( DataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tpu_ComprobantesPago", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdComprobantePago", "IdComprobantePago" ),
																											 new System.Data.Common.DataColumnMapping( "IdResponsable", "IdResponsable" ),
																											 new System.Data.Common.DataColumnMapping( "IdAutorizacion", "IdAutorizacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdInstanciaCaja", "IdInstanciaCaja" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tpu_ComprobantesPago_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdComprobantePago", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdComprobantePago", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdResponsable", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdAutorizacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdAutorizacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdInstanciaCaja", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdComprobantePago", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobantePago", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tpu_ComprobantesPago_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdComprobantePago", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobantePago", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tpu_ComprobantesPago_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdComprobantePago", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobantePago", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdResponsable", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdAutorizacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdAutorizacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdInstanciaCaja", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdInstanciaCaja", DataRowVersion.Current, null ) );
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


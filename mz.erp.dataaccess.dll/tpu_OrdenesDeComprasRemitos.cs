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

	public class tpu_OrdenesDeComprasRemitos : IDisposable
	{
	
		#region Custom Members

		public static DataSet GetItems(string IdComprobanteRemito)
		{
			
			tpu_OrdenesDeComprasRemitosDataset data = new tpu_OrdenesDeComprasRemitosDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_OrdenesDeComprasRemitos" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_OrdenesDeComprasRemitos_getItems", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdComprobanteDestino", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobanteDestino" ].Value = IdComprobanteRemito;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}
		
		#endregion
		
		public tpu_OrdenesDeComprasRemitos()
		{
		}

		public static tpu_OrdenesDeComprasRemitosDataset GetList()
		{
			tpu_OrdenesDeComprasRemitosDataset data = new tpu_OrdenesDeComprasRemitosDataset();

			return ( tpu_OrdenesDeComprasRemitosDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_OrdenesDeComprasRemitos" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tpu_OrdenesDeComprasRemitos_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_OrdenesDeComprasRemitosDataset GetList( string IdComprobanteOrigen, long OrdinalOrigen, string IdComprobanteDestino, long OrdinalDestino )
		{
			tpu_OrdenesDeComprasRemitosDataset data = new tpu_OrdenesDeComprasRemitosDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_OrdenesDeComprasRemitos" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_OrdenesDeComprasRemitos_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdComprobanteOrigen", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobanteOrigen" ].Value = IdComprobanteOrigen;
			cmd.Parameters.Add( new SqlParameter( "@OrdinalOrigen", SqlDbType.BigInt ) );
			if ( OrdinalOrigen == long.MinValue )
			{
				cmd.Parameters[ "@OrdinalOrigen" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@OrdinalOrigen" ].Value = OrdinalOrigen;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdComprobanteDestino", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobanteDestino" ].Value = IdComprobanteDestino;
			cmd.Parameters.Add( new SqlParameter( "@OrdinalDestino", SqlDbType.BigInt ) );
			if ( OrdinalDestino == long.MinValue )
			{
				cmd.Parameters[ "@OrdinalDestino" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@OrdinalDestino" ].Value = OrdinalDestino;
			}
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_OrdenesDeComprasRemitosDataset.tpu_OrdenesDeComprasRemitosRow NewRow()
		{
			return ( new tpu_OrdenesDeComprasRemitosDataset() ).tpu_OrdenesDeComprasRemitos.Newtpu_OrdenesDeComprasRemitosRow();
		}
	
		public static tpu_OrdenesDeComprasRemitosDataset.tpu_OrdenesDeComprasRemitosRow GetByPk( string IdComprobanteOrigen, long OrdinalOrigen, string IdComprobanteDestino, long OrdinalDestino )
		{
			tpu_OrdenesDeComprasRemitosDataset data = new tpu_OrdenesDeComprasRemitosDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tpu_OrdenesDeComprasRemitos_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdComprobanteOrigen", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobanteOrigen" ].Value = IdComprobanteOrigen;
			
			cmd.Parameters.Add( new SqlParameter( "@OrdinalOrigen", SqlDbType.BigInt ) );
			cmd.Parameters[ "@OrdinalOrigen" ].Value = OrdinalOrigen;
			
			cmd.Parameters.Add( new SqlParameter( "@IdComprobanteDestino", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobanteDestino" ].Value = IdComprobanteDestino;
			
			cmd.Parameters.Add( new SqlParameter( "@OrdinalDestino", SqlDbType.BigInt ) );
			cmd.Parameters[ "@OrdinalDestino" ].Value = OrdinalDestino;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tpu_OrdenesDeComprasRemitos" );

			adapter.Fill( data );

			if ( data.tpu_OrdenesDeComprasRemitos.Rows.Count == 1 )
			{
				return ( tpu_OrdenesDeComprasRemitosDataset.tpu_OrdenesDeComprasRemitosRow )data.tpu_OrdenesDeComprasRemitos.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tpu_OrdenesDeComprasRemitosDataset.tpu_OrdenesDeComprasRemitosRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tpu_OrdenesDeComprasRemitosDataset.tpu_OrdenesDeComprasRemitosDataTable )row.Table ).Addtpu_OrdenesDeComprasRemitosRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tpu_OrdenesDeComprasRemitosDataset dataSet )
		{
			Update( dataSet.tpu_OrdenesDeComprasRemitos );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tpu_OrdenesDeComprasRemitosDataset.tpu_OrdenesDeComprasRemitosDataTable )dataTable, trx );
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
			Update( ( tpu_OrdenesDeComprasRemitosDataset.tpu_OrdenesDeComprasRemitosDataTable )dataTable, trx );
		}
				

		public static void Update( tpu_OrdenesDeComprasRemitosDataset.tpu_OrdenesDeComprasRemitosDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tpu_OrdenesDeComprasRemitos", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdComprobanteOrigen", "IdComprobanteOrigen" ),
																											 new System.Data.Common.DataColumnMapping( "OrdinalOrigen", "OrdinalOrigen" ),
																											 new System.Data.Common.DataColumnMapping( "IdComprobanteDestino", "IdComprobanteDestino" ),
																											 new System.Data.Common.DataColumnMapping( "OrdinalDestino", "OrdinalDestino" ),
																											 new System.Data.Common.DataColumnMapping( "CantidadOrigen", "CantidadOrigen" ),
																											 new System.Data.Common.DataColumnMapping( "CantidadDestino", "CantidadDestino" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tpu_OrdenesDeComprasRemitos_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdComprobanteOrigen", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdComprobanteOrigen", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OrdinalOrigen", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "OrdinalOrigen", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdComprobanteDestino", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdComprobanteDestino", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OrdinalDestino", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "OrdinalDestino", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CantidadOrigen", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CantidadOrigen", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CantidadDestino", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CantidadDestino", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdComprobanteOrigen", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobanteOrigen", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldOrdinalOrigen", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OrdinalOrigen", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdComprobanteDestino", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobanteDestino", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldOrdinalDestino", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OrdinalDestino", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tpu_OrdenesDeComprasRemitos_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdComprobanteOrigen", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobanteOrigen", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@OrdinalOrigen", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "OrdinalOrigen", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdComprobanteDestino", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobanteDestino", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@OrdinalDestino", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "OrdinalDestino", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tpu_OrdenesDeComprasRemitos_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdComprobanteOrigen", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobanteOrigen", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@OrdinalOrigen", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "OrdinalOrigen", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdComprobanteDestino", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobanteDestino", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@OrdinalDestino", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "OrdinalDestino", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CantidadOrigen", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CantidadOrigen", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CantidadDestino", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CantidadDestino", DataRowVersion.Current, null ) );
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


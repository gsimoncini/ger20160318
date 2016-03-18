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

	public class tlg_MovimientosDeStockNumerosDeSerie : IDisposable
	{
	
		#region Custom Members

			public static bool ExistsNueroDeSerie(string NumeroDeSerie, string IdProducto, string IdEstadoDeStock)
			{
				DataSet data = new DataSet();
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "tlg_MovimientosDeStockNumerosDeSerie" );
				SqlCommand cmd = new SqlCommand( "Pr_tlg_MovimientosDeStockNumerosDeSerieExistsNumeroDeSerie", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
				cmd.Parameters.Add( new SqlParameter( "@NumeroDeSerie", SqlDbType.VarChar ) );
				cmd.Parameters[ "@NumeroDeSerie" ].Value = NumeroDeSerie;
				cmd.Parameters.Add( new SqlParameter( "@IdEstadoDeStock", SqlDbType.VarChar ) );
				if(IdEstadoDeStock != null && !IdEstadoDeStock.Equals(string.Empty))
					cmd.Parameters[ "@IdEstadoDeStock" ].Value = IdEstadoDeStock;
				else
					cmd.Parameters[ "@IdEstadoDeStock" ].Value = System.DBNull.Value ;
				adapter.SelectCommand = cmd;

				adapter.Fill( data );
				if(data.Tables[0].Rows.Count > 0)
					return Convert.ToDecimal(data.Tables[0].Rows[0]["Cantidad"]) > 0;
				return false;
				
			}

		public static DataSet GetNumerosDeSerieParaBaja(string IdProducto, string IdEstadoDeStock)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			SqlCommand cmd = new SqlCommand( "Pr_tlg_MovimientosDeStockNumerosDeSerie_GetNumerosDeSerieParaEstadoStock", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			cmd.Parameters.Add( new SqlParameter( "@IdEstadoDeStock", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdEstadoDeStock" ].Value = IdEstadoDeStock;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
			return data;
			
		}

		#endregion
		
		public tlg_MovimientosDeStockNumerosDeSerie()
		{
		}

		public static tlg_MovimientosDeStockNumerosDeSerieDataset GetList()
		{
			tlg_MovimientosDeStockNumerosDeSerieDataset data = new tlg_MovimientosDeStockNumerosDeSerieDataset();

			return ( tlg_MovimientosDeStockNumerosDeSerieDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tlg_MovimientosDeStockNumerosDeSerie" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tlg_MovimientosDeStockNumerosDeSerie_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tlg_MovimientosDeStockNumerosDeSerieDataset GetList( string IdMovimientoDeStock, string NumeroDeSerie )
		{
			tlg_MovimientosDeStockNumerosDeSerieDataset data = new tlg_MovimientosDeStockNumerosDeSerieDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tlg_MovimientosDeStockNumerosDeSerie" );

			SqlCommand cmd = new SqlCommand( "Pr_tlg_MovimientosDeStockNumerosDeSerie_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdMovimientoDeStock", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdMovimientoDeStock" ].Value = IdMovimientoDeStock;
			cmd.Parameters.Add( new SqlParameter( "@NumeroDeSerie", SqlDbType.VarChar ) );
			cmd.Parameters[ "@NumeroDeSerie" ].Value = NumeroDeSerie;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tlg_MovimientosDeStockNumerosDeSerieDataset.tlg_MovimientosDeStockNumerosDeSerieRow NewRow()
		{
			return ( new tlg_MovimientosDeStockNumerosDeSerieDataset() ).tlg_MovimientosDeStockNumerosDeSerie.Newtlg_MovimientosDeStockNumerosDeSerieRow();
		}
	
		public static tlg_MovimientosDeStockNumerosDeSerieDataset.tlg_MovimientosDeStockNumerosDeSerieRow GetByPk( string IdMovimientoDeStock )
		{
			tlg_MovimientosDeStockNumerosDeSerieDataset data = new tlg_MovimientosDeStockNumerosDeSerieDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tlg_MovimientosDeStockNumerosDeSerie_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdMovimientoDeStock", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdMovimientoDeStock" ].Value = IdMovimientoDeStock;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tlg_MovimientosDeStockNumerosDeSerie" );

			adapter.Fill( data );

			if ( data.tlg_MovimientosDeStockNumerosDeSerie.Rows.Count == 1 )
			{
				return ( tlg_MovimientosDeStockNumerosDeSerieDataset.tlg_MovimientosDeStockNumerosDeSerieRow )data.tlg_MovimientosDeStockNumerosDeSerie.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tlg_MovimientosDeStockNumerosDeSerieDataset.tlg_MovimientosDeStockNumerosDeSerieRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tlg_MovimientosDeStockNumerosDeSerieDataset.tlg_MovimientosDeStockNumerosDeSerieDataTable )row.Table ).Addtlg_MovimientosDeStockNumerosDeSerieRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tlg_MovimientosDeStockNumerosDeSerieDataset dataSet )
		{
			Update( dataSet.tlg_MovimientosDeStockNumerosDeSerie );
		}

		public static void Update( tlg_MovimientosDeStockNumerosDeSerieDataset dataSet , string IdTransaction)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			Update( dataSet.Tables["tlg_MovimientosDeStockNumerosDeSerie"] , trx);
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
/*
		public static void Update( DataTable dataTable, SqlTransaction trx )
		{
			Update( ( tlg_MovimientosDeStockNumerosDeSerieDataset.tlg_MovimientosDeStockNumerosDeSerieDataTable )dataTable, trx );
		}
		*/
				

		public static void Update( DataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tlg_MovimientosDeStockNumerosDeSerie", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdMovimientoDeStock", "IdMovimientoDeStock" ),
																											 new System.Data.Common.DataColumnMapping( "NumeroDeSerie", "NumeroDeSerie" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tlg_MovimientosDeStockNumerosDeSerie_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdMovimientoDeStock", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdMovimientoDeStock", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@NumeroDeSerie", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "NumeroDeSerie", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdMovimientoDeStock", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdMovimientoDeStock", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tlg_MovimientosDeStockNumerosDeSerie_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdMovimientoDeStock", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMovimientoDeStock", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tlg_MovimientosDeStockNumerosDeSerie_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMovimientoDeStock", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMovimientoDeStock", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@NumeroDeSerie", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "NumeroDeSerie", DataRowVersion.Current, null ) );
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


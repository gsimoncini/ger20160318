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

	public class tlg_StockNumerosDeSerie : IDisposable
	{
	
		#region Custom Members

		public static DataSet GetNumerosDeSerieParaBaja( string IdProducto, string IdDeposito, string IdSeccion, string IdEstadoDeStock )
		{
			DataSet data = new DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tlg_StockNumerosDeSerie" );

			SqlCommand cmd = new SqlCommand( "Pr_tlg_StockNumerosDeSerie_GetNumerosDeSerieParaBaja", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			cmd.Parameters.Add( new SqlParameter( "@IdDeposito", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdDeposito" ].Value = IdDeposito;
			cmd.Parameters.Add( new SqlParameter( "@IdSeccion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdSeccion" ].Value = IdSeccion;
			cmd.Parameters.Add( new SqlParameter( "@IdEstadoDeStock", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdEstadoDeStock" ].Value = IdEstadoDeStock;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static DataSet ExistsNumeroDeSerie( string IdProducto, string NumeroDeSerie )
		{
			DataSet data = new DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tlg_StockNumerosDeSerie" );

			SqlCommand cmd = new SqlCommand( "Pr_tlg_StockNumerosDeSerie_ExisteNumeroDeSerie", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			cmd.Parameters.Add( new SqlParameter( "@NumeroDeSerie", SqlDbType.VarChar ) );
			cmd.Parameters[ "@NumeroDeSerie" ].Value = NumeroDeSerie;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		
		#endregion
		
		public tlg_StockNumerosDeSerie()
		{
		}

		public static tlg_StockNumerosDeSerieDataset GetList()
		{
			tlg_StockNumerosDeSerieDataset data = new tlg_StockNumerosDeSerieDataset();

			return ( tlg_StockNumerosDeSerieDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tlg_StockNumerosDeSerie" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tlg_StockNumerosDeSerie_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tlg_StockNumerosDeSerieDataset GetList( string IdStockNumerosDeSerie, string IdProducto, string IdDeposito, string IdSeccion, string IdEstadoDeStock, string NumeroDeSerie )
		{
			tlg_StockNumerosDeSerieDataset data = new tlg_StockNumerosDeSerieDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tlg_StockNumerosDeSerie" );

			SqlCommand cmd = new SqlCommand( "Pr_tlg_StockNumerosDeSerie_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdStockNumerosDeSerie", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdStockNumerosDeSerie" ].Value = IdStockNumerosDeSerie;
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			cmd.Parameters.Add( new SqlParameter( "@IdDeposito", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdDeposito" ].Value = IdDeposito;
			cmd.Parameters.Add( new SqlParameter( "@IdSeccion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdSeccion" ].Value = IdSeccion;
			cmd.Parameters.Add( new SqlParameter( "@IdEstadoDeStock", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdEstadoDeStock" ].Value = IdEstadoDeStock;
			cmd.Parameters.Add( new SqlParameter( "@NumeroDeSerie", SqlDbType.VarChar ) );
			cmd.Parameters[ "@NumeroDeSerie" ].Value = NumeroDeSerie;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tlg_StockNumerosDeSerieDataset.tlg_StockNumerosDeSerieRow NewRow()
		{
			return ( new tlg_StockNumerosDeSerieDataset() ).tlg_StockNumerosDeSerie.Newtlg_StockNumerosDeSerieRow();
		}
	
		public static tlg_StockNumerosDeSerieDataset.tlg_StockNumerosDeSerieRow GetByPk( string IdStockNumerosDeSerie )
		{
			tlg_StockNumerosDeSerieDataset data = new tlg_StockNumerosDeSerieDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tlg_StockNumerosDeSerie_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdStockNumerosDeSerie", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdStockNumerosDeSerie" ].Value = IdStockNumerosDeSerie;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tlg_StockNumerosDeSerie" );

			adapter.Fill( data );

			if ( data.tlg_StockNumerosDeSerie.Rows.Count == 1 )
			{
				return ( tlg_StockNumerosDeSerieDataset.tlg_StockNumerosDeSerieRow )data.tlg_StockNumerosDeSerie.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tlg_StockNumerosDeSerieDataset.tlg_StockNumerosDeSerieRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tlg_StockNumerosDeSerieDataset.tlg_StockNumerosDeSerieDataTable )row.Table ).Addtlg_StockNumerosDeSerieRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tlg_StockNumerosDeSerieDataset dataSet )
		{
			Update( dataSet.tlg_StockNumerosDeSerie );
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


		public static void Update(DataSet data, string IdTransaction)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			Update(data.Tables["tlg_StockNumerosDeSerie"], trx);
		}
				

		public static void Update( DataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tlg_StockNumerosDeSerie", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdStockNumerosDeSerie", "IdStockNumerosDeSerie" ),
																											 new System.Data.Common.DataColumnMapping( "IdProducto", "IdProducto" ),
																											 new System.Data.Common.DataColumnMapping( "IdDeposito", "IdDeposito" ),
																											 new System.Data.Common.DataColumnMapping( "IdSeccion", "IdSeccion" ),
																											 new System.Data.Common.DataColumnMapping( "IdEstadoDeStock", "IdEstadoDeStock" ),
																											 new System.Data.Common.DataColumnMapping( "NumeroDeSerie", "NumeroDeSerie" ),
																											 new System.Data.Common.DataColumnMapping( "Observaciones", "Observaciones" ),
																											 new System.Data.Common.DataColumnMapping( "Aux1", "Aux1" ),
																											 new System.Data.Common.DataColumnMapping( "Aux2", "Aux2" ),
																											 new System.Data.Common.DataColumnMapping( "Aux3", "Aux3" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tlg_StockNumerosDeSerie_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdStockNumerosDeSerie", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdStockNumerosDeSerie", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdDeposito", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdDeposito", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSeccion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSeccion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEstadoDeStock", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEstadoDeStock", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@NumeroDeSerie", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "NumeroDeSerie", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Observaciones", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Observaciones", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Aux1", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Aux1", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Aux2", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Aux2", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Aux3", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Aux3", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdStockNumerosDeSerie", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdStockNumerosDeSerie", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tlg_StockNumerosDeSerie_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdStockNumerosDeSerie", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdStockNumerosDeSerie", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tlg_StockNumerosDeSerie_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdStockNumerosDeSerie", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdStockNumerosDeSerie", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdDeposito", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdDeposito", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSeccion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSeccion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEstadoDeStock", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEstadoDeStock", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@NumeroDeSerie", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "NumeroDeSerie", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Observaciones", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Observaciones", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Aux1", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Aux1", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Aux2", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Aux2", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Aux3", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Aux3", DataRowVersion.Current, null ) );
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



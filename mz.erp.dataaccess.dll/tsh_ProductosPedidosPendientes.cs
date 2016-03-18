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

	public class tsh_ProductosPedidosPendientes : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsh_ProductosPedidosPendientes()
		{
		}

		public static tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesRow GetByIdComprobanteIdProductoOrdinal(string IdComprobante, string IdProducto, long Ordinal, bool Cerrado)
		{
			tsh_ProductosPedidosPendientesDataset data = new tsh_ProductosPedidosPendientesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_ProductosPedidosPendientes" );

			SqlCommand cmd = new SqlCommand( "Pr_tsh_ProductosPedidosPendientes_GetByIdComprobanteIdProductoOrdinal", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			if (IdComprobante.Equals(String.Empty))
				cmd.Parameters[ "@IdComprobante" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
			
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			if (IdProducto.Equals(String.Empty))
				cmd.Parameters[ "@IdProducto" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			
			cmd.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt ) );
			if ( Ordinal.Equals(long.MinValue) )
				cmd.Parameters[ "@Ordinal" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Ordinal" ].Value = Ordinal;

			cmd.Parameters.Add( new SqlParameter( "@Cerrado", SqlDbType.Bit ) );			
			cmd.Parameters[ "@Cerrado" ].Value = Cerrado;

			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			if ( data.tsh_ProductosPedidosPendientes.Rows.Count == 1 )
			{
				return ( tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesRow )data.tsh_ProductosPedidosPendientes.Rows[ 0 ];
			}
			
			return null;
			
		}

		public static tsh_ProductosPedidosPendientesDataset GetList()
		{
			tsh_ProductosPedidosPendientesDataset data = new tsh_ProductosPedidosPendientesDataset();

			return ( tsh_ProductosPedidosPendientesDataset )GetList( data );
		}
		
		public static DataSet GetList(string codigo)
		{
			tsh_ProductosPedidosPendientesDataset data = new tsh_ProductosPedidosPendientesDataset();

			return ( DataSet )GetExList( DateTime.MinValue, false, "", codigo, "", DateTime.MinValue, decimal.MinValue, long.MinValue );
		}

		public static DataSet GetExList( DateTime FechaCierre, bool Cerrado, string IdComprobante, string IdProducto, string IdProveedor, DateTime FechaRecepcion, decimal Cantidad, long Ordinal )
		{
			DataSet data = new DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_ProductosPedidosPendientes" );

			SqlCommand cmd = new SqlCommand( "Pr_tsh_ProductosPedidosPendientesEx_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			/*cmd.Parameters.Add( new SqlParameter( "@FechaCierre", SqlDbType.DateTime ) );
			if(FechaCierre.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaCierre" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaCierre" ].Value = FechaCierre;

			cmd.Parameters.Add( new SqlParameter( "@Cerrado", SqlDbType.Bit ) );			
			cmd.Parameters[ "@Cerrado" ].Value = Cerrado;

			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			if (IdComprobante.Equals(String.Empty))
				cmd.Parameters[ "@IdComprobante" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
			*/
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			if (IdProducto.Equals(String.Empty))
				cmd.Parameters[ "@IdProducto" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			
			/*cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
			if (IdProveedor.Equals(String.Empty))
				cmd.Parameters[ "@IdProveedor" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdProveedor" ].Value = IdProveedor;
			
			cmd.Parameters.Add( new SqlParameter( "@FechaRecepcion", SqlDbType.DateTime ) );
			if(FechaRecepcion.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaRecepcion" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaRecepcion" ].Value = FechaRecepcion;
			
			cmd.Parameters.Add( new SqlParameter( "@Cantidad", SqlDbType.Decimal ) );
			if(Cantidad.Equals(decimal.MinValue))
				cmd.Parameters[ "@Cantidad" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Cantidad" ].Value = Cantidad;
			
			cmd.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt ) );
			if ( Ordinal.Equals(long.MinValue) )
				cmd.Parameters[ "@Ordinal" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Ordinal" ].Value = Ordinal;
			*/

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}


		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_ProductosPedidosPendientes" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsh_ProductosPedidosPendientes_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		
		public static tsh_ProductosPedidosPendientesDataset GetList( DateTime FechaCierre, bool Cerrado, string IdComprobante, string IdProducto, string IdProveedor, DateTime FechaRecepcion, decimal Cantidad, long Ordinal )
		{
			tsh_ProductosPedidosPendientesDataset data = new tsh_ProductosPedidosPendientesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_ProductosPedidosPendientes" );

			SqlCommand cmd = new SqlCommand( "Pr_tsh_ProductosPedidosPendientes_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@FechaCierre", SqlDbType.DateTime ) );
			if(FechaCierre.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaCierre" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaCierre" ].Value = FechaCierre;

			cmd.Parameters.Add( new SqlParameter( "@Cerrado", SqlDbType.Bit ) );			
			cmd.Parameters[ "@Cerrado" ].Value = Cerrado;

			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			if (IdComprobante.Equals(String.Empty))
				cmd.Parameters[ "@IdComprobante" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
			
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			if (IdProducto.Equals(String.Empty))
				cmd.Parameters[ "@IdProducto" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			
			cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
			if (IdProveedor.Equals(String.Empty))
				cmd.Parameters[ "@IdProveedor" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdProveedor" ].Value = IdProveedor;
			
			cmd.Parameters.Add( new SqlParameter( "@FechaRecepcion", SqlDbType.DateTime ) );
			if(FechaRecepcion.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaRecepcion" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaRecepcion" ].Value = FechaRecepcion;
			
			cmd.Parameters.Add( new SqlParameter( "@Cantidad", SqlDbType.Decimal ) );
			if(Cantidad.Equals(decimal.MinValue))
				cmd.Parameters[ "@Cantidad" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Cantidad" ].Value = Cantidad;
			
			cmd.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt ) );
			if ( Ordinal.Equals(long.MinValue) )
				cmd.Parameters[ "@Ordinal" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Ordinal" ].Value = Ordinal;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static DataSet GetListGroup( bool Cerrado, string IdProducto, string IdComprobante )
		{
			DataSet data = new DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_ProductosPedidosPendientes" );

			SqlCommand cmd = new SqlCommand( "Pr_tsh_ProductosPedidosPendientes_SearchAgrupado", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@Cerrado", SqlDbType.Bit ) );			
			cmd.Parameters[ "@Cerrado" ].Value = Cerrado;
			
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			if (IdProducto.Equals(String.Empty))
				cmd.Parameters[ "@IdProducto" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdProducto" ].Value = IdProducto;

			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			if (IdComprobante.Equals(String.Empty))
				cmd.Parameters[ "@IdComprobante" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
			
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesRow NewRow()
		{
			return ( new tsh_ProductosPedidosPendientesDataset() ).tsh_ProductosPedidosPendientes.Newtsh_ProductosPedidosPendientesRow();
		}
	
		public static tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesRow GetByPk( string IdComprobante, string IdProducto, DateTime FechaRecepcion, long Ordinal )
		{
			tsh_ProductosPedidosPendientesDataset data = new tsh_ProductosPedidosPendientesDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsh_ProductosPedidosPendientes_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
			
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			
			cmd.Parameters.Add( new SqlParameter( "@FechaRecepcion", SqlDbType.DateTime ) );
			cmd.Parameters[ "@FechaRecepcion" ].Value = FechaRecepcion;
			
			cmd.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt ) );
			cmd.Parameters[ "@Ordinal" ].Value = Ordinal;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsh_ProductosPedidosPendientes" );

			adapter.Fill( data );

			if ( data.tsh_ProductosPedidosPendientes.Rows.Count == 1 )
			{
				return ( tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesRow )data.tsh_ProductosPedidosPendientes.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesDataTable )row.Table ).Addtsh_ProductosPedidosPendientesRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tsh_ProductosPedidosPendientesDataset dataSet )
		{
			Update( dataSet.tsh_ProductosPedidosPendientes );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesDataTable )dataTable, trx );
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


		public static void Update( DataTable dataTable, string  IdTransaction )
		{
			
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			Update( dataTable, trx );
		}
				

		public static void Update( DataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsh_ProductosPedidosPendientes", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCierre", "FechaCierre" ),
																											 new System.Data.Common.DataColumnMapping( "Cerrado", "Cerrado" ),
																											 new System.Data.Common.DataColumnMapping( "IdComprobante", "IdComprobante" ),
																											 new System.Data.Common.DataColumnMapping( "IdProducto", "IdProducto" ),
																											 new System.Data.Common.DataColumnMapping( "IdProveedor", "IdProveedor" ),
																											 new System.Data.Common.DataColumnMapping( "FechaRecepcion", "FechaRecepcion" ),
																											 new System.Data.Common.DataColumnMapping( "Cantidad", "Cantidad" ),
																											 new System.Data.Common.DataColumnMapping( "Ordinal", "Ordinal" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsh_ProductosPedidosPendientes_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaCierre", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaCierre", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Cerrado", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Cerrado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdComprobante", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProveedor", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaRecepcion", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaRecepcion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Cantidad", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Cantidad", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Ordinal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdComprobante", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProducto", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldFechaRecepcion", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FechaRecepcion", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldOrdinal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ordinal", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsh_ProductosPedidosPendientes_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobante", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@FechaRecepcion", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaRecepcion", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Ordinal", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsh_ProductosPedidosPendientes_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCierre", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCierre", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Cerrado", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Cerrado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdComprobante", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProveedor", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaRecepcion", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaRecepcion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Cantidad", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Cantidad", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Ordinal", DataRowVersion.Current, null ) );

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



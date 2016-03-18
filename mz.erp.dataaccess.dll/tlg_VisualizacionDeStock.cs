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

	public class tlg_VisualizacionDeStock : IDisposable
	{
	
		#region Custom Members

		public static decimal CalculateStock(string IdProducto, string IdVisualizacionDeStock, long IdSucursal, long IdEmpresa)
		{
			SqlCommand cmd = new SqlCommand( "Pr_tlg_VisualizacionDeStock_CalculateStock", dbhelper.Connection.GetConnection() );
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			cmd.Parameters.Add( new SqlParameter( "@IdVisualizacionDeStock", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdVisualizacionDeStock" ].Value = IdVisualizacionDeStock;
			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			if ( IdSucursal == long.MinValue )
			{cmd.Parameters[ "@IdSucursal" ].Value = System.DBNull.Value;}
			else
			{cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;}
			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );       
			if ( IdEmpresa == long.MinValue )
			{cmd.Parameters[ "@IdEmpresa" ].Value = System.DBNull.Value;}
			else
			{cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;}
			cmd.CommandType = CommandType.StoredProcedure;
			if(!cmd.Connection.State.Equals(System.Data.ConnectionState.Open))
				cmd.Connection.Open();
			decimal valor = Convert.ToDecimal(cmd.ExecuteScalar());
			return valor;
			
		}
		
		
		#endregion
		
		public tlg_VisualizacionDeStock()
		{
		}

		public static tlg_VisualizacionDeStockDataset GetList()
		{
			tlg_VisualizacionDeStockDataset data = new tlg_VisualizacionDeStockDataset();

			return ( tlg_VisualizacionDeStockDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tlg_VisualizacionDeStock" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tlg_VisualizacionDeStock_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tlg_VisualizacionDeStockDataset GetList( string IdVisualizacionDeStock, string Descripcion)
		{
			tlg_VisualizacionDeStockDataset data = new tlg_VisualizacionDeStockDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tlg_VisualizacionDeStock" );

			SqlCommand cmd = new SqlCommand( "Pr_tlg_VisualizacionDeStock_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdVisualizacionDeStock", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdVisualizacionDeStock" ].Value = IdVisualizacionDeStock;
			cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Descripcion" ].Value = Descripcion;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tlg_VisualizacionDeStockDataset.tlg_VisualizacionDeStockRow NewRow()
		{
			return ( new tlg_VisualizacionDeStockDataset() ).tlg_VisualizacionDeStock.Newtlg_VisualizacionDeStockRow();
		}
	
		public static tlg_VisualizacionDeStockDataset.tlg_VisualizacionDeStockRow GetByPk( string IdVisualizacionDeStock )
		{
			tlg_VisualizacionDeStockDataset data = new tlg_VisualizacionDeStockDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tlg_VisualizacionDeStock_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdVisualizacionDeStock", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdVisualizacionDeStock" ].Value = IdVisualizacionDeStock;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tlg_VisualizacionDeStock" );

			adapter.Fill( data );

			if ( data.tlg_VisualizacionDeStock.Rows.Count == 1 )
			{
				return ( tlg_VisualizacionDeStockDataset.tlg_VisualizacionDeStockRow )data.tlg_VisualizacionDeStock.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tlg_VisualizacionDeStockDataset.tlg_VisualizacionDeStockRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tlg_VisualizacionDeStockDataset.tlg_VisualizacionDeStockDataTable )row.Table ).Addtlg_VisualizacionDeStockRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tlg_VisualizacionDeStockDataset dataSet )
		{
			Update( dataSet.tlg_VisualizacionDeStock );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tlg_VisualizacionDeStockDataset.tlg_VisualizacionDeStockDataTable )dataTable, trx );
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
			Update( ( tlg_VisualizacionDeStockDataset.tlg_VisualizacionDeStockDataTable )dataTable, trx );
		}*/
				
		public static void Update( DataTable dataTable, SqlTransaction trx )
		//public static void Update( tlg_VisualizacionDeStockDataset.tlg_VisualizacionDeStockDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tlg_VisualizacionDeStock", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdVisualizacionDeStock", "IdVisualizacionDeStock" ),
																											 new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "OldIdVisualizacionDeStock", "OldIdVisualizacionDeStock" ),
																											 new System.Data.Common.DataColumnMapping( "Activo", "Activo" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tlg_VisualizacionDeStock_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdVisualizacionDeStock", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdVisualizacionDeStock", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			//sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdVisualizacionDeStock", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "OldIdVisualizacionDeStock", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdVisualizacionDeStock", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdVisualizacionDeStock", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tlg_VisualizacionDeStock_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdVisualizacionDeStock", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdVisualizacionDeStock", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tlg_VisualizacionDeStock_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdVisualizacionDeStock", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdVisualizacionDeStock", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@OldIdVisualizacionDeStock", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "OldIdVisualizacionDeStock", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );

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


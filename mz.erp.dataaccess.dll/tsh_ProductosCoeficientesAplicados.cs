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

	public class tsh_ProductosCoeficientesAplicados : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsh_ProductosCoeficientesAplicados()
		{
		}

		public static tsh_ProductosCoeficientesAplicadosDataset GetList()
		{
			tsh_ProductosCoeficientesAplicadosDataset data = new tsh_ProductosCoeficientesAplicadosDataset();

			return ( tsh_ProductosCoeficientesAplicadosDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_ProductosCoeficientesAplicados" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsh_ProductosCoeficientesAplicados_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsh_ProductosCoeficientesAplicadosDataset GetList( string IdProducto, string IdCoeficienteCostoIndirecto1, string IdCoeficienteCostoIndirecto2, string IdCoeficienteCostoIndirecto3, string IdCoeficienteCostoIndirecto4, string IdCoeficienteCostoIndirecto5, string IdCoeficienteCostoIndirecto6, string IdCoeficienteCostoIndirecto7, string IdCoeficienteCostoIndirecto8, string IdCoeficienteCostoIndirecto9, string IdCoeficienteCostoIndirecto10 )
		{
			tsh_ProductosCoeficientesAplicadosDataset data = new tsh_ProductosCoeficientesAplicadosDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_ProductosCoeficientesAplicados" );

			SqlCommand cmd = new SqlCommand( "Pr_tsh_ProductosCoeficientesAplicados_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			cmd.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto1", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCoeficienteCostoIndirecto1" ].Value = IdCoeficienteCostoIndirecto1;
			cmd.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto2", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCoeficienteCostoIndirecto2" ].Value = IdCoeficienteCostoIndirecto2;
			cmd.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto3", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCoeficienteCostoIndirecto3" ].Value = IdCoeficienteCostoIndirecto3;
			cmd.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto4", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCoeficienteCostoIndirecto4" ].Value = IdCoeficienteCostoIndirecto4;
			cmd.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto5", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCoeficienteCostoIndirecto5" ].Value = IdCoeficienteCostoIndirecto5;
			cmd.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto6", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCoeficienteCostoIndirecto6" ].Value = IdCoeficienteCostoIndirecto6;
			cmd.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto7", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCoeficienteCostoIndirecto7" ].Value = IdCoeficienteCostoIndirecto7;
			cmd.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto8", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCoeficienteCostoIndirecto8" ].Value = IdCoeficienteCostoIndirecto8;
			cmd.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto9", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCoeficienteCostoIndirecto9" ].Value = IdCoeficienteCostoIndirecto9;
			cmd.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto10", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCoeficienteCostoIndirecto10" ].Value = IdCoeficienteCostoIndirecto10;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosRow NewRow()
		{
			return ( new tsh_ProductosCoeficientesAplicadosDataset() ).tsh_ProductosCoeficientesAplicados.Newtsh_ProductosCoeficientesAplicadosRow();
		}
	
		public static tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosRow GetByPk( string IdProducto )
		{
			tsh_ProductosCoeficientesAplicadosDataset data = new tsh_ProductosCoeficientesAplicadosDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsh_ProductosCoeficientesAplicados_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsh_ProductosCoeficientesAplicados" );

			adapter.Fill( data );

			if ( data.tsh_ProductosCoeficientesAplicados.Rows.Count == 1 )
			{
				return ( tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosRow )data.tsh_ProductosCoeficientesAplicados.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosDataTable )row.Table ).Addtsh_ProductosCoeficientesAplicadosRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tsh_ProductosCoeficientesAplicadosDataset dataSet )
		{
			Update( dataSet.tsh_ProductosCoeficientesAplicados );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosDataTable )dataTable, trx );
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
			Update( ( tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosDataTable )dataTable, trx );
		}*/
				

		public static void Update( DataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsh_ProductosCoeficientesAplicados", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
																											 new System.Data.Common.DataColumnMapping( "IdProducto", "IdProducto" ),
																											 new System.Data.Common.DataColumnMapping( "IdCoeficienteCostoIndirecto1", "IdCoeficienteCostoIndirecto1" ),
																											 new System.Data.Common.DataColumnMapping( "Valor1", "Valor1" ),
																											 new System.Data.Common.DataColumnMapping( "IdCoeficienteCostoIndirecto2", "IdCoeficienteCostoIndirecto2" ),
																											 new System.Data.Common.DataColumnMapping( "Valor2", "Valor2" ),
																											 new System.Data.Common.DataColumnMapping( "IdCoeficienteCostoIndirecto3", "IdCoeficienteCostoIndirecto3" ),
																											 new System.Data.Common.DataColumnMapping( "Valor3", "Valor3" ),
																											 new System.Data.Common.DataColumnMapping( "IdCoeficienteCostoIndirecto4", "IdCoeficienteCostoIndirecto4" ),
																											 new System.Data.Common.DataColumnMapping( "Valor4", "Valor4" ),
																											 new System.Data.Common.DataColumnMapping( "IdCoeficienteCostoIndirecto5", "IdCoeficienteCostoIndirecto5" ),
																											 new System.Data.Common.DataColumnMapping( "Valor5", "Valor5" ),
																											 new System.Data.Common.DataColumnMapping( "IdCoeficienteCostoIndirecto6", "IdCoeficienteCostoIndirecto6" ),
																											 new System.Data.Common.DataColumnMapping( "Valor6", "Valor6" ),
																											 new System.Data.Common.DataColumnMapping( "IdCoeficienteCostoIndirecto7", "IdCoeficienteCostoIndirecto7" ),
																											 new System.Data.Common.DataColumnMapping( "Valor7", "Valor7" ),
																											 new System.Data.Common.DataColumnMapping( "IdCoeficienteCostoIndirecto8", "IdCoeficienteCostoIndirecto8" ),
																											 new System.Data.Common.DataColumnMapping( "Valor8", "Valor8" ),
																											 new System.Data.Common.DataColumnMapping( "IdCoeficienteCostoIndirecto9", "IdCoeficienteCostoIndirecto9" ),
																											 new System.Data.Common.DataColumnMapping( "Valor9", "Valor9" ),
																											 new System.Data.Common.DataColumnMapping( "IdCoeficienteCostoIndirecto10", "IdCoeficienteCostoIndirecto10" ),
																											 new System.Data.Common.DataColumnMapping( "Valor10", "Valor10" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsh_ProductosCoeficientesAplicados_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto1", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCoeficienteCostoIndirecto1", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Valor1", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Valor1", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto2", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCoeficienteCostoIndirecto2", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Valor2", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Valor2", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto3", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCoeficienteCostoIndirecto3", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Valor3", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Valor3", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto4", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCoeficienteCostoIndirecto4", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Valor4", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Valor4", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto5", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCoeficienteCostoIndirecto5", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Valor5", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Valor5", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto6", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCoeficienteCostoIndirecto6", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Valor6", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Valor6", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto7", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCoeficienteCostoIndirecto7", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Valor7", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Valor7", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto8", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCoeficienteCostoIndirecto8", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Valor8", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Valor8", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto9", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCoeficienteCostoIndirecto9", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Valor9", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Valor9", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto10", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCoeficienteCostoIndirecto10", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Valor10", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Valor10", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProducto", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsh_ProductosCoeficientesAplicados_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsh_ProductosCoeficientesAplicados_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto1", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCoeficienteCostoIndirecto1", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Valor1", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Valor1", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto2", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCoeficienteCostoIndirecto2", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Valor2", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Valor2", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto3", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCoeficienteCostoIndirecto3", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Valor3", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Valor3", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto4", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCoeficienteCostoIndirecto4", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Valor4", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Valor4", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto5", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCoeficienteCostoIndirecto5", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Valor5", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Valor5", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto6", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCoeficienteCostoIndirecto6", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Valor6", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Valor6", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto7", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCoeficienteCostoIndirecto7", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Valor7", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Valor7", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto8", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCoeficienteCostoIndirecto8", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Valor8", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Valor8", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto9", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCoeficienteCostoIndirecto9", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Valor9", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Valor9", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto10", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCoeficienteCostoIndirecto10", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Valor10", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Valor10", DataRowVersion.Current, null ) );

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



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

	public class tsy_ImpuestosProductos : IDisposable
	{
	
		#region Custom Members

		public static tsy_ImpuestosProductosDataset GetListByIdProducto( string IdProducto)
		{
			tsy_ImpuestosProductosDataset data = new tsy_ImpuestosProductosDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsy_ImpuestosProductos" );

			SqlCommand cmd = new SqlCommand( "Pr_tsy_ImpuestosProductos_GetListByIdProducto", dbhelper.Connection.GetConnection() );

			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );			
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;			

			cmd.CommandType = CommandType.StoredProcedure;
			adapter.SelectCommand = cmd;
			
			adapter.Fill( data );
			return data;
		}

		
		#endregion
		
		public tsy_ImpuestosProductos()
		{
		}

		public static tsy_ImpuestosProductosDataset GetList()
		{
			tsy_ImpuestosProductosDataset data = new tsy_ImpuestosProductosDataset();

			return ( tsy_ImpuestosProductosDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsy_ImpuestosProductos" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsy_ImpuestosProductos_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsy_ImpuestosProductosDataset GetList( string IdProducto, string IdImpuesto, long IdEmpresa, long IdSucursal)
		{
			tsy_ImpuestosProductosDataset data = new tsy_ImpuestosProductosDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsy_ImpuestosProductos" );

			SqlCommand cmd = new SqlCommand( "Pr_tsy_ImpuestosProductos_Search", dbhelper.Connection.GetConnection() );

			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );			
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;			

			cmd.Parameters.Add( new SqlParameter( "@IdImpuesto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdImpuesto" ].Value = IdImpuesto;						     
			
			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
			if (IdEmpresa != long.MinValue) 
			{cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;}
			else
			{cmd.Parameters[ "@IdEmpresa" ].Value = null;}
			

			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );

			if (IdSucursal != long.MinValue) 
			{cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;}
			else
			{cmd.Parameters[ "@IdSucursal" ].Value = null;}
						
			cmd.CommandType = CommandType.StoredProcedure;
			adapter.SelectCommand = cmd;
			
			try 
			{
				adapter.Fill( data );
			}
			catch (Exception e) 
			{
				Console.WriteLine(e.Message.ToString());
				//Console.WriteLine("La clave es correcta");
			}
         
			return data;
		}

		public static tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow NewRow()
		{
			return ( new tsy_ImpuestosProductosDataset() ).tsy_ImpuestosProductos.Newtsy_ImpuestosProductosRow();
		}
	
		public static tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow GetByPk( string IdProducto, string IdImpuesto )
		{
			tsy_ImpuestosProductosDataset data = new tsy_ImpuestosProductosDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsy_ImpuestosProductos_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			
			cmd.Parameters.Add( new SqlParameter( "@IdImpuesto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdImpuesto" ].Value = IdImpuesto;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsy_ImpuestosProductos" );

			adapter.Fill( data );

			if ( data.tsy_ImpuestosProductos.Rows.Count == 1 )
			{
				return ( tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow )data.tsy_ImpuestosProductos.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosDataTable )row.Table ).Addtsy_ImpuestosProductosRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tsy_ImpuestosProductosDataset dataSet )
		{
			Update( dataSet.tsy_ImpuestosProductos );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update(dataTable, trx );
				trx.Commit();
			}
			catch (Exception e)
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
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsy_ImpuestosProductos", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdProducto", "IdProducto" ),
																											 new System.Data.Common.DataColumnMapping( "IdImpuesto", "IdImpuesto" ),
																											 new System.Data.Common.DataColumnMapping( "MetodoDeAsignacion", "MetodoDeAsignacion" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsy_ImpuestosProductos_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdImpuesto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdImpuesto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@MetodoDeAsignacion", SqlDbType.Char, 1, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "MetodoDeAsignacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProducto", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdImpuesto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdImpuesto", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsy_ImpuestosProductos_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdImpuesto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdImpuesto", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsy_ImpuestosProductos_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdImpuesto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdImpuesto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@MetodoDeAsignacion", SqlDbType.Char, 1, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "MetodoDeAsignacion", DataRowVersion.Current, null ) );
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


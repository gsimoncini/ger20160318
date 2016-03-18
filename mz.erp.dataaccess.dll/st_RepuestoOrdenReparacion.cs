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

	public class st_RepuestoOrdenReparacion : IDisposable
	{
	
		#region Custom Members

		public static st_RepuestoOrdenReparacionDataset GetListByIdInstanciaOrdenReparacion( long IdInstanciaOrdenReparacion)
		{
			st_RepuestoOrdenReparacionDataset data = new st_RepuestoOrdenReparacionDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "st_RepuestoOrdenReparacion" );

			SqlCommand cmd = new SqlCommand( "Pr_st_RepuestoOrdenReparacion_GetListByInstanciaOrdenReparacion", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			
			cmd.Parameters.Add( new SqlParameter( "@IdInstanciaOrdenReparacion", SqlDbType.BigInt ) );
			if ( IdInstanciaOrdenReparacion == long.MinValue )
			{
				cmd.Parameters[ "@IdInstanciaOrdenReparacion" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdInstanciaOrdenReparacion" ].Value = IdInstanciaOrdenReparacion;
			}
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

	
		
		#endregion
		
		public st_RepuestoOrdenReparacion()
		{
		}

		public static st_RepuestoOrdenReparacionDataset GetList()
		{
			st_RepuestoOrdenReparacionDataset data = new st_RepuestoOrdenReparacionDataset();

			return ( st_RepuestoOrdenReparacionDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "st_RepuestoOrdenReparacion" );
			
			SqlCommand cmd = new SqlCommand( "Pr_st_RepuestoOrdenReparacion_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static st_RepuestoOrdenReparacionDataset GetList( long IdRepuestoOrdenReparacion, long IdInstanciaOrdenReparacion, string IdProducto)
		{
			st_RepuestoOrdenReparacionDataset data = new st_RepuestoOrdenReparacionDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "st_RepuestoOrdenReparacion" );

			SqlCommand cmd = new SqlCommand( "Pr_st_RepuestoOrdenReparacion_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdRepuestoOrdenReparacion", SqlDbType.BigInt ) );
			if ( IdRepuestoOrdenReparacion == long.MinValue )
			{
				cmd.Parameters[ "@IdRepuestoOrdenReparacion" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdRepuestoOrdenReparacion" ].Value = IdRepuestoOrdenReparacion;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdInstanciaOrdenReparacion", SqlDbType.BigInt ) );
			if ( IdInstanciaOrdenReparacion == long.MinValue )
			{
				cmd.Parameters[ "@IdInstanciaOrdenReparacion" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdInstanciaOrdenReparacion" ].Value = IdInstanciaOrdenReparacion;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static st_RepuestoOrdenReparacionDataset.st_RepuestoOrdenReparacionRow NewRow()
		{
			return ( new st_RepuestoOrdenReparacionDataset() ).st_RepuestoOrdenReparacion.Newst_RepuestoOrdenReparacionRow();
		}
	
		public static st_RepuestoOrdenReparacionDataset.st_RepuestoOrdenReparacionRow GetByPk( long IdRepuestoOrdenReparacion )
		{
			st_RepuestoOrdenReparacionDataset data = new st_RepuestoOrdenReparacionDataset();

			SqlCommand cmd = new SqlCommand( "Pr_st_RepuestoOrdenReparacion_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdRepuestoOrdenReparacion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdRepuestoOrdenReparacion" ].Value = IdRepuestoOrdenReparacion;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "st_RepuestoOrdenReparacion" );

			adapter.Fill( data );

			if ( data.st_RepuestoOrdenReparacion.Rows.Count == 1 )
			{
				return ( st_RepuestoOrdenReparacionDataset.st_RepuestoOrdenReparacionRow )data.st_RepuestoOrdenReparacion.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( st_RepuestoOrdenReparacionDataset.st_RepuestoOrdenReparacionRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( st_RepuestoOrdenReparacionDataset.st_RepuestoOrdenReparacionDataTable )row.Table ).Addst_RepuestoOrdenReparacionRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( st_RepuestoOrdenReparacionDataset dataSet )
		{
			Update( dataSet.st_RepuestoOrdenReparacion );
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

		public static void Update(DataTable table, string IdTransaction)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			Update(table, trx);
		}


				

		public static void Update( DataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "st_RepuestoOrdenReparacion", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdRepuestoOrdenReparacion", "IdRepuestoOrdenReparacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdInstanciaOrdenReparacion", "IdInstanciaOrdenReparacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdProducto", "IdProducto" ),
																											 new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" ),
																											 new System.Data.Common.DataColumnMapping( "Cantidad", "Cantidad" ),
																											 new System.Data.Common.DataColumnMapping( "Precio", "Precio" ),
																											 new System.Data.Common.DataColumnMapping( "PrecioSugerido", "PrecioSugerido" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "entregado", "entregado" ),
																											 new System.Data.Common.DataColumnMapping( "Reservado", "Reservado" )		
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_st_RepuestoOrdenReparacion_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdRepuestoOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdRepuestoOrdenReparacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdInstanciaOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdInstanciaOrdenReparacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Cantidad", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Cantidad", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Precio", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Precio", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PrecioSugerido", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioSugerido", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@entregado", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "entregado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Reservado", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Reservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdRepuestoOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdRepuestoOrdenReparacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_st_RepuestoOrdenReparacion_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdRepuestoOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdRepuestoOrdenReparacion", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_st_RepuestoOrdenReparacion_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdInstanciaOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdInstanciaOrdenReparacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Cantidad", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Cantidad", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Precio", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Precio", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PrecioSugerido", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "PrecioSugerido", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@entregado", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "entregado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdRepuestoOrdenReparacion", SqlDbType.BigInt, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdRepuestoOrdenReparacion", DataRowVersion.Current, null ) );

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


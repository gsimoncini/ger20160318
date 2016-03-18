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

	public class tsa_CondicionesDeVentas : IDisposable
	{
	
		#region Custom Members

		public static tsa_CondicionesDeVentasDataset GetCondicionesDeVentaByIdTDCompTesoreria(string IdTDCompTesoreria)
		{
			tsa_CondicionesDeVentasDataset data = new tsa_CondicionesDeVentasDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_CondicionesDeVentas" );

			SqlCommand cmd = new SqlCommand( "Pr_tsa_CondicionesDeVentas_GetListByIdTDCompTesoreria", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTDCompTesoreria" ].Value = IdTDCompTesoreria;
			
			adapter.SelectCommand = cmd;
			adapter.Fill( data );         
			return data;
		}
		



		public static DataTable GetCondicionesDeVentaBy(string IdCuenta,string IdTipoDeComprobante)
		{
			DataSet data = new DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_CondicionesDeVentas" );

			SqlCommand cmd = new SqlCommand( "Pr_tsa_CondicionesDeVenta_GetListBy", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar ) );
			if(IdTipoDeComprobante == null || IdTipoDeComprobante.Equals(string.Empty))
				cmd.Parameters[ "@IdTipoDeComprobante" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdTipoDeComprobante" ].Value = IdTipoDeComprobante;
			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			if(IdCuenta == null || IdCuenta.Equals(string.Empty))
				cmd.Parameters[ "@IdCuenta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;

			adapter.SelectCommand = cmd;
			adapter.Fill( data );         
			return data.Tables[0];
		}



		public static DataSet GetList( string IdCuenta, string IdCondicionDeVenta )
		{
			DataSet data = new DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_CondicionesDeVentas" );

			SqlCommand cmd = new SqlCommand( "Pr_tsa_CondicionesDeVentas_SearchEx", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdCondicionDeVenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCondicionDeVenta" ].Value = IdCondicionDeVenta;
			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;

			adapter.SelectCommand = cmd;
			adapter.Fill( data );         
			return data;
		}

		#endregion
		
		public tsa_CondicionesDeVentas()
		{
		}

		public static tsa_CondicionesDeVentasDataset GetList()
		{
			tsa_CondicionesDeVentasDataset data = new tsa_CondicionesDeVentasDataset();

			return ( tsa_CondicionesDeVentasDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_CondicionesDeVentas" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsa_CondicionesDeVentas_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsa_CondicionesDeVentasDataset GetList( string IdCondicionDeVenta, string Descripcion, bool Activo )
		{
			tsa_CondicionesDeVentasDataset data = new tsa_CondicionesDeVentasDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_CondicionesDeVentas" );

			SqlCommand cmd = new SqlCommand( "Pr_tsa_CondicionesDeVentas_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdCondicionDeVenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCondicionDeVenta" ].Value = IdCondicionDeVenta;
			cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Descripcion" ].Value = Descripcion;
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasRow NewRow()
		{
			return ( new tsa_CondicionesDeVentasDataset() ).tsa_CondicionesDeVentas.Newtsa_CondicionesDeVentasRow();
		}
	
		public static tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasRow GetByPk( string IdCondicionDeVenta )
		{
			tsa_CondicionesDeVentasDataset data = new tsa_CondicionesDeVentasDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsa_CondicionesDeVentas_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdCondicionDeVenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCondicionDeVenta" ].Value = IdCondicionDeVenta;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsa_CondicionesDeVentas" );

			adapter.Fill( data );

			if ( data.tsa_CondicionesDeVentas.Rows.Count == 1 )
			{
				return ( tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasRow )data.tsa_CondicionesDeVentas.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasDataTable )row.Table ).Addtsa_CondicionesDeVentasRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tsa_CondicionesDeVentasDataset dataSet )
		{
			Update( dataSet.tsa_CondicionesDeVentas );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				//Update( ( tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasDataTable )dataTable, trx );
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
				//	Update( ( tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasDataTable )dataTable, trx );
					Update( dataTable, trx );
				}
		*/				
		
		public static void Update(System.Data.DataTable dataTable,string IdTransaction)
		{
				SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
				Update(dataTable,trx);			
		}

	//public static void Update( tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasDataTable dataTable, SqlTransaction trx )
	public static void Update( System.Data.DataTable dataTable, SqlTransaction trx )
{
	SqlDataAdapter adapter = new SqlDataAdapter();
			
	adapter.TableMappings.AddRange(
	new System.Data.Common.DataTableMapping[] 
{
	new System.Data.Common.DataTableMapping( "Table", "tsa_CondicionesDeVentas", 
	new System.Data.Common.DataColumnMapping[] 
{
	new System.Data.Common.DataColumnMapping( "IdCondicionDeVenta", "IdCondicionDeVenta" ),
	new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" ),
	new System.Data.Common.DataColumnMapping( "Activo", "Activo" ),
	new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
	new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
	new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
	new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
	new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
	new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
	new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
	new System.Data.Common.DataColumnMapping( "Recargo", "Recargo" )
}
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsa_CondicionesDeVentas_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCondicionDeVenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCondicionDeVenta", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdCondicionDeVenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdCondicionDeVenta", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Recargo", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Recargo", DataRowVersion.Current, null ) );

			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsa_CondicionesDeVentas_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdCondicionDeVenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCondicionDeVenta", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsa_CondicionesDeVentas_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCondicionDeVenta", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCondicionDeVenta", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Recargo", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Recargo", DataRowVersion.Current, null ) );

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


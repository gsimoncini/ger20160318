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

	public class tfi_CuentaBancaria : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tfi_CuentaBancaria()
		{
		}

		public static tfi_CuentaBancariaDataset GetList()
		{
			tfi_CuentaBancariaDataset data = new tfi_CuentaBancariaDataset();

			return ( tfi_CuentaBancariaDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_CuentaBancaria" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tfi_CuentaBancaria_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tfi_CuentaBancariaDataset GetList( string IdCuenta, string CodigoCuenta, string IdBanco, string NroCuenta, string Descripcion)
		{
			tfi_CuentaBancariaDataset data = new tfi_CuentaBancariaDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tfi_CuentaBancaria" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_CuentaBancaria_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			if(IdCuenta == null || IdCuenta.Equals(string.Empty))
				cmd.Parameters[ "@IdCuenta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;
			cmd.Parameters.Add( new SqlParameter( "@CodigoCuenta", SqlDbType.VarChar ) );
			if(CodigoCuenta == null || CodigoCuenta.Equals(string.Empty))
				cmd.Parameters[ "@CodigoCuenta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@CodigoCuenta" ].Value = CodigoCuenta;
			cmd.Parameters.Add( new SqlParameter( "@IdBanco", SqlDbType.VarChar ) );
			if(IdBanco == null || IdBanco.Equals(string.Empty))
				cmd.Parameters[ "@IdBanco" ].Value = IdBanco;
			else
				cmd.Parameters[ "@IdBanco" ].Value = IdBanco;
			cmd.Parameters.Add( new SqlParameter( "@NroCuenta", SqlDbType.VarChar ) );
			if(NroCuenta == null || NroCuenta.Equals(string.Empty))
				cmd.Parameters[ "@NroCuenta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@NroCuenta" ].Value = NroCuenta;
			cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
			if(Descripcion == null || Descripcion.Equals(string.Empty))
				cmd.Parameters[ "@Descripcion" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Descripcion" ].Value = Descripcion;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}
		

		public static tfi_CuentaBancariaDataset.tfi_CuentaBancariaRow NewRow()
		{
			return ( new tfi_CuentaBancariaDataset() ).tfi_CuentaBancaria.Newtfi_CuentaBancariaRow();
		}
	
		public static tfi_CuentaBancariaDataset.tfi_CuentaBancariaRow GetByPk( string IdCuenta )
		{
			tfi_CuentaBancariaDataset data = new tfi_CuentaBancariaDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tfi_CuentaBancaria_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tfi_CuentaBancaria" );

			adapter.Fill( data );

			if ( data.tfi_CuentaBancaria.Rows.Count == 1 )
			{
				return ( tfi_CuentaBancariaDataset.tfi_CuentaBancariaRow )data.tfi_CuentaBancaria.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tfi_CuentaBancariaDataset.tfi_CuentaBancariaRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tfi_CuentaBancariaDataset.tfi_CuentaBancariaDataTable )row.Table ).Addtfi_CuentaBancariaRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tfi_CuentaBancariaDataset dataSet )
		{
			Update( dataSet.tfi_CuentaBancaria );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tfi_CuentaBancariaDataset.tfi_CuentaBancariaDataTable )dataTable, trx );
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
			Update( ( tfi_CuentaBancariaDataset.tfi_CuentaBancariaDataTable )dataTable, trx );
		}
				

		public static void Update( tfi_CuentaBancariaDataset.tfi_CuentaBancariaDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tfi_CuentaBancaria", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdCuenta", "IdCuenta" ),
																											 new System.Data.Common.DataColumnMapping( "CodigoCuenta", "CodigoCuenta" ),
																											 new System.Data.Common.DataColumnMapping( "IdBanco", "IdBanco" ),
																											 new System.Data.Common.DataColumnMapping( "NroCuenta", "NroCuenta" ),
																											 new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tfi_CuentaBancaria_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCuenta", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CodigoCuenta", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CodigoCuenta", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdBanco", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdBanco", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@NroCuenta", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "NroCuenta", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdCuenta", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdCuenta", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tfi_CuentaBancaria_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCuenta", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tfi_CuentaBancaria_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCuenta", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CodigoCuenta", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CodigoCuenta", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdBanco", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdBanco", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@NroCuenta", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "NroCuenta", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
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


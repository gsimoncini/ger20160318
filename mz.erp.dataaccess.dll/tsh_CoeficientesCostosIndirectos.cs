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

	public class tsh_CoeficientesCostosIndirectos : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsh_CoeficientesCostosIndirectos()
		{
		}

		public static tsh_CoeficientesCostosIndirectosDataset GetList()
		{
			tsh_CoeficientesCostosIndirectosDataset data = new tsh_CoeficientesCostosIndirectosDataset();

			return ( tsh_CoeficientesCostosIndirectosDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_CoeficientesCostosIndirectos" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsh_CoeficientesCostosIndirectos_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsh_CoeficientesCostosIndirectosDataset GetList( string IdCoeficienteCostoIndirecto, string Descripcion, decimal Valor, bool Tipo, string IdMoneda, string IdFuenteDeCambio, long Orden, bool Activo )
		{
			tsh_CoeficientesCostosIndirectosDataset data = new tsh_CoeficientesCostosIndirectosDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_CoeficientesCostosIndirectos" );

			SqlCommand cmd = new SqlCommand( "Pr_tsh_CoeficientesCostosIndirectos_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCoeficienteCostoIndirecto" ].Value = IdCoeficienteCostoIndirecto;
			cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Descripcion" ].Value = Descripcion;
			cmd.Parameters.Add( new SqlParameter( "@Valor", SqlDbType.Decimal ) );
			cmd.Parameters[ "@Valor" ].Value = Valor;
			cmd.Parameters.Add( new SqlParameter( "@Tipo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Tipo" ].Value = Tipo;
			cmd.Parameters.Add( new SqlParameter( "@IdMoneda", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdMoneda" ].Value = IdMoneda;
			cmd.Parameters.Add( new SqlParameter( "@IdFuenteDeCambio", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdFuenteDeCambio" ].Value = IdFuenteDeCambio;
			cmd.Parameters.Add( new SqlParameter( "@Orden", SqlDbType.BigInt ) );
			if ( Orden == long.MinValue )
			{
				cmd.Parameters[ "@Orden" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@Orden" ].Value = Orden;
			}
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static DataSet GetListEx()
		{
            DataSet data = new DataSet();

			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_CoeficientesCostosIndirectosEx" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsh_CoeficientesCostosIndirectos_GetListEx", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow NewRow()
		{
			return ( new tsh_CoeficientesCostosIndirectosDataset() ).tsh_CoeficientesCostosIndirectos.Newtsh_CoeficientesCostosIndirectosRow();
		}
	
		public static tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow GetByPk( string IdCoeficienteCostoIndirecto )
		{
			tsh_CoeficientesCostosIndirectosDataset data = new tsh_CoeficientesCostosIndirectosDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsh_CoeficientesCostosIndirectos_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCoeficienteCostoIndirecto" ].Value = IdCoeficienteCostoIndirecto;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsh_CoeficientesCostosIndirectos" );

			adapter.Fill( data );

			if ( data.tsh_CoeficientesCostosIndirectos.Rows.Count == 1 )
			{
				return ( tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow )data.tsh_CoeficientesCostosIndirectos.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosDataTable )row.Table ).Addtsh_CoeficientesCostosIndirectosRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tsh_CoeficientesCostosIndirectosDataset dataSet )
		{
			Update( dataSet.tsh_CoeficientesCostosIndirectos );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosDataTable )dataTable, trx );
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
			Update( ( tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosDataTable )dataTable, trx );
		}
				

		public static void Update( tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsh_CoeficientesCostosIndirectos", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
																											 new System.Data.Common.DataColumnMapping( "IdCoeficienteCostoIndirecto", "IdCoeficienteCostoIndirecto" ),
																											 new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" ),
																											 new System.Data.Common.DataColumnMapping( "Valor", "Valor" ),
																											 new System.Data.Common.DataColumnMapping( "Tipo", "Tipo" ),
																											 new System.Data.Common.DataColumnMapping( "IdMoneda", "IdMoneda" ),
																											 new System.Data.Common.DataColumnMapping( "IdFuenteDeCambio", "IdFuenteDeCambio" ),
																											 new System.Data.Common.DataColumnMapping( "Orden", "Orden" ),
																											 new System.Data.Common.DataColumnMapping( "Activo", "Activo" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsh_CoeficientesCostosIndirectos_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCoeficienteCostoIndirecto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 30, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Valor", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Valor", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Tipo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Tipo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdMoneda", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdMoneda", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdFuenteDeCambio", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdFuenteDeCambio", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Orden", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Orden", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdCoeficienteCostoIndirecto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdCoeficienteCostoIndirecto", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsh_CoeficientesCostosIndirectos_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCoeficienteCostoIndirecto", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsh_CoeficientesCostosIndirectos_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCoeficienteCostoIndirecto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCoeficienteCostoIndirecto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 30, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Valor", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Valor", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Tipo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Tipo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMoneda", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMoneda", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdFuenteDeCambio", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdFuenteDeCambio", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Orden", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Orden", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );

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



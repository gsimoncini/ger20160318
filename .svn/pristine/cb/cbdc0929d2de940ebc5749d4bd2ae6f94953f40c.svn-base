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

	public class tpu_ProveedoresDetallePagoImpuestoGanancias : IDisposable
	{
	
		#region Custom Members

		public static tpu_ProveedoresDetallePagoImpuestoGananciasDataset.tpu_ProveedoresDetallePagoImpuestoGananciasRow GetByPeriodo( string IdProveedor, int Año, int Mes)
		{
			tpu_ProveedoresDetallePagoImpuestoGananciasDataset data = new tpu_ProveedoresDetallePagoImpuestoGananciasDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ProveedoresDetallePagoImpuestoGanancias" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_ProveedoresDetallePagoImpuestoGanancias_GetByPeriodo", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
			if(IdProveedor == null || IdProveedor == string.Empty)
				cmd.Parameters[ "@IdProveedor" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdProveedor" ].Value = IdProveedor;
			cmd.Parameters.Add( new SqlParameter( "@Mes", SqlDbType.Int ) );
			if(Mes.Equals(int.MinValue))
				cmd.Parameters[ "@Mes" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Mes" ].Value = Mes;
			cmd.Parameters.Add( new SqlParameter( "@Anio", SqlDbType.Int ) );
			if(Año.Equals(int.MinValue))
				cmd.Parameters[ "@Anio" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@Anio" ].Value = Año;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			if ( data.tpu_ProveedoresDetallePagoImpuestoGanancias.Rows.Count == 1 )
			{
				return ( tpu_ProveedoresDetallePagoImpuestoGananciasDataset.tpu_ProveedoresDetallePagoImpuestoGananciasRow )data.tpu_ProveedoresDetallePagoImpuestoGanancias.Rows[ 0 ];
			}
			
			return null;
		}
		
		#endregion
		
		public tpu_ProveedoresDetallePagoImpuestoGanancias()
		{
		}

		public static tpu_ProveedoresDetallePagoImpuestoGananciasDataset GetList()
		{
			tpu_ProveedoresDetallePagoImpuestoGananciasDataset data = new tpu_ProveedoresDetallePagoImpuestoGananciasDataset();

			return ( tpu_ProveedoresDetallePagoImpuestoGananciasDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ProveedoresDetallePagoImpuestoGanancias" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tpu_ProveedoresDetallePagoImpuestoGanancias_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_ProveedoresDetallePagoImpuestoGananciasDataset GetList( long IdDetallePago, int Mes, int Anio, decimal TotalPago, decimal TotalRetencioes, long IdConceptoImpuestoGanancias )
		{
			tpu_ProveedoresDetallePagoImpuestoGananciasDataset data = new tpu_ProveedoresDetallePagoImpuestoGananciasDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ProveedoresDetallePagoImpuestoGanancias" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_ProveedoresDetallePagoImpuestoGanancias_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdDetallePago", SqlDbType.BigInt ) );
			if ( IdDetallePago == long.MinValue )
			{
				cmd.Parameters[ "@IdDetallePago" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdDetallePago" ].Value = IdDetallePago;
			}
			cmd.Parameters.Add( new SqlParameter( "@Mes", SqlDbType.Int ) );
			cmd.Parameters[ "@Mes" ].Value = Mes;
			cmd.Parameters.Add( new SqlParameter( "@Anio", SqlDbType.Int ) );
			cmd.Parameters[ "@Anio" ].Value = Anio;
			cmd.Parameters.Add( new SqlParameter( "@TotalPago", SqlDbType.Decimal ) );
			cmd.Parameters[ "@TotalPago" ].Value = TotalPago;
			cmd.Parameters.Add( new SqlParameter( "@TotalRetencioes", SqlDbType.Decimal ) );
			cmd.Parameters[ "@TotalRetencioes" ].Value = TotalRetencioes;
			cmd.Parameters.Add( new SqlParameter( "@IdConceptoImpuestoGanancias", SqlDbType.BigInt ) );
			if ( IdConceptoImpuestoGanancias == long.MinValue )
			{
				cmd.Parameters[ "@IdConceptoImpuestoGanancias" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdConceptoImpuestoGanancias" ].Value = IdConceptoImpuestoGanancias;
			}
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_ProveedoresDetallePagoImpuestoGananciasDataset.tpu_ProveedoresDetallePagoImpuestoGananciasRow NewRow()
		{
			return ( new tpu_ProveedoresDetallePagoImpuestoGananciasDataset() ).tpu_ProveedoresDetallePagoImpuestoGanancias.Newtpu_ProveedoresDetallePagoImpuestoGananciasRow();
		}
	
		public static tpu_ProveedoresDetallePagoImpuestoGananciasDataset.tpu_ProveedoresDetallePagoImpuestoGananciasRow GetByPk( long IdDetallePago )
		{
			tpu_ProveedoresDetallePagoImpuestoGananciasDataset data = new tpu_ProveedoresDetallePagoImpuestoGananciasDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tpu_ProveedoresDetallePagoImpuestoGanancias_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdDetallePago", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdDetallePago" ].Value = IdDetallePago;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tpu_ProveedoresDetallePagoImpuestoGanancias" );

			adapter.Fill( data );

			if ( data.tpu_ProveedoresDetallePagoImpuestoGanancias.Rows.Count == 1 )
			{
				return ( tpu_ProveedoresDetallePagoImpuestoGananciasDataset.tpu_ProveedoresDetallePagoImpuestoGananciasRow )data.tpu_ProveedoresDetallePagoImpuestoGanancias.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tpu_ProveedoresDetallePagoImpuestoGananciasDataset.tpu_ProveedoresDetallePagoImpuestoGananciasRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tpu_ProveedoresDetallePagoImpuestoGananciasDataset.tpu_ProveedoresDetallePagoImpuestoGananciasDataTable )row.Table ).Addtpu_ProveedoresDetallePagoImpuestoGananciasRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tpu_ProveedoresDetallePagoImpuestoGananciasDataset dataSet )
		{
			Update( dataSet.tpu_ProveedoresDetallePagoImpuestoGanancias );
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

		
				
		public static void Update( DataTable dataTable, string IdTransaction)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			Update( dataTable, trx );
		}
		

		public static void Update( DataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tpu_ProveedoresDetallePagoImpuestoGanancias", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdDetallePago", "IdDetallePago" ),
																											 new System.Data.Common.DataColumnMapping( "IdProveedor", "IdProveedor" ),
																											 new System.Data.Common.DataColumnMapping( "Mes", "Mes" ),
																											 new System.Data.Common.DataColumnMapping( "Anio", "Anio" ),
																											 new System.Data.Common.DataColumnMapping( "TotalPago", "TotalPago" ),
																											 new System.Data.Common.DataColumnMapping( "TotalRetenciones", "TotalRetenciones" ),
																											 new System.Data.Common.DataColumnMapping( "IdConceptoImpuestoGanancias", "IdConceptoImpuestoGanancias" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tpu_ProveedoresDetallePagoImpuestoGanancias_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdDetallePago", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdDetallePago", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProveedor", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Mes", SqlDbType.Int, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Mes", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Anio", SqlDbType.Int, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Anio", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@TotalPago", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "TotalPago", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@TotalRetenciones", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "TotalRetenciones", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConceptoImpuestoGanancias", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConceptoImpuestoGanancias", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdDetallePago", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdDetallePago", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tpu_ProveedoresDetallePagoImpuestoGanancias_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdDetallePago", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdDetallePago", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tpu_ProveedoresDetallePagoImpuestoGanancias_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProveedor", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Mes", SqlDbType.Int, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Mes", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Anio", SqlDbType.Int, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Anio", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@TotalPago", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "TotalPago", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@TotalRetenciones", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "TotalRetenciones", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConceptoImpuestoGanancias", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConceptoImpuestoGanancias", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdDetallePago", SqlDbType.BigInt, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdDetallePago", DataRowVersion.Current, null ) );

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


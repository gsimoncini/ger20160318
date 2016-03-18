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

	public class Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria()
		{
		}

		public static Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset GetList()
		{
			Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset data = new Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset();

			return ( Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria" );
			
			SqlCommand cmd = new SqlCommand( "Pr_Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset GetList( string IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria, string IdTipoDeComprobante, string IdTDCompTesoreria, string IdCondicionDeVenta)
		{
			Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset data = new Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria" );

			SqlCommand cmd = new SqlCommand( "Pr_Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria" ].Value = IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria;
			cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTipoDeComprobante" ].Value = IdTipoDeComprobante;
			cmd.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTDCompTesoreria" ].Value = IdTDCompTesoreria;
			cmd.Parameters.Add( new SqlParameter( "@IdCondicionDeVenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCondicionDeVenta" ].Value = IdCondicionDeVenta;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow NewRow()
		{
			return ( new Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset() ).Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.NewTsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow();
		}
	
		public static Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow GetByPk( string IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria )
		{
			Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset data = new Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset();

			SqlCommand cmd = new SqlCommand( "Pr_Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria" ].Value = IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria" );

			adapter.Fill( data );

			if ( data.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.Rows.Count == 1 )
			{
				return ( Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow )data.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataTable )row.Table ).AddTsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update(System.Data.DataTable dataTable,string IdTransaction)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			Update(dataTable,trx);			
		}


		public static void Update( Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset dataSet )
		{
			Update( dataSet.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataTable )dataTable, trx );
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
			Update( (Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataTable)dataTable, trx );
		}
				

		public static void Update( Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria", "IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria" ),
																											 new System.Data.Common.DataColumnMapping( "IdTipoDeComprobante", "IdTipoDeComprobante" ),
																											 new System.Data.Common.DataColumnMapping( "IdTDCompTesoreria", "IdTDCompTesoreria" ),
																											 new System.Data.Common.DataColumnMapping( "IdCondicionDeVenta", "IdCondicionDeVenta" ),
																											 new System.Data.Common.DataColumnMapping( "MetodoDeAsignacion", "MetodoDeAsignacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
																											 new System.Data.Common.DataColumnMapping( "IdProceso", "IdProceso" ),
																											 new System.Data.Common.DataColumnMapping( "IdTarea", "IdTarea" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTipoDeComprobante", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTDCompTesoreria", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCondicionDeVenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCondicionDeVenta", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@MetodoDeAsignacion", SqlDbType.VarChar, 1, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "MetodoDeAsignacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProceso", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProceso", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTarea", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoDeComprobante", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTDCompTesoreria", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTDCompTesoreria", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCondicionDeVenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCondicionDeVenta", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@MetodoDeAsignacion", SqlDbType.VarChar, 1, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "MetodoDeAsignacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProceso", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProceso", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTarea", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTarea", DataRowVersion.Current, null ) );

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


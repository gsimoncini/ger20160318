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

	public class tsa_DescuentosPorCuentas : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsa_DescuentosPorCuentas()
		{
		}

		public static tsa_DescuentosPorCuentasDataset GetList()
		{
			tsa_DescuentosPorCuentasDataset data = new tsa_DescuentosPorCuentasDataset();

			return ( tsa_DescuentosPorCuentasDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_DescuentosPorCuentas" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsa_DescuentosPorCuentas_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsa_DescuentosPorCuentasDataset GetList( long IdDescuentosPorCuentas, string IdCuenta, string Descripcion, decimal BonificacionRecargo, decimal CargoFijo, decimal MontoMinimo, DateTime VigenciaDesde, DateTime VigenciaHasta, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			tsa_DescuentosPorCuentasDataset data = new tsa_DescuentosPorCuentasDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_DescuentosPorCuentas" );

			SqlCommand cmd = new SqlCommand( "Pr_tsa_DescuentosPorCuentas_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdDescuentosPorCuentas", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdDescuentosPorCuentas" ].Value = IdDescuentosPorCuentas;
			
			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;
			
			cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Descripcion" ].Value = Descripcion;
			
			cmd.Parameters.Add( new SqlParameter( "@BonificacionRecargo", SqlDbType.Decimal ) );
			cmd.Parameters[ "@BonificacionRecargo" ].Value = BonificacionRecargo;
			
			cmd.Parameters.Add( new SqlParameter( "@CargoFijo", SqlDbType.Decimal ) );
			cmd.Parameters[ "@CargoFijo" ].Value = CargoFijo;
			
			cmd.Parameters.Add( new SqlParameter( "@MontoMinimo", SqlDbType.Decimal ) );
			cmd.Parameters[ "@MontoMinimo" ].Value = MontoMinimo;
			
			cmd.Parameters.Add( new SqlParameter( "@VigenciaDesde", SqlDbType.DateTime ) );
			cmd.Parameters[ "@VigenciaDesde" ].Value = VigenciaDesde;
			
			cmd.Parameters.Add( new SqlParameter( "@VigenciaHasta", SqlDbType.DateTime ) );
			cmd.Parameters[ "@VigenciaHasta" ].Value = VigenciaHasta;
			
			cmd.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime ) );
			cmd.Parameters[ "@FechaCreacion" ].Value = FechaCreacion;
			
			cmd.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdConexionCreacion" ].Value = IdConexionCreacion;
			
			cmd.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp ) );
			cmd.Parameters[ "@UltimaModificacion" ].Value = UltimaModificacion;
			
			cmd.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdConexionUltimaModificacion" ].Value = IdConexionUltimaModificacion;
			
			cmd.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdReservado" ].Value = IdReservado;
			
			cmd.Parameters.Add( new SqlParameter( "@RowId", SqlDbType.UniqueIdentifier ) );
			cmd.Parameters[ "@RowId" ].Value = RowId;
			
			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;
			
			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;
			

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsa_DescuentosPorCuentasDataset.tsa_DescuentosPorCuentasRow NewRow()
		{
			return ( new tsa_DescuentosPorCuentasDataset() ).tsa_DescuentosPorCuentas.Newtsa_DescuentosPorCuentasRow();
		}
	
		public static tsa_DescuentosPorCuentasDataset.tsa_DescuentosPorCuentasRow GetByPk( long IdDescuentosPorCuentas )
		{
			tsa_DescuentosPorCuentasDataset data = new tsa_DescuentosPorCuentasDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsa_DescuentosPorCuentas_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdDescuentosPorCuentas", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdDescuentosPorCuentas" ].Value = IdDescuentosPorCuentas;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsa_DescuentosPorCuentas" );

			adapter.Fill( data );

			if ( data.tsa_DescuentosPorCuentas.Rows.Count == 1 )
			{
				return ( tsa_DescuentosPorCuentasDataset.tsa_DescuentosPorCuentasRow )data.tsa_DescuentosPorCuentas.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tsa_DescuentosPorCuentasDataset.tsa_DescuentosPorCuentasRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsa_DescuentosPorCuentasDataset.tsa_DescuentosPorCuentasDataTable )row.Table ).Addtsa_DescuentosPorCuentasRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tsa_DescuentosPorCuentasDataset dataSet )
		{
			Update( dataSet.tsa_DescuentosPorCuentas );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tsa_DescuentosPorCuentasDataset.tsa_DescuentosPorCuentasDataTable )dataTable, trx );
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
			Update( ( tsa_DescuentosPorCuentasDataset.tsa_DescuentosPorCuentasDataTable )dataTable, trx );
		}
				

		public static void Update( tsa_DescuentosPorCuentasDataset.tsa_DescuentosPorCuentasDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
					new System.Data.Common.DataTableMapping( "Table", "tsa_DescuentosPorCuentas", 
						new System.Data.Common.DataColumnMapping[] {
							new System.Data.Common.DataColumnMapping( "IdDescuentosPorCuentas", "IdDescuentosPorCuentas" ),
							new System.Data.Common.DataColumnMapping( "IdCuenta", "IdCuenta" ),
							new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" ),
							new System.Data.Common.DataColumnMapping( "BonificacionRecargo", "BonificacionRecargo" ),
							new System.Data.Common.DataColumnMapping( "CargoFijo", "CargoFijo" ),
							new System.Data.Common.DataColumnMapping( "MontoMinimo", "MontoMinimo" ),
							new System.Data.Common.DataColumnMapping( "VigenciaDesde", "VigenciaDesde" ),
							new System.Data.Common.DataColumnMapping( "VigenciaHasta", "VigenciaHasta" ),
							new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
							new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
							new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
							new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
							new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
							new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
							new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
							new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" )
						}
					)
				}
			);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsa_DescuentosPorCuentas_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdDescuentosPorCuentas", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdDescuentosPorCuentas", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCuenta", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@BonificacionRecargo", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "BonificacionRecargo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CargoFijo", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CargoFijo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@MontoMinimo", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "MontoMinimo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@VigenciaDesde", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "VigenciaDesde", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@VigenciaHasta", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "VigenciaHasta", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdDescuentosPorCuentas", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdDescuentosPorCuentas", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsa_DescuentosPorCuentas_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdDescuentosPorCuentas", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdDescuentosPorCuentas", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsa_DescuentosPorCuentas_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCuenta", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@BonificacionRecargo", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "BonificacionRecargo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CargoFijo", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CargoFijo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@MontoMinimo", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "MontoMinimo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@VigenciaDesde", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "VigenciaDesde", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@VigenciaHasta", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "VigenciaHasta", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdDescuentosPorCuentas", SqlDbType.BigInt, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdDescuentosPorCuentas", DataRowVersion.Current, null ) );

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


using System;

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

	public class tsa_CuentasJerarquias : IDisposable
	{
	
		#region Custom Members
		private static SentenciasReplicacion _replication;
		#endregion
		
		public tsa_CuentasJerarquias()
		{
		}

		public static tsa_CuentasJerarquiasDataset GetList()
		{
			tsa_CuentasJerarquiasDataset data = new tsa_CuentasJerarquiasDataset();

			return ( tsa_CuentasJerarquiasDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_CuentasJerarquias" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsa_CuentasJerarquias_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsa_CuentasJerarquiasDataset GetList( string IdCuenta, string IdNomenclatura1a, string IdNomenclatura1b, string IdNomenclatura1c, string IdNomenclatura1d, string IdNomenclatura2a, string IdNomenclatura2b, string IdNomenclatura2c, string IdNomenclatura2d, string IdNomenclatura3a, string IdNomenclatura3b, string IdNomenclatura3c, string IdNomenclatura3d, string IdNomenclatura4a, string IdNomenclatura4b, string IdNomenclatura4c, string IdNomenclatura4d, string IdNomenclatura5a, string IdNomenclatura5b, string IdNomenclatura5c, string IdNomenclatura5d, string IdNomenclatura6a, string IdNomenclatura6b, string IdNomenclatura6c, string IdNomenclatura6d, string IdNomenclatura7a, string IdNomenclatura7b, string IdNomenclatura7c, string IdNomenclatura7d, string IdNomenclatura8a, string IdNomenclatura8b, string IdNomenclatura8c, string IdNomenclatura8d, string IdNomenclatura9a, string IdNomenclatura9b, string IdNomenclatura9c, string IdNomenclatura9d, string IdNomenclatura10a, string IdNomenclatura10b, string IdNomenclatura10c, string IdNomenclatura10d, bool Activo, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa, long IdSucursal )
		{
			tsa_CuentasJerarquiasDataset data = new tsa_CuentasJerarquiasDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_CuentasJerarquias" );

			SqlCommand cmd = new SqlCommand( "Pr_tsa_CuentasJerarquias_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura1a", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura1a" ].Value = IdNomenclatura1a;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura1b", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura1b" ].Value = IdNomenclatura1b;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura1c", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura1c" ].Value = IdNomenclatura1c;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura1d", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura1d" ].Value = IdNomenclatura1d;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura2a", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura2a" ].Value = IdNomenclatura2a;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura2b", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura2b" ].Value = IdNomenclatura2b;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura2c", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura2c" ].Value = IdNomenclatura2c;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura2d", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura2d" ].Value = IdNomenclatura2d;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura3a", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura3a" ].Value = IdNomenclatura3a;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura3b", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura3b" ].Value = IdNomenclatura3b;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura3c", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura3c" ].Value = IdNomenclatura3c;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura3d", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura3d" ].Value = IdNomenclatura3d;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura4a", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura4a" ].Value = IdNomenclatura4a;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura4b", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura4b" ].Value = IdNomenclatura4b;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura4c", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura4c" ].Value = IdNomenclatura4c;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura4d", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura4d" ].Value = IdNomenclatura4d;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura5a", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura5a" ].Value = IdNomenclatura5a;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura5b", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura5b" ].Value = IdNomenclatura5b;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura5c", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura5c" ].Value = IdNomenclatura5c;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura5d", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura5d" ].Value = IdNomenclatura5d;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura6a", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura6a" ].Value = IdNomenclatura6a;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura6b", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura6b" ].Value = IdNomenclatura6b;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura6c", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura6c" ].Value = IdNomenclatura6c;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura6d", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura6d" ].Value = IdNomenclatura6d;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura7a", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura7a" ].Value = IdNomenclatura7a;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura7b", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura7b" ].Value = IdNomenclatura7b;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura7c", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura7c" ].Value = IdNomenclatura7c;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura7d", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura7d" ].Value = IdNomenclatura7d;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura8a", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura8a" ].Value = IdNomenclatura8a;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura8b", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura8b" ].Value = IdNomenclatura8b;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura8c", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura8c" ].Value = IdNomenclatura8c;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura8d", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura8d" ].Value = IdNomenclatura8d;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura9a", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura9a" ].Value = IdNomenclatura9a;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura9b", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura9b" ].Value = IdNomenclatura9b;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura9c", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura9c" ].Value = IdNomenclatura9c;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura9d", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura9d" ].Value = IdNomenclatura9d;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura10a", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura10a" ].Value = IdNomenclatura10a;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura10b", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura10b" ].Value = IdNomenclatura10b;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura10c", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura10c" ].Value = IdNomenclatura10c;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura10d", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdNomenclatura10d" ].Value = IdNomenclatura10d;
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;
			cmd.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime ) );
			cmd.Parameters[ "@FechaCreacion" ].Value = FechaCreacion;
			cmd.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt ) );
			if ( IdConexionCreacion == long.MinValue )
			{
				cmd.Parameters[ "@IdConexionCreacion" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdConexionCreacion" ].Value = IdConexionCreacion;
			}
			cmd.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp ) );
			cmd.Parameters[ "@UltimaModificacion" ].Value = UltimaModificacion;
			cmd.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt ) );
			if ( IdConexionUltimaModificacion == long.MinValue )
			{
				cmd.Parameters[ "@IdConexionUltimaModificacion" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdConexionUltimaModificacion" ].Value = IdConexionUltimaModificacion;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt ) );
			if ( IdReservado == long.MinValue )
			{
				cmd.Parameters[ "@IdReservado" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdReservado" ].Value = IdReservado;
			}
			cmd.Parameters.Add( new SqlParameter( "@RowId", SqlDbType.UniqueIdentifier ) );
			cmd.Parameters[ "@RowId" ].Value = RowId;
			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
			if ( IdEmpresa == long.MinValue )
			{
				cmd.Parameters[ "@IdEmpresa" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;
			}
			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			if ( IdSucursal == long.MinValue )
			{
				cmd.Parameters[ "@IdSucursal" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;
			}
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasRow NewRow()
		{
			return ( new tsa_CuentasJerarquiasDataset() ).tsa_CuentasJerarquias.Newtsa_CuentasJerarquiasRow();
		}
	
		public static tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasRow GetByPk( string IdCuenta )
		{
			tsa_CuentasJerarquiasDataset data = new tsa_CuentasJerarquiasDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsa_CuentasJerarquias_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsa_CuentasJerarquias" );

			adapter.Fill( data );

			if ( data.tsa_CuentasJerarquias.Rows.Count == 1 )
			{
				return ( tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasRow )data.tsa_CuentasJerarquias.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasDataTable )row.Table ).Addtsa_CuentasJerarquiasRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tsa_CuentasJerarquiasDataset dataSet )
		{
			Update( dataSet.tsa_CuentasJerarquias );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasDataTable )dataTable, trx );
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
			Update( ( tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasDataTable )dataTable, trx );
		}
				

		public static void Update( tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsa_CuentasJerarquias", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdCuenta", "IdCuenta" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura1a", "IdNomenclatura1a" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura1b", "IdNomenclatura1b" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura1c", "IdNomenclatura1c" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura1d", "IdNomenclatura1d" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura2a", "IdNomenclatura2a" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura2b", "IdNomenclatura2b" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura2c", "IdNomenclatura2c" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura2d", "IdNomenclatura2d" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura3a", "IdNomenclatura3a" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura3b", "IdNomenclatura3b" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura3c", "IdNomenclatura3c" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura3d", "IdNomenclatura3d" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura4a", "IdNomenclatura4a" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura4b", "IdNomenclatura4b" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura4c", "IdNomenclatura4c" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura4d", "IdNomenclatura4d" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura5a", "IdNomenclatura5a" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura5b", "IdNomenclatura5b" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura5c", "IdNomenclatura5c" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura5d", "IdNomenclatura5d" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura6a", "IdNomenclatura6a" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura6b", "IdNomenclatura6b" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura6c", "IdNomenclatura6c" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura6d", "IdNomenclatura6d" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura7a", "IdNomenclatura7a" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura7b", "IdNomenclatura7b" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura7c", "IdNomenclatura7c" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura7d", "IdNomenclatura7d" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura8a", "IdNomenclatura8a" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura8b", "IdNomenclatura8b" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura8c", "IdNomenclatura8c" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura8d", "IdNomenclatura8d" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura9a", "IdNomenclatura9a" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura9b", "IdNomenclatura9b" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura9c", "IdNomenclatura9c" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura9d", "IdNomenclatura9d" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura10a", "IdNomenclatura10a" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura10b", "IdNomenclatura10b" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura10c", "IdNomenclatura10c" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura10d", "IdNomenclatura10d" ),
																											 new System.Data.Common.DataColumnMapping( "Activo", "Activo" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsa_CuentasJerarquias_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCuenta", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura1a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura1a", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura1b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura1b", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura1c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura1c", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura1d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura1d", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura2a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura2a", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura2b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura2b", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura2c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura2c", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura2d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura2d", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura3a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura3a", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura3b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura3b", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura3c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura3c", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura3d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura3d", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura4a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura4a", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura4b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura4b", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura4c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura4c", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura4d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura4d", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura5a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura5a", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura5b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura5b", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura5c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura5c", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura5d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura5d", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura6a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura6a", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura6b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura6b", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura6c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura6c", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura6d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura6d", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura7a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura7a", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura7b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura7b", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura7c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura7c", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura7d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura7d", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura8a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura8a", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura8b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura8b", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura8c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura8c", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura8d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura8d", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura9a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura9a", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura9b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura9b", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura9c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura9c", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura9d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura9d", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura10a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura10a", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura10b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura10b", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura10c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura10c", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura10d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura10d", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdCuenta", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsa_CuentasJerarquias_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCuenta", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsa_CuentasJerarquias_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCuenta", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura1a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura1a", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura1b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura1b", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura1c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura1c", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura1d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura1d", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura2a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura2a", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura2b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura2b", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura2c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura2c", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura2d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura2d", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura3a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura3a", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura3b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura3b", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura3c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura3c", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura3d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura3d", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura4a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura4a", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura4b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura4b", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura4c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura4c", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura4d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura4d", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura5a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura5a", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura5b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura5b", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura5c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura5c", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura5d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura5d", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura6a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura6a", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura6b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura6b", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura6c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura6c", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura6d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura6d", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura7a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura7a", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura7b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura7b", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura7c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura7c", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura7d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura7d", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura8a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura8a", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura8b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura8b", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura8c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura8c", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura8d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura8d", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura9a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura9a", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura9b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura9b", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura9c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura9c", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura9d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura9d", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura10a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura10a", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura10b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura10b", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura10c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura10c", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura10d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura10d", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
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
		

		public static void Update( DataTable dataTable, SqlTransaction trx, SentenciasReplicacion replication)
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsa_CuentasJerarquias", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdCuenta", "IdCuenta" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura1a", "IdNomenclatura1a" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura1b", "IdNomenclatura1b" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura1c", "IdNomenclatura1c" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura1d", "IdNomenclatura1d" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura2a", "IdNomenclatura2a" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura2b", "IdNomenclatura2b" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura2c", "IdNomenclatura2c" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura2d", "IdNomenclatura2d" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura3a", "IdNomenclatura3a" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura3b", "IdNomenclatura3b" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura3c", "IdNomenclatura3c" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura3d", "IdNomenclatura3d" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura4a", "IdNomenclatura4a" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura4b", "IdNomenclatura4b" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura4c", "IdNomenclatura4c" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura4d", "IdNomenclatura4d" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura5a", "IdNomenclatura5a" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura5b", "IdNomenclatura5b" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura5c", "IdNomenclatura5c" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura5d", "IdNomenclatura5d" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura6a", "IdNomenclatura6a" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura6b", "IdNomenclatura6b" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura6c", "IdNomenclatura6c" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura6d", "IdNomenclatura6d" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura7a", "IdNomenclatura7a" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura7b", "IdNomenclatura7b" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura7c", "IdNomenclatura7c" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura7d", "IdNomenclatura7d" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura8a", "IdNomenclatura8a" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura8b", "IdNomenclatura8b" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura8c", "IdNomenclatura8c" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura8d", "IdNomenclatura8d" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura9a", "IdNomenclatura9a" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura9b", "IdNomenclatura9b" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura9c", "IdNomenclatura9c" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura9d", "IdNomenclatura9d" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura10a", "IdNomenclatura10a" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura10b", "IdNomenclatura10b" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura10c", "IdNomenclatura10c" ),
																											 new System.Data.Common.DataColumnMapping( "IdNomenclatura10d", "IdNomenclatura10d" ),
																											 new System.Data.Common.DataColumnMapping( "Activo", "Activo" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsa_CuentasJerarquias_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCuenta", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura1a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura1a", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura1b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura1b", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura1c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura1c", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura1d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura1d", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura2a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura2a", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura2b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura2b", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura2c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura2c", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura2d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura2d", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura3a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura3a", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura3b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura3b", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura3c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura3c", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura3d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura3d", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura4a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura4a", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura4b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura4b", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura4c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura4c", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura4d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura4d", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura5a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura5a", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura5b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura5b", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura5c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura5c", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura5d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura5d", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura6a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura6a", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura6b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura6b", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura6c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura6c", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura6d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura6d", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura7a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura7a", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura7b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura7b", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura7c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura7c", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura7d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura7d", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura8a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura8a", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura8b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura8b", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura8c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura8c", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura8d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura8d", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura9a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura9a", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura9b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura9b", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura9c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura9c", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura9d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura9d", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura10a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura10a", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura10b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura10b", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura10c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura10c", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdNomenclatura10d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdNomenclatura10d", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdCuenta", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsa_CuentasJerarquias_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCuenta", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsa_CuentasJerarquias_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCuenta", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura1a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura1a", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura1b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura1b", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura1c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura1c", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura1d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura1d", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura2a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura2a", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura2b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura2b", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura2c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura2c", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura2d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura2d", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura3a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura3a", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura3b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura3b", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura3c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura3c", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura3d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura3d", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura4a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura4a", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura4b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura4b", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura4c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura4c", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura4d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura4d", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura5a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura5a", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura5b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura5b", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura5c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura5c", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura5d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura5d", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura6a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura6a", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura6b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura6b", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura6c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura6c", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura6d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura6d", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura7a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura7a", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura7b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura7b", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura7c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura7c", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura7d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura7d", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura8a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura8a", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura8b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura8b", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura8c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura8c", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura8d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura8d", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura9a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura9a", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura9b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura9b", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura9c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura9c", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura9d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura9d", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura10a", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura10a", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura10b", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura10b", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura10c", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura10c", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdNomenclatura10d", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdNomenclatura10d", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );

			#region Replicacion


			_replication = replication;
		
			adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);

			#endregion

			adapter.UpdateCommand = sqlCommandUpdate;
			adapter.DeleteCommand = sqlCommandDelete;
			adapter.InsertCommand = sqlCommandInsert;
			adapter.Update ( dataTable );
		}

		public static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
		{
			
		
			StatementSQLForReplicationFactory.GetSqlStatement(e.Command, _replication.Sentence);
			if(_replication.IdTipoDeSentencia == null || _replication.IdTipoDeSentencia.Equals(string.Empty))
				_replication.IdTipoDeSentencia = e.StatementType.ToString().ToUpper();
			
			
		}

		
		public void Dispose()
		{
		}

		
	}
}


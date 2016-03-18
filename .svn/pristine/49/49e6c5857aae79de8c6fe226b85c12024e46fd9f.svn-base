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

	public class tsa_CuentasObservacionesEstados : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsa_CuentasObservacionesEstados()
		{
		}

		public static tsa_CuentasObservacionesEstadosDataset GetList()
		{
			tsa_CuentasObservacionesEstadosDataset data = new tsa_CuentasObservacionesEstadosDataset();

			return ( tsa_CuentasObservacionesEstadosDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_CuentasObservacionesEstados" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsa_CuentasObservacionesEstados_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsa_CuentasObservacionesEstadosDataset GetList( string IdCuentaObservacionEstado, string Descripcion, bool Activo  )
		{
			tsa_CuentasObservacionesEstadosDataset data = new tsa_CuentasObservacionesEstadosDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_CuentasObservacionesEstados" );

			SqlCommand cmd = new SqlCommand( "Pr_tsa_CuentasObservacionesEstados_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
			if (Descripcion== string.Empty)
				cmd.Parameters[ "@Descripcion" ].Value = null;
			else
			cmd.Parameters[ "@Descripcion" ].Value = Descripcion;

			cmd.Parameters.Add( new SqlParameter( "@IdCuentaObservacionEstado", SqlDbType.VarChar ) );
			if (IdCuentaObservacionEstado== string.Empty)
				cmd.Parameters[ "@IdCuentaObservacionEstado" ].Value= null;
			else
				cmd.Parameters[ "@IdCuentaObservacionEstado" ].Value = IdCuentaObservacionEstado;
			

			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;

			adapter.SelectCommand = cmd;
			adapter.Fill( data );
         
			return data;
		}

		public static tsa_CuentasObservacionesEstadosDataset.tsa_CuentasObservacionesEstadosRow NewRow()
		{
			return ( new tsa_CuentasObservacionesEstadosDataset() ).tsa_CuentasObservacionesEstados.Newtsa_CuentasObservacionesEstadosRow();
		}
	
		public static tsa_CuentasObservacionesEstadosDataset.tsa_CuentasObservacionesEstadosRow GetByPk( string IdCuentaObservacionEstado )
		{
			tsa_CuentasObservacionesEstadosDataset data = new tsa_CuentasObservacionesEstadosDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsa_CuentasObservacionesEstados_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdCuentaObservacionEstado", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuentaObservacionEstado" ].Value = IdCuentaObservacionEstado;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsa_CuentasObservacionesEstados" );

			adapter.Fill( data );

			if ( data.tsa_CuentasObservacionesEstados.Rows.Count == 1 )
			{
				return ( tsa_CuentasObservacionesEstadosDataset.tsa_CuentasObservacionesEstadosRow )data.tsa_CuentasObservacionesEstados.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tsa_CuentasObservacionesEstadosDataset.tsa_CuentasObservacionesEstadosRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsa_CuentasObservacionesEstadosDataset.tsa_CuentasObservacionesEstadosDataTable )row.Table ).Addtsa_CuentasObservacionesEstadosRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tsa_CuentasObservacionesEstadosDataset dataSet )
		{
			Update( dataSet.tsa_CuentasObservacionesEstados );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tsa_CuentasObservacionesEstadosDataset.tsa_CuentasObservacionesEstadosDataTable )dataTable, trx );
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
			Update( ( tsa_CuentasObservacionesEstadosDataset.tsa_CuentasObservacionesEstadosDataTable )dataTable, trx );
		}
				

		public static void Update( tsa_CuentasObservacionesEstadosDataset.tsa_CuentasObservacionesEstadosDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsa_CuentasObservacionesEstados", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdCuentaObservacionEstado", "IdCuentaObservacionEstado" ),
																											 new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "Activo", "Activo" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsa_CuentasObservacionesEstados_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCuentaObservacionEstado", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCuentaObservacionEstado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdCuentaObservacionEstado", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdCuentaObservacionEstado", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsa_CuentasObservacionesEstados_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdCuentaObservacionEstado", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCuentaObservacionEstado", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsa_CuentasObservacionesEstados_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCuentaObservacionEstado", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCuentaObservacionEstado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
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


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

	public class tui_ConfiguracionFamiliaFDPEntidades : IDisposable
	{
	
		#region Custom Members
		
		public static tui_ConfiguracionFamiliaFDPEntidadesDataset.tui_ConfiguracionFamiliaFDPEntidadesRow GetByIdEntidad(string IdEntidad )
		{
			tui_ConfiguracionFamiliaFDPEntidadesDataset data = new tui_ConfiguracionFamiliaFDPEntidadesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tui_ConfiguracionFamiliaFDPEntidades" );

			SqlCommand cmd = new SqlCommand( "Pr_tui_ConfiguracionFamiliaFDPEntidades_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdEntidad", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdEntidad" ].Value = IdEntidad;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );

			if ( data.tui_ConfiguracionFamiliaFDPEntidades.Rows.Count == 1 )
			{
				return ( tui_ConfiguracionFamiliaFDPEntidadesDataset.tui_ConfiguracionFamiliaFDPEntidadesRow )data.tui_ConfiguracionFamiliaFDPEntidades.Rows[ 0 ];
			}
			
			return null;
		}

		#endregion
		
		public tui_ConfiguracionFamiliaFDPEntidades()
		{
		}

		public static tui_ConfiguracionFamiliaFDPEntidadesDataset GetList()
		{
			tui_ConfiguracionFamiliaFDPEntidadesDataset data = new tui_ConfiguracionFamiliaFDPEntidadesDataset();

			return ( tui_ConfiguracionFamiliaFDPEntidadesDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tui_ConfiguracionFamiliaFDPEntidades" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tui_ConfiguracionFamiliaFDPEntidades_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tui_ConfiguracionFamiliaFDPEntidadesDataset GetList( string Familia, string IdEntidad )
		{
			tui_ConfiguracionFamiliaFDPEntidadesDataset data = new tui_ConfiguracionFamiliaFDPEntidadesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tui_ConfiguracionFamiliaFDPEntidades" );

			SqlCommand cmd = new SqlCommand( "Pr_tui_ConfiguracionFamiliaFDPEntidades_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@Familia", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Familia" ].Value = Familia;
			cmd.Parameters.Add( new SqlParameter( "@IdEntidad", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdEntidad" ].Value = IdEntidad;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tui_ConfiguracionFamiliaFDPEntidadesDataset.tui_ConfiguracionFamiliaFDPEntidadesRow NewRow()
		{
			return ( new tui_ConfiguracionFamiliaFDPEntidadesDataset() ).tui_ConfiguracionFamiliaFDPEntidades.Newtui_ConfiguracionFamiliaFDPEntidadesRow();
		}
	
		public static tui_ConfiguracionFamiliaFDPEntidadesDataset.tui_ConfiguracionFamiliaFDPEntidadesRow GetByPk( string Familia, string IdEntidad )
		{
			tui_ConfiguracionFamiliaFDPEntidadesDataset data = new tui_ConfiguracionFamiliaFDPEntidadesDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tui_ConfiguracionFamiliaFDPEntidades_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@Familia", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Familia" ].Value = Familia;
			
			cmd.Parameters.Add( new SqlParameter( "@IdEntidad", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdEntidad" ].Value = IdEntidad;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tui_ConfiguracionFamiliaFDPEntidades" );

			adapter.Fill( data );

			if ( data.tui_ConfiguracionFamiliaFDPEntidades.Rows.Count == 1 )
			{
				return ( tui_ConfiguracionFamiliaFDPEntidadesDataset.tui_ConfiguracionFamiliaFDPEntidadesRow )data.tui_ConfiguracionFamiliaFDPEntidades.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tui_ConfiguracionFamiliaFDPEntidadesDataset.tui_ConfiguracionFamiliaFDPEntidadesRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tui_ConfiguracionFamiliaFDPEntidadesDataset.tui_ConfiguracionFamiliaFDPEntidadesDataTable )row.Table ).Addtui_ConfiguracionFamiliaFDPEntidadesRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update(System.Data.DataTable dataTable,string IdTransaction)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			Update(dataTable,trx);			
		}

		public static void Update( tui_ConfiguracionFamiliaFDPEntidadesDataset dataSet )
		{
			Update( dataSet.tui_ConfiguracionFamiliaFDPEntidades );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tui_ConfiguracionFamiliaFDPEntidadesDataset.tui_ConfiguracionFamiliaFDPEntidadesDataTable )dataTable, trx );
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
			Update( ( tui_ConfiguracionFamiliaFDPEntidadesDataset.tui_ConfiguracionFamiliaFDPEntidadesDataTable )dataTable, trx );
		}
				

		public static void Update( tui_ConfiguracionFamiliaFDPEntidadesDataset.tui_ConfiguracionFamiliaFDPEntidadesDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tui_ConfiguracionFamiliaFDPEntidades", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "Familia", "Familia" ),
																											 new System.Data.Common.DataColumnMapping( "IdEntidad", "IdEntidad" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tui_ConfiguracionFamiliaFDPEntidades_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Familia", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Familia", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEntidad", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEntidad", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldFamilia", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Familia", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdEntidad", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdEntidad", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tui_ConfiguracionFamiliaFDPEntidades_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@Familia", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Familia", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdEntidad", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEntidad", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tui_ConfiguracionFamiliaFDPEntidades_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Familia", SqlDbType.VarChar, 255, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Familia", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEntidad", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEntidad", DataRowVersion.Current, null ) );
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
		
		public void Dispose()
		{
		}

		
	}
}


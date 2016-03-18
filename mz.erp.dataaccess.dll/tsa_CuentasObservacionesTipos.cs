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

	public class tsa_CuentasObservacionesTipos : IDisposable
	{
	
		#region Custom Members
		public static tsa_CuentasObservacionesTiposDataset GetListTiposPerfil(bool Activo, long IdPerfil, string Modo)
		{
			tsa_CuentasObservacionesTiposDataset data = new tsa_CuentasObservacionesTiposDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_CuentasObservacionesTipos" );

			SqlCommand cmd;
			if (Modo == "Add")
				cmd = new SqlCommand( "Pr_tsa_CuentasObservacionesTipos_SearchTiposPerfilAdd", dbhelper.Connection.GetConnection() );
			else
				cmd = new SqlCommand( "Pr_tsa_CuentasObservacionesTipos_SearchTiposPerfilVer", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;
			cmd.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.Int ) );
			cmd.Parameters[ "@IdPerfil" ].Value = IdPerfil;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}
		public static tsa_CuentasObservacionesTiposDataset GetListSubTiposPerfil(bool Activo, string IdCuentaObservacionTipoPadre, long IdPerfil, string Modo)
		{
			tsa_CuentasObservacionesTiposDataset data = new tsa_CuentasObservacionesTiposDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_CuentasObservacionesTipos" );
			SqlCommand cmd;

			if (Modo == "Add")
				cmd = new SqlCommand( "Pr_tsa_CuentasObservacionesTipos_SearchSubTiposPerfilAdd", dbhelper.Connection.GetConnection() );
			else
				cmd = new SqlCommand( "Pr_tsa_CuentasObservacionesTipos_SearchSubTiposPerfilVer", dbhelper.Connection.GetConnection() );


			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;
			cmd.Parameters.Add( new SqlParameter( "@IdCuentaObservacionTipoPadre", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuentaObservacionTipoPadre" ].Value = IdCuentaObservacionTipoPadre;
			cmd.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.Int ) );
			cmd.Parameters[ "@IdPerfil" ].Value = IdPerfil;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsa_CuentasObservacionesTiposDataset GetListTipos(bool Activo)
		{
			tsa_CuentasObservacionesTiposDataset data = new tsa_CuentasObservacionesTiposDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_CuentasObservacionesTipos" );

			SqlCommand cmd = new SqlCommand( "Pr_tsa_CuentasObservacionesTipos_SearchTipos", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}
		public static tsa_CuentasObservacionesTiposDataset GetListSubTipos(bool Activo, string IdCuentaObservacionTipoPadre)
		{
			tsa_CuentasObservacionesTiposDataset data = new tsa_CuentasObservacionesTiposDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_CuentasObservacionesTipos" );

			SqlCommand cmd = new SqlCommand( "Pr_tsa_CuentasObservacionesTipos_SearchSubTipos", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;
			cmd.Parameters.Add( new SqlParameter( "@IdCuentaObservacionTipoPadre", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuentaObservacionTipoPadre" ].Value = IdCuentaObservacionTipoPadre;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}
		
		#endregion
		
		public tsa_CuentasObservacionesTipos()
		{
		}

		public static tsa_CuentasObservacionesTiposDataset GetList()
		{
			tsa_CuentasObservacionesTiposDataset data = new tsa_CuentasObservacionesTiposDataset();

			return ( tsa_CuentasObservacionesTiposDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_CuentasObservacionesTipos" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsa_CuentasObservacionesTipos_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsa_CuentasObservacionesTiposDataset GetList(string IdCuentaObservacionTipoPadre, bool Activo)
		{
			tsa_CuentasObservacionesTiposDataset data = new tsa_CuentasObservacionesTiposDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsa_CuentasObservacionesTipos" );

			SqlCommand cmd = new SqlCommand( "Pr_tsa_CuentasObservacionesTipos_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdCuentaObservacionTipoPadre", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuentaObservacionTipoPadre" ].Value = IdCuentaObservacionTipoPadre;
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;

			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposRow NewRow()
		{
			return ( new tsa_CuentasObservacionesTiposDataset() ).tsa_CuentasObservacionesTipos.Newtsa_CuentasObservacionesTiposRow();
		}
	
		public static tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposRow GetByPk( string IdCuentaObservacionTipo )
		{
			tsa_CuentasObservacionesTiposDataset data = new tsa_CuentasObservacionesTiposDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsa_CuentasObservacionesTipos_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdCuentaObservacionTipo", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCuentaObservacionTipo" ].Value = IdCuentaObservacionTipo;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsa_CuentasObservacionesTipos" );

			adapter.Fill( data );

			if ( data.tsa_CuentasObservacionesTipos.Rows.Count == 1 )
			{
				return ( tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposRow )data.tsa_CuentasObservacionesTipos.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposDataTable )row.Table ).Addtsa_CuentasObservacionesTiposRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tsa_CuentasObservacionesTiposDataset dataSet )
		{
			Update( dataSet.tsa_CuentasObservacionesTipos );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposDataTable )dataTable, trx );
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
			Update( ( tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposDataTable )dataTable, trx );
		}
				

		public static void Update( tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsa_CuentasObservacionesTipos", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdCuentaObservacionTipo", "IdCuentaObservacionTipo" ),
																											 new System.Data.Common.DataColumnMapping( "IdCuentaObservacionTipoPadre", "IdCuentaObservacionTipoPadre" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsa_CuentasObservacionesTipos_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCuentaObservacionTipo", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCuentaObservacionTipo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCuentaObservacionTipoPadre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCuentaObservacionTipoPadre", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdCuentaObservacionTipo", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdCuentaObservacionTipo", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsa_CuentasObservacionesTipos_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdCuentaObservacionTipo", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCuentaObservacionTipo", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsa_CuentasObservacionesTipos_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCuentaObservacionTipo", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCuentaObservacionTipo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCuentaObservacionTipoPadre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCuentaObservacionTipoPadre", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
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


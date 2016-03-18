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

	public class tpu_ProveedoresObservacionesTipos : IDisposable
	{
	
		#region Custom Members
		public static tpu_ProveedoresObservacionesTiposDataset GetListTipos(bool Activo)
		{
			tpu_ProveedoresObservacionesTiposDataset data = new tpu_ProveedoresObservacionesTiposDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ProveedoresObservacionesTipos" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_ProveedoresObservacionesTipos_SearchTipos", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}
	
		public static tpu_ProveedoresObservacionesTiposDataset GetListSubTipos(bool Activo, string IdProveedorObservacionTipoPadre)
		{
			tpu_ProveedoresObservacionesTiposDataset data = new tpu_ProveedoresObservacionesTiposDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ProveedoresObservacionesTipos" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_ProveedoresObservacionesTipos_SearchSubTipos", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;
			cmd.Parameters.Add( new SqlParameter( "@IdProveedorObservacionTipoPadre", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProveedorObservacionTipoPadre" ].Value = IdProveedorObservacionTipoPadre;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_ProveedoresObservacionesTiposDataset GetList(string IdProveedorObservacionTipoPadre, bool Activo)
		{
			tpu_ProveedoresObservacionesTiposDataset data = new tpu_ProveedoresObservacionesTiposDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ProveedoresObservacionesTipos" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_ProveedoresObservacionesTipos_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdProveedorObservacionTipoPadre", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProveedorObservacionTipoPadre" ].Value = IdProveedorObservacionTipoPadre;
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;

			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_ProveedoresObservacionesTiposDataset GetListSubTiposPerfil(bool Activo, string IdProveedorObservacionTipoPadre, long IdPerfil, string Modo)
		{
			tpu_ProveedoresObservacionesTiposDataset data = new tpu_ProveedoresObservacionesTiposDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ProveedoresObservacionesTipos" );
			SqlCommand cmd;

			if (Modo == "Add")
				cmd = new SqlCommand( "Pr_tpu_ProveedoresObservacionesTipos_SearchSubTiposPerfilAdd", dbhelper.Connection.GetConnection() );
			else
				cmd = new SqlCommand( "Pr_tpu_ProveedoresObservacionesTipos_SearchSubTiposPerfilVer", dbhelper.Connection.GetConnection() );


			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;
			cmd.Parameters.Add( new SqlParameter( "@IdProveedorObservacionTipoPadre", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProveedorObservacionTipoPadre" ].Value = IdProveedorObservacionTipoPadre;
			cmd.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.Int ) );
			cmd.Parameters[ "@IdPerfil" ].Value = IdPerfil;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_ProveedoresObservacionesTiposDataset GetListTiposPerfil(bool Activo, long IdPerfil, string Modo)
		{
			tpu_ProveedoresObservacionesTiposDataset data = new tpu_ProveedoresObservacionesTiposDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ProveedoresObservacionesTipos" );

			SqlCommand cmd;
			if (Modo == "Add")
				cmd = new SqlCommand( "Pr_tpu_ProveedoresObservacionesTipos_SearchTiposPerfilAdd", dbhelper.Connection.GetConnection() );
			else
				cmd = new SqlCommand( "Pr_tsa_tpu_ProveedoresObservacionesTipos_SearchTiposPerfilVer", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;
			cmd.Parameters.Add( new SqlParameter( "@IdPerfil", SqlDbType.Int ) );
			cmd.Parameters[ "@IdPerfil" ].Value = IdPerfil;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}


		#endregion
		
		public tpu_ProveedoresObservacionesTipos()
		{
		}

		public static tpu_ProveedoresObservacionesTiposDataset GetList()
		{
			tpu_ProveedoresObservacionesTiposDataset data = new tpu_ProveedoresObservacionesTiposDataset();

			return ( tpu_ProveedoresObservacionesTiposDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_ProveedoresObservacionesTipos" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tpu_ProveedoresObservacionesTipos_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tpu_ProveedoresObservacionesTiposDataset.tpu_ProveedoresObservacionesTiposRow NewRow()
		{
			return ( new tpu_ProveedoresObservacionesTiposDataset() ).tpu_ProveedoresObservacionesTipos.Newtpu_ProveedoresObservacionesTiposRow();
		}
	
		public static tpu_ProveedoresObservacionesTiposDataset.tpu_ProveedoresObservacionesTiposRow GetByPk( string IdProveedorObservacionTipo )
		{
			tpu_ProveedoresObservacionesTiposDataset data = new tpu_ProveedoresObservacionesTiposDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tpu_ProveedoresObservacionesTipos_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdProveedorObservacionTipo", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProveedorObservacionTipo" ].Value = IdProveedorObservacionTipo;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tpu_ProveedoresObservacionesTipos" );

			adapter.Fill( data );

			if ( data.tpu_ProveedoresObservacionesTipos.Rows.Count == 1 )
			{
				return ( tpu_ProveedoresObservacionesTiposDataset.tpu_ProveedoresObservacionesTiposRow )data.tpu_ProveedoresObservacionesTipos.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tpu_ProveedoresObservacionesTiposDataset.tpu_ProveedoresObservacionesTiposRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tpu_ProveedoresObservacionesTiposDataset.tpu_ProveedoresObservacionesTiposDataTable )row.Table ).Addtpu_ProveedoresObservacionesTiposRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tpu_ProveedoresObservacionesTiposDataset dataSet )
		{
			Update( dataSet.tpu_ProveedoresObservacionesTipos );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tpu_ProveedoresObservacionesTiposDataset.tpu_ProveedoresObservacionesTiposDataTable )dataTable, trx );
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
			Update( ( tpu_ProveedoresObservacionesTiposDataset.tpu_ProveedoresObservacionesTiposDataTable )dataTable, trx );
		}
				

		public static void Update( tpu_ProveedoresObservacionesTiposDataset.tpu_ProveedoresObservacionesTiposDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tpu_ProveedoresObservacionesTipos", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdProveedorObservacionTipo", "IdProveedorObservacionTipo" ),
																											 new System.Data.Common.DataColumnMapping( "IdProveedorObservacionTipoPadre", "IdProveedorObservacionTipoPadre" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tpu_ProveedoresObservacionesTipos_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProveedorObservacionTipo", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProveedorObservacionTipo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProveedorObservacionTipoPadre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProveedorObservacionTipoPadre", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdProveedorObservacionTipo", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProveedorObservacionTipo", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tpu_ProveedoresObservacionesTipos_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdProveedorObservacionTipo", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProveedorObservacionTipo", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tpu_ProveedoresObservacionesTipos_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProveedorObservacionTipo", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProveedorObservacionTipo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProveedorObservacionTipoPadre", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProveedorObservacionTipoPadre", DataRowVersion.Current, null ) );
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


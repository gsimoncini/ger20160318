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

	public class tsh_Provincias : IDisposable
	{
	
		#region Custom Members
		public static tsh_ProvinciasDataset GetList( long IdProvincia)
		{
			return GetList(IdProvincia, "", "", long.MinValue, long.MinValue, long.MinValue);
		}
		
		#endregion
		
		public tsh_Provincias()
		{
		}

		public static tsh_ProvinciasDataset GetList()
		{
			tsh_ProvinciasDataset data = new tsh_ProvinciasDataset();

			return ( tsh_ProvinciasDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_Provincias" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsh_Provincias_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tsh_ProvinciasDataset GetList( long IdProvincia, string Nombre, string Descripcion, long IdTratamiento, long IdEmpresa, long IdSucursal )
		{
			tsh_ProvinciasDataset data = new tsh_ProvinciasDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tsh_Provincias" );

			SqlCommand cmd = new SqlCommand( "Pr_tsh_Provincias_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdProvincia", SqlDbType.BigInt ) );
			if ( IdProvincia == long.MinValue )
			{
				cmd.Parameters[ "@IdProvincia" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdProvincia" ].Value = IdProvincia;
			}
			
			cmd.Parameters.Add( new SqlParameter( "@Nombre", SqlDbType.VarChar ) );
			if(Nombre.Equals(string.Empty))
                cmd.Parameters[ "@Nombre" ].Value = System.DBNull.Value;
			else
                cmd.Parameters[ "@Nombre" ].Value = Nombre;
			
			cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
			if(Descripcion.Equals(string.Empty))
				cmd.Parameters[ "@Descripcion" ].Value = System.DBNull.Value;
			else
                cmd.Parameters[ "@Descripcion" ].Value = Descripcion;

			cmd.Parameters.Add( new SqlParameter( "@IdTratamiento", SqlDbType.BigInt ) );
			if ( IdTratamiento == long.MinValue )
			{
				cmd.Parameters[ "@IdTratamiento" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdTratamiento" ].Value = IdTratamiento;
			}
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

		public static tsh_ProvinciasDataset.tsh_ProvinciasRow NewRow()
		{
			return ( new tsh_ProvinciasDataset() ).tsh_Provincias.Newtsh_ProvinciasRow();
		}
	
		public static tsh_ProvinciasDataset.tsh_ProvinciasRow GetByPk( long IdProvincia )
		{
			tsh_ProvinciasDataset data = new tsh_ProvinciasDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsh_Provincias_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdProvincia", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdProvincia" ].Value = IdProvincia;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsh_Provincias" );

			adapter.Fill( data );

			if ( data.tsh_Provincias.Rows.Count == 1 )
			{
				return ( tsh_ProvinciasDataset.tsh_ProvinciasRow )data.tsh_Provincias.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tsh_ProvinciasDataset.tsh_ProvinciasRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsh_ProvinciasDataset.tsh_ProvinciasDataTable )row.Table ).Addtsh_ProvinciasRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tsh_ProvinciasDataset dataSet )
		{
			Update( dataSet.tsh_Provincias );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tsh_ProvinciasDataset.tsh_ProvinciasDataTable )dataTable, trx );
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
			Update( ( tsh_ProvinciasDataset.tsh_ProvinciasDataTable )dataTable, trx );
		}
				

		public static void Update( tsh_ProvinciasDataset.tsh_ProvinciasDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsh_Provincias", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdProvincia", "IdProvincia" ),
																											 new System.Data.Common.DataColumnMapping( "Nombre", "Nombre" ),
																											 new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdTratamiento", "IdTratamiento" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsh_Provincias_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProvincia", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProvincia", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Nombre", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Nombre", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTratamiento", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTratamiento", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdProvincia", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProvincia", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsh_Provincias_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdProvincia", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProvincia", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsh_Provincias_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Nombre", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Nombre", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTratamiento", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTratamiento", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProvincia", SqlDbType.BigInt, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProvincia", DataRowVersion.Current, null ) );

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


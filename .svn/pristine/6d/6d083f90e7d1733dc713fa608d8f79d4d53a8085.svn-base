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

	public class tlg_Secciones : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tlg_Secciones()
		{
		}

		public static tlg_SeccionesDataset GetList()
		{
			tlg_SeccionesDataset data = new tlg_SeccionesDataset();

			return ( tlg_SeccionesDataset )GetList( data );
		}
		
		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tlg_Secciones" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tlg_Secciones_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static tlg_SeccionesDataset GetList( string IdSeccion, string IdDeposito, string Descripcion, string Ubicacion, string Comentario, long IdSucursal, long IdEmpresa, bool Activo )
		{
			tlg_SeccionesDataset data = new tlg_SeccionesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tlg_Secciones" );

			SqlCommand cmd = new SqlCommand( "Pr_tlg_Secciones_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdSeccion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdSeccion" ].Value = IdSeccion;
			cmd.Parameters.Add( new SqlParameter( "@IdDeposito", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdDeposito" ].Value = IdDeposito;

			cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
			if ( Descripcion == String.Empty )
			{
				cmd.Parameters[ "@Descripcion" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@Descripcion" ].Value = Descripcion;
			}
			
			cmd.Parameters.Add( new SqlParameter( "@Ubicacion", SqlDbType.VarChar ) );
			if ( Ubicacion == String.Empty )
			{
				cmd.Parameters[ "@Ubicacion" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@Ubicacion" ].Value = Ubicacion;
			}			

			cmd.Parameters.Add( new SqlParameter( "@Comentario", SqlDbType.VarChar ) );
			if ( Comentario == String.Empty )
			{
				cmd.Parameters[ "@Comentario" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@Comentario" ].Value = Comentario;
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
			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
			if ( IdEmpresa == long.MinValue )
			{
				cmd.Parameters[ "@IdEmpresa" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;
			}
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.BigInt ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;
			adapter.SelectCommand = cmd;		

			adapter.Fill( data );
         
			return data;
		}

		public static tlg_SeccionesDataset GetList( string IdSeccion, string Descripcion, string Ubicacion, bool Activo)
		{
			tlg_SeccionesDataset data = new tlg_SeccionesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tlg_Secciones" );

			SqlCommand cmd = new SqlCommand( "Pr_tlg_Secciones_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdSeccion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdSeccion" ].Value = IdSeccion;

			cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
			if ( Descripcion == String.Empty )
			{
				cmd.Parameters[ "@Descripcion" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@Descripcion" ].Value = Descripcion;
			}
			
			cmd.Parameters.Add( new SqlParameter( "@Ubicacion", SqlDbType.VarChar ) );
			if ( Ubicacion == String.Empty )
			{
				cmd.Parameters[ "@Ubicacion" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@Ubicacion" ].Value = Ubicacion;
			}	
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.BigInt ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;

			adapter.SelectCommand = cmd;		

			adapter.Fill( data );
         
			return data;
		}


/*		public static tlg_SeccionesDataset GetList( string IdSeccion, string IdDeposito, string Descripcion, string Ubicacion, string Comentario, long Activo, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			tlg_SeccionesDataset data = new tlg_SeccionesDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tlg_Secciones" );

			SqlCommand cmd = new SqlCommand( "Pr_tlg_Secciones_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdSeccion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdSeccion" ].Value = IdSeccion;
			cmd.Parameters.Add( new SqlParameter( "@IdDeposito", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdDeposito" ].Value = IdDeposito;
			cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Descripcion" ].Value = Descripcion;
			cmd.Parameters.Add( new SqlParameter( "@Ubicacion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Ubicacion" ].Value = Ubicacion;
			cmd.Parameters.Add( new SqlParameter( "@Comentario", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Comentario" ].Value = Comentario;
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.BigInt ) );
			if ( Activo == long.MinValue )
			{
				cmd.Parameters[ "@Activo" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@Activo" ].Value = Activo;
			}

			cmd.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime ) );
			cmd.Parameters[ "@FechaCreacion" ].Value = FechaCreacion;
			if ( FechaCreacion == DateTime.MinValue )
			{
				cmd.Parameters[ "@FechaCreacion" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@FechaCreacion" ].Value = IdConexionCreacion;
			}

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
			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			if ( IdSucursal == long.MinValue )
			{
				cmd.Parameters[ "@IdSucursal" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;
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
			adapter.SelectCommand = cmd;

			adapter.Fill( data );			
			long cuenta = data.Tables[0].Rows.Count;
			return data;
		}*/

		public static tlg_SeccionesDataset.tlg_SeccionesRow NewRow()
		{
			return ( new tlg_SeccionesDataset() ).tlg_Secciones.Newtlg_SeccionesRow();
		}
	
		public static tlg_SeccionesDataset.tlg_SeccionesRow GetByPk( string IdSeccion, string IdDeposito )
		{
			tlg_SeccionesDataset data = new tlg_SeccionesDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tlg_Secciones_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdSeccion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdSeccion" ].Value = IdSeccion;
			
			cmd.Parameters.Add( new SqlParameter( "@IdDeposito", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdDeposito" ].Value = IdDeposito;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tlg_Secciones" );

			adapter.Fill( data );

			if ( data.tlg_Secciones.Rows.Count == 1 )
			{
				return ( tlg_SeccionesDataset.tlg_SeccionesRow )data.tlg_Secciones.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tlg_SeccionesDataset.tlg_SeccionesRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tlg_SeccionesDataset.tlg_SeccionesDataTable )row.Table ).Addtlg_SeccionesRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( tlg_SeccionesDataset dataSet )
		{
			Update( dataSet.tlg_Secciones );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				Update( ( tlg_SeccionesDataset.tlg_SeccionesDataTable )dataTable, trx );
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
			Update( ( tlg_SeccionesDataset.tlg_SeccionesDataTable )dataTable, trx );
		}
				

		public static void Update( tlg_SeccionesDataset.tlg_SeccionesDataTable dataTable, SqlTransaction trx )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tlg_Secciones", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdSeccion", "IdSeccion" ),
																											 new System.Data.Common.DataColumnMapping( "IdDeposito", "IdDeposito" ),
																											 new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" ),
																											 new System.Data.Common.DataColumnMapping( "Ubicacion", "Ubicacion" ),
																											 new System.Data.Common.DataColumnMapping( "Comentario", "Comentario" ),
																											 new System.Data.Common.DataColumnMapping( "Activo", "Activo" ),
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
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tlg_Secciones_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSeccion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSeccion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdDeposito", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdDeposito", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Ubicacion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Ubicacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Comentario", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Comentario", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdSeccion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdSeccion", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdDeposito", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdDeposito", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tlg_Secciones_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdSeccion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSeccion", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdDeposito", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdDeposito", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tlg_Secciones_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSeccion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSeccion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdDeposito", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdDeposito", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Ubicacion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Ubicacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Comentario", SqlDbType.VarChar, 100, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Comentario", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
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


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

	public class sy_Usuarios : IDisposable
	{
	
		#region Custom Members

		public static System.Data.DataTable GetUsuariosActivosSegunPerfiles(string Perfiles)
		{
			sy_UsuariosDataset data = new sy_UsuariosDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_Usuarios" );

			SqlCommand cmd = new SqlCommand( "Pr_sy_Usuarios_GetListActivosSegunPerfiles", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@Perfiles", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Perfiles" ].Value = Perfiles;
			adapter.SelectCommand = cmd;

			try 
			{
				adapter.Fill( data );         
			}
			catch  (Exception e)
			{
				throw e;
			}			
			return data.sy_Usuarios;
		}

		public static sy_UsuariosDataset GetListActivos(string PerfilesExcluidos)
		{
			sy_UsuariosDataset data = new sy_UsuariosDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_Usuarios" );

			SqlCommand cmd = new SqlCommand( "Pr_sy_Usuarios_GetListActivosEx", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@PerfilesExcluidos", SqlDbType.VarChar ) );
			cmd.Parameters[ "@PerfilesExcluidos" ].Value = PerfilesExcluidos;
			adapter.SelectCommand = cmd;

			try 
			{
				adapter.Fill( data );         
			}
			catch  (Exception e)
			{
				throw e;
			}			
			return data;
		}

		public static System.Data.DataSet UsuariosPersonasGetList()
		{
			System.Data.DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_UsuariosPersonas" );
			
			SqlCommand cmd = new SqlCommand( "Pr_sy_UsuariosPersonas_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

        public static System.Data.DataSet UsuariosPersonasGetList(bool Activos)
        {
            System.Data.DataSet data = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "sy_UsuariosPersonas");

            SqlCommand cmd = new SqlCommand("Pr_sy_UsuariosPersonas_GetList", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Activos", SqlDbType.Bit));
            cmd.Parameters["@Activos"].Value = Activos;

            adapter.SelectCommand = cmd;

            adapter.Fill(data);

            return data;
        }

		public static System.Data.DataSet UsuariosPersonasGetList(string IdPersona)
		{
			System.Data.DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_UsuariosPersonas" );
			
			SqlCommand cmd = new SqlCommand( "Pr_sy_Usuarios_GetListByIdPersona", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@IdPersona", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdPersona" ].Value = IdPersona;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		public static System.Data.DataSet UsuariosPersonasGetList(string IdUsuario , string NombreUsuario, string NombrePersona)
		{
			System.Data.DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_UsuariosPersonas" );
			
			SqlCommand cmd = new SqlCommand( "Pr_sy_UsuariosPersonas_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdUsuario" ].Value = IdUsuario;
			cmd.Parameters.Add( new SqlParameter( "@NombreUsuario", SqlDbType.VarChar ) );
			cmd.Parameters[ "@NombreUsuario" ].Value = NombreUsuario;
			cmd.Parameters.Add( new SqlParameter( "@NombrePersona", SqlDbType.VarChar ) );
			cmd.Parameters[ "@NombrePersona" ].Value = NombrePersona;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}

		#endregion
		
		public sy_Usuarios()
		{
		}

		public static sy_UsuariosDataset GetList()
		{
			sy_UsuariosDataset data = new sy_UsuariosDataset();

			return ( sy_UsuariosDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_Usuarios" );
			
			SqlCommand cmd = new SqlCommand( "Pr_sy_Usuarios_GetList", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}
		public static sy_UsuariosDataset GetListByIdPersona( string IdPersona)
		{
			sy_UsuariosDataset data = new sy_UsuariosDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_Usuarios" );

			SqlCommand cmd = new SqlCommand( "Pr_sy_Usuarios_GetListByIdPersona", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdPersona", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdPersona" ].Value = IdPersona;
			adapter.SelectCommand = cmd;

			try 
			{
				adapter.Fill( data );         
			}
			catch  (Exception e)
			{
				string voloooo = " ";
			}			
			return data;
		}

		//public static sy_UsuariosDataset GetList( string IdUsuario, string Nombre, string Clave, byte CantidadConexionesFallida, DateTime UltimaConexion, DateTime Expiracion, short DiasValidezClave, DateTime VencimientoClave, bool Bloqueado, byte IntentosPermitidosConexion, DateTime HabilitacionCuenta, bool Administrador, bool ClaveNuncaCaduca, bool PermiteCambioClave, long ResponsableUltimaModificacion, long PerfilUtilizado, bool Activo, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId )
		public static sy_UsuariosDataset GetList( string IdUsuario, string Nombre )
		{
			sy_UsuariosDataset data = new sy_UsuariosDataset();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "sy_Usuarios" );

			SqlCommand cmd = new SqlCommand( "Pr_sy_Usuarios_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdUsuario" ].Value = IdUsuario;
			cmd.Parameters.Add( new SqlParameter( "@Nombre", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Nombre" ].Value = Nombre;
		/*	cmd.Parameters.Add( new SqlParameter( "@Clave", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Clave" ].Value = Clave;
			cmd.Parameters.Add( new SqlParameter( "@CantidadConexionesFallida", SqlDbType.TinyInt ) );
			cmd.Parameters[ "@CantidadConexionesFallida" ].Value = CantidadConexionesFallida;
			cmd.Parameters.Add( new SqlParameter( "@UltimaConexion", SqlDbType.DateTime ) );
			cmd.Parameters[ "@UltimaConexion" ].Value = UltimaConexion;
			cmd.Parameters.Add( new SqlParameter( "@Expiracion", SqlDbType.DateTime ) );
			cmd.Parameters[ "@Expiracion" ].Value = Expiracion;
			cmd.Parameters.Add( new SqlParameter( "@DiasValidezClave", SqlDbType.SmallInt ) );
			cmd.Parameters[ "@DiasValidezClave" ].Value = DiasValidezClave;
			cmd.Parameters.Add( new SqlParameter( "@VencimientoClave", SqlDbType.DateTime ) );
			cmd.Parameters[ "@VencimientoClave" ].Value = VencimientoClave;
			cmd.Parameters.Add( new SqlParameter( "@Bloqueado", SqlDbType.Bit ) );
			cmd.Parameters[ "@Bloqueado" ].Value = Bloqueado;
			cmd.Parameters.Add( new SqlParameter( "@IntentosPermitidosConexion", SqlDbType.TinyInt ) );
			cmd.Parameters[ "@IntentosPermitidosConexion" ].Value = IntentosPermitidosConexion;
			cmd.Parameters.Add( new SqlParameter( "@HabilitacionCuenta", SqlDbType.DateTime ) );
			cmd.Parameters[ "@HabilitacionCuenta" ].Value = HabilitacionCuenta;
			cmd.Parameters.Add( new SqlParameter( "@Administrador", SqlDbType.Bit ) );
			cmd.Parameters[ "@Administrador" ].Value = Administrador;
			cmd.Parameters.Add( new SqlParameter( "@ClaveNuncaCaduca", SqlDbType.Bit ) );
			cmd.Parameters[ "@ClaveNuncaCaduca" ].Value = ClaveNuncaCaduca;
			cmd.Parameters.Add( new SqlParameter( "@PermiteCambioClave", SqlDbType.Bit ) );
			cmd.Parameters[ "@PermiteCambioClave" ].Value = PermiteCambioClave;
			cmd.Parameters.Add( new SqlParameter( "@ResponsableUltimaModificacion", SqlDbType.BigInt ) );
			if ( ResponsableUltimaModificacion == long.MinValue )
			{
				cmd.Parameters[ "@ResponsableUltimaModificacion" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@ResponsableUltimaModificacion" ].Value = ResponsableUltimaModificacion;
			}
			cmd.Parameters.Add( new SqlParameter( "@PerfilUtilizado", SqlDbType.BigInt ) );
			if ( PerfilUtilizado == long.MinValue )
			{
				cmd.Parameters[ "@PerfilUtilizado" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@PerfilUtilizado" ].Value = PerfilUtilizado;
			}
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
			cmd.Parameters.Add( new SqlParameter( "@RowId", SqlDbType.UniqueIdentifier ) );
			cmd.Parameters[ "@RowId" ].Value = RowId;*/
			adapter.SelectCommand = cmd;

			try 
			{
				adapter.Fill( data );         
			}
			catch  (Exception e)
			{
				string pavada = " ";
			}			
			return data;
		}

		public static sy_UsuariosDataset.sy_UsuariosRow NewRow()
		{
			return ( new sy_UsuariosDataset() ).sy_Usuarios.Newsy_UsuariosRow();
		}
	
		public static sy_UsuariosDataset.sy_UsuariosRow GetByPk( string IdUsuario )
		{
			if (IdUsuario == null) return null;

			sy_UsuariosDataset data = new sy_UsuariosDataset();

			SqlCommand cmd = new SqlCommand( "Pr_sy_Usuarios_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdUsuario" ].Value = IdUsuario;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "sy_Usuarios" );

			adapter.Fill( data );

			if ( data.sy_Usuarios.Rows.Count == 1 )
			{
				return ( sy_UsuariosDataset.sy_UsuariosRow )data.sy_Usuarios.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( sy_UsuariosDataset.sy_UsuariosRow row )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( sy_UsuariosDataset.sy_UsuariosDataTable )row.Table ).Addsy_UsuariosRow( row );
			}
			
			Update( row.Table );
		}

		public static void Update( sy_UsuariosDataset dataSet )
		{
			Update( dataSet.sy_Usuarios );
		}
		
		public static void Update( DataTable dataTable )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );
			SentenciasReplicacion replication = null;
			try
			{
				Update( dataTable, trx, replication);
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


				

		public static void Update( System.Data.DataTable dataTable, SqlTransaction trx, SentenciasReplicacion replication )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "sy_Usuarios", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdUsuario", "IdUsuario" ),
																											 new System.Data.Common.DataColumnMapping( "Nombre", "Nombre" ),
																											 new System.Data.Common.DataColumnMapping( "Clave", "Clave" ),
																											 new System.Data.Common.DataColumnMapping( "CantidadConexionesFallida", "CantidadConexionesFallida" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaConexion", "UltimaConexion" ),
																											 new System.Data.Common.DataColumnMapping( "Expiracion", "Expiracion" ),
																											 new System.Data.Common.DataColumnMapping( "DiasValidezClave", "DiasValidezClave" ),
																											 new System.Data.Common.DataColumnMapping( "VencimientoClave", "VencimientoClave" ),
																											 new System.Data.Common.DataColumnMapping( "Bloqueado", "Bloqueado" ),
																											 new System.Data.Common.DataColumnMapping( "IntentosPermitidosConexion", "IntentosPermitidosConexion" ),
																											 new System.Data.Common.DataColumnMapping( "HabilitacionCuenta", "HabilitacionCuenta" ),
																											 new System.Data.Common.DataColumnMapping( "Administrador", "Administrador" ),
																											 new System.Data.Common.DataColumnMapping( "ClaveNuncaCaduca", "ClaveNuncaCaduca" ),
																											 new System.Data.Common.DataColumnMapping( "PermiteCambioClave", "PermiteCambioClave" ),
																											 new System.Data.Common.DataColumnMapping( "ResponsableUltimaModificacion", "ResponsableUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "PerfilUtilizado", "PerfilUtilizado" ),
																											 new System.Data.Common.DataColumnMapping( "Activo", "Activo" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdPersona", "IdPersona" ),
																											 new System.Data.Common.DataColumnMapping( "Equipo", "Equipo" )
																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_sy_Usuarios_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdUsuario", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Nombre", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Nombre", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Clave", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Clave", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CantidadConexionesFallida", SqlDbType.TinyInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CantidadConexionesFallida", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaConexion", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaConexion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Expiracion", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Expiracion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@DiasValidezClave", SqlDbType.SmallInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "DiasValidezClave", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@VencimientoClave", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "VencimientoClave", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Bloqueado", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Bloqueado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IntentosPermitidosConexion", SqlDbType.TinyInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IntentosPermitidosConexion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@HabilitacionCuenta", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "HabilitacionCuenta", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Administrador", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Administrador", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ClaveNuncaCaduca", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "ClaveNuncaCaduca", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PermiteCambioClave", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PermiteCambioClave", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ResponsableUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "ResponsableUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PerfilUtilizado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PerfilUtilizado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdPersona", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdPersona", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdUsuario", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdUsuario", DataRowVersion.Original, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Equipo", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Equipo", DataRowVersion.Current, null ) );

			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_sy_Usuarios_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdUsuario", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );
			
			SqlCommand sqlCommandInsert = new SqlCommand("Pr_sy_Usuarios_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdUsuario", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdUsuario", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Nombre", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Nombre", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Clave", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Clave", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CantidadConexionesFallida", SqlDbType.TinyInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CantidadConexionesFallida", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@UltimaConexion", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaConexion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Expiracion", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Expiracion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@DiasValidezClave", SqlDbType.SmallInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "DiasValidezClave", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@VencimientoClave", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "VencimientoClave", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Bloqueado", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Bloqueado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IntentosPermitidosConexion", SqlDbType.TinyInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IntentosPermitidosConexion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@HabilitacionCuenta", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "HabilitacionCuenta", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Administrador", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Administrador", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@ClaveNuncaCaduca", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "ClaveNuncaCaduca", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PermiteCambioClave", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "PermiteCambioClave", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@ResponsableUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "ResponsableUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PerfilUtilizado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "PerfilUtilizado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdPersona", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdPersona", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Equipo", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Equipo", DataRowVersion.Current, null ) );

			#region Replicacion

			_replication = replication;
			adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);

			#endregion
			adapter.UpdateCommand = sqlCommandUpdate;
			adapter.DeleteCommand = sqlCommandDelete;
			adapter.InsertCommand = sqlCommandInsert;
			adapter.Update ( dataTable );
		}

		private static SentenciasReplicacion _replication;
		public static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
		{
			try
			{		
				StatementSQLForReplicationFactory.GetSqlStatement(e.Command, _replication.Sentence);
				if(_replication.IdTipoDeSentencia == null || _replication.IdTipoDeSentencia.Equals(string.Empty))
					_replication.IdTipoDeSentencia = e.StatementType.ToString().ToUpper();
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}					
		}		
		public void Dispose()
		{
		}

		
	}
}


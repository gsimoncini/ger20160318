namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Data.SqlClient;
	using System.Text.RegularExpressions;
	using System.Collections;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_Usuarios : IDisposable
	{
	
		#region Custom Members
		/// <summary>
		/// Obtiene la lista de la tabla sy_Usuarios de aquellos usuarios activos
		/// </summary>
		/*public static System.Data.DataSet GetListActivos()
		{			
			System.Data.DataSet data = new DataSet();
			return mz.erp.dataaccess.sy_Usuarios.GetListActivos(data);
		}*/
		/// <summary>
		/// Obtiene la lista completa de la tabla sy_Usuarios
		/// </summary>
		/// 

		public static System.Data.DataTable GetUsuariosActivosSegunPerfiles(string Perfiles)
		{
			return mz.erp.dataaccess.sy_Usuarios.GetUsuariosActivosSegunPerfiles(Perfiles);
		}

		public static System.Data.DataTable GetListActivos()
		{
			sy_UsuariosDataset data = mz.erp.dataaccess.sy_Usuarios.GetList();
			//DataView dv = new DataView( data.sy_Usuarios, "Activo = true", string.Empty, DataViewRowState.OriginalRows);			
			//DataTable table = dv.Table.Clone();		
			DataTable table = data.sy_Usuarios.Clone();
			System.Data.DataRow [] rows = data.sy_Usuarios.Select("Activo = true");
			foreach (DataRow row in rows) 
			{
				table.ImportRow(row);
			}			
			return table;			
		}

		public static sy_UsuariosDataset GetListActivos(string PerfilesExcluidos)
		{
			return mz.erp.dataaccess.sy_Usuarios.GetListActivos(PerfilesExcluidos);
		}

		#endregion
		
		public sy_Usuarios()
		{
		}

		public static System.Data.DataSet UsuariosPersonasGetList()
		{
			return mz.erp.dataaccess.sy_Usuarios.UsuariosPersonasGetList();
		}

        public static System.Data.DataSet UsuariosPersonasGetList(bool Activos)
        {
            return mz.erp.dataaccess.sy_Usuarios.UsuariosPersonasGetList(Activos);
        }

		public static string GetUsuario(string IdPersona)
		{
			DataSet data = mz.erp.dataaccess.sy_Usuarios.UsuariosPersonasGetList(IdPersona);
			return Convert.ToString(data.Tables[0].Rows[0]["IdUsuario"]);
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_Usuarios
		/// </summary>
		public static sy_UsuariosDataset GetList()
		{
			return mz.erp.dataaccess.sy_Usuarios.GetList();
		}
		
		public static sy_UsuariosDataset GetListByIdPersona(string IdPersona)
		{
			return mz.erp.dataaccess.sy_Usuarios.GetListByIdPersona( IdPersona);
		}
		/// <summary>
		/// Obtiene tabla sy_Usuarios filtrada por las condiciones de bsqueda
		/// </summary>
		//public static sy_UsuariosDataset GetList( string IdUsuario, string Nombre, string Clave, byte CantidadConexionesFallida, DateTime UltimaConexion, DateTime Expiracion, short DiasValidezClave, DateTime VencimientoClave, bool Bloqueado, byte IntentosPermitidosConexion, DateTime HabilitacionCuenta, bool Administrador, bool ClaveNuncaCaduca, bool PermiteCambioClave, long ResponsableUltimaModificacion, long PerfilUtilizado, bool Activo, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId )
		public static sy_UsuariosDataset GetList( string IdUsuario, string Nombre )
		{
			//return mz.erp.dataaccess.sy_Usuarios.GetList( IdUsuario, Nombre, Clave, CantidadConexionesFallida, UltimaConexion, Expiracion, DiasValidezClave, VencimientoClave, Bloqueado, IntentosPermitidosConexion, HabilitacionCuenta, Administrador, ClaveNuncaCaduca, PermiteCambioClave, ResponsableUltimaModificacion, PerfilUtilizado, Activo, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, RowId );
			return mz.erp.dataaccess.sy_Usuarios.GetList( IdUsuario, Nombre);
		}

		/*public static sy_UsuariosDataset GetList( string IdUsuario, string Nombre)
		{
			/*string Clave;
			byte CantidadConexionesFallida;
			DateTime UltimaConexion;
			DateTime Expiracion;
			short DiasValidezClave;
			DateTime VencimientoClave;
			bool Bloqueado;
			byte IntentosPermitidosConexion;
			DateTime HabilitacionCuenta;
			bool Administrador;
			bool ClaveNuncaCaduca;
			bool PermiteCambioClave;
			long ResponsableUltimaModificacion;
			long PerfilUtilizado;
			bool Activo;
			DateTime FechaCreacion;
			long IdConexionCreacion;
			byte[] UltimaModificacion;
			long IdConexionUltimaModificacion;
			Guid RowId;

			string Clave = string.Empty;
			byte CantidadConexionesFallida = 0;
			DateTime UltimaConexion = mz.erp.businessrules.Sistema.DateTime.Now;
			DateTime Expiracion = mz.erp.businessrules.Sistema.DateTime.Now;
			short DiasValidezClave = 0;
			DateTime VencimientoClave = mz.erp.businessrules.Sistema.DateTime.Now;
			bool Bloqueado = false;
			byte IntentosPermitidosConexion = 0;
			DateTime HabilitacionCuenta = mz.erp.businessrules.Sistema.DateTime.Now;
			bool Administrador = false;
			bool ClaveNuncaCaduca = false;
			bool PermiteCambioClave = false;
			long ResponsableUltimaModificacion = 0;
			long PerfilUtilizado = 0;
			bool Activo = false;
			DateTime FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			long IdConexionCreacion = Security.IdConexion;
			byte[] UltimaModificacion = null;
			long IdConexionUltimaModificacion = Security.IdConexion;
			Guid RowId = Guid.Empty;

			return mz.erp.dataaccess.sy_Usuarios.GetList( IdUsuario, Nombre, Clave, CantidadConexionesFallida, UltimaConexion, Expiracion, DiasValidezClave, VencimientoClave, Bloqueado, IntentosPermitidosConexion, HabilitacionCuenta, Administrador, ClaveNuncaCaduca, PermiteCambioClave, ResponsableUltimaModificacion, PerfilUtilizado, Activo, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, RowId );
		}*/

		/// <summary>
		/// Crea un sy_UsuariosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static sy_UsuariosDataset.sy_UsuariosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.sy_Usuarios.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_Usuarios que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_UsuariosDataset.sy_UsuariosRow GetByPk( string IdUsuario )
		{
			sy_UsuariosDataset.sy_UsuariosRow row = mz.erp.dataaccess.sy_Usuarios.GetByPk( IdUsuario  );
			if (row == null) 
			{
				return null;
			}

			foreach ( DataColumn dc in row.Table.Columns ) 
			{
				if (row[dc] == System.DBNull.Value)
				{
					row[dc] = Util.DefaultValue( dc.DataType );
				}
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_Usuarios que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static sy_UsuariosDataset.sy_UsuariosRow GetByPk( object IdUsuario )
		{
			return GetByPk( ( string )IdUsuario );
		}

		/// <summary>
		/// Establece los valores por defecto de sy_UsuariosRow.
		/// </summary>
		public static sy_UsuariosDataset.sy_UsuariosRow SetRowDefaultValues( sy_UsuariosDataset.sy_UsuariosRow row )
		{
			row.IdUsuario = string.Empty; 
			row.Nombre = string.Empty;
			row.Clave = string.Empty;
			row.CantidadConexionesFallida = 0;
			row.UltimaConexion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.Expiracion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.DiasValidezClave = 0;
			row.VencimientoClave = mz.erp.businessrules.Sistema.DateTime.Now;
			row.Bloqueado = false;
			row.IntentosPermitidosConexion = 0;
			row.HabilitacionCuenta = mz.erp.businessrules.Sistema.DateTime.Now;
			row.Administrador = false;
			row.ClaveNuncaCaduca = false;
			row.PermiteCambioClave = false;
			row.ResponsableUltimaModificacion = 0;
			row.PerfilUtilizado = 0;
			row.Activo = true;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
		//	row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;
			row.IdPersona = string.Empty;
			row.PerfilUtilizado=0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del sy_UsuariosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( sy_UsuariosDataset.sy_UsuariosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del sy_UsuariosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( sy_UsuariosDataset.sy_UsuariosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del sy_UsuariosRow a la base de datos.
		/// </summary>
		public static void Update( sy_UsuariosDataset.sy_UsuariosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Usuarios.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_UsuariosDataset a la base de datos.
		/// </summary>
		public static void Update( sy_UsuariosDataset data )
		{
			ApplicationAssert.Check( data != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( data.sy_Usuarios.Rows.Count > 0, "La tabla data.sy_UsuariosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Usuarios.Update( data );
		}
		

		/// <summary>
		/// Envia los cambios del sy_UsuariosDataset a la base de datos.
		/// </summary>
		public static void Update( sy_UsuariosDataset data, SqlTransaction trx, SentenciasReplicacion replicacion)
		{		
			mz.erp.dataaccess.sy_Usuarios.Update( (DataTable) data.sy_Usuarios, trx, replicacion );
		}	


		/// <summary>
		/// Envia los cambios del sy_UsuariosDataset.sy_UsuariosDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_UsuariosDataset.sy_UsuariosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Usuarios.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_UsuariosRow.
		/// </summary>
		public static bool RowIsValid( System.Data.DataRow  row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			isValid = !row.HasErrors;
			if ( !IdUsuarioIsValid( row["IdUsuario"], out mensaje) )
			{ 
				row.SetColumnError( "IdUsuario" , mensaje);
				isValid=false;
			
			}
						
			if ( !NombreIsValid( row["Nombre"], out mensaje) )
			{ 
				row.SetColumnError( "Nombre" , mensaje);
				isValid=false;
			
			}
						
			if ( !ClaveIsValid( row["Clave"], out mensaje) )
			{ 
				row.SetColumnError( "Clave" , mensaje);
				isValid=false;
			
			}
						
			if ( !CantidadConexionesFallidaIsValid( row["CantidadConexionesFallida"], out mensaje) )
			{ 
				row.SetColumnError( "CantidadConexionesFallida" , mensaje);
				isValid=false;
			
			}
						
			if ( !UltimaConexionIsValid( row["UltimaConexion"], out mensaje) )
			{ 
				row.SetColumnError( "UltimaConexion" , mensaje);
				isValid=false;
			
			}
						
			if ( !ExpiracionIsValid( row["Expiracion"], out mensaje) )
			{ 
				row.SetColumnError( "Expiracion" , mensaje);
				isValid=false;
			
			}
						
			if ( !DiasValidezClaveIsValid( row["DiasValidezClave"], out mensaje) )
			{ 
				row.SetColumnError( "DiasValidezClave" , mensaje);
				isValid=false;
			
			}
						
			if ( !VencimientoClaveIsValid( row["VencimientoClave"], out mensaje) )
			{ 
				row.SetColumnError( "VencimientoClave" , mensaje);
				isValid=false;
			
			}
						
			if ( !BloqueadoIsValid( row["Bloqueado"], out mensaje) )
			{ 
				row.SetColumnError( "Bloqueado" , mensaje);
				isValid=false;
			
			}
						
			if ( !IntentosPermitidosConexionIsValid( row["IntentosPermitidosConexion"], out mensaje) )
			{ 
				row.SetColumnError( "IntentosPermitidosConexion" , mensaje);
				isValid=false;
			
			}
						
			if ( !HabilitacionCuentaIsValid( row["HabilitacionCuenta"], out mensaje) )
			{ 
				row.SetColumnError( "HabilitacionCuenta" , mensaje);
				isValid=false;
			
			}
						
			if ( !AdministradorIsValid( row["Administrador"], out mensaje) )
			{ 
				row.SetColumnError( "Administrador" , mensaje);
				isValid=false;
			
			}
						
			if ( !ClaveNuncaCaducaIsValid( row["ClaveNuncaCaduca"], out mensaje) )
			{ 
				row.SetColumnError( "ClaveNuncaCaduca" , mensaje);
				isValid=false;
			
			}
						
			if ( !PermiteCambioClaveIsValid( row["PermiteCambioClave"], out mensaje) )
			{ 
				row.SetColumnError( "PermiteCambioClave" , mensaje);
				isValid=false;
			
			}
						
			if ( !ResponsableUltimaModificacionIsValid( row["ResponsableUltimaModificacion"], out mensaje) )
			{ 
				row.SetColumnError( "ResponsableUltimaModificacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !PerfilUtilizadoIsValid( row["PerfilUtilizado"], out mensaje) )
			{ 
				row.SetColumnError( "PerfilUtilizado" , mensaje);
				isValid=false;
			
			}
						
			if ( !ActivoIsValid( row["Activo"], out mensaje) )
			{ 
				row.SetColumnError( "Activo" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaCreacionIsValid( row["FechaCreacion"], out mensaje) )
			{ 
				row.SetColumnError( "FechaCreacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConexionCreacionIsValid( row["IdConexionCreacion"], out mensaje) )
			{ 
				row.SetColumnError( "IdConexionCreacion" , mensaje);
				isValid=false;
			
			}
						
		/*	if ( !UltimaModificacionIsValid( row["UltimaModificacion"], out mensaje) )
			{ 
				row.SetColumnError( "UltimaModificacion" , mensaje);
				isValid=false;
			
			}*/
						
			if ( !IdConexionUltimaModificacionIsValid( row["IdConexionUltimaModificacion"], out mensaje) )
			{ 
				row.SetColumnError( "IdConexionUltimaModificacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !RowIdIsValid( row["RowId"], out mensaje) )
			{ 
				row.SetColumnError( "RowId" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdPersonaIsValid( row["IdPersona"], out mensaje) )
			{ 
				row.SetColumnError( "IdPersona" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdUsuario.
		/// </summary>
		public static bool IdUsuarioIsValid( object IdUsuario , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdUsuario. Metodo Sobrecargado
		/// </summary>
		public static bool IdUsuarioIsValid( object IdUsuario)
		{
			string mensaje;
			return IdUsuarioIsValid( IdUsuario, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Nombre.
		/// </summary>
		public static bool NombreIsValid( object Nombre , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Nombre. Metodo Sobrecargado
		/// </summary>
		public static bool NombreIsValid( object Nombre)
		{
			string mensaje;
			return NombreIsValid( Nombre, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Clave.
		/// </summary>
		public static bool ClaveIsValid( object  Clave , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Clave. Metodo Sobrecargado
		/// </summary>
		public static bool ClaveIsValid( object  Clave)
		{
			string mensaje;
			return ClaveIsValid( Clave, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CantidadConexionesFallida.
		/// </summary>
		public static bool CantidadConexionesFallidaIsValid( object  CantidadConexionesFallida , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CantidadConexionesFallida. Metodo Sobrecargado
		/// </summary>
		public static bool CantidadConexionesFallidaIsValid( object  CantidadConexionesFallida)
		{
			string mensaje;
			return CantidadConexionesFallidaIsValid( CantidadConexionesFallida, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo UltimaConexion.
		/// </summary>
		public static bool UltimaConexionIsValid( object  UltimaConexion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo UltimaConexion. Metodo Sobrecargado
		/// </summary>
		public static bool UltimaConexionIsValid( object  UltimaConexion)
		{
			string mensaje;
			return UltimaConexionIsValid( UltimaConexion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Expiracion.
		/// </summary>
		public static bool ExpiracionIsValid( object  Expiracion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Expiracion. Metodo Sobrecargado
		/// </summary>
		public static bool ExpiracionIsValid( object  Expiracion)
		{
			string mensaje;
			return ExpiracionIsValid( Expiracion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo DiasValidezClave.
		/// </summary>
		public static bool DiasValidezClaveIsValid( object  DiasValidezClave , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo DiasValidezClave. Metodo Sobrecargado
		/// </summary>
		public static bool DiasValidezClaveIsValid( object DiasValidezClave)
		{
			string mensaje;
			return DiasValidezClaveIsValid( DiasValidezClave, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo VencimientoClave.
		/// </summary>
		public static bool VencimientoClaveIsValid( object  VencimientoClave , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo VencimientoClave. Metodo Sobrecargado
		/// </summary>
		public static bool VencimientoClaveIsValid( object  VencimientoClave)
		{
			string mensaje;
			return VencimientoClaveIsValid( VencimientoClave, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Bloqueado.
		/// </summary>
		public static bool BloqueadoIsValid( object  Bloqueado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Bloqueado. Metodo Sobrecargado
		/// </summary>
		public static bool BloqueadoIsValid( object  Bloqueado)
		{
			string mensaje;
			return BloqueadoIsValid( Bloqueado, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IntentosPermitidosConexion.
		/// </summary>
		public static bool IntentosPermitidosConexionIsValid( object  IntentosPermitidosConexion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IntentosPermitidosConexion. Metodo Sobrecargado
		/// </summary>
		public static bool IntentosPermitidosConexionIsValid( object  IntentosPermitidosConexion)
		{
			string mensaje;
			return IntentosPermitidosConexionIsValid( IntentosPermitidosConexion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo HabilitacionCuenta.
		/// </summary>
		public static bool HabilitacionCuentaIsValid( object  HabilitacionCuenta , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo HabilitacionCuenta. Metodo Sobrecargado
		/// </summary>
		public static bool HabilitacionCuentaIsValid( object  HabilitacionCuenta)
		{
			string mensaje;
			return HabilitacionCuentaIsValid( HabilitacionCuenta, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Administrador.
		/// </summary>
		public static bool AdministradorIsValid( object  Administrador , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Administrador. Metodo Sobrecargado
		/// </summary>
		public static bool AdministradorIsValid( object  Administrador)
		{
			string mensaje;
			return AdministradorIsValid( Administrador, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo ClaveNuncaCaduca.
		/// </summary>
		public static bool ClaveNuncaCaducaIsValid( object ClaveNuncaCaduca , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ClaveNuncaCaduca. Metodo Sobrecargado
		/// </summary>
		public static bool ClaveNuncaCaducaIsValid( object ClaveNuncaCaduca)
		{
			string mensaje;
			return ClaveNuncaCaducaIsValid( ClaveNuncaCaduca, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo PermiteCambioClave.
		/// </summary>
		public static bool PermiteCambioClaveIsValid( object PermiteCambioClave , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo PermiteCambioClave. Metodo Sobrecargado
		/// </summary>
		public static bool PermiteCambioClaveIsValid( object PermiteCambioClave)
		{
			string mensaje;
			return PermiteCambioClaveIsValid( PermiteCambioClave, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo ResponsableUltimaModificacion.
		/// </summary>
		public static bool ResponsableUltimaModificacionIsValid( object ResponsableUltimaModificacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ResponsableUltimaModificacion. Metodo Sobrecargado
		/// </summary>
		public static bool ResponsableUltimaModificacionIsValid( object ResponsableUltimaModificacion)
		{
			string mensaje;
			return ResponsableUltimaModificacionIsValid( ResponsableUltimaModificacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo PerfilUtilizado.
		/// </summary>
		public static bool PerfilUtilizadoIsValid( object PerfilUtilizado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo PerfilUtilizado. Metodo Sobrecargado
		/// </summary>
		public static bool PerfilUtilizadoIsValid( object PerfilUtilizado)
		{
			string mensaje;
			return PerfilUtilizadoIsValid( PerfilUtilizado, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Activo.
		/// </summary>
		public static bool ActivoIsValid( object Activo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Activo. Metodo Sobrecargado
		/// </summary>
		public static bool ActivoIsValid( object Activo)
		{
			string mensaje;
			return ActivoIsValid( Activo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaCreacion.
		/// </summary>
		public static bool FechaCreacionIsValid( object FechaCreacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaCreacion. Metodo Sobrecargado
		/// </summary>
		public static bool FechaCreacionIsValid( object FechaCreacion)
		{
			string mensaje;
			return FechaCreacionIsValid( FechaCreacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdConexionCreacion.
		/// </summary>
		public static bool IdConexionCreacionIsValid( object IdConexionCreacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexionCreacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConexionCreacionIsValid( object IdConexionCreacion)
		{
			string mensaje;
			return IdConexionCreacionIsValid( IdConexionCreacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo UltimaModificacion.
		/// </summary>
		public static bool UltimaModificacionIsValid(object UltimaModificacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo UltimaModificacion. Metodo Sobrecargado
		/// </summary>
		public static bool UltimaModificacionIsValid( object UltimaModificacion)
		{
			string mensaje;
			return UltimaModificacionIsValid( UltimaModificacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdConexionUltimaModificacion.
		/// </summary>
		public static bool IdConexionUltimaModificacionIsValid( object IdConexionUltimaModificacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexionUltimaModificacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConexionUltimaModificacionIsValid( object IdConexionUltimaModificacion)
		{
			string mensaje;
			return IdConexionUltimaModificacionIsValid( IdConexionUltimaModificacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo RowId.
		/// </summary>
		public static bool RowIdIsValid( object RowId , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo RowId. Metodo Sobrecargado
		/// </summary>
		public static bool RowIdIsValid( object RowId)
		{
			string mensaje;
			return RowIdIsValid( RowId, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdPersona.
		/// </summary>
		public static bool IdPersonaIsValid( object IdPersona , out string mensaje )
		{
			//Agregar cdigo de validacin
			if ((string )IdPersona == "")
			{
				mensaje = "La Perona no puede ser nula";
				return false;
			}
			else
			{
				mensaje="";
				return true;
			}
		}
		
		/// <summary>
		/// Valida el campo IdPersona. Metodo Sobrecargado
		/// </summary>
		public static bool IdPersonaIsValid( object IdPersona)
		{
			string mensaje;
			return IdPersonaIsValid( IdPersona, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}


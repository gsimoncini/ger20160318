namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_PerfilesUsuariosEmpresas : IDisposable
	{
	
		#region Custom Members
		public static sy_PerfilesUsuariosEmpresasDataset GetList(long IdPerfil, long IdEmpresa )
		{
			return GetList( string.Empty, IdPerfil, IdEmpresa );
		}
		#endregion
		
		public sy_PerfilesUsuariosEmpresas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_PerfilesUsuariosEmpresas
		/// </summary>
		public static sy_PerfilesUsuariosEmpresasDataset GetList()
		{
			return mz.erp.dataaccess.sy_PerfilesUsuariosEmpresas.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla sy_PerfilesUsuariosEmpresas filtrada por las condiciones de bsqueda
		/// </summary>
		public static sy_PerfilesUsuariosEmpresasDataset GetList( string IdUsuario, long IdPerfil, long IdEmpresa )
		{
			return mz.erp.dataaccess.sy_PerfilesUsuariosEmpresas.GetList( IdUsuario, IdPerfil, IdEmpresa );
		}

		/// <summary>
		/// Obtiene tabla sy_PerfilesUsuariosEmpresas filtrada por las condiciones de bsqueda
		/// </summary>
		public static sy_PerfilesUsuariosEmpresasDataset GetList( string IdUsuario, long IdEmpresa )
		{
			long IdPerfil = long.MinValue;
			return mz.erp.dataaccess.sy_PerfilesUsuariosEmpresas.GetList( IdUsuario, IdPerfil, IdEmpresa );
		}

		/// <summary>
		/// Crea un sy_PerfilesUsuariosEmpresasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.sy_PerfilesUsuariosEmpresas.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_PerfilesUsuariosEmpresas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasRow GetByPk( string IdUsuario, long IdPerfil, long IdEmpresa )
		{
			sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasRow row = mz.erp.dataaccess.sy_PerfilesUsuariosEmpresas.GetByPk( IdUsuario, IdPerfil, IdEmpresa  );
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
		/// Obtiene un registro de la tabla sy_PerfilesUsuariosEmpresas que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasRow GetByPk( object IdUsuario, object  IdPerfil ,object  IdEmpresa )
		{
			return GetByPk( ( string )IdUsuario, ( long )IdPerfil, ( long )IdEmpresa );
		}

		/// <summary>
		/// Establece los valores por defecto de sy_PerfilesUsuariosEmpresasRow.
		/// </summary>
		public static sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasRow SetRowDefaultValues( sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasRow row )
		{
			row.IdUsuario = Util.NewStringId(); 
			row.IdPerfil = 0; 
			row.IdEmpresa = Security.IdEmpresa; 
			row.ConexionDefault = 0;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del sy_PerfilesUsuariosEmpresasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del sy_PerfilesUsuariosEmpresasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del sy_PerfilesUsuariosEmpresasRow a la base de datos.
		/// </summary>
		public static void Update( sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_PerfilesUsuariosEmpresas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_PerfilesUsuariosEmpresasDataset a la base de datos.
		/// </summary>
		public static void Update( sy_PerfilesUsuariosEmpresasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_PerfilesUsuariosEmpresas.Rows.Count > 0, "La tabla dataSet.sy_PerfilesUsuariosEmpresasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_PerfilesUsuariosEmpresas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_PerfilesUsuariosEmpresas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_PerfilesUsuariosEmpresasRow.
		/// </summary>
		public static bool RowIsValid( System.Data.DataRow  row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdUsuarioIsValid( (string )row["IdUsuario"], out mensaje) )
			{ 
				row.SetColumnError( "IdUsuario" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdPerfilIsValid( (long)row["IdPerfil"], out mensaje) )
			{ 
				row.SetColumnError( "IdPerfil" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEmpresaIsValid( (long)row["IdEmpresa"], out mensaje) )
			{ 
				row.SetColumnError( "IdEmpresa" , mensaje);
				isValid=false;
			
			}
						
			/*if ( !ConexionDefaultIsValid( (byte)row["ConexionDefault"], out mensaje) )
			{ 
				row.SetColumnError( "ConexionDefault" , mensaje);
				isValid=false;
			
			}*/
						
			/*if ( !FechaCreacionIsValid( (DateTime)row["FechaCreacion"], out mensaje) )
			{ 
				row.SetColumnError( "FechaCreacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConexionCreacionIsValid( (long)row["IdConexionCreacion"], out mensaje) )
			{ 
				row.SetColumnError( "IdConexionCreacion" , mensaje);
				isValid=false;
			
			}
						
			/*if ( !UltimaModificacionIsValid( (byte[])row["UltimaModificacion"], out mensaje) )
			{ 
				row.SetColumnError( "UltimaModificacion" , mensaje);
				isValid=false;
			
			}*/
						
			/*if ( !IdConexionUltimaModificacionIsValid( (long)row["IdConexionUltimaModificacion"], out mensaje) )
			{ 
				row.SetColumnError( "IdConexionUltimaModificacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !RowIdIsValid( (Guid)row["RowId"], out mensaje) )
			{ 
				row.SetColumnError( "RowId" , mensaje);
				isValid=false;
			
			}
			;*/
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdUsuario.
		/// </summary>
		public static bool IdUsuarioIsValid( string IdUsuario , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdUsuario. Metodo Sobrecargado
		/// </summary>
		public static bool IdUsuarioIsValid( string IdUsuario)
		{
			string mensaje;
			return IdUsuarioIsValid( IdUsuario, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdPerfil.
		/// </summary>
		public static bool IdPerfilIsValid( long IdPerfil , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdPerfil. Metodo Sobrecargado
		/// </summary>
		public static bool IdPerfilIsValid( long IdPerfil)
		{
			string mensaje;
			return IdPerfilIsValid( IdPerfil, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdEmpresa.
		/// </summary>
		public static bool IdEmpresaIsValid( long IdEmpresa , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEmpresa. Metodo Sobrecargado
		/// </summary>
		public static bool IdEmpresaIsValid( long IdEmpresa)
		{
			string mensaje;
			return IdEmpresaIsValid( IdEmpresa, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo ConexionDefault.
		/// </summary>
		public static bool ConexionDefaultIsValid( byte ConexionDefault , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ConexionDefault. Metodo Sobrecargado
		/// </summary>
		public static bool ConexionDefaultIsValid( byte ConexionDefault)
		{
			string mensaje;
			return ConexionDefaultIsValid( ConexionDefault, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaCreacion.
		/// </summary>
		public static bool FechaCreacionIsValid( DateTime FechaCreacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaCreacion. Metodo Sobrecargado
		/// </summary>
		public static bool FechaCreacionIsValid( DateTime FechaCreacion)
		{
			string mensaje;
			return FechaCreacionIsValid( FechaCreacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdConexionCreacion.
		/// </summary>
		public static bool IdConexionCreacionIsValid( long IdConexionCreacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexionCreacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConexionCreacionIsValid( long IdConexionCreacion)
		{
			string mensaje;
			return IdConexionCreacionIsValid( IdConexionCreacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo UltimaModificacion.
		/// </summary>
		public static bool UltimaModificacionIsValid( byte[] UltimaModificacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo UltimaModificacion. Metodo Sobrecargado
		/// </summary>
		public static bool UltimaModificacionIsValid( byte[] UltimaModificacion)
		{
			string mensaje;
			return UltimaModificacionIsValid( UltimaModificacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdConexionUltimaModificacion.
		/// </summary>
		public static bool IdConexionUltimaModificacionIsValid( long IdConexionUltimaModificacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexionUltimaModificacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConexionUltimaModificacionIsValid( long IdConexionUltimaModificacion)
		{
			string mensaje;
			return IdConexionUltimaModificacionIsValid( IdConexionUltimaModificacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo RowId.
		/// </summary>
		public static bool RowIdIsValid( Guid RowId , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo RowId. Metodo Sobrecargado
		/// </summary>
		public static bool RowIdIsValid( Guid RowId)
		{
			string mensaje;
			return RowIdIsValid( RowId, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}


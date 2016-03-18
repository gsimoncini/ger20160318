namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_Excepciones : IDisposable
	{
	
		#region Custom Members
		
		public static void AddExcepcion(string maquina, string usuario, string version, string excSource, string excType, string excMensaje, string excTargetSite, string excStackTrace, string excInnerException, string excHelpLink, string exception, string appDomain, string codebase) 
		{
			sy_ExcepcionesDataset.sy_ExcepcionesRow	row = businessrules.sy_Excepciones.NewRow();
			row.Machine = maquina;
			row.User = usuario;
			row.Version = version;
			row.Exc_Source = excSource;
			row.Exc_Type = excType;
			row.Exc_Message = excMensaje;
			row.Exc_Site = excTargetSite;
			row.Exc_StackTrace = excStackTrace;
			row.Exc_InnerException = excInnerException;
			row.Exc_HelpLink = excHelpLink;
			row.Exception = exception;
			row.AppDomain = appDomain;
			row.CodeBase	= codebase;
			row.IdSucursal = Security.IdSucursal;
			row.IdEmpresa = Security.IdEmpresa;
			businessrules.sy_Excepciones.Update(row);
		}
		
		#endregion
		
		public sy_Excepciones()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_Excepciones
		/// </summary>
		public static sy_ExcepcionesDataset GetList()
		{
			return mz.erp.dataaccess.sy_Excepciones.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla sy_Excepciones filtrada por las condiciones de bsqueda
		/// </summary>
		/*public static sy_ExcepcionesDataset GetList(  )
		{
			return mz.erp.dataaccess.sy_Excepciones.GetList(  );
		}*/

		/// <summary>
		/// Crea un sy_ExcepcionesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static sy_ExcepcionesDataset.sy_ExcepcionesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.sy_Excepciones.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_Excepciones que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_ExcepcionesDataset.sy_ExcepcionesRow GetByPk( string IdExcepcion )
		{
			sy_ExcepcionesDataset.sy_ExcepcionesRow row = mz.erp.dataaccess.sy_Excepciones.GetByPk( IdExcepcion  );
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
		/// Obtiene un registro de la tabla sy_Excepciones que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static sy_ExcepcionesDataset.sy_ExcepcionesRow GetByPk( object IdExcepcion )
		{
			return GetByPk( ( string )IdExcepcion );
		}

		/// <summary>
		/// Establece los valores por defecto de sy_ExcepcionesRow.
		/// </summary>
		public static sy_ExcepcionesDataset.sy_ExcepcionesRow SetRowDefaultValues( sy_ExcepcionesDataset.sy_ExcepcionesRow row )
		{
			row.IdExcepcion = Util.NewStringId(); 
			row.FechaCreacion = DateTime.Now;
			row.Machine = string.Empty;
			row.User = string.Empty;
			row.Version = string.Empty;
			row.AppDomain = string.Empty;
			row.CodeBase = string.Empty;
			row.Exc_Source = string.Empty;
			row.Exc_Type = string.Empty;
			row.Exc_Message = string.Empty;
			row.Exc_Site = string.Empty;
			row.Exc_StackTrace = string.Empty;
			row.Exc_InnerException = string.Empty;
			row.Exc_HelpLink = string.Empty;
			row.Exception = string.Empty;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = 0;
			row.IdEmpresa = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del sy_ExcepcionesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( sy_ExcepcionesDataset.sy_ExcepcionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del sy_ExcepcionesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( sy_ExcepcionesDataset.sy_ExcepcionesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del sy_ExcepcionesRow a la base de datos.
		/// </summary>
		public static void Update( sy_ExcepcionesDataset.sy_ExcepcionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Excepciones.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_ExcepcionesDataset a la base de datos.
		/// </summary>
		public static void Update( sy_ExcepcionesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_Excepciones.Rows.Count > 0, "La tabla dataSet.sy_ExcepcionesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Excepciones.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_ExcepcionesDataset.sy_ExcepcionesDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_ExcepcionesDataset.sy_ExcepcionesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Excepciones.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_ExcepcionesRow.
		/// </summary>
		public static bool RowIsValid( sy_ExcepcionesDataset.sy_ExcepcionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdExcepcionIsValid( row.IdExcepcion, out mensaje) )
			{ 
				row.SetColumnError( "IdExcepcion" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaCreacionIsValid( row.FechaCreacion, out mensaje) )
			{ 
				row.SetColumnError( "FechaCreacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !MachineIsValid( row.Machine, out mensaje) )
			{ 
				row.SetColumnError( "Machine" , mensaje);
				isValid=false;
			
			}
						
			if ( !UserIsValid( row.User, out mensaje) )
			{ 
				row.SetColumnError( "User" , mensaje);
				isValid=false;
			
			}
						
			if ( !VersionIsValid( row.Version, out mensaje) )
			{ 
				row.SetColumnError( "Version" , mensaje);
				isValid=false;
			
			}
						
			if ( !AppDomainIsValid( row.AppDomain, out mensaje) )
			{ 
				row.SetColumnError( "AppDomain" , mensaje);
				isValid=false;
			
			}
						
			if ( !CodeBaseIsValid( row.CodeBase, out mensaje) )
			{ 
				row.SetColumnError( "CodeBase" , mensaje);
				isValid=false;
			
			}
						
			if ( !Exc_SourceIsValid( row.Exc_Source, out mensaje) )
			{ 
				row.SetColumnError( "Exc_Source" , mensaje);
				isValid=false;
			
			}
						
			if ( !Exc_TypeIsValid( row.Exc_Type, out mensaje) )
			{ 
				row.SetColumnError( "Exc_Type" , mensaje);
				isValid=false;
			
			}
						
			if ( !Exc_MessageIsValid( row.Exc_Message, out mensaje) )
			{ 
				row.SetColumnError( "Exc_Message" , mensaje);
				isValid=false;
			
			}
						
			if ( !Exc_SiteIsValid( row.Exc_Site, out mensaje) )
			{ 
				row.SetColumnError( "Exc_Site" , mensaje);
				isValid=false;
			
			}
						
			if ( !Exc_StackTraceIsValid( row.Exc_StackTrace, out mensaje) )
			{ 
				row.SetColumnError( "Exc_StackTrace" , mensaje);
				isValid=false;
			
			}
						
			if ( !Exc_InnerExceptionIsValid( row.Exc_InnerException, out mensaje) )
			{ 
				row.SetColumnError( "Exc_InnerException" , mensaje);
				isValid=false;
			
			}
						
			if ( !Exc_HelpLinkIsValid( row.Exc_HelpLink, out mensaje) )
			{ 
				row.SetColumnError( "Exc_HelpLink" , mensaje);
				isValid=false;
			
			}
						
			if ( !ExceptionIsValid( row.Exception, out mensaje) )
			{ 
				row.SetColumnError( "Exception" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConexionCreacionIsValid( row.IdConexionCreacion, out mensaje) )
			{ 
				row.SetColumnError( "IdConexionCreacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !UltimaModificacionIsValid( row.UltimaModificacion, out mensaje) )
			{ 
				row.SetColumnError( "UltimaModificacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConexionUltimaModificacionIsValid( row.IdConexionUltimaModificacion, out mensaje) )
			{ 
				row.SetColumnError( "IdConexionUltimaModificacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdReservadoIsValid( row.IdReservado, out mensaje) )
			{ 
				row.SetColumnError( "IdReservado" , mensaje);
				isValid=false;
			
			}
						
			if ( !RowIdIsValid( row.RowId, out mensaje) )
			{ 
				row.SetColumnError( "RowId" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdSucursalIsValid( row.IdSucursal, out mensaje) )
			{ 
				row.SetColumnError( "IdSucursal" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEmpresaIsValid( row.IdEmpresa, out mensaje) )
			{ 
				row.SetColumnError( "IdEmpresa" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdExcepcion.
		/// </summary>
		public static bool IdExcepcionIsValid( string IdExcepcion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdExcepcion. Metodo Sobrecargado
		/// </summary>
		public static bool IdExcepcionIsValid( string IdExcepcion)
		{
			string mensaje;
			return IdExcepcionIsValid( IdExcepcion, out mensaje );
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
		/// Valida el campo Machine.
		/// </summary>
		public static bool MachineIsValid( string Machine , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Machine. Metodo Sobrecargado
		/// </summary>
		public static bool MachineIsValid( string Machine)
		{
			string mensaje;
			return MachineIsValid( Machine, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo User.
		/// </summary>
		public static bool UserIsValid( string User , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo User. Metodo Sobrecargado
		/// </summary>
		public static bool UserIsValid( string User)
		{
			string mensaje;
			return UserIsValid( User, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Version.
		/// </summary>
		public static bool VersionIsValid( string Version , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Version. Metodo Sobrecargado
		/// </summary>
		public static bool VersionIsValid( string Version)
		{
			string mensaje;
			return VersionIsValid( Version, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo AppDomain.
		/// </summary>
		public static bool AppDomainIsValid( string AppDomain , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo AppDomain. Metodo Sobrecargado
		/// </summary>
		public static bool AppDomainIsValid( string AppDomain)
		{
			string mensaje;
			return AppDomainIsValid( AppDomain, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CodeBase.
		/// </summary>
		public static bool CodeBaseIsValid( string CodeBase , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CodeBase. Metodo Sobrecargado
		/// </summary>
		public static bool CodeBaseIsValid( string CodeBase)
		{
			string mensaje;
			return CodeBaseIsValid( CodeBase, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Exc_Source.
		/// </summary>
		public static bool Exc_SourceIsValid( string Exc_Source , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Exc_Source. Metodo Sobrecargado
		/// </summary>
		public static bool Exc_SourceIsValid( string Exc_Source)
		{
			string mensaje;
			return Exc_SourceIsValid( Exc_Source, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Exc_Type.
		/// </summary>
		public static bool Exc_TypeIsValid( string Exc_Type , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Exc_Type. Metodo Sobrecargado
		/// </summary>
		public static bool Exc_TypeIsValid( string Exc_Type)
		{
			string mensaje;
			return Exc_TypeIsValid( Exc_Type, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Exc_Message.
		/// </summary>
		public static bool Exc_MessageIsValid( string Exc_Message , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Exc_Message. Metodo Sobrecargado
		/// </summary>
		public static bool Exc_MessageIsValid( string Exc_Message)
		{
			string mensaje;
			return Exc_MessageIsValid( Exc_Message, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Exc_Site.
		/// </summary>
		public static bool Exc_SiteIsValid( string Exc_Site , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Exc_Site. Metodo Sobrecargado
		/// </summary>
		public static bool Exc_SiteIsValid( string Exc_Site)
		{
			string mensaje;
			return Exc_SiteIsValid( Exc_Site, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Exc_StackTrace.
		/// </summary>
		public static bool Exc_StackTraceIsValid( string Exc_StackTrace , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Exc_StackTrace. Metodo Sobrecargado
		/// </summary>
		public static bool Exc_StackTraceIsValid( string Exc_StackTrace)
		{
			string mensaje;
			return Exc_StackTraceIsValid( Exc_StackTrace, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Exc_InnerException.
		/// </summary>
		public static bool Exc_InnerExceptionIsValid( string Exc_InnerException , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Exc_InnerException. Metodo Sobrecargado
		/// </summary>
		public static bool Exc_InnerExceptionIsValid( string Exc_InnerException)
		{
			string mensaje;
			return Exc_InnerExceptionIsValid( Exc_InnerException, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Exc_HelpLink.
		/// </summary>
		public static bool Exc_HelpLinkIsValid( string Exc_HelpLink , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Exc_HelpLink. Metodo Sobrecargado
		/// </summary>
		public static bool Exc_HelpLinkIsValid( string Exc_HelpLink)
		{
			string mensaje;
			return Exc_HelpLinkIsValid( Exc_HelpLink, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Exception.
		/// </summary>
		public static bool ExceptionIsValid( string Exception , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Exception. Metodo Sobrecargado
		/// </summary>
		public static bool ExceptionIsValid( string Exception)
		{
			string mensaje;
			return ExceptionIsValid( Exception, out mensaje );
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
		/// Valida el campo IdReservado.
		/// </summary>
		public static bool IdReservadoIsValid( long IdReservado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdReservado. Metodo Sobrecargado
		/// </summary>
		public static bool IdReservadoIsValid( long IdReservado)
		{
			string mensaje;
			return IdReservadoIsValid( IdReservado, out mensaje );
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
		
		/// <summary>
		/// Valida el campo IdSucursal.
		/// </summary>
		public static bool IdSucursalIsValid( long IdSucursal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSucursal. Metodo Sobrecargado
		/// </summary>
		public static bool IdSucursalIsValid( long IdSucursal)
		{
			string mensaje;
			return IdSucursalIsValid( IdSucursal, out mensaje );
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
		

		public void Dispose()
		{
		}
		
	}
}


namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_Validaciones : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public sy_Validaciones()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_Validaciones
		/// </summary>
		public static sy_ValidacionesDataset GetList()
		{
			return mz.erp.dataaccess.sy_Validaciones.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla sy_Validaciones filtrada por las condiciones de bsqueda
		/// </summary>
		public static sy_ValidacionesDataset GetList( string IdValidacion, string Validacion, string Titulo, string Mensaje, string TipoMensaje, string Botones, DateTime FechaInicio, DateTime FechaFin, bool Activo, string Key, string Descripcion )
		{
			return mz.erp.dataaccess.sy_Validaciones.GetList( IdValidacion, Validacion, Titulo, Mensaje, TipoMensaje, Botones, FechaInicio, FechaFin, Activo, Key, Descripcion );
		}

		/// <summary>
		/// Crea un sy_ValidacionesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static sy_ValidacionesDataset.sy_ValidacionesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.sy_Validaciones.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_Validaciones que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_ValidacionesDataset.sy_ValidacionesRow GetByPk( string IdValidacion )
		{
			sy_ValidacionesDataset.sy_ValidacionesRow row = mz.erp.dataaccess.sy_Validaciones.GetByPk( IdValidacion  );
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
		/// Obtiene un registro de la tabla sy_Validaciones que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static sy_ValidacionesDataset.sy_ValidacionesRow GetByPk( object IdValidacion )
		{
			return GetByPk( ( string )IdValidacion );
		}

		/// <summary>
		/// Establece los valores por defecto de sy_ValidacionesRow.
		/// </summary>
		public static sy_ValidacionesDataset.sy_ValidacionesRow SetRowDefaultValues( sy_ValidacionesDataset.sy_ValidacionesRow row )
		{
			row.IdValidacion = Util.NewStringId(); 
			row.Validacion = string.Empty;
			row.Titulo = string.Empty;
			row.Mensaje = string.Empty;
			row.TipoMensaje = string.Empty;
			row.Botones = string.Empty;
			row.FechaInicio = DateTime.Now;
			row.FechaFin = DateTime.Now;
			row.Activo = false;
			row.CampoAuxiliar1 = string.Empty;
			row.CampoAuxiliar2 = string.Empty;
			row.CampoAuxiliar3 = string.Empty;
			row.IdSucursal = 0;
			row.IdEmpresa = 0;			
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.Key = string.Empty;
			row.Descripcion = string.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del sy_ValidacionesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( sy_ValidacionesDataset.sy_ValidacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del sy_ValidacionesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( sy_ValidacionesDataset.sy_ValidacionesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del sy_ValidacionesRow a la base de datos.
		/// </summary>
		public static void Update( sy_ValidacionesDataset.sy_ValidacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Validaciones.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_ValidacionesDataset a la base de datos.
		/// </summary>
		public static void Update( sy_ValidacionesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_Validaciones.Rows.Count > 0, "La tabla dataSet.sy_ValidacionesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Validaciones.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_ValidacionesDataset.sy_ValidacionesDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_ValidacionesDataset.sy_ValidacionesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Validaciones.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_ValidacionesRow.
		/// </summary>
		public static bool RowIsValid( sy_ValidacionesDataset.sy_ValidacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdValidacionIsValid( row.IdValidacion, out mensaje) )
			{ 
				row.SetColumnError( "IdValidacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !ValidacionIsValid( row.Validacion, out mensaje) )
			{ 
				row.SetColumnError( "Validacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !TituloIsValid( row.Titulo, out mensaje) )
			{ 
				row.SetColumnError( "Titulo" , mensaje);
				isValid=false;
			
			}
						
			if ( !MensajeIsValid( row.Mensaje, out mensaje) )
			{ 
				row.SetColumnError( "Mensaje" , mensaje);
				isValid=false;
			
			}
						
			if ( !TipoMensajeIsValid( row.TipoMensaje, out mensaje) )
			{ 
				row.SetColumnError( "TipoMensaje" , mensaje);
				isValid=false;
			
			}
						
			if ( !BotonesIsValid( row.Botones, out mensaje) )
			{ 
				row.SetColumnError( "Botones" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaInicioIsValid( row.FechaInicio, out mensaje) )
			{ 
				row.SetColumnError( "FechaInicio" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaFinIsValid( row.FechaFin, out mensaje) )
			{ 
				row.SetColumnError( "FechaFin" , mensaje);
				isValid=false;
			
			}
						
			if ( !ActivoIsValid( row.Activo, out mensaje) )
			{ 
				row.SetColumnError( "Activo" , mensaje);
				isValid=false;
			
			}
						
			if ( !CampoAuxiliar1IsValid( row.CampoAuxiliar1, out mensaje) )
			{ 
				row.SetColumnError( "CampoAuxiliar1" , mensaje);
				isValid=false;
			
			}
						
			if ( !CampoAuxiliar2IsValid( row.CampoAuxiliar2, out mensaje) )
			{ 
				row.SetColumnError( "CampoAuxiliar2" , mensaje);
				isValid=false;
			
			}
						
			if ( !CampoAuxiliar3IsValid( row.CampoAuxiliar3, out mensaje) )
			{ 
				row.SetColumnError( "CampoAuxiliar3" , mensaje);
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
						
			if ( !FechaCreacionIsValid( row.FechaCreacion, out mensaje) )
			{ 
				row.SetColumnError( "FechaCreacion" , mensaje);
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
						
			if ( !KeyIsValid( row.Key, out mensaje) )
			{ 
				row.SetColumnError( "Key" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdValidacion.
		/// </summary>
		public static bool IdValidacionIsValid( string IdValidacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdValidacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdValidacionIsValid( string IdValidacion)
		{
			string mensaje;
			return IdValidacionIsValid( IdValidacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Validacion.
		/// </summary>
		public static bool ValidacionIsValid( string Validacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Validacion. Metodo Sobrecargado
		/// </summary>
		public static bool ValidacionIsValid( string Validacion)
		{
			string mensaje;
			return ValidacionIsValid( Validacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Titulo.
		/// </summary>
		public static bool TituloIsValid( string Titulo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Titulo. Metodo Sobrecargado
		/// </summary>
		public static bool TituloIsValid( string Titulo)
		{
			string mensaje;
			return TituloIsValid( Titulo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Mensaje.
		/// </summary>
		public static bool MensajeIsValid( string Mensaje , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Mensaje. Metodo Sobrecargado
		/// </summary>
		public static bool MensajeIsValid( string Mensaje)
		{
			string mensaje;
			return MensajeIsValid( Mensaje, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo TipoMensaje.
		/// </summary>
		public static bool TipoMensajeIsValid( string TipoMensaje , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo TipoMensaje. Metodo Sobrecargado
		/// </summary>
		public static bool TipoMensajeIsValid( string TipoMensaje)
		{
			string mensaje;
			return TipoMensajeIsValid( TipoMensaje, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Botones.
		/// </summary>
		public static bool BotonesIsValid( string Botones , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Botones. Metodo Sobrecargado
		/// </summary>
		public static bool BotonesIsValid( string Botones)
		{
			string mensaje;
			return BotonesIsValid( Botones, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaInicio.
		/// </summary>
		public static bool FechaInicioIsValid( DateTime FechaInicio , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaInicio. Metodo Sobrecargado
		/// </summary>
		public static bool FechaInicioIsValid( DateTime FechaInicio)
		{
			string mensaje;
			return FechaInicioIsValid( FechaInicio, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaFin.
		/// </summary>
		public static bool FechaFinIsValid( DateTime FechaFin , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaFin. Metodo Sobrecargado
		/// </summary>
		public static bool FechaFinIsValid( DateTime FechaFin)
		{
			string mensaje;
			return FechaFinIsValid( FechaFin, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Activo.
		/// </summary>
		public static bool ActivoIsValid( bool Activo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Activo. Metodo Sobrecargado
		/// </summary>
		public static bool ActivoIsValid( bool Activo)
		{
			string mensaje;
			return ActivoIsValid( Activo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CampoAuxiliar1.
		/// </summary>
		public static bool CampoAuxiliar1IsValid( string CampoAuxiliar1 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CampoAuxiliar1. Metodo Sobrecargado
		/// </summary>
		public static bool CampoAuxiliar1IsValid( string CampoAuxiliar1)
		{
			string mensaje;
			return CampoAuxiliar1IsValid( CampoAuxiliar1, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CampoAuxiliar2.
		/// </summary>
		public static bool CampoAuxiliar2IsValid( string CampoAuxiliar2 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CampoAuxiliar2. Metodo Sobrecargado
		/// </summary>
		public static bool CampoAuxiliar2IsValid( string CampoAuxiliar2)
		{
			string mensaje;
			return CampoAuxiliar2IsValid( CampoAuxiliar2, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CampoAuxiliar3.
		/// </summary>
		public static bool CampoAuxiliar3IsValid( string CampoAuxiliar3 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CampoAuxiliar3. Metodo Sobrecargado
		/// </summary>
		public static bool CampoAuxiliar3IsValid( string CampoAuxiliar3)
		{
			string mensaje;
			return CampoAuxiliar3IsValid( CampoAuxiliar3, out mensaje );
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
		/// Valida el campo Key.
		/// </summary>
		public static bool KeyIsValid( string Key , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Key. Metodo Sobrecargado
		/// </summary>
		public static bool KeyIsValid( string Key)
		{
			string mensaje;
			return KeyIsValid( Key, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Descripcion.
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Descripcion. Metodo Sobrecargado
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion)
		{
			string mensaje;
			return DescripcionIsValid( Descripcion, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}


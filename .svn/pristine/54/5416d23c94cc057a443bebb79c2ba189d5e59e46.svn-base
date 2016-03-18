namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_Cotizacion : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsa_Cotizacion()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_Cotizacion
		/// </summary>
		public static tsa_CotizacionDataset GetList()
		{
			return mz.erp.dataaccess.tsa_Cotizacion.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_Cotizacion filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_CotizacionDataset GetList( long IdCotizacion, string Codigo, DateTime Fecha, DateTime FechaVencimiento, string Descripcion, string IdResponsable, string IdSolicita, string IdCuenta, long IdEstado, long IdCondicionDeVenta, string Observaciones, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsa_Cotizacion.GetList( IdCotizacion, Codigo, Fecha, FechaVencimiento, Descripcion, IdResponsable, IdSolicita, IdCuenta, IdEstado, IdCondicionDeVenta, Observaciones, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsa_CotizacionRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_CotizacionDataset.tsa_CotizacionRow NewRow()
		{
			return mz.erp.dataaccess.tsa_Cotizacion.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_Cotizacion que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_CotizacionDataset.tsa_CotizacionRow GetByPk( long IdCotizacion )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsa_Cotizacion.GetByPk( IdCotizacion ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_CotizacionRow.
		/// </summary>
		public static tsa_CotizacionDataset.tsa_CotizacionRow SetRowDefaultValues( tsa_CotizacionDataset.tsa_CotizacionRow row )
		{
			row.IdCotizacion = 0; 
			row.Codigo = string.Empty;
			row.Fecha = DateTime.Now;
			row.FechaVencimiento = DateTime.Now;
			row.Descripcion = string.Empty;
			row.IdResponsable = string.Empty;
			row.IdSolicita = string.Empty;
			row.IdCuenta = string.Empty;
			row.IdEstado = 0;
			row.IdCondicionDeVenta = 0;
			row.Observaciones = string.Empty;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = 0;
			row.IdEmpresa = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CotizacionRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsa_CotizacionDataset.tsa_CotizacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsa_CotizacionRow a la base de datos.
		/// </summary>
		public static void Update( tsa_CotizacionDataset.tsa_CotizacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_Cotizacion.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_CotizacionDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_CotizacionDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_Cotizacion.Rows.Count > 0, "La tabla dataSet.tsa_CotizacionDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_Cotizacion.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CotizacionDataset.tsa_CotizacionDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_CotizacionDataset.tsa_CotizacionDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_Cotizacion.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_CotizacionRow.
		/// </summary>
		public static bool RowIsValid( tsa_CotizacionDataset.tsa_CotizacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdCotizacionIsValid( row.IdCotizacion ) )
			{ 
				return false;
			}
						
			if ( !CodigoIsValid( row.Codigo ) )
			{ 
				return false;
			}
						
			if ( !FechaIsValid( row.Fecha ) )
			{ 
				return false;
			}
						
			if ( !FechaVencimientoIsValid( row.FechaVencimiento ) )
			{ 
				return false;
			}
						
			if ( !DescripcionIsValid( row.Descripcion ) )
			{ 
				return false;
			}
						
			if ( !IdResponsableIsValid( row.IdResponsable ) )
			{ 
				return false;
			}
						
			if ( !IdSolicitaIsValid( row.IdSolicita ) )
			{ 
				return false;
			}
						
			if ( !IdCuentaIsValid( row.IdCuenta ) )
			{ 
				return false;
			}
						
			if ( !IdEstadoIsValid( row.IdEstado ) )
			{ 
				return false;
			}
						
			if ( !IdCondicionDeVentaIsValid( row.IdCondicionDeVenta ) )
			{ 
				return false;
			}
						
			if ( !ObservacionesIsValid( row.Observaciones ) )
			{ 
				return false;
			}
						
			if ( !FechaCreacionIsValid( row.FechaCreacion ) )
			{ 
				return false;
			}
						
			if ( !IdConexionCreacionIsValid( row.IdConexionCreacion ) )
			{ 
				return false;
			}
						
			if ( !UltimaModificacionIsValid( row.UltimaModificacion ) )
			{ 
				return false;
			}
						
			if ( !IdConexionUltimaModificacionIsValid( row.IdConexionUltimaModificacion ) )
			{ 
				return false;
			}
						
			if ( !IdReservadoIsValid( row.IdReservado ) )
			{ 
				return false;
			}
						
			if ( !RowIdIsValid( row.RowId ) )
			{ 
				return false;
			}
						
			if ( !IdSucursalIsValid( row.IdSucursal ) )
			{ 
				return false;
			}
						
			if ( !IdEmpresaIsValid( row.IdEmpresa ) )
			{ 
				return false;
			}
			;
			
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCotizacion.
		/// </summary>
		public static bool IdCotizacionIsValid( long IdCotizacion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Codigo.
		/// </summary>
		public static bool CodigoIsValid( string Codigo )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Fecha.
		/// </summary>
		public static bool FechaIsValid( DateTime Fecha )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaVencimiento.
		/// </summary>
		public static bool FechaVencimientoIsValid( DateTime FechaVencimiento )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Descripcion.
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdResponsable.
		/// </summary>
		public static bool IdResponsableIsValid( string IdResponsable )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSolicita.
		/// </summary>
		public static bool IdSolicitaIsValid( string IdSolicita )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCuenta.
		/// </summary>
		public static bool IdCuentaIsValid( string IdCuenta )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEstado.
		/// </summary>
		public static bool IdEstadoIsValid( long IdEstado )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCondicionDeVenta.
		/// </summary>
		public static bool IdCondicionDeVentaIsValid( long IdCondicionDeVenta )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Observaciones.
		/// </summary>
		public static bool ObservacionesIsValid( string Observaciones )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaCreacion.
		/// </summary>
		public static bool FechaCreacionIsValid( DateTime FechaCreacion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexionCreacion.
		/// </summary>
		public static bool IdConexionCreacionIsValid( long IdConexionCreacion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo UltimaModificacion.
		/// </summary>
		public static bool UltimaModificacionIsValid( byte[] UltimaModificacion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexionUltimaModificacion.
		/// </summary>
		public static bool IdConexionUltimaModificacionIsValid( long IdConexionUltimaModificacion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdReservado.
		/// </summary>
		public static bool IdReservadoIsValid( long IdReservado )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo RowId.
		/// </summary>
		public static bool RowIdIsValid( Guid RowId )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSucursal.
		/// </summary>
		public static bool IdSucursalIsValid( long IdSucursal )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEmpresa.
		/// </summary>
		public static bool IdEmpresaIsValid( long IdEmpresa )
		{
			//Agregar cdigo de validacin
			return true;
		}
		

		public void Dispose()
		{
		}
		
	}
}


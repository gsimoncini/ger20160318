namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsy_EstadosCotizaciones : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsy_EstadosCotizaciones()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsy_EstadosCotizaciones
		/// </summary>
		public static tsy_EstadosCotizacionesDataset GetList()
		{
			return mz.erp.dataaccess.tsy_EstadosCotizaciones.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsy_EstadosCotizaciones filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsy_EstadosCotizacionesDataset GetList( long IdEstado, string Descripcion, string IdResponsable, bool Sistema, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsy_EstadosCotizaciones.GetList( IdEstado, Descripcion, IdResponsable, Sistema, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsy_EstadosCotizacionesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsy_EstadosCotizacionesDataset.tsy_EstadosCotizacionesRow NewRow()
		{
			return mz.erp.dataaccess.tsy_EstadosCotizaciones.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsy_EstadosCotizaciones que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsy_EstadosCotizacionesDataset.tsy_EstadosCotizacionesRow GetByPk( long IdEstado )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsy_EstadosCotizaciones.GetByPk( IdEstado ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsy_EstadosCotizacionesRow.
		/// </summary>
		public static tsy_EstadosCotizacionesDataset.tsy_EstadosCotizacionesRow SetRowDefaultValues( tsy_EstadosCotizacionesDataset.tsy_EstadosCotizacionesRow row )
		{
			row.IdEstado = 0; 
			row.Descripcion = string.Empty;
			row.IdResponsable = string.Empty;
			row.Sistema = false;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsy_EstadosCotizacionesRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsy_EstadosCotizacionesDataset.tsy_EstadosCotizacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsy_EstadosCotizacionesRow a la base de datos.
		/// </summary>
		public static void Update( tsy_EstadosCotizacionesDataset.tsy_EstadosCotizacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_EstadosCotizaciones.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsy_EstadosCotizacionesDataset a la base de datos.
		/// </summary>
		public static void Update( tsy_EstadosCotizacionesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsy_EstadosCotizaciones.Rows.Count > 0, "La tabla dataSet.tsy_EstadosCotizacionesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_EstadosCotizaciones.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_EstadosCotizacionesDataset.tsy_EstadosCotizacionesDataTable a la base de datos.
		/// </summary>
		public static void Update( tsy_EstadosCotizacionesDataset.tsy_EstadosCotizacionesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_EstadosCotizaciones.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsy_EstadosCotizacionesRow.
		/// </summary>
		public static bool RowIsValid( tsy_EstadosCotizacionesDataset.tsy_EstadosCotizacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdEstadoIsValid( row.IdEstado ) )
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
						
			if ( !SistemaIsValid( row.Sistema ) )
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
						
			if ( !IdEmpresaIsValid( row.IdEmpresa ) )
			{ 
				return false;
			}
			;
			
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
		/// Valida el campo Sistema.
		/// </summary>
		public static bool SistemaIsValid( bool Sistema )
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


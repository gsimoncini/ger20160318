namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_SeguimientoDevoluciones : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_SeguimientoDevoluciones()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_SeguimientoDevoluciones
		/// </summary>
		public static tpu_SeguimientoDevolucionesDataset GetList()
		{
			return mz.erp.dataaccess.tpu_SeguimientoDevoluciones.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_SeguimientoDevoluciones filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_SeguimientoDevolucionesDataset GetList( long IdDevolucion, long IdEstado, DateTime Fecha, string IdResponsable, string Comentario, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tpu_SeguimientoDevoluciones.GetList( IdDevolucion, IdEstado, Fecha, IdResponsable, Comentario, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tpu_SeguimientoDevolucionesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_SeguimientoDevolucionesDataset.tpu_SeguimientoDevolucionesRow NewRow()
		{
			return mz.erp.dataaccess.tpu_SeguimientoDevoluciones.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_SeguimientoDevoluciones que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_SeguimientoDevolucionesDataset.tpu_SeguimientoDevolucionesRow GetByPk( long IdDevolucion, long IdEstado, DateTime Fecha )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tpu_SeguimientoDevoluciones.GetByPk( IdDevolucion, IdEstado, Fecha ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_SeguimientoDevolucionesRow.
		/// </summary>
		public static tpu_SeguimientoDevolucionesDataset.tpu_SeguimientoDevolucionesRow SetRowDefaultValues( tpu_SeguimientoDevolucionesDataset.tpu_SeguimientoDevolucionesRow row )
		{
			row.IdDevolucion = 0; 
			row.IdEstado = 0; 
			row.Fecha = DateTime.Now; 
			row.IdResponsable = string.Empty;
			row.Comentario = string.Empty;
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
		/// Envia los cambios del tpu_SeguimientoDevolucionesRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tpu_SeguimientoDevolucionesDataset.tpu_SeguimientoDevolucionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tpu_SeguimientoDevolucionesRow a la base de datos.
		/// </summary>
		public static void Update( tpu_SeguimientoDevolucionesDataset.tpu_SeguimientoDevolucionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_SeguimientoDevoluciones.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_SeguimientoDevolucionesDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_SeguimientoDevolucionesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_SeguimientoDevoluciones.Rows.Count > 0, "La tabla dataSet.tpu_SeguimientoDevolucionesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_SeguimientoDevoluciones.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_SeguimientoDevolucionesDataset.tpu_SeguimientoDevolucionesDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_SeguimientoDevolucionesDataset.tpu_SeguimientoDevolucionesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_SeguimientoDevoluciones.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_SeguimientoDevolucionesRow.
		/// </summary>
		public static bool RowIsValid( tpu_SeguimientoDevolucionesDataset.tpu_SeguimientoDevolucionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdDevolucionIsValid( row.IdDevolucion ) )
			{ 
				return false;
			}
						
			if ( !IdEstadoIsValid( row.IdEstado ) )
			{ 
				return false;
			}
						
			if ( !FechaIsValid( row.Fecha ) )
			{ 
				return false;
			}
						
			if ( !IdResponsableIsValid( row.IdResponsable ) )
			{ 
				return false;
			}
						
			if ( !ComentarioIsValid( row.Comentario ) )
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
		/// Valida el campo IdDevolucion.
		/// </summary>
		public static bool IdDevolucionIsValid( long IdDevolucion )
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
		/// Valida el campo Fecha.
		/// </summary>
		public static bool FechaIsValid( DateTime Fecha )
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
		/// Valida el campo Comentario.
		/// </summary>
		public static bool ComentarioIsValid( string Comentario )
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


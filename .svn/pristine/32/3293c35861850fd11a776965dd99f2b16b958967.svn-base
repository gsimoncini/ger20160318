namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_MotivosDevoluciones : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_MotivosDevoluciones()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_MotivosDevoluciones
		/// </summary>
		public static tpu_MotivosDevolucionesDataset GetList()
		{
			return mz.erp.dataaccess.tpu_MotivosDevoluciones.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_MotivosDevoluciones filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_MotivosDevolucionesDataset GetList( long IdMotivoDevolucion, string Descripcion, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa )
		{
			return mz.erp.dataaccess.tpu_MotivosDevoluciones.GetList( IdMotivoDevolucion, Descripcion, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
		}

		/// <summary>
		/// Crea un tpu_MotivosDevolucionesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_MotivosDevolucionesDataset.tpu_MotivosDevolucionesRow NewRow()
		{
			return mz.erp.dataaccess.tpu_MotivosDevoluciones.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_MotivosDevoluciones que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_MotivosDevolucionesDataset.tpu_MotivosDevolucionesRow GetByPk( long IdMotivoDevolucion )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tpu_MotivosDevoluciones.GetByPk( IdMotivoDevolucion ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_MotivosDevolucionesRow.
		/// </summary>
		public static tpu_MotivosDevolucionesDataset.tpu_MotivosDevolucionesRow SetRowDefaultValues( tpu_MotivosDevolucionesDataset.tpu_MotivosDevolucionesRow row )
		{
			row.IdMotivoDevolucion = 0; 
			row.Descripcion = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tpu_MotivosDevolucionesRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tpu_MotivosDevolucionesDataset.tpu_MotivosDevolucionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tpu_MotivosDevolucionesRow a la base de datos.
		/// </summary>
		public static void Update( tpu_MotivosDevolucionesDataset.tpu_MotivosDevolucionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_MotivosDevoluciones.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_MotivosDevolucionesDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_MotivosDevolucionesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_MotivosDevoluciones.Rows.Count > 0, "La tabla dataSet.tpu_MotivosDevolucionesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_MotivosDevoluciones.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_MotivosDevolucionesDataset.tpu_MotivosDevolucionesDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_MotivosDevolucionesDataset.tpu_MotivosDevolucionesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_MotivosDevoluciones.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_MotivosDevolucionesRow.
		/// </summary>
		public static bool RowIsValid( tpu_MotivosDevolucionesDataset.tpu_MotivosDevolucionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdMotivoDevolucionIsValid( row.IdMotivoDevolucion ) )
			{ 
				return false;
			}
						
			if ( !DescripcionIsValid( row.Descripcion ) )
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
		/// Valida el campo IdMotivoDevolucion.
		/// </summary>
		public static bool IdMotivoDevolucionIsValid( long IdMotivoDevolucion )
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


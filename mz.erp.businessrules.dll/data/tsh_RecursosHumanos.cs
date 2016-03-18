namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsh_RecursosHumanos : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsh_RecursosHumanos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_RecursosHumanos
		/// </summary>
		public static tsh_RecursosHumanosDataset GetList()
		{
			return mz.erp.dataaccess.tsh_RecursosHumanos.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_RecursosHumanos filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsh_RecursosHumanosDataset GetList( string IdPersona, decimal HorasAportables, string Ubicacion, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsh_RecursosHumanos.GetList( IdPersona, HorasAportables, Ubicacion, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsh_RecursosHumanosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_RecursosHumanosDataset.tsh_RecursosHumanosRow NewRow()
		{
			return mz.erp.dataaccess.tsh_RecursosHumanos.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_RecursosHumanos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_RecursosHumanosDataset.tsh_RecursosHumanosRow GetByPk( string IdPersona )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsh_RecursosHumanos.GetByPk( IdPersona ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_RecursosHumanosRow.
		/// </summary>
		public static tsh_RecursosHumanosDataset.tsh_RecursosHumanosRow SetRowDefaultValues( tsh_RecursosHumanosDataset.tsh_RecursosHumanosRow row )
		{
			row.IdPersona = Util.NewStringId(); 
			row.HorasAportables = 0;
			row.Ubicacion = string.Empty;
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
		/// Envia los cambios del tsh_RecursosHumanosRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsh_RecursosHumanosDataset.tsh_RecursosHumanosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsh_RecursosHumanosRow a la base de datos.
		/// </summary>
		public static void Update( tsh_RecursosHumanosDataset.tsh_RecursosHumanosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_RecursosHumanos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_RecursosHumanosDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_RecursosHumanosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_RecursosHumanos.Rows.Count > 0, "La tabla dataSet.tsh_RecursosHumanosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_RecursosHumanos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_RecursosHumanosDataset.tsh_RecursosHumanosDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_RecursosHumanosDataset.tsh_RecursosHumanosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_RecursosHumanos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_RecursosHumanosRow.
		/// </summary>
		public static bool RowIsValid( tsh_RecursosHumanosDataset.tsh_RecursosHumanosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdPersonaIsValid( row.IdPersona ) )
			{ 
				return false;
			}
						
			if ( !HorasAportablesIsValid( row.HorasAportables ) )
			{ 
				return false;
			}
						
			if ( !UbicacionIsValid( row.Ubicacion ) )
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
		/// Valida el campo IdPersona.
		/// </summary>
		public static bool IdPersonaIsValid( string IdPersona )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo HorasAportables.
		/// </summary>
		public static bool HorasAportablesIsValid( decimal HorasAportables )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Ubicacion.
		/// </summary>
		public static bool UbicacionIsValid( string Ubicacion )
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


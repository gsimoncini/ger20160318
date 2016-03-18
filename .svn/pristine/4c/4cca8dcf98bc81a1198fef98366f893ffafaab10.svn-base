namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tcs_DomiciliosPersonas : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tcs_DomiciliosPersonas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tcs_DomiciliosPersonas
		/// </summary>
		public static tcs_DomiciliosPersonasDataset GetList()
		{
			return mz.erp.dataaccess.tcs_DomiciliosPersonas.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tcs_DomiciliosPersonas filtrada por las condiciones de bsqueda
		/// </summary>
		public static tcs_DomiciliosPersonasDataset GetList( long IdDomicilio, string IdPersona, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa )
		{
			return mz.erp.dataaccess.tcs_DomiciliosPersonas.GetList( IdDomicilio, IdPersona, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
		}

		/// <summary>
		/// Crea un tcs_DomiciliosPersonasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tcs_DomiciliosPersonasDataset.tcs_DomiciliosPersonasRow NewRow()
		{
			return mz.erp.dataaccess.tcs_DomiciliosPersonas.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tcs_DomiciliosPersonas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tcs_DomiciliosPersonasDataset.tcs_DomiciliosPersonasRow GetByPk( long IdDomicilio, string IdPersona )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tcs_DomiciliosPersonas.GetByPk( IdDomicilio, IdPersona ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tcs_DomiciliosPersonasRow.
		/// </summary>
		public static tcs_DomiciliosPersonasDataset.tcs_DomiciliosPersonasRow SetRowDefaultValues( tcs_DomiciliosPersonasDataset.tcs_DomiciliosPersonasRow row )
		{
			row.IdDomicilio = 0; 
			row.IdPersona = Util.NewStringId(); 
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
		/// Envia los cambios del tcs_DomiciliosPersonasRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tcs_DomiciliosPersonasDataset.tcs_DomiciliosPersonasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tcs_DomiciliosPersonasRow a la base de datos.
		/// </summary>
		public static void Update( tcs_DomiciliosPersonasDataset.tcs_DomiciliosPersonasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tcs_DomiciliosPersonas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tcs_DomiciliosPersonasDataset a la base de datos.
		/// </summary>
		public static void Update( tcs_DomiciliosPersonasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tcs_DomiciliosPersonas.Rows.Count > 0, "La tabla dataSet.tcs_DomiciliosPersonasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tcs_DomiciliosPersonas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tcs_DomiciliosPersonasDataset.tcs_DomiciliosPersonasDataTable a la base de datos.
		/// </summary>
		public static void Update( tcs_DomiciliosPersonasDataset.tcs_DomiciliosPersonasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tcs_DomiciliosPersonas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tcs_DomiciliosPersonasRow.
		/// </summary>
		public static bool RowIsValid( tcs_DomiciliosPersonasDataset.tcs_DomiciliosPersonasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdDomicilioIsValid( row.IdDomicilio ) )
			{ 
				return false;
			}
						
			if ( !IdPersonaIsValid( row.IdPersona ) )
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
		/// Valida el campo IdDomicilio.
		/// </summary>
		public static bool IdDomicilioIsValid( long IdDomicilio )
		{
			//Agregar cdigo de validacin
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


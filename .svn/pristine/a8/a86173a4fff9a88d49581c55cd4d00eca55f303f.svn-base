namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsh_DocumentosPersonas : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsh_DocumentosPersonas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_DocumentosPersonas
		/// </summary>
		public static tsh_DocumentosPersonasDataset GetList()
		{
			return mz.erp.dataaccess.tsh_DocumentosPersonas.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_DocumentosPersonas filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsh_DocumentosPersonasDataset GetList( string IdPersona, string IdDocumento, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsh_DocumentosPersonas.GetList( IdPersona, IdDocumento, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsh_DocumentosPersonasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_DocumentosPersonasDataset.tsh_DocumentosPersonasRow NewRow()
		{
			return mz.erp.dataaccess.tsh_DocumentosPersonas.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_DocumentosPersonas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_DocumentosPersonasDataset.tsh_DocumentosPersonasRow GetByPk( string IdPersona, string IdDocumento )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsh_DocumentosPersonas.GetByPk( IdPersona, IdDocumento ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_DocumentosPersonasRow.
		/// </summary>
		public static tsh_DocumentosPersonasDataset.tsh_DocumentosPersonasRow SetRowDefaultValues( tsh_DocumentosPersonasDataset.tsh_DocumentosPersonasRow row )
		{
			row.IdPersona = Util.NewStringId(); 
			row.IdDocumento = Util.NewStringId(); 
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
		/// Envia los cambios del tsh_DocumentosPersonasRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsh_DocumentosPersonasDataset.tsh_DocumentosPersonasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsh_DocumentosPersonasRow a la base de datos.
		/// </summary>
		public static void Update( tsh_DocumentosPersonasDataset.tsh_DocumentosPersonasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_DocumentosPersonas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_DocumentosPersonasDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_DocumentosPersonasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_DocumentosPersonas.Rows.Count > 0, "La tabla dataSet.tsh_DocumentosPersonasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_DocumentosPersonas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_DocumentosPersonasDataset.tsh_DocumentosPersonasDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_DocumentosPersonasDataset.tsh_DocumentosPersonasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_DocumentosPersonas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_DocumentosPersonasRow.
		/// </summary>
		public static bool RowIsValid( tsh_DocumentosPersonasDataset.tsh_DocumentosPersonasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdPersonaIsValid( row.IdPersona ) )
			{ 
				return false;
			}
						
			if ( !IdDocumentoIsValid( row.IdDocumento ) )
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
		/// Valida el campo IdDocumento.
		/// </summary>
		public static bool IdDocumentoIsValid( string IdDocumento )
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


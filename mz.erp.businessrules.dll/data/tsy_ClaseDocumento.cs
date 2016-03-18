namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsy_ClaseDocumento : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsy_ClaseDocumento()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsy_ClaseDocumento
		/// </summary>
		public static tsy_ClaseDocumentoDataset GetList()
		{
			return mz.erp.dataaccess.tsy_ClaseDocumento.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsy_ClaseDocumento filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsy_ClaseDocumentoDataset GetList( long IdClaseDocumento, string Descripcion, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsy_ClaseDocumento.GetList( IdClaseDocumento, Descripcion, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsy_ClaseDocumentoRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsy_ClaseDocumentoDataset.tsy_ClaseDocumentoRow NewRow()
		{
			return mz.erp.dataaccess.tsy_ClaseDocumento.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsy_ClaseDocumento que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsy_ClaseDocumentoDataset.tsy_ClaseDocumentoRow GetByPk( long IdClaseDocumento )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsy_ClaseDocumento.GetByPk( IdClaseDocumento ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsy_ClaseDocumentoRow.
		/// </summary>
		public static tsy_ClaseDocumentoDataset.tsy_ClaseDocumentoRow SetRowDefaultValues( tsy_ClaseDocumentoDataset.tsy_ClaseDocumentoRow row )
		{
			row.IdClaseDocumento = 0; 
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
		/// Envia los cambios del tsy_ClaseDocumentoRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsy_ClaseDocumentoDataset.tsy_ClaseDocumentoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsy_ClaseDocumentoRow a la base de datos.
		/// </summary>
		public static void Update( tsy_ClaseDocumentoDataset.tsy_ClaseDocumentoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_ClaseDocumento.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsy_ClaseDocumentoDataset a la base de datos.
		/// </summary>
		public static void Update( tsy_ClaseDocumentoDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsy_ClaseDocumento.Rows.Count > 0, "La tabla dataSet.tsy_ClaseDocumentoDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_ClaseDocumento.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_ClaseDocumentoDataset.tsy_ClaseDocumentoDataTable a la base de datos.
		/// </summary>
		public static void Update( tsy_ClaseDocumentoDataset.tsy_ClaseDocumentoDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_ClaseDocumento.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsy_ClaseDocumentoRow.
		/// </summary>
		public static bool RowIsValid( tsy_ClaseDocumentoDataset.tsy_ClaseDocumentoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdClaseDocumentoIsValid( row.IdClaseDocumento ) )
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
		/// Valida el campo IdClaseDocumento.
		/// </summary>
		public static bool IdClaseDocumentoIsValid( long IdClaseDocumento )
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


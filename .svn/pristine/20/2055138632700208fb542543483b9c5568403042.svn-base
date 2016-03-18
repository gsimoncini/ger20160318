namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsy_TiposDocumentos : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsy_TiposDocumentos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsy_TiposDocumentos
		/// </summary>
		public static tsy_TiposDocumentosDataset GetList()
		{
			return mz.erp.dataaccess.tsy_TiposDocumentos.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsy_TiposDocumentos filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsy_TiposDocumentosDataset GetList( string idTipoDocumento, string Descripcion, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsy_TiposDocumentos.GetList( idTipoDocumento, Descripcion, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsy_TiposDocumentosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsy_TiposDocumentosDataset.tsy_TiposDocumentosRow NewRow()
		{
			return mz.erp.dataaccess.tsy_TiposDocumentos.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsy_TiposDocumentos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsy_TiposDocumentosDataset.tsy_TiposDocumentosRow GetByPk( string idTipoDocumento )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsy_TiposDocumentos.GetByPk( idTipoDocumento ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsy_TiposDocumentosRow.
		/// </summary>
		public static tsy_TiposDocumentosDataset.tsy_TiposDocumentosRow SetRowDefaultValues( tsy_TiposDocumentosDataset.tsy_TiposDocumentosRow row )
		{
			row.idTipoDocumento = Util.NewStringId(); 
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
		/// Envia los cambios del tsy_TiposDocumentosRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsy_TiposDocumentosDataset.tsy_TiposDocumentosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsy_TiposDocumentosRow a la base de datos.
		/// </summary>
		public static void Update( tsy_TiposDocumentosDataset.tsy_TiposDocumentosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_TiposDocumentos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsy_TiposDocumentosDataset a la base de datos.
		/// </summary>
		public static void Update( tsy_TiposDocumentosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsy_TiposDocumentos.Rows.Count > 0, "La tabla dataSet.tsy_TiposDocumentosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_TiposDocumentos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_TiposDocumentosDataset.tsy_TiposDocumentosDataTable a la base de datos.
		/// </summary>
		public static void Update( tsy_TiposDocumentosDataset.tsy_TiposDocumentosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_TiposDocumentos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsy_TiposDocumentosRow.
		/// </summary>
		public static bool RowIsValid( tsy_TiposDocumentosDataset.tsy_TiposDocumentosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !idTipoDocumentoIsValid( row.idTipoDocumento ) )
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
		/// Valida el campo idTipoDocumento.
		/// </summary>
		public static bool idTipoDocumentoIsValid( string idTipoDocumento )
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


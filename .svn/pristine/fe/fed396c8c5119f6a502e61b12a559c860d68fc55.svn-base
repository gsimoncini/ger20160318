namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsh_Documentos : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsh_Documentos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_Documentos
		/// </summary>
		public static tsh_DocumentosDataset GetList()
		{
			return mz.erp.dataaccess.tsh_Documentos.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_Documentos filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsh_DocumentosDataset GetList( string IdDocumento, long IdTipoArchivo, long IdClaseDocumento, string Descripcion, long Tamanio, byte[] Documento, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsh_Documentos.GetList( IdDocumento, IdTipoArchivo, IdClaseDocumento, Descripcion, Tamanio, Documento, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsh_DocumentosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_DocumentosDataset.tsh_DocumentosRow NewRow()
		{
			return mz.erp.dataaccess.tsh_Documentos.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_Documentos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_DocumentosDataset.tsh_DocumentosRow GetByPk( string IdDocumento )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsh_Documentos.GetByPk( IdDocumento ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_DocumentosRow.
		/// </summary>
		public static tsh_DocumentosDataset.tsh_DocumentosRow SetRowDefaultValues( tsh_DocumentosDataset.tsh_DocumentosRow row )
		{
			row.IdDocumento = Util.NewStringId(); 
			row.IdTipoArchivo = 0;
			row.IdClaseDocumento = 0;
			row.Descripcion = string.Empty;
			row.Tamanio = 0;
			row.Documento = null;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = Security.IdSucursal;
			row.IdEmpresa = Security.IdEmpresa;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsh_DocumentosRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsh_DocumentosDataset.tsh_DocumentosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsh_DocumentosRow a la base de datos.
		/// </summary>
		public static void Update( tsh_DocumentosDataset.tsh_DocumentosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_Documentos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_DocumentosDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_DocumentosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_Documentos.Rows.Count > 0, "La tabla dataSet.tsh_DocumentosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_Documentos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_DocumentosDataset.tsh_DocumentosDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_DocumentosDataset.tsh_DocumentosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_Documentos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_DocumentosRow.
		/// </summary>
		public static bool RowIsValid( tsh_DocumentosDataset.tsh_DocumentosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdDocumentoIsValid( row.IdDocumento ) )
			{ 
				return false;
			}
						
			if ( !IdTipoArchivoIsValid( row.IdTipoArchivo ) )
			{ 
				return false;
			}
						
			if ( !IdClaseDocumentoIsValid( row.IdClaseDocumento ) )
			{ 
				return false;
			}
						
			if ( !DescripcionIsValid( row.Descripcion ) )
			{ 
				return false;
			}
						
			if ( !TamanioIsValid( row.Tamanio ) )
			{ 
				return false;
			}
						
			if ( !DocumentoIsValid( row.Documento ) )
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
		/// Valida el campo IdDocumento.
		/// </summary>
		public static bool IdDocumentoIsValid( string IdDocumento )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoArchivo.
		/// </summary>
		public static bool IdTipoArchivoIsValid( long IdTipoArchivo )
		{
			//Agregar cdigo de validacin
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
		/// Valida el campo Tamanio.
		/// </summary>
		public static bool TamanioIsValid( long Tamanio )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Documento.
		/// </summary>
		public static bool DocumentoIsValid( byte[] Documento )
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


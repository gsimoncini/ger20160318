namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_ContactosProveedores : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_ContactosProveedores()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_ContactosProveedores
		/// </summary>
		public static tpu_ContactosProveedoresDataset GetList()
		{
			return mz.erp.dataaccess.tpu_ContactosProveedores.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_ContactosProveedores filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_ContactosProveedoresDataset GetList( string IdPersona, long IdProveedor, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa )
		{
			return mz.erp.dataaccess.tpu_ContactosProveedores.GetList( IdPersona, IdProveedor, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
		}

		/// <summary>
		/// Crea un tpu_ContactosProveedoresRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_ContactosProveedoresDataset.tpu_ContactosProveedoresRow NewRow()
		{
			return mz.erp.dataaccess.tpu_ContactosProveedores.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_ContactosProveedores que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_ContactosProveedoresDataset.tpu_ContactosProveedoresRow GetByPk( string IdPersona, long IdProveedor )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tpu_ContactosProveedores.GetByPk( IdPersona, IdProveedor ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_ContactosProveedoresRow.
		/// </summary>
		public static tpu_ContactosProveedoresDataset.tpu_ContactosProveedoresRow SetRowDefaultValues( tpu_ContactosProveedoresDataset.tpu_ContactosProveedoresRow row )
		{
			row.IdPersona = Util.NewStringId(); 
			row.IdProveedor = 0; 
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
		/// Envia los cambios del tpu_ContactosProveedoresRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tpu_ContactosProveedoresDataset.tpu_ContactosProveedoresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tpu_ContactosProveedoresRow a la base de datos.
		/// </summary>
		public static void Update( tpu_ContactosProveedoresDataset.tpu_ContactosProveedoresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ContactosProveedores.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_ContactosProveedoresDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_ContactosProveedoresDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_ContactosProveedores.Rows.Count > 0, "La tabla dataSet.tpu_ContactosProveedoresDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ContactosProveedores.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ContactosProveedoresDataset.tpu_ContactosProveedoresDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_ContactosProveedoresDataset.tpu_ContactosProveedoresDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ContactosProveedores.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_ContactosProveedoresRow.
		/// </summary>
		public static bool RowIsValid( tpu_ContactosProveedoresDataset.tpu_ContactosProveedoresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdPersonaIsValid( row.IdPersona ) )
			{ 
				return false;
			}
						
			if ( !IdProveedorIsValid( row.IdProveedor ) )
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
		/// Valida el campo IdProveedor.
		/// </summary>
		public static bool IdProveedorIsValid( long IdProveedor )
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


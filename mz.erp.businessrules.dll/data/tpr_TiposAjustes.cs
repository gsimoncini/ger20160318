namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpr_TiposAjustes : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpr_TiposAjustes()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpr_TiposAjustes
		/// </summary>
		public static tpr_TiposAjustesDataset GetList()
		{
			return mz.erp.dataaccess.tpr_TiposAjustes.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpr_TiposAjustes filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpr_TiposAjustesDataset GetList( long IdTipoAjuste, string Descripcion, byte Operacion, bool Sistema, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tpr_TiposAjustes.GetList( IdTipoAjuste, Descripcion, Operacion, Sistema, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tpr_TiposAjustesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpr_TiposAjustesDataset.tpr_TiposAjustesRow NewRow()
		{
			return mz.erp.dataaccess.tpr_TiposAjustes.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpr_TiposAjustes que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpr_TiposAjustesDataset.tpr_TiposAjustesRow GetByPk( long IdTipoAjuste )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tpr_TiposAjustes.GetByPk( IdTipoAjuste ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tpr_TiposAjustesRow.
		/// </summary>
		public static tpr_TiposAjustesDataset.tpr_TiposAjustesRow SetRowDefaultValues( tpr_TiposAjustesDataset.tpr_TiposAjustesRow row )
		{
			row.IdTipoAjuste = 0; 
			row.Descripcion = string.Empty;
			//row.Operacion = null;
			row.Sistema = false;
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
		/// Envia los cambios del tpr_TiposAjustesRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tpr_TiposAjustesDataset.tpr_TiposAjustesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tpr_TiposAjustesRow a la base de datos.
		/// </summary>
		public static void Update( tpr_TiposAjustesDataset.tpr_TiposAjustesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpr_TiposAjustes.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpr_TiposAjustesDataset a la base de datos.
		/// </summary>
		public static void Update( tpr_TiposAjustesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpr_TiposAjustes.Rows.Count > 0, "La tabla dataSet.tpr_TiposAjustesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpr_TiposAjustes.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpr_TiposAjustesDataset.tpr_TiposAjustesDataTable a la base de datos.
		/// </summary>
		public static void Update( tpr_TiposAjustesDataset.tpr_TiposAjustesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpr_TiposAjustes.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpr_TiposAjustesRow.
		/// </summary>
		public static bool RowIsValid( tpr_TiposAjustesDataset.tpr_TiposAjustesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdTipoAjusteIsValid( row.IdTipoAjuste ) )
			{ 
				return false;
			}
						
			if ( !DescripcionIsValid( row.Descripcion ) )
			{ 
				return false;
			}
						
			if ( !OperacionIsValid( row.Operacion ) )
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
		/// Valida el campo IdTipoAjuste.
		/// </summary>
		public static bool IdTipoAjusteIsValid( long IdTipoAjuste )
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
		/// Valida el campo Operacion.
		/// </summary>
		public static bool OperacionIsValid( byte Operacion )
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


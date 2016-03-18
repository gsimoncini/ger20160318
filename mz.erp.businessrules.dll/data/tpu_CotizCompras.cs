namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_CotizCompras : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_CotizCompras()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_CotizCompras
		/// </summary>
		public static tpu_CotizComprasDataset GetList()
		{
			return mz.erp.dataaccess.tpu_CotizCompras.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_CotizCompras filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_CotizComprasDataset GetList( long IdCotizCompra, string Codigo, DateTime Fecha, DateTime FechaConfirmacion, DateTime Fevarcharespuesta, DateTime FechaVencimiento, string Descripcion, long IdProveedor, string Estado, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tpu_CotizCompras.GetList( IdCotizCompra, Codigo, Fecha, FechaConfirmacion, Fevarcharespuesta, FechaVencimiento, Descripcion, IdProveedor, Estado, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tpu_CotizComprasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_CotizComprasDataset.tpu_CotizComprasRow NewRow()
		{
			return mz.erp.dataaccess.tpu_CotizCompras.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_CotizCompras que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_CotizComprasDataset.tpu_CotizComprasRow GetByPk( long IdCotizCompra )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tpu_CotizCompras.GetByPk( IdCotizCompra ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_CotizComprasRow.
		/// </summary>
		public static tpu_CotizComprasDataset.tpu_CotizComprasRow SetRowDefaultValues( tpu_CotizComprasDataset.tpu_CotizComprasRow row )
		{
			row.IdCotizCompra = 0; 
			row.Codigo = string.Empty;
			row.Fecha = mz.erp.businessrules.Sistema.DateTime.Now;
			row.FechaConfirmacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.Fevarcharespuesta = mz.erp.businessrules.Sistema.DateTime.Now;
			row.FechaVencimiento = mz.erp.businessrules.Sistema.DateTime.Now;
			row.Descripcion = string.Empty;
			row.IdProveedor = 0;
			row.Estado = string.Empty;
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
		/// Envia los cambios del tpu_CotizComprasRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tpu_CotizComprasDataset.tpu_CotizComprasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tpu_CotizComprasRow a la base de datos.
		/// </summary>
		public static void Update( tpu_CotizComprasDataset.tpu_CotizComprasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_CotizCompras.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_CotizComprasDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_CotizComprasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_CotizCompras.Rows.Count > 0, "La tabla dataSet.tpu_CotizComprasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_CotizCompras.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_CotizComprasDataset.tpu_CotizComprasDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_CotizComprasDataset.tpu_CotizComprasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_CotizCompras.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_CotizComprasRow.
		/// </summary>
		public static bool RowIsValid( tpu_CotizComprasDataset.tpu_CotizComprasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdCotizCompraIsValid( row.IdCotizCompra ) )
			{ 
				return false;
			}
						
			if ( !CodigoIsValid( row.Codigo ) )
			{ 
				return false;
			}
						
			if ( !FechaIsValid( row.Fecha ) )
			{ 
				return false;
			}
						
			if ( !FechaConfirmacionIsValid( row.FechaConfirmacion ) )
			{ 
				return false;
			}
						
			if ( !FevarcharespuestaIsValid( row.Fevarcharespuesta ) )
			{ 
				return false;
			}
						
			if ( !FechaVencimientoIsValid( row.FechaVencimiento ) )
			{ 
				return false;
			}
						
			if ( !DescripcionIsValid( row.Descripcion ) )
			{ 
				return false;
			}
						
			if ( !IdProveedorIsValid( row.IdProveedor ) )
			{ 
				return false;
			}
						
			if ( !EstadoIsValid( row.Estado ) )
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
		/// Valida el campo IdCotizCompra.
		/// </summary>
		public static bool IdCotizCompraIsValid( long IdCotizCompra )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Codigo.
		/// </summary>
		public static bool CodigoIsValid( string Codigo )
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
		/// Valida el campo FechaConfirmacion.
		/// </summary>
		public static bool FechaConfirmacionIsValid( DateTime FechaConfirmacion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Fevarcharespuesta.
		/// </summary>
		public static bool FevarcharespuestaIsValid( DateTime Fevarcharespuesta )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaVencimiento.
		/// </summary>
		public static bool FechaVencimientoIsValid( DateTime FechaVencimiento )
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
		/// Valida el campo IdProveedor.
		/// </summary>
		public static bool IdProveedorIsValid( long IdProveedor )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Estado.
		/// </summary>
		public static bool EstadoIsValid( string Estado )
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


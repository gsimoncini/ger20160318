namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_DevolucionesCompras : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_DevolucionesCompras()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_DevolucionesCompras
		/// </summary>
		public static tpu_DevolucionesComprasDataset GetList()
		{
			return mz.erp.dataaccess.tpu_DevolucionesCompras.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_DevolucionesCompras filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_DevolucionesComprasDataset GetList( long IdDevolucion, DateTime Fecha, string Descripcion, string IdResponsable, string IdProducto, long IdRemitoCompra, long IdMotivoDevolucion, long IdFacturaDevolucion, long IdProveedor, decimal PrecioCostoNeto, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tpu_DevolucionesCompras.GetList( IdDevolucion, Fecha, Descripcion, IdResponsable, IdProducto, IdRemitoCompra, IdMotivoDevolucion, IdFacturaDevolucion, IdProveedor, PrecioCostoNeto, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tpu_DevolucionesComprasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_DevolucionesComprasDataset.tpu_DevolucionesComprasRow NewRow()
		{
			return mz.erp.dataaccess.tpu_DevolucionesCompras.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_DevolucionesCompras que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_DevolucionesComprasDataset.tpu_DevolucionesComprasRow GetByPk( long IdDevolucion )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tpu_DevolucionesCompras.GetByPk( IdDevolucion ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_DevolucionesComprasRow.
		/// </summary>
		public static tpu_DevolucionesComprasDataset.tpu_DevolucionesComprasRow SetRowDefaultValues( tpu_DevolucionesComprasDataset.tpu_DevolucionesComprasRow row )
		{
			row.IdDevolucion = 0; 
			row.Fecha = mz.erp.businessrules.Sistema.DateTime.Now;
			row.Descripcion = string.Empty;
			row.IdResponsable = string.Empty;
			row.IdProducto = string.Empty;
			row.IdRemitoCompra = 0;
			row.IdMotivoDevolucion = 0;
			row.IdFacturaDevolucion = 0;
			row.IdProveedor = 0;
			row.PrecioCostoNeto = 0;
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
		/// Envia los cambios del tpu_DevolucionesComprasRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tpu_DevolucionesComprasDataset.tpu_DevolucionesComprasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tpu_DevolucionesComprasRow a la base de datos.
		/// </summary>
		public static void Update( tpu_DevolucionesComprasDataset.tpu_DevolucionesComprasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_DevolucionesCompras.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_DevolucionesComprasDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_DevolucionesComprasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_DevolucionesCompras.Rows.Count > 0, "La tabla dataSet.tpu_DevolucionesComprasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_DevolucionesCompras.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_DevolucionesComprasDataset.tpu_DevolucionesComprasDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_DevolucionesComprasDataset.tpu_DevolucionesComprasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_DevolucionesCompras.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_DevolucionesComprasRow.
		/// </summary>
		public static bool RowIsValid( tpu_DevolucionesComprasDataset.tpu_DevolucionesComprasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdDevolucionIsValid( row.IdDevolucion ) )
			{ 
				return false;
			}
						
			if ( !FechaIsValid( row.Fecha ) )
			{ 
				return false;
			}
						
			if ( !DescripcionIsValid( row.Descripcion ) )
			{ 
				return false;
			}
						
			if ( !IdResponsableIsValid( row.IdResponsable ) )
			{ 
				return false;
			}
						
			if ( !IdProductoIsValid( row.IdProducto ) )
			{ 
				return false;
			}
						
			if ( !IdRemitoCompraIsValid( row.IdRemitoCompra ) )
			{ 
				return false;
			}
						
			if ( !IdMotivoDevolucionIsValid( row.IdMotivoDevolucion ) )
			{ 
				return false;
			}
						
			if ( !IdFacturaDevolucionIsValid( row.IdFacturaDevolucion ) )
			{ 
				return false;
			}
						
			if ( !IdProveedorIsValid( row.IdProveedor ) )
			{ 
				return false;
			}
						
			if ( !PrecioCostoNetoIsValid( row.PrecioCostoNeto ) )
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
		/// Valida el campo IdDevolucion.
		/// </summary>
		public static bool IdDevolucionIsValid( long IdDevolucion )
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
		/// Valida el campo Descripcion.
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdResponsable.
		/// </summary>
		public static bool IdResponsableIsValid( string IdResponsable )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProducto.
		/// </summary>
		public static bool IdProductoIsValid( string IdProducto )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdRemitoCompra.
		/// </summary>
		public static bool IdRemitoCompraIsValid( long IdRemitoCompra )
		{
			//Agregar cdigo de validacin
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
		/// Valida el campo IdFacturaDevolucion.
		/// </summary>
		public static bool IdFacturaDevolucionIsValid( long IdFacturaDevolucion )
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
		/// Valida el campo PrecioCostoNeto.
		/// </summary>
		public static bool PrecioCostoNetoIsValid( decimal PrecioCostoNeto )
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


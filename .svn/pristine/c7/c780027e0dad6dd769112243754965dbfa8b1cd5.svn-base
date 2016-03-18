namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_OrdenesCompra : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_OrdenesCompra()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_OrdenesCompra
		/// </summary>
		public static tpu_OrdenesCompraDataset GetList()
		{
			return mz.erp.dataaccess.tpu_OrdenesCompra.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_OrdenesCompra filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_OrdenesCompraDataset GetList( long IdOrdenCompra, string Codigo, long IdProveedor, DateTime Fecha, DateTime FechaConfirmacion, DateTime FechaEstEntrega, DateTime FechaEntrega, DateTime FechaVencimiento, string Descripcion, decimal Total, string Estado, string FormaDePago, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tpu_OrdenesCompra.GetList( IdOrdenCompra, Codigo, IdProveedor, Fecha, FechaConfirmacion, FechaEstEntrega, FechaEntrega, FechaVencimiento, Descripcion, Total, Estado, FormaDePago, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tpu_OrdenesCompraRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_OrdenesCompraDataset.tpu_OrdenesCompraRow NewRow()
		{
			return mz.erp.dataaccess.tpu_OrdenesCompra.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_OrdenesCompra que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_OrdenesCompraDataset.tpu_OrdenesCompraRow GetByPk( long IdOrdenCompra )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tpu_OrdenesCompra.GetByPk( IdOrdenCompra ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_OrdenesCompraRow.
		/// </summary>
		public static tpu_OrdenesCompraDataset.tpu_OrdenesCompraRow SetRowDefaultValues( tpu_OrdenesCompraDataset.tpu_OrdenesCompraRow row )
		{
			row.IdOrdenCompra = 0; 
			row.Codigo = string.Empty;
			row.IdProveedor = 0;
			row.Fecha = mz.erp.businessrules.Sistema.DateTime.Now;
			row.FechaConfirmacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.FechaEstEntrega = mz.erp.businessrules.Sistema.DateTime.Now;
			row.FechaEntrega = mz.erp.businessrules.Sistema.DateTime.Now;
			row.FechaVencimiento = mz.erp.businessrules.Sistema.DateTime.Now;
			row.Descripcion = string.Empty;
			row.Total = 0;
			row.Estado = string.Empty;
			row.FormaDePago = string.Empty;
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
		/// Envia los cambios del tpu_OrdenesCompraRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tpu_OrdenesCompraDataset.tpu_OrdenesCompraRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tpu_OrdenesCompraRow a la base de datos.
		/// </summary>
		public static void Update( tpu_OrdenesCompraDataset.tpu_OrdenesCompraRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_OrdenesCompra.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_OrdenesCompraDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_OrdenesCompraDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_OrdenesCompra.Rows.Count > 0, "La tabla dataSet.tpu_OrdenesCompraDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_OrdenesCompra.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_OrdenesCompraDataset.tpu_OrdenesCompraDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_OrdenesCompraDataset.tpu_OrdenesCompraDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_OrdenesCompra.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_OrdenesCompraRow.
		/// </summary>
		public static bool RowIsValid( tpu_OrdenesCompraDataset.tpu_OrdenesCompraRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdOrdenCompraIsValid( row.IdOrdenCompra ) )
			{ 
				return false;
			}
						
			if ( !CodigoIsValid( row.Codigo ) )
			{ 
				return false;
			}
						
			if ( !IdProveedorIsValid( row.IdProveedor ) )
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
						
			if ( !FechaEstEntregaIsValid( row.FechaEstEntrega ) )
			{ 
				return false;
			}
						
			if ( !FechaEntregaIsValid( row.FechaEntrega ) )
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
						
			if ( !TotalIsValid( row.Total ) )
			{ 
				return false;
			}
						
			if ( !EstadoIsValid( row.Estado ) )
			{ 
				return false;
			}
						
			if ( !FormaDePagoIsValid( row.FormaDePago ) )
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
		/// Valida el campo IdOrdenCompra.
		/// </summary>
		public static bool IdOrdenCompraIsValid( long IdOrdenCompra )
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
		/// Valida el campo IdProveedor.
		/// </summary>
		public static bool IdProveedorIsValid( long IdProveedor )
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
		/// Valida el campo FechaEstEntrega.
		/// </summary>
		public static bool FechaEstEntregaIsValid( DateTime FechaEstEntrega )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaEntrega.
		/// </summary>
		public static bool FechaEntregaIsValid( DateTime FechaEntrega )
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
		/// Valida el campo Total.
		/// </summary>
		public static bool TotalIsValid( decimal Total )
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
		/// Valida el campo FormaDePago.
		/// </summary>
		public static bool FormaDePagoIsValid( string FormaDePago )
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


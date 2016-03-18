namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_OrdenesCompraDet : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_OrdenesCompraDet()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_OrdenesCompraDet
		/// </summary>
		public static tpu_OrdenesCompraDetDataset GetList()
		{
			return mz.erp.dataaccess.tpu_OrdenesCompraDet.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_OrdenesCompraDet filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_OrdenesCompraDetDataset GetList( long IdOrdenCompra, short Renglon, string IdProducto, decimal Cantidad, decimal Entregado, string Descripcion, decimal PCostoNeto, decimal PCostoNetoFinal, decimal Alicuota, long IdMoneda, long IdFuenteDeCambio, decimal VarMaximaPrecio, decimal VarMinimaPedido, decimal VarMaximaPedido, string Observaciones, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tpu_OrdenesCompraDet.GetList( IdOrdenCompra, Renglon, IdProducto, Cantidad, Entregado, Descripcion, PCostoNeto, PCostoNetoFinal, Alicuota, IdMoneda, IdFuenteDeCambio, VarMaximaPrecio, VarMinimaPedido, VarMaximaPedido, Observaciones, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tpu_OrdenesCompraDetRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_OrdenesCompraDetDataset.tpu_OrdenesCompraDetRow NewRow()
		{
			return mz.erp.dataaccess.tpu_OrdenesCompraDet.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_OrdenesCompraDet que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_OrdenesCompraDetDataset.tpu_OrdenesCompraDetRow GetByPk( long IdOrdenCompra, short Renglon )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tpu_OrdenesCompraDet.GetByPk( IdOrdenCompra, Renglon ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_OrdenesCompraDetRow.
		/// </summary>
		public static tpu_OrdenesCompraDetDataset.tpu_OrdenesCompraDetRow SetRowDefaultValues( tpu_OrdenesCompraDetDataset.tpu_OrdenesCompraDetRow row )
		{
			row.IdOrdenCompra = 0; 
			row.Renglon = 0; 
			row.IdProducto = string.Empty;
			row.Cantidad = 0;
			row.Entregado = 0;
			row.Descripcion = string.Empty;
			row.PCostoNeto = 0;
			row.PCostoNetoFinal = 0;
			row.Alicuota = 0;
			row.IdMoneda = 0;
			row.IdFuenteDeCambio = 0;
			row.VarMaximaPrecio = 0;
			row.VarMinimaPedido = 0;
			row.VarMaximaPedido = 0;
			row.Observaciones = string.Empty;
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
		/// Envia los cambios del tpu_OrdenesCompraDetRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tpu_OrdenesCompraDetDataset.tpu_OrdenesCompraDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tpu_OrdenesCompraDetRow a la base de datos.
		/// </summary>
		public static void Update( tpu_OrdenesCompraDetDataset.tpu_OrdenesCompraDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_OrdenesCompraDet.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_OrdenesCompraDetDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_OrdenesCompraDetDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_OrdenesCompraDet.Rows.Count > 0, "La tabla dataSet.tpu_OrdenesCompraDetDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_OrdenesCompraDet.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_OrdenesCompraDetDataset.tpu_OrdenesCompraDetDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_OrdenesCompraDetDataset.tpu_OrdenesCompraDetDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_OrdenesCompraDet.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_OrdenesCompraDetRow.
		/// </summary>
		public static bool RowIsValid( tpu_OrdenesCompraDetDataset.tpu_OrdenesCompraDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdOrdenCompraIsValid( row.IdOrdenCompra ) )
			{ 
				return false;
			}
						
			if ( !RenglonIsValid( row.Renglon ) )
			{ 
				return false;
			}
						
			if ( !IdProductoIsValid( row.IdProducto ) )
			{ 
				return false;
			}
						
			if ( !CantidadIsValid( row.Cantidad ) )
			{ 
				return false;
			}
						
			if ( !EntregadoIsValid( row.Entregado ) )
			{ 
				return false;
			}
						
			if ( !DescripcionIsValid( row.Descripcion ) )
			{ 
				return false;
			}
						
			if ( !PCostoNetoIsValid( row.PCostoNeto ) )
			{ 
				return false;
			}
						
			if ( !PCostoNetoFinalIsValid( row.PCostoNetoFinal ) )
			{ 
				return false;
			}
						
			if ( !AlicuotaIsValid( row.Alicuota ) )
			{ 
				return false;
			}
						
			if ( !IdMonedaIsValid( row.IdMoneda ) )
			{ 
				return false;
			}
						
			if ( !IdFuenteDeCambioIsValid( row.IdFuenteDeCambio ) )
			{ 
				return false;
			}
						
			if ( !VarMaximaPrecioIsValid( row.VarMaximaPrecio ) )
			{ 
				return false;
			}
						
			if ( !VarMinimaPedidoIsValid( row.VarMinimaPedido ) )
			{ 
				return false;
			}
						
			if ( !VarMaximaPedidoIsValid( row.VarMaximaPedido ) )
			{ 
				return false;
			}
						
			if ( !ObservacionesIsValid( row.Observaciones ) )
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
		/// Valida el campo Renglon.
		/// </summary>
		public static bool RenglonIsValid( short Renglon )
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
		/// Valida el campo Cantidad.
		/// </summary>
		public static bool CantidadIsValid( decimal Cantidad )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Entregado.
		/// </summary>
		public static bool EntregadoIsValid( decimal Entregado )
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
		/// Valida el campo PCostoNeto.
		/// </summary>
		public static bool PCostoNetoIsValid( decimal PCostoNeto )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo PCostoNetoFinal.
		/// </summary>
		public static bool PCostoNetoFinalIsValid( decimal PCostoNetoFinal )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Alicuota.
		/// </summary>
		public static bool AlicuotaIsValid( decimal Alicuota )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMoneda.
		/// </summary>
		public static bool IdMonedaIsValid( long IdMoneda )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdFuenteDeCambio.
		/// </summary>
		public static bool IdFuenteDeCambioIsValid( long IdFuenteDeCambio )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo VarMaximaPrecio.
		/// </summary>
		public static bool VarMaximaPrecioIsValid( decimal VarMaximaPrecio )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo VarMinimaPedido.
		/// </summary>
		public static bool VarMinimaPedidoIsValid( decimal VarMinimaPedido )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo VarMaximaPedido.
		/// </summary>
		public static bool VarMaximaPedidoIsValid( decimal VarMaximaPedido )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Observaciones.
		/// </summary>
		public static bool ObservacionesIsValid( string Observaciones )
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


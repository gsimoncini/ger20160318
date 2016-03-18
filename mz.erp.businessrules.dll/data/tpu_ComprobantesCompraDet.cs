namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_ComprobantesCompraDet : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_ComprobantesCompraDet()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_ComprobantesCompraDet
		/// </summary>
		public static tpu_ComprobantesCompraDetDataset GetList()
		{
			return mz.erp.dataaccess.tpu_ComprobantesCompraDet.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_ComprobantesCompraDet filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_ComprobantesCompraDetDataset GetList( long IdComprobanteCompra, short Renglon, string IdProducto, decimal Cantidad, decimal PrecioNetoLista, decimal Bonificacion, decimal PrecioNeto, decimal Alicuota, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tpu_ComprobantesCompraDet.GetList( IdComprobanteCompra, Renglon, IdProducto, Cantidad, PrecioNetoLista, Bonificacion, PrecioNeto, Alicuota, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tpu_ComprobantesCompraDetRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_ComprobantesCompraDetDataset.tpu_ComprobantesCompraDetRow NewRow()
		{
			return mz.erp.dataaccess.tpu_ComprobantesCompraDet.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_ComprobantesCompraDet que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_ComprobantesCompraDetDataset.tpu_ComprobantesCompraDetRow GetByPk( long IdComprobanteCompra, short Renglon )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tpu_ComprobantesCompraDet.GetByPk( IdComprobanteCompra, Renglon ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_ComprobantesCompraDetRow.
		/// </summary>
		public static tpu_ComprobantesCompraDetDataset.tpu_ComprobantesCompraDetRow SetRowDefaultValues( tpu_ComprobantesCompraDetDataset.tpu_ComprobantesCompraDetRow row )
		{
			row.IdComprobanteCompra = 0; 
			row.Renglon = 0; 
			row.IdProducto = string.Empty;
			row.Cantidad = 0;
			row.PrecioNetoLista = 0;
			row.Bonificacion = 0;
			row.PrecioNeto = 0;
			row.Alicuota = 0;
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
		/// Envia los cambios del tpu_ComprobantesCompraDetRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tpu_ComprobantesCompraDetDataset.tpu_ComprobantesCompraDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesCompraDetRow a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesCompraDetDataset.tpu_ComprobantesCompraDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ComprobantesCompraDet.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_ComprobantesCompraDetDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesCompraDetDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_ComprobantesCompraDet.Rows.Count > 0, "La tabla dataSet.tpu_ComprobantesCompraDetDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ComprobantesCompraDet.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesCompraDetDataset.tpu_ComprobantesCompraDetDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesCompraDetDataset.tpu_ComprobantesCompraDetDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ComprobantesCompraDet.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_ComprobantesCompraDetRow.
		/// </summary>
		public static bool RowIsValid( tpu_ComprobantesCompraDetDataset.tpu_ComprobantesCompraDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdComprobanteCompraIsValid( row.IdComprobanteCompra ) )
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
						
			if ( !PrecioNetoListaIsValid( row.PrecioNetoLista ) )
			{ 
				return false;
			}
						
			if ( !BonificacionIsValid( row.Bonificacion ) )
			{ 
				return false;
			}
						
			if ( !PrecioNetoIsValid( row.PrecioNeto ) )
			{ 
				return false;
			}
						
			if ( !AlicuotaIsValid( row.Alicuota ) )
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
		/// Valida el campo IdComprobanteCompra.
		/// </summary>
		public static bool IdComprobanteCompraIsValid( long IdComprobanteCompra )
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
		/// Valida el campo PrecioNetoLista.
		/// </summary>
		public static bool PrecioNetoListaIsValid( decimal PrecioNetoLista )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Bonificacion.
		/// </summary>
		public static bool BonificacionIsValid( decimal Bonificacion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo PrecioNeto.
		/// </summary>
		public static bool PrecioNetoIsValid( decimal PrecioNeto )
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


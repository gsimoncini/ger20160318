namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_RemitosComprasDet : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_RemitosComprasDet()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_RemitosComprasDet
		/// </summary>
		public static tpu_RemitosComprasDetDataset GetList()
		{
			return mz.erp.dataaccess.tpu_RemitosComprasDet.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_RemitosComprasDet filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_RemitosComprasDetDataset GetList( long IdRemitoCompra, short Renglon, string IdProducto, decimal Cantidad, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tpu_RemitosComprasDet.GetList( IdRemitoCompra, Renglon, IdProducto, Cantidad, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tpu_RemitosComprasDetRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_RemitosComprasDetDataset.tpu_RemitosComprasDetRow NewRow()
		{
			return mz.erp.dataaccess.tpu_RemitosComprasDet.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_RemitosComprasDet que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_RemitosComprasDetDataset.tpu_RemitosComprasDetRow GetByPk( long IdRemitoCompra, short Renglon )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tpu_RemitosComprasDet.GetByPk( IdRemitoCompra, Renglon ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_RemitosComprasDetRow.
		/// </summary>
		public static tpu_RemitosComprasDetDataset.tpu_RemitosComprasDetRow SetRowDefaultValues( tpu_RemitosComprasDetDataset.tpu_RemitosComprasDetRow row )
		{
			row.IdRemitoCompra = 0; 
			row.Renglon = 0; 
			row.IdProducto = string.Empty;
			row.Cantidad = 0;
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
		/// Envia los cambios del tpu_RemitosComprasDetRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tpu_RemitosComprasDetDataset.tpu_RemitosComprasDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tpu_RemitosComprasDetRow a la base de datos.
		/// </summary>
		public static void Update( tpu_RemitosComprasDetDataset.tpu_RemitosComprasDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_RemitosComprasDet.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_RemitosComprasDetDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_RemitosComprasDetDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_RemitosComprasDet.Rows.Count > 0, "La tabla dataSet.tpu_RemitosComprasDetDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_RemitosComprasDet.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_RemitosComprasDetDataset.tpu_RemitosComprasDetDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_RemitosComprasDetDataset.tpu_RemitosComprasDetDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_RemitosComprasDet.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_RemitosComprasDetRow.
		/// </summary>
		public static bool RowIsValid( tpu_RemitosComprasDetDataset.tpu_RemitosComprasDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdRemitoCompraIsValid( row.IdRemitoCompra ) )
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
		/// Valida el campo IdRemitoCompra.
		/// </summary>
		public static bool IdRemitoCompraIsValid( long IdRemitoCompra )
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


namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_OrdenesRemitosCompras : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_OrdenesRemitosCompras()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_OrdenesRemitosCompras
		/// </summary>
		public static tpu_OrdenesRemitosComprasDataset GetList()
		{
			return mz.erp.dataaccess.tpu_OrdenesRemitosCompras.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_OrdenesRemitosCompras filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_OrdenesRemitosComprasDataset GetList( long IdOrdenCompra, short RenglonOrden, long IdRemitosCompra, short RenglonRemito, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tpu_OrdenesRemitosCompras.GetList( IdOrdenCompra, RenglonOrden, IdRemitosCompra, RenglonRemito, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tpu_OrdenesRemitosComprasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_OrdenesRemitosComprasDataset.tpu_OrdenesRemitosComprasRow NewRow()
		{
			return mz.erp.dataaccess.tpu_OrdenesRemitosCompras.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_OrdenesRemitosCompras que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_OrdenesRemitosComprasDataset.tpu_OrdenesRemitosComprasRow GetByPk( long IdOrdenCompra, short RenglonOrden, long IdRemitosCompra, short RenglonRemito )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tpu_OrdenesRemitosCompras.GetByPk( IdOrdenCompra, RenglonOrden, IdRemitosCompra, RenglonRemito ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_OrdenesRemitosComprasRow.
		/// </summary>
		public static tpu_OrdenesRemitosComprasDataset.tpu_OrdenesRemitosComprasRow SetRowDefaultValues( tpu_OrdenesRemitosComprasDataset.tpu_OrdenesRemitosComprasRow row )
		{
			row.IdOrdenCompra = 0; 
			row.RenglonOrden = 0; 
			row.IdRemitosCompra = 0; 
			row.RenglonRemito = 0; 
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
		/// Envia los cambios del tpu_OrdenesRemitosComprasRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tpu_OrdenesRemitosComprasDataset.tpu_OrdenesRemitosComprasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tpu_OrdenesRemitosComprasRow a la base de datos.
		/// </summary>
		public static void Update( tpu_OrdenesRemitosComprasDataset.tpu_OrdenesRemitosComprasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_OrdenesRemitosCompras.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_OrdenesRemitosComprasDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_OrdenesRemitosComprasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_OrdenesRemitosCompras.Rows.Count > 0, "La tabla dataSet.tpu_OrdenesRemitosComprasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_OrdenesRemitosCompras.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_OrdenesRemitosComprasDataset.tpu_OrdenesRemitosComprasDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_OrdenesRemitosComprasDataset.tpu_OrdenesRemitosComprasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_OrdenesRemitosCompras.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_OrdenesRemitosComprasRow.
		/// </summary>
		public static bool RowIsValid( tpu_OrdenesRemitosComprasDataset.tpu_OrdenesRemitosComprasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdOrdenCompraIsValid( row.IdOrdenCompra ) )
			{ 
				return false;
			}
						
			if ( !RenglonOrdenIsValid( row.RenglonOrden ) )
			{ 
				return false;
			}
						
			if ( !IdRemitosCompraIsValid( row.IdRemitosCompra ) )
			{ 
				return false;
			}
						
			if ( !RenglonRemitoIsValid( row.RenglonRemito ) )
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
		/// Valida el campo RenglonOrden.
		/// </summary>
		public static bool RenglonOrdenIsValid( short RenglonOrden )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdRemitosCompra.
		/// </summary>
		public static bool IdRemitosCompraIsValid( long IdRemitosCompra )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo RenglonRemito.
		/// </summary>
		public static bool RenglonRemitoIsValid( short RenglonRemito )
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


namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_RemitosCompComprasDet : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_RemitosCompComprasDet()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_RemitosCompComprasDet
		/// </summary>
		public static tpu_RemitosCompComprasDetDataset GetList()
		{
			return mz.erp.dataaccess.tpu_RemitosCompComprasDet.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_RemitosCompComprasDet filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_RemitosCompComprasDetDataset GetList( long IdComprobanteCompra, short RenglonCompra, long IdRemitoCompra, short RenglonRemito, decimal Cantidad, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tpu_RemitosCompComprasDet.GetList( IdComprobanteCompra, RenglonCompra, IdRemitoCompra, RenglonRemito, Cantidad, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tpu_RemitosCompComprasDetRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_RemitosCompComprasDetDataset.tpu_RemitosCompComprasDetRow NewRow()
		{
			return mz.erp.dataaccess.tpu_RemitosCompComprasDet.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_RemitosCompComprasDet que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_RemitosCompComprasDetDataset.tpu_RemitosCompComprasDetRow GetByPk( long IdComprobanteCompra )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tpu_RemitosCompComprasDet.GetByPk( IdComprobanteCompra ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_RemitosCompComprasDetRow.
		/// </summary>
		public static tpu_RemitosCompComprasDetDataset.tpu_RemitosCompComprasDetRow SetRowDefaultValues( tpu_RemitosCompComprasDetDataset.tpu_RemitosCompComprasDetRow row )
		{
			row.IdComprobanteCompra = 0; 
			row.RenglonCompra = 0;
			row.IdRemitoCompra = 0;
			row.RenglonRemito = 0;
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
		/// Envia los cambios del tpu_RemitosCompComprasDetRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tpu_RemitosCompComprasDetDataset.tpu_RemitosCompComprasDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tpu_RemitosCompComprasDetRow a la base de datos.
		/// </summary>
		public static void Update( tpu_RemitosCompComprasDetDataset.tpu_RemitosCompComprasDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_RemitosCompComprasDet.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_RemitosCompComprasDetDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_RemitosCompComprasDetDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_RemitosCompComprasDet.Rows.Count > 0, "La tabla dataSet.tpu_RemitosCompComprasDetDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_RemitosCompComprasDet.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_RemitosCompComprasDetDataset.tpu_RemitosCompComprasDetDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_RemitosCompComprasDetDataset.tpu_RemitosCompComprasDetDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_RemitosCompComprasDet.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_RemitosCompComprasDetRow.
		/// </summary>
		public static bool RowIsValid( tpu_RemitosCompComprasDetDataset.tpu_RemitosCompComprasDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdComprobanteCompraIsValid( row.IdComprobanteCompra ) )
			{ 
				return false;
			}
						
			if ( !RenglonCompraIsValid( row.RenglonCompra ) )
			{ 
				return false;
			}
						
			if ( !IdRemitoCompraIsValid( row.IdRemitoCompra ) )
			{ 
				return false;
			}
						
			if ( !RenglonRemitoIsValid( row.RenglonRemito ) )
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
		/// Valida el campo IdComprobanteCompra.
		/// </summary>
		public static bool IdComprobanteCompraIsValid( long IdComprobanteCompra )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo RenglonCompra.
		/// </summary>
		public static bool RenglonCompraIsValid( short RenglonCompra )
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
		/// Valida el campo RenglonRemito.
		/// </summary>
		public static bool RenglonRemitoIsValid( short RenglonRemito )
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


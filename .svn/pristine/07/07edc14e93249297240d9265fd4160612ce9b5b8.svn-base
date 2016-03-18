namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsh_MovimientosStockDet : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsh_MovimientosStockDet()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_MovimientosStockDet
		/// </summary>
		public static tsh_MovimientosStockDetDataset GetList()
		{
			return mz.erp.dataaccess.tsh_MovimientosStockDet.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_MovimientosStockDet filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsh_MovimientosStockDetDataset GetList( long IdMovimientoStock, short Renglon, string IdProducto, long Cantidad, long IdDeposito, long IdSeccion, string NumeroSerie, long IdLote, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsh_MovimientosStockDet.GetList( IdMovimientoStock, Renglon, IdProducto, Cantidad, IdDeposito, IdSeccion, NumeroSerie, IdLote, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsh_MovimientosStockDetRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_MovimientosStockDetDataset.tsh_MovimientosStockDetRow NewRow()
		{
			return mz.erp.dataaccess.tsh_MovimientosStockDet.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_MovimientosStockDet que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_MovimientosStockDetDataset.tsh_MovimientosStockDetRow GetByPk( long IdMovimientoStock, short Renglon )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsh_MovimientosStockDet.GetByPk( IdMovimientoStock, Renglon ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_MovimientosStockDetRow.
		/// </summary>
		public static tsh_MovimientosStockDetDataset.tsh_MovimientosStockDetRow SetRowDefaultValues( tsh_MovimientosStockDetDataset.tsh_MovimientosStockDetRow row )
		{
			row.IdMovimientoStock = 0; 
			row.Renglon = 0; 
			row.IdProducto = string.Empty;
			row.Cantidad = 0;
			row.IdDeposito = 0;
			row.IdSeccion = 0;
			row.NumeroSerie = string.Empty;
			row.IdLote = 0;
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
		/// Envia los cambios del tsh_MovimientosStockDetRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsh_MovimientosStockDetDataset.tsh_MovimientosStockDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsh_MovimientosStockDetRow a la base de datos.
		/// </summary>
		public static void Update( tsh_MovimientosStockDetDataset.tsh_MovimientosStockDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_MovimientosStockDet.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_MovimientosStockDetDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_MovimientosStockDetDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_MovimientosStockDet.Rows.Count > 0, "La tabla dataSet.tsh_MovimientosStockDetDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_MovimientosStockDet.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_MovimientosStockDetDataset.tsh_MovimientosStockDetDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_MovimientosStockDetDataset.tsh_MovimientosStockDetDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_MovimientosStockDet.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_MovimientosStockDetRow.
		/// </summary>
		public static bool RowIsValid( tsh_MovimientosStockDetDataset.tsh_MovimientosStockDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdMovimientoStockIsValid( row.IdMovimientoStock ) )
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
						
			if ( !IdDepositoIsValid( row.IdDeposito ) )
			{ 
				return false;
			}
						
			if ( !IdSeccionIsValid( row.IdSeccion ) )
			{ 
				return false;
			}
						
			if ( !NumeroSerieIsValid( row.NumeroSerie ) )
			{ 
				return false;
			}
						
			if ( !IdLoteIsValid( row.IdLote ) )
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
		/// Valida el campo IdMovimientoStock.
		/// </summary>
		public static bool IdMovimientoStockIsValid( long IdMovimientoStock )
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
		public static bool CantidadIsValid( long Cantidad )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdDeposito.
		/// </summary>
		public static bool IdDepositoIsValid( long IdDeposito )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSeccion.
		/// </summary>
		public static bool IdSeccionIsValid( long IdSeccion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo NumeroSerie.
		/// </summary>
		public static bool NumeroSerieIsValid( string NumeroSerie )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdLote.
		/// </summary>
		public static bool IdLoteIsValid( long IdLote )
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


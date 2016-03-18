namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsh_MovimientosStock : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsh_MovimientosStock()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_MovimientosStock
		/// </summary>
		public static tsh_MovimientosStockDataset GetList()
		{
			return mz.erp.dataaccess.tsh_MovimientosStock.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_MovimientosStock filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsh_MovimientosStockDataset GetList( long IdMovimientoStock, string IdTipoMovimiento, long IdUsuario, DateTime Fecha, string Comentario, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsh_MovimientosStock.GetList( IdMovimientoStock, IdTipoMovimiento, IdUsuario, Fecha, Comentario, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsh_MovimientosStockRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_MovimientosStockDataset.tsh_MovimientosStockRow NewRow()
		{
			return mz.erp.dataaccess.tsh_MovimientosStock.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_MovimientosStock que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_MovimientosStockDataset.tsh_MovimientosStockRow GetByPk( long IdMovimientoStock )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsh_MovimientosStock.GetByPk( IdMovimientoStock ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_MovimientosStockRow.
		/// </summary>
		public static tsh_MovimientosStockDataset.tsh_MovimientosStockRow SetRowDefaultValues( tsh_MovimientosStockDataset.tsh_MovimientosStockRow row )
		{
			row.IdMovimientoStock = 0; 
			row.IdTipoMovimiento = string.Empty;
			row.IdUsuario = 0;
			row.Fecha = mz.erp.businessrules.Sistema.DateTime.Now;
			row.Comentario = string.Empty;
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
		/// Envia los cambios del tsh_MovimientosStockRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsh_MovimientosStockDataset.tsh_MovimientosStockRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsh_MovimientosStockRow a la base de datos.
		/// </summary>
		public static void Update( tsh_MovimientosStockDataset.tsh_MovimientosStockRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_MovimientosStock.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_MovimientosStockDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_MovimientosStockDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_MovimientosStock.Rows.Count > 0, "La tabla dataSet.tsh_MovimientosStockDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_MovimientosStock.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_MovimientosStockDataset.tsh_MovimientosStockDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_MovimientosStockDataset.tsh_MovimientosStockDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_MovimientosStock.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_MovimientosStockRow.
		/// </summary>
		public static bool RowIsValid( tsh_MovimientosStockDataset.tsh_MovimientosStockRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdMovimientoStockIsValid( row.IdMovimientoStock ) )
			{ 
				return false;
			}
						
			if ( !IdTipoMovimientoIsValid( row.IdTipoMovimiento ) )
			{ 
				return false;
			}
						
			if ( !IdUsuarioIsValid( row.IdUsuario ) )
			{ 
				return false;
			}
						
			if ( !FechaIsValid( row.Fecha ) )
			{ 
				return false;
			}
						
			if ( !ComentarioIsValid( row.Comentario ) )
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
		/// Valida el campo IdTipoMovimiento.
		/// </summary>
		public static bool IdTipoMovimientoIsValid( string IdTipoMovimiento )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdUsuario.
		/// </summary>
		public static bool IdUsuarioIsValid( long IdUsuario )
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
		/// Valida el campo Comentario.
		/// </summary>
		public static bool ComentarioIsValid( string Comentario )
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


namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsh_StockMinimo : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsh_StockMinimo()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_StockMinimo
		/// </summary>
		public static tsh_StockMinimoDataset GetList()
		{
			return mz.erp.dataaccess.tsh_StockMinimo.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_StockMinimo filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsh_StockMinimoDataset GetList( string IdProducto, long IdDeposito, decimal Cantidad, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsh_StockMinimo.GetList( IdProducto, IdDeposito, Cantidad, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsh_StockMinimoRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_StockMinimoDataset.tsh_StockMinimoRow NewRow()
		{
			return mz.erp.dataaccess.tsh_StockMinimo.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_StockMinimo que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_StockMinimoDataset.tsh_StockMinimoRow GetByPk( string IdProducto, long IdDeposito )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsh_StockMinimo.GetByPk( IdProducto, IdDeposito ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_StockMinimoRow.
		/// </summary>
		public static tsh_StockMinimoDataset.tsh_StockMinimoRow SetRowDefaultValues( tsh_StockMinimoDataset.tsh_StockMinimoRow row )
		{
			row.IdProducto = Util.NewStringId(); 
			row.IdDeposito = 0; 
			row.Cantidad = 0;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = 0;
			row.IdEmpresa = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsh_StockMinimoRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsh_StockMinimoDataset.tsh_StockMinimoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsh_StockMinimoRow a la base de datos.
		/// </summary>
		public static void Update( tsh_StockMinimoDataset.tsh_StockMinimoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_StockMinimo.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_StockMinimoDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_StockMinimoDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_StockMinimo.Rows.Count > 0, "La tabla dataSet.tsh_StockMinimoDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_StockMinimo.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_StockMinimoDataset.tsh_StockMinimoDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_StockMinimoDataset.tsh_StockMinimoDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_StockMinimo.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_StockMinimoRow.
		/// </summary>
		public static bool RowIsValid( tsh_StockMinimoDataset.tsh_StockMinimoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdProductoIsValid( row.IdProducto ) )
			{ 
				return false;
			}
						
			if ( !IdDepositoIsValid( row.IdDeposito ) )
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
		/// Valida el campo IdProducto.
		/// </summary>
		public static bool IdProductoIsValid( string IdProducto )
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


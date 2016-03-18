namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_CotizOrdenesCompra : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_CotizOrdenesCompra()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_CotizOrdenesCompra
		/// </summary>
		public static tpu_CotizOrdenesCompraDataset GetList()
		{
			return mz.erp.dataaccess.tpu_CotizOrdenesCompra.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_CotizOrdenesCompra filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_CotizOrdenesCompraDataset GetList( long IdCotizCompra, short RenglonCotiz, long IdOrdenCompra, short RenglonOrden, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tpu_CotizOrdenesCompra.GetList( IdCotizCompra, RenglonCotiz, IdOrdenCompra, RenglonOrden, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tpu_CotizOrdenesCompraRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_CotizOrdenesCompraDataset.tpu_CotizOrdenesCompraRow NewRow()
		{
			return mz.erp.dataaccess.tpu_CotizOrdenesCompra.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_CotizOrdenesCompra que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_CotizOrdenesCompraDataset.tpu_CotizOrdenesCompraRow GetByPk( long IdCotizCompra, short RenglonCotiz, long IdOrdenCompra, short RenglonOrden )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tpu_CotizOrdenesCompra.GetByPk( IdCotizCompra, RenglonCotiz, IdOrdenCompra, RenglonOrden ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_CotizOrdenesCompraRow.
		/// </summary>
		public static tpu_CotizOrdenesCompraDataset.tpu_CotizOrdenesCompraRow SetRowDefaultValues( tpu_CotizOrdenesCompraDataset.tpu_CotizOrdenesCompraRow row )
		{
			row.IdCotizCompra = 0; 
			row.RenglonCotiz = 0; 
			row.IdOrdenCompra = 0; 
			row.RenglonOrden = 0; 
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
		/// Envia los cambios del tpu_CotizOrdenesCompraRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tpu_CotizOrdenesCompraDataset.tpu_CotizOrdenesCompraRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tpu_CotizOrdenesCompraRow a la base de datos.
		/// </summary>
		public static void Update( tpu_CotizOrdenesCompraDataset.tpu_CotizOrdenesCompraRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_CotizOrdenesCompra.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_CotizOrdenesCompraDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_CotizOrdenesCompraDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_CotizOrdenesCompra.Rows.Count > 0, "La tabla dataSet.tpu_CotizOrdenesCompraDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_CotizOrdenesCompra.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_CotizOrdenesCompraDataset.tpu_CotizOrdenesCompraDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_CotizOrdenesCompraDataset.tpu_CotizOrdenesCompraDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_CotizOrdenesCompra.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_CotizOrdenesCompraRow.
		/// </summary>
		public static bool RowIsValid( tpu_CotizOrdenesCompraDataset.tpu_CotizOrdenesCompraRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdCotizCompraIsValid( row.IdCotizCompra ) )
			{ 
				return false;
			}
						
			if ( !RenglonCotizIsValid( row.RenglonCotiz ) )
			{ 
				return false;
			}
						
			if ( !IdOrdenCompraIsValid( row.IdOrdenCompra ) )
			{ 
				return false;
			}
						
			if ( !RenglonOrdenIsValid( row.RenglonOrden ) )
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
		/// Valida el campo IdCotizCompra.
		/// </summary>
		public static bool IdCotizCompraIsValid( long IdCotizCompra )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo RenglonCotiz.
		/// </summary>
		public static bool RenglonCotizIsValid( short RenglonCotiz )
		{
			//Agregar cdigo de validacin
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


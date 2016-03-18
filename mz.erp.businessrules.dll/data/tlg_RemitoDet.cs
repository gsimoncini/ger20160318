namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tlg_RemitoDet : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tlg_RemitoDet()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tlg_RemitoDet
		/// </summary>
		public static tlg_RemitoDetDataset GetList()
		{
			return mz.erp.dataaccess.tlg_RemitoDet.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tlg_RemitoDet filtrada por las condiciones de bsqueda
		/// </summary>
		public static tlg_RemitoDetDataset GetList( long IdRemito, string IdProducto, decimal Cantidad, decimal Precio, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tlg_RemitoDet.GetList( IdRemito, IdProducto, Cantidad, Precio, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tlg_RemitoDetRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tlg_RemitoDetDataset.tlg_RemitoDetRow NewRow()
		{
			return mz.erp.dataaccess.tlg_RemitoDet.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_RemitoDet que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tlg_RemitoDetDataset.tlg_RemitoDetRow GetByPk( long IdRemito, string IdProducto )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tlg_RemitoDet.GetByPk( IdRemito, IdProducto ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tlg_RemitoDetRow.
		/// </summary>
		public static tlg_RemitoDetDataset.tlg_RemitoDetRow SetRowDefaultValues( tlg_RemitoDetDataset.tlg_RemitoDetRow row )
		{
			row.IdRemito = 0; 
			row.IdProducto = Util.NewStringId(); 
			row.Cantidad = 0;
			row.Precio = 0;
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
		/// Envia los cambios del tlg_RemitoDetRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tlg_RemitoDetDataset.tlg_RemitoDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tlg_RemitoDetRow a la base de datos.
		/// </summary>
		public static void Update( tlg_RemitoDetDataset.tlg_RemitoDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_RemitoDet.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tlg_RemitoDetDataset a la base de datos.
		/// </summary>
		public static void Update( tlg_RemitoDetDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tlg_RemitoDet.Rows.Count > 0, "La tabla dataSet.tlg_RemitoDetDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_RemitoDet.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_RemitoDetDataset.tlg_RemitoDetDataTable a la base de datos.
		/// </summary>
		public static void Update( tlg_RemitoDetDataset.tlg_RemitoDetDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_RemitoDet.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tlg_RemitoDetRow.
		/// </summary>
		public static bool RowIsValid( tlg_RemitoDetDataset.tlg_RemitoDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdRemitoIsValid( row.IdRemito ) )
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
						
			if ( !PrecioIsValid( row.Precio ) )
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
		/// Valida el campo IdRemito.
		/// </summary>
		public static bool IdRemitoIsValid( long IdRemito )
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
		/// Valida el campo Precio.
		/// </summary>
		public static bool PrecioIsValid( decimal Precio )
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


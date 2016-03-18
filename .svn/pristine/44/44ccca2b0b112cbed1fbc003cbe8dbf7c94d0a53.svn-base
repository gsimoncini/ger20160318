namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_SeguimientoPedidos : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsa_SeguimientoPedidos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_SeguimientoPedidos
		/// </summary>
		public static tsa_SeguimientoPedidosDataset GetList()
		{
			return mz.erp.dataaccess.tsa_SeguimientoPedidos.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_SeguimientoPedidos filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_SeguimientoPedidosDataset GetList( long IdPedido, string IdProducto, short Renglon, DateTime Fecha, string Descripcion, string IdResponsable, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsa_SeguimientoPedidos.GetList( IdPedido, IdProducto, Renglon, Fecha, Descripcion, IdResponsable, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsa_SeguimientoPedidosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_SeguimientoPedidosDataset.tsa_SeguimientoPedidosRow NewRow()
		{
			return mz.erp.dataaccess.tsa_SeguimientoPedidos.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_SeguimientoPedidos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_SeguimientoPedidosDataset.tsa_SeguimientoPedidosRow GetByPk( long IdPedido, string IdProducto, short Renglon, DateTime Fecha )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsa_SeguimientoPedidos.GetByPk( IdPedido, IdProducto, Renglon, Fecha ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_SeguimientoPedidosRow.
		/// </summary>
		public static tsa_SeguimientoPedidosDataset.tsa_SeguimientoPedidosRow SetRowDefaultValues( tsa_SeguimientoPedidosDataset.tsa_SeguimientoPedidosRow row )
		{
			row.IdPedido = 0; 
			row.IdProducto = Util.NewStringId(); 
			row.Renglon = 0; 
			row.Fecha = DateTime.Now; 
			row.Descripcion = string.Empty;
			row.IdResponsable = string.Empty;
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
		/// Envia los cambios del tsa_SeguimientoPedidosRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsa_SeguimientoPedidosDataset.tsa_SeguimientoPedidosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsa_SeguimientoPedidosRow a la base de datos.
		/// </summary>
		public static void Update( tsa_SeguimientoPedidosDataset.tsa_SeguimientoPedidosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_SeguimientoPedidos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_SeguimientoPedidosDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_SeguimientoPedidosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_SeguimientoPedidos.Rows.Count > 0, "La tabla dataSet.tsa_SeguimientoPedidosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_SeguimientoPedidos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_SeguimientoPedidosDataset.tsa_SeguimientoPedidosDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_SeguimientoPedidosDataset.tsa_SeguimientoPedidosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_SeguimientoPedidos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_SeguimientoPedidosRow.
		/// </summary>
		public static bool RowIsValid( tsa_SeguimientoPedidosDataset.tsa_SeguimientoPedidosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdPedidoIsValid( row.IdPedido ) )
			{ 
				return false;
			}
						
			if ( !IdProductoIsValid( row.IdProducto ) )
			{ 
				return false;
			}
						
			if ( !RenglonIsValid( row.Renglon ) )
			{ 
				return false;
			}
						
			if ( !FechaIsValid( row.Fecha ) )
			{ 
				return false;
			}
						
			if ( !DescripcionIsValid( row.Descripcion ) )
			{ 
				return false;
			}
						
			if ( !IdResponsableIsValid( row.IdResponsable ) )
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
		/// Valida el campo IdPedido.
		/// </summary>
		public static bool IdPedidoIsValid( long IdPedido )
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
		/// Valida el campo Renglon.
		/// </summary>
		public static bool RenglonIsValid( short Renglon )
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
		/// Valida el campo Descripcion.
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdResponsable.
		/// </summary>
		public static bool IdResponsableIsValid( string IdResponsable )
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


namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_PedidosDet : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsa_PedidosDet()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_PedidosDet
		/// </summary>
		public static tsa_PedidosDetDataset GetList()
		{
			return mz.erp.dataaccess.tsa_PedidosDet.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_PedidosDet filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_PedidosDetDataset GetList( long IdPedido, string IdProducto, short Renglon, decimal Cantidad, decimal Resuelto, bool AceptaVariante, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsa_PedidosDet.GetList( IdPedido, IdProducto, Renglon, Cantidad, Resuelto, AceptaVariante, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsa_PedidosDetRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_PedidosDetDataset.tsa_PedidosDetRow NewRow()
		{
			return mz.erp.dataaccess.tsa_PedidosDet.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_PedidosDet que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_PedidosDetDataset.tsa_PedidosDetRow GetByPk( long IdPedido, string IdProducto, short Renglon )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsa_PedidosDet.GetByPk( IdPedido, IdProducto, Renglon ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_PedidosDetRow.
		/// </summary>
		public static tsa_PedidosDetDataset.tsa_PedidosDetRow SetRowDefaultValues( tsa_PedidosDetDataset.tsa_PedidosDetRow row )
		{
			row.IdPedido = 0; 
			row.IdProducto = Util.NewStringId(); 
			row.Renglon = 0; 
			row.Cantidad = 0;
			row.Resuelto = 0;
			row.AceptaVariante = false;
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
		/// Envia los cambios del tsa_PedidosDetRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsa_PedidosDetDataset.tsa_PedidosDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsa_PedidosDetRow a la base de datos.
		/// </summary>
		public static void Update( tsa_PedidosDetDataset.tsa_PedidosDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_PedidosDet.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_PedidosDetDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_PedidosDetDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_PedidosDet.Rows.Count > 0, "La tabla dataSet.tsa_PedidosDetDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_PedidosDet.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_PedidosDetDataset.tsa_PedidosDetDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_PedidosDetDataset.tsa_PedidosDetDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_PedidosDet.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_PedidosDetRow.
		/// </summary>
		public static bool RowIsValid( tsa_PedidosDetDataset.tsa_PedidosDetRow row )
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
						
			if ( !CantidadIsValid( row.Cantidad ) )
			{ 
				return false;
			}
						
			if ( !ResueltoIsValid( row.Resuelto ) )
			{ 
				return false;
			}
						
			if ( !AceptaVarianteIsValid( row.AceptaVariante ) )
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
		/// Valida el campo Cantidad.
		/// </summary>
		public static bool CantidadIsValid( decimal Cantidad )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Resuelto.
		/// </summary>
		public static bool ResueltoIsValid( decimal Resuelto )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo AceptaVariante.
		/// </summary>
		public static bool AceptaVarianteIsValid( bool AceptaVariante )
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


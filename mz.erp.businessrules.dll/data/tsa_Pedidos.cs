namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_Pedidos : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsa_Pedidos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_Pedidos
		/// </summary>
		public static tsa_PedidosDataset GetList()
		{
			return mz.erp.dataaccess.tsa_Pedidos.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_Pedidos filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_PedidosDataset GetList( long IdPedido, DateTime Fecha, DateTime Fevarcharegistracion, string IdResponsable, string IdCuenta, string Comentario, DateTime FechaVencimiento, long IdEstado, string Origen, DateTime FechaCierre, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsa_Pedidos.GetList( IdPedido, Fecha, Fevarcharegistracion, IdResponsable, IdCuenta, Comentario, FechaVencimiento, IdEstado, Origen, FechaCierre, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsa_PedidosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_PedidosDataset.tsa_PedidosRow NewRow()
		{
			return mz.erp.dataaccess.tsa_Pedidos.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_Pedidos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_PedidosDataset.tsa_PedidosRow GetByPk( long IdPedido )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsa_Pedidos.GetByPk( IdPedido ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_PedidosRow.
		/// </summary>
		public static tsa_PedidosDataset.tsa_PedidosRow SetRowDefaultValues( tsa_PedidosDataset.tsa_PedidosRow row )
		{
			row.IdPedido = 0; 
			row.Fecha = DateTime.Now;
			row.Fevarcharegistracion = DateTime.Now;
			row.IdResponsable = string.Empty;
			row.IdCuenta = string.Empty;
			row.Comentario = string.Empty;
			row.FechaVencimiento = DateTime.Now;
			row.IdEstado = 0;
			row.Origen = string.Empty;
			row.FechaCierre = DateTime.Now;
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
		/// Envia los cambios del tsa_PedidosRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsa_PedidosDataset.tsa_PedidosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsa_PedidosRow a la base de datos.
		/// </summary>
		public static void Update( tsa_PedidosDataset.tsa_PedidosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_Pedidos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_PedidosDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_PedidosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_Pedidos.Rows.Count > 0, "La tabla dataSet.tsa_PedidosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_Pedidos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_PedidosDataset.tsa_PedidosDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_PedidosDataset.tsa_PedidosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_Pedidos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_PedidosRow.
		/// </summary>
		public static bool RowIsValid( tsa_PedidosDataset.tsa_PedidosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdPedidoIsValid( row.IdPedido ) )
			{ 
				return false;
			}
						
			if ( !FechaIsValid( row.Fecha ) )
			{ 
				return false;
			}
						
			if ( !FevarcharegistracionIsValid( row.Fevarcharegistracion ) )
			{ 
				return false;
			}
						
			if ( !IdResponsableIsValid( row.IdResponsable ) )
			{ 
				return false;
			}
						
			if ( !IdCuentaIsValid( row.IdCuenta ) )
			{ 
				return false;
			}
						
			if ( !ComentarioIsValid( row.Comentario ) )
			{ 
				return false;
			}
						
			if ( !FechaVencimientoIsValid( row.FechaVencimiento ) )
			{ 
				return false;
			}
						
			if ( !IdEstadoIsValid( row.IdEstado ) )
			{ 
				return false;
			}
						
			if ( !OrigenIsValid( row.Origen ) )
			{ 
				return false;
			}
						
			if ( !FechaCierreIsValid( row.FechaCierre ) )
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
		/// Valida el campo Fecha.
		/// </summary>
		public static bool FechaIsValid( DateTime Fecha )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Fevarcharegistracion.
		/// </summary>
		public static bool FevarcharegistracionIsValid( DateTime Fevarcharegistracion )
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
		/// Valida el campo IdCuenta.
		/// </summary>
		public static bool IdCuentaIsValid( string IdCuenta )
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
		/// Valida el campo FechaVencimiento.
		/// </summary>
		public static bool FechaVencimientoIsValid( DateTime FechaVencimiento )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEstado.
		/// </summary>
		public static bool IdEstadoIsValid( long IdEstado )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Origen.
		/// </summary>
		public static bool OrigenIsValid( string Origen )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaCierre.
		/// </summary>
		public static bool FechaCierreIsValid( DateTime FechaCierre )
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


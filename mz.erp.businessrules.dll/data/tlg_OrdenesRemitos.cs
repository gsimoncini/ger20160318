namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tlg_OrdenesRemitos : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tlg_OrdenesRemitos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tlg_OrdenesRemitos
		/// </summary>
		public static tlg_OrdenesRemitosDataset GetList()
		{
			return mz.erp.dataaccess.tlg_OrdenesRemitos.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tlg_OrdenesRemitos filtrada por las condiciones de bsqueda
		/// </summary>
		public static tlg_OrdenesRemitosDataset GetList( long IdOrdenPreparacion, string IdProductoOrden, long IdRemito, string IdProductoRemito, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tlg_OrdenesRemitos.GetList( IdOrdenPreparacion, IdProductoOrden, IdRemito, IdProductoRemito, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tlg_OrdenesRemitosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tlg_OrdenesRemitosDataset.tlg_OrdenesRemitosRow NewRow()
		{
			return mz.erp.dataaccess.tlg_OrdenesRemitos.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_OrdenesRemitos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tlg_OrdenesRemitosDataset.tlg_OrdenesRemitosRow GetByPk( long IdOrdenPreparacion, string IdProductoOrden, long IdRemito, string IdProductoRemito )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tlg_OrdenesRemitos.GetByPk( IdOrdenPreparacion, IdProductoOrden, IdRemito, IdProductoRemito ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tlg_OrdenesRemitosRow.
		/// </summary>
		public static tlg_OrdenesRemitosDataset.tlg_OrdenesRemitosRow SetRowDefaultValues( tlg_OrdenesRemitosDataset.tlg_OrdenesRemitosRow row )
		{
			row.IdOrdenPreparacion = 0; 
			row.IdProductoOrden = Util.NewStringId(); 
			row.IdRemito = 0; 
			row.IdProductoRemito = Util.NewStringId(); 
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
		/// Envia los cambios del tlg_OrdenesRemitosRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tlg_OrdenesRemitosDataset.tlg_OrdenesRemitosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tlg_OrdenesRemitosRow a la base de datos.
		/// </summary>
		public static void Update( tlg_OrdenesRemitosDataset.tlg_OrdenesRemitosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_OrdenesRemitos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tlg_OrdenesRemitosDataset a la base de datos.
		/// </summary>
		public static void Update( tlg_OrdenesRemitosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tlg_OrdenesRemitos.Rows.Count > 0, "La tabla dataSet.tlg_OrdenesRemitosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_OrdenesRemitos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_OrdenesRemitosDataset.tlg_OrdenesRemitosDataTable a la base de datos.
		/// </summary>
		public static void Update( tlg_OrdenesRemitosDataset.tlg_OrdenesRemitosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_OrdenesRemitos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tlg_OrdenesRemitosRow.
		/// </summary>
		public static bool RowIsValid( tlg_OrdenesRemitosDataset.tlg_OrdenesRemitosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdOrdenPreparacionIsValid( row.IdOrdenPreparacion ) )
			{ 
				return false;
			}
						
			if ( !IdProductoOrdenIsValid( row.IdProductoOrden ) )
			{ 
				return false;
			}
						
			if ( !IdRemitoIsValid( row.IdRemito ) )
			{ 
				return false;
			}
						
			if ( !IdProductoRemitoIsValid( row.IdProductoRemito ) )
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
		/// Valida el campo IdOrdenPreparacion.
		/// </summary>
		public static bool IdOrdenPreparacionIsValid( long IdOrdenPreparacion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProductoOrden.
		/// </summary>
		public static bool IdProductoOrdenIsValid( string IdProductoOrden )
		{
			//Agregar cdigo de validacin
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
		/// Valida el campo IdProductoRemito.
		/// </summary>
		public static bool IdProductoRemitoIsValid( string IdProductoRemito )
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


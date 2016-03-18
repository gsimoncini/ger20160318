namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_RemitosCompras : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_RemitosCompras()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_RemitosCompras
		/// </summary>
		public static tpu_RemitosComprasDataset GetList()
		{
			return mz.erp.dataaccess.tpu_RemitosCompras.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_RemitosCompras filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_RemitosComprasDataset GetList( long IdRemitoCompra, long IdProveedor, string Codigo, DateTime Fecha, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tpu_RemitosCompras.GetList( IdRemitoCompra, IdProveedor, Codigo, Fecha, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tpu_RemitosComprasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_RemitosComprasDataset.tpu_RemitosComprasRow NewRow()
		{
			return mz.erp.dataaccess.tpu_RemitosCompras.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_RemitosCompras que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_RemitosComprasDataset.tpu_RemitosComprasRow GetByPk( long IdRemitoCompra )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tpu_RemitosCompras.GetByPk( IdRemitoCompra ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_RemitosComprasRow.
		/// </summary>
		public static tpu_RemitosComprasDataset.tpu_RemitosComprasRow SetRowDefaultValues( tpu_RemitosComprasDataset.tpu_RemitosComprasRow row )
		{
			row.IdRemitoCompra = 0; 
			row.IdProveedor = 0;
			row.Codigo = string.Empty;
			row.Fecha = mz.erp.businessrules.Sistema.DateTime.Now;
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
		/// Envia los cambios del tpu_RemitosComprasRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tpu_RemitosComprasDataset.tpu_RemitosComprasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tpu_RemitosComprasRow a la base de datos.
		/// </summary>
		public static void Update( tpu_RemitosComprasDataset.tpu_RemitosComprasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_RemitosCompras.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_RemitosComprasDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_RemitosComprasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_RemitosCompras.Rows.Count > 0, "La tabla dataSet.tpu_RemitosComprasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_RemitosCompras.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_RemitosComprasDataset.tpu_RemitosComprasDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_RemitosComprasDataset.tpu_RemitosComprasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_RemitosCompras.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_RemitosComprasRow.
		/// </summary>
		public static bool RowIsValid( tpu_RemitosComprasDataset.tpu_RemitosComprasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdRemitoCompraIsValid( row.IdRemitoCompra ) )
			{ 
				return false;
			}
						
			if ( !IdProveedorIsValid( row.IdProveedor ) )
			{ 
				return false;
			}
						
			if ( !CodigoIsValid( row.Codigo ) )
			{ 
				return false;
			}
						
			if ( !FechaIsValid( row.Fecha ) )
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
		/// Valida el campo IdRemitoCompra.
		/// </summary>
		public static bool IdRemitoCompraIsValid( long IdRemitoCompra )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProveedor.
		/// </summary>
		public static bool IdProveedorIsValid( long IdProveedor )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Codigo.
		/// </summary>
		public static bool CodigoIsValid( string Codigo )
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


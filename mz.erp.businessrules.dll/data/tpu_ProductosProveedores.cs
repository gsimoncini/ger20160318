namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_ProductosProveedores : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_ProductosProveedores()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_ProductosProveedores
		/// </summary>
		public static tpu_ProductosProveedoresDataset GetList()
		{
			return mz.erp.dataaccess.tpu_ProductosProveedores.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_ProductosProveedores filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_ProductosProveedoresDataset GetList( string IdProducto, long IdProveedor )
		{
			return mz.erp.dataaccess.tpu_ProductosProveedores.GetList( IdProducto, IdProveedor );
		}

		/// <summary>
		/// Crea un tpu_ProductosProveedoresRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_ProductosProveedoresDataset.tpu_ProductosProveedoresRow NewRow()
		{
			return mz.erp.dataaccess.tpu_ProductosProveedores.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_ProductosProveedores que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_ProductosProveedoresDataset.tpu_ProductosProveedoresRow GetByPk( string IdProducto, long IdProveedor )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tpu_ProductosProveedores.GetByPk( IdProducto, IdProveedor ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_ProductosProveedoresRow.
		/// </summary>
		public static tpu_ProductosProveedoresDataset.tpu_ProductosProveedoresRow SetRowDefaultValues( tpu_ProductosProveedoresDataset.tpu_ProductosProveedoresRow row )
		{
			row.IdProducto = Util.NewStringId(); 
			row.IdProveedor = 0; 
			row.PrecioCosto = 0;
			row.Bonificacion = 0;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProductosProveedoresRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tpu_ProductosProveedoresDataset.tpu_ProductosProveedoresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tpu_ProductosProveedoresRow a la base de datos.
		/// </summary>
		public static void Update( tpu_ProductosProveedoresDataset.tpu_ProductosProveedoresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ProductosProveedores.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_ProductosProveedoresDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_ProductosProveedoresDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_ProductosProveedores.Rows.Count > 0, "La tabla dataSet.tpu_ProductosProveedoresDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ProductosProveedores.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProductosProveedoresDataset.tpu_ProductosProveedoresDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_ProductosProveedoresDataset.tpu_ProductosProveedoresDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ProductosProveedores.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_ProductosProveedoresRow.
		/// </summary>
		public static bool RowIsValid( tpu_ProductosProveedoresDataset.tpu_ProductosProveedoresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdProductoIsValid( row.IdProducto ) )
			{ 
				return false;
			}
						
			if ( !IdProveedorIsValid( row.IdProveedor ) )
			{ 
				return false;
			}
						
			if ( !PrecioCostoIsValid( row.PrecioCosto ) )
			{ 
				return false;
			}
						
			if ( !BonificacionIsValid( row.Bonificacion ) )
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
		/// Valida el campo IdProveedor.
		/// </summary>
		public static bool IdProveedorIsValid( long IdProveedor )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo PrecioCosto.
		/// </summary>
		public static bool PrecioCostoIsValid( decimal PrecioCosto )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Bonificacion.
		/// </summary>
		public static bool BonificacionIsValid( decimal Bonificacion )
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


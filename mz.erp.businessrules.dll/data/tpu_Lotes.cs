namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_Lotes : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_Lotes()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_Lotes
		/// </summary>
		public static tpu_LotesDataset GetList()
		{
			return mz.erp.dataaccess.tpu_Lotes.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_Lotes filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_LotesDataset GetList( long IdLote, string IdProducto, string Codigo, DateTime FechaIngreso, DateTime FechaLiquidacion, DateTime FechaVencimiento, decimal Cantidad, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tpu_Lotes.GetList( IdLote, IdProducto, Codigo, FechaIngreso, FechaLiquidacion, FechaVencimiento, Cantidad, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tpu_LotesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_LotesDataset.tpu_LotesRow NewRow()
		{
			return mz.erp.dataaccess.tpu_Lotes.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_Lotes que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_LotesDataset.tpu_LotesRow GetByPk( long IdLote, string IdProducto )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tpu_Lotes.GetByPk( IdLote, IdProducto ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_LotesRow.
		/// </summary>
		public static tpu_LotesDataset.tpu_LotesRow SetRowDefaultValues( tpu_LotesDataset.tpu_LotesRow row )
		{
			row.IdLote = 0; 
			row.IdProducto = Util.NewStringId(); 
			row.Codigo = string.Empty;
			row.FechaIngreso = mz.erp.businessrules.Sistema.DateTime.Now;
			row.FechaLiquidacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.FechaVencimiento = mz.erp.businessrules.Sistema.DateTime.Now;
			row.Cantidad = 0;
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
		/// Envia los cambios del tpu_LotesRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tpu_LotesDataset.tpu_LotesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tpu_LotesRow a la base de datos.
		/// </summary>
		public static void Update( tpu_LotesDataset.tpu_LotesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_Lotes.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_LotesDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_LotesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_Lotes.Rows.Count > 0, "La tabla dataSet.tpu_LotesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_Lotes.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_LotesDataset.tpu_LotesDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_LotesDataset.tpu_LotesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_Lotes.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_LotesRow.
		/// </summary>
		public static bool RowIsValid( tpu_LotesDataset.tpu_LotesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdLoteIsValid( row.IdLote ) )
			{ 
				return false;
			}
						
			if ( !IdProductoIsValid( row.IdProducto ) )
			{ 
				return false;
			}
						
			if ( !CodigoIsValid( row.Codigo ) )
			{ 
				return false;
			}
						
			if ( !FechaIngresoIsValid( row.FechaIngreso ) )
			{ 
				return false;
			}
						
			if ( !FechaLiquidacionIsValid( row.FechaLiquidacion ) )
			{ 
				return false;
			}
						
			if ( !FechaVencimientoIsValid( row.FechaVencimiento ) )
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
		/// Valida el campo IdLote.
		/// </summary>
		public static bool IdLoteIsValid( long IdLote )
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
		/// Valida el campo Codigo.
		/// </summary>
		public static bool CodigoIsValid( string Codigo )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaIngreso.
		/// </summary>
		public static bool FechaIngresoIsValid( DateTime FechaIngreso )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaLiquidacion.
		/// </summary>
		public static bool FechaLiquidacionIsValid( DateTime FechaLiquidacion )
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


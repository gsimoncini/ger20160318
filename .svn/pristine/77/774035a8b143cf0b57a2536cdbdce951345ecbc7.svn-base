namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_VariantesStock : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsa_VariantesStock()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_VariantesStock
		/// </summary>
		public static tsa_VariantesStockDataset GetList()
		{
			return mz.erp.dataaccess.tsa_VariantesStock.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_VariantesStock filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_VariantesStockDataset GetList( string IdProducto, long IdVariante, decimal Cantidad, string FormulaCalculoCantidad, byte Prioridad, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsa_VariantesStock.GetList( IdProducto, IdVariante, Cantidad, FormulaCalculoCantidad, Prioridad, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsa_VariantesStockRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_VariantesStockDataset.tsa_VariantesStockRow NewRow()
		{
			return mz.erp.dataaccess.tsa_VariantesStock.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_VariantesStock que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_VariantesStockDataset.tsa_VariantesStockRow GetByPk( string IdProducto, long IdVariante )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsa_VariantesStock.GetByPk( IdProducto, IdVariante ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_VariantesStockRow.
		/// </summary>
		public static tsa_VariantesStockDataset.tsa_VariantesStockRow SetRowDefaultValues( tsa_VariantesStockDataset.tsa_VariantesStockRow row )
		{
			row.IdProducto = Util.NewStringId(); 
			row.IdVariante = 0; 
			row.Cantidad = 0;
			row.FormulaCalculoCantidad = string.Empty;
			row.Prioridad = 0;
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
		/// Envia los cambios del tsa_VariantesStockRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsa_VariantesStockDataset.tsa_VariantesStockRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsa_VariantesStockRow a la base de datos.
		/// </summary>
		public static void Update( tsa_VariantesStockDataset.tsa_VariantesStockRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_VariantesStock.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_VariantesStockDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_VariantesStockDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_VariantesStock.Rows.Count > 0, "La tabla dataSet.tsa_VariantesStockDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_VariantesStock.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_VariantesStockDataset.tsa_VariantesStockDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_VariantesStockDataset.tsa_VariantesStockDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_VariantesStock.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_VariantesStockRow.
		/// </summary>
		public static bool RowIsValid( tsa_VariantesStockDataset.tsa_VariantesStockRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdProductoIsValid( row.IdProducto ) )
			{ 
				return false;
			}
						
			if ( !IdVarianteIsValid( row.IdVariante ) )
			{ 
				return false;
			}
						
			if ( !CantidadIsValid( row.Cantidad ) )
			{ 
				return false;
			}
						
			if ( !FormulaCalculoCantidadIsValid( row.FormulaCalculoCantidad ) )
			{ 
				return false;
			}
						
			if ( !PrioridadIsValid( row.Prioridad ) )
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
		/// Valida el campo IdVariante.
		/// </summary>
		public static bool IdVarianteIsValid( long IdVariante )
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
		/// Valida el campo FormulaCalculoCantidad.
		/// </summary>
		public static bool FormulaCalculoCantidadIsValid( string FormulaCalculoCantidad )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Prioridad.
		/// </summary>
		public static bool PrioridadIsValid( byte Prioridad )
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


namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_ComboDet : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsa_ComboDet()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_ComboDet
		/// </summary>
		public static tsa_ComboDetDataset GetList()
		{
			return mz.erp.dataaccess.tsa_ComboDet.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_ComboDet filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_ComboDetDataset GetList( long IdCombo, string IdProducto, decimal Cantidad, string FormulaCalculoCantidad, byte Orden, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsa_ComboDet.GetList( IdCombo, IdProducto, Cantidad, FormulaCalculoCantidad, Orden, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsa_ComboDetRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_ComboDetDataset.tsa_ComboDetRow NewRow()
		{
			return mz.erp.dataaccess.tsa_ComboDet.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_ComboDet que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_ComboDetDataset.tsa_ComboDetRow GetByPk( long IdCombo )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsa_ComboDet.GetByPk( IdCombo ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_ComboDetRow.
		/// </summary>
		public static tsa_ComboDetDataset.tsa_ComboDetRow SetRowDefaultValues( tsa_ComboDetDataset.tsa_ComboDetRow row )
		{
			row.IdCombo = 0; 
			row.IdProducto = string.Empty;
			row.Cantidad = 0;
			row.FormulaCalculoCantidad = string.Empty;
			//row.Orden = null;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComboDetRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsa_ComboDetDataset.tsa_ComboDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsa_ComboDetRow a la base de datos.
		/// </summary>
		public static void Update( tsa_ComboDetDataset.tsa_ComboDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComboDet.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_ComboDetDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_ComboDetDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_ComboDet.Rows.Count > 0, "La tabla dataSet.tsa_ComboDetDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComboDet.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComboDetDataset.tsa_ComboDetDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_ComboDetDataset.tsa_ComboDetDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComboDet.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_ComboDetRow.
		/// </summary>
		public static bool RowIsValid( tsa_ComboDetDataset.tsa_ComboDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdComboIsValid( row.IdCombo ) )
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
						
			if ( !FormulaCalculoCantidadIsValid( row.FormulaCalculoCantidad ) )
			{ 
				return false;
			}
						
			if ( !OrdenIsValid( row.Orden ) )
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
		/// Valida el campo IdCombo.
		/// </summary>
		public static bool IdComboIsValid( long IdCombo )
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
		/// Valida el campo FormulaCalculoCantidad.
		/// </summary>
		public static bool FormulaCalculoCantidadIsValid( string FormulaCalculoCantidad )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Orden.
		/// </summary>
		public static bool OrdenIsValid( byte Orden )
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


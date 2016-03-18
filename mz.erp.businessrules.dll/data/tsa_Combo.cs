namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_Combo : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsa_Combo()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_Combo
		/// </summary>
		public static tsa_ComboDataset GetList()
		{
			return mz.erp.dataaccess.tsa_Combo.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_Combo filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_ComboDataset GetList( long IdCombo, string Descripcion, decimal BonificacionRecargo, decimal PrecioFijo, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsa_Combo.GetList( IdCombo, Descripcion, BonificacionRecargo, PrecioFijo, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsa_ComboRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_ComboDataset.tsa_ComboRow NewRow()
		{
			return mz.erp.dataaccess.tsa_Combo.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_Combo que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_ComboDataset.tsa_ComboRow GetByPk( long IdCombo )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsa_Combo.GetByPk( IdCombo ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_ComboRow.
		/// </summary>
		public static tsa_ComboDataset.tsa_ComboRow SetRowDefaultValues( tsa_ComboDataset.tsa_ComboRow row )
		{
			row.IdCombo = 0; 
			row.Descripcion = string.Empty;
			row.BonificacionRecargo = 0;
			row.PrecioFijo = 0;
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
		/// Envia los cambios del tsa_ComboRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsa_ComboDataset.tsa_ComboRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsa_ComboRow a la base de datos.
		/// </summary>
		public static void Update( tsa_ComboDataset.tsa_ComboRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_Combo.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_ComboDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_ComboDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_Combo.Rows.Count > 0, "La tabla dataSet.tsa_ComboDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_Combo.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComboDataset.tsa_ComboDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_ComboDataset.tsa_ComboDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_Combo.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_ComboRow.
		/// </summary>
		public static bool RowIsValid( tsa_ComboDataset.tsa_ComboRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdComboIsValid( row.IdCombo ) )
			{ 
				return false;
			}
						
			if ( !DescripcionIsValid( row.Descripcion ) )
			{ 
				return false;
			}
						
			if ( !BonificacionRecargoIsValid( row.BonificacionRecargo ) )
			{ 
				return false;
			}
						
			if ( !PrecioFijoIsValid( row.PrecioFijo ) )
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
		/// Valida el campo Descripcion.
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo BonificacionRecargo.
		/// </summary>
		public static bool BonificacionRecargoIsValid( decimal BonificacionRecargo )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo PrecioFijo.
		/// </summary>
		public static bool PrecioFijoIsValid( decimal PrecioFijo )
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


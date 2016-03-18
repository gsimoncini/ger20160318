namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_ComisionesCotasVariables : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsa_ComisionesCotasVariables()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_ComisionesCotasVariables
		/// </summary>
		public static tsa_ComisionesCotasVariablesDataset GetList()
		{
			return mz.erp.dataaccess.tsa_ComisionesCotasVariables.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_ComisionesCotasVariables filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_ComisionesCotasVariablesDataset GetList( long IdComision, short Renglon, decimal CotaInferior, decimal CotaSuperior, decimal ValorAAplicar, string FormaDeAplicacion, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsa_ComisionesCotasVariables.GetList( IdComision, Renglon, CotaInferior, CotaSuperior, ValorAAplicar, FormaDeAplicacion, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsa_ComisionesCotasVariablesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_ComisionesCotasVariablesDataset.tsa_ComisionesCotasVariablesRow NewRow()
		{
			return mz.erp.dataaccess.tsa_ComisionesCotasVariables.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_ComisionesCotasVariables que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_ComisionesCotasVariablesDataset.tsa_ComisionesCotasVariablesRow GetByPk( long IdComision, short Renglon )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsa_ComisionesCotasVariables.GetByPk( IdComision, Renglon ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_ComisionesCotasVariablesRow.
		/// </summary>
		public static tsa_ComisionesCotasVariablesDataset.tsa_ComisionesCotasVariablesRow SetRowDefaultValues( tsa_ComisionesCotasVariablesDataset.tsa_ComisionesCotasVariablesRow row )
		{
			row.IdComision = 0; 
			row.Renglon = 0; 
			row.CotaInferior = 0;
			row.CotaSuperior = 0;
			row.ValorAAplicar = 0;
			row.FormaDeAplicacion = string.Empty;
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
		/// Envia los cambios del tsa_ComisionesCotasVariablesRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsa_ComisionesCotasVariablesDataset.tsa_ComisionesCotasVariablesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsa_ComisionesCotasVariablesRow a la base de datos.
		/// </summary>
		public static void Update( tsa_ComisionesCotasVariablesDataset.tsa_ComisionesCotasVariablesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComisionesCotasVariables.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_ComisionesCotasVariablesDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_ComisionesCotasVariablesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_ComisionesCotasVariables.Rows.Count > 0, "La tabla dataSet.tsa_ComisionesCotasVariablesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComisionesCotasVariables.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComisionesCotasVariablesDataset.tsa_ComisionesCotasVariablesDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_ComisionesCotasVariablesDataset.tsa_ComisionesCotasVariablesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComisionesCotasVariables.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_ComisionesCotasVariablesRow.
		/// </summary>
		public static bool RowIsValid( tsa_ComisionesCotasVariablesDataset.tsa_ComisionesCotasVariablesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdComisionIsValid( row.IdComision ) )
			{ 
				return false;
			}
						
			if ( !RenglonIsValid( row.Renglon ) )
			{ 
				return false;
			}
						
			if ( !CotaInferiorIsValid( row.CotaInferior ) )
			{ 
				return false;
			}
						
			if ( !CotaSuperiorIsValid( row.CotaSuperior ) )
			{ 
				return false;
			}
						
			if ( !ValorAAplicarIsValid( row.ValorAAplicar ) )
			{ 
				return false;
			}
						
			if ( !FormaDeAplicacionIsValid( row.FormaDeAplicacion ) )
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
		/// Valida el campo IdComision.
		/// </summary>
		public static bool IdComisionIsValid( long IdComision )
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
		/// Valida el campo CotaInferior.
		/// </summary>
		public static bool CotaInferiorIsValid( decimal CotaInferior )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo CotaSuperior.
		/// </summary>
		public static bool CotaSuperiorIsValid( decimal CotaSuperior )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo ValorAAplicar.
		/// </summary>
		public static bool ValorAAplicarIsValid( decimal ValorAAplicar )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo FormaDeAplicacion.
		/// </summary>
		public static bool FormaDeAplicacionIsValid( string FormaDeAplicacion )
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


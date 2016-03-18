namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_VariablesSucursales : IDisposable
	{
	
		#region Custom Members
		public static object GetValue( string IdVariable, int IdEmpresa, int IdSucursal )
		{
			sy_VariablesSucursalesDataset data = sy_VariablesSucursales.GetList( IdVariable, IdEmpresa, IdSucursal );
			if ( data != null && data.sy_VariablesSucursales.Rows.Count == 1 )
			{
				return ( ( sy_VariablesSucursalesDataset.sy_VariablesSucursalesRow ) data.sy_VariablesSucursales.Rows[ 0 ] ).Valor;
			}
			else
			{
				throw new ArgumentException( "No se ha encontrado el parámetro indicado" );
			}
		}		
		#endregion
		
		public sy_VariablesSucursales()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_VariablesSucursales
		/// </summary>
		public static sy_VariablesSucursalesDataset GetList()
		{
			return mz.erp.dataaccess.sy_VariablesSucursales.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla sy_VariablesSucursales filtrada por las condiciones de bsqueda
		/// </summary>
		public static sy_VariablesSucursalesDataset GetList( string IdVariable, long IdEmpresa, long IdSucursal )
		{
			return mz.erp.dataaccess.sy_VariablesSucursales.GetList( IdVariable, IdEmpresa, IdSucursal );
		}

		/// <summary>
		/// Crea un sy_VariablesSucursalesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_VariablesSucursalesDataset.sy_VariablesSucursalesRow NewRow()
		{
			return mz.erp.dataaccess.sy_VariablesSucursales.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_VariablesSucursales que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_VariablesSucursalesDataset.sy_VariablesSucursalesRow GetByPk( string IdVariable, long IdEmpresa, long IdSucursal )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.sy_VariablesSucursales.GetByPk( IdVariable, IdEmpresa, IdSucursal ) );
		}

		/// <summary>
		/// Establece los valores por defecto de sy_VariablesSucursalesRow.
		/// </summary>
		public static sy_VariablesSucursalesDataset.sy_VariablesSucursalesRow SetRowDefaultValues( sy_VariablesSucursalesDataset.sy_VariablesSucursalesRow row )
		{
			row.IdVariable = Util.NewStringId(); 
			row.IdEmpresa = 0; 
			row.IdSucursal = 0; 
			row.Valor = string.Empty;
			row.FechaCreacion = DateTime.Now;
			row.IdConecxionCreacion = 0;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del sy_VariablesSucursalesRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( sy_VariablesSucursalesDataset.sy_VariablesSucursalesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del sy_VariablesSucursalesRow a la base de datos.
		/// </summary>
		public static void Update( sy_VariablesSucursalesDataset.sy_VariablesSucursalesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_VariablesSucursales.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_VariablesSucursalesDataset a la base de datos.
		/// </summary>
		public static void Update( sy_VariablesSucursalesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_VariablesSucursales.Rows.Count > 0, "La tabla dataSet.sy_VariablesSucursalesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_VariablesSucursales.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_VariablesSucursalesDataset.sy_VariablesSucursalesDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_VariablesSucursalesDataset.sy_VariablesSucursalesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_VariablesSucursales.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_VariablesSucursalesRow.
		/// </summary>
		public static bool RowIsValid( sy_VariablesSucursalesDataset.sy_VariablesSucursalesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdVariableIsValid( row.IdVariable ) )
			{ 
				return false;
			}
						
			if ( !IdEmpresaIsValid( row.IdEmpresa ) )
			{ 
				return false;
			}
						
			if ( !IdSucursalIsValid( row.IdSucursal ) )
			{ 
				return false;
			}
						
			if ( !ValorIsValid( row.Valor ) )
			{ 
				return false;
			}
						
			if ( !FechaCreacionIsValid( row.FechaCreacion ) )
			{ 
				return false;
			}
						
			if ( !IdConecxionCreacionIsValid( row.IdConecxionCreacion ) )
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
						
			if ( !RowIdIsValid( row.RowId ) )
			{ 
				return false;
			}
			;
			
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdVariable.
		/// </summary>
		public static bool IdVariableIsValid( string IdVariable )
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
		
		/// <summary>
		/// Valida el campo IdSucursal.
		/// </summary>
		public static bool IdSucursalIsValid( long IdSucursal )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Valor.
		/// </summary>
		public static bool ValorIsValid( string Valor )
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
		/// Valida el campo IdConecxionCreacion.
		/// </summary>
		public static bool IdConecxionCreacionIsValid( long IdConecxionCreacion )
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
		/// Valida el campo RowId.
		/// </summary>
		public static bool RowIdIsValid( Guid RowId )
		{
			//Agregar cdigo de validacin
			return true;
		}
		

		public void Dispose()
		{
		}
		
	}
}


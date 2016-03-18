namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_Sucesos : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public sy_Sucesos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_Sucesos
		/// </summary>
		public static sy_SucesosDataset GetList()
		{
			return mz.erp.dataaccess.sy_Sucesos.GetList();
		}

		/// <summary>
		/// Crea un sy_SucesosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_SucesosDataset.sy_SucesosRow NewRow()
		{
			return mz.erp.dataaccess.sy_Sucesos.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_Sucesos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_SucesosDataset.sy_SucesosRow GetByPk( long IdSuceso )
		{
			return mz.erp.dataaccess.sy_Sucesos.GetByPk( IdSuceso );
		}
		
		/// <summary>
		/// Envia los cambios del sy_SucesosRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( sy_SucesosDataset.sy_SucesosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del sy_SucesosRow a la base de datos.
		/// </summary>
		public static void Update( sy_SucesosDataset.sy_SucesosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Sucesos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_SucesosDataset a la base de datos.
		/// </summary>
		public static void Update( sy_SucesosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_Sucesos.Rows.Count > 0, "La tabla dataSet.sy_SucesosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Sucesos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_SucesosDataset.sy_SucesosDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_SucesosDataset.sy_SucesosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Sucesos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_SucesosRow.
		/// </summary>
		public static bool RowIsValid( sy_SucesosDataset.sy_SucesosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdSucesoIsValid( row.IdSuceso ) )
			{ 
				return false;
			}
						
			if ( !IdTipoSucesoIsValid( row.IdTipoSuceso ) )
			{ 
				return false;
			}
						
			if ( !FechaIsValid( row.Fecha ) )
			{ 
				return false;
			}
						
			if ( !MensajeIsValid( row.Mensaje ) )
			{ 
				return false;
			}
						
			if ( !IdConexionIsValid( row.IdConexion ) )
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
						
			if ( !RowIdIsValid( row.RowId ) )
			{ 
				return false;
			}
			;
			
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSuceso.
		/// </summary>
		public static bool IdSucesoIsValid( long IdSuceso )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoSuceso.
		/// </summary>
		public static bool IdTipoSucesoIsValid( long IdTipoSuceso )
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
		/// Valida el campo Mensaje.
		/// </summary>
		public static bool MensajeIsValid( string Mensaje )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexion.
		/// </summary>
		public static bool IdConexionIsValid( long IdConexion )
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


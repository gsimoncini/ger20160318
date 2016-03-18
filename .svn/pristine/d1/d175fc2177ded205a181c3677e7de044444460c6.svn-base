namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_TiposSucesos : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public sy_TiposSucesos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_TiposSucesos
		/// </summary>
		public static sy_TiposSucesosDataset GetList()
		{
			return mz.erp.dataaccess.sy_TiposSucesos.GetList();
		}

		/// <summary>
		/// Crea un sy_TiposSucesosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_TiposSucesosDataset.sy_TiposSucesosRow NewRow()
		{
			return mz.erp.dataaccess.sy_TiposSucesos.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_TiposSucesos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_TiposSucesosDataset.sy_TiposSucesosRow GetByPk( long IdTipoSuceso )
		{
			return mz.erp.dataaccess.sy_TiposSucesos.GetByPk( IdTipoSuceso );
		}
		
		/// <summary>
		/// Envia los cambios del sy_TiposSucesosRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( sy_TiposSucesosDataset.sy_TiposSucesosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del sy_TiposSucesosRow a la base de datos.
		/// </summary>
		public static void Update( sy_TiposSucesosDataset.sy_TiposSucesosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_TiposSucesos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_TiposSucesosDataset a la base de datos.
		/// </summary>
		public static void Update( sy_TiposSucesosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_TiposSucesos.Rows.Count > 0, "La tabla dataSet.sy_TiposSucesosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_TiposSucesos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_TiposSucesosDataset.sy_TiposSucesosDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_TiposSucesosDataset.sy_TiposSucesosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_TiposSucesos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_TiposSucesosRow.
		/// </summary>
		public static bool RowIsValid( sy_TiposSucesosDataset.sy_TiposSucesosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdTipoSucesoIsValid( row.IdTipoSuceso ) )
			{ 
				return false;
			}
						
			if ( !DescripcionIsValid( row.Descripcion ) )
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
		/// Valida el campo IdTipoSuceso.
		/// </summary>
		public static bool IdTipoSucesoIsValid( long IdTipoSuceso )
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


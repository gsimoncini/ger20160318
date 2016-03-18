namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_Idiomas : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public sy_Idiomas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_Idiomas
		/// </summary>
		public static sy_IdiomasDataset GetList()
		{
			return mz.erp.dataaccess.sy_Idiomas.GetList();
		}

		/// <summary>
		/// Crea un sy_IdiomasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_IdiomasDataset.sy_IdiomasRow NewRow()
		{
			return mz.erp.dataaccess.sy_Idiomas.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_Idiomas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_IdiomasDataset.sy_IdiomasRow GetByPk( long IdIdioma )
		{
			return mz.erp.dataaccess.sy_Idiomas.GetByPk( IdIdioma );
		}
		
		/// <summary>
		/// Envia los cambios del sy_IdiomasRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( sy_IdiomasDataset.sy_IdiomasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del sy_IdiomasRow a la base de datos.
		/// </summary>
		public static void Update( sy_IdiomasDataset.sy_IdiomasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Idiomas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_IdiomasDataset a la base de datos.
		/// </summary>
		public static void Update( sy_IdiomasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_Idiomas.Rows.Count > 0, "La tabla dataSet.sy_IdiomasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Idiomas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_IdiomasDataset.sy_IdiomasDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_IdiomasDataset.sy_IdiomasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Idiomas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_IdiomasRow.
		/// </summary>
		public static bool RowIsValid( sy_IdiomasDataset.sy_IdiomasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdIdiomaIsValid( row.IdIdioma ) )
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
		/// Valida el campo IdIdioma.
		/// </summary>
		public static bool IdIdiomaIsValid( long IdIdioma )
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


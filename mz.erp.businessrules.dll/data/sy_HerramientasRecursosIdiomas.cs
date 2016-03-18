namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_HerramientasRecursosIdiomas : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public sy_HerramientasRecursosIdiomas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_HerramientasRecursosIdiomas
		/// </summary>
		public static sy_HerramientasRecursosIdiomasDataset GetList()
		{
			return mz.erp.dataaccess.sy_HerramientasRecursosIdiomas.GetList();
		}

		/// <summary>
		/// Crea un sy_HerramientasRecursosIdiomasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static sy_HerramientasRecursosIdiomasDataset.sy_HerramientasRecursosIdiomasRow NewRow()
		{
			return (sy_HerramientasRecursosIdiomasDataset.sy_HerramientasRecursosIdiomasRow)SetRowDefaultValues(mz.erp.dataaccess.sy_HerramientasRecursosIdiomas.NewRow());
		}

		public static DataRow SetRowDefaultValues( DataRow row )
		{
			row["IdHerramienta"]= 0; 
			row["IdRecurso"] = 0; 
			row["IdIdioma"] = 0; 
			row["FechaCreacion"] = mz.erp.businessrules.Sistema.DateTime.Now;
			row["IdConexionCreacion"] = Security.IdConexion;
			//row["UltimaModificacion"] = null;
			row["IdConexionUltimaModificacion"] = Security.IdConexion;
			row["RowId"] = Guid.Empty;

			return row;
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_HerramientasRecursosIdiomas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_HerramientasRecursosIdiomasDataset.sy_HerramientasRecursosIdiomasRow GetByPk( long IdHerramienta, long IdRecurso, long IdIdioma )
		{
			return mz.erp.dataaccess.sy_HerramientasRecursosIdiomas.GetByPk( IdHerramienta, IdRecurso, IdIdioma );
		}
		
		/// <summary>
		/// Envia los cambios del sy_HerramientasRecursosIdiomasRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( sy_HerramientasRecursosIdiomasDataset.sy_HerramientasRecursosIdiomasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del sy_HerramientasRecursosIdiomasRow a la base de datos.
		/// </summary>
		public static void Update( sy_HerramientasRecursosIdiomasDataset.sy_HerramientasRecursosIdiomasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_HerramientasRecursosIdiomas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_HerramientasRecursosIdiomasDataset a la base de datos.
		/// </summary>
		public static void Update( sy_HerramientasRecursosIdiomasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_HerramientasRecursosIdiomas.Rows.Count > 0, "La tabla dataSet.sy_HerramientasRecursosIdiomasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_HerramientasRecursosIdiomas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_HerramientasRecursosIdiomasDataset.sy_HerramientasRecursosIdiomasDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_HerramientasRecursosIdiomasDataset.sy_HerramientasRecursosIdiomasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_HerramientasRecursosIdiomas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_HerramientasRecursosIdiomasRow.
		/// </summary>
		public static bool RowIsValid( sy_HerramientasRecursosIdiomasDataset.sy_HerramientasRecursosIdiomasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdHerramientaIsValid( row.IdHerramienta ) )
			{ 
				return false;
			}
						
			if ( !IdRecursoIsValid( row.IdRecurso ) )
			{ 
				return false;
			}
						
			if ( !IdIdiomaIsValid( row.IdIdioma ) )
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
		/// Valida el campo IdHerramienta.
		/// </summary>
		public static bool IdHerramientaIsValid( long IdHerramienta )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdRecurso.
		/// </summary>
		public static bool IdRecursoIsValid( long IdRecurso )
		{
			//Agregar cdigo de validacin
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


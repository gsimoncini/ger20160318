namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_TiposRecursos : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public sy_TiposRecursos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_TiposRecursos
		/// </summary>
		public static sy_TiposRecursosDataset GetList()
		{
			return mz.erp.dataaccess.sy_TiposRecursos.GetList();
		}

		/// <summary>
		/// Crea un sy_TiposRecursosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_TiposRecursosDataset.sy_TiposRecursosRow NewRow()
		{
			return mz.erp.dataaccess.sy_TiposRecursos.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_TiposRecursos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_TiposRecursosDataset.sy_TiposRecursosRow GetByPk( long IdTipoRecurso )
		{
			return mz.erp.dataaccess.sy_TiposRecursos.GetByPk( IdTipoRecurso );
		}
		
		/// <summary>
		/// Envia los cambios del sy_TiposRecursosRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( sy_TiposRecursosDataset.sy_TiposRecursosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del sy_TiposRecursosRow a la base de datos.
		/// </summary>
		public static void Update( sy_TiposRecursosDataset.sy_TiposRecursosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_TiposRecursos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_TiposRecursosDataset a la base de datos.
		/// </summary>
		public static void Update( sy_TiposRecursosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_TiposRecursos.Rows.Count > 0, "La tabla dataSet.sy_TiposRecursosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_TiposRecursos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_TiposRecursosDataset.sy_TiposRecursosDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_TiposRecursosDataset.sy_TiposRecursosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_TiposRecursos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_TiposRecursosRow.
		/// </summary>
		public static bool RowIsValid( sy_TiposRecursosDataset.sy_TiposRecursosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdTipoRecursoIsValid( row.IdTipoRecurso ) )
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
		/// Valida el campo IdTipoRecurso.
		/// </summary>
		public static bool IdTipoRecursoIsValid( long IdTipoRecurso )
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


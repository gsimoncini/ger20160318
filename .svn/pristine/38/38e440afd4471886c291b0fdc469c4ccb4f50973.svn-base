namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_Recursos : IDisposable
	{
	
		#region Custom Members

		public static sy_RecursosDataset GetList( long IdIdioma, long IdHerramienta )
		{
			return mz.erp.dataaccess.sy_Recursos.GetList( IdIdioma, IdHerramienta );
		}
		

		#endregion
		
		public sy_Recursos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_Recursos
		/// </summary>
		public static sy_RecursosDataset GetList()
		{
			return mz.erp.dataaccess.sy_Recursos.GetList();
		}

		/// <summary>
		/// Crea un sy_RecursosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static sy_RecursosDataset.sy_RecursosRow NewRow()
		{
			return (sy_RecursosDataset.sy_RecursosRow)SetRowDefaultValues(mz.erp.dataaccess.sy_Recursos.NewRow());
		}

		public static DataRow SetRowDefaultValues( DataRow row )
		{
			row["IdRecurso"] = 0; 
			row["Descripcion"] = string.Empty;
			//row["Datos"] = null;
			row["IdTipoRecurso"] = 0;
			row["FechaCreacion"] = mz.erp.businessrules.Sistema.DateTime.Now;
			row["IdConexionCreacion"] = Security.IdConexion;
			//row["UltimaModificacion"] = null;
			row["IdConexionUltimaModificacion"] = Security.IdConexion;
			row["RowId"] = Guid.Empty;

			return row;
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_Recursos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_RecursosDataset.sy_RecursosRow GetByPk( long IdRecurso )
		{
			return mz.erp.dataaccess.sy_Recursos.GetByPk( IdRecurso );
		}
		
		/// <summary>
		/// Envia los cambios del sy_RecursosRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( sy_RecursosDataset.sy_RecursosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del sy_RecursosRow a la base de datos.
		/// </summary>
		public static void Update( sy_RecursosDataset.sy_RecursosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Recursos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_RecursosDataset a la base de datos.
		/// </summary>
		public static void Update( sy_RecursosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_Recursos.Rows.Count > 0, "La tabla dataSet.sy_RecursosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Recursos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_RecursosDataset.sy_RecursosDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_RecursosDataset.sy_RecursosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Recursos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_RecursosRow.
		/// </summary>
		public static bool RowIsValid( sy_RecursosDataset.sy_RecursosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdRecursoIsValid( row.IdRecurso ) )
			{ 
				return false;
			}
						
			if ( !DescripcionIsValid( row.Descripcion ) )
			{ 
				return false;
			}
						
			if ( !DatosIsValid( row.Datos ) )
			{ 
				return false;
			}
						
			if ( !IdTipoRecursoIsValid( row.IdTipoRecurso ) )
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
		/// Valida el campo IdRecurso.
		/// </summary>
		public static bool IdRecursoIsValid( long IdRecurso )
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
		/// Valida el campo Datos.
		/// </summary>
		public static bool DatosIsValid( byte[] Datos )
		{
			//Agregar cdigo de validacin
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


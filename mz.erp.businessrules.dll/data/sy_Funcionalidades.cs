namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_Funcionalidades : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public sy_Funcionalidades()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_Funcionalidades
		/// </summary>
		public static sy_FuncionalidadesDataset GetList()
		{
			return mz.erp.dataaccess.sy_Funcionalidades.GetList();
		}

		/// <summary>
		/// Crea un sy_FuncionalidadesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_FuncionalidadesDataset.sy_FuncionalidadesRow NewRow()
		{
			return mz.erp.dataaccess.sy_Funcionalidades.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_Funcionalidades que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_FuncionalidadesDataset.sy_FuncionalidadesRow GetByPk( long IdFuncionalidad )
		{
			return mz.erp.dataaccess.sy_Funcionalidades.GetByPk( IdFuncionalidad );
		}
		
		/// <summary>
		/// Envia los cambios del sy_FuncionalidadesRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( sy_FuncionalidadesDataset.sy_FuncionalidadesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del sy_FuncionalidadesRow a la base de datos.
		/// </summary>
		public static void Update( sy_FuncionalidadesDataset.sy_FuncionalidadesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Funcionalidades.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_FuncionalidadesDataset a la base de datos.
		/// </summary>
		public static void Update( sy_FuncionalidadesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_Funcionalidades.Rows.Count > 0, "La tabla dataSet.sy_FuncionalidadesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Funcionalidades.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_FuncionalidadesDataset.sy_FuncionalidadesDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_FuncionalidadesDataset.sy_FuncionalidadesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Funcionalidades.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_FuncionalidadesRow.
		/// </summary>
		public static bool RowIsValid( sy_FuncionalidadesDataset.sy_FuncionalidadesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdFuncionalidadIsValid( row.IdFuncionalidad ) )
			{ 
				return false;
			}
						
			if ( !DescripcionIsValid( row.Descripcion ) )
			{ 
				return false;
			}
						
			if ( !ComentarioIsValid( row.Comentario ) )
			{ 
				return false;
			}
						
			if ( !IdConexionIsValid( row.IdConexion ) )
			{ 
				return false;
			}
						
			if ( !ActivaIsValid( row.Activa ) )
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
		/// Valida el campo IdFuncionalidad.
		/// </summary>
		public static bool IdFuncionalidadIsValid( long IdFuncionalidad )
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
		/// Valida el campo Comentario.
		/// </summary>
		public static bool ComentarioIsValid( string Comentario )
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
		/// Valida el campo Activa.
		/// </summary>
		public static bool ActivaIsValid( string Activa )
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


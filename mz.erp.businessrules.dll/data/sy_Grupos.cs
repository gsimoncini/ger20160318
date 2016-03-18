namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_Grupos : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public sy_Grupos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_Grupos
		/// </summary>
		public static sy_GruposDataset GetList()
		{
			return mz.erp.dataaccess.sy_Grupos.GetList();
		}

		/// <summary>
		/// Crea un sy_GruposRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_GruposDataset.sy_GruposRow NewRow()
		{
			return mz.erp.dataaccess.sy_Grupos.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_Grupos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_GruposDataset.sy_GruposRow GetByPk( long IdGrupo )
		{
			return mz.erp.dataaccess.sy_Grupos.GetByPk( IdGrupo );
		}
		
		/// <summary>
		/// Envia los cambios del sy_GruposRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( sy_GruposDataset.sy_GruposRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del sy_GruposRow a la base de datos.
		/// </summary>
		public static void Update( sy_GruposDataset.sy_GruposRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Grupos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_GruposDataset a la base de datos.
		/// </summary>
		public static void Update( sy_GruposDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_Grupos.Rows.Count > 0, "La tabla dataSet.sy_GruposDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Grupos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_GruposDataset.sy_GruposDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_GruposDataset.sy_GruposDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Grupos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_GruposRow.
		/// </summary>
		public static bool RowIsValid( sy_GruposDataset.sy_GruposRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdGrupoIsValid( row.IdGrupo ) )
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
		/// Valida el campo IdGrupo.
		/// </summary>
		public static bool IdGrupoIsValid( long IdGrupo )
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


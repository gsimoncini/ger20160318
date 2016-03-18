namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_PerfilesFuncionalidades : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public sy_PerfilesFuncionalidades()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_PerfilesFuncionalidades
		/// </summary>
		public static sy_PerfilesFuncionalidadesDataset GetList()
		{
			return mz.erp.dataaccess.sy_PerfilesFuncionalidades.GetList();
		}

		/// <summary>
		/// Crea un sy_PerfilesFuncionalidadesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_PerfilesFuncionalidadesDataset.sy_PerfilesFuncionalidadesRow NewRow()
		{
			return mz.erp.dataaccess.sy_PerfilesFuncionalidades.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_PerfilesFuncionalidades que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_PerfilesFuncionalidadesDataset.sy_PerfilesFuncionalidadesRow GetByPk( long IdPerfil, long IdFuncionalidad )
		{
			return mz.erp.dataaccess.sy_PerfilesFuncionalidades.GetByPk( IdPerfil, IdFuncionalidad );
		}
		
		/// <summary>
		/// Envia los cambios del sy_PerfilesFuncionalidadesRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( sy_PerfilesFuncionalidadesDataset.sy_PerfilesFuncionalidadesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del sy_PerfilesFuncionalidadesRow a la base de datos.
		/// </summary>
		public static void Update( sy_PerfilesFuncionalidadesDataset.sy_PerfilesFuncionalidadesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_PerfilesFuncionalidades.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_PerfilesFuncionalidadesDataset a la base de datos.
		/// </summary>
		public static void Update( sy_PerfilesFuncionalidadesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_PerfilesFuncionalidades.Rows.Count > 0, "La tabla dataSet.sy_PerfilesFuncionalidadesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_PerfilesFuncionalidades.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_PerfilesFuncionalidadesDataset.sy_PerfilesFuncionalidadesDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_PerfilesFuncionalidadesDataset.sy_PerfilesFuncionalidadesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_PerfilesFuncionalidades.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_PerfilesFuncionalidadesRow.
		/// </summary>
		public static bool RowIsValid( sy_PerfilesFuncionalidadesDataset.sy_PerfilesFuncionalidadesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdPerfilIsValid( row.IdPerfil ) )
			{ 
				return false;
			}
						
			if ( !IdFuncionalidadIsValid( row.IdFuncionalidad ) )
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
		/// Valida el campo IdPerfil.
		/// </summary>
		public static bool IdPerfilIsValid( long IdPerfil )
		{
			//Agregar cdigo de validacin
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


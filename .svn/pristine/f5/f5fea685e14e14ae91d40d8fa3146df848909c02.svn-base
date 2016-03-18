namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_GruposVariables : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public sy_GruposVariables()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_GruposVariables
		/// </summary>
		public static sy_GruposVariablesDataset GetList()
		{
			return mz.erp.dataaccess.sy_GruposVariables.GetList();
		}

		/// <summary>
		/// Crea un sy_GruposVariablesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_GruposVariablesDataset.sy_GruposVariablesRow NewRow()
		{
			return mz.erp.dataaccess.sy_GruposVariables.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_GruposVariables que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_GruposVariablesDataset.sy_GruposVariablesRow GetByPk( long IdGrupo, long IdVariable )
		{
			return mz.erp.dataaccess.sy_GruposVariables.GetByPk( IdGrupo, IdVariable );
		}
		
		/// <summary>
		/// Envia los cambios del sy_GruposVariablesRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( sy_GruposVariablesDataset.sy_GruposVariablesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del sy_GruposVariablesRow a la base de datos.
		/// </summary>
		public static void Update( sy_GruposVariablesDataset.sy_GruposVariablesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_GruposVariables.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_GruposVariablesDataset a la base de datos.
		/// </summary>
		public static void Update( sy_GruposVariablesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_GruposVariables.Rows.Count > 0, "La tabla dataSet.sy_GruposVariablesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_GruposVariables.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_GruposVariablesDataset.sy_GruposVariablesDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_GruposVariablesDataset.sy_GruposVariablesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_GruposVariables.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_GruposVariablesRow.
		/// </summary>
		public static bool RowIsValid( sy_GruposVariablesDataset.sy_GruposVariablesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdGrupoIsValid( row.IdGrupo ) )
			{ 
				return false;
			}
						
			if ( !IdVariableIsValid( row.IdVariable ) )
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
		/// Valida el campo IdVariable.
		/// </summary>
		public static bool IdVariableIsValid( long IdVariable )
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


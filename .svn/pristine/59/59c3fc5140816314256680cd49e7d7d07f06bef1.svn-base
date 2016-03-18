namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_AuxiliarVariables : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public sy_AuxiliarVariables()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_AuxiliarVariables
		/// </summary>
		public static sy_AuxiliarVariablesDataset GetList()
		{
			return mz.erp.dataaccess.sy_AuxiliarVariables.GetList();
		}

		/// <summary>
		/// Crea un sy_AuxiliarVariablesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_AuxiliarVariablesDataset.sy_AuxiliarVariablesRow NewRow()
		{
			return mz.erp.dataaccess.sy_AuxiliarVariables.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_AuxiliarVariables que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_AuxiliarVariablesDataset.sy_AuxiliarVariablesRow GetByPk( long IdVariable )
		{
			return mz.erp.dataaccess.sy_AuxiliarVariables.GetByPk( IdVariable );
		}
		
		/// <summary>
		/// Envia los cambios del sy_AuxiliarVariablesRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( sy_AuxiliarVariablesDataset.sy_AuxiliarVariablesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del sy_AuxiliarVariablesRow a la base de datos.
		/// </summary>
		public static void Update( sy_AuxiliarVariablesDataset.sy_AuxiliarVariablesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_AuxiliarVariables.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_AuxiliarVariablesDataset a la base de datos.
		/// </summary>
		public static void Update( sy_AuxiliarVariablesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_AuxiliarVariables.Rows.Count > 0, "La tabla dataSet.sy_AuxiliarVariablesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_AuxiliarVariables.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_AuxiliarVariablesDataset.sy_AuxiliarVariablesDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_AuxiliarVariablesDataset.sy_AuxiliarVariablesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_AuxiliarVariables.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_AuxiliarVariablesRow.
		/// </summary>
		public static bool RowIsValid( sy_AuxiliarVariablesDataset.sy_AuxiliarVariablesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdVariableIsValid( row.IdVariable ) )
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
						
			if ( !ValorIsValid( row.Valor ) )
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
		/// Valida el campo IdVariable.
		/// </summary>
		public static bool IdVariableIsValid( long IdVariable )
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
		/// Valida el campo Valor.
		/// </summary>
		public static bool ValorIsValid( string Valor )
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


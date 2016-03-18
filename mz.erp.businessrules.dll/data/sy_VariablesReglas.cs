namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_VariablesReglas : IDisposable
	{
	
		#region Custom Members
		public static sy_VariablesReglasDataset GetList( string IdConfiguracion)
		{
			return GetList( string.Empty, IdConfiguracion);
		}
		
		#endregion
		
		public sy_VariablesReglas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_VariablesReglas
		/// </summary>
		public static sy_VariablesReglasDataset GetList()
		{
			return mz.erp.dataaccess.sy_VariablesReglas.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla sy_VariablesReglas filtrada por las condiciones de bsqueda
		/// </summary>
		public static sy_VariablesReglasDataset GetList( string IdVariable, string IdConfiguracion)
		{
			return mz.erp.dataaccess.sy_VariablesReglas.GetList( IdVariable, IdConfiguracion);
		}

		/// <summary>
		/// Crea un sy_VariablesReglasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static sy_VariablesReglasDataset.sy_VariablesReglasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.sy_VariablesReglas.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_VariablesReglas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_VariablesReglasDataset.sy_VariablesReglasRow GetByPk( string IdVariable )
		{
			sy_VariablesReglasDataset.sy_VariablesReglasRow row = mz.erp.dataaccess.sy_VariablesReglas.GetByPk( IdVariable  );
			foreach ( DataColumn dc in row.Table.Columns ) 
			{
				if (row[dc] == System.DBNull.Value)
				{
					row[dc] = Util.DefaultValue( dc.DataType );
				}
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_VariablesReglas que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static sy_VariablesReglasDataset.sy_VariablesReglasRow GetByPk( object IdVariable )
		{
			return GetByPk( ( string )IdVariable );
		}

		/// <summary>
		/// Establece los valores por defecto de sy_VariablesReglasRow.
		/// </summary>
		public static sy_VariablesReglasDataset.sy_VariablesReglasRow SetRowDefaultValues( sy_VariablesReglasDataset.sy_VariablesReglasRow row )
		{
			row.IdVariable = Util.NewStringId(); 
			row.IdConfiguracion = string.Empty;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del sy_VariablesReglasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( sy_VariablesReglasDataset.sy_VariablesReglasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del sy_VariablesReglasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( sy_VariablesReglasDataset.sy_VariablesReglasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del sy_VariablesReglasRow a la base de datos.
		/// </summary>
		public static void Update( sy_VariablesReglasDataset.sy_VariablesReglasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_VariablesReglas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_VariablesReglasDataset a la base de datos.
		/// </summary>
		public static void Update( sy_VariablesReglasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_VariablesReglas.Rows.Count > 0, "La tabla dataSet.sy_VariablesReglasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_VariablesReglas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_VariablesReglasDataset.sy_VariablesReglasDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_VariablesReglasDataset.sy_VariablesReglasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_VariablesReglas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_VariablesReglasRow.
		/// </summary>
		public static bool RowIsValid( sy_VariablesReglasDataset.sy_VariablesReglasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdVariableIsValid( row.IdVariable, out mensaje) )
			{ 
				row.SetColumnError( "IdVariable" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConfiguracionIsValid( row.IdConfiguracion, out mensaje) )
			{ 
				row.SetColumnError( "IdConfiguracion" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaCreacionIsValid( row.FechaCreacion, out mensaje) )
			{ 
				row.SetColumnError( "FechaCreacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConexionCreacionIsValid( row.IdConexionCreacion, out mensaje) )
			{ 
				row.SetColumnError( "IdConexionCreacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !UltimaModificacionIsValid( row.UltimaModificacion, out mensaje) )
			{ 
				row.SetColumnError( "UltimaModificacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConexionUltimaModificacionIsValid( row.IdConexionUltimaModificacion, out mensaje) )
			{ 
				row.SetColumnError( "IdConexionUltimaModificacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !RowIdIsValid( row.RowId, out mensaje) )
			{ 
				row.SetColumnError( "RowId" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdVariable.
		/// </summary>
		public static bool IdVariableIsValid( string IdVariable , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdVariable. Metodo Sobrecargado
		/// </summary>
		public static bool IdVariableIsValid( string IdVariable)
		{
			string mensaje;
			return IdVariableIsValid( IdVariable, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdConfiguracion.
		/// </summary>
		public static bool IdConfiguracionIsValid( string IdConfiguracion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConfiguracion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConfiguracionIsValid( string IdConfiguracion)
		{
			string mensaje;
			return IdConfiguracionIsValid( IdConfiguracion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaCreacion.
		/// </summary>
		public static bool FechaCreacionIsValid( DateTime FechaCreacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaCreacion. Metodo Sobrecargado
		/// </summary>
		public static bool FechaCreacionIsValid( DateTime FechaCreacion)
		{
			string mensaje;
			return FechaCreacionIsValid( FechaCreacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdConexionCreacion.
		/// </summary>
		public static bool IdConexionCreacionIsValid( long IdConexionCreacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexionCreacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConexionCreacionIsValid( long IdConexionCreacion)
		{
			string mensaje;
			return IdConexionCreacionIsValid( IdConexionCreacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo UltimaModificacion.
		/// </summary>
		public static bool UltimaModificacionIsValid( byte[] UltimaModificacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo UltimaModificacion. Metodo Sobrecargado
		/// </summary>
		public static bool UltimaModificacionIsValid( byte[] UltimaModificacion)
		{
			string mensaje;
			return UltimaModificacionIsValid( UltimaModificacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdConexionUltimaModificacion.
		/// </summary>
		public static bool IdConexionUltimaModificacionIsValid( long IdConexionUltimaModificacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexionUltimaModificacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConexionUltimaModificacionIsValid( long IdConexionUltimaModificacion)
		{
			string mensaje;
			return IdConexionUltimaModificacionIsValid( IdConexionUltimaModificacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo RowId.
		/// </summary>
		public static bool RowIdIsValid( Guid RowId , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo RowId. Metodo Sobrecargado
		/// </summary>
		public static bool RowIdIsValid( Guid RowId)
		{
			string mensaje;
			return RowIdIsValid( RowId, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}


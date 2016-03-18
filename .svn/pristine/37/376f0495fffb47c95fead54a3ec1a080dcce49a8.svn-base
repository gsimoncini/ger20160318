namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class twf_Verificaciones : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public twf_Verificaciones()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla twf_Verificaciones
		/// </summary>
		public static twf_VerificacionesDataset GetList()
		{
			return mz.erp.dataaccess.twf_Verificaciones.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla twf_Verificaciones filtrada por las condiciones de bsqueda
		/// </summary>
		public static twf_VerificacionesDataset GetList( long IdValidacion, long IdDependencia, long IdConexion, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId, string Observaciones )
		{
			return mz.erp.dataaccess.twf_Verificaciones.GetList( IdValidacion, IdDependencia, IdConexion, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, RowId, Observaciones );
		}

		/// <summary>
		/// Crea un twf_VerificacionesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static twf_VerificacionesDataset.twf_VerificacionesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.twf_Verificaciones.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla twf_Verificaciones que luego puede ser persistido en la base de datos.
		/// </summary>
		public static twf_VerificacionesDataset.twf_VerificacionesRow GetByPk( long IdValidacion, long IdDependencia )
		{
			twf_VerificacionesDataset.twf_VerificacionesRow row = mz.erp.dataaccess.twf_Verificaciones.GetByPk( IdValidacion, IdDependencia  );
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
		/// Obtiene un registro de la tabla twf_Verificaciones que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static twf_VerificacionesDataset.twf_VerificacionesRow GetByPk( object IdValidacion, object IdDependencia )
		{
			return GetByPk( ( long )IdValidacion, ( long )IdDependencia );
		}

		/// <summary>
		/// Establece los valores por defecto de twf_VerificacionesRow.
		/// </summary>
		public static twf_VerificacionesDataset.twf_VerificacionesRow SetRowDefaultValues( twf_VerificacionesDataset.twf_VerificacionesRow row )
		{
			row.IdValidacion = 0; 
			row.IdDependencia = 0; 
			row.IdConexion = 0;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;
			row.Observaciones = string.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del twf_VerificacionesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( twf_VerificacionesDataset.twf_VerificacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del twf_VerificacionesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( twf_VerificacionesDataset.twf_VerificacionesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del twf_VerificacionesRow a la base de datos.
		/// </summary>
		public static void Update( twf_VerificacionesDataset.twf_VerificacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.twf_Verificaciones.Update( row );
		}

		/// <summary>
		/// Envia los cambios del twf_VerificacionesDataset a la base de datos.
		/// </summary>
		public static void Update( twf_VerificacionesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.twf_Verificaciones.Rows.Count > 0, "La tabla dataSet.twf_VerificacionesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.twf_Verificaciones.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del twf_VerificacionesDataset.twf_VerificacionesDataTable a la base de datos.
		/// </summary>
		public static void Update( twf_VerificacionesDataset.twf_VerificacionesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.twf_Verificaciones.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un twf_VerificacionesRow.
		/// </summary>
		public static bool RowIsValid( twf_VerificacionesDataset.twf_VerificacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdValidacionIsValid( row.IdValidacion, out mensaje) )
			{ 
				row.SetColumnError( "IdValidacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdDependenciaIsValid( row.IdDependencia, out mensaje) )
			{ 
				row.SetColumnError( "IdDependencia" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConexionIsValid( row.IdConexion, out mensaje) )
			{ 
				row.SetColumnError( "IdConexion" , mensaje);
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
						
			if ( !ObservacionesIsValid( row.Observaciones, out mensaje) )
			{ 
				row.SetColumnError( "Observaciones" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdValidacion.
		/// </summary>
		public static bool IdValidacionIsValid( long IdValidacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdValidacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdValidacionIsValid( long IdValidacion)
		{
			string mensaje;
			return IdValidacionIsValid( IdValidacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdDependencia.
		/// </summary>
		public static bool IdDependenciaIsValid( long IdDependencia , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdDependencia. Metodo Sobrecargado
		/// </summary>
		public static bool IdDependenciaIsValid( long IdDependencia)
		{
			string mensaje;
			return IdDependenciaIsValid( IdDependencia, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdConexion.
		/// </summary>
		public static bool IdConexionIsValid( long IdConexion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConexionIsValid( long IdConexion)
		{
			string mensaje;
			return IdConexionIsValid( IdConexion, out mensaje );
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
		
		/// <summary>
		/// Valida el campo Observaciones.
		/// </summary>
		public static bool ObservacionesIsValid( string Observaciones , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Observaciones. Metodo Sobrecargado
		/// </summary>
		public static bool ObservacionesIsValid( string Observaciones)
		{
			string mensaje;
			return ObservacionesIsValid( Observaciones, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}


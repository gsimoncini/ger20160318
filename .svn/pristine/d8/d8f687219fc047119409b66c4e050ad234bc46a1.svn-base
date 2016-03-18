namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class twf_Validaciones : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public twf_Validaciones()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla twf_Validaciones
		/// </summary>
		public static twf_ValidacionesDataset GetList()
		{
			return mz.erp.dataaccess.twf_Validaciones.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla twf_Validaciones filtrada por las condiciones de bsqueda
		/// </summary>
		public static twf_ValidacionesDataset GetList( long IdValidacion, string Descripcion, string Formula, long IdConexion, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId, string Observaciones )
		{
			return mz.erp.dataaccess.twf_Validaciones.GetList( IdValidacion, Descripcion, Formula, IdConexion, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, RowId, Observaciones );
		}

		/// <summary>
		/// Crea un twf_ValidacionesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static twf_ValidacionesDataset.twf_ValidacionesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.twf_Validaciones.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla twf_Validaciones que luego puede ser persistido en la base de datos.
		/// </summary>
		public static twf_ValidacionesDataset.twf_ValidacionesRow GetByPk( long IdValidacion )
		{
			twf_ValidacionesDataset.twf_ValidacionesRow row = mz.erp.dataaccess.twf_Validaciones.GetByPk( IdValidacion  );
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
		/// Obtiene un registro de la tabla twf_Validaciones que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static twf_ValidacionesDataset.twf_ValidacionesRow GetByPk( object IdValidacion )
		{
			return GetByPk( ( long )IdValidacion );
		}

		/// <summary>
		/// Establece los valores por defecto de twf_ValidacionesRow.
		/// </summary>
		public static twf_ValidacionesDataset.twf_ValidacionesRow SetRowDefaultValues( twf_ValidacionesDataset.twf_ValidacionesRow row )
		{
			row.IdValidacion = 0; 
			row.Descripcion = string.Empty;
			row.Formula = string.Empty;
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
		/// Envia los cambios del twf_ValidacionesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( twf_ValidacionesDataset.twf_ValidacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del twf_ValidacionesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( twf_ValidacionesDataset.twf_ValidacionesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del twf_ValidacionesRow a la base de datos.
		/// </summary>
		public static void Update( twf_ValidacionesDataset.twf_ValidacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.twf_Validaciones.Update( row );
		}

		/// <summary>
		/// Envia los cambios del twf_ValidacionesDataset a la base de datos.
		/// </summary>
		public static void Update( twf_ValidacionesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.twf_Validaciones.Rows.Count > 0, "La tabla dataSet.twf_ValidacionesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.twf_Validaciones.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del twf_ValidacionesDataset.twf_ValidacionesDataTable a la base de datos.
		/// </summary>
		public static void Update( twf_ValidacionesDataset.twf_ValidacionesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.twf_Validaciones.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un twf_ValidacionesRow.
		/// </summary>
		public static bool RowIsValid( twf_ValidacionesDataset.twf_ValidacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdValidacionIsValid( row.IdValidacion, out mensaje) )
			{ 
				row.SetColumnError( "IdValidacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}
						
			if ( !FormulaIsValid( row.Formula, out mensaje) )
			{ 
				row.SetColumnError( "Formula" , mensaje);
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
		/// Valida el campo Descripcion.
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Descripcion. Metodo Sobrecargado
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion)
		{
			string mensaje;
			return DescripcionIsValid( Descripcion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Formula.
		/// </summary>
		public static bool FormulaIsValid( string Formula , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Formula. Metodo Sobrecargado
		/// </summary>
		public static bool FormulaIsValid( string Formula)
		{
			string mensaje;
			return FormulaIsValid( Formula, out mensaje );
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


namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsy_TiposDeRetenciones : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsy_TiposDeRetenciones()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsy_TiposDeRetenciones
		/// </summary>
		public static tsy_TiposDeRetencionesDataset GetList()
		{
			return mz.erp.dataaccess.tsy_TiposDeRetenciones.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsy_TiposDeRetenciones filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsy_TiposDeRetencionesDataset GetList( string IdTipoDeRetencion, string Descripcion, bool Sistema, bool Activo, string Formula )
		{
			return mz.erp.dataaccess.tsy_TiposDeRetenciones.GetList( IdTipoDeRetencion, Descripcion, Sistema, Activo, Formula );
		}

		/// <summary>
		/// Crea un tsy_TiposDeRetencionesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsy_TiposDeRetencionesDataset.tsy_TiposDeRetencionesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsy_TiposDeRetenciones.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsy_TiposDeRetenciones que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsy_TiposDeRetencionesDataset.tsy_TiposDeRetencionesRow GetByPk( string IdTipoDeRetencion )
		{
		   tsy_TiposDeRetencionesDataset.tsy_TiposDeRetencionesRow row = mz.erp.dataaccess.tsy_TiposDeRetenciones.GetByPk( IdTipoDeRetencion  );
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
		/// Obtiene un registro de la tabla tsy_TiposDeRetenciones que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsy_TiposDeRetencionesDataset.tsy_TiposDeRetencionesRow GetByPk( object IdTipoDeRetencion )
		{
			return GetByPk( ( string )IdTipoDeRetencion );
		}

		/// <summary>
		/// Establece los valores por defecto de tsy_TiposDeRetencionesRow.
		/// </summary>
		public static tsy_TiposDeRetencionesDataset.tsy_TiposDeRetencionesRow SetRowDefaultValues( tsy_TiposDeRetencionesDataset.tsy_TiposDeRetencionesRow row )
		{
			row.IdTipoDeRetencion = Util.NewStringId(); 
			row.Descripcion = string.Empty;
			row.Sistema = false;
			row.Activo = false;
			row.Formula = string.Empty;
			row.Auxiliar1 = string.Empty;
			row.Auxiliar2 = string.Empty;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsy_TiposDeRetencionesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsy_TiposDeRetencionesDataset.tsy_TiposDeRetencionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsy_TiposDeRetencionesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsy_TiposDeRetencionesDataset.tsy_TiposDeRetencionesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_TiposDeRetencionesRow a la base de datos.
		/// </summary>
		public static void Update( tsy_TiposDeRetencionesDataset.tsy_TiposDeRetencionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_TiposDeRetenciones.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsy_TiposDeRetencionesDataset a la base de datos.
		/// </summary>
		public static void Update( tsy_TiposDeRetencionesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsy_TiposDeRetenciones.Rows.Count > 0, "La tabla dataSet.tsy_TiposDeRetencionesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_TiposDeRetenciones.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_TiposDeRetencionesDataset.tsy_TiposDeRetencionesDataTable a la base de datos.
		/// </summary>
		public static void Update( tsy_TiposDeRetencionesDataset.tsy_TiposDeRetencionesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_TiposDeRetenciones.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsy_TiposDeRetencionesRow.
		/// </summary>
		public static bool RowIsValid( tsy_TiposDeRetencionesDataset.tsy_TiposDeRetencionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdTipoDeRetencionIsValid( row.IdTipoDeRetencion, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoDeRetencion" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}
						
			if ( !SistemaIsValid( row.Sistema, out mensaje) )
			{ 
				row.SetColumnError( "Sistema" , mensaje);
				isValid=false;
			
			}
						
			if ( !ActivoIsValid( row.Activo, out mensaje) )
			{ 
				row.SetColumnError( "Activo" , mensaje);
				isValid=false;
			
			}
						
			if ( !FormulaIsValid( row.Formula, out mensaje) )
			{ 
				row.SetColumnError( "Formula" , mensaje);
				isValid=false;
			
			}
						
			if ( !Auxiliar1IsValid( row.Auxiliar1, out mensaje) )
			{ 
				row.SetColumnError( "Auxiliar1" , mensaje);
				isValid=false;
			
			}
						
			if ( !Auxiliar2IsValid( row.Auxiliar2, out mensaje) )
			{ 
				row.SetColumnError( "Auxiliar2" , mensaje);
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
		/// Valida el campo IdTipoDeRetencion.
		/// </summary>
		public static bool IdTipoDeRetencionIsValid( string IdTipoDeRetencion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoDeRetencion. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoDeRetencionIsValid( string IdTipoDeRetencion)
		{
			string mensaje;
			return IdTipoDeRetencionIsValid( IdTipoDeRetencion, out mensaje );
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
		/// Valida el campo Sistema.
		/// </summary>
		public static bool SistemaIsValid( bool Sistema , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Sistema. Metodo Sobrecargado
		/// </summary>
		public static bool SistemaIsValid( bool Sistema)
		{
			string mensaje;
			return SistemaIsValid( Sistema, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Activo.
		/// </summary>
		public static bool ActivoIsValid( bool Activo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Activo. Metodo Sobrecargado
		/// </summary>
		public static bool ActivoIsValid( bool Activo)
		{
			string mensaje;
			return ActivoIsValid( Activo, out mensaje );
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
		/// Valida el campo Auxiliar1.
		/// </summary>
		public static bool Auxiliar1IsValid( string Auxiliar1 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Auxiliar1. Metodo Sobrecargado
		/// </summary>
		public static bool Auxiliar1IsValid( string Auxiliar1)
		{
			string mensaje;
			return Auxiliar1IsValid( Auxiliar1, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Auxiliar2.
		/// </summary>
		public static bool Auxiliar2IsValid( string Auxiliar2 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Auxiliar2. Metodo Sobrecargado
		/// </summary>
		public static bool Auxiliar2IsValid( string Auxiliar2)
		{
			string mensaje;
			return Auxiliar2IsValid( Auxiliar2, out mensaje );
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


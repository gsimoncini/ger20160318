namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class st_ListaDePreciosTarea : IDisposable
	{
	
		#region Custom Members
		
		public static st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaRow GetByIdTarea( long IdTarea )
		{
			return mz.erp.dataaccess.st_ListaDePreciosTarea.GetByIdTarea( IdTarea  );
		}

		#endregion
		
		public st_ListaDePreciosTarea()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla st_ListaDePreciosTarea
		/// </summary>
		public static st_ListaDePreciosTareaDataset GetList()
		{
			return mz.erp.dataaccess.st_ListaDePreciosTarea.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla st_ListaDePreciosTarea filtrada por las condiciones de bsqueda
		/// </summary>
		public static st_ListaDePreciosTareaDataset GetList( long IdListaDePreciosTarea, long IdTarea, DateTime FechaInicio, DateTime FechaFin, decimal Precio, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId )
		{
			return mz.erp.dataaccess.st_ListaDePreciosTarea.GetList( IdListaDePreciosTarea, IdTarea, FechaInicio, FechaFin, Precio, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, RowId );
		}

		/// <summary>
		/// Crea un st_ListaDePreciosTareaRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.st_ListaDePreciosTarea.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla st_ListaDePreciosTarea que luego puede ser persistido en la base de datos.
		/// </summary>
		public static st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaRow GetByPk( long IdListaDePreciosTarea )
		{
			st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaRow row = mz.erp.dataaccess.st_ListaDePreciosTarea.GetByPk( IdListaDePreciosTarea  );
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
		/// Obtiene un registro de la tabla st_ListaDePreciosTarea que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaRow GetByPk( object IdListaDePreciosTarea )
		{
			return GetByPk( ( long )IdListaDePreciosTarea );
		}

		/// <summary>
		/// Establece los valores por defecto de st_ListaDePreciosTareaRow.
		/// </summary>
		public static st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaRow SetRowDefaultValues( st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaRow row )
		{
			row.IdListaDePreciosTarea = 0; 
			row.IdTarea = 0;
			row.FechaInicio = DateTime.Now;
			row.FechaFin = DateTime.Now;
			row.Precio = 0;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del st_ListaDePreciosTareaRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del st_ListaDePreciosTareaRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del st_ListaDePreciosTareaRow a la base de datos.
		/// </summary>
		public static void Update( st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_ListaDePreciosTarea.Update( row );
		}

		/// <summary>
		/// Envia los cambios del st_ListaDePreciosTareaDataset a la base de datos.
		/// </summary>
		public static void Update( st_ListaDePreciosTareaDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.st_ListaDePreciosTarea.Rows.Count > 0, "La tabla dataSet.st_ListaDePreciosTareaDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_ListaDePreciosTarea.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaDataTable a la base de datos.
		/// </summary>
		public static void Update( st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_ListaDePreciosTarea.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un st_ListaDePreciosTareaRow.
		/// </summary>
		public static bool RowIsValid( st_ListaDePreciosTareaDataset.st_ListaDePreciosTareaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdListaDePreciosTareaIsValid( row.IdListaDePreciosTarea, out mensaje) )
			{ 
				row.SetColumnError( "IdListaDePreciosTarea" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTareaIsValid( row.IdTarea, out mensaje) )
			{ 
				row.SetColumnError( "IdTarea" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaInicioIsValid( row.FechaInicio, out mensaje) )
			{ 
				row.SetColumnError( "FechaInicio" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaFinIsValid( row.FechaFin, out mensaje) )
			{ 
				row.SetColumnError( "FechaFin" , mensaje);
				isValid=false;
			
			}
						
			if ( !PrecioIsValid( row.Precio, out mensaje) )
			{ 
				row.SetColumnError( "Precio" , mensaje);
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
		/// Valida el campo IdListaDePreciosTarea.
		/// </summary>
		public static bool IdListaDePreciosTareaIsValid( long IdListaDePreciosTarea , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdListaDePreciosTarea. Metodo Sobrecargado
		/// </summary>
		public static bool IdListaDePreciosTareaIsValid( long IdListaDePreciosTarea)
		{
			string mensaje;
			return IdListaDePreciosTareaIsValid( IdListaDePreciosTarea, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTarea.
		/// </summary>
		public static bool IdTareaIsValid( long IdTarea , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTarea. Metodo Sobrecargado
		/// </summary>
		public static bool IdTareaIsValid( long IdTarea)
		{
			string mensaje;
			return IdTareaIsValid( IdTarea, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaInicio.
		/// </summary>
		public static bool FechaInicioIsValid( DateTime FechaInicio , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaInicio. Metodo Sobrecargado
		/// </summary>
		public static bool FechaInicioIsValid( DateTime FechaInicio)
		{
			string mensaje;
			return FechaInicioIsValid( FechaInicio, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaFin.
		/// </summary>
		public static bool FechaFinIsValid( DateTime FechaFin , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaFin. Metodo Sobrecargado
		/// </summary>
		public static bool FechaFinIsValid( DateTime FechaFin)
		{
			string mensaje;
			return FechaFinIsValid( FechaFin, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Precio.
		/// </summary>
		public static bool PrecioIsValid( decimal Precio , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Precio. Metodo Sobrecargado
		/// </summary>
		public static bool PrecioIsValid( decimal Precio)
		{
			string mensaje;
			return PrecioIsValid( Precio, out mensaje );
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


namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class st_ServicioTareas : IDisposable
	{
	
		#region Custom Members
		public static st_ServicioTareasDataset GetList( long IdServicio)
		{
			return GetList( IdServicio, long.MinValue );
		}
	
		#endregion
		
		public st_ServicioTareas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla st_ServicioTareas
		/// </summary>
		public static st_ServicioTareasDataset GetList()
		{
			return mz.erp.dataaccess.st_ServicioTareas.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla st_ServicioTareas filtrada por las condiciones de bsqueda
		/// </summary>
		public static st_ServicioTareasDataset GetList( long IdServicio, long IdTarea )
		{
			return mz.erp.dataaccess.st_ServicioTareas.GetList( IdServicio, IdTarea );
		}

		/// <summary>
		/// Crea un st_ServicioTareasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static st_ServicioTareasDataset.st_ServicioTareasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.st_ServicioTareas.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla st_ServicioTareas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static st_ServicioTareasDataset.st_ServicioTareasRow GetByPk( long IdServicio, long IdTarea )
		{
			st_ServicioTareasDataset.st_ServicioTareasRow row = mz.erp.dataaccess.st_ServicioTareas.GetByPk( IdServicio, IdTarea  );
			if(row != null)
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if(!dc.Caption.ToUpper().Equals("ROWID"))
					{
						if (row[dc] == System.DBNull.Value)
						{
							row[dc] = Util.DefaultValue( dc.DataType );
						}
					}
				}
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla st_ServicioTareas que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static st_ServicioTareasDataset.st_ServicioTareasRow GetByPk( object IdServicio, object IdTarea )
		{
			return GetByPk( ( long )IdServicio, ( long )IdTarea );
		}

		/// <summary>
		/// Establece los valores por defecto de st_ServicioTareasRow.
		/// </summary>
		public static st_ServicioTareasDataset.st_ServicioTareasRow SetRowDefaultValues( st_ServicioTareasDataset.st_ServicioTareasRow row )
		{
			row.IdServicio = 0; 
			row.IdTarea = 0; 
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del st_ServicioTareasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( st_ServicioTareasDataset.st_ServicioTareasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del st_ServicioTareasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( st_ServicioTareasDataset.st_ServicioTareasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del st_ServicioTareasRow a la base de datos.
		/// </summary>
		public static void Update( st_ServicioTareasDataset.st_ServicioTareasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_ServicioTareas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del st_ServicioTareasDataset a la base de datos.
		/// </summary>
		public static void Update( st_ServicioTareasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.st_ServicioTareas.Rows.Count > 0, "La tabla dataSet.st_ServicioTareasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_ServicioTareas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del st_ServicioTareasDataset.st_ServicioTareasDataTable a la base de datos.
		/// </summary>
		public static void Update( st_ServicioTareasDataset.st_ServicioTareasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_ServicioTareas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un st_ServicioTareasRow.
		/// </summary>
		public static bool RowIsValid( st_ServicioTareasDataset.st_ServicioTareasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdServicioIsValid( row.IdServicio, out mensaje) )
			{ 
				row.SetColumnError( "IdServicio" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTareaIsValid( row.IdTarea, out mensaje) )
			{ 
				row.SetColumnError( "IdTarea" , mensaje);
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
		/// Valida el campo IdServicio.
		/// </summary>
		public static bool IdServicioIsValid( long IdServicio , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdServicio. Metodo Sobrecargado
		/// </summary>
		public static bool IdServicioIsValid( long IdServicio)
		{
			string mensaje;
			return IdServicioIsValid( IdServicio, out mensaje );
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


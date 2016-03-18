namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class st_Tarea : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public st_Tarea()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla st_Tarea
		/// </summary>
		public static st_TareaDataset GetList()
		{
			return mz.erp.dataaccess.st_Tarea.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla st_Tarea filtrada por las condiciones de bsqueda
		/// </summary>
		public static st_TareaDataset GetList( long IdTarea, string Codigo, string Descripcion, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId, string IdProducto, string Complejidad, decimal Duracion, decimal ValorTecnico, decimal ValorTecnicoProvisorio )
		{
			return mz.erp.dataaccess.st_Tarea.GetList( IdTarea, Codigo, Descripcion, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, RowId, IdProducto, Complejidad, Duracion, ValorTecnico, ValorTecnicoProvisorio );
		}

		/// <summary>
		/// Crea un st_TareaRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static st_TareaDataset.st_TareaRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.st_Tarea.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla st_Tarea que luego puede ser persistido en la base de datos.
		/// </summary>
		public static st_TareaDataset.st_TareaRow GetByPk( long IdTarea )
		{
			st_TareaDataset.st_TareaRow row = mz.erp.dataaccess.st_Tarea.GetByPk( IdTarea  );
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
		/// Obtiene un registro de la tabla st_Tarea que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static st_TareaDataset.st_TareaRow GetByPk( object IdTarea )
		{
			return GetByPk( ( long )IdTarea );
		}

		/// <summary>
		/// Establece los valores por defecto de st_TareaRow.
		/// </summary>
		public static st_TareaDataset.st_TareaRow SetRowDefaultValues( st_TareaDataset.st_TareaRow row )
		{
			row.IdTarea = 0; 
			row.Codigo = string.Empty;
			row.Descripcion = string.Empty;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;
			row.IdProducto = string.Empty;
			row.Complejidad = string.Empty;
			row.Duracion = 0;
			row.ValorTecnico = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del st_TareaRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( st_TareaDataset.st_TareaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del st_TareaRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( st_TareaDataset.st_TareaRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del st_TareaRow a la base de datos.
		/// </summary>
		public static void Update( st_TareaDataset.st_TareaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_Tarea.Update( row );
		}

		/// <summary>
		/// Envia los cambios del st_TareaDataset a la base de datos.
		/// </summary>
		public static void Update( st_TareaDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.st_Tarea.Rows.Count > 0, "La tabla dataSet.st_TareaDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_Tarea.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del st_TareaDataset.st_TareaDataTable a la base de datos.
		/// </summary>
		public static void Update( st_TareaDataset.st_TareaDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_Tarea.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un st_TareaRow.
		/// </summary>
		public static bool RowIsValid( st_TareaDataset.st_TareaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdTareaIsValid( row.IdTarea, out mensaje) )
			{ 
				row.SetColumnError( "IdTarea" , mensaje);
				isValid=false;
			
			}
						
			if ( !CodigoIsValid( row.Codigo, out mensaje) )
			{ 
				row.SetColumnError( "Codigo" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
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
						
			if ( !IdProductoIsValid( row.IdProducto, out mensaje) )
			{ 
				row.SetColumnError( "IdProducto" , mensaje);
				isValid=false;
			
			}
						
			if ( !ComplejidadIsValid( row.Complejidad, out mensaje) )
			{ 
				row.SetColumnError( "Complejidad" , mensaje);
				isValid=false;
			
			}
						
			if ( !DuracionIsValid( row.Duracion, out mensaje) )
			{ 
				row.SetColumnError( "Duracion" , mensaje);
				isValid=false;
			
			}
						
			if ( !ValorTecnicoIsValid( row.ValorTecnico, out mensaje) )
			{ 
				row.SetColumnError( "ValorTecnico" , mensaje);
				isValid=false;
			
			}
						
			return isValid;
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
		/// Valida el campo Codigo.
		/// </summary>
		public static bool CodigoIsValid( string Codigo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Codigo. Metodo Sobrecargado
		/// </summary>
		public static bool CodigoIsValid( string Codigo)
		{
			string mensaje;
			return CodigoIsValid( Codigo, out mensaje );
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
		/// Valida el campo IdProducto.
		/// </summary>
		public static bool IdProductoIsValid( string IdProducto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProducto. Metodo Sobrecargado
		/// </summary>
		public static bool IdProductoIsValid( string IdProducto)
		{
			string mensaje;
			return IdProductoIsValid( IdProducto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Complejidad.
		/// </summary>
		public static bool ComplejidadIsValid( string Complejidad , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Complejidad. Metodo Sobrecargado
		/// </summary>
		public static bool ComplejidadIsValid( string Complejidad)
		{
			string mensaje;
			return ComplejidadIsValid( Complejidad, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Duracion.
		/// </summary>
		public static bool DuracionIsValid( decimal Duracion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Duracion. Metodo Sobrecargado
		/// </summary>
		public static bool DuracionIsValid( decimal Duracion)
		{
			string mensaje;
			return DuracionIsValid( Duracion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo ValorTecnico.
		/// </summary>
		public static bool ValorTecnicoIsValid( decimal ValorTecnico , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ValorTecnico. Metodo Sobrecargado
		/// </summary>
		public static bool ValorTecnicoIsValid( decimal ValorTecnico)
		{
			string mensaje;
			return ValorTecnicoIsValid( ValorTecnico, out mensaje );
		}		
		
		public void Dispose()
		{
		}
		
	}
}


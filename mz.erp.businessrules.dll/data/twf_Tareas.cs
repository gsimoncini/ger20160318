namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class twf_Tareas : IDisposable
	{
	
		#region Custom Members
		public static long GetIdTaskByName( string _nameTask )
		{
			twf_TareasDataset _data = GetList( long.MinValue, _nameTask,long.MinValue,DateTime.MinValue,long.MinValue,new byte[]{},long.MinValue,Guid.NewGuid(),null );
			long idTask = long.MinValue;
			if (_data.twf_Tareas.Rows.Count > 0)
			{
				idTask = ((twf_TareasDataset.twf_TareasRow)_data.twf_Tareas.Rows[0]).IdTarea;
			}
			return idTask;
		}
		#endregion
		
		public twf_Tareas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla twf_Tareas
		/// </summary>
		public static twf_TareasDataset GetList()
		{
			return mz.erp.dataaccess.twf_Tareas.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla twf_Tareas filtrada por las condiciones de bsqueda
		/// </summary>
		public static twf_TareasDataset GetList( long IdTarea, string Descripcion, long IdConexion, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId, string Observaciones)
		{
			return mz.erp.dataaccess.twf_Tareas.GetList( IdTarea, Descripcion, IdConexion, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, RowId, Observaciones);
		}

		/// <summary>
		/// Crea un twf_TareasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static twf_TareasDataset.twf_TareasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.twf_Tareas.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla twf_Tareas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static twf_TareasDataset.twf_TareasRow GetByPk( long IdTarea )
		{
			twf_TareasDataset.twf_TareasRow row = mz.erp.dataaccess.twf_Tareas.GetByPk( IdTarea  );
			if (row != null)
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					object value =Util.DefaultValue( dc.DataType );
					if ((value != null) && (row[dc] == null))
					{
						row[dc] = value;
					}

					
				}
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla twf_Tareas que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static twf_TareasDataset.twf_TareasRow GetByPk( object IdTarea )
		{
			return GetByPk( ( long )IdTarea );
		}

		/// <summary>
		/// Establece los valores por defecto de twf_TareasRow.
		/// </summary>
		public static twf_TareasDataset.twf_TareasRow SetRowDefaultValues( twf_TareasDataset.twf_TareasRow row )
		{
			row.IdTarea = 0; 
			row.Descripcion = string.Empty;
			row.IdConexion = 0;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;
			row.Observaciones = string.Empty;
			row.DescripcionParaUsuario = string.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del twf_TareasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( twf_TareasDataset.twf_TareasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del twf_TareasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( twf_TareasDataset.twf_TareasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del twf_TareasRow a la base de datos.
		/// </summary>
		public static void Update( twf_TareasDataset.twf_TareasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.twf_Tareas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del twf_TareasDataset a la base de datos.
		/// </summary>
		public static void Update( twf_TareasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.twf_Tareas.Rows.Count > 0, "La tabla dataSet.twf_TareasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.twf_Tareas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del twf_TareasDataset.twf_TareasDataTable a la base de datos.
		/// </summary>
		public static void Update( twf_TareasDataset.twf_TareasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.twf_Tareas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un twf_TareasRow.
		/// </summary>
		public static bool RowIsValid( twf_TareasDataset.twf_TareasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdTareaIsValid( row.IdTarea, out mensaje) )
			{ 
				row.SetColumnError( "IdTarea" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}
			if ( !DescripcionParaUsuarioIsValid( row.DescripcionParaUsuario, out mensaje) )
			{ 
				row.SetColumnError( "DescripcionParaUsuario" , mensaje);
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
		/// Valida el campo Descripcion.
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		/// <summary>
		/// Valida el campo DescripcionParaUsuario.
		/// </summary>
		public static bool DescripcionParaUsuarioIsValid( string DescripcionParaUsuario , out string mensaje )
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
		/// Valida el campo DescripcionParaUsuario. Metodo Sobrecargado
		/// </summary>
		public static bool DescripcionParaUsuarioIsValid( string DescripcionParaUsuario)
		{
			string mensaje;
			return DescripcionIsValid( DescripcionParaUsuario, out mensaje );
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


namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class twf_ProcesosTareas : IDisposable
	{
	
		#region Custom Members		
		
		public static System.Data.DataTable GetList(string IdProceso)
		{
			long IdTarea = Int64.MinValue;
			int Orden = Int32.MinValue;				
			long IdProceso2 = Convert.ToInt64(IdProceso);
			return mz.erp.dataaccess.twf_ProcesosTareas.GetList(IdProceso2, IdTarea, Orden, null).Tables[0];
		}
		
		#endregion
		
		public twf_ProcesosTareas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla twf_ProcesosTareas
		/// </summary>
		public static twf_ProcesosTareasDataset GetList()
		{
			return mz.erp.dataaccess.twf_ProcesosTareas.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla twf_ProcesosTareas filtrada por las condiciones de bsqueda
		/// </summary>
		public static twf_ProcesosTareasDataset GetList( long IdProceso, long IdTarea, int Orden, string Descripcion, long IdConexion, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId, string Observaciones, int OrdenBR, int OrdenDA, int OrdenUI )
		{
			return mz.erp.dataaccess.twf_ProcesosTareas.GetList( IdProceso, IdTarea, Orden, Descripcion, IdConexion, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, RowId, Observaciones, OrdenBR, OrdenDA, OrdenUI );
		}

		/// <summary>
		/// solo trae de la tabla aquellas tuplas que tengan orden != -1
		/// </summary>
		/// <returns></returns>
		public static System.Data.DataSet GetList( long IdProceso, long IdTarea, int Orden, string Descripcion )
		{
			return mz.erp.dataaccess.twf_ProcesosTareas.GetList( IdProceso, IdTarea, Orden, Descripcion );
		}
		/// <summary>
		/// Crea un twf_ProcesosTareasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static twf_ProcesosTareasDataset.twf_ProcesosTareasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.twf_ProcesosTareas.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla twf_ProcesosTareas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static twf_ProcesosTareasDataset.twf_ProcesosTareasRow GetByPk( long IdProceso, long IdTarea )
		{
		   twf_ProcesosTareasDataset.twf_ProcesosTareasRow row = mz.erp.dataaccess.twf_ProcesosTareas.GetByPk( IdProceso, IdTarea  );
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
		/// Obtiene un registro de la tabla twf_ProcesosTareas que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static twf_ProcesosTareasDataset.twf_ProcesosTareasRow GetByPk( object IdProceso, object IdTarea )
		{
			return GetByPk( ( long )IdProceso, ( long )IdTarea );
		}

		/// <summary>
		/// Establece los valores por defecto de twf_ProcesosTareasRow.
		/// </summary>
		public static twf_ProcesosTareasDataset.twf_ProcesosTareasRow SetRowDefaultValues( twf_ProcesosTareasDataset.twf_ProcesosTareasRow row )
		{
			row.IdProceso = 0; 
			row.IdTarea = 0; 
			row.Orden = 0;
			row.Descripcion = string.Empty;
			row.IdConexion = 0;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;
			row.Observaciones = string.Empty;
			row.OrdenBR = 0;
			row.OrdenDA = 0;
			row.OrdenUI = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del twf_ProcesosTareasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( twf_ProcesosTareasDataset.twf_ProcesosTareasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del twf_ProcesosTareasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( twf_ProcesosTareasDataset.twf_ProcesosTareasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del twf_ProcesosTareasRow a la base de datos.
		/// </summary>
		public static void Update( twf_ProcesosTareasDataset.twf_ProcesosTareasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.twf_ProcesosTareas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del twf_ProcesosTareasDataset a la base de datos.
		/// </summary>
		public static void Update( twf_ProcesosTareasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.twf_ProcesosTareas.Rows.Count > 0, "La tabla dataSet.twf_ProcesosTareasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.twf_ProcesosTareas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del twf_ProcesosTareasDataset.twf_ProcesosTareasDataTable a la base de datos.
		/// </summary>
		public static void Update( twf_ProcesosTareasDataset.twf_ProcesosTareasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.twf_ProcesosTareas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un twf_ProcesosTareasRow.
		/// </summary>
		public static bool RowIsValid( twf_ProcesosTareasDataset.twf_ProcesosTareasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdProcesoIsValid( row.IdProceso, out mensaje) )
			{ 
				row.SetColumnError( "IdProceso" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTareaIsValid( row.IdTarea, out mensaje) )
			{ 
				row.SetColumnError( "IdTarea" , mensaje);
				isValid=false;
			
			}
						
			if ( !OrdenIsValid( row.Orden, out mensaje) )
			{ 
				row.SetColumnError( "Orden" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
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
						
			if ( !OrdenBRIsValid( row.OrdenBR, out mensaje) )
			{ 
				row.SetColumnError( "OrdenBR" , mensaje);
				isValid=false;
			
			}
						
			if ( !OrdenDAIsValid( row.OrdenDA, out mensaje) )
			{ 
				row.SetColumnError( "OrdenDA" , mensaje);
				isValid=false;
			
			}
						
			if ( !OrdenUIIsValid( row.OrdenUI, out mensaje) )
			{ 
				row.SetColumnError( "OrdenUI" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdProceso.
		/// </summary>
		public static bool IdProcesoIsValid( long IdProceso , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProceso. Metodo Sobrecargado
		/// </summary>
		public static bool IdProcesoIsValid( long IdProceso)
		{
			string mensaje;
			return IdProcesoIsValid( IdProceso, out mensaje );
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
		/// Valida el campo Orden.
		/// </summary>
		public static bool OrdenIsValid( int Orden , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Orden. Metodo Sobrecargado
		/// </summary>
		public static bool OrdenIsValid( int Orden)
		{
			string mensaje;
			return OrdenIsValid( Orden, out mensaje );
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
		
		/// <summary>
		/// Valida el campo OrdenBR.
		/// </summary>
		public static bool OrdenBRIsValid( int OrdenBR , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo OrdenBR. Metodo Sobrecargado
		/// </summary>
		public static bool OrdenBRIsValid( int OrdenBR)
		{
			string mensaje;
			return OrdenBRIsValid( OrdenBR, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo OrdenDA.
		/// </summary>
		public static bool OrdenDAIsValid( int OrdenDA , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo OrdenDA. Metodo Sobrecargado
		/// </summary>
		public static bool OrdenDAIsValid( int OrdenDA)
		{
			string mensaje;
			return OrdenDAIsValid( OrdenDA, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo OrdenUI.
		/// </summary>
		public static bool OrdenUIIsValid( int OrdenUI , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo OrdenUI. Metodo Sobrecargado
		/// </summary>
		public static bool OrdenUIIsValid( int OrdenUI)
		{
			string mensaje;
			return OrdenUIIsValid( OrdenUI, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}


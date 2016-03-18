namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class twf_ProcesosTareasValidaciones : IDisposable
	{
	
		#region Custom Members
			
		public static DataSet GetValidaciones(long IdProceso, long IdTarea)
		{
			return mz.erp.dataaccess.twf_ProcesosTareasValidaciones.GetList(null, null, IdProceso, IdTarea, Security.IdPerfil);
		}

		public static DataSet GetValidacionesForStartProcess(long IdProceso, long IdTarea)
		{
			return mz.erp.dataaccess.twf_ProcesosTareasValidaciones.GetValidacionesForStartProcess(IdProceso, IdTarea,Security.IdPerfil);
		}
		
		#endregion
		
		public twf_ProcesosTareasValidaciones()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla twf_ProcesosTareasValidaciones
		/// </summary>
		public static twf_ProcesosTareasValidacionesDataset GetList()
		{
			return mz.erp.dataaccess.twf_ProcesosTareasValidaciones.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla twf_ProcesosTareasValidaciones filtrada por las condiciones de bsqueda
		/// </summary>
		public static twf_ProcesosTareasValidacionesDataset GetList( string IdProcesoTareaValidacion, string IdValidacion, long IdProceso, long IdTarea, long IdPerfil )
		{
			return mz.erp.dataaccess.twf_ProcesosTareasValidaciones.GetList( IdProcesoTareaValidacion, IdValidacion, IdProceso, IdTarea, IdPerfil );
		}

		/// <summary>
		/// Crea un twf_ProcesosTareasValidacionesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static twf_ProcesosTareasValidacionesDataset.twf_ProcesosTareasValidacionesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.twf_ProcesosTareasValidaciones.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla twf_ProcesosTareasValidaciones que luego puede ser persistido en la base de datos.
		/// </summary>
		public static twf_ProcesosTareasValidacionesDataset.twf_ProcesosTareasValidacionesRow GetByPk( string IdProcesoTareaValidacion )
		{
			twf_ProcesosTareasValidacionesDataset.twf_ProcesosTareasValidacionesRow row = mz.erp.dataaccess.twf_ProcesosTareasValidaciones.GetByPk( IdProcesoTareaValidacion  );
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
		/// Obtiene un registro de la tabla twf_ProcesosTareasValidaciones que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static twf_ProcesosTareasValidacionesDataset.twf_ProcesosTareasValidacionesRow GetByPk( object IdProcesoTareaValidacion )
		{
			return GetByPk( ( string )IdProcesoTareaValidacion );
		}

		/// <summary>
		/// Establece los valores por defecto de twf_ProcesosTareasValidacionesRow.
		/// </summary>
		public static twf_ProcesosTareasValidacionesDataset.twf_ProcesosTareasValidacionesRow SetRowDefaultValues( twf_ProcesosTareasValidacionesDataset.twf_ProcesosTareasValidacionesRow row )
		{
			row.IdProcesoTareaValidacion = Util.NewStringId(); 
			row.IdValidacion = string.Empty;
			row.IdProceso = 0;
			row.IdTarea = 0;
			row.IdPerfil = 0;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = 0;
			row.IdEmpresa = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del twf_ProcesosTareasValidacionesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( twf_ProcesosTareasValidacionesDataset.twf_ProcesosTareasValidacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del twf_ProcesosTareasValidacionesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( twf_ProcesosTareasValidacionesDataset.twf_ProcesosTareasValidacionesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del twf_ProcesosTareasValidacionesRow a la base de datos.
		/// </summary>
		public static void Update( twf_ProcesosTareasValidacionesDataset.twf_ProcesosTareasValidacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.twf_ProcesosTareasValidaciones.Update( row );
		}

		/// <summary>
		/// Envia los cambios del twf_ProcesosTareasValidacionesDataset a la base de datos.
		/// </summary>
		public static void Update( twf_ProcesosTareasValidacionesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.twf_ProcesosTareasValidaciones.Rows.Count > 0, "La tabla dataSet.twf_ProcesosTareasValidacionesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.twf_ProcesosTareasValidaciones.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del twf_ProcesosTareasValidacionesDataset.twf_ProcesosTareasValidacionesDataTable a la base de datos.
		/// </summary>
		public static void Update( twf_ProcesosTareasValidacionesDataset.twf_ProcesosTareasValidacionesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.twf_ProcesosTareasValidaciones.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un twf_ProcesosTareasValidacionesRow.
		/// </summary>
		public static bool RowIsValid( twf_ProcesosTareasValidacionesDataset.twf_ProcesosTareasValidacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdProcesoTareaValidacionIsValid( row.IdProcesoTareaValidacion, out mensaje) )
			{ 
				row.SetColumnError( "IdProcesoTareaValidacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdValidacionIsValid( row.IdValidacion, out mensaje) )
			{ 
				row.SetColumnError( "IdValidacion" , mensaje);
				isValid=false;
			
			}
						
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
						
			if ( !IdPerfilIsValid( row.IdPerfil, out mensaje) )
			{ 
				row.SetColumnError( "IdPerfil" , mensaje);
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
						
			if ( !IdReservadoIsValid( row.IdReservado, out mensaje) )
			{ 
				row.SetColumnError( "IdReservado" , mensaje);
				isValid=false;
			
			}
						
			if ( !RowIdIsValid( row.RowId, out mensaje) )
			{ 
				row.SetColumnError( "RowId" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdSucursalIsValid( row.IdSucursal, out mensaje) )
			{ 
				row.SetColumnError( "IdSucursal" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEmpresaIsValid( row.IdEmpresa, out mensaje) )
			{ 
				row.SetColumnError( "IdEmpresa" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdProcesoTareaValidacion.
		/// </summary>
		public static bool IdProcesoTareaValidacionIsValid( string IdProcesoTareaValidacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProcesoTareaValidacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdProcesoTareaValidacionIsValid( string IdProcesoTareaValidacion)
		{
			string mensaje;
			return IdProcesoTareaValidacionIsValid( IdProcesoTareaValidacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdValidacion.
		/// </summary>
		public static bool IdValidacionIsValid( string IdValidacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdValidacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdValidacionIsValid( string IdValidacion)
		{
			string mensaje;
			return IdValidacionIsValid( IdValidacion, out mensaje );
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
		/// Valida el campo IdPerfil.
		/// </summary>
		public static bool IdPerfilIsValid( long IdPerfil , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdPerfil. Metodo Sobrecargado
		/// </summary>
		public static bool IdPerfilIsValid( long IdPerfil)
		{
			string mensaje;
			return IdPerfilIsValid( IdPerfil, out mensaje );
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
		/// Valida el campo IdReservado.
		/// </summary>
		public static bool IdReservadoIsValid( long IdReservado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdReservado. Metodo Sobrecargado
		/// </summary>
		public static bool IdReservadoIsValid( long IdReservado)
		{
			string mensaje;
			return IdReservadoIsValid( IdReservado, out mensaje );
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
		/// Valida el campo IdSucursal.
		/// </summary>
		public static bool IdSucursalIsValid( long IdSucursal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSucursal. Metodo Sobrecargado
		/// </summary>
		public static bool IdSucursalIsValid( long IdSucursal)
		{
			string mensaje;
			return IdSucursalIsValid( IdSucursal, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdEmpresa.
		/// </summary>
		public static bool IdEmpresaIsValid( long IdEmpresa , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEmpresa. Metodo Sobrecargado
		/// </summary>
		public static bool IdEmpresaIsValid( long IdEmpresa)
		{
			string mensaje;
			return IdEmpresaIsValid( IdEmpresa, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}


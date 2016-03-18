namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tui_ConfiguracionGrillasPerfiles : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tui_ConfiguracionGrillasPerfiles()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tui_ConfiguracionGrillasPerfiles
		/// </summary>
		public static tui_ConfiguracionGrillasPerfilesDataset GetList()
		{
			return mz.erp.dataaccess.tui_ConfiguracionGrillasPerfiles.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tui_ConfiguracionGrillasPerfiles filtrada por las condiciones de bsqueda
		/// </summary>
		public static tui_ConfiguracionGrillasPerfilesDataset GetList( long IdPerfil, long IdProceso, long IdTarea, string Grilla, string Campo, string Propiedad, string Formulario )
		{
			return mz.erp.dataaccess.tui_ConfiguracionGrillasPerfiles.GetList( IdPerfil, IdProceso, IdTarea, Grilla, Campo, Propiedad, Formulario );
		}

		/// <summary>
		/// Crea un tui_ConfiguracionGrillasPerfilesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tui_ConfiguracionGrillasPerfilesDataset.tui_ConfiguracionGrillasPerfilesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tui_ConfiguracionGrillasPerfiles.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tui_ConfiguracionGrillasPerfiles que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tui_ConfiguracionGrillasPerfilesDataset.tui_ConfiguracionGrillasPerfilesRow GetByPk( long IdPerfil, long IdProceso, long IdTarea, string Grilla, string Campo, string Propiedad )
		{
			tui_ConfiguracionGrillasPerfilesDataset.tui_ConfiguracionGrillasPerfilesRow row = mz.erp.dataaccess.tui_ConfiguracionGrillasPerfiles.GetByPk( IdPerfil, IdProceso, IdTarea, Grilla, Campo, Propiedad  );
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
		/// Obtiene un registro de la tabla tui_ConfiguracionGrillasPerfiles que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tui_ConfiguracionGrillasPerfilesDataset.tui_ConfiguracionGrillasPerfilesRow GetByPk( object IdPerfil,object IdProceso,object IdTarea,object Grilla,object Campo,object Propiedad )
		{
			return GetByPk( ( long )IdPerfil, ( long )IdProceso, ( long )IdTarea, ( string )Grilla, ( string )Campo, ( string )Propiedad );
		}

		/// <summary>
		/// Establece los valores por defecto de tui_ConfiguracionGrillasPerfilesRow.
		/// </summary>
		public static tui_ConfiguracionGrillasPerfilesDataset.tui_ConfiguracionGrillasPerfilesRow SetRowDefaultValues( tui_ConfiguracionGrillasPerfilesDataset.tui_ConfiguracionGrillasPerfilesRow row )
		{
			row.IdPerfil = 0; 
			row.IdProceso = 0; 
			row.IdTarea = 0; 
			row.Grilla = Util.NewStringId(); 
			row.Campo = Util.NewStringId(); 
			row.Propiedad = Util.NewStringId(); 
			row.Valor = string.Empty;
			row.Activo = true;
			row.Comentario = string.Empty;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;
			row.IdEmpresa = 0;
			row.IdSucursal = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillasPerfilesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tui_ConfiguracionGrillasPerfilesDataset.tui_ConfiguracionGrillasPerfilesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillasPerfilesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tui_ConfiguracionGrillasPerfilesDataset.tui_ConfiguracionGrillasPerfilesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillasPerfilesRow a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionGrillasPerfilesDataset.tui_ConfiguracionGrillasPerfilesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionGrillasPerfiles.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillasPerfilesDataset a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionGrillasPerfilesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tui_ConfiguracionGrillasPerfiles.Rows.Count > 0, "La tabla dataSet.tui_ConfiguracionGrillasPerfilesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionGrillasPerfiles.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillasPerfilesDataset.tui_ConfiguracionGrillasPerfilesDataTable a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionGrillasPerfilesDataset.tui_ConfiguracionGrillasPerfilesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionGrillasPerfiles.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tui_ConfiguracionGrillasPerfilesRow.
		/// </summary>
		public static bool RowIsValid( tui_ConfiguracionGrillasPerfilesDataset.tui_ConfiguracionGrillasPerfilesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdPerfilIsValid( row.IdPerfil, out mensaje) )
			{ 
				row.SetColumnError( "IdPerfil" , mensaje);
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
						
			if ( !GrillaIsValid( row.Grilla, out mensaje) )
			{ 
				row.SetColumnError( "Grilla" , mensaje);
				isValid=false;
			
			}
						
			if ( !CampoIsValid( row.Campo, out mensaje) )
			{ 
				row.SetColumnError( "Campo" , mensaje);
				isValid=false;
			
			}
						
			if ( !PropiedadIsValid( row.Propiedad, out mensaje) )
			{ 
				row.SetColumnError( "Propiedad" , mensaje);
				isValid=false;
			
			}
						
			if ( !ValorIsValid( row.Valor, out mensaje) )
			{ 
				row.SetColumnError( "Valor" , mensaje);
				isValid=false;
			
			}
						
			if ( !ActivoIsValid( row.Activo, out mensaje) )
			{ 
				row.SetColumnError( "Activo" , mensaje);
				isValid=false;
			
			}
						
			if ( !ComentarioIsValid( row.Comentario, out mensaje) )
			{ 
				row.SetColumnError( "Comentario" , mensaje);
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
						
			if ( !IdEmpresaIsValid( row.IdEmpresa, out mensaje) )
			{ 
				row.SetColumnError( "IdEmpresa" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdSucursalIsValid( row.IdSucursal, out mensaje) )
			{ 
				row.SetColumnError( "IdSucursal" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
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
		/// Valida el campo Grilla.
		/// </summary>
		public static bool GrillaIsValid( string Grilla , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Grilla. Metodo Sobrecargado
		/// </summary>
		public static bool GrillaIsValid( string Grilla)
		{
			string mensaje;
			return GrillaIsValid( Grilla, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Campo.
		/// </summary>
		public static bool CampoIsValid( string Campo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Campo. Metodo Sobrecargado
		/// </summary>
		public static bool CampoIsValid( string Campo)
		{
			string mensaje;
			return CampoIsValid( Campo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Propiedad.
		/// </summary>
		public static bool PropiedadIsValid( string Propiedad , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Propiedad. Metodo Sobrecargado
		/// </summary>
		public static bool PropiedadIsValid( string Propiedad)
		{
			string mensaje;
			return PropiedadIsValid( Propiedad, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Valor.
		/// </summary>
		public static bool ValorIsValid( string Valor , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Valor. Metodo Sobrecargado
		/// </summary>
		public static bool ValorIsValid( string Valor)
		{
			string mensaje;
			return ValorIsValid( Valor, out mensaje );
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
		/// Valida el campo Comentario.
		/// </summary>
		public static bool ComentarioIsValid( string Comentario , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Comentario. Metodo Sobrecargado
		/// </summary>
		public static bool ComentarioIsValid( string Comentario)
		{
			string mensaje;
			return ComentarioIsValid( Comentario, out mensaje );
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
		

		public void Dispose()
		{
		}
		
	}
}


namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tui_ConfiguracionGrillaEstiloAplicadoPerfiles : IDisposable
	{
	
		#region Custom Members

		public static tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset GetList( long IdProceso, long IdTarea, string Grilla, string Formulario, long IdConfiguracion)
		{
			return GetList( long.MinValue, IdProceso, IdTarea, Grilla, Formulario, IdConfiguracion, long.MinValue, long.MinValue );
		}

		public static tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset GetList( long IdPerfil, long IdProceso, long IdTarea, string Grilla, string Formulario, long IdConfiguracion )
		{
			return GetList(IdPerfil ,IdProceso, IdTarea, Grilla, Formulario, IdConfiguracion, long.MinValue, long.MinValue );
		}

		public static tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset GetList( long IdConfiguracion )
		{
			return GetList(long.MinValue ,long.MinValue, long.MinValue, string.Empty, string.Empty, IdConfiguracion, long.MinValue, long.MinValue );
		}

		public static long GetIdConfiguracionAplicada( long IdPerfil, long IdProceso, long IdTarea, string Grilla, string Formulario)
		{
			tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset data = GetList( IdPerfil, IdProceso, IdTarea, Grilla, Formulario, long.MinValue, long.MinValue, long.MinValue );
			if(data.tui_ConfiguracionGrillaEstiloAplicadoPerfiles.Rows.Count > 0)
				return ((tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset.tui_ConfiguracionGrillaEstiloAplicadoPerfilesRow)data.tui_ConfiguracionGrillaEstiloAplicadoPerfiles.Rows[0]).IdConfiguracion;
			else
				return long.MinValue;
		}

		public static tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset.tui_ConfiguracionGrillaEstiloAplicadoPerfilesRow GetConfiguracionAplicada( long IdPerfil, long IdProceso, long IdTarea, string Grilla, string Formulario)
		{
			tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset data = GetList( IdPerfil, IdProceso, IdTarea, Grilla, Formulario, long.MinValue, long.MinValue, long.MinValue );
			if(data.tui_ConfiguracionGrillaEstiloAplicadoPerfiles.Rows.Count > 0)
				return (tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset.tui_ConfiguracionGrillaEstiloAplicadoPerfilesRow)data.tui_ConfiguracionGrillaEstiloAplicadoPerfiles.Rows[0];
			else
				return null;
		}

		#endregion
		
		public tui_ConfiguracionGrillaEstiloAplicadoPerfiles()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tui_ConfiguracionGrillaEstiloAplicadoPerfiles
		/// </summary>
		public static tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset GetList()
		{
			return mz.erp.dataaccess.tui_ConfiguracionGrillaEstiloAplicadoPerfiles.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tui_ConfiguracionGrillaEstiloAplicadoPerfiles filtrada por las condiciones de bsqueda
		/// </summary>
		public static tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset GetList( long IdPerfil, long IdProceso, long IdTarea, string Grilla, string Formulario, long IdConfiguracion, long IdEmpresa, long IdSucursal )
		{
			return mz.erp.dataaccess.tui_ConfiguracionGrillaEstiloAplicadoPerfiles.GetList( IdPerfil, IdProceso, IdTarea, Grilla, Formulario, IdConfiguracion, IdEmpresa, IdSucursal );
		}

		/// <summary>
		/// Crea un tui_ConfiguracionGrillaEstiloAplicadoPerfilesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset.tui_ConfiguracionGrillaEstiloAplicadoPerfilesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tui_ConfiguracionGrillaEstiloAplicadoPerfiles.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tui_ConfiguracionGrillaEstiloAplicadoPerfiles que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset.tui_ConfiguracionGrillaEstiloAplicadoPerfilesRow GetByPk( long IdPerfil, long IdProceso, long IdTarea, string Grilla, long IdConfiguracion )
		{
			tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset.tui_ConfiguracionGrillaEstiloAplicadoPerfilesRow row = mz.erp.dataaccess.tui_ConfiguracionGrillaEstiloAplicadoPerfiles.GetByPk( IdPerfil, IdProceso, IdTarea, Grilla, IdConfiguracion  );
			if(row != null)
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if (row[dc] == System.DBNull.Value)
					{
						row[dc] = Util.DefaultValue( dc.DataType );
					}
				}
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla tui_ConfiguracionGrillaEstiloAplicadoPerfiles que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset.tui_ConfiguracionGrillaEstiloAplicadoPerfilesRow GetByPk( object IdPerfil, object IdProceso, object IdTarea, object Grilla, object IdConfiguracion )
		{
			return GetByPk( ( long )IdPerfil, ( long )IdProceso, ( long )IdTarea, ( string )Grilla, ( long )IdConfiguracion );
		}

		/// <summary>
		/// Establece los valores por defecto de tui_ConfiguracionGrillaEstiloAplicadoPerfilesRow.
		/// </summary>
		public static tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset.tui_ConfiguracionGrillaEstiloAplicadoPerfilesRow SetRowDefaultValues( tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset.tui_ConfiguracionGrillaEstiloAplicadoPerfilesRow row )
		{
			row.IdPerfil = 0; 
			row.IdProceso = 0; 
			row.IdTarea = 0; 
			row.Grilla = Util.NewStringId(); 
			row.IdConfiguracion = 0;  
			row.Formulario = string.Empty;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = 0;
			row.IdSucursal = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillaEstiloAplicadoPerfilesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset.tui_ConfiguracionGrillaEstiloAplicadoPerfilesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillaEstiloAplicadoPerfilesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset.tui_ConfiguracionGrillaEstiloAplicadoPerfilesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillaEstiloAplicadoPerfilesRow a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset.tui_ConfiguracionGrillaEstiloAplicadoPerfilesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionGrillaEstiloAplicadoPerfiles.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tui_ConfiguracionGrillaEstiloAplicadoPerfiles.Rows.Count > 0, "La tabla dataSet.tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionGrillaEstiloAplicadoPerfiles.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset.tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataTable a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset.tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionGrillaEstiloAplicadoPerfiles.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tui_ConfiguracionGrillaEstiloAplicadoPerfilesRow.
		/// </summary>
		public static bool RowIsValid( tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset.tui_ConfiguracionGrillaEstiloAplicadoPerfilesRow row )
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
						
			if ( !FormularioIsValid( row.Formulario, out mensaje) )
			{ 
				row.SetColumnError( "Formulario" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConfiguracionIsValid( row.IdConfiguracion, out mensaje) )
			{ 
				row.SetColumnError( "IdConfiguracion" , mensaje);
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
		/// Valida el campo Formulario.
		/// </summary>
		public static bool FormularioIsValid( string Formulario , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Formulario. Metodo Sobrecargado
		/// </summary>
		public static bool FormularioIsValid( string Formulario)
		{
			string mensaje;
			return FormularioIsValid( Formulario, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdConfiguracion.
		/// </summary>
		public static bool IdConfiguracionIsValid( long IdConfiguracion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConfiguracion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConfiguracionIsValid( long IdConfiguracion)
		{
			string mensaje;
			return IdConfiguracionIsValid( IdConfiguracion, out mensaje );
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


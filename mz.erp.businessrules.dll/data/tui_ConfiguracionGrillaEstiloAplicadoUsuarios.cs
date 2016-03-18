namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tui_ConfiguracionGrillaEstiloAplicadoUsuarios : IDisposable
	{
	
		#region Custom Members
		public static tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset GetList( string IdUsuario, long IdProceso, long IdTarea, string Grilla, string Formulario, long IdConfiguracion )
		{
			return GetList(IdUsuario ,IdProceso, IdTarea, Grilla, Formulario, IdConfiguracion, long.MinValue, long.MinValue );
		}

		public static tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset GetList( long IdProceso, long IdTarea, string Grilla, string Formulario, long IdConfiguracion )
		{
			return GetList(string.Empty ,IdProceso, IdTarea, Grilla, Formulario, IdConfiguracion, long.MinValue, long.MinValue );
		}

		public static tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset GetList( long IdConfiguracion )
		{
			return GetList(string.Empty ,long.MinValue, long.MinValue, string.Empty, string.Empty, IdConfiguracion, long.MinValue, long.MinValue );
		}

		public static long GetIdConfiguracionAplicada( string IdUsuario, long IdProceso, long IdTarea, string Grilla, string Formulario)
		{
			tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset data = GetList(IdUsuario, IdProceso, IdTarea, Grilla, Formulario, long.MinValue, long.MinValue, long.MinValue );
			if(data.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.Rows.Count > 0)
				return ((tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset.tui_ConfiguracionGrillaEstiloAplicadoUsuariosRow)data.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.Rows[0]).IdConfiguracion;
			else
				return long.MinValue;
		}

		public static tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset.tui_ConfiguracionGrillaEstiloAplicadoUsuariosRow GetConfiguracionAplicada( string IdUsuario, long IdProceso, long IdTarea, string Grilla, string Formulario)
		{
			tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset data = GetList(IdUsuario, IdProceso, IdTarea, Grilla, Formulario, long.MinValue, long.MinValue, long.MinValue );
			if(data.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.Rows.Count > 0)
				return (tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset.tui_ConfiguracionGrillaEstiloAplicadoUsuariosRow)data.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.Rows[0];
			else
				return null;
		}
		#endregion
		
		public tui_ConfiguracionGrillaEstiloAplicadoUsuarios()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tui_ConfiguracionGrillaEstiloAplicadoUsuarios
		/// </summary>
		public static tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset GetList()
		{
			return mz.erp.dataaccess.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tui_ConfiguracionGrillaEstiloAplicadoUsuarios filtrada por las condiciones de bsqueda
		/// </summary>
		public static tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset GetList( string IdUsuario, long IdProceso, long IdTarea, string Grilla, string Formulario, long IdConfiguracion, long IdEmpresa, long IdSucursal )
		{
			return mz.erp.dataaccess.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.GetList( IdUsuario, IdProceso, IdTarea, Grilla, Formulario, IdConfiguracion, IdEmpresa, IdSucursal );
		}

		/// <summary>
		/// Crea un tui_ConfiguracionGrillaEstiloAplicadoUsuariosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset.tui_ConfiguracionGrillaEstiloAplicadoUsuariosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tui_ConfiguracionGrillaEstiloAplicadoUsuarios que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset.tui_ConfiguracionGrillaEstiloAplicadoUsuariosRow GetByPk( string IdUsuario, long IdProceso, long IdTarea, string Grilla, long IdConfiguracion )
		{
			tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset.tui_ConfiguracionGrillaEstiloAplicadoUsuariosRow row = mz.erp.dataaccess.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.GetByPk( IdUsuario, IdProceso, IdTarea, Grilla, IdConfiguracion  );
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
		/// Obtiene un registro de la tabla tui_ConfiguracionGrillaEstiloAplicadoUsuarios que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset.tui_ConfiguracionGrillaEstiloAplicadoUsuariosRow GetByPk( object IdUsuario, object IdProceso, object IdTarea, object Grilla, object IdConfiguracion )
		{
			return GetByPk( ( string )IdUsuario, ( long )IdProceso, ( long )IdTarea, ( string )Grilla, ( long )IdConfiguracion );
		}

		/// <summary>
		/// Establece los valores por defecto de tui_ConfiguracionGrillaEstiloAplicadoUsuariosRow.
		/// </summary>
		public static tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset.tui_ConfiguracionGrillaEstiloAplicadoUsuariosRow SetRowDefaultValues( tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset.tui_ConfiguracionGrillaEstiloAplicadoUsuariosRow row )
		{
			row.IdUsuario = Util.NewStringId(); 
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
		/// Envia los cambios del tui_ConfiguracionGrillaEstiloAplicadoUsuariosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset.tui_ConfiguracionGrillaEstiloAplicadoUsuariosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillaEstiloAplicadoUsuariosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset.tui_ConfiguracionGrillaEstiloAplicadoUsuariosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillaEstiloAplicadoUsuariosRow a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset.tui_ConfiguracionGrillaEstiloAplicadoUsuariosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.Rows.Count > 0, "La tabla dataSet.tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset.tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataTable a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset.tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tui_ConfiguracionGrillaEstiloAplicadoUsuariosRow.
		/// </summary>
		public static bool RowIsValid( tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset.tui_ConfiguracionGrillaEstiloAplicadoUsuariosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdUsuarioIsValid( row.IdUsuario, out mensaje) )
			{ 
				row.SetColumnError( "IdUsuario" , mensaje);
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
		/// Valida el campo IdUsuario.
		/// </summary>
		public static bool IdUsuarioIsValid( string IdUsuario , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdUsuario. Metodo Sobrecargado
		/// </summary>
		public static bool IdUsuarioIsValid( string IdUsuario)
		{
			string mensaje;
			return IdUsuarioIsValid( IdUsuario, out mensaje );
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


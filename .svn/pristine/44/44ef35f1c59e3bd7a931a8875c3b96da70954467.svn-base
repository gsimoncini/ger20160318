namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tui_ConfiguracionGrillaEstilosAplicablesModificables : IDisposable
	{
	
		#region Custom Members
		public static tui_ConfiguracionGrillaEstilosAplicablesModificablesDataset GetList( long IdProceso, long IdTarea, string Grilla, string Formulario, long IdConfiguracion)
		{
			return GetList( IdProceso, IdTarea, Grilla, Formulario, IdConfiguracion, DateTime.MinValue, long.MinValue, long.MinValue );
		}

		public static tui_ConfiguracionGrillaEstilosAplicablesModificablesDataset GetList( long IdConfiguracion)
		{
			return GetList( long.MinValue, long.MinValue, string.Empty, string.Empty, IdConfiguracion, DateTime.MinValue, long.MinValue, long.MinValue );
		}
		#endregion
		
		public tui_ConfiguracionGrillaEstilosAplicablesModificables()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tui_ConfiguracionGrillaEstilosAplicablesModificables
		/// </summary>
		public static tui_ConfiguracionGrillaEstilosAplicablesModificablesDataset GetList()
		{
			return mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosAplicablesModificables.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tui_ConfiguracionGrillaEstilosAplicablesModificables filtrada por las condiciones de bsqueda
		/// </summary>
		public static tui_ConfiguracionGrillaEstilosAplicablesModificablesDataset GetList( long IdProceso, long IdTarea, string Grilla, string Formulario, long IdConfiguracion, DateTime FechaCreacion, long IdEmpresa, long IdSucursal )
		{
			return mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosAplicablesModificables.GetList( IdProceso, IdTarea, Grilla, Formulario, IdConfiguracion, FechaCreacion, IdEmpresa, IdSucursal );
		}

		/// <summary>
		/// Crea un tui_ConfiguracionGrillaEstilosAplicablesModificablesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tui_ConfiguracionGrillaEstilosAplicablesModificablesDataset.tui_ConfiguracionGrillaEstilosAplicablesModificablesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosAplicablesModificables.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tui_ConfiguracionGrillaEstilosAplicablesModificables que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tui_ConfiguracionGrillaEstilosAplicablesModificablesDataset.tui_ConfiguracionGrillaEstilosAplicablesModificablesRow GetByPk( long IdProceso, long IdTarea, string Grilla, long IdConfiguracion )
		{
			tui_ConfiguracionGrillaEstilosAplicablesModificablesDataset.tui_ConfiguracionGrillaEstilosAplicablesModificablesRow row = mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosAplicablesModificables.GetByPk( IdProceso, IdTarea, Grilla, IdConfiguracion  );
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
		/// Obtiene un registro de la tabla tui_ConfiguracionGrillaEstilosAplicablesModificables que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tui_ConfiguracionGrillaEstilosAplicablesModificablesDataset.tui_ConfiguracionGrillaEstilosAplicablesModificablesRow GetByPk( object IdProceso, object IdTarea, object Grilla, object IdConfiguracion )
		{
			return GetByPk( ( long )IdProceso, ( long )IdTarea, ( string )Grilla, ( long )IdConfiguracion );
		}

		/// <summary>
		/// Establece los valores por defecto de tui_ConfiguracionGrillaEstilosAplicablesModificablesRow.
		/// </summary>
		public static tui_ConfiguracionGrillaEstilosAplicablesModificablesDataset.tui_ConfiguracionGrillaEstilosAplicablesModificablesRow SetRowDefaultValues( tui_ConfiguracionGrillaEstilosAplicablesModificablesDataset.tui_ConfiguracionGrillaEstilosAplicablesModificablesRow row )
		{
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
		/// Envia los cambios del tui_ConfiguracionGrillaEstilosAplicablesModificablesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tui_ConfiguracionGrillaEstilosAplicablesModificablesDataset.tui_ConfiguracionGrillaEstilosAplicablesModificablesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillaEstilosAplicablesModificablesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tui_ConfiguracionGrillaEstilosAplicablesModificablesDataset.tui_ConfiguracionGrillaEstilosAplicablesModificablesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillaEstilosAplicablesModificablesRow a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionGrillaEstilosAplicablesModificablesDataset.tui_ConfiguracionGrillaEstilosAplicablesModificablesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosAplicablesModificables.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillaEstilosAplicablesModificablesDataset a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionGrillaEstilosAplicablesModificablesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tui_ConfiguracionGrillaEstilosAplicablesModificables.Rows.Count > 0, "La tabla dataSet.tui_ConfiguracionGrillaEstilosAplicablesModificablesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosAplicablesModificables.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillaEstilosAplicablesModificablesDataset.tui_ConfiguracionGrillaEstilosAplicablesModificablesDataTable a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionGrillaEstilosAplicablesModificablesDataset.tui_ConfiguracionGrillaEstilosAplicablesModificablesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosAplicablesModificables.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tui_ConfiguracionGrillaEstilosAplicablesModificablesRow.
		/// </summary>
		public static bool RowIsValid( tui_ConfiguracionGrillaEstilosAplicablesModificablesDataset.tui_ConfiguracionGrillaEstilosAplicablesModificablesRow row )
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


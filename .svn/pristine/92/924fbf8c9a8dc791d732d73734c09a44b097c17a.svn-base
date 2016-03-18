namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tui_ConfiguracionGrillaEstilosCondicionalesUsuarios : IDisposable
	{
	
		#region Custom Members
		public static tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow GetByName( string Nombre)
		{
			tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow row = mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.GetByName( Nombre);
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

		public static tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow GetByName( string Nombre, string IdUsuario)
		{
			tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow row = mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.GetByName( Nombre, IdUsuario);
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
		/*public static tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow GetByIdConfiguracion( long IdConfiguracion)
		{
			tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow row = mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.GetByIdConfiguracion( IdConfiguracion);
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

		*/
		#endregion
		
		public tui_ConfiguracionGrillaEstilosCondicionalesUsuarios()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tui_ConfiguracionGrillaEstilosCondicionalesUsuarios
		/// </summary>
		public static tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset GetList()
		{
			return mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tui_ConfiguracionGrillaEstilosCondicionalesUsuarios filtrada por las condiciones de bsqueda
		/// </summary>
		public static tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset GetList( string IdUsuario, long IdConfiguracion, string Nombre, string IdUsuarioCreador, long IdEmpresa, long IdSucursal )
		{
			return mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.GetList( IdUsuario, IdConfiguracion, Nombre, IdUsuarioCreador, IdEmpresa, IdSucursal );
		}

		/// <summary>
		/// Crea un tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tui_ConfiguracionGrillaEstilosCondicionalesUsuarios que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow GetByPk( string IdUsuario, long IdConfiguracion )
		{
			tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow row = mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.GetByPk( IdUsuario, IdConfiguracion  );
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
		/// Obtiene un registro de la tabla tui_ConfiguracionGrillaEstilosCondicionalesUsuarios que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow GetByPk( object IdUsuario, object IdConfiguracion )
		{
			return GetByPk( ( string )IdUsuario, ( long )IdConfiguracion );
		}

		/// <summary>
		/// Establece los valores por defecto de tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow.
		/// </summary>
		public static tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow SetRowDefaultValues( tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow row )
		{
			row.IdUsuario = Util.NewStringId(); 
			row.IdConfiguracion = Util.NewLongId(); 
			row.Nombre = string.Empty;
			row.IdUsuarioCreador = string.Empty;
			row.Activo = false;
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
		/// Envia los cambios del tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.Rows.Count > 0, "La tabla dataSet.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataTable a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow.
		/// </summary>
		public static bool RowIsValid( tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdUsuarioIsValid( row.IdUsuario, out mensaje) )
			{ 
				row.SetColumnError( "IdUsuario" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConfiguracionIsValid( row.IdConfiguracion, out mensaje) )
			{ 
				row.SetColumnError( "IdConfiguracion" , mensaje);
				isValid=false;
			
			}
						
			if ( !NombreIsValid( row.Nombre, out mensaje) )
			{ 
				row.SetColumnError( "Nombre" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdUsuarioCreadorIsValid( row.IdUsuarioCreador, out mensaje) )
			{ 
				row.SetColumnError( "IdUsuarioCreador" , mensaje);
				isValid=false;
			
			}
						
			if ( !ActivoIsValid( row.Activo, out mensaje) )
			{ 
				row.SetColumnError( "Activo" , mensaje);
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
		/// Valida el campo Nombre.
		/// </summary>
		public static bool NombreIsValid( string Nombre , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Nombre. Metodo Sobrecargado
		/// </summary>
		public static bool NombreIsValid( string Nombre)
		{
			string mensaje;
			return NombreIsValid( Nombre, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdUsuarioCreador.
		/// </summary>
		public static bool IdUsuarioCreadorIsValid( string IdUsuarioCreador , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdUsuarioCreador. Metodo Sobrecargado
		/// </summary>
		public static bool IdUsuarioCreadorIsValid( string IdUsuarioCreador)
		{
			string mensaje;
			return IdUsuarioCreadorIsValid( IdUsuarioCreador, out mensaje );
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


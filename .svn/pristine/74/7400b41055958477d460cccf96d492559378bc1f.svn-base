namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios : IDisposable
	{
	
		#region Custom Members
		public static tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataset GetList(string IdUsuario, long IdConfiguracion, long IdCondicion)
		{
			return mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.GetList(IdUsuario, IdConfiguracion, IdCondicion, string.Empty, string.Empty, long.MinValue, long.MinValue );
		}

		#endregion
		
		public tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios
		/// </summary>
		public static tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataset GetList()
		{
			return mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios filtrada por las condiciones de bsqueda
		/// </summary>
		public static tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataset GetList( string IdUsuario, long IdConfiguracion, long IdCondicion, string Propiedad, string Valor, long IdEmpresa, long IdSucursal )
		{
			return mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.GetList( IdUsuario, IdConfiguracion, IdCondicion, Propiedad, Valor, IdEmpresa, IdSucursal );
		}

		/// <summary>
		/// Crea un tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow GetByPk( string IdUsuario, long IdConfiguracion, long IdCondicion, string Propiedad )
		{
			tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow row = mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.GetByPk( IdUsuario, IdConfiguracion, IdCondicion, Propiedad  );
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
		/// Obtiene un registro de la tabla tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow GetByPk( object IdUsuario, object IdConfiguracion, object IdCondicion, object Propiedad )
		{
			return GetByPk( ( string )IdUsuario, ( long )IdConfiguracion, ( long )IdCondicion, ( string )Propiedad );
		}

		/// <summary>
		/// Establece los valores por defecto de tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow.
		/// </summary>
		public static tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow SetRowDefaultValues( tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow row )
		{
			row.IdUsuario = Util.NewStringId(); 
			row.IdConfiguracion = Util.NewLongId(); 
			row.IdCondicion = Util.NewLongId(); 
			row.Propiedad = Util.NewStringId(); 
			row.Valor = string.Empty;
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
		/// Envia los cambios del tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataset a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.Rows.Count > 0, "La tabla dataSet.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataTable a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuarios.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow.
		/// </summary>
		public static bool RowIsValid( tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetEstilosAplicadosUsuariosRow row )
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
						
			if ( !IdCondicionIsValid( row.IdCondicion, out mensaje) )
			{ 
				row.SetColumnError( "IdCondicion" , mensaje);
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
		/// Valida el campo IdCondicion.
		/// </summary>
		public static bool IdCondicionIsValid( long IdCondicion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCondicion. Metodo Sobrecargado
		/// </summary>
		public static bool IdCondicionIsValid( long IdCondicion)
		{
			string mensaje;
			return IdCondicionIsValid( IdCondicion, out mensaje );
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


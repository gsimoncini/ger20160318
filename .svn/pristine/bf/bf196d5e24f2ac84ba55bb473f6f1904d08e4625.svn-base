namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Data.SqlClient;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;	

	public class tsa_CuentasObservaciones : IDisposable
	{
	
		#region Custom Members
		/// <summary>
		/// Envia los cambios del sy_UsuariosDataset a la base de datos.
		/// </summary>
		
		public static void Update( tsa_CuentasObservacionesDataset data, SqlTransaction trx, SentenciasReplicacion replicacion)
		{					
			mz.erp.dataaccess.tsa_CuentasObservaciones.Update((DataTable) data.tsa_CuentasObservaciones, trx, replicacion );
		}

		public static DataTable GetListEx(string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdCuentaObservacionTipo, string IdCuentaObservacionSubTipo, string IdCuentaObservacionEstado, string IdResponsable)
		{
			string IdCuentaObservacion = null; 		
			bool Activo = true;
			long IdPerfil = Security.IdPerfil;			
			long IdSucursal = Security.IdSucursal; 
			long IdEmpresa = Security.IdEmpresa;
			DataSet data = (DataSet) mz.erp.dataaccess.tsa_CuentasObservaciones.GetListEx(IdCuentaObservacion, IdCuenta, IdPerfil, FechaDesde, FechaHasta, IdCuentaObservacionTipo, IdCuentaObservacionSubTipo, IdCuentaObservacionEstado, IdResponsable, Activo, IdSucursal, IdEmpresa);			
			return data.Tables[0];			
		}


		#endregion
		
		public tsa_CuentasObservaciones()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_CuentasObservaciones
		/// </summary>
		/*public static tsa_CuentasObservacionesDataset GetList(string IdCuenta)
		{
			return mz.erp.dataaccess.tsa_CuentasObservaciones.GetList(IdCuenta);
		}*/
		
		/// <summary>
		/// Obtiene tabla tsa_CuentasObservaciones filtrada por las condiciones de bsqueda
		/// </summary>
		/*public static tsa_CuentasObservacionesDataset GetList( parametros )
		{
			return mz.erp.dataaccess.tsa_CuentasObservaciones.GetList(  );
		}*/

		/// <summary>
		/// Crea un tsa_CuentasObservacionesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsa_CuentasObservacionesDataset.tsa_CuentasObservacionesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsa_CuentasObservaciones.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_CuentasObservaciones que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_CuentasObservacionesDataset.tsa_CuentasObservacionesRow GetByPk( string IdCuentaObservacion )
		{
			tsa_CuentasObservacionesDataset.tsa_CuentasObservacionesRow row = mz.erp.dataaccess.tsa_CuentasObservaciones.GetByPk( IdCuentaObservacion  );
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
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_CuentasObservaciones que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsa_CuentasObservacionesDataset.tsa_CuentasObservacionesRow GetByPk( object IdCuentaObservacion )
		{
			return GetByPk( ( string )IdCuentaObservacion );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_CuentasObservacionesRow.
		/// </summary>
		public static tsa_CuentasObservacionesDataset.tsa_CuentasObservacionesRow SetRowDefaultValues( tsa_CuentasObservacionesDataset.tsa_CuentasObservacionesRow row )
		{
			row.IdCuentaObservacion = Util.NewStringId(); 
			row.IdCuenta = string.Empty;
			row.Titulo = string.Empty;
			row.Observacion = string.Empty;
			row.IdResponsable = Security.IdPersona;
			row.Fecha = DateTime.Now;
			row.IdCuentaObservacionTipo = string.Empty;
			row.IdCuentaObservacionSubTipo = string.Empty;
			row.IdCuentaObservacionEstado = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.Activo = true;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = Security.IdSucursal;
			row.IdEmpresa = Security.IdEmpresa;;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CuentasObservacionesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsa_CuentasObservacionesDataset.tsa_CuentasObservacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CuentasObservacionesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsa_CuentasObservacionesDataset.tsa_CuentasObservacionesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CuentasObservacionesRow a la base de datos.
		/// </summary>
		public static void Update( tsa_CuentasObservacionesDataset.tsa_CuentasObservacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_CuentasObservaciones.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_CuentasObservacionesDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_CuentasObservacionesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_CuentasObservaciones.Rows.Count > 0, "La tabla dataSet.tsa_CuentasObservacionesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_CuentasObservaciones.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CuentasObservacionesDataset.tsa_CuentasObservacionesDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_CuentasObservacionesDataset.tsa_CuentasObservacionesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_CuentasObservaciones.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_CuentasObservacionesRow.
		/// </summary>
		public static bool RowIsValid( tsa_CuentasObservacionesDataset.tsa_CuentasObservacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdCuentaObservacionIsValid( row.IdCuentaObservacion, out mensaje) )
			{ 
				row.SetColumnError( "IdCuentaObservacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCuentaIsValid( row.IdCuenta, out mensaje) )
			{ 
				row.SetColumnError( "IdCuenta" , mensaje);
				isValid=false;
			
			}
						
			if ( !TituloIsValid( row.Titulo, out mensaje) )
			{ 
				row.SetColumnError( "Titulo" , mensaje);
				isValid=false;
			
			}
						
			if ( !ObservacionIsValid( row.Observacion, out mensaje) )
			{ 
				row.SetColumnError( "Observacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdResponsableIsValid( row.IdResponsable, out mensaje) )
			{ 
				row.SetColumnError( "IdResponsable" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaIsValid( row.Fecha, out mensaje) )
			{ 
				row.SetColumnError( "Fecha" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCuentaObservacionTipoIsValid( row.IdCuentaObservacionTipo, out mensaje) )
			{ 
				row.SetColumnError( "IdCuentaObservacionTipo" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCuentaObservacionSubTipoIsValid( row.IdCuentaObservacionSubTipo, out mensaje) )
			{ 
				row.SetColumnError( "IdCuentaObservacionSubTipo" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCuentaObservacionEstadoIsValid( row.IdCuentaObservacionEstado, out mensaje) )
			{ 
				row.SetColumnError( "IdCuentaObservacionEstado" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaCreacionIsValid( row.FechaCreacion, out mensaje) )
			{ 
				row.SetColumnError( "FechaCreacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !ActivoIsValid( row.Activo, out mensaje) )
			{ 
				row.SetColumnError( "Activo" , mensaje);
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
		/// Valida el campo IdCuentaObservacion.
		/// </summary>
		public static bool IdCuentaObservacionIsValid( string IdCuentaObservacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCuentaObservacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdCuentaObservacionIsValid( string IdCuentaObservacion)
		{
			string mensaje;
			return IdCuentaObservacionIsValid( IdCuentaObservacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCuenta.
		/// </summary>
		public static bool IdCuentaIsValid( string IdCuenta , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCuenta. Metodo Sobrecargado
		/// </summary>
		public static bool IdCuentaIsValid( string IdCuenta)
		{
			string mensaje;
			return IdCuentaIsValid( IdCuenta, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Titulo.
		/// </summary>
		public static bool TituloIsValid( string Titulo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Titulo. Metodo Sobrecargado
		/// </summary>
		public static bool TituloIsValid( string Titulo)
		{
			string mensaje;
			return TituloIsValid( Titulo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Observacion.
		/// </summary>
		public static bool ObservacionIsValid( string Observacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Observacion. Metodo Sobrecargado
		/// </summary>
		public static bool ObservacionIsValid( string Observacion)
		{
			string mensaje;
			return ObservacionIsValid( Observacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdResponsable.
		/// </summary>
		public static bool IdResponsableIsValid( string IdResponsable , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdResponsable. Metodo Sobrecargado
		/// </summary>
		public static bool IdResponsableIsValid( string IdResponsable)
		{
			string mensaje;
			return IdResponsableIsValid( IdResponsable, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Fecha.
		/// </summary>
		public static bool FechaIsValid( DateTime Fecha , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Fecha. Metodo Sobrecargado
		/// </summary>
		public static bool FechaIsValid( DateTime Fecha)
		{
			string mensaje;
			return FechaIsValid( Fecha, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCuentaObservacionTipo.
		/// </summary>
		public static bool IdCuentaObservacionTipoIsValid( string IdCuentaObservacionTipo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCuentaObservacionTipo. Metodo Sobrecargado
		/// </summary>
		public static bool IdCuentaObservacionTipoIsValid( string IdCuentaObservacionTipo)
		{
			string mensaje;
			return IdCuentaObservacionTipoIsValid( IdCuentaObservacionTipo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCuentaObservacionSubTipo.
		/// </summary>
		public static bool IdCuentaObservacionSubTipoIsValid( string IdCuentaObservacionSubTipo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCuentaObservacionSubTipo. Metodo Sobrecargado
		/// </summary>
		public static bool IdCuentaObservacionSubTipoIsValid( string IdCuentaObservacionSubTipo)
		{
			string mensaje;
			return IdCuentaObservacionSubTipoIsValid( IdCuentaObservacionSubTipo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCuentaObservacionEstado.
		/// </summary>
		public static bool IdCuentaObservacionEstadoIsValid( string IdCuentaObservacionEstado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCuentaObservacionEstado. Metodo Sobrecargado
		/// </summary>
		public static bool IdCuentaObservacionEstadoIsValid( string IdCuentaObservacionEstado)
		{
			string mensaje;
			return IdCuentaObservacionEstadoIsValid( IdCuentaObservacionEstado, out mensaje );
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


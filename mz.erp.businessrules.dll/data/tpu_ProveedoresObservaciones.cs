namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;
	using System.Data.SqlClient;

	public class tpu_ProveedoresObservaciones : IDisposable
	{
	
		#region Custom Members
		public static void Update( tpu_ProveedoresObservacionesDataset data, SqlTransaction trx, SentenciasReplicacion replicacion)
		{					
			mz.erp.dataaccess.tpu_ProveedoresObservaciones.Update((DataTable) data.tpu_ProveedoresObservaciones, trx, replicacion );
		}

		public static DataTable GetListEx(string IdProveedor, DateTime FechaDesde, DateTime FechaHasta, string IdProveedorObservacionTipo, string IdProveedorObservacionSubTipo, string IdProveedorObservacionEstado, string IdResponsable)
		{
			string IdProveedorObservacion = null; 		
			bool Activo = true;
			long IdPerfil = Security.IdPerfil;			
			long IdSucursal = Security.IdSucursal; 
			long IdEmpresa = Security.IdEmpresa;
			DataSet data = (DataSet) mz.erp.dataaccess.tpu_ProveedoresObservaciones.GetListEx(IdProveedorObservacion, IdProveedor, IdPerfil, FechaDesde, FechaHasta, IdProveedorObservacionTipo, IdProveedorObservacionSubTipo, IdProveedorObservacionEstado, IdResponsable, Activo, IdSucursal, IdEmpresa);			
			return data.Tables[0];			
		}

		#endregion
		
		public tpu_ProveedoresObservaciones()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_ProveedoresObservaciones
		/// </summary>
		public static tpu_ProveedoresObservacionesDataset GetList()
		{
			return mz.erp.dataaccess.tpu_ProveedoresObservaciones.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_ProveedoresObservaciones filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_ProveedoresObservacionesDataset GetList( string IdProveedorObservacion, string IdProveedor, string Titulo, string Observacion, string IdResponsable, DateTime Fecha, string IdProveedorObservacionTipo, string IdProveedorObservacionSubTipo, string IdProveedorObservacionEstado, DateTime FechaCreacion, bool Activo )
		{
			return mz.erp.dataaccess.tpu_ProveedoresObservaciones.GetList( IdProveedorObservacion, IdProveedor, Titulo, Observacion, IdResponsable, Fecha, IdProveedorObservacionTipo, IdProveedorObservacionSubTipo, IdProveedorObservacionEstado, FechaCreacion, Activo );
		}

		/// <summary>
		/// Crea un tpu_ProveedoresObservacionesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tpu_ProveedoresObservacionesDataset.tpu_ProveedoresObservacionesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tpu_ProveedoresObservaciones.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_ProveedoresObservaciones que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_ProveedoresObservacionesDataset.tpu_ProveedoresObservacionesRow GetByPk( string IdProveedorObservacion )
		{
			tpu_ProveedoresObservacionesDataset.tpu_ProveedoresObservacionesRow row = mz.erp.dataaccess.tpu_ProveedoresObservaciones.GetByPk( IdProveedorObservacion  );
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
		/// Obtiene un registro de la tabla tpu_ProveedoresObservaciones que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tpu_ProveedoresObservacionesDataset.tpu_ProveedoresObservacionesRow GetByPk( object IdProveedorObservacion )
		{
			return GetByPk( ( string )IdProveedorObservacion );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_ProveedoresObservacionesRow.
		/// </summary>
		public static tpu_ProveedoresObservacionesDataset.tpu_ProveedoresObservacionesRow SetRowDefaultValues( tpu_ProveedoresObservacionesDataset.tpu_ProveedoresObservacionesRow row )
		{
			row.IdProveedorObservacion = Util.NewStringId(); 
			row.IdProveedor = string.Empty;
			row.Titulo = string.Empty;
			row.Observacion = string.Empty;
			row.IdResponsable = Security.IdPersona;
			row.Fecha = DateTime.Now;
			row.IdProveedorObservacionTipo = string.Empty;
			row.IdProveedorObservacionSubTipo = string.Empty;
			row.IdProveedorObservacionEstado = string.Empty;
			row.FechaCreacion = DateTime.Now;
			row.Activo = false;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = Security.IdSucursal;
			row.IdEmpresa = Security.IdEmpresa;
			row.FechaVencimiento = DateTime.Now;
			row.FechaAviso = DateTime.Now;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresObservacionesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tpu_ProveedoresObservacionesDataset.tpu_ProveedoresObservacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresObservacionesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tpu_ProveedoresObservacionesDataset.tpu_ProveedoresObservacionesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresObservacionesRow a la base de datos.
		/// </summary>
		public static void Update( tpu_ProveedoresObservacionesDataset.tpu_ProveedoresObservacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ProveedoresObservaciones.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_ProveedoresObservacionesDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_ProveedoresObservacionesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_ProveedoresObservaciones.Rows.Count > 0, "La tabla dataSet.tpu_ProveedoresObservacionesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ProveedoresObservaciones.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresObservacionesDataset.tpu_ProveedoresObservacionesDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_ProveedoresObservacionesDataset.tpu_ProveedoresObservacionesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ProveedoresObservaciones.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_ProveedoresObservacionesRow.
		/// </summary>
		public static bool RowIsValid( tpu_ProveedoresObservacionesDataset.tpu_ProveedoresObservacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdProveedorObservacionIsValid( row.IdProveedorObservacion, out mensaje) )
			{ 
				row.SetColumnError( "IdProveedorObservacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdProveedorIsValid( row.IdProveedor, out mensaje) )
			{ 
				row.SetColumnError( "IdProveedor" , mensaje);
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
						
			if ( !IdProveedorObservacionTipoIsValid( row.IdProveedorObservacionTipo, out mensaje) )
			{ 
				row.SetColumnError( "IdProveedorObservacionTipo" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdProveedorObservacionSubTipoIsValid( row.IdProveedorObservacionSubTipo, out mensaje) )
			{ 
				row.SetColumnError( "IdProveedorObservacionSubTipo" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdProveedorObservacionEstadoIsValid( row.IdProveedorObservacionEstado, out mensaje) )
			{ 
				row.SetColumnError( "IdProveedorObservacionEstado" , mensaje);
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
						
			if ( !FechaVencimientoIsValid( row.FechaVencimiento, out mensaje) )
			{ 
				row.SetColumnError( "FechaVencimiento" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaAvisoIsValid( row.FechaAviso, out mensaje) )
			{ 
				row.SetColumnError( "FechaAviso" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdProveedorObservacion.
		/// </summary>
		public static bool IdProveedorObservacionIsValid( string IdProveedorObservacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProveedorObservacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdProveedorObservacionIsValid( string IdProveedorObservacion)
		{
			string mensaje;
			return IdProveedorObservacionIsValid( IdProveedorObservacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdProveedor.
		/// </summary>
		public static bool IdProveedorIsValid( string IdProveedor , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProveedor. Metodo Sobrecargado
		/// </summary>
		public static bool IdProveedorIsValid( string IdProveedor)
		{
			string mensaje;
			return IdProveedorIsValid( IdProveedor, out mensaje );
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
		/// Valida el campo IdProveedorObservacionTipo.
		/// </summary>
		public static bool IdProveedorObservacionTipoIsValid( string IdProveedorObservacionTipo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProveedorObservacionTipo. Metodo Sobrecargado
		/// </summary>
		public static bool IdProveedorObservacionTipoIsValid( string IdProveedorObservacionTipo)
		{
			string mensaje;
			return IdProveedorObservacionTipoIsValid( IdProveedorObservacionTipo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdProveedorObservacionSubTipo.
		/// </summary>
		public static bool IdProveedorObservacionSubTipoIsValid( string IdProveedorObservacionSubTipo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProveedorObservacionSubTipo. Metodo Sobrecargado
		/// </summary>
		public static bool IdProveedorObservacionSubTipoIsValid( string IdProveedorObservacionSubTipo)
		{
			string mensaje;
			return IdProveedorObservacionSubTipoIsValid( IdProveedorObservacionSubTipo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdProveedorObservacionEstado.
		/// </summary>
		public static bool IdProveedorObservacionEstadoIsValid( string IdProveedorObservacionEstado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProveedorObservacionEstado. Metodo Sobrecargado
		/// </summary>
		public static bool IdProveedorObservacionEstadoIsValid( string IdProveedorObservacionEstado)
		{
			string mensaje;
			return IdProveedorObservacionEstadoIsValid( IdProveedorObservacionEstado, out mensaje );
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
		
		/// <summary>
		/// Valida el campo FechaVencimiento.
		/// </summary>
		public static bool FechaVencimientoIsValid( DateTime FechaVencimiento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaVencimiento. Metodo Sobrecargado
		/// </summary>
		public static bool FechaVencimientoIsValid( DateTime FechaVencimiento)
		{
			string mensaje;
			return FechaVencimientoIsValid( FechaVencimiento, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaAviso.
		/// </summary>
		public static bool FechaAvisoIsValid( DateTime FechaAviso , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaAviso. Metodo Sobrecargado
		/// </summary>
		public static bool FechaAvisoIsValid( DateTime FechaAviso)
		{
			string mensaje;
			return FechaAvisoIsValid( FechaAviso, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}


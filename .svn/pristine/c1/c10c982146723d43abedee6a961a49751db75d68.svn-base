namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_ProveedoresEstados : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_ProveedoresEstados()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_ProveedoresEstados
		/// </summary>
		public static tpu_ProveedoresEstadosDataset GetList()
		{
			return mz.erp.dataaccess.tpu_ProveedoresEstados.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_ProveedoresEstados filtrada por las condiciones de bsqueda
		/// </summary>
		/*public static tpu_ProveedoresEstadosDataset GetList(  )
		{
			return mz.erp.dataaccess.tpu_ProveedoresEstados.GetList(  );
		}*/	

		/// <summary>
		/// Crea un tpu_ProveedoresEstadosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tpu_ProveedoresEstadosDataset.tpu_ProveedoresEstadosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tpu_ProveedoresEstados.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_ProveedoresEstados que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_ProveedoresEstadosDataset.tpu_ProveedoresEstadosRow GetByPk( long IdEstado )
		{
			tpu_ProveedoresEstadosDataset.tpu_ProveedoresEstadosRow row = mz.erp.dataaccess.tpu_ProveedoresEstados.GetByPk( IdEstado  );
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
		/// Obtiene un registro de la tabla tpu_ProveedoresEstados que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tpu_ProveedoresEstadosDataset.tpu_ProveedoresEstadosRow GetByPk( object IdEstado )
		{
			return GetByPk( ( long )IdEstado );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_ProveedoresEstadosRow.
		/// </summary>
		public static tpu_ProveedoresEstadosDataset.tpu_ProveedoresEstadosRow SetRowDefaultValues( tpu_ProveedoresEstadosDataset.tpu_ProveedoresEstadosRow row )
		{
			row.IdEstado = 0; 
			row.Descripcion = string.Empty;
			row.Clave = string.Empty;
			row.Observaciones = string.Empty;
			row.Activo = false;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = 0;
			row.IdSsucursal = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresEstadosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tpu_ProveedoresEstadosDataset.tpu_ProveedoresEstadosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresEstadosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tpu_ProveedoresEstadosDataset.tpu_ProveedoresEstadosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresEstadosRow a la base de datos.
		/// </summary>
		public static void Update( tpu_ProveedoresEstadosDataset.tpu_ProveedoresEstadosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ProveedoresEstados.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_ProveedoresEstadosDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_ProveedoresEstadosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_ProveedoresEstados.Rows.Count > 0, "La tabla dataSet.tpu_ProveedoresEstadosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ProveedoresEstados.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresEstadosDataset.tpu_ProveedoresEstadosDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_ProveedoresEstadosDataset.tpu_ProveedoresEstadosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ProveedoresEstados.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_ProveedoresEstadosRow.
		/// </summary>
		public static bool RowIsValid( tpu_ProveedoresEstadosDataset.tpu_ProveedoresEstadosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdEstadoIsValid( row.IdEstado, out mensaje) )
			{ 
				row.SetColumnError( "IdEstado" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}
						
			if ( !ClaveIsValid( row.Clave, out mensaje) )
			{ 
				row.SetColumnError( "Clave" , mensaje);
				isValid=false;
			
			}
						
			if ( !ObservacionesIsValid( row.Observaciones, out mensaje) )
			{ 
				row.SetColumnError( "Observaciones" , mensaje);
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
						
			if ( !IdSsucursalIsValid( row.IdSsucursal, out mensaje) )
			{ 
				row.SetColumnError( "IdSsucursal" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdEstado.
		/// </summary>
		public static bool IdEstadoIsValid( long IdEstado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEstado. Metodo Sobrecargado
		/// </summary>
		public static bool IdEstadoIsValid( long IdEstado)
		{
			string mensaje;
			return IdEstadoIsValid( IdEstado, out mensaje );
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
		/// Valida el campo Clave.
		/// </summary>
		public static bool ClaveIsValid( string Clave , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Clave. Metodo Sobrecargado
		/// </summary>
		public static bool ClaveIsValid( string Clave)
		{
			string mensaje;
			return ClaveIsValid( Clave, out mensaje );
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
		/// Valida el campo IdSsucursal.
		/// </summary>
		public static bool IdSsucursalIsValid( long IdSsucursal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSsucursal. Metodo Sobrecargado
		/// </summary>
		public static bool IdSsucursalIsValid( long IdSsucursal)
		{
			string mensaje;
			return IdSsucursalIsValid( IdSsucursal, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}


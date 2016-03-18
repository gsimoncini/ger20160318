namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_Retenciones : IDisposable
	{
	
		#region Custom Members
		public static DataSet GetList( long IdRetencion )
		{
			return mz.erp.dataaccess.tpu_Retenciones.GetList( IdRetencion, string.Empty, decimal.MinValue, decimal.MinValue, string.Empty, DateTime.MinValue, string.Empty );
		}
		
		#endregion
		
		public tpu_Retenciones()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_Retenciones
		/// </summary>
		public static tpu_RetencionesDataset GetList()
		{
			return mz.erp.dataaccess.tpu_Retenciones.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_Retenciones filtrada por las condiciones de bsqueda
		/// </summary>
		public static DataSet GetList( long IdRetencion, string IdTipoDeRetencion, decimal MontoNeto, decimal MontoRetencion, string NumeroRetencion, DateTime FechaRetencion, string NumeroRecibo )
		{
			return mz.erp.dataaccess.tpu_Retenciones.GetList( IdRetencion, IdTipoDeRetencion, MontoNeto, MontoRetencion, NumeroRetencion, FechaRetencion, NumeroRecibo );
		}

		/// <summary>
		/// Crea un tpu_RetencionesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tpu_RetencionesDataset.tpu_RetencionesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tpu_Retenciones.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_Retenciones que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_RetencionesDataset.tpu_RetencionesRow GetByPk( long IdRetencion )
		{
			tpu_RetencionesDataset.tpu_RetencionesRow row = mz.erp.dataaccess.tpu_Retenciones.GetByPk( IdRetencion  );
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
		/// Obtiene un registro de la tabla tpu_Retenciones que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tpu_RetencionesDataset.tpu_RetencionesRow GetByPk( object IdRetencion )
		{
			return GetByPk( ( long )IdRetencion );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_RetencionesRow.
		/// </summary>
		public static tpu_RetencionesDataset.tpu_RetencionesRow SetRowDefaultValues( tpu_RetencionesDataset.tpu_RetencionesRow row )
		{
			row.IdRetencion = 0; 
			row.IdTipoDeRetencion = string.Empty;
			row.MontoNeto = 0;
			row.MontoRetencion = 0;
			row.NumeroRetencion = string.Empty;
			row.FechaRetencion = DateTime.Now;
			row.NumeroRecibo = string.Empty;
			row.IdComprobante = string.Empty;
			row.IdProveedor = string.Empty;
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
		/// Envia los cambios del tpu_RetencionesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tpu_RetencionesDataset.tpu_RetencionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tpu_RetencionesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tpu_RetencionesDataset.tpu_RetencionesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_RetencionesRow a la base de datos.
		/// </summary>
		public static void Update( tpu_RetencionesDataset.tpu_RetencionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_Retenciones.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_RetencionesDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_RetencionesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_Retenciones.Rows.Count > 0, "La tabla dataSet.tpu_RetencionesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_Retenciones.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_RetencionesDataset.tpu_RetencionesDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_RetencionesDataset.tpu_RetencionesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_Retenciones.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_RetencionesRow.
		/// </summary>
		public static bool RowIsValid( tpu_RetencionesDataset.tpu_RetencionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdRetencionIsValid( row.IdRetencion, out mensaje) )
			{ 
				row.SetColumnError( "IdRetencion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTipoDeRetencionIsValid( row.IdTipoDeRetencion, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoDeRetencion" , mensaje);
				isValid=false;
			
			}
						
			if ( !MontoNetoIsValid( row.MontoNeto, out mensaje) )
			{ 
				row.SetColumnError( "MontoNeto" , mensaje);
				isValid=false;
			
			}
						
			if ( !MontoRetencionIsValid( row.MontoRetencion, out mensaje) )
			{ 
				row.SetColumnError( "MontoRetencion" , mensaje);
				isValid=false;
			
			}
						
			if ( !NumeroRetencionIsValid( row.NumeroRetencion, out mensaje) )
			{ 
				row.SetColumnError( "NumeroRetencion" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaRetencionIsValid( row.FechaRetencion, out mensaje) )
			{ 
				row.SetColumnError( "FechaRetencion" , mensaje);
				isValid=false;
			
			}
						
			if ( !NumeroReciboIsValid( row.NumeroRecibo, out mensaje) )
			{ 
				row.SetColumnError( "NumeroRecibo" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdComprobanteIsValid( row.IdComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdComprobante" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdProveedorIsValid( row.IdProveedor, out mensaje) )
			{ 
				row.SetColumnError( "IdProveedor" , mensaje);
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
		/// Valida el campo IdRetencion.
		/// </summary>
		public static bool IdRetencionIsValid( long IdRetencion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdRetencion. Metodo Sobrecargado
		/// </summary>
		public static bool IdRetencionIsValid( long IdRetencion)
		{
			string mensaje;
			return IdRetencionIsValid( IdRetencion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTipoDeRetencion.
		/// </summary>
		public static bool IdTipoDeRetencionIsValid( string IdTipoDeRetencion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoDeRetencion. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoDeRetencionIsValid( string IdTipoDeRetencion)
		{
			string mensaje;
			return IdTipoDeRetencionIsValid( IdTipoDeRetencion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo MontoNeto.
		/// </summary>
		public static bool MontoNetoIsValid( decimal MontoNeto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo MontoNeto. Metodo Sobrecargado
		/// </summary>
		public static bool MontoNetoIsValid( decimal MontoNeto)
		{
			string mensaje;
			return MontoNetoIsValid( MontoNeto, out mensaje );
		}		
		
	
		/// <summary>
		/// Valida el campo MontoRetencion.
		/// </summary>
		public static bool MontoRetencionIsValid( decimal MontoRetencion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo MontoRetencion. Metodo Sobrecargado
		/// </summary>
		public static bool MontoRetencionIsValid( decimal MontoRetencion)
		{
			string mensaje;
			return MontoRetencionIsValid( MontoRetencion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo NumeroRetencion.
		/// </summary>
		public static bool NumeroRetencionIsValid( string NumeroRetencion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo NumeroRetencion. Metodo Sobrecargado
		/// </summary>
		public static bool NumeroRetencionIsValid( string NumeroRetencion)
		{
			string mensaje;
			return NumeroRetencionIsValid( NumeroRetencion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaRetencion.
		/// </summary>
		public static bool FechaRetencionIsValid( DateTime FechaRetencion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaRetencion. Metodo Sobrecargado
		/// </summary>
		public static bool FechaRetencionIsValid( DateTime FechaRetencion)
		{
			string mensaje;
			return FechaRetencionIsValid( FechaRetencion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo NumeroRecibo.
		/// </summary>
		public static bool NumeroReciboIsValid( string NumeroRecibo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo NumeroRecibo. Metodo Sobrecargado
		/// </summary>
		public static bool NumeroReciboIsValid( string NumeroRecibo)
		{
			string mensaje;
			return NumeroReciboIsValid( NumeroRecibo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdComprobante.
		/// </summary>
		public static bool IdComprobanteIsValid( string IdComprobante , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdComprobante. Metodo Sobrecargado
		/// </summary>
		public static bool IdComprobanteIsValid( string IdComprobante)
		{
			string mensaje;
			return IdComprobanteIsValid( IdComprobante, out mensaje );
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


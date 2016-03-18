namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_ComprobanteDetalleOrdenReparacion : IDisposable
	{
	
		#region Custom Members

		public static tsa_ComprobanteDetalleOrdenReparacionDataset GetListByIdOrdenReparacion( long IdOrdenReparacion)
		{
			return mz.erp.dataaccess.tsa_ComprobanteDetalleOrdenReparacion.GetListByIdOrdenReparacion( IdOrdenReparacion);
		}

		
		#endregion
		
		public tsa_ComprobanteDetalleOrdenReparacion()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_ComprobanteDetalleOrdenReparacion
		/// </summary>
		public static tsa_ComprobanteDetalleOrdenReparacionDataset GetList()
		{
			return mz.erp.dataaccess.tsa_ComprobanteDetalleOrdenReparacion.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_ComprobanteDetalleOrdenReparacion filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_ComprobanteDetalleOrdenReparacionDataset GetList( string IdComprobante, long IdOrdenReparacion, long Ordinal )
		{
			return mz.erp.dataaccess.tsa_ComprobanteDetalleOrdenReparacion.GetList( IdComprobante, IdOrdenReparacion, Ordinal );
		}

		/// <summary>
		/// Crea un tsa_ComprobanteDetalleOrdenReparacionRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsa_ComprobanteDetalleOrdenReparacionDataset.tsa_ComprobanteDetalleOrdenReparacionRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsa_ComprobanteDetalleOrdenReparacion.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_ComprobanteDetalleOrdenReparacion que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_ComprobanteDetalleOrdenReparacionDataset.tsa_ComprobanteDetalleOrdenReparacionRow GetByPk( string IdComprobante, long IdOrdenReparacion, long Ordinal )
		{
			tsa_ComprobanteDetalleOrdenReparacionDataset.tsa_ComprobanteDetalleOrdenReparacionRow row = mz.erp.dataaccess.tsa_ComprobanteDetalleOrdenReparacion.GetByPk( IdComprobante, IdOrdenReparacion, Ordinal  );
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
		/// Obtiene un registro de la tabla tsa_ComprobanteDetalleOrdenReparacion que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsa_ComprobanteDetalleOrdenReparacionDataset.tsa_ComprobanteDetalleOrdenReparacionRow GetByPk( object IdComprobante, object IdOrdenReparacion, object Ordinal )
		{
			return GetByPk( ( string )IdComprobante, ( long )IdOrdenReparacion, ( long )Ordinal );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_ComprobanteDetalleOrdenReparacionRow.
		/// </summary>
		public static tsa_ComprobanteDetalleOrdenReparacionDataset.tsa_ComprobanteDetalleOrdenReparacionRow SetRowDefaultValues( tsa_ComprobanteDetalleOrdenReparacionDataset.tsa_ComprobanteDetalleOrdenReparacionRow row )
		{
			row.IdComprobante = Util.NewStringId(); 
			row.IdOrdenReparacion = 0; 
			row.Ordinal = 0; 
			row.IdProducto = string.Empty;
			row.IdEstadoStockOrigen = string.Empty;
			row.IdEstadoStockDestino = string.Empty;
			row.IdMovimientoDeStockOrigen = string.Empty;
			row.IdMovimientoDeStockDestino = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = 0;
			row.IdEmpresa = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDetalleOrdenReparacionRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsa_ComprobanteDetalleOrdenReparacionDataset.tsa_ComprobanteDetalleOrdenReparacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDetalleOrdenReparacionRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsa_ComprobanteDetalleOrdenReparacionDataset.tsa_ComprobanteDetalleOrdenReparacionRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDetalleOrdenReparacionRow a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobanteDetalleOrdenReparacionDataset.tsa_ComprobanteDetalleOrdenReparacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComprobanteDetalleOrdenReparacion.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDetalleOrdenReparacionDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobanteDetalleOrdenReparacionDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_ComprobanteDetalleOrdenReparacion.Rows.Count > 0, "La tabla dataSet.tsa_ComprobanteDetalleOrdenReparacionDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComprobanteDetalleOrdenReparacion.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDetalleOrdenReparacionDataset.tsa_ComprobanteDetalleOrdenReparacionDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobanteDetalleOrdenReparacionDataset.tsa_ComprobanteDetalleOrdenReparacionDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComprobanteDetalleOrdenReparacion.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_ComprobanteDetalleOrdenReparacionRow.
		/// </summary>
		public static bool RowIsValid( tsa_ComprobanteDetalleOrdenReparacionDataset.tsa_ComprobanteDetalleOrdenReparacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdComprobanteIsValid( row.IdComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdComprobante" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdOrdenReparacionIsValid( row.IdOrdenReparacion, out mensaje) )
			{ 
				row.SetColumnError( "IdOrdenReparacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !OrdinalIsValid( row.Ordinal, out mensaje) )
			{ 
				row.SetColumnError( "Ordinal" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdProductoIsValid( row.IdProducto, out mensaje) )
			{ 
				row.SetColumnError( "IdProducto" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEstadoStockOrigenIsValid( row.IdEstadoStockOrigen, out mensaje) )
			{ 
				row.SetColumnError( "IdEstadoStockOrigen" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEstadoStockDestinoIsValid( row.IdEstadoStockDestino, out mensaje) )
			{ 
				row.SetColumnError( "IdEstadoStockDestino" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdMovimientoDeStockOrigenIsValid( row.IdMovimientoDeStockOrigen, out mensaje) )
			{ 
				row.SetColumnError( "IdMovimientoDeStockOrigen" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdMovimientoDeStockDestinoIsValid( row.IdMovimientoDeStockDestino, out mensaje) )
			{ 
				row.SetColumnError( "IdMovimientoDeStockDestino" , mensaje);
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
		/// Valida el campo IdOrdenReparacion.
		/// </summary>
		public static bool IdOrdenReparacionIsValid( long IdOrdenReparacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdOrdenReparacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdOrdenReparacionIsValid( long IdOrdenReparacion)
		{
			string mensaje;
			return IdOrdenReparacionIsValid( IdOrdenReparacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Ordinal.
		/// </summary>
		public static bool OrdinalIsValid( long Ordinal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Ordinal. Metodo Sobrecargado
		/// </summary>
		public static bool OrdinalIsValid( long Ordinal)
		{
			string mensaje;
			return OrdinalIsValid( Ordinal, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdProducto.
		/// </summary>
		public static bool IdProductoIsValid( string IdProducto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProducto. Metodo Sobrecargado
		/// </summary>
		public static bool IdProductoIsValid( string IdProducto)
		{
			string mensaje;
			return IdProductoIsValid( IdProducto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdEstadoStockOrigen.
		/// </summary>
		public static bool IdEstadoStockOrigenIsValid( string IdEstadoStockOrigen , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEstadoStockOrigen. Metodo Sobrecargado
		/// </summary>
		public static bool IdEstadoStockOrigenIsValid( string IdEstadoStockOrigen)
		{
			string mensaje;
			return IdEstadoStockOrigenIsValid( IdEstadoStockOrigen, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdEstadoStockDestino.
		/// </summary>
		public static bool IdEstadoStockDestinoIsValid( string IdEstadoStockDestino , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEstadoStockDestino. Metodo Sobrecargado
		/// </summary>
		public static bool IdEstadoStockDestinoIsValid( string IdEstadoStockDestino)
		{
			string mensaje;
			return IdEstadoStockDestinoIsValid( IdEstadoStockDestino, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdMovimientoDeStockOrigen.
		/// </summary>
		public static bool IdMovimientoDeStockOrigenIsValid( string IdMovimientoDeStockOrigen , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMovimientoDeStockOrigen. Metodo Sobrecargado
		/// </summary>
		public static bool IdMovimientoDeStockOrigenIsValid( string IdMovimientoDeStockOrigen)
		{
			string mensaje;
			return IdMovimientoDeStockOrigenIsValid( IdMovimientoDeStockOrigen, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdMovimientoDeStockDestino.
		/// </summary>
		public static bool IdMovimientoDeStockDestinoIsValid( string IdMovimientoDeStockDestino , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMovimientoDeStockDestino. Metodo Sobrecargado
		/// </summary>
		public static bool IdMovimientoDeStockDestinoIsValid( string IdMovimientoDeStockDestino)
		{
			string mensaje;
			return IdMovimientoDeStockDestinoIsValid( IdMovimientoDeStockDestino, out mensaje );
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


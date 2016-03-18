namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_ComprobantesDeCompraConfirmacionDePrecios : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_ComprobantesDeCompraConfirmacionDePrecios()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_ComprobantesDeCompraConfirmacionDePrecios
		/// </summary>
		public static tpu_ComprobantesDeCompraConfirmacionDePreciosDataset GetList()
		{
			return mz.erp.dataaccess.tpu_ComprobantesDeCompraConfirmacionDePrecios.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_ComprobantesDeCompraConfirmacionDePrecios filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_ComprobantesDeCompraConfirmacionDePreciosDataset GetList( string IdComprobante, string IdComprobanteFactura, string IdProveedor, string IdAutorizacion, string IdTipoDeComprobante, string Estado, string NumeroFactura, string IdResponsable, string Observaciones )
		{
			return mz.erp.dataaccess.tpu_ComprobantesDeCompraConfirmacionDePrecios.GetList( IdComprobante, IdComprobanteFactura, IdProveedor, IdAutorizacion, IdTipoDeComprobante, Estado, NumeroFactura, IdResponsable, Observaciones );
		}

		/// <summary>
		/// Crea un tpu_ComprobantesDeCompraConfirmacionDePreciosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tpu_ComprobantesDeCompraConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraConfirmacionDePreciosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tpu_ComprobantesDeCompraConfirmacionDePrecios.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_ComprobantesDeCompraConfirmacionDePrecios que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_ComprobantesDeCompraConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraConfirmacionDePreciosRow GetByPk( string IdComprobante )
		{
			tpu_ComprobantesDeCompraConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraConfirmacionDePreciosRow row = mz.erp.dataaccess.tpu_ComprobantesDeCompraConfirmacionDePrecios.GetByPk( IdComprobante  );
			if(row != null)
			{
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
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_ComprobantesDeCompraConfirmacionDePrecios que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tpu_ComprobantesDeCompraConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraConfirmacionDePreciosRow GetByPk( object IdComprobante )
		{
			return GetByPk( ( string )IdComprobante );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_ComprobantesDeCompraConfirmacionDePreciosRow.
		/// </summary>
		public static tpu_ComprobantesDeCompraConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraConfirmacionDePreciosRow SetRowDefaultValues( tpu_ComprobantesDeCompraConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraConfirmacionDePreciosRow row )
		{
			row.IdComprobante = Util.NewStringId(); 
			row.IdComprobanteFactura = string.Empty;
			row.IdProveedor = string.Empty;
			row.IdAutorizacion = string.Empty;
			row.IdTipoDeComprobante = string.Empty;
			row.Estado = string.Empty;
			row.NumeroFactura = string.Empty;
			row.IdResponsable = string.Empty;
			row.Observaciones = string.Empty;
			row.IdMonedaOriginal = string.Empty;
			row.IdFuenteDeCambioOriginal = string.Empty;
			row.IdCotizacionOriginal = string.Empty;
			row.ValorCotizacionOriginal = 0;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = Security.IdSucursal;
			row.IdEmpresa = Security.IdEmpresa;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesDeCompraConfirmacionDePreciosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tpu_ComprobantesDeCompraConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraConfirmacionDePreciosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesDeCompraConfirmacionDePreciosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tpu_ComprobantesDeCompraConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraConfirmacionDePreciosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesDeCompraConfirmacionDePreciosRow a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesDeCompraConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraConfirmacionDePreciosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ComprobantesDeCompraConfirmacionDePrecios.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_ComprobantesDeCompraConfirmacionDePreciosDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesDeCompraConfirmacionDePreciosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_ComprobantesDeCompraConfirmacionDePrecios.Rows.Count > 0, "La tabla dataSet.tpu_ComprobantesDeCompraConfirmacionDePreciosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ComprobantesDeCompraConfirmacionDePrecios.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesDeCompraConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraConfirmacionDePreciosDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesDeCompraConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraConfirmacionDePreciosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ComprobantesDeCompraConfirmacionDePrecios.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_ComprobantesDeCompraConfirmacionDePreciosRow.
		/// </summary>
		public static bool RowIsValid( tpu_ComprobantesDeCompraConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraConfirmacionDePreciosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdComprobanteIsValid( row.IdComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdComprobante" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdComprobanteFacturaIsValid( row.IdComprobanteFactura, out mensaje) )
			{ 
				row.SetColumnError( "IdComprobanteFactura" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdProveedorIsValid( row.IdProveedor, out mensaje) )
			{ 
				row.SetColumnError( "IdProveedor" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdAutorizacionIsValid( row.IdAutorizacion, out mensaje) )
			{ 
				row.SetColumnError( "IdAutorizacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTipoDeComprobanteIsValid( row.IdTipoDeComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoDeComprobante" , mensaje);
				isValid=false;
			
			}
						
			if ( !EstadoIsValid( row.Estado, out mensaje) )
			{ 
				row.SetColumnError( "Estado" , mensaje);
				isValid=false;
			
			}
						
			if ( !NumeroFacturaIsValid( row.NumeroFactura, out mensaje) )
			{ 
				row.SetColumnError( "NumeroFactura" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdResponsableIsValid( row.IdResponsable, out mensaje) )
			{ 
				row.SetColumnError( "IdResponsable" , mensaje);
				isValid=false;
			
			}
						
			if ( !ObservacionesIsValid( row.Observaciones, out mensaje) )
			{ 
				row.SetColumnError( "Observaciones" , mensaje);
				isValid=false;
			
			}
						
			
						
			if ( !IdMonedaOriginalIsValid( row.IdMonedaOriginal, out mensaje) )
			{ 
				row.SetColumnError( "IdMonedaOriginal" , mensaje);
				isValid=false;
			
			}
						
			
						
			if ( !IdFuenteDeCambioOriginalIsValid( row.IdFuenteDeCambioOriginal, out mensaje) )
			{ 
				row.SetColumnError( "IdFuenteDeCambioOriginal" , mensaje);
				isValid=false;
			
			}
						
			
						
			if ( !IdCotizacionOrigenIsValid( row.IdCotizacionOriginal, out mensaje) )
			{ 
				row.SetColumnError( "IdCotizacionOrigen" , mensaje);
				isValid=false;
			
			}
						
			
						
			if ( !ValorCotizacionOrigenIsValid( row.ValorCotizacionOriginal, out mensaje) )
			{ 
				row.SetColumnError( "ValorCotizacionOrigen" , mensaje);
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
				/*		
			if ( !UltimaModificacionIsValid( row.UltimaModificacion, out mensaje) )
			{ 
				row.SetColumnError( "UltimaModificacion" , mensaje);
				isValid=false;
			
			}
					*/	
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
		/// Valida el campo IdComprobanteFactura.
		/// </summary>
		public static bool IdComprobanteFacturaIsValid( string IdComprobanteFactura , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdComprobanteFactura. Metodo Sobrecargado
		/// </summary>
		public static bool IdComprobanteFacturaIsValid( string IdComprobanteFactura)
		{
			string mensaje;
			return IdComprobanteFacturaIsValid( IdComprobanteFactura, out mensaje );
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
		/// Valida el campo IdAutorizacion.
		/// </summary>
		public static bool IdAutorizacionIsValid( string IdAutorizacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdAutorizacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdAutorizacionIsValid( string IdAutorizacion)
		{
			string mensaje;
			return IdAutorizacionIsValid( IdAutorizacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTipoDeComprobante.
		/// </summary>
		public static bool IdTipoDeComprobanteIsValid( string IdTipoDeComprobante , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoDeComprobante. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoDeComprobanteIsValid( string IdTipoDeComprobante)
		{
			string mensaje;
			return IdTipoDeComprobanteIsValid( IdTipoDeComprobante, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Estado.
		/// </summary>
		public static bool EstadoIsValid( string Estado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Estado. Metodo Sobrecargado
		/// </summary>
		public static bool EstadoIsValid( string Estado)
		{
			string mensaje;
			return EstadoIsValid( Estado, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo NumeroFactura.
		/// </summary>
		public static bool NumeroFacturaIsValid( string NumeroFactura , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo NumeroFactura. Metodo Sobrecargado
		/// </summary>
		public static bool NumeroFacturaIsValid( string NumeroFactura)
		{
			string mensaje;
			return NumeroFacturaIsValid( NumeroFactura, out mensaje );
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
		/// Valida el campo IdMoneda.
		/// </summary>
		public static bool IdMonedaIsValid( string IdMoneda , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMoneda. Metodo Sobrecargado
		/// </summary>
		public static bool IdMonedaIsValid( string IdMoneda)
		{
			string mensaje;
			return IdMonedaIsValid( IdMoneda, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdMonedaOriginal.
		/// </summary>
		public static bool IdMonedaOriginalIsValid( string IdMonedaOriginal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMonedaOriginal. Metodo Sobrecargado
		/// </summary>
		public static bool IdMonedaOriginalIsValid( string IdMonedaOriginal)
		{
			string mensaje;
			return IdMonedaOriginalIsValid( IdMonedaOriginal, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdFuenteDeCambio.
		/// </summary>
		public static bool IdFuenteDeCambioIsValid( string IdFuenteDeCambio , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdFuenteDeCambio. Metodo Sobrecargado
		/// </summary>
		public static bool IdFuenteDeCambioIsValid( string IdFuenteDeCambio)
		{
			string mensaje;
			return IdFuenteDeCambioIsValid( IdFuenteDeCambio, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdFuenteDeCambioOriginal.
		/// </summary>
		public static bool IdFuenteDeCambioOriginalIsValid( string IdFuenteDeCambioOriginal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdFuenteDeCambioOriginal. Metodo Sobrecargado
		/// </summary>
		public static bool IdFuenteDeCambioOriginalIsValid( string IdFuenteDeCambioOriginal)
		{
			string mensaje;
			return IdFuenteDeCambioOriginalIsValid( IdFuenteDeCambioOriginal, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCotizacion.
		/// </summary>
		public static bool IdCotizacionIsValid( string IdCotizacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCotizacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdCotizacionIsValid( string IdCotizacion)
		{
			string mensaje;
			return IdCotizacionIsValid( IdCotizacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCotizacionOrigen.
		/// </summary>
		public static bool IdCotizacionOrigenIsValid( string IdCotizacionOrigen , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCotizacionOrigen. Metodo Sobrecargado
		/// </summary>
		public static bool IdCotizacionOrigenIsValid( string IdCotizacionOrigen)
		{
			string mensaje;
			return IdCotizacionOrigenIsValid( IdCotizacionOrigen, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo ValorCotizacion.
		/// </summary>
		public static bool ValorCotizacionIsValid( decimal ValorCotizacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ValorCotizacion. Metodo Sobrecargado
		/// </summary>
		public static bool ValorCotizacionIsValid( decimal ValorCotizacion)
		{
			string mensaje;
			return ValorCotizacionIsValid( ValorCotizacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo ValorCotizacionOrigen.
		/// </summary>
		public static bool ValorCotizacionOrigenIsValid( decimal ValorCotizacionOrigen , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ValorCotizacionOrigen. Metodo Sobrecargado
		/// </summary>
		public static bool ValorCotizacionOrigenIsValid( decimal ValorCotizacionOrigen)
		{
			string mensaje;
			return ValorCotizacionOrigenIsValid( ValorCotizacionOrigen, out mensaje );
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


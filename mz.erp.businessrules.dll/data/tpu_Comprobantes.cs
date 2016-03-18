using System;
using System.Data;
using System.Text.RegularExpressions;
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.dataaccess;


namespace mz.erp.businessrules
{
	
	public class tpu_Comprobantes : IDisposable
	{
	
		#region Custom Members
		/// <summary>
		/// Establece los valores por defecto de tpu_ComprobantesRow.
		/// </summary>
		/// 

		public static DataSet GetMovimientosNumeroDeSeriePendientes(string IdComprobanteDestino, string IdEstadoDeStock)
		{
			return mz.erp.dataaccess.tpu_Comprobantes.GetMovimientosNumeroDeSeriePendientes(IdComprobanteDestino, IdEstadoDeStock);
		}
		public static tpu_ComprobantesDataset.tpu_ComprobantesRow SetRowDefaultValues( tpu_ComprobantesDataset.tpu_ComprobantesRow row )
		{
			row.IdComprobante = Util.NewStringId(); 
			row.IdSucursal = 0;
			row.IdEmpresa = 0;
			row.IdInstanciaCaja = string.Empty;
			row.IdTipoDeComprobante = string.Empty;
			row.Numero = string.Empty;
			row.Fecha = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdProveedor = string.Empty;
			row.IdResponsable = string.Empty;
			row.Total = 0;
			row.IdCotizacionCierre = string.Empty;
			row.IdMonedaCierre = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			//row.RowId = Guid.Empty;
			row.Proveedor = string.Empty;
			row.Domicilio = string.Empty;
			row.TipoDocumento = string.Empty;
			row.Documento = string.Empty;
			row.Observaciones = string.Empty;
			row.Aux1 = string.Empty;
			row.Aux2 = string.Empty;
			row.Aux3 = string.Empty;
			row.Aux4 = 0;
			row.FechaDeRegistracion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.FechaRecepcionMercaderia = mz.erp.businessrules.Sistema.DateTime.Now;
			row.Estado = string.Empty;
			row.IdCondicionDeCompra = string.Empty;
			row.IdAutorizacion = string.Empty;
			

			return row;
		}

		public static bool ExistsNumeration(string numero, string tipoDeComprobante, string idProveedor)
		{
			return mz.erp.dataaccess.tpu_Comprobantes.ExistsNumeration(numero, tipoDeComprobante, idProveedor);
		}

		public static bool ExistsNumeroFactura(string numero, string tipoDeComprobante, string idProveedor)
		{
			return mz.erp.dataaccess.tpu_Comprobantes.ExistsNumeroFactura(numero, tipoDeComprobante, idProveedor);
		}



		#endregion
		
		public tpu_Comprobantes()
		{
		}


		public static tpu_ComprobantesDataset GetList(  )
		{
			return mz.erp.dataaccess.tpu_Comprobantes.GetList(  );
		}

		public static DataTable GetListByNroYTipoComprobante( string nroComprobante, string idTipoComprobante )
		{
			return mz.erp.dataaccess.tpu_Comprobantes.GetListByNroYTipoComprobante(nroComprobante, idTipoComprobante);
		}


		/// <summary>
		/// Crea un tpu_ComprobantesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tpu_ComprobantesDataset.tpu_ComprobantesRow NewRow()
		{
			return (tpu_ComprobantesDataset.tpu_ComprobantesRow )SetRowDefaultValues(mz.erp.dataaccess.tpu_Comprobantes.NewRow());
		}


		/// <summary>
		/// Obtiene un registro de la tabla tpu_Comprobantes que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_ComprobantesDataset.tpu_ComprobantesRow GetByPk( string IdComprobante )
		{
			tpu_ComprobantesDataset.tpu_ComprobantesRow row = mz.erp.dataaccess.tpu_Comprobantes.GetByPk( IdComprobante  );
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
		/// Obtiene un registro de la tabla tpu_Comprobantes que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tpu_ComprobantesDataset.tpu_ComprobantesRow GetByPk( object IdComprobante )
		{
			return GetByPk( ( string )IdComprobante );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_ComprobantesRow.
		/// </summary>
		
		public static void UpdateIdTipoDeComprobante(string IdTransaction, string IdComprobante, string IdTipoDeComprobante)
		{
			mz.erp.dataaccess.tpu_Comprobantes.UpdateIdTipoDeComprobante(IdTransaction, IdComprobante, IdTipoDeComprobante);
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tpu_ComprobantesDataset.tpu_ComprobantesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tpu_ComprobantesDataset.tpu_ComprobantesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesRow a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesDataset.tpu_ComprobantesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_Comprobantes.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_ComprobantesDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_Comprobantes.Rows.Count > 0, "La tabla dataSet.tpu_ComprobantesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_Comprobantes.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesDataset.tpu_ComprobantesDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesDataset.tpu_ComprobantesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_Comprobantes.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_ComprobantesRow.
		/// </summary>
		public static bool RowIsValid( tpu_ComprobantesDataset.tpu_ComprobantesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdComprobanteIsValid( row.IdComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdComprobante" , mensaje);
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
						
			if ( !IdInstanciaCajaIsValid( row.IdInstanciaCaja, out mensaje) )
			{ 
				row.SetColumnError( "IdInstanciaCaja" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTipoDeComprobanteIsValid( row.IdTipoDeComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoDeComprobante" , mensaje);
				isValid=false;
			
			}
						
			if ( !NumeroIsValid( row.Numero, out mensaje) )
			{ 
				row.SetColumnError( "Numero" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaIsValid( row.Fecha, out mensaje) )
			{ 
				row.SetColumnError( "Fecha" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdProveedorIsValid( row.IdProveedor, out mensaje) )
			{ 
				row.SetColumnError( "IdProveedor" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdResponsableIsValid( row.IdResponsable, out mensaje) )
			{ 
				row.SetColumnError( "IdResponsable" , mensaje);
				isValid=false;
			
			}
						
			if ( !TotalIsValid( row.Total, out mensaje) )
			{ 
				row.SetColumnError( "Total" , mensaje);
				isValid=false;
			
			}
						
						
			if ( !IdMonedaCierreIsValid( row.IdMonedaCierre, out mensaje) )
			{ 
				row.SetColumnError( "IdMonedaCierre" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCotizacionCierreIsValid( row.IdCotizacionCierre, out mensaje) )
			{ 
				row.SetColumnError( "IdCotizacionCierre" , mensaje);
				isValid=false;
			
			}
			if ( !FechaRecepcionMercaderiaIsValid( row.FechaRecepcionMercaderia, out mensaje) )
			{ 
				row.SetColumnError( "FechaRecepcionMercaderia" , mensaje);
				isValid=false;
			
			}
			/*			
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
			;*/
			
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
		
		/// <summary>
		/// Valida el campo IdInstanciaCaja.
		/// </summary>
		public static bool IdInstanciaCajaIsValid( string IdInstanciaCaja , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdInstanciaCaja. Metodo Sobrecargado
		/// </summary>
		public static bool IdInstanciaCajaIsValid( string IdInstanciaCaja)
		{
			string mensaje;
			return IdInstanciaCajaIsValid( IdInstanciaCaja, out mensaje );
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
		/// Valida el campo Numero.
		/// </summary>
		public static bool NumeroIsValid( string Numero , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Numero. Metodo Sobrecargado
		/// </summary>
		public static bool NumeroIsValid( string Numero)
		{
			string mensaje;
			return NumeroIsValid( Numero, out mensaje );
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
		/// Valida el campo Total.
		/// </summary>
		public static bool TotalIsValid( decimal Total , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Total. Metodo Sobrecargado
		/// </summary>
		public static bool TotalIsValid( decimal Total)
		{
			string mensaje;
			return TotalIsValid( Total, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo TotalConImpuestos.
		/// </summary>
		public static bool TotalConImpuestosIsValid( decimal TotalConImpuestos , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo TotalConImpuestos. Metodo Sobrecargado
		/// </summary>
		public static bool TotalConImpuestosIsValid( decimal TotalConImpuestos)
		{
			string mensaje;
			return TotalConImpuestosIsValid( TotalConImpuestos, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdMonedaCierre.
		/// </summary>
		public static bool IdMonedaCierreIsValid( string IdMonedaCierre , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMonedaCierre. Metodo Sobrecargado
		/// </summary>
		public static bool IdMonedaCierreIsValid( string IdMonedaCierre)
		{
			string mensaje;
			return IdMonedaCierreIsValid( IdMonedaCierre, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCotizacionCierre.
		/// </summary>
		public static bool IdCotizacionCierreIsValid( string IdCotizacionCierre , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCotizacionCierre. Metodo Sobrecargado
		/// </summary>
		public static bool IdCotizacionCierreIsValid( string IdCotizacionCierre)
		{
			string mensaje;
			return IdCotizacionCierreIsValid( IdCotizacionCierre, out mensaje );
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
		/// Valida el campo FechaRecepcionMercaderia.
		/// </summary>
		public static bool FechaRecepcionMercaderiaIsValid( DateTime FechaRecepcionMercaderia , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaRecepcionMercaderia. Metodo Sobrecargado
		/// </summary>
		public static bool FechaRecepcionMercaderiaIsValid( DateTime FechaRecepcionMercaderia)
		{
			string mensaje;
			return FechaRecepcionMercaderiaIsValid( FechaRecepcionMercaderia, out mensaje );
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
		

		public void Dispose()
		{
		}
		
	}
}

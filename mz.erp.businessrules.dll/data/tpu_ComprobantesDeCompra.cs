namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_ComprobantesDeCompra : IDisposable
	{
	
		#region Custom Members

		public static void Update( tpu_ComprobantesDeCompraDataset.tpu_ComprobantesDeCompraDataTable dataTable, string IdTransaction )
		{						
			mz.erp.dataaccess.tpu_ComprobantesDeCompra.Update(dataTable, IdTransaction);
		}

		public static System.Data.DataSet GetSinAutorizar( string tiposComprobantesOrigen, string IdProveedor, DateTime EmisionDesde, DateTime EmisionHasta, DateTime VencimientoDesde, DateTime VencimientoHasta, DateTime RecepcionDesde, DateTime RecepcionHasta, string IdResponsable, long IdSucursal, long IdEmpresa, bool VerHTML, string IdCuentaImputacion, string IdSubCuentaImputacion)
		{
			return  mz.erp.dataaccess.tpu_ComprobantesEx.GetSinAutorizar( tiposComprobantesOrigen, IdProveedor, EmisionDesde, EmisionHasta, VencimientoDesde, VencimientoHasta, RecepcionDesde, RecepcionHasta, IdResponsable, IdSucursal, IdEmpresa, VerHTML, IdCuentaImputacion, IdSubCuentaImputacion);
		}

		#endregion
		
		public tpu_ComprobantesDeCompra()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_ComprobantesDeCompra
		/// </summary>
		public static tpu_ComprobantesDeCompraDataset GetList()
		{
			return mz.erp.dataaccess.tpu_ComprobantesDeCompra.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_ComprobantesDeCompra filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_ComprobantesDeCompraDataset GetList( string IdComprobante, string IdTipoDeComprobante, string Numero, DateTime Fecha, string IdProveedor, string IdResponsable, DateTime FechaDeRegistracion, string IdTipoMovimiento, string IdSubtipoMovimiento, DateTime FechaVencimiento, long MesImputacion, long AñoImputacion/*, DateTime FechaRecepcionMercaderia*/, string CAI, string Leyenda )
		{
			return mz.erp.dataaccess.tpu_ComprobantesDeCompra.GetList( IdComprobante, IdTipoDeComprobante, Numero, Fecha, IdProveedor, IdResponsable, FechaDeRegistracion, IdTipoMovimiento, IdSubtipoMovimiento, FechaVencimiento, MesImputacion,  AñoImputacion, /*, FechaRecepcionMercaderia,*/ CAI, Leyenda );
		}



		/// <summary>
		/// Crea un tpu_ComprobantesDeCompraRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tpu_ComprobantesDeCompraDataset.tpu_ComprobantesDeCompraRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tpu_ComprobantesDeCompra.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_ComprobantesDeCompra que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_ComprobantesDeCompraDataset.tpu_ComprobantesDeCompraRow GetByPk( string IdComprobante )
		{
			tpu_ComprobantesDeCompraDataset.tpu_ComprobantesDeCompraRow row = mz.erp.dataaccess.tpu_ComprobantesDeCompra.GetByPk( IdComprobante  );
			if (row != null)
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if (row[dc] == System.DBNull.Value)
					{
						row[dc] = Util.DefaultValue( dc.DataType );
					}
				}
				return row;
			}
			return null;			
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_ComprobantesDeCompra que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tpu_ComprobantesDeCompraDataset.tpu_ComprobantesDeCompraRow GetByPk( object IdComprobante )
		{
			return GetByPk( ( string )IdComprobante );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_ComprobantesDeCompraRow.
		/// </summary>
		public static tpu_ComprobantesDeCompraDataset.tpu_ComprobantesDeCompraRow SetRowDefaultValues( tpu_ComprobantesDeCompraDataset.tpu_ComprobantesDeCompraRow row )
		{
			row.IdComprobante = Util.NewStringId(); 
			row.IdTipoDeComprobante = string.Empty;
			row.Numero = string.Empty;
			row.Fecha = DateTime.Now;
			row.IdProveedor = string.Empty;
			row.IdResponsable = string.Empty;
			row.IdMonedaCierre = string.Empty;
			row.FechaDeRegistracion = DateTime.Now;
			row.ValorCotizacionProveedor = 0;
			row.IdTipoMovimiento = string.Empty;
			row.IdSubtipoMovimiento = string.Empty;
			row.FechaVencimiento = DateTime.Now;
			row.MesImputacion = 0;
			row.AñoImputacion = 0;
			row.CAI = string.Empty;
			row.Leyenda = string.Empty;
			row.NetoGravado = 0;
			row.GastoGravado = 0;
			row.ServicioGravado = 0;
			row.MontoNoGravado = 0;
			row.NetoBruto = 0;
			row.Descuento = 0;
			row.SubtotalNeto = 0;
			row.IvaInscripto1 = 0;
			row.IvaInscripto2 = 0;
			row.IvaInscripto3 = 0;
			row.PercepcionIB = 0;
			row.PercepcionGanancias = 0;
			row.PercepcionIVA = 0;
			row.ImpuestosInternos = 0;
			row.TotalGeneral = 0;
			row.DescuentoGeneral = 0;
			row.Total = 0;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = 0;
			row.IdEmpresa = 0;
			row.AñoDevengamiento = 0;
			row.MesDevengamiento = 0;
			row.Autorizada = true;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesDeCompraRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tpu_ComprobantesDeCompraDataset.tpu_ComprobantesDeCompraRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesDeCompraRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tpu_ComprobantesDeCompraDataset.tpu_ComprobantesDeCompraRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesDeCompraRow a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesDeCompraDataset.tpu_ComprobantesDeCompraRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ComprobantesDeCompra.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_ComprobantesDeCompraDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesDeCompraDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_ComprobantesDeCompra.Rows.Count > 0, "La tabla dataSet.tpu_ComprobantesDeCompraDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ComprobantesDeCompra.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesDeCompraDataset.tpu_ComprobantesDeCompraDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesDeCompraDataset.tpu_ComprobantesDeCompraDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ComprobantesDeCompra.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_ComprobantesDeCompraRow.
		/// </summary>
		public static bool RowIsValid( tpu_ComprobantesDeCompraDataset.tpu_ComprobantesDeCompraRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdComprobanteIsValid( row.IdComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdComprobante" , mensaje);
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
						
			if ( !IdMonedaCierreIsValid( row.IdMonedaCierre, out mensaje) )
			{ 
				row.SetColumnError( "IdMonedaCierre" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaDeRegistracionIsValid( row.FechaDeRegistracion, out mensaje) )
			{ 
				row.SetColumnError( "FechaDeRegistracion" , mensaje);
				isValid=false;
			
			}
						
			if ( !ValorCotizacionProveedorIsValid( row.ValorCotizacionProveedor, out mensaje) )
			{ 
				row.SetColumnError( "ValorCotizacionProveedor" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTipoMovimientoIsValid( row.IdTipoMovimiento, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoMovimiento" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdSubtipoMovimientoIsValid( row.IdSubtipoMovimiento, out mensaje) )
			{ 
				row.SetColumnError( "IdSubtipoMovimiento" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaVencimientoIsValid( row.FechaVencimiento, out mensaje) )
			{ 
				row.SetColumnError( "FechaVencimiento" , mensaje);
				isValid=false;
			
			}
						
			if ( !MesImputacionIsValid( row.MesImputacion, out mensaje) )
			{ 
				row.SetColumnError( "MesImputacion" , mensaje);
				isValid=false;
			
			}
						
			
						
			if ( !CAIIsValid( row.CAI, out mensaje) )
			{ 
				row.SetColumnError( "CAI" , mensaje);
				isValid=false;
			
			}
						
			if ( !LeyendaIsValid( row.Leyenda, out mensaje) )
			{ 
				row.SetColumnError( "Leyenda" , mensaje);
				isValid=false;
			
			}
						
			if ( !NetoGravadoIsValid( row.NetoGravado, out mensaje) )
			{ 
				row.SetColumnError( "NetoGravado" , mensaje);
				isValid=false;
			
			}
						
			if ( !GastosGravadoIsValid( row.GastoGravado, out mensaje) )
			{ 
				row.SetColumnError( "GastoGravado" , mensaje);
				isValid=false;
			
			}
						
			if ( !ServiciosGravadoIsValid( row.ServicioGravado, out mensaje) )
			{ 
				row.SetColumnError( "ServicioGravado" , mensaje);
				isValid=false;
			
			}
						
			if ( !MontosNoGravadosIsValid( row.MontoNoGravado, out mensaje) )
			{ 
				row.SetColumnError( "MontoNoGravado" , mensaje);
				isValid=false;
			
			}
						
			if ( !NetoBrutoIsValid( row.NetoBruto, out mensaje) )
			{ 
				row.SetColumnError( "NetoBruto" , mensaje);
				isValid=false;
			
			}
						
			if ( !DecuentoIsValid( row.Descuento, out mensaje) )
			{ 
				row.SetColumnError( "Descuento" , mensaje);
				isValid=false;
			
			}
						
			if ( !SubtotalNetoIsValid( row.SubtotalNeto, out mensaje) )
			{ 
				row.SetColumnError( "SubtotalNeto" , mensaje);
				isValid=false;
			
			}
						
			if ( !IvaInscriptoIsValid( row.IvaInscripto1, out mensaje) )
			{ 
				row.SetColumnError( "IvaInscripto1" , mensaje);
				isValid=false;
			
			}
						
			if ( !PrecepcionIBIsValid( row.PercepcionIB, out mensaje) )
			{ 
				row.SetColumnError( "PercepcionIB" , mensaje);
				isValid=false;
			
			}
						
			if ( !PercepcionGananciasIsValid( row.PercepcionGanancias, out mensaje) )
			{ 
				row.SetColumnError( "PercepcionGanancias" , mensaje);
				isValid=false;
			
			}
						
			if ( !PercepcionIVAIsValid( row.PercepcionIVA, out mensaje) )
			{ 
				row.SetColumnError( "PercepcionIVA" , mensaje);
				isValid=false;
			
			}
						
			if ( !ImpuestosInternosIsValid( row.ImpuestosInternos, out mensaje) )
			{ 
				row.SetColumnError( "ImpuestosInternos" , mensaje);
				isValid=false;
			
			}
						
			if ( !TotalGeneralIsValid( row.TotalGeneral, out mensaje) )
			{ 
				row.SetColumnError( "TotalGeneral" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescuentoGeneralIsValid( row.DescuentoGeneral, out mensaje) )
			{ 
				row.SetColumnError( "DescuentoGeneral" , mensaje);
				isValid=false;
			
			}
						
			if ( !TotalIsValid( row.Total, out mensaje) )
			{ 
				row.SetColumnError( "Total" , mensaje);
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
		/// Valida el campo FechaDeRegistracion.
		/// </summary>
		public static bool FechaDeRegistracionIsValid( DateTime FechaDeRegistracion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaDeRegistracion. Metodo Sobrecargado
		/// </summary>
		public static bool FechaDeRegistracionIsValid( DateTime FechaDeRegistracion)
		{
			string mensaje;
			return FechaDeRegistracionIsValid( FechaDeRegistracion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo ValorCotizacionProveedor.
		/// </summary>
		public static bool ValorCotizacionProveedorIsValid( decimal ValorCotizacionProveedor , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ValorCotizacionProveedor. Metodo Sobrecargado
		/// </summary>
		public static bool ValorCotizacionProveedorIsValid( decimal ValorCotizacionProveedor)
		{
			string mensaje;
			return ValorCotizacionProveedorIsValid( ValorCotizacionProveedor, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTipoMovimiento.
		/// </summary>
		public static bool IdTipoMovimientoIsValid( string IdTipoMovimiento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoMovimiento. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoMovimientoIsValid( string IdTipoMovimiento)
		{
			string mensaje;
			return IdTipoMovimientoIsValid( IdTipoMovimiento, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdSubtipoMovimiento.
		/// </summary>
		public static bool IdSubtipoMovimientoIsValid( string IdSubtipoMovimiento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSubtipoMovimiento. Metodo Sobrecargado
		/// </summary>
		public static bool IdSubtipoMovimientoIsValid( string IdSubtipoMovimiento)
		{
			string mensaje;
			return IdSubtipoMovimientoIsValid( IdSubtipoMovimiento, out mensaje );
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
		/// Valida el campo MesImputacion.
		/// </summary>
		public static bool MesImputacionIsValid( long MesImputacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo MesImputacion. Metodo Sobrecargado
		/// </summary>
		public static bool MesImputacionIsValid( long MesImputacion)
		{
			string mensaje;
			return MesImputacionIsValid( MesImputacion, out mensaje );
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
		/// Valida el campo CAI.
		/// </summary>
		public static bool CAIIsValid( string CAI , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CAI. Metodo Sobrecargado
		/// </summary>
		public static bool CAIIsValid( string CAI)
		{
			string mensaje;
			return CAIIsValid( CAI, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Leyenda.
		/// </summary>
		public static bool LeyendaIsValid( string Leyenda , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Leyenda. Metodo Sobrecargado
		/// </summary>
		public static bool LeyendaIsValid( string Leyenda)
		{
			string mensaje;
			return LeyendaIsValid( Leyenda, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo NetoGravado.
		/// </summary>
		public static bool NetoGravadoIsValid( decimal NetoGravado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo NetoGravado. Metodo Sobrecargado
		/// </summary>
		public static bool NetoGravadoIsValid( decimal NetoGravado)
		{
			string mensaje;
			return NetoGravadoIsValid( NetoGravado, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo GastosGravado.
		/// </summary>
		public static bool GastosGravadoIsValid( decimal GastosGravado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo GastosGravado. Metodo Sobrecargado
		/// </summary>
		public static bool GastosGravadoIsValid( decimal GastosGravado)
		{
			string mensaje;
			return GastosGravadoIsValid( GastosGravado, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo ServiciosGravado.
		/// </summary>
		public static bool ServiciosGravadoIsValid( decimal ServiciosGravado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ServiciosGravado. Metodo Sobrecargado
		/// </summary>
		public static bool ServiciosGravadoIsValid( decimal ServiciosGravado)
		{
			string mensaje;
			return ServiciosGravadoIsValid( ServiciosGravado, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo MontosNoGravados.
		/// </summary>
		public static bool MontosNoGravadosIsValid( decimal MontosNoGravados , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo MontosNoGravados. Metodo Sobrecargado
		/// </summary>
		public static bool MontosNoGravadosIsValid( decimal MontosNoGravados)
		{
			string mensaje;
			return MontosNoGravadosIsValid( MontosNoGravados, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo NetoBruto.
		/// </summary>
		public static bool NetoBrutoIsValid( decimal NetoBruto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo NetoBruto. Metodo Sobrecargado
		/// </summary>
		public static bool NetoBrutoIsValid( decimal NetoBruto)
		{
			string mensaje;
			return NetoBrutoIsValid( NetoBruto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Decuento.
		/// </summary>
		public static bool DecuentoIsValid( decimal Decuento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Decuento. Metodo Sobrecargado
		/// </summary>
		public static bool DecuentoIsValid( decimal Decuento)
		{
			string mensaje;
			return DecuentoIsValid( Decuento, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo SubtotalNeto.
		/// </summary>
		public static bool SubtotalNetoIsValid( decimal SubtotalNeto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo SubtotalNeto. Metodo Sobrecargado
		/// </summary>
		public static bool SubtotalNetoIsValid( decimal SubtotalNeto)
		{
			string mensaje;
			return SubtotalNetoIsValid( SubtotalNeto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IvaInscripto.
		/// </summary>
		public static bool IvaInscriptoIsValid( decimal IvaInscripto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IvaInscripto. Metodo Sobrecargado
		/// </summary>
		public static bool IvaInscriptoIsValid( decimal IvaInscripto)
		{
			string mensaje;
			return IvaInscriptoIsValid( IvaInscripto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo PrecepcionIB.
		/// </summary>
		public static bool PrecepcionIBIsValid( decimal PrecepcionIB , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo PrecepcionIB. Metodo Sobrecargado
		/// </summary>
		public static bool PrecepcionIBIsValid( decimal PrecepcionIB)
		{
			string mensaje;
			return PrecepcionIBIsValid( PrecepcionIB, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo PercepcionGanancias.
		/// </summary>
		public static bool PercepcionGananciasIsValid( decimal PercepcionGanancias , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo PercepcionGanancias. Metodo Sobrecargado
		/// </summary>
		public static bool PercepcionGananciasIsValid( decimal PercepcionGanancias)
		{
			string mensaje;
			return PercepcionGananciasIsValid( PercepcionGanancias, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo PercepcionIVA.
		/// </summary>
		public static bool PercepcionIVAIsValid( decimal PercepcionIVA , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo PercepcionIVA. Metodo Sobrecargado
		/// </summary>
		public static bool PercepcionIVAIsValid( decimal PercepcionIVA)
		{
			string mensaje;
			return PercepcionIVAIsValid( PercepcionIVA, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo ImpuestosInternos.
		/// </summary>
		public static bool ImpuestosInternosIsValid( decimal ImpuestosInternos , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ImpuestosInternos. Metodo Sobrecargado
		/// </summary>
		public static bool ImpuestosInternosIsValid( decimal ImpuestosInternos)
		{
			string mensaje;
			return ImpuestosInternosIsValid( ImpuestosInternos, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo TotalGeneral.
		/// </summary>
		public static bool TotalGeneralIsValid( decimal TotalGeneral , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo TotalGeneral. Metodo Sobrecargado
		/// </summary>
		public static bool TotalGeneralIsValid( decimal TotalGeneral)
		{
			string mensaje;
			return TotalGeneralIsValid( TotalGeneral, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo DescuentoGeneral.
		/// </summary>
		public static bool DescuentoGeneralIsValid( decimal DescuentoGeneral , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo DescuentoGeneral. Metodo Sobrecargado
		/// </summary>
		public static bool DescuentoGeneralIsValid( decimal DescuentoGeneral)
		{
			string mensaje;
			return DescuentoGeneralIsValid( DescuentoGeneral, out mensaje );
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


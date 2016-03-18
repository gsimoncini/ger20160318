namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_ComprobantesDet : IDisposable
	{
	
		#region Custom Members
		public static tsa_ComprobantesDetDataset GetByPk( string IdComprobante) 
		{
			/*
			DateTime Fecha = DateTime.MinValue;
			string Numero = null;
			string IdProducto = null;
			long Ordinal = long.MinValue;
			*/
			return dataaccess.tsa_ComprobantesDet.GetListByPk(IdComprobante);
		}
		
		#endregion
		
		public tsa_ComprobantesDet()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_ComprobantesDet
		/// </summary>
		public static tsa_ComprobantesDetDataset GetList()
		{
			return mz.erp.dataaccess.tsa_ComprobantesDet.GetList();
		}

		/// <summary>
		/// Obtiene tabla tsa_ComprobantesDet filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_ComprobantesDetDataset GetList( string IdComprobante, DateTime Fecha, string Numero, string IdProducto, long Ordinal)
		{
			return mz.erp.dataaccess.tsa_ComprobantesDet.GetList( IdComprobante, Fecha, Numero, IdProducto, Ordinal) ;
		}

		/// <summary>
		/// Crea un tsa_ComprobantesDetRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsa_ComprobantesDetDataset.tsa_ComprobantesDetRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsa_ComprobantesDet.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_ComprobantesDet que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_ComprobantesDetDataset.tsa_ComprobantesDetRow GetByPk( string IdComprobante, long Ordinal )
		{
			tsa_ComprobantesDetDataset.tsa_ComprobantesDetRow row = mz.erp.dataaccess.tsa_ComprobantesDet.GetByPk( IdComprobante, Ordinal  );
			if (row != null)
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
		/// Obtiene un registro de la tabla tsa_ComprobantesDet que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsa_ComprobantesDetDataset.tsa_ComprobantesDetRow GetByPk( object IdComprobante, object Ordinal )
		{
			return GetByPk( ( string )IdComprobante, ( long )Ordinal );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_ComprobantesDetRow.
		/// </summary>
		public static tsa_ComprobantesDetDataset.tsa_ComprobantesDetRow SetRowDefaultValues( tsa_ComprobantesDetDataset.tsa_ComprobantesDetRow row )
		{
			row.IdComprobante = Util.NewStringId(); 
			row.Ordinal = 0; 
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			row.IdTipoDeComprobante = string.Empty;
			row.Fecha = mz.erp.businessrules.Sistema.DateTime.Now;
			row.Numero = string.Empty;
			row.IdProducto = string.Empty;
			row.Cantidad = 0;
			row.PrecioFinal = 0;
			row.PrecioBruto = 0;
			row.PrecioNeto = 0;
			row.DescuentosAplicados = 0;
			row.BonificacionRecargoFinanciero = 0;
			row.BonificacionRecargoCuenta = 0;
			row.BonificacionRecargoProducto = 0;
			row.PrecioDeCosto = 0;
			row.ImpuestosDirectos = 0;
			row.ImpuestosIndirectos = 0;
			row.IdMonedaOrigen = string.Empty;
			row.IdMonedaCierre = string.Empty;
			row.IdCotizacionCierre = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.SetRowIdGeneradoNull();
			row.IdListaDePrecio = string.Empty;
			row.CoeficienteListaDePrecio = 0;
			row.ModoDeAplicacion = string.Empty;
			row.PrecioDeCostoDirectoOriginal = 0;
			row.PrecioDeCostoIndirectoOriginal = 0;
			row.Coeficiente1Original = 0;
			row.Coeficiente2Original = 0;
			row.Coeficiente3Original = 0;
			row.Coeficiente4Original = 0;
			row.Coeficiente5Original = 0;
			row.Coeficiente6Original = 0;
			row.Coeficiente7Original = 0;
			row.Coeficiente8Original = 0;
			row.Coeficiente9Original = 0;
			row.Coeficiente10Original = 0;
			row.CodigoSecundarioOriginal = string.Empty;

            //Sabrina: Tarea 1073. 20110323
            row.IdCombo = string.Empty;
            row.Combo = string.Empty;
            //Fin Sabrina: Tarea 1073. 20110323
            
            return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobantesDetRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsa_ComprobantesDetDataset.tsa_ComprobantesDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobantesDetRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsa_ComprobantesDetDataset.tsa_ComprobantesDetRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobantesDetRow a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobantesDetDataset.tsa_ComprobantesDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComprobantesDet.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_ComprobantesDetDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobantesDetDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_ComprobantesDet.Rows.Count > 0, "La tabla dataSet.tsa_ComprobantesDetDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComprobantesDet.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobantesDetDataset.tsa_ComprobantesDetDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobantesDetDataset.tsa_ComprobantesDetDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComprobantesDet.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_ComprobantesDetRow.
		/// </summary>
		public static bool RowIsValid( tsa_ComprobantesDetDataset.tsa_ComprobantesDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdComprobanteIsValid( row.IdComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdComprobante" , mensaje);
				isValid=false;
			
			}
						
			if ( !OrdinalIsValid( row.Ordinal, out mensaje) )
			{ 
				row.SetColumnError( "Ordinal" , mensaje);
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
						
			if ( !IdTipoDeComprobanteIsValid( row.IdTipoDeComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoDeComprobante" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaIsValid( row.Fecha, out mensaje) )
			{ 
				row.SetColumnError( "Fecha" , mensaje);
				isValid=false;
			
			}
						
			if ( !NumeroIsValid( row.Numero, out mensaje) )
			{ 
				row.SetColumnError( "Numero" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdProductoIsValid( row.IdProducto, out mensaje) )
			{ 
				row.SetColumnError( "IdProducto" , mensaje);
				isValid=false;
			
			}
						
			if ( !CantidadIsValid( row.Cantidad, out mensaje) )
			{ 
				row.SetColumnError( "Cantidad" , mensaje);
				isValid=false;
			
			}
						
			if ( !PrecioFinalIsValid( row.PrecioFinal, out mensaje) )
			{ 
				row.SetColumnError( "PrecioFinal" , mensaje);
				isValid=false;
			
			}
						
			if ( !PrecioBrutoIsValid( row.PrecioBruto, out mensaje) )
			{ 
				row.SetColumnError( "PrecioBruto" , mensaje);
				isValid=false;
			
			}
						
			if ( !PrecioNetoIsValid( row.PrecioNeto, out mensaje) )
			{ 
				row.SetColumnError( "PrecioNeto" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescuentosAplicadosIsValid( row.DescuentosAplicados, out mensaje) )
			{ 
				row.SetColumnError( "DescuentosAplicados" , mensaje);
				isValid=false;
			
			}
						
			if ( !BonificacionRecargoFinancieroIsValid( row.BonificacionRecargoFinanciero, out mensaje) )
			{ 
				row.SetColumnError( "BonificacionRecargoFinanciero" , mensaje);
				isValid=false;
			
			}
						
			if ( !BonificacionRecargoCuentaIsValid( row.BonificacionRecargoCuenta, out mensaje) )
			{ 
				row.SetColumnError( "BonificacionRecargoCuenta" , mensaje);
				isValid=false;
			
			}
						
			if ( !BonificacionRecargoProductoIsValid( row.BonificacionRecargoProducto, out mensaje) )
			{ 
				row.SetColumnError( "BonificacionRecargoProducto" , mensaje);
				isValid=false;
			
			}
						
			if ( !PrecioDeCostoIsValid( row.PrecioDeCosto, out mensaje) )
			{ 
				row.SetColumnError( "PrecioDeCosto" , mensaje);
				isValid=false;
			
			}
						
			if ( !ImpuestosDirectosIsValid( row.ImpuestosDirectos, out mensaje) )
			{ 
				row.SetColumnError( "ImpuestosDirectos" , mensaje);
				isValid=false;
			
			}
						
			if ( !ImpuestosIndirectosIsValid( row.ImpuestosIndirectos, out mensaje) )
			{ 
				row.SetColumnError( "ImpuestosIndirectos" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdMonedaOrigenIsValid( row.IdMonedaOrigen, out mensaje) )
			{ 
				row.SetColumnError( "IdMonedaOrigen" , mensaje);
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
		/// Valida el campo Cantidad.
		/// </summary>
		public static bool CantidadIsValid( decimal Cantidad , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Cantidad. Metodo Sobrecargado
		/// </summary>
		public static bool CantidadIsValid( decimal Cantidad)
		{
			string mensaje;
			return CantidadIsValid( Cantidad, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo PrecioFinal.
		/// </summary>
		public static bool PrecioFinalIsValid( decimal PrecioFinal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo PrecioFinal. Metodo Sobrecargado
		/// </summary>
		public static bool PrecioFinalIsValid( decimal PrecioFinal)
		{
			string mensaje;
			return PrecioFinalIsValid( PrecioFinal, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo PrecioBruto.
		/// </summary>
		public static bool PrecioBrutoIsValid( decimal PrecioBruto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo PrecioBruto. Metodo Sobrecargado
		/// </summary>
		public static bool PrecioBrutoIsValid( decimal PrecioBruto)
		{
			string mensaje;
			return PrecioBrutoIsValid( PrecioBruto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo PrecioNeto.
		/// </summary>
		public static bool PrecioNetoIsValid( decimal PrecioNeto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo PrecioNeto. Metodo Sobrecargado
		/// </summary>
		public static bool PrecioNetoIsValid( decimal PrecioNeto)
		{
			string mensaje;
			return PrecioNetoIsValid( PrecioNeto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo DescuentosAplicados.
		/// </summary>
		public static bool DescuentosAplicadosIsValid( decimal DescuentosAplicados , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo DescuentosAplicados. Metodo Sobrecargado
		/// </summary>
		public static bool DescuentosAplicadosIsValid( decimal DescuentosAplicados)
		{
			string mensaje;
			return DescuentosAplicadosIsValid( DescuentosAplicados, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo BonificacionRecargoFinanciero.
		/// </summary>
		public static bool BonificacionRecargoFinancieroIsValid( decimal BonificacionRecargoFinanciero , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo BonificacionRecargoFinanciero. Metodo Sobrecargado
		/// </summary>
		public static bool BonificacionRecargoFinancieroIsValid( decimal BonificacionRecargoFinanciero)
		{
			string mensaje;
			return BonificacionRecargoFinancieroIsValid( BonificacionRecargoFinanciero, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo BonificacionRecargoCuenta.
		/// </summary>
		public static bool BonificacionRecargoCuentaIsValid( decimal BonificacionRecargoCuenta , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo BonificacionRecargoCuenta. Metodo Sobrecargado
		/// </summary>
		public static bool BonificacionRecargoCuentaIsValid( decimal BonificacionRecargoCuenta)
		{
			string mensaje;
			return BonificacionRecargoCuentaIsValid( BonificacionRecargoCuenta, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo BonificacionRecargoProducto.
		/// </summary>
		public static bool BonificacionRecargoProductoIsValid( decimal BonificacionRecargoProducto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo BonificacionRecargoProducto. Metodo Sobrecargado
		/// </summary>
		public static bool BonificacionRecargoProductoIsValid( decimal BonificacionRecargoProducto)
		{
			string mensaje;
			return BonificacionRecargoProductoIsValid( BonificacionRecargoProducto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo PrecioDeCosto.
		/// </summary>
		public static bool PrecioDeCostoIsValid( decimal PrecioDeCosto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo PrecioDeCosto. Metodo Sobrecargado
		/// </summary>
		public static bool PrecioDeCostoIsValid( decimal PrecioDeCosto)
		{
			string mensaje;
			return PrecioDeCostoIsValid( PrecioDeCosto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo ImpuestosDirectos.
		/// </summary>
		public static bool ImpuestosDirectosIsValid( decimal ImpuestosDirectos , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ImpuestosDirectos. Metodo Sobrecargado
		/// </summary>
		public static bool ImpuestosDirectosIsValid( decimal ImpuestosDirectos)
		{
			string mensaje;
			return ImpuestosDirectosIsValid( ImpuestosDirectos, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo ImpuestosIndirectos.
		/// </summary>
		public static bool ImpuestosIndirectosIsValid( decimal ImpuestosIndirectos , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ImpuestosIndirectos. Metodo Sobrecargado
		/// </summary>
		public static bool ImpuestosIndirectosIsValid( decimal ImpuestosIndirectos)
		{
			string mensaje;
			return ImpuestosIndirectosIsValid( ImpuestosIndirectos, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdMonedaOrigen.
		/// </summary>
		public static bool IdMonedaOrigenIsValid( string IdMonedaOrigen , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMonedaOrigen. Metodo Sobrecargado
		/// </summary>
		public static bool IdMonedaOrigenIsValid( string IdMonedaOrigen)
		{
			string mensaje;
			return IdMonedaOrigenIsValid( IdMonedaOrigen, out mensaje );
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


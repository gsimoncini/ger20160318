using System;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.systemframework;


namespace mz.erp.businessrules.comprobantes
{
	#region Clases Auxiliares
	public class Item
	{
		public Item()
		{
		}
		private string _descripcionCorta = string.Empty;
		private string _descripcionLarga = string.Empty;
		private string _descripcion= string.Empty;
		private string _descripcionDetallada = string.Empty;
		private string _campoAuxiliar1= string.Empty;
		private string _campoAuxiliar2= string.Empty;
		private string _campoAuxiliar3= string.Empty;
		private string _campoAuxiliar4= string.Empty;
		private string _campoAuxiliar5= string.Empty;
		private decimal _bonificacionRecargoProducto = 0;
		//private decimal _bonificacionRecargoProductoConImpuestos = 0;
		
		private decimal _bonificacionRecargoFinanciero = 0;
		private decimal _bonificacionRecargoCuenta = 0 ;
		private string _idProducto = string.Empty;
		private long _ordinalOrigen = 0;
		private long _ordinalDestino = 0;
		private string _idComprobanteOrigen = string.Empty;
		private string _idTipoComprobanteOrigen = string.Empty;
		private string _idComprobanteDestino = string.Empty;
		private string _idTipoComprobanteDestino = string.Empty;
		private string _idResponsableOrigen = string.Empty;
		private long _equipo = 0;
		private decimal _cantidad = 0;
		private decimal _cantidadOrigen = 0;
		private string _idMomentoDeStock = string.Empty;
		private decimal _precioNeto = 0;
		private decimal _precioBruto = 0;
		private decimal _precioCosto = 0;
		private decimal _precioCostoMonedaReferencia = 0;
		private decimal _bonificacionaplicada = 0;
		private bool _tieneDescripcionDetallada = false; 
		private string _codigo = string.Empty;
		private string _codigoSecundario = string.Empty;
		private string _codigoProveedor = string.Empty;
		private decimal _precioBrutoImpuestosIncluidos = 0;
		private decimal _maximoDescuento = 0;
		private decimal _porcentajeMaximoDescuento = 0;
		private decimal _porcentajeDescuento = 0;
		private long _contadorOrigen = 0;		
		private long _contadorDestino = 0;				

		/*Nuevas German*/
		private bool _entregar = true;
		private bool _cierraCircuito = false;
		private bool _allowEdit = true;
		private bool _afectaStock = true;
		private bool _visible = true;
		private string _idTipoProducto = "A";
		private long _idInstanciaOR = 0;

		private string _idComprobantesSucesores = string.Empty;
		private string _idComprobantesPredecesores = string.Empty;
		private string _idTiposComprobantesSucesores = string.Empty;
		private string _idTiposComprobantesPredecesores = string.Empty;

		private bool _percibeIB = true;

		private string _idListaDePrecios = string.Empty;
		private string _idListaDePreciosDefault = tsh_ListasDePrecios.GetDefault().IdListaDePrecio;
		private decimal _coeficienteListaDePrecios = 0; 
		private string _modoDeAplicacionListaDePrecios = string.Empty;
		//Nueva Vivi
		private Bonificacion _bonificacionProducto=new Bonificacion();

		private string _simboloMonedaPrecioCosto = string.Empty;
		private decimal _valorCotizacionPrecioCosto = 0;
		private string _simboloMonedaPrecioCostoBase = string.Empty;
		private decimal _precioCostoBase = 0;
		private decimal _valorCotizacionPrecioCostoBase = 0;

		private bool _origenMultiple = false;
		private ArrayList _origenes = new ArrayList();

		private bool _obligaCodigoBarra = false;
		private bool _obligaNumeroDeSerie = false;
		private ArrayList _codigosSecundarios = new ArrayList();
		private bool _tieneCodigoSecundarioSegmentado = false;
		private string _codigoSecundarioSegmentado = string.Empty;
		private bool _busquedaPorCodigoSecundarioSegmentado = false;
		private CodigoSecundarioSegmentadoParser _parserCodigoSecundarioSegmentado = null;

		/*Nuevas Matias*/
		private decimal _coeficiente1 = 0; 
		private decimal _coeficiente2 = 0;
		private decimal _coeficiente3 = 0;
		private decimal _coeficiente4 = 0;
		private decimal _coeficiente5 = 0;
		private decimal _coeficiente6 = 0;
		private decimal _coeficiente7 = 0;
		private decimal _coeficiente8 = 0;
		private decimal _coeficiente9 = 0;
		private decimal _coeficiente10 = 0;

		private decimal _precioDeCostoDirectoDB = 0;
		private decimal _precioDeCostoIndirectoDB = 0;
		private decimal _precioDeCostoRefDB = 0;

		// Matias - Tarea 41
		private decimal _precioDeCostoReposicionOriginal = 0;
		private decimal _precioDeCostoPromedioPonderadoOriginal = 0;
		private decimal _precioDeVentaMercadoBolsaOriginal = 0;
		private decimal _precioDeVentaMercadoCadenaOriginal = 0;
		private decimal _precioDeVentaMercadoCompetenciaDirectaOriginal = 0;
		private bool _usaPrecioDeCostoReposicionOriginal = false;
		private string _idCotizacionCierrePrecioDeCostoRefOriginal = string.Empty;

		private decimal _precioFinalOriginal = 0;

        //Sabrina: Tarea 1069. 20110322
        private bool _esCombo = false;
        //Fin Sabrina: Tarea 1069. 20110322

        //Sabrina: Tarea 1071. 20110322
        private decimal _precioDeVentaBrutoOriginalProductoCombo = 0;
        //Fin Sabrina: Tarea 1071. 20110322

        /* Silvina 20110704 - Tarea 0000136 */
        private bool _permiteCambio = true;
        /* Fin Silvina 20110704 - Tarea 0000136 */

        /* Silvina 20111104 - Tarea 0000222 */
        private string _jerarquiaCategorias = string.Empty;
        /* Fin Silvina 20111104 - Tarea 0000222 */

        //German 20120601 - Tarea 0000346
        private decimal _precioDeVentaBrutoOriginal = 0;
        //Fin German 20120601 - Tarea 0000346

		#region conversiones

		private Conversion _conversion;
		private string _idConversion;
		private string _idUnidad;
		private string _unidad;
		private string _idUnidadOrigen;
		private string _idUnidadDestino;
		private string _unidadOrigen;
		private string _unidadDestino;
		private decimal _valorOrigen;
		private decimal _valorDestino;

		private string _momento;
		
		#endregion

		public Item(ConceptosAdicionales concepto)
		{
			string momento = concepto.GetProcessManagerParent().Process.MainTask.KeyTask;
			_idProducto = Variables.GetValueString("Momentos." + momento + ".Flete.IdProductoAsociado");
			_cantidad = 1;
			System.Data.DataRow row = mz.erp.businessrules.tlg_Transportes.GetByPk(concepto.IdTransporte);
			if(row != null)
			{
				_precioNeto = Convert.ToDecimal(row["Valor1"]);
				_precioBruto = Convert.ToDecimal(row["Valor1"]);
				_descripcion =  Convert.ToString(row["Descripcion"]);
				_descripcionCorta = Convert.ToString(row["Descripcion"]);
				_descripcionLarga = Convert.ToString(row["Descripcion"]);
				_descripcionDetallada = Convert.ToString(row["Descripcion"]);
				_tieneDescripcionDetallada = true;

			}
			
			_bonificacionRecargoProducto = 0;
			//			_bonificacionRecargoProductoConImpuestos = 0;
			
			_idConversion = string.Empty;
			_idUnidad = string.Empty;
			_precioBrutoImpuestosIncluidos = concepto.Monto;
			

		}

        public Item(Productos producto)
        {
            _idProducto = producto.IdProducto;
            _cantidad = 1;
            _precioNeto = Convert.ToDecimal(producto.PrecioDeVentaBruto);
            _precioBruto = Convert.ToDecimal(producto.PrecioDeVentaBruto);
            _descripcion = producto.Descripcion;
            _descripcionDetallada = producto.DescripcionDetallada;
            _descripcionCorta = producto.DescripcionCorta;
            _descripcion = producto.Descripcion;
            _campoAuxiliar1 = producto.CampoAuxiliar1;
            _campoAuxiliar2 = producto.CampoAuxiliar2;
            _campoAuxiliar3 = producto.CampoAuxiliar3;
            _campoAuxiliar4 = producto.CampoAuxiliar4;
            _campoAuxiliar5 = producto.CampoAuxiliar5;
            //tendria q cargar el detalle de bonificacion q tenga para cantidad 1 q es la q se carga por default, cuando se actualiza la cantidad tendra otra bonificacion

            //German 201200531 - Tarea 0000276
            //this.BonificacionProducto.IdBonificacion = producto.IdBonificacion;
            //this.BonificacionProducto.CargarDetalle();
            //Fin German 20120531 - Tarea 0000276

            _bonificacionRecargoProducto = 0;
            //_bonificacionRecargoProductoConImpuestos = 0;
            _precioCosto = producto.PrecioDeCostoDirecto;
            _precioCostoMonedaReferencia = producto.PrecioDeCostoDirectoMonedaReferencia;
            _valorCotizacionPrecioCosto = producto.ValorCotizacionPrecioDeCostoRef;
            _idConversion = producto.IdConversion;
            _idUnidad = producto.IdUnidadMedida;
            _codigo = producto.Codigo;
            _codigoSecundario = producto.CodigoSecundario;
            _codigoProveedor = producto.CodigoProveedor;
            _codigosSecundarios = producto.CodigosSecundarios;
            _tieneCodigoSecundarioSegmentado = producto.TieneCodigoSecundarioSegmentado;
            _codigoSecundarioSegmentado = producto.CodigoSecundarioSegmentado;
            _precioBrutoImpuestosIncluidos = producto.PrecioBrutoConImpuestos;
            _maximoDescuento = producto.MaximoDescuento;
            _porcentajeMaximoDescuento = producto.PorcentajeMaximoDescuento;
            _porcentajeDescuento = 0;
            _percibeIB = producto.PercibeIB;
            _contadorOrigen = producto.ContadorOrigen;
            _contadorDestino = producto.ContadorDestino;

            _idListaDePrecios = producto.IdListaDePrecios;
            _idListaDePreciosDefault = producto.IdListaDePreciosDefault;
            _coeficienteListaDePrecios = producto.CoeficienteListaDePrecios;
            _modoDeAplicacionListaDePrecios = producto.ModoDeAplicacionListaDePrecios;

            _simboloMonedaPrecioCosto = producto.SimboloMonedaPrecioDeCostoRef;
            _simboloMonedaPrecioCostoBase = producto.SimboloMonedaPrecioDeCostoRef;
            _precioCostoBase = _precioCosto;
            _valorCotizacionPrecioCostoBase = producto.ValorCotizacionPrecioDeCostoRef;

            _coeficiente1 = producto.Coeficiente1;
            _coeficiente2 = producto.Coeficiente2;
            _coeficiente3 = producto.Coeficiente3;
            _coeficiente4 = producto.Coeficiente4;
            _coeficiente5 = producto.Coeficiente5;
            _coeficiente6 = producto.Coeficiente6;
            _coeficiente7 = producto.Coeficiente7;
            _coeficiente8 = producto.Coeficiente8;
            _coeficiente9 = producto.Coeficiente9;
            _coeficiente10 = producto.Coeficiente10;

            _precioDeCostoDirectoDB = producto.PrecioDeCostoDirectoDB;
            _precioDeCostoIndirectoDB = producto.PrecioDeCostoIndirectoDB;
            _precioDeCostoRefDB = producto.PrecioDeCostoRefDB;

            // Matias - Tarea 41
            _precioDeCostoReposicionOriginal = producto.PrecioDeCostoReposicion;
            _precioDeCostoPromedioPonderadoOriginal = producto.PrecioDeCostoPromedioPonderado;
            _precioDeVentaMercadoBolsaOriginal = producto.PrecioDeVentaMercadoBolsa;
            _precioDeVentaMercadoCadenaOriginal = producto.PrecioDeVentaMercadoCadena;
            _precioDeVentaMercadoCompetenciaDirectaOriginal = producto.PrecioDeVentaMercadoCompetenciaDirecta;
            _usaPrecioDeCostoReposicionOriginal = producto.UsaPrecioDeCostoReposicion;
            _idCotizacionCierrePrecioDeCostoRefOriginal = producto.IdCotizacionCierrePrecioDeCostoRef;
            // -------------

            _obligaCodigoBarra = producto.ObligaCodigoBarra;
            _obligaNumeroDeSerie = producto.ObligaNumeroDeSerie;


            _idTipoProducto = producto.IdTipoProducto;

            //Sabrina: Tarea 1069. 20110322
            _esCombo = producto.EsCombo;
            //Fin Sabrina: Tarea 1069. 20110322

            //Sabrina: Tarea 1071. 20110322
            _precioDeVentaBrutoOriginalProductoCombo = producto.PrecioDeVentaBrutoOriginalProductoCombo;
            //Fin Sabrina: Tarea 1071. 20110322


            /*string servicioGarantia = Variables.GetValueString("Productos.IdTipoProducto.ServicioDeGarantia");
            if (IdTipoProducto == servicioGarantia)
            _afectaStock = tsy_TipoProducto.AfectaStock(_idTipoProducto);*/

            /* Silvina 20110704 - Tarea 0000136 */
            _permiteCambio = producto.PermiteCambio;
            /* Fin Silvina 20110704 - Tarea 0000136 */

            /* Silvina 20111104 - Tarea 0000222 */
            _jerarquiaCategorias = producto.JerarquiaCategorias;
            /* Fin Silvina 20111104 - Tarea 0000222 */
            //German 20120601 - Tarea 0000346 //Se usa para el Step, pq si se toma el precio desde el comprobante anterior, se pierde el Precio de Venta Bruto original!
            _precioDeVentaBrutoOriginal = Convert.ToDecimal(producto.PrecioDeVentaBruto);
            //Fin German 20120601 - Tarea 0000346

        }
        //German 20120601 - Tarea 0000346
        public decimal PrecioDeVentaBrutoOriginal
        {
            get
            {
                return _precioDeVentaBrutoOriginal;
            }
        }
        //Fin German 20120601 - Tarea 0000346

		public void SetConversion(string Momento)
		{
			this._conversion = Factory.GetConversion(this._idConversion, this._idUnidad,Momento);
			this._conversion.Items.Get(0).ValorSinConvertir = this._conversion.Items.Get(0).ValorConversion;
			this._conversion.Items.Get(0).OnConverionChanged +=new EventHandler(Item_OnConverionChanged);
		}

		public string CodigoProveedor
		{
			get
			{
				return _codigoProveedor;
			}
		}

		public bool BusquedaPorCodigoSecundarioSegmentado
		{
			get
			{
				return _busquedaPorCodigoSecundarioSegmentado;
			}
			set
			{
				_busquedaPorCodigoSecundarioSegmentado = value;
			}
	
	}

		public CodigoSecundarioSegmentadoParser ParserCodigoSecundarioSegmentado
		{
			get{return _parserCodigoSecundarioSegmentado;}
			set{_parserCodigoSecundarioSegmentado = value;}
		}

		public string CodigoSecundarioSegmentado
		{
			get{return _codigoSecundarioSegmentado;}
			set{_codigoSecundarioSegmentado = value;}
		}

		public bool TieneCodigoSecundarioSegmentado
		{
			get{return _tieneCodigoSecundarioSegmentado;}
		}

		public ArrayList CodigosSecundarios
		{
			get{return _codigosSecundarios;}
		}

		public bool OrigenMultiple
		{
			get{return _origenMultiple;}
			set{_origenMultiple = value;}
		}

		public ArrayList Origenes
		{
			get{return _origenes;}
			set{_origenes = value;}
		}

		public decimal CantidadOrigen
		{
			get{return _cantidadOrigen;}
			set{_cantidadOrigen = value;}
		}

		public bool PercibeIB
		{
			get{return _percibeIB;}
			set{_percibeIB = value;}
		}

		public Bonificacion BonificacionProducto
		{
			get{return _bonificacionProducto;}
			set{_bonificacionProducto = value;}
		}
		public long IdInstanciaOR
		{
			get{return _idInstanciaOR;}
			set{_idInstanciaOR = value;}
		}
		
		public long Equipo
		{
			get{return _equipo;}
			set{_equipo = value;}
		}

		public string IdResponsableOrigen
			{
				get
				{
					return _idResponsableOrigen;
				}
				set
				{
					_idResponsableOrigen = value;
				}
			}
		public string IdTipoProducto
		{
			get
			{
				return _idTipoProducto;
			}
			set
			{
				_idTipoProducto = value;
			}
		}

		public bool AllowEdit
		{
			get
			{
				return _allowEdit;
			}
			set
			{
				_allowEdit = value;
			}
		}

		public bool Visible
		{
			get{return _visible;}
			set{_visible = value;}
		}

		
		public bool AfectaStock
		{
			get
			{
				return _afectaStock;
			}
			set
			{
				_afectaStock = value;
			}
		}

		
		public bool CierraCircuito
		{
			get
			{
				return _cierraCircuito;
			}
			set
			{
				_cierraCircuito = value;
			}
		}

		
		public bool Entregar
		{
			get
			{
				return _entregar;
			}
			set
			{
				_entregar = value;
			}
		}




		public Conversion Conversion
		{
			get
			{
				return _conversion;
			}
		}

		public string IdUnidad
		{
			get
			{
				return _idUnidad;
			}
		}

		public string IdConversion
		{
			get
			{
				return _idConversion;
			}
		}


		public string CodigoSecundario
		{
			get
			{
				return _codigoSecundario;
			}
			set
			{
				_codigoSecundario = value;
			}
		}



		public string Codigo
		{
			get
			{
				return _codigo;
			}
			set
			{
				_codigo = value;
			}
		}
	
		public bool TieneDescripcionDetallada
		{
			get
			{
				return _tieneDescripcionDetallada;
			}
			set
			{
				_tieneDescripcionDetallada = value;
			}
		}


		public string DescripcionCorta
		{
			get 
			{
				if (_descripcionCorta != string.Empty)
				{
					return _descripcionCorta;
				}
				else
				{
					return _descripcion; 
				}
			}
			set { _descripcionCorta = value; }
		}
		
		public string DescripcionLarga
		{
			get 
			{ 
				if (_descripcionLarga != String.Empty )
				{
					return _descripcionLarga;
				}
				else
				{
					return _descripcion;
				}
			}
			set { _descripcionLarga = value; }
		}
		
		public string Descripcion
		{
			get { return _descripcion; }
			set { _descripcion = value; }
		}

		public string CampoAuxiliar1
		{
			get { return _campoAuxiliar1; }
			set { _campoAuxiliar1 = value; }
		}
		public string CampoAuxiliar2
		{
			get { return _campoAuxiliar2; }
			set { _campoAuxiliar2 = value; }
		}
		public string CampoAuxiliar3
		{
			get { return _campoAuxiliar3; }
			set { _campoAuxiliar3 = value; }
		}
		public string CampoAuxiliar4
		{
			get { return _campoAuxiliar4; }
			set { _campoAuxiliar4 = value; }
		}
		public string CampoAuxiliar5
		{
			get { return _campoAuxiliar5; }
			set { _campoAuxiliar5 = value; }
		}
		public string DescripcionDetallada
		{
			get
			{
				return _descripcionDetallada;
			}
			set
			{
				_descripcionDetallada = value;
			}
		}

		public decimal BonificacionRecargoProducto
		{
			get { return _bonificacionRecargoProducto ; }
			set { _bonificacionRecargoProducto = value ; }
		}

		/*public decimal BonificacionRecargoProductoConImpuestos
		{
			get { return _bonificacionRecargoProductoConImpuestos; }
			set { _bonificacionRecargoProductoConImpuestos = value ; }
		}*/
		
		public decimal BonificacionRecargoFinanciero
		{
			get { return _bonificacionRecargoFinanciero ; }
			set { _bonificacionRecargoFinanciero = value ; }
		}
		
		public decimal BonficacionRecargoCuenta
		{
			get { return _bonificacionRecargoCuenta ; }
			set { _bonificacionRecargoCuenta = value ; }
		}
		
		public string IdProducto 
		{
			get { return _idProducto ;}
			set { _idProducto = value ; }
		}
		
		public bool ObligaCodigoBarra 
		{
			get { return _obligaCodigoBarra ;}
			set { _obligaCodigoBarra = value ; }
		}

		public bool ObligaNumeroDeSerie
		{
			get { return _obligaNumeroDeSerie ;}
			set { _obligaNumeroDeSerie = value ; }
		}

		public long OrdinalOrigen
		{
			get { return _ordinalOrigen ; }
			set { _ordinalOrigen = value; }
		}
		
		public long OrdinalDestino
		{
			get { return _ordinalDestino ; }
			set { _ordinalDestino = value ; }
		}
		
		public string IdComprobanteOrigen
		{
			get { return _idComprobanteOrigen ; }
			set { _idComprobanteOrigen = value ; }
		}
		
		public string IdComprobanteDestino
		{
			get { return _idComprobanteDestino ; }
			set { _idComprobanteDestino = value ; }
		}
		
		public string IdTipoComprobanteOrigen
		{
			get { return _idTipoComprobanteOrigen; }
			set { _idTipoComprobanteOrigen = value ; }
		}
		public string IdTipoComprobanteDestino
		{
			get { return _idTipoComprobanteDestino; }
			set { _idTipoComprobanteDestino = value ;}
		}

		public decimal Cantidad
		{
			get { return _cantidad ; }
			set { _cantidad = value ; }
		}

		public string IdMomentoDeStock
		{
			get { return _idMomentoDeStock; }
			set { _idMomentoDeStock = value ;}
		}
		
		public decimal PrecioNeto
		{
			get { return _precioNeto; }
			set { _precioNeto = value ;}
		}
		public decimal PrecioBrutoImpuestosIncluidos
		{
			get { return this._precioBrutoImpuestosIncluidos; }
			set { _precioBrutoImpuestosIncluidos = value ; }
		}
		public decimal MaximoDescuento
		{
			get { return this._maximoDescuento; }
			set { _maximoDescuento = value ; }
		}

		public decimal PorcentajeMaximoDescuento
		{
			get { return this._porcentajeMaximoDescuento; }
			set { _porcentajeMaximoDescuento = value ; }
		}
		public decimal PorcentajeDescuento
		{
			get { return this._porcentajeDescuento; }
			set { _porcentajeDescuento = value ; }
		}
		
		public decimal PrecioBruto
		{
			get { return _precioBruto ; }
			set { _precioBruto = value ;} 
		}

		public  decimal PrecioCostoMonedaReferencia
		{
			get { return _precioCostoMonedaReferencia ; }
			set { _precioCostoMonedaReferencia = value ; }
		}

		public decimal PrecioCosto
		{
			get { return _precioCosto ; }
			set { _precioCosto = value ; }
		}

		public decimal PrecioFinalOriginal
		{
			get { return _precioFinalOriginal ; }
			set { _precioFinalOriginal = value ; }
		}
		

		public decimal BonificacionAplicada
		{
			set { _bonificacionaplicada = value ; }
			get { return _bonificacionaplicada ; }
		}
		
		public long ContadorOrigen
		{
			get { return _contadorOrigen ; }
			set { _contadorOrigen = value; }
		}
		public long ContadorDestino
		{
			get { return _contadorDestino ; }
			set { _contadorDestino = value ; }
		}

		/*
		public bool SeIncluyeEnRecalculos
		{
			get
			{
				return _seIncluyeEnRecalculos;
			}
		}
		*/

		public string IdListaDePrecios
		{
			get { return _idListaDePrecios; }
			set { _idListaDePrecios = value; }
		}

		public string IdListaDePreciosDefault
		{
			get { return _idListaDePreciosDefault; }
			set { _idListaDePreciosDefault = value; }
		}

		public decimal CoeficienteListaDePrecios
		{
			get { return _coeficienteListaDePrecios; }
			set { _coeficienteListaDePrecios = value; }
		}

		public string ModoDeAplicacionListaDePrecios
		{
			get { return _modoDeAplicacionListaDePrecios; }
			set { _modoDeAplicacionListaDePrecios = value; }
		}

		private void Item_OnConverionChanged(object sender, EventArgs e)
		{
			
			ConversionItem conversionItem = (ConversionItem) sender;
			this._cantidad = conversionItem.ValorConvertido;
		}

		public string SimboloMonedaPrecioCosto
		{
			get { return _simboloMonedaPrecioCosto ; }
			set { _simboloMonedaPrecioCosto = value ; }
		}

		public decimal ValorCotizacionPrecioCosto
		{
			get { return _valorCotizacionPrecioCosto ; }
			set { _valorCotizacionPrecioCosto = value ; }
		}

		public string SimboloMonedaPrecioCostoBase
		{
			get { return _simboloMonedaPrecioCostoBase ; }
			set { _simboloMonedaPrecioCostoBase = value ; }
		}

		public decimal PrecioCostoBase
		{
			get { return _precioCostoBase ; }
			set { _precioCostoBase = value ; }
		}

		public decimal ValorCotizacionPrecioCostoBase
		{
			get { return _valorCotizacionPrecioCostoBase ; }
			set { _valorCotizacionPrecioCostoBase = value ; }
		}

		public decimal Coeficiente1
		{
			get { return _coeficiente1 ; }
		}

		public decimal Coeficiente2
		{
			get { return _coeficiente2 ; }
		}

		public decimal Coeficiente3
		{
			get { return _coeficiente3 ; }
		}

		public decimal Coeficiente4
		{
			get { return _coeficiente4 ; }
		}

		public decimal Coeficiente5
		{
			get { return _coeficiente5 ; }
		}

		public decimal Coeficiente6
		{
			get { return _coeficiente6 ; }
		}

		public decimal Coeficiente7
		{
			get { return _coeficiente7 ; }
		}

		public decimal Coeficiente8
		{
			get { return _coeficiente8 ; }
		}

		public decimal Coeficiente9
		{
			get { return _coeficiente9 ; }
		}

		public decimal Coeficiente10
		{
			get { return _coeficiente10 ; }
		}

		public decimal PrecioDeCostoDirectoDB
		{
			get { return _precioDeCostoDirectoDB; }
		}

		public decimal PrecioDeCostoIndirectoDB
		{
			get { return _precioDeCostoIndirectoDB; }
		}

		public decimal PrecioDeCostoRefDB
		{
			get { return _precioDeCostoRefDB; }
		}

		// Matias - Tarea 41 
		public decimal PrecioDeCostoReposicionOriginal
		{
			get { return _precioDeCostoReposicionOriginal; }
		}

		public decimal PrecioDeCostoPromedioPonderadoOriginal
		{
			get { return _precioDeCostoPromedioPonderadoOriginal; }
		}

		public decimal PrecioDeVentaMercadoBolsaOriginal
		{
			get { return _precioDeVentaMercadoBolsaOriginal; }
		}


		public decimal PrecioDeVentaMercadoCadenaOriginal
		{
			get { return _precioDeVentaMercadoCadenaOriginal; }
		}

		public decimal PrecioDeVentaMercadoCompetenciaDirectaOriginal
		{
			get { return _precioDeVentaMercadoCompetenciaDirectaOriginal; }
		}
											
		public bool UsaPrecioDeCostoReposicionOriginal											 
		{												 
			get { return _usaPrecioDeCostoReposicionOriginal; }											 
		}

		public string IdCotizacionCierrePrecioDeCostoRefOriginal
		{
			get { return _idCotizacionCierrePrecioDeCostoRefOriginal; }
		}
		// -- fin Tarea 41

       //Sabrina: Tarea 1069. 20110322
        public bool EsCombo
        {
            get { return _esCombo; }
        }
        //Fin Sabrina: Tarea 1069. 20110322

        //Sabrina: Tarea 1071. 20110322
        public decimal PrecioDeVentaBrutoOriginalProductoCombo
        {
            get { return _precioDeVentaBrutoOriginalProductoCombo; }
               
        }
        //Fin Sabrina: Tarea 1071. 20110322

        /* Silvina 20110704 - Tarea 0000136 */
        public bool PermiteCambio
        {
            get { return _permiteCambio; }
        }
        /* Fin Silvina 20110704 - Tarea 0000136 */

        /* Silvina 20111104 - Tarea 0000222 */
        public string JerarquiaCategorias
        {
            get { return _jerarquiaCategorias; }
        }
        /* Fin Silvina 20111104 - Tarea 0000222 */
	}
	#endregion

	/// <summary>
	/// Item de un comprobante de Venta. 
	/// Con esta clase se obtiene toda la informacion relativa a un item en particular
	/// La sumatoria de los montos del item deberia coincidir con el total del comprobante de venta,
	/// por lo tanto a traves de esta clase se podria obtener toda la información relativa a un 
	/// comprobante verticalmente.
	/// Un items deberia estar contenida en una coleccion de items
	/// </summary>
	public class ItemComprobante: DataObject
	{
		#region Eventos y Delegados
		public delegate void RefrescarItem( object sender, System.EventArgs e );
		/// <summary>
		/// Se dispara cada vez que es necesario refrescar atributos informativos del item
		/// </summary>
		public event RefrescarItem OnRefreshItem;

		public event EventHandler CantidadChanged;

		public delegate void RecalcularItem( object sender, System.EventArgs e );
		/// <summary>
		/// Se dispara cada vez que cambio una variable de calculo del item que puede afectar
		/// otras variables de calculo del comprobante de venta.
		/// </summary>
		public event RecalcularItem OnRecalcItem;
		#endregion

		#region Variables Privadas		
		private decimal _precio = 0;
		private string _idProducto;
		private decimal _cantidad;
		private long _ordinal = 0;
		private long _ordinalOrigen = 0;
		private long _contadorOrigen = 0;
		private long _contadorDestino = 0;		
		private int _contadorDigitos = 6;
		private string _metodoBonificacion = ComprobantesRules.Comprobantes_Bonificaciones_Metodo; 
		private decimal _precioDeVentaBruto=0;
		private decimal _precioDeVentaBrutoOriginal=0;
		private decimal cantidadCompraOriginal = 0;
		private decimal _precioCompraOriginal = 0;
		private decimal _precioDeVentaNetoMinimo=0;
		private decimal _precioDeVentaConImpuestosOriginal=0;
		private decimal _precioDeCostoNeto=0;
		private string _idComprobanteOrigen = string.Empty;
		private string _idTipoComprobanteOrigen = string.Empty;
       
		private Impuestos _impuestos;
		private ItemsComprobantes _itemsComprobantes;
		
		private string _descripcionLargaOriginal = string.Empty;
		private string _descripcionOriginal = string.Empty;

		private string _descripcionLarga = string.Empty;
		private string _descripcionCorta = string.Empty;
		private string _descripcion = string.Empty;

		private string _descripcionDetallada = string.Empty;

		private string _campoAuxiliar1 = string.Empty;
		private string _campoAuxiliar2 = string.Empty;
		private string _campoAuxiliar3 = string.Empty;
		private string _campoAuxiliar4 = string.Empty;
		private string _campoAuxiliar5 = string.Empty;

		private string _codigo = string.Empty;
		private string _codigoSecundario = string.Empty;
		private string _codigoProveedor = string.Empty;
		private bool _busquedaPorCodigoSecundarioSegmentado = false;
		private CodigoSecundarioSegmentadoParser _parserCodigoSecundarioSegmentado = null;

		private decimal _bonificacionRecargoProducto = 0;
		private decimal _bonificacionRecargoProductoConImpuestos = 0;
		private decimal _bonificacionRecargoFinanciero = 0;
		private decimal _maximoDescuento = 0;
		private decimal _porcentajeMaximoDescuento = 0;
		private decimal _porcentajeDescuento = 0;
		private decimal _bonificacion = 0;

		//private bool _seIncluyeEnRecalculos = true;


		private Conversion _conversion;
		private string _idUnidad;
		private string _unidad;
		private string _idUnidadOrigen;
		private string _idUnidadDestino;
		private string _unidadOrigen;
		private string _unidadDestino;
		private decimal _valorOrigen;
		private decimal _valorDestino;

		//Auxiliares

		private string _idUnidadAux;
		private string _unidadAux;
		private string _idUnidadOrigenAux;
		private string _idUnidadDestinoAux;
		private string _unidadOrigenAux;
		private string _unidadDestinoAux;
		private decimal _valorOrigenAux;
		private decimal _valorDestinoAux;
		private decimal _cantidadAux;

		//Para la visualizacion de Stock

		private string _visualizacionStock;
		private string _estadoStock;
		private decimal _cantStock;
		private decimal _cantStockPropio;

		//Para controlar la descripcion adicional

		private bool _tieneDescripcionAdicional = false;

		/*Nuevas Ordenreparacion*/
		private bool _entregar = true;
		private bool _cierraCircuito = false;
		private bool _allowEdit = true;
		private bool _afectaStock = true;
		private string _idTipoProducto = "A";
		private string _idEstadoStockDestino = string.Empty;
		private string _idEstadoStockOrigen = string.Empty;
		private long _idInstanciaOR = 0;
		bool _modificaCantidad = false;				
		private bool _visible = true;
		private bool _percibeIB = true;


		
		/*Modificacion 08/09/2007*/
		private long _idOrdenReparacion = 0;
		private long _idInstanciaOrdenReparacion = 0;
		private long _idTareaRealizada = 0;
		private long _idRepuestoOrdenReparacion = 0;
		private string _idComprobantesSucesores = string.Empty;
		private string _idComprobantesPredecesores = string.Empty;
		private string _idTiposComprobantesSucesores = string.Empty;
		private string _idTiposComprobantesPredecesores = string.Empty;
		private string _idResponsableOrigen=string.Empty;
		private long _equipo=0;
		private string _ordinalesPredecesores = string.Empty;
		private string _ordinalesSucesores = string.Empty;

		private string _idListaDePrecios = string.Empty;
		private string _idListaDePreciosDefault = tsh_ListasDePrecios.GetDefault().IdListaDePrecio;
		private decimal _coeficienteListaDePrecios = 0; 
		private string _modoDeAplicacionListaDePrecios = string.Empty;
		//Vivi
		private Bonificacion _bonificacionProducto=new Bonificacion();

		private ArrayList _codigosSecundarios = new ArrayList();
		private decimal _precioBrutoImpuestosIncluidosOriginal = 0;

		// Matias 10/09/08.
		private decimal _coeficiente1 = 0; 
		private decimal _coeficiente2 = 0;
		private decimal _coeficiente3 = 0;
		private decimal _coeficiente4 = 0;
		private decimal _coeficiente5 = 0;
		private decimal _coeficiente6 = 0;
		private decimal _coeficiente7 = 0;
		private decimal _coeficiente8 = 0;
		private decimal _coeficiente9 = 0;
		private decimal _coeficiente10 = 0;

		private decimal _precioDeCostoDirectoOriginal = 0;
		private decimal _precioDeCostoIndirectoOriginal = 0;
		private decimal _precioDeCostoRefOriginal = 0;

		// Matias - Tarea 41 - agrega nuevos campos
		private decimal _precioDeCostoReposicionOriginal = 0;
		private decimal _precioDeCostoPromedioPonderadoOriginal = 0;
		private decimal _precioDeVentaMercadoBolsaOriginal = 0;
		private decimal _precioDeVentaMercadoCadenaOriginal = 0;
		private decimal _precioDeVentaMercadoCompetenciaDirectaOriginal = 0;
		private bool _usaPrecioDeCostoReposicionOriginal = false;
		private string _idCotizacionCierrePrecioDeCostoRefOriginal = string.Empty;
		// -- fin var - Tarea 41


		private bool _obligaCodigoBarra = false;
		private bool _obligaNumeroDeSerie = false;

        //Sabrina: Tarea 1070. 20110322
        private string _idCombo = string.Empty;
        private string _combo = string.Empty;
        //Fin Sabrina: Tarea 1070. 20110322

        //Sabrina: Tarea 1071. 20110322
        private decimal _precioDeVentaBrutoOriginalProductoCombo = 0;
        //Fin Sabrina: Tarea 1071. 20110322

        /* Silvina 20110704 - Tarea 0000136 */
        private bool _permiteCambio = true; 
        /* Fin Silvina 20110704 - Tarea 0000136 */

        //German 20120612 - Tarea 0000325
        private bool _actualizaLPPorCategoria = true;
        //Fin German 20120612 - Tarea 0000325

        #endregion

		#region Constructores y Destructores
		public ItemComprobante( string action, ItemsComprobantes _parent, Item item  )
		{
			this._itemsComprobantes = _parent;
			Init( action, item );
		}

		public void Dispose()
		{
			
		}
		#endregion

		#region Inicializadores y Carga
		private void Init( string action, Item item )
		{
			switch (action.ToUpper())
			{
				case "NEW":
					
					FillLoadData( action, item );
					FillStaticData( );
					break;
				case "EDIT":
					FillLoadData( action, item );
					FillStaticData( );
					break;
				case "STEP":
					FillLoadData( action, item );
					FillStaticData( );
					break;
			}

		}
		
		private void FillLoadData( string action, Item item )
		{
			switch (action.ToUpper())
			{
				case "NEW":
				{
					//this._seIncluyeEnRecalculos = item.SeIncluyeEnRecalculos;
					this._idProducto = item.IdProducto;
					this._descripcion = item.Descripcion;
					this._descripcionOriginal = item.Descripcion;
					this._descripcionCorta = item.DescripcionCorta;
					this._descripcionLarga = item.DescripcionLarga;
					this._descripcionLargaOriginal = item.DescripcionLarga;
					this._descripcionDetallada = item.DescripcionDetallada;
					this._tieneDescripcionAdicional = item.TieneDescripcionDetallada;

					this._campoAuxiliar1 = item.CampoAuxiliar1;
					this._campoAuxiliar2 = item.CampoAuxiliar2;
					this._campoAuxiliar3 = item.CampoAuxiliar3;
					this._campoAuxiliar4 = item.CampoAuxiliar4;
					this._campoAuxiliar5 = item.CampoAuxiliar5;										

					this._bonificacion = item.BonificacionRecargoProducto;					
					this._bonificacionRecargoProducto = item.BonificacionRecargoProducto;										
					this._bonificacionRecargoFinanciero = 0;
					this._maximoDescuento = item.MaximoDescuento;
					this._porcentajeMaximoDescuento = item.PorcentajeMaximoDescuento;
					this._porcentajeDescuento = item.PorcentajeDescuento;
					
					this._cantidad = Math.Abs(item.Cantidad) * this.ItemsComprobantes.ComprobanteDeVenta.Signo;
					
					this._precio = item.PrecioNeto;
					this._precioDeVentaBruto = item.PrecioBruto;
					this._precioDeVentaBrutoOriginal = item.PrecioBruto;
					this._precioDeCostoNeto = item.PrecioCostoMonedaReferencia;										
					this._idComprobanteOrigen = null;
					this._ordinalOrigen = long.MinValue;
					this._idTipoComprobanteOrigen = null;
					this._ordinal = this.ItemsComprobantes.Ordinal;
					this._percibeIB = item.PercibeIB;

					this._impuestos = new Impuestos("NEW", this );
					this._bonificacionRecargoProductoConImpuestos = _bonificacionRecargoProductoConImpuestos + _precioDeVentaBruto + FuncionesImpuestos.ObtenerValor( this._impuestos );
					this._precioDeVentaConImpuestosOriginal = this._bonificacionRecargoProductoConImpuestos;
					this._contadorOrigen = item.ContadorOrigen;
					this._contadorDestino = item.ContadorDestino;					
					this._idResponsableOrigen=item.IdResponsableOrigen;
					this._equipo=item.Equipo;
					//this.ItemsComprobantes.ComprobanteDeVenta.IdResponsable;
					/*Medidas*/
					if(item.Conversion != null)
					{
						this._conversion = item.Conversion;
						this._idUnidad = item.IdUnidad;
						ConversionItem ci = this._conversion.Items.Get(0);
						this._idUnidadOrigen = ci.IdUnidadOrigen;
						this._idUnidadDestino = ci.IdUnidadDestino;
						this._unidadDestino = ci.UnidadDestino;
						this._unidadOrigen = ci.UnidadOrigen;
						if(this._conversion.Items.Get(0).ValorSinConvertir == 0)
							this._conversion.Items.Get(0).ValorSinConvertir = 1;
						this._valorOrigen = this._conversion.Items.Get(0).ValorSinConvertir;
						//this._conversion.Items.Get(0).ValorSinConvertir = 1;
						this._valorDestino = ci.ValorConvertido;
					}					
					
					string proceso = this.ItemsComprobantes.ComprobanteDeVenta.ProcessName();
					string tarea = this.ItemsComprobantes.ComprobanteDeVenta.TaskName();
					bool CantidadCeroPorDefectoPorContador = Variables.GetValueBool(proceso, tarea, "CantidadCeroPorDefectoPorContador");										
					if (CantidadCeroPorDefectoPorContador && this._contadorDestino == this._contadorOrigen)
					{
						_valorOrigen = 0;
						this._conversion.Items.Get(0).ValorSinConvertir = 0;						
						_cantidad = this._conversion.Items.Get(0).ValorConvertido;
					}					
					_idListaDePrecios = item.IdListaDePrecios;
					_idListaDePreciosDefault = item.IdListaDePreciosDefault;
					_coeficienteListaDePrecios = item.CoeficienteListaDePrecios;
					if(item.CodigoSecundarioSegmentado != string.Empty)
						_codigoSecundario  = item.CodigoSecundarioSegmentado;
					else
						_codigoSecundario  = item.CodigoSecundario;
					_codigosSecundarios = item.CodigosSecundarios;
					_codigoProveedor = item.CodigoProveedor;
					_busquedaPorCodigoSecundarioSegmentado = item.BusquedaPorCodigoSecundarioSegmentado;
					_parserCodigoSecundarioSegmentado = item.ParserCodigoSecundarioSegmentado;
					_modoDeAplicacionListaDePrecios = item.ModoDeAplicacionListaDePrecios;
					//Vivi
					_bonificacionProducto=item.BonificacionProducto;
					this.BonificacionRecargoProductoPorcentual=_bonificacionProducto.BonificacionAAplicar(this._cantidad);

					//Matias 10/09/08
					_coeficiente1 = item.Coeficiente1; 
					_coeficiente2 = item.Coeficiente2; 
					_coeficiente3 = item.Coeficiente3; 
					_coeficiente4 = item.Coeficiente4;
					_coeficiente5 = item.Coeficiente5;
					_coeficiente6 = item.Coeficiente6;
					_coeficiente7 = item.Coeficiente7;
					_coeficiente8 = item.Coeficiente8;
					_coeficiente9 = item.Coeficiente9;
					_coeficiente10 = item.Coeficiente10;

					_precioDeCostoDirectoOriginal = item.PrecioDeCostoDirectoDB;
					_precioDeCostoIndirectoOriginal = item.PrecioDeCostoIndirectoDB;
					_precioDeCostoRefOriginal = item.PrecioDeCostoRefDB;

					// Tarea 41
					_precioDeCostoReposicionOriginal = item.PrecioDeCostoReposicionOriginal;
                    _precioDeCostoPromedioPonderadoOriginal = item.PrecioDeCostoPromedioPonderadoOriginal;
					_precioDeVentaMercadoBolsaOriginal = item.PrecioDeVentaMercadoBolsaOriginal;
                    _precioDeVentaMercadoCadenaOriginal = item.PrecioDeVentaMercadoCadenaOriginal;
					_precioDeVentaMercadoCompetenciaDirectaOriginal = item.PrecioDeVentaMercadoCompetenciaDirectaOriginal;
					_usaPrecioDeCostoReposicionOriginal = item.UsaPrecioDeCostoReposicionOriginal;
					_idCotizacionCierrePrecioDeCostoRefOriginal = item.IdCotizacionCierrePrecioDeCostoRefOriginal;
					// -----
				
					if(item.BusquedaPorCodigoSecundarioSegmentado)
					{
						
						if(_parserCodigoSecundarioSegmentado.IsValid)
						{
							if(_parserCodigoSecundarioSegmentado.UsaPrecio)
							{
								_modificaCantidad = true;
								SubTotalConImpuestosDirectos = _parserCodigoSecundarioSegmentado.Precio;
							}
							if(_parserCodigoSecundarioSegmentado.UsaCantidad)
							{
								_modificaCantidad = false;
								CantidadUnidadOrigen = _parserCodigoSecundarioSegmentado.Cantidad;
							}
						}

						/*
						string prefijo = _codigoSecundario.Substring(0,2);
						if(prefijo.Equals("20"))
						{
							string codigoProductoConCeros = _codigoSecundario.Substring(2,5);
							string precioStr = _codigoSecundario.Substring(7,5);
							decimal precio = Convert.ToDecimal(precioStr)/100;
							_modificaCantidad = true;
							SubTotalConImpuestosDirectos = precio;
						}
						*/
					}

					this._obligaCodigoBarra = item.ObligaCodigoBarra;
					this._obligaNumeroDeSerie = item.ObligaNumeroDeSerie;
                    //German 20120514 - Tarea 0000325
                    _jerarquiaCategorias = item.JerarquiaCategorias;
                    //German 20120612 - Tarea 0000325 - Agrega el and
                    if (_itemsComprobantes.ComprobanteDeVenta.UsaCategorias && _actualizaLPPorCategoria)
                    //Fin German 20120612 - Tarea 0000325
                    {
                        string lp = tsh_ProductosListasDePreciosCategoriasCuentas.GetListaDePrecios(_itemsComprobantes.ComprobanteDeVenta.Cuenta.JerarquiaCategorias, item.JerarquiaCategorias);
                        if (lp != null)
                            this.IdListaDePrecios = lp;
                       
                    }
                    //Fin German 20120514 - Tarea 0000325
                    
                    break;
				}
				case "EDIT":
					//this._seIncluyeEnRecalculos = item.SeIncluyeEnRecalculos;
					this._idProducto = item.IdProducto;
					this._descripcion = item.Descripcion;
					this._descripcionOriginal = item.Descripcion;
					this._descripcionCorta = item.DescripcionCorta;
					this._descripcionLarga = item.DescripcionLarga;
					this._descripcionLargaOriginal = item.DescripcionLarga;

					this._bonificacion = item.BonificacionAplicada;
					this._bonificacionRecargoFinanciero = item.BonificacionRecargoFinanciero;
					this._bonificacionRecargoProducto = item.BonificacionRecargoProducto;										
					this._maximoDescuento = item.MaximoDescuento;
					this._porcentajeMaximoDescuento = item.PorcentajeMaximoDescuento;
					this._porcentajeDescuento = item.PorcentajeDescuento;
					
					this._descripcionDetallada = item.DescripcionDetallada;
					this._cantidad = item.Cantidad;
					
					
					this._precio = item.PrecioNeto;
					this._precioDeVentaBruto = item.PrecioBruto;
					this._precioDeVentaBrutoOriginal = item.PrecioBruto;
					this._precioDeCostoNeto = item.PrecioCostoMonedaReferencia;					
					
					this._ordinalOrigen = long.MinValue;
					this._ordinal = item.OrdinalDestino;
					
					this._impuestos = new Impuestos("EDIT", this );
					this._bonificacionRecargoProductoConImpuestos = _bonificacionRecargoProductoConImpuestos + _precioDeVentaBruto + FuncionesImpuestos.ObtenerValor( this._impuestos );
					this._precioDeVentaConImpuestosOriginal = this._bonificacionRecargoProductoConImpuestos;
					this._percibeIB = item.PercibeIB;

					FillEditDataDescripcionAdicional( this );

					/*Medidas*/
					
					if(item.Conversion != null)
					{
						this._conversion = item.Conversion;
						this._idUnidad = item.IdUnidad;
						ConversionItem cii = this._conversion.Items.Get(0);
						this._idUnidadOrigen = cii.IdUnidadOrigen;
						this._idUnidadDestino = cii.IdUnidadDestino;
						this._unidadDestino = cii.UnidadDestino;
						this._unidadOrigen = cii.UnidadOrigen;
						cii.ValorConvertido = item.Cantidad;
					
					
						this._valorOrigen = cii.getValorInverso();
						//this._conversion.Items.Get(0).ValorSinConvertir = 1;
						this._valorDestino = cii.ValorConvertido;
					}
					
					_idListaDePrecios = item.IdListaDePrecios;
					_idListaDePreciosDefault = item.IdListaDePreciosDefault;
					_coeficienteListaDePrecios = item.CoeficienteListaDePrecios;
					_modoDeAplicacionListaDePrecios = item.ModoDeAplicacionListaDePrecios;
					//Vivi
					_bonificacionProducto=item.BonificacionProducto;
					this.BonificacionRecargoProductoPorcentual=_bonificacionProducto.BonificacionAAplicar(this._cantidad);
                    //German 20120514 - Tarea 0000325
                    _jerarquiaCategorias = item.JerarquiaCategorias;
                    //Fin German 20120514 - Tarea 0000325
					break;
				case "STEP":
					//this._seIncluyeEnRecalculos = item.SeIncluyeEnRecalculos;
					this._idProducto = item.IdProducto;
					this._descripcion = item.Descripcion;
					this._descripcionOriginal = item.Descripcion;
					this._descripcionCorta = item.DescripcionCorta;
					this._descripcionLarga = item.DescripcionLarga;
					this._descripcionLargaOriginal = item.DescripcionLarga;
					this._descripcionDetallada = item.DescripcionDetallada;
					this._tieneDescripcionAdicional = item.TieneDescripcionDetallada;
					this._campoAuxiliar1 = item.CampoAuxiliar1;
					this._campoAuxiliar2 = item.CampoAuxiliar2;
					this._campoAuxiliar3 = item.CampoAuxiliar3;
					this._campoAuxiliar4 = item.CampoAuxiliar4;
					this._campoAuxiliar5 = item.CampoAuxiliar5;										
					
					this._bonificacion = item.BonificacionAplicada;
					this._bonificacionRecargoFinanciero = item.BonificacionRecargoFinanciero;
					this._bonificacionRecargoProducto = item.BonificacionRecargoProducto;										
					this._maximoDescuento = item.MaximoDescuento;
					this._porcentajeMaximoDescuento = item.PorcentajeMaximoDescuento;
					this._porcentajeDescuento = item.PorcentajeDescuento;
					//this._porcentajeDescuentoFijoAplicado = item.PorcentajeDescuentoFijoAplicado;
					this._idResponsableOrigen = item.IdResponsableOrigen;
					this._equipo = item.Equipo;
					this._cantidad = item.Cantidad;
					
					this._precio = item.PrecioNeto;
					this._recargosfinancierosaplicables = this.Precio - decimal.Round( (this._precio / (1 + this._bonificacionRecargoFinanciero /100)),4);
					this._precioDeVentaBruto = item.PrecioBruto;
                    //German 20120601 - Tarea 0000346
					//Se documenta pq no tiene en cuenta la lista de precio del comprobante actual - MUY MAL PQ ESTO SE USA PARA SACAR LOS DESCUENTOS PARA EL COMPROBANTE Y LA FISCAL
                    //this._precioDeVentaBrutoOriginal = Productos.ObtenerPrecioDeVentaBruto(this._idProducto, Security.IdSucursal);
                    this._precioDeVentaBrutoOriginal = item.PrecioDeVentaBrutoOriginal;
                    //Fin German 20120601 - Tarea 0000346
					this._precioDeCostoNeto = item.PrecioCostoMonedaReferencia;				
					
					this._idComprobanteOrigen = item.IdComprobanteOrigen;
					this._ordinalOrigen = item.OrdinalOrigen;
					this._ordinal = item.OrdinalDestino;
					this._idTipoComprobanteOrigen = item.IdTipoComprobanteOrigen;
					this._visible = item.Visible;
					this._idInstanciaOR = item.IdInstanciaOR;
					
					this._impuestos = new Impuestos("NEW", this );
					this._bonificacionRecargoProductoConImpuestos = _bonificacionRecargoProductoConImpuestos + _precioDeVentaBruto + FuncionesImpuestos.ObtenerValor( this._impuestos );	
					//this._precioDeVentaConImpuestosOriginal = this._bonificacionRecargoProductoConImpuestos;
					this._precioDeVentaConImpuestosOriginal = item.PrecioFinalOriginal;
					FillEditDataDescripcionAdicional( this );
					this._percibeIB = item.PercibeIB;
					/*Medidas*/

					if(item.Conversion != null)
					{
						this._conversion = item.Conversion;
						this._idUnidad = item.IdUnidad;
						ConversionItem ciii = this._conversion.Items.Get(0);
						this._idUnidadOrigen = ciii.IdUnidadOrigen;
						this._idUnidadDestino = ciii.IdUnidadDestino;
						this._unidadDestino = ciii.UnidadDestino;
						this._unidadOrigen = ciii.UnidadOrigen;
						ciii.ValorConvertido = item.Cantidad;
						this._valorOrigen = ciii.getValorInverso();
						//this._conversion.Items.Get(0).ValorSinConvertir = 1;
						this._valorDestino = ciii.ValorConvertido;
					}

					this._contadorOrigen = item.ContadorOrigen;
					this._contadorDestino = item.ContadorDestino;


					_codigoSecundario  = item.CodigoSecundario;
					_codigosSecundarios = item.CodigosSecundarios;
				

					_idListaDePrecios = item.IdListaDePrecios;
					_idListaDePreciosDefault = item.IdListaDePreciosDefault;
					_coeficienteListaDePrecios = item.CoeficienteListaDePrecios;
					_modoDeAplicacionListaDePrecios = item.ModoDeAplicacionListaDePrecios;
					//Vivi
					_bonificacionProducto=item.BonificacionProducto;
					this.BonificacionRecargoProductoPorcentual=_bonificacionProducto.BonificacionAAplicar(this._cantidad);

					//Matias 10/09/08
					_coeficiente1 = item.Coeficiente1; 
					_coeficiente2 = item.Coeficiente2; 
					_coeficiente3 = item.Coeficiente3; 
					_coeficiente4 = item.Coeficiente4;
					_coeficiente5 = item.Coeficiente5;
					_coeficiente6 = item.Coeficiente6;
					_coeficiente7 = item.Coeficiente7;
					_coeficiente8 = item.Coeficiente8;
					_coeficiente9 = item.Coeficiente9;
					_coeficiente10 = item.Coeficiente10;

					_precioDeCostoDirectoOriginal = item.PrecioDeCostoDirectoDB;
					_precioDeCostoIndirectoOriginal = item.PrecioDeCostoIndirectoDB;
					_precioDeCostoRefOriginal = item.PrecioDeCostoRefDB;

					// Tarea 41
					_precioDeCostoReposicionOriginal = item.PrecioDeCostoReposicionOriginal;
					_precioDeCostoPromedioPonderadoOriginal = item.PrecioDeCostoPromedioPonderadoOriginal;
					_precioDeVentaMercadoBolsaOriginal = item.PrecioDeVentaMercadoBolsaOriginal;
					_precioDeVentaMercadoCadenaOriginal = item.PrecioDeVentaMercadoCadenaOriginal;
					_precioDeVentaMercadoCompetenciaDirectaOriginal = item.PrecioDeVentaMercadoCompetenciaDirectaOriginal;
					_usaPrecioDeCostoReposicionOriginal = item.UsaPrecioDeCostoReposicionOriginal;
					_idCotizacionCierrePrecioDeCostoRefOriginal = item.IdCotizacionCierrePrecioDeCostoRefOriginal;
					// -----

					this._obligaCodigoBarra = item.ObligaCodigoBarra;
					this._obligaNumeroDeSerie = item.ObligaNumeroDeSerie;

                    //German 20120307 - Tarea 0000290

                    this._origenMultiple = item.OrigenMultiple;
                    //Fin German 20120307 - Tarea 0000290
                    //German 20120514 - Tarea 0000325
                    _jerarquiaCategorias = item.JerarquiaCategorias;
                    //Fin German 20120514 - Tarea 0000325

					break;
			}
			this._afectaStock = item.AfectaStock;
			this._entregar = item.Entregar;
			this._allowEdit = item.AllowEdit;
			this._cierraCircuito = item.CierraCircuito;
			this._idTipoProducto = item.IdTipoProducto;
			System.Console.WriteLine("Valor del responsable");
			System.Console.WriteLine(this._idResponsableOrigen);

            //Sabrina: Tarea 1071. 20110322
            _precioDeVentaBrutoOriginalProductoCombo = item.PrecioDeVentaBrutoOriginalProductoCombo;
            //Fin Sabrina: Tarea 1071. 20110322

            /* Silvina 20110704 - Tarea 0000136 */
            _permiteCambio = item.PermiteCambio;
            /* Fin Silvina 20110704 - Tarea 0000136 */

            /* Silvina 20111104 - Tarea 0000222 */
            //German 20120514 - Tarea 0000325
            //_jerarquiaCategorias = item.JerarquiaCategorias;
            //Fin German 20120514 - Tarea 0000325
            /* Fin Silvina 20111104 - Tarea 0000222 */

			//this._impuestos.SetAlicuotaMonto();

		}
		private void FillEditDataDescripcionAdicional( ItemComprobante item )
		{
			tsa_ComprobanteDetalleDescripcionAdicionalDataset.tsa_ComprobanteDetalleDescripcionAdicionalRow row = mz.erp.dataaccess.tsa_ComprobanteDetalleDescripcionAdicional.GetByPk( this.ItemsComprobantes.ComprobanteDeVenta.IdComprobante, this.Ordinal );
			if (row != null)
			{
				if (row.Descripcion != null) 
				{
					this._descripcionLarga = row.Descripcion;
				}
				else
				{
					this._descripcionLarga = this._descripcion;
				}
			}
			else
			{
				this._descripcionLarga = this._descripcion;
			}

		}

		private void FillStaticData()
		{
			Productos informacionAdicional = new Productos( this._idProducto );
			if (this._codigo == string.Empty ) { this._codigo = informacionAdicional.Codigo; }
			if (this._descripcion == string.Empty ) {	this._descripcion = informacionAdicional.Descripcion; }
			if (this._descripcionCorta == string.Empty ) { this._descripcionCorta = informacionAdicional.DescripcionCorta ; }
			if ((this._descripcionLarga == null) || (this._descripcionLarga == string.Empty )) 	{ this._descripcionLarga = informacionAdicional.DescripcionLarga; }
			if ((this._precioDeVentaNetoMinimo == 0 )) { this._precioDeVentaNetoMinimo = informacionAdicional.PrecioDeVentaNeto; }
			string IdVisualizacionDeStock = Variables.GetValue("Stock.VisualizacionDeStock.Default").ToString();
			string IdEstadoDeStock = Variables.GetValue("Stock.EstadoDeStock.Default").ToString();
			decimal stock = Stock.GetStock(IdVisualizacionDeStock, IdEstadoDeStock, _idProducto, false);
			decimal stockPropio = Stock.GetStock(IdVisualizacionDeStock, IdEstadoDeStock, _idProducto, true); 
			
			_modificaCantidad = Variables.GetValueBool("Momentos.Vender.Emision.Editar.Items.ModificaCantidad");
			tlg_VisualizacionDeStockDataset.tlg_VisualizacionDeStockRow rowVS = tlg_VisualizacionDeStock.GetByPk(IdVisualizacionDeStock);
			tlg_EstadosDeStockDataset.tlg_EstadosDeStockRow rowES = mz.erp.businessrules.tlg_EstadosDeStock.GetByPk(IdEstadoDeStock);
			this.CantStock = stock;
			this.CantStockPropio = stockPropio;
			this.VisualizacionStock = rowVS.Descripcion;
			this.EstadoStock = rowES.Descripcion;
		}


		#endregion

		#region Variables Publicas

		public bool ObligaCodigoBarra 
		{
			get { return _obligaCodigoBarra ;}
			set { _obligaCodigoBarra = value ; }
		}

		public bool ObligaNumeroDeSerie
		{
			get { return _obligaNumeroDeSerie ;}
			set { _obligaNumeroDeSerie = value ; }
		}

		public bool BusquedaPorCodigoSecundarioSegmentado
		{
			get
			{
				return _busquedaPorCodigoSecundarioSegmentado;
			}
		}

		public decimal PrecioBrutoImpuestosIncluidosOriginal
		{
			get { return this.PrecioBrutoImpuestosIncluidosOriginal; }
			set { PrecioBrutoImpuestosIncluidosOriginal = value ; }
		}

		public string OrdinalesSucesores
		{
			get{return _ordinalesSucesores;}
			set{_ordinalesSucesores = value;}
		}


		public string OrdinalesPredecesores
		{
			get{return _ordinalesPredecesores;}
			set{_ordinalesPredecesores = value;}
		}



		/*Modificacion 08/09/2007*/
		public long IdInstanciaOrdenReparacion
		{
			get {return _idInstanciaOrdenReparacion;}
			set {_idInstanciaOrdenReparacion = value;}
		}

		public long IdRepuestoOrdenReparacion
		{
			get {return _idRepuestoOrdenReparacion;}
			set {_idRepuestoOrdenReparacion = value;}
		}

		public long IdOrdenReparacion
		{
			get {return _idOrdenReparacion;}
			set {_idOrdenReparacion = value;}
		}

		public long IdTareaRealizada
		{
			get {return _idTareaRealizada;}
			set {_idTareaRealizada = value;}
		}

		public string IdTiposComprobantesPredecesores
		{
			get {return _idTiposComprobantesPredecesores;}
			set {_idTiposComprobantesPredecesores = value;}
		}

		public string IdTiposComprobantesSucesores
		{
			get {return _idTiposComprobantesSucesores;}
			set {_idTiposComprobantesSucesores = value;}
		}

		
		public string IdComprobantesPredecesores
		{
			get {return _idComprobantesPredecesores;}
			set {_idComprobantesPredecesores = value;}
		}


		public string IdComprobantesSucesores
		{
			get {return _idComprobantesSucesores;}
			set {_idComprobantesSucesores = value;}
		}


   
		public long Equipo
		{
			get {return _equipo;}
			set {_equipo = value;}
		}
		public string IdResponsableOrigen
		{
			get {return _idResponsableOrigen;}
			set {_idResponsableOrigen = value;}
		}

		/// <summary>
		/// La coleccion de items que lo contiene.
		/// </summary>
		public ItemsComprobantes ItemsComprobantes
		{
			get { return _itemsComprobantes; }
		}

		/// <summary>
		/// Descripcion del item. 
		/// Permite modificarla segun lo indicado en la variable
		/// Comprobante.Seguridad.Productos.PermiteModificarDescripcion
		/// </summary>
		/// 
		/*
				public bool SeIncluyeEnRecalculos
				{
					get
					{
						return _seIncluyeEnRecalculos;
					}
				}
		*/

		public bool PercibeIB
		{
			get{return _percibeIB;}
		}

		public bool TieneDescripcionPersonalizada
		{
			get{return _tieneDescripcionAdicional || (this._descripcionOriginal != this._descripcionDetallada);}
			set{_tieneDescripcionAdicional = value;}
		}
		
		public string IdTipoComprobanteOrigen
		{
			get { return _idTipoComprobanteOrigen ;  }
		}

		public string IdTipoProducto
		{
			get
			{
				return _idTipoProducto;
			}
			set
			{
				_idTipoProducto = value;
			}
		}
		
		public bool AllowEdit
		{
			get
			{
				return _allowEdit;
			}
			set
			{
				_allowEdit = value;
			}
		}
		

		
		public bool AfectaStock
		{
			get
			{
				return _afectaStock;
			}
			set
			{
				_afectaStock = value;
			}
		}

		
		public bool CierraCircuito
		{
			get
			{
				return _cierraCircuito;
			}
			set
			{
				_cierraCircuito = value;
			}
		}

		
		public bool Entregar
		{
			get
			{
				return _entregar;
			}
			set
			{
				_entregar = value;
			}
		}




		public string IdUnidad
		{
			get
			{
				return _idUnidad;
			}
			set
			{
				_idUnidad = value;
			}
		}

		public string UnidadOrigen
		{
			get{return _unidadOrigen;}
			set{_unidadOrigen = value;}
		}

		public string UnidadDestino
		{
			get {return _unidadDestino;}
			set {_unidadDestino = value;}

		}

		public string IdUnidadOrigen
		{
			get{return _idUnidadOrigen;}
			set{_idUnidadOrigen = value ;}
		}

		public string IdUnidadDestino
		{
			get{return _idUnidadDestino;}
			set{_idUnidadDestino = value ;}
		}


		public decimal CantidadUnidadOrigen
		{
			get{return _valorOrigen;}
			set
			{
                //German 20110411 - Tarea 0000071
                value=Math.Abs(value);
                //German 20110601 - Tarea 0000144
                _valorOrigen = value;
                //Fin German 20110601 - Tarea 0000144
				
				this._conversion.Items.Get(0).ValorSinConvertir = value;
				Cantidad = this._conversion.Items.Get(0).ValorConvertido;
			}
		}

		public decimal CantidadUnidadDestino
		{
			get{return _valorDestino;}
			set {_valorDestino = value;}
		}

		public Conversion Conversion
		{	
			get{return _conversion;}
			set
			{
				if(value != null)
				{
					_conversion = value;
					_conversion.Items.OnConversionChanged += new EventHandler(Items_OnConversionChanged);
				}
			}
		}


		public string Unidad
		{
			get{return _unidad;}
			set {_unidad = value;}
		}

		/*
		private System.Collections.Hashtable ColeccionImpuestos
		{
			get
			{
				System.Collections.Hashtable table = new System.Collections.Hashtable();
				table = FuncionesImpuestos.ObtenerFormulas( this.ItemsComprobantes.ComprobanteDeVenta.Cuenta.IdCuenta, this.ItemsComprobantes.ComprobanteDeVenta.TipoComprobanteDestino,this.IdProducto );
				return table;
			}
		}
		*/
		/// <summary>
		/// Descripcion del item. 
		/// Permite modificarla segun lo indicado en la variable
		/// Comprobante.Seguridad.Productos.PermiteModificarDescripcion
		/// </summary>
		/// 
		public string Descripcion
		{

			set 
			{
				if (ComprobantesRules.Comprobantes_Seguridad_Productos_Permite_ModificarDescripcion)
				{

					if (value != _descripcion)
					{
						_descripcion = value;
						if (OnRefreshItem != null)
						{
							OnRefreshItem( this, new System.EventArgs() );
						}
					}
				}
			}
			get
			{
				return _descripcion ;
			}
		}

		/// <summary>
		/// Descirpcion larga del producto
		/// Permite modificarla segun lo indicado en la variable
		/// Comprobante.Seguridad.Productos.PermiteModificarDescripcion
		/// </summary>
		public string DescripcionLarga
		{
			set 
			{
				if (true) //ComprobantesRules.Comprobantes_Seguridad_Productos_Permite_ModificarDescripcion)
				{
					if (value != _descripcionLarga)
					{
						_descripcionLarga = value;
						if (OnRefreshItem != null)
						{
							OnRefreshItem( this, new System.EventArgs() );
						}
					}
				}
				
			}
			get
			{
				return _descripcionLarga ;
			}
		}
		/// <summary>
		/// Descirpcion larga del producto
		/// Permite modificarla segun lo indicado en 
		/// ComprobantesRules.GetMaxItemValue
		/// </summary>
		/// 
		public string DescripcionCorta
		{
			set 
			{
				if (true) //ComprobantesRules.Comprobantes_Seguridad_Productos_Permite_ModificarDescripcion)
				{
					if (value != _descripcionCorta)
					{
						_descripcionCorta = value;
						if (OnRefreshItem != null)
						{
							OnRefreshItem( this, new System.EventArgs() );
						}
					}
				}
				
			}
			get
			{
				return _descripcionCorta ;
			}
		}

		public string DescripcionDetallada
		{
			get
			{
				return this._descripcionDetallada;
			}
			set
			{
				this._descripcionDetallada = value;
			}
		
		}

		public string CampoAuxiliar1
		{
			set {_campoAuxiliar1 = value;}
			get {return _campoAuxiliar1 ;}
		}
		public string CampoAuxiliar2
		{
			set {_campoAuxiliar2 = value;}
			get {return _campoAuxiliar2 ;}
		}
		public string CampoAuxiliar3
		{
			set {_campoAuxiliar3 = value;}
			get {return _campoAuxiliar3 ;}
		}
		public string CampoAuxiliar4
		{
			set {_campoAuxiliar4 = value;}
			get {return _campoAuxiliar4 ;}
		}
		public string CampoAuxiliar5
		{
			set {_campoAuxiliar5 = value;}
			get {return _campoAuxiliar5 ;}
		}



		/// <summary>
		/// Descripcion corta del producto
		/// Permite modificarla segun lo indicado en 
		/// ComprobantesRules.GetMaxItemValue
		/// </summary>

		public decimal Cantidad
		{
			set 
			{	
				if (_cantidad <= ComprobantesRules.GetMaxItemValue())
				{
					if (value != _cantidad)
					{
                        //German 20110411 - Tarea 0000071
						_cantidad = Math.Abs(value) * this.ItemsComprobantes.ComprobanteDeVenta.Signo;
                        //_cantidad = value * this.ItemsComprobantes.ComprobanteDeVenta.Signo;
                        //Fin German 20110411 - Tarea 0000071
						this.IsDirty=true;
						//Vivi
						this.BonificacionRecargoProductoPorcentual=_bonificacionProducto.BonificacionAAplicar(_cantidad);
						AplicarBonificaciones();
						if (OnRecalcItem != null)
						{
							OnRecalcItem( this, new System.EventArgs() );
						}

						if(CantidadChanged != null)
							CantidadChanged(this, new EventArgs());
					}
				}
			}
			get 
			{
				return _cantidad;
			}
		}

		/// <summary>
		/// Precio del item
		/// Indica el precio Neto una vez aplicado todos las bonificaciones y recargos directos e indirecto. 
		/// Excluido impuestos
		/// </summary>
		public decimal Precio
		{
			set
			{
				if (true)/*(Variables.GetValueBool("Comprobante.Seguridad.Productos.PermiteDescuentos"))*/
				{
					if (_precio != value)
					{
						_precio = value;
						_isPrecioChanged = true;
						this.IsDirty=true;
						if (OnRecalcItem != null)
						{
							OnRecalcItem( this, new System.EventArgs() );
						}
						
					}
				}
			}
			get
			{
				return _precio;
			}
		}

		
		/// <summary>
		/// Precio Neto + Impuestos Directos e Indirectos aplicados al item.
		/// </summary>
	

		/// <summary>
		/// Precio Neto + Impuestos Directos aplicados al item
		/// </summary>
		public decimal PrecioConImpuestosDirectos
		{
			get
			{
				return _precio + FuncionesImpuestos.ObtenerValorAplicado( this._impuestos, Constantes.ImpuestosAplicadosAProductos ) ;
			}
			set
			{
				
				if(value != 0 && this.ItemsComprobantes.ComprobanteDeVenta.MustRecalcular)
				{			
					decimal precioFinalSinImpuestos=FuncionesImpuestos.CalcularInversa( this._impuestos, value, Constantes.ImpuestosAplicadosAProductos);
					PrecioDeVentaBruto = FuncionesImpuestos.CalcularInversa( this._impuestos, value, Constantes.ImpuestosAplicadosAProductos);
					
					//AplicarBonificacionesInversa(precioFinalSinImpuestos);
					//_porcentajeDescuento = ((_precioDeVentaConImpuestosOriginal / PrecioConImpuestosDirectos)-1)*100;
					/*
					_aux = value;
					decimal Precio = FuncionesImpuestos.CalcularInversa( this._impuestos, value );
					decimal Bonif = Math.Round(_bonificacion,2);
					decimal PrecioSinBonificaciones = Precio - _recargosfinancierosaplicables;
					decimal descuentoProducto = _precioDeVentaBruto * BonificacionRecargoProductoPorcentual / 100;
					decimal precioBonificadoProducto = _precioDeVentaBruto - descuentoProducto;
					decimal descuentoCliente = precioBonificadoProducto * BonificacionRecargoCuenta / 100;
					PrecioDeVentaBruto = PrecioSinBonificaciones + descuentoProducto + descuentoCliente;
					this.IsDirty=true;
					if (OnRecalcItem != null)
					{
						OnRecalcItem( this, new System.EventArgs() );
					}
					*/
					
				
					
				}
				else if(value == 0)PrecioDeVentaBruto = 0;
			}
		}

		public decimal PrecioDeVentaNetoMinimo
		{
			get
			{
				return _precioDeVentaNetoMinimo;
			}
		}



		/// <summary>
		/// Retorna coleccion de impuestos directos aplicados al item.
		/// </summary>
		public Impuestos ImpuestosDirectos 
		{
			get
			{
				return FuncionesImpuestos.ObtenerColeccionImpuestos( this._impuestos, Constantes.ImpuestosAplicadosAProductos );
			}
		}

		/// <summary>
		/// Retorna la coleccion de impuestos indirectos aplicados al item.
		/// </summary>
		public Impuestos ImpuestosIndirectos
		{
			get
			{
				return FuncionesImpuestos.ObtenerColeccionImpuestosNoAplicados( this._impuestos, Constantes.ImpuestosAplicadosAProductos );
			}
		}
		/// <summary>
		/// Cantidad * Precio
		/// </summary>
		public decimal SubTotalNeto
		{
			get 
			{
				return _cantidad * _precio;
			}
		}
		/// <summary>
		/// Cantidad * Precio Con Impuestos Directos
		/// </summary>
		public decimal SubTotalConImpuestosDirectos
		{
			get
			{
				return _cantidad * PrecioConImpuestosDirectos;
			}
			set 
			{				
				if (value != _cantidad * PrecioConImpuestosDirectos)
				{					
					if (_modificaCantidad && PrecioConImpuestosDirectos != 0) 
					{
						CantidadUnidadOrigen = value / PrecioConImpuestosDirectos;
					}
					else 
					{
						PrecioConImpuestosDirectos = value / _cantidad;
					}
				}
			}
		}
		/// <summary>
		/// Cantidad * Precio Con Impuestos Directos e Indirectos
		/// </summary>
		public decimal SubTotalConImpuestos
		{
			get
			{
				return _cantidad * PrecioConImpuestos;
			}
            /* Silvina 20111025 - Tarea 0000212 */
            set
            {
                if (value != _cantidad * PrecioConImpuestos)
                {
                    if (_modificaCantidad && PrecioConImpuestos != 0)
                    {
                        CantidadUnidadOrigen = value / PrecioConImpuestos;
                    }
                    else
                    {
                        PrecioConImpuestos = value / _cantidad;
                    }
                }
            }
            /* Fin Silvina 20111025 - Tarea 0000212 */
		}

		private decimal _recargosfinancierosaplicables = 0;
		
		//Cambio echo por German - a Prueba 26-11-2005
		public decimal SubTotalRecargosFinancieros
		{
			get
			{
				//if(_seIncluyeEnRecalculos)
				return _cantidad * _recargosfinancierosaplicables;
				//else return 0;
			}
		}
		/// <summary>
		/// Identificador unico del producto. Relacion con IdProducto de la tabla Productos
		/// </summary>
		public string IdProducto
		{
			get { return _idProducto; }
		}

		public decimal ImporteUnitarioSinImpBonificacionRecargoCuenta
		{
			get
			{
				return _precioDeVentaBruto * this.BonificacionRecargoCuenta / 100;
			}
		}

		//Cambio echo por German - a Prueba 26-11-2005
		public decimal ImporteUnitarioSinImpBonificacionRecargoFinanciero
		{
			get
			{
				//if(_seIncluyeEnRecalculos)
				return _precioDeVentaBruto * this.BonificacionRecargoFinanciero /100;
				//else return _precioDeVentaBruto;
			}
		}

		//Cambio echo por German - a Prueba 26-11-2005
		public decimal ImporteUnitarioSinImpBonificacionRecargoProducto
		{
			get
			{
				//if(_seIncluyeEnRecalculos)
				return _precioDeVentaBruto * this.BonificacionRecargoProductoPorcentual / 100;
				//else return _precioDeVentaBruto;
			}
		}
		/// <summary>
		/// Retorna el porcentaje de bonificacion que aplica la cuenta
		/// </summary>
		/// 

		//Cambio echo por German - a Prueba 26-11-2005
		public decimal BonificacionRecargoCuenta
		{
			get
			{
				//if(_seIncluyeEnRecalculos)
				return this._itemsComprobantes.ComprobanteDeVenta.Cuenta.BonificacionCuenta;
				// else return 0;
			}
		}

		/// <summary>
		/// Retorna el importe de la bonificacion que se aplica en forma directa al producto
		/// </summary>
		/// 

		//Cambio echo por German - a Prueba 26-11-2005
		public decimal BonificacionRecargoProducto
		{
			set
			{
				//if(_seIncluyeEnRecalculos)
				//{
				this.IsDirty= true;
				_bonificacionRecargoProducto = value;
				AplicarBonificaciones();
				//}
			}
			get
			{
				return _bonificacionRecargoProducto;
			}
		}
		/// <summary>
		/// Retorna el porcentaje de la bonificacion que se aplica en forma directa al producto
		/// </summary>
		/// 


		//Cambio echo por German - a Prueba 26-11-2005
		public decimal BonificacionRecargoProductoPorcentual
		{
			set
			{
				//if(_seIncluyeEnRecalculos)
				//{
				this.IsDirty = true;
				BonificacionRecargoProducto = (_precioDeVentaBruto*value /100);
				//}
			}
			get
			{
				//if(_seIncluyeEnRecalculos)
				//{
				if (_precioDeVentaBruto != 0)
				{
					

					return (_bonificacionRecargoProducto * Convert.ToDecimal(100.00) / _precioDeVentaBruto);
				}
				else
				{
					return 0;
				}
				//}
				//else
				//	return 0;

			}
		}
		/// <summary>
		/// Retorna el importe de la bonificacion que se aplica en forma directa al producto
		/// </summary>
		public decimal BonificacionRecargoProductoConImpuestos
		{			
			get
			{
				return _bonificacionRecargoProductoConImpuestos;
			}
		}

		/// <summary>
		/// Retorna el porcentaj de la bonificacion que se aplica por las condiciones financieras del pago del comprobante
		/// </summary>
		/// 


		//Cambio echo por German - a Prueba 26-11-2005
		public decimal BonificacionRecargoFinanciero
		{
			get
			{
				//if(_seIncluyeEnRecalculos)
				//{
				//if(_bonificacionRecargoFinanciero == 0)
				_bonificacionRecargoFinanciero = this.ItemsComprobantes.ComprobanteDeVenta.PorcentualRecargosFinancieros;
				return _bonificacionRecargoFinanciero;
				//}
				//return 0;
				

			}
		}


		public decimal MaximoDescuento
		{
			get { return this._maximoDescuento; }
			set { _maximoDescuento = value ; }
		}

		public decimal PorcentajeMaximoDescuento
		{
			get { return this._porcentajeMaximoDescuento; }
			set { _porcentajeMaximoDescuento = value ; }
		}


		public decimal PorcentajeDescuento
		{
			get { return this._porcentajeDescuento; }
			set 
			{				
				if (_porcentajeDescuento != value)					
				{
                    _porcentajeDescuento = value;
                    //Sabrina: Tarea 1071. 20110322
                    if (this.IdCombo != null && ! this.IdCombo.Equals(string.Empty)) //Si es parte de un combo el descuento se aplica al PrecioDeVentaBrutoOriginal que tenia el producto en el combo
                    {
                        decimal nuevoPVBProductoCombo = _precioDeVentaBrutoOriginalProductoCombo * (1 - _porcentajeDescuento / 100);
                        System.Collections.Hashtable formulas = mz.erp.businessrules.comprobantes.FuncionesImpuestos.ObtenerFormulas(null, null, IdProducto);
                        decimal impuestosBrutos = mz.erp.businessrules.comprobantes.FuncionesImpuestos.Calcular(formulas, nuevoPVBProductoCombo);
                        PrecioConImpuestosDirectos = nuevoPVBProductoCombo + impuestosBrutos;
                    }
                    else
                        PrecioConImpuestosDirectos = _precioDeVentaConImpuestosOriginal * (1 - _porcentajeDescuento / 100);
                    //Fin Sabrina: Tarea 1071. 20110322
				}
			}
		}

		public void PorcentajeDescuentoSinRecalculo(decimal valor)
		{
			_porcentajeDescuento = valor;
		}


		/// <summary>
		/// Determina la bonificacion porcentual final aplicada según el procedimiento de <see cref="AplicarBonificaciones"/>
		/// </summary>
		public decimal BonificacionPorcentual
		{
			get
			{
				return _bonificacion;
			}
		}
		/// <summary>
		/// Determina la bonificacion monetaria final aplicada según el procedimiento de <see cref="AplicarBonificaciones"/>
		/// </summary>
		/// 


		//Cambio echo por German - a Prueba 26-11-2005
		public decimal BonificacionMonetaria
		{
			get
			{
				//if(_seIncluyeEnRecalculos)
				return Convert.ToDecimal(_precioDeVentaBruto * _bonificacion / 100);

				//return 0;
			}
		}
		/* Modificacion German 03/10/2006 */
		private decimal _aux = decimal.MinValue;
		public decimal PrecioConImpuestos
		{
			get
			{				
				return _precio + FuncionesImpuestos.ObtenerValor( this._impuestos );
			}
			set
			{
				if(value != 0 && this.ItemsComprobantes.ComprobanteDeVenta.MustRecalcular)
				{
					PrecioDeVentaBruto = FuncionesImpuestos.CalcularInversa( this._impuestos, value);
					/*
					_aux = value;
					decimal Precio = FuncionesImpuestos.CalcularInversa( this._impuestos, value );
					decimal Bonif = Math.Round(_bonificacion,2);
					decimal PrecioSinBonificaciones = Precio - _recargosfinancierosaplicables;
					decimal descuentoProducto = _precioDeVentaBruto * BonificacionRecargoProductoPorcentual / 100;
					decimal precioBonificadoProducto = _precioDeVentaBruto - descuentoProducto;
					decimal descuentoCliente = precioBonificadoProducto * BonificacionRecargoCuenta / 100;
					PrecioDeVentaBruto = PrecioSinBonificaciones + descuentoProducto + descuentoCliente;
					this.IsDirty=true;
					if (OnRecalcItem != null)
					{
						OnRecalcItem( this, new System.EventArgs() );
					}
					*/
					
				
					
				}
				else if(value == 0)PrecioDeVentaBruto = 0;
			}		
		}
		/// <summary>
		/// Precio de Venta bruto. Tambien conocido como precio de lista.
		/// No incluye impuestos ni recargos ni bonificaciones.
		/// Es el precio inicial de un producto sin que se le aplique ningun tipo de cargo o bonificacion por todo concepto.
		/// </summary>
		/// 

		
		public decimal PrecioDeVentaBruto
		{
			get
			{
				return _precioDeVentaBruto;
			}
			set
			{
				if(_precioDeVentaBruto != value)
				{
					_precioDeVentaBruto = value;
					_isPrecioChanged = true;
					//Vivi OJO ACA HAY Q TRAER DE NUEVO LA BONIFICACION DE CUENTA, VER SI NO LA TRAE BIEN.
					AplicarBonificaciones();
					this.IsDirty=true;
					if (OnRecalcItem != null)
					{
						OnRecalcItem( this, new System.EventArgs() );
					}
				}
						

			}
		}
		public decimal PrecioDeVentaBrutoOriginal 
		{
			get 
			{
				return _precioDeVentaBrutoOriginal;
			}
		}



		/// <summary>
		/// Retorna el Codigo del Producto. Clave Unica de identificación para el usuario. 
		/// El Id del Producto es interno de la base de datos. La clave unica es la codificacion
		/// que utiliza el cliente para visualizar los productos.
		/// </summary>
		public string Codigo
		{
			get
			{
				return _codigo;
			}

			set
			{
				_codigo = value;
			}
		}

		public string CodigoSecundario
		{
			get
			{
				return _codigoSecundario;
			}

			set
			{
				_codigoSecundario = value;
			}
		}


		/// <summary>
		/// Posicion con respecto a la coleccion de items
		/// </summary>
		public long Ordinal
		{
			get
			{
				return _ordinal;
			}
			set
			{
				_ordinal = value;
			}
		}

		public long OrdinalOrigen
		{
			get{return _ordinalOrigen;}
		}

		public string VisualizacionStock
		{
			get{return _visualizacionStock;}
			set{_visualizacionStock = value;}
		}

		public string EstadoStock
		{		
			get{return _estadoStock;}
			set{_estadoStock = value;}
		}

		public decimal  CantStock
		{
			get{return _cantStock;}
			set{_cantStock = value;}
		}

		public decimal  CantStockPropio
		{
			get{return _cantStockPropio;}
			set{_cantStockPropio = value;}
		}

		public Impuestos Impuestos
		{
			get{return _impuestos;}
		}

		public bool Visible 
		{
			get {return _visible;}
		}

		public string IdComprobanteOrigen
		{
			get{return _idComprobanteOrigen;}
		}
		
		public long IdInstanciaOR
		{
			get{return _idInstanciaOR;}
		}

		public long ContadorOrigen
		{
			get 
			{ 
				//return _contadorOrigenInf ; 
				return _contadorOrigen ; 
			}
		}
		
		public long ContadorDestino
		{			
			get { return _contadorDestino ; }
			set 
			{			
				long maximo = Util.MaximoValor(_contadorDigitos);
				if (value != _contadorDestino && value <= maximo)
				{
					_contadorDestino = value;					
					if (value < _contadorOrigen)
					{
						this.CantidadUnidadOrigen = maximo + 1 - _contadorOrigen + _contadorDestino;
					}
					else 
					{						
						this.CantidadUnidadOrigen = _contadorDestino - _contadorOrigen;
					}								
					
				}				 
			}
		}


        
		public string IdListaDePrecios
		{
			get { return _idListaDePrecios; }
			set
			{
			    if(_idListaDePrecios != value)
				{
					
                    //German 20100906 - Tarea 825
                    if (this.ItemsComprobantes.ComprobanteDeVenta.State.Equals("NEW"))
                    {

                        mz.erp.businessrules.Productos miProducto = new mz.erp.businessrules.Productos("IDPRODUCTO", this.IdProducto, value, _idListaDePreciosDefault, true, false);
                        mz.erp.businessrules.comprobantes.Item miItem = new mz.erp.businessrules.comprobantes.Item(miProducto);
                        this._bonificacionRecargoProductoConImpuestos = 0;
                        decimal cant = this.CantidadUnidadOrigen;
                        //German 20120514 - Tarea 0000325
                        //string IdListaDePrecioAux = value;
                        //Fin German 20120514 - Tarea 0000325
                        /* Silvina 20101029 - Tarea 887 */
                        long ord = _ordinal;
                        //German 20120612 - Tarea 0000325
                        _actualizaLPPorCategoria = false;
                        //Fin German 20120612 - Tarea 0000325
                        this.FillLoadData("NEW", miItem);
                        //German 20120612 - Tarea 0000325
                        _actualizaLPPorCategoria = true;
                        //Fin German 20120612 - Tarea 0000325
                        _ordinal = ord;
                        /* Fin Silvina */
                        //German 20120514 - Tarea 0000325
                        //_idListaDePrecios = IdListaDePrecioAux;
                        _idListaDePrecios = value;
                        //Fin German 20120514 - Tarea 0000325
                        this.CantidadUnidadOrigen = cant;
                        this.IsDirty = true;
                        if (OnRecalcItem != null)
                        {
                            OnRecalcItem(this, new System.EventArgs());
                        }
                    }
                    else
                    {
                        if (this._idProducto != ComprobantesRules.Comprobantes_OrdenReparcion_IdProductoComodinServicios())
                        {
                            mz.erp.businessrules.Productos miProducto = new mz.erp.businessrules.Productos("IDPRODUCTO", this.IdProducto, value, _idListaDePreciosDefault, true, false);
                            mz.erp.businessrules.comprobantes.Item miItem = new mz.erp.businessrules.comprobantes.Item(miProducto);

                            this._maximoDescuento = miItem.MaximoDescuento;
                            this._porcentajeMaximoDescuento = miItem.PorcentajeMaximoDescuento;
                            this._porcentajeDescuento = miItem.PorcentajeDescuento;

                            this._precio = miItem.PrecioNeto;
                            this._recargosfinancierosaplicables = this.Precio - decimal.Round((this._precio / (1 + this._bonificacionRecargoFinanciero / 100)), 4);
                            this._precioDeVentaBruto = miItem.PrecioBruto;
                            //German 20120601 - Tarea 0000346
                            this._precioDeVentaBrutoOriginal = miItem.PrecioDeVentaBrutoOriginal;
                            //Fin German 20120601 - Tarea 0000346
                            
                            this._precioDeVentaConImpuestosOriginal = miItem.PrecioBrutoImpuestosIncluidos;

                            _idListaDePrecios = miItem.IdListaDePrecios;
                            _idListaDePreciosDefault = miItem.IdListaDePreciosDefault;
                            _coeficienteListaDePrecios = miItem.CoeficienteListaDePrecios;
                            _modoDeAplicacionListaDePrecios = miItem.ModoDeAplicacionListaDePrecios;
                            this.IsDirty = true;
                            if (OnRecalcItem != null)
                            {
                                OnRecalcItem(this, new System.EventArgs());
                            }
                        }
                    }
				


                    //Fin German 20100906 - Tarea 825

                }
			}
		}

		public decimal CoeficienteListaDePrecios
		{
			get { return _coeficienteListaDePrecios; }
			set { _coeficienteListaDePrecios = value; }
		}

		public string ModoDeAplicacionListaDePrecios
		{
			get { return _modoDeAplicacionListaDePrecios; }
			set { _modoDeAplicacionListaDePrecios = value; }
		}

        //Sabrina: Tarea 1070. 20110322
        public string IdCombo
        {
            get { return _idCombo; }
            set { _idCombo = value; }
        }

        public string Combo
        {
            get { return _combo; }
            set { _combo = value; }
        }
        //Fin Sabrina: Tarea 1070. 20110322

        /* Silvina 20110704 - Tarea 0000136 */
        public bool PermiteCambio
        {
            get { return _permiteCambio; }
        }
        /* Fin Silvina 20110704 - Tarea 0000136 */

        /* Silvina 20111104 - Tarea 0000222 */
        private string _jerarquiaCategorias = string.Empty;

        public string JerarquiaCategorias
        {
            get { return _jerarquiaCategorias; }
        }

        /* Fin Silvina 20111104 - Tarea 0000222 */

        #endregion

		#region Propiedades de Estado

		private bool _isPrecioChanged = false;
		public bool IsPrecioChanged
		{
			get { return _isPrecioChanged ; }
		}

		
		public bool IsDirty
		{
			set
			{
				_impuestos.IsDirty = value;
			}
			get
			{
				return _impuestos.IsDirty;
			}
		}

		public bool IsDescripcionChanged
		{
			get
			{
				if ((this._descripcionOriginal != this._descripcion) || (this._descripcionLarga != this._descripcionLargaOriginal )
					|| this._tieneDescripcionAdicional 	)
						
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}


		#endregion

		#region Funciones y Metodos Publicos

        //German 20120307 - Tarea 0000290
        private ArrayList _origenes = new ArrayList();

        private bool _origenMultiple = false;
        public void AddOrigen(RelacionComprobanteOrigen origen)
        {
            this._origenes.Add(origen);

        }

        //Fin German 20120307 - Tarea 0000290

		/// <summary>
		/// Fuerza un refrezco de los impuestos definidos para el item.
		/// </summary>
		/// <param name="NombreImpuesto"></param>
		/// <returns></returns>
		public decimal GetPorcentajeImpuesto (string NombreImpuesto) 
		{
			return _impuestos.GetPorcentajeImpuesto(NombreImpuesto);
		}
		public decimal GetAlicuota (string NombreImpuesto) 
		{
			return _impuestos.GetAlicuota(NombreImpuesto);
		}
        //Matias 20110823 - Tarea 0000131
        public decimal GetTotalImpuesto (ArrayList NombresImpuestos) 
		{
            return _impuestos.GetTotalImpuesto(NombresImpuestos) * this.Cantidad;
        }
        public decimal GetBaseImponible(string impuestos)
        {
            /*
            * Por cada item, si este tiene aplicado alguno de los impuestos de keyImpuestos...
            * suma el subtotalneto del item
            * return +sumatoria del subtotalneto
            * iva.BaseImp = return;
            */
            if (_impuestos.Contiene(impuestos))
                return this.SubTotalNeto;
            return 0;
        }
        //FinMatias 20110823 - Tarea 0000131
		public void RefrescarImpuestos()
		{
			_impuestos.Clear();
			_impuestos = new Impuestos( "NEW", this );
		}

		/// <summary>
		/// Permite determinar si un impuesto esta incluido en el item en particular.
		/// </summary>
		/// <param name="idImpuesto"></param>
		/// <returns></returns>
		public bool ContieneImpuesto( string idImpuesto )
		{
			foreach(Impuesto imp in this._impuestos)
			{
				if (imp.IdImpuesto == idImpuesto)
				{
					return true;
				}
			}
			return false;
		}


		//Cambio echo por German - a Prueba 26-11-2005

		public void AplicarBonificaciones()
		{
			//if(_seIncluyeEnRecalculos)
			//{
				string metodo = this._metodoBonificacion;
				
			
			if (metodo.ToUpper() == Constantes.MetodoBonificacionAcumuladoA )
				{
					//Primero toma la bonificacion del producto
					//luego la bonificacion de la cuenta y la aplica sobre el producto bonificado
					decimal descuentoProducto = _precioDeVentaBruto * BonificacionRecargoProductoPorcentual / 100;
					decimal precioBonificadoProducto = _precioDeVentaBruto - descuentoProducto;
					decimal descuentoCliente = precioBonificadoProducto * BonificacionRecargoCuenta / 100;
					_precio = precioBonificadoProducto - descuentoCliente;
					_recargosfinancierosaplicables = (_precio * this.BonificacionRecargoFinanciero /100);

					//Modificacion de OSCAR 4/4/2007. 
					if (_codigo == "0099999")
					{
						string Proceso = this.ItemsComprobantes.ComprobanteDeVenta.GetProcessManagerParent().Process.ProcessName;
						string Tarea = this.ItemsComprobantes.ComprobanteDeVenta.GetTaskName();
						string aux = Variables.GetValueString(Proceso, Tarea, "CondicionesDeVentasExcluidasDeRecargoAServicio");
						ArrayList res = mz.erp.systemframework.Util.Parse(aux, ",");
						if(res.Contains(this.ItemsComprobantes.ComprobanteDeVenta.CondicionDeVenta.IdCondicionDeVenta))
							_recargosfinancierosaplicables = 0;
					}
					//FIN Modificacion de OSCAR 4/4/2007. 

					_precio = _precio + _recargosfinancierosaplicables;
					if (_precioDeVentaBruto != 0)
					{
						_bonificacion = (_precioDeVentaBruto - _precio) * 100 / _precioDeVentaBruto;
					}
					else
					{
						_bonificacion = 0;
					}

				}
				if (metodo.ToUpper() == Constantes.MetodoBonificacionMejorPostor )
				{
					//De los descuentos aplicables toma el de mayor valor
					decimal maximoDescuento = Math.Max( _bonificacionRecargoProducto, BonificacionRecargoCuenta );
					decimal descuentoMaximo = _precioDeVentaBruto* maximoDescuento / 100;
					_precio = _precioDeVentaBruto - descuentoMaximo;
					_recargosfinancierosaplicables = (_precio * this.BonificacionRecargoFinanciero /100);
					_precio = _precio + _recargosfinancierosaplicables;
					if (_precioDeVentaBruto != 0)
					{
						_bonificacion = (_precioDeVentaBruto- _precio) * 100 / _precioDeVentaBruto;
					}
					else
					{
						_bonificacion = 0;
					}
				}
				this.IsDirty=true;
				if (OnRecalcItem != null)
				{
					OnRecalcItem( this, new System.EventArgs() );
				}
			//}
		
		}
		
		/// <summary>
		/// Prepara los datos del item para ser almacenados en el comprobante
		/// Requiere que el El Encabezado ya esté almacenado
		/// </summary>
		public override void Commit()
		{
			tsa_ComprobantesExDataset data = this.ItemsComprobantes.ComprobanteDeVenta.DatasetComprobante;
			data = this.CommitItem(data);
			data = this.CommitDescripcionAdicional(data);
			data = this.CommitRelacionOrigenDestino(data);
			
			this.ImpuestosDirectos.Commit();
			this.ImpuestosIndirectos.Commit();	
			data = this.CommitItemReparaciones(data);
		}


		#endregion

		#region Funciones y Metodos Privados
		//Metodo Viejo

		/*private void AplicarBonificacionesInversa()
		{
			string metodo = this._metodoBonificacion;
			if (metodo.ToUpper() == Constantes.MetodoBonificacionAcumuladoA )
			{
				//Primero toma la bonificacion del producto
				//luego la bonificacion de la cuenta y la aplica sobre el producto bonificado
				decimal descuentoProducto = _precioDeVentaBruto * BonificacionRecargoProductoPorcentual / 100;
				decimal precioBonificadoProducto = _precioDeVentaBruto - descuentoProducto;
				decimal descuentoCliente = precioBonificadoProducto * BonificacionRecargoCuenta / 100;
				_bonificacion = (_precioDeVentaBruto - _precio) * 100 / _precioDeVentaBruto;
				
			}
			if (metodo.ToUpper() == Constantes.MetodoBonificacionMejorPostor )
			{
				//De los descuentos aplicables toma el de mayor valor
				decimal maximoDescuento = Math.Max( _bonificacionRecargoProducto, BonificacionRecargoCuenta );
				decimal descuentoMaximo = _precioDeVentaBruto* maximoDescuento / 100;
				_precio = _precioDeVentaBruto - descuentoMaximo;
				_bonificacion = (_precioDeVentaBruto- _precio) * 100 / _precioDeVentaBruto;
			}
		}*/

		private void AplicarBonificacionesInversa(decimal precioFinalSinImpuesto)
		{
			//Asi se aplican las bonificaciones entonces volvamos pa atras
			/*decimal descuentoProducto = _precioDeVentaBruto * BonificacionRecargoProductoPorcentual / 100;
			decimal precioBonificadoProducto = _precioDeVentaBruto - descuentoProducto;
			decimal descuentoCliente = precioBonificadoProducto * BonificacionRecargoCuenta / 100;
			_precio = precioBonificadoProducto - descuentoCliente;
			_recargosfinancierosaplicables = (_precio * this.BonificacionRecargoFinanciero /100);*/
							
			//codigo mio
			decimal recargoProducto=this.BonificacionRecargoProductoPorcentual;
			decimal recargoFinanciero=this.BonificacionRecargoFinanciero;
			decimal recargoCuenta=this.BonificacionRecargoProductoPorcentual;
			decimal precioFinalBonificacionRecargoFinanciero=precioFinalSinImpuesto-precioFinalSinImpuesto*this.BonificacionRecargoFinanciero/100;
			decimal precioFinalBonificacionCuenta=precioFinalBonificacionRecargoFinanciero +precioFinalBonificacionRecargoFinanciero * this.BonificacionRecargoCuenta/100;
			decimal precioFinalBonificacionProducto=precioFinalBonificacionCuenta + precioFinalBonificacionCuenta* this.BonificacionRecargoProductoPorcentual/100 ;
			
					
			_precioDeVentaBruto = precioFinalBonificacionProducto;
			this.BonificacionRecargoProductoPorcentual = recargoProducto;
			//this.BonificacionRecargoFinanciero=recargoFinanciero;
			this.BonificacionRecargoProductoPorcentual=recargoCuenta;
			_isPrecioChanged = true;
			AplicarBonificaciones();
			this.IsDirty=true;
			if (OnRecalcItem != null)
			{
				OnRecalcItem( this, new System.EventArgs() );
			}
			
			
		}


		private tsa_ComprobantesExDataset CommitItemReparaciones(tsa_ComprobantesExDataset data)
		{
			if(this.ItemsComprobantes.ComprobanteDeVenta.OrdenesReparacion.Count > 0)
			{
				if(this.ItemsComprobantes.ComprobanteDeVenta.OrdenesReparacion.Contains(Convert.ToInt64(this._idComprobanteOrigen)))
				{
					tsa_ComprobantesExDataset.tsa_ComprobanteDetalleOrdenReparacionRow row = data.tsa_ComprobanteDetalleOrdenReparacion.Newtsa_ComprobanteDetalleOrdenReparacionRow();
					row.FechaCreacion = this.ItemsComprobantes.ComprobanteDeVenta.FechaComprobante;
					row.IdComprobante = this.ItemsComprobantes.ComprobanteDeVenta.IdComprobante;
					row.IdEmpresa = Security.IdEmpresa;
					row.IdSucursal = Security.IdSucursal;
					row.IdOrdenReparacion = Convert.ToInt64(this._idComprobanteOrigen);
					row.IdEstadoStockDestino = this._idEstadoStockDestino;
					row.IdEstadoStockOrigen = this._idEstadoStockOrigen;
					row.IdMovimientoDeStockDestino = "0";
					row.IdMovimientoDeStockOrigen = "0";
					row.IdProducto = this._idProducto;
					row.Ordinal = this._ordinal;
					row.IdConexionCreacion = Security.IdConexion;
					row.IdConexionUltimaModificacion = Security.IdConexion;
					row.IdReservado = 1;
					data.tsa_ComprobanteDetalleOrdenReparacion.Addtsa_ComprobanteDetalleOrdenReparacionRow(row);
				
				}
			}
			return data;

		}

		private tsa_ComprobantesExDataset CommitItem(tsa_ComprobantesExDataset data)
		{			
			tsa_ComprobantesExDataset.tsa_ComprobantesDetRow row = data.tsa_ComprobantesDet.Newtsa_ComprobantesDetRow();						
			
			row.IdComprobante = this.ItemsComprobantes.ComprobanteDeVenta.IdComprobante;
			row.IdTipoDeComprobante = this.ItemsComprobantes.ComprobanteDeVenta.TipoComprobanteDestino;
			row.Numero = this.ItemsComprobantes.ComprobanteDeVenta.Numero;
			row.Fecha = this.ItemsComprobantes.ComprobanteDeVenta.FechaComprobante;			
			
			row.Ordinal = this._ordinal;
			row.Cantidad = this._cantidad;
			row.IdProducto = this._idProducto;

			row.PrecioBruto = this._precioDeVentaBruto;
			row.PrecioNeto = this._precio;
			row.DescuentosAplicados = this.BonificacionMonetaria;
			row.BonificacionRecargoFinanciero = this.BonificacionRecargoFinanciero;
			row.BonificacionRecargoCuenta = this.BonificacionRecargoCuenta;
			row.BonificacionRecargoProducto = this.BonificacionRecargoProducto;
			row.PrecioFinal = this.PrecioConImpuestos;
			row.PrecioDeCosto = this._precioDeCostoNeto;
			row.ImpuestosDirectos = this.ImpuestosDirectos.Total;
			row.ImpuestosIndirectos = this.ImpuestosIndirectos.Total;
			
			row.IdCotizacionCierre = ComprobantesRules.Contabilidad_CotizacionReferencia;
			row.IdMonedaCierre = ComprobantesRules.Contabilidad_MonedaReferencia;
			row.IdMonedaOrigen = ComprobantesRules.Contabilidad_MonedaReferencia;
			
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			
			row.IdConexionUltimaModificacion = Security.IdConexion;		
			row.Visible = this.Visible;
			row.IdListaDePrecio = this.IdListaDePrecios;
			row.CoeficienteListaDePrecio = this.CoeficienteListaDePrecios;
			row.ModoDeAplicacion = this.ModoDeAplicacionListaDePrecios;
			row.PrecioNetoOriginal = this._precioDeVentaNetoMinimo;
			row.PrecioBrutoOriginal	= this._precioDeVentaBrutoOriginal;
			row.PrecioFinalOriginal	= this._precioDeVentaConImpuestosOriginal;
			row.MaxDescuentoPorcentualOriginal	= this._porcentajeMaximoDescuento;
			row.MaxDescuentoOriginal = this._maximoDescuento;			
			row.DescuentoAplicadoVendedor = _precioDeVentaBrutoOriginal - _precioDeVentaBruto;
			
			// matias 17/09/08
			/*if (this._porcentajeMaximoDescuento != 0)				
				row.DescuentoPorcentualAplicadoVendedor	= row.DescuentoAplicadoVendedor * _maximoDescuento / this._porcentajeMaximoDescuento;			
			else
				if (_precioDeVentaBruto != 0)
					row.DescuentoPorcentualAplicadoVendedor	= (_precioDeVentaBrutoOriginal / _precioDeVentaBruto - 1) * 100;
				else
					row.DescuentoPorcentualAplicadoVendedor	= 0;
					*/

			if (_precioDeVentaBrutoOriginal != 0)
				row.DescuentoPorcentualAplicadoVendedor	= ( (_precioDeVentaBrutoOriginal - _precioDeVentaBruto) * 100 / _precioDeVentaBrutoOriginal );
			else
				row.DescuentoPorcentualAplicadoVendedor	= 0;

			// --
			// matias 10/09/08
			row.Coeficiente1Original = this._coeficiente1;
			row.Coeficiente2Original = this._coeficiente2;
			row.Coeficiente3Original = this._coeficiente3;
			row.Coeficiente4Original = this._coeficiente4;
			row.Coeficiente5Original = this._coeficiente5;
			row.Coeficiente6Original = this._coeficiente6;
			row.Coeficiente7Original = this._coeficiente7;
			row.Coeficiente8Original = this._coeficiente8;
			row.Coeficiente9Original = this._coeficiente9;
			row.Coeficiente10Original = this._coeficiente10;
			row.PrecioDeCostoDirectoOriginal = this._precioDeCostoDirectoOriginal;
			row.PrecioDeCostoIndirectoOriginal = this._precioDeCostoIndirectoOriginal;
			row.PrecioDeCostoRefOriginal = this._precioDeCostoRefOriginal;
			row.CodigoSecundarioOriginal = this._codigoSecundario;
			row.PorcentajeDescuentoFijoAplicado = this._porcentajeDescuento;
			// --------

			// Matias - Tarea 41
			row.PrecioDeCostoReposicionOriginal = this._precioDeCostoReposicionOriginal;
            row.PrecioDeCostoPromedioPonderadoOriginal = this._precioDeCostoPromedioPonderadoOriginal;
			row.PrecioDeVentaMercadoBolsaOriginal = this._precioDeVentaMercadoBolsaOriginal;
			row.PrecioDeVentaMercadoCadenaOriginal = this._precioDeVentaMercadoCadenaOriginal;
            row.PrecioDeVentaMercadoCompetenciaDirectaOriginal = this._precioDeVentaMercadoCompetenciaDirectaOriginal;
            row.UsaPrecioDeCostoReposicionOriginal = this._usaPrecioDeCostoReposicionOriginal;
            row.IdCotizacionCierrePrecioDeCostoRefOriginal = this._idCotizacionCierrePrecioDeCostoRefOriginal;
			// --------

            //Sabrina: Tarea 1071. 20110322
            /* Como los items del combo por ahora solo guardan el PrecioDeCostoRef y el PrecioDeVentaBruto, el resto de los precios los guardamos en 0.
             Mas adelante se vera si es necesario almacenar estos valores y modificar las tablas tsh_CombosDet y tsh_CombosDetListasDeprecios para que los almacenen.*/
            //German 20120522 - Tarea 0000331
            //if (this.IdCombo != null && !!this.IdCombo.Equals(string.Empty)) //Si es un ietm del combo
            if (this.IdCombo != null && !this.IdCombo.Equals(string.Empty)) //Si es un ietm del combo
            //Fin German 20120522 - Tarea 0000331
            {
                row.PrecioDeCosto = 0;
                row.PrecioNetoOriginal = 0;
                row.MaxDescuentoPorcentualOriginal = 0;
                row.MaxDescuentoOriginal = 0;
                row.PrecioDeCostoDirectoOriginal = 0;
                row.PrecioDeCostoIndirectoOriginal = 0;
                row.PrecioDeCostoReposicionOriginal = 0;
                row.PrecioDeCostoPromedioPonderadoOriginal = 0;
                //row.UsaPrecioDeCostoReposicionOriginal = this._usaPrecioDeCostoReposicionOriginal;
            }
            //Fin Sabrina: Tarea 1071. 20110322

            //Sabrina: Tarea 1074. 20110323
            row.IdCombo = this.IdCombo;
            row.Combo = this.Combo;
            //Fin Sabrina: Tarea 1074. 20110323

			data.tsa_ComprobantesDet.Addtsa_ComprobantesDetRow( row );

			tsa_ComprobantesExDataset.tsa_ComprobantesDetAuxiliaresRow rowA = data.tsa_ComprobantesDetAuxiliares.Newtsa_ComprobantesDetAuxiliaresRow();
			rowA.IdComprobante = row.IdComprobante;
			rowA.Ordinal = row.Ordinal;
			rowA.ContadorOrigen = _contadorOrigen;
			rowA.ContadorDestino = _contadorDestino;
			rowA.IdEmpresa = row.IdEmpresa;
			rowA.IdSucursal = row.IdSucursal;
			rowA.IdConexionUltimaModificacion = Security.IdConexion;
			rowA.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			rowA.Visible = this.Visible;

			/*Modificacion 08/09/2007*/
			rowA.IdOrdenReparacion = _idOrdenReparacion;
			rowA.IdInstanciaOrdenReparacion = _idInstanciaOrdenReparacion;
			rowA.IdRepuestoOrdenReparacion = _idRepuestoOrdenReparacion;
			rowA.IdTareaRealizada = _idTareaRealizada;
			rowA.IdComprobantesPredecesores = _idComprobantesPredecesores;
			rowA.IdComprobantesSucesores = _idComprobantesSucesores;
			rowA.IdTiposComprobantesPredecesores = _idTiposComprobantesPredecesores;
			rowA.IdTiposComprobantesSucesores = _idTiposComprobantesSucesores;
			rowA.IdResponsableOrigen=_idResponsableOrigen;
			rowA.Equipo=_equipo;
			rowA.OrdinalesPredecesores = _ordinalesPredecesores;
			rowA.OrdinalesSucesores = _ordinalesSucesores;

			
			data.tsa_ComprobantesDetAuxiliares.Addtsa_ComprobantesDetAuxiliaresRow( rowA );
			

			return data;

		}
		/// <summary>
		/// Relación origen/destino			
		/// Por ahora asumimos que la cantidad de origen de los items se cancela con la cantidad de destino
		/// </summary>
		private tsa_ComprobantesExDataset CommitRelacionOrigenDestino(tsa_ComprobantesExDataset data)
		{
            //German 20120307 - Tarea 0000290
            string IdComprobanteOrigen = null;
            string IdComprobanteDestino = null;
            long IdOrdinalDestino = 0;
            long IdOrdinalOrigen = 0;
            bool CierraCircuito = false;
            decimal Cantidad = 0;
            if (!this._origenMultiple)
            {
                IdComprobanteOrigen = this._idComprobanteOrigen;
                IdComprobanteDestino = this.ItemsComprobantes.ComprobanteDeVenta.IdComprobanteDestino;
                IdOrdinalDestino = this._ordinal;
                IdOrdinalOrigen = this._ordinalOrigen;
                CierraCircuito = mz.erp.businessrules.tlg_TiposComprobantesOrigenDestino.CierraCircuito(this.ItemsComprobantes.ComprobanteDeVenta.TipoComprobanteDestino);
                CierraCircuito = CierraCircuito || this._cierraCircuito;
                Cantidad = this._cantidad;
                if (!allowCopy())
                {
                    if (IdComprobanteOrigen != IdComprobanteDestino)
                    {
                        data = mz.erp.businessrules.tsa_ComprobantesEx.SetRelacionOrigenDestino(data, IdComprobanteOrigen, IdComprobanteDestino, IdOrdinalOrigen, IdOrdinalDestino, Cantidad, CierraCircuito);
                    }
                }
            }
            else
            {
                foreach (RelacionComprobanteOrigen rel in this._origenes)
                {
                    
                    IdOrdinalOrigen = rel.OrdinalOrigen;
                    IdComprobanteOrigen = rel.IdComprobanteOrigen;
                    Cantidad = rel.CantidadDestino;

                    IdComprobanteDestino = this.ItemsComprobantes.ComprobanteDeVenta.IdComprobanteDestino;
                    IdOrdinalDestino = this._ordinal;
                    CierraCircuito = mz.erp.businessrules.tlg_TiposComprobantesOrigenDestino.CierraCircuito(this.ItemsComprobantes.ComprobanteDeVenta.TipoComprobanteDestino);
                    CierraCircuito = CierraCircuito || this._cierraCircuito;
                    if (IdComprobanteOrigen != IdComprobanteDestino)
                    {
                        mz.erp.businessrules.tsa_ComprobantesEx.SetRelacionOrigenDestino(data, IdComprobanteOrigen, IdComprobanteDestino, IdOrdinalOrigen, IdOrdinalDestino, Cantidad, CierraCircuito);
                    }
                }
            }
			return data;
            //Fin German 20120307 - Tarea 0000290
		}


		/*Por ahora harcodeado Esta funcion tiene como objetivo definir si la operacion es una copia*/
		/*Por ahora se considera copia cuando el tipo de comprobante origen y destino coinciden o cuando*/
		/*son distintos pero es entre presupustos . Por ahora solo vale la copia de presupuestos*/
		private bool allowCopy()
		{
			/*
			bool ok = this.ItemsComprobantes.ComprobanteDeVenta.TipoComprobanteOrigen == this.ItemsComprobantes.ComprobanteDeVenta.TipoComprobanteDestino;
			bool ok1 = this.ItemsComprobantes.ComprobanteDeVenta.TipoComprobanteOrigen != this.ItemsComprobantes.ComprobanteDeVenta.TipoComprobanteDestino
						&& ((this.ItemsComprobantes.ComprobanteDeVenta.TipoComprobanteOrigen == "PREA" && this.ItemsComprobantes.ComprobanteDeVenta.TipoComprobanteDestino == "PREB")
							
								||(this.ItemsComprobantes.ComprobanteDeVenta.TipoComprobanteOrigen == "PREB" && this.ItemsComprobantes.ComprobanteDeVenta.TipoComprobanteDestino == "PREA"));
			return ok || ok1;
			*/
			return this.ItemsComprobantes.ComprobanteDeVenta.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoCopiaDePresupuesto");

		}
		/*/// <summary>
		/// Movimientos de Stock
		/// </summary>
		private tsa_ComprobantesExDataset CommitMovimientosDeStock(tsa_ComprobantesExDataset data)
		{
			//Movimiento de Stock			
			if(this.AfectaStock)
			{
				string IdDeposito = ComprobantesRules.Momentos_Parametros( this.ItemsComprobantes.ComprobanteDeVenta.Momento, "Deposito");
				string IdSeccion =  ComprobantesRules.Momentos_Parametros( this.ItemsComprobantes.ComprobanteDeVenta.Momento, "Seccion");

				string IdEstadoStockOrigen = string.Empty;
				string IdEstadoStockDestino = string.Empty;
				long idMomentoDeStock = tlg_TiposComprobantesOrigenDestino.GetMomento( this._idTipoComprobanteOrigen, this.ItemsComprobantes.ComprobanteDeVenta.TipoComprobanteDestino);
				Stock.GetEstados( idMomentoDeStock, ref IdEstadoStockOrigen, ref IdEstadoStockDestino );
				this._idEstadoStockDestino = IdEstadoStockDestino;
				this._idEstadoStockOrigen = IdEstadoStockOrigen;
				if ((IdDeposito != string.Empty) && (IdSeccion != string.Empty) )
				{
					data = mz.erp.businessrules.tsa_ComprobantesEx.SetMovimientosDeStock( data, Security.IdSucursal, Security.IdEmpresa, IdDeposito, IdSeccion, null,IdEstadoStockOrigen,IdEstadoStockDestino, null,this._idProducto, this._cantidad );
				}
			}
			return data;
		}*/

		
		private tsa_ComprobantesExDataset CommitDescripcionAdicional(tsa_ComprobantesExDataset data)
		{
			
			if (this.IsDescripcionChanged)
			{
				tsa_ComprobantesExDataset.tsa_ComprobanteDetalleDescripcionAdicionalRow row = data.tsa_ComprobanteDetalleDescripcionAdicional.Newtsa_ComprobanteDetalleDescripcionAdicionalRow();
				row.IdComprobante = this.ItemsComprobantes.ComprobanteDeVenta.IdComprobante;
				row.Ordinal = this.Ordinal;

				row.Descripcion = this.DescripcionLarga;
			
				row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
				row.IdConexionCreacion = Security.IdConexion;
				row.IdConexionUltimaModificacion = Security.IdConexion;

				row.IdReservado = 0;
				row.IdEmpresa = Security.IdEmpresa;
				row.IdSucursal = Security.IdSucursal;
				data.tsa_ComprobanteDetalleDescripcionAdicional.Addtsa_ComprobanteDetalleDescripcionAdicionalRow( row );
			}
			return data;
		}

		#endregion

		private void Items_OnConversionChanged(object sender, EventArgs e)
		{
			if(sender != null)
			{
				ConversionItem item = (ConversionItem)sender;
				this._cantidadAux = item.ValorConvertido;
				this._idUnidadDestinoAux = item.IdUnidadDestino;
				this._idUnidadOrigenAux = item.IdUnidadOrigen;
				this._unidadOrigenAux = item.UnidadOrigen;
				this._unidadDestinoAux = item.UnidadDestino;
				this._valorOrigenAux = item.ValorSinConvertir;
				this._valorDestinoAux = item.ValorConvertido;
			}
		}

		public void AcceptConversion()
		{
			this._cantidad= this._cantidadAux;
			this._idUnidadDestino = this._idUnidadDestinoAux;
			this._idUnidadOrigen = this._idUnidadOrigenAux;
			this._unidadOrigen = this._unidadOrigenAux;
			this._unidadDestino =this._unidadDestinoAux;
			this._valorOrigen = this._valorOrigenAux;
			this._valorDestino = this._valorDestinoAux;			
		}		
	}
}
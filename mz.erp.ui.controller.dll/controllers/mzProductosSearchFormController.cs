using System;
using System.Data;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using System.Drawing;



namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de mzProductosSearchFormController.
	/// </summary>
	public class mzProductosSearchFormController
	{
		public mzProductosSearchFormController()
		{
			
			Init();
		}
		private string _search_codigo = string.Empty;
		private string _search_codigoSec = string.Empty;
        //Cristian Tarea 935
        private string _search_proveedor = string.Empty;
        //fin Tarea 935
		private string _search_descripcion = string.Empty;
		private string _search_CampoAuxiliar1 = string.Empty;
		private string _search_CampoAuxiliar2 = string.Empty;	
		private string _search_CampoAuxiliar3 = string.Empty;
		private string _search_CampoAuxiliar4 = string.Empty;			
		private string _search_CampoAuxiliar5 = string.Empty;		
		private string _search_CampoAuxiliar6 = string.Empty;			
		private bool _activo_Search = true;
		private string _search_IdListaDePrecio = string.Empty;
		private string _search_TipoDePrecioDeCosto = string.Empty;
		private bool _allowSearchByActivo = Variables.GetValueBool("Productos.Activo.Editable");
		private string _leyendacampoAuxiliar1 = Variables.GetValueString( "Productos.CampoAuxiliar1.Etiqueta" );
		private string _leyendacampoAuxiliar2 = Variables.GetValueString( "Productos.CampoAuxiliar2.Etiqueta" );
		private string _leyendacampoAuxiliar3 = Variables.GetValueString( "Productos.CampoAuxiliar3.Etiqueta" );
		private string _leyendacampoAuxiliar4 = Variables.GetValueString( "Productos.CampoAuxiliar4.Etiqueta" );
		private string _leyendacampoAuxiliar5 = Variables.GetValueString( "Productos.CampoAuxiliar5.Etiqueta" );
		private string _leyendacampoAuxiliar6 = Variables.GetValueString( "Productos.CampoAuxiliar6.Etiqueta" );
		private string _observaciones = "";
		private string _idEstadoDeStock = Variables.GetValueString("Stock.EstadoDeStock.Default");
		private string _idVisualizacionDeStock = Variables.GetValueString("Stock.VisualizacionDeStock.Default");
		private bool _stockMinimoVisible = Variables.GetValueBool("Productos.StockInferiorMinimo.Visible");
		private string _campo = Variables.GetValueString("Productos.StockInferiorMinimo.NombreCampo");
		private string _condicion = Variables.GetValueString("Productos.StockInferiorMinimo.Condicion");
		private string _valor = Variables.GetValueString("Productos.StockInferiorMinimo.Valor");		

		private bool _solapaStockVisible = Variables.GetValueBool("Productos.Solapas.Stock.Visible");
		private bool _solapaPreciosVisible = Variables.GetValueBool("Productos.Solapas.Precios.Visible");
		private bool _solapaPreciosMediosDePagoVisible = Variables.GetValueBool("Productos.Solapas.PreciosMediosDePagoVisible.Visible");		
		private bool _solapaMedidasVisible = Variables.GetValueBool("Productos.Solapas.Medidas.Visible");
		private bool _solapaAgrupamientosVisible = Variables.GetValueBool("Productos.Solapas.Agrupamientos.Visible");
		private bool _solapaProductosAsociadosVisible = Variables.GetValueBool("Productos.Solapas.ProductosAsociados.Visible");
		private bool _solapaPreciosPorCondicionDeVenta = Variables.GetValueBool("Productos.Solapas.PreciosPorCondicionDeVenta.Visible");
		private bool _condicionesDeVentasOrdenadasBD = Variables.GetValueBool("Productos.Solapas.PreciosPorCondicionDeVenta.HabilitaOrden");
		private bool _formasDePagosOrdenadasBD = Variables.GetValueBool("Productos.Solapas.PreciosMediosDePagoVisible.HabilitaOrden");
		private bool _solapaUltimaModificacionPreciosVisible = Variables.GetValueBool("Productos.Solapas.UltimaModificacionPrecios.Visible");
		private bool _solapaImagenesVisible = Variables.GetValueBool("Productos.Solapas.Imegenes.Visible");
		private bool _solapaLinksVisible = Variables.GetValueBool("Productos.Solapas.Links.Visible");
		

		//Sabrina 20100715 - Tarea 794
		private bool _solapaListasDePreciosVisible = Variables.GetValueBool("Productos.Solapas.ListasDePrecios.Visible");
		//Fin Sabrina 20100715 - Tarea 794

        //Sabrina: Tarea 1081. 20110328
        private bool _solapaDetalleComboVisible = Variables.GetValueBool("Productos.Solapas.DetalleCombo.Visible");
        //Fin Sabrina: Tarea 1081. 20110328


		private bool _solapaBuscadorJerarquicoVisible = Variables.GetValueBool("Productos.Solapas.SolapaBuscadorJerarquico.Visible");
		private bool _buscadorJerarquicoAllowMultipleSelect = Variables.GetValueBool("Productos.BuscadorJerarquico.AllowMultipleSelect");

		private bool _solapaBuscadorCamposAuxiliaresVisible = Variables.GetValueBool("Productos.Solapas.SolapaBuscadorCamposAuxiliares.Visible");

		private bool _solapaProductosPendientesEntrega = Variables.GetValueBool("Productos.Solapas.SolapaProductosPendientesEntrega.Visible");
		
		private string _listaFormasDePagos = Variables.GetValueString("Productos.Solapas.PreciosMediosDePagoVisible.ListaDeTDCompTesoreria");
			
		private string _leyendaCodigoSec = Variables.GetValueString("Productos.CodigoSecundario.Etiqueta");

		private string _idCondicionDeVentaVisualizacionPrecio = Variables.GetValueString("Productos.Buscador.Precio.CondicionDeVentaVisualizacion");

		private System.Drawing.Color _color = System.Drawing.Color.FromName(Variables.GetValueString("Productos.StockInferiorMinimo.Color"));
		private string _leyendaPrecioNetoMO = string.Empty;
		private string _leyendaPrecioFinalMO = string.Empty;
		private string _leyendaPrecioNetoMD = string.Empty;
		private string _leyendaPrecioFinalMD = string.Empty;
		private decimal _precioNetoMO = 0;
		private decimal _precioFinalMO = 0;
		private decimal _precioNetoMD = 0;
		private decimal _precioFinalMD = 0;
		private decimal _precioFinalMDRecargoCondicionDeVenta = 0;
		private decimal _precioFinalMORecargoCondicionDeVenta = 0;
		private decimal _precioDeVentaBrutoMDRecargoCondicionDeVenta = 0;
		private decimal _precioDeVentaBrutoMORecargoCondicionDeVenta = 0;
		private Image _thumb;
		private string _link1 = "";
		private string _link2 = "";
		private string _link3 = "";
		private string _link4 = "";
		private string _link5 = "";
		private mz.erp.businessrules.comprobantes.FormasDePagos _fdp = mz.erp.businessrules.tfi_FormasDePagoEx.GetFormasDePago();
		private System.Collections.ArrayList _preciosPorCondicionDeVenta;
		private string _layoutFormasDePago = new mz.erp.ui.controllers.tfi_FormasDePagoEx(new string[] {"IdFormaDePago","Descripcion","DescripcionEntidad","Cuotas","Recargo","Agrupado","IdTDComprobante","IdEntidad","IdMoneda","IdCotizacion","ImporteConRecargo","ValorDeLaCuota"}).GetLayout( );
		private bool _searchByJerarquia = Variables.GetValueBool("BuscadorProductos.HojaBuscadorJerarquicoDefault");
		private bool _allowSearchChangeListaDePrecio = Variables.GetValueBool("BuscadorProductos.ListasDePrecios.RefrescarDatosProductos");
		private DataSet _pppDataSet;
		private mz.erp.commontypes.data.tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow _prodAuxRow;
		private mz.erp.commontypes.data.tpu_ProveedoresDataset.tpu_ProveedoresRow _proveedoresRow;

        /* Silvina 20110304 - Tarea 0000049 */
        private System.Drawing.Color _colorFecha = System.Drawing.Color.FromName(Variables.GetValueString("Productos.UltimaModificacionPrecio.Color"));
        private string _campoUltimaModificacionPrecio = Variables.GetValueString("Productos.UltimaModificacionPrecio.NombreCampo");
        private decimal _valorUltimaModificacionPrecio = Variables.GetValueDecimal("Productos.UltimaModificacionPrecio.Valor");
        private bool _ultimaModificacionPrecioVisible = Variables.GetValueBool("Productos.UltimaModificacionPrecio.Visible");
        private string _condicionFecha = Variables.GetValueString("Productos.UltimaModificacionPrecio.Condicion");
        /* Fin Silvina */

        //German 20120208 - Tarea 0000276
        private string _idBonificacion = string.Empty;
        public string IdBonificacion
        {
            get { return _idBonificacion; }
            set { _idBonificacion = value; }
        }
        
        private bool _solapaBonificaciones = Variables.GetValueBool("Productos.Solapas.Bonificaciones.Visible");
        private ArrayList _bonificacionesDet = new ArrayList();
        public ArrayList BonificacionesDet
        {
            get { return _bonificacionesDet; }
        }

        public event System.EventHandler IdBonificacionChanged;

        //German 20120208 - Tarea 0000276
		public bool HojaBuscadorJerarquicoDefault()
		{
			return Variables.GetValueBool("BuscadorProductos.HojaBuscadorJerarquicoDefault");
		}

		private string _solapaVisualizacionActiva = Variables.GetValueString("Productos.SolapasVisualizacion.Activa");
		public string SolapaVisualizacionActiva
		{
			get
			{
				if(!_solapaActiva.Equals(string.Empty))
					return _solapaVisualizacionActiva;
				else
					return "PreciosPorCondicionDeVenta";
			}
		}

		private string _solapaActiva = Variables.GetValueString("Productos.Solapas.Activa");
		public string SolapaActiva
		{
			get
			{
				if(!_solapaActiva.Equals(string.Empty))
					return _solapaActiva;
				else
					return "SolapaBuscadorGenerico";
			}
		}

		private string _solapaBuscadorGenericoControlActivo = Variables.GetValueString("Productos.Solapas.SolapaBuscadorGenerico.Control.Activo");
		public string SolapaBuscadorGenericoControlActivo
		{
			get
			{
				if(!_solapaBuscadorGenericoControlActivo.Equals(string.Empty))
					return _solapaBuscadorGenericoControlActivo;
				else
					return "Descripcion";
			}
		}

		private string _solapaSolapaBuscadorJerarquicoControlActivo = Variables.GetValueString("Productos.Solapas.SolapaBuscadorJerarquico.Control.Activo");
		public string SolapaBuscadorJerarquicoControlActivo
		{
			get
			{
				if(!_solapaSolapaBuscadorJerarquicoControlActivo.Equals(string.Empty))
					return _solapaSolapaBuscadorJerarquicoControlActivo;
				else
					return "Jerarquia1";
			}
		}


		private string _solapaBuscadorCamposAuxiliaresControlActivo = Variables.GetValueString("Productos.Solapas.SolapaBuscadorCamposAuxiliares.Control.Activo");
		public string SolapaBuscadorCamposAuxiliaresControlActivo
		{
			get
			{
				if(!_solapaBuscadorCamposAuxiliaresControlActivo.Equals(string.Empty))
					return _solapaBuscadorCamposAuxiliaresControlActivo;
				else
					return "CampoAuxiliar1";
			}
		}

		public bool AllowSearchOnListaDePrecioChange
		{
			get
			{
				return _allowSearchChangeListaDePrecio;
			}
		}

		public bool SerachByJerarquia
		{
			set{_searchByJerarquia = value;}
		}

		public bool AllowSearchByActivo
		{
			get
			{
				return _allowSearchByActivo;
			}
		}
		public bool Activo_Search
		{
			get { return _activo_Search ; }
			set { _activo_Search = value ; }
		}
		public string Codigo_Search
		{
			get { return _search_codigo ; }
			set { _search_codigo = value ; }
		}
		public string CodigoSec_Search
		{
			get { return _search_codigoSec ; }
			set { _search_codigoSec = value ; }
		}
        //Cristian Tarea 935
        public string Codigo_Proveedor
        {
            get { return _search_proveedor; }
            set { _search_proveedor = value; }
        }
        //Fin Tarea 935
		public string Descripcion_Search
		{
			get { return _search_descripcion; }
			set { _search_descripcion = value ; }
		}
		
		public string CampoAuxiliar1_Search
		{
			get { return _search_CampoAuxiliar1; }
			set { _search_CampoAuxiliar1 = value ; }
		}

		public string CampoAuxiliar2_Search
		{
			get { return _search_CampoAuxiliar2; }
			set { _search_CampoAuxiliar2 = value ; }
		}

		public string CampoAuxiliar3_Search
		{
			get { return _search_CampoAuxiliar3; }
			set { _search_CampoAuxiliar3 = value ; }
		}

		public string CampoAuxiliar4_Search
		{
			get { return _search_CampoAuxiliar4; }
			set { _search_CampoAuxiliar4 = value ; }
		}

		public string CampoAuxiliar5_Search
		{
			get { return _search_CampoAuxiliar5; }
			set { _search_CampoAuxiliar5 = value ; }
		}

		public string CampoAuxiliar6_Search
		{
			get { return _search_CampoAuxiliar6; }
			set { _search_CampoAuxiliar6 = value ; }
		}


		public string IdListaDePrecio_Search
		{
			get { return _search_IdListaDePrecio; }
			set { _search_IdListaDePrecio = value ; }
		}

		public string TipoDePrecioDeCosto_Search
		{
			get { return _search_TipoDePrecioDeCosto; }
			set { _search_TipoDePrecioDeCosto = value ; }
		}
		
		public string Observaciones
		{
			get { return _observaciones ;}
		}
		public string LeyendaCampoAuxiliar1
		{
			get { return _leyendacampoAuxiliar1 ;}
		}
		public string LeyendaCampoAuxiliar2
		{
			get { return _leyendacampoAuxiliar2 ;}
		}
		public string LeyendaCampoAuxiliar3
		{
			get { return _leyendacampoAuxiliar3 ;}
		}
		public string LeyendaCampoAuxiliar4
		{
			get { return _leyendacampoAuxiliar4 ;}
		}
		public string LeyendaCampoAuxiliar5
		{
			get { return _leyendacampoAuxiliar5 ;}
		}
		public string LeyendaCampoAuxiliar6
		{
			get { return _leyendacampoAuxiliar6 ;}
		}

		public string LeyendaCodigoSec 
		{
			get { return _leyendaCodigoSec;}
		}

		public string LayoutGrillaBusquedaJerarquica
		{
			//get { return (new mz.erp.ui.controllers.tsh_Productos( new string[] {"IdProducto","Codigo","Descripcion","PrecioDeVentaBruto","DescripcionMonedaOrigenPrecioDeVentaBruto","PrecioFinalEstimado","DescripcionMonedaOrigenPrecioDeVentaBruto","StockDisponible","CampoAuxiliar1","CampoAuxiliar2","StockAntesMinimo","StockMinimo"}).GetLayout()); }
			get { return (new mz.erp.ui.controllers.tsh_Productos( new string[] {"IdProducto","Codigo","Descripcion","PrecioDeVentaBrutoMonedaOrigenRecargoCondicionDeVenta","SimboloMonedaOrigenPrecioDeVentaBruto","PrecioFinalEstimadoMonedaOrigenRecargoCondicionDeVenta","SimboloMonedaOrigenPrecioDeVentaBruto","StockDisponible","CampoAuxiliar1","CampoAuxiliar2","StockAntesMinimo","StockMinimo"}).GetLayoutBuscadorJerarquicoProductos()); }
		}

		public string LayoutGrillaBusqueda
		{
			//get { return (new mz.erp.ui.controllers.tsh_Productos( new string[] {"IdProducto","Codigo","Descripcion","PrecioDeVentaBruto","DescripcionMonedaOrigenPrecioDeVentaBruto","PrecioFinalEstimado","DescripcionMonedaOrigenPrecioDeVentaBruto","StockDisponible","CampoAuxiliar1","CampoAuxiliar2","StockAntesMinimo","StockMinimo"}).GetLayout()); }
			get { return (new mz.erp.ui.controllers.tsh_Productos( new string[] {"IdProducto","Codigo","Descripcion","PrecioDeVentaBrutoMonedaOrigenRecargoCondicionDeVenta","SimboloMonedaOrigenPrecioDeVentaBruto","PrecioFinalEstimadoMonedaOrigenRecargoCondicionDeVenta","SimboloMonedaOrigenPrecioDeVentaBruto","StockDisponible","CampoAuxiliar1","CampoAuxiliar2","StockAntesMinimo","StockMinimo"}).GetLayoutBuscadorProductos()); }
		}
		public string LayoutDetalleJerarquia
		{
			get 
			{ 
				return (new mz.erp.ui.controllers.tsh_Productos(new string[] {"IdProducto","Codigo","Descripcion","PrecioDeVentaBrutoConImpuesto"}).GetLayout() );
			}
		}
		public string LayoutPreciosPorCondicionesDeVenta
		{
			get
			{
				return (new mz.erp.ui.controllers.tsa_CondicionesDeVentas( new string[] { "Descripcion","PorcentajeRecargo","Recargo","Importe"} ).GetCustomLayout() );
			}
		}

		public string LayoutProductosPendientesRecepcion
		{
			get
			{
				return (new mz.erp.ui.controllers.tsh_ProductosPedidosPendientes().GetLayout() );
			}
		}


		public string LayoutGrillaStock
		{
			get { return mz.erp.ui.controllers.Stock.GetLayoutStockSucursales(new string [] {"Descripcion","DescripcionDeposito", "DescripcionSeccion", "Suma"} ); }
		}
		public string LayoutFormasDePago
		{
			get { return _layoutFormasDePago; }
		}
		public bool StockMinimoVisible
		{
			get {return _stockMinimoVisible;}
		}

        public bool SolapaStockVisible 
		{
			get {return _solapaStockVisible;}
		}
		public bool SolapaPreciosVisible
		{
			get {return _solapaPreciosVisible;}
		}
		public bool SolapaPreciosMediosDePagoVisible
		{
			get {return _solapaPreciosMediosDePagoVisible;}
		}
		public bool SolapaMedidasVisible
		{
			get {return _solapaMedidasVisible;}
		}
		public bool SolapaAgrupamientosVisible 
		{
			get {return _solapaAgrupamientosVisible;}
		}
		public bool SolapaProductosAsociadosVisible 
		{
			get {return _solapaProductosAsociadosVisible;}
		}
		public bool SolapaPreciosPorCondicionDeVenta
		{
			get {return _solapaPreciosPorCondicionDeVenta; }
		}
		public bool SolapaBuscadorJerarquicoVisible
		{
			get {return _solapaBuscadorJerarquicoVisible; }
		}
		public bool BuscadorJerarquicoAllowMultipleSelect
		{
			get {return _buscadorJerarquicoAllowMultipleSelect; }
		}		
		public bool SolapaBuscadorCamposAuxiliaresVisible
		{
			get {return _solapaBuscadorCamposAuxiliaresVisible; }		
		}		
		
		public bool SolapaProductosPendientesEntrega
		{
			get {return _solapaProductosPendientesEntrega; }		
		}

		public bool SolapaUltimaModificacionPreciosVisible
		{
			get {return _solapaUltimaModificacionPreciosVisible; }		
		}

		public bool SolapaLinksVisible
		{
			get {return _solapaLinksVisible; }		
		}

		public bool SolapaImagenesVisible
		{
			get {return _solapaImagenesVisible; }		
		}

		//Sabrina 20100715 - Tarea 794
		public bool SolapaListasDePreciosVisible
		{
			get {return _solapaListasDePreciosVisible; }		
		}
		//Fin Sabrina 20100715 - Tarea 794

        //Sabrina: Tarea 1081. 20110328
        public bool SolapaDetalleComboVisible
        {
            get { return _solapaDetalleComboVisible; }
        }
        //Fin Sabrina: Tarea 1081. 20110328

        //German 20120208 - Tarea 0000276
        public bool SolapaBonificaciones
        {
            get { return _solapaBonificaciones; }
        }
        //German 20120208 - Tarea 0000276


		public string Campo 
		{
			get {return _campo;}
		}
		public string Condicion
		{
			get {return _condicion;}
		}
		public string Valor
		{
			get {return _valor;}
		}
		public System.Drawing.Color Color 
		{
			get {return _color;}
		}

        /* Silvina 20110304 - Tarea 0000049 */

        public string CondicionFecha
        {
            get { return _condicionFecha; }
        }

        public bool UltimaModificacionPrecioVisible
        {
            get { return _ultimaModificacionPrecioVisible; }
        }

        public string CampoUltimaModificacionPrecio
        {
            get { return _campoUltimaModificacionPrecio; }
        }

        public int ValorUltimaModificacionPrecio
        {
            get { return Convert.ToInt16(_valorUltimaModificacionPrecio); }
        }
        public System.Drawing.Color ColorFecha
        {
            get { return _colorFecha; }
        }
        /* Fin Silvina */

		public string LeyendaPrecioNetoMO
		{
			get {return _leyendaPrecioNetoMO; }
		}
		public string LeyendaPrecioFinalMO
		{
			get {return _leyendaPrecioFinalMO ; }
		}
		public string LeyendaPrecioNetoMD
		{
			get { return _leyendaPrecioNetoMD ;}
		}
		public string LeyendaPrecioFinalMD
		{
			get { return _leyendaPrecioFinalMD; }
		}
		
		public decimal PrecioFinalMO
		{
			get { return _precioFinalMO ; }
		}
		public decimal PrecioNetoMO
		{
			get { return _precioNetoMO ; }
		}
		public decimal PrecioFinalMDRecargoCV
		{
			get{return _precioFinalMDRecargoCondicionDeVenta;}
		}

		public decimal PrecioFinalMORecargoCV
		{
			get{return _precioFinalMORecargoCondicionDeVenta;}
		}

		public Image Thumb
		{
			get 
			{
				return _thumb;
			}
		}

		
		public string Link1
		{
			get {return _link1;	}	
		}
		public string Link2
		{
			get {return _link2;	}	
		}
		public string Link3
		{
			get {return _link3;	}	
		}
		public string Link4
		{
			get {return _link4;	}	
		}
		public string Link5
		{
			get {return _link5;	}	
		}


		public decimal PrecioDeVentaBrutoMDRecargoCondicionDeVenta
		{
			get{return _precioDeVentaBrutoMDRecargoCondicionDeVenta;}
		}


		public decimal PrecioDeVentaBrutoMORecargoCondicionDeVenta
		{
			get{return _precioDeVentaBrutoMORecargoCondicionDeVenta;}
		}


		public decimal PrecioFinalMD
		{
			get { return _precioFinalMD ; }
		}
		public decimal PrecioNetoMD
		{
			get { return _precioNetoMD ; }
		}
		public FormasDePagos PreciosSegunFormaDePago
		{
			get { return _fdp ; }
		}

//		public mz.erp.commontypes.data.tsh_ProductosPedidosPendientesDataset ProductosPedidosPendientesDataSet
		public DataSet ProductosPedidosPendientesDataSet
		{
			get { return _pppDataSet; }		
		}

		private string _fechaProximaRecepcion;
		public string FechaProximaRecepcion
		{
			get { return _fechaProximaRecepcion; }		
		}

		private string _cantProximaRecepcion;
		public string CantProximaRecepcion
		{
			get { return _cantProximaRecepcion; }		
		}

		private string _proveedorPendiente;
		public string ProveedorPendiente
		{
			get { return _proveedorPendiente; }		
		}


		public ArrayList PreciosPorCondicionDeVenta
		{
			get { return _preciosPorCondicionDeVenta; }
		}

		private System.Data.DataSet _stockDataset;
		public System.Data.DataSet DataStock
		{
			get { return _stockDataset ; }
		}


		//Sabrina 20100715 - Tarea 794
		private System.Data.DataSet _listasDePreciosDataset;
		public System.Data.DataSet DataListasDePrecios
		{
			get { return _listasDePreciosDataset; }
		}
		//Fin Sabrina 20100715 - Tarea 794

        //Sabrina: Tarea 1081. 20110328
        private System.Data.DataSet _detalleComboDataset;
        public System.Data.DataSet DetalleComboDataset
        {
            get { return _detalleComboDataset; }
        }
        //Fin Sabrina: Tarea 1081. 20110328
        
        private System.Data.DataView _dataSearch = new DataView();

		public System.Data.DataView DataSearch
		{
			get { return _dataSearch ; }
		}
		/*private System.Data.DataTable _dataSearch = new DataTable();
		public System.Data.DataTable DataSearch
		{
			get { return _dataSearch ; }
		}*/

		public System.Data.DataTable _dataHierarchy = new DataTable();
		public System.Data.DataTable DataHierarchy
		{
			get { return _dataHierarchy; }
		}

		private mz.erp.commontypes.data.tsy_TipoProductoDataset.tsy_TipoProductoDataTable _listaTiposProductos = null ;
		public DataTable ListaTiposProductos 
		{
			get{return _listaTiposProductos;}
		}

		public string KeyValueTiposProductos
		{
			get { return "IdTipoProducto" ; }
		}				
		public string KeyListTiposProductos
		{
			get { return "Descripcion" ; }
		}

		private DataTable _listaDePrecios = null;
		public System.Data.DataTable ListaDePrecios
		{
			get {return _listaDePrecios;}
		}
		public string KeyValueListaDePrecios
		{
			get { return "IdListaDePrecio" ; }
		}				
		public string KeyListListaDePrecios
		{
			get { return "Descripcion" ; }
		}

		private string _idListaDePreciosDefault = string.Empty;
		public string IdListaDePreciosDefault
		{
			get { return _idListaDePreciosDefault; }
		}

		private bool _listaDePreciosHabilitadas = Variables.GetValueBool("Productos.ListasDePrecios"); 
		public bool ListaDePreciosHabilitadas
		{
			get{return _listaDePreciosHabilitadas;}
		}

		private bool _listaTiposDeProductosHabilitados = true; 
		public bool ListaTiposDeProductosHabilitados
		{
			get{return _listaTiposDeProductosHabilitados;}
		}

		// ---- Matias - Custom - Semana 8 - Tarea 279 - 20090721
		public string _idResponsable = string.Empty;
		public string IdResponsable
		{
			get{return _idResponsable;}
			set{_idResponsable=value;}
		}

		public DateTime _fechaAltaDesde = mz.erp.businessrules.Sistema.DateTime.Now;
		public DateTime FechaAltaDesde
		{
			get{return _fechaAltaDesde;}
			set{_fechaAltaDesde=value;}
		}

		public DateTime _fechaAltaHasta = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-30);
		public DateTime FechaAltaHasta
		{
			get{return _fechaAltaHasta;}
			set{_fechaAltaHasta=value;}
		}

		private bool _buscarPorFechaAlta = false;
		public bool BuscarPorFechaAlta
		{
			get{return _buscarPorFechaAlta;}
			set{_buscarPorFechaAlta=value;}
		}

		public bool _buscarPorResponsable = false;
		public bool BuscarPorResponsable
		{
			get{return _buscarPorResponsable;}
			set{_buscarPorResponsable=value;}
		}
		// ---- FinMatias 

        /* Silvina 20110704 - Tarea 0000136 */
        private bool _permiteCambio = true;
        public bool PermiteCambio
        {
            get { return _permiteCambio; }
            set { _permiteCambio = value; }
        }
        /* Fin Silvina 20110704 - Tarea 0000136 */

		public event System.EventHandler DataSearchChanged;
		public event System.EventHandler DataDetailChanged;
		public event System.EventHandler DataDetailHierarchyChanged;
		public event System.EventHandler ValorCampoAuxiliar1Changed;
		public event System.EventHandler ValorCampoAuxiliar2Changed;
		public event System.EventHandler ValorCampoAuxiliar3Changed;
		public event System.EventHandler ValorCampoAuxiliar4Changed;
		public event System.EventHandler ValorCampoAuxiliar5Changed;
		public event System.EventHandler PrecioFinalImpuestosIncluidosChanged;
		public event System.EventHandler DescripcionChanged;

		public event System.EventHandler PrecioFinalChanged;
		public event System.EventHandler PrecioFinalMOChanged;
		public event System.EventHandler PrecioNetoMOChanged;
		public event System.EventHandler PrecioFinalMDChanged;
		public event System.EventHandler PrecioNetoMDChanged;
		public event System.EventHandler LeyendaPrecioFinalMOChanged;
		public event System.EventHandler LeyendaPrecioNetoMOChanged;
		public event System.EventHandler LeyendaPrecioFinalMDChanged;
		public event System.EventHandler LeyendaPrecioNetoMDChanged;
		public event EventHandler PrecioFinalMORecargoCVChanged;
		public event EventHandler PrecioFinalMDRecargoCVChanged;
		public event System.EventHandler UltimaModificacionPcioCostoChanged;
		public event System.EventHandler UltimaModificacionPcioVentaChanged;

				
		public void BuscarAhora()
		{			
			/*if(!_searchByJerarquia)
			{				
				DataTable tabla = (System.Data.DataTable)mz.erp.businessrules.tsh_Productos.GetListDataset(null, this._search_codigo, this._search_codigoSec, this._search_descripcion, null, null, _idCondicionDeVentaVisualizacionPrecio ).Tables[0];			
				

				DataView view = new DataView(tabla,null, _orderBy,System.Data.DataViewRowState.OriginalRows);
				_dataSearch = view;
			  
				if (DataSearchChanged != null)
				{
					DataSearchChanged( this, new System.EventArgs() );
				}
			}
			else this.NodoActual();*/

			string j1 = BuildJerarquia(_jerarquia1);
			string j2 = BuildJerarquia(_jerarquia2);
			string j3 = BuildJerarquia(_jerarquia3);
			string j4 = BuildJerarquia(_jerarquia4);
			string j5 = BuildJerarquia(_jerarquia5);
			string j6 = BuildJerarquia(_jerarquia6);
			string j7 = BuildJerarquia(_jerarquia7);
			string j8 = BuildJerarquia(_jerarquia8);

			bool[] aux = new bool[8]{_byJerarquia1, _byJerarquia2, _byJerarquia3, _byJerarquia4, _byJerarquia5, _byJerarquia6, _byJerarquia7, _byJerarquia8};
			string[] jerarquias = new string[8]{_byJerarquia1?j1:string.Empty,_byJerarquia2?j2:string.Empty,_byJerarquia3?j3:string.Empty,_byJerarquia4?j4:string.Empty,_byJerarquia5?j5:string.Empty,_byJerarquia6?j6:string.Empty,_byJerarquia7?j7:string.Empty,_byJerarquia8?j8:string.Empty };
			string[] jers = new string[8]{string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,string.Empty};
			for(int i = 0; i<8;i++)
			{
				if(aux[i])
				{
					for(int j = 0; j<8; j++)
					{
						if(jers[j] == string.Empty)
						{
							jers[j] = jerarquias[i];
							break;
						}
					}
				}
			}
			
			j1 = jers[0];
			j2 = jers[1];
			j3 = jers[2];
			j4 = jers[3];
			j5 = jers[4];
			j6 = jers[5];
			j7 = jers[6];
			j8 = jers[7];	
	
			if (!_buscarPorResponsable)
				this.IdResponsable=string.Empty;

			if (!_buscarPorFechaAlta)
			{
				this.FechaAltaDesde=DateTime.MinValue;
				this.FechaAltaHasta=DateTime.MinValue;
			}
            
			DataTable tabla;
			if(_tipoDeFormularioPadre.Equals("C"))
                //Sabrina: Tarea 1080. 20110326
                /* Silvina 20110704 - Tarea 0000136 */
                tabla = mz.erp.businessrules.tsh_ProductosEx.SearchProductosCompras(_search_codigo, _search_codigoSec, _search_descripcion, _search_CampoAuxiliar1, _search_CampoAuxiliar2,_search_CampoAuxiliar3, _search_CampoAuxiliar4, _search_CampoAuxiliar5,_search_CampoAuxiliar6, _idCondicionDeVentaVisualizacionPrecio, j1,j2,j3,j4,j5,j6,j7,j8, Security.IdSucursal, Security.IdEmpresa, _activo_Search, _search_IdListaDePrecio, _search_TipoDePrecioDeCosto, _idProveedor, _idTipoProducto, PermiteProductosCombo, PermiteCambio);
                /* Fin Silvina 20110704 - Tarea 0000136 */
                //Fin Sabrina: Tarea 1080. 20110326
			else
                //Cristian Tarea 935 20101130
                //Sabrina: Tarea 1080. 20110326
                /* Silvina 20110704 - Tarea 0000136 */
                tabla = mz.erp.businessrules.tsh_ProductosEx.SearchProductos(_search_codigo, _search_codigoSec, _search_proveedor, _search_descripcion, _search_CampoAuxiliar1, _search_CampoAuxiliar2, _search_CampoAuxiliar3, _search_CampoAuxiliar4, _search_CampoAuxiliar5, _search_CampoAuxiliar6, _idCondicionDeVentaVisualizacionPrecio, j1, j2, j3, j4, j5, j6, j7, j8, Security.IdSucursal, Security.IdEmpresa, _activo_Search, _search_IdListaDePrecio, _idTipoProducto, _idResponsable, _fechaAltaDesde, _fechaAltaHasta, PermiteProductosCombo, PermiteCambio);
                /* Fin Silvina 20110704 - Tarea 0000136 */
                //Fin Sabrina: Tarea 1080. 20110326
                //Fin Tarea 935 

			DataView view = new DataView(tabla,null, _orderBy,System.Data.DataViewRowState.OriginalRows);
			_dataSearch = view;
			  
			if (DataSearchChanged != null)
			{
				DataSearchChanged( this, new System.EventArgs() );
			}
		}
		
		private string _codigo = null;
		public string Codigo 
		{
			get {return _codigo ; }
		}

		private string _idListaDePrecio = null;
		public string IdListaDePrecio 
		{
			get {
                /* Silvina 20100920 - Tarea 840 */
                if (_idListaDePrecio == null)
                    _idListaDePrecio = Variables.GetValueString("Productos.IdListaDePreciosDefault",null);
                /* Fin Silvina */
                return _idListaDePrecio; 
            }
			set {_idListaDePrecio = value;}

		}
		
		private string _tipoDePrecioDeCosto = null;
		public string TipoDePrecioDeCosto 
		{
			get {return _tipoDePrecioDeCosto; }
			set {_tipoDePrecioDeCosto = value;}

		}

		private string _idTipoProducto = string.Empty;
		public string IdTipoProducto
		{
			get{return _idTipoProducto;}
			set{_idTipoProducto = value;}
		}

        //Sabrina: Tarea 1080. 20110326
        private bool _permiteProductosCombo = true;
        public bool PermiteProductosCombo
        {
            get { return _permiteProductosCombo; }
            set { _permiteProductosCombo = value; }

        }
        //Fin Sabrina: Tarea 1080. 20110326

        //Sabrina: Tarea 1081. 20110328
        private bool _esCombo = false;
        public bool EsCombo
        {
            get { return _esCombo; }
        }
        //Fin Sabrina: Tarea 1081. 20110328

		public void VerDetalle( System.Data.DataRowView _dataRowSelected )
		{
			if (_dataRowSelected != null)
			{
				_codigo = Convert.ToString( _dataRowSelected["Codigo"] );
				_descripcion = Convert.ToString(_dataRowSelected["Descripcion"]);
				_observaciones = Convert.ToString(_dataRowSelected["Observaciones"]);
				_valorCampoAuxiliar1 = Convert.ToString(_dataRowSelected["CampoAuxiliar1"]);
				_valorCampoAuxiliar2 = Convert.ToString(_dataRowSelected["CampoAuxiliar2"]);
				_valorCampoAuxiliar3 = Convert.ToString(_dataRowSelected["CampoAuxiliar3"]);
				_valorCampoAuxiliar4 = Convert.ToString(_dataRowSelected["CampoAuxiliar4"]);
				_valorCampoAuxiliar5 = Convert.ToString(_dataRowSelected["CampoAuxiliar5"]);
				_valorCampoAuxiliar6 = Convert.ToString(_dataRowSelected["CampoAuxiliar6"]);
				_precioFinalImpuestosIncludos = Convert.ToDecimal ( _dataRowSelected["PrecioDeVentaBrutoConImpuesto"]	);
				_precioFinal = Convert.ToDecimal ( _dataRowSelected["PrecioDeVentaBruto"] );
				_precioFinalMO = Convert.ToDecimal( _dataRowSelected["PrecioDeVentaBrutoConImpuesto"] );
				_precioNetoMO = Convert.ToDecimal( _dataRowSelected[ "PrecioDeVentaBruto"] );
				_precioFinalMD = Convert.ToDecimal ( _dataRowSelected["PrecioFinalEstimadoMonedaDestino"] );

				_precioFinalMDRecargoCondicionDeVenta = Convert.ToDecimal ( _dataRowSelected["PrecioFinalEstimadoMonedaDestinoRecargoCondicionDeVenta"] );
				_precioFinalMORecargoCondicionDeVenta = Convert.ToDecimal ( _dataRowSelected["PrecioFinalEstimadoMonedaOrigenRecargoCondicionDeVenta"] );
				_precioDeVentaBrutoMDRecargoCondicionDeVenta = Convert.ToDecimal( _dataRowSelected["PrecioDeVentaBrutoMonedaDestinoRecargoCondicionDeVenta"] );
				_precioDeVentaBrutoMORecargoCondicionDeVenta = Convert.ToDecimal( _dataRowSelected["PrecioDeVentaBrutoMonedaOrigenRecargoCondicionDeVenta"] );
				_precioNetoMD = Convert.ToDecimal( _dataRowSelected["PrecioDeVentaBrutoMonedaDestino"] );
				_leyendaPrecioFinalMO = Convert.ToString( _dataRowSelected["DescripcionMonedaOrigenPrecioDeVentaBruto"] );
				_leyendaPrecioNetoMO = Convert.ToString( _dataRowSelected["DescripcionMonedaOrigenPrecioDeVentaBruto"] );
				_leyendaPrecioFinalMD = Convert.ToString( _dataRowSelected["DescripcionMonedaDestino"] );
				_leyendaPrecioNetoMD = Convert.ToString( _dataRowSelected["DescripcionMonedaDestino"] );				

				if(_dataRowSelected["FechaUltimaModificacionPrecioDeCosto"] != null && _dataRowSelected["FechaUltimaModificacionPrecioDeCosto"] != System.DBNull.Value)
                    _ultimaModificacionPcioCosto = Convert.ToDateTime(_dataRowSelected["FechaUltimaModificacionPrecioDeCosto"]);
				else
					_ultimaModificacionPcioCosto = DateTime.MinValue;

				if(_dataRowSelected["FechaUltimaModificacionPrecioDeVenta"] != null && _dataRowSelected["FechaUltimaModificacionPrecioDeVenta"] != System.DBNull.Value)
					_ultimaModificacionPcioVenta = Convert.ToDateTime(_dataRowSelected["FechaUltimaModificacionPrecioDeVenta"]);
				else
					_ultimaModificacionPcioVenta = DateTime.MinValue;
				
				_fdp = mz.erp.businessrules.tfi_FormasDePagoEx.GetFormasDePago(_precioFinalMD, _listaFormasDePagos);
				if(_formasDePagosOrdenadasBD)
					_fdp.SortByOrden();
					
				_preciosPorCondicionDeVenta = mz.erp.businessrules.tsa_CondicionesDeVentas.RecargosPorCondicionesDeVenta( _precioFinalMD , _condicionesDeVentasOrdenadasBD);

				_pppDataSet = mz.erp.businessrules.tsh_ProductosPedidosPendientes.GetList( Convert.ToString( _dataRowSelected["IdProducto"] ) );

				if ( _pppDataSet.Tables[0].Rows.Count > 0 )
                    _prodAuxRow = mz.erp.businessrules.tsh_ProductosAuxiliares.GetByPk( Convert.ToString( _dataRowSelected["IdProducto"] ) );
				else 
					_prodAuxRow = null;
				
				if ( _prodAuxRow != null )
				{
					_fechaProximaRecepcion = Convert.ToString(_prodAuxRow["FechaRecepcion"]);
					_cantProximaRecepcion = Convert.ToString(_prodAuxRow["Cantidad"]);
					_proveedoresRow = mz.erp.businessrules.tpu_Proveedores.GetByPk( Convert.ToString(_prodAuxRow["IdProveedor"]) );
					if ( _proveedoresRow != null )
						_proveedorPendiente = Convert.ToString(_proveedoresRow["Nombre"]);									
				}
				else 
				{
					_proveedorPendiente = String.Empty;
					_cantProximaRecepcion = String.Empty;
					_fechaProximaRecepcion = String.Empty;                    
				}
				
				string ListaDeVisualizaciones = Variables.GetValueString("Productos.Solapas.Stock.ListaVisualizacionesDeStock");
				_stockDataset = mz.erp.businessrules.tlg_Stock.GetList(Convert.ToString(_dataRowSelected["IdProducto"]),ListaDeVisualizaciones);					
				this._thumb = tsh_ProductosAuxiliares.GetThumb(Convert.ToString(_dataRowSelected["IdProducto"]));
				this._link1 = Convert.ToString(_dataRowSelected["Link1"]);
				this._link2 = Convert.ToString(_dataRowSelected["Link2"]);
				this._link3 = Convert.ToString(_dataRowSelected["Link3"]);
				this._link4 = Convert.ToString(_dataRowSelected["Link4"]);
				this._link5 = Convert.ToString(_dataRowSelected["Link5"]);
				_idListaDePrecio = Convert.ToString(_dataRowSelected["IdListaDePrecio"]);
				if(_tipoDeFormularioPadre.Equals("C"))
                    _tipoDePrecioDeCosto = Convert.ToString(_dataRowSelected["TipoDePrecioDeCosto"]);
				//Sabrina 20100715 - Tarea 794
				_listasDePreciosDataset = tsh_ProductosListasDePrecios.SearchEx(Convert.ToString(_dataRowSelected["IdProducto"]), _idCondicionDeVentaVisualizacionPrecio);
				//Fin Sabrina 20100715 - Tarea 794

                //Sabrina: Tarea 1081. 20110328
                _esCombo = Convert.ToBoolean(_dataRowSelected["EsCombo"]);
                if (_esCombo)
                    _detalleComboDataset = tsh_CombosDet.SearchEx(Convert.ToString(_dataRowSelected["IdProducto"]));
                else
                    _detalleComboDataset = new DataSet();
                //Fin Sabrina: Tarea 1081. 20110328
                //German 20120208 - Tarea 0000276
                _idBonificacion = Convert.ToString(_dataRowSelected["IdBonificacion"]);
                Bonificacion BonificacionProducto = new Bonificacion();
                BonificacionProducto.IdBonificacion = IdBonificacion;
                BonificacionProducto.CargarDetalle();
                BonificacionProducto.setPrecioFinalProducto(_precioFinalMD);

                _bonificacionesDet = BonificacionProducto.BonificacionesDetalle;
                //German 20120208 - Tarea 0000276

            }

			CallRefresh();
		}
		
		private void CallRefresh()
		{
			if (ValorCampoAuxiliar1Changed != null)
			{
				ValorCampoAuxiliar1Changed( this, new System.EventArgs() );
			}
			if (ValorCampoAuxiliar2Changed != null)
			{
				ValorCampoAuxiliar2Changed( this, new System.EventArgs() );
			}
			if (ValorCampoAuxiliar3Changed != null)
			{
				ValorCampoAuxiliar3Changed( this, new System.EventArgs() );
			}
			if (ValorCampoAuxiliar4Changed != null)
			{
				ValorCampoAuxiliar4Changed( this, new System.EventArgs() );
			}
			if (ValorCampoAuxiliar5Changed != null)
			{
				ValorCampoAuxiliar5Changed( this, new System.EventArgs() );
			}
			if (PrecioFinalImpuestosIncluidosChanged != null)
			{
				PrecioFinalImpuestosIncluidosChanged( this, new System.EventArgs() );
			}
			if (DescripcionChanged != null)
			{
				DescripcionChanged( this, new System.EventArgs() );
			}
			if (DataDetailChanged != null)
			{
				DataDetailChanged( this, new System.EventArgs() );
			}
			if (PrecioFinalChanged != null)
			{
				PrecioFinalChanged( this, new System.EventArgs() );
			}
			if (PrecioFinalMOChanged != null)
			{
				PrecioFinalMOChanged( this, new System.EventArgs() );
			}	 
			if (PrecioNetoMOChanged != null)
			{
				PrecioNetoMOChanged( this, new System.EventArgs ());
			}
			if (PrecioFinalMDChanged != null)
			{
				PrecioFinalMDChanged ( this,new System.EventArgs ());
			}
			if (PrecioNetoMDChanged != null)
			{
				PrecioNetoMDChanged ( this,new System.EventArgs () );
			}
			if (LeyendaPrecioFinalMOChanged != null)
			{
				LeyendaPrecioFinalMOChanged( this,new System.EventArgs());
			}
			if (LeyendaPrecioNetoMOChanged != null)
			{
				LeyendaPrecioNetoMOChanged( this, new System.EventArgs());
			}
			if (LeyendaPrecioFinalMDChanged != null)
			{
				LeyendaPrecioFinalMDChanged( this, new System.EventArgs());
			}
			if (LeyendaPrecioNetoMDChanged != null)
			{
				LeyendaPrecioNetoMDChanged( this,new System.EventArgs());
			}
			if(PrecioFinalMORecargoCVChanged != null)
				PrecioFinalMORecargoCVChanged(this, new EventArgs());
			
			if(PrecioFinalMDRecargoCVChanged != null)
				PrecioFinalMDRecargoCVChanged(this, new EventArgs());

			if (UltimaModificacionPcioCostoChanged != null)
			{
				UltimaModificacionPcioCostoChanged( this, new System.EventArgs() );
			}

			if (UltimaModificacionPcioVentaChanged != null)
			{
				UltimaModificacionPcioVentaChanged( this, new System.EventArgs() );
			}
            //German 20120208 - Tarea 0000276
            if (IdBonificacionChanged != null)
                IdBonificacionChanged(this, EventArgs.Empty);
            //German 20120208 - Tarea 0000276

		}
		private string _orderBy = Variables.GetValueString("Productos.Busquedas.OrderBy");
		private decimal _precioFinalImpuestosIncludos = 0;
		private decimal _precioFinal = 0;
		private string _valorCampoAuxiliar1 = string.Empty;
		private string _valorCampoAuxiliar2 = string.Empty;
		private string _valorCampoAuxiliar3 = string.Empty;
		private string _valorCampoAuxiliar4 = string.Empty;
		private string _valorCampoAuxiliar5 = string.Empty;
		private string _valorCampoAuxiliar6 = string.Empty;
		private ArrayList _jerarquia1 = new ArrayList();
		private ArrayList _jerarquia2 = new ArrayList();
		private ArrayList _jerarquia3 = new ArrayList();
		private ArrayList _jerarquia4 = new ArrayList();
		private ArrayList _jerarquia5 = new ArrayList();		
		private ArrayList _jerarquia6 = new ArrayList();
		private ArrayList _jerarquia7 = new ArrayList();
		private ArrayList _jerarquia8 = new ArrayList();

		private bool _byJerarquia1 = false;
		private bool _byJerarquia2 = false;
		private bool _byJerarquia3 = false;
		private bool _byJerarquia4 = false;
		private bool _byJerarquia5 = false;
		private bool _byJerarquia6 = false;
		private bool _byJerarquia7 = false;
		private bool _byJerarquia8 = false;

		private string _descripcion = string.Empty;

		private DateTime _ultimaModificacionPcioCosto = DateTime.MinValue;
		private DateTime _ultimaModificacionPcioVenta = DateTime.MinValue;

		public bool ByJerarquia1
		{
			get{return _byJerarquia1;}
			set{_byJerarquia1 = value;}
		}

		public bool ByJerarquia2
		{
			get{return _byJerarquia2;}
			set{_byJerarquia2 = value;}
		}
		public bool ByJerarquia3
		{
			get{return _byJerarquia3;}
			set{_byJerarquia3 = value;}
		}
		public bool ByJerarquia4
		{
			get{return _byJerarquia4;}
			set{_byJerarquia4 = value;}
		}
		public bool ByJerarquia5
		{
			get{return _byJerarquia5;}
			set{_byJerarquia5 = value;}
		}
		public bool ByJerarquia6
		{
			get{return _byJerarquia6;}
			set{_byJerarquia6 = value;}
		}
		public bool ByJerarquia7
		{
			get{return _byJerarquia7;}
			set{_byJerarquia7 = value;}
		}
		public bool ByJerarquia8
		{
			get{return _byJerarquia8;}
			set{_byJerarquia8 = value;}
		}

		public ArrayList Jerarquia1
		{
			get{return _jerarquia1;}
			set{_jerarquia1 = value;}
		}
		public ArrayList Jerarquia2
		{
			get{return _jerarquia2;}
			set{_jerarquia2 = value;}
		}
		public ArrayList Jerarquia3
		{
			get{return _jerarquia3;}
			set{_jerarquia3 = value;}
		}
		public ArrayList Jerarquia4
		{
			get{return _jerarquia4;}
			set{_jerarquia4 = value;}
		}
		public ArrayList Jerarquia5
		{
			get{return _jerarquia5;}
			set{_jerarquia5 = value;}
		}
		public ArrayList Jerarquia6
		{
			get{return _jerarquia6;}
			set{_jerarquia6 = value;}
		}
		public ArrayList Jerarquia7
		{
			get{return _jerarquia7;}
			set{_jerarquia7 = value;}
		}
		public ArrayList Jerarquia8
		{
			get{return _jerarquia8;}
			set{_jerarquia8 = value;}
		}

		public string ValorCampoAuxiliar1
		{
			get { return _valorCampoAuxiliar1 ; }
		}
		public string ValorCampoAuxiliar2
		{
			get { return _valorCampoAuxiliar2 ;}
		}
		public string ValorCampoAuxiliar3
		{
			get { return _valorCampoAuxiliar3; }
		}
		public string ValorCampoAuxiliar4
		{
			get { return _valorCampoAuxiliar4; }
		}
		public string ValorCampoAuxiliar5
		{
			get { return _valorCampoAuxiliar5; }
		}
		public string ValorCampoAuxiliar6
		{
			get { return _valorCampoAuxiliar6; }
		}
		public decimal PrecioFinalImpuestosIncluidos
		{
			get { return _precioFinalImpuestosIncludos; }
		}
		public decimal PrecioFinal
		{
			get { return _precioFinal; }
		}

		public string Descripcion
		{
			get { return _descripcion ; }
		}

		public DateTime UltimaModificacionPcioCosto
		{
			get { return _ultimaModificacionPcioCosto; }
		}
		

		public DateTime UltimaModificacionPcioVenta
		{
			get { return _ultimaModificacionPcioVenta; }
		}
		
		private bool _ver_InfAdicional_Stock = true;
		private bool _ver_InfAdicional_Agrupamientos = false;
		private bool _ver_InfAdicional_Medidas = false;
		private bool _ver_InfAdicional_ProductosAsociados = false;
		public bool VerInfAdicional_Stock
		{
			get { return _ver_InfAdicional_Stock ; }
		}
		public bool VerInfAdicional_Agrupamientos
		{
			get { return _ver_InfAdicional_Agrupamientos; }
		}
		public bool VerInfAdicional_Medidas
		{
			get { return _ver_InfAdicional_Medidas; }
		}
		public bool VerInfAdicional_ProductosAsociados
		{
			get { return _ver_InfAdicional_ProductosAsociados; }
		}

		public void NodoExpandir(Infragistics.Win.UltraWinTree.UltraTreeNode NodoPadre)
		{
			
			mz.erp.ui.controllers.tsh_JerarquiaAgrupProd.HijosYNietos( NodoPadre );
		}

/*		private string BuildJerarquia(ArrayList je)
		{
			if(je.Count > 0)
			{
				ItemJerarquia it = (ItemJerarquia) je[0];
				return it.NodeKeyPath;
			}
			return string.Empty;
		}*/
		private string BuildJerarquia(ArrayList je)
		{
			string jerarquias = "";
			ArrayList array = new ArrayList();
			if(je.Count > 0)
			{
				foreach (object item in je)
				{
					ItemJerarquia it = (ItemJerarquia) item;
					array.Add(it.NodeKeyPath);
				}				
				jerarquias = systemframework.Util.PackString(array);
				
			}
			return jerarquias;
		}


		private void NodoActual()
		{						
			string j1 = BuildJerarquia(_jerarquia1);
			string j2 = BuildJerarquia(_jerarquia2);
			string j3 = BuildJerarquia(_jerarquia3);
			string j4 = BuildJerarquia(_jerarquia4);
			string j5 = BuildJerarquia(_jerarquia5);
			string j6 = BuildJerarquia(_jerarquia6);
			string j7 = BuildJerarquia(_jerarquia7);
			string j8 = BuildJerarquia(_jerarquia8);

			bool[] aux = new bool[8]{_byJerarquia1, _byJerarquia2, _byJerarquia3, _byJerarquia4, _byJerarquia5, _byJerarquia6, _byJerarquia7, _byJerarquia8};
			string[] jerarquias = new string[8]{_byJerarquia1?j1:string.Empty,_byJerarquia2?j2:string.Empty,_byJerarquia3?j3:string.Empty,_byJerarquia4?j4:string.Empty,_byJerarquia5?j5:string.Empty,_byJerarquia6?j6:string.Empty,_byJerarquia7?j7:string.Empty,_byJerarquia8?j8:string.Empty };
			string[] jers = new string[8]{string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,string.Empty,string.Empty};
			for(int i = 0; i<8;i++)
			{
				if(aux[i])
				{
					for(int j = 0; j<8; j++)
					{
						if(jers[j] == string.Empty)
						{
							jers[j] = jerarquias[i];
							break;
						}
					}
				}
			}
			
			j1 = jers[0];
			j2 = jers[1];
			j3 = jers[2];
			j4 = jers[3];
			j5 = jers[4];
			j6 = jers[5];
			j7 = jers[6];
			j8 = jers[7];
			this._dataHierarchy = mz.erp.businessrules.tsh_ProductosEx.SearchProductByJerarquia(j1,j2,j3,j4,j5,j6,j7,j8, Security.IdSucursal, Security.IdEmpresa);
			if (DataDetailHierarchyChanged != null)
			{
				DataDetailHierarchyChanged( this, new System.EventArgs() );
			}

		}

		public void NodoActual(Infragistics.Win.UltraWinTree.UltraTreeNode Nodo)
		{
			_key = Nodo.Key;
			NodoActualDetalle( Nodo );
		}
		public void NodoActualDetalle(Infragistics.Win.UltraWinTree.UltraTreeNode Nodo)
		{
			string _jerarquia = GetHierarchy( Nodo, string.Empty );
			this._dataHierarchy = mz.erp.businessrules.tsh_ProductosEx.SearchProductByJerarquia(_jerarquia, Security.IdSucursal, Security.IdEmpresa);
			if (DataDetailHierarchyChanged != null)
			{
				DataDetailHierarchyChanged( this, new System.EventArgs() );
			}
		}
		private string GetHierarchy(Infragistics.Win.UltraWinTree.UltraTreeNode Nodo, string aux)
		{
			if(Nodo.IsRootLevelNode)
				return aux;
			else
				return GetHierarchy(Nodo.Parent, Nodo.Key + aux);

		}

		private string _key = String.Empty;
		public string Key
		{
			set { _key = value ; }
			get { return _key; }
		}
		private void Init() 
		{
			InitData();
		}	

		private void InitData()
		{
            SetCombosData();
		}

		private void SetCombosData()
		{
			_listaDePrecios = businessrules.tsh_ListasDePrecios.GetList().tsh_ListasDePrecios;
			_idListaDePreciosDefault = businessrules.tsh_ListasDePrecios.GetDefault().IdListaDePrecio;	
			_listaTiposProductos = mz.erp.businessrules.tsy_TipoProducto.GetList().tsy_TipoProducto;
			mz.erp.commontypes.data.tsy_TipoProductoDataset.tsy_TipoProductoRow row =  _listaTiposProductos.Newtsy_TipoProductoRow();
			mz.erp.businessrules.tsy_TipoProducto.SetRowDefaultValues(row);
			row.IdTipoProducto = "";
			row.Descripcion = "";
			_listaTiposProductos.Addtsy_TipoProductoRow(row);
		
		}
		
		private string _tipoDePrecioDeCostoDefault = string.Empty;
		public string TipoDePrecioDeCostoDefault
		{
			get { return _tipoDePrecioDeCostoDefault; }
		}

		private ArrayList _tiposDePrecioDeCosto;
		public ArrayList TiposDePrecioDeCosto
		{
			get {return _tiposDePrecioDeCosto;}
		}

		public string _taskName = "";
		public string _processName = "";
		//esta variable indica si el control esta en un form de compras (C) o ventas (V)
		private string _tipoDeFormularioPadre = "V";
		public void SetProcess(string ProcessName, string TaskName, string TipoDeFormularioPadre)
		{
			_processName = ProcessName;
			_taskName = TaskName;
			_tipoDeFormularioPadre = TipoDeFormularioPadre;
			_tipoDePrecioDeCostoDefault = Variables.GetValueString(_processName, _taskName, "PrecioDeCosto.Origen");	
			if(_tipoDePrecioDeCostoDefault.Equals(string.Empty))
				_tipoDePrecioDeCostoDefault = Variables.GetValueString("Productos.PrecioDeCosto.Origen");

			_idTipoProducto = Variables.GetValueString(_processName, _taskName, "Busquedas.TipoDeProducto");
			if(_idTipoProducto.Equals(string.Empty))
				_idTipoProducto = Variables.GetValueString("Productos.Busquedas.TipoDeProducto");
			_listaTiposDeProductosHabilitados = Variables.GetValueBool(_processName, _taskName, "Busquedas.PermiteFiltroTipoDeProducto", "Productos.Busquedas.PermiteFiltroTipoDeProducto");

		}

        private string _idProveedor = "";
		public void SetIdProveedor(string IdProveedor)
		{
			_idProveedor = IdProveedor;
			if(IdProveedor == null || IdProveedor.Equals(string.Empty))
			{
				_tiposDePrecioDeCosto = new ArrayList();
				_tiposDePrecioDeCosto.Add("Precio de Costo");
			}
			else
			{
				_tiposDePrecioDeCosto = new ArrayList();
				_tiposDePrecioDeCosto.Add("Precio de Lista Proveedor");
				_tiposDePrecioDeCosto.Add("Ultima Compra Proveedor");
				_tiposDePrecioDeCosto.Add("Precio de Costo");
			}
		}

		public string GetProcessName()
		{
			return _processName;
		}

		public string GetTaskName()
		{
			return _taskName;
		}


	}
}

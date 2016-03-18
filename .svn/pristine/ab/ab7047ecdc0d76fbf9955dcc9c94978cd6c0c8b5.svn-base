using System;
using mz.erp.businessrules;
using System.Data;
using mz.erp.commontypes.CommonInterfaces;
using mz.erp.commontypes;
using System.Collections;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// La rompi y QQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQ
	/// Descripción breve de IngresarPrecioProductoController.
	/// </summary>
	public class IngresarPrecioProductoController : ITaskController, IObservable, IObserver	
	{
		
		#region Constructores

		/*
		public IngresarPrecioProductoController(string CodigoProducto)
		{
			_brClass = new IngresarPrecioProducto(CodigoProducto);
			Init();
		}
		*/

		public IngresarPrecioProductoController(IngresarPrecioProducto brClass)
		{
			_brClass = brClass;
			Init();
		}

		#endregion

		#region Variables Privadas

		private IngresarPrecioProducto _brClass;
		private string _leyendaFormulario;
		private string _layoutDetalle = string.Empty;
		private bool _allowEditPrecioDeCostoRef = false;
		private bool _allowEditPrecioDeCostoMonedaProveedor = true;
		private bool _allowRemoveItems = false;
		private bool _configuracionBasica = false;
		private object _productoABorrar = null;
		private businessrules.ListaDePreciosProveedoresItem _listaDePreciosProveedoresItemABorrar = null;
		private bool _allowSeleccionMultiple = false;

		#endregion

		#region Propiedades


        //German 20120522 - Tarea 0000333

        public bool NoTrasladaSiempreCambioPrecioDeCompraAPrecioDeCostoReposicion
        {
            get { return _brClass.NoTrasladaSiempreCambioPrecioDeCompraAPrecioDeCostoReposicion; }

        }

        public bool PreguntaTrasladaCambioPrecioDeCompraAPrecioDeCostoReposicion
        {
            get { return _brClass.PreguntaTrasladaCambioPrecioDeCompraAPrecioDeCostoReposicion; }

        }

        //Fin German 20120522 - Tarea 0000333
        

		public bool ListaDePreciosHabilitadas
		{
			get{return _brClass.ListaDePreciosHabilitadas;}
		}

		public bool UsaPrecioDeListaProveedor
		{
			get{return _brClass.UsaPrecioDeListaProveedor;}
		}

		public bool PrecioDeVentaAfectaMac
		{
			get{return _brClass.PrecioDeVentaAfectaMac;}
		}

		public bool HabilitaContenedorPrecioListaProveedor
		{
            //German 20110309 - tarea 0000038
			/*
            get{return !_brClass.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia") 
					&& !_brClass.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior");}
             * */
            get
            {
                return Workflow.NOEsProcesoDeConfirmacionDePrecios(_brClass.GetProcessManagerParent().Process.ProcessName);
            }
            //Fin German 20110309 - tarea 0000038
            
		}

		public bool HabilitaTrasladarPrecioDeListaFinal
		{
			get{return _brClass.HabilitaTrasladarPrecioDeListaFinal;}
		}

		public bool AllowSeleccionMultiple
		{
			get{return _allowSeleccionMultiple;}
			
		}

		public bool SeleccionMultiple
		{
			get{return _brClass.SeleccionMultiple;}
			set
			{
				_brClass.SeleccionMultiple = value;
				Seleccionar(false);
			}
		}


		public decimal PrecioDeListaConImpuestosMonedaReferencia
		{
			get{return _brClass.PrecioDeListaConImpuestosMonedaReferencia;}
			set{_brClass.PrecioDeListaConImpuestosMonedaReferencia = value;}
		}

		public bool ConfiguracionBasica
		{
			get{return _configuracionBasica;}
		}

		public bool AllowRemoveItems
		{
			get{return _allowRemoveItems;}
		}
		public bool AllowEditPrecioDeCostoRef
		{
			get{return _allowEditPrecioDeCostoRef;}
		}
		public bool AllowEditPrecioDeCostoMonedaProveedor
		{
			get{return _allowEditPrecioDeCostoMonedaProveedor;}
		}

		public string IdFuenteDeCambioProductoPrecioDeCosto
		{
			get{return _brClass.IdFuenteDeCambioProductoPrecioDeCosto;}
		}

		public decimal PrecioDeCostoAnteriorMonedaProducto
		{
			get
			{
				return _brClass.PrecioDeCostoAnteriorMonedaProducto;
				
			}

		}

		public string SimboloMonedaDescuentoMaximo
		{
			get{return _brClass.SimboloMonedaDescuentoMaximo;}
		}

		public decimal Coeficiente1
		{
			get{return _brClass.Coeficiente1;}
		}

		public decimal Coeficiente2
		{
			get{return _brClass.Coeficiente2;}
		}
		public decimal Coeficiente3
		{
			get{return _brClass.Coeficiente3;}
		}

		public decimal Coeficiente4
		{
			get{return _brClass.Coeficiente4;}
		}
		public decimal Coeficiente5
		{
			get{return _brClass.Coeficiente5;}
		}
	
		//--- COSTOS EN MONEDA---------------------
		public decimal CostoIndirecto1
		{
			get{return _brClass.CostoIndirecto1;}
			set{_brClass.CostoIndirecto1 = value;}
		}

		public decimal CostoIndirecto2
		{
			get{return _brClass.CostoIndirecto2;}
			set{_brClass.CostoIndirecto2 = value;}
		}
		public decimal CostoIndirecto3
		{
			get{return _brClass.CostoIndirecto3;}
			set{_brClass.CostoIndirecto3 = value;}
		}

		public decimal CostoIndirecto4
		{
			get{return _brClass.CostoIndirecto4;}
			set{_brClass.CostoIndirecto4 = value;}
		}

		public decimal CostoIndirecto5
		{
			get{return _brClass.CostoIndirecto5;}
			set{_brClass.CostoIndirecto5 = value;}
		}

		public decimal CostoIndirecto6
		{
			get{return _brClass.CostoIndirecto6;}
			set{_brClass.CostoIndirecto6 = value;}
		}

		public decimal CostoIndirecto7
		{
			get{return _brClass.CostoIndirecto7;}
			set{_brClass.CostoIndirecto7 = value;}
		}
		public decimal CostoIndirecto8
		{
			get{return _brClass.CostoIndirecto8;}
			set{_brClass.CostoIndirecto8 = value;}
		}

		public decimal CostoIndirecto9
		{
			get{return _brClass.CostoIndirecto9;}
			set{_brClass.CostoIndirecto9 = value;}
		}

		public decimal CostoIndirecto10
		{
			get{return _brClass.CostoIndirecto10;}
			set{_brClass.CostoIndirecto10 = value;}
		}
		//-----------------------------------------

		//Sabrina: tarea 56
		/*public decimal CostoIndirectoTotal
		{
			get{return _brClass.CostoIndirectoTotal;}			
		}*/

		public decimal PrecioDeCostoIndirecto
		{
			get{return _brClass.PrecioDeCostoIndirecto;}			
		}

		public decimal PrecioDeCostoReposicion
		{
			get{return _brClass.PrecioDeCostoReposicion;}			
			set{_brClass.PrecioDeCostoReposicion = value;}			
		}

		public decimal PrecioDeCostoPromedioPonderadoAnterior
		{
			get{return _brClass.PrecioDeCostoPromedioPonderadoAnterior;}
		}

		public decimal PrecioDeCostoPromedioPonderado
		{
			get{return _brClass.PrecioDeCostoPromedioPonderado;}			
			set{_brClass.PrecioDeCostoPromedioPonderado = value;}			
		}

		public bool UsaPrecioDeCostoReposicion
		{
			get{return _brClass.UsaPrecioDeCostoReposicion;}			
			set{_brClass.UsaPrecioDeCostoReposicion = value;}			
		}

		private bool _permiteModificarPrecioDeCostoPromedioPonderado = false;
		public bool PermiteModificarPrecioDeCostoPromedioPonderado
		{
			get{return _permiteModificarPrecioDeCostoPromedioPonderado;}			
		}

		private bool _permiteModificarPrecioDeCostoReposicion = true;
		public bool PermiteModificarPrecioDeCostoReposicion
		{
			get{return _permiteModificarPrecioDeCostoReposicion;}			
		}
		
		private bool _permiteModificarUsaPrecioDeCostoReposicion = true;
		public bool PermiteModificarUsaPrecioDeCostoReposicion
		{
			get{return _permiteModificarUsaPrecioDeCostoReposicion;}			
		}

		public string ProcessName
		{
			get{return _brClass.GetProcessManagerParent().Process.ProcessName;}
		}

		//Matias 20100612 - Tarea 22
		private bool _enabledButtonCuentaCtaCte = true;
		public bool EnabledButtonCuentaCtaCte
		{
			get 
			{
				return  _enabledButtonCuentaCtaCte;
			}				
		}
		//Fin Matias 20100612 - Tarea 22

		//--- PROCENTAJES -------------------------
		public decimal CostoIndirectoPorc1
		{
			get{return _brClass.CostoIndirectoPorc1;}
			set{_brClass.CostoIndirectoPorc1 = value;}
		}

		public decimal CostoIndirectoPorc2
		{
			get{return _brClass.CostoIndirectoPorc2;}
			set{_brClass.CostoIndirectoPorc2 = value;}
		}
		public decimal CostoIndirectoPorc3
		{
			get{return _brClass.CostoIndirectoPorc3;}
			set{_brClass.CostoIndirectoPorc3 = value;}
		}

		public decimal CostoIndirectoPorc4
		{
			get{return _brClass.CostoIndirectoPorc4;}
			set{_brClass.CostoIndirectoPorc4 = value;}
		}

		public decimal CostoIndirectoPorc5
		{
			get{return _brClass.CostoIndirectoPorc5;}
			set{_brClass.CostoIndirectoPorc5 = value;}
		}

		public decimal CostoIndirectoPorc6
		{
			get{return _brClass.CostoIndirectoPorc6;}
			set{_brClass.CostoIndirectoPorc6 = value;}
		}

		public decimal CostoIndirectoPorc7
		{
			get{return _brClass.CostoIndirectoPorc7;}
			set{_brClass.CostoIndirectoPorc7 = value;}
		}
		public decimal CostoIndirectoPorc8
		{
			get{return _brClass.CostoIndirectoPorc8;}
			set{_brClass.CostoIndirectoPorc8 = value;}
		}

		public decimal CostoIndirectoPorc9
		{
			get{return _brClass.CostoIndirectoPorc9;}
			set{_brClass.CostoIndirectoPorc9 = value;}
		}

		public decimal CostoIndirectoPorc10
		{
			get{return _brClass.CostoIndirectoPorc10;}
			set{_brClass.CostoIndirectoPorc10 = value;}
		}
		//-----------------------------------------

		//----------------------------------------- carga las descrip de los Costos Indirectos
		public string CostosIndirectosDescrip1
		{
			get{return _brClass.CostosIndirectosDescrip1;}
		}
		public string CostosIndirectosDescrip2
		{
			get{return _brClass.CostosIndirectosDescrip2;}
		}
		public string CostosIndirectosDescrip3
		{
			get{return _brClass.CostosIndirectosDescrip3;}
		}
		public string CostosIndirectosDescrip4
		{
			get{return _brClass.CostosIndirectosDescrip4;}
		}
		public string CostosIndirectosDescrip5
		{
			get{return _brClass.CostosIndirectosDescrip5;}
		}
		public string CostosIndirectosDescrip6
		{
			get{return _brClass.CostosIndirectosDescrip6;}
		}
		public string CostosIndirectosDescrip7
		{
			get{return _brClass.CostosIndirectosDescrip7;}
		}
		public string CostosIndirectosDescrip8
		{
			get{return _brClass.CostosIndirectosDescrip8;}
		}
		public string CostosIndirectosDescrip9
		{
			get{return _brClass.CostosIndirectosDescrip9;}
		}
		public string CostosIndirectosDescrip10
		{
			get{return _brClass.CostosIndirectosDescrip10;}
		}

		// -------------------------------------
		public bool CostoIndirectoActivo1
		{
			get {return _brClass.CostoIndirectoActivo1;}
			//set {}
		}
		public bool CostoIndirectoActivo2
		{
			get {return _brClass.CostoIndirectoActivo2;}
			//set {}
		}
		public bool CostoIndirectoActivo3
		{
			get {return _brClass.CostoIndirectoActivo3;}
			//set {}
		}
		public bool CostoIndirectoActivo4
		{
			get {return _brClass.CostoIndirectoActivo4;}
			//set {}
		}
		public bool CostoIndirectoActivo5
		{
			get {return _brClass.CostoIndirectoActivo5;}
			//set {}
		}
		public bool CostoIndirectoActivo6
		{
			get {return _brClass.CostoIndirectoActivo6;}
			//set {}
		}
		public bool CostoIndirectoActivo7
		{
			get {return _brClass.CostoIndirectoActivo7;}
			//set {}
		}
		public bool CostoIndirectoActivo8
		{
			get {return _brClass.CostoIndirectoActivo8;}
			//set {}
		}
		public bool CostoIndirectoActivo9
		{
			get {return _brClass.CostoIndirectoActivo9;}
			//set {}
		}
		public bool CostoIndirectoActivo10
		{
			get {return _brClass.CostoIndirectoActivo10;}
			//set {}
		}
		// -------------------------------------

		// ---------------- get CostosIndirectos.tipo
		public bool CostoIndirectoTipo1
		{
			get {return _brClass.CostoIndirectoTipo1;}
		}
		public bool CostoIndirectoTipo2
		{
			get {return _brClass.CostoIndirectoTipo2;}
		}
		public bool CostoIndirectoTipo3
		{
			get {return _brClass.CostoIndirectoTipo3;}
		}
		public bool CostoIndirectoTipo4
		{
			get {return _brClass.CostoIndirectoTipo4;}
		}
		public bool CostoIndirectoTipo5
		{
			get {return _brClass.CostoIndirectoTipo5;}
		}
		public bool CostoIndirectoTipo6
		{
			get {return _brClass.CostoIndirectoTipo6;}
		}
		public bool CostoIndirectoTipo7
		{
			get {return _brClass.CostoIndirectoTipo7;}
		}
		public bool CostoIndirectoTipo8
		{
			get {return _brClass.CostoIndirectoTipo8;}
		}
		public bool CostoIndirectoTipo9
		{
			get {return _brClass.CostoIndirectoTipo9;}
		}
		public bool CostoIndirectoTipo10
		{
			get {return _brClass.CostoIndirectoTipo10;}
		}
		// --------------------
	
		public decimal CostosIndirectos
		{
			get{return _brClass.CostosIndirectos;}
		}


		public bool HayProductoSeleccionado
		{
			get{ return _brClass.HayProductoSeleccionado; }
		}


		public bool AllowCantidadAutomatica
		{
			get{return _brClass.AllowCantidadAutomatica;}
		}


		public string SimboloMonedaPrecioDeCostoReferencia
		{
			get{return _brClass.SimboloMonedaPrecioDeCostoReferencia;}
		}

		public string SimboloMonedaPrecioDeLista
		{
			get{return _brClass.SimboloMonedaPrecioDeLista;}
		}

		public string SimboloMonedaPrecioDeVentaNeto
		{
			get{return _brClass.SimboloMonedaPrecioDeVentaNeto;}
		}
		
		public string SimboloMonedaOrigen
		{
			get
			{
				return _brClass.SimboloMonedaOrigen;
			}
		}

		public string SimboloMonedaComprador
		{
			get{return  _brClass.SimboloMonedaComprador;}
		}

		public string SimboloMonedaProveedor
		{
			get{return _brClass.SimboloMonedaProveedor;}
		}

		public string SimboloMonedaReferencia
		{
			get{return _brClass.SimboloMonedaReferencia;}
		}

		public Producto SelectedItem
		{
			get{return _brClass.SelectedItem;}
			set{_brClass.SelectedItem = value;}
		}

		public ArrayList Items
		{
			get{return this._brClass.Items;}
		}

		public string LeyendaFormulario
		{
			get
			{
				return this._leyendaFormulario;
			}
		}

		public string LayoutProductos
		{
			get{return _layoutDetalle;}
		}


		public DataTable TableMonedas
		{
			get{return _brClass.TableMonedas;}
		}

		public DataTable TableFuentesDeCambio 
		{
			get{return _brClass.TableFuentesDeCambio;}
		}

		public Type ProductosSearch
		{
			get{return typeof(mz.erp.ui.controllers.tsh_Productos);}
		}
		public string IdMonedaReferencia
		{
			get{return _brClass.IdMonedaReferencia;}
		}

		public string IdFuenteDeCambioReferencia
		{
			get{return _brClass.IdFuenteDeCambioReferencia;}
		}

		public string IdFuenteDeCambioProveedor
		{
			get{return _brClass.IdFuenteDeCambioProveedor;}
			set 
			{
				_brClass.IdFuenteDeCambioProveedor = value;
			}
		}


		public string IdMonedaProveedor
		{
			get{return _brClass.IdMonedaProveedor;}
			set{_brClass.IdMonedaProveedor = value;}
		}

		public string IdMonedaComprador
		{
			get{return _brClass.IdMonedaComprador;}
			set{_brClass.IdMonedaComprador = value;}
		}

		public decimal ValorCotizacionFuenteDeCambioComprador
		{
			get{return _brClass.ValorCotizacionFuenteDeCambioComprador;}
		}

		public decimal ValorCotizacionFuenteDeCambioProveedor
		{
			get{return _brClass.ValorCotizacionFuenteDeCambioProveedor;}
		}
		public decimal StockDisponible
		{
			get{return _brClass.StockDisponible;}
		}

		public decimal PrecioCostoAnterior
		{
			get{return _brClass.PrecioCostoAnterior;}
		}

		public string CodigoProducto
		{
			get{return _brClass.CodigoProducto;}
			set{_brClass.CodigoProducto = value;}
		}

		public decimal PrecioCostoMonedaReferencia
		{
			get{return _brClass.PrecioCostoMonedaReferencia;}
		}


		public decimal PrecioDeCostoMonedaProducto
		{
			get{return _brClass.PrecioDeCostoMonedaProducto;}
			set{_brClass.PrecioDeCostoMonedaProducto = value;}
		}
		/*
		public decimal PrecioCostoProveedorConvertidoMonedaFuenteCambioOficial
		{
			get{return _brClass.PrecioCostoProveedorConvertidoMonedaFuenteCambioOficial;}
		}
		*/

		/*
		public decimal PrecioCostoProveedorConvertidoMonedaComprador
		{
			get{return _brClass.PrecioCostoProveedorConvertidoMonedaComprador;}
		}
		*/

		public decimal PrecioDeCostoMonedaProveedor
		{
			get{return _brClass.PrecioDeCostoMonedaProveedor;}
			set{_brClass.PrecioDeCostoMonedaProveedor = value;}
		}

		public decimal PrecioDeCosto
		{
			get{return _brClass.PrecioDeCosto;}
			//set{_brClass.PrecioDeCosto = value;}
		}

		public decimal Cantidad
		{
			get{return _brClass.Cantidad;}
			set{_brClass.Cantidad  = value;}
		}

		public decimal MAC
		{		
			get{return _brClass.MAC;}
			set{_brClass.MAC = value;}
			
		}

		public decimal PrecioDeVentaNeto
		{
			get{return _brClass.PrecioDeVentaNeto;}
		}

		public decimal MaximoDescuento
		{
			get{return _brClass.MaximoDescuento;}
		}

		public decimal PorcentajeMaximoDescuento
		{
			get{return _brClass.PorcentajeMaximoDescuento;}
			set{ _brClass.PorcentajeMaximoDescuento = value;}
		}

		public decimal PrecioDeVentaBruto
		{
			get{return _brClass.PrecioDeVentaBruto;}
			set 
			{
				_brClass.PrecioDeVentaBruto = value;}
		}

		public decimal PrecioCostoRef
		{
			get{return _brClass.PrecioCostoRef;}
			set
			{
				_brClass.PrecioCostoRef = value;
			}
		}

		public decimal PrecioDeListaConImpuestos
		{
			get{return _brClass.PrecioDeListaConImpuestos;}
			set{_brClass.PrecioDeListaConImpuestos = value;}
		}

		public string TextoBotonSiguiente
		{
			get { return _brClass.TextoBotonSiguiente ; }
		}
		
		public string TextoBotonAnterior
		{
			get { return _brClass.TextoBotonAnterior; }
		}


		public bool EnableBuscadorProducto
		{
			get
			{
                //German 20110309 - Tarea 0000038
				/*
                switch(_brClass.GetProcessManagerParent().Process.ProcessName)
				{
					case "ProcesoConfirmarIngresoMercaderia":
						return false;
						break;
					case "ProcesoConfirmarIngresoMercaderiaAnterior":
						return false;
						break;
					default : return true;
				}
                 * */
                return Workflow.NOEsProcesoDeConfirmacionDePrecios(_brClass.GetProcessManagerParent().Process.ProcessName);
                //Fin German 20110309 - Tarea 0000038
			}
		}

		public bool VisibleDatosProveedor
		{
			get
			{
				switch(_brClass.GetProcessManagerParent().Process.ProcessName)
				{
					case "ProcesoModificarPrecioProducto":
						return false;
						break;
					default : return true;
				}
			}
		}


		public bool EnableCantidad
		{
			get
			{
                //German 20110309 - Tarea 0000038
                /*
                switch(_brClass.GetProcessManagerParent().Process.ProcessName)
                {
                    case "ProcesoConfirmarIngresoMercaderia":
                        return false;
                        break;
                    case "ProcesoConfirmarIngresoMercaderiaAnterior":
                        return false;
                        break;
                    default : return true;
                }
                 * */
                return Workflow.NOEsProcesoDeConfirmacionDePrecios(_brClass.GetProcessManagerParent().Process.ProcessName);
                //Fin German 20110309 - Tarea 0000038
			}

		}

		public bool ReadOnlyPrecioDeCostoMonedaProducto
		{
			get
			{
				switch(_brClass.GetProcessManagerParent().Process.ProcessName)
				{
					case "ProcesoModificarPrecioProducto":
						return false;
						break;
					default : return true;
				}
			}
		}

		public bool VisibleDatosCompra
		{
			get
			{
				switch(_brClass.GetProcessManagerParent().Process.ProcessName)
				{
					case "ProcesoModificarPrecioProducto":
						return !_configuracionBasica;
						break;
					default : return true;
				}
			}
		}

		public bool VisibleDatosVenta
		{
			get
			{
				switch(_brClass.GetProcessManagerParent().Process.ProcessName)
				{
					
					default : return true;
				}
			}
		}

		
		public ListaDePreciosItem ListaDePreciosItemSeleccionado
		{
			get{return _brClass.ListaDePreciosItemSeleccionado;}
			set{_brClass.ListaDePreciosItemSeleccionado = value;}
		}

		public decimal CoeficienteProductoLPItem
		{
			get{return _brClass.CoeficienteProductoLPItem;}
			set{_brClass.CoeficienteProductoLPItem = value;}
		}

		public decimal CoeficienteProductoMonedaRefLPItem
		{
			get{return _brClass.CoeficienteProductoMonedaRefLPItem;}
			set{_brClass.CoeficienteProductoMonedaRefLPItem = value;}
		}

		public decimal MaxDescuentoPorcentualLPItem
		{
			get{return _brClass.MaxDescuentoPorcentualLPItem;}
		}

		public decimal MaxDescuentoLPItem
		{
			get{return _brClass.MaxDescuentoLPItem;}
		}
		
		public decimal PrecioVentaBrutoLPItem
		{
			get{return _brClass.PrecioVentaBrutoLPItem;}
			set{_brClass.PrecioVentaBrutoLPItem = value;}
		}

		public decimal PrecioDeListaConImpuestoLPItem
		{
			get{return _brClass.PrecioDeListaConImpuestoLPItem;}
			set{_brClass.PrecioDeListaConImpuestoLPItem = value;}
		}
		
		public decimal PrecioFinalMonedaReferenciaLPItem
		{
			get{return _brClass.PrecioFinalMonedaReferenciaLPItem;}
			set{_brClass.PrecioFinalMonedaReferenciaLPItem = value;}
		}
		
		public decimal PrecioCostoRefLPItem
		{
			get{return _brClass.PrecioCostoRefLPItem;}
			set{_brClass.PrecioCostoRefLPItem = value;}
		}

		public decimal MACLPItem
		{
			get{return _brClass.MACLPItem;}
			set{_brClass.MACLPItem = value;}
		}
		
		public Type ProveedoresSearchObject 
		{
			get 
			{
				return typeof(mz.erp.ui.controllers.tpu_Proveedores);
			}
		}
		
		public string IdProveedor
		{
			get {return _brClass.IdProveedor;}
			set {_brClass.IdProveedor = value;}		
		}			

		//Matias 20100612 - Tarea 22
		public string CodigoProveedor
		{
			get {return _brClass.CodigoProveedor;}
			set {_brClass.CodigoProveedor = value;}		
		}
		//Fin Matias 20100612 - Tarea 22
		
		public decimal PrecioDeCostoProdProv
		{
			get {return _brClass.PrecioDeCostoProdProv;}
			set {_brClass.PrecioDeCostoProdProv = value;}		
		}			

		public string SimbololMonedaPrecioDeCostoProveedor
		{
			get{return _brClass.SimbololMonedaPrecioDeCostoProveedor;}
		}

		public string IdMonedaPrecioDeCostoProveedor
		{
			get{return _brClass.IdMonedaPrecioDeCostoProveedor;}
			set{_brClass.IdMonedaPrecioDeCostoProveedor = value;}
		}

		public string IdFuenteDeCambioListaProveedor
		{
			get{return _brClass.IdFuenteDeCambioListaProveedor;}
			set{_brClass.IdFuenteDeCambioListaProveedor = value;}
		}

		public decimal ValorCotizacionPrecioDeCostoProveedor
		{
			get{return _brClass.ValorCotizacionPrecioDeCostoProveedor;}
			set{_brClass.ValorCotizacionPrecioDeCostoProveedor = value;}
		}

		public bool ActualizaPrecioDeCostoReposicion
		{
			get{return _brClass.ActualizaPrecioDeCostoReposicion;}
			set{_brClass.ActualizaPrecioDeCostoReposicion = value;}
		}

		public bool BonificacionAcumulativa
		{
			get{return _brClass.BonificacionAcumulativa;}
			set{_brClass.BonificacionAcumulativa = value;}
		}


		public decimal Bonificacion1
		{
			get{return _brClass.Bonificacion1;}
			set{_brClass.Bonificacion1 = value;}
		}

		public decimal Bonificacion2
		{
			get{return _brClass.Bonificacion2;}
			set{_brClass.Bonificacion2 = value;}
		}

		public decimal Bonificacion3
		{
			get{return _brClass.Bonificacion3;}
			set{_brClass.Bonificacion3 = value;}
		}

		public decimal Bonificacion4
		{
			get{return _brClass.Bonificacion4;}
			set{_brClass.Bonificacion4 = value;}
		}

		public decimal Bonificacion5
		{
			get{return _brClass.Bonificacion5;}
			set{_brClass.Bonificacion5 = value;}
		}

		public decimal PorcentajeBonificacion1
		{
			get{return _brClass.PorcentajeBonificacion1;}
			set{_brClass.PorcentajeBonificacion1 = value;}
		}
        //German 20140125 - Tarea 1 - SP 22
        public string CodigoProductoProveedor
        {
            get { return _brClass.CodigoProductoProveedor; }
            set { _brClass.CodigoProductoProveedor = value; }
        }
        //Fin German 20140125 - Tarea 1 - SP 22

		public decimal PorcentajeBonificacion2
		{
			get{return _brClass.PorcentajeBonificacion2;}
			set{_brClass.PorcentajeBonificacion2 = value;}
		}

		public decimal PorcentajeBonificacion3
		{
			get{return _brClass.PorcentajeBonificacion3;}
			set{_brClass.PorcentajeBonificacion3 = value;}
		}
		
		public decimal PorcentajeBonificacion4
		{
			get{return _brClass.PorcentajeBonificacion4;}
			set{_brClass.PorcentajeBonificacion4 = value;}
		}
		
		public decimal PorcentajeBonificacion5
		{
			get{return _brClass.PorcentajeBonificacion5;}
			set{_brClass.PorcentajeBonificacion5 = value;}
		}

		public decimal PrecioDeCostoFinalProveedor
		{
			get{return _brClass.PrecioDeCostoFinalProveedor;}
		}

		public bool ExisteProveedorProducto
		{
			get{return _brClass.ExisteProveedorProducto;}
		}

		public ListaDePreciosProveedoresItem ListaDePreciosProveedoresItemSeleccionado
		{
			get{return _brClass.ListaDePreciosProveedoresItemSeleccionado;}
			set{_brClass.ListaDePreciosProveedoresItemSeleccionado = value;}
		}

		private string _contenedoresVisibles = string.Empty;
		public string ContenedoresVisibles
		{
			get{return _contenedoresVisibles;}
		}
		private string _contenedoresHabilitados = string.Empty;						
		public string ContenedoresHabilitados
		{
			get{return _contenedoresHabilitados;}
		}

		private string _contenedoresColapsados = string.Empty;						
		public string ContenedoresColapsados
		{
			get{return _contenedoresColapsados;}
		}

		//TODO
		//Sabrina: tarea 56
		/*
		public decimal PrecioDeCostoReposicion
		{
			get{return _brClass.PrecioDeCostoReposicion;}
			set{_brClass.PrecioDeCostoReposicion = value;}
		}

		public decimal PrecioDeCostoPromedioPonderado
		{
			get{return _brClass.PrecioDeCostoPromedioPonderado;}
			set{_brClass.PrecioDeCostoPromedioPonderado = value;}
		}
			
		public bool UsaPrecioDeCostoReposicion
		{
			get{return _brClass.UsaPrecioDeCostoReposicion;}
			set{_brClass.UsaPrecioDeCostoReposicion = value;}
		}
		*/

		private bool _usaCostosIndirectos = false;
		public bool UsaCostosIndirectos
		{
			get{return _usaCostosIndirectos;}
		}

        //Sabrina: Tarea 1068. 20110317
        public bool ActualizaPreciosProductosCombo
        {
            get { return _brClass.ActualizaPreciosProductosCombo; }
            set { _brClass.ActualizaPreciosProductosCombo = value; }
        }
        //Fin Sabrina: Tarea 1068. 20110317
		#endregion

		#region Eventos
			
		public event EventHandler PrecioCostoProveedorConvertidoMonedaReferenciaChanged;
		public event EventHandler PrecioCostoProveedorConvertidoMonedaFuenteCambioOficialChanged;
		public event EventHandler PrecioDeCostoChanged;
			
		public event EventHandler PrecioCostoAnteriorChanged;
		public event EventHandler StockDisponibleChanged;
		public event EventHandler ObjectHasChanged;
		public event EventHandler PrecioDeCostoRefChanged;
		public event EventHandler PrecioDeVentaBrutoChanged;
		public event EventHandler PorcentajeMaximoDescuentoChanged;
		public event EventHandler MaximoDescuentoChanged;
		public event EventHandler MACChanged;
		public event EventHandler SeleccionMultipleChanged;
		public event EventHandler CoeficienteProductoLPItemChanged;
		public event EventHandler PrecioDeCostoMonedaProveedorChanged;

		public event EventHandler SeleccionMultiplePrecioDeCostoError;
		public event EventHandler SeleccionMultiplePrecioDeVentaError;
		public event System.EventHandler ListaDePreciosProveedoresHasChanged;
        
		/// <summary>
		/// manejadores de Costos Indirectos (para la Moneda $)
		/// </summary>
		public event EventHandler CostoIndirecto1Changed;
		public event EventHandler CostoIndirecto2Changed;
		public event EventHandler CostoIndirecto3Changed;
		public event EventHandler CostoIndirecto4Changed;
		public event EventHandler CostoIndirecto5Changed;
		public event EventHandler CostoIndirecto6Changed;
		public event EventHandler CostoIndirecto7Changed;
		public event EventHandler CostoIndirecto8Changed;
		public event EventHandler CostoIndirecto9Changed;
		public event EventHandler CostoIndirecto10Changed;
		/// <summary>
		/// manejadores de Costos Indirectos (para el Porcentaje %)
		/// </summary>
		public event EventHandler CostoIndirectoPorc1Changed;
		public event EventHandler CostoIndirectoPorc2Changed;
		public event EventHandler CostoIndirectoPorc3Changed;
		public event EventHandler CostoIndirectoPorc4Changed;
		public event EventHandler CostoIndirectoPorc5Changed;
		public event EventHandler CostoIndirectoPorc6Changed;
		public event EventHandler CostoIndirectoPorc7Changed;
		public event EventHandler CostoIndirectoPorc8Changed;
		public event EventHandler CostoIndirectoPorc9Changed;
		public event EventHandler CostoIndirectoPorc10Changed;
        
		//Sabrina: tarea 56
		public event EventHandler PrecioDeCostoFinalChanged;


		private void _brClass_CostoIndirecto1Changed(object sender, EventArgs e)
		{
			if(CostoIndirecto1Changed != null)
				CostoIndirecto1Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirecto2Changed(object sender, EventArgs e)
		{
			if(CostoIndirecto2Changed != null)
				CostoIndirecto2Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirecto3Changed(object sender, EventArgs e)
		{
			if(CostoIndirecto3Changed != null)
				CostoIndirecto3Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirecto4Changed(object sender, EventArgs e)
		{
			if(CostoIndirecto4Changed != null)
				CostoIndirecto4Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirecto5Changed(object sender, EventArgs e)
		{
			if(CostoIndirecto5Changed != null)
				CostoIndirecto5Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirecto6Changed(object sender, EventArgs e)
		{
			if(CostoIndirecto6Changed != null)
				CostoIndirecto6Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirecto7Changed(object sender, EventArgs e)
		{
			if(CostoIndirecto7Changed != null)
				CostoIndirecto7Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirecto8Changed(object sender, EventArgs e)
		{
			if(CostoIndirecto8Changed != null)
				CostoIndirecto8Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirecto9Changed(object sender, EventArgs e)
		{
			if(CostoIndirecto9Changed != null)
				CostoIndirecto9Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirecto10Changed(object sender, EventArgs e)
		{
			if(CostoIndirecto10Changed != null)
				CostoIndirecto10Changed(this, new EventArgs());
		}

		private void _brClass_CostoIndirectoPorc1Changed(object sender, EventArgs e)
		{
			if(CostoIndirectoPorc1Changed != null)
				CostoIndirectoPorc1Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirectoPorc2Changed(object sender, EventArgs e)
		{
			if(CostoIndirectoPorc2Changed != null)
				CostoIndirectoPorc2Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirectoPorc3Changed(object sender, EventArgs e)
		{
			if(CostoIndirectoPorc3Changed != null)
				CostoIndirectoPorc3Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirectoPorc4Changed(object sender, EventArgs e)
		{
			if(CostoIndirectoPorc4Changed != null)
				CostoIndirectoPorc4Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirectoPorc5Changed(object sender, EventArgs e)
		{
			if(CostoIndirectoPorc5Changed != null)
				CostoIndirectoPorc5Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirectoPorc6Changed(object sender, EventArgs e)
		{
			if(CostoIndirectoPorc6Changed != null)
				CostoIndirectoPorc6Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirectoPorc7Changed(object sender, EventArgs e)
		{
			if(CostoIndirectoPorc7Changed != null)
				CostoIndirectoPorc7Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirectoPorc8Changed(object sender, EventArgs e)
		{
			if(CostoIndirectoPorc8Changed != null)
				CostoIndirectoPorc8Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirectoPorc9Changed(object sender, EventArgs e)
		{
			if(CostoIndirectoPorc9Changed != null)
				CostoIndirectoPorc9Changed(this, new EventArgs());
		}
		private void _brClass_CostoIndirectoPorc10Changed(object sender, EventArgs e)
		{
			if(CostoIndirectoPorc10Changed != null)
				CostoIndirectoPorc10Changed(this, new EventArgs());
		}


		#endregion

		#region Metodos Privados

		private void _brClass_ProductosCollectionChanged(object sender, EventArgs e)
		{
			if(ProductosCollectionChanged != null)
				ProductosCollectionChanged(this, new EventArgs());
		}

		bool isDirty = true;

		private void Refresh(object sender, EventArgs e)
		{
			
			try
			{
				if(ValorCotizacionFuenteDeCambioCompradorChanged != null)
					ValorCotizacionFuenteDeCambioCompradorChanged(this, new EventArgs());
				if(PrecioDeCostoRefChanged != null)
					PrecioDeCostoRefChanged(this, new EventArgs());
				if(PorcentajeMaximoDescuentoChanged != null)
					PorcentajeMaximoDescuentoChanged(this, new EventArgs());
				if(MaximoDescuentoChanged != null)
					MaximoDescuentoChanged(this, new EventArgs());
				if(MACChanged != null)
					MACChanged(this, new EventArgs());
				if(PrecioDeVentaBrutoChanged != null)
					PrecioDeVentaBrutoChanged(this, new EventArgs());
				if(PrecioCostoProveedorConvertidoMonedaReferenciaChanged != null)
					PrecioCostoProveedorConvertidoMonedaReferenciaChanged(this, new EventArgs());
				if(PrecioCostoProveedorConvertidoMonedaFuenteCambioOficialChanged != null)
					PrecioCostoProveedorConvertidoMonedaFuenteCambioOficialChanged(this, new EventArgs());
				if(PrecioDeCostoChanged != null)
					PrecioDeCostoChanged(this, new EventArgs());
				if(PrecioCostoAnteriorChanged != null)
					PrecioCostoAnteriorChanged(this, new EventArgs());
				if(StockDisponibleChanged != null)
					StockDisponibleChanged(this, new EventArgs());
				if(CoeficienteProductoLPItemChanged != null)
					CoeficienteProductoLPItemChanged(this, new EventArgs());
				/*German*/
				/*
				if(PrecioDeCostoMonedaProveedorChanged != null)
					PrecioDeCostoMonedaProveedorChanged(this, new EventArgs());					
				*/
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
			}
			catch(Exception ex )
			{
				Console.WriteLine(ex.Message);
			}
		}


		private void Refresh2(object sender, EventArgs e)
		{			
			try
			{
				if(ValorCotizacionFuenteDeCambioCompradorChanged != null)
					ValorCotizacionFuenteDeCambioCompradorChanged(this, new EventArgs());
				if(PrecioDeCostoRefChanged != null)
					PrecioDeCostoRefChanged(this, new EventArgs());
				if(PrecioDeVentaBrutoChanged != null)
					PrecioDeVentaBrutoChanged(this, new EventArgs());
				if(PorcentajeMaximoDescuentoChanged != null)
					PorcentajeMaximoDescuentoChanged(this, new EventArgs());
				if(MaximoDescuentoChanged != null)
					MaximoDescuentoChanged(this, new EventArgs());
				if(MACChanged != null)
					MACChanged(this, new EventArgs());
				if(PrecioCostoProveedorConvertidoMonedaReferenciaChanged != null)
					PrecioCostoProveedorConvertidoMonedaReferenciaChanged(this, new EventArgs());
				if(PrecioCostoProveedorConvertidoMonedaFuenteCambioOficialChanged != null)
					PrecioCostoProveedorConvertidoMonedaFuenteCambioOficialChanged(this, new EventArgs());
				if(PrecioDeCostoChanged != null)
					PrecioDeCostoChanged(this, new EventArgs());
				if(PrecioCostoAnteriorChanged != null)
					PrecioCostoAnteriorChanged(this, new EventArgs());
				if(StockDisponibleChanged != null)
					StockDisponibleChanged(this, new EventArgs());
				if(CoeficienteProductoLPItemChanged != null)
					CoeficienteProductoLPItemChanged(this, new EventArgs());
				if(PrecioDeCostoMonedaProveedorChanged != null)
					PrecioDeCostoMonedaProveedorChanged(this, new EventArgs());
				//if(ObjectHasChanged != null)
				//	ObjectHasChanged(this, new EventArgs());				
			}
			catch(Exception ex )
			{
				Console.WriteLine(ex.Message);
			}
		}
		

		
		private void SetLayoutDetalle()
		{
			
			ArrayList _buildedarray = new ArrayList();
			switch (this._brClass.GetProcessManagerParent().Process.ProcessName)
			{
				case "ProcesoConfirmarIngresoMercaderia":
				{
					_buildedarray.Add("IdProducto");
					_buildedarray.Add("Codigo");
					_buildedarray.Add("Cantidad");
					_buildedarray.Add("Descripcion");
					_buildedarray.Add("PrecioDeCostoMonedaProveedor");
				}
					break;
				case "ProcesoModificarPrecioProducto":
				{
					_buildedarray.Add("Codigo");
					_buildedarray.Add("Descripcion");
					_buildedarray.Add("StockDisponible");
				}
					break;

			}
			if(_allowSeleccionMultiple) _buildedarray.Add("Selected");
			string[] _campos = (string[])_buildedarray.ToArray( typeof( string ) ) ;			
			_layoutDetalle = mz.erp.ui.controllers.ComprobantesDeCompra.GetLayoutDetalle( _campos );
		}

		private void Init()
		{
			/*DEPRECATED a partir de la version 1.6.13*/
			//_allowEditPrecioDeCostoRef = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName,_brClass.GetTaskName(),"AllowEditPrecioDeCostoRef");
			
			
			_allowEditPrecioDeCostoMonedaProveedor = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName,_brClass.GetTaskName(),"AllowEditPrecioDeCostoMonedaProveedor", _allowEditPrecioDeCostoMonedaProveedor);
			_allowRemoveItems = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName,_brClass.GetTaskName(),"AllowRemoveItems");
			_configuracionBasica = Variables.GetValueBool("Productos.Precios.ConfiguracionBasica");
			_allowSeleccionMultiple = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName,_brClass.GetTaskName(),"AllowMultipleSelect", _allowSeleccionMultiple);
			_contenedoresVisibles = Variables.GetValueString(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "ContenedoresVisibles");
			_contenedoresHabilitados = Variables.GetValueString(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "ContenedoresHabilitados");
			_contenedoresColapsados = Variables.GetValueString(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "ContenedoresColapsados");
			_permiteModificarPrecioDeCostoPromedioPonderado = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName,_brClass.GetTaskName(),"PermiteModificarPrecioDeCostoPromedioPonderado", _permiteModificarPrecioDeCostoPromedioPonderado);
			_permiteModificarPrecioDeCostoReposicion = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName,_brClass.GetTaskName(),"PermiteModificarPrecioDeCostoReposicion", _permiteModificarPrecioDeCostoReposicion);
			_permiteModificarUsaPrecioDeCostoReposicion = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName,_brClass.GetTaskName(),"PermiteModificarUsaPrecioDeCostoReposicion", _permiteModificarUsaPrecioDeCostoReposicion);
			_usaCostosIndirectos = Variables.GetValueBool("Productos.PrecioDeCosto.UsaCostosIndirectos", _usaCostosIndirectos);
			InitEventHandlers();
			InitData();

			//Matias 20100612 - Tarea 22
			_enabledButtonCuentaCtaCte = Variables.GetValueBool(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(), "Proveedor.HabilitaBotonCtaCte", _enabledButtonCuentaCtaCte);
			//Fin Matias 20100612 - Tarea 22
		}

		private void InitData()
		{
			SetLeyendaFormulario();
			//SetLayoutDetalle();
		}

		private void InitEventHandlers()
		{
			_brClass.ObjectHasChanged +=new EventHandler(Refresh);			
			
			/*
			_brClass.CostoIndirecto1Changed +=new EventHandler(Refresh2);
			_brClass.CostoIndirectoPorc1Changed +=new EventHandler(Refresh2);
			_brClass.CostoIndirecto2Changed +=new EventHandler(Refresh2);
			_brClass.CostoIndirectoPorc2Changed +=new EventHandler(Refresh2);
			_brClass.CostoIndirecto3Changed +=new EventHandler(Refresh2);
			_brClass.CostoIndirectoPorc3Changed +=new EventHandler(Refresh2);
			_brClass.CostoIndirecto4Changed +=new EventHandler(Refresh2);
			_brClass.CostoIndirectoPorc4Changed +=new EventHandler(Refresh2);
			_brClass.CostoIndirecto5Changed +=new EventHandler(Refresh2);
			_brClass.CostoIndirectoPorc5Changed +=new EventHandler(Refresh2);
			*/
			/*
			_brClass.CostoIndirecto1ActivatedChanged+=new EventHandler(_brClass_CostoIndirecto1ActivatedChanged);
			_brClass.CostoIndirecto2ActivatedChanged+=new EventHandler(_brClass_CostoIndirecto2ActivatedChanged);
			_brClass.CostoIndirecto3ActivatedChanged+=new EventHandler(_brClass_CostoIndirecto3ActivatedChanged);
			_brClass.CostoIndirecto4ActivatedChanged+=new EventHandler(_brClass_CostoIndirecto4ActivatedChanged);
			_brClass.CostoIndirecto5ActivatedChanged+=new EventHandler(_brClass_CostoIndirecto5ActivatedChanged);
			*/

			_brClass.ProductosCollectionChanged += new EventHandler(_brClass_ProductosCollectionChanged);
			_brClass.PrecioDeCostoMonedaProveedorChanged += new EventHandler(RefreshPrecioDeCostoProveedor);
			_brClass.SeleccionMultiplePrecioDeCostoError +=new EventHandler(_brClass_SeleccionMultiplePrecioDeCostoError);
			_brClass.SeleccionMultiplePrecioDeVentaError +=new EventHandler(_brClass_SeleccionMultiplePrecioDeVentaError);
			_brClass.SeleccionMultipleChanged +=new EventHandler(_brClass_SeleccionMultipleChanged);
			_brClass.ListaDePreciosProveedoresHasChanged += new EventHandler(_brClass_ListaDePreciosProveedoresHasChanged);

			// manejadores de eventos de los Costos Indirectos (Moneda, $)
			_brClass.CostoIndirecto1Changed += new EventHandler(_brClass_CostoIndirecto1Changed);
			_brClass.CostoIndirecto2Changed += new EventHandler(_brClass_CostoIndirecto2Changed);
			_brClass.CostoIndirecto3Changed += new EventHandler(_brClass_CostoIndirecto3Changed);
			_brClass.CostoIndirecto4Changed += new EventHandler(_brClass_CostoIndirecto4Changed);
			_brClass.CostoIndirecto5Changed += new EventHandler(_brClass_CostoIndirecto5Changed);
			_brClass.CostoIndirecto6Changed += new EventHandler(_brClass_CostoIndirecto6Changed);
			_brClass.CostoIndirecto7Changed += new EventHandler(_brClass_CostoIndirecto7Changed);
			_brClass.CostoIndirecto8Changed += new EventHandler(_brClass_CostoIndirecto8Changed);
			_brClass.CostoIndirecto9Changed += new EventHandler(_brClass_CostoIndirecto9Changed);
			_brClass.CostoIndirecto10Changed += new EventHandler(_brClass_CostoIndirecto10Changed);
			
			// manejadores de eventos de los Costos Indirectos (Procentaje, %)
			_brClass.CostoIndirectoPorc1Changed += new EventHandler(_brClass_CostoIndirectoPorc1Changed);
			_brClass.CostoIndirectoPorc2Changed += new EventHandler(_brClass_CostoIndirectoPorc2Changed);
			_brClass.CostoIndirectoPorc3Changed += new EventHandler(_brClass_CostoIndirectoPorc3Changed);
			_brClass.CostoIndirectoPorc4Changed += new EventHandler(_brClass_CostoIndirectoPorc4Changed);
			_brClass.CostoIndirectoPorc5Changed += new EventHandler(_brClass_CostoIndirectoPorc5Changed);
			_brClass.CostoIndirectoPorc6Changed += new EventHandler(_brClass_CostoIndirectoPorc6Changed);
			_brClass.CostoIndirectoPorc7Changed += new EventHandler(_brClass_CostoIndirectoPorc7Changed);
			_brClass.CostoIndirectoPorc8Changed += new EventHandler(_brClass_CostoIndirectoPorc8Changed);
			_brClass.CostoIndirectoPorc9Changed += new EventHandler(_brClass_CostoIndirectoPorc9Changed);
			_brClass.CostoIndirectoPorc10Changed += new EventHandler(_brClass_CostoIndirectoPorc10Changed);
		}

		private void RefreshPrecioDeCostoProveedor(object sender, EventArgs e)
		{
			/*German*/
			if(PrecioDeCostoMonedaProveedorChanged != null)
				PrecioDeCostoMonedaProveedorChanged(this, new EventArgs());	

			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
			if(ProductosCollectionChanged != null)
				ProductosCollectionChanged(this, new EventArgs());

		}



		private void SetLeyendaFormulario()
		{
			string leyenda = Variables.GetValueString( "Momentos." + this._brClass.GetTaskName()+"." + this._brClass.GetProcessManagerParent().Process.ProcessName +".LeyendaFormulario" );
			if (leyenda.Equals(string.Empty))
			{
				leyenda = Variables.GetValueString( "Momentos." + this._brClass.GetTaskName()+".LeyendaFormulario" );
			}
			if (leyenda.Equals(string.Empty))
			{
				leyenda = this._brClass.GetTaskName();
			}
			this._leyendaFormulario = leyenda;
		}


		#endregion

		#region Miembros de ITaskController

		public bool IsFlushedState()
		{
			return this._processManager.ProcessFlushed;
		}

		public bool IsNextState()
		{
			return this._processManager.IsNextState();	
		}

		public bool IsBackState()
		{	
			return this._processManager.IsBackState();
		}

		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_brClass.GetTaskName());
		}

		public bool IsLastTask()
		{					
			return this._processManager.IsLastTask(_brClass.GetTaskName());
		}

		private ProcessControllerManager _processManager;
		public void SetProcessManager(ProcessControllerManager processManager)
		{
			_processManager = processManager;
		}
		public ProcessControllerManager GetProcessManager()
		{
			return _processManager;
		}

		public bool AllowPrevious()
		{
			return _brClass.AllowPrevious();
		}

		public void Previous()
		{
			_brClass.Previous();
		}

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}

		public string GetProcessName()
		{
			return _processManager.GetProcessName();
		}

		public ITask GetTask()
		{
			return _brClass;
		}

		public void Execute()
		{
			_brClass.Execute();
		}

		public bool AllowShow()
		{
			return _brClass.AllowShow();
		}
		
		
		public ItemsDatasetErrors GetErrors()
		{
			return 	_brClass.GetErrors();
		}
		public string GetWarnings()
		{
			return 	_brClass.GetWarnings();
		}
		public void Continue()
		{
			_brClass.Execute();
		}

		#endregion

		#region Eventos

		public event EventHandler ValorCotizacionFuenteDeCambioCompradorChanged;
		public event EventHandler ProductosCollectionChanged;
			

		#endregion

		#region Miembros de IObservable

		private ArrayList _observers = new ArrayList();

		public void ProcessObjectsObserver()
		{
			
		}

		public void AddObjectListener(IObserver observer)
		{
			_observers.Add(observer);
		}

		#endregion

		#region Miembros de IObserver

		public void UpdateObject(object sender, object valores)
		{
			    if ((valores.GetType()) == typeof(System.Collections.ArrayList))
			{
				ProcessItem( (ArrayList)valores);
			}
		}

		private void ProcessItem( ArrayList lista )
		{
			_brClass.AddRange(lista);		
		}

		#endregion
		
		#region Metodos Publicos
        //German 20140125 - Tarea 1 - SP 22
        public void removeListaDePrecioProveedor(ListaDePreciosProveedoresItem item)
        {
            _brClass.removeListaDePrecioProveedor(item);
        }
        //German 20140125 - Tarea 1 - SP 22

        //German 20110309 - Tarea 0000038
        public bool EsProcesoDeConfirmacionDePrecios(string ProcessName)
        {
            return Workflow.EsProcesoDeConfirmacionDePrecios(ProcessName);
        }

        //Fin German 20110309 - Tarea 0000038

        //Sabrina: Tarea 1068. 20110317
        public bool CambioCostoProductosCombo()
        {
            return _brClass.CambioCostoProductosCombo();
        }

        public bool CambioPrecioVentaProductosCombo()
        {
           return _brClass.CambioPrecioVentaProductosCombo();
        }
        //Fin Sabrina: Tarea 1068. 20110317
		
        public bool isProveedorComprobante()

		{
			return _brClass.isProveedorComprobante();
		}

		public bool PrecioDeCostoMonedaProveedorEsIgualAPrecioDeCostoFinalLP()
		{
			return _brClass.PrecioDeCostoMonedaProveedorEsIgualAPrecioDeCostoFinalLP();
		}

		public void ActualizarPrecioDeCostoReposicionConPrecioDeCostoMonedaProveedor()
		{
			_brClass.ActualizarPrecioDeCostoReposicionConPrecioDeCostoMonedaProveedor();
		}

		public void DeshacerActualizarPrecioDeCostoReposicionConPrecioDeCostoMonedaProveedor()
		{
			_brClass.DeshacerActualizarPrecioDeCostoReposicionConPrecioDeCostoMonedaProveedor();
			if(ProductosCollectionChanged != null)
				ProductosCollectionChanged(this, new EventArgs());


		}


		public void DisconnectCostosIndirectosEvent()
		{
			
			_brClass.CostoIndirecto1ActivatedChanged-=new EventHandler(_brClass_CostoIndirecto1ActivatedChanged);
			_brClass.CostoIndirecto2ActivatedChanged-=new EventHandler(_brClass_CostoIndirecto2ActivatedChanged);
			_brClass.CostoIndirecto3ActivatedChanged-=new EventHandler(_brClass_CostoIndirecto3ActivatedChanged);
			_brClass.CostoIndirecto4ActivatedChanged-=new EventHandler(_brClass_CostoIndirecto4ActivatedChanged);
			_brClass.CostoIndirecto5ActivatedChanged-=new EventHandler(_brClass_CostoIndirecto5ActivatedChanged);
		}

		public void ConnectCostosIndirectosEvent()
		{
			
			_brClass.CostoIndirecto1ActivatedChanged+=new EventHandler(_brClass_CostoIndirecto1ActivatedChanged);
			_brClass.CostoIndirecto2ActivatedChanged+=new EventHandler(_brClass_CostoIndirecto2ActivatedChanged);
			_brClass.CostoIndirecto3ActivatedChanged+=new EventHandler(_brClass_CostoIndirecto3ActivatedChanged);
			_brClass.CostoIndirecto4ActivatedChanged+=new EventHandler(_brClass_CostoIndirecto4ActivatedChanged);
			_brClass.CostoIndirecto5ActivatedChanged+=new EventHandler(_brClass_CostoIndirecto5ActivatedChanged);

			/*
			_brClass.CostoIndirecto1Changed += new EventHandler(Refresh2);
			_brClass.CostoIndirectoPorc1Changed += new EventHandler(Refresh2);
			_brClass.CostoIndirecto2Changed += new EventHandler(Refresh2);
			_brClass.CostoIndirectoPorc2Changed += new EventHandler(Refresh2);
			_brClass.CostoIndirecto3Changed += new EventHandler(Refresh2);
			_brClass.CostoIndirectoPorc3Changed += new EventHandler(Refresh2);
			_brClass.CostoIndirecto4Changed += new EventHandler(Refresh2);
			_brClass.CostoIndirectoPorc4Changed += new EventHandler(Refresh2);
			_brClass.CostoIndirecto5Changed += new EventHandler(Refresh2);
			_brClass.CostoIndirectoPorc5Changed += new EventHandler(Refresh2);
			*/
		}

		public void AplicarCoeficienteSobrePrecioCostoListaProveedor(decimal coef)
		{
			_brClass.AplicarCoeficienteSobrePrecioCostoListaProveedor(coef);
		}

		/*		public void TrasladarPrecioUnitario()
				{
					_brClass.TrasladarPrecioUnitario();
				}
		*/
		public void TrasladarPrecioDeListaFinal()
		{
			_brClass.TrasladarPrecioDeListaFinal();
		}

		public void UpdateCoeficienteToGral()
		{
			_brClass.UpdateCoeficienteToGral();
		}

		public void Seleccionar(bool seleccionar)
		{
			foreach(Producto prod in _brClass.Productos)
			{
				prod.Selected = seleccionar;
			}
			if(ProductosCollectionChanged != null)
				ProductosCollectionChanged(this, new EventArgs());

		}

		public void DeleteSelectedItem()
		{
			if(this._productoABorrar != null)
			{
				_brClass.Productos.Remove(this._productoABorrar);
				_brClass.SetSelectedItemNull();
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
			}
		}

		public void CellEdited(bool esProveedorPorDefault)
		{
			_brClass.SetProveedorDefaultListaDePreciosProveedoresItemSeleccionado(esProveedorPorDefault);
		}

		public void SetItemABorrar(object itemDeleting)
		{
			_productoABorrar = itemDeleting;
		}


		public bool EstaSeleccionado()
		{
			return _brClass.Selected;
		}

		public void SetListaDePreciosProveedoresItemABorrar(businessrules.ListaDePreciosProveedoresItem itemDeleting)
		{
			_listaDePreciosProveedoresItemABorrar = itemDeleting;
		}

		
		public void EliminarListaDePreciosProveedorSeleccionado()
		{
			if(this._listaDePreciosProveedoresItemABorrar != null)
			{
				_brClass.EliminarListaDePreciosProveedor(this._listaDePreciosProveedoresItemABorrar);
				_brClass.SetListaDePreciosProveedoresItemSeleccionadoNull();
			}			
		}

		
		//----------------------------------------- Activa/Desactiva un Costo Indirecto
		public void ActivarCostoIndirecto(long idCosto, bool valor)
		{
			_brClass.ActivarCostoIndirecto(idCosto, valor);				
		}

		public bool CoeficienteCreadoyActivo(long indice)
		{
			return _brClass.CoeficienteCreadoyActivo(indice);				
		}
		//----------------------------------------- 

		public void DisconnectObjectHasChangedEvent()
		{
			_brClass.ObjectHasChanged -=new EventHandler(Refresh);
		}

		public void ConnectObjectHasChangedEvent()
		{
			_brClass.ObjectHasChanged +=new EventHandler(Refresh);
		}
				
		//-----------------------------------------

		public void CargarCostosIndirectosDescripcion()
		{
			_brClass.CargarCostosIndirectosDescripcion();
		}

		public bool CoeficienteBinding(long indice)
		{
			return _brClass.CoeficienteBinding(indice);
		}

		#endregion

		private void _brClass_SeleccionMultiplePrecioDeCostoError(object sender, EventArgs e)
		{
			if(SeleccionMultiplePrecioDeCostoError != null)
				SeleccionMultiplePrecioDeCostoError(this, new EventArgs());
		}

		private void _brClass_SeleccionMultiplePrecioDeVentaError(object sender, EventArgs e)
		{
			if(SeleccionMultiplePrecioDeVentaError != null)
				SeleccionMultiplePrecioDeVentaError(this, new EventArgs());
		}

		private void _brClass_SeleccionMultipleChanged(object sender, EventArgs e)
		{
			if(SeleccionMultipleChanged != null)
				SeleccionMultipleChanged(this, new EventArgs());
		}


		private void _brClass_ListaDePreciosProveedoresHasChanged(object sender, EventArgs e)
		{
			if(ListaDePreciosProveedoresHasChanged != null)
				ListaDePreciosProveedoresHasChanged(this, new EventArgs());
		}

		private void _brClass_CostoIndirecto1ActivatedChanged(object sender, EventArgs e)
		{
			Refresh2(sender, e);
			_brClass_CostoIndirecto1Changed(sender, e);
			_brClass_CostoIndirectoPorc1Changed(sender, e);
		}

		private void _brClass_CostoIndirecto2ActivatedChanged(object sender, EventArgs e)
		{
			Refresh2(sender, e);
			_brClass_CostoIndirecto2Changed(sender, e);
			_brClass_CostoIndirectoPorc2Changed(sender, e);
		}

		private void _brClass_CostoIndirecto3ActivatedChanged(object sender, EventArgs e)
		{
			Refresh2(sender, e);
			_brClass_CostoIndirecto1Changed(sender, e);
			_brClass_CostoIndirectoPorc3Changed(sender, e);
		}

		private void _brClass_CostoIndirecto4ActivatedChanged(object sender, EventArgs e)
		{
			Refresh2(sender, e);
			_brClass_CostoIndirecto4Changed(sender, e);
			_brClass_CostoIndirectoPorc4Changed(sender, e);
		}

		private void _brClass_CostoIndirecto5ActivatedChanged(object sender, EventArgs e)
		{
			Refresh2(sender, e);
			_brClass_CostoIndirecto5Changed(sender, e);
			_brClass_CostoIndirectoPorc5Changed(sender, e);
		}
	}
}

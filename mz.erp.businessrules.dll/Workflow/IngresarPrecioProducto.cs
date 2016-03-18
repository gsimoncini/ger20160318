using System;
using System.Data;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes.data;
using System.Collections;
using mz.erp.commontypes;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de IngresarPrecioProducto.
	/// </summary>
	public class IngresarPrecioProducto: ITask, IPersistentTask
	{
		
		#region Constructores

		public IngresarPrecioProducto()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		/*
		public IngresarPrecioProducto(string codigoProducto)
		{
			Init();
			GenerateProducto(codigoProducto);
		}
		*/

		#endregion

		#region Variables Privadas
			
		private string _idProducto = string.Empty;
		private string _idProveedor = string.Empty;
		private string _codigo = string.Empty;
		private DataTable _tableMonedas = new DataTable();
		private DataTable _tableFuentesDeCambio = new DataTable();
		private decimal _valorCotizacionFuenteDeCambioProveedor = 0;
		private decimal _valorCotizacionFuenteDeCambioComprador = 0;
			
		private string _idCotizacionFuenteDeCambioComprador = string.Empty;
		private string _idMonedaProveedor = string.Empty;
		private string _idMonedaComprador = string.Empty;
		private string _idMonedaReferencia = string.Empty;
		private string _simboloMonedaReferencia = string.Empty;
		private string _simboloMonedaProveedor = string.Empty;
		private string _simboloMonedaComprador = string.Empty;
		private string _idFuenteDeCambioProveedor = string.Empty;
		private string _idFuenteDeCambioReferencia = string.Empty;
		private Cotizacion _cotizacionComprador;
		private Cotizacion _cotizacionProveedor;

		private tfi_MonedasDataset _dataMonedas = new tfi_MonedasDataset();
		
			
		//private ItemsIngresoPrecioProducto _items = new ItemsIngresoPrecioProducto();
		private Producto _producto;
		private ProductosCollection _productos;
		
		private ArrayList _productosInvalidos = new ArrayList();
		private ArrayList _productosInvalidosPrecioProveedor = new ArrayList();
		private ArrayList _productosInvalidosPrecioProveedorConPrecioFactura = new ArrayList();
		private DataSet _dataProductos = new tsh_ProductosDataset();
		private DataSet _dataProductosSucursales = new tsh_ProductosSucursalesDataset();
		private tpu_ProveedoresProductosDataset _dataProveedoresProductos = new tpu_ProveedoresProductosDataset();
        //Sabrina: Incidencia 0000204. 20110901
        private tpu_ProveedoresProductosAuxiliaresDataset _dataProveedoresProductosAuxiliares = new tpu_ProveedoresProductosAuxiliaresDataset();
        //Fin Sabrina: Incidencia 0000204. 20110901
        private tsh_ProductosCoeficientesAplicadosDataset _dataProductosCoeficientesAplicados = new tsh_ProductosCoeficientesAplicadosDataset();
		private tsh_ProductosAuxiliaresDataset _dataProductosAuxiliares = new tsh_ProductosAuxiliaresDataset();
		private bool _seleccionMultilple = false;
		private ListaDePreciosItem _listaDePreciosItemSeleccionado;
		private bool _listaDePreciosHabilitadas = false; 

		private bool _usaCotizacionDefault = true;
		private bool _usaPrecioDeListaProveedor = false;
		private string _idCotizacionPrecioDeCostoProveedor = string.Empty;
		private decimal _precioDeCostoUltimaCompra = 0;

		private bool _habilitaTrasladarPrecioDeListaFinal = false;

		private bool _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = false;
		    
		private ListaDePreciosProveedoresItem _listaDePreciosProveedoresItemSeleccionado;
		private bool _precioDeVentaAfectaMac = false;

		private string _tiposDeArticulosAdicionales = string.Empty;
		private ArrayList _tiposDeArticulosAdicionalesList = new ArrayList();

		private string _costoIndirectoDescrip1 = string.Empty;
		private string _costoIndirectoDescrip2 = string.Empty;
		private string _costoIndirectoDescrip3 = string.Empty;
		private string _costoIndirectoDescrip4 = string.Empty;
		private string _costoIndirectoDescrip5 = string.Empty;
		private string _costoIndirectoDescrip6 = string.Empty;
		private string _costoIndirectoDescrip7 = string.Empty;
		private string _costoIndirectoDescrip8 = string.Empty;
		private string _costoIndirectoDescrip9 = string.Empty;
		private string _costoIndirectoDescrip10 = string.Empty;

		private decimal _precioDeCostoMonedaProveedorAnterior; 		
		
		private bool _allowCantidadAutomatica = false;
		/*German 20090325*/
		private bool _calculaPPP = true;
		private Producto _productoComodin;
		/*Fin German 20090325*/

		private bool _bonificacionesAcumulativas = true;

		private bool _visualizaVentana = true;

        //German 20110309 - Tarea 0000038
        private ComprobanteDeCompra _compCompra = null;
        //Fin German 20110309 - Tarea 0000038
        
        #endregion

		#region Eventos

		public event EventHandler PrecioDeCostoMonedaProveedorChanged;
		public event EventHandler ProductosCollectionChanged;
		public event EventHandler SeleccionMultiplePrecioDeCostoError;
		public event EventHandler SeleccionMultiplePrecioDeVentaError;
		public event EventHandler SeleccionMultipleChanged;
		//Sabrina 20100616 - Tarea 744
		public event EventHandler IdMonedaPrecioDeCostoProveedorChanged;
		public event EventHandler IdFuenteDeCambioListaProveedorChanged;
		//Fin Sabrina 20100616 - Tarea 744
		
		#endregion
			
		#region Variables Publicas

        //German 20120522 - Tarea 0000333
        private bool _noTrasladaSiempreCambioPrecioDeCompraAPrecioDeCostoReposicion = false;
        private bool _preguntaTrasladaCambioPrecioDeCompraAPrecioDeCostoReposicion = false;

        public bool NoTrasladaSiempreCambioPrecioDeCompraAPrecioDeCostoReposicion
        {
            get { return _noTrasladaSiempreCambioPrecioDeCompraAPrecioDeCostoReposicion; }

        }

        public bool PreguntaTrasladaCambioPrecioDeCompraAPrecioDeCostoReposicion
        {
            get { return _preguntaTrasladaCambioPrecioDeCompraAPrecioDeCostoReposicion; }

        }

        //Fin German 20120522 - Tarea 0000333

        //German 20110309 - Tarea 0000038
        public ComprobanteDeCompra ComprobanteCompra
        {
            get { return _compCompra; }
        }
        //Fin German 20110309 - Tarea 0000038


		public bool AllowCantidadAutomatica
		{
			get{return _allowCantidadAutomatica;}
		}

		public bool PrecioDeVentaAfectaMac
		{
			get{return _precioDeVentaAfectaMac;}
		}
		

		public bool SeleccionMultiple
		{
			get{return _seleccionMultilple;}
			set
			{
				if(_seleccionMultilple != value)
				{
					_seleccionMultilple = value;
					if(value)
					{
						/*German 20090325*/
						Producto prod  = new Producto(_calculaPPP, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
						/*Fin German 20090325*/
						//Sabrina 20100705 - Tarea 790
						prod.CargarListasDePrecios("NEW_MULTIPLE");
						//Fin Sabrina 20100705 - Tarea 790
						GenerateCotizacionProveedor();
						prod.CotizacionProveedor = _cotizacionProveedor;
						GenerateCotizacionPrecioDeCostoMasivo(prod);
						GenerateCotizacionPrecioDeVentaMasivo(prod);
						GetIdProducto(prod);
						SelectedItem = prod;
						if(ListaDePreciosProveedoresHasChanged != null)
							ListaDePreciosProveedoresHasChanged(this, new EventArgs());
						if(SeleccionMultipleChanged != null)
							SeleccionMultipleChanged(this, new EventArgs());

					}
				}
			}
		}

		private void GetIdProducto(Producto prod)
		{
			if(_productos.Count > 0)
			{
				Producto producto = _productos.Get(0);
				prod.IdProducto = producto.IdProducto;
			}
		}

		private void GenerateCotizacionPrecioDeCostoMasivo(Producto prod)
		{
			if(_productos.Count > 0)
			{
				Producto producto = _productos.Get(0);
				prod.IdMonedaPrecioDeCosto = producto.IdMonedaPrecioDeCosto;
				prod.IdFuenteDeCambioProductoPrecioDeCosto = producto.IdFuenteDeCambioProductoPrecioDeCosto;
				prod.SimboloMonedaOrigen = producto.SimboloMonedaOrigen;
			}
		}
		private void GenerateCotizacionPrecioDeVentaMasivo(Producto prod)
		{
			if(_productos.Count > 0)
			{
				Producto producto = _productos.Get(0);
				prod.IdMonedaPrecioDeVentaNeto = producto.IdMonedaPrecioDeVentaNeto;
				prod.IdFuenteDeCambioProductoPrecioDeVenta = producto.IdFuenteDeCambioProductoPrecioDeVenta;
				prod.SimboloMonedaDescuentoMaximo = producto.SimboloMonedaDescuentoMaximo;
				prod.SimboloMonedaPrecioDeLista = producto.SimboloMonedaPrecioDeLista;
				prod.SimboloMonedaPrecioDeVentaNeto = producto.SimboloMonedaPrecioDeVentaNeto;
			}
		}


		public decimal PrecioDeListaConImpuestosMonedaReferencia
		{
			get
			{
				if(_producto != null)
				{
					return _producto.PrecioDeListaConImpuestosMonedaReferencia;
				}
				return 0;
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.PrecioDeListaConImpuestosMonedaReferencia)
					{
						_producto.PrecioDeListaConImpuestosMonedaReferencia = value;
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						if(ChequearMonedaPrecioDeVenta())
						{
							foreach(Producto prod in _productos)
							{
								if(prod != _producto)
									if(prod.Selected)
										prod.PrecioDeListaConImpuestosMonedaReferencia = value;
							}
						}
						else
							if(SeleccionMultiplePrecioDeVentaError != null)
							SeleccionMultiplePrecioDeVentaError(this, new EventArgs());
					}
				}
			}
		}

		public decimal PrecioDeListaConImpuestos
		{
			get
			{
				if(_producto != null)
				{
					return _producto.PrecioDeListaConImpuestos;
				}
				return 0;
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.PrecioDeListaConImpuestos)
					{
						_producto.PrecioDeListaConImpuestos = value;
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						if(ChequearMonedaPrecioDeVenta())
						{
							foreach(Producto prod in _productos)
							{
								if(prod != _producto)
									if(prod.Selected)
										prod.PrecioDeListaConImpuestos = value;
							}
						}
						else
							if(SeleccionMultiplePrecioDeVentaError != null)
							SeleccionMultiplePrecioDeVentaError(this, new EventArgs());
					}
					
				}
			}
		}

		public string IdFuenteDeCambioProductoPrecioDeCosto
		{
			get
			{
				if(_producto != null)
				{
					return _producto.IdFuenteDeCambioProductoPrecioDeCosto;
				}
				return string.Empty;
			}
		}

		public decimal PrecioDeCostoAnteriorMonedaProducto
		{
			get
			{
				if(_producto != null)
				{
					return _producto.PrecioDeCostoAnteriorMonedaProducto;
				}
				return 0;
			}

		}

		public bool Selected
		{
			get
			{
				if(_producto != null)
				{

					return _producto.Selected;
				}
				return false;
			}
			set
			{
				if(_producto != null)
				{

					_producto.Selected = value;
				}
				
			}
		}

		public decimal CostosIndirectos
		{
			get
			{
				if(_producto != null)
				{

					return _producto.CostosIndirectos;
				}
				return 0;
			}
		}

		// --- Matias --- costos indirectos (coeficientes) ------- (Tarea 26) 
		// --------------------- CostoIndirecto
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


		public event EventHandler CostoIndirecto1ActivatedChanged;
		public event EventHandler CostoIndirecto2ActivatedChanged;
		public event EventHandler CostoIndirecto3ActivatedChanged;
		public event EventHandler CostoIndirecto4ActivatedChanged;
		public event EventHandler CostoIndirecto5ActivatedChanged;
		public event EventHandler CostoIndirecto6ActivatedChanged;
		public event EventHandler CostoIndirecto7ActivatedChanged;
		public event EventHandler CostoIndirecto8ActivatedChanged;
		public event EventHandler CostoIndirecto9ActivatedChanged;
		public event EventHandler CostoIndirecto10ActivatedChanged;
		

		public decimal CostoIndirecto1
		{
			get
			{
				if(_producto != null)
				{
					return _producto.CostoIndirecto1;
				}
				return 0;
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.CostoIndirecto1)
					{
						_producto.CostoIndirecto1 = value;
						if(CostoIndirecto1Changed != null)
							CostoIndirecto1Changed(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.CostoIndirecto1 = value;
						}
					}
				}
			}
		}

		public decimal CostoIndirecto2
		{
			get
			{
				if(_producto != null)
				{

					return _producto.CostoIndirecto2;
				}
				return 0;
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.CostoIndirecto2)
					{
						_producto.CostoIndirecto2 = value;
						if(CostoIndirecto2Changed != null)
							CostoIndirecto2Changed(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.CostoIndirecto2 = value;						
						}
					}
				}
			}
		}

		public decimal CostoIndirecto3
		{
			get
			{
				if(_producto != null)
				{

					return _producto.CostoIndirecto3;
				}
				return 0;
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.CostoIndirecto3)
					{
						_producto.CostoIndirecto3 = value;
						if(CostoIndirecto3Changed != null)
							CostoIndirecto3Changed(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.CostoIndirecto3 = value;						
						}
					}
				}
			}
		}

		public decimal CostoIndirecto4
		{
			get
			{
				if(_producto != null)
				{

					return _producto.CostoIndirecto4;
				}
				return 0;
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.CostoIndirecto4)
					{
						_producto.CostoIndirecto4 = value;
						if(CostoIndirecto4Changed != null)
							CostoIndirecto4Changed(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.CostoIndirecto4 = value;						
						}
					}
				}
			}
		}

		public decimal CostoIndirecto5
		{
			get
			{
				if(_producto != null)
				{

					return _producto.CostoIndirecto5;
				}
				return 0;
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.CostoIndirecto5)
					{
						_producto.CostoIndirecto5 = value;
						if(CostoIndirecto5Changed != null)
							CostoIndirecto5Changed(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.CostoIndirecto5 = value;						
						}
					}
				}
			}
		}

		public decimal CostoIndirecto6
		{
			get
			{
				if(_producto != null)
				{

					return _producto.CostoIndirecto6;
				}
				return 0;
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.CostoIndirecto6)
					{
						_producto.CostoIndirecto6 = value;
						if(CostoIndirecto6Changed != null)
							CostoIndirecto6Changed(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.CostoIndirecto6 = value;						
						}
					}
				}
			}
		}

		public decimal CostoIndirecto7
		{
			get
			{
				if(_producto != null)
				{

					return _producto.CostoIndirecto7;
				}
				return 0;
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.CostoIndirecto7)
					{
						_producto.CostoIndirecto7 = value;
						if(CostoIndirecto7Changed != null)
							CostoIndirecto7Changed(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.CostoIndirecto7 = value;						
						}
					}
				}
			}
		}

		public decimal CostoIndirecto8
		{
			get
			{
				if(_producto != null)
				{

					return _producto.CostoIndirecto8;
				}
				return 0;
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.CostoIndirecto8)
					{
						_producto.CostoIndirecto8 = value;
						if(CostoIndirecto8Changed != null)
							CostoIndirecto8Changed(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.CostoIndirecto8 = value;						
						}
					}
				}
			}
		}

		public decimal CostoIndirecto9
		{
			get
			{
				if(_producto != null)
				{

					return _producto.CostoIndirecto9;
				}
				return 0;
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.CostoIndirecto9)
					{
						_producto.CostoIndirecto9 = value;
						if(CostoIndirecto9Changed != null)
							CostoIndirecto9Changed(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.CostoIndirecto9 = value;						
						}
					}
				}
			}
		}

		public decimal CostoIndirecto10
		{
			get
			{
				if(_producto != null)
				{

					return _producto.CostoIndirecto10;
				}
				return 0;
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.CostoIndirecto10)
					{
						_producto.CostoIndirecto10 = value;
						if(CostoIndirecto10Changed != null)
							CostoIndirecto10Changed(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.CostoIndirecto10 = value;						
						}
					}
				}
			}
		}


		//Sabrina: tarea 56
		// --------------------- CostoIndirectoTotal
		/*public decimal CostoIndirectoTotal
		{
			get
			{
				if(_producto != null)
				{

					return _producto.CostoIndirectoTotal;
				}
				return 0;
			}			
		}*/

		public decimal PrecioDeCostoIndirecto
		{
			get
			{
				if(_producto != null)
				{

					return _producto.PrecioDeCostoIndirecto;
				}
				return 0;
			}			
		}

		public decimal PrecioDeCostoReposicion
		{		
			get
			{	
				if(_producto != null)
					return _producto.PrecioDeCostoReposicion;
				return 0;			
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.PrecioDeCostoReposicion)
					{
						_producto.PrecioDeCostoReposicion = value;
						//Sabrina 20100719 - Tarea 796
						_producto.ListaDePrecios.UpdatePrecios(_producto.PrecioDeCosto, _producto.MAC, _producto.PrecioDeVentaNeto);
						ListaDePreciosItem itemDefault = _producto.ListaDePrecios.GetDefaultItem();
						_producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
						//German 20090421
						/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
							_producto.PrecioLista = _producto.PrecioDeVentaNeto;
							*/
						//Fin German 20090421
						//Fin Sabrina 20100719 - Tarea 796
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
								{
									prod.PrecioDeCostoReposicion = value;
									//Sabrina 20100719 - Tarea 796
									prod.ListaDePrecios.UpdatePrecios(prod.PrecioDeCosto, prod.MAC, prod.PrecioDeVentaNeto);
									ListaDePreciosItem itemDefault = prod.ListaDePrecios.GetDefaultItem();
									prod.PrecioLista = itemDefault.PrecioDeVentaBruto;
									//German 20090421
									/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
										prod.PrecioLista = prod.PrecioDeVentaNeto;
										*/
									//Fin German 20090421
									//Fin Sabrina 20100719 - Tarea 796
								}
						}
						
					}
				}
				
			}

		}

		public decimal PrecioDeCostoPromedioPonderadoAnterior
		{
			get
			{
				if(_producto != null)
					return _producto.PrecioCostoPromedioPonderadoAnterior;
				else return 0;
			}
		}

		

		public decimal PrecioDeCostoPromedioPonderado
		{		
			get
			{	
				if(_producto != null)
					return _producto.PrecioDeCostoPromedioPonderado;
				return 0;			
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.PrecioDeCostoPromedioPonderado)
					{
						_producto.PrecioDeCostoPromedioPonderado = value;
						//Sabrina 20100719 - Tarea 796
						_producto.ListaDePrecios.UpdatePrecios(_producto.PrecioDeCosto, _producto.MAC, _producto.PrecioDeVentaNeto);
						ListaDePreciosItem itemDefault = _producto.ListaDePrecios.GetDefaultItem();
						_producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
						//German 20090421
						/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
							_producto.PrecioLista = _producto.PrecioDeVentaNeto;
							*/
						//Fin German 20090421
						//Fin Sabrina 20100719 - Tarea 796
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
								{
									prod.PrecioDeCostoPromedioPonderado = value;
									//Sabrina 20100719 - Tarea 796
									prod.ListaDePrecios.UpdatePrecios(prod.PrecioDeCosto, prod.MAC, prod.PrecioDeVentaNeto);
									ListaDePreciosItem itemDefault = prod.ListaDePrecios.GetDefaultItem();
									prod.PrecioLista = itemDefault.PrecioDeVentaBruto;
									//German 20090421
									/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
										prod.PrecioLista = prod.PrecioDeVentaNeto;
										*/
									//Fin German 20090421
									//Fin Sabrina 20100719 - Tarea 796
								}
						}
						
					}
				}
				
			}

		}
		
		private bool _usaPrecioDeCostoReposicionDefault = Variables.GetValueBool("Productos.PrecioDeCosto.UsaPrecioDeCostoReposicion");
		public bool UsaPrecioDeCostoReposicion
		{		
			get
			{	
				if(_producto != null)
					return _producto.UsaPrecioDeCostoReposicion;
				return _usaPrecioDeCostoReposicionDefault;			
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.UsaPrecioDeCostoReposicion)
					{
						_producto.UsaPrecioDeCostoReposicion = value;
						//Sabrina 20100719 - Tarea 796
						_producto.ListaDePrecios.UpdatePrecios(_producto.PrecioDeCosto, _producto.MAC, _producto.PrecioDeVentaNeto);
						ListaDePreciosItem itemDefault = _producto.ListaDePrecios.GetDefaultItem();
						_producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
						//German 20090421
						/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
							_producto.PrecioLista = _producto.PrecioDeVentaNeto;
							*/
						//Fin German 20090421
						//Fin Sabrina 20100719 - Tarea 796
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
								{
									prod.UsaPrecioDeCostoReposicion = value;
									//Sabrina 20100719 - Tarea 796
									prod.ListaDePrecios.UpdatePrecios(prod.PrecioDeCosto, prod.MAC, prod.PrecioDeVentaNeto);
									ListaDePreciosItem itemDefault = prod.ListaDePrecios.GetDefaultItem();
									prod.PrecioLista = itemDefault.PrecioDeVentaBruto;
									//German 20090421
									/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
										prod.PrecioLista = prod.PrecioDeVentaNeto;
									*/
									//Fin German 20090421
									//Fin Sabrina 20100719 - Tarea 796
								}
						}
						
					}
				}
				
			}

		}
		





		// --------------------- CostoIndirectoPorc
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
		public decimal CostoIndirectoPorc1
		{
			get
			{
				if(_producto != null)
				{

					return _producto.CostoIndirectoPorc1;
				}
				return 0;
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.CostoIndirectoPorc1)
					{
						_producto.CostoIndirectoPorc1 = value;
						if(CostoIndirectoPorc1Changed != null)
							CostoIndirectoPorc1Changed(this, new EventArgs());
						
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.CostoIndirectoPorc1 = value;						
						}
					}
				}
			}
		}

		public decimal CostoIndirectoPorc2
		{
			get
			{
				if(_producto != null)
				{

					return _producto.CostoIndirectoPorc2;
				}
				return 0;
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.CostoIndirectoPorc2)
					{
						_producto.CostoIndirectoPorc2 = value;
						if(CostoIndirectoPorc2Changed != null)
							CostoIndirectoPorc2Changed(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.CostoIndirectoPorc2 = value;						
						}
					}
				}
			}
		}

		public decimal CostoIndirectoPorc3
		{
			get
			{
				if(_producto != null)
				{

					return _producto.CostoIndirectoPorc3;
				}
				return 0;
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.CostoIndirectoPorc3)
					{
						_producto.CostoIndirectoPorc3 = value;
						if(CostoIndirectoPorc3Changed != null)
							CostoIndirectoPorc3Changed(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.CostoIndirectoPorc3 = value;						
						}
					}
				}
			}
		}

		public decimal CostoIndirectoPorc4
		{
			get
			{
				if(_producto != null)
				{

					return _producto.CostoIndirectoPorc4;
				}
				return 0;
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.CostoIndirectoPorc4)
					{
						_producto.CostoIndirectoPorc4 = value;
						if(CostoIndirectoPorc4Changed != null)
							CostoIndirectoPorc4Changed(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.CostoIndirectoPorc4 = value;						
						}
					}
				}
			}
		}

		public decimal CostoIndirectoPorc5
		{
			get
			{
				if(_producto != null)
				{

					return _producto.CostoIndirectoPorc5;
				}
				return 0;
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.CostoIndirectoPorc5)
					{
						_producto.CostoIndirectoPorc5 = value;
						if(CostoIndirectoPorc5Changed != null)
							CostoIndirectoPorc5Changed(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.CostoIndirectoPorc5 = value;						
						}
					}
				}
			}
		}

		public decimal CostoIndirectoPorc6
		{
			get
			{
				if(_producto != null)
				{

					return _producto.CostoIndirectoPorc6;
				}
				return 0;
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.CostoIndirectoPorc6)
					{
						_producto.CostoIndirectoPorc6 = value;
						if(CostoIndirectoPorc6Changed != null)
							CostoIndirectoPorc6Changed(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.CostoIndirectoPorc6 = value;						
						}
					}
				}
			}
		}

		public decimal CostoIndirectoPorc7
		{
			get
			{
				if(_producto != null)
				{

					return _producto.CostoIndirectoPorc7;
				}
				return 0;
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.CostoIndirectoPorc7)
					{
						_producto.CostoIndirectoPorc7 = value;
						if(CostoIndirectoPorc7Changed != null)
							CostoIndirectoPorc7Changed(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.CostoIndirectoPorc7 = value;						
						}
					}
				}
			}
		}

		public decimal CostoIndirectoPorc8
		{
			get
			{
				if(_producto != null)
				{

					return _producto.CostoIndirectoPorc8;
				}
				return 0;
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.CostoIndirectoPorc8)
					{
						_producto.CostoIndirectoPorc8 = value;
						if(CostoIndirectoPorc8Changed != null)
							CostoIndirectoPorc8Changed(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.CostoIndirectoPorc8 = value;						
						}
					}
				}
			}
		}

		public decimal CostoIndirectoPorc9
		{
			get
			{
				if(_producto != null)
				{

					return _producto.CostoIndirectoPorc9;
				}
				return 0;
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.CostoIndirectoPorc9)
					{
						_producto.CostoIndirectoPorc9 = value;
						if(CostoIndirectoPorc9Changed != null)
							CostoIndirectoPorc9Changed(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.CostoIndirectoPorc9 = value;						
						}
					}
				}
			}
		}

		public decimal CostoIndirectoPorc10
		{
			get
			{
				if(_producto != null)
				{

					return _producto.CostoIndirectoPorc10;
				}
				return 0;
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.CostoIndirectoPorc10)
					{
						_producto.CostoIndirectoPorc10 = value;
						if(CostoIndirectoPorc10Changed != null)
							CostoIndirectoPorc10Changed(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.CostoIndirectoPorc10 = value;						
						}
					}
				}
			}
		}


		// --------------------- Recupera las descripciones de los costos indirectos
		public string CostosIndirectosDescrip1
		{
			//get{return this._producto.CostoIndirectoDescrip1;}
			get{ return this._costoIndirectoDescrip1; }
		}
		public string CostosIndirectosDescrip2
		{
			get{ return this._costoIndirectoDescrip2; }
		}
		public string CostosIndirectosDescrip3
		{
			get{ return this._costoIndirectoDescrip3; }
		}
		public string CostosIndirectosDescrip4
		{
			get{ return this._costoIndirectoDescrip4; }
		}
		public string CostosIndirectosDescrip5
		{
			get{ return this._costoIndirectoDescrip5; }
		}
		public string CostosIndirectosDescrip6
		{
			get{ return this._costoIndirectoDescrip6; }
		}
		public string CostosIndirectosDescrip7
		{
			get{ return this._costoIndirectoDescrip7; }
		}
		public string CostosIndirectosDescrip8
		{
			get{ return this._costoIndirectoDescrip8; }

		}
		public string CostosIndirectosDescrip9
		{
			get{ return this._costoIndirectoDescrip9; }
		}
		public string CostosIndirectosDescrip10
		{
			get{ return this._costoIndirectoDescrip10; }
		}


		// --------------------- getCostosIndirectos
		public bool CostoIndirectoActivo1
		{
			get
			{
				if(_producto != null)
				{
					return this._producto.CostoIndirectoActivo1;
				}
				return false;
			}
		}
		public bool CostoIndirectoActivo2
		{
			get
			{
				if(_producto != null)
				{
					return this._producto.CostoIndirectoActivo2;
				}
				return false;
			}
		}
		public bool CostoIndirectoActivo3
		{
			get
			{
				if(_producto != null)
				{
					return this._producto.CostoIndirectoActivo3;
				}
				return false;
			}
		}

		public bool CostoIndirectoActivo4
		{
			get
			{
				if(_producto != null)
				{
					return this._producto.CostoIndirectoActivo4;
				}
				return false;
			}
		}

		public bool CostoIndirectoActivo5
		{
			get
			{
				if(_producto != null)
				{
					return this._producto.CostoIndirectoActivo5;
				}
				return false;
			}
		}

		public bool CostoIndirectoActivo6
		{
			get
			{
				if(_producto != null)
				{
					return this._producto.CostoIndirectoActivo6;
				}
				return false;
			}
		}

		public bool CostoIndirectoActivo7
		{
			get
			{
				if(_producto != null)
				{
					return this._producto.CostoIndirectoActivo7;
				}
				return false;
			}
		}

		public bool CostoIndirectoActivo8
		{
			get
			{
				if(_producto != null)
				{
					return this._producto.CostoIndirectoActivo8;
				}
				return false;
			}
		}

		public bool CostoIndirectoActivo9
		{
			get
			{
				if(_producto != null)
				{
					return this._producto.CostoIndirectoActivo9;
				}
				return false;
			}
		}

		public bool CostoIndirectoActivo10
		{
			get
			{
				if(_producto != null)
				{
					return this._producto.CostoIndirectoActivo10;
				}
				return false;
			}
		}
		
		
		// --------------------- get CostosIndirectos.tipo
		public bool CostoIndirectoTipo1
		{
			get 
			{
				if(_producto != null)
				{
					return _producto.CostoIndirectoTipo1;
				}
				return false;
			}
		}
		public bool CostoIndirectoTipo2
		{
			get 
			{
				if(_producto != null)
				{
					return _producto.CostoIndirectoTipo2;
				}
				return false;
			}

		}
		public bool CostoIndirectoTipo3
		{
			get 
			{
				if(_producto != null)
				{
					return _producto.CostoIndirectoTipo3;
				}
				return false;
			}

		}
		public bool CostoIndirectoTipo4
		{
			get 
			{
				if(_producto != null)
				{
					return _producto.CostoIndirectoTipo4;
				}
				return false;
			}

		}
		public bool CostoIndirectoTipo5
		{
			get 
			{
				if(_producto != null)
				{
					return _producto.CostoIndirectoTipo5;
				}
				return false;
			}

		}
		public bool CostoIndirectoTipo6
		{
			get 
			{
				if(_producto != null)
				{
					return _producto.CostoIndirectoTipo6;
				}
				return false;
			}

		}
		public bool CostoIndirectoTipo7
		{
			get 
			{
				if(_producto != null)
				{
					return _producto.CostoIndirectoTipo7;
				}
				return false;
			}

		}
		public bool CostoIndirectoTipo8
		{
			get 
			{
				if(_producto != null)
				{
					return _producto.CostoIndirectoTipo8;
				}
				return false;
			}

		}
		public bool CostoIndirectoTipo9
		{
			get 
			{
				if(_producto != null)
				{
					return _producto.CostoIndirectoTipo9;
				}
				return false;
			}

		}
		public bool CostoIndirectoTipo10
		{
			get 
			{
				if(_producto != null)
				{
					return _producto.CostoIndirectoTipo10;
				}
				return false;
			}

		}

		
		public bool HayProductoSeleccionado
		{
			get{
				if ( _productos.Count > 0 )
					return true;
				else
					return false;				
			}
		}
		
	
		// ------ Casi-Deprecated (se usa para guardar los coef, en PORCENTAJES, en la tabla tsh_productosAuxiliares)
		public decimal Coeficiente1
		{
			get
			{
				if(_producto != null)
				{

					return _producto.Coeficiente1;
				}
				return 0;
			}
			/*
			set
			{
				if(_producto != null)
				{
					if(value != _producto.Coeficiente1)
					{
						_producto.Coeficiente1 = value;
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.Coeficiente1 = value;
						
						}
					}
				}
			}*/
		}

		public decimal Coeficiente2
		{
			get
			{
				if(_producto != null)
				{

					return _producto.Coeficiente2;
				}
				return 0;
			}
		}

		public decimal Coeficiente3
		{
			get
			{
				if(_producto != null)
				{

					return _producto.Coeficiente3;
				}
				return 0;
			}
		}

		public decimal Coeficiente4
		{
			get
			{
				if(_producto != null)
				{

					return _producto.Coeficiente4;
				}
				return 0;
			}
		}

		public decimal Coeficiente5
		{
			get
			{
				if(_producto != null)
				{

					return _producto.Coeficiente5;
				}
				return 0;
			}
		}

		// ------ endDeprecated

		public string SimboloMonedaDescuentoMaximo
		{
			get
			{
				if(_producto != null)
				{

					return _producto.SimboloMonedaDescuentoMaximo;
				}
				return string.Empty;
			}
		}

		public string SimboloMonedaPrecioDeCostoReferencia
		{
			get
			{
				if(_producto != null)
				{

					return _producto.SimboloMonedaOrigen;
				}
				return string.Empty;
			}
		}

		public string SimboloMonedaPrecioDeLista
		{
			get
			{
				if(_producto != null)
				{

					return _producto.SimboloMonedaPrecioDeLista;
				}
				return string.Empty;
			}
		}

		public string SimboloMonedaPrecioDeVentaNeto
		{
			get
			{
				if(_producto != null)
				{

					return _producto.SimboloMonedaPrecioDeVentaNeto;
				}
				return string.Empty;
			}
		}
		
		
		public string SimboloMonedaOrigen
		{
			get
			{
				if(_producto != null)
				{

					return _producto.SimboloMonedaOrigen;
				}
				return string.Empty;
			}
		}
		
		public string SimboloMonedaReferencia
		{
			get{return _simboloMonedaReferencia;}
		}

		public string SimboloMonedaComprador
		{
			get{return  _simboloMonedaComprador;}
		}

		public string SimboloMonedaProveedor
		{
			get{return _simboloMonedaProveedor;}
		}

		public ProductosCollection Productos
		{
			get{return _productos;}
		}

		
		public DataTable TableMonedas
		{
			get{return _tableMonedas;}
		}

		public DataTable TableFuentesDeCambio
		{
			get{return _tableFuentesDeCambio;}
		}

		public string IdMonedaReferencia
		{
			get{return _idMonedaReferencia;}
		}

		public string IdFuenteDeCambioReferencia
		{
			get{return _idFuenteDeCambioReferencia;}
		}

		public string IdMonedaProveedor
		{
			get{return _idMonedaProveedor;}
			set{_idMonedaProveedor = value;}
		}

		public string IdMonedaComprador
		{
			get{return _idMonedaComprador;}
			set{_idMonedaComprador = value;}
		}

		public decimal ValorCotizacionFuenteDeCambioComprador 
		{
			get{return _valorCotizacionFuenteDeCambioComprador;}
		}

		public decimal ValorCotizacionFuenteDeCambioProveedor
		{
			get{return _valorCotizacionFuenteDeCambioProveedor;}
		}


		public string IdFuenteDeCambioProveedor
		{
			get{return _idFuenteDeCambioProveedor;}
			set
			{
				if(_idFuenteDeCambioProveedor != value)
				{
					_idFuenteDeCambioProveedor = value;
					if(_idFuenteDeCambioProveedor != null && !_idFuenteDeCambioProveedor.Equals(string.Empty))
					{
						if(_idMonedaProveedor != null && !_idMonedaProveedor.Equals(string.Empty))
						{
							GenerateCotizacionProveedor();
							_productos.SetCotizacionProveedor(_cotizacionProveedor);
							if(ObjectHasChanged != null)
								ObjectHasChanged(this, new EventArgs());
						}
					}

				}
			
			}
		}

		public decimal StockDisponible
		{
			get
			{
				if(_producto != null)
				{
					return _producto.Stock;
				}
				return 0;
			}
		}

		public decimal PrecioCostoAnterior
		{
			get
			{
				if(_producto != null)
				{
					return _producto.PrecioDeCostoAnterior;
				}
				return 0;

			}
		}

		public string CodigoProducto
		{
			get
			{
				if(_producto != null)
				{
					return _producto.Codigo;
				}
				return string.Empty;
			}
			set
			{
				if(value != null && value != string.Empty)
				{
					string IdProd = mz.erp.businessrules.tsh_Productos.GetPkByCodigo(value);
					/*Agregar la cantidad q se toma de otra porpiedad de esta tarea*/
					GenerateProducto(IdProd, 0);
				}
			}
		}

		public decimal PrecioDeCostoMonedaProveedor
		{
			get
			{
				if(_producto != null)
					return _producto.PrecioDeCostoMonedaProveedor;
				return 0;
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.PrecioDeCostoMonedaProveedor)
					{
						_producto.PrecioDeCostoMonedaProveedor = value;
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
						if(PrecioDeCostoMonedaProveedorChanged != null)
							PrecioDeCostoMonedaProveedorChanged(this, new EventArgs());

					}
					
					if(_seleccionMultilple)
					{
						/*
						if(ChequearMonedaPrecioDeVenta())
						{
						*/
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.PrecioDeCostoMonedaProveedor = value;
						}
						/*}
						else
							if(SeleccionMultiplePrecioDeVentaError != null)
								SeleccionMultiplePrecioDeVentaError(this, new EventArgs());
						*/
					}
				}

			}
		}

		public decimal PrecioDeCosto
		{
			get
			{
				if(_producto != null)
					return _producto.PrecioDeCostoPromedioPonderado;
				return 0;
			}
			
		}

		public decimal PrecioCostoMonedaReferencia
		{
			get
			{
				if(_producto != null)
					return _producto.PrecioCostoMonedaReferencia;
				return 0;
			}
		}

		public decimal PrecioDeCostoMonedaProducto
		{
			get
			{
				if(_producto != null)
					return _producto.PrecioDeCostoMonedaProducto;
				return 0;
			}
			set
			{
				
				if(_producto != null)
				{
					_producto.PrecioDeCostoMonedaProducto = value;
				}
				if(_seleccionMultilple)
				{
					if(ChequearMonedaPrecioDeVenta())
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.PrecioDeCostoMonedaProducto = value;
						}
					}
					else
						if(SeleccionMultiplePrecioDeVentaError != null)
							SeleccionMultiplePrecioDeVentaError(this, new EventArgs());
				}
			}
		}

		/*
		public decimal PrecioCostoProveedorConvertidoMonedaFuenteCambioOficial
		{
			get
			{
				if(_producto != null)
					return _producto.PrecioCostoProveedorConvertidoMonedaFuenteCambioOficial;
				return 0;
			}
		}
		*/
		/*
		public decimal PrecioCostoProveedorConvertidoMonedaComprador
		{
			get
			{
				if(_producto != null)
					return _producto.PrecioCostoProveedorConvertidoMonedaComprador;
				return 0;
			}
		}
		*/

		public decimal Cantidad
		{
			get
			{
				if(_producto != null)
				{
					return _producto.Cantidad;
				}
				return 0;
			}
			set
			{
				
				if(_producto != null)
				{
					_producto.Cantidad = value;
				}
			}
		}


		public decimal MAC
		{		
			get
			{	
				if(_producto != null)
					return _producto.MAC;
				return 0;
			
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.MAC)
					{
						_producto.MAC = value;
						//Sabrina 20100719 - Tarea 796
						/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
							_producto.PrecioLista = _producto.PrecioDeVentaNeto;
							*/
						//Fin Sabrina 20100719 - Tarea 796
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
								{
									prod.MAC = value;
									//Sabrina 20100719 - Tarea 796
									/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
										prod.PrecioLista = prod.PrecioDeVentaNeto;
										*/
									//Fin Sabrina 20100719 - Tarea 796
								}
						}
						
					}
				}
				
			}
			

		}

		public decimal PrecioDeVentaNeto
		{
			get
			{
				if(_producto != null)
				{
					return _producto.PrecioDeVentaNeto;
				}
				else return 0;

			}
		}

		public decimal MaximoDescuento
		{
			get
			{
				if(_producto != null)
				{
					return _producto.MaximoDescuento;
				}
				return 0;
			}
		}

		public decimal PorcentajeMaximoDescuento
		{
			get
			{
				if(_producto != null)
				{
					return _producto.PorcentajeMaximoDescuento;
				}
				return 0;
			}
			set 
			{
				
				if(value != _producto.PorcentajeMaximoDescuento)
				{
					_producto.PorcentajeMaximoDescuento = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
				if(_seleccionMultilple)
				{
					foreach(Producto prod in _productos)
					{
						if(prod != _producto)
							if(prod.Selected)
								prod.PorcentajeMaximoDescuento = value;
					}
				}
			}

		}


		public decimal PrecioDeVentaBruto
		{
			get
			{
				if(_producto != null)
				{
					return _producto.PrecioLista;
				}
				return 0;
			}
			set 
			{
				
				if(value != _producto.PrecioLista)
				{
					_producto.PrecioLista = value;
					
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
				if(_seleccionMultilple)
				{
					if(ChequearMonedaPrecioDeVenta())
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
									prod.PrecioLista = value;
						}
					}
					else
						if(SeleccionMultiplePrecioDeVentaError != null)
						SeleccionMultiplePrecioDeVentaError(this, new EventArgs());
				}
			}
		}

		public decimal PrecioCostoRef
		{
			get
			{
				if(_producto != null)
				{
					return _producto.PrecioDeCosto;
				}
				return 0;

			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.PrecioDeCosto)
					{
						_producto.PrecioDeCosto = value;
						if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
							_producto.PrecioLista = _producto.PrecioDeVentaNeto;
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						if(ChequearMonedaPrecioDeCosto())
						{
							foreach(Producto prod in _productos)
							{
								if(prod != _producto)
									if(prod.Selected)
									{
										prod.PrecioDeCosto = value;
										if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
											prod.PrecioLista = prod.PrecioDeVentaNeto;
									}
							}
						}
						else
							if(SeleccionMultiplePrecioDeCostoError != null)
							SeleccionMultiplePrecioDeCostoError(this, new EventArgs());
					}
				}
				
			}
		}

		public Producto SelectedItem
		{
			get{return _producto;}
			set
			{
				
				if(value != null)
				{
					Producto prod = (Producto) value;
					if(prod != _producto)
					{
						_producto = prod;
						_producto.PrecioDeVentaAfectaMac = PrecioDeVentaAfectaMac;
						// matias
						bool existeProv = false;
						foreach(ListaDePreciosProveedoresItem proveedor in _producto.ListaDePreciosProveedores.Items)
						{
							if(proveedor.IdProveedor == IdProveedor) existeProv = true;						
						}
						// fin					
						//German 20090313
						//German 20090325
                        //German 20110309 - Tarea 0000038
						if(! existeProv && Workflow.NOEsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName)
							/*!_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia") &&
							!_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior")*/)
                        //Fin German 20110309 - Tarea 0000038
						//Fin German 20090325
						{
							if(_producto.IdProveedorDefault != null && _producto.IdProveedorDefault != string.Empty)
								_idProveedorListaDePrecios = _producto.IdProveedorDefault;
							else
							{
								if(_producto.ListaDePreciosProveedores.Items.Count > 0)
								{
									ListaDePreciosProveedoresItem lpi = (ListaDePreciosProveedoresItem) _producto.ListaDePreciosProveedores.Items[0];
									_idProveedorListaDePrecios = lpi.IdProveedor;
								}

							}
						}
						
						if(IdProveedor != null && !IdProveedor.Equals(string.Empty)/*German 20090313*/ /*&& existeProv*/)
						//Fin
						{
							_listaDePreciosProveedoresItemSeleccionado = _producto.ListaDePreciosProveedores.getListaDePreciosProveedoresItem(_idProveedorListaDePrecios);
							if(_listaDePreciosProveedoresItemSeleccionado == null)
							{
								string IdMonedaPrecioDeCostoProveedor = _producto.IdMonedaPrecioDeCosto;
								string IdFuenteDeCambioListaProveedor = _producto.IdFuenteDeCambioProductoPrecioDeCosto;
								string IdCotizacionPrecioDeCostoProveedor = _producto.IdCotizacionMonedaPrecioDeCosto;
								string IdMonedaProveedor = _producto.IdMonedaPrecioDeCosto;
								string IdFuenteDeCambioProveedor = _producto.IdFuenteDeCambioProductoPrecioDeCosto;
								string IdCotizacionProveedor = _producto.IdCotizacionMonedaPrecioDeCosto;
								if(_usaCotizacionDefault)
								{
									IdMonedaProveedor = _idMonedaReferencia;
									IdFuenteDeCambioProveedor = _idFuenteDeCambioProveedor;
									IdCotizacionProveedor = Variables.GetValueString("Contabilidad.CotizacionReferencia");
								}
								ListaDePreciosProveedoresItem it = new ListaDePreciosProveedoresItem(_producto.IdProducto, _idProveedorListaDePrecios, IdMonedaPrecioDeCostoProveedor, IdFuenteDeCambioListaProveedor, IdCotizacionPrecioDeCostoProveedor, IdCotizacionProveedor, IdFuenteDeCambioProveedor, IdMonedaProveedor, _bonificacionesAcumulativas);
								_producto.ListaDePreciosProveedores.AddItem(it);
								_listaDePreciosProveedoresItemSeleccionado = it;
							}
							_existeProveedorProducto = !_listaDePreciosProveedoresItemSeleccionado.isNew();

						}else
							//German 20090729
							//_listaDePreciosProveedoresItemSeleccionado = null;
							SetListaDePreciosProveedoresItemSeleccionadoNull();
							//Fin German 20090729
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
				}
								
			}
		}


		public ArrayList Items
		{
			get{return _productos.ToArrayList();}
		}

		public void SetSelectedItemNull()
		{
			_producto = null;
		}

		public bool HabilitaTrasladarPrecioDeListaFinal
		{
			get
			{
				return _habilitaTrasladarPrecioDeListaFinal;
			}
		}

		
		
		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonAnterior";
				valor = Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonAnterior";
					valor = Variables.GetValueString(variable);				
				}									
				
				if (valor == String.Empty) 
				{
					return _textoBotonAnterior;
				}
				else 
				{
					return valor;
				}							
			}
		}
		private string _textoBotonSiguiente = "Siguiente";
		public string TextoBotonSiguiente
		{
			get 
			{		
				string valor = String.Empty;				
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonSiguiente";
				valor = Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonSiguiente";
					valor = Variables.GetValueString(variable);				
				}									
				
				if (valor == String.Empty) 
				{
					return _textoBotonSiguiente;
				}
				else 
				{
					return valor;
				}
			}
		}


		public string IdCotizacionFuenteDeCambioComprador
		{
			get{return _idCotizacionFuenteDeCambioComprador;}
		}
		
		public ListaDePreciosItem ListaDePreciosItemSeleccionado
		{
			get{return _listaDePreciosItemSeleccionado;}
			set
			{
				if(value != null)
				{
					ListaDePreciosItem itemLP = (ListaDePreciosItem) value;
					if(itemLP != _listaDePreciosItemSeleccionado)
                    /* Silvina 20110712 - Tarea 0000141 */
					//{
						_listaDePreciosItemSeleccionado = itemLP;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
					//}
                    /* Fin Silvina 20110712 - Tarea 0000141 */
				}
								
			}
		}

		public decimal CoeficienteProductoLPItem
		{		
			get
			{	
				if(_listaDePreciosItemSeleccionado != null)
					return _listaDePreciosItemSeleccionado.CoeficienteProducto;
				return 0;
			
			}
			set
			{
				if(_listaDePreciosItemSeleccionado != null)
				{
					if(value != _listaDePreciosItemSeleccionado.CoeficienteProducto)
					{
						_producto.ListaDePrecios.UpdateCoeficiente(_listaDePreciosItemSeleccionado, value);
						if(_listaDePreciosItemSeleccionado.IsDefault)
							_producto.PrecioLista = _listaDePreciosItemSeleccionado.PrecioDeVentaBruto;
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
								{
									prod.ListaDePrecios.UpdateCoeficiente(prod.IdProducto, _listaDePreciosItemSeleccionado.IdListaDePrecios, value);
									ListaDePreciosItem item = prod.ListaDePrecios.GetItem(prod.IdProducto, _listaDePreciosItemSeleccionado.IdListaDePrecios);
									if(item.IsDefault)
										prod.PrecioLista = item.PrecioDeVentaBruto;
								}
						}
						
					}
				}
				
			}
			

		}

		public decimal CoeficienteProductoMonedaRefLPItem
		{		
			get
			{	
				if(_listaDePreciosItemSeleccionado != null)
					return _listaDePreciosItemSeleccionado.CoeficienteProductoMonedaReferencia;
				return 0;
			
			}
			set
			{
				if(_listaDePreciosItemSeleccionado != null)
				{
					if(value != _listaDePreciosItemSeleccionado.CoeficienteProductoMonedaReferencia)
					{
						decimal coeficienteNew = _listaDePreciosItemSeleccionado.GetCoeficienteFromCoeficienteMonedaRef(value);
						CoeficienteProductoLPItem = coeficienteNew;
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
								{
									ListaDePreciosItem item = prod.ListaDePrecios.GetItem(prod.IdProducto, _listaDePreciosItemSeleccionado.IdListaDePrecios);
									decimal coeficienteNew = item.GetCoeficienteFromCoeficienteMonedaRef(value);
									CoeficienteProductoLPItem = coeficienteNew;
								}
						}
						
					}
				}
				
			}
			

		}

		public decimal MaxDescuentoPorcentualLPItem
		{		
			get
			{	
				if(_listaDePreciosItemSeleccionado != null)
					return _listaDePreciosItemSeleccionado.PorcentajeMaximoDescuento;
				return 0;
			}
		}

		public decimal MaxDescuentoLPItem
		{		
			get
			{	
				if(_listaDePreciosItemSeleccionado != null)
					return _listaDePreciosItemSeleccionado.MaxDescuento;
				return 0;
			}
		}

		public decimal PrecioVentaBrutoLPItem
		{		
			get
			{	
				if(_listaDePreciosItemSeleccionado != null)
					return _listaDePreciosItemSeleccionado.PrecioDeVentaBruto;
				return 0;			
			}
			set
			{
				if(_listaDePreciosItemSeleccionado != null)
				{
					if(value != _listaDePreciosItemSeleccionado.PrecioDeVentaBruto)
					{
						if(_listaDePreciosItemSeleccionado.IsDefault)
							_producto.PrecioLista = value;
						decimal coeficienteNew = _listaDePreciosItemSeleccionado.GetCoeficienteFromPrecioVentaBruto(value);
						CoeficienteProductoLPItem = coeficienteNew;
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
								{
									ListaDePreciosItem item = prod.ListaDePrecios.GetItem(prod.IdProducto, _listaDePreciosItemSeleccionado.IdListaDePrecios);
									if(item.IsDefault)
										prod.PrecioLista = value;
									decimal coeficienteNew = item.GetCoeficienteFromPrecioVentaBruto(value);
									CoeficienteProductoLPItem = coeficienteNew;
								}
						}
						
					}
				}
				
			}

		}

		public decimal PrecioDeListaConImpuestoLPItem
		{		
			get
			{	
				if(_listaDePreciosItemSeleccionado != null)
					return _listaDePreciosItemSeleccionado.PrecioDeVentaBrutoConImpuestos;
				return 0;			
			}
			set
			{
				if(_listaDePreciosItemSeleccionado != null)
				{
					if(value != _listaDePreciosItemSeleccionado.PrecioDeVentaBrutoConImpuestos)
					{
						//Sabrina 20100716 - Tarea 796
						if(_listaDePreciosItemSeleccionado.IsDefault)
							_producto.PrecioDeListaConImpuestos = value;
						//Fin Sabrina 20100716 - Tarea 796
						decimal coeficienteNew = _listaDePreciosItemSeleccionado.GetCoeficienteFromPrecioVentaBrutoConImp(value);
						CoeficienteProductoLPItem = coeficienteNew;
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
								{
									ListaDePreciosItem item = prod.ListaDePrecios.GetItem(prod.IdProducto, _listaDePreciosItemSeleccionado.IdListaDePrecios);
									//Sabrina 20100716 - Tarea 796
									if(item.IsDefault)
										prod.PrecioDeListaConImpuestos = value;
                                    //Fin Sabrina 20100716 - Tarea 796

                                    //German 20111114 - Tarea 0000226
									decimal coeficienteNew = item.GetCoeficienteFromPrecioVentaBrutoConImp(value);
									//CoeficienteProductoLPItem = coeficienteNew;
                                    if (value != _listaDePreciosItemSeleccionado.CoeficienteProducto)
                                    {
                                        prod.ListaDePrecios.UpdateCoeficiente(prod.IdProducto, _listaDePreciosItemSeleccionado.IdListaDePrecios, coeficienteNew);
                                        if (item.IsDefault)
                                            prod.PrecioLista = item.PrecioDeVentaBruto;
                                        //if (ObjectHasChanged != null)
                                        //    ObjectHasChanged(this, new EventArgs());
                                    }
                                    //German 20111114 - Tarea 0000226
								}
						}
						
					}
				}
				
			}

		}


		public decimal PrecioFinalMonedaReferenciaLPItem
		{		
			get
			{	
				if(_listaDePreciosItemSeleccionado != null)
					return _listaDePreciosItemSeleccionado.PrecioDeVentaBrutoConImpuestosMonedaReferencia;
				return 0;			
			}
			set
			{
				if(_listaDePreciosItemSeleccionado != null)
				{
					if(value != _listaDePreciosItemSeleccionado.PrecioDeVentaBrutoConImpuestosMonedaReferencia)
					{
						//Sabrina 20100716 - Tarea 796
						if(_listaDePreciosItemSeleccionado.IsDefault)
							_producto.PrecioDeListaConImpuestosMonedaReferencia = value;
						//Fin Sabrina 20100716 - Tarea 796
						decimal coeficienteNew = _listaDePreciosItemSeleccionado.GetCoeficienteFromPrecioVentaBrutoConImpMonedaRef(value);
						CoeficienteProductoLPItem = coeficienteNew;
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
								{
									ListaDePreciosItem item = prod.ListaDePrecios.GetItem(prod.IdProducto, _listaDePreciosItemSeleccionado.IdListaDePrecios);
									//Sabrina 20100716 - Tarea 796
									if(item.IsDefault)
										prod.PrecioDeListaConImpuestosMonedaReferencia = value;
									//Fin Sabrina 20100716 - Tarea 796
                                    //German 20111114  - Tarea 0000226
                                    decimal coeficienteNew = item.GetCoeficienteFromPrecioVentaBrutoConImp(value);
                                    //CoeficienteProductoLPItem = coeficienteNew;
                                    if (value != _listaDePreciosItemSeleccionado.CoeficienteProducto)
                                    {
                                        prod.ListaDePrecios.UpdateCoeficiente(prod.IdProducto, _listaDePreciosItemSeleccionado.IdListaDePrecios, coeficienteNew);
                                        if (item.IsDefault)
                                            prod.PrecioLista = item.PrecioDeVentaBruto;
                                        //if (ObjectHasChanged != null)
                                        //    ObjectHasChanged(this, new EventArgs());
                                    }
                                    //German 20111114  - Tarea 0000226
								}
						}
						
					}
				}
				
			}

		}

		public decimal PrecioCostoRefLPItem
		{		
			get
			{	
				if(_producto != null)
					return _producto.PrecioDeCosto;
				return 0;			
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.PrecioDeCosto)
					{
						_producto.PrecioDeCosto = value;
						_producto.ListaDePrecios.UpdatePrecios(value, _producto.MAC, _producto.PrecioDeVentaNeto);
						ListaDePreciosItem itemDefault = _producto.ListaDePrecios.GetDefaultItem();
						_producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
								{
									prod.PrecioDeCosto = value;
									prod.ListaDePrecios.UpdatePrecios(value, prod.MAC, prod.PrecioDeVentaNeto);
									ListaDePreciosItem itemDefault = prod.ListaDePrecios.GetDefaultItem();
									prod.PrecioLista = itemDefault.PrecioDeVentaBruto;

								}
						}
						
					}
				}
				
			}

		}
		
		public decimal MACLPItem
		{		
			get
			{	
				if(_producto != null)
					return _producto.MAC;
				return 0;			
			}
			set
			{
				if(_producto != null)
				{
					if(value != _producto.MAC)
					{
						_producto.MAC = value;
						_producto.ListaDePrecios.UpdatePrecios(_producto.PrecioDeCosto, value, _producto.PrecioDeVentaNeto);
						ListaDePreciosItem itemDefault = _producto.ListaDePrecios.GetDefaultItem();
						_producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
								{
									prod.MAC = value;
									prod.ListaDePrecios.UpdatePrecios(prod.PrecioDeCosto, value, prod.PrecioDeVentaNeto);
									ListaDePreciosItem itemDefault = prod.ListaDePrecios.GetDefaultItem();
									prod.PrecioLista = itemDefault.PrecioDeVentaBruto;

								}
						}
						
					}
				}
				
			}

		}

		public bool ListaDePreciosHabilitadas
		{
			get{return _listaDePreciosHabilitadas;}
		}

		public bool UsaPrecioDeListaProveedor
		{
			get{return _usaPrecioDeListaProveedor;}
		}


		private string _idProveedorListaDePrecios = string.Empty;

		//Matias 20100612 - Tarea 22
		public string CodigoProveedor
		{
			get {
				if (!this.IdProveedor.Equals(string.Empty))
				{
					Proveedor proveedor = new Proveedor();
					proveedor.GetProveedor_IdProveedor(this.IdProveedor);
					return proveedor.Codigo;
				}
				return string.Empty;
			}
			set {
				//_codigoProveedor = value;
				if(value != null && !value.Equals(string.Empty))
				{
					Proveedor proveedor = new Proveedor();
					proveedor.GetCuenta_CodigoProveedor(value);
					this.IdProveedor = proveedor.IdProveedor;
				}
				else
					this.IdProveedor = string.Empty;
			}
		}
		//Fin Matias 20100612 - Tarea 22
		
		public string IdProveedor
		{
			get {return _idProveedorListaDePrecios;}
			set
			{
				if(_idProveedorListaDePrecios != value && value != string.Empty)
				{
					_idProveedorListaDePrecios = value;
					if(_producto != null)
					{
						
						_listaDePreciosProveedoresItemSeleccionado = _producto.ListaDePreciosProveedores.getListaDePreciosProveedoresItem(_idProveedorListaDePrecios);
						if(_listaDePreciosProveedoresItemSeleccionado == null)
						{
							string IdMonedaPrecioDeCostoProveedor = _producto.IdMonedaPrecioDeCosto;
							string IdFuenteDeCambioListaProveedor = _producto.IdFuenteDeCambioProductoPrecioDeCosto;
							string IdCotizacionPrecioDeCostoProveedor = _producto.IdCotizacionMonedaPrecioDeCosto;
							string IdMonedaProveedor = _producto.IdMonedaPrecioDeCosto;
							string IdFuenteDeCambioProveedor = _producto.IdFuenteDeCambioProductoPrecioDeCosto;
							string IdCotizacionProveedor = _producto.IdCotizacionMonedaPrecioDeCosto;
							if(_usaCotizacionDefault)
							{
								IdMonedaProveedor = _idMonedaReferencia;
								IdFuenteDeCambioProveedor = _idFuenteDeCambioProveedor;
								IdCotizacionProveedor = Variables.GetValueString("Contabilidad.CotizacionReferencia");
							}
							ListaDePreciosProveedoresItem it = new ListaDePreciosProveedoresItem(_producto.IdProducto, _idProveedorListaDePrecios, IdMonedaPrecioDeCostoProveedor, IdFuenteDeCambioListaProveedor, IdCotizacionPrecioDeCostoProveedor, IdCotizacionProveedor, IdFuenteDeCambioProveedor, IdMonedaProveedor, _bonificacionesAcumulativas);
							_producto.ListaDePreciosProveedores.AddItem(it);
							_listaDePreciosProveedoresItemSeleccionado = it;
						}
						_existeProveedorProducto = !_listaDePreciosProveedoresItemSeleccionado.isNew();
						if(_producto.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal && !_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia")*/)
							_producto.PrecioDeCostoMonedaProducto = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _producto.ValorCotizacionPrecioDeCosto;
                        //German 20110309 - Tarea 0000038
                        //if(_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia") || _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior"))
                        if ( Workflow.EsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName))
                        //Fin German 20110309 - Tarea 0000038
						{
							if(_producto.OrdenDeCompraItem != null)
							{
								_producto.PrecioDeCostoMonedaProveedor = _producto.OrdenDeCompraItem.PrecioDeCosto * _producto.OrdenDeCompraItem.ValorCotizacion / _cotizacionProveedor.Valor;
							}
							else
							{
								if(_usaPrecioDeListaProveedor)
									_producto.PrecioDeCostoMonedaProveedor = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _cotizacionProveedor.Valor;
								else
									_producto.PrecioDeCostoMonedaProveedor = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoUltimaCompra * _producto.ValorCotizacionPrecioDeCosto / _cotizacionProveedor.Valor ;
							}
						}
						if(ListaDePreciosProveedoresHasChanged != null)
							ListaDePreciosProveedoresHasChanged(this, new EventArgs());
						/*if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());*/
						if(_seleccionMultilple)
						{
							foreach(Producto prod in _productos)
							{
								if(prod != _producto)
									if(prod.Selected)
									{
										ListaDePreciosProveedoresItem listaDePreciosProveedoresItemSeleccionado = prod.ListaDePreciosProveedores.getListaDePreciosProveedoresItem(_idProveedorListaDePrecios);
										if(listaDePreciosProveedoresItemSeleccionado == null)
										{
											string IdMonedaPrecioDeCostoProveedor = prod.IdMonedaPrecioDeCosto;
											string IdFuenteDeCambioListaProveedor = prod.IdFuenteDeCambioProductoPrecioDeCosto;
											string IdCotizacionPrecioDeCostoProveedor = prod.IdCotizacionMonedaPrecioDeCosto;
											string IdMonedaProveedor = _producto.IdMonedaPrecioDeCosto;
											string IdFuenteDeCambioProveedor = _producto.IdFuenteDeCambioProductoPrecioDeCosto;
											string IdCotizacionProveedor = _producto.IdCotizacionMonedaPrecioDeCosto;
											if(_usaCotizacionDefault)
											{
												IdMonedaProveedor = _idMonedaReferencia;
												IdFuenteDeCambioProveedor = _idFuenteDeCambioProveedor;
												IdCotizacionProveedor = Variables.GetValueString("Contabilidad.CotizacionReferencia");
											}
											ListaDePreciosProveedoresItem it = new ListaDePreciosProveedoresItem(prod.IdProducto, _idProveedorListaDePrecios, IdMonedaPrecioDeCostoProveedor, IdFuenteDeCambioListaProveedor, IdCotizacionPrecioDeCostoProveedor, IdCotizacionProveedor, IdFuenteDeCambioProveedor, IdMonedaProveedor, _bonificacionesAcumulativas);
											prod.ListaDePreciosProveedores.AddItem(it);
											
										}
									}
							}
						}
					}
					else
						//German 20090729
						//_listaDePreciosProveedoresItemSeleccionado = null;
						SetListaDePreciosProveedoresItemSeleccionadoNull();
					//Fin German 20090729
					
				}
				//Sabrina: tarea 56
				else if(value == string.Empty)
				{
					_idProveedorListaDePrecios = value;
					//German 20090729
					//_listaDePreciosProveedoresItemSeleccionado = null;
					SetListaDePreciosProveedoresItemSeleccionadoNull();
					//Fin German 20090729
				}
				
			}		
		}	
		
		public void AplicarCoeficienteSobrePrecioCostoListaProveedor(decimal coef)
		{
			if(_listaDePreciosProveedoresItemSeleccionado != null)
			{
				//if(value != _listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto)
				//{
				decimal nuevoCosto = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto + (_listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto * coef /100);
				_listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto = nuevoCosto;
				recalcularBonificaciones(_listaDePreciosProveedoresItemSeleccionado);
				_listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto + _listaDePreciosProveedoresItemSeleccionado.Bonificacion1 + _listaDePreciosProveedoresItemSeleccionado.Bonificacion2 + _listaDePreciosProveedoresItemSeleccionado.Bonificacion3 + _listaDePreciosProveedoresItemSeleccionado.Bonificacion4 + _listaDePreciosProveedoresItemSeleccionado.Bonificacion5;
				if(_producto.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
				{
					_producto.PrecioDeCostoMonedaProducto = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _producto.ValorCotizacionPrecioDeCosto;
					/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
						_producto.PrecioLista = _producto.PrecioDeVentaNeto;*/
                    _producto.ListaDePrecios.UpdatePrecios(_producto.PrecioDeCosto, _producto.MAC, _producto.PrecioDeVentaNeto);
                    ListaDePreciosItem itemDefault = _producto.ListaDePrecios.GetDefaultItem();
                    _producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
							
				}
						
                //German 20110309 - Tarea 0000038
				//if(_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && (_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia")  || _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior")))
                if (_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && Workflow.EsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName))
                //Fin German 20110309 - Tarea 0000038
				{
					_precioDeCostoMonedaProveedorAnterior = _producto.PrecioDeCostoMonedaProveedor;
					_producto.PrecioDeCostoMonedaProveedor = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _cotizacionProveedor.Valor;						
				}
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
				//}
				if(_seleccionMultilple)
				{
					foreach(Producto prod in _productos)
					{
						if(prod != _producto)
							if(prod.Selected)
							{
								ListaDePreciosProveedoresItem item = prod.ListaDePreciosProveedores.getListaDePreciosProveedoresItem(_idProveedorListaDePrecios);
								decimal costo = item.PrecioDeCosto + (item.PrecioDeCosto * coef /100);
								item.PrecioDeCosto = costo;
								recalcularBonificaciones(item);
								//German 20090729
								//item.PrecioDeCostoFinal = item.PrecioDeCosto + item.Bonificacion1 + item.Bonificacion2 + item.Bonificacion3 + item.Bonificacion4 + item.Bonificacion5;
								item.SetPrecioDeCostoFinal(item.PrecioDeCosto + item.Bonificacion1 + item.Bonificacion2 + item.Bonificacion3 + item.Bonificacion4 + item.Bonificacion5);
								//Fin German 20090729
								if(prod.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
								{
									prod.PrecioDeCostoReposicion = (item.PrecioDeCostoFinal * item.ValorCotizacionProveedor) / prod.ValorCotizacionPrecioDeCosto;
									prod.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / prod.ValorCotizacionPrecioDeCosto;
									/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
										prod.PrecioLista = prod.PrecioDeVentaNeto;
                                     */
                                    prod.ListaDePrecios.UpdatePrecios(prod.PrecioDeCosto, prod.MAC, prod.PrecioDeVentaNeto);
                                    ListaDePreciosItem itemDefault = prod.ListaDePrecios.GetDefaultItem();
                                    prod.PrecioLista = itemDefault.PrecioDeVentaBruto;
								}
							}
					}
						
				}
			}

		}


		public decimal PrecioDeCostoProdProv
		{
			get 
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
					return _listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto;
				return 0;
			}
			set 
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
				{
					if(value != _listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto)
					{
						_listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto = value;
						recalcularBonificaciones(_listaDePreciosProveedoresItemSeleccionado);
						_listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto + _listaDePreciosProveedoresItemSeleccionado.Bonificacion1 + _listaDePreciosProveedoresItemSeleccionado.Bonificacion2 + _listaDePreciosProveedoresItemSeleccionado.Bonificacion3 + _listaDePreciosProveedoresItemSeleccionado.Bonificacion4 + _listaDePreciosProveedoresItemSeleccionado.Bonificacion5;
						if(_producto.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
						{
							_producto.PrecioDeCostoMonedaProducto = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _producto.ValorCotizacionPrecioDeCosto;
							//Sabrina 20100719 - Tarea 796
							_producto.ListaDePrecios.UpdatePrecios(_producto.PrecioDeCosto, _producto.MAC, _producto.PrecioDeVentaNeto);
							ListaDePreciosItem itemDefault = _producto.ListaDePrecios.GetDefaultItem();
							_producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
							/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
								_producto.PrecioLista = _producto.PrecioDeVentaNeto;
								*/
							//Fin Sabrina 20100719 - Tarea 796
						}
						if(_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && (_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia")  || _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior")))
						{
							_precioDeCostoMonedaProveedorAnterior = _producto.PrecioDeCostoMonedaProveedor;
							
							/*German reemplaza la linea comentada por el bloque siguiente*/
							/*_producto.PrecioDeCostoMonedaProveedor = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _cotizacionProveedor.Valor;						*/
							if(_producto.PrecioDeCostoMonedaProveedor != _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _cotizacionProveedor.Valor)
							{
								_producto.PrecioDeCostoMonedaProveedor = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _cotizacionProveedor.Valor;						
								if(PrecioDeCostoMonedaProveedorChanged != null)
									PrecioDeCostoMonedaProveedorChanged(this, new EventArgs());
							}
						}
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
								{
									ListaDePreciosProveedoresItem item = prod.ListaDePreciosProveedores.getListaDePreciosProveedoresItem(_idProveedorListaDePrecios);
									item.PrecioDeCosto = value;
									recalcularBonificaciones(item);
									//German 20090729
									//item.PrecioDeCostoFinal = item.PrecioDeCosto + item.Bonificacion1 + item.Bonificacion2 + item.Bonificacion3 + item.Bonificacion4 + item.Bonificacion5;
									item.SetPrecioDeCostoFinal(item.PrecioDeCosto + item.Bonificacion1 + item.Bonificacion2 + item.Bonificacion3 + item.Bonificacion4 + item.Bonificacion5);
									//Fin German 20090729
									if(prod.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
									{
										prod.PrecioDeCostoReposicion = (item.PrecioDeCostoFinal * item.ValorCotizacionProveedor) / prod.ValorCotizacionPrecioDeCosto;
										prod.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / prod.ValorCotizacionPrecioDeCosto;
										//Sabrina 20100719 - Tarea 796
										prod.ListaDePrecios.UpdatePrecios(prod.PrecioDeCosto, prod.MAC, prod.PrecioDeVentaNeto);
										ListaDePreciosItem itemDefault = prod.ListaDePrecios.GetDefaultItem();
										prod.PrecioLista = itemDefault.PrecioDeVentaBruto;
										/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
											prod.PrecioLista = prod.PrecioDeVentaNeto;
											*/
										//Fin Sabrina 20100719 - Tarea 796
									}
								}
						}
						
					}
				}

			}
		}


		public string SimbololMonedaPrecioDeCostoProveedor
		{
			get 
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
					return _listaDePreciosProveedoresItemSeleccionado.SimbololMonedaPrecioDeCosto;
				return "$";
			}
		}
		
		public string IdMonedaPrecioDeCostoProveedor
		{
			get
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
					return _listaDePreciosProveedoresItemSeleccionado.IdMonedaProveedor;
				return "1";
			}
			set
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
				{
					if(value != _listaDePreciosProveedoresItemSeleccionado.IdMonedaProveedor)
					{
						_listaDePreciosProveedoresItemSeleccionado.IdMonedaProveedor = value;
						if(_producto.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
						{
							_producto.PrecioDeCostoMonedaProducto = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _producto.ValorCotizacionPrecioDeCosto;
							//Sabrina 20100719 - Tarea 796
							_producto.ListaDePrecios.UpdatePrecios(_producto.PrecioDeCosto, _producto.MAC, _producto.PrecioDeVentaNeto);
							ListaDePreciosItem itemDefault = _producto.ListaDePrecios.GetDefaultItem();
							_producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
							/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
								_producto.PrecioLista = _producto.PrecioDeVentaNeto;
								*/
							//Fin Sabrina 20100719 - Tarea 796
						}
                        //German 20110309 - Tarea 0000038
                        //if(_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && (_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia")  || _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior")))
                        if (_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && Workflow.EsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName))
                        //Fin German 20110309 - Tarea 0000038
						{
							_producto.PrecioDeCostoMonedaProveedor = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _cotizacionProveedor.Valor;						
						}
						//Sabrina 20100616 - Tarea 744
						if(IdMonedaPrecioDeCostoProveedorChanged != null)
							IdMonedaPrecioDeCostoProveedorChanged(this, new EventArgs());
						//Fin Sabrina 20100616 - Tarea 744
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
								{
									ListaDePreciosProveedoresItem item = prod.ListaDePreciosProveedores.getListaDePreciosProveedoresItem(_idProveedorListaDePrecios);
									item.IdMonedaProveedor = value;
									if(prod.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
									{
										prod.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / prod.ValorCotizacionPrecioDeCosto;
										//Sabrina 20100719 - Tarea 796
										prod.ListaDePrecios.UpdatePrecios(prod.PrecioDeCosto, prod.MAC, prod.PrecioDeVentaNeto);
										ListaDePreciosItem itemDefault = prod.ListaDePrecios.GetDefaultItem();
										prod.PrecioLista = itemDefault.PrecioDeVentaBruto;
										/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
											prod.PrecioLista = prod.PrecioDeVentaNeto;
											*/
										//Fin Sabrina 20100719 - Tarea 796
									}
								}
						}
						
					}
				}
			}
		}

		public string IdFuenteDeCambioListaProveedor
		{
			get
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
					return _listaDePreciosProveedoresItemSeleccionado.IdFuenteDeCambioProveedor;
				return "1";
			}
			set
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
				{
					if(value != _listaDePreciosProveedoresItemSeleccionado.IdFuenteDeCambioProveedor)
					{
						_listaDePreciosProveedoresItemSeleccionado.IdFuenteDeCambioProveedor = value;
						if(_producto.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
						{
							_producto.PrecioDeCostoMonedaProducto = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _producto.ValorCotizacionPrecioDeCosto;
							//Sabrina 20100719 - Tarea 796
							_producto.ListaDePrecios.UpdatePrecios(_producto.PrecioDeCosto, _producto.MAC, _producto.PrecioDeVentaNeto);
							ListaDePreciosItem itemDefault = _producto.ListaDePrecios.GetDefaultItem();
							_producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
							/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
								_producto.PrecioLista = _producto.PrecioDeVentaNeto;
								*/
							//Fin Sabrina 20100719 - Tarea 796
						}
                        //German 20110309 - Tarea 0000038
						//if(_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && (_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia")  || _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior")))
                        if (_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && Workflow.EsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName))
                        //Fin German 20110309 - Tarea 0000038
						{
							_precioDeCostoMonedaProveedorAnterior = _producto.PrecioDeCostoMonedaProveedor;
							_producto.PrecioDeCostoMonedaProveedor = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _cotizacionProveedor.Valor;						
						}
						//Sabrina 20100616 - Tarea 744
						if(IdFuenteDeCambioListaProveedorChanged != null)
							IdFuenteDeCambioListaProveedorChanged(this, new EventArgs());
						//Fin Sabrina 20100616 - Tarea 744
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
								{
									ListaDePreciosProveedoresItem item = prod.ListaDePreciosProveedores.getListaDePreciosProveedoresItem(_idProveedorListaDePrecios);
									item.IdFuenteDeCambioProveedor = value;
									if(prod.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
									{
										prod.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / prod.ValorCotizacionPrecioDeCosto;
										//Sabrina 20100719 - Tarea 796
										prod.ListaDePrecios.UpdatePrecios(prod.PrecioDeCosto, prod.MAC, prod.PrecioDeVentaNeto);
										ListaDePreciosItem itemDefault = prod.ListaDePrecios.GetDefaultItem();
										prod.PrecioLista = itemDefault.PrecioDeVentaBruto;
										/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
											prod.PrecioLista = prod.PrecioDeVentaNeto;
											*/
										//Fin Sabrina 20100719 - Tarea 796
									}
								}
						}
						
					}
				}
			}
		}
		
		public decimal ValorCotizacionPrecioDeCostoProveedor
		{
			get
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
					return _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor;
				return 1;
			}
			set
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
				{
					if(value != _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor)
					{
						_listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor = value;
						if(_producto.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
						{
							_producto.PrecioDeCostoMonedaProducto = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _producto.ValorCotizacionPrecioDeCosto;
							//Sabrina 20100719 - Tarea 796
							_producto.ListaDePrecios.UpdatePrecios(_producto.PrecioDeCosto, _producto.MAC, _producto.PrecioDeVentaNeto);
							ListaDePreciosItem itemDefault = _producto.ListaDePrecios.GetDefaultItem();
							_producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
							/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
								_producto.PrecioLista = _producto.PrecioDeVentaNeto;
								*/
							//Fin Sabrina 20100719 - Tarea 796
						}
                        //German 20110309 - Tarea 0000038
						//if(_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && (_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia")  || _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior")))
                        if (_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && Workflow.EsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName))
                        //Fin German 20110309 - Tarea 0000038
						{
							_precioDeCostoMonedaProveedorAnterior = _producto.PrecioDeCostoMonedaProveedor;
							_producto.PrecioDeCostoMonedaProveedor = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _cotizacionProveedor.Valor;						
						}
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
								{
									ListaDePreciosProveedoresItem item = prod.ListaDePreciosProveedores.getListaDePreciosProveedoresItem(_idProveedorListaDePrecios);
									item.ValorCotizacionProveedor = value;
									if(prod.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
									{
										prod.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / prod.ValorCotizacionPrecioDeCosto;
										//Sabrina 20100719 - Tarea 796
										prod.ListaDePrecios.UpdatePrecios(prod.PrecioDeCosto, prod.MAC, prod.PrecioDeVentaNeto);
										ListaDePreciosItem itemDefault = prod.ListaDePrecios.GetDefaultItem();
										prod.PrecioLista = itemDefault.PrecioDeVentaBruto;
										/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
											prod.PrecioLista = prod.PrecioDeVentaNeto;
											*/
										//Fin Sabrina 20100719 - Tarea 796
									}
								}
						}
						
					}
				}
			}
		}
		public bool ActualizaPrecioDeCostoReposicion
		{
			get
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
					return _listaDePreciosProveedoresItemSeleccionado.ActualizaPrecioDeCostoReposicion;
				return false;
			}
			set
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
				{
					if(value != _listaDePreciosProveedoresItemSeleccionado.ActualizaPrecioDeCostoReposicion)
					{
						_listaDePreciosProveedoresItemSeleccionado.ActualizaPrecioDeCostoReposicion = value;
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
				}
			}
		}

        //German 20140125 - Tarea 1 - SP 22
        public string CodigoProductoProveedor
        {
            get
            {
                if (_listaDePreciosProveedoresItemSeleccionado != null)
                    return _listaDePreciosProveedoresItemSeleccionado.CodigoProductoProveedor;
                return string.Empty;
            }
            set
            {
                if (_listaDePreciosProveedoresItemSeleccionado != null)
                {
                    if (value != _listaDePreciosProveedoresItemSeleccionado.CodigoProductoProveedor)
                    {
                        _listaDePreciosProveedoresItemSeleccionado.CodigoProductoProveedor = value;
                        if (ObjectHasChanged != null)
                            ObjectHasChanged(this, new EventArgs());
                    }
                }
            }
        }
        //Fin German 20140125 - Tarea 1 - SP 22



		public bool BonificacionAcumulativa
		{
			get
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
					return _listaDePreciosProveedoresItemSeleccionado.BonificacionAcumulativa;
				return false;
			}
			set
			{
				_bonificacionesAcumulativas = value;
				if(_listaDePreciosProveedoresItemSeleccionado != null)
				{
					if(value != _listaDePreciosProveedoresItemSeleccionado.BonificacionAcumulativa)
					{
						_listaDePreciosProveedoresItemSeleccionado.BonificacionAcumulativa = value;

						recalcularBonificaciones(_listaDePreciosProveedoresItemSeleccionado);
						_listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto + _listaDePreciosProveedoresItemSeleccionado.Bonificacion1 + _listaDePreciosProveedoresItemSeleccionado.Bonificacion2 + _listaDePreciosProveedoresItemSeleccionado.Bonificacion3 + _listaDePreciosProveedoresItemSeleccionado.Bonificacion4 + _listaDePreciosProveedoresItemSeleccionado.Bonificacion5;
						if(_producto.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
						{
							_producto.PrecioDeCostoMonedaProducto = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _producto.ValorCotizacionPrecioDeCosto;
							//Sabrina 20100719 - Tarea 796
							_producto.ListaDePrecios.UpdatePrecios(_producto.PrecioDeCosto, _producto.MAC, _producto.PrecioDeVentaNeto);
							ListaDePreciosItem itemDefault = _producto.ListaDePrecios.GetDefaultItem();
							_producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
							/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
								_producto.PrecioLista = _producto.PrecioDeVentaNeto;
								*/
							//Fin Sabrina 20100719 - Tarea 796
						}
                        //German 20110309 - Tarea 0000038
                        //if(_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && (_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia")  || _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior")))
                        if (_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && Workflow.EsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName))
                        //Fin German 20110309 - Tarea 0000038
						{
							_precioDeCostoMonedaProveedorAnterior = _producto.PrecioDeCostoMonedaProveedor;
							
							/*German reemplaza la linea comentada por el bloque siguiente*/
							/*_producto.PrecioDeCostoMonedaProveedor = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _cotizacionProveedor.Valor;						*/
							if(_producto.PrecioDeCostoMonedaProveedor != _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _cotizacionProveedor.Valor)
							{
								_producto.PrecioDeCostoMonedaProveedor = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _cotizacionProveedor.Valor;						
								if(PrecioDeCostoMonedaProveedorChanged != null)
									PrecioDeCostoMonedaProveedorChanged(this, new EventArgs());
							}
						}
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
								{
									ListaDePreciosProveedoresItem item = prod.ListaDePreciosProveedores.getListaDePreciosProveedoresItem(_idProveedorListaDePrecios);
									item.BonificacionAcumulativa = value;
									recalcularBonificaciones(item);
									//German 20090729
									//item.PrecioDeCostoFinal = item.PrecioDeCosto + item.Bonificacion1 + item.Bonificacion2 + item.Bonificacion3 + item.Bonificacion4 + item.Bonificacion5;
									item.SetPrecioDeCostoFinal(item.PrecioDeCosto + item.Bonificacion1 + item.Bonificacion2 + item.Bonificacion3 + item.Bonificacion4 + item.Bonificacion5);
									//Fin German 20090729
									if(prod.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
									{
										prod.PrecioDeCostoReposicion = (item.PrecioDeCostoFinal * item.ValorCotizacionProveedor) / prod.ValorCotizacionPrecioDeCosto;
										prod.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / prod.ValorCotizacionPrecioDeCosto;
										//Sabrina 20100719 - Tarea 796
										prod.ListaDePrecios.UpdatePrecios(prod.PrecioDeCosto, prod.MAC, prod.PrecioDeVentaNeto);
										ListaDePreciosItem itemDefault = prod.ListaDePrecios.GetDefaultItem();
										prod.PrecioLista = itemDefault.PrecioDeVentaBruto;
										/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
											prod.PrecioLista = prod.PrecioDeVentaNeto;
											*/
										//Fin Sabrina 20100719 - Tarea 796
									}
								}
						}
						
					}
				}
			}
		}

		public decimal Bonificacion1
		{
			get
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
					return _listaDePreciosProveedoresItemSeleccionado.Bonificacion1;
				return 0;
			}
			set
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
				{
					if(value != _listaDePreciosProveedoresItemSeleccionado.Bonificacion1)
					{
						_listaDePreciosProveedoresItemSeleccionado.Bonificacion1 = value;
                        //German 20120725 - Tarea 0000364
                        this.recalcularBonificaciones(_listaDePreciosProveedoresItemSeleccionado);
                        //Fin German 20120725 - Tarea 0000364
						if(_producto.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
						{
							_producto.PrecioDeCostoMonedaProducto = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _producto.ValorCotizacionPrecioDeCosto;
							//Sabrina 20100719 - Tarea 796
							_producto.ListaDePrecios.UpdatePrecios(_producto.PrecioDeCosto, _producto.MAC, _producto.PrecioDeVentaNeto);
							ListaDePreciosItem itemDefault = _producto.ListaDePrecios.GetDefaultItem();
							_producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
							/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
								_producto.PrecioLista = _producto.PrecioDeVentaNeto;
								*/
							//Fin Sabrina 20100719 - Tarea 796
						}
                        //German 20110309 - Tarea 0000038
                        //if(_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && (_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia")  || _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior")))
                        if (_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && Workflow.EsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName))
                        //Fin German 20110309 - Tarea 0000038
						{
							_precioDeCostoMonedaProveedorAnterior = _producto.PrecioDeCostoMonedaProveedor;
							_producto.PrecioDeCostoMonedaProveedor = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _cotizacionProveedor.Valor;						
							if(PrecioDeCostoMonedaProveedorChanged != null)
								PrecioDeCostoMonedaProveedorChanged(this, new EventArgs());

						}
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
								{
									ListaDePreciosProveedoresItem item = prod.ListaDePreciosProveedores.getListaDePreciosProveedoresItem(_idProveedorListaDePrecios);
									item.Bonificacion1 = value;
                                    //German 20120725 - Tarea 0000364
                                    this.recalcularBonificaciones(item);
                                    //Fin German 20120725 - Tarea 0000364
									if(prod.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
									{
										prod.PrecioDeCostoReposicion = (item.PrecioDeCostoFinal * item.ValorCotizacionProveedor) / prod.ValorCotizacionPrecioDeCosto;
										prod.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / prod.ValorCotizacionPrecioDeCosto;
										//Sabrina 20100719 - Tarea 796
										prod.ListaDePrecios.UpdatePrecios(prod.PrecioDeCosto, prod.MAC, prod.PrecioDeVentaNeto);
										ListaDePreciosItem itemDefault = prod.ListaDePrecios.GetDefaultItem();
										prod.PrecioLista = itemDefault.PrecioDeVentaBruto;
										/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
											prod.PrecioLista = prod.PrecioDeVentaNeto;
											*/
										//Fin Sabrina 20100719 - Tarea 796
									}
								}
						}
						
					}
				}
			}
		}

		public decimal Bonificacion2
		{
			get
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
					return _listaDePreciosProveedoresItemSeleccionado.Bonificacion2;
				return 0;
			}
			set
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
				{
					if(value != _listaDePreciosProveedoresItemSeleccionado.Bonificacion2)
					{
						_listaDePreciosProveedoresItemSeleccionado.Bonificacion2 = value;
						if(_listaDePreciosProveedoresItemSeleccionado.BonificacionAcumulativa)
						{
							decimal precioInt = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto + _listaDePreciosProveedoresItemSeleccionado.Bonificacion1;
							if(precioInt != 0)
								_listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion2 = (value * 100)/ precioInt;
							else
								_listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion2 = 0;
						}
						else
						{
							if(_listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto != 0)
								_listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion2 = (value * 100)/ _listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto;
							else
								_listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion2 = 0;
						}
                        //German 20120725 - Tarea 0000364
                        this.recalcularBonificaciones(_listaDePreciosProveedoresItemSeleccionado);
                        //Fin German 20120725 - Tarea 0000364
						if(_producto.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
						{
							_producto.PrecioDeCostoMonedaProducto = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _producto.ValorCotizacionPrecioDeCosto;
							//Sabrina 20100719 - Tarea 796
							_producto.ListaDePrecios.UpdatePrecios(_producto.PrecioDeCosto, _producto.MAC, _producto.PrecioDeVentaNeto);
							ListaDePreciosItem itemDefault = _producto.ListaDePrecios.GetDefaultItem();
							_producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
							/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
								_producto.PrecioLista = _producto.PrecioDeVentaNeto;
								*/
							//Fin Sabrina 20100719 - Tarea 796
						}
                        //German 20110309 - Tarea 0000038
                        //if(_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && (_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia")  || _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior")))
                        if (_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && Workflow.EsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName))
                        //Fin German 20110309 - Tarea 0000038
						{
							_producto.PrecioDeCostoMonedaProveedor = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _cotizacionProveedor.Valor;						
							if(PrecioDeCostoMonedaProveedorChanged != null)
								PrecioDeCostoMonedaProveedorChanged(this, new EventArgs());
						}
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
								{
									ListaDePreciosProveedoresItem item = prod.ListaDePreciosProveedores.getListaDePreciosProveedoresItem(_idProveedorListaDePrecios);
									item.Bonificacion2 = value;
									if(item.BonificacionAcumulativa)
									{
										decimal precioInt = item.PrecioDeCosto + item.Bonificacion1;
										if(precioInt != 0)
											item.PorcentajeBonificacion2 = (value * 100)/ precioInt;
										else
											item.PorcentajeBonificacion2 = 0;
									}
									else
									{
										if(item.PrecioDeCosto != 0)
											item.PorcentajeBonificacion2 = (value * 100)/ item.PrecioDeCosto;
										else
											item.PorcentajeBonificacion2 = 0;
									}
                                    //German 20120725 - Tarea 0000364
                                    this.recalcularBonificaciones(item);
                                    //Fin German 20120725 - Tarea 0000364
									if(prod.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
									{
										prod.PrecioDeCostoReposicion = (item.PrecioDeCostoFinal * item.ValorCotizacionProveedor) / prod.ValorCotizacionPrecioDeCosto;
										prod.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / prod.ValorCotizacionPrecioDeCosto;
										//Sabrina 20100719 - Tarea 796
										prod.ListaDePrecios.UpdatePrecios(prod.PrecioDeCosto, prod.MAC, prod.PrecioDeVentaNeto);
										ListaDePreciosItem itemDefault = prod.ListaDePrecios.GetDefaultItem();
										prod.PrecioLista = itemDefault.PrecioDeVentaBruto;
										/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
											prod.PrecioLista = prod.PrecioDeVentaNeto;
											*/
										//Fin Sabrina 20100719 - Tarea 796
									}

								}
						}
						
					}
				}
			}
		}

		public decimal Bonificacion3
		{
			get
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
					return _listaDePreciosProveedoresItemSeleccionado.Bonificacion3;
				return 0;
			}
			set
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
				{
					if(value != _listaDePreciosProveedoresItemSeleccionado.Bonificacion3)
					{
						_listaDePreciosProveedoresItemSeleccionado.Bonificacion3 = value;
						if(_listaDePreciosProveedoresItemSeleccionado.BonificacionAcumulativa)
						{
							decimal precioInt = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto + _listaDePreciosProveedoresItemSeleccionado.Bonificacion1 + _listaDePreciosProveedoresItemSeleccionado.Bonificacion2;
							if(precioInt != 0)
								_listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion3 = (value * 100)/ precioInt;
							else
								_listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion3 = 0;
						}
						else
						{
							if(_listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto != 0)
								_listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion3 = (value * 100)/ _listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto;
							else
								_listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion3 = 0;
						}
                        //German 20120725 - Tarea 0000364
                        this.recalcularBonificaciones(_listaDePreciosProveedoresItemSeleccionado);
                        //Fin German 20120725 - Tarea 0000364
						if(_producto.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
						{
							_producto.PrecioDeCostoMonedaProducto = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _producto.ValorCotizacionPrecioDeCosto;
							//Sabrina 20100719 - Tarea 796
							_producto.ListaDePrecios.UpdatePrecios(_producto.PrecioDeCosto, _producto.MAC, _producto.PrecioDeVentaNeto);
							ListaDePreciosItem itemDefault = _producto.ListaDePrecios.GetDefaultItem();
							_producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
							/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
								_producto.PrecioLista = _producto.PrecioDeVentaNeto;
								*/
							//Fin Sabrina 20100719 - Tarea 796
						}
                        //German 20110309 - Tarea 0000038
                        //if(_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && (_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia")  || _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior")))
                        if (_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && Workflow.EsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName))
                        //Fin German 20110309 - Tarea 0000038
						{
							_precioDeCostoMonedaProveedorAnterior = _producto.PrecioDeCostoMonedaProveedor;
							_producto.PrecioDeCostoMonedaProveedor = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _cotizacionProveedor.Valor;						
							if(PrecioDeCostoMonedaProveedorChanged != null)
								PrecioDeCostoMonedaProveedorChanged(this, new EventArgs());
						}
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
								{
									ListaDePreciosProveedoresItem item = prod.ListaDePreciosProveedores.getListaDePreciosProveedoresItem(_idProveedorListaDePrecios);
									item.Bonificacion3 = value;
									if(item.BonificacionAcumulativa)
									{
										decimal precioInt = item.PrecioDeCosto + item.Bonificacion1 + item.Bonificacion2;
										if(precioInt != 0)
											item.PorcentajeBonificacion3 = (value * 100)/ precioInt;
										else
											item.PorcentajeBonificacion3 = 0;
									}
									else
									{
										if(item.PrecioDeCosto != 0)
											item.PorcentajeBonificacion3 = (value * 100)/ item.PrecioDeCosto;
										else
											item.PorcentajeBonificacion3 = 0;
									}
                                    //German 20120725 - Tarea 0000364
                                    this.recalcularBonificaciones(item);
                                    //Fin German 20120725 - Tarea 0000364
									if(prod.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
									{
										prod.PrecioDeCostoReposicion = (item.PrecioDeCostoFinal * item.ValorCotizacionProveedor) / prod.ValorCotizacionPrecioDeCosto;
										prod.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / prod.ValorCotizacionPrecioDeCosto;
										//Sabrina 20100719 - Tarea 796
										prod.ListaDePrecios.UpdatePrecios(prod.PrecioDeCosto, prod.MAC, prod.PrecioDeVentaNeto);
										ListaDePreciosItem itemDefault = prod.ListaDePrecios.GetDefaultItem();
										prod.PrecioLista = itemDefault.PrecioDeVentaBruto;
										/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
											prod.PrecioLista = prod.PrecioDeVentaNeto;
											*/
										//Fin Sabrina 20100719 - Tarea 796
									}
								}
						}
						
					}
				}
			}
		}

		public decimal Bonificacion4
		{
			get
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
					return _listaDePreciosProveedoresItemSeleccionado.Bonificacion4;
				return 0;
			}
			set
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
				{
					if(value != _listaDePreciosProveedoresItemSeleccionado.Bonificacion4)
					{
						_listaDePreciosProveedoresItemSeleccionado.Bonificacion4 = value;
						if(_listaDePreciosProveedoresItemSeleccionado.BonificacionAcumulativa)
						{
							decimal precioInt = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto + _listaDePreciosProveedoresItemSeleccionado.Bonificacion1 + _listaDePreciosProveedoresItemSeleccionado.Bonificacion2 + _listaDePreciosProveedoresItemSeleccionado.Bonificacion3;
							if(precioInt != 0)
								_listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion4 = (value * 100)/ precioInt;
							else
								_listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion4 = 0;
						}
						else
						{
							if(_listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto != 0)
								_listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion4 = (value * 100)/ _listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto;
							else
								_listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion4 = 0;
						}
                        //German 20120725 - Tarea 0000364
                        this.recalcularBonificaciones(_listaDePreciosProveedoresItemSeleccionado);
                        //Fin German 20120725 - Tarea 0000364
						if(_producto.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
						{
							_producto.PrecioDeCostoMonedaProducto = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _producto.ValorCotizacionPrecioDeCosto;
							//Sabrina 20100719 - Tarea 796
							_producto.ListaDePrecios.UpdatePrecios(_producto.PrecioDeCosto, _producto.MAC, _producto.PrecioDeVentaNeto);
							ListaDePreciosItem itemDefault = _producto.ListaDePrecios.GetDefaultItem();
							_producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
							/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
								_producto.PrecioLista = _producto.PrecioDeVentaNeto;
								*/
							//Fin Sabrina 20100719 - Tarea 796
						}
                        //German 20110309 - Tarea 0000038
                        //if(_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && (_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia")  || _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior")))
                        if (_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && Workflow.EsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName))
                        //Fin German 20110309 - Tarea 0000038
						{
							_producto.PrecioDeCostoMonedaProveedor = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _cotizacionProveedor.Valor;						
							if(PrecioDeCostoMonedaProveedorChanged != null)
								PrecioDeCostoMonedaProveedorChanged(this, new EventArgs());
						}
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
								{
									ListaDePreciosProveedoresItem item = prod.ListaDePreciosProveedores.getListaDePreciosProveedoresItem(_idProveedorListaDePrecios);
									item.Bonificacion4 = value;
									if(item.BonificacionAcumulativa)
									{
										decimal precioInt = item.PrecioDeCosto + item.Bonificacion1 + item.Bonificacion2 + item.PorcentajeBonificacion3;
										if(precioInt != 0)
											item.PorcentajeBonificacion4 = (value * 100)/ precioInt;
										else
											item.PorcentajeBonificacion4 = 0;
									}
									else
									{
										if(item.PrecioDeCosto != 0)
											item.PorcentajeBonificacion4 = (value * 100)/ item.PrecioDeCosto;
										else
											item.PorcentajeBonificacion4 = 0;
									}
                                    //German 20120725 - Tarea 0000364
                                    this.recalcularBonificaciones(item);
                                    //Fin German 20120725 - Tarea 0000364
									if(prod.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
									{
										prod.PrecioDeCostoReposicion = (item.PrecioDeCostoFinal * item.ValorCotizacionProveedor) / prod.ValorCotizacionPrecioDeCosto;
										prod.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / prod.ValorCotizacionPrecioDeCosto;
										//Sabrina 20100719 - Tarea 796
										prod.ListaDePrecios.UpdatePrecios(prod.PrecioDeCosto, prod.MAC, prod.PrecioDeVentaNeto);
										ListaDePreciosItem itemDefault = prod.ListaDePrecios.GetDefaultItem();
										prod.PrecioLista = itemDefault.PrecioDeVentaBruto;
										/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
											prod.PrecioLista = prod.PrecioDeVentaNeto;
											*/
										//Fin Sabrina 20100719 - Tarea 796
									}
								}
						}
						
					}
				}
			}
		}

		public decimal Bonificacion5
		{
			get
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
					return _listaDePreciosProveedoresItemSeleccionado.Bonificacion5;
				return 0;
			}
			set
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
				{
					if(value != _listaDePreciosProveedoresItemSeleccionado.Bonificacion5)
					{
						_listaDePreciosProveedoresItemSeleccionado.Bonificacion5 = value;
						if(_listaDePreciosProveedoresItemSeleccionado.BonificacionAcumulativa)
						{
							decimal precioInt = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto + _listaDePreciosProveedoresItemSeleccionado.Bonificacion1 + _listaDePreciosProveedoresItemSeleccionado.Bonificacion2 + _listaDePreciosProveedoresItemSeleccionado.Bonificacion3 + _listaDePreciosProveedoresItemSeleccionado.Bonificacion4;
							if(precioInt != 0)
								_listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion5 = (value * 100)/ precioInt;
							else
								_listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion5 = 0;
						}
						else
						{
							if(_listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto != 0)
								_listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion5 = (value * 100)/ _listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto;
							else
								_listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion5 = 0;
						}
                        //German 20120725 - Tarea 0000364
                        this.recalcularBonificaciones(_listaDePreciosProveedoresItemSeleccionado);
                        //Fin German 20120725 - Tarea 0000364
						if(_producto.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
						{
							_producto.PrecioDeCostoMonedaProducto = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _producto.ValorCotizacionPrecioDeCosto;
							//Sabrina 20100719 - Tarea 796
							_producto.ListaDePrecios.UpdatePrecios(_producto.PrecioDeCosto, _producto.MAC, _producto.PrecioDeVentaNeto);
							ListaDePreciosItem itemDefault = _producto.ListaDePrecios.GetDefaultItem();
							_producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
							/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
								_producto.PrecioLista = _producto.PrecioDeVentaNeto;
								*/
							//Fin Sabrina 20100719 - Tarea 796
						}
                        //German 20110309 - Tarea 0000038
                        //if(_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && (_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia")  || _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior")))
                        if (_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && Workflow.EsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName))
                        //Fin German 20110309 - Tarea 0000038
						{
							_producto.PrecioDeCostoMonedaProveedor = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _cotizacionProveedor.Valor;						
							if(PrecioDeCostoMonedaProveedorChanged != null)
								PrecioDeCostoMonedaProveedorChanged(this, new EventArgs());
						}
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
								{
									ListaDePreciosProveedoresItem item = prod.ListaDePreciosProveedores.getListaDePreciosProveedoresItem(_idProveedorListaDePrecios);
									item.Bonificacion5 = value;
									if(item.BonificacionAcumulativa)
									{
										decimal precioInt = item.PrecioDeCosto + item.Bonificacion1 + item.Bonificacion2 + item.PorcentajeBonificacion3 + item.Bonificacion4;
										if(precioInt != 0)
											item.PorcentajeBonificacion5 = (value * 100)/ precioInt;
										else
											item.PorcentajeBonificacion5 = 0;
									}
									else
									{
										if(item.PrecioDeCosto != 0)
											item.PorcentajeBonificacion5 = (value * 100)/ item.PrecioDeCosto;
										else
											item.PorcentajeBonificacion5 = 0;
									}
                                    //German 20120725 - Tarea 0000364
                                    this.recalcularBonificaciones(item);
                                    //Fin German 20120725 - Tarea 0000364
									if(prod.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
									{
										prod.PrecioDeCostoReposicion = (item.PrecioDeCostoFinal * item.ValorCotizacionProveedor) / prod.ValorCotizacionPrecioDeCosto;
										prod.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / prod.ValorCotizacionPrecioDeCosto;
										//Sabrina 20100719 - Tarea 796
										prod.ListaDePrecios.UpdatePrecios(prod.PrecioDeCosto, prod.MAC, prod.PrecioDeVentaNeto);
										ListaDePreciosItem itemDefault = prod.ListaDePrecios.GetDefaultItem();
										prod.PrecioLista = itemDefault.PrecioDeVentaBruto;
										/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
											prod.PrecioLista = prod.PrecioDeVentaNeto;
											*/
										//Fin Sabrina 20100719 - Tarea 796
									}
								}
						}
						
					}
				}
			}
		}

		public decimal PorcentajeBonificacion1
		{
			get
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
					return _listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion1;
				return 0;
			}
			set
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
				{
					if(value != _listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion1)
					{
						_listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion1 = value;
                        //German 20120725 - Tarea 0000364
                        this.recalcularBonificaciones(_listaDePreciosProveedoresItemSeleccionado);
                        //Fin German 20120725 - Tarea 0000364
						if(_producto.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
						{
							_producto.PrecioDeCostoMonedaProducto = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _producto.ValorCotizacionPrecioDeCosto;
							//Sabrina 20100719 - Tarea 796
							_producto.ListaDePrecios.UpdatePrecios(_producto.PrecioDeCosto, _producto.MAC, _producto.PrecioDeVentaNeto);
							ListaDePreciosItem itemDefault = _producto.ListaDePrecios.GetDefaultItem();
							_producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
							/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
								_producto.PrecioLista = _producto.PrecioDeVentaNeto;
								*/
							//Fin Sabrina 20100719 - Tarea 796
						}
                        //German 20110309 - Tarea 0000038
                        //if(_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && (_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia")  || _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior")))
                        if (_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && Workflow.EsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName))
                        //Fin German 20110309 - Tarea 0000038
						{
							_producto.PrecioDeCostoMonedaProveedor = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _cotizacionProveedor.Valor;						
							if(PrecioDeCostoMonedaProveedorChanged != null)
								PrecioDeCostoMonedaProveedorChanged(this, new EventArgs());
						}
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
								{
									ListaDePreciosProveedoresItem item = prod.ListaDePreciosProveedores.getListaDePreciosProveedoresItem(_idProveedorListaDePrecios);
									item.PorcentajeBonificacion1 = value;
                                    //German 20120725 - Tarea 0000364
                                    this.recalcularBonificaciones(item);
                                    //Fin German 20120725 - Tarea 0000364
									if(prod.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
									{
										prod.PrecioDeCostoReposicion = (item.PrecioDeCostoFinal * item.ValorCotizacionProveedor) / prod.ValorCotizacionPrecioDeCosto;
										prod.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / prod.ValorCotizacionPrecioDeCosto;
										//Sabrina 20100719 - Tarea 796
										prod.ListaDePrecios.UpdatePrecios(prod.PrecioDeCosto, prod.MAC, prod.PrecioDeVentaNeto);
										ListaDePreciosItem itemDefault = prod.ListaDePrecios.GetDefaultItem();
										prod.PrecioLista = itemDefault.PrecioDeVentaBruto;
										/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
											prod.PrecioLista = prod.PrecioDeVentaNeto;
											*/
										//Fin Sabrina 20100719 - Tarea 796
									}
								}
						}
						
					}
				}
			}
		}

		public decimal PorcentajeBonificacion2
		{
			get
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
					return _listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion2;
				return 0;
			}
			set
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
				{
					if(value != _listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion2)
					{
						_listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion2 = value;
                        //German 20120725 - Tarea 0000364
                        this.recalcularBonificaciones(_listaDePreciosProveedoresItemSeleccionado);
                        /*
						if(_listaDePreciosProveedoresItemSeleccionado.BonificacionAcumulativa)
						{
							decimal precioInt = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto + _listaDePreciosProveedoresItemSeleccionado.Bonificacion1;
							_listaDePreciosProveedoresItemSeleccionado.Bonificacion2 = (value * precioInt) / 100;
						}
						else
							_listaDePreciosProveedoresItemSeleccionado.Bonificacion2 = (value * _listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto) / 100;
                         */
                        //Fin German 20120725 - Tarea 0000364

						if(_producto.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
						{
							_producto.PrecioDeCostoMonedaProducto = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _producto.ValorCotizacionPrecioDeCosto;
							//Sabrina 20100719 - Tarea 796
							_producto.ListaDePrecios.UpdatePrecios(_producto.PrecioDeCosto, _producto.MAC, _producto.PrecioDeVentaNeto);
							ListaDePreciosItem itemDefault = _producto.ListaDePrecios.GetDefaultItem();
							_producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
							/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
								_producto.PrecioLista = _producto.PrecioDeVentaNeto;
								*/
							//Fin Sabrina 20100719 - Tarea 796
						}
                        //German 20110309 - Tarea 0000038
                        //if(_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && (_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia")  || _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior")))
                        if (_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && Workflow.EsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName))
                        //Fin German 20110309 - Tarea 0000038
						{
							_precioDeCostoMonedaProveedorAnterior = _producto.PrecioDeCostoMonedaProveedor;
							_producto.PrecioDeCostoMonedaProveedor = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _cotizacionProveedor.Valor;						
							if(PrecioDeCostoMonedaProveedorChanged != null)
								PrecioDeCostoMonedaProveedorChanged(this, new EventArgs());
						}
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
								{
									ListaDePreciosProveedoresItem item = prod.ListaDePreciosProveedores.getListaDePreciosProveedoresItem(_idProveedorListaDePrecios);
									item.PorcentajeBonificacion2 = value;
                                    //German 20120725 - Tarea 0000364
                                    this.recalcularBonificaciones(item);
                                    /*
									if(item.BonificacionAcumulativa)
									{
										decimal precioInt = item.PrecioDeCosto + item.Bonificacion1;
										item.Bonificacion2 = (value * precioInt) / 100;
									}
									else
										item.Bonificacion2 = (value * item.PrecioDeCosto) / 100;
                                    */
                                    //Fin German 20120725 - Tarea 0000364
									if(prod.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
									{
										prod.PrecioDeCostoReposicion = (item.PrecioDeCostoFinal * item.ValorCotizacionProveedor) / prod.ValorCotizacionPrecioDeCosto;
										prod.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / prod.ValorCotizacionPrecioDeCosto;
										//Sabrina 20100719 - Tarea 796
										prod.ListaDePrecios.UpdatePrecios(prod.PrecioDeCosto, prod.MAC, prod.PrecioDeVentaNeto);
										ListaDePreciosItem itemDefault = prod.ListaDePrecios.GetDefaultItem();
										prod.PrecioLista = itemDefault.PrecioDeVentaBruto;
										/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
											prod.PrecioLista = prod.PrecioDeVentaNeto;
											*/
										//Fin Sabrina 20100719 - Tarea 796
									}
								}
						}
						
					}
				}
			}
		}

		public decimal PorcentajeBonificacion3
		{
			get
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
					return _listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion3;
				return 0;
			}
			set
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
				{
					if(value != _listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion3)
					{
						_listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion3 = value;
                        //German 20120725 - Tarea 0000364
                        this.recalcularBonificaciones(_listaDePreciosProveedoresItemSeleccionado);
                        /*
						if(_listaDePreciosProveedoresItemSeleccionado.BonificacionAcumulativa)
						{
							decimal precioInt = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto + _listaDePreciosProveedoresItemSeleccionado.Bonificacion1 + _listaDePreciosProveedoresItemSeleccionado.Bonificacion2;
							_listaDePreciosProveedoresItemSeleccionado.Bonificacion3 = (value * precioInt) / 100;
						}
						else
							_listaDePreciosProveedoresItemSeleccionado.Bonificacion3 = (value * _listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto) / 100;
                         * */
                        //Fin German 20120725 - Tarea 0000364

						if(_producto.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
						{
							_producto.PrecioDeCostoMonedaProducto = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _producto.ValorCotizacionPrecioDeCosto;
							//Sabrina 20100719 - Tarea 796
							_producto.ListaDePrecios.UpdatePrecios(_producto.PrecioDeCosto, _producto.MAC, _producto.PrecioDeVentaNeto);
							ListaDePreciosItem itemDefault = _producto.ListaDePrecios.GetDefaultItem();
							_producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
							/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
								_producto.PrecioLista = _producto.PrecioDeVentaNeto;
								*/
							//Fin Sabrina 20100719 - Tarea 796
						}
                        //German 20110309 - Tarea 0000038
                        //if(_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && (_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia")  || _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior")))
                        if (_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && Workflow.EsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName))
                        //Fin German 20110309 - Tarea 0000038
						{
							_producto.PrecioDeCostoMonedaProveedor = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _cotizacionProveedor.Valor;
							if(PrecioDeCostoMonedaProveedorChanged != null)
								PrecioDeCostoMonedaProveedorChanged(this, new EventArgs());
						}
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
								{
									ListaDePreciosProveedoresItem item = prod.ListaDePreciosProveedores.getListaDePreciosProveedoresItem(_idProveedorListaDePrecios);
									item.PorcentajeBonificacion3 = value;
                                    //German 20120725 - Tarea 0000364
                                    this.recalcularBonificaciones(item);
                                    /*

									if(item.BonificacionAcumulativa)
									{
										decimal precioInt = item.PrecioDeCosto + item.Bonificacion1 + item.Bonificacion2;
										item.Bonificacion3 = (value * precioInt) / 100;
									}
									else
										item.Bonificacion3 = (value * item.PrecioDeCosto) / 100;
                                     * */
                                    //Fin German 20120725 - Tarea 0000364
									if(prod.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
									{
										prod.PrecioDeCostoReposicion = (item.PrecioDeCostoFinal * item.ValorCotizacionProveedor) / prod.ValorCotizacionPrecioDeCosto;
										prod.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / prod.ValorCotizacionPrecioDeCosto;
										//Sabrina 20100719 - Tarea 796
										prod.ListaDePrecios.UpdatePrecios(prod.PrecioDeCosto, prod.MAC, prod.PrecioDeVentaNeto);
										ListaDePreciosItem itemDefault = prod.ListaDePrecios.GetDefaultItem();
										prod.PrecioLista = itemDefault.PrecioDeVentaBruto;
										/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
											prod.PrecioLista = prod.PrecioDeVentaNeto;
											*/
										//Fin Sabrina 20100719 - Tarea 796
									}
								}
						}
						
					}
				}
			}
		}

		public decimal PorcentajeBonificacion4
		{
			get
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
					return _listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion4;
				return 0;
			}
			set
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
				{
					if(value != _listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion4)
					{
						_listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion4 = value;
                        //German 20120725 - Tarea 0000364
                        this.recalcularBonificaciones(_listaDePreciosProveedoresItemSeleccionado);
                        /*
						if(_listaDePreciosProveedoresItemSeleccionado.BonificacionAcumulativa)
						{
							decimal precioInt = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto + _listaDePreciosProveedoresItemSeleccionado.Bonificacion1 + _listaDePreciosProveedoresItemSeleccionado.Bonificacion2 + _listaDePreciosProveedoresItemSeleccionado.Bonificacion3;
							_listaDePreciosProveedoresItemSeleccionado.Bonificacion4 = (value * precioInt) / 100;
						}
						else
							_listaDePreciosProveedoresItemSeleccionado.Bonificacion4 = (value * _listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto) / 100;
                         * */
                        //Fin German 20120725 - Tarea 0000364
						if(_producto.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
						{
							_producto.PrecioDeCostoMonedaProducto = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _producto.ValorCotizacionPrecioDeCosto;
							//Sabrina 20100719 - Tarea 796
							_producto.ListaDePrecios.UpdatePrecios(_producto.PrecioDeCosto, _producto.MAC, _producto.PrecioDeVentaNeto);
							ListaDePreciosItem itemDefault = _producto.ListaDePrecios.GetDefaultItem();
							_producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
							/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
								_producto.PrecioLista = _producto.PrecioDeVentaNeto;
								*/
							//Fin Sabrina 20100719 - Tarea 796
						}
                        //German 20110309 - Tarea 0000038
                        //if(_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && (_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia")  || _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior")))
                        if (_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && Workflow.EsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName))
                        //Fin German 20110309 - Tarea 0000038
						{
							_producto.PrecioDeCostoMonedaProveedor = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _cotizacionProveedor.Valor;						
							if(PrecioDeCostoMonedaProveedorChanged != null)
								PrecioDeCostoMonedaProveedorChanged(this, new EventArgs());
						}
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
								{
									ListaDePreciosProveedoresItem item = prod.ListaDePreciosProveedores.getListaDePreciosProveedoresItem(_idProveedorListaDePrecios);
									item.PorcentajeBonificacion4 = value;
                                    //German 20120725 - Tarea 0000364
                                    this.recalcularBonificaciones(item);
                                    /*

									if(item.BonificacionAcumulativa)
									{
										decimal precioInt = item.PrecioDeCosto + item.Bonificacion1 + item.Bonificacion2 + item.Bonificacion3;
										item.Bonificacion4 = (value * precioInt) / 100;
									}
									else
										item.Bonificacion4 = (value * item.PrecioDeCosto) / 100;
                                     * */
                                    //Fin German 20120725 - Tarea 0000364
									if(prod.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
									{
										prod.PrecioDeCostoReposicion = (item.PrecioDeCostoFinal * item.ValorCotizacionProveedor) / prod.ValorCotizacionPrecioDeCosto;
										prod.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / prod.ValorCotizacionPrecioDeCosto;
										//Sabrina 20100719 - Tarea 796
										prod.ListaDePrecios.UpdatePrecios(prod.PrecioDeCosto, prod.MAC, prod.PrecioDeVentaNeto);
										ListaDePreciosItem itemDefault = prod.ListaDePrecios.GetDefaultItem();
										prod.PrecioLista = itemDefault.PrecioDeVentaBruto;
										/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
											prod.PrecioLista = prod.PrecioDeVentaNeto;
											*/
										//Fin Sabrina 20100719 - Tarea 796
									}
								}
						}
						
					}
				}
			}
		}

		
		public decimal PorcentajeBonificacion5
		{
			get
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
					return _listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion5;
				return 0;
			}
			set
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
				{
					if(value != _listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion5)
					{
						_listaDePreciosProveedoresItemSeleccionado.PorcentajeBonificacion5 = value;
                        //German 20120725 - Tarea 0000364
                        this.recalcularBonificaciones(_listaDePreciosProveedoresItemSeleccionado);
                        /*
						if(_listaDePreciosProveedoresItemSeleccionado.BonificacionAcumulativa)
						{
							decimal precioInt = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto + _listaDePreciosProveedoresItemSeleccionado.Bonificacion1 + _listaDePreciosProveedoresItemSeleccionado.Bonificacion2 + _listaDePreciosProveedoresItemSeleccionado.Bonificacion3 + _listaDePreciosProveedoresItemSeleccionado.Bonificacion4;
							_listaDePreciosProveedoresItemSeleccionado.Bonificacion5 = (value * precioInt) / 100;
						}
						else
							_listaDePreciosProveedoresItemSeleccionado.Bonificacion5 = (value * _listaDePreciosProveedoresItemSeleccionado.PrecioDeCosto) / 100;
                         */
                        //German 20120725 - Tarea 0000364
						if(_producto.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
						{
							_producto.PrecioDeCostoMonedaProducto = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _producto.ValorCotizacionPrecioDeCosto;
							//Sabrina 20100719 - Tarea 796
							_producto.ListaDePrecios.UpdatePrecios(_producto.PrecioDeCosto, _producto.MAC, _producto.PrecioDeVentaNeto);
							ListaDePreciosItem itemDefault = _producto.ListaDePrecios.GetDefaultItem();
							_producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
							/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
								_producto.PrecioLista = _producto.PrecioDeVentaNeto;
								*/
							//Fin Sabrina 20100719 - Tarea 796
						}
                        //German 20110309 - Tarea 0000038
                        //if(_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && (_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia")  || _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior")))
                        if (_usaPrecioDeListaProveedor && _idProveedorListaDePrecios.Equals(_idProveedor) && Workflow.EsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName))
                        //Fin German 20110309 - Tarea 0000038
						{
							_producto.PrecioDeCostoMonedaProveedor = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _cotizacionProveedor.Valor;
							if(PrecioDeCostoMonedaProveedorChanged != null)
								PrecioDeCostoMonedaProveedorChanged(this, new EventArgs());
						}
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
					if(_seleccionMultilple)
					{
						foreach(Producto prod in _productos)
						{
							if(prod != _producto)
								if(prod.Selected)
								{
									ListaDePreciosProveedoresItem item = prod.ListaDePreciosProveedores.getListaDePreciosProveedoresItem(_idProveedorListaDePrecios);
									item.PorcentajeBonificacion5 = value;
                                    //German 20120725 - Tarea 0000364
                                    this.recalcularBonificaciones(item);
                                    /*
									if(item.BonificacionAcumulativa)
									{
										decimal precioInt = item.PrecioDeCosto + item.Bonificacion1 + item.Bonificacion2 + item.Bonificacion3 + item.Bonificacion4;
										item.Bonificacion5 = (value * precioInt) / 100;
									}
									else
										item.Bonificacion5 = (value * item.PrecioDeCosto) / 100;
                                     * */
                                    //Fin German 20120725 - Tarea 0000364
									if(prod.IdProveedorDefault.Equals(_idProveedorListaDePrecios) /*&& !_habilitaTrasladarPrecioDeListaFinal*/)
									{
										prod.PrecioDeCostoReposicion = (item.PrecioDeCostoFinal * item.ValorCotizacionProveedor) / prod.ValorCotizacionPrecioDeCosto;
										prod.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / prod.ValorCotizacionPrecioDeCosto;
										//Sabrina 20100719 - Tarea 796
										prod.ListaDePrecios.UpdatePrecios(prod.PrecioDeCosto, prod.MAC, prod.PrecioDeVentaNeto);
										ListaDePreciosItem itemDefault = prod.ListaDePrecios.GetDefaultItem();
										prod.PrecioLista = itemDefault.PrecioDeVentaBruto;
										/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
											prod.PrecioLista = prod.PrecioDeVentaNeto;
											*/
										//Fin Sabrina 20100719 - Tarea 796
									}
								}
						}
						
					}
				}
			}
		}

		public decimal PrecioDeCostoFinalProveedor
		{
			get
			{
				if(_listaDePreciosProveedoresItemSeleccionado != null)
					return _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal;
				return 0;
			}
		}

		private bool _existeProveedorProducto = false;
		public bool ExisteProveedorProducto
		{
			get{return _existeProveedorProducto;}
		}

		public ListaDePreciosProveedoresItem ListaDePreciosProveedoresItemSeleccionado
		{
			get{return _listaDePreciosProveedoresItemSeleccionado;}
			set
			{
				if(value != null)
				{
					ListaDePreciosProveedoresItem itemLP = (ListaDePreciosProveedoresItem) value;
					if(itemLP != _listaDePreciosProveedoresItemSeleccionado)
					{
						_listaDePreciosProveedoresItemSeleccionado = itemLP;
						_idProveedorListaDePrecios = itemLP.IdProveedor;
						_existeProveedorProducto = !_listaDePreciosProveedoresItemSeleccionado.isNew();
						//Sabrina: tarea 56
						_precioDeCostoMonedaProveedorAnterior = _producto.PrecioDeCostoMonedaProveedor;
                        //German 20110309 - Tarea 0000038
						//if(!(_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia")  || _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior")))
                        if (Workflow.NOEsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName))
                        //Fin German 20110309 - Tarea 0000038
						{
							_listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinalChanged -=new EventHandler(_listaDePreciosProveedoresItemSeleccionado_PrecioDeCostoFinalChanged); 
							if(_producto.IdProveedorDefault.Equals(_idProveedorListaDePrecios) )
							{
								_listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinalChanged +=new EventHandler(_listaDePreciosProveedoresItemSeleccionado_PrecioDeCostoFinalChanged); 
							}
						}
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
				}
								
			}
		}

        //Sabrina: Tarea 1068. 20110317
        private bool _actualizaPreciosProductosCombo = false;
        public bool ActualizaPreciosProductosCombo
        {
            get { return _actualizaPreciosProductosCombo; }
            set { _actualizaPreciosProductosCombo = value; }
        }
        //Fin Sabrina: Tarea 1068. 20110317

		#endregion

		#region Metodos Privados

		private void recalcularBonificaciones(ListaDePreciosProveedoresItem item)
		{
			item.Bonificacion1 = (item.PrecioDeCosto * item.PorcentajeBonificacion1) /100;
			if(item.BonificacionAcumulativa)
			{
				decimal precioInt = item.PrecioDeCosto + item.Bonificacion1;
				item.Bonificacion2 = (precioInt * item.PorcentajeBonificacion2) /100;
				precioInt += item.Bonificacion2;
				item.Bonificacion3 = (precioInt * item.PorcentajeBonificacion3) /100;
				precioInt += item.Bonificacion3;
				item.Bonificacion4 = (precioInt * item.PorcentajeBonificacion4) /100;
				precioInt += item.Bonificacion4;
				item.Bonificacion5 = (precioInt * item.PorcentajeBonificacion5) /100;
			}
			else
			{
				item.Bonificacion2 = (item.PrecioDeCosto * item.PorcentajeBonificacion2) /100;
				item.Bonificacion3 = (item.PrecioDeCosto * item.PorcentajeBonificacion3) /100;
				item.Bonificacion4 = (item.PrecioDeCosto * item.PorcentajeBonificacion4) /100;
				item.Bonificacion5 = (item.PrecioDeCosto * item.PorcentajeBonificacion5) /100;
			}
		}


		private void commitProveedoresProductos(Producto prod)
		{
			if(prod.ListaDePreciosProveedores.Items.Count > 0)
			{
				foreach(ListaDePreciosProveedoresItem item in prod.ListaDePreciosProveedores.Items)
				{
					switch(item.Estado)
					{
						case "NEW": //Nueva lista de precios proveedores para el producto
						{
							tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow rowPP = _dataProveedoresProductos.tpu_ProveedoresProductos.Newtpu_ProveedoresProductosRow();
							rowPP.IdProducto = item.IdProducto;
							rowPP.IdProveedor = item.IdProveedor;
							rowPP.PrecioDeCosto = item.PrecioDeCosto;
							rowPP.IdMonedaPrecioDeCosto = item.IdMonedaPrecioDeCosto;
							rowPP.IdCotizacionPrecioDeCosto = item.IdCotizacionPrecioDeCosto;
							rowPP.IdFuenteDeCambio = item.IdFuenteDeCambio;
							rowPP.PrecioDeCostoFinal = item.PrecioDeCostoFinal;
							rowPP.FechaUltimaModificacionPrecioDeCosto = mz.erp.businessrules.Sistema.DateTime.Now;
                            //German 20110309 - Tarea 0000038
							//if(/*!_usaPrecioDeListaProveedor &&*/ (_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia") || _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior")))
                            if (/*!_usaPrecioDeListaProveedor &&*/ Workflow.EsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName))
                            //Fin German 20110309 - Tarea 0000038
							{
								rowPP.PrecioDeCostoUltimaCompra = prod.PrecioDeCostoMonedaProducto;
								rowPP.FechaUltimaModificacionPrecioDeCostoUltimaCompra = mz.erp.businessrules.Sistema.DateTime.Now;
							}
							else
								rowPP.PrecioDeCostoUltimaCompra = 0;				
							rowPP.CampoAuxiliar1 = item.CampoAuxiliar1;
							rowPP.CampoAuxiliar2 = item.CampoAuxiliar2;
							rowPP.CampoAuxiliar3 = item.CampoAuxiliar3;
							rowPP.CampoAuxiliar4 = item.CampoAuxiliar4;
							rowPP.CampoAuxiliar5 = item.CampoAuxiliar5;
							rowPP.BonificacionAcumulativa = item.BonificacionAcumulativa;
							rowPP.Bonificacion1 = item.Bonificacion1;
							rowPP.Bonificacion2 = item.Bonificacion2;
							rowPP.Bonificacion3 = item.Bonificacion3;
							rowPP.Bonificacion4 = item.Bonificacion4;
							rowPP.Bonificacion5 = item.Bonificacion5;
							rowPP.Observaciones = item.Observaciones;
							rowPP.FechaCreacion = DateTime.Now;
							rowPP.IdConexionCreacion = Security.IdConexion;
							rowPP.IdConexionUltimaModificacion = Security.IdConexion;
							rowPP.IdReservado= 0;
							rowPP.RowId = Guid.Empty;
							rowPP.IdSucursal = Security.IdSucursal;
							rowPP.IdEmpresa = Security.IdEmpresa;
							rowPP.PorcentajeBonificacion1 = item.PorcentajeBonificacion1;
							rowPP.PorcentajeBonificacion2 = item.PorcentajeBonificacion2;
							rowPP.PorcentajeBonificacion3 = item.PorcentajeBonificacion3;
							rowPP.PorcentajeBonificacion4 = item.PorcentajeBonificacion4;
							rowPP.PorcentajeBonificacion5 = item.PorcentajeBonificacion5;
							rowPP.IdCotizacionProveedor = item.IdCotizacionProveedor;
							rowPP.IdFuenteDeCambioProveedor = item.IdFuenteDeCambioProveedor;
							rowPP.IdMonedaProveedor = item.IdMonedaProveedor;
							rowPP.ValorCotizacionProveedor = item.ValorCotizacionProveedor;
							_dataProveedoresProductos.tpu_ProveedoresProductos.Addtpu_ProveedoresProductosRow(rowPP);

                            //Sabrina: Incidencia 0000204. 20110901
                            //Agrego en tpu_ProveedoresProductosAuxiliares
                            tpu_ProveedoresProductosAuxiliaresDataset.tpu_ProveedoresProductosAuxiliaresRow rowPPA = _dataProveedoresProductosAuxiliares.tpu_ProveedoresProductosAuxiliares.Newtpu_ProveedoresProductosAuxiliaresRow();
                            mz.erp.businessrules.tpu_ProveedoresProductosAuxiliares.SetRowDefaultValues(rowPPA);
                            rowPPA.IdProducto = item.IdProducto;
                            rowPPA.IdProveedor = item.IdProveedor;
                            rowPPA.CodigoProductoProveedor = item.CodigoProductoProveedor;
                            _dataProveedoresProductosAuxiliares.tpu_ProveedoresProductosAuxiliares.Addtpu_ProveedoresProductosAuxiliaresRow(rowPPA);
                            //Fin Sabrina: Incidencia 0000204. 20110901
							break;

						}
						case "MODIF": //Modificacion de Lista de precios proveedores producto 
						{
							tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow rowPP = tpu_ProveedoresProductos.GetByPk(item.IdProveedor, item.IdProducto);  
							rowPP.PrecioDeCosto = item.PrecioDeCosto;
							if(rowPP.PrecioDeCostoFinal != item.PrecioDeCostoFinal)
								rowPP.FechaUltimaModificacionPrecioDeCosto = mz.erp.businessrules.Sistema.DateTime.Now;
							rowPP.PrecioDeCostoFinal = item.PrecioDeCostoFinal;
                            //German 20110309 - Tarea 0000038
                            //if(/*!_usaPrecioDeListaProveedor &&*/ (_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia") || _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior")))
                            if (/*!_usaPrecioDeListaProveedor &&*/ Workflow.EsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName))
                            //Fin German 20110309 - Tarea 0000038
							{
								rowPP.PrecioDeCostoUltimaCompra = prod.PrecioDeCostoMonedaProducto;
								rowPP.FechaUltimaModificacionPrecioDeCostoUltimaCompra = mz.erp.businessrules.Sistema.DateTime.Now;
							}				
							rowPP.BonificacionAcumulativa = item.BonificacionAcumulativa;
							rowPP.Bonificacion1 = item.Bonificacion1;
							rowPP.Bonificacion2 = item.Bonificacion2;
							rowPP.Bonificacion3 = item.Bonificacion3;
							rowPP.Bonificacion4 = item.Bonificacion4;
							rowPP.Bonificacion5 = item.Bonificacion5;
							rowPP.PorcentajeBonificacion1 = item.PorcentajeBonificacion1;
							rowPP.PorcentajeBonificacion2 = item.PorcentajeBonificacion2;
							rowPP.PorcentajeBonificacion3 = item.PorcentajeBonificacion3;
							rowPP.PorcentajeBonificacion4 = item.PorcentajeBonificacion4;
							rowPP.PorcentajeBonificacion5 = item.PorcentajeBonificacion5;
							rowPP.IdCotizacionProveedor = item.IdCotizacionProveedor;
							rowPP.IdFuenteDeCambioProveedor = item.IdFuenteDeCambioProveedor;
							rowPP.IdMonedaProveedor = item.IdMonedaProveedor;
							rowPP.ValorCotizacionProveedor = item.ValorCotizacionProveedor;
							_dataProveedoresProductos.tpu_ProveedoresProductos.ImportRow(rowPP);
                            //German 20140125 - Tarea 1 - SP 22
                            tpu_ProveedoresProductosAuxiliaresDataset.tpu_ProveedoresProductosAuxiliaresRow rowPPA = mz.erp.dataaccess.tpu_ProveedoresProductosAuxiliares.GetByPk(item.IdProveedor, item.IdProducto);
                            rowPPA.CodigoProductoProveedor = item.CodigoProductoProveedor;
                            _dataProveedoresProductosAuxiliares.tpu_ProveedoresProductosAuxiliares.ImportRow(rowPPA);
                            //Fin German 20140125 - Tarea 1 - SP 22
							break;
						}
						default:
						{
                            //German 20110309 - Tarea 0000038
							//if(_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia")  || _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior"))
                            if (Workflow.EsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName))
                            //Fin German 20110309 - Tarea 0000038
							{
								tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow rowPP = null;
								rowPP = _dataProveedoresProductos.tpu_ProveedoresProductos.FindByIdProveedorIdProducto(item.IdProveedor, prod.IdProducto);
								if(rowPP != null)
								{
									rowPP.PrecioDeCostoUltimaCompra = prod.PrecioDeCostoMonedaProducto;
									rowPP.FechaUltimaModificacionPrecioDeCostoUltimaCompra = mz.erp.businessrules.Sistema.DateTime.Now;
                                    //German 20140125 - Tarea 1 - SP 22
                                    tpu_ProveedoresProductosAuxiliaresDataset.tpu_ProveedoresProductosAuxiliaresRow rowPPA = null;
                                    rowPPA = _dataProveedoresProductosAuxiliares.tpu_ProveedoresProductosAuxiliares.FindByIdProveedorIdProducto(item.IdProveedor, prod.IdProducto);
                                    if (rowPPA != null)
                                    {
                                        rowPPA.CodigoProductoProveedor = item.CodigoProductoProveedor;
                                    }
                                    //Fin German 20140125 - Tarea 1 - SP 22
								}
								else
								{
									rowPP = tpu_ProveedoresProductos.GetByPk(item.IdProveedor, item.IdProducto);  
									if(rowPP != null)
									{
										rowPP.PrecioDeCostoUltimaCompra = prod.PrecioDeCostoMonedaProducto;
										rowPP.FechaUltimaModificacionPrecioDeCostoUltimaCompra = mz.erp.businessrules.Sistema.DateTime.Now;
										_dataProveedoresProductos.tpu_ProveedoresProductos.ImportRow(rowPP);

                                        //German 20140125 - Tarea 1 - SP 22
                                        tpu_ProveedoresProductosAuxiliaresDataset.tpu_ProveedoresProductosAuxiliaresRow rowPPA = mz.erp.dataaccess.tpu_ProveedoresProductosAuxiliares.GetByPk(item.IdProveedor, item.IdProducto);
                                        rowPPA.CodigoProductoProveedor = item.CodigoProductoProveedor;
                                        _dataProveedoresProductosAuxiliares.tpu_ProveedoresProductosAuxiliares.ImportRow(rowPPA);
                                        //Fin German 20140125 - Tarea 1 - SP 22
									}
									else
									{
										rowPP = _dataProveedoresProductos.tpu_ProveedoresProductos.Newtpu_ProveedoresProductosRow();
										rowPP.IdProducto = item.IdProducto;
										rowPP.IdProveedor = item.IdProveedor;
										rowPP.PrecioDeCosto = item.PrecioDeCosto;
										rowPP.IdMonedaPrecioDeCosto = item.IdMonedaPrecioDeCosto;
										rowPP.IdCotizacionPrecioDeCosto = item.IdCotizacionPrecioDeCosto;
										rowPP.IdFuenteDeCambio = item.IdFuenteDeCambio;
										rowPP.PrecioDeCostoFinal = item.PrecioDeCostoFinal;
										rowPP.FechaUltimaModificacionPrecioDeCosto = mz.erp.businessrules.Sistema.DateTime.Now;
                                        //German 20110309 - tarea 0000038
										//if(/*!_usaPrecioDeListaProveedor &&*/ (_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia") || _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior")))
                                        if (/*!_usaPrecioDeListaProveedor &&*/ Workflow.EsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName))
                                        //Fin German 20110309 - tarea 0000038
										{
											rowPP.PrecioDeCostoUltimaCompra = prod.PrecioDeCostoMonedaProducto;
											rowPP.FechaUltimaModificacionPrecioDeCostoUltimaCompra = mz.erp.businessrules.Sistema.DateTime.Now;
										}
										else
											rowPP.PrecioDeCostoUltimaCompra = 0;				
										rowPP.CampoAuxiliar1 = item.CampoAuxiliar1;
										rowPP.CampoAuxiliar2 = item.CampoAuxiliar2;
										rowPP.CampoAuxiliar3 = item.CampoAuxiliar3;
										rowPP.CampoAuxiliar4 = item.CampoAuxiliar4;
										rowPP.CampoAuxiliar5 = item.CampoAuxiliar5;
										rowPP.BonificacionAcumulativa = item.BonificacionAcumulativa;
										rowPP.Bonificacion1 = item.Bonificacion1;
										rowPP.Bonificacion2 = item.Bonificacion2;
										rowPP.Bonificacion3 = item.Bonificacion3;
										rowPP.Bonificacion4 = item.Bonificacion4;
										rowPP.Bonificacion5 = item.Bonificacion5;
										rowPP.Observaciones = item.Observaciones;
										rowPP.FechaCreacion = DateTime.Now;
										rowPP.IdConexionCreacion = Security.IdConexion;
										rowPP.IdConexionUltimaModificacion = Security.IdConexion;
										rowPP.IdReservado= 0;
										rowPP.RowId = Guid.Empty;
										rowPP.IdSucursal = Security.IdSucursal;
										rowPP.IdEmpresa = Security.IdEmpresa;
										rowPP.PorcentajeBonificacion1 = item.PorcentajeBonificacion1;
										rowPP.PorcentajeBonificacion2 = item.PorcentajeBonificacion2;
										rowPP.PorcentajeBonificacion3 = item.PorcentajeBonificacion3;
										rowPP.PorcentajeBonificacion4 = item.PorcentajeBonificacion4;
										rowPP.PorcentajeBonificacion5 = item.PorcentajeBonificacion5;
										rowPP.IdCotizacionProveedor = item.IdCotizacionProveedor;
										rowPP.IdFuenteDeCambioProveedor = item.IdFuenteDeCambioProveedor;
										rowPP.IdMonedaProveedor = item.IdMonedaProveedor;
										rowPP.ValorCotizacionProveedor = item.ValorCotizacionProveedor;
										_dataProveedoresProductos.tpu_ProveedoresProductos.Addtpu_ProveedoresProductosRow(rowPP);

                                        //Sabrina: Incidencia 0000204. 20110901
                                        //Agrego en tpu_ProveedoresProductosAuxiliares
                                        tpu_ProveedoresProductosAuxiliaresDataset.tpu_ProveedoresProductosAuxiliaresRow rowPPA = _dataProveedoresProductosAuxiliares.tpu_ProveedoresProductosAuxiliares.Newtpu_ProveedoresProductosAuxiliaresRow();
                                        mz.erp.businessrules.tpu_ProveedoresProductosAuxiliares.SetRowDefaultValues(rowPPA);
                                        rowPPA.IdProducto = item.IdProducto;
                                        rowPPA.IdProveedor = item.IdProveedor;
                                        rowPPA.CodigoProductoProveedor = item.CodigoProductoProveedor;
                                        _dataProveedoresProductosAuxiliares.tpu_ProveedoresProductosAuxiliares.Addtpu_ProveedoresProductosAuxiliaresRow(rowPPA);
                                        //Fin Sabrina: Incidencia 0000204. 20110901

									}
								}
						
							}	
							if (item.EsProveedorPorDefault)
							{
								DataRow rowProd = ((tsh_ProductosDataset) _dataProductos).tsh_Productos.FindByIdProducto(prod.IdProducto);
								rowProd["IdProveedorDefault"] = item.IdProveedor; 
							}
							break;
						}
					
					}
				}
			}
			else
			{
                //German 20110309 - tarea 0000038
				//if(_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia")  || _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior"))
                if (Workflow.EsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName))
                //Fin German 20110309 - tarea 0000038
				{
					tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow rowPP = null;
					rowPP = _dataProveedoresProductos.tpu_ProveedoresProductos.FindByIdProveedorIdProducto(this.IdProveedor, prod.IdProducto);
					if(rowPP != null)
					{
						rowPP.PrecioDeCostoUltimaCompra = prod.PrecioDeCostoMonedaProducto;
						rowPP.FechaUltimaModificacionPrecioDeCostoUltimaCompra = mz.erp.businessrules.Sistema.DateTime.Now;
					}
					else
					{
						rowPP = tpu_ProveedoresProductos.GetByPk(this.IdProveedor, prod.IdProducto);  
						if(rowPP != null)
						{
							rowPP.PrecioDeCostoUltimaCompra = prod.PrecioDeCostoMonedaProducto;
							rowPP.FechaUltimaModificacionPrecioDeCostoUltimaCompra = mz.erp.businessrules.Sistema.DateTime.Now;
							_dataProveedoresProductos.tpu_ProveedoresProductos.ImportRow(rowPP);

						}
						else
						{
							rowPP = _dataProveedoresProductos.tpu_ProveedoresProductos.Newtpu_ProveedoresProductosRow();
							rowPP.IdProducto = prod.IdProducto;
							rowPP.IdProveedor = _idProveedor;
							rowPP.PrecioDeCosto = prod.PrecioDeCostoMonedaProducto;
							rowPP.IdMonedaPrecioDeCosto = prod.IdMonedaPrecioDeCosto;
							rowPP.IdCotizacionPrecioDeCosto = prod.IdCotizacionMonedaPrecioDeCosto;
							rowPP.IdFuenteDeCambio = prod.IdFuenteDeCambioProductoPrecioDeCosto;
							rowPP.PrecioDeCostoFinal = prod.PrecioDeCostoMonedaProducto;
							rowPP.FechaUltimaModificacionPrecioDeCosto = mz.erp.businessrules.Sistema.DateTime.Now;
							rowPP.PrecioDeCostoUltimaCompra = prod.PrecioDeCostoMonedaProducto;
							rowPP.FechaUltimaModificacionPrecioDeCostoUltimaCompra = mz.erp.businessrules.Sistema.DateTime.Now;
							rowPP.CampoAuxiliar1 = string.Empty;
							rowPP.CampoAuxiliar2 = string.Empty;
							rowPP.CampoAuxiliar3 = string.Empty;
							rowPP.CampoAuxiliar4 = string.Empty;
							rowPP.CampoAuxiliar5 = 0;
							rowPP.BonificacionAcumulativa = false;
							rowPP.Bonificacion1 = 0;
							rowPP.Bonificacion2 = 0;
							rowPP.Bonificacion3 = 0;
							rowPP.Bonificacion4 = 0;
							rowPP.Bonificacion5 = 0;
							rowPP.Observaciones = string.Empty;
							rowPP.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
							rowPP.IdConexionCreacion = Security.IdConexion;
							rowPP.IdConexionUltimaModificacion = Security.IdConexion;
							rowPP.IdReservado= 0;
							rowPP.RowId = Guid.Empty;
							rowPP.IdSucursal = Security.IdSucursal;
							rowPP.IdEmpresa = Security.IdEmpresa;
							rowPP.PorcentajeBonificacion1 = 0;
							rowPP.PorcentajeBonificacion2 = 0;
							rowPP.PorcentajeBonificacion3 = 0;
							rowPP.PorcentajeBonificacion4 = 0;
							rowPP.PorcentajeBonificacion5 = 0;
							rowPP.IdCotizacionProveedor = prod.IdCotizacionMonedaPrecioDeCosto;
							rowPP.IdFuenteDeCambioProveedor = prod.IdFuenteDeCambioProductoPrecioDeCosto;
							rowPP.IdMonedaProveedor = prod.IdMonedaPrecioDeCosto;
							rowPP.ValorCotizacionProveedor = prod.ValorCotizacionPrecioDeCosto;
							_dataProveedoresProductos.tpu_ProveedoresProductos.Addtpu_ProveedoresProductosRow(rowPP);

                            //Sabrina: Incidencia 0000204. 20110901
                            //Agrego en tpu_ProveedoresProductosAuxiliares
                            tpu_ProveedoresProductosAuxiliaresDataset.tpu_ProveedoresProductosAuxiliaresRow rowPPA = _dataProveedoresProductosAuxiliares.tpu_ProveedoresProductosAuxiliares.Newtpu_ProveedoresProductosAuxiliaresRow();
                            mz.erp.businessrules.tpu_ProveedoresProductosAuxiliares.SetRowDefaultValues(rowPPA);
                            rowPPA.IdProducto = prod.IdProducto;
                            rowPPA.IdProveedor = _idProveedor;
                            rowPPA.CodigoProductoProveedor = string.Empty;
                            _dataProveedoresProductosAuxiliares.tpu_ProveedoresProductosAuxiliares.Addtpu_ProveedoresProductosAuxiliaresRow(rowPPA);
                            //Fin Sabrina: Incidencia 0000204. 20110901
                        }
					}
						
				}	
				

			}
		
		}




		/*		private void commitProveedoresProductos(Producto prod)
				{
			
					if(!this._idProveedorListaDePrecios.Equals(string.Empty))
					{
						tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow rowPP = mz.erp.dataaccess.tpu_ProveedoresProductos.GetByPk(this._idProveedorListaDePrecios, prod.IdProducto);
						if(rowPP != null) //Existe la fila entonces la modifico
						{
							this._dataProveedoresProductos.Tables[0].ImportRow(rowPP);
							tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow rowProvProd = ((tpu_ProveedoresProductosDataset)this._dataProveedoresProductos).tpu_ProveedoresProductos.FindByIdProveedorIdProducto(this._idProveedorListaDePrecios, prod.IdProducto);
							rowProvProd.PrecioDeCosto = _precioDeCostoProvProd;
							rowProvProd.Bonificacion1 = _bonificacion1;
							rowProvProd.Bonificacion2 = _bonificacion2;
							rowProvProd.Bonificacion3 = _bonificacion3;
							rowProvProd.Bonificacion4 = _bonificacion4;
							rowProvProd.Bonificacion5 = _bonificacion5;
							rowProvProd.PorcentajeBonificacion1 = _porcentajeBonificacion1;
							rowProvProd.PorcentajeBonificacion2 = _porcentajeBonificacion2;
							rowProvProd.PorcentajeBonificacion3 = _porcentajeBonificacion3;
							rowProvProd.PorcentajeBonificacion4 = _porcentajeBonificacion4;
							rowProvProd.PorcentajeBonificacion5 = _porcentajeBonificacion5;
							/*
							if(_usaPrecioDeListaProveedor)
							{
								rowProvProd.PrecioDeCostoFinal = _precioDeCostoFinalProveedor;
								rowProvProd.FechaUltimaModificacionPrecioDeCosto = DateTime.Now;
							}
							else
							{
								rowProvProd.PrecioDeCostoUltimaCompra = prod.PrecioDeCostoMonedaProducto;
								rowProvProd.FechaUltimaModificacionPrecioDeCostoUltimaCompra = DateTime.Now;
							}
							*/

		/*					if(rowProvProd.PrecioDeCostoFinal != _precioDeCostoFinalProveedor)
								rowProvProd.FechaUltimaModificacionPrecioDeCosto = DateTime.Now;
							rowProvProd.PrecioDeCostoFinal = _precioDeCostoFinalProveedor;
						
							if(!_usaPrecioDeListaProveedor && _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia"))
							{
								rowProvProd.PrecioDeCostoUltimaCompra = prod.PrecioDeCostoMonedaProducto;
								rowProvProd.FechaUltimaModificacionPrecioDeCostoUltimaCompra = DateTime.Now;
							}

						}
						else
						{
							tpu_ProveedoresProductosDataset dataPP = (tpu_ProveedoresProductosDataset) this._dataProveedoresProductos;
							rowPP = dataPP.tpu_ProveedoresProductos.Newtpu_ProveedoresProductosRow();
							rowPP.IdProducto = prod.IdProducto;
							rowPP.IdProveedor = _idProveedorListaDePrecios;
							rowPP.PrecioDeCosto = _precioDeCostoProvProd;
							rowPP.IdMonedaPrecioDeCosto = _idMonedaPrecioDeCostoProveedor;
							rowPP.IdCotizacionPrecioDeCosto = _idCotizacionPrecioDeCostoProveedor;
							rowPP.IdFuenteDeCambio = _idFuenteDeCambioListaProveedor;
							/*
							if(_usaPrecioDeListaProveedor)
							{
								rowPP.PrecioDeCostoFinal = _precioDeCostoFinalProveedor;
								rowPP.FechaUltimaModificacionPrecioDeCosto = DateTime.Now;
							}
							else
							{
								rowPP.PrecioDeCostoUltimaCompra = prod.PrecioDeCostoMonedaProducto;
								rowPP.FechaUltimaModificacionPrecioDeCostoUltimaCompra = DateTime.Now;
							}
							*/
		/*					rowPP.PrecioDeCostoFinal = _precioDeCostoFinalProveedor;
							/*Validar que el precio de lista cambio*/
		/*					rowPP.FechaUltimaModificacionPrecioDeCosto = DateTime.Now;
							if(!_usaPrecioDeListaProveedor && _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia"))
							{
								rowPP.PrecioDeCostoUltimaCompra = prod.PrecioDeCostoMonedaProducto;
								rowPP.FechaUltimaModificacionPrecioDeCostoUltimaCompra = DateTime.Now;
							}
							rowPP.CampoAuxiliar1 = string.Empty;
							rowPP.CampoAuxiliar2 = string.Empty;
							rowPP.CampoAuxiliar3 = string.Empty;
							rowPP.CampoAuxiliar4 = string.Empty;
							rowPP.CampoAuxiliar5 = 0;
							rowPP.Bonificacion1 = _bonificacion1;
							rowPP.Bonificacion2 = _bonificacion2;
							rowPP.Bonificacion3 = _bonificacion3;
							rowPP.Bonificacion4 = _bonificacion4;
							rowPP.Bonificacion5 = _bonificacion5;
							rowPP.Observaciones = string.Empty;
							rowPP.FechaCreacion = DateTime.Now;
							rowPP.IdConexionCreacion = Security.IdConexion;
							rowPP.IdConexionUltimaModificacion = Security.IdConexion;
							rowPP.IdReservado= 0;
							rowPP.RowId = Guid.Empty;
							rowPP.IdSucursal = Security.IdSucursal;
							rowPP.IdEmpresa = Security.IdEmpresa;
							rowPP.PorcentajeBonificacion1 = _porcentajeBonificacion1;
							rowPP.PorcentajeBonificacion2 = _porcentajeBonificacion2;
							rowPP.PorcentajeBonificacion3 = _porcentajeBonificacion3;
							rowPP.PorcentajeBonificacion4 = _porcentajeBonificacion4;
							rowPP.PorcentajeBonificacion5 = _porcentajeBonificacion5;
							dataPP.tpu_ProveedoresProductos.Addtpu_ProveedoresProductosRow(rowPP);
						}
				
					}
				}*/

		/*		private void recalcularBonificaciones()
				{
					Bonificacion1 = (_precioDeCostoProvProd * _porcentajeBonificacion1) /100;
					Bonificacion2 = (_precioDeCostoProvProd * _porcentajeBonificacion2) /100;
					Bonificacion3 = (_precioDeCostoProvProd * _porcentajeBonificacion3) /100;
					Bonificacion4 = (_precioDeCostoProvProd * _porcentajeBonificacion4) /100;
					Bonificacion5 = (_precioDeCostoProvProd * _porcentajeBonificacion5) /100;
				}
		*/
		/*		private void setDatosProveedoresProductos()
				{
					_precioDeCostoProvProd = 0;
					if(_usaCotizacionDefault || _producto == null)
					{
						_idMonedaPrecioDeCostoProveedor = _idMonedaReferencia;
						_idFuenteDeCambioListaProveedor = _idFuenteDeCambioProveedor;
						_idCotizacionPrecioDeCostoProveedor = Variables.GetValueString("Contabilidad.CotizacionReferencia");
					}
					else
					{
						_idMonedaPrecioDeCostoProveedor = _producto.IdMonedaPrecioDeCosto;
						_idFuenteDeCambioListaProveedor = _producto.IdFuenteDeCambioProductoPrecioDeCosto;
						_idCotizacionPrecioDeCostoProveedor = _producto.IdCotizacionMonedaPrecioDeCosto;
					}
					_bonificacion1 = 0;
					_bonificacion2 = 0;
					_bonificacion3 = 0;
					_bonificacion4 = 0;
					_bonificacion5 = 0;
					_porcentajeBonificacion1 = 0;
					_porcentajeBonificacion2 = 0;
					_porcentajeBonificacion3 = 0;
					_porcentajeBonificacion4 = 0;
					_porcentajeBonificacion5 = 0;
					_precioDeCostoFinalProveedor = 0;
					_existeProveedorProducto = false;
					_cotizacionPrecioDeCostoProveedor= new CotizacionWrapper(_idCotizacionPrecioDeCostoProveedor);
					_valorCotizacionPrecioDeCostoProveedor = _cotizacionPrecioDeCostoProveedor.Valor;
					_simbololMonedaPrecioDeCostoProveedor = tfi_Monedas.GetByPk(_idMonedaPrecioDeCostoProveedor).Simbolo;
					if(!_seleccionMultilple)
					{
						if(_producto != null)
						{ 
						   tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow rowPP = businessrules.tpu_ProveedoresProductos.GetByPk(_idProveedorListaDePrecios, _producto.IdProducto);
							if(rowPP != null)
							{
								_precioDeCostoProvProd = rowPP.PrecioDeCosto;
								_idMonedaPrecioDeCostoProveedor = rowPP.IdMonedaPrecioDeCosto;
								_idFuenteDeCambioListaProveedor = rowPP.IdFuenteDeCambio;
								_idCotizacionPrecioDeCostoProveedor = rowPP.IdCotizacionPrecioDeCosto;
								_bonificacion1 = rowPP.Bonificacion1;
								_bonificacion2 = rowPP.Bonificacion2;
								_bonificacion3 = rowPP.Bonificacion3;
								_bonificacion4 = rowPP.Bonificacion4;
								_bonificacion5 = rowPP.Bonificacion5;
								_porcentajeBonificacion1 = rowPP.PorcentajeBonificacion1;
								_porcentajeBonificacion2 = rowPP.PorcentajeBonificacion2;
								_porcentajeBonificacion3 = rowPP.PorcentajeBonificacion3;
								_porcentajeBonificacion4 = rowPP.PorcentajeBonificacion4;
								_porcentajeBonificacion5 = rowPP.PorcentajeBonificacion5;
								_precioDeCostoFinalProveedor = rowPP.PrecioDeCostoFinal;
								_existeProveedorProducto = true;
								_precioDeCostoUltimaCompra = rowPP.PrecioDeCostoUltimaCompra;
								_cotizacionPrecioDeCostoProveedor= new CotizacionWrapper(_idCotizacionPrecioDeCostoProveedor);
								_valorCotizacionPrecioDeCostoProveedor = _cotizacionPrecioDeCostoProveedor.Valor;
								_simbololMonedaPrecioDeCostoProveedor = tfi_Monedas.GetByPk(_idMonedaPrecioDeCostoProveedor).Simbolo;
						
								/*if(_processParent.Process.ProcessName.Equals("ProcesoIngresarPrecioProducto"))
								{
									_producto.PrecioDeCostoMonedaProducto = _precioDeCostoFinalProveedor * _valorCotizacionPrecioDeCostoProveedor / _producto.ValorCotizacionPrecioDeCosto;
								}
						
								if(_processParent.Process.ProcessName.Equals("ProcesoIngresarPrecioProducto"))
								{
									if(_usaPrecioDeListaProveedor)
									{
										//PrecioDeCostoMonedaProveedor = _precioDeCostoFinalProveedor;
										_producto.PrecioDeCostoMonedaProducto = _precioDeCostoFinalProveedor;
									}
									else
									{
										//PrecioDeCostoMonedaProveedor = _precioDeCostoUltimaCompra;
										_producto.PrecioDeCostoMonedaProducto = _precioDeCostoUltimaCompra;
									}
								}
								*/
						
		/*}
				}
			}



		}*/

		private bool ChequearMonedaPrecioDeCosto()
		{
			foreach(Producto prod in _productos)
			{
				foreach(Producto p in _productos)
				{
					if(prod != p)
						if(p.Selected)
							if(p.IdCotizacionMonedaPrecioDeCosto != prod.IdCotizacionMonedaPrecioDeCosto)
								return false;
				}
			}
			return true;
		}

		private bool ChequearMonedaPrecioDeVenta()
		{
			foreach(Producto prod in _productos)
			{
				foreach(Producto p in _productos)
				{
					if(prod != p)
						if(p.Selected)
							if(p.IdCotizacionMonedaPrecioDeVentaNeto != prod.IdCotizacionMonedaPrecioDeVentaNeto)
								return false;
				}
			}
			return true;
		}

		#endregion
			
		#region Miembros de ITask

		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;

		public event System.EventHandler OnTaskAfterPrevious;

		public event System.EventHandler ListaDePreciosProveedoresHasChanged;


		public void ListenerTaskDependentChanged(object sender)
		{
			
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.comprobantes.ComprobanteDeCompra)))	
			{
				ComprobanteDeCompra comprobante = (ComprobanteDeCompra) sender;
                //German 20110309 - Tarea 0000038
                if ((comprobante.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoIngresarComprasCompleto")
                   && comprobante.GetTaskName().Equals("ConfirmarIngresoMercaderia")) || (!comprobante.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoIngresarComprasCompleto"))

                   )
                {
                   if ((comprobante.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoIngresarComprasCompleto")
                   && comprobante.GetTaskName().Equals("ConfirmarIngresoMercaderia")))
                        _compCompra = comprobante;

                    //Fin German 20110309 - Tarea 0000038
                    
                    LoadFromComprobanteDeCompra(comprobante);
                    //Sabrina: tarea 56
                    if (_usaPrecioDeListaProveedor)
                    {
                        foreach (Producto prod in _productos)
                        {
                            ListaDePreciosProveedoresItem itemLP = prod.ListaDePreciosProveedores.getListaDePreciosProveedoresItem(_idProveedor);
                            if (itemLP == null)
                            {
                                string IdMonedaPrecioDeCostoProveedor = prod.IdMonedaPrecioDeCosto;
                                string IdFuenteDeCambioListaProveedor = prod.IdFuenteDeCambioProductoPrecioDeCosto;
                                string IdCotizacionPrecioDeCostoProveedor = prod.IdCotizacionMonedaPrecioDeCosto;
                                string IdMonedaProveedor = prod.IdMonedaPrecioDeCosto;
                                string IdFuenteDeCambioProveedor = prod.IdFuenteDeCambioProductoPrecioDeCosto;
                                string IdCotizacionProveedor = prod.IdCotizacionMonedaPrecioDeCosto;
                                if (_usaCotizacionDefault)
                                {
                                    IdMonedaProveedor = _idMonedaReferencia;
                                    IdFuenteDeCambioProveedor = _idFuenteDeCambioProveedor;
                                    IdCotizacionProveedor = Variables.GetValueString("Contabilidad.CotizacionReferencia");
                                }
                                itemLP = new ListaDePreciosProveedoresItem(prod.IdProducto, _idProveedor, IdMonedaPrecioDeCostoProveedor, IdFuenteDeCambioListaProveedor, IdCotizacionPrecioDeCostoProveedor, IdCotizacionProveedor, IdFuenteDeCambioProveedor, IdMonedaProveedor, _bonificacionesAcumulativas);
                                prod.ListaDePreciosProveedores.AddItem(itemLP);
                            }
                            if (prod.OrdenDeCompraItem != null)
                            {
                                prod.PrecioDeCostoMonedaProveedor = prod.OrdenDeCompraItem.PrecioDeCosto * prod.OrdenDeCompraItem.ValorCotizacion / _cotizacionProveedor.Valor;
                            }
                            else
                            {
                                if (_usaPrecioDeListaProveedor)
                                    prod.PrecioDeCostoMonedaProveedor = itemLP.PrecioDeCostoFinal * itemLP.ValorCotizacionProveedor / _cotizacionProveedor.Valor;
                                else
                                    prod.PrecioDeCostoMonedaProveedor = itemLP.PrecioDeCostoUltimaCompra * prod.ValorCotizacionPrecioDeCosto / _cotizacionProveedor.Valor;
                            }
                            //German 20090722
                            if ( Workflow.EsProcesoDeConfirmacionDePrecios(this._processParent.Process.ProcessName)
                                
                                )
                            {
                                if (itemLP != null)
                                {
                                    if (itemLP.IdProveedor.Equals(prod.IdProveedorDefault))
                                        itemLP.ActualizaPrecioDeCostoReposicion = true;

                                }
                            }

                            //Fin German 20090722
                        }
                    }
                    IdProveedor = this._idProveedor;
                }
			}
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.ConfirmarPreciosProductosCompras)))	
			{
				ConfirmarPreciosProductosCompras comprobante = (ConfirmarPreciosProductosCompras) sender;
				LoadFromConfirmarPreciosProductosCompras( comprobante);
				IdProveedor = this._idProveedor;
			}
		}

		private void LoadFromConfirmarPreciosProductosCompras( ConfirmarPreciosProductosCompras comp)
		{
			foreach( FacturaDeCompraItem itemFA in comp.Items)
			{
				Producto prod = _productos.GetByIdProducto(itemFA.IdProducto);
				prod.PrecioDeCostoMonedaProveedor = itemFA.PrecioDeCostoReal;
			}/*
				itemFA.CantidadFactura = item.Cantidad;
				itemFA.CantidadReal = item.Cantidad;
				itemFA.CantidadOrdenDeCompra = itemOC.CantidadOrigen;
				itemFA.Codigo = item.Codigo;
				itemFA.FechaOrdenDeCompra = itemOC.FechaComprobanteOrigen;
				itemFA.IdFuenteDeCambioOrdenDeCompra = itemOC.IdFuenteDeCambio;
				itemFA.IdComprobanteOrdenDeCompra = itemOC.IdComprobanteOrigen;
				itemFA.IdMonedaOrdenDeCompra = itemOC.IdMoneda;
				itemFA.IdProducto = item.IdProducto;
				itemFA.NumeroOrdenDeCompra = itemOC.NumeroComprobanteOrigen;
				itemFA.Ordinal = item.Ordinal;// Es el ordinal del CRMXC
				itemFA.OrdinalOrdenDeCompra = itemOC.OrdinalOrigen;
				itemFA.PrecioDeCostoFactura = item.PrecioDeCosto;
				itemFA.PrecioDeCostoReal = item.PrecioDeCosto;
				itemFA.PrecioDeCostoOrdenDeCompra = itemOC.PrecioDeCosto;
				itemFA.Producto = item.Descripcion;
				itemFA.ValorCotizacionOrdenDeCompra = itemOC.ValorCotizacion;
				itemFA.ValorCotizacionFactura = item.ValorCotizacionPrecioDeCosto;
				
			}*/
		}

		private void LoadFromComprobanteDeCompra( ComprobanteDeCompra comp)
		{
			//this._items.Clear();
			this._productos.Clear();
			this._idProveedor = comp.IdProveedor;
			GenerateCotizacionProveedor(comp);
			/**
			 * Ver de poner una variable para los clientes q no van a usar Ordenes de Compra
			 * De forma tal q se siga comportando como estaba antes
			 * */
			ArrayList ListaIdComprobantesOrigen = null;
			OrdenesDeComprasItems itemsOrdenesDeCompras = null;
			Producto prod = null;
			foreach(ItemComprobanteCompra item in comp.Items)
			{
				//if(!_tiposDeArticulosAdicionalesList.Contains(item.IdTipoProducto))
				//{
					if(item.OrdenCompraItem == null)
					{
						if(itemsOrdenesDeCompras == null)
						{
							ListaIdComprobantesOrigen = GetListaIdComprobantesOrigen(comp);
							itemsOrdenesDeCompras = new OrdenesDeComprasItems();
							itemsOrdenesDeCompras.LoadItems(ListaIdComprobantesOrigen);
						}
						prod = GenerateProducto(item.IdProducto, item.Cantidad, itemsOrdenesDeCompras.GetItem(item.IdComprobanteOrigen, item.OrdinalOrigen));
						item.OrdenCompraItem = itemsOrdenesDeCompras.GetItem(item.IdComprobanteOrigen, item.OrdinalOrigen);
					}
					else
						prod = GenerateProducto(item.IdProducto, item.Cantidad, item.OrdenCompraItem);
				
					/*
					 * Esta echo puesto que el add no necesariamente agrega el producto  a la coleccionn
					 * Si ya existe uno con el mismo codigo, modifica la cantidad
					 * Pendiente, modificar al Add para que devuelva el prodcuto agregado
					 * */
					this._productos.Add(prod);
					item.MiProducto = this._productos.GetByIdProducto(item.IdProducto);
				//}

			}
		}

		private ArrayList GetListaIdComprobantesOrigen(ComprobanteDeCompra comp)
		{
			ArrayList result = new ArrayList();
			foreach(ItemComprobanteCompra item in comp.Items)
			{
				if(item.IdComprobanteOrigen != null && item.IdComprobanteOrigen != string.Empty)
				{
					if(!result.Contains(item.IdComprobanteOrigen))
						result.Add(item.IdComprobanteOrigen);
				}
			}
			return result;
		}

	

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}

		
		public void Init()
		{

            _tableMonedas = mz.erp.businessrules.tfi_Monedas.GetList().tfi_Monedas;
			_tableFuentesDeCambio = mz.erp.businessrules.tfi_FuentesDeCambio.GetList().tfi_FuentesDeCambio;
			_idMonedaComprador = "2";
			_idMonedaProveedor = "2";
			_idMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");
			_dataMonedas = mz.erp.businessrules.tfi_Monedas.GetList();
			_simboloMonedaReferencia = _dataMonedas.tfi_Monedas.FindByIdMoneda(_idMonedaReferencia).Simbolo;
			
			
			_idFuenteDeCambioReferencia = Variables.GetValueString("Contabilidad.FuenteDeCambioReferencia");
			_idFuenteDeCambioProveedor = Variables.GetValueString("Contabilidad.FuenteDeCambioReferencia");
			GenerateCotizacionComprador();
			GenerateCotizacionProveedor();
			_productos = new ProductosCollection();
			this._dataProductos.DataSetName = "tsh_ProductosDataset";
			this._dataProductosSucursales.DataSetName = "tsh_ProductosSucursalesDataset";

			_usaCotizacionDefault = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "UsaCotizacionDefault");
			_usaPrecioDeListaProveedor = Variables.GetValueBool("Productos.Compras.Facturas.UsaPrecioDeListaProveedor");
			_idCotizacionPrecioDeCostoProveedor = Variables.GetValueString("Contabilidad.CotizacionReferencia");

			_habilitaTrasladarPrecioDeListaFinal = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "PermiteTrasladarPrecioListaFinal");
			_listaDePreciosHabilitadas = Variables.GetValueBool("Productos.ListasDePrecios"); 
			_precioDeVentaAfectaMac = Variables.GetValueBool("Productos.Precio.PrecioDeVentaAfectaMac", false);

			_tiposDeArticulosAdicionales = Variables.GetValueString("Compras.Facturas.TiposDeArticulosAdicionales");
			_tiposDeArticulosAdicionalesList = mz.erp.systemframework.Util.Parse( _tiposDeArticulosAdicionales);

			//German 20090420
			_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "ModificaPrecioDeCostoListaProveedorTrasladaPrecioDeVentaBruto","Productos.Precio.ModificaPrecioDeCostoListaProveedorTrasladaPrecioDeVentaBruto");
			//Fin German 20090420
			_allowCantidadAutomatica = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "CantidadAutomatica");
			/*German 20090325*/
			_calculaPPP = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName,"PrecioDeCosto.CalculaPPP","Productos.PrecioDeCosto.CalculaPPP", _calculaPPP);
			_productoComodin = new Producto(_calculaPPP, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
			/*Fin German 20090325*/

			_bonificacionesAcumulativas = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "BonificacionAcumulativa");
			_visualizaVentana = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "VisualizaVentana", _visualizaVentana);
            

            /*Verifica que se encuentre el parametro cargado que viene desde el ABM de productos*/
            //Cristian tarea 000243 20120103
            if (_processParent.Parametros != null)
            {
                if (_processParent.Parametros["IdProducto"] != null)
                {
                    String state = (String)this._processParent.Parametros["Estado"];
                    String _productoModificarPrecio = (String)this._processParent.Parametros["IdProducto"];
                    String _codigoNuevo = (String)this._processParent.Parametros["Codigo"];
                    //if (state.Equals("NEW")) {  }
                    //else
                    //{
                        this.AddRange(_productoModificarPrecio);
                    //}
                }
            }
            //Fin tarea 000243 20120103
            //German 20120522 - Tarea 0000333
            _noTrasladaSiempreCambioPrecioDeCompraAPrecioDeCostoReposicion = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "NoTrasladaSiempreCambioPrecioDeCompraAPrecioDeCostoReposicion");
            _preguntaTrasladaCambioPrecioDeCompraAPrecioDeCostoReposicion = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "PreguntaTrasladaCambioPrecioDeCompraAPrecioDeCostoReposicion");

            //Fin German 20120522 - Tarea 0000333

            
        }

		public void CargarCostosIndirectosDescripcion()
		{
			foreach(tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow row in CostosIndirectosLoader.Load().Rows)
			{                                  
				if ((row.Orden == 1) & ( row.Descripcion != string.Empty )) // & circuito corto
					_costoIndirectoDescrip1 = row.Descripcion;
				if ((row.Orden == 2) & ( row.Descripcion != string.Empty )) // & circuito corto
					_costoIndirectoDescrip2 = row.Descripcion;
				if ((row.Orden == 3) & ( row.Descripcion != string.Empty )) // & circuito corto
					_costoIndirectoDescrip3 = row.Descripcion;
				if ((row.Orden == 4) & ( row.Descripcion != string.Empty )) // & circuito corto
					_costoIndirectoDescrip4 = row.Descripcion;
				if ((row.Orden == 5) & ( row.Descripcion != string.Empty )) // & circuito corto
					_costoIndirectoDescrip5 = row.Descripcion;
				if ((row.Orden == 6) & ( row.Descripcion != string.Empty )) // & circuito corto
					_costoIndirectoDescrip6 = row.Descripcion;
				if ((row.Orden == 7) & ( row.Descripcion != string.Empty )) // & circuito corto
					_costoIndirectoDescrip7 = row.Descripcion;
				if ((row.Orden == 8) & ( row.Descripcion != string.Empty )) // & circuito corto
					_costoIndirectoDescrip8 = row.Descripcion;
				if ((row.Orden == 9) & ( row.Descripcion != string.Empty )) // & circuito corto
					_costoIndirectoDescrip9 = row.Descripcion;
				if ((row.Orden == 10) & ( row.Descripcion != string.Empty )) // & circuito corto
					_costoIndirectoDescrip10 = row.Descripcion;
			}
			
		}

		private void GenerateCotizacionComprador()
		{
			_cotizacionComprador = tfi_CotizacionesMonedas.GetCoeficienteCotizacion(_idMonedaComprador, _idMonedaReferencia, _idFuenteDeCambioReferencia);
			_valorCotizacionFuenteDeCambioComprador = _cotizacionComprador.Valor;
			_idCotizacionFuenteDeCambioComprador = _cotizacionComprador.IdCotizacion;
			_simboloMonedaComprador = _dataMonedas.tfi_Monedas.FindByIdMoneda(_idMonedaComprador).Simbolo;
		}
		
		private void GenerateCotizacionProveedor()
		{
			_cotizacionProveedor = Factory.GetCotizacion(string.Empty, _idMonedaProveedor, _idMonedaReferencia,_valorCotizacionFuenteDeCambioProveedor ,_idFuenteDeCambioProveedor);
			_simboloMonedaProveedor = _dataMonedas.tfi_Monedas.FindByIdMoneda(_idMonedaProveedor).Simbolo;
		}
		
		
		private void GenerateCotizacionProveedor(ComprobanteDeCompra comp)
		{
			_cotizacionProveedor.IdMonedaOrigen = comp.IdMonedaOrigen;
			_cotizacionProveedor.IdMonedaDestino = comp.IdMonedaCierre;
			_cotizacionProveedor.IdFuenteDeCambio = comp.IdFuenteDeCambioProveedor;
			_cotizacionProveedor.Valor = comp.ValorCotizacionProveedor;
			_valorCotizacionFuenteDeCambioProveedor = _cotizacionProveedor.Valor;
			_idFuenteDeCambioProveedor = _cotizacionProveedor.IdFuenteDeCambio;
			_idMonedaProveedor = _cotizacionProveedor.IdMonedaOrigen;
			_simboloMonedaProveedor = _dataMonedas.tfi_Monedas.FindByIdMoneda(_idMonedaProveedor).Simbolo;
			
		}
		
		
		private void GenerateProducto(string IdProducto, decimal Cantidad)
		{
			string IdVisualizacionDeStock = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "VisualizacionDeStock");
			/*German 20090325*/
			_producto = new Producto(IdProducto,IdVisualizacionDeStock, Cantidad, this._idProveedor, this._taskName,  _cotizacionProveedor, _usaPrecioDeListaProveedor, _calculaPPP, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
			/*Fin German 20090325*/
			
		}

		private Producto GenerateProducto(string IdProducto, decimal Cantidad, OrdenDeCompraItem item)
		{
			string IdVisualizacionDeStock = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "VisualizacionDeStock");
			/*German 20090325*/
			return new Producto(IdProducto,IdVisualizacionDeStock, Cantidad, this._idProveedor, this._taskName,  _cotizacionProveedor, _usaPrecioDeListaProveedor, item, _calculaPPP, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
			/*Fin German 20090325*/
		}

		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}
		
		public bool IsValid()
		{
			
			_errores.Clear();
			bool isvalid = ValidarPrecioDeVentaBruto();
			if(isvalid)
				isvalid =  ValidarMacError();
			if(isvalid)
				isvalid = ValidarProveedorDefault();
			return isvalid;
			
		}

		private bool ValidarMacError()
		{
			bool ok = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "ValidarMacNegativo.Error", "Productos.Precios.ValidarMacNegativo.Error");
			_errores.Clear();
			if(ok)
			{
				//if(!_listaDePreciosHabilitadas)
				//{	
				int i = 0;
				bool hayError = false;
				while(!hayError && i < _productos.Count)
				{
					Producto prod = (Producto)_productos.ToArrayList()[i];
					hayError = prod.MAC < 0;
					i++;
				}
				if(hayError)
					_errores.Add( new ItemDatasetError( "Ingresar Precio Producto","Margen/Precio Costo Neto","El Margen/Precio Costo Neto no puede ser negativo.") );
				//}
				/*else
				{
					int i = 0;
					bool hayError = false;
					while(!hayError && i < _productos.Count)
					{
						Producto prod = (Producto)_productos.ToArrayList()[i];
						int j = 0;
						while(!hayError && j < prod.ListaDePrecios.Items.Count)
						{
							ListaDePreciosItem item = (ListaDePreciosItem) prod.ListaDePrecios.Items[j];
							hayError = item.Mac < 0;
							j++;																															 
						}
						i++;
					}
					if(hayError)
						_errores.Add( new ItemDatasetError( "Ingresar Precio Producto","Margen/Precio Costo Neto","El Margen/Precio Costo Neto no puede ser negativo.") );
				}*/
			}
			return _errores.Count == 0;

		}

		private bool ValidarPrecioDeVentaBruto()
		{
			bool ok = Variables.GetValueBool("Productos.ListasDePrecios.ValidarPrecioDeVentaBruto.Error");
			_errores.Clear();
			if(ok)
			{
				if(!_listaDePreciosHabilitadas)
				{	
					int i = 0;
					bool hayError = false;
					while(!hayError && i < _productos.Count)
					{
						Producto prod = (Producto)_productos.ToArrayList()[i];
						hayError = decimal.Round(prod.PrecioDeVentaNeto,2) > decimal.Round(prod.PrecioLista,2);
						i++;
					}
					if(hayError)
						_errores.Add( new ItemDatasetError( "Ingresar Precio Producto","Precio de Lista","El precio de Lista no puede ser inferior al precio de venta neto.") );
				}
				else
				{
					int i = 0;
					bool hayError = false;
					while(!hayError && i < _productos.Count)
					{
						Producto prod = (Producto)_productos.ToArrayList()[i];
						int j = 0;
						while(!hayError && j < prod.ListaDePrecios.Items.Count)
						{
							ListaDePreciosItem item = (ListaDePreciosItem) prod.ListaDePrecios.Items[j];
							hayError = decimal.Round(item.PrecioDeVentaNeto,2) > decimal.Round(item.PrecioDeVentaBruto,2);
							j++;																															 
						}
						i++;
					}
					if(hayError)
						_errores.Add( new ItemDatasetError( "Ingresar Precio Producto","Precio de Lista","El precio de Lista no puede ser inferior al precio de venta neto.") );
				}
			}
			return _errores.Count == 0;

		}

		private bool ValidarPrecios()
		{
			//German 20100915 - Tarea 831
            //bool ok = Variables.GetValueBool("Productos.ListasDePrecios.ValidarPrecioDeVentaBruto.Error");
            bool ok = Variables.GetValueBool("Productos.ListasDePrecios.ValidarPrecioDeVentaBruto.Warning");
            //Fin German 20100915 - Tarea 831
			_productosInvalidos.Clear();
            //German 20100915 - Tarea 831
			//if(!ok)
            if(ok)
            //Fin German 20100915 - Tarea 831
			{
				if(!_listaDePreciosHabilitadas)
				{					
					foreach(Producto prod in _productos)
					{
						if(decimal.Round(prod.PrecioDeVentaNeto,2) > decimal.Round(prod.PrecioLista,2))
						{
							ItemError item = new ItemError();
							item.Codigo = prod.Codigo;
							item.Descripcion = prod.Descripcion;
							item.PrecioDeLista = prod.PrecioLista;
							item.PrecioDeVentaNeto = prod.PrecioDeVentaNeto;
							_productosInvalidos.Add(item);
						}
					}
				}
				else
				{
					foreach(Producto prod in _productos)
					{
						bool errors = false;
						foreach(ListaDePreciosItem item in prod.ListaDePrecios.Items)
						{
							if(decimal.Round(item.PrecioDeVentaNeto,2) > decimal.Round(item.PrecioDeVentaBruto,2))
							{
								errors = true;
							}
						}
						if(errors)
						{
							ItemError item = new ItemError();
							item.Codigo = prod.Codigo;
							item.Descripcion = prod.Descripcion;
							_productosInvalidos.Add(item);
						}

					}
				}
			}
			return _productosInvalidos.Count == 0;
		}

		private bool ValidarMAC()
		{
			bool ok = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "ValidarMacNegativo.Error", "Productos.Precios.ValidarMacNegativo.Error");
			if(!ok)
			{
				ok = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "ValidarMacNegativo.Advertencia", "Productos.Precios.ValidarMacNegativo.Advertencia");
				_productosInvalidos.Clear();
				if(ok)
				{
					//if(!_listaDePreciosHabilitadas)
					//{					
					foreach(Producto prod in _productos)
					{
						if(prod.MAC < 0)
						{
							ItemError item = new ItemError();
							item.Codigo = prod.Codigo;
							item.Descripcion = prod.Descripcion;
							item.PrecioDeLista = prod.PrecioLista;
							item.PrecioDeVentaNeto = prod.PrecioDeVentaNeto;
							_productosInvalidos.Add(item);
						}
					}
					//}
					/*else
					{
						foreach(Producto prod in _productos)
						{
							bool errors = false;
							foreach(ListaDePreciosItem item in prod.ListaDePrecios.Items)
							{
								if(item.Mac < 0)
									errors = true;
							}
							if(errors)
							{
								ItemError item = new ItemError();
								item.Codigo = prod.Codigo;
								item.Descripcion = prod.Descripcion;
								_productosInvalidos.Add(item);
							}

						}
					}*/
				}
				return _productosInvalidos.Count != 0;
			}
			else
				return false;
		}


		private bool ValidarProveedorDefault()
		{
			bool isValid = true;
			//Sabrina Tarea 75
			if(_usaPrecioDeListaProveedor)
			{				
				foreach(Producto prod in _productos)
				{
					if(prod.IdProveedorDefault.Equals(string.Empty))
					{
						_errores.Add( new ItemDatasetError( "Ingresar Precio Producto","Proveedor por Default","Debe seleccionar el Proveedor por Default para el producto" + prod.Codigo) );
						isValid = false;
					}
				}
			}
			/*
				bool isValid = false;
				foreach (ListaDePreciosProveedoresItem it in SelectedItem.ListaDePreciosProveedores.Items)
				{
					if (it.EsProveedorPorDefault)
					{
						isValid=true;
					}
				}
       			if(!isValid)
					_errores.Add( new ItemDatasetError( "Ingresar Precio Producto","Proveedor por Default","Debe seleccionar el Proveedor por Default") );
				*/
			return isValid;
		}
		
		public bool AllowShow()
		{
			return _visualizaVentana;
		}
		public void FormHasClosed() 
		{
		}
		public ItemsDatasetErrors GetErrors()
		{
			return _errores;
		}

		public string GetWarnings()
		{
			
			string res = string.Empty;
			bool ok = false;
			if (!this.ValidarPrecios())
			{
				ok = true;
				string result = string.Empty;
				foreach(ItemError item in _productosInvalidos)
				{
					result = result + item.Codigo + ' ';
				}
				res = res + "Lo/s Producto/s " + result + " posee/n precio de Lista inferior al precio de venta neto.";
			}
			if (this.ValidarPrecioProveedor())
			{
				ok = true;
				string result = string.Empty;
				foreach(ItemError item in _productosInvalidosPrecioProveedor)
				{
					result = result + item.Codigo + ' ';
				}
				res = res +   "Lo/s Producto/s " + result + " NO TIENEN PRECIO DE COMPRA.";
			}
			if (this.ValidarPrecioProveedorConPrecioFactura())
			{
				ok = true;
				string result = string.Empty;
				foreach(ItemError item in _productosInvalidosPrecioProveedorConPrecioFactura)
				{
					result = result + item.Codigo + ' ';
				}
				res = res +   "Lo/s Producto/s " + result + " EN ESTA FACTURA TIENEN UN PRECIO DISTINTO AL PRECIO DE LISTA DEL PROVEEDOR.";
			}
			if (this.ValidarMAC())
			{
				ok = true;
				string result = string.Empty;
				foreach(ItemError item in _productosInvalidos)
				{
					result = result + item.Codigo + ' ';
				}
				res = res + "Lo/s Producto/s " + result + " posee/n Margen/Precio Costo Neto inferior a 0.";
			}

			if(ok) res = res + " Desea Continuar de todas formas??";
			return res;
		}

		private bool ValidarPrecioProveedor()
		{
			bool ok = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "Validar.PrecioCompraProveedor");
			_productosInvalidosPrecioProveedor.Clear();
			if(ok)
			{
				foreach(Producto prod in _productos)
				{
					if(prod.PrecioDeCostoMonedaProveedor <= 0)
					{
						ItemError item = new ItemError();
						item.Codigo = prod.Codigo;
						item.Descripcion = prod.Descripcion;
						_productosInvalidosPrecioProveedor.Add(item);
					}
				}
			}
			return _productosInvalidosPrecioProveedor.Count > 0;

		}		
		private bool ValidarPrecioProveedorConPrecioFactura()
		{
			//German 20110309 - tarea 0000038
            //bool ok = _usaPrecioDeListaProveedor && (_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia") || _processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior"));
            bool ok = _usaPrecioDeListaProveedor && (Workflow.EsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName));
            //Fin German 20110309 - tarea 0000038
			_productosInvalidosPrecioProveedorConPrecioFactura.Clear();
			if(ok)
			{
				foreach(Producto prod in _productos)
				{
					
					ListaDePreciosProveedoresItem listaProv = prod.ListaDePreciosProveedores.getListaDePreciosProveedoresItem(_listaDePreciosProveedoresItemSeleccionado.IdProveedor);
					if(prod.PrecioDeCostoMonedaProveedor != (listaProv.PrecioDeCostoFinal * listaProv.ValorCotizacionProveedor / _cotizacionProveedor.Valor))
					{
						ItemError item = new ItemError();
						item.Codigo = prod.Codigo;
						item.Descripcion = prod.Descripcion;
						_productosInvalidosPrecioProveedorConPrecioFactura.Add(item);
					}
				}
			}
			return _productosInvalidosPrecioProveedorConPrecioFactura.Count > 0;

		}

		public ProcessManager GetProcessManagerParent()
		{
			return _processParent;
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_processParent = processManager;
		}

		public string GetTaskName()
		{
			return this._taskName;
		}

		public void SetTaskName(string taskName)
		{
			_taskName = taskName;
		}

		public void Execute()
		{
			if(OnTaskBeforeExecute != null)
				OnTaskBeforeExecute(this, new EventArgs());			

			this.IsValid();

			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}

		public bool AllowPrevious()
		{
			return true;
		}

		public void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public void ListenerAfterPreviousDependentTask(object sender)
		{
			
		}

		public void ListenerBeforePreviousDependentTask(object sender)
		{
			
		}

		#endregion

		#region Miembros de IPersistentTask

		public event System.EventHandler OnTaskBeforeFlush;

		public event System.EventHandler OnTaskAfterFlush;

		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();
			data.Add( (DataSet) this._dataProductos);
			data.Add( (DataSet) this._dataProductosSucursales);
			data.Add( (DataSet) this._dataProveedoresProductos);
			data.Add( (DataSet) this._dataProductosCoeficientesAplicados);
			return data;
		}

		public void Commit()
		{
			/*Ver para q procesos el commit se hace de esta manera.
			 * Tener en cuenta q s el producto se esta creando y esta tarea participa con otra tarea de la
			 * creacion de dicho producto, no se va hacer un update sino un insert
			 * 
			 * */

			/*if(!_seleccionMultilple)
				commitProveedoresProductos(_producto);
			*/

			foreach(Producto prod in this._productos)
			{
				DataRow row = mz.erp.businessrules.tsh_Productos.GetByPk(prod.IdProducto);
				_dataProductos.Tables[0].ImportRow(row);
				DataRow rowProd = ((tsh_ProductosDataset) _dataProductos).tsh_Productos.FindByIdProducto(prod.IdProducto);
				rowProd["MAC"] = prod.MAC;
				rowProd["PrecioDeCostoRef"] = prod.PrecioDeCosto;
				if(prod.PrecioDeCosto != prod.PrecioDeCostoEnBD)
					rowProd["FechaUltimaModificacionPrecioDeCosto"] = DateTime.Now;
				//Sabrina: tarea 56
				//rowProd["PrecioDeCostoDirecto"] = prod.PrecioDeCostoPromedioPonderado;
				//rowProd["PrecioDeCostoIndirecto"] = prod.CostosIndirectos;
				rowProd["PrecioDeCostoDirecto"] = prod.PrecioDeCostoDirecto;
				rowProd["PrecioDeCostoIndirecto"] = prod.PrecioDeCostoIndirecto;
				rowProd["UsaPrecioDeCostoReposicion"] = prod.UsaPrecioDeCostoReposicion;
				rowProd["PrecioDeCostoReposicion"] = prod.PrecioDeCostoReposicion;
				rowProd["PrecioDeCostoPromedioPonderado"] = prod.PrecioDeCostoPromedioPonderado;
				rowProd["PrecioDeVentaNeto"] = prod.PrecioDeVentaNeto;
				rowProd["MaxDescuentoPorcentual"] = prod.PorcentajeMaximoDescuento;
				rowProd["MaxDescuento"] = prod.MaximoDescuento;
				rowProd["PrecioDeVentaBruto"] = prod.PrecioLista;
				if(prod.PrecioLista != prod.PrecioDeListaEnBD)
					rowProd["FechaUltimaModificacionPrecioDeVenta"] = DateTime.Now;


				rowProd["IdMonedaCierrePrecioDeCostoRef"] = prod.IdMonedaPrecioDeCosto;
				rowProd["IdMonedaCierrePrecioDeVentaNeto"] = prod.IdMonedaPrecioDeVentaNeto;
				rowProd["IdMonedaCierreMaxDescuento"] = prod.IdMonedaPrecioDeVentaNeto;
				rowProd["IdMonedaCierrePrecioDeVentaBruto"] = prod.IdMonedaPrecioDeVentaNeto;

				rowProd["IdCotizacionCierrePrecioDeCostoRef"] = prod.IdCotizacionMonedaPrecioDeCosto;
				rowProd["IdCotizacionCierrePrecioDeVentaNeto"] = prod.IdCotizacionMonedaPrecioDeVentaNeto;
				rowProd["IdCotizacionCierreMaxDescuento"] = prod.IdCotizacionMonedaPrecioDeVentaNeto;
				rowProd["IdCotizacionCierrePrecioDeVentaBruto"] = prod.IdCotizacionMonedaPrecioDeVentaNeto;
				rowProd["IdProveedorDefault"] = prod.IdProveedorDefault;

				/*
					row = mz.erp.businessrules.tsh_ProductosSucursales.GetByPk(prod.IdProducto, prod.IdSucursal, prod.IdEmpresa);
					this._dataProductosSucursales.Tables[0].ImportRow(row);
					DataRow rowProdSuc = ((tsh_ProductosSucursalesDataset)this._dataProductosSucursales).tsh_ProductosSucursales.FindByIdProductoIdSucursalIdEmpresa(prod.IdProducto, prod.IdSucursal, prod.IdEmpresa);
					rowProdSuc["PrecioFinalEstimado"] = prod.PrecioDeVentaConImpuestos;
					*/
				
				
				if(_listaDePreciosHabilitadas)//Depende de la variable Productos.ListasDePrecios
					prod.ListaDePrecios.Commit();
				else
				{
					ListaDePreciosItem item = prod.ListaDePrecios.GetDefaultItem();
					item.ModoDeAplicacion = "P";
					item.PrecioDeCosto = prod.PrecioDeCosto;
					item.Mac = prod.MAC;
					item.PrecioDeVentaNeto = prod.PrecioDeVentaNeto;
					decimal coeficienteNew = item.GetCoeficienteFromPrecioVentaBruto(prod.PrecioLista);
					item.CoeficienteProducto = coeficienteNew;
					item.PrecioDeVentaBrutoConImpuestos = prod.PrecioDeListaConImpuestos;
					prod.ListaDePrecios.Commit(item);
				}
				//if(_seleccionMultilple && prod.Selected)
				commitProveedoresProductos(prod);

				// Commit de Porcentajes en tsh_ProductosAuxiliares
				CommitProductosAuxiliaresCoeficientes(prod);
				
                // Commit de Costos Indirectos.				
				prod.CoeficientesIndirectos.Commit();
				_dataProductosCoeficientesAplicados = prod.CoeficientesIndirectos.DataPca;
			}

		}

		private void CommitProductosAuxiliaresCoeficientes(Producto producto)
		{
			tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow rowPa = tsh_ProductosAuxiliares.GetByPk(producto.IdProducto);
			if ( rowPa != null )
			{
                rowPa.Coeficiente1 = producto.Coeficiente1;
				rowPa.Coeficiente2 = producto.Coeficiente2;
				rowPa.Coeficiente3 = producto.Coeficiente3;
				rowPa.Coeficiente4 = producto.Coeficiente4;
				rowPa.Coeficiente5 = producto.Coeficiente5;
				rowPa.Coeficiente6 = producto.Coeficiente6;
				rowPa.Coeficiente7 = producto.Coeficiente7;
				rowPa.Coeficiente8 = producto.Coeficiente8;
				rowPa.Coeficiente9 = producto.Coeficiente9;
				rowPa.Coeficiente10 = producto.Coeficiente10;
				_dataProductosAuxiliares.tsh_ProductosAuxiliares.ImportRow(rowPa);
			}					
		}


		private static SentenciasReplicacion  GenerateReplicaction()
		{
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsh_Productos";
			return replication;
			
		}

		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());
			SentenciasReplicacion _replicacion = GenerateReplicaction();
			mz.erp.dataaccess.tsh_Productos.Update(this._dataProductos, IdTransaction, _replicacion);
			foreach(Producto prod in this._productos)
			{
				DataRow row = mz.erp.businessrules.tsh_ProductosSucursales.GetByPk(IdTransaction, prod.IdProducto, prod.IdSucursal, prod.IdEmpresa);
				this._dataProductosSucursales.Tables[0].ImportRow(row);
				DataRow rowProdSuc = ((tsh_ProductosSucursalesDataset)this._dataProductosSucursales).tsh_ProductosSucursales.FindByIdProductoIdSucursalIdEmpresa(prod.IdProducto, prod.IdSucursal, prod.IdEmpresa);
				rowProdSuc["PrecioFinalEstimado"] = prod.PrecioDeListaConImpuestos;
				prod.ListaDePrecios.Flush(IdTransaction);
				prod.CoeficientesIndirectos.Flush(IdTransaction);
                //Sabrina: Tarea 1068. 20110317
                if(ActualizaPreciosProductosCombo)
                    tsh_CombosDet.ActualizarPreciosProductosCombo(IdTransaction, prod.IdProducto, prod.PrecioDeCosto, prod.PrecioLista, prod.IdMonedaPrecioDeCosto, prod.IdMonedaPrecioDeVentaNeto, prod.IdCotizacionMonedaPrecioDeCosto, prod.IdCotizacionMonedaPrecioDeVentaNeto);
                //Fin Sabrina: Tarea 1068. 20110317
			}
			mz.erp.dataaccess.tsh_ProductosSucursales.Update(this._dataProductosSucursales, IdTransaction, _replicacion);
			mz.erp.dataaccess.tpu_ProveedoresProductos.Update(this._dataProveedoresProductos.Tables[0], IdTransaction);
            //Sabrina: Incidencia 0000204. 20110901
            mz.erp.dataaccess.tpu_ProveedoresProductosAuxiliares.Update(this._dataProveedoresProductosAuxiliares.Tables[0], IdTransaction);
            //Fin Sabrina: Incidencia 0000204. 20110901
			mz.erp.dataaccess.tsh_ProductosAuxiliares.Update(this._dataProductosAuxiliares.Tables[0], IdTransaction);
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());	
		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
			
		}

		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			
			return GenerateReplicaction();
		}

		public bool GetHasSaved()
		{
			
			return false;
		}

		#endregion

		#region Metodos Publicos

        //German 20140125 - Tarea 1 - SP 22
        public void removeListaDePrecioProveedor(ListaDePreciosProveedoresItem item)
        {
            mz.erp.dataaccess.tpu_ProductosProveedores.removeListaDePrecioProveedor(item.IdProducto, item.IdProveedor);
        }
        //German 20140125 - Tarea 1 - SP 22

		//Sabrina: Tarea 1068. 20110317
        public bool CambioCostoProductosCombo()
        {
            bool cambio = false;
            foreach (Producto prod in this._productos)
            {
                if (prod.PrecioDeCosto != prod.PrecioDeCostoEnBD)
                {
                    tsh_CombosDetDataset.tsh_CombosDetDataTable tableProdCombo = tsh_CombosDet.GetByIdProductoReferencia(prod.IdProducto).tsh_CombosDet;
                    if (tableProdCombo.Rows.Count > 0)
                        cambio = true;
                }
            }
            return cambio;
        }

        public bool CambioPrecioVentaProductosCombo()
        {
            bool cambio = false;
            foreach (Producto prod in this._productos)
            {
                if (prod.PrecioLista != prod.PrecioDeListaEnBD)
                {
                    tsh_CombosDetDataset.tsh_CombosDetDataTable tableProdCombo = tsh_CombosDet.GetByIdProductoReferencia(prod.IdProducto).tsh_CombosDet;
                    if (tableProdCombo.Rows.Count > 0)
                        cambio = true;
                }
            }
            return cambio;
        }
        //Fin Sabrina: Tarea 1068. 20110317

        public bool isProveedorComprobante()
		{
			return _idProveedorListaDePrecios.Equals(_idProveedor);
		}

		public bool PrecioDeCostoMonedaProveedorEsIgualAPrecioDeCostoFinalLP()
		{
            //German 20101215 - Tarea 992
            //return _precioDeCostoMonedaProveedorAnterior == _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _cotizacionProveedor.Valor;						
            return _producto.PrecioDeCostoMonedaProveedor == _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _cotizacionProveedor.Valor
                && _precioDeCostoMonedaProveedorAnterior == _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _cotizacionProveedor.Valor;
            //Fin German 20101215 - Tarea 992
		}

		public void ActualizarPrecioDeCostoReposicionConPrecioDeCostoMonedaProveedor()
		{
			if(_producto != null)
			{
				_producto.ActualizarPrecioDeCostoReposicionConPrecioDeCostoMonedaProveedor();
                //German 20100913 - Tarea 830
                _producto.ListaDePrecios.UpdatePrecios(_producto.PrecioDeCosto, _producto.MAC, _producto.PrecioDeVentaNeto);
                ListaDePreciosItem itemDefault = _producto.ListaDePrecios.GetDefaultItem();
                _producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
                /*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
                    _producto.PrecioLista = _producto.PrecioDeVentaNeto;
                */
                //Fin German 20100913 - Tarea 830
				if(_seleccionMultilple)
				{
					foreach(Producto prod in _productos)
					{
						if(prod != _producto)
                            //German 20100913 - Tarea 830
                            if (prod.Selected)
                            {
                                prod.ActualizarPrecioDeCostoReposicionConPrecioDeCostoMonedaProveedor();
                                prod.ListaDePrecios.UpdatePrecios(prod.PrecioDeCosto, prod.MAC, prod.PrecioDeVentaNeto);
                                itemDefault = prod.ListaDePrecios.GetDefaultItem();
                                prod.PrecioLista = itemDefault.PrecioDeVentaBruto;
                                              
                            }
                            //Fin German 20100913 - Tarea 830
					}
				}

			}
		}

		public void DeshacerActualizarPrecioDeCostoReposicionConPrecioDeCostoMonedaProveedor()
		{
			if(_producto != null)
			{
				_producto.DeshacerActualizarPrecioDeCostoReposicionConPrecioDeCostoMonedaProveedor();
				_producto.IdProveedorDefault = _producto.IdProveedorDefaultAnterior;
				_producto.IdProveedorDefaultAnterior = "null";

			}
		}

		public void ActualizarPrecioDeCostoReposicionConPrecioDeCostoListaProveedor()
		{
			if(_producto != null)
			{
				_producto.ActualizarPrecioDeCostoReposicionConPrecioDeCostoListaProveedor();
				if(_producto.IdProveedorDefault != null && _producto.IdProveedorDefault != this.IdProveedor)
					_producto.IdProveedorDefault = IdProveedor;

			}

		}


		public void TrasladarPrecioDeListaFinal()
		{

			if(_listaDePreciosProveedoresItemSeleccionado != null)
			{
				
				_producto.PrecioDeCostoMonedaProducto = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _producto.ValorCotizacionPrecioDeCosto;
				if(_seleccionMultilple)
				{
					foreach(Producto prod in _productos)
					{
						if(prod != _producto)
							if(prod.Selected)
							{
								ListaDePreciosProveedoresItem item = prod.ListaDePreciosProveedores.getListaDePreciosProveedoresItem(_idProveedorListaDePrecios);
								prod.PrecioDeCostoMonedaProducto = item.PrecioDeCostoFinal * item.ValorCotizacionProveedor / prod.ValorCotizacionPrecioDeCosto;
							}
					}
					
				}
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
			}
			
		}

		/*		public void TrasladarPrecioUnitario()
				{

					if(_listaDePreciosProveedoresItemSeleccionado != null)
					{
						_listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal = _producto.PrecioDeCostoMonedaProducto * _producto.ValorCotizacionPrecioDeCosto / _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor;
						if(_seleccionMultilple)
						{
							foreach(Producto prod in _productos)
							{
								if(prod != _producto)
									if(prod.Selected)
									{
										ListaDePreciosProveedoresItem item = prod.ListaDePreciosProveedores.getListaDePreciosProveedoresItem(_idProveedorListaDePrecios);
										item.PrecioDeCostoFinal = prod.PrecioDeCostoMonedaProducto * prod.ValorCotizacionPrecioDeCosto / item.ValorCotizacionProveedor;
									}
							}
					
						}
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
			
				}*/

		public void UpdateCoeficienteToGral()
		{
			if(_listaDePreciosItemSeleccionado != null)
			{
				if(_listaDePreciosItemSeleccionado.CoeficienteProducto != _listaDePreciosItemSeleccionado.CoeficienteGral)
				{
					_producto.ListaDePrecios.UpdateCoeficienteToGral(_listaDePreciosItemSeleccionado);
					if(_listaDePreciosItemSeleccionado.IsDefault)
						_producto.PrecioLista = _listaDePreciosItemSeleccionado.PrecioDeVentaBruto;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
				if(_seleccionMultilple)
				{
					foreach(Producto prod in _productos)
					{
						if(prod != _producto)
							if(prod.Selected)
							{
								ListaDePreciosItem item = prod.ListaDePrecios.GetItem(prod.IdProducto, _listaDePreciosItemSeleccionado.IdListaDePrecios);
								prod.ListaDePrecios.UpdateCoeficienteToGral(item);
								if(item.IsDefault)
									prod.PrecioLista = item.PrecioDeVentaBruto;

							}
					}
				}
			}
				
			
		}

		//Sabrina: Tarea 60
		public void SetProveedorDefaultListaDePreciosProveedoresItemSeleccionado(bool esProveedorPorDefault)
		{
			if(_listaDePreciosProveedoresItemSeleccionado != null)
			{
				ArrayList listaDePreciosProv = _producto.ListaDePreciosProveedores.Items;
				foreach (ListaDePreciosProveedoresItem pp in listaDePreciosProv)
				{
					pp.EsProveedorPorDefault = false;
				}
				_listaDePreciosProveedoresItemSeleccionado.EsProveedorPorDefault = esProveedorPorDefault;
				if (esProveedorPorDefault)
				{
                    //German 20110309 - tarea 0000038
                    /*
					if(_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia") ||
						_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior"))
                    */
                    if (Workflow.EsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName))
                    //Fin German 20110309 - tarea 0000038
						_producto.IdProveedorDefaultAnterior = _producto.IdProveedorDefault;
					_producto.IdProveedorDefault = _listaDePreciosProveedoresItemSeleccionado.IdProveedor;
                    //Sabrina 20100730 - Tarea 804
                    _producto.PrecioDeCostoMonedaProducto = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _producto.ValorCotizacionPrecioDeCosto;
                    //Fin Sabrina 20100730 - Tarea 804
                    //German 20111227 - Tarea 0000242
                    _producto.PrecioDeCostoReposicion = _listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor / _producto.ValorCotizacionPrecioDeCosto;
                    //Fin German 20111227 - Tarea 0000242
					//Sabrina 20100719 - Tarea 796
					_producto.ListaDePrecios.UpdatePrecios(_producto.PrecioDeCosto, _producto.MAC, _producto.PrecioDeVentaNeto);
					ListaDePreciosItem itemDefault = _producto.ListaDePrecios.GetDefaultItem();
					_producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
					//German 20090826
					/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
						_producto.PrecioLista = _producto.PrecioDeVentaNeto;*/
					//German 20090826
					//Fin Sabrina 20100719 - Tarea 796
				}
				else
				{
                    //German 20110309 - Tarea 0000038
					/*if(_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia") ||
						_processParent.Process.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior"))
                     * */
                    if (Workflow.EsProcesoDeConfirmacionDePrecios(_processParent.Process.ProcessName))
                    //Fin German 20110309 - Tarea 0000038
					{
						if(_producto.IdProveedorDefaultAnterior.Equals("null"))
							_producto.IdProveedorDefault = string.Empty;
						else
                            _producto.IdProveedorDefault = _producto.IdProveedorDefaultAnterior;
						_producto.IdProveedorDefaultAnterior = "null";
						_producto.DeshacerActualizarPrecioDeCostoReposicionConPrecioDeCostoMonedaProveedor();
					}
				}
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
				if(_seleccionMultilple)
				{
					foreach(Producto prod in _productos)
					{
						if(prod != _producto)
							if(prod.Selected)
							{
								ArrayList listaDePreciosProvMultiple = prod.ListaDePreciosProveedores.Items;
								foreach (ListaDePreciosProveedoresItem pp in listaDePreciosProvMultiple)
								{
									pp.EsProveedorPorDefault = false;
								}
								ListaDePreciosProveedoresItem item = prod.ListaDePreciosProveedores.getListaDePreciosProveedoresItem(_idProveedorListaDePrecios);
								item.EsProveedorPorDefault = esProveedorPorDefault;
								if (esProveedorPorDefault)
								{
									prod.IdProveedorDefault = item.IdProveedor;
									prod.PrecioDeCostoReposicion = item.PrecioDeCostoFinal;
									//Sabrina 20100719 - Tarea 796
									prod.ListaDePrecios.UpdatePrecios(prod.PrecioDeCosto, prod.MAC, prod.PrecioDeVentaNeto);
									ListaDePreciosItem itemDefault = prod.ListaDePrecios.GetDefaultItem();
									prod.PrecioLista = itemDefault.PrecioDeVentaBruto;
									//German 20090826
									/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
										_producto.PrecioLista = _producto.PrecioDeVentaNeto;
										*/
									//German 20090826
									//Fin Sabrina 20100719 - Tarea 796

								}

							}
					}
						
				}
			}
		}

		public void AddRange(ArrayList items)
		{
			string IdVisualizacionDeStock = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "VisualizacionDeStock");
			foreach ( mz.erp.businessrules.comprobantes.Item item in items )
			{
				/*German 20090325*/
				Producto prod = new Producto(item.IdProducto, IdVisualizacionDeStock, _calculaPPP, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
				/*Fin German 20090325*/
				prod.Cantidad = item.Cantidad;
				this._productos.Add(prod);
			}
			if(ProductosCollectionChanged != null)
				ProductosCollectionChanged(this, new EventArgs());
		
		}

        //Cristian tarea 000243 20120103
        public void AddRange(String idProducto)
        {
                string IdVisualizacionDeStock = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "VisualizacionDeStock");
                Producto prod = new Producto(idProducto, IdVisualizacionDeStock, _calculaPPP, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
                prod.Cantidad = 1;
                this._productos.Add(prod);
                if (ProductosCollectionChanged != null)
                   ProductosCollectionChanged(this, new EventArgs());
        }
		//Fin Cristian Tarea 0000243		


		public void EliminarListaDePreciosProveedor(ListaDePreciosProveedoresItem item)
		{
			if(item.Estado.Equals("NEW") && _producto != null)
			{
				_producto.ListaDePreciosProveedores.RemoveItem(item);
				if(ListaDePreciosProveedoresHasChanged != null)
					ListaDePreciosProveedoresHasChanged(this, new EventArgs());
				if(_seleccionMultilple)
				{
					foreach(Producto prod in _productos)
					{
						if(prod != _producto)
							if(prod.Selected)
							{
								ListaDePreciosProveedoresItem it = prod.ListaDePreciosProveedores.getListaDePreciosProveedoresItem(item.IdProveedor);
								prod.ListaDePreciosProveedores.RemoveItem(it);
							}
					}
				}

			}
		}


		public void SetListaDePreciosProveedoresItemSeleccionadoNull()
		{
			if(_listaDePreciosProveedoresItemSeleccionado != null)
				_listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinalChanged -=new EventHandler(_listaDePreciosProveedoresItemSeleccionado_PrecioDeCostoFinalChanged); 
			_listaDePreciosProveedoresItemSeleccionado = null;
		}

		//------------------------------ Activa o Desactiva un costo indirecto
		public void ActivarCostoIndirecto(long idCosto, bool valor)
		{        
			_producto.ActivarCostoIndirecto(idCosto, valor);
			if(_seleccionMultilple)
				foreach(Producto prod in _productos)
				{
					if(prod != _producto)
						if(prod.Selected)
							prod.ActivarCostoIndirecto(idCosto, valor);
				}
			
			switch(idCosto)
			{
				case 1: 
				{
					if(CostoIndirecto1ActivatedChanged != null)
						CostoIndirecto1ActivatedChanged(this, new EventArgs());
					break;
				}
				case 2: 
				{
					if(CostoIndirecto2ActivatedChanged != null)
						CostoIndirecto2ActivatedChanged(this, new EventArgs());
					break;
				}
				case 3: 
				{
					if(CostoIndirecto3ActivatedChanged != null)
						CostoIndirecto3ActivatedChanged(this, new EventArgs());
					break;
				}
				case 4: 
				{
					if(CostoIndirecto4ActivatedChanged != null)
						CostoIndirecto4ActivatedChanged(this, new EventArgs());
					break;
				}
				case 5: 
				{
					/*
					if(CostoIndirecto5Changed != null)
						CostoIndirecto5Changed(this, new EventArgs());
					if(CostoIndirectoPorc5Changed != null)
						CostoIndirectoPorc5Changed(this, new EventArgs());
					*/
					if(CostoIndirecto5ActivatedChanged != null)
						CostoIndirecto5ActivatedChanged(this, new EventArgs());
					break;
				}
				case 6: 
				{
					if(CostoIndirecto6Changed != null)
						CostoIndirecto6Changed(this, new EventArgs());
					if(CostoIndirectoPorc6Changed != null)
						CostoIndirectoPorc6Changed(this, new EventArgs());
					break;
				}
				case 7: 
				{
					if(CostoIndirecto7Changed != null)
						CostoIndirecto7Changed(this, new EventArgs());
					if(CostoIndirectoPorc7Changed != null)
						CostoIndirectoPorc7Changed(this, new EventArgs());
					break;
				}
				case 8: 
				{
					if(CostoIndirecto8Changed != null)
						CostoIndirecto8Changed(this, new EventArgs());
					if(CostoIndirectoPorc8Changed != null)
						CostoIndirectoPorc8Changed(this, new EventArgs());
					break;
				}
				case 9: 
				{
					if(CostoIndirecto9Changed != null)
						CostoIndirecto9Changed(this, new EventArgs());
					if(CostoIndirectoPorc9Changed != null)
						CostoIndirectoPorc9Changed(this, new EventArgs());
					break;
				}
				case 10: 
				{
					if(CostoIndirecto10Changed != null)
						CostoIndirecto10Changed(this, new EventArgs());
					if(CostoIndirectoPorc10Changed != null)
						CostoIndirectoPorc10Changed(this, new EventArgs());
					break;
				}

			}
		}

		//-------------------------------------------------------------

		public bool CoeficienteCreadoyActivo(long indice)		
		{
			if(_producto != null)
				return _producto.CoeficienteCreadoyActivo(indice);
			return false;
		}

		public bool CoeficienteBinding(long indice)
		{
			foreach(tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow row in CostosIndirectosLoader.Load().Rows)
			{                                  
				if ((row.Orden == indice) && ( row.Activo )) 
					return true;
				else
					if ((row.Orden == indice) && ( !row.Activo )) 
                    	return false;
			}
			return false;
		}

		#endregion

		private void _listaDePreciosProveedoresItemSeleccionado_PrecioDeCostoFinalChanged(object sender, EventArgs e)
		{
			//German 20090729
			//PrecioDeCostoReposicion = (_listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor) / _producto.ValorCotizacionPrecioDeCosto;
			if(_producto != null)
			{
				decimal valor = (_listaDePreciosProveedoresItemSeleccionado.PrecioDeCostoFinal * _listaDePreciosProveedoresItemSeleccionado.ValorCotizacionProveedor) / _producto.ValorCotizacionPrecioDeCosto;
				if(valor != _producto.PrecioDeCostoReposicion)
				{
					_producto.PrecioDeCostoReposicion = valor;
					//Sabrina 20100719 - Tarea 796
					/*
					if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
						_producto.PrecioLista = _producto.PrecioDeVentaNeto;
						*/
					//Sabrina 20100719 - Tarea 796
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
			}
			//Fin German 20090729
		}
	}

	public sealed class ProductosCollection : CollectionBase
	{
		public ProductosCollection()
		{
			
		}

		public bool Contains(string IdProducto) 
		{
			bool resultado = false;
			foreach(Producto prod in this.List) 
			{
				if (prod.IdProducto.Equals(IdProducto))
				{
					return true;
				}
			}			
			return resultado;
		}
		
		public void SetCotizacionProveedor(Cotizacion cotizacionProveedor)
		{
			foreach(Producto prod in this.List)
				prod.CotizacionProveedor = cotizacionProveedor;
		}

		public void Add(Producto producto)
		{
			if (this.Contains(producto.IdProducto) )
			{
				foreach(Producto prod in this.List)
				{
					if(prod.IdProducto.Equals(producto.IdProducto)) 
					{
						prod.Cantidad+= producto.Cantidad;
					}						
				}
			}
			else 
			{
				this.List.Add(producto);
			}					
		}

		public ArrayList ToArrayList()
		{
			ArrayList resutl = new ArrayList();
			foreach(Producto prod in this.List)
				resutl.Add(prod);
			return resutl;
		}

		public Producto Get(int index )
		{
			return (Producto)List[index];
		}

		public Producto GetByCodigo (string codigo)
		{
			foreach(Producto prod in this.List)
			{
				if(prod.Codigo.Equals(codigo))
					return prod;
			}
			return null;
		}

		public Producto GetByIdProducto (string IdProducto)
		{
			foreach(Producto prod in this.List)
			{
				if(prod.IdProducto.Equals(IdProducto))
					return prod;
			}
			return null;
		}

		public void Clear()
		{
			this.List.Clear();
		}
		public void Remove(object item)
		{
			this.Remove((Producto)item);
		}

		public void Remove(Producto item)
		{
			this.List.Remove(item);
		}
	}
	

	public sealed class ImpuestoProducto
	{
		private string _idImpuesto = "";
		private string _descripcion = "";
		private bool _activo = false;
		private string _formula = "";

		public string IdImpuesto 
		{
			get {return _idImpuesto;}
			set {_idImpuesto = value;}
		}
		public string Descripcion 
		{
			get {return _descripcion;}
			set {_descripcion = value;}
		}
		public bool Activo 
		{
			get {return _activo;}
			set {_activo = value;}
		}
		public string Formula
		{
			get {return _formula;}
			set {_formula = value;}
		}
	}

	public class SucursalProducto
	{			
		//Datos de la tabla Productos Sucursales
		private long _idSucursal;
		private long _idEmpresa;
		private string _empresa;
		private string _descripcion;
		private bool _bloqueado;
		private decimal _incrementoDeCosto;
		private decimal _mac;
		private decimal _precioDeVentaNeto;
		private decimal _maximoDescuento;		
		private decimal _precioDeVentaBruto;
		private decimal _stockMinimo;
		private decimal _stockMaximo;
		private decimal _stockDisponible;
		private bool _isAvailable;

		//Datos del Producto
		private Producto _producto;

		//Datos de la Sucursal
		private decimal _cargoFijoProductos;
		private decimal _bonificacionRecargoProductos;




		
		public void Init(long IdSucursal, long IdEmpresa, Producto p)
		{

			sy_SucursalesDataset.sy_SucursalesRow row = mz.erp.businessrules.sy_Sucursales.GetByPk(IdSucursal);
			sy_EmpresasDataset.sy_EmpresasRow rowE = mz.erp.businessrules.sy_Empresas.GetByPk(IdEmpresa);
			tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow rowPS = mz.erp.businessrules.tsh_ProductosSucursales.GetByPk(p.IdProducto, IdSucursal, IdEmpresa);
			//El Producto
			_producto = p;

			//Datos de las Sucursales
			_idSucursal = row.IdSucursal;
			_descripcion = row.Descripcion;
			_cargoFijoProductos = row.CargoFijoProductos;
			_bonificacionRecargoProductos = row.BonificacionRecargoProductos;

			//Datos de la empresa
			_idEmpresa = rowE.IdEmpresa;
			_empresa = rowE.Descripcion;

			//Datos de los produstos Sucursales

			_isAvailable = rowPS.Activo;
			_incrementoDeCosto = rowPS.IncrementoDeCosto;
			_stockMinimo = rowPS.StockMinimo;
			_stockMaximo = rowPS.StockMaximo;
			_stockDisponible = rowPS.StockDisponible;
			_mac = rowPS.MAC;
			_maximoDescuento = rowPS.MaxDescuento;
			_precioDeVentaBruto = rowPS.PrecioDeVentaBruto;
			_precioDeVentaNeto = rowPS.PrecioDeVentaNeto;
		}


		public long IdEmpresa
		{
			get{return _idEmpresa;}
			set{_idEmpresa = value;}
		}

		public string Empresa
		{
			get{return _empresa;}
			set{_empresa = value;}
		}



		public decimal CargoFijoProductos
		{		
			get{return _cargoFijoProductos;}
			
		}

		public decimal BonificacionRecargoProductos
		{
			get{return _bonificacionRecargoProductos;}
			
		}

		public decimal StockMinimo
		{
			get{return _stockMinimo;}
			set{_stockMinimo = value;}
		}

		public decimal StockMaximo
		{
			get{return _stockMaximo;}				
			set{_stockMaximo = value;}
		}

		public decimal StockDisponible
		{
			get{return _stockDisponible;}				
		}

		public Producto Producto
		{
			get{return _producto;}
			set{_producto = value;}
		}

		public long IdSucursal
		{
			get{return _idSucursal;}
			set{_idSucursal = value;}
		}

		public string Descripcion
		{
			get{return _descripcion;}
			set
			{
				_descripcion = value;
			}
		}

		public bool Bloqueado
		{
			get{return _bloqueado;}
			set{_bloqueado = value;}
		}

		public decimal IncrementoDeCosto
		{
			get{return _incrementoDeCosto;}
			set{_incrementoDeCosto = value;}
		}		
			
		public decimal MAC
		{
			get{return _mac;}
			set{_mac = value;}
		}
		
		public decimal PrecioDeVentaNeto
		{
			get
			{
				decimal precioDeCostoProducto = this.Producto.PrecioDeCosto;
				decimal cargoFijoProducto = CargoFijoProductos;
				decimal incrementoDeCosto = IncrementoDeCosto;
				decimal montoDeIncremento = precioDeCostoProducto * incrementoDeCosto / 100;
				decimal precioDeCosto = (precioDeCostoProducto + montoDeIncremento + cargoFijoProducto);
				//Si el margen especifico para la sucursal no está definido obtengo el precio a partir del precio margen
				//definido en la central para el producto
				decimal precioDeVentaNeto = 0;
				if (MAC != 0)
				{
					precioDeVentaNeto = (precioDeCosto * MAC / 100)+ precioDeCosto;
				}
				else
				{
					precioDeVentaNeto = (precioDeCosto * this.Producto.MAC / 100) + precioDeCosto;
				}

				return precioDeVentaNeto;
			}
			
		}

		public decimal PrecioDeVentaBruto
		{
			get
			{
				decimal precioDeVentaBruto = this.Producto.PrecioLista;
				decimal incrementoProducto= precioDeVentaBruto * (BonificacionRecargoProductos / 100);
				decimal precioDeVentaBrutoSucursal = precioDeVentaBruto + incrementoProducto;
				return precioDeVentaBrutoSucursal;
			}
			
		}


		public decimal MaximoDescuento
		{	
			get{return (PrecioDeVentaBruto - PrecioDeVentaNeto);}
			
		}

		public decimal PrecioDeVentaBrutoConImpuestos
		{
			get
			{
				decimal _precioDeVentaBruto = this.PrecioDeVentaBruto;
				System.Collections.Hashtable formulas = mz.erp.businessrules.comprobantes.FuncionesImpuestos.ObtenerFormulas( null, null, Producto.IdProducto );                 
				decimal _impuestosBrutos = mz.erp.businessrules.comprobantes.FuncionesImpuestos.Calcular( formulas, _precioDeVentaBruto);
				return _precioDeVentaBruto+_impuestosBrutos;   
			}
		
		}

		

		
	}

	public sealed class ItemError
	{
		private string _codigo = string.Empty;
		private string _descripcion = string.Empty;
		private decimal _precioDeVentaNeto = 0;
		private decimal _precioDeLista = 0;

		public string Codigo
		{
			get{return _codigo;}
			set{_codigo = value;}
		}

		public string Descripcion
		{
			get{return _descripcion;}
			set{_descripcion = value;}
		}

		public decimal PrecioDeVentaNeto
		{
			get{return _precioDeVentaNeto;}
			set{_precioDeVentaNeto = value;}
		}

		public decimal PrecioDeLista
		{
			get{return _precioDeLista;}
			set{_precioDeLista = value;}
		}
	}
}

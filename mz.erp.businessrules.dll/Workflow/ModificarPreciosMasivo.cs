using System;
using System.Data;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes.data;
using System.Collections;
using mz.erp.commontypes;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ModificarPreciosMasivo.
	/// </summary>
	public class ModificarPreciosMasivo: ITask, IPersistentTask
	{
		
		#region Constructores

		public ModificarPreciosMasivo()
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

		public enum Afecta
		{
			NoAfecta,
			PrecioDeLista,
			PrecioDeListaIgualPrecioDeVentaSugerido,
			PrecioDeListaSIPrecioDeListaMenorPrecioVentaSugerido,
			PrecioDeListaIgualPrecioDeVentaSugeridoSIPrecioDeListaMenorPrecioVentaSugerido,
			MAC

		}

		
		#region Variables Privadas
			
		private string _idProducto = string.Empty;
		private string _codigo = string.Empty;
		private DataTable _tableMonedas = new DataTable();
		private DataTable _tableFuentesDeCambio = new DataTable();
		private string _idMonedaReferencia = string.Empty;
		private string _idMonedaValorConstante = string.Empty;
		private string _idFuenteDeCambioValorConstante = string.Empty;
		private string _simboloMonedaReferencia = string.Empty;
		private string _idFuenteDeCambioReferencia = string.Empty;


		private bool _aplicaValorConstante = false;
		private bool _aplicaPorcentaje = false;
		private decimal _porcentaje = 0;
		private decimal _valorConstante = 0;
		private decimal _valorConstanteCotizado = 0;
		private CotizacionWrapper _cotizacion = null;
		

		private bool _aplicaSobrePrecioDeCosto = false;
		private bool _aplicaSobrePrecioDeVenta = false;
		private bool _aplicaSobrePrecioDeVentaNeto = false;
		private bool _aplicaSobrePrecioDeVentaBruto = false;
		private bool _aplicaSobrePrecioDeVentaBrutoConImpuestos = false;
		
		private bool _aplicaSobreMAC = false;

		private bool _aplicaSobreMaximoDescuentoPorcentual = false;
		


		private Afecta _aplicaSobreMaximoDescuentoPorcentualAfecta;
		private Afecta _aplicaSobrePrecioDeCostoAfecta;
		private Afecta _aplicaSobrePrecioDeVentaAfecta;
		private Afecta _aplicaSobreMACAfecta;

		private bool _aplicaSobreCostoAfectaPCRTodos = false;
		private bool _aplicaSobreCostoAfectaPCRTodosUsaPcioCtoReposicion = false;
	
		
			
		//private ItemsIngresoPrecioProducto _items = new ItemsIngresoPrecioProducto();
		
		private ProductosCollection _productos;
		private ArrayList _productosDeshacer; 

		private ArrayList _productosInvalidos = new ArrayList();

		private DataSet _dataProductos = new tsh_ProductosDataset();
		private DataSet _dataProductosSucursales = new tsh_ProductosSucursalesDataset();
		private tsh_ProductosCoeficientesAplicadosDataset _dataProductosCoeficientesAplicados = new tsh_ProductosCoeficientesAplicadosDataset();
		private tsh_ProductosAuxiliaresDataset _dataProductosAuxiliares = new tsh_ProductosAuxiliaresDataset();

		private bool _error = false;
		private string _errorMessage = string.Empty;
		private bool _habilitaListasDePrecios = false;
		private bool _precioDeVentaAfectaMac = Variables.GetValueBool("Productos.Precio.PrecioDeVentaAfectaMac", false);
		private ListaDePreciosItem _listaDePreciosItemSeleccionado;
        //Sabrina: Tarea 834. 20101004
        //private string _idListaDePrecioSeleccionada = string.Empty;
        //Fin Sabrina: Tarea 834. 20101004

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

		/*German 20090325*/
		private bool _calculaPPP = true;
		private Producto _producto;
		/*Fin German 20090325*/

		private bool _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = false;
					
		#endregion

		#region Eventos

		
		public event EventHandler ProductosCollectionChanged;
		public event EventHandler ProductosCollectionBackChanged;
		public event EventHandler ErrorOcurred;

			
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

		#endregion
			
		#region Variables Publicas




        //Sabrina: Tarea 834. 20101004
        /*public string IdListaDePrecioSeleccionada
        {
            get{return _idListaDePrecioSeleccionada;}
        }*/
        //Fin Sabrina: Tarea 834. 20101004

		public ListaDePreciosItem ListaDePreciosItemSeleccionado
		{
			get{return _listaDePreciosItemSeleccionado;}
			set
			{
				if(value != null)
				{
					ListaDePreciosItem itemLP = (ListaDePreciosItem) value;
					if(itemLP != _listaDePreciosItemSeleccionado)
					{
						_listaDePreciosItemSeleccionado = itemLP;
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
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
				}
				
			}

		}


		public bool PrecioDeVentaAfectaMac
		{
			get{return _precioDeVentaAfectaMac;}
			set{_precioDeVentaAfectaMac = value;}
		}

		public bool PrecioDeVentaAfectaPVP
		{
			get{return !_precioDeVentaAfectaMac;}
			set{_precioDeVentaAfectaMac = !value;}
		}

		public bool AplicaSobreMaximoDescuentoPorcentual
		{
			get{return _aplicaSobreMaximoDescuentoPorcentual;}
			set{_aplicaSobreMaximoDescuentoPorcentual = value;}
		}
		public Afecta AplicaSobreMaximoDescuentoPorcentualAfecta
		{
			get{return _aplicaSobreMaximoDescuentoPorcentualAfecta;}
			set{_aplicaSobreMaximoDescuentoPorcentualAfecta = value;}
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
				}
			}
		}


		public bool Error
		{
			get{return _error;}
		}

		public string ErrorMessage
		{
			get{return _errorMessage;}
		}

		public bool PermiteDeshacer
		{
			get{return _productosDeshacer.Count > 0;}
		}

		public Afecta AplicaSobreMACAfecta
		{
			get{return _aplicaSobreMACAfecta;}
			set{_aplicaSobreMACAfecta = value;}
		}

		public Afecta AplicaSobrePrecioDeCostoAfecta
		{
			get{return _aplicaSobrePrecioDeCostoAfecta;}
			set{_aplicaSobrePrecioDeCostoAfecta = value;}
		}

		public Afecta AplicaSobrePrecioDeVentaAfecta
		{
			get{return _aplicaSobrePrecioDeVentaAfecta;}
			set{_aplicaSobrePrecioDeVentaAfecta = value;}
		}

		public bool AplicaSobreMAC
		{
			get{return _aplicaSobreMAC;}
			set{_aplicaSobreMAC = value;}
		}

		public bool AplicaSobrePrecioDeCosto
		{
			get{return _aplicaSobrePrecioDeCosto;}
			set{_aplicaSobrePrecioDeCosto = value;}
		}

		public bool AplicaSobrePrecioDeVenta
		{
			get{return _aplicaSobrePrecioDeVenta;}
			set{_aplicaSobrePrecioDeVenta = value;}
		}

		public bool AplicaSobrePrecioDeVentaNeto
		{
			get{return _aplicaSobrePrecioDeVentaNeto;}
			set{_aplicaSobrePrecioDeVentaNeto = value;}
		}

		public bool AplicaSobrePrecioDeVentaBruto
		{
			get{return _aplicaSobrePrecioDeVentaBruto;}
			set{_aplicaSobrePrecioDeVentaBruto = value;}
		}

		public bool AplicaSobrePrecioDeVentaBrutoConImpuestos
		{
			get{return _aplicaSobrePrecioDeVentaBrutoConImpuestos;}
			set{_aplicaSobrePrecioDeVentaBrutoConImpuestos = value;}
		}
		
		
		public bool AplicaValorConstante
		{
			get{return _aplicaValorConstante;}
			set{_aplicaValorConstante = value;}
		}

		public bool AplicaPorcentaje
		{
			get{return _aplicaPorcentaje;}
			set{_aplicaPorcentaje = value;}
		}
			
		public string IdFuenteDeCambioValorConstante
		{
			get{return _idFuenteDeCambioValorConstante;}
			set{_idFuenteDeCambioValorConstante = value;}
		}

		public string IdMonedaValorConstante
		{
			get{return _idMonedaValorConstante;}
			set{_idMonedaValorConstante = value;}
		}

		public decimal Porcentaje
		{
			get{ return _porcentaje;}
			set{_porcentaje = value;}
		}

		public decimal ValorConstante
		{
			get{return _valorConstante;}
			set{_valorConstante = value;}
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

		
/*		public decimal CostoIndirecto1
		{
			get
			{
				if(_producto != null)
				{

					return _producto.CostoIndirecto1;
				}
				return 0;
			}
		}
*/
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

/*		public decimal CostoIndirecto2
		{
			get
			{
				if(_producto != null)
				{

					return _producto.CostoIndirecto2;
				}
				return 0;
			}
		}

*/
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
					GenerateProducto(IdProd);
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
			}
		}

		

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
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
				}
				else
				{
					_producto = null;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
				
			}
		}


		public ArrayList Items
		{
			get{return _productos.ToArrayList();}
		}

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
				{
					return _producto.PrecioDeCostoReposicion;
				}
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
						/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
							_producto.PrecioLista = _producto.PrecioDeVentaNeto;
						*/
						//Fin Sabrina 20100719 - Tarea 796
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
				}
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
						/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
							_producto.PrecioLista = _producto.PrecioDeVentaNeto;
							*/
						//Fin Sabrina 20100719 - Tarea 796
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
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
						/*if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista) //Tarslada el nuevo precio de venta como precio de Lista
							_producto.PrecioLista = _producto.PrecioDeVentaNeto;
							*/
						//Fin Sabrina 20100719 - Tarea 796
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
				}
				
			}

		}

		public bool AplicaSobreCostoAfectaPCRTodos
		{
			get{return _aplicaSobreCostoAfectaPCRTodos;}
			set{_aplicaSobreCostoAfectaPCRTodos = value;}
		}

		public bool AplicaSobreCostoAfectaPCRTodosUsaPcioCtoReposicion
		{
			get{return _aplicaSobreCostoAfectaPCRTodosUsaPcioCtoReposicion;}
			set{_aplicaSobreCostoAfectaPCRTodosUsaPcioCtoReposicion = value;}
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
				}
			}
		}



		#region Propiedades públicas
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


		
		#endregion



		

		



			
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

		public void ListenerTaskDependentChanged(object sender)
		{
			
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
			
		}

		
	

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}

		public void Init()
		{
			_tableMonedas = mz.erp.businessrules.tfi_Monedas.GetList().tfi_Monedas;
			_tableFuentesDeCambio = mz.erp.businessrules.tfi_FuentesDeCambio.GetList().tfi_FuentesDeCambio;
			_idMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");
			_idMonedaValorConstante = _idMonedaReferencia;
			_simboloMonedaReferencia = ((tfi_MonedasDataset.tfi_MonedasDataTable)_tableMonedas).FindByIdMoneda(_idMonedaReferencia).Simbolo;
			_idFuenteDeCambioReferencia = Variables.GetValueString("Contabilidad.FuenteDeCambioReferencia");
			_idFuenteDeCambioValorConstante = Variables.GetValueString("Contabilidad.FuenteDeCambioReferencia");
			_productos = new ProductosCollection();
			_productosDeshacer = new ArrayList();
			this._dataProductos.DataSetName = "tsh_ProductosDataset";
			this._dataProductosSucursales.DataSetName = "tsh_ProductosSucursalesDataset";
			_habilitaListasDePrecios = Variables.GetValueBool("Productos.ListasDePrecios");
			/*German 20090325*/
			_calculaPPP = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName,"PrecioDeCosto.CalculaPPP","Productos.PrecioDeCosto.CalculaPPP", _calculaPPP);
			/*Fin German 20090325*/
			_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "ModificaPrecioDeCostoListaProveedorTrasladaPrecioDeVentaBruto","Productos.Precio.ModificaPrecioDeCostoListaProveedorTrasladaPrecioDeVentaBruto");
           
            //Sabrina: Tarea 863. 20101109
            //Cargo las listas de precios
            _listasDePrecios.Clear();
            DataTable listaDePreciosDT = tsh_ListasDePrecios.GetList().tsh_ListasDePrecios;
            foreach (System.Data.DataRow row in listaDePreciosDT.Rows)
            {
                string id = row["IdListaDePrecio"].ToString();
                string descripcion = row["Descripcion"].ToString();
                ListaDePreciosView lista = new ListaDePreciosView(id, descripcion);
                _listasDePrecios.Add(lista);
            }
            //Fin Sabrina: Tarea 863. 20101109
		}

		
		
		
		private void GenerateProducto(string IdProducto)
		{
			string IdVisualizacionDeStock = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "VisualizacionDeStock");
			/*German 20090325*/
			_producto = new Producto(IdProducto,IdVisualizacionDeStock, _calculaPPP, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
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
			bool isvalid = true;
			if(isvalid)
				isvalid =  ValidarMacError();
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


		private bool ValidarPrecios()
		{
			_productosInvalidos.Clear();
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
			return _productosInvalidos.Count == 0;

		}

		private bool ValidarMAC()
		{
			bool ok = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "ValidarMacNegativo.Error", "Productos.Precios.ValidarMacNegativo.Error");
			if(!ok)
			{
				ok = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "ValidarMacNegativo.Advertencia", "Productos.Precios.ValidarMacNegativo. Advertencia");
				_productosInvalidos.Clear();
				if(ok)
				{
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
				}
				return _productosInvalidos.Count != 0;
			}
			else
				return false;
		}


		public bool AllowShow()
		{
			return true;
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
					//ItemDatasetError error = new ItemDatasetError("Importe","Precio de Lista Invalido","Producto " + item.Descripcion + ". El precio de Lista no puede ser inferior al precio de venta neto");
					//_errores.Add( error );
					result = result + item.Codigo + ' ';
				}
				res = res + "Lo/s Producto/s " + result + " posee/n precio de Lista inferior al precio de venta neto.";
				//return "Lo/s Producto/s " + result + " posee/n precio de Lista inferior al precio de venta neto. Desea Continuar de todas formas??";
				//isvalid = false;			
			}
			if (this.ValidarMAC())
			{
				ok = true;
				string result = string.Empty;
				foreach(ItemError item in _productosInvalidos)
				{
					result = result + item.Codigo + ' ';
				}
				res = res + " Lo/s Producto/s " + result + " posee/n Margen/Precio Costo Neto inferior a 0.";
			}
		    if(ok)
			{
				res = res + " Desea Continuar de todas formas??";
				return res;
			}
			else
			{
				return "Está seguro que desea guardar los cambios realizados en los precios de los productos??";
			}
			
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
			return data;
		}

		public void Commit()
		{
			/*Ver para q procesos el commit se hace de esta manera.
			 * Tener en cuenta q s el producto se esta creando y esta tarea participa con otra tarea de la
			 * creacion de dicho producto, no se va hacer un update sino un insert
			 * 
			 * */

			DateTime fecha = DateTime.Now;
			Console.WriteLine("Antes Commit" + DateTime.Now);
			
			if(_porProducto)
			{
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
					/*
					row = mz.erp.businessrules.tsh_ProductosSucursales.GetByPk(prod.IdProducto, prod.IdSucursal, prod.IdEmpresa);
					this._dataProductosSucursales.Tables[0].ImportRow(row);
					DataRow rowProdSuc = ((tsh_ProductosSucursalesDataset)this._dataProductosSucursales).tsh_ProductosSucursales.FindByIdProductoIdSucursalIdEmpresa(prod.IdProducto, prod.IdSucursal, prod.IdEmpresa);
					rowProdSuc["PrecioFinalEstimado"] = prod.PrecioDeVentaConImpuestos;
					*/
					if(_habilitaListasDePrecios)//Depende de la variable Productos.ListasDePrecios
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
					// Commit de Porcentajes en tsh_ProductosAuxiliares
					CommitProductosAuxiliaresCoeficientes(prod);
				
					// Commit de Costos Indirectos.				
					prod.CoeficientesIndirectos.Commit();
					_dataProductosCoeficientesAplicados = prod.CoeficientesIndirectos.DataPca;

				}
			}
			else
			{
				foreach(Producto prod in this._productos)
				{
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
					
					if(_habilitaListasDePrecios)//Depende de la variable Productos.ListasDePrecios
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
						prod.ListaDePrecios.CommitWithCachedRow(item);
					}
					// Commit de Porcentajes en tsh_ProductosAuxiliares
					CommitProductosAuxiliaresCoeficientes(prod);
				
					// Commit de Costos Indirectos.				
					prod.CoeficientesIndirectos.Commit();
					_dataProductosCoeficientesAplicados = prod.CoeficientesIndirectos.DataPca;
				}

			}
			TimeSpan  diff = DateTime.Now.Subtract(fecha);
			Console.WriteLine("Despues Commit" + diff.TotalSeconds + " " + DateTime.Now);



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
			DateTime fecha = DateTime.Now;
			Console.WriteLine("Antes Flush" + DateTime.Now);
			
			DateTime fecha1 = DateTime.Now;
			Console.WriteLine("Antes tsh_Productos.Update" + DateTime.Now);
			mz.erp.dataaccess.tsh_Productos.Update(this._dataProductos, IdTransaction, _replicacion);
			TimeSpan  diff1 = DateTime.Now.Subtract(fecha1);
			Console.WriteLine("Despues tsh_Productos.Update" + diff1.TotalSeconds + " " + DateTime.Now);
			DateTime fecha2 = DateTime.Now;
			Console.WriteLine("Antes prod.ListaDePrecios.Flush" + DateTime.Now);
			foreach(Producto prod in this._productos)
			{
				if(_porProducto)
				{
					/*Dado que si es por jerarquia esta tabla se carga antes*/
					DataRow row = mz.erp.businessrules.tsh_ProductosSucursales.GetByPk(IdTransaction, prod.IdProducto, prod.IdSucursal, prod.IdEmpresa);
					this._dataProductosSucursales.Tables[0].ImportRow(row);
				}
				DataRow rowProdSuc = ((tsh_ProductosSucursalesDataset)this._dataProductosSucursales).tsh_ProductosSucursales.FindByIdProductoIdSucursalIdEmpresa(prod.IdProducto, prod.IdSucursal, prod.IdEmpresa);
				rowProdSuc["PrecioFinalEstimado"] = prod.PrecioDeListaConImpuestos;
				prod.ListaDePrecios.Flush(IdTransaction);
				prod.CoeficientesIndirectos.Flush(IdTransaction);
                //Sabrina: Tarea 1068. 20110317
                if (ActualizaPreciosProductosCombo)
                    tsh_CombosDet.ActualizarPreciosProductosCombo(IdTransaction, prod.IdProducto, prod.PrecioDeCosto, prod.PrecioLista, prod.IdMonedaPrecioDeCosto, prod.IdMonedaPrecioDeVentaNeto, prod.IdCotizacionMonedaPrecioDeCosto, prod.IdCotizacionMonedaPrecioDeVentaNeto);
                //Fin Sabrina: Tarea 1068. 20110317			
			}
			TimeSpan  diff2 = DateTime.Now.Subtract(fecha2);
			Console.WriteLine("Despues prod.ListaDePrecios" + diff2.TotalSeconds + " " + DateTime.Now);
			DateTime fecha3 = DateTime.Now;
			Console.WriteLine("Antes tsh_ProductosSucursales.Update" + DateTime.Now);
			mz.erp.dataaccess.tsh_ProductosSucursales.Update(this._dataProductosSucursales, IdTransaction, _replicacion);
			TimeSpan  diff3 = DateTime.Now.Subtract(fecha3);
			Console.WriteLine("Despues tsh_ProductosSucursales.Update" + diff3.TotalSeconds + " " + DateTime.Now);
			TimeSpan  diff = DateTime.Now.Subtract(fecha);
			Console.WriteLine("Despues Flush" + diff.TotalSeconds + " " + DateTime.Now);
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

		//------------------------------ Activa o Desactiva un costo indirecto
		public void ActivarCostoIndirecto(long idCosto, bool valor)
		{        
			_producto.ActivarCostoIndirecto(idCosto, valor);
			
			switch(idCosto)
			{
				case 1: 
				{
					/*
					if(CostoIndirecto1Changed != null)
						CostoIndirecto1Changed(this, new EventArgs());
					if(CostoIndirectoPorc1Changed != null)
						CostoIndirectoPorc1Changed(this, new EventArgs());
					*/
					if(CostoIndirecto1ActivatedChanged != null)
						CostoIndirecto1ActivatedChanged(this, new EventArgs());
					break;
				}
				case 2: 
				{
					/*
					if(CostoIndirecto2Changed != null)
						CostoIndirecto2Changed(this, new EventArgs());
					if(CostoIndirectoPorc2Changed != null)
						CostoIndirectoPorc2Changed(this, new EventArgs());
					*/
					if(CostoIndirecto2ActivatedChanged != null)
						CostoIndirecto2ActivatedChanged(this, new EventArgs());
					break;
				}
				case 3: 
				{
					/*
					if(CostoIndirecto3Changed != null)
						CostoIndirecto3Changed(this, new EventArgs());
					if(CostoIndirectoPorc3Changed != null)
						CostoIndirectoPorc3Changed(this, new EventArgs());
						*/
					if(CostoIndirecto3ActivatedChanged != null)
						CostoIndirecto3ActivatedChanged(this, new EventArgs());
					break;
				}
				case 4: 
				{
					/*
					if(CostoIndirecto4Changed != null)
						CostoIndirecto4Changed(this, new EventArgs());
					if(CostoIndirectoPorc4Changed != null)
						CostoIndirectoPorc4Changed(this, new EventArgs());
						*/
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
			}
				
			
		}


		public void DeleteSelectedItem()
		{
			if(this._producto != null)
			{
				this._productos.Remove(this._producto);
				_producto = null;
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
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
				this._productos.Add(prod);
                //Sabrina: Tarea 834. 20101004
                //_idListaDePrecioSeleccionada = item.IdListaDePrecios;
                //Fin Sabrina: Tarea 834. 20101004
			}
			if(ProductosCollectionChanged != null)
				ProductosCollectionChanged(this, new EventArgs());
		
		}

		public void DeshacerActualizacion()
		{
			if(_productosDeshacer.Count > 0)
			{
				_productos = (ProductosCollection)_productosDeshacer[_productosDeshacer.Count - 1];
				_productosDeshacer.Remove(_productos);
			}
			if(ProductosCollectionBackChanged != null)
				ProductosCollectionBackChanged(this, new EventArgs());
			/*
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
			if(ProductosCollectionChanged != null)
				ProductosCollectionChanged(this, new EventArgs());
			*/
			
		}


		public string ActualizarPrecios()
		{
			string advertencia = string.Empty;

			if(_porProducto)
			{
				if(_productos.Count > 0)
				{
				
					if(!IsValidCotizacion())
					{
						_error = true;
						_errorMessage = "No existe Cotización para la Moneda y Fuente de Cambio Seleccionada";
					}
					if(_error)
					{
						if(ErrorOcurred != null)
							ErrorOcurred(this, new EventArgs());
						return string.Empty ;
					}
					else
					{
						ProductosCollection aux = new ProductosCollection();
						foreach(Producto p in _productos)
						{
							Producto clone = p.ShallowClone();
							aux.Add(clone);
						}
						_productosDeshacer.Add(aux);
						foreach(Producto prod in _productos)
						{
							prod.PrecioDeVentaAfectaMac = _precioDeVentaAfectaMac;
							advertencia = this.ArmarAdvertencia(advertencia, prod);
							ActualizarPrecioProducto(prod);
						}


					}
					if(ProductosCollectionChanged != null)
						ProductosCollectionChanged(this, new EventArgs());
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
			}
			else
			{
				if(!IsValidCotizacion())
				{
					_error = true;
					_errorMessage = "No existe Cotización para la Moneda y Fuente de Cambio Seleccionada";
				}
				if(_error)
				{
					if(ErrorOcurred != null)
						ErrorOcurred(this, new EventArgs());
					return string.Empty ;
				}
				else
				{
					string j1 = BuildJerarquia(_jerarquias1);
					string j2 = BuildJerarquia(_jerarquias2);
					string j3 = BuildJerarquia(_jerarquias3);
					string j4 = BuildJerarquia(_jerarquias4);
					string j5 = BuildJerarquia(_jerarquias5);
					string j6 = BuildJerarquia(_jerarquias6);
					string j7 = BuildJerarquia(_jerarquias7);
					string j8 = BuildJerarquia(_jerarquias8);

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
					string IdVisualizacionDeStock = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "VisualizacionDeStock");
					DateTime fecha = DateTime.Now;
					Console.WriteLine("Antes Buscar" + DateTime.Now);
					tsh_ProductosDataset data = mz.erp.businessrules.tsh_ProductosEx.SearchProductByJerarquiaAux(j1,j2,j3,j4,j5,j6,j7,j8, Security.IdEmpresa, Security.IdSucursal);			
					_dataProductos = data;
					_dataProductosSucursales = mz.erp.businessrules.tsh_ProductosSucursales.GetList();
					/*
					DataSet dataPLP = mz.erp.businessrules.tsh_ProductosListasDePrecios.GetList();
					DataSet dataPLPA = mz.erp.businessrules.tsh_ProductosListasDePreciosAplicadas.GetList();
					DataTable tablePLP = dataPLP.Tables[0];
					DataTable tablePLPA = dataPLPA.Tables[0];
					*/
					TimeSpan  diff = DateTime.Now.Subtract(fecha);
					Console.WriteLine("Despues Buscar" + diff.TotalSeconds + " " + DateTime.Now);
					this._productos.Clear();
					DateTime fecha1 = DateTime.Now;
					Console.WriteLine("Antes Crear Productos" + DateTime.Now);
					foreach(DataRow row in _dataProductos.Tables[0].Rows)
					{
						//Producto prod = new Producto(Convert.ToString(row["IdProducto"]), IdVisualizacionDeStock);
						Producto prod = new Producto(true, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
						fecha = DateTime.Now;
						Console.WriteLine("Antes de cargar Datos Principales" + DateTime.Now);
						prod.CargarDatosPrincipales(row);
						TimeSpan diff3 = DateTime.Now.Subtract(fecha);
						Console.WriteLine("Despues de cargar Datos Principales" + diff3.TotalSeconds + " " + DateTime.Now);
						fecha = DateTime.Now;
						//prod.CargarListasDePrecios(tablePLP, tablePLPA);
						//Sabrina 20100615 - Tarea 764
						prod.CargarListasDePrecios("EDIT");
						//Fin Sabrina 20100615 - Tarea 764
						TimeSpan diff4 = DateTime.Now.Subtract(fecha);
						Console.WriteLine("Despues de cargar Datos Principales" + diff4.TotalSeconds + " " + DateTime.Now);
						this._productos.Add(prod);
						prod.PrecioDeVentaAfectaMac = _precioDeVentaAfectaMac;
						advertencia = this.ArmarAdvertencia(advertencia, prod);
						ActualizarPrecioProducto(prod);
					}
					TimeSpan diff2 = DateTime.Now.Subtract(fecha1);
					Console.WriteLine("Despues Crear Productos" + diff2.TotalSeconds + " " + DateTime.Now);
					Console.WriteLine("Fin");
				}
			
			}
			return advertencia;
		}

		private string ArmarAdvertencia(string Advertencia, Producto prod)
		{
			//Advertenia para cuando se intenta modificar el precio de venta sugerido y el precio de costo es 0
			if(_aplicaSobrePrecioDeVenta && _aplicaSobrePrecioDeVentaNeto && prod.PrecioDeCosto == 0)
			{
				if(Advertencia.Equals(string.Empty))
					Advertencia = "El precio de venta sugerido de el/los siguiente/s producto/s no ha sido modificado pues su precio de costo es 0: ";
				else
					Advertencia = Advertencia + ", ";
                Advertencia = Advertencia + prod.Codigo;
			}
			if(_aplicaSobreMAC && prod.PrecioLista == 0)
			{
				if(Advertencia.Equals(string.Empty))
					Advertencia = "El MAC de el/los siguiente/s producto/s no ha sido modificado pues su precio de lista es 0: ";
				else
					Advertencia = Advertencia + ", ";
				Advertencia = Advertencia + prod.Codigo;
			}
			return Advertencia;
		}

		private bool IsValidCotizacion()
		{
			_cotizacion = new CotizacionWrapper(this._idMonedaValorConstante, this._idMonedaReferencia, this._idFuenteDeCambioValorConstante);
			return _cotizacion.IsValid;
		}
 
		//Sabrina Tarea 75		
		private void ActualizarPrecioProducto(Producto producto)
		{
			if(_aplicaSobrePrecioDeCosto)
			{
				if(producto.UsaPrecioDeCostoReposicion || _aplicaSobreCostoAfectaPCRTodos)
				{
					if(!producto.UsaPrecioDeCostoReposicion)
						producto.UsaPrecioDeCostoReposicion = true;
					decimal valorConstanteEnMonedaReferencia = _valorConstante * _cotizacion.Valor;
					CotizacionWrapper cot = new CotizacionWrapper(_idMonedaReferencia,producto.IdMonedaPrecioDeCosto, producto.IdFuenteDeCambioProductoPrecioDeCosto);
					if(cot.IsValid)
					{
						_valorConstanteCotizado = valorConstanteEnMonedaReferencia * cot.Valor;
						decimal nuevoPrecioDeCostoDirecto = Calcular(producto.PrecioDeCostoDirecto);
						producto.RecalcularAplicaSobrePrecioDeCosto(nuevoPrecioDeCostoDirecto, _aplicaSobrePrecioDeCostoAfecta);
                        //Sabrina: Tarea 834. 20101004
                        producto.ListaDePrecios.UpdatePrecios(producto.PrecioDeCosto, producto.MAC, producto.PrecioDeVentaNeto, producto.PrecioLista, _aplicaSobrePrecioDeCostoAfecta);
                        producto.CalcularPreciosAfectados(_aplicaSobrePrecioDeCostoAfecta);
                        //German 20101214 - Tarea 989
                        //ListaDePreciosItem itemDefault = _producto.ListaDePrecios.GetDefaultItem();
                        ListaDePreciosItem itemDefault = producto.ListaDePrecios.GetDefaultItem();
                        //Fin German 20101214  - Tarea 989
                        producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
                        //Fin Sabrina: Tarea 834. 20101004
					}
                    //Sabrina: Tarea 834. 20101004
                    //producto.CalcularPreciosAfectados(_aplicaSobrePrecioDeCostoAfecta);
                    //Fin Sabrina: Tarea 834. 20101004
				}
			}
			if(_aplicaSobrePrecioDeVenta)
			{
				if(_aplicaSobrePrecioDeVentaNeto)
				{
					if(producto.PrecioDeCosto != 0)
					{
						decimal valorConstanteEnMonedaReferencia = _valorConstante * _cotizacion.Valor;
						CotizacionWrapper cot = new CotizacionWrapper(_idMonedaReferencia,producto.IdMonedaPrecioDeVentaNeto, producto.IdFuenteDeCambioProductoPrecioDeVenta);
						decimal PVN = 0;
						if(cot.IsValid)
						{
							_valorConstanteCotizado = valorConstanteEnMonedaReferencia * cot.Valor;
							PVN = Calcular(producto.PrecioDeVentaNeto);
						}
						cot = new CotizacionWrapper(producto.IdMonedaPrecioDeVentaNeto, _idMonedaReferencia, producto.IdFuenteDeCambioProductoPrecioDeVenta);
						if(cot.IsValid)
						{
							decimal PVentaMonedaReferencia =  PVN * cot.Valor;
							cot = new CotizacionWrapper(_idMonedaReferencia, producto.IdMonedaPrecioDeCosto, producto.IdFuenteDeCambioProductoPrecioDeCosto);
							if(cot.IsValid)
							{
								decimal PVentaMonedaPrecioCosto = PVentaMonedaReferencia * cot.Valor;
								if(PVentaMonedaPrecioCosto != 0)
								{
									decimal nuevoMac = (PVentaMonedaPrecioCosto - producto.PrecioDeCosto) * 100 /producto.PrecioDeCosto;
									producto.RecalcularAplicaSobrePrecioDeVentaNeto(nuevoMac, _aplicaSobrePrecioDeVentaAfecta);
                                    //Sabrina: Tarea 863. 20101109
                                    producto.ListaDePrecios.UpdatePrecios(producto.PrecioDeCosto, producto.MAC, producto.PrecioDeVentaNeto, producto.PrecioLista, _aplicaSobrePrecioDeVentaAfecta);
                                    producto.CalcularPreciosAfectados(_aplicaSobrePrecioDeVentaAfecta);
                                    //German 20101214 - Tarea 989
                                    //ListaDePreciosItem itemDefault = _producto.ListaDePrecios.GetDefaultItem();
                                    ListaDePreciosItem itemDefault = producto.ListaDePrecios.GetDefaultItem();
                                    //Fin German 20101214  - Tarea 989
                                    producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
                                    //Fin Sabrina: Tarea 863. 20101109
								}

				
							}
						}
						//Sabrina: Tarea 863. 20101109
						//producto.CalcularPreciosAfectados(_aplicaSobrePrecioDeVentaAfecta);
						//Fin Sabrina: Tarea 863. 20101109
                    }
				}
				else
				{
					if(_aplicaSobrePrecioDeVentaBruto)
					{
						decimal valorConstanteEnMonedaReferencia = _valorConstante * _cotizacion.Valor;
						CotizacionWrapper cot = new CotizacionWrapper(_idMonedaReferencia,producto.IdMonedaPrecioDeVentaNeto, producto.IdFuenteDeCambioProductoPrecioDeVenta);
						if(cot.IsValid)
						{
							_valorConstanteCotizado = valorConstanteEnMonedaReferencia * cot.Valor;
                            //Sabrina: Tarea 863. 20101109
                            /*decimal nuevoPrecioDeLista = Calcular(producto.PrecioLista);
                            producto.RecalcularAplicaSobrePrecioDeVentaBruto(nuevoPrecioDeLista);*/
                            if (HabilitaListasDePrecios)
                            {
                                foreach (ListaDePreciosItem item in producto.ListaDePrecios.Items)
                                {
                                    if (_listasDePreciosSeleccionadas.Contains(new ListaDePreciosView(item.IdListaDePrecios, item.Descripcion)))
                                    {
                                        decimal nuevoPrecioDeListaItem = Calcular(item.PrecioDeVentaBruto);
                                        decimal coeficienteNew = item.GetCoeficienteFromPrecioVentaBruto(nuevoPrecioDeListaItem);
                                        producto.ListaDePrecios.UpdateCoeficiente(item, coeficienteNew);
                                        if (item.IsDefault)
                                            producto.RecalcularAplicaSobrePrecioDeVentaBruto(nuevoPrecioDeListaItem);

                                    }
                                }

                            }
                            else
                            {
                                decimal nuevoPrecioDeLista = Calcular(producto.PrecioLista);
                                producto.RecalcularAplicaSobrePrecioDeVentaBruto(nuevoPrecioDeLista);
                            }
                            //Fin Sabrina: Tarea 863. 20101109
						}
					}
					else
					{
						if(_aplicaSobrePrecioDeVentaBrutoConImpuestos)
						{
							decimal valorConstanteEnMonedaReferencia = _valorConstante * _cotizacion.Valor;
							CotizacionWrapper cot = new CotizacionWrapper(_idMonedaReferencia,producto.IdMonedaPrecioDeVentaNeto, producto.IdFuenteDeCambioProductoPrecioDeVenta);
							if(cot.IsValid)
							{
								_valorConstanteCotizado = valorConstanteEnMonedaReferencia * cot.Valor;
								//Sabrina: Tarea 863. 20101109
								/*decimal nuevoPrecioDeListaConImpuestos = Calcular(producto.PrecioDeListaConImpuestos);
								producto.RecalcularAplicaSobrePrecioDeVentaBrutoConImpuestos(nuevoPrecioDeListaConImpuestos);*/
								if(HabilitaListasDePrecios)
								{
									foreach(ListaDePreciosItem item in producto.ListaDePrecios.Items)
									{
										if(_listasDePreciosSeleccionadas.Contains(new ListaDePreciosView(item.IdListaDePrecios, item.Descripcion)))
										{
											decimal nuevoPrecioDeListaConImpuestosItem = Calcular(item.PrecioDeVentaBrutoConImpuestos);
											decimal coeficienteNew = item.GetCoeficienteFromPrecioVentaBrutoConImp(nuevoPrecioDeListaConImpuestosItem);
											producto.ListaDePrecios.UpdateCoeficiente(item, coeficienteNew);
											if(item.IsDefault)
												producto.RecalcularAplicaSobrePrecioDeVentaBrutoConImpuestos(nuevoPrecioDeListaConImpuestosItem);

										}
									}

								}
								else
								{
									decimal nuevoPrecioDeListaConImpuestos = Calcular(producto.PrecioDeListaConImpuestos);
									producto.RecalcularAplicaSobrePrecioDeVentaBrutoConImpuestos(nuevoPrecioDeListaConImpuestos);
								}
								//Fin Sabrina: Tarea 863. 20101109
                            }
						}
					}
				}
			}
			if(_aplicaSobreMAC)
			{
				if(producto.PrecioLista != 0)
				{
					producto.RecalcularAplicaSobrePrecioDeVentaNeto(_porcentaje, _aplicaSobreMACAfecta);
					//Sabrina: Tarea 863. 20101109
					//producto.CalcularPreciosAfectados(_aplicaSobreMACAfecta);
					producto.ListaDePrecios.UpdatePrecios(producto.PrecioDeCosto, producto.MAC, producto.PrecioDeVentaNeto, producto.PrecioLista, _aplicaSobreMACAfecta);
					producto.CalcularPreciosAfectados(_aplicaSobreMACAfecta);
                    //German 20101214 - Tarea 989
                    //ListaDePreciosItem itemDefault = _producto.ListaDePrecios.GetDefaultItem();
                    ListaDePreciosItem itemDefault = producto.ListaDePrecios.GetDefaultItem();
                    //Fin German 20101214  - Tarea 989
					producto.PrecioLista = itemDefault.PrecioDeVentaBruto;
					//Fin Sabrina: Tarea 863. 20101109
                }
			}			
			if(_aplicaSobreMaximoDescuentoPorcentual)
			{
				producto.RecalcularAplicaSobreMaximoDescuentoPorcentual(AplicaSobreMaximoDescuentoPorcentualAfecta, _porcentaje);
			}
		}
		
		
		/* Sabrina Tarea 75
		 * private decimal _precioDeVentaNetoAnterior = 0;
		 * private void ActualizarPrecioProducto(Producto producto)
		{
			if(_aplicaSobrePrecioDeCosto)
			{
				if(producto.UsaPrecioDeCostoReposicion || _aplicaSobreCostoAfectaPCRTodos)
				{
					if(!producto.UsaPrecioDeCostoReposicion)
						producto.UsaPrecioDeCostoReposicion = true;
					decimal valorConstanteEnMonedaReferencia = _valorConstante * _cotizacion.Valor;
					CotizacionWrapper cot = new CotizacionWrapper(_idMonedaReferencia,producto.IdMonedaPrecioDeCosto, producto.IdFuenteDeCambioProductoPrecioDeCosto);
					if(cot.IsValid)
					{
						_valorConstanteCotizado = valorConstanteEnMonedaReferencia * cot.Valor;
						_precioDeVentaNetoAnterior  = producto.PrecioDeVentaNeto;
						producto.PrecioDeCostoDirecto = Calcular(producto.PrecioDeCostoDirecto);
						producto.PrecioDeCostoReposicion = producto.PrecioDeCostoDirecto;
					}
					CalcularPreciosAfectados(producto, _aplicaSobrePrecioDeCostoAfecta);
				}
			}
			if(_aplicaSobrePrecioDeVenta)
			{
				if(_aplicaSobrePrecioDeVentaNeto)
				{
					decimal valorConstanteEnMonedaReferencia = _valorConstante * _cotizacion.Valor;
					CotizacionWrapper cot = new CotizacionWrapper(_idMonedaReferencia,producto.IdMonedaPrecioDeVentaNeto, producto.IdFuenteDeCambioProductoPrecioDeVenta);
					decimal PVN = 0;
					if(cot.IsValid)
					{
						_valorConstanteCotizado = valorConstanteEnMonedaReferencia * cot.Valor;
						PVN = Calcular(producto.PrecioDeVentaNeto);
					}
					cot = new CotizacionWrapper(producto.IdMonedaPrecioDeVentaNeto, _idMonedaReferencia, producto.IdFuenteDeCambioProductoPrecioDeVenta);
					if(cot.IsValid)
					{
						decimal PVentaMonedaReferencia =  PVN * cot.Valor;
						cot = new CotizacionWrapper(_idMonedaReferencia, producto.IdMonedaPrecioDeCosto, producto.IdFuenteDeCambioProductoPrecioDeCosto);
						if(cot.IsValid)
						{
							decimal PVentaMonedaPrecioCosto = PVentaMonedaReferencia * cot.Valor;
							if(PVentaMonedaPrecioCosto != 0)
							{
								_precioDeVentaNetoAnterior  = producto.PrecioDeVentaNeto;
								producto.MAC = (PVentaMonedaPrecioCosto - producto.PrecioDeCosto) * 100 /producto.PrecioDeCosto;
							}

				
						}
					}
					CalcularPreciosAfectados(producto, _aplicaSobrePrecioDeVentaAfecta);
				}
				else
				{
					if(_aplicaSobrePrecioDeVentaBruto)
					{
						decimal valorConstanteEnMonedaReferencia = _valorConstante * _cotizacion.Valor;
						CotizacionWrapper cot = new CotizacionWrapper(_idMonedaReferencia,producto.IdMonedaPrecioDeVentaNeto, producto.IdFuenteDeCambioProductoPrecioDeVenta);
						if(cot.IsValid)
						{
							_valorConstanteCotizado = valorConstanteEnMonedaReferencia * cot.Valor;
							producto.PrecioLista = Calcular(producto.PrecioLista);
						}
					}
					else
					{
						if(_aplicaSobrePrecioDeVentaBrutoConImpuestos)
						{
							decimal valorConstanteEnMonedaReferencia = _valorConstante * _cotizacion.Valor;
							CotizacionWrapper cot = new CotizacionWrapper(_idMonedaReferencia,producto.IdMonedaPrecioDeVentaNeto, producto.IdFuenteDeCambioProductoPrecioDeVenta);
							if(cot.IsValid)
							{
								_valorConstanteCotizado = valorConstanteEnMonedaReferencia * cot.Valor;
								producto.PrecioDeListaConImpuestos = Calcular(producto.PrecioDeListaConImpuestos);
							}
						}
					}
				}
			}
			if(_aplicaSobreMAC)
			{
				_precioDeVentaNetoAnterior  = producto.PrecioDeVentaNeto;
				producto.MAC = _porcentaje;
				//TODO este metodo de aca abajo es el q esta mal definido charlar con ger como deberia ser
				CalcularPreciosAfectados(producto, _aplicaSobreMACAfecta);
			}
			if(_aplicaSobreMaximoDescuentoPorcentual)
			{
				if(AplicaSobreMaximoDescuentoPorcentualAfecta.Equals(ModificarPreciosMasivo.Afecta.MAC) && _precioDeVentaAfectaMac)
				{
					_producto.MAC = _porcentaje;
				}
				else if(AplicaSobreMaximoDescuentoPorcentualAfecta.Equals(ModificarPreciosMasivo.Afecta.PrecioDeLista) && !_precioDeVentaAfectaMac)
				{
					producto.PrecioLista =  producto.PrecioDeVentaNeto /(1- (_porcentaje/100));
				}
				//if(_precioDeVentaAfectaMac)
				//{
					/*
					decimal precioSugerido = producto.PrecioLista - (producto.PrecioLista * _porcentaje /100);
					decimal PCostoMonReferencia = producto.PrecioDeCosto * producto.ValorCotizacionPrecioDeCosto;
					decimal difPCostoPSugerido = (precioSugerido*producto.ValorCotizacionPrecioDeVenta)  - PCostoMonReferencia;
					decimal nuevoMAC = 0;
					if(PCostoMonReferencia > 0)
						nuevoMAC = difPCostoPSugerido * 100 / PCostoMonReferencia;
					else
						nuevoMAC = producto.MAC;
					producto.MAC = nuevoMAC;
					*/
					/*producto.PorcentajeMaximoDescuento = _porcentaje;
				}
				else
				{
					producto.PrecioLista =  producto.PrecioDeVentaNeto - (producto.PrecioLista * _porcentaje /100);
				 
				}*/

				
			/*}
		}

		private void CalcularPreciosAfectados(Producto producto, Afecta af)
		{
			switch(af)
			{
				case Afecta.PrecioDeLista:
				{
					//CalcularPrecioDeLista(producto);
				}
				break;
				case Afecta.PrecioDeListaIgualPrecioDeVentaSugerido:
				{
					producto.PrecioLista = producto.PrecioDeVentaNeto;
				}
					break;
				case Afecta.PrecioDeListaIgualPrecioDeVentaSugeridoSIPrecioDeListaMenorPrecioVentaSugerido:
				{
					if(producto.PrecioLista < producto.PrecioDeVentaNeto)
						producto.PrecioLista = producto.PrecioDeVentaNeto;
				}
					break;
				case Afecta.PrecioDeListaSIPrecioDeListaMenorPrecioVentaSugerido:
				{	
					if(producto.PrecioLista < producto.PrecioDeVentaNeto)
						CalcularPrecioDeLista(producto);
				}
					break;
				default : break;
			}
			
		}

		private void CalcularPrecioDeLista(Producto producto)
		{
			if(_precioDeVentaNetoAnterior != 0)
			{
				decimal PLista = producto.PrecioLista;
				decimal dif = PLista - _precioDeVentaNetoAnterior;
				decimal coef = (dif *100 / _precioDeVentaNetoAnterior);
				producto.PrecioLista = producto.PrecioDeVentaNeto + producto.PrecioDeVentaNeto * coef/100;
			}
			
		}
		*/

		private decimal Calcular(decimal valor)
		{
			if(_aplicaPorcentaje && _aplicaValorConstante)
			{
				valor =  AplicarPorcentaje(valor);
				return AplicarValorConstante(valor);
			}
			if(_aplicaPorcentaje && !_aplicaValorConstante)
				return AplicarPorcentaje(valor);
			if(_aplicaValorConstante && !_aplicaPorcentaje)
				return AplicarValorConstante(valor);
			return valor;
		}


		private decimal AplicarValorConstante(decimal valor)
		{
			return valor + _valorConstanteCotizado;
		}

		private decimal AplicarPorcentaje(decimal valor)
		{
			return valor + valor * _porcentaje /100;
		}


		
		#endregion

		#region Codigo Nuevo

		private ArrayList _jerarquias1 = new ArrayList();
		private ArrayList _jerarquias2 = new ArrayList();
		private ArrayList _jerarquias3 = new ArrayList();
		private ArrayList _jerarquias4 = new ArrayList();
		private ArrayList _jerarquias5 = new ArrayList();
		private ArrayList _jerarquias6 = new ArrayList();
		private ArrayList _jerarquias7 = new ArrayList();
		private ArrayList _jerarquias8 = new ArrayList();

		private bool _byJerarquia1 = false;
		private bool _byJerarquia2 = false;
		private bool _byJerarquia3 = false;
		private bool _byJerarquia4 = false;
		private bool _byJerarquia5 = false;
		private bool _byJerarquia6 = false;
		private bool _byJerarquia7 = false;
		private bool _byJerarquia8 = false;

		private bool _porProducto = true;
	

		public ArrayList  Jerarquias1
		{
			get{return _jerarquias1;}
			set{_jerarquias1 = value;}
		}
		public ArrayList  Jerarquias2
		{
			get{return _jerarquias2;}
			set{_jerarquias2 = value;}
		}

		public ArrayList  Jerarquias3
		{
			get{return _jerarquias3;}
			set{_jerarquias3 = value;}
		}

		public ArrayList  Jerarquias4
		{
			get{return _jerarquias4;}
			set{_jerarquias4 = value;}
		}

		public ArrayList  Jerarquias5
		{
			get{return _jerarquias5;}
			set{_jerarquias5 = value;}
		}

		public ArrayList  Jerarquias6
		{
			get{return _jerarquias6;}
			set{_jerarquias6 = value;}
		}

		public ArrayList  Jerarquias7
		{
			get{return _jerarquias7;}
			set{_jerarquias7 = value;}
		}

		public ArrayList  Jerarquias8
		{
			get{return _jerarquias8;}
			set{_jerarquias8 = value;}
		}

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

		public bool PorProducto
		{
			set{_porProducto = value;}

		}

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

		public bool HabilitaListasDePrecios
		{
			get{return _habilitaListasDePrecios;}
		}
        		//Sabrina: Tarea 863. 20101109
		ArrayList _listasDePrecios = new ArrayList();
		public ArrayList ListasDePrecios
		{
			get 
			{
				return _listasDePrecios;
			}
		}

		ArrayList _listasDePreciosSeleccionadas = new ArrayList();
		public ArrayList ListasDePreciosSeleccionadas
		{
			set 
			{
				_listasDePreciosSeleccionadas = value;
			}
		}
		//Fin Sabrina: Tarea 863. 20101109

        //Sabrina: Tarea 1068. 20110317
        private bool _actualizaPreciosProductosCombo = false;
        public bool ActualizaPreciosProductosCombo
        {
            get { return _actualizaPreciosProductosCombo; }
            set { _actualizaPreciosProductosCombo = value; }
        }
        //Fin Sabrina: Tarea 1068. 20110317

        #endregion

	}

	
	

}

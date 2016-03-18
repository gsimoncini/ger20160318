using System;
using System.Collections;
using mz.erp.businessrules;
using System.Data;
using mz.erp.commontypes;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de mzProductosControlController.
	/// </summary>
	public class mzProductosControlController: IObserver, IObservable // Matias 20081219
	{
		public mzProductosControlController()
		{

		}

		#region Eventos y Delegados
		public event EventHandler SingleSelectionProducto;
		public event EventHandler MultipleSelectionProducto;
		public event System.EventHandler IdListaDePrecios_SearchChanged;
		#endregion

		mz.erp.businessrules.comprobantes.Item _miItem;
		mz.erp.businessrules.Productos _miProducto;

		private bool _habilitaMultiplesCodigosSecundarios = false;

		public mz.erp.businessrules.comprobantes.Item Item
		{
			get
			{
				return _miItem;
			}
		}
		
		
		private string _codigo_search = string.Empty;
		public string Codigo_Search
		{
			get { return _codigo_search; }
			set 
			{ 
				_codigo_search = value ;
				//BuscarAhora();	
				 
			}
		}

		private string _codigoSec_search = string.Empty;
		public string CodigoSec_Search
		{
			get { return _codigoSec_search; }
			set 
			{ 
				_codigoSec_search = value ;
				//BuscarAhora();	
				 
			}
		}
		
		
		private string _codigoProveedor_search = string.Empty;
		public string CodigoProveedor_search
		{
			get { return _codigoProveedor_search; }
			set 
			{ 
				_codigoProveedor_search = value ;
				//BuscarAhora();	
				 
			}
		}
		

		private string _codigoSec = string.Empty;
		public string CodigoSec
		{
			get { return _codigoSec; }

		}

		private string _codigoProveedor = string.Empty;
		public string CodigoProveedor
		{
			get { return _codigoProveedor; }

		}

		private string _lastcode_search = string.Empty;
		public string Lastcode_search
		{
			get { return _lastcode_search; }
			set 
			{ 
				_lastcode_search = value ;								 
			}
		}

		private string _ordenDeBusqueda = string.Empty;
		private string[] _ordenDeBusquedaList = null;
		public string[] OrdenDeBusqueda
		{
			get{return _ordenDeBusquedaList;}
		}

		private string _idListaDePrecios_search = string.Empty;
		public string IdListaDePrecios_Search
		{
			get { return _idListaDePrecios_search; }
			set 
			{ 
				_idListaDePrecios_search = value ;
			}
		}

		private string _tipoDePrecioDeCosto_Search = string.Empty;
		public string TipoDePrecioDeCosto_Search
		{
			get { return _tipoDePrecioDeCosto_Search; }
			set 
			{ 
				_tipoDePrecioDeCosto_Search = value ;
			}
		}

        //Sabrina: Tarea 1080. 20110326
        private bool _permiteProductosCombo = false;
        public bool PermiteProductosCombo
        {
            get { return _permiteProductosCombo; }
            set { _permiteProductosCombo = value; }

        }
        //Fin Sabrina: Tarea 1080. 20110326

		public void SetOrdenBusqueda()
		{
			_ordenDeBusqueda = Variables.GetValueString(_processName, _taskName, "Productos.Busqueda.OrdenDeBusqueda");
			if(_ordenDeBusqueda == null || _ordenDeBusqueda.Equals(string.Empty))
				_ordenDeBusqueda = Variables.GetValueString("Productos.Busqueda.OrdenDeBusqueda");
			_ordenDeBusquedaList = _ordenDeBusqueda.Split(',');
		}

		public void BuscarAhora()
		{
			if (_idListaDePrecios_search == null)
				_idListaDePrecios_search = _idListaDePreciosDefault;
			if (_tipoDePrecioDeCosto_Search == null || _tipoDePrecioDeCosto_Search.Equals(string.Empty))
				_tipoDePrecioDeCosto_Search = _tipoDePrecioDeCostoDefault;
			if (_lastcode_search.CompareTo(_codigo_search) != 0 || _miProducto == null)
			{
				_selectedItems.Clear();
				if ((_codigo_search != null) && (_codigo_search.CompareTo(string.Empty) != 0))
				{

                    //Sabrina: Tarea 1080. 20110326
                    _miProducto = new mz.erp.businessrules.Productos( "CODIGO", this._codigo_search, this._idListaDePrecios_search, this._idListaDePreciosDefault ,_listaDePreciosHabilitadas, false, _idProveedor, _tipoDePrecioDeCosto_Search, PermiteProductosCombo);
                    //Fin Sabrina: Tarea 1080. 20110326
					if ((_miProducto != null) && (_miProducto.Codigo != null) && (_miProducto.Codigo.CompareTo(string.Empty) != 0))
					{
						
						AddItem(_miProducto);
						_lastcode_search = _codigo_search;
						_codigoSec = _miProducto.CodigoSecundario;
						IdListaDePrecios_Search = _miProducto.IdListaDePrecios;
						if (this.SingleSelectionProducto != null)
						{
							SingleSelectionProducto( this, new System.EventArgs());
						}
						_miProducto = null;
						CallRefresh();
						_isValid = true;
					}
					else
					{
						_miProducto = null;
                        /* Silvina 20110217 - Tarea 0000018 */
						//_codigo_search = string.Empty;
                        /* Fin Silvina */
						_isValid = false;
						_errorMessage = "El producto no es válido o no está habilitado";
					}
				}
				else
				{
					_miProducto = null;
					_codigo_search = string.Empty;
					_isValid = true;
					_errorMessage = string.Empty;
				}
			}
			else
			{
				if(_lastcode_search.CompareTo(string.Empty)!= 0)
				{
						_isValid = true;	
					
				}
				CallRefresh();
			}
		}

		public void BuscarAhoraCodigoProveedor()
		{			
			if (_idListaDePrecios_search == null)
				_idListaDePrecios_search = _idListaDePreciosDefault;
			if (_lastcode_search.CompareTo(_codigo_search) != 0 || _miProducto == null)
			{
				_selectedItems.Clear();
				if ((_codigoProveedor_search != null) && (_codigoProveedor_search.CompareTo(string.Empty) != 0))
				{
                    //Sabrina: Tarea 1080. 20110326
					_miProducto = new mz.erp.businessrules.Productos( "CODIGOPROVEEDOR", this._codigoProveedor_search, this._idListaDePrecios_search, this._idListaDePreciosDefault,_listaDePreciosHabilitadas, _habilitaMultiplesCodigosSecundarios, PermiteProductosCombo);
                    //Fin Sabrina: Tarea 1080. 20110326
					if ((_miProducto != null) && (_miProducto.Codigo != null) && (_miProducto.Codigo.CompareTo(string.Empty) != 0))
					{
						
						AddItem(_miProducto);
						_lastcode_search = _miProducto.Codigo;
						_codigo_search = _miProducto.Codigo;
						_codigoSec = _miProducto.CodigoSecundario;
						_codigoProveedor_search = _miProducto.CodigoProveedor;
						IdListaDePrecios_Search = _miProducto.IdListaDePrecios;
						if (this.SingleSelectionProducto != null)
						{
							SingleSelectionProducto( this, new System.EventArgs());
						}
						_miProducto = null;
						CallRefresh();
						_isValid = true;						
					}
					else
					{
						_miProducto = null;
						_codigo_search = string.Empty;
						_isValid = false;
						_errorMessage = "El producto no es válido o no está habilitado";
					}
				}
				else
				{
					_miProducto = null;
					_codigo_search = string.Empty;
					_isValid = true;
					_errorMessage = string.Empty;
				}
			}
			else
			{
				if(_lastcode_search.CompareTo(string.Empty)!= 0)
				{
					_isValid = true;	
					
				}
				CallRefresh();
			}
		}

		
		public void BuscarAhoraSec()
		{			
			if (_idListaDePrecios_search == null)
				_idListaDePrecios_search = _idListaDePreciosDefault;
			if (_tipoDePrecioDeCosto_Search == null || _tipoDePrecioDeCosto_Search.Equals(string.Empty))
				_tipoDePrecioDeCosto_Search = _tipoDePrecioDeCostoDefault;
			if (_lastcode_search.CompareTo(_codigo_search) != 0 || _miProducto == null)
			{
				_selectedItems.Clear();
				if ((_codigoSec_search != null) && (_codigoSec_search.CompareTo(string.Empty) != 0))
				{
					/*
					string prefijo = _codigoSec_search.Substring(0,2);
					if(prefijo.Equals("20"))
					{
						string codigoProductoConCeros = _codigoSec_search.Substring(2,5);
						string precioStr = _codigoSec_search.Substring(7,5);
						decimal precio = Convert.ToDecimal(precioStr)/100;
						string codigoProducto = mz.erp.systemframework.Util.RemoveZerosLeft(codigoProductoConCeros);
						Console.WriteLine(precioStr);
						_codigo_search = codigoProducto;
						BuscarAhora();
						if(_isValid)
							if(_miItem != null && _miItem.Codigo.Equals(_codigo_search))
								_miItem.CodigoSecundarioSegmentado = _codigoSec_search;
					*/
					CodigoSecundarioSegmentadoParser parser = new CodigoSecundarioSegmentadoParser(_codigoSec_search);
					if(parser.IsValid) 
					{
						if(parser.UsaCodigo)
						{
							_codigo_search = parser.Codigo;
							BuscarAhora();
							if(_isValid)
								if(_miItem != null && _miItem.Codigo.Equals(_codigo_search))
								{
									_miItem.CodigoSecundarioSegmentado = parser.CodigoSecundarioSegmentado;
									_miItem.BusquedaPorCodigoSecundarioSegmentado = true;
									_miItem.ParserCodigoSecundarioSegmentado = parser;
								}
						}
						if(parser.UsaCodigoSecundario)
						{
							_codigoSec_search = parser.CodigoSecundario;
							BuscarAhoraSec();
							if(_isValid)
								if(_miItem != null && _miItem.Codigo.Equals(_codigo_search))
								{
									_miItem.CodigoSecundarioSegmentado = parser.CodigoSecundarioSegmentado;
									_miItem.BusquedaPorCodigoSecundarioSegmentado = true;
									_miItem.ParserCodigoSecundarioSegmentado = parser;
								}
						}
						if(parser.UsaCodigoProveedor)
						{
							_codigoProveedor_search = parser.CodigoProveedor;
							BuscarAhoraCodigoProveedor();
							if(_isValid)
								if(_miItem != null && _miItem.Codigo.Equals(_codigo_search))
								{
									_miItem.CodigoSecundarioSegmentado = parser.CodigoSecundarioSegmentado;
									_miItem.BusquedaPorCodigoSecundarioSegmentado = true;
									_miItem.ParserCodigoSecundarioSegmentado = parser;
								}
						}
					}
					else
					{
                        //Sabrina: Tarea 1080. 20110326
						_miProducto = new mz.erp.businessrules.Productos( "CODIGOSECUNDARIO", this._codigoSec_search, this._idListaDePrecios_search, this._idListaDePreciosDefault,_listaDePreciosHabilitadas, _habilitaMultiplesCodigosSecundarios, _idProveedor, _tipoDePrecioDeCosto_Search, PermiteProductosCombo);
                        //Fin Sabrina: Tarea 1080. 20110326
						if ((_miProducto != null) && (_miProducto.Codigo != null) && (_miProducto.Codigo.CompareTo(string.Empty) != 0))
						{
						
							AddItem(_miProducto);
							_lastcode_search = _miProducto.Codigo;
							_codigo_search = _miProducto.Codigo;
							_codigoSec = _miProducto.CodigoSecundario;
							IdListaDePrecios_Search = _miProducto.IdListaDePrecios;
							if (this.SingleSelectionProducto != null)
							{
								SingleSelectionProducto( this, new System.EventArgs());
							}
							_miProducto = null;
							CallRefresh();
							_isValid = true;						
						}
						else
						{
							_miProducto = null;
							_codigo_search = string.Empty;
							_isValid = false;
							_errorMessage = "El producto no es válido o no está habilitado";
						}
					}
				}
				else
				{
					_miProducto = null;
					_codigo_search = string.Empty;
					_isValid = true;
					_errorMessage = string.Empty;
				}
			}
			else
			{
				if(_lastcode_search.CompareTo(string.Empty)!= 0)
				{
					_isValid = true;	
					
				}
				CallRefresh();
			}
		}

		private bool _isValid = true;
		public bool IsValid
		{
			get { return _isValid ; }
			set {_isValid = value; }
		}
		private string _errorMessage = string.Empty;
		public string ErrorMessage
		{
			get { return _errorMessage ; }
			set { _errorMessage = value; }
		}
		
		public void BuscadorAuxiliar()
		{
			/*
			this.SelectedItems.Clear();
			mz.erp.ui.controllers.forms.mzProductosSearchForm sf = new mz.erp.ui.controllers.forms.mzProductosSearchForm();
			sf.ShowDialog();
			if (sf.DialogResult == System.Windows.Forms.DialogResult.OK)
			{
				this._descripcion = sf.SelectedDescription;
				this._codigo_search = sf.SelectedValue;
				if (sf.SelectedItems.Count >= 2)
				{
					foreach ( string idproducto in sf.SelectedItems)
					{
						AddItem( idproducto );
					}
					if (this.MultipleSelectionProducto != null)
					{
						MultipleSelectionProducto( this, new System.EventArgs());
					}


				}
				else
				{
					if (sf.SelectedItems.Count == 1)
					{
						AddItem( (string)sf.SelectedItems[0] );
						_lastcode_search = _codigo_search;
						if (this.SingleSelectionProducto != null)
						{
							SingleSelectionProducto( this, new System.EventArgs());
						}
						CallRefresh();
					}
				}
				_isValid = true;
			}
			else
			{
				_isValid = false; 
				_errorMessage = string.Empty;
			}
			*/
		}
		public void AddItem(string idProducto)
		{
			mz.erp.businessrules.Productos _miProducto = new mz.erp.businessrules.Productos( "IDPRODUCTO", idProducto, this._idListaDePrecios_search, _idListaDePreciosDefault,_listaDePreciosHabilitadas, false);
			IdListaDePrecios_Search = _miProducto.IdListaDePrecios;
			_miItem = new mz.erp.businessrules.comprobantes.Item(_miProducto);
			_miItem.SetConversion(this._momento);
			this._miItem.Conversion.Items.Get(0).ValorConvertidoChanged +=new EventHandler(mzProductosControlController_ValorConvertidoChanged);
			_selectedItems.Add(_miItem);
			_descripcion = _miProducto.DescripcionDetallada;
			_campoAuxiliar1 = _miProducto.CampoAuxiliar1;
			_campoAuxiliar2 = _miProducto.CampoAuxiliar2;
			_nombreCampoAuxiliar1 = _miProducto.NombreCampoAuxiliar1;
			_nombreCampoAuxiliar2 = _miProducto.NombreCampoAuxiliar2;
			_idProducto = idProducto;
		}

		private void AddItem(mz.erp.businessrules.Productos  Producto)
		{
			
			_miItem = new mz.erp.businessrules.comprobantes.Item(Producto);
			_miItem.SetConversion(this._momento);
			_selectedItems.Add(_miItem);
			this._miItem.Conversion.Items.Get(0).ValorConvertidoChanged +=new EventHandler(mzProductosControlController_ValorConvertidoChanged);
			_descripcion = Producto.DescripcionDetallada;
			_campoAuxiliar1 = Producto.CampoAuxiliar1;
			_campoAuxiliar2 = Producto.CampoAuxiliar2;
			_nombreCampoAuxiliar1 = Producto.NombreCampoAuxiliar1;
			_nombreCampoAuxiliar2 = Producto.NombreCampoAuxiliar2;
			_idProducto = Producto.IdProducto;
		}
		
		private string _momento = string.Empty;
		public string Momento
		{
			get { return _momento ; }
			set { _momento = value; }
		}
		private ArrayList _selectedItems = new ArrayList();
		private string _descripcion = string.Empty;
		public ArrayList SelectedItems
		{
			get { return _selectedItems; }			
		}
		public string Descripcion
		{
			get { return _descripcion; }
			set {_descripcion = value; }
		}
		private string _informacion_Adicional1 = string.Empty;
		public string InformacionAdicional1
		{
			get { return _informacion_Adicional1 ;}
		}
		private string _informacion_Adicional2 = string.Empty;
		public string InformacionAdicional2
		{
			get { return _informacion_Adicional2; }
		}
		private string _formulaConversion= string.Empty;
		public string FormulaConversion
		{
			get { return _formulaConversion ; } 
		}
		//private decimal _cantidad = 1;
		public decimal Cantidad
		{
			get 
			{
				if(_miItem != null)
					return _miItem.Conversion.Items.Get(0).ValorSinConvertir;
				return 0;
			}
			set 
			{ 
				if(_miItem != null)
					 _miItem.Conversion.Items.Get(0).ValorSinConvertir = value;;
			}
		}
		private decimal _cantidadDestino = 1;
		
		public decimal CantidadDestino
		{
			get 
			{ 
				if(_miItem != null)
					return _miItem.Conversion.Items.Get(0).ValorConvertido;
				else return 0;
			}
			
			set
			{
				_cantidadDestino = value;
				if (CantidadDestinoChanged != null)
				{
					CantidadDestinoChanged( this, new System.EventArgs() );
				}
			}
			
		}
		
		private string _unidadOrigen = string.Empty;
		public string UnidadOrigen
		{
			get 
			{
				if(_miItem != null)
					return _miItem.Conversion.Items.Get(0).UnidadOrigen;
				else return string.Empty;
			}
		}

		private string _unidadDestino = string.Empty;
		public string UnidadDestino
		{
			get 
			{
				if(_miItem != null)
					 return _miItem.Conversion.Items.Get(0).UnidadDestino;
				 else return string.Empty;
			}
		}
		private decimal _precioUnidadOrigen = 0;
		public decimal PrecioUnidadOrigen
		{
			get 
			{
				if(_miItem != null)
				{
					decimal precio = (_miItem.PrecioBrutoImpuestosIncluidos  / _miItem.Conversion.Items.Get(0).ValorConversion);
					return  precio;
				}
				else
					return 0 ;
			}
		}
		private decimal _precioUnidadDestino = 0;
		public decimal PrecioUnidadDestino
		{
			get 
			{
				if(_miItem != null)
				{
					decimal precio = _miItem.PrecioBrutoImpuestosIncluidos;
					return precio;
				}
				else return 0 ; 
			}
		}

		private decimal _valorConversion;
		public decimal ValorConversion
		{
			get
			{
				if(_miItem != null)
					return _miItem.Conversion.Items.Get(0).ValorConversion;
				else return 0 ; 
			}
			
				
		}

		private decimal _stock;
		public decimal Stock
		{
			get
			{									
				return businessrules.Stock.GetStockDisponible(_miItem.IdProducto);;
			}
		}
		private string _campoAuxiliar1;
		public string CampoAuxiliar1
		{
			get
			{
				return _campoAuxiliar1;
			}
		}
		private string _campoAuxiliar2;
		public string CampoAuxiliar2
		{
			get
			{
				return _campoAuxiliar2;
			}
		}
		private string _nombreCampoAuxiliar1;
		public string NombreCampoAuxiliar1
		{
			get
			{
				return _nombreCampoAuxiliar1;
			}
		}
		private string _nombreCampoAuxiliar2;
		public string NombreCampoAuxiliar2
		{
			get
			{
				return _nombreCampoAuxiliar2;
			}
		}

		private bool _listaDePreciosHabilitadas = false; 
		public bool ListaDePreciosHabilitadas
		{
			get{return _listaDePreciosHabilitadas;}
		}

		private bool _permiteListaDePreciosDistintas = false; 
		public bool PermiteListaDePreciosDistintas
		{
			get{return _permiteListaDePreciosDistintas;}
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
			set { _idListaDePreciosDefault = value;}
		}

		private ArrayList _tiposDePrecioDeCosto;
		public ArrayList TiposDePrecioDeCosto
		{
			get {return _tiposDePrecioDeCosto;}
		}

		private string _tipoDePrecioDeCostoDefault = string.Empty;
		public string TipoDePrecioDeCostoDefault
		{
			get { return _tipoDePrecioDeCostoDefault; }
		}

		private bool _volverAListaDePreciosDefault = false;
		public bool VolverAListaDePreciosDefault
		{
			get { return _volverAListaDePreciosDefault; }
		}

		private string _idProducto;
		public string IdProducto
		{
			get { return _idProducto; }
			set {_idProducto = value; }
		}

		//German 20090331
		public bool FocoEnCodigoProducto
		{
			get{return _focoEnCodigo;}
		}
		//Fin German 20090331

		public event System.EventHandler PrecioUnidadDestinoChanged;
		public event System.EventHandler PrecioUnidadOrigenChanged;
		public event System.EventHandler UnidadDestinoChanged;
		public event System.EventHandler UnidadOrigenChanged;
		public event System.EventHandler CantidadDestinoChanged;
		public event System.EventHandler CantidadChanged;
		public event System.EventHandler FormulaConversionChanged;
		public event System.EventHandler InformacionAdicional2Changed;
		public event System.EventHandler InformacionAdicional1Changed;
		public event System.EventHandler DescripcionChanged;

		public void RefreshMultiple()
		{
			if (MultipleSelectionProducto != null)
			{
				MultipleSelectionProducto( this, new System.EventArgs());
			}
		}
		public void RefreshSingle()
		{
			if (SingleSelectionProducto != null)
			{
				SingleSelectionProducto( this, new System.EventArgs());
			}
			CallRefresh();
		}

		public void CallRefresh()
		{
			if (PrecioUnidadDestinoChanged != null)
			{
				PrecioUnidadDestinoChanged( this, new System.EventArgs() );
			}
			if (PrecioUnidadOrigenChanged != null)
			{
				PrecioUnidadOrigenChanged( this, new System.EventArgs() );
			}
			if (UnidadDestinoChanged != null)
			{
				UnidadDestinoChanged( this, new System.EventArgs() );
			}
			if (UnidadOrigenChanged != null)
			{
				UnidadOrigenChanged( this, new System.EventArgs() );
			}
			if (CantidadDestinoChanged != null)
			{
				CantidadDestinoChanged( this, new System.EventArgs() );
			}
			if (CantidadChanged != null)
			{
				CantidadChanged( this, new System.EventArgs() );
			}
			if (FormulaConversionChanged != null)
			{
				FormulaConversionChanged( this, new System.EventArgs() );
			}
			if (InformacionAdicional2Changed != null)
			{
				InformacionAdicional2Changed( this, new System.EventArgs() );
			}
			if (InformacionAdicional1Changed != null)
			{
				InformacionAdicional1Changed( this, new System.EventArgs() );
			}
			if (DescripcionChanged != null)
			{
				DescripcionChanged( this, new System.EventArgs() );
			}

		}

		private void mzProductosControlController_ValorConvertidoChanged(object sender, EventArgs e)
		{
			this.CantidadDestino = _miItem.Conversion.Items.Get(0).ValorConvertido;
		}

		public bool MostrarSugerencias()
		{
			Conversion conversion = this._miItem.Conversion;
			ConversionItem item = conversion.Items.Get(0);
			//Harcodeado
			//return true;
			return item.IdUnidadOrigen.Equals("1") && item.IdUnidadDestino.Equals("3");

		}

		private string _taskName = "";
		private string _processName = "";
		//esta variable indica si el control esta en un form de compras (C) o ventas (V)
		private string _tipoDeFormularioPadre = "V";
		//German 20090331
		private bool _focoEnCodigo = true;
		//Fin German 20090331


		public void SetProcess(string ProcessName, string TaskName, string TipoDeFormularioPadre)
		{
			_processName = ProcessName;
			_taskName = TaskName;
			_tipoDeFormularioPadre = TipoDeFormularioPadre;
			Init();
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

		private void Init() 
		{
			InitData();
		}	

		private void InitData()
		{
			SetCombosData();
			_volverAListaDePreciosDefault = Variables.GetValueBool(_processName, _taskName, "ListaDePrecios.VolverADefault");	
			_listaDePreciosHabilitadas = Variables.GetValueBool("Productos.ListasDePrecios");
			_permiteListaDePreciosDistintas = Variables.GetValueBool("Productos.ListaDePrecios.PermiteListaDePreciosDistintas");
			
			_habilitaMultiplesCodigosSecundarios = Variables.GetValueBool("Productos.MultiplesCodigosSecundarios", _habilitaMultiplesCodigosSecundarios);
			
			//German 20090331
			/*Levanta esta variable para ver si cuando se busca y no se encuentra el codigo del producto, vuelve el foco al codigo o sigue a la cantidad*/
			_focoEnCodigo = Variables.GetValueBool(_processName, _taskName, "Buscador.FocoEnCodigoProducto","Productos.Buscador.FocoEnCodigoProducto", _focoEnCodigo);
			//Fin German 20090331

		}

		private void SetCombosData()
		{
			DataTable listaDePreciosTable = businessrules.tsh_ListasDePrecios.GetList().tsh_ListasDePrecios;
			_listaDePrecios = VariablesListComparer.FilterDataTable(_processName, _taskName, "ListasDePrecios", KeyValueListaDePrecios, listaDePreciosTable);
			
			_idListaDePreciosDefault = Variables.GetValueString(_processName, _taskName, "ListaDePreciosDefault");	
			if(_idListaDePreciosDefault.Equals(string.Empty))
				_idListaDePreciosDefault = businessrules.tsh_ListasDePrecios.GetDefault().IdListaDePrecio;

			_tipoDePrecioDeCostoDefault = Variables.GetValueString(_processName, _taskName, "PrecioDeCosto.Origen");	
			if(_tipoDePrecioDeCostoDefault.Equals(string.Empty))
				_tipoDePrecioDeCostoDefault = Variables.GetValueString("Productos.PrecioDeCosto.Origen");
			
		}

		#region IObservable
		private ArrayList _objectListener = new ArrayList();
		public void AddObjectListener( IObserver _object )
		{
			_objectListener.Add( _object );
		}
		public void ProcessObjectsObserver()
		{
			System.EventArgs e = new System.EventArgs();
			foreach ( IObserver _object in _objectListener )
			{
				_object.UpdateObject( this, this._descripcion);
			}
		}
		#endregion

		#region Miembros de IObserver		
		public void UpdateObject(object sender, object valores)
		{		
			if ( ((valores.GetType()) == typeof(System.String)) && (!valores.Equals(String.Empty)) )
			{
				if (IdListaDePreciosDefault != Convert.ToString(valores)) 
				{
					this.IdListaDePreciosDefault = Convert.ToString(valores);
					this.IdListaDePrecios_Search = _idListaDePreciosDefault;
					if(IdListaDePrecios_SearchChanged != null)
					{
						IdListaDePrecios_SearchChanged(this, new EventArgs());
					}				
				}

				//Sabrina 20100615 - Tarea 765
				if(IdListaDePrecios_Search != Convert.ToString(valores))
				{
					this.IdListaDePrecios_Search = Convert.ToString(valores);
					if(IdListaDePrecios_SearchChanged != null)
					{
						IdListaDePrecios_SearchChanged(this, new EventArgs());
					}				
				}
				//Fin Sabrina 20100615 - Tarea 765
			}
		}


		#endregion
	}
}

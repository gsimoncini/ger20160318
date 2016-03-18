using System;
using System.Data;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.ui;
using System.Text;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ComprobantesDeCompraController.
	/// </summary>
	public class ComprobantesDeCompraController: ITaskController, IObserver
	{
		#region Constructores		
		public ComprobantesDeCompraController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			_comprobanteDeCompra = new mz.erp.businessrules.comprobantes.ComprobanteDeCompra();
			Init();
		}
		public ComprobantesDeCompraController( ComprobanteDeCompra _comprobante )
		{
			_comprobanteDeCompra = _comprobante;
			Init();
		}
		private void Init()
		{
			InitializeData();
			InitEventHandlers();
		}
		#endregion

		#region Variables Privadas
		private ComprobanteDeCompra _comprobanteDeCompra;
		
		/*private string _responsableDeEmision = string.Empty;
		private string _tipoDeComprobante = string.Empty;
		private string _cuenta;
		
		private System.DateTime _fecha = mz.erp..erp.businessrules.Sistema.DateTime.Now;
		private string _numeroComprobante = "";
		*/
		private System.Collections.Hashtable _listatiposDeComprobantes =  businessrules.tsy_TiposDeComprobantes.GetListHashTable();		
		private string _layoutDetalle = string.Empty;
		private string _leyendaFormulario = string.Empty;
		private string _itemKey = "Codigo";
		//private bool _editable = true;		
		

		#endregion

		#region Variables Publicas Interfaz

		public bool AllowEditCondicionDeCompra
		{
			get{return _comprobanteDeCompra.AllowEditCondicionDeCompra;}
		}


		
		public bool AllowEditDiasDemoraEntrega
		{
			get{return _comprobanteDeCompra.AllowEditDiasDemoraEntrega;}
		}

		public bool AllowEditFechaRecepcionMercaderia
		{
			get{return _comprobanteDeCompra.AllowEditFechaRecepcionMercaderia;}
		}

		public string LeyendaFormulario
		{
			get
			{
				return this._leyendaFormulario;
			}
		}

		public bool PreguntarAlCancelar
		{
			get {return _comprobanteDeCompra.PreguntarAlCancelar;}
		}

        /* Silvina 20100531 - Tarea 646 */
        public bool SeleccionaUltimo
        {
            get { return _comprobanteDeCompra.SeleccionaUltimo; }
        }
        /* Fin Silvina */

		public string Caption 
		{
			get
			{
				return "Emision de " + this.NombreDeComprobante;
			}
		}

		/*public string LayoutVariables
		{
			get
			{
				return _layoutVariables;
			}
		}

		public string LayoutCondicionesDeVenta
		{
			get
			{
				return _layoutCondicionesDeVenta;
			}
		}

		public string LayoutImpuestos
		{
			get
			{
				return _layoutImpuestos;
			}
		}

		public string LayoutItems
		{
			get 
			{ 
				return _layoutItems;
			}
		}
		*/

		public bool AllowEditValorCotizacion
		{
			get{return _comprobanteDeCompra.AllowEditValorCotizacion;}
		}



		public bool AllowEditMonedaOrigen
		{
			get{return _comprobanteDeCompra.AllowEditMonedaOrigen;}
		}

		public bool AllowEditFuenteDeCambio
		{
			get{return _comprobanteDeCompra.AllowEditFuenteDeCambio;}
		}

		public bool RemoveItemsFromGrid
		{
			get{return !_comprobanteDeCompra.ProcessName().Equals("ProcesoEditarPreOrdenDeCompra");}
		}

		public bool AlwaysInEditMode
		{
			get{return _comprobanteDeCompra.ProcessName().Equals("ProcesoEditarPreOrdenDeCompra");}
		}

		public bool IsEditable( object selectedItem, string Propiedad)
		{
			
			ItemComprobanteCompra item = (ItemComprobanteCompra) selectedItem;

			string nombreProceso = this._processManager.GetProcessName();
			string nombreTarea = this._comprobanteDeCompra.GetTaskName();
			string colaVariable = string.Empty;

			if(Propiedad.Equals("Cantidad"))
				if((item.IdComprobanteOrigen != null && item.IdComprobanteOrigen != string.Empty) )
				{
					colaVariable = "Emision.Editar.Step." + Propiedad;
					bool result1 = Variables.GetValueBool(nombreProceso, nombreTarea, colaVariable);
					return result1;
				}

			colaVariable = "Emision.Editar." + Propiedad;
			bool result = Variables.GetValueBool(nombreProceso, nombreTarea, colaVariable);
			return item.AllowEdit && result; //&& (!habiltaComodines || (habiltaComodines && aux.Contains(item.Codigo)));
			
			
		}

		public bool IsRemovable( object selectedItem)
		{
			ItemComprobanteCompra item = (ItemComprobanteCompra) selectedItem;
			if(item.IdComprobanteOrigen != null && item.IdComprobanteOrigen != string.Empty)
			{
				string nombreProceso = this._processManager.GetProcessName();
				string nombreTarea = this._comprobanteDeCompra.GetTaskName();
				string colaVariable = string.Empty;
				colaVariable = "Emision.Step.Delete.Items";
				bool result = Variables.GetValueBool(nombreProceso, nombreTarea, colaVariable);
				return result;
			}
			return item.AllowEdit;
		}

		public bool AllowDeleteItems
		{
			get{return this._comprobanteDeCompra.AllowDeleteItems;	}			
		}
		public bool AllowAddItems
		{
			get{return this._comprobanteDeCompra.AllowAddItems;	}			
		}

		public bool AllowEditItems
		{
			get
			{
				return this._comprobanteDeCompra.AllowEditItems;
			}
		}
		public bool AllowEditTipoDeComprobante
		{
			get
			{
				return this._comprobanteDeCompra.AllowEditTipoDeComprobante;
			}
		}
		public bool AllowEditResponsableEmision
		{
			get
			{
				return this._comprobanteDeCompra.AllowEditResponsableEmision;
			}
		}
		public bool AllowEditProveedor
		{
			get
			{
				return this._comprobanteDeCompra.AllowEditProveedor;
			}
		}

		private bool _enabledButtonCuentaCtaCte = true;
		public bool EnabledButtonCuentaCtaCte
		{
			get 
			{
				return  _enabledButtonCuentaCtaCte;
			}				
		}



		public bool AllowEditFecha
		{
			get
			{
				return this._comprobanteDeCompra.AllowEditFecha;
			}
		}

		public bool AllowEditFechaRegistracion
		{
			get
			{
				return this._comprobanteDeCompra.AllowEditFechaRegistracion;
			}
		}

		public bool AllowEditNumeration
		{
			get
			{
				return this._comprobanteDeCompra.AllowEditNumeration;
			}
		}

		
		
/*
		public bool AllowEditProveedores
		{
			get
			{
				return true;//XXX this._comprobanteCompra.AllowEditProveedores;
			}
		}

		public bool AllowEditTiposDeComprobantes
		{
			get
			{
				return true;//XXX this._comprobanteCompra.AllowEditTiposDeComprobantes;
			}
		}	
*/

		public string TextoBotonSiguiente
		{
			get 
			{
				return this._comprobanteDeCompra.TextoBotonSiguiente;
			}
		}
		public string TextoBotonAnterior
		{
			get 
			{
				return this._comprobanteDeCompra.TextoBotonAnterior;					
			}
		}
		public string TextoCampoAuxiliar1
		{
			get 
			{
				return this._comprobanteDeCompra.TextoCampoAuxiliar1;					
			}
		}
		public string TextoCampoAuxiliar2
		{
			get 
			{
				return this._comprobanteDeCompra.TextoCampoAuxiliar2;					
			}
		}
		public string TextoCampoAuxiliar3
		{
			get 
			{
				return this._comprobanteDeCompra.TextoCampoAuxiliar3;					
			}
		}
		public string TextoCampoAuxiliar4
		{
			get 
			{
				return this._comprobanteDeCompra.TextoCampoAuxiliar4;					
			}
		}
		public string MascaraCampoAuxiliar1
		{
			get 
			{
				return this._comprobanteDeCompra.MascaraCampoAuxiliar1;					
			}
		}
	
		
		public DataTable TableMonedas
		{
			get{return _comprobanteDeCompra.TableMonedas;}	
		}
		public DataTable TableFuentesDeCambio
		{
			get{return _comprobanteDeCompra.TableFuentesDeCambio;}
		}		

		#endregion

		#region Variables Publicas Datos


		private string _idCondicionDeCompra = string.Empty;
		public string IdCondicionDeCompra
		{
			get{return _comprobanteDeCompra.IdCondicionDeCompra;}
			set
			{
				_idCondicionDeCompra = value;
				_comprobanteDeCompra.IdCondicionDeCompra = value;
			}
		}

		public DateTime FechaRecepcionMercaderia
		{
			get{return _comprobanteDeCompra.FechaRecepcionMercaderia;}
			set{_comprobanteDeCompra.FechaRecepcionMercaderia = value;}
		}

		public int DiasDemoraEntrega
		{
			get{return _comprobanteDeCompra.DiasDemoraEntrega;}
			set{_comprobanteDeCompra.DiasDemoraEntrega = value;}
		}
	

		public decimal Neto 
		{
			get
			{
				return _comprobanteDeCompra.Neto;

			}
		}




		public object SelectedItem
		{
			set{_comprobanteDeCompra.SelectedItem = value;}
		}

		public string ItemKey
		{
			get{return _itemKey;}
		}

		private decimal _total = 0;
		public decimal Total
		{
			get
			{
				return _total;
			}
		}

		public string NombreDeComprobante
		{
			get { return _listatiposDeComprobantes[ _comprobanteDeCompra.TipoComprobanteDestino].ToString() ;}
		}

		public ItemsComprobantesCompra Items
		{
			get
			{
				return _comprobanteDeCompra.Items;
			}
		}

		public string IdProveedor
		{
			get
			{
				return _comprobanteDeCompra.Proveedor.IdProveedor;
			}
		}

		private string _mascara = string.Empty;
		public string Mascara
		{
			get
			{
				return _mascara;
			}
		}

		private string _keyValueProveedores = string.Empty;
		public string KeyValueProveedores
		{
			get {return _comprobanteDeCompra.CodigoProveedor;}
			set 
			{
				if (_keyValueProveedores!= value) 
				{
					_keyValueProveedores = value;
					businessrules.Proveedor proveedor = new businessrules.Proveedor();
					proveedor.GetCuenta_CodigoProveedor(value);
					_comprobanteDeCompra.IdProveedor = proveedor.IdProveedor;		
					if(KeyValueProveedoresChanged != null)
						KeyValueProveedoresChanged(this, new EventArgs());	
				}				
			}		
		}			
		

		private object _keyValueTiposDeComprobantes = string.Empty;
		public object KeyValueTiposDeComprobantes
		{
			get {return _comprobanteDeCompra.TipoComprobanteDestino;}
			set 
			{
				if (_keyValueTiposDeComprobantes!= value) 
				{
					_keyValueTiposDeComprobantes = value;
					_comprobanteDeCompra.TipoComprobanteDestino = Convert.ToString(value);
					/*
					if(KeyValueTiposDeComprobantesChanged != null)
						KeyValueTiposDeComprobantesChanged(this, new EventArgs());	
					*/
				}				
			}
		}

		private object _responsableDeEmision = string.Empty;
		public object ResponsableDeEmision
		{
			get {return _comprobanteDeCompra.IdResponsable;}
			set 
			{
				if (_responsableDeEmision!= value) 
				{
					_responsableDeEmision = value;
					_comprobanteDeCompra.IdResponsable = Convert.ToString(value);
					/*
					if(ResponsableDeEmisionChanged != null)
						ResponsableDeEmisionChanged(this, new EventArgs());	
					*/
				}				
			}
		}

		private string _numeroComprobante = "";
		public string NumeroComprobante 
		{
			get {return _comprobanteDeCompra.Numero;	}
			set 
			{
				if(_numeroComprobante != value)
				{
					_numeroComprobante = value;
					_comprobanteDeCompra.Numero = value;
				}
			}
		}
		private string _observaciones = "";
		public string Observaciones
		{
			get {return _comprobanteDeCompra.Observaciones ;	}
			set 
			{
				if(_observaciones != null)
				{
					_observaciones = value;
					_comprobanteDeCompra.Observaciones = value;
				}
			}
		}
		private string _campoAuxiliar1 = "";
		public string CampoAuxiliar1
		{
			get {return _comprobanteDeCompra.CampoAuxiliar1;	}
			set 
			{
				if(_campoAuxiliar1 != value)
				{
					_campoAuxiliar1 = value;
					_comprobanteDeCompra.CampoAuxiliar1 = value;

				}
			
			}
		}
		private string _campoAuxiliar2 = "";
		public string CampoAuxiliar2
		{
			get {return _comprobanteDeCompra.CampoAuxiliar2;	}
			set 
			{
				if(_campoAuxiliar2 != value)
				{
					_campoAuxiliar2 = value;
					_comprobanteDeCompra.CampoAuxiliar2 = value;

				}
			
			}
		}
		private string _campoAuxiliar3 = "";
		public string CampoAuxiliar3
		{
			get {return _comprobanteDeCompra.CampoAuxiliar3;	}
			set 
			{
				if(_campoAuxiliar3 != value)
				{
					_campoAuxiliar3 = value;
					_comprobanteDeCompra.CampoAuxiliar3 = value;

				}
			
			}		
		}
		private decimal _campoAuxiliar4 = 0;
		public decimal CampoAuxiliar4
		{
			get {return _comprobanteDeCompra.CampoAuxiliar4;	}
			set 
			{
					if(_campoAuxiliar4 != value)
				{
					_campoAuxiliar4 = value;
					_comprobanteDeCompra.CampoAuxiliar4 = value;

				}
			
			}
		}
		private DateTime _fecha = mz.erp.businessrules.Sistema.DateTime.Now;
		public DateTime Fecha
		{
			get 
			{
				return _comprobanteDeCompra.FechaEmision;	
			}
			set 
			{
				if(_fecha != value)
				{
					_fecha = value;
					_comprobanteDeCompra.FechaEmision = value;
				}
			}
		}
		private DateTime _fechaRegistracion = mz.erp.businessrules.Sistema.DateTime.Now;
		public DateTime FechaRegistracion
		{
			get {return _comprobanteDeCompra.FechaRegistracion;	}
			set 
			{
				if(_fechaRegistracion != value)
				{
					_fechaRegistracion = value;
					_comprobanteDeCompra.FechaRegistracion = value;
				}
			}
		}

		private decimal _valorCotizacionProveedor = 1;
		public decimal ValorCotizacionProveedor
		{
			get
			{
				return  _comprobanteDeCompra.ValorCotizacionProveedor;
			}
			set
			{
				if(_valorCotizacionProveedor != value)
				{
					_valorCotizacionProveedor = value;
					_comprobanteDeCompra.ValorCotizacionProveedor = value;
				}
			}

		}

		private string _idMonedaOrigen = string.Empty;
		public string IdMonedaOrigen
		{
			get
			{
				return _comprobanteDeCompra.IdMonedaOrigen;
			}
			set
			{
				if(_idMonedaOrigen != value)
				{
					_idMonedaOrigen = value;
					_comprobanteDeCompra.IdMonedaOrigen = value;

				}
			}
		}
			
		private string _idFuenteDeCambioProveedor = string.Empty;
		public string IdFuenteDeCambioProveedor
		{
			get
			{
				return _comprobanteDeCompra.IdFuenteDeCambioProveedor;
			}
			set
			{
				if(_idFuenteDeCambioProveedor != value)
				{
					_idFuenteDeCambioProveedor = value;
					_comprobanteDeCompra.IdFuenteDeCambioProveedor = value;
				}
			}
		}

		public Type ProveedoresSearchObject 
		{
			get 
			{
				return typeof(mz.erp.ui.controllers.tpu_Proveedores);
			}
		}


		public DataTable ResponsableDataTable
		{
			get
			{
				return businessrules.data.UsuariosPersonas.GetList();
			}
		}

		public DataTable TiposDeComprobantesSearchObject 
		{
			get 
			{
				return _comprobanteDeCompra.TableTiposDeComprobantesValidos;
			}
		}
		public string LayoutDetalle 
		{
			get 
			{
				return _layoutDetalle;
			}
		}

		public string ResponsableValueMember
		{
			get
			{
				return "IdPersona";
			}
		}

		public string ResponsableDisplayMember
		{
			get
			{
				return "Nombre";
			}
		}

		public string TiposDeComprobantesValueMember
		{
			get 
			{
				return "IdTipoDeComprobante";
			}
		}

		public string TiposDeComprobantesDisplayMember
		{
			get 
			{
				return "Descripcion";
			}
		}

		public string KeyValueTiposMovimientos
		{
			get { return "IdTipoMovimiento" ; }
		}
		public string KeyListTiposMovimientos
		{
			get { return "Descripcion" ; }
		}




		/*public bool Editable 
		{
			get
			{
				return _editable;
			}
		}
		public DataTable ResumenDeImpuestos
		{
			get
			{	
				return this._comprobanteDeVenta.ResumenDeImpuestos;
			}
		
		}

		public ICollection DetalleCondicionDeVenta
		{
			get
			{
				return this._comprobanteDeVenta.CondicionDeVenta.DetalleCondicionDeVenta;
			}
		}

		public ICollection VariablesDeUsuario
		{
			get
			{
				return this._comprobanteDeVenta.VariablesDeUsuario;
			}
		}*/


		/*public string Mascara
		{
			get { return _comprobanteDeVenta.Mascara;}
		}
		
		public ICollection DataItems
		{
			get { return (ICollection)_comprobanteDeVenta.Items ; }
		}

		public decimal TotalNeto
		{
			get { return this._comprobanteDeVenta.TotalNeto ; }
		}
		
		public decimal TotalConImpuestos
		{
			get { return this._comprobanteDeVenta.TotalConImpuestos ; }
		}
		public decimal TotalImpuestos
		{
			get { return this._comprobanteDeVenta.TotalImpuestos; }
		}
		public decimal TotalBruto
		{
			get { return this._comprobanteDeVenta.TotalBruto ; }
		}
		
		public decimal TotalDescuentos
		{
			get { return this._comprobanteDeVenta.TotalDescuentos * (-1) ; }
		}

		public decimal Total
		{
			get { return this._comprobanteDeVenta.Total ; }
		}

		
		*/


		#endregion
		
		#region Eventos y Delegados
		public event EventHandler KeyValueProveedoresChanged;		
		public event EventHandler KeyValueTiposDeComprobantesChanged;		
		public event EventHandler NumeroComprobanteChanged;
		public event EventHandler ResponsableDeEmisionChanged;
		public event EventHandler FechaChanged;
		public event EventHandler FechaRegistracionChanged;
		public event EventHandler ObservacionesChanged;
		public event EventHandler CampoAuxiliar1Changed;
		public event EventHandler CampoAuxiliar2Changed;
		public event EventHandler CampoAuxiliar3Changed;
		public event EventHandler CampoAuxiliar4Changed;
		public event EventHandler ItemsChanged;
		public event EventHandler TotalChanged;
		public event EventHandler ValorCotizacionChanged;
		public event EventHandler IdMonedaOrigenChanged;
		public event EventHandler IdFuenteDeCambioProveedorChanged;
		public event EventHandler ValorCotizacionProveedorChanged;
		public event EventHandler FechaVencimientoChanged;
		public event EventHandler DiasVencimientoChanged;
		public event EventHandler IdCuentaImputacionChanged;
		public event EventHandler IdSubCuentaImputacionChanged;
		public event EventHandler CuentaImputacionChanged;
		public event EventHandler TipoDeComprobanteDestinoChanged;
		public event EventHandler FechaRecepcionMercaderiaChanged;
		public event EventHandler DiasDemoraEntregaChanged;
		public event EventHandler IdCondicionDeCompraChanged;
		public event EventHandler AddItemsChanged;

		
/*
		public event EventHandler OnTaskAfterExecute;		
*/
		private void CallRefresh()
		{
			if(_idMonedaOrigen != _comprobanteDeCompra.IdMonedaOrigen)
			{
				_idMonedaOrigen = _comprobanteDeCompra.IdMonedaOrigen;
				if(IdMonedaOrigenChanged != null)
					IdMonedaOrigenChanged(this, new EventArgs());
			}
			if(_idFuenteDeCambioProveedor != _comprobanteDeCompra.IdFuenteDeCambioProveedor)
			{
				_idFuenteDeCambioProveedor = _comprobanteDeCompra.IdFuenteDeCambioProveedor;
				if(IdFuenteDeCambioProveedorChanged != null)
					IdFuenteDeCambioProveedorChanged(this, new EventArgs());
			}
			if(_valorCotizacionProveedor != _comprobanteDeCompra.ValorCotizacionProveedor)
			{
				_valorCotizacionProveedor = _comprobanteDeCompra.ValorCotizacionProveedor;
				if(ValorCotizacionProveedorChanged != null)
					ValorCotizacionProveedorChanged(this, new EventArgs());
			}
			if (_keyValueProveedores != (_comprobanteDeCompra.Proveedor.Codigo)) 
			{								
				_keyValueProveedores = _comprobanteDeCompra.Proveedor.Codigo;
				if (KeyValueProveedoresChanged != null) 
				{
					KeyValueProveedoresChanged(this, new EventArgs());	
				}
			}
			if (_responsableDeEmision != (_comprobanteDeCompra.IdResponsable)) 
			{								
				_responsableDeEmision = _comprobanteDeCompra.IdResponsable;
				if (ResponsableDeEmisionChanged != null) 
				{
					ResponsableDeEmisionChanged(this, new EventArgs());	
				}
			}
			if (_keyValueTiposDeComprobantes != (_comprobanteDeCompra.TipoComprobanteDestino)) 
			{
				_keyValueTiposDeComprobantes = _comprobanteDeCompra.TipoComprobanteDestino;
				if (KeyValueTiposDeComprobantesChanged != null) 
				{
					KeyValueTiposDeComprobantesChanged(this, new EventArgs());	
				}
			}
			if (!_numeroComprobante.Equals(_comprobanteDeCompra.Numero))
			{	
				_numeroComprobante = _comprobanteDeCompra.Numero;
				if (NumeroComprobanteChanged != null) 
				{
					NumeroComprobanteChanged(this, new EventArgs());	
				}
			}
			if (!_fecha.Equals(_comprobanteDeCompra.FechaComprobante)) 
			{										
				_fecha = _comprobanteDeCompra.FechaComprobante;
				if (FechaChanged != null) 
				{
					FechaChanged(this, new EventArgs());	
				}
			}
			if (_fechaRegistracion != _comprobanteDeCompra.FechaRegistracion)   //) 
			{
				_fechaRegistracion = _comprobanteDeCompra.FechaRegistracion;
			
				if (FechaRegistracionChanged!= null) 
				
				{										
					FechaRegistracionChanged(this, new EventArgs());	
				}				
			}
			if (!_observaciones.Equals(_comprobanteDeCompra.Observaciones)) 
			{										
				_observaciones = _comprobanteDeCompra.Observaciones;
				if (ObservacionesChanged!= null) 
				{
					ObservacionesChanged(this, new EventArgs());	
								
				}
			}
			if (!_campoAuxiliar1.Equals(_comprobanteDeCompra.CampoAuxiliar1)) 
			{
				_campoAuxiliar1 = _comprobanteDeCompra.CampoAuxiliar1;
				if (CampoAuxiliar1Changed!= null) 
				{
					CampoAuxiliar1Changed(this, new EventArgs());	
				}
			}
			if (!_campoAuxiliar2.Equals(_comprobanteDeCompra.CampoAuxiliar2)) 
			{
				_campoAuxiliar2 = _comprobanteDeCompra.CampoAuxiliar2;
				if (CampoAuxiliar2Changed!= null) 
				{
					CampoAuxiliar2Changed(this, new EventArgs());	
				}
			}
			if (!_campoAuxiliar3.Equals(_comprobanteDeCompra.CampoAuxiliar3)) 
			{
				_campoAuxiliar3 = _comprobanteDeCompra.CampoAuxiliar3;
				if (CampoAuxiliar3Changed!= null) 
				{
					CampoAuxiliar3Changed(this, new EventArgs());	
				}
			}

			if (!_campoAuxiliar4.Equals(_comprobanteDeCompra.CampoAuxiliar4)) 
			{
				_campoAuxiliar4 = _comprobanteDeCompra.CampoAuxiliar4;
				if (CampoAuxiliar4Changed!= null) 
				{
					CampoAuxiliar4Changed(this, new EventArgs());	
				}
			}
			if(ItemsChanged != null)
				ItemsChanged(this, new EventArgs());

			if (!_total.Equals(_comprobanteDeCompra.Total)) 
			{
				_total = _comprobanteDeCompra.Total;
				if (TotalChanged!= null) 
				{
					TotalChanged(this, new EventArgs());	
				}
			}
			if(_idCondicionDeCompra != _comprobanteDeCompra.IdCondicionDeCompra)
			{
				_idCondicionDeCompra = _comprobanteDeCompra.IdCondicionDeCompra;
				if(IdCondicionDeCompraChanged != null)
					IdCondicionDeCompraChanged(this, new EventArgs());
			}


		}

		private void InitEventHandlers()
		{
			_comprobanteDeCompra.ObjectHasChanged+=new EventHandler(ListenerObjectHasChanged);
			_comprobanteDeCompra.FechaRecepcionMercaderiaChanged+=new EventHandler(_brClass_FechaRecepcionMercaderiaChanged);
			_comprobanteDeCompra.DiasDemoraEntregaChanged +=new EventHandler(_brClass_DiasDemoraEntregaChanged);
			_comprobanteDeCompra.AddItemsChanged +=new EventHandler(_comprobanteDeCompra_AddItemsChanged);
			//German 20090407
			_comprobanteDeCompra.ItemsChanged +=new EventHandler(_comprobanteDeCompra_ItemsChanged);
			//Fin German 20090407
			/*_comprobanteDeCompra.FechaVencimientoChanged +=new EventHandler(_comprobanteDeCompra_FechaVencimientoChanged);
			_comprobanteDeCompra.DiasVencimientoChanged +=new EventHandler(_comprobanteDeCompra_DiasVencimientoChanged);
			_comprobanteDeCompra.IdCuentaImputacionChanged +=new EventHandler(_comprobanteDeCompra_IdCuentaImputacionChanged);
			_comprobanteDeCompra.NetoChanged +=new EventHandler(_comprobanteDeCompra_NetoChanged);
			_comprobanteDeCompra.TipoDeComprobanteDestinoChanged +=new EventHandler(_comprobanteDeCompra_TipoDeComprobanteDestinoChanged);*/
			
		}

		private void _brClass_FechaRecepcionMercaderiaChanged(object sender, EventArgs e)
		{
			if(FechaRecepcionMercaderiaChanged != null)
				FechaRecepcionMercaderiaChanged(this, new EventArgs());
		}	
	
		private void _brClass_DiasDemoraEntregaChanged(object sender, EventArgs e)
		{
			if(DiasDemoraEntregaChanged != null)
				DiasDemoraEntregaChanged(this, new EventArgs());
		}


		public void RefreshData()
		{
			
		}

		private void ListenerObjectHasChanged(object sender, System.EventArgs e)
		{
			CallRefresh();
		}
		
		/*public void processEventChange(object sender, EventArgs e)
		{
			if ((sender.GetType()) == typeof(System.Collections.ArrayList))
			{
				ProcessItemComprobante( (ArrayList)sender);
			}
		}*/
		
		/*private void ProcessItemComprobante( ArrayList lista )
		{
			_comprobanteDeVenta.Items.ClearCache();
			foreach ( mz.erp.businessrules.comprobantes.Item item in lista )
			{
				mz.erp.businessrules.comprobantes.ItemComprobante _miItemComprobante = new ItemComprobante( "NEW", _comprobanteDeVenta.Items, item );
				_comprobanteDeVenta.Items.AddInCache( _miItemComprobante );
			}
			_comprobanteDeVenta.Items.FlushCache();
		}

		public void OnRecalcularItems()
		{
			this._comprobanteDeVenta.Items.OnRecalcularItems();
		}

		public ItemComprobante ConvertToItem(object item)
		{
			return (ItemComprobante)item;
		}*/

		/// <summary>
		/// Esta propiedad no deberia ser publica. No deberia ser usada nunca. Al que intente usarla se le estirpara 
		/// de a uno por uno, los dedos de la mano derecha, y de la izquierda para aquel q sea zurdo.
		/// Esta variable solo esta pq no se ha hecho el controlador pa el formulario FrmABMComprobantesProductos.
		/// </summary>
		/*public ComprobanteDeVenta Comprobante
		{
			get {  return _comprobanteDeVenta ;}
		}*/
		
		private void InitializeData()
		{
			SetLayoutDetalle();	
			this._responsableDeEmision = _comprobanteDeCompra.IdResponsable;
			this._keyValueProveedores = _comprobanteDeCompra.IdProveedor;
			this._keyValueTiposDeComprobantes = _comprobanteDeCompra.TipoComprobanteDestino;
			this._campoAuxiliar1 = _comprobanteDeCompra.CampoAuxiliar1;
			this._campoAuxiliar2 = _comprobanteDeCompra.CampoAuxiliar2;
			this._campoAuxiliar3 = _comprobanteDeCompra.CampoAuxiliar3;
			this._campoAuxiliar4 = _comprobanteDeCompra.CampoAuxiliar4;
			this._fechaRegistracion = _comprobanteDeCompra.FechaRegistracion;
			this._fecha = _comprobanteDeCompra.FechaComprobante;
			this._observaciones = _comprobanteDeCompra.Observaciones;
			this._mascara = _comprobanteDeCompra.Mascara;
        	this._total = _comprobanteDeCompra.Total;
			this._numeroComprobante = _comprobanteDeCompra.Numero;
			this._idMonedaOrigen = _comprobanteDeCompra.IdMonedaOrigen;
			this._idFuenteDeCambioProveedor = _comprobanteDeCompra.IdFuenteDeCambioProveedor;
			this._valorCotizacionProveedor = _comprobanteDeCompra.ValorCotizacionProveedor;
			SetLeyendaFormulario();
			_enabledButtonCuentaCtaCte = Variables.GetValueBool(this._comprobanteDeCompra.GetProcessManagerParent().Process.ProcessName, this._comprobanteDeCompra.GetTaskName(), "Proveedor.HabilitaBotonCtaCte", _enabledButtonCuentaCtaCte);

		}
		private void SetLeyendaFormulario()
		{
			string leyenda = Variables.GetValueString( "Momentos." + this._comprobanteDeCompra.GetTaskName()+"." + this._comprobanteDeCompra.GetProcessManagerParent().Process.ProcessName +".LeyendaFormulario" );
			if (leyenda.Equals(string.Empty))
			{
				leyenda = Variables.GetValueString( "Momentos." + this._comprobanteDeCompra.GetTaskName() +".LeyendaFormulario" );
			}
			if (leyenda.Equals(string.Empty))
			{
				leyenda = this._comprobanteDeCompra.GetTaskName();
			}
			this._leyendaFormulario = leyenda;
		}



		private void SetEditable()
		{	//si el proceso actual es "procesoPrevenderVender" retorna false, sino true.
			//this._editable = (this._comprobanteDeVenta.IsEditable());	
		}
		
		private void SetLayoutDetalle()
		{
			ArrayList _buildedarray = new ArrayList();
			_buildedarray.Add("Codigo");
			_buildedarray.Add("Cantidad");
			_buildedarray.Add("Descripcion");
			string[] _campos = (string[])_buildedarray.ToArray( typeof( string ) ) ;			
			_layoutDetalle = mz.erp.ui.controllers.ComprobantesDeCompra.GetLayoutDetalle( _campos );
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

		public string GetTaskName()
		{
			return _comprobanteDeCompra.GetTaskName();
		}


		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_comprobanteDeCompra.GetTaskName());
		}

		public bool IsLastTask()
		{					
			return this._processManager.IsLastTask(_comprobanteDeCompra.GetTaskName());
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
			return _comprobanteDeCompra.AllowPrevious();
		}

		public void Previous()
		{
			_comprobanteDeCompra.Previous();
		}


		public ITask GetTask()
		{
			// TODO: agregar la implementación ComprobantesDeVentaController.GetTask
			return null;
		}

		public void Execute()
		{
			// TODO: agregar la implementación ComprobantesDeVentaController.Execute
			_comprobanteDeCompra.Execute();
		}

		public bool AllowShow()
		{
            //German 20110310 - Tarea 00000038
            return _comprobanteDeCompra.AllowShow();
            //Fin German 20110310 - Tarea 00000038
		}
		
		public event EventHandler OnTaskBeforeExecute;
		public void ListenerAfterExecute( object sender, System.EventArgs e)
		{
			/*if (OnTaskAfterExecute != null)
			{
				OnTaskAfterExecute( this, new System.EventArgs() );
			}*/
		}
		public ItemsDatasetErrors GetErrors()
		{
			return 	_comprobanteDeCompra.GetErrors();
		}
		public string GetWarnings()
		{
			return 	_comprobanteDeCompra.GetWarnings();
		}
		public void Continue()
		{
			_comprobanteDeCompra.Execute();
		}

									   
		#endregion

		#region Miembros de IObserver

		public void UpdateObject(object sender, object valores)
		{
			if ((valores.GetType()) == typeof(System.Collections.ArrayList))
			{
				ProcessItemComprobante( (ArrayList)valores);
			}
		}
		private void ProcessItemComprobante( ArrayList lista )
		{
			_comprobanteDeCompra.AddItems(lista);
		}



		#endregion

		#region Métodos  Públicos 
		public void RemoveItem (businessrules.comprobantes.ItemComprobanteCompra item)
		{
			_comprobanteDeCompra.RemoveItem(item);
		}
		#endregion

		public string FillNumberWithZeros(string txt)
		{
			return _comprobanteDeCompra.FillNumberWithZeros(txt);
		}

		private void _comprobanteDeCompra_AddItemsChanged(object sender, EventArgs e)
		{
			if(AddItemsChanged != null)
				AddItemsChanged(this, new EventArgs());
		}

		//German 20090407
		private void _comprobanteDeCompra_ItemsChanged(object sender, EventArgs e)
		{
			if(ItemsChanged != null)
				ItemsChanged(this, new EventArgs());
		}
		//Fin German 20090407
	}
}

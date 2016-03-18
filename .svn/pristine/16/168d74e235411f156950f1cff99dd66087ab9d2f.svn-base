using System;
using System.Data;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.commontypes.data;


namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Descripción breve de ComprobanteDeCompraCabecera.
	/// </summary>
	public class ComprobanteDeCompraCabecera
	{
		public void UpdateDataFromProveedor(Proveedor proveedor)
		{
			_comprobante.UpdateDataFromProveedor(proveedor);
			_idCuentaImputacion = proveedor.IdCuentaImputacion == null || proveedor.IdCuentaImputacion.Equals(string.Empty)? _idCuentaImputacion : proveedor.IdCuentaImputacion ;
			_idSubCuentaImputacion = proveedor.IdSubcuentaImputacion == null || proveedor.IdSubcuentaImputacion.Equals(string.Empty) ? _idSubCuentaImputacion : proveedor.IdSubcuentaImputacion ;
			if(IdCuentaImputacionProveedorChanged != null)
				IdCuentaImputacionProveedorChanged(this, new EventArgs());
			if(IdSubCuentaImputacionProveedorChanged != null)
				IdSubCuentaImputacionProveedorChanged(this, new EventArgs());
			ActualizarConceptosAsociados();
						 
		}
		
		public ComprobanteDeCompraCabecera()
		{
			_comprobante = new ComprobanteDeCompra();
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_comprobante.SetProcessManagerParent(processManager);
		}

		public void SetTaskName(string taskName)
		{
			_comprobante.SetTaskName(taskName);
		}


		private decimal _netoGravado = 0;
		private decimal _netoServicio = 0;
		private decimal _gastoGravado = 0;

		public decimal GastoGravado
		{
			get{return _gastoGravado;}
		}

		public decimal NetoGravado
		{
			get{return _netoGravado;}
		}
		public decimal NetoServicio
		{
			get{return _netoServicio;}
		}


		public void Edit(string IdComprobante)
		{

			//Cuando baje lo de Sabrina deberia descomentar la siguiente linea
			//_comprobante.Edit(IdComprobante)
			

			_comprobante.Edit(IdComprobante);
			_isEdit = true;
            
			tpu_ComprobantesDeCompraDataset.tpu_ComprobantesDeCompraRow CompOrigenCab = businessrules.tpu_ComprobantesDeCompra.GetByPk(IdComprobante);					
			if (CompOrigenCab != null)
			{
				this._idCuentaImputacion = CompOrigenCab.IdTipoMovimiento;
				this._idSubCuentaImputacion = CompOrigenCab.IdSubtipoMovimiento;
				this._CAI = CompOrigenCab.CAI;
				this._leyenda = CompOrigenCab.Leyenda;					
				this._mesDeImputacion = Convert.ToString(CompOrigenCab.MesImputacion) + "/" + Convert.ToString(CompOrigenCab.AñoImputacion);
				this._mesDeDevengamiento = Convert.ToString(CompOrigenCab.MesDevengamiento) + "/" + Convert.ToString(CompOrigenCab.AñoDevengamiento);
				this._mesDeDevengamientoOriginal = Convert.ToString(CompOrigenCab.MesDevengamiento) + "/" + Convert.ToString(CompOrigenCab.AñoDevengamiento);
				this._fechaVencimiento = CompOrigenCab.FechaVencimiento;
				this._netoBruto = CompOrigenCab.NetoBruto;
				this._descuentos = CompOrigenCab.Descuento;
				this._neto = CompOrigenCab.SubtotalNeto;
				this._totalGeneral = CompOrigenCab.TotalGeneral;
				this._totalUsuario =  CompOrigenCab.Total;
				this._impuestos = this._totalGeneral - this._neto;
				this._descuentoGeneral = CompOrigenCab.DescuentoGeneral;
				this._total = CompOrigenCab.Total;
				this._netoGravado = CompOrigenCab.NetoGravado;
				this._netoServicio = CompOrigenCab.ServicioGravado;
				this._gastoGravado = CompOrigenCab.GastoGravado;
				this.TipoComprobanteDestino = CompOrigenCab.IdTipoDeComprobante;
				this.Numero = CompOrigenCab.Numero;
                this._conceptosGravados = new ItemsConcepto();
				this._conceptosNOGravados = new ItemsConcepto();

				DataSet comprobantesImpuestos = businessrules.tpu_ComprobantesImpuestos.GetListEx(IdComprobante);
				foreach (DataRow row in comprobantesImpuestos.Tables[0].Rows)
				{				
					ItemConcepto ic = new ItemConcepto();
					ic.IdConcepto = Convert.ToString(row["IdNeto"]);
					ic.Concepto = Convert.ToString(row["DescripcionNeto"]);
					ic.IdImpuesto = Convert.ToString(row["IdImpuesto"]);
					ic.Impuesto = Convert.ToString(row["DescripcionImpuesto"]);
					ic.MontoNeto = Convert.ToDecimal(row["ValorNeto"]);
					ic.MontoImpuesto = Convert.ToDecimal(row["ValorImpuesto"]);
					ic.PorcentajeImpuesto = Convert.ToDecimal(row["PorcentajeAplicado"]);
					ic.Familia = Convert.ToString(row["Familia"]);
					ic.FamiliaImp = Convert.ToString(row["FamiliaImp"]);
					ic.ValorCotizacion = Convert.ToDecimal(row["ValorCotizacionProveedor"]);					

					if (Convert.ToBoolean(row["EsGravado"]))
						this._conceptosGravados.Add(ic);
					else
						this._conceptosNOGravados.Add(ic);
				}
			}
		}

		public void StepEdit(RelacionesComprobanteDeCompraOrigenDestino relaciones)
		{			
			this._isStep = false;
			this._isEdit = true;
			_comprobante.StepEdit(relaciones);
			_comprobante.TrasladaNumero = true;
			this.Numero = relaciones.Numero;
			this._idCuentaImputacion = relaciones.IdCuentaImputacion == null || relaciones.IdCuentaImputacion.Equals(string.Empty)? _comprobante.Proveedor.IdCuentaImputacion: relaciones.IdCuentaImputacion ;
			this._idSubCuentaImputacion = relaciones.IdSubCuentaImputacion == null || relaciones.IdSubCuentaImputacion.Equals(string.Empty)? _comprobante.Proveedor.IdSubcuentaImputacion : relaciones.IdSubCuentaImputacion;	
			if(IdCuentaImputacionProveedorChanged != null)
				IdCuentaImputacionProveedorChanged(this, new EventArgs());
			if(IdSubCuentaImputacionProveedorChanged != null)
				IdSubCuentaImputacionProveedorChanged(this, new EventArgs());		
			this._CAI = relaciones.CAI;
			this._leyenda = relaciones.Leyenda;					
			this._mesDeImputacion = relaciones.MesDeImputacion;
			this._mesDeDevengamiento = relaciones.MesDeDevengamiento;
			if(relaciones.IsValidFecheVencimiento)
				this._fechaVencimiento = relaciones.FechaVencimiento;
			else
			{
				DateTime aux = mz.erp.systemframework.Util.GetStartDay(_comprobante.FechaComprobante);
				this.FechaVencimiento = aux.AddDays(_comprobante.DiasVencimientoPago);
			}
			this._proximaFechaVencimiento = relaciones.FechaProximoVencimiento;
			this._netoBruto = relaciones.NetoBruto;
			this._descuentos = relaciones.Descuentos;
			this._neto = relaciones.Neto;
			this._impuestos = relaciones.Impuestos;
			this._descuentoGeneral = relaciones.DescuentoGeneral;
			this._totalGeneral = relaciones.TotalGeneral;
			this._total = relaciones.Total;
			this._totalUsuario = relaciones.TotalGeneral;
			this._conceptosGravados = new ItemsConcepto(relaciones.ConceptosGravados);
			this._conceptosNOGravados = new ItemsConcepto(relaciones.ConceptosNoGravados);
			RecalcularTotal();

			this._comprobante.CampoAuxiliar1 = string.Empty;
			ActualizarItems();
			ActualizarCotizacionConceptos();
			ActualizarConceptosAsociados();
			
			if(_actualizaEstadoFactura && !relaciones.MultiplesOrigenes)
			{
				_facturaState = relaciones.Factura;
				_facturaState.IdComprobanteFactura = _comprobante.IdComprobante;
				
			}
			
		}		

		

		public void Step(RelacionesComprobanteDeCompraOrigenDestino relaciones)
		{			
			this._isStep = true;
			this._isEdit = false;
			_comprobante.Step(relaciones);
			_comprobante.TrasladaNumero = true;
			this.Numero = relaciones.Numero;
			this._idCuentaImputacion = relaciones.IdCuentaImputacion == null || relaciones.IdCuentaImputacion.Equals(string.Empty)? _comprobante.Proveedor.IdCuentaImputacion: relaciones.IdCuentaImputacion ;
            this._idSubCuentaImputacion = relaciones.IdSubCuentaImputacion == null || relaciones.IdSubCuentaImputacion.Equals(string.Empty)? _comprobante.Proveedor.IdSubcuentaImputacion : relaciones.IdSubCuentaImputacion;	
			if(IdCuentaImputacionProveedorChanged != null)
				IdCuentaImputacionProveedorChanged(this, new EventArgs());
			if(IdSubCuentaImputacionProveedorChanged != null)
				IdSubCuentaImputacionProveedorChanged(this, new EventArgs());		
			this._CAI = relaciones.CAI;
			this._leyenda = relaciones.Leyenda;					
			this._mesDeImputacion = relaciones.MesDeImputacion;
			this._mesDeDevengamiento = relaciones.MesDeDevengamiento;
			if(relaciones.IsValidFecheVencimiento)
				this._fechaVencimiento = relaciones.FechaVencimiento;
			else
			{
				DateTime aux = mz.erp.systemframework.Util.GetStartDay(_comprobante.FechaComprobante);
				this.FechaVencimiento = aux.AddDays(_comprobante.DiasVencimientoPago);
			}
			this._proximaFechaVencimiento = relaciones.FechaProximoVencimiento;
			this._netoBruto = relaciones.NetoBruto;
			this._descuentos = relaciones.Descuentos;
			this._neto = relaciones.Neto;
			this._impuestos = relaciones.Impuestos;
			this._descuentoGeneral = relaciones.DescuentoGeneral;
			this._totalGeneral = relaciones.TotalGeneral;
			this._total = relaciones.Total;
			this._totalUsuario = relaciones.TotalGeneral;
			this._conceptosGravados = new ItemsConcepto(relaciones.ConceptosGravados);
			this._conceptosNOGravados = new ItemsConcepto(relaciones.ConceptosNoGravados);
			RecalcularTotal();

			this._comprobante.CampoAuxiliar1 = string.Empty;
			ActualizarItems();
			ActualizarCotizacionConceptos();
			ActualizarConceptosAsociados();
			
			if(_actualizaEstadoFactura && !relaciones.MultiplesOrigenes)
			{
				_facturaState = relaciones.Factura;
			}
			
		}		

		private void ActualizarItems()
		{
			foreach(ItemComprobanteCompra item in this.Items)
			{
				item.PrecioCompraOriginal = item.PrecioDeCosto;
				item.CantidadCompraOriginal = item.Cantidad;
			}
		}

        //Cristian Tarea 879
        //German 20101111 - Tarea 933
        public void updateConcepto(String idConcepto,string IdImpuesto, decimal valorImpuestoModificar)
        //Fin German 20101111 - Tarea 933
        {
            foreach (ItemConcepto it in this.ConceptosGravados)
            {
                //German 20101111 - Tarea 933
                if (it.IdConcepto.Equals(idConcepto) && it.IdImpuesto.Equals(IdImpuesto))
                //Fin German 20101111 - Tarea 933
                {
                    it.MontoImpuesto = valorImpuestoModificar;
                    it.MontoNeto = Decimal.Round((it.MontoImpuesto * 100 / it.PorcentajeImpuesto),2);

                }

            }

            //German 20101105 - Tarea 879
            RecalcularTotal();
            //Fin German 20101105 - Tarea 879
        }
        //Fin Tarea 879

        //German Tarea 879
        //German 20101111 - Tarea 93
        public void updateImpuesto(String idConcepto, String IdImpuesto, decimal valorNetoModificar)
        //Fin German 20101111 - Tarea 93
        {
            foreach (ItemConcepto it in this.ConceptosGravados)
            {
                //German 20101111 - Tarea 933
                if (it.IdConcepto.Equals(idConcepto) && it.IdImpuesto.Equals(IdImpuesto))
                //Fin German 20101111 - Tarea 933
                {
                    it.MontoNeto = valorNetoModificar;
                    it.MontoImpuesto = it.MontoNeto * it.PorcentajeImpuesto / 100;
                }

            }
            RecalcularTotal();

        }
        //Fin Tarea 879
		public void Init()
		{				
			InitData();
			InitEventHandlers();
			SetEditablesProperty();								
		}

		private void InitData()
		{
				
			_actualizaEstadoFactura = Variables.GetValueBool(_comprobante.ProcessName(), _comprobante.GetTaskName(), "ActualizaEstadoFactura");
			_transicionesDeEstados = Variables.GetValueString(_comprobante.ProcessName(), _comprobante.GetTaskName(), "TransicionesDeEstados");
			_comprobante.Init();
			_comprobante.TrasladaNumero = true;
			_autorizada = Variables.GetValueBool(_comprobante.ProcessName(), _comprobante.GetTaskName(), "AutorizaPorDefault");
			
		}

		private void InitEventHandlers()
		{
			_comprobante.TipoDeComprobanteDestinoChanged+=new EventHandler(_comprobante_TipoDeComprobanteDestinoChanged);			
			_comprobante.IdMonedaOrigenChanged +=new EventHandler(_comprobante_IdMonedaOrigenChanged);
			_comprobante.Items.NetoItemsOriginalChanged +=new EventHandler(Items_NetoItemsOriginalChanged);
			_comprobante.CondicionDeCompraChanged +=new EventHandler(_comprobante_CondicionDeCompraChanged);

		}
		private void SetEditablesProperty()
		{
		}

		#region Variables Privadas ComprobanteDeCompraCabecera		
		
		private ComprobanteDeCompra _comprobante;
		private tpu_ComprobantesDeCompraDataset _dataComprobantes = new tpu_ComprobantesDeCompraDataset();
		private tpu_ComprobantesImpuestosDataset _dataComprobantesImp = new tpu_ComprobantesImpuestosDataset();
		private tpu_ComprobantesDeCompraDetDataset _dataComprobantesDet = new tpu_ComprobantesDeCompraDetDataset();
		private tpu_ComprobanteDetalleDeudaDataset _dataComprobantesDD = new tpu_ComprobanteDetalleDeudaDataset();
		private mz.erp.commontypes.SentenciasReplicacion _replication;
		private bool _isStep = false;
		private bool _isEdit = false;
		private string _mascaraNumeroDefault= string.Empty;		
		private string _idCotizacionCierre = string.Empty;		
		private string _idFuenteDeCambioReferencia = string.Empty;
		private Cotizacion _cotizacionCierre = null;
		private bool _allowConceptosRepetidos = false;
				

		#endregion
		#region Eventos y delegados
		public event EventHandler FechaVencimientoChanged;
		public event EventHandler DiasVencimientoChanged;
		public event EventHandler IdCuentaImputacionProveedorChanged;//Utilizo este evento cuando la cuenta de imputación se modifica al cambiar el proveedor y para que sea distinto de cuando el cambio de la cuenta de imputación modifica las subcuentas de imputación.
		public event EventHandler IdSubCuentaImputacionProveedorChanged;
		public event EventHandler TipoDeComprobanteDestinoChanged;
		public event EventHandler NetoChanged;
		public event EventHandler TotalChanged;
		public event EventHandler IdMonedaOrigenChanged;
		public event EventHandler TotalUsuarioChanged;
		public event EventHandler NetoItemsOriginalChanged;
		public event EventHandler CondicionDeCompraChanged;

		#endregion
		#region Propiedades ComprobanteDeCompra

		public int DiasVencimientoPago
		{
			get{return Convert.ToInt32(_comprobante.DiasVencimientoPago);}
		}

		public string IdCondicionDeCompra
		{
			get{return _comprobante.IdCondicionDeCompra;}
			set
			{
				_comprobante.IdCondicionDeCompra = value;
			}
		}

		public decimal NetoItemsOriginal
		{
			get
			{
				return _comprobante.NetoOriginal;
			}
		}

		public decimal NetoItems
		{
			get
			{
				return _comprobante.Neto;

			}
		}


		public string IdMonedaOrigen
		{
			get{return _comprobante.IdMonedaOrigen;}
			set
			{
				if(_comprobante.IdMonedaOrigen != value)
				{
					_comprobante.IdMonedaOrigen = value;
				}
			}
		}

		public string SimboloMonedaOrigen
		{
			get
			{
				return _comprobante.SimboloMonedaOrigen;
			}
			set
			{
				_comprobante.SimboloMonedaOrigen = value;
			}
		}

		public string SimboloMonedaCierre
		{
			get
			{
				return _comprobante.SimboloMonedaCierre;
			}
		}


		public string IdFuenteDeCambioProveedor
		{
			get{return _comprobante.IdFuenteDeCambioProveedor;	}
			set
			{
				if(value != _comprobante.IdFuenteDeCambioProveedor)
				{
					_comprobante.IdFuenteDeCambioProveedor = value;
				}
			}		
		}
		
		public Cotizacion CotizacionProveedor
		{
			get{return _comprobante.CotizacionProveedor;}
		}

		
		public decimal ValorCotizacionProveedor
		{
			get
			{
				return _comprobante.ValorCotizacionProveedor;
			}
			set
			{
				_comprobante.ValorCotizacionProveedor = value;
				ActualizarCotizacionConceptos();
			}
		}
		

		public bool AllowConceptosRepetidos
		{
			get
			{
				return _allowConceptosRepetidos;
			}
			set
			{
				_allowConceptosRepetidos = value;
			}
		}

		//German 20090422
		public bool AllowValidateItems
		{
			get
			{
				return _comprobante.AllowValidateItems;
			}
		}
		//Fin German 20090422

		public DataTable TableTiposDeComprobantesValidos
		{
			get
			{
				return _comprobante.TableTiposDeComprobantesValidos;
			}
		}

		public string Mascara 
		{
			get{return _comprobante.Mascara;}
		}
	
	
		public bool CategoriaImpositivaProveedorAfectaTipoDeComprobanteDestino
		{
			set { _comprobante.CategoriaImpositivaProveedorAfectaTipoDeComprobanteDestino = value;}
		}

		public decimal ValorCotizacion 
		{
			get
			{
				if(_cotizacionCierre != null)
				{
					return _cotizacionCierre.Valor;
				}
				return 1;
			}
		}


		public string IdCotizacionCierre
		{
			get
			{
				if(_cotizacionCierre != null)
					return _cotizacionCierre.IdCotizacion;
				return string.Empty;
			}
		}
	
		
		public Proveedor Proveedor
		{
			get{return _comprobante.Proveedor;}
		}

		//private string _idResponsable = string.Empty;
		public string IdResponsable
		{
			get{return _comprobante.IdResponsable;}
			set
			{
				if(_comprobante.IdResponsable != value)
				{
					_comprobante.IdResponsable = value;
					/*if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());*/
				}

			}
		}

		/*public string IdProveedor
		{
			get
			{
				if(_proveedor != null)
					return _proveedor.IdProveedor;
				else return string.Empty;
			}
			set
			{
				if(_proveedor != null)
				{
					if(_proveedor.IdProveedor != value)
					{
						_proveedor.IdProveedor = value;
						//if(ObjectHasChanged != null)
						//	ObjectHasChanged(this, new EventArgs());
					}
				}
			}
		}*/


		/*public string Observaciones
		{
			get{return _observaciones;}
			set
			{
				if(_observaciones!= value)
				{
					_observaciones = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
			}
		}*/
		
		public string Numero
		{
			get{return _comprobante.Numero;}
			set
			{
				if(_comprobante.Numero != value)
				{
					_comprobante.Numero = value;
					/*if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());*/
				}		
			}
		}
		
//		public string CampoAuxiliar1
//		{
//			get{return _comprobante.CampoAuxiliar1;}
//			set
//			{
//				if(_comprobante.CampoAuxiliar1 != value)
//				{
//					_comprobante.CampoAuxiliar1 = value;
//					/*if(ObjectHasChanged != null)
//						ObjectHasChanged(this, new EventArgs());*/					
//				}
//			}
//		}

		/*public string CampoAuxiliar2
		{
			get{return _campoAuxiliar2;}
			set
			{
				if(_campoAuxiliar2 != value)
				{
					_campoAuxiliar2 = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
					
				}
			}
		}

		public string CampoAuxiliar3
		{
			get{return _campoAuxiliar3;}
			set
			{
				if(_campoAuxiliar3 != value)
				{
					_campoAuxiliar3 = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
					

				}
			}
		}

		public decimal CampoAuxiliar4
		{
			get{return _campoAuxiliar4;}
			set
			{
				if(_campoAuxiliar4 != value)
				{
					_campoAuxiliar4 = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
					
				}
			}
		}*/

		public string TipoComprobanteDestino
		{
			get{return _comprobante.TipoComprobanteDestino;}
			set
			{
				if(_comprobante.TipoComprobanteDestino != value)
				{
					_comprobante.TipoComprobanteDestino = value;
					ActualizarConceptosAsociados();
					/*if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());*/					
				}
			}
		}


		/*public string NombreCampo1
		{
			get{return _comprobante.NombreCampo1;}
		}

		public string NombreCampo2
		{
			get{return _comprobante.NombreCampo2;}
		}

		public string NombreCampo3
		{
			get{return _comprobante.NombreCampo3;}
		}

		public string NombreCampo4
		{
			get{return _comprobante.NombreCampo4;}
		}*/

		public ItemsComprobantesCompra Items
		{
			get { return this._comprobante.Items; }
			set { this._comprobante.Items = value; }
		}

		private bool _autorizada = true;
		public bool Autorizada
		{
			get { return _autorizada; }
			set { _autorizada = value;}
		}
		
		
		#endregion
		#region Propiedades ComprobanteDeCompraCabecera

		private bool _actualizaEstadoFactura = false;
		private string _transicionesDeEstados = string.Empty;
		private FacturaDeCompraItems _facturaState = null;
		
		private DataTable _tableCuentasDeImputacion;
		public DataTable TableCuentasDeImputacion
		{
			get{return _tableCuentasDeImputacion;}
		}

		private DataTable _tableSubcuentasDeImputacion = new DataTable();
		public DataTable TableSubcuentasDeImputacion
		{
			get{return _tableSubcuentasDeImputacion;}
		}

		private string _idCuentaImputacion = string.Empty;
		public  string IdCuentaImputacion 
		{
			get{return _idCuentaImputacion;}
			set{_idCuentaImputacion = value;}
		}

		private string _idSubCuentaImputacion = string.Empty;
		public string IdSubCuentaImputacion
		{
			get{return _idSubCuentaImputacion;}
			set{_idSubCuentaImputacion = value;	}
		}

		private string _CAI = string.Empty;
		public string CAI
		{
			get{return _CAI;}
			set{_CAI = value;}
		}

		private string _leyenda = "";
		public string Leyenda 
		{
			get{return _leyenda;}			
			set{_leyenda = value;}
		}

		public string Observaciones
		{
			get{return _comprobante.Observaciones;}
			set{_comprobante.Observaciones = value;}
		}

		private int _diasVencimiento = 0;
		public int DiasVencimiento
		{
			get{return _diasVencimiento;}
			set{_diasVencimiento = value;}
		}		
		
		public DateTime FechaRegistracion
		{
			get{return _comprobante.FechaRegistracion;}
			set{_comprobante.FechaRegistracion = value;}
		}		
		public DateTime FechaComprobante
		{
			get{return _comprobante.FechaEmision;}
			set{ _comprobante.FechaEmision = value;}
		}

		private DateTime _fechaVencimiento = mz.erp.businessrules.Sistema.DateTime.Now;
		public DateTime FechaVencimiento
		{
			get{return _fechaVencimiento;}
			set{_fechaVencimiento = value;}
		}

		private DateTime _proximaFechaVencimiento = mz.erp.businessrules.Sistema.DateTime.Now;
		public DateTime ProximaFechaVencimiento
		{
			get{return _proximaFechaVencimiento;}
			set{_proximaFechaVencimiento = value;}
		}


		private string _mesDeImputacion = string.Empty;
		public string MesDeImputacion
		{
			get{return _mesDeImputacion;}
			set{_mesDeImputacion = value;}
		}

		private string _mesDeDevengamiento = string.Empty;
		public string MesDeDevengamiento
		{
			get{return _mesDeDevengamiento;}
			set{_mesDeDevengamiento = value;}
		}

		private string _mesDeDevengamientoOriginal = string.Empty;
		public string MesDeDevengamientoOriginal
		{
			get{return _mesDeDevengamientoOriginal;}
			set{_mesDeDevengamientoOriginal = value;}
		}

		private decimal _netoBruto = 0;
		public decimal NetoBruto
		{
			get{return _netoBruto;}
			set
			{
				if(_netoBruto != value)
				{
					_netoBruto = value;
					_neto = _netoBruto + _descuentos;										
					this.RecalcularTotal();
					/*if(NetoChanged != null)
						NetoChanged(this, new EventArgs());*/
				}
			}
		}

		private decimal _descuentos = 0;
		public decimal Descuentos 
		{
			get{return _descuentos;}
			set
			{
				if(_descuentos != value)
				{
					_descuentos = value;
					if(_netoBruto > 0)
					{
						_neto = _netoBruto + _descuentos;
						_porcentajeDescuento = _descuentos * 100 / _netoBruto; 
						this.RecalcularTotal();
						/*if(NetoChanged != null)
							NetoChanged(this, new EventArgs());*/
					}
				}
			}
		}
			
		private decimal _porcentajeDescuento = 0;
		public decimal PorcentajeDescuentos 
		{
			get{return _porcentajeDescuento;}
			set
			{
				if(_porcentajeDescuento != value)
				{
					_porcentajeDescuento = value;
					if(_netoBruto > 0)
					{
						_descuentos = _porcentajeDescuento * _netoBruto / 100; 
						_neto = _netoBruto + _descuentos;
						this.RecalcularTotal();
						/*if(NetoChanged != null)
							NetoChanged(this, new EventArgs());*/
					}					
				}
			}
		}
		
		private decimal _total = 0;
		public decimal Total
		{
			get{return _total;}			
		}	

		private decimal _neto = 0;
		public decimal Neto 
		{
			get{return _neto;}
			set{_neto = value;}
		}		
	
		private decimal _totalGeneral = 0;
		public decimal TotalGeneral 
		{
			get{return _totalGeneral;}			
		}	
		private decimal _descuentoGeneral = 0;
		public decimal DescuentoGeneral 
		{
			get{return _descuentoGeneral;}	
			set 
			{
				if(_descuentoGeneral != value)
				{
					_descuentoGeneral = value;
					if(_totalGeneral > 0)
					{								
						_total = _totalGeneral + _descuentoGeneral;						
						_porcentajeDescuentoGeneral = _descuentoGeneral * 100 / _totalGeneral; 						
						if(TotalChanged != null)
							TotalChanged(this, new EventArgs());
					}
				}
			}
		}	
		
		private decimal _porcentajeDescuentoGeneral = 0;
		public decimal PorcentajeDescuentoGeneral
		{
			get{return _porcentajeDescuentoGeneral;}
			set
			{
				if(_porcentajeDescuentoGeneral != value)
				{
					_porcentajeDescuentoGeneral = value;
					_descuentoGeneral = _totalGeneral * _porcentajeDescuentoGeneral / 100;												
					_total = _totalGeneral + _descuentoGeneral;
					if(TotalChanged != null)
						TotalChanged(this, new EventArgs());
				}
			}
		}

		private decimal _impuestos = 0;
		public decimal Impuestos 
		{
			get{return _impuestos;}			
			set
            {
				_impuestos = value;
			}
		}	
	
		
		public decimal TotalUsuarioMonedaReferencia
		{
			get
			{
				return _totalUsuario * _comprobante.ValorCotizacionProveedor;
			}			
		}

		private decimal _totalUsuario = 0;
		public decimal TotalUsuario 
		{
			get{return _totalUsuario;}
			set
			{
				if(_totalUsuario != value)
				{
					_totalUsuario = value;
					_impuestos = _totalUsuario - _neto;
					if(TotalUsuarioChanged != null)
						TotalUsuarioChanged(this, new EventArgs());

				}
			}
		}

        //German 20101104 - Tarea 876
        /*Esta propiedad el total de impuestos por conceptos Gravados y NO Gravados
         * */
        public decimal TotalImpuestos
        {
            get
            {
                decimal ImpuestosAplicadosNetosGravados = 0;
                decimal ImpuestosAplicadosNetosNoGravados = 0;
                ImpuestosAplicadosNetosGravados = _conceptosGravados.GetImpuestos();
                ImpuestosAplicadosNetosNoGravados = _conceptosNOGravados.GetImpuestos();
                return ImpuestosAplicadosNetosGravados + ImpuestosAplicadosNetosNoGravados ;

            }
        }
        //876 German 20101104 - Tarea 876

		/*Esta propiedad representa el total del comprobante de compra desde el punto de vista de los impuesto
		 * Este mismo deberia coincidir con el total obtenido a partir de los items de comprobante y con el total 
		 *  ingresado por el usuario
		 * */
		public decimal TotalImpositivo
		{
			get
			{
				decimal NetosGravados = 0;
				decimal NetosNoGravados = 0;
				decimal ImpuestosAplicadosNetosGravados = 0;
				decimal ImpuestosAplicadosNetosNoGravados = 0;
				NetosGravados = _conceptosGravados.GetNeto();
				NetosNoGravados = _conceptosNOGravados.GetNeto();
				ImpuestosAplicadosNetosGravados = _conceptosGravados.GetImpuestos();
				ImpuestosAplicadosNetosNoGravados = _conceptosNOGravados.GetImpuestos();
				return NetosGravados + ImpuestosAplicadosNetosGravados + NetosNoGravados + ImpuestosAplicadosNetosNoGravados + _descuentoGeneral;

			}
		}

		/*Esta propiedad representa el total del comprobante de compra desde el punto de vista de los items
		 * Este mismo deberia coincidir con el total obtenido a partir de los datos impositivos del comprobante y con el total 
		 *  ingresado por el usuario
		 * */
		public decimal TotalItems
		{
			get
			{
				return this.Items.Total;
			}
		}


		private ItemsConcepto _conceptosGravados = new ItemsConcepto();
		public ItemsConcepto ConceptosGravados
		{
			get{return this._conceptosGravados;}
		}

		private ItemsConcepto _conceptosNOGravados = new ItemsConcepto();
		public ItemsConcepto ConceptosNOGravados
		{
			get{return this._conceptosNOGravados;}
		}

		#endregion
		#region Metodos publicos

		public void RemoveItem (ItemComprobanteCompra item)
		{
			_comprobante.RemoveItem(item);
		}

		public void AddItems(ArrayList items)
		{
			_comprobante.AddItems(items);
		}


		public void UpdateFromIngresarPrecioProducto(IngresarPrecioProducto task)
		{
			
			this._comprobante.UpdateFromIngresarPrecioProducto(task);
			ActualizarCotizacionConceptos();
					
		}

		private void ActualizarCotizacionConceptos()
		{
			
			foreach(ItemConcepto item in this._conceptosGravados)
			{
				item.ValorCotizacion = _comprobante.ValorCotizacionProveedor;
			}
			foreach(ItemConcepto item in this._conceptosNOGravados)
			{
				item.ValorCotizacion = _comprobante.ValorCotizacionProveedor;
			}
		}

		public bool IsValidCondicionDeCompra()
		{
			return _comprobante.IsValidCondicionDeCompra();
		}

		public bool IsValidNetoAcumulado()
		{
			/*
			decimal NetoAcumulado = _conceptosGravados.GetNeto() + _conceptosNOGravados.GetNeto();
			return NetoAcumulado <= this._neto;
			*/
			return true;
		}
		public bool IsValidTotalItemsTotalUsuario()
		{
			if(this._comprobante.Items.Count == 0) return true;
			return decimal.Round(_neto,2) == decimal.Round(this.TotalItems,2);
		}


		public bool IsValidTotal()
		{
            /* German 20101019 - Tarea 876 */
			//if(this.ConceptosGravados.Count >0 || this.ConceptosNOGravados.Count > 0)
            /* Fin German 20101019 - Tarea 876 */
                /* Silvina 20101019 - Tarea 876 */
				//return Math.Abs(decimal.Round(_totalUsuario,2) - decimal.Round(this.TotalImpositivo,2)) <= Convert.ToDecimal(0.50);
                return Math.Abs(decimal.Round(_totalUsuario, 2) - decimal.Round(this.Total, 2)) <= Convert.ToDecimal(0.05);
                /* Fin Silvina */
			return true;
		}

        /* Silvina 20101019 - Tarea 876 */
        public bool IsValidImpuestos()
        {
            /* German 20101019 - Tarea 876 */
            //if (this.ConceptosGravados.Count > 0 || this.ConceptosNOGravados.Count > 0)
            return Math.Abs(decimal.Round(_impuestos, 2) - decimal.Round(this.TotalImpuestos, 2)) <= Convert.ToDecimal(0.05);
            //return true;
            /* Fin German 20101019 - Tarea 876 */
        }

        /* Silvina 20110601 - Tarea 0000147 */
        public bool IsValidFechaProximoVencimiento()
        {
            //German 20120518 - Tarea 0000320
            return (_fechaVencimiento <= _proximaFechaVencimiento);
            //Fin German 20120518 - Tarea 0000320
        }
        /* Fin Silvina 20110601 - Tarea 0000147 */

		public void AddNetoGravado(string IdNetoGravado, string DescripcionNeto, string IdImpuestoAplicado, string DescripcionImpuesto, decimal Neto, decimal  PorcentajeAplicado, decimal ImpuestoAplicado, decimal Total)
		{
			if (!_allowConceptosRepetidos && this._conceptosGravados.Contains(IdNetoGravado, IdImpuestoAplicado)) 
				throw new ConceptoRepetidoException();

			ItemConcepto item = this.CreateItemConcepto(IdNetoGravado, DescripcionNeto,IdImpuestoAplicado,DescripcionImpuesto, Neto, PorcentajeAplicado, ImpuestoAplicado, Total);
			this._conceptosGravados.Add(item);
			RecalcularTotal();
		}

		private ItemConcepto CreateItemConcepto(string IdNetoNOGravado, string DescripcionNeto, string IdImpuestoAplicado, string DescripcionImpuesto, decimal Neto, decimal  PorcentajeAplicado, decimal ImpuestoAplicado, decimal Total)
		{

			ItemConcepto item = new ItemConcepto();
			item.IdConcepto = IdNetoNOGravado;
			item.Concepto = DescripcionNeto;
			item.IdImpuesto = IdImpuestoAplicado;
			item.Impuesto = DescripcionImpuesto;
			item.MontoNeto = Neto;
			item.MontoImpuesto = ImpuestoAplicado;
			item.PorcentajeImpuesto = PorcentajeAplicado;
			item.Familia = businessrules.tpu_Netos.GetFamilia(Convert.ToInt32(item.IdConcepto));
			item.FamiliaImp = businessrules.tpu_NetosImpuestos.GetFamilia(Convert.ToInt32(item.IdConcepto),item.IdImpuesto, _comprobante.TipoComprobanteDestino);
			item.ValorCotizacion = _comprobante.ValorCotizacionProveedor;
			return item;
		}

		public void AddNetoNOGravado(string IdNetoNOGravado, string DescripcionNeto, string IdImpuestoAplicado, string DescripcionImpuesto, decimal Neto, decimal  PorcentajeAplicado, decimal ImpuestoAplicado, decimal Total)
		{
			
			if (!_allowConceptosRepetidos && this._conceptosNOGravados.Contains(IdNetoNOGravado, IdImpuestoAplicado)) 
				throw new ConceptoRepetidoException();
            ItemConcepto item = this.CreateItemConcepto(IdNetoNOGravado, DescripcionNeto,IdImpuestoAplicado,DescripcionImpuesto, Neto, PorcentajeAplicado, ImpuestoAplicado, Total);
			this._conceptosNOGravados.Add(item);
			RecalcularTotal();				
		}

		public DataTable GetPagos()
		{
			return _comprobante.GetPagos();
		}
		
		public void Commit()
		{						
			_comprobante.Commit();
			if(_actualizaEstadoFactura) _facturaState.Commit();
			this.MyCommitCabecera();
			this.MyCommitDetalleDeuda();
			this.MyCommitComprobantesDet();
			this.MyCommitDetalleImpuestos();
			this.MyCommitUpdateConfirmacionDePrecios();
			
		}

		public void GetData(TaskCollectionData data)
		{
			TaskCollectionData dataComp = _comprobante.GetData();
			foreach(DataSet da in dataComp)
			{
				data.Add(da);
			}
			data.Add(_dataConfirmacionDePrecios);
			data.Add(_dataComprobantes);
			data.Add(_dataComprobantesImp);
			data.Add(_dataComprobantesDet);
			data.Add(_dataComprobantesDD);
		}

		#endregion

		private tpu_ComprobantesDeCompraConfirmacionDePreciosDataset _dataConfirmacionDePrecios = new tpu_ComprobantesDeCompraConfirmacionDePreciosDataset();

		private void MyCommitUpdateConfirmacionDePrecios()
		{
			if(_comprobante.IdComprobanteOrigen != null)
			{
				DataRow row = mz.erp.businessrules.tpu_ComprobantesDeCompraConfirmacionDePrecios.GetByPk(_comprobante.IdComprobanteOrigen);
				if(row != null)
				{
					_dataConfirmacionDePrecios.Tables[0].ImportRow(row);
				}
			}

		}

		private void SetValues(tpu_ComprobantesDeCompraDataset.tpu_ComprobantesDeCompraRow row)
		{
			
			string[] mesAño = _mesDeImputacion.Split(new char[]{'/'});
			long Mes = 0;
			long Año = 0;
			if(mesAño.Length == 2)
			{
				Mes = Convert.ToInt64(mesAño[0]);
				Año = Convert.ToInt64(mesAño[1]);
			}
			row.IdComprobante = _comprobante.IdComprobante;
			row.IdTipoDeComprobante = _comprobante.TipoComprobanteDestino;
			row.Numero = _comprobante.Numero;

			DateTime now = mz.erp.businessrules.Sistema.DateTime.Now;

			DateTime fc = _comprobante.FechaEmision;
			DateTime fecha = fc; //DateTime fecha = new DateTime(fc.Year, fc.Month, fc.Day, 0,0,0);
			if ( !_isEdit || (_isEdit && _comprobante.FechaEmisionModificada) )
				fecha = mz.erp.businessrules.Sistema.DateTime.FillDateTime(fecha);
            row.Fecha = fecha;
			
			row.IdProveedor = _comprobante.IdProveedor;
			row.IdResponsable = _comprobante.IdResponsable;
			row.IdMonedaCierre = _comprobante.IdMonedaCierre;

			now = mz.erp.businessrules.Sistema.DateTime.Now;
			fc = _comprobante.FechaRegistracion;
			fecha = mz.erp.businessrules.Sistema.DateTime.FillDateTime(fc); //fecha = new DateTime(fc.Year, fc.Month, fc.Day, now.Hour, now.Minute, now.Second);
			row.FechaDeRegistracion = fecha;
			
			
			row.ValorCotizacionProveedor = _comprobante.ValorCotizacionProveedor;
			row.IdTipoMovimiento = _idCuentaImputacion;;
			row.IdSubtipoMovimiento = _idSubCuentaImputacion;
			row.FechaVencimiento = _fechaVencimiento;
			row.FechaProximoVencimiento = _proximaFechaVencimiento;
			row.MesImputacion = Mes;
			row.AñoImputacion = Año;
			row.CAI = _CAI;
			row.Leyenda = _leyenda;

			row.NetoBruto = _netoBruto * _comprobante.ValorCotizacionProveedor;
			row.Descuento = _descuentos * _comprobante.ValorCotizacionProveedor;
			row.SubtotalNeto = _neto * _comprobante.ValorCotizacionProveedor;

			row.NetoGravado = _conceptosGravados.GetNetoGravadoMonedaReferencia();
			row.GastoGravado = _conceptosGravados.GetGastoGravadoMonedaReferencia();
			row.ServicioGravado = _conceptosGravados.GetServicioGravadoMonedaReferencia();
			
			row.MontoNoGravado = _conceptosNOGravados.GetGastosNOGravadoMonedaReferencia();

			row.IvaInscripto1 = _conceptosGravados.GetIVA1MonedaReferencia();				
			row.IvaInscripto2 = _conceptosGravados.GetIVA2MonedaReferencia();				
			row.IvaInscripto3 = _conceptosGravados.GetIVA3MonedaReferencia();				
			row.PercepcionIB = _conceptosNOGravados.GetPIBMonedaReferencia();
			row.PercepcionGanancias = _conceptosNOGravados.GetPGMonedaReferencia();
			row.PercepcionIVA = _conceptosNOGravados.GetPIVAMonedaReferencia();
			row.ImpuestosInternos = _conceptosNOGravados.GetIIMonedaReferencia();

			row.TotalGeneral = _totalGeneral * _comprobante.ValorCotizacionProveedor;
			row.DescuentoGeneral = _descuentoGeneral * _comprobante.ValorCotizacionProveedor;
			row.Total = this.TotalUsuarioMonedaReferencia;

			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.IdSucursal = Security.IdSucursal;
			row.IdEmpresa = Security.IdEmpresa;	
	
			// ---- Matias - 20090629 - Tarea 254 Custom.
			string[] mesAñoDevengamiento = _mesDeDevengamiento.Split(new char[]{'/'});
			long MesDevengamiento = 0;
			long AñoDevengamiento = 0;
			if(mesAñoDevengamiento.Length == 2)
			{
				MesDevengamiento = Convert.ToInt64(mesAñoDevengamiento[0]);
				AñoDevengamiento = Convert.ToInt64(mesAñoDevengamiento[1]);
			}
			row.MesDevengamiento = MesDevengamiento;
			row.AñoDevengamiento = AñoDevengamiento;
			// ---- FinMatias

			row.Autorizada = Autorizada;
				
		}

		private void MyCommitCabecera()
		{						
			string campoau = _comprobante.CampoAuxiliar1;						

			_dataComprobantes.tpu_ComprobantesDeCompra.Clear();
			if(!_isEdit)
			{
				tpu_ComprobantesDeCompraDataset.tpu_ComprobantesDeCompraRow row = _dataComprobantes.tpu_ComprobantesDeCompra.Newtpu_ComprobantesDeCompraRow();
				SetValues(row);
				_dataComprobantes.tpu_ComprobantesDeCompra.Addtpu_ComprobantesDeCompraRow(row);	
			}
			else
			{
				tpu_ComprobantesDeCompraDataset.tpu_ComprobantesDeCompraRow row = mz.erp.businessrules.tpu_ComprobantesDeCompra.GetByPk(_comprobante.IdComprobante);
				SetValues(row);
				_dataComprobantes.tpu_ComprobantesDeCompra.ImportRow(row);
			}	
		

			tpu_ComprobantesDataset data = _comprobante.DataComprobantes;
			if(data.tpu_Comprobantes.Rows.Count > 0)
			{
				DataRow rowC = data.tpu_Comprobantes.Rows[0];
				rowC["Total"] = this.TotalUsuarioMonedaReferencia;
			}
		}

		private void MyCommitDetalleDeuda()
		{
			_dataComprobantesDD.tpu_ComprobanteDetalleDeuda.Clear();
			if(_isEdit)
			{
				DataSet data = mz.erp.businessrules.tpu_ComprobanteDetalleDeuda.GetList( _comprobante.IdComprobante, null, null);
				foreach(DataRow rowC in data.Tables[0].Rows)
					rowC.Delete();
				//_dataComprobantes.Merge( data, true);
				_dataComprobantesDD.Merge(data, true);
			}
			tpu_ComprobanteDetalleDeudaDataset.tpu_ComprobanteDetalleDeudaRow row = _dataComprobantesDD.tpu_ComprobanteDetalleDeuda.Newtpu_ComprobanteDetalleDeudaRow();
			row.IdComprobante = _comprobante.IdComprobante;
			row.IdTipoDeComprobante = _comprobante.TipoComprobanteDestino;
			row.Numero = _comprobante.Numero;

			DateTime now = mz.erp.businessrules.Sistema.DateTime.Now;
			DateTime fc = _comprobante.FechaEmision;
			DateTime fecha = fc; //DateTime fecha = new DateTime(fc.Year, fc.Month, fc.Day, 0,0,0);
			if ( !_isEdit || (_isEdit && _comprobante.FechaEmisionModificada) )
				fecha = mz.erp.businessrules.Sistema.DateTime.FillDateTime(fecha);
			row.FechaEmision = fecha;
			
			row.FechaVencimiento = _fechaVencimiento;
			row.Cuota = 1;
			
			int signo = Convert.ToInt16(tsy_TiposDeComprobantes.GetByPk(_comprobante.TipoComprobanteDestino).signo);
			row.Importe = this.TotalUsuarioMonedaReferencia * signo;
			
            /* Silvina 20110426 - Tarea 0000048 */
            if ((_comprobante.ProcessName().Equals("ProcesoIngresarFacturaGastoAlContado") || _comprobante.ProcessName().Equals("ProcesoIngresarFacturaComprasAlContado")) && 
                _comprobante.GetTaskName().Equals("IngresarComprobanteDeCompraCabecera") )
            /* Fin Silvina 20110426 - Tarea 0000048 */
			{
				// Para cuando es una Ingreso de Factura de Gastos con pago al contado.
				row.Saldo = 0;
				row.SaldoTemporal = 0;
			}
			else
			{
				row.Saldo = this.TotalUsuarioMonedaReferencia* signo;
				row.SaldoTemporal = this.TotalUsuarioMonedaReferencia* signo;
			}

			row.IdMonedaCierre = this.IdMonedaOrigen;
			row.IdCotizacionCierre = this.IdCotizacionCierre;						
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.IdSucursal = Security.IdSucursal;
			row.IdEmpresa = Security.IdEmpresa;		
			_dataComprobantesDD.tpu_ComprobanteDetalleDeuda.Addtpu_ComprobanteDetalleDeudaRow(row);
		}

		private void MyCommitComprobantesDet()
		{	
			/*
			_dataComprobantesDet.tpu_ComprobantesDeCompraDet.Clear();
			foreach(ItemComprobanteCompra item in _comprobante.Items)
			{			
				tpu_ComprobantesDeCompraDetDataset.tpu_ComprobantesDeCompraDetRow row = _dataComprobantesDet.tpu_ComprobantesDeCompraDet.Newtpu_ComprobantesDeCompraDetRow();
				row.IdComprobante = _comprobante.IdComprobante;
				row.Ordinal = item.Ordinal;
				row.Cantidad = item.CantidadCompraOriginal;
				row.Precio = item.PrecioCompraOriginal;
				row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
				row.IdConexionCreacion = Security.IdConexion;
				row.IdConexionUltimaModificacion = Security.IdConexion;
				row.IdReservado = 0;
				row.IdSucursal = Security.IdSucursal;
				row.IdEmpresa = Security.IdEmpresa;		
				_dataComprobantesDet.tpu_ComprobantesDeCompraDet.Addtpu_ComprobantesDeCompraDetRow(row);			
			}	
			*/	
		}

		private void MyCommitDetalleImpuestos()
		{
			_dataComprobantesImp.tpu_ComprobantesImpuestos.Clear();
			if(_isEdit)
			{
				DataSet data = mz.erp.businessrules.tpu_ComprobantesImpuestos.GetList( _comprobante.IdComprobante);
				foreach(DataRow rowC in data.Tables[0].Rows)
					rowC.Delete();
				_dataComprobantesImp.Merge( data, true);
			}
			foreach(ItemConcepto item in this.ConceptosGravados)
			{			
				tpu_ComprobantesImpuestosDataset.tpu_ComprobantesImpuestosRow row = _dataComprobantesImp.tpu_ComprobantesImpuestos.Newtpu_ComprobantesImpuestosRow();
				row.IdComprobante = _comprobante.IdComprobante;
				row.IdNeto = Convert.ToInt64(item.IdConcepto);
				row.IdImpuesto = item.IdImpuesto;				
				row.ValorNeto = item.MontoNetoMondeReferencia;
				row.ValorImpuesto = item.MontoImpuestoMonedaReferencia;
				row.PorcentajeAplicado = item.PorcentajeImpuesto;
				row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
				row.IdConexionCreacion = Security.IdConexion;
				row.IdConexionUltimaModificacion = Security.IdConexion;
				row.IdReservado = 0;
				row.IdSucursal = Security.IdSucursal;
				row.IdEmpresa = Security.IdEmpresa;		
				_dataComprobantesImp.tpu_ComprobantesImpuestos.Addtpu_ComprobantesImpuestosRow(row);			
			}			
			foreach(ItemConcepto item in this.ConceptosNOGravados)
			{			
				tpu_ComprobantesImpuestosDataset.tpu_ComprobantesImpuestosRow row = _dataComprobantesImp.tpu_ComprobantesImpuestos.Newtpu_ComprobantesImpuestosRow();
				row.IdComprobante = _comprobante.IdComprobante;
				row.IdNeto = Convert.ToInt64(item.IdConcepto);
				row.IdImpuesto = item.IdImpuesto;				
				row.ValorNeto = item.MontoNetoMondeReferencia;
				row.ValorImpuesto = item.MontoImpuestoMonedaReferencia;
				row.PorcentajeAplicado = item.PorcentajeImpuesto;
				row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
				row.IdConexionCreacion = Security.IdConexion;
				row.IdConexionUltimaModificacion = Security.IdConexion;
				row.IdReservado = 0;
				row.IdSucursal = Security.IdSucursal;
				row.IdEmpresa = Security.IdEmpresa;		
				_dataComprobantesImp.tpu_ComprobantesImpuestos.Addtpu_ComprobantesImpuestosRow(row);			
			}
		}

		public void Flush(string IdTransaction)
		{			
			_comprobante.Flush(IdTransaction);

			_dataComprobantes.tpu_ComprobantesDeCompra.Rows[0]["IdComprobante"] = _comprobante.IdComprobante;
			foreach(DataRow row in  _dataComprobantesDD.Tables[0].Rows)
			{
				if(!row.RowState.Equals(System.Data.DataRowState.Deleted))
					row["IdComprobante"] = _comprobante.IdComprobante;
			}
			/*
			if (_dataComprobantesDet.tpu_ComprobantesDeCompraDet.Rows.Count != 0)
			{
				foreach(tpu_ComprobantesDeCompraDetDataset.tpu_ComprobantesDeCompraDetRow row in _dataComprobantesDet.tpu_ComprobantesDeCompraDet.Rows)
				{
					row.IdComprobante = _comprobante.IdComprobante;
				}			

			}
			*/			
			if (_dataComprobantesImp.tpu_ComprobantesImpuestos.Rows.Count != 0 )
			{

				foreach(DataRow row in  _dataComprobantesImp.tpu_ComprobantesImpuestos.Rows)
				{
					if(!row.RowState.Equals(System.Data.DataRowState.Deleted))
						row["IdComprobante"] = _comprobante.IdComprobante;
				}		
			}

			businessrules.tpu_ComprobantesDeCompra.Update(_dataComprobantes.tpu_ComprobantesDeCompra, IdTransaction);
			businessrules.tpu_ComprobantesDeCompraDet.Update(_dataComprobantesDet.tpu_ComprobantesDeCompraDet,  IdTransaction);
			businessrules.tpu_ComprobanteDetalleDeuda.Update(_dataComprobantesDD.tpu_ComprobanteDetalleDeuda, IdTransaction, _replication);
			businessrules.tpu_ComprobantesImpuestos.Update(_dataComprobantesImp.tpu_ComprobantesImpuestos, IdTransaction);
			if(_dataConfirmacionDePrecios.Tables[0].Rows.Count > 0 && !_actualizaEstadoFactura)
			{
				_dataConfirmacionDePrecios.Tables[0].Rows[0]["IdComprobanteFactura"] = _comprobante.IdComprobante;
				mz.erp.dataaccess.tpu_ComprobantesDeCompraConfirmacionDePrecios.Update(_dataConfirmacionDePrecios.Tables[0], IdTransaction);
			}
			if(_actualizaEstadoFactura)
			{
				mz.erp.dataaccess.tpu_ComprobantesDeCompraConfirmacionDePrecios.Update(_facturaState.DataCabecera.Tables[0], IdTransaction);
				mz.erp.dataaccess.tpu_ComprobantesDeCompraDetConfirmacionDePrecios.Update(_facturaState.DataDetalle.Tables[0], IdTransaction);

			}
		}		

		private void _comprobante_TipoDeComprobanteDestinoChanged(object sender, EventArgs e)
		{
			ActualizarConceptosAsociados();
			if(TipoDeComprobanteDestinoChanged != null)
				TipoDeComprobanteDestinoChanged(this, new EventArgs());
		}
		

		public void ActualizarConceptosAsociados()
		{
			if(this.TipoComprobanteDestino != null && this.TipoComprobanteDestino != string.Empty)
			{
				DataTable table = mz.erp.businessrules.tpu_NetosImpuestos.GetListImpuestosAsociados(this.TipoComprobanteDestino);
		 		ArrayList ConceptosGravadosAEliminar = new ArrayList();
				ArrayList ConceptosNOGravadosAEliminar = new ArrayList();
				if(table != null)
				{
					foreach(ItemConcepto it in _conceptosGravados)
					{
						bool ok = true;
						foreach(DataRow row in table.Rows)
						{
							string IdConcepto = Convert.ToString(row["IdNeto"]);
							string IdImpuesto = Convert.ToString(row["IdImpuesto"]);
							if(it.IdConcepto.Equals(IdConcepto) && it.IdImpuesto.Equals(IdImpuesto))
								ok = false;
						
						}
						if(ok) ConceptosGravadosAEliminar.Add(it);
					}
					foreach(ItemConcepto it in _conceptosNOGravados)
					{
						bool ok = true;
						foreach(DataRow row in table.Rows)
						{
							string IdConcepto = Convert.ToString(row["IdNeto"]);
							string IdImpuesto = Convert.ToString(row["IdImpuesto"]);
							if(it.IdConcepto.Equals(IdConcepto) && it.IdImpuesto.Equals(IdImpuesto))
								ok = false;
						
						}
						if(ok) ConceptosNOGravadosAEliminar.Add(it);
					}
					foreach(ItemConcepto it in ConceptosGravadosAEliminar)
					{
						_conceptosGravados.Remove(it);
					}
					foreach(ItemConcepto it in ConceptosNOGravadosAEliminar)
					{
						_conceptosNOGravados.Remove(it);
					}
					
					
						
					
				}
			}
		}


		/*private void _items_ObjectHasChanged(object sender, EventArgs e)
		{
			Refresh();
		}*/

		/*	private void Refresh()
			{
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
			}*/

	
		public void RecalcularTotal()
		{			
			decimal _impuestosGravados = 0;
			decimal _impuestosNOGravados = 0;
			decimal _netosEnDetalle = 0;
			decimal _difEntreNetos = 0;

			foreach(ItemConcepto item in this.ConceptosGravados)
			{
				_impuestosGravados = _impuestosGravados + item.MontoImpuesto;
				_netosEnDetalle = _netosEnDetalle + item.MontoNeto;
			}
			foreach(ItemConcepto item in this.ConceptosNOGravados)
			{
				_impuestosNOGravados = _impuestosNOGravados + item.MontoImpuesto;
				_netosEnDetalle = _netosEnDetalle + item.MontoNeto;
			}
			_totalGeneral = _neto + _impuestosGravados + _impuestosNOGravados;			
			_porcentajeDescuentoGeneral = 0;
			_descuentoGeneral = 0;
			_total = _totalGeneral;
			_difEntreNetos = _neto - _netosEnDetalle;

			if(NetoChanged != null)
				NetoChanged(this, new EventArgs());
		}

		
		public void SetItems(ItemsComprobantesCompra items)
		{
			_comprobante.SetItems(items);
			_comprobante.Items.NetoItemsOriginalChanged +=new EventHandler(Items_NetoItemsOriginalChanged);
		}

		private void _comprobante_IdMonedaOrigenChanged(object sender, EventArgs e)
		{
			if(IdMonedaOrigenChanged != null)
				IdMonedaOrigenChanged(this, new EventArgs());
		}

		private void Items_NetoItemsOriginalChanged(object sender, EventArgs e)
		{
			if(NetoItemsOriginalChanged != null)
				NetoItemsOriginalChanged(this, new EventArgs());
		}

		private void _comprobante_CondicionDeCompraChanged(object sender, EventArgs e)
		{
			if(CondicionDeCompraChanged != null)
				CondicionDeCompraChanged(this, new EventArgs());
		}
	}
	
	public class ConceptoRepetidoException: Exception
	{

	}
	public class NetoAcumuladoInvalidoException: Exception
	{

	}

	public class ItemsConcepto:CollectionBase	
	{


		public ItemsConcepto()
		{
		}

		public ItemsConcepto (ItemsConcepto copy)
		{
			foreach(ItemConcepto item in copy)
			{
				this.Add(new ItemConcepto(item));
			}
		}
		public void Add(ItemConcepto it)
		{
			this.List.Add(it);
		}

		public bool Contains(ItemConcepto it)
		{
			return this.List.Contains(it);
		}

		public void Remove(ItemConcepto it)
		{
			this.List.Remove(it);
		}

		public void RemoveAll()
		{
			this.List.Clear();
		}

		public bool Contains(string IdConcepto, string IdImpuesto)
		{
			foreach(ItemConcepto it in this.List)
			{
				if(it.IdConcepto.Equals(IdConcepto) && it.IdImpuesto.Equals(IdImpuesto))
				{
					return true;
				}
			}
			return false;
		}

		public ItemConcepto Get(string IdConcepto, string IdImpuesto)
		{
			foreach(ItemConcepto it in this.List)
			{
				if(it.IdConcepto.Equals(IdConcepto) && it.IdImpuesto.Equals(IdImpuesto))
				{
					return it;
				}
			}
			return null;
		}
		public decimal GetNetoMonedaReferencia()
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				result = result + it.MontoNetoMondeReferencia;
			}
			return result;
		}

		public decimal GetNeto()
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				result = result + it.MontoNeto;
			}
			return result;
		}

		public decimal GetImpuestos()
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				result = result + it.MontoImpuesto;
			}
			return result;
		}

		public decimal GetNetoGravadoMonedaReferencia()
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				if(it.Familia.Equals("NG"))
				{
					result = result + it.MontoNetoMondeReferencia;
				}
			}
			return result;
		}
		public decimal GetNetoGravado()
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				if(it.Familia.Equals("NG"))
				{
					result = result + it.MontoNeto;
				}
			}
			return result;
		}

		public decimal GetGastoGravadoMonedaReferencia()
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				if(it.Familia.Equals("GG"))
				{
					result = result + it.MontoNetoMondeReferencia;
				}
			}
			return result;
		}

		public decimal GetGastoGravado()
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				if(it.Familia.Equals("GG"))
				{
					result = result + it.MontoNeto;
				}
			}
			return result;
		}

		public decimal GetServicioGravadoMonedaReferencia()
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				if(it.Familia.Equals("SG"))
				{
					result = result + it.MontoNetoMondeReferencia;
				}
			}
			return result;
		}
		public decimal GetServicioGravado()
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				if(it.Familia.Equals("SG"))
				{
					result = result + it.MontoNeto;
				}
			}
			return result;
		}

		public decimal GetGastosNOGravadoMonedaReferencia()
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				if(it.FamiliaImp.Equals("EX"))
				{
					result = result + it.MontoImpuestoMonedaReferencia;
				}
			}
			return result;
		}

		public decimal GetGastosNOGravado()
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				if(it.FamiliaImp.Equals("EX"))
				{
					result = result + it.MontoImpuesto;
				}
			}
			return result;
		}

		public decimal GetIVA1MonedaReferencia()
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				if(it.FamiliaImp.Equals("IVA1"))
				{
					result = result + it.MontoImpuestoMonedaReferencia;
				}
			}
			return result;
		}
		
		public decimal GetIVA1()
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				if(it.FamiliaImp.Equals("IVA1"))
				{
					result = result + it.MontoImpuesto;
				}
			}
			return result;
		}

		public decimal GetIVA2MonedaReferencia()
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				if(it.FamiliaImp.Equals("IVA2"))
				{
					result = result + it.MontoImpuestoMonedaReferencia;
				}
			}
			return result;
		}
		
		public decimal GetIVA2()
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				if(it.FamiliaImp.Equals("IVA2"))
				{
					result = result + it.MontoImpuesto;
				}
			}
			return result;
		}


		public decimal GetIVA3MonedaReferencia()
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				if(it.FamiliaImp.Equals("IVA3"))
				{
					result = result + it.MontoImpuestoMonedaReferencia;
				}
			}
			return result;
		}
		
		public decimal GetIVA3()
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				if(it.FamiliaImp.Equals("IVA3"))
				{
					result = result + it.MontoImpuesto;
				}
			}
			return result;
		}

		public decimal GetPIBMonedaReferencia()
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				if(it.FamiliaImp.Equals("PIB"))
				{
					result = result + it.MontoImpuestoMonedaReferencia;
				}
			}
			return result;
		}

		public decimal GetPIB()
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				if(it.FamiliaImp.Equals("PIB"))
				{
					result = result + it.MontoImpuesto;
				}
			}
			return result;
		}

		public decimal GetPGMonedaReferencia()
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				if(it.FamiliaImp.Equals("PG"))
				{
					result = result + it.MontoImpuestoMonedaReferencia;
				}
			}
			return result;
		}
		public decimal GetPG()
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				if(it.FamiliaImp.Equals("PG"))
				{
					result = result + it.MontoImpuesto;
				}
			}
			return result;
		}

		public decimal GetPIVAMonedaReferencia()
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				if(it.FamiliaImp.Equals("PIVA"))
				{
					result = result + it.MontoImpuestoMonedaReferencia;
				}
			}
			return result;
		}

		public decimal GetPIVA()
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				if(it.FamiliaImp.Equals("PIVA"))
				{
					result = result + it.MontoImpuesto;
				}
			}
			return result;
		}

		public decimal GetIIMonedaReferencia()
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				if(it.FamiliaImp.Equals("II"))
				{
					result = result + it.MontoImpuestoMonedaReferencia;
				}
			}
			return result;
		}

		public decimal GetII()
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				if(it.FamiliaImp.Equals("II"))
				{
					result = result + it.MontoImpuesto;
				}
			}
			return result;
		}

		public decimal GetAlicuotaIVA()
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				if(it.FamiliaImp.Equals("IVA1") ||it.FamiliaImp.Equals("IVA2") || it.FamiliaImp.Equals("IVA3"))
				{
					result = result + it.PorcentajeImpuesto;
				}
			}
			return result;
		}

		public decimal GetAlicuotaIVAMinima()
		{
			decimal ali = decimal.MaxValue;
			foreach(ItemConcepto it in this.List)
			{
				
				if(it.FamiliaImp.Equals("IVA1") ||it.FamiliaImp.Equals("IVA2") || it.FamiliaImp.Equals("IVA3"))
				{
					if(it.PorcentajeImpuesto < ali)
						ali = it.PorcentajeImpuesto;
				}
			}
			return ali.Equals(decimal.MaxValue)? 0:ali;
		}

		public decimal GetAlicuotasImpuestosAplicadas(ArrayList imps)
		{
			decimal result = 0;
			foreach(ItemConcepto it in this.List)
			{
				if(imps.Contains(it.FamiliaImp))
				{
					result = result + it.PorcentajeImpuesto;
				}
			}
			return result;
		}


	}
	public class ItemConcepto
	{
		private string _idConcepto = string.Empty;
		private string _idImpuesto = string.Empty;
		private string _concepto = string.Empty; 
		private string _impuesto = string.Empty;
		private decimal _montoNeto = 0;
		private decimal _montoImpuesto = 0;
		private decimal _porcentajeImpuesto = 0;
		private string _familia = string.Empty;
		private string _familiaImp = string.Empty;
		private decimal _valorCotizacion = 1;

		public ItemConcepto()
		{
		}


		public ItemConcepto(ItemConcepto copy)
		{
			_idConcepto = copy.IdConcepto;
			_idImpuesto =copy.IdImpuesto;
			_concepto = copy.Concepto;
			_impuesto = copy.Impuesto;
			_montoNeto = copy.MontoNeto;
			_montoImpuesto = copy.MontoImpuesto;
			_porcentajeImpuesto = copy.PorcentajeImpuesto;
			_familia = copy.Familia;
			_familiaImp = copy.FamiliaImp;
			_valorCotizacion = copy.ValorCotizacion;
		}


		public decimal MontoNetoMondeReferencia
		{
			get{ return _montoNeto * _valorCotizacion;}
		}

		public decimal MontoImpuestoMonedaReferencia
		{
			get{return _montoImpuesto * _valorCotizacion;}
		}

		public decimal ValorCotizacion
		{
			get
			{
				return _valorCotizacion;
			}
			set
			{
				_valorCotizacion = value;
			}
		}


		public decimal PorcentajeImpuesto
		{
			get{return _porcentajeImpuesto;}
			set{_porcentajeImpuesto = value;}
		}

		public decimal MontoImpuesto
		{
			get{return _montoImpuesto;}
			set{_montoImpuesto = value;}
		}
		public decimal MontoNeto
		{
			get{return _montoNeto;}
			set{_montoNeto = value;}
		}
		public string Impuesto
		{
			get{return _impuesto;}
			set{_impuesto = value;}
		}
		public string Concepto
		{
			get{return _concepto;}
			set{_concepto = value;}
		}
		public string IdConcepto
		{
			get{return _idConcepto;}
			set{_idConcepto = value;}
		}
		public string IdImpuesto
		{
			get{return _idImpuesto;}
			set{_idImpuesto = value;}
		}
		public string Familia
		{
			get{return _familia;}
			set{_familia = value;}
		}	
		public string FamiliaImp
		{
			get{return _familiaImp;}
			set{_familiaImp = value;}
		}	


	}

	


}


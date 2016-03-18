using System;
using mz.erp.businessrules.comprobantes;
using ParaisoFiscal;
using System.Collections;
using System.Data;
using mz.erp.commontypes;
using mz.erp.businessrules.workout_eFactura; //Matias 20110813 - Tarea 0000131
using System.Diagnostics; //Matias 20110813 - Tarea 0000131
using System.Text; //Matias 20110813 - Tarea 0000131
using System.Security.Cryptography; //Matias 20110813 - Tarea 0000131

namespace mz.erp.businessrules
{
	public class DatosPreparadosParaImpresion
	{
		private string _cuentaNombre = string.Empty;
		public string CuentaNombre
		{
			get { return _cuentaNombre ; }			
			set { _cuentaNombre = value; }			
		}	

		private string _cuentaDocumento = string.Empty;
		public string CuentaDocumento 
		{
			get { return _cuentaDocumento ; }			
			set { _cuentaDocumento = value; }			
		}

		private string _cuentaDomicilio = string.Empty;
		public string CuentaDomicilio 
		{
			get { return _cuentaDomicilio ; }			
			set { _cuentaDomicilio = value; }			
		}

		private string _cuentaDomicilioEntrega = string.Empty;
		public string CuentaDomicilioEntrega
		{
			get { return _cuentaDomicilioEntrega ; }			
			set { _cuentaDomicilioEntrega = value; }			
		}
		private string _cuentaLocalidad = string.Empty;
		public string CuentaLocalidad 
		{
			get { return _cuentaLocalidad ; }			
			set { _cuentaLocalidad = value; }			
		}

		private string _cuentaTelefono = string.Empty;
		public string CuentaTelefono 
		{
			get { return _cuentaTelefono ; }			
			set { _cuentaTelefono = value; }			
		}
		
		private string _cuentaIdCuenta = string.Empty;
		public string CuentaIdCuenta 
		{
			get { return _cuentaIdCuenta ; }			
			set { _cuentaIdCuenta = value; }			
		}

		private string _cuentaCodigo = string.Empty;
		public string CuentaCodigo
		{
			get { return _cuentaCodigo ; }			
			set { _cuentaCodigo = value; }			
		}
		private string _cuentaCategoriaImpositiva = string.Empty;
		public string CuentaCategoriaImpositiva 
		{
			get { return _cuentaCategoriaImpositiva ; }			
			set { _cuentaCategoriaImpositiva = value; }			
		}

		private string _cuentaTipoDocumento = string.Empty;
		public string CuentaTipoDocumento 
		{
			get { return _cuentaTipoDocumento ; }			
			set { _cuentaTipoDocumento = value; }			
		}

		private string _idCuenta = string.Empty;
		public string IdCuenta 
		{
			get { return _idCuenta ; }			
			set { _idCuenta = value; }			
		}

		private string _momento = string.Empty;
		public string Momento 
		{
			get { return _momento ; }			
			set { _momento = value; }			
		}

		private decimal _total = 0;
		public decimal Total
		{
			get { return _total ; }			
			set { _total = value; }			
		}

		private string _tipoComprobante = string.Empty;
		public string TipoComprobante
		{
			get { return _tipoComprobante ; }
			set { _tipoComprobante = value; }
		}	
		private string _concepto = string.Empty;
		public string Concepto
		{
			get { return _concepto ; }
			set { _concepto = value; }
		}	

		private string _responsable = string.Empty;
		public string Responsable 
		{
			get { return _responsable == null ? "nulo" : _responsable ; }
			set { _responsable = value; }
		}


		private DataTable _resumenDeImpuestos = null;
		public DataTable ResumenDeImpuestos 
		{
			get { return _resumenDeImpuestos; }
			set { _resumenDeImpuestos = value; }
		}
		

		private string _condicionDeVenta = string.Empty;
		public string CondicionDeVenta 
		{
			get { return _condicionDeVenta ; }			
			set { _condicionDeVenta = value; }			
		}

		private string _observaciones = string.Empty;
		public string Observaciones 
		{
			get { return _observaciones ; }			
			set { _observaciones = value; }			
		}

		private string _nroInterno = String.Empty;
		public string NroInterno 
		{
			get {return _nroInterno;}
			set {_nroInterno = value;}
		}

		private ArrayList _comprobantesAsociados = new ArrayList();
		public ArrayList ComprobantesAsociados 
		{
			get { return _comprobantesAsociados ; }			
			set { _comprobantesAsociados = value; }			
		}

		private ArrayList _valores = new ArrayList();
		public ArrayList Valores 
		{
			get { return _valores ; }			
			set { _valores = value; }			
		}

		private ArrayList _variablesDeUsuario = new ArrayList();
		public ArrayList VariablesDeUsuario 
		{
			get { return _variablesDeUsuario ; }			
			set { _variablesDeUsuario = value; }			
		}		
		
		private bool _percibeIB = true;
		public bool PercibeIB 
		{
			get { return _percibeIB ; }			
			set { _percibeIB = value; }			
		}	

		private ItemsComprobantes _items;
		public ItemsComprobantes Items
		{
			get { return _items ; }
			set { _items = value; }			
		}		

		private decimal _itemsTotalBonificacionesRecargosCuenta = 0;
		public decimal ItemsTotalBonificacionesRecargosCuenta 
		{
			get { return _itemsTotalBonificacionesRecargosCuenta ; }			
			set { _itemsTotalBonificacionesRecargosCuenta = value; }			
		}

		private decimal _itemsTotalBonificacionesRecargosProducto = 0;
		public decimal ItemsTotalBonificacionesRecargosProducto 
		{
			get { return _itemsTotalBonificacionesRecargosProducto ; }			
			set { _itemsTotalBonificacionesRecargosProducto = value; }			
		}

		private decimal _itemsTotalBonificacionesRecargosFinancieros = 0;
		public decimal ItemsTotalBonificacionesRecargosFinancieros 
		{
			get { return _itemsTotalBonificacionesRecargosFinancieros ; }			
			set { _itemsTotalBonificacionesRecargosFinancieros = value; }			
		}

		private decimal _alicuotaPercepcionIngresosBrutos = 0;
		public decimal AlicuotaPercepcionIngresosBrutos
		{
			get{return _alicuotaPercepcionIngresosBrutos;}
			set{_alicuotaPercepcionIngresosBrutos = value;}
		}
        //German 20120306 - Tarea 0000289
        private ArrayList _remitosAsociados = new ArrayList();
        public ArrayList RemitosAsociados
        {
            get { return _remitosAsociados; }
            set { _remitosAsociados = value; }
        }
        //Fin German 20120306 - Tarea 0000289
	}	

	/// <summary>
	/// Descripción breve de PrepararDatosImpresionComprobantes.
	/// </summary>
	public class FiscalComprobantes: ITask, ITaskBeforeFlush, IPersistentTask
	{
		private string _numero = String.Empty;
		public string Numero
		{			
			get	{return _numero;}
		}
		private string _numeroDesde = string.Empty;
		private string _numeroHasta = string.Empty;
		private char _claseComp = char.MaxValue;
		private string _puntoVentaComp = string.Empty;
		private string _tipoComprobanteDeVenta = string.Empty;
		private ComprobanteDeVenta _comprobanteDeVenta = null;
		private bool _allowSave = false;
		//Se usa para ver si cuando dice @Vendedor en la configuracion de la impresion se imprime el responable del comprobanta
		//actual o de los items de los comprobantes anteriores.
		private bool _imprimeResponsablesComprobantesAnteriores = false;

		/// <summary>
		/// En true da la posibilidad de buscar el número de comprobante en la variable "Comprobantes.Numeracion..."
		/// Cuando desde la interface fiscal está todo OK (cierre de comprobante) se pone el parámetro en false. 
		/// De esta forma se graba con el valor que asigna el controlador fiscal
		/// </summary>
		private bool _actualizaNumeracion = true;
		public bool ActualizaNumeracion
		{			
			get	{return _actualizaNumeracion;}	
		}		

		private bool _cierreAutomatico = Variables.GetValueBool("Fiscal.CierreAutomatico");		
		public bool CierreAutomatico
		{
			get {return _cierreAutomatico;}			
		}

		public FiscalComprobantes()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		

		#region Miembros de ITask
		public event System.EventHandler ObjectHasChanged;				
		public event System.EventHandler OnTaskBeforeExecute;
		public event System.EventHandler OnTaskAfterExecute;
		public event System.EventHandler OnTaskBeforePrevious;
		public event System.EventHandler OnTaskAfterPrevious;
		

		public void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}
		public void FormHasClosed() 
		{
		}

		public bool AllowPrevious()
		{
			return true;
		}
		public void ListenerAfterPreviousDependentTask( object sender )
		{
		}
		public void ListenerBeforePreviousDependentTask( object sender )
		{
		}
			

		public void ListenerTaskDependentChanged(object sender)
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.ListenerTaskDependentChanged
		}

		private string _tareaAsociada = string.Empty;
		public string TareaAsociada
		{
			get
			{
				return _tareaAsociada;
			}
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{			
			string NombreTareaSender = ((ITask) sender).GetTaskName();
			string NombreTarea = this.GetTaskName();			
			string NombreProceso = _processParent.Process.ProcessName;			
			string variable = "Momentos." + NombreTarea + "." + NombreProceso + "." + "Tarea";
			string valor = Variables.GetValueString(variable);				
			_tareaAsociada = valor;
			//Momentos.ImprimirComprobanteDeVentaFiscal.ProcesoPrevenderVender.Proceso

			if (sender.GetType() == typeof(mz.erp.businessrules.comprobantes.ComprobanteDeVenta))
			{
				if (valor == NombreTareaSender)
				{
					ComprobanteDeVenta _comprobante = (ComprobanteDeVenta)sender;
					LoadDataFromComprobanteDeVenta( _comprobante );
				}				
			}
			if (sender.GetType() == typeof(mz.erp.businessrules.comprobantes.ComprobanteDeEntrega))
			{
				if (valor == NombreTareaSender)
				{
					ComprobanteDeEntrega _comprobante = (ComprobanteDeEntrega)sender;
					LoadDataFromComprobanteDeEntrega( _comprobante );
				}
			}
			if (sender.GetType() == typeof(mz.erp.businessrules.comprobantes.ComprobanteDePago))
			{		
				ComprobanteDePago _comprobante = (ComprobanteDePago)sender;
				//German 20090814
				if(!(NombreProceso.Equals("ProcesoCambiarMercaderiaVentas")))
				{
					this._datosPreparados.Valores = _comprobante.Valores.MisValores;
				}
				//Fin German 20090814
				if (valor == NombreTareaSender)
				{										
					LoadDataFromComprobanteDePago( _comprobante );			
				}					
			}
			if (sender.GetType() == typeof(mz.erp.businessrules.RecargosFormasDePago))
			{				
				//German 20090814
				if(!(NombreProceso.Equals("ProcesoCambiarMercaderiaVentas")))
				{
					RecargosFormasDePago _comprobante = (RecargosFormasDePago)sender;
					LoadDataFromRecargosFormasDePago( _comprobante );			
				}
				//Fin German 20090814	
			}		
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.ListenerBeforeExecuteDependentTask
		}

		public void Init()
		{
			_imprimeResponsablesComprobantesAnteriores = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "ImprimirResposanblesComprobantesAnteriores");
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
			bool IsValid = true;
			_errores.Clear();

            //Matias - 20110808 - Tarea 0000131
            //Codigo anterior.............................
            //if ((!(_impresionFiscalExitosa)) && (_soportaComprobanteFiscal))
            //{
            //    IsValid = false;
            //    _errores.Add(new ItemDatasetError("Impresora Fiscal", "Impresión", "Ha ocurrido un error al intentar imprimir "));
            //}
            //FinCodigo anterior.............................
            //Codigo nuevo.............................
            if ((this.EFacturaHabilitada) && (this.EFacturaGenerar) && (!_eFacturaExitosa))
            {
                IsValid = false;
                _errores.Add(new ItemDatasetError("eFactura", _presentaFacturaRsp.Error.Codigo, _presentaFacturaRsp.Error.Descripcion));
                _errores.Add(new ItemDatasetError("eFactura", "Observaciones", _presentaFacturaRsp.CAE.Motivo));
            }
            else
            {
                if ( ( ((!this.EFacturaHabilitada) || (this.EFacturaHabilitada && !this.EFacturaGenerar) ) )
                    && (!(_impresionFiscalExitosa)) && (_soportaComprobanteFiscal))
                {
                    IsValid = false;
                    _errores.Add(new ItemDatasetError("Impresora Fiscal", "Impresión", "Ha ocurrido un error al intentar imprimir "));
                }
            }
            //FinCodigo nuevo.............................
            //FinMatias - 20110808 - Tarea 0000131
            return IsValid;
		}
		public bool AllowShow() 
		{
            return _allowShow;
		}

		public ItemsDatasetErrors GetErrors()
		{
			return _errores;			
		}
		public string GetWarnings()
		{
			return null;			
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
			return _taskName;
		}

		public void SetTaskName(string taskName)
		{
			_taskName = taskName;
		}

		public void Execute()
		{
			if(OnTaskBeforeExecute != null)
				OnTaskBeforeExecute(this, new EventArgs());
			
            //Matias - 20110808 - Tarea 0000131
            //Codigo anterior.............................
            //if (_allowShow)
            //{
            //    this.PrinterFiscal();
            //}
            //this.IsValid();
            //FinCodigo anterior.............................
            //Codigo Nuevo.............................
            if ((_allowShow) && (!this.EFacturaHabilitada || (this.EFacturaHabilitada && !this.EFacturaGenerar)))
            {
                this.PrinterFiscal();
            }
            else 
            {
                if (this.EFacturaHabilitada && this._eFacturaGenerar)
                    this.ConsumirWS(); //Que sucede si hay un error en el Commit o Flush?? Para ese momento ya se habrá registrado la factura electrónica en AFIP!! Ver!
            }
            this.IsValid();
            //FinCodigo Nuevo.............................
            //FinMatias - 20110808 - Tarea 0000131
            
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());

		}

        //Matias - 20110808 - Tarea 0000131
        private void EFactura_ArmarParametro(ComprobanteDeVenta comprobante)
        {
            //Arma el XML directamente instanciando la clase PresentaFacturaReq.
            //1°) Login
            _presentaFacturaReq.Login = new credenciales();
            _presentaFacturaReq.Login.UserId = Variables.GetValueString("Sistema.eFactura.Userid");
            string password = _presentaFacturaReq.Login.UserId + (Variables.GetValueString("Sistema.CUITEmpresa")).Replace("-","") + comprobante.Cuenta.Documento.Replace("-","") + "soluciones_wko"; // userid + ndocEmisor + ndocCliente + palabraClave:“soluciones_wko”
            _presentaFacturaReq.Login.Password = this.MD5CodificarClave(password);

            //2°) FactID
            _presentaFacturaReq.FacID = new facid();
            _presentaFacturaReq.FacID.NroInterno = comprobante.IdComprobante;
            DataRow rowTipoCompro = tsy_AfipTiposDeComprobantes.GetByIdTipoDeComprobante(comprobante.TipoComprobanteDestino);
            _presentaFacturaReq.FacID.Tipo = (rowTipoCompro != null) ? Convert.ToString(rowTipoCompro["Codigo"]) : string.Empty; //Segun tablas afip/workout.
            _presentaFacturaReq.FacID.PtoVenta = Variables.GetValueString("Sistema.eFactura.PuntoDeVenta"); //El valor a setear sera post-registro en AFIP
            _presentaFacturaReq.FacID.Numero = ""; //Opcional - No completar.
            _presentaFacturaReq.FacID.Fecha = ""; //Opcional - No completar.
            string fechaVto = Convert.ToString(((DetalleCuotas)(comprobante.CondicionDeVenta.DetalleCondicionDeVentaList[0])).FechaVencimiento);
            _presentaFacturaReq.FacID.FechaVencimiento = fechaVto.Substring(6, 4) + '-' + fechaVto.Substring(3, 2) + '-' + fechaVto.Substring(0, 2); //Formato "aaaa-mm-dd"
            _presentaFacturaReq.FacID.ConceptoAFIP = Variables.GetValueString("Sistema.eFactura.IdConceptoAfip"); //Segun tablas afip/workout; por ahora siempre sera "Productos & Servicios".

            //3°) Emisor
            _presentaFacturaReq.Emisor = new sujetoemisor();
            _presentaFacturaReq.Emisor.Datos = new sujeto();
            _presentaFacturaReq.Emisor.Datos.TipoDoc = Variables.GetValueString("Sistema.eFactura.IdTipoDoc"); //Segun tablas afip/workout ==> "80" CUIT.
            _presentaFacturaReq.Emisor.Datos.NroDoc = (Variables.GetValueString("Sistema.CUITEmpresa")).Replace("-","");
            _presentaFacturaReq.Emisor.Datos.RSocial = Variables.GetValueString("Sistema.NombreEmpresa");
            _presentaFacturaReq.Emisor.Datos.Domicilio = Variables.GetValueString("Sistema.DomicilioEmpresa");
            _presentaFacturaReq.Emisor.Datos.Localidad = Variables.GetValueString("Sistema.LocalidadEmpresa");
            _presentaFacturaReq.Emisor.Datos.Cp = Variables.GetValueString("Sistema.CpEmpresa");
            _presentaFacturaReq.Emisor.Datos.Provincia = Variables.GetValueString("Sistema.eFactura.CodigoAfipProvinciaEmpresa"); //Segun tablas afip/workout.
            _presentaFacturaReq.Emisor.Datos.TipoIva = Variables.GetValueString("Sistema.eFactura.CodigoAfipTipoIvaEmpresa"); //Segun tablas afip/workout. Cruzar con tablas de MZ
            _presentaFacturaReq.Emisor.Datos.IvaExento = Variables.GetValueString("Sistema.eFactura.CodigoAfipIvaExentoEmpresa"); //Segun tablas afip/workout ==> "1" Exento - "0" No Exento.
            _presentaFacturaReq.Emisor.IngBrutos = (Variables.GetValueString("Sistema.IngresosBrutosEmpresa")).Replace("-", "");
            string fechaInicioAct = Variables.GetValueString("Sistema.InicioActividadesEmpresa"); //formato original: dd/mm/aaaa
            _presentaFacturaReq.Emisor.FechaInicioActiv = fechaInicioAct.Substring(6, 4) + '-' + fechaInicioAct.Substring(3, 2) + '-' + fechaInicioAct.Substring(0, 2); //Formato "aaaa-mm-dd"
            
            //4°) Cliente
            _presentaFacturaReq.Cliente = new sujetocliente();
            _presentaFacturaReq.Cliente.Datos = new sujeto();
            DataRow rowTipoDoc = tsy_AfipTiposDeDocumentos.GetByIdTipoDeDocumento(comprobante.Cuenta.TipoDocumento);
            _presentaFacturaReq.Cliente.Datos.TipoDoc = (rowTipoDoc != null) ? Convert.ToString(rowTipoDoc["Codigo"]) : string.Empty; //Segun tablas afip/workout.
            _presentaFacturaReq.Cliente.Datos.NroDoc = comprobante.Cuenta.Documento;
            _presentaFacturaReq.Cliente.Datos.RSocial = comprobante.Cuenta.Nombre;
            _presentaFacturaReq.Cliente.Datos.Domicilio = comprobante.Cuenta.Domicilio;
            _presentaFacturaReq.Cliente.Datos.Localidad = comprobante.Cuenta.Localidad;
            _presentaFacturaReq.Cliente.Datos.Cp = comprobante.Cuenta.CodigoPostal;            
            _presentaFacturaReq.Cliente.Datos.Provincia = comprobante.Cuenta.CodigoProvincia; //Nuevo campo en tsh_Provincias 'CodigoProvinciaWorkout'
            _presentaFacturaReq.Cliente.Datos.TipoIva = comprobante.Cuenta.CategoriaImpositiva; //Usa directamente las de tsy_CategoriasIva dado que son iguales! VER!!
            string conceptosNoGravados = Variables.GetValueString("Sistema.eFactura.ConceptosNoGravados"); //Lista de ivas que son conceptos no gravados.
            string exentos = Variables.GetValueString("Sistema.eFactura.Exentos"); //Lista de ivas que son exentos.
            ArrayList exentosArray = mz.erp.systemframework.Util.Parse(exentos);
            string bitStrExento = "0";
            if (exentosArray.Contains(comprobante.Cuenta.CategoriaImpositiva))
            {
                bitStrExento = "1";
            }
            _presentaFacturaReq.Cliente.Datos.IvaExento = bitStrExento; //Segun tablas afip/workout ==> "1" Exento - "0" No Exento. Segun categoriaImpositiva ==> "si es exento ==> 1"
            _presentaFacturaReq.Cliente.Email = (!comprobante.Cuenta.EMail.Equals(string.Empty)) ? comprobante.Cuenta.EMail : Variables.GetValueString("Sistema.eFactura.EMailDefault");
            _presentaFacturaReq.Cliente.CondVta = (comprobante.CondicionDeVenta.EsCuentaCorriente) ? "CC" : "CO"; //Segun tablas afip/workout ("CO" o "CC").
                        
            //5°) Detalle (colección)
            int x = 0;
            _presentaFacturaReq.Detalle = new linea[comprobante.Items.Count];
            foreach (mz.erp.businessrules.comprobantes.ItemComprobante itemC in comprobante.Items)
            {
                linea itemDet = new linea();
                itemDet.Orden = Convert.ToString(itemC.Ordinal);
                itemDet.Codigo = itemC.Codigo;
                itemDet.Descripcion = itemC.Descripcion;
                itemDet.Cantidad = Convert.ToString(itemC.Cantidad);
                itemDet.Unidad = Variables.GetValueString("Sistema.eFactura.UnidadDeMedida"); //Fijo: 07 = "Unidad"
                itemDet.PrecioUnitario = Convert.ToString(decimal.Round(itemC.Precio,2)); //Precio sin impuestos
                itemDet.PrecioTotal = Convert.ToString(decimal.Round(itemC.SubTotalNeto,2));
                itemDet.Observaciones = "";
                //IVAs
                itemDet.IdIVA = string.Empty;
                ArrayList ivaAL = new ArrayList();
                string impTemp = string.Empty;
                foreach (Impuesto imp in itemC.ImpuestosDirectos)
                {
                    if (imp.Key.Equals("IVA"))
                    {
                        impTemp = "IVA";
                        ivaAL.Clear();
                        ivaAL.Add(impTemp);
                        DataRow rowTipoImpuestoIVA = tsy_AfipTiposDeImpuestosIVA.GetByImpuesto(impTemp);
                        itemDet.IdIVA = (rowTipoImpuestoIVA != null) ? Convert.ToString(rowTipoImpuestoIVA["Codigo"]) : string.Empty; //Segun tablas afip/workout
                        itemDet.ImporteIVA = Convert.ToString(decimal.Round(itemC.GetTotalImpuesto(ivaAL),2));
                        break;
                    }
                    else
                    {
                        if (imp.Key.Equals("IVADIF"))
                        {
                            impTemp = "IVADIF";
                            ivaAL.Clear();
                            ivaAL.Add(impTemp);
                            DataRow rowTipoImpuestoIVA = tsy_AfipTiposDeImpuestosIVA.GetByImpuesto(impTemp);
                            itemDet.IdIVA = (rowTipoImpuestoIVA != null) ? Convert.ToString(rowTipoImpuestoIVA["Codigo"]) : string.Empty; //Segun tablas afip/workout
                            itemDet.ImporteIVA = Convert.ToString(decimal.Round(itemC.GetTotalImpuesto(ivaAL), 2));
                            break;
                        }
                        else
                        {
                            if (imp.Key.Equals("EX"))
                            {
                                itemDet.IdIVA = Variables.GetValueString("Sistema.eFactura.CodigoAfipIvaExento"); //Fijo: 02 = "Exento"
                                itemDet.ImporteIVA = "0";
                                break;
                            }
                        }
                    }
                }
                _presentaFacturaReq.Detalle[x] = itemDet;
                x++;
            }

            //6°) Totales
            _presentaFacturaReq.Totales = new totales();
            _presentaFacturaReq.Totales.SubtotalA = Convert.ToString(decimal.Round(comprobante.TotalNeto,2)); //Es el total antes del descuento (para MZ el TotalNeto ya aplica descuentos).
            _presentaFacturaReq.Totales.PorcentDescuento = "0"; //No aplica porcentaje de descuento (viene incluido en el precio)
            _presentaFacturaReq.Totales.ValorDescuento = "0"; //No aplica porcentaje de descuento (viene incluido en el precio)
            _presentaFacturaReq.Totales.SubtotalB = _presentaFacturaReq.Totales.SubtotalA; //dada la naturaleza, es igual al SubTotalA
            _presentaFacturaReq.Totales.PorcentIB = Convert.ToString(decimal.Round(comprobante.Cuenta.AlicuotaPercepcionIngresosBrutos,2)); //Porcentaje de IIBB. --Deprecated!
            ArrayList impIIBB = new ArrayList(); 
            string impIIBBstr = Variables.GetValueString("Impuestos.Lista.IB");
            impIIBB = systemframework.Util.Parse(impIIBBstr);
            _presentaFacturaReq.Totales.ValorIB = Convert.ToString(decimal.Round(comprobante.Items.GetTotalImpuesto(impIIBB),2)); //Importe de IIBB. --Deprecated!
            _presentaFacturaReq.Totales.PorcentIVA1 = Convert.ToString(decimal.Round(comprobante.Items.GetAlicuotaImpuesto("IVA"),2)); //Porcentaje de IVA #1 21% --Deprecated!
            ArrayList impIVA = new ArrayList();
            impIVA.Add("IVA");
            _presentaFacturaReq.Totales.ValorIVA1 = Convert.ToString(decimal.Round(comprobante.Items.GetTotalImpuesto(impIVA),2)); //Importe de IVA #1. --Deprecated!
            _presentaFacturaReq.Totales.PorcentIVA2 = Convert.ToString(decimal.Round(comprobante.Items.GetAlicuotaImpuesto("IVADIF"),2)); //Porcentaje de IVA #2 10.5% --Deprecated!
            impIVA.Clear();
            impIVA.Add("IVADIF");
            _presentaFacturaReq.Totales.ValorIVA2 = Convert.ToString(decimal.Round(comprobante.Items.GetTotalImpuesto(impIVA),2)); //--Deprecated!
            _presentaFacturaReq.Totales.TotalGral = Convert.ToString(comprobante.Total); //Total general --Deprecated!

            //7°) TotalesAFIP
            //Listado de impuestos internos
            ArrayList impInternos = new ArrayList();
            string impInternosStr = Variables.GetValueString("Impuestos.Lista.II"); //Impuestos internos
            impInternos = systemframework.Util.Parse(impInternosStr);
            //Listado de impuestos IVA
            impIVA.Clear();
            impIVA.Add("IVA");
            impIVA.Add("IVADIF");
            string impIVAstr = mz.erp.systemframework.Util.PackString(impIVA);
            //Obtine la cantidad de impuestos (para definir el size del arreglo), tanto de Tributos como de IVAs
            int ctribII = 0; //Impuestos internos
            int ctribIB = 0; //IIBB
            int civa = 0;
            ctribIB = comprobante.CantidadDeImpuestos(impIIBB);
            ctribII = comprobante.CantidadDeImpuestos(impInternos);
            civa = comprobante.CantidadDeImpuestos(impIVA);
            //Veo si el Cliente NO percibe IIBB; en tal caso no voy a sumar sus impuestos ni al tamaño ni al monto de los tributos
            ctribIB = ( _eFacturaComprobanteDeVenta.Cuenta.AlicuotaPercepcionIngresosBrutos == decimal.Zero) ? 0 : ctribIB;
            //Define los arreglos en los cuales voy a poner los impuestos
            _presentaFacturaReq.TotalesAFIP = new TotalesAFIPType();
            if (ctribIB + ctribII > 0)
                _presentaFacturaReq.TotalesAFIP.Tributos = new tributo[ctribIB + ctribII];
            _presentaFacturaReq.TotalesAFIP.IVAs = new iva[civa];
            //Arma las 2 colecciones de impuestos en el mismo bloque: Tributos (colección) e IVAs (coleccion)
            //Itero por cada impuesto del comprobante...
            int t = 0;
            int i = 0;
            decimal totalIVA = 0;
            decimal totalTributo = 0;
            foreach (DataRow rowImpuesto in comprobante.Items.ResumenDeImpuestos.Rows)
            {
                string impuestoKey = Convert.ToString(rowImpuesto["Key"]);
                if ( ((ctribIB > 0) && impIIBB.Contains(impuestoKey)) || ((ctribII > 0) && impInternos.Contains(impuestoKey)) )
                {
                    //IIBB
                    tributo trb = new tributo();
                    DataRow rowTipoImpuestoTrib = tsy_AfipTiposDeImpuestosTributo.GetByImpuesto(impuestoKey);
                    trb.Id = (rowTipoImpuestoTrib != null) ? Convert.ToString(rowTipoImpuestoTrib["Codigo"]) : string.Empty; //Segun tablas afip/workout
                    trb.Desc = Convert.ToString(rowImpuesto["DescripcionCorta"]); //Descripcion del tributo (acepta cualquier descripcion)
                    trb.BaseImp = Convert.ToString(decimal.Round(comprobante.TotalNeto,2)); //Importe de base imponible para el calculo del tributo
                    trb.Alic = Convert.ToString( decimal.Round((Convert.ToDecimal(rowImpuesto["Alicuota"])),2) ); //Alicuota del tributo
                    trb.Importe = Convert.ToString(decimal.Round(Convert.ToDecimal(rowImpuesto["Valor"]),2)); //Importe del tributo
                    _presentaFacturaReq.TotalesAFIP.Tributos[t] = trb;
                    t++;
                    totalTributo += decimal.Round(Convert.ToDecimal(rowImpuesto["Valor"]),2);
                }
                else
                {                    
                    //IVAs
                    if (impIVA.Contains(impuestoKey))
                    {
                        iva iva = new iva();
                        DataRow rowTipoImpuestoIVA = tsy_AfipTiposDeImpuestosIVA.GetByImpuesto(impuestoKey);
                        iva.Id = (rowTipoImpuestoIVA != null) ? Convert.ToString(rowTipoImpuestoIVA["Codigo"]) : string.Empty; //Segun tablas afip/workout
                        iva.BaseImp = Convert.ToString(decimal.Round(comprobante.GetBaseImponible(impuestoKey),2)); //Importe de base imponible para el calculo del IVA
                        iva.Importe = Convert.ToString(decimal.Round(Convert.ToDecimal(rowImpuesto["Valor"]),2)); //Convert.ToString(comprobante.Items.GetTotalImpuesto(new ArrayList().Add(impuestoKey)));
                        _presentaFacturaReq.TotalesAFIP.IVAs[i] = iva;
                        i++;
                        totalIVA += decimal.Round(Convert.ToDecimal(rowImpuesto["Valor"]),2);
                    }
                }
            }

            decimal ImpTotConcDecimal = decimal.Round(comprobante.GetBaseImponible(conceptosNoGravados),2);
            decimal ImpNetoDecimal = decimal.Round(comprobante.GetBaseImponible(impIVAstr),2);
            decimal ImpOpExDecimal = decimal.Round(comprobante.GetBaseImponible(exentos),2);
            _presentaFacturaReq.TotalesAFIP.ImpTotConc = Convert.ToString(ImpTotConcDecimal); //Total con conceptos no gravados.
            _presentaFacturaReq.TotalesAFIP.ImpNeto = Convert.ToString(ImpNetoDecimal); //Total del importe al cual se le aplica el IVA.
            _presentaFacturaReq.TotalesAFIP.ImpOpEx = Convert.ToString(ImpOpExDecimal); //Sumatoria de operaciones exentas de IVA.
            _presentaFacturaReq.TotalesAFIP.ImpTrib = Convert.ToString(totalTributo); //Sumatoria de importe en el tag repetitivo TotalesAFIP.Tributos
            _presentaFacturaReq.TotalesAFIP.ImpIVA = Convert.ToString(totalIVA); //Sumatoria de importe en el tag repetitivo TotalesAFIP.Tributos
            //El calculo del total va al final dado que depende de los calculos anteriores!
            _presentaFacturaReq.TotalesAFIP.ImpTotal = Convert.ToString( ImpTotConcDecimal + ImpNetoDecimal + ImpOpExDecimal + totalTributo + totalIVA);
            string fechaComprobante = Convert.ToString(comprobante.FechaComprobante);
            _presentaFacturaReq.TotalesAFIP.FchServDesde = fechaComprobante.Substring(6, 4) + fechaComprobante.Substring(3, 2) + fechaComprobante.Substring(0, 2); //?? Fecha de inicio de la prestacion del servicio facturado. Formato aaaammdd o aaaa-mm-dd ??
            _presentaFacturaReq.TotalesAFIP.FchServHasta = fechaComprobante.Substring(6, 4) + fechaComprobante.Substring(3, 2) + fechaComprobante.Substring(0, 2); //?? Fecha de fin de la prestacion del servicio facturado. Formato aaaammdd o aaaa-mm-dd ??
            _presentaFacturaReq.TotalesAFIP.MonId = "PES"; //Segun tablas afip/workout ==> fijo
            _presentaFacturaReq.TotalesAFIP.MonCotiz = "1"; //Segun tablas afip/workout (Si MonId=="PES" ==> MonCotiz="1", sino iria la cotizacion de la moneda respecto al peso) ==> fijo
            //Comprobantes asociados (colección). Caso NC desde Factura
            int y = 0;            
            _presentaFacturaReq.TotalesAFIP.CbtesAsoc = new cbteasoc[comprobante.ComprobantesAsociados.Count];
            foreach (string nroComprobante in comprobante.ComprobantesAsociados)
            {
                cbteasoc cbte = new cbteasoc();
                cbte.Nro = string.Empty;
                cbte.PtoVta = string.Empty;
                cbte.Tipo = string.Empty;
                DataRow rowCompAsoc = tsa_Comprobantes.GetByNroComprobante(nroComprobante);
                if (rowCompAsoc != null)
                {
                    string idTipoComp = Convert.ToString(rowCompAsoc["IdTipoDeComprobante"]);
                    DataRow rowTipoComp = tsy_AfipTiposDeComprobantes.GetByIdTipoDeComprobante(idTipoComp);
                    if (rowTipoComp != null)
                    {
                        cbte.Tipo = Convert.ToString(rowTipoComp["Codigo"]);                        
                    }
                    cbte.PtoVta = nroComprobante.Substring(2, 4); //Si "B-0001-00000152" ==> "0001"
                    cbte.Nro = nroComprobante.Substring(7, 8); //Si "B-0001-00000152" ==> "00000152"
                }
                _presentaFacturaReq.TotalesAFIP.CbtesAsoc[y] = cbte;
                y++;
            }
            
            //8°) Otros Datos
            _presentaFacturaReq.OtrosDatos = new otrosdatos();
            _presentaFacturaReq.OtrosDatos.Leyenda0 = "";
            _presentaFacturaReq.OtrosDatos.Leyenda1 = "";
            _presentaFacturaReq.OtrosDatos.Leyenda2 = "";
            _presentaFacturaReq.OtrosDatos.Leyenda3 = "";
            _presentaFacturaReq.OtrosDatos.Leyenda4 = "";
            _presentaFacturaReq.OtrosDatos.Leyenda5 = "";
            _presentaFacturaReq.OtrosDatos.Leyenda6 = "";
            _presentaFacturaReq.OtrosDatos.Leyenda7 = "";
            _presentaFacturaReq.OtrosDatos.Leyenda8 = "";
            _presentaFacturaReq.OtrosDatos.Leyenda9 = "";
            _presentaFacturaReq.OtrosDatos.Remito = ""; //Nro del remito
            _presentaFacturaReq.OtrosDatos.Operacion = ""; //Id de la operacion
            _presentaFacturaReq.OtrosDatos.Despacho = ""; //Nro de despacho
            _presentaFacturaReq.OtrosDatos.Confecciono = Security.IdUsuario;
            //..........FinArmado de XML virtual. 
        }

        private void ConsumirWS()
        {
            try
            {
                //Crea & consume el WS.
                sp_wsfe ws_eFactura = new sp_wsfe();
                _presentaFacturaRsp = ws_eFactura.PresentaFactura(_presentaFacturaReq);
                this.IsValidEFactura();
            }
            catch (Exception e)
            {
                //Error manejado por excepcion interna
                _eFacturaExitosa = false;
                error errorWS = new error();
                errorWS.Codigo = "10000";
                errorWS.Descripcion = "No se pudo establecer la comunicación con el servicio web (error manejado por el sistema)";
                _presentaFacturaRsp.Error = errorWS;
                _presentaFacturaRsp.CAE.Motivo = "No hubo observaciones";
            }
        }

        private void IsValidEFactura()
        {
            if (_presentaFacturaRsp.CAE.Resultado.Equals("A"))
            {
                //Factura electrónica generada & aprobada
                _eFacturaExitosa = true;
                _cae = _presentaFacturaRsp.CAE; //Guardo el CAE que luego voy a utilizar para guardar los datos en tsa_ComprobantesEFactura
            }
            else
            {
                if (_presentaFacturaRsp.CAE.Resultado.Equals("R")) //Error de eFactura
                    _eFacturaExitosa = false;                
            }
        }

        public string MD5CodificarClave(string clave)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(clave));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }        
        //FinMatias - 20110808 - Tarea 0000131

		#endregion
		#region Variables privadas
		private string _taskName = string.Empty;
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;
		private DatosPreparadosParaImpresion _datosPreparados = new DatosPreparadosParaImpresion();
		private InterfaceFiscal _iFiscal;
		private bool _allowShow = Variables.GetValueBool("Fiscal.Activo");
        private ComprobanteDeVenta _eFacturaComprobanteDeVenta = new ComprobanteDeVenta(); //Matias - 20110830 - Tarea 0000131
        private bool _eFacturaHabilitada = Variables.GetValueBool("Comprobantes.eFactura.Habilitada", false); //Matias - 20110808 - Tarea 0000131
        private bool _eFacturaGenerar = false; //Matias - 20110808 - Tarea 0000131 (Implica que el usuario decidio generar la eFactura!! (sii _eFacturaHabilitada == true )
        private bool _eFacturaExitosa = false; //Matias - 20110808 - Tarea 0000131
        private mz.erp.businessrules.workout_eFactura.cae _cae = new cae(); //Matias - 20110831 - Tarea 0000131
        private mz.erp.businessrules.workout_eFactura.PresentaFacturaReq _presentaFacturaReq = new PresentaFacturaReq(); //Matias - 20110817 - Tarea 0000131
        private mz.erp.businessrules.workout_eFactura.PresentaFacturaRsp _presentaFacturaRsp = new PresentaFacturaRsp(); //Matias - 20110912 - Tarea 0000131
        private DataTable _dataComprobantesEFactura = new mz.erp.commontypes.data.tsa_ComprobantesEFacturaDataset().tsa_ComprobantesEFactura; //Matias - 20110901 - Tarea 0000131

		private bool _impresionFiscalExitosa = false;
		public bool ImpresionFiscalExitosa
		{
			get 
			{
				return _impresionFiscalExitosa;
			}			
		}
		private bool _soportaComprobanteFiscal = false;
		public bool SoportaComprobanteFiscal 
		{
			get 
			{
				return _soportaComprobanteFiscal;
			}			
		}
        //Matias - 20110902 - Tarea 0000131
        public bool EFacturaHabilitada
        {
            get { return _eFacturaHabilitada; }
        }
        public bool EFacturaGenerar
        {
            get { return _eFacturaGenerar; }
            set { _eFacturaGenerar = value; }
        }
        //FinMatias - 20110902 - Tarea 0000131
        #endregion


		private void LoadDataFromComprobanteDeVenta( ComprobanteDeVenta _comprobante)
		{
            _comprobanteDeVenta = _comprobante;
            string NombreTarea = this.GetTaskName();
            string NombreProceso = _processParent.Process.ProcessName;
            string variable = "Momentos." + NombreTarea + "." + NombreProceso + "." + "Tarea";
            string valor = Variables.GetValueString(variable);

            this._datosPreparados.CuentaNombre = _comprobante.Cuenta.Nombre;
            this._datosPreparados.CuentaDomicilio = _comprobante.Cuenta.Domicilio;
            this._datosPreparados.CuentaLocalidad = _comprobante.Cuenta.Localidad;
            this._datosPreparados.CuentaTelefono = _comprobante.Cuenta.Telefono;
            this._datosPreparados.CuentaTipoDocumento = _comprobante.Cuenta.TipoDocumento;
            this._datosPreparados.CuentaDocumento = _comprobante.Cuenta.Documento;
            this._datosPreparados.CuentaCategoriaImpositiva = _comprobante.Cuenta.CategoriaImpositiva;
            this._datosPreparados.CuentaIdCuenta = _comprobante.Cuenta.IdCuenta;
            this._datosPreparados.CuentaCodigo = _comprobante.Cuenta.Codigo;
            //German 20091023 - Tarea 470

            string _prefacturas = Variables.GetValueString("Comprobantes.TiposDeComprobantes.Prefacturas");
            ArrayList comp = mz.erp.systemframework.Util.Parse(_prefacturas, ",");
            if (_imprimeResponsablesComprobantesAnteriores)
            {

                if (comp.Contains(_comprobante.TipoComprobanteOrigen))
                {
                    ArrayList aux = new ArrayList();
                    Hashtable table = new Hashtable();
                    string nombreResponsable = string.Empty;
                    foreach (string IdResponsable in _comprobante.ResponsablesComprobantesAnteriores)
                    {
                        if (!table.ContainsKey(IdResponsable))
                        {
                            DataRow row = mz.erp.businessrules.tsh_Personas.GetByPk(IdResponsable);
                            if (row != null)
                            {
                                nombreResponsable = Convert.ToString(row["Nombre"]);
                                table.Add(IdResponsable, nombreResponsable);

                            }
                        }
                    }
                    aux = new ArrayList(table.Values);
                    this._datosPreparados.Responsable = mz.erp.systemframework.Util.PackString(aux);
                }
                else
                    this._datosPreparados.Responsable = _comprobante.Responsable;

            }
            else
                this._datosPreparados.Responsable = _comprobante.Responsable;
            //Fin German 20091023 - Tarea 470



            this._datosPreparados.ResumenDeImpuestos = _comprobante.ResumenDeImpuestos;

            string FechaComp = String.Format("{0:dd/MM/yy}", _comprobante.FechaComprobante);
            string FechaVenc = FechaComp;

            //Esto habría que pasarlo a InterfaceFisca y se debería hacer un foreach sobre DetalleCondicionDeVenta
            //Por si hubiera varios pagos, como se hace en comprobantes.CondicionDeVenta.Commit
            ArrayList detalles = new ArrayList(_comprobante.CondicionDeVenta.DetalleCondicionDeVenta);
            DetalleCuotas dc = (DetalleCuotas)detalles[0];
            FechaVenc = String.Format("{0:dd/MM/yy}", dc.GetFechaVencimiento());
            if (FechaVenc != FechaComp)
            {
                FechaVenc = " Vto " + FechaVenc;
            }
            else
            {
                FechaVenc = "";
            }

            this._datosPreparados.CondicionDeVenta = _comprobante.CondicionDeVenta.Descripcion + FechaVenc;
            this._datosPreparados.Observaciones = _comprobante.Observaciones;
            this._datosPreparados.Momento = valor;//this.GetTaskName();						
            this._datosPreparados.Total = _comprobante.Total;

            string Momento = "Fiscal.Momentos." + _comprobante.Momento;
            this._datosPreparados.TipoComprobante = Variables.GetValueString(Momento);

            this._datosPreparados.Items = _comprobante.Items;

            this._datosPreparados.ItemsTotalBonificacionesRecargosCuenta = _comprobante.Items.TotalBonificacionesRecargosCuenta;
            this._datosPreparados.ItemsTotalBonificacionesRecargosProducto = _comprobante.Items.TotalBonificacionesRecargosProducto;
            this._datosPreparados.ItemsTotalBonificacionesRecargosFinancieros = _comprobante.Items.TotalBonificacionesRecargosFinancieros;

            this._datosPreparados.ComprobantesAsociados = _comprobante.ComprobantesAsociados;
            this._datosPreparados.VariablesDeUsuario = _comprobante.VariablesDeUsuario;
            this._datosPreparados.PercibeIB = _comprobante.PercibeIB;
            _tipoComprobanteDeVenta = _comprobante.TipoComprobanteDestino;
            this._datosPreparados.AlicuotaPercepcionIngresosBrutos = _comprobante.Cuenta.AlicuotaPercepcionIngresosBrutos;
            
            //Matias - 20110817 - Tarea 0000131
            if (this.EFacturaHabilitada)
            {
                //Si eFactura esta habilitada ==> el Cliente podrá elegir e/esta o la impresion fiscal tradicional
                _eFacturaComprobanteDeVenta = _comprobante;
            }
            //FinMatias - 20110817 - Tarea 0000131   
            //German 20120306 - Tarea 0000289
            this._datosPreparados.RemitosAsociados = _comprobante.RemitosAsociados;
            //Fin German 20120306 - Tarea 0000289
                    
		}
		private void LoadDataFromComprobanteDeEntrega( ComprobanteDeEntrega _comprobante)
		{									
			this._datosPreparados.CuentaNombre = _comprobante.Cuenta.Nombre;
			this._datosPreparados.CuentaDomicilio = _comprobante.Cuenta.Domicilio;
			this._datosPreparados.CuentaLocalidad = _comprobante.Cuenta.Localidad;
			this._datosPreparados.CuentaTelefono = _comprobante.Cuenta.Telefono;
			this._datosPreparados.CuentaTipoDocumento = _comprobante.Cuenta.TipoDocumento;
			this._datosPreparados.CuentaDocumento = _comprobante.Cuenta.Documento;						
			this._datosPreparados.CuentaCategoriaImpositiva	= _comprobante.Cuenta.CategoriaImpositiva;			
			this._datosPreparados.CuentaIdCuenta = _comprobante.Cuenta.IdCuenta;
			this._datosPreparados.CuentaCodigo = _comprobante.Cuenta.Codigo;
			this._datosPreparados.Responsable = _comprobante.Responsable;
			this._datosPreparados.CondicionDeVenta = _comprobante.CondicionDeVenta.Descripcion;
			this._datosPreparados.Observaciones = _comprobante.Observaciones;
			this._datosPreparados.Momento = _comprobante.GetTaskName();
			string Momento = "Fiscal.Momentos." + this._datosPreparados.Momento;
			this._datosPreparados.TipoComprobante = Variables.GetValueString(Momento);
			this._datosPreparados.Items = _comprobante.Items;
			
			ArrayList domiciliosAsociados = _comprobante.Cuenta.DomiciliosAsociado;
			foreach(mz.erp.businessrules.Domicilio domicilio in domiciliosAsociados)
			{				
				if (domicilio.Checked)
				{
					this._datosPreparados.CuentaDomicilioEntrega = domicilio.DomicilioTexto + domicilio.Numero.Trim() + domicilio.Piso + domicilio.Departamento + domicilio.Localidad + domicilio.Telefono;
				}				
			}
			

			ArrayList arr = new ArrayList(); 
			if (_comprobante.TipoComprobanteDestino == "RMXDF")
			{
				string TiposComprobantesFacturas = Variables.GetValueString("Comprobantes.TiposDeComprobantes.Facturas");
				DataSet data = businessrules.Workflow.GetComprobantesBottonUp(_comprobante.IdComprobanteOrigen, TiposComprobantesFacturas);							
				foreach(DataRow row in data.Tables[0].Rows)
				{
					string IdComprobante = Convert.ToString(row["IdComprobante"]);
					mz.erp.commontypes.data.tsa_ComprobantesDataset.tsa_ComprobantesRow rowC = tsa_Comprobantes.GetByPk(IdComprobante);					
					arr.Add(rowC.Numero);
				}				
			}
			else
				arr.Add(_comprobante.NumeroOrigen);

			this._datosPreparados.ComprobantesAsociados = arr;
			this._datosPreparados.Valores = null;
			this._datosPreparados.VariablesDeUsuario = _comprobante.VariablesDeUsuario;			
		}

		private void LoadDataFromComprobanteDePago( ComprobanteDePago _comprobante)		 
		{			 
			commontypes.data.tsa_CuentasDataset.tsa_CuentasRow row = businessrules.tsa_Cuentas.GetByPk(_comprobante.IdCuenta);
			this._datosPreparados.CuentaNombre = Convert.ToString(row["Nombre"]);			
			this._datosPreparados.CuentaDomicilio = Convert.ToString(row["Domicilio"]);
			this._datosPreparados.CuentaLocalidad = "";
			//this._datosPreparados.CuentaTelefono = _comprobante.Cuenta.Telefono;
			//this._datosPreparados.CuentaTipoDocumento = _comprobante.Cuenta.TipoDocumento;
			//this._datosPreparados.CuentaDocumento = _comprobante.Cuenta.Documento;						
			this._datosPreparados.CuentaCategoriaImpositiva	= Convert.ToString(row["IdCategoriaIva"]);
			this._datosPreparados.CuentaIdCuenta = _comprobante.IdCuenta;	
			this._datosPreparados.CuentaCodigo = _comprobante.CodigoCuenta;
			this._datosPreparados.Responsable = _comprobante.Responsable;
			//this._datosPreparados.CondicionDeVenta = _comprobante.CondicionDeVenta.Descripcion;
			this._datosPreparados.Observaciones = _comprobante.Observaciones;			
			
			string Momento = "Pagar";
			string Variable = "Fiscal.Momentos." + Momento;
			this._datosPreparados.Momento = Momento;
			this._datosPreparados.TipoComprobante = Variables.GetValueString(Variable);			
			this._datosPreparados.Concepto = "Pago a cuenta";


			this._datosPreparados.Valores = _comprobante.Valores.MisValores;
			this._datosPreparados.NroInterno = _comprobante.Numero;

            
		}

		private void LoadDataFromRecargosFormasDePago( RecargosFormasDePago _comprobante)		 
		{	 	
			foreach (FormaDePago fp in _comprobante.FormasDePagos)
			{
				if(fp.Valor != null)
					this._datosPreparados.Valores.Add(fp.Valor);
			}			
			this._datosPreparados.Total = _comprobante.TotalComprobanteDeVenta;
			/*ArrayList valores = new ArrayList();			
			foreach(FormaDePago fdp in _comprobante.)
			{
				valores.Add(fdp.Valor);
			}
			this._datosPreparados.Valores = valores;			*/

            //Matias - 20110817 - Tarea 0000131
            if (this.EFacturaHabilitada)
            {
                //Arma el parametro necesario para luego poder consumir el WS.
                this.EFactura_ArmarParametro(this._eFacturaComprobanteDeVenta);
            }
            //FinMatias - 20110817 - Tarea 0000131
		}		

		private void PrinterFiscal()
		{
            /* Silvina 20110704 - Tarea 0000136 */
            _iFiscal = new InterfaceFiscal(this._datosPreparados, this._processParent, this._taskName, _tipoComprobanteDeVenta);
            /* Fin Silvina 20110704 - Tarea 0000136 */
			_iFiscal.OnChangeEstadoFiscal += new EventHandler(this.ListenerChangesInterfaceFiscal);
			_impresionFiscalExitosa = _iFiscal.ImpresionFiscal();
			_soportaComprobanteFiscal = _iFiscal.SoportaComprobante;			
			if (_impresionFiscalExitosa) 
			{
				_numero = _iFiscal.Numero;
				_actualizaNumeracion = _iFiscal.ActualizaNumeracion;
				_numeroDesde = _iFiscal.NumeroDesde;
				_numeroHasta = _iFiscal.NumeroHasta;
				_claseComp = _iFiscal.ClaseComp;
				_puntoVentaComp = _iFiscal.PuntoVentaComp;
				_allowSave = Variables.GetValueBool("Fiscal.Comprobantes.Transporte.GrabaTransportes");
				
				_impresionFiscalExitosa = _iFiscal.TotalOK;
			}
		}

		private string _mensaje = "";
		public string Mensaje 
		{
			get {return _mensaje;	}
		}
		

		private void ListenerChangesInterfaceFiscal( object sender, System.EventArgs e )
		{
			_mensaje = _iFiscal.Mensaje;
			if (ObjectHasChanged != null)
			{
				ObjectHasChanged( this, new System.EventArgs() );
			}
		}


		#region Miembros de IPersistentTask

		private  static SentenciasReplicacion  GenerateReplication()
		{
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdEmpresa;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsa_comprobantes";
			return replication;
		}

		public event System.EventHandler OnTaskBeforeFlush;

		public event System.EventHandler OnTaskAfterFlush;

		private mz.erp.commontypes.SentenciasReplicacion _replication;

		private bool _hasSaved = false;
	
		private DataSet _data = new DataSet();

		private ArrayList _comprobantes = new ArrayList();

		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();
			data.Add( (DataSet) this._data);
			return data;
		}
	

		public void Commit()
		{
			if(_allowSave)
			{
				if(_numeroDesde != null && _numeroHasta != null && 
					_numeroDesde != string.Empty && _numeroHasta != string.Empty && _numeroDesde != _numeroHasta)
				{
					try
					{
						int nDesde = Convert.ToInt32(_numeroDesde);
						int nHasta = Convert.ToInt32(_numeroHasta);
						int contador = nHasta - nDesde;
						if(contador > 0)
						{
							for( int i = 0; i< contador; i++)
							{
								string Numero = string.Empty;
								if(Variables.GetValueBool("Fiscal.Comprobantes.Transporte.ImporteUltimo"))
									Numero = _claseComp.ToString() + '-' + _puntoVentaComp + '-' + Convert.ToString(nDesde + i).PadLeft(8,'0');
								else Numero = _claseComp.ToString() + '-' + _puntoVentaComp + '-' + Convert.ToString(nHasta - i).PadLeft(8,'0');
								ComprobanteDeVenta comprobante = new ComprobanteDeVenta();			
								comprobante.SetProcessManagerParent(_processParent);
								comprobante.SetTaskName(_taskName);
								comprobante.Init();
								comprobante.ActualizaNumeracion = false;
								comprobante.Validar = false;
								comprobante.Commit(_comprobanteDeVenta, Numero);
								_comprobantes.Add(comprobante);
							}
						}
					}
					catch(Exception e){}
				}                
			}
            //Matias 20110831 - Tarea 0000131
            if (this.EFacturaHabilitada && _eFacturaExitosa)
            {
                DataRow rowCeFactura = _dataComprobantesEFactura.NewRow();
                rowCeFactura = tsa_ComprobantesEFactura.SetRowDefaultValues(rowCeFactura);
                rowCeFactura["IdComprobante"] = _eFacturaComprobanteDeVenta.IdComprobante; //comprobante guardado en LoadDataFromComprobanteDeVenta
                rowCeFactura["CAE"] = _cae.Nro;
                try
                {
                    rowCeFactura["FechaVencimientoCAE"] = Convert.ToDateTime(_cae.Fecha.Substring(6, 2) + '/' + _cae.Fecha.Substring(4, 2) + '/' + _cae.Fecha.Substring(0, 4)); //fechaCAE; ; _cae.Fecha
                }
                catch (Exception e)
                {
                    rowCeFactura["FechaVencimientoCAE"] = DateTime.Now;
                }
                rowCeFactura["Motivo"] = _cae.Motivo;
                _dataComprobantesEFactura.Rows.Add(rowCeFactura);                           
            }
            //FinMatias 20110831 - Tarea 0000131
		}

		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());
			_replication = GenerateReplication();
			if(_allowSave)
			{
				foreach(ComprobanteDeVenta comp in _comprobantes)
				{
					comp.Flush(IdTransaction);
				}                
			}
            //Matias 20110831 - Tarea 0000131
            if (this.EFacturaHabilitada && _eFacturaExitosa)
            {
                //Seteo el nuevo IdComprobane guardado en ComprobanteDeVenta
                DataRow rowTemp = _dataComprobantesEFactura.Rows[0];
                rowTemp["IdComprobante"] = _eFacturaComprobanteDeVenta.IdComprobante;
                dataaccess.tsa_ComprobantesEFactura.Update(_dataComprobantesEFactura, IdTransaction, _replication);
            }
            //FinMatias 20110831 - Tarea 0000131
			_hasSaved = true;
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
			
		}

		public SentenciasReplicacion GetSentenceReplication()
		{
			return _replication;
		}
	
		public bool GetHasSaved()
		{
			
			return _hasSaved;
		}

		#endregion
	}
}

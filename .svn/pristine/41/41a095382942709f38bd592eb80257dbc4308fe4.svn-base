using System;
using mz.erp.businessrules.comprobantes;
using mz.erp.businessrules;
using mz.erp.commontypes.data;
using mz.erp.commontypes;
using System.Threading;
using System.Collections;
using System.Data;


namespace mz.erp.businessrules
{



	public class SolicitarAutorizacion: ITask, ITaskBeforeFlush
	{

        /// <summary>
        /// Initializes a new instance of the <see cref="SolicitarAutorizacion"/> class.
        /// </summary>
        public SolicitarAutorizacion()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//

		}
        /// <summary>
        /// Occurs when [on close form].
        /// </summary>
		public event System.EventHandler OnCloseForm;
		public event System.EventHandler OnShowForm;
		public event System.EventHandler OnChangeTimer;
		



		#region Miembros de ITask
		public event System.EventHandler OnTaskBeforePrevious;
		public event System.EventHandler OnTaskAfterPrevious;

		public void Previous()
		{
			if(autoEvent != null)
				autoEvent.Reset();
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			this.AllowPrevious();
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
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
			
		
		


		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public void ListenerTaskDependentChanged(object sender)
		{
			if (sender.GetType() == typeof(mz.erp.businessrules.comprobantes.ComprobanteDeVenta))
			{
				ComprobanteDeVenta _comprobante = (ComprobanteDeVenta)sender;
				_totalComprobante = _comprobante.Total;
			}
			
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
			if (sender.GetType() == typeof(mz.erp.businessrules.comprobantes.ComprobanteDeVenta))
			{
				ComprobanteDeVenta _comprobante = (ComprobanteDeVenta)sender;
				LoadDataFromComprobanteDeVenta( _comprobante );
			}
			if (sender.GetType() == typeof(mz.erp.businessrules.comprobantes.ComprobanteDePago))
			{
				ComprobanteDePago _comprobante = (ComprobanteDePago)sender;
				LoadDataFromComprobanteDePago( _comprobante );
			}			
			if (sender.GetType() == typeof(mz.erp.businessrules.AjustarStock))
			{
				AjustarStock aj = (AjustarStock) sender;
				LoadDataFromAjustarStock(aj);
			}
			if (sender.GetType() == typeof(mz.erp.businessrules.RegistrarNumerosDeSerie))
			{
				RegistrarNumerosDeSerie rns = (RegistrarNumerosDeSerie) sender;
				LoadDataFromRegistrarNumerosDeSerie(rns);
			}
			if (sender.GetType() == typeof(mz.erp.businessrules.SeleccionItemsDeCompraPendientes))
			{
				SeleccionItemsDeCompraPendientes comp = (SeleccionItemsDeCompraPendientes) sender;
				LoadDataFromSeleccionItemsDeCompraPendientes(comp);
			}
			if (sender.GetType() == typeof(mz.erp.businessrules.IngresarComprobanteDePagoCompras))
			{
				IngresarComprobanteDePagoCompras _comprobante = (IngresarComprobanteDePagoCompras)sender;
				LoadDataFromComprobanteDePagoCompras( _comprobante );
			}	
			if (sender.GetType() == typeof(mz.erp.businessrules.PagarServiciosGastosCompras))
			{
				PagarServiciosGastosCompras _comprobante = (PagarServiciosGastosCompras)sender;
				LoadDataFromPagarServiciosGastosCompras( _comprobante );
			}	
			

		}

		private void LoadDataFromSeleccionItemsDeCompraPendientes(SeleccionItemsDeCompraPendientes comp)
		{
			_idUsuario = Security.IdUsuario;
			_responsable = Security.IdPersona;
			_relacionesCompras = comp.RelacionesComprobanteDeCompraOrigenDestino;
		}

		private void LoadDataFromComprobanteDeVenta( ComprobanteDeVenta _comprobante)
		{			
			if (_comprobante.TaskName().Equals("Prevender") || _comprobante.TaskName().Equals("Preprestar")
				|| _comprobante.TaskName().Equals("Predevolver") || _comprobante.TaskName().Equals("Vender")
				|| _comprobante.TaskName().Equals("VenderManual") || _comprobante.TaskName().Equals("Prestar")
				)
			{
				_totalComprobante = _comprobante.Total;				
				_limiteDeCredito = Decimal.Round(_comprobante.Cuenta.LimiteDeCredito,2);			
				_idCuenta = _comprobante.IdCuenta;
				_cuenta = _comprobante.Cuenta.Nombre;
				_cuentaCodigo = _comprobante.Cuenta.Codigo;
				_idCondicionDeVenta = _comprobante.CondicionDeVenta.IdCondicionDeVenta;
				_condicionDeVenta = _comprobante.CondicionDeVenta.Descripcion;
				_items = _comprobante.Items;							
				_tipoDeComprobante = _comprobante.TipoComprobanteDestino;
				_observacionesComp = _comprobante.Observaciones;
				_responsable = _comprobante.IdResponsable;			
				_idUsuario = businessrules.sy_Usuarios.GetUsuario(_comprobante.IdResponsable);			 			
			}			
		}

		private void LoadDataFromPagarServiciosGastosCompras( PagarServiciosGastosCompras _comprobante)
		{		
			_totalPago = _comprobante.Total;											
			_valores = _comprobante.Valores;
			_pagoGastosServicios = true;
			_pagarServicios = _comprobante;
			_idUsuario = Security.IdUsuario;
			_responsable = Security.IdPersona;
			
		}	


		private void LoadDataFromComprobanteDePagoCompras( IngresarComprobanteDePagoCompras _comprobante)
		{					
			_totalPago = _comprobante.Total;											
			_valores = _comprobante.Valores;
			_proveedor = _comprobante.Proveedor;
			_ctaCte = _comprobante.CuentaCorriente;
			_idUsuario = Security.IdUsuario;
			_responsable = Security.IdPersona;
			_pagoCompras = true;

		}	

		private void LoadDataFromComprobanteDePago( ComprobanteDePago _comprobante)
		{						
			_totalPago = _comprobante.Total;											
			_valores = _comprobante.Valores.MisValores;
		}				

		private void LoadDataFromRegistrarNumerosDeSerie(RegistrarNumerosDeSerie regNroSerie)
		{
			_itemsNumerosDeSerie= (RegistrarNumerosDeSerie.ItemsNumerosDeSerie)regNroSerie.Detalle;
		}		

		private void LoadDataFromAjustarStock(AjustarStock ajuste)
		{
			this._idUsuario = Security.IdUsuario;
			this._responsable = Security.IdPersona;	
			this._observacionesAj = ajuste.Observaciones;
			if(ajuste.GetTaskName().Equals("AjustarStockDestino"))
			{
				DataRow row = mz.erp.businessrules.tlg_Depositos.GetByPk(ajuste.IdDeposito);
				if(row != null)
					_depositoDestino = Convert.ToString(row["Descripcion"]);
				row = mz.erp.businessrules.tlg_Secciones.GetByPk(ajuste.IdSeccion, ajuste.IdDeposito);
				if(row != null)
					_seccionDestino = Convert.ToString(row["Descripcion"]);
				row = mz.erp.businessrules.tlg_EstadosDeStock.GetByPk(ajuste.IdEstadoDeStock);
				if(row != null)
					_estadoDestino = Convert.ToString(row["Descripcion"]);
				row = mz.erp.businessrules.tlg_TiposDeAjuste.GetByPk(ajuste.IdTipoDeAjuste);
				if(row != null)
					_tipoDeAjusteDestino = Convert.ToString(row["Descripcion"]);
			}
			else
			{
				DataRow row = mz.erp.businessrules.tlg_Depositos.GetByPk(ajuste.IdDeposito);
				if(row != null)
					_depositoOrigen = Convert.ToString(row["Descripcion"]);
				row = mz.erp.businessrules.tlg_Secciones.GetByPk(ajuste.IdSeccion, ajuste.IdDeposito);
				if(row != null)
					_seccionOrigen = Convert.ToString(row["Descripcion"]);
				row = mz.erp.businessrules.tlg_EstadosDeStock.GetByPk(ajuste.IdEstadoDeStock);
				if(row != null)
					_estadoOrigen = Convert.ToString(row["Descripcion"]);
				row = mz.erp.businessrules.tlg_TiposDeAjuste.GetByPk(ajuste.IdTipoDeAjuste);
				if(row != null)
					_tipoDeAjusteOrigen = Convert.ToString(row["Descripcion"]);
				_itemsAjuste = ajuste.Items;


			}
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.ListenerBeforeExecuteDependentTask
		}

		public void Init()
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.Init						
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
			
			if (!(_isValid))
			{
				IsValid = false;				
				if (!_autorizado ) 
				{
					Progreso = _progresoMax;					

					if (_observaciones == String.Empty) 
					{
						_errores.Add( new ItemDatasetError( _titulo,_motivo,"Tiempo de espera agotado."));
					}
					else
					{
						_errores.Add( new ItemDatasetError( "Solicitud desautorizada.",_responsableDeAutorizacion,_observaciones));
					}
					
				}				
			}
			return IsValid;
		}
		public bool AllowShow() 
		{	
			return _allowShow = NecesitaAutorizar();
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

			/*if (NecesitaAutorizar())
			{
				if(OnShowForm != null)
					OnShowForm(this, new EventArgs());

				GenerarSolicitud();
				EsperarSolicitud();

				if (_autorizado) 
				{
					_isValid = true;
					if(OnCloseForm != null)
						OnCloseForm(this, new EventArgs());
				}
			}
			else 
			{
				_isValid = true;
			}*/

			if (_idAutorizacion != String.Empty) 
			{
				//Con esta opción cambia el estado a MOD ya que el vendedor modificó el comprobante de venta y la autorización ya no es necesaria
				EliminarSolicitud();
			}

			_isValid = true;
			this.IsValid();

			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}


		#endregion
		#region Variables privadas
		private string _taskName = string.Empty;		
		private string _responsable = string.Empty;
		private string _idUsuario = string.Empty;
		private string _idCuenta = String.Empty;
        private string _cuenta = String.Empty;
		private string _cuentaCodigo = String.Empty;
		private string _idCondicionDeVenta = String.Empty;
		private string _condicionDeVenta = String.Empty;
		private string _proveedor = string.Empty;
		private string _idProveedor = string.Empty;
		private string _proveedorCodigo = string.Empty;
		private string _condicionDeCompra = string.Empty;
		private RelacionesComprobanteDeCompraOrigenDestino _relacionesCompras;
		private ItemsComprobantesCompra _itemsCompras;
		private decimal _totalPago = 0;
		private decimal _totalComprobante = 0;
		private decimal _saldoCC = 0;
		private decimal _saldoComprobante = 0;		
		private decimal _limiteDeCredito = 0;
		private ItemsComprobantes _items;
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;
		
		private bool _isValid = false;
		private bool _allowShow = true;
		private bool _autorizado = false;		
		private bool _pendienteGeneralHTML = true;
		//private bool _necesitaAutorizar = true;
		string _titulo = "Solicitud de autorización";
		string _observaciones = String.Empty;		
		string _observacionesComp = String.Empty;
		string _observacionesAj = String.Empty;
		string _responsableDeAutorizacion = String.Empty;
		string _motivo = String.Empty;
		string _datos = String.Empty;		
		string _tipoDeComprobante = String.Empty;
		ArrayList _valores;
		ArrayList _valoresParaAutorizar = new ArrayList();


		private bool _esTransferenciaDeStock = false;

		private string _depositoOrigen = string.Empty;
		private string _depositoDestino = string.Empty;

		private string _seccionOrigen = string.Empty;
		private string _seccionDestino = string.Empty;

		private string _tipoDeAjusteOrigen = string.Empty;
		private string _tipoDeAjusteDestino = string.Empty;

		private string _estadoOrigen = string.Empty;
		private string _estadoDestino = string.Empty;

		private ArrayList _itemsAjuste = new ArrayList();
		private RegistrarNumerosDeSerie.ItemsNumerosDeSerie _itemsNumerosDeSerie = new mz.erp.businessrules.RegistrarNumerosDeSerie.ItemsNumerosDeSerie();

		private CuentaCorriente _ctaCte;

		private string _idAutorizacion = "";
		private bool _pagoCompras = false;
		private bool _pagoGastosServicios = false;
		private PagarServiciosGastosCompras _pagarServicios;
		#endregion
		#region Variables privadas Timer		
		
		int _periodo = Convert.ToInt32(Variables.GetValueLong("Momentos.Autorizar.Timer.Periodo"));//Lapso entre procesos del timer
		int _inicio = Convert.ToInt32(Variables.GetValueLong("Momentos.Autorizar.Timer.Inicio"));//Tiempo antes que inicie el timer
		int _progreso = 0;
		int _progresoMin = 0;
		int _progresoMax = Convert.ToInt32(Variables.GetValueLong("Momentos.Autorizar.Timer.Duracion"));
		#endregion
		#region Propiedades

		public int Progreso 
		{
			get 
			{
				return _progreso;
			}
			set 
			{
				_progreso = value;
				if(OnChangeTimer != null)
				OnChangeTimer(this, new EventArgs());				
			}
		}

		public int ProgresoMin
		{
			get 
			{
				return _progresoMin;
			}
		}

		public int ProgresoMax
		{
			get 
			{
				return _progresoMax;
			}			
		}

		public string Datos
		{
			get {return _datos;}
		}
		public string Motivo
		{
			get {return _motivo;}
		}
		public string Observaciones
		{
			get {return _observaciones;}
		}

		public bool Autorizado 
		{
			get {return _autorizado;}
		}

		public string Mensaje
		{
			get 
			{				
				if (_observaciones == String.Empty) 
				{
					return "Tiempo de espera agotado";					
				}				
				else 
				{
					return "Solicitud rechazada";
				}

			}
		}
		public string IdAutorizacion
		{
			get 
			{
				return _idAutorizacion;
			}
		}

		#endregion

        /// <summary>
        /// Necesitas the autorizar.
        /// </summary>
        /// <returns></returns>
		private bool NecesitaAutorizar() 		
		{	
			bool AutorizacionCV = false;
			bool AutorizacionCH = false;
			bool AutorizacionCC = false;
			bool AutorizacionD = false;
			bool AutorizacionTC = false;
			bool AutorizacionFP = false;
			bool AutorizacionDifRemito = false;
			bool AutorizacionPorProceso = false;
			bool _necesitaAutorizar = false;
			_pendienteGeneralHTML = true;
			_datos = String.Empty;
			string variable = Variables.GetValueStringDefault(this._processParent.Process.ProcessName, this._taskName, "TipoAutorizacion", null);
			if (variable == null)
			{
				variable = Variables.GetValueString("Momentos.SolicitarAutorizacion.Default.TipoAutorizacion");
			}
					
			ArrayList TiposAutorizaciones = systemframework.Util.Parse(variable, ",");

			foreach (string TipoAutorizacion in TiposAutorizaciones) 
			{
				switch (TipoAutorizacion.ToUpper().Trim())
				{
					case "CV": 						
						AutorizacionCV = NecesitaAutorizarCondicionDeVenta();
						/// Necesito autorizar si la condición de venta no está configurada para la cuenta del comprobante
						///  excepto que mi nivel de usuario lo permita
						if (AutorizacionCV && _pendienteGeneralHTML)
						{
							_datos = _datos + StringBuildGeneral_HTML();
						}
						break;
					case "CC": 	
						AutorizacionCC = NecesitaAutorizarCuentaCorriente();
						/// Necesito autorizar si el límite de credito de la cuenta es menor que lo que se deja sin pagar
						///  excepto que mi nivel de usuario lo permita 
						if (AutorizacionCC && _pendienteGeneralHTML)
						{
							_datos = _datos + StringBuildGeneral_HTML();
						}
						break;
					case "DESC":
						AutorizacionD = NecesitaAutorizarDescuento();
						/// Necesito autorizar si estoy asignando un descuento superior a lo permitido (PrecioDeVentaBruto menor PrecioDeVentaNeto
						///  excepto que mi nivel de usuario lo permite
						if (AutorizacionD && _pendienteGeneralHTML)
						{
							_datos = _datos + StringBuildGeneral_HTML();
						}
						break;
					case "TC":
						AutorizacionTC = NecesitaAutorizarTipoComprobante();
						/// Necesito autorizar si el tipo de comprobante se encuentra en la variable para autorizar
						///  excepto que mi nivel de usuario lo permita
						if (AutorizacionTC && _pendienteGeneralHTML)
						{
							_datos = _datos + StringBuildGeneral_HTML();
						}
						break;
					case "FP":
						AutorizacionFP = NecesitaAutorizarFormasDePago();
						if (AutorizacionFP && _pendienteGeneralHTML)
						{
							_datos = _datos + StringBuildGeneral_HTML();
						}
						break;
					case "CHEQUE":
						AutorizacionCH = NecesitaAutorizarCheques();
						/*
						if (AutorizacionCH && _pendienteGeneralHTML)
						{
							_datos = _datos + StringBuildGeneral_HTML();
						}
						*/
						break;
					case "DIFINGREMITO":
						AutorizacionDifRemito = NecesitaAutorizarRemitoCompra();
						/*
						if (AutorizacionDifRemito && _pendienteGeneralHTML)
						{
							_datos = _datos + StringBuildGeneral_HTML();
						}*/
						break;
					
					case "PROCESO":
						AutorizacionPorProceso = NecesitaAutorizarProceso();						
						break;
				}			
			}
			if( AutorizacionPorProceso)
			{
				_datos = _datos + StringBuildForProcess_HTML(this._processParent.Process.ProcessName); 			
			}

			_necesitaAutorizar = (AutorizacionCV || AutorizacionCC || AutorizacionD || AutorizacionTC || AutorizacionFP
				|| AutorizacionPorProceso || AutorizacionDifRemito || AutorizacionCH);

			return _necesitaAutorizar;

			/*
			 * Tomo el nombre del proceso. Ejemplo: PrevenderVender
			 * Tomo los tags que necesita evaluar. Ejemplo: CV,CC,Desc,TC			 
			 * Genero ArrayList y recorro. Hago un case
			 * 
			 * CASE
			 * CV:
			 *	AutorizacionCV = NecesitaAutorizarCondicionDeVenta();
			 * CC:
			 *  AutorizacionCC = NecesitaAutorizarCuentaCorriente();
			 * DESC:
			 *  AutorizacionD = NecesitaAutorizarDescuento();
			 * TC:
			 *  AutorizacionTC = NecesitaAutorizarTipoComprobante();
			 * Proceso:
			 *  AutorizacionPorProceso = NecesitaAutorizarProceso();
			 * 
			 * Luego para autorizacion por proceso hay que eliminar estas 3 variables
			 * Momentos.SolicitarAutorizacion.ProcesoAjustarStockNegativo.RequiereAutorizacion
			 * Momentos.SolicitarAutorizacion.ProcesoAjustarStockPositivo.RequiereAutorizacion
			 * Momentos.SolicitarAutorizacion.ProcesoTransferenciaInternaDeStock.RequiereAutorizacion
			 * Ya que quedará configurado en variables de la siguiente manera:
			 * IdVariable: Momentos.ProcesoXXX.SolicitudDeAutorizacion
			 * ValorDefault: Proceso
			 * */
		}

		private bool NecesitaAutorizarRemitoCompra()
		{
			if(_processParent.Process.ProcessName.Equals("ProcesoOrdenDeCompraIngresarMercaderia"))
			{
				bool cvOK = RemitoCompraOK();
				string variable = String.Empty;
			
				if (cvOK) 
				{
					return false;
				}
				else 
				{
					variable = "Seguridad.Autorizaciones.PermiteRemitosCompras";
					bool permitePerfil = Security.AllowFunction(variable, _idUsuario);
					if (permitePerfil)
					{
						return false;
					}
					else
					{
						variable = "Seguridad.Autorizaciones.TextoMotivo.RemitosCompras";
						_motivo = Variables.GetValueString(variable);
						_datos = _datos + StringBuildRemitoCompra_HTML();											
						return true;
					}								
				}
			}
			return false;
		}

		private bool RemitoCompraOK()
		{
			foreach(RelacionComprobanteDeCompraOrigenDestino rel in this._relacionesCompras)
			{
				if(rel.CantidadDestino > rel.CantidadPendiente)
					return false;
			}
			return true;
		}

		private string StringBuildRemitoCompra_HTML()
		{
			string cadena = String.Empty;
			cadena = cadena + "<b><u><font size=\"2\"><p align=\"left\">Artículos Ingresados con Cantidad Mayor a la Cantidad Pedida en la Orden de Compra Asociada" + "</font></u></b>" + Enter ;
			cadena = cadena + "<font size=\"2\">";				
			//cadena = cadena + Enter;
			DataRow rowProv = mz.erp.businessrules.tpu_Proveedores.GetByPk(_relacionesCompras.IdProveedor);
			cadena = cadena + "<b>Artículos con Cantidad mayor a la pedida" + "</b>" + Enter ;
			cadena = cadena + "<b>Proveedor: " + Convert.ToString(rowProv["Nombre"]) + "</b>" + Enter ;
			ArrayList result = _relacionesCompras.Sort("FR");
			foreach(RelacionComprobanteDeCompraOrigenDestino rel in result)
			{		
				/*
				string IdVisualizacionDeStock = Variables.GetValueString(_processParent.Process.ProcessName, _processParent.Process.MainTask.KeyTask,"VisualizacionDeStock");
				if(IdVisualizacionDeStock == null || IdVisualizacionDeStock.Equals(string.Empty))
					IdVisualizacionDeStock = Variables.GetValueString("Stock.VisualizacionDeStock.Default");
				Producto prod = new Producto(rel.IdProducto, IdVisualizacionDeStock);
				*/
				if(rel.CantidadDestino > rel.CantidadPendiente)
					cadena = cadena + "<b>";
				cadena = cadena + Tab + String.Format("Código {0} Producto: {1} OC {2} Cantidad OC {3} Cantidad Pendiente {4} Cantidad Ingresada {5}", 
					rel.Codigo, rel.Descripcion, rel.Numero, rel.CantidadOrigen, rel.CantidadPendiente, rel.CantidadDestino) + Enter;
				if(rel.CantidadDestino > rel.CantidadPendiente)
					cadena = cadena + "</b>";
								
			}						
			cadena = cadena + "</font>";
			cadena = cadena + Enter;
			return cadena;
		}


		private bool NecesitaAutorizarProceso()
		{
			/*Poner Variable q digan explicitamente q una autorizacion debe salir para un Proceso determinado*/
			//if(!Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "RequiereAutorizacion"))
			//		return false;

			string variable = "Seguridad.Autorizaciones.Permite" + this._processParent.Process.ProcessName;
			bool resutl =  Security.AllowFunction(variable, _idUsuario);
			if(resutl ) return false;
			variable = "Seguridad.Autorizaciones.TextoMotivo."+ this._processParent.Process.ProcessName;
			_motivo = Variables.GetValueString(variable);
			_datos = string.Empty;
			return true;
			
			
		
		}

		private bool NecesitaAutorizarCondicionDeVenta() 
		{
			bool cvOK = CondicionDeVentaOK();
			string variable = String.Empty;
			
			if (cvOK) 
			{
				return false;
			}
			else 
			{
				variable = "Seguridad.Autorizaciones.PermiteCondicionDeVenta";
				bool permitePerfil = Security.AllowFunction(variable, _idUsuario);
				if (permitePerfil)
				{
					return false;
				}
				else
				{
					variable = "Seguridad.Autorizaciones.TextoMotivo.CondicionDeVenta";
					_motivo = Variables.GetValueString(variable);
					_datos = _datos + StringBuildCV_HTML();											
					return true;
				}								
			}
		}


		private bool NecesitaAutorizarCuentaCorriente() 
		{
			bool ccOK = CuentaCorrienteOK();
			string variable = String.Empty;

			if (ccOK) 
			{
				return false;
			}
			else 
			{
				variable = "Seguridad.Autorizaciones.PermiteCuentaCorriente";
				bool permitePerfil = Security.AllowFunction(variable, _idUsuario);
				if (permitePerfil) 
				{
					return false;
				}
				else
				{					
					variable = "Seguridad.Autorizaciones.TextoMotivo.CuentaCorriente";
					_motivo = Variables.GetValueString(variable);
					_datos = _datos + StringBuildCC_HTML();					
					return true;
				}								
			}
		}

		private bool NecesitaAutorizarDescuento() 
		{						
			bool descOK = DescuentoOK();
			string variable = String.Empty;

			if (descOK) 
			{
				return false;
			}
			else 
			{
				variable = "Seguridad.Autorizaciones.PermiteDescuento";
				bool permitePerfil = Security.AllowFunction(variable, _idUsuario);				
				if (permitePerfil) 
				{
					return false;
				}
				else
				{
					variable = "Seguridad.Autorizaciones.TextoMotivo.Descuento";
					_motivo = Variables.GetValueString(variable);
					_datos = _datos + StringBuildDesc_HTML();					
					return true;
				}								
			}
		}

		private bool NecesitaAutorizarTipoComprobante() 
		{						
			bool tcOK = TipoComprobanteOK();
			string variable = String.Empty;

			if (tcOK) 
			{
				return false;
			}
			else 
			{
				variable = "Seguridad.Autorizaciones.PermiteTiposDeComprobante";
				bool permitePerfil = Security.AllowFunction(variable, _idUsuario);				
				if (permitePerfil) 
				{
					return false;
				}
				else
				{					
					variable = "Seguridad.Autorizaciones.TextoMotivo.TiposDeComprobante";
					_motivo = Variables.GetValueString(variable);
					_datos = _datos + StringBuildTipoComprobante_HTML();
					return true;
				}								
			}
			return false;
		}
		
		private bool NecesitaAutorizarCheques() 
		{						
			bool tcOK = ChequesOK();
			string variable = String.Empty;

			if (tcOK) 
			{
				return false;
			}
			else 
			{
				variable = "Seguridad.Autorizaciones.PermiteCheques";
				bool permitePerfil = Security.AllowFunction(variable, _idUsuario);				
				if (permitePerfil) 
				{
					return false;
				}
				else
				{					
					variable = "Seguridad.Autorizaciones.TextoMotivo.Cheques";
					_motivo = Variables.GetValueString(variable);
					_datos = _datos + StringBuildCheques_HTML();
					return true;
				}
			}
			return false;
		}

		private bool NecesitaAutorizarFormasDePago() 
		{						
			bool tcOK = FormasDePagoOK();
			string variable = String.Empty;

			if (tcOK) 
			{
				return false;
			}
			else 
			{
				variable = "Seguridad.Autorizaciones.PermiteFormasDePago";
				bool permitePerfil = Security.AllowFunction(variable, _idUsuario);				
				if (permitePerfil) 
				{
					return false;
				}
				else
				{					
					variable = "Seguridad.Autorizaciones.TextoMotivo.FormasDePago";
					_motivo = Variables.GetValueString(variable);
					_datos = _datos + StringBuildFormaDePago_HTML();
					return true;
				}
			}
			return false;
		}
			
		private bool CondicionDeVentaOK() 
		{			
			if(!_idCuenta.Equals(string.Empty) && !_idCondicionDeVenta.Equals(string.Empty))
				return tsa_CuentasCondicionesDeVenta_TDCompTesoreria.GetActivo(_idCuenta, _idCondicionDeVenta, _tipoDeComprobante);
			return true;
		}

		private bool CuentaCorrienteOK() 
		{						
			string _ProcessCtaCte = this._processParent.Process.ProcessName;
			if (_ProcessCtaCte.Equals("ProcesoPrestar"))
				_ProcessCtaCte = "ProcesoCuentaCorrienteClienteDV";
			else
				_ProcessCtaCte = "ProcesoCuentaCorrienteCliente";

			if(!_idCuenta.Equals(string.Empty))
			{
				//decimal cantDiasDesde = Variables.GetValueDecimal("CuentaCorriente.RangoFechas.DiasAnteriores");
				//decimal cantDiasHasta = Variables.GetValueDecimal("CuentaCorriente.RangoFechas.DiasPosteriores");
			
				DateTime fDesde = DateTime.MinValue;//mz.erp.businessrules.Sistema.DateTime.Now.AddDays((-1)* Convert.ToDouble(cantDiasDesde)); 
				DateTime fHasta = DateTime.MinValue;//mz.erp.businessrules.Sistema.DateTime.Now.AddDays(Convert.ToDouble(cantDiasHasta));

				comprobantes.CuentaCorriente _ctacte = Factory.GetCuentaCorriente(_idCuenta, fDesde, fHasta, null);
				//ojo modif cta_cte ojoooooooo (se deberia llamar a los dos y sumarlos segun el signo q tengas y ese seria mi saldo posterior)
				//_ctacte.GetDetalleCuentaCorriente(_ProcessCtaCte);			
				_ctacte.GetSaldoPosterior(_ProcessCtaCte);
				_saldoCC = Decimal.Round(_ctacte.SaldoPosterior,2);			

				//El saldoCC solo lo tengo en cuenta si el saldo de cuenta corriente es deudor para el cliente
				//decimal saldoCCFormat = (_saldoCC < 0) ? 0 : Math.Abs(_saldoCC);
				decimal saldoCCFormat = _saldoCC;

				_saldoComprobante = Decimal.Round(_totalComprobante - _totalPago,2);
				if (_saldoComprobante > 0) 
				{
                    /* Silvina 20100712 - Tarea 792 */
                    decimal limiteCredito = tsa_Cuentas.GetByPk(_idCuenta).LimiteDeCredito;
                    if (limiteCredito > 0)
                        return false;
                    else
                        return true;
                    /* Fin Silvina */
					/*if ( _limiteDeCredito < _saldoComprobante + saldoCCFormat) 
					{
						return false;
					}
					else 
					{
						return true;
					}*/
				}
				else 
				{
					return true;
				}
				return false;
			}
			else return true;
		}

        /// <summary>
        /// Excluyes the flujo comprobante origen destino.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
		private bool ExcluyeFlujoComprobanteOrigenDestino(ItemComprobante item)
		{
			string flujos = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "PermiteDescuento.FlujosTiposComprobantesExcluidos");
			if(flujos != string.Empty)
			{
				string[] arelacionComprobantesPrevios = flujos.Split( ',');
				if (arelacionComprobantesPrevios.Length > 0)
				{
					for(int i=0;i<arelacionComprobantesPrevios.Length;i++)
					{
						string[] atupla = arelacionComprobantesPrevios[i].Split(':');
						if (atupla.Length == 2)
						{
							if(( item.IdTipoComprobanteOrigen == atupla[0] || (item.IdTipoComprobanteOrigen == null && atupla[0] == string.Empty))
								&& ( item.ItemsComprobantes.ComprobanteDeVenta.TipoComprobanteDestino == (atupla[1]) || (item.ItemsComprobantes.ComprobanteDeVenta.TipoComprobanteDestino == null && atupla[1] == string.Empty)))		
								return true;
						}
					}
					
				}
			}
			return false;
		}

		
		private bool TipoComprobanteOK() 
		{	
			//obtengo los tipos de comprobante de las variables que me exigen pedir autorizacion
			//esas variables las paso a ArrayList y veo si contains el tipo de comprobante de mi comprobante
			//si no lo contiene devuelvo true
			string variable = "Seguridad.Autorizaciones.TiposDeComprobanteParaAutorizar";
			string TiposDeComprobantes = Variables.GetValueString(variable);
			ArrayList array = systemframework.Util.Parse(TiposDeComprobantes,",");
			if (array.Contains(_tipoDeComprobante))
				return false;
			else
				return true;						
		}
		
		private bool ChequesOK() 
		{	
			//obtengo los tipos de comprobante de las variables que me exigen pedir autorizacion
			//esas variables las paso a ArrayList y veo si contains el tipo de comprobante de mi comprobante
			//si no lo contiene devuelvo true			
			bool resultado = true;
			string variable = "Seguridad.Autorizaciones.ChequesParaAutorizar";
			string FormasDePago = Variables.GetValueString(variable);						
			ArrayList array = systemframework.Util.Parse(FormasDePago,",");

			foreach(Valor valor in _valores)
				//for (int i = 1; i <= _valores.Count; i++)  
			{				
				//Valor valor = (Valor) _valores[i-1];				
				if (array.Contains(valor.IdTDCompTesoreria))
				{
					_valoresParaAutorizar.Add(valor);
					resultado = false;
				}					
			}	
			return resultado;			
		}	

		private bool FormasDePagoOK() 
		{	
			//obtengo los tipos de comprobante de las variables que me exigen pedir autorizacion
			//esas variables las paso a ArrayList y veo si contains el tipo de comprobante de mi comprobante
			//si no lo contiene devuelvo true			
			bool resultado = true;
			string variable = "Seguridad.Autorizaciones.FormasDePagoParaAutorizar";
			string FormasDePago = Variables.GetValueString(variable);						
			ArrayList array = systemframework.Util.Parse(FormasDePago,",");

			foreach(Valor valor in _valores)
			//for (int i = 1; i <= _valores.Count; i++)  
			{				
				//Valor valor = (Valor) _valores[i-1];				
				if (array.Contains(valor.IdTDCompTesoreria))
				{
					_valoresParaAutorizar.Add(valor);
					resultado = false;
				}					
			}	
			return resultado;			
		}			

		private string StringBuildCV() 
		{
			string cadena = String.Empty;
			cadena = cadena + String.Format("Condición de venta {0} no permitida para el cliente", _condicionDeVenta.ToUpper()) + ";" ;
			cadena = cadena + String.Format("Cliente: {0}. Código: {1}", _cuenta, _cuentaCodigo) + ";" ;
			return cadena;
		}
		private string StringBuildCC() 
		{
			string cadena = String.Empty;
			cadena = "Límite de crédito excedido" + ";" ;
			cadena = cadena + String.Format("Cliente: {0}. Código: {1}", _cuenta, _cuentaCodigo)+ ";" ;
			cadena = cadena + String.Format("Límite de crédito: {0}", _limiteDeCredito.ToString())+ ";" ;
			cadena = cadena + String.Format("Saldo Cta. Cte.: {0}", _saldoCC.ToString())+ ";" ;
			cadena = cadena + String.Format("Saldo comprobante: {0}", _saldoComprobante.ToString())+ ";";			
			return cadena;
		}

		private string StringBuildDesc() 
		{
			string cadena = String.Empty;
			cadena = "Descuento superior al permitido" + ";" ;

			ItemsComprobantes items = _items;
			foreach (ItemComprobante item in _items) 
			{				
				decimal precioBruto = Math.Round(item.PrecioDeVentaBruto,2);
				decimal precioMinimo = Math.Round(item.PrecioDeVentaNetoMinimo,2);
				if (precioBruto < precioMinimo) 
				{
					cadena = cadena + Tab + String.Format("Código {1} Producto: {0} Precio Neto {2} Precio Vendido {3}", item.DescripcionCorta.ToUpper(), item.Codigo, Math.Round(precioMinimo,2), Math.Round(precioBruto,2)) + ";";
				}
			}						
			return cadena;
		}
		


		string Enter = "<br>";
		string Tab = "&nbsp;";

		private string StringBuildCV_HTML() 
		{
			string cadena = String.Empty;		
			cadena = cadena + "<b><u><font size=\"2\"><p align=\"left\">Condición de venta no permitida para el cliente" + "</font></u></b>" + Enter ;
			cadena = cadena + "<font size=\"2\">";							
			//cadena = cadena + Enter;
			cadena = cadena + Tab + String.Format("Condición de venta: <b>{0}</b>", _condicionDeVenta.ToUpper()) + Enter ;			
			cadena = cadena + "</font>";
			cadena = cadena + Enter;
			return cadena;
		}
		private string StringBuildCC_HTML() 
		{
			string cadena = String.Empty;		
			cadena = cadena + "<b><u><font size=\"2\"><p align=\"left\">Límite de crédito excedido" + "</font></u></b>" + Enter ;
			cadena = cadena + "<font size=\"2\">";					
			//cadena = cadena + Enter;
			cadena = cadena + Tab + String.Format("Límite de crédito: {0}", _limiteDeCredito.ToString())+ Enter ;
			cadena = cadena + Tab + String.Format("Saldo Cta. Cte.: {0}", _saldoCC.ToString())+ Enter ;
			cadena = cadena + Tab + String.Format("Saldo de la factura: {0}", _saldoComprobante.ToString())+ Enter;
			decimal SaldoCtaCte = _saldoCC + _saldoComprobante;
			cadena = cadena + Tab + String.Format("Saldo Cta. Cte. con esta factura: {0}", SaldoCtaCte.ToString())+ Enter;			
			cadena = cadena + "</font>";			
			cadena = cadena + Enter;
			return cadena;
		}

		private bool DescuentoOK() 
		{								
			if(_items != null)
			{
				ItemsComprobantes items = _items;
				string comodines = Variables.GetValueString(this._processParent.Process.ProcessName, this._processParent.Process.MainTask.KeyTask, "Emision.Editar.Items.ListaItemComodin");
				bool autorizaItemComodines = Variables.GetValueBool(this._processParent.Process.ProcessName, this._processParent.Process.MainTask.KeyTask, "RequiereAutorizarItemComodin");
				ArrayList comodinesList = mz.erp.systemframework.Util.Parse(comodines, ",");
				foreach (ItemComprobante item in _items) 
				{				
					if(!ExcluyeFlujoComprobanteOrigenDestino(item))
					{
						if(!comodinesList.Contains(item.IdProducto) || 
							(comodinesList.Contains(item.IdProducto) && autorizaItemComodines ))
						{
							decimal precio = Math.Round(item.PrecioDeVentaBruto,2);
							decimal precioMinimo = 0;
							DataRow rowP = mz.erp.businessrules.tsh_Productos.GetByPk(item.IdProducto);
							if(rowP != null)
							{
								decimal precioNeto = Convert.ToDecimal(rowP["PrecioDeVentaNeto"]);
								string IdCotizacion = Convert.ToString(rowP["IdCotizacionCierrePrecioDeVentaNeto"]);
								Cotizacion cot = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCotizacion(IdCotizacion);
								precioMinimo = Math.Round(precioNeto * cot.Valor,2);
							}
							decimal result = precio - precioMinimo;
							if (result < Convert.ToDecimal(-0.05)) 
							{
								return false;
							}
						}
					}
				}	
			}
			return true;
		}
		private string StringBuildDesc_HTML() 
		{
			string cadena = String.Empty;
			cadena = cadena + "<b><u><font size=\"2\"><p align=\"left\">Descuento superior al permitido" + "</font></u></b>" + Enter ;
			cadena = cadena + "<font size=\"2\">";				
			//cadena = cadena + Enter;
			cadena = cadena + "<b>Artículos con descuento superior al permitido" + "</b>" + Enter ;
			string comodines = Variables.GetValueString(this._processParent.Process.ProcessName, this._processParent.Process.MainTask.KeyTask, "Emision.Editar.Items.ListaItemComodin");
			bool autorizaItemComodines = Variables.GetValueBool(this._processParent.Process.ProcessName, this._processParent.Process.MainTask.KeyTask, "RequiereAutorizarItemComodin");
			ArrayList comodinesList = mz.erp.systemframework.Util.Parse(comodines, ",");
				
			ItemsComprobantes items = _items;
			foreach (ItemComprobante item in _items) 
			{		
				if(!ExcluyeFlujoComprobanteOrigenDestino(item))
				{
					if(!comodinesList.Contains(item.IdProducto) || 
						(comodinesList.Contains(item.IdProducto) && autorizaItemComodines ))
					{
						
						decimal precioBruto = Math.Round(item.PrecioDeVentaBruto * item.Cantidad,2);
						decimal precioMinimo = 0;
						DataRow rowP = mz.erp.businessrules.tsh_Productos.GetByPk(item.IdProducto);
						if(rowP != null)
						{
							decimal precioNeto = Convert.ToDecimal(rowP["PrecioDeVentaNeto"]);
							string IdCotizacion = Convert.ToString(rowP["IdCotizacionCierrePrecioDeVentaNeto"]);
							Cotizacion cot = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCotizacion(IdCotizacion);
							precioMinimo = Math.Round(precioNeto * item.Cantidad * cot.Valor,2);
						}
						decimal result = precioBruto - precioMinimo;
						if (result < Convert.ToDecimal(-0.05)) 
						{
							if(item.PorcentajeDescuento != 0)
								cadena = cadena + Tab + String.Format("Código {1} Producto: {0} Cantidad {4} Precio Neto {2} Precio Neto Vendido {3} Descuento {5}", item.DescripcionCorta.ToUpper(), item.Codigo, precioMinimo, precioBruto, item.Cantidad, item.PorcentajeDescuento) + Enter;
							else
								cadena = cadena + Tab + String.Format("Código {1} Producto: {0} Cantidad {4} Precio Neto {2} Precio Neto Vendido {3}", item.DescripcionCorta.ToUpper(), item.Codigo, precioMinimo, precioBruto, item.Cantidad) + Enter;
						}
					}
				}				
			}						
			cadena = cadena + "</font>";
			cadena = cadena + Enter;
			return cadena;
		}
		private string StringBuildTipoComprobante_HTML()
		{
			string cadena = String.Empty;						
			string TipoDeComprobante = tsy_TiposDeComprobantes.GetByPk(_tipoDeComprobante).Descripcion;			
			cadena = cadena + "<b><u><font size=\"2\"><p align=\"left\">Tipo de comprobante no permitido" + "</font></u></b>" + Enter ;
			cadena = cadena + "<font size=\"2\">";	
			cadena = cadena + Tab + String.Format("Tipo de comprobante: <b>{0}</b>", TipoDeComprobante.ToUpper()) + Enter ;			
			cadena = cadena + "</font>";
			cadena = cadena + Enter;			
			return cadena;
		}

		private string StringBuildCheques_HTML()
		{
			string cadena = String.Empty;	
			if(_pagoCompras)
			{
				cadena = cadena + "<b><u><font size=\"2\"><p align=\"left\">Proveedor " + "</font></u></b>" + Enter ;
				cadena = cadena + "<font size=\"2\">";	
				cadena = cadena + Tab + String.Format("<b>{0}</b>",_proveedor ) + Enter + Enter ;	
			}

			cadena = cadena + "<b><u><font size=\"2\"><p align=\"left\">Forma/s de pago a Validar" + "</font></u></b>" + Enter ;
            cadena = cadena + "<font size=\"2\">";	
			cadena = cadena + Enter;		

			foreach(Valor valor in _valores)
			{
				decimal monto = Math.Round(valor.MontoCotizado, 2);
				string comp = valor.Comprobante;
				if(_valoresParaAutorizar.Contains(valor))
				{
					
					string entidad = valor.Banco;
					string numero = valor.Numero;
					string cuenta = valor.CuentaBancaria;
					string suc = valor.Sucursal;
					DateTime fechaVenc = valor.FechaVencimiento;
					cadena = cadena + Tab + String.Format("<b>{0}</b> por {1}", valor.Comprobante.ToUpper(), monto) + Enter ;			
					cadena = cadena + Tab + String.Format("<b>Banco: </b> {0}",entidad ) + Enter ;			
					cadena = cadena + Tab + String.Format("<b>Número: </b> {0}",numero ) + Enter ;			
					cadena = cadena + Tab + String.Format("<b>Cuenta Bancaria: </b> {0}",cuenta ) + Enter ;			
					cadena = cadena + Tab + String.Format("<b>Sucursal: </b> {0}",suc ) + Enter ;			
					cadena = cadena + Tab + String.Format("<b>Fecha de Cobro: </b> {0}",fechaVenc.ToShortDateString() ) + Enter ;			
					cadena = cadena + Tab + String.Format("<b>Cruzado: </b> {0}", valor.Cruzado?"S":"N" );
					cadena = cadena + Tab + String.Format("<b>Sellado: </b> {0}", valor.Sellado?"S":"N" ) + Enter;
				}
				else
					cadena = cadena + Tab + String.Format("<b>{0}</b> por {1}", valor.Comprobante.ToUpper(), monto) + Enter ;			
				if(_pagoGastosServicios)
				{
					cadena = cadena + Enter ;
					cadena = cadena + "<b><u><font size=\"2\"><p align=\"left\">Facturas Imputadas" + "</font></u></b>" + Enter ;
					cadena = cadena + "<font size=\"2\">";	
					cadena = cadena + Enter ;	

					ArrayList comps = _pagarServicios.GetComprobantes(valor);
					foreach(ItemComprobanteDeCompraView item in comps)
					{
						string compro = item.Comprobante;
						string num = item.Numero;
						DateTime fechaV = item.FechaVencimiento;
						decimal total = Math.Round(item.Total,2);
						decimal saldo = Math.Round(item.Saldo,2);
						string prove = item.Proveedor;
						cadena = cadena + Tab + String.Format("<b>{0} {1} Proveedor:</b> {5}  <b>Fecha Vencimiento:</b> {2} <b>Importe:</b> {3} <b>Saldo:</b> {4}",compro, num, fechaV,total, saldo, prove  ) + Enter ;	
					}

				}
			}
			if(_pagoCompras)
			{
				if(_ctaCte != null)
				{
					cadena = cadena + Enter ;	
					cadena = cadena + "<b><u><font size=\"2\"><p align=\"left\">Facturas Imputadas" + "</font></u></b>" + Enter ;
					cadena = cadena + "<font size=\"2\">";	
					cadena = cadena + Enter ;	
			
					foreach(ItemCuentaCorriente item  in this._ctaCte)
					{
						if(item.Pago > 0)
						{
							string comp = item.Comprobante;
							string num = item.Numero;
							DateTime fechaV = item.FechaVencimiento;
							decimal monto = Math.Round(item.Importe,2);
							decimal saldo = Math.Round(item.Saldo,2);
							decimal pago = Math.Round(item.Pago,2);
							cadena = cadena + Tab + String.Format("<b>{0} {1}  Fecha Vencimiento:</b> {2} <b>Imputa:</b> {5} <b>Importe:</b> {3} <b>Saldo:</b> {4}",comp, num, fechaV,monto, saldo, pago  ) + Enter ;	
						}
					}
				}
			}
			
			cadena = cadena + "</font>";
			cadena = cadena + Enter;
			return cadena;
		}	

		private string StringBuildFormaDePago_HTML()
		{
			string cadena = String.Empty;						
			cadena = cadena + "<b><u><font size=\"2\"><p align=\"left\">Forma/s de pago no permitida/s" + "</font></u></b>" + Enter ;
			cadena = cadena + "<font size=\"2\">";	

			foreach(Valor valor in _valoresParaAutorizar)
			{
				decimal monto = Math.Round(valor.MontoCotizado, 2);
				cadena = cadena + Tab + String.Format("<b>{0}</b> por {1}", valor.Comprobante.ToUpper(), monto) + Enter ;			
			}
			cadena = cadena + "</font>";
			cadena = cadena + Enter;
			return cadena;
		}		
		
		private string StringBuildForProcess_HTML(string processName)
		{			
			string cadena = "";
			switch (processName)
			{
				case "ProcesoAjustarStockNegativo": return StringBuildAjusteDeStock_HTML();break;
				case "ProcesoAjustarStockPositivo": return StringBuildAjusteDeStock_HTML();break;
				case "ProcesoTransferenciaInternaDeStock": return StringBuildTransferenciaInternaDeStock_HTML();break;						
				default:
				{
					cadena = StringBuildProceso_HTML();					
					cadena = cadena + StringBuildGeneral_HTML();
				}

				break;
			}			
			return cadena;
		}


		private string StringBuildAjusteDeStock_HTML()
		{
			string cadena = string.Empty;
			cadena = cadena + "<font size=\"3\">";				
			cadena = cadena + "<b>Descripción del Ajuste de Stock" + "</b>" + Enter ;		
			cadena = cadena + "<font size=\"2\">";	
			cadena = cadena + Tab + String.Format("Tipo de Ajuste: {0}. ", _tipoDeAjusteOrigen) + Enter ;
			cadena = cadena + Tab + String.Format("Estado de Stock asociado: {0}. ", _estadoOrigen) + Enter ;
			cadena = cadena + Tab + String.Format("Depósito: {0}. ", _depositoOrigen) + Enter ;
			cadena = cadena + Tab + String.Format("Sección: {0}. ", _seccionOrigen) + Enter ;
			cadena = cadena + Enter;
			cadena = cadena + Tab + "Artículos: " + Enter;
			foreach(ItemAjuste item in _itemsAjuste)
			{
				cadena = cadena + Tab + Tab + String.Format("Código {1} Producto: {0} Cantidad: {2} Stock: {3}", item.Descripcion.ToUpper(), item.Codigo, item.Cantidad.ToString(), item.StockDisponible.ToString() ) + Enter;
			}
			cadena = cadena + Enter;
			cadena = cadena + Tab + "Números de Series: " + Enter;
			ArrayList aux = new ArrayList();
			foreach(ItemAjuste item in _itemsAjuste)
			{
				if(!aux.Contains(item.IdProducto))
				{
					aux.Add(item.IdProducto);
					ArrayList nrosDeSerie = _itemsNumerosDeSerie.Filter(item.IdProducto, null);
					if(nrosDeSerie.Count > 0)
					{
						cadena = cadena + Tab + Tab + String.Format("Código {0}: ", item.Codigo);
						foreach(RegistrarNumerosDeSerie.ItemNumeroDeSerie it in nrosDeSerie)
							cadena = cadena + it.NumeroDeSerie + " ";
						cadena = cadena + Enter;
					}
				}
			}
			cadena = cadena + StringBuildAjustesObservaciones_HTML();
			
			return cadena;
		}

		private string StringBuildTransferenciaInternaDeStock_HTML()
		{
			string cadena = string.Empty;
			cadena = cadena + "<font size=\"3\">";				
			cadena = cadena + "<b>Transferencia Interna de Stock" + "</b>" + "</font>" + Enter ;
			cadena = cadena + "<font size=\"2\">";				
			cadena = cadena + Tab + "<b>Descripción Ajuste Origen" + "</b>" + "</font>" + Enter ;		
			
			cadena = cadena + Tab + String.Format("Tipo de Ajuste: {0}. ", _tipoDeAjusteOrigen) + Enter ;
			cadena = cadena + Tab + String.Format("Estado de Stock asociado: {0}. ", _estadoOrigen) + Enter ;
			cadena = cadena + Tab + String.Format("Depósito: {0}. ", _depositoOrigen) + Enter ;
			cadena = cadena + Tab + String.Format("Sección: {0}. ", _seccionOrigen) + Enter ;
			cadena = cadena + Enter;
			
			
			cadena = cadena + Tab + "<b>Descripción Ajuste Destino" + "</b>" + "</font>" + Enter ;		
			
			cadena = cadena + Tab + String.Format("Tipo de Ajuste: {0}. ", _tipoDeAjusteDestino) + Enter ;
			cadena = cadena + Tab + String.Format("Estado de Stock asociado: {0}. ", _estadoDestino) + Enter ;
			cadena = cadena + Tab + String.Format("Depósito: {0}. ", _depositoDestino) + Enter ;
			cadena = cadena + Tab + String.Format("Sección: {0}. ", _seccionDestino) + Enter ;
			cadena = cadena + Enter;
			

			
			cadena = cadena + Tab + "<b>Artículos: </b>" + Enter;
			foreach(ItemAjuste item in _itemsAjuste)
			{
				cadena = cadena + Tab + Tab + String.Format("Código {1} Producto: {0} Cantidad: {2} Stock: {3}", item.Descripcion.ToUpper(), item.Codigo, item.Cantidad.ToString(), item.StockDisponible.ToString() ) + Enter;
			}
			cadena = cadena + Enter;
			cadena = cadena + Tab + "<b>Números de Series: </b>" + Enter;
			ArrayList aux = new ArrayList();
			foreach(ItemAjuste item in _itemsAjuste)
			{
				if(!aux.Contains(item.IdProducto))
				{
					aux.Add(item.IdProducto);
					ArrayList nrosDeSerie = _itemsNumerosDeSerie.Filter(item.IdProducto, null);
					if(nrosDeSerie.Count > 0)
					{
						cadena = cadena + Tab + Tab + String.Format("Código {0}: ", item.Codigo);
						foreach(RegistrarNumerosDeSerie.ItemNumeroDeSerie it in nrosDeSerie)
							cadena = cadena + it.NumeroDeSerie + " ";
						cadena = cadena + Enter;
					}
				}
			}
			cadena = cadena + "</font>";
			cadena = cadena + StringBuildAjustesObservaciones_HTML();			
			return cadena;
		}

			
		private string StringBuildProceso_HTML()
		{
			string cadena = String.Empty;		
			cadena = cadena + "<b><u><font size=\"2\"><p align=\"left\">" + _motivo + "</font></u></b>" + Enter ;
			cadena = cadena + "<font size=\"2\">";					
			cadena = cadena + "</font>";			
			cadena = cadena + Enter;
			return cadena;
		}

	

		private string StringBuildGeneral_HTML() 
		{
			_pendienteGeneralHTML = false;
			string IdCondicionDeVenta = MAPStaticInfo.GetIdCV("Cuenta Corriente");
			bool OperaCtaCte = tsa_CuentasCondicionesDeVenta_TDCompTesoreria.GetActivo(_idCuenta, IdCondicionDeVenta, _tipoDeComprobante);
			string StrOperaCtaCTe = (OperaCtaCte ? "SI" : "NO");
			string cadena = String.Empty;
			cadena = cadena + "<font size=\"2\">";				
			cadena = cadena + "<b>General" + "</b>" + Enter ;			

			cadena = cadena + Tab + String.Format("Cliente: {0}. Código: {1}", _cuenta, _cuentaCodigo) + Enter ;
			cadena = cadena + Tab + String.Format("Monto total de la factura: {0}", _totalComprobante.ToString())+ Enter;
			cadena = cadena + Tab + String.Format("Saldo de la factura: {0}", _saldoComprobante.ToString())+ Enter;
			cadena = cadena + Tab + String.Format("Condición de venta: {0}", _condicionDeVenta.ToString())+ Enter;
			//cadena = cadena + Tab + String.Format("Forma de pago: {0}", ) + Enter;
			cadena = cadena + Tab + String.Format("Opera en cuenta corriente: {0}", StrOperaCtaCTe)+ Enter;
			cadena = cadena + Tab + String.Format("Saldo de cta.cte.: {0}", _saldoCC.ToString())+ Enter;
			cadena = cadena + Tab + String.Format("Límite de crédito: {0}", _limiteDeCredito.ToString())+ Enter;
			
			if (_observacionesComp != String.Empty)
			{
				cadena = cadena + Enter;
				cadena = cadena + Tab + "<b>Observaciones:" + "</b>" + _observacionesComp + Enter;			
			}			
			cadena = cadena + Enter;
			cadena = cadena + Tab + "Artículos vendidos:" + Enter;

			ItemsComprobantes items = _items;
			foreach (ItemComprobante item in _items) 
			{								
				decimal precioBruto = Math.Round(item.Cantidad * item.PrecioDeVentaBruto,2);
				decimal precioSubTotal = Math.Round(item.SubTotalConImpuestos,2);
				//decimal precioMinimo = 0;							
				/*DataRow rowP = mz.erp.businessrules.tsh_Productos.GetByPk(item.IdProducto);
				if(rowP != null)
				{
					decimal precioNeto = Convert.ToDecimal(rowP["PrecioDeVentaNeto"]);
					string IdCotizacion = Convert.ToString(rowP["IdCotizacionCierrePrecioDeVentaNeto"]);
					Cotizacion cot = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCotizacion(IdCotizacion);
					precioMinimo = Math.Round(item.Cantidad * precioNeto * cot.Valor,2);
				}*/
				cadena = cadena + Tab + Tab + String.Format("Código {1} Producto: {0} Cantidad {4} Precio Neto Vendido {2} Precio Final {3}", item.DescripcionLarga.ToUpper(), item.Codigo, precioBruto, precioSubTotal, item.Cantidad) + Enter;				
			}						
			cadena = cadena + "</font>";
			cadena = cadena + Enter;			
			return cadena;
		}


		private string StringBuildAjustesObservaciones_HTML()
		{
			string cadena = String.Empty;	
			if (_observacionesAj != String.Empty)
			{
				
				cadena = cadena + Enter;
				cadena = cadena + Tab + "<b>Observaciones:" + "</b>" + _observacionesAj + Enter;			
			}			
			return cadena;
		}
		public void ComenzarSolicitud() 
		{
			if (!_autorizado) 
			{
				GenerarSolicitud();
				if (!_autorizado)
				{
					EsperarSolicitud();
					if (_autorizado) 
					{
						this.Execute();
					}
				}
				else 
				{
					this.Execute();
				}
			}
			else 
			{
				this.Execute();
			}
		}

		
		private void GenerarSolicitud() 
		{			
			if (_idAutorizacion == String.Empty) //Genera nueva solicitud con estado PA
			{
				tsh_AutorizacionesDataset.tsh_AutorizacionesRow row = businessrules.tsh_Autorizaciones.NewRow();

				row.IdResponsable = this._responsable;
				row.Motivo = _motivo;
				row.Datos = _datos;
				row.Estado = "PA"; //Pendiente de Autorización

				businessrules.tsh_Autorizaciones.Update(row);
				_idAutorizacion = row.IdAutorizacion;
			}
			else 
			{
				tsh_AutorizacionesDataset.tsh_AutorizacionesRow row = businessrules.tsh_Autorizaciones.GetByPk(_idAutorizacion);
				/*if (row.Estado != "RPA") //Si ya está en estado RPA no tiene sentido que modifique la row
				{*/
					if (row.Estado == "A") 
					{
						_autorizado = true;
					}
					if (row.Estado == "R")  //Rechazado Pendiente de Autorización. Ya fue desautorizado y se vuelve a solicitar.
					{
						_observaciones = row.Observaciones;
						row.Estado = "RPA"; 
						businessrules.tsh_Autorizaciones.Update(row);						
					}
					if (row.Estado == "PA")
					{
						bool na = NecesitaAutorizar();
						row.Datos = _datos;
						businessrules.tsh_Autorizaciones.Update(row);
					}
					if (row.Estado == "RPA")
					{
						bool na = NecesitaAutorizar();
						row.Datos = _datos;
						businessrules.tsh_Autorizaciones.Update(row);
					}
				/*}
				else 
				{*/
					//El tiempo se agotó y se reintenta la solicitud
				//}
			}
		}
		private void EliminarSolicitud() 
		{			
			tsh_AutorizacionesDataset.tsh_AutorizacionesRow row = businessrules.tsh_Autorizaciones.GetByPk(_idAutorizacion);			
			row.Estado = "MOD";
			businessrules.tsh_Autorizaciones.Update(row);
		}

		public void FormHasClosed() 
		{
			if (_idAutorizacion != "")
			{
				bool Borra = Variables.GetValueBool("Momentos.Autorizar.EliminarAlSalir");
				if (Borra) 
				{
					tsh_AutorizacionesDataset.tsh_AutorizacionesRow row = businessrules.tsh_Autorizaciones.GetByPk(_idAutorizacion);
					row.Estado = "DEL";
					businessrules.tsh_Autorizaciones.Update(row);
				}			
			}
		}

		AutoResetEvent autoEvent = null;
		int trans = 0;
		private void EsperarSolicitud() 
		{
			/// Este timer se configura según la cantidad de intentos que tiene que hacer o según la 
			/// duración total.
			/// Para el primer caso configurar las variables de la siguiente manera:
			/// int intentos = 10;
			/// int duracionTotal = _periodo *tu intentos + _inicio;
			/// Para el segundo caso colocar un valor grande en intentos
			/// int periodo = 1000;

			//caso 1			
			/*int intentos = 10;
			int duracionTotal = _periodo * intentos + _inicio;*/

			//caso 2
			int duracionTotal = _progresoMax;
			int intentos = 1000;

			autoEvent = new AutoResetEvent(false);
			ChequeoDeEstado chequeoDeEstado = new ChequeoDeEstado(intentos, _idAutorizacion);

			// Create the delegate that invokes methods for the timer.
			TimerCallback timerDelegate = new TimerCallback(chequeoDeEstado.CheckStatus);

			chequeoDeEstado.OnChangeEstado +=new EventHandler(chequeoDeEstado_OnChangeEstado);

					

			System.Threading.Timer stateTimer = new System.Threading.Timer(timerDelegate, autoEvent, _inicio, _periodo);

			//System.Threading.Thread.CurrentThread.IsBackground = true;

			//autoEvent.WaitOne(duracionTotal, false);
			//((System.Threading.Thread) autoEvent).Suspend();
			

			/*
			while(trans < duracionTotal)
			{
				autoEvent.WaitOne();
				trans = chequeoDeEstado.Progreso;
			}
			*/
			autoEvent.WaitOne(duracionTotal, false);
			
			if (!chequeoDeEstado.Autorizado)  
			{
				Progreso = duracionTotal;				
			}

			stateTimer.Dispose();	
			
			
			_autorizado = chequeoDeEstado.Autorizado;
			_observaciones = chequeoDeEstado.Observaciones;
			_responsableDeAutorizacion = chequeoDeEstado.ResponsableDeAutorizacion;
			
			
		}

		private void chequeoDeEstado_OnChangeEstado(object sender, EventArgs e)
		{
			ChequeoDeEstado estado = (ChequeoDeEstado) sender;
			Progreso = estado.Progreso * this._periodo;
		}

		/*private void SolicitarAutorizacion_OnCloseForm(object sender, EventArgs e)
		{
			EliminarSolicitud();
		}*/
	}





	class ChequeoDeEstado
	{
		public event System.EventHandler OnChangeEstado;
		public event System.EventHandler OnChangeDatos;
		int _invokeCount, _maxCount;				
		bool _autorizado = false;
		

		public ChequeoDeEstado(int count, string IdAutorizacion)
		{
			_invokeCount  = 0;
			_maxCount = count;
			_idAutorizacion = IdAutorizacion;
		}

		string _idAutorizacion = String.Empty;
		public bool Autorizado 
		{
			get 
			{ 
				return _autorizado;
			}
		}


		string _observaciones = String.Empty;
		public string Observaciones
		{
			get 
			{ 
				return _observaciones;
			}
		}		

		private string _responsableDeAutorizacion = String.Empty;
		public string ResponsableDeAutorizacion
		{
			get 
			{ 
				return _responsableDeAutorizacion;
			}
		}

		public int Progreso 
		{			
			get 
			{
				return _invokeCount;
			}
			set 
			{				
				if (OnChangeEstado != null) 
				{
					OnChangeEstado( this , new System.EventArgs());
				}			
			}
		}

		// This method is called by the timer delegate.
		public void CheckStatus(Object stateInfo)
		{						
			AutoResetEvent autoEvent = (AutoResetEvent)stateInfo;
			//autoEvent.WaitOne();
	            
			Console.WriteLine("{0} Checking status {1,2}.", mz.erp.businessrules.Sistema.DateTime.Now.ToString("h:mm:ss.fff"), (++ _invokeCount).ToString());			
			Progreso = _invokeCount;
			

			if(_invokeCount == _maxCount)
			{
				// Reset the counter and signal Main.				
				_autorizado = false;
				_invokeCount  = 0;
				autoEvent.Set();
			}

			tsh_AutorizacionesDataset.tsh_AutorizacionesRow row = businessrules.tsh_Autorizaciones.GetByPk(_idAutorizacion);
			if (row.Estado == "A") //AUTORIZADO - Dejó de estar Pendiente de Autorizacion
			{
				_invokeCount  = 0;
				_autorizado = true;
				_observaciones = row.Observaciones;
				autoEvent.Set();
			}			

			if (row.Estado == "R") 
			{
				tsh_PersonasDataset.tsh_PersonasRow rowP = businessrules.tsh_Personas.GetByPk(row.IdResponsableDeAutorizacion);
				_responsableDeAutorizacion =  rowP.Nombre;

				_invokeCount  = 0;
				_autorizado = false;
				_observaciones = row.Observaciones;
				autoEvent.Set();
			}			
			row.Table.Dispose();
		}
	}
}

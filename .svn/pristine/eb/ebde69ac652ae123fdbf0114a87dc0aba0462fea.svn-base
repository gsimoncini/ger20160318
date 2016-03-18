using System;
using System.Collections;
using mz.erp.businessrules;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ProcessControlllerManager.
	/// </summary>
	public class ProcessControllerManager
	{
		private ProcessManager brProcess = null;
		public event System.EventHandler OnProcessMessageChanged;
		public event System.EventHandler OnProgressCounterChanged;
		public event System.EventHandler OnProcessHadProblems;
		public delegate void OnNextTaskHandler(ControllerDynamicInfo taskController);
		public delegate void OnPreviousTaskHandler(ControllerDynamicInfo taskController);
		public delegate void OnEndProcessHandler(ControllerDynamicInfo taskController);
		public delegate void OnProcessErrorsHandler(ControllerDynamicInfo taskController);
		public delegate void OnProcessWarningsHandler(ControllerDynamicInfo taskController);
		public delegate void OnProcessErrorsOnStartHandler(ItemsDatasetErrors errors);
		public delegate void OnProcessErrorFlushHandler(ControllerDynamicInfo taskController, string mensaje, ItemsDatasetErrors flushErrors);
		public event OnNextTaskHandler OnNextTask;
		public event OnNextTaskHandler OnPreviousTask;
		public event OnProcessErrorsHandler OnProcessErrors;
		public event OnProcessWarningsHandler OnProcessWarnings;
		public event OnEndProcessHandler OnEndProcess;
		public event OnProcessErrorsOnStartHandler OnProcessErrorsOnStart;
		public event OnProcessErrorFlushHandler OnProcessFlushError;

		private string _processName = string.Empty;
		private string _controllerMessage = string.Empty;

		public string GetProcessName()
		{
			return _processName;
		}
		public ProcessControllerManager( )
		{
			
		}
		public void CreateNewProcess( string processName, Hashtable parametros )
		{
			brProcess = new mz.erp.businessrules.ProcessManager( );
			brProcess.OnProcessMessageChanged+= new System.EventHandler( this.ListenerProcessMessage );
			brProcess.OnProgressCounterChanged+= new System.EventHandler( this.ListenerProcessProgress );
			//brProcess.OnProcessHadProblems+=new EventHandler(this.ListenerProcessHadProblems);
			brProcess.CreateNewProcess( processName, parametros );			
			brProcess.OnNextTask +=new mz.erp.businessrules.ProcessManager.OnNextTaskHandler(this.ListenerProcessNextTask);
			brProcess.OnPreviousTask +=new mz.erp.businessrules.ProcessManager.OnPreviousTaskHandler(this.ListenerProcessPreviousTask);
			brProcess.OnEndProcess +=new mz.erp.businessrules.ProcessManager.OnEndProcessHandler(this.ListenerEndProcess);
			brProcess.OnProcessErrors +=new mz.erp.businessrules.ProcessManager.OnProcessErrorsHandler(this.ListenerProcessErrors);
			brProcess.OnProcessWarnings +=new mz.erp.businessrules.ProcessManager.OnProcessWarningsHandler(this.ListenerProcessWarnings);
			brProcess.OnProcessErrorsOnStart +=new mz.erp.businessrules.ProcessManager.OnProcessErrorsOnStartHandler(this.ListenerProcessErrorsOnStart);
			brProcess.OnErrorFlushProcess +=new mz.erp.businessrules.ProcessManager.OnProcessErrorFlushHandler(this.ListenerProcessErrorsFlush);

			_processName = processName;
			SetMessage( "Cargando Controladores..." );
			CallControllers();
			if (Variables.GetValueBool("Debug.StatusBar.MostrarNombreProceso",false))
			{
				string AdmMensaje = String.Format("{0}-{1}", brProcess.Process.IdProcess.ToString(), _processName);
				SetMessage( AdmMensaje );				
			}
			else
				SetMessage( "Listo." );
		}

		public void StartProcess()
		{
			brProcess.StartProcess();
		}

		public void SetMessage(string message)
		{
			this._controllerMessage = message;
			if (this.OnProcessMessageChanged != null)
				OnProcessMessageChanged( null, new System.EventArgs() );
		}
		public string ControllerMessage
		{
			get { return this._controllerMessage ; }
		}
		public void ListenerProcessMessage( object sender, System.EventArgs e)
		{
			this.SetMessage(this.brProcess.ProcessMessage) ;
		}
		public void ListenerProcessProgress( object sender, System.EventArgs e )
		{
			if (this.OnProgressCounterChanged != null)
				OnProgressCounterChanged( null, new System.EventArgs() );
		}
		
		public void ListenerProcessHadProblems( object sender, System.EventArgs e )
		{
			if (this.OnProcessHadProblems != null)
				OnProcessHadProblems( null, new System.EventArgs() );
		}
			
		public int ProcessProgress
		{
			get { return this.brProcess.ProgressCounter; }
		}
		public int ProcessProgressTop
		{
			get { return this.brProcess.ProgressCounterTop; }
		}

		private Hashtable _controllersInstances = new Hashtable();
		private void CallControllers( )
		{
			ArrayList sortedTask = brProcess.SortedTasks(TaskStaticInfo.SortOrder.OrderBR);
			foreach (TaskDynamicInfo _task in sortedTask )
			{
				ControllerDynamicInfo controller = CallStaticController( _task );
				if (controller != null)
				{
					_controllersInstances.Add(_task.KeyTask,  controller );
				}
			}
		}

		private static System.Collections.SortedList _controllertypes = new SortedList();
	
		private static void DeclareTypes()
		{			//Nombre de la tarea						Nombre que evalue el manejador de formularios
			_controllertypes=ControllerTarea.Controls;

		}

		private ControllerDynamicInfo CallStaticController( TaskDynamicInfo _task )
		{
			if (_controllertypes.Count == 0)
			{
				DeclareTypes();
			}
			ControllerDynamicInfo controller = new ControllerDynamicInfo();
			//if (_controllertypes.ContainsKey( _task.KeyTask ))
			//{ca
				string _grupo = (string)_controllertypes[ _task.KeyTask ];
				switch (_grupo )
				{
					case "ComprobanteDeVenta": 
						controller.ControllerInstance = new mz.erp.ui.controllers.ComprobantesDeVentaController( (mz.erp.businessrules.comprobantes.ComprobanteDeVenta)_task.TaskInstance );
						controller.KeyController = "ComprobanteDeVenta";
						controller.KeyTask = _task.KeyTask;
						break;

					case "EditarComprobanteDeVenta": 
						controller.ControllerInstance = new mz.erp.ui.controllers.EditarComprobanteDeVentaController( (mz.erp.businessrules.EditarComprobanteDeVenta)_task.TaskInstance );
						controller.KeyController = "EditarComprobanteDeVenta";
						controller.KeyTask = _task.KeyTask;
						break;

					case "ComprobanteDePago":
						controller.ControllerInstance = new mz.erp.ui.controllers.ComprobantesDePagoController( (mz.erp.businessrules.comprobantes.ComprobanteDePago)_task.TaskInstance );
						controller.KeyController = "ComprobanteDePago";
						controller.KeyTask = _task.KeyTask;
						break;

					case "ComprobanteDeEntrega":
						controller.ControllerInstance = new mz.erp.ui.controllers.EntregasController( (mz.erp.businessrules.comprobantes.ComprobanteDeEntrega)_task.TaskInstance );
						controller.KeyController = "ComprobanteDeEntrega";
						controller.KeyTask = _task.KeyTask;
						break;

					case "ComprobantesPendientes":
						controller.ControllerInstance = new mz.erp.ui.controllers.ComprobantesPendientesController( ( mz.erp.businessrules.ComprobantesPendientes )_task.TaskInstance );
						controller.KeyController = "ComprobantesPendientes";
						controller.KeyTask = _task.KeyTask;
						break;

					case "ComprobantesDeCompraPendientes":					
						controller.ControllerInstance = new mz.erp.ui.controllers.ComprobantesDeCompraPendientesController( ( mz.erp.businessrules.ComprobantesDeCompraPendientes )_task.TaskInstance );
						controller.KeyController = "ComprobantesDeCompraPendientes";
						controller.KeyTask = _task.KeyTask;
						break;
					case "SeleccionarComprobantesDeCompraPendientes":
						controller.ControllerInstance = new mz.erp.ui.controllers.SeleccionarComprobantesDeCompraPendientesController( ( mz.erp.businessrules.SeleccionarComprobantesDeCompraPendientes)_task.TaskInstance );
						controller.KeyController = "SeleccionarComprobantesDeCompraPendientes";
						controller.KeyTask = _task.KeyTask;
						break;

					case "SeleccionReparacionesPendientes":
						controller.ControllerInstance = new mz.erp.ui.controllers.ReparacionesPendientesController( ( mz.erp.businessrules.SeleccionReparacionesPendientes )_task.TaskInstance );
						controller.KeyController = "SeleccionReparacionesPendientes";
						controller.KeyTask = _task.KeyTask;
						break;

					case "SeleccionReparacionesAjustes":
						controller.ControllerInstance = new mz.erp.ui.controllers.ReparacionesAjustesController( ( mz.erp.businessrules.SeleccionReparacionAjustes )_task.TaskInstance );
						controller.KeyController = "SeleccionReparacionesAjustes";
						controller.KeyTask = _task.KeyTask;
						break;


					case "SeleccionarFormaDeEntrega" :
						controller.ControllerInstance = new mz.erp.ui.controllers.SeleccionarEstadoItemsController( ( mz.erp.businessrules.SeleccionEstadoDeItem )_task.TaskInstance );
						controller.KeyController = "SeleccionarFormaDeEntrega";
						controller.KeyTask = _task.KeyTask;
						break;

					case "ConceptosAdicionales" :
						controller.ControllerInstance = new mz.erp.ui.controllers.ConceptosAdicionalesController( ( mz.erp.businessrules.ConceptosAdicionales )_task.TaskInstance );
						controller.KeyController = "ConceptosAdicionales";
						controller.KeyTask = _task.KeyTask;
						break;

					case "SeleccionItemsPendientes":
						controller.ControllerInstance = new mz.erp.ui.controllers.ComprobantesSelectNController( ( mz.erp.businessrules.SeleccionItemsPendientes )_task.TaskInstance );
						controller.KeyController = "SeleccionarItemsPendientes";
						controller.KeyTask = _task.KeyTask;
						break;
					case "SeleccionItemsDeCompraPendientes":
						controller.ControllerInstance = new mz.erp.ui.controllers.ComprobantesDeCompraSelectNController( ( mz.erp.businessrules.SeleccionItemsDeCompraPendientes )_task.TaskInstance );
						controller.KeyController = "SeleccionItemsDeCompraPendientes";
						controller.KeyTask = _task.KeyTask;
						break;
					
					case "ListarComprobantesPendientes":
						controller.ControllerInstance = new mz.erp.ui.controllers.ListarComprobantesPendientesController( ( mz.erp.businessrules.ListarComprobantesPendientes )_task.TaskInstance );
						controller.KeyController = "ListarComprobantesPendientes";
						controller.KeyTask = _task.KeyTask;
						break;
					
					case "ListarComprobantes":
						controller.ControllerInstance = new mz.erp.ui.controllers.ListarComprobantesController( ( mz.erp.businessrules.ListarComprobantes )_task.TaskInstance );
						controller.KeyController = "ListarComprobantes";
						controller.KeyTask = _task.KeyTask;
						break;
					case "ListarComprobantesDV":
						controller.ControllerInstance = new mz.erp.ui.controllers.ListarComprobantesDVController( ( mz.erp.businessrules.ListarComprobantes )_task.TaskInstance );
						controller.KeyController = "ListarComprobantesDV";
						controller.KeyTask = _task.KeyTask;
						break;
										
					case "ImprimirReporteComprobanteDeVenta" :
						controller.ControllerInstance = new mz.erp.ui.controllers.ReportsController( ( mz.erp.businessrules.ImprimirReporteComprobanteDeVenta )_task.TaskInstance );
						controller.KeyController = "ImprimirReporteComprobanteDeVenta";
						controller.KeyTask = _task.KeyTask;
						break;
					case "SeleccionarFormasDePagos":
						controller.ControllerInstance = new mz.erp.ui.controllers.FormasDePagoController( ( mz.erp.businessrules.RecargosFormasDePago )_task.TaskInstance );
						controller.KeyController = "SeleccionarFormasDePagos";
						controller.KeyTask = _task.KeyTask;
						break;
					case "ImpresionComprobanteDeVentaFiscal" :
						controller.ControllerInstance = new mz.erp.ui.controllers.FiscalController( (mz.erp.businessrules.FiscalComprobantes) _task.TaskInstance);
						controller.KeyController = "ImpresionComprobanteDeVentaFiscal";
						controller.KeyTask = _task.KeyTask;
						break;
					case "EmisionCierreX" :
						controller.ControllerInstance = new mz.erp.ui.controllers.FiscalController( (mz.erp.businessrules.FiscalCierre) _task.TaskInstance);
						controller.KeyController = "EmisionCierreX";
						controller.KeyTask = _task.KeyTask;
						break;
					case "EmisionCierreZ" :
						controller.ControllerInstance = new mz.erp.ui.controllers.FiscalController( (mz.erp.businessrules.FiscalCierre) _task.TaskInstance);
						controller.KeyController = "EmisionCierreZ";
						controller.KeyTask = _task.KeyTask;
						break;
					case "ImprimirReporte":
						controller.ControllerInstance = new mz.erp.ui.controllers.ReportsGenericController( (mz.erp.businessrules.ImprimirReporte) _task.TaskInstance );
						controller.KeyController = "ImprimirReporte";
						controller.KeyTask = _task.KeyTask;
						break;
					case "SolicitudDeAutorizacion":
						controller.ControllerInstance = new mz.erp.ui.controllers.SolicitarAutorizacionController( (mz.erp.businessrules.SolicitarAutorizacion) _task.TaskInstance );
						controller.KeyController = "SolicitudDeAutorizacion";
						break;
					case "ABMCuentasCondicionesDeVenta":
						controller.ControllerInstance = new mz.erp.ui.controllers.AbmCuentasCondicionesDeVentaController( (mz.erp.businessrules.AbmCuentasCondicionesDeVenta) _task.TaskInstance );
						controller.KeyController = "ABMCuentasCondicionesDeVenta";
						break;	
					case "ABMCuentasObservaciones":
						controller.ControllerInstance = new mz.erp.ui.controllers.AbmCuentasObservacionesController( (mz.erp.businessrules.AbmCuentasObservaciones) _task.TaskInstance );
						controller.KeyController = "ABMCuentasObservaciones";
						break;							
					case "SeleccionarObservacion":
						controller.ControllerInstance = new mz.erp.ui.controllers.mzCuentasObservacionesSearchFormController( (mz.erp.businessrules.mzCuentasObservacionesSearchForm) _task.TaskInstance );
						controller.KeyController = "SeleccionarObservacion";
						break;				
						
					case "ABMCotizacionMoneda":

						controller.ControllerInstance = new mz.erp.ui.controllers.AbmCotizacionMonedaController( (mz.erp.businessrules.AbmCotizacionMoneda) _task.TaskInstance );
						controller.KeyController = "ABMCotizacionMoneda";
						break;							
					case "Autorizacion":
						controller.ControllerInstance = new mz.erp.ui.controllers.AutorizarController( (mz.erp.businessrules.Autorizar) _task.TaskInstance );
						controller.KeyController = "Autorizacion";
						break;
					case "ConsultarCaja":
						controller.ControllerInstance = new mz.erp.ui.controllers.ConsultasCajaController( ( mz.erp.businessrules.ConsultasDeCaja) _task.TaskInstance );
						controller.KeyController = "ConsultasCaja";
						controller.KeyTask = _task.KeyTask;
						break;

					case "ConsultarCajaTDCompTesoreria":
						controller.ControllerInstance = new mz.erp.ui.controllers.ConsultasCajaController( ( mz.erp.businessrules.ConsultasDeCaja) _task.TaskInstance );
						controller.KeyController = "ConsultarCajaTDCompTesoreria";
						controller.KeyTask = _task.KeyTask;
						break;

					case "ConsultarCajaDetallada":
						controller.ControllerInstance = new mz.erp.ui.controllers.ConsultasCajaController( ( mz.erp.businessrules.ConsultasDeCaja) _task.TaskInstance );
						controller.KeyController = "ConsultasCajaDetallada";
						controller.KeyTask = _task.KeyTask;
						break;

					case "RegistrarMovimientosDeCaja":
						controller.ControllerInstance = new mz.erp.ui.controllers.MovimientosDeCajaController( ( mz.erp.businessrules.MovimientosCaja) _task.TaskInstance );
						controller.KeyController = "RegistrarMovimientosDeCaja";
						controller.KeyTask = _task.KeyTask;
						break;
					
					case "ConsultarPendientesEntregas":
						controller.ControllerInstance = new mz.erp.ui.controllers.ComprobantesPendientesConsolaEntregas( ( mz.erp.businessrules.ComprobantesPendientesConsolaEntregas) _task.TaskInstance );
						controller.KeyController = "ConsultarPendientesEntregas";
						controller.KeyTask = _task.KeyTask;
						break;

					case "ComprobanteDeCompraCabecera":
						controller.ControllerInstance = new mz.erp.ui.controllers.IngresarComprobanteDeCompraCabeceraController( ( mz.erp.businessrules.IngresarComprobanteDeCompraCabecera) _task.TaskInstance );
						controller.KeyController = "ComprobanteDeCompraCabecera";
						controller.KeyTask = _task.KeyTask;
						break;
					
					case "ComprobanteDeCompra":
						controller.ControllerInstance = new mz.erp.ui.controllers.ComprobantesDeCompraController( ( mz.erp.businessrules.comprobantes.ComprobanteDeCompra) _task.TaskInstance );
						controller.KeyController = "ComprobanteDeCompra";
						controller.KeyTask = _task.KeyTask;
						break;

					case "RegistrarNumerosDeSerie":
						controller.ControllerInstance = new mz.erp.ui.controllers.RegistrarNumerosDeSerieController( ( mz.erp.businessrules.RegistrarNumerosDeSerie) _task.TaskInstance );
						controller.KeyController = "RegistrarNumerosDeSerie";
						controller.KeyTask = _task.KeyTask;
						break;
					case "TransferirValoresCaja":
						controller.ControllerInstance = new mz.erp.ui.controllers.TransferenciasValoresCajasController( ( mz.erp.businessrules.TransferirValores) _task.TaskInstance );
						controller.KeyController = "TransferirValoresCaja";
						controller.KeyTask = _task.KeyTask;
						break;

					case "AjustarStock":
						controller.ControllerInstance = new mz.erp.ui.controllers.AjusteDeStockController( ( mz.erp.businessrules.AjustarStock) _task.TaskInstance );
						controller.KeyController = "AjustarStock";
						controller.KeyTask = _task.KeyTask;
						break;

					case "Aceptacion":
						controller.ControllerInstance = new mz.erp.ui.controllers.AceptacionController ((mz.erp.businessrules.Aceptacion) _task.TaskInstance );
						controller.KeyController = "Aceptacion";
						controller.KeyTask = _task.KeyTask;
						break;

					case "MovimientoCaja":
						controller.ControllerInstance = new mz.erp.ui.controllers.MovimientoAjusteCajaController((mz.erp.businessrules.MovimientosCaja) _task.TaskInstance );
						controller.KeyController = "MovimientoCaja";
						controller.KeyTask = _task.KeyTask;
						break;

					case "CambiarContraseña":
						controller.ControllerInstance = new mz.erp.ui.controllers.CambiarContraseñaController( ( mz.erp.businessrules.CambiarContraseña) _task.TaskInstance );
						controller.KeyController = "CambioDeContraseña";
						controller.KeyTask = _task.KeyTask;
						break;
					case "HabilitarOpcionDeMenu":
						controller.ControllerInstance = new mz.erp.ui.controllers.HabilitarOpcionDeMenuController( ( mz.erp.businessrules.HabilitarOpcionDeMenu) _task.TaskInstance );
						controller.KeyController = "HabilitacionOpcionDeMenu";
						controller.KeyTask = _task.KeyTask;
						break;
					case "ABMProductos":
						controller.ControllerInstance = new mz.erp.ui.controllers.AbmProductosController( (mz.erp.businessrules.AbmProductos) _task.TaskInstance );
						controller.KeyController = "ABMProductos";
						controller.KeyTask = _task.KeyTask;
						break;	

					case "ABMProductosPrecios":
						controller.ControllerInstance = new mz.erp.ui.controllers.AbmProductosPreciosController( (mz.erp.businessrules.AbmProductosPrecios) _task.TaskInstance );
						controller.KeyController = "ABMProductosPrecios";
						controller.KeyTask = _task.KeyTask;
						break;	

					case "ABMProductosSucursales":
						controller.ControllerInstance = new mz.erp.ui.controllers.AbmProductosSucursalesController( (mz.erp.businessrules.AbmProductoSucursal) _task.TaskInstance );
						controller.KeyController = "ABMProductosSucursales";
						controller.KeyTask = _task.KeyTask;
						break;	

					case "ABMTiposMovimientos":
						controller.ControllerInstance = new mz.erp.ui.controllers.AbmTiposMovimientosController( (mz.erp.businessrules.AbmTiposMovimientos) _task.TaskInstance );
						controller.KeyController = "ABMTiposMovimientos";
						controller.KeyTask = _task.KeyTask;
						break;	
						

					case "SeleccionarCompProductosPendientesNumeroSerie":
						controller.ControllerInstance = new mz.erp.ui.controllers.ComprobantesConProductosPendientesDeNumeroDeSerieController( ( mz.erp.businessrules.SeleccionarComprobantesConProductosPendientesDeNumeroDeSerie) _task.TaskInstance );
						controller.KeyController = "SeleccionarCompProductosPendientesNumeroSerie";
						controller.KeyTask = _task.KeyTask;
						break;

					case "ConsultarStockNDias":
						controller.ControllerInstance = new mz.erp.ui.controllers.StockNDiasController( ( mz.erp.businessrules.StockNDias) _task.TaskInstance );
						controller.KeyController = "ConsultarStockNDias";
						controller.KeyTask = _task.KeyTask;
						break;

					case "IngresarPrecioProducto":
						controller.ControllerInstance = new mz.erp.ui.controllers.IngresarPrecioProductoController( ( mz.erp.businessrules.IngresarPrecioProducto) _task.TaskInstance );
						controller.KeyController = "IngresarPrecioProducto";
						controller.KeyTask = _task.KeyTask;
						break;

					case "SeleccionarInstanciaOrdenReparacion":
						controller.ControllerInstance = new mz.erp.ui.controllers.SeleccionarInstanciaOrdenReparacionController( ( mz.erp.businessrules.SeleccionarInstanciaOrdenReparacion) _task.TaskInstance );
						controller.KeyController = "SeleccionarInstanciaOrdenReparacion";
						controller.KeyTask = _task.KeyTask;
						break;

					case "ConsultarMovimientosStockPorJerarquias":
						controller.ControllerInstance = new mz.erp.ui.controllers.ConsultaMovimientosStockController( ( mz.erp.businessrules.ConsultaMovimientosStock) _task.TaskInstance );
						controller.KeyController = "ConsultarMovimientosStockPorJerarquias";
						controller.KeyTask = _task.KeyTask;
						break;
						

					case "ConsultarCompras":
						controller.ControllerInstance = new mz.erp.ui.controllers.ConsultaComprasController( ( mz.erp.businessrules.ConsultaCompras) _task.TaskInstance );
						controller.KeyController = "ConsultarCompras";
						controller.KeyTask = _task.KeyTask;
						break;

					case "ConsultarVentas":
						controller.ControllerInstance = new mz.erp.ui.controllers.ConsultaVentasController( ( mz.erp.businessrules.ConsultaVentas) _task.TaskInstance );
						controller.KeyController = "ConsultarVentas";
						controller.KeyTask = _task.KeyTask;
						break;

					case "Valor":
						controller.ControllerInstance = new mz.erp.ui.controllers.ValoresController( ( mz.erp.businessrules.comprobantes.Valor) _task.TaskInstance);
						controller.KeyController = "Valor";
						controller.KeyTask = _task.KeyTask;
						break;

					case "AjustarCuentaCorriente":
						controller.ControllerInstance = new mz.erp.ui.controllers.ComprobanteDeAjusteCuentaCorrienteController( ( mz.erp.businessrules.comprobantes.ComprobanteDeAjusteCuentaCorriente) _task.TaskInstance);
						controller.KeyController = "AjustarCuentaCorriente";
						controller.KeyTask = _task.KeyTask;
						break;
					case "ConsultarGastos":
						controller.ControllerInstance = new mz.erp.ui.controllers.ConsultarMovimientosDeCajasController( ( mz.erp.businessrules.ConsultarMovimientosDeCajas) _task.TaskInstance);
						controller.KeyController = "ConsultarGastos";
						controller.KeyTask = _task.KeyTask;
						break;
					case "CuentaCorrienteGeneral":
						controller.ControllerInstance = new mz.erp.ui.controllers.CuentaCorrienteGeneralController( ( mz.erp.businessrules.CuentaCorrienteGeneral) _task.TaskInstance);
						controller.KeyController = "CuentaCorrienteGeneral";
						controller.KeyTask = _task.KeyTask;
						break;
						
					case "ConfigurarLayoutGrillas":
						controller.ControllerInstance = new mz.erp.ui.controllers.ConfigurarLayoutGrillasController( ( mz.erp.businessrules.ConfigurarLayoutGrillas) _task.TaskInstance);
						controller.KeyController = "ConfigurarLayoutGrillas";
						controller.KeyTask = _task.KeyTask;
						break;

					case "ListarComprobantesDeCompra":
						controller.ControllerInstance = new mz.erp.ui.controllers.ListarComprobantesDeCompraController( ( mz.erp.businessrules.ListarComprobantesDeCompra) _task.TaskInstance);
						controller.KeyController = "ListarComprobantesDeCompra";
						controller.KeyTask = _task.KeyTask;
						break;
						
					case "ModificarPreciosMasivo":
						controller.ControllerInstance = new mz.erp.ui.controllers.ModificarPreciosMasivoController( ( mz.erp.businessrules.ModificarPreciosMasivo) _task.TaskInstance);
						controller.KeyController = "ModificarPreciosMasivo";
						controller.KeyTask = _task.KeyTask;
						break;
					case "IngresarCodigoSecundario":
						controller.ControllerInstance = new mz.erp.ui.controllers.IngresarCodigoSecundarioController( ( mz.erp.businessrules.IngresarCodigoSecundario) _task.TaskInstance);
						controller.KeyController = "IngresarCodigoSecundario";
						controller.KeyTask = _task.KeyTask;
						break;				
						

					case "ABMCuentasObservacionesEstados": 
						controller.ControllerInstance = new mz.erp.ui.controllers.ABMCuentasObservacionesEstadosControllers( (ABMCuentasObservacionesEstados)_task.TaskInstance );
						controller.KeyController = "ABMCuentasObservacionesEstados";
						controller.KeyTask = _task.KeyTask;
						break;

					case "ABMLocalidades": 
						controller.ControllerInstance = new mz.erp.ui.controllers.ABMLocalidadesController( (ABMLocalidades)_task.TaskInstance );
						controller.KeyController = "ABMLocalidades";
						controller.KeyTask = _task.KeyTask;
						break;

					case "ModificarProductosMasivo":
						controller.ControllerInstance = new mz.erp.ui.controllers.ModificarProductosMasivoController( ( mz.erp.businessrules.ModificarProductosMasivo) _task.TaskInstance);
						controller.KeyController = "ModificarProductosMasivo";
						controller.KeyTask = _task.KeyTask;
						break;				

					case "AbmTiposObservacionesCuentas":
						controller.ControllerInstance = new mz.erp.ui.controllers.TiposObservacionesCuentasController( ( mz.erp.businessrules.TiposObservacionesCuentas) _task.TaskInstance);
						controller.KeyController = "AbmTiposObservacionesCuentas";
						controller.KeyTask = _task.KeyTask;
						break;	

					case "ConsultarValores":
						controller.ControllerInstance = new mz.erp.ui.controllers.ConsultaValoresController( ( mz.erp.businessrules.ConsultaValores) _task.TaskInstance);
						controller.KeyController = "ConsultarValores";
						controller.KeyTask = _task.KeyTask;
						break;	
                        
					case "ConsultarProductos":
						controller.ControllerInstance = new mz.erp.ui.controllers.mzProductosSearchFormWorkflowController( ( mz.erp.businessrules.mzProductosSearchFormWorkflow) _task.TaskInstance);
						controller.KeyController = "ConsultarProductos";
						controller.KeyTask = _task.KeyTask;
						break;				

					case "AbmVisualizacionDeStock":
						controller.ControllerInstance = new mz.erp.ui.controllers.AbmVisualizacionDeStockController( ( mz.erp.businessrules.AbmVisualizacionDeStock) _task.TaskInstance);
						controller.KeyController = "AbmVisualizacionDeStock";
						controller.KeyTask = _task.KeyTask;
						break;	
					
					case "ABMComprobantesCategoriaIva":
						controller.ControllerInstance = new mz.erp.ui.controllers.ABMComprobantesCategoriaIvaController( ( mz.erp.businessrules.ABMComprobantesCategoriaIva) _task.TaskInstance);
						controller.KeyController = "ABMComprobantesCategoriaIva";
						controller.KeyTask = _task.KeyTask;
						break;	
						

		
					case "ConfigurarVariables":
						controller.ControllerInstance = new mz.erp.ui.controllers.ConfigurarVariablesController( ( mz.erp.businessrules.ConfigurarVariables) _task.TaskInstance );
						controller.KeyController = "ConfigurarVariables";
						controller.KeyTask = _task.KeyTask;
						break;

					case "ConsultarEntregas":
						controller.ControllerInstance = new mz.erp.ui.controllers.ConsultaEntregasController( ( mz.erp.businessrules.ConsultaEntregas) _task.TaskInstance );
						controller.KeyController = "ConsultarEntregas";
						controller.KeyTask = _task.KeyTask;
						break;

					case "ConsultarPersonas":
						controller.ControllerInstance = new mz.erp.ui.controllers.mzPersonasSearchFormController( ( mz.erp.businessrules.mzPersonasSearchForm) _task.TaskInstance );
						controller.KeyController = "ConsultarPersonas";
						controller.KeyTask = _task.KeyTask;
						break;
						
					case "ConsultarListasDePrecios":
						controller.ControllerInstance = new mz.erp.ui.controllers.ConsultarListasDePreciosController( ( mz.erp.businessrules.ConsultarListasDePrecios) _task.TaskInstance );
						controller.KeyController = "ConsultarListasDePrecios";
						controller.KeyTask = _task.KeyTask;
						break;
					case "AbmBonificaciones": 
						controller.ControllerInstance = new mz.erp.ui.controllers.AbmBonificacionesController( (AbmBonificaciones)_task.TaskInstance );
						controller.KeyController = "AbmBonificaciones";
						controller.KeyTask = _task.KeyTask;
						break;

					case "ABMChequeras": 
						controller.ControllerInstance = new mz.erp.ui.controllers.ABMChequerasControllers( (ABMChequeras)_task.TaskInstance );
						controller.KeyController = "ABMChequeras";
						controller.KeyTask = _task.KeyTask;
						break;

					case "DepositoBancario": 
						controller.ControllerInstance = new mz.erp.ui.controllers.DepositoBancarioController( (DepositoBancario)_task.TaskInstance );
						controller.KeyController = "DepositoBancario";
						controller.KeyTask = _task.KeyTask;
						break;


					case "ComprobanteDePagoCompras":
						controller.ControllerInstance = new mz.erp.ui.controllers.IngresarComprobanteDePagoComprasController( (mz.erp.businessrules.IngresarComprobanteDePagoCompras)_task.TaskInstance );
						controller.KeyController = "ComprobanteDePagoCompras";
						controller.KeyTask = _task.KeyTask;
						break;

					case "PagarServiciosGastosCompras":
						controller.ControllerInstance = new mz.erp.ui.controllers.PagarServiciosGastosComprasController( (mz.erp.businessrules.PagarServiciosGastosCompras)_task.TaskInstance );
						controller.KeyController = "PagarServiciosGastosCompras";
						controller.KeyTask = _task.KeyTask;
						break;


					case "ConfirmarPreciosProductosCompras":
						controller.ControllerInstance = new mz.erp.ui.controllers.ConfirmarPreciosProductosComprasController( (mz.erp.businessrules.ConfirmarPreciosProductosCompras)_task.TaskInstance );
						controller.KeyController = "ConfirmarPreciosProductosCompras";
						controller.KeyTask = _task.KeyTask;
						break;


					case "ConsultarProductosSinMovimientos":
						controller.ControllerInstance = new mz.erp.ui.controllers.mzProductosSearchFormWorkflowController( (mz.erp.businessrules.mzProductosSearchFormWorkflow)_task.TaskInstance );
						controller.KeyController = "ConsultarProductosSinMovimientos";
						controller.KeyTask = _task.KeyTask;
						break;

					case "ConsultarLibroIVA":
						controller.ControllerInstance = new mz.erp.ui.controllers.ConsultarLibroIVAController( (mz.erp.businessrules.ConsultarLibroIVA)_task.TaskInstance );
						controller.KeyController = "ConsultarLibroIVA";
						controller.KeyTask = _task.KeyTask;
						break;

					case "ConsultarSeguimientoCompras":
						controller.ControllerInstance = new mz.erp.ui.controllers.ConsultarSeguimientoComprasController( (mz.erp.businessrules.ConsultarSeguimientoCompras)_task.TaskInstance );
						controller.KeyController = "ConsultarSeguimientoCompras";
						controller.KeyTask = _task.KeyTask;
						break;

					case "ConsultarRetencionesProveedores":
						controller.ControllerInstance = new mz.erp.ui.controllers.ConsultarRetencionesProveedoresController( (mz.erp.businessrules.ConsultarRetencionesProveedores)_task.TaskInstance );
						controller.KeyController = "ConsultarRetencionesProveedores";
						controller.KeyTask = _task.KeyTask;
						break;

					case "AbmTiposObservacionesProveedores":
						controller.ControllerInstance = new mz.erp.ui.controllers.TiposObservacionesCuentasController( ( mz.erp.businessrules.TiposObservacionesProveedores) _task.TaskInstance);
						controller.KeyController = "AbmTiposObservacionesProveedores";
						controller.KeyTask = _task.KeyTask;
						break;	

					case "ConfigurarMenues": 
						controller.ControllerInstance = new mz.erp.ui.controllers.ConfigurarMenuesController( (mz.erp.businessrules.ConfigurarMenues)_task.TaskInstance );
						controller.KeyController = "ConfigurarMenues";
						controller.KeyTask = _task.KeyTask;
						break;

					case "ConsultarEntrega": 
						controller.ControllerInstance = new mz.erp.ui.controllers.ConsultaEntregasController( (mz.erp.businessrules.ConsultaEntregas)_task.TaskInstance );
						controller.KeyController = "ConsultarEntrega";
						controller.KeyTask = _task.KeyTask;
						break;

					case "ListarTareasRealizadasOrdenReparacion": 
						controller.ControllerInstance = new mz.erp.ui.controllers.ListarTareasRealizadasOrdenReparacionController( (mz.erp.businessrules.ListarTareasRealizadasOrdenReparacion)_task.TaskInstance );
						controller.KeyController = "ListarTareasRealizadasOrdenReparacion";
						controller.KeyTask = _task.KeyTask;
						break;

					case "AbmMotivoOrdenReparacion":
						controller.ControllerInstance = new mz.erp.ui.controllers.AbmMotivoOrdenReparacionController( ( mz.erp.businessrules.AbmMotivoOrdenReparacion) _task.TaskInstance);
						controller.KeyController = "AbmMotivoOrdenReparacion";
						controller.KeyTask = _task.KeyTask;
						break;	

					case "AbmServicio":
						controller.ControllerInstance = new mz.erp.ui.controllers.AbmServicioController( ( mz.erp.businessrules.AbmServicio) _task.TaskInstance);
						controller.KeyController = "AbmServicio";
						controller.KeyTask = _task.KeyTask;
						break;	

					case "ConsultarEstadisticaOrdenReparacion":
						controller.ControllerInstance = new mz.erp.ui.controllers.ConsultarEstadisticaOrdenReparacionController( ( mz.erp.businessrules.ConsultarEstadisticaOrdenReparacion) _task.TaskInstance);
						controller.KeyController = "ConsultarEstadisticaOrdenReparacion";
						controller.KeyTask = _task.KeyTask;
						break;	

					case "AbmTarea":
						controller.ControllerInstance = new mz.erp.ui.controllers.AbmTareaController( ( mz.erp.businessrules.AbmTarea) _task.TaskInstance);
						controller.KeyController = "AbmTarea";
						controller.KeyTask = _task.KeyTask;
						break;	

					case "CierreMasivoOrdenReparacion":
						controller.ControllerInstance = new mz.erp.ui.controllers.CierreMasivoOrdenReparacionController( ( mz.erp.businessrules.CierreMasivoOrdenReparacion) _task.TaskInstance);
						controller.KeyController = "CierreMasivoOrdenReparacion";
						controller.KeyTask = _task.KeyTask;
						break;	


					case "ConsultarProductosConPreciosModificados":
						controller.ControllerInstance = new mz.erp.ui.controllers.ConsultarProductosConPreciosModificadosController( ( mz.erp.businessrules.ConsultarProductosConPreciosModificados) _task.TaskInstance);
						controller.KeyController = "ConsultarProductosConPreciosModificados";
						controller.KeyTask = _task.KeyTask;
						break;	

					case "ABMCondicionesDeVenta":
						controller.ControllerInstance = new mz.erp.ui.controllers.ABMCondicionesDeVentaController( ( mz.erp.businessrules.ABMCondicionesDeVenta) _task.TaskInstance);
						controller.KeyController = "ABMCondicionesDeVenta";
						controller.KeyTask = _task.KeyTask;
						break;	

					case "AbmCostosIndirectos":
						controller.ControllerInstance = new mz.erp.ui.controllers.AbmCostosIndirectosController( ( mz.erp.businessrules.AbmCostosIndirectos) _task.TaskInstance);
						controller.KeyController = "AbmCostosIndirectos";
						controller.KeyTask = _task.KeyTask;
						break;	

					case "ModificarPreciosMasivoDesdeExcel":
						controller.ControllerInstance = new mz.erp.ui.controllers.ModificarPreciosMasivoDesdeExcelController( ( mz.erp.businessrules.ModificarPreciosMasivoDesdeExcel) _task.TaskInstance);
						controller.KeyController = "ModificarPreciosMasivoDesdeExcel";
						controller.KeyTask = _task.KeyTask;
						break;	

					case "ABMEntidades":
						controller.ControllerInstance = new mz.erp.ui.controllers.ABMEntidadesController( ( mz.erp.businessrules.AbmEntidades) _task.TaskInstance);
						controller.KeyController = "ABMEntidades";
						controller.KeyTask = _task.KeyTask;
						break;

					case "ConsultarVariables":
						controller.ControllerInstance = new mz.erp.ui.controllers.ConsultarVariablesController( ( mz.erp.businessrules.ConsultarVariables) _task.TaskInstance);
						controller.KeyController = "ConsultarVariables";
						controller.KeyTask = _task.KeyTask;
						break;	

					case "ABMVariables":
						controller.ControllerInstance = new mz.erp.ui.controllers.ABMVariablesController( ( mz.erp.businessrules.ABMVariables) _task.TaskInstance);
						controller.KeyController = "ABMVariables";
						controller.KeyTask = _task.KeyTask;
						break;	

					case "AbmTipoDeAjusteStock":
						controller.ControllerInstance = new mz.erp.ui.controllers.ABMTiposDeAjusteStockController( ( mz.erp.businessrules.ABMTiposDeAjusteStock) _task.TaskInstance);
						controller.KeyController = "ABMTiposDeAjusteStock";
						controller.KeyTask = _task.KeyTask;
						break;
					
					case "AbmTipoDeComprobante":
						controller.ControllerInstance = new mz.erp.ui.controllers.AbmTipoDeComprobanteController( ( mz.erp.businessrules.AbmTipoDeComprobante) _task.TaskInstance);
						controller.KeyController = "AbmTipoDeComprobante";
						controller.KeyTask = _task.KeyTask;
						break;

					case "JerarquiaConfigurarVariable":
						controller.ControllerInstance = new mz.erp.ui.controllers.JerarquiaConfigurarVariableController( ( mz.erp.businessrules.JerarquiaConfigurarVariable) _task.TaskInstance);
						controller.KeyController = "JerarquiaConfigurarVariable";
						controller.KeyTask = _task.KeyTask;
						break;

					case "AbmPerfil":
						controller.ControllerInstance = new mz.erp.ui.controllers.AbmPerfilController( ( mz.erp.businessrules.AbmPerfil ) _task.TaskInstance);
						controller.KeyController = "AbmPerfil";
						controller.KeyTask = _task.KeyTask;
						break;	

					case "ConsultarFacturasImpagas":
						controller.ControllerInstance = new mz.erp.ui.controllers.ConsultarFacturasImpagasController( ( mz.erp.businessrules.ConsultarFacturasImpagas) _task.TaskInstance);
						controller.KeyController = "ConsultarFacturasImpagas";
						controller.KeyTask = _task.KeyTask;
						break;	
					
					case "SoporteModificarComprobantes":
						controller.ControllerInstance = new mz.erp.ui.controllers.SoporteModificarComprobantesController( ( mz.erp.businessrules.SoporteModificarComprobantes ) _task.TaskInstance);
						controller.KeyController = "SoporteModificarComprobantes";
						controller.KeyTask = _task.KeyTask;
						break;	

					case "ConfigurarPrecios":
						controller.ControllerInstance = new mz.erp.ui.controllers.ConfigurarPreciosController( ( mz.erp.businessrules.ConfigurarPrecios) _task.TaskInstance);
						controller.KeyController = "ConfigurarPrecios";
						controller.KeyTask = _task.KeyTask;
						break;	

					case "AutorizarFacturasCompras":
						controller.ControllerInstance = new mz.erp.ui.controllers.AutorizarFacturasComprasController( ( mz.erp.businessrules.AutorizarFacturasCompras) _task.TaskInstance);
						controller.KeyController = "AutorizarFacturasCompras";
						controller.KeyTask = _task.KeyTask;
						break;	

					case "ControlarCajas":
						controller.ControllerInstance = new mz.erp.ui.controllers.ControlarCajasController( ( mz.erp.businessrules.ControlarCajas) _task.TaskInstance);
						controller.KeyController = "ControlarCajas";
						controller.KeyTask = _task.KeyTask;
						break;	

					case "ConsultarControlCajas":
						controller.ControllerInstance = new mz.erp.ui.controllers.ConsultarControlCajasController( ( mz.erp.businessrules.ConsultarControlCajas) _task.TaskInstance);
						controller.KeyController = "ConsultarControlCajas";
						controller.KeyTask = _task.KeyTask;
						break;	

					//Sabrina 20100615 - Tarea 766
					case "ModificarCuentasMasivo":
						controller.ControllerInstance = new mz.erp.ui.controllers.ModificarCuentasMasivoController( ( mz.erp.businessrules.ModificarCuentasMasivo) _task.TaskInstance);
						controller.KeyController = "ModificarCuentasMasivo";
						controller.KeyTask = _task.KeyTask;
						break;	
					//Fin Sabrina 20100615 - Tarea 766

                    //Matias 20110422 - Tarea 0000061
                    case "IngresarPadronARBA":
                        controller.ControllerInstance = new mz.erp.ui.controllers.IngresarPadronARBAController((mz.erp.businessrules.IngresarPadronARBA)_task.TaskInstance);
                        controller.KeyController = "IngresarPadronARBA";
                        controller.KeyTask = _task.KeyTask;
                        break;
                    //FinMatias 20110422 - Tarea 0000061

                    //Matias 20110429 - Tarea 0000061
                    case "ConsultarActualizacionAlicuotasIIBB":
                        controller.ControllerInstance = new mz.erp.ui.controllers.ConsultarActualizacionAlicuotasIIBBController((mz.erp.businessrules.ConsultarActualizacionAlicuotasIIBB)_task.TaskInstance);
                        controller.KeyController = "ConsultarActualizacionAlicuotasIIBB";
                        controller.KeyTask = _task.KeyTask;
                        break;
                    //FinMatias 20110429 - Tarea 0000061

                    /* Silvina 20111104 - Tarea 0000222 */
                    case "AbmProductosCategoriasCuentas":
                        controller.ControllerInstance = new mz.erp.ui.controllers.AbmProductosCategoriasCuentasController((mz.erp.businessrules.AbmProductosCategoriasCuentas)_task.TaskInstance);
                        controller.KeyController = "AbmProductosCategoriasCuentas";
                        controller.KeyTask = _task.KeyTask;
                        break;
                    /* Fin Silvina 20111104 - Tarea 0000222 */

                    //German 20120228 -  Tarea 0000247
                    case "ConsultarSeguimientoAcopios":
                        controller.ControllerInstance = new mz.erp.ui.controllers.ConsultarSeguimientoAcopioController((mz.erp.businessrules.ConsultarSeguimientoAcopio)_task.TaskInstance);
                        controller.KeyController = "ConsultarSeguimientoAcopios";
                        controller.KeyTask = _task.KeyTask;
                        break;
                    //Fin German 20120228 -  Tarea 0000247

					default:
						controller.ControllerInstance = new mz.erp.ui.controllers.DefaultController((ITask)_task.TaskInstance);
						controller.KeyController = "DefaultController";
						controller.KeyTask = _task.KeyTask;
						System.Console.Out.WriteLine("No se encontro el controlador para el grupo " +_grupo+ " de la tarea " + _task.KeyTask );
						break;
				}
				ITaskController cont = (ITaskController)controller.ControllerInstance;
				cont.SetProcessManager(this);
			//}
			return controller;
		}
		public Hashtable ControllersInstances
		{
			get { return _controllersInstances; }
		}

		public void Commit()
		{
			brProcess.Commit();		
		}

		public bool Flush()
		{
			return brProcess.Flush();
		}
		public bool IsPersistentProcess
		{
			get {return brProcess.IsPersistentProcess; }
		}
		public bool ProcessFlushed
		{
			get {return brProcess.ProcessFlushed; }
		}

		public bool ValidBackState
		{
			get {return brProcess.ValidBackState; }
		}
		private void ListenerProcessNextTask(string keyTask)
		{
			if(OnNextTask != null)
			{
				ControllerDynamicInfo taskController= (ControllerDynamicInfo)_controllersInstances[keyTask];
				OnNextTask(taskController);
			}
		}

		private void ListenerEndProcess(string keyTask)
		{
			if(OnEndProcess != null)
			{
				ControllerDynamicInfo taskController= (ControllerDynamicInfo)_controllersInstances[keyTask];
				OnEndProcess(taskController);
			}
		}

		private void ListenerProcessErrors(string keyTask)
		{
			if(OnProcessErrors != null)
			{
				ControllerDynamicInfo taskController= (ControllerDynamicInfo)_controllersInstances[keyTask];
				OnProcessErrors(taskController);
			}
		}

		private void ListenerProcessWarnings(string keyTask)
		{
			if(OnProcessWarnings != null)
			{
				ControllerDynamicInfo taskController= (ControllerDynamicInfo)_controllersInstances[keyTask];
				OnProcessWarnings(taskController);
			}
		}

		private  void ListenerProcessErrorsFlush(string keyTask, string mensaje, ItemsDatasetErrors flushErrors)
		{
			if(OnProcessFlushError!= null)
			{
				ControllerDynamicInfo taskController= (ControllerDynamicInfo)_controllersInstances[keyTask];
				OnProcessFlushError(taskController, mensaje, flushErrors);
			}
		}
		private void ListenerProcessPreviousTask(string keyTask)
		{
			if(OnPreviousTask != null)
			{
				ControllerDynamicInfo taskController= (ControllerDynamicInfo)_controllersInstances[keyTask];
				OnPreviousTask(taskController);
			}
		}

		public bool IsNextState()
		{
			return brProcess.IsNextState();
		}


		public bool IsBackState()
		{
			return brProcess.IsBackState();
		}

		public bool IsFirstTask(string keyTask)
		{
			return brProcess.IsFirstTask(keyTask);
		}

		public bool IsLastTask(string keyTask)
		{
			return brProcess.IsLastTask(keyTask);
		}
		public bool AskRecallProcess
		{
			get { return brProcess.AskRecallProcess; }
		}
		public bool RecallProcess
		{
			get { return brProcess.RecallProcess; }
		}
        //Cristian Tarea 0000145 20110601
        public bool ShowMessageEndProcess
        {
            get { return brProcess.ShowMessageEndProcess; }
        }
        //Fin Cristian Tarea 0000145
		public bool MostroWarnings
		{
			set{brProcess.MostroWarnings=value;}
		}

		public void Continue()
		{
			brProcess.Continue();
		}

		private void ListenerProcessErrorsOnStart(ItemsDatasetErrors errors)
		{
			if(OnProcessErrorsOnStart != null)
				OnProcessErrorsOnStart(errors);
		}

		public bool AllowShow(string KeyTask)
		{
			return brProcess.AllowShow(KeyTask);
		}


		public void EndByUser()
		{
			brProcess.EndByUser();
		}
	}
}

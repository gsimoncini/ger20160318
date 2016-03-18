using System;
using mz.erp.businessrules;
using mz.erp.ui.controllers;
using System.Windows.Forms;
using System.Collections;
using mz.erp.ui.forms;



namespace mz.erp.ui.forms.classes
{
	/// <summary>
	/// Esta clase tiene como objetivo manejar las tareas para la interfaz de usuario
	/// Su constructor recibe como parametros un arreglo de arreglo de objetos. Cada arreglo de objetos
	/// se usa para inicializar la respectiva tarea. Por ehora el macheo es posicional, se puede pensar en 
	/// otra opcion..
	/// </summary>
	public class ProcessUIManager
	{

		#region Constructores
		
		public ProcessUIManager( )
		{			
		}
		public void CreateNewProcess(string _processName, Hashtable parametros)
		{
			this.SetMessage( "Iniciando... ");
			_process = new mz.erp.ui.controllers.ProcessControllerManager( );
			_process.OnProcessMessageChanged+= new System.EventHandler( this.ListenerOnProcessMessageChange );
			_process.OnProgressCounterChanged+= new System.EventHandler( this.ListenerOnProcessProgressChange );
			//_process.OnProcessHadProblems+=new EventHandler(this.ListenerProcessHadProblems);
			_process.CreateNewProcess( _processName, parametros ) ;
			_process.OnNextTask +=new mz.erp.ui.controllers.ProcessControllerManager.OnNextTaskHandler(this.ListenerProcessNextTask);						
			_process.OnPreviousTask +=new mz.erp.ui.controllers.ProcessControllerManager.OnNextTaskHandler(this.ListenerProcessPreviousTask);
			_process.OnEndProcess +=new mz.erp.ui.controllers.ProcessControllerManager.OnEndProcessHandler(this.ListenerEndProcess);
			_process.OnProcessErrors +=new mz.erp.ui.controllers.ProcessControllerManager.OnProcessErrorsHandler(this.ListenerProcessErrors);
			_process.OnProcessWarnings +=new mz.erp.ui.controllers.ProcessControllerManager.OnProcessWarningsHandler(this.ListenerProcessWarnings);
			_process.OnProcessErrorsOnStart +=new mz.erp.ui.controllers.ProcessControllerManager.OnProcessErrorsOnStartHandler(this.ListenerProcessErrorsOnStart);
			_process.OnProcessFlushError += new mz.erp.ui.controllers.ProcessControllerManager.OnProcessErrorFlushHandler(this.ListenerProcessFlushError);
				
			_actualProcess = _processName;
		}

		#endregion

		#region Variables Privadas
			ProcessControllerManager _process = null;		
			private ITaskForm _actualForm = null ;
			bool WorkFlowClose = false;
			bool ProcessHadProblems = false;			
		#endregion

		#region Variables Publicas

			public string _actualProcess = "";
			public string ActualProcess
			{   get
				{
					return _actualProcess;
				}
			}


		#endregion

		public void Init()
		{
			StartProcess();
		}
		private void StartProcess()
		{
			_process.StartProcess();
		}

		private void SetMessage( string _message )
		{
			IMainForm form = (IMainForm)mz.erp.ui.utility.Environment.MainForm;
			form.SetMessage( _message );
		}
		private void ListenerOnProcessMessageChange( object sender, System.EventArgs e )
		{
			SetMessage(this._process.ControllerMessage);
		}
		private void ListenerOnProcessProgressChange( object sender, System.EventArgs e )
		{
			IMainForm form = (IMainForm)mz.erp.ui.utility.Environment.MainForm;
			form.SetProgressBarTop( this._process.ProcessProgressTop );
			form.SetProgressBar( this._process.ProcessProgress);
		}
		/*
		public void ListenerProcessHadProblems( object sender, System.EventArgs e )
		{						
			ProcessHadProblems = true;			
		}
		*/	
		private void InstanceInterfases()
		{
			Hashtable controllerInstances = _process.ControllersInstances;
			foreach ( ControllerDynamicInfo _aController in controllerInstances.Values )
			{
				CallStaticInterfase( _aController );
			}
		}
		private Hashtable _interfases = new Hashtable();
		
		private ITaskForm CallStaticInterfase( ControllerDynamicInfo _aController )
		{
			System.Console.Out.WriteLine("Cargando el formulario " + _aController.KeyController );
			 switch (_aController.KeyController )
			{

				case "ComprobanteDeEntrega":
				{ 
					#region ComprobanteDeEntrega
					mz.erp.ui.controllers.EntregasController entregasController = (mz.erp.ui.controllers.EntregasController) _aController.ControllerInstance;
					entregasController.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					mz.erp.ui.forms.FrmEntregas aForm = new mz.erp.ui.forms.FrmEntregas(entregasController );
					aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					//_interfases.Add(_aController.KeyTask, aForm );
					return (ITaskForm)aForm;
					
					break;
					#endregion
				}

				 case "ComprobanteDeCompra":
				 { 
					 #region ComprobanteDeCompra
					 mz.erp.ui.controllers.ComprobantesDeCompraController comprasController = (mz.erp.ui.controllers.ComprobantesDeCompraController) _aController.ControllerInstance;
					// comprasController.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					 mz.erp.ui.forms.FrmComprobantesDeCompra aForm = new mz.erp.ui.forms.FrmComprobantesDeCompra(comprasController );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)aForm;
					
					 break;
					 #endregion
				 }

				 case "ComprobanteDeCompraCabecera":
				 { 
					 #region ComprobanteDeCompraCabecera
					 mz.erp.ui.controllers.IngresarComprobanteDeCompraCabeceraController comprasController = (mz.erp.ui.controllers.IngresarComprobanteDeCompraCabeceraController) _aController.ControllerInstance;					 
					 // comprasController.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					 mz.erp.ui.forms.FrmCabeceraComprobanteDeCompra aForm = new mz.erp.ui.forms.FrmCabeceraComprobanteDeCompra(comprasController);
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)aForm;
					
					 break;
					 #endregion
				 }
				
				case "ComprobanteDeVenta":
				{
					#region ComprobanteDeVenta
					mz.erp.ui.controllers.ComprobantesDeVentaController ventasController = (mz.erp.ui.controllers.ComprobantesDeVentaController) _aController.ControllerInstance;
					ventasController.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					mz.erp.ui.forms.FrmComprobantesDeVenta aFormV = new mz.erp.ui.forms.FrmComprobantesDeVenta( ventasController );
					aFormV.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					//_interfases.Add(_aController.KeyTask, aFormV );
					return (ITaskForm)aFormV;
					break;
					#endregion
				}

					 
				 case "EditarComprobanteDeVenta":
				 {
					 #region EditarComprobanteDeVenta
					 mz.erp.ui.controllers.EditarComprobanteDeVentaController ventasController = (mz.erp.ui.controllers.EditarComprobanteDeVentaController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmEditarComprobanteDeVenta aFormV = new mz.erp.ui.forms.FrmEditarComprobanteDeVenta( ventasController );
					 aFormV.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 //_interfases.Add(_aController.KeyTask, aFormV );
					 return (ITaskForm)aFormV;
					 break;
					 #endregion
				 }
					 
					 
				case "ComprobanteDePago":
				{
					#region ComprobanteDePago
					mz.erp.ui.controllers.ComprobantesDePagoController pagosController = (mz.erp.ui.controllers.ComprobantesDePagoController) _aController.ControllerInstance;
					pagosController.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					 mz.erp.ui.forms.FrmComprobantesDePago aFormP = new mz.erp.ui.forms.FrmComprobantesDePago( pagosController );
					aFormP.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					//_interfases.Add(_aController.KeyTask, aFormP );
					return (ITaskForm)aFormP;
					break;
					#endregion
				}
				
				case "ComprobantesPendientes":
				{
					#region ComprobantesPendientes
					mz.erp.ui.controllers.ComprobantesPendientesController comprobantesPendientesController = (mz.erp.ui.controllers.ComprobantesPendientesController) _aController.ControllerInstance;
					comprobantesPendientesController.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					mz.erp.ui.forms.FrmConsultas aFormConsultas = new mz.erp.ui.forms.FrmConsultas(comprobantesPendientesController );
					aFormConsultas.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					//_interfases.Add(_aController.KeyTask, aFormConsultas );
					return  (ITaskForm)aFormConsultas;
					break;
					#endregion
				}

				 case "ComprobantesDeCompraPendientes":
				 {
					 #region ComprobantesDeCompraPendientes
					 mz.erp.ui.controllers.ComprobantesDeCompraPendientesController comprobantesDeCompraPendientesController = (mz.erp.ui.controllers.ComprobantesDeCompraPendientesController) _aController.ControllerInstance;
					 comprobantesDeCompraPendientesController.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					 mz.erp.ui.forms.FrmConsultas aFormConsultas = new mz.erp.ui.forms.FrmConsultas(comprobantesDeCompraPendientesController );
					 aFormConsultas.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 //_interfases.Add(_aController.KeyTask, aFormConsultas );
					 return  (ITaskForm)aFormConsultas;
					 break;
					 #endregion
				 }
				 case "SeleccionarComprobantesDeCompraPendientes":
				 {
					 #region SeleccionarComprobantesDeCompraPendientes
					 mz.erp.ui.controllers.SeleccionarComprobantesDeCompraPendientesController controlller = (mz.erp.ui.controllers.SeleccionarComprobantesDeCompraPendientesController) _aController.ControllerInstance;
					 controlller.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					 mz.erp.ui.forms.FrmComprobantesDeCompraPendientes aFormConsultas = new mz.erp.ui.forms.FrmComprobantesDeCompraPendientes(controlller );
					 aFormConsultas.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 //_interfases.Add(_aController.KeyTask, aFormConsultas );
					 return  (ITaskForm)aFormConsultas;
					 break;
					 #endregion
				 }		
				 case "SeleccionReparacionesPendientes":
				 {
					 #region ReparacionesPendientes
					 mz.erp.ui.controllers.ReparacionesPendientesController reparacionesPendientesController = (mz.erp.ui.controllers.ReparacionesPendientesController) _aController.ControllerInstance;
					 reparacionesPendientesController.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					 mz.erp.ui.forms.FrmConsultas aFormConsultas = new mz.erp.ui.forms.FrmConsultas(reparacionesPendientesController );
					 aFormConsultas.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 //_interfases.Add(_aController.KeyTask, aFormConsultas );
					 return  (ITaskForm)aFormConsultas;
					 break;
					 #endregion
				 }

				 case "SeleccionReparacionesAjustes":
				 {
					 #region ReparacionesAjustes
					 mz.erp.ui.controllers.ReparacionesAjustesController repAjustesController = (mz.erp.ui.controllers.ReparacionesAjustesController) _aController.ControllerInstance;
					 repAjustesController.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					 mz.erp.ui.forms.FrmConsultas aFrmConsultas = new mz.erp.ui.forms.FrmConsultas(repAjustesController );
					 aFrmConsultas.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return  (ITaskForm)aFrmConsultas;
					 break;
					 #endregion
				 }
				case "SeleccionarItemsPendientes":
				{
					#region SeleccionarItemsPendientes
					mz.erp.ui.controllers.ComprobantesSelectNController comprobantesSelectNController = (mz.erp.ui.controllers.ComprobantesSelectNController) _aController.ControllerInstance;
					comprobantesSelectNController.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					mz.erp.ui.forms.FrmComprobantesSelectN aFormSelectN = new mz.erp.ui.forms.FrmComprobantesSelectN(comprobantesSelectNController );
					aFormSelectN.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					//_interfases.Add(_aController.KeyTask, aFormSelectN );
					return (ITaskForm)aFormSelectN;
					break;
					#endregion
				}

				 case "SeleccionItemsDeCompraPendientes":
				 {
					 #region SeleccionItemsDeCompraPendientes
					 mz.erp.ui.controllers.ComprobantesDeCompraSelectNController comprobantesSelectNController = (mz.erp.ui.controllers.ComprobantesDeCompraSelectNController) _aController.ControllerInstance;
					 comprobantesSelectNController.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					 mz.erp.ui.forms.FrmComprobanteDeCompraSelectN aFormSelectN = new mz.erp.ui.forms.FrmComprobanteDeCompraSelectN(comprobantesSelectNController );
					 aFormSelectN.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 //_interfases.Add(_aController.KeyTask, aFormSelectN );
					 return (ITaskForm)aFormSelectN;
					 break;
					 #endregion
				 }
				
					
				case "SeleccionarFormaDeEntrega": //st
				{
					#region SeleccionarFormaDeEntrega
					mz.erp.ui.controllers.SeleccionarEstadoItemsController estadoItemController = (mz.erp.ui.controllers.SeleccionarEstadoItemsController) _aController.ControllerInstance;
					estadoItemController.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					mz.erp.ui.forms.FrmSeleccionEstadoDeItems seleccion = new mz.erp.ui.forms.FrmSeleccionEstadoDeItems(estadoItemController);
					seleccion.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					//_interfases.Add(_aController.KeyTask, seleccion );
					return (ITaskForm)seleccion;
					break;
					#endregion
				}
				case "ConceptosAdicionales": //st
				{
					#region ConceptosAdicionales
					mz.erp.ui.controllers.ConceptosAdicionalesController conceptoAdicionalController = (mz.erp.ui.controllers.ConceptosAdicionalesController) _aController.ControllerInstance;
					conceptoAdicionalController.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					mz.erp.ui.forms.FrmCargosAdicionales formulario = new mz.erp.ui.forms.FrmCargosAdicionales(conceptoAdicionalController);
					formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					//_interfases.Add(_aController.KeyTask, formulario );
					return (ITaskForm)formulario;
					break;
					#endregion
				}
						
				case "ImprimirReporteComprobanteDeVenta":
				{
					#region ImprimirReporteComprobanteDeVenta
					mz.erp.ui.controllers.ReportsController reporteController = (mz.erp.ui.controllers.ReportsController) _aController.ControllerInstance;
					reporteController.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					mz.erp.ui.forms.FrmReportsViewer formulario = new mz.erp.ui.forms.FrmReportsViewer(reporteController, _actualProcess, "ImprimirReporteComprobanteDeVenta");
					formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					return (ITaskForm)formulario;			
					break;
					#endregion
				}

				case "ImpresionComprobanteDeVentaFiscal":
				case "EmisionCierreX":
				case "EmisionCierreZ":
				{
					#region ComprobanteDeVentaFiscal
					mz.erp.ui.controllers.FiscalController fiscal = (mz.erp.ui.controllers.FiscalController) _aController.ControllerInstance;
					fiscal.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);					 
					mz.erp.ui.forms.FrmFiscal form = new mz.erp.ui.forms.FrmFiscal(fiscal);
					//_interfases.Add( _aController.KeyTask,form );
					return (ITaskForm) form;
					break;
					#endregion
				}
				case "ListarComprobantesPendientes":
				{
					 #region ListarComprobantesPendientes
					 mz.erp.ui.controllers.ListarComprobantesPendientesController listarComprobantesPendientesController = (mz.erp.ui.controllers.ListarComprobantesPendientesController) _aController.ControllerInstance;
					 listarComprobantesPendientesController.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					 mz.erp.ui.forms.FrmConsultas aFormConsultas = new mz.erp.ui.forms.FrmConsultas(listarComprobantesPendientesController );
					 aFormConsultas.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 //_interfases.Add(_aController.KeyTask, aFormConsultas );
					return (ITaskForm)aFormConsultas;
					 break;
					 #endregion
				}				
				case "ListarComprobantes":
				 {
					#region ConsultarComprobantes
					 mz.erp.ui.controllers.ListarComprobantesController listarComprobantesController = (mz.erp.ui.controllers.ListarComprobantesController) _aController.ControllerInstance;
					 listarComprobantesController.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					 mz.erp.ui.forms.FrmConsultas aFormConsultas = new mz.erp.ui.forms.FrmConsultas(listarComprobantesController );
					 aFormConsultas.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 //_interfases.Add(_aController.KeyTask, aFormConsultas );
					return (ITaskForm) aFormConsultas;
					 break;
					 #endregion
				 }
				 case "ListarComprobantesDV":
				 {
					 #region ConsultarComprobantesDV
					 mz.erp.ui.controllers.ListarComprobantesDVController listarComprobantesDVController = (mz.erp.ui.controllers.ListarComprobantesDVController) _aController.ControllerInstance;
					 listarComprobantesDVController.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					 mz.erp.ui.forms.FrmConsultas aFormConsultas = new mz.erp.ui.forms.FrmConsultas(listarComprobantesDVController );
					 aFormConsultas.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aFormConsultas;
					 break;
					 #endregion
				 }
				case "SeleccionarFormasDePagos": 
				{
					#region SeleccionasFormasDePagos
					mz.erp.ui.controllers.FormasDePagoController formasDePagoController = (mz.erp.ui.controllers.FormasDePagoController) _aController.ControllerInstance;
					formasDePagoController.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					mz.erp.ui.forms.FrmFormasDePago formulario = new mz.erp.ui.forms.FrmFormasDePago(formasDePagoController);
					formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					//_interfases.Add(_aController.KeyTask, formulario );
					return (ITaskForm)formulario;
					break;
					#endregion
				}
				case "ImprimirReporte":
				{
					#region ImprimirReporte
					mz.erp.ui.controllers.ReportsGenericController reportcontroller = (mz.erp.ui.controllers.ReportsGenericController) _aController.ControllerInstance;
					reportcontroller.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					mz.erp.ui.forms.FrmReportsGenericViewer formulario = new mz.erp.ui.forms.FrmReportsGenericViewer(reportcontroller);
					formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					//_interfases.Add(_aController.KeyTask, formulario );
					return (ITaskForm)formulario;
					break;
					#endregion
				}
				case "ConsultasCaja":
				{
					#region ConsultasCaja
					mz.erp.ui.controllers.ConsultasCajaController consultascontroller = (mz.erp.ui.controllers.ConsultasCajaController) _aController.ControllerInstance;
					consultascontroller.OnTaskAfterExecute += new EventHandler( ListenerOnTaskAfterExecute) ;
					System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmConsultaCaja( consultascontroller );
					formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					return (ITaskForm) formulario ;
					break;
					#endregion
				}
				 case "ConsultarCajaTDCompTesoreria":
				 {
					 #region ConsultasCajaTDCompTesoreria
					 mz.erp.ui.controllers.ConsultasCajaController consultascontroller = (mz.erp.ui.controllers.ConsultasCajaController) _aController.ControllerInstance;
					 consultascontroller.OnTaskAfterExecute += new EventHandler( ListenerOnTaskAfterExecute) ;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmConsultaCajaTDCompTesoreria( consultascontroller );
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) formulario ;
					 break;
					 #endregion
				 }

				 case "ConsultasCajaDetallada":
				 {
					 #region ConsultasCajaDetallada
					 mz.erp.ui.controllers.ConsultasCajaController consultascontroller = (mz.erp.ui.controllers.ConsultasCajaController) _aController.ControllerInstance;
					 consultascontroller.OnTaskAfterExecute += new EventHandler( ListenerOnTaskAfterExecute) ;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmConsultaCajaDetalle( consultascontroller );
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) formulario ;
					 break;
					 #endregion
				 }

				case "SolicitudDeAutorizacion":
				{
					#region SolicitudDeAutorizacion
					mz.erp.ui.controllers.SolicitarAutorizacionController controller = (mz.erp.ui.controllers.SolicitarAutorizacionController) _aController.ControllerInstance;
					controller.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmSolicitarAutorizacion(controller);
					formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					//_interfases.Add( formulario );
					return (ITaskForm)formulario;
					break;
					#endregion
				}
				 case "Autorizacion":
				 {
					 #region Autorizacion
					 mz.erp.ui.controllers.AutorizarController controller = (mz.erp.ui.controllers.AutorizarController) _aController.ControllerInstance;
					 controller.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmAutorizaciones(controller);
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }

				 case "Aceptacion":
				 {
					 #region Aceptacion
					 mz.erp.ui.controllers.AceptacionController controller = (mz.erp.ui.controllers.AceptacionController) _aController.ControllerInstance;
					 controller.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmAceptacion(controller);
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 //_interfases.Add( formulario );
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }

				 case "MovimientoCaja":
				 {
					 #region Ajuste movimiento de caja
					 mz.erp.ui.controllers.MovimientoAjusteCajaController controller = (mz.erp.ui.controllers.MovimientoAjusteCajaController) _aController.ControllerInstance;
					 controller.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmMovimientosAjusteCajaEx(controller);
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }
				 case "Valor":
				 {
					 #region Valor
					 mz.erp.ui.controllers.ValoresController controller = (mz.erp.ui.controllers.ValoresController) _aController.ControllerInstance;
					 controller.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmValores(controller);
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }

				case "ABMCuentasCondicionesDeVenta":
				{
					 #region ABMCuentasCondicionesDeVenta
					 mz.erp.ui.controllers.AbmCuentasCondicionesDeVentaController controller = (mz.erp.ui.controllers.AbmCuentasCondicionesDeVentaController) _aController.ControllerInstance;
					 controller.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmAbmCuentasCondicionesDeVenta(controller);
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 //_interfases.Add( formulario );
					return (ITaskForm)formulario;
					 break;
					 #endregion
				}

				case "ABMCuentasObservaciones":
				 {
					#region ABMCuentasObservaciones
					mz.erp.ui.controllers.AbmCuentasObservacionesController controller = (mz.erp.ui.controllers.AbmCuentasObservacionesController) _aController.ControllerInstance;
					controller.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmAbmCuentasObservaciones(controller);
					formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;					
					return (ITaskForm)formulario;
					break;
					#endregion					
				 }

				case "SeleccionarObservacion":
				 {
					#region SeleccionarObservacion
					mz.erp.ui.controllers.mzCuentasObservacionesSearchFormController controller = (mz.erp.ui.controllers.mzCuentasObservacionesSearchFormController) _aController.ControllerInstance;
					controller.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					System.Windows.Forms.Form formulario = new mz.erp.ui.forms.mzCuentasObservacionesSearchForm(controller);
					formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;					
					return (ITaskForm)formulario;
					break;
					#endregion					
				 }				 

				case "ABMCotizacionMoneda":
				{
					 #region ABMCotizacionMoneda
					 mz.erp.ui.controllers.AbmCotizacionMonedaController controller = (mz.erp.ui.controllers.AbmCotizacionMonedaController) _aController.ControllerInstance;
					 controller.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmAbmCotizacionMoneda(controller);
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 //_interfases.Add( formulario );
					return (ITaskForm)formulario;
					 break;
					 #endregion
				}
					 
				case "ABMProductos":
				{

					#region ABMProductos

					 mz.erp.ui.controllers.AbmProductosController controller = (mz.erp.ui.controllers.AbmProductosController) _aController.ControllerInstance;
					 controller.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmAbmProductos(controller);
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 //_interfases.Add( formulario );
					return (ITaskForm)formulario;
					
					
					break;
					#endregion

				}

				 case "ABMProductosPrecios":
				 {

					 #region ABMProductosPrecios

					 mz.erp.ui.controllers.AbmProductosPreciosController controller = (mz.erp.ui.controllers.AbmProductosPreciosController) _aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmAbmProductosPrecios(controller);
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 //_interfases.Add( formulario );
					 return (ITaskForm)formulario;
					
					
					 break;
					 #endregion

				 }

				 case "ABMTiposMovimientos":
				 {
					 #region ABMTiposMovimientos
					 mz.erp.ui.controllers.AbmTiposMovimientosController controller = (mz.erp.ui.controllers.AbmTiposMovimientosController) _aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmAbmTiposMovimientos(controller);
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 //_interfases.Add( formulario );
					 return (ITaskForm)formulario;										
					 break;
					 #endregion

				 }

				case "ConsultarPendientesEntregas":
				{
					#region ConsultarPendientesEntregas":
					mz.erp.ui.controllers.ComprobantesPendientesConsolaEntregas controller = (mz.erp.ui.controllers.ComprobantesPendientesConsolaEntregas)_aController.ControllerInstance;
					System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmComprobantesPendientesConsolaEntregas( controller) ;
					formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					return (ITaskForm)formulario;
					break;
					#endregion
				}

				 case "RegistrarNumerosDeSerie":
				 {
					 #region RegistrarNumerosDeSerie":
					 mz.erp.ui.controllers.RegistrarNumerosDeSerieController controller = (mz.erp.ui.controllers.RegistrarNumerosDeSerieController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmRegistrarNumerosDeSerie( controller) ;
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }

				 case "TransferirValoresCaja": 
				 {
					 #region TransferirValoresCaja":
					 
					
					 mz.erp.ui.controllers.TransferenciasValoresCajasController controller = (mz.erp.ui.controllers.TransferenciasValoresCajasController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmTransferenciasValoresCajas( controller) ;
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }

				 case "AjustarStock": 
				 {
					 #region AjustarStock":
					 mz.erp.ui.controllers.AjusteDeStockController controller = (mz.erp.ui.controllers.AjusteDeStockController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmAjusteDeStock( controller) ;
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }
				
				 case "CambioDeContraseña": 
				 {
					 #region CambioDeContraseña":
					 mz.erp.ui.controllers.CambiarContraseñaController controller = (mz.erp.ui.controllers.CambiarContraseñaController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmCambioDeContraseña( controller) ;
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }

				 case "HabilitacionOpcionDeMenu": 
				 {
					 #region HabilitacionOpcionDeMenu":
					 mz.erp.ui.controllers.HabilitarOpcionDeMenuController controller = (mz.erp.ui.controllers.HabilitarOpcionDeMenuController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmHabilitacionOpcionDeMenu( controller) ;
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }

				 case "SeleccionarCompProductosPendientesNumeroSerie": 
				 {
					 #region SeleccionarCompProductosPendientesNumeroSerie":
					 mz.erp.ui.controllers.ComprobantesConProductosPendientesDeNumeroDeSerieController controller = (mz.erp.ui.controllers.ComprobantesConProductosPendientesDeNumeroDeSerieController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmConsultas( controller) ;
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }

				 case "ConsultarStockNDias": 
				 {
					 #region ConsultarStockNDias":
					 mz.erp.ui.controllers.StockNDiasController controller = (mz.erp.ui.controllers.StockNDiasController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmStockNDias( controller) ;
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }

				 case "IngresarPrecioProducto": 
				 {
					 #region IngresarPrecioProducto":
					 mz.erp.ui.controllers.IngresarPrecioProductoController controller = (mz.erp.ui.controllers.IngresarPrecioProductoController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmIngresarPrecioProducto( controller) ;
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }

				 case "SeleccionarInstanciaOrdenReparacion": 
				 {
					 #region SeleccionarInstanciaOrdenReparacion":
					 mz.erp.ui.controllers.SeleccionarInstanciaOrdenReparacionController controller = (mz.erp.ui.controllers.SeleccionarInstanciaOrdenReparacionController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmSeleccionarInstanciaOrdenReparacion( controller) ;
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }


					 
				 case "ConsultarMovimientosStockPorJerarquias": 
				 {
					 #region ConsultarMovimientosStockPorJerarquias":
					 mz.erp.ui.controllers.ConsultaMovimientosStockController controller = (mz.erp.ui.controllers.ConsultaMovimientosStockController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmConsultaMovimientosStock( controller) ;
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }
				
				 case "ConsultarCompras": 
				 {
					 #region ConsultarCompras":
					 mz.erp.ui.controllers.ConsultaComprasController controller = (mz.erp.ui.controllers.ConsultaComprasController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmConsultaCompras( (mz.erp.ui.controllers.ConsultaComprasController) controller) ;
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }

				 case "ConsultarVentas": 
				 {
					 #region ConsultarVentas":
					 mz.erp.ui.controllers.ConsultaVentasController controller = (mz.erp.ui.controllers.ConsultaVentasController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmConsultaVentas( (mz.erp.ui.controllers.ConsultaVentasController) controller) ;
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }

				 case "ABMProductosSucursales":
				 {

					 #region ABMProductosSucursales

					 mz.erp.ui.controllers.AbmProductosSucursalesController controller = (mz.erp.ui.controllers.AbmProductosSucursalesController) _aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmAbmProductosSucursales(controller);
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 //_interfases.Add( formulario );
					 return (ITaskForm)formulario;
					
					
					 break;
					 #endregion

				 }

					 
				 case "AjustarCuentaCorriente":
				 {

					 #region AjustarCuentaCorriente

					 mz.erp.ui.controllers.ComprobanteDeAjusteCuentaCorrienteController controller = (mz.erp.ui.controllers.ComprobanteDeAjusteCuentaCorrienteController) _aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmComprobanteDeAjusteCuentaCorriente(controller);
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 //_interfases.Add( formulario );
					 return (ITaskForm)formulario;
					
					
					 break;
					 #endregion

				 }

				 case "ConsultarGastos":
				 {
					 #region ConsultarGastos

					 mz.erp.ui.controllers.ConsultarMovimientosDeCajasController controller = (mz.erp.ui.controllers.ConsultarMovimientosDeCajasController) _aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmConsultaMovimientosDeCaja(controller);
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 //_interfases.Add( formulario );
					 return (ITaskForm)formulario;
					
					
					 break;
					 #endregion
				 }

				 case "CuentaCorrienteGeneral":
				 {
					 #region CuentaCorrienteGeneral

					 mz.erp.ui.controllers.CuentaCorrienteGeneralController controller = (mz.erp.ui.controllers.CuentaCorrienteGeneralController) _aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmVisualizacionCuentaCorrienteGeneral(controller);
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 //_interfases.Add( formulario );
					 return (ITaskForm)formulario;
					
					
					 break;
					 #endregion
				 }

				 case "ConfigurarLayoutGrillas":
				 {
					 #region ConfigurarLayoutGrillas

					 mz.erp.ui.controllers.ConfigurarLayoutGrillasController controller = (mz.erp.ui.controllers.ConfigurarLayoutGrillasController) _aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.frmConfiguracionLayoutGrilla(controller);
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 //_interfases.Add( formulario );
					 return (ITaskForm)formulario;
					
					
					 break;
					 #endregion
				 }

				 case "ListarComprobantesDeCompra":
				 {
					 #region ListarComprobantesDeCompra
					 mz.erp.ui.controllers.ListarComprobantesDeCompraController listarComprobantesController = (mz.erp.ui.controllers.ListarComprobantesDeCompraController) _aController.ControllerInstance;
					 listarComprobantesController.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					 mz.erp.ui.forms.FrmConsultas aFormConsultas = new mz.erp.ui.forms.FrmConsultas(listarComprobantesController );
					 aFormConsultas.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 //_interfases.Add(_aController.KeyTask, aFormConsultas );
					 return (ITaskForm) aFormConsultas;
					 break;
					 #endregion
				 }

				 case "ModificarPreciosMasivo":
				 {
					 #region ModificarPreciosMasivo
					 mz.erp.ui.controllers.ModificarPreciosMasivoController listarComprobantesController = (mz.erp.ui.controllers.ModificarPreciosMasivoController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmModificarPreciosMasivo aFormConsultas = new mz.erp.ui.forms.FrmModificarPreciosMasivo(listarComprobantesController );
					 aFormConsultas.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 //_interfases.Add(_aController.KeyTask, aFormConsultas );
					 return (ITaskForm) aFormConsultas;
					 break;
					 #endregion
				 }

				 case "IngresarCodigoSecundario":
				 {
					 #region IngresarCodigoSecundario
					 mz.erp.ui.controllers.IngresarCodigoSecundarioController _controller = (mz.erp.ui.controllers.IngresarCodigoSecundarioController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmIngresarCodigoSecundario aForm = new mz.erp.ui.forms.FrmIngresarCodigoSecundario(_controller );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 //_interfases.Add(_aController.KeyTask, aFormConsultas );
					 return (ITaskForm) aForm;
					 break;
					 #endregion
				 }
				 case "ABMCuentasObservacionesEstados": 
					 #region ABMCuentasObservacionesEstados
					 mz.erp.ui.controllers.ABMCuentasObservacionesEstadosControllers aBMCuentasObservacionesEstadosControllers = (mz.erp.ui.controllers.ABMCuentasObservacionesEstadosControllers) _aController.ControllerInstance;
					// aBMCuentasObservacionesEstadosControllers.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					 mz.erp.ui.forms.FrmAbmCuentasObservacionesEstados frmABMCOE = new mz.erp.ui.forms.FrmAbmCuentasObservacionesEstados(aBMCuentasObservacionesEstadosControllers);
					 frmABMCOE.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 //_interfases.Add(_aController.KeyTask, formulario );
					 return (ITaskForm)frmABMCOE;
					 break;
					 #endregion

				 case "ModificarProductosMasivo":
				 {
					 
					 #region ModificarProductosMasivo
					 
					 mz.erp.ui.controllers.ModificarProductosMasivoController _controller = (mz.erp.ui.controllers.ModificarProductosMasivoController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmModificarProductosMasivo aForm = new mz.erp.ui.forms.FrmModificarProductosMasivo(_controller );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }

				 case "AbmTiposObservacionesCuentas":
				 {
					 
					 #region TiposObservacionesCuentas
					 
					 mz.erp.ui.controllers.TiposObservacionesCuentasController _controller = (mz.erp.ui.controllers.TiposObservacionesCuentasController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmAbmTiposObservacionesCuentas aForm = new mz.erp.ui.forms.FrmAbmTiposObservacionesCuentas(_controller );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }


				 case "ConsultarValores":
				 {

					 #region ConsultarValores
					 
					 mz.erp.ui.controllers.ConsultaValoresController _controller = (mz.erp.ui.controllers.ConsultaValoresController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmConsultaValores aForm = new mz.erp.ui.forms.FrmConsultaValores(_controller );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }
				 case "ConsultarProductos": 
				 {
					 #region ConsultarProductos:
					 mz.erp.ui.controllers.mzProductosSearchFormWorkflowController controller = (mz.erp.ui.controllers.mzProductosSearchFormWorkflowController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.mzProductosSearchFormWorkflow( (mz.erp.ui.controllers.mzProductosSearchFormWorkflowController) controller) ;
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }
				 
				 case "AbmVisualizacionDeStock": 
				 {
					 #region AbmVisualizacionDeStock:
					 mz.erp.ui.controllers.AbmVisualizacionDeStockController controller = (mz.erp.ui.controllers.AbmVisualizacionDeStockController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmAbmVisualizacionDeStock( (mz.erp.ui.controllers.AbmVisualizacionDeStockController) controller) ;
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }


				
				 case "ABMComprobantesCategoriaIva": 
				 {
					 #region ABMComprobantesCategoriaIva:
					 mz.erp.ui.controllers.ABMComprobantesCategoriaIvaController controller = (mz.erp.ui.controllers.ABMComprobantesCategoriaIvaController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmABMComprobantesCategoriaIva( (mz.erp.ui.controllers.ABMComprobantesCategoriaIvaController) controller) ;
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }
					
				 case "ConfigurarVariables":

				 {
					 #region ConfigurarVariables:
					 mz.erp.ui.controllers.ConfigurarVariablesController controller = (mz.erp.ui.controllers.ConfigurarVariablesController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmConfigurarVariables( controller) ;
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }

				 case "ConsultarEntregas": 
				 {
					 #region ConsultarEntregas":
					 mz.erp.ui.controllers.ConsultaEntregasController controller = (mz.erp.ui.controllers.ConsultaEntregasController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmConsultaEntregas( (mz.erp.ui.controllers.ConsultaEntregasController) controller) ;
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }

				 case "ConsultarPersonas": 
				 {
					 #region ConsultarPersonas:
					 mz.erp.ui.controllers.mzPersonasSearchFormController controller = (mz.erp.ui.controllers.mzPersonasSearchFormController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.mzPersonasSearchForm( (mz.erp.ui.controllers.mzPersonasSearchFormController) controller) ;
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }
				 case "ABMLocalidades": 
					 #region ABMLocalidades
					 mz.erp.ui.controllers.ABMLocalidadesController aBMLocalidadesControllers = (mz.erp.ui.controllers.ABMLocalidadesController) _aController.ControllerInstance;
					 // aBMCuentasObservacionesEstadosControllers.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					 mz.erp.ui.forms.FrmABMLocalidadesWorkflow frmABMLOc= new mz.erp.ui.forms.FrmABMLocalidadesWorkflow(aBMLocalidadesControllers);
					 frmABMLOc.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 //_interfases.Add(_aController.KeyTask, formulario );
					 return (ITaskForm)frmABMLOc;
					 break;
					 #endregion

				 case "ConsultarListasDePrecios": 
				 {
					 #region ConsultarListasDePrecios:
					 mz.erp.ui.controllers.ConsultarListasDePreciosController controller = (mz.erp.ui.controllers.ConsultarListasDePreciosController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmConsultarListasDePrecios( (mz.erp.ui.controllers.ConsultarListasDePreciosController) controller) ;
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }

				 case "ConsultarListasDePreciosProveedores": 
				 {
					 #region ConsultarListasDePreciosProveedores:
					 mz.erp.ui.controllers.ConsultaComprasController controller = (mz.erp.ui.controllers.ConsultaComprasController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmConsultaCompras( (mz.erp.ui.controllers.ConsultaComprasController) controller) ;
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }

				 case "PagarServiciosGastosCompras":
				 {
					 mz.erp.ui.controllers.PagarServiciosGastosComprasController controllerPS = (mz.erp.ui.controllers.PagarServiciosGastosComprasController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formularioPS = new mz.erp.ui.forms.FrmPagosGastosServicios( (mz.erp.ui.controllers.PagarServiciosGastosComprasController) controllerPS) ;
					 formularioPS.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formularioPS;
					 break;
				 }

				 case "ComprobanteDePagoCompras":
				 {
					 mz.erp.ui.controllers.IngresarComprobanteDePagoComprasController controllerPC = (mz.erp.ui.controllers.IngresarComprobanteDePagoComprasController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formularioPC = new mz.erp.ui.forms.FrmComprobantesDePagoCompras( (mz.erp.ui.controllers.IngresarComprobanteDePagoComprasController) controllerPC) ;
					 formularioPC.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formularioPC;
					 break;
				 }

				 case "AbmBonificaciones": 
				 {
					 mz.erp.ui.controllers.AbmBonificacionesController controllerB = (mz.erp.ui.controllers.AbmBonificacionesController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formularioB = new mz.erp.ui.forms.FrmAbmBonificacionesEx( (mz.erp.ui.controllers.AbmBonificacionesController) controllerB) ;
					 formularioB.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formularioB;
					 break;
				 }

				 case "ABMChequeras": 
				 {
					 mz.erp.ui.controllers.ABMChequerasControllers controllerCh = (mz.erp.ui.controllers.ABMChequerasControllers)_aController.ControllerInstance;
					 System.Windows.Forms.Form formularioCh = new mz.erp.ui.forms.FrmAbmChequeras( (mz.erp.ui.controllers.ABMChequerasControllers) controllerCh) ;
					 formularioCh.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formularioCh;  
					 break;
				 }

				 case "DepositoBancario": 
				 {
					 mz.erp.ui.controllers.DepositoBancarioController controllerDep = (mz.erp.ui.controllers.DepositoBancarioController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formularioDep = new mz.erp.ui.forms.FrmDepositoBancario( (mz.erp.ui.controllers.DepositoBancarioController) controllerDep) ;
					 formularioDep.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formularioDep;
					 break;
				 }

					



				 case "ConfirmarPreciosProductosCompras": 
				 {
					 #region ConfirmarPreciosProductosCompras:
					 mz.erp.ui.controllers.ConfirmarPreciosProductosComprasController controller = (mz.erp.ui.controllers.ConfirmarPreciosProductosComprasController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmConfirmarPreciosProductosCompras( (mz.erp.ui.controllers.ConfirmarPreciosProductosComprasController) controller) ;
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }



				 case "ConsultarProductosSinMovimientos": 
				 {
					 #region ConsultarProductosSinMovimientos:
					 mz.erp.ui.controllers.mzProductosSearchFormWorkflowController controller = (mz.erp.ui.controllers.mzProductosSearchFormWorkflowController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.mzProductosSearchFormWorkflow( (mz.erp.ui.controllers.mzProductosSearchFormWorkflowController) controller) ;
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }

				 case "ConsultarLibroIVA": 
				 {
					 #region ConsultarLibroIVA:
					 mz.erp.ui.controllers.ConsultarLibroIVAController controllerLIVA = (mz.erp.ui.controllers.ConsultarLibroIVAController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formularioLIVA = new mz.erp.ui.forms.FrmConsultarLibroIVA( (mz.erp.ui.controllers.ConsultarLibroIVAController) controllerLIVA) ;
					 formularioLIVA.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formularioLIVA;
					 break;
					 #endregion
				 }

				 case "ConsultarRetencionesProveedores": 
				 {
					 #region ConsultarRetencionesProveedores:
					 mz.erp.ui.controllers.ConsultarRetencionesProveedoresController controller = (mz.erp.ui.controllers.ConsultarRetencionesProveedoresController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmConsultarRetencionesProveedores( (mz.erp.ui.controllers.ConsultarRetencionesProveedoresController) controller) ;
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }

				 case "ConsultarSeguimientoCompras": 
				 {
					 #region ConsultarSeguimientoCompras:
					 mz.erp.ui.controllers.ConsultarSeguimientoComprasController controller = (mz.erp.ui.controllers.ConsultarSeguimientoComprasController)_aController.ControllerInstance;
					 System.Windows.Forms.Form formulario = new mz.erp.ui.forms.FrmConsultarSeguimientoCompras( (mz.erp.ui.controllers.ConsultarSeguimientoComprasController) controller) ;
					 formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)formulario;
					 break;
					 #endregion
				 }

				 case "AbmTiposObservacionesProveedores":
				 {
					 
					 #region TiposObservacionesProveedores
					 
					 mz.erp.ui.controllers.TiposObservacionesCuentasController _controller = (mz.erp.ui.controllers.TiposObservacionesCuentasController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmAbmTiposObservacionesCuentas aForm = new mz.erp.ui.forms.FrmAbmTiposObservacionesCuentas(_controller );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }

				 case "ConfigurarMenues":
				 { 
					 #region ConfigurarMenues
					 mz.erp.ui.controllers.ConfigurarMenuesController confMController = (mz.erp.ui.controllers.ConfigurarMenuesController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmConfigurarMenues aForm = new mz.erp.ui.forms.FrmConfigurarMenues(confMController );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)aForm;
					
					 break;
					 #endregion
				 }

				 case "ConsultarEntrega":
				 { 
					 #region ConsultarEntrega
					 mz.erp.ui.controllers.ConsultaEntregasController consultaEntregaController = (mz.erp.ui.controllers.ConsultaEntregasController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmConsultaEntregas consultarEntregaForm = new mz.erp.ui.forms.FrmConsultaEntregas(consultaEntregaController);
					 consultarEntregaForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)consultarEntregaForm;
					
					 break;
					 #endregion
				 }

				 case "ListarTareasRealizadasOrdenReparacion":
				 { 
					 #region ListarTareasRealizadasOrdenReparacion
					 mz.erp.ui.controllers.ListarTareasRealizadasOrdenReparacionController listarTRORController = (mz.erp.ui.controllers.ListarTareasRealizadasOrdenReparacionController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmListarTareasRealizadasOrdenReparacion aForm = new mz.erp.ui.forms.FrmListarTareasRealizadasOrdenReparacion(listarTRORController );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm)aForm;
					
					 break;
					 #endregion
				 }

				 case "AbmMotivoOrdenReparacion":
				 {
					 
					 #region AbmMotivoOrdenReparacion
					 
					 mz.erp.ui.controllers.AbmMotivoOrdenReparacionController _controller = (mz.erp.ui.controllers.AbmMotivoOrdenReparacionController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmAbmMotivoOrdenReparacion aForm = new mz.erp.ui.forms.FrmAbmMotivoOrdenReparacion(_controller );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }


				 case "AbmServicio":
				 {
					 
					 #region AbmServicio
					 
					 mz.erp.ui.controllers.AbmServicioController _controller = (mz.erp.ui.controllers.AbmServicioController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmAbmServicio aForm = new mz.erp.ui.forms.FrmAbmServicio(_controller );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }

				 case "ConsultarEstadisticaOrdenReparacion":
				 {
					 
					 #region ConsultarEstadisticaOrdenReparacion
					 
					 mz.erp.ui.controllers.ConsultarEstadisticaOrdenReparacionController _controller = (mz.erp.ui.controllers.ConsultarEstadisticaOrdenReparacionController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmConsultarEstadisticaOrdenReparacion aForm = new mz.erp.ui.forms.FrmConsultarEstadisticaOrdenReparacion(_controller );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }
				 
				 case "AbmTarea":
				 {					 
					 #region AbmTarea
					 
					 mz.erp.ui.controllers.AbmTareaController _controller = (mz.erp.ui.controllers.AbmTareaController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmAbmTarea aForm = new mz.erp.ui.forms.FrmAbmTarea(_controller );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }

				 case "CierreMasivoOrdenReparacion":
				 {					 
					 #region CierreMasivoOrdenReparacion
					 
					 mz.erp.ui.controllers.CierreMasivoOrdenReparacionController _controller = (mz.erp.ui.controllers.CierreMasivoOrdenReparacionController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmCierreMasivoOrdenReparacion aForm = new mz.erp.ui.forms.FrmCierreMasivoOrdenReparacion(_controller );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }

				 case "ConsultarProductosConPreciosModificados":
				 {					 
					 #region ConsultarProductosConPreciosModificados
					 
					 mz.erp.ui.controllers.ConsultarProductosConPreciosModificadosController _controller = (mz.erp.ui.controllers.ConsultarProductosConPreciosModificadosController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmConsultarProductosConPreciosModificados aForm = new mz.erp.ui.forms.FrmConsultarProductosConPreciosModificados(_controller );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }

				 case "ABMCondicionesDeVenta":
				 {
					 #region ABMCondicionesDeVenta
					 
					 mz.erp.ui.controllers.ABMCondicionesDeVentaController _controller = (mz.erp.ui.controllers.ABMCondicionesDeVentaController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmABMCondicionesDeVenta aForm = new mz.erp.ui.forms.FrmABMCondicionesDeVenta (_controller );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }

				 case "ABMEntidades":
				 {
					 #region ABMEntidades
					 
					 mz.erp.ui.controllers.ABMEntidadesController _controller = (mz.erp.ui.controllers.ABMEntidadesController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmAbmEntidadesW aForm = new mz.erp.ui.forms.FrmAbmEntidadesW (_controller );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }

				 case "AbmCostosIndirectos":
				 {
					 #region AbmCostosIndirectos
					 
					 mz.erp.ui.controllers.AbmCostosIndirectosController _controller = (mz.erp.ui.controllers.AbmCostosIndirectosController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmABMCostosIndirectos aForm = new mz.erp.ui.forms.FrmABMCostosIndirectos (_controller );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }

				 case "ModificarPreciosMasivoDesdeExcel":
				 {
					 #region ModificarPreciosMasivoDesdeExcel
					 
					 mz.erp.ui.controllers.ModificarPreciosMasivoDesdeExcelController _controller = (mz.erp.ui.controllers.ModificarPreciosMasivoDesdeExcelController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmModificarPreciosMasivoDesdeExcel aForm = new mz.erp.ui.forms.FrmModificarPreciosMasivoDesdeExcel (_controller );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }

				 case "ConsultarVariables":
				 {
					 #region ConsultarVariables
					 
					 mz.erp.ui.controllers.ConsultarVariablesController _controller = (mz.erp.ui.controllers.ConsultarVariablesController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmConsultarVariables aForm = new mz.erp.ui.forms.FrmConsultarVariables (_controller );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }
				 
				 case "ABMVariables":
				 {
					 #region ABMVariables
					 
					 mz.erp.ui.controllers.ABMVariablesController _controller = (mz.erp.ui.controllers.ABMVariablesController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmABMVariables aForm = new mz.erp.ui.forms.FrmABMVariables (_controller );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }

				 case "ABMTiposDeAjusteStock":
				 {
					 #region ABMTiposDeAjusteStock
					 
					 mz.erp.ui.controllers.ABMTiposDeAjusteStockController _controller = (mz.erp.ui.controllers.ABMTiposDeAjusteStockController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmAbmTiposDeAjusteStock aForm = new mz.erp.ui.forms.FrmAbmTiposDeAjusteStock (_controller );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }

				 case "AbmTipoDeComprobante":
				 {
					 #region AbmTipoDeComprobante
					 
					 mz.erp.ui.controllers.AbmTipoDeComprobanteController _controller = (mz.erp.ui.controllers.AbmTipoDeComprobanteController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmAbmTiposDeComprobantes aForm = new mz.erp.ui.forms.FrmAbmTiposDeComprobantes (_controller );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }

				 case "JerarquiaConfigurarVariable":
				 {
					 #region JerarquiaConfigurarVariable
					 
					 mz.erp.ui.controllers.JerarquiaConfigurarVariableController _controller = (mz.erp.ui.controllers.JerarquiaConfigurarVariableController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmJerarquiaConfigurarVariable aForm = new mz.erp.ui.forms.FrmJerarquiaConfigurarVariable(_controller );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }

				 case "AbmPerfil":
				 {
					 #region AbmPerfil
					 
					 mz.erp.ui.controllers.AbmPerfilController _controller = (mz.erp.ui.controllers.AbmPerfilController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmAbmPerfiles aForm = new mz.erp.ui.forms.FrmAbmPerfiles(_controller);
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }

				 case "ConsultarFacturasImpagas":
				 {
					 #region ConsultarFacturasImpagas
					 
					 mz.erp.ui.controllers.ConsultarFacturasImpagasController _controller = (mz.erp.ui.controllers.ConsultarFacturasImpagasController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmConsultarFacturasImpagas aForm = new mz.erp.ui.forms.FrmConsultarFacturasImpagas (_controller );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }

				 case "SoporteModificarComprobantes":
				 {
					 #region SoporteModificarComprobantes
					 
					 mz.erp.ui.controllers.SoporteModificarComprobantesController _controller = (mz.erp.ui.controllers.SoporteModificarComprobantesController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmSoporteModificarComprobantes aForm = new mz.erp.ui.forms.FrmSoporteModificarComprobantes(_controller);
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }

				 case "ConfigurarPrecios":
				 {
					 #region ConfigurarPrecios
					 
					 mz.erp.ui.controllers.ConfigurarPreciosController _controller = (mz.erp.ui.controllers.ConfigurarPreciosController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmConfigurarPrecios aForm = new mz.erp.ui.forms.FrmConfigurarPrecios (_controller );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }

				 case "AutorizarFacturasCompras":
				 {
					 #region AutorizarFacturasCompras
					 
					 mz.erp.ui.controllers.AutorizarFacturasComprasController _controller = (mz.erp.ui.controllers.AutorizarFacturasComprasController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmAutorizarFacturasCompras aForm = new mz.erp.ui.forms.FrmAutorizarFacturasCompras (_controller );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }

				 case "ControlarCajas":
				 {
					 #region ControlarCajas
					 
					 mz.erp.ui.controllers.ControlarCajasController _controller = (mz.erp.ui.controllers.ControlarCajasController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmControlarCajas aForm = new mz.erp.ui.forms.FrmControlarCajas (_controller );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }

				 case "ConsultarControlCajas":
				 {
					 #region ConsultarControlCajas
					 
					 mz.erp.ui.controllers.ConsultarControlCajasController _controller = (mz.erp.ui.controllers.ConsultarControlCajasController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmConsultarControlCajas aForm = new mz.erp.ui.forms.FrmConsultarControlCajas (_controller );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }

				 //Sabrina 20100615 - Tarea 766
				 case "ModificarCuentasMasivo":
				 {
					 #region ModificarCuentasMasivo
					 
					 mz.erp.ui.controllers.ModificarCuentasMasivoController _controller = (mz.erp.ui.controllers.ModificarCuentasMasivoController) _aController.ControllerInstance;
					 mz.erp.ui.forms.FrmModificarCuentasMasivo aForm = new mz.erp.ui.forms.FrmModificarCuentasMasivo (_controller );
					 aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					 return (ITaskForm) aForm;
					 
					 break;
					 #endregion
				 }
				 //Fin Sabrina 20100615 - Tarea 766

                 //Matias 20110422 - Tarea 0000061
                 case "IngresarPadronARBA":
                 {
                     #region IngresarPadronARBA

                     mz.erp.ui.controllers.IngresarPadronARBAController _controller = (mz.erp.ui.controllers.IngresarPadronARBAController)_aController.ControllerInstance;
                     mz.erp.ui.forms.FrmIngresarPadronARBA aForm = new mz.erp.ui.forms.FrmIngresarPadronARBA(_controller);
                     aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
                     return (ITaskForm)aForm;

                     break;
                     #endregion
                 }
                 //FinMatias 20110422 - Tarea 0000061

                 //Matias 20110429 - Tarea 0000061
                 case "ConsultarActualizacionAlicuotasIIBB":
                 {
                     #region ConsultarActualizacionAlicuotasIIBB

                     mz.erp.ui.controllers.ConsultarActualizacionAlicuotasIIBBController _controller = (mz.erp.ui.controllers.ConsultarActualizacionAlicuotasIIBBController)_aController.ControllerInstance;
                     mz.erp.ui.forms.FrmConsultarActualizacionAlicuotasIIBB aForm = new mz.erp.ui.forms.FrmConsultarActualizacionAlicuotasIIBB(_controller);
                     aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
                     return (ITaskForm)aForm;

                     break;
                     #endregion
                 }
                 //FinMatias 20110429 - Tarea 0000061

                 /* Silvina 20111104 - Tarea 0000222 */
                 case "AbmProductosCategoriasCuentas":
                 {
                     mz.erp.ui.controllers.AbmProductosCategoriasCuentasController _controller = (mz.erp.ui.controllers.AbmProductosCategoriasCuentasController)_aController.ControllerInstance;
                     mz.erp.ui.forms.FrmAbmProductosCategoriasCuentas aForm = new mz.erp.ui.forms.FrmAbmProductosCategoriasCuentas(_controller);
                     aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
                     return (ITaskForm)aForm;
                     break;
                 }
                 /* Fin Silvina 20111104 - Tarea 0000222 */

                //German 20120228 -  Tarea 0000247
                 case "ConsultarSeguimientoAcopios":
                 {
                     mz.erp.ui.controllers.ConsultarSeguimientoAcopioController _controller = (mz.erp.ui.controllers.ConsultarSeguimientoAcopioController)_aController.ControllerInstance;
                     mz.erp.ui.forms.FrmConsultarSeguimientoAcopios aForm = new mz.erp.ui.forms.FrmConsultarSeguimientoAcopios(_controller);
                     aForm.MdiParent = mz.erp.ui.utility.Environment.MainForm;
                     return (ITaskForm)aForm;
                     break;
                 }
                 //Fin German 20120228 -  Tarea 0000247

            
				 default:

				{
					#region DefaultForm
					mz.erp.ui.controllers.DefaultController defaultcontroller = (mz.erp.ui.controllers.DefaultController) _aController.ControllerInstance;
					defaultcontroller.OnTaskAfterExecute += new EventHandler(ListenerOnTaskAfterExecute);
					mz.erp.ui.forms.DefaultForm formulario = new mz.erp.ui.forms.DefaultForm(defaultcontroller);
					formulario.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					//_interfases.Add(_aController.KeyTask, formulario );
					return (ITaskForm)formulario;
					break;
					#endregion
				}
				
			}
		}
		
		private void ShowInterfases(int index)
		{
			
		}

		private void ListenerOnTaskAfterExecute(object sender, EventArgs e)
		{
			
		}

		bool _workflowClosed = false;
		private void ListenerProcessNextTask(ControllerDynamicInfo taskController)
		{
			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
			ITaskController controller = (ITaskController)taskController.ControllerInstance;							
			if(_actualForm != null)
			{
				WorkFlowClose = true;

				_actualForm.CloseForm();

			}

			_actualForm = CallStaticInterfase(taskController);
			((Form)_actualForm).Closed+=new EventHandler(ProcessUIManager_Closed);
			_actualForm.ShowForm();
			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
		}

		private void ListenerEndProcess(ControllerDynamicInfo taskController)
		{
			ITaskController controller = (ITaskController)taskController.ControllerInstance;			
				
			if(_actualForm != null)
			{
				((Form)_actualForm).Closed+=new EventHandler(ProcessUIManager_Closed);
				WorkFlowClose = true;
				_actualForm.CloseForm();
				WorkFlowClose = false;
			}
			
			//if (!ProcessHadProblems)
            //Cristian tarea 0000145
            if (_process.ShowMessageEndProcess)
            {
                System.Windows.Forms.MessageBox.Show("El proceso ha finalizado con éxito.", "Mensaje", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            //Fin Cristian
			if (this._process.AskRecallProcess) 
			{
				if (System.Windows.Forms.MessageBox.Show( "¿Desea repetir el ciclo?","Repetir proceso", System.Windows.Forms.MessageBoxButtons.YesNo ) == System.Windows.Forms.DialogResult.Yes )
					ProcessLoader.CallProcess( this.ActualProcess );			
			}
			else 
			{
				if (this._process.RecallProcess) 
				{
					ProcessLoader.CallProcess( this.ActualProcess );
				}
			}			
		}

		private void ListenerProcessErrors(ControllerDynamicInfo taskController)
		{
			ITaskController controller = (ITaskController)taskController.ControllerInstance;
			if(controller.GetErrors().Count > 0)
			{
				/*20110328 - Tarea 0000057*/ FrmShowErrors _form = new /*20110328 - Tarea 0000057*/ FrmShowErrors( controller.GetErrors() );
				_form.ShowDialog();
			}
		}
		private void ListenerProcessFlushError(ControllerDynamicInfo taskController, string mensaje, ItemsDatasetErrors flushErrors)
		{
			if(_actualForm != null)
				_actualForm.CloseForm();
			if(mensaje != null && mensaje != string.Empty)
				System.Windows.Forms.MessageBox.Show(mensaje, "Error al intentar guardar los datos",System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			if(flushErrors.Count > 0)
			{
				/*20110328 - Tarea 0000057*/ FrmShowErrors _form = new /*20110328 - Tarea 0000057*/ FrmShowErrors( flushErrors );
				_form.ShowDialog();
			}
			if (this._process.AskRecallProcess) 
			{
				if (System.Windows.Forms.MessageBox.Show( "¿Desea repetir el ciclo?","Repetir proceso", System.Windows.Forms.MessageBoxButtons.YesNo ) == System.Windows.Forms.DialogResult.Yes )
					ProcessLoader.CallProcess( this.ActualProcess );			
			}
			else 
			{
				if (this._process.RecallProcess) 
				{
					ProcessLoader.CallProcess( this.ActualProcess );
				}
			}		
		}

		private void ListenerProcessWarnings(ControllerDynamicInfo taskController)
		{
			ITaskController controller = (ITaskController)taskController.ControllerInstance;
			string _str = controller.GetWarnings();
			if  (_str != null & !_str.Equals(String.Empty)) 
			{	
				FrmShowWarnings _form = new FrmShowWarnings( _str );
				_form.ShowDialog();		
				if (_form.DialogResult == System.Windows.Forms.DialogResult.OK)
				{
					//si presiona aceptar, como no hay mz.erp.ui.forms.classes.Errores, continua con el WF
					_process.Continue();
					controller.Continue();
				}
				//si presiono cancelar se queda en el formulario, que dió el mensaje de warning	
				if (_form.DialogResult == System.Windows.Forms.DialogResult.Cancel)
				{
					_process.MostroWarnings=false;
				}
				
			}
		}


		private void ListenerProcessPreviousTask(ControllerDynamicInfo taskController)
		{
			ITaskController controller = (ITaskController)taskController.ControllerInstance;						
			if(_actualForm != null)
			{
				WorkFlowClose = true;
				_actualForm.CloseForm();
				WorkFlowClose = false;
			}
			_actualForm = CallStaticInterfase(taskController);
			((Form)_actualForm).Closed+=new EventHandler(ProcessUIManager_Closed);
			_actualForm.ShowForm();
		}

		private void ListenerProcessErrorsOnStart(ItemsDatasetErrors errors)
		{
			if(errors.Count > 0)
			{
				/*20110328 - Tarea 0000057*/ FrmShowErrors _form = new /*20110328 - Tarea 0000057*/ FrmShowErrors( errors );
				//20110328 - Tarea 0000057
                _form.ShowDialog();
				//_form.ShowForm();
                //Fin 20110328 - Tarea 0000057
			}
			else
				MessageBox.Show("Ha Ocurrido un error. El Proceso no puede iniciarse debido a no estan dadas las condiciones","El Proceso no puede iniciarse",MessageBoxButtons.OK,MessageBoxIcon.Error);
		}

		private void ProcessUIManager_Closed(object sender, EventArgs e)
		{
			if (!WorkFlowClose)
			{
				_process.EndByUser();
			}

		}

	}
}

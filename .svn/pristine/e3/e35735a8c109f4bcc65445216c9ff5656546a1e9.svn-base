using System;
using System.Data;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using System.Drawing;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de mzProductosSearchFormWorkflowController.
	/// </summary>
	public class mzProductosSearchFormWorkflowController: ITaskController
	{

		#region Constructores
		public mzProductosSearchFormWorkflowController(mzProductosSearchFormWorkflow brClass)
		{
			_brClass = brClass;
			Init();
		}
		#endregion
	
	    #region Variables Privadas

		private mzProductosSearchFormWorkflow _brClass;
		private string _leyendaFormulario;
		private string _resultDescripcion = string.Empty;
        private string _resultObservaciones = string.Empty;
		private string _resultCampoAuxiliar1 = string.Empty;
		private string _resultCampoAuxiliar2 = string.Empty;
		private string _resultCampoAuxiliar3 = string.Empty;
		private string _resultCampoAuxiliar4 = string.Empty;
		private string _resultCampoAuxiliar5 = string.Empty;
		private decimal _resultPrecioFinalMO = 0;
		private decimal _resultPrecioFinalMD = 0;		
		private decimal _resultPrecioDeVentaBrutoMDRecargoCondicionDeVenta = 0;
		private decimal _resultPrecioDeVentaBrutoMORecargoCondicionDeVenta = 0;
		private string _etiquetaResultPrecioFinalMO = string.Empty;
		private string _etiquetaResultPrecioNetoMO = string.Empty;
		private string _etiquetaResultPrecioFinalMD = string.Empty;
		private string _etiquetaResultPrecioNetoMD = string.Empty;
		private System.Collections.ArrayList _preciosPorCondicionDeVenta;
		private bool _condicionesDeVentasOrdenadasBD = Variables.GetValueBool("Productos.Solapas.PreciosPorCondicionDeVenta.HabilitaOrden");
		private decimal _resultPrecioFinalMDRecargoCondicionDeVenta = 0;
		private decimal _resultPrecioFinalMORecargoCondicionDeVenta = 0;
		private Image _thumb;
		private string _layoutFormasDePago = new mz.erp.ui.controllers.tfi_FormasDePagoEx(new string[] {"IdFormaDePago","Descripcion","DescripcionEntidad","Cuotas","Recargo","Agrupado","IdTDComprobante","IdEntidad","IdMoneda","IdCotizacion","ImporteConRecargo","ValorDeLaCuota"}).GetLayout( );
		private mz.erp.businessrules.comprobantes.FormasDePagos _fdp = mz.erp.businessrules.tfi_FormasDePagoEx.GetFormasDePago();
		private string _listaFormasDePagos = Variables.GetValueString("Productos.Solapas.PreciosMediosDePagoVisible.ListaDeTDCompTesoreria");
		private bool _formasDePagosOrdenadasBD = Variables.GetValueBool("Productos.Solapas.PreciosMediosDePagoVisible.HabilitaOrden");
		private decimal _resultPrecioFinalImpuestosIncludos = 0;
		private string _idProductoSeleccionado = string.Empty;
		#endregion
	
		#region Propiedades

		public DataTable DataTableResult
		{
			get { return _brClass.Result; }
		}

		public DateTime FechaDesde
		{
			get{return _brClass.FechaDesde;}
			set{_brClass.FechaDesde = value;}
		} 

		public DateTime FechaHasta
		{
			get{return _brClass.FechaHasta;}
			set{_brClass.FechaHasta = value;}
		} 

		public string ProcessName
		{
			get{return _brClass.GetProcessManagerParent().Process.ProcessName;}
		}

		private bool _allowEditCodigo = true;
		public bool AllowEditCodigo
		{
			get{return _allowEditCodigo;}
		}

		private bool _allowEditCodigoSecundario = true;
		public bool AllowEditCodigoSecundario
		{
			get{return _allowEditCodigoSecundario;}
		}

		private bool _allowEditDescripcion = true;
		public bool AllowEditDescripcion
		{
			get{return _allowEditDescripcion;}
		}

		private bool _allowEditDescripcionCorta = true;
		public bool AllowEditDescripcionCorta
		{
			get{return _allowEditDescripcionCorta;}
		}

		private bool _allowEditDescripcionLarga = true;
		public bool AllowEditDescripcionLarga
		{
			get{return _allowEditDescripcionLarga;}
		}
		
		private bool _allowEditActivo = true;
		public bool AllowEditActivo
		{
			get{return _allowEditActivo;}
		}

		private bool _allowEditHabilitarActivo = true;
		public bool AllowEditHabilitarActivo
		{
			get{return _allowEditHabilitarActivo;}
		}

		private bool _allowEditTipoProducto = true;
		public bool AllowEditTipoProducto
		{
			get{return _allowEditTipoProducto;}
		}

		private bool _allowEditObservaciones = true;
		public bool AllowEditObservaciones
		{
			get{return _allowEditObservaciones;}
		}

		private bool _allowEditCampoAuxiliar1 = true;
		public bool AllowEditCampoAuxiliar1
		{
			get{return _allowEditCampoAuxiliar1;}
		}

		private bool _allowEditCampoAuxiliar2 = true;
		public bool AllowEditCampoAuxiliar2
		{
			get{return _allowEditCampoAuxiliar2;}
		}

		private bool _allowEditCampoAuxiliar3 = true;
		public bool AllowEditCampoAuxiliar3
		{
			get{return _allowEditCampoAuxiliar3;}
		}
		
		private bool _allowEditCampoAuxiliar4 = true;
		public bool AllowEditCampoAuxiliar4
		{
			get{return _allowEditCampoAuxiliar4;}
		}
		
		private bool _allowEditCampoAuxiliar5 = true;
		public bool AllowEditCampoAuxiliar5
		{
			get{return _allowEditCampoAuxiliar5;}
		}
		
		private bool _allowEditObligaCodigoBarra = true;
		public bool AllowEditObligaCodigoBarra
		{
			get{return _allowEditObligaCodigoBarra;}
		}

		private bool _allowEditHabilitarObligaCB = true;
		public bool AllowEditHabilitarObligaCB
		{
			get{return _allowEditHabilitarObligaCB;}
		}
		
		private bool _allowEditObligaNumeroSerie = true;
		public bool AllowEditObligaNumeroSerie
		{
			get{return _allowEditObligaNumeroSerie;}
		}

		private bool _allowEditHabilitarObligaNS = true;
		public bool AllowEditHabilitarObligaNS
		{
			get{return _allowEditHabilitarObligaNS;}
		}

		private bool _allowEditPercibeIB = true;
		public bool AllowEditPercibeIB
		{
			get{return _allowEditPercibeIB;}
		}

		private bool _allowEditHabilitarPercibeIB = true;
		public bool AllowEditHabilitarPercibeIB
		{
			get{return _allowEditHabilitarPercibeIB;}
		}

		private bool _allowEditBonificacion = true;
		public bool AllowEditBonificacion
		{
			get{return _allowEditBonificacion;}
		}
		
		private bool _allowEditFechaDesde = true;
		public bool AllowEditFechaDesde
		{
			get{return _allowEditFechaDesde;}
		}

		private bool _allowEditFechaHasta = true;
		public bool AllowEditFechaHasta
		{
			get{return _allowEditFechaHasta;}
		}
		
		private string _solapasHabilitadas = string.Empty;
		public string SolapasHabilitadas
		{
			get{return _solapasHabilitadas;}
		}

		private string _solapaActiva = string.Empty;
		public string SolapaActiva
		{
			get{return _solapaActiva;}
		}

		public string LeyendaFormulario
		{
			get
			{
				return this._leyendaFormulario;
			}
		}

		public string TextoBotonSiguiente
		{
			get { return _brClass.TextoBotonSiguiente ; }
		}
		
		public string TextoBotonAnterior
		{
			get { return _brClass.TextoBotonAnterior; }
		}

		private System.Data.DataSet _stockDataset;
		public System.Data.DataSet DataStock
		{
			get { return _stockDataset ; }
		}

		public string LayoutFormasDePago
		{
			get { return _layoutFormasDePago; }
		}

        public Image Thumb
		{
			get{return _thumb;}
		}


		public decimal ResultPrecioFinalMDRecargoCV
		{
			get{return _resultPrecioFinalMDRecargoCondicionDeVenta;}
		}

		public decimal ResultPrecioFinalMORecargoCV
		{
			get{return _resultPrecioFinalMORecargoCondicionDeVenta;}
		}

		public decimal ResultPrecioFinalImpuestosIncluidos
		{
			get { return _resultPrecioFinalImpuestosIncludos; }
		}

		public FormasDePagos PreciosSegunFormaDePago
		{
			get { return _fdp ; }
		}

		public ArrayList PreciosPorCondicionDeVenta
		{
			get { return _preciosPorCondicionDeVenta; }
		}

		public string LayoutPreciosPorCondicionesDeVenta
		{
			get
			{
				return (new mz.erp.ui.controllers.tsa_CondicionesDeVentas( new string[] { "Descripcion","PorcentajeRecargo","Recargo","Importe"} ).GetCustomLayout() );
			}
		}

		private bool _solapaStockVisible = Variables.GetValueBool("Productos.Solapas.Stock.Visible");
		public bool SolapaStockVisible 
		{
			get {return _solapaStockVisible;}
		}

		private bool _solapaMedidasVisible = Variables.GetValueBool("Productos.Solapas.Medidas.Visible");
		public bool SolapaMedidasVisible
		{
			get {return _solapaMedidasVisible;}
		}
		private bool _solapaPreciosVisible = Variables.GetValueBool("Productos.Solapas.Precios.Visible");
		public bool SolapaPreciosVisible
		{
			get {return _solapaPreciosVisible;}
		}

		private bool _solapaPreciosMediosDePagoVisible = Variables.GetValueBool("Productos.Solapas.PreciosMediosDePagoVisible.Visible");		
		public bool SolapaPreciosMediosDePagoVisible
		{
			get {return _solapaPreciosMediosDePagoVisible;}
		}

		private bool _solapaAgrupamientosVisible = Variables.GetValueBool("Productos.Solapas.Agrupamientos.Visible");
		public bool SolapaAgrupamientosVisible 
		{
			get {return _solapaAgrupamientosVisible;}
		}

		private bool _solapaProductosAsociadosVisible = Variables.GetValueBool("Productos.Solapas.ProductosAsociados.Visible");
		public bool SolapaProductosAsociadosVisible 
		{
			get {return _solapaProductosAsociadosVisible;}
		}
		
		private string _etiquetaCampoAuxiliar1 = string.Empty;	
		public string EtiquetaCampoAuxiliar1
		{
			get{return this._etiquetaCampoAuxiliar1;}
		}

		private string _etiquetaCampoAuxiliar2 = string.Empty;	
		public string EtiquetaCampoAuxiliar2
		{
			get{return this._etiquetaCampoAuxiliar2;}
		}

		private string _etiquetaCampoAuxiliar3 = string.Empty;	
		public string EtiquetaCampoAuxiliar3
		{
			get{return this._etiquetaCampoAuxiliar3;}
		}

		private string _etiquetaCampoAuxiliar4 = string.Empty;	
		public string EtiquetaCampoAuxiliar4
		{
			get{return this._etiquetaCampoAuxiliar4;}
		}

		private string _etiquetaCampoAuxiliar5 = string.Empty;
		public string EtiquetaCampoAuxiliar5
		{
			get{return this._etiquetaCampoAuxiliar5;}
		}

		public bool ByJerarquia1
		{
			get{return _brClass.ByJerarquia1;}
			set{_brClass.ByJerarquia1 = value;}
		}

		public bool ByJerarquia2
		{
			get{return _brClass.ByJerarquia2;}
			set{_brClass.ByJerarquia2 = value;}
		}
		public bool ByJerarquia3
		{
			get{return _brClass.ByJerarquia3;}
			set{_brClass.ByJerarquia3 = value;}
		}
		public bool ByJerarquia4
		{
			get{return _brClass.ByJerarquia4;}
			set{_brClass.ByJerarquia4 = value;}
		}
		public bool ByJerarquia5
		{
			get{return _brClass.ByJerarquia5;}
			set{_brClass.ByJerarquia5 = value;}
		}
		public bool ByJerarquia6
		{
			get{return _brClass.ByJerarquia6;}
			set{_brClass.ByJerarquia6 = value;}
		}
		public bool ByJerarquia7
		{
			get{return _brClass.ByJerarquia7;}
			set{_brClass.ByJerarquia7 = value;}
		}
		public bool ByJerarquia8
		{
			get{return _brClass.ByJerarquia8;}
			set{_brClass.ByJerarquia8 = value;}
		}

		public ArrayList Jerarquia1
		{
			get{return _brClass.Jerarquia1;}
			set{_brClass.Jerarquia1 = value;}
		}
		public ArrayList Jerarquia2
		{
			get{return _brClass.Jerarquia2;}
			set{_brClass.Jerarquia2 = value;}
		}
		public ArrayList Jerarquia3
		{
			get{return _brClass.Jerarquia3;}
			set{_brClass.Jerarquia3 = value;}
		}
		public ArrayList Jerarquia4
		{
			get{return _brClass.Jerarquia4;}
			set{_brClass.Jerarquia4 = value;}
		}
		public ArrayList Jerarquia5
		{
			get{return _brClass.Jerarquia5;}
			set{_brClass.Jerarquia5 = value;}
		}
		public ArrayList Jerarquia6
		{
			get{return _brClass.Jerarquia6;}
			set{_brClass.Jerarquia6 = value;}
		}
		public ArrayList Jerarquia7
		{
			get{return _brClass.Jerarquia7;}
			set{_brClass.Jerarquia7 = value;}
		}
		public ArrayList Jerarquia8
		{
			get{return _brClass.Jerarquia8;}
			set{_brClass.Jerarquia8 = value;}
		}

		private bool _buscadorJerarquicoAllowMultipleSelect = Variables.GetValueBool("Productos.BuscadorJerarquico.AllowMultipleSelect");
		public bool BuscadorJerarquicoAllowMultipleSelect
		{
			get {return _buscadorJerarquicoAllowMultipleSelect; }
		}		

		public string Codigo
		{
			get { return _brClass.Codigo;}
			set { _brClass.Codigo = value;}
		}

		public string CodigoSecundario
		{
			get { return _brClass.CodigoSecundario;}
			set { _brClass.CodigoSecundario = value;}
		}

		public string Descripcion
		{
			get { return _brClass.Descripcion;}
			set { _brClass.Descripcion = value;}
		}

		public string DescripcionCorta
		{
			get { return _brClass.DescripcionCorta;}
			set { _brClass.DescripcionCorta = value;}
		}

		public string DescripcionLarga
		{
			get { return _brClass.DescripcionLarga;}
			set { _brClass.DescripcionLarga = value;}
		}

		public bool Activo
		{
			get{return _brClass.Activo;}
			set{_brClass.Activo = value;}
		}

		public bool ByActivo
		{
			get{return _brClass.ByActivo;}
			set{_brClass.ByActivo = value;}
		}

		public string IdTipoProducto
		{
			get { return _brClass.IdTipoProducto;}
			set { _brClass.IdTipoProducto = value;}
		}

		public string Observaciones
		{
			get { return _brClass.Observaciones;}
			set { _brClass.Observaciones = value;}
		}

		public string CampoAuxiliar1
		{
			get { return _brClass.CampoAuxiliar1;}
			set { _brClass.CampoAuxiliar1 = value;}
		}

		public string CampoAuxiliar2
		{
			get { return _brClass.CampoAuxiliar2;}
			set { _brClass.CampoAuxiliar2 = value;}
		}

		public string CampoAuxiliar3
		{
			get { return _brClass.CampoAuxiliar3;}
			set { _brClass.CampoAuxiliar3 = value;}
		}

		public string CampoAuxiliar4
		{
			get { return _brClass.CampoAuxiliar4;}
			set { _brClass.CampoAuxiliar4 = value;}
		}

		public string CampoAuxiliar5
		{
			get { return _brClass.CampoAuxiliar5;}
			set { _brClass.CampoAuxiliar5 = value;}
		}

		public string IdBonificacion
		{
			get { return _brClass.IdBonificacion;}
			set { _brClass.IdBonificacion = value;}
		}
		
		public bool ObligaCodigoBarra
		{
			get{return _brClass.ObligaCodigoBarra;}
			set{_brClass.ObligaCodigoBarra = value;}
		}

		public bool ByObligaCodigoBarra
		{
			get{return _brClass.ByObligaCodigoBarra;}
			set{_brClass.ByObligaCodigoBarra = value;}
		}

		public bool ObligaNumeroSerie
		{
			get{return _brClass.ObligaNumeroSerie;}
			set{_brClass.ObligaNumeroSerie = value;}
		}

		public bool ByObligaNumeroSerie
		{
			get{return _brClass.ByObligaNumeroSerie;}
			set{_brClass.ByObligaNumeroSerie = value;}
		}

		public bool PercibeIB
		{
			get{return _brClass.PercibeIB;}
			set{_brClass.PercibeIB = value;}
		}

		public bool ByPercibeIB
		{
			get{return _brClass.ByPercibeIB;}
			set{_brClass.ByPercibeIB = value;}
		}

		private DataTable _tiposProductos = null;
		public System.Data.DataTable TiposProductos
		{
			get {return _tiposProductos;}
		}

		public string KeyValueTiposProductos
		{
			get { return "IdTipoProducto" ; }
		}				
		public string KeyListTiposProductos
		{
			get { return "Descripcion" ; }
		}

		private DataTable _bonificaciones = null;
		public System.Data.DataTable Bonificaciones
		{
			get {return _bonificaciones;}
		}
		public string KeyValueBonificaciones
		{
			get { return "IdBonificacion" ; }
		}				
		public string KeyListBonificaciones
		{
			get { return "Descripcion" ; }
		}

		public string ResultDescripcion
		{
			get { return _resultDescripcion ; }
		}

		public string ResultObservaciones
		{
			get { return _resultObservaciones ; }
		}

		public string ResultCampoAuxiliar1
		{
			get { return _resultCampoAuxiliar1 ; }
		}

		public string ResultCampoAuxiliar2
		{
			get { return _resultCampoAuxiliar2 ; }
		}

		public string ResultCampoAuxiliar3
		{
			get { return _resultCampoAuxiliar3 ; }
		}
		
		public string ResultCampoAuxiliar4
		{
			get { return _resultCampoAuxiliar4 ; }
		}
		
		public string ResultCampoAuxiliar5
		{
			get { return _resultCampoAuxiliar5 ; }
		}

		public decimal ResultPrecioDeVentaBrutoMDRecargoCondicionDeVenta
		{
			get{return _resultPrecioDeVentaBrutoMDRecargoCondicionDeVenta;}
		}


		public decimal ResultPrecioDeVentaBrutoMORecargoCondicionDeVenta
		{
			get{return _resultPrecioDeVentaBrutoMORecargoCondicionDeVenta;}
		}

		public string EtiquetaResultPrecioNetoMO
		{
			get {return _etiquetaResultPrecioNetoMO; }
		}

		public string EtiquetaResultPrecioFinalMO
		{
			get {return _etiquetaResultPrecioFinalMO ; }
		}

		public string EtiquetaResultPrecioNetoMD
		{
			get { return _etiquetaResultPrecioNetoMD ;}
		}

		public string EtiquetaResultPrecioFinalMD
		{
			get { return _etiquetaResultPrecioFinalMD; }
		}

		public string IdProductoSeleccionado
		{
			get {return _idProductoSeleccionado;}
		}

		public string IdResponsable
		{
			get{return _brClass.IdResponsable;}
			set{_brClass.IdResponsable=value;}
		}
		public DateTime FechaAltaDesde
		{
			get{return _brClass.FechaAltaDesde;}
			set{_brClass.FechaAltaDesde=value;}
		}
		public DateTime FechaAltaHasta
		{
			get{return _brClass.FechaAltaHasta;}
			set{_brClass.FechaAltaHasta=value;}
		}
		public bool BuscarPorFechaAlta
		{
			get{return _brClass.BuscarPorFechaAlta;}
			set{_brClass.BuscarPorFechaAlta=value;}
		}
		public bool BuscarPorResponsable
		{
			get{return _brClass.BuscarPorResponsable;}
			set{_brClass.BuscarPorResponsable=value;}
		}
		#endregion

		#region Eventos
		public event EventHandler DetalleChanged;
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

		#region Métodos Privados
		private void Init() 
		{
			_solapasHabilitadas = Variables.GetValueStringDefault(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "Filtros.SolapasHabilitadas", "FiltroPrincipal,FiltroSecundario,FiltroJerarquico");
			_solapaActiva = Variables.GetValueStringDefault(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "Filtros.SolapaActiva", "FiltroPrincipal");
			_allowEditCodigo = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "AllowEditCodigo",true);
            _allowEditCodigoSecundario = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "AllowEditCodigoSecundario",true);
            _allowEditDescripcion = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "AllowEditDescripcion",true);
            _allowEditDescripcionCorta = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "AllowEditDescripcionCorta",true);
            _allowEditDescripcionLarga = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "AllowEditDescripcionLarga",true);
			_allowEditActivo = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "AllowEditActivo",true);
			_allowEditHabilitarActivo = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "AllowEditHabilitarActivo",true);
			_allowEditTipoProducto = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "AllowEditTipoProducto",true);
			_allowEditObservaciones = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "AllowEditObservaciones",true);
			_allowEditCampoAuxiliar1 = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "AllowEditCampoAuxiliar1",true);
			_allowEditCampoAuxiliar2 = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "AllowEditCampoAuxiliar2",true);
			_allowEditCampoAuxiliar3 = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "AllowEditCampoAuxiliar3",true);
			_allowEditCampoAuxiliar4 = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "AllowEditCampoAuxiliar4",true);
			_allowEditCampoAuxiliar5 = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "AllowEditCampoAuxiliar5",true);
			_allowEditObligaCodigoBarra = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "AllowEditObligaCodigoBarra",true);
			_allowEditHabilitarObligaCB = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "AllowEditHabilitarObligaCB",true);
			_allowEditObligaNumeroSerie = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "AllowEditObligaNumeroSerie",true);
			_allowEditHabilitarObligaNS = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "AllowEditHabilitarObligaNS",true);
			_allowEditPercibeIB = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "AllowEditPercibeIB",true);
			_allowEditHabilitarPercibeIB = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "AllowEditHabilitarPercibeIB",true);
			_allowEditBonificacion = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "AllowEditBonificacion",true);
			_allowEditFechaDesde = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "AllowEditFechaDesde",true);
			_allowEditFechaHasta = Variables.GetValueBool(_brClass.GetProcessManagerParent().Process.ProcessName, _brClass.GetTaskName(), "AllowEditFechaHasta",true);	
			InitEventHandlers();
			InitData();
		}	

		private void InitData()
		{
			SetLeyendaFormulario();
			SetEtiquetaCamposAuxiliares();
			SetCombosData();
		}

		
		private void InitEventHandlers()
		{
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

		private void SetEtiquetaCamposAuxiliares()
		{
			this._etiquetaCampoAuxiliar1 = Variables.GetValueString("Productos.CampoAuxiliar1.Etiqueta");
			if(_etiquetaCampoAuxiliar1.Equals(string.Empty)) _etiquetaCampoAuxiliar1 = "CampoAuxiliar1";
			this._etiquetaCampoAuxiliar2 = Variables.GetValueString("Productos.CampoAuxiliar2.Etiqueta");
			if(_etiquetaCampoAuxiliar2.Equals(string.Empty)) _etiquetaCampoAuxiliar2 = "CampoAuxiliar2";
			this._etiquetaCampoAuxiliar3 = Variables.GetValueString("Productos.CampoAuxiliar3.Etiqueta");
			if(_etiquetaCampoAuxiliar3.Equals(string.Empty)) _etiquetaCampoAuxiliar3 = "CampoAuxiliar3";
			this._etiquetaCampoAuxiliar4 = Variables.GetValueString("Productos.CampoAuxiliar4.Etiqueta");
			if(_etiquetaCampoAuxiliar4.Equals(string.Empty)) _etiquetaCampoAuxiliar4 = "CampoAuxiliar4";
			this._etiquetaCampoAuxiliar5 = Variables.GetValueString("Productos.CampoAuxiliar5.Etiqueta");
			if(_etiquetaCampoAuxiliar5.Equals(string.Empty)) _etiquetaCampoAuxiliar5 = "CampoAuxiliar5";
		}

		private void SetCombosData()
		{
			_tiposProductos = businessrules.tsy_TipoProducto.GetList().tsy_TipoProducto;
			DataRow rowTP = _tiposProductos.NewRow();					
			rowTP["IdTipoProducto"] = String.Empty;
			rowTP["Descripcion"] = String.Empty;
			rowTP["IdConexionCreacion"] = 1;
			rowTP["FechaCreacion"] = DateTime.Now;
			rowTP["IdEmpresa"] = 1;
            rowTP["AfectaStock"] = false;
			_tiposProductos.Rows.Add(rowTP);

			_bonificaciones = tsa_Bonificaciones.GetList(null,null,Constantes.TipoBonificacionProducto).tsa_Bonificaciones;
			DataRow rowB = _bonificaciones.NewRow();					
			rowB["IdBonificacion"] = String.Empty;
			rowB["Descripcion"] = String.Empty;
			rowB["IdTipoBonificacion"] = String.Empty;
			rowB["IdConexionCreacion"] = 1;
			rowB["FechaCreacion"] = DateTime.Now;
			rowB["IdEmpresa"] = 1;
			rowB["IdSucursal"] = 1;
			_bonificaciones.Rows.Add(rowB);

		}

		#endregion

		#region Métodos Públicos

		public void SearchNow()
		{
			_brClass.SearchNow();
		}

		public void VerDetalle( System.Data.DataRowView _dataRowSelected )
		{
			if (_dataRowSelected != null)
			{
				_idProductoSeleccionado = Convert.ToString(_dataRowSelected["IdProducto"]);
				_resultDescripcion = Convert.ToString(_dataRowSelected["Descripcion"]);
				_resultObservaciones = Convert.ToString(_dataRowSelected["Observaciones"]);
				_resultCampoAuxiliar1 = Convert.ToString(_dataRowSelected["CampoAuxiliar1"]);
				_resultCampoAuxiliar2 = Convert.ToString(_dataRowSelected["CampoAuxiliar2"]);
				_resultCampoAuxiliar3 = Convert.ToString(_dataRowSelected["CampoAuxiliar3"]);
				_resultCampoAuxiliar4 = Convert.ToString(_dataRowSelected["CampoAuxiliar4"]);
				_resultCampoAuxiliar5 = Convert.ToString(_dataRowSelected["CampoAuxiliar5"]);
                _resultPrecioFinalMO = Convert.ToDecimal( _dataRowSelected["PrecioFinalEstimado"] );
				_resultPrecioFinalImpuestosIncludos = Convert.ToDecimal ( _dataRowSelected["PrecioFinalEstimado"]	);
				_resultPrecioFinalMD = Convert.ToDecimal ( _dataRowSelected["PrecioFinalEstimadoMonedaDestino"] );
				_resultPrecioFinalMDRecargoCondicionDeVenta = Convert.ToDecimal ( _dataRowSelected["PrecioFinalEstimadoMonedaDestinoRecargoCondicionDeVenta"] );
				_resultPrecioFinalMORecargoCondicionDeVenta = Convert.ToDecimal ( _dataRowSelected["PrecioFinalEstimadoMonedaOrigenRecargoCondicionDeVenta"] );
				_resultPrecioDeVentaBrutoMDRecargoCondicionDeVenta = Convert.ToDecimal( _dataRowSelected["PrecioDeVentaBrutoMonedaDestinoRecargoCondicionDeVenta"] );
				_resultPrecioDeVentaBrutoMORecargoCondicionDeVenta = Convert.ToDecimal( _dataRowSelected["PrecioDeVentaBrutoMonedaOrigenRecargoCondicionDeVenta"] );
				_etiquetaResultPrecioFinalMO = Convert.ToString( _dataRowSelected["DescripcionMonedaOrigenPrecioDeVentaBruto"] );
				_etiquetaResultPrecioNetoMO = Convert.ToString( _dataRowSelected["DescripcionMonedaOrigenPrecioDeVentaBruto"] );
				_etiquetaResultPrecioFinalMD = Convert.ToString( _dataRowSelected["DescripcionMonedaDestino"] );
				_etiquetaResultPrecioNetoMD = Convert.ToString( _dataRowSelected["DescripcionMonedaDestino"] );				

				_fdp = mz.erp.businessrules.tfi_FormasDePagoEx.GetFormasDePago(_resultPrecioFinalMD, _listaFormasDePagos);
				if(_formasDePagosOrdenadasBD)
					_fdp.SortByOrden();
				_preciosPorCondicionDeVenta = mz.erp.businessrules.tsa_CondicionesDeVentas.RecargosPorCondicionesDeVenta( _resultPrecioFinalMD , _condicionesDeVentasOrdenadasBD);
				string ListaDeVisualizaciones = Variables.GetValueString("Productos.Solapas.Stock.ListaVisualizacionesDeStock");
				_stockDataset = mz.erp.businessrules.tlg_Stock.GetList(Convert.ToString(_dataRowSelected["IdProducto"]),ListaDeVisualizaciones);					
				this._thumb = tsh_ProductosAuxiliares.GetThumb(Convert.ToString(_dataRowSelected["IdProducto"]));

				if(DetalleChanged != null)
					DetalleChanged(this, new EventArgs());
				
			}
		}

		#endregion
	}
}

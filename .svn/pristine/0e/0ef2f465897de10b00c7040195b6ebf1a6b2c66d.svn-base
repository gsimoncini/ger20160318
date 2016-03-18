using System;
using System.Data;
using System.Collections;
using System.Text;
using mz.erp.businessrules;
using mz.erp.commontypes;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ConsultaEntregasController.
	/// </summary>
	public class ConsultaEntregasController : ITaskController
	{
		public ConsultaEntregasController(ConsultaEntregas brClass)
		{
			_brClass = brClass;	
			Init();
		}

		#region Metodos Privados

		private void Init()
		{
			_brClass.ObjectHasChanged +=new EventHandler(Refresh);
			_brClass.DataChanged +=new EventHandler(RefreshData);
			string Tarea = this._brClass.GetTaskName();
			string Proceso = this._brClass.GetProcessManagerParent().Process.ProcessName;						

			_visualizaBotonImprimir = Variables.GetValueBool(Proceso, Tarea, "HabilitaBotonImprimir", _visualizaBotonImprimir);
			_visualizaCheckBoxResumido = Variables.GetValueBool(Proceso, Tarea, "HabilitaCheckBoxResumido", _visualizaCheckBoxResumido);
			
			_visualizaDetalle = Variables.GetValueBool(Proceso, Tarea, "VisualizaDetalleComprobantes", _visualizaDetalle);
			_metodoVisualizacion = Variables.GetValueString(Proceso, Tarea,"MetodoVisualizacionDetalle");
			
		}


		private string GetLayoutProductos()
		{
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			string etiquetaCampoAuxiliar1 = Variables.GetValueString("Productos.CampoAuxiliar1.Etiqueta");
			string etiquetaCampoAuxiliar2 = Variables.GetValueString("Productos.CampoAuxiliar2.Etiqueta");
			string etiquetaCampoAuxiliar3 = Variables.GetValueString("Productos.CampoAuxiliar3.Etiqueta");
			string etiquetaCampoAuxiliar4 = Variables.GetValueString("Productos.CampoAuxiliar4.Etiqueta");
			string etiquetaCampoAuxiliar5 = Variables.GetValueString("Productos.CampoAuxiliar5.Etiqueta");
			
			bool HideCampoAux1 = etiquetaCampoAuxiliar1.Trim() == "" ? true : false;
			bool HideCampoAux2 = etiquetaCampoAuxiliar2.Trim() == "" ? true : false;
			bool HideCampoAux3 = etiquetaCampoAuxiliar3.Trim() == "" ? true : false;
			bool HideCampoAux4 = etiquetaCampoAuxiliar4.Trim() == "" ? true : false;
			bool HideCampoAux5 = etiquetaCampoAuxiliar5.Trim() == "" ? true : false;			

			sb.Append( LayoutBuilder.GetRow( i++, "IdProducto", "IdProducto",true) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdTipoProducto", "Tipo de Producto",true) );
			sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Codigo",50) );
			sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion",300) );			
			sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeVentaBruto", "Pcio bruto", 70, Types.Aligment.Far ) );
			sb.Append( LayoutBuilder.GetRow( i++, "DescripcionMonedaOrigenPrecioDeVentaBruto", "Moneda",true) );
			sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimadoMonedaDestino", "Pcio Imp", true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "DescripcionMonedaOrigenPrecioDeVentaBruto", "Moneda",true) );
			sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimado", "Pcio Imp", 70,Types.Aligment.Far ) );
			sb.Append( LayoutBuilder.GetRow( i++, "DescripcionMonedaOrigenPrecioDeVentaBruto", "Moneda",65) );
			sb.Append( LayoutBuilder.GetRow( i++, "SimboloMonedaOrigenPrecioDeVentaBruto", "Moneda",40) );
			sb.Append( LayoutBuilder.GetRow( i++, "StockDisponible", "Stock", 65,Types.Aligment.Far,Types.FormatDisplay.Integer ));
			sb.Append( LayoutBuilder.GetRow( i++, "DescripcionCorta", "Descripcion Corta",true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "DescripcionLarga", "Descripcion Larga", true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar1", etiquetaCampoAuxiliar1,65, HideCampoAux1) );
			sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar2", etiquetaCampoAuxiliar2,65, HideCampoAux2) );
			sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar3", etiquetaCampoAuxiliar3,65, HideCampoAux3) );
			sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar4", etiquetaCampoAuxiliar4,65, HideCampoAux4) );
			sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar5", etiquetaCampoAuxiliar5,65, HideCampoAux5) );
			sb.Append( LayoutBuilder.GetRow( i++, "StockMinimo", "StockMinimo",65, true) );
			sb.Append( LayoutBuilder.GetRow( i++, "StockAntesMinimo", "StockAntesMinimo",65, true) );
			
			

			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

		private void Refresh(object sender, EventArgs e)
		{
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
		}

		
		private void RefreshData(object sender, EventArgs e)
		{
			if(DataChanged != null)
				DataChanged(this, new EventArgs());
		}

		
		
		#endregion

		#region Propiedades

		public bool AllowMultipleSelect
		{
			get{return _brClass.AllowMultipleSelect;}
		}

		public bool AllowSearchByNumero 
		{
			get{return _brClass.AllowSearchByNumero;}
		}

		public string ListaFiltros 
		{
			get{return _brClass.ListaFiltros;}
		}

		public string ListaFiltrosSecundarios 
		{
			get{return _brClass.ListaFiltrosSecundarios;}
		}
		
		public bool FilterByNumero
		{
			get{return _brClass.FilterByNumero;}
			set{_brClass.FilterByNumero = value;}
		}

		public bool FilterByFecha
		{
			get{return _brClass.FilterByFecha;}
			set{_brClass.FilterByFecha = value;}
		}

		public bool FilterByFechaConv
		{
			get{return _brClass.FilterByFechaConv;}
			set{_brClass.FilterByFechaConv = value;}
		}

		public bool FilterByFechaVto
		{
			get{return _brClass.FilterByFechaVto;}
			set{_brClass.FilterByFechaVto = value;}
		}
		
		public bool AllowEdit
		{
			get{return _allowEdit;}
		}


		public bool AllowFilters
		{
			get{return _allowFilters;}
		}

		public bool AllowTotalRow
		{
			get{return _allowTotalRow;}
		}

		public ArrayList Groups
		{
			get{return _groups;}
		}
		
		public bool AllowGroups
		{
			get
			{
				return _allowGroup ;
			}
		}

		public ArrayList FieldsGroupTotal
		{
			get
			{
				return _fieldsGroupTotal;
			}
		}
		/*public bool ByFechas
		{
			get{return _brClass.ByFechas;}
			set{_brClass.ByFechas = value;}
		}*/

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

		public bool ByJerarquia9
		{
			get{return _brClass.ByJerarquia9;}
			set{_brClass.ByJerarquia9 = value;}
		}

		public bool ByJerarquia10
		{
			get{return _brClass.ByJerarquia10;}
			set{_brClass.ByJerarquia10 = value;}
		}


		public bool ByJerarquia11
		{
			get{return _brClass.ByJerarquia11;}
			set{_brClass.ByJerarquia11 = value;}
		}


		public bool ByJerarquia12
		{
			get{return _brClass.ByJerarquia12;}
			set{_brClass.ByJerarquia12 = value;}
		}


		public bool ByJerarquia13
		{
			get{return _brClass.ByJerarquia13;}
			set{_brClass.ByJerarquia13 = value;}
		}


		public bool ByJerarquia14
		{
			get{return _brClass.ByJerarquia14;}
			set{_brClass.ByJerarquia14 = value;}
		}


		public bool ByJerarquia15
		{
			get{return _brClass.ByJerarquia15;}
			set{_brClass.ByJerarquia15 = value;}
		}

		public bool ByJerarquia16
		{
			get{return _brClass.ByJerarquia16;}
			set{_brClass.ByJerarquia16 = value;}
		}

		/*public bool Resumido
		{
			get{return _brClass.Resumido;}
			set{_brClass.Resumido = value;}
		}*/

		public ArrayList Jerarquias1
		{
			get{return _brClass.Jerarquias1;}
			set{_brClass.Jerarquias1 = value;}
		}

		public ArrayList Jerarquias2
		{
			get{return _brClass.Jerarquias2;}
			set{_brClass.Jerarquias2 = value;}
		}
		public ArrayList Jerarquias3
		{
			get{return _brClass.Jerarquias3;}
			set{_brClass.Jerarquias3 = value;}
		}

		public ArrayList Jerarquias4
		{
			get{return _brClass.Jerarquias4;}
			set{_brClass.Jerarquias4 = value;}
		}

		public ArrayList Jerarquias5
		{
			get{return _brClass.Jerarquias5;}
			set{_brClass.Jerarquias5 = value;}
		}

		public ArrayList Jerarquias6
		{
			get{return _brClass.Jerarquias6;}
			set{_brClass.Jerarquias6 = value;}
		}

		public ArrayList Jerarquias7
		{
			get{return _brClass.Jerarquias7;}
			set{_brClass.Jerarquias7 = value;}
		}

		public ArrayList Jerarquias8
		{
			get{return _brClass.Jerarquias8;}
			set{_brClass.Jerarquias8 = value;}
		}	

		public ArrayList Jerarquias9
		{
			get{return _brClass.Jerarquias9;}
			set{_brClass.Jerarquias9 = value;}
		}

		public ArrayList Jerarquias10
		{
			get{return _brClass.Jerarquias10;}
			set{_brClass.Jerarquias10 = value;}
		}

		public ArrayList Jerarquias11
		{
			get{return _brClass.Jerarquias11;}
			set{_brClass.Jerarquias11 = value;}
		}

		public ArrayList Jerarquias12
		{
			get{return _brClass.Jerarquias12;}
			set{_brClass.Jerarquias12 = value;}
		}

		public ArrayList Jerarquias13
		{
			get{return _brClass.Jerarquias13;}
			set{_brClass.Jerarquias13 = value;}
		}

		public ArrayList Jerarquias14
		{
			get{return _brClass.Jerarquias14;}
			set{_brClass.Jerarquias14 = value;}
		}

		public ArrayList Jerarquias15
		{
			get{return _brClass.Jerarquias15;}
			set{_brClass.Jerarquias15 = value;}
		}

		public ArrayList Jerarquias16
		{
			get{return _brClass.Jerarquias16;}
			set{_brClass.Jerarquias16 = value;}
		}
	
		public string CodigoCuenta
		{			
			get { return _brClass.CodigoCuenta ; }
			set { _brClass.CodigoCuenta = value; }
		}

		public string ResponsableEmision
		{			
			get { return _brClass.ResponsableEmision ; }
			set { _brClass.ResponsableEmision = value; }
		}		

		public string FamiliaComprobantes
		{			
			get { return _brClass.FamiliaComprobantes ; }
			set { _brClass.FamiliaComprobantes = value; }
		}		
		
		public string TodosLosComprobantes 
		{
			get 
			{
				return Constantes.TodosLosComprobantes;
			}
		}

		public string FamiliaDefault 
		{
			get {return _brClass.FamiliaDefault;}
		}

		public string ListaFamiliaDeComprobantesEntregas
		{			
			get { return _brClass.ListaFamiliaDeComprobantesEntregas ; }			
		}	


		public System.Data.DataTable Result
		{
			get { return _brClass.Result; }
		}

		private bool _visualizaBotonImprimir = false;
		public bool VisualizaBotonImprimir
		{
			get 
			{				
				return _visualizaBotonImprimir;
			}
		}
		private bool _visualizaCheckBoxResumido = false;
		public bool VisualizaCheckBoxResumido
		{
			get 
			{
				return _visualizaCheckBoxResumido;
			}
		}
		
		public string LeyendaFormulario
		{
			get { return _brClass.LeyendaFormulario ; }
		}
		public bool PreguntarAlCancelar
		{
			get
			{
				return _brClass.PreguntarAlCancelar;
			}
		}
		public string TextoBotonSiguiente
		{
			get 
			{
				return _brClass.TextoBotonSiguiente;
			}
		}

		public string TextoBotonAnterior
		{
			get 
			{
				return _brClass.TextoBotonAnterior;
			}
		}		

		public string Codigo
		{
			get
			{
				return _brClass.CodigoProducto;
			}
			set
			{
				_brClass.CodigoProducto = value;
			}
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

		public DateTime FechaConvDesde
		{
			get{return _brClass.FechaConvDesde;}
			set{_brClass.FechaConvDesde = value;}
		}

		public DateTime FechaConvHasta
		{
			get{return _brClass.FechaConvHasta;}
			set{_brClass.FechaConvHasta = value;}
		}

		public DateTime FechaVtoDesde
		{
			get{return _brClass.FechaVtoDesde;}
			set{_brClass.FechaVtoDesde = value;}
		}

		public DateTime FechaVtoHasta
		{
			get{return _brClass.FechaVtoHasta;}
			set{_brClass.FechaVtoHasta = value;}
		}
		
		public string NumeroDesde
		{
			get{return _brClass.NumeroDesde;}
			set{_brClass.NumeroDesde = value;}
		}

		public string NumeroHasta
		{
			get{return _brClass.NumeroHasta;}
			set{_brClass.NumeroHasta = value;}
		}


		public DateTime FechaDesdeDefault
		{
			get{return _brClass.FechaDesdeDefault;}			
		}

		public DateTime FechaHastaDefault
		{
			get{return _brClass.FechaHastaDefault;}			
		}

		public bool AllowGeneralSearch 
		{
			get{return _brClass.AllowGeneralSearch;}
		}

		public string LayoutProductos
		{
			get{return _layoutProductos;}
		}

		
		public Type SearchProducto
		{
			get{return typeof(mz.erp.ui.controllers.tsh_Productos);}
		}
		
		public string Observaciones
		{
			get
			{
				return _brClass.Observaciones;
			}
			set
			{
				_brClass.Observaciones = value;
			}
		}

		public string CampoAuxiliar1
		{
			get
			{
				return _brClass.CampoAuxiliar1;
			}
			set
			{
				_brClass.CampoAuxiliar1 = value;
			}
		}

		public string CampoAuxiliar2
		{
			get
			{
				return _brClass.CampoAuxiliar2;
			}
			set
			{
				_brClass.CampoAuxiliar2 = value;
			}
		}

		public string CampoAuxiliar3
		{
			get
			{
				return _brClass.CampoAuxiliar3;
			}
			set
			{
				_brClass.CampoAuxiliar3 = value;
			}
		}

		public string CampoAuxiliar4
		{
			get
			{
				return _brClass.CampoAuxiliar4;
			}
			set
			{
				_brClass.CampoAuxiliar4 = value;
			}
		}

		public string CampoAuxiliar5
		{
			get
			{
				return _brClass.CampoAuxiliar5;
			}
			set
			{
				_brClass.CampoAuxiliar5 = value;
			}
		}

		private string _etiquetaCampoAuxiliar1 = Variables.GetValueString("Momentos.ConsultarDetalleComprobantesEntregas.ProcesoConsultarDetalleComprobantesEntregas.CampoAuxiliar1.Etiqueta");	
		public string EtiquetaCampoAuxiliar1
		{
			get
			{
				return this._etiquetaCampoAuxiliar1;
			}
		}
				
		private string _etiquetaCampoAuxiliar2 = Variables.GetValueString("Momentos.ConsultarDetalleComprobantesEntregas.ProcesoConsultarDetalleComprobantesEntregas.CampoAuxiliar2.Etiqueta");		
		public string EtiquetaCampoAuxiliar2
		{
			get
			{
				return this._etiquetaCampoAuxiliar2;
			}
		}

		private string _etiquetaCampoAuxiliar3 = Variables.GetValueString("Momentos.ConsultarDetalleComprobantesEntregas.ProcesoConsultarDetalleComprobantesEntregas.CampoAuxiliar3.Etiqueta");		
		public string EtiquetaCampoAuxiliar3
		{
			get
			{
				return this._etiquetaCampoAuxiliar3;
			}
		}

		private string _etiquetaCampoAuxiliar4 = Variables.GetValueString("Momentos.ConsultarDetalleComprobantesEntregas.ProcesoConsultarDetalleComprobantesEntregas.CampoAuxiliar4.Etiqueta");	
		public string EtiquetaCampoAuxiliar4
		{
			get
			{
				return this._etiquetaCampoAuxiliar4;
			}
		}

		private string _etiquetaCampoAuxiliar5 = Variables.GetValueString("Momentos.ConsultarDetalleComprobantesEntregas.ProcesoConsultarDetalleComprobantesEntregas.CampoAuxiliar5.Etiqueta");	
		public string EtiquetaCampoAuxiliar5
		{
			get
			{
				return this._etiquetaCampoAuxiliar5;
			}
		}

		public bool Pendientes 
		{
			get{return _brClass.Pendientes;}
			set{_brClass.Pendientes = value;}
		}


		public bool VisualizaDetalle
		{
			get{return _visualizaDetalle;}
		}
		
		public string MetodoVisualizacion
		{
			get{return _metodoVisualizacion;}
		}

		#endregion

		#region Eventos
		
		public event EventHandler ObjectHasChanged;
		public event EventHandler DataChanged;
		public event EventHandler CodigoCuentaChanged;		
		public event EventHandler ResponsableEmisionChanged;		
		public event EventHandler FamiliaComprobantesChanged;
		
		#endregion

		#region Variables Privadas
							
		private bool _visualizaDetalle = false;
		private string _metodoVisualizacion = string.Empty;
		private ConsultaEntregas _brClass;
		private string _layoutProductos = string.Empty;
		bool _allowGroup = false;
		private ArrayList _fieldsGroupTotal = new ArrayList();
		private ArrayList _groups = new ArrayList();
		private bool _allowTotalRow = false;
		private bool _allowFilters = false;
		private bool _allowEdit = false;
				
		#endregion

		#region Miembros de ITaskController

		public  bool IsFlushedState()
		{
			return this._processManager.ProcessFlushed;
		}

		public  bool IsNextState()
		{
			return this._processManager.IsNextState();	
		}

		public  bool IsBackState()
		{	
			return this._processManager.IsBackState();
		}
		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}

		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_brClass.GetTaskName());
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
		public void Continue()
		{
			_brClass.Execute();
		}

		public ItemsDatasetErrors GetErrors()
		{
			
			return _brClass.GetErrors();				
		}

		public string GetWarnings()
		{
			return _brClass.GetWarnings();
		}

		public void Execute() 
		{													
			this._brClass.Execute();
		}


		public bool AllowShow()
		{
			return _brClass.AllowShow();
		}

		public ITask GetTask()
		{
			return (ITask)this._brClass;
		}

		#endregion

		#region Metodos Publicos

		public ReportFilterArray GetFiltro() 
		{
			switch (this._brClass.GetTaskName())
			{
				
				default:
					return new ReportFilterArray();;
			}
			return new ReportFilterArray();;
			
		}

		public void RefreshData()
		{
			_brClass.RefreshData();
			if(DataChanged != null)
				DataChanged(this, new EventArgs());
		}
        //Cristian Tsrea 0000050 20110310
        //Cristian Tarea 0000146 20110725
        public void updateFechas(DateTime fechaDesde, bool ordenInverso)
        {
            _brClass.updateFechas(fechaDesde, ordenInverso);

        }
        //fin Cristian Tarea 0000146
        //Fin Cristian	
		public void ResetFechas()
		{
			_brClass.ResetFechas();
		}
		
		public string GetLayout() 
		{
			switch (this._brClass.GetTaskName())
			{
				case "ConsultaSeguimientos":
					return GetLayoutConsultaSeguimientos();
					break;
				case "ConsultarProductosNumerosDeSerie":
					return GetLayoutConsultaProductosNumerosDeSerie();
					break;
				case "ConsultarComprasListaDePrecios":
					return GetLayoutConsultarComprasListaDePrecios();
					break;
				case "ValorizarStock":
					return GetLayoutValorizarStock();
					break;
				case "ConsultarRentabilidadProductos":
					return GetLayoutConsultarRentabilidadProductos();
					break;
				default:
					return null;
			}
			return null;
		}

		private string GetLayoutConsultarRentabilidadProductos()
		{
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );	
			sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Cod.", 50 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion", 350 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Linea", "Linea",150));
			sb.Append( LayoutBuilder.GetRow( i++, "Cantidad", "Cant.", 50 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "TotalPrecioDeCosto", "Tot P.Costo", 75 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "TotalPrecioDeVenta", "Tot P.Venta", 75 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Rentabilidad", "Rent.", 75 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "StockDisponible", "Stock Disp.", 75 ) );
			sb.Append( LayoutBuilder.GetFooter() );
			return sb.ToString();	
		

		}

		private string GetLayoutConsultaSeguimientos()
		{
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );			
			sb.Append( LayoutBuilder.GetRow( i++, "Cantidad", "Cant.", 50, Types.Aligment.Far, Types.FormatDisplay.Integer));
			sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha", 140, Types.Aligment.Near, Types.FormatDisplay.DateTime));
			if(((_brClass.ByJerarquia1 || _brClass.ByJerarquia2 ||_brClass.ByJerarquia3 ||_brClass.ByJerarquia4 ||_brClass.ByJerarquia5) && _brClass.CodigoProducto.Equals(string.Empty)))
				sb.Append( LayoutBuilder.GetRow( i++, "Producto", "Item", 200 ) );
			else sb.Append( LayoutBuilder.GetRow( i++, "Producto", "Item", true) );
			sb.Append( LayoutBuilder.GetRow( i++, "Movimiento", "Movimiento", 190 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdTipoDeComprobante", "Comp.", 75 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Numero", 100 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Cuenta", 250 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Progresion", "Prog.", 35, Types.Aligment.Far, Types.FormatDisplay.Integer));
			sb.Append( LayoutBuilder.GetRow( i++, "Responsable", "Responsable", 75 ) );			
			//sb.Append( LayoutBuilder.GetRow( i++, "Imprimir", "Imprimir",75,Types.ColumnTypes.CheckBox,Types.EditType.CheckBox) );
			sb.Append( LayoutBuilder.GetFooter() );
			return sb.ToString();					
		}

		private string GetLayoutConsultaProductosNumerosDeSerie()
		{
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );			
			sb.Append( LayoutBuilder.GetRow( i++, "Producto", "Producto", 400 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "NumeroDeSerie", "Nro de Serie", 150));
			sb.Append( LayoutBuilder.GetRow( i++, "Deposito", "Deposito", 200 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Seccion", "Seccion", 200 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "EstadoDeStock", "Est. de Stock", 200 ) );
			sb.Append( LayoutBuilder.GetFooter() );
			return sb.ToString();					
		}

		private string GetLayoutValorizarStock()
		{
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );			
			sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Codigo", 50) );
			sb.Append( LayoutBuilder.GetRow( i++, "Producto", "Producto", 200) );
			sb.Append( LayoutBuilder.GetRow( i++, "Cantidad", "cant.",75));
			sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeCostoMonedaVisualizacion", "P. Costo", 75 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "TotalMonedaVisualizacion", "Total", 75 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "EstadoDeStock", "Est. de Stock", 200 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Deposito", "Deposito", 200 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Seccion", "Seccion", 200 ) );
			
			sb.Append( LayoutBuilder.GetFooter() );
			return sb.ToString();					
		}

		private string GetLayoutConsultarComprasListaDePrecios()
		{
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );	
			sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Cod.", 50 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Producto", "Producto", 250 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeCostoDirecto", "P. Costo Dir.",75));
			sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeCostoIndirecto", "P. Costo Indir.", 75 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeCostoRef", "P. de Costo", 75 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "MAC", "MAC %", 50 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeVentaNeto", "P. Venta Neto(Sug)", 75 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "MaxDescuento", "Desc", 75 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "MaxDescuentoPorcentual", "Desc %", 75 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeVentaBruto", "P.Lista", 75 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimado", "P. Lista c/Imp", 75 ) );
			sb.Append( LayoutBuilder.GetFooter() );
			return sb.ToString();	
		}

		#endregion

	}
}

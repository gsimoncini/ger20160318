using System;
using System.Data;
using System.Collections;
using System.Text;
using mz.erp.businessrules;
using mz.erp.commontypes;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ConsultaComprasController.
	/// </summary>
	public class ConsultaComprasController : IObserver,ITaskController
	{
		public ConsultaComprasController(ConsultaCompras brClass)
		{
			_brClass = brClass;	
			Init();
		}

		#region Metodos Privados
		
		



		private void Init()
		{
			//_brClass.ObjectHasChanged +=new EventHandler(Refresh);
			this._brClass.ObjectHasChanged += new EventHandler(this.ListenerObjectHasChanged);
			this._brClass.DataChanged += new EventHandler(this.ListenerRefreshData);
			//_brClass.DataChanged +=new EventHandler(RefreshData);
			string Tarea = this._brClass.GetTaskName();
			string Proceso = this._brClass.GetProcessManagerParent().Process.ProcessName;						


			/*


			
			_layoutProductos = this.GetLayoutProductos();
			_allowGroup = Variables.GetValueBool(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(),"PermiteAgrupar");				
			_fieldsGroupTotal = mz.erp.systemframework.Util.Parse(Variables.GetValueString(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(),"ListaGruposTotalizados"),",");
			_groups = mz.erp.systemframework.Util.Parse(Variables.GetValueString(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(),"ListaGruposDefault"),",");
			_allowTotalRow = Variables.GetValueBool(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(),"PermiteTotalizarGrupos");				
			_allowFilters = Variables.GetValueBool(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(),"PermiteFiltros");	
			_allowEdit  = Variables.GetValueBool(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(),"PermiteEditar");	

			*/

			_visualizaBotonImprimir = Variables.GetValueBool(Proceso, Tarea, "HabilitaBotonImprimir", _visualizaBotonImprimir);
			_visualizaCheckBoxResumido = Variables.GetValueBool(Proceso, Tarea, "HabilitaCheckBoxResumido", _visualizaCheckBoxResumido);
			_visualizaJerarquias = Variables.GetValueBool(Proceso, Tarea, "HabilitaJerarquias", _visualizaJerarquias);
			_habilitaFiltroProducto = Variables.GetValueBool(Proceso, Tarea, "HabilitaFiltroProducto", _habilitaFiltroProducto);
			_habilitaFiltroProveedor = Variables.GetValueBool(Proceso, Tarea, "HabilitaFiltroProveedor", _habilitaFiltroProveedor);
			_visualizaOtrosFiltros = Variables.GetValueBool(Proceso, Tarea, "HabilitaOtrosFiltro", _visualizaOtrosFiltros);
			_enabledButtonCuentaCtaCte = Variables.GetValueBool(Proceso, Tarea, "Proveedor.HabilitaBotonCtaCte", _enabledButtonCuentaCtaCte);
            
			_visualizaFiltroProducto = Variables.GetValueBool(Proceso, Tarea, "VisualizaFiltroProducto", _visualizaFiltroProducto);
			_visualizaFiltroProveedor = Variables.GetValueBool(Proceso, Tarea, "VisualizaFiltroProveedor", _visualizaFiltroProveedor);

            /* Silvina 20100630 - Tarea 669 */
            _visualizaJerarquiasClientes = Variables.GetValueBool(Proceso, Tarea, "HabilitaJerarquiasClientes", _visualizaJerarquiasClientes);
            /* Fin Silvina */

            //Matias 20100717 - Tarea 88
            this.SoloActivos = Variables.GetValueBool(Proceso, Tarea, "SoloActivos.Valor", this.SoloActivos);
            _soloActivosHabilitado = Variables.GetValueBool(Proceso, Tarea, "SoloActivos.Habilitado", _soloActivosHabilitado);
            _soloActivosVisible = Variables.GetValueBool(Proceso, Tarea, "SoloActivos.Visible", _soloActivosVisible);
            //Fin Matias 20100717 - Tarea 88
            //Cristian Tarea 0000010 20110223
		    _listaDeposito = _brClass.ListaDeposito;
		    _listaSeccion = _brClass.ListaSeccion;
		    _idSeccion = _brClass.IdSeccion;
		    _idDeposito = _brClass.IdDeposito;
            //Fin Cristian
		}	

		private void ListenerRefreshData( object sender, EventArgs e)
		{
			if(DataChanged != null)
				DataChanged(this, new EventArgs());
		}

		private void ListenerObjectHasChanged( object sender, EventArgs e )
		{
			if (this.ObjectHasChanged != null)
			{
				ObjectHasChanged( this, new System.EventArgs() );
			}
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


		/*
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
		*/
		
		#endregion

		#region Propiedades

		public string ContenedoresVisibles
		{
			get{return _brClass.ContenedoresVisibles;}
		}
		
		public ArrayList SelectedEstadosDeStock
		{
			set{ _brClass.SelectedEstadosDeStock = value;}
		}


		public ArrayList SelectedVisualizacionesDeStock
		{
			set{_brClass.SelectedVisualizacionesDeStock = value;}
		}



		public bool HabilitaFiltroFechas
		{
			get{return _brClass.HabilitaFiltroFechas;}
		}

		public bool PermiteModificarFechaHasta
		{
			get{return _brClass.PermiteModificarFechaHasta;}
		}

		public ArrayList EstadosDeStock
		{
			get{return _brClass.EstadosDeStock ;}
		}


		public ArrayList VisualizacionesDeStock
		{
			get{return _brClass.VisualizacionesDeStock;}
		}

		public bool ByEstadoDeStock
		{
			set{_brClass.ByEstadoDeStock = value;}
			
		}

		public bool VisualizaOtrosFiltros
		{
			get{return _visualizaOtrosFiltros;}
		}

		public bool HabilitaFiltroStock
		{
			get{return _brClass.HabilitaFiltroStock;}
		}

		public bool VisualizaFiltroProducto
		{
			get{return _visualizaFiltroProducto;}
		}

		public bool VisualizaFiltroProveedor
		{
			get{return _visualizaFiltroProveedor;}
		}

		public bool VisualizaJerarquias
		{
			get{return _visualizaJerarquias;}
		}

        /* Silvina 20100630 - Tarea 669 */
        public bool VisualizaJerarquiasClientes
        {
            get { return _visualizaJerarquiasClientes; }
        }

		public bool HabilitaFiltroProducto
		{
			get{return _habilitaFiltroProducto;}
		}

		public bool HabilitaFiltroProveedor
		{
			get{return _habilitaFiltroProveedor;}
		}
		
		private bool _enabledButtonCuentaCtaCte = true;
		public bool EnabledButtonCuentaCtaCte
		{
			get 
			{
				return  _enabledButtonCuentaCtaCte;
			}				
		}

		public DateTime FechaSeleccionada
		{
			set{_brClass.FechaSeleccionada = value;}
		}

		public bool AllowMultipleSelect
		{
			get{return _brClass.AllowMultipleSelect;}
		}

		public bool AllowShowBuscarFechasAlmacenadas
		{
			get{ return  _brClass.AllowShowBuscarFechasAlmacenadas;}
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
		public bool ByFechas
		{
			get{return _brClass.ByFechas;}
			set{_brClass.ByFechas = value;}
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

		public bool Resumido
		{
			get{return _brClass.Resumido;}
			set{_brClass.Resumido = value;}
		}

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

        /* Silvina 20100630 - Tarea 669 */

        public bool ByJerarquiaCliente1
        {
            get { return _brClass.ByJerarquiaCliente1; }
            set { _brClass.ByJerarquiaCliente1 = value; }
        }

        public bool ByJerarquiaCliente2
        {
            get { return _brClass.ByJerarquiaCliente2; }
            set { _brClass.ByJerarquiaCliente2 = value; }
        }

        public bool ByJerarquiaCliente3
        {
            get { return _brClass.ByJerarquiaCliente3; }
            set { _brClass.ByJerarquiaCliente3 = value; }
        }

        public bool ByJerarquiaCliente4
        {
            get { return _brClass.ByJerarquiaCliente4; }
            set { _brClass.ByJerarquiaCliente4 = value; }
        }

        public bool ByJerarquiaCliente5
        {
            get { return _brClass.ByJerarquiaCliente5; }
            set { _brClass.ByJerarquiaCliente5 = value; }
        }

        public bool ByJerarquiaCliente6
        {
            get { return _brClass.ByJerarquiaCliente6; }
            set { _brClass.ByJerarquiaCliente6 = value; }
        }

        public bool ByJerarquiaCliente7
        {
            get { return _brClass.ByJerarquiaCliente7; }
            set { _brClass.ByJerarquiaCliente7 = value; }
        }

        public bool ByJerarquiaCliente8
        {
            get { return _brClass.ByJerarquiaCliente8; }
            set { _brClass.ByJerarquiaCliente8 = value; }
        }

        public ArrayList JerarquiasCliente1
        {
            get { return _brClass.JerarquiasCliente1; }
            set { _brClass.JerarquiasCliente1 = value; }
        }

        public ArrayList JerarquiasCliente2
        {
            get { return _brClass.JerarquiasCliente2; }
            set { _brClass.JerarquiasCliente2 = value; }
        }
        public ArrayList JerarquiasCliente3
        {
            get { return _brClass.JerarquiasCliente3; }
            set { _brClass.JerarquiasCliente3 = value; }
        }

        public ArrayList JerarquiasCliente4
        {
            get { return _brClass.JerarquiasCliente4; }
            set { _brClass.JerarquiasCliente4 = value; }
        }

        public ArrayList JerarquiasCliente5
        {
            get { return _brClass.JerarquiasCliente5; }
            set { _brClass.JerarquiasCliente5 = value; }
        }

        public ArrayList JerarquiasCliente6
        {
            get { return _brClass.JerarquiasCliente6; }
            set { _brClass.JerarquiasCliente6 = value; }
        }

        public ArrayList JerarquiasCliente7
        {
            get { return _brClass.JerarquiasCliente7; }
            set { _brClass.JerarquiasCliente7 = value; }
        }

        public ArrayList JerarquiasCliente8
        {
            get { return _brClass.JerarquiasCliente8; }
            set { _brClass.JerarquiasCliente8 = value; }
        }

        /* Fin Silvina */

        /* Silvina 20100909 - Tarea 669 */
        public bool ByFechasDefault
        {
            get { return _brClass.ByFechasDefault; }
            set { _brClass.ByFechasDefault = value; }
        }
        /* Fin Silvina */
		
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
				return _brClass.Codigo;
			}
			set
			{
				_brClass.Codigo = value;
			}
		}

		/*public string IdProveedor
		{
			get{return _brClass.IdProveedor;}
			set{_brClass.IdProveedor = value;}
		}*/

		public string CodigoProveedor
		{
			get{return _brClass.CodigoProveedor;}
			set{_brClass.CodigoProveedor = value;}
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

		public string LayoutProductos
		{
			get{return _layoutProductos;}
		}

		
		public Type SearchProducto
		{
			get{return typeof(mz.erp.ui.controllers.tsh_Productos);}
		}
		
		public Type ProveedoresSearchObject 
		{
			get{return typeof(mz.erp.ui.controllers.tpu_Proveedores);}
		}

        //Matias 20100717 - Tarea 88
        public bool SoloActivos
        {
            get { return _brClass.SoloActivos; }
            set { _brClass.SoloActivos = value; }
        }
        public bool SoloActivosHabilitado
        {
            get { return _soloActivosHabilitado; }
        }
        public bool SoloActivosVisible
        {
            get { return _soloActivosVisible; }
        }
        //Fin Matias 20100717 - Tarea 88
        //Cristian Tarea 0000010 20110222
        public ArrayList FiltroStock
        {
            get { return _filtroStock; }
            set { _brClass.FiltroStock = value; }
        }

        public string IdDeposito
        {
            get { return _brClass.IdDeposito; }
            set { _brClass.IdDeposito = value; }
        }

        public string IdSeccion
        {
            get { return _brClass.IdSeccion; }
            set { _brClass.IdSeccion = value; }
        }
        public DataTable ListaDeposito
        {
            get { return _listaDeposito; }
            set { _listaDeposito = value; }
        }

        public DataTable ListaSeccion
        {
            get { return _listaSeccion; }
            set { _listaSeccion = value; }
        }	
        //Fin Cristian
		#endregion

		#region Eventos
		
		public event EventHandler ObjectHasChanged;
		public event EventHandler DataChanged;
		public event EventHandler ByFechasChanged;
		public event EventHandler ResumidoChanged;		
		public event EventHandler OnModelChanged;
		
		#endregion
	
		#region Variables Privadas
							
		private ConsultaCompras _brClass;
		private string _layoutProductos = string.Empty;
		bool _allowGroup = false;
		private ArrayList _fieldsGroupTotal = new ArrayList();
		private ArrayList _groups = new ArrayList();
		private bool _allowTotalRow = false;
		private bool _allowFilters = false;
		private bool _allowEdit = false;
		private bool _visualizaJerarquias = true;
		private bool _habilitaFiltroProducto = true;
		private bool _visualizaOtrosFiltros = false;

		private bool _habilitaFiltroProveedor = false;
		
		private bool _visualizaFiltroProducto = true;				
		private bool _visualizaFiltroProveedor = true;

        /* Silvina 20100630 - Tarea 669 */
        private bool _visualizaJerarquiasClientes = false;

        //Matias 20100717 - Tarea 88
        // Por default (si NO fueron definidas las variables), busca TODOS los productos (Activos e Inactivos).
        private bool _soloActivosHabilitado = false;
        private bool _soloActivosVisible = false;
        //Fin Matias 20100717 - Tarea 88
        //Cristian Tarea 0000010 20110222
        private ArrayList _filtroStock = new ArrayList();
        private DataTable _listaDeposito = null;
        private DataTable _listaSeccion = null;
        private string _idDeposito = string.Empty;
        private string _idSeccion = string.Empty;
        //Fin Cristian
		#endregion

		#region Miembros de IObserver

		public void UpdateObject(object sender, object valores)
		{			
			if ((valores.GetType()) == typeof(System.Collections.ArrayList))
			{				
				ArrayList lista = (ArrayList)valores;	
				if (lista.Count == 0) this.Codigo = "00000000";
				else 
				{
					foreach ( mz.erp.businessrules.comprobantes.Item item in lista )
					{					
						this.Codigo = item.Codigo;	
					}
					if (OnModelChanged != null) OnModelChanged(this, new System.EventArgs());
				}
			}
		}

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

        //Cristian Tarea 0000010 20110223
        public void FiltroListaSecciones()
        {
            _listaSeccion = (DataTable)businessrules.tlg_Secciones.GetList(this.IdDeposito, true).tlg_Secciones;
            this.IdSeccion = _listaSeccion.Rows[0]["IdSeccion"].ToString();
        }

        //Fin Cristian
		public ArrayList GetDetalleVisualizacionDeStock(object selectedValue)
		{
			ArrayList result = new ArrayList();
			VisualizacionDeStockView vsv = (VisualizacionDeStockView)selectedValue;
			foreach(DetalleVisualizacionDeStockView dvsv in _brClass.VisualizacionesDeStockDet)
			{
				if(dvsv.IdVisualizacionDeStock.Equals(vsv.IdVisualizacionDeStock))
					result.Add(dvsv);
			}
			return result;
		}


		public ArrayList GetFechasAlmacenadas()
		{
			return _brClass.GetFechasAlmacenadas();
		}

		public bool FechasValidas()
		{
			if(_brClass.MustValidarFechas)
				return _brClass.ValidarFechas();
			return true;
		}

		public bool RangoDeFechasValido()
		{
			return _brClass.RangoDeFechasValido();
		}

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
        //Cristian Tarea 0000146 20110721
        public void updateFechas(DateTime fechaDesde, bool ordenInverso)
        {
            this._brClass.updateFechas(fechaDesde, ordenInverso);
            
        }
        //Fin Cristian Tarea 0000146
        //Fin Cristian
		
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
			if(((_brClass.ByJerarquia1 || _brClass.ByJerarquia2 ||_brClass.ByJerarquia3 ||_brClass.ByJerarquia4 ||_brClass.ByJerarquia5) && _brClass.Codigo.Equals(string.Empty)))
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

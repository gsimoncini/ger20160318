using System;
using mz.erp.businessrules;
using System.Data;
using System.Collections;
using System.Text;

using mz.erp.commontypes;



namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de StockNDiasController.
	/// </summary>
	public class StockNDiasController : IObserver, ITaskController
	{
		
		#region Constructores

		public StockNDiasController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public StockNDiasController(StockNDias brClass)
		{
			_brClass = brClass;
			Init();
		}

		private void Init()
		{
			this._layoutFiltroResultado = this.GetLayoutResultado();
			this._brClass.ObjectHasChanged += new System.EventHandler( this.ListenerObjectHasChanged );
			_allowEdit  = Variables.GetValueBool(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(),"PermiteEditar");	
			_allowGroup = Variables.GetValueBool(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(),"PermiteAgrupar");				
			_fieldsGroupTotal = mz.erp.systemframework.Util.Parse(Variables.GetValueString(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(),"ListaGruposTotalizados"),",");
			_groups = mz.erp.systemframework.Util.Parse(Variables.GetValueString(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(),"ListaGruposDefault"),",");
			_allowTotalRow = Variables.GetValueBool(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(),"PermiteTotalizarGrupos");				
			_allowFilters = Variables.GetValueBool(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(),"PermiteFiltros");	
    		_enabledButtonCuentaCtaCte = Variables.GetValueBool(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(), "Proveedor.HabilitaBotonCtaCte", _enabledButtonCuentaCtaCte);

			
		}

		private void ListenerObjectHasChanged( object sender, System.EventArgs e )
		{
			if (this.ObjectHasChanged != null)
			{
				ObjectHasChanged( this, new System.EventArgs() );
			}
		}

		private string GetLayoutResultado( )
		{
			int i = 0;
			
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			sb.Append( LayoutBuilder.GetRow( i++, "IdProducto", "IdProducto", true) );
			sb.Append( LayoutBuilder.GetRow( i++, "Linea", "Linea", true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Codigo", 50 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Proveedor", "Proveedor", 80 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Producto", 300 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "StockActual", "Stock Actual", 75, Types.Aligment.Far, Types.FormatDisplay.Integer ) );
			sb.Append( LayoutBuilder.GetRow( i++, "CantidadPorVentas", "Cant. Ventas", 75, Types.Aligment.Far, Types.FormatDisplay.Integer ) );
			sb.Append( LayoutBuilder.GetRow( i++, "CantidadSugerida", "Stock Sugerido", 100, Types.Aligment.Far, Types.FormatDisplay.Integer ) );
			sb.Append( LayoutBuilder.GetRow( i++, "CantidadAComprar", "Cant. A Comprar", 100,Types.Aligment.Far, Types.FormatDisplay.Integer  ) );
			sb.Append( LayoutBuilder.GetRow( i++, "MontoMonedaVisualizacion","P. Costo", 80 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "TotalMonedaVisualizacion","Monto a Comprar", 80 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "MonedaVisualizacion","Moneda", 80 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "MontoMonedaReferencia","P. Costo", 80 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "TotalMonedaReferencia","Monto a Comprar", 80 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "MonedaReferencia","Moneda", 80 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeCosto","P. Costo", 80 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "TotalMonedaProducto","Monto a Comprar", 80 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "MonedaProducto","Moneda", 80 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "CantidadPorDevoluciones", "Cant. NC", 75, Types.Aligment.Far, Types.FormatDisplay.Integer ) );
			sb.Append( LayoutBuilder.GetRow( i++, "CantidadPorST", "Cant. ST", 75, Types.Aligment.Far, Types.FormatDisplay.Integer ) );
			sb.Append( LayoutBuilder.GetRow( i++, "CantidadPorDevolucionesST", "Cant. NC ST", 75, Types.Aligment.Far, Types.FormatDisplay.Integer ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Media", "Media", 50, Types.Aligment.Far)  );
			sb.Append( LayoutBuilder.GetRow( i++, "MaximaVenta", "Max Venta", 50, Types.Aligment.Far)  );
			
			
			//sb.Append( LayoutBuilder.GetRow( i++, "Cierre","F.Cierre Caja", 80 ) );

			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}


		#endregion

		#region Variables Privadas
	
			private StockNDias _brClass;
			private string _layoutFiltroResultado = string.Empty;
			private bool _byHierarchy = false;
			private bool _allowEdit = false;
			bool _allowGroup = false;
			private ArrayList _fieldsGroupTotal = new ArrayList();
			private ArrayList _groups = new ArrayList();
			private bool _allowTotalRow = false;
			private bool _allowFilters = false;
			
			public event EventHandler OnModelChanged;

	
		#endregion

		#region Variables Publicas

			public event System.EventHandler ObjectHasChanged;
			public event System.EventHandler DataDetailHierarchyChanged;
			public event EventHandler ByJerarquia1Changed;
			public event EventHandler ByJerarquia2Changed;

		#endregion

		#region Propiedades

		private bool _enabledButtonCuentaCtaCte = true;
		public bool EnabledButtonCuentaCtaCte
		{
			get 
			{
				return  _enabledButtonCuentaCtaCte;
			}				
		}

		public bool AllowMultipleSelect
		{
			get{return _brClass.AllowMultipleSelect;}
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

		public bool AllowEdit
		{
			get{return _allowEdit;}
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

		public bool ByHierarchy
		{
			set{ _brClass.ByHierarchy = value;}
		}

		public Type SearchProveedor
		{
			get{return typeof(mz.erp.ui.controllers.tpu_Proveedores);}
		}

		public Type SearchProducto
		{
			get{return typeof(mz.erp.ui.controllers.tsh_Productos);}
		}			
		public string LayoutFiltroResultado
		{
			get { return _layoutFiltroResultado; }
		}


		public string IdProducto
		{
			get{return _brClass.IdProducto;}
			set{_brClass.IdProducto = value;}
		}

		public string Codigo
		{
			get{return _brClass.Codigo;}
			
			set
			{
				_brClass.Codigo = value;
			}
		}

		public ArrayList IdJerarquia1
		{
			get{return _brClass.IdJerarquia1;}
			set{_brClass.IdJerarquia1 = value;}
		}

		public ArrayList IdJerarquia2
		{
			get{return _brClass.IdJerarquia2;}
			set{_brClass.IdJerarquia2 = value;}
		}

		public ArrayList IdJerarquia3
		{
			get{return _brClass.IdJerarquia3;}
			set{_brClass.IdJerarquia3 = value;}
		}

		public ArrayList IdJerarquia4
		{
			get{return _brClass.IdJerarquia4;}
			set{_brClass.IdJerarquia4 = value;}
		}
		public ArrayList IdJerarquia5
		{
			get{return _brClass.IdJerarquia5;}
			set{_brClass.IdJerarquia5 = value;}
		}

		public ArrayList IdJerarquia6
		{
			get{return _brClass.IdJerarquia6;}
			set{_brClass.IdJerarquia6 = value;}
		}

	
		public ArrayList IdJerarquia7
		{
			get{return _brClass.IdJerarquia7;}
			set{_brClass.IdJerarquia7 = value;}
		}

		public ArrayList IdJerarquia8
		{
			get{return _brClass.IdJerarquia8;}
			set{_brClass.IdJerarquia8 = value;}
		}

		public ArrayList Jerarquias
		{
			get{return _brClass.Jerarquias;}
		}


		/*public string IdProveedor
		{
			get{return _brClass.IdProveedor;}
			set{_brClass.IdProveedor = value;}
		}
*/
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

		public int Dias
		{
			get{return _brClass.Dias;}
			set{_brClass.Dias = value;}
		}

		public bool PrecioUltimaCompra
		{
			get{return _brClass.PrecioUltimaCompra;}
			set{_brClass.PrecioUltimaCompra = value;}
		}

		public bool PrecioUltimaCompraProveedor
		{
			get{return _brClass.PrecioUltimaCompraProveedor;}
			set{_brClass.PrecioUltimaCompraProveedor = value;}
		}

		public bool PrecioDeListaProveedor
		{
			get{return _brClass.PrecioDeListaProveedor;}
			set{_brClass.PrecioDeListaProveedor = value;}
		}


		#endregion

		#region Miembros de IObserver

		public void UpdateObject(object sender, object valores)
		{			
			if ((valores.GetType()) == typeof(System.Collections.ArrayList))
			{				
				ArrayList lista = (ArrayList)valores;				
				foreach ( mz.erp.businessrules.comprobantes.Item item in lista )
				{					
					//DataRow row = mz.erp.businessrules.tsh_ProductosSucursales.GetByPk(item.IdProducto, Security.IdSucursal, Security.IdEmpresa);
					//if(row != null)
					this.IdProducto = item.IdProducto;					
				}
				if (OnModelChanged != null) OnModelChanged(this, new System.EventArgs());
			}
		}

		#endregion

		#region Miembros de ITaskController

		private ProcessControllerManager _processManager;

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}



		public string GetWarnings()
		{
			
			return null;
		}

		public void Continue()
		{
			
		}

		public ItemsDatasetErrors GetErrors()
		{
			return _brClass.GetErrors();
		}

		public void Execute()
		{
			_brClass.Execute();
		}

		public bool AllowShow()
		{
			return _brClass.AllowShow();
		}

		public bool AllowPrevious()
		{
			return _brClass.AllowPrevious();
		}

		public void Previous()
		{
			_brClass.Previous();
		}

		public void SetProcessManager(ProcessControllerManager processManager)
		{
			_processManager = processManager;
		}

		public ProcessControllerManager GetProcessManager()
		{
			return _processManager;
		}

		public bool IsFirstTask()
		{
			return _processManager.IsFirstTask(_brClass.GetTaskName());
		}

		public bool IsNextState()
		{
			return _processManager.IsNextState();
		}

		public bool IsBackState()
		{
			return _processManager.IsBackState();
		}

		public bool IsFlushedState()
		{
			return false;

		}

		#endregion

		#region Metodos Publicos



        //Cristian Tsrea 0000050 20110310
        //Cristian Tarea 0000146 20110725
        public void updateFechas(DateTime fechaDesde, bool ordenInverso)
        {
            this._brClass.updateFechas(fechaDesde,ordenInverso);

        }
        //Fin Cristian Tarea 0000146
        //Fin Cristian

		public void RefreshData()
		{
			_brClass.RefreshData();
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
		}


		#endregion

		
		public System.Data.DataTable _dataHierarchy = new DataTable();
		public System.Data.DataTable DataTableResult
		{
			get { return _brClass.Result; }
		}

		public bool PreguntarAlCancelar
		{
			get {return _brClass.PreguntarAlCancelar;}
		}


		
	}
}

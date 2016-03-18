using System;
using mz.erp.businessrules;
using System.Data;
using System.Collections;
using System.Text;
using mz.erp.commontypes;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ConsultaMovimientosStockController.
	/// </summary>
	public class ConsultaMovimientosStockController: ITaskController, IObserver
	{
		public ConsultaMovimientosStockController(ConsultaMovimientosStock brClass)
		{
			_brClass = brClass;
			Init();
		}
		#region Constructores

		
			
		

		private void Init()
		{
			this._layoutFiltroResultado = this.GetLayoutResultado();
			this._brClass.ObjectHasChanged += new System.EventHandler( this.ListenerObjectHasChanged );
			_layoutProductos = this.GetLayoutProductos();
			
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

		private void ListenerObjectHasChanged( object sender, System.EventArgs e )
		{
			if (this.ObjectHasChanged != null)
			{
				ObjectHasChanged( this, new System.EventArgs() );
			}
		}

		private string GetLayoutResultado( )
		{
			return new mz.erp.ui.controllers.tlg_MovimientosDeStock().GetLayout();
		}


		#endregion

		#region Variables Privadas
	
		private ConsultaMovimientosStock _brClass;
		private string _layoutFiltroResultado = string.Empty;
		private bool _byHierarchy = false;
		private string _layoutProductos = string.Empty;

	
		#endregion

		#region Variables Publicas

		public event System.EventHandler ObjectHasChanged;
		public event System.EventHandler DataDetailHierarchyChanged;
		public event EventHandler ByJerarquia1Changed;
		public event EventHandler ByJerarquia2Changed;
		public event EventHandler ByFechasChanged;
		public event EventHandler CodigoChanged;
		public event EventHandler FechaDesdeChanged;
		public event EventHandler FechaHastaChanged;
		public event EventHandler OnModelChanged;

		#endregion
	

		#region Propiedades

		public string LayoutProductos
		{
			get{return _layoutProductos;}
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

		public bool ByFechas
		{
			get{return _brClass.ByFechas;}
			set{_brClass.ByFechas = value;}
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

		public string IdJerarquia1
		{
			get{return _brClass.IdJerarquia1;}
			set{_brClass.IdJerarquia1 = value;}
		}

		public string IdJerarquia2
		{
			get{return _brClass.IdJerarquia2;}
			set{_brClass.IdJerarquia2 = value;}
		}

		public string RaizJerarquia1
		{
			get{return _brClass.RaizJerarquia1;}
		}

		public string RaizJerarquia2
		{
			get{return _brClass.RaizJerarquia2;}
		}


		public string DescripcionRaizJerarquia1
		{
			get{return _brClass.DescripcionRaizJerarquia1;}
		}

		public string DescripcionRaizJerarquia2
		{
			get{return _brClass.DescripcionRaizJerarquia2;}
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
					this.Codigo = item.Codigo;
				}
				if (OnModelChanged != null) OnModelChanged(this, new System.EventArgs());
			}
		}

		#endregion

		#region Metodos Publicos
		
		public string LeyendaFormulario()
		{
			string _nombreProceso = this._brClass.GetProcessManagerParent().Process.ProcessName;
			string _nombreTarea = this._brClass.GetTaskName();
			string _leyenda = _leyenda = Variables.GetValueString("Momentos."+_nombreTarea +"."+_nombreProceso+".LeyendaFormulario");
			if (_leyenda =="" || _leyenda.Equals(string.Empty) || _leyenda == null)
				_leyenda = _nombreProceso + " " + _nombreTarea;
			return _leyenda;
			
		}

		public bool PreguntarAlCancelar()
		{
			bool _preguntarAlCancelar = Variables.GetValueBool(this._brClass.GetProcessManagerParent().Process.ProcessName,this._brClass.GetTaskName(),"PreguntarAlCancelar",false);
			return _preguntarAlCancelar ;
		}

		public void RefreshData()
		{
			_brClass.RefreshData();
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
		}


		#endregion

		public void NodoExpandir(Infragistics.Win.UltraWinTree.UltraTreeNode NodoPadre)
		{
			
			mz.erp.ui.controllers.tsh_JerarquiaAgrupProd.HijosYNietos( NodoPadre );
		}

		public void NodoActual(Infragistics.Win.UltraWinTree.UltraTreeNode Nodo, string NroJerarquia)
		{
			
			string _jerarquia = GetHierarchy( Nodo, string.Empty );
			switch (NroJerarquia )
			{
				case "1": IdJerarquia1 = _jerarquia;break;
				case "2":IdJerarquia2 = _jerarquia;break;
			}
		}
		
		private string GetHierarchy(Infragistics.Win.UltraWinTree.UltraTreeNode Nodo, string aux)
		{
			if(Nodo.IsRootLevelNode)
				return aux;
			else
				return GetHierarchy(Nodo.Parent, Nodo.Key + aux);

		}

		
		public string Key
		{
			set { _brClass.IdJerarquia1 = value ; }
			get { return _brClass.IdJerarquia1; }
		}

		public System.Data.DataTable _dataHierarchy = new DataTable();
		public System.Data.DataTable DataTableResult
		{
			get { return _brClass.Result; }
		}


	}
}

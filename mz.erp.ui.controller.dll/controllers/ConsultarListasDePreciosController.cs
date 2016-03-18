using System;
using mz.erp.businessrules;
using System.Collections;
using mz.erp.commontypes;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ConsultarListasDePreciosController.
	/// </summary>
	public class ConsultarListasDePreciosController: IObserver,ITaskController
	{

		#region Constructores
		public ConsultarListasDePreciosController(ConsultarListasDePrecios brClass)
		{
			_brClass = brClass;
			Init();
		}
		#endregion

		#region Variables Privadas

		private ConsultarListasDePrecios _brClass;
		private string _layoutProductos = string.Empty;
		
		#endregion

		#region Propiedades

		public string LeyendaFormulario
		{
			get 
			{
				return _brClass.LeyendaFormulario;
			}
		}

		public bool PreguntarAlCancelar
		{
			get {return _brClass.PreguntarAlCancelar;}
		}

		public string TextoBotonSiguiente
		{
			get { return _brClass.TextoBotonSiguiente ; }
		}
		
		public string TextoBotonAnterior
		{
			get { return _brClass.TextoBotonAnterior; }
		}


		public Type SearchProducto
		{
			get{return typeof(mz.erp.ui.controllers.tsh_Productos);}
		}


		public string LayoutProductos
		{
			get{return _layoutProductos;}
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

		public bool SoloProductosActivos
		{
			get
			{
				return _brClass.SoloProductosActivos;
			}
			set
			{
				_brClass.SoloProductosActivos = value;
			}
		}


		public bool AllowMultipleSelect
		{
			get{return _brClass.AllowMultipleSelect;}
		}


		public ArrayList ListasDePrecios
		{
			get 
			{
				return _brClass.ListasDePrecios;
			}
		}

		public ArrayList ListasDePreciosSeleccionadas
		{
			set 
			{
				_brClass.ListasDePreciosSeleccionadas = value;
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

		public System.Data.DataTable Result
		{
			get { return _brClass.Result; }
		}

		public bool MonedaListaDePreciosPesos
		{
			get
			{
				return _brClass.MonedaListaDePreciosPesos;
			}
			set
			{
				_brClass.MonedaListaDePreciosPesos = value;
			}
		}

		public bool MonedaListaDePreciosDolares
		{
			get
			{
				return _brClass.MonedaListaDePreciosDolares;
			}
			set
			{
				_brClass.MonedaListaDePreciosDolares = value;
			}
		}

		public bool AllowGridConfiguration
		{
			get{return _brClass.AllowGridConfiguration;}
		}

		#endregion

		#region Eventos y delegados		
		public event EventHandler DataChanged;
		public event EventHandler OnModelChanged;
		#endregion

		#region Métodos  Públicos 

		#endregion

		#region Métodos Privados
		private void Init() 
		{
			InitEventHandlers();
			InitData();
		}	

		private void InitData()
		{			
		}

		private void InitEventHandlers()
		{
			_brClass.DataChanged +=new EventHandler(RefreshData);
		}

		private void RefreshData(object sender, EventArgs e)
		{
			if(DataChanged != null)
				DataChanged(this, new EventArgs());
		}

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

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}


		public void Previous()
		{
			_brClass.Previous();
		}
		public void Continue()
		{
		}

		public ItemsDatasetErrors GetErrors()
		{
			return _brClass.GetErrors();				
		}

		public string GetWarnings()
		{
			return null;
		}

		public void RefreshData()
		{
			_brClass.RefreshData();
			if(DataChanged != null)
				DataChanged(this, new EventArgs());
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
	}
}

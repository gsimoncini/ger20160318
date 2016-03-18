using System;
using mz.erp.businessrules;
using System.Reflection;
using System.Collections;
using System.Data;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de AgrupCuentasController.
	/// </summary>
	public class AgrupamientosController : ITaskController
	{

		#region Constructores
		public AgrupamientosController(Agrupamientos agrup)
		{
			_model = agrup;
			Init();
			
		}

		public AgrupamientosController(string type)
		{
			if(type.ToUpper().Equals("CUENTAS"))
				_model = new AgrupamientosCuentas();
			else if(type.ToUpper().Equals("PROVEEDORES"))
				_model = new AgrupamientosProveedores();
			_model.ObjectHasChanged +=new EventHandler(_model_ObjectHasChanged);
			_model.Init();
			Init();
		}
		#endregion

		#region Variables Privadas
			
		private Agrupamientos _model;
		private string _layoutElementos = string.Empty;
		private string _layoutAgrupamientos = string.Empty;
		private Type _searchObjectClass;
		private Node _currentNode;
		private string _currentKey;
		private string _currentDescription;

			
		
		#endregion

		#region Propiedades

		public event EventHandler ModelHasChanged;
		public event EventHandler AgrupamientosHasChanged;
			
		public string LayoutElementos
		{
			get
			{
				return _layoutElementos;
			}
		}

		public string LayoutAgrupamientos
		{
			get
			{
				return _layoutAgrupamientos;

			}

		}

		public Type SearchObjectClass
		{
			get
			{
				return _searchObjectClass;
			}
		}

		public IList Elementos
		{
			get
			{
				return _model.Elementos;
			}
		}

		public string CurrentKey
		{
			set
			{
				_currentKey = value;
			}
		}

		public string CurrentDescription 
		{
			set
			{
				_currentDescription = value;
			}
		}



		#endregion

		#region Metodos Privados

		private void Init()
		{
			InitializeData();
			InitEventHandlers();		
		}

		private void InitializeData()
		{
			ArrayList fields = _model.FiledsLayout;
			Type uiType = Type.GetType(_model.UIClass);
			object instance = Activator.CreateInstance(uiType,fields.ToArray());
			MethodInfo method = uiType.GetMethod("GetLayout");
			_layoutElementos = Convert.ToString(method.Invoke(instance, null));
			Type uiTypeAgrupamientos = Type.GetType(_model.UIClassAgrupamientos);
			instance = Activator.CreateInstance(uiTypeAgrupamientos);
			method = uiTypeAgrupamientos.GetMethod("GetLayout");
			_layoutAgrupamientos = Convert.ToString(method.Invoke(instance, null));
			_searchObjectClass = uiType;


		}

		private void InitEventHandlers()
		{

		}


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
			return this._processManager.IsFirstTask(_model.GetTaskName());
		}

		public string GetTaskName()
		{
			return _model.GetTaskName();
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
			return _model.AllowPrevious();
		}

		public void Previous()
		{
			_model.Previous();
		}

		public bool IsValid()
		{
			return _model.IsValid();
		}
		
		public ItemsDatasetErrors GetErrors()
		{
			return _model.GetErrors();
		}
		public string GetWarnings()
		{
			return null;
		}
		public void Continue()
		{
		}

		public void Execute()
		{
			_model.Execute();
		}

		public bool AllowShow()
		{
			
			return _model.AllowShow();
		}

		#endregion


		#region Metodos Publicos


		
		public void UpdateTree(string key)
		{
			_currentNode = _model.getChildsNode(key);
		}

		public bool HasNext()
		{
			if(_currentNode != null)
				return _currentNode.HasNext();
			else return false;
		}

		public ArrayList Next()
		{
			Node node = _currentNode.Next();
			ArrayList result = new ArrayList();
			result.Add(node.Key);
			result.Add(node.Description);
			return result;
		}

		public void UpdateElementos(ArrayList rows)
		{
			this._model.UpdateElementos(rows);
		}

		public DataTable BuscarJerarquias(object SelectedItem)
		{
			return _model.SearchAgrupamientos(SelectedItem);
			
		}
	
		#endregion

		private void _model_ObjectHasChanged(object sender, EventArgs e)
		{
			if (ModelHasChanged != null)
					ModelHasChanged(this, new EventArgs());
		}

		public void Add()
		{
			if(_currentKey != null && !_currentKey.Equals(string.Empty))
				_model.Add(_currentKey);
		}

		public void BorrarAgrupamientos(string Jerarquia)
		{
			if(Jerarquia != null && !Jerarquia.Equals(string.Empty))
				_model.DeleteAgrupamientos(Jerarquia);
		}
        //Cristian Tarea 00084 20120109
        public void Agregar(string codigo)
        {
            _model.Agregar(codigo);
        }
	}
}

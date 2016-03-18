using System;
using System.Data;
using mz.erp.businessrules;
using System.Reflection;
using System.Collections;
using System.Text;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de TiposObservacionesCuentasController.
	/// </summary>
	public class TiposObservacionesCuentasController: ITaskController
	{

		#region Contructores
		public TiposObservacionesCuentasController()
		{			
		}

		public TiposObservacionesCuentasController(mz.erp.businessrules.TiposObservacionesCuentas brClass)
		{
			_brClass = brClass;
			_model = brClass;
			Init();
		}

		public TiposObservacionesCuentasController(mz.erp.businessrules.TiposObservacionesProveedores brClass)
		{
			_brClass = brClass;
			_model = brClass;
			Init();
		}
		#endregion

		#region Variables Privadas 
		private mz.erp.businessrules.ITiposObservaciones _brClass;
		private bool _allowShow = true;		
		private mz.erp.businessrules.ITiposObservaciones _model;
		private Node _currentNode;
		private string _currentKey;
		private string _currentDescription;
		private string _parentKey;
		private string _parentDescription;
		private bool _activo;		

		#endregion

		#region Variables Públicas

		#endregion

		#region Propiedades

		public string TextoBotonAnterior
		{
			get 
			{
				return _brClass.TextoBotonAnterior();
			}
		}
		public string TextoBotonSiguiente
		{
			get 
			{
				return _brClass.TextoBotonSiguiente();
			}
		}
		public string LeyendaFormulario
		{
			get 
			{
				return _brClass.LeyendaFormulario();
			}
		}
		public bool PreguntarAlCancelar
		{
			get
			{
				return _brClass.PreguntarAlCancelar();
			}
		}
		public string CurrentKey
		{
			get{return _currentKey;}
			set
			{
				_currentKey = value;
			}
		}

		public string CurrentDescription 
		{
			get{return _currentDescription;}
			set
			{
				_currentDescription = value;
			}
		}
		
		public string ParentKey
		{
			get{return _parentKey;}
			set
			{
				_parentKey = value;
			}
		}

		public string ParentDescription
		{
			get{return _parentDescription;}
			set
			{
				_parentDescription = value;
			}
		}

		public bool Activo 
		{
			get
            {
				return _activo;
		    }
			set
			{
				_activo = value;
			}
		}

		public System.Collections.ArrayList TiposObservacionesNuevas
		{
			get {return _brClass.TiposObservacionesNuevas();}
		}

		public System.Collections.ArrayList TiposObservacionesNuevasConfigVariables
		{
			get {return _brClass.TiposObservacionesNuevasConfigVariables();}
		}

		#endregion

		#region Eventos y delegados		
		public event System.EventHandler TiposObservacionesNuevasHasChanged;
		#endregion

		#region Métodos  Públicos

		public void AddMovimiento(string DescripcionTipo, string KeyTipo, string KeyTipoPadre, string DescripcionTipoPadre, bool Activo, string Modo)
		{
			_brClass.AddMovimiento(DescripcionTipo, KeyTipo, KeyTipoPadre, DescripcionTipoPadre, Activo, Modo);
		}

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


		public string GetLayout() 
		{			
			return (new mz.erp.ui.controllers.tsa_CuentasObservacionesTipos( new string[] {"KeyTipo", "DescripcionTipo", "KeyTipoPadre", "DescripcionTipoPadre", "Activo", "Modo"}).GetLayoutEx()); 
		}

		#endregion

		#region Métodos Privados
		
		private void Init()
		{
			InitializeData();
			InitEvents();
		}

		private void InitializeData()
		{
		}
		
		private void InitEvents()
		{
			this._brClass.TiposObservacionesNuevasHasChanged+=new EventHandler(_brClass_TiposObservacionesNuevasHasChanged);
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
			// TODO: agregar la implementación ConceptosAdicionalesController.GetErrors
			return _brClass.GetErrors();				
		}

		public string GetWarnings()
		{
			return null;
		}

		public void RefreshData()
		{
			
		}

		public void Execute() 
		{													
			this._brClass.Execute();
		}

		public bool AllowShow()
		{
			return _allowShow;
		}

		public ITask GetTask()
		{
			return (ITask)this._brClass;
		}
			
		#endregion

		private void _brClass_TiposObservacionesNuevasHasChanged(object sender, EventArgs e)
		{
			if(TiposObservacionesNuevasHasChanged != null)
				TiposObservacionesNuevasHasChanged(this, new EventArgs());	
		}

	}
}

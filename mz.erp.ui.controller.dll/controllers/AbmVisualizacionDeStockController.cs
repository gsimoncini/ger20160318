using System;
using System.Data;
using mz.erp.businessrules;
using System.Collections;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de VisualizacionDeStockController.
	/// </summary>
	public class AbmVisualizacionDeStockController: ITaskController
	{
		#region Contructores
		public AbmVisualizacionDeStockController(AbmVisualizacionDeStock brClass)
		{
			_brClass = brClass;
			_model = brClass;
			Init();
		}
		#endregion

		#region Variables Privadas 
		private AbmVisualizacionDeStock _brClass;
		private bool _allowShow = true;		
		private Node _currentNode;
		private AbmVisualizacionDeStock _model;
		private string _currentKey;
		private string _currentDescription;
		private string _parentKey;
		private string _parentDescription;
		private bool _activo;	
		private int _operacion;
		#endregion

		#region Variables Públicas
		#endregion
	
		#region Propiedades
		public string TextoBotonAnterior
		{
			get 
			{
				return _brClass.TextoBotonAnterior;
			}
		}
		public string TextoBotonSiguiente
		{
			get 
			{
				return _brClass.TextoBotonSiguiente;
			}
		}
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
		private DataTable _estadosDeStock = null;
		public System.Data.DataTable EstadosDeStock
		{
			get {return _estadosDeStock;}
		}

		public string KeyValueEstadosDeStock
		{
			get { return "IdEstadoDeStock" ; }
		}				
		public string KeyListEstadosDeStock
		{
			get { return "Descripcion" ; }
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

		public int Operacion 
		{
			get
			{
				return _operacion;
			}
			set
			{
				_operacion = value;
			}
		}

		public System.Collections.ArrayList VisualizacionesNuevas
		{
			get {return _brClass.VisualizacionesNuevas;}
		}

		public VisualizacionNueva VisualizacionModificada
		{
			get {return _brClass.VisualizacionModificada;}
		}

		public System.Collections.ArrayList VisualizacionesNuevasConfigVariables
		{
			get {return _brClass.VisualizacionesNuevasConfigVariables;}
		}

		Infragistics.Win.UltraWinTree.TreeNodesCollection _previousTree = null;
		public Infragistics.Win.UltraWinTree.TreeNodesCollection PreviousTree
		{
			get {return _previousTree;}
			set {_previousTree = value;}
		}

		#endregion
	
		#region Eventos y delegados 
		public event System.EventHandler VisualizacionesNuevasHasChanged;
		#endregion
	
		#region Métodos  Públicos 
		public string GetLayout() 
		{			
			return (new mz.erp.ui.controllers.tlg_VisualizacionDeStock( new string[] {"KeyVisualizacion", "NombreVisualizacion", "KeyEstado", "DescripcionEstado", "Operacion", "Activo", "Modo"}).GetLayoutEx()); 
		}

		public void UpdateTree(string key)
		{
			_currentNode = _model.getChildsNode(key);
		}

		public Node UpdateNode(string keyVisualizacion, string keyEstado)
		{
			return _model.getNode(keyVisualizacion, keyEstado);
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

		public void AddVisualizacion(string NombreVisualizacion, string KeyVisualizacion, string KeyEstado, string DescripcionEstado, string Operacion, bool Activo, string Modo)
		{
			_brClass.AddVisualizacion(NombreVisualizacion, KeyVisualizacion, KeyEstado, DescripcionEstado, Operacion, Activo, Modo);
		}

		#endregion
	
		#region Métodos Privados
		private void Init() 
		{
			InitEventHandlers();
			InitData();
		}	

		private void InitData()
		{
			SetCombosData();
		}
		private void SetCombosData()
		{
			_estadosDeStock = businessrules.tlg_EstadosDeStock.GetList().tlg_EstadosDeStock;

		}

		private void InitEventHandlers()
		{
			this._brClass.VisualizacionesNuevasHasChanged+=new EventHandler(_brClass_VisualizacionesNuevasHasChanged);
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

		private void _brClass_VisualizacionesNuevasHasChanged(object sender, EventArgs e)
		{
			if(VisualizacionesNuevasHasChanged != null)
				VisualizacionesNuevasHasChanged(this, new EventArgs());	
		}

	}
}

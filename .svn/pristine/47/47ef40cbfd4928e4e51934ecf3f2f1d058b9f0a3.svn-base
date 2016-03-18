using System;
using System.Data;
using mz.erp.businessrules;
using System.Reflection;
using System.Collections;
using System.Text;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de AbmMotivoOrdenReparacionController.
	/// </summary>
	public class AbmMotivoOrdenReparacionController: ITaskController
	{
		#region Contructores

		public AbmMotivoOrdenReparacionController()
		{
		}

		public AbmMotivoOrdenReparacionController(AbmMotivoOrdenReparacion brClass)
		{
			_brClass = brClass;
            _model = brClass;
			Init();
		}

		#endregion

		#region Variables Privadas 
		private AbmMotivoOrdenReparacion _brClass;
		private AbmMotivoOrdenReparacion _model;
		private bool _allowShow = true;		
		private Node _currentNode;
		private string _currentKey;
		private string _currentDescription;
		private string _parentKey;
		private string _parentDescription;
		private bool _esVerdadero;		
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
				return _brClass.PreguntarAlCancelar;
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

		public bool EsVerdadero 
		{
			get
			{
				return _esVerdadero;
			}
			set
			{
				_esVerdadero = value;
			}
		}

		public ArrayList MotivosOrdenReparacionNuevos
		{
			get {return _brClass.MotivosOrdenReparacionNuevos;}
		}


		#endregion

		#region Eventos y delegados		
		public event System.EventHandler MotivosOrdenReparacionNuevosHasChanged;
		#endregion

		#region Métodos  Públicos

		public void AddMotivo(string Descripcion, string KeyMotivo, string KeyMotivoPadre, string DescripcionMotivoPadre, bool EsMotivoVerdadero, string Modo)
		{
			_brClass.AddMotivo(Descripcion, KeyMotivo, KeyMotivoPadre, DescripcionMotivoPadre, EsMotivoVerdadero, Modo);
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
			return (new mz.erp.ui.controllers.tsy_MotivoOrdenReparacion( new string[] {"IdMotivo", "IdMotivoPadre", "DescripcionMotivo", "DescripcionMotivoPadre", "EsMotivoVerdadero", "Modo"}).GetLayoutEx()); 
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
			this._brClass.MotivosOrdenReparacionNuevosHasChanged+=new EventHandler(_brClass_MotivosOrdenReparacionNuevosHasChanged);
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

		private void _brClass_MotivosOrdenReparacionNuevosHasChanged(object sender, EventArgs e)
		{
			if(MotivosOrdenReparacionNuevosHasChanged != null)
				MotivosOrdenReparacionNuevosHasChanged(this, new EventArgs());	
		}


	}
}

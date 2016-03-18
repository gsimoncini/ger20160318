using System;
using System.Data;
using mz.erp.businessrules;
using System.Reflection;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de FiscalController.
	/// </summary>
	public class CambiarContraseñaController: ITaskController
	{
		#region Contructores
		private mz.erp.businessrules.CambiarContraseña _brClass;
		public CambiarContraseñaController()
		{			
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public CambiarContraseñaController(mz.erp.businessrules.CambiarContraseña brClass)
		{
			_brClass = brClass;
			Init();
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}


		private void Init()
		{
			InitializeData();
			InitEvents();
		}

		#endregion

		#region Variables Públicas

		public event EventHandler OnTaskAfterExecute;
			
		#endregion

		#region Variables Públicas Datos

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

		#endregion

		#region Variables Privadas
							
		
		private bool _isValid = true;
		private bool _allowShow = true;		
						
		#endregion

		#region Variables Privadas Datos
		public bool IsValid 
		{
			get {return _isValid;}
		}

		private string _claveAnterior = string.Empty;
		public string ClaveAnterior
		{
			get {return _brClass.ClaveAnterior;}
			set 
			{
				if (_claveAnterior!= value) 
				{
					_claveAnterior = value;
					_brClass.ClaveAnterior = value;
					if(ClaveAnteriorChanged != null)
						ClaveAnteriorChanged(this, new EventArgs());	
				}				
			}
		}

		private string _claveNueva1 = string.Empty;
		public string ClaveNueva1
		{
			get {return _brClass.ClaveNueva1;}
			set 
			{
				if (_claveNueva1!= value) 
				{
					_claveNueva1 = value;
					_brClass.ClaveNueva1 = value;
					if(ClaveNueva1Changed != null)
						ClaveNueva1Changed(this, new EventArgs());	
				}				
			}
		}

		private string _claveNueva2 = string.Empty;
		public string ClaveNueva2
		{
			get {return _brClass.ClaveNueva2;}
			set 
			{
				if (_claveNueva2!= value) 
				{
					_claveNueva2 = value;
					_brClass.ClaveNueva2 = value;
					if(ClaveNueva2Changed != null)
						ClaveNueva2Changed(this, new EventArgs());	
				}				
			}
		}

		#endregion

		#region Eventos y delegados
			
		public event EventHandler ClaveAnteriorChanged;		
		public event EventHandler ClaveNueva1Changed;		
		public event EventHandler ClaveNueva2Changed;
		public event EventHandler IdUsuarioChanged;
		#endregion
		
		#region Métodos  Públicos
		#endregion

		#region Métodos  Privados

		private void InitializeData()
		{
		}
		
		private void InitEvents()
		{
			this._brClass.OnTaskAfterExecute +=new EventHandler(_brClass_OnTaskAfterExecute);
			this._brClass.ObjectHasChanged+=new EventHandler(_brClass_ObjectHasChanged);			
		}


		private void Listener(object Sender, System.EventArgs e)
		{			
		}

		private void CallRefresh()
		{
			if (_claveAnterior != _brClass.ClaveAnterior) 
			{
				_claveAnterior = _brClass.ClaveAnterior;
				if (ClaveAnteriorChanged != null)
					ClaveAnteriorChanged(this, new EventArgs());
			}
			if (_claveNueva1 != _brClass.ClaveNueva1) 
			{
				_claveNueva1 = _brClass.ClaveNueva1;
				if (ClaveNueva1Changed != null)
					ClaveNueva1Changed(this, new EventArgs());
			}			
			if (_claveNueva2 != _brClass.ClaveNueva2) 
			{
				_claveNueva2 = _brClass.ClaveNueva2;
				if (ClaveNueva2Changed != null)
					ClaveNueva2Changed(this, new EventArgs());
			}			
			if (_idUsuario.CompareTo(_brClass.IdUsuario ) != 0)
			{
				_idUsuario = _brClass.IdUsuario;
				if (IdUsuarioChanged != null)
					IdUsuarioChanged(this, new EventArgs());
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

		private void _brClass_OnTaskAfterExecute(object sender, EventArgs e)
		{
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}

		private void _brClass_ObjectHasChanged(object sender, EventArgs e)
		{
			CallRefresh();
		}

		public bool EnabledSetPreviuosPassword
		{
			get { return _brClass.EnabledSetPreviousPassword; }
		}
		private string _idUsuario = string.Empty;
		public object IdUsuario
		{
			get { return _brClass.IdUsuario ; }
			set 
			{ 
				if (_brClass.IdUsuario.CompareTo( value ) != 0)
				{
					_idUsuario = Convert.ToString(value);
					_brClass.IdUsuario = Convert.ToString(value) ; 
					if (this.IdUsuarioChanged != null)
						IdUsuarioChanged (this, new EventArgs());
				}
			}

		}
		public System.Data.DataTable Usuarios
		{
			get { return _brClass.Usuarios ; }
		}
		public string KeyValueUsuarios
		{
			get { return "IdUsuario" ; }
		}
		public string KeyListUsuarios
		{
			get { return "Nombre" ; }
		}
	}
}

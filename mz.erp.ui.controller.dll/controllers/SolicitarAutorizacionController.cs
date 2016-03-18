using System;
using mz.erp.businessrules;
using System.Reflection;

namespace mz.erp.ui.controllers
{	
	/// <summary>
	/// Descripción breve de SolicitarAutorizacionController.
	/// </summary>
	/// businessrules.SolicitarAutorizacion autorizacion 
	public class SolicitarAutorizacionController: ITaskController
	{


		public SolicitarAutorizacionController(businessrules.SolicitarAutorizacion Autorizacion)
		{
			_brClass = Autorizacion;
			Init();
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}


		public SolicitarAutorizacionController()
		{
			_brClass = new SolicitarAutorizacion();
			Init();
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#region Contructores


		private void Init()
		{			
			InitializeData();
			InitEvents();
		}

		#endregion
		#region Variables Públicas

		public event EventHandler OnTaskAfterExecute;
		//public event EventHandler OnModelChanged;				
			
		#endregion

		#region Variables Públicas Datos

		private string _titulo = "Solicitando autorización";
		public string Titulo 
		{
			get {return _titulo;}
		}
		public string Datos
		{
			get {return _brClass.Datos;}
		}
		public string Motivo
		{
			get {return _brClass.Motivo;}
		}
		public string Observaciones
		{
			get {return _brClass.Observaciones;}
		}
		public bool Autorizado
		{
			get {return _brClass.Autorizado;}
		}

		public string Mensaje
		{
			get {return _brClass.Mensaje;}
		}


		#endregion
		#region Variables Privadas							
		
		private businessrules.SolicitarAutorizacion _brClass  = null;
 /*
		private string _mensaje = "";*/
		private bool _isValid = true;
		int _progreso = 0;
		int _progresoMin = 0;
		int _progresoMax = 0;
		/*private bool _allowShow = false;
						
		#endregion

		#region Variables Privadas Datos
/*		public string Mensaje 
		{
			get {return _mensaje;	}
		}*/
		public bool IsValid 
		{
			get {return _isValid;}
		}
		public int Progreso 
		{
			get 
			{
				return _progreso;
			}					
		}

		public int ProgresoMax
		{
			get 
			{
				return _progresoMax;
			}			
		}

		public int ProgresoMin
		{
			get 
			{
				return _progresoMin;
			}			
		}

		
		#endregion

		#region Eventos y delegados
		public event System.EventHandler OnShowForm;
		public event System.EventHandler OnCloseForm;
		public event System.EventHandler OnChangeTimer;
		#endregion
		
		#region Métodos  Públicos
		/*public void FormHasClosed() 
		{
			_brClass.FormHasClosed();
		}*/

		#endregion

		#region Métodos  Privados

		private void InitializeData()
		{
			_progresoMin = _brClass.ProgresoMin;
			_progresoMax = _brClass.ProgresoMax;
			//_allowShow = _cierre.AllowShow();
		}
		
		private void InitEvents()
		{			
			_brClass.OnTaskAfterExecute +=new EventHandler(_brClass_OnTaskAfterExecute);				
			_brClass.OnShowForm +=new EventHandler(_brClass_OnShowForm);
			//_brClass.OnCloseForm +=new EventHandler(_brClass_OnCloseForm);
			_brClass.OnChangeTimer +=new EventHandler(_brClass_OnChangeTimer);
			//this._cierre.ObjectHasChanged +=new EventHandler(_cierre_ObjectHasChanged);							
		}

		private void AfterTaskExecute(object sender , EventArgs e)
		{
		}

		private void _brClass_OnTaskAfterExecute(object sender, EventArgs e)
		{
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}


		private void _brClass_OnShowForm(object sender, EventArgs e)
		{
			if(OnShowForm != null)
				OnShowForm(this, new EventArgs());
		}

		private void _brClass_OnCloseForm(object sender, EventArgs e)
		{
			if(OnCloseForm != null)
				OnCloseForm(this, new EventArgs());
		}

		private void _brClass_OnChangeTimer(object sender, EventArgs e)
		{
			//Console.WriteLine(_brClass.Progreso);
			this._progreso = _brClass.Progreso;
			if(OnChangeTimer != null)
				OnChangeTimer(this, new EventArgs());
		}

/*		private void _cierre_ObjectHasChanged(object sender, EventArgs e)
		{
			System.Type tipo = sender.GetType();
			object objeto = tipo.InvokeMember( "Mensaje", System.Reflection.BindingFlags.GetProperty, null, sender, new object[] {} );			
						
			_mensaje = Convert.ToString(objeto);
			if(OnModelChanged != null)
				OnModelChanged(this, new EventArgs());
		}*/

		private void Listener(object Sender, System.EventArgs e)
		{			
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

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
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


		public ItemsDatasetErrors GetErrors()
		{
			// TODO: agregar la implementación ConceptosAdicionalesController.GetErrors
			return _brClass.GetErrors();			
		}
		public string GetWarnings()
		{
			// TODO: agregar la implementación ConceptosAdicionalesController.GetErrors
			return null;			
		}
		public void Continue()
		{
		}

		public void RefreshData()
		{
			Listener( this, new System.EventArgs());
		}

		public void Execute() 
		{	
			this._brClass.Execute();									
		}

		public bool AllowShow()
		{
			return _brClass.AllowShow();			
		}

		public void ComenzarSolicitud()  
		{
			_brClass.ComenzarSolicitud();
		}
			
		#endregion


	}
}

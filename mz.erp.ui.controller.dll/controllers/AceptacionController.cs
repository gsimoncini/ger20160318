using System;
using mz.erp.businessrules;
using System.Reflection;
using System.Collections;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de AceptacionController.
	/// </summary>
	public class AceptacionController: ITaskController
	{
		#region Constructores
		
		public AceptacionController( Aceptacion aceptacion)
		{	
			_model = aceptacion;
			Init();
		}
		
		#endregion

		#region Variables Privadas
			
		private Aceptacion _model;
		
		private string _usuario1 = string.Empty;
		private string _usuario2 = string.Empty;
		private string _clave1 = string.Empty;
		private string _clave2 = string.Empty;
		private string _comentario = string.Empty;
		private string _mensaje = string.Empty;

		#endregion

		#region Propiedades y eventos

		public event EventHandler OnTaskAfterExecute;
		public event EventHandler ModelHasChanged;
			
		public event EventHandler Clave1Changed;		
		public event EventHandler Clave2Changed;
		public event EventHandler Usuario1Changed;		
		public event EventHandler Usuario2Changed;
		public event EventHandler MensajeChanged;		
		public event EventHandler ComentarioChanged;
		
		public string Clave1
		{
			get {return _model.Clave1;}
			set 
			{
				if (_clave1!= value) 
				{
					_clave1 = value;
					_model.Clave1 = value;
					if(Clave1Changed != null)
						Clave1Changed(this, new EventArgs());	
				}				
			}
		}
		public string Clave2
		{
			get {return _model.Clave2;}
			set 
			{
				if (_clave2!= value) 
				{
					_clave2 = value;
					_model.Clave2 = value;
					if(Clave2Changed != null)
						Clave2Changed(this, new EventArgs());	
				}				
			}
		}

		public string Usuario1
		{
			get {return _model.Usuario1;}
			set 
			{
				if (_usuario1!= value) 
				{
					_usuario1 = value;
					_model.Usuario1= value;
					if(Usuario1Changed != null)
						Usuario1Changed(this, new EventArgs());	
				}				
			}
		}
		public string Usuario2
		{
			get {return _model.Usuario2;}
			set 
			{
				if (_usuario2!= value) 
				{
					_usuario2 = value;
					_model.Usuario2= value;
					if(Usuario2Changed != null)
						Usuario2Changed(this, new EventArgs());	
				}				
			}
		}

		public string Comentario
		{
			get {return _model.Comentario;}
			set 
			{
				if (_comentario!= value) 
				{
					_comentario= value;
					_model.Comentario= value;
					if(ComentarioChanged != null)
						ComentarioChanged(this, new EventArgs());	
				}				
			}
		}
		public string Mensaje
		{
			get {return _model.Mensaje;}
			set 
			{
				if (_mensaje!= value) 
				{
					_mensaje= value;
					_model.Mensaje= value;
					if(MensajeChanged != null)
						MensajeChanged(this, new EventArgs());	
				}				
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
		}

		private void InitEventHandlers()
		{

		}


		#endregion

		#region Miembros de ITaskController

		private ProcessControllerManager _processManager;

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

		private void _model_ObjectHasChanged(object sender, EventArgs e)
		{
			if (ModelHasChanged != null)
				ModelHasChanged(this, new EventArgs());
		}

		
		public event System.EventHandler OnControllerChanged;
		private void ListenerObjectHasChanged(object sender, System.EventArgs e)
		{
			if (this.OnControllerChanged != null)
				this.OnControllerChanged(this,new System.EventArgs() );
		}

		public bool PreguntarAlCancelar
		{
			get {return _model.PreguntarAlCancelar;}
		}
	}
}

using System;
using System.Data;
using mz.erp.businessrules;
using System.Reflection;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de FiscalController.
	/// </summary>
	public class AutorizarController: ITaskController
	{
		#region Contructores
		
		private Autorizar _autorizacion;
		public AutorizarController()
		{			
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public AutorizarController(Autorizar autorizacion)
		{
			_autorizacion = autorizacion;
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
		//public event EventHandler OnModelChanged;		
		//public event EventHandler OnCloseFiscal;

			
		#endregion
		#region Variables Públicas Datos
		private string _observaciones = String.Empty;
		public string Observaciones 
		{
			get 
			{
				return _observaciones;
			}
			set 
			{
				_observaciones = value;
			}
		}
		private bool _autorizado = false;
		public bool Autorizado
		{
			set 
			{
				_autorizado = value;
			}
		}
		
		public DataTable Solicitudes 
		{
			get 
			{
				return _autorizacion.Solicitudes;
			}
		}

		private string _idAutorizacion = String.Empty;
		public string IdAutorizacion 
		{
			set 
			{
				_idAutorizacion = value;
			}
		}
	
	#endregion
		#region Variables Privadas
							
		private bool _isValid = false;	
		private bool _allowShow = false;
		
	/*private bool _enabledBotonContinuar = false;
		private bool _allowEnabledBotonContinuar = false; //Creada para impedir que en cierres X, por ejemplo, el usuario pueda volver imprimir el comprobante mientras la impresora fiscal está imprimiendo.*/
								#endregion

		#region Variables Privadas Datos

		public bool IsValid 
		{
			get {return _autorizacion.IsValid();}
		}

	#endregion

		#region Eventos y delegados
	//public event EventHandler CodigoChanged;
			
		
		#endregion
		
		#region Métodos  Públicos
		public  void GetSolicitudes() 
		{
			_autorizacion.GetSolicitudes();		
		}

		public string GetDatos(string IdAutorizacion) 
		{
			return _autorizacion.GetDatos(IdAutorizacion);
		}
		public string GetObservaciones(string IdAutorizacion) 
		{
			return _autorizacion.GetObservaciones(IdAutorizacion);
		}
	#endregion

		#region Métodos  Privados

		private void InitializeData()
		{			
			_allowShow = _autorizacion.AllowShow();
		}
		
		private void InitEvents()
		{
			_autorizacion.OnTaskAfterExecute+=new EventHandler(_autorizacion_OnTaskAfterExecute);
		}

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
			return this._processManager.IsFirstTask(_autorizacion.GetTaskName());
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
			return _autorizacion.AllowPrevious();
		}

		public void Previous()
		{
			_autorizacion.Previous();
		}

		public string GetTaskName()
		{
			return _autorizacion.GetTaskName();
		}



	public ItemsDatasetErrors GetErrors()
	{
	// TODO: agregar la implementación ConceptosAdicionalesController.GetErrors
		return _autorizacion.GetErrors();	
	}
		public string GetWarnings()
		{
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
		this._autorizacion.Autorizado = this._autorizado;	
		this._autorizacion.Observaciones = this._observaciones;
		this._autorizacion.IdAutorizacion = this._idAutorizacion;
		this._autorizacion.Execute();
	}

	public bool AllowShow()
	{
		return _allowShow;
	}

	public ITask GetTask()
	{
		return (ITask)this._autorizacion;
	}
			
		#endregion

		private void _autorizacion_OnTaskAfterExecute(object sender, EventArgs e)
		{
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}
	}
}

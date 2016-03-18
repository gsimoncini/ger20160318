using System;
using mz.erp.businessrules;
using System.Reflection;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de FiscalController.
	/// </summary>
	public class FiscalController: ITaskController
	{
		#region Contructores
		private ITask _cierre;
		public FiscalController()
		{
			//_cierre = new Fisca
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public FiscalController(mz.erp.businessrules.FiscalComprobantes Cierre)
		{
			
			_cierre = (ITask) Cierre;
			_allowEnabledBotonContinuar = true;
			Init();
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public FiscalController(mz.erp.businessrules.FiscalCierre Cierre)
		{			
			_cierre = (ITask) Cierre;
			_allowEnabledBotonContinuar = false;
			Init();
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public FiscalController(mz.erp.businessrules.FiscalSincronizacion Cierre)
		{			
			_cierre = (ITask) Cierre;
			_allowEnabledBotonContinuar = false;
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
		public event EventHandler OnModelChanged;		
		public event EventHandler OnCloseFiscal;
			
		#endregion

		#region Variables Públicas Datos
		
		#endregion
		#region Variables Privadas
							
		private bool _cierreAutomatico = false;
		private string _mensaje = "";
		//private bool _isValid = false;
		//private bool _allowShow = false;
		//private bool _enabledBotonContinuar = false;
		private bool _allowEnabledBotonContinuar = false; //Creada para impedir que en cierres X, por ejemplo, el usuario pueda volver imprimir el comprobante mientras la impresora fiscal está imprimiendo.
						
		#endregion

		#region Variables Privadas Datos
		public string Mensaje 
		{
			get {return _mensaje;	}
		}
		public bool IsValid 
		{
			get 
			{
				return _cierre.IsValid();
				/*if (!result) 
				{
					if(OnModelChanged != null)
						OnModelChanged(this, new EventArgs());
				}*/				
			}
		}
		public bool CierreAutomatico
		{			
			get 
			{
				Type tipo =  _cierre.GetType();
				return Convert.ToBoolean(tipo.GetProperty("CierreAutomatico").GetValue(_cierre, null));
			}
		}
		public bool EnabledBotonContinuar
		{
			//get {return _enabledBotonContinuar;}
			get 
			{
				if (_allowEnabledBotonContinuar) 
				{
					return !_cierre.IsValid();
				}
				else 
				{
					return false;
				}
			}
		}
        //Matias - 20110902 - Tarea 0000131
        public bool EFacturaHabilitada
        {
            //get { return Variables.GetValueBool("Comprobantes.eFactura.Habilitada", false); }
            get
            {
                Type tipo = _cierre.GetType();
                return Convert.ToBoolean(tipo.GetProperty("EFacturaHabilitada").GetValue(_cierre, null));
            }
        }
        public bool EFacturaGenerar
        {
            get 
            {
                Type tipo = _cierre.GetType();
                return Convert.ToBoolean(tipo.GetProperty("EFacturaGenerar").GetValue(_cierre, null));
            }
            set 
            {
                Type tipo = _cierre.GetType();
                tipo.GetProperty("EFacturaGenerar").SetValue(_cierre, value, null);
            }
        }
        //FinMatias - 20110902 - Tarea 0000131
		#endregion

		#region Eventos y delegados

		#endregion
		
		#region Métodos  Públicos
		#endregion

		#region Métodos  Privados

		private void InitializeData()
		{
			//_allowShow = _cierre.AllowShow();
		}
		
		private void InitEvents()
		{
			this._cierre.OnTaskAfterExecute += new EventHandler(this.AfterTaskExecute);
			this._cierre.ObjectHasChanged +=new EventHandler(_cierre_ObjectHasChanged);
		}

		private void AfterTaskExecute(object sender , EventArgs e)
		{
			/*
			System.Type tipo = sender.GetType();
			_isValid = Convert.ToBoolean( tipo.GetMethod("IsValid").Invoke(sender, null));			
			*/


			/*if (_allowEnabledBotonContinuar) 
			{
				_enabledBotonContinuar = !_isValid;			
				if (!_isValid) 
				{
					if(OnModelChanged != null)
						OnModelChanged(this, new EventArgs());
				}
			}*/
			/*
			
			_cierreAutomatico = Convert.ToBoolean( tipo.InvokeMember( "CierreAutomatico", System.Reflection.BindingFlags.GetProperty, null, sender, new object[] {} ) );

			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
				*/
			/*if(OnModelChanged != null)
				OnModelChanged(this, new EventArgs());*/
		}

		private void _cierre_ObjectHasChanged(object sender, EventArgs e)
		{
			System.Type tipo = sender.GetType();
			object objeto = tipo.InvokeMember( "Mensaje", System.Reflection.BindingFlags.GetProperty, null, sender, new object[] {} );			
						
			_mensaje = Convert.ToString(objeto);
			if(OnModelChanged != null)
				OnModelChanged(this, new EventArgs());
		}

		private void Listener(object Sender, System.EventArgs e)
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
			return this._processManager.IsFirstTask(_cierre.GetTaskName());
		}

		public string GetTaskName()
		{
			return _cierre.GetTaskName();
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
			return _cierre.AllowPrevious();
		}

		public void Previous()
		{
			_cierre.Previous();
		}



		public ItemsDatasetErrors GetErrors()
		{
			// TODO: agregar la implementación ConceptosAdicionalesController.GetErrors
			return _cierre.GetErrors();				
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
			this._cierre.Execute();							
			if (!_cierre.IsValid()) 
			{
				if(OnModelChanged != null)
					OnModelChanged(this, new EventArgs());
			}
		}

		public bool AllowShow()
		{
			//return _allowShow;
			return _cierre.AllowShow();
		}

		public ITask GetTask()
		{
			return (ITask)this._cierre;
		}
			
		#endregion
	}
}

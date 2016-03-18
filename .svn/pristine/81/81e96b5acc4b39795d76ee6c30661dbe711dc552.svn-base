using System;
using mz.erp.businessrules;
using System.Reflection;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de FiscalController.
	/// </summary>
	public class AbmCuentasCondicionesDeVentaController: ITaskController
	{
		#region Contructores
		private AbmCuentasCondicionesDeVenta _abm;
		public AbmCuentasCondicionesDeVentaController()
		{			
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public AbmCuentasCondicionesDeVentaController(mz.erp.businessrules.AbmCuentasCondicionesDeVenta abm)
		{
			_abm = abm;
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

		private string _codigo = String.Empty;
		public string Codigo
		{
			set 
			{
				if (value != _codigo)
				{
					_codigo = value;
					if(CodigoChanged != null)
						CodigoChanged(this, new EventArgs());
				}
			}
			get 
			{
				return _codigo;
			}			
		}

		private CuentaCondicionesDeVenta _cuentaCondicionesDeVenta;
		public CuentaCondicionesDeVenta CuentaCondicionesDeVenta 
		{
			get 
			{
				return _cuentaCondicionesDeVenta;
			}
			set 
			{
				_cuentaCondicionesDeVenta = value;
			}
		}
			
		#endregion

		#region Variables Públicas Datos
		
		#endregion
		#region Variables Privadas
							
		/*private bool _cierreAutomatico = false;
		private string _mensaje = "";*/
		private bool _isValid = true;
		private bool _allowShow = false;
		
		/*private bool _enabledBotonContinuar = false;
		private bool _allowEnabledBotonContinuar = false; //Creada para impedir que en cierres X, por ejemplo, el usuario pueda volver imprimir el comprobante mientras la impresora fiscal está imprimiendo.*/
						
		#endregion

		#region Variables Privadas Datos
		/*public string Mensaje 
		{
			get {return _mensaje;	}
		}*/
		public bool IsValid 
		{
			get {return _isValid;}
		}
		/*public bool CierreAutomatico
		{
			get {return _cierreAutomatico;}
		}
		public bool EnabledBotonContinuar
		{
			get {return _enabledBotonContinuar;}
		}	*/	
		
		#endregion

		#region Eventos y delegados
		public event EventHandler CodigoChanged;
		
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
			this._abm.OnTaskAfterExecute +=new EventHandler(_abm_OnTaskAfterExecute);
			this.CodigoChanged +=new EventHandler(AbmCuentasCondicionesDeVentaController_CodigoChanged);
		}

		/*private void _cierre_ObjectHasChanged(object sender, EventArgs e)
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
			return this._processManager.IsFirstTask(_abm.GetTaskName());
		}
		public string GetTaskName()
		{
			return _abm.GetTaskName();
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
			return _abm.AllowPrevious();
		}

		public void Previous()
		{
			_abm.Previous();
		}


		public ItemsDatasetErrors GetErrors()
		{
			// TODO: agregar la implementación ConceptosAdicionalesController.GetErrors
			return _abm.GetErrors();				
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
			this._abm.CuentaCondicionesDeVenta = this._cuentaCondicionesDeVenta;
			this._abm.Execute();
		}

		public bool AllowShow()
		{
			return _allowShow;
		}

		public ITask GetTask()
		{
			return (ITask)this._abm;
		}
			
		#endregion

		private void _abm_OnTaskAfterExecute(object sender, EventArgs e)
		{
			/*System.Type tipo = sender.GetType();
			_isValid = Convert.ToBoolean( tipo.GetMethod("IsValid").Invoke(sender, null));			


			if (_allowEnabledBotonContinuar) 
			{
				_enabledBotonContinuar = !_isValid;			
				if (!_isValid) 
				{
					if(OnModelChanged != null)
						OnModelChanged(this, new EventArgs());
				}
			}			
			_cierreAutomatico = Convert.ToBoolean( tipo.InvokeMember( "CierreAutomatico", System.Reflection.BindingFlags.GetProperty, null, sender, new object[] {} ) );*/

			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}

		private void AbmCuentasCondicionesDeVentaController_CodigoChanged(object sender, EventArgs e)
		{						
			_cuentaCondicionesDeVenta = _abm.GetCondicionesDeVenta(Codigo);
		}
		/*public 
			GetCondicionesDeVenta(string Codigo) 
		{
			._cuentaCondicionesDeVenta = _abm.GetCondicionesDeVenta(Codigo);
		}*/
		
		public bool PreguntarAlCancelar
		{
			get
			{
				return _abm.PreguntarAlCancelar;
			}
		}

	}
}


using System;
using System.Data;
using mz.erp.businessrules;
using System.Reflection;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de FiscalController.
	/// </summary>
	public class AbmCotizacionMonedaController: ITaskController
	{
		#region Contructores
		private mz.erp.businessrules.AbmCotizacionMoneda _abm;
		public AbmCotizacionMonedaController()
		{			
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public AbmCotizacionMonedaController(mz.erp.businessrules.AbmCotizacionMoneda abm)
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
		#endregion

		#region Variables Públicas Datos
		public string LeyendaFormulario
		{
			get { return this._leyendaFormulario ; }
		}
		public bool PreguntarAlCancelar
		{
			get	{return _abm.PreguntarAlCancelar;}
		}
		public string TextoBotonSiguiente
		{
			get 
			{
				return _abm.TextoBotonSiguiente;
			}
		}

		public string TextoBotonAnterior
		{
			get 
			{
				return _abm.TextoBotonAnterior;
			}
		}
		
		#endregion
		#region Variables Privadas
							
		
		private bool _isValid = true;
		private bool _allowShow = true;
		private string _leyendaFormulario = "Cotización de monedas";
						
		#endregion

		#region Variables Privadas Datos		

		public bool IsValid 
		{
			get {return _isValid;}
		}

		private string _monedaValueMember = "IdMoneda";
		public string MonedaValueMember 
		{
			get {return _monedaValueMember;}
		}

		private string _monedaDisplayMember = "Descripcion";
		public string MonedaDisplayMember 
		{
			get {return _monedaDisplayMember;}
		}

		private string _monedaSortedMember = "Descripcion";
		public string MonedaSortedMember 
		{
			get {return _monedaSortedMember;}			
		}
 		
		private string _fuenteDeCambioValueMember = "IdFuenteDeCambio";
		public string FuenteDeCambioValueMember 
		{
			get {return _fuenteDeCambioValueMember;}
		}

		private string _fuenteDeCambioDisplayMember = "Descripcion";
		public string FuenteDeCambioDisplayMember 
		{
			get {return _fuenteDeCambioDisplayMember;}
		}


		private string _fuenteDeCambioSortedMember = "Descripcion";
		public string FuenteDeCambioSortedMember 
		{
			get {return _fuenteDeCambioSortedMember;}			
		} 
 
		public DataTable Monedas
		{
			get
			{
				return _abm.Monedas;
			}
		}
		public DataTable FuentesDeCambio
		{
			get
			{
				return _abm.FuentesDeCambio;
			}
		}		

		public string IdMonedaOrigen
		{
			get {return _abm.IdMonedaOrigen;}
			set 
			{
				if (_abm.IdMonedaOrigen!= value) 
				{
					_abm.IdMonedaOrigen = value;
					if(IdMonedaOrigenChanged != null)
						IdMonedaOrigenChanged(this, new EventArgs());	
				}				
			}		
		}

		public string IdMonedaDestino
		{
			get {return _abm.IdMonedaDestino;}
			set 
			{
				if (_abm.IdMonedaDestino!= value) 
				{
					_abm.IdMonedaDestino = value;
					if(IdMonedaDestinoChanged != null)
						IdMonedaDestinoChanged(this, new EventArgs());	
				}				
			}
		}

		public string IdFuenteDeCambio
		{
			get {return _abm.IdFuenteDeCambio;}
			set 
			{
				if (_abm.IdFuenteDeCambio!= value) 
				{
					_abm.IdFuenteDeCambio = value;
					if(IdFuenteDeCambioChanged != null)
						IdFuenteDeCambioChanged(this, new EventArgs());	
				}				
			}
		}

		
		public decimal Cotizacion
		{
			get {return _abm.Cotizacion;}
			set {_abm.Cotizacion = value;}
		}

		#endregion

		#region Eventos y delegados
			
		public event EventHandler IdMonedaOrigenChanged;		
		public event EventHandler IdMonedaDestinoChanged;		
		public event EventHandler IdFuenteDeCambioChanged;		
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
			//this.CodigoChanged +=new EventHandler(AbmCuentasCondicionesDeVentaController_CodigoChanged);
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
		public void Continue()
		{
			_abm.Execute();
		}

		public ItemsDatasetErrors GetErrors()
		{
			// TODO: agregar la implementación ConceptosAdicionalesController.GetErrors
			return _abm.GetErrors();				
		}

		public string GetWarnings()
		{
			return _abm.GetWarnings();
		}

		public void RefreshData()
		{
			Listener( this, new System.EventArgs());
		}

		public void Execute() 
		{													
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
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}

	}
}

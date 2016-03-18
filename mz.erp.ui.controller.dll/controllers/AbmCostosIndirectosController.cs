
using System;
using System.Data;
using mz.erp.businessrules;
using System.Reflection;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de AbmCostosIndirectos.
	/// </summary>
	public class AbmCostosIndirectosController: ITaskController
	{
		#region Contructores
		private mz.erp.businessrules.AbmCostosIndirectos _brClass;
		public AbmCostosIndirectosController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public AbmCostosIndirectosController(mz.erp.businessrules.AbmCostosIndirectos _abm)
		{
			_brClass = _abm;
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

		#region Variables Publicas
		public event EventHandler OnTaskAfterExecute;
		#endregion

		#region Variables Privadas
		private bool _isValid = true;
		private bool _allowShow = true;
		private string _leyendaFormulario = "Costos Indirectos";
		#endregion

		#region Metodos  Privados
		private void InitializeData()
		{
			
		}
		
		private void InitEvents()
		{
			this._brClass.OnTaskBeforeExecute +=new EventHandler(_brClass_OnTaskAfterExecute);
			//this. += new EventHandler(AbmCuentasCondicionesDeVentaController_CodigoChanged);
		}

		private void Listener(object Sender, System.EventArgs e)
		{			
		}
		#endregion

		#region Propiedades

		public bool IsValid 
		{
			get {return _isValid;}
		}

		public string LeyendaFormulario
		{
			get { return this._leyendaFormulario; }
		}

		public bool PreguntarAlCancelar
		{
			get {return _brClass.PreguntarAlCancelar;}
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

		private string _tipoValueMember = "IdTipo";
		public string TipoValueMember 
		{
			get {return _tipoValueMember;}
		}

		private string _tipoDisplayMember = "Descripcion";
		public string TipoDisplayMember 
		{
			get {return _tipoDisplayMember;}
		}


		private string _tipoSortedMember = "Descripcion";
		public string TipoSortedMember 
		{
			get {return _tipoSortedMember;}			
		} 

		public DataTable Monedas
		{
			get
			{
				return _brClass.Monedas;
			}
		}
		public DataTable FuentesDeCambio
		{
			get
			{
				return _brClass.FuentesDeCambio;
			}
		}	
	
		public bool Tipo
		{
			get
			{
				return _brClass.Tipo;
			}
		}	

		public string IdMoneda
		{
			get {return _brClass.IdMoneda;}
			set 
			{
				if (_brClass.IdMoneda != value) 
				{
					_brClass.IdMoneda = value;
					if(IdMonedaChanged != null)
						IdMonedaChanged(this, new EventArgs());	
				}				
			}		
		}

		public string IdFuenteDeCambio
		{
			get {return _brClass.IdFuenteDeCambio;}
			set 
			{
				if (_brClass.IdFuenteDeCambio!= value) 
				{
					_brClass.IdFuenteDeCambio = value;
					if(IdFuenteDeCambioChanged != null)
						IdFuenteDeCambioChanged(this, new EventArgs());	
				}				
			}
		}

		public bool Porcentaje
		{
			get{return _brClass.Porcentaje;}
			set{_brClass.Porcentaje = value;}
		}

		public bool Moneda
		{
			get{return _brClass.Moneda;}
			set{_brClass.Moneda = value;}
		}

		public System.Data.DataTable CostosIndirectosDataTable
		{
			get{return _brClass.CostosIndirectosDataTable;}
		}
		
		public decimal Cotizacion
		{
			get {return _brClass.Cotizacion;}
			set {_brClass.Cotizacion = value;}
		}

		public string IdCoeficienteCostoIndirecto
		{
			get{return _brClass.IdCoeficienteCostoIndirecto;}
			set{_brClass.IdCoeficienteCostoIndirecto = value;}
		}

		#endregion

		#region Eventos y delegados			
		public event EventHandler IdMonedaChanged;		
		public event EventHandler IdFuenteDeCambioChanged;		
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
		public void Continue()
		{
			_brClass.Execute();
		}

		public ItemsDatasetErrors GetErrors()
		{
			// TODO: agregar la implementación ConceptosAdicionalesController.GetErrors
			return _brClass.GetErrors();				
		}

		public string GetWarnings()
		{
			return _brClass.GetWarnings();
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

	}

}

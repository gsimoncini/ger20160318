
using System;
using System.Data;
using mz.erp.businessrules;
using System.Reflection;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de AbmCostosIndirectos.
	/// </summary>
	public class AbmCostosIndirectos: ITaskController
	{
		#region Contructores
		private mz.erp.businessrules.AbmCostosIndirectos _brAbmCostosIndirectos;
		public AbmCostosIndirectos()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public AbmCostosIndirectos(mz.erp.businessrules.AbmCostosIndirectos _abm)
		{
			_brAbmCostosIndirectos = _abm;
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
		private string _leyendaFormulario = "ABM de Costos Indirectos";
		#endregion

		#region Metodos  Publicos
		#endregion

		#region Metodos  Privados
		private void InitializeData()
		{
			
		}
		
		private void InitEvents()
		{
			this._brAbmCostosIndirectos.OnTaskBeforeExecute +=new EventHandler(_brAbmCostosIndirectos_OnTaskAfterExecute);
			//this. += new EventHandler(AbmCuentasCondicionesDeVentaController_CodigoChanged);
		}

		private void Listener(object Sender, System.EventArgs e)
		{			
		}
		#endregion

		#region Eventos y delegados			
		public event EventHandler IdMonedaOrigenChanged;		
		public event EventHandler IdMonedaDestinoChanged;		
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
			return this._processManager.IsFirstTask(_brAbmCostosIndirectos.GetTaskName());
		}

		public string GetTaskName()
		{
			return _brAbmCostosIndirectos.GetTaskName();
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
			return _brAbmCostosIndirectos.AllowPrevious();
		}

		public void Previous()
		{
			_brAbmCostosIndirectos.Previous();
		}
		public void Continue()
		{
			_brAbmCostosIndirectos.Execute();
		}

		public ItemsDatasetErrors GetErrors()
		{
			// TODO: agregar la implementación ConceptosAdicionalesController.GetErrors
			return _brAbmCostosIndirectos.GetErrors();				
		}

		public string GetWarnings()
		{
			return _brAbmCostosIndirectos.GetWarnings();
		}

		public void RefreshData()
		{
			Listener( this, new System.EventArgs());
		}

		public void Execute() 
		{													
			this._brAbmCostosIndirectos.Execute();
		}

		public bool AllowShow()
		{
			return _allowShow;
		}

		public ITask GetTask()
		{
			return (ITask)this._brAbmCostosIndirectos;
		}
			
		#endregion

		private void _brAbmCostosIndirectos_OnTaskAfterExecute(object sender, EventArgs e)
		{
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}

	}

}

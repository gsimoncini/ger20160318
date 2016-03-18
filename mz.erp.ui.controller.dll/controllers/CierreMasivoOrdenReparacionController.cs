using System;
using System.Data;
using mz.erp.businessrules;
using System.Collections;
using System.Text;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de CierreMasivoOrdenReparacionController.
	/// </summary>
	public class CierreMasivoOrdenReparacionController: ITaskController
	{
		#region Contructores

		public CierreMasivoOrdenReparacionController()
		{
		}

		public CierreMasivoOrdenReparacionController(CierreMasivoOrdenReparacion brClass)
		{
			_brClass = brClass;
			Init();
		}

		#endregion

		#region Variables Privadas 
		private CierreMasivoOrdenReparacion _brClass;
		private bool _allowShow = true;		
		#endregion

		#region Propiedades

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

		public ArrayList Result
		{
			get { return _brClass.Result; }
		}

		public System.Data.DataTable ResultAsTable
		{
			get { return _brClass.ResultAsTable; }
		}


		#endregion

		#region Eventos y delegados		
		public event EventHandler DataChanged;
		#endregion

		#region Métodos  Públicos
		public void RefreshData()
		{
			_brClass.RefreshData();
			if(DataChanged != null)
				DataChanged(this, new EventArgs());
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

	}
}

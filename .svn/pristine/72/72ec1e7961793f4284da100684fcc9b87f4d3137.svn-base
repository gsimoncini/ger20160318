using System;
using System.Collections;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ConsultarComprobantesGuardados.
	/// </summary>
	public class ConsultarComprobantesGuardados: ITask, IQuerySavedTask
	{

		private object _data;
		public object Data 
		{
			get 
			{
				return _data;
			}
			set 
			{
				_data = value;
			}
		}

		#region Variables privadas
		private DateTime _fechaDesde;
		private DateTime _fechaHasta;
		private string _idCuenta;
		/*private string _codigoCuenta = string.Empty;*/
		private string _idResponsable;
		private string _familiaComprobantes;
		private string _idProveedor;

		private ArrayList _tiposDeComprobantesOrigen = new ArrayList();
		private ArrayList _tiposDeComprobantesDestino = new ArrayList();
			
		/*private ArrayList _arrayIdComprobantesPendientes = new ArrayList();
		private RelacionesComprobanteOrigenDestino _relacionesComprobanteOrigenDestino;*/
		private ProcessManager _processManager;
		private string _taskName;
		private long _idTask;
		private string _primaryTaskName;
		private long _idPrimaryTask;
		private long _idProcess;
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();


		#endregion

		#region Miembros de ITask
		public event System.EventHandler ObjectHasChanged;
		public event System.EventHandler OnTaskBeforeExecute;
		public event System.EventHandler OnTaskAfterExecute;	
	
		public event System.EventHandler OnTaskBeforePrevious;
		public event System.EventHandler OnTaskAfterPrevious;

		public void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public bool AllowPrevious()
		{
			return true;
		}
		public void ListenerAfterPreviousDependentTask( object sender )
		{
		}
		public void ListenerBeforePreviousDependentTask( object sender )
		{
		}
			

		public void ListenerTaskDependentChanged(object sender){}
		public void ListenerAfterExecuteDependentTask( object sender ){}
		public void ListenerBeforeExecuteDependentTask( object sender ){}

		public void Init()
		{
			ProcessManager processManager = this.GetProcessManagerParent();
			TaskDynamicInfo primaryTask = processManager.Process.MainTask;
			this._idProcess = processManager.Process.IdProcess;
			this._primaryTaskName = primaryTask.KeyTask;
			this._idPrimaryTask = primaryTask.IdTask;
			this._idTask = Workflow.GetIdTakByName(this._taskName);
			this._fechaDesde = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-30);
			this._fechaHasta = mz.erp.businessrules.Sistema.DateTime.Now;
			this._idResponsable = Security.IdPersona;
			//this._familiaComprobantes = this.ObtenerFamiliaComprobante();
			this._idProveedor = Variables.GetValueString("Compras.Pedidos.ProveedorPorDefault");
			this._idCuenta = Variables.GetValueString("Momentos." +_idPrimaryTask+ ".Cuenta.Default");
			//_arrayIdComprobantesPendientes = new ArrayList();
			//this._tiposDeComprobantesOrigen = this.GetTiposDeComprobantesOrigen();
			//this._tiposDeComprobantesDestino = this.GetTiposDeComprobantesDestinos();
		}

		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processManager.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}

		public bool IsValid()
		{
			return true;
		}
		public bool AllowShow() 
		{
			return true;
		}

		public void FormHasClosed() 
		{
		}

		public ItemsDatasetErrors GetErrors()
		{			
			return _errores;
		}
		public string GetWarnings()
		{
			return null;			
		}

		public ProcessManager GetProcessManagerParent()
		{
			return _processManager;
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			//_processManager = processManager;
		}

		public string GetTaskName()
		{			
			return _taskName;
		}

		public void SetTaskName(string taskName)
		{
			_taskName = taskName;
		}

		public void Execute()
		{
			if(OnTaskBeforeExecute != null)
				OnTaskBeforeExecute(this, new EventArgs());
			this.IsValid();
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}

		#endregion


		public ConsultarComprobantesGuardados()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
	}
}

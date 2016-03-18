using System;
using System.Collections;
using mz.erp.commontypes.data;
using mz.erp.businessrules.comprobantes;
using mz.erp.systemframework;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ListarComprobantes.
	/// </summary>
	public class ListarComprobantes: ITask
	{
		public ListarComprobantes()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#region Variables privadas
			
		private DateTime _fechaDesde = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-1);
		private DateTime _fechaHasta = mz.erp.businessrules.Sistema.DateTime.Now;
		private string _idCuenta = string.Empty;		
		
		private string _codigoCuenta = string.Empty;
		private string _idResponsable = string.Empty;//Security.IdPersona;
		
		private string _tipoComprobante = string.Empty;

		private bool _allowShowDetail = false;
		
		private ArrayList _arrayListaComprobantes = new ArrayList();
		private ProcessManager _processManager;
		private string _taskName;
		private long _idTask;
		private string _primaryTaskName;
		private long _idPrimaryTask;
		private long _idProcess;
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();

		private System.Data.DataTable _result;
		private bool _soloPendientes = true;
			

		#endregion

		#region Variables Publicas

		public System.Data.DataTable Result
		{
			get{return _result;}
			set{_result = value;}
			
		}


		public bool AllowShowDetail
		{
			get{return _allowShowDetail;}
		}
		public ArrayList ArrayListaComporbantes
		{
			get
			{
				return _arrayListaComprobantes;
			}
			set
			{
				if(value != _arrayListaComprobantes)
				{
					_arrayListaComprobantes = value;
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}

			}

		}


		
		public string CodigoCuenta
		{
			get
			{
				return _codigoCuenta;
			}
			set
			{
				if(value != _codigoCuenta)
				{
					_codigoCuenta = value;
					_idCuenta = mz.erp.businessrules.tsa_Cuentas.GetPkByUk(_codigoCuenta);
				}
			}
		}
		
		public string TipoComprobante
		{
			get
			{
				return _tipoComprobante;
			}
			set
			{
				_tipoComprobante = value;
			}
		}

		private string _familiaComprobantes;
		public string FamiliaComprobantes
		{
			get
			{
				return _familiaComprobantes;
			}
			set
			{
				_familiaComprobantes = value;
			}
		}
		public string IdCuenta
		{
			get
			{
				return _idCuenta;
			}
			
		}
		public string IdResponsable
		{
			get
			{
				return _idResponsable;
			}
			set
			{		
				_idResponsable = value;
			}
		}
		public DateTime FechaDesde
		{
			get
			{
				return _fechaDesde;
			}
			set
			{
				_fechaDesde = value;
			}
		}

		public DateTime FechaHasta
		{
			get
			{
				return _fechaHasta;
			}
			set
			{
				_fechaHasta = value;
			}
		}

		public bool SoloPendientes
		{
			get
			{
				return _soloPendientes;
			}
			set
			{
				_soloPendientes = value;
			}
		}


		public string ProcesoEnEjecucion
		{
			get { return this.GetProcessManagerParent().Process.ProcessName; }
		}
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
			
		
		

		public void ListenerTaskDependentChanged(object sender)	{}
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
			this._familiaComprobantes = Variables.GetValueString("Momentos." +_taskName+ ".FamiliaComprobantes.Default");
			this._allowShowDetail = Variables.GetValueBool(this._processManager.Process.ProcessName, this._taskName, "VisualizaDetalleComprobantes");
			long  cantDias = Variables.GetValueLong(this._processManager.Process.ProcessName, this._taskName, "RangoFechas.DiasAnteriores");
			if(!cantDias.Equals(long.MinValue))
				_fechaDesde = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-cantDias);
			 cantDias = Variables.GetValueLong(this._processManager.Process.ProcessName, this._taskName, "RangoFechas.DiasPosteriores");
			if(!cantDias.Equals(long.MinValue))
				_fechaHasta = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(cantDias);
			_arrayListaComprobantes = new ArrayList();
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
			_processManager = processManager;
		}

		public string GetTaskName()
		{
			
			return _taskName;
		}

		public void SetTaskName(string taskName)
		{
			_taskName = taskName;
		}

		public void FormHasClosed() 
		{
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
        //Cristian Tsrea 0000050 20110310
        //Cristian Tsrea 0000146 20110719
        public void updateFechas(DateTime fecha, bool ordenInverso)
        {
            long dias = Variables.GetValueLong("Momentos." + this._taskName + "." + _processManager.Process.ProcessName + ".RangoFechas.DiasAnteriores");
            if (!ordenInverso)
            { this._fechaDesde = fecha; }
            else { this._fechaHasta = fecha; };

            if (!ordenInverso)
            {
                if (this.FechaHasta < fecha)
                {
                    _fechaHasta = Util.GenerateFechaHasta(fecha, dias);
                }
            }
            else
            {
                if (this.FechaDesde > fecha)
                {
                    _fechaDesde = Util.GenerateFechaHasta(fecha, dias);
                }

            }//End ELSE

        }
        //Fin Cristian Tarea 0000146
        //Fin Cristian	
	}
}

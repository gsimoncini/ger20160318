using System;
using System.Collections;
using System.Data;
using mz.erp.businessrules.reportes;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ConsultarLibroIVA.
	/// </summary>
	public class ConsultarLibroIVA: ITask
	{
		public ConsultarLibroIVA()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#region Propiedades

		private string _leyendaFormulario = string.Empty;
		public string LeyendaFormulario
		{
			get 
			{		
				string valor = String.Empty;				
				valor = Variables.GetValueString(this._processParent.Process.ProcessName, this.GetTaskName(), "LeyendaFormulario");
				if (valor == String.Empty) 
				{
					return this._taskName;
				}
				else 
				{
					return valor;
				}
			}
		}

		public bool PreguntarAlCancelar
		{
			get 
			{
				bool _preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;
			}
		}

		public string FechaDesde
		{
			get{return _fechaDesde;}
			set{_fechaDesde = value;}
		}

		public string FechaHasta
		{
			get{return _fechaHasta;}
			set{_fechaHasta = value;}
		}

		public DataTable RefreshData()
		{						
			
			string[] mesAñoDesde = _fechaDesde.Split(new char[]{'/'});
			string[] mesAñoHasta = _fechaHasta.Split(new char[]{'/'});
			int MesDesde = 0;
			int AñoDesde = 0;
			int MesHasta = 0;
			int AñoHasta = 0;
			if(mesAñoDesde.Length == 2 && mesAñoHasta.Length ==2)
			{
				MesDesde = Convert.ToInt32(mesAñoDesde[0]);
				AñoDesde = Convert.ToInt32(mesAñoDesde[1]);
				MesHasta = Convert.ToInt32(mesAñoHasta[0]);
				AñoHasta = Convert.ToInt32(mesAñoHasta[1]);
				_result = mz.erp.businessrules.reportes.tsa_ReporteImpuestos.GetLibroIVACompras(AñoDesde, MesDesde, AñoHasta, MesHasta, _listaTiposDeComprobantes).Tables[0];

			}

            return _result;
		}



		#endregion

		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler DataChanged;

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
			

		public void ListenerTaskDependentChanged(object sender)
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.ListenerTaskDependentChanged
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación PrepararDatosImpresionComprobantes.ListenerBeforeExecuteDependentTask
		}

		public void Init()
		{
			_fechaDesde = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();				
			_fechaHasta = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();	
			_listaTiposDeComprobantes = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "ListaTiposDeComprobantes");
		}

		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}

		public bool IsValid()
		{
			bool IsValid = true;
			_errores.Clear();
			return IsValid;
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
			if(_processParent.Process.ProcessName.Equals("ProcesoValorizarStock"))
				return "Desea guardar La Valorización de Stock Actual?";
			return null;			
		}

		public ProcessManager GetProcessManagerParent()
		{
			return _processParent;
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_processParent = processManager;
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

		#region Variables privadas

		private string _taskName = string.Empty;		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;	
		private DataTable _result = new DataTable();	
		private string _fechaDesde = string.Empty;
		private string _fechaHasta = string.Empty;
		private string _listaTiposDeComprobantes = string.Empty;
		


		#endregion
	}
}

using System;
using System.Data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de mzPersonasSearchForm.
	/// </summary>
	public class mzPersonasSearchForm: ITask
	{
		#region Constructores
		public mzPersonasSearchForm()
		{

		}
		#endregion

		#region Variables Privadas
		#endregion

		#region Eventos
		#endregion

		#region Variables Públicas

		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonAnterior";
				valor = Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonAnterior";
					valor = Variables.GetValueString(variable);				
				}									
				
				if (valor == String.Empty) 
				{
					return _textoBotonAnterior;
				}
				else 
				{
					return valor;
				}							
			}
		}
		private string _textoBotonSiguiente = "Siguiente";
		public string TextoBotonSiguiente
		{
			get 
			{		
				string valor = String.Empty;				
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonSiguiente";
				valor = Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonSiguiente";
					valor = Variables.GetValueString(variable);				
				}									
				
				if (valor == String.Empty) 
				{
					return _textoBotonSiguiente;
				}
				else 
				{
					return valor;
				}
			}
		}

		private string _nombre = String.Empty;
		public string Nombre
		{
			get { return _nombre;}
			set { _nombre = value;}
		}

		private string _telefonos = String.Empty;
		public string Telefonos
		{
			get { return _telefonos;}
			set { _telefonos = value;}
		}

		private string _email = String.Empty;
		public string Email
		{
			get { return _email;}
			set { _email = value;}
		}

		private bool _activo = false;
		public bool Activo
		{
			get { return _activo;}
			set { _activo = value;}
		}

		private bool _byActivo = false;
		public bool ByActivo
		{
			get { return _byActivo;}
			set { _byActivo = value;}
		}

		#endregion

		#region Métodos Privados

		#endregion

		#region Métodos Públicos

		public DataView SearchNow()
		{
			DataTable tabla = mz.erp.businessrules.tsh_Personas.GetList("", _nombre, _telefonos, _email, _byActivo, _activo).tsh_Personas;			
			return tabla.DefaultView;

		}

		#endregion

		#region Miembros de ITask

		private string _taskName = string.Empty;			
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _processParent;

		public event System.EventHandler ObjectHasChanged;

		public event System.EventHandler OnTaskBeforeExecute;

		public event System.EventHandler OnTaskAfterExecute;

		public event System.EventHandler OnTaskBeforePrevious;

		public event System.EventHandler OnTaskAfterPrevious;

		public void ListenerTaskDependentChanged(object sender)
		{
			
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}

		public void Init()
		{

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
			_errores.Clear();
			bool isvalid = true;
			return isvalid;
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
			return string.Empty;
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
			return this._taskName;
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

		public bool AllowPrevious()
		{
			return true;
		}

		public void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public void ListenerAfterPreviousDependentTask(object sender)
		{
			
		}

		public void ListenerBeforePreviousDependentTask(object sender)
		{
			
		}

		#endregion

		#region Variables Privadas
		#endregion


	}
}

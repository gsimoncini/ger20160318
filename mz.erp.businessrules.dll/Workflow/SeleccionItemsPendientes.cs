using System;
using System.Collections;
using mz.erp.businessrules.comprobantes;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de SeleccionItemsPendientes.
	/// </summary>
	public class SeleccionItemsPendientes : ITask
	{
		public SeleccionItemsPendientes()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		
		#region Variables Privadas
			private ProcessManager _processManager;
			private string _taskName;
			private long _idTask;
			private ArrayList _arrayComprobantesPendientes;
			private RelacionesComprobanteOrigenDestino _relacionesComprobantesOrigenDestino;
			private bool _hasShow = true;
			private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
			
		#endregion

		public bool HasShow
		{
			get
			{
				return _hasShow;
			}
		}
			
		public RelacionesComprobanteOrigenDestino RelacionesComprobanteOrigenDestino
		{
			get
			{
				return _relacionesComprobantesOrigenDestino;
			}
		}

		public ArrayList ArrayComprobantesPendientes
		{
			get
			{
				return _arrayComprobantesPendientes;
			}
		}

		public bool PreguntarAlCancelar
		{
			get 
			{
				bool _preguntarAlCancelar = Variables.GetValueBool(_processManager.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;
			}
		}

		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				string variable = "Momentos." + this.GetTaskName() + "." + this._processManager.Process.ProcessName + "." + "TextoBotonAnterior";
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
				string variable = "Momentos." + this.GetTaskName() + "." + this._processManager.Process.ProcessName + "." + "TextoBotonSiguiente";
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

		#region Variables Publicas
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
			

		public void ListenerTaskDependentChanged(object sender)
		{
		}
		public void ListenerAfterExecuteDependentTask( object sender )
		{
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.ComprobantesPendientes)))
			{
				ComprobantesPendientes comprobantesPendientes = (ComprobantesPendientes) sender;
				this._arrayComprobantesPendientes = comprobantesPendientes.ArrayIdComprobantesPendientes;
				ArrayList TCdestinos = comprobantesPendientes.TiposDeComprobantesDestino;				
				if(comprobantesPendientes.RelacionesComprobanteOrigenDestino != null && comprobantesPendientes.RelacionesComprobanteOrigenDestino.Count > 0 && !comprobantesPendientes.HasShowSeleccionItems)
				{
					this._relacionesComprobantesOrigenDestino = comprobantesPendientes.RelacionesComprobanteOrigenDestino;					
					
				}
				else
				{
					GetRelacionesComprobantesOrigenDestino(TCdestinos);				
				}
				_hasShow = comprobantesPendientes.HasShowSeleccionItems;
					
			}
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.SeleccionReparacionesPendientes)))
			{
				SeleccionReparacionesPendientes reparacionesPendientes = (SeleccionReparacionesPendientes) sender;
				this._arrayComprobantesPendientes = reparacionesPendientes.ArrayIdComporbantesPendientes;
				GetRelacionesComprobantesOrigenDestinoFromReparaciones();
							
			}
			
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.ComprobantesPendientesConsolaEntregas)))
			{
				ComprobantesPendientesConsolaEntregas comprobantesPendientesConsolaEntregas = (ComprobantesPendientesConsolaEntregas) sender;
				this._arrayComprobantesPendientes= comprobantesPendientesConsolaEntregas.ComprobantesSeleccionados;				
				GetRelacionesComprobantesOrigenDestino();
				_hasShow = true;
					
			}
			
		}
		public void ListenerBeforeExecuteDependentTask( object sender ){}
		
		private void GetRelacionesComprobantesOrigenDestinoFromReparaciones()
		{
			if(this._arrayComprobantesPendientes != null && this._arrayComprobantesPendientes.Count > 0)
			{
				System.Data.DataSet data =  Workflow.GetPreviousTasksOfProcess(this._processManager.Process.MainTask.IdTask, this._processManager.Process.IdProcess);
				string TareaPrevia = string.Empty;
				if(data.Tables[0].Rows.Count > 0)
				{
					TareaPrevia = Convert.ToString(data.Tables[0].Rows[0]["Descripcion"]);
				}
				this._relacionesComprobantesOrigenDestino = new RelacionesComprobanteOrigenDestino( this._processManager.Process.ProcessName, this._taskName, TareaPrevia);
				this._relacionesComprobantesOrigenDestino.LoadFromOrdenReparaciones(this._arrayComprobantesPendientes);
				this.ObjectHasChanged(this, new EventArgs());
			}
		}

		private void GetRelacionesComprobantesOrigenDestino()
		{
			if(this._arrayComprobantesPendientes != null && this._arrayComprobantesPendientes.Count > 0)
			{
				this._relacionesComprobantesOrigenDestino = new RelacionesComprobanteOrigenDestino(this._arrayComprobantesPendientes, this._processManager.Process.ProcessName, this._taskName, this._processManager.Process.MainTask.KeyTask);				
					this.ObjectHasChanged(this, new EventArgs());
			}
		}

		private void GetRelacionesComprobantesOrigenDestino(ArrayList TCdestinos)
		{
			if(this._arrayComprobantesPendientes != null && this._arrayComprobantesPendientes.Count > 0)
			{
				this._relacionesComprobantesOrigenDestino = new RelacionesComprobanteOrigenDestino(this._arrayComprobantesPendientes,this._processManager.Process.ProcessName, this._taskName, this._processManager.Process.MainTask.KeyTask);				
				this._relacionesComprobantesOrigenDestino.ArrTiposComprobantesDestino = TCdestinos;
				//this._relacionesComprobantesOrigenDestino.Load(this._arrayComprobantesPendientes);				
				this.ObjectHasChanged(this, new EventArgs());
			}
		}


		public void Init()
		{
			this._idTask = Workflow.GetIdTakByName(this._taskName);
		}

		public bool IsValid()
		{
			return true;
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


		public bool AllowShow() 
		{
			//string variable = "Momentos." + this._processManager.Process.MainTask.KeyTask + "." + this._taskName + ".VisualizaVentana";
			/*
			string variable = "Momentos." + this.GetTaskName() + "." + this._processManager.Process.ProcessName + "." + "VisualizaVentana";
			string var = "Momentos." + this._taskName + ".VisualizaVentana";
			
			bool ok = Variables.GetValueBool(variable);
			if(!ok)
			{
				ok = Variables.GetValueBool(var);
				return ok;
			}
			else
			return true;
			*/
			return Variables.GetValueBool(this._processManager.Process.ProcessName, this._taskName, "VisualizaVentana")
					&& !this.ComprobantesPreviosPercibenIB();
		}

		private bool ComprobantesPreviosPercibenIB()
		{
			ArrayList table = new ArrayList();
			foreach(RelacionComprobanteOrigenDestino rcod in this._relacionesComprobantesOrigenDestino)
			{
				string IdComprobante = rcod.IdComprobante;
				if(!table.Contains(IdComprobante))
					table.Add(IdComprobante);
			}
			bool ok = false;
			foreach(string IdComp in table)
			{
				ok = ok || mz.erp.businessrules.tsa_ComprobantesEx.PercibeIB(IdComp);
			}
			return ok;
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
			
			return this._processManager;
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			this._processManager = processManager;
		}

		public string GetTaskName()
		{
			return this._taskName;
		}

		public void SetTaskName(string taskName)
		{
			this._taskName = taskName;
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
	}
}

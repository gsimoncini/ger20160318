using System;
using System.Collections;
using mz.erp.businessrules.comprobantes;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de SeleccionItemsDeCompraPendientes.
	/// </summary>
	public class SeleccionItemsDeCompraPendientes: ITask
	{
		public SeleccionItemsDeCompraPendientes()
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
		private RelacionesComprobanteDeCompraOrigenDestino _relacionesComprobantesDeCompraOrigenDestino;
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
			
		public RelacionesComprobanteDeCompraOrigenDestino RelacionesComprobanteDeCompraOrigenDestino
		{
			get
			{
				return _relacionesComprobantesDeCompraOrigenDestino;
			}
		}

		public ArrayList ArrayComprobantesPendientes
		{
			get
			{
				return _arrayComprobantesPendientes;
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
		public bool PreguntarAlCancelar
		{
			get 
			{
				bool _preguntarAlCancelar = Variables.GetValueBool(_processManager.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;
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
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.ComprobantesDeCompraPendientes)))
			{
				ComprobantesDeCompraPendientes comprobantesPendientes = (ComprobantesDeCompraPendientes) sender;
				this._arrayComprobantesPendientes = comprobantesPendientes.ArrayIdComporbantesPendientes;
				if(comprobantesPendientes.RelacionesComprobanteDeCompraOrigenDestino != null && comprobantesPendientes.RelacionesComprobanteDeCompraOrigenDestino.Count > 0 && !comprobantesPendientes.HasShowSeleccionItems)
				{
					this._relacionesComprobantesDeCompraOrigenDestino = comprobantesPendientes.RelacionesComprobanteDeCompraOrigenDestino;
					
				}
				else
				{
					GetRelacionesComprobantesOrigenDestino();					

				}
				_hasShow = comprobantesPendientes.HasShowSeleccionItems;
					
			}
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.SeleccionarComprobantesDeCompraPendientes))
				&& !_processManager.Process.ProcessName.Equals("ProcesoPredevolverCompras")
				&& !_processManager.Process.ProcessName.Equals("ProcesoCompletarFacturaCompras")
				&& !_processManager.Process.ProcessName.Equals("ProcesoPredebitarCompras"))
			{
				SeleccionarComprobantesDeCompraPendientes comprobantesPendientes = (SeleccionarComprobantesDeCompraPendientes) sender;
				this._arrayComprobantesPendientes = comprobantesPendientes.ArrayComprobantesPendientes;
				if(comprobantesPendientes.RelacionesComprobanteDeCompraOrigenDestino != null && comprobantesPendientes.RelacionesComprobanteDeCompraOrigenDestino.Count > 0 && !comprobantesPendientes.HasShowSeleccionItems)
				{
					this._relacionesComprobantesDeCompraOrigenDestino = comprobantesPendientes.RelacionesComprobanteDeCompraOrigenDestino;
					
				}
				else
				{
					GetRelacionesComprobantesOrigenDestino();					

				}
				_hasShow = comprobantesPendientes.HasShowSeleccionItems;					
			}			
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.SeleccionarComprobantesDeCompraPendientes))
				&& _processManager.Process.ProcessName.Equals("ProcesoPredevolverCompras"))
			{
				SeleccionarComprobantesDeCompraPendientes comprobantesPendientes = (SeleccionarComprobantesDeCompraPendientes) sender;
				this._arrayComprobantesPendientes = comprobantesPendientes.ArrayComprobantesPendientes;
				_relacionesComprobantesDeCompraOrigenDestino = new RelacionesComprobanteDeCompraOrigenDestino();
				_relacionesComprobantesDeCompraOrigenDestino.LoadForComprobantesDeCompraConfirmacionDePrecios(this._arrayComprobantesPendientes, this._processManager.Process.ProcessName, this._taskName, this._processManager.Process.MainTask.KeyTask);
				_hasShow = comprobantesPendientes.HasShowSeleccionItems;					
			}

			if(sender.GetType().Equals(typeof(mz.erp.businessrules.SeleccionarComprobantesDeCompraPendientes))
				&& _processManager.Process.ProcessName.Equals("ProcesoPredebitarCompras"))
			{
				SeleccionarComprobantesDeCompraPendientes comprobantesPendientes = (SeleccionarComprobantesDeCompraPendientes) sender;
				this._arrayComprobantesPendientes = comprobantesPendientes.ArrayComprobantesPendientes;
				_relacionesComprobantesDeCompraOrigenDestino = new RelacionesComprobanteDeCompraOrigenDestino();
				_relacionesComprobantesDeCompraOrigenDestino.LoadForComprobantesDeCompraConfirmacionDePrecios(this._arrayComprobantesPendientes, this._processManager.Process.ProcessName, this._taskName, this._processManager.Process.MainTask.KeyTask);
				_hasShow = comprobantesPendientes.HasShowSeleccionItems;					
			}

			if(sender.GetType().Equals(typeof(mz.erp.businessrules.SeleccionarComprobantesDeCompraPendientes))
				&& _processManager.Process.ProcessName.Equals("ProcesoCompletarFacturaCompras"))
			{
				SeleccionarComprobantesDeCompraPendientes comprobantesPendientes = (SeleccionarComprobantesDeCompraPendientes) sender;
				this._arrayComprobantesPendientes = comprobantesPendientes.ArrayComprobantesPendientes;
				_relacionesComprobantesDeCompraOrigenDestino = new RelacionesComprobanteDeCompraOrigenDestino();
				_relacionesComprobantesDeCompraOrigenDestino.LoadForCompletarFacturaCompras(this._arrayComprobantesPendientes, this._processManager.Process.ProcessName, this._taskName, this._processManager.Process.MainTask.KeyTask);
				_hasShow = comprobantesPendientes.HasShowSeleccionItems;					
			}
		}
		public void ListenerBeforeExecuteDependentTask( object sender ){}
		
		
		private void GetRelacionesComprobantesOrigenDestino()
		{
			if(this._arrayComprobantesPendientes != null && this._arrayComprobantesPendientes.Count > 0)
			{
				this._relacionesComprobantesDeCompraOrigenDestino = new RelacionesComprobanteDeCompraOrigenDestino(this._arrayComprobantesPendientes, this._processManager.Process.ProcessName, this._taskName, this._processManager.Process.MainTask.KeyTask);
				this.ObjectHasChanged(this, new EventArgs());
			}
		}

		public void Init()
		{
			this._idTask = Workflow.GetIdTakByName(this._taskName);
		}

		public bool IsValid()
		{

			bool isValid = true;
			_errores.Clear();
			if(_processManager.Process.ProcessName.Equals("ProcesoCompletarFacturaCompras"))
			{
				if(_relacionesComprobantesDeCompraOrigenDestino.Count == 0)
				{
					isValid = false;
					_errores.Add( new ItemDatasetError( "Items","Items","Los Artículos aún no han sido Ingresados"));
				}
			}
			foreach( RelacionComprobanteDeCompraOrigenDestino rod in _relacionesComprobantesDeCompraOrigenDestino)
			{
				if(rod.CantidadPendiente < rod.CantidadDestino)
				{
					isValid = false;
					_errores.Add( new ItemDatasetError( "Item " + rod.Codigo,"Cantidad Pendiente","La Cantidad no puede ser mayor que la cantidad Pendiente"));
				}
			}
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
			return Variables.GetValueBool(this._processManager.Process.ProcessName, this._taskName, "VisualizaVentana");
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
			//this.GetRelacionesComprobantesOrigenDestino();
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}
		
		#endregion
	}
	
}

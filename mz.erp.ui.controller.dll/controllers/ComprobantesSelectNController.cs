using System;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ComprobantesSelectNController.
	/// </summary>
	public class ComprobantesSelectNController: ITaskController
	{
		
		public ComprobantesSelectNController(SeleccionItemsPendientes seleccionItemsPendientes)
		{
			this._seleccionItemsPendientes = seleccionItemsPendientes;
			InitEvents();
		}

		
		#region Variables Privadas
		
		private string _layout = mz.erp.ui.controllers.ComprobantesDeVenta.GetLayoutRelacionOrigenDestino( new string[] {"IdTipoDeComprobante", "Numero", "OrdinalOrigen", "CantidadOrigen","CantidadPendiente","CantidadDestino","CodigoProducto","Descripcion", "Precio","Visible", "CampoAuxiliar1", "CampoAuxiliar2", "CampoAuxiliar3", "CampoAuxiliar4", "CampoAuxiliar5", "CampoAuxiliar6", "CodigoProveedor", "Observaciones", "FechaUltimaModificacionPrecioCosto", "FechaUltimaModificacionPrecioVenta"});
		private SeleccionItemsPendientes _seleccionItemsPendientes;
		
		#endregion

		#region Variables Publicas
		
		public event EventHandler OnTaskAfterExecute;
		public event EventHandler OnModelChanged;
		public string Layout
		{
			get
			{
				return _layout;
			}
		}

		public bool HasShow 
		{
			get
			{
				return this._seleccionItemsPendientes.HasShow;
			}
		}
		public RelacionesComprobanteOrigenDestino Items
		{
			get
			{
				return _seleccionItemsPendientes.RelacionesComprobanteOrigenDestino;
			}
		}
		public  string TextoBotonSiguiente
		{
			get 
			{				
				return _seleccionItemsPendientes.TextoBotonSiguiente;
			}
		}

		public  string TextoBotonAnterior
		{
			get 
			{
				return _seleccionItemsPendientes.TextoBotonAnterior;
			}
		}

		public bool PreguntarAlCancelar
		{
			get {return _seleccionItemsPendientes.PreguntarAlCancelar;}
		}



		#endregion
		

		#region Metodos Privados

		private void InitEvents()
		{
			
			this._seleccionItemsPendientes.OnTaskAfterExecute += new EventHandler(this.AfterTaskExecute);	
			this._seleccionItemsPendientes.ObjectHasChanged +=new EventHandler(_seleccionItemsPendientes_ObjectHasChanged);
		
		}

		private void AfterTaskExecute(object sender , EventArgs e)
		{
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}
		
		#endregion

		#region Miembros de ITaskController

		public bool IsFlushedState()
		{
			return this._processManager.ProcessFlushed;
		}

		public bool IsNextState()
		{
			return this._processManager.IsNextState();	
		}

		public bool IsBackState()
		{	
			return this._processManager.IsBackState();
		}

		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_seleccionItemsPendientes.GetTaskName());
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
			return _seleccionItemsPendientes.AllowPrevious();
		}

		public string GetTaskName()
		{
			return _seleccionItemsPendientes.GetTaskName();
		}

		public string GetProcessName()
		{
			return this._processManager.GetProcessName();
		}

		public void Previous()
		{
			_seleccionItemsPendientes.Previous();
		}


		public ITask GetTask()
		{
			
			return (ITask)this._seleccionItemsPendientes;
		}

		public void Execute()
		{
			this._seleccionItemsPendientes.Execute();
		}

		public bool AllowShow()
		{
			return _seleccionItemsPendientes.AllowShow();
		}
		#endregion

		private void _seleccionItemsPendientes_ObjectHasChanged(object sender, EventArgs e)
		{
			if(OnModelChanged != null)
				OnModelChanged(this, new EventArgs());
		}

		public ItemsDatasetErrors GetErrors()
		{
			return _seleccionItemsPendientes.GetErrors();
		}

		public string GetWarnings()
		{
			return null;
		}
		public void Continue()
		{
		}

	}
}

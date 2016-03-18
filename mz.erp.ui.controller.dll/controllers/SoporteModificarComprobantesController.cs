using System;
using System.Data;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.commontypes;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de SoporteModificarComprobantesController.
	/// </summary>
	public class SoporteModificarComprobantesController: ITaskController
	{
		public SoporteModificarComprobantesController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public SoporteModificarComprobantesController(SoporteModificarComprobantes brClass)
		{
			_brClass = brClass;
			Init();
		}

		#region Miembros de ITaskController

		public string GetWarnings()
		{
			return _brClass.GetWarnings();
		}

		public void Continue()
		{
			_brClass.Execute();
		}

		public mz.erp.businessrules.ItemsDatasetErrors GetErrors()
		{
			return _brClass.GetErrors();
		}

		public void Execute()
		{
			_brClass.Execute();
		}

		public bool AllowShow()
		{
			return _brClass.AllowShow();
		}

		public bool AllowPrevious()
		{
			return _brClass.AllowPrevious();
		}

		public void Previous()
		{
			_brClass.Previous();
		}

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
			return this._processManager.IsFirstTask(_brClass.GetTaskName());
		}

		public bool IsLastTask()
		{					
			return this._processManager.IsLastTask(_brClass.GetTaskName());
		}

		
		public void SetProcessManager(ProcessControllerManager processManager)
		{
			_processManager = processManager;
		}

		public ProcessControllerManager GetProcessManager()
		{
			return _processManager;
		}

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}


		
		#endregion

		#region Variables Privadas
		private SoporteModificarComprobantes _brClass;
		private ProcessControllerManager _processManager;
		private string _leyendaFormulario = string.Empty;		
		#endregion

		#region Metodos Privadas
		private void Init()
		{
			SetLeyendaFormulario();
		}
		private void SetLeyendaFormulario()
		{
			string leyenda = Variables.GetValueString(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(), "LeyendaFormulario" );
			if (leyenda.Equals(string.Empty))
			{
				leyenda = this._brClass.GetTaskName();
			}
			this._leyendaFormulario = leyenda;
		}
		#endregion

		#region Metodos Publicos
		public string LeyendaFormulario()
		{
			return this._leyendaFormulario;
		}
		
		public string FillNumberWithZeros(string txt)
		{
			return _brClass.FillNumberWithZeros(txt);
		}
		public DataTable Search()
		{
			return _brClass.Search();
		}
		#endregion

		#region Propiedades
		// -------------------------- CmbTiposDeComprobantes
		public string KeyValueTiposDeComprobates
		{
			get { return "IdTipoDeComprobante" ; }
		}
		public string KeyListTiposDeComprobates
		{
			get { return "Descripcion" ; }
		}
		// --------------------------
		public DataTable TiposComprobanteActual
		{
			get{return _brClass.TiposComprobanteActual;}
		}
		public DataTable TiposComprobanteNuevo
		{
			get{return _brClass.TiposComprobanteNuevo;}
		}
		public string IdTipoComprobanteActual
		{
			get{return _brClass.IdTipoComprobanteActual;}
			set{_brClass.IdTipoComprobanteActual=value;}
		}
		public string IdTipoComprobanteNuevo
		{
			get{return _brClass.IdTipoComprobanteNuevo;}
			set{_brClass.IdTipoComprobanteNuevo=value;}
		}
		public string NroComprobante
		{
			get{return _brClass.NroComprobante;}
			set{_brClass.NroComprobante=value;}
		}
        //Cristian Tarea 0000064 20110317
        public string NroComprobanteNuevo
        {
            get { return _brClass.NroComprobanteNuevo; }
            set { _brClass.NroComprobanteNuevo = value; }
        }
        //Fin Cristian
		#endregion		

		public bool PreguntarAlCancelar
		{
			get {return _brClass.PreguntarAlCancelar;}
		}
	}
}

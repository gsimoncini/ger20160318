using System;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.commontypes;
using mz.erp.businessrules.comprobantes;
using System.Data;
using mz.erp.systemframework;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ConsultarSeguimientoComprasController.
	/// </summary>
	public class ConsultarSeguimientoComprasController : ITaskController
	{
		#region Constructores

		public ConsultarSeguimientoComprasController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public ConsultarSeguimientoComprasController(ConsultarSeguimientoCompras brClass)
		{
			_brClass = brClass;	
			Init();
		}
		#endregion

		#region Metodos Privados
		private void Init()
		{
			string Tarea = this._brClass.GetTaskName();
			string Proceso = this._brClass.GetProcessManagerParent().Process.ProcessName;
			_visualizaDetalle = Variables.GetValueBool(Proceso, Tarea, "VisualizaDetalleComprobantes", _visualizaDetalle);
			_metodoVisualizacion = Variables.GetValueString(Proceso, Tarea,"MetodoVisualizacionDetalle");
			_enabledButtonCuentaCtaCte = Variables.GetValueBool(Proceso, Tarea, "Proveedor.HabilitaBotonCtaCte", _enabledButtonCuentaCtaCte);
		}

		#endregion

		#region Propiedades

		private bool _enabledButtonCuentaCtaCte = true;
		public bool EnabledButtonCuentaCtaCte
		{
			get 
			{
				return  _enabledButtonCuentaCtaCte;
			}				
		}


		public bool VisualizaDetalle
		{
			get{return _visualizaDetalle;}
		}

		public string MetodoVisualizacion
		{
			get{ return _metodoVisualizacion;}
		}

		public System.Data.DataTable Result
		{
			get { return _brClass.Result; }
		}

		/*public string IdProveedor
		{
			get{return _brClass.IdProveedor;}
			set{_brClass.IdProveedor = value;}
		}*/

		public string CodigoProveedor
		{
			get{return _brClass.CodigoProveedor;}
			set{_brClass.CodigoProveedor = value;}
		}


		public DateTime FechaDesde
		{
			get{return _brClass.FechaDesde;}
			set{_brClass.FechaDesde = value;}
		}

		public DateTime FechaHasta
		{
			get{return _brClass.FechaHasta;}
			set{_brClass.FechaHasta = value;}
		}

		public string LeyendaFormulario
		{
			get { return _brClass.LeyendaFormulario ; }
		}
		public bool PreguntarAlCancelar
		{
			get {return _brClass.PreguntarAlCancelar;}
		}
		public string TextoBotonSiguiente
		{
			get 
			{
				return _brClass.TextoBotonSiguiente;
			}
		}

		public string TextoBotonAnterior
		{
			get 
			{
				return _brClass.TextoBotonAnterior;
			}
		}		
		#endregion

		#region Eventos
		public event EventHandler DataChanged;
		#endregion

		#region Variables Privadas						

		private ConsultarSeguimientoCompras _brClass;		
		private bool _visualizaDetalle = false;
		private string _metodoVisualizacion = string.Empty;

		#endregion

		#region Miembros de ITaskController
		public event EventHandler OnTaskAfterExecute;
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
		public string GetTaskName()
		{
			return _brClass.GetTaskName();
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

		public void Previous()
		{
			_brClass.Previous();
		}
		public void Continue()
		{
			_brClass.Execute();
		}

		public ItemsDatasetErrors GetErrors()
		{
			
			return _brClass.GetErrors();				
		}

		public string GetWarnings()
		{
			return _brClass.GetWarnings();
		}

		public void Execute() 
		{													
			this._brClass.Execute();
		}


		public bool AllowShow()
		{
			return _brClass.AllowShow();
		}

		public ITask GetTask()
		{
			return (ITask)this._brClass;
		}
		#endregion

		#region Metodos Publicos
		public void RefreshData()
		{
			_brClass.RefreshData();
			if(DataChanged != null)
				DataChanged(this, new EventArgs());
		}
		public void ResetFechas()
		{
			_brClass.ResetFechas();
		}
        //Cristian Tsrea 0000050 20110310
        public void updateFechas(DateTime fechaDesde)
        {
            _brClass.updateFechas(fechaDesde);
            
        }
        //Fin Cristian	

		#endregion


	}
}

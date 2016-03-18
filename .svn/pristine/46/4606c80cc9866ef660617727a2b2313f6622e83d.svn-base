using System;
using mz.erp.businessrules;
using System.Collections;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ConsultarEstadisticaOrdenReparacionController.
	/// </summary>
	public class ConsultarEstadisticaOrdenReparacionController: ITaskController
	{
		#region Constructores
		public ConsultarEstadisticaOrdenReparacionController(ConsultarEstadisticaOrdenReparacion brClass)
		{
			_brClass = brClass;
			Init();
		}
		#endregion

		#region Variables Privadas

		private ConsultarEstadisticaOrdenReparacion _brClass;
		
		#endregion

		#region Propiedades

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

		public string TextoBotonSiguiente
		{
			get { return _brClass.TextoBotonSiguiente ; }
		}
		
		public string TextoBotonAnterior
		{
			get { return _brClass.TextoBotonAnterior; }
		}


		public System.Data.DataTable Result
		{
			get { return _brClass.Result; }
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

		public bool PorFechaAltaOrdenReparacion
		{
			get{return _brClass.PorFechaAltaOrdenReparacion;}
			set{_brClass.PorFechaAltaOrdenReparacion = value;}
		}

		public bool PorFechaAsignacionATecnico
		{
			get{return _brClass.PorFechaAsignacionATecnico;}
			set{_brClass.PorFechaAsignacionATecnico = value;}
		}

		public bool PorFechaFactura
		{
			get{return _brClass.PorFechaFactura;}
			set{_brClass.PorFechaFactura = value;}
		}

		public bool PorFechaCierre
		{
			get{return _brClass.PorFechaCierre;}
			set{_brClass.PorFechaCierre = value;}
		}

		public bool PorFechaCierreTecnico
		{
			get{return _brClass.PorFechaCierreTecnico;}
			set{_brClass.PorFechaCierreTecnico = value;}
		}

		public decimal TotalTecnicoProvisorio
		{
			get{return _brClass.TotalTecnicoProvisorio;}
			set{_brClass.TotalTecnicoProvisorio = value;}
		}

		public decimal TotalCerrado
		{
			get{return _brClass.TotalCerrado;}
			set{_brClass.TotalCerrado = value;}
		}

		public decimal TotalPorCerrar
		{
			get{return _brClass.TotalPorCerrar;}
			set{_brClass.TotalPorCerrar = value;}
		}

		public System.Data.DataTable EstadosOrdenReparacion
		{
			get {return _brClass.EstadosOrdenReparacion;}
		}

		public string KeyValueEstadosOrdenReparacion
		{
			get { return "IdEstadoOrdenReparacion" ; }
		}

		public string KeyListEstadosOrdenReparacion
		{
			get { return "Descripcion" ; }
		}

		public long IdEstadoOrdenReparacion
		{
			get{return _brClass.IdEstadoOrdenReparacion;}
			set{_brClass.IdEstadoOrdenReparacion = value;}
		}

		public bool EsSupervisorST
		{
			get 
			{
				return _brClass.EsSupervisorST;
			}
		}

		public ArrayList Tecnicos
		{
			get {return _brClass.Tecnicos;}
		}

		public string IdTecnicosSelecionados
		{
			get{return _brClass.IdTecnicosSelecionados;}
			set{_brClass.IdTecnicosSelecionados = value;}
		}

		#endregion

		#region Eventos y delegados		
		public event EventHandler DataChanged;
		#endregion

		#region Métodos  Públicos 
		public void RefreshData()
		{
			_brClass.RefreshData();
		}

		#endregion

		#region Métodos Privados
		private void Init() 
		{
			InitEventHandlers();
			InitData();
		}	

		private void InitData()
		{			
		}

		private void InitEventHandlers()
		{
			_brClass.DataChanged +=new EventHandler(RefreshData);
		}

		private void RefreshData(object sender, EventArgs e)
		{
			if(DataChanged != null)
				DataChanged(this, new EventArgs());
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
			return _brClass.AllowShow();
		}

		public ITask GetTask()
		{
			return (ITask)this._brClass;
		}
			
		#endregion

	}
}

using System;
using System.Data;
using mz.erp.businessrules;
using System.Reflection;
using System.Collections;
using System.Text;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de AbmServicioController.
	/// </summary>
	public class AbmServicioController: ITaskController
	{
		#region Contructores

		public AbmServicioController()
		{
		}
		public AbmServicioController(AbmServicio brClass)
		{
			_brClass = brClass;
			Init();
		}
		#endregion

		#region Variables Privadas 
		private AbmServicio _brClass;
		private bool _allowShow = true;		
		#endregion

		#region Variables Públicas

		#endregion

		#region Propiedades

		public string TextoBotonAnterior
		{
			get 
			{
				return _brClass.TextoBotonAnterior();
			}
		}
		public string TextoBotonSiguiente
		{
			get 
			{
				return _brClass.TextoBotonSiguiente();
			}
		}
		public string LeyendaFormulario
		{
			get 
			{
				return _brClass.LeyendaFormulario();
			}
		}

		public string ContenedoresVisibles
		{
			get{return _brClass.ContenedoresVisibles;}
		}

		public string ContenedoresHabilitados
		{
			get{return _brClass.ContenedoresHabilitados;}
		}

		public long IdServicioSeleccionado
		{
			get{return _brClass.IdServicioSeleccionado;}
			set{_brClass.IdServicioSeleccionado = value;}
		}

		public ArrayList TareasEnBD
		{
			get {return _brClass.TareasEnBD;}
		}

		public string NombreServicio
		{
			get{return _brClass.NombreServicio;}
			set{_brClass.NombreServicio = value;}
		}

		public int DuracionDiasServicio
		{
			get{return _brClass.DuracionDiasServicio;}
			set{_brClass.DuracionDiasServicio = value;}
		}

		public decimal CostoServicio
		{
			get{return _brClass.CostoServicio;}
			set{_brClass.CostoServicio = value;}
		}

		public decimal CostoMaximoServicio
		{
			get{return _brClass.CostoMaximoServicio;}
			set{_brClass.CostoMaximoServicio = value;}
		}

		public decimal CostoPresupuestoServicio
		{
			get{return _brClass.CostoPresupuestoServicio;}
			set{_brClass.CostoPresupuestoServicio = value;}
		}

		public ArrayList TareasServicioSeleccionado
		{
			get {return _brClass.TareasServicioSeleccionado;}
		}

		#endregion

		#region Eventos y delegados		
		public event System.EventHandler TareasHasChanged;
		public event System.EventHandler ServiciosHasChanged;
		public event System.EventHandler TareasServicioHasChanged;
		#endregion

		#region Métodos  Públicos
		/*public string GetLayout() 
		{			
			return (new mz.erp.ui.controllers.st_Servicio( new string[] {"IdServicio", "Codigo", "Nombre", "Estado"}).GetLayoutEx()); 
		}
		*/

		public DataTable ServiciosEnBD()
		{
			return _brClass.ServiciosEnBD();
		}

		public void AddServicio()
		{
			_brClass.AddServicio();
		}

		public void ModificarServicio()
		{
			_brClass.ModificarServicio();
		}

		public void ModificarServicioTarea(Tarea tarea, bool seleccionada)
		{
			_brClass.ModificarServicioTarea(tarea, seleccionada);
		}

		public bool ExisteNombreServicio()
		{
			return _brClass.ExisteNombreServicio();
		}

		public void SaveChanges()
		{
			_brClass.SaveChanges();
		}

        // German 20100826 - tarea 818    
        public bool ExisteAlMenosUnaTarea()
        {
            return _brClass.ExisteAlMenosUnaTarea();
        }

        public bool TotalServicioIgualTotalTareas()
        {
            return _brClass.TotalServicioIgualTotalTareas();
        }
        
        //Fin German 20100826 - tarea 818    
		#endregion

		#region Métodos Privados
		
		private void Init()
		{
			InitializeData();
			InitEvents();
		}

		private void InitializeData()
		{
		}
		
		private void InitEvents()
		{
			this._brClass.TareasHasChanged+=new EventHandler(_brClass_TareasHasChanged);
			this._brClass.ServiciosHasChanged+=new EventHandler(_brClass_ServiciosHasChanged);
			this._brClass.TareasServicioHasChanged+=new EventHandler(_brClass_TareasServicioHasChanged);
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
			// TODO: agregar la implementación ConceptosAdicionalesController.GetErrors
			return _brClass.GetErrors();				
		}

		public string GetWarnings()
		{
			return null;
		}

		public void RefreshData()
		{
			
		}

		public void Execute() 
		{													
			this._brClass.Execute();
		}

		public bool AllowShow()
		{
			return _allowShow;
		}

		public ITask GetTask()
		{
			return (ITask)this._brClass;
		}
			
		#endregion

		private void _brClass_TareasHasChanged(object sender, EventArgs e)
		{
			if(TareasHasChanged != null)
				TareasHasChanged(this, new EventArgs());	
		}
		

		private void _brClass_ServiciosHasChanged(object sender, EventArgs e)
		{
			if(ServiciosHasChanged != null)
				ServiciosHasChanged(this, new EventArgs());	
		}

		private void _brClass_TareasServicioHasChanged(object sender, EventArgs e)
		{
			if(TareasServicioHasChanged != null)
				TareasServicioHasChanged(this, new EventArgs());	
		}
	}
}

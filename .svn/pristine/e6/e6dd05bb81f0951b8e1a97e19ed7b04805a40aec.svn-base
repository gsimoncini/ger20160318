using System;
using System.Data;
using mz.erp.businessrules;
using System.Reflection;
using System.Collections;
using System.Text;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de AbmTareaController.
	/// </summary>
	public class AbmTareaController: ITaskController
	{
		#region Contructores

		public AbmTareaController()
		{
		}

		public AbmTareaController(AbmTarea brClass)
		{
			_brClass = brClass;
			Init();
		}
		#endregion

		#region Variables Privadas 
		private AbmTarea _brClass;
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

		public long IdTareaSeleccionada
		{
			get{return _brClass.IdTareaSeleccionada;}
			set{_brClass.IdTareaSeleccionada = value;}
		}

		public string Descripcion
		{
			get{return _brClass.Descripcion;}
			set{_brClass.Descripcion = value;}
		}

		public string Codigo
		{
			get{return _brClass.Codigo;}
			set{_brClass.Codigo = value;}
		}

		public string IdProducto
		{
			get{return _brClass.IdProducto;}
			set{_brClass.IdProducto = value;}
		}

		public string Complejidad
		{
			get{return _brClass.Complejidad;}
			set{_brClass.Complejidad = value;}
		}

		public decimal Duracion
		{
			get{return _brClass.Duracion;}
			set{_brClass.Duracion = value;}
		}

		public decimal ValorTecnico
		{
			get{return _brClass.ValorTecnico;}
			set{_brClass.ValorTecnico = value;}
		}

		public decimal ValorCliente
		{
			get{return _brClass.ValorCliente;}
			set{_brClass.ValorCliente = value;}
		}

		public decimal ValorTecnicoProvisorio
		{
			get{return _brClass.ValorTecnicoProvisorio;}
			set{_brClass.ValorTecnicoProvisorio = value;}
		}

		public string ListaComplejidades
		{			
			get { return _brClass.ListaComplejidades ; }			
		}
		#endregion

		#region Eventos y delegados		
		public event System.EventHandler TareaSeleccionadaHasChanged;
		public event System.EventHandler TareasHasChanged;
		#endregion

		#region Métodos  Públicos
		public DataTable TareasEnBD()
		{
			return _brClass.TareasEnBD();
		}

		public void AddTarea()
		{
			_brClass.AddTarea();
		}

		public void ModificarTarea()
		{
			_brClass.ModificarTarea();
		}

		public bool ExisteNombreTarea()
		{
			return _brClass.ExisteNombreTarea();
		}

		public void SaveChanges()
		{
			_brClass.SaveChanges();
		}

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
			this._brClass.TareaSeleccionadaHasChanged+=new EventHandler(_brClass_TareaSeleccionadaHasChanged);
			this._brClass.TareasHasChanged+=new EventHandler(_brClass_TareasHasChanged);
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

		private void _brClass_TareaSeleccionadaHasChanged(object sender, EventArgs e)
		{
			if(TareaSeleccionadaHasChanged != null)
				TareaSeleccionadaHasChanged(this, new EventArgs());	
		}

		private void _brClass_TareasHasChanged(object sender, EventArgs e)
		{
			if(TareasHasChanged != null)
				TareasHasChanged(this, new EventArgs());	
		}

	}
}

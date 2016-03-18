using System;
using System.Data;
using System.Collections;
using System.Text;
using mz.erp.businessrules;
using mz.erp.commontypes;
namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ConsultarLibroIVAController.
	/// </summary>
	public class ConsultarLibroIVAController: ITaskController
	{
		public ConsultarLibroIVAController(ConsultarLibroIVA BrClass)
		{
			_brClass = BrClass;
			Init();
		}

		private void Init()
		{
			string Tarea = this._brClass.GetTaskName();
			string Proceso = this._brClass.GetProcessManagerParent().Process.ProcessName;						
			_visualizaDetalle = Variables.GetValueBool(Proceso, Tarea, "VisualizaDetalleComprobantes", _visualizaDetalle);
			_visualizaBotonImprimir = Variables.GetValueBool(Proceso, Tarea, "HabilitaBotonImprimir", _visualizaBotonImprimir);
		}

		#region Propriedades

		
		public bool VisualizaBotonImprimir
		{
			get 
			{				
				return _visualizaBotonImprimir;
			}
		}

		public string LeyendaFormulario
		{
			get { return _brClass.LeyendaFormulario ; }
		}

		public bool PreguntarAlCancelar
		{
			get {return _brClass.PreguntarAlCancelar;}
		}

		public string FechaDesde
		{
			get{return _brClass.FechaDesde;}
			set{_brClass.FechaDesde = value;}
		}

		public string FechaHasta
		{
			get{return _brClass.FechaHasta;}
			set{_brClass.FechaHasta = value;}
		}

		#endregion

		#region Variables Privadas
							
		private bool _visualizaDetalle = false;
		private bool _visualizaBotonImprimir = false;
		private ConsultarLibroIVA _brClass;
				
		
						
		#endregion
		public DataTable RefreshData()
		{
			return _brClass.RefreshData();
		}


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
	}
}

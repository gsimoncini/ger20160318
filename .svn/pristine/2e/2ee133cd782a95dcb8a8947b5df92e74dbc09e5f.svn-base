using System;
using mz.erp.businessrules;
using System.Collections;
using System.Data;
//using System.Text.RegularExpressions;
using System.Text;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de SeleccionarInstanciaOrdenReparacionController.
	/// </summary>
	public class SeleccionarInstanciaOrdenReparacionController : ITaskController
	{
		
		#region Constructores

		public SeleccionarInstanciaOrdenReparacionController(SeleccionarInstanciaOrdenReparacion brClass)
		{
			_brClass = brClass;
			Init();
			
		}


		#endregion
		
		#region Variables Privadas


			SeleccionarInstanciaOrdenReparacion _brClass;
			private string _layout = string.Empty;

		#endregion

		#region Variables Publicas

		public object SelectedItem
		{
			set{ _brClass.SelectedItem = value;}
		}

		public string Layout
		{
			get{return _layout;}
		}


		public InstanciasOrdenReparacion InstanciasOrdenReparacion
		{
			get{return _brClass.InstanciasOrdenReparacion;}
		}
		
		#endregion


		#region Metodos Privados

		private void Init()
		{
			InitData();
			InitEventHandlers();
		}

		private void InitData()
		{
			_layout = Build_LayoutDetalleDisponible();	
		}


		private void InitEventHandlers()
		{
		}

		private string Build_LayoutDetalleDisponible()
		{			
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );			
			sb.Append( LayoutBuilder.GetRow( i++, "IdInstanciaOrdenReparacion", "IdInstanciaOrdenReparacion",80 ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Tecnico", "Tecnico",500, Types.EditType.NoEdit ) );
			sb.Append( LayoutBuilder.GetRow( i++, "IdTecnico", "IdTecnico",100, true ) );
			
			sb.Append( LayoutBuilder.GetFooter() );
			return sb.ToString();		
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
		public string GetTaskName()
		{
			return _brClass.GetTaskName();
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
			return _brClass.AllowShow();
		}

		public ITask GetTask()
		{
			return (ITask)this._brClass;
		}
		#endregion

		public bool PreguntarAlCancelar
		{
			get {return _brClass.PreguntarAlCancelar;}
		}
	}
}

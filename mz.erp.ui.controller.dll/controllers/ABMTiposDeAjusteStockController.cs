using System;
using mz.erp.businessrules;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ABMTiposDeAjusteStockController.
	/// </summary>
	public class ABMTiposDeAjusteStockController:ITaskController
	{
		public ABMTiposDeAjusteStockController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public ABMTiposDeAjusteStockController(ABMTiposDeAjusteStock model)
		{
			_brClass = model;
			Init();
		}

		private void Init()
		{
		}

		#region Variables Privadas

		private ABMTiposDeAjusteStock _brClass;
		private ProcessControllerManager _processManager;


		#endregion

		#region Propiedades

		public string IdTipoAjusteStock
		{
			get{return _brClass.IdTipoAjusteStock;}
			set 
			{
				_brClass.IdTipoAjusteStock = value;
			}
		}

		public string IdEstadoDeStock
		{
			get{return _brClass.IdEstadoDeStock;}
			set 
			{
				_brClass.IdEstadoDeStock = value;
			}
		}

		public string Descripcion
		{
			get{return _brClass.Descripcion;}
			set 
			{
				_brClass.Descripcion = value;
			}
		}

		public short Operacion
		{
			get {return _brClass.Operacion;}
			set
			{
				_brClass.Operacion = value;
			}
		}

		public bool Sistema
		{
			get{return _brClass.Sistema;}
			set 
			{
				_brClass.Sistema = value;
			}
		}

		public bool Activo
		{
			get{return _brClass.Activo;}
			set 
			{
				_brClass.Activo = value;
			}
		}

		public bool AfectaSeguimientoArticulosFisico
		{
			get{return _brClass.AfectaSeguimientoArticulosFisico;}
			set 
			{
				_brClass.AfectaSeguimientoArticulosFisico = value;
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

		public string LeyendaFormulario
		{
			get{return _brClass.LeyendaFormulario;}
		}

		public bool PreguntarAlCancelar
		{
			get {return _brClass.PreguntarAlCancelar;}
		}

		public bool PerteneceAPerfilSuperior
		{
			get {return _brClass.PerteneceAPerfilSuperior;}
		}

		#endregion

		#region Miembros de ITaskController

		public string GetWarnings()
		{
			return null;
		}

		public void Continue()
		{
			
		}

		public mz.erp.businessrules.ItemsDatasetErrors GetErrors()
		{
			return _brClass.GetErrors();
		}

		public void Execute()
		{
			_brClass.Execute();
		}

		public void Previous()
		{
			_brClass.Previous();
		}

		public bool AllowShow()
		{
			return _brClass.AllowShow();
		}

		public bool AllowPrevious()
		{
			return false;
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

		public string GetProcessName()
		{
			return _processManager.GetProcessName();
		}
        
		public bool IsFirstTask()
		{
			
			return _processManager.IsFirstTask(_brClass.GetTaskName());
		}

		public bool IsNextState()
		{
			return _processManager.IsNextState();
		}

		public bool IsBackState()
		{
			return _processManager.IsBackState();
		}

		public bool IsFlushedState()
		{
			return false;
		}
		#endregion
	}
}

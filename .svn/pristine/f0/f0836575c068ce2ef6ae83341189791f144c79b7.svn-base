using System;
using System.Data;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.ui.controllers;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de MovimientosDeCajaController.
	/// </summary>
	public class MovimientosDeCajaController: ITaskController	
	{
		private mz.erp.businessrules.MovimientosCaja _brClass;
		public event System.EventHandler OnControllerHasChanged;
		public event System.EventHandler OnTaskAfterExecute;
		public MovimientosDeCajaController(mz.erp.businessrules.MovimientosCaja brClass)
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			this._brClass = brClass;
			Init();
		}
		public string IdTipo
		{
			get { return _brClass.IdTipo ; }
			set { _brClass.IdTipo = value ; }
		}
		public string IdCaja
		{
			get { return _brClass.IdCaja ;}
			set 
			{
				_brClass.IdCaja = value; 
			}
		}
		public DataTable FiltroCajas
		{
			get { return _brClass.FiltroCajas; }
			set { _brClass.FiltroCajas = value ; }
		}
		public DataTable FiltroTiposMovimientos
		{
			get { return _brClass.FiltroTiposMovimientos ; }
			set { _brClass.FiltroTiposMovimientos=value ; }
		}
		public string Observaciones
		{
			get { return _brClass.Observaciones ; }
			set { _brClass.Observaciones=value; }
		}
		public decimal Total
		{
			get { return 0; }
		}
		public System.DateTime Fecha
		{
			get { return _brClass.Fecha; }
		}

		public ArrayList Valores
		{
			get { return _brClass.Valores ;}
			set { _brClass.Valores=value; }
		}
		public bool AllowEditCajas
		{
			get { return _brClass.AllowEditCaja; }
		}
		public bool AllowEditTiposDeMovimiento
		{
			get { return _brClass.AllowEditTipoDeMovimiento ; }
		}
		
	//	public bool 
		#region Miembros de ITaskController

		public ItemsDatasetErrors GetErrors()
		{
			return _brClass.GetErrors();
		}
		public string GetWarnings()
		{
			return _brClass.GetWarnings();
		}
		public void Continue()
		{
		}

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}



		public void Execute()
		{
			// TODO: agregar la implementación MovimientosDeCajaController.Execute
		}

		public bool AllowShow()
		{
			// TODO: agregar la implementación MovimientosDeCajaController.AllowShow
			return false;
		}

		public bool AllowPrevious()
		{
			// TODO: agregar la implementación MovimientosDeCajaController.AllowPrevious
			return false;
		}

		public void Previous()
		{
			// TODO: agregar la implementación MovimientosDeCajaController.Previous
		}

		public void SetProcessManager(ProcessControllerManager processManager)
		{
			_process = processManager;
		}
		ProcessControllerManager _process;
		public ProcessControllerManager GetProcessManager()
		{
			return _process;
			
		}

		public bool IsFirstTask()
		{
			// TODO: agregar la implementación MovimientosDeCajaController.IsFirstTask
			return false;
		}

		public bool IsNextState()
		{
			// TODO: agregar la implementación MovimientosDeCajaController.IsNextState
			return false;
		}

		public bool IsBackState()
		{
			// TODO: agregar la implementación MovimientosDeCajaController.IsBackState
			return false;
		}

		public bool IsFlushedState()
		{
			// TODO: agregar la implementación MovimientosDeCajaController.IsFlushedState
			return false;
		}

		#endregion
		private void Init()
		{
			_brClass.ObjectHasChanged+= new System.EventHandler( this.ListenerBusinessObjectChanged );
		}
		private void ListenerBusinessObjectChanged ( object sender, System.EventArgs e)
		{

		}

		
	}
}

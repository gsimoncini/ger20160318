using System;
using System.Collections.Generic;
using System.Text;
using mz.erp.businessrules;

namespace mz.erp.ui.controllers
{
    public class ConsultarSeguimientoAcopioController: ITaskController
    {

        public ConsultarSeguimientoAcopioController(ConsultarSeguimientoAcopio task)
		{
			_task = task;
			Init();

		}

		private void Init()
		{
			InitEvents();
		}

		private void InitEvents()
		{
			this._task.OnTaskAfterExecute +=new EventHandler(AfterExecute);
		}

		private ConsultarSeguimientoAcopio _task;

		public event EventHandler OnTaskAfterExecute;

		#region Miembros de ITaskController

		public bool IsFlushedState()
		{
			return this._processManager.ProcessFlushed;
		}

		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_task.GetTaskName());
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

		public string GetTaskName()
		{
			return _task.GetTaskName();
		}


		public bool AllowPrevious()
		{
			return _task.AllowPrevious();
		}

		public void Previous()
		{
			_task.Previous();
		}


		public mz.erp.businessrules.ItemsDatasetErrors GetErrors()
		{
			return _task.GetErrors();
		}
		public string GetWarnings()
		{
			return null;
		}
		public void Continue()
		{
		}


		public void Execute()
		{
			this._task.Execute();
		}

		public bool AllowShow()
		{
			
			return _task.AllowShow();
		}

		#endregion

		private void AfterExecute(object sender, EventArgs e)
		{
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}

		public bool IsNextState()
		{
			return this._processManager.IsNextState();	
		}

		public bool IsBackState()
		{	
			return this._processManager.IsBackState();
		}


        public string CodigoCuenta
        {
            get { return _task.CodigoCuenta; }
            set { _task.CodigoCuenta = value; }
        }

        public DateTime FechaDesde
        {
            get { return _task.FechaDesde; }
            set { _task.FechaDesde = value; }
        }

        public DateTime FechaHasta
        {
            get { return _task.FechaHasta; }
            set { _task.FechaHasta = value; }
        }

        public System.Data.DataTable Result
        {
            get { return _task.Result; }
        }

        public System.Data.DataTable ResultDetalleAcopio
        {
            get { return _task.ResultDetalleAcopio; }
        }

        public void RefreshData()
        {
            _task.RefreshData();

        }

        public void RefreshDataDetalleAcopio(string IdComprobante)
        {
            _task.RefreshDataDetalleAcopio(IdComprobante);

        }


    }
}

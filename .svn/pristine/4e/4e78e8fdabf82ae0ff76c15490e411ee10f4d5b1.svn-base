//Matias 20110422 - Tarea 0000061
using System;
using System.Data;
using System.Text;
using System.Collections;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

namespace mz.erp.ui.controllers
{
    public class ConsultarActualizacionAlicuotasIIBBController : ITaskController
    {
        public ConsultarActualizacionAlicuotasIIBBController()
        {
            //
            // TODO: agregar aquí la lógica del constructor
            //
        }

        public ConsultarActualizacionAlicuotasIIBBController(ConsultarActualizacionAlicuotasIIBB BrClass)
        {
            _brClass = BrClass;
            Init();
        }

        #region Miembros de ITaskController

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

        public string GetTaskName()
        {
            return _brClass.GetTaskName();
        }

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
            _brClass.Execute();
        }

        public void Execute()
        {
            _brClass.Execute();
        }

        public bool AllowShow()
        {
            return _brClass.AllowShow();
        }

        #endregion

        #region Variables Privadas

        private ConsultarActualizacionAlicuotasIIBB _brClass;
        private ProcessControllerManager _processManager;
        private string _taskName = string.Empty;
        private string _processName = string.Empty;
        private ITaskController _taskController;
        private string _taskControllerName = string.Empty;
        private string _taskControllerProcessName = string.Empty;
        private string _leyendaFormulario = string.Empty;

        #endregion

        #region metodos privados
        private void Init()
        {
            SetLeyendaFormulario();
            InitEventHandlers();
        }

        private void InitEventHandlers()
        {
            _brClass.DataChanged += new EventHandler(RefreshData);
        }

        private void RefreshData(object sender, EventArgs e)
        {
            if (DataChanged != null)
                DataChanged(this, new EventArgs());
        }

        private void SetLeyendaFormulario()
        {
            string leyenda = Variables.GetValueString(this._brClass.GetProcessManagerParent().Process.ProcessName, this._brClass.GetTaskName(), "LeyendaFormulario");
            if (leyenda.Equals(string.Empty))
                leyenda = this._brClass.GetTaskName();
            this._leyendaFormulario = leyenda;
        }

        #endregion

        #region Eventos
        public event System.EventHandler DataChanged;
        #endregion

        #region Propiedades
        public string LeyendaFormulario
        {
            get { return this._leyendaFormulario; }
        }
        public long IdProcess
        {
            get { return _brClass.IdProcess; }
        }
        public long IdTask
        {
            get { return _brClass.IdTask; }
        }
        public string ProcessName
        {
            get { return _brClass.ProcessName; }
        }
        public string TaskName
        {
            get { return _brClass.TaskName; }
        }
        public bool PreguntarAlCancelar
        {
            get { return _brClass.PreguntarAlCancelar; }
        }
        public bool PreguntarAlGuardar
        {
            get { return _brClass.PreguntarAlGuardar; }
        }
        public string IdCuenta
        {
            get { return _brClass.IdCuenta; }
            set { _brClass.IdCuenta = value; }
        }
        public string IdProveedor
        {
            get { return _brClass.IdProveedor; }
            set { _brClass.IdProveedor = value; }
        }
        public string CodigoCuenta
        {
            get { return _brClass.CodigoCuenta; }
            set { _brClass.CodigoCuenta = value; }
        }
        public string CodigoProveedor
        {
            get { return _brClass.CodigoProveedor; }
            set { _brClass.CodigoProveedor = value; }
        }        
        public DateTime FechaDesde
        {
            get { return _brClass.FechaDesde; }
            set { _brClass.FechaDesde = value; }
        }
        public DateTime FechaHasta
        {
            get { return _brClass.FechaHasta; }
            set { _brClass.FechaHasta = value; }
        }
        public DateTime FechaDesdeOrig
        {
            get { return _brClass.FechaDesdeOrig; }
            set { _brClass.FechaDesdeOrig = value; }
        }
        public DateTime FechaHastaOrig
        {
            get { return _brClass.FechaHastaOrig; }
            set { _brClass.FechaHastaOrig = value; }
        }
        public System.Data.DataTable Result
        {
            get { return _brClass.Result; }
        }
        #endregion

        #region Metodos Publicos
        public void SearchNow()
        {
            _brClass.SearchNow();
            if (DataChanged != null)
                DataChanged(this, new EventArgs());
        }
        public void ResetFilters()
        {
            _brClass.ResetFilters();
        }
        #endregion
    }
}


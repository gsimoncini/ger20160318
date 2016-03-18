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
    public class IngresarPadronARBAController : ITaskController
    {
        public IngresarPadronARBAController()
        {
            //
            // TODO: agregar aquí la lógica del constructor
            //
        }

        public IngresarPadronARBAController(IngresarPadronARBA BrClass)
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

        private IngresarPadronARBA _brClass;
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
            //_brClass.ObjectHasChanged += new EventHandler(Refresh);            
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
        //public event EventHandler ProductosCollectionChanged;
        //public event EventHandler ObjectHasChanged;
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
        public bool PreguntarAlCancelar
        {
            get { return _brClass.PreguntarAlCancelar; }
        }
        public bool PreguntarAlGuardar
        {
            get { return _brClass.PreguntarAlGuardar; }
        }
        public string FilePath
        {
            get { return _brClass.FilePath; }
            set { _brClass.FilePath = value; }
        }
        #endregion

        #region Metodos Publicos

        #endregion
    }
}


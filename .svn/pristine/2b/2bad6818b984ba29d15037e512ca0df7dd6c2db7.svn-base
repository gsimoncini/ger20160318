//Matias 20110422 - Tarea 0000061
using System;
using System.Data;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.businessrules.comprobantes;
using System.Text;
using System.IO;

namespace mz.erp.businessrules
{
    public class ConsultarActualizacionAlicuotasIIBB : ITask, IPersistentTask
    {
        public ConsultarActualizacionAlicuotasIIBB()
        {
            //
            // TODO: agregar aquí la lógica del constructor
            //
        }

        #region Variables Privadas
        public string _taskName = string.Empty;
        public string _processName = string.Empty;
        private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
        private ProcessManager _processParent;
        private bool _preguntarAlCancelar = false;
        private bool _preguntarAlGuardar = false;
        private bool _allowShow = true;
        private bool _mostrarWarning = false;

        private string _codigoCuenta = string.Empty;
        private string _codigoProveedor = string.Empty; 
        private string _idCuenta = string.Empty;
        private string _idProveedor = string.Empty;
        private DateTime _fechaDesde = mz.erp.businessrules.Sistema.DateTime.Now;
        private DateTime _fechaHasta = mz.erp.businessrules.Sistema.DateTime.Now;
        private DateTime _fechaDesdeOrig = mz.erp.businessrules.Sistema.DateTime.Now;
        private DateTime _fechaHastaOrig = mz.erp.businessrules.Sistema.DateTime.Now;

        private DataTable _result = new DataTable();

        #endregion

        #region Miembros de ITask

        public event System.EventHandler ObjectHasChanged;
        public event System.EventHandler OnTaskBeforeExecute;
        public event System.EventHandler OnTaskAfterExecute;
        public event System.EventHandler OnTaskBeforePrevious;
        public event System.EventHandler OnTaskAfterPrevious;

        public virtual void Previous()
        {
            if (OnTaskBeforePrevious != null)
                OnTaskBeforePrevious(this, new EventArgs());
            if (OnTaskAfterPrevious != null)
                OnTaskAfterPrevious(this, new EventArgs());
        }

        public virtual bool AllowPrevious()
        {
            return true;
        }

        public void ListenerAfterPreviousDependentTask(object sender)
        {
        }

        public void ListenerBeforePreviousDependentTask(object sender)
        {
        }

        public void ListenerTaskDependentChanged(object sender)
        {
        }

        public void ListenerAfterExecuteDependentTask(object sender)
        {

        }

        public void ListenerBeforeExecuteDependentTask(object sender)
        {

        }

        public bool IsValidForStartProcess()
        {
            _errores.Clear();
            WorkflowValidator validator = new WorkflowValidator();
            long IdTarea = Workflow.GetIdTakByName(_taskName);
            bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess, IdTarea, this);
            _errores.AddAll(validator.GetErrors());
            return IsValid;
        }

        public virtual bool IsValid()
        {
            ValidarDatos();
            if (_errores.Count > 0)
                return false;
            else
                return true;
        }

        public void Init()
        {
            this._allowShow = Variables.GetValueBool(this._processName, this._taskName, "AllowShow", true);
            this._preguntarAlGuardar = Variables.GetValueBool(this._processName, this._taskName, "PreguntarAlGuardar");
            this._preguntarAlCancelar = Variables.GetValueBool(this._processName, this._taskName, "PreguntarAlCancelar");
            this.MostrarWarning = Variables.GetValueBool(this._processName, this._taskName, "MostrarWarning", false);
            long cantDiasDesde = (!Variables.GetValueLong(_processName, _taskName, "RangoFechas.DiasAnteriores").Equals(long.MinValue)) ? (Variables.GetValueLong(_processName, _taskName, "RangoFechas.DiasAnteriores")) : 0;
            this.FechaDesde = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-cantDiasDesde);
            this.FechaDesdeOrig = this.FechaDesde;
            this.FechaHasta = mz.erp.businessrules.Sistema.DateTime.Now;
            this.FechaHastaOrig = this.FechaHasta;
            this.IdCuenta = string.Empty;
            this.CodigoCuenta = string.Empty;
            this.IdProveedor = string.Empty;
            this.CodigoProveedor = string.Empty;

        }

        public bool AllowShow()
        {
            return _allowShow;
        }
        public void FormHasClosed()
        {
        }

        public ItemsDatasetErrors GetErrors()
        {
            return _errores;
        }

        public string GetWarnings()
        {
            if (this.MostrarWarning)
            {

            }
            return null;
        }

        public ProcessManager GetProcessManagerParent()
        {

            return _processParent;
        }

        public void SetProcessManagerParent(ProcessManager processManager)
        {
            _processParent = processManager;
            _processName = _processParent.Process.ProcessName;
        }

        public string GetTaskName()
        {

            return _taskName;
        }

        public void SetTaskName(string taskName)
        {
            _taskName = taskName;
        }

        public void Execute()
        {
            if (OnTaskBeforeExecute != null)
                OnTaskBeforeExecute(this, new EventArgs());
            this.IsValid();
            if (OnTaskAfterExecute != null)
                OnTaskAfterExecute(this, new EventArgs());
        }

        #endregion

        #region Miembros de IPersistentTask

        public event System.EventHandler OnTaskBeforeFlush;
        public event System.EventHandler OnTaskAfterFlush;

        private mz.erp.commontypes.SentenciasReplicacion _replication;
        public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
        {
            return _replication;
        }
        private mz.erp.commontypes.SentenciasReplicacion GenerateReplication()
        {
            mz.erp.commontypes.SentenciasReplicacion replication = new mz.erp.commontypes.SentenciasReplicacion();
            replication.IdConexion = Security.IdConexion;
            replication.SucGeneradora = Security.IdSucursal;
            //Para todas las sucursales
            replication.Destino = null;
            replication.VersionBD = null;
            replication.NombreTabla = "dataaccess.sy_Usuarios";
            return replication;
        }

        private bool _hasSaved = false;
        public bool GetHasSaved()
        {
            return _hasSaved;
        }

        public void PutExtraData(ProcessCollectionData _processCollectionData)
        {
        }

        public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
        {
        }

        public ArrayList GetDataList()
        {
            ArrayList array = new ArrayList();
            return array;
        }

        public TaskCollectionData GetData()
        {
            TaskCollectionData data = new TaskCollectionData();
            data.TaskName = this.GetTaskName();
            return data;
        }

        /// <summary>
        /// Envia el dataset e información adicional a la capa de acceso a datos para ejecutar la grabación de datos
        /// en el RDBM.
        /// </summary>
        public void Commit()
        {
            
        }

        public void Flush(string IdTransaction)
        {
            
        }

        #endregion

        #region Metodos Privados

        private void ValidarDatos()
        {
            _errores.Clear();
        }

        #endregion

        #region Propiedades
        public string ProcessName
        {
            get { return _processName; }
        }
        public string TaskName
        {
            get { return _taskName; }
        }
        public long IdProcess
        {
            get { return Workflow.GetIdProcessByName(this.ProcessName); }
        }
        public long IdTask
        {
            get { return Workflow.GetIdProcessByName(this.TaskName); }
        }
        public bool PreguntarAlCancelar
        {
            get { return _preguntarAlCancelar; }
        }
        public bool PreguntarAlGuardar
        {
            get { return _preguntarAlGuardar; }
        }
        public bool MostrarWarning
        {
            get { return _mostrarWarning; }
            set { _mostrarWarning = value; }
        }
        public string CodigoCuenta
        {
            get { return _codigoCuenta; }
            set 
            {
                _codigoCuenta = value;
                this.IdCuenta = string.Empty;
                if (_codigoCuenta != null && !_codigoCuenta.Equals(string.Empty))
                {
                    Cuenta cuenta = new Cuenta();
                    cuenta.GetCuenta_CodigoCuenta(_codigoCuenta);
                    this.IdCuenta = cuenta.IdCuenta;
                }
            }
        }
        public string CodigoProveedor
        {
            get { return _codigoProveedor; }
            set 
            { 
                _codigoProveedor = value;
                this.IdProveedor = string.Empty;
                if (_codigoProveedor != null && !_codigoProveedor.Equals(string.Empty))
                {
                    Proveedor prov = new Proveedor();
                    prov.GetCuenta_CodigoProveedor(_codigoProveedor);
                    this.IdProveedor = prov.IdProveedor;
                }
            }
        }
        public string IdCuenta
        {
            get { return _idCuenta; }
            set{_idCuenta = value;}
        }
        public string IdProveedor
        {
            get { return _idProveedor; }
            set {_idProveedor = value;}
        }
        public DateTime FechaDesde
        {
            get { return _fechaDesde; }
            set { _fechaDesde = value; }
        }
        public DateTime FechaHasta
        {
            get { return _fechaHasta; }
            set { _fechaHasta = value; }
        }
        public DateTime FechaDesdeOrig
        {
            get { return _fechaDesdeOrig; }
            set { _fechaDesdeOrig = value; }
        }
        public DateTime FechaHastaOrig
        {
            get { return _fechaHastaOrig; }
            set { _fechaHastaOrig = value; }
        }
        public System.Data.DataTable Result
        {
            get { return _result; }
        }
        #endregion

        #region Eventos
        public event System.EventHandler DataChanged;
        #endregion

        #region Metodos Publicos
        public void SearchNow()
        {
            // Ejecuta consulta de actualizacion de alicuotas de IIBB, tanto de Clientes como de Proveedores.
            // En caso que IdCuenta y IdProveedor==string.Empty --> busca TODOS los Clientes y Proveedores actualizados en el ultimo padron procesado.
            _result = tsa_CuentasPadronesARBA.GetListActualizacionAlicuotasIIBBMasProveedores(this.IdCuenta, this.IdProveedor, this.FechaDesde, this.FechaHasta);
            if (this.DataChanged != null)
                this.DataChanged(this, new System.EventArgs());
        }
        public void ResetFilters()
        {
            this.Init();
        }
        #endregion
    }
}

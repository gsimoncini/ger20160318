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
    public class IngresarPadronARBA : ITask, IPersistentTask
    {
        public IngresarPadronARBA()
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

        private string _filePath = string.Empty;
        private bool _validarFormato = false;
        private bool _validarActualizacionMensual = false;
        private bool _validarActualizacionMasReciente = false;
        private DateTime _fechaPadron = mz.erp.businessrules.Sistema.DateTime.Now;

        //private DataTable _dataVariables = new sy_VariablesDataset().sy_Variables;
        //private DataTable _dataProductosAux = new tsh_ProductosAuxiliaresDataset().tsh_ProductosAuxiliares;
        
        
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
            this.ValidarFormato = Variables.GetValueBool(this._processName, this._taskName, "ValidarFormato", false);
            this.ValidarActualizacionMensual = Variables.GetValueBool(this._processName, this._taskName, "ValidarActualizacionMensual", false);
            this.ValidarActualizacionMasReciente = Variables.GetValueBool(this._processName, this._taskName, "ValidarActualizacionMasReciente", false);

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
             //No hay Commit --> la actualización se realiza directamente en la BD.           
        }

        public void Flush(string IdTransaction)
        {
            // Actualiza todo dentro del SP.
            tsh_PadronesARBA.UpdateAlicuotasDesdePadron(this.FilePath, IdTransaction);
        }

        #endregion

        #region Metodos Privados

        private void ValidarDatos()
        {
            _errores.Clear();
            if (FilePath.Equals(string.Empty) || FilePath=="")
            {
                _errores.Add(new ItemDatasetError("Archivo Origen", "Vacio", "No ha seleccionado el archivo origen."));
            }
            if (_errores.Count == 0) //Significa que hay un archivo seleccionado.
            {
                if (ValidarFormato && !EsFormatoValido())
                {
                    _errores.Add(new ItemDatasetError("Archivo Origen", "Formato", "El archivo seleccionado no contiene un formato válido."));
                }

                if (ValidarActualizacionMensual && !EsFechaValida()) //Valida que solo se realize una actualización mensual.
                {
                    _errores.Add(new ItemDatasetError("Archivo Origen", "Fecha", "El período del archivo seleccionado ya fué procesado."));
                }

                if (ValidarActualizacionMasReciente && !EsFechaMasReciente()) //Valida que no exista una actualización mensual mas reciente.
                {
                    _errores.Add(new ItemDatasetError("Archivo Origen", "Fecha", "El período del archivo seleccionado es inferior al actual procesado."));
                }
            }
        }

        private bool EsFormatoValido()
        {
            // Valida el formato del archivo ingresado (toman una muestra de las primeras 100 filas).
            // La validación solo intenta detectar cantidad de columnas distintas a las informadas por ARBA.
            StreamReader sr = new StreamReader(FilePath);
            string strline = string.Empty;
            string[] _values = null;
            int x = 0;
            while (x<100 && !sr.EndOfStream)
            {
                x++;
                strline = sr.ReadLine();
                _values = strline.Split(';'); // Separador del arhivo enviado por ARBA (11 registros separados por ";" con 60 carac de ancho.                    
                if (strline.Length != 60 || _values.Length != 11)
                {
                    sr.Close();
                    return false; //Formato inválido
                }
            }
            this.FechaPadron = Convert.ToDateTime(_values[0].Substring(0, 2) + "/" + _values[0].Substring(2, 2) + "/" + _values[0].Substring(4, 4));
            sr.Close();
            return true; //Formato válido.
        }

        private bool EsFechaValida()
        {
            // Valida que la Fecha de Publicacion del archivo no sea la misma que la ultima registrada en el sistema (esto es para evitar ejecutar este proceso mas de una vez!)
            DateTime fechaPublicacionUltimaActualizacion = mz.erp.systemframework.Util.GetStartDay(mz.erp.businessrules.Sistema.DateTime.Now);
            tsh_PadronesARBADataset.tsh_PadronesARBARow rowPA = tsh_PadronesARBA.GetFechaPublicacionDeUltimaActualizacion();
            if (rowPA != null)
            {
                fechaPublicacionUltimaActualizacion = rowPA.FechaPublicacion;
                if (this.FechaPadron.Equals(fechaPublicacionUltimaActualizacion))
                    return false;
            }
            return true;
        }

        private bool EsFechaMasReciente()
        {
            // Valida que la Fecha de Publicacion del archivo no sea inferior a la ultima registrada en el sistema (esto es para evitar actualizar alicuotas deprecated)
            DateTime fechaPublicacionUltimaActualizacion = mz.erp.systemframework.Util.GetStartDay(mz.erp.businessrules.Sistema.DateTime.Now);
            tsh_PadronesARBADataset.tsh_PadronesARBARow rowPA = tsh_PadronesARBA.GetFechaPublicacionDeUltimaActualizacion();
            if (rowPA != null)
            {
                fechaPublicacionUltimaActualizacion = rowPA.FechaPublicacion;
                if (this.FechaPadron > fechaPublicacionUltimaActualizacion) //La fecha del padron a ingesar es mayor a la mas reciente de la BD.
                    return true;
                else
                    return false;
            }
            return true; //no existen padrones procesados!
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
        public bool ValidarFormato
        {
            get { return _validarFormato; }
            set { _validarFormato = value; }
        }
        public bool ValidarActualizacionMensual
        {
            get { return _validarActualizacionMensual; }
            set { _validarActualizacionMensual = value; }
        }
        public bool ValidarActualizacionMasReciente
        {
            get { return _validarActualizacionMasReciente; }
            set { _validarActualizacionMasReciente = value; }
        }
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }
        public DateTime FechaPadron
        {
            get { return _fechaPadron; }
            set { _fechaPadron = value; }
        }
        #endregion

        #region Eventos
        
        #endregion

        #region Metodos Publicos
                
        #endregion
    }
}

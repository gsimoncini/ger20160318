/* Silvina 20111104 - Tarea 0000222 */
using System;
using System.Data;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{
    public class AbmProductosCategoriasCuentas: ITask, IPersistentTask
    {
        #region Variables Privadas

        private ProcessManager _processParent;
        private string _taskName;
        private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
        private SentenciasReplicacion _sentencia;

        private tsh_ProductosListasDePreciosCategoriasCuentasDataset _data = new mz.erp.commontypes.data.tsh_ProductosListasDePreciosCategoriasCuentasDataset();
        private string _leyendaFormulario = string.Empty;
        private bool _preguntarAlCancelar = false;
        private string _etiquetaCuentas = string.Empty;
        private string _etiquetaProductos = string.Empty;
        private string _jerarquiaCuentas = string.Empty;
        private string _jerarquiaProductos  = string.Empty;
        private string _idListaDePrecios = string.Empty;
        private string _listaDePrecios = string.Empty;
        private ArrayList _itemsJerarquiasCuenta;
        private ArrayList _itemsJerarquiasProducto;
        private ArrayList _tabla = new ArrayList();
        private ArrayList _eliminados = new ArrayList();
 
        #endregion

        public AbmProductosCategoriasCuentas()
		{

		}

        #region Propiedades

        public string LeyendaFormulario
        {
            get {return _leyendaFormulario;}
        }

        public bool PreguntarAlCancelar
        {
            get {return _preguntarAlCancelar;}
        }

        public string EtiquetaCuentas
        {
            get { return _etiquetaCuentas; }
        }

        public string EtiquetaProductos
        {
            get { return _etiquetaProductos; }
        }

        public string JerarquiaCuentas
        {
            get { return _jerarquiaCuentas; }
        }

        public string JerarquiaProductos
        {
            get { return _jerarquiaProductos; }
        }

        public string IdListaDePrecios
        {
            get { return _idListaDePrecios; }
            set { _idListaDePrecios = value; }
        }

        public string ListaDePrecios
        {
            get { return _listaDePrecios; }
            set { _listaDePrecios = value; }
        }

        public ArrayList ItemsJerarquiasCuenta
        {
            get { return _itemsJerarquiasCuenta; }
            set { _itemsJerarquiasCuenta = value; }
        }

        public ArrayList ItemsJerarquiasProducto
        {
            get { return _itemsJerarquiasProducto; }
            set { _itemsJerarquiasProducto = value; }
        }

        public ArrayList Tabla
        {
            get { return _tabla; }
            set { _tabla = value; }
        }

        #endregion

        #region Miembros de ITask

        public event System.EventHandler ObjectHasChanged;

        public event System.EventHandler DataChanged;

        public event System.EventHandler OnTaskBeforeExecute;

        public event System.EventHandler OnTaskAfterExecute;

        public event System.EventHandler OnTaskBeforePrevious;
        public event System.EventHandler OnTaskAfterPrevious;

        public void Previous()
        {
            if (OnTaskBeforePrevious != null)
                OnTaskBeforePrevious(this, new EventArgs());
            if (OnTaskAfterPrevious != null)
                OnTaskAfterPrevious(this, new EventArgs());
        }

        public bool AllowPrevious()
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

        public void Init()
        {
            string proceso = _processParent.Process.ProcessName;
            _preguntarAlCancelar = Variables.GetValueBool(proceso, _taskName, "PreguntarAlCancelar");
            string valor = String.Empty;
            valor = Variables.GetValueString(proceso, _taskName, "LeyendaFormulario");
            if (valor != String.Empty)
                _leyendaFormulario = valor;
            _etiquetaProductos = Variables.GetValueString("Productos.Categorias.Etiqueta");
            _etiquetaCuentas = Variables.GetValueString("Cuentas.Categorias.Etiqueta");
            _jerarquiaCuentas = Variables.GetValueString("Cuentas.Categorias.JerarquiaAsociada");
            _jerarquiaProductos = Variables.GetValueString("Productos.Categorias.JerarquiaAsociada");
            _tabla = tsh_ProductosListasDePreciosCategoriasCuentas.GetListEx();
        }


        public bool IsValidForStartProcess()
        {
            _errores.Clear();
            WorkflowValidator validator = new WorkflowValidator();
            long IdTarea = Workflow.GetIdTakByName(_taskName);
            bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess, IdTarea, this);
            _errores.AddAll(validator.GetErrors());
            return IsValid;
            return true;
        }

        public bool IsValid()
        {
            ValidarDatos();
            if (_errores.Count > 0)
                return false;
            else
                return true;
        }

        public bool AllowShow()
        {
            return true;
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
            return null;
        }

        public ProcessManager GetProcessManagerParent()
        {
            return _processParent;
        }

        public void SetProcessManagerParent(ProcessManager processManager)
        {
            _processParent = processManager;
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

        public TaskCollectionData GetData()
        {
            TaskCollectionData data = new TaskCollectionData();
            data.TaskName = _taskName;
            data.Add(this._data);
            return data;
        }


        public void Commit()
        {
            foreach (ProductosCategoriasCuentas row in _tabla)
            {
                row.Commit(_data);
            }
            foreach (ProductosCategoriasCuentas row in _eliminados)
            {
                row.Commit(_data);
            }

        }

        public void Flush(string IdTransaction)
        {
            mz.erp.dataaccess.tsh_ProductosListasDePreciosCategoriasCuentas.Update(_data.tsh_ProductosListasDePreciosCategoriasCuentas, IdTransaction);
        }

        private mz.erp.commontypes.SentenciasReplicacion GenerateReplication()
        {
            mz.erp.commontypes.SentenciasReplicacion replication = new mz.erp.commontypes.SentenciasReplicacion();
            replication.IdConexion = Security.IdConexion;
            replication.SucGeneradora = Security.IdSucursal;
            replication.Destino = null;
            replication.VersionBD = null;
            //replication.NombreTabla = "dataaccess.tsh_Productos";
            return replication;
        }

        public void PutErrorOnDataSet(System.Data.DataRow row)
        {/*
			_errors.Clear();
			if (_rowProductos.HasErrors)
			{
				System.Data.DataColumn[] columnasConError = row.GetColumnsInError();
				for(int i=0;columnasConError.Length<i;i++)
				{
					ItemDatasetError error = new ItemDatasetError( ((System.Data.DataColumn)columnasConError[i]).Table.TableName,  ((System.Data.DataColumn)columnasConError[i]).ColumnName, row.GetColumnError( columnasConError[i] ) );
					_errors.Add( error );
				}
			}*/
        }

        public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
        {
        }

        public void PutExtraData(ProcessCollectionData _processCollectionData)
        {
        }

        public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
        {
            return _sentencia;

        }

        public bool GetHasSaved()
        {
            return false;
        }

        #endregion

        private void ValidarDatos()
        {
        }

        private bool Existe(string IdNomenclaturaCuenta, string IdNomenclaturaProducto)
        {
            foreach (ProductosCategoriasCuentas p in _tabla)
            {
                if (p.IdNomenclaturaCuenta.Equals(IdNomenclaturaCuenta) && (p.IdNomenclaturaProducto.Equals(IdNomenclaturaProducto)))
                    return true;
            }
            return false;
        }

        public void Eliminar(ProductosCategoriasCuentas row)
        {
            if (!row.Estado.Equals("NEW"))
            {
                row.Estado = "DEL";
                _eliminados.Add(row);
            }
            _tabla.Remove(row);
        }

        public void Agregar()
        {
            string repetidos = string.Empty;
            foreach (ItemJerarquia itc in _itemsJerarquiasCuenta)
            {
                foreach (ItemJerarquia itp in _itemsJerarquiasProducto)
                {
                    if (Existe(itc.NodeKey, itp.NodeKey))                        
                        repetidos = repetidos + itc.NodeDescription + " - " + itp.NodeDescription + ", ";
                }
            }
            if (string.IsNullOrEmpty(repetidos))
            {
                foreach (ItemJerarquia itc in _itemsJerarquiasCuenta)
                {
                    foreach (ItemJerarquia itp in _itemsJerarquiasProducto)
                    {
                        ProductosCategoriasCuentas pc = new ProductosCategoriasCuentas();
                        pc.Estado = "NEW";
                        pc.IdNomenclaturaCuenta = itc.NodeKey;
                        pc.CategoriaCuenta = itc.NodeDescription;
                        pc.IdNomenclaturaProducto = itp.NodeKey;
                        pc.CategoriaProducto = itp.NodeDescription;
                        pc.IdListaDePrecios = IdListaDePrecios;
                        pc.ListaDePrecios = ListaDePrecios;
                        _tabla.Add(pc);
                    }
                }
            }
            else
            {
                repetidos = repetidos.Remove(repetidos.Length - 2);
                System.Windows.Forms.MessageBox.Show(repetidos + " ya existen", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
            }
        }
    }
}

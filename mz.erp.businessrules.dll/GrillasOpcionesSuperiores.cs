using System;
using System.Collections;
using System.Data;
using mz.erp.commontypes.data;
using mz.erp.systemframework;


namespace mz.erp.businessrules
{
    /// <summary>
    /// Descripción breve de GrillasOpcionesSuperiores.
    /// </summary>
    public class GrillasOpcionesSuperiores
    {
        public GrillasOpcionesSuperiores()
        {
            this.Init();
        }

        public GrillasOpcionesSuperiores(string processName, string taskName, string grillaName)
        {
            _processName = processName;
            _taskName = taskName;
            _gridName = grillaName;
            //this.Init();
        }
        public GrillasOpcionesSuperiores(string processName, string taskName, string grillaName, ArrayList columnsProperties)
        {
            _processName = processName;
            _taskName = taskName;
            _gridName = grillaName;
            _columnsPropertiesArrayList = columnsProperties;
            this.Init();
        }

        #region Variables Privadas
        private string _processName = string.Empty;
        private string _taskName = string.Empty;
        private string _grillaName = string.Empty;
        private ArrayList _columnsPropertiesArrayList;
        private PropertiesColumn _selectedItem;
        private string _gridName = string.Empty;
        #endregion

        public event System.EventHandler ObjectHasChanged;        

        public void Init()
        {
            //Inicializar lo que se va a levantar en ComboColumnas (visibles de la grilla).
            foreach (PropertiesColumn pc in _columnsPropertiesArrayList)
            {
                _columnsProperties.AddItem(pc);
                if (pc.Visible)
                {
                    //this.Columns.Add(pc.ColumnName);
                    KeyValuePar parKV = new KeyValuePar(pc.ColumnName, pc.ColumnCaption);
                    this.Columns.Add(parKV);
                }
            }
            _columnsProperties.Sort();

        }
        
        #region Propiedades

        public object SelectedItem
        {
            set
            {
                string selectedCol = Convert.ToString(value);
                object aux = this.GetColumnProperties(selectedCol);
                if (aux != null)
                {
                    _selectedItem = (PropertiesColumn)aux;
                    if (ObjectHasChanged != null)
                        ObjectHasChanged(this, new EventArgs());
                }
            }
            get { return _selectedItem; }
        }

        private ArrayList _columns = new ArrayList();
        public ArrayList Columns
        {
            get { return _columns; }
        }
        private int _setIndex = 0;
        public int SetIndex
        {
            get { return _setIndex; }
        }

        private bool _merge = false;
        public bool Merge
        {
            get { return _merge; }
            set { _merge = value; }
        }

        private PropertiesColumnsCollection _columnsProperties = new PropertiesColumnsCollection();
        public PropertiesColumnsCollection ColumnsProperties
        {
            get { return _columnsProperties; }
        }

        private bool _exportarSQL = false;
        public bool ExportarSQL
        {
            get { return _exportarSQL; }
            set { _exportarSQL = value; }
        }

        #endregion
               
        #region Metodos Publicos

        public bool ExisteConfigPerfil()
        {
            tui_ConfiguracionGrillasPerfilesDataset _dataPerfil = new tui_ConfiguracionGrillasPerfilesDataset();
            _dataPerfil = mz.erp.businessrules.tui_ConfiguracionGrillasPerfiles.GetList(Security.IdPerfil, Workflow.GetIdProcessByName(_processName), Workflow.GetIdTakByName(_taskName), _grillaName, null, null, null);
            if (_dataPerfil.Tables[0].Rows.Count > 0)
                return true;
            return false;
        }

        public bool ExisteConfigUsuario()
        {
            tui_ConfiguracionGrillasUsuariosDataset _dataPerfil = new tui_ConfiguracionGrillasUsuariosDataset();
            _dataPerfil = mz.erp.businessrules.tui_ConfiguracionGrillasUsuarios.GetList(Security.IdUsuario, Workflow.GetIdProcessByName(_processName), Workflow.GetIdTakByName(_taskName), _grillaName, null, null, null);
            if (_dataPerfil.Tables[0].Rows.Count > 0)
                return true;
            return false;
        }
           
        public PropertiesColumn GetColumnProperties(string colName)
        {
            return _columnsProperties.Get(colName);
        }

        #endregion

    }

    public class KeyValuePar
    {
        public string _key;
        public string _value;

        public KeyValuePar(string NewKey, string NewValue)
        {
            _key = NewKey;
            _value = NewValue;
        }

        //  ToString() es utilizado por el ComboBox para recuperar el texto a mostrar de cada objeto.
        public override string ToString()
        {
            return _value;
        }

        public string Key
        {
            get { return _key; }
        }
        public string Value
        {
            get { return _value; }
        }

    }
    
}


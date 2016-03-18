using System;
using System.Data;
using System.Collections;
using System.Text;
using mz.erp.businessrules;
using mz.erp.commontypes;

namespace mz.erp.ui.controllers
{
    public class GrillasOpcionesSuperioresController
    {
        public GrillasOpcionesSuperioresController()
        {
            _brClass = new GrillasOpcionesSuperiores();
            Init();
        }

        public GrillasOpcionesSuperioresController(string processName, string taskName, string grillaName)
        {
            _brClass = new GrillasOpcionesSuperiores(processName, taskName, grillaName);
            Init();
        }
        
        public GrillasOpcionesSuperioresController(string processName, string taskName, string grillaName, ArrayList columnsProperties)
        {
            _brClass = new GrillasOpcionesSuperiores(processName, taskName, grillaName, columnsProperties);
            Init();
        }

        private GrillasOpcionesSuperiores _brClass = null;
        
        #region Eventos y delegados
        public event System.EventHandler ObjectHasChanged;
        public event System.EventHandler ColumnAlignmentChanged;
        public event System.EventHandler ColumnEditTypeChanged;
        public event System.EventHandler ColumnTypeChanged;
        public event System.EventHandler ColumnFormatChanged;
        
        #endregion

        #region Propiedades
        
        public bool ColumnVisible
        {
            get
            {
                if (_brClass.SelectedItem != null)
                    return ((PropertiesColumn)_brClass.SelectedItem).Visible;
                else return true;
            }
            set
            {
                if (_brClass.SelectedItem != null)
                    ((PropertiesColumn)_brClass.SelectedItem).Visible = value;
            }
        }
        public string ColumnAlignment
        {
            get
            {
                if (_brClass.SelectedItem != null)
                    return ((PropertiesColumn)_brClass.SelectedItem).Alignment;
                else return string.Empty;
            }
            set
            {
                if (_brClass.SelectedItem != null)
                {
                    ((PropertiesColumn)_brClass.SelectedItem).Alignment = value;
                }
            }
        }
        public string ColumnFormat
        {
            get
            {
                if (_brClass.SelectedItem != null)
                {
                    switch (((PropertiesColumn)_brClass.SelectedItem).Format)
                    {
                        case "c": return "Moneda";
                            break;
                        case "p": return "Porcentaje";
                            break;
                        case "d": return "Fecha";
                            break;
                        case "dd/MM/yyyy": return "Fecha corta";
                            break;
                        case "0": return "Entero";
                            break;
                        case "0.00": return "Decimal";
                            break;
                        case "#,##0.00;#,##0.00;0.00": return "Decimal+-0";
                            break;
                        case "f": return "Default";
                            break;
                        default: return "Default";
                    }
                }
                else return string.Empty;
            }
            set
            {
                if (_brClass.SelectedItem != null)
                {
                    switch (value)
                    {
                        case "Moneda": ((PropertiesColumn)_brClass.SelectedItem).Format = "c";
                            break;
                        case "Porcentaje": ((PropertiesColumn)_brClass.SelectedItem).Format = "p";
                            break;
                        case "Fecha": ((PropertiesColumn)_brClass.SelectedItem).Format = "d";
                            break;
                        case "Fecha corta": ((PropertiesColumn)_brClass.SelectedItem).Format = "dd/MM/yyyy";
                            break;
                        case "Entero": ((PropertiesColumn)_brClass.SelectedItem).Format = "0";
                            break;
                        case "Decimal": ((PropertiesColumn)_brClass.SelectedItem).Format = "0.00";
                            break;
                        case "Decimal+-0": ((PropertiesColumn)_brClass.SelectedItem).Format = "#,##0.00;#,##0.00;0.00";
                            break;
                        case "Default": ((PropertiesColumn)_brClass.SelectedItem).Format = "f";
                            break;
                    }
                }
            }
        }
        public string ColumnType
        {
            get
            {
                if (_brClass.SelectedItem != null)
                    return ((PropertiesColumn)_brClass.SelectedItem).Type;
                else return string.Empty;
            }
            set
            {
                if (_brClass.SelectedItem != null)
                {
                    ((PropertiesColumn)_brClass.SelectedItem).Type = value;
                }
            }
        }
        public string ColumnEditType
        {
            get
            {
                if (_brClass.SelectedItem != null)
                    return ((PropertiesColumn)_brClass.SelectedItem).EditType;
                else return string.Empty;
            }
            set
            {
                if (_brClass.SelectedItem != null)
                {
                    ((PropertiesColumn)_brClass.SelectedItem).EditType = value;
                }
            }
        }

        public PropertiesColumnsCollection ColumnsProperties
        {
            get
            {
                return _brClass.ColumnsProperties;
            }
        }

        public object SelectedItem
        {
            set { _brClass.SelectedItem = value; }
        }

        public ArrayList Columns
        {
            get { return _brClass.Columns; }
        }

        public bool ExportarSQL
        {
            get { return _brClass.ExportarSQL; }
            set { _brClass.ExportarSQL = value; }
        }
        #endregion

        #region Metodos Privados

        private void Init()
        {
            InitEvents();
        }

        private void InitEvents()
        {
            this._brClass.ObjectHasChanged += new EventHandler(_brClass_ObjectHasChanged);            
        }

        #endregion
                      
        #region Metodos Publicos

        public bool ExisteConfigPerfil()
        {
            return _brClass.ExisteConfigPerfil();
        }

        public bool ExisteConfigUsuario()
        {
            return _brClass.ExisteConfigUsuario();
        }

        private void _brClass_ObjectHasChanged(object sender, EventArgs e)
        {
            if (ObjectHasChanged != null)
                ObjectHasChanged(this, new EventArgs());
        }
        #endregion

        
        
    }
}


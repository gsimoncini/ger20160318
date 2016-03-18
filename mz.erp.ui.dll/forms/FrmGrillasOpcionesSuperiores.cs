using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using mz.erp.ui.forms.classes;
using mz.erp.ui.controllers;
using mz.erp.businessrules;
using mz.erp.commontypes.data;
using mz.erp.commontypes;

namespace mz.erp.ui.forms
{
    public partial class FrmGrillasOpcionesSuperiores : Form //Nueva clase - Tarea 898
    {
        public FrmGrillasOpcionesSuperiores()
        {
            InitializeComponent();
        }

        // Constructor para "Mas Opciones de configuracion"
        public FrmGrillasOpcionesSuperiores(GridVariablesLoader loader, IGridManager manager, string excludedColumns, string processName, string taskName, string grillaName)
        {
            InitializeComponent();
            _manager = manager;
            _loader = loader;
            _excludedColumns = excludedColumns;
            _processName = processName;
            _taskName = taskName;
            _grillaName = grillaName;
            _uiController = new GrillasOpcionesSuperioresController(_processName, _taskName, _grillaName);
            // Config de UI
            this.ultraExplorerBar1.Groups["OpcionesGenerales"].Visible = true;
            this.ultraExplorerBar1.Groups["OpcionesFormato"].Visible = false;

            // InitData.
            chkBoxExportarSQL.Checked = _uiController.ExportarSQL;
            btnFileChooser.Visible = _uiController.ExportarSQL;
            txtPathFile.Visible = _uiController.ExportarSQL;
            
            // InitEventHandlers.
            this.btnFileChooser.Click += new EventHandler(btnFileChooser_Click);
            this.chkBoxExportarSQL.CheckedChanged += new EventHandler(chkBoxExportarSQL_CheckedChanged);
        }

        void btnFileChooser_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Sql files (*.sql)|*.sql";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPathFile.Text = saveFileDialog1.FileName;
            }
        }

        void chkBoxExportarSQL_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxExportarSQL.Checked)
            {
                btnFileChooser.Visible = true;
                txtPathFile.Visible = true;
                _uiController.ExportarSQL = true;
            }
            else
            {
                btnFileChooser.Visible = false;
                txtPathFile.Visible = false;
                _uiController.ExportarSQL = false;
            }
        }

        // Constructor para "Formato de Columnas VISIBLES"
        public FrmGrillasOpcionesSuperiores(string processName, string taskName, Janus.Windows.GridEX.GridEX grilla, IGridManager manager)
        {
            InitializeComponent();
            _manager = manager;
            _processName = processName;
            _taskName = taskName;
            _grillaName = grilla.Name;
            _grilla = grilla;
            _uiController = new GrillasOpcionesSuperioresController(_processName, _taskName, _grillaName, _manager.GetLayoutProperties(string.Empty) );
            // Config de UI
            this.ultraExplorerBar1.Groups["OpcionesGenerales"].Visible = false;
            this.ultraExplorerBar1.Groups["OpcionesFormato"].Visible = true;

            // InitData.
            comboColumna.Items.AddRange(_uiController.Columns.ToArray());

            // InitEventHandlers.
            this.comboColumna.SelectedIndexChanged += new EventHandler(comboColumna_SelectedIndexChanged);
            this.comboAlineacion.SelectedIndexChanged += new EventHandler(comboAlineacion_SelectedIndexChanged);
            this.comboFormato.SelectedIndexChanged += new EventHandler(comboFormato_SelectedIndexChanged);
            this.comboTipoEdicion.SelectedIndexChanged += new EventHandler(comboTipoEdicion_SelectedIndexChanged);
            this.comboTipoColumna.SelectedIndexChanged += new EventHandler(comboTipoColumna_SelectedIndexChanged);
            _uiController.ObjectHasChanged += new EventHandler(Refresh);

            if (comboColumna.Items.Count > 0)
            {
                //Autoselecciono el primer elemento del combo.
                comboColumna.SelectedIndex = 0;
                KeyValuePar kvp = (KeyValuePar)comboColumna.SelectedItem;
                _uiController.SelectedItem = kvp.Key;
            }
        }

        void comboTipoEdicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTipoEdicion.SelectedItem != null)
                _uiController.ColumnEditType = (string)comboTipoEdicion.SelectedItem;
        }

        void comboTipoColumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTipoColumna.SelectedItem != null)
                _uiController.ColumnType = (string)comboTipoColumna.SelectedItem;
        }

        void comboFormato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFormato.SelectedItem != null)
                _uiController.ColumnFormat = (string)comboFormato.SelectedItem;
        }

        void comboAlineacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAlineacion.SelectedItem != null)
                _uiController.ColumnAlignment = (string)comboAlineacion.SelectedItem;
        }

        void comboColumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboColumna.SelectedItem != null)
            {
                KeyValuePar kvp = (KeyValuePar)comboColumna.SelectedItem;
                _uiController.SelectedItem = kvp.Key;
                //_uiController.SelectedItem = comboColumna.SelectedItem;
            }
            
        }

        void Refresh(object sender, EventArgs e)
        {
            // Actualiza los combos con la configuracion del campo seleccionado.
            comboAlineacion.Text = _uiController.ColumnAlignment;
            comboFormato.Text = _uiController.ColumnFormat;
            comboTipoEdicion.Text = _uiController.ColumnEditType;
            comboTipoColumna.Text = _uiController.ColumnType;
        }

        
        #region Variables privadas

        private GrillasOpcionesSuperioresController _uiController = null;
        private IGridManager _manager;
        private GridVariablesLoader _loader;
        private ArrayList _gridLayoutProperties = new ArrayList();
        private string _excludedColumns = string.Empty;
        private string _processName = string.Empty;
        private string _taskName = string.Empty;
        private string _grillaName = string.Empty;
        private Janus.Windows.GridEX.GridEX _grilla;

        #endregion

        private void utbGuardar_Click(object sender, EventArgs e)
        {
            _gridLayoutProperties = _manager.GetLayoutProperties(_excludedColumns);

            bool saveForPerfil = false;
            bool saveForUsuario = false;

            DialogResult result;
            result = MessageBox.Show("¿Desea guardar la nueva configuración para el Perfil: " + Security.Perfil + " (perfil del IdUsuario logueado)?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Chequea si existe una config, a nivel Perfil, para la grilla seleccionada.
                if (_uiController.ExisteConfigPerfil())
                {
                    // Existe la config para el Perfil ==> preg si sobreescribe.
                    DialogResult resultPerfil;
                    resultPerfil = MessageBox.Show("Existe una configuración, a nivel Perfil, para la grilla a guardar. ¿Desea sobreescribir?" + " (perfil: " + Security.Perfil + ")", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultPerfil == DialogResult.Yes)
                        saveForPerfil = true;
                }
                else
                    saveForPerfil = true;
            }

            result = MessageBox.Show("¿Desea guardar la nueva configuración de la grilla para el Usuario: " + Security.IdUsuario + " (IdUsuario logueado)?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Chequea si existe una config, a nivel Perfil, para la grilla seleccionada.
                if (_uiController.ExisteConfigUsuario())
                {
                    // Existe la config para el Usuario ==> preg si sobreescribe.
                    DialogResult resultUsuario;
                    resultUsuario = MessageBox.Show("Existe una configuración, a nivel Usuario, para la grilla a guardar. ¿Desea sobreescribir?" + " (IdUsuario: " + Security.IdUsuario + ")", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultUsuario == DialogResult.Yes)
                        saveForUsuario = true;
                }
                else
                    saveForUsuario = true;
            }

            if (_manager.SaveLayoutProperties(_gridLayoutProperties, _processName, _taskName, _excludedColumns, saveForPerfil, saveForUsuario, _uiController.ExportarSQL, txtPathFile.Text))
                MessageBox.Show("Operación realizada!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error al intentar exportar la nueva configuración." + Environment.NewLine + "(Asegúrese que el archivo (o ruta) existe y NO se encuentra abierto)", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void ubGuardarFormato_Click(object sender, EventArgs e)
        {
            // Actualizo los columnsProperties de la grilla actual
            _manager.SetLayoutProperties(_uiController.ColumnsProperties);            
            this.Close();
        }
    }
}

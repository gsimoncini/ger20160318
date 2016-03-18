using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using mz.erp.ui.forms.classes;
using mz.erp.ui.controllers;
using mz.erp.ui.forms;
using mz.erp.businessrules;

namespace mz.erp.ui.controls
{
    //Matias 20101005 - Tarea 898 - NUEVO CONTROL DE USUARIO.
    public partial class GridManagerViewSaveConfig : System.Windows.Forms.UserControl
    {
        #region Variables privadas
        private IGridManager _manager;
        private GridVariablesLoader _loader;
        private ArrayList _gridLayoutProperties = new ArrayList();
        private string _excludedColumns = string.Empty;
        private string _processName = string.Empty;
        private string _taskName = string.Empty;
        private string _grillaName = string.Empty;
        #endregion

        public GridManagerViewSaveConfig()
        {
            InitializeComponent();
        }

        #region Métodos privados
        private void utbGuardar_Click(object sender, EventArgs e)
        {
            FrmGrillasOpcionesSuperiores frmOpciones = new FrmGrillasOpcionesSuperiores(_loader, _manager, _excludedColumns, _processName, _taskName, _grillaName);
            frmOpciones.ShowDialog();
        }

        #endregion

        #region Métodos públicos
        public void Configure(IGridManager manager, GridVariablesLoader loader, string ExcludedColumns, string ProcessName, string TaskName, string GrillaName)
        {
            _loader = loader;
            _manager = manager;
            _excludedColumns = ExcludedColumns;
            _processName = ProcessName;
            _taskName = TaskName;
            _grillaName = GrillaName;
        }
        #endregion
    }
}

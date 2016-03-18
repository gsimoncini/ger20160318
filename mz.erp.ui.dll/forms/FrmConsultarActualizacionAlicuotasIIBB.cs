//Matias 20110422 - Tarea 0000061
using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using mz.erp.ui.forms.classes;
using mz.erp.businessrules;
using mz.erp.commontypes;
using mz.erp.ui.utility;

namespace mz.erp.ui.forms
{
    public partial class FrmConsultarActualizacionAlicuotasIIBB : Form, ITaskForm, ISearchObjectListener
    {
        public FrmConsultarActualizacionAlicuotasIIBB()
        {
            InitializeComponent();
        }

        public FrmConsultarActualizacionAlicuotasIIBB(ConsultarActualizacionAlicuotasIIBBController uiController)
        {
            InitializeComponent();
            _uiController = uiController;
        }

        #region Variables Privadas

        private mz.erp.ui.controllers.ConsultarActualizacionAlicuotasIIBBController _uiController = null;

        #endregion

        #region Miembros de ITaskForm

        public void ShowForm()
        {
            Build_UI();
            if (this._uiController.AllowShow())
            {
                base.Show();
            }
            else
            {
                if (_uiController.IsNextState())
                    this._uiController.Execute();
                else
                    if (_uiController.IsBackState())
                        this._uiController.Previous();
            }

        }

        public void Previous()
        {
            this._uiController.Previous();
        }

        public void CloseForm()
        {
            if (_uiController.PreguntarAlCancelar)
            {
                if ((MessageBox.Show(this, "Está a punto de cerrar el fomulario. Realmente desea realizar esta operación?", "Atención!", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Stop) == System.Windows.Forms.DialogResult.OK))
                    Close();
            }
            else
            {
                Close();
            }
        }

        public void KeyDownPrevious()
        {
        }

        public void KeyDownNext()
        {
            Execute();
        }

        #endregion

        #region Miembros de ISearchObjectListener

        public void processEventChange(object sender, EventArgs e)
        {

        }

        #endregion
        private void Build_UI()
        {
            ConfigureInterface();
            InitializeData();
            InitDataBindings();
            InitEventHandlers();
        }

        private void ConfigureInterface()
        {
            //Cristian  configuracion imagenes 20110729
            utility.Util.LoadImages(toolBarStandar,this.imageList1);
            //Fin Cristian
            tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
            tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
            labelTarea.Text = _uiController.LeyendaFormulario;
            this.Text = _uiController.LeyendaFormulario;

            this.mzCmbCuenta.Visible = true;
            this.mzCmbProveedor.Visible = true;

            gridManagerView1.Configure(_uiController.ProcessName, _uiController.TaskName, this.Name, gridResultado, this.Text);
            this.KeyPreview = true;
        }

        private void InitializeData()
        {
            mzCmbCuenta.Init(_uiController.ProcessName, _uiController.TaskName);
            mzCmbCuenta.SearchObjectListener = this;

            mzCmbProveedor.Init();
            mzCmbProveedor.SearchObjectListener = this;

            fechaDesde.Value = _uiController.FechaDesde;
            fechaHasta.Value = _uiController.FechaHasta;
        }

        private void InitEventHandlers()
        {
            this.toolBarStandar.ButtonClick += new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
            _uiController.DataChanged += new EventHandler(RefreshData);
            this.KeyDown += new KeyEventHandler(FrmConsultarActualizacionAlicuotasIIBB_KeyDown);
            KeyDownManager KeyDownMan = new KeyDownManager(this);
        }

        void FrmConsultarActualizacionAlicuotasIIBB_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case System.Windows.Forms.Keys.F5:
                    this.SearchNow();
                    break;
            }
        }

        private void InitDataBindings()
        {

        }

        public void Execute()
        {
            DialogResult result = DialogResult.Yes;
            if (_uiController.PreguntarAlGuardar)
                result = MessageBox.Show("¿Esta seguro que desea confirmar esta operación?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.DumpControls();
                _uiController.Execute();

            }
        }

        protected void DumpControls()
        {
            _uiController.CodigoCuenta = mzCmbCuenta.DataValue;
            _uiController.CodigoProveedor = mzCmbProveedor.DataValue;

            _uiController.FechaDesde = Convert.ToDateTime(fechaDesde.Value);
            _uiController.FechaHasta = Convert.ToDateTime(fechaHasta.Value);
        }

        protected void FillControls()
        {

        }

        void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            switch (toolBarStandar.Buttons.IndexOf(e.Button))
            {
                case 0:
                    _uiController.Previous();
                    break;
                case 2:
                    _uiController.Execute();
                    break;
                case 4:
                    SearchNow();
                    break;
                case 6:
                    ResetFilters();
                    break;
                case 8:
                    CloseForm();
                    break;
            }            
        }

        private void SearchNow()
        {
            this.Cursor = Cursors.WaitCursor;
            Util.MoveFocus(this.gridResultado);
            this.DumpControls();
            _uiController.SearchNow();
            this.Cursor = Cursors.Default;
        }

        private void RefreshData(object sender, EventArgs e)
        {
            gridResultado.SetDataBinding(null, null);
            gridResultado.SetDataBinding(_uiController.Result, null);
            if (gridManagerView1.AllowGroupCollapse)
                this.gridResultado.CollapseGroups();
            else
                if (gridResultado.RootTable.Groups.Count > 0)
                    gridResultado.RootTable.Groups[0].Expand();
            if (gridManagerView1.AllowExportExcel || gridManagerView1.AllowSortByAgregateColumn)
                gridManagerView1.SetTable(_uiController.Result);
        }

        private void ResetFilters()
        {
            _uiController.ResetFilters();

            mzCmbCuenta.ClearControl();
            mzCmbProveedor.ClearControl();
            
            fechaDesde.Value = _uiController.FechaDesdeOrig;
            fechaHasta.Value = _uiController.FechaHastaOrig;

            gridResultado.SetDataBinding(null, null);
            gridResultado.Refresh();
        }

        
    }
}

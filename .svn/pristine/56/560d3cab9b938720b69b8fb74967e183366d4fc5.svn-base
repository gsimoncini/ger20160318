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

namespace mz.erp.ui.forms
{
    public partial class FrmIngresarPadronARBA : Form, ITaskForm
    {
        public FrmIngresarPadronARBA()
        {
            InitializeComponent();
        }

        public FrmIngresarPadronARBA(IngresarPadronARBAController uiController)
		{
			InitializeComponent();
			_uiController = uiController;
		}

        #region Variables Privadas

        private mz.erp.ui.controllers.IngresarPadronARBAController _uiController = null;

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

        private void Build_UI()
        {
            ConfigureInterface();
            InitializeData();
            InitDataBindings();
            InitEventHandlers();
        }

        private void ConfigureInterface()
        {
            //Cristian Configuracion ImageList
            mz.erp.ui.utility.Util.LoadImages(toolBarStandar,imglStandar);
            //Fin Cristian
            tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
            tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
            labelTarea.Text = _uiController.LeyendaFormulario;
            this.Text = _uiController.LeyendaFormulario;
        }

        private void InitializeData()
        {
            
        }

        private void InitEventHandlers()
        {
            this.toolBarStandar.ButtonClick += new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
            this.btnFileChooser.Click += new EventHandler(btnFileChooser_Click);
            KeyDownManager KeyDownMan = new KeyDownManager(this);
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
            _uiController.FilePath = this.txtFileName.Text; 
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
                    this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
					Execute();
                    this.Cursor = System.Windows.Forms.Cursors.Default;
                    break;
                case 4:
                    CloseForm();
                    break;
            }
        }

        void btnFileChooser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogIIBB = new OpenFileDialog();
            openFileDialogIIBB.Filter = "txt files (*.txt)|*.txt|csv files (*.csv)|*.csv";
            openFileDialogIIBB.RestoreDirectory = true;
            if (openFileDialogIIBB.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = openFileDialogIIBB.FileName;
            }
        }


    }
}

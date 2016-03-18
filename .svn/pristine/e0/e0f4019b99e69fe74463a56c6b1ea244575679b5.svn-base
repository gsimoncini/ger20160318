/* Silvina 20111104 - Tarea 0000222 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using mz.erp.ui.forms.classes;
using mz.erp.businessrules;

namespace mz.erp.ui.forms
{
    public partial class FrmAbmProductosCategoriasCuentas : Form, ITaskForm 
    {

        private mz.erp.ui.controllers.AbmProductosCategoriasCuentasController _uiController;

        public FrmAbmProductosCategoriasCuentas()
        {
            InitializeComponent();
        }

        public FrmAbmProductosCategoriasCuentas(mz.erp.ui.controllers.AbmProductosCategoriasCuentasController uiController)
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			_uiController = uiController;
			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

        #region Miembros de ITaskForm

        public void ShowForm()
        {
            if (this._uiController.AllowShow())
            {
                this.Build_UI();
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


        public void Execute()
        {
            this.DumpControls();
            this._uiController.Execute();
        }

        public void Previous()
        {
            this._uiController.Previous();
        }


        public void CloseForm()
        {
            Close();
        }

        public void KeyDownPrevious()
        {
            Previous();
        }

        public void KeyDownNext()
        {
            Execute();
        }

        private void Build_UI()
        {
            ConfigureInterface();
            InitEventHandlers();
            InitializeData();
            InitializeMembers();
            InitDataBindings();
            FillControls();
        }

        private void ConfigureInterface()
        {
            utility.Util.LoadImages(toolBar1, imglStandar);
            Text = _uiController.LeyendaFormulario;
            labelTarea.Text = _uiController.LeyendaFormulario;
            gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), this.Name, gridResultado, this.Text);			
            //gridResultado.LayoutData = _uiController.GetLayout();
            gridResultado.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
            //gridResultado.AutomaticSort = true;
            gridResultado.ColumnAutoResize = true;
            KeyPreview = true;
        }

        private void ListenerControllerChanges(object sender, System.EventArgs e)
        {
            RefreshData();
        }

        private void InitEventHandlers()
        {
            toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            btnAgregar.Click += new EventHandler(btnAgregar_Click);
            btnEliminar.Click += new EventHandler(btnEliminar_Click);
            KeyDownManager KeyDown = new KeyDownManager(this);
        }

        private void InitializeData()
        {

        }

        protected void InitializeMembers()
        {
            lCuentas.Text = _uiController.EtiquetaCuentas;
            /* Silvina 20111226 - Tarea 0000241 */
            mzSTBCuentas.Init("CUENTAS",true,_uiController.JerarquiaCuentas,",");
            lProductos.Text = _uiController.EtiquetaProductos;
            mzSTBProductos.Init("PRODUCTOS",true,_uiController.JerarquiaProductos,",");
            /* Fin Silvina 20111226 - Tarea 0000241 */
            mzCEListaPrecios.FillFromDataSource(businessrules.tsh_ListasDePrecios.GetList().tsh_ListasDePrecios, "IdListaDePrecio", "Descripcion", 100, "1", "2", "Descripcion");
            gridResultado.DataBindings.Clear();
            gridResultado.SetDataBinding(_uiController.Tabla, null);
        }

        private void InitDataBindings()
        {            
        }

        //se ejecuta al levantar la ventana
        protected void FillControls()
        {
        }

        //se ejecuta al intentar guardar
        protected void DumpControls()
        {
        }

        private void RefreshData()
        {
        }
        #endregion

        #region Eventos

        private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
        {
            switch (toolBar1.Buttons.IndexOf(e.Button))
            {
                case 0: //Anterior
                    Previous();
                    break;
                case 2: //Siguiente
                    Execute();
                    break;
                case 4:	//Cancelar		
                    if (_uiController.PreguntarAlCancelar)
                    {
                        if ((MessageBox.Show(this, "Está a punto de cerrar el fomulario. Realmente desea realizar esta operación?", "Atención!", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Stop) == System.Windows.Forms.DialogResult.OK))
                            CloseForm();
                    }
                    else
                    {
                        CloseForm();
                    }
                    break;
            }
        }

        void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (Janus.Windows.GridEX.GridEXSelectedItem it in gridResultado.SelectedItems)
            {
                ProductosCategoriasCuentas row = (ProductosCategoriasCuentas)it.GetRow().DataRow;
                _uiController.Eliminar(row);
            }
            gridResultado.DataBindings.Clear();
            gridResultado.SetDataBinding(_uiController.Tabla, null);
        }

        void btnAgregar_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                _uiController.IdListaDePrecios = mzCEListaPrecios.Value.ToString();
                _uiController.ItemsJerarquiasCuenta = mzSTBCuentas.ItemsJerarquias;
                _uiController.ListaDePrecios = mzCEListaPrecios.Text;
                _uiController.ItemsJerarquiasProducto = mzSTBProductos.ItemsJerarquias;

                _uiController.Agregar();
                gridResultado.DataBindings.Clear();
                gridResultado.SetDataBinding(_uiController.Tabla, null);
            }
        }

        #endregion

        private bool IsValid()
        {
            if (mzCEListaPrecios.Value == null)
            {
                MessageBox.Show(this, "Debe seleccionar una Lista de Precios.", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
                return false;
            }
            if (mzSTBCuentas.NodeDescription.Equals(string.Empty))
            {
                MessageBox.Show(this, "Debe seleccionar al menos una Categoría de Clientes.", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
                return false;
            }
            if (mzSTBProductos.NodeDescription.Equals(string.Empty))
            {
                MessageBox.Show(this, "Debe seleccionar al menos una Categoría de Productos.", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

    }
}

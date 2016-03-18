/* Silvina 20110712 - Tarea 0000121 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using mz.erp.ui.controllers;

namespace mz.erp.ui.forms
{
    public partial class FrmAlertas : Form
    {
        public FrmAlertas()
        {
            InitializeComponent();
            Build_UI();            
        }

        private AlertasController _uiController = new AlertasController();

        private void Build_UI()
        {
            ConfigureInterface();
            InitEventHandlers();
            //German 20120302 - Tarea 0000285
            //InitializeMembers();    

            //Fin German 20120302 - Tarea 0000285
        }

        private void ConfigureInterface()
        {
            gridResultado.Name = _uiController.Grilla;
            //German 2012017 - Tarea 0000261
            //gridManagerView1.Configure(string.Empty, string.Empty, this.Name, gridResultado, this.Text);
            gridManagerView1.Configure("ProcesoMostrarAlertas", "MostrarAlertas", this.Name, gridResultado, this.Text, true);
            //German 2012017 - Tarea 0000261
            gridResultado.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            gridResultado.AutomaticSort = true;
            if (gridResultado.Name.Equals("gridCtaCte"))
            {
                gridResultado.RootTable.Columns["SaldoCtaCteDV"].Visible = _uiController.MuestraSaldoCtaCteDV;
                gridResultado.RootTable.Columns["Fecha"].Visible = _uiController.ValidaPorFecha;
                gridResultado.RootTable.Columns["LimiteDeCredito"].Visible = _uiController.ValidaPorMonto;
            }
        }

        private void InitEventHandlers()
        {
            btAceptar.Click += new EventHandler(btAceptar_Click);
        }

        private void InitializeMembers()
        {
            //German 20120302 - Tarea 0000285
            /*
            _uiController.ActualizarDatos();
            gridResultado.SetDataBinding(null, null);
            gridResultado.SetDataBinding(_uiController.Result, null);
             */

            this.ActualizarDatos();
            //Fin German 20120302 - Tarea 0000285

        }

        void btAceptar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public bool VisualizaAlertas()
        {
            return _uiController.VisualizaAlertas;
        }

        public bool HayAlertas()
        {
            return _uiController.HayAlertas;
        }

        public int TiempoDeActualizacion()
        {
            return _uiController.TiempoDeActualizacion;
        }

        public void ActualizarDatos()
        {
            _uiController.ActualizarDatos();
            gridResultado.SetDataBinding(null, null);
            gridResultado.SetDataBinding(_uiController.Result, null);
            //German 20120302 - Tarea 0000285
            if (gridManagerView1.AllowGroupCollapse)
                this.gridResultado.CollapseGroups();
            else
                if (gridResultado.RootTable.Groups.Count > 0)
                    gridResultado.RootTable.Groups[0].Expand();
            if (gridManagerView1.AllowExportExcel || gridManagerView1.AllowSortByAgregateColumn)
                gridManagerView1.SetTable(_uiController.Result);
            //Fin German 20120302 - Tarea 0000285
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

    }
}

/* Fin Silvina 20110712 - Tarea 0000121 */
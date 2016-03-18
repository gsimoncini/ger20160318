using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.commontypes;
using mz.erp.ui.forms.classes;
using mz.erp.ui.utility;
using mz.erp.ui.controllers;

namespace mz.erp.ui.forms
{
    public partial class FrmConsultarSeguimientoAcopios : Form, ITaskForm
    {
        public FrmConsultarSeguimientoAcopios()
        {
            InitializeComponent();
        }

        private ConsultarSeguimientoAcopioController _uiController;

        public FrmConsultarSeguimientoAcopios(ConsultarSeguimientoAcopioController controller)
		{
			InitializeComponent();
			_uiController = controller;
			

		}


		#region Miembros de ITaskForm
		public void Execute()
		{
			this._uiController.Execute();
		}

		public void Previous()
		{
			this._uiController.Previous();
		}

		private void Build_UI()
		{
            ConfigureInterface();
            InitializeData();
            InitEventHandlers();
            //InitDataBindings();
		}

        private void ConfigureInterface()
        {
            /* Silvina 20120416 - Tarea 0000277 */
            utility.Util.LoadImagesCuentaCorriente(toolBarStandar, imglStandar);
            /* Fin Silvina 20120416 - Tarea 0000277 */

            this.Text = "Consulta Seguimiento Acopios";
            labelTarea.Text = "Consulta Seguimiento Acopios";
            this.KeyPreview = true;
            
            mzCmbCuenta.Init(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName());
            mzCmbCuenta.Enabled = true;
            mzCmbCuenta.EnableCtaCte = false;
            mzCmbCuenta.AllowEditClientePaso = false;

            gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), gridAcopios, this.Text, true);
            gridManagerView2.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), gridDetalleAcopios, this.Text, true);



            gridAcopios.ContextMenu = this.contextMenuGridAcopios;
            gridDetalleAcopios.ContextMenu = this.contextMenuGridDetalleAcopios;

            Janus.Windows.GridEX.ConditionOperator condConec = Janus.Windows.GridEX.ConditionOperator.Equal;
            Janus.Windows.GridEX.GridEXFormatCondition cndConec = new Janus.Windows.GridEX.GridEXFormatCondition(gridAcopios.RootTable.Columns["Cerrado"], condConec, true);
            cndConec.FormatStyle.ForeColor = Color.Red;
            cndConec.FormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            gridAcopios.RootTable.FormatConditions.Add(cndConec);

            
        }

        private void InitializeData()
        {
            udteDesde.Value = _uiController.FechaDesde;
            udteHasta.Value = _uiController.FechaHasta;
        }

        private void InitEventHandlers()
        {
            this.KeyDown += new KeyEventHandler(KeyDownBehavior);
            mzCmbCuenta.ValueChanged += new System.EventHandler(this.Componentes_Changes);
            this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
            this.Detalles.Click += new EventHandler(Detalles_Click);
            this.menuItem1.Click += new EventHandler(menuItem1_Click);
        }



        void menuItem1_Click(object sender, EventArgs e)
        {
            if (gridDetalleAcopios.SelectedItems.Count > 0 && gridDetalleAcopios.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
            {
                string IdComprobante = Convert.ToString(gridDetalleAcopios.SelectedItems[0].GetRow().Cells["IdComprobante"].Value);
                long Ordinal = Convert.ToInt64(gridDetalleAcopios.SelectedItems[0].GetRow().Cells["Ordinal"].Value);
                if (!IdComprobante.Equals(string.Empty))
                {
                    this.richInfoComprobante.Clear();
                    string datos = mz.erp.businessrules.Workflow.GetHTMLDetalleAcopio(IdComprobante, Ordinal);
                    this.richInfoComprobante.AddHTML(datos);
                }
                else this.richInfoComprobante.Clear();
                
            }
        }

        void Detalles_Click(object sender, EventArgs e)
        {
            if (gridAcopios.SelectedItems.Count > 0 && gridAcopios.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
            {
                string IdComprobante = Convert.ToString(gridAcopios.SelectedItems[0].GetRow().Cells["IdComprobante"].Value);
                if (!IdComprobante.Equals(string.Empty))
                {
                    _uiController.RefreshDataDetalleAcopio(IdComprobante);

                    gridDetalleAcopios.SetDataBinding(null, null);
                    gridDetalleAcopios.SetDataBinding(_uiController.ResultDetalleAcopio, null);

                    if (gridManagerView2.AllowGroupCollapse)
                        this.gridDetalleAcopios.CollapseGroups();
                    else
                        if (gridDetalleAcopios.RootTable.Groups.Count > 0)
                            gridDetalleAcopios.RootTable.Groups[0].Expand();
                    if (gridManagerView2.AllowExportExcel || gridManagerView2.AllowSortByAgregateColumn)
                        gridManagerView2.SetTable(_uiController.ResultDetalleAcopio);

                    if (gridDetalleAcopios.RecordCount > 0)
                    {
                        gridDetalleAcopios.Row = 0;

                    }

                }
                
            }
        }

        private void Componentes_Changes(object sender, System.EventArgs e)
        {

            _uiController.CodigoCuenta = Convert.ToString(mzCmbCuenta.DataValue);

        }

        private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            switch (toolBarStandar.Buttons.IndexOf(e.Button))
            {
                case 0:
                    RefreshData();
                    break;
                case 2:
                    _uiController.Execute();
                    break;
                case 4:
                    
                    break;
                
            }
        }
        
        private void KeyDownBehavior(object sender, KeyEventArgs e)
		{
			switch (e.KeyData )
			{
				case System.Windows.Forms.Keys.F5 :
					this.RefreshData();
					break;
			}
		}

        protected void RefreshData()
        {
            Util.MoveFocus(this.ultraExplorerBarContainerControl3);
            this.Cursor = Cursors.WaitCursor;
            gridAcopios.Focus();
            this.DumpControls();
            _uiController.RefreshData();
            gridAcopios.SetDataBinding(null, null);
            gridAcopios.SetDataBinding(_uiController.Result, null);
            gridDetalleAcopios.SetDataBinding(null, null);
            if (gridManagerView1.AllowGroupCollapse)
                this.gridAcopios.CollapseGroups();
            else
                if (gridAcopios.RootTable.Groups.Count > 0)
                    gridAcopios.RootTable.Groups[0].Expand();
            if (gridManagerView1.AllowExportExcel || gridManagerView1.AllowSortByAgregateColumn)
                gridManagerView1.SetTable(_uiController.Result);	

            if (gridAcopios.RecordCount > 0)
            {
                gridAcopios.Row = 0;

            }
           
            this.Cursor = Cursors.Default;
        }

        private void DumpControls()
        {

            _uiController.FechaDesde = Convert.ToDateTime(udteDesde.Value);
            _uiController.FechaHasta = Convert.ToDateTime(udteHasta.Value);
        }


		public virtual void ShowForm()
		{
			
			
			if(this._uiController.AllowShow())
			{
				this.Build_UI();
				base.Show();

			}
			else
			{
				if(_uiController.IsNextState())
					this._uiController.Execute();
				else
					if(_uiController.IsBackState())
					this._uiController.Previous();
			}
		}

		public void CloseForm()
		{
			
		}

		public void KeyDownPrevious()
		{
		}

		public void KeyDownNext()
		{
		}

		#endregion
    }
}

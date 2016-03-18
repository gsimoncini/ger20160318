//Matias 20110430 - Tarea 0000061
namespace mz.erp.ui.forms
{
    partial class FrmConsultarActualizacionAlicuotasIIBB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.labelTarea = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fechaDesde = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.fechaHasta = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.gridResultado = new Janus.Windows.GridEX.GridEX();
            this.toolBarStandar = new System.Windows.Forms.ToolBar();
            this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
            this.tbbEjecutarConsulta = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.tbbReiniciarFiltros = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.mzCmbCuenta = new mz.erp.ui.controls.mzCuentasControl();
            this.mzCmbProveedor = new mz.erp.ui.controls.mzProveedoresControl();
            this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
            this.ultraExplorerBarContainerControl4.SuspendLayout();
            this.ultraExplorerBarContainerControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fechaDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaHasta)).BeginInit();
            this.ultraExplorerBarContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
            this.ultraExplorerBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraExplorerBarContainerControl4
            // 
            this.ultraExplorerBarContainerControl4.Controls.Add(this.labelTarea);
            this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
            this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(1331, 24);
            this.ultraExplorerBarContainerControl4.TabIndex = 3;
            this.ultraExplorerBarContainerControl4.Visible = false;
            // 
            // labelTarea
            // 
            this.labelTarea.BackColor = System.Drawing.Color.Transparent;
            this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarea.Location = new System.Drawing.Point(0, 0);
            this.labelTarea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTarea.Name = "labelTarea";
            this.labelTarea.Size = new System.Drawing.Size(1331, 22);
            this.labelTarea.TabIndex = 1;
            this.labelTarea.Text = "Tarea";
            this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ultraExplorerBarContainerControl1
            // 
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbCuenta);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbProveedor);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.groupBox1);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.lblCliente);
            this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 20);
            this.ultraExplorerBarContainerControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(1331, 98);
            this.ultraExplorerBarContainerControl1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fechaDesde);
            this.groupBox1.Controls.Add(this.fechaHasta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(4, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(370, 49);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha de actualización: ";
            // 
            // fechaDesde
            // 
            this.fechaDesde.Location = new System.Drawing.Point(75, 17);
            this.fechaDesde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.Size = new System.Drawing.Size(94, 21);
            this.fechaDesde.TabIndex = 108;
            // 
            // fechaHasta
            // 
            this.fechaHasta.Location = new System.Drawing.Point(224, 17);
            this.fechaHasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Size = new System.Drawing.Size(94, 21);
            this.fechaHasta.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 110;
            this.label1.Text = "Desde:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(177, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 111;
            this.label2.Text = "Hasta:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(2, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 103;
            this.label3.Text = "Proveedor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Location = new System.Drawing.Point(2, 0);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(90, 17);
            this.lblCliente.TabIndex = 82;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ultraExplorerBarContainerControl2
            // 
            this.ultraExplorerBarContainerControl2.Controls.Add(this.gridManagerView1);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.gridResultado);
            this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 175);
            this.ultraExplorerBarContainerControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
            this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(1331, 314);
            this.ultraExplorerBarContainerControl2.TabIndex = 1;
            // 
            // gridResultado
            // 
            this.gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridResultado.AlternatingColors = true;
            this.gridResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridResultado.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridResultado.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridResultado.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridResultado.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridResultado.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridResultado.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
            this.gridResultado.GroupByBoxVisible = false;
            this.gridResultado.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridResultado.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridResultado.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
            this.gridResultado.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
            this.gridResultado.Location = new System.Drawing.Point(0, 27);
            this.gridResultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridResultado.Name = "gridResultado";
            this.gridResultado.RecordNavigator = true;
            this.gridResultado.RecordNavigatorText = "Registro:|de";
            this.gridResultado.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridResultado.ShowEmptyFields = false;
            this.gridResultado.Size = new System.Drawing.Size(1327, 281);
            this.gridResultado.TabIndex = 2;
            this.gridResultado.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            // 
            // toolBarStandar
            // 
            this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbAnterior,
            this.tbbSeparator,
            this.tbbSiguiente,
            this.tbbSeparator2,
            this.tbbEjecutarConsulta,
            this.toolBarButton1,
            this.tbbReiniciarFiltros,
            this.toolBarButton2,
            this.tbbCancelar});
            this.toolBarStandar.DropDownArrows = true;
            this.toolBarStandar.ImageList = this.imageList1;
            this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
            this.toolBarStandar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toolBarStandar.Name = "toolBarStandar";
            this.toolBarStandar.ShowToolTips = true;
            this.toolBarStandar.Size = new System.Drawing.Size(1397, 28);
            this.toolBarStandar.TabIndex = 22;
            this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            // 
            // tbbAnterior
            // 
            this.tbbAnterior.ImageIndex = 9;
            this.tbbAnterior.Name = "tbbAnterior";
            this.tbbAnterior.Text = "&Anterior";
            // 
            // tbbSeparator
            // 
            this.tbbSeparator.Name = "tbbSeparator";
            this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbSiguiente
            // 
            this.tbbSiguiente.ImageIndex = 8;
            this.tbbSiguiente.Name = "tbbSiguiente";
            this.tbbSiguiente.Text = "&Siguiente";
            // 
            // tbbSeparator2
            // 
            this.tbbSeparator2.Name = "tbbSeparator2";
            this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbEjecutarConsulta
            // 
            this.tbbEjecutarConsulta.ImageIndex = 2;
            this.tbbEjecutarConsulta.Name = "tbbEjecutarConsulta";
            this.tbbEjecutarConsulta.Text = "Ejecutar Consulta[F5]";
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbReiniciarFiltros
            // 
            this.tbbReiniciarFiltros.ImageIndex = 5;
            this.tbbReiniciarFiltros.Name = "tbbReiniciarFiltros";
            this.tbbReiniciarFiltros.Text = "Reiniciar Filtros de Búsqueda";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbCancelar
            // 
            this.tbbCancelar.ImageIndex = 7;
            this.tbbCancelar.Name = "tbbCancelar";
            this.tbbCancelar.Text = "Cancelar";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            // 
            // ultraExplorerBar1
            // 
            this.ultraExplorerBar1.AnimationEnabled = false;
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
            this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl4;
            ultraExplorerBarGroup1.Settings.ContainerHeight = 24;
            ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup1.Text = "New Group";
            ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
            ultraExplorerBarGroup2.Settings.ContainerHeight = 98;
            ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup2.Text = "Filtros";
            ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl2;
            ultraExplorerBarGroup3.Settings.ContainerHeight = 314;
            ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup3.Text = "Detalle";
            this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2,
            ultraExplorerBarGroup3});
            this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
            this.ultraExplorerBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ultraExplorerBar1.Name = "ultraExplorerBar1";
            this.ultraExplorerBar1.Size = new System.Drawing.Size(1397, 471);
            this.ultraExplorerBar1.TabIndex = 80;
            // 
            // mzCmbCuenta
            // 
            this.mzCmbCuenta.AllowEditClientePaso = false;
            this.mzCmbCuenta.BackColor = System.Drawing.SystemColors.Control;
            this.mzCmbCuenta.DataValue = "";
            this.mzCmbCuenta.EnableCtaCte = false;
            this.mzCmbCuenta.FastSearch = false;
            this.mzCmbCuenta.Location = new System.Drawing.Point(80, 0);
            this.mzCmbCuenta.Margin = new System.Windows.Forms.Padding(2);
            this.mzCmbCuenta.Name = "mzCmbCuenta";
            this.mzCmbCuenta.ReseteaCodCta = false;
            this.mzCmbCuenta.SearchObjectListener = null;
            this.mzCmbCuenta.Size = new System.Drawing.Size(551, 23);
            this.mzCmbCuenta.TabIndex = 0;
            // 
            // mzCmbProveedor
            // 
            this.mzCmbProveedor.BackColor = System.Drawing.SystemColors.Control;
            this.mzCmbProveedor.DataValue = "";
            this.mzCmbProveedor.EnableCtaCte = false;
            this.mzCmbProveedor.FastSearch = false;
            this.mzCmbProveedor.Location = new System.Drawing.Point(80, 24);
            this.mzCmbProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.mzCmbProveedor.Name = "mzCmbProveedor";
            this.mzCmbProveedor.SearchObjectListener = null;
            this.mzCmbProveedor.Size = new System.Drawing.Size(551, 22);
            this.mzCmbProveedor.TabIndex = 0;
            this.mzCmbProveedor.Tag = "Proveedor";
            this.mzCmbProveedor.Visible = false;
            // 
            // gridManagerView1
            // 
            this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
            this.gridManagerView1.Location = new System.Drawing.Point(-2, -1);
            this.gridManagerView1.Name = "gridManagerView1";
            this.gridManagerView1.Size = new System.Drawing.Size(864, 24);
            this.gridManagerView1.TabIndex = 3;
            // 
            // FrmConsultarActualizacionAlicuotasIIBB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 499);
            this.Controls.Add(this.ultraExplorerBar1);
            this.Controls.Add(this.toolBarStandar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmConsultarActualizacionAlicuotasIIBB";
            this.Text = "FrmConsultarActualizacionAlicuotasIIBB";
            this.ultraExplorerBarContainerControl4.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fechaDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaHasta)).EndInit();
            this.ultraExplorerBarContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
            this.ultraExplorerBar1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolBar toolBarStandar;
        private System.Windows.Forms.ToolBarButton tbbAnterior;
        private System.Windows.Forms.ToolBarButton tbbSeparator;
        private System.Windows.Forms.ToolBarButton tbbSiguiente;
        private System.Windows.Forms.ToolBarButton tbbSeparator2;
        private System.Windows.Forms.ToolBarButton tbbCancelar;
        private System.Windows.Forms.ImageList imageList1;
        protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
        protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
        private controls.mzCuentasControl mzCmbCuenta;
        private controls.mzProveedoresControl mzCmbProveedor;
        private System.Windows.Forms.Label lblCliente;
        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
        private Janus.Windows.GridEX.GridEX gridResultado;
        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
        private System.Windows.Forms.Label labelTarea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor fechaDesde;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor fechaHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolBarButton tbbEjecutarConsulta;
        private System.Windows.Forms.ToolBarButton toolBarButton1;
        private System.Windows.Forms.ToolBarButton tbbReiniciarFiltros;
        private System.Windows.Forms.ToolBarButton toolBarButton2;
        private controls.GridManagerView gridManagerView1;
    }
}
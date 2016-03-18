using System;
using System.Drawing;
using System.Data;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.forms.classes;
using mz.erp.ui.controllers;
using mz.erp.ui.utility;
using mz.erp.commontypes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmComprobantesDeCompraPendientes.
	/// </summary>
	public class FrmComprobantesDeCompraPendientes : System.Windows.Forms.Form, ITaskForm, ISearchObjectListener
	{
		private System.Windows.Forms.ImageList imglStandar;
		protected System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton toolBarButton11;
		private System.Windows.Forms.ToolBarButton toolBarButton12;
		private System.Windows.Forms.ToolBarButton toolBarButton13;
		private System.Windows.Forms.ToolBarButton toolBarButton14;
		private System.Windows.Forms.ToolBarButton toolBarButton16;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ContainerFiltro;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		protected Janus.Windows.GridEX.GridEX gridResultado;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private HtmlRichText.HtmlRichTextBox richInfoComprobante;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbResponsableEmision;
		private System.Windows.Forms.ComboBox cboTiposDeComprobantes;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo FechaDesde;
		private System.Windows.Forms.Label label6;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo FechaHasta;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbFechaEmision;
		private System.Windows.Forms.RadioButton rbFechaVencimiento;
		private System.Windows.Forms.Label label3;
		private mz.erp.ui.controls.mzComboEditor mzCmbSubTipos;
		private mz.erp.ui.controls.mzComboEditor mzCmbTipos;
		private System.Windows.Forms.GroupBox groupBoxTiposMovimientos;
		private System.Windows.Forms.CheckBox chkHabilitaTiposMovimientos;
		private System.Windows.Forms.Label lbTarea;
		private System.Windows.Forms.RadioButton rbFechaRecepcionMercaderia;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem Detalles;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private mz.erp.ui.controls.HierarchicalSearchControl hierarchicalSearchControl1;
		private System.Windows.Forms.Label label9;
		private mz.erp.ui.controls.mzProveedoresControl mzCmb;
		private mz.erp.ui.controls.mzProductosControl mzProductosControl1;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton tbImprimir;
        private RadioButton rbFechaRegistracion;
        private RadioButton radioButton1;

		private System.ComponentModel.IContainer components;
	

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton3 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComprobantesDeCompraPendientes));
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup6 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup7 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup8 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup9 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup10 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.lbTarea = new System.Windows.Forms.Label();
            this.ContainerFiltro = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.chkHabilitaTiposMovimientos = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTiposDeComprobantes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaDesde = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.label6 = new System.Windows.Forms.Label();
            this.FechaHasta = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFechaRegistracion = new System.Windows.Forms.RadioButton();
            this.rbFechaRecepcionMercaderia = new System.Windows.Forms.RadioButton();
            this.rbFechaVencimiento = new System.Windows.Forms.RadioButton();
            this.rbFechaEmision = new System.Windows.Forms.RadioButton();
            this.groupBoxTiposMovimientos = new System.Windows.Forms.GroupBox();
            this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.label9 = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.gridResultado = new Janus.Windows.GridEX.GridEX();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.Detalles = new System.Windows.Forms.MenuItem();
            this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.imglStandar = new System.Windows.Forms.ImageList(this.components);
            this.toolBarStandar = new System.Windows.Forms.ToolBar();
            this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton11 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton12 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton13 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton14 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton16 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.tbImprimir = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
            this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.mzCmbResponsableEmision = new mz.erp.ui.controls.mzComboSearchEditor();
            this.mzCmbTipos = new mz.erp.ui.controls.mzComboEditor();
            this.mzCmbSubTipos = new mz.erp.ui.controls.mzComboEditor();
            this.mzCmb = new mz.erp.ui.controls.mzProveedoresControl();
            this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
            this.richInfoComprobante = new HtmlRichText.HtmlRichTextBox();
            this.mzProductosControl1 = new mz.erp.ui.controls.mzProductosControl();
            this.hierarchicalSearchControl1 = new mz.erp.ui.controls.HierarchicalSearchControl();
            this.ultraExplorerBarContainerControl1.SuspendLayout();
            this.ContainerFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FechaDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaHasta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxTiposMovimientos.SuspendLayout();
            this.ultraExplorerBarContainerControl4.SuspendLayout();
            this.ultraExplorerBarContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
            this.ultraExplorerBarContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
            this.ultraExplorerBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbTipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbSubTipos)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraExplorerBarContainerControl1
            // 
            this.ultraExplorerBarContainerControl1.Controls.Add(this.lbTarea);
            this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 24);
            this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(878, 17);
            this.ultraExplorerBarContainerControl1.TabIndex = 2;
            // 
            // lbTarea
            // 
            this.lbTarea.BackColor = System.Drawing.Color.Transparent;
            this.lbTarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTarea.Location = new System.Drawing.Point(0, 0);
            this.lbTarea.Name = "lbTarea";
            this.lbTarea.Size = new System.Drawing.Size(878, 16);
            this.lbTarea.TabIndex = 2;
            this.lbTarea.Text = "Tarea";
            this.lbTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContainerFiltro
            // 
            this.ContainerFiltro.Controls.Add(this.chkHabilitaTiposMovimientos);
            this.ContainerFiltro.Controls.Add(this.label3);
            this.ContainerFiltro.Controls.Add(this.mzCmbResponsableEmision);
            this.ContainerFiltro.Controls.Add(this.cboTiposDeComprobantes);
            this.ContainerFiltro.Controls.Add(this.label7);
            this.ContainerFiltro.Controls.Add(this.label2);
            this.ContainerFiltro.Controls.Add(this.label5);
            this.ContainerFiltro.Controls.Add(this.label1);
            this.ContainerFiltro.Controls.Add(this.FechaDesde);
            this.ContainerFiltro.Controls.Add(this.label6);
            this.ContainerFiltro.Controls.Add(this.FechaHasta);
            this.ContainerFiltro.Controls.Add(this.groupBox1);
            this.ContainerFiltro.Controls.Add(this.groupBoxTiposMovimientos);
            this.ContainerFiltro.Controls.Add(this.mzCmb);
            this.ContainerFiltro.Location = new System.Drawing.Point(28, 100);
            this.ContainerFiltro.Name = "ContainerFiltro";
            this.ContainerFiltro.Size = new System.Drawing.Size(878, 142);
            this.ContainerFiltro.TabIndex = 0;
            // 
            // chkHabilitaTiposMovimientos
            // 
            this.chkHabilitaTiposMovimientos.BackColor = System.Drawing.Color.Transparent;
            this.chkHabilitaTiposMovimientos.Location = new System.Drawing.Point(140, 62);
            this.chkHabilitaTiposMovimientos.Name = "chkHabilitaTiposMovimientos";
            this.chkHabilitaTiposMovimientos.Size = new System.Drawing.Size(16, 24);
            this.chkHabilitaTiposMovimientos.TabIndex = 3;
            this.chkHabilitaTiposMovimientos.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(8, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 128;
            this.label3.Text = "Tipo";
            // 
            // cboTiposDeComprobantes
            // 
            this.cboTiposDeComprobantes.Location = new System.Drawing.Point(136, 120);
            this.cboTiposDeComprobantes.Name = "cboTiposDeComprobantes";
            this.cboTiposDeComprobantes.Size = new System.Drawing.Size(336, 21);
            this.cboTiposDeComprobantes.TabIndex = 7;
            this.cboTiposDeComprobantes.Tag = "TiposDeComprobantes";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(8, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 123;
            this.label7.Tag = "FechaDesde";
            this.label7.Text = "Fecha inicio";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(8, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 122;
            this.label2.Tag = "ResponsableEmision";
            this.label2.Text = "Responsable de emisión";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(8, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 121;
            this.label5.Tag = "TiposDeComprobantes";
            this.label5.Text = "Tipos de comprobantes";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 120;
            this.label1.Tag = "Proveedor";
            this.label1.Text = "Proveedor";
            // 
            // FechaDesde
            // 
            dateButton3.Caption = "Today";
            this.FechaDesde.DateButtons.Add(dateButton3);
            this.FechaDesde.Location = new System.Drawing.Point(136, 22);
            this.FechaDesde.Name = "FechaDesde";
            this.FechaDesde.NonAutoSizeHeight = 23;
            this.FechaDesde.Size = new System.Drawing.Size(96, 21);
            this.FechaDesde.TabIndex = 1;
            this.FechaDesde.Tag = "FechaDesde";
            this.FechaDesde.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(8, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 119;
            this.label6.Tag = "FechaHasta";
            this.label6.Text = "Fecha fin";
            // 
            // FechaHasta
            // 
            dateButton1.Caption = "Today";
            this.FechaHasta.DateButtons.Add(dateButton1);
            this.FechaHasta.Location = new System.Drawing.Point(136, 43);
            this.FechaHasta.Name = "FechaHasta";
            this.FechaHasta.NonAutoSizeHeight = 23;
            this.FechaHasta.Size = new System.Drawing.Size(96, 21);
            this.FechaHasta.TabIndex = 2;
            this.FechaHasta.Tag = "FechaHasta";
            this.FechaHasta.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbFechaRegistracion);
            this.groupBox1.Controls.Add(this.rbFechaRecepcionMercaderia);
            this.groupBox1.Controls.Add(this.rbFechaVencimiento);
            this.groupBox1.Controls.Add(this.rbFechaEmision);
            this.groupBox1.Location = new System.Drawing.Point(239, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 40);
            this.groupBox1.TabIndex = 125;
            this.groupBox1.TabStop = false;
            // 
            // rbFechaRegistracion
            // 
            this.rbFechaRegistracion.AutoSize = true;
            this.rbFechaRegistracion.Location = new System.Drawing.Point(482, 23);
            this.rbFechaRegistracion.Name = "rbFechaRegistracion";
            this.rbFechaRegistracion.Size = new System.Drawing.Size(136, 17);
            this.rbFechaRegistracion.TabIndex = 11;
            this.rbFechaRegistracion.TabStop = true;
            this.rbFechaRegistracion.Text = "Por Fecha Registración";
            this.rbFechaRegistracion.UseVisualStyleBackColor = true;
            // 
            // rbFechaRecepcionMercaderia
            // 
            this.rbFechaRecepcionMercaderia.Location = new System.Drawing.Point(271, 19);
            this.rbFechaRecepcionMercaderia.Name = "rbFechaRecepcionMercaderia";
            this.rbFechaRecepcionMercaderia.Size = new System.Drawing.Size(205, 24);
            this.rbFechaRecepcionMercaderia.TabIndex = 10;
            this.rbFechaRecepcionMercaderia.Text = "Por Fecha Recepción de Mercadería";
            // 
            // rbFechaVencimiento
            // 
            this.rbFechaVencimiento.Location = new System.Drawing.Point(129, 19);
            this.rbFechaVencimiento.Name = "rbFechaVencimiento";
            this.rbFechaVencimiento.Size = new System.Drawing.Size(147, 24);
            this.rbFechaVencimiento.TabIndex = 9;
            this.rbFechaVencimiento.Text = "Por Fecha Vencimiento";
            // 
            // rbFechaEmision
            // 
            this.rbFechaEmision.Location = new System.Drawing.Point(8, 16);
            this.rbFechaEmision.Name = "rbFechaEmision";
            this.rbFechaEmision.Size = new System.Drawing.Size(128, 24);
            this.rbFechaEmision.TabIndex = 8;
            this.rbFechaEmision.Text = "Por Fecha Emisión";
            // 
            // groupBoxTiposMovimientos
            // 
            this.groupBoxTiposMovimientos.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTiposMovimientos.Controls.Add(this.mzCmbTipos);
            this.groupBoxTiposMovimientos.Controls.Add(this.mzCmbSubTipos);
            this.groupBoxTiposMovimientos.Location = new System.Drawing.Point(136, 61);
            this.groupBoxTiposMovimientos.Name = "groupBoxTiposMovimientos";
            this.groupBoxTiposMovimientos.Size = new System.Drawing.Size(496, 35);
            this.groupBoxTiposMovimientos.TabIndex = 129;
            this.groupBoxTiposMovimientos.TabStop = false;
            // 
            // ultraExplorerBarContainerControl4
            // 
            this.ultraExplorerBarContainerControl4.Controls.Add(this.mzProductosControl1);
            this.ultraExplorerBarContainerControl4.Controls.Add(this.hierarchicalSearchControl1);
            this.ultraExplorerBarContainerControl4.Controls.Add(this.label9);
            this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, 301);
            this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
            this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(878, 84);
            this.ultraExplorerBarContainerControl4.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(8, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 55;
            this.label9.Text = "Producto";
            // 
            // ultraExplorerBarContainerControl2
            // 
            this.ultraExplorerBarContainerControl2.Controls.Add(this.gridManagerView1);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.gridResultado);
            this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, -45);
            this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
            this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(878, 205);
            this.ultraExplorerBarContainerControl2.TabIndex = 1;
            // 
            // gridResultado
            // 
            this.gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridResultado.ContextMenu = this.contextMenu1;
            this.gridResultado.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridResultado.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridResultado.GroupByBoxVisible = false;
            this.gridResultado.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridResultado.Location = new System.Drawing.Point(0, 24);
            this.gridResultado.Name = "gridResultado";
            this.gridResultado.Size = new System.Drawing.Size(872, 184);
            this.gridResultado.TabIndex = 1;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Detalles});
            // 
            // Detalles
            // 
            this.Detalles.Index = 0;
            this.Detalles.Text = "Ver detalles";
            // 
            // ultraExplorerBarContainerControl3
            // 
            this.ultraExplorerBarContainerControl3.Controls.Add(this.richInfoComprobante);
            this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 219);
            this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
            this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(878, 150);
            this.ultraExplorerBarContainerControl3.TabIndex = 3;
            // 
            // imglStandar
            // 
            this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
            this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
            this.imglStandar.Images.SetKeyName(0, "");
            this.imglStandar.Images.SetKeyName(1, "");
            this.imglStandar.Images.SetKeyName(2, "");
            this.imglStandar.Images.SetKeyName(3, "");
            this.imglStandar.Images.SetKeyName(4, "");
            this.imglStandar.Images.SetKeyName(5, "");
            this.imglStandar.Images.SetKeyName(6, "");
            this.imglStandar.Images.SetKeyName(7, "");
            this.imglStandar.Images.SetKeyName(8, "");
            this.imglStandar.Images.SetKeyName(9, "");
            this.imglStandar.Images.SetKeyName(10, "");
            this.imglStandar.Images.SetKeyName(11, "");
            // 
            // toolBarStandar
            // 
            this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbAnterior,
            this.tbbSeparator,
            this.tbbSiguiente,
            this.toolBarButton11,
            this.toolBarButton12,
            this.toolBarButton13,
            this.toolBarButton14,
            this.toolBarButton16,
            this.toolBarButton2,
            this.tbImprimir,
            this.toolBarButton1,
            this.tbbCancelar});
            this.toolBarStandar.DropDownArrows = true;
            this.toolBarStandar.ImageList = this.imglStandar;
            this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
            this.toolBarStandar.Name = "toolBarStandar";
            this.toolBarStandar.ShowToolTips = true;
            this.toolBarStandar.Size = new System.Drawing.Size(944, 28);
            this.toolBarStandar.TabIndex = 20;
            this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            // 
            // tbbAnterior
            // 
            this.tbbAnterior.ImageIndex = 10;
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
            this.tbbSiguiente.ImageIndex = 11;
            this.tbbSiguiente.Name = "tbbSiguiente";
            this.tbbSiguiente.Text = "&Siguiente";
            // 
            // toolBarButton11
            // 
            this.toolBarButton11.Name = "toolBarButton11";
            this.toolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // toolBarButton12
            // 
            this.toolBarButton12.ImageIndex = 2;
            this.toolBarButton12.Name = "toolBarButton12";
            this.toolBarButton12.Text = "Ejecutar Consulta [F5]";
            // 
            // toolBarButton13
            // 
            this.toolBarButton13.Name = "toolBarButton13";
            this.toolBarButton13.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // toolBarButton14
            // 
            this.toolBarButton14.ImageIndex = 5;
            this.toolBarButton14.Name = "toolBarButton14";
            this.toolBarButton14.Text = "Reiniciar Filtros de Busqueda";
            // 
            // toolBarButton16
            // 
            this.toolBarButton16.ImageIndex = 9;
            this.toolBarButton16.Name = "toolBarButton16";
            this.toolBarButton16.Text = "&Selección";
            this.toolBarButton16.Visible = false;
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbImprimir
            // 
            this.tbImprimir.ImageIndex = 8;
            this.tbImprimir.Name = "tbImprimir";
            this.tbImprimir.Text = "Imprimir";
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbCancelar
            // 
            this.tbbCancelar.ImageIndex = 7;
            this.tbbCancelar.Name = "tbbCancelar";
            this.tbbCancelar.Text = "Cancelar";
            // 
            // ultraExplorerBar1
            // 
            this.ultraExplorerBar1.Controls.Add(this.ContainerFiltro);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
            this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            ultraExplorerBarGroup6.Container = this.ultraExplorerBarContainerControl1;
            ultraExplorerBarGroup6.Key = "Tarea";
            ultraExplorerBarGroup6.Settings.ContainerHeight = 17;
            ultraExplorerBarGroup6.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraExplorerBarGroup6.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup6.Text = "Tarea";
            ultraExplorerBarGroup7.Container = this.ContainerFiltro;
            ultraExplorerBarGroup7.Key = "FiltroPrincipal";
            ultraExplorerBarGroup7.Settings.ContainerHeight = 142;
            ultraExplorerBarGroup7.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup7.Text = "Filtro Inicial";
            ultraExplorerBarGroup8.Container = this.ultraExplorerBarContainerControl4;
            ultraExplorerBarGroup8.Key = "FiltroProductos";
            ultraExplorerBarGroup8.Settings.ContainerHeight = 84;
            ultraExplorerBarGroup8.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup8.Text = "Filtro de productos";
            ultraExplorerBarGroup9.Container = this.ultraExplorerBarContainerControl2;
            ultraExplorerBarGroup9.Key = "Resultado";
            ultraExplorerBarGroup9.Settings.ContainerHeight = 205;
            ultraExplorerBarGroup9.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup9.Text = "Resultado";
            ultraExplorerBarGroup10.Container = this.ultraExplorerBarContainerControl3;
            ultraExplorerBarGroup10.Key = "Detalles";
            ultraExplorerBarGroup10.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup10.Text = "Contenido del Comprobante";
            ultraExplorerBarGroup10.Visible = false;
            this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup6,
            ultraExplorerBarGroup7,
            ultraExplorerBarGroup8,
            ultraExplorerBarGroup9,
            ultraExplorerBarGroup10});
            this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
            this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
            this.ultraExplorerBar1.Size = new System.Drawing.Size(944, 394);
            this.ultraExplorerBar1.TabIndex = 21;
            this.ultraExplorerBar1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(493, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(148, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Por fecha de Registración";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // mzCmbResponsableEmision
            // 
            this.mzCmbResponsableEmision.DataValue = "";
            this.mzCmbResponsableEmision.EditObject = null;
            this.mzCmbResponsableEmision.FastSearch = false;
            this.mzCmbResponsableEmision.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mzCmbResponsableEmision.HierarchicalSearch = false;
            this.mzCmbResponsableEmision.Location = new System.Drawing.Point(136, 97);
            this.mzCmbResponsableEmision.Name = "mzCmbResponsableEmision";
            this.mzCmbResponsableEmision.ReadOnly = false;
            this.mzCmbResponsableEmision.SearchObject = null;
            this.mzCmbResponsableEmision.SearchObjectListener = null;
            this.mzCmbResponsableEmision.Size = new System.Drawing.Size(496, 22);
            this.mzCmbResponsableEmision.TabIndex = 6;
            this.mzCmbResponsableEmision.Tag = "ResponsableEmision";
            // 
            // mzCmbTipos
            // 
            this.mzCmbTipos.AutoComplete = true;
            this.mzCmbTipos.AutoSize = true;
            this.mzCmbTipos.DataSource = null;
            this.mzCmbTipos.DisplayMember = "";
            this.mzCmbTipos.DisplayMemberCaption = "";
            this.mzCmbTipos.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbTipos.Location = new System.Drawing.Point(24, 10);
            this.mzCmbTipos.MaxItemsDisplay = 50;
            this.mzCmbTipos.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbTipos.Name = "mzCmbTipos";
            this.mzCmbTipos.Size = new System.Drawing.Size(217, 21);
            this.mzCmbTipos.SorterMember = "";
            this.mzCmbTipos.TabIndex = 4;
            this.mzCmbTipos.ValueMember = "";
            this.mzCmbTipos.ValueMemberCaption = "";
            // 
            // mzCmbSubTipos
            // 
            this.mzCmbSubTipos.AutoComplete = true;
            this.mzCmbSubTipos.AutoSize = true;
            this.mzCmbSubTipos.DataSource = null;
            this.mzCmbSubTipos.DisplayMember = "";
            this.mzCmbSubTipos.DisplayMemberCaption = "";
            this.mzCmbSubTipos.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbSubTipos.Location = new System.Drawing.Point(263, 10);
            this.mzCmbSubTipos.MaxItemsDisplay = 50;
            this.mzCmbSubTipos.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbSubTipos.Name = "mzCmbSubTipos";
            this.mzCmbSubTipos.Size = new System.Drawing.Size(217, 21);
            this.mzCmbSubTipos.SorterMember = "";
            this.mzCmbSubTipos.TabIndex = 5;
            this.mzCmbSubTipos.ValueMember = "";
            this.mzCmbSubTipos.ValueMemberCaption = "";
            // 
            // mzCmb
            // 
            this.mzCmb.BackColor = System.Drawing.SystemColors.Control;
            this.mzCmb.DataValue = "";
            this.mzCmb.EnableCtaCte = false;
            this.mzCmb.FastSearch = false;
            this.mzCmb.Location = new System.Drawing.Point(136, 0);
            this.mzCmb.Name = "mzCmb";
            this.mzCmb.SearchObjectListener = null;
            this.mzCmb.Size = new System.Drawing.Size(490, 22);
            this.mzCmb.TabIndex = 0;
            this.mzCmb.Tag = "ResponsableEmision";
            // 
            // gridManagerView1
            // 
            this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
            this.gridManagerView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridManagerView1.Location = new System.Drawing.Point(0, 0);
            this.gridManagerView1.Name = "gridManagerView1";
            this.gridManagerView1.Size = new System.Drawing.Size(878, 24);
            this.gridManagerView1.TabIndex = 0;
            // 
            // richInfoComprobante
            // 
            this.richInfoComprobante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richInfoComprobante.Location = new System.Drawing.Point(0, 0);
            this.richInfoComprobante.Name = "richInfoComprobante";
            this.richInfoComprobante.Size = new System.Drawing.Size(878, 150);
            this.richInfoComprobante.TabIndex = 90;
            this.richInfoComprobante.Text = "";
            // 
            // mzProductosControl1
            // 
            this.mzProductosControl1.BackColor = System.Drawing.Color.Transparent;
            this.mzProductosControl1.EnabledCantidad = true;
            this.mzProductosControl1.EnabledListaDePrecio = true;
            this.mzProductosControl1.Location = new System.Drawing.Point(104, 0);
            this.mzProductosControl1.Name = "mzProductosControl1";
            this.mzProductosControl1.Size = new System.Drawing.Size(408, 40);
            this.mzProductosControl1.TabIndex = 0;
            this.mzProductosControl1.VisibleCantidad = true;
            this.mzProductosControl1.VisibleComboListaDePrecios = true;
            this.mzProductosControl1.VisibleComboTipoDePrecioDeCosto = false;
            this.mzProductosControl1.VisiblePrecios = true;
            // 
            // hierarchicalSearchControl1
            // 
            this.hierarchicalSearchControl1.BackColor = System.Drawing.Color.Transparent;
            this.hierarchicalSearchControl1.Location = new System.Drawing.Point(8, 40);
            this.hierarchicalSearchControl1.Name = "hierarchicalSearchControl1";
            this.hierarchicalSearchControl1.Size = new System.Drawing.Size(784, 95);
            this.hierarchicalSearchControl1.TabIndex = 1;
            // 
            // FrmComprobantesDeCompraPendientes
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(944, 422);
            this.Controls.Add(this.ultraExplorerBar1);
            this.Controls.Add(this.toolBarStandar);
            this.Name = "FrmComprobantesDeCompraPendientes";
            this.Text = "Comprobantes de compra pendientes";
            this.ultraExplorerBarContainerControl1.ResumeLayout(false);
            this.ContainerFiltro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FechaDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaHasta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxTiposMovimientos.ResumeLayout(false);
            this.ultraExplorerBarContainerControl4.ResumeLayout(false);
            this.ultraExplorerBarContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
            this.ultraExplorerBarContainerControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
            this.ultraExplorerBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbTipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbSubTipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
		#region Constructores y Destructores
		public FrmComprobantesDeCompraPendientes()
		{
			InitializeComponent();			
		}
		public FrmComprobantesDeCompraPendientes(controllers.SeleccionarComprobantesDeCompraPendientesController controller)
		{
			InitializeComponent();
			_uiController = controller;
			Build_UI();
		}
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
				_uiController.DataChanged -=new EventHandler(RefreshData);
				_uiController.CuentaImputacionChanged -=new EventHandler(_uiController_CuentaImputacionChanged);
				BindingController.Clear(cboTiposDeComprobantes, "Text", _uiController, "FamiliaComprobantes");
			}
			base.Dispose( disposing );
		}
		#endregion
		#region Variables Privadas
		private controllers.SeleccionarComprobantesDeCompraPendientesController _uiController = null;
		private bool _allowShowDetails = false;
        //Cristian Tarea 0000146 20110718
        private bool _updateFechaDesde = true;
        //Fin Cristian Tarea 0000146
		#endregion
		#region Inicializadores y Carga
		protected void Build_UI()
		{
			ConfigureInterface();	
			InitializeData();
			InitEventHandlers();
			InitDataBindings();		
			FillControls();
			RefreshData();
		}


		private void FillControls()
		{
			mzCmbTipos.Value = _uiController.IdTipoMovimiento;
			mzCmbSubTipos.Value = _uiController.IdSubTipoMovimiento;
			mzCmbResponsableEmision.DataValue = _uiController.ResponsableEmision;
		}


		private void ConfigureInterface()
		{						
			this.Text = _uiController.LeyendaFormulario;
			//mzCEProductos.SearchObject= _uiController.SearchProducto;
			mzProductosControl1.SetProcess(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), "");
			mzCmb.Init();
			mzCmb.SearchObjectListener = this;
			mzCmb.EnableCtaCte = _uiController.EnabledButtonCuentaCtaCte;
			mzCmbResponsableEmision.SearchObject = typeof( mz.erp.ui.forms.classes.tsh_Personas );			
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), gridResultado, this.Text);
			lbTarea.Text = _uiController.LeyendaFormulario;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			this.gridResultado.AutomaticSort = true;
			this.KeyPreview = true;		
			//rbFechaEmision.Checked = _uiController.PorFechaEmision;
			//rbFechaVencimiento.Checked = _uiController.PorFechaVencimiento;
			//rbFechaRecepcionMercaderia.Checked = _uiController.PorFechaRecepcionMercaderia;

            //Cristian 20100917 Tarea 836
            ConfigureFiltroFechaValorPorDefault();
            //Fin Cristian 20100917 Tarea 836

			ConfigureTiposComprobantes();
			//mzCEProductos.WidthSearchForm = 800;
			this.hierarchicalSearchControl1.Build_UI("PRODUCTOS",_uiController.AllowMultipleSelect);			
		
			chkHabilitaTiposMovimientos.Enabled = _uiController.HabilitaFiltroTipoMovimiento;
			mzCmbSubTipos.Enabled = _uiController.PorTipoMovimiento;
			mzCmbTipos.Enabled = _uiController.PorTipoMovimiento;
			if (_uiController.AllowMultipleSelect)
			{
				gridResultado.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
			}
			else
			{
				gridResultado.SelectionMode = Janus.Windows.GridEX.SelectionMode.SingleSelection;
			}


			foreach( Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup group in this.ultraExplorerBar1.Groups)
			{				
				group.Visible = false;
				if (group.Container != null)
					group.Container.Enabled = false;
			}
			if(!_uiController.ContenedoresVisibles.Equals(string.Empty))
			{
				ArrayList cont = mz.erp.systemframework.Util.Parse(_uiController.ContenedoresVisibles, ",");
				foreach(string grupo in cont)
				{
					this.ultraExplorerBar1.Groups[grupo].Visible = true;
				}
				_allowShowDetails = cont.Contains("Detalles");
			}

			if(!_uiController.ContenedoresHabilitados.Equals(string.Empty))
			{								
				ArrayList cont = mz.erp.systemframework.Util.Parse(_uiController.ContenedoresHabilitados, ",");
				foreach(string grupo in cont)
				{
					if (this.ultraExplorerBar1.Groups[grupo].Container != null)
						this.ultraExplorerBar1.Groups[grupo].Container.Enabled = true;
				}
			}
            mz.erp.ui.forms.classes.ContainerManager.UpdateSize(this.ultraExplorerBarContainerControl4, hierarchicalSearchControl1);

			mz.erp.ui.forms.classes.ContainerManager.CollapseContainers(ultraExplorerBar1, _uiController.GetProcessName(), _uiController.GetTaskName());
		}



		private void ConfigureTiposComprobantes()
		{
			object defaultValue = null;
			string _listaFamiliaDeComprobantes = _uiController.ListaFamiliaDeComprobantes;
			string _familiaDefault = _uiController.FamiliaDefault;

			if(_listaFamiliaDeComprobantes == null || _listaFamiliaDeComprobantes.Equals(string.Empty))
				cboTiposDeComprobantes.Items.AddRange(new object [] {_uiController.TodosLosComprobantes,"Facturas", "Presupuestos",/*"Notas de Débito",*/"Notas de Crédito","Prefacturas","Remitos","Pedidos","Confirmación de Pedido","Preremitos","Recibos"});
			else
			{
				ArrayList aux = new ArrayList();
				aux.Add(_uiController.TodosLosComprobantes);
				aux.AddRange(mz.erp.systemframework.Util.Parse(_listaFamiliaDeComprobantes,","));
				cboTiposDeComprobantes.Items.AddRange(aux.ToArray());					
			}
			cboTiposDeComprobantes.SelectedItem = _uiController.TodosLosComprobantes;
			_uiController.FamiliaComprobantes = _uiController.TodosLosComprobantes;
			if (_familiaDefault != "")
			{
				cboTiposDeComprobantes.SelectedItem = (string)_familiaDefault;
				_uiController.FamiliaComprobantes = (string)_familiaDefault;
			}
			cboTiposDeComprobantes.Enabled = _uiController.HabilitaFamiliasComprobantes;
		}

		private void InitializeData()
		{
			FechaDesde.Value = _uiController.FechaDesde;
			FechaHasta.Value = _uiController.FechaHasta;
			chkHabilitaTiposMovimientos.Checked = _uiController.PorTipoMovimiento;
			mzCmbTipos.FillFromDataSource( _uiController.Tipos, _uiController.KeyValueTipos,_uiController.KeyListTipos,100, _uiController.KeyListTipos );
			mzCmbSubTipos.FillFromDataSource( _uiController.SubTipos, _uiController.KeyValueSubTipos,_uiController.KeyListTipos,100, _uiController.KeyValueSubTipos ,_uiController.KeyListTipos, null, _uiController.Filter  );
			
		}
		private void InitEventHandlers()
		{			
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			_uiController.DataChanged+=new EventHandler(RefreshData);
			this.KeyDown +=new KeyEventHandler(KeyDownBehavior);
			_uiController.CuentaImputacionChanged +=new EventHandler(_uiController_CuentaImputacionChanged);
			if(_uiController.HabilitaFiltroTipoMovimiento)
				chkHabilitaTiposMovimientos.CheckedChanged +=new EventHandler(chkHabilitaTiposMovimientos_CheckedChanged);
			mzCmbTipos.ValueChanged +=new EventHandler(_uiController_CuentaImputacionChanged);
			this.Detalles.Click +=new EventHandler(Detalles_Click);
			this.gridResultado.Click +=new EventHandler(gridResultado_Click);
			hierarchicalSearchControl1.OnSelected+=new EventHandler(hierarchicalSearchControl1_OnSelected);
			KeyDownManager KeyDown = new KeyDownManager(this);
        //Cristian Tarea 0000050 20110310
            this.FechaDesde.ValueChanged += new EventHandler(FechaDesde_ValueChanged);
            this.FechaHasta.ValueChanged +=new EventHandler(FechaHasta_ValueChanged);
         //Fin Cristian

		}

        //Cristian Tarea 0000146 20110719
        void FechaHasta_ValueChanged(object sender, EventArgs e)
        {

             _uiController.updateFechas((Convert.ToDateTime(FechaHasta.Value)), true);
            this.FechaDesde.Value = _uiController.FechaDesde;

        }
        //Fin Cristian Tarea 0000146
        //Cristian Tarea 0000050 20110310
        void FechaDesde_ValueChanged(object sender, EventArgs e)
        {

             _uiController.updateFechas((Convert.ToDateTime(FechaDesde.Value)) ,false);
             this.FechaHasta.Value = _uiController.FechaHasta;
 
        }
        //Fin Cristian
		private void _uiController_CuentaImputacionChanged(object sender, EventArgs e)
		{
			_uiController.IdTipoMovimiento = Convert.ToString(mzCmbTipos.Value);
			mzCmbSubTipos.FillFromDataSource( _uiController.SubTipos, _uiController.KeyValueSubTipos,_uiController.KeyListTipos,100, _uiController.KeyValueSubTipos ,_uiController.KeyListTipos ,null, _uiController.Filter );			//mzCmbSubTipos.Value = _uiController.IdSubTipoMovimiento;
			if(mzCmbSubTipos.Items.Count > 0)
			{
				mzCmbSubTipos.Value = mzCmbSubTipos.Items[0].DataValue;
				_uiController.IdSubTipoMovimiento = Convert.ToString(mzCmbSubTipos.Value);
			}

		}



		private void Componentes_Changes( object sender, System.EventArgs e)
		{			
			
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
	
		private void InitDataBindings()
		{							
			BindingController.Bind(cboTiposDeComprobantes, "Text", _uiController, "FamiliaComprobantes");
			//mzCEProductos.DataBindings.Add("DataValue", _uiController, "Codigo");
			mzProductosControl1.AddObjectListener( (IObserver)_uiController );
		}
		
		#endregion
		#region Miembros de ITaskForm

		public void Execute()
		{
			gridResultado.UpdateData();
			if(gridResultado.SelectedItems.Count > 0)
			{
				DialogResult result = DialogResult.Yes;
				if (_uiController.PreguntarAlGuardar)
					result = MessageBox.Show("¿Esta seguro que desea confirmar esta operación?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		
				if(result == DialogResult.Yes)
				{

					if(gridResultado.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
					{
						ArrayList arrayIdComprobantesPendientes = new ArrayList();
						ArrayList selectedItems = new ArrayList();
						if (gridResultado.SelectedItems.Count > 0) 
						{
							for (int i=0;i<gridResultado.SelectedItems.Count;i++)
							{
								arrayIdComprobantesPendientes.Add( gridResultado.SelectedItems[i].GetRow().Cells["IdComprobante"].Value );
								DataRow rowAux = null;
								if(gridResultado.SelectedItems[i].GetRow().DataRow.GetType().Equals(typeof(System.Data.DataRowView)))
								{
									rowAux = (DataRow)((DataRowView)gridResultado.SelectedItems[i].GetRow().DataRow).Row;
									selectedItems.Add(rowAux );
								}
								else
									if(gridResultado.SelectedItems[i].GetRow().DataRow.GetType().Equals(typeof(System.Data.DataRow)))
								{
									rowAux = (DataRow)(gridResultado.SelectedItems[i].GetRow().DataRow);
									selectedItems.Add(rowAux );
								}
							}
						}
						_uiController.ArrayComprobantesPendientes = arrayIdComprobantesPendientes;
						_uiController.HasShowSeleccionItems = true;
						_uiController.Execute();
					}
				}
			}
		}

		public void Previous()
		{
			this._uiController.Previous();
		}

		public void ShowForm()
		{
				this.Show();
			
			/*if(this._uiController.AllowShow())
			{
				this.Build_UI();
				this.Show();
			}
			else
			{
				if(_uiController.IsNextState())
					this._uiController.Execute();
				else
					if(_uiController.IsBackState())
					this._uiController.Previous();
			}*/
		}

		public void CloseForm()
		{			
			if (_uiController.PreguntarAlCancelar)
			{
				if ((MessageBox.Show(this,"Está a punto de cerrar el fomulario. Realmente desea realizar esta operación?","Atención!",System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Stop )== System.Windows.Forms.DialogResult.OK))
					Close();
			}
			else
			{
				Close();
			}
		}

		public void KeyDownPrevious()
		{
			_uiController.Previous();
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

		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			int index = toolBarStandar.Buttons.IndexOf( e.Button ) ;
			switch ( index)
			{
				case 0:
					_uiController.Previous();
					break;
				case 2:

					this.Execute();

					break;
				case 4:					
					RefreshData();
					break;
				case 6:					
					ResetFilters();
					break;
				case 9:					
					PrintComprobante();									
					break;
				case 11:
					CloseForm();
					break;

			}				
		}
		protected void RefreshData()
		{
			Util.MoveFocus(this.ContainerFiltro);
			this.Cursor = Cursors.WaitCursor;
			gridResultado.Focus();
			this.DumpControls();		
			_uiController.RefreshData();

			/*if(this._allowShowDetails)
			{
				if(gridResultado.RecordCount > 0)
				{
					gridResultado.Row = 0;
					//this.gridResultado_SelectionChanged(gridResultado, new EventArgs())	;
				}
			}*/
			this.Cursor = Cursors.Default;
		}

		private void DumpControls()
		{
			_uiController.ResponsableEmision = Convert.ToString(mzCmbResponsableEmision.DataValue);
			_uiController.CodigoProveedor = Convert.ToString(mzCmb.DataValue);
			_uiController.FechaDesde = Convert.ToDateTime(FechaDesde.Value);
			_uiController.FechaHasta = Convert.ToDateTime(FechaHasta.Value);
			_uiController.PorFechaEmision = rbFechaEmision.Checked;
			_uiController.PorFechaVencimiento = rbFechaVencimiento.Checked;
			_uiController.PorFechaRecepcionMercaderia = rbFechaRecepcionMercaderia.Checked;

            //Cristian 20100917 Tarea 836 
            _uiController.PorFechaRegistracion = rbFechaRegistracion.Checked;
            //Fin Cristian 2010 Tarea 836

			_uiController.PorTipoMovimiento = chkHabilitaTiposMovimientos.Checked;
			_uiController.IdTipoMovimiento = Convert.ToString(mzCmbTipos.Value);
			_uiController.IdSubTipoMovimiento = Convert.ToString(mzCmbSubTipos.Value);
		}
		
		private void RefreshData(object sender, EventArgs e)
		{			
			gridResultado.SetDataBinding(null, null);
			gridResultado.SetDataBinding(_uiController.Result, null);
			if (gridManagerView1.AllowGroupCollapse)
				this.gridResultado.CollapseGroups();
			else
				if (gridResultado.RootTable.Groups.Count > 0 )
				gridResultado.RootTable.Groups[0].Expand();
			if (gridManagerView1.AllowExportExcel || gridManagerView1.AllowSortByAgregateColumn)
				gridManagerView1.SetTable(_uiController.Result);
		}

		private void ResetFilters()
		{
			// Filtro ppal
			_uiController.ResetFilters();
            
			mzCmbResponsableEmision.DataValue=_uiController.ResponsableEmision;
			//mzCmb.DataValue=_uiController.CodigoProveedor;
			mzCmb.ClearControl();
			
			FechaDesde.Value=_uiController.FechaDesde;
			FechaHasta.Value=_uiController.FechaHasta;

			if (_uiController.HabilitaFiltroTipoMovimiento)
			{
				chkHabilitaTiposMovimientos.Enabled=true;
				chkHabilitaTiposMovimientos.Checked=false;				
			}
			else
			{
				chkHabilitaTiposMovimientos.Enabled=false;
				chkHabilitaTiposMovimientos.Checked=false;
				
			}
			mzCmbTipos.Value=_uiController.IdTipoMovimiento;
			mzCmbSubTipos.Value=_uiController.IdSubTipoMovimiento;
			mzCmbTipos.Enabled=false;
			mzCmbSubTipos.Enabled=false;

            //rbFechaEmision.Checked=_uiController.PorFechaEmision;		
			//rbFechaVencimiento.Checked=_uiController.PorFechaVencimiento;
			//rbFechaRecepcionMercaderia.Checked=_uiController.PorFechaRecepcionMercaderia;
			
            //Cristian 20100917 Tarea 836
            ConfigureFiltroFechaValorPorDefault();
            //Fin Cristian 20100917 Tarea 836

			gridResultado.SetDataBinding(null, null);
			gridResultado.Refresh();
		}

		private void chkHabilitaTiposMovimientos_CheckedChanged(object sender, EventArgs e)
		{
			mzCmbTipos.Enabled = chkHabilitaTiposMovimientos.Checked;
			mzCmbSubTipos.Enabled = chkHabilitaTiposMovimientos.Checked;
		}

		private void Detalles_Click(object sender, EventArgs e)
		{
			bool visualizaDetalle = _uiController.VisualizaDetalle;
			string metodoVisualizacion = _uiController.MetodoVisualizacion;
			if(visualizaDetalle && metodoVisualizacion.Equals("PORDEMANDA"))
			{
				if(gridResultado.SelectedItems.Count > 0 && gridResultado.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
				{
					string IdComprobante = Convert.ToString(gridResultado.SelectedItems[0].GetRow().Cells["IdComprobante"].Value);
					string IdTipoDeComprobante = Convert.ToString(gridResultado.SelectedItems[0].GetRow().Cells["IdTipoDeComprobante"].Value);
					if(!IdComprobante.Equals(string.Empty) && !IdTipoDeComprobante.Equals(string.Empty))
					{
						this.richInfoComprobante.Clear();
						string datos = mz.erp.businessrules.Workflow.GetHTMLComprobantes(IdComprobante, IdTipoDeComprobante);
						this.richInfoComprobante.AddHTML(datos);
					}
					else this.richInfoComprobante.Clear();
					//ReportsManager.PrintReportComprobantes( IdComprobante, this.MdiParent) ;
				}
			}
			else
			{
				if(visualizaDetalle && metodoVisualizacion.Equals("AUTOMATICO"))
				{
					if(this.gridResultado.SelectedItems.Count > 0)
					{
						string datos = string.Empty;
						if (gridResultado.SelectedItems.Count == 1 &&  gridResultado.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
						{
							foreach(Janus.Windows.GridEX.GridEXColumn col in gridResultado.RootTable.Columns)
							{
								if(col.Key.Equals("TextoHTML"))
									datos = Convert.ToString(this.gridResultado.SelectedItems[0].GetRow().Cells["TextoHTML"].Value);
							}
						}		
						this.richInfoComprobante.Clear();
						this.richInfoComprobante.AddHTML(datos);
					}
				}
			}
		}

		private void gridResultado_Click(object sender, EventArgs e)
		{
			bool visualizaDetalle = _uiController.VisualizaDetalle;
			string metodoVisualizacion = _uiController.MetodoVisualizacion;
			if(visualizaDetalle && metodoVisualizacion.Equals("PORDEMANDA"))
			{
				if(gridResultado.SelectedItems.Count > 0 && gridResultado.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
				{
					string IdComprobante = Convert.ToString(gridResultado.SelectedItems[0].GetRow().Cells["IdComprobante"].Value);
					string IdTipoDeComprobante = Convert.ToString(gridResultado.SelectedItems[0].GetRow().Cells["IdTipoDeComprobante"].Value);
					if(!IdComprobante.Equals(string.Empty) && !IdTipoDeComprobante.Equals(string.Empty))
					{
						this.richInfoComprobante.Clear();
						string datos = mz.erp.businessrules.Workflow.GetHTMLComprobantesResumido(IdComprobante, IdTipoDeComprobante);
						this.richInfoComprobante.AddHTML(datos);
					}
					else this.richInfoComprobante.Clear();
					//ReportsManager.PrintReportComprobantes( IdComprobante, this.MdiParent) ;
				}
			}
		}

        //Cristian 20100917 Tarea 836
        private void ConfigureFiltroFechaValorPorDefault()
        {
            rbFechaRegistracion.Checked = false;
            rbFechaVencimiento.Checked = false;
            rbFechaEmision.Checked = false;
            rbFechaRecepcionMercaderia.Checked = false;
            string filtroFecha = _uiController.FiltroFechaValorPorDefault;
       		switch ( filtroFecha )
			{
                case "FV":
                    rbFechaVencimiento.Checked = true;
					break;

                case "FRM":
                    rbFechaRecepcionMercaderia.Checked = true;
                    break;
                case "FR":
                    rbFechaRegistracion.Checked = true;
                    break;
                default:
                    rbFechaEmision.Checked = true;
                    break;	
            }

        }
        //Fin Cristian 20100917 Tarea 836

		protected void PrintComprobante()
		{
			if( _uiController.VisualizaBotonImprimir)
			{
				if ((gridResultado.RecordCount > 0 ) && (gridResultado.SelectedItems.Count > 0))
				{
					if(gridResultado.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
					{
						this.Cursor = Cursors.WaitCursor;
						string IdComprobante = Convert.ToString(gridResultado.SelectedItems[0].GetRow().Cells["IdComprobante"].Value);					
						string IdTipoDeComprobante = Convert.ToString(gridResultado.SelectedItems[0].GetRow().Cells["IdTipoDeComprobante"].Value);					
						ReportsManager.PrintReportComprobantesCompras( IdComprobante, IdTipoDeComprobante, this.MdiParent) ;
						this.Cursor = Cursors.Default;
					}
				}
			}
		}

		private void hierarchicalSearchControl1_OnSelected(object sender, EventArgs e)
		{			
			_uiController.ByJerarquia1 = hierarchicalSearchControl1.NodeChecked1;
			_uiController.Jerarquias1 = hierarchicalSearchControl1.ItemsJerarquia1;
			_uiController.ByJerarquia2 = hierarchicalSearchControl1.NodeChecked2;
			_uiController.Jerarquias2 = hierarchicalSearchControl1.ItemsJerarquia2;
			_uiController.ByJerarquia3 = hierarchicalSearchControl1.NodeChecked3;
			_uiController.Jerarquias3 = hierarchicalSearchControl1.ItemsJerarquia3;
			_uiController.ByJerarquia4 = hierarchicalSearchControl1.NodeChecked4;
			_uiController.Jerarquias4 = hierarchicalSearchControl1.ItemsJerarquia4;
			_uiController.ByJerarquia5 = hierarchicalSearchControl1.NodeChecked5;
			_uiController.Jerarquias5 = hierarchicalSearchControl1.ItemsJerarquia5;
			_uiController.ByJerarquia6 = hierarchicalSearchControl1.NodeChecked6;
			_uiController.Jerarquias6 = hierarchicalSearchControl1.ItemsJerarquia6;
			_uiController.ByJerarquia7 = hierarchicalSearchControl1.NodeChecked7;
			_uiController.Jerarquias7 = hierarchicalSearchControl1.ItemsJerarquia7;
			_uiController.ByJerarquia8 = hierarchicalSearchControl1.NodeChecked8;
			_uiController.Jerarquias8 = hierarchicalSearchControl1.ItemsJerarquia8;			
		}
	}
}

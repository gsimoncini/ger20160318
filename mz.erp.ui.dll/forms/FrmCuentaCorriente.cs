using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using mz.erp.ui.utility;
using mz.erp.commontypes;
using mz.erp.ui.forms.classes;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using System.Data;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmCuentaCorriente.
	/// </summary>
	public class FrmCuentaCorriente : System.Windows.Forms.Form, ISearchObjectListener
	{
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem Detalles;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbVerCtaCte;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton tbbImprimir;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton tbbImputar;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton tbbVerAsociaciones;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton tbbDesimputar;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		private System.Windows.Forms.ToolBarButton tbbAnular;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.RadioButton rbTodo;
		private System.Windows.Forms.RadioButton rbSoloFacturas;
		private System.Windows.Forms.CheckBox cbSoloPendientes;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udteDesde;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udteHasta;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Infragistics.Win.UltraWinEditors.UltraCurrencyEditor uneSaldoPosterior;
		private Infragistics.Win.UltraWinEditors.UltraCurrencyEditor uneSaldoAnterior;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private HtmlRichText.HtmlRichTextBox richInfoComprobante;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;

		private System.Windows.Forms.Label labelTarea;
		private Janus.Windows.GridEX.GridEX gridResultado;		
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rbSoloNC;		
		private System.Windows.Forms.RadioButton rbOrdenacionFechaEmision;
		private System.Windows.Forms.RadioButton rbOrdenacionFechaVencimiento;
		private System.Windows.Forms.GroupBox gbFechas;
		private System.Windows.Forms.RadioButton rbFiltroFechaEmision;
		private System.Windows.Forms.RadioButton rbFiltroFechaVencimiento;
		private System.Windows.Forms.ToolBarButton tbbRefrescar;
		private System.Windows.Forms.RadioButton rbSoloRecibos;
		private System.Windows.Forms.Label lblEntidad;
		private mz.erp.ui.controls.mzProveedoresControl mzCmb;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
        private mz.erp.ui.controls.mzCuentasControl mzCmbCuenta;
        private Infragistics.Win.UltraWinEditors.UltraCurrencyEditor uneSaldoAcopios;
        private Label labSaldoAcopios;
        private Infragistics.Win.UltraWinEditors.UltraCurrencyEditor uneSaldoRemitosSinFacturar;
        private Label labSaldoRemitos;
        private CheckBox chkAcopios;		
		private System.ComponentModel.IContainer components;


		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.labelTarea = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.mzCmbCuenta = new mz.erp.ui.controls.mzCuentasControl();
            this.gbFechas = new System.Windows.Forms.GroupBox();
            this.rbFiltroFechaEmision = new System.Windows.Forms.RadioButton();
            this.rbFiltroFechaVencimiento = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.udteDesde = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.label2 = new System.Windows.Forms.Label();
            this.udteHasta = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.mzCmb = new mz.erp.ui.controls.mzProveedoresControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSoloRecibos = new System.Windows.Forms.RadioButton();
            this.cbSoloPendientes = new System.Windows.Forms.CheckBox();
            this.rbTodo = new System.Windows.Forms.RadioButton();
            this.rbSoloNC = new System.Windows.Forms.RadioButton();
            this.rbSoloFacturas = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOrdenacionFechaEmision = new System.Windows.Forms.RadioButton();
            this.rbOrdenacionFechaVencimiento = new System.Windows.Forms.RadioButton();
            this.lblEntidad = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.uneSaldoAcopios = new Infragistics.Win.UltraWinEditors.UltraCurrencyEditor();
            this.labSaldoAcopios = new System.Windows.Forms.Label();
            this.uneSaldoRemitosSinFacturar = new Infragistics.Win.UltraWinEditors.UltraCurrencyEditor();
            this.labSaldoRemitos = new System.Windows.Forms.Label();
            this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
            this.uneSaldoPosterior = new Infragistics.Win.UltraWinEditors.UltraCurrencyEditor();
            this.uneSaldoAnterior = new Infragistics.Win.UltraWinEditors.UltraCurrencyEditor();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gridResultado = new Janus.Windows.GridEX.GridEX();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.Detalles = new System.Windows.Forms.MenuItem();
            this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.richInfoComprobante = new HtmlRichText.HtmlRichTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolBarStandar = new System.Windows.Forms.ToolBar();
            this.tbbVerCtaCte = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.tbbRefrescar = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.tbbImprimir = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.tbbImputar = new System.Windows.Forms.ToolBarButton();
            this.tbbVerAsociaciones = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.tbbDesimputar = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
            this.tbbAnular = new System.Windows.Forms.ToolBarButton();
            this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.chkAcopios = new System.Windows.Forms.CheckBox();
            this.ultraExplorerBarContainerControl4.SuspendLayout();
            this.ultraExplorerBarContainerControl1.SuspendLayout();
            this.gbFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udteDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udteHasta)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ultraExplorerBarContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneSaldoAcopios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneSaldoRemitosSinFacturar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneSaldoPosterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneSaldoAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
            this.ultraExplorerBarContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
            this.ultraExplorerBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraExplorerBarContainerControl4
            // 
            this.ultraExplorerBarContainerControl4.Controls.Add(this.labelTarea);
            this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, 24);
            this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
            this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(854, 26);
            this.ultraExplorerBarContainerControl4.TabIndex = 3;
            // 
            // labelTarea
            // 
            this.labelTarea.BackColor = System.Drawing.Color.Transparent;
            this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarea.Location = new System.Drawing.Point(0, 0);
            this.labelTarea.Name = "labelTarea";
            this.labelTarea.Size = new System.Drawing.Size(854, 23);
            this.labelTarea.TabIndex = 1;
            this.labelTarea.Text = "Tarea";
            this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ultraExplorerBarContainerControl1
            // 
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbCuenta);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.gbFechas);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmb);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.groupBox2);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.groupBox1);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.lblEntidad);
            this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 107);
            this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(854, 101);
            this.ultraExplorerBarContainerControl1.TabIndex = 0;
            // 
            // mzCmbCuenta
            // 
            this.mzCmbCuenta.AllowEditClientePaso = false;
            this.mzCmbCuenta.BackColor = System.Drawing.SystemColors.Control;
            this.mzCmbCuenta.DataValue = "";
            this.mzCmbCuenta.EnableCtaCte = false;
            this.mzCmbCuenta.FastSearch = false;
            this.mzCmbCuenta.Location = new System.Drawing.Point(112, 0);
            this.mzCmbCuenta.Name = "mzCmbCuenta";
            this.mzCmbCuenta.ReseteaCodCta = false;
            this.mzCmbCuenta.SearchObjectListener = null;
            this.mzCmbCuenta.Size = new System.Drawing.Size(440, 24);
            this.mzCmbCuenta.TabIndex = 0;
            // 
            // gbFechas
            // 
            this.gbFechas.BackColor = System.Drawing.Color.Transparent;
            this.gbFechas.Controls.Add(this.rbFiltroFechaEmision);
            this.gbFechas.Controls.Add(this.rbFiltroFechaVencimiento);
            this.gbFechas.Controls.Add(this.label1);
            this.gbFechas.Controls.Add(this.udteDesde);
            this.gbFechas.Controls.Add(this.label2);
            this.gbFechas.Controls.Add(this.udteHasta);
            this.gbFechas.Location = new System.Drawing.Point(8, 24);
            this.gbFechas.Name = "gbFechas";
            this.gbFechas.Size = new System.Drawing.Size(344, 72);
            this.gbFechas.TabIndex = 102;
            this.gbFechas.TabStop = false;
            this.gbFechas.Text = "Fechas";
            // 
            // rbFiltroFechaEmision
            // 
            this.rbFiltroFechaEmision.BackColor = System.Drawing.Color.Transparent;
            this.rbFiltroFechaEmision.Checked = true;
            this.rbFiltroFechaEmision.Location = new System.Drawing.Point(8, 16);
            this.rbFiltroFechaEmision.Name = "rbFiltroFechaEmision";
            this.rbFiltroFechaEmision.Size = new System.Drawing.Size(112, 24);
            this.rbFiltroFechaEmision.TabIndex = 1;
            this.rbFiltroFechaEmision.TabStop = true;
            this.rbFiltroFechaEmision.Text = "Fecha de emisión";
            this.rbFiltroFechaEmision.UseVisualStyleBackColor = false;
            // 
            // rbFiltroFechaVencimiento
            // 
            this.rbFiltroFechaVencimiento.BackColor = System.Drawing.Color.Transparent;
            this.rbFiltroFechaVencimiento.Location = new System.Drawing.Point(128, 16);
            this.rbFiltroFechaVencimiento.Name = "rbFiltroFechaVencimiento";
            this.rbFiltroFechaVencimiento.Size = new System.Drawing.Size(136, 24);
            this.rbFiltroFechaVencimiento.TabIndex = 3;
            this.rbFiltroFechaVencimiento.Text = "Fecha de vencimiento";
            this.rbFiltroFechaVencimiento.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 80;
            this.label1.Text = "Desde:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // udteDesde
            // 
            this.udteDesde.Location = new System.Drawing.Point(56, 40);
            this.udteDesde.Name = "udteDesde";
            this.udteDesde.Size = new System.Drawing.Size(104, 21);
            this.udteDesde.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(176, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 81;
            this.label2.Text = "Hasta:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // udteHasta
            // 
            this.udteHasta.Location = new System.Drawing.Point(232, 40);
            this.udteHasta.Name = "udteHasta";
            this.udteHasta.Size = new System.Drawing.Size(104, 21);
            this.udteHasta.TabIndex = 4;
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
            this.mzCmb.Tag = "Proveedor";
            this.mzCmb.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.chkAcopios);
            this.groupBox2.Controls.Add(this.rbSoloRecibos);
            this.groupBox2.Controls.Add(this.cbSoloPendientes);
            this.groupBox2.Controls.Add(this.rbTodo);
            this.groupBox2.Controls.Add(this.rbSoloNC);
            this.groupBox2.Controls.Add(this.rbSoloFacturas);
            this.groupBox2.Location = new System.Drawing.Point(360, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 72);
            this.groupBox2.TabIndex = 100;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visualización";
            // 
            // rbSoloRecibos
            // 
            this.rbSoloRecibos.BackColor = System.Drawing.Color.Transparent;
            this.rbSoloRecibos.Location = new System.Drawing.Point(240, 40);
            this.rbSoloRecibos.Name = "rbSoloRecibos";
            this.rbSoloRecibos.Size = new System.Drawing.Size(68, 24);
            this.rbSoloRecibos.TabIndex = 9;
            this.rbSoloRecibos.Text = "Recibos";
            this.rbSoloRecibos.UseVisualStyleBackColor = false;
            // 
            // cbSoloPendientes
            // 
            this.cbSoloPendientes.BackColor = System.Drawing.Color.Transparent;
            this.cbSoloPendientes.Location = new System.Drawing.Point(16, 20);
            this.cbSoloPendientes.Name = "cbSoloPendientes";
            this.cbSoloPendientes.Size = new System.Drawing.Size(120, 16);
            this.cbSoloPendientes.TabIndex = 5;
            this.cbSoloPendientes.Text = "Solo Pendientes";
            this.cbSoloPendientes.UseVisualStyleBackColor = false;
            // 
            // rbTodo
            // 
            this.rbTodo.BackColor = System.Drawing.Color.Transparent;
            this.rbTodo.Checked = true;
            this.rbTodo.Location = new System.Drawing.Point(16, 40);
            this.rbTodo.Name = "rbTodo";
            this.rbTodo.Size = new System.Drawing.Size(56, 24);
            this.rbTodo.TabIndex = 6;
            this.rbTodo.TabStop = true;
            this.rbTodo.Text = "Todo";
            this.rbTodo.UseVisualStyleBackColor = false;
            // 
            // rbSoloNC
            // 
            this.rbSoloNC.BackColor = System.Drawing.Color.Transparent;
            this.rbSoloNC.Location = new System.Drawing.Point(176, 40);
            this.rbSoloNC.Name = "rbSoloNC";
            this.rbSoloNC.Size = new System.Drawing.Size(40, 24);
            this.rbSoloNC.TabIndex = 8;
            this.rbSoloNC.Text = "NC";
            this.rbSoloNC.UseVisualStyleBackColor = false;
            // 
            // rbSoloFacturas
            // 
            this.rbSoloFacturas.BackColor = System.Drawing.Color.Transparent;
            this.rbSoloFacturas.Location = new System.Drawing.Point(88, 40);
            this.rbSoloFacturas.Name = "rbSoloFacturas";
            this.rbSoloFacturas.Size = new System.Drawing.Size(72, 24);
            this.rbSoloFacturas.TabIndex = 7;
            this.rbSoloFacturas.Text = "Facturas";
            this.rbSoloFacturas.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbOrdenacionFechaEmision);
            this.groupBox1.Controls.Add(this.rbOrdenacionFechaVencimiento);
            this.groupBox1.Location = new System.Drawing.Point(688, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 72);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenación";
            // 
            // rbOrdenacionFechaEmision
            // 
            this.rbOrdenacionFechaEmision.BackColor = System.Drawing.Color.Transparent;
            this.rbOrdenacionFechaEmision.Checked = true;
            this.rbOrdenacionFechaEmision.Location = new System.Drawing.Point(16, 16);
            this.rbOrdenacionFechaEmision.Name = "rbOrdenacionFechaEmision";
            this.rbOrdenacionFechaEmision.Size = new System.Drawing.Size(112, 24);
            this.rbOrdenacionFechaEmision.TabIndex = 10;
            this.rbOrdenacionFechaEmision.TabStop = true;
            this.rbOrdenacionFechaEmision.Text = "Fecha de emisión";
            this.rbOrdenacionFechaEmision.UseVisualStyleBackColor = false;
            // 
            // rbOrdenacionFechaVencimiento
            // 
            this.rbOrdenacionFechaVencimiento.BackColor = System.Drawing.Color.Transparent;
            this.rbOrdenacionFechaVencimiento.Location = new System.Drawing.Point(16, 40);
            this.rbOrdenacionFechaVencimiento.Name = "rbOrdenacionFechaVencimiento";
            this.rbOrdenacionFechaVencimiento.Size = new System.Drawing.Size(136, 24);
            this.rbOrdenacionFechaVencimiento.TabIndex = 11;
            this.rbOrdenacionFechaVencimiento.Text = "Fecha de vencimiento";
            this.rbOrdenacionFechaVencimiento.UseVisualStyleBackColor = false;
            // 
            // lblEntidad
            // 
            this.lblEntidad.BackColor = System.Drawing.Color.Transparent;
            this.lblEntidad.Location = new System.Drawing.Point(8, 2);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(100, 18);
            this.lblEntidad.TabIndex = 82;
            this.lblEntidad.Text = "lblEntidad";
            this.lblEntidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ultraExplorerBarContainerControl2
            // 
            this.ultraExplorerBarContainerControl2.Controls.Add(this.uneSaldoAcopios);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.labSaldoAcopios);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.uneSaldoRemitosSinFacturar);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.labSaldoRemitos);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.gridManagerView1);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.uneSaldoPosterior);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.uneSaldoAnterior);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.label6);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.label4);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.gridResultado);
            this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 265);
            this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
            this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(854, 340);
            this.ultraExplorerBarContainerControl2.TabIndex = 1;
            // 
            // uneSaldoAcopios
            // 
            this.uneSaldoAcopios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uneSaldoAcopios.Location = new System.Drawing.Point(744, 315);
            this.uneSaldoAcopios.MaskInput = "$-nnnnnnnnn.nn";
            this.uneSaldoAcopios.Name = "uneSaldoAcopios";
            this.uneSaldoAcopios.ReadOnly = true;
            this.uneSaldoAcopios.Size = new System.Drawing.Size(104, 21);
            this.uneSaldoAcopios.TabIndex = 82;
            this.uneSaldoAcopios.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // labSaldoAcopios
            // 
            this.labSaldoAcopios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labSaldoAcopios.BackColor = System.Drawing.Color.Transparent;
            this.labSaldoAcopios.Location = new System.Drawing.Point(640, 315);
            this.labSaldoAcopios.Name = "labSaldoAcopios";
            this.labSaldoAcopios.Size = new System.Drawing.Size(100, 21);
            this.labSaldoAcopios.TabIndex = 83;
            this.labSaldoAcopios.Text = "Saldo Acopios";
            this.labSaldoAcopios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uneSaldoRemitosSinFacturar
            // 
            this.uneSaldoRemitosSinFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uneSaldoRemitosSinFacturar.Location = new System.Drawing.Point(744, 291);
            this.uneSaldoRemitosSinFacturar.MaskInput = "$-nnnnnnnnn.nn";
            this.uneSaldoRemitosSinFacturar.Name = "uneSaldoRemitosSinFacturar";
            this.uneSaldoRemitosSinFacturar.ReadOnly = true;
            this.uneSaldoRemitosSinFacturar.Size = new System.Drawing.Size(104, 21);
            this.uneSaldoRemitosSinFacturar.TabIndex = 80;
            this.uneSaldoRemitosSinFacturar.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // labSaldoRemitos
            // 
            this.labSaldoRemitos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labSaldoRemitos.BackColor = System.Drawing.Color.Transparent;
            this.labSaldoRemitos.Location = new System.Drawing.Point(640, 291);
            this.labSaldoRemitos.Name = "labSaldoRemitos";
            this.labSaldoRemitos.Size = new System.Drawing.Size(100, 21);
            this.labSaldoRemitos.TabIndex = 81;
            this.labSaldoRemitos.Text = "Saldo Remitos";
            this.labSaldoRemitos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridManagerView1
            // 
            this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
            this.gridManagerView1.Location = new System.Drawing.Point(0, 0);
            this.gridManagerView1.Name = "gridManagerView1";
            this.gridManagerView1.Size = new System.Drawing.Size(736, 24);
            this.gridManagerView1.TabIndex = 0;
            // 
            // uneSaldoPosterior
            // 
            this.uneSaldoPosterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uneSaldoPosterior.Location = new System.Drawing.Point(744, 264);
            this.uneSaldoPosterior.MaskInput = "$-nnnnnnnnn.nn";
            this.uneSaldoPosterior.Name = "uneSaldoPosterior";
            this.uneSaldoPosterior.ReadOnly = true;
            this.uneSaldoPosterior.Size = new System.Drawing.Size(104, 21);
            this.uneSaldoPosterior.TabIndex = 3;
            this.uneSaldoPosterior.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneSaldoAnterior
            // 
            this.uneSaldoAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uneSaldoAnterior.FormatString = "";
            this.uneSaldoAnterior.Location = new System.Drawing.Point(744, 32);
            this.uneSaldoAnterior.MaskInput = "$-nnnnnnnnn.nn";
            this.uneSaldoAnterior.Name = "uneSaldoAnterior";
            this.uneSaldoAnterior.ReadOnly = true;
            this.uneSaldoAnterior.Size = new System.Drawing.Size(104, 21);
            this.uneSaldoAnterior.TabIndex = 1;
            this.uneSaldoAnterior.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(640, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 79;
            this.label6.Text = "Saldo Actual";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(640, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 77;
            this.label4.Text = "Saldo Anterior";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridResultado
            // 
            this.gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridResultado.AlternatingColors = true;
            this.gridResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridResultado.ContextMenu = this.contextMenu1;
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
            this.gridResultado.Location = new System.Drawing.Point(0, 56);
            this.gridResultado.Name = "gridResultado";
            this.gridResultado.RecordNavigator = true;
            this.gridResultado.RecordNavigatorText = "Registro:|de";
            this.gridResultado.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridResultado.ShowEmptyFields = false;
            this.gridResultado.Size = new System.Drawing.Size(848, 205);
            this.gridResultado.TabIndex = 2;
            this.gridResultado.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
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
            this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 662);
            this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
            this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(854, 216);
            this.ultraExplorerBarContainerControl3.TabIndex = 2;
            // 
            // richInfoComprobante
            // 
            this.richInfoComprobante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richInfoComprobante.Location = new System.Drawing.Point(0, 0);
            this.richInfoComprobante.Name = "richInfoComprobante";
            this.richInfoComprobante.Size = new System.Drawing.Size(848, 208);
            this.richInfoComprobante.TabIndex = 0;
            this.richInfoComprobante.Text = "";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            // 
            // toolBarStandar
            // 
            this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbVerCtaCte,
            this.toolBarButton1,
            this.tbbRefrescar,
            this.toolBarButton2,
            this.tbbImprimir,
            this.toolBarButton3,
            this.tbbImputar,
            this.tbbVerAsociaciones,
            this.toolBarButton5,
            this.tbbDesimputar,
            this.toolBarButton6,
            this.tbbAnular});
            this.toolBarStandar.DropDownArrows = true;
            this.toolBarStandar.ImageList = this.imageList1;
            this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
            this.toolBarStandar.Name = "toolBarStandar";
            this.toolBarStandar.ShowToolTips = true;
            this.toolBarStandar.Size = new System.Drawing.Size(920, 28);
            this.toolBarStandar.TabIndex = 18;
            this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            // 
            // tbbVerCtaCte
            // 
            this.tbbVerCtaCte.ImageIndex = 6;
            this.tbbVerCtaCte.Name = "tbbVerCtaCte";
            this.tbbVerCtaCte.Text = "Detalle &Cta Cte [F5]";
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbRefrescar
            // 
            this.tbbRefrescar.ImageIndex = 5;
            this.tbbRefrescar.Name = "tbbRefrescar";
            this.tbbRefrescar.Text = "Refrescar";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbImprimir
            // 
            this.tbbImprimir.ImageIndex = 9;
            this.tbbImprimir.Name = "tbbImprimir";
            this.tbbImprimir.Text = "&Imprimir";
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.Name = "toolBarButton3";
            this.toolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbImputar
            // 
            this.tbbImputar.Enabled = false;
            this.tbbImputar.Name = "tbbImputar";
            this.tbbImputar.Text = "Impu&tar";
            // 
            // tbbVerAsociaciones
            // 
            this.tbbVerAsociaciones.Enabled = false;
            this.tbbVerAsociaciones.Name = "tbbVerAsociaciones";
            this.tbbVerAsociaciones.Text = "&Ver Imputaciones";
            // 
            // toolBarButton5
            // 
            this.toolBarButton5.Name = "toolBarButton5";
            this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbDesimputar
            // 
            this.tbbDesimputar.Enabled = false;
            this.tbbDesimputar.Name = "tbbDesimputar";
            this.tbbDesimputar.Text = "&Eliminar Imputacion";
            // 
            // toolBarButton6
            // 
            this.toolBarButton6.Name = "toolBarButton6";
            this.toolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbAnular
            // 
            this.tbbAnular.Enabled = false;
            this.tbbAnular.ImageIndex = 7;
            this.tbbAnular.Name = "tbbAnular";
            this.tbbAnular.Text = "&Anular";
            // 
            // ultraExplorerBar1
            // 
            this.ultraExplorerBar1.AnimationEnabled = false;
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
            this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl4;
            ultraExplorerBarGroup1.Settings.ContainerHeight = 26;
            ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup1.Text = "New Group";
            ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
            ultraExplorerBarGroup2.Settings.ContainerHeight = 101;
            ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup2.Text = "Filtros";
            ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl2;
            ultraExplorerBarGroup3.Settings.ContainerHeight = 340;
            ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup3.Text = "Detalle";
            ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl3;
            ultraExplorerBarGroup4.Settings.ContainerHeight = 216;
            ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup4.Text = "Contenido del Comprobante";
            this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2,
            ultraExplorerBarGroup3,
            ultraExplorerBarGroup4});
            this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
            this.ultraExplorerBar1.Name = "ultraExplorerBar1";
            this.ultraExplorerBar1.Size = new System.Drawing.Size(920, 666);
            this.ultraExplorerBar1.TabIndex = 79;
            // 
            // chkAcopios
            // 
            this.chkAcopios.BackColor = System.Drawing.Color.Transparent;
            this.chkAcopios.Location = new System.Drawing.Point(176, 20);
            this.chkAcopios.Name = "chkAcopios";
            this.chkAcopios.Size = new System.Drawing.Size(120, 16);
            this.chkAcopios.TabIndex = 10;
            this.chkAcopios.Text = "Acopios";
            this.chkAcopios.UseVisualStyleBackColor = false;
            // 
            // FrmCuentaCorriente
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(920, 694);
            this.Controls.Add(this.ultraExplorerBar1);
            this.Controls.Add(this.toolBarStandar);
            this.Name = "FrmCuentaCorriente";
            this.Text = "Cuenta corriente";
            this.ultraExplorerBarContainerControl4.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.ResumeLayout(false);
            this.gbFechas.ResumeLayout(false);
            this.gbFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udteDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udteHasta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ultraExplorerBarContainerControl2.ResumeLayout(false);
            this.ultraExplorerBarContainerControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneSaldoAcopios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneSaldoRemitosSinFacturar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneSaldoPosterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneSaldoAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
            this.ultraExplorerBarContainerControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
            this.ultraExplorerBar1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		#region Inicializadores y Carga

		#endregion
		
		#region Variables privadas
		/*private bool _cierreAutomatico = true;
		private bool _isProcess = false;*/
		private CuentaCorrienteController _uiController;
		System.Drawing.Color _colorPositivo;
		System.Drawing.Color _colorNegativo;
		
		#endregion
		#region Propiedades públicas
		#endregion
		
		
		#region Constructores y Destructores
		
		public FrmCuentaCorriente(string Proceso, string Codigo)
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();	
			_uiController = new CuentaCorrienteController();			
			//_uiController.Entidad = Entidad;
			_uiController.ProcessName = Proceso;
			_uiController.Codigo = Codigo;
			_uiController.Init();
			Build_UI();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		#endregion

	

		#region Custom Members		
		
		public virtual void ShowDialog()
		{
			Init();
			base.ShowDialog();			
		}

		#region Miembros de ITaskForm
		/*
		public void ShowForm()
		{
			Init();
			MdiParent = mz.erp.ui.utility.Environment.MainForm;
			Show();			
		}

		public void CloseForm()
		{
			Close();			
		}
		/*public void Execute()
		{			
			if (gridResultado.SelectedItems.Count > 0)
				_uiController.IdCuentaObservacion = Convert.ToString( gridResultado.SelectedItems[0].GetRow().Cells["IdCuentaObservacion"].Value);
			
			this._uiController.Execute();
		}*/

		/*public void Previous()
		{
			this._uiController.Previous();
		}*/

		#endregion

		private void Init()
		{
			Build_UI();
		}

		private void Build_UI()
		{
			ConfigureInterface();	
			InitializeData();
			InitEventHandlers();
			InitDataBindings();
			FillControls();			
		}
		private void ConfigureInterface()
		{
            /* Silvina 20120416 - Tarea 0000277 */
            utility.Util.LoadImagesCuentaCorriente(toolBarStandar, imageList1);
            /* Fin Silvina 20120416 - Tarea 0000277 */

			cbSoloPendientes.Checked = _uiController.SoloPendientes;
			udteDesde.Value = _uiController.FechaDesde; 
			udteHasta.Value = _uiController.FechaHasta;

			if (_uiController.FiltroFechaDefault == "FechaEmision")
				rbFiltroFechaEmision.Checked = true;				
			else if (_uiController.FiltroFechaDefault == "FechaVencimiento")
				rbFiltroFechaVencimiento.Checked = true;

			if (_uiController.FiltroComprobantesDefault == "Todo")
				 rbTodo.Checked = true;
			else if (_uiController.FiltroComprobantesDefault == "FA")
				rbSoloFacturas.Checked = true;
			else if (_uiController.FiltroComprobantesDefault == "NC")
				rbSoloNC.Checked = true;
			else if (_uiController.FiltroComprobantesDefault == "RE")
				rbSoloRecibos.Checked = true;

			if (_uiController.OrdenacionDefault == "FechaEmision")
				rbOrdenacionFechaEmision.Checked = true;				
			else if (_uiController.OrdenacionDefault == "FechaVencimiento")
				rbOrdenacionFechaVencimiento.Checked = true;

			this.Text = _uiController.LeyendaFormulario;
			labelTarea.Text = _uiController.LeyendaFormulario;

			switch(_uiController.ProcessName)
			{
				case "ProcesoCuentaCorrienteCliente":
				{									
					mzCmb.Visible = false;
					mzCmbCuenta.Visible = true;
					lblEntidad.Text = "Cuenta";
					break;
				}
				case "ProcesoCuentaCorrienteClienteDV":
				{									
					mzCmb.Visible = false;
					mzCmbCuenta.Visible = true;
					lblEntidad.Text = "Cuenta";
					break;
				}
				case "ProcesoCuentaCorrienteClienteConsolidada":
				{									
					mzCmb.Visible = false;
					mzCmbCuenta.Visible = true;
					lblEntidad.Text = "Cuenta";
					break;
				}
				case "ProcesoCuentaCorrienteProveedor":
				{
					mzCmb.Visible = true;
					mzCmbCuenta.Visible = false;
					lblEntidad.Text = "Proveedor";
					break;
				}
				case "ProcesoCuentaCorrienteProveedorDV":
				{
					mzCmb.Visible = true;
					mzCmbCuenta.Visible = false;
					lblEntidad.Text = "Proveedor";
					break;
				}
				case "ProcesoCuentaCorrienteProveedoresConsolidada":
				{
					mzCmb.Visible = true;
					mzCmbCuenta.Visible = false;
					lblEntidad.Text = "Proveedor";
					break;
				}
			}	

			_colorPositivo = System.Drawing.Color.FromName(_uiController.ColorPositivo);
			_colorNegativo = System.Drawing.Color.FromName(_uiController.ColorNegativo);
            
			uneSaldoAnterior.FormatString = "$#,##0.00;$#,##0.00;$0.00";	
			uneSaldoPosterior.FormatString = "$#,##0.00;$#,##0.00;$0.00";
            //German 20120223 -  Tarea 0000247
            uneSaldoRemitosSinFacturar.FormatString = "$#,##0.00;$#,##0.00;$0.00";
            uneSaldoAcopios.FormatString = "$#,##0.00;$#,##0.00;$0.00";

            labSaldoAcopios.Visible = false;
            uneSaldoAcopios.Visible = false;
            labSaldoRemitos.Visible = false;
            uneSaldoRemitosSinFacturar.Visible = false;
            chkAcopios.Visible = false;
            if (_uiController.VisualizaSaldoRemitos)
            {
                labSaldoRemitos.Visible = true;
                uneSaldoRemitosSinFacturar.Visible = true;
                if (_uiController.VisualizaSaldoAcopios)
                {
                    labSaldoAcopios.Visible = true;
                    uneSaldoAcopios.Visible = true;
                    chkAcopios.Visible = true;
                }
                else //Hay que achicar el container
                {
                    ultraExplorerBarContainerControl2.Size = new  System.Drawing.Size(  ultraExplorerBarContainerControl2.Size.Width, ultraExplorerBarContainerControl2.Size.Height - uneSaldoAcopios.Size.Height);
                }
            }
            else
            {
                if (_uiController.VisualizaSaldoAcopios) //Hay que achicar el container
                {
                    labSaldoAcopios.Visible = true;
                    uneSaldoAcopios.Visible = true;
                    chkAcopios.Visible = true;
                    labSaldoAcopios.SetBounds(labSaldoRemitos.Location.X, labSaldoRemitos.Location.Y, labSaldoRemitos.Size.Width, labSaldoRemitos.Size.Height);
                    uneSaldoAcopios.SetBounds(uneSaldoRemitosSinFacturar.Location.X, uneSaldoRemitosSinFacturar.Location.Y, uneSaldoRemitosSinFacturar.Size.Width, uneSaldoRemitosSinFacturar.Size.Height);
                    ultraExplorerBarContainerControl2.Size = new  System.Drawing.Size(  ultraExplorerBarContainerControl2.Size.Width, ultraExplorerBarContainerControl2.Size.Height - uneSaldoAcopios.Size.Height);
                }
                else //Hay que achicar el container

                {
                    ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(ultraExplorerBarContainerControl2.Size.Width, ultraExplorerBarContainerControl2.Size.Height - uneSaldoAcopios.Size.Height  - uneSaldoRemitosSinFacturar.Size.Height);
                }
            }



            //Fin German 20120223 -  Tarea 0000247
			
			gridManagerView1.Configure(_uiController.ProcessName, _uiController.TaskName, this.Name, gridResultado, this.Text);			
			this.KeyPreview = true;
		}
		

		private void InitializeData()
		{									
			switch(_uiController.ProcessName)
			{
				case "ProcesoCuentaCorrienteCliente":
				{									
					/*mzCmbCuenta.SearchObject = typeof(  mz.erp.ui.forms.classes.tsa_Cuentas  );
					mzCmbCuenta.EditObject = typeof(mz.erp.ui.forms.FrmAbmCuentas);*/					
					mzCmbCuenta.Init(_uiController.ProcessName, _uiController.TaskName);
					mzCmbCuenta.SearchObjectListener = this;
					mzCmbCuenta.DataValue = _uiController.Codigo;
					/*mzCmbCuenta.AddObjectListener( (IObserver)_uiController );
					mzCmbCuenta.SendObservable((IObservable) _uiController);*/
					/*mzCmb.SearchObject = typeof(  mz.erp.ui.forms.classes.tsa_Cuentas  );
					mzCmb.EditObject = typeof(mz.erp.ui.forms.FrmAbmCuentas);
					mzCmb.DataValue = _uiController.Codigo;*/

					break;
				}
				case "ProcesoCuentaCorrienteClienteDV":
				{									
					mzCmbCuenta.Init(_uiController.ProcessName, _uiController.TaskName);
					mzCmbCuenta.SearchObjectListener = this;
					mzCmbCuenta.DataValue = _uiController.Codigo;
					break;
				}
				case "ProcesoCuentaCorrienteClienteConsolidada":
				{									
					mzCmbCuenta.Init(_uiController.ProcessName, _uiController.TaskName);
					mzCmbCuenta.SearchObjectListener = this;
					mzCmbCuenta.DataValue = _uiController.Codigo;
					break;
				}
				case "ProcesoCuentaCorrienteProveedor":
				{
					mzCmb.Init();
					mzCmb.SearchObjectListener = this;
					mzCmb.DataValue = _uiController.Codigo;
					break;
				}
				case "ProcesoCuentaCorrienteProveedorDV":
				{
					mzCmb.Init();
					mzCmb.SearchObjectListener = this;
					mzCmb.DataValue = _uiController.Codigo;
					break;
				}
				case "ProcesoCuentaCorrienteProveedoresConsolidada":
				{
					mzCmb.Init();
					mzCmb.SearchObjectListener = this;
					mzCmb.DataValue = _uiController.Codigo;
					break;
				}
			}	
		}

		private void InitEventHandlers()
		{
			_uiController.DataSearchChanged+= new System.EventHandler( this.OnGeneralChangesListener );
			_uiController.OnErrors+=new EventHandler(_uiController_OnErrors);			
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			this.KeyDown+=new KeyEventHandler(FrmCuentaCorriente_KeyDown);
			this.Detalles.Click += new System.EventHandler(this.Detalles_Click);
			this.gridResultado.Click+=new EventHandler(this.DetallesResumido_Click);	
			cbSoloPendientes.Click+=new EventHandler(NuevoFiltro_Click);
			rbFiltroFechaEmision.Click+=new EventHandler(NuevoFiltro_Click);
			rbFiltroFechaVencimiento.Click+=new EventHandler(NuevoFiltro_Click);
			rbTodo.Click+=new EventHandler(NuevoFiltro_Click);
			rbSoloFacturas.Click+=new EventHandler(NuevoFiltro_Click);
			rbSoloNC.Click+=new EventHandler(NuevoFiltro_Click);
			rbSoloRecibos.Click+=new EventHandler(NuevoFiltro_Click);
			rbOrdenacionFechaEmision.Click+=new EventHandler(NuevoFiltro_Click);
			rbOrdenacionFechaVencimiento.Click+=new EventHandler(NuevoFiltro_Click);
			//mzCmb.ValueChanged+= new System.EventHandler( this.Componentes_Changes );
			/*this.Closed +=new EventHandler(mzCuentasSearchForm_Closed);*/
			gridResultado.SelectionChanged +=new EventHandler(gridResultado_SelectionChanged);
            //Cristian Tarea 0000050 20110310
            this.udteDesde.ValueChanged += new EventHandler(FechaDesde_ValueChanged);
            //Fin Cristian
            //Cristian Tarea 0000146 20110725
            this.udteHasta.ValueChanged += new EventHandler(udteHasta_ValueChanged);
            //Fin Cristian
            //German 20120531 -  Tarea 0000247
            chkAcopios.Click += new EventHandler(NuevoFiltro_Click);
            //Fin German 20120531 -  Tarea 0000247

            

        }

        void udteHasta_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(udteHasta.Value)),true);
            this.udteDesde.Value = _uiController.FechaDesde;
        }
        //Cristian Tarea 0000050 20110310
        void FechaDesde_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(udteDesde.Value)),false);
            this.udteHasta.Value = _uiController.FechaHasta;
        }
        //Fin Cristian
		private void InitDataBindings()
		{
		}
		private void FillControls()
		{
		}		
		private void OnGeneralChangesListener( object sender, System.EventArgs e)
		{
			this.gridResultado.SetDataBinding( null, null );
			this.gridResultado.SetDataBinding( _uiController.Result, null );
			this.gridResultado.Refetch();
			this.gridResultado.Refresh();
			/*
			if (gridManagerView1.AllowExportExcel)
				gridManagerView1.SetTable(_uiController.Result);
				*/
		}
		#endregion



		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:					
					Refresh();
					break;
				case 2:					
					_uiController.GetDataFromDB = true;
					this.SearchNow();
					break;
				case 4:					
					this.Imprimir();
					break;
				case 6:	//Imputar	
				{
					//this.Imputar();
					this.ImputarNuevo();					
					break;
				}
				case 7:	//Ver Imputaciones				
					this.VerImputaciones();
					break;
				case 9://Desimputar
					if(gridResultado.SelectedItems.Count > 0)
					{
						//if 
						//Desimputar();
						DialogResult result;
						result = MessageBox.Show("¿Está seguro que desea eliminar las imputaciones asociadas?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if(result == DialogResult.Yes)
						{					
							DesimputarNuevo();
							_uiController.GetDataFromDB = true;
							this.SearchNow();
						}
					}
					else
						MessageBox.Show("Debe seleccionar el comprobante a desimputar","Atencion",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Warning);
					break;
				case 11://Anular Recibo
					Anular();
					_uiController.GetDataFromDB = true;
					this.SearchNow();
					break;

			}
		}

		private void Refresh()
		{
			_uiController.GetDataFromDB = false;
			this.SearchNow();
		}
		private void SearchNow()
		{						
			Util.MoveFocus(this.ultraExplorerBarContainerControl1);
			//Matias 20100614 - Tarea 67
			this.richInfoComprobante.Clear();
			//Fin Matias 20100614 - Tarea 67
			this.Cursor = Cursors.WaitCursor;
			this.DumpControls();
			_uiController.BuscarAhora();			
			SetSaldoAnteriorYPosterior();
			gridResultado.Enabled = (gridResultado.RecordCount != 0);
			
			ArrayList aux = new ArrayList();
			
			foreach(ItemCuentaCorriente itcc in _uiController.Result)
			{
				DetalleCuentaCorrienteView item = new DetalleCuentaCorrienteView(itcc);
				aux.Add(item);
			}
			DataTable table = (new mz.erp.commontypes.DataTableConverter()).GetDataTable(aux);
			gridManagerView1.SetTable(table);

			if (gridManagerView1.AllowGroupCollapse)
				this.gridResultado.CollapseGroups();
			else
				if (gridResultado.RootTable.Groups.Count > 0 )
				gridResultado.RootTable.Groups[0].Expand();
			this.Cursor = Cursors.Default;

            //German 20120222 -  Tarea 0000247
            SetSaldoRemitosSinFacturar();
            SetSaldoAcopios();
            
            //Fin German 20120222 -  Tarea 0000247
		}
		private void Imprimir()
		{
			if(_uiController.Result != null && _uiController.Result.Count > 0)
			{				
				ReportsManager.PrintReportCuentaCorriente(_uiController.Result, this.MdiParent, _uiController.ProcessName, cbSoloPendientes.Checked, rbSoloFacturas.Checked, rbSoloNC.Checked, _uiController.SaldoAnterior, _uiController.SaldoPosterior, _uiController.FechaDesde, _uiController.FechaHasta, _uiController.NombreEntidad);
			}
			else
				MessageBox.Show(this,"Debe seleccionar el detalle de la cuenta corriente","Advertencia",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
		}

		private void Desimputar()
		{
			ItemCuentaCorriente icc = (ItemCuentaCorriente)gridResultado.SelectedItems[0].GetRow().DataRow;
			businessrules.comprobantes.DetalleCuentaCorriente dcc = (businessrules.comprobantes.DetalleCuentaCorriente)new businessrules.comprobantes.DetalleCuentaCorriente(icc);
			if (dcc.Desimputar())
				dcc.flushDesimputar();
			
		}
		
		private void DesimputarNuevo()
		{
			ItemCuentaCorriente icc = (ItemCuentaCorriente)gridResultado.SelectedItems[0].GetRow().DataRow;
			businessrules.comprobantes.DetalleCuentaCorriente dcc = (businessrules.comprobantes.DetalleCuentaCorriente)new businessrules.comprobantes.DetalleCuentaCorriente(icc);
			switch(_uiController.ProcessName)
			{
				case "ProcesoCuentaCorrienteCliente":
				{									
					if (_uiController.DesimputarCliente(icc))
						_uiController.FlushDesimputarCliente(icc);
					break;
				}
				case "ProcesoCuentaCorrienteClienteDV":
				{
					if (_uiController.DesimputarCliente(icc))
						_uiController.FlushDesimputarCliente(icc);
					break;
				}
				case "ProcesoCuentaCorrienteClienteConsolidada":
				{
					if (_uiController.DesimputarCliente(icc))
						_uiController.FlushDesimputarCliente(icc);
					break;
				}
				case "ProcesoCuentaCorrienteProveedor":
				{
					if (_uiController.DesimputarProveedor(icc))
						_uiController.FlushDesimputarProveedor(icc);
					break;
				}
				case "ProcesoCuentaCorrienteProveedorDV":
				{
					if (_uiController.DesimputarProveedor(icc))
						_uiController.FlushDesimputarProveedor(icc);
					break;
				}
				case "ProcesoCuentaCorrienteProveedoresConsolidada":
				{
					if (_uiController.DesimputarProveedor(icc))
						_uiController.FlushDesimputarProveedor(icc);
					break;
				}
			}
		}

		private void Imputar()
		{
			FrmImputaciones frmimp;
			if (gridResultado.SelectedItems.Count > 0)
			{
				ItemCuentaCorriente icc = (ItemCuentaCorriente)gridResultado.SelectedItems[0].GetRow().DataRow;
				switch(_uiController.ProcessName)
				{
					case "ProcesoCuentaCorrienteCliente":
					{									
						frmimp = new FrmImputaciones(_uiController.IdCuenta, icc, _uiController.ProcessName, _uiController.CuentaCorriente, "CLIENTES");
						frmimp.OnRowChanged += new FrmImputaciones.RowChanged(UpdateSelection);
						frmimp.MdiParent = this.MdiParent;
						frmimp.Show();
						break;
					}
					case "ProcesoCuentaCorrienteClienteDV":
					{
						frmimp = new FrmImputaciones(_uiController.IdCuenta, icc, _uiController.ProcessName, _uiController.CuentaCorriente, "CLIENTES");
						frmimp.OnRowChanged += new FrmImputaciones.RowChanged(UpdateSelection);
						frmimp.MdiParent = this.MdiParent;
						frmimp.Show();
						break;
					}
					case "ProcesoCuentaCorrienteClienteConsolidada":
					{
						frmimp = new FrmImputaciones(_uiController.IdCuenta, icc, _uiController.ProcessName, _uiController.CuentaCorriente, "CLIENTES");
						frmimp.OnRowChanged += new FrmImputaciones.RowChanged(UpdateSelection);
						frmimp.MdiParent = this.MdiParent;
						frmimp.Show();
						break;
					}
					case "ProcesoCuentaCorrienteProveedor":
					{
						frmimp = new FrmImputaciones(_uiController.IdCuenta, icc, _uiController.ProcessName, _uiController.CuentaCorriente, "PROVEEDORES");
						frmimp.OnRowChanged += new FrmImputaciones.RowChanged(UpdateSelection);
						frmimp.MdiParent = this.MdiParent;
						frmimp.Show();
						break;
					}
					case "ProcesoCuentaCorrienteProveedorDV":
					{
						frmimp = new FrmImputaciones(_uiController.IdCuenta, icc, _uiController.ProcessName, _uiController.CuentaCorriente, "PROVEEDORES");
						frmimp.OnRowChanged += new FrmImputaciones.RowChanged(UpdateSelection);
						frmimp.MdiParent = this.MdiParent;
						frmimp.Show();
						break;
					}
					case "ProcesoCuentaCorrienteProveedoresConsolidada":
					{
						frmimp = new FrmImputaciones(_uiController.IdCuenta, icc, _uiController.ProcessName, _uiController.CuentaCorriente, "PROVEEDORES");
						frmimp.OnRowChanged += new FrmImputaciones.RowChanged(UpdateSelection);
						frmimp.MdiParent = this.MdiParent;
						frmimp.Show();
						break;
					}
				}	
			}
			else 
			{
				frmimp = new FrmImputaciones(_uiController.IdCuenta, null, _uiController.ProcessName, _uiController.CuentaCorriente, "PROVEEDORES");
				frmimp.OnRowChanged += new FrmImputaciones.RowChanged(UpdateSelection);
				frmimp.MdiParent = this.MdiParent;
				frmimp.Show();
			}
		}

		private void ImputarNuevo()
		{
			FrmImputacionesCtaCte frmimpCtaCte;
			if (gridResultado.SelectedItems.Count > 0)
			{
				ItemCuentaCorriente icc = (ItemCuentaCorriente)gridResultado.SelectedItems[0].GetRow().DataRow;
				switch(_uiController.ProcessName)
				{
					case "ProcesoCuentaCorrienteCliente":
					{									
						frmimpCtaCte = new FrmImputacionesCtaCte(_uiController.IdCuenta, icc, _uiController.ProcessName, _uiController.CuentaCorriente, "CLIENTES");
						frmimpCtaCte.OnRowChanged += new FrmImputacionesCtaCte.RowChanged(UpdateSelection);
						frmimpCtaCte.MdiParent = this.MdiParent;
						frmimpCtaCte.Show();		
						break;
					}
					case "ProcesoCuentaCorrienteClienteDV":
					{
						frmimpCtaCte = new FrmImputacionesCtaCte(_uiController.IdCuenta, icc, _uiController.ProcessName, _uiController.CuentaCorriente, "CLIENTES");						
						frmimpCtaCte.OnRowChanged += new FrmImputacionesCtaCte.RowChanged(UpdateSelection);
						frmimpCtaCte.MdiParent = this.MdiParent;
						frmimpCtaCte.Show();		
						break;
					}
					case "ProcesoCuentaCorrienteClienteConsolidada":
					{
						frmimpCtaCte = new FrmImputacionesCtaCte(_uiController.IdCuenta, icc, _uiController.ProcessName, _uiController.CuentaCorriente, "CLIENTES");						
						frmimpCtaCte.OnRowChanged += new FrmImputacionesCtaCte.RowChanged(UpdateSelection);
						frmimpCtaCte.MdiParent = this.MdiParent;
						frmimpCtaCte.Show();		
						break;
					}
					case "ProcesoCuentaCorrienteProveedor":
					{
						frmimpCtaCte = new FrmImputacionesCtaCte(_uiController.IdCuenta, icc, _uiController.ProcessName, _uiController.CuentaCorriente, "PROVEEDORES");						
						frmimpCtaCte.OnRowChanged += new FrmImputacionesCtaCte.RowChanged(UpdateSelection);
						frmimpCtaCte.MdiParent = this.MdiParent;
						frmimpCtaCte.Show();		
						break;
					}
					case "ProcesoCuentaCorrienteProveedorDV":
					{
						frmimpCtaCte = new FrmImputacionesCtaCte(_uiController.IdCuenta, icc, _uiController.ProcessName, _uiController.CuentaCorriente, "PROVEEDORES");
						frmimpCtaCte.OnRowChanged += new FrmImputacionesCtaCte.RowChanged(UpdateSelection);
						frmimpCtaCte.MdiParent = this.MdiParent;
						frmimpCtaCte.Show();		
						break;
					}
					case "ProcesoCuentaCorrienteProveedoresConsolidada":
					{
						frmimpCtaCte = new FrmImputacionesCtaCte(_uiController.IdCuenta, icc, _uiController.ProcessName, _uiController.CuentaCorriente, "PROVEEDORES");
						frmimpCtaCte.OnRowChanged += new FrmImputacionesCtaCte.RowChanged(UpdateSelection);
						frmimpCtaCte.MdiParent = this.MdiParent;
						frmimpCtaCte.Show();		
						break;
					}
				}	
			}
			else 
			{
				frmimpCtaCte = new FrmImputacionesCtaCte(_uiController.IdCuenta, null, _uiController.ProcessName, _uiController.CuentaCorriente, string.Empty);
				frmimpCtaCte.OnRowChanged += new FrmImputacionesCtaCte.RowChanged(UpdateSelection);
				frmimpCtaCte.MdiParent = this.MdiParent;
				frmimpCtaCte.Show();		
			}
		}

		
		private void UpdateSelection(object sender, EventArgs e)
		{
			_uiController.GetDataFromDB = true;
			this.SearchNow();
		}

		private void VerImputaciones()
		{
			ItemCuentaCorriente icc = (ItemCuentaCorriente)gridResultado.SelectedItems[0].GetRow().DataRow;
			FrmVerImputaciones frmVI = new FrmVerImputaciones(_uiController.IdCuenta,icc, _uiController.ProcessName);
			frmVI.MdiParent = this.MdiParent;
			frmVI.Show();
		}

		private void Anular()
		{
			if (tbbDesimputar.Enabled)
				MessageBox.Show("Debe desimputar el comprobante antes de anularlo");
			else
			{
				ItemCuentaCorriente icc = (ItemCuentaCorriente)gridResultado.SelectedItems[0].GetRow().DataRow;
				businessrules.comprobantes.DetalleCuentaCorriente dcc = (businessrules.comprobantes.DetalleCuentaCorriente)new businessrules.comprobantes.DetalleCuentaCorriente(icc);
				CancelacionComprobanteDePago ccp = new CancelacionComprobanteDePago();
				ccp.Anular(dcc.IdComprobante);
				ccp.Commit();
				if(ccp.IsValid())
					ccp.Flush();
			}
		}



		private void DumpControls()
		{

            //German 20120416 - Tarea 0000247
            _uiController.SoloAcopios = chkAcopios.Checked;
            //German 20120416 - Tarea 0000247
            _uiController.SoloPendientes = cbSoloPendientes.Checked;
			if (rbTodo.Checked)
				_uiController.Comprobantes = "Todos";
			else if (rbSoloFacturas.Checked)
				_uiController.Comprobantes = "FA";
			else if (rbSoloNC.Checked)
				_uiController.Comprobantes = "NC";
			else if (rbSoloRecibos.Checked)
				_uiController.Comprobantes = "RE";
			
			if (rbOrdenacionFechaEmision.Checked)
				_uiController.OrderBy = "FechaEmision";
			else if (rbOrdenacionFechaVencimiento.Checked)
				_uiController.OrderBy = "FechaVencimiento";

			if (rbFiltroFechaEmision.Checked)
				_uiController.FilterBy = "FechaEmision";
			else if (rbFiltroFechaVencimiento.Checked)
				_uiController.FilterBy = "FechaVencimiento";

			
			switch(_uiController.ProcessName)
			{
				case "ProcesoCuentaCorrienteCliente":
				{									
					_uiController.Codigo = Convert.ToString( mzCmbCuenta.DataValue );
					break;
				}
				case "ProcesoCuentaCorrienteClienteDV":
				{									
					_uiController.Codigo = Convert.ToString( mzCmbCuenta.DataValue );
					break;
				}
				case "ProcesoCuentaCorrienteClienteConsolidada":
				{									
					_uiController.Codigo = Convert.ToString( mzCmbCuenta.DataValue );
					break;
				}

				case "ProcesoCuentaCorrienteProveedor":
				{
					_uiController.Codigo = Convert.ToString( mzCmb.DataValue );
					break;
				}

				case "ProcesoCuentaCorrienteProveedorDV":
				{
					_uiController.Codigo = Convert.ToString( mzCmb.DataValue );
					break;
				}
				case "ProcesoCuentaCorrienteProveedoresConsolidada":
				{
					_uiController.Codigo = Convert.ToString( mzCmb.DataValue );
					break;
				}

			}

			_uiController.FechaDesde = Convert.ToDateTime(udteDesde.Value);
			_uiController.FechaHasta = Convert.ToDateTime(udteHasta.Value);
		}


        //German 20120222 -  Tarea 0000247
        private void SetSaldoRemitosSinFacturar()
        {
            //modifico el color del saldo anterior			
            if (_uiController.SaldoRemitosSinFacturar >= 0)
                uneSaldoRemitosSinFacturar.Appearance.ForeColor = _colorPositivo;
            else uneSaldoRemitosSinFacturar.Appearance.ForeColor = _colorNegativo;

           
            uneSaldoRemitosSinFacturar.Value = _uiController.SaldoRemitosSinFacturar;
            
        }

        private void SetSaldoAcopios()
        {
            //modifico el color del saldo anterior			
            if (_uiController.SaldoAcopios >= 0)
                uneSaldoAcopios.Appearance.ForeColor = _colorPositivo;
            else uneSaldoAcopios.Appearance.ForeColor = _colorNegativo;


            uneSaldoAcopios.Value = _uiController.SaldoAcopios;

        }


      
        //Fin German 20120222 -  Tarea 0000247


		private void SetSaldoAnteriorYPosterior ()
		{						
			//modifico el color del saldo anterior			
			if(_uiController.SaldoAnterior >= 0)
				uneSaldoAnterior.Appearance.ForeColor = _colorPositivo;
			else uneSaldoAnterior.Appearance.ForeColor = _colorNegativo;	
					
			//modifico el color del saldo posterior						
			if(_uiController.SaldoPosterior >= 0)
				uneSaldoPosterior.Appearance.ForeColor = _colorPositivo;
			else uneSaldoPosterior.Appearance.ForeColor = _colorNegativo;			
		
			uneSaldoAnterior.Value = _uiController.SaldoAnterior;
			uneSaldoPosterior.Value = _uiController.SaldoPosterior;

			Janus.Windows.GridEX.GridEXFormatCondition fc = new Janus.Windows.GridEX.GridEXFormatCondition(this.gridResultado.RootTable.Columns["SaldoAcumulado"],
				Janus.Windows.GridEX.ConditionOperator.LessThan,0);
			fc.FormatStyle.ForeColor= _colorNegativo;
			fc.TargetColumn = this.gridResultado.RootTable.Columns["SaldoAcumulado"];
			this.gridResultado.RootTable.FormatConditions.Add(fc);

			fc = new Janus.Windows.GridEX.GridEXFormatCondition(this.gridResultado.RootTable.Columns["SaldoAcumulado"],
				Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo,0);
			fc.FormatStyle.ForeColor= _colorPositivo; 
			fc.TargetColumn = this.gridResultado.RootTable.Columns["SaldoAcumulado"];
			this.gridResultado.RootTable.FormatConditions.Add(fc);
		}	

		/*
		private void ClearEventHandlers()
		{			
			this.Closed -=new EventHandler(mzCuentasSearchForm_Closed);						
			this.gridResultado.Click+=new EventHandler(gridResultado_Click);
			this.gridResultado.SelectionChanged+=new EventHandler(gridResultado_Click);
			this.toolBarStandar.ButtonClick -= new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			_uiController.DataSearchChanged-= new System.EventHandler( this.OnGeneralChangesListener );			
			_uiController.CodigoCuentaChanged+=new EventHandler(_uiController_CodigoCuentaChanged);			
		}		
		*/
		private void FrmCuentaCorriente_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyData) 
			{
				case System.Windows.Forms.Keys.F5: 
					this.SearchNow();
					break;
			}
		}
		
		private void Detalles_Click(object sender, EventArgs e)
		{
			/*bool visualizaDetalle = Variables.GetValueBool("Momentos." + _processName + ".VisualizaDetalleComprobantes");
			string metodoVisualizacion = Variables.GetValueString("Momentos." + _processName + ".MetodoVisualizacionDetalle");*/
			bool VerHTML = false;
			/*if(visualizaDetalle && metodoVisualizacion.Equals("PORDEMANDA"))
				VerHTML = true;*/
			VerHTML = true;
			if(VerHTML)
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
		}
		private void DetallesResumido_Click(object sender, EventArgs e)
		{
			/*bool visualizaDetalle = Variables.GetValueBool("Momentos." + _processName + ".VisualizaDetalleComprobantes");
			string metodoVisualizacion = Variables.GetValueString("Momentos." + _processName + ".MetodoVisualizacionDetalle");*/
			bool VerHTML = false;
			/*if(visualizaDetalle && metodoVisualizacion.Equals("PORDEMANDA"))
				VerHTML = true;*/
			VerHTML = true;
			if(VerHTML)
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
		/*#region Miembros de ISearchObjectListener

		public void processEventChange(object sender, EventArgs e)
		{
			// TODO: agregar la implementación FrmVisualizacionCuentaCorriente.processEventChange
		}

		#endregion*/

		private void _uiController_OnErrors(object sender, EventArgs e)
		{
			if(_uiController.Errors.Count > 0)
			{
				/*20110328 - Tarea 0000057*/ FrmShowErrors _form = new /*20110328 - Tarea 0000057*/ FrmShowErrors( _uiController.Errors );
				_form.ShowDialog();
			}
		}

		private void Componentes_Changes( object sender, System.EventArgs e )
		{
			/*if (_uiController.CodigoCuenta.CompareTo( Convert.ToString(mzCmbCuenta.DataValue)) != 0)
			{
				_uiController.CodigoCuenta = Convert.ToString(mzCmbCuenta.DataValue);
			}			*/
		}
		public void processEventChange(object sender , EventArgs e)
		{			
		}

		private void NuevoFiltro_Click(object sender, EventArgs e)
		{
			Refresh();
		}

		private void gridResultado_SelectionChanged(object sender, EventArgs e)
		{
			
			if (gridResultado.SelectedItems.Count > 0 )
			{
				ItemCuentaCorriente icc = (ItemCuentaCorriente)gridResultado.SelectedItems[0].GetRow().DataRow;
				string VarCompImputar = Variables.GetValueString(_uiController.ProcessName, "Imputar", "Comprobantes"); //Variables.GetValueString("Momentos.Imputar.Comprobantes");
				string VarCompDesimputar = Variables.GetValueString(_uiController.ProcessName, "Desimputar", "Comprobantes"); //Variables.GetValueString("Momentos.Desimputar.Comprobantes");
				string VarCompImputacionesExcluidas = Variables.GetValueString(_uiController.ProcessName, "Desimputar", "RelacionesComprobantesImputacionesExcluidas"); //Variables.GetValueString("Momentos.Desimputar.Comprobantes");
				string VarCompAnulables = Variables.GetValueString(_uiController.ProcessName, "Anular", "Comprobantes"); 

				
				ArrayList comprobantesImputar = mz.erp.systemframework.Util.Parse(VarCompImputar,",");
				ArrayList comprobantesDesimputar = mz.erp.systemframework.Util.Parse(VarCompDesimputar,",");
				ArrayList comprobantesAnulables = mz.erp.systemframework.Util.Parse(VarCompAnulables,",");
				

				bool permiteDesimputar = true;
				
				string[] arelacionComprobantesPrevios = VarCompImputacionesExcluidas.Split( ';');
				if (arelacionComprobantesPrevios.Length > 0)
				{
					Hashtable hash = new Hashtable();
					for(int i=0;i<arelacionComprobantesPrevios.Length;i++)
					{
						string[] atupla = arelacionComprobantesPrevios[i].Split(':');
						if (atupla.Length == 2)
						{
							if(!hash.ContainsKey(atupla[0]))
								hash.Add( atupla[0], mz.erp.systemframework.Util.Parse(atupla[1]));
						}
					}

					if(hash.ContainsKey(icc.IdTipoDeComprobante))
					{
						ArrayList Imputaciones = new ArrayList(); 
						switch(_uiController.ProcessName)
						{
							case "ProcesoCuentaCorrienteCliente":
							{									
								Imputaciones = icc.GetImputacionesCliente();
								break;
							}
							case "ProcesoCuentaCorrienteClienteDV":
							{									
								Imputaciones = icc.GetImputacionesCliente();
								break;
							}
							case "ProcesoCuentaCorrienteClienteConsolidada":
							{									
								Imputaciones = icc.GetImputacionesCliente();
								break;
							}

							case "ProcesoCuentaCorrienteProveedor":
							{
								Imputaciones = icc.GetImputacionesProveedor();
								break;
							}

							case "ProcesoCuentaCorrienteProveedorDV":
							{
								Imputaciones = icc.GetImputacionesProveedor();
								break;
							}
							case "ProcesoCuentaCorrienteProveedoresConsolidada":
							{
								Imputaciones = icc.GetImputacionesProveedor();
								break;
							}

						}
						ArrayList comprobantesDesimputarExluidas = (ArrayList)hash[icc.IdTipoDeComprobante];
						foreach(ItemCuentaCorriente imputacionItem in Imputaciones)
						{
							if(comprobantesDesimputarExluidas.Contains(imputacionItem.IdTipoDeComprobante))
							{
								permiteDesimputar = false;
							}
						}
					}
					
					
				}
				


				bool anulado = icc.EstaAnulado(_uiController.ProcessName);
				tbbAnular.Enabled = comprobantesAnulables.Contains(icc.IdTipoDeComprobante) && !anulado && icc.Importe.Equals(icc.Saldo);

				//Si el saldo es 0 implica que el comprobante esta saldado
				
				tbbVerAsociaciones.Enabled = true;

				if(icc.Saldo == 0)
				{
					//Habilita o deshabilita sabiendo que el saldo es 0 y depndiendo si el comprobante seleccionado
					//pertence al momento imputar desimputar

					tbbDesimputar.Enabled = permiteDesimputar && (comprobantesDesimputar.Contains(icc.IdTipoDeComprobante)) && !anulado;
					tbbVerAsociaciones.Enabled = !anulado; //(comprobantesDesimputar.Contains(icc.IdTipoDeComprobante)) && !anulado;

					tbbImputar.Enabled = false;
				}
					//El saldo es >0, por ende, puede que el comprobante este con imputaciones parciales
				else 
				{
					//Chequea que haya imputaciones parciales y que el tipo de comprobante puede estar en en 
					// momento inputar o desimputar

					tbbDesimputar.Enabled = permiteDesimputar && (decimal.Round(icc.Saldo,2) < decimal.Round(icc.Importe,2)) && (comprobantesDesimputar.Contains(icc.IdTipoDeComprobante));
					tbbVerAsociaciones.Enabled =(decimal.Round(icc.Saldo,2) < decimal.Round(icc.Importe,2)) ;//&& (comprobantesDesimputar.Contains(icc.IdTipoDeComprobante));

					tbbImputar.Enabled = (comprobantesImputar.Contains(icc.IdTipoDeComprobante)) && !anulado;
				}
			}
		}
	}
}

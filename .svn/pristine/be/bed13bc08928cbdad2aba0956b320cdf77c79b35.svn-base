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
using mz.erp.ui.controllers;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmAutorizarFacturasCompras.
	/// </summary>
	public class FrmAutorizarFacturasCompras : System.Windows.Forms.Form, ITaskForm, ISearchObjectListener
	{
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem Detalles;
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
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ContainerFiltro;
		private System.Windows.Forms.CheckBox chkHabilitaTiposMovimientos;
		private System.Windows.Forms.Label label3;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbResponsableEmision;
		private System.Windows.Forms.ComboBox cboTiposDeComprobantes;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo FechaDesde;
		private System.Windows.Forms.Label label6;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo FechaHasta;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbFechaRecepcionMercaderia;
		private System.Windows.Forms.RadioButton rbFechaVencimiento;
		private System.Windows.Forms.RadioButton rbFechaEmision;
		private System.Windows.Forms.GroupBox groupBoxTiposMovimientos;
		private mz.erp.ui.controls.mzComboEditor mzCmbTipos;
		private mz.erp.ui.controls.mzComboEditor mzCmbSubTipos;
		private mz.erp.ui.controls.mzProveedoresControl mzCmb;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		protected Janus.Windows.GridEX.GridEX gridResultado;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.Label lbTarea;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private HtmlRichText.HtmlRichTextBox richInfoComprobante;
		private System.Windows.Forms.CheckBox chSinAutorizar;
		private System.ComponentModel.IContainer components;


		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton2 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmAutorizarFacturasCompras));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.lbTarea = new System.Windows.Forms.Label();
			this.ContainerFiltro = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.chSinAutorizar = new System.Windows.Forms.CheckBox();
			this.chkHabilitaTiposMovimientos = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.mzCmbResponsableEmision = new mz.erp.ui.controls.mzComboSearchEditor();
			this.cboTiposDeComprobantes = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.FechaDesde = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.label6 = new System.Windows.Forms.Label();
			this.FechaHasta = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbFechaRecepcionMercaderia = new System.Windows.Forms.RadioButton();
			this.rbFechaVencimiento = new System.Windows.Forms.RadioButton();
			this.rbFechaEmision = new System.Windows.Forms.RadioButton();
			this.groupBoxTiposMovimientos = new System.Windows.Forms.GroupBox();
			this.mzCmbTipos = new mz.erp.ui.controls.mzComboEditor();
			this.mzCmbSubTipos = new mz.erp.ui.controls.mzComboEditor();
			this.mzCmb = new mz.erp.ui.controls.mzProveedoresControl();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.gridResultado = new Janus.Windows.GridEX.GridEX();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.Detalles = new System.Windows.Forms.MenuItem();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.richInfoComprobante = new HtmlRichText.HtmlRichTextBox();
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
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.ContainerFiltro.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.FechaDesde)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaHasta)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBoxTiposMovimientos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTipos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbSubTipos)).BeginInit();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.lbTarea);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(870, 16);
			this.ultraExplorerBarContainerControl1.TabIndex = 2;
			// 
			// lbTarea
			// 
			this.lbTarea.BackColor = System.Drawing.Color.Transparent;
			this.lbTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbTarea.Location = new System.Drawing.Point(0, 0);
			this.lbTarea.Name = "lbTarea";
			this.lbTarea.Size = new System.Drawing.Size(870, 16);
			this.lbTarea.TabIndex = 2;
			this.lbTarea.Text = "Tarea";
			this.lbTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ContainerFiltro
			// 
			this.ContainerFiltro.Controls.Add(this.chSinAutorizar);
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
			this.ContainerFiltro.Location = new System.Drawing.Point(28, 99);
			this.ContainerFiltro.Name = "ContainerFiltro";
			this.ContainerFiltro.Size = new System.Drawing.Size(870, 141);
			this.ContainerFiltro.TabIndex = 0;
			// 
			// chSinAutorizar
			// 
			this.chSinAutorizar.BackColor = System.Drawing.Color.Transparent;
			this.chSinAutorizar.Checked = true;
			this.chSinAutorizar.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chSinAutorizar.Location = new System.Drawing.Point(552, 128);
			this.chSinAutorizar.Name = "chSinAutorizar";
			this.chSinAutorizar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chSinAutorizar.Size = new System.Drawing.Size(112, 16);
			this.chSinAutorizar.TabIndex = 130;
			this.chSinAutorizar.Text = "Solo sin autorizar";
			this.chSinAutorizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// chkHabilitaTiposMovimientos
			// 
			this.chkHabilitaTiposMovimientos.BackColor = System.Drawing.Color.Transparent;
			this.chkHabilitaTiposMovimientos.Location = new System.Drawing.Point(140, 62);
			this.chkHabilitaTiposMovimientos.Name = "chkHabilitaTiposMovimientos";
			this.chkHabilitaTiposMovimientos.Size = new System.Drawing.Size(16, 24);
			this.chkHabilitaTiposMovimientos.TabIndex = 7;
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
			// mzCmbResponsableEmision
			// 
			this.mzCmbResponsableEmision.DataValue = "";
			this.mzCmbResponsableEmision.EditObject = null;
			this.mzCmbResponsableEmision.FastSearch = false;
			this.mzCmbResponsableEmision.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbResponsableEmision.HierarchicalSearch = false;
			this.mzCmbResponsableEmision.Location = new System.Drawing.Point(136, 97);
			this.mzCmbResponsableEmision.Name = "mzCmbResponsableEmision";
			this.mzCmbResponsableEmision.ReadOnly = false;
			this.mzCmbResponsableEmision.SearchObject = null;
			this.mzCmbResponsableEmision.SearchObjectListener = null;
			this.mzCmbResponsableEmision.Size = new System.Drawing.Size(496, 22);
			this.mzCmbResponsableEmision.TabIndex = 10;
			this.mzCmbResponsableEmision.Tag = "ResponsableEmision";
			// 
			// cboTiposDeComprobantes
			// 
			this.cboTiposDeComprobantes.Location = new System.Drawing.Point(136, 120);
			this.cboTiposDeComprobantes.Name = "cboTiposDeComprobantes";
			this.cboTiposDeComprobantes.Size = new System.Drawing.Size(336, 21);
			this.cboTiposDeComprobantes.TabIndex = 11;
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
			dateButton1.Caption = "Today";
			this.FechaDesde.DateButtons.Add(dateButton1);
			this.FechaDesde.Location = new System.Drawing.Point(136, 22);
			this.FechaDesde.Name = "FechaDesde";
			this.FechaDesde.NonAutoSizeHeight = 23;
			this.FechaDesde.Size = new System.Drawing.Size(96, 21);
			this.FechaDesde.TabIndex = 2;
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
			dateButton2.Caption = "Today";
			this.FechaHasta.DateButtons.Add(dateButton2);
			this.FechaHasta.Location = new System.Drawing.Point(136, 43);
			this.FechaHasta.Name = "FechaHasta";
			this.FechaHasta.NonAutoSizeHeight = 23;
			this.FechaHasta.Size = new System.Drawing.Size(96, 21);
			this.FechaHasta.TabIndex = 3;
			this.FechaHasta.Tag = "FechaHasta";
			this.FechaHasta.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.rbFechaRecepcionMercaderia);
			this.groupBox1.Controls.Add(this.rbFechaVencimiento);
			this.groupBox1.Controls.Add(this.rbFechaEmision);
			this.groupBox1.Location = new System.Drawing.Point(239, 21);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(587, 40);
			this.groupBox1.TabIndex = 125;
			this.groupBox1.TabStop = false;
			// 
			// rbFechaRecepcionMercaderia
			// 
			this.rbFechaRecepcionMercaderia.Location = new System.Drawing.Point(360, 16);
			this.rbFechaRecepcionMercaderia.Name = "rbFechaRecepcionMercaderia";
			this.rbFechaRecepcionMercaderia.Size = new System.Drawing.Size(208, 24);
			this.rbFechaRecepcionMercaderia.TabIndex = 6;
			this.rbFechaRecepcionMercaderia.Text = "Por Fecha Recepción de Mercadería";
			// 
			// rbFechaVencimiento
			// 
			this.rbFechaVencimiento.Location = new System.Drawing.Point(176, 16);
			this.rbFechaVencimiento.Name = "rbFechaVencimiento";
			this.rbFechaVencimiento.Size = new System.Drawing.Size(160, 24);
			this.rbFechaVencimiento.TabIndex = 5;
			this.rbFechaVencimiento.Text = "Por Fecha Vencimiento";
			// 
			// rbFechaEmision
			// 
			this.rbFechaEmision.Location = new System.Drawing.Point(24, 16);
			this.rbFechaEmision.Name = "rbFechaEmision";
			this.rbFechaEmision.Size = new System.Drawing.Size(128, 24);
			this.rbFechaEmision.TabIndex = 4;
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
			// mzCmbTipos
			// 
			this.mzCmbTipos.AutoComplete = true;
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
			this.mzCmbTipos.TabIndex = 8;
			this.mzCmbTipos.ValueMember = "";
			this.mzCmbTipos.ValueMemberCaption = "";
			// 
			// mzCmbSubTipos
			// 
			this.mzCmbSubTipos.AutoComplete = true;
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
			this.mzCmbSubTipos.TabIndex = 9;
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
			this.mzCmb.TabIndex = 1;
			this.mzCmb.Tag = "ResponsableEmision";
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridManagerView1);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridResultado);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 299);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(870, 205);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
			this.gridManagerView1.Dock = System.Windows.Forms.DockStyle.Top;
			this.gridManagerView1.Location = new System.Drawing.Point(0, 0);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(870, 24);
			this.gridManagerView1.TabIndex = 52;
			// 
			// gridResultado
			// 
			this.gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridResultado.ContextMenu = this.contextMenu1;
			this.gridResultado.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gridResultado.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.gridResultado.GroupByBoxVisible = false;
			this.gridResultado.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridResultado.Location = new System.Drawing.Point(0, 21);
			this.gridResultado.Name = "gridResultado";
			this.gridResultado.Size = new System.Drawing.Size(870, 184);
			this.gridResultado.TabIndex = 0;
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
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 525);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(870, 150);
			this.ultraExplorerBarContainerControl3.TabIndex = 3;
			// 
			// richInfoComprobante
			// 
			this.richInfoComprobante.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richInfoComprobante.Location = new System.Drawing.Point(0, 0);
			this.richInfoComprobante.Name = "richInfoComprobante";
			this.richInfoComprobante.Size = new System.Drawing.Size(870, 150);
			this.richInfoComprobante.TabIndex = 90;
			this.richInfoComprobante.Text = "";
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
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
																							  this.toolBarButton1,
																							  this.tbbCancelar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(936, 28);
			this.toolBarStandar.TabIndex = 21;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// tbbAnterior
			// 
			this.tbbAnterior.ImageIndex = 10;
			this.tbbAnterior.Text = "&Anterior";
			// 
			// tbbSeparator
			// 
			this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbSiguiente
			// 
			this.tbbSiguiente.ImageIndex = 11;
			this.tbbSiguiente.Text = "&Siguiente";
			// 
			// toolBarButton11
			// 
			this.toolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton12
			// 
			this.toolBarButton12.ImageIndex = 2;
			this.toolBarButton12.Text = "Ejecutar Consulta [F5]";
			// 
			// toolBarButton13
			// 
			this.toolBarButton13.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton14
			// 
			this.toolBarButton14.ImageIndex = 5;
			this.toolBarButton14.Text = "Reiniciar Filtros de Busqueda";
			// 
			// toolBarButton16
			// 
			this.toolBarButton16.ImageIndex = 9;
			this.toolBarButton16.Text = "&Selección";
			this.toolBarButton16.Visible = false;
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbCancelar
			// 
			this.tbbCancelar.ImageIndex = 7;
			this.tbbCancelar.Text = "Cancelar";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ContainerFiltro);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Key = "Tarea";
			ultraExplorerBarGroup1.Settings.ContainerHeight = 16;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ContainerFiltro;
			ultraExplorerBarGroup2.Key = "FiltroPrincipal";
			ultraExplorerBarGroup2.Settings.ContainerHeight = 141;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Filtro Inicial";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup3.Key = "Resultado";
			ultraExplorerBarGroup3.Settings.ContainerHeight = 205;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Resultado";
			ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup4.Key = "Detalles";
			ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup4.Text = "Contenido del Comprobante";
			ultraExplorerBarGroup4.Visible = false;
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3,
																														ultraExplorerBarGroup4});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(936, 498);
			this.ultraExplorerBar1.TabIndex = 22;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// FrmAutorizarFacturasCompras
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(936, 526);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmAutorizarFacturasCompras";
			this.Text = "FrmAutorizarFacturasCompras";
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.ContainerFiltro.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.FechaDesde)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaHasta)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBoxTiposMovimientos.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTipos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbSubTipos)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Constructores y Destructores
		public FrmAutorizarFacturasCompras()
		{
			InitializeComponent();			
		}
		public FrmAutorizarFacturasCompras(AutorizarFacturasComprasController controller)
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
		private AutorizarFacturasComprasController _uiController = null;
		private bool _allowShowDetails = false;
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
			mzCmb.Init();
			mzCmb.SearchObjectListener = this;
			mzCmb.EnableCtaCte = _uiController.EnabledButtonCuentaCtaCte;
			mzCmbResponsableEmision.SearchObject = typeof( mz.erp.ui.forms.classes.tsh_Personas );			
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), gridResultado, this.Text);
			gridResultado.Tables[0].AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
			lbTarea.Text = _uiController.LeyendaFormulario;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			this.gridResultado.AutomaticSort = true;
			this.KeyPreview = true;		
			rbFechaEmision.Checked = _uiController.PorFechaEmision;
			rbFechaVencimiento.Checked = _uiController.PorFechaVencimiento;
			rbFechaRecepcionMercaderia.Checked = _uiController.PorFechaRecepcionMercaderia;
			ConfigureTiposComprobantes();		
		
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

			chSinAutorizar.Checked = true;
			chSinAutorizar.Enabled = false;

		}

		private void ConfigureTiposComprobantes()
		{
			object defaultValue = null;
			string _listaFamiliaDeComprobantes = _uiController.ListaFamiliaDeComprobantes;
			string _familiaDefault = _uiController.FamiliaDefault;

			if(_listaFamiliaDeComprobantes == null || _listaFamiliaDeComprobantes.Equals(string.Empty))
				cboTiposDeComprobantes.Items.AddRange(new object [] {"Facturas", "Presupuestos",/*"Notas de Débito",*/"Notas de Crédito","Prefacturas","Remitos","Pedidos","Confirmación de Pedido","Preremitos","Recibos"});
			else
			{
				ArrayList aux = new ArrayList();
				aux.AddRange(mz.erp.systemframework.Util.Parse(_listaFamiliaDeComprobantes,","));
				cboTiposDeComprobantes.Items.AddRange(aux.ToArray());					
			}
			//cboTiposDeComprobantes.SelectedItem = _uiController.TodosLosComprobantes;
			//_uiController.FamiliaComprobantes = _uiController.TodosLosComprobantes;
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
			//gridResultado.CellEdited += new Janus.Windows.GridEX.ColumnActionEventHandler(gridResultado_CellEdited);
			KeyDownManager KeyDown = new KeyDownManager(this);
			
		}	

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
		}
		
		#endregion

		#region Miembros de ITaskForm

		public void Execute()
		{
			gridResultado.UpdateData();
			if(gridResultado.SelectedItems.Count > 0)
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

			rbFechaEmision.Checked=_uiController.PorFechaEmision;		
			rbFechaVencimiento.Checked=_uiController.PorFechaVencimiento;
			rbFechaRecepcionMercaderia.Checked=_uiController.PorFechaRecepcionMercaderia;
			
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
				}
			}
		}


		private void gridResultado_CellEdited(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
		{
			if(gridResultado.SelectedItems.Count > 0)
			{
				DataRowView rowView = (DataRowView)gridResultado.SelectedItems[0].GetRow().DataRow;
				//mz.erp.businessrules.Tarjeta row = (mz.erp.businessrules.Tarjeta) gridTarjetas.SelectedItems[0].GetRow().DataRow;
				DataRow row = rowView.Row;

				gridResultado.Update();
			}
		}
	}
}

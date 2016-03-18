using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using mz.erp.commontypes;
using mz.erp.ui.forms.classes;
using mz.erp.ui.utility;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmConsultaEntregas.
	/// </summary>
	public class FrmConsultaEntregas : System.Windows.Forms.Form, ITaskForm, ISearchObjectListener
	{

		#region Código generado por el Diseñador de Windows Forms

		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbConsultar;
		private System.Windows.Forms.ToolBarButton tbbSeparator3;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton tbbSeparadorImprimir;
		private System.Windows.Forms.ToolBarButton tbbImprimir;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ContainerFiltro;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		protected Janus.Windows.GridEX.GridEX gridResultado;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private System.Windows.Forms.Label lblTarea;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ContainerJerarquias;
		private System.Windows.Forms.Label label9;
		private Infragistics.Win.UltraWinTabControl.UltraTabControl utcFiltros;
		private Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage ultraTabSharedControlsPage2;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl utpFiltroPrincipal;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl utpFiltroSecundario;
		private System.Windows.Forms.Label lblEtiquetaCampoAuxiliar5;
		private System.Windows.Forms.TextBox txtCampoAuxiliar5;
		private System.Windows.Forms.Label lblEtiquetaCampoAuxiliar4;
		private System.Windows.Forms.TextBox txtCampoAuxiliar4;
		private System.Windows.Forms.Label lblEtiquetaCampoAuxiliar2;
		private System.Windows.Forms.TextBox txtCampoAuxiliar2;
		private System.Windows.Forms.Label lblEtiquetaCampoAuxiliar1;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TextBox txtCampoAuxiliar1;
		private System.Windows.Forms.TextBox txtObservaciones;
		private System.Windows.Forms.Label lblEtiquetaCampoAuxiliar3;
		private System.Windows.Forms.TextBox txtCampoAuxiliar3;
		private System.Windows.Forms.ComboBox cboTiposDeComprobantes;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo FechaDesde;
		private System.Windows.Forms.Label label6;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo FechaHasta;
		private System.Windows.Forms.CheckBox chkEntreFechas;
		private System.Windows.Forms.Label label3;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit txtNumeroHasta;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit txtNumeroDesde;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label15;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo FechaConvDesde;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo FechaConvHasta;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo FechaVtoDesde;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo FechaVtoHasta;
		private System.Windows.Forms.CheckBox chkEntreFecha;
		private System.Windows.Forms.CheckBox chkEntreFechaConv;
		private System.Windows.Forms.CheckBox chkEntreFechaVto;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.CheckBox chkPendientes;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private HtmlRichText.HtmlRichTextBox richInfoComprobante;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem Detalles;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbResponsableEmision;
		private mz.erp.ui.controls.mzComboSearchEditor mzCEProductos;
		private mz.erp.ui.controls.HierarchicalSearchControl hierarchicalSearchControl1;
		private mz.erp.ui.controls.mzCuentasControl mzCmbCuenta;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private mz.erp.ui.controls.HierarchicalSearchControl hierarchicalSearchControlClientes;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ContainerJerarquiasClientes;
		private System.Windows.Forms.ToolBarButton tbbReiniciarFiltros;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.ComponentModel.IContainer components;

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton2 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton3 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton4 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton5 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton6 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			Infragistics.Win.UltraWinTabControl.UltraTab ultraTab1 = new Infragistics.Win.UltraWinTabControl.UltraTab();
			Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
			Infragistics.Win.UltraWinTabControl.UltraTab ultraTab2 = new Infragistics.Win.UltraWinTabControl.UltraTab();
			Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmConsultaEntregas));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup6 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.utpFiltroPrincipal = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
			this.mzCmbCuenta = new mz.erp.ui.controls.mzCuentasControl();
			this.mzCmbResponsableEmision = new mz.erp.ui.controls.mzComboSearchEditor();
			this.chkPendientes = new System.Windows.Forms.CheckBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.chkEntreFechaVto = new System.Windows.Forms.CheckBox();
			this.label10 = new System.Windows.Forms.Label();
			this.FechaVtoDesde = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.label11 = new System.Windows.Forms.Label();
			this.FechaVtoHasta = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.chkEntreFechaConv = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.FechaConvDesde = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.label8 = new System.Windows.Forms.Label();
			this.FechaConvHasta = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.chkEntreFecha = new System.Windows.Forms.CheckBox();
			this.chkEntreFechas = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNumeroHasta = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
			this.txtNumeroDesde = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
			this.cboTiposDeComprobantes = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.FechaDesde = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.label6 = new System.Windows.Forms.Label();
			this.FechaHasta = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.utpFiltroSecundario = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
			this.lblEtiquetaCampoAuxiliar5 = new System.Windows.Forms.Label();
			this.txtCampoAuxiliar5 = new System.Windows.Forms.TextBox();
			this.lblEtiquetaCampoAuxiliar4 = new System.Windows.Forms.Label();
			this.txtCampoAuxiliar4 = new System.Windows.Forms.TextBox();
			this.lblEtiquetaCampoAuxiliar2 = new System.Windows.Forms.Label();
			this.txtCampoAuxiliar2 = new System.Windows.Forms.TextBox();
			this.lblEtiquetaCampoAuxiliar1 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.txtCampoAuxiliar1 = new System.Windows.Forms.TextBox();
			this.txtObservaciones = new System.Windows.Forms.TextBox();
			this.lblEtiquetaCampoAuxiliar3 = new System.Windows.Forms.Label();
			this.txtCampoAuxiliar3 = new System.Windows.Forms.TextBox();
			this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.lblTarea = new System.Windows.Forms.Label();
			this.ContainerFiltro = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.utcFiltros = new Infragistics.Win.UltraWinTabControl.UltraTabControl();
			this.ultraTabSharedControlsPage2 = new Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage();
			this.ContainerJerarquias = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.hierarchicalSearchControl1 = new mz.erp.ui.controls.HierarchicalSearchControl();
			this.mzCEProductos = new mz.erp.ui.controls.mzComboSearchEditor();
			this.label9 = new System.Windows.Forms.Label();
			this.ContainerJerarquiasClientes = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.hierarchicalSearchControlClientes = new mz.erp.ui.controls.HierarchicalSearchControl();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.gridResultado = new Janus.Windows.GridEX.GridEX();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.Detalles = new System.Windows.Forms.MenuItem();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.richInfoComprobante = new HtmlRichText.HtmlRichTextBox();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbConsultar = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator3 = new System.Windows.Forms.ToolBarButton();
			this.tbbReiniciarFiltros = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.tbbImprimir = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparadorImprimir = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.utpFiltroPrincipal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.FechaVtoDesde)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaVtoHasta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaConvDesde)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaConvHasta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaDesde)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaHasta)).BeginInit();
			this.utpFiltroSecundario.SuspendLayout();
			this.ultraExplorerBarContainerControl4.SuspendLayout();
			this.ContainerFiltro.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.utcFiltros)).BeginInit();
			this.utcFiltros.SuspendLayout();
			this.ContainerJerarquias.SuspendLayout();
			this.ContainerJerarquiasClientes.SuspendLayout();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar2)).BeginInit();
			this.ultraExplorerBar2.SuspendLayout();
			this.SuspendLayout();
			// 
			// utpFiltroPrincipal
			// 
			this.utpFiltroPrincipal.AutoScroll = true;
			this.utpFiltroPrincipal.Controls.Add(this.mzCmbCuenta);
			this.utpFiltroPrincipal.Controls.Add(this.mzCmbResponsableEmision);
			this.utpFiltroPrincipal.Controls.Add(this.chkPendientes);
			this.utpFiltroPrincipal.Controls.Add(this.label14);
			this.utpFiltroPrincipal.Controls.Add(this.label15);
			this.utpFiltroPrincipal.Controls.Add(this.label13);
			this.utpFiltroPrincipal.Controls.Add(this.label12);
			this.utpFiltroPrincipal.Controls.Add(this.chkEntreFechaVto);
			this.utpFiltroPrincipal.Controls.Add(this.label10);
			this.utpFiltroPrincipal.Controls.Add(this.FechaVtoDesde);
			this.utpFiltroPrincipal.Controls.Add(this.label11);
			this.utpFiltroPrincipal.Controls.Add(this.FechaVtoHasta);
			this.utpFiltroPrincipal.Controls.Add(this.chkEntreFechaConv);
			this.utpFiltroPrincipal.Controls.Add(this.label4);
			this.utpFiltroPrincipal.Controls.Add(this.FechaConvDesde);
			this.utpFiltroPrincipal.Controls.Add(this.label8);
			this.utpFiltroPrincipal.Controls.Add(this.FechaConvHasta);
			this.utpFiltroPrincipal.Controls.Add(this.chkEntreFecha);
			this.utpFiltroPrincipal.Controls.Add(this.chkEntreFechas);
			this.utpFiltroPrincipal.Controls.Add(this.label3);
			this.utpFiltroPrincipal.Controls.Add(this.txtNumeroHasta);
			this.utpFiltroPrincipal.Controls.Add(this.txtNumeroDesde);
			this.utpFiltroPrincipal.Controls.Add(this.cboTiposDeComprobantes);
			this.utpFiltroPrincipal.Controls.Add(this.label7);
			this.utpFiltroPrincipal.Controls.Add(this.label2);
			this.utpFiltroPrincipal.Controls.Add(this.label5);
			this.utpFiltroPrincipal.Controls.Add(this.label1);
			this.utpFiltroPrincipal.Controls.Add(this.FechaDesde);
			this.utpFiltroPrincipal.Controls.Add(this.label6);
			this.utpFiltroPrincipal.Controls.Add(this.FechaHasta);
			this.utpFiltroPrincipal.Location = new System.Drawing.Point(1, 23);
			this.utpFiltroPrincipal.Name = "utpFiltroPrincipal";
			this.utpFiltroPrincipal.Size = new System.Drawing.Size(827, 220);
			// 
			// mzCmbCuenta
			// 
			this.mzCmbCuenta.AllowEditClientePaso = false;
			this.mzCmbCuenta.BackColor = System.Drawing.SystemColors.Control;
			this.mzCmbCuenta.DataValue = "";
			this.mzCmbCuenta.EnableCtaCte = false;
			this.mzCmbCuenta.FastSearch = false;
			this.mzCmbCuenta.Location = new System.Drawing.Point(136, 8);
			this.mzCmbCuenta.Name = "mzCmbCuenta";
			this.mzCmbCuenta.SearchObjectListener = null;
			this.mzCmbCuenta.Size = new System.Drawing.Size(512, 22);
			this.mzCmbCuenta.TabIndex = 0;
			this.mzCmbCuenta.Tag = "Cuenta";
			// 
			// mzCmbResponsableEmision
			// 
			this.mzCmbResponsableEmision.DataValue = "";
			this.mzCmbResponsableEmision.EditObject = null;
			this.mzCmbResponsableEmision.FastSearch = false;
			this.mzCmbResponsableEmision.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbResponsableEmision.HierarchicalSearch = false;
			this.mzCmbResponsableEmision.Location = new System.Drawing.Point(136, 104);
			this.mzCmbResponsableEmision.Name = "mzCmbResponsableEmision";
			this.mzCmbResponsableEmision.ReadOnly = false;
			this.mzCmbResponsableEmision.SearchObject = null;
			this.mzCmbResponsableEmision.SearchObjectListener = null;
			this.mzCmbResponsableEmision.Size = new System.Drawing.Size(480, 22);
			this.mzCmbResponsableEmision.TabIndex = 10;
			this.mzCmbResponsableEmision.Tag = "ResponsableEmision";
			// 
			// chkPendientes
			// 
			this.chkPendientes.BackColor = System.Drawing.Color.Transparent;
			this.chkPendientes.Location = new System.Drawing.Point(136, 176);
			this.chkPendientes.Name = "chkPendientes";
			this.chkPendientes.Size = new System.Drawing.Size(16, 20);
			this.chkPendientes.TabIndex = 15;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Location = new System.Drawing.Point(8, 178);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(104, 16);
			this.label14.TabIndex = 144;
			this.label14.Tag = "Pendientes";
			this.label14.Text = "Pendientes";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Location = new System.Drawing.Point(136, 83);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(72, 21);
			this.label15.TabIndex = 142;
			this.label15.Tag = "FechaVencimiento";
			this.label15.Text = "Fecha Inicio";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Location = new System.Drawing.Point(136, 59);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(72, 21);
			this.label13.TabIndex = 141;
			this.label13.Tag = "FechaConvenida";
			this.label13.Text = "Fecha Inicio";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Location = new System.Drawing.Point(136, 35);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(72, 21);
			this.label12.TabIndex = 140;
			this.label12.Tag = "Fecha";
			this.label12.Text = "Fecha Inicio";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chkEntreFechaVto
			// 
			this.chkEntreFechaVto.BackColor = System.Drawing.Color.Transparent;
			this.chkEntreFechaVto.Location = new System.Drawing.Point(496, 82);
			this.chkEntreFechaVto.Name = "chkEntreFechaVto";
			this.chkEntreFechaVto.Size = new System.Drawing.Size(16, 20);
			this.chkEntreFechaVto.TabIndex = 9;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(8, 83);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(104, 21);
			this.label10.TabIndex = 138;
			this.label10.Tag = "FechaVencimiento";
			this.label10.Text = "Fecha Vencimiento";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FechaVtoDesde
			// 
			dateButton1.Caption = "Today";
			this.FechaVtoDesde.DateButtons.Add(dateButton1);
			this.FechaVtoDesde.Location = new System.Drawing.Point(208, 80);
			this.FechaVtoDesde.Name = "FechaVtoDesde";
			this.FechaVtoDesde.NonAutoSizeHeight = 23;
			this.FechaVtoDesde.Size = new System.Drawing.Size(96, 21);
			this.FechaVtoDesde.TabIndex = 7;
			this.FechaVtoDesde.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Location = new System.Drawing.Point(320, 83);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(56, 21);
			this.label11.TabIndex = 137;
			this.label11.Tag = "FechaVencimiento";
			this.label11.Text = "Fecha Fin";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FechaVtoHasta
			// 
			dateButton2.Caption = "Today";
			this.FechaVtoHasta.DateButtons.Add(dateButton2);
			this.FechaVtoHasta.Location = new System.Drawing.Point(392, 80);
			this.FechaVtoHasta.Name = "FechaVtoHasta";
			this.FechaVtoHasta.NonAutoSizeHeight = 23;
			this.FechaVtoHasta.Size = new System.Drawing.Size(96, 21);
			this.FechaVtoHasta.TabIndex = 8;
			this.FechaVtoHasta.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
			// 
			// chkEntreFechaConv
			// 
			this.chkEntreFechaConv.BackColor = System.Drawing.Color.Transparent;
			this.chkEntreFechaConv.Location = new System.Drawing.Point(496, 57);
			this.chkEntreFechaConv.Name = "chkEntreFechaConv";
			this.chkEntreFechaConv.Size = new System.Drawing.Size(16, 20);
			this.chkEntreFechaConv.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(8, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 21);
			this.label4.TabIndex = 133;
			this.label4.Tag = "FechaConvenida";
			this.label4.Text = "Fecha Convenida";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FechaConvDesde
			// 
			dateButton3.Caption = "Today";
			this.FechaConvDesde.DateButtons.Add(dateButton3);
			this.FechaConvDesde.Location = new System.Drawing.Point(208, 56);
			this.FechaConvDesde.Name = "FechaConvDesde";
			this.FechaConvDesde.NonAutoSizeHeight = 23;
			this.FechaConvDesde.Size = new System.Drawing.Size(96, 21);
			this.FechaConvDesde.TabIndex = 4;
			this.FechaConvDesde.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(320, 60);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 21);
			this.label8.TabIndex = 132;
			this.label8.Tag = "FechaConvenida";
			this.label8.Text = "Fecha Fin";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FechaConvHasta
			// 
			dateButton4.Caption = "Today";
			this.FechaConvHasta.DateButtons.Add(dateButton4);
			this.FechaConvHasta.Location = new System.Drawing.Point(392, 56);
			this.FechaConvHasta.Name = "FechaConvHasta";
			this.FechaConvHasta.NonAutoSizeHeight = 23;
			this.FechaConvHasta.Size = new System.Drawing.Size(96, 21);
			this.FechaConvHasta.TabIndex = 5;
			this.FechaConvHasta.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
			// 
			// chkEntreFecha
			// 
			this.chkEntreFecha.BackColor = System.Drawing.Color.Transparent;
			this.chkEntreFecha.Location = new System.Drawing.Point(496, 34);
			this.chkEntreFecha.Name = "chkEntreFecha";
			this.chkEntreFecha.Size = new System.Drawing.Size(16, 20);
			this.chkEntreFecha.TabIndex = 3;
			// 
			// chkEntreFechas
			// 
			this.chkEntreFechas.BackColor = System.Drawing.Color.Transparent;
			this.chkEntreFechas.Location = new System.Drawing.Point(344, 152);
			this.chkEntreFechas.Name = "chkEntreFechas";
			this.chkEntreFechas.Size = new System.Drawing.Size(16, 20);
			this.chkEntreFechas.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(8, 152);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 20);
			this.label3.TabIndex = 127;
			this.label3.Tag = "Numero";
			this.label3.Text = "Número";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtNumeroHasta
			// 
			this.txtNumeroHasta.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
			this.txtNumeroHasta.Location = new System.Drawing.Point(240, 152);
			this.txtNumeroHasta.Name = "txtNumeroHasta";
			this.txtNumeroHasta.TabIndex = 13;
			this.txtNumeroHasta.Tag = "Numero";
			this.txtNumeroHasta.Text = "--";
			// 
			// txtNumeroDesde
			// 
			this.txtNumeroDesde.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
			this.txtNumeroDesde.Location = new System.Drawing.Point(136, 152);
			this.txtNumeroDesde.Name = "txtNumeroDesde";
			this.txtNumeroDesde.TabIndex = 12;
			this.txtNumeroDesde.Tag = "Numero";
			this.txtNumeroDesde.Text = "--";
			// 
			// cboTiposDeComprobantes
			// 
			this.cboTiposDeComprobantes.Location = new System.Drawing.Point(136, 128);
			this.cboTiposDeComprobantes.Name = "cboTiposDeComprobantes";
			this.cboTiposDeComprobantes.Size = new System.Drawing.Size(336, 21);
			this.cboTiposDeComprobantes.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(10, 35);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 21);
			this.label7.TabIndex = 124;
			this.label7.Tag = "Fecha";
			this.label7.Text = "Fecha Emisión";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(8, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 22);
			this.label2.TabIndex = 123;
			this.label2.Tag = "ResponsableEmision";
			this.label2.Text = "Responsable de emisión";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(8, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(128, 21);
			this.label5.TabIndex = 122;
			this.label5.Tag = "TiposDeComprobantes";
			this.label5.Text = "Tipos de comprobantes";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(10, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 24);
			this.label1.TabIndex = 121;
			this.label1.Tag = "Cuenta";
			this.label1.Text = "Cuenta";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FechaDesde
			// 
			dateButton5.Caption = "Today";
			this.FechaDesde.DateButtons.Add(dateButton5);
			this.FechaDesde.Location = new System.Drawing.Point(208, 32);
			this.FechaDesde.Name = "FechaDesde";
			this.FechaDesde.NonAutoSizeHeight = 23;
			this.FechaDesde.Size = new System.Drawing.Size(96, 21);
			this.FechaDesde.TabIndex = 1;
			this.FechaDesde.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(320, 36);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 21);
			this.label6.TabIndex = 120;
			this.label6.Tag = "Fecha";
			this.label6.Text = "Fecha Fin";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FechaHasta
			// 
			dateButton6.Caption = "Today";
			this.FechaHasta.DateButtons.Add(dateButton6);
			this.FechaHasta.Location = new System.Drawing.Point(392, 32);
			this.FechaHasta.Name = "FechaHasta";
			this.FechaHasta.NonAutoSizeHeight = 23;
			this.FechaHasta.Size = new System.Drawing.Size(96, 21);
			this.FechaHasta.TabIndex = 2;
			this.FechaHasta.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
			// 
			// utpFiltroSecundario
			// 
			this.utpFiltroSecundario.AutoScroll = true;
			this.utpFiltroSecundario.Controls.Add(this.lblEtiquetaCampoAuxiliar5);
			this.utpFiltroSecundario.Controls.Add(this.txtCampoAuxiliar5);
			this.utpFiltroSecundario.Controls.Add(this.lblEtiquetaCampoAuxiliar4);
			this.utpFiltroSecundario.Controls.Add(this.txtCampoAuxiliar4);
			this.utpFiltroSecundario.Controls.Add(this.lblEtiquetaCampoAuxiliar2);
			this.utpFiltroSecundario.Controls.Add(this.txtCampoAuxiliar2);
			this.utpFiltroSecundario.Controls.Add(this.lblEtiquetaCampoAuxiliar1);
			this.utpFiltroSecundario.Controls.Add(this.label24);
			this.utpFiltroSecundario.Controls.Add(this.txtCampoAuxiliar1);
			this.utpFiltroSecundario.Controls.Add(this.txtObservaciones);
			this.utpFiltroSecundario.Controls.Add(this.lblEtiquetaCampoAuxiliar3);
			this.utpFiltroSecundario.Controls.Add(this.txtCampoAuxiliar3);
			this.utpFiltroSecundario.Location = new System.Drawing.Point(-10000, -10000);
			this.utpFiltroSecundario.Name = "utpFiltroSecundario";
			this.utpFiltroSecundario.Size = new System.Drawing.Size(827, 220);
			// 
			// lblEtiquetaCampoAuxiliar5
			// 
			this.lblEtiquetaCampoAuxiliar5.BackColor = System.Drawing.Color.Transparent;
			this.lblEtiquetaCampoAuxiliar5.Location = new System.Drawing.Point(8, 107);
			this.lblEtiquetaCampoAuxiliar5.Name = "lblEtiquetaCampoAuxiliar5";
			this.lblEtiquetaCampoAuxiliar5.Size = new System.Drawing.Size(96, 18);
			this.lblEtiquetaCampoAuxiliar5.TabIndex = 61;
			this.lblEtiquetaCampoAuxiliar5.Tag = "CampoAuxiliar5";
			this.lblEtiquetaCampoAuxiliar5.Text = "Campo Auxiliar5";
			// 
			// txtCampoAuxiliar5
			// 
			this.txtCampoAuxiliar5.Location = new System.Drawing.Point(104, 104);
			this.txtCampoAuxiliar5.MaxLength = 256;
			this.txtCampoAuxiliar5.Name = "txtCampoAuxiliar5";
			this.txtCampoAuxiliar5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtCampoAuxiliar5.Size = new System.Drawing.Size(296, 20);
			this.txtCampoAuxiliar5.TabIndex = 60;
			this.txtCampoAuxiliar5.Text = "";
			this.txtCampoAuxiliar5.WordWrap = false;
			// 
			// lblEtiquetaCampoAuxiliar4
			// 
			this.lblEtiquetaCampoAuxiliar4.BackColor = System.Drawing.Color.Transparent;
			this.lblEtiquetaCampoAuxiliar4.Location = new System.Drawing.Point(8, 88);
			this.lblEtiquetaCampoAuxiliar4.Name = "lblEtiquetaCampoAuxiliar4";
			this.lblEtiquetaCampoAuxiliar4.Size = new System.Drawing.Size(96, 18);
			this.lblEtiquetaCampoAuxiliar4.TabIndex = 59;
			this.lblEtiquetaCampoAuxiliar4.Tag = "CampoAuxiliar4";
			this.lblEtiquetaCampoAuxiliar4.Text = "Campo Auxiliar4";
			// 
			// txtCampoAuxiliar4
			// 
			this.txtCampoAuxiliar4.Location = new System.Drawing.Point(104, 84);
			this.txtCampoAuxiliar4.MaxLength = 256;
			this.txtCampoAuxiliar4.Name = "txtCampoAuxiliar4";
			this.txtCampoAuxiliar4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtCampoAuxiliar4.Size = new System.Drawing.Size(296, 20);
			this.txtCampoAuxiliar4.TabIndex = 58;
			this.txtCampoAuxiliar4.Text = "";
			this.txtCampoAuxiliar4.WordWrap = false;
			// 
			// lblEtiquetaCampoAuxiliar2
			// 
			this.lblEtiquetaCampoAuxiliar2.BackColor = System.Drawing.Color.Transparent;
			this.lblEtiquetaCampoAuxiliar2.Location = new System.Drawing.Point(8, 47);
			this.lblEtiquetaCampoAuxiliar2.Name = "lblEtiquetaCampoAuxiliar2";
			this.lblEtiquetaCampoAuxiliar2.Size = new System.Drawing.Size(96, 18);
			this.lblEtiquetaCampoAuxiliar2.TabIndex = 57;
			this.lblEtiquetaCampoAuxiliar2.Tag = "CampoAuxiliar2";
			this.lblEtiquetaCampoAuxiliar2.Text = "Campo Auxiliar2";
			// 
			// txtCampoAuxiliar2
			// 
			this.txtCampoAuxiliar2.Location = new System.Drawing.Point(104, 44);
			this.txtCampoAuxiliar2.MaxLength = 256;
			this.txtCampoAuxiliar2.Name = "txtCampoAuxiliar2";
			this.txtCampoAuxiliar2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtCampoAuxiliar2.Size = new System.Drawing.Size(296, 20);
			this.txtCampoAuxiliar2.TabIndex = 56;
			this.txtCampoAuxiliar2.Text = "";
			this.txtCampoAuxiliar2.WordWrap = false;
			// 
			// lblEtiquetaCampoAuxiliar1
			// 
			this.lblEtiquetaCampoAuxiliar1.BackColor = System.Drawing.Color.Transparent;
			this.lblEtiquetaCampoAuxiliar1.Location = new System.Drawing.Point(8, 26);
			this.lblEtiquetaCampoAuxiliar1.Name = "lblEtiquetaCampoAuxiliar1";
			this.lblEtiquetaCampoAuxiliar1.Size = new System.Drawing.Size(96, 18);
			this.lblEtiquetaCampoAuxiliar1.TabIndex = 55;
			this.lblEtiquetaCampoAuxiliar1.Tag = "CampoAuxiliar1";
			this.lblEtiquetaCampoAuxiliar1.Text = "Campo Auxiliar1";
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.Transparent;
			this.label24.Location = new System.Drawing.Point(8, 7);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(80, 20);
			this.label24.TabIndex = 53;
			this.label24.Tag = "Observaciones";
			this.label24.Text = "Observaciones";
			// 
			// txtCampoAuxiliar1
			// 
			this.txtCampoAuxiliar1.Location = new System.Drawing.Point(104, 24);
			this.txtCampoAuxiliar1.MaxLength = 256;
			this.txtCampoAuxiliar1.Name = "txtCampoAuxiliar1";
			this.txtCampoAuxiliar1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtCampoAuxiliar1.Size = new System.Drawing.Size(296, 20);
			this.txtCampoAuxiliar1.TabIndex = 51;
			this.txtCampoAuxiliar1.Text = "";
			this.txtCampoAuxiliar1.WordWrap = false;
			// 
			// txtObservaciones
			// 
			this.txtObservaciones.Location = new System.Drawing.Point(104, 4);
			this.txtObservaciones.MaxLength = 255;
			this.txtObservaciones.Multiline = true;
			this.txtObservaciones.Name = "txtObservaciones";
			this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtObservaciones.Size = new System.Drawing.Size(576, 20);
			this.txtObservaciones.TabIndex = 50;
			this.txtObservaciones.Text = "";
			// 
			// lblEtiquetaCampoAuxiliar3
			// 
			this.lblEtiquetaCampoAuxiliar3.BackColor = System.Drawing.Color.Transparent;
			this.lblEtiquetaCampoAuxiliar3.Location = new System.Drawing.Point(8, 66);
			this.lblEtiquetaCampoAuxiliar3.Name = "lblEtiquetaCampoAuxiliar3";
			this.lblEtiquetaCampoAuxiliar3.Size = new System.Drawing.Size(96, 18);
			this.lblEtiquetaCampoAuxiliar3.TabIndex = 59;
			this.lblEtiquetaCampoAuxiliar3.Tag = "CampoAuxiliar3";
			this.lblEtiquetaCampoAuxiliar3.Text = "Campo Auxiliar3";
			// 
			// txtCampoAuxiliar3
			// 
			this.txtCampoAuxiliar3.Location = new System.Drawing.Point(104, 64);
			this.txtCampoAuxiliar3.MaxLength = 256;
			this.txtCampoAuxiliar3.Name = "txtCampoAuxiliar3";
			this.txtCampoAuxiliar3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtCampoAuxiliar3.Size = new System.Drawing.Size(296, 20);
			this.txtCampoAuxiliar3.TabIndex = 58;
			this.txtCampoAuxiliar3.Text = "";
			this.txtCampoAuxiliar3.WordWrap = false;
			// 
			// ultraExplorerBarContainerControl4
			// 
			this.ultraExplorerBarContainerControl4.Controls.Add(this.lblTarea);
			this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
			this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(831, 31);
			this.ultraExplorerBarContainerControl4.TabIndex = 2;
			// 
			// lblTarea
			// 
			this.lblTarea.BackColor = System.Drawing.Color.Transparent;
			this.lblTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTarea.Location = new System.Drawing.Point(0, 0);
			this.lblTarea.Name = "lblTarea";
			this.lblTarea.Size = new System.Drawing.Size(831, 23);
			this.lblTarea.TabIndex = 2;
			this.lblTarea.Text = "Tarea";
			this.lblTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ContainerFiltro
			// 
			this.ContainerFiltro.Controls.Add(this.utcFiltros);
			this.ContainerFiltro.Location = new System.Drawing.Point(28, 114);
			this.ContainerFiltro.Name = "ContainerFiltro";
			this.ContainerFiltro.Size = new System.Drawing.Size(831, 246);
			this.ContainerFiltro.TabIndex = 0;
			// 
			// utcFiltros
			// 
			this.utcFiltros.BackColor = System.Drawing.Color.Transparent;
			this.utcFiltros.Controls.Add(this.ultraTabSharedControlsPage2);
			this.utcFiltros.Controls.Add(this.utpFiltroPrincipal);
			this.utcFiltros.Controls.Add(this.utpFiltroSecundario);
			this.utcFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
			this.utcFiltros.Location = new System.Drawing.Point(0, 0);
			this.utcFiltros.Name = "utcFiltros";
			this.utcFiltros.SharedControlsPage = this.ultraTabSharedControlsPage2;
			this.utcFiltros.Size = new System.Drawing.Size(831, 246);
			this.utcFiltros.TabIndex = 1;
			appearance1.BackColor = System.Drawing.Color.Transparent;
			ultraTab1.ActiveAppearance = appearance1;
			appearance2.BackColor = System.Drawing.Color.Transparent;
			ultraTab1.Appearance = appearance2;
			appearance3.BackColor = System.Drawing.Color.Transparent;
			ultraTab1.ClientAreaAppearance = appearance3;
			ultraTab1.Key = "FiltroPrincipal";
			ultraTab1.TabPage = this.utpFiltroPrincipal;
			ultraTab1.Text = "Filtro Principal";
			appearance4.BackColor = System.Drawing.Color.Transparent;
			ultraTab2.ActiveAppearance = appearance4;
			appearance5.BackColor = System.Drawing.Color.Transparent;
			ultraTab2.Appearance = appearance5;
			appearance6.BackColor = System.Drawing.Color.Transparent;
			ultraTab2.ClientAreaAppearance = appearance6;
			ultraTab2.Key = "FiltroSecundario";
			ultraTab2.TabPage = this.utpFiltroSecundario;
			ultraTab2.Text = "Filtro Secundario";
			this.utcFiltros.Tabs.AddRange(new Infragistics.Win.UltraWinTabControl.UltraTab[] {
																								 ultraTab1,
																								 ultraTab2});
			this.utcFiltros.TabStop = false;
			// 
			// ultraTabSharedControlsPage2
			// 
			this.ultraTabSharedControlsPage2.Location = new System.Drawing.Point(-10000, -10000);
			this.ultraTabSharedControlsPage2.Name = "ultraTabSharedControlsPage2";
			this.ultraTabSharedControlsPage2.Size = new System.Drawing.Size(827, 220);
			// 
			// ContainerJerarquias
			// 
			this.ContainerJerarquias.Controls.Add(this.hierarchicalSearchControl1);
			this.ContainerJerarquias.Controls.Add(this.mzCEProductos);
			this.ContainerJerarquias.Controls.Add(this.label9);
			this.ContainerJerarquias.Location = new System.Drawing.Point(28, 419);
			this.ContainerJerarquias.Name = "ContainerJerarquias";
			this.ContainerJerarquias.Size = new System.Drawing.Size(831, 85);
			this.ContainerJerarquias.TabIndex = 1;
			// 
			// hierarchicalSearchControl1
			// 
			this.hierarchicalSearchControl1.BackColor = System.Drawing.Color.Transparent;
			this.hierarchicalSearchControl1.Location = new System.Drawing.Point(0, 40);
			this.hierarchicalSearchControl1.Name = "hierarchicalSearchControl1";
			this.hierarchicalSearchControl1.Size = new System.Drawing.Size(792, 88);
			this.hierarchicalSearchControl1.TabIndex = 1;
			// 
			// mzCEProductos
			// 
			this.mzCEProductos.DataValue = "";
			this.mzCEProductos.EditObject = null;
			this.mzCEProductos.FastSearch = false;
			this.mzCEProductos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCEProductos.HierarchicalSearch = false;
			this.mzCEProductos.Location = new System.Drawing.Point(121, 0);
			this.mzCEProductos.Name = "mzCEProductos";
			this.mzCEProductos.ReadOnly = false;
			this.mzCEProductos.SearchObject = null;
			this.mzCEProductos.SearchObjectListener = null;
			this.mzCEProductos.Size = new System.Drawing.Size(496, 22);
			this.mzCEProductos.TabIndex = 0;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(8, 4);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(69, 16);
			this.label9.TabIndex = 52;
			this.label9.Text = "Producto";
			// 
			// ContainerJerarquiasClientes
			// 
			this.ContainerJerarquiasClientes.Controls.Add(this.hierarchicalSearchControlClientes);
			this.ContainerJerarquiasClientes.Location = new System.Drawing.Point(28, 524);
			this.ContainerJerarquiasClientes.Name = "ContainerJerarquiasClientes";
			this.ContainerJerarquiasClientes.Size = new System.Drawing.Size(831, 102);
			this.ContainerJerarquiasClientes.TabIndex = 5;
			// 
			// hierarchicalSearchControlClientes
			// 
			this.hierarchicalSearchControlClientes.BackColor = System.Drawing.Color.Transparent;
			this.hierarchicalSearchControlClientes.Location = new System.Drawing.Point(0, 8);
			this.hierarchicalSearchControlClientes.Name = "hierarchicalSearchControlClientes";
			this.hierarchicalSearchControlClientes.Size = new System.Drawing.Size(784, 88);
			this.hierarchicalSearchControlClientes.TabIndex = 55;
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.gridManagerView1);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.gridResultado);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 544);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(831, 296);
			this.ultraExplorerBarContainerControl3.TabIndex = 1;
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
			this.gridManagerView1.Location = new System.Drawing.Point(0, 0);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(864, 24);
			this.gridManagerView1.TabIndex = 0;
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
			this.gridResultado.Location = new System.Drawing.Point(0, 24);
			this.gridResultado.Name = "gridResultado";
			this.gridResultado.Size = new System.Drawing.Size(831, 272);
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
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.richInfoComprobante);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 529);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(831, 150);
			this.ultraExplorerBarContainerControl1.TabIndex = 4;
			// 
			// richInfoComprobante
			// 
			this.richInfoComprobante.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richInfoComprobante.Location = new System.Drawing.Point(0, 0);
			this.richInfoComprobante.Name = "richInfoComprobante";
			this.richInfoComprobante.ReadOnly = true;
			this.richInfoComprobante.Size = new System.Drawing.Size(831, 150);
			this.richInfoComprobante.TabIndex = 1;
			this.richInfoComprobante.TabStop = false;
			this.richInfoComprobante.Text = "";
			// 
			// imglStandar
			// 
			this.imglStandar.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
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
																							  this.tbbSeparator2,
																							  this.tbbConsultar,
																							  this.tbbSeparator3,
																							  this.tbbReiniciarFiltros,
																							  this.toolBarButton3,
																							  this.tbbCancelar,
																							  this.toolBarButton2,
																							  this.tbbImprimir,
																							  this.tbbSeparadorImprimir});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(896, 28);
			this.toolBarStandar.TabIndex = 22;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			// 
			// tbbAnterior
			// 
			this.tbbAnterior.ImageIndex = 9;
			this.tbbAnterior.Text = "&Anterior";
			// 
			// tbbSeparator
			// 
			this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbSiguiente
			// 
			this.tbbSiguiente.ImageIndex = 8;
			this.tbbSiguiente.Text = "&Siguiente";
			// 
			// tbbSeparator2
			// 
			this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbConsultar
			// 
			this.tbbConsultar.ImageIndex = 2;
			this.tbbConsultar.Text = "Ejecutar Consulta[F5]";
			// 
			// tbbSeparator3
			// 
			this.tbbSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbReiniciarFiltros
			// 
			this.tbbReiniciarFiltros.ImageIndex = 5;
			this.tbbReiniciarFiltros.Text = "Reiniciar Filtros de Busqueda";
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbCancelar
			// 
			this.tbbCancelar.ImageIndex = 7;
			this.tbbCancelar.Text = "&Cancelar";
			// 
			// tbbImprimir
			// 
			this.tbbImprimir.ImageIndex = 10;
			this.tbbImprimir.Text = "Imprimir";
			// 
			// tbbSeparadorImprimir
			// 
			this.tbbSeparadorImprimir.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// ultraExplorerBar2
			// 
			this.ultraExplorerBar2.Controls.Add(this.ContainerFiltro);
			this.ultraExplorerBar2.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar2.Controls.Add(this.ultraExplorerBarContainerControl4);
			this.ultraExplorerBar2.Controls.Add(this.ContainerJerarquias);
			this.ultraExplorerBar2.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar2.Controls.Add(this.ContainerJerarquiasClientes);
			this.ultraExplorerBar2.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl4;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 31;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ContainerFiltro;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 246;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Filtros";
			ultraExplorerBarGroup3.Container = this.ContainerJerarquias;
			ultraExplorerBarGroup3.Settings.ContainerHeight = 85;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Productos";
			ultraExplorerBarGroup4.Container = this.ContainerJerarquiasClientes;
			ultraExplorerBarGroup4.Settings.ContainerHeight = 102;
			ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup4.Text = "Jerarquia de Clientes";
			ultraExplorerBarGroup5.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup5.Settings.ContainerHeight = 296;
			ultraExplorerBarGroup5.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup5.Text = "Resultado";
			ultraExplorerBarGroup6.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup6.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup6.Text = "Observaciones";
			this.ultraExplorerBar2.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3,
																														ultraExplorerBarGroup4,
																														ultraExplorerBarGroup5,
																														ultraExplorerBarGroup6});
			this.ultraExplorerBar2.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar2.Name = "ultraExplorerBar2"; this.ultraExplorerBar2.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar2.Size = new System.Drawing.Size(896, 514);
			this.ultraExplorerBar2.TabIndex = 0;
			this.ultraExplorerBar2.TabStop = false;
			// 
			// FrmConsultaEntregas
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(896, 542);
			this.Controls.Add(this.ultraExplorerBar2);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmConsultaEntregas";
			this.Text = "FrmConsultaEntregas";
			this.utpFiltroPrincipal.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.FechaVtoDesde)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaVtoHasta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaConvDesde)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaConvHasta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaDesde)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaHasta)).EndInit();
			this.utpFiltroSecundario.ResumeLayout(false);
			this.ultraExplorerBarContainerControl4.ResumeLayout(false);
			this.ContainerFiltro.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.utcFiltros)).EndInit();
			this.utcFiltros.ResumeLayout(false);
			this.ContainerJerarquias.ResumeLayout(false);
			this.ContainerJerarquiasClientes.ResumeLayout(false);
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar2)).EndInit();
			this.ultraExplorerBar2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Constructores y Destructores

		public FrmConsultaEntregas()
		{
			InitializeComponent();
		}

		public FrmConsultaEntregas(ConsultaEntregasController controller)
		{
			InitializeComponent();
			_uiController = controller;
			Init();

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

		#region Variables Privadas
		
		private ConsultaEntregasController _uiController = null;
		private ReportFilterArray _filtros = null;
		private int iniX = 10;
		private int iniY = 10;
		private int desplazamientotexto = 150;
		private int factordealtura = 24;
		private ArrayList _parametros = new ArrayList();
		
		#endregion

		#region Inicializadores y Carga
		protected void Build_UI()
		{
			ConfigureInterface();	
			InitializeData();
			InitEventHandlers();
			InitDataBindings();			
		}
		private void ConfigureInterface()
		{			
			
			this.mzCmbResponsableEmision.Tag = "ResponsableEmision";  // va
			this.chkEntreFechaVto.Tag = "FechaVencimiento"; // va
			this.FechaVtoDesde.Tag = "FechaVencimiento"; 
			this.FechaVtoHasta.Tag = "FechaVencimiento";
			this.chkEntreFechaConv.Tag = "FechaConvenida";
			this.FechaConvDesde.Tag = "FechaConvenida";
			this.FechaConvHasta.Tag = "FechaConvenida";
			this.chkEntreFecha.Tag = "Fecha"; // va
			this.chkEntreFechas.Tag = "Numero";
			this.cboTiposDeComprobantes.Tag = "TiposDeComprobantes"; // va
			this.FechaDesde.Tag = "Fecha";
			this.FechaHasta.Tag = "Fecha";
			this.mzCmbCuenta.Tag = "Cuenta"; // va
			this.chkPendientes.Tag = "Pendientes"; // va

			this.txtCampoAuxiliar1.Tag = "CampoAuxiliar1";
			this.txtCampoAuxiliar2.Tag = "CampoAuxiliar2";
			this.txtCampoAuxiliar3.Tag = "CampoAuxiliar3";
			this.txtCampoAuxiliar4.Tag = "CampoAuxiliar4";
			this.txtCampoAuxiliar5.Tag = "CampoAuxiliar5";
			this.txtObservaciones.Tag = "Observaciones";
			
			mzCEProductos.SearchObject= _uiController.SearchProducto;
			tbbImprimir.Visible = _uiController.VisualizaBotonImprimir;
			tbbSeparadorImprimir.Visible = _uiController.VisualizaBotonImprimir;

			mzCmbCuenta.Init(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName());
			mzCmbCuenta.Enabled = true;

			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), gridResultado, this.Text);

			ultraExplorerBar2.Groups[2].Expanded = false;	
			// Busca los nombres a poner en el Formulario --> para la solapa y titulo
			this.Text = _uiController.LeyendaFormulario;
			lblTarea.Text = _uiController.LeyendaFormulario;
			mzCEProductos.WidthSearchForm = 800;
			mzCEProductos.LayoutData = _uiController.LayoutProductos;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			this.gridResultado.AutomaticSort = true;
			this.KeyPreview = true;
			this.hierarchicalSearchControl1.Build_UI("PRODUCTOS",_uiController.AllowMultipleSelect);	
		
			this.hierarchicalSearchControlClientes.Build_UI("CUENTAS",_uiController.AllowMultipleSelect);

			FechaDesde.Enabled = false;
			FechaHasta.Enabled = false;		
			FechaConvDesde.Enabled =false;
			FechaConvHasta.Enabled = false;
			FechaVtoDesde.Enabled = false;
			FechaVtoHasta.Enabled = false;

			if (! _uiController.AllowGeneralSearch)
			{			
				chkEntreFecha.Enabled = false;
				chkEntreFechaConv.Enabled = false;
				chkEntreFechaVto.Enabled = false;
			}
			else 
			{
				chkEntreFecha.Enabled = true;
				chkEntreFechaConv.Enabled = true;
				chkEntreFechaVto.Enabled = true;

			}
			

			chkEntreFechas.Checked = _uiController.FilterByNumero;
			txtNumeroDesde.Enabled = _uiController.FilterByNumero;
			txtNumeroHasta.Enabled = _uiController.FilterByNumero;
			txtNumeroDesde.InputMask = @">A-####-########";			
			txtNumeroHasta.InputMask = @">A-####-########";
			txtNumeroDesde.Text = _uiController.NumeroDesde;
			txtNumeroHasta.Text = _uiController.NumeroHasta;

			chkEntreFecha.Checked = _uiController.FilterByFecha;
			chkEntreFechaConv.Checked = _uiController.FilterByFechaConv;
			chkEntreFechaVto.Checked = _uiController.FilterByFechaVto;
			
			// Organiza los filtros.
			ControlManager cm = new ControlManager();
			cm.OrganizeFilters(utpFiltroPrincipal.Controls, _uiController.ListaFiltros);
			ContainerFiltro.Height = cm.Height + 23;
			ControlManager cm2 = new ControlManager();
			cm2.OrganizeFilters(utpFiltroSecundario.Controls, _uiController.ListaFiltrosSecundarios);
			if(cm2.Height + 23 >ContainerFiltro.Height)
				ContainerFiltro.Height = cm2.Height + 23;
			ConfigureTiposComprobantes();			

			lblEtiquetaCampoAuxiliar1.Text = _uiController.EtiquetaCampoAuxiliar1;
			lblEtiquetaCampoAuxiliar2.Text = _uiController.EtiquetaCampoAuxiliar2;
			lblEtiquetaCampoAuxiliar3.Text = _uiController.EtiquetaCampoAuxiliar3;
			lblEtiquetaCampoAuxiliar4.Text = _uiController.EtiquetaCampoAuxiliar4;
			lblEtiquetaCampoAuxiliar5.Text = _uiController.EtiquetaCampoAuxiliar5;

			mz.erp.ui.forms.classes.ContainerManager.UpdateSize(this.ContainerJerarquias, hierarchicalSearchControl1);
			mz.erp.ui.forms.classes.ContainerManager.UpdateSize(this.ContainerJerarquiasClientes, hierarchicalSearchControlClientes);
		}



		private void ConfigureTiposComprobantes()
		{
			object defaultValue = null;
			string _listaFamiliaDeComprobantesEntregas = _uiController.ListaFamiliaDeComprobantesEntregas;
			string _familiaDefault = _uiController.FamiliaDefault;

			if(_listaFamiliaDeComprobantesEntregas == null || _listaFamiliaDeComprobantesEntregas.Equals(string.Empty))
				cboTiposDeComprobantes.Items.AddRange(new object [] {_uiController.TodosLosComprobantes,"Orden de Preparado Diferida", "Orden de Preparado Inmediata","Remito","Remito Interno de Entrega"});
			else
			{
				ArrayList aux = new ArrayList();
				
				aux.Add(_uiController.TodosLosComprobantes);
				aux.AddRange(mz.erp.systemframework.Util.Parse(_listaFamiliaDeComprobantesEntregas,","));
				cboTiposDeComprobantes.Items.AddRange(aux.ToArray());					
			}
			cboTiposDeComprobantes.SelectedItem = _uiController.TodosLosComprobantes;
			
			if (_familiaDefault != "")
			{
				cboTiposDeComprobantes.SelectedItem = (string)_familiaDefault;
				_uiController.FamiliaComprobantes = (string)_familiaDefault;
			}
		}

		private void InitializeData()
		{
			mzCEProductos.SearchObject= _uiController.SearchProducto;
		}
		private void InitEventHandlers()
		{			
			_uiController.DataChanged+=new EventHandler(RefreshData);
			this.Load +=new EventHandler(FrmConsultaEntregas_Load);
			this.KeyDown +=new KeyEventHandler(KeyDownBehavior);
			gridResultado.GroupsChanged +=new Janus.Windows.GridEX.GroupsChangedEventHandler(gridResultado_GroupsChanged);
			hierarchicalSearchControl1.OnSelected+=new EventHandler(hierarchicalSearchControl1_OnSelected);
			hierarchicalSearchControlClientes.OnSelected+=new EventHandler(hierarchicalSearchControlClientes_OnSelected);
			
			this.Detalles.Click +=new System.EventHandler(this.Detalles_Click);
			this.gridResultado.SelectionChanged +=new EventHandler(this.DetallesResumido_Click);	
	
			mzCmbCuenta.AllowEditClientePaso = false;
			mzCmbCuenta.SearchObjectListener = this;
			mzCmbCuenta.ValueChanged+= new System.EventHandler( this.Componentes_Changes );		
			mzCmbResponsableEmision.SearchObject = typeof( mz.erp.ui.forms.classes.tsh_Personas );			
			chkEntreFechas.Click+=new EventHandler(chkEntreFechas_Click);

			chkEntreFecha.Click+=new EventHandler(chkEntreFecha_Click);
			chkEntreFechaConv.Click+=new EventHandler(chkEntreFechaConv_Click);
			chkEntreFechaVto.Click+=new EventHandler(chkEntreFechaVto_Click);
			KeyDownManager KeyDown = new KeyDownManager(this);
            //Cristian Tarea 0000050 20110310
            this.FechaVtoDesde.ValueChanged +=new EventHandler(FechaDesde_ValueChanged);
            //Fin Cristian
            //Cristian Tarea 000146 20110310
            this.FechaVtoHasta.ValueChanged += new EventHandler(FechaVtoHasta_ValueChanged);
            //Fin Cristian 20110726

        }

        //Cristian Tarea 000146 20110725
        void FechaVtoHasta_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(FechaVtoHasta.Value)), true);
            this.FechaVtoDesde.Value = _uiController.FechaVtoDesde;
        }
        //Fin Cristian 20110726
        //Cristian Tarea 0000050 20110310
        void FechaDesde_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(FechaVtoDesde.Value)),false);
            this.FechaVtoHasta.Value = _uiController.FechaVtoHasta;

        }
        //Fin Cristian

		private void Componentes_Changes( object sender, System.EventArgs e )
		{			
			_uiController.CodigoCuenta = Convert.ToString(mzCmbCuenta.DataValue);				
			if (! _uiController.AllowGeneralSearch)
			{
				if (_uiController.CodigoCuenta == "")
				{
					chkEntreFecha.Enabled = false;
					chkEntreFechaConv.Enabled = false;
					chkEntreFechaVto.Enabled = false;
					FechaDesde.Value = _uiController.FechaDesdeDefault;
					FechaHasta.Value = _uiController.FechaHastaDefault;
					FechaConvDesde.Value = _uiController.FechaDesdeDefault;
					FechaConvHasta.Value = _uiController.FechaHastaDefault;
					FechaVtoDesde.Value = _uiController.FechaDesdeDefault;
					FechaVtoHasta.Value = _uiController.FechaHastaDefault;
					_uiController.FechaDesde = _uiController.FechaDesdeDefault;
					_uiController.FechaHasta = _uiController.FechaHastaDefault;
					_uiController.FechaConvDesde = _uiController.FechaDesdeDefault;
					_uiController.FechaConvHasta = _uiController.FechaHastaDefault;
					_uiController.FechaVtoDesde = _uiController.FechaDesdeDefault;
					_uiController.FechaVtoDesde = _uiController.FechaHastaDefault;
				}
				else 
				{
					chkEntreFecha.Enabled = true;
					chkEntreFechaConv.Enabled = true;
					chkEntreFechaVto.Enabled = true;
				}
			}
			else 
			{
				chkEntreFecha.Enabled = true;
				chkEntreFechaConv.Enabled = true;
				chkEntreFechaVto.Enabled = true;
			}
		}

		public void processEventChange(object sender , EventArgs e)
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
			BindingController.Bind(mzCmbResponsableEmision, "DataValue", _uiController, "ResponsableEmision");
			BindingController.Bind(cboTiposDeComprobantes, "Text", _uiController, "FamiliaComprobantes");

			FechaDesde.DataBindings.Add("Value", _uiController, "FechaDesde");
			FechaHasta.DataBindings.Add("Value", _uiController, "FechaHasta");			
			FechaConvDesde.DataBindings.Add("Value", _uiController, "FechaConvDesde");
			FechaConvHasta.DataBindings.Add("Value", _uiController, "FechaConvHasta");			
			FechaVtoDesde.DataBindings.Add("Value", _uiController, "FechaVtoDesde");
			FechaVtoHasta.DataBindings.Add("Value", _uiController, "FechaVtoHasta");			
			mzCEProductos.DataBindings.Add("DataValue", _uiController, "Codigo");

			txtObservaciones.DataBindings.Add("Text", _uiController, "Observaciones");
			txtCampoAuxiliar1.DataBindings.Add("Text", _uiController, "CampoAuxiliar1");
			txtCampoAuxiliar2.DataBindings.Add("Text", _uiController, "CampoAuxiliar2");
			txtCampoAuxiliar3.DataBindings.Add("Text", _uiController, "CampoAuxiliar3");
			txtCampoAuxiliar4.DataBindings.Add("Text", _uiController, "CampoAuxiliar4");
			txtCampoAuxiliar5.DataBindings.Add("Text", _uiController, "CampoAuxiliar5");

		}
		
		#endregion

		#region Miembros de ITaskForm

		public void Execute()
		{
			this._uiController.Execute();
		}

		public void Previous()
		{
			this._uiController.Previous();
		}

		public void ShowForm()
		{
			if(this._uiController.AllowShow())
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
			}
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
			_uiController.Execute();
		}

		#endregion

		#region Métodos privados
		
		
		private void chkFiltroFechas_Click(object sender, System.EventArgs e)
		{
		}

		private void Init()
		{
			_filtros = _uiController.GetFiltro();
			#region filtros
			for (int i=0;i<=(_filtros.Count-1);i++)
			{
				ReportFilterItem unfiltro = _filtros[i];
				if ((unfiltro.Clave.ToUpper() == "PRODUCTO"))
				{
					_parametros.Add( null );
				}
				if ((unfiltro.Clave.ToUpper() == "PROVEEDOR"))
				{
					_parametros.Add( null );
				}
			}
			#endregion
		}

		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					_uiController.Previous();
					break;
				case 2:
					_uiController.Execute();
					break;
				case 4:					
					RefreshData();
					break;
				case 6:					
					ResetFilters();
					break;
				case 8:
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
			this.Cursor = Cursors.Default;
		}

		private void ResetFilters()
		{
			// Filtro ppal
			mzCmbCuenta.ClearControl(); //mzCmbCuenta.DataValue=string.Empty;
			_uiController.CodigoCuenta=string.Empty;

			mzCmbResponsableEmision.DataValue=string.Empty;
			_uiController.ResetFechas();
			
			chkEntreFechaVto.Checked=false;
			FechaVtoDesde.Enabled=false;
			FechaVtoHasta.Enabled=false;
			FechaVtoDesde.Value=_uiController.FechaVtoDesde;
			FechaVtoHasta.Value=_uiController.FechaVtoHasta;
			
			chkEntreFechaConv.Checked=false;
			FechaConvDesde.Enabled=false;
			FechaConvHasta.Enabled=false;
			FechaConvDesde.Value=_uiController.FechaConvDesde;
			FechaConvHasta.Value=_uiController.FechaConvHasta;

			chkEntreFecha.Checked=false;
			FechaDesde.Enabled=false;
			FechaHasta.Enabled=false;
			FechaDesde.Value=_uiController.FechaDesde;
			FechaHasta.Value=_uiController.FechaHasta;

			cboTiposDeComprobantes.Text=string.Empty;
			txtNumeroDesde.Text=string.Empty;
			txtNumeroHasta.Text=string.Empty;	
			
			txtObservaciones.Text=string.Empty;
			txtCampoAuxiliar1.Text=string.Empty;
			txtCampoAuxiliar2.Text=string.Empty;
			txtCampoAuxiliar3.Text=string.Empty;
			txtCampoAuxiliar4.Text=string.Empty;
			txtCampoAuxiliar5.Text=string.Empty;

            chkPendientes.Checked=false;		

			// Filtro Productos
			mzCEProductos.DataValue=string.Empty;
			hierarchicalSearchControl1.ClearSelectedNodes();

			// Filtro Jerarquias
			hierarchicalSearchControlClientes.ClearSelectedNodes();

			gridResultado.SetDataBinding(null, null);
			gridResultado.Refresh();
		}

		private void DumpControls()
		{
			_uiController.NumeroDesde = txtNumeroDesde.Text;
			_uiController.NumeroHasta = txtNumeroHasta.Text;
			_uiController.Pendientes = chkPendientes.Checked;
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

		private void FrmConsultaEntregas_Load(object sender, EventArgs e)
		{
		}

		#endregion
		
		// Aca entra cuando cambia el agrupamiento :D
		private void gridResultado_GroupsChanged(object sender, Janus.Windows.GridEX.GroupsChangedEventArgs e)
		{
			this.gridResultado.CollapseGroups();
		}

		private void gridManagerView1_Load(object sender, System.EventArgs e)
		{		
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

		private void hierarchicalSearchControlClientes_OnSelected(object sender, EventArgs e)
		{			
			_uiController.ByJerarquia9 = hierarchicalSearchControlClientes.NodeChecked1;
			_uiController.Jerarquias9 = hierarchicalSearchControlClientes.ItemsJerarquia1;
			_uiController.ByJerarquia10 = hierarchicalSearchControlClientes.NodeChecked2;
			_uiController.Jerarquias10 = hierarchicalSearchControlClientes.ItemsJerarquia2;
			_uiController.ByJerarquia11 = hierarchicalSearchControlClientes.NodeChecked3;
			_uiController.Jerarquias11 = hierarchicalSearchControlClientes.ItemsJerarquia3;
			_uiController.ByJerarquia12 = hierarchicalSearchControlClientes.NodeChecked4;
			_uiController.Jerarquias12 = hierarchicalSearchControlClientes.ItemsJerarquia4;
			_uiController.ByJerarquia13 = hierarchicalSearchControlClientes.NodeChecked5;
			_uiController.Jerarquias13 = hierarchicalSearchControlClientes.ItemsJerarquia5;
			_uiController.ByJerarquia14 = hierarchicalSearchControlClientes.NodeChecked6;
			_uiController.Jerarquias14 = hierarchicalSearchControlClientes.ItemsJerarquia6;
			_uiController.ByJerarquia15 = hierarchicalSearchControlClientes.NodeChecked7;
			_uiController.Jerarquias15 = hierarchicalSearchControlClientes.ItemsJerarquia7;
			_uiController.ByJerarquia16 = hierarchicalSearchControlClientes.NodeChecked8;
			_uiController.Jerarquias16 = hierarchicalSearchControlClientes.ItemsJerarquia8;			
		}


		private void chkEntreFechas_Click(object sender, EventArgs e)
		{						
			_uiController.FilterByNumero = chkEntreFechas.Checked;			
			txtNumeroDesde.Enabled = chkEntreFechas.Checked;
			txtNumeroHasta.Enabled = chkEntreFechas.Checked;
		}

		private void chkEntreFecha_Click(object sender, EventArgs e)
		{						
			_uiController.FilterByFecha = chkEntreFecha.Checked;			
			FechaDesde.Enabled = chkEntreFecha.Checked;
			FechaHasta.Enabled = chkEntreFecha.Checked;
		}

		private void chkEntreFechaConv_Click(object sender, EventArgs e)
		{						
			_uiController.FilterByFechaConv = chkEntreFechaConv.Checked;			
			FechaConvDesde.Enabled = chkEntreFechaConv.Checked;
			FechaConvHasta.Enabled = chkEntreFechaConv.Checked;
		}
	
		private void chkEntreFechaVto_Click(object sender, EventArgs e)
		{						
			_uiController.FilterByFechaVto = chkEntreFechaVto.Checked;			
			FechaVtoDesde.Enabled = chkEntreFechaVto.Checked;
			FechaVtoHasta.Enabled = chkEntreFechaVto.Checked;
		}


		// Metodo invocado por opcion del boton derecho (sobre la grilla)
		// Detalles completo
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

		private void DetallesResumido_Click(object sender, EventArgs e)
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


	}
}

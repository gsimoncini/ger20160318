using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.commontypes;
using mz.erp.ui.controllers;
using mz.erp.systemframework;
using mz.erp.ui.controls;
using mz.erp.ui.forms.classes;
using mz.erp.ui.utility;


namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmComprobantesDeCompra.
	/// </summary>
	public class FrmComprobantesDeCompra : System.Windows.Forms.Form,ITaskForm, ISearchObjectListener
	{
		private System.ComponentModel.IContainer components;

		private mz.erp.businessrules.comprobantes.ComprobanteDeCompra _compCompra;
		private string _momento;
		private string _state;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo cldFechaRegistracion;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMENumero;
		private mz.erp.ui.controls.mzComboEditor mzCEResponsableEmision;
		private mz.erp.ui.controls.mzComboEditor mzCETipoComprobante;
		private Infragistics.Win.Misc.UltraLabel ultraLabel2;
		private Infragistics.Win.Misc.UltraLabel ultraLabel6;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel3;
		private Infragistics.Win.Misc.UltraLabel ultraLabel5;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo cldFechaComprobante;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl containerItems;
		private mzProductosControl mzProductosControl;
		private Janus.Windows.GridEX.GridEX gridProductos;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotal1;
		private Infragistics.Win.Misc.UltraButton bDetallesProducto;
		private Infragistics.Win.Misc.UltraButton bAgregarProducto;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Label labelTarea;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCampoAuxiliar4;
		private Infragistics.Win.Misc.UltraLabel lblObservaciones;
		private System.Windows.Forms.TextBox txtCampoAuxiliar3;
		private System.Windows.Forms.TextBox txtCampoAuxiliar2;
		private Infragistics.Win.Misc.UltraLabel lblCampoAuxiliar2;
		private Infragistics.Win.Misc.UltraLabel lblCampoAuxiliar4;
		private Infragistics.Win.Misc.UltraLabel lblCampoAuxiliar3;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMECampoAuxiliar1;
		private Infragistics.Win.Misc.UltraLabel lblCampoAuxiliar1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel7;
		private mz.erp.ui.controls.mzComboEditor mzCEMonedas;
		private mz.erp.ui.controls.mzComboEditor mzCETiposDeCambio;
		private Infragistics.Win.Misc.UltraLabel ultraLabel8;
		private Infragistics.Win.Misc.UltraLabel ultraLabel9;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneValorCotizacion;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo uccFechaRecepcionMercaderia;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneDiasDemoraEntrega;
		private Infragistics.Win.Misc.UltraLabel ultraLabel14;
		private mz.erp.ui.controls.mzComboEditor mzCECondicionDeCompra;
		private Infragistics.Win.Misc.UltraLabel ultraLabel10;
		private HtmlRichText.HtmlRichTextBox htmlRichTextBoxObservaciones;
		private mz.erp.ui.controls.mzProveedoresControl mzCmb;
		private System.Windows.Forms.ImageList imglStandar;


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
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton3 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmComprobantesDeCompra));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.mzCmb = new mz.erp.ui.controls.mzProveedoresControl();
			this.mzCECondicionDeCompra = new mz.erp.ui.controls.mzComboEditor();
			this.ultraLabel10 = new Infragistics.Win.Misc.UltraLabel();
			this.cldFechaRegistracion = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.uccFechaRecepcionMercaderia = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.uneDiasDemoraEntrega = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.ultraLabel14 = new Infragistics.Win.Misc.UltraLabel();
			this.mzCETipoComprobante = new mz.erp.ui.controls.mzComboEditor();
			this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
			this.uneValorCotizacion = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.ultraLabel9 = new Infragistics.Win.Misc.UltraLabel();
			this.mzCETiposDeCambio = new mz.erp.ui.controls.mzComboEditor();
			this.ultraLabel8 = new Infragistics.Win.Misc.UltraLabel();
			this.mzCEMonedas = new mz.erp.ui.controls.mzComboEditor();
			this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraMECampoAuxiliar1 = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
			this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraMENumero = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
			this.mzCEResponsableEmision = new mz.erp.ui.controls.mzComboEditor();
			this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
			this.cldFechaComprobante = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.lblCampoAuxiliar1 = new Infragistics.Win.Misc.UltraLabel();
			this.containerItems = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.mzProductosControl = new mz.erp.ui.controls.mzProductosControl();
			this.gridProductos = new Janus.Windows.GridEX.GridEX();
			this.uneTotal1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.bDetallesProducto = new Infragistics.Win.Misc.UltraButton();
			this.bAgregarProducto = new Infragistics.Win.Misc.UltraButton();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.htmlRichTextBoxObservaciones = new HtmlRichText.HtmlRichTextBox();
			this.uneCampoAuxiliar4 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.lblObservaciones = new Infragistics.Win.Misc.UltraLabel();
			this.txtCampoAuxiliar3 = new System.Windows.Forms.TextBox();
			this.txtCampoAuxiliar2 = new System.Windows.Forms.TextBox();
			this.lblCampoAuxiliar2 = new Infragistics.Win.Misc.UltraLabel();
			this.lblCampoAuxiliar4 = new Infragistics.Win.Misc.UltraLabel();
			this.lblCampoAuxiliar3 = new Infragistics.Win.Misc.UltraLabel();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.ultraExplorerBar = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCECondicionDeCompra)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cldFechaRegistracion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uccFechaRecepcionMercaderia)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneDiasDemoraEntrega)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCETipoComprobante)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneValorCotizacion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCETiposDeCambio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMonedas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEResponsableEmision)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cldFechaComprobante)).BeginInit();
			this.containerItems.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotal1)).BeginInit();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uneCampoAuxiliar4)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar)).BeginInit();
			this.ultraExplorerBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, -22);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(910, 24);
			this.ultraExplorerBarContainerControl2.TabIndex = 2;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(910, 23);
			this.labelTarea.TabIndex = 1;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmb);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCECondicionDeCompra);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel10);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.cldFechaRegistracion);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uccFechaRecepcionMercaderia);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uneDiasDemoraEntrega);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel14);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCETipoComprobante);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uneValorCotizacion);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel9);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCETiposDeCambio);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel8);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEMonedas);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel7);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraMECampoAuxiliar1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel4);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraMENumero);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEResponsableEmision);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel6);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel5);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.cldFechaComprobante);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.lblCampoAuxiliar1);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, -92);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(910, 128);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			this.ultraExplorerBarContainerControl1.Visible = false;
			// 
			// mzCmb
			// 
			this.mzCmb.BackColor = System.Drawing.SystemColors.Control;
			this.mzCmb.DataValue = "";
			this.mzCmb.EnableCtaCte = false;
			this.mzCmb.FastSearch = false;
			this.mzCmb.Location = new System.Drawing.Point(128, 28);
			this.mzCmb.Name = "mzCmb";
			this.mzCmb.SearchObjectListener = null;
			this.mzCmb.Size = new System.Drawing.Size(408, 22);
			this.mzCmb.TabIndex = 1;
			this.mzCmb.Tag = "ResponsableEmision";
			// 
			// mzCECondicionDeCompra
			// 
			this.mzCECondicionDeCompra.AutoComplete = true;
			this.mzCECondicionDeCompra.DataSource = null;
			this.mzCECondicionDeCompra.DisplayMember = "";
			this.mzCECondicionDeCompra.DisplayMemberCaption = "";
			this.mzCECondicionDeCompra.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCECondicionDeCompra.Location = new System.Drawing.Point(672, 0);
			this.mzCECondicionDeCompra.MaxItemsDisplay = 7;
			this.mzCECondicionDeCompra.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCECondicionDeCompra.Name = "mzCECondicionDeCompra";
			this.mzCECondicionDeCompra.Size = new System.Drawing.Size(152, 21);
			this.mzCECondicionDeCompra.SorterMember = "";
			this.mzCECondicionDeCompra.TabIndex = 6;
			this.mzCECondicionDeCompra.ValueMember = "";
			this.mzCECondicionDeCompra.ValueMemberCaption = "";
			// 
			// ultraLabel10
			// 
			this.ultraLabel10.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel10.Location = new System.Drawing.Point(553, 6);
			this.ultraLabel10.Name = "ultraLabel10";
			this.ultraLabel10.Size = new System.Drawing.Size(104, 16);
			this.ultraLabel10.TabIndex = 57;
			this.ultraLabel10.Text = "Cond. De Pago";
			// 
			// cldFechaRegistracion
			// 
			dateButton1.Caption = "Today";
			this.cldFechaRegistracion.DateButtons.Add(dateButton1);
			this.cldFechaRegistracion.Location = new System.Drawing.Point(128, 80);
			this.cldFechaRegistracion.Name = "cldFechaRegistracion";
			this.cldFechaRegistracion.NonAutoSizeHeight = 23;
			this.cldFechaRegistracion.Size = new System.Drawing.Size(112, 21);
			this.cldFechaRegistracion.TabIndex = 3;
			this.cldFechaRegistracion.Value = new System.DateTime(2005, 1, 28, 0, 0, 0, 0);
			// 
			// uccFechaRecepcionMercaderia
			// 
			dateButton2.Caption = "Today";
			this.uccFechaRecepcionMercaderia.DateButtons.Add(dateButton2);
			this.uccFechaRecepcionMercaderia.Location = new System.Drawing.Point(672, 24);
			this.uccFechaRecepcionMercaderia.Name = "uccFechaRecepcionMercaderia";
			this.uccFechaRecepcionMercaderia.NonAutoSizeHeight = 23;
			this.uccFechaRecepcionMercaderia.Size = new System.Drawing.Size(112, 21);
			this.uccFechaRecepcionMercaderia.TabIndex = 7;
			this.uccFechaRecepcionMercaderia.Value = new System.DateTime(2005, 1, 28, 0, 0, 0, 0);
			this.uccFechaRecepcionMercaderia.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.uccFechaRecepcionMercaderia_BeforeDropDown);
			// 
			// uneDiasDemoraEntrega
			// 
			this.uneDiasDemoraEntrega.Location = new System.Drawing.Point(792, 24);
			this.uneDiasDemoraEntrega.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
			this.uneDiasDemoraEntrega.MaskInput = "nnn";
			this.uneDiasDemoraEntrega.MaxValue = 999;
			this.uneDiasDemoraEntrega.MinValue = 0;
			this.uneDiasDemoraEntrega.Name = "uneDiasDemoraEntrega";
			this.uneDiasDemoraEntrega.Size = new System.Drawing.Size(32, 21);
			this.uneDiasDemoraEntrega.TabIndex = 10;
			this.uneDiasDemoraEntrega.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			this.uneDiasDemoraEntrega.Enter += new System.EventHandler(this.uneDiasDemoraEntrega_Enter);
			// 
			// ultraLabel14
			// 
			this.ultraLabel14.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel14.Location = new System.Drawing.Point(552, 29);
			this.ultraLabel14.Name = "ultraLabel14";
			this.ultraLabel14.Size = new System.Drawing.Size(112, 16);
			this.ultraLabel14.TabIndex = 53;
			this.ultraLabel14.Text = "Fecha Recep. merc.";
			// 
			// mzCETipoComprobante
			// 
			this.mzCETipoComprobante.AutoComplete = true;
			this.mzCETipoComprobante.DataSource = null;
			this.mzCETipoComprobante.DisplayMember = "";
			this.mzCETipoComprobante.DisplayMemberCaption = "";
			this.mzCETipoComprobante.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCETipoComprobante.Location = new System.Drawing.Point(128, 53);
			this.mzCETipoComprobante.MaxItemsDisplay = 7;
			this.mzCETipoComprobante.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCETipoComprobante.Name = "mzCETipoComprobante";
			this.mzCETipoComprobante.Size = new System.Drawing.Size(167, 21);
			this.mzCETipoComprobante.SorterMember = "";
			this.mzCETipoComprobante.TabIndex = 2;
			this.mzCETipoComprobante.ValueMember = "";
			this.mzCETipoComprobante.ValueMemberCaption = "";
			// 
			// ultraLabel2
			// 
			this.ultraLabel2.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel2.Location = new System.Drawing.Point(8, 56);
			this.ultraLabel2.Name = "ultraLabel2";
			this.ultraLabel2.Size = new System.Drawing.Size(116, 16);
			this.ultraLabel2.TabIndex = 20;
			this.ultraLabel2.Text = "Tipo de Comprobante";
			// 
			// uneValorCotizacion
			// 
			this.uneValorCotizacion.Location = new System.Drawing.Point(672, 96);
			this.uneValorCotizacion.MinValue = 0;
			this.uneValorCotizacion.Name = "uneValorCotizacion";
			this.uneValorCotizacion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneValorCotizacion.Size = new System.Drawing.Size(152, 21);
			this.uneValorCotizacion.TabIndex = 10;
			this.uneValorCotizacion.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			this.uneValorCotizacion.ValueChanged += new System.EventHandler(this.uneValorCotizacion_ValueChanged);
			this.uneValorCotizacion.Enter += new System.EventHandler(this.uneValorCotizacion_Enter);
			// 
			// ultraLabel9
			// 
			this.ultraLabel9.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel9.Location = new System.Drawing.Point(552, 104);
			this.ultraLabel9.Name = "ultraLabel9";
			this.ultraLabel9.Size = new System.Drawing.Size(112, 16);
			this.ultraLabel9.TabIndex = 34;
			this.ultraLabel9.Text = "Cotizacion";
			// 
			// mzCETiposDeCambio
			// 
			this.mzCETiposDeCambio.AutoComplete = true;
			this.mzCETiposDeCambio.DataSource = null;
			this.mzCETiposDeCambio.DisplayMember = "";
			this.mzCETiposDeCambio.DisplayMemberCaption = "";
			this.mzCETiposDeCambio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCETiposDeCambio.Location = new System.Drawing.Point(672, 72);
			this.mzCETiposDeCambio.MaxItemsDisplay = 7;
			this.mzCETiposDeCambio.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCETiposDeCambio.Name = "mzCETiposDeCambio";
			this.mzCETiposDeCambio.Size = new System.Drawing.Size(152, 21);
			this.mzCETiposDeCambio.SorterMember = "";
			this.mzCETiposDeCambio.TabIndex = 9;
			this.mzCETiposDeCambio.ValueMember = "";
			this.mzCETiposDeCambio.ValueMemberCaption = "";
			// 
			// ultraLabel8
			// 
			this.ultraLabel8.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel8.Location = new System.Drawing.Point(552, 79);
			this.ultraLabel8.Name = "ultraLabel8";
			this.ultraLabel8.Size = new System.Drawing.Size(120, 16);
			this.ultraLabel8.TabIndex = 32;
			this.ultraLabel8.Text = "Tipo de Cambio";
			// 
			// mzCEMonedas
			// 
			this.mzCEMonedas.AutoComplete = true;
			this.mzCEMonedas.DataSource = null;
			this.mzCEMonedas.DisplayMember = "";
			this.mzCEMonedas.DisplayMemberCaption = "";
			this.mzCEMonedas.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEMonedas.Location = new System.Drawing.Point(672, 48);
			this.mzCEMonedas.MaxItemsDisplay = 7;
			this.mzCEMonedas.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEMonedas.Name = "mzCEMonedas";
			this.mzCEMonedas.Size = new System.Drawing.Size(152, 21);
			this.mzCEMonedas.SorterMember = "";
			this.mzCEMonedas.TabIndex = 8;
			this.mzCEMonedas.ValueMember = "";
			this.mzCEMonedas.ValueMemberCaption = "";
			// 
			// ultraLabel7
			// 
			this.ultraLabel7.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel7.Location = new System.Drawing.Point(552, 53);
			this.ultraLabel7.Name = "ultraLabel7";
			this.ultraLabel7.Size = new System.Drawing.Size(120, 16);
			this.ultraLabel7.TabIndex = 30;
			this.ultraLabel7.Text = "Moneda Comprobante";
			// 
			// ultraMECampoAuxiliar1
			// 
			this.ultraMECampoAuxiliar1.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
			this.ultraMECampoAuxiliar1.InputMask = "?-####-########";
			this.ultraMECampoAuxiliar1.Location = new System.Drawing.Point(128, 80);
			this.ultraMECampoAuxiliar1.Name = "ultraMECampoAuxiliar1";
			this.ultraMECampoAuxiliar1.TabIndex = 3;
			this.ultraMECampoAuxiliar1.Text = "--";
			// 
			// ultraLabel4
			// 
			this.ultraLabel4.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel4.Location = new System.Drawing.Point(8, 82);
			this.ultraLabel4.Name = "ultraLabel4";
			this.ultraLabel4.Size = new System.Drawing.Size(120, 16);
			this.ultraLabel4.TabIndex = 27;
			this.ultraLabel4.Text = "Fecha de ingreso";
			// 
			// ultraMENumero
			// 
			this.ultraMENumero.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
			this.ultraMENumero.InputMask = "\\A-####-########";
			this.ultraMENumero.Location = new System.Drawing.Point(376, 54);
			this.ultraMENumero.Name = "ultraMENumero";
			this.ultraMENumero.TabIndex = 5;
			this.ultraMENumero.Text = "A--";
			this.ultraMENumero.Leave += new System.EventHandler(this.ultraMENumero_Leave);
			// 
			// mzCEResponsableEmision
			// 
			this.mzCEResponsableEmision.AutoComplete = true;
			this.mzCEResponsableEmision.DataSource = null;
			this.mzCEResponsableEmision.DisplayMember = "";
			this.mzCEResponsableEmision.DisplayMemberCaption = "";
			this.mzCEResponsableEmision.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEResponsableEmision.Location = new System.Drawing.Point(128, 2);
			this.mzCEResponsableEmision.MaxItemsDisplay = 8;
			this.mzCEResponsableEmision.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEResponsableEmision.Name = "mzCEResponsableEmision";
			this.mzCEResponsableEmision.Size = new System.Drawing.Size(167, 21);
			this.mzCEResponsableEmision.SorterMember = "";
			this.mzCEResponsableEmision.TabIndex = 0;
			this.mzCEResponsableEmision.ValueMember = "";
			this.mzCEResponsableEmision.ValueMemberCaption = "";
			// 
			// ultraLabel6
			// 
			this.ultraLabel6.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel6.Location = new System.Drawing.Point(8, 6);
			this.ultraLabel6.Name = "ultraLabel6";
			this.ultraLabel6.Size = new System.Drawing.Size(120, 16);
			this.ultraLabel6.TabIndex = 15;
			this.ultraLabel6.Text = "Responsable Emisión";
			// 
			// ultraLabel1
			// 
			this.ultraLabel1.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel1.Location = new System.Drawing.Point(8, 32);
			this.ultraLabel1.Name = "ultraLabel1";
			this.ultraLabel1.Size = new System.Drawing.Size(62, 16);
			this.ultraLabel1.TabIndex = 13;
			this.ultraLabel1.Text = "Proveedor";
			// 
			// ultraLabel3
			// 
			this.ultraLabel3.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel3.Location = new System.Drawing.Point(8, 104);
			this.ultraLabel3.Name = "ultraLabel3";
			this.ultraLabel3.Size = new System.Drawing.Size(112, 16);
			this.ultraLabel3.TabIndex = 12;
			this.ultraLabel3.Text = "Fecha de emisión";
			// 
			// ultraLabel5
			// 
			this.ultraLabel5.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel5.Location = new System.Drawing.Point(304, 56);
			this.ultraLabel5.Name = "ultraLabel5";
			this.ultraLabel5.Size = new System.Drawing.Size(62, 16);
			this.ultraLabel5.TabIndex = 10;
			this.ultraLabel5.Text = "Número";
			// 
			// cldFechaComprobante
			// 
			dateButton3.Caption = "Today";
			this.cldFechaComprobante.DateButtons.Add(dateButton3);
			this.cldFechaComprobante.Location = new System.Drawing.Point(128, 104);
			this.cldFechaComprobante.Name = "cldFechaComprobante";
			this.cldFechaComprobante.NonAutoSizeHeight = 23;
			this.cldFechaComprobante.Size = new System.Drawing.Size(112, 21);
			this.cldFechaComprobante.TabIndex = 4;
			this.cldFechaComprobante.Value = new System.DateTime(2005, 1, 28, 0, 0, 0, 0);
			// 
			// lblCampoAuxiliar1
			// 
			this.lblCampoAuxiliar1.BackColor = System.Drawing.Color.Transparent;
			this.lblCampoAuxiliar1.Location = new System.Drawing.Point(8, 82);
			this.lblCampoAuxiliar1.Name = "lblCampoAuxiliar1";
			this.lblCampoAuxiliar1.Size = new System.Drawing.Size(112, 16);
			this.lblCampoAuxiliar1.TabIndex = 29;
			this.lblCampoAuxiliar1.Text = "Campo Auxiliar 1";
			// 
			// containerItems
			// 
			this.containerItems.Controls.Add(this.gridManagerView1);
			this.containerItems.Controls.Add(this.mzProductosControl);
			this.containerItems.Controls.Add(this.gridProductos);
			this.containerItems.Controls.Add(this.uneTotal1);
			this.containerItems.Controls.Add(this.bDetallesProducto);
			this.containerItems.Controls.Add(this.bAgregarProducto);
			this.containerItems.Location = new System.Drawing.Point(28, 95);
			this.containerItems.Name = "containerItems";
			this.containerItems.Size = new System.Drawing.Size(910, 269);
			this.containerItems.TabIndex = 1;
			this.containerItems.Visible = false;
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
			this.gridManagerView1.Location = new System.Drawing.Point(192, 0);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(384, 24);
			this.gridManagerView1.TabIndex = 2;
			// 
			// mzProductosControl
			// 
			this.mzProductosControl.BackColor = System.Drawing.Color.Transparent;
			this.mzProductosControl.EnabledCantidad = false;
			this.mzProductosControl.EnabledListaDePrecio = true;
			this.mzProductosControl.Location = new System.Drawing.Point(0, 192);
			this.mzProductosControl.Name = "mzProductosControl";
			this.mzProductosControl.Size = new System.Drawing.Size(776, 80);
			this.mzProductosControl.TabIndex = 4;
			this.mzProductosControl.VisibleCantidad = true;
			this.mzProductosControl.VisibleComboListaDePrecios = true;
			this.mzProductosControl.VisibleComboTipoDePrecioDeCosto = false;
			this.mzProductosControl.VisiblePrecios = true;
			this.mzProductosControl.Load += new System.EventHandler(this.mzProductosControl_Load);
			// 
			// gridProductos
			// 
			this.gridProductos.AllowCardSizing = false;
			this.gridProductos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridProductos.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridProductos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridProductos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.gridProductos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridProductos.Location = new System.Drawing.Point(0, 32);
			this.gridProductos.Name = "gridProductos";
			this.gridProductos.Size = new System.Drawing.Size(904, 160);
			this.gridProductos.TabIndex = 3;
			this.gridProductos.TabStop = false;
			// 
			// uneTotal1
			// 
			appearance1.BackColor = System.Drawing.Color.Transparent;
			this.uneTotal1.Appearance = appearance1;
			this.uneTotal1.BorderStyle = Infragistics.Win.UIElementBorderStyle.None;
			this.uneTotal1.Enabled = false;
			this.uneTotal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.uneTotal1.Location = new System.Drawing.Point(784, 200);
			this.uneTotal1.Name = "uneTotal1";
			this.uneTotal1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotal1.PromptChar = ' ';
			this.uneTotal1.ReadOnly = true;
			this.uneTotal1.Size = new System.Drawing.Size(112, 27);
			this.uneTotal1.TabIndex = 5;
			this.uneTotal1.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			this.uneTotal1.TabStop = false;
			// 
			// bDetallesProducto
			// 
			this.bDetallesProducto.Enabled = false;
			this.bDetallesProducto.Location = new System.Drawing.Point(92, 0);
			this.bDetallesProducto.Name = "bDetallesProducto";
			this.bDetallesProducto.Size = new System.Drawing.Size(88, 23);
			this.bDetallesProducto.TabIndex = 1;
			this.bDetallesProducto.Text = "&Detalles";
			// 
			// bAgregarProducto
			// 
			this.bAgregarProducto.Location = new System.Drawing.Point(1, 0);
			this.bAgregarProducto.Name = "bAgregarProducto";
			this.bAgregarProducto.Size = new System.Drawing.Size(88, 23);
			this.bAgregarProducto.TabIndex = 0;
			this.bAgregarProducto.Text = "&Agregar";
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.htmlRichTextBoxObservaciones);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.uneCampoAuxiliar4);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.lblObservaciones);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.txtCampoAuxiliar3);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.txtCampoAuxiliar2);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.lblCampoAuxiliar2);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.lblCampoAuxiliar4);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.lblCampoAuxiliar3);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 423);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(910, 204);
			this.ultraExplorerBarContainerControl3.TabIndex = 3;
			this.ultraExplorerBarContainerControl3.Visible = false;
			// 
			// htmlRichTextBoxObservaciones
			// 
			this.htmlRichTextBoxObservaciones.Location = new System.Drawing.Point(128, 8);
			this.htmlRichTextBoxObservaciones.Name = "htmlRichTextBoxObservaciones";
			this.htmlRichTextBoxObservaciones.Size = new System.Drawing.Size(736, 120);
			this.htmlRichTextBoxObservaciones.TabIndex = 0;
			this.htmlRichTextBoxObservaciones.Text = "";
			// 
			// uneCampoAuxiliar4
			// 
			this.uneCampoAuxiliar4.Location = new System.Drawing.Point(128, 176);
			this.uneCampoAuxiliar4.MinValue = 0;
			this.uneCampoAuxiliar4.Name = "uneCampoAuxiliar4";
			this.uneCampoAuxiliar4.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneCampoAuxiliar4.Size = new System.Drawing.Size(100, 21);
			this.uneCampoAuxiliar4.TabIndex = 3;
			this.uneCampoAuxiliar4.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			this.uneCampoAuxiliar4.ValueChanged += new System.EventHandler(this.uneCampoAuxiliar4_ValueChanged);
			// 
			// lblObservaciones
			// 
			this.lblObservaciones.BackColor = System.Drawing.Color.Transparent;
			this.lblObservaciones.Location = new System.Drawing.Point(8, 6);
			this.lblObservaciones.Name = "lblObservaciones";
			this.lblObservaciones.Size = new System.Drawing.Size(112, 16);
			this.lblObservaciones.TabIndex = 21;
			this.lblObservaciones.Text = "Observaciones";
			// 
			// txtCampoAuxiliar3
			// 
			this.txtCampoAuxiliar3.Location = new System.Drawing.Point(128, 152);
			this.txtCampoAuxiliar3.Name = "txtCampoAuxiliar3";
			this.txtCampoAuxiliar3.Size = new System.Drawing.Size(288, 20);
			this.txtCampoAuxiliar3.TabIndex = 2;
			this.txtCampoAuxiliar3.Text = "";
			// 
			// txtCampoAuxiliar2
			// 
			this.txtCampoAuxiliar2.Location = new System.Drawing.Point(128, 128);
			this.txtCampoAuxiliar2.Name = "txtCampoAuxiliar2";
			this.txtCampoAuxiliar2.Size = new System.Drawing.Size(288, 20);
			this.txtCampoAuxiliar2.TabIndex = 1;
			this.txtCampoAuxiliar2.Text = "";
			// 
			// lblCampoAuxiliar2
			// 
			this.lblCampoAuxiliar2.BackColor = System.Drawing.Color.Transparent;
			this.lblCampoAuxiliar2.Location = new System.Drawing.Point(6, 136);
			this.lblCampoAuxiliar2.Name = "lblCampoAuxiliar2";
			this.lblCampoAuxiliar2.Size = new System.Drawing.Size(112, 16);
			this.lblCampoAuxiliar2.TabIndex = 16;
			this.lblCampoAuxiliar2.Text = "Campo Auxiliar 2";
			// 
			// lblCampoAuxiliar4
			// 
			this.lblCampoAuxiliar4.BackColor = System.Drawing.Color.Transparent;
			this.lblCampoAuxiliar4.Location = new System.Drawing.Point(6, 184);
			this.lblCampoAuxiliar4.Name = "lblCampoAuxiliar4";
			this.lblCampoAuxiliar4.Size = new System.Drawing.Size(112, 16);
			this.lblCampoAuxiliar4.TabIndex = 15;
			this.lblCampoAuxiliar4.Text = "Campo Auxiliar 4";
			// 
			// lblCampoAuxiliar3
			// 
			this.lblCampoAuxiliar3.BackColor = System.Drawing.Color.Transparent;
			this.lblCampoAuxiliar3.Location = new System.Drawing.Point(6, 160);
			this.lblCampoAuxiliar3.Name = "lblCampoAuxiliar3";
			this.lblCampoAuxiliar3.Size = new System.Drawing.Size(112, 16);
			this.lblCampoAuxiliar3.TabIndex = 14;
			this.lblCampoAuxiliar3.Text = "Campo Auxiliar 3";
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.ultraExplorerBar);
			this.panel1.Controls.Add(this.toolBarStandar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(976, 542);
			this.panel1.TabIndex = 0;
			// 
			// ultraExplorerBar
			// 
			this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar.Controls.Add(this.containerItems);
			this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 24;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 128;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Datos de Cabecera";
			ultraExplorerBarGroup3.Container = this.containerItems;
			ultraExplorerBarGroup3.Settings.ContainerHeight = 269;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Detalle de Productos";
			ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup4.Settings.ContainerHeight = 204;
			ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup4.Text = "Información adicional";
			this.ultraExplorerBar.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																													   ultraExplorerBarGroup1,
																													   ultraExplorerBarGroup2,
																													   ultraExplorerBarGroup3,
																													   ultraExplorerBarGroup4});
			this.ultraExplorerBar.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar.Name = "ultraExplorerBar"; this.ultraExplorerBar.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar.Size = new System.Drawing.Size(976, 514);
			this.ultraExplorerBar.TabIndex = 23;
			this.ultraExplorerBar.TabStop = false;
			this.ultraExplorerBar.ItemClick += new Infragistics.Win.UltraWinExplorerBar.ItemClickEventHandler(this.ultraExplorerBar_ItemClick);
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.tbbAnterior,
																							  this.tbbSeparator,
																							  this.tbbSiguiente,
																							  this.tbbSeparator2,
																							  this.tbbCancelar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(976, 28);
			this.toolBarStandar.TabIndex = 22;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
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
			// tbbCancelar
			// 
			this.tbbCancelar.ImageIndex = 7;
			this.tbbCancelar.Text = "Cancelar";
			// 
			// FrmComprobantesDeCompra
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(976, 542);
			this.Controls.Add(this.panel1);
			this.Name = "FrmComprobantesDeCompra";
			this.Text = "Comprobantes de Compra";
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCECondicionDeCompra)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cldFechaRegistracion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uccFechaRecepcionMercaderia)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneDiasDemoraEntrega)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCETipoComprobante)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneValorCotizacion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCETiposDeCambio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMonedas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEResponsableEmision)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cldFechaComprobante)).EndInit();
			this.containerItems.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotal1)).EndInit();
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uneCampoAuxiliar4)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar)).EndInit();
			this.ultraExplorerBar.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Variables Privadas		
		private controllers.ComprobantesDeCompraController _uiController = null;		
		#endregion

		#region Variables Publicas
		#endregion

		#region Constructores y Destructores
		public FrmComprobantesDeCompra()
		{
			InitializeComponent();
			_uiController = new mz.erp.ui.controllers.ComprobantesDeCompraController();
		}

		public FrmComprobantesDeCompra( controllers.ComprobantesDeCompraController controller )
		{			
			InitializeComponent();
			_uiController = controller;			
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
				
				cldFechaComprobante.DataBindings.Clear();
				cldFechaRegistracion.DataBindings.Clear();
				ultraMENumero.DataBindings.Clear();
				ultraMECampoAuxiliar1.DataBindings.Clear();
				BindingController.Clear(mzCETiposDeCambio,"Value", _uiController, "IdFuenteDeCambioProveedor");
				BindingController.Clear(mzCEMonedas,"Value", _uiController, "IdMonedaOrigen");
				//BindingController.Clear(uneValorCotizacion, "Value", _uiController, "ValorCotizacionProveedor");
				uneValorCotizacion.DataBindings.Clear();
				BindingController.Clear(mzCETipoComprobante,"Value",_uiController,"KeyValueTiposDeComprobantes");
				mzCmb.DataBindings.Clear();
				BindingController.Clear(htmlRichTextBoxObservaciones,"Text", _uiController, "Observaciones" );
				BindingController.Clear(ultraMECampoAuxiliar1,"Text", _uiController, "CampoAuxiliar1" );	
				BindingController.Clear(txtCampoAuxiliar2,"Text", _uiController, "CampoAuxiliar2" );	
				BindingController.Clear(txtCampoAuxiliar3,"Text", _uiController, "CampoAuxiliar3" );
				BindingController.Clear(mzCECondicionDeCompra,"Value", _uiController, "IdCondicionDeCompra");
				mzCEResponsableEmision.DataBindings.Clear();
				uneCampoAuxiliar4.DataBindings.Clear();
				uneTotal1.DataBindings.Clear();
				gridProductos.SetDataBinding(null, null);
				uneDiasDemoraEntrega.DataBindings.Clear();
				uccFechaRecepcionMercaderia.DataBindings.Clear();
				
	

				mzCEResponsableEmision.DataBindings.Clear();
				uneCampoAuxiliar4.DataBindings.Clear();
				uneTotal1.DataBindings.Clear();
				gridProductos.SetDataBinding(null, null);
				uneDiasDemoraEntrega.DataBindings.Clear();
				uccFechaRecepcionMercaderia.DataBindings.Clear();
				
	

				//German 20090421
				
				mzCmb.ValueChanged-=new EventHandler(mzCmbProveedor_ValueChanged);
				_uiController.ItemsChanged -=new EventHandler(_uiController_ItemsChanged);

				toolBarStandar.ButtonClick-=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
				uneCampoAuxiliar4.Enter -=new EventHandler(OnEnterControl);
				_uiController.DiasDemoraEntregaChanged -=new EventHandler(_uiController_DiasDemoraEntregaChanged);
				_uiController.FechaRecepcionMercaderiaChanged -=new EventHandler(_uiController_FechaRecepcionMercaderiaChanged);
				gridProductos.DeletingRecords -=new CancelEventHandler(gridProductos_DeletingRecords);
				mzCmb.ValueChanged -=new EventHandler(mzCmbProveedor_ValueChanged);
				_uiController.AddItemsChanged -=new EventHandler(_uiController_AddItemsChanged);

				//German 20090407
				gridProductos.Error -=new Janus.Windows.GridEX.ErrorEventHandler(gridProductos_Error);
				gridProductos.UpdatingCell -=new Janus.Windows.GridEX.UpdatingCellEventHandler(gridProductos_UpdatingCell);
				gridProductos.CellUpdated -=new Janus.Windows.GridEX.ColumnActionEventHandler(gridProductos_CellUpdated);
				gridProductos.CellEdited -=new Janus.Windows.GridEX.ColumnActionEventHandler(gridProductos_CellEdited);
				gridProductos.EditingCell -=new Janus.Windows.GridEX.EditingCellEventHandler(gridProductos_EditingCell);
			
		
				//Fin German 20090421
	
				//uneValorCotizacion.DataBindings.Clear();
			}
			base.Dispose( disposing );
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
				base.Show();
				_uiController.RefreshData();

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
			SaveChanges();
		}

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
			labelTarea.Text = _uiController.LeyendaFormulario;
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			mzCmb.Enabled = _uiController.AllowEditProveedor;
			mzCmb.Init();
			mzCmb.SearchObjectListener = this;
			mzCmb.EnableCtaCte = _uiController.EnabledButtonCuentaCtaCte;
			mzCETipoComprobante.Enabled = _uiController.AllowEditTipoDeComprobante;
			bAgregarProducto.Enabled = false;
			bDetallesProducto.Enabled = false;	
			mzProductosControl.Enabled = _uiController.AllowAddItems;
			mzProductosControl.SetProcess(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), "C");
			mzProductosControl.SetIdProveedor(_uiController.IdProveedor);
			if(_uiController.AllowDeleteItems)
			{
				gridProductos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			}
			else
			{
				gridProductos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
			}
			
			gridProductos.GroupByBoxVisible = false;

			//Visible
			uneTotal1.Visible = false;
						

			//Mask
			ultraMENumero.Enabled = _uiController.AllowEditNumeration;
			ultraMENumero.InputMask = _uiController.MascaraCampoAuxiliar1;

			//Text
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;
			lblCampoAuxiliar1.Text = _uiController.TextoCampoAuxiliar1;			
			lblCampoAuxiliar2.Text = _uiController.TextoCampoAuxiliar2;			
			lblCampoAuxiliar3.Text = _uiController.TextoCampoAuxiliar3;			
			lblCampoAuxiliar4.Text = _uiController.TextoCampoAuxiliar4;			
			ultraMENumero.Text = "X--";			

			//Otros
			mzProductosControl.EnabledCantidad = true;

			//mzProductosControl.Enabled = _uiController.AllowEditItems;
	
			mzCEResponsableEmision.Enabled = _uiController.AllowEditResponsableEmision;
			cldFechaComprobante.Enabled = _uiController.AllowEditFecha;
			cldFechaRegistracion.Enabled = _uiController.AllowEditFechaRegistracion;
			gridProductos.SelectionMode = Janus.Windows.GridEX.SelectionMode.SingleSelection;
			//uneValorCotizacion.ReadOnly = true;

			mzCEMonedas.Enabled = _uiController.AllowEditMonedaOrigen;
			mzCETiposDeCambio.Enabled = _uiController.AllowEditFuenteDeCambio;
			uneValorCotizacion.Enabled = _uiController.AllowEditValorCotizacion;

			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), this.Name, gridProductos, this.Text);			
			mzProductosControl.EnabledListaDePrecio = false;

			uneDiasDemoraEntrega.Enabled = _uiController.AllowEditDiasDemoraEntrega;
			uccFechaRecepcionMercaderia.Enabled = _uiController.AllowEditFechaRecepcionMercaderia;
			mzCECondicionDeCompra.Enabled  = _uiController.AllowEditCondicionDeCompra;
			htmlRichTextBoxObservaciones.MaxLength = 1000;


			//German 20090407
			//gridProductos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			gridProductos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextRow;
			//Fin German 20090407

			KeyPreview = true;

		}



		private void InitializeData()
		{						
			
			mzCETipoComprobante.FillFromDataSource(_uiController.TiposDeComprobantesSearchObject,_uiController.TiposDeComprobantesValueMember,_uiController.TiposDeComprobantesDisplayMember,100,_uiController.TiposDeComprobantesDisplayMember);
			mzProductosControl.AddObjectListener((IObserver)_uiController);
			//gridProductos.LayoutData = _uiController.LayoutDetalle;
			ConfigureGrid();
			mzCEResponsableEmision.FillFromDataSource(_uiController.ResponsableDataTable, _uiController.ResponsableValueMember,_uiController.ResponsableDisplayMember,8,_uiController.ResponsableDisplayMember);
			mzCEMonedas.FillFromDataSource(_uiController.TableMonedas, "IdMoneda", "Descripcion", 8,null);
			mzCETiposDeCambio.FillFromDataSource(_uiController.TableFuentesDeCambio, "IdFuenteDeCambio", "Descripcion", 8,null);
			mzCECondicionDeCompra.FillFromDataSource(mz.erp.businessrules.tpu_CondicionesDeCompras.GetList().tpu_CondicionesDeCompras, "IdCondicionDeCompra", "Descripcion", 16, "Orden");
			//uneValorCotizacion.Value = 1;
			mzCmb.DataValue = _uiController.KeyValueProveedores;

		}
		private void InitEventHandlers()
		{			
			/*
			ultraMENumero.TextChanged+=new EventHandler(this.ListenerControllerChanged);
			mzCmbProveedor.ValueChanged+=new EventHandler(this.ListenerControllerChanged);
			mzCETipoComprobante.ValueChanged+=new EventHandler(this.ListenerControllerChanged);
			mzCEResponsableEmision.ValueChanged+=new EventHandler(this.ListenerControllerChanged);
			cldFechaComprobante.ValueChanged+=new EventHandler(this.ListenerControllerChanged);
			cldFechaRegistracion.ValueChanged+=new EventHandler(this.ListenerControllerChanged);
			txtObservaciones.TextChanged+=new EventHandler(this.ListenerControllerChanged);
			txtCampoAuxiliar1.TextChanged+=new EventHandler(this.ListenerControllerChanged);
			txtCampoAuxiliar2.TextChanged+=new EventHandler(this.ListenerControllerChanged);
			txtCampoAuxiliar3.TextChanged+=new EventHandler(this.ListenerControllerChanged);
			txtCampoAuxiliar4.TextChanged+=new EventHandler(this.ListenerControllerChanged);
			*/

			toolBarStandar.ButtonClick+=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			_uiController.ItemsChanged +=new EventHandler(_uiController_ItemsChanged);
			uneCampoAuxiliar4.Enter +=new EventHandler(OnEnterControl);
			_uiController.DiasDemoraEntregaChanged +=new EventHandler(_uiController_DiasDemoraEntregaChanged);
			_uiController.FechaRecepcionMercaderiaChanged +=new EventHandler(_uiController_FechaRecepcionMercaderiaChanged);
			gridProductos.DeletingRecords +=new CancelEventHandler(gridProductos_DeletingRecords);
			mzCmb.ValueChanged+=new EventHandler(mzCmbProveedor_ValueChanged);

			_uiController.AddItemsChanged +=new EventHandler(_uiController_AddItemsChanged);

			//German 20090407
			gridProductos.Error +=new Janus.Windows.GridEX.ErrorEventHandler(gridProductos_Error);
			gridProductos.UpdatingCell +=new Janus.Windows.GridEX.UpdatingCellEventHandler(gridProductos_UpdatingCell);
			gridProductos.CellUpdated +=new Janus.Windows.GridEX.ColumnActionEventHandler(gridProductos_CellUpdated);
			gridProductos.CellEdited +=new Janus.Windows.GridEX.ColumnActionEventHandler(gridProductos_CellEdited);
			gridProductos.EditingCell +=new Janus.Windows.GridEX.EditingCellEventHandler(gridProductos_EditingCell);
			
			//Fin German 20090407



			//German 20090407
			gridProductos.Error +=new Janus.Windows.GridEX.ErrorEventHandler(gridProductos_Error);
			gridProductos.UpdatingCell +=new Janus.Windows.GridEX.UpdatingCellEventHandler(gridProductos_UpdatingCell);
			gridProductos.CellUpdated +=new Janus.Windows.GridEX.ColumnActionEventHandler(gridProductos_CellUpdated);
			gridProductos.CellEdited +=new Janus.Windows.GridEX.ColumnActionEventHandler(gridProductos_CellEdited);
			gridProductos.EditingCell +=new Janus.Windows.GridEX.EditingCellEventHandler(gridProductos_EditingCell);
			
			//Fin German 20090407
          
			KeyDownManager KeyDown = new KeyDownManager(this);	

		}	 

		private void _uiController_DiasDemoraEntregaChanged(object sender, EventArgs e)
		{
			uccFechaRecepcionMercaderia.Value = _uiController.FechaRecepcionMercaderia;
		}		

		private void _uiController_FechaRecepcionMercaderiaChanged(object sender, EventArgs e)
		{
			uneDiasDemoraEntrega.Value = _uiController.DiasDemoraEntrega;
		}
		

	
		private void InitDataBindings()
		{				
			//BindingController.Bind(mzCEResponsableEmision, "Value", _uiController, "ResponsableDeEmision");
			//BindingController.Bind(ultraMENumero,"Text", _uiController, "NumeroComprobante" );
			//BindingController.Bind(ultraMENumero, "Text", _uiController, "NumeroComprobante");
			//BindingController.Bind(uneValorCotizacion, "Value", _uiController, "ValorCotizacionProveedor");

			ultraMENumero.DataBindings.Add( "InputMask",_uiController , "Mascara" );
			mzCEResponsableEmision.DataBindings.Add("Value", _uiController, "ResponsableDeEmision");
			BindingController.Bind(mzCETipoComprobante,"Value",_uiController,"KeyValueTiposDeComprobantes");
			
			//German 20090421
			//mzCmb.DataBindings.Add("DataValue",_uiController,"KeyValueProveedores");
			//Fin German 20090421

			ultraMENumero.DataBindings.Add("Text", _uiController, "NumeroComprobante");			
			cldFechaComprobante.DataBindings.Add("Value", _uiController, "Fecha");
			cldFechaRegistracion.DataBindings.Add("Value", _uiController, "FechaRegistracion");
			BindingController.Bind(htmlRichTextBoxObservaciones,"Text", _uiController, "Observaciones" );
			BindingController.Bind(ultraMECampoAuxiliar1,"Text", _uiController, "CampoAuxiliar1" );	

			BindingController.Bind(txtCampoAuxiliar2,"Text", _uiController, "CampoAuxiliar2" );	
			BindingController.Bind(txtCampoAuxiliar3,"Text", _uiController, "CampoAuxiliar3" );
			uneCampoAuxiliar4.DataBindings.Add("Value", _uiController, "CampoAuxiliar4" );			
			uneTotal1.DataBindings.Add("Value", _uiController,"Total");
			gridProductos.SetDataBinding(_uiController.Items, null);
			BindingController.Bind(mzCETiposDeCambio,"Value", _uiController, "IdFuenteDeCambioProveedor");
			BindingController.Bind(mzCEMonedas,"Value", _uiController, "IdMonedaOrigen");
			uneValorCotizacion.DataBindings.Add("Value", _uiController, "ValorCotizacionProveedor");

			uneDiasDemoraEntrega.DataBindings.Add("Value", _uiController, "DiasDemoraEntrega");
			uccFechaRecepcionMercaderia.DataBindings.Add("Value", _uiController, "FechaRecepcionMercaderia");

			BindingController.Bind(mzCECondicionDeCompra,"Value", _uiController, "IdCondicionDeCompra");
	


		}


		private void ConfigureGrid()
		{
			if(_uiController.AllowEditItems)
			{
				gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
				gridProductos.RootTable.Columns["Codigo"].EditType = Janus.Windows.GridEX.EditType.NoEdit;
				gridProductos.RootTable.Columns["Descripcion"].EditType = Janus.Windows.GridEX.EditType.NoEdit;
				gridProductos.RootTable.Columns["Cantidad"].EditType = Janus.Windows.GridEX.EditType.TextBox;
				//German 20090407
				if(mz.erp.systemframework.Util.ContainsColumn(gridProductos, "PrecioDeCosto"))
					gridProductos.RootTable.Columns["PrecioDeCosto"].EditType = Janus.Windows.GridEX.EditType.TextBox;
				if(mz.erp.systemframework.Util.ContainsColumn(gridProductos, "Total"))
					gridProductos.RootTable.Columns["Total"].EditType = Janus.Windows.GridEX.EditType.NoEdit;
				//Fin German 20090407
				if(_uiController.GetProcessManager().GetProcessName().Equals("ProcesoEditarPreOrdenDeCompra"))
					gridProductos.RootTable.Columns["Estado"].EditType = Janus.Windows.GridEX.EditType.NoEdit;
			}
			else
				gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;

		}
		#region Custom Members
		
		private void ListenerControllerChanged(object sender, System.EventArgs e)
		{			
			if (((Control)sender).Name.Equals("mzCEResponsableEmision"))
			{
				if ( _uiController != null) 
				{
					mzCEResponsableEmision.Value = _uiController.ResponsableDeEmision;
				}
			}
			if (((Control)sender).Name.Equals("mzCETipoComprobante"))
			{
				if ( _uiController != null && _uiController.KeyValueTiposDeComprobantes != null) 
				{
					mzCETipoComprobante.Value = _uiController.KeyValueTiposDeComprobantes;
				}
			}
			if (((Control)sender).Name.Equals("mzCmb"))
			{
				if ( _uiController != null && _uiController.KeyValueProveedores != null) 
				{
					mzCmb.DataValue = _uiController.KeyValueProveedores;
				}
			}
			if (((Control)sender).Name.Equals("ultraMENumero"))
			{
				if ( _uiController != null && _uiController.KeyValueTiposDeComprobantes != null) 
				{
					ultraMENumero.Value = _uiController.NumeroComprobante;
				}
			}			
			if (((Control)sender).Name.Equals("cldFechaComprobante"))
			{
				if ( _uiController != null ) 
				{
					cldFechaComprobante.Value = _uiController.Fecha;
				}
			}	
			if (((Control)sender).Name.Equals("cldFechaRegistracion"))
			{
				if ( _uiController != null ) 
				{
					cldFechaRegistracion.Value = _uiController.FechaRegistracion;
				}
			}	
			if (((Control)sender).Name.Equals("htmlRichTextBoxObservaciones"))
			{
				if ( _uiController != null && _uiController.Observaciones != null) 
				{
					htmlRichTextBoxObservaciones.Text = _uiController.Observaciones;
				}
			}	
			if (((Control)sender).Name.Equals("ultraMECampoAuxiliar1"))
			{
				if ( _uiController != null && _uiController.CampoAuxiliar1 != null) 
				{
					ultraMECampoAuxiliar1.Text = _uiController.CampoAuxiliar1;
				}
			}	
			if (((Control)sender).Name.Equals("txtCampoAuxiliar2"))
			{
				if ( _uiController != null && _uiController.CampoAuxiliar2 != null) 
				{
					txtCampoAuxiliar2.Text = _uiController.CampoAuxiliar2;
				}
			}	
			if (((Control)sender).Name.Equals("txtCampoAuxiliar3"))
			{
				if ( _uiController != null && _uiController.CampoAuxiliar3 != null) 
				{
					txtCampoAuxiliar3.Text = _uiController.CampoAuxiliar3;
				}
			}
			/*
			if (((Control)sender).Name.Equals("txtCampoAuxiliar4"))
			{
				if ( _uiController != null ) 
				{
					txtCampoAuxiliar4.Text = _uiController.CampoAuxiliar4.ToString();
				}
			}
			*/	
		}

		#endregion

		#region Miembros de ISearchObjectListener

		public void processEventChange(object sender, EventArgs e)
		{
		}

		#endregion

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{			
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					_uiController.Previous();
					break;
				case 2://Guardar					
					SaveChanges();
					break;
				case 4:
					if ((MessageBox.Show(this,"Está a punto de cerrar el fomulario. Realmente desea realizar esta operación?","Atención!",System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Stop )== System.Windows.Forms.DialogResult.OK))
						Close();
					break;
			}						
		}

		private void SaveChanges()
		{			
			mz.erp.ui.utility.Util.MoveFocus(this.ultraExplorerBarContainerControl1);
			_uiController.FechaRecepcionMercaderia = Convert.ToDateTime(uccFechaRecepcionMercaderia.Value);			
			_uiController.Execute();
		}

		#endregion

		private void gridProductos_DeletingRecords(object sender, CancelEventArgs e)
		{
			if(gridProductos.SelectedItems.Count > 0)
			{
				businessrules.comprobantes.ItemComprobanteCompra itemComp =  (businessrules.comprobantes.ItemComprobanteCompra)gridProductos.SelectedItems[0].GetRow().DataRow;
				if(itemComp.Estado.Equals("NEW")|| _uiController.RemoveItemsFromGrid)
				{
					
					if (_uiController.AllowDeleteItems) 
					{
						object selectedItem = 	gridProductos.SelectedItems[0].GetRow().DataRow;
						if (_uiController.IsRemovable(selectedItem)) 
							e.Cancel = false;
						else e.Cancel = true;
					}
					else e.Cancel = true;
				}
				else
				{
					e.Cancel = true;
					_uiController.RemoveItem(itemComp);
				}
			}
		}
	

		private void _uiController_ItemsChanged(object sender, EventArgs e)
		{
			//German 20090407
			//gridProductos.SetDataBinding(null, null);
			//gridProductos.SetDataBinding(_uiController.Items, null);
			try
			{
				gridProductos.Refresh();
				gridProductos.Refetch();
			}
			catch(Exception ex)
			{
			}
			//Fin German 20090407

		}

		private void mzCmbProveedor_ValueChanged(object sender, EventArgs e)
		{
			_uiController.KeyValueProveedores = (string)mzCmb.DataValue;
            mzProductosControl.SetIdProveedor((string)_uiController.IdProveedor);		
		}

		private void OnEnterControl(object sender, EventArgs e)
		{
			if(sender.GetType().Equals(typeof(Infragistics.Win.UltraWinEditors.UltraNumericEditor)))
			{
				Infragistics.Win.UltraWinEditors.UltraNumericEditor control = (Infragistics.Win.UltraWinEditors.UltraNumericEditor) sender;
				control.SelectAll();
			}
		}

		private void ultraExplorerBar_ItemClick(object sender, Infragistics.Win.UltraWinExplorerBar.ItemEventArgs e)
		{
		
		}

		private void uneDiasDemoraEntrega_Enter(object sender, System.EventArgs e)
		{
			uneDiasDemoraEntrega.SelectAll();
		}

		private void uneValorCotizacion_Enter(object sender, System.EventArgs e)
		{
			uneValorCotizacion.SelectAll();
		}

		private void ultraMENumero_Leave(object sender, System.EventArgs e)
		{
			this.ultraMENumero.Text = _uiController.FillNumberWithZeros(ultraMENumero.Text);
		}

		private void uccFechaRecepcionMercaderia_BeforeDropDown(object sender, System.ComponentModel.CancelEventArgs e)
		{
		
		}

		private void uneValorCotizacion_ValueChanged(object sender, System.EventArgs e)
		{
		
		}

		private void mzProductosControl_Load(object sender, System.EventArgs e)
		{
		
		}

		private void uneCampoAuxiliar4_ValueChanged(object sender, System.EventArgs e)
		{
		
		}

		private void _uiController_AddItemsChanged(object sender, EventArgs e)
		{
			if((_uiController.Items.Count > 0)&& (_uiController.SeleccionaUltimo))
                gridProductos.MoveLast();
		}

		

		//German 20080407
		private void gridProductos_Error(object sender, Janus.Windows.GridEX.ErrorEventArgs e)
		{
			e.DisplayErrorMessage = false;
		}
		


		private void gridProductos_UpdatingCell(object sender, Janus.Windows.GridEX.UpdatingCellEventArgs e)
		{
			if(e.Value == null || e.Value == System.DBNull.Value)
				e.Cancel = true;
			
			/*
			 * else
			{
				if(!_uiController.AlwaysInEditMode)
				{
					object selectedItem = 	gridProductos.SelectedItems[0].GetRow().DataRow;
					int col = gridProductos.Col;
					if (col != -1)
					{
						string column = gridProductos.RootTable.Columns[col].Key;
						if (!_uiController.IsEditable(selectedItem, column)) 
						{
							e.Cancel = true;
						}
					}
					else
						e.Cancel = true;
				}
				else
					e.Cancel = false;
			}
			*/

		}

		private void gridProductos_CellUpdated(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
		{
			//gridProductos.UpdateData();
			//gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			
		}

		private void gridProductos_CellEdited(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
		{
			gridProductos.UpdateData();
			//gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			gridProductos.Col = gridProductos.RootTable.Columns["Cantidad"].Index;;
		}

		//Fin German 20080407

		private void gridProductos_EditingCell(object sender, Janus.Windows.GridEX.EditingCellEventArgs e)
		{
			if(e.Value == null || e.Value == System.DBNull.Value)
				e.Cancel = true;
			else
			{
				if(!_uiController.AlwaysInEditMode)
				{
					object selectedItem = 	gridProductos.SelectedItems[0].GetRow().DataRow;
					int col = gridProductos.Col;
					if (col != -1)
					{
						string column = gridProductos.RootTable.Columns[col].Key;
						if (!_uiController.IsEditable(selectedItem, column)) 
						{
							e.Cancel = true;
						}
					}
					else
						e.Cancel = true;
				}
				else
					e.Cancel = false;
			}
		}


//
//		private void gridProductos_UpdatingCell(object sender, Janus.Windows.GridEX.UpdatingCellEventArgs e)
//		{
//			if(e.Value == null || e.Value == System.DBNull.Value)
//				e.Cancel = true;
//			
//			/*
//			 * else
//			{
//				if(!_uiController.AlwaysInEditMode)
//				{
//					object selectedItem = 	gridProductos.SelectedItems[0].GetRow().DataRow;
//					int col = gridProductos.Col;
//					if (col != -1)
//					{
//						string column = gridProductos.RootTable.Columns[col].Key;
//						if (!_uiController.IsEditable(selectedItem, column)) 
//						{
//							e.Cancel = true;
//						}
//					}
//					else
//						e.Cancel = true;
//				}
//				else
//					e.Cancel = false;
//			}
//			*/
//
//		}
//
//		private void gridProductos_CellUpdated(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
//		{
//			//gridProductos.UpdateData();
//			//gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
//			
//		}
//
//		private void gridProductos_CellEdited(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
//		{
//			gridProductos.UpdateData();
//			//gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
//		}
//
//		//Fin German 20080407
//
//		private void gridProductos_EditingCell(object sender, Janus.Windows.GridEX.EditingCellEventArgs e)
//		{
//			if(e.Value == null || e.Value == System.DBNull.Value)
//				e.Cancel = true;
//			else
//			{
//				if(!_uiController.AlwaysInEditMode)
//				{
//					object selectedItem = 	gridProductos.SelectedItems[0].GetRow().DataRow;
//					int col = gridProductos.Col;
//					if (col != -1)
//					{
//						string column = gridProductos.RootTable.Columns[col].Key;
//						if (!_uiController.IsEditable(selectedItem, column)) 
//						{
//							e.Cancel = true;
//						}
//					}
//					else
//						e.Cancel = true;
//				}
//				else
//					e.Cancel = false;
//			}
//		}
//



//		private void gridProductos_UpdatingCell(object sender, Janus.Windows.GridEX.UpdatingCellEventArgs e)
//		{
//			if(e.Value == null || e.Value == System.DBNull.Value)
//				e.Cancel = true;
//			
//			/*
//			 * else
//			{
//				if(!_uiController.AlwaysInEditMode)
//				{
//					object selectedItem = 	gridProductos.SelectedItems[0].GetRow().DataRow;
//					int col = gridProductos.Col;
//					if (col != -1)
//					{
//						string column = gridProductos.RootTable.Columns[col].Key;
//						if (!_uiController.IsEditable(selectedItem, column)) 
//						{
//							e.Cancel = true;
//						}
//					}
//					else
//						e.Cancel = true;
//				}
//				else
//					e.Cancel = false;
//			}
//			*/
//
//		}
//
//		private void gridProductos_CellUpdated(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
//		{
//			//gridProductos.UpdateData();
//			//gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
//			
//		}
//
//		private void gridProductos_CellEdited(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
//		{
//			gridProductos.UpdateData();
//			//gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
//		}
//
//		//Fin German 20080407
//
//		private void gridProductos_EditingCell(object sender, Janus.Windows.GridEX.EditingCellEventArgs e)
//		{
//			if(e.Value == null || e.Value == System.DBNull.Value)
//				e.Cancel = true;
//			else
//			{
//				if(!_uiController.AlwaysInEditMode)
//				{
//					object selectedItem = 	gridProductos.SelectedItems[0].GetRow().DataRow;
//					int col = gridProductos.Col;
//					if (col != -1)
//					{
//						string column = gridProductos.RootTable.Columns[col].Key;
//						if (!_uiController.IsEditable(selectedItem, column)) 
//						{
//							e.Cancel = true;
//						}
//					}
//					else
//						e.Cancel = true;
//				}
//				else
//					e.Cancel = false;
//			}
//		}

	}
}

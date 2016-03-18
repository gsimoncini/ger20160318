using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.businessrules.comprobantes;
using mz.erp.businessrules;
using mz.erp.ui.controls;
using mz.erp.ui.controllers;
using mz.erp.systemframework;
using mz.erp.commontypes;
using Infragistics.Win.UltraWinExplorerBar;
using mz.erp.ui.forms.classes;
using mz.erp.ui.controllers;


namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de TestFactura.
	/// </summary>
	public class FrmComprobantes : System.Windows.Forms.Form , ISearchObjectListener
	{


		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.ToolBarButton tbStep3;
		private System.Windows.Forms.ImageList imglStandar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel5;
		private Infragistics.Win.Misc.UltraLabel ultraLabel3;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel6;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbCuenta;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbCondicionDeVenta;
		private Infragistics.Win.Misc.UltraButton bDetallesProducto;
		private Infragistics.Win.Misc.UltraButton bAgregarProducto;
		private Janus.Windows.GridEX.GridEX gridProductos;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private System.Windows.Forms.Label label8;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo cldFechaComprobante;
		private Janus.Windows.GridEX.GridEX gridVariablesUsuario;
		private System.Windows.Forms.Label label9;
		private Janus.Windows.GridEX.GridEX gridDetalleCondicionDeVenta;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotal1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel2;
		private mz.erp.ui.controls.mzComboEditor mzCmbTipoComprobante;
		private System.Windows.Forms.ToolBarButton toolBarButton9;
		private System.Windows.Forms.ToolBarButton tbbImprimir;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl containerItems;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl containerFormasDePago;
		private System.ComponentModel.IContainer components;
		private string _momento;
		private Infragistics.Win.Misc.UltraButton ubEliminar;
		private Infragistics.Win.Misc.UltraButton ubAgregar;
		private System.Windows.Forms.Label label1;
		private Janus.Windows.GridEX.GridEX gridEXValores;
		private mz.erp.ui.controls.mzComboEditor mzCEResponsableEmision;
		private System.Windows.Forms.ToolBarButton tbCerrar;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit txtNumero;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Janus.Windows.GridEX.GridEX gridResumenImpuestos;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneRecargosFinancieros;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalDescuentos;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalBruto;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotal;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalImpuestos;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalNeto;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ToolBarButton tbGuardar;
		private mzProductosControl mzProductosControl1;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneBonRecCuenta;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneBonRecProducto;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalValores;

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmComprobantes));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.txtNumero = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
			this.mzCEResponsableEmision = new mz.erp.ui.controls.mzComboEditor();
			this.mzCmbTipoComprobante = new mz.erp.ui.controls.mzComboEditor();
			this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
			this.mzCmbCondicionDeVenta = new mz.erp.ui.controls.mzComboSearchEditor();
			this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
			this.cldFechaComprobante = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.mzCmbCuenta = new mz.erp.ui.controls.mzComboSearchEditor();
			this.containerItems = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.uneTotal1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.gridProductos = new Janus.Windows.GridEX.GridEX();
			this.bDetallesProducto = new Infragistics.Win.Misc.UltraButton();
			this.bAgregarProducto = new Infragistics.Win.Misc.UltraButton();
			this.containerFormasDePago = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.ubEliminar = new Infragistics.Win.Misc.UltraButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.ubAgregar = new Infragistics.Win.Misc.UltraButton();
			this.label1 = new System.Windows.Forms.Label();
			this.gridEXValores = new Janus.Windows.GridEX.GridEX();
			this.uneTotalValores = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.uneBonRecCuenta = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label3 = new System.Windows.Forms.Label();
			this.uneBonRecProducto = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label2 = new System.Windows.Forms.Label();
			this.gridResumenImpuestos = new Janus.Windows.GridEX.GridEX();
			this.uneRecargosFinancieros = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.uneTotalDescuentos = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.uneTotalBruto = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.uneTotal = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.uneTotalImpuestos = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.uneTotalNeto = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridDetalleCondicionDeVenta = new Janus.Windows.GridEX.GridEX();
			this.label9 = new System.Windows.Forms.Label();
			this.gridVariablesUsuario = new Janus.Windows.GridEX.GridEX();
			this.label8 = new System.Windows.Forms.Label();
			this.mzProductosControl1 = new mz.erp.ui.controls.mzProductosControl();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.tbGuardar = new System.Windows.Forms.ToolBarButton();
			this.tbStep3 = new System.Windows.Forms.ToolBarButton();
			this.tbbImprimir = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.tbCerrar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCEResponsableEmision)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTipoComprobante)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cldFechaComprobante)).BeginInit();
			this.containerItems.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uneTotal1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
			this.containerFormasDePago.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridEXValores)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalValores)).BeginInit();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uneBonRecCuenta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneBonRecProducto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridResumenImpuestos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneRecargosFinancieros)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalDescuentos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalBruto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalImpuestos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalNeto)).BeginInit();
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDetalleCondicionDeVenta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridVariablesUsuario)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar)).BeginInit();
			this.ultraExplorerBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtNumero);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEResponsableEmision);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbTipoComprobante);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel4);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbCondicionDeVenta);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel6);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel5);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.cldFechaComprobante);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbCuenta);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 49);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(758, 64);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// txtNumero
			// 
			this.txtNumero.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
			this.txtNumero.InputMask = "\\A-####-########";
			this.txtNumero.Location = new System.Drawing.Point(576, 40);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.TabIndex = 5;
			this.txtNumero.Text = "A--";
			// 
			// mzCEResponsableEmision
			// 
			this.mzCEResponsableEmision.AutoComplete = true;
			this.mzCEResponsableEmision.DataSource = null;
			this.mzCEResponsableEmision.DisplayMember = "";
			this.mzCEResponsableEmision.DisplayMemberCaption = "";
			this.mzCEResponsableEmision.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEResponsableEmision.Location = new System.Drawing.Point(120, -2);
			this.mzCEResponsableEmision.MaxItemsDisplay = 7;
			this.mzCEResponsableEmision.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEResponsableEmision.Name = "mzCEResponsableEmision";
			this.mzCEResponsableEmision.Size = new System.Drawing.Size(167, 21);
			this.mzCEResponsableEmision.SorterMember = "";
			this.mzCEResponsableEmision.TabIndex = 0;
			this.mzCEResponsableEmision.ValueMember = "";
			this.mzCEResponsableEmision.ValueMemberCaption = "";
			// 
			// mzCmbTipoComprobante
			// 
			this.mzCmbTipoComprobante.AutoComplete = true;
			this.mzCmbTipoComprobante.DataSource = null;
			this.mzCmbTipoComprobante.DisplayMember = "";
			this.mzCmbTipoComprobante.DisplayMemberCaption = "";
			this.mzCmbTipoComprobante.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbTipoComprobante.Location = new System.Drawing.Point(576, 0);
			this.mzCmbTipoComprobante.MaxItemsDisplay = 7;
			this.mzCmbTipoComprobante.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbTipoComprobante.Name = "mzCmbTipoComprobante";
			this.mzCmbTipoComprobante.Size = new System.Drawing.Size(167, 21);
			this.mzCmbTipoComprobante.SorterMember = "";
			this.mzCmbTipoComprobante.TabIndex = 3;
			this.mzCmbTipoComprobante.ValueMember = "";
			this.mzCmbTipoComprobante.ValueMemberCaption = "";
			// 
			// ultraLabel2
			// 
			appearance1.TextHAlign = Infragistics.Win.HAlign.Right;
			this.ultraLabel2.Appearance = appearance1;
			this.ultraLabel2.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel2.Location = new System.Drawing.Point(456, 3);
			this.ultraLabel2.Name = "ultraLabel2";
			this.ultraLabel2.Size = new System.Drawing.Size(116, 16);
			this.ultraLabel2.TabIndex = 20;
			this.ultraLabel2.Text = "Tipo de Comprobante";
			// 
			// ultraLabel4
			// 
			appearance2.TextHAlign = Infragistics.Win.HAlign.Right;
			this.ultraLabel4.Appearance = appearance2;
			this.ultraLabel4.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel4.Location = new System.Drawing.Point(7, 42);
			this.ultraLabel4.Name = "ultraLabel4";
			this.ultraLabel4.Size = new System.Drawing.Size(104, 16);
			this.ultraLabel4.TabIndex = 18;
			this.ultraLabel4.Text = "Condición de Venta";
			// 
			// mzCmbCondicionDeVenta
			// 
			this.mzCmbCondicionDeVenta.DataValue = "";
			this.mzCmbCondicionDeVenta.EditObject = null;
			this.mzCmbCondicionDeVenta.FastSearch = false;
			this.mzCmbCondicionDeVenta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbCondicionDeVenta.HierarchicalSearch = false;
			this.mzCmbCondicionDeVenta.Location = new System.Drawing.Point(120, 41);
			this.mzCmbCondicionDeVenta.Name = "mzCmbCondicionDeVenta";
			this.mzCmbCondicionDeVenta.ReadOnly = false;
			this.mzCmbCondicionDeVenta.SearchObject = null;
			this.mzCmbCondicionDeVenta.SearchObjectListener = null;
			this.mzCmbCondicionDeVenta.Size = new System.Drawing.Size(384, 22);
			this.mzCmbCondicionDeVenta.TabIndex = 2;
			// 
			// ultraLabel6
			// 
			appearance3.TextHAlign = Infragistics.Win.HAlign.Right;
			this.ultraLabel6.Appearance = appearance3;
			this.ultraLabel6.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel6.Location = new System.Drawing.Point(-3, 2);
			this.ultraLabel6.Name = "ultraLabel6";
			this.ultraLabel6.Size = new System.Drawing.Size(120, 20);
			this.ultraLabel6.TabIndex = 15;
			this.ultraLabel6.Text = "Responsable Emisión";
			// 
			// ultraLabel1
			// 
			appearance4.TextHAlign = Infragistics.Win.HAlign.Right;
			this.ultraLabel1.Appearance = appearance4;
			this.ultraLabel1.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel1.Location = new System.Drawing.Point(48, 22);
			this.ultraLabel1.Name = "ultraLabel1";
			this.ultraLabel1.Size = new System.Drawing.Size(62, 16);
			this.ultraLabel1.TabIndex = 13;
			this.ultraLabel1.Text = "Cuenta";
			// 
			// ultraLabel3
			// 
			appearance5.TextHAlign = Infragistics.Win.HAlign.Right;
			this.ultraLabel3.Appearance = appearance5;
			this.ultraLabel3.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel3.Location = new System.Drawing.Point(508, 22);
			this.ultraLabel3.Name = "ultraLabel3";
			this.ultraLabel3.Size = new System.Drawing.Size(62, 11);
			this.ultraLabel3.TabIndex = 12;
			this.ultraLabel3.Text = "Fecha";
			// 
			// ultraLabel5
			// 
			appearance6.TextHAlign = Infragistics.Win.HAlign.Right;
			this.ultraLabel5.Appearance = appearance6;
			this.ultraLabel5.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel5.Location = new System.Drawing.Point(508, 40);
			this.ultraLabel5.Name = "ultraLabel5";
			this.ultraLabel5.Size = new System.Drawing.Size(62, 11);
			this.ultraLabel5.TabIndex = 10;
			this.ultraLabel5.Text = "Número";
			// 
			// cldFechaComprobante
			// 
			dateButton1.Caption = "Today";
			this.cldFechaComprobante.DateButtons.Add(dateButton1);
			this.cldFechaComprobante.Location = new System.Drawing.Point(576, 20);
			this.cldFechaComprobante.Name = "cldFechaComprobante";
			this.cldFechaComprobante.NonAutoSizeHeight = 23;
			this.cldFechaComprobante.Size = new System.Drawing.Size(109, 21);
			this.cldFechaComprobante.TabIndex = 4;
			this.cldFechaComprobante.Value = new System.DateTime(2005, 1, 28, 0, 0, 0, 0);
			// 
			// mzCmbCuenta
			// 
			this.mzCmbCuenta.DataValue = "";
			this.mzCmbCuenta.EditObject = null;
			this.mzCmbCuenta.FastSearch = false;
			this.mzCmbCuenta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbCuenta.HierarchicalSearch = false;
			this.mzCmbCuenta.Location = new System.Drawing.Point(120, 19);
			this.mzCmbCuenta.Name = "mzCmbCuenta";
			this.mzCmbCuenta.ReadOnly = false;
			this.mzCmbCuenta.SearchObject = null;
			this.mzCmbCuenta.SearchObjectListener = null;
			this.mzCmbCuenta.Size = new System.Drawing.Size(384, 22);
			this.mzCmbCuenta.TabIndex = 1;
			this.mzCmbCuenta.ValueChanged += new System.EventHandler(this.mzCmbCuenta_ValueChanged);
			// 
			// containerItems
			// 
			this.containerItems.Controls.Add(this.uneTotal1);
			this.containerItems.Controls.Add(this.gridProductos);
			this.containerItems.Controls.Add(this.bDetallesProducto);
			this.containerItems.Controls.Add(this.bAgregarProducto);
			this.containerItems.Location = new System.Drawing.Point(28, 172);
			this.containerItems.Name = "containerItems";
			this.containerItems.Size = new System.Drawing.Size(758, 262);
			this.containerItems.TabIndex = 1;
			this.containerItems.Paint += new System.Windows.Forms.PaintEventHandler(this.containerItems_Paint);
			// 
			// uneTotal1
			// 
			appearance7.BackColor = System.Drawing.Color.Transparent;
			this.uneTotal1.Appearance = appearance7;
			this.uneTotal1.BorderStyle = Infragistics.Win.UIElementBorderStyle.None;
			this.uneTotal1.Enabled = false;
			this.uneTotal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.uneTotal1.Location = new System.Drawing.Point(600, 196);
			this.uneTotal1.Name = "uneTotal1";
			this.uneTotal1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotal1.PromptChar = ' ';
			this.uneTotal1.ReadOnly = true;
			this.uneTotal1.Size = new System.Drawing.Size(136, 27);
			this.uneTotal1.TabIndex = 3;
			this.uneTotal1.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// gridProductos
			// 
			this.gridProductos.AllowCardSizing = false;
			this.gridProductos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridProductos.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridProductos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridProductos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gridProductos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridProductos.Location = new System.Drawing.Point(3, 24);
			this.gridProductos.Name = "gridProductos";
			this.gridProductos.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridProductos.Size = new System.Drawing.Size(733, 160);
			this.gridProductos.TabIndex = 2;
			this.gridProductos.TabStop = false;
			this.gridProductos.Error += new Janus.Windows.GridEX.ErrorEventHandler(this.gridProductos_Error);
			// 
			// bDetallesProducto
			// 
			this.bDetallesProducto.Enabled = false;
			this.bDetallesProducto.Location = new System.Drawing.Point(93, -1);
			this.bDetallesProducto.Name = "bDetallesProducto";
			this.bDetallesProducto.Size = new System.Drawing.Size(88, 24);
			this.bDetallesProducto.TabIndex = 1;
			this.bDetallesProducto.Text = "&Detalles";
			// 
			// bAgregarProducto
			// 
			this.bAgregarProducto.AcceptsFocus = false;
			this.bAgregarProducto.Location = new System.Drawing.Point(2, -1);
			this.bAgregarProducto.Name = "bAgregarProducto";
			this.bAgregarProducto.Size = new System.Drawing.Size(88, 24);
			this.bAgregarProducto.TabIndex = 0;
			this.bAgregarProducto.TabStop = false;
			this.bAgregarProducto.Text = "&Agregar";
			this.bAgregarProducto.Click += new System.EventHandler(this.BotoneraProductos);
			// 
			// containerFormasDePago
			// 
			this.containerFormasDePago.Controls.Add(this.ubEliminar);
			this.containerFormasDePago.Controls.Add(this.ubAgregar);
			this.containerFormasDePago.Controls.Add(this.label1);
			this.containerFormasDePago.Controls.Add(this.gridEXValores);
			this.containerFormasDePago.Controls.Add(this.uneTotalValores);
			this.containerFormasDePago.Location = new System.Drawing.Point(28, 493);
			this.containerFormasDePago.Name = "containerFormasDePago";
			this.containerFormasDePago.Size = new System.Drawing.Size(758, 226);
			this.containerFormasDePago.TabIndex = 2;
			// 
			// ubEliminar
			// 
			this.ubEliminar.AcceptsFocus = false;
			this.ubEliminar.ImageList = this.imglStandar;
			this.ubEliminar.Location = new System.Drawing.Point(111, 2);
			this.ubEliminar.Name = "ubEliminar";
			this.ubEliminar.Size = new System.Drawing.Size(96, 24);
			this.ubEliminar.TabIndex = 1;
			this.ubEliminar.TabStop = false;
			this.ubEliminar.Text = "Eliminar Pago";
			this.ubEliminar.Click += new System.EventHandler(this.ubEliminar_Click);
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// ubAgregar
			// 
			this.ubAgregar.AcceptsFocus = false;
			this.ubAgregar.ImageList = this.imglStandar;
			this.ubAgregar.Location = new System.Drawing.Point(7, 2);
			this.ubAgregar.Name = "ubAgregar";
			this.ubAgregar.Size = new System.Drawing.Size(96, 24);
			this.ubAgregar.TabIndex = 0;
			this.ubAgregar.TabStop = false;
			this.ubAgregar.Text = "Agregar &Pago";
			this.ubAgregar.Click += new System.EventHandler(this.ubAgregar_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(405, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 12);
			this.label1.TabIndex = 36;
			this.label1.Text = "Total";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gridEXValores
			// 
			this.gridEXValores.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridEXValores.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridEXValores.ContinuousScroll = false;
			this.gridEXValores.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEXValores.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEXValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gridEXValores.GroupByBoxVisible = false;
			this.gridEXValores.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridEXValores.Location = new System.Drawing.Point(7, 34);
			this.gridEXValores.Name = "gridEXValores";
			this.gridEXValores.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridEXValores.Size = new System.Drawing.Size(652, 160);
			this.gridEXValores.TabIndex = 3;
			// 
			// uneTotalValores
			// 
			this.uneTotalValores.Location = new System.Drawing.Point(537, 5);
			this.uneTotalValores.Name = "uneTotalValores";
			this.uneTotalValores.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotalValores.Size = new System.Drawing.Size(120, 21);
			this.uneTotalValores.TabIndex = 2;
			this.uneTotalValores.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.uneBonRecCuenta);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.uneBonRecProducto);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridResumenImpuestos);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.uneRecargosFinancieros);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.uneTotalDescuentos);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.uneTotalBruto);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.uneTotal);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.uneTotalImpuestos);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.uneTotalNeto);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label12);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label13);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label14);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label15);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label16);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label17);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label18);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 438);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(758, 149);
			this.ultraExplorerBarContainerControl2.TabIndex = 5;
			this.ultraExplorerBarContainerControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.ultraExplorerBarContainerControl2_Paint);
			// 
			// uneBonRecCuenta
			// 
			this.uneBonRecCuenta.Location = new System.Drawing.Point(400, 92);
			this.uneBonRecCuenta.Name = "uneBonRecCuenta";
			this.uneBonRecCuenta.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneBonRecCuenta.PromptChar = ' ';
			this.uneBonRecCuenta.ReadOnly = true;
			this.uneBonRecCuenta.Size = new System.Drawing.Size(100, 21);
			this.uneBonRecCuenta.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(288, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(144, 16);
			this.label3.TabIndex = 47;
			this.label3.Text = "Bon/Rec. Cuenta";
			// 
			// uneBonRecProducto
			// 
			this.uneBonRecProducto.Location = new System.Drawing.Point(400, 67);
			this.uneBonRecProducto.Name = "uneBonRecProducto";
			this.uneBonRecProducto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneBonRecProducto.PromptChar = ' ';
			this.uneBonRecProducto.ReadOnly = true;
			this.uneBonRecProducto.Size = new System.Drawing.Size(100, 21);
			this.uneBonRecProducto.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(288, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 16);
			this.label2.TabIndex = 45;
			this.label2.Text = "Bon/Rec. Producto";
			// 
			// gridResumenImpuestos
			// 
			this.gridResumenImpuestos.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridResumenImpuestos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridResumenImpuestos.Location = new System.Drawing.Point(5, 20);
			this.gridResumenImpuestos.Name = "gridResumenImpuestos";
			this.gridResumenImpuestos.Size = new System.Drawing.Size(275, 120);
			this.gridResumenImpuestos.TabIndex = 0;
			// 
			// uneRecargosFinancieros
			// 
			this.uneRecargosFinancieros.Location = new System.Drawing.Point(400, 43);
			this.uneRecargosFinancieros.Name = "uneRecargosFinancieros";
			this.uneRecargosFinancieros.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneRecargosFinancieros.PromptChar = ' ';
			this.uneRecargosFinancieros.ReadOnly = true;
			this.uneRecargosFinancieros.Size = new System.Drawing.Size(100, 21);
			this.uneRecargosFinancieros.TabIndex = 2;
			// 
			// uneTotalDescuentos
			// 
			this.uneTotalDescuentos.Location = new System.Drawing.Point(400, 118);
			this.uneTotalDescuentos.Name = "uneTotalDescuentos";
			this.uneTotalDescuentos.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotalDescuentos.PromptChar = ' ';
			this.uneTotalDescuentos.ReadOnly = true;
			this.uneTotalDescuentos.Size = new System.Drawing.Size(100, 21);
			this.uneTotalDescuentos.TabIndex = 5;
			// 
			// uneTotalBruto
			// 
			this.uneTotalBruto.Location = new System.Drawing.Point(400, 19);
			this.uneTotalBruto.Name = "uneTotalBruto";
			this.uneTotalBruto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotalBruto.PromptChar = ' ';
			this.uneTotalBruto.ReadOnly = true;
			this.uneTotalBruto.Size = new System.Drawing.Size(100, 21);
			this.uneTotalBruto.TabIndex = 1;
			// 
			// uneTotal
			// 
			this.uneTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.uneTotal.Location = new System.Drawing.Point(616, 67);
			this.uneTotal.Name = "uneTotal";
			this.uneTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotal.PromptChar = ' ';
			this.uneTotal.ReadOnly = true;
			this.uneTotal.Size = new System.Drawing.Size(100, 24);
			this.uneTotal.TabIndex = 8;
			// 
			// uneTotalImpuestos
			// 
			this.uneTotalImpuestos.Location = new System.Drawing.Point(616, 42);
			this.uneTotalImpuestos.Name = "uneTotalImpuestos";
			this.uneTotalImpuestos.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotalImpuestos.PromptChar = ' ';
			this.uneTotalImpuestos.ReadOnly = true;
			this.uneTotalImpuestos.Size = new System.Drawing.Size(100, 21);
			this.uneTotalImpuestos.TabIndex = 7;
			// 
			// uneTotalNeto
			// 
			this.uneTotalNeto.Location = new System.Drawing.Point(616, 18);
			this.uneTotalNeto.Name = "uneTotalNeto";
			this.uneTotalNeto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotalNeto.PromptChar = ' ';
			this.uneTotalNeto.ReadOnly = true;
			this.uneTotalNeto.Size = new System.Drawing.Size(100, 21);
			this.uneTotalNeto.TabIndex = 6;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Location = new System.Drawing.Point(288, 47);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(144, 16);
			this.label12.TabIndex = 37;
			this.label12.Text = "Bon/Rec Financieros";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Location = new System.Drawing.Point(288, 119);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(136, 16);
			this.label13.TabIndex = 36;
			this.label13.Text = "Total Bon./Rec.";
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Location = new System.Drawing.Point(288, 23);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(136, 16);
			this.label14.TabIndex = 35;
			this.label14.Text = "Subtotal";
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Location = new System.Drawing.Point(528, 73);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(75, 16);
			this.label15.TabIndex = 34;
			this.label15.Text = "Total";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Location = new System.Drawing.Point(528, 48);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(72, 16);
			this.label16.TabIndex = 33;
			this.label16.Text = "Impuestos";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Location = new System.Drawing.Point(528, 24);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(88, 16);
			this.label17.TabIndex = 32;
			this.label17.Text = "Subtotal Neto";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Location = new System.Drawing.Point(8, 4);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(100, 16);
			this.label18.TabIndex = 31;
			this.label18.Text = "Impuestos";
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Controls.Add(this.gridDetalleCondicionDeVenta);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.label9);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.gridVariablesUsuario);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.label8);
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 459);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(758, 144);
			this.ultraExplorerBarContainerControl5.TabIndex = 4;
			// 
			// gridDetalleCondicionDeVenta
			// 
			this.gridDetalleCondicionDeVenta.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridDetalleCondicionDeVenta.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridDetalleCondicionDeVenta.Location = new System.Drawing.Point(9, 24);
			this.gridDetalleCondicionDeVenta.Name = "gridDetalleCondicionDeVenta";
			this.gridDetalleCondicionDeVenta.Size = new System.Drawing.Size(208, 104);
			this.gridDetalleCondicionDeVenta.TabIndex = 22;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(232, 7);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 16);
			this.label9.TabIndex = 21;
			this.label9.Text = "Otros datos";
			// 
			// gridVariablesUsuario
			// 
			this.gridVariablesUsuario.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell;
			this.gridVariablesUsuario.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridVariablesUsuario.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridVariablesUsuario.Location = new System.Drawing.Point(234, 26);
			this.gridVariablesUsuario.Name = "gridVariablesUsuario";
			this.gridVariablesUsuario.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridVariablesUsuario.Size = new System.Drawing.Size(526, 102);
			this.gridVariablesUsuario.TabIndex = 23;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(10, 7);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 16);
			this.label8.TabIndex = 1;
			this.label8.Text = "Vencimientos";
			// 
			// mzProductosControl1
			// 
			this.mzProductosControl1.BackColor = System.Drawing.SystemColors.Control;
			this.mzProductosControl1.EnabledCantidad = false;
			this.mzProductosControl1.EnabledListaDePrecio = true;
			this.mzProductosControl1.Location = new System.Drawing.Point(0, 0);
			this.mzProductosControl1.Name = "mzProductosControl1";
			this.mzProductosControl1.Size = new System.Drawing.Size(672, 80);
			this.mzProductosControl1.TabIndex = 0;
			this.mzProductosControl1.VisibleCantidad = true;
			this.mzProductosControl1.VisibleComboListaDePrecios = true;
			this.mzProductosControl1.VisibleComboTipoDePrecioDeCosto = false;
			this.mzProductosControl1.VisiblePrecios = true;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.toolBarButton1,
																							  this.toolBarButton2,
																							  this.toolBarButton3,
																							  this.toolBarButton4,
																							  this.toolBarButton5,
																							  this.toolBarButton6,
																							  this.toolBarButton7,
																							  this.tbGuardar,
																							  this.tbStep3,
																							  this.tbbImprimir,
																							  this.toolBarButton9,
																							  this.tbCerrar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(824, 28);
			this.toolBarStandar.TabIndex = 17;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.ImageIndex = 0;
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.ImageIndex = 1;
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.ImageIndex = 2;
			// 
			// toolBarButton4
			// 
			this.toolBarButton4.ImageIndex = 3;
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton6
			// 
			this.toolBarButton6.ImageIndex = 5;
			// 
			// toolBarButton7
			// 
			this.toolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbGuardar
			// 
			this.tbGuardar.ImageIndex = 4;
			this.tbGuardar.Text = "&Guardar";
			// 
			// tbStep3
			// 
			this.tbStep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.tbStep3.Visible = false;
			// 
			// tbbImprimir
			// 
			this.tbbImprimir.ImageIndex = 8;
			this.tbbImprimir.Text = "Imprimir";
			this.tbbImprimir.Visible = false;
			// 
			// toolBarButton9
			// 
			this.toolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbCerrar
			// 
			this.tbCerrar.ImageIndex = 7;
			this.tbCerrar.Text = "Cerrar";
			// 
			// ultraExplorerBar
			// 
			this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar.Controls.Add(this.containerItems);
			this.ultraExplorerBar.Controls.Add(this.containerFormasDePago);
			this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl5);
			this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 64;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Datos de Cabecera";
			ultraExplorerBarGroup2.Container = this.containerItems;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 262;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Detalle de Productos";
			ultraExplorerBarGroup3.Container = this.containerFormasDePago;
			ultraExplorerBarGroup3.Settings.ContainerHeight = 226;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Formas de Pago";
			ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup4.Settings.ContainerHeight = 149;
			ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup4.Text = "Totales";
			ultraExplorerBarGroup5.Container = this.ultraExplorerBarContainerControl5;
			ultraExplorerBarGroup5.Settings.ContainerHeight = 144;
			ultraExplorerBarGroup5.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup5.Text = "Información Adicional";
			this.ultraExplorerBar.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																													   ultraExplorerBarGroup1,
																													   ultraExplorerBarGroup2,
																													   ultraExplorerBarGroup3,
																													   ultraExplorerBarGroup4,
																													   ultraExplorerBarGroup5});
			this.ultraExplorerBar.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar.Name = "ultraExplorerBar"; this.ultraExplorerBar.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar.Size = new System.Drawing.Size(824, 473);
			this.ultraExplorerBar.TabIndex = 18;
			this.ultraExplorerBar.TabStop = false;
			this.ultraExplorerBar.ItemClick += new Infragistics.Win.UltraWinExplorerBar.ItemClickEventHandler(this.ultraExplorerBar_ItemClick);
			// 
			// FrmComprobantes
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(824, 501);
			this.Controls.Add(this.ultraExplorerBar);
			this.Controls.Add(this.toolBarStandar);
			this.KeyPreview = true;
			this.Name = "FrmComprobantes";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmComprobantes_KeyDown);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCEResponsableEmision)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTipoComprobante)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cldFechaComprobante)).EndInit();
			this.containerItems.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uneTotal1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
			this.containerFormasDePago.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridEXValores)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalValores)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uneBonRecCuenta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneBonRecProducto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridResumenImpuestos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneRecargosFinancieros)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalDescuentos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalBruto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalImpuestos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalNeto)).EndInit();
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridDetalleCondicionDeVenta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridVariablesUsuario)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar)).EndInit();
			this.ultraExplorerBar.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Eventos y Delegados
		public event EventHandler OnCommitComprobante;
		#endregion

		#region Variables Privadas

		private ItemComprobante _miItemComprobante ;
		private ComprobanteDeVenta miComprobante;
		private Productos _miProducto;
		private bool _save = false;
		
		private string _state;

		

		#endregion

		#region Variables Publicas

		public string State
		{
			get { return _state; }
		}

		[ IsViewFormMember ]
		public void Edit( string IdComprobante)
		{
			Init( "EDIT", IdComprobante, null, null,null);
			this.MdiParent = utility.Environment.MainForm;
			this.Show();
		}

		[ IsNextStepMember ]
		public void Step( string momento, string TipoComprobanteDestino, RelacionesComprobanteOrigenDestino relaciones)
		{						
			Init( "STEP", null, momento, TipoComprobanteDestino, relaciones);
			this.MdiParent = utility.Environment.MainForm;
			this.Show();
		}

		public void Step( string momento, RelacionesComprobanteOrigenDestino relaciones)
		{
			string TipoComprobanteDestino = null;
			Init( "STEP", null, momento, TipoComprobanteDestino, relaciones);
			this.MdiParent = utility.Environment.MainForm;
			this.Show();
		}

		#endregion

		#region Constructores y Destructores
		public FrmComprobantes()
		{
			InitializeComponent();
		}

		public FrmComprobantes(string state, string idComprobante, string momento)
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
			Init( state, idComprobante, momento, null,null);
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

		#region Inicializadores y Carga
		
			
		private void Init(string state, string idComprobante, string momento, string TipoComprobanteDestino, RelacionesComprobanteOrigenDestino relaciones)
		{			
			this._state= state;
			this._momento = momento;
			switch (state.ToUpper())
			{
				case "NEW":
					this.Text = "Nuevo Comprobante";
					miComprobante = new mz.erp.businessrules.comprobantes.ComprobanteDeVenta( "NEW", momento,null, mz.erp.businessrules.Sistema.DateTime.Now, null, null );					
					break;
				case "EDIT":
					this.Text = "Consulta de Comprobante";
					miComprobante = new mz.erp.businessrules.comprobantes.ComprobanteDeVenta( "EDIT", momento, idComprobante, null );
					this._momento = mz.erp.businessrules.tsy_TiposDeComprobantes.GetByPk(miComprobante.TipoComprobanteDestino).Momento;
					break;
				case "STEP":
					this.Text = "Proximo Comprobante";
					miComprobante = new mz.erp.businessrules.comprobantes.ComprobanteDeVenta( "STEP", momento,null,TipoComprobanteDestino, relaciones );
					break;
			}
			
			InitEventHandlers();
			InitEvents();
			InitDataBindings();

			
		}

		private void InitEventHandlers()
		{
			if (this.State != "EDIT")
			{
				mzProductosControl1.Init();
				mzProductosControl1.Momento = this._momento;
				mzProductosControl1.SingleSelectionProducto +=new EventHandler(mzProductosControl1_SingleSelectionProducto);
				mzProductosControl1.MultipleSelectionProducto +=new EventHandler(mzProductosControl1_MultipleSelectionProducto);
				//mzCmbResponsableEmision.ValueChanged+= new System.EventHandler( this.Componentes_Changes );
				mzCmbCuenta.ValueChanged+= new System.EventHandler( this.Componentes_Changes );
				mzCmbCondicionDeVenta.ValueChanged+= new System.EventHandler( this.Componentes_Changes );
				mzCmbTipoComprobante.ValueChanged +=new System.EventHandler( this.Componentes_Changes );
				mzCEResponsableEmision.ValueChanged += new System.EventHandler( this.Componentes_Changes );
				mzCmbTipoComprobante.FillFromDataSource( businessrules.tsy_TiposDeComprobantes.GetList(null,null,true,int.MinValue,Variables.GetValueString("Momentos."+this._momento+".Comprobantes")).tsy_TiposDeComprobantes, "IdTipoDeComprobante","Descripcion",100,"ID","Descripcion","Descripcion");
		
			}
			if(this._state == "EDIT")
			{
				tbbImprimir.Visible = true;
				tbStep3.Visible = true;
				mzCmbTipoComprobante.FillFromDataSource( businessrules.tsy_TiposDeComprobantes.GetList(null,null,true,int.MinValue,null).tsy_TiposDeComprobantes, "IdTipoDeComprobante","Descripcion",100,"ID","Descripcion","Descripcion");
			}	

			gridProductos.DoubleClick += new EventHandler(gridProductos_DoubleClick);
			gridProductos.KeyDown +=new KeyEventHandler(gridProductos_KeyDown);
			gridProductos.RecordAdded +=new EventHandler(gridProductos_RecordAdded);
			
			
			mzCEResponsableEmision.FillFromDataSource(businessrules.data.UsuariosPersonas.GetList(), "IdPersona","Nombre",100,"ID","Nombre","Nombre");
			
			mzCmbCuenta.SearchObject = typeof(  mz.erp.ui.forms.classes.tsa_Cuentas  );
			mzCmbCuenta.EditObject = typeof(mz.erp.ui.forms.FrmAbmCuentas);
			mzCmbCuenta.SearchObjectListener = this;
			mzCmbCondicionDeVenta.SearchObject = typeof( mz.erp.ui.forms.classes.tsa_CondicionesDeVentas );
			//cldFechaComprobante.ReadOnly = true;

			gridProductos.GroupByBoxVisible= false;
			
			if (Variables.GetValueBool("Comprobantes.Objetos.DefinicionActiva"))
			{
				ArrayList _buildedarray = new ArrayList();
				_buildedarray.Add("Codigo");
				_buildedarray.Add("DescripcionLarga");
				_buildedarray.Add("Cantidad");
				_buildedarray.Add("UnidadDestino");
				_buildedarray.Add("ValorOrigen");
				_buildedarray.Add("UnidadOrigen");
				_buildedarray.Add("BonificacionPorcentual");
				_buildedarray.Add("PrecioConImpuestos");
				_buildedarray.Add("SubTotalConImpuestos");
				string _camposExtra = Variables.GetValueString("Sistema.Interfaz.ComprobantesDeVenta.LayoutProductos.CamposAdicionales");
				string[] _camposExtras = _camposExtra.Split( ',' );
				for(int i=0;i<_camposExtras.Length;i++)
				{
					_buildedarray.Add( _camposExtras[i] );
				}

				string[] _campos = (string[])_buildedarray.ToArray( typeof( string ) ) ;

				gridProductos.LayoutData = mz.erp.ui.forms.classes.ComprobantesDeVenta.GetLayoutDetalleProductos( _campos );
			}
			else
			{
				ArrayList _buildedarray = new ArrayList();
				_buildedarray.Add("Codigo");
				_buildedarray.Add("DescripcionDetallada");
				_buildedarray.Add("Cantidad");
				_buildedarray.Add("UnidadDestino");
				_buildedarray.Add("ValorOrigen");
				_buildedarray.Add("UnidadOrigen");
				_buildedarray.Add("PrecioConImpuestos");
				_buildedarray.Add("SubTotalConImpuestos");
				string _camposExtra = Variables.GetValueString("Sistema.Interfaz.ComprobantesDeVenta.LayoutProductos.CamposAdicionales");
				string[] _camposExtras = _camposExtra.Split( ',' );
				for(int i=0;i<_camposExtras.Length;i++)
				{
					_buildedarray.Add( _camposExtras[i] );
				}
				
				string[] _campos = (string[])_buildedarray.ToArray( typeof( string ) ) ;
				gridProductos.LayoutData = mz.erp.ui.forms.classes.ComprobantesDeVenta.GetLayoutDetalleProductos( _campos );
				//gridProductos.LayoutData = mz.erp.ui.forms.classes.ComprobantesDeVenta.GetLayoutDetalleProductos( new string[] { "Codigo", "Cantidad","Descripcion","PrecioDeVentaBruto","BonificacionPorcentual","Precio","SubTotalNeto","SubTotalConImpuestos","PrecioConImpuestos"} );
			}

			gridResumenImpuestos.GroupByBoxVisible = false;
			gridResumenImpuestos.LayoutData = mz.erp.ui.forms.classes.ComprobantesDeVenta.GetLayoutResumenImpuestos( new string[] { "Impuesto","Valor" } );
			gridResumenImpuestos.Enabled = false;

			gridVariablesUsuario.GroupByBoxVisible = false;
			gridVariablesUsuario.LayoutData = mz.erp.ui.forms.classes.ComprobantesDeVenta.GetLayoutVariables( );

			gridDetalleCondicionDeVenta.GroupByBoxVisible = false;
			gridDetalleCondicionDeVenta.LayoutData = mz.erp.ui.forms.classes.ComprobantesDeVenta.GetLayoutDetalleCondicionDeVenta( new string[] {"IdCuota","FechaVencimiento","Monto"} );
			gridDetalleCondicionDeVenta.Enabled = false;

			gridEXValores.LayoutData = new mz.erp.ui.forms.classes.tfi_ValoresEx().GetLayoutValores();

			
			
			//Para poder scrollear con el boton del medio del mouse

			MouseHelper mouseControler = new MouseHelper();
			mouseControler.Control = ultraExplorerBar;
			mouseControler.WheelBackward+=new MouseEventHandler(ScrollDown);
			mouseControler.WheelForward += new MouseEventHandler(ScrollUp);

			gridEXValores.RecordsDeleted +=new EventHandler(gridEXValores_RecordsDeleted);
			gridEXValores.DeletingRecords += new CancelEventHandler(gridEXValores_DeletingRecords);


			this.Closing += new CancelEventHandler(FrmComprobantes_Closing);

			gridVariablesUsuario.DoubleClick +=new EventHandler(gridVariablesUsuario_DoubleClick);

		}

		private void ScrollDown (object sender, MouseEventArgs e)
		{
			ultraExplorerBar.PerformAction(UltraExplorerBarAction.ScrollPageDown);
		}

		private void ScrollUp (object sender, MouseEventArgs e)
		{
			ultraExplorerBar.PerformAction(UltraExplorerBarAction.ScrollPageUp);
		}
		

		private void InitEvents()
		{
			miComprobante.OnRecalcularComprobante+= new ComprobanteDeVenta.RecalcularComprobante( this.Recalcular );
			miComprobante.OnRefrescarComprobante+= new ComprobanteDeVenta.RefrescarComprobante( this.Refrescar );
			gridProductos.RecordsDeleted +=new EventHandler(gridProductos_RecordsDeleted);
		}
		private void InitDataBindings()
		{
			//mzCmbResponsableEmision.DataValue = miComprobante.IdResponsable;
			mzCEResponsableEmision.Value = miComprobante.IdResponsable;
			string codigo = null;
			if ((miComprobante.Cuenta.IdCuenta != null && miComprobante.Cuenta.IdCuenta != string.Empty))
			{
				codigo = mz.erp.businessrules.tsa_Cuentas.GetByPk(miComprobante.Cuenta.IdCuenta).Codigo;			
			}
			else 	
			{
				codigo = ComprobantesRules.Momentos_Cuenta_Default(this._momento);
			}
			mzCmbCuenta.DataValue = codigo;
			mzCmbCondicionDeVenta.DataValue= miComprobante.CondicionDeVenta.IdCondicionDeVenta;		

			gridProductos.DataSource = miComprobante.Items;
			//gridProductos.DataBindings.Clear();
			//gridProductos.SetDataBinding(miComprobante.Items, null);
			gridResumenImpuestos.DataSource = miComprobante.ResumenDeImpuestos;
			gridVariablesUsuario.DataSource = miComprobante.VariablesDeUsuario;
			gridDetalleCondicionDeVenta.DataSource = miComprobante.CondicionDeVenta.DetalleCondicionDeVenta;

			uneTotal1.DataBindings.Add("Value",miComprobante,"Total");
			uneTotal.DataBindings.Add( "Value", miComprobante, "Total");
			uneTotalImpuestos.DataBindings.Add("Value", miComprobante, "TotalImpuestos");
			uneTotalNeto.DataBindings.Add("Value",miComprobante,"TotalNeto");
			uneTotalBruto.DataBindings.Add( "Value", miComprobante, "TotalBruto");
			uneTotalDescuentos.DataBindings.Add("Value",miComprobante, "TotalDescuentos");
			uneTotalValores.DataBindings.Add("Value",miComprobante,"ImporteCancelado");
			uneRecargosFinancieros.DataBindings.Add("Value",miComprobante,"TotalRecargosFinancieros");						
			uneBonRecCuenta.DataBindings.Add("Value",miComprobante,"TotalDescuentosCuentas");
			uneBonRecProducto.DataBindings.Add("Value",miComprobante,"TotalDescuentosProductos");
			
			if (miComprobante.TipoComprobanteDestino != null && miComprobante.TipoComprobanteDestino != string.Empty)
			{
				mzCmbTipoComprobante.SetValue( (string)miComprobante.TipoComprobanteDestino);
			}
			cldFechaComprobante.Value = miComprobante.FechaComprobante;
			foreach (Control control in ultraExplorerBar.Controls)
			{
				control.Enabled = miComprobante.AllowEdit;
			}
			if (miComprobante.TemporalNumeration == true)
			{
				txtNumero.Text = "Por Asignar";
			}
			else
			{
				txtNumero.Text = miComprobante.Numero;
			}
			
			txtNumero.Enabled = miComprobante.AllowEditNumeration;
			if (miComprobante.AllowEditNumeration == true) 
			{
				txtNumero.Text = String.Empty;
				txtNumero.DataBindings.Add("Text", miComprobante, "Numero");
				txtNumero.DataBindings.Add("InputMask", miComprobante, "Mascara" );
			}	
			
			this.mzCmbCondicionDeVenta.Enabled = miComprobante.AllowEditCondicionDeVenta;
			this.mzCmbCuenta.Enabled = miComprobante.AllowEditCuenta;
			//this.mzCmbResponsableEmision.Enabled = miComprobante.AllowEditResponsableEmision;
			this.mzCEResponsableEmision.Enabled = miComprobante.AllowEditResponsableEmision;
			this.mzCmbTipoComprobante.Enabled = miComprobante.AllowEditTipoDeComprobante;
			this.containerFormasDePago.Enabled = miComprobante.AllowEditFormasDePago;
			//this.containerItems.Enabled = miComprobante.AllowEditItems;
			this.containerItems.Enabled = true;
			if(this.State.ToUpper().Equals("EDIT"))
			{
				this.bAgregarProducto.Enabled = false;
				this.bDetallesProducto.Enabled = false;
				this.gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
				this.gridProductos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
				this.mzProductosControl1.Enabled = false;
			}

		

			this.cldFechaComprobante.Enabled = miComprobante.AllowEditFecha;
			//Aca iria el nombre del coprobante


			this.Text ="Emision de " + mzCmbTipoComprobante.Text;
			SetCaptionForm("Emision de " + mzCmbTipoComprobante.Text);

			if(this._state.ToUpper().Equals("STEP"))
			{
				//if(this.miComprobante.HasValores)
				//	ConfigGridValores();
			}	
			if(this._state.ToUpper().Equals("EDIT")) 
			{
				tbGuardar.Enabled = false;
			}

			/* Metodo privado q se utiliza para configraciones particulares de las grillas*/
			ConfigGrids();
		}
	
		private void ConfigGrids()
		{	
			foreach(VariableAuxiliar var in miComprobante.VariablesDeUsuario)
			{

			}
		}



		#endregion

		#region Funciones y Metodos Publicos
		#endregion

		#region Funciones y Metodos Privados
		private void SetCaptionForm(string texto)
		{
			this.ultraExplorerBar.Text= texto;
			this.ultraExplorerBar.Groups[0].Text = "Datos de Cabecera - " + texto;
		}
		private void Componentes_Changes(object sender, System.EventArgs e)
		{
			if (((Control)sender).Name == "mzCmbCuenta")
			{
				if (mzCmbCuenta.DataValue != null && miComprobante != null)
				{
					miComprobante.Cuenta.IdCuenta = mz.erp.businessrules.tsa_Cuentas.GetPkByUk((string)mzCmbCuenta.DataValue);
				}
			}
			if (((Control)sender).Name == "mzCmbCondicionDeVenta")
			{
				if (mzCmbCondicionDeVenta.DataValue != null && miComprobante != null)
				{
					miComprobante.CondicionDeVenta.IdCondicionDeVenta = (string)mzCmbCondicionDeVenta.DataValue;
					miComprobante.CondicionDeVenta.Descripcion = (string)mzCmbCondicionDeVenta.Description;
				}
			}
			if (((Control)sender).Name == "mzCEResponsableEmision")
			{
				if (mzCEResponsableEmision.Value != null && miComprobante != null)
				{
					miComprobante.IdResponsable = (string)mzCEResponsableEmision.Value;
					miComprobante.Responsable = mzCEResponsableEmision.Text;
				}
			}
			if(((Control)sender).Name == "mzCmbTipoComprobante")
			{
				this.Text ="Emision de " + mzCmbTipoComprobante.Text;
				SetCaptionForm("Emision de " + mzCmbTipoComprobante.Text);
			}

			if(((Control)sender).Name == "txtNumero")
			{
				miComprobante.Numero = txtNumero.Text;
			}
		
		}
		private void BotoneraProductos( object sender, System.EventArgs e)
		{
			if (sender is Infragistics.Win.Misc.UltraButton)
			{
				string name=((Infragistics.Win.Misc.UltraButton)sender).Name;
				if (name == "bAgregarProducto")
				{
					AgregarProducto();
				}
				if (name == "bEliminarProducto")
				{
					EliminarProducto();
				}
			}
		}

		private void AgregarProducto()
		{
			mz.erp.ui.forms.FrmComprobantesABMProductos form = new FrmComprobantesABMProductos();
			form.ShowForm( miComprobante, "Nuevo", "Agregar Productos");
		}
		private void EliminarProducto()
		{
		}
		private void Refrescar( object sender, System.EventArgs e)
		{
			gridProductos.Refetch();
			gridProductos.Refresh();
		}
		private void Recalcular( object sender, System.EventArgs e )
		{
				
					

			gridProductos.Refetch();
			gridProductos.Refresh();
			//gridProductos.DataBindings.Clear();
			//gridProductos.SetDataBinding(this.miComprobante.Items, null);
			gridVariablesUsuario.SetDataBinding(null,null);
			gridVariablesUsuario.SetDataBinding(miComprobante.VariablesDeUsuario, null );
			gridResumenImpuestos.SetDataBinding( null, null );
			gridResumenImpuestos.SetDataBinding( miComprobante.ResumenDeImpuestos, null);
			gridDetalleCondicionDeVenta.SetDataBinding( null, null);
			gridDetalleCondicionDeVenta.SetDataBinding( miComprobante.CondicionDeVenta.DetalleCondicionDeVenta, null);
			gridDetalleCondicionDeVenta.Refresh();					
			mzCmbTipoComprobante.SetValue( (string)miComprobante.TipoComprobanteDestino );

			

			
		}


		private void mzCmbTipoComprobante_ValueChanged(object sender, System.EventArgs e)
		{
			
		}

		private void mzCmbCuenta_ValueChanged(object sender, System.EventArgs e)
		{

		}

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					break;
				case 1:
					break;
				case 2:
					break;
				case 3:
					break;
				case 5:					
					MessageBox.Show(this,"Funcionalidad no habilitada","Atención!",System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop );
					break;
				case 7:
					if (!HayErrores()) 
					{
						DumpControls();
					}     
					break;
				case 9:
					ReportsManager.PrintReportComprobantes(miComprobante.IdComprobante,this.MdiParent);

					break;
				case 11:
					if ((MessageBox.Show(this,"Esta a punto de cerrar el fomulario. Realmente desea realizar esta operacion?","Atención!",System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Stop )== System.Windows.Forms.DialogResult.OK))
						Close();
					break;
			}		
		
		}
		protected bool Evaluate()
		{			
			if (miComprobante.IsValid())
			{
				if (miComprobante.DatasetComprobante.HasErrors)
				{
					DatasetErrors Errores = new DatasetErrors( miComprobante.DatasetComprobante );
					/*20110328 - Tarea 0000057*/ FrmShowErrors _form = new /*20110328 - Tarea 0000057*/ FrmShowErrors( miComprobante.DatasetComprobante );
					_form.Show();
					miComprobante.DatasetComprobante = null;
					return false;
				}
				else
				{
					return true;
				}
			}
			else
			{
				/*20110328 - Tarea 0000057*/ FrmShowErrors _form = new /*20110328 - Tarea 0000057*/ FrmShowErrors( miComprobante.Errores );
				_form.Show();

				return false;
			}

		}

		private void DumpControls()
		{   					
			Impresion imp = new Impresion(this.MdiParent, miComprobante);
			imp.Imprimir();			
			if (imp.Ok) 
			{				
				MessageBox.Show("La acción se ha ejecutado con éxito");
			
			}

			if(imp.Ok && this._state.ToUpper().Equals("STEP"))
				if(OnCommitComprobante != null)
					OnCommitComprobante(this, new EventArgs());

			if (imp.Cerrar) 
			{
				_save = true;
				this.Close();
			}
			
		}			


		private bool HayErrores() 
		{
			return !Evaluate();
		}

		private void containerItems_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}




		private void ultraExplorerBar1_ItemClick(object sender, Infragistics.Win.UltraWinExplorerBar.ItemEventArgs e)
		{
			
		}
		
		private void ubAgregar_Click(object sender, System.EventArgs e)
		{
			/*
			FrmAbmValores frmV= new FrmAbmValores( miComprobante.GetDataSetValores(), miComprobante.GetCotizaciones(),miComprobante.Saldo );
			frmV.DataSetChange+= new FrmAbmValores.DataSetChangeEventHandler( getDataSet );
			frmV.ShowForm(null,"Pago por "+mzCmbTipoComprobante.Text+" de "+mzCmbCuenta.DisplayValue,"","");
			*/
		}
		private void getDataSet(System.Data.DataSet data, Valor valor)
		{
			try
				{
					decimal recargo = mz.erp.businessrules.tfi_TDCompTesoreriasMonedasRecargos.Recargo( valor.IdTDCompTesoreria, valor.IdMoneda );
					valor.MontoSinRecargos = valor.MontoCotizado;
					if (recargo > 0)
					{
						string mensaje = "La forma de pago ingresada posee un recargo asociado de "+Convert.ToDecimal(recargo)+" %. Desea aplicar los recargos sobre la misma forma de pago? ";
				  		System.Windows.Forms.DialogResult dlg = System.Windows.Forms.MessageBox.Show( mensaje, "Recargos financieros", System.Windows.Forms.MessageBoxButtons.YesNo );
						if (dlg == System.Windows.Forms.DialogResult.Yes)
						{
							//valor.Monto = valor.Monto + (valor.Monto * recargo /100);
						}
					}
					//miComprobante.PutDataSetValores(data, valor);
					ConfigGridValores();
					
				}
			catch (Exception e)
				{
					System.Console.WriteLine(e);
				}
			
		}


		private void ConfigGridValores()
		{
			//gridEXValores.SetDataBinding(miComprobante.GetArrayValores(),null); 
			Janus.Windows.GridEX.GridEXColumnCollection col = gridEXValores.CurrentTable.Columns;
			col["IdMoneda"].HasValueList =true;
			col["IdMoneda"].EditType= Janus.Windows.GridEX.EditType.Combo;
			col["IdMoneda"].ValueList.PopulateValueList(mz.erp.businessrules.tfi_Monedas.GetList().tfi_Monedas,"IdMoneda","Descripcion");
			col["IdEntidad"].HasValueList= true;
			col["IdEntidad"].EditType= Janus.Windows.GridEX.EditType.Combo;
			col["IdEntidad"].ValueList.PopulateValueList(mz.erp.businessrules.tfi_Entidades.GetList().tfi_Entidades, "IdEntidad","Descripcion");
			col["Fecha"].EditType = Janus.Windows.GridEX.EditType.CalendarCombo;
			col["FechaVencimiento"].EditType= Janus.Windows.GridEX.EditType.CalendarCombo;
			col["IdTDCompTesoreria"].HasValueList =true;
			col["IdTDCompTesoreria"].EditType= Janus.Windows.GridEX.EditType.Combo;
			col["IdTDCompTesoreria"].ValueList.PopulateValueList(mz.erp.businessrules.tfi_TDCompTesoreria.GetList().tfi_TDCompTesoreria,"IdTDCompTesoreria","Descripcion");


		}


		private void uneCantidad_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
		
		}

		private void gridProductos_DoubleClick(object sender, EventArgs e)
		{
			//esto se debe hacer segun se permita la edicion o no de la ventana
			gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
			
		}

		
		private void FrmComprobantes_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == System.Windows.Forms.Keys.G)
				if(e.Modifiers == System.Windows.Forms.Keys.Alt)
				{
					if (!HayErrores()) 
					{
						DumpControls();
					}    
				}
		}

		private void ultraExplorerBar_ItemClick(object sender, Infragistics.Win.UltraWinExplorerBar.ItemEventArgs e)
		{
			
		}



		#endregion

		#region Implemetancion Interface ISearchObjectListener
		public void processEventChange(object sender , EventArgs e)
		{
			System.Data.DataSet data = (System.Data.DataSet)sender;
			System.Data.DataTable table = data.Tables["tsa_cuentas"];
			System.Data.DataRow row = table.Rows[0];
			mzCmbCuenta.DataValue = (string )row["Codigo"];
			miComprobante.Cuenta.IdCuenta = mz.erp.businessrules.tsa_Cuentas.GetPkByUk((string)mzCmbCuenta.DataValue);
			
		}
		
		#endregion

		private void ubEliminar_Click(object sender, System.EventArgs e)
		{
			if (gridEXValores.SelectedItems.Count > 0)
			{
				
				gridEXValores.Delete();
				gridEXValores.Refresh();
													
					
			}
		}

		private void gridProductos_RecordsDeleted(object sender, EventArgs e)
		{
			miComprobante.Items.OnRecalcularItems();
		}

		private void ultraExplorerBarContainerControl2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void gridEXValores_RecordsDeleted(object sender, EventArgs e)
		{
			
			//this.miComprobante.Recalcular();
		}

		private void gridEXValores_DeletingRecords(object sender, CancelEventArgs e)
		{
			int posicion  = gridEXValores.SelectedItems[0].Position;
			//this.miComprobante.EliminarValor(posicion);	
		
		}

		
		private void FrmComprobantes_Closing(object sender, CancelEventArgs e)
		{
			if(!_save)
			{
				if(MessageBox.Show("¿Esta seguro que desea cerrar el formulario?","Advertencia",System.Windows.Forms.MessageBoxButtons.OKCancel,System.Windows.Forms.MessageBoxIcon.Warning) == DialogResult.Cancel)
					e.Cancel = true;
			}

		}
		
		private void gridVariablesUsuario_DoubleClick(object sender, EventArgs e)
		{
			
			
			VariableAuxiliar var = (VariableAuxiliar)gridVariablesUsuario.GetRow().DataRow;
			FrmInputType frmInputType = new FrmInputType(var.Descripcion,var,"Valor",var.DataType,typeof(mz.erp.businessrules.comprobantes.VariableAuxiliar));
			frmInputType.ShowDialog();
			gridVariablesUsuario.SetDataBinding(null, null);
			gridVariablesUsuario.SetDataBinding(this.miComprobante.VariablesDeUsuario,null);
		}

		private void mzProductosControl1_SingleSelectionProducto(object sender, EventArgs e)
		{
			Item item = (Item) sender;
			_miItemComprobante = new ItemComprobante( "NEW", miComprobante.Items, item );
			miComprobante.Items.Add( _miItemComprobante );
			gridProductos.MoveLast();
			
		}

		private void mzProductosControl1_MultipleSelectionProducto(object sender, EventArgs e)
		{			
			ArrayList items = (ArrayList)sender;
			miComprobante.Items.ClearCache();
			foreach(Item item in items)
			{
				_miItemComprobante = new ItemComprobante( "NEW", miComprobante.Items, item );
				miComprobante.Items.AddInCache( _miItemComprobante );
			}
			miComprobante.Items.FlushCache();
			gridProductos.MoveLast();


		}

		private void gridProductos_Error(object sender, Janus.Windows.GridEX.ErrorEventArgs e)
		{

			e.DisplayErrorMessage = false;

		}

		private void gridProductos_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == System.Windows.Forms.Keys.D)
			{
				if(e.Modifiers == System.Windows.Forms.Keys.Alt)
				{
			
					ArrayList items = new ArrayList();
					foreach(Janus.Windows.GridEX.GridEXSelectedItem itemSelected in gridProductos.SelectedItems)
					{
						ItemComprobante item = (ItemComprobante)itemSelected.GetRow().DataRow;
						items.Add(item);

					}
					FrmDetalleItem frmdi = new FrmDetalleItem(items, "");
					frmdi.ShowDialog();
			
				}
			}
			else
				if(e.KeyCode == System.Windows.Forms.Keys.Enter)
				{	
					gridProductos.UpdateData();
					gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
				}
			
		}

		private void gridProductos_RecordAdded(object sender, EventArgs e)
		{
			//gridProductos.Row = gridProductos.RecordCount - 1;
			gridProductos.MoveToNewRecord();
		}


	}
}
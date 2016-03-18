using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.businessrules;
using mz.erp.businessrules.data;
using mz.erp.businessrules.comprobantes;
using mz.erp.ui.controls;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.ui.forms.classes;
//using mz.erp.ui.controls;
using mz.erp.ui.controllers;
using mz.erp.ui.utility;


namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de borrar.
	/// </summary>
	public class FrmEntregas : System.Windows.Forms.Form,ITaskForm
	{
		private System.Windows.Forms.ToolBarButton tbGuardar;
		private System.Windows.Forms.ToolBarButton toolBarButton9;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.ToolBarButton tbStep3;
		private System.Windows.Forms.ToolBarButton tbbImprimir;
		private System.Windows.Forms.ToolBarButton tbCerrar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Panel panel2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel2;
		private Infragistics.Win.Misc.UltraLabel ultraLabel6;
		private Infragistics.Win.Misc.UltraLabel ultraLabel7;
		
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit txtNumero;
		private mz.erp.ui.controls.mzComboEditor mzCEResponsableEmision;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo cldFechaVencimiento;
		private Infragistics.Win.Misc.UltraLabel ultraLabel3;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo cldFechaConvenida;
		private Infragistics.Win.Misc.UltraLabel ultraLabel5;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Janus.Windows.GridEX.GridEX gridProductos;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.Label lblCampoAuxiliar4;
		private System.Windows.Forms.Label lblCampoAuxiliar2;
		private System.Windows.Forms.TextBox txtCampoAuxiliar5;
		private System.Windows.Forms.Label lblCampoAuxiliar5;
		private System.Windows.Forms.TextBox txtCampoAuxiliar4;
		private System.Windows.Forms.Label lblCampoAuxiliar3;
		private System.Windows.Forms.TextBox txtCampoAuxiliar3;
		private System.Windows.Forms.Label lblCampoAuxiliar1;
		private System.Windows.Forms.TextBox txtCampoAuxiliar2;
		private System.Windows.Forms.TextBox txtCampoAuxiliar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private System.Windows.Forms.TextBox txtObservaciones;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label1;
		private Janus.Windows.GridEX.GridEX gridDomiciliosAsociados;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtTipoDeComprobante;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private System.Windows.Forms.Label labelTarea;
        private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private mz.erp.ui.controls.mzProductosControl mzProductosControl;
		private mz.erp.ui.controls.mzCuentasControl mzCmbCuenta;
		private System.Windows.Forms.CheckBox chkSoloEntregas;
        private mz.erp.ui.controls.GridManagerView gridManagerView1;
        private ImageList imglStandar;
		protected System.Windows.Forms.ToolBarButton tbbCancelar;

		//private string _momento;



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
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton2 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.labelTarea = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.mzCmbCuenta = new mz.erp.ui.controls.mzCuentasControl();
            this.txtTipoDeComprobante = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
            this.txtNumero = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.mzCEResponsableEmision = new mz.erp.ui.controls.mzComboEditor();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.cldFechaVencimiento = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.cldFechaConvenida = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.gridProductos = new Janus.Windows.GridEX.GridEX();
            this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
            this.mzProductosControl = new mz.erp.ui.controls.mzProductosControl();
            this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.chkSoloEntregas = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gridDomiciliosAsociados = new Janus.Windows.GridEX.GridEX();
            this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.lblCampoAuxiliar4 = new System.Windows.Forms.Label();
            this.lblCampoAuxiliar2 = new System.Windows.Forms.Label();
            this.txtCampoAuxiliar5 = new System.Windows.Forms.TextBox();
            this.lblCampoAuxiliar5 = new System.Windows.Forms.Label();
            this.txtCampoAuxiliar4 = new System.Windows.Forms.TextBox();
            this.lblCampoAuxiliar3 = new System.Windows.Forms.Label();
            this.txtCampoAuxiliar3 = new System.Windows.Forms.TextBox();
            this.lblCampoAuxiliar1 = new System.Windows.Forms.Label();
            this.txtCampoAuxiliar2 = new System.Windows.Forms.TextBox();
            this.txtCampoAuxiliar1 = new System.Windows.Forms.TextBox();
            this.tbGuardar = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
            this.tbStep3 = new System.Windows.Forms.ToolBarButton();
            this.tbbImprimir = new System.Windows.Forms.ToolBarButton();
            this.tbCerrar = new System.Windows.Forms.ToolBarButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.toolBarStandar = new System.Windows.Forms.ToolBar();
            this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
            this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
            this.imglStandar = new System.Windows.Forms.ImageList(this.components);
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.ultraExplorerBarContainerControl5.SuspendLayout();
            this.ultraExplorerBarContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoDeComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEResponsableEmision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cldFechaVencimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cldFechaConvenida)).BeginInit();
            this.ultraExplorerBarContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.ultraExplorerBarContainerControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDomiciliosAsociados)).BeginInit();
            this.ultraExplorerBarContainerControl3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
            this.ultraExplorerBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraExplorerBarContainerControl5
            // 
            this.ultraExplorerBarContainerControl5.Controls.Add(this.labelTarea);
            this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 24);
            this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
            this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(870, 24);
            this.ultraExplorerBarContainerControl5.TabIndex = 4;
            // 
            // labelTarea
            // 
            this.labelTarea.BackColor = System.Drawing.Color.Transparent;
            this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarea.Location = new System.Drawing.Point(0, 0);
            this.labelTarea.Name = "labelTarea";
            this.labelTarea.Size = new System.Drawing.Size(870, 23);
            this.labelTarea.TabIndex = 1;
            this.labelTarea.Text = "Tarea";
            this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ultraExplorerBarContainerControl1
            // 
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbCuenta);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.txtTipoDeComprobante);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel2);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel6);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel7);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.txtNumero);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEResponsableEmision);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel1);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.cldFechaVencimiento);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel3);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.cldFechaConvenida);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel5);
            this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 107);
            this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
            this.ultraExplorerBarContainerControl1.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(870, 76);
            this.ultraExplorerBarContainerControl1.TabIndex = 0;
            // 
            // mzCmbCuenta
            // 
            this.mzCmbCuenta.AllowEditClientePaso = false;
            this.mzCmbCuenta.BackColor = System.Drawing.Color.Transparent;
            this.mzCmbCuenta.DataValue = "";
            this.mzCmbCuenta.EnableCtaCte = false;
            this.mzCmbCuenta.FastSearch = false;
            this.mzCmbCuenta.Location = new System.Drawing.Point(120, 24);
            this.mzCmbCuenta.Name = "mzCmbCuenta";
            this.mzCmbCuenta.ReseteaCodCta = false;
            this.mzCmbCuenta.SearchObjectListener = null;
            this.mzCmbCuenta.Size = new System.Drawing.Size(384, 24);
            this.mzCmbCuenta.TabIndex = 1;
            // 
            // txtTipoDeComprobante
            // 
            this.txtTipoDeComprobante.Location = new System.Drawing.Point(120, 48);
            this.txtTipoDeComprobante.Name = "txtTipoDeComprobante";
            this.txtTipoDeComprobante.Size = new System.Drawing.Size(232, 21);
            this.txtTipoDeComprobante.TabIndex = 2;
            // 
            // ultraLabel2
            // 
            appearance1.TextHAlignAsString = "Right";
            this.ultraLabel2.Appearance = appearance1;
            this.ultraLabel2.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel2.Location = new System.Drawing.Point(-19, 50);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(131, 16);
            this.ultraLabel2.TabIndex = 64;
            this.ultraLabel2.Text = "Tipo de Comprobante";
            // 
            // ultraLabel6
            // 
            appearance2.TextHAlignAsString = "Right";
            this.ultraLabel6.Appearance = appearance2;
            this.ultraLabel6.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel6.Location = new System.Drawing.Point(-11, 3);
            this.ultraLabel6.Name = "ultraLabel6";
            this.ultraLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ultraLabel6.Size = new System.Drawing.Size(120, 20);
            this.ultraLabel6.TabIndex = 63;
            this.ultraLabel6.Text = "Responsable Emisión";
            // 
            // ultraLabel7
            // 
            appearance3.TextHAlignAsString = "Right";
            this.ultraLabel7.Appearance = appearance3;
            this.ultraLabel7.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel7.Location = new System.Drawing.Point(47, 28);
            this.ultraLabel7.Name = "ultraLabel7";
            this.ultraLabel7.Size = new System.Drawing.Size(62, 16);
            this.ultraLabel7.TabIndex = 62;
            this.ultraLabel7.Text = "Cuenta";
            // 
            // txtNumero
            // 
            this.txtNumero.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.txtNumero.InputMask = "\\R-####-########";
            this.txtNumero.Location = new System.Drawing.Point(404, 48);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 3;
            this.txtNumero.Text = "R--";
            this.txtNumero.Leave += new System.EventHandler(this.txtNumero_Leave);
            // 
            // mzCEResponsableEmision
            // 
            this.mzCEResponsableEmision.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEResponsableEmision.DisplayMember = "";
            this.mzCEResponsableEmision.DisplayMemberCaption = "";
            this.mzCEResponsableEmision.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEResponsableEmision.Location = new System.Drawing.Point(120, 0);
            this.mzCEResponsableEmision.MaxItemsDisplay = 7;
            this.mzCEResponsableEmision.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEResponsableEmision.Name = "mzCEResponsableEmision";
            this.mzCEResponsableEmision.Size = new System.Drawing.Size(152, 21);
            this.mzCEResponsableEmision.SorterMember = "";
            this.mzCEResponsableEmision.TabIndex = 0;
            this.mzCEResponsableEmision.ValueMember = "";
            this.mzCEResponsableEmision.ValueMemberCaption = "";
            // 
            // ultraLabel1
            // 
            appearance4.TextHAlignAsString = "Right";
            this.ultraLabel1.Appearance = appearance4;
            this.ultraLabel1.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel1.Location = new System.Drawing.Point(520, 50);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(104, 11);
            this.ultraLabel1.TabIndex = 57;
            this.ultraLabel1.Text = "Fecha vencimiento";
            // 
            // cldFechaVencimiento
            // 
            this.cldFechaVencimiento.BackColor = System.Drawing.SystemColors.Window;
            this.cldFechaVencimiento.DateButtons.Add(dateButton1);
            this.cldFechaVencimiento.Location = new System.Drawing.Point(632, 48);
            this.cldFechaVencimiento.Name = "cldFechaVencimiento";
            this.cldFechaVencimiento.NonAutoSizeHeight = 23;
            this.cldFechaVencimiento.Size = new System.Drawing.Size(104, 21);
            this.cldFechaVencimiento.TabIndex = 5;
            this.cldFechaVencimiento.Value = new System.DateTime(2005, 1, 28, 0, 0, 0, 0);
            // 
            // ultraLabel3
            // 
            appearance5.TextHAlignAsString = "Right";
            this.ultraLabel3.Appearance = appearance5;
            this.ultraLabel3.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel3.Location = new System.Drawing.Point(512, 28);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ultraLabel3.Size = new System.Drawing.Size(112, 11);
            this.ultraLabel3.TabIndex = 56;
            this.ultraLabel3.Text = "Fecha convenida";
            // 
            // cldFechaConvenida
            // 
            this.cldFechaConvenida.BackColor = System.Drawing.SystemColors.Window;
            this.cldFechaConvenida.DateButtons.Add(dateButton2);
            this.cldFechaConvenida.Location = new System.Drawing.Point(632, 24);
            this.cldFechaConvenida.Name = "cldFechaConvenida";
            this.cldFechaConvenida.NonAutoSizeHeight = 23;
            this.cldFechaConvenida.Size = new System.Drawing.Size(104, 21);
            this.cldFechaConvenida.TabIndex = 4;
            this.cldFechaConvenida.Value = new System.DateTime(2005, 1, 28, 0, 0, 0, 0);
            // 
            // ultraLabel5
            // 
            appearance6.TextHAlignAsString = "Right";
            this.ultraLabel5.Appearance = appearance6;
            this.ultraLabel5.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel5.Location = new System.Drawing.Point(328, 50);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.Size = new System.Drawing.Size(72, 22);
            this.ultraLabel5.TabIndex = 65;
            this.ultraLabel5.Text = "Número";
            // 
            // ultraExplorerBarContainerControl2
            // 
            this.ultraExplorerBarContainerControl2.Controls.Add(this.gridProductos);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.gridManagerView1);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.mzProductosControl);
            this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 242);
            this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
            this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(870, 218);
            this.ultraExplorerBarContainerControl2.TabIndex = 1;
            // 
            // gridProductos
            // 
            this.gridProductos.AllowCardSizing = false;
            this.gridProductos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridProductos.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridProductos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridProductos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridProductos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridProductos.Location = new System.Drawing.Point(8, 24);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridProductos.Size = new System.Drawing.Size(856, 144);
            this.gridProductos.TabIndex = 0;
            this.gridProductos.TabStop = false;
            // 
            // gridManagerView1
            // 
            this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
            this.gridManagerView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridManagerView1.Location = new System.Drawing.Point(0, 0);
            this.gridManagerView1.Name = "gridManagerView1";
            this.gridManagerView1.Size = new System.Drawing.Size(870, 24);
            this.gridManagerView1.TabIndex = 3;
            // 
            // mzProductosControl
            // 
            this.mzProductosControl.BackColor = System.Drawing.Color.Transparent;
            this.mzProductosControl.EnabledCantidad = false;
            this.mzProductosControl.EnabledListaDePrecio = true;
            this.mzProductosControl.Location = new System.Drawing.Point(0, 160);
            this.mzProductosControl.Name = "mzProductosControl";
            this.mzProductosControl.PermiteProductosCombo = false;
            this.mzProductosControl.Size = new System.Drawing.Size(790, 48);
            this.mzProductosControl.TabIndex = 1;
            this.mzProductosControl.VisibleCantidad = true;
            this.mzProductosControl.VisibleComboListaDePrecios = true;
            this.mzProductosControl.VisibleComboTipoDePrecioDeCosto = false;
            this.mzProductosControl.VisiblePrecios = true;
            // 
            // ultraExplorerBarContainerControl4
            // 
            this.ultraExplorerBarContainerControl4.Controls.Add(this.chkSoloEntregas);
            this.ultraExplorerBarContainerControl4.Controls.Add(this.label1);
            this.ultraExplorerBarContainerControl4.Controls.Add(this.txtObservaciones);
            this.ultraExplorerBarContainerControl4.Controls.Add(this.label9);
            this.ultraExplorerBarContainerControl4.Controls.Add(this.gridDomiciliosAsociados);
            this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, 519);
            this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
            this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(870, 137);
            this.ultraExplorerBarContainerControl4.TabIndex = 3;
            // 
            // chkSoloEntregas
            // 
            this.chkSoloEntregas.BackColor = System.Drawing.Color.Transparent;
            this.chkSoloEntregas.Checked = true;
            this.chkSoloEntregas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSoloEntregas.Location = new System.Drawing.Point(248, 8);
            this.chkSoloEntregas.Name = "chkSoloEntregas";
            this.chkSoloEntregas.Size = new System.Drawing.Size(160, 16);
            this.chkSoloEntregas.TabIndex = 0;
            this.chkSoloEntregas.Text = "Solo domicilios de entrega";
            this.chkSoloEntregas.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 61;
            this.label1.Text = "Entregar en...";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(416, 27);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(448, 109);
            this.txtObservaciones.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(416, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Observaciones";
            // 
            // gridDomiciliosAsociados
            // 
            this.gridDomiciliosAsociados.AllowCardSizing = false;
            this.gridDomiciliosAsociados.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridDomiciliosAsociados.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridDomiciliosAsociados.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridDomiciliosAsociados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gridDomiciliosAsociados.GroupByBoxVisible = false;
            this.gridDomiciliosAsociados.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridDomiciliosAsociados.Location = new System.Drawing.Point(7, 27);
            this.gridDomiciliosAsociados.Name = "gridDomiciliosAsociados";
            this.gridDomiciliosAsociados.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridDomiciliosAsociados.Size = new System.Drawing.Size(385, 109);
            this.gridDomiciliosAsociados.TabIndex = 1;
            this.gridDomiciliosAsociados.TabStop = false;
            // 
            // ultraExplorerBarContainerControl3
            // 
            this.ultraExplorerBarContainerControl3.Controls.Add(this.lblCampoAuxiliar4);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.lblCampoAuxiliar2);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.txtCampoAuxiliar5);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.lblCampoAuxiliar5);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.txtCampoAuxiliar4);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.lblCampoAuxiliar3);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.txtCampoAuxiliar3);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.lblCampoAuxiliar1);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.txtCampoAuxiliar2);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.txtCampoAuxiliar1);
            this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
            this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(870, 112);
            this.ultraExplorerBarContainerControl3.TabIndex = 2;
            this.ultraExplorerBarContainerControl3.Visible = false;
            // 
            // lblCampoAuxiliar4
            // 
            this.lblCampoAuxiliar4.BackColor = System.Drawing.Color.Transparent;
            this.lblCampoAuxiliar4.Location = new System.Drawing.Point(8, 62);
            this.lblCampoAuxiliar4.Name = "lblCampoAuxiliar4";
            this.lblCampoAuxiliar4.Size = new System.Drawing.Size(88, 16);
            this.lblCampoAuxiliar4.TabIndex = 51;
            this.lblCampoAuxiliar4.Text = "CampoAuxiliar4";
            this.lblCampoAuxiliar4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCampoAuxiliar2
            // 
            this.lblCampoAuxiliar2.BackColor = System.Drawing.Color.Transparent;
            this.lblCampoAuxiliar2.Location = new System.Drawing.Point(8, 22);
            this.lblCampoAuxiliar2.Name = "lblCampoAuxiliar2";
            this.lblCampoAuxiliar2.Size = new System.Drawing.Size(88, 16);
            this.lblCampoAuxiliar2.TabIndex = 49;
            this.lblCampoAuxiliar2.Text = "CampoAuxiliar2";
            this.lblCampoAuxiliar2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCampoAuxiliar5
            // 
            this.txtCampoAuxiliar5.Location = new System.Drawing.Point(96, 80);
            this.txtCampoAuxiliar5.Name = "txtCampoAuxiliar5";
            this.txtCampoAuxiliar5.Size = new System.Drawing.Size(768, 20);
            this.txtCampoAuxiliar5.TabIndex = 47;
            // 
            // lblCampoAuxiliar5
            // 
            this.lblCampoAuxiliar5.BackColor = System.Drawing.Color.Transparent;
            this.lblCampoAuxiliar5.Location = new System.Drawing.Point(8, 82);
            this.lblCampoAuxiliar5.Name = "lblCampoAuxiliar5";
            this.lblCampoAuxiliar5.Size = new System.Drawing.Size(88, 16);
            this.lblCampoAuxiliar5.TabIndex = 52;
            this.lblCampoAuxiliar5.Text = "CampoAuxiliar5";
            this.lblCampoAuxiliar5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCampoAuxiliar4
            // 
            this.txtCampoAuxiliar4.Location = new System.Drawing.Point(96, 60);
            this.txtCampoAuxiliar4.Name = "txtCampoAuxiliar4";
            this.txtCampoAuxiliar4.Size = new System.Drawing.Size(768, 20);
            this.txtCampoAuxiliar4.TabIndex = 46;
            // 
            // lblCampoAuxiliar3
            // 
            this.lblCampoAuxiliar3.BackColor = System.Drawing.Color.Transparent;
            this.lblCampoAuxiliar3.Location = new System.Drawing.Point(8, 42);
            this.lblCampoAuxiliar3.Name = "lblCampoAuxiliar3";
            this.lblCampoAuxiliar3.Size = new System.Drawing.Size(88, 16);
            this.lblCampoAuxiliar3.TabIndex = 50;
            this.lblCampoAuxiliar3.Text = "CampoAuxiliar3";
            this.lblCampoAuxiliar3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCampoAuxiliar3
            // 
            this.txtCampoAuxiliar3.Location = new System.Drawing.Point(96, 40);
            this.txtCampoAuxiliar3.Name = "txtCampoAuxiliar3";
            this.txtCampoAuxiliar3.Size = new System.Drawing.Size(768, 20);
            this.txtCampoAuxiliar3.TabIndex = 45;
            // 
            // lblCampoAuxiliar1
            // 
            this.lblCampoAuxiliar1.BackColor = System.Drawing.Color.Transparent;
            this.lblCampoAuxiliar1.Location = new System.Drawing.Point(8, 2);
            this.lblCampoAuxiliar1.Name = "lblCampoAuxiliar1";
            this.lblCampoAuxiliar1.Size = new System.Drawing.Size(88, 16);
            this.lblCampoAuxiliar1.TabIndex = 48;
            this.lblCampoAuxiliar1.Text = "CampoAuxiliar1";
            this.lblCampoAuxiliar1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCampoAuxiliar2
            // 
            this.txtCampoAuxiliar2.Location = new System.Drawing.Point(96, 20);
            this.txtCampoAuxiliar2.Name = "txtCampoAuxiliar2";
            this.txtCampoAuxiliar2.Size = new System.Drawing.Size(768, 20);
            this.txtCampoAuxiliar2.TabIndex = 44;
            // 
            // txtCampoAuxiliar1
            // 
            this.txtCampoAuxiliar1.Location = new System.Drawing.Point(96, 0);
            this.txtCampoAuxiliar1.Name = "txtCampoAuxiliar1";
            this.txtCampoAuxiliar1.Size = new System.Drawing.Size(768, 20);
            this.txtCampoAuxiliar1.TabIndex = 43;
            // 
            // tbGuardar
            // 
            this.tbGuardar.ImageIndex = 4;
            this.tbGuardar.Name = "tbGuardar";
            this.tbGuardar.Text = "&Guardar";
            // 
            // toolBarButton9
            // 
            this.toolBarButton9.Name = "toolBarButton9";
            this.toolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // toolBarButton5
            // 
            this.toolBarButton5.Name = "toolBarButton5";
            this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.ImageIndex = 2;
            this.toolBarButton3.Name = "toolBarButton3";
            // 
            // toolBarButton4
            // 
            this.toolBarButton4.ImageIndex = 3;
            this.toolBarButton4.Name = "toolBarButton4";
            // 
            // toolBarButton6
            // 
            this.toolBarButton6.ImageIndex = 5;
            this.toolBarButton6.Name = "toolBarButton6";
            // 
            // toolBarButton7
            // 
            this.toolBarButton7.Name = "toolBarButton7";
            this.toolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbStep3
            // 
            this.tbStep3.Name = "tbStep3";
            this.tbStep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.tbStep3.Visible = false;
            // 
            // tbbImprimir
            // 
            this.tbbImprimir.ImageIndex = 8;
            this.tbbImprimir.Name = "tbbImprimir";
            this.tbbImprimir.Text = "Imprimir";
            this.tbbImprimir.Visible = false;
            // 
            // tbCerrar
            // 
            this.tbCerrar.ImageIndex = 7;
            this.tbCerrar.Name = "tbCerrar";
            this.tbCerrar.Text = "Cerrar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.toolBarStandar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 614);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ultraExplorerBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 586);
            this.panel2.TabIndex = 42;
            // 
            // ultraExplorerBar1
            // 
            this.ultraExplorerBar1.AnimationEnabled = false;
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
            this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl5;
            ultraExplorerBarGroup1.Settings.ContainerHeight = 24;
            ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup1.Text = "Tarea";
            ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
            ultraExplorerBarGroup2.Settings.ContainerHeight = 76;
            ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup2.Text = "Datos de cabecera";
            ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl2;
            ultraExplorerBarGroup3.Settings.ContainerHeight = 218;
            ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup3.Text = "Detalle de productos";
            ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl4;
            ultraExplorerBarGroup4.Settings.ContainerHeight = 137;
            ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup4.Text = "Detalles de entrega";
            ultraExplorerBarGroup5.Container = this.ultraExplorerBarContainerControl3;
            ultraExplorerBarGroup5.Settings.ContainerHeight = 112;
            ultraExplorerBarGroup5.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup5.Text = "Información adicional";
            this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2,
            ultraExplorerBarGroup3,
            ultraExplorerBarGroup4,
            ultraExplorerBarGroup5});
            this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 0);
            this.ultraExplorerBar1.Name = "ultraExplorerBar1";
            this.ultraExplorerBar1.Size = new System.Drawing.Size(936, 586);
            this.ultraExplorerBar1.TabIndex = 2;
            this.ultraExplorerBar1.TabStop = false;
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
            this.toolBarStandar.Size = new System.Drawing.Size(936, 28);
            this.toolBarStandar.TabIndex = 41;
            this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
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
            // tbbCancelar
            // 
            this.tbbCancelar.ImageIndex = 7;
            this.tbbCancelar.Name = "tbbCancelar";
            this.tbbCancelar.Text = "&Cancelar";
            // 
            // imglStandar
            // 
            this.imglStandar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
            this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.ImageIndex = 1;
            this.toolBarButton2.Name = "toolBarButton2";
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.ImageIndex = 0;
            this.toolBarButton1.Name = "toolBarButton1";
            // 
            // FrmEntregas
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(936, 614);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEntregas";
            this.Text = "Entregas";
            this.ultraExplorerBarContainerControl5.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoDeComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEResponsableEmision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cldFechaVencimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cldFechaConvenida)).EndInit();
            this.ultraExplorerBarContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ultraExplorerBarContainerControl4.ResumeLayout(false);
            this.ultraExplorerBarContainerControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDomiciliosAsociados)).EndInit();
            this.ultraExplorerBarContainerControl3.ResumeLayout(false);
            this.ultraExplorerBarContainerControl3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
            this.ultraExplorerBar1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
		#endregion 

		#region Custom Members
		

		
		private void Componentes_Changes(object sender, System.EventArgs e)
		{
			
			if (((Control)sender).Name == "mzCmbCuenta")
			{
				if (mzCmbCuenta.DataValue != null && _uiController != null)
				{
					_uiController.CodigoCuenta = (string)mzCmbCuenta.DataValue;
					this.gridDomiciliosAsociados.SetDataBinding(null,null);
					this.gridDomiciliosAsociados.SetDataBinding(this._uiController.DomiciliosAsociados, null );
					RefreshDomicilios();
				}
			}
			if (((Control)sender).Name == "mzCEResponsableEmision")
			{
				if (mzCEResponsableEmision.Value != null && _uiController != null)
				{
					_uiController.IdResponsable = (string)mzCEResponsableEmision.Value;
					

				}
			}
			
		
			
		}


		private void SetCaptionForm(string texto)
		{
			this.Text = texto;
		}

		private void FrmEntregas_Closing(object sender, CancelEventArgs e)
		{
			
			//
			// if(!_save)
			//{
			//	if(MessageBox.Show("¿Esta seguro que desea cerrar el formulario?","Advertencia",System.Windows.Forms.MessageBoxButtons.OKCancel,System.Windows.Forms.MessageBoxIcon.Warning) == DialogResult.Cancel)
			//		e.Cancel = true;
			//}

		}
		#endregion

		#region Variables Privadas
		private string _state;
		private controllers.EntregasController _uiController = null;
		#endregion

		#region Variables Publicas

		//public string State
		//{
		//	get { return _state; }
		//}

		//[ IsViewFormMember ]
		//public void Edit( string idComprobante)
		//{
		//	Init( "EDIT", idComprobante, null, null,null);
		//	this.MdiParent = utility.Environment.MainForm;
		//	this.Show();
		//}

		[ IsNextStepMember ]
		public void Step( string momento, string TipoComprobanteDestino, RelacionesComprobanteOrigenDestino relaciones)
		{						
			//Init( "STEP", null, momento, TipoComprobanteDestino, relaciones);
			this.MdiParent = utility.Environment.MainForm;
			this.Show();
		}

		public void Step( string momento, RelacionesComprobanteOrigenDestino relaciones)
		{
			string TipoComprobanteDestino = null;
			//Init( "STEP", null, momento, TipoComprobanteDestino, relaciones);
			this.MdiParent = utility.Environment.MainForm;
			this.Show();
		}

		#endregion

		#region Constructores y Destructores
		public FrmEntregas( controllers.EntregasController puiController )
		{
			InitializeComponent();
			_uiController = puiController;
			Init();
			
		}

		public FrmEntregas()
		{
			
			InitializeComponent();
			_uiController = new mz.erp.ui.controllers.EntregasController();
	
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
				_uiController.ComprobanteChanged -=new EventHandler(_uiController_ComprobanteChanged);	
				gridProductos.DeletingRecords +=new CancelEventHandler(gridProductos_DeletingRecords);
			}
			base.Dispose( disposing );
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

		//Cristian Configuracion 20110719
        utility.Util.LoadImages(toolBarStandar, imglStandar);
        //Fin Cristian
        tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();


		tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
		gridProductos.GroupByBoxVisible= false;
		/* Silvina 20100614 - Tarea 37 */
        //gridProductos.LayoutData = _uiController.ProductosLayoutData;
		gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(),this.Name, gridProductos, this.Text);
		/* Fin Silvina */
		gridProductos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell;
		gridDomiciliosAsociados.LayoutData = _uiController.DomiciliosAsociadosLayoutData;
		mzCEResponsableEmision.FillFromDataSource(_uiController.Responsable, _uiController.ResponsableValueMember,_uiController.ResponsableDisplayValue,8,_uiController.ResponsableValueMemberCaption,_uiController.ResponsableDisplayMemberCaption,_uiController.ResponsableSortedMember);
		
		mzCmbCuenta.Init(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName());

		this.mzCmbCuenta.Enabled = _uiController.AllowEditCuenta;
		this.mzCEResponsableEmision.Enabled = _uiController.AllowEditResponsableEmision;
		this.txtTipoDeComprobante.Enabled = _uiController.AllowEditTipoDeComprobante;
		gridProductos.Enabled = true;
		mzProductosControl.Enabled = _uiController.AllowAddItems;
		mzProductosControl.EnabledCantidad = true;
		mzProductosControl.SetProcess(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), "V");
		this.txtNumero.Enabled = _uiController.AllowEditNumeration;
		txtNumero.InputMask = _uiController.Mascara;
		txtNumero.Text = _uiController.Numero;
		
		mzCEResponsableEmision.Value = Security.IdPersona;
		labelTarea.Text = _uiController.LeyendaFormulario;
		this.Text = _uiController.Caption;
		if( _uiController.AllowDeleteItems)
			gridProductos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
		else
			gridProductos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
	
		gridDomiciliosAsociados.Enabled = true;
		KeyPreview = true;
	}

	private void InitializeData()
	{
		this.lblCampoAuxiliar1.Text = _uiController.EtiquetaCampoAuxiliar1;
		this.lblCampoAuxiliar2.Text = _uiController.EtiquetaCampoAuxiliar2;
		this.lblCampoAuxiliar3.Text = _uiController.EtiquetaCampoAuxiliar3;
		this.lblCampoAuxiliar4.Text = _uiController.EtiquetaCampoAuxiliar4;
		this.lblCampoAuxiliar5.Text = _uiController.EtiquetaCampoAuxiliar5;

		//this.Text = _uiController.NombreTarea;
		this.cldFechaConvenida.Value = _uiController.FechaConvenida;
		this.cldFechaVencimiento.Value = _uiController.FechaVencimiento;
		this.txtCampoAuxiliar1.Text = _uiController.CampoAuxiliar1;
		this.txtCampoAuxiliar2.Text = _uiController.CampoAuxiliar2;
		this.txtCampoAuxiliar3.Text = _uiController.CampoAuxiliar3;
		this.txtCampoAuxiliar4.Text = _uiController.CampoAuxiliar4;
		this.txtCampoAuxiliar5.Text = _uiController.CampoAuxiliar5;
		this.txtObservaciones.Text = _uiController.Observaciones;
		mzCmbCuenta.DataValue = _uiController.CodigoCuenta;
		this.cldFechaConvenida.Focus();
				
		

	}
	private void InitEventHandlers()
	{
		mzCEResponsableEmision.ValueChanged+= new System.EventHandler( this.Componentes_Changes );
		mzCmbCuenta.ValueChanged+= new System.EventHandler( this.Componentes_Changes );
		gridProductos.Error +=new Janus.Windows.GridEX.ErrorEventHandler(gridProductos_Error);
		gridProductos.DoubleClick +=new EventHandler(gridProductos_DoubleClick);
		gridProductos.UpdatingCell +=new Janus.Windows.GridEX.UpdatingCellEventHandler(gridProductos_UpdatingCell);
		gridProductos.CellEdited+=new Janus.Windows.GridEX.ColumnActionEventHandler(gridProductos_CellEdited);
				
		this.Closing += new CancelEventHandler(FrmEntregas_Closing);
		_uiController.ComprobanteChanged +=new EventHandler(_uiController_ComprobanteChanged);	
		mzProductosControl.AddObjectListener( (IObserver)_uiController );	
		mzCmbCuenta.AddObjectListener( (IObserver)_uiController );
		this.chkSoloEntregas.CheckedChanged += new System.EventHandler(this.chkSoloEntregas_CheckedChanged);

		gridProductos.DeletingRecords +=new CancelEventHandler(gridProductos_DeletingRecords);

		KeyDownManager KeyDownMan = new KeyDownManager(this);

	}	
	
	private void InitDataBindings()

	{				
		cldFechaConvenida.DataBindings.Add("Value", _uiController,"FechaConvenida");
		cldFechaVencimiento.DataBindings.Add("Value", _uiController, "FechaVencimiento");
		txtCampoAuxiliar1.DataBindings.Add("Text", _uiController, "CampoAuxiliar1");
		txtCampoAuxiliar2.DataBindings.Add("Text", _uiController, "CampoAuxiliar2");
		txtCampoAuxiliar3.DataBindings.Add("Text", _uiController, "CampoAuxiliar3");
		txtCampoAuxiliar4.DataBindings.Add("Text", _uiController, "CampoAuxiliar4");
		txtCampoAuxiliar5.DataBindings.Add("Text", _uiController, "CampoAuxiliar5");
		txtObservaciones.DataBindings.Add("Text", _uiController, "Observaciones");
			
		gridProductos.SetDataBinding(_uiController.Items, null);
		gridDomiciliosAsociados.SetDataBinding( _uiController.DomiciliosAsociados, null );
		//BindingController.Bind(txtTipoDeComprobante, "Text", _uiController, "TipoComprobanteDestino");
		RefreshDomicilios();

		txtTipoDeComprobante.DataBindings.Add("Text", _uiController, "NombreDeComprobante");

}
	private void EventsListener()
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
				case 2:	//Guardar
					
					SaveChanges();
					break;
				case 4:	//Salir
					
					_uiController.RefreshData();
					Close();
				break;
			}						
		}

		private void SaveChanges()
		{			
			utility.Util.MoveFocus(ultraExplorerBarContainerControl1);
			_uiController.Numero = txtNumero.Text;
			//gridDomiciliosAsociados.UpdateData();
			_uiController.Execute();
			
		}

		
		/*
		private void mzProductosControl_SingleSelectionProducto(object sender, EventArgs e)
		{
			_uiController.AddItem(sender);
			gridProductos.MoveLast();
		}
		private void mzProductosControl_MultipleSelectionProducto(object sender, EventArgs e)
		{
			


			_uiController.AddItems(sender);
			gridProductos.MoveLast();


		}
		*/

		private void _uiController_ComprobanteChanged(object sender, EventArgs e)
		{
			
			this.gridProductos.SetDataBinding(null, null);
			this.gridProductos.SetDataBinding(this._uiController.Items, null);
			this.gridDomiciliosAsociados.SetDataBinding(null,null);
			this.gridDomiciliosAsociados.SetDataBinding(this._uiController.DomiciliosAsociados, null );
            /* Silvina 20100527 - Tarea 646 */
            if ((_uiController.Items.Count > 0)&& (_uiController.SeleccionaUltimo))
                gridProductos.MoveLast();
			/* Fin Silvina */
			mzCmbCuenta.ValueChanged -= new System.EventHandler( this.Componentes_Changes );
			mzCmbCuenta.DataValue = _uiController.CodigoCuenta;
			mzCmbCuenta.ValueChanged += new System.EventHandler( this.Componentes_Changes );
			mzCEResponsableEmision.ValueChanged -= new System.EventHandler ( this.Componentes_Changes );
			mzCEResponsableEmision.Value = _uiController.IdResponsable;
			mzCEResponsableEmision.ValueChanged += new System.EventHandler ( this.Componentes_Changes );
			RefreshDomicilios();
					
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

		public void ShowForm()
		{
			if(this._uiController.AllowShow())						
			{
				this.Build_UI();
				base.Show();
				//_uiController.RefreshData();

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
			Close();
			
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
		private void ultraLabel2_Click(object sender, System.EventArgs e)
		{
			
		}

		private void cldFechaVencimiento_BeforeDropDown(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
		}

		private void ultraLabel1_Click(object sender, System.EventArgs e)
		{
			
		}

		private void gridProductos_Error(object sender, Janus.Windows.GridEX.ErrorEventArgs e)
		{
			e.DisplayErrorMessage = false;
		}

		private void Init() 
		{
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;
			chkSoloEntregas.Checked = false;
			chkSoloEntregas.CheckState = System.Windows.Forms.CheckState.Unchecked;
			chkSoloEntregas.Enabled = _uiController.AllowOtrosDomicilios;
			this.chkSoloEntregas.CheckedChanged += new System.EventHandler(this.chkSoloEntregas_CheckedChanged);
		
			

		}

		private void gridProductos_DoubleClick(object sender, EventArgs e)
		{
			//esto se debe hacer segun se permita la edicion o no de la ventana, 
			//por eso se le pregunta al controller si es editable o no
			if(_uiController.AllowEditItems)
			{
				if(gridProductos.SelectedItems.Count > 0)
				{
					object selectedItem = 	gridProductos.SelectedItems[0].GetRow().DataRow;
					int col = gridProductos.Col;
					string column = gridProductos.RootTable.Columns[col].Key;
					if (_uiController.IsEditable(selectedItem, column)) 
					{
						if(_uiController.AllowEditInOtherWindow(column))
						{
							FrmInputType frmInputType = new FrmInputType(_uiController.GetDescription(column),selectedItem,column,_uiController.GetTypeOfColumn(selectedItem,column),typeof(mz.erp.businessrules.comprobantes.ItemComprobante));
							frmInputType.ShowDialog();
							gridProductos.SetDataBinding(null, null);
							gridProductos.SetDataBinding(_uiController.Items, null);
						}
						else
						{
							gridProductos.RootTable.Columns[col].EditType = Janus.Windows.GridEX.EditType.TextBox;
							gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
						}
					}
			
					else
					{
						if(gridProductos.AllowEdit.Equals(Janus.Windows.GridEX.InheritableBoolean.True))
							gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;		
					}
				
				}
			}

		}
		private void gridProductos_UpdatingCell(object sender, Janus.Windows.GridEX.UpdatingCellEventArgs e)
		{
			if(e.Value == null || e.Value == System.DBNull.Value)
				e.Cancel = true;
		}

		private void gridProductos_CellEdited(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
		{
			gridProductos.UpdateData();
			gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
		}
		private void RefreshDomicilios()
		{
			if (chkSoloEntregas.Checked)
			{
				//German 20100118 SP6 647
				_uiController.FiltrarYSeleccionarDomicilioEntregas();
				//Fin German 20100118 SP6 647
				Janus.Windows.GridEX.GridEXColumn column = gridDomiciliosAsociados.RootTable.Columns["TipoDomicilio"];
				Janus.Windows.GridEX.ConditionOperator condicion = Janus.Windows.GridEX.ConditionOperator.Contains;
				Janus.Windows.GridEX.GridEXFilterCondition filtro = new Janus.Windows.GridEX.GridEXFilterCondition(column, condicion, "Entrega");
				gridDomiciliosAsociados.RootTable.FilterCondition = filtro;				
			}
			else
			{
				//German 20100118 SP6 647
				_uiController.FiltrarYSeleccionarDomicilio();
				//Fin German 20100118 SP6 647
				if (gridDomiciliosAsociados.RootTable.FilterApplied != null )
					gridDomiciliosAsociados.RootTable.FilterCondition = null;
			}
		}

		private void chkSoloEntregas_CheckedChanged(object sender, System.EventArgs e)
		{
			RefreshDomicilios();
		}

		private void txtNumero_Leave(object sender, System.EventArgs e)
		{
			this.txtNumero.Text = _uiController.FillNumberWithZeros(txtNumero.Text);
		}

		private void gridProductos_DeletingRecords(object sender, CancelEventArgs e)
		{
			if(gridProductos.SelectedItems.Count ==  1)
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
			else e.Cancel = true;
		}


	}
}

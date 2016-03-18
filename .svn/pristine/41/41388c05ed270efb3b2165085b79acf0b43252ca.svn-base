using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.commontypes;
using mz.erp.ui.forms.classes;
using mz.erp.ui.utility;
using System.IO;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmAbmCuentasObservaciones.
	/// </summary>
    public class FrmAbmCuentasObservaciones : System.Windows.Forms.Form, ITaskForm, ISearchObjectListener
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		protected System.Windows.Forms.ToolBarButton toolBarButton6;
		private System.Windows.Forms.ToolBar toolBarStandar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Label labelTarea;		
		private System.Windows.Forms.GroupBox groupBox2;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl container;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton separador2;
		protected System.Windows.Forms.ToolBarButton tbCancelar;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private HtmlRichText.HtmlRichTextBox htmlRichTextBox;
		private System.Windows.Forms.TextBox txtTitulo;
		private mz.erp.ui.controls.mzComboEditor mzCmbSubTipos;
		private mz.erp.ui.controls.mzComboEditor mzCmbTipos;
		private mz.erp.ui.controls.mzComboEditor mzCmbEstados;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo cldFecha;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ImageList imgList1;
		private System.Windows.Forms.ToolBar tb1;
		private System.Windows.Forms.ToolBarButton tbbSeparator0;
		private System.Windows.Forms.ToolBarButton tbbOpen;
		private System.Windows.Forms.ToolBarButton tbbSave;
		private System.Windows.Forms.ToolBarButton tbbSeparator1;
		private System.Windows.Forms.ToolBarButton tbbLeft;
		private System.Windows.Forms.ToolBarButton tbbRight;
		private System.Windows.Forms.ToolBarButton tbbCenter;
		private System.Windows.Forms.ToolBarButton tbbSeparator3;
		private System.Windows.Forms.ToolBarButton tbbBold;
		private System.Windows.Forms.ToolBarButton tbbItalic;
		private System.Windows.Forms.ToolBarButton tbbUnderline;
		private System.Windows.Forms.ToolBarButton tbbSeparator4;
		private System.Windows.Forms.ToolBarButton tbbStrikeout;
		private System.Windows.Forms.ToolBarButton tbbSeparator5;
		private System.Windows.Forms.ToolBarButton tbbSuperScript;
		private System.Windows.Forms.ToolBarButton tbbSubScript;
		private System.Windows.Forms.ToolBarButton tbbSeparator6;
		private System.Windows.Forms.ToolBarButton tbbFont;
		private System.Windows.Forms.ToolBarButton tbbColor;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.Label label6;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo cldFechaAviso;
		private System.Windows.Forms.Label label7;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo cldFechaVencimiento;		
		private System.Windows.Forms.OpenFileDialog ofd1;
		private System.Windows.Forms.SaveFileDialog sfd1;
		//private mz.erp.ui.controls.mzComboSearchEditor mzCmbCuenta2;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbCuenta;
		private System.Windows.Forms.Label label8;
        private mz.erp.ui.controls.mzComboEditor mzComboUsuario;
        private mz.erp.ui.controls.mzProveedoresControl mzCmbProveedor;
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
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton3 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbmCuentasObservaciones));
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.labelTarea = new System.Windows.Forms.Label();
            this.container = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.mzCmbProveedor = new mz.erp.ui.controls.mzProveedoresControl();
            this.mzComboUsuario = new mz.erp.ui.controls.mzComboEditor();
            this.label8 = new System.Windows.Forms.Label();
            this.mzCmbCuenta = new mz.erp.ui.controls.mzComboSearchEditor();
            this.cldFechaVencimiento = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.cldFechaAviso = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cldFecha = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb1 = new System.Windows.Forms.ToolBar();
            this.tbbSeparator0 = new System.Windows.Forms.ToolBarButton();
            this.tbbOpen = new System.Windows.Forms.ToolBarButton();
            this.tbbSave = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator1 = new System.Windows.Forms.ToolBarButton();
            this.tbbLeft = new System.Windows.Forms.ToolBarButton();
            this.tbbRight = new System.Windows.Forms.ToolBarButton();
            this.tbbCenter = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator3 = new System.Windows.Forms.ToolBarButton();
            this.tbbBold = new System.Windows.Forms.ToolBarButton();
            this.tbbItalic = new System.Windows.Forms.ToolBarButton();
            this.tbbUnderline = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator4 = new System.Windows.Forms.ToolBarButton();
            this.tbbStrikeout = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator5 = new System.Windows.Forms.ToolBarButton();
            this.tbbSuperScript = new System.Windows.Forms.ToolBarButton();
            this.tbbSubScript = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator6 = new System.Windows.Forms.ToolBarButton();
            this.tbbFont = new System.Windows.Forms.ToolBarButton();
            this.tbbColor = new System.Windows.Forms.ToolBarButton();
            this.imgList1 = new System.Windows.Forms.ImageList(this.components);
            this.htmlRichTextBox = new HtmlRichText.HtmlRichTextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.mzCmbSubTipos = new mz.erp.ui.controls.mzComboEditor();
            this.mzCmbTipos = new mz.erp.ui.controls.mzComboEditor();
            this.mzCmbEstados = new mz.erp.ui.controls.mzComboEditor();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.imglStandar = new System.Windows.Forms.ImageList(this.components);
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
            this.toolBarStandar = new System.Windows.Forms.ToolBar();
            this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
            this.separador2 = new System.Windows.Forms.ToolBarButton();
            this.tbCancelar = new System.Windows.Forms.ToolBarButton();
            this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.sfd1 = new System.Windows.Forms.SaveFileDialog();
            this.ultraExplorerBarContainerControl2.SuspendLayout();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzComboUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cldFechaVencimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cldFechaAviso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cldFecha)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbSubTipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbTipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbEstados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
            this.ultraExplorerBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraExplorerBarContainerControl2
            // 
            this.ultraExplorerBarContainerControl2.Controls.Add(this.labelTarea);
            this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 24);
            this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
            this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(927, 24);
            this.ultraExplorerBarContainerControl2.TabIndex = 1;
            // 
            // labelTarea
            // 
            this.labelTarea.BackColor = System.Drawing.Color.Transparent;
            this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarea.Location = new System.Drawing.Point(0, 0);
            this.labelTarea.Name = "labelTarea";
            this.labelTarea.Size = new System.Drawing.Size(927, 23);
            this.labelTarea.TabIndex = 3;
            this.labelTarea.Text = "Tarea";
            this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // container
            // 
            this.container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.container.Controls.Add(this.mzCmbProveedor);
            this.container.Controls.Add(this.mzComboUsuario);
            this.container.Controls.Add(this.label8);
            this.container.Controls.Add(this.mzCmbCuenta);
            this.container.Controls.Add(this.cldFechaVencimiento);
            this.container.Controls.Add(this.cldFechaAviso);
            this.container.Controls.Add(this.label5);
            this.container.Controls.Add(this.label4);
            this.container.Controls.Add(this.label3);
            this.container.Controls.Add(this.label2);
            this.container.Controls.Add(this.label1);
            this.container.Controls.Add(this.cldFecha);
            this.container.Controls.Add(this.groupBox2);
            this.container.Controls.Add(this.txtTitulo);
            this.container.Controls.Add(this.mzCmbSubTipos);
            this.container.Controls.Add(this.mzCmbTipos);
            this.container.Controls.Add(this.mzCmbEstados);
            this.container.Controls.Add(this.label6);
            this.container.Controls.Add(this.label7);
            this.container.Location = new System.Drawing.Point(28, 107);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(927, 509);
            this.container.TabIndex = 0;
            this.container.TabStop = true;
            // 
            // mzCmbProveedor
            // 
            this.mzCmbProveedor.BackColor = System.Drawing.SystemColors.Control;
            this.mzCmbProveedor.DataValue = "";
            this.mzCmbProveedor.EnableCtaCte = false;
            this.mzCmbProveedor.FastSearch = false;
            this.mzCmbProveedor.Location = new System.Drawing.Point(104, 9);
            this.mzCmbProveedor.Name = "mzCmbProveedor";
            this.mzCmbProveedor.SearchObjectListener = null;
            this.mzCmbProveedor.Size = new System.Drawing.Size(448, 22);
            this.mzCmbProveedor.TabIndex = 113;
            this.mzCmbProveedor.Tag = "ResponsableEmision";
            // 
            // mzComboUsuario
            // 
            this.mzComboUsuario.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzComboUsuario.DisplayMember = "";
            this.mzComboUsuario.DisplayMemberCaption = "";
            this.mzComboUsuario.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzComboUsuario.Location = new System.Drawing.Point(616, 80);
            this.mzComboUsuario.MaxItemsDisplay = 50;
            this.mzComboUsuario.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzComboUsuario.Name = "mzComboUsuario";
            this.mzComboUsuario.Size = new System.Drawing.Size(160, 21);
            this.mzComboUsuario.SorterMember = "";
            this.mzComboUsuario.TabIndex = 8;
            this.mzComboUsuario.ValueMember = "";
            this.mzComboUsuario.ValueMemberCaption = "";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(568, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 16);
            this.label8.TabIndex = 112;
            this.label8.Text = "Usuario";
            // 
            // mzCmbCuenta
            // 
            this.mzCmbCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mzCmbCuenta.DataValue = "";
            this.mzCmbCuenta.EditObject = null;
            this.mzCmbCuenta.FastSearch = false;
            this.mzCmbCuenta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mzCmbCuenta.HierarchicalSearch = false;
            this.mzCmbCuenta.Location = new System.Drawing.Point(104, 8);
            this.mzCmbCuenta.Name = "mzCmbCuenta";
            this.mzCmbCuenta.ReadOnly = false;
            this.mzCmbCuenta.SearchObject = null;
            this.mzCmbCuenta.SearchObjectListener = null;
            this.mzCmbCuenta.Size = new System.Drawing.Size(422, 22);
            this.mzCmbCuenta.TabIndex = 0;
            // 
            // cldFechaVencimiento
            // 
            this.cldFechaVencimiento.BackColor = System.Drawing.SystemColors.Window;
            this.cldFechaVencimiento.DateButtons.Add(dateButton1);
            this.cldFechaVencimiento.Location = new System.Drawing.Point(376, 80);
            this.cldFechaVencimiento.Name = "cldFechaVencimiento";
            this.cldFechaVencimiento.NonAutoSizeHeight = 23;
            this.cldFechaVencimiento.Size = new System.Drawing.Size(128, 21);
            this.cldFechaVencimiento.TabIndex = 7;
            this.cldFechaVencimiento.Value = new System.DateTime(2005, 8, 15, 0, 0, 0, 0);
            // 
            // cldFechaAviso
            // 
            this.cldFechaAviso.BackColor = System.Drawing.SystemColors.Window;
            this.cldFechaAviso.DateButtons.Add(dateButton2);
            this.cldFechaAviso.Location = new System.Drawing.Point(104, 80);
            this.cldFechaAviso.Name = "cldFechaAviso";
            this.cldFechaAviso.NonAutoSizeHeight = 23;
            this.cldFechaAviso.Size = new System.Drawing.Size(128, 21);
            this.cldFechaAviso.TabIndex = 6;
            this.cldFechaAviso.Value = new System.DateTime(2005, 8, 15, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(16, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 107;
            this.label5.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(568, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 106;
            this.label4.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(16, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 105;
            this.label3.Text = "Título";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(568, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 104;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 103;
            this.label1.Text = "Cuenta";
            // 
            // cldFecha
            // 
            this.cldFecha.BackColor = System.Drawing.SystemColors.Window;
            this.cldFecha.DateButtons.Add(dateButton3);
            this.cldFecha.Location = new System.Drawing.Point(648, 8);
            this.cldFecha.Name = "cldFecha";
            this.cldFecha.NonAutoSizeHeight = 23;
            this.cldFecha.Size = new System.Drawing.Size(128, 21);
            this.cldFecha.TabIndex = 1;
            this.cldFecha.Value = new System.DateTime(2005, 8, 15, 0, 0, 0, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.tb1);
            this.groupBox2.Controls.Add(this.htmlRichTextBox);
            this.groupBox2.Location = new System.Drawing.Point(8, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 384);
            this.groupBox2.TabIndex = 100;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Observaciones";
            // 
            // tb1
            // 
            this.tb1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbSeparator0,
            this.tbbOpen,
            this.tbbSave,
            this.tbbSeparator1,
            this.tbbLeft,
            this.tbbRight,
            this.tbbCenter,
            this.tbbSeparator3,
            this.tbbBold,
            this.tbbItalic,
            this.tbbUnderline,
            this.tbbSeparator4,
            this.tbbStrikeout,
            this.tbbSeparator5,
            this.tbbSuperScript,
            this.tbbSubScript,
            this.tbbSeparator6,
            this.tbbFont,
            this.tbbColor});
            this.tb1.ButtonSize = new System.Drawing.Size(16, 16);
            this.tb1.Divider = false;
            this.tb1.DropDownArrows = true;
            this.tb1.ImageList = this.imgList1;
            this.tb1.Location = new System.Drawing.Point(3, 16);
            this.tb1.Name = "tb1";
            this.tb1.ShowToolTips = true;
            this.tb1.Size = new System.Drawing.Size(762, 26);
            this.tb1.TabIndex = 7;
            this.tb1.Visible = false;
            this.tb1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tb1_ButtonClick);
            // 
            // tbbSeparator0
            // 
            this.tbbSeparator0.Name = "tbbSeparator0";
            this.tbbSeparator0.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbOpen
            // 
            this.tbbOpen.Enabled = false;
            this.tbbOpen.ImageIndex = 10;
            this.tbbOpen.Name = "tbbOpen";
            this.tbbOpen.ToolTipText = "Open";
            // 
            // tbbSave
            // 
            this.tbbSave.Enabled = false;
            this.tbbSave.ImageIndex = 11;
            this.tbbSave.Name = "tbbSave";
            this.tbbSave.ToolTipText = "Save";
            // 
            // tbbSeparator1
            // 
            this.tbbSeparator1.Name = "tbbSeparator1";
            this.tbbSeparator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbLeft
            // 
            this.tbbLeft.ImageIndex = 0;
            this.tbbLeft.Name = "tbbLeft";
            this.tbbLeft.ToolTipText = "Left";
            // 
            // tbbRight
            // 
            this.tbbRight.ImageIndex = 1;
            this.tbbRight.Name = "tbbRight";
            this.tbbRight.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbRight.ToolTipText = "Right";
            // 
            // tbbCenter
            // 
            this.tbbCenter.ImageIndex = 2;
            this.tbbCenter.Name = "tbbCenter";
            this.tbbCenter.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbCenter.ToolTipText = "Center";
            // 
            // tbbSeparator3
            // 
            this.tbbSeparator3.Name = "tbbSeparator3";
            this.tbbSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbBold
            // 
            this.tbbBold.ImageIndex = 3;
            this.tbbBold.Name = "tbbBold";
            this.tbbBold.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbBold.ToolTipText = "Bold";
            // 
            // tbbItalic
            // 
            this.tbbItalic.ImageIndex = 4;
            this.tbbItalic.Name = "tbbItalic";
            this.tbbItalic.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbItalic.ToolTipText = "Italic";
            // 
            // tbbUnderline
            // 
            this.tbbUnderline.ImageIndex = 5;
            this.tbbUnderline.Name = "tbbUnderline";
            this.tbbUnderline.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbUnderline.ToolTipText = "Underline";
            // 
            // tbbSeparator4
            // 
            this.tbbSeparator4.Name = "tbbSeparator4";
            this.tbbSeparator4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbStrikeout
            // 
            this.tbbStrikeout.ImageIndex = 6;
            this.tbbStrikeout.Name = "tbbStrikeout";
            this.tbbStrikeout.ToolTipText = "Strikeout";
            // 
            // tbbSeparator5
            // 
            this.tbbSeparator5.Name = "tbbSeparator5";
            this.tbbSeparator5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbSuperScript
            // 
            this.tbbSuperScript.ImageIndex = 12;
            this.tbbSuperScript.Name = "tbbSuperScript";
            this.tbbSuperScript.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbSuperScript.ToolTipText = "Super";
            // 
            // tbbSubScript
            // 
            this.tbbSubScript.ImageIndex = 13;
            this.tbbSubScript.Name = "tbbSubScript";
            this.tbbSubScript.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbSubScript.ToolTipText = "Sub";
            // 
            // tbbSeparator6
            // 
            this.tbbSeparator6.Name = "tbbSeparator6";
            this.tbbSeparator6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbFont
            // 
            this.tbbFont.ImageIndex = 8;
            this.tbbFont.Name = "tbbFont";
            this.tbbFont.ToolTipText = "Font";
            // 
            // tbbColor
            // 
            this.tbbColor.ImageIndex = 9;
            this.tbbColor.Name = "tbbColor";
            this.tbbColor.ToolTipText = "Color";
            // 
            // imgList1
            // 
            this.imgList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList1.ImageStream")));
            this.imgList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // htmlRichTextBox
            // 
            this.htmlRichTextBox.Location = new System.Drawing.Point(16, 48);
            this.htmlRichTextBox.Name = "htmlRichTextBox";
            this.htmlRichTextBox.Size = new System.Drawing.Size(736, 328);
            this.htmlRichTextBox.TabIndex = 9;
            this.htmlRichTextBox.Text = "";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(104, 56);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(672, 20);
            this.txtTitulo.TabIndex = 5;
            this.txtTitulo.Text = "textBox1";
            // 
            // mzCmbSubTipos
            // 
            this.mzCmbSubTipos.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbSubTipos.DisplayMember = "";
            this.mzCmbSubTipos.DisplayMemberCaption = "";
            this.mzCmbSubTipos.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbSubTipos.Location = new System.Drawing.Point(272, 32);
            this.mzCmbSubTipos.MaxItemsDisplay = 50;
            this.mzCmbSubTipos.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbSubTipos.Name = "mzCmbSubTipos";
            this.mzCmbSubTipos.Size = new System.Drawing.Size(160, 21);
            this.mzCmbSubTipos.SorterMember = "";
            this.mzCmbSubTipos.TabIndex = 3;
            this.mzCmbSubTipos.ValueMember = "";
            this.mzCmbSubTipos.ValueMemberCaption = "";
            // 
            // mzCmbTipos
            // 
            this.mzCmbTipos.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbTipos.DisplayMember = "";
            this.mzCmbTipos.DisplayMemberCaption = "";
            this.mzCmbTipos.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbTipos.Location = new System.Drawing.Point(104, 32);
            this.mzCmbTipos.MaxItemsDisplay = 50;
            this.mzCmbTipos.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbTipos.Name = "mzCmbTipos";
            this.mzCmbTipos.Size = new System.Drawing.Size(160, 21);
            this.mzCmbTipos.SorterMember = "";
            this.mzCmbTipos.TabIndex = 2;
            this.mzCmbTipos.ValueMember = "";
            this.mzCmbTipos.ValueMemberCaption = "";
            // 
            // mzCmbEstados
            // 
            this.mzCmbEstados.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbEstados.DisplayMember = "";
            this.mzCmbEstados.DisplayMemberCaption = "";
            this.mzCmbEstados.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbEstados.Location = new System.Drawing.Point(648, 32);
            this.mzCmbEstados.MaxItemsDisplay = 50;
            this.mzCmbEstados.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbEstados.Name = "mzCmbEstados";
            this.mzCmbEstados.Size = new System.Drawing.Size(128, 21);
            this.mzCmbEstados.SorterMember = "";
            this.mzCmbEstados.TabIndex = 4;
            this.mzCmbEstados.ValueMember = "";
            this.mzCmbEstados.ValueMemberCaption = "";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(16, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 109;
            this.label6.Text = "Fecha de aviso";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(296, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 111;
            this.label7.Text = "Fecha de venc.";
            // 
            // imglStandar
            // 
            this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
            this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.ImageIndex = 9;
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.Text = "&Anterior";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.ImageIndex = 8;
            this.toolBarButton3.Name = "toolBarButton3";
            this.toolBarButton3.Text = "&Siguiente";
            // 
            // toolBarButton4
            // 
            this.toolBarButton4.Name = "toolBarButton4";
            this.toolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.toolBarButton4.Visible = false;
            // 
            // toolBarButton6
            // 
            this.toolBarButton6.ImageIndex = 7;
            this.toolBarButton6.Name = "toolBarButton6";
            this.toolBarButton6.Text = "&Cancelar";
            this.toolBarButton6.Visible = false;
            // 
            // toolBarStandar
            // 
            this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbAnterior,
            this.tbbSeparator,
            this.tbbSiguiente,
            this.separador2,
            this.tbCancelar});
            this.toolBarStandar.DropDownArrows = true;
            this.toolBarStandar.ImageList = this.imglStandar;
            this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
            this.toolBarStandar.Name = "toolBarStandar";
            this.toolBarStandar.ShowToolTips = true;
            this.toolBarStandar.Size = new System.Drawing.Size(976, 28);
            this.toolBarStandar.TabIndex = 44;
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
            // separador2
            // 
            this.separador2.Name = "separador2";
            this.separador2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.separador2.Visible = false;
            // 
            // tbCancelar
            // 
            this.tbCancelar.ImageIndex = 7;
            this.tbCancelar.Name = "tbCancelar";
            this.tbCancelar.Text = "&Cancelar";
            this.tbCancelar.Visible = false;
            // 
            // ultraExplorerBar1
            // 
            this.ultraExplorerBar1.AnimationEnabled = false;
            this.ultraExplorerBar1.Controls.Add(this.container);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
            this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl2;
            ultraExplorerBarGroup1.Settings.ContainerHeight = 24;
            ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup1.Text = "Tarea";
            ultraExplorerBarGroup2.Container = this.container;
            ultraExplorerBarGroup2.Settings.ContainerHeight = 509;
            ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup2.Text = "Datos Generales";
            this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2});
            this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
            this.ultraExplorerBar1.Name = "ultraExplorerBar1";
            this.ultraExplorerBar1.Size = new System.Drawing.Size(976, 658);
            this.ultraExplorerBar1.TabIndex = 45;
            this.ultraExplorerBar1.TabStop = false;
            // 
            // ofd1
            // 
            this.ofd1.DefaultExt = "htm";
            this.ofd1.Filter = "Html Files|*.htm;*.html|Rich Text Files|*.rtf|Plain Text File|*.txt|All Files|*.*" +
                "";
            this.ofd1.Title = "Open File";
            // 
            // sfd1
            // 
            this.sfd1.DefaultExt = "htm";
            this.sfd1.Filter = "Html Files|*.htm;*.html|Rich Text Files|*.rtf|Plain Text File|*.txt|All Files|*.*" +
                "";
            this.sfd1.Title = "Save As";
            // 
            // FrmAbmCuentasObservaciones
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(976, 686);
            this.Controls.Add(this.ultraExplorerBar1);
            this.Controls.Add(this.toolBarStandar);
            this.Name = "FrmAbmCuentasObservaciones";
            this.Text = "FrmAbmCuentasObservaciones";
            this.ultraExplorerBarContainerControl2.ResumeLayout(false);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzComboUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cldFechaVencimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cldFechaAviso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cldFecha)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbSubTipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbTipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbEstados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
            this.ultraExplorerBar1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        /* Silvina 20100920 - Tarea 839 */
        #region Miembros de ISearchObjectListener
        public void processEventChange(object sender, EventArgs e)
        {
        }

        #endregion
        /* Fin Silvina */

		#region Constructores y Destructores		
		public FrmAbmCuentasObservaciones()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		public FrmAbmCuentasObservaciones( controllers.AbmCuentasObservacionesController controller )
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
		private controllers.AbmCuentasObservacionesController _uiController = null;
		#endregion
		#region Variables Publicas
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
            /* Silvina 20110801 - Tarea 0000065 */
            mz.erp.ui.utility.Util.LoadImages(toolBarStandar, imglStandar);
            /* Fin Silvina 20110801 - Tarea 0000065 */

			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();

			this.Text = _uiController.LeyendaFormulario;			
			this.labelTarea.Text = _uiController.LeyendaFormulario;	
			this.txtTitulo.Text = _uiController.Titulo;
			
			this.htmlRichTextBox.Text = _uiController.Observaciones;
			htmlRichTextBox.MaxLength = 8000;
			
			
			this.cldFechaAviso.AllowNull = false;
			this.cldFechaVencimiento.AllowNull = false;
			this.cldFecha.AllowNull=false;

			bool PanelVisible = _uiController.HerramientaFormatoVisible; 
			this.tb1.Visible = PanelVisible;
			if (PanelVisible)
			{
				this.htmlRichTextBox.Location = new System.Drawing.Point(16, 48);				
				this.htmlRichTextBox.Size = new System.Drawing.Size(736, 264);
			}
			else 
			{
				this.htmlRichTextBox.Location = new System.Drawing.Point(16, 16);				
				this.htmlRichTextBox.Size = new System.Drawing.Size(736, 296);
			}
			//this.tb1.Enabled = false;

			//mzCmbCuenta.Enabled = true;
			mzCmbCuenta.Visible = true;
			mzCmbCuenta.Select();			

			mzComboUsuario.FillFromDataSource(_uiController.Usuarios,_uiController.KeyValueUsuarios,_uiController.KeyListUsuarios,100,_uiController.KeyListUsuarios );
		
			System.Console.WriteLine(_uiController.IdUsuario);
			//Controles enable
			this.txtTitulo.Enabled=_uiController.PermiteEditarTitulo;
			this.mzCmbEstados.Enabled=_uiController.PermiteEditarEstado;
			this.mzCmbTipos.Enabled=_uiController.PermiteEditarTipo;
			this.mzCmbSubTipos.Enabled=_uiController.PermiteEditarSubTipo;
			this.mzCmbCuenta.Enabled=_uiController.PermiteEditarCuenta;
            /* Silvina 20100916 - Tarea 839 */
            mzCmbProveedor.Init();
            mzCmbProveedor.SearchObjectListener = this;
            //mzCmbProveedor.EnableCtaCte = _uiController.EnabledButtonCuentaCtaCte;
            mzCmbProveedor.Enabled = _uiController.PermiteEditarCuenta;
            /* Fin Silvina */
			this.mzComboUsuario.Enabled=_uiController.PermiteEditarResponsable;
			this.cldFechaAviso.Enabled=_uiController.PermiteEditarFechaAviso;
			this.cldFechaVencimiento.Enabled=_uiController.PermiteEditarFechaVencimiento;
			this.cldFecha.Enabled = _uiController.PermiteEditarFecha;
			this.htmlRichTextBox.Enabled=_uiController.PermiteEditarObservaciones;

			string Proceso = _uiController.GetProcessManager().GetProcessName();
			if(Proceso.Equals("ProcesoABMCuentasObservaciones") || Proceso.Equals("ProcesoEditarCuentasObservaciones"))
			{
				label1.Text = "Cuenta";
				mzCmbEstados.FillFromDataSource( _uiController.Estados, _uiController.KeyValueEstados,_uiController.KeyListEstados,100, _uiController.KeyListEstados );
				mzCmbTipos.FillFromDataSource( _uiController.Tipos, _uiController.KeyValueTipos,_uiController.KeyListTipos,100, _uiController.KeyListTipos );
				mzCmbSubTipos.FillFromDataSource( _uiController.SubTipos, _uiController.KeyValueTipos,_uiController.KeyListTipos,100, _uiController.KeyListTipos );
                /* Silvina 20100916 - Tarea 839 */
                mzCmbProveedor.Visible = false;
                mzCmbCuenta.Visible = true;
                /* Fin Silvina */
			}
			else if(Proceso.Equals("ProcesoABMProveedoresObservaciones") || Proceso.Equals("ProcesoEditarProveedoresObservaciones"))
			{
				label1.Text = "Proveedor";
				mzCmbEstados.FillFromDataSource( _uiController.EstadosProveedores, _uiController.KeyValueEstadosProveedores,_uiController.KeyListEstadosProveedores,100, _uiController.KeyListEstadosProveedores );
				mzCmbTipos.FillFromDataSource( _uiController.TiposProveedores, _uiController.KeyValueTiposProveedores,_uiController.KeyListTiposProveedores,100, _uiController.KeyListTiposProveedores );
				mzCmbSubTipos.FillFromDataSource( _uiController.SubTiposProveedores, _uiController.KeyValueTiposProveedores,_uiController.KeyListTiposProveedores,100, _uiController.KeyListTiposProveedores );
                /* Silvina 20100916 - Tarea 839 */
                mzCmbProveedor.Visible = true;
                mzCmbCuenta.Visible = false;
                /* Fin Silvina */
			}

			KeyPreview = true;
				
		}

		private void InitializeData()
		{
			string Proceso = _uiController.GetProcessManager().GetProcessName();
			if(Proceso.Equals("ProcesoABMCuentasObservaciones") || Proceso.Equals("ProcesoEditarCuentasObservaciones"))
                mzCmbCuenta.DataValue = _uiController.CodigoCuenta;
			else if(Proceso.Equals("ProcesoABMProveedoresObservaciones") || Proceso.Equals("ProcesoEditarProveedoresObservaciones"))
				/* Silvina 20100916 - Tarea 839 */
                //mzCmbCuenta.DataValue = _uiController.IdProveedor;
                mzCmbProveedor.DataValue = _uiController.CodigoProveedor;
                /* Fin Silvina */
		}

		private void InitEventHandlers()
		{
			mzCmbCuenta.ValueChanged+= new System.EventHandler( this.Componentes_Changes );
			string Proceso = _uiController.GetProcessManager().GetProcessName();
			if(Proceso.Equals("ProcesoABMCuentasObservaciones") || Proceso.Equals("ProcesoEditarCuentasObservaciones"))
			{
				mzCmbCuenta.SearchObject = typeof(  mz.erp.ui.forms.classes.tsa_Cuentas  );
				mzCmbCuenta.EditObject = typeof(mz.erp.ui.forms.FrmAbmCuentas);
			}
			else if(Proceso.Equals("ProcesoABMProveedoresObservaciones") || Proceso.Equals("ProcesoEditarProveedoresObservaciones"))
			{
                /* Silvina 20100920 - Tarea 839 */
                //mzCmbCuenta.SearchObject = typeof(mz.erp.ui.forms.classes.tpu_Proveedores);
                //mzCmbCuenta.EditObject = typeof(mz.erp.ui.forms.FrmAbmProveedores);
                mzCmbProveedor.ValueChanged += new EventHandler(mzCmbProveedor_ValueChanged);
                /* Fin Silvina */
			}
			mzCmbTipos.ValueChanged+= new System.EventHandler( this.Componentes_Changes );			
			this._uiController.TiposHasChanged +=new EventHandler(_uiController_TiposHasChanged);
			this.mzComboUsuario.Leave+=new EventHandler(mzComboUsuario_Change);
			//this.mzCEResponsableEmision.Leave+=new EventHandler(mzCEResponsableEmision_Change);
			//mzCmbCuenta.SearchObjectListener = this;
			this.Closed +=new EventHandler(FrmAbmCuentasObservaciones_Closed);
			KeyDownManager KeyDown = new KeyDownManager(this);
		}

        /* Silvina 20100920 - Tarea 839 */
        private void mzCmbProveedor_ValueChanged(object sender, EventArgs e)
        {
            _uiController.CodigoProveedor = (string)mzCmbProveedor.DataValue;
        }
        /* Fin Silvina */

		private void InitDataBindings()
		{			
			string Proceso = _uiController.GetProcessManager().GetProcessName();
			if(Proceso.Equals("ProcesoABMCuentasObservaciones") || Proceso.Equals("ProcesoEditarCuentasObservaciones"))
			{
				BindingController.Bind(mzCmbCuenta, "DataValue", _uiController, "CodigoCuenta");
				BindingController.Bind(mzCmbEstados,"Value", _uiController, "IdEstado");
				BindingController.Bind(mzCmbTipos,"Value", _uiController, "IdTipo");
				BindingController.Bind(mzCmbSubTipos,"Value", _uiController, "IdSubTipo");
			}
			else if(Proceso.Equals("ProcesoABMProveedoresObservaciones") || Proceso.Equals("ProcesoEditarProveedoresObservaciones"))
			{
                /* Silvina 20100920 */
				//BindingController.Bind(mzCmbCuenta, "DataValue", _uiController, "IdProveedor");
                /* Fin Silvina */
				BindingController.Bind(mzCmbEstados,"Value", _uiController, "IdEstadoProveedor");
				BindingController.Bind(mzCmbTipos,"Value", _uiController, "IdTipoProveedor");
				BindingController.Bind(mzCmbSubTipos,"Value", _uiController, "IdSubTipoProveedor");
			}
			BindingController.Bind(cldFecha,"Value", _uiController, "Fecha");			
			BindingController.Bind(cldFechaAviso,"Value", _uiController, "FechaAviso");			
			BindingController.Bind(cldFechaVencimiento,"Value", _uiController, "FechaVencimiento");			
			BindingController.Bind(mzComboUsuario,"Value", _uiController, "IdUsuario");
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);			
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
				case 4:	//Cancelar					
					CloseForm();
					break;
			}						
		}

		private void SaveChanges()
		{									
			Util.MoveFocus(this.container);
			_uiController.Titulo = txtTitulo.Text;
			//_uiController.Observaciones = htmlRichTextBox.Rtf;
			_uiController.Observaciones = htmlRichTextBox.Text;
			_uiController.Execute();
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


		private void Init() 
		{			
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;						
			if (_uiController.IdCuentaObservacion != null)
			{
				_uiController.GetObservacion();
			}
		}

		private void Componentes_Changes( object sender, System.EventArgs e )
		{
			/*if (_uiController.CodigoCuenta.CompareTo( Convert.ToString(mzCmbCuenta.DataValue)) != 0)
			{
				_uiController.CodigoCuenta = Convert.ToString(mzCmbCuenta.DataValue);
			}			*/
		}

		private void FrmAbmCuentasObservaciones_Closed(object sender, EventArgs e)
		{
			ClearDataBindings();
			ClearEventHandlers();
		}
	
		private void ClearDataBindings()
		{			
			mzCmbCuenta.DataBindings.Clear();	
			mzCmbEstados.DataBindings.Clear();	
			mzCmbTipos.DataBindings.Clear();	
			mzCmbSubTipos.DataBindings.Clear();	
			BindingController.Clear(mzComboUsuario,"Value", _uiController, "IdUsuario");
			BindingController.Clear(cldFecha,"Value", _uiController, "Fecha");
			BindingController.Clear(cldFechaAviso,"Value", _uiController, "FechaAviso");			
			BindingController.Clear(cldFechaVencimiento,"Value", _uiController, "FechaVencimiento");			

		}

		private void ClearEventHandlers()
		{
			mzCmbCuenta.ValueChanged-= new System.EventHandler( this.Componentes_Changes );			
			mzCmbTipos.ValueChanged-= new System.EventHandler( this.Componentes_Changes );
			this.Closed -=new EventHandler(FrmAbmCuentasObservaciones_Closed);						
		}

		private void _uiController_TiposHasChanged(object sender, EventArgs e)
		{
			string Proceso = _uiController.GetProcessManager().GetProcessName();
			if(Proceso.Equals("ProcesoABMCuentasObservaciones") || Proceso.Equals("ProcesoEditarCuentasObservaciones"))
				mzCmbSubTipos.FillFromDataSource( _uiController.SubTipos, _uiController.KeyValueTipos,_uiController.KeyListTipos,100, _uiController.KeyListTipos );
			else if(Proceso.Equals("ProcesoABMProveedoresObservaciones") || Proceso.Equals("ProcesoEditarProveedoresObservaciones"))
				mzCmbSubTipos.FillFromDataSource( _uiController.SubTiposProveedores, _uiController.KeyValueTiposProveedores,_uiController.KeyListTiposProveedores,100, _uiController.KeyListTiposProveedores );
			if (mzCmbTipos.Value != null) 
			{														
				if (_uiController.CantidadSubTipos <= 1) 
				{					
					this.mzCmbSubTipos.Enabled = false;								
				}
				else 
				{					
					this.mzCmbSubTipos.Enabled = true;
					
				}
			}
		}

		private void tb1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch(e.Button.ToolTipText)
			{
				case "Bold":
				{
					if (htmlRichTextBox.SelectionFont != null) 
					{
						htmlRichTextBox.SelectionFont = new Font(htmlRichTextBox.SelectionFont, htmlRichTextBox.SelectionFont.Style ^ FontStyle.Bold);
					}

				}
					break;

				case "Italic":
				{
					if (htmlRichTextBox.SelectionFont != null) 
					{
						htmlRichTextBox.SelectionFont = new Font(htmlRichTextBox.SelectionFont, htmlRichTextBox.SelectionFont.Style ^ FontStyle.Italic);
					}
				}
					break;

				case "Underline":
				{
					if (htmlRichTextBox.SelectionFont != null) 
					{
						htmlRichTextBox.SelectionFont = new Font(htmlRichTextBox.SelectionFont, htmlRichTextBox.SelectionFont.Style ^ FontStyle.Underline);
					}
				}
					break;

				case "Strikeout":
				{
					if (htmlRichTextBox.SelectionFont != null) 
					{
						htmlRichTextBox.SelectionFont = new Font(htmlRichTextBox.SelectionFont, htmlRichTextBox.SelectionFont.Style ^ FontStyle.Strikeout);
					}
				}
					break;

				case "Super":
				{
					if (tbbSuperScript.Pushed)
					{
						htmlRichTextBox.SetSuperScript(true);
						htmlRichTextBox.SetSubScript(false);
					}
					else
					{
						htmlRichTextBox.SetSuperScript(false);
					}
				}
					break;

				case "Sub":
				{
					if (tbbSubScript.Pushed)
					{
						htmlRichTextBox.SetSubScript(true);
						htmlRichTextBox.SetSuperScript(false);
					}
					else
					{
						htmlRichTextBox.SetSubScript(false);
					}
				}
					break;
				case "Left":
				{
					//change horizontal alignment to left
					htmlRichTextBox.SelectionAlignment = HorizontalAlignment.Left; 
				}
					break;

				case "Right":
				{
					//change horizontal alignment to right
					htmlRichTextBox.SelectionAlignment = HorizontalAlignment.Right;
				}
					break;

				case "Center":
				{
					//change horizontal alignment to center
					htmlRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
				}
					break;

				case "Open":
				{
					try
					{
						if ((ofd1.ShowDialog() == DialogResult.OK) && (ofd1.FileName.Length > 0))
						{
							string strExt = System.IO.Path.GetExtension(ofd1.FileName).ToLower();

							if (strExt == ".rtf")
							{
								htmlRichTextBox.LoadFile(ofd1.FileName, RichTextBoxStreamType.RichText);
							}
							else if (strExt == ".txt") 
							{
								htmlRichTextBox.LoadFile(ofd1.FileName, RichTextBoxStreamType.PlainText);
							}
							else if ((strExt == ".htm") || (strExt == ".html")) 
							{
								// Read the HTML format
								StreamReader sr = File.OpenText(ofd1.FileName);
								string strHTML = sr.ReadToEnd();
								sr.Close();

								htmlRichTextBox.AddHTML(strHTML);
							}
						}
					}
					catch
					{
						MessageBox.Show("There was an error loading the file: " + ofd1.FileName);
					}
				}
					break;

				case "Save":
				{
					if ((sfd1.ShowDialog() == DialogResult.OK) && (sfd1.FileName.Length > 0))
					{
						string strExt = System.IO.Path.GetExtension(sfd1.FileName).ToLower();

						if (strExt == ".rtf")
						{
							htmlRichTextBox.SaveFile(sfd1.FileName);
						}
						else if (strExt == ".txt") 
						{
							htmlRichTextBox.SaveFile(sfd1.FileName, RichTextBoxStreamType.PlainText);
						}
						else if ((strExt == ".htm") || (strExt == ".html")) 
						{
							try
							{
								// save as HTML format
								string strText = htmlRichTextBox.GetHTML(true, true);

								if (File.Exists(sfd1.FileName)) 
									File.Delete(sfd1.FileName);

								StreamWriter sr = File.CreateText(sfd1.FileName);
								sr.Write(strText);
								sr.Close();
							}
							catch
							{
								MessageBox.Show("There was an error saving the file: " + sfd1.FileName);
							}
						}
					}
				}
					break;

				case "Font":
				{
					if (htmlRichTextBox.SelectionFont != null)
						fontDialog1.Font = htmlRichTextBox.SelectionFont;
					else
						fontDialog1.Font = htmlRichTextBox.Font;

					if (fontDialog1.ShowDialog() == DialogResult.OK)
					{
						if (htmlRichTextBox.SelectionFont != null)
							htmlRichTextBox.SelectionFont = fontDialog1.Font;
						else
							htmlRichTextBox.Font = fontDialog1.Font;
					}
				}
					break;

				case "Color":
				{
					colorDialog1.Color = htmlRichTextBox.SelectionColor;

					if (colorDialog1.ShowDialog() == DialogResult.OK)
					{						
						htmlRichTextBox.SelectionColor = colorDialog1.Color;
					}
				}
					break;
			}
			
			UpdateToolbar(); //Update the toolbar buttons		
		}
		public void UpdateToolbar()
		{
			//This is done incase 2 different fonts are selected at the same time
			//If that is the case there is no selection font so I use the default
			//font instead.
			Font fnt;
			
			if (htmlRichTextBox.SelectionFont != null)
				fnt = htmlRichTextBox.SelectionFont;
			else
				fnt = htmlRichTextBox.Font;

			//Do all the toolbar button checks
			tbbBold.Pushed		= fnt.Bold; //bold button
			tbbItalic.Pushed	= fnt.Italic; //italic button
			tbbUnderline.Pushed	= fnt.Underline; //underline button
			tbbStrikeout.Pushed	= fnt.Strikeout; //strikeout button
			tbbLeft.Pushed		= (htmlRichTextBox.SelectionAlignment == HorizontalAlignment.Left); //justify left
			tbbCenter.Pushed	= (htmlRichTextBox.SelectionAlignment == HorizontalAlignment.Center); //justify center
			tbbRight.Pushed		= (htmlRichTextBox.SelectionAlignment == HorizontalAlignment.Right); //justify right

			tbbSuperScript.Pushed = htmlRichTextBox.IsSuperScript();
			tbbSubScript.Pushed = htmlRichTextBox.IsSubScript();
		}

		private void ShowPassword() 
		{			
			string IdPersona = Convert.ToString(mzComboUsuario.Value);			
			if (IdPersona != _uiController.UltimoResponsableClaveCorrecta)
			{
				string password = InputBox.ShowInputBoxPassword("Ingrese la contraseña:","Cambio de responsable de emisión");								
				bool ClaveCorrecta = false;
				if (IdPersona != null && IdPersona != String.Empty)
				{
					ClaveCorrecta = businessrules.Security.LogInXPersona(IdPersona, password);					
					if (!ClaveCorrecta /*&& password != ""*/)
						MessageBox.Show("¡Clave incorrecta!", "Cambio de responsable de emisión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					else
						_uiController.UltimoResponsableClaveCorrecta = IdPersona;
				}
				
				if (!ClaveCorrecta)
					_uiController.ClearResponsableDeEmision();
			}
		}

		private void mzComboUsuario_Change(object sender, EventArgs e)
		{
			if (_uiController.HabilitarContraseña) 
			{
				ShowPassword();				
			}	
		}

		}
}

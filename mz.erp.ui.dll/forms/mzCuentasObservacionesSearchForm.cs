using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.commontypes;
using mz.erp.ui.controllers;
using mz.erp.ui.utility;
using mz.erp.ui.forms.classes;
/* Silvina 20110608 - Tarea 0000065 */
using System.Data;
/* Fin Silvina 20110608 - Tarea 0000065 */

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de mzCuentasSearchForm.
	/// </summary>
    public class mzCuentasObservacionesSearchForm : System.Windows.Forms.Form, ITaskForm, ISearchObjectListener
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.ImageList imglStandar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
		private mz.erp.ui.controls.mzComboEditor mzCmbTipos;
		private mz.erp.ui.controls.mzComboEditor mzCmbEstados;
		private mz.erp.ui.controls.mzComboEditor mzCmbUsuarios;
		private System.Windows.Forms.CheckBox chkFiltroFechas;
		private System.Windows.Forms.Label label1;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbCuenta;
		private System.Windows.Forms.CheckBox chkFiltroCuenta;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo uccFechaHasta;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo uccFechaDesde;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private HtmlRichText.HtmlRichTextBox htmlRichTextBox1;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.CheckBox chkVerAvisosPendientes;
		private Janus.Windows.GridEX.GridEX gridResultado;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
        private mz.erp.ui.controls.mzProveedoresControl mzCmbProveedor;
        private ToolTip toolTip;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtSubTipos;
        private Infragistics.Win.UltraWinGrid.UltraGrid grillaSubTipos;
		private System.ComponentModel.IContainer components;


		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton2 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.ValueListItem valueListItem1 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.txtSubTipos = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.grillaSubTipos = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.mzCmbProveedor = new mz.erp.ui.controls.mzProveedoresControl();
            this.chkVerAvisosPendientes = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.uccFechaHasta = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.uccFechaDesde = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.chkFiltroCuenta = new System.Windows.Forms.CheckBox();
            this.mzCmbCuenta = new mz.erp.ui.controls.mzComboSearchEditor();
            this.label1 = new System.Windows.Forms.Label();
            this.mzCmbUsuarios = new mz.erp.ui.controls.mzComboEditor();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mzCmbTipos = new mz.erp.ui.controls.mzComboEditor();
            this.mzCmbEstados = new mz.erp.ui.controls.mzComboEditor();
            this.chkFiltroFechas = new System.Windows.Forms.CheckBox();
            this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
            this.gridResultado = new Janus.Windows.GridEX.GridEX();
            this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.htmlRichTextBox1 = new HtmlRichText.HtmlRichTextBox();
            this.imglStandar = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.toolBarStandar = new System.Windows.Forms.ToolBar();
            this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ultraExplorerBarContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaSubTipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uccFechaHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uccFechaDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbTipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbEstados)).BeginInit();
            this.ultraExplorerBarContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
            this.ultraExplorerBarContainerControl3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
            this.ultraExplorerBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraExplorerBarContainerControl1
            // 
            this.ultraExplorerBarContainerControl1.Controls.Add(this.txtSubTipos);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.grillaSubTipos);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbProveedor);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.chkVerAvisosPendientes);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label4);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label6);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label7);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.uccFechaHasta);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.uccFechaDesde);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.chkFiltroCuenta);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbCuenta);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbUsuarios);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label5);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbTipos);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbEstados);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.chkFiltroFechas);
            this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, -55);
            this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(842, 103);
            this.ultraExplorerBarContainerControl1.TabIndex = 0;
            // 
            // txtSubTipos
            // 
            this.txtSubTipos.Location = new System.Drawing.Point(283, 32);
            this.txtSubTipos.Name = "txtSubTipos";
            this.txtSubTipos.Size = new System.Drawing.Size(141, 21);
            this.txtSubTipos.TabIndex = 131;
            // 
            // grillaSubTipos
            // 
            appearance13.BackColor = System.Drawing.SystemColors.Window;
            appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.grillaSubTipos.DisplayLayout.Appearance = appearance13;
            this.grillaSubTipos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.grillaSubTipos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance14.BorderColor = System.Drawing.SystemColors.Window;
            this.grillaSubTipos.DisplayLayout.GroupByBox.Appearance = appearance14;
            appearance16.ForeColor = System.Drawing.SystemColors.GrayText;
            this.grillaSubTipos.DisplayLayout.GroupByBox.BandLabelAppearance = appearance16;
            this.grillaSubTipos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.grillaSubTipos.DisplayLayout.GroupByBox.Hidden = true;
            appearance15.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance15.BackColor2 = System.Drawing.SystemColors.Control;
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance15.ForeColor = System.Drawing.SystemColors.GrayText;
            this.grillaSubTipos.DisplayLayout.GroupByBox.PromptAppearance = appearance15;
            this.grillaSubTipos.DisplayLayout.MaxColScrollRegions = 1;
            this.grillaSubTipos.DisplayLayout.MaxRowScrollRegions = 1;
            appearance21.BackColor = System.Drawing.SystemColors.Window;
            appearance21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grillaSubTipos.DisplayLayout.Override.ActiveCellAppearance = appearance21;
            appearance17.BackColor = System.Drawing.SystemColors.Highlight;
            appearance17.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.grillaSubTipos.DisplayLayout.Override.ActiveRowAppearance = appearance17;
            this.grillaSubTipos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.grillaSubTipos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance24.BackColor = System.Drawing.SystemColors.Window;
            this.grillaSubTipos.DisplayLayout.Override.CardAreaAppearance = appearance24;
            appearance20.BorderColor = System.Drawing.Color.Silver;
            appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.grillaSubTipos.DisplayLayout.Override.CellAppearance = appearance20;
            this.grillaSubTipos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.grillaSubTipos.DisplayLayout.Override.CellPadding = 0;
            appearance18.BackColor = System.Drawing.SystemColors.Control;
            appearance18.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance18.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance18.BorderColor = System.Drawing.SystemColors.Window;
            this.grillaSubTipos.DisplayLayout.Override.GroupByRowAppearance = appearance18;
            appearance19.TextHAlignAsString = "Left";
            this.grillaSubTipos.DisplayLayout.Override.HeaderAppearance = appearance19;
            this.grillaSubTipos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.grillaSubTipos.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance22.BackColor = System.Drawing.SystemColors.Window;
            appearance22.BorderColor = System.Drawing.Color.Silver;
            this.grillaSubTipos.DisplayLayout.Override.RowAppearance = appearance22;
            this.grillaSubTipos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance23.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grillaSubTipos.DisplayLayout.Override.TemplateAddRowAppearance = appearance23;
            this.grillaSubTipos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.grillaSubTipos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.grillaSubTipos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.grillaSubTipos.Location = new System.Drawing.Point(642, 6);
            this.grillaSubTipos.Name = "grillaSubTipos";
            this.grillaSubTipos.Size = new System.Drawing.Size(170, 83);
            this.grillaSubTipos.TabIndex = 130;
            this.grillaSubTipos.Text = "ultraGrid1";
            // 
            // mzCmbProveedor
            // 
            this.mzCmbProveedor.BackColor = System.Drawing.SystemColors.Control;
            this.mzCmbProveedor.DataValue = "";
            this.mzCmbProveedor.EnableCtaCte = false;
            this.mzCmbProveedor.FastSearch = false;
            this.mzCmbProveedor.Location = new System.Drawing.Point(97, 55);
            this.mzCmbProveedor.Name = "mzCmbProveedor";
            this.mzCmbProveedor.SearchObjectListener = null;
            this.mzCmbProveedor.Size = new System.Drawing.Size(448, 22);
            this.mzCmbProveedor.TabIndex = 128;
            this.mzCmbProveedor.Tag = "ResponsableEmision";
            // 
            // chkVerAvisosPendientes
            // 
            this.chkVerAvisosPendientes.BackColor = System.Drawing.Color.Transparent;
            this.chkVerAvisosPendientes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkVerAvisosPendientes.Location = new System.Drawing.Point(8, 80);
            this.chkVerAvisosPendientes.Name = "chkVerAvisosPendientes";
            this.chkVerAvisosPendientes.Size = new System.Drawing.Size(192, 24);
            this.chkVerAvisosPendientes.TabIndex = 9;
            this.chkVerAvisosPendientes.Text = "Ver avisos pendientes";
            this.chkVerAvisosPendientes.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 127;
            this.label2.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(448, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 126;
            this.label4.Text = "Usuario alta:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(280, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 124;
            this.label6.Text = "Fin";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(120, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 125;
            this.label7.Text = "Inicio";
            // 
            // uccFechaHasta
            // 
            this.uccFechaHasta.BackColor = System.Drawing.SystemColors.Window;
            this.uccFechaHasta.DateButtons.Add(dateButton1);
            this.uccFechaHasta.Location = new System.Drawing.Point(328, 8);
            this.uccFechaHasta.Name = "uccFechaHasta";
            this.uccFechaHasta.NonAutoSizeHeight = 23;
            this.uccFechaHasta.Size = new System.Drawing.Size(96, 21);
            this.uccFechaHasta.TabIndex = 2;
            this.uccFechaHasta.Value = new System.DateTime(2011, 4, 5, 0, 0, 0, 0);
            // 
            // uccFechaDesde
            // 
            this.uccFechaDesde.BackColor = System.Drawing.SystemColors.Window;
            this.uccFechaDesde.DateButtons.Add(dateButton2);
            this.uccFechaDesde.Location = new System.Drawing.Point(160, 8);
            this.uccFechaDesde.Name = "uccFechaDesde";
            this.uccFechaDesde.NonAutoSizeHeight = 23;
            this.uccFechaDesde.Size = new System.Drawing.Size(96, 21);
            this.uccFechaDesde.TabIndex = 1;
            this.uccFechaDesde.Value = new System.DateTime(2011, 4, 5, 0, 0, 0, 0);
            // 
            // chkFiltroCuenta
            // 
            this.chkFiltroCuenta.BackColor = System.Drawing.Color.Transparent;
            this.chkFiltroCuenta.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFiltroCuenta.Checked = true;
            this.chkFiltroCuenta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFiltroCuenta.Location = new System.Drawing.Point(72, 55);
            this.chkFiltroCuenta.Name = "chkFiltroCuenta";
            this.chkFiltroCuenta.Size = new System.Drawing.Size(16, 24);
            this.chkFiltroCuenta.TabIndex = 7;
            this.chkFiltroCuenta.UseVisualStyleBackColor = false;
            // 
            // mzCmbCuenta
            // 
            this.mzCmbCuenta.DataValue = "";
            this.mzCmbCuenta.EditObject = null;
            this.mzCmbCuenta.FastSearch = false;
            this.mzCmbCuenta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mzCmbCuenta.HierarchicalSearch = false;
            this.mzCmbCuenta.Location = new System.Drawing.Point(96, 56);
            this.mzCmbCuenta.Name = "mzCmbCuenta";
            this.mzCmbCuenta.ReadOnly = false;
            this.mzCmbCuenta.SearchObject = null;
            this.mzCmbCuenta.SearchObjectListener = null;
            this.mzCmbCuenta.Size = new System.Drawing.Size(592, 22);
            this.mzCmbCuenta.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 119;
            this.label1.Text = "Cuenta";
            // 
            // mzCmbUsuarios
            // 
            this.mzCmbUsuarios.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbUsuarios.DisplayMember = "";
            this.mzCmbUsuarios.DisplayMemberCaption = "";
            this.mzCmbUsuarios.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbUsuarios.Location = new System.Drawing.Point(528, 8);
            this.mzCmbUsuarios.MaxItemsDisplay = 50;
            this.mzCmbUsuarios.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbUsuarios.Name = "mzCmbUsuarios";
            this.mzCmbUsuarios.Size = new System.Drawing.Size(160, 21);
            this.mzCmbUsuarios.SorterMember = "";
            this.mzCmbUsuarios.TabIndex = 3;
            this.mzCmbUsuarios.ValueMember = "";
            this.mzCmbUsuarios.ValueMemberCaption = "";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(8, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 112;
            this.label5.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(448, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 111;
            this.label3.Text = "Estado";
            // 
            // mzCmbTipos
            // 
            this.mzCmbTipos.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbTipos.DisplayMember = "";
            this.mzCmbTipos.DisplayMemberCaption = "";
            this.mzCmbTipos.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbTipos.Location = new System.Drawing.Point(97, 32);
            this.mzCmbTipos.MaxItemsDisplay = 50;
            this.mzCmbTipos.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbTipos.Name = "mzCmbTipos";
            this.mzCmbTipos.Size = new System.Drawing.Size(160, 21);
            this.mzCmbTipos.SorterMember = "";
            this.mzCmbTipos.TabIndex = 4;
            this.mzCmbTipos.ValueMember = "";
            this.mzCmbTipos.ValueMemberCaption = "";
            // 
            // mzCmbEstados
            // 
            this.mzCmbEstados.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbEstados.DisplayMember = "";
            this.mzCmbEstados.DisplayMemberCaption = "";
            this.mzCmbEstados.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            valueListItem1.DataValue = "ValueListItem0";
            this.mzCmbEstados.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem1});
            this.mzCmbEstados.Location = new System.Drawing.Point(528, 32);
            this.mzCmbEstados.MaxItemsDisplay = 50;
            this.mzCmbEstados.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbEstados.Name = "mzCmbEstados";
            this.mzCmbEstados.Size = new System.Drawing.Size(160, 21);
            this.mzCmbEstados.SorterMember = "";
            this.mzCmbEstados.TabIndex = 6;
            this.mzCmbEstados.ValueMember = "";
            this.mzCmbEstados.ValueMemberCaption = "";
            // 
            // chkFiltroFechas
            // 
            this.chkFiltroFechas.BackColor = System.Drawing.Color.Transparent;
            this.chkFiltroFechas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFiltroFechas.Location = new System.Drawing.Point(72, 6);
            this.chkFiltroFechas.Name = "chkFiltroFechas";
            this.chkFiltroFechas.Size = new System.Drawing.Size(16, 24);
            this.chkFiltroFechas.TabIndex = 0;
            this.chkFiltroFechas.UseVisualStyleBackColor = false;
            // 
            // ultraExplorerBarContainerControl2
            // 
            this.ultraExplorerBarContainerControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.ultraExplorerBarContainerControl2.Controls.Add(this.gridManagerView1);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.gridResultado);
            this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 107);
            this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
            this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(842, 181);
            this.ultraExplorerBarContainerControl2.TabIndex = 1;
            // 
            // gridManagerView1
            // 
            this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
            this.gridManagerView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridManagerView1.Location = new System.Drawing.Point(0, 0);
            this.gridManagerView1.Name = "gridManagerView1";
            this.gridManagerView1.Size = new System.Drawing.Size(842, 24);
            this.gridManagerView1.TabIndex = 0;
            // 
            // gridResultado
            // 
            this.gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridResultado.AlternatingColors = true;
            this.gridResultado.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridResultado.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridResultado.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridResultado.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridResultado.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridResultado.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
            this.gridResultado.GroupByBoxVisible = false;
            this.gridResultado.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridResultado.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridResultado.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
            this.gridResultado.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
            this.gridResultado.Location = new System.Drawing.Point(0, 21);
            this.gridResultado.Name = "gridResultado";
            this.gridResultado.RecordNavigatorText = "Registro:|de";
            this.gridResultado.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridResultado.ShowEmptyFields = false;
            this.gridResultado.Size = new System.Drawing.Size(842, 160);
            this.gridResultado.TabIndex = 1;
            this.gridResultado.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            // 
            // ultraExplorerBarContainerControl3
            // 
            this.ultraExplorerBarContainerControl3.Controls.Add(this.htmlRichTextBox1);
            this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 347);
            this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
            this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(842, 128);
            this.ultraExplorerBarContainerControl3.TabIndex = 2;
            // 
            // htmlRichTextBox1
            // 
            this.htmlRichTextBox1.AutoSize = true;
            this.htmlRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlRichTextBox1.Location = new System.Drawing.Point(0, 0);
            this.htmlRichTextBox1.Name = "htmlRichTextBox1";
            this.htmlRichTextBox1.Size = new System.Drawing.Size(842, 128);
            this.htmlRichTextBox1.TabIndex = 91;
            this.htmlRichTextBox1.Text = "";
            // 
            // imglStandar
            // 
            this.imglStandar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
            this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(916, 526);
            this.tabControl1.TabIndex = 46;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ultraExplorerBar1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(908, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Observaciones";
            // 
            // ultraExplorerBar1
            // 
            this.ultraExplorerBar1.AnimationEnabled = false;
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
            this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
            ultraExplorerBarGroup1.Settings.ContainerHeight = 103;
            ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup1.Text = "Filtros";
            ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
            ultraExplorerBarGroup2.Settings.ContainerHeight = 181;
            ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup2.Text = "Detalle";
            ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl3;
            ultraExplorerBarGroup3.Settings.ContainerHeight = 128;
            ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup3.Text = "Más detalles";
            this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2,
            ultraExplorerBarGroup3});
            this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 0);
            this.ultraExplorerBar1.Name = "ultraExplorerBar1";
            this.ultraExplorerBar1.Size = new System.Drawing.Size(908, 500);
            this.ultraExplorerBar1.TabIndex = 79;
            // 
            // toolBarStandar
            // 
            this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbAnterior,
            this.tbbSeparator,
            this.tbbSiguiente,
            this.toolBarButton1,
            this.toolBarButton2});
            this.toolBarStandar.DropDownArrows = true;
            this.toolBarStandar.ImageList = this.imglStandar;
            this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
            this.toolBarStandar.Name = "toolBarStandar";
            this.toolBarStandar.ShowToolTips = true;
            this.toolBarStandar.Size = new System.Drawing.Size(916, 28);
            this.toolBarStandar.TabIndex = 47;
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
            this.tbbSiguiente.Text = "Siguiente";
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.ImageIndex = 10;
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.Text = "[F2] Buscar ahora";
            // 
            // toolTip
            // 
            this.toolTip.ShowAlways = true;
            // 
            // mzCuentasObservacionesSearchForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(916, 526);
            this.Controls.Add(this.toolBarStandar);
            this.Controls.Add(this.tabControl1);
            this.Name = "mzCuentasObservacionesSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mzCuentasSearchForm";
            this.ultraExplorerBarContainerControl1.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaSubTipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uccFechaHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uccFechaDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbTipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbEstados)).EndInit();
            this.ultraExplorerBarContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
            this.ultraExplorerBarContainerControl3.ResumeLayout(false);
            this.ultraExplorerBarContainerControl3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
            this.ultraExplorerBar1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        /* Silvina 20100923 - Tarea 843 */
        #region Miembros de ISearchObjectListener
        public void processEventChange(object sender, EventArgs e)
        {
        }

        #endregion
        /* Fin Silvina */

		#region Constructores y Destructores		
		public mzCuentasObservacionesSearchForm(string Tipo)
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			_uiController.Origen = "GENERAL"; //Entro a la pantalla y muestro columna de cliente.	
			_tipo = Tipo;
			_uiController.Tipo = Tipo;
			_uiController.Init();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}
		public mzCuentasObservacionesSearchForm(string Id,  string Tipo)
		{ //boton derecho
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			_tipo = Tipo;
			_uiController.Init();
			_uiController.Tipo = Tipo;
			if(Tipo.Equals("CUENTA") )
				_idCuenta = Id;		
			else
				_idProveedor = Id;
				

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		public mzCuentasObservacionesSearchForm(string Id,  string Codigo, string Tipo)
		{ 
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
            _tipo = Tipo;
            //Cristian Tarea 850
            _uiController.Tipo = Tipo;
            //Fin Tarea 850
			_uiController.Init();
		
			if(Tipo.Equals("CUENTA") )
			{
				_idCuenta = Id;		
				_codigoCuenta = Codigo;
			}
			else 
			{
				_idProveedor = Id;
				_codigoProveedor = Codigo;
			}

		}

		public mzCuentasObservacionesSearchForm(mz.erp.ui.controllers.mzCuentasObservacionesSearchFormController controller)
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//			
			InitializeComponent();
			_uiController = controller;	
			_uiController.Origen = "GENERAL"; //Entro a la pantalla y muestro columna de cliente.				
			_isProcess = true;

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}


		/*public mzCuentasSearchForm(bool CierreAutomatico)
		{
			_cierreAutomatico = CierreAutomatico;
			InitializeComponent();
		}*/

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
		
		#region Variables privadas
		private bool _cierreAutomatico = true;
		private string _idCuenta = String.Empty;
		private string _codigoCuenta = String.Empty;
		private string _observacion = String.Empty;		
		private bool _isProcess = false;
		private string _idProveedor = String.Empty;
		private string _codigoProveedor = String.Empty;
		private string _tipo;
		
		#endregion
		#region Propiedades públicas
		#endregion
		#endregion

		#region Custom Members
		private mzCuentasObservacionesSearchFormController _uiController = new mzCuentasObservacionesSearchFormController();
		public virtual void ShowDialog()
		{
			Init();
			base.ShowDialog();			
		}

		#region Miembros de ITaskForm
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

		public void KeyDownPrevious()
		{
			this.Previous();
		}

		public void KeyDownNext()
		{
			this.Execute();
		}

		public void Execute()
		{			
			if (gridResultado.SelectedItems.Count > 0)
			{
				if(_isProcess)
				{
					string Proceso = _uiController.GetProcessManager().GetProcessName();
					if(Proceso.Equals("ProcesoEditarCuentasObservaciones"))
						_uiController.IdCuentaObservacion = Convert.ToString( gridResultado.SelectedItems[0].GetRow().Cells["IdCuentaObservacion"].Value);
					else if(Proceso.Equals("ProcesoEditarProveedoresObservaciones"))
						_uiController.IdProveedorObservacion = Convert.ToString( gridResultado.SelectedItems[0].GetRow().Cells["IdProveedorObservacion"].Value);
				}
				else
				{
					if(_tipo.Equals("CUENTA"))
						_uiController.IdCuentaObservacion = Convert.ToString( gridResultado.SelectedItems[0].GetRow().Cells["IdCuentaObservacion"].Value);
					else
						_uiController.IdProveedorObservacion = Convert.ToString( gridResultado.SelectedItems[0].GetRow().Cells["IdProveedorObservacion"].Value);
				}

			
			}
			this._uiController.Execute();
		}

		public void Previous()
		{
			this._uiController.Previous();
		}

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

		private string _selectedValue = string.Empty;
		private string _selectedDescription = string.Empty;
		private System.Data.DataRow _datarow = null;
		#region Métodos privados
		public string SelectedValue
		{
			get { return _selectedValue ; }
		}
		public string SelectedDescription
		{
			get { return _selectedDescription; }
		}

		public System.Data.DataRow SelectedRow
		{
			get{ return _datarow; }
		}
		#endregion

		private void ConfigureInterface()
		{
			//Cristian Configuracion imageList
            utility.Util.LoadImages(toolBarStandar,imglStandar);
            this.toolBarButton2.ImageIndex = 12;
            //Fin Cristian
            this.mzCmbUsuarios.FillFromDataSource( _uiController.Usuarios, _uiController.KeyValueUsuarios,_uiController.KeyListUsuarios,100, _uiController.KeyListUsuarios );
			this.htmlRichTextBox1.ReadOnly = true;						
			this.mzCmbCuenta.Enabled = _uiController.ByCuenta;
            /* Silvina 20100923 - Tarea 843 */
            mzCmbProveedor.Init();
            mzCmbProveedor.SearchObjectListener = this;
            mzCmbProveedor.Enabled = _uiController.ByCuenta;
            /* Fin Silvina */
			//this.mzCmbUsuarios.Enabled=_uiController.
			/*PARA Q EL COMBO DE USUARIOS TENGA SELECCIONADO EL USUARIO ACTUAL, NO SE HACE ACA SINO EN EL CONTROLLER DADO Q ESTA BINGDEADO, VER InitDataBindings(), SE CAMBIA EN EL CONTROLLER EL VALOR POR DEFECTO DE LA PROPIEDAD CON LA Q SE HACE BINDING*/
			_uiController.IdCuenta = _idCuenta;
			_uiController.IdProveedor = _idProveedor;
			_uiController.CodigoCuenta = _codigoCuenta;
			_uiController.CodigoProveedor = _codigoProveedor;
			_uiController.GetCuenta();
			if (!_uiController.PermiteObservacionesOtrosUser)
				this.mzCmbUsuarios.Enabled=false;

			if (_uiController.Origen == "GENERAL")
			{
                //Cristian Tarea 860
                if (_uiController.Tipo.Equals("PROVEEDOR"))
                {
                    this.Text = "Observaciones de Proveedores";
                }
                else { this.Text = "Observaciones de Clientes"; }
				//Fin Tarea 860

                //				ultraExplorerBarContainerControl1.Height = 79;				
			}
			else 
			{
				this.Text = String.Format("Observaciones - {0}", _uiController.Nombre);

				mzCmbCuenta.Enabled = false;
				//ultraExplorerBarContainerControl1.Height = 55;
			}

			if (_isProcess)
			{
				tbbAnterior.Visible = true;
				tbbSiguiente.Visible = true;
				tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();			
				tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
				string Proceso = _uiController.GetProcessManager().GetProcessName();
				if(Proceso.Equals("ProcesoEditarCuentasObservaciones"))
				{
					label1.Text = "Cuenta";
					
					this.mzCmbEstados.FillFromDataSource( _uiController.Estados, _uiController.KeyValueEstados,_uiController.KeyListEstados,100, _uiController.KeyListEstados );
					this.mzCmbTipos.FillFromDataSource( _uiController.Tipos, _uiController.KeyValueTipos,_uiController.KeyListTipos,100, _uiController.KeyListTipos );		
					this.gridResultado.LayoutData = _uiController.GetLayout(_idCuenta == String.Empty);
                    /* Silvina 20100923 - Tarea 843 */
                    mzCmbProveedor.Visible = false;
                    mzCmbCuenta.Visible = true;
                    /* Fin Silvina 20100923 - Tarea 843 */
				}
				else if(Proceso.Equals("ProcesoEditarProveedoresObservaciones"))
				{
					label1.Text = "Proveedor";
					mzCmbEstados.FillFromDataSource( _uiController.Estados, _uiController.KeyValueEstadosProveedores,_uiController.KeyListEstados,100, _uiController.KeyListEstados );
					mzCmbTipos.FillFromDataSource( _uiController.Tipos, _uiController.KeyValueTiposProveedores,_uiController.KeyListTipos,100, _uiController.KeyListTipos );
					this.gridResultado.LayoutData = _uiController.GetLayoutProveedores(_idProveedor == String.Empty);
                    /* Silvina 20100923 - Tarea 843 */
                    mzCmbProveedor.Visible = true;
                    mzCmbCuenta.Visible = false;
                    /* Fin Silvina */

				}

			}
			else 
			{
				tbbAnterior.Visible = false;
				tbbSiguiente.Visible = false;
				if(_tipo.Equals("CUENTA"))
				{
					label1.Text = "Cuenta";
					mzCmbCuenta.SearchObject = typeof( mz.erp.ui.forms.classes.tsa_Cuentas );
					this.mzCmbEstados.FillFromDataSource( _uiController.Estados, _uiController.KeyValueEstados,_uiController.KeyListEstados,100, _uiController.KeyListEstados );
					this.mzCmbTipos.FillFromDataSource( _uiController.Tipos, _uiController.KeyValueTipos,_uiController.KeyListTipos,100, _uiController.KeyListTipos );		
					this.gridResultado.LayoutData = _uiController.GetLayout(_idCuenta == String.Empty);
                    /* Silvina 20100923 - Tarea 843 */
                    mzCmbProveedor.Visible = false;
                    mzCmbCuenta.Visible = true;
                    /* Fin Silvina 20100923 - Tarea 843 */
				}
				else
				{
					label1.Text = "Proveedor";
					mzCmbCuenta.SearchObject = typeof( mz.erp.ui.forms.classes.tpu_Proveedores );
					mzCmbEstados.FillFromDataSource( _uiController.Estados, _uiController.KeyValueEstadosProveedores,_uiController.KeyListEstados,100, _uiController.KeyListEstados );
					mzCmbTipos.FillFromDataSource( _uiController.Tipos, _uiController.KeyValueTiposProveedores,_uiController.KeyListTipos,100, _uiController.KeyListTipos );
					this.gridResultado.LayoutData = _uiController.GetLayoutProveedores(_idProveedor == String.Empty);
                    /* Silvina 20100923 - Tarea 843 */
                    mzCmbProveedor.Visible = true;
                    mzCmbCuenta.Visible = false;
                    /* Fin Silvina 20100923 - Tarea 843 */
				}

			}

            /* Silvina 20110608 - Tarea 0000065 */

            Infragistics.Win.UltraWinEditors.DropDownEditorButton b = new Infragistics.Win.UltraWinEditors.DropDownEditorButton(); //Dropdown Editor Button
            b.Control = grillaSubTipos; 
            txtSubTipos.ButtonsRight.Add(b);
            txtSubTipos.ReadOnly = true;

            /* Fin Silvina 20110608 - Tarea 0000065 */
			gridManagerView1.Configure(_uiController.Proceso, _uiController.Tarea, gridResultado, this.Text);
			this.KeyPreview = true;

			gridResultado.RecordNavigator = true;
		}

		

		private void InitializeData()
		{						
			if (_uiController.Origen == "GENERAL")
			{
				if (_isProcess)
				{
					string Proceso = _uiController.GetProcessManager().GetProcessName();
					if(Proceso.Equals("ProcesoEditarCuentasObservaciones"))
						mzCmbCuenta.DataValue = _uiController.CodigoCuenta;
					else if(Proceso.Equals("ProcesoEditarProveedoresObservaciones"))
						mzCmbCuenta.DataValue = _uiController.CodigoProveedor;
				}
				else
				{
					if(_tipo.Equals("CUENTA") )
					{
						mzCmbCuenta.DataValue = _uiController.CodigoCuenta;
						//this.gridResultado.LayoutData = _uiController.GetLayout(_idCuenta == String.Empty);	

					}
					else
                        /* Silvina 20100916 - Tarea 839 */
                        //mzCmbCuenta.DataValue = _uiController.CodigoProveedor;
                        mzCmbProveedor.DataValue = _uiController.CodigoProveedor;
                        /* Fin Silvina */
				}
			}		
			else
			{
				if(_tipo.Equals("CUENTA") )
				{
					mzCmbCuenta.DataValue = _uiController.CodigoCuenta;
				}
				else
					mzCmbCuenta.DataValue = _uiController.CodigoProveedor;
			}
		}

		private void InitEventHandlers()
		{
			_uiController.DataSearchChanged+= new System.EventHandler( this.OnGeneralChangesListener );
			_uiController.TiposHasChanged+=new EventHandler(_uiController_TiposHasChanged);
			_uiController.CodigoCuentaChanged+=new EventHandler(_uiController_CodigoCuentaChanged);			
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			this.Closed +=new EventHandler(mzCuentasSearchForm_Closed);
			this.gridResultado.Click+=new EventHandler(gridResultado_Click);
			this.gridResultado.SelectionChanged+=new EventHandler(gridResultado_Click);
			this.KeyDown+=new KeyEventHandler(mzCuentasSearchForm_KeyDown);						
			this.chkFiltroFechas.Click+=new EventHandler(chkFiltroFechas_Click);				
			this.chkFiltroCuenta.Click+=new EventHandler(chkFiltroCuenta_Click);
			_uiController.CodigoCuentaChanged+=new EventHandler(_uiController_CodigoCuentaChanged);		
            /* Silvina 20100923 - Tarea 843 */
			//_uiController.CodigoProveedorChanged +=new EventHandler(_uiController_CodigoProveedorChanged);	
	        /* Fin Silvina */

			if (_uiController.Origen == "GENERAL")
			{				
				if (_isProcess)
				{
					string Proceso = _uiController.GetProcessManager().GetProcessName();
					if(Proceso.Equals("ProcesoEditarCuentasObservaciones"))
					{
						mzCmbCuenta.SearchObject = typeof(  mz.erp.ui.forms.classes.tsa_Cuentas  );
						mzCmbCuenta.EditObject = typeof(mz.erp.ui.forms.FrmAbmCuentas);
					}
					else if(Proceso.Equals("ProcesoEditarProveedoresObservaciones"))
					{
                        /* Silvina 20100923 - Tarea 843 */
                        //mzCmbCuenta.SearchObject = typeof(mz.erp.ui.forms.classes.tpu_Proveedores);
                        //mzCmbCuenta.EditObject = typeof(mz.erp.ui.forms.FrmAbmProveedores);
                        mzCmbProveedor.ValueChanged += new EventHandler(mzCmbProveedor_ValueChanged);
                        /* Fin Silvina */
					}
				}
				else
				{
					if(_tipo.Equals("CUENTA"))
					{
						mzCmbCuenta.SearchObject = typeof(  mz.erp.ui.forms.classes.tsa_Cuentas  );
						mzCmbCuenta.EditObject = typeof(mz.erp.ui.forms.FrmAbmCuentas);
					}
					else
					{
                        /* Silvina 20100923 - Tarea 843 */
						//mzCmbCuenta.SearchObject = typeof(  mz.erp.ui.forms.classes.tpu_Proveedores);
						//mzCmbCuenta.EditObject = typeof(mz.erp.ui.forms.FrmAbmProveedores);
                        mzCmbProveedor.ValueChanged += new EventHandler(mzCmbProveedor_ValueChanged);
                        /* Fin Silvina */
					}

				}
			}
			KeyDownManager KeyDownMan = new KeyDownManager(this);	
		    //Cristian Tarea 0000050 20110310
            this.uccFechaDesde.ValueChanged += new EventHandler(FechaDesde_ValueChanged);
            //Fin Cristian
            /* Silvina 20110608 - Tarea 0000065 */
            txtSubTipos.AfterEditorButtonCloseUp += new Infragistics.Win.UltraWinEditors.EditorButtonEventHandler(txtSubTipos_AfterEditorButtonCloseUp);
            /* Fin Silvina 20110608 - Tarea 0000065 */
        //Cristian Tarea 0000050 20110310
            this.uccFechaHasta.ValueChanged += new EventHandler(uccFechaHasta_ValueChanged);
        }

        void uccFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(uccFechaHasta.Value)),true);
            this.uccFechaDesde.Value = _uiController.FechaDesde;
        }
        //Fin Cristian tArea 0000146

        /* Silvina 20110608 - Tarea 0000065 */
        void txtSubTipos_AfterEditorButtonCloseUp(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            this.txtSubTipos.Text = string.Empty;
            DataTable aux = (DataTable)grillaSubTipos.DataSource;
            foreach (DataRow row in aux.Rows)
            {
                if (Convert.ToBoolean(row["Activo"]))
                {
                    if ((row["Descripcion"].ToString().Equals("Todos")))
                    {
                        this.txtSubTipos.Text = "Todos";
                        break;
                    }
                    else
                        this.txtSubTipos.Text = this.txtSubTipos.Text + row["Descripcion"].ToString() + ',';
                }
            }
        }

        private void ConfigurarGrillaSubtipos()
        {
            grillaSubTipos.DisplayLayout.Bands[0].Columns[0].ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;

            grillaSubTipos.DisplayLayout.Bands[0].Columns[0].EditorControl = this.txtSubTipos;
            grillaSubTipos.DisplayLayout.Bands[0].Columns[0].Hidden = true;
            grillaSubTipos.DisplayLayout.Bands[0].Columns[1].Hidden = true;
            grillaSubTipos.DisplayLayout.Bands[0].Columns[2].Hidden = true;
            grillaSubTipos.DisplayLayout.Bands[0].Columns[3].Hidden = true;
            grillaSubTipos.DisplayLayout.Bands[0].Columns[4].Hidden = true;
            grillaSubTipos.DisplayLayout.Bands[0].Columns[5].Hidden = true;
            grillaSubTipos.DisplayLayout.Bands[0].Columns[6].Hidden = true;
            grillaSubTipos.DisplayLayout.Bands[0].Columns[7].Hidden = true;
            grillaSubTipos.DisplayLayout.Bands[0].Columns[8].Hidden = true;
            grillaSubTipos.DisplayLayout.Bands[0].Columns[9].Hidden = true;
            grillaSubTipos.DisplayLayout.Bands[0].Columns[10].Hidden = true;
            grillaSubTipos.DisplayLayout.Bands[0].Columns[11].Hidden = true;
            grillaSubTipos.DisplayLayout.Bands[0].Columns["Descripcion"].Hidden = false;
            grillaSubTipos.DisplayLayout.Bands[0].Columns["Activo"].Hidden = false;
            grillaSubTipos.DisplayLayout.Bands[0].ColHeadersVisible = false;
            grillaSubTipos.DisplayLayout.Bands[0].Columns["Descripcion"].CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            grillaSubTipos.DisplayLayout.Bands[0].Columns["Descripcion"].Width = 140;
            grillaSubTipos.DisplayLayout.Bands[0].Columns["Activo"].Width = 25;
        }
        /* Fin Silvina 20110608 - Tarea 0000065 */

        //Cristian Tarea 0000050 20110310
        void FechaDesde_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(uccFechaDesde.Value)),false);
            this.uccFechaHasta.Value = _uiController.FechaHasta;

        }
        //Fin Cristian
	

        /* Silvina 20100923 - Tarea 843 */
        private void mzCmbProveedor_ValueChanged(object sender, EventArgs e)
        {
            _uiController.CodigoProveedor = (string)mzCmbProveedor.DataValue;
       }
        /* Fin Silvina */

		private void InitDataBindings()
		{			
			if (_isProcess)
			{

				string Proceso = _uiController.GetProcessManager().GetProcessName();
				if (_uiController.Origen == "GENERAL")
				{
					if(Proceso.Equals("ProcesoEditarCuentasObservaciones"))
						BindingController.Bind(mzCmbCuenta, "DataValue", _uiController, "CodigoCuenta");
                    /* Silvina 20100923 - Tarea 843*/
					/*else if(Proceso.Equals("ProcesoEditarProveedoresObservaciones"))
						BindingController.Bind(mzCmbCuenta, "DataValue", _uiController, "CodigoProveedor");*/
                    /* Fin Silvina */
				}			
			}
			else
			{
				if(_tipo.Equals("CUENTA") )
					BindingController.Bind(mzCmbCuenta, "DataValue", _uiController, "CodigoCuenta");
                /* Silvina 20100923 - Tarea 843*/
				/*else
					BindingController.Bind(mzCmbCuenta, "DataValue", _uiController, "IdProveedor");*/
                /* Fin Silvina */
			}
			BindingController.Bind(mzCmbEstados,"Value", _uiController, "IdEstado");
			BindingController.Bind(mzCmbTipos,"Value", _uiController, "IdTipo");
			BindingController.Bind(mzCmbUsuarios,"Value", _uiController, "IdUsuario");
			BindingController.Bind(uccFechaDesde,"Value", _uiController, "FechaDesde");
			BindingController.Bind(uccFechaHasta,"Value", _uiController, "FechaHasta");		
			BindingController.Bind(chkFiltroFechas, "Checked", _uiController, "ByFechas");			
			BindingController.Bind(chkFiltroCuenta, "Checked", _uiController, "ByCuenta");
			BindingController.Bind(chkVerAvisosPendientes, "Checked", _uiController, "VerAvisosPendientes");
		}
		private void FillControls() 
		{
			this.chkFiltroFechas_Click(this, new System.EventArgs());									
			if (_uiController.IdTipoDefault != String.Empty)
				this.mzCmbTipos.SetValue(Convert.ToString(_uiController.IdTipoDefault));

			/*if (_uiController.Origen == "GENERAL" && _uiController.PermiteObservacionesOtrosUser)
				this.mzCmbUsuarios.SetValue(Convert.ToString(""));*/
			if (_uiController.PermiteObservacionesOtrosUser)
				this.mzCmbUsuarios.SetValue(Convert.ToString(""));

		}
	
		private void OnGeneralChangesListener( object sender, System.EventArgs e)
		{
			this.gridResultado.SetDataBinding( null, null );
			this.gridResultado.SetDataBinding( _uiController.DataSearch, null );
			this.gridResultado.Refetch();
			this.gridResultado.Refresh();
			if (gridManagerView1.AllowExportExcel || gridManagerView1.AllowSortByAgregateColumn)
				gridManagerView1.SetView(_uiController.DataSearch);
		}
		#endregion



		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					this.Previous();
					break;				
				case 2:					
					this.Execute();
					break;
				case 4:
					this.SearchNow();
					break;
			}
		}

		private void SearchNow()
		{						
			Util.MoveFocus(this.ultraExplorerBarContainerControl1);
			this.Cursor = Cursors.WaitCursor;
            /* Silvina 20110608 - Tarea 0000065 */
            if (txtSubTipos.Text.Equals("Todos"))
                _uiController.IdSubTipo = string.Empty;
            else
            {
                string subTipos = string.Empty;
                DataTable aux = (DataTable)grillaSubTipos.DataSource;
                foreach (DataRow row in aux.Rows)
                {
                    if (Convert.ToBoolean(row["Activo"]))
                    {
                        if (_tipo.Equals("PROVEEDOR"))
                            subTipos = subTipos + ',' + row["IdProveedorObservacionTipo"].ToString();
                        else
                            subTipos = subTipos + ',' + row["IdCuentaObservacionTipo"].ToString();
                    }
                }
                if (subTipos.Length > 0)
                    subTipos = subTipos.Remove(0, 1);
                _uiController.IdSubTipo = subTipos;
            }
            /* Fin Silvina 20110608 - Tarea 0000065 */
			_uiController.BuscarAhora();
			gridResultado.Enabled = (gridResultado.RecordCount != 0);
			if (gridManagerView1.AllowGroupCollapse)
				this.gridResultado.CollapseGroups();
			else
				if (gridResultado.RootTable.Groups.Count > 0 )
				gridResultado.RootTable.Groups[0].Expand();
			this.Cursor = Cursors.Default;

			
		}
		private void mzCuentasSearchForm_Closed(object sender, EventArgs e)
		{
			ClearDataBindings();
			ClearEventHandlers();
		}
		private void ClearDataBindings()
		{						
			if (_uiController.Origen == "GENERAL")
			{
				mzCmbCuenta.DataBindings.Clear();	
			}	
			BindingController.Clear(mzCmbEstados,"Value", _uiController, "IdEstado");
			BindingController.Clear(mzCmbTipos,"Value", _uiController, "IdTipo");
			BindingController.Clear(mzCmbUsuarios,"Value", _uiController, "IdUsuario");
			BindingController.Clear(uccFechaDesde,"Value", _uiController, "FechaDesde");
			BindingController.Clear(uccFechaHasta,"Value", _uiController, "FechaHasta");		
			BindingController.Clear(chkFiltroFechas, "Checked", _uiController, "ByFechas");
			
		}
		private void ClearEventHandlers()
		{			
			this.Closed -=new EventHandler(mzCuentasSearchForm_Closed);						
			this.gridResultado.Click+=new EventHandler(gridResultado_Click);
			this.gridResultado.SelectionChanged+=new EventHandler(gridResultado_Click);
			this.toolBarStandar.ButtonClick -= new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			_uiController.DataSearchChanged-= new System.EventHandler( this.OnGeneralChangesListener );			
			_uiController.CodigoCuentaChanged+=new EventHandler(_uiController_CodigoCuentaChanged);			
		}
		
		private void _uiController_TiposHasChanged(object sender, EventArgs e)
		{
            /* Silvina 20110608 - Tarea 0000065 */
            /*if(_isProcess)
            {
                string Proceso = _uiController.GetProcessManager().GetProcessName();
                if (Proceso.Equals("ProcesoEditarCuentasObservaciones"))
                {
                    //mzCmbSubTipos.FillFromDataSource(_uiController.SubTipos, _uiController.KeyValueTipos, _uiController.KeyListTipos, 100, _uiController.KeyListTipos);
                }
                else if (Proceso.Equals("ProcesoEditarProveedoresObservaciones"))
                    mzCmbSubTipos.FillFromDataSource(_uiController.SubTipos, _uiController.KeyValueTiposProveedores, _uiController.KeyListTipos, 100, _uiController.KeyListTipos);
            }
            else
            {
                if(_tipo.Equals("CUENTA") )
                    mzCmbSubTipos.FillFromDataSource( _uiController.SubTipos, _uiController.KeyValueTipos,_uiController.KeyListTipos,100, _uiController.KeyListTipos );
                else
                    mzCmbSubTipos.FillFromDataSource( _uiController.SubTipos, _uiController.KeyValueTiposProveedores,_uiController.KeyListTipos,100, _uiController.KeyListTipos );
            } */
            grillaSubTipos.DataSource = _uiController.SubTipos;
            txtSubTipos.Text = "Todos";
            ConfigurarGrillaSubtipos();
            try 
			{
				if (mzCmbTipos.Value != null) 
				{														
					if (_uiController.CantidadSubTipos <= 1) 
					{
                        txtSubTipos.Enabled = false;
                        //this.mzCmbSubTipos.Enabled = false;
					}
					else 
					{
                        txtSubTipos.Enabled = true;
                        //this.mzCmbSubTipos.Enabled = true;				
					}
				}
			}
            /* Fin Silvina 20110608 - Tarea 0000065 */
			catch{}
		}
		private void gridResultado_Click(object sender, EventArgs e)
		{
			ChangeDatos();
		}
		private void ChangeDatos()
		{
			if (gridResultado.SelectedItems.Count == 1 &&
				this.gridResultado.SelectedItems[0].GetRow().RowType == Janus.Windows.GridEX.RowType.Record
				)
			{				
				string Observacion = (string)gridResultado.SelectedItems[0].GetRow().Cells["Observacion"].Value;			
				if (_observacion != Observacion)
				{
					this.htmlRichTextBox1.Clear();					
					//this.htmlRichTextBox1.Rtf. = Observacion;
					this.htmlRichTextBox1.AddHTML(Observacion);
				}				
			}
			if (gridResultado.SelectedItems.Count == 0)
			{							
					this.htmlRichTextBox1.Clear();	
			}			
		}

		private void mzCuentasSearchForm_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyData) 
			{
				case System.Windows.Forms.Keys.F2: 
					this.SearchNow();
					break;
				case System.Windows.Forms.Keys.Escape :
					this.Close();
					break;
				default:
					break;
			}
		}

		private void chkFiltroFechas_Click(object sender, EventArgs e)
		{			
			uccFechaDesde.Enabled = chkFiltroFechas.Checked;
			uccFechaHasta.Enabled = chkFiltroFechas.Checked;
			if (chkFiltroFechas.Checked)
			{
				_uiController.FechaDesde = Convert.ToDateTime(uccFechaDesde.Value);
				_uiController.FechaHasta = Convert.ToDateTime(uccFechaHasta.Value);
			}
		}

		private void chkFiltroCuenta_Click(object sender, EventArgs e)
		{
			mzCmbCuenta.Enabled = chkFiltroCuenta.Checked;
		}

		private void _uiController_CodigoCuentaChanged(object sender, EventArgs e)
		{
			this.gridResultado.SetDataBinding( null, null );
			this.htmlRichTextBox1.Clear();	
		}
		private void _uiController_CodigoProveedorChanged(object sender, EventArgs e)
		{
			this.gridResultado.SetDataBinding( null, null );
			this.htmlRichTextBox1.Clear();
		}


		private void toolBarStandar_ButtonClick_1(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
		
		}

	}
}

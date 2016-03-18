using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.commontypes;
using mz.erp.ui.forms.classes;
using mz.erp.ui.utility;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmConsultaVentas.
	/// </summary>
	public class FrmConsultaVentas : System.Windows.Forms.Form, ITaskForm, ISearchObjectListener
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


		//private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.Label labelTarea;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ContainerFiltro;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		protected Janus.Windows.GridEX.GridEX gridResultado;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblTarea;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ContainerJerarquias;		
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ContainerJerarquiasClientes;
		private System.Windows.Forms.ToolBarButton tbbSeparadorImprimir;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton tbbImprimir;		
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;		
		private System.Windows.Forms.ComboBox cboTiposDeComprobantes;				
		private System.Windows.Forms.Label label9;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo FechaDesde;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo FechaHasta;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit txtNumeroDesde;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit txtNumeroHasta;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox chkEntreFechas;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;		
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem Detalles;
		private mz.erp.ui.controls.mzCuentasControl mzCmbCuenta;
		private mz.erp.ui.controls.HierarchicalSearchControl hierarchicalSearchControl1;

		private mz.erp.ui.controls.HierarchicalSearchControl hierarchicalSearchControlClientes;

		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private HtmlRichText.HtmlRichTextBox richInfoComprobante;
		private System.ComponentModel.IContainer components;
		private mz.erp.ui.controls.mzProductosControl mzProductosControl1;
		private System.Windows.Forms.ToolBarButton tbbReiniciarFiltros;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
        private ToolBarButton tbbSeparadorTicketDeCambio;
        private ToolBarButton tbbImprimirTicketDeCambio;
        private controls.mzComboEditor mzCEResponsableEmision;

		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControlClientes;


		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton3 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton4 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup6 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.lblTarea = new System.Windows.Forms.Label();
            this.ContainerFiltro = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.mzCEResponsableEmision = new mz.erp.ui.controls.mzComboEditor();
            this.mzCmbCuenta = new mz.erp.ui.controls.mzCuentasControl();
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
            this.ContainerJerarquias = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.mzProductosControl1 = new mz.erp.ui.controls.mzProductosControl();
            this.hierarchicalSearchControl1 = new mz.erp.ui.controls.HierarchicalSearchControl();
            this.label9 = new System.Windows.Forms.Label();
            this.ContainerJerarquiasClientes = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.hierarchicalSearchControlClientes = new mz.erp.ui.controls.HierarchicalSearchControl();
            this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.gridResultado = new Janus.Windows.GridEX.GridEX();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.Detalles = new System.Windows.Forms.MenuItem();
            this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
            this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.richInfoComprobante = new HtmlRichText.HtmlRichTextBox();
            this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.labelTarea = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.imglStandar = new System.Windows.Forms.ImageList(this.components);
            this.toolBarStandar = new System.Windows.Forms.ToolBar();
            this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
            this.tbbConsultar = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.tbbReiniciarFiltros = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator3 = new System.Windows.Forms.ToolBarButton();
            this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparadorImprimir = new System.Windows.Forms.ToolBarButton();
            this.tbbImprimir = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparadorTicketDeCambio = new System.Windows.Forms.ToolBarButton();
            this.tbbImprimirTicketDeCambio = new System.Windows.Forms.ToolBarButton();
            this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.ultraExplorerBarContainerControl4.SuspendLayout();
            this.ContainerFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEResponsableEmision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaHasta)).BeginInit();
            this.ContainerJerarquias.SuspendLayout();
            this.ContainerJerarquiasClientes.SuspendLayout();
            this.ultraExplorerBarContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
            this.ultraExplorerBarContainerControl5.SuspendLayout();
            this.ultraExplorerBarContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
            this.ultraExplorerBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraExplorerBarContainerControl4
            // 
            this.ultraExplorerBarContainerControl4.Controls.Add(this.lblTarea);
            this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, 24);
            this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
            this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(908, 40);
            this.ultraExplorerBarContainerControl4.TabIndex = 2;
            // 
            // lblTarea
            // 
            this.lblTarea.BackColor = System.Drawing.Color.Transparent;
            this.lblTarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarea.Location = new System.Drawing.Point(0, 0);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(908, 23);
            this.lblTarea.TabIndex = 2;
            this.lblTarea.Text = "Tarea";
            this.lblTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContainerFiltro
            // 
            this.ContainerFiltro.Controls.Add(this.mzCEResponsableEmision);
            this.ContainerFiltro.Controls.Add(this.mzCmbCuenta);
            this.ContainerFiltro.Controls.Add(this.chkEntreFechas);
            this.ContainerFiltro.Controls.Add(this.label3);
            this.ContainerFiltro.Controls.Add(this.txtNumeroHasta);
            this.ContainerFiltro.Controls.Add(this.txtNumeroDesde);
            this.ContainerFiltro.Controls.Add(this.cboTiposDeComprobantes);
            this.ContainerFiltro.Controls.Add(this.label7);
            this.ContainerFiltro.Controls.Add(this.label2);
            this.ContainerFiltro.Controls.Add(this.label5);
            this.ContainerFiltro.Controls.Add(this.label1);
            this.ContainerFiltro.Controls.Add(this.FechaDesde);
            this.ContainerFiltro.Controls.Add(this.label6);
            this.ContainerFiltro.Controls.Add(this.FechaHasta);
            this.ContainerFiltro.Location = new System.Drawing.Point(28, 123);
            this.ContainerFiltro.Name = "ContainerFiltro";
            this.ContainerFiltro.Size = new System.Drawing.Size(908, 149);
            this.ContainerFiltro.TabIndex = 0;
            // 
            // mzCEResponsableEmision
            // 
            this.mzCEResponsableEmision.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEResponsableEmision.DisplayMember = "";
            this.mzCEResponsableEmision.DisplayMemberCaption = "";
            this.mzCEResponsableEmision.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEResponsableEmision.Location = new System.Drawing.Point(136, 72);
            this.mzCEResponsableEmision.MaxItemsDisplay = 8;
            this.mzCEResponsableEmision.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEResponsableEmision.Name = "mzCEResponsableEmision";
            this.mzCEResponsableEmision.Size = new System.Drawing.Size(336, 21);
            this.mzCEResponsableEmision.SorterMember = "";
            this.mzCEResponsableEmision.TabIndex = 118;
            this.mzCEResponsableEmision.ValueMember = "";
            this.mzCEResponsableEmision.ValueMemberCaption = "";
            // 
            // mzCmbCuenta
            // 
            this.mzCmbCuenta.AllowEditClientePaso = false;
            this.mzCmbCuenta.BackColor = System.Drawing.SystemColors.Control;
            this.mzCmbCuenta.DataValue = "";
            this.mzCmbCuenta.EnableCtaCte = false;
            this.mzCmbCuenta.FastSearch = false;
            this.mzCmbCuenta.Location = new System.Drawing.Point(136, 0);
            this.mzCmbCuenta.Name = "mzCmbCuenta";
            this.mzCmbCuenta.ReseteaCodCta = false;
            this.mzCmbCuenta.SearchObjectListener = null;
            this.mzCmbCuenta.Size = new System.Drawing.Size(512, 22);
            this.mzCmbCuenta.TabIndex = 0;
            // 
            // chkEntreFechas
            // 
            this.chkEntreFechas.BackColor = System.Drawing.Color.Transparent;
            this.chkEntreFechas.Location = new System.Drawing.Point(344, 120);
            this.chkEntreFechas.Name = "chkEntreFechas";
            this.chkEntreFechas.Size = new System.Drawing.Size(16, 20);
            this.chkEntreFechas.TabIndex = 7;
            this.chkEntreFechas.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(8, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 117;
            this.label3.Text = "Número";
            // 
            // txtNumeroHasta
            // 
            this.txtNumeroHasta.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.txtNumeroHasta.Location = new System.Drawing.Point(240, 120);
            this.txtNumeroHasta.Name = "txtNumeroHasta";
            this.txtNumeroHasta.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroHasta.TabIndex = 6;
            this.txtNumeroHasta.Text = "--";
            // 
            // txtNumeroDesde
            // 
            this.txtNumeroDesde.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.txtNumeroDesde.Location = new System.Drawing.Point(136, 120);
            this.txtNumeroDesde.Name = "txtNumeroDesde";
            this.txtNumeroDesde.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDesde.TabIndex = 5;
            this.txtNumeroDesde.Text = "--";
            // 
            // cboTiposDeComprobantes
            // 
            this.cboTiposDeComprobantes.Location = new System.Drawing.Point(136, 96);
            this.cboTiposDeComprobantes.Name = "cboTiposDeComprobantes";
            this.cboTiposDeComprobantes.Size = new System.Drawing.Size(336, 21);
            this.cboTiposDeComprobantes.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(8, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 21);
            this.label7.TabIndex = 114;
            this.label7.Text = "Fecha Inicio";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(8, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 113;
            this.label2.Text = "Responsable de emisión";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(8, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 111;
            this.label5.Text = "Tipos de comprobantes";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 110;
            this.label1.Text = "Cuenta";
            // 
            // FechaDesde
            // 
            this.FechaDesde.BackColor = System.Drawing.SystemColors.Window;
            this.FechaDesde.DateButtons.Add(dateButton3);
            this.FechaDesde.Location = new System.Drawing.Point(136, 24);
            this.FechaDesde.Name = "FechaDesde";
            this.FechaDesde.NonAutoSizeHeight = 23;
            this.FechaDesde.Size = new System.Drawing.Size(96, 21);
            this.FechaDesde.TabIndex = 1;
            this.FechaDesde.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(8, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha Fin";
            // 
            // FechaHasta
            // 
            this.FechaHasta.BackColor = System.Drawing.SystemColors.Window;
            this.FechaHasta.DateButtons.Add(dateButton4);
            this.FechaHasta.Location = new System.Drawing.Point(136, 48);
            this.FechaHasta.Name = "FechaHasta";
            this.FechaHasta.NonAutoSizeHeight = 23;
            this.FechaHasta.Size = new System.Drawing.Size(96, 21);
            this.FechaHasta.TabIndex = 2;
            this.FechaHasta.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
            // 
            // ContainerJerarquias
            // 
            this.ContainerJerarquias.Controls.Add(this.mzProductosControl1);
            this.ContainerJerarquias.Controls.Add(this.hierarchicalSearchControl1);
            this.ContainerJerarquias.Controls.Add(this.label9);
            this.ContainerJerarquias.Location = new System.Drawing.Point(28, 331);
            this.ContainerJerarquias.Name = "ContainerJerarquias";
            this.ContainerJerarquias.Size = new System.Drawing.Size(908, 170);
            this.ContainerJerarquias.TabIndex = 0;
            // 
            // mzProductosControl1
            // 
            this.mzProductosControl1.BackColor = System.Drawing.Color.Transparent;
            this.mzProductosControl1.EnabledCantidad = true;
            this.mzProductosControl1.EnabledListaDePrecio = true;
            this.mzProductosControl1.Location = new System.Drawing.Point(64, 0);
            this.mzProductosControl1.Name = "mzProductosControl1";
            this.mzProductosControl1.PermiteProductosCombo = false;
            this.mzProductosControl1.Size = new System.Drawing.Size(408, 48);
            this.mzProductosControl1.TabIndex = 0;
            this.mzProductosControl1.VisibleCantidad = true;
            this.mzProductosControl1.VisibleComboListaDePrecios = true;
            this.mzProductosControl1.VisibleComboTipoDePrecioDeCosto = false;
            this.mzProductosControl1.VisiblePrecios = true;
            // 
            // hierarchicalSearchControl1
            // 
            this.hierarchicalSearchControl1.BackColor = System.Drawing.Color.Transparent;
            this.hierarchicalSearchControl1.Location = new System.Drawing.Point(8, 72);
            this.hierarchicalSearchControl1.Name = "hierarchicalSearchControl1";
            this.hierarchicalSearchControl1.Size = new System.Drawing.Size(784, 88);
            this.hierarchicalSearchControl1.TabIndex = 1;
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
            this.ContainerJerarquiasClientes.Location = new System.Drawing.Point(-10000, -10000);
            this.ContainerJerarquiasClientes.Name = "ContainerJerarquiasClientes";
            this.ContainerJerarquiasClientes.Size = new System.Drawing.Size(846, 90);
            this.ContainerJerarquiasClientes.TabIndex = 0;
            this.ContainerJerarquiasClientes.Visible = false;
            // 
            // hierarchicalSearchControlClientes
            // 
            this.hierarchicalSearchControlClientes.BackColor = System.Drawing.Color.Transparent;
            this.hierarchicalSearchControlClientes.Location = new System.Drawing.Point(8, 0);
            this.hierarchicalSearchControlClientes.Name = "hierarchicalSearchControlClientes";
            this.hierarchicalSearchControlClientes.Size = new System.Drawing.Size(784, 88);
            this.hierarchicalSearchControlClientes.TabIndex = 0;
            // 
            // ultraExplorerBarContainerControl3
            // 
            this.ultraExplorerBarContainerControl3.Controls.Add(this.gridResultado);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.gridManagerView1);
            this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
            this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(846, 296);
            this.ultraExplorerBarContainerControl3.TabIndex = 1;
            this.ultraExplorerBarContainerControl3.Visible = false;
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
            this.gridResultado.Size = new System.Drawing.Size(846, 272);
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
            // gridManagerView1
            // 
            this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
            this.gridManagerView1.Location = new System.Drawing.Point(0, 0);
            this.gridManagerView1.Name = "gridManagerView1";
            this.gridManagerView1.Size = new System.Drawing.Size(864, 24);
            this.gridManagerView1.TabIndex = 0;
            // 
            // ultraExplorerBarContainerControl5
            // 
            this.ultraExplorerBarContainerControl5.Controls.Add(this.richInfoComprobante);
            this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
            this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(846, 150);
            this.ultraExplorerBarContainerControl5.TabIndex = 4;
            this.ultraExplorerBarContainerControl5.Visible = false;
            // 
            // richInfoComprobante
            // 
            this.richInfoComprobante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richInfoComprobante.Location = new System.Drawing.Point(0, 0);
            this.richInfoComprobante.Name = "richInfoComprobante";
            this.richInfoComprobante.Size = new System.Drawing.Size(846, 150);
            this.richInfoComprobante.TabIndex = 0;
            this.richInfoComprobante.Text = "";
            // 
            // ultraExplorerBarContainerControl1
            // 
            this.ultraExplorerBarContainerControl1.Controls.Add(this.labelTarea);
            this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 24);
            this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(855, 24);
            this.ultraExplorerBarContainerControl1.TabIndex = 2;
            // 
            // labelTarea
            // 
            this.labelTarea.BackColor = System.Drawing.Color.Transparent;
            this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarea.Location = new System.Drawing.Point(0, 0);
            this.labelTarea.Name = "labelTarea";
            this.labelTarea.Size = new System.Drawing.Size(855, 23);
            this.labelTarea.TabIndex = 2;
            this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ultraExplorerBarContainerControl2
            // 
            this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 107);
            this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
            this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(855, 150);
            this.ultraExplorerBarContainerControl2.TabIndex = 1;
            // 
            // imglStandar
            // 
            this.imglStandar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
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
            this.toolBarButton3,
            this.tbbReiniciarFiltros,
            this.tbbSeparator3,
            this.tbbCancelar,
            this.toolBarButton2,
            this.tbbSeparadorImprimir,
            this.tbbImprimir,
            this.tbbSeparadorTicketDeCambio,
            this.tbbImprimirTicketDeCambio});
            this.toolBarStandar.DropDownArrows = true;
            this.toolBarStandar.ImageList = this.imglStandar;
            this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
            this.toolBarStandar.Name = "toolBarStandar";
            this.toolBarStandar.ShowToolTips = true;
            this.toolBarStandar.Size = new System.Drawing.Size(974, 28);
            this.toolBarStandar.TabIndex = 21;
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
            // tbbConsultar
            // 
            this.tbbConsultar.ImageIndex = 2;
            this.tbbConsultar.Name = "tbbConsultar";
            this.tbbConsultar.Text = "Ejecutar Consulta[F5]";
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.Name = "toolBarButton3";
            this.toolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbReiniciarFiltros
            // 
            this.tbbReiniciarFiltros.ImageIndex = 5;
            this.tbbReiniciarFiltros.Name = "tbbReiniciarFiltros";
            this.tbbReiniciarFiltros.Text = "Reiniciar Filtros de Busqueda";
            // 
            // tbbSeparator3
            // 
            this.tbbSeparator3.Name = "tbbSeparator3";
            this.tbbSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbCancelar
            // 
            this.tbbCancelar.ImageIndex = 7;
            this.tbbCancelar.Name = "tbbCancelar";
            this.tbbCancelar.Text = "&Cancelar";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.Name = "toolBarButton2";
            // 
            // tbbSeparadorImprimir
            // 
            this.tbbSeparadorImprimir.Name = "tbbSeparadorImprimir";
            this.tbbSeparadorImprimir.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbImprimir
            // 
            this.tbbImprimir.ImageIndex = 10;
            this.tbbImprimir.Name = "tbbImprimir";
            this.tbbImprimir.Text = "Imprimir";
            // 
            // tbbSeparadorTicketDeCambio
            // 
            this.tbbSeparadorTicketDeCambio.Name = "tbbSeparadorTicketDeCambio";
            this.tbbSeparadorTicketDeCambio.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbImprimirTicketDeCambio
            // 
            this.tbbImprimirTicketDeCambio.ImageIndex = 10;
            this.tbbImprimirTicketDeCambio.Name = "tbbImprimirTicketDeCambio";
            this.tbbImprimirTicketDeCambio.Text = "Imprimir Ticket de Cambio";
            // 
            // ultraExplorerBar1
            // 
            this.ultraExplorerBar1.AnimationEnabled = false;
            this.ultraExplorerBar1.Controls.Add(this.ContainerFiltro);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
            this.ultraExplorerBar1.Controls.Add(this.ContainerJerarquias);
            this.ultraExplorerBar1.Controls.Add(this.ContainerJerarquiasClientes);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
            this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl4;
            ultraExplorerBarGroup1.Key = "Tarea";
            ultraExplorerBarGroup1.Settings.ContainerHeight = 40;
            ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup1.Text = "Tarea";
            ultraExplorerBarGroup2.Container = this.ContainerFiltro;
            ultraExplorerBarGroup2.Key = "FiltroInicial";
            ultraExplorerBarGroup2.Settings.ContainerHeight = 149;
            ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup2.Text = "Filtro Inicial";
            ultraExplorerBarGroup3.Container = this.ContainerJerarquias;
            ultraExplorerBarGroup3.Key = "FiltroProductos";
            ultraExplorerBarGroup3.Settings.ContainerHeight = 170;
            ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup3.Text = "Filtro de productos";
            ultraExplorerBarGroup4.Container = this.ContainerJerarquiasClientes;
            ultraExplorerBarGroup4.Key = "JerarquiaClientes";
            ultraExplorerBarGroup4.Settings.ContainerHeight = 90;
            ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup4.Text = "Jerarquia de Clientes";
            ultraExplorerBarGroup5.Container = this.ultraExplorerBarContainerControl3;
            ultraExplorerBarGroup5.Key = "Resultado";
            ultraExplorerBarGroup5.Settings.ContainerHeight = 296;
            ultraExplorerBarGroup5.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup5.Text = "Resultado";
            ultraExplorerBarGroup6.Container = this.ultraExplorerBarContainerControl5;
            ultraExplorerBarGroup6.Key = "Detalle";
            ultraExplorerBarGroup6.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup6.Text = "Detalle";
            this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2,
            ultraExplorerBarGroup3,
            ultraExplorerBarGroup4,
            ultraExplorerBarGroup5,
            ultraExplorerBarGroup6});
            this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
            this.ultraExplorerBar1.Name = "ultraExplorerBar1";
            this.ultraExplorerBar1.Size = new System.Drawing.Size(974, 514);
            this.ultraExplorerBar1.TabIndex = 22;
            this.ultraExplorerBar1.TabStop = false;
            // 
            // FrmConsultaVentas
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(974, 542);
            this.Controls.Add(this.ultraExplorerBar1);
            this.Controls.Add(this.toolBarStandar);
            this.Name = "FrmConsultaVentas";
            this.Text = "FrmConsultaVentas";
            this.ultraExplorerBarContainerControl4.ResumeLayout(false);
            this.ContainerFiltro.ResumeLayout(false);
            this.ContainerFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEResponsableEmision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaHasta)).EndInit();
            this.ContainerJerarquias.ResumeLayout(false);
            this.ContainerJerarquiasClientes.ResumeLayout(false);
            this.ultraExplorerBarContainerControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
            this.ultraExplorerBarContainerControl5.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
            this.ultraExplorerBar1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
		
		#region Constructores y Destructores
		public FrmConsultaVentas()
		{
			InitializeComponent();			
		}
		public FrmConsultaVentas(controllers.ConsultaVentasController controller)
		{
			InitializeComponent();
			_uiController = controller;
			Init();
		}
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
		
		private mz.erp.ui.controllers.ConsultaVentasController _uiController = null;
		private ReportFilterArray _filtros = null;
		private int iniX = 10;
		private int iniY = 10;
		private int desplazamientotexto = 150;
		private int factordealtura = 24;
		private ArrayList _parametros = new ArrayList();
		private bool _allowShowDetails = false;
		
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
			

            //Cristian Configuracion de ImageList 20110717
            Util.LoadImages(toolBarStandar,imglStandar);
            //tbbAnterior.ImageIndex = (Int16)Util.ButtonIndex.Anterior;
            //tbbCancelar.ImageIndex = (Int16)Util.ButtonIndex.Cancelar;
            //Fin Cristian Configuracion de ImageList 20110717

			this.label2.Tag = "ResponsableEmision";
			this.label7.Tag = "FechaDesde";
			this.cboTiposDeComprobantes.Tag = "TiposDeComprobantes";
			this.chkEntreFechas.Tag = "Numero";
            //German 20120412 - Tarea 0000282
			//this.mzCmbResponsableEmision.Tag = "ResponsableEmision";
            this.mzCEResponsableEmision.Tag = "ResponsableEmision";
            //Fin German 20120412 - Tarea 0000282
			this.mzCmbCuenta.Tag = "Cuenta";
			this.FechaHasta.Tag = "FechaHasta";
			this.label6.Tag = "FechaHasta";
			this.FechaDesde.Tag = "FechaDesde";
			this.label1.Tag = "Cuenta";
			this.label5.Tag = "TiposDeComprobantes";
			this.txtNumeroDesde.Tag = "Numero";
			this.txtNumeroHasta.Tag = "Numero";
			this.label3.Tag = "Numero";

			this.Text = _uiController.LeyendaFormulario;
			//mzCEProductos.SearchObject= _uiController.SearchProducto;

			mzProductosControl1.SetProcess(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), "");

			tbbImprimir.Visible = _uiController.VisualizaBotonImprimir;
			tbbSeparadorImprimir.Visible = _uiController.VisualizaBotonImprimir;
			//chkResumido.Visible = _uiController.VisualizaCheckBoxResumido;

			mzCmbCuenta.Init(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName());
			mzCmbCuenta.Enabled = true;
			mzCmbCuenta.EnableCtaCte = true;

			//CallGridManager();
			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), gridResultado, this.Text);

			ultraExplorerBar1.Groups[2].Expanded = false;	
			
			
			lblTarea.Text = _uiController.LeyendaFormulario;
			//mzCEProductos.WidthSearchForm = 800;
			//mzCEProductos.LayoutData = _uiController.LayoutProductos;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			this.gridResultado.AutomaticSort = true;
			this.KeyPreview = true;
			this.hierarchicalSearchControl1.Build_UI("PRODUCTOS",_uiController.AllowMultipleSelect);
			this.hierarchicalSearchControlClientes.Build_UI("CUENTAS",_uiController.AllowMultipleSelect);

			if (! _uiController.AllowGeneralSearch)
			{			
				FechaDesde.Enabled = false;
				FechaHasta.Enabled = false;						
			}
			else 
			{
				FechaDesde.Enabled = true;
				FechaHasta.Enabled = true;
			}
			
			/*if (_uiController.AllowSearchByNumero)			
			{
				txtNumeroDesde.Visible = true;
				txtNumeroHasta.Visible = true;																
				ContainerFiltro.Height = 140;
			}
			else
			{				
				txtNumeroDesde.Visible = false;
				txtNumeroHasta.Visible = false;				
				ContainerFiltro.Height = 120;
			}*/
			

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
				_allowShowDetails = cont.Contains("Detalle");
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


			chkEntreFechas.Checked = _uiController.FilterByNumero;
			txtNumeroDesde.Enabled = _uiController.FilterByNumero;
			txtNumeroHasta.Enabled = _uiController.FilterByNumero;
			txtNumeroDesde.InputMask = @">A-####-########";			
			txtNumeroHasta.InputMask = @">A-####-########";
			txtNumeroDesde.Text = _uiController.NumeroDesde;
			txtNumeroHasta.Text = _uiController.NumeroHasta;

			ControlManager cm = new ControlManager();
			cm.OrganizeFilters(ContainerFiltro.Controls, _uiController.ListaFiltros);
			ContainerFiltro.Height = cm.Height;
			ConfigureTiposComprobantes();	
			mz.erp.ui.forms.classes.ContainerManager.UpdateSize(this.ContainerJerarquias, hierarchicalSearchControl1);
			mz.erp.ui.forms.classes.ContainerManager.UpdateSize(this.ContainerJerarquiasClientes, hierarchicalSearchControlClientes);
			mz.erp.ui.forms.classes.ContainerManager.CollapseContainers(ultraExplorerBar1, _uiController.GetProcessName(), _uiController.GetTaskName());

            /* Silvina 20110704 - Tarea 0000136 */
            tbbImprimirTicketDeCambio.Enabled = false;
            /* Fin Silvina 20110704 - Tarea 0000136 */
		}



		private void ConfigureTiposComprobantes()
		{
			object defaultValue = null;
			string _listaFamiliaDeComprobantes = _uiController.ListaFamiliaDeComprobantes;
			string _listaFamiliaDeComprobantesDV = _uiController.ListaFamiliaDeComprobantesDV;
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
			
			if (_familiaDefault != "")
			{
				cboTiposDeComprobantes.SelectedItem = (string)_familiaDefault;
				_uiController.FamiliaComprobantes = (string)_familiaDefault;
				//_defaultValueComprobantesAgrupados = (string)defaultValue;			
			}
			/*else
			{
				if(_uiController != null)
				{
					cboTiposDeComprobantes.DataBindings.Add("Text",_uiController,propertyBinding);
					_defaultValueComprobantesAgrupados = _uiController.FamiliaComprobantes;
				}
			}*/
		}

		private void InitializeData()
		{
			//mzCEProductos.SearchObject= _uiController.SearchProducto;
			FechaDesde.Value = _uiController.FechaDesde;
			FechaHasta.Value = _uiController.FechaHasta;
		}
		private void InitEventHandlers()
		{			
			_uiController.DataChanged+=new EventHandler(RefreshData);
			this.Load +=new EventHandler(FrmConsultaVentas_Load);
			this.KeyDown +=new KeyEventHandler(KeyDownBehavior);
			gridResultado.GroupsChanged +=new Janus.Windows.GridEX.GroupsChangedEventHandler(gridResultado_GroupsChanged);
			//gridResultado.SelectionChanged+=new EventHandler(gridResultado_SelectionChanged);
			this.Detalles.Click += new System.EventHandler(this.Detalles_Click);
			this.gridResultado.Click+=new EventHandler(this.DetallesResumido_Click);	
			//this.chkFiltroFechas.Click += new System.EventHandler(this.chkFiltroFechas_Click);
			hierarchicalSearchControl1.OnSelected+=new EventHandler(hierarchicalSearchControl1_OnSelected);
			hierarchicalSearchControlClientes.OnSelected+=new EventHandler(hierarchicalSearchControlClientes_OnSelected);

			/*mzCmbCuenta.SearchObject = typeof(  mz.erp.ui.forms.classes.tsa_Cuentas  );
			mzCmbCuenta.EditObject = typeof(mz.erp.ui.forms.FrmAbmCuentas);*/
				
			mzCmbCuenta.AllowEditClientePaso = false;
			mzCmbCuenta.SearchObjectListener = this;
			mzCmbCuenta.ValueChanged+= new System.EventHandler( this.Componentes_Changes );
            //German 20120412 - Tarea 0000282
			//mzCmbResponsableEmision.SearchObject = typeof( mz.erp.ui.forms.classes.tsh_Personas );			
			mzCEResponsableEmision.FillFromDataSource(businessrules.data.UsuariosPersonas.GetList(), "IdPersona","Nombre",200,"ID","Nombre","Nombre");					
            //Fin German 20120412 - Tarea 0000282
			chkEntreFechas.Click+=new EventHandler(chkEntreFechas_Click);
			KeyDownManager KeyDownMan = new KeyDownManager(this);

            //Cristian Tarea 0000050 20110310
            this.FechaDesde.ValueChanged += new EventHandler(FechaDesde_ValueChanged);
            //Fin Cristian
            //Cristian Tarea 0000146
            this.FechaHasta.ValueChanged += new EventHandler(FechaHasta_ValueChanged);
            //Fin cristian

        }

        //Cristian Tarea 0000146 20110725
        void FechaHasta_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(FechaHasta.Value)), true);
            this.FechaDesde.Value = _uiController.FechaDesde;
        }
        //Fin cristian Tarea 0000146

        //Cristian Tarea 0000050 20110310
        void FechaDesde_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(FechaDesde.Value)),false);
            this.FechaHasta.Value = _uiController.FechaHasta;

        }
        //Fin Cristian


		private void Componentes_Changes( object sender, System.EventArgs e )
		{			
			/*if (_uiController.Cuenta.CompareTo( Convert.ToString(mzCmbCuenta.DataValue)) != 0
				|| )
			{
			*/				
			//}
			_uiController.CodigoCuenta = Convert.ToString(mzCmbCuenta.DataValue);				
			if (! _uiController.AllowGeneralSearch)
			{
				if (_uiController.CodigoCuenta == "")
				{
					FechaDesde.Enabled = false;
					FechaHasta.Enabled = false;
					FechaDesde.Value = _uiController.FechaDesdeDefault;
					FechaHasta.Value = _uiController.FechaHastaDefault;
					_uiController.FechaDesde = _uiController.FechaDesdeDefault;
					_uiController.FechaHasta = _uiController.FechaHastaDefault;
				}
				else 
				{
					FechaDesde.Enabled = true;
					FechaHasta.Enabled = true;
				}
			}
			else 
			{
				FechaDesde.Enabled = true;
				FechaHasta.Enabled = true;
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
			/*BindingController.Bind(chkFiltroFechas, "Checked", _uiController, "ByFechas");
			BindingController.Bind(chkResumido, "Checked", _uiController, "Resumido");*/			
			//BindingController.Bind(mzCmbCuenta, "DataValue", _uiController, "CodigoCuenta");
            //German 20120412 - Tarea 0000282
			//BindingController.Bind(mzCmbResponsableEmision, "DataValue", _uiController, "ResponsableEmision");
            BindingController.Bind(mzCEResponsableEmision, "Value", _uiController, "ResponsableEmision");
            //Fin German 20120412 - Tarea 0000282
			BindingController.Bind(cboTiposDeComprobantes, "Text", _uiController, "FamiliaComprobantes");

			//FechaDesde.DataBindings.Add("Value", _uiController, "FechaDesde");
			//FechaHasta.DataBindings.Add("Value", _uiController, "FechaHasta");			
			//txtNumeroDesde.DataBindings.Add("Value", _uiController, "NumeroDesde");
			//txtNumeroHasta.DataBindings.Add("Value", _uiController, "NumeroHasta");
							
			//mzCEProductos.DataBindings.Add("DataValue", _uiController, "Codigo");
			mzProductosControl1.AddObjectListener( (IObserver)_uiController );
			

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
			/*uccFechaDesdePorProducto.Enabled = chkFiltroFechas.Checked;
			uccFechaHastaPorProducto.Enabled = chkFiltroFechas.Checked;*/
		}

		private void Init()
		{
			//toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.onClick);						
			_filtros = _uiController.GetFiltro();
			#region filtros
			for (int i=0;i<=(_filtros.Count-1);i++)
			{
				ReportFilterItem unfiltro = _filtros[i];
				/*if(unfiltro.Clave.ToUpper().Equals("ESTADOSORDENREPARACION"))
				{
					_parametros.Add( null );
					FiltroEstadoOrdenReparacion(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding, unfiltro.Table );
				}
				if ((unfiltro.Clave.ToUpper() == "ESTADODESTOCK"))
				{
					_parametros.Add( null );
					FiltroEstadoDeStock(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding );
				}
				if ((unfiltro.Clave.ToUpper() == "SECCION"))
				{
					_parametros.Add( null );
					FiltroSeccion(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding );
				}
				if ((unfiltro.Clave.ToUpper() == "DEPOSITO"))
				{
					_parametros.Add( null );
					FiltroDeposito(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding );
				}*/
				if ((unfiltro.Clave.ToUpper() == "PRODUCTO"))
				{
					_parametros.Add( null );
					//FiltroProducto(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue , unfiltro.PropertyBinding);
				}
				/*if ((unfiltro.Clave.ToUpper() == "TIPODEAJUSTE"))
				{
					_parametros.Add( null );
					FiltroTipoDeAjuste(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding );
				}
				if ((unfiltro.Clave.ToUpper() == "CUENTA"))
				{
					_parametros.Add( null );
					FiltroCuenta(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue , unfiltro.PropertyBinding);
				}
				if ((unfiltro.Clave.ToUpper() == "PERSONA"))
				{
					_parametros.Add( null );
					FiltroPersona(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue , unfiltro.PropertyBinding);
				}
				if ((unfiltro.Clave.ToUpper() == "RESPONSABLE"))
				{
					_parametros.Add( null );
					FiltroResponsable(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue , unfiltro.PropertyBinding);
				}
				if ((unfiltro.Clave.ToUpper() == "FECHA"))
				{
					_parametros.Add( mz.erp.businessrules.Sistema.DateTime.Now );
					FiltroFecha(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding );
				}
				if ((unfiltro.Clave.ToUpper() == "TIPODECOMPROBANTE"))
				{
					_parametros.Add( null );
					FiltroTipoDeComprobante(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
				}*/
				/*if ((unfiltro.Clave.ToUpper() == "TIPODECOMPROBANTEAGRUPADO"))
				{
					_parametros.Add( null );
					FiltroTipoDeComprobanteAgrupado(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
				}*/
				if ((unfiltro.Clave.ToUpper() == "PROVEEDOR"))
				{
					_parametros.Add( null );
					//FiltroProveedor(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
				}
				/*if ((unfiltro.Clave.ToUpper() == "MONEDA"))
				{
					_parametros.Add( null );
					FiltroMoneda(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
				}
				if ((unfiltro.Clave.ToUpper() == "MOMENTO"))
				{
					_parametros.Add( null );
					FiltroTextBox(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
				}
				if ((unfiltro.Clave.ToUpper() == "IDORDENREPARACION"))
				{
					_parametros.Add( null );
					FiltroTextBox(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
				}*/
			}
			#endregion
		}

        private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            switch (toolBarStandar.Buttons.IndexOf(e.Button))
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
                case 11:
                    PrintComprobante();
                    break;
                /* Silvina 20110704 - Tarea 0000136 */
                case 13:
                    ImprimirTicketDeCambio();
                    break;
                /* Fin Silvina 20110704 - Tarea 0000136 */
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
            /* Silvina 20120420 - Tarea 0000294 */
            switch (_uiController.GetProcessName())
            {
                case "ProcesoConsultarComisiones":
                {
                     ReportsManager.PrintReportConsultaComisiones(_uiController.Result, this.MdiParent);
                }
                break;
                case "ProcesoConsultarVentasPorVendedor":
                {
                    ReportsManager.PrintReportConsultaVentas(_uiController.Result, this.MdiParent);
                }
                break;
                case "ProcesoConsultarCobranzas":
                {
                    ReportsManager.PrintReportConsultaCobranzas(_uiController.Result, this.MdiParent);
                }
                break;
            }
            /* Fin Silvina 20120420 - Tarea 0000294 */
            this.Cursor = Cursors.Default;
			if(this._allowShowDetails)
			{
				if(gridResultado.RecordCount > 0)
				{
					gridResultado.Row = 0;
					//this.gridResultado_SelectionChanged(gridResultado, new EventArgs())	;
				}
			}
			this.Cursor = Cursors.Default;
		}

		private void ResetFilters()
		{
			_uiController.ResetFilters();
			mzCmbCuenta.ClearControl(); //mzCmbCuenta.DataValue=string.Empty;
			
			FechaDesde.Value=_uiController.FechaDesde;
			FechaHasta.Value=_uiController.FechaHasta;

            //German 20120412 - Tarea 0000282
			//mzCmbResponsableEmision.ClearControl(); //mzCmbResponsableEmision.DataValue=string.Empty;
            mzCEResponsableEmision.Value = null;
            //Fin German 20120412 - Tarea 0000282
			
			cboTiposDeComprobantes.SelectedItem = _uiController.TodosLosComprobantes;
			if (!_uiController.FamiliaDefault.Equals(string.Empty))
			{
				cboTiposDeComprobantes.SelectedItem = _uiController.FamiliaDefault;
				_uiController.FamiliaComprobantes = _uiController.FamiliaDefault;
			}

			txtNumeroDesde.Text=string.Empty;
			txtNumeroHasta.Text=string.Empty;
			chkEntreFechas.Checked=false;
			
			mzProductosControl1.ClearControl();
			_uiController.Codigo=string.Empty;
			
			hierarchicalSearchControl1.ClearSelectedNodes();
			hierarchicalSearchControlClientes.ClearSelectedNodes();
			
			gridResultado.SetDataBinding(null, null);
			gridResultado.Refresh();
		}

		private void DumpControls()
		{
			_uiController.NumeroDesde = txtNumeroDesde.Text;
			_uiController.NumeroHasta = txtNumeroHasta.Text;
			_uiController.FechaDesde = Convert.ToDateTime(FechaDesde.Value);
			_uiController.FechaHasta = Convert.ToDateTime(FechaHasta.Value);
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

		private void FrmConsultaVentas_Load(object sender, EventArgs e)
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
                    /* Silvina 20110704 - Tarea 0000136 */
                    tbbImprimirTicketDeCambio.Enabled = _uiController.VisualizaBotonImprimirTicketDeCambio(IdTipoDeComprobante);
                    /* Fin Silvina 20110704 - Tarea 0000136 */
				}
			}
			
		}
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
						ReportsManager.PrintReportComprobantes( IdComprobante, this.MdiParent) ;
						this.Cursor = Cursors.Default;
					}
				}
			}
		}

        /* Silvina 20110704 - Tarea 0000136 */
        private void ImprimirTicketDeCambio()
        {
            if (gridResultado.SelectedItems.Count > 0 && gridResultado.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
            {
                string IdComprobante = Convert.ToString(gridResultado.SelectedItems[0].GetRow().Cells["IdComprobante"].Value);
                if (!_uiController.ImprimirTicketDeCambio(IdComprobante))
                    MessageBox.Show("El comprobante no tiene productos que permitan cambio.");
            }
        }
        /* Fin Silvina 20110704 - Tarea 0000136 */
	}
}

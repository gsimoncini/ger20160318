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
	/// Descripción breve de FrmConsultarRetencionesProveedores.
	/// </summary>
	public class FrmConsultarRetencionesProveedores : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem Detalles;
		protected System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton toolBarButton11;
		private System.Windows.Forms.ToolBarButton toolBarButton12;
		private System.Windows.Forms.ToolBarButton toolBarButton13;
		private System.Windows.Forms.ToolBarButton toolBarButton14;
		private System.Windows.Forms.ToolBarButton tbbSeparadorImprimir;
		private System.Windows.Forms.ToolBarButton tbbImprimir;
		private System.Windows.Forms.ToolBarButton toolBarButton16;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ContainerFiltro;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		protected Janus.Windows.GridEX.GridEX gridResultado;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.Label lbTarea;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private HtmlRichText.HtmlRichTextBox richInfoRetenciones;
		private mz.erp.ui.controls.mzComboEditor mzCmbTiposDeRetenciones;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMENumeroRetencion;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMENumeroRecibo;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMENumeroFactura;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label9;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo FechaFacturaDesde;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo FechaReciboDesde;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo FechaRetencionDesde;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo FechaFacturaHasta;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo FechaReciboHasta;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo FechaRetencionHasta;
		private System.Windows.Forms.CheckBox chkFechaRetencion;
		private System.Windows.Forms.CheckBox chkFechaRecibo;
		private System.Windows.Forms.CheckBox chkFechaFactura;
		private System.Windows.Forms.ToolBarButton tbbSeparadorCancelar;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private System.ComponentModel.IContainer components;

		#region Constructores y Destructores
		public FrmConsultarRetencionesProveedores()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		public FrmConsultarRetencionesProveedores(controllers.ConsultarRetencionesProveedoresController controller)
		{
			// controller = ProcesoConsultarRetencionesProveedores
			InitializeComponent();
			_uiController = controller;
			Build_UI();
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
				this.toolBarStandar.ButtonClick -= new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
				_uiController.DataChanged -=new EventHandler(RefreshData);
				this.Detalles.Click -=new EventHandler(Detalles_Click);
				this.gridResultado.Click -=new EventHandler(gridResultado_Click);
				ultraMENumeroRetencion.DataBindings.Clear();
				FechaRetencionDesde.DataBindings.Clear();
				FechaRetencionHasta.DataBindings.Clear();
				mzCmbTiposDeRetenciones.DataBindings.Clear();
				ultraMENumeroRecibo.DataBindings.Clear();
				FechaReciboDesde.DataBindings.Clear();
				FechaReciboHasta.DataBindings.Clear();
				ultraMENumeroFactura.DataBindings.Clear();
				FechaFacturaDesde.DataBindings.Clear();
				FechaFacturaHasta.DataBindings.Clear();
			}
			base.Dispose( disposing );
		}
		#endregion

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
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton4 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton5 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton6 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmConsultarRetencionesProveedores));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.lbTarea = new System.Windows.Forms.Label();
			this.ContainerFiltro = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.chkFechaFactura = new System.Windows.Forms.CheckBox();
			this.chkFechaRecibo = new System.Windows.Forms.CheckBox();
			this.chkFechaRetencion = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.FechaFacturaHasta = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.label6 = new System.Windows.Forms.Label();
			this.FechaReciboHasta = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.label9 = new System.Windows.Forms.Label();
			this.FechaRetencionHasta = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.ultraMENumeroFactura = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
			this.ultraMENumeroRecibo = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
			this.ultraMENumeroRetencion = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
			this.mzCmbTiposDeRetenciones = new mz.erp.ui.controls.mzComboEditor();
			this.label8 = new System.Windows.Forms.Label();
			this.FechaFacturaDesde = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.label10 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.FechaReciboDesde = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.FechaRetencionDesde = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.gridResultado = new Janus.Windows.GridEX.GridEX();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.Detalles = new System.Windows.Forms.MenuItem();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.richInfoRetenciones = new HtmlRichText.HtmlRichTextBox();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton11 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton12 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton13 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton14 = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparadorImprimir = new System.Windows.Forms.ToolBarButton();
			this.tbbImprimir = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton16 = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparadorCancelar = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.ContainerFiltro.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.FechaFacturaHasta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaReciboHasta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaRetencionHasta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposDeRetenciones)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaFacturaDesde)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaReciboDesde)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaRetencionDesde)).BeginInit();
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
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, -21);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(878, 17);
			this.ultraExplorerBarContainerControl1.TabIndex = 2;
			// 
			// lbTarea
			// 
			this.lbTarea.BackColor = System.Drawing.Color.Transparent;
			this.lbTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbTarea.Location = new System.Drawing.Point(0, 0);
			this.lbTarea.Name = "lbTarea";
			this.lbTarea.Size = new System.Drawing.Size(878, 16);
			this.lbTarea.TabIndex = 2;
			this.lbTarea.Text = "Tarea";
			this.lbTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ContainerFiltro
			// 
			this.ContainerFiltro.Controls.Add(this.chkFechaFactura);
			this.ContainerFiltro.Controls.Add(this.chkFechaRecibo);
			this.ContainerFiltro.Controls.Add(this.chkFechaRetencion);
			this.ContainerFiltro.Controls.Add(this.label4);
			this.ContainerFiltro.Controls.Add(this.FechaFacturaHasta);
			this.ContainerFiltro.Controls.Add(this.label6);
			this.ContainerFiltro.Controls.Add(this.FechaReciboHasta);
			this.ContainerFiltro.Controls.Add(this.label9);
			this.ContainerFiltro.Controls.Add(this.FechaRetencionHasta);
			this.ContainerFiltro.Controls.Add(this.ultraMENumeroFactura);
			this.ContainerFiltro.Controls.Add(this.ultraMENumeroRecibo);
			this.ContainerFiltro.Controls.Add(this.ultraMENumeroRetencion);
			this.ContainerFiltro.Controls.Add(this.mzCmbTiposDeRetenciones);
			this.ContainerFiltro.Controls.Add(this.label8);
			this.ContainerFiltro.Controls.Add(this.FechaFacturaDesde);
			this.ContainerFiltro.Controls.Add(this.label10);
			this.ContainerFiltro.Controls.Add(this.label2);
			this.ContainerFiltro.Controls.Add(this.FechaReciboDesde);
			this.ContainerFiltro.Controls.Add(this.label3);
			this.ContainerFiltro.Controls.Add(this.label5);
			this.ContainerFiltro.Controls.Add(this.label7);
			this.ContainerFiltro.Controls.Add(this.label1);
			this.ContainerFiltro.Controls.Add(this.FechaRetencionDesde);
			this.ContainerFiltro.Location = new System.Drawing.Point(28, -108);
			this.ContainerFiltro.Name = "ContainerFiltro";
			this.ContainerFiltro.Size = new System.Drawing.Size(878, 99);
			this.ContainerFiltro.TabIndex = 0;
			// 
			// chkFechaFactura
			// 
			this.chkFechaFactura.BackColor = System.Drawing.Color.Transparent;
			this.chkFechaFactura.Location = new System.Drawing.Point(787, 71);
			this.chkFechaFactura.Name = "chkFechaFactura";
			this.chkFechaFactura.TabIndex = 12;
			// 
			// chkFechaRecibo
			// 
			this.chkFechaRecibo.BackColor = System.Drawing.Color.Transparent;
			this.chkFechaRecibo.Location = new System.Drawing.Point(787, 47);
			this.chkFechaRecibo.Name = "chkFechaRecibo";
			this.chkFechaRecibo.TabIndex = 11;
			// 
			// chkFechaRetencion
			// 
			this.chkFechaRetencion.BackColor = System.Drawing.Color.Transparent;
			this.chkFechaRetencion.Location = new System.Drawing.Point(787, 23);
			this.chkFechaRetencion.Name = "chkFechaRetencion";
			this.chkFechaRetencion.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(635, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 16);
			this.label4.TabIndex = 145;
			this.label4.Tag = "FechaFactura";
			this.label4.Text = "Hasta";
			// 
			// FechaFacturaHasta
			// 
			dateButton1.Caption = "Today";
			this.FechaFacturaHasta.DateButtons.Add(dateButton1);
			this.FechaFacturaHasta.Location = new System.Drawing.Point(680, 72);
			this.FechaFacturaHasta.Name = "FechaFacturaHasta";
			this.FechaFacturaHasta.NonAutoSizeHeight = 23;
			this.FechaFacturaHasta.Size = new System.Drawing.Size(96, 21);
			this.FechaFacturaHasta.TabIndex = 9;
			this.FechaFacturaHasta.Tag = "FechaFactura";
			this.FechaFacturaHasta.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(635, 51);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 16);
			this.label6.TabIndex = 143;
			this.label6.Tag = "FechaRecibo";
			this.label6.Text = "Hasta";
			// 
			// FechaReciboHasta
			// 
			dateButton2.Caption = "Today";
			this.FechaReciboHasta.DateButtons.Add(dateButton2);
			this.FechaReciboHasta.Location = new System.Drawing.Point(680, 48);
			this.FechaReciboHasta.Name = "FechaReciboHasta";
			this.FechaReciboHasta.NonAutoSizeHeight = 23;
			this.FechaReciboHasta.Size = new System.Drawing.Size(96, 21);
			this.FechaReciboHasta.TabIndex = 8;
			this.FechaReciboHasta.Tag = "FechaRecibo";
			this.FechaReciboHasta.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(635, 27);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 16);
			this.label9.TabIndex = 141;
			this.label9.Tag = "FechaRetencion";
			this.label9.Text = "Hasta";
			// 
			// FechaRetencionHasta
			// 
			dateButton3.Caption = "Today";
			this.FechaRetencionHasta.DateButtons.Add(dateButton3);
			this.FechaRetencionHasta.Location = new System.Drawing.Point(680, 24);
			this.FechaRetencionHasta.Name = "FechaRetencionHasta";
			this.FechaRetencionHasta.NonAutoSizeHeight = 23;
			this.FechaRetencionHasta.Size = new System.Drawing.Size(96, 21);
			this.FechaRetencionHasta.TabIndex = 7;
			this.FechaRetencionHasta.Tag = "FechaRetencion";
			this.FechaRetencionHasta.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
			// 
			// ultraMENumeroFactura
			// 
			this.ultraMENumeroFactura.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
			this.ultraMENumeroFactura.InputMask = "?-####-########";
			this.ultraMENumeroFactura.Location = new System.Drawing.Point(144, 72);
			this.ultraMENumeroFactura.Name = "ultraMENumeroFactura";
			this.ultraMENumeroFactura.TabIndex = 3;
			this.ultraMENumeroFactura.Text = "--";
			// 
			// ultraMENumeroRecibo
			// 
			this.ultraMENumeroRecibo.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
			this.ultraMENumeroRecibo.InputMask = "?-####-########";
			this.ultraMENumeroRecibo.Location = new System.Drawing.Point(144, 48);
			this.ultraMENumeroRecibo.Name = "ultraMENumeroRecibo";
			this.ultraMENumeroRecibo.TabIndex = 2;
			this.ultraMENumeroRecibo.Text = "--";
			// 
			// ultraMENumeroRetencion
			// 
			this.ultraMENumeroRetencion.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
			this.ultraMENumeroRetencion.InputMask = "?-####-########";
			this.ultraMENumeroRetencion.Location = new System.Drawing.Point(144, 0);
			this.ultraMENumeroRetencion.Name = "ultraMENumeroRetencion";
			this.ultraMENumeroRetencion.TabIndex = 0;
			this.ultraMENumeroRetencion.Text = "--";
			// 
			// mzCmbTiposDeRetenciones
			// 
			this.mzCmbTiposDeRetenciones.AutoComplete = true;
			this.mzCmbTiposDeRetenciones.DataSource = null;
			this.mzCmbTiposDeRetenciones.DisplayMember = "";
			this.mzCmbTiposDeRetenciones.DisplayMemberCaption = "";
			this.mzCmbTiposDeRetenciones.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbTiposDeRetenciones.Location = new System.Drawing.Point(136, 24);
			this.mzCmbTiposDeRetenciones.MaxItemsDisplay = 50;
			this.mzCmbTiposDeRetenciones.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbTiposDeRetenciones.Name = "mzCmbTiposDeRetenciones";
			this.mzCmbTiposDeRetenciones.Size = new System.Drawing.Size(217, 21);
			this.mzCmbTiposDeRetenciones.SorterMember = "";
			this.mzCmbTiposDeRetenciones.TabIndex = 1;
			this.mzCmbTiposDeRetenciones.ValueMember = "";
			this.mzCmbTiposDeRetenciones.ValueMemberCaption = "";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(392, 75);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(128, 16);
			this.label8.TabIndex = 135;
			this.label8.Tag = "FechaFactura";
			this.label8.Text = "Fecha Factura Desde";
			// 
			// FechaFacturaDesde
			// 
			dateButton4.Caption = "Today";
			this.FechaFacturaDesde.DateButtons.Add(dateButton4);
			this.FechaFacturaDesde.Location = new System.Drawing.Point(528, 72);
			this.FechaFacturaDesde.Name = "FechaFacturaDesde";
			this.FechaFacturaDesde.NonAutoSizeHeight = 23;
			this.FechaFacturaDesde.Size = new System.Drawing.Size(96, 21);
			this.FechaFacturaDesde.TabIndex = 6;
			this.FechaFacturaDesde.Tag = "FechaFactura";
			this.FechaFacturaDesde.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(8, 72);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(112, 17);
			this.label10.TabIndex = 131;
			this.label10.Tag = "NumeroFactura";
			this.label10.Text = "Número Factura";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(392, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 16);
			this.label2.TabIndex = 130;
			this.label2.Tag = "FechaRecibo";
			this.label2.Text = "Fecha Recibo Desde";
			// 
			// FechaReciboDesde
			// 
			dateButton5.Caption = "Today";
			this.FechaReciboDesde.DateButtons.Add(dateButton5);
			this.FechaReciboDesde.Location = new System.Drawing.Point(528, 48);
			this.FechaReciboDesde.Name = "FechaReciboDesde";
			this.FechaReciboDesde.NonAutoSizeHeight = 23;
			this.FechaReciboDesde.Size = new System.Drawing.Size(96, 21);
			this.FechaReciboDesde.TabIndex = 5;
			this.FechaReciboDesde.Tag = "FechaRecibo";
			this.FechaReciboDesde.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(8, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 17);
			this.label3.TabIndex = 126;
			this.label3.Tag = "NumeroRecibo";
			this.label3.Text = "Número Recibo";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(8, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(128, 16);
			this.label5.TabIndex = 125;
			this.label5.Tag = "TipoDeRetencion";
			this.label5.Text = "Tipo de Retención";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(392, 27);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(128, 16);
			this.label7.TabIndex = 123;
			this.label7.Tag = "FechaRetencion";
			this.label7.Text = "Fecha Retención Desde";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(8, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 17);
			this.label1.TabIndex = 120;
			this.label1.Tag = "NumeroRetencion";
			this.label1.Text = "Número Retención";
			// 
			// FechaRetencionDesde
			// 
			dateButton6.Caption = "Today";
			this.FechaRetencionDesde.DateButtons.Add(dateButton6);
			this.FechaRetencionDesde.Location = new System.Drawing.Point(528, 24);
			this.FechaRetencionDesde.Name = "FechaRetencionDesde";
			this.FechaRetencionDesde.NonAutoSizeHeight = 23;
			this.FechaRetencionDesde.Size = new System.Drawing.Size(96, 21);
			this.FechaRetencionDesde.TabIndex = 4;
			this.FechaRetencionDesde.Tag = "FechaRetencion";
			this.FechaRetencionDesde.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
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
			// gridManagerView1
			// 
			this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
			this.gridManagerView1.Dock = System.Windows.Forms.DockStyle.Top;
			this.gridManagerView1.Location = new System.Drawing.Point(0, 0);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(878, 24);
			this.gridManagerView1.TabIndex = 0;
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
			this.ultraExplorerBarContainerControl3.Controls.Add(this.richInfoRetenciones);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 219);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(878, 150);
			this.ultraExplorerBarContainerControl3.TabIndex = 3;
			// 
			// richInfoRetenciones
			// 
			this.richInfoRetenciones.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richInfoRetenciones.Location = new System.Drawing.Point(0, 0);
			this.richInfoRetenciones.Name = "richInfoRetenciones";
			this.richInfoRetenciones.Size = new System.Drawing.Size(878, 150);
			this.richInfoRetenciones.TabIndex = 0;
			this.richInfoRetenciones.Text = "";
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
																							  this.tbbSeparadorImprimir,
																							  this.tbbImprimir,
																							  this.toolBarButton16,
																							  this.tbbSeparadorCancelar,
																							  this.tbbCancelar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(944, 28);
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
			// tbbSeparadorImprimir
			// 
			this.tbbSeparadorImprimir.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbImprimir
			// 
			this.tbbImprimir.ImageIndex = 8;
			this.tbbImprimir.Text = "Imprimir";
			// 
			// toolBarButton16
			// 
			this.toolBarButton16.ImageIndex = 9;
			this.toolBarButton16.Text = "&Selección";
			// 
			// tbbSeparadorCancelar
			// 
			this.tbbSeparadorCancelar.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
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
			ultraExplorerBarGroup1.Settings.ContainerHeight = 17;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ContainerFiltro;
			ultraExplorerBarGroup2.Key = "FiltroPrincipal";
			ultraExplorerBarGroup2.Settings.ContainerHeight = 99;
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
			ultraExplorerBarGroup4.Text = "Detalle";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3,
																														ultraExplorerBarGroup4});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(944, 394);
			this.ultraExplorerBar1.TabIndex = 22;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// FrmConsultarRetencionesProveedores
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(944, 422);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmConsultarRetencionesProveedores";
			this.Text = "FrmConsultarRetencionesProveedores";
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.ContainerFiltro.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.FechaFacturaHasta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaReciboHasta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaRetencionHasta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposDeRetenciones)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaFacturaDesde)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaReciboDesde)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaRetencionDesde)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Variables Privadas
		private controllers.ConsultarRetencionesProveedoresController _uiController;
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
		}


		private void ConfigureInterface()
		{						
			this.Text = _uiController.LeyendaFormulario;
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), gridResultado, this.Text);
			lbTarea.Text = _uiController.LeyendaFormulario;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			this.gridResultado.AutomaticSort = true;
			tbbImprimir.Visible = _uiController.VisualizaBotonImprimir;
			tbbSeparadorImprimir.Visible = _uiController.VisualizaBotonImprimir;

			if (! _uiController.AllowGeneralSearch) // agregar variable y metodo en brClass...
			{			
				chkFechaRetencion.Enabled = false;
				chkFechaRecibo.Enabled = false;
				chkFechaFactura.Enabled = false;
			}
			else 
			{
				chkFechaRetencion.Enabled = true;
				chkFechaRecibo.Enabled = true;
				chkFechaFactura.Enabled = true;
			}

			chkFechaRetencion.Checked = _uiController.FilterByFechaRetencion;
			chkFechaRecibo.Checked = _uiController.FilterByFechaRecibo;
			chkFechaFactura.Checked = _uiController.FilterByFechaFactura;
			KeyPreview = true;


		}


		private void InitializeData()
		{
			mzCmbTiposDeRetenciones.FillFromDataSource( _uiController.TiposDeRetenciones, _uiController.KeyValueTiposDeRetenciones,_uiController.KeyListTiposDeRetenciones,100, _uiController.KeyListTiposDeRetenciones );
		}

		private void InitEventHandlers()
		{			
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			_uiController.DataChanged+=new EventHandler(RefreshData);
			this.Detalles.Click +=new EventHandler(Detalles_Click);
			this.gridResultado.Click +=new EventHandler(gridResultado_Click);
			this.KeyDown +=new KeyEventHandler(KeyDownBehavior);
			KeyDownManager KeyDownMan = new KeyDownManager(this);
            //Cristian Tarea 0000050 20110310
            this.FechaReciboDesde.ValueChanged += new EventHandler(FechaReciboDesde_ValueChanged);
            this.FechaFacturaDesde.ValueChanged += new EventHandler(FechaFacturaDesde_ValueChanged);
            this.FechaRetencionDesde.ValueChanged += new EventHandler(FechaRetencionDesde_ValueChanged);
            //Fin Cristian
            //Cristian Tarea 0000050 20110725
            this.FechaFacturaHasta.ValueChanged += new EventHandler(FechaFacturaHasta_ValueChanged);
            this.FechaReciboHasta.ValueChanged += new EventHandler(FechaReciboHasta_ValueChanged);
            this.FechaRetencionHasta.ValueChanged += new EventHandler(FechaRetencionHasta_ValueChanged);
            //Fin cristian

        }
        //Cristian Tarea 0000146 20110725
        void FechaRetencionHasta_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(FechaRetencionHasta.Value)), "RETENCION", true);
            this.FechaRetencionDesde.Value = _uiController.FechaRetencionDesde;
        }

        void FechaReciboHasta_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(FechaReciboHasta.Value)), "RECIBO", true);
            this.FechaReciboDesde.Value = _uiController.FechaReciboDesde;
        }

        void FechaFacturaHasta_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(FechaFacturaHasta.Value)), "FACTURA", true);
            this.FechaFacturaDesde.Value = _uiController.FechaFacturaDesde;
        }

        //Fin Cristian  20110725

        //Cristian Tarea 0000050 20110310
        void FechaRetencionDesde_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(FechaRetencionDesde.Value)), "RETENCION",false);
            this.FechaRetencionHasta.Value = _uiController.FechaRetencionHasta;
        }

        void FechaFacturaDesde_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(FechaFacturaDesde.Value)), "FACTURA",false);
            this.FechaFacturaHasta.Value = _uiController.FechaFacturaHasta;
        }

        void FechaReciboDesde_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(FechaReciboDesde.Value)),"RECIBO",false);
            this.FechaReciboHasta.Value = _uiController.FechaReciboHasta;
        }

        //Fin Cristian

		private void InitDataBindings()
		{
			ultraMENumeroRetencion.DataBindings.Add("Text", _uiController, "NumeroRetencion");
			FechaRetencionDesde.DataBindings.Add("Value", _uiController, "FechaRetencionDesde");
			FechaRetencionHasta.DataBindings.Add("Value", _uiController, "FechaRetencionHasta");
			mzCmbTiposDeRetenciones.DataBindings.Add("Value", _uiController, "IdTipoDeRetencion");
			ultraMENumeroRecibo.DataBindings.Add("Text", _uiController, "NumeroRecibo");
			FechaReciboDesde.DataBindings.Add("Value", _uiController, "FechaReciboDesde");
			FechaReciboHasta.DataBindings.Add("Value", _uiController, "FechaReciboHasta");
			ultraMENumeroFactura.DataBindings.Add("Text", _uiController, "NumeroFactura");
			FechaFacturaDesde.DataBindings.Add("Value", _uiController, "FechaFacturaDesde");
			FechaFacturaHasta.DataBindings.Add("Value", _uiController, "FechaFacturaHasta");

			chkFechaRetencion.Click+=new EventHandler(chkFechaRetencion_Click);
			chkFechaRecibo.Click+=new EventHandler(chkFechaRecibo_Click);
			chkFechaFactura.Click+=new EventHandler(chkFechaFactura_Click);
		}
		
		#endregion

		#region Miembros de ITaskForm

		public void Execute()
		{
			_uiController.Execute();			
		}

		public void Previous()
		{
			this._uiController.Previous();
		}

		public void ShowForm()
		{
			this.Show();
			
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
			this.Execute();
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
				case 8:					
					PrintComprobante();									
					break;
				case 11:
					CloseForm();
					break;

			}				
		}
		protected void ResetFilters()
		{
			ultraMENumeroRetencion.Text = string.Empty;
			FechaRetencionDesde.Value = null;
			FechaRetencionHasta.Value = null;
			mzCmbTiposDeRetenciones.Value = null;
			ultraMENumeroRecibo.Text = string.Empty;
			FechaReciboDesde.Value = null;
			FechaReciboHasta.Value = null;
			ultraMENumeroFactura.Text = string.Empty;
			FechaFacturaDesde.Value = null;
			FechaFacturaHasta.Value = null;
			
			_uiController.NumeroRetencion = string.Empty;
			_uiController.FechaRetencionDesde = DateTime.MinValue;
			_uiController.FechaRetencionHasta = DateTime.MinValue;
			_uiController.IdTipoDeRetencion = string.Empty;
			_uiController.NumeroRecibo = string.Empty;
			_uiController.FechaReciboDesde = DateTime.MinValue;
			_uiController.FechaReciboHasta = DateTime.MinValue;
			_uiController.NumeroFactura = string.Empty;
			_uiController.FechaFacturaDesde = DateTime.MinValue;
			_uiController.FechaFacturaHasta = DateTime.MinValue;
			
			chkFechaFactura.Checked=false;
			chkFechaRecibo.Checked=false;
			chkFechaRetencion.Checked=false;
			
			FechaRetencionDesde.Enabled=false;
			FechaRetencionHasta.Enabled=false;
			FechaReciboDesde.Enabled=false;
			FechaReciboHasta.Enabled=false;
			FechaFacturaDesde.Enabled=false;
			FechaFacturaHasta.Enabled=false;
			
			gridResultado.SetDataBinding(null, null);
			gridResultado.Refresh();
		}


		protected void RefreshData()
		{
			Util.MoveFocus(this.ContainerFiltro);
			this.Cursor = Cursors.WaitCursor;
			gridResultado.Focus();
			_uiController.RefreshData();
			this.Cursor = Cursors.Default;
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
						long IdRetencion = Convert.ToInt64(gridResultado.SelectedItems[0].GetRow().Cells["IdRetencion"].Value);					
						ReportsManager.PrintReportRetenciones( IdRetencion, this.MdiParent) ;
						this.Cursor = Cursors.Default;
					}
				}
			}
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

		private void Detalles_Click(object sender, EventArgs e)
		{
			bool visualizaDetalle = _uiController.VisualizaDetalle;
			string metodoVisualizacion = _uiController.MetodoVisualizacion;
			if(visualizaDetalle && metodoVisualizacion.Equals("PORDEMANDA"))
			{
				if(gridResultado.SelectedItems.Count > 0 && gridResultado.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
				{
					long IdRetencion = Convert.ToInt64(gridResultado.SelectedItems[0].GetRow().Cells["IdRetencion"].Value);
					if(!IdRetencion.Equals(long.MinValue))
					{
						this.richInfoRetenciones.Clear();
						string datos = mz.erp.businessrules.Workflow.GetHTMLRetenciones(IdRetencion);
						this.richInfoRetenciones.AddHTML(datos);
					}
					else this.richInfoRetenciones.Clear();
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
						this.richInfoRetenciones.Clear();
						this.richInfoRetenciones.AddHTML(datos);
					}
				}
			}
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

		private void gridResultado_Click(object sender, EventArgs e)
		{
			bool visualizaDetalle = _uiController.VisualizaDetalle;
			string metodoVisualizacion = _uiController.MetodoVisualizacion;
			if(visualizaDetalle && metodoVisualizacion.Equals("PORDEMANDA"))
			{
				if(gridResultado.SelectedItems.Count > 0 && gridResultado.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
				{
					long IdRetencion = Convert.ToInt64(gridResultado.SelectedItems[0].GetRow().Cells["IdRetencion"].Value);
					if(!IdRetencion.Equals(long.MinValue))
					{
						this.richInfoRetenciones.Clear();
						string datos = mz.erp.businessrules.Workflow.GetHTMLRetenciones(IdRetencion);
						this.richInfoRetenciones.AddHTML(datos);
					}
					else this.richInfoRetenciones.Clear();
				}
			}
		}

		private void chkFechaRetencion_Click(object sender, EventArgs e)
		{						
			_uiController.FilterByFechaRetencion = chkFechaRetencion.Checked;
			FechaRetencionDesde.Enabled = chkFechaRetencion.Checked;
			FechaRetencionHasta.Enabled = chkFechaRetencion.Checked;
		}

		private void chkFechaRecibo_Click(object sender, EventArgs e)
		{						
			_uiController.FilterByFechaRecibo = chkFechaRecibo.Checked;
			FechaReciboDesde.Enabled = chkFechaRecibo.Checked;
			FechaReciboHasta.Enabled = chkFechaRecibo.Checked;
		}

		private void chkFechaFactura_Click(object sender, EventArgs e)
		{						
			_uiController.FilterByFechaFactura = chkFechaFactura.Checked;
			FechaFacturaDesde.Enabled = chkFechaFactura.Checked;
			FechaFacturaHasta.Enabled = chkFechaFactura.Checked;
		}


	}
}

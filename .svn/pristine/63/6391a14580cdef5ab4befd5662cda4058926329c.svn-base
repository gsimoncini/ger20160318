using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using mz.erp.ui.forms.classes;
using mz.erp.commontypes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmComprobantesPendientesConsolaEntregas.
	/// </summary>
	public class FrmComprobantesPendientesConsolaEntregas : System.Windows.Forms.Form, ITaskForm
	{
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.ToolBarButton tbbRefresh;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton tbbReiniciar;
		private Janus.Windows.GridEX.GridEX gridComprobantesEntrega;
		private Janus.Windows.GridEX.GridEX gridPreComprobantes;
		private HtmlRichText.HtmlRichTextBox htmlComprobantesEntrega;
		private HtmlRichText.HtmlRichTextBox htmlPreComprobantes;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem Detalles;
		private System.Windows.Forms.ContextMenu contextMenu2;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo uccFechaDesde;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo uccFechaHasta;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private mz.erp.ui.controls.GridManagerView gridManagerView2;
        private controls.mzCuentasControl mzCmbCuenta;
        private Label label1;
		mz.erp.ui.controllers.ComprobantesPendientesConsolaEntregas _uiController;
		public FrmComprobantesPendientesConsolaEntregas(mz.erp.ui.controllers.ComprobantesPendientesConsolaEntregas uiController)
		{
			InitializeComponent();
			_uiController = uiController;
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
			}
			_uiController.OnControllerChanged-=new System.EventHandler( this.ListenerControllerChanges );
			BindingController.Clear(uccFechaDesde,"Value",_uiController,"FechaDesde");
			BindingController.Clear(uccFechaHasta,"Value",_uiController,"FechaHasta");
			base.Dispose( disposing );
		}
		
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComprobantesPendientesConsolaEntregas));
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.uccFechaDesde = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.label7 = new System.Windows.Forms.Label();
            this.uccFechaHasta = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.label6 = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
            this.htmlComprobantesEntrega = new HtmlRichText.HtmlRichTextBox();
            this.gridComprobantesEntrega = new Janus.Windows.GridEX.GridEX();
            this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.htmlPreComprobantes = new HtmlRichText.HtmlRichTextBox();
            this.gridPreComprobantes = new Janus.Windows.GridEX.GridEX();
            this.gridManagerView2 = new mz.erp.ui.controls.GridManagerView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolBarStandar = new System.Windows.Forms.ToolBar();
            this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
            this.tbbRefresh = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.tbbReiniciar = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
            this.imglStandar = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.Detalles = new System.Windows.Forms.MenuItem();
            this.contextMenu2 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mzCmbCuenta = new mz.erp.ui.controls.mzCuentasControl();
            this.label1 = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uccFechaDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uccFechaHasta)).BeginInit();
            this.ultraExplorerBarContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridComprobantesEntrega)).BeginInit();
            this.ultraExplorerBarContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPreComprobantes)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
            this.ultraExplorerBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraExplorerBarContainerControl1
            // 
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbCuenta);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.uccFechaDesde);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label7);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.uccFechaHasta);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label6);
            this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 47);
            this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(913, 53);
            this.ultraExplorerBarContainerControl1.TabIndex = 0;
            // 
            // uccFechaDesde
            // 
            this.uccFechaDesde.BackColor = System.Drawing.SystemColors.Window;
            this.uccFechaDesde.DateButtons.Add(dateButton1);
            this.uccFechaDesde.Location = new System.Drawing.Point(96, 5);
            this.uccFechaDesde.Name = "uccFechaDesde";
            this.uccFechaDesde.NonAutoSizeHeight = 23;
            this.uccFechaDesde.Size = new System.Drawing.Size(96, 21);
            this.uccFechaDesde.TabIndex = 0;
            this.uccFechaDesde.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(24, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 59;
            this.label7.Text = "Fecha Desde";
            // 
            // uccFechaHasta
            // 
            this.uccFechaHasta.BackColor = System.Drawing.SystemColors.Window;
            this.uccFechaHasta.DateButtons.Add(dateButton2);
            this.uccFechaHasta.Location = new System.Drawing.Point(280, 5);
            this.uccFechaHasta.Name = "uccFechaHasta";
            this.uccFechaHasta.NonAutoSizeHeight = 23;
            this.uccFechaHasta.Size = new System.Drawing.Size(96, 21);
            this.uccFechaHasta.TabIndex = 1;
            this.uccFechaHasta.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(208, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 57;
            this.label6.Text = "Fecha Hasta";
            // 
            // ultraExplorerBarContainerControl2
            // 
            this.ultraExplorerBarContainerControl2.Controls.Add(this.gridManagerView1);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.htmlComprobantesEntrega);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.gridComprobantesEntrega);
            this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 157);
            this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
            this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(913, 199);
            this.ultraExplorerBarContainerControl2.TabIndex = 1;
            // 
            // gridManagerView1
            // 
            this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
            this.gridManagerView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridManagerView1.Location = new System.Drawing.Point(0, 0);
            this.gridManagerView1.Name = "gridManagerView1";
            this.gridManagerView1.Size = new System.Drawing.Size(913, 24);
            this.gridManagerView1.TabIndex = 2;
            // 
            // htmlComprobantesEntrega
            // 
            this.htmlComprobantesEntrega.Location = new System.Drawing.Point(360, 24);
            this.htmlComprobantesEntrega.Name = "htmlComprobantesEntrega";
            this.htmlComprobantesEntrega.ReadOnly = true;
            this.htmlComprobantesEntrega.Size = new System.Drawing.Size(560, 168);
            this.htmlComprobantesEntrega.TabIndex = 1;
            this.htmlComprobantesEntrega.Text = "";
            this.htmlComprobantesEntrega.WordWrap = false;
            // 
            // gridComprobantesEntrega
            // 
            this.gridComprobantesEntrega.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridComprobantesEntrega.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridComprobantesEntrega.GroupByBoxVisible = false;
            this.gridComprobantesEntrega.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridComprobantesEntrega.Location = new System.Drawing.Point(3, 24);
            this.gridComprobantesEntrega.Name = "gridComprobantesEntrega";
            this.gridComprobantesEntrega.Size = new System.Drawing.Size(349, 168);
            this.gridComprobantesEntrega.TabIndex = 0;
            // 
            // ultraExplorerBarContainerControl3
            // 
            this.ultraExplorerBarContainerControl3.Controls.Add(this.htmlPreComprobantes);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.gridPreComprobantes);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.gridManagerView2);
            this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 413);
            this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
            this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(913, 194);
            this.ultraExplorerBarContainerControl3.TabIndex = 2;
            // 
            // htmlPreComprobantes
            // 
            this.htmlPreComprobantes.Location = new System.Drawing.Point(360, 24);
            this.htmlPreComprobantes.Name = "htmlPreComprobantes";
            this.htmlPreComprobantes.ReadOnly = true;
            this.htmlPreComprobantes.Size = new System.Drawing.Size(560, 168);
            this.htmlPreComprobantes.TabIndex = 1;
            this.htmlPreComprobantes.Text = "";
            this.htmlPreComprobantes.WordWrap = false;
            // 
            // gridPreComprobantes
            // 
            this.gridPreComprobantes.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridPreComprobantes.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridPreComprobantes.GroupByBoxVisible = false;
            this.gridPreComprobantes.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridPreComprobantes.Location = new System.Drawing.Point(3, 24);
            this.gridPreComprobantes.Name = "gridPreComprobantes";
            this.gridPreComprobantes.Size = new System.Drawing.Size(349, 168);
            this.gridPreComprobantes.TabIndex = 0;
            // 
            // gridManagerView2
            // 
            this.gridManagerView2.BackColor = System.Drawing.SystemColors.Control;
            this.gridManagerView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridManagerView2.Location = new System.Drawing.Point(0, 0);
            this.gridManagerView2.Name = "gridManagerView2";
            this.gridManagerView2.Size = new System.Drawing.Size(913, 24);
            this.gridManagerView2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolBarStandar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 32);
            this.panel1.TabIndex = 0;
            // 
            // toolBarStandar
            // 
            this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbAnterior,
            this.tbbSeparator,
            this.tbbSiguiente,
            this.tbbSeparator2,
            this.tbbRefresh,
            this.toolBarButton1,
            this.tbbReiniciar,
            this.toolBarButton2,
            this.tbbCancelar});
            this.toolBarStandar.DropDownArrows = true;
            this.toolBarStandar.ImageList = this.imglStandar;
            this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
            this.toolBarStandar.Name = "toolBarStandar";
            this.toolBarStandar.ShowToolTips = true;
            this.toolBarStandar.Size = new System.Drawing.Size(979, 28);
            this.toolBarStandar.TabIndex = 19;
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
            // tbbSeparator2
            // 
            this.tbbSeparator2.Name = "tbbSeparator2";
            this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbRefresh
            // 
            this.tbbRefresh.ImageIndex = 2;
            this.tbbRefresh.Name = "tbbRefresh";
            this.tbbRefresh.Text = "Ejecutar Consulta[F5]";
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbReiniciar
            // 
            this.tbbReiniciar.Enabled = false;
            this.tbbReiniciar.ImageIndex = 5;
            this.tbbReiniciar.Name = "tbbReiniciar";
            this.tbbReiniciar.Text = "Reiniciar Filtros de Busqueda";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbCancelar
            // 
            this.tbbCancelar.ImageIndex = 7;
            this.tbbCancelar.Name = "tbbCancelar";
            this.tbbCancelar.Text = "Cancelar";
            // 
            // imglStandar
            // 
            this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
            this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
            //German 20120413 - Tarea 0000247
            /*
            this.imglStandar.Images.SetKeyName(0, "");
            this.imglStandar.Images.SetKeyName(1, "");
            this.imglStandar.Images.SetKeyName(2, "");
            this.imglStandar.Images.SetKeyName(3, "");
            this.imglStandar.Images.SetKeyName(4, "");
            this.imglStandar.Images.SetKeyName(5, "");
            this.imglStandar.Images.SetKeyName(6, "");
            this.imglStandar.Images.SetKeyName(7, "");
            this.imglStandar.Images.SetKeyName(8, "");
            this.imglStandar.Images.SetKeyName(9, "");
             * */
            //Fin German 20120413 - Tarea 0000247
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ultraExplorerBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(979, 478);
            this.panel2.TabIndex = 1;
            // 
            // ultraExplorerBar1
            // 
            this.ultraExplorerBar1.AnimationEnabled = false;
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
            this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
            ultraExplorerBarGroup1.Key = "Filtros";
            ultraExplorerBarGroup1.Settings.ContainerHeight = 53;
            ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup1.Text = "Filtros";
            ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
            ultraExplorerBarGroup2.Key = "ComprobantesPrincipales";
            ultraExplorerBarGroup2.Settings.ContainerHeight = 199;
            ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup2.Text = "Pendientes de Entrega";
            ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl3;
            ultraExplorerBarGroup3.Key = "ComprobantesSecundarios";
            ultraExplorerBarGroup3.Settings.ContainerHeight = 194;
            ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup3.Text = "Pendientes de Preparado";
            this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2,
            ultraExplorerBarGroup3});
            this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 0);
            this.ultraExplorerBar1.Name = "ultraExplorerBar1";
            this.ultraExplorerBar1.Size = new System.Drawing.Size(979, 478);
            this.ultraExplorerBar1.TabIndex = 0;
            this.ultraExplorerBar1.TabStop = false;
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
            // contextMenu2
            // 
            this.contextMenu2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Ver detalles";
            // 
            // mzCmbCuenta
            // 
            this.mzCmbCuenta.AllowEditClientePaso = false;
            this.mzCmbCuenta.BackColor = System.Drawing.SystemColors.Control;
            this.mzCmbCuenta.DataValue = "";
            this.mzCmbCuenta.EnableCtaCte = false;
            this.mzCmbCuenta.FastSearch = false;
            this.mzCmbCuenta.Location = new System.Drawing.Point(95, 27);
            this.mzCmbCuenta.Name = "mzCmbCuenta";
            this.mzCmbCuenta.ReseteaCodCta = false;
            this.mzCmbCuenta.SearchObjectListener = null;
            this.mzCmbCuenta.Size = new System.Drawing.Size(512, 22);
            this.mzCmbCuenta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 112;
            this.label1.Text = "Cuenta";
            // 
            // FrmComprobantesPendientesConsolaEntregas
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(979, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmComprobantesPendientesConsolaEntregas";
            this.Text = "FrmComprobantesPendientesConsolaEntregas";
            this.ultraExplorerBarContainerControl1.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uccFechaDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uccFechaHasta)).EndInit();
            this.ultraExplorerBarContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridComprobantesEntrega)).EndInit();
            this.ultraExplorerBarContainerControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPreComprobantes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
            this.ultraExplorerBar1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		#region Miembros de ITaskForm

		public void ShowForm()
		{
			base.Show();
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

		public void Execute()
		{
			_uiController.Execute();
		}

		public void Previous()
		{
			// TODO: agregar la implementación FrmComprobantesPendientesConsolaEntregas.Previous
		}

		#endregion

		private void Build_UI()
		{
            /* Silvina 20120416 - Tarea 0000277 */
            utility.Util.LoadImages(toolBarStandar, imglStandar);
            /* Fin Silvina 20120416 - Tarea 0000277 */

			/* Silvina 20100614 - Tarea 37 */

			//this.gridComprobantesEntrega.LayoutData = _uiController.LayoutGridComprobantesEntrega;
			//this.gridPreComprobantes.LayoutData= _uiController.LayoutGridComprobantesEntrega;
			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), gridComprobantesEntrega, this.Text);
			gridManagerView2.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), gridPreComprobantes, this.Text);

			/* Fin Silvina */    

			this.KeyPreview = true;
			this.tbbAnterior.Text = _uiController.TextoBotonPrevio;
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSiguiente.Enabled = !_uiController.IsLastTask() && !_uiController.IsFlushedState();
			this.tbbSiguiente.Text = _uiController.TextoBotonSiguiente;						
			this.Text = _uiController.LeyendaFormulario;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			_uiController.OnControllerChanged+= new System.EventHandler( this.ListenerControllerChanges );
			this.gridComprobantesEntrega.SelectionChanged+=new EventHandler(gridComprobantesEntrega_SelectionChanged);
			this.gridPreComprobantes.SelectionChanged+=new EventHandler(gridPreComprobantes_SelectionChanged);
			BindingController.Bind(uccFechaDesde,"Value",_uiController,"FechaDesde");
			BindingController.Bind(uccFechaHasta,"Value",_uiController,"FechaHasta");
			_uiController.RefreshData();
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConsultas_KeyDown);
			//if(_uiController.VerHTML && _uiController.MetodoVisualizacionHTML.Equals("PORDEMANDA"))
			//{
				this.gridComprobantesEntrega.ContextMenu = this.contextMenu1;
				this.gridPreComprobantes.ContextMenu = this.contextMenu2;
				this.Detalles.Click +=new EventHandler(Detalles_Click);
				this.menuItem1.Click +=new EventHandler(menuItem1_Click);				
			//}
			if(_uiController.AllowMultipleSelect)
				gridComprobantesEntrega.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
				
			else
				gridComprobantesEntrega.SelectionMode = Janus.Windows.GridEX.SelectionMode.SingleSelection;
			
			foreach( Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup group in this.ultraExplorerBar1.Groups)
			{
				group.Visible = false;
			}
			if(!_uiController.ContenedoresVisibles.Equals(string.Empty))
			{
				ArrayList cont = mz.erp.systemframework.Util.Parse(_uiController.ContenedoresVisibles, ",");
				foreach(string grupo in cont)
				{
					this.ultraExplorerBar1.Groups[grupo].Visible = true;
				}
			}
			uccFechaDesde.Enabled = _uiController.AllowEditarFechas;
			uccFechaHasta.Enabled = _uiController.AllowEditarFechas;
		
			KeyPreview = true;
			KeyDownManager KeyDown = new KeyDownManager(this);

			mz.erp.ui.forms.classes.ContainerManager.CollapseContainers(ultraExplorerBar1, _uiController.GetProcessName(), _uiController.GetTaskName());

            //Cristian Tarea 0000050 20110310
            this.uccFechaDesde.ValueChanged += new EventHandler(FechaDesde_ValueChanged);
            //Fin Cristian
            //Cristian Tarea 0000146 20110725
            this.uccFechaHasta.ValueChanged += new EventHandler(uccFechaHasta_ValueChanged);
            //Fin Cristian 20110725

            //German 20120413 - Tarea 0000247
            mzCmbCuenta.Init(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName());
            mzCmbCuenta.Enabled = true;
            mzCmbCuenta.EnableCtaCte = false;
            mzCmbCuenta.AllowEditClientePaso = false;
            mzCmbCuenta.DataValue = _uiController.CodigoCuenta;
            mzCmbCuenta.ValueChanged += new System.EventHandler(this.Componentes_Changes);
            //Fin German 20120413 - Tarea 0000247

        }


        //German 20120413 - Tarea 0000247
        private void Componentes_Changes(object sender, System.EventArgs e)
        {

            _uiController.CodigoCuenta = Convert.ToString(mzCmbCuenta.DataValue);
          
        }
        //Fin German 20120413 - Tarea 0000247
        //Cristian Tarea 0000146 20110725
        void uccFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(uccFechaHasta.Value)), true);
            this.uccFechaDesde.Value = _uiController.FechaDesde;
        }
        //Fin Cristiah
        //Cristian Tarea 0000050 20110310
        void FechaDesde_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(uccFechaDesde.Value)),false);
            this.uccFechaHasta.Value = _uiController.FechaHasta;

        }
        //Fin Cristian

		private void FrmConsultas_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == System.Windows.Forms.Keys.F5)
				this._uiController.RefreshData();
		}
		private void ListenerControllerChanges(object sender, System.EventArgs e )
		{
			this.gridComprobantesEntrega.SetDataBinding( null, null);
			this.gridComprobantesEntrega.SetDataBinding( _uiController.ComprobantesEntrega,null);
			this.gridPreComprobantes.SetDataBinding( null, null);
			this.gridPreComprobantes.SetDataBinding( _uiController.ComprobantesPrevios,null);
		}

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
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
					_uiController.RefreshData();
					break;
				case 8:
					CloseForm();
					break;
			}		
		}

		private void gridComprobantesEntrega_SelectionChanged(object sender, EventArgs e)
		{
			/*if(_uiController.VerHTML && _uiController.MetodoVisualizacionHTML.Equals("AUTOMATICO"))
			{
				if (this.gridComprobantesEntrega.SelectedItems.Count == 1)
				{
					_uiController.KeyValueComprobanteEntrega = this.gridComprobantesEntrega.SelectedItems[0].GetRow().Cells[ _uiController.KeyComprobantesEntrega ].Value;
					string infoDetallada = string.Empty;
					infoDetallada = Convert.ToString(this.gridComprobantesEntrega.SelectedItems[0].GetRow().Cells["TextoHTML"].Value);
					this.htmlComprobantesEntrega.Clear();
					this.htmlComprobantesEntrega.AddHTML(infoDetallada);
				}
			}
			else
			{*/
				//if(_uiController.VerHTML && _uiController.MetodoVisualizacionHTML.ToUpper().Equals("PORDEMANDA"))
				//{
					if(this.gridComprobantesEntrega.SelectedItems.Count > 0)
					{
						string datos = string.Empty;
						if (gridComprobantesEntrega.SelectedItems.Count == 1 && gridComprobantesEntrega.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
						{
							string IdComprobante = Convert.ToString(gridComprobantesEntrega.SelectedItems[0].GetRow().Cells["IdComprobante"].Value);
							string IdTipoDeComprobante = Convert.ToString(gridComprobantesEntrega.SelectedItems[0].GetRow().Cells["IdTipoDeComprobante"].Value);
							if(!IdComprobante.Equals(string.Empty) && !IdTipoDeComprobante.Equals(string.Empty))
							{
								_uiController.KeyValueComprobanteEntrega = this.gridComprobantesEntrega.SelectedItems[0].GetRow().Cells[ _uiController.KeyComprobantesEntrega ].Value;
								this.htmlComprobantesEntrega.Clear();
								datos = mz.erp.businessrules.Workflow.GetHTMLComprobantesResumido(IdComprobante, IdTipoDeComprobante);
								this.htmlComprobantesEntrega.AddHTML(datos);
							}
							else this.htmlComprobantesEntrega.Clear();															
						}								
					}
					else this.htmlPreComprobantes.Clear();
				//}
				//else this.htmlPreComprobantes.Clear();
			//}						
		}

		private void gridPreComprobantes_SelectionChanged(object sender, EventArgs e)
		{
			/*if(_uiController.VerHTML && _uiController.MetodoVisualizacionHTML.Equals("AUTOMATICO"))
			{		
				if (this.gridPreComprobantes.SelectedItems.Count == 1)
				{
					_uiController.KeyValueComprobantesPrevios = this.gridPreComprobantes.SelectedItems[0].GetRow().Cells[ _uiController.KeyComprobantesPrevios ].Value;
					string infoDetallada = string.Empty;
					infoDetallada = Convert.ToString(this.gridPreComprobantes.SelectedItems[0].GetRow().Cells["TextoHTML"].Value);
					this.htmlPreComprobantes.Clear();
					this.htmlPreComprobantes.AddHTML(infoDetallada);
				}
			}
			else
			{*/
				//if(_uiController.VerHTML && _uiController.MetodoVisualizacionHTML.ToUpper().Equals("PORDEMANDA"))
				//{
					if(this.gridPreComprobantes.SelectedItems.Count > 0)
					{
						string datos = string.Empty;
						if (gridPreComprobantes.SelectedItems.Count == 1 && gridPreComprobantes.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
						{
							string IdComprobante = Convert.ToString(gridPreComprobantes.SelectedItems[0].GetRow().Cells["IdComprobante"].Value);
							string IdTipoDeComprobante = Convert.ToString(gridPreComprobantes.SelectedItems[0].GetRow().Cells["IdTipoDeComprobante"].Value);
							if(!IdComprobante.Equals(string.Empty) && !IdTipoDeComprobante.Equals(string.Empty))
							{
								_uiController.KeyValueComprobantesPrevios = this.gridPreComprobantes.SelectedItems[0].GetRow().Cells[ _uiController.KeyComprobantesPrevios ].Value;
								this.htmlPreComprobantes.Clear();
								datos = mz.erp.businessrules.Workflow.GetHTMLComprobantesResumido(IdComprobante, IdTipoDeComprobante);
								this.htmlPreComprobantes.AddHTML(datos);
							}
							else this.htmlPreComprobantes.Clear();															
						}								
					}
					else this.htmlPreComprobantes.Clear();
				//}
				//else this.htmlPreComprobantes.Clear();
			//}			
		}

		private void Detalles_Click(object sender, EventArgs e)
		{
			//if(_uiController.VerHTML && _uiController.MetodoVisualizacionHTML.ToUpper().Equals("PORDEMANDA"))
				if(this.gridComprobantesEntrega.SelectedItems.Count > 0)
				{
					string datos = string.Empty;
					if (gridComprobantesEntrega.SelectedItems.Count == 1 && gridComprobantesEntrega.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
					{
						string IdComprobante = Convert.ToString(gridComprobantesEntrega.SelectedItems[0].GetRow().Cells["IdComprobante"].Value);
						string IdTipoDeComprobante = Convert.ToString(gridComprobantesEntrega.SelectedItems[0].GetRow().Cells["IdTipoDeComprobante"].Value);
						if(!IdComprobante.Equals(string.Empty) && !IdTipoDeComprobante.Equals(string.Empty))
						{
							this.htmlComprobantesEntrega.Clear();
							datos = mz.erp.businessrules.Workflow.GetHTMLComprobantes(IdComprobante, IdTipoDeComprobante);
							this.htmlComprobantesEntrega.AddHTML(datos);
						}
						else this.htmlComprobantesEntrega.Clear();															
					}								
				}
		}

		private void menuItem1_Click(object sender, EventArgs e)
		{
			//if(_uiController.VerHTML && _uiController.MetodoVisualizacionHTML.ToUpper().Equals("PORDEMANDA"))
				if(this.gridPreComprobantes.SelectedItems.Count > 0)
				{
					string datos = string.Empty;
					if (gridPreComprobantes.SelectedItems.Count == 1 && gridPreComprobantes.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
					{
						string IdComprobante = Convert.ToString(gridPreComprobantes.SelectedItems[0].GetRow().Cells["IdComprobante"].Value);
						string IdTipoDeComprobante = Convert.ToString(gridPreComprobantes.SelectedItems[0].GetRow().Cells["IdTipoDeComprobante"].Value);
						if(!IdComprobante.Equals(string.Empty) && !IdTipoDeComprobante.Equals(string.Empty))
						{
							this.htmlPreComprobantes.Clear();
							datos = mz.erp.businessrules.Workflow.GetHTMLComprobantes(IdComprobante, IdTipoDeComprobante);
							this.htmlPreComprobantes.AddHTML(datos);
						}
						else this.htmlPreComprobantes.Clear();															
					}								
				}
		}
	}
}

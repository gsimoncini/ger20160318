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
	/// Descripción breve de FrmConsultarSeguimientoCompras.
	/// </summary>
	public class FrmConsultarSeguimientoCompras : System.Windows.Forms.Form, ITaskForm, ISearchObjectListener
	{
		private System.ComponentModel.IContainer components;

		#region Constructores y Destructores

		public FrmConsultarSeguimientoCompras()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		public FrmConsultarSeguimientoCompras(controllers.ConsultarSeguimientoComprasController controller)
		{
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
				mzCmb.DataBindings.Clear();
				FechaDesde.DataBindings.Clear();
				FechaHasta.DataBindings.Clear();
				this.toolBarStandar.ButtonClick -= new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
				_uiController.DataChanged-=new EventHandler(RefreshData);
				this.Detalles.Click -=new EventHandler(Detalles_Click);
				this.gridResultado.Click -=new EventHandler(gridResultado_Click);

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmConsultarSeguimientoCompras));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.lbTarea = new System.Windows.Forms.Label();
			this.ContainerFiltro = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.mzCmb = new mz.erp.ui.controls.mzProveedoresControl();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.FechaHasta = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.label7 = new System.Windows.Forms.Label();
			this.FechaDesde = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.gridResultado = new Janus.Windows.GridEX.GridEX();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.Detalles = new System.Windows.Forms.MenuItem();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.richInfoRetenciones = new HtmlRichText.HtmlRichTextBox();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton11 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton12 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton13 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton14 = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparadorImprimir = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton16 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.ContainerFiltro.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.FechaHasta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaDesde)).BeginInit();
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
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, -17);
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
			this.ContainerFiltro.Controls.Add(this.mzCmb);
			this.ContainerFiltro.Controls.Add(this.label1);
			this.ContainerFiltro.Controls.Add(this.label2);
			this.ContainerFiltro.Controls.Add(this.FechaHasta);
			this.ContainerFiltro.Controls.Add(this.label7);
			this.ContainerFiltro.Controls.Add(this.FechaDesde);
			this.ContainerFiltro.Location = new System.Drawing.Point(28, -83);
			this.ContainerFiltro.Name = "ContainerFiltro";
			this.ContainerFiltro.Size = new System.Drawing.Size(878, 76);
			this.ContainerFiltro.TabIndex = 0;
			// 
			// mzCmb
			// 
			this.mzCmb.BackColor = System.Drawing.SystemColors.Control;
			this.mzCmb.DataValue = "";
			this.mzCmb.EnableCtaCte = false;
			this.mzCmb.FastSearch = false;
			this.mzCmb.Location = new System.Drawing.Point(144, 48);
			this.mzCmb.Name = "mzCmb";
			this.mzCmb.SearchObjectListener = null;
			this.mzCmb.Size = new System.Drawing.Size(490, 22);
			this.mzCmb.TabIndex = 2;
			this.mzCmb.Tag = "ResponsableEmision";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(8, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 17);
			this.label1.TabIndex = 131;
			this.label1.Tag = "Proveedor";
			this.label1.Text = "Proveedor";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(8, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 16);
			this.label2.TabIndex = 130;
			this.label2.Tag = "FechaHasta";
			this.label2.Text = "Fecha Hasta";
			// 
			// FechaHasta
			// 
			dateButton1.Caption = "Today";
			this.FechaHasta.DateButtons.Add(dateButton1);
			this.FechaHasta.Location = new System.Drawing.Point(144, 24);
			this.FechaHasta.Name = "FechaHasta";
			this.FechaHasta.NonAutoSizeHeight = 23;
			this.FechaHasta.Size = new System.Drawing.Size(96, 21);
			this.FechaHasta.TabIndex = 1;
			this.FechaHasta.Tag = "FechaHasta";
			this.FechaHasta.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(8, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(128, 16);
			this.label7.TabIndex = 123;
			this.label7.Tag = "FechaDesde";
			this.label7.Text = "Fecha Desde";
			// 
			// FechaDesde
			// 
			dateButton2.Caption = "Today";
			this.FechaDesde.DateButtons.Add(dateButton2);
			this.FechaDesde.Location = new System.Drawing.Point(144, 0);
			this.FechaDesde.Name = "FechaDesde";
			this.FechaDesde.NonAutoSizeHeight = 23;
			this.FechaDesde.Size = new System.Drawing.Size(96, 21);
			this.FechaDesde.TabIndex = 0;
			this.FechaDesde.Tag = "FechaDesde";
			this.FechaDesde.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
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
			ultraExplorerBarGroup2.Settings.ContainerHeight = 76;
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
			this.ultraExplorerBar1.TabIndex = 24;
			this.ultraExplorerBar1.TabStop = false;
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
																							  this.toolBarButton16,
																							  this.tbbCancelar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(944, 28);
			this.toolBarStandar.TabIndex = 23;
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
			// toolBarButton16
			// 
			this.toolBarButton16.ImageIndex = 9;
			this.toolBarButton16.Text = "&Selección";
			this.toolBarButton16.Visible = false;
			// 
			// tbbCancelar
			// 
			this.tbbCancelar.ImageIndex = 7;
			this.tbbCancelar.Text = "Cancelar";
			// 
			// FrmConsultarSeguimientoCompras
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(944, 422);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmConsultarSeguimientoCompras";
			this.Text = "FrmConsultarSeguimientoCompras";
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.ContainerFiltro.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.FechaHasta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaDesde)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem Detalles;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ContainerFiltro;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		protected Janus.Windows.GridEX.GridEX gridResultado;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.Label lbTarea;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private HtmlRichText.HtmlRichTextBox richInfoRetenciones;
		protected System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton toolBarButton11;
		private System.Windows.Forms.ToolBarButton toolBarButton12;
		private System.Windows.Forms.ToolBarButton toolBarButton13;
		private System.Windows.Forms.ToolBarButton toolBarButton14;
		private System.Windows.Forms.ToolBarButton tbbSeparadorImprimir;
		private System.Windows.Forms.ToolBarButton toolBarButton16;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo FechaHasta;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo FechaDesde;
		private System.Windows.Forms.Label label1;
		private mz.erp.ui.controls.mzProveedoresControl mzCmb;
		private System.Windows.Forms.ToolBarButton tbbCancelar;


		#region Variables Privadas
		private controllers.ConsultarSeguimientoComprasController _uiController;
		#endregion

		#region Inicializadores y Carga
		protected void Build_UI()
		{
			ConfigureInterface();	
			InitializeData();
			InitEventHandlers();
			InitDataBindings();		
			//RefreshData();
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
			mzCmb.Init();
			mzCmb.SearchObjectListener = this;
			mzCmb.EnableCtaCte = _uiController.EnabledButtonCuentaCtaCte;
			KeyPreview = true;

		}


		private void InitializeData()
		{
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
            this.FechaDesde.ValueChanged += new EventHandler(FechaDesde_ValueChanged);
            //Fin Cristian

        }
        //Cristian Tarea 0000050 20110310
        void FechaDesde_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(FechaDesde.Value)));
            this.FechaHasta.Value = _uiController.FechaHasta;

        }
        //Fin Cristian

		private void InitDataBindings()
		{
			mzCmb.DataBindings.Add("DataValue", _uiController, "CodigoProveedor");
			FechaDesde.DataBindings.Add("Value", _uiController, "FechaDesde");
			FechaHasta.DataBindings.Add("Value", _uiController, "FechaHasta");

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

		private void KeyDownBehavior(object sender, KeyEventArgs e)
		{
			switch (e.KeyData )
			{
				case System.Windows.Forms.Keys.F5 :
					this.RefreshData();
					break;
			}
		}

		protected void RefreshData()
		{
			Util.MoveFocus(this.ContainerFiltro);
			this.Cursor = Cursors.WaitCursor;
			gridResultado.Focus();
			_uiController.RefreshData();
			this.Cursor = Cursors.Default;
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
			_uiController.ResetFechas();
			FechaDesde.Value=_uiController.FechaDesde;
			FechaHasta.Value=_uiController.FechaHasta;
			mzCmb.ClearControl(); //mzCmb.DataValue=string.Empty;
			_uiController.CodigoProveedor=string.Empty;
			gridResultado.SetDataBinding(null, null);
			gridResultado.Refresh();
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
					if(!IdComprobante.Equals(string.Empty))
					{
						this.richInfoRetenciones.Clear();
						string datos = mz.erp.businessrules.Workflow.GetHTMLComprobantesDeComprasPendientes(IdComprobante);
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

		private void gridResultado_Click(object sender, EventArgs e)
		{
			bool visualizaDetalle = _uiController.VisualizaDetalle;
			string metodoVisualizacion = _uiController.MetodoVisualizacion;
			if(visualizaDetalle && metodoVisualizacion.Equals("PORDEMANDA"))
			{
				if(gridResultado.SelectedItems.Count > 0 && gridResultado.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
				{
					string IdComprobante = Convert.ToString(gridResultado.SelectedItems[0].GetRow().Cells["IdComprobante"].Value);
					if(!IdComprobante.Equals(string.Empty))
					{
						this.richInfoRetenciones.Clear();
						string datos = mz.erp.businessrules.Workflow.GetHTMLComprobantesDeComprasPendientes(IdComprobante);
						this.richInfoRetenciones.AddHTML(datos);
					}
					else this.richInfoRetenciones.Clear();
				}
			}
		}


	}
}

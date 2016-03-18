using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.commontypes;
using mz.erp.ui.controllers;
using mz.erp.ui.controls;
using mz.erp.ui.forms.classes;
using mz.erp.ui.utility;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmAjusteDeStock.
	/// </summary>
	public class FrmAjusteDeStock : System.Windows.Forms.Form , ITaskForm
	{
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl containerItems;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Label labelTarea;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private System.Windows.Forms.ImageList imglStandar;
		private mzProductosControl mzProductosControl1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private Janus.Windows.GridEX.GridEX gridProductos;
		private mz.erp.ui.controls.mzComboEditor mzCmbSecciones;
		private mz.erp.ui.controls.mzComboEditor mzCmbDepositos;
		private mz.erp.ui.controls.mzComboEditor mzCmbTiposDeAjuste;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtEstadoDeStock;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor uTEObservaciones;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private string signo;

		public FrmAjusteDeStock()
		{
			InitializeComponent();
		}

		public FrmAjusteDeStock (string sig)
		{
			InitializeComponent();
			signo = sig;
		}

		public FrmAjusteDeStock (AjusteDeStockController controller)
		{
			_uiController = controller;	
			InitializeComponent();
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
				_uiController.OnModelChanged-=new EventHandler(_uiController_OnModelChanged);
				_uiController.IdTipoDeAjusteChanged -=new EventHandler(_uiController_IdTipoDeAjusteChanged);
				BindingController.Clear(mzCmbTiposDeAjuste,"Value", _uiController, "IdTipoDeAjuste");
				BindingController.Clear(uTEObservaciones, "Text", _uiController, "Observaciones");
				this.gridProductos.SetDataBinding( null, null );
			}
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjusteDeStock));
            this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.labelTarea = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.txtEstadoDeStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mzProductosControl1 = new mz.erp.ui.controls.mzProductosControl();
            this.mzCmbSecciones = new mz.erp.ui.controls.mzComboEditor();
            this.mzCmbDepositos = new mz.erp.ui.controls.mzComboEditor();
            this.mzCmbTiposDeAjuste = new mz.erp.ui.controls.mzComboEditor();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.containerItems = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.gridProductos = new Janus.Windows.GridEX.GridEX();
            this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
            this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.uTEObservaciones = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraExplorerBar = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.toolBarStandar = new System.Windows.Forms.ToolBar();
            this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
            this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
            this.imglStandar = new System.Windows.Forms.ImageList(this.components);
            this.ultraExplorerBarContainerControl2.SuspendLayout();
            this.ultraExplorerBarContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbSecciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbDepositos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposDeAjuste)).BeginInit();
            this.containerItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.ultraExplorerBarContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uTEObservaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar)).BeginInit();
            this.ultraExplorerBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraExplorerBarContainerControl2
            // 
            this.ultraExplorerBarContainerControl2.Controls.Add(this.labelTarea);
            this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 24);
            this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
            this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(806, 25);
            this.ultraExplorerBarContainerControl2.TabIndex = 2;
            // 
            // labelTarea
            // 
            this.labelTarea.BackColor = System.Drawing.Color.Transparent;
            this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarea.Location = new System.Drawing.Point(0, 0);
            this.labelTarea.Name = "labelTarea";
            this.labelTarea.Size = new System.Drawing.Size(806, 23);
            this.labelTarea.TabIndex = 1;
            this.labelTarea.Text = "Tarea";
            this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ultraExplorerBarContainerControl1
            // 
            this.ultraExplorerBarContainerControl1.Controls.Add(this.txtEstadoDeStock);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzProductosControl1);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbSecciones);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbDepositos);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbTiposDeAjuste);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label4);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label6);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label7);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label8);
            this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 106);
            this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(806, 159);
            this.ultraExplorerBarContainerControl1.TabIndex = 0;
            // 
            // txtEstadoDeStock
            // 
            this.txtEstadoDeStock.Location = new System.Drawing.Point(472, 88);
            this.txtEstadoDeStock.Name = "txtEstadoDeStock";
            this.txtEstadoDeStock.ReadOnly = true;
            this.txtEstadoDeStock.Size = new System.Drawing.Size(272, 20);
            this.txtEstadoDeStock.TabIndex = 4;
            this.txtEstadoDeStock.TabStop = false;
            this.txtEstadoDeStock.Text = "Estado de Stock";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Location = new System.Drawing.Point(376, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Estado de Stock";
            // 
            // mzProductosControl1
            // 
            this.mzProductosControl1.BackColor = System.Drawing.Color.Transparent;
            this.mzProductosControl1.EnabledCantidad = true;
            this.mzProductosControl1.EnabledListaDePrecio = true;
            this.mzProductosControl1.Location = new System.Drawing.Point(88, 0);
            this.mzProductosControl1.Name = "mzProductosControl1";
            this.mzProductosControl1.Size = new System.Drawing.Size(704, 80);
            this.mzProductosControl1.TabIndex = 0;
            this.mzProductosControl1.VisibleCantidad = true;
            this.mzProductosControl1.VisibleComboListaDePrecios = true;
            this.mzProductosControl1.VisibleComboTipoDePrecioDeCosto = false;
            this.mzProductosControl1.VisiblePrecios = true;
            // 
            // mzCmbSecciones
            // 
            appearance1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mzCmbSecciones.Appearance = appearance1;
            this.mzCmbSecciones.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbSecciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mzCmbSecciones.DisplayMember = "";
            this.mzCmbSecciones.DisplayMemberCaption = "";
            this.mzCmbSecciones.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbSecciones.Location = new System.Drawing.Point(96, 136);
            this.mzCmbSecciones.MaxItemsDisplay = 50;
            this.mzCmbSecciones.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbSecciones.Name = "mzCmbSecciones";
            this.mzCmbSecciones.Size = new System.Drawing.Size(272, 21);
            this.mzCmbSecciones.SorterMember = "";
            this.mzCmbSecciones.TabIndex = 3;
            this.mzCmbSecciones.ValueMember = "";
            this.mzCmbSecciones.ValueMemberCaption = "";
            // 
            // mzCmbDepositos
            // 
            appearance2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mzCmbDepositos.Appearance = appearance2;
            this.mzCmbDepositos.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbDepositos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mzCmbDepositos.DisplayMember = "";
            this.mzCmbDepositos.DisplayMemberCaption = "";
            this.mzCmbDepositos.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbDepositos.Location = new System.Drawing.Point(96, 112);
            this.mzCmbDepositos.MaxItemsDisplay = 50;
            this.mzCmbDepositos.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbDepositos.Name = "mzCmbDepositos";
            this.mzCmbDepositos.Size = new System.Drawing.Size(272, 21);
            this.mzCmbDepositos.SorterMember = "";
            this.mzCmbDepositos.TabIndex = 2;
            this.mzCmbDepositos.ValueMember = "";
            this.mzCmbDepositos.ValueMemberCaption = "";
            // 
            // mzCmbTiposDeAjuste
            // 
            appearance3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mzCmbTiposDeAjuste.Appearance = appearance3;
            this.mzCmbTiposDeAjuste.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbTiposDeAjuste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mzCmbTiposDeAjuste.DisplayMember = "";
            this.mzCmbTiposDeAjuste.DisplayMemberCaption = "";
            this.mzCmbTiposDeAjuste.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbTiposDeAjuste.Location = new System.Drawing.Point(96, 88);
            this.mzCmbTiposDeAjuste.MaxItemsDisplay = 50;
            this.mzCmbTiposDeAjuste.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbTiposDeAjuste.Name = "mzCmbTiposDeAjuste";
            this.mzCmbTiposDeAjuste.Size = new System.Drawing.Size(272, 21);
            this.mzCmbTiposDeAjuste.SorterMember = "";
            this.mzCmbTiposDeAjuste.TabIndex = 1;
            this.mzCmbTiposDeAjuste.ValueMember = "";
            this.mzCmbTiposDeAjuste.ValueMemberCaption = "";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Location = new System.Drawing.Point(8, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Sección";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Location = new System.Drawing.Point(8, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Depósito";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Location = new System.Drawing.Point(8, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tipo de ajuste";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Location = new System.Drawing.Point(8, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Producto";
            // 
            // containerItems
            // 
            this.containerItems.Controls.Add(this.gridProductos);
            this.containerItems.Controls.Add(this.gridManagerView1);
            this.containerItems.Location = new System.Drawing.Point(28, 322);
            this.containerItems.Name = "containerItems";
            this.containerItems.Size = new System.Drawing.Size(806, 269);
            this.containerItems.TabIndex = 0;
            // 
            // gridProductos
            // 
            this.gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridProductos.AlternatingColors = true;
            this.gridProductos.AutomaticSort = false;
            this.gridProductos.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridProductos.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProductos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridProductos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridProductos.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridProductos.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
            this.gridProductos.GroupByBoxVisible = false;
            this.gridProductos.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridProductos.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridProductos.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
            this.gridProductos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
            this.gridProductos.Location = new System.Drawing.Point(0, 24);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.RecordNavigatorText = "Registro:|de";
            this.gridProductos.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridProductos.ShowEmptyFields = false;
            this.gridProductos.Size = new System.Drawing.Size(806, 245);
            this.gridProductos.TabIndex = 0;
            this.gridProductos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            // 
            // gridManagerView1
            // 
            this.gridManagerView1.BackColor = System.Drawing.Color.Transparent;
            this.gridManagerView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridManagerView1.Location = new System.Drawing.Point(0, 0);
            this.gridManagerView1.Name = "gridManagerView1";
            this.gridManagerView1.Size = new System.Drawing.Size(806, 24);
            this.gridManagerView1.TabIndex = 1;
            // 
            // ultraExplorerBarContainerControl3
            // 
            this.ultraExplorerBarContainerControl3.Controls.Add(this.uTEObservaciones);
            this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
            this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(862, 150);
            this.ultraExplorerBarContainerControl3.TabIndex = 3;
            this.ultraExplorerBarContainerControl3.Visible = false;
            // 
            // uTEObservaciones
            // 
            this.uTEObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uTEObservaciones.Location = new System.Drawing.Point(0, 0);
            this.uTEObservaciones.Multiline = true;
            this.uTEObservaciones.Name = "uTEObservaciones";
            this.uTEObservaciones.Size = new System.Drawing.Size(862, 150);
            this.uTEObservaciones.TabIndex = 0;
            // 
            // ultraExplorerBar
            // 
            this.ultraExplorerBar.AnimationEnabled = false;
            this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl1);
            this.ultraExplorerBar.Controls.Add(this.containerItems);
            this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl2);
            this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl3);
            this.ultraExplorerBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ultraExplorerBar.Dock = System.Windows.Forms.DockStyle.Fill;
            ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl2;
            ultraExplorerBarGroup1.Settings.ContainerHeight = 25;
            ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup1.Text = "Tarea";
            ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
            ultraExplorerBarGroup2.Settings.ContainerHeight = 159;
            ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup2.Text = "Información";
            ultraExplorerBarGroup3.Container = this.containerItems;
            ultraExplorerBarGroup3.Settings.ContainerHeight = 269;
            ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup3.Text = "Detalle de Productos";
            ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl3;
            ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup4.Text = "Observaciones";
            this.ultraExplorerBar.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2,
            ultraExplorerBarGroup3,
            ultraExplorerBarGroup4});
            this.ultraExplorerBar.Location = new System.Drawing.Point(0, 28);
            this.ultraExplorerBar.Name = "ultraExplorerBar";
            this.ultraExplorerBar.Size = new System.Drawing.Size(872, 450);
            this.ultraExplorerBar.TabIndex = 25;
            this.ultraExplorerBar.TabStop = false;
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
            this.toolBarStandar.Size = new System.Drawing.Size(872, 28);
            this.toolBarStandar.TabIndex = 24;
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
            this.tbbCancelar.Text = "Cancelar";
            // 
            // imglStandar
            // 
            this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
            this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
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
            // 
            // FrmAjusteDeStock
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(872, 478);
            this.Controls.Add(this.ultraExplorerBar);
            this.Controls.Add(this.toolBarStandar);
            this.Name = "FrmAjusteDeStock";
            this.Text = "FrmAjusteDeStock";
            this.ultraExplorerBarContainerControl2.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbSecciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbDepositos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposDeAjuste)).EndInit();
            this.containerItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ultraExplorerBarContainerControl3.ResumeLayout(false);
            this.ultraExplorerBarContainerControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uTEObservaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar)).EndInit();
            this.ultraExplorerBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
				this.Init();
				base.Show();
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
			gridProductos.UpdateData();
			Util.MoveFocus(this.ultraExplorerBarContainerControl1);
			_uiController.Execute();
		}

		#endregion

		private void ConfigureInterface()
		{			
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			labelTarea.Text = _uiController.LeyendaFormulario;

			this.Text = _uiController.LeyendaFormulario;
			tbbAnterior.Text= _uiController.TextoBotonAnterior;
			tbbSiguiente.Text= _uiController.TextoBotonSiguiente;
			mzProductosControl1.Enabled = _uiController.AllowAddItems;
			mzProductosControl1.EnabledListaDePrecio = false;
			mzCmbDepositos.Enabled = _uiController.AllowEditDeposito;
			mzCmbSecciones.Enabled = _uiController.AllowEditSeccion;
			mzCmbTiposDeAjuste.Enabled = _uiController.AllowEditAjusteDeStock;
			if(_uiController.AllowEditItems)
				gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
			else gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;

				mzProductosControl1.SetProcess(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), "V");
			KeyPreview = true;
		}

		#region Custom Members
		
		controllers.AjusteDeStockController _uiController;
		
		protected void Init()
		{
			ConfigureInterface();
			Build_UI();
			InitEvents();
			InitDataBindings();			
		}

		private void Build_UI()
		{																			
			//this.mzCmbProductos.WidthSearchForm = _uiController.WidthSearchForm;
			//this.mzCmbProductos.SearchObject = _uiController.ListaProductos;			
		
			if (_uiController.Signo == "+")
			{
				this.mzCmbTiposDeAjuste.FillFromDataSource(_uiController.ListaTipoDeAjustePositivo(), _uiController.TipoAjusteValueMember, _uiController.TipoAjusteDisplayMember,15, _uiController.TipoAjusteValueMember, _uiController.TipoAjusteDisplayMember, "", _uiController.View);
				if (this.mzCmbTiposDeAjuste.Items.Count == 1)			
				{
					_uiController.IdTipoDeAjuste = this.mzCmbTiposDeAjuste.Items[0].DataValue.ToString();
					this.mzCmbTiposDeAjuste.SetValue(_uiController.IdTipoDeAjuste);
					this.mzCmbTiposDeAjuste.Enabled = false;								
				}
			}
			else 
			{
					if (_uiController.Signo == "-")
				{
						this.mzCmbTiposDeAjuste.FillFromDataSource(_uiController.ListaTipoDeAjusteNegativo(), _uiController.TipoAjusteValueMember, _uiController.TipoAjusteDisplayMember,15, _uiController.TipoAjusteValueMember, _uiController.TipoAjusteDisplayMember, "", _uiController.View);
					if (this.mzCmbTiposDeAjuste.Items.Count == 1)			
					{
						_uiController.IdTipoDeAjuste = this.mzCmbTiposDeAjuste.Items[0].DataValue.ToString();
						this.mzCmbTiposDeAjuste.SetValue(_uiController.IdTipoDeAjuste);
						this.mzCmbTiposDeAjuste.Enabled = false;								
					}
				}
				else this.mzCmbTiposDeAjuste.FillFromDataSource(_uiController.ListaTipoDeAjuste, _uiController.TipoAjusteValueMember, _uiController.TipoAjusteDisplayMember,8, "Descripcion", "Descripcion", "", _uiController.View);
			}

			this.mzCmbDepositos.FillFromDataSource( _uiController.ListaDeposito, _uiController.DepositoValueMember,_uiController.DepositoDisplayMember,8,"Descripcion");
			
			if (_uiController.IdDeposito != "") 
			{
				this.mzCmbDepositos.SetValue(_uiController.IdDeposito);
				_uiController.FiltroListaSecciones();				
			}

			this.mzCmbSecciones.FillFromDataSource( _uiController.ListaSeccion, _uiController.SeccionValueMember,_uiController.SeccionDisplayMember,8,"Descripcion");
			if (_uiController.IdSeccion != "") 
			{
				this.mzCmbSecciones.SetValue(_uiController.IdSeccion);
				this.mzCmbSecciones.Enabled = false;
			}			
			if(_uiController.AllowEditItems)
				this.gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridProductos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			this.mzCmbSecciones.Enabled = false;
            /* Silvina 20100604 - Tarea 54 */
            //gridProductos.LayoutData = _uiController.Layout;
            /* Fin Silvina */
			gridProductos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextRow;
			/* Silvina 20100604 - Tarea 54 */
			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), gridProductos, this.Text);
			/* Fin Silvina */
			txtEstadoDeStock.Text = _uiController.EstadoDeStock;
		}
		private void InitEvents()
		{			
			mzCmbDepositos.ValueChanged+= new System.EventHandler( this.Componentes_Changes );
			mzCmbSecciones.ValueChanged+= new System.EventHandler( this.Componentes_Changes );
			_uiController.OnModelChanged+=new EventHandler(_uiController_OnModelChanged);
			_uiController.IdTipoDeAjusteChanged +=new EventHandler(_uiController_IdTipoDeAjusteChanged);
			KeyDownManager KeyDown = new KeyDownManager(this);
			
		}
		private void InitDataBindings()
		{		
			BindingController.Bind(mzCmbTiposDeAjuste,"Value", _uiController, "IdTipoDeAjuste");		
			BindingController.Bind(uTEObservaciones, "Text", _uiController, "Observaciones");
			//this.mzCmbTiposDeAjuste.DataBindings.Add("Value", _uiController, "IdTipoDeAjuste");
			this.mzCmbDepositos.DataBindings.Add("Value", _uiController, "IdDeposito");
			this.mzCmbSecciones.DataBindings.Add("Value", _uiController, "IdSeccion");
			this.mzProductosControl1.AddObjectListener( (IObserver)_uiController );
			
			this.gridProductos.SetDataBinding( null, null );
			this.gridProductos.SetDataBinding(_uiController.Items, null);
			this.gridProductos.Refresh();
			this.gridProductos.Refetch();
		}

		private void EventsListener()
		{
			
		}

		private void Componentes_Changes(object sender, System.EventArgs e)
		{		
			if (((Control)sender).Name == "mzCmbProductos")
			{
				/*if (mzCmbProductos.SelectedRow != null) 
				{
					_uiController.IdProducto = mzCmbProductos.SelectedRow["IdProducto"].ToString();				
				}*/
			}
			else
			{
				if (((Control)sender).Name == "mzCmbTiposDeAjuste") 
				{
					txtEstadoDeStock.Text = _uiController.EstadoDeStock;
				}								
				else 
				{
					if (((Control)sender).Name == "mzCmbDepositos") 
					{
						if (mzCmbDepositos.Value != null) 
						{														
							_uiController.IdDeposito = (string) mzCmbDepositos.Value;
							_uiController.FiltroListaSecciones();
							this.mzCmbSecciones.FillFromDataSource( _uiController.ListaSeccion, _uiController.SeccionValueMember,_uiController.SeccionDisplayMember,8,"Descripcion");
							//Verifico que si existe una sola sección para el depósito seleccionado, que automáticamente lo muestre.
							if (_uiController.CantidadSecciones == 1) 
							{
								this.mzCmbSecciones.SetValue(_uiController.IdSeccion);
								this.mzCmbSecciones.Enabled = false;								
							}
							else 
							{
								this.mzCmbSecciones.Enabled = true;
							}
						}
					}
				}					
			}						
		}		

		protected void Aceptar()
		{
			Util.MoveFocus(this.ultraExplorerBarContainerControl1);				
			this.Execute();	
		}

		protected void Evaluate()
		{
			
		}

		#endregion

		private void _uiController_OnModelChanged(object sender, EventArgs e)
		{
			this.gridProductos.SetDataBinding( null, null );
			this.gridProductos.SetDataBinding(_uiController.Items, null);
		}


	

		
		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					_uiController.Previous();
					break;
				case 2:
					gridProductos.UpdateData();
					Util.MoveFocus(this.ultraExplorerBarContainerControl1);
					_uiController.Execute();
					break;
				case 4:
					CloseForm();
					break;
			}
		}

		private void _uiController_IdTipoDeAjusteChanged(object sender, EventArgs e)
		{
			txtEstadoDeStock.Text = _uiController.EstadoDeStock;
		}
	}
}

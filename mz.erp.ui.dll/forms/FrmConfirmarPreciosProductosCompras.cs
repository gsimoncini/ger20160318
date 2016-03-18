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
	/// Descripción breve de FrmConfirmarPreciosProductosCompras.
	/// </summary>
	public class FrmConfirmarPreciosProductosCompras : System.Windows.Forms.Form, ITaskForm
	{
		private System.ComponentModel.IContainer components;

		public FrmConfirmarPreciosProductosCompras(ConfirmarPreciosProductosComprasController UIController)
		{
			InitializeComponent();
			_uiController = UIController;
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

		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Label labelTarea;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl containerProductos;
		private Janus.Windows.GridEX.GridEX gridProductos;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor uTEObservaciones;
		private System.Windows.Forms.GroupBox groupBox1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbProveedor;
		private System.Windows.Forms.GroupBox groupBox2;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo uccFechaFactura;
		private Infragistics.Win.Misc.UltraLabel ultraLabel2;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit umeNumeroFactura;
		private Infragistics.Win.Misc.UltraLabel ultraLabel5;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneValorCotizacionFactura;
		private Infragistics.Win.Misc.UltraLabel ultraLabel31;
		private Infragistics.Win.Misc.UltraLabel ultraLabel32;
		private Infragistics.Win.Misc.UltraLabel ultraLabel33;
		private mz.erp.ui.controls.mzComboEditor mzCEFuenteDeCambioFactura;
		private mz.erp.ui.controls.mzComboEditor mzCEMonedaFactura;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private System.Windows.Forms.CheckBox checkBox1;

		#region Variables Privadas		
		private controllers.ConfirmarPreciosProductosComprasController _uiController = null;		
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmConfirmarPreciosProductosCompras));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.containerProductos = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.gridProductos = new Janus.Windows.GridEX.GridEX();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.uccFechaFactura = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
			this.umeNumeroFactura = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
			this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
			this.uneValorCotizacionFactura = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.ultraLabel31 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel32 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel33 = new Infragistics.Win.Misc.UltraLabel();
			this.mzCEFuenteDeCambioFactura = new mz.erp.ui.controls.mzComboEditor();
			this.mzCEMonedaFactura = new mz.erp.ui.controls.mzComboEditor();
			this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
			this.mzCmbProveedor = new mz.erp.ui.controls.mzComboSearchEditor();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.uTEObservaciones = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			this.containerProductos.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uccFechaFactura)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneValorCotizacionFactura)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEFuenteDeCambioFactura)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMonedaFactura)).BeginInit();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uTEObservaciones)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar)).BeginInit();
			this.ultraExplorerBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, -43);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(846, 34);
			this.ultraExplorerBarContainerControl2.TabIndex = 2;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(846, 23);
			this.labelTarea.TabIndex = 1;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// containerProductos
			// 
			this.containerProductos.Controls.Add(this.groupBox2);
			this.containerProductos.Controls.Add(this.groupBox1);
			this.containerProductos.Location = new System.Drawing.Point(28, -221);
			this.containerProductos.Name = "containerProductos";
			this.containerProductos.Size = new System.Drawing.Size(846, 453);
			this.containerProductos.TabIndex = 3;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.gridManagerView1);
			this.groupBox2.Controls.Add(this.gridProductos);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 120);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(846, 333);
			this.groupBox2.TabIndex = 157;
			this.groupBox2.TabStop = false;
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
			this.gridManagerView1.Dock = System.Windows.Forms.DockStyle.Top;
			this.gridManagerView1.Location = new System.Drawing.Point(3, 16);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(840, 24);
			this.gridManagerView1.TabIndex = 7;
			this.gridManagerView1.Visible = false;
			// 
			// gridProductos
			// 
			this.gridProductos.AllowCardSizing = false;
			this.gridProductos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridProductos.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridProductos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridProductos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridProductos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.gridProductos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridProductos.Location = new System.Drawing.Point(3, 16);
			this.gridProductos.Name = "gridProductos";
			this.gridProductos.Size = new System.Drawing.Size(840, 314);
			this.gridProductos.TabIndex = 8;
			this.gridProductos.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.uccFechaFactura);
			this.groupBox1.Controls.Add(this.ultraLabel2);
			this.groupBox1.Controls.Add(this.umeNumeroFactura);
			this.groupBox1.Controls.Add(this.ultraLabel5);
			this.groupBox1.Controls.Add(this.uneValorCotizacionFactura);
			this.groupBox1.Controls.Add(this.ultraLabel31);
			this.groupBox1.Controls.Add(this.ultraLabel32);
			this.groupBox1.Controls.Add(this.ultraLabel33);
			this.groupBox1.Controls.Add(this.mzCEFuenteDeCambioFactura);
			this.groupBox1.Controls.Add(this.mzCEMonedaFactura);
			this.groupBox1.Controls.Add(this.ultraLabel4);
			this.groupBox1.Controls.Add(this.mzCmbProveedor);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(846, 120);
			this.groupBox1.TabIndex = 156;
			this.groupBox1.TabStop = false;
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(17, 93);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(184, 16);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.Text = "La factura ha sido cargada";
			// 
			// uccFechaFactura
			// 
			dateButton1.Caption = "Today";
			this.uccFechaFactura.DateButtons.Add(dateButton1);
			this.uccFechaFactura.Location = new System.Drawing.Point(88, 64);
			this.uccFechaFactura.Name = "uccFechaFactura";
			this.uccFechaFactura.NonAutoSizeHeight = 23;
			this.uccFechaFactura.Size = new System.Drawing.Size(112, 21);
			this.uccFechaFactura.TabIndex = 2;
			this.uccFechaFactura.Value = new System.DateTime(2005, 1, 28, 0, 0, 0, 0);
			// 
			// ultraLabel2
			// 
			this.ultraLabel2.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel2.Location = new System.Drawing.Point(16, 64);
			this.ultraLabel2.Name = "ultraLabel2";
			this.ultraLabel2.Size = new System.Drawing.Size(62, 16);
			this.ultraLabel2.TabIndex = 168;
			this.ultraLabel2.Text = "Fecha";
			// 
			// umeNumeroFactura
			// 
			this.umeNumeroFactura.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
			this.umeNumeroFactura.InputMask = "?-####-########";
			this.umeNumeroFactura.Location = new System.Drawing.Point(88, 40);
			this.umeNumeroFactura.Name = "umeNumeroFactura";
			this.umeNumeroFactura.TabIndex = 1;
			this.umeNumeroFactura.Text = "A--";
			// 
			// ultraLabel5
			// 
			this.ultraLabel5.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel5.Location = new System.Drawing.Point(16, 41);
			this.ultraLabel5.Name = "ultraLabel5";
			this.ultraLabel5.Size = new System.Drawing.Size(62, 16);
			this.ultraLabel5.TabIndex = 167;
			this.ultraLabel5.Text = "Número";
			// 
			// uneValorCotizacionFactura
			// 
			this.uneValorCotizacionFactura.Location = new System.Drawing.Point(344, 88);
			this.uneValorCotizacionFactura.Name = "uneValorCotizacionFactura";
			this.uneValorCotizacionFactura.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneValorCotizacionFactura.PromptChar = ' ';
			this.uneValorCotizacionFactura.Size = new System.Drawing.Size(100, 21);
			this.uneValorCotizacionFactura.TabIndex = 6;
			this.uneValorCotizacionFactura.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// ultraLabel31
			// 
			this.ultraLabel31.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel31.Location = new System.Drawing.Point(216, 90);
			this.ultraLabel31.Name = "ultraLabel31";
			this.ultraLabel31.Size = new System.Drawing.Size(104, 16);
			this.ultraLabel31.TabIndex = 162;
			this.ultraLabel31.Text = "Valor Conversion";
			// 
			// ultraLabel32
			// 
			this.ultraLabel32.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel32.Location = new System.Drawing.Point(216, 64);
			this.ultraLabel32.Name = "ultraLabel32";
			this.ultraLabel32.Size = new System.Drawing.Size(120, 16);
			this.ultraLabel32.TabIndex = 161;
			this.ultraLabel32.Text = "Fuente de Cambio";
			// 
			// ultraLabel33
			// 
			this.ultraLabel33.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel33.Location = new System.Drawing.Point(216, 41);
			this.ultraLabel33.Name = "ultraLabel33";
			this.ultraLabel33.Size = new System.Drawing.Size(72, 16);
			this.ultraLabel33.TabIndex = 160;
			this.ultraLabel33.Text = "Moneda";
			// 
			// mzCEFuenteDeCambioFactura
			// 
			this.mzCEFuenteDeCambioFactura.AutoComplete = true;
			this.mzCEFuenteDeCambioFactura.DataSource = null;
			this.mzCEFuenteDeCambioFactura.DisplayMember = "";
			this.mzCEFuenteDeCambioFactura.DisplayMemberCaption = "";
			this.mzCEFuenteDeCambioFactura.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEFuenteDeCambioFactura.Location = new System.Drawing.Point(344, 64);
			this.mzCEFuenteDeCambioFactura.MaxItemsDisplay = 8;
			this.mzCEFuenteDeCambioFactura.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEFuenteDeCambioFactura.Name = "mzCEFuenteDeCambioFactura";
			this.mzCEFuenteDeCambioFactura.Size = new System.Drawing.Size(167, 21);
			this.mzCEFuenteDeCambioFactura.SorterMember = "";
			this.mzCEFuenteDeCambioFactura.TabIndex = 5;
			this.mzCEFuenteDeCambioFactura.ValueMember = "";
			this.mzCEFuenteDeCambioFactura.ValueMemberCaption = "";
			// 
			// mzCEMonedaFactura
			// 
			this.mzCEMonedaFactura.AutoComplete = true;
			this.mzCEMonedaFactura.DataSource = null;
			this.mzCEMonedaFactura.DisplayMember = "";
			this.mzCEMonedaFactura.DisplayMemberCaption = "";
			this.mzCEMonedaFactura.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEMonedaFactura.Location = new System.Drawing.Point(344, 40);
			this.mzCEMonedaFactura.MaxItemsDisplay = 8;
			this.mzCEMonedaFactura.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEMonedaFactura.Name = "mzCEMonedaFactura";
			this.mzCEMonedaFactura.Size = new System.Drawing.Size(167, 21);
			this.mzCEMonedaFactura.SorterMember = "";
			this.mzCEMonedaFactura.TabIndex = 4;
			this.mzCEMonedaFactura.ValueMember = "";
			this.mzCEMonedaFactura.ValueMemberCaption = "";
			// 
			// ultraLabel4
			// 
			this.ultraLabel4.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel4.Location = new System.Drawing.Point(16, 16);
			this.ultraLabel4.Name = "ultraLabel4";
			this.ultraLabel4.Size = new System.Drawing.Size(62, 16);
			this.ultraLabel4.TabIndex = 159;
			this.ultraLabel4.Text = "Proveedor";
			// 
			// mzCmbProveedor
			// 
			this.mzCmbProveedor.BackColor = System.Drawing.SystemColors.Control;
			this.mzCmbProveedor.DataValue = "";
			this.mzCmbProveedor.EditObject = null;
			this.mzCmbProveedor.FastSearch = false;
			this.mzCmbProveedor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbProveedor.HierarchicalSearch = false;
			this.mzCmbProveedor.Location = new System.Drawing.Point(88, 16);
			this.mzCmbProveedor.Name = "mzCmbProveedor";
			this.mzCmbProveedor.ReadOnly = false;
			this.mzCmbProveedor.SearchObject = null;
			this.mzCmbProveedor.SearchObjectListener = null;
			this.mzCmbProveedor.Size = new System.Drawing.Size(560, 22);
			this.mzCmbProveedor.TabIndex = 0;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uTEObservaciones);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 291);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(846, 150);
			this.ultraExplorerBarContainerControl1.TabIndex = 4;
			// 
			// uTEObservaciones
			// 
			this.uTEObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
			this.uTEObservaciones.Location = new System.Drawing.Point(0, 0);
			this.uTEObservaciones.Multiline = true;
			this.uTEObservaciones.Name = "uTEObservaciones";
			this.uTEObservaciones.Size = new System.Drawing.Size(846, 150);
			this.uTEObservaciones.TabIndex = 2;
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
																							  this.tbbSeparator2,
																							  this.tbbCancelar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(912, 28);
			this.toolBarStandar.TabIndex = 24;
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
			// ultraExplorerBar
			// 
			this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar.Controls.Add(this.containerProductos);
			this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup1.Enabled = false;
			ultraExplorerBarGroup1.Key = "Tarea";
			ultraExplorerBarGroup1.Settings.ContainerHeight = 34;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.containerProductos;
			ultraExplorerBarGroup2.Key = "Productos";
			ultraExplorerBarGroup2.Settings.ContainerHeight = 453;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Producto";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup3.Key = "Observaciones";
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			this.ultraExplorerBar.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																													   ultraExplorerBarGroup1,
																													   ultraExplorerBarGroup2,
																													   ultraExplorerBarGroup3});
			this.ultraExplorerBar.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar.Name = "ultraExplorerBar"; this.ultraExplorerBar.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar.Size = new System.Drawing.Size(912, 466);
			this.ultraExplorerBar.TabIndex = 25;
			this.ultraExplorerBar.TabStop = false;
			// 
			// FrmConfirmarPreciosProductosCompras
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(912, 494);
			this.Controls.Add(this.ultraExplorerBar);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmConfirmarPreciosProductosCompras";
			this.Text = "FrmConfirmarPreciosProductosCompras";
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			this.containerProductos.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uccFechaFactura)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneValorCotizacionFactura)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEFuenteDeCambioFactura)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMonedaFactura)).EndInit();
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uTEObservaciones)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar)).EndInit();
			this.ultraExplorerBar.ResumeLayout(false);
			this.ResumeLayout(false);

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
			FillControls();
		}



		
		private void ConfigureInterface()
		{
			labelTarea.Text = _uiController.LeyendaFormulario;
			this.Text = _uiController.LeyendaFormulario;
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			
			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), this.Name, gridProductos, this.Text);

			Janus.Windows.GridEX.GridEXColumnCollection col = gridProductos.RootTable.Columns;
			col["IdMotivoDiferencia"].HasValueList =true;
			col["IdMotivoDiferencia"].EditType= Janus.Windows.GridEX.EditType.Combo;
			col["IdMotivoDiferencia"].ValueList.PopulateValueList(mz.erp.businessrules.tsy_MotivosDiferenciasCompras.GetList().tsy_MotivosDiferenciasCompras,"IdMotivoDiferencia","Descripcion");
			
			col["Estado"].HasValueList =true;
			col["Estado"].EditType= Janus.Windows.GridEX.EditType.Combo;
			col["Estado"].ValueList.PopulateValueList( _uiController.Estados,"IdEstado","Descripcion");
			if(!_uiController.AllowEditEstados)
				col["Estado"].EditType = Janus.Windows.GridEX.EditType.NoEdit;

			mzCEMonedaFactura.ReadOnly = true;
			mzCEFuenteDeCambioFactura.ReadOnly = true;
			uneValorCotizacionFactura.ReadOnly = true;
			umeNumeroFactura.ReadOnly = true;
			uccFechaFactura.ReadOnly = true;
			mzCmbProveedor.ReadOnly = true;
			checkBox1.Enabled = false;

			gridProductos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			gridProductos.UpdateOnLeave = true;
			KeyPreview = true;
		}



		private void InitializeData()
		{						
			mzCmbProveedor.SearchObject = _uiController.ProveedoresSearchObject;
			
			mzCEMonedaFactura.FillFromDataSource( businessrules.tfi_Monedas.GetList().tfi_Monedas, "idMoneda", "Descripcion", 8, "1", "2", "Descripcion");
			
			mzCEFuenteDeCambioFactura.FillFromDataSource( businessrules.tfi_FuentesDeCambio.GetList().tfi_FuentesDeCambio, "idFuenteDeCambio", "Descripcion", 8, "1", "2", "Descripcion");
			
			
			mzCmbProveedor.SearchObject = _uiController.ProveedoresSearchObject;
			
		}

		private void FillControls()
		{
			mzCmbProveedor.DataValue = _uiController.IdProveedor;
			mzCEFuenteDeCambioFactura.Value = _uiController.IdFuenteDeCambioFactura;
			mzCEMonedaFactura.Value = _uiController.IdMonedaFactura;
			uneValorCotizacionFactura.Value = _uiController.ValorCotizacionFactura;
			uccFechaFactura.Value = _uiController.FechaFactura;
			umeNumeroFactura.Value = _uiController.NumeroFactura;
			checkBox1.Checked = _uiController.ExisteFactura;
		}
			

		private void InitEventHandlers()
		{			
			toolBarStandar.ButtonClick+=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			_uiController.EstadoItemsChanged +=new EventHandler(_uiController_EstadoItemsChanged);
			gridProductos.Error +=new Janus.Windows.GridEX.ErrorEventHandler(gridProductos_Error);
			KeyDownManager KeyDown = new KeyDownManager(this);
		}	 

		
		private void InitDataBindings()
		{	
			gridProductos.SetDataBinding(null, null);
			gridProductos.SetDataBinding(_uiController.Items, null);
		}


		

		
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
					CloseForm();
					break;
			}						
		}

		private void SaveChanges()
		{			
			mz.erp.ui.utility.Util.MoveFocus(this.ultraExplorerBarContainerControl1);
			gridProductos.UpdateData();
			_uiController.Execute();
		}
		

		#endregion

		private void _uiController_EstadoItemsChanged(object sender, EventArgs e)
		{
			/*
			gridProductos.SetDataBinding(null, null);
			gridProductos.SetDataBinding(_uiController.Items, null);
			*/
			//gridProductos.Refetch();
		}

		private void gridProductos_Error(object sender, Janus.Windows.GridEX.ErrorEventArgs e)
		{
			e.DisplayErrorMessage = false;
		}
	}
}

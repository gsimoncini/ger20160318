using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.forms.classes;
using mz.erp.ui.controllers;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de mzPersonasSearchForm.
	/// </summary>
	public class mzPersonasSearchForm : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItemExportarExcel;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItemVerDetalleVentas;
		private System.Windows.Forms.MenuItem menuItemVerObservaciones;
		private System.Windows.Forms.MenuItem menuItemVerCtaCte;
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbBuscar;
		private System.Windows.Forms.ToolBarButton tbbSeparador1;
		private System.Windows.Forms.ToolBarButton tbbNuevaBusqueda;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbNuevo;
		private System.Windows.Forms.ToolBarButton tbbSeparator3;
		private System.Windows.Forms.ToolBarButton tbbEditar;
		private System.Windows.Forms.ToolBarButton tbbSeparator4;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator5;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeprardor6;
		private System.Windows.Forms.ToolBarButton tbbAceptar;
		private System.Windows.Forms.ToolBarButton tbbSeparator7;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinTabControl.UltraTabControl utcFiltros;
		private Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage ultraTabSharedControlsPage2;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl utpFiltroPrincipal;
		private System.Windows.Forms.Label label3;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private Janus.Windows.GridEX.GridEX gridEx;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label labelNombre;
		private System.Windows.Forms.TextBox txtTelefonos;
		private System.Windows.Forms.Label label2;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkActivo;
		private System.Windows.Forms.TextBox txtEmail;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarActivo;
		private System.ComponentModel.IContainer components;

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Infragistics.Win.UltraWinTabControl.UltraTab ultraTab1 = new Infragistics.Win.UltraWinTabControl.UltraTab();
			Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(mzPersonasSearchForm));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.utpFiltroPrincipal = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
			this.chkHabilitarActivo = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.chkActivo = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtTelefonos = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.labelNombre = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.utcFiltros = new Infragistics.Win.UltraWinTabControl.UltraTabControl();
			this.ultraTabSharedControlsPage2 = new Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.gridEx = new Janus.Windows.GridEX.GridEX();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItemExportarExcel = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItemVerDetalleVentas = new System.Windows.Forms.MenuItem();
			this.menuItemVerObservaciones = new System.Windows.Forms.MenuItem();
			this.menuItemVerCtaCte = new System.Windows.Forms.MenuItem();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbBuscar = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparador1 = new System.Windows.Forms.ToolBarButton();
			this.tbbNuevaBusqueda = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbNuevo = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator3 = new System.Windows.Forms.ToolBarButton();
			this.tbbEditar = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator4 = new System.Windows.Forms.ToolBarButton();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator5 = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeprardor6 = new System.Windows.Forms.ToolBarButton();
			this.tbbAceptar = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator7 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.utpFiltroPrincipal.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.utcFiltros)).BeginInit();
			this.utcFiltros.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridEx)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// utpFiltroPrincipal
			// 
			this.utpFiltroPrincipal.AutoScroll = true;
			this.utpFiltroPrincipal.Controls.Add(this.chkHabilitarActivo);
			this.utpFiltroPrincipal.Controls.Add(this.chkActivo);
			this.utpFiltroPrincipal.Controls.Add(this.txtEmail);
			this.utpFiltroPrincipal.Controls.Add(this.txtTelefonos);
			this.utpFiltroPrincipal.Controls.Add(this.txtNombre);
			this.utpFiltroPrincipal.Controls.Add(this.label3);
			this.utpFiltroPrincipal.Controls.Add(this.labelNombre);
			this.utpFiltroPrincipal.Controls.Add(this.label2);
			this.utpFiltroPrincipal.Location = new System.Drawing.Point(1, 23);
			this.utpFiltroPrincipal.Name = "utpFiltroPrincipal";
			this.utpFiltroPrincipal.Size = new System.Drawing.Size(898, 109);
			// 
			// chkHabilitarActivo
			// 
			this.chkHabilitarActivo.BackColor = System.Drawing.Color.Transparent;
			this.chkHabilitarActivo.Location = new System.Drawing.Point(88, 80);
			this.chkHabilitarActivo.Name = "chkHabilitarActivo";
			this.chkHabilitarActivo.Size = new System.Drawing.Size(128, 16);
			this.chkHabilitarActivo.TabIndex = 4;
			this.chkHabilitarActivo.Text = "Habilitar";
			this.chkHabilitarActivo.CheckedChanged += new System.EventHandler(this.chkHabilitarActivo_CheckedChanged);
			// 
			// chkActivo
			// 
			this.chkActivo.BackColor = System.Drawing.Color.Transparent;
			this.chkActivo.Enabled = false;
			this.chkActivo.Location = new System.Drawing.Point(8, 80);
			this.chkActivo.Name = "chkActivo";
			this.chkActivo.Size = new System.Drawing.Size(56, 16);
			this.chkActivo.TabIndex = 3;
			this.chkActivo.Text = "Activo";
			// 
			// txtEmail
			// 
			this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtEmail.Location = new System.Drawing.Point(88, 56);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(272, 20);
			this.txtEmail.TabIndex = 2;
			this.txtEmail.Text = "";
			// 
			// txtTelefonos
			// 
			this.txtTelefonos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtTelefonos.Location = new System.Drawing.Point(88, 32);
			this.txtTelefonos.Name = "txtTelefonos";
			this.txtTelefonos.Size = new System.Drawing.Size(272, 20);
			this.txtTelefonos.TabIndex = 1;
			this.txtTelefonos.Text = "";
			// 
			// txtNombre
			// 
			this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNombre.Location = new System.Drawing.Point(88, 8);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(272, 20);
			this.txtNombre.TabIndex = 0;
			this.txtNombre.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(8, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 20);
			this.label3.TabIndex = 47;
			this.label3.Text = "Telefonos";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// labelNombre
			// 
			this.labelNombre.BackColor = System.Drawing.Color.Transparent;
			this.labelNombre.Location = new System.Drawing.Point(8, 8);
			this.labelNombre.Name = "labelNombre";
			this.labelNombre.Size = new System.Drawing.Size(104, 20);
			this.labelNombre.TabIndex = 46;
			this.labelNombre.Text = "Nombre";
			this.labelNombre.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(8, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 54;
			this.label2.Text = "Email";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.AutoScroll = true;
			this.ultraExplorerBarContainerControl1.Controls.Add(this.utcFiltros);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 49);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(902, 135);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// utcFiltros
			// 
			this.utcFiltros.BackColor = System.Drawing.Color.Transparent;
			this.utcFiltros.Controls.Add(this.ultraTabSharedControlsPage2);
			this.utcFiltros.Controls.Add(this.utpFiltroPrincipal);
			this.utcFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
			this.utcFiltros.Location = new System.Drawing.Point(0, 0);
			this.utcFiltros.Name = "utcFiltros";
			this.utcFiltros.SharedControlsPage = this.ultraTabSharedControlsPage2;
			this.utcFiltros.Size = new System.Drawing.Size(902, 135);
			this.utcFiltros.TabIndex = 0;
			appearance1.BackColor = System.Drawing.Color.Transparent;
			ultraTab1.ActiveAppearance = appearance1;
			appearance2.BackColor = System.Drawing.Color.Transparent;
			ultraTab1.Appearance = appearance2;
			appearance3.BackColor = System.Drawing.Color.Transparent;
			ultraTab1.ClientAreaAppearance = appearance3;
			ultraTab1.Key = "FiltroPrincipal";
			ultraTab1.TabPage = this.utpFiltroPrincipal;
			ultraTab1.Text = "Filtro Principal";
			this.utcFiltros.Tabs.AddRange(new Infragistics.Win.UltraWinTabControl.UltraTab[] {
																								 ultraTab1});
			this.utcFiltros.TabStop = false;
			// 
			// ultraTabSharedControlsPage2
			// 
			this.ultraTabSharedControlsPage2.Location = new System.Drawing.Point(-10000, -10000);
			this.ultraTabSharedControlsPage2.Name = "ultraTabSharedControlsPage2";
			this.ultraTabSharedControlsPage2.Size = new System.Drawing.Size(898, 109);
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.AutoScroll = true;
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridManagerView1);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridEx);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 243);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(902, 192);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
			this.gridManagerView1.Location = new System.Drawing.Point(0, 0);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(872, 24);
			this.gridManagerView1.TabIndex = 0;
			this.gridManagerView1.Visible = false;
			// 
			// gridEx
			// 
			this.gridEx.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridEx.AlternatingColors = true;
			this.gridEx.ContextMenu = this.contextMenu1;
			this.gridEx.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEx.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEx.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gridEx.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEx.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridEx.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gridEx.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gridEx.GroupByBoxVisible = false;
			this.gridEx.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridEx.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridEx.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gridEx.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
			this.gridEx.Location = new System.Drawing.Point(0, 32);
			this.gridEx.Name = "gridEx";
			this.gridEx.RecordNavigatorText = "Registro:|de";
			this.gridEx.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridEx.ShowEmptyFields = false;
			this.gridEx.Size = new System.Drawing.Size(902, 160);
			this.gridEx.TabIndex = 1;
			this.gridEx.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemExportarExcel,
																						 this.menuItem1});
			// 
			// menuItemExportarExcel
			// 
			this.menuItemExportarExcel.Index = 0;
			this.menuItemExportarExcel.Text = "Exportar a Excel";
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 1;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItemVerDetalleVentas,
																					  this.menuItemVerObservaciones,
																					  this.menuItemVerCtaCte});
			this.menuItem1.Text = "Ver";
			// 
			// menuItemVerDetalleVentas
			// 
			this.menuItemVerDetalleVentas.Index = 0;
			this.menuItemVerDetalleVentas.Text = "Detalle Ventas";
			// 
			// menuItemVerObservaciones
			// 
			this.menuItemVerObservaciones.Index = 1;
			this.menuItemVerObservaciones.Text = "Observaciones";
			// 
			// menuItemVerCtaCte
			// 
			this.menuItemVerCtaCte.Index = 2;
			this.menuItemVerCtaCte.Text = "Cuenta Corriente";
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
																							  this.tbbBuscar,
																							  this.tbbSeparador1,
																							  this.tbbNuevaBusqueda,
																							  this.tbbSeparator2,
																							  this.tbbNuevo,
																							  this.tbbSeparator3,
																							  this.tbbEditar,
																							  this.tbbSeparator4,
																							  this.tbbAnterior,
																							  this.tbbSeparator5,
																							  this.tbbSiguiente,
																							  this.tbbSeprardor6,
																							  this.tbbAceptar,
																							  this.tbbSeparator7,
																							  this.tbbCancelar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(960, 28);
			this.toolBarStandar.TabIndex = 50;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// tbbBuscar
			// 
			this.tbbBuscar.ImageIndex = 10;
			this.tbbBuscar.Text = "[F2] Buscar ahora";
			// 
			// tbbSeparador1
			// 
			this.tbbSeparador1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbNuevaBusqueda
			// 
			this.tbbNuevaBusqueda.ImageIndex = 5;
			this.tbbNuevaBusqueda.Text = "Nueva búsqueda";
			// 
			// tbbSeparator2
			// 
			this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbNuevo
			// 
			this.tbbNuevo.ImageIndex = 11;
			this.tbbNuevo.Text = "Nuevo";
			// 
			// tbbSeparator3
			// 
			this.tbbSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbEditar
			// 
			this.tbbEditar.ImageIndex = 6;
			this.tbbEditar.Text = "Editar";
			// 
			// tbbSeparator4
			// 
			this.tbbSeparator4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbAnterior
			// 
			this.tbbAnterior.ImageIndex = 9;
			this.tbbAnterior.Text = "&Anterior";
			// 
			// tbbSeparator5
			// 
			this.tbbSeparator5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbSiguiente
			// 
			this.tbbSiguiente.ImageIndex = 8;
			this.tbbSiguiente.Text = "Siguiente";
			// 
			// tbbSeprardor6
			// 
			this.tbbSeprardor6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbAceptar
			// 
			this.tbbAceptar.ImageIndex = 12;
			this.tbbAceptar.Text = "Aceptar";
			// 
			// tbbSeparator7
			// 
			this.tbbSeparator7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbCancelar
			// 
			this.tbbCancelar.ImageIndex = 7;
			this.tbbCancelar.Text = "Cancelar";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 135;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Filtros";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 192;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Detalle";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(-8, 25);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Scrollbars = Infragistics.Win.UltraWinExplorerBar.ScrollbarStyle.Always;
			this.ultraExplorerBar1.Size = new System.Drawing.Size(968, 539);
			this.ultraExplorerBar1.TabIndex = 82;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// mzPersonasSearchForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(960, 550);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "mzPersonasSearchForm";
			this.Text = "mzPersonasSearchForm";
			this.utpFiltroPrincipal.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.utcFiltros)).EndInit();
			this.utcFiltros.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridEx)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Constructores y Destructores

		public mzPersonasSearchForm()
		{
			InitializeComponent();
			_uiController = new mzPersonasSearchFormController();
		}

		public mzPersonasSearchForm(mzPersonasSearchFormController uiController)
		{
			InitializeComponent();
			_uiController = uiController;
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

		#region Variables privadas
		private mzPersonasSearchFormController _uiController;
		#endregion

		#region Propiedades
		#endregion

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
			_uiController.Previous();
		}

		public void KeyDownNext()
		{
			_uiController.Execute();
		}

		public void Execute()
		{			
		}

		public void Previous()
		{
			
		}

		#endregion

		#region Métodos privados

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

		private void ConfigureInterface()
		{
			this.Text = _uiController.LeyendaFormulario;
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator5.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;
			gridManagerView1.Configure("ProcesoConsultarPersonas", "ConsultarPersonas", gridEx, this.Text);
			this.KeyPreview = true;	

			gridEx.RecordNavigator = true;
		}

		private void InitializeData()
		{
		}

		private void InitEventHandlers()
		{
			this.toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			this.gridEx.SelectionChanged += new System.EventHandler(this.gridEx_SelectionChanged);
			this.gridEx.DoubleClick+=new EventHandler(gridEx_DoubleClick);			
			this.KeyDown +=new KeyEventHandler(mzPersonasSearchForm_KeyDown);
		}


		private void InitDataBindings()
		{
		}

		private void FillControls() 
		{
		}

		private void InitNW()
		{
			Build_UINW();
		}

		private void Build_UINW()
		{
			ConfigureInterfaceNW();	
			InitEventHandlers();
		}

		private void ConfigureInterfaceNW()
		{
			this.Text = _uiController.LeyendaFormulario;
			tbbAnterior.Enabled = false;
			tbbSeparator5.Enabled = false;
			tbbAnterior.Text = "Anterior";
			tbbSiguiente.Text = "Siguiente";
			gridManagerView1.Configure("ProcesoConsultarPersonas", "ConsultarPersonas", gridEx, this.Text);
			this.KeyPreview = true;	

			gridEx.RecordNavigator = true;
		}


		#endregion

		#region Métodos Públicos
		public void ShowFormNW()
		{
			InitNW();
			MdiParent = mz.erp.ui.utility.Environment.MainForm;
			Show();			
		}

    	#endregion

		#region Eventos y Delegados
		public delegate void RowChanged( object sender, EventArgs args );
		public event RowChanged OnRowChanged;
		#endregion

		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0: /*Buscar Ahora*/
					this.SearchNow();
					break;
				case 2: /*Nueva Búsqueda*/
					this.ResetParameters();
					break;
				case 4: /*Nuevo*/
					this.Nuevo();
					break;
				case 6: /*Editar*/
					this.Editar();
					break;
				case 8:/*Anterior*/
					_uiController.Previous();
					break;
				case 10:/*Siguiente*/
					_uiController.Execute();
					break;
				case 12: /*Aceptar*/
					this.Aceptar();					
					break;
				case 14: /*Cancelar*/
					this.Cancelar();
					break;
				
			}		
		}

		private void SearchNow()
		{						
			this.Cursor = Cursors.WaitCursor;
			_uiController.Nombre = txtNombre.Text;
			_uiController.Telefonos = txtTelefonos.Text;
			_uiController.Email = txtEmail.Text;
			_uiController.ByActivo = chkHabilitarActivo.Checked;
			_uiController.Activo = chkActivo.Checked;
			System.Data.DataView view = _uiController.SearchNow();		
			gridEx.DataSource =	view;
			if (gridManagerView1.AllowExportExcel || gridManagerView1.AllowSortByAgregateColumn)
				gridManagerView1.SetTable(view.Table);
			this.Cursor = Cursors.Default;
		}

		public void ResetParameters()
		{
			txtEmail.Text = string.Empty;
			txtNombre.Text = string.Empty;
			txtTelefonos.Text = string.Empty;
			chkActivo.Checked = false;
			chkActivo.Enabled = false;
			chkHabilitarActivo.Checked = false;
		}


		private void Nuevo()
		{
			this.Cursor = Cursors.WaitCursor;
			FrmAbmPersonas form = new FrmAbmPersonas();
			form.OnRowChanged += new mz.erp.ui.forms.FrmAMB.RowChanged(EventoRefrescar);
			form.ShowForm(null, "Persona");
			this.Cursor = Cursors.Default;

		}


		private void Editar()
		{
			if(this.gridEx.SelectedItems.Count > 0)
			{
				this.Cursor = Cursors.WaitCursor;
				FrmAbmPersonas form = new FrmAbmPersonas();
				form.OnRowChanged += new mz.erp.ui.forms.FrmAMB.RowChanged(EventoRefrescar);
				form.ShowForm(_uiController.IdPersonaSeleccionada, "Persona");
				this.Cursor = Cursors.Default;
			}
		}

		private void Aceptar()
		{
			_uiController.Execute();
			if ( OnRowChanged != null )
			{
				if(this.gridEx.SelectedItems.Count > 0)
				{
					System.Data.DataRowView dataRowSelected = (System.Data.DataRowView)gridEx.SelectedItems[0].GetRow().DataRow;
					OnRowChanged( dataRowSelected, null );
				}else
					OnRowChanged( null, null );			
				this.Close();
			}

		}

		private void EventoRefrescar( object sender, EventArgs args )
		{			
			this.SearchNow();
		}

		private void Cancelar()
		{					
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;	
			this.Close();
		}


	
		private void gridEx_SelectionChanged(object sender, System.EventArgs e)
		{
			if (gridEx.SelectedItems.Count > 0)
			{
				System.Data.DataRowView dataRowSelected = (System.Data.DataRowView)gridEx.SelectedItems[0].GetRow().DataRow;
				_uiController.IdPersonaSeleccionada = Convert.ToString(dataRowSelected["IdPersona"]);
			}
		}

		private void chkHabilitarActivo_CheckedChanged(object sender, System.EventArgs e)
		{
			chkActivo.Enabled = chkHabilitarActivo.Checked;
		}

		private void mzPersonasSearchForm_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyData )
			{
				case System.Windows.Forms.Keys.F2 :
					this.SearchNow();					
					break;
				case System.Windows.Forms.Keys.PageDown :
					gridEx.Focus();
					break;
				case System.Windows.Forms.Keys.Enter:				
					Select();
					break;				
				case System.Windows.Forms.Keys.Escape :
					this.Close();
					break;
				default:
					break;
			}
		}


		private void gridEx_DoubleClick(object sender, EventArgs e)
		{
			Select();
		}
		private void Select()
		{
			bool _cierreAutomatico = true;
			if (_cierreAutomatico) 
			{		
				_uiController.Execute();
				if ( OnRowChanged != null )
				{
					if(this.gridEx.SelectedItems.Count > 0)
					{
						System.Data.DataRowView dataRowSelected = (System.Data.DataRowView)gridEx.SelectedItems[0].GetRow().DataRow;
						OnRowChanged( dataRowSelected, null );
					}
					else
						OnRowChanged( null, null );								
				
					this.DialogResult = System.Windows.Forms.DialogResult.OK;
					this.Close();
				}
			}
		}

	}
}

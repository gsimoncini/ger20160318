using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using mz.erp.commontypes;
using mz.erp.ui.forms.classes;
using mz.erp.ui.utility;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmConsultarVariables.
	/// </summary>
	public class FrmConsultarVariables : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItemSeleccionarTodos;
		private System.Windows.Forms.MenuItem menuItemDesSeleccionar;
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
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelCodigoSec;
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Janus.Windows.GridEX.GridEX gridEx;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarProceso;
		private System.Windows.Forms.TextBox txtIdVariable;
		private mz.erp.ui.controls.mzComboEditor mzComboProceso;
		private mz.erp.ui.controls.mzComboEditor mzComboTarea;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarTarea;
		private System.Windows.Forms.ComboBox cboContextoDeBusqueda;
		private Infragistics.Win.Misc.UltraButton btnEliminar;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmConsultarVariables));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.utpFiltroPrincipal = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
			this.cboContextoDeBusqueda = new System.Windows.Forms.ComboBox();
			this.chkHabilitarTarea = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.mzComboTarea = new mz.erp.ui.controls.mzComboEditor();
			this.chkHabilitarProceso = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.mzComboProceso = new mz.erp.ui.controls.mzComboEditor();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelCodigoSec = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtIdVariable = new System.Windows.Forms.TextBox();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.utcFiltros = new Infragistics.Win.UltraWinTabControl.UltraTabControl();
			this.ultraTabSharedControlsPage2 = new Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.btnEliminar = new Infragistics.Win.Misc.UltraButton();
			this.gridEx = new Janus.Windows.GridEX.GridEX();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItemSeleccionarTodos = new System.Windows.Forms.MenuItem();
			this.menuItemDesSeleccionar = new System.Windows.Forms.MenuItem();
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
			((System.ComponentModel.ISupportInitialize)(this.mzComboTarea)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboProceso)).BeginInit();
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
			this.utpFiltroPrincipal.Controls.Add(this.cboContextoDeBusqueda);
			this.utpFiltroPrincipal.Controls.Add(this.chkHabilitarTarea);
			this.utpFiltroPrincipal.Controls.Add(this.mzComboTarea);
			this.utpFiltroPrincipal.Controls.Add(this.chkHabilitarProceso);
			this.utpFiltroPrincipal.Controls.Add(this.mzComboProceso);
			this.utpFiltroPrincipal.Controls.Add(this.label5);
			this.utpFiltroPrincipal.Controls.Add(this.label3);
			this.utpFiltroPrincipal.Controls.Add(this.labelCodigoSec);
			this.utpFiltroPrincipal.Controls.Add(this.label1);
			this.utpFiltroPrincipal.Controls.Add(this.txtIdVariable);
			this.utpFiltroPrincipal.Location = new System.Drawing.Point(1, 23);
			this.utpFiltroPrincipal.Name = "utpFiltroPrincipal";
			this.utpFiltroPrincipal.Size = new System.Drawing.Size(734, 116);
			// 
			// cboContextoDeBusqueda
			// 
			this.cboContextoDeBusqueda.Location = new System.Drawing.Point(112, 78);
			this.cboContextoDeBusqueda.Name = "cboContextoDeBusqueda";
			this.cboContextoDeBusqueda.Size = new System.Drawing.Size(152, 21);
			this.cboContextoDeBusqueda.TabIndex = 3;
			this.cboContextoDeBusqueda.Tag = "TiposDeComprobantes";
			// 
			// chkHabilitarTarea
			// 
			this.chkHabilitarTarea.BackColor = System.Drawing.Color.Transparent;
			this.chkHabilitarTarea.Location = new System.Drawing.Point(432, 56);
			this.chkHabilitarTarea.Name = "chkHabilitarTarea";
			this.chkHabilitarTarea.TabIndex = 5;
			this.chkHabilitarTarea.Text = "Habilitar";
			// 
			// mzComboTarea
			// 
			this.mzComboTarea.AutoComplete = true;
			this.mzComboTarea.DataSource = null;
			this.mzComboTarea.DisplayMember = "";
			this.mzComboTarea.DisplayMemberCaption = "";
			this.mzComboTarea.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzComboTarea.Location = new System.Drawing.Point(112, 55);
			this.mzComboTarea.MaxItemsDisplay = 7;
			this.mzComboTarea.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzComboTarea.Name = "mzComboTarea";
			this.mzComboTarea.Size = new System.Drawing.Size(312, 21);
			this.mzComboTarea.SorterMember = "";
			this.mzComboTarea.TabIndex = 2;
			this.mzComboTarea.ValueMember = "";
			this.mzComboTarea.ValueMemberCaption = "";
			// 
			// chkHabilitarProceso
			// 
			this.chkHabilitarProceso.BackColor = System.Drawing.Color.Transparent;
			this.chkHabilitarProceso.Location = new System.Drawing.Point(432, 32);
			this.chkHabilitarProceso.Name = "chkHabilitarProceso";
			this.chkHabilitarProceso.TabIndex = 4;
			this.chkHabilitarProceso.Text = "Habilitar";
			// 
			// mzComboProceso
			// 
			this.mzComboProceso.AutoComplete = true;
			this.mzComboProceso.DataSource = null;
			this.mzComboProceso.DisplayMember = "";
			this.mzComboProceso.DisplayMemberCaption = "";
			this.mzComboProceso.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzComboProceso.Location = new System.Drawing.Point(112, 32);
			this.mzComboProceso.MaxItemsDisplay = 7;
			this.mzComboProceso.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzComboProceso.Name = "mzComboProceso";
			this.mzComboProceso.Size = new System.Drawing.Size(312, 21);
			this.mzComboProceso.SorterMember = "";
			this.mzComboProceso.TabIndex = 1;
			this.mzComboProceso.ValueMember = "";
			this.mzComboProceso.ValueMemberCaption = "";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(8, 78);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 20);
			this.label5.TabIndex = 49;
			this.label5.Text = "Contexto";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(9, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 20);
			this.label3.TabIndex = 47;
			this.label3.Text = "Tarea";
			// 
			// labelCodigoSec
			// 
			this.labelCodigoSec.BackColor = System.Drawing.Color.Transparent;
			this.labelCodigoSec.Location = new System.Drawing.Point(9, 32);
			this.labelCodigoSec.Name = "labelCodigoSec";
			this.labelCodigoSec.Size = new System.Drawing.Size(104, 20);
			this.labelCodigoSec.TabIndex = 46;
			this.labelCodigoSec.Text = "Proceso";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(9, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 45;
			this.label1.Text = "Variable";
			// 
			// txtIdVariable
			// 
			this.txtIdVariable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtIdVariable.Location = new System.Drawing.Point(112, 10);
			this.txtIdVariable.Name = "txtIdVariable";
			this.txtIdVariable.Size = new System.Drawing.Size(600, 20);
			this.txtIdVariable.TabIndex = 0;
			this.txtIdVariable.Text = "";
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.AutoScroll = true;
			this.ultraExplorerBarContainerControl1.Controls.Add(this.utcFiltros);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 49);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(738, 142);
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
			this.utcFiltros.Size = new System.Drawing.Size(738, 142);
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
			this.ultraTabSharedControlsPage2.Size = new System.Drawing.Size(734, 116);
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.AutoScroll = true;
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridManagerView1);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.btnEliminar);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridEx);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 250);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(738, 350);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
			this.gridManagerView1.Location = new System.Drawing.Point(0, 32);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(672, 24);
			this.gridManagerView1.TabIndex = 1;
			this.gridManagerView1.Visible = false;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Enabled = false;
			this.btnEliminar.Location = new System.Drawing.Point(0, 0);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(80, 24);
			this.btnEliminar.TabIndex = 0;
			this.btnEliminar.Text = "&Eliminar";
			// 
			// gridEx
			// 
			this.gridEx.AllowDrop = true;
			this.gridEx.AlternatingColors = true;
			this.gridEx.AutoEdit = true;
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
			this.gridEx.Location = new System.Drawing.Point(0, 56);
			this.gridEx.Name = "gridEx";
			this.gridEx.RecordNavigatorText = "Registro:|de";
			this.gridEx.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridEx.ShowEmptyFields = false;
			this.gridEx.Size = new System.Drawing.Size(721, 320);
			this.gridEx.TabIndex = 2;
			this.gridEx.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemSeleccionarTodos,
																						 this.menuItemDesSeleccionar});
			// 
			// menuItemSeleccionarTodos
			// 
			this.menuItemSeleccionarTodos.Index = 0;
			this.menuItemSeleccionarTodos.Text = "Todos";
			// 
			// menuItemDesSeleccionar
			// 
			this.menuItemDesSeleccionar.Index = 1;
			this.menuItemDesSeleccionar.Text = "Ninguno";
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
			this.toolBarStandar.Size = new System.Drawing.Size(804, 28);
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
			this.tbbAceptar.ImageIndex = 4;
			this.tbbAceptar.Text = "Guardar";
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
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 142;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Filtros";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 350;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Detalle";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Scrollbars = Infragistics.Win.UltraWinExplorerBar.ScrollbarStyle.Always;
			this.ultraExplorerBar1.Size = new System.Drawing.Size(804, 529);
			this.ultraExplorerBar1.TabIndex = 82;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// FrmConsultarVariables
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(804, 557);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.KeyPreview = true;
			this.Name = "FrmConsultarVariables";
			this.Text = "FrmConsultarVariables";
			this.utpFiltroPrincipal.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzComboTarea)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboProceso)).EndInit();
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

		public FrmConsultarVariables(ConsultarVariablesController uiController)
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
				this.toolBarStandar.ButtonClick -=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			}
			base.Dispose( disposing );
		}
		#endregion

		#region Variables privadas
		private ConsultarVariablesController _uiController;
		private bool _cerrarFormulario= true;
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
			if(_cerrarFormulario)
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
			SearchNow();
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
            
			gridManagerView1.Configure(_uiController.ProcessName, _uiController.GetTaskName(), gridEx, this.Text);

			mzComboProceso.Enabled = _uiController.ByProceso;
			mzComboTarea.Enabled = _uiController.ByTarea;
			mzComboProceso.FillFromDataSource( _uiController.Procesos, _uiController.KeyValueProcesos, _uiController.KeyListProcesos, 100, _uiController.KeyListProcesos);
			mzComboTarea.FillFromDataSource( _uiController.Tareas, _uiController.KeyValueTareas, _uiController.KeyListTareas, 100, _uiController.KeyListTareas);
			string _contextosDeBusqueda = _uiController.ContextosDeBusqueda;
			string _contextosDeBusquedaDefault = _uiController.ContextosDeBusquedaDefault;
			ArrayList aux = new ArrayList();
			aux.AddRange(mz.erp.systemframework.Util.Parse(_contextosDeBusqueda,","));
			cboContextoDeBusqueda.Items.AddRange(aux.ToArray());					
			cboContextoDeBusqueda.SelectedItem = (string)_contextosDeBusquedaDefault;
			txtIdVariable.Focus();
			btnEliminar.Enabled = false;
			KeyPreview = true;
		}

		private void InitializeData()
		{
		}

		private void InitEventHandlers()
		{
			this.toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			chkHabilitarProceso.CheckedChanged+=new EventHandler(chkHabilitarProceso_CheckedChanged);
			chkHabilitarTarea.CheckedChanged+=new EventHandler(chkHabilitarTarea_CheckedChanged);
			mzComboProceso.SelectionChanged+=new EventHandler(mzComboProceso_SelectionChanged);
			gridEx.SelectionChanged+=new EventHandler(gridEx_SelectionChanged);
			this.KeyDown+=new KeyEventHandler(FrmConsultarVariables_KeyDown);
			//this.Activated+=new EventHandler(FrmConsultarVariables_Activated);
			btnEliminar.Click+=new EventHandler(btnEliminar_Click);
			_uiController.DataChanged+=new EventHandler(RefreshData);
			gridEx.EditingCell+=new Janus.Windows.GridEX.EditingCellEventHandler(gridEx_EditingCell);
			KeyDownManager KeyDownMan = new KeyDownManager(this);	
		}

		private void InitDataBindings()
		{
			txtIdVariable.DataBindings.Clear();
			chkHabilitarProceso.DataBindings.Clear();
			chkHabilitarTarea.DataBindings.Clear();
			mzComboProceso.DataBindings.Clear();
			mzComboTarea.DataBindings.Clear();
			cboContextoDeBusqueda.DataBindings.Clear();

			txtIdVariable.DataBindings.Add("Text",_uiController,"IdVariable");
			chkHabilitarProceso.DataBindings.Add("Checked",_uiController,"ByProceso");
			chkHabilitarTarea.DataBindings.Add("Checked",_uiController,"ByTarea");
			mzComboProceso.DataBindings.Add("Value",_uiController,"IdProceso");
			mzComboTarea.DataBindings.Add("Value",_uiController,"IdTarea");
			cboContextoDeBusqueda.DataBindings.Add("SelectedItem",_uiController,"ContextoDeBusqueda");
		}

		private void FillControls() 
		{
		}

		#endregion

		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			_cerrarFormulario = true;
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
					gridEx.UpdateData();
					_uiController.Execute();
					break;
				case 12: /*Aceptar*/
					_cerrarFormulario = false;
					gridEx.UpdateData();
					_uiController.Execute();
					break;
				case 14: /*Cancelar*/
					this.Cancelar();
					break;
				
			}		
		}

		private void SearchNow()
		{			
			this.Cursor = Cursors.WaitCursor;
    		_uiController.ProcesoSeleccionado = (string)mzComboProceso.Text;
			_uiController.TareaSeleccionada = (string)mzComboTarea.Text;
			_uiController.IdVariable = txtIdVariable.Text;
			_uiController.ContextoDeBusqueda = (string)cboContextoDeBusqueda.SelectedItem;
			_uiController.SearchNow();
			gridEx.SetDataBinding(null, null);
			gridEx.SetDataBinding(_uiController.DataTableResult, null);
			this.Cursor = Cursors.Default;
		}

		public void ResetParameters()
		{
			txtIdVariable.Text = string.Empty;
			mzComboProceso.ResetText();
			mzComboTarea.ResetText();
			_uiController.ResetTareas();
			cboContextoDeBusqueda.ResetText();
			chkHabilitarProceso.Checked = false;
			chkHabilitarTarea.Checked = false;
			gridEx.SetDataBinding(null, null);
		}


		private void Nuevo()
		{
			this.Cursor = Cursors.WaitCursor;
			if(gridEx.SelectedItems.Count > 0) //si en la grilla hay una variable seleccionada le paso los datos para q copie en el alta
			{
				_uiController.GetParametersAlta(true);
				ProcessLoader.CallProcess( "ProcesoABMVariables", _uiController.Parametros);
			}
			else
			{
				_uiController.GetParametersAlta(false);
				ProcessLoader.CallProcess( "ProcesoABMVariables", _uiController.Parametros);
			}
			this.Cursor = Cursors.Default;

		}

		private void Editar()
		{
			if(this.gridEx.SelectedItems.Count > 0)
			{
				this.Cursor = Cursors.WaitCursor;
				_uiController.GetParameters();
				ProcessLoader.CallProcess( "ProcesoABMVariables", _uiController.Parametros);
				this.Cursor = Cursors.Default;
			}
		}

		private void Cancelar()
		{					
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;	
			this.Close();
		}

		private void chkHabilitarProceso_CheckedChanged(object sender, EventArgs e)
		{
			_uiController.ByProceso = chkHabilitarProceso.Checked;
			mzComboProceso.Enabled = chkHabilitarProceso.Checked;
			if(!chkHabilitarProceso.Checked)
			{
				mzComboProceso.ResetText();
    			_uiController.IdProceso = 0;
				_uiController.ResetTareas();
				_uiController.IdTarea = 0;
				mzComboTarea.FillFromDataSource( _uiController.Tareas, _uiController.KeyValueTareas, _uiController.KeyListTareas, 100, _uiController.KeyListTareas);
			}
		}

		private void chkHabilitarTarea_CheckedChanged(object sender, EventArgs e)
		{
			_uiController.ByTarea = chkHabilitarTarea.Checked;
			mzComboTarea.Enabled = chkHabilitarTarea.Checked;
		}

		private void mzComboProceso_SelectionChanged(object sender, EventArgs e)
		{
			if(chkHabilitarProceso.Checked)
			{
				_uiController.IdProceso = (long)mzComboProceso.Value;
				mzComboTarea.FillFromDataSource( _uiController.Tareas, _uiController.KeyValueTareas, _uiController.KeyListTareas, 100, _uiController.KeyListTareas);
			}
		}

		private void gridEx_SelectionChanged(object sender, EventArgs e)
		{
			if(this.gridEx.SelectedItems.Count > 0)
			{
				_uiController.VariableSeleccionada = (System.Data.DataRowView)gridEx.SelectedItems[0].GetRow().DataRow;
				if(_uiController.VariableSeleccionada == null)
				{
					_uiController.IdVariableSeleccionada = gridEx.SelectedItems[0].GetRow().GroupCaption;
					_uiController.SeleccionGeneral = true;
				}
				else
					_uiController.SeleccionGeneral = false;
				btnEliminar.Enabled = !_uiController.SeleccionGeneral;

			}

		}

		/*private void FrmConsultarVariables_Activated(object sender, EventArgs e)
		{
			this.SearchNow();
		}*/

		private void RefreshData(object sender, EventArgs e)
		{	
			this.SearchNow();		
		}

		private void FrmConsultarVariables_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyData )
			{
				case System.Windows.Forms.Keys.F2 :
					this.SearchNow();					
					break;
				default:
					break;
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			gridEx.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;	
			if(gridEx.SelectedItems.Count == 1)
			{
				int index = gridEx.SelectedItems[0].Position;									
				if(MessageBox.Show("Está seguro que desea Eliminar la variable seleccionada","Advertencia",System.Windows.Forms.MessageBoxButtons.OKCancel,System.Windows.Forms.MessageBoxIcon.Question).Equals(DialogResult.OK))
				{
						_uiController.DeleteVariableSeleccionada();
						gridEx.Delete();
				}
			}
			gridEx.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;	

		}

		private void gridEx_EditingCell(object sender, Janus.Windows.GridEX.EditingCellEventArgs e)
		{
			if(!e.Column.Key.Equals("Tipo") && !e.Column.Key.Equals("ValorDefault"))
                e.Cancel = true;
		}
	}
}

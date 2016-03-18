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
	/// Descripción breve de FrmConfigurarVariables.
	/// </summary>
	public class FrmConfigurarVariables : System.Windows.Forms.Form, ITaskForm
	{
		private System.ComponentModel.IContainer components;

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmConfigurarVariables));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.chkDatosNuevos = new mz.erp.ui.controls.ToolTipCheckedListBox();
			this.label7 = new System.Windows.Forms.Label();
			this.chkVariables = new mz.erp.ui.controls.ToolTipCheckedListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.btnAgregar = new Infragistics.Win.Misc.UltraButton();
			this.chkEmpresas = new mz.erp.ui.controls.ToolTipCheckedListBox();
			this.chkSucursales = new mz.erp.ui.controls.ToolTipCheckedListBox();
			this.chkPuestos = new mz.erp.ui.controls.ToolTipCheckedListBox();
			this.chkPerfiles = new mz.erp.ui.controls.ToolTipCheckedListBox();
			this.chkUsuarios = new mz.erp.ui.controls.ToolTipCheckedListBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridEX1 = new Janus.Windows.GridEX.GridEX();
			this.btnEliminar = new Infragistics.Win.Misc.UltraButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.btnNingunoUsuarios = new Infragistics.Win.Misc.UltraButton();
			this.btnTodosUsuarios = new Infragistics.Win.Misc.UltraButton();
			this.btnNingunoPerfiles = new Infragistics.Win.Misc.UltraButton();
			this.btnTodosPerfiles = new Infragistics.Win.Misc.UltraButton();
			this.btnNingunoPuestos = new Infragistics.Win.Misc.UltraButton();
			this.btnTodosPuestos = new Infragistics.Win.Misc.UltraButton();
			this.btnNingunoSucursales = new Infragistics.Win.Misc.UltraButton();
			this.btnTodosSucursales = new Infragistics.Win.Misc.UltraButton();
			this.btnNingunoEmpresas = new Infragistics.Win.Misc.UltraButton();
			this.btnTodosEmpresas = new Infragistics.Win.Misc.UltraButton();
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.ultraExplorerBarContainerControl4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, -15);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(738, 25);
			this.ultraExplorerBarContainerControl5.TabIndex = 4;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(738, 23);
			this.labelTarea.TabIndex = 1;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.chkDatosNuevos);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label7);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.chkVariables);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, -207);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(738, 200);
			this.ultraExplorerBarContainerControl2.TabIndex = 5;
			// 
			// chkDatosNuevos
			// 
			this.chkDatosNuevos.Location = new System.Drawing.Point(8, 32);
			this.chkDatosNuevos.Name = "chkDatosNuevos";
			this.chkDatosNuevos.Size = new System.Drawing.Size(312, 154);
			this.chkDatosNuevos.TabIndex = 94;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(8, 8);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 16);
			this.label7.TabIndex = 93;
			this.label7.Text = "Datos Nuevos";
			// 
			// chkVariables
			// 
			this.chkVariables.Location = new System.Drawing.Point(352, 32);
			this.chkVariables.Name = "chkVariables";
			this.chkVariables.Size = new System.Drawing.Size(360, 154);
			this.chkVariables.TabIndex = 92;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(352, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 16);
			this.label2.TabIndex = 91;
			this.label2.Text = "Variables";
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.btnNingunoEmpresas);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.btnTodosEmpresas);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.btnNingunoSucursales);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.btnTodosSucursales);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.btnNingunoPuestos);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.btnTodosPuestos);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.btnNingunoPerfiles);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.btnTodosPerfiles);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.btnNingunoUsuarios);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.btnTodosUsuarios);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.btnAgregar);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkEmpresas);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkSucursales);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkPuestos);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkPerfiles);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkUsuarios);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label6);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label5);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label4);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, -167);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(738, 380);
			this.ultraExplorerBarContainerControl1.TabIndex = 6;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(552, 208);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(80, 24);
			this.btnAgregar.TabIndex = 110;
			this.btnAgregar.Text = "&Agregar";
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// chkEmpresas
			// 
			this.chkEmpresas.Location = new System.Drawing.Point(312, 200);
			this.chkEmpresas.Name = "chkEmpresas";
			this.chkEmpresas.Size = new System.Drawing.Size(176, 139);
			this.chkEmpresas.TabIndex = 101;
			// 
			// chkSucursales
			// 
			this.chkSucursales.Location = new System.Drawing.Point(72, 200);
			this.chkSucursales.Name = "chkSucursales";
			this.chkSucursales.Size = new System.Drawing.Size(176, 139);
			this.chkSucursales.TabIndex = 100;
			// 
			// chkPuestos
			// 
			this.chkPuestos.Location = new System.Drawing.Point(552, 8);
			this.chkPuestos.Name = "chkPuestos";
			this.chkPuestos.Size = new System.Drawing.Size(176, 139);
			this.chkPuestos.TabIndex = 99;
			// 
			// chkPerfiles
			// 
			this.chkPerfiles.Location = new System.Drawing.Point(312, 8);
			this.chkPerfiles.Name = "chkPerfiles";
			this.chkPerfiles.Size = new System.Drawing.Size(176, 139);
			this.chkPerfiles.TabIndex = 98;
			// 
			// chkUsuarios
			// 
			this.chkUsuarios.Location = new System.Drawing.Point(72, 8);
			this.chkUsuarios.Name = "chkUsuarios";
			this.chkUsuarios.Size = new System.Drawing.Size(176, 139);
			this.chkUsuarios.TabIndex = 97;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(8, 208);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 16);
			this.label6.TabIndex = 96;
			this.label6.Text = "Sucursales";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(256, 208);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 16);
			this.label5.TabIndex = 95;
			this.label5.Text = "Empresas";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(264, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 16);
			this.label4.TabIndex = 94;
			this.label4.Text = "Perfiles";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(496, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 16);
			this.label3.TabIndex = 93;
			this.label3.Text = "Puestos";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 92;
			this.label1.Text = "Usuarios";
			// 
			// ultraExplorerBarContainerControl4
			// 
			this.ultraExplorerBarContainerControl4.Controls.Add(this.gridEX1);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.btnEliminar);
			this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, 272);
			this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
			this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(738, 206);
			this.ultraExplorerBarContainerControl4.TabIndex = 8;
			// 
			// gridEX1
			// 
			this.gridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridEX1.AlternatingColors = true;
			this.gridEX1.AutomaticSort = false;
			this.gridEX1.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEX1.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEX1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridEX1.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gridEX1.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gridEX1.GroupByBoxVisible = false;
			this.gridEX1.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridEX1.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridEX1.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gridEX1.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
			this.gridEX1.Location = new System.Drawing.Point(16, 39);
			this.gridEX1.Name = "gridEX1";
			this.gridEX1.RecordNavigatorText = "Registro:|de";
			this.gridEX1.ShowEmptyFields = false;
			this.gridEX1.Size = new System.Drawing.Size(696, 160);
			this.gridEX1.TabIndex = 110;
			this.gridEX1.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Enabled = false;
			this.btnEliminar.Location = new System.Drawing.Point(16, 7);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(80, 24);
			this.btnEliminar.TabIndex = 109;
			this.btnEliminar.Text = "&Eliminar";
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
			this.toolBarStandar.Size = new System.Drawing.Size(804, 28);
			this.toolBarStandar.TabIndex = 49;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			// 
			// tbbAnterior
			// 
			this.tbbAnterior.ImageIndex = 1;
			this.tbbAnterior.Text = "&Anterior";
			// 
			// tbbSeparator
			// 
			this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbSiguiente
			// 
			this.tbbSiguiente.ImageIndex = 2;
			this.tbbSiguiente.Text = "&Siguiente";
			// 
			// tbbSeparator2
			// 
			this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbCancelar
			// 
			this.tbbCancelar.ImageIndex = 0;
			this.tbbCancelar.Text = "&Cancelar";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl5;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 25;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 200;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Contexto";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup3.Settings.ContainerHeight = 380;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Aplicación";
			ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl4;
			ultraExplorerBarGroup4.Settings.ContainerHeight = 206;
			ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup4.Text = "Modificaciones";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3,
																														ultraExplorerBarGroup4});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(804, 314);
			this.ultraExplorerBar1.TabIndex = 50;
			// 
			// btnNingunoUsuarios
			// 
			this.btnNingunoUsuarios.Location = new System.Drawing.Point(128, 152);
			this.btnNingunoUsuarios.Name = "btnNingunoUsuarios";
			this.btnNingunoUsuarios.Size = new System.Drawing.Size(64, 24);
			this.btnNingunoUsuarios.TabIndex = 123;
			this.btnNingunoUsuarios.Text = "Ninguno";
			// 
			// btnTodosUsuarios
			// 
			this.btnTodosUsuarios.Location = new System.Drawing.Point(72, 152);
			this.btnTodosUsuarios.Name = "btnTodosUsuarios";
			this.btnTodosUsuarios.Size = new System.Drawing.Size(56, 24);
			this.btnTodosUsuarios.TabIndex = 121;
			this.btnTodosUsuarios.Text = "Todos";
			// 
			// btnNingunoPerfiles
			// 
			this.btnNingunoPerfiles.Location = new System.Drawing.Point(365, 152);
			this.btnNingunoPerfiles.Name = "btnNingunoPerfiles";
			this.btnNingunoPerfiles.Size = new System.Drawing.Size(64, 24);
			this.btnNingunoPerfiles.TabIndex = 125;
			this.btnNingunoPerfiles.Text = "Ninguno";
			// 
			// btnTodosPerfiles
			// 
			this.btnTodosPerfiles.Location = new System.Drawing.Point(309, 152);
			this.btnTodosPerfiles.Name = "btnTodosPerfiles";
			this.btnTodosPerfiles.Size = new System.Drawing.Size(56, 24);
			this.btnTodosPerfiles.TabIndex = 124;
			this.btnTodosPerfiles.Text = "Todos";
			// 
			// btnNingunoPuestos
			// 
			this.btnNingunoPuestos.Location = new System.Drawing.Point(608, 152);
			this.btnNingunoPuestos.Name = "btnNingunoPuestos";
			this.btnNingunoPuestos.Size = new System.Drawing.Size(64, 24);
			this.btnNingunoPuestos.TabIndex = 127;
			this.btnNingunoPuestos.Text = "Ninguno";
			// 
			// btnTodosPuestos
			// 
			this.btnTodosPuestos.Location = new System.Drawing.Point(552, 152);
			this.btnTodosPuestos.Name = "btnTodosPuestos";
			this.btnTodosPuestos.Size = new System.Drawing.Size(56, 24);
			this.btnTodosPuestos.TabIndex = 126;
			this.btnTodosPuestos.Text = "Todos";
			// 
			// btnNingunoSucursales
			// 
			this.btnNingunoSucursales.Location = new System.Drawing.Point(128, 344);
			this.btnNingunoSucursales.Name = "btnNingunoSucursales";
			this.btnNingunoSucursales.Size = new System.Drawing.Size(64, 24);
			this.btnNingunoSucursales.TabIndex = 129;
			this.btnNingunoSucursales.Text = "Ninguno";
			// 
			// btnTodosSucursales
			// 
			this.btnTodosSucursales.Location = new System.Drawing.Point(72, 344);
			this.btnTodosSucursales.Name = "btnTodosSucursales";
			this.btnTodosSucursales.Size = new System.Drawing.Size(56, 24);
			this.btnTodosSucursales.TabIndex = 128;
			this.btnTodosSucursales.Text = "Todos";
			// 
			// btnNingunoEmpresas
			// 
			this.btnNingunoEmpresas.Location = new System.Drawing.Point(368, 344);
			this.btnNingunoEmpresas.Name = "btnNingunoEmpresas";
			this.btnNingunoEmpresas.Size = new System.Drawing.Size(64, 24);
			this.btnNingunoEmpresas.TabIndex = 131;
			this.btnNingunoEmpresas.Text = "Ninguno";
			// 
			// btnTodosEmpresas
			// 
			this.btnTodosEmpresas.Location = new System.Drawing.Point(312, 344);
			this.btnTodosEmpresas.Name = "btnTodosEmpresas";
			this.btnTodosEmpresas.Size = new System.Drawing.Size(56, 24);
			this.btnTodosEmpresas.TabIndex = 130;
			this.btnTodosEmpresas.Text = "Todos";
			// 
			// FrmConfigurarVariables
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(804, 342);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmConfigurarVariables";
			this.Text = "FrmConfigurarVariables";
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		protected System.Windows.Forms.ToolBarButton tbbCancelar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private System.Windows.Forms.Label labelTarea;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Label label2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private mz.erp.ui.controls.ToolTipCheckedListBox chkVariables;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private mz.erp.ui.controls.ToolTipCheckedListBox chkUsuarios;
		private mz.erp.ui.controls.ToolTipCheckedListBox chkPerfiles;
		private mz.erp.ui.controls.ToolTipCheckedListBox chkPuestos;
		private mz.erp.ui.controls.ToolTipCheckedListBox chkSucursales;
		private mz.erp.ui.controls.ToolTipCheckedListBox chkEmpresas;
		private System.Windows.Forms.Label label7;
		private mz.erp.ui.controls.ToolTipCheckedListBox chkDatosNuevos;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private Janus.Windows.GridEX.GridEX gridEX1;
		private Infragistics.Win.Misc.UltraButton btnEliminar;
		private Infragistics.Win.Misc.UltraButton btnAgregar;
		private Infragistics.Win.Misc.UltraButton btnNingunoUsuarios;
		private Infragistics.Win.Misc.UltraButton btnTodosUsuarios;
		private Infragistics.Win.Misc.UltraButton btnNingunoPerfiles;
		private Infragistics.Win.Misc.UltraButton btnTodosPerfiles;
		private Infragistics.Win.Misc.UltraButton btnNingunoPuestos;
		private Infragistics.Win.Misc.UltraButton btnTodosPuestos;
		private Infragistics.Win.Misc.UltraButton btnNingunoSucursales;
		private Infragistics.Win.Misc.UltraButton btnTodosSucursales;
		private Infragistics.Win.Misc.UltraButton btnNingunoEmpresas;
		private Infragistics.Win.Misc.UltraButton btnTodosEmpresas;

		#region Variables Privadas
		private ConfigurarVariablesController _uiController = null;
		#endregion

		#region Constructores y Destructores
		public FrmConfigurarVariables(ConfigurarVariablesController controller)
		{
			InitializeComponent();
			_uiController = controller;
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
				_uiController.ConfiguracionesNuevasHasChanged-=new EventHandler(_uiController_ConfiguracionesNuevasHasChanged);

			}
			base.Dispose( disposing );
		}
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
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			
			this.Text = _uiController.LeyendaFormulario;
			labelTarea.Text = _uiController.LeyendaFormulario;	

			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;

			this.gridEX1.LayoutData = _uiController.GetLayout();
			KeyPreview = true;
		}

		private void InitializeData()
		{
			chkDatosNuevos.Items.AddRange(_uiController.DatosNuevos.ToArray());
			chkVariables.Items.AddRange(_uiController.Variables.ToArray());
			chkUsuarios.Items.AddRange(_uiController.Usuarios.ToArray());
            chkPerfiles.Items.AddRange(_uiController.Perfiles.ToArray());
			chkPuestos.Items.AddRange(_uiController.Puestos.ToArray());
			chkEmpresas.Items.AddRange(_uiController.Empresas.ToArray());
			chkSucursales.Items.AddRange(_uiController.Sucursales.ToArray());
		}

		private void InitEventHandlers()
		{
			_uiController.ConfiguracionesNuevasHasChanged+=new EventHandler(_uiController_ConfiguracionesNuevasHasChanged);
			btnTodosUsuarios.Click +=new EventHandler(btnTodosUsuarios_Click);
			btnTodosPerfiles.Click +=new EventHandler(btnTodosPerfiles_Click);
			btnTodosPuestos.Click +=new EventHandler(btnTodosPuestos_Click);
			btnTodosSucursales.Click +=new EventHandler(btnTodosSucursales_Click);
			btnTodosEmpresas.Click +=new EventHandler(btnTodosEmpresas_Click);
			btnNingunoUsuarios.Click +=new EventHandler(btnNingunoUsuarios_Click);
			btnNingunoPerfiles.Click +=new EventHandler(btnNingunoPerfiles_Click);
			btnNingunoPuestos.Click +=new EventHandler(btnNingunoPuestos_Click);
			btnNingunoSucursales.Click +=new EventHandler(btnNingunoSucursales_Click);
			btnNingunoEmpresas.Click+=new EventHandler(btnNingunoEmpresas_Click);
			KeyDownManager KeyDown = new KeyDownManager(this);
		}	
	
		private void InitDataBindings()
		{
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

		#region Métodos Privados

		private void SaveChanges()
        {	
			this.Cursor = Cursors.WaitCursor;
			_uiController.VariablesSeleccionadas = new ArrayList();
			_uiController.UsuariosSeleccionados = new ArrayList();
			_uiController.PerfilesSeleccionados = new ArrayList();
			_uiController.PuestosSeleccionados = new ArrayList();
			_uiController.EmpresasSeleccionadas = new ArrayList();
			_uiController.SucursalesSeleccionadas = new ArrayList();
			if(chkVariables.CheckedItems.Count > 0)
			{
				ArrayList variablesSeleccionadas = new ArrayList();
				variablesSeleccionadas.AddRange(chkVariables.CheckedItems);
				_uiController.VariablesSeleccionadas = variablesSeleccionadas;
				if(chkUsuarios.CheckedItems.Count > 0)
				{
					ArrayList usuariosSeleccionados = new ArrayList();
					usuariosSeleccionados.AddRange(chkUsuarios.CheckedItems);
					_uiController.UsuariosSeleccionados = usuariosSeleccionados;
				}

				if(chkPerfiles.CheckedItems.Count > 0)
				{
					ArrayList perfilesSeleccionados = new ArrayList();
					perfilesSeleccionados.AddRange(chkPerfiles.CheckedItems);
					_uiController.PerfilesSeleccionados = perfilesSeleccionados;
				}

				if(chkPuestos.CheckedItems.Count > 0)
				{
					ArrayList puestosSeleccionados = new ArrayList();
					puestosSeleccionados.AddRange(chkPuestos.CheckedItems);
					_uiController.PuestosSeleccionados = puestosSeleccionados;
				}

				if(chkEmpresas.CheckedItems.Count > 0)
				{
					ArrayList empresasSeleccionadas = new ArrayList();
					empresasSeleccionadas.AddRange(chkEmpresas.CheckedItems);
					_uiController.EmpresasSeleccionadas = empresasSeleccionadas;
				}

				if(chkSucursales.CheckedItems.Count > 0)
				{
					ArrayList sucursalesSeleccionadas = new ArrayList();
					sucursalesSeleccionadas.AddRange(chkSucursales.CheckedItems);
					_uiController.SucursalesSeleccionadas = sucursalesSeleccionadas;
				}
			}
			_uiController.Execute();
			this.Cursor = Cursors.Default;
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
				case 4:	//Salir					
					CloseForm();
					break;
			}						
		}

		private void btnAgregar_Click(object sender, System.EventArgs e)
		{
			foreach(string variable in chkVariables.CheckedItems)
			{
				foreach(mz.erp.businessrules.IDatoNuevo dato in chkDatosNuevos.CheckedItems)
				{
					foreach(mz.erp.businessrules.UsuarioView usuario in chkUsuarios.CheckedItems)
					{
						_uiController.AddConfiguracion(variable, dato.getDescripcionDatoNuevo(), usuario.IdUsuario, 0, 0, usuario.Nombre, "Usuario");			
					}
					foreach(mz.erp.businessrules.PerfilView perfil in chkPerfiles.CheckedItems)
					{
						_uiController.AddConfiguracion(variable, dato.getDescripcionDatoNuevo(), "", perfil.IdPerfil, 0, perfil.Descripcion, "Perfil");			
					}
					foreach(mz.erp.businessrules.PuestoView puesto in chkPuestos.CheckedItems)
					{
						_uiController.AddConfiguracion(variable, dato.getDescripcionDatoNuevo(), "", puesto.IdPuesto, 0, puesto.Descripcion, "Puesto");			
					}
					foreach(mz.erp.businessrules.EmpresaView empresa in chkEmpresas.CheckedItems)
					{
						_uiController.AddConfiguracion(variable, dato.getDescripcionDatoNuevo(), "", empresa.IdEmpresa, 0, empresa.Descripcion, "Empresa");			
					}
					foreach(mz.erp.businessrules.SucursalView sucursal in chkSucursales.CheckedItems)
					{
						_uiController.AddConfiguracion(variable, dato.getDescripcionDatoNuevo(), "", sucursal.IdSucursal, sucursal.IdEmpresa, sucursal.Descripcion, "Sucursal");			
					}
				}
			}
		}

		private void _uiController_ConfiguracionesNuevasHasChanged(object sender, EventArgs e)
		{			
			this.gridEX1.SetDataBinding( null, null );
			this.gridEX1.SetDataBinding(_uiController.ConfiguracionesNuevas, null );
			btnEliminar.Enabled = true;
		}

		private void btnEliminar_Click(object sender, System.EventArgs e)
		{
			CurrencyManager cm = (CurrencyManager) this.BindingContext[_uiController.ConfiguracionesNuevas];
			int pos = cm.Position;
			if(pos >= 0)
			{
				cm.RemoveAt(pos);
				cm.Refresh();
			}		
			if(_uiController.ConfiguracionesNuevas.Count == 0)
				btnEliminar.Enabled = false;	
		}

		private void btnTodosUsuarios_Click(object sender, EventArgs e)
		{
			for(int i = 0; i<chkUsuarios.Items.Count; i++)
				chkUsuarios.SetItemChecked(i, true);			
		}

		private void btnTodosPerfiles_Click(object sender, EventArgs e)
		{
			for(int i = 0; i<chkPerfiles.Items.Count; i++)
				chkPerfiles.SetItemChecked(i, true);			
		}

		private void btnTodosPuestos_Click(object sender, EventArgs e)
		{
			for(int i = 0; i<chkPuestos.Items.Count; i++)
				chkPuestos.SetItemChecked(i, true);			
		}

		private void btnTodosSucursales_Click(object sender, EventArgs e)
		{
			for(int i = 0; i<chkSucursales.Items.Count; i++)
				chkSucursales.SetItemChecked(i, true);			
		}

		private void btnTodosEmpresas_Click(object sender, EventArgs e)
		{
			for(int i = 0; i<chkEmpresas.Items.Count; i++)
				chkEmpresas.SetItemChecked(i, true);			
		}

		private void btnNingunoUsuarios_Click(object sender, EventArgs e)
		{
			for(int i = 0; i<chkUsuarios.Items.Count; i++)
				chkUsuarios.SetItemChecked(i, false);			
		}

		private void btnNingunoPerfiles_Click(object sender, EventArgs e)
		{
			for(int i = 0; i<chkPerfiles.Items.Count; i++)
				chkPerfiles.SetItemChecked(i, false);			
		}

		private void btnNingunoPuestos_Click(object sender, EventArgs e)
		{
			for(int i = 0; i<chkPuestos.Items.Count; i++)
				chkPuestos.SetItemChecked(i, false);			
		}

		private void btnNingunoSucursales_Click(object sender, EventArgs e)
		{
			for(int i = 0; i<chkSucursales.Items.Count; i++)
				chkSucursales.SetItemChecked(i, false);			
		}

		private void btnNingunoEmpresas_Click(object sender, EventArgs e)
		{
			for(int i = 0; i<chkEmpresas.Items.Count; i++)
				chkEmpresas.SetItemChecked(i, false);			
		}
	}
}

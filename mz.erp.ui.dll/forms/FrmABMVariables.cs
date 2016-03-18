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
	/// Descripción breve de FrmABMVariables.
	/// </summary>
	public class FrmABMVariables : System.Windows.Forms.Form, ITaskForm
	{
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
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private Janus.Windows.GridEX.GridEX gridEX1;
		private Infragistics.Win.Misc.UltraButton btnEliminar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtIdVariable;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtTipo;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtValor;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkGenerica;
		private Infragistics.Win.Misc.UltraButton btnAgregar;
		private mz.erp.ui.controls.ToolTipCheckedListBox chkPuestos;
		private mz.erp.ui.controls.ToolTipCheckedListBox chkPerfiles;
		private mz.erp.ui.controls.ToolTipCheckedListBox chkUsuarios;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.Misc.UltraButton btnModificar;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private System.Windows.Forms.GroupBox groupBoxAplicacion;
		private Infragistics.Win.Misc.UltraButton btnEliminarDeBD;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtValorGenerica;
		private System.Windows.Forms.TextBox txtValorUsuarios;
		private System.Windows.Forms.TextBox txtValorPerfiles;
		private System.Windows.Forms.TextBox txtValorPuestos;
		private System.ComponentModel.IContainer components;
		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmABMVariables));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.btnModificar = new Infragistics.Win.Misc.UltraButton();
			this.groupBoxAplicacion = new System.Windows.Forms.GroupBox();
			this.btnEliminarDeBD = new Infragistics.Win.Misc.UltraButton();
			this.chkGenerica = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.chkPuestos = new mz.erp.ui.controls.ToolTipCheckedListBox();
			this.chkPerfiles = new mz.erp.ui.controls.ToolTipCheckedListBox();
			this.chkUsuarios = new mz.erp.ui.controls.ToolTipCheckedListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtTipo = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtIdVariable = new System.Windows.Forms.TextBox();
			this.btnAgregar = new Infragistics.Win.Misc.UltraButton();
			this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
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
			this.txtValorGenerica = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtValorUsuarios = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtValorPerfiles = new System.Windows.Forms.TextBox();
			this.txtValorPuestos = new System.Windows.Forms.TextBox();
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			this.groupBoxAplicacion.SuspendLayout();
			this.ultraExplorerBarContainerControl4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, -10);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(738, 26);
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
			this.ultraExplorerBarContainerControl2.Controls.Add(this.btnModificar);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.groupBoxAplicacion);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.txtValor);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label9);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.txtTipo);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label8);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.txtDescripcion);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label7);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.txtIdVariable);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.btnAgregar);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 34);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(738, 410);
			this.ultraExplorerBarContainerControl2.TabIndex = 5;
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(648, 112);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(80, 24);
			this.btnModificar.TabIndex = 119;
			this.btnModificar.Text = "&Modificar";
			// 
			// groupBoxAplicacion
			// 
			this.groupBoxAplicacion.Controls.Add(this.txtValorPuestos);
			this.groupBoxAplicacion.Controls.Add(this.txtValorPerfiles);
			this.groupBoxAplicacion.Controls.Add(this.txtValorUsuarios);
			this.groupBoxAplicacion.Controls.Add(this.label6);
			this.groupBoxAplicacion.Controls.Add(this.txtValorGenerica);
			this.groupBoxAplicacion.Controls.Add(this.label5);
			this.groupBoxAplicacion.Controls.Add(this.btnEliminarDeBD);
			this.groupBoxAplicacion.Controls.Add(this.chkGenerica);
			this.groupBoxAplicacion.Controls.Add(this.chkPuestos);
			this.groupBoxAplicacion.Controls.Add(this.chkPerfiles);
			this.groupBoxAplicacion.Controls.Add(this.chkUsuarios);
			this.groupBoxAplicacion.Controls.Add(this.label4);
			this.groupBoxAplicacion.Controls.Add(this.label3);
			this.groupBoxAplicacion.Controls.Add(this.label1);
			this.groupBoxAplicacion.Location = new System.Drawing.Point(8, 144);
			this.groupBoxAplicacion.Name = "groupBoxAplicacion";
			this.groupBoxAplicacion.Size = new System.Drawing.Size(728, 256);
			this.groupBoxAplicacion.TabIndex = 54;
			this.groupBoxAplicacion.TabStop = false;
			this.groupBoxAplicacion.Text = "Aplicación";
			// 
			// btnEliminarDeBD
			// 
			this.btnEliminarDeBD.Location = new System.Drawing.Point(632, 72);
			this.btnEliminarDeBD.Name = "btnEliminarDeBD";
			this.btnEliminarDeBD.Size = new System.Drawing.Size(80, 24);
			this.btnEliminarDeBD.TabIndex = 120;
			this.btnEliminarDeBD.Text = "&Eliminar";
			// 
			// chkGenerica
			// 
			this.chkGenerica.BackColor = System.Drawing.Color.Transparent;
			this.chkGenerica.Location = new System.Drawing.Point(16, 24);
			this.chkGenerica.Name = "chkGenerica";
			this.chkGenerica.Size = new System.Drawing.Size(72, 20);
			this.chkGenerica.TabIndex = 119;
			this.chkGenerica.Text = "Genérica";
			// 
			// chkPuestos
			// 
			this.chkPuestos.Location = new System.Drawing.Point(440, 72);
			this.chkPuestos.Name = "chkPuestos";
			this.chkPuestos.Size = new System.Drawing.Size(176, 139);
			this.chkPuestos.TabIndex = 117;
			// 
			// chkPerfiles
			// 
			this.chkPerfiles.Location = new System.Drawing.Point(248, 72);
			this.chkPerfiles.Name = "chkPerfiles";
			this.chkPerfiles.Size = new System.Drawing.Size(176, 139);
			this.chkPerfiles.TabIndex = 116;
			// 
			// chkUsuarios
			// 
			this.chkUsuarios.Location = new System.Drawing.Point(48, 72);
			this.chkUsuarios.Name = "chkUsuarios";
			this.chkUsuarios.Size = new System.Drawing.Size(176, 139);
			this.chkUsuarios.TabIndex = 115;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(248, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 16);
			this.label4.TabIndex = 114;
			this.label4.Text = "Perfiles";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(440, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 16);
			this.label3.TabIndex = 113;
			this.label3.Text = "Puestos";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(48, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 112;
			this.label1.Text = "Usuarios";
			// 
			// txtValor
			// 
			this.txtValor.Location = new System.Drawing.Point(112, 104);
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(208, 20);
			this.txtValor.TabIndex = 53;
			this.txtValor.Text = "";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(8, 112);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 16);
			this.label9.TabIndex = 52;
			this.label9.Text = "Valor";
			// 
			// txtTipo
			// 
			this.txtTipo.Location = new System.Drawing.Point(112, 80);
			this.txtTipo.Name = "txtTipo";
			this.txtTipo.Size = new System.Drawing.Size(208, 20);
			this.txtTipo.TabIndex = 51;
			this.txtTipo.Text = "";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(8, 80);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 16);
			this.label8.TabIndex = 50;
			this.label8.Text = "Tipo";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(112, 32);
			this.txtDescripcion.Multiline = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDescripcion.Size = new System.Drawing.Size(600, 48);
			this.txtDescripcion.TabIndex = 49;
			this.txtDescripcion.Text = "";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(8, 32);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 16);
			this.label7.TabIndex = 48;
			this.label7.Text = "Descripción";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 47;
			this.label2.Text = "Variable";
			// 
			// txtIdVariable
			// 
			this.txtIdVariable.Location = new System.Drawing.Point(112, 8);
			this.txtIdVariable.Name = "txtIdVariable";
			this.txtIdVariable.Size = new System.Drawing.Size(600, 20);
			this.txtIdVariable.TabIndex = 46;
			this.txtIdVariable.Text = "";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(560, 112);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(80, 24);
			this.btnAgregar.TabIndex = 118;
			this.btnAgregar.Text = "&Agregar";
			// 
			// ultraExplorerBarContainerControl4
			// 
			this.ultraExplorerBarContainerControl4.Controls.Add(this.gridManagerView1);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.gridEX1);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.btnEliminar);
			this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, 503);
			this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
			this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(738, 206);
			this.ultraExplorerBarContainerControl4.TabIndex = 8;
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
			this.gridManagerView1.Location = new System.Drawing.Point(16, 40);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(672, 24);
			this.gridManagerView1.TabIndex = 111;
			this.gridManagerView1.Visible = false;
			// 
			// gridEX1
			// 
			this.gridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridEX1.AlternatingColors = true;
			this.gridEX1.AutomaticSort = false;
			this.gridEX1.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEX1.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEX1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEX1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridEX1.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gridEX1.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gridEX1.GroupByBoxVisible = false;
			this.gridEX1.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridEX1.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridEX1.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gridEX1.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
			this.gridEX1.Location = new System.Drawing.Point(0, 46);
			this.gridEX1.Name = "gridEX1";
			this.gridEX1.RecordNavigatorText = "Registro:|de";
			this.gridEX1.ShowEmptyFields = false;
			this.gridEX1.Size = new System.Drawing.Size(738, 160);
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
			this.toolBarStandar.TabIndex = 50;
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
			this.tbbCancelar.Text = "&Cancelar";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl5;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 26;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 410;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Datos Generales";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl4;
			ultraExplorerBarGroup3.Settings.ContainerHeight = 206;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Modificaciones";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(804, 536);
			this.ultraExplorerBar1.TabIndex = 51;
			// 
			// txtValorGenerica
			// 
			this.txtValorGenerica.Location = new System.Drawing.Point(152, 24);
			this.txtValorGenerica.Name = "txtValorGenerica";
			this.txtValorGenerica.ReadOnly = true;
			this.txtValorGenerica.Size = new System.Drawing.Size(208, 20);
			this.txtValorGenerica.TabIndex = 122;
			this.txtValorGenerica.Text = "";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(112, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 16);
			this.label5.TabIndex = 121;
			this.label5.Text = "Valor";
			// 
			// txtValorUsuarios
			// 
			this.txtValorUsuarios.Location = new System.Drawing.Point(48, 216);
			this.txtValorUsuarios.Name = "txtValorUsuarios";
			this.txtValorUsuarios.ReadOnly = true;
			this.txtValorUsuarios.Size = new System.Drawing.Size(176, 20);
			this.txtValorUsuarios.TabIndex = 124;
			this.txtValorUsuarios.Text = "";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(8, 224);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 16);
			this.label6.TabIndex = 123;
			this.label6.Text = "Valor";
			// 
			// txtValorPerfiles
			// 
			this.txtValorPerfiles.Location = new System.Drawing.Point(248, 216);
			this.txtValorPerfiles.Name = "txtValorPerfiles";
			this.txtValorPerfiles.ReadOnly = true;
			this.txtValorPerfiles.Size = new System.Drawing.Size(176, 20);
			this.txtValorPerfiles.TabIndex = 125;
			this.txtValorPerfiles.Text = "";
			// 
			// txtValorPuestos
			// 
			this.txtValorPuestos.Location = new System.Drawing.Point(440, 216);
			this.txtValorPuestos.Name = "txtValorPuestos";
			this.txtValorPuestos.ReadOnly = true;
			this.txtValorPuestos.Size = new System.Drawing.Size(176, 20);
			this.txtValorPuestos.TabIndex = 126;
			this.txtValorPuestos.Text = "";
			// 
			// FrmABMVariables
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(804, 564);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmABMVariables";
			this.Text = "FrmABMVariables";
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			this.groupBoxAplicacion.ResumeLayout(false);
			this.ultraExplorerBarContainerControl4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Variables Privadas
		private ABMVariablesController _uiController = null;
		#endregion

		#region Constructores y Destructores
		public FrmABMVariables(ABMVariablesController controller)
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
			
			if(!_uiController.EsAlta())
				_uiController.LeyendaFormulario = "Modificación de Variables";
			this.Text = _uiController.LeyendaFormulario;
			labelTarea.Text = _uiController.LeyendaFormulario;	

			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;

			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), gridEX1, this.Text);

			btnModificar.Visible = !_uiController.EsAlta();
			btnAgregar.Visible = _uiController.EsAlta();
			txtDescripcion.Enabled = _uiController.EsAlta();
			txtTipo.Enabled = _uiController.EsAlta();
			txtIdVariable.Enabled = _uiController.EsAlta() || !_uiController.ModificacionSimple;

			btnEliminarDeBD.Visible =  !_uiController.EsAlta();
			KeyPreview = true;

		}

		private void InitializeData()
		{
			chkUsuarios.Items.AddRange(_uiController.Usuarios.ToArray());
			chkPerfiles.Items.AddRange(_uiController.Perfiles.ToArray());
			chkPuestos.Items.AddRange(_uiController.Puestos.ToArray());
			txtIdVariable.Text = _uiController.IdVariable;
			groupBoxAplicacion.Enabled = !_uiController.ModificacionSimple;
			if(_uiController.EsAlta())
			{
				txtIdVariable.Text = _uiController.IdVariableAlta;
				txtDescripcion.Text = _uiController.DescripcionAlta;
				txtTipo.Text = _uiController.TipoAlta;
				txtValor.Text = _uiController.ValorAlta;
			}

			foreach(businessrules.Variable var in _uiController.VariablesSeleccionadas)
			{
				switch(var.TipoVariable)
				{
					case "GENERICA":
					{
						txtDescripcion.Text = var.Descripcion;
						txtTipo.Text = var.IdTipoVariable;
						if(_uiController.ModificacionSimple)
                            txtValor.Text = var.Valor;
						txtDescripcion.Enabled = true;
						txtTipo.Enabled = true;
						chkGenerica.Checked = true;
						txtValorGenerica.Text = var.Valor;
						break;
					}
					case "USUARIO":
					{
						txtDescripcion.Text = var.Descripcion;
						txtTipo.Text = var.IdTipoVariable;
						mz.erp.businessrules.UsuarioView usuario = new mz.erp.businessrules.UsuarioView(var.IdUsuario, var.Usuario);
						int index = chkUsuarios.Items.IndexOf(usuario);
						if(index != -1)
                            chkUsuarios.SetItemChecked(index, true);
						if(_uiController.ModificacionSimple)
							txtValor.Text = var.Valor;
						break;
					}
					case "PERFIL":
					{
						txtDescripcion.Text = var.Descripcion;
						txtTipo.Text = var.IdTipoVariable;
						mz.erp.businessrules.PerfilView perfil = new mz.erp.businessrules.PerfilView(var.IdPerfil, var.Perfil);
						int index = chkPerfiles.Items.IndexOf(perfil);
						if(index != -1)
							chkPerfiles.SetItemChecked(index, true);
						if(_uiController.ModificacionSimple)
							txtValor.Text = var.Valor;
						break;
					}
					case "PUESTO":
					{
						txtDescripcion.Text = var.Descripcion;
						txtTipo.Text = var.IdTipoVariable;
						mz.erp.businessrules.PuestoView puesto = new mz.erp.businessrules.PuestoView(var.IdPuesto, var.Puesto);
						int index = chkPuestos.Items.IndexOf(puesto);
						if(index != -1)
							chkPuestos.SetItemChecked(index, true);
						if(_uiController.ModificacionSimple)
							txtValor.Text = var.Valor;
						break;
					}
				}
				
			}
		}

		private void InitEventHandlers()
		{
			this.btnAgregar.Click+=new EventHandler(btnAgregar_Click);
			_uiController.VariablesHasChanged+=new EventHandler(_uiController_VariablesHasChanged);
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			btnModificar.Click+=new EventHandler(btnModificar_Click);
			chkGenerica.CheckedChanged+=new EventHandler(chkGenerica_CheckedChanged);
			btnEliminarDeBD.Click+=new EventHandler(btnEliminarDeBD_Click);
			chkUsuarios.SelectedValueChanged+=new EventHandler(chkUsuarios_SelectedValueChanged);
			chkPerfiles.SelectedValueChanged+=new EventHandler(chkPerfiles_SelectedValueChanged);
			chkPuestos.SelectedValueChanged+=new EventHandler(chkPuestos_SelectedValueChanged);
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
			string variable = txtIdVariable.Text;
			string descripcion = txtDescripcion.Text;
			string tipo = txtTipo.Text;
			string valor = txtValor.Text;
			if(chkGenerica.Checked)
				_uiController.AddVariable(variable, descripcion, tipo, valor, string.Empty, long.MinValue, long.MinValue, string.Empty, string.Empty, string.Empty, "NEW", "GENERICA");			
			foreach(mz.erp.businessrules.UsuarioView usuario in chkUsuarios.CheckedItems)
			{
				_uiController.AddVariable(variable, descripcion, tipo, valor, usuario.IdUsuario, long.MinValue, long.MinValue, usuario.Nombre, string.Empty, string.Empty, "NEW", "USUARIO");			
			}
			foreach(mz.erp.businessrules.PerfilView perfil in chkPerfiles.CheckedItems)
			{
				_uiController.AddVariable(variable, descripcion, tipo, valor, string.Empty, perfil.IdPerfil, long.MinValue, string.Empty, perfil.Descripcion, string.Empty, "NEW", "PERFIL");			
			}
			foreach(mz.erp.businessrules.PuestoView puesto in chkPuestos.CheckedItems)
			{
				_uiController.AddVariable(variable, descripcion, tipo, valor,  string.Empty, long.MinValue, puesto.IdPuesto, string.Empty, string.Empty, puesto.Descripcion, "NEW", "PUESTO");			
			}
		}

		private void _uiController_VariablesHasChanged(object sender, EventArgs e)
		{			
			this.gridEX1.SetDataBinding( null, null );
			this.gridEX1.SetDataBinding(_uiController.Variables, null );
			if(_uiController.EsAlta())
				btnEliminar.Enabled = true;
			else if(_uiController.IdVariableOriginal.Equals(txtIdVariable.Text)) //Si es modificacion y no cambio el idvariable
                btnEliminar.Enabled = true;
			else
				btnEliminar.Enabled = false;
		}

		private void btnEliminar_Click(object sender, System.EventArgs e)
		{
			CurrencyManager cm = (CurrencyManager) this.BindingContext[_uiController.Variables];
			int pos = cm.Position;
			if(pos >= 0)
			{
				cm.RemoveAt(pos);
				cm.Refresh();
			}		
			if(_uiController.Variables.Count == 0)
				btnEliminar.Enabled = false;	
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			string variable = txtIdVariable.Text;
			string descripcion = txtDescripcion.Text;
			string tipo = txtTipo.Text;
			string valor = txtValor.Text;
			if(_uiController.IdVariableOriginal.Equals(variable)) 
			{ //No de cambi el id
				if(chkGenerica.Checked)
					_uiController.AddVariableModif(variable, descripcion, tipo, valor, string.Empty, long.MinValue, long.MinValue, string.Empty, string.Empty, string.Empty, "GENERICA");			
				foreach(mz.erp.businessrules.UsuarioView usuario in chkUsuarios.CheckedItems)
				{
					_uiController.AddVariableModif(variable, descripcion, tipo, valor, usuario.IdUsuario, long.MinValue, long.MinValue, usuario.Nombre, string.Empty, string.Empty, "USUARIO");			
				}
				foreach(mz.erp.businessrules.PerfilView perfil in chkPerfiles.CheckedItems)
				{
					_uiController.AddVariableModif(variable, descripcion, tipo, valor, string.Empty, perfil.IdPerfil, long.MinValue, string.Empty, perfil.Descripcion, string.Empty, "PERFIL");			
				}
				foreach(mz.erp.businessrules.PuestoView puesto in chkPuestos.CheckedItems)
				{
					_uiController.AddVariableModif(variable, descripcion, tipo, valor,  string.Empty, long.MinValue, puesto.IdPuesto, string.Empty, string.Empty, puesto.Descripcion, "PUESTO");			
				}
			}
			else
			{//Si se cambio el idvariable se deben modificar todas las variables relacionadas sin importar lo q este seleccionado en los checks boxz
				DialogResult result = MessageBox.Show("Ha modificado el id de la variable. Todas las variables relacionadas serán modificadas. Desea Continuar?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);					
				if(result.Equals(DialogResult.Yes))
				{

					foreach(businessrules.Variable var in _uiController.VariablesSeleccionadas)
					{
						switch(var.TipoVariable)
						{
							case "GENERICA":
							{
								_uiController.AddVariableModif(variable, descripcion, tipo, valor, string.Empty, long.MinValue, long.MinValue, string.Empty, string.Empty, string.Empty, "GENERICA");			
								break;
							}
							case "USUARIO":
							{
								_uiController.AddVariableModif(variable, descripcion, tipo, valor, var.IdUsuario, long.MinValue, long.MinValue, var.Usuario, string.Empty, string.Empty, "USUARIO");			
								break;
							}
							case "PERFIL":
							{
								_uiController.AddVariableModif(variable, descripcion, tipo, valor, string.Empty, var.IdPerfil, long.MinValue, string.Empty, var.Perfil, string.Empty, "PERFIL");			
								break;
							}
							case "PUESTO":
							{
								_uiController.AddVariableModif(variable, descripcion, tipo, valor,  string.Empty, long.MinValue, var.IdPuesto, string.Empty, string.Empty, var.Puesto, "PUESTO");			
								break;
							}
						}

				
					}
				}
				else
				{
					txtIdVariable.Text = _uiController.IdVariableOriginal;
				}
			}

		}

		private void chkGenerica_CheckedChanged(object sender, EventArgs e)
		{
			if(chkGenerica.Checked)
			{
				txtDescripcion.Enabled = true;
				txtTipo.Enabled = true;
			}
			else
			{
				txtDescripcion.Enabled = false;
				txtTipo.Enabled = false;
			}
		}

		private void btnEliminarDeBD_Click(object sender, EventArgs e)
		{
			string variable = txtIdVariable.Text;
			string descripcion = txtDescripcion.Text;
			string tipo = txtTipo.Text;
			string valor = txtValor.Text;
			foreach(mz.erp.businessrules.UsuarioView usuario in chkUsuarios.SelectedItems)
			{
				_uiController.AddVariableDeleted(variable, descripcion, tipo, valor, usuario.IdUsuario, long.MinValue, long.MinValue, usuario.Nombre, string.Empty, string.Empty, "USUARIO");			
			}
			foreach(mz.erp.businessrules.PerfilView perfil in chkPerfiles.SelectedItems)
			{
				_uiController.AddVariableDeleted(variable, descripcion, tipo, valor, string.Empty, perfil.IdPerfil, long.MinValue, string.Empty, perfil.Descripcion, string.Empty, "PERFIL");			
			}
			foreach(mz.erp.businessrules.PuestoView puesto in chkPuestos.SelectedItems)
			{
				_uiController.AddVariableDeleted(variable, descripcion, tipo, valor,  string.Empty, long.MinValue, puesto.IdPuesto, string.Empty, string.Empty, puesto.Descripcion, "PUESTO");			
			}

		}

		private void chkUsuarios_SelectedValueChanged(object sender, EventArgs e)
		{
			string idUsuario = ((mz.erp.businessrules.UsuarioView)chkUsuarios.SelectedItem).IdUsuario;
			txtValorUsuarios.Text = _uiController.GetValorVariable(_uiController.IdVariableOriginal, idUsuario, long.MinValue, long.MinValue, "USUARIO");
		}

		private void chkPerfiles_SelectedValueChanged(object sender, EventArgs e)
		{
			long idPerfil = ((mz.erp.businessrules.PerfilView)chkPerfiles.SelectedItem).IdPerfil;
			txtValorPerfiles.Text = _uiController.GetValorVariable(_uiController.IdVariableOriginal, string.Empty, idPerfil, long.MinValue, "PERFIL");
		}

		private void chkPuestos_SelectedValueChanged(object sender, EventArgs e)
		{
			long idPuesto = ((mz.erp.businessrules.PuestoView)chkPuestos.SelectedItem).IdPuesto;
			txtValorPuestos.Text = _uiController.GetValorVariable(_uiController.IdVariableOriginal, string.Empty, long.MinValue, idPuesto, "PUESTO");
		}

	}
}

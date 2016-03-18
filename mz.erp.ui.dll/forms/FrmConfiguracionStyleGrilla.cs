using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using System.Data;
using mz.erp.ui.utility;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmConfiguracionStyleGrilla.
	/// </summary>
	public class FrmConfiguracionStyleGrilla : System.Windows.Forms.Form
	{
		protected System.Windows.Forms.ToolBar toolBarStandar;
		protected System.Windows.Forms.ToolBarButton tbFirst;
		protected System.Windows.Forms.ToolBarButton tbPrev;
		protected System.Windows.Forms.ToolBarButton tbNext;
		protected System.Windows.Forms.ToolBarButton tbLast;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		protected System.Windows.Forms.ToolBarButton tbActualizar;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.ToolBarButton tbStep3;
		protected System.Windows.Forms.ToolBarButton tbDelete;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnSubir;
		private System.Windows.Forms.Button btnBajar;
		private Infragistics.Win.Misc.UltraButton btnNinguno;
		private Infragistics.Win.Misc.UltraButton btnInvertir;
		private Infragistics.Win.Misc.UltraButton btnTodos;
		private System.Windows.Forms.ImageList imglStandar;
		private mz.erp.ui.controls.ToolTipCheckedListBox chkColumnas;
		private Infragistics.Win.Misc.UltraButton btnVerTodas;
		private Infragistics.Win.Misc.UltraButton btnVerSeleccionados;
		private System.Windows.Forms.GroupBox groupComparadores;
		private System.Windows.Forms.RadioButton rbMenor;
		private System.Windows.Forms.RadioButton rbMayor;
		private System.Windows.Forms.RadioButton rbIgual;
		private System.Windows.Forms.RadioButton rbMayorIgual;
		private System.Windows.Forms.RadioButton rbMenorIgual;
		private System.Windows.Forms.RadioButton rbLike;
		private System.Windows.Forms.RadioButton rbDistinto;
		private System.Windows.Forms.RadioButton btnColumnas;
		private System.Windows.Forms.RadioButton btnConstantes;
		private System.Windows.Forms.Panel panelConstantes;
		private System.Windows.Forms.TextBox txtValor;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneValor;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor uceValor;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo uccValor;
		private mz.erp.ui.controls.ToolTipCheckedListBox chkValorColumna;
		private System.Windows.Forms.GroupBox groupValores;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private System.Windows.Forms.Label label2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.RadioButton rbTodos;
		private System.Windows.Forms.RadioButton rbPorPerfil;
		private mz.erp.ui.controls.ToolTipCheckedListBox chkPerfiles;
		private mz.erp.ui.controls.ToolTipCheckedListBox chkUsuarios;
		private System.Windows.Forms.RadioButton rbPorUsuario;
		private System.Windows.Forms.Label label4;
		private mz.erp.ui.controls.mzComboEditor mzCEConfiguraciones;
		private Infragistics.Win.Misc.UltraButton btnModificarConfig;
		private Infragistics.Win.Misc.UltraButton btnAgregarConfig;
		private Infragistics.Win.Misc.UltraButton btnBorrarConfig;
		private Infragistics.Win.Misc.UltraButton btnAplicarConfig;
		private Infragistics.Win.Misc.UltraButton btnCancelar;
		private Infragistics.Win.Misc.UltraButton btnAceptar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private System.Windows.Forms.RadioButton rbPorUsuarioAplicables;
		private System.Windows.Forms.RadioButton rbPorPerfilAplicables;
		private System.Windows.Forms.RadioButton rbTodosAplicables;
		private mz.erp.ui.controls.ToolTipCheckedListBox chkPerfilesAplicables;
		private mz.erp.ui.controls.ToolTipCheckedListBox chkUsuariosAplicables;
		private System.Windows.Forms.RadioButton rbTodosModificables;
		private mz.erp.ui.controls.ToolTipCheckedListBox chkUsuariosModificables;
		private System.Windows.Forms.RadioButton rbPorUsuarioModificables;
		private mz.erp.ui.controls.ToolTipCheckedListBox chkPerfilesModificables;
		private System.Windows.Forms.RadioButton rbPorPerfilModificables;
		protected System.Windows.Forms.ToolBarButton tbTerminar;
		private System.Windows.Forms.GroupBox panelABMCondiciones;
		private System.Windows.Forms.GroupBox panelBotonesConfirmacionConfiguracion;
		private System.Windows.Forms.GroupBox panelBotonesABMConfiguracion;
		private System.Windows.Forms.GroupBox panelABM;
		private System.Windows.Forms.GroupBox groupBox1;
		private Janus.Windows.GridEX.GridEX gridConfiguraciones;
		private System.Windows.Forms.TextBox txtNombreConfiguracion;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox panelBotonesConfirmacionCondiciones;
		private Infragistics.Win.Misc.UltraButton btnAceptarCondicion;
		private Infragistics.Win.Misc.UltraButton btnCanelarCond;
		private System.Windows.Forms.GroupBox panelBotonesABMCondiciones;
		private Infragistics.Win.Misc.UltraButton btnAgregar;
		private Infragistics.Win.Misc.UltraButton btnEliminar;
		private Infragistics.Win.Misc.UltraButton btnModificarCondicion;
		private System.ComponentModel.IContainer components;

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmConfiguracionStyleGrilla));
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panelBotonesConfirmacionConfiguracion = new System.Windows.Forms.GroupBox();
			this.btnCancelar = new Infragistics.Win.Misc.UltraButton();
			this.btnAceptar = new Infragistics.Win.Misc.UltraButton();
			this.mzCEConfiguraciones = new mz.erp.ui.controls.mzComboEditor();
			this.label4 = new System.Windows.Forms.Label();
			this.panelBotonesABMConfiguracion = new System.Windows.Forms.GroupBox();
			this.btnModificarConfig = new Infragistics.Win.Misc.UltraButton();
			this.btnAgregarConfig = new Infragistics.Win.Misc.UltraButton();
			this.btnBorrarConfig = new Infragistics.Win.Misc.UltraButton();
			this.btnAplicarConfig = new Infragistics.Win.Misc.UltraButton();
			this.panelABM = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnBajar = new System.Windows.Forms.Button();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.btnNinguno = new Infragistics.Win.Misc.UltraButton();
			this.btnInvertir = new Infragistics.Win.Misc.UltraButton();
			this.btnTodos = new Infragistics.Win.Misc.UltraButton();
			this.btnVerTodas = new Infragistics.Win.Misc.UltraButton();
			this.btnSubir = new System.Windows.Forms.Button();
			this.btnVerSeleccionados = new Infragistics.Win.Misc.UltraButton();
			this.chkColumnas = new mz.erp.ui.controls.ToolTipCheckedListBox();
			this.groupComparadores = new System.Windows.Forms.GroupBox();
			this.rbDistinto = new System.Windows.Forms.RadioButton();
			this.rbIgual = new System.Windows.Forms.RadioButton();
			this.rbLike = new System.Windows.Forms.RadioButton();
			this.rbMenorIgual = new System.Windows.Forms.RadioButton();
			this.rbMayorIgual = new System.Windows.Forms.RadioButton();
			this.rbMenor = new System.Windows.Forms.RadioButton();
			this.rbMayor = new System.Windows.Forms.RadioButton();
			this.groupValores = new System.Windows.Forms.GroupBox();
			this.chkValorColumna = new mz.erp.ui.controls.ToolTipCheckedListBox();
			this.btnConstantes = new System.Windows.Forms.RadioButton();
			this.btnColumnas = new System.Windows.Forms.RadioButton();
			this.panelConstantes = new System.Windows.Forms.Panel();
			this.uccValor = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.uceValor = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.uneValor = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.panelABMCondiciones = new System.Windows.Forms.GroupBox();
			this.gridConfiguraciones = new Janus.Windows.GridEX.GridEX();
			this.txtNombreConfiguracion = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panelBotonesConfirmacionCondiciones = new System.Windows.Forms.GroupBox();
			this.btnAceptarCondicion = new Infragistics.Win.Misc.UltraButton();
			this.btnCanelarCond = new Infragistics.Win.Misc.UltraButton();
			this.panelBotonesABMCondiciones = new System.Windows.Forms.GroupBox();
			this.btnAgregar = new Infragistics.Win.Misc.UltraButton();
			this.btnEliminar = new Infragistics.Win.Misc.UltraButton();
			this.btnModificarCondicion = new Infragistics.Win.Misc.UltraButton();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.chkUsuarios = new mz.erp.ui.controls.ToolTipCheckedListBox();
			this.rbPorUsuario = new System.Windows.Forms.RadioButton();
			this.chkPerfiles = new mz.erp.ui.controls.ToolTipCheckedListBox();
			this.rbPorPerfil = new System.Windows.Forms.RadioButton();
			this.rbTodos = new System.Windows.Forms.RadioButton();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.chkUsuariosAplicables = new mz.erp.ui.controls.ToolTipCheckedListBox();
			this.rbPorUsuarioAplicables = new System.Windows.Forms.RadioButton();
			this.chkPerfilesAplicables = new mz.erp.ui.controls.ToolTipCheckedListBox();
			this.rbPorPerfilAplicables = new System.Windows.Forms.RadioButton();
			this.rbTodosAplicables = new System.Windows.Forms.RadioButton();
			this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.chkUsuariosModificables = new mz.erp.ui.controls.ToolTipCheckedListBox();
			this.rbPorUsuarioModificables = new System.Windows.Forms.RadioButton();
			this.chkPerfilesModificables = new mz.erp.ui.controls.ToolTipCheckedListBox();
			this.rbPorPerfilModificables = new System.Windows.Forms.RadioButton();
			this.rbTodosModificables = new System.Windows.Forms.RadioButton();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbFirst = new System.Windows.Forms.ToolBarButton();
			this.tbPrev = new System.Windows.Forms.ToolBarButton();
			this.tbNext = new System.Windows.Forms.ToolBarButton();
			this.tbLast = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.tbActualizar = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.tbTerminar = new System.Windows.Forms.ToolBarButton();
			this.tbStep3 = new System.Windows.Forms.ToolBarButton();
			this.tbDelete = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panelBotonesConfirmacionConfiguracion.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCEConfiguraciones)).BeginInit();
			this.panelBotonesABMConfiguracion.SuspendLayout();
			this.panelABM.SuspendLayout();
			this.groupComparadores.SuspendLayout();
			this.groupValores.SuspendLayout();
			this.panelConstantes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uccValor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneValor)).BeginInit();
			this.panelABMCondiciones.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridConfiguraciones)).BeginInit();
			this.panelBotonesConfirmacionCondiciones.SuspendLayout();
			this.panelBotonesABMCondiciones.SuspendLayout();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			this.ultraExplorerBarContainerControl4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.groupBox1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.panelABM);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.panelABMCondiciones);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 34);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(878, 650);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			this.ultraExplorerBarContainerControl1.TabStop = true;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.panelBotonesConfirmacionConfiguracion);
			this.groupBox1.Controls.Add(this.mzCEConfiguraciones);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.panelBotonesABMConfiguracion);
			this.groupBox1.Controls.Add(this.btnAplicarConfig);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(878, 48);
			this.groupBox1.TabIndex = 156;
			this.groupBox1.TabStop = false;
			// 
			// panelBotonesConfirmacionConfiguracion
			// 
			this.panelBotonesConfirmacionConfiguracion.BackColor = System.Drawing.Color.Transparent;
			this.panelBotonesConfirmacionConfiguracion.Controls.Add(this.btnCancelar);
			this.panelBotonesConfirmacionConfiguracion.Controls.Add(this.btnAceptar);
			this.panelBotonesConfirmacionConfiguracion.Location = new System.Drawing.Point(408, 16);
			this.panelBotonesConfirmacionConfiguracion.Name = "panelBotonesConfirmacionConfiguracion";
			this.panelBotonesConfirmacionConfiguracion.Size = new System.Drawing.Size(160, 24);
			this.panelBotonesConfirmacionConfiguracion.TabIndex = 153;
			this.panelBotonesConfirmacionConfiguracion.TabStop = false;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.Enabled = false;
			this.btnCancelar.Location = new System.Drawing.Point(80, 0);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(80, 24);
			this.btnCancelar.TabIndex = 149;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(0, 0);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(80, 24);
			this.btnAceptar.TabIndex = 148;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// mzCEConfiguraciones
			// 
			this.mzCEConfiguraciones.AutoComplete = true;
			this.mzCEConfiguraciones.DataSource = null;
			this.mzCEConfiguraciones.DisplayMember = "";
			this.mzCEConfiguraciones.DisplayMemberCaption = "";
			this.mzCEConfiguraciones.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEConfiguraciones.Location = new System.Drawing.Point(104, 16);
			this.mzCEConfiguraciones.MaxDropDownItems = 7;
			this.mzCEConfiguraciones.MaxItemsDisplay = 50;
			this.mzCEConfiguraciones.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEConfiguraciones.Name = "mzCEConfiguraciones";
			this.mzCEConfiguraciones.Size = new System.Drawing.Size(288, 21);
			this.mzCEConfiguraciones.SorterMember = "";
			this.mzCEConfiguraciones.TabIndex = 140;
			this.mzCEConfiguraciones.ValueMember = "";
			this.mzCEConfiguraciones.ValueMemberCaption = "";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(8, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 16);
			this.label4.TabIndex = 135;
			this.label4.Text = "Configuraciones";
			// 
			// panelBotonesABMConfiguracion
			// 
			this.panelBotonesABMConfiguracion.BackColor = System.Drawing.Color.Transparent;
			this.panelBotonesABMConfiguracion.Controls.Add(this.btnModificarConfig);
			this.panelBotonesABMConfiguracion.Controls.Add(this.btnAgregarConfig);
			this.panelBotonesABMConfiguracion.Controls.Add(this.btnBorrarConfig);
			this.panelBotonesABMConfiguracion.Location = new System.Drawing.Point(408, 16);
			this.panelBotonesABMConfiguracion.Name = "panelBotonesABMConfiguracion";
			this.panelBotonesABMConfiguracion.Size = new System.Drawing.Size(240, 24);
			this.panelBotonesABMConfiguracion.TabIndex = 154;
			this.panelBotonesABMConfiguracion.TabStop = false;
			// 
			// btnModificarConfig
			// 
			this.btnModificarConfig.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModificarConfig.Enabled = false;
			this.btnModificarConfig.Location = new System.Drawing.Point(80, 0);
			this.btnModificarConfig.Name = "btnModificarConfig";
			this.btnModificarConfig.Size = new System.Drawing.Size(80, 24);
			this.btnModificarConfig.TabIndex = 142;
			this.btnModificarConfig.Text = "Modificar";
			this.btnModificarConfig.Click += new System.EventHandler(this.btnModificarConfig_Click);
			// 
			// btnAgregarConfig
			// 
			this.btnAgregarConfig.Location = new System.Drawing.Point(0, 0);
			this.btnAgregarConfig.Name = "btnAgregarConfig";
			this.btnAgregarConfig.Size = new System.Drawing.Size(80, 24);
			this.btnAgregarConfig.TabIndex = 141;
			this.btnAgregarConfig.Text = "Agregar";
			this.btnAgregarConfig.Click += new System.EventHandler(this.btnAgregarConfig_Click);
			// 
			// btnBorrarConfig
			// 
			this.btnBorrarConfig.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBorrarConfig.Enabled = false;
			this.btnBorrarConfig.Location = new System.Drawing.Point(160, 0);
			this.btnBorrarConfig.Name = "btnBorrarConfig";
			this.btnBorrarConfig.Size = new System.Drawing.Size(80, 24);
			this.btnBorrarConfig.TabIndex = 143;
			this.btnBorrarConfig.Text = "Borrar";
			this.btnBorrarConfig.Click += new System.EventHandler(this.btnBorrarConfig_Click);
			// 
			// btnAplicarConfig
			// 
			this.btnAplicarConfig.Location = new System.Drawing.Point(656, 16);
			this.btnAplicarConfig.Name = "btnAplicarConfig";
			this.btnAplicarConfig.Size = new System.Drawing.Size(80, 24);
			this.btnAplicarConfig.TabIndex = 144;
			this.btnAplicarConfig.Text = "Aplicar";
			this.btnAplicarConfig.Click += new System.EventHandler(this.btnAplicarConfig_Click);
			// 
			// panelABM
			// 
			this.panelABM.BackColor = System.Drawing.Color.Transparent;
			this.panelABM.Controls.Add(this.label7);
			this.panelABM.Controls.Add(this.btnBajar);
			this.panelABM.Controls.Add(this.btnNinguno);
			this.panelABM.Controls.Add(this.btnInvertir);
			this.panelABM.Controls.Add(this.btnTodos);
			this.panelABM.Controls.Add(this.btnVerTodas);
			this.panelABM.Controls.Add(this.btnSubir);
			this.panelABM.Controls.Add(this.btnVerSeleccionados);
			this.panelABM.Controls.Add(this.chkColumnas);
			this.panelABM.Controls.Add(this.groupComparadores);
			this.panelABM.Controls.Add(this.groupValores);
			this.panelABM.Controls.Add(this.label2);
			this.panelABM.Controls.Add(this.propertyGrid1);
			this.panelABM.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelABM.Location = new System.Drawing.Point(0, 282);
			this.panelABM.Name = "panelABM";
			this.panelABM.Size = new System.Drawing.Size(878, 368);
			this.panelABM.TabIndex = 155;
			this.panelABM.TabStop = false;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(8, 8);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 16);
			this.label7.TabIndex = 95;
			this.label7.Text = "Columnas";
			// 
			// btnBajar
			// 
			this.btnBajar.ImageIndex = 12;
			this.btnBajar.ImageList = this.imglStandar;
			this.btnBajar.Location = new System.Drawing.Point(248, 88);
			this.btnBajar.Name = "btnBajar";
			this.btnBajar.Size = new System.Drawing.Size(24, 32);
			this.btnBajar.TabIndex = 121;
			this.btnBajar.Click += new System.EventHandler(this.btnBajar_Click);
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btnNinguno
			// 
			this.btnNinguno.Location = new System.Drawing.Point(24, 176);
			this.btnNinguno.Name = "btnNinguno";
			this.btnNinguno.Size = new System.Drawing.Size(16, 24);
			this.btnNinguno.TabIndex = 120;
			this.btnNinguno.Text = "N";
			this.btnNinguno.Click += new System.EventHandler(this.btnNinguno_Click);
			// 
			// btnInvertir
			// 
			this.btnInvertir.Location = new System.Drawing.Point(40, 176);
			this.btnInvertir.Name = "btnInvertir";
			this.btnInvertir.Size = new System.Drawing.Size(16, 24);
			this.btnInvertir.TabIndex = 119;
			this.btnInvertir.Text = "I";
			this.btnInvertir.Click += new System.EventHandler(this.btnInvertir_Click);
			// 
			// btnTodos
			// 
			this.btnTodos.Location = new System.Drawing.Point(8, 176);
			this.btnTodos.Name = "btnTodos";
			this.btnTodos.Size = new System.Drawing.Size(16, 24);
			this.btnTodos.TabIndex = 118;
			this.btnTodos.Text = "T";
			this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
			// 
			// btnVerTodas
			// 
			this.btnVerTodas.Location = new System.Drawing.Point(168, 176);
			this.btnVerTodas.Name = "btnVerTodas";
			this.btnVerTodas.Size = new System.Drawing.Size(72, 24);
			this.btnVerTodas.TabIndex = 124;
			this.btnVerTodas.Text = "Ver Todas";
			this.btnVerTodas.Click += new System.EventHandler(this.btnVerTodas_Click);
			// 
			// btnSubir
			// 
			this.btnSubir.ImageIndex = 11;
			this.btnSubir.ImageList = this.imglStandar;
			this.btnSubir.Location = new System.Drawing.Point(248, 56);
			this.btnSubir.Name = "btnSubir";
			this.btnSubir.Size = new System.Drawing.Size(24, 32);
			this.btnSubir.TabIndex = 122;
			this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
			// 
			// btnVerSeleccionados
			// 
			this.btnVerSeleccionados.Location = new System.Drawing.Point(56, 176);
			this.btnVerSeleccionados.Name = "btnVerSeleccionados";
			this.btnVerSeleccionados.Size = new System.Drawing.Size(112, 24);
			this.btnVerSeleccionados.TabIndex = 123;
			this.btnVerSeleccionados.Text = "Ver Seleccionadas";
			this.btnVerSeleccionados.Click += new System.EventHandler(this.btnVerSeleccionados_Click);
			// 
			// chkColumnas
			// 
			this.chkColumnas.Location = new System.Drawing.Point(8, 24);
			this.chkColumnas.Name = "chkColumnas";
			this.chkColumnas.Size = new System.Drawing.Size(232, 154);
			this.chkColumnas.TabIndex = 117;
			// 
			// groupComparadores
			// 
			this.groupComparadores.BackColor = System.Drawing.Color.Transparent;
			this.groupComparadores.Controls.Add(this.rbDistinto);
			this.groupComparadores.Controls.Add(this.rbIgual);
			this.groupComparadores.Controls.Add(this.rbLike);
			this.groupComparadores.Controls.Add(this.rbMenorIgual);
			this.groupComparadores.Controls.Add(this.rbMayorIgual);
			this.groupComparadores.Controls.Add(this.rbMenor);
			this.groupComparadores.Controls.Add(this.rbMayor);
			this.groupComparadores.Location = new System.Drawing.Point(288, 24);
			this.groupComparadores.Name = "groupComparadores";
			this.groupComparadores.Size = new System.Drawing.Size(48, 184);
			this.groupComparadores.TabIndex = 125;
			this.groupComparadores.TabStop = false;
			// 
			// rbDistinto
			// 
			this.rbDistinto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbDistinto.Location = new System.Drawing.Point(8, 136);
			this.rbDistinto.Name = "rbDistinto";
			this.rbDistinto.Size = new System.Drawing.Size(40, 24);
			this.rbDistinto.TabIndex = 6;
			this.rbDistinto.Text = "!=";
			// 
			// rbIgual
			// 
			this.rbIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbIgual.Location = new System.Drawing.Point(8, 64);
			this.rbIgual.Name = "rbIgual";
			this.rbIgual.Size = new System.Drawing.Size(40, 24);
			this.rbIgual.TabIndex = 5;
			this.rbIgual.Text = "=";
			// 
			// rbLike
			// 
			this.rbLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbLike.Location = new System.Drawing.Point(8, 160);
			this.rbLike.Name = "rbLike";
			this.rbLike.Size = new System.Drawing.Size(40, 24);
			this.rbLike.TabIndex = 4;
			this.rbLike.Text = "like";
			// 
			// rbMenorIgual
			// 
			this.rbMenorIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbMenorIgual.Location = new System.Drawing.Point(8, 112);
			this.rbMenorIgual.Name = "rbMenorIgual";
			this.rbMenorIgual.Size = new System.Drawing.Size(40, 24);
			this.rbMenorIgual.TabIndex = 3;
			this.rbMenorIgual.Text = "<=";
			// 
			// rbMayorIgual
			// 
			this.rbMayorIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbMayorIgual.Location = new System.Drawing.Point(8, 88);
			this.rbMayorIgual.Name = "rbMayorIgual";
			this.rbMayorIgual.Size = new System.Drawing.Size(40, 24);
			this.rbMayorIgual.TabIndex = 2;
			this.rbMayorIgual.Text = ">=";
			// 
			// rbMenor
			// 
			this.rbMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbMenor.Location = new System.Drawing.Point(8, 40);
			this.rbMenor.Name = "rbMenor";
			this.rbMenor.Size = new System.Drawing.Size(40, 24);
			this.rbMenor.TabIndex = 1;
			this.rbMenor.Text = "<";
			// 
			// rbMayor
			// 
			this.rbMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbMayor.Location = new System.Drawing.Point(8, 16);
			this.rbMayor.Name = "rbMayor";
			this.rbMayor.Size = new System.Drawing.Size(40, 24);
			this.rbMayor.TabIndex = 0;
			this.rbMayor.Text = ">";
			// 
			// groupValores
			// 
			this.groupValores.BackColor = System.Drawing.Color.Transparent;
			this.groupValores.Controls.Add(this.chkValorColumna);
			this.groupValores.Controls.Add(this.btnConstantes);
			this.groupValores.Controls.Add(this.btnColumnas);
			this.groupValores.Controls.Add(this.panelConstantes);
			this.groupValores.Location = new System.Drawing.Point(352, 16);
			this.groupValores.Name = "groupValores";
			this.groupValores.Size = new System.Drawing.Size(512, 192);
			this.groupValores.TabIndex = 126;
			this.groupValores.TabStop = false;
			this.groupValores.Text = "Valores";
			// 
			// chkValorColumna
			// 
			this.chkValorColumna.Location = new System.Drawing.Point(304, 32);
			this.chkValorColumna.Name = "chkValorColumna";
			this.chkValorColumna.Size = new System.Drawing.Size(200, 154);
			this.chkValorColumna.TabIndex = 118;
			// 
			// btnConstantes
			// 
			this.btnConstantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnConstantes.Location = new System.Drawing.Point(8, 8);
			this.btnConstantes.Name = "btnConstantes";
			this.btnConstantes.Size = new System.Drawing.Size(88, 24);
			this.btnConstantes.TabIndex = 6;
			this.btnConstantes.Text = "Constantes";
			// 
			// btnColumnas
			// 
			this.btnColumnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnColumnas.Location = new System.Drawing.Point(304, 8);
			this.btnColumnas.Name = "btnColumnas";
			this.btnColumnas.Size = new System.Drawing.Size(96, 24);
			this.btnColumnas.TabIndex = 5;
			this.btnColumnas.Text = "Columnas";
			// 
			// panelConstantes
			// 
			this.panelConstantes.BackColor = System.Drawing.Color.Transparent;
			this.panelConstantes.Controls.Add(this.uccValor);
			this.panelConstantes.Controls.Add(this.uceValor);
			this.panelConstantes.Controls.Add(this.uneValor);
			this.panelConstantes.Controls.Add(this.txtValor);
			this.panelConstantes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.panelConstantes.Location = new System.Drawing.Point(0, 32);
			this.panelConstantes.Name = "panelConstantes";
			this.panelConstantes.Size = new System.Drawing.Size(288, 88);
			this.panelConstantes.TabIndex = 7;
			// 
			// uccValor
			// 
			dateButton1.Caption = "Today";
			this.uccValor.DateButtons.Add(dateButton1);
			this.uccValor.Location = new System.Drawing.Point(8, 63);
			this.uccValor.Name = "uccValor";
			this.uccValor.NonAutoSizeHeight = 23;
			this.uccValor.Size = new System.Drawing.Size(96, 21);
			this.uccValor.TabIndex = 88;
			// 
			// uceValor
			// 
			this.uceValor.BackColor = System.Drawing.Color.Transparent;
			this.uceValor.Location = new System.Drawing.Point(8, 45);
			this.uceValor.Name = "uceValor";
			this.uceValor.Size = new System.Drawing.Size(80, 16);
			this.uceValor.TabIndex = 87;
			this.uceValor.Text = "Verdadero";
			// 
			// uneValor
			// 
			this.uneValor.Location = new System.Drawing.Point(8, 22);
			this.uneValor.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
			this.uneValor.MaskInput = "-nnnnnnnn.nnnn";
			this.uneValor.Name = "uneValor";
			this.uneValor.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneValor.Size = new System.Drawing.Size(100, 21);
			this.uneValor.TabIndex = 2;
			this.uneValor.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// txtValor
			// 
			this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtValor.Location = new System.Drawing.Point(8, 0);
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(272, 20);
			this.txtValor.TabIndex = 1;
			this.txtValor.Text = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(8, 216);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 16);
			this.label2.TabIndex = 129;
			this.label2.Text = "Estilos";
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.BackColor = System.Drawing.Color.White;
			this.propertyGrid1.CommandsBackColor = System.Drawing.Color.White;
			this.propertyGrid1.CommandsVisibleIfAvailable = true;
			this.propertyGrid1.HelpVisible = false;
			this.propertyGrid1.LargeButtons = false;
			this.propertyGrid1.LineColor = System.Drawing.SystemColors.Control;
			this.propertyGrid1.Location = new System.Drawing.Point(64, 216);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
			this.propertyGrid1.Size = new System.Drawing.Size(528, 144);
			this.propertyGrid1.TabIndex = 128;
			this.propertyGrid1.Text = "propertyGrid1";
			this.propertyGrid1.ToolbarVisible = false;
			this.propertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window;
			this.propertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText;
			// 
			// panelABMCondiciones
			// 
			this.panelABMCondiciones.BackColor = System.Drawing.Color.Transparent;
			this.panelABMCondiciones.Controls.Add(this.gridConfiguraciones);
			this.panelABMCondiciones.Controls.Add(this.txtNombreConfiguracion);
			this.panelABMCondiciones.Controls.Add(this.label3);
			this.panelABMCondiciones.Controls.Add(this.panelBotonesConfirmacionCondiciones);
			this.panelABMCondiciones.Controls.Add(this.panelBotonesABMCondiciones);
			this.panelABMCondiciones.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelABMCondiciones.Location = new System.Drawing.Point(0, 0);
			this.panelABMCondiciones.Name = "panelABMCondiciones";
			this.panelABMCondiciones.Size = new System.Drawing.Size(878, 650);
			this.panelABMCondiciones.TabIndex = 152;
			this.panelABMCondiciones.TabStop = false;
			// 
			// gridConfiguraciones
			// 
			this.gridConfiguraciones.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridConfiguraciones.AlternatingColors = true;
			this.gridConfiguraciones.AutomaticSort = false;
			this.gridConfiguraciones.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridConfiguraciones.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridConfiguraciones.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridConfiguraciones.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridConfiguraciones.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gridConfiguraciones.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gridConfiguraciones.GroupByBoxVisible = false;
			this.gridConfiguraciones.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridConfiguraciones.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridConfiguraciones.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gridConfiguraciones.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
			this.gridConfiguraciones.Location = new System.Drawing.Point(8, 112);
			this.gridConfiguraciones.Name = "gridConfiguraciones";
			this.gridConfiguraciones.RecordNavigatorText = "Registro:|de";
			this.gridConfiguraciones.ShowEmptyFields = false;
			this.gridConfiguraciones.Size = new System.Drawing.Size(696, 160);
			this.gridConfiguraciones.TabIndex = 159;
			this.gridConfiguraciones.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			// 
			// txtNombreConfiguracion
			// 
			this.txtNombreConfiguracion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNombreConfiguracion.Location = new System.Drawing.Point(128, 56);
			this.txtNombreConfiguracion.Name = "txtNombreConfiguracion";
			this.txtNombreConfiguracion.Size = new System.Drawing.Size(272, 20);
			this.txtNombreConfiguracion.TabIndex = 162;
			this.txtNombreConfiguracion.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label3.Location = new System.Drawing.Point(8, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 16);
			this.label3.TabIndex = 161;
			this.label3.Text = "Nombre Configuración";
			// 
			// panelBotonesConfirmacionCondiciones
			// 
			this.panelBotonesConfirmacionCondiciones.BackColor = System.Drawing.Color.Transparent;
			this.panelBotonesConfirmacionCondiciones.Controls.Add(this.btnAceptarCondicion);
			this.panelBotonesConfirmacionCondiciones.Controls.Add(this.btnCanelarCond);
			this.panelBotonesConfirmacionCondiciones.Location = new System.Drawing.Point(8, 88);
			this.panelBotonesConfirmacionCondiciones.Name = "panelBotonesConfirmacionCondiciones";
			this.panelBotonesConfirmacionCondiciones.Size = new System.Drawing.Size(160, 24);
			this.panelBotonesConfirmacionCondiciones.TabIndex = 158;
			this.panelBotonesConfirmacionCondiciones.TabStop = false;
			// 
			// btnAceptarCondicion
			// 
			this.btnAceptarCondicion.Location = new System.Drawing.Point(0, 0);
			this.btnAceptarCondicion.Name = "btnAceptarCondicion";
			this.btnAceptarCondicion.Size = new System.Drawing.Size(80, 24);
			this.btnAceptarCondicion.TabIndex = 150;
			this.btnAceptarCondicion.Text = "Aceptar";
			this.btnAceptarCondicion.Click += new System.EventHandler(this.btnAceptarCondicion_Click);
			// 
			// btnCanelarCond
			// 
			this.btnCanelarCond.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCanelarCond.Location = new System.Drawing.Point(80, 0);
			this.btnCanelarCond.Name = "btnCanelarCond";
			this.btnCanelarCond.Size = new System.Drawing.Size(80, 24);
			this.btnCanelarCond.TabIndex = 151;
			this.btnCanelarCond.Text = "Cancelar";
			this.btnCanelarCond.Click += new System.EventHandler(this.btnCanelarCond_Click);
			// 
			// panelBotonesABMCondiciones
			// 
			this.panelBotonesABMCondiciones.BackColor = System.Drawing.Color.Transparent;
			this.panelBotonesABMCondiciones.Controls.Add(this.btnAgregar);
			this.panelBotonesABMCondiciones.Controls.Add(this.btnEliminar);
			this.panelBotonesABMCondiciones.Controls.Add(this.btnModificarCondicion);
			this.panelBotonesABMCondiciones.Location = new System.Drawing.Point(8, 88);
			this.panelBotonesABMCondiciones.Name = "panelBotonesABMCondiciones";
			this.panelBotonesABMCondiciones.Size = new System.Drawing.Size(344, 24);
			this.panelBotonesABMCondiciones.TabIndex = 160;
			this.panelBotonesABMCondiciones.TabStop = false;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(0, 0);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(112, 24);
			this.btnAgregar.TabIndex = 154;
			this.btnAgregar.Text = "Agregar Condición";
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEliminar.Enabled = false;
			this.btnEliminar.Location = new System.Drawing.Point(232, 0);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(112, 24);
			this.btnEliminar.TabIndex = 158;
			this.btnEliminar.Text = "Eliminar Condición";
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnModificarCondicion
			// 
			this.btnModificarCondicion.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModificarCondicion.Location = new System.Drawing.Point(112, 0);
			this.btnModificarCondicion.Name = "btnModificarCondicion";
			this.btnModificarCondicion.Size = new System.Drawing.Size(120, 24);
			this.btnModificarCondicion.TabIndex = 159;
			this.btnModificarCondicion.Text = "Modificar Condición";
			this.btnModificarCondicion.Click += new System.EventHandler(this.btnModificarCondicion_Click);
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.chkUsuarios);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.rbPorUsuario);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.chkPerfiles);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.rbPorPerfil);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.rbTodos);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 503);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(878, 150);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// chkUsuarios
			// 
			this.chkUsuarios.Location = new System.Drawing.Point(392, 25);
			this.chkUsuarios.Name = "chkUsuarios";
			this.chkUsuarios.Size = new System.Drawing.Size(240, 124);
			this.chkUsuarios.TabIndex = 122;
			// 
			// rbPorUsuario
			// 
			this.rbPorUsuario.BackColor = System.Drawing.Color.Transparent;
			this.rbPorUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbPorUsuario.Location = new System.Drawing.Point(392, 1);
			this.rbPorUsuario.Name = "rbPorUsuario";
			this.rbPorUsuario.Size = new System.Drawing.Size(96, 24);
			this.rbPorUsuario.TabIndex = 121;
			this.rbPorUsuario.Text = "Por Usuario";
			// 
			// chkPerfiles
			// 
			this.chkPerfiles.Location = new System.Drawing.Point(128, 24);
			this.chkPerfiles.Name = "chkPerfiles";
			this.chkPerfiles.Size = new System.Drawing.Size(240, 124);
			this.chkPerfiles.TabIndex = 120;
			// 
			// rbPorPerfil
			// 
			this.rbPorPerfil.BackColor = System.Drawing.Color.Transparent;
			this.rbPorPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbPorPerfil.Location = new System.Drawing.Point(128, 0);
			this.rbPorPerfil.Name = "rbPorPerfil";
			this.rbPorPerfil.Size = new System.Drawing.Size(96, 24);
			this.rbPorPerfil.TabIndex = 119;
			this.rbPorPerfil.Text = "Por Perfil";
			// 
			// rbTodos
			// 
			this.rbTodos.BackColor = System.Drawing.Color.Transparent;
			this.rbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbTodos.Location = new System.Drawing.Point(16, 0);
			this.rbTodos.Name = "rbTodos";
			this.rbTodos.Size = new System.Drawing.Size(88, 24);
			this.rbTodos.TabIndex = 7;
			this.rbTodos.Text = "Todos";
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.chkUsuariosAplicables);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.rbPorUsuarioAplicables);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.chkPerfilesAplicables);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.rbPorPerfilAplicables);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.rbTodosAplicables);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 514);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(846, 150);
			this.ultraExplorerBarContainerControl2.TabIndex = 3;
			// 
			// chkUsuariosAplicables
			// 
			this.chkUsuariosAplicables.Location = new System.Drawing.Point(392, 26);
			this.chkUsuariosAplicables.Name = "chkUsuariosAplicables";
			this.chkUsuariosAplicables.Size = new System.Drawing.Size(240, 124);
			this.chkUsuariosAplicables.TabIndex = 127;
			// 
			// rbPorUsuarioAplicables
			// 
			this.rbPorUsuarioAplicables.BackColor = System.Drawing.Color.Transparent;
			this.rbPorUsuarioAplicables.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbPorUsuarioAplicables.Location = new System.Drawing.Point(392, 2);
			this.rbPorUsuarioAplicables.Name = "rbPorUsuarioAplicables";
			this.rbPorUsuarioAplicables.Size = new System.Drawing.Size(96, 24);
			this.rbPorUsuarioAplicables.TabIndex = 126;
			this.rbPorUsuarioAplicables.Text = "Por Usuario";
			// 
			// chkPerfilesAplicables
			// 
			this.chkPerfilesAplicables.Location = new System.Drawing.Point(128, 25);
			this.chkPerfilesAplicables.Name = "chkPerfilesAplicables";
			this.chkPerfilesAplicables.Size = new System.Drawing.Size(240, 124);
			this.chkPerfilesAplicables.TabIndex = 125;
			// 
			// rbPorPerfilAplicables
			// 
			this.rbPorPerfilAplicables.BackColor = System.Drawing.Color.Transparent;
			this.rbPorPerfilAplicables.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbPorPerfilAplicables.Location = new System.Drawing.Point(128, 1);
			this.rbPorPerfilAplicables.Name = "rbPorPerfilAplicables";
			this.rbPorPerfilAplicables.Size = new System.Drawing.Size(96, 24);
			this.rbPorPerfilAplicables.TabIndex = 124;
			this.rbPorPerfilAplicables.Text = "Por Perfil";
			// 
			// rbTodosAplicables
			// 
			this.rbTodosAplicables.BackColor = System.Drawing.Color.Transparent;
			this.rbTodosAplicables.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbTodosAplicables.Location = new System.Drawing.Point(16, 1);
			this.rbTodosAplicables.Name = "rbTodosAplicables";
			this.rbTodosAplicables.Size = new System.Drawing.Size(88, 24);
			this.rbTodosAplicables.TabIndex = 123;
			this.rbTodosAplicables.Text = "Todos";
			// 
			// ultraExplorerBarContainerControl4
			// 
			this.ultraExplorerBarContainerControl4.Controls.Add(this.chkUsuariosModificables);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.rbPorUsuarioModificables);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.chkPerfilesModificables);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.rbPorPerfilModificables);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.rbTodosModificables);
			this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, 338);
			this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
			this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(846, 150);
			this.ultraExplorerBarContainerControl4.TabIndex = 4;
			// 
			// chkUsuariosModificables
			// 
			this.chkUsuariosModificables.Location = new System.Drawing.Point(392, 26);
			this.chkUsuariosModificables.Name = "chkUsuariosModificables";
			this.chkUsuariosModificables.Size = new System.Drawing.Size(240, 124);
			this.chkUsuariosModificables.TabIndex = 127;
			// 
			// rbPorUsuarioModificables
			// 
			this.rbPorUsuarioModificables.BackColor = System.Drawing.Color.Transparent;
			this.rbPorUsuarioModificables.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbPorUsuarioModificables.Location = new System.Drawing.Point(392, 2);
			this.rbPorUsuarioModificables.Name = "rbPorUsuarioModificables";
			this.rbPorUsuarioModificables.Size = new System.Drawing.Size(96, 24);
			this.rbPorUsuarioModificables.TabIndex = 126;
			this.rbPorUsuarioModificables.Text = "Por Usuario";
			// 
			// chkPerfilesModificables
			// 
			this.chkPerfilesModificables.Location = new System.Drawing.Point(128, 25);
			this.chkPerfilesModificables.Name = "chkPerfilesModificables";
			this.chkPerfilesModificables.Size = new System.Drawing.Size(240, 124);
			this.chkPerfilesModificables.TabIndex = 125;
			// 
			// rbPorPerfilModificables
			// 
			this.rbPorPerfilModificables.BackColor = System.Drawing.Color.Transparent;
			this.rbPorPerfilModificables.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbPorPerfilModificables.Location = new System.Drawing.Point(128, 1);
			this.rbPorPerfilModificables.Name = "rbPorPerfilModificables";
			this.rbPorPerfilModificables.Size = new System.Drawing.Size(96, 24);
			this.rbPorPerfilModificables.TabIndex = 124;
			this.rbPorPerfilModificables.Text = "Por Perfil";
			// 
			// rbTodosModificables
			// 
			this.rbTodosModificables.BackColor = System.Drawing.Color.Transparent;
			this.rbTodosModificables.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbTodosModificables.Location = new System.Drawing.Point(16, 1);
			this.rbTodosModificables.Name = "rbTodosModificables";
			this.rbTodosModificables.Size = new System.Drawing.Size(88, 24);
			this.rbTodosModificables.TabIndex = 123;
			this.rbTodosModificables.Text = "Todos";
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.tbFirst,
																							  this.tbPrev,
																							  this.tbNext,
																							  this.tbLast,
																							  this.toolBarButton5,
																							  this.tbActualizar,
																							  this.toolBarButton7,
																							  this.tbTerminar,
																							  this.tbStep3,
																							  this.tbDelete});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(944, 28);
			this.toolBarStandar.TabIndex = 18;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// tbFirst
			// 
			this.tbFirst.ImageIndex = 0;
			this.tbFirst.Visible = false;
			// 
			// tbPrev
			// 
			this.tbPrev.ImageIndex = 1;
			this.tbPrev.Visible = false;
			// 
			// tbNext
			// 
			this.tbNext.ImageIndex = 2;
			this.tbNext.Visible = false;
			// 
			// tbLast
			// 
			this.tbLast.ImageIndex = 3;
			this.tbLast.Visible = false;
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.toolBarButton5.Visible = false;
			// 
			// tbActualizar
			// 
			this.tbActualizar.ImageIndex = 5;
			this.tbActualizar.Visible = false;
			// 
			// toolBarButton7
			// 
			this.toolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.toolBarButton7.Visible = false;
			// 
			// tbTerminar
			// 
			this.tbTerminar.ImageIndex = 7;
			this.tbTerminar.Text = "&Terminar";
			// 
			// tbStep3
			// 
			this.tbStep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.tbStep3.Visible = false;
			// 
			// tbDelete
			// 
			this.tbDelete.ImageIndex = 7;
			this.tbDelete.Text = "Borrar";
			this.tbDelete.Visible = false;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 650;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup2.Key = "Aplicacion";
			ultraExplorerBarGroup2.Settings.ContainerHeight = 150;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Aplicación";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup3.Key = "Aplicables";
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Aplicables";
			ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl4;
			ultraExplorerBarGroup4.Key = "Modificables";
			ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup4.Text = "Modificables";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3,
																														ultraExplorerBarGroup4});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(944, 498);
			this.ultraExplorerBar1.TabIndex = 19;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// FrmConfiguracionStyleGrilla
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(944, 526);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmConfiguracionStyleGrilla";
			this.Text = "FrmConfiguracionStyleGrilla";
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.panelBotonesConfirmacionConfiguracion.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCEConfiguraciones)).EndInit();
			this.panelBotonesABMConfiguracion.ResumeLayout(false);
			this.panelABM.ResumeLayout(false);
			this.groupComparadores.ResumeLayout(false);
			this.groupValores.ResumeLayout(false);
			this.panelConstantes.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uccValor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneValor)).EndInit();
			this.panelABMCondiciones.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridConfiguraciones)).EndInit();
			this.panelBotonesConfirmacionCondiciones.ResumeLayout(false);
			this.panelBotonesABMCondiciones.ResumeLayout(false);
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			this.ultraExplorerBarContainerControl4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Constructores y Destructores

		public FrmConfiguracionStyleGrilla(ArrayList columnas, Janus.Windows.GridEX.GridEX Grid, string ProcessName, string TaskName, string Formulario, string TituloFormularioPadre)
		{
			InitializeComponent();
			_uiController = new ConfiguracionStyleGrillaController();
			_uiController.Columnas = columnas;
			_uiController.ProcessName = ProcessName;
			_uiController.TaskName = TaskName;
			_uiController.Formulario = Formulario;
			_uiController.InitVariables();
			_uiController.TituloFormularioPadre = TituloFormularioPadre;
			_grid = Grid;
			_defaultRowStyle = _grid.RowFormatStyle;
			Init();
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
		private ConfiguracionStyleGrillaController _uiController;
		private bool _processItem = true;
		Janus.Windows.GridEX.GridEX _grid;
		Janus.Windows.GridEX.GridEXFormatStyle _defaultRowStyle;
		private string _estado = string.Empty;
		private mz.erp.businessrules.ConfiguracionStyleGrilla.MyGridEXFormatStyle _estiloAnterior;
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
			mzCEConfiguraciones.FillFromDataSource( _uiController.ConfiguracionesEnBD(_grid), "IdConfiguracion", "Nombre", 50, "1", "2", "Nombre");
			mzCEConfiguraciones.Value = _uiController.IdConfiguracionSeleccionada;
			if(_uiController.ConfiguracionSeleccionada.Nombre.Equals("Ninguna"))
			{
				btnModificarConfig.Enabled = false;
				btnBorrarConfig.Enabled = false;
			}
			btnAplicarConfig.Enabled = false;
		}

		private void ConfigureInterface()
		{
			this.Text = _uiController.LeyendaFormulario;
			groupComparadores.Enabled = false;
			groupValores.Enabled = false;	
			Janus.Windows.GridEX.GridEXFormatStyle fs = new Janus.Windows.GridEX.GridEXFormatStyle(_grid.RowFormatStyle);
			mz.erp.businessrules.ConfiguracionStyleGrilla.MyGridEXFormatStyle mifs = new mz.erp.businessrules.ConfiguracionStyleGrilla.MyGridEXFormatStyle(fs);
			propertyGrid1.SelectedObject = mifs;
			gridConfiguraciones.LayoutData = _uiController.GetLayout();
			btnEliminar.Enabled = false;
			panelABM.Enabled = false;
			panelABMCondiciones.Enabled = false;
			btnAceptar.Enabled = false;
			btnCancelar.Enabled = false;
			mzCEConfiguraciones.MaxDropDownItems = _uiController.CantidadMaximaConfiguracionesVisiblesEnCombo;

			panelBotonesABMConfiguracion.Visible = true;
			btnAplicarConfig.Visible = true;
			panelBotonesConfirmacionConfiguracion.Visible = false;
			panelBotonesABMCondiciones.Visible = true;
			panelBotonesConfirmacionCondiciones.Visible = false;
		}

		private void InitializeData()
		{
			chkColumnas.Items.AddRange(_uiController.Columnas.ToArray());
			chkValorColumna.Items.AddRange(_uiController.Columnas.ToArray());
			chkPerfilesAplicables.Items.AddRange(_uiController.Perfiles.ToArray());
			chkUsuariosAplicables.Items.AddRange(_uiController.Usuarios.ToArray());
			ultraExplorerBarContainerControl2.Enabled = false;
			rbPorUsuarioAplicables.Checked = false;
			rbTodosAplicables.Checked = false;
			rbPorPerfilAplicables.Checked = false;
			if(_uiController.PermiteModificarAplicables)
			{
				ultraExplorerBarContainerControl2.Enabled = true;
				string modoDeAplicacionDefault = _uiController.ModoAplicableDefault;
				if(modoDeAplicacionDefault.Equals("T"))
				{
					rbTodosAplicables.Checked = true;
				}
				else if(modoDeAplicacionDefault.Equals("U"))
				{
					rbPorUsuarioAplicables.Checked = true;
					int index = _uiController.GetIndexUsuarioLogueado();
					chkUsuariosAplicables.SetItemChecked(index, true);
				}
				else
				{
					rbPorPerfilAplicables.Checked = true;
					int index = _uiController.GetIndexPerfilLogueado();
					chkPerfilesAplicables.SetItemChecked(index, true);
				}

			}
			else
			{
				rbTodosAplicables.Checked = true;
				this.ultraExplorerBar1.Groups["Aplicables"].Visible = false;
			}

			chkPerfilesModificables.Items.AddRange(_uiController.Perfiles.ToArray());
			chkUsuariosModificables.Items.AddRange(_uiController.Usuarios.ToArray());
			ultraExplorerBarContainerControl4.Enabled = false;
			rbPorUsuarioModificables.Checked = false;
			rbTodosModificables.Checked = false;
			rbPorPerfilModificables.Checked = false;
			if(_uiController.PermiteModificarAplicablesModificables)
			{
				ultraExplorerBarContainerControl4.Enabled = true;
				string modoDeAplicacionDefault = _uiController.ModoAplicableModificableDefault;
				if(modoDeAplicacionDefault.Equals("T"))
				{
					rbTodosModificables.Checked = true;
				}
				else if(modoDeAplicacionDefault.Equals("U"))
				{
					rbPorUsuarioModificables.Checked = true;
					int index = _uiController.GetIndexUsuarioLogueado();
					chkUsuariosModificables.SetItemChecked(index, true);
				}
				else
				{
					rbPorPerfilModificables.Checked = true;
					int index = _uiController.GetIndexPerfilLogueado();
					chkPerfilesModificables.SetItemChecked(index, true);
				}

			}
			else
			{
				/*rbPorUsuarioModificables.Checked = true;
				int index = _uiController.GetIndexUsuarioLogueado();
				chkUsuariosModificables.SetItemChecked(index, true);*/
				this.ultraExplorerBar1.Groups["Modificables"].Visible = false;
			}

			chkPerfiles.Items.AddRange(_uiController.Perfiles.ToArray());
			chkUsuarios.Items.AddRange(_uiController.Usuarios.ToArray());
			ultraExplorerBarContainerControl3.Enabled = false;
			rbPorUsuario.Checked = false;
			rbTodos.Checked = false;
			rbPorPerfil.Checked = false;
			if(_uiController.PermiteModificarAplicacion)
			{
				ultraExplorerBarContainerControl3.Enabled = true;
				string modoDeAplicacionDefault = _uiController.ModoDeAplicacionDefault;
				if(modoDeAplicacionDefault.Equals("T"))
				{
					rbTodos.Checked = true;
				}
				else if(modoDeAplicacionDefault.Equals("U"))
				{
					rbPorUsuario.Checked = true;
					int index = _uiController.GetIndexUsuarioLogueado();
					chkUsuarios.SetItemChecked(index, true);
				}
				else
				{
					rbPorPerfil.Checked = true;
					int index = _uiController.GetIndexPerfilLogueado();
					chkPerfiles.SetItemChecked(index, true);
				}

			}
			else
			{
				rbPorUsuario.Checked = true;
				int index = _uiController.GetIndexUsuarioLogueado();
				chkUsuarios.SetItemChecked(index, true);
				this.ultraExplorerBar1.Groups["Aplicacion"].Visible = false;
			}

		}

		private void InitEventHandlers()
		{
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			chkColumnas.ItemCheck += new ItemCheckEventHandler(chkColumnas_ItemCheck);
			btnConstantes.CheckedChanged += new EventHandler(btnConstantes_CheckedChanged);
			rbMenor.CheckedChanged +=new EventHandler(rbComparadores_CheckedChanged);
			rbMayor.CheckedChanged +=new EventHandler(rbComparadores_CheckedChanged);
			rbIgual.CheckedChanged +=new EventHandler(rbComparadores_CheckedChanged);
			rbMayorIgual.CheckedChanged +=new EventHandler(rbComparadores_CheckedChanged);
			rbMenorIgual.CheckedChanged +=new EventHandler(rbComparadores_CheckedChanged);
			rbLike.CheckedChanged +=new EventHandler(rbComparadores_CheckedChanged);
			rbDistinto.CheckedChanged +=new EventHandler(rbComparadores_CheckedChanged);
			_uiController.ConfiguracionesHasChanged+=new EventHandler(_uiController_ConfiguracionesHasChanged);
			_uiController.CondicionesHasChanged+=new EventHandler(_uiController_CondicionesHasChanged);
			_uiController.ConfiguracionGrillaHasChanged += new EventHandler(_uiController_ConfiguracionGrillaHasChanged);
			mzCEConfiguraciones.SelectionChanged +=new EventHandler(mzCEConfiguraciones_SelectionChanged);
			gridConfiguraciones.SelectionChanged +=new EventHandler(gridConfiguraciones_SelectionChanged);
		}

		private void InitDataBindings()
		{
			txtNombreConfiguracion.DataBindings.Clear();
			txtNombreConfiguracion.DataBindings.Add("Text", _uiController, "NombreConfiguracion");
		}

		private void setComparadoresEnabled(bool valor)
		{
			rbMayor.Enabled = valor;
			rbMenor.Enabled = valor;
			rbIgual.Enabled = valor;
			rbMayorIgual.Enabled = valor;
			rbMenorIgual.Enabled = valor;
			rbDistinto.Enabled = valor;
			rbLike.Enabled = valor;
		}

		private void setValoresEnabled(bool valor)
		{
			txtValor.Enabled = valor;
			uneValor.Enabled = valor;
			uceValor.Enabled = valor;
			uccValor.Enabled = valor;
		}

		private void habilitarDatosPara(string type, int index)
		{
			bool isValidSelection = true;
			int i = 0;
			while(isValidSelection && i < chkColumnas.CheckedItems.Count)
			{
				mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView colV = (mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView)chkColumnas.CheckedItems[i];
				int indexItem = chkColumnas.Items.IndexOf(colV);
				if(indexItem != index)
					isValidSelection = colV.Type.Equals(type);
				i++;
			}
			if(isValidSelection)
			{
				groupComparadores.Enabled = true;
				groupValores.Enabled = true;
				if(!(btnConstantes.Checked || btnColumnas.Checked))
					btnConstantes.Checked = true;
				setComparadoresEnabled(false);
				setValoresEnabled(false);

				switch ( type)
				{
					case "STRING":
						rbIgual.Enabled = true;
						rbDistinto.Enabled = true;
						rbLike.Enabled = true;
						txtValor.Enabled = true;	
						chkValorColumna.Items.AddRange(_uiController.ColumnasString.ToArray());
						break;
					case "INT":			
						rbMayor.Enabled = true;
						rbMenor.Enabled = true;
						rbIgual.Enabled = true;
						rbMayorIgual.Enabled = true;
						rbMenorIgual.Enabled = true;
						rbDistinto.Enabled = true;
						uneValor.Enabled = true;
						chkValorColumna.Items.AddRange(_uiController.ColumnasInt.ToArray());
						break;
					case "DECIMAL":			
						rbMayor.Enabled = true;
						rbMenor.Enabled = true;
						rbIgual.Enabled = true;
						rbMayorIgual.Enabled = true;
						rbMenorIgual.Enabled = true;
						rbDistinto.Enabled = true;
						uneValor.Enabled = true;
						chkValorColumna.Items.AddRange(_uiController.ColumnasDecimal.ToArray());
						break;
					case "BOOL":					
						rbIgual.Enabled = true;
						rbDistinto.Enabled = true;
						uceValor.Enabled = true;
						chkValorColumna.Items.AddRange(_uiController.ColumnasBool.ToArray());
						break;
					case "DATETIME":					
						rbMayor.Enabled = true;
						rbMenor.Enabled = true;
						rbIgual.Enabled = true;
						rbMayorIgual.Enabled = true;
						rbMenorIgual.Enabled = true;
						rbDistinto.Enabled = true;
						uccValor.Enabled = true;
						chkValorColumna.Items.AddRange(_uiController.ColumnasDateTime.ToArray());
						break;
				}		

			}
			else
			{
				groupComparadores.Enabled = false;
				groupValores.Enabled = false;
				chkValorColumna.Items.AddRange(_uiController.Columnas.ToArray());
			}
		}




		private void SaveChanges()
		{	
			Util.MoveFocus(this.ultraExplorerBarContainerControl1);
			this.Cursor = Cursors.WaitCursor;
			string nombreConf = _uiController.GetNombreCofiguracionSimilar();
			if(!nombreConf.Equals(string.Empty))
				MessageBox.Show("La configuración " + nombreConf + " es identica a la configuración creada. Debe utilizar dicha configuración.", "Advertencia",System.Windows.Forms.MessageBoxButtons.OK);
			else if(_uiController.NombreConfiguracion.Equals(string.Empty))
				MessageBox.Show("Debe ingresar un nombre para esta configuración","Advertencia",System.Windows.Forms.MessageBoxButtons.OK);
			else if(_uiController.ExisteNombreConfiguracion()) 
				MessageBox.Show("El nombre de configuración ingresado ya existe, por favor elija otro","Advertencia",System.Windows.Forms.MessageBoxButtons.OK);
			else
			{
				bool ok = false;
				_uiController.UsuariosAplicablesSeleccionados = new ArrayList();
				_uiController.PerfilesAplicablesSeleccionados = new ArrayList();
				if(rbTodosAplicables.Checked)
				{
					_uiController.TodosAplicables = true;
					_uiController.PorPerfilAplicables = false;
					_uiController.PorUsuarioAplicables = false;
					ok = true;
				}
				else if (rbPorUsuarioAplicables.Checked)
				{
					_uiController.PorUsuarioAplicables = true;
					_uiController.TodosAplicables = false;
					_uiController.PorPerfilAplicables = false;
					if(chkUsuariosAplicables.CheckedItems.Count==0)
						MessageBox.Show("Debe seleccionar los usarios que pueden ver esta configuración. De lo contrario, seleccione todos","Advertencia",System.Windows.Forms.MessageBoxButtons.OK);
					else
					{
						ok = true;
						_uiController.UsuariosAplicablesSeleccionados.AddRange(chkUsuariosAplicables.CheckedItems);
					}
				}
				else
				{
					_uiController.PorPerfilAplicables = true;
					_uiController.PorUsuarioAplicables = false;
					_uiController.TodosAplicables = false;
					if(chkPerfilesAplicables.CheckedItems.Count==0)
						MessageBox.Show("Debe seleccionar los perfiles que pueden ver esta configuración. De lo contrario, seleccione todos","Advertencia",System.Windows.Forms.MessageBoxButtons.OK);
					else
					{
						ok = true;
						_uiController.PerfilesAplicablesSeleccionados.AddRange(chkPerfilesAplicables.CheckedItems);
					}
				}
				if(ok)
				{
					if(_uiController.PermiteModificarAplicablesModificables)
					{
						_uiController.UsuariosAplicablesModificablesSeleccionados = new ArrayList();
						_uiController.PerfilesAplicablesModificablesSeleccionados = new ArrayList();
						if(rbTodosModificables.Checked)
							_uiController.TodosModificables = true;
						else if (rbPorUsuarioModificables.Checked)
						{
							_uiController.PorUsuarioModificables = true;
							_uiController.UsuariosAplicablesModificablesSeleccionados.AddRange(chkUsuariosModificables.CheckedItems);
						}
						else
						{
							_uiController.PorPerfilModificables = true;
							_uiController.PerfilesAplicablesModificablesSeleccionados.AddRange(chkPerfilesModificables.CheckedItems);
						}
					}
					_uiController.Save(_grid);
					this.Cursor = Cursors.Default;
					panelABMCondiciones.Enabled = false;
					btnAceptar.Enabled = false;
					btnCancelar.Enabled = false;
					btnAgregarConfig.Enabled = true;
					if(!_uiController.ConfiguracionSeleccionada.Nombre.Equals("Ninguna"))
					{
						btnModificarConfig.Enabled = true;
						btnBorrarConfig.Enabled = true;
						if(!_uiController.IdConfiguracionSeleccionada.Equals(_uiController.IdConfiguracionAplicada))
							btnAplicarConfig.Enabled = true;
						else
							btnAplicarConfig.Enabled = false;				
					}
					else
					{
						btnModificarConfig.Enabled = false;
						btnBorrarConfig.Enabled = false;
						btnAplicarConfig.Enabled = false;
					}
				}
			}
		}

		#endregion

		#region Eventos y delegados		
		public event System.EventHandler ConfiguracionGrillaHasChanged;
		#endregion

		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 7:
					this.Close();
					break;
			}				
		}

		
		private void chkColumnas_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if(_processItem)
			{
				rbMayor.Checked = false;
				rbMenor.Checked = false;
				rbIgual.Checked = false;
				rbMayorIgual.Checked = false;
				rbMenorIgual.Checked = false;
				rbDistinto.Checked = false;
				rbLike.Checked = false;
				if(_estado.Equals("MODIF_COND") && chkColumnas.CheckedItems.Count > 0 && e.NewValue.CompareTo(System.Windows.Forms.CheckState.Checked) == 0)
				{
					chkColumnas.ItemCheck-=new ItemCheckEventHandler(chkColumnas_ItemCheck);
					this.btnNinguno_Click(sender, new EventArgs());
					chkColumnas.SetItemChecked(e.Index, true);					
					chkColumnas.ItemCheck+=new ItemCheckEventHandler(chkColumnas_ItemCheck);
				}
				chkValorColumna.Items.Clear();
				if((chkColumnas.CheckedItems.Count == 1 && e.NewValue.CompareTo(System.Windows.Forms.CheckState.Unchecked) != 0)  || (chkColumnas.CheckedItems.Count == 0 && e.NewValue.CompareTo(System.Windows.Forms.CheckState.Checked) == 0) || chkColumnas.CheckedItems.Count > 1)
				{
					mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView colV;
					if(e.NewValue.CompareTo(System.Windows.Forms.CheckState.Checked) == 0)
						colV = (mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView)chkColumnas.Items[e.Index];
					else
						colV = (mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView)chkColumnas.CheckedItems[0];
					habilitarDatosPara(colV.Type, e.Index);
				}
				else
				{
					groupComparadores.Enabled = false;
					groupValores.Enabled = false;
					chkValorColumna.Items.AddRange(_uiController.Columnas.ToArray());
				}
			}
		}

		private void btnConstantes_CheckedChanged(object sender, EventArgs e)
		{
			panelConstantes.Enabled = btnConstantes.Checked;
			chkValorColumna.Enabled = !btnConstantes.Checked;
		}

		private void btnTodos_Click(object sender, System.EventArgs e)
		{
			_processItem = false;
			for(int i = 0; i<chkColumnas.Items.Count; i++)
			{
				if(i +1 == chkColumnas.Items.Count)// si es el ultimo
					_processItem = true;
				chkColumnas.SetItemChecked(i, true);			
			}
		}

		private void btnNinguno_Click(object sender, System.EventArgs e)
		{
			_processItem = false;
			for(int i = 0; i<chkColumnas.Items.Count; i++)
			{
				if(i +1 == chkColumnas.Items.Count)// si es el ultimo
					_processItem = true;
				chkColumnas.SetItemChecked(i, false);			
			}
		}

		private void btnInvertir_Click(object sender, System.EventArgs e)
		{
			_processItem = false;
			for(int i = 0; i<chkColumnas.Items.Count; i++)
			{
				if(i +1 == chkColumnas.Items.Count)// si es el ultimo
					_processItem = true;
				chkColumnas.SetItemChecked(i, !chkColumnas.GetItemChecked(i));
			}
		
		}

		private void btnVerSeleccionados_Click(object sender, System.EventArgs e)
		{
			ArrayList selectedColumns = new ArrayList();
			foreach(mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView col in chkColumnas.CheckedItems)
				selectedColumns.Add(col);
			chkColumnas.Items.Clear();
			chkColumnas.Items.AddRange(selectedColumns.ToArray());
			_processItem = false;
			for(int i = 0; i<chkColumnas.Items.Count; i++)
			{
				if(i +1 == chkColumnas.Items.Count)// si es el ultimo
					_processItem = true;
				chkColumnas.SetItemChecked(i, true);	
			}
		}

		private void btnVerTodas_Click(object sender, System.EventArgs e)
		{
			int i = 0;
			foreach(mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView col in _uiController.Columnas)
			{
				if(!chkColumnas.Items.Contains(col))
					chkColumnas.Items.Insert(i, col);	
				i++;
			}
		
		}

		private void btnSubir_Click(object sender, System.EventArgs e)
		{
			_processItem = false;
			int index = chkColumnas.SelectedIndex;
			if(index != -1)
			{
				if(index > 0)
				{
					bool chkIndex = chkColumnas.GetItemChecked(index);
					bool chkIndex1 = chkColumnas.GetItemChecked(index -1);
					object aux = chkColumnas.Items[index];
					chkColumnas.Items[index] = chkColumnas.Items[index - 1];
					chkColumnas.SetItemChecked(index, chkIndex1);
					chkColumnas.Items[index - 1] = aux;
					chkColumnas.SetItemChecked(index -1, chkIndex);
					chkColumnas.SelectedIndex = index -1;
				}
			}
			_processItem = true;

		}

		private void btnBajar_Click(object sender, System.EventArgs e)
		{
			_processItem = false;
			int index = chkColumnas.SelectedIndex;
			if(index != -1)
			{
				if(index < chkColumnas.Items.Count - 1)
				{
					bool chkIndex = chkColumnas.GetItemChecked(index);
					bool chkIndex1 = chkColumnas.GetItemChecked(index +1);
					object aux = chkColumnas.Items[index];
					chkColumnas.Items[index] = chkColumnas.Items[index + 1];
					chkColumnas.SetItemChecked(index, chkIndex1);
					chkColumnas.Items[index + 1] = aux;
					chkColumnas.SetItemChecked(index +1, chkIndex);
					chkColumnas.SelectedIndex = index + 1;
				}
			}
			_processItem = true;
		}


		private void rbComparadores_CheckedChanged(object sender, System.EventArgs e)
		{

			System.Windows.Forms.RadioButton radioButon = (System.Windows.Forms.RadioButton) sender;
			if(radioButon.Checked)
				_uiController.Condicion = radioButon.Text;
		}

		private void btnAgregar_Click(object sender, System.EventArgs e)
		{
			panelABM.Enabled = true;
			propertyGrid1.Refresh();
			this.resetCondiciones();
			_estado = "NEW_COND";
			panelBotonesABMCondiciones.Visible = false;
			panelBotonesConfirmacionCondiciones.Visible = true;
		}

		private void resetCondiciones()
		{
			this.btnNinguno_Click(this, new EventArgs());
			for(int i = 0; i<chkValorColumna.Items.Count; i++)
				chkValorColumna.SetItemChecked(i, false);		
			txtValor.Text = string.Empty;
			uneValor.Value = 0;
			uceValor.Checked = false;
			uccValor.Value = DateTime.Today;        
			Janus.Windows.GridEX.GridEXFormatStyle fs = new Janus.Windows.GridEX.GridEXFormatStyle(_grid.RowFormatStyle);
			mz.erp.businessrules.ConfiguracionStyleGrilla.MyGridEXFormatStyle mifs = new mz.erp.businessrules.ConfiguracionStyleGrilla.MyGridEXFormatStyle(fs);
			propertyGrid1.SelectedObject = mifs;
			rbMayor.Checked = false;
			rbMenor.Checked = false;
			rbIgual.Checked = false;
			rbMayorIgual.Checked = false;
			rbMenorIgual.Checked = false;
			rbDistinto.Checked = false;
			rbLike.Checked = false;
	    }
		private void _uiController_CondicionesHasChanged(object sender, EventArgs e)
		{			
			gridConfiguraciones.SetDataBinding( null, null );
			gridConfiguraciones.SetDataBinding(_uiController.Configuraciones, null );
			if(_uiController.Configuraciones.Count > 0)
			{
				btnEliminar.Enabled = true;
				btnModificarCondicion.Enabled = true;
			}
			else
			{
				btnEliminar.Enabled = false;
				btnModificarCondicion.Enabled = false;
			}
			txtNombreConfiguracion.Text = _uiController.NombreConfiguracion;
		}

		
		private void _uiController_ConfiguracionesHasChanged(object sender, EventArgs e)
		{			
			mzCEConfiguraciones.FillFromDataSource( _uiController.ConfiguracionesEnBD(_grid), "IdConfiguracion", "Nombre", 50, "1", "2", "Nombre");
			mzCEConfiguraciones.Value = _uiController.IdConfiguracionSeleccionada;
			if(_uiController.ConfiguracionSeleccionada.Nombre.Equals("Ninguna"))
			{
				btnModificarConfig.Enabled = false;
				btnBorrarConfig.Enabled = false;
			}

		}
		
		private void btnEliminar_Click(object sender, System.EventArgs e)
		{
			if(gridConfiguraciones.SelectedItems.Count > 0)
			{
				businessrules.ConfiguracionStyleGrilla.ConfiguracionGrillaEstilosCondicionalesDet cond = (businessrules.ConfiguracionStyleGrilla.ConfiguracionGrillaEstilosCondicionalesDet)gridConfiguraciones.SelectedItems[0].GetRow().DataRow;
				if(cond.Estado.Equals("NEW"))
				{
					CurrencyManager cm = (CurrencyManager) this.BindingContext[_uiController.Configuraciones];
					int pos = cm.Position;
					if(pos >= 0)
					{
						cm.RemoveAt(pos);
						cm.Refresh();
					}
				}
				else
                    _uiController.RemoveCondicion(cond);
				if(_uiController.Configuraciones.Count == 0)
				{
					btnEliminar.Enabled = false;	
					btnModificarCondicion.Enabled = false;
				}
			}
		
		}

		private void _uiController_ConfiguracionGrillaHasChanged(object sender, EventArgs e)
		{			
			if(ConfiguracionGrillaHasChanged != null)
				ConfiguracionGrillaHasChanged(this, new EventArgs());	
		}

		private void mzCEConfiguraciones_SelectionChanged(object sender, EventArgs e)
		{
			this.resetCondiciones();
			gridConfiguraciones.SelectionChanged-=new EventHandler(gridConfiguraciones_SelectionChanged);
			_uiController.IdConfiguracionSeleccionada = (long)mzCEConfiguraciones.Value;
			gridConfiguraciones.SelectionChanged+=new EventHandler(gridConfiguraciones_SelectionChanged);
			if(_uiController.Configuraciones.Count > 0)
				gridConfiguraciones_SelectionChanged(this, new EventArgs());			
			if(!_uiController.ConfiguracionSeleccionada.Nombre.Equals("Ninguna"))
			{
				btnModificarConfig.Enabled = true;
				btnBorrarConfig.Enabled = true;
				if(!_uiController.IdConfiguracionSeleccionada.Equals(_uiController.IdConfiguracionAplicada))
					btnAplicarConfig.Enabled = true;
				else
					btnAplicarConfig.Enabled = false;				
			}
			else
			{
				btnModificarConfig.Enabled = false;
				btnBorrarConfig.Enabled = false;
				btnAplicarConfig.Enabled = false;
			}

		}

		private void btnAgregarConfig_Click(object sender, System.EventArgs e)
		{
			if(_uiController.PuedeAgregarConfiguracion())
			{
				panelABMCondiciones.Enabled = true;
				btnAceptar.Enabled = true;
				btnCancelar.Enabled = true;
				btnAgregarConfig.Enabled = false;
				btnModificarConfig.Enabled = false;
				btnBorrarConfig.Enabled = false;
				btnAplicarConfig.Enabled = false;
				_uiController.AddConfiguracion();
				panelBotonesABMConfiguracion.Visible = false;
				btnAplicarConfig.Visible = false;
				panelBotonesConfirmacionConfiguracion.Visible = true;
				panelBotonesABMCondiciones.Visible = true;
				panelBotonesConfirmacionCondiciones.Visible = false;
			}
			else
				MessageBox.Show("Ha superado la cantidad máxima de configuraciones que puede crear un usuario. Intente modificar o borrar una existente.", "Advertencia",System.Windows.Forms.MessageBoxButtons.OK);
		
		}

		private void btnModificarConfig_Click(object sender, System.EventArgs e)
		{
			if(!_uiController.ConfiguracionSeleccionada.Nombre.Equals("Ninguna"))
			{
				if(_uiController.PuedeModificarConfiguracion(_grid.Name))
				{
			
					panelABMCondiciones.Enabled = true;		
					btnAceptar.Enabled = true;
					btnCancelar.Enabled = true;
					btnAgregarConfig.Enabled = false;
					btnModificarConfig.Enabled = false;
					btnBorrarConfig.Enabled = false;
					btnAplicarConfig.Enabled = false;
					_uiController.ModificarConfiguracion();
					panelBotonesABMConfiguracion.Visible = false;
					btnAplicarConfig.Visible = false;
					panelBotonesConfirmacionConfiguracion.Visible = true;
					panelBotonesABMCondiciones.Visible = true;
					panelBotonesConfirmacionCondiciones.Visible = false;
				}
				else
				{
					if(_uiController.PuedeAgregarConfiguracion())
					{
						panelABMCondiciones.Enabled = true;
						btnAceptar.Enabled = true;
						btnCancelar.Enabled = true;
						btnAgregarConfig.Enabled = false;
						btnModificarConfig.Enabled = false;
						btnBorrarConfig.Enabled = false;
						btnAplicarConfig.Enabled = false;
						_uiController.AddConfiguracionLikeSelected();
						panelBotonesABMConfiguracion.Visible = false;
						btnAplicarConfig.Visible = false;
						panelBotonesConfirmacionConfiguracion.Visible = true;
						panelBotonesABMCondiciones.Visible = true;
						panelBotonesConfirmacionCondiciones.Visible = false;
						MessageBox.Show("La configuración seleccionada no puede ser modificada, por favor seleccione un nuevo nombre para la configuración.", "Advertencia",System.Windows.Forms.MessageBoxButtons.OK);
					}
					else
						MessageBox.Show("La configuración seleccionada no puede ser modificada y ha superado la cantidad máxima de configuraciones que puede crear un usuario.", "Advertencia",System.Windows.Forms.MessageBoxButtons.OK);
				}
                    
			}
		}

		private void btnBorrarConfig_Click(object sender, System.EventArgs e)
		{
			if(!_uiController.ConfiguracionSeleccionada.Nombre.Equals("Ninguna"))
			{
				if(_uiController.PuedeModificarConfiguracion(_grid.Name) && _uiController.PuedeBorrarConfiguracion())
				{
					if(_uiController.PuedeBorrarConfiguracionAplicada())
					{
						if(MessageBox.Show("¿Esta seguro que desea borrar la configuración " + _uiController.ConfiguracionSeleccionada.Nombre + "?", "Confirmar eliminación",System.Windows.Forms.MessageBoxButtons.OKCancel).Equals(System.Windows.Forms.DialogResult.OK))
                            _uiController.RemoveConfiguracion();
					}
					else
						MessageBox.Show("La configuración seleccionada no puede ser borrada ya que la misma se encuentra aplicada.", "Advertencia",System.Windows.Forms.MessageBoxButtons.OK);
				}
				else
					MessageBox.Show("La configuración seleccionada no puede ser borrada, pues fue creada por el usuario " + _uiController.ConfiguracionSeleccionada.IdUsuarioCreador, "Advertencia",System.Windows.Forms.MessageBoxButtons.OK);
			}
		
		}

		private void btnAplicarConfig_Click(object sender, System.EventArgs e)
		{
			if(!_uiController.ConfiguracionSeleccionada.Nombre.Equals("Ninguna"))
			{
				Util.MoveFocus(this.ultraExplorerBarContainerControl1);
				this.Cursor = Cursors.WaitCursor;
				bool ok = false;
				_uiController.UsuariosSeleccionados = new ArrayList();
				_uiController.PerfilesSeleccionados = new ArrayList();
				if(rbTodos.Checked)
				{
					if(_uiController.PuedeAplicarConfiguracionATodos(_grid.Name))
					{
						_uiController.Todos = true;
						_uiController.PorUsuario = false;
						_uiController.PorPerfil = false;
						ok = true;
					}else
						MessageBox.Show("La configuración seleccionada no es aplicable a todos los usuarios","Advertencia",System.Windows.Forms.MessageBoxButtons.OK);
				}
				else if (rbPorUsuario.Checked)
				{
					_uiController.PorUsuario = true;
					_uiController.Todos = false;
					_uiController.PorPerfil = false;
					if(chkUsuarios.CheckedItems.Count==0)
						MessageBox.Show("Debe seleccionar algún usuario al que se le aplique esta configuración","Advertencia",System.Windows.Forms.MessageBoxButtons.OK);
					else
					{
						_uiController.UsuariosSeleccionados.AddRange(chkUsuarios.CheckedItems);
						if(_uiController.PuedeAplicarConfiguracionAUsuarios(_grid.Name))
							ok = true;
						else
							MessageBox.Show("La configuración seleccionada no es aplicable a todos los usuarios seleccionados","Advertencia",System.Windows.Forms.MessageBoxButtons.OK);
					}
				}
				else
				{
					_uiController.PorPerfil = true;
					_uiController.PorUsuario = false;
					_uiController.Todos = false;
					if(chkPerfiles.CheckedItems.Count==0)
						MessageBox.Show("Debe seleccionar algún perfil al que se le aplique esta configuración","Advertencia",System.Windows.Forms.MessageBoxButtons.OK);
					else
					{
						_uiController.PerfilesSeleccionados.AddRange(chkPerfiles.CheckedItems);
						if(_uiController.PuedeAplicarConfiguracionAPerfiles(_grid.Name))
							ok = true;
						else
							MessageBox.Show("La configuración seleccionada no es aplicable a todos los perfiles seleccionados","Advertencia",System.Windows.Forms.MessageBoxButtons.OK);
					}
				}

				if(ok)
				{
					_uiController.AplicarConfiguracion(_grid);
					this.Cursor = Cursors.Default;
					btnAplicarConfig.Enabled = false;

				}
			}		
		}

		private void btnAceptar_Click(object sender, System.EventArgs e)
		{
			SaveChanges();
			panelBotonesABMConfiguracion.Visible = true;
			btnAplicarConfig.Visible = true;
			panelBotonesConfirmacionConfiguracion.Visible = false;
			panelBotonesABMCondiciones.Visible = true;
			panelBotonesConfirmacionCondiciones.Visible = false;
		}

		private void btnCancelar_Click(object sender, System.EventArgs e)
		{
			this._uiController_ConfiguracionesHasChanged(sender, new EventArgs());
			panelABMCondiciones.Enabled = false;
			panelABM.Enabled = false;
			btnAceptar.Enabled = false;
			btnCancelar.Enabled = false;
			btnAgregarConfig.Enabled = true;
			if(!_uiController.ConfiguracionSeleccionada.Nombre.Equals("Ninguna"))
			{
				btnModificarConfig.Enabled = true;
				btnBorrarConfig.Enabled = true;
				if(!_uiController.IdConfiguracionSeleccionada.Equals(_uiController.IdConfiguracionAplicada))
					btnAplicarConfig.Enabled = true;
				else
					btnAplicarConfig.Enabled = false;				

			}
			else
			{
				btnModificarConfig.Enabled = false;
				btnBorrarConfig.Enabled = false;
				btnAplicarConfig.Enabled = false;
			}
			panelBotonesABMConfiguracion.Visible = true;
			btnAplicarConfig.Visible = true;
			panelBotonesConfirmacionConfiguracion.Visible = false;
			panelBotonesABMCondiciones.Visible = true;
			panelBotonesConfirmacionCondiciones.Visible = false;
		}


		
		private void gridConfiguraciones_SelectionChanged(object sender, EventArgs e)
		{
			businessrules.ConfiguracionStyleGrilla.ConfiguracionGrillaEstilosCondicionalesDet cond = (businessrules.ConfiguracionStyleGrilla.ConfiguracionGrillaEstilosCondicionalesDet) gridConfiguraciones.GetRow().DataRow;
			this.btnNinguno_Click(sender, new EventArgs());
			int index = chkColumnas.Items.IndexOf(cond.Columna);
			chkColumnas.SetItemChecked(index, true);
			string condicion = cond.Condicion;
			switch (condicion )
			{				
				case ">" :
				{
					rbMayor.Checked = true;
					break;
				}
				case "<" :
				{
					rbMenor.Checked = true;
					break;
				}
				case "=" :
				{
					rbIgual.Checked = true;
					break;
				}
				case ">=":
				{
					rbMayorIgual.Checked = true;
					break;
				}
				case "<=":
				{
					rbMenorIgual.Checked = true;
					break;
				}
				case "!=":
				{
					rbDistinto.Checked = true;
					break;
				}
				case "like":
				{
					rbLike.Checked = true;
					break;
				}
			}	
					
			for(int i = 0; i<chkValorColumna.Items.Count; i++)
				chkValorColumna.SetItemChecked(i, false);		
			txtValor.Text = string.Empty;
			uneValor.Value = 0;
			uceValor.Checked = false;
            uccValor.Value = DateTime.Today;            
			object valor = cond.Valor;
			if(valor.GetType().Name.Equals("GridEXColumn")) //El valor es una columna
			{
				btnColumnas.Checked = true;
				Janus.Windows.GridEX.GridEXColumn valorC = (Janus.Windows.GridEX.GridEXColumn) valor;
				int i = 0;
				int indexC = -1;
				while(indexC < 0 && i<chkValorColumna.Items.Count)
				{
					businessrules.ConfiguracionStyleGrilla.ColumnaView colView = (businessrules.ConfiguracionStyleGrilla.ColumnaView)chkValorColumna.Items[i];
					if(colView.Name.Equals(valorC.Key))
						indexC = i;
					i++;
				}
				chkValorColumna.SetItemChecked(indexC, true);
			}
			else
			{
				btnConstantes.Checked = true;
				string type = cond.Columna.Type;
				switch (type )
				{	
					case "DECIMAL" :
						uneValor.Value = valor;
						break;
					case "INT" :
						uneValor.Value = valor;
						break;
					case "DATETIME" :
						uccValor.Value = valor;
						break;
					case "STRING" :
						txtValor.Text = valor.ToString();
						break;
					case "BOOL" :
						uceValor.Checked = Convert.ToBoolean(valor);
						break;
				}																
			}
			mz.erp.businessrules.ConfiguracionStyleGrilla.MyGridEXFormatStyle mifs = cond.Estilo;
			propertyGrid1.SelectedObject = mifs;
		}

		private void btnAceptarCondicion_Click(object sender, System.EventArgs e)
		{
			if(!_uiController.Condicion.Equals(string.Empty) && chkColumnas.CheckedItems.Count > 0)
			{
				object valor = null;
				mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView column = (mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView) chkColumnas.CheckedItems[0];
				switch (column.Type )
				{				
					case "STRING" :
						if(btnConstantes.Checked)
							valor = txtValor.Text;
						else if(chkValorColumna.CheckedItems.Count > 0)
							valor = ((mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView)chkValorColumna.CheckedItems[0]).RealColumn;
						break;
					case "DECIMAL" :
						if(btnConstantes.Checked)
							valor = uneValor.Value.ToString();
						else if(chkValorColumna.CheckedItems.Count > 0)
							valor = ((mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView)chkValorColumna.CheckedItems[0]).RealColumn;
						break;
					case "BOOL" :
						if(btnConstantes.Checked)
							valor = uceValor.Checked;
						break;
					case "DATETIME":
						if(btnConstantes.Checked)
							valor = uccValor.Value;
						break;
					case "INT":
						if(btnConstantes.Checked)
							valor = uneValor.Value.ToString();
						break;
				}		
				if(valor != null)
				{
					gridConfiguraciones.SelectionChanged-=new EventHandler(gridConfiguraciones_SelectionChanged);
					if(_estado.Equals("NEW_COND"))
					{
						foreach(mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView col in chkColumnas.CheckedItems)
						{
							mz.erp.businessrules.ConfiguracionStyleGrilla.MyGridEXFormatStyle mifs = (mz.erp.businessrules.ConfiguracionStyleGrilla.MyGridEXFormatStyle)propertyGrid1.SelectedObject;
							Janus.Windows.GridEX.GridEXFormatStyle fs = new Janus.Windows.GridEX.GridEXFormatStyle(mifs.ToFormatStyle());
							mz.erp.businessrules.ConfiguracionStyleGrilla.MyGridEXFormatStyle mifsCopy = new mz.erp.businessrules.ConfiguracionStyleGrilla.MyGridEXFormatStyle(fs);
							_uiController.AddCondicionAConfiguracion(col, _uiController.Condicion, valor, mifsCopy);
						}
					}
					else //es modificacion
					{
						mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView col = (mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView)chkColumnas.CheckedItems[0];
						mz.erp.businessrules.ConfiguracionStyleGrilla.MyGridEXFormatStyle mifs = (mz.erp.businessrules.ConfiguracionStyleGrilla.MyGridEXFormatStyle)propertyGrid1.SelectedObject;
						Janus.Windows.GridEX.GridEXFormatStyle fs = new Janus.Windows.GridEX.GridEXFormatStyle(mifs.ToFormatStyle());
						mz.erp.businessrules.ConfiguracionStyleGrilla.MyGridEXFormatStyle mifsCopy = new mz.erp.businessrules.ConfiguracionStyleGrilla.MyGridEXFormatStyle(fs);
						businessrules.ConfiguracionStyleGrilla.ConfiguracionGrillaEstilosCondicionalesDet cond = (businessrules.ConfiguracionStyleGrilla.ConfiguracionGrillaEstilosCondicionalesDet)gridConfiguraciones.SelectedItems[0].GetRow().DataRow;
						_uiController.ModifCondicionDeConfiguracion(cond, col, _uiController.Condicion, valor, mifsCopy);

					}
                   gridConfiguraciones.SelectionChanged+=new EventHandler(gridConfiguraciones_SelectionChanged);
				}
			}	
			panelABM.Enabled = false;			
			panelBotonesABMCondiciones.Visible = true;
			panelBotonesConfirmacionCondiciones.Visible = false;
		}

		private void btnCanelarCond_Click(object sender, System.EventArgs e)
		{
			panelABM.Enabled = false;		
			if(_estado.Equals("MODIF_COND"))
			{
				businessrules.ConfiguracionStyleGrilla.ConfiguracionGrillaEstilosCondicionalesDet cond = (businessrules.ConfiguracionStyleGrilla.ConfiguracionGrillaEstilosCondicionalesDet) gridConfiguraciones.GetRow().DataRow;
				cond.Estilo = _estiloAnterior;
				cond.EstilosAplicados = _estiloAnterior.Propiedades();
				cond.Estilos = _estiloAnterior.ToString();
				this._uiController_CondicionesHasChanged(sender, new EventArgs());
			}
			panelBotonesABMCondiciones.Visible = true;
			panelBotonesConfirmacionCondiciones.Visible = false;
		}

		private void btnModificarCondicion_Click(object sender, System.EventArgs e)
		{
			if(gridConfiguraciones.SelectedItems.Count > 0)
			{
				panelABM.Enabled = true;
				propertyGrid1.Refresh();
				_estado = "MODIF_COND";
				businessrules.ConfiguracionStyleGrilla.ConfiguracionGrillaEstilosCondicionalesDet cond = (businessrules.ConfiguracionStyleGrilla.ConfiguracionGrillaEstilosCondicionalesDet) gridConfiguraciones.GetRow().DataRow;
				Janus.Windows.GridEX.GridEXFormatStyle fs = new Janus.Windows.GridEX.GridEXFormatStyle(cond.Estilo.ToFormatStyle());
				_estiloAnterior = new mz.erp.businessrules.ConfiguracionStyleGrilla.MyGridEXFormatStyle(fs);
				panelBotonesABMCondiciones.Visible = false;
				panelBotonesConfirmacionCondiciones.Visible = true;
			}
		}


	}
}

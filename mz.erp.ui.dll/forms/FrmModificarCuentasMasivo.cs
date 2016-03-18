using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using mz.erp.commontypes;
using mz.erp.ui.controls;
using mz.erp.ui.forms.classes;
using mz.erp.ui.utility;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmModificarCuentasMasivo.
	/// </summary>
	public class FrmModificarCuentasMasivo : System.Windows.Forms.Form, ITaskForm
	{
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
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton rbPorJerarquia;
		private System.Windows.Forms.GroupBox groupPorProducto;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupPorJerarquia;
		private mz.erp.ui.controls.HierarchicalSearchControl hierarchicalSearchControl1;
		private System.Windows.Forms.GroupBox groupRB;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.RadioButton rbPorCuenta;
		private mz.erp.ui.controls.mzCuentasControl mzCmbCuenta;
		private System.Windows.Forms.Panel panel1;
		private Infragistics.Win.Misc.UltraButton bNingunoCaja;
		private Infragistics.Win.Misc.UltraButton bTodosCaja;
		private System.Windows.Forms.RadioButton rbSeleccionMultiple;
		private System.Windows.Forms.RadioButton rbSeleccionSimple;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneLimiteDeCredito;
		private System.Windows.Forms.Label label12;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarLimCredito;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneDiasLimiteDeCredito;
		private System.Windows.Forms.Label label16;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarDiasLimCredito;
		private System.Windows.Forms.RichTextBox rtbObservaciones;
		private System.Windows.Forms.Label label2;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarObservaciones;
		private System.Windows.Forms.GroupBox groupBoxTipoEdicionObservaciones;
		private System.Windows.Forms.RadioButton rbConcatenaObservaciones;
		private System.Windows.Forms.RadioButton rbReemplazaObserveciones;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkActivo;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarActivo;
		private System.Windows.Forms.TextBox txtCampoAuxiliar2;
		private System.Windows.Forms.Label labelCampoAuxiliar2;
		private System.Windows.Forms.TextBox txtCampoAuxiliar3;
		private System.Windows.Forms.Label labelCampoAuxiliar3;
		private System.Windows.Forms.TextBox txtCampoAuxiliar1;
		private System.Windows.Forms.Label labelCampoAuxiliar1;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarCAux3;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarCAux2;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarCAux1;
		private System.Windows.Forms.GroupBox groupBoxTipoEdicionCampoAuxiliar1;
		private System.Windows.Forms.RadioButton rbConcatenaCampoAuxiliar1;
		private System.Windows.Forms.RadioButton rbReemplazaCampoAuxiliar1;
		private System.Windows.Forms.GroupBox groupBoxTipoEdicionCampoAuxiliar2;
		private System.Windows.Forms.RadioButton rbConcatenaCampoAuxiliar2;
		private System.Windows.Forms.RadioButton rbReemplazaCampoAuxiliar2;
		private System.Windows.Forms.GroupBox groupBoxTipoEdicionCampoAuxiliar3;
		private System.Windows.Forms.RadioButton rbConcatenaCampoAuxiliar3;
		private System.Windows.Forms.RadioButton rbReemplazaCampoAuxiliar3;
		private mz.erp.ui.controls.mzComboEditor mzCEListaPrecios;
		private System.Windows.Forms.Label label5;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarListaDePreciosDefault;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private Janus.Windows.GridEX.GridEX gridCuentas;
		private System.ComponentModel.IContainer components;

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmModificarCuentasMasivo));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.containerProductos = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.rbPorJerarquia = new System.Windows.Forms.RadioButton();
			this.rbPorCuenta = new System.Windows.Forms.RadioButton();
			this.groupPorProducto = new System.Windows.Forms.GroupBox();
			this.gridCuentas = new Janus.Windows.GridEX.GridEX();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.bNingunoCaja = new Infragistics.Win.Misc.UltraButton();
			this.bTodosCaja = new Infragistics.Win.Misc.UltraButton();
			this.rbSeleccionMultiple = new System.Windows.Forms.RadioButton();
			this.rbSeleccionSimple = new System.Windows.Forms.RadioButton();
			this.mzCmbCuenta = new mz.erp.ui.controls.mzCuentasControl();
			this.label9 = new System.Windows.Forms.Label();
			this.groupPorJerarquia = new System.Windows.Forms.GroupBox();
			this.hierarchicalSearchControl1 = new mz.erp.ui.controls.HierarchicalSearchControl();
			this.groupRB = new System.Windows.Forms.GroupBox();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.chkHabilitarListaDePreciosDefault = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.mzCEListaPrecios = new mz.erp.ui.controls.mzComboEditor();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBoxTipoEdicionCampoAuxiliar2 = new System.Windows.Forms.GroupBox();
			this.rbConcatenaCampoAuxiliar2 = new System.Windows.Forms.RadioButton();
			this.rbReemplazaCampoAuxiliar2 = new System.Windows.Forms.RadioButton();
			this.groupBoxTipoEdicionCampoAuxiliar1 = new System.Windows.Forms.GroupBox();
			this.rbConcatenaCampoAuxiliar1 = new System.Windows.Forms.RadioButton();
			this.rbReemplazaCampoAuxiliar1 = new System.Windows.Forms.RadioButton();
			this.chkHabilitarCAux3 = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.chkHabilitarCAux2 = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.chkHabilitarCAux1 = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.txtCampoAuxiliar2 = new System.Windows.Forms.TextBox();
			this.labelCampoAuxiliar2 = new System.Windows.Forms.Label();
			this.txtCampoAuxiliar3 = new System.Windows.Forms.TextBox();
			this.labelCampoAuxiliar3 = new System.Windows.Forms.Label();
			this.txtCampoAuxiliar1 = new System.Windows.Forms.TextBox();
			this.labelCampoAuxiliar1 = new System.Windows.Forms.Label();
			this.chkHabilitarActivo = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.chkActivo = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.groupBoxTipoEdicionObservaciones = new System.Windows.Forms.GroupBox();
			this.rbConcatenaObservaciones = new System.Windows.Forms.RadioButton();
			this.rbReemplazaObserveciones = new System.Windows.Forms.RadioButton();
			this.rtbObservaciones = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.chkHabilitarObservaciones = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.chkHabilitarDiasLimCredito = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.uneDiasLimiteDeCredito = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label16 = new System.Windows.Forms.Label();
			this.chkHabilitarLimCredito = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.uneLimiteDeCredito = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBoxTipoEdicionCampoAuxiliar3 = new System.Windows.Forms.GroupBox();
			this.rbConcatenaCampoAuxiliar3 = new System.Windows.Forms.RadioButton();
			this.rbReemplazaCampoAuxiliar3 = new System.Windows.Forms.RadioButton();
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
			this.groupBox4.SuspendLayout();
			this.groupPorProducto.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridCuentas)).BeginInit();
			this.panel1.SuspendLayout();
			this.groupPorJerarquia.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCEListaPrecios)).BeginInit();
			this.groupBoxTipoEdicionCampoAuxiliar2.SuspendLayout();
			this.groupBoxTipoEdicionCampoAuxiliar1.SuspendLayout();
			this.groupBoxTipoEdicionObservaciones.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uneDiasLimiteDeCredito)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneLimiteDeCredito)).BeginInit();
			this.groupBoxTipoEdicionCampoAuxiliar3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar)).BeginInit();
			this.ultraExplorerBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(954, 31);
			this.ultraExplorerBarContainerControl2.TabIndex = 2;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(954, 23);
			this.labelTarea.TabIndex = 1;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// containerProductos
			// 
			this.containerProductos.Controls.Add(this.groupBox4);
			this.containerProductos.Controls.Add(this.groupPorProducto);
			this.containerProductos.Controls.Add(this.groupPorJerarquia);
			this.containerProductos.Controls.Add(this.groupRB);
			this.containerProductos.Location = new System.Drawing.Point(28, 114);
			this.containerProductos.Name = "containerProductos";
			this.containerProductos.Size = new System.Drawing.Size(954, 235);
			this.containerProductos.TabIndex = 3;
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Transparent;
			this.groupBox4.Controls.Add(this.rbPorJerarquia);
			this.groupBox4.Controls.Add(this.rbPorCuenta);
			this.groupBox4.Location = new System.Drawing.Point(0, 0);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(952, 32);
			this.groupBox4.TabIndex = 83;
			this.groupBox4.TabStop = false;
			// 
			// rbPorJerarquia
			// 
			this.rbPorJerarquia.Location = new System.Drawing.Point(193, 10);
			this.rbPorJerarquia.Name = "rbPorJerarquia";
			this.rbPorJerarquia.Size = new System.Drawing.Size(176, 20);
			this.rbPorJerarquia.TabIndex = 1;
			this.rbPorJerarquia.Text = "Por Jerarquías";
			// 
			// rbPorCuenta
			// 
			this.rbPorCuenta.Location = new System.Drawing.Point(8, 10);
			this.rbPorCuenta.Name = "rbPorCuenta";
			this.rbPorCuenta.Size = new System.Drawing.Size(176, 20);
			this.rbPorCuenta.TabIndex = 0;
			this.rbPorCuenta.Text = "Por Cuentas";
			// 
			// groupPorProducto
			// 
			this.groupPorProducto.BackColor = System.Drawing.Color.Transparent;
			this.groupPorProducto.Controls.Add(this.gridCuentas);
			this.groupPorProducto.Controls.Add(this.gridManagerView1);
			this.groupPorProducto.Controls.Add(this.panel1);
			this.groupPorProducto.Controls.Add(this.mzCmbCuenta);
			this.groupPorProducto.Controls.Add(this.label9);
			this.groupPorProducto.Location = new System.Drawing.Point(0, 32);
			this.groupPorProducto.Name = "groupPorProducto";
			this.groupPorProducto.Size = new System.Drawing.Size(952, 216);
			this.groupPorProducto.TabIndex = 81;
			this.groupPorProducto.TabStop = false;
			// 
			// gridCuentas
			// 
			this.gridCuentas.AllowCardSizing = false;
			this.gridCuentas.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridCuentas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridCuentas.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridCuentas.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridCuentas.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.gridCuentas.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridCuentas.Location = new System.Drawing.Point(16, 72);
			this.gridCuentas.Name = "gridCuentas";
			this.gridCuentas.Size = new System.Drawing.Size(920, 120);
			this.gridCuentas.TabIndex = 80;
			this.gridCuentas.TabStop = false;
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
			this.gridManagerView1.Location = new System.Drawing.Point(16, 88);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(392, 24);
			this.gridManagerView1.TabIndex = 79;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.bNingunoCaja);
			this.panel1.Controls.Add(this.bTodosCaja);
			this.panel1.Controls.Add(this.rbSeleccionMultiple);
			this.panel1.Controls.Add(this.rbSeleccionSimple);
			this.panel1.Location = new System.Drawing.Point(16, 48);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(920, 24);
			this.panel1.TabIndex = 78;
			// 
			// bNingunoCaja
			// 
			this.bNingunoCaja.AcceptsFocus = false;
			this.bNingunoCaja.Location = new System.Drawing.Point(392, 0);
			this.bNingunoCaja.Name = "bNingunoCaja";
			this.bNingunoCaja.Size = new System.Drawing.Size(64, 22);
			this.bNingunoCaja.TabIndex = 4;
			this.bNingunoCaja.TabStop = false;
			this.bNingunoCaja.Text = "&Ninguna";
			// 
			// bTodosCaja
			// 
			this.bTodosCaja.AcceptsFocus = false;
			this.bTodosCaja.Location = new System.Drawing.Point(328, 0);
			this.bTodosCaja.Name = "bTodosCaja";
			this.bTodosCaja.Size = new System.Drawing.Size(64, 22);
			this.bTodosCaja.TabIndex = 3;
			this.bTodosCaja.TabStop = false;
			this.bTodosCaja.Text = "&Todas";
			// 
			// rbSeleccionMultiple
			// 
			this.rbSeleccionMultiple.Location = new System.Drawing.Point(176, 0);
			this.rbSeleccionMultiple.Name = "rbSeleccionMultiple";
			this.rbSeleccionMultiple.Size = new System.Drawing.Size(152, 24);
			this.rbSeleccionMultiple.TabIndex = 2;
			this.rbSeleccionMultiple.Text = "Selección Múltiple";
			// 
			// rbSeleccionSimple
			// 
			this.rbSeleccionSimple.Location = new System.Drawing.Point(8, 0);
			this.rbSeleccionSimple.Name = "rbSeleccionSimple";
			this.rbSeleccionSimple.Size = new System.Drawing.Size(168, 24);
			this.rbSeleccionSimple.TabIndex = 1;
			this.rbSeleccionSimple.Text = "Selección Individual";
			// 
			// mzCmbCuenta
			// 
			this.mzCmbCuenta.AllowEditClientePaso = false;
			this.mzCmbCuenta.BackColor = System.Drawing.SystemColors.Control;
			this.mzCmbCuenta.DataValue = "";
			this.mzCmbCuenta.EnableCtaCte = false;
			this.mzCmbCuenta.FastSearch = false;
			this.mzCmbCuenta.Location = new System.Drawing.Point(96, 16);
			this.mzCmbCuenta.Name = "mzCmbCuenta";
			this.mzCmbCuenta.ReseteaCodCta = false;
			this.mzCmbCuenta.SearchObjectListener = null;
			this.mzCmbCuenta.Size = new System.Drawing.Size(440, 24);
			this.mzCmbCuenta.TabIndex = 76;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(9, 13);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(69, 16);
			this.label9.TabIndex = 75;
			this.label9.Text = "Cuenta";
			// 
			// groupPorJerarquia
			// 
			this.groupPorJerarquia.BackColor = System.Drawing.Color.Transparent;
			this.groupPorJerarquia.Controls.Add(this.hierarchicalSearchControl1);
			this.groupPorJerarquia.Location = new System.Drawing.Point(0, 24);
			this.groupPorJerarquia.Name = "groupPorJerarquia";
			this.groupPorJerarquia.Size = new System.Drawing.Size(960, 208);
			this.groupPorJerarquia.TabIndex = 82;
			this.groupPorJerarquia.TabStop = false;
			// 
			// hierarchicalSearchControl1
			// 
			this.hierarchicalSearchControl1.BackColor = System.Drawing.Color.Transparent;
			this.hierarchicalSearchControl1.Location = new System.Drawing.Point(8, 8);
			this.hierarchicalSearchControl1.Name = "hierarchicalSearchControl1";
			this.hierarchicalSearchControl1.Size = new System.Drawing.Size(840, 144);
			this.hierarchicalSearchControl1.TabIndex = 55;
			// 
			// groupRB
			// 
			this.groupRB.BackColor = System.Drawing.Color.Transparent;
			this.groupRB.Location = new System.Drawing.Point(-17, -43);
			this.groupRB.Name = "groupRB";
			this.groupRB.Size = new System.Drawing.Size(920, 43);
			this.groupRB.TabIndex = 80;
			this.groupRB.TabStop = false;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkHabilitarListaDePreciosDefault);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEListaPrecios);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label5);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.groupBoxTipoEdicionCampoAuxiliar2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.groupBoxTipoEdicionCampoAuxiliar1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkHabilitarCAux3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkHabilitarCAux2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkHabilitarCAux1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtCampoAuxiliar2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.labelCampoAuxiliar2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtCampoAuxiliar3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.labelCampoAuxiliar3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtCampoAuxiliar1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.labelCampoAuxiliar1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkHabilitarActivo);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkActivo);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.groupBoxTipoEdicionObservaciones);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.rtbObservaciones);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkHabilitarObservaciones);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkHabilitarDiasLimCredito);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uneDiasLimiteDeCredito);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label16);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkHabilitarLimCredito);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uneLimiteDeCredito);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label12);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.groupBoxTipoEdicionCampoAuxiliar3);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 408);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(954, 301);
			this.ultraExplorerBarContainerControl1.TabIndex = 5;
			// 
			// chkHabilitarListaDePreciosDefault
			// 
			this.chkHabilitarListaDePreciosDefault.BackColor = System.Drawing.Color.Transparent;
			this.chkHabilitarListaDePreciosDefault.Enabled = false;
			this.chkHabilitarListaDePreciosDefault.Location = new System.Drawing.Point(656, 8);
			this.chkHabilitarListaDePreciosDefault.Name = "chkHabilitarListaDePreciosDefault";
			this.chkHabilitarListaDePreciosDefault.Size = new System.Drawing.Size(160, 20);
			this.chkHabilitarListaDePreciosDefault.TabIndex = 116;
			this.chkHabilitarListaDePreciosDefault.Text = "Habilitar su modificación";
			// 
			// mzCEListaPrecios
			// 
			this.mzCEListaPrecios.AutoComplete = true;
			this.mzCEListaPrecios.DataSource = null;
			this.mzCEListaPrecios.DisplayMember = "";
			this.mzCEListaPrecios.DisplayMemberCaption = "";
			this.mzCEListaPrecios.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEListaPrecios.Enabled = false;
			this.mzCEListaPrecios.ImageTransparentColor = System.Drawing.Color.Violet;
			this.mzCEListaPrecios.Location = new System.Drawing.Point(504, 8);
			this.mzCEListaPrecios.MaxItemsDisplay = 7;
			this.mzCEListaPrecios.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEListaPrecios.Name = "mzCEListaPrecios";
			this.mzCEListaPrecios.Size = new System.Drawing.Size(136, 21);
			this.mzCEListaPrecios.SorterMember = "";
			this.mzCEListaPrecios.TabIndex = 115;
			this.mzCEListaPrecios.ValueMember = "";
			this.mzCEListaPrecios.ValueMemberCaption = "";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(400, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 24);
			this.label5.TabIndex = 114;
			this.label5.Text = "Lista de Precios";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBoxTipoEdicionCampoAuxiliar2
			// 
			this.groupBoxTipoEdicionCampoAuxiliar2.Controls.Add(this.rbConcatenaCampoAuxiliar2);
			this.groupBoxTipoEdicionCampoAuxiliar2.Controls.Add(this.rbReemplazaCampoAuxiliar2);
			this.groupBoxTipoEdicionCampoAuxiliar2.Enabled = false;
			this.groupBoxTipoEdicionCampoAuxiliar2.Location = new System.Drawing.Point(96, 192);
			this.groupBoxTipoEdicionCampoAuxiliar2.Name = "groupBoxTipoEdicionCampoAuxiliar2";
			this.groupBoxTipoEdicionCampoAuxiliar2.Size = new System.Drawing.Size(184, 32);
			this.groupBoxTipoEdicionCampoAuxiliar2.TabIndex = 113;
			this.groupBoxTipoEdicionCampoAuxiliar2.TabStop = false;
			// 
			// rbConcatenaCampoAuxiliar2
			// 
			this.rbConcatenaCampoAuxiliar2.Location = new System.Drawing.Point(8, 8);
			this.rbConcatenaCampoAuxiliar2.Name = "rbConcatenaCampoAuxiliar2";
			this.rbConcatenaCampoAuxiliar2.Size = new System.Drawing.Size(80, 16);
			this.rbConcatenaCampoAuxiliar2.TabIndex = 0;
			this.rbConcatenaCampoAuxiliar2.Text = "Concatena";
			// 
			// rbReemplazaCampoAuxiliar2
			// 
			this.rbReemplazaCampoAuxiliar2.Location = new System.Drawing.Point(96, 8);
			this.rbReemplazaCampoAuxiliar2.Name = "rbReemplazaCampoAuxiliar2";
			this.rbReemplazaCampoAuxiliar2.Size = new System.Drawing.Size(80, 16);
			this.rbReemplazaCampoAuxiliar2.TabIndex = 101;
			this.rbReemplazaCampoAuxiliar2.Text = "Reemplaza";
			// 
			// groupBoxTipoEdicionCampoAuxiliar1
			// 
			this.groupBoxTipoEdicionCampoAuxiliar1.Controls.Add(this.rbConcatenaCampoAuxiliar1);
			this.groupBoxTipoEdicionCampoAuxiliar1.Controls.Add(this.rbReemplazaCampoAuxiliar1);
			this.groupBoxTipoEdicionCampoAuxiliar1.Enabled = false;
			this.groupBoxTipoEdicionCampoAuxiliar1.Location = new System.Drawing.Point(96, 144);
			this.groupBoxTipoEdicionCampoAuxiliar1.Name = "groupBoxTipoEdicionCampoAuxiliar1";
			this.groupBoxTipoEdicionCampoAuxiliar1.Size = new System.Drawing.Size(184, 32);
			this.groupBoxTipoEdicionCampoAuxiliar1.TabIndex = 112;
			this.groupBoxTipoEdicionCampoAuxiliar1.TabStop = false;
			// 
			// rbConcatenaCampoAuxiliar1
			// 
			this.rbConcatenaCampoAuxiliar1.Location = new System.Drawing.Point(8, 8);
			this.rbConcatenaCampoAuxiliar1.Name = "rbConcatenaCampoAuxiliar1";
			this.rbConcatenaCampoAuxiliar1.Size = new System.Drawing.Size(80, 16);
			this.rbConcatenaCampoAuxiliar1.TabIndex = 0;
			this.rbConcatenaCampoAuxiliar1.Text = "Concatena";
			// 
			// rbReemplazaCampoAuxiliar1
			// 
			this.rbReemplazaCampoAuxiliar1.Location = new System.Drawing.Point(96, 8);
			this.rbReemplazaCampoAuxiliar1.Name = "rbReemplazaCampoAuxiliar1";
			this.rbReemplazaCampoAuxiliar1.Size = new System.Drawing.Size(80, 16);
			this.rbReemplazaCampoAuxiliar1.TabIndex = 101;
			this.rbReemplazaCampoAuxiliar1.Text = "Reemplaza";
			// 
			// chkHabilitarCAux3
			// 
			this.chkHabilitarCAux3.BackColor = System.Drawing.Color.Transparent;
			this.chkHabilitarCAux3.Enabled = false;
			this.chkHabilitarCAux3.Location = new System.Drawing.Point(784, 272);
			this.chkHabilitarCAux3.Name = "chkHabilitarCAux3";
			this.chkHabilitarCAux3.Size = new System.Drawing.Size(160, 20);
			this.chkHabilitarCAux3.TabIndex = 111;
			this.chkHabilitarCAux3.Text = "Habilitar su modificación";
			// 
			// chkHabilitarCAux2
			// 
			this.chkHabilitarCAux2.BackColor = System.Drawing.Color.Transparent;
			this.chkHabilitarCAux2.Enabled = false;
			this.chkHabilitarCAux2.Location = new System.Drawing.Point(784, 224);
			this.chkHabilitarCAux2.Name = "chkHabilitarCAux2";
			this.chkHabilitarCAux2.Size = new System.Drawing.Size(160, 20);
			this.chkHabilitarCAux2.TabIndex = 110;
			this.chkHabilitarCAux2.Text = "Habilitar su modificación";
			// 
			// chkHabilitarCAux1
			// 
			this.chkHabilitarCAux1.BackColor = System.Drawing.Color.Transparent;
			this.chkHabilitarCAux1.Enabled = false;
			this.chkHabilitarCAux1.Location = new System.Drawing.Point(784, 176);
			this.chkHabilitarCAux1.Name = "chkHabilitarCAux1";
			this.chkHabilitarCAux1.Size = new System.Drawing.Size(160, 20);
			this.chkHabilitarCAux1.TabIndex = 109;
			this.chkHabilitarCAux1.Text = "Habilitar su modificación";
			// 
			// txtCampoAuxiliar2
			// 
			this.txtCampoAuxiliar2.Enabled = false;
			this.txtCampoAuxiliar2.Location = new System.Drawing.Point(96, 224);
			this.txtCampoAuxiliar2.Name = "txtCampoAuxiliar2";
			this.txtCampoAuxiliar2.Size = new System.Drawing.Size(672, 20);
			this.txtCampoAuxiliar2.TabIndex = 105;
			this.txtCampoAuxiliar2.Text = "";
			// 
			// labelCampoAuxiliar2
			// 
			this.labelCampoAuxiliar2.BackColor = System.Drawing.Color.Transparent;
			this.labelCampoAuxiliar2.Location = new System.Drawing.Point(8, 200);
			this.labelCampoAuxiliar2.Name = "labelCampoAuxiliar2";
			this.labelCampoAuxiliar2.Size = new System.Drawing.Size(88, 20);
			this.labelCampoAuxiliar2.TabIndex = 108;
			this.labelCampoAuxiliar2.Text = "CampoAuxiliar2";
			// 
			// txtCampoAuxiliar3
			// 
			this.txtCampoAuxiliar3.Enabled = false;
			this.txtCampoAuxiliar3.Location = new System.Drawing.Point(96, 272);
			this.txtCampoAuxiliar3.Name = "txtCampoAuxiliar3";
			this.txtCampoAuxiliar3.Size = new System.Drawing.Size(672, 20);
			this.txtCampoAuxiliar3.TabIndex = 106;
			this.txtCampoAuxiliar3.Text = "";
			// 
			// labelCampoAuxiliar3
			// 
			this.labelCampoAuxiliar3.BackColor = System.Drawing.Color.Transparent;
			this.labelCampoAuxiliar3.Location = new System.Drawing.Point(8, 248);
			this.labelCampoAuxiliar3.Name = "labelCampoAuxiliar3";
			this.labelCampoAuxiliar3.Size = new System.Drawing.Size(88, 20);
			this.labelCampoAuxiliar3.TabIndex = 107;
			this.labelCampoAuxiliar3.Text = "CampoAuxiliar3";
			// 
			// txtCampoAuxiliar1
			// 
			this.txtCampoAuxiliar1.Enabled = false;
			this.txtCampoAuxiliar1.Location = new System.Drawing.Point(96, 176);
			this.txtCampoAuxiliar1.Name = "txtCampoAuxiliar1";
			this.txtCampoAuxiliar1.Size = new System.Drawing.Size(672, 20);
			this.txtCampoAuxiliar1.TabIndex = 103;
			this.txtCampoAuxiliar1.Text = "";
			// 
			// labelCampoAuxiliar1
			// 
			this.labelCampoAuxiliar1.BackColor = System.Drawing.Color.Transparent;
			this.labelCampoAuxiliar1.Location = new System.Drawing.Point(8, 152);
			this.labelCampoAuxiliar1.Name = "labelCampoAuxiliar1";
			this.labelCampoAuxiliar1.Size = new System.Drawing.Size(88, 20);
			this.labelCampoAuxiliar1.TabIndex = 104;
			this.labelCampoAuxiliar1.Text = "CampoAuxiliar1";
			// 
			// chkHabilitarActivo
			// 
			this.chkHabilitarActivo.BackColor = System.Drawing.Color.Transparent;
			this.chkHabilitarActivo.Enabled = false;
			this.chkHabilitarActivo.Location = new System.Drawing.Point(656, 40);
			this.chkHabilitarActivo.Name = "chkHabilitarActivo";
			this.chkHabilitarActivo.Size = new System.Drawing.Size(160, 20);
			this.chkHabilitarActivo.TabIndex = 102;
			this.chkHabilitarActivo.Text = "Habilitar su modificación";
			// 
			// chkActivo
			// 
			this.chkActivo.BackColor = System.Drawing.Color.Transparent;
			this.chkActivo.Checked = true;
			this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkActivo.Enabled = false;
			this.chkActivo.Location = new System.Drawing.Point(576, 40);
			this.chkActivo.Name = "chkActivo";
			this.chkActivo.Size = new System.Drawing.Size(56, 24);
			this.chkActivo.TabIndex = 101;
			this.chkActivo.Text = "Activo";
			// 
			// groupBoxTipoEdicionObservaciones
			// 
			this.groupBoxTipoEdicionObservaciones.Controls.Add(this.rbConcatenaObservaciones);
			this.groupBoxTipoEdicionObservaciones.Controls.Add(this.rbReemplazaObserveciones);
			this.groupBoxTipoEdicionObservaciones.Enabled = false;
			this.groupBoxTipoEdicionObservaciones.Location = new System.Drawing.Point(96, 72);
			this.groupBoxTipoEdicionObservaciones.Name = "groupBoxTipoEdicionObservaciones";
			this.groupBoxTipoEdicionObservaciones.Size = new System.Drawing.Size(184, 32);
			this.groupBoxTipoEdicionObservaciones.TabIndex = 100;
			this.groupBoxTipoEdicionObservaciones.TabStop = false;
			// 
			// rbConcatenaObservaciones
			// 
			this.rbConcatenaObservaciones.Location = new System.Drawing.Point(8, 8);
			this.rbConcatenaObservaciones.Name = "rbConcatenaObservaciones";
			this.rbConcatenaObservaciones.Size = new System.Drawing.Size(80, 16);
			this.rbConcatenaObservaciones.TabIndex = 0;
			this.rbConcatenaObservaciones.Text = "Concatena";
			// 
			// rbReemplazaObserveciones
			// 
			this.rbReemplazaObserveciones.Location = new System.Drawing.Point(96, 8);
			this.rbReemplazaObserveciones.Name = "rbReemplazaObserveciones";
			this.rbReemplazaObserveciones.Size = new System.Drawing.Size(80, 16);
			this.rbReemplazaObserveciones.TabIndex = 101;
			this.rbReemplazaObserveciones.Text = "Reemplaza";
			// 
			// rtbObservaciones
			// 
			this.rtbObservaciones.Enabled = false;
			this.rtbObservaciones.Location = new System.Drawing.Point(96, 104);
			this.rtbObservaciones.Name = "rtbObservaciones";
			this.rtbObservaciones.Size = new System.Drawing.Size(672, 40);
			this.rtbObservaciones.TabIndex = 99;
			this.rtbObservaciones.Text = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(8, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 16);
			this.label2.TabIndex = 98;
			this.label2.Text = "Observaciones";
			// 
			// chkHabilitarObservaciones
			// 
			this.chkHabilitarObservaciones.BackColor = System.Drawing.Color.Transparent;
			this.chkHabilitarObservaciones.Enabled = false;
			this.chkHabilitarObservaciones.Location = new System.Drawing.Point(784, 104);
			this.chkHabilitarObservaciones.Name = "chkHabilitarObservaciones";
			this.chkHabilitarObservaciones.Size = new System.Drawing.Size(160, 20);
			this.chkHabilitarObservaciones.TabIndex = 97;
			this.chkHabilitarObservaciones.Text = "Habilitar su modificación";
			// 
			// chkHabilitarDiasLimCredito
			// 
			this.chkHabilitarDiasLimCredito.BackColor = System.Drawing.Color.Transparent;
			this.chkHabilitarDiasLimCredito.Enabled = false;
			this.chkHabilitarDiasLimCredito.Location = new System.Drawing.Point(208, 40);
			this.chkHabilitarDiasLimCredito.Name = "chkHabilitarDiasLimCredito";
			this.chkHabilitarDiasLimCredito.Size = new System.Drawing.Size(160, 20);
			this.chkHabilitarDiasLimCredito.TabIndex = 96;
			this.chkHabilitarDiasLimCredito.Text = "Habilitar su modificación";
			// 
			// uneDiasLimiteDeCredito
			// 
			this.uneDiasLimiteDeCredito.Enabled = false;
			this.uneDiasLimiteDeCredito.Location = new System.Drawing.Point(96, 40);
			this.uneDiasLimiteDeCredito.MaskInput = "nnnn";
			this.uneDiasLimiteDeCredito.MaxValue = 9999;
			this.uneDiasLimiteDeCredito.MinValue = 0;
			this.uneDiasLimiteDeCredito.Name = "uneDiasLimiteDeCredito";
			this.uneDiasLimiteDeCredito.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneDiasLimiteDeCredito.Size = new System.Drawing.Size(88, 21);
			this.uneDiasLimiteDeCredito.TabIndex = 94;
			this.uneDiasLimiteDeCredito.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Location = new System.Drawing.Point(8, 48);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(100, 16);
			this.label16.TabIndex = 95;
			this.label16.Text = "Dias Lim. Cred.";
			// 
			// chkHabilitarLimCredito
			// 
			this.chkHabilitarLimCredito.BackColor = System.Drawing.Color.Transparent;
			this.chkHabilitarLimCredito.Enabled = false;
			this.chkHabilitarLimCredito.Location = new System.Drawing.Point(208, 8);
			this.chkHabilitarLimCredito.Name = "chkHabilitarLimCredito";
			this.chkHabilitarLimCredito.Size = new System.Drawing.Size(160, 20);
			this.chkHabilitarLimCredito.TabIndex = 91;
			this.chkHabilitarLimCredito.Text = "Habilitar su modificación";
			// 
			// uneLimiteDeCredito
			// 
			this.uneLimiteDeCredito.Enabled = false;
			this.uneLimiteDeCredito.Location = new System.Drawing.Point(96, 8);
			this.uneLimiteDeCredito.Name = "uneLimiteDeCredito";
			this.uneLimiteDeCredito.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneLimiteDeCredito.Size = new System.Drawing.Size(88, 21);
			this.uneLimiteDeCredito.TabIndex = 89;
			this.uneLimiteDeCredito.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Location = new System.Drawing.Point(8, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(79, 22);
			this.label12.TabIndex = 90;
			this.label12.Text = "Lím. de crédito";
			// 
			// groupBoxTipoEdicionCampoAuxiliar3
			// 
			this.groupBoxTipoEdicionCampoAuxiliar3.Controls.Add(this.rbConcatenaCampoAuxiliar3);
			this.groupBoxTipoEdicionCampoAuxiliar3.Controls.Add(this.rbReemplazaCampoAuxiliar3);
			this.groupBoxTipoEdicionCampoAuxiliar3.Enabled = false;
			this.groupBoxTipoEdicionCampoAuxiliar3.Location = new System.Drawing.Point(96, 240);
			this.groupBoxTipoEdicionCampoAuxiliar3.Name = "groupBoxTipoEdicionCampoAuxiliar3";
			this.groupBoxTipoEdicionCampoAuxiliar3.Size = new System.Drawing.Size(184, 32);
			this.groupBoxTipoEdicionCampoAuxiliar3.TabIndex = 113;
			this.groupBoxTipoEdicionCampoAuxiliar3.TabStop = false;
			// 
			// rbConcatenaCampoAuxiliar3
			// 
			this.rbConcatenaCampoAuxiliar3.Location = new System.Drawing.Point(8, 8);
			this.rbConcatenaCampoAuxiliar3.Name = "rbConcatenaCampoAuxiliar3";
			this.rbConcatenaCampoAuxiliar3.Size = new System.Drawing.Size(80, 16);
			this.rbConcatenaCampoAuxiliar3.TabIndex = 0;
			this.rbConcatenaCampoAuxiliar3.Text = "Concatena";
			// 
			// rbReemplazaCampoAuxiliar3
			// 
			this.rbReemplazaCampoAuxiliar3.Location = new System.Drawing.Point(96, 8);
			this.rbReemplazaCampoAuxiliar3.Name = "rbReemplazaCampoAuxiliar3";
			this.rbReemplazaCampoAuxiliar3.Size = new System.Drawing.Size(80, 16);
			this.rbReemplazaCampoAuxiliar3.TabIndex = 101;
			this.rbReemplazaCampoAuxiliar3.Text = "Reemplaza";
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
			this.toolBarStandar.Size = new System.Drawing.Size(1020, 28);
			this.toolBarStandar.TabIndex = 25;
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
			ultraExplorerBarGroup1.Settings.ContainerHeight = 31;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.containerProductos;
			ultraExplorerBarGroup2.Key = "Cuenta";
			ultraExplorerBarGroup2.Settings.ContainerHeight = 235;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Cuenta";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup3.Key = "Informacion";
			ultraExplorerBarGroup3.Settings.ContainerHeight = 301;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Información";
			this.ultraExplorerBar.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																													   ultraExplorerBarGroup1,
																													   ultraExplorerBarGroup2,
																													   ultraExplorerBarGroup3});
			this.ultraExplorerBar.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar.Name = "ultraExplorerBar"; this.ultraExplorerBar.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar.Size = new System.Drawing.Size(1020, 584);
			this.ultraExplorerBar.TabIndex = 26;
			this.ultraExplorerBar.TabStop = false;
			// 
			// FrmModificarCuentasMasivo
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 612);
			this.Controls.Add(this.ultraExplorerBar);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmModificarCuentasMasivo";
			this.Text = "FrmModificarCuentasMasivo";
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			this.containerProductos.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupPorProducto.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridCuentas)).EndInit();
			this.panel1.ResumeLayout(false);
			this.groupPorJerarquia.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCEListaPrecios)).EndInit();
			this.groupBoxTipoEdicionCampoAuxiliar2.ResumeLayout(false);
			this.groupBoxTipoEdicionCampoAuxiliar1.ResumeLayout(false);
			this.groupBoxTipoEdicionObservaciones.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uneDiasLimiteDeCredito)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneLimiteDeCredito)).EndInit();
			this.groupBoxTipoEdicionCampoAuxiliar3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar)).EndInit();
			this.ultraExplorerBar.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Construtores y Destructores
		public FrmModificarCuentasMasivo(ModificarCuentasMasivoController uiController)
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

		#region Variables Privadas

		private ModificarCuentasMasivoController _uiController;

		#endregion

		#region Metodos Privados

		protected void Build_UI()
		{
			ConfigureInterface();	
			InitializeData();
			InitEventHandlers();
			InitDataBindings();	
		}

		
		private void ConfigureInterface()
		{
			this.Text = _uiController.LeyendaFormulario;
			labelTarea.Text = _uiController.LeyendaFormulario;
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();

			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;

			labelCampoAuxiliar1.Text = _uiController.EtiquetaCampoAuxiliar1;
			labelCampoAuxiliar2.Text = _uiController.EtiquetaCampoAuxiliar2;
			labelCampoAuxiliar3.Text = _uiController.EtiquetaCampoAuxiliar3;

			mzCmbCuenta.Init(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName());
			mzCmbCuenta.AddObjectListener( (IObserver) _uiController );
			mzCmbCuenta.ReseteaCodCta = true;
			mzCmbCuenta.AllowMultipleSelect = true;

			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), this.Name, gridCuentas, this.Text);
			gridCuentas.SelectionMode = Janus.Windows.GridEX.SelectionMode.SingleSelection;

			if(_uiController.AllowRemoveItems)
				gridCuentas.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			else gridCuentas.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;

			if(_uiController.AllowSeleccionMultiple)
			{
				if(!_uiController.SeleccionMultiple)
				{
					gridCuentas.RootTable.Columns["Selected"].Visible = false;
				}
			}

			rbSeleccionSimple.Checked = !_uiController.SeleccionMultiple;
			rbSeleccionMultiple.Checked = _uiController.SeleccionMultiple;
			bTodosCaja.Enabled = _uiController.SeleccionMultiple;
			bNingunoCaja.Enabled = _uiController.SeleccionMultiple;

			this.hierarchicalSearchControl1.Build_UI("CUENTAS",true);	
			rbPorCuenta.Checked = true;
			groupPorProducto.Visible = true;
			groupPorJerarquia.Visible = false;

		}

		private void InitializeData()
		{						
			mzCEListaPrecios.FillFromDataSource( businessrules.tsh_ListasDePrecios.GetList().tsh_ListasDePrecios, "IdListaDePrecio", "Descripcion", 100, "1", "2", "Descripcion");
		}
	
		private void InitEventHandlers()
		{			
			toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			_uiController.ObjectHasChanged +=new EventHandler(RefreshControls);
			_uiController.CuentasCollectionChanged +=	new EventHandler(Refresh);
			gridCuentas.SelectionChanged +=new EventHandler(gridCuentas_SelectionChanged);
			gridCuentas.EditingCell+=new Janus.Windows.GridEX.EditingCellEventHandler(gridCuentas_EditingCell);
			rbSeleccionSimple.CheckedChanged +=new EventHandler(rbSeleccionMultiple_CheckedChanged);
			rbSeleccionMultiple.CheckedChanged +=new EventHandler(rbSeleccionMultiple_CheckedChanged);
			bTodosCaja.Click +=new EventHandler(bTodosCaja_Click);
			bNingunoCaja.Click +=new EventHandler(bNingunoCaja_Click);
			chkHabilitarLimCredito.CheckedChanged+=new EventHandler(chkHabilitarLimCredito_CheckedChanged);
			chkHabilitarDiasLimCredito.CheckedChanged+=new EventHandler(chkHabilitarDiasLimCredito_CheckedChanged);
			chkHabilitarObservaciones.CheckedChanged+=new EventHandler(chkHabilitarObservaciones_CheckedChanged);
			chkHabilitarCAux1.CheckedChanged+=new EventHandler(chkHabilitarCAux1_CheckedChanged);
			chkHabilitarCAux2.CheckedChanged+=new EventHandler(chkHabilitarCAux2_CheckedChanged);
			chkHabilitarCAux3.CheckedChanged+=new EventHandler(chkHabilitarCAux3_CheckedChanged);
			chkHabilitarListaDePreciosDefault.CheckedChanged+=new EventHandler(chkHabilitarListaDePreciosDefault_CheckedChanged);
			chkHabilitarActivo.CheckedChanged+=new EventHandler(chkHabilitarActivo_CheckedChanged);

			rbPorCuenta.CheckedChanged +=new EventHandler(rbPorCuenta_CheckedChanged);
			rbPorJerarquia.CheckedChanged +=new EventHandler(rbPorJerarquia_CheckedChanged);
			hierarchicalSearchControl1.OnSelected +=new EventHandler(hierarchicalSearchControl1_OnSelected);

			mzCmbCuenta.MultipleSelectedItemsChanged +=new EventHandler(mzCmbCuenta_MultipleSelectedItemsChanged);		
		}

		private void InitDataBindings()
		{				
			gridCuentas.SetDataBinding(null, null);
			gridCuentas.SetDataBinding(_uiController.Items, null);

			rbReemplazaObserveciones.DataBindings.Clear();
			rbReemplazaCampoAuxiliar1.DataBindings.Clear();
			rbReemplazaCampoAuxiliar2.DataBindings.Clear();
			rbReemplazaCampoAuxiliar3.DataBindings.Clear();
			uneLimiteDeCredito.DataBindings.Clear();
			uneDiasLimiteDeCredito.DataBindings.Clear();
			rtbObservaciones.DataBindings.Clear();
			txtCampoAuxiliar1.DataBindings.Clear();
			txtCampoAuxiliar2.DataBindings.Clear();
			txtCampoAuxiliar3.DataBindings.Clear();
			mzCEListaPrecios.DataBindings.Clear();
			chkActivo.DataBindings.Clear();

			rbReemplazaObserveciones.DataBindings.Add("Checked", _uiController, "ReemplazaObservaciones");
			rbConcatenaObservaciones.Checked = !_uiController.ReemplazaObservaciones;
			rbReemplazaCampoAuxiliar1.DataBindings.Add("Checked", _uiController, "ReemplazaCampoAuxiliar1");
			rbConcatenaCampoAuxiliar1.Checked = !_uiController.ReemplazaCampoAuxiliar1;
			rbReemplazaCampoAuxiliar2.DataBindings.Add("Checked", _uiController, "ReemplazaCampoAuxiliar2");
			rbConcatenaCampoAuxiliar2.Checked = !_uiController.ReemplazaCampoAuxiliar2;
			rbReemplazaCampoAuxiliar3.DataBindings.Add("Checked", _uiController, "ReemplazaCampoAuxiliar3");
			rbConcatenaCampoAuxiliar3.Checked = !_uiController.ReemplazaCampoAuxiliar3;

			uneLimiteDeCredito.DataBindings.Add("Value", _uiController, "LimiteDeCredito");
			uneDiasLimiteDeCredito.DataBindings.Add("Value", _uiController, "DiasLimiteDeCredito");
			rtbObservaciones.DataBindings.Add("Text", _uiController, "Observaciones");
			txtCampoAuxiliar1.DataBindings.Add("Text", _uiController, "CampoAuxiliar1");
			txtCampoAuxiliar2.DataBindings.Add("Text", _uiController, "CampoAuxiliar2");
			txtCampoAuxiliar3.DataBindings.Add("Text", _uiController, "CampoAuxiliar3");
			mzCEListaPrecios.DataBindings.Add("Value", _uiController, "IdListaDePreciosDefault");
			chkActivo.DataBindings.Add("Checked", _uiController, "Activo");

		}

		private void Cancelar()
		{					
			this.CloseForm();
		}

		
		private void habilitarModificaciones()
		{
            //German 20100903 - Tarea 824
            //bool hayCuentas = gridCuentas.SelectedItems.Count > 0;
            bool hayCuentas = (rbPorJerarquia.Checked && gridCuentas.SelectedItems.Count > 0) ||  (rbPorJerarquia.Checked) ;
            //German 20100903 - Tarea 824
			chkHabilitarLimCredito.Enabled = hayCuentas && _uiController.AllowEditLimiteDeCredito;
			chkHabilitarDiasLimCredito.Enabled = hayCuentas && _uiController.AllowEditDiasLimiteDeCredito;
			chkHabilitarObservaciones.Enabled = hayCuentas && _uiController.AllowEditObservaciones;
			chkHabilitarCAux1.Enabled = hayCuentas && _uiController.AllowEditCampoAuxiliar1;
			chkHabilitarCAux2.Enabled = hayCuentas && _uiController.AllowEditCampoAuxiliar2;
			chkHabilitarCAux3.Enabled = hayCuentas && _uiController.AllowEditCampoAuxiliar3;
			chkHabilitarListaDePreciosDefault.Enabled = hayCuentas && _uiController.AllowEditListaDePrecios;
			chkHabilitarActivo.Enabled = hayCuentas && _uiController.AllowEditActivo;

		}

		#endregion

		#region Miembros de ITaskForm

		public void Execute()
		{
			this.Cursor = Cursors.WaitCursor;
			Util.MoveFocus(this.ultraExplorerBarContainerControl1);
			
			_uiController.Execute();
			this.Cursor = Cursors.Default;
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
			this.Execute();
		}

		#endregion

		#region Manejadores de Eventos

		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					_uiController.Previous();
					break;
				case 2://Guardar					
					this.Execute();
					break;
				case 4://Cancelar
					this.Cancelar();
					break;

			}						
		}

		private void Refresh(object sender, EventArgs e)
		{
			try
			{
				gridCuentas.SetDataBinding(null, null);
				gridCuentas.SetDataBinding(_uiController.Items, null);
				gridCuentas.UpdateData();
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
	
		}

		private void RefreshControls(object sender, EventArgs e)
		{
			uneLimiteDeCredito.Value = _uiController.LimiteDeCredito;
			uneDiasLimiteDeCredito.Value = _uiController.DiasLimiteDeCredito;
			rtbObservaciones.Text = _uiController.Observaciones;
			txtCampoAuxiliar1.Text = _uiController.CampoAuxiliar1;
			txtCampoAuxiliar2.Text = _uiController.CampoAuxiliar2;
			txtCampoAuxiliar3.Text = _uiController.CampoAuxiliar3;
			mzCEListaPrecios.Value = _uiController.IdListaDePreciosDefault;
			chkActivo.Checked = _uiController.Activo;

		}

		
		private void gridCuentas_SelectionChanged(object sender, EventArgs e)
		{
			habilitarModificaciones();
			if(!_uiController.SeleccionMultiple)
			{
				if(gridCuentas.SelectedItems.Count > 0)
				{
					object selectedItem = gridCuentas.SelectedItems[0].GetRow().DataRow;
					_uiController.SelectedItem = selectedItem;
				}
			}
		}

		private void gridCuentas_EditingCell(object sender, Janus.Windows.GridEX.EditingCellEventArgs e)
		{
			if(e.Value == null || e.Value == System.DBNull.Value)
				e.Cancel = true;
			else
			{
				object selectedItem = 	gridCuentas.SelectedItems[0].GetRow().DataRow;
				int col = gridCuentas.Col;
				if (col != -1)
				{
					string column = gridCuentas.RootTable.Columns[col].Key;
					if (!column.Equals("Selected")) 
					{
						e.Cancel = true;
					}
				}
				else
					e.Cancel = true;
			}

		}

		private void rbSeleccionMultiple_CheckedChanged(object sender, EventArgs e)
		{
			bTodosCaja.Enabled = rbSeleccionMultiple.Checked;
			bNingunoCaja.Enabled = rbSeleccionMultiple.Checked;
			_uiController.SeleccionMultiple = rbSeleccionMultiple.Checked;
			if(rbSeleccionSimple.Checked)
				this.gridCuentas_SelectionChanged(gridCuentas, new EventArgs());
			if(_uiController.AllowSeleccionMultiple)
			{
				gridCuentas.RootTable.Columns["Selected"].Visible = rbSeleccionMultiple.Checked;
			}
		}

		private void bTodosCaja_Click(object sender, EventArgs e)
		{
			_uiController.Seleccionar(true);
		}

		private void bNingunoCaja_Click(object sender, EventArgs e)
		{
			_uiController.Seleccionar(false);
		}

		private void chkHabilitarLimCredito_CheckedChanged(object sender, EventArgs e)
		{
			uneLimiteDeCredito.Enabled = chkHabilitarLimCredito.Checked;
			_uiController.ModificaLimiteDeCredito = chkHabilitarLimCredito.Checked;
		}

		private void chkHabilitarDiasLimCredito_CheckedChanged(object sender, EventArgs e)
		{
			uneDiasLimiteDeCredito.Enabled = chkHabilitarDiasLimCredito.Checked;
			_uiController.ModificaDiasLimiteDeCredito = chkHabilitarDiasLimCredito.Checked;
		}

		private void chkHabilitarObservaciones_CheckedChanged(object sender, EventArgs e)
		{
			rtbObservaciones.Enabled = chkHabilitarObservaciones.Checked;
			groupBoxTipoEdicionObservaciones.Enabled = chkHabilitarObservaciones.Checked;
			_uiController.ModificaObservaciones = chkHabilitarObservaciones.Checked;
		}

		private void chkHabilitarCAux1_CheckedChanged(object sender, EventArgs e)
		{
			txtCampoAuxiliar1.Enabled = chkHabilitarCAux1.Checked;
			groupBoxTipoEdicionCampoAuxiliar1.Enabled = chkHabilitarCAux1.Checked;
			_uiController.ModificaCampoAuxiliar1 = chkHabilitarCAux1.Checked;
		}

		private void chkHabilitarCAux2_CheckedChanged(object sender, EventArgs e)
		{
			txtCampoAuxiliar2.Enabled = chkHabilitarCAux2.Checked;
			groupBoxTipoEdicionCampoAuxiliar2.Enabled = chkHabilitarCAux2.Checked;
			_uiController.ModificaCampoAuxiliar2 = chkHabilitarCAux2.Checked;
		}

		private void chkHabilitarCAux3_CheckedChanged(object sender, EventArgs e)
		{
			txtCampoAuxiliar3.Enabled = chkHabilitarCAux3.Checked;
			groupBoxTipoEdicionCampoAuxiliar3.Enabled = chkHabilitarCAux3.Checked;
			_uiController.ModificaCampoAuxiliar3 = chkHabilitarCAux3.Checked;
		}

		private void chkHabilitarListaDePreciosDefault_CheckedChanged(object sender, EventArgs e)
		{
			mzCEListaPrecios.Enabled = chkHabilitarListaDePreciosDefault.Checked;
			_uiController.ModificaListaDePrecios = chkHabilitarListaDePreciosDefault.Checked;
		}

		private void chkHabilitarActivo_CheckedChanged(object sender, EventArgs e)
		{
			chkActivo.Enabled = chkHabilitarActivo.Checked;
			_uiController.ModificaActivo = chkHabilitarActivo.Checked;
		}
		
		private void rbPorCuenta_CheckedChanged(object sender, EventArgs e)
		{
			groupPorProducto.Visible = true;
			groupPorJerarquia.Visible = false;
			_uiController.PorCuenta = true;

		}

		private void rbPorJerarquia_CheckedChanged(object sender, EventArgs e)
		{
			groupPorProducto.Visible = false;
			groupPorJerarquia.Visible = true;
			_uiController.PorCuenta = false;
            //German 20100903 - Tarea 824
            habilitarModificaciones();
            //Fin German 20100903 - Tarea 824

		}
	
		private void hierarchicalSearchControl1_OnSelected(object sender, EventArgs e)
		{

			_uiController.ByJerarquia1 = hierarchicalSearchControl1.NodeChecked1;
			_uiController.Jerarquias1 = hierarchicalSearchControl1.ItemsJerarquia1;
			_uiController.ByJerarquia2 = hierarchicalSearchControl1.NodeChecked2;
			_uiController.Jerarquias2 = hierarchicalSearchControl1.ItemsJerarquia2;
			_uiController.ByJerarquia3 = hierarchicalSearchControl1.NodeChecked3;
			_uiController.Jerarquias3 = hierarchicalSearchControl1.ItemsJerarquia3;
			_uiController.ByJerarquia4 = hierarchicalSearchControl1.NodeChecked4;
			_uiController.Jerarquias4 = hierarchicalSearchControl1.ItemsJerarquia4;
			_uiController.ByJerarquia5 = hierarchicalSearchControl1.NodeChecked5;
			_uiController.Jerarquias5 = hierarchicalSearchControl1.ItemsJerarquia5;
			_uiController.ByJerarquia6 = hierarchicalSearchControl1.NodeChecked6;
			_uiController.Jerarquias6 = hierarchicalSearchControl1.ItemsJerarquia6;
			_uiController.ByJerarquia7 = hierarchicalSearchControl1.NodeChecked7;
			_uiController.Jerarquias7 = hierarchicalSearchControl1.ItemsJerarquia7;
			_uiController.ByJerarquia8 = hierarchicalSearchControl1.NodeChecked8;
			_uiController.Jerarquias8 = hierarchicalSearchControl1.ItemsJerarquia8;			

		}

		private void mzCmbCuenta_MultipleSelectedItemsChanged(object sender, EventArgs e)
		{
			if( mzCmbCuenta.SelectedItems.Count > 1)
				_uiController.AddRange( mzCmbCuenta.SelectedItems);
		}

		#endregion

	}
}

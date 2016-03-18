using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.commontypes;
using mz.erp.ui.forms.classes;
using mz.erp.ui.utility;
using System.Data;
using mz.erp.businessrules;
using Janus.Windows.GridEX;


namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmAbmTiposMovimientos.
	/// </summary>
	public class FrmAbmTiposMovimientos : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		protected System.Windows.Forms.ToolBarButton tbbCancelar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private System.Windows.Forms.Label labelTarea;
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.Misc.UltraButton btnEliminar;
		private Infragistics.Win.Misc.UltraButton btnAgregar;
		private Janus.Windows.GridEX.GridEX gridEX1;
		private System.Windows.Forms.GroupBox groupBox1;
		private mz.erp.ui.controls.mzComboEditor mzCmbTiposMovimiento;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.RadioButton radIngreso;
		private System.Windows.Forms.RadioButton radEgreso;
		private System.Windows.Forms.RadioButton radSubTipoMovimiento;
		private System.Windows.Forms.RadioButton radTipoMovimiento;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Label label2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private Janus.Windows.GridEX.GridEX gridSubTiposMovimientos;
		private Janus.Windows.GridEX.GridEX gridTiposMovimientos;
		private Infragistics.Win.Misc.UltraButton btnModificarTipo;
		private System.Windows.Forms.TextBox txtDescripcionModifSubTipo;
		private Infragistics.Win.Misc.UltraButton btnModificarSubTipo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDescripcionModifTipo;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton radioIngreso;
		private System.Windows.Forms.RadioButton radioEgreso;
		private Infragistics.Win.Misc.UltraButton btnEliminarTipo;
		private Infragistics.Win.Misc.UltraButton btnEliminarSubTipo;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkActivo;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkActivoTipo;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkActivoSubTipo;
		private Infragistics.Win.Misc.UltraButton btnActivar;
		private System.Windows.Forms.TextBox txtIdTipo;
		private System.Windows.Forms.Label labelIdTipo;
		private System.Windows.Forms.Label labelIdSubTipo;
		private System.Windows.Forms.TextBox txtIdSubTipo;
		private System.ComponentModel.IContainer components;


		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmAbmTiposMovimientos));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.btnActivar = new Infragistics.Win.Misc.UltraButton();
			this.chkActivoSubTipo = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.chkActivoTipo = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.btnEliminarSubTipo = new Infragistics.Win.Misc.UltraButton();
			this.btnEliminarTipo = new Infragistics.Win.Misc.UltraButton();
			this.txtDescripcionModifSubTipo = new System.Windows.Forms.TextBox();
			this.btnModificarSubTipo = new Infragistics.Win.Misc.UltraButton();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDescripcionModifTipo = new System.Windows.Forms.TextBox();
			this.gridTiposMovimientos = new Janus.Windows.GridEX.GridEX();
			this.gridSubTiposMovimientos = new Janus.Windows.GridEX.GridEX();
			this.btnModificarTipo = new Infragistics.Win.Misc.UltraButton();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.radioIngreso = new System.Windows.Forms.RadioButton();
			this.radioEgreso = new System.Windows.Forms.RadioButton();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkActivo = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radIngreso = new System.Windows.Forms.RadioButton();
			this.radEgreso = new System.Windows.Forms.RadioButton();
			this.mzCmbTiposMovimiento = new mz.erp.ui.controls.mzComboEditor();
			this.radSubTipoMovimiento = new System.Windows.Forms.RadioButton();
			this.radTipoMovimiento = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.btnAgregar = new Infragistics.Win.Misc.UltraButton();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
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
			this.txtIdTipo = new System.Windows.Forms.TextBox();
			this.labelIdTipo = new System.Windows.Forms.Label();
			this.labelIdSubTipo = new System.Windows.Forms.Label();
			this.txtIdSubTipo = new System.Windows.Forms.TextBox();
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridTiposMovimientos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridSubTiposMovimientos)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposMovimiento)).BeginInit();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, -30);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(790, 27);
			this.ultraExplorerBarContainerControl5.TabIndex = 4;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(790, 23);
			this.labelTarea.TabIndex = 1;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.labelIdSubTipo);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.txtIdSubTipo);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.labelIdTipo);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.txtIdTipo);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.btnActivar);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.chkActivoSubTipo);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.chkActivoTipo);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.btnEliminarSubTipo);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.btnEliminarTipo);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.txtDescripcionModifSubTipo);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.btnModificarSubTipo);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.txtDescripcionModifTipo);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridTiposMovimientos);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridSubTiposMovimientos);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.btnModificarTipo);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.groupBox3);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, -71);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(790, 203);
			this.ultraExplorerBarContainerControl2.TabIndex = 5;
			// 
			// btnActivar
			// 
			this.btnActivar.Location = new System.Drawing.Point(240, 176);
			this.btnActivar.Name = "btnActivar";
			this.btnActivar.Size = new System.Drawing.Size(160, 24);
			this.btnActivar.TabIndex = 7;
			this.btnActivar.Text = "&Activar/Desactivar";
			// 
			// chkActivoSubTipo
			// 
			this.chkActivoSubTipo.BackColor = System.Drawing.Color.Transparent;
			this.chkActivoSubTipo.Location = new System.Drawing.Point(504, 144);
			this.chkActivoSubTipo.Name = "chkActivoSubTipo";
			this.chkActivoSubTipo.Size = new System.Drawing.Size(80, 22);
			this.chkActivoSubTipo.TabIndex = 9;
			this.chkActivoSubTipo.Text = "Activo";
			// 
			// chkActivoTipo
			// 
			this.chkActivoTipo.BackColor = System.Drawing.Color.Transparent;
			this.chkActivoTipo.Location = new System.Drawing.Point(24, 176);
			this.chkActivoTipo.Name = "chkActivoTipo";
			this.chkActivoTipo.Size = new System.Drawing.Size(80, 22);
			this.chkActivoTipo.TabIndex = 4;
			this.chkActivoTipo.Text = "Activo";
			// 
			// btnEliminarSubTipo
			// 
			this.btnEliminarSubTipo.Location = new System.Drawing.Point(704, 144);
			this.btnEliminarSubTipo.Name = "btnEliminarSubTipo";
			this.btnEliminarSubTipo.Size = new System.Drawing.Size(80, 24);
			this.btnEliminarSubTipo.TabIndex = 11;
			this.btnEliminarSubTipo.Text = "&Eliminar";
			// 
			// btnEliminarTipo
			// 
			this.btnEliminarTipo.Location = new System.Drawing.Point(320, 152);
			this.btnEliminarTipo.Name = "btnEliminarTipo";
			this.btnEliminarTipo.Size = new System.Drawing.Size(80, 24);
			this.btnEliminarTipo.TabIndex = 6;
			this.btnEliminarTipo.Text = "&Eliminar";
			// 
			// txtDescripcionModifSubTipo
			// 
			this.txtDescripcionModifSubTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtDescripcionModifSubTipo.Location = new System.Drawing.Point(504, 122);
			this.txtDescripcionModifSubTipo.Name = "txtDescripcionModifSubTipo";
			this.txtDescripcionModifSubTipo.Size = new System.Drawing.Size(192, 20);
			this.txtDescripcionModifSubTipo.TabIndex = 8;
			this.txtDescripcionModifSubTipo.Text = "";
			// 
			// btnModificarSubTipo
			// 
			this.btnModificarSubTipo.Location = new System.Drawing.Point(704, 122);
			this.btnModificarSubTipo.Name = "btnModificarSubTipo";
			this.btnModificarSubTipo.Size = new System.Drawing.Size(80, 24);
			this.btnModificarSubTipo.TabIndex = 10;
			this.btnModificarSubTipo.Text = "&Modificar";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(440, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 16);
			this.label3.TabIndex = 94;
			this.label3.Text = "Descripción";
			// 
			// txtDescripcionModifTipo
			// 
			this.txtDescripcionModifTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtDescripcionModifTipo.Location = new System.Drawing.Point(80, 122);
			this.txtDescripcionModifTipo.Name = "txtDescripcionModifTipo";
			this.txtDescripcionModifTipo.Size = new System.Drawing.Size(336, 20);
			this.txtDescripcionModifTipo.TabIndex = 1;
			this.txtDescripcionModifTipo.Text = "";
			// 
			// gridTiposMovimientos
			// 
			this.gridTiposMovimientos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridTiposMovimientos.AlternatingColors = true;
			this.gridTiposMovimientos.AutomaticSort = false;
			this.gridTiposMovimientos.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridTiposMovimientos.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridTiposMovimientos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridTiposMovimientos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridTiposMovimientos.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gridTiposMovimientos.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gridTiposMovimientos.GroupByBoxVisible = false;
			this.gridTiposMovimientos.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridTiposMovimientos.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridTiposMovimientos.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gridTiposMovimientos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
			this.gridTiposMovimientos.Location = new System.Drawing.Point(8, 8);
			this.gridTiposMovimientos.Name = "gridTiposMovimientos";
			this.gridTiposMovimientos.RecordNavigatorText = "Registro:|de";
			this.gridTiposMovimientos.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridTiposMovimientos.ShowEmptyFields = false;
			this.gridTiposMovimientos.Size = new System.Drawing.Size(408, 112);
			this.gridTiposMovimientos.TabIndex = 0;
			this.gridTiposMovimientos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			// 
			// gridSubTiposMovimientos
			// 
			this.gridSubTiposMovimientos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridSubTiposMovimientos.AlternatingColors = true;
			this.gridSubTiposMovimientos.AutomaticSort = false;
			this.gridSubTiposMovimientos.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridSubTiposMovimientos.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridSubTiposMovimientos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridSubTiposMovimientos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridSubTiposMovimientos.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gridSubTiposMovimientos.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gridSubTiposMovimientos.GroupByBoxVisible = false;
			this.gridSubTiposMovimientos.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridSubTiposMovimientos.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridSubTiposMovimientos.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gridSubTiposMovimientos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
			this.gridSubTiposMovimientos.Location = new System.Drawing.Point(440, 8);
			this.gridSubTiposMovimientos.Name = "gridSubTiposMovimientos";
			this.gridSubTiposMovimientos.RecordNavigatorText = "Registro:|de";
			this.gridSubTiposMovimientos.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridSubTiposMovimientos.ShowEmptyFields = false;
			this.gridSubTiposMovimientos.Size = new System.Drawing.Size(344, 112);
			this.gridSubTiposMovimientos.TabIndex = 89;
			this.gridSubTiposMovimientos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			// 
			// btnModificarTipo
			// 
			this.btnModificarTipo.Location = new System.Drawing.Point(240, 152);
			this.btnModificarTipo.Name = "btnModificarTipo";
			this.btnModificarTipo.Size = new System.Drawing.Size(80, 24);
			this.btnModificarTipo.TabIndex = 5;
			this.btnModificarTipo.Text = "&Modificar";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(8, 122);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 16);
			this.label2.TabIndex = 91;
			this.label2.Text = "Descripción";
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.radioIngreso);
			this.groupBox3.Controls.Add(this.radioEgreso);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(24, 144);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(184, 32);
			this.groupBox3.TabIndex = 101;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Tipo de Movimiento";
			// 
			// radioIngreso
			// 
			this.radioIngreso.BackColor = System.Drawing.Color.Transparent;
			this.radioIngreso.Location = new System.Drawing.Point(48, 13);
			this.radioIngreso.Name = "radioIngreso";
			this.radioIngreso.Size = new System.Drawing.Size(64, 16);
			this.radioIngreso.TabIndex = 2;
			this.radioIngreso.Text = "Ingreso";
			// 
			// radioEgreso
			// 
			this.radioEgreso.BackColor = System.Drawing.Color.Transparent;
			this.radioEgreso.Location = new System.Drawing.Point(120, 13);
			this.radioEgreso.Name = "radioEgreso";
			this.radioEgreso.Size = new System.Drawing.Size(65, 16);
			this.radioEgreso.TabIndex = 3;
			this.radioEgreso.Text = "Egreso";
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.groupBox1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.btnAgregar);
			this.ultraExplorerBarContainerControl1.DockPadding.Top = 12;
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 191);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(790, 89);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.chkActivo);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.mzCmbTiposMovimiento);
			this.groupBox1.Controls.Add(this.radSubTipoMovimiento);
			this.groupBox1.Controls.Add(this.radTipoMovimiento);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtDescripcion);
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(624, 88);
			this.groupBox1.TabIndex = 94;
			this.groupBox1.TabStop = false;
			// 
			// chkActivo
			// 
			this.chkActivo.BackColor = System.Drawing.Color.Transparent;
			this.chkActivo.Location = new System.Drawing.Point(432, 16);
			this.chkActivo.Name = "chkActivo";
			this.chkActivo.Size = new System.Drawing.Size(80, 22);
			this.chkActivo.TabIndex = 1;
			this.chkActivo.Text = "Activo";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.radIngreso);
			this.groupBox2.Controls.Add(this.radEgreso);
			this.groupBox2.Location = new System.Drawing.Point(168, 36);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(80, 44);
			this.groupBox2.TabIndex = 96;
			this.groupBox2.TabStop = false;
			// 
			// radIngreso
			// 
			this.radIngreso.BackColor = System.Drawing.Color.Transparent;
			this.radIngreso.Location = new System.Drawing.Point(8, 8);
			this.radIngreso.Name = "radIngreso";
			this.radIngreso.Size = new System.Drawing.Size(64, 16);
			this.radIngreso.TabIndex = 3;
			this.radIngreso.Text = "Ingreso";
			// 
			// radEgreso
			// 
			this.radEgreso.BackColor = System.Drawing.Color.Transparent;
			this.radEgreso.Location = new System.Drawing.Point(8, 24);
			this.radEgreso.Name = "radEgreso";
			this.radEgreso.Size = new System.Drawing.Size(65, 16);
			this.radEgreso.TabIndex = 4;
			this.radEgreso.Text = "Egreso";
			// 
			// mzCmbTiposMovimiento
			// 
			this.mzCmbTiposMovimiento.AutoComplete = true;
			this.mzCmbTiposMovimiento.DataSource = null;
			this.mzCmbTiposMovimiento.DisplayMember = "";
			this.mzCmbTiposMovimiento.DisplayMemberCaption = "";
			this.mzCmbTiposMovimiento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbTiposMovimiento.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
			this.mzCmbTiposMovimiento.Location = new System.Drawing.Point(432, 40);
			this.mzCmbTiposMovimiento.MaxItemsDisplay = 7;
			this.mzCmbTiposMovimiento.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbTiposMovimiento.Name = "mzCmbTiposMovimiento";
			this.mzCmbTiposMovimiento.Size = new System.Drawing.Size(176, 21);
			this.mzCmbTiposMovimiento.SorterMember = "";
			this.mzCmbTiposMovimiento.TabIndex = 6;
			this.mzCmbTiposMovimiento.ValueMember = "";
			this.mzCmbTiposMovimiento.ValueMemberCaption = "";
			// 
			// radSubTipoMovimiento
			// 
			this.radSubTipoMovimiento.BackColor = System.Drawing.Color.Transparent;
			this.radSubTipoMovimiento.Location = new System.Drawing.Point(272, 40);
			this.radSubTipoMovimiento.Name = "radSubTipoMovimiento";
			this.radSubTipoMovimiento.Size = new System.Drawing.Size(160, 24);
			this.radSubTipoMovimiento.TabIndex = 5;
			this.radSubTipoMovimiento.Text = "Subtipo de movimiento de";
			this.radSubTipoMovimiento.CheckedChanged += new System.EventHandler(this.radSubTipoMovimiento_CheckedChanged);
			// 
			// radTipoMovimiento
			// 
			this.radTipoMovimiento.BackColor = System.Drawing.Color.Transparent;
			this.radTipoMovimiento.Location = new System.Drawing.Point(24, 40);
			this.radTipoMovimiento.Name = "radTipoMovimiento";
			this.radTipoMovimiento.Size = new System.Drawing.Size(136, 24);
			this.radTipoMovimiento.TabIndex = 2;
			this.radTipoMovimiento.Text = "Tipo de movimiento";
			this.radTipoMovimiento.CheckedChanged += new System.EventHandler(this.radTipoMovimiento_CheckedChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(8, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 67;
			this.label1.Text = "Descripción";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtDescripcion.Location = new System.Drawing.Point(80, 16);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(336, 20);
			this.txtDescripcion.TabIndex = 0;
			this.txtDescripcion.Text = "";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(648, 56);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(80, 24);
			this.btnAgregar.TabIndex = 7;
			this.btnAgregar.Text = "&Agregar";
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.gridEX1);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.btnEliminar);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 339);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(790, 150);
			this.ultraExplorerBarContainerControl3.TabIndex = 6;
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
			this.gridEX1.Location = new System.Drawing.Point(8, 0);
			this.gridEX1.Name = "gridEX1";
			this.gridEX1.RecordNavigatorText = "Registro:|de";
			this.gridEX1.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridEX1.ShowEmptyFields = false;
			this.gridEX1.Size = new System.Drawing.Size(584, 160);
			this.gridEX1.TabIndex = 0;
			this.gridEX1.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(632, 8);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(80, 24);
			this.btnEliminar.TabIndex = 1;
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
			this.toolBarStandar.Size = new System.Drawing.Size(856, 28);
			this.toolBarStandar.TabIndex = 42;
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
			this.tbbSeparator2.Visible = false;
			// 
			// tbbCancelar
			// 
			this.tbbCancelar.ImageIndex = 7;
			this.tbbCancelar.Text = "&Cancelar";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl5;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 27;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 203;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Edición de movimientos existentes";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup3.Settings.ContainerHeight = 89;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Nuevos movimientos";
			ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup4.Text = "Modificaciones";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3,
																														ultraExplorerBarGroup4});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(856, 514);
			this.ultraExplorerBar1.TabIndex = 47;
			// 
			// txtIdTipo
			// 
			this.txtIdTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtIdTipo.Location = new System.Drawing.Point(168, 176);
			this.txtIdTipo.Name = "txtIdTipo";
			this.txtIdTipo.Size = new System.Drawing.Size(48, 20);
			this.txtIdTipo.TabIndex = 123;
			this.txtIdTipo.Text = "";
			// 
			// labelIdTipo
			// 
			this.labelIdTipo.BackColor = System.Drawing.Color.Transparent;
			this.labelIdTipo.Location = new System.Drawing.Point(144, 180);
			this.labelIdTipo.Name = "labelIdTipo";
			this.labelIdTipo.Size = new System.Drawing.Size(16, 16);
			this.labelIdTipo.TabIndex = 124;
			this.labelIdTipo.Text = "Id";
			// 
			// labelIdSubTipo
			// 
			this.labelIdSubTipo.BackColor = System.Drawing.Color.Transparent;
			this.labelIdSubTipo.Location = new System.Drawing.Point(600, 149);
			this.labelIdSubTipo.Name = "labelIdSubTipo";
			this.labelIdSubTipo.Size = new System.Drawing.Size(16, 16);
			this.labelIdSubTipo.TabIndex = 126;
			this.labelIdSubTipo.Text = "Id";
			// 
			// txtIdSubTipo
			// 
			this.txtIdSubTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtIdSubTipo.Location = new System.Drawing.Point(624, 144);
			this.txtIdSubTipo.Name = "txtIdSubTipo";
			this.txtIdSubTipo.Size = new System.Drawing.Size(48, 20);
			this.txtIdSubTipo.TabIndex = 125;
			this.txtIdSubTipo.Text = "";
			// 
			// FrmAbmTiposMovimientos
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(856, 542);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmAbmTiposMovimientos";
			this.Text = "FrmAbmTiposMovimientos";
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridTiposMovimientos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridSubTiposMovimientos)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposMovimiento)).EndInit();
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Custom Members
	
		#endregion


		#region Variables Privadas
		private controllers.AbmTiposMovimientosController _uiController = null;
		private string DescripcionTipoMovimientoModif = "";
		private string KeyTipoMovimientoModif = "";
		private string DescripcionSubTipoMovimientoModif = "";
		private string KeySubTipoMovimientoModif = "";
		private bool cambioSigno = false;

		#endregion

		#region Variables Publicas
		#endregion

		#region Constructores y Destructores
		public FrmAbmTiposMovimientos( controllers.AbmTiposMovimientosController controller )
		{
			InitializeComponent();
			_uiController = controller;
			Init();			
		}

		public FrmAbmTiposMovimientos()
		{			
			InitializeComponent();
			_uiController = new mz.erp.ui.controllers.AbmTiposMovimientosController();	
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
				/*BindingController.Clear(txtClaveAnt,"Text", _uiController, "ClaveAnterior");
				BindingController.Clear(txtClaveNue1,"Text", _uiController, "ClaveNueva1");
				BindingController.Clear(txtClaveNue2,"Text", _uiController, "ClaveNueva2");	*/
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

			mzCmbTiposMovimiento.FillFromDataSource( _uiController.TiposMovimientos, _uiController.KeyValueTiposMovimientos,_uiController.KeyListTiposMovimientos,100, _uiController.KeyListTiposMovimientos );

			this.gridEX1.LayoutData = _uiController.GetLayout();
			this.gridTiposMovimientos.LayoutData = _uiController.LayoutTiposMovimientos;
			this.gridSubTiposMovimientos.LayoutData = _uiController.LayoutSubTiposMovimientos;			


			gridTiposMovimientos.DataSource = _uiController.TiposSubTipos;
			gridSubTiposMovimientos.DataSource = _uiController.TiposSubTipos;

			gridTiposMovimientos.SetDataBinding(_uiController.TiposSubTipos, "tsy_TiposMovimientos");
			//gridSubTiposMovimientos.SetDataBinding(_uiController.TiposSubTipos,"tsy_SuTiposMovimientos.TiposSubtipos");			
			gridSubTiposMovimientos.SetDataBinding(_uiController.TiposSubTipos,"tsy_TiposMovimientos.TiposSubtipos");
			//gridSubTiposMovimientos.SetDataBinding(_uiController.TiposSubTipos,"tsy_SubTipoMovimiento");
			

			gridTiposMovimientos.Refresh();
			//this.gridSubTiposMovimientos.DataSource = _uiController.TiposSubMovimientos;			
			radTipoMovimiento.Checked = true;
			chkActivo.Checked = true;
/*			txtClaveAnt.Select();
			txtClaveAnt.Enabled = _uiController.EnabledSetPreviuosPassword;
			mzCmbUsuarios.FillFromDataSource( _uiController.Usuarios, _uiController.KeyValueUsuarios,_uiController.KeyListUsuarios,100, _uiController.KeyListUsuarios );
			mzCmbUsuarios.Enabled = !_uiController.EnabledSetPreviuosPassword;*/

			txtIdTipo.ReadOnly = true;
			txtIdSubTipo.ReadOnly = true;

			bool perfilSuperior = _uiController.PerteneceAPerfilSuperior;

			txtIdTipo.Visible = perfilSuperior;
			txtIdSubTipo.Visible = perfilSuperior;
			labelIdSubTipo.Visible = perfilSuperior;
			labelIdTipo.Visible = perfilSuperior;
			KeyPreview = true;
		}

		private void InitializeData()
		{
    
		}
		private void InitEventHandlers()
		{
			_uiController.TiposMovimientosNuevosHasChanged+=new EventHandler(_uiController_TiposMovimientosNuevosHasChanged);
			_uiController.TiposMovimientosHasChanged+=new EventHandler(_uiController_TiposMovimientosHasChanged);
			//_uiController.SubTiposMovimientosHasChanged+=new EventHandler(_uiController_SubTiposMovimientosHasChanged);
			this.gridTiposMovimientos.SelectionChanged+=new EventHandler(gridTiposMovimientos_SelectionChanged);			
			this.gridSubTiposMovimientos.SelectionChanged+=new EventHandler(gridSubTiposMovimientos_SelectionChanged);
			this.btnModificarTipo.Click += new System.EventHandler(this.btnModificarTipo_Click);
			this.btnModificarSubTipo.Click += new System.EventHandler(this.btnModificarSubTipo_Click);
			this.btnEliminarTipo.Click += new EventHandler(btnEliminarTipo_Click);
			this.btnEliminarSubTipo.Click += new EventHandler(btnEliminarSubTipo_Click);
			this.btnActivar.Click += new EventHandler(btnActivar_Click);
			radioIngreso.CheckedChanged += new EventHandler(radioIngreso_CheckedChanged);
			radioEgreso.CheckedChanged += new EventHandler(radioEgreso_CheckedChanged);
			KeyDownManager KeyDown = new KeyDownManager(this);
            this.gridTiposMovimientos.Click += new EventHandler(gridTiposMovimientos_Click);
		}

        void gridTiposMovimientos_Click(object sender, EventArgs e)
        {
            //Cristian Tarea 0000168 20110707
            gridTiposMovimientos.Focus();
            gridTiposMovimientos_SelectionChanged(sender,e);
            //Fin Tarea 0000168
        }	
	
		private void InitDataBindings()
		{
			//this.gridEX1.SetDataBinding( _uiController.TiposMovimientosNuevos, null );
			//gridEX1.DataSource = _uiController.TiposMovimientosNuevos;
			gridEX1.DataSource = _uiController.TiposMovimientosNuevos;
			//this.gridTiposMovimientos.SetDataBinding(_uiController.TiposMovimientos, null);		
			
			/*BindingController.Bind(txtClaveAnt,"Text", _uiController, "ClaveAnterior");
			BindingController.Bind(txtClaveNue1,"Text", _uiController, "ClaveNueva1");
			BindingController.Bind(txtClaveNue2,"Text", _uiController, "ClaveNueva2");			
			BindingController.Bind(mzCmbUsuarios, "Value", _uiController, "IdUsuario" );*/

			//Cristian Tarea 0000112 20110606
            btnActivar.Visible = false;
            //Fin Tarea 0000112
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);			
		}

		private void EventsListener()
		{
			
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
				case 4:	//Cancelar					
					CloseForm();
					break;
			}						
		}

		private void SaveChanges()
		{			
			Util.MoveFocus(this.ultraExplorerBarContainerControl1);
			_uiController.Execute();
		}

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

		private void Init() 
		{			
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;			
		}

		private void radTipoMovimiento_CheckedChanged(object sender, System.EventArgs e)
		{
			groupBox2.Enabled = true;	
			mzCmbTiposMovimiento.Enabled = false;
		}

		private void radSubTipoMovimiento_CheckedChanged(object sender, System.EventArgs e)
		{
			groupBox2.Enabled = false;	
			mzCmbTiposMovimiento.Enabled = true;		
		}

		private void btnAgregar_Click(object sender, System.EventArgs e)
		{			
			bool EsIngreso;
			string DescripcionTipo;
			string KeyTipo;
			string DescripcionSubTipo;
			string KeySubTipo;
			if (radTipoMovimiento.Checked)
			{				
				DescripcionTipo = txtDescripcion.Text;
				KeyTipo = "";
				DescripcionSubTipo = "";
				KeySubTipo = "";
				EsIngreso = radIngreso.Checked;				
			}
			else 
			{		
				DescripcionTipo = (string) mzCmbTiposMovimiento.Text;
				KeyTipo = (string) mzCmbTiposMovimiento.Value;
				DescripcionSubTipo = txtDescripcion.Text;					
				KeySubTipo = "";
				EsIngreso = false;				
			}
			_uiController.AddMovimiento(DescripcionTipo, KeyTipo, DescripcionSubTipo, KeySubTipo, EsIngreso, "NEW",chkActivo.Checked);
			
		}

		private void _uiController_TiposMovimientosNuevosHasChanged(object sender, EventArgs e)
		{			
            this.gridEX1.SetDataBinding( null, null );
			this.gridEX1.SetDataBinding(_uiController.TiposMovimientosNuevos, null );
		}
		private void _uiController_TiposMovimientosHasChanged(object sender, EventArgs e)
		{
			mzCmbTiposMovimiento.FillFromDataSource( _uiController.TiposMovimientos, _uiController.KeyValueTiposMovimientos,_uiController.KeyListTiposMovimientos,100, _uiController.KeyListTiposMovimientos );
		}
		private void _uiController_SubTiposMovimientosHasChanged(object sender, EventArgs e)
		{
		}			

		private void btnModificarTipo_Click(object sender, System.EventArgs e)
		{

            String idMovimientoModificado = KeyTipoMovimientoModif;
            if (cambioSigno)
			{
				if (_uiController.TieneMovimientosAsociados(KeyTipoMovimientoModif,"TIPO"))
				{
					MessageBox.Show(this,"No puede modificar el signo de este Tipo de Movimiento.", "Atención!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning );
				}
				else
				{
					if (radioIngreso.Checked)
						_uiController.AddMovimiento(txtDescripcionModifTipo.Text, KeyTipoMovimientoModif, "", "", true, "MODIF",chkActivoTipo.Checked);			
					else 
						_uiController.AddMovimiento(txtDescripcionModifTipo.Text, KeyTipoMovimientoModif, "", "", false, "MODIF",chkActivoTipo.Checked);			
				}
			}      
			else
			{
				_uiController.AddMovimiento(txtDescripcionModifTipo.Text, KeyTipoMovimientoModif, "", "", radioIngreso.Checked, "MODIF",chkActivoTipo.Checked);			
			}
            //Cristian Tarea 0000112 20110427
            txtDescripcionModifTipo.Text = "";
            GridEXColumn columna = gridTiposMovimientos.RootTable.Columns["idTipoMovimiento"];
            GridEXFilterCondition condicion = new GridEXFilterCondition(columna, ConditionOperator.Equal, idMovimientoModificado);
            gridTiposMovimientos.Focus(); 
            bool encontro = gridTiposMovimientos.Find(condicion,-1,1);
            GridEXColumn columnaOrden = gridTiposMovimientos.RootTable.Columns["Descripcion"];
            GridEXSortKey sortKey = new GridEXSortKey(columnaOrden, Janus.Windows.GridEX.SortOrder.Ascending);
            gridTiposMovimientos.RootTable.SortKeys.Add(sortKey);
            //Fin Cristian 20110427
		}

		private void btnActivar_Click(object sender, EventArgs e)
		{
			_uiController.AddMovimiento(txtDescripcionModifTipo.Text, KeyTipoMovimientoModif, txtDescripcionModifSubTipo.Text, KeySubTipoMovimientoModif, false, "MODIF", chkActivoTipo.Checked);					
		}

		private void btnEliminarTipo_Click(object sender, EventArgs e)
		{
			if (_uiController.TieneMovimientosAsociados(KeyTipoMovimientoModif,"TIPO"))
			{
				MessageBox.Show(this,"No puede eliminar este Tipo.", "Atención!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning );
			}
			else
			{
				_uiController.AddMovimiento(txtDescripcionModifTipo.Text, KeyTipoMovimientoModif, txtDescripcionModifSubTipo.Text, KeySubTipoMovimientoModif, false, "ELIMINAR_TIPO", true);					
			}
		}

		private void btnModificarSubTipo_Click(object sender, System.EventArgs e)
		{			
			if (KeySubTipoMovimientoModif != "")
				_uiController.AddMovimiento(DescripcionTipoMovimientoModif, KeyTipoMovimientoModif, txtDescripcionModifSubTipo.Text, KeySubTipoMovimientoModif, false, "MODIF",chkActivoSubTipo.Checked);					
		}

		private void btnEliminarSubTipo_Click(object sender, EventArgs e)
		{
			if (KeySubTipoMovimientoModif != "") 
				if (_uiController.TieneMovimientosAsociados(KeySubTipoMovimientoModif,"SUBTIPO"))
				{
					MessageBox.Show(this,"No puede eliminar este Subtipo.", "Atención!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning );
				}
				else
				{
					_uiController.AddMovimiento(DescripcionTipoMovimientoModif, KeyTipoMovimientoModif, txtDescripcionModifSubTipo.Text, KeySubTipoMovimientoModif, false, "ELIMINAR_SUBTIPO",true);					
				}
		}
        //Cristian Tarea 0000112   20110426
		private void btnEliminar_Click(object sender, System.EventArgs e)
		{
            
            CurrencyManager cm = (CurrencyManager) this.BindingContext[_uiController.TiposMovimientosNuevos];
			int pos = cm.Position;
            MovimientoNuevo movimientoSeleccionado = (MovimientoNuevo) cm.Current;

            String keyTipo = movimientoSeleccionado.KeyTipo;
            _uiController.RemoveModificacion(keyTipo);
			if(pos >= 0)
			{
				cm.RemoveAt(pos);
				cm.Refresh();
			}

            //Cristian Tarea 0000112 20110427
            /*se posiciona en la grilla seleccionando el movimiento */
            GridEXColumn columna = gridTiposMovimientos.RootTable.Columns["idTipoMovimiento"];
            GridEXFilterCondition condicion = new GridEXFilterCondition(columna, ConditionOperator.Equal, keyTipo);
            gridTiposMovimientos.Focus();
            bool encontro = gridTiposMovimientos.Find(condicion, -1, 1);
            /* ordenamos la grilla por descripcion */
            GridEXColumn columnaOrden = gridTiposMovimientos.RootTable.Columns["Descripcion"];
            GridEXSortKey sortKey = new GridEXSortKey(columnaOrden, Janus.Windows.GridEX.SortOrder.Ascending);
            gridTiposMovimientos.RootTable.SortKeys.Add(sortKey);
            //Fin Cristian 20110427
		}
        //Fin Tarea 0000112
		private void gridTiposMovimientos_SelectionChanged(object sender, EventArgs e)
		{
			radioIngreso.CheckedChanged -= new EventHandler(radioIngreso_CheckedChanged);
			radioEgreso.CheckedChanged -= new EventHandler(radioEgreso_CheckedChanged);
            //Cristian Tarea 0000021 20110418
            string tipoMovimientoModif = "";
            //Console.WriteLine(gridTiposMovimientos.SelectedItems[0].ToString());
           // if (gridTiposMovimientos.SelectedItems.Count > 0)
           // {
                DescripcionTipoMovimientoModif = (string)gridTiposMovimientos.SelectedItems[0].GetRow().Cells["Descripcion"].Value;
                tipoMovimientoModif = (string)gridTiposMovimientos.SelectedItems[0].GetRow().Cells["Tipo Movimiento"].Value;
                KeyTipoMovimientoModif = (string)gridTiposMovimientos.SelectedItems[0].GetRow().Cells["IdTipoMovimiento"].Value;
                chkActivoTipo.Checked = Convert.ToBoolean(gridTiposMovimientos.SelectedItems[0].GetRow().Cells["Activo"].Value);
            //}
            //Fin Tarea 0000021 20110418

			KeySubTipoMovimientoModif = "";
			DescripcionSubTipoMovimientoModif = "";
			if (gridSubTiposMovimientos.RecordCount == 0)
			{
				DescripcionSubTipoMovimientoModif = "";
				KeySubTipoMovimientoModif = "";
			}
			else 
			{
				DescripcionSubTipoMovimientoModif = (string) gridSubTiposMovimientos.SelectedItems[0].GetRow().Cells["Descripcion"].Value;			
				KeySubTipoMovimientoModif = (string) gridSubTiposMovimientos.SelectedItems[0].GetRow().Cells["IdSubTipoMovimiento"].Value;
			}

			txtDescripcionModifTipo.Text = DescripcionTipoMovimientoModif;			
			txtDescripcionModifSubTipo.Text = DescripcionSubTipoMovimientoModif;
            //Cristian Tarea 0000112 20110427
            if (tipoMovimientoModif != null)
            {
                if (!tipoMovimientoModif.Equals(string.Empty)&& tipoMovimientoModif.Equals("Egreso"))
				    radioEgreso.Checked=true;
			    else
				    radioIngreso.Checked=true;
            }
            //Fin Cristian 20110427
			txtIdTipo.Text = KeyTipoMovimientoModif;
			txtIdSubTipo.Text = KeySubTipoMovimientoModif;

			radioIngreso.CheckedChanged += new EventHandler(radioIngreso_CheckedChanged);
			radioEgreso.CheckedChanged += new EventHandler(radioEgreso_CheckedChanged);

		}

		private void gridSubTiposMovimientos_SelectionChanged(object sender, EventArgs e)
		{
			DescripcionTipoMovimientoModif = (string) gridTiposMovimientos.SelectedItems[0].GetRow().Cells["Descripcion"].Value;
			KeyTipoMovimientoModif = (string) gridTiposMovimientos.SelectedItems[0].GetRow().Cells["IdTipoMovimiento"].Value;
            //Cristian Tarea 0000168 20110707
            if(gridSubTiposMovimientos.SelectedItems.Count > 0)
			{
			    DescripcionSubTipoMovimientoModif =
			        (string) gridSubTiposMovimientos.SelectedItems[0].GetRow().Cells["Descripcion"].Value;
			    KeySubTipoMovimientoModif =
			        (string) gridSubTiposMovimientos.SelectedItems[0].GetRow().Cells["IdSubTipoMovimiento"].Value;
			}
            //Fin Tarea 0000168
		    txtDescripcionModifSubTipo.Text = DescripcionSubTipoMovimientoModif;
			chkActivoSubTipo.Checked = Convert.ToBoolean(gridSubTiposMovimientos.SelectedItems[0].GetRow().Cells["Activo"].Value);
			txtIdSubTipo.Text = KeySubTipoMovimientoModif;
			txtIdTipo.Text = KeyTipoMovimientoModif;
		}

		private void radioIngreso_CheckedChanged(object sender, EventArgs e)
		{
			cambioSigno = true;
		}

		private void radioEgreso_CheckedChanged(object sender, EventArgs e)
		{
			cambioSigno = true;
		}
	}
}

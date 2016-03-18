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
	/// Descripción breve de FrmConsultarFacturasImpagas.
	/// </summary>
	public class FrmConsultarFacturasImpagas : System.Windows.Forms.Form, ITaskForm, ISearchObjectListener
	{
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ImageList imglStandar;
		protected System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton toolBarButton11;
		private System.Windows.Forms.ToolBarButton toolBarButton12;
		private System.Windows.Forms.ToolBarButton toolBarButton13;
		private System.Windows.Forms.ToolBarButton toolBarButton14;
		private System.Windows.Forms.ToolBarButton toolBarButton16;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ContainerFiltro;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo FechaDesde;
		private System.Windows.Forms.Label label6;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo FechaHasta;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbFechaVencimiento;
		private System.Windows.Forms.RadioButton rbFechaEmision;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		protected Janus.Windows.GridEX.GridEX gridResultado;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.Label lbTarea;
		private mz.erp.ui.controls.mzCuentasControl mzCmbCuenta;
		private System.Windows.Forms.Label label2;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCantPeriodo;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rbPeriodoEnSemanas;
		private System.Windows.Forms.RadioButton rbPeriodoEnDias;
		private System.Windows.Forms.RadioButton rbEnMeses;
		private System.Windows.Forms.ToolBarButton tbbSeparadorCacelar;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton rbPeriodoPorFechaVencimiento;
		private System.Windows.Forms.RadioButton rbPeriodoPorFechaEmision;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label4;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkMostrarElResto;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmConsultarFacturasImpagas));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.lbTarea = new System.Windows.Forms.Label();
			this.ContainerFiltro = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rbPeriodoPorFechaVencimiento = new System.Windows.Forms.RadioButton();
			this.rbPeriodoPorFechaEmision = new System.Windows.Forms.RadioButton();
			this.uneCantPeriodo = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbEnMeses = new System.Windows.Forms.RadioButton();
			this.rbPeriodoEnSemanas = new System.Windows.Forms.RadioButton();
			this.rbPeriodoEnDias = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.chkMostrarElResto = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.label2 = new System.Windows.Forms.Label();
			this.mzCmbCuenta = new mz.erp.ui.controls.mzCuentasControl();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.FechaDesde = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.label6 = new System.Windows.Forms.Label();
			this.FechaHasta = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbFechaVencimiento = new System.Windows.Forms.RadioButton();
			this.rbFechaEmision = new System.Windows.Forms.RadioButton();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.gridResultado = new Janus.Windows.GridEX.GridEX();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton11 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton12 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton13 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton14 = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparadorCacelar = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton16 = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.ContainerFiltro.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uneCantPeriodo)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.FechaDesde)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaHasta)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.lbTarea);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(878, 16);
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
			this.ContainerFiltro.Controls.Add(this.groupBox4);
			this.ContainerFiltro.Controls.Add(this.groupBox3);
			this.ContainerFiltro.Controls.Add(this.chkMostrarElResto);
			this.ContainerFiltro.Controls.Add(this.label2);
			this.ContainerFiltro.Controls.Add(this.mzCmbCuenta);
			this.ContainerFiltro.Controls.Add(this.label7);
			this.ContainerFiltro.Controls.Add(this.label1);
			this.ContainerFiltro.Controls.Add(this.FechaDesde);
			this.ContainerFiltro.Controls.Add(this.label6);
			this.ContainerFiltro.Controls.Add(this.FechaHasta);
			this.ContainerFiltro.Controls.Add(this.groupBox1);
			this.ContainerFiltro.Location = new System.Drawing.Point(28, 99);
			this.ContainerFiltro.Name = "ContainerFiltro";
			this.ContainerFiltro.Size = new System.Drawing.Size(878, 135);
			this.ContainerFiltro.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Transparent;
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Location = new System.Drawing.Point(568, 0);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(304, 96);
			this.groupBox4.TabIndex = 138;
			this.groupBox4.TabStop = false;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(16, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(280, 72);
			this.label4.TabIndex = 134;
			this.label4.Tag = "";
			this.label4.Text = "La consulta divide las facturas impagas en 5 períodos, cuya extensión será decidi" +
				"da por el usuario. En caso de seleccionar Mostrar el Resto, un sexto período mos" +
				"trará las facturas impagas no incluidas dentro los períodos seleccionados.";
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.rbPeriodoPorFechaVencimiento);
			this.groupBox3.Controls.Add(this.rbPeriodoPorFechaEmision);
			this.groupBox3.Controls.Add(this.uneCantPeriodo);
			this.groupBox3.Controls.Add(this.groupBox2);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Location = new System.Drawing.Point(96, 64);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(456, 64);
			this.groupBox3.TabIndex = 137;
			this.groupBox3.TabStop = false;
			// 
			// rbPeriodoPorFechaVencimiento
			// 
			this.rbPeriodoPorFechaVencimiento.Location = new System.Drawing.Point(144, 8);
			this.rbPeriodoPorFechaVencimiento.Name = "rbPeriodoPorFechaVencimiento";
			this.rbPeriodoPorFechaVencimiento.Size = new System.Drawing.Size(160, 24);
			this.rbPeriodoPorFechaVencimiento.TabIndex = 6;
			this.rbPeriodoPorFechaVencimiento.Text = "Por Fecha Vencimiento";
			// 
			// rbPeriodoPorFechaEmision
			// 
			this.rbPeriodoPorFechaEmision.Location = new System.Drawing.Point(8, 8);
			this.rbPeriodoPorFechaEmision.Name = "rbPeriodoPorFechaEmision";
			this.rbPeriodoPorFechaEmision.Size = new System.Drawing.Size(128, 24);
			this.rbPeriodoPorFechaEmision.TabIndex = 5;
			this.rbPeriodoPorFechaEmision.Text = "Por Fecha Emisión";
			// 
			// uneCantPeriodo
			// 
			this.uneCantPeriodo.Location = new System.Drawing.Point(80, 32);
			this.uneCantPeriodo.MinValue = 0;
			this.uneCantPeriodo.Name = "uneCantPeriodo";
			this.uneCantPeriodo.PromptChar = ' ';
			this.uneCantPeriodo.Size = new System.Drawing.Size(100, 21);
			this.uneCantPeriodo.TabIndex = 7;
			this.uneCantPeriodo.Value = 1;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.rbEnMeses);
			this.groupBox2.Controls.Add(this.rbPeriodoEnSemanas);
			this.groupBox2.Controls.Add(this.rbPeriodoEnDias);
			this.groupBox2.Location = new System.Drawing.Point(184, 27);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(264, 27);
			this.groupBox2.TabIndex = 135;
			this.groupBox2.TabStop = false;
			// 
			// rbEnMeses
			// 
			this.rbEnMeses.Location = new System.Drawing.Point(184, 3);
			this.rbEnMeses.Name = "rbEnMeses";
			this.rbEnMeses.Size = new System.Drawing.Size(72, 24);
			this.rbEnMeses.TabIndex = 10;
			this.rbEnMeses.Text = "Meses";
			// 
			// rbPeriodoEnSemanas
			// 
			this.rbPeriodoEnSemanas.Location = new System.Drawing.Point(96, 3);
			this.rbPeriodoEnSemanas.Name = "rbPeriodoEnSemanas";
			this.rbPeriodoEnSemanas.Size = new System.Drawing.Size(72, 24);
			this.rbPeriodoEnSemanas.TabIndex = 9;
			this.rbPeriodoEnSemanas.Text = "Semanas";
			// 
			// rbPeriodoEnDias
			// 
			this.rbPeriodoEnDias.Location = new System.Drawing.Point(24, 3);
			this.rbPeriodoEnDias.Name = "rbPeriodoEnDias";
			this.rbPeriodoEnDias.Size = new System.Drawing.Size(56, 24);
			this.rbPeriodoEnDias.TabIndex = 8;
			this.rbPeriodoEnDias.Text = "Días";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(8, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 16);
			this.label3.TabIndex = 138;
			this.label3.Tag = "Periodos";
			this.label3.Text = "Cantidad de";
			// 
			// chkMostrarElResto
			// 
			this.chkMostrarElResto.BackColor = System.Drawing.Color.Transparent;
			this.chkMostrarElResto.Location = new System.Drawing.Point(560, 104);
			this.chkMostrarElResto.Name = "chkMostrarElResto";
			this.chkMostrarElResto.TabIndex = 11;
			this.chkMostrarElResto.Text = "Mostrar el resto";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(8, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 16);
			this.label2.TabIndex = 133;
			this.label2.Tag = "Periodos";
			this.label2.Text = "Períodos";
			// 
			// mzCmbCuenta
			// 
			this.mzCmbCuenta.AllowEditClientePaso = false;
			this.mzCmbCuenta.BackColor = System.Drawing.SystemColors.Control;
			this.mzCmbCuenta.DataValue = "";
			this.mzCmbCuenta.EnableCtaCte = false;
			this.mzCmbCuenta.FastSearch = false;
			this.mzCmbCuenta.Location = new System.Drawing.Point(96, 0);
			this.mzCmbCuenta.Name = "mzCmbCuenta";
			this.mzCmbCuenta.SearchObjectListener = null;
			this.mzCmbCuenta.Size = new System.Drawing.Size(456, 24);
			this.mzCmbCuenta.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(8, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 16);
			this.label7.TabIndex = 123;
			this.label7.Tag = "FechaDesde";
			this.label7.Text = "Fecha inicio";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(8, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 17);
			this.label1.TabIndex = 120;
			this.label1.Tag = "Cliente";
			this.label1.Text = "Cliente";
			// 
			// FechaDesde
			// 
			dateButton1.Caption = "Today";
			this.FechaDesde.DateButtons.Add(dateButton1);
			this.FechaDesde.Location = new System.Drawing.Point(96, 22);
			this.FechaDesde.Name = "FechaDesde";
			this.FechaDesde.NonAutoSizeHeight = 23;
			this.FechaDesde.Size = new System.Drawing.Size(96, 21);
			this.FechaDesde.TabIndex = 1;
			this.FechaDesde.Tag = "FechaDesde";
			this.FechaDesde.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(8, 50);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 16);
			this.label6.TabIndex = 119;
			this.label6.Tag = "FechaHasta";
			this.label6.Text = "Fecha fin";
			// 
			// FechaHasta
			// 
			dateButton2.Caption = "Today";
			this.FechaHasta.DateButtons.Add(dateButton2);
			this.FechaHasta.Location = new System.Drawing.Point(96, 43);
			this.FechaHasta.Name = "FechaHasta";
			this.FechaHasta.NonAutoSizeHeight = 23;
			this.FechaHasta.Size = new System.Drawing.Size(96, 21);
			this.FechaHasta.TabIndex = 1;
			this.FechaHasta.Tag = "FechaHasta";
			this.FechaHasta.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.rbFechaVencimiento);
			this.groupBox1.Controls.Add(this.rbFechaEmision);
			this.groupBox1.Location = new System.Drawing.Point(200, 21);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(352, 40);
			this.groupBox1.TabIndex = 125;
			this.groupBox1.TabStop = false;
			// 
			// rbFechaVencimiento
			// 
			this.rbFechaVencimiento.Location = new System.Drawing.Point(176, 16);
			this.rbFechaVencimiento.Name = "rbFechaVencimiento";
			this.rbFechaVencimiento.Size = new System.Drawing.Size(160, 24);
			this.rbFechaVencimiento.TabIndex = 4;
			this.rbFechaVencimiento.Text = "Por Fecha Vencimiento";
			// 
			// rbFechaEmision
			// 
			this.rbFechaEmision.Location = new System.Drawing.Point(24, 16);
			this.rbFechaEmision.Name = "rbFechaEmision";
			this.rbFechaEmision.Size = new System.Drawing.Size(128, 24);
			this.rbFechaEmision.TabIndex = 3;
			this.rbFechaEmision.Text = "Por Fecha Emisión";
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridManagerView1);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridResultado);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 293);
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
			this.gridManagerView1.TabIndex = 52;
			// 
			// gridResultado
			// 
			this.gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.gridResultado.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridResultado.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.gridResultado.GroupByBoxVisible = false;
			this.gridResultado.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridResultado.Location = new System.Drawing.Point(0, 24);
			this.gridResultado.Name = "gridResultado";
			this.gridResultado.Size = new System.Drawing.Size(872, 184);
			this.gridResultado.TabIndex = 0;
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
																							  this.toolBarButton11,
																							  this.toolBarButton12,
																							  this.toolBarButton13,
																							  this.toolBarButton14,
																							  this.tbbSeparadorCacelar,
																							  this.tbbCancelar,
																							  this.toolBarButton16});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(944, 28);
			this.toolBarStandar.TabIndex = 21;
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
			// tbbSeparadorCacelar
			// 
			this.tbbSeparadorCacelar.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbCancelar
			// 
			this.tbbCancelar.ImageIndex = 7;
			this.tbbCancelar.Text = "Cancelar";
			// 
			// toolBarButton16
			// 
			this.toolBarButton16.ImageIndex = 9;
			this.toolBarButton16.Text = "&Selección";
			this.toolBarButton16.Visible = false;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ContainerFiltro);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Key = "Tarea";
			ultraExplorerBarGroup1.Settings.ContainerHeight = 16;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ContainerFiltro;
			ultraExplorerBarGroup2.Key = "FiltroPrincipal";
			ultraExplorerBarGroup2.Settings.ContainerHeight = 135;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Filtro";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup3.Key = "Resultado";
			ultraExplorerBarGroup3.Settings.ContainerHeight = 205;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Resultado";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(944, 394);
			this.ultraExplorerBar1.TabIndex = 22;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// FrmConsultarFacturasImpagas
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(944, 422);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmConsultarFacturasImpagas";
			this.Text = "FrmConsultarFacturasImpagas";
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.ContainerFiltro.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uneCantPeriodo)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.FechaDesde)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaHasta)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
	
		#region Constructores y Destructores		

		public FrmConsultarFacturasImpagas(ConsultarFacturasImpagasController uiController)
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
		private ConsultarFacturasImpagasController _uiController;
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
			//this.gridResultado.AutomaticSort = true;

			mzCmbCuenta.Init(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName());
			mzCmbCuenta.Enabled = true;
			mzCmbCuenta.EnableCtaCte = true;
			mzCmbCuenta.AllowEditClientePaso = false;
			mzCmbCuenta.SearchObjectListener = this;

			this.KeyPreview = true;		

			/*rbFechaEmision.Checked = _uiController.PorFechaEmision;
			rbFechaVencimiento.Checked = _uiController.PorFechaVencimiento;
			rbFechaRecepcionMercaderia.Checked = _uiController.PorFechaRecepcionMercaderia;
		

			foreach( Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup group in this.ultraExplorerBar1.Groups)
			{				
				group.Visible = false;
				if (group.Container != null)
					group.Container.Enabled = false;
			}
			if(!_uiController.ContenedoresVisibles.Equals(string.Empty))
			{
				ArrayList cont = mz.erp.systemframework.Util.Parse(_uiController.ContenedoresVisibles, ",");
				foreach(string grupo in cont)
				{
					this.ultraExplorerBar1.Groups[grupo].Visible = true;
				}
				_allowShowDetails = cont.Contains("Detalles");
			}

			if(!_uiController.ContenedoresHabilitados.Equals(string.Empty))
			{								
				ArrayList cont = mz.erp.systemframework.Util.Parse(_uiController.ContenedoresHabilitados, ",");
				foreach(string grupo in cont)
				{
					if (this.ultraExplorerBar1.Groups[grupo].Container != null)
						this.ultraExplorerBar1.Groups[grupo].Container.Enabled = true;
				}
			}
			tbbSeparadorImprimir.Visible = _uiController.VisualizaBotonImprimir;
			*/
		}

		private void InitializeData()
		{
			FechaDesde.Value = _uiController.FechaDesde;
			FechaHasta.Value = _uiController.FechaHasta;
			rbFechaEmision.Checked = _uiController.PorFechaEmision;
			rbFechaVencimiento.Checked = _uiController.PorFechaVencimiento;
			rbPeriodoEnDias.Checked = _uiController.PeriodosEnDias;
			rbPeriodoEnSemanas.Checked = _uiController.PeriodosEnSemanas;
			rbEnMeses.Checked = _uiController.PeriodosEnMeses;
			chkMostrarElResto.Checked = _uiController.MostrarElResto;
			rbPeriodoPorFechaEmision.Checked = _uiController.PeriodosPorFechaEmision;
			rbPeriodoPorFechaVencimiento.Checked = _uiController.PeriodosPorFechaVencimiento;
		}

		private void InitEventHandlers()
		{
			this.toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
            mzCmbCuenta.ValueChanged+= new System.EventHandler( this.Componentes_Changes );		
			_uiController.DataChanged+=new EventHandler(RefreshData);
			this.KeyDown+=new KeyEventHandler(FrmConsultarFacturasImpagas_KeyDown);
			uneCantPeriodo.ValueChanged+=new EventHandler(uneCantPeriodo_ValueChanged);
			KeyDownManager KeyDownMan = new KeyDownManager(this);
            //Cristian Tarea 0000050 20110310
            this.FechaDesde.ValueChanged += new EventHandler(dtFechaDesde_ValueChanged);
            //Fin Cristian

        }
        //Cristian Tarea 0000050 20110310
        void dtFechaDesde_ValueChanged(object sender, EventArgs e)
        {

                _uiController.updateFechas((Convert.ToDateTime(FechaDesde.Value)));
                this.FechaHasta.Value = _uiController.FechaHasta;

        }

        //Fin Cristian

		private void InitDataBindings()
		{
		}

		private void RefreshData()
		{
			Util.MoveFocus(this.ContainerFiltro);
			this.Cursor = Cursors.WaitCursor;
			gridResultado.Focus();
			this.DumpControls();			
			_uiController.RefreshData();
			this.Cursor = Cursors.Default;
		}
		private void DumpControls()
		{
			_uiController.FechaDesde = Convert.ToDateTime(FechaDesde.Value);
			_uiController.FechaHasta = Convert.ToDateTime(FechaHasta.Value);
			_uiController.PorFechaEmision = rbFechaEmision.Checked;
			_uiController.PorFechaVencimiento = rbFechaVencimiento.Checked;
			_uiController.Periodos = Convert.ToInt16(uneCantPeriodo.Value);
			_uiController.PeriodosEnDias = rbPeriodoEnDias.Checked;
			_uiController.PeriodosEnSemanas = rbPeriodoEnSemanas.Checked;
			_uiController.PeriodosEnMeses = rbEnMeses.Checked;
			_uiController.MostrarElResto = chkMostrarElResto.Checked;
			_uiController.PeriodosPorFechaEmision = rbPeriodoPorFechaEmision.Checked;
			_uiController.PeriodosPorFechaVencimiento = rbPeriodoPorFechaVencimiento.Checked;
		}

		public void ResetParameters()
		{
			mzCmbCuenta.DataValue = string.Empty;
			mzCmbCuenta.ResetText();
			mzCmbCuenta.ClearControl();
			FechaDesde.Value = _uiController.FechaDesde;
			FechaHasta.Value = _uiController.FechaHasta;
			rbFechaEmision.Checked = _uiController.PorFechaEmision;
			rbFechaVencimiento.Checked = _uiController.PorFechaVencimiento;
			rbPeriodoEnDias.Checked = _uiController.PeriodosEnDias;
			rbPeriodoEnSemanas.Checked = _uiController.PeriodosEnSemanas;
			rbEnMeses.Checked = _uiController.PeriodosEnMeses;
			chkMostrarElResto.Checked = _uiController.MostrarElResto;
			rbPeriodoPorFechaEmision.Checked = _uiController.PeriodosPorFechaEmision;
			rbPeriodoPorFechaVencimiento.Checked = _uiController.PeriodosPorFechaVencimiento;
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
					_uiController.Execute();
					//this.Execute();
					break;
				case 4: /*Buscar Ahora*/					
					RefreshData();
					break;
				case 6: /*Nueva Búsqueda*/					
					ResetParameters();
					break;
				case 8:	//Cancelar				
					this.CloseForm();									
					break;

			}				
		}

		public void processEventChange(object sender , EventArgs e)
		{				
		}

		private void Componentes_Changes( object sender, System.EventArgs e )
		{			
			_uiController.CodigoCuenta = Convert.ToString(mzCmbCuenta.DataValue);				
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

		private void FrmConsultarFacturasImpagas_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyData )
			{
				case System.Windows.Forms.Keys.F5 :
					this.RefreshData();					
					break;
				default:
					break;
			}

		}

		private void uneCantPeriodo_ValueChanged(object sender, EventArgs e)
		{
			if(Convert.ToInt16(uneCantPeriodo.Value) == 0)
			{
				System.Windows.Forms.DialogResult result = MessageBox.Show("La cantidad debe ser mayor que 0", "Advertencia",System.Windows.Forms.MessageBoxButtons.OK);
				uneCantPeriodo.Value = 1;
			}

		}
	}
}

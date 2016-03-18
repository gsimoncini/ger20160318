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
using System.Data;
namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmConsultarEstadisticaOrdenReparacion.
	/// </summary>
	public class FrmConsultarEstadisticaOrdenReparacion : System.Windows.Forms.Form,  ITaskForm
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private System.Windows.Forms.Label labelTarea;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Label label1;
		protected Janus.Windows.GridEX.GridEX gridResultado;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo uccFechaHasta;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo uccFechaDesde;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rbFechaAsignacionTecnico;
		private System.Windows.Forms.RadioButton rbFechaAltaOR;
		private System.Windows.Forms.RadioButton rbFechaFactura;
		private System.Windows.Forms.RadioButton rbFechaCierre;
		private System.Windows.Forms.RadioButton rbFechaUltimaModifTecnico;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTotalCerrado;
		private System.Windows.Forms.TextBox txtTotalPorCerrar;
		private System.Windows.Forms.Label label4;
		private mz.erp.ui.controls.mzComboEditor mzCmbEstadosOrdenReparacion;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ListBox listBoxTecnicos;
		private System.ComponentModel.IContainer components;


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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmConsultarEstadisticaOrdenReparacion));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbFechaUltimaModifTecnico = new System.Windows.Forms.RadioButton();
			this.rbFechaCierre = new System.Windows.Forms.RadioButton();
			this.rbFechaFactura = new System.Windows.Forms.RadioButton();
			this.rbFechaAsignacionTecnico = new System.Windows.Forms.RadioButton();
			this.rbFechaAltaOR = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.uccFechaHasta = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.uccFechaDesde = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.txtTotalPorCerrar = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTotalCerrado = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gridResultado = new Janus.Windows.GridEX.GridEX();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.label4 = new System.Windows.Forms.Label();
			this.mzCmbEstadosOrdenReparacion = new mz.erp.ui.controls.mzComboEditor();
			this.label5 = new System.Windows.Forms.Label();
			this.listBoxTecnicos = new System.Windows.Forms.ListBox();
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uccFechaHasta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uccFechaDesde)).BeginInit();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbEstadosOrdenReparacion)).BeginInit();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(814, 26);
			this.ultraExplorerBarContainerControl5.TabIndex = 4;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(814, 23);
			this.labelTarea.TabIndex = 1;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.listBoxTecnicos);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label5);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.mzCmbEstadosOrdenReparacion);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label4);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.groupBox2);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label6);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label7);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.uccFechaHasta);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.uccFechaDesde);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 109);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(814, 180);
			this.ultraExplorerBarContainerControl2.TabIndex = 5;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.rbFechaUltimaModifTecnico);
			this.groupBox2.Controls.Add(this.rbFechaCierre);
			this.groupBox2.Controls.Add(this.rbFechaFactura);
			this.groupBox2.Controls.Add(this.rbFechaAsignacionTecnico);
			this.groupBox2.Controls.Add(this.rbFechaAltaOR);
			this.groupBox2.Location = new System.Drawing.Point(224, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(224, 144);
			this.groupBox2.TabIndex = 132;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Fecha Comparación";
			// 
			// rbFechaUltimaModifTecnico
			// 
			this.rbFechaUltimaModifTecnico.Location = new System.Drawing.Point(8, 112);
			this.rbFechaUltimaModifTecnico.Name = "rbFechaUltimaModifTecnico";
			this.rbFechaUltimaModifTecnico.Size = new System.Drawing.Size(208, 24);
			this.rbFechaUltimaModifTecnico.TabIndex = 11;
			this.rbFechaUltimaModifTecnico.Text = "Fecha Cierre Técnico";
			// 
			// rbFechaCierre
			// 
			this.rbFechaCierre.Location = new System.Drawing.Point(8, 88);
			this.rbFechaCierre.Name = "rbFechaCierre";
			this.rbFechaCierre.Size = new System.Drawing.Size(208, 24);
			this.rbFechaCierre.TabIndex = 10;
			this.rbFechaCierre.Text = "Fecha Cierre";
			// 
			// rbFechaFactura
			// 
			this.rbFechaFactura.Location = new System.Drawing.Point(8, 61);
			this.rbFechaFactura.Name = "rbFechaFactura";
			this.rbFechaFactura.Size = new System.Drawing.Size(208, 24);
			this.rbFechaFactura.TabIndex = 9;
			this.rbFechaFactura.Text = "Fecha de Factura";
			// 
			// rbFechaAsignacionTecnico
			// 
			this.rbFechaAsignacionTecnico.Location = new System.Drawing.Point(8, 37);
			this.rbFechaAsignacionTecnico.Name = "rbFechaAsignacionTecnico";
			this.rbFechaAsignacionTecnico.Size = new System.Drawing.Size(208, 24);
			this.rbFechaAsignacionTecnico.TabIndex = 8;
			this.rbFechaAsignacionTecnico.Text = "Fecha de Asignación a Técnico";
			// 
			// rbFechaAltaOR
			// 
			this.rbFechaAltaOR.Location = new System.Drawing.Point(8, 13);
			this.rbFechaAltaOR.Name = "rbFechaAltaOR";
			this.rbFechaAltaOR.Size = new System.Drawing.Size(208, 24);
			this.rbFechaAltaOR.TabIndex = 7;
			this.rbFechaAltaOR.Text = "Fecha de Alta de Orden Reparación";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(8, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 16);
			this.label6.TabIndex = 128;
			this.label6.Text = "Fecha Hasta";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(8, 8);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 16);
			this.label7.TabIndex = 129;
			this.label7.Text = "Fecha Desde";
			// 
			// uccFechaHasta
			// 
			dateButton1.Caption = "Today";
			this.uccFechaHasta.DateButtons.Add(dateButton1);
			this.uccFechaHasta.Location = new System.Drawing.Point(96, 40);
			this.uccFechaHasta.Name = "uccFechaHasta";
			this.uccFechaHasta.NonAutoSizeHeight = 23;
			this.uccFechaHasta.Size = new System.Drawing.Size(96, 21);
			this.uccFechaHasta.TabIndex = 127;
			// 
			// uccFechaDesde
			// 
			dateButton2.Caption = "Today";
			this.uccFechaDesde.DateButtons.Add(dateButton2);
			this.uccFechaDesde.Location = new System.Drawing.Point(96, 8);
			this.uccFechaDesde.Name = "uccFechaDesde";
			this.uccFechaDesde.NonAutoSizeHeight = 23;
			this.uccFechaDesde.Size = new System.Drawing.Size(96, 21);
			this.uccFechaDesde.TabIndex = 126;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtTotalPorCerrar);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtTotalCerrado);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtTotal);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridResultado);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridManagerView1);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 348);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(814, 255);
			this.ultraExplorerBarContainerControl1.TabIndex = 6;
			// 
			// txtTotalPorCerrar
			// 
			this.txtTotalPorCerrar.Enabled = false;
			this.txtTotalPorCerrar.Location = new System.Drawing.Point(576, 0);
			this.txtTotalPorCerrar.Name = "txtTotalPorCerrar";
			this.txtTotalPorCerrar.TabIndex = 120;
			this.txtTotalPorCerrar.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(480, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 16);
			this.label3.TabIndex = 119;
			this.label3.Text = "Total por Cerrar";
			// 
			// txtTotalCerrado
			// 
			this.txtTotalCerrado.Enabled = false;
			this.txtTotalCerrado.Location = new System.Drawing.Point(368, 0);
			this.txtTotalCerrado.Name = "txtTotalCerrado";
			this.txtTotalCerrado.TabIndex = 118;
			this.txtTotalCerrado.Text = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(280, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 16);
			this.label2.TabIndex = 117;
			this.label2.Text = "Total Cerrado";
			// 
			// txtTotal
			// 
			this.txtTotal.Enabled = false;
			this.txtTotal.Location = new System.Drawing.Point(168, 0);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.TabIndex = 116;
			this.txtTotal.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(8, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 16);
			this.label1.TabIndex = 115;
			this.label1.Text = "Total Técnico Provisorio";
			// 
			// gridResultado
			// 
			this.gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridResultado.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gridResultado.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.gridResultado.GroupByBoxVisible = false;
			this.gridResultado.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridResultado.Location = new System.Drawing.Point(0, 55);
			this.gridResultado.Name = "gridResultado";
			this.gridResultado.Size = new System.Drawing.Size(814, 200);
			this.gridResultado.TabIndex = 54;
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
			this.gridManagerView1.Location = new System.Drawing.Point(0, 24);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(831, 24);
			this.gridManagerView1.TabIndex = 53;
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
																							  this.toolBarButton1,
																							  this.toolBarButton2,
																							  this.toolBarButton3,
																							  this.tbbCancelar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(880, 28);
			this.toolBarStandar.TabIndex = 49;
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
			this.tbbSiguiente.Text = "Siguiente";
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.ImageIndex = 10;
			this.toolBarButton2.Text = "[F2] Buscar ahora";
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbCancelar
			// 
			this.tbbCancelar.ImageIndex = 7;
			this.tbbCancelar.Text = "Cancelar";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl5;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 26;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 180;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Filtros";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup3.Settings.ContainerHeight = 255;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Resultado";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(880, 464);
			this.ultraExplorerBar1.TabIndex = 52;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(8, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 16);
			this.label4.TabIndex = 133;
			this.label4.Text = "Estado";
			// 
			// mzCmbEstadosOrdenReparacion
			// 
			this.mzCmbEstadosOrdenReparacion.AutoComplete = true;
			this.mzCmbEstadosOrdenReparacion.DataSource = null;
			this.mzCmbEstadosOrdenReparacion.DisplayMember = "";
			this.mzCmbEstadosOrdenReparacion.DisplayMemberCaption = "";
			this.mzCmbEstadosOrdenReparacion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbEstadosOrdenReparacion.Location = new System.Drawing.Point(96, 152);
			this.mzCmbEstadosOrdenReparacion.MaxItemsDisplay = 50;
			this.mzCmbEstadosOrdenReparacion.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbEstadosOrdenReparacion.Name = "mzCmbEstadosOrdenReparacion";
			this.mzCmbEstadosOrdenReparacion.Size = new System.Drawing.Size(217, 21);
			this.mzCmbEstadosOrdenReparacion.SorterMember = "";
			this.mzCmbEstadosOrdenReparacion.TabIndex = 134;
			this.mzCmbEstadosOrdenReparacion.ValueMember = "";
			this.mzCmbEstadosOrdenReparacion.ValueMemberCaption = "";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(472, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 16);
			this.label5.TabIndex = 135;
			this.label5.Text = "Técnicos";
			// 
			// listBoxTecnicos
			// 
			this.listBoxTecnicos.Location = new System.Drawing.Point(552, 8);
			this.listBoxTecnicos.Name = "listBoxTecnicos";
			this.listBoxTecnicos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.listBoxTecnicos.Size = new System.Drawing.Size(232, 173);
			this.listBoxTecnicos.TabIndex = 136;
			// 
			// FrmConsultarEstadisticaOrdenReparacion
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(880, 492);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmConsultarEstadisticaOrdenReparacion";
			this.Text = "FrmConsultarEstadisticaOrdenReparacion";
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uccFechaHasta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uccFechaDesde)).EndInit();
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCmbEstadosOrdenReparacion)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region Construtores y Destructores

		public FrmConsultarEstadisticaOrdenReparacion(ConsultarEstadisticaOrdenReparacionController uiController)
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
				this.toolBarStandar.ButtonClick -= new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
				_uiController.DataChanged -=new EventHandler(RefreshData);
				uccFechaDesde.DataBindings.Clear();
				uccFechaHasta.DataBindings.Clear();
				rbFechaAltaOR.DataBindings.Clear();		
				rbFechaAsignacionTecnico.DataBindings.Clear();		
				rbFechaFactura.DataBindings.Clear();		
				rbFechaCierre.DataBindings.Clear();	
				rbFechaAltaOR.CheckedChanged -=new EventHandler(rbFechaAltaOR_CheckedChanged);
				rbFechaAsignacionTecnico.CheckedChanged -=new EventHandler(rbFechaAsignacionTecnico_CheckedChanged);
				rbFechaFactura.CheckedChanged -= new EventHandler(rbFechaFactura_CheckedChanged);
				rbFechaCierre.CheckedChanged -=new EventHandler(rbFechaCierre_CheckedChanged);
                rbFechaUltimaModifTecnico.CheckedChanged -=new EventHandler(rbFechaUltimaModifTecnico_CheckedChanged);

			}
			base.Dispose( disposing );
		}

		#endregion

		#region Variables Privadas
		private ConsultarEstadisticaOrdenReparacionController _uiController = null;
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

			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), gridResultado, this.Text);

			label5.Visible = _uiController.EsSupervisorST;
			listBoxTecnicos.Visible = _uiController.EsSupervisorST;
			KeyPreview = true;

		}

		private void InitializeData()
		{
			mzCmbEstadosOrdenReparacion.FillFromDataSource( _uiController.EstadosOrdenReparacion, _uiController.KeyValueEstadosOrdenReparacion,_uiController.KeyListEstadosOrdenReparacion,100, _uiController.KeyListEstadosOrdenReparacion );
			listBoxTecnicos.Items.Clear();
			listBoxTecnicos.Items.AddRange(_uiController.Tecnicos.ToArray());
		}

		private void InitEventHandlers()
		{
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			_uiController.DataChanged+=new EventHandler(RefreshData);
			rbFechaAltaOR.CheckedChanged +=new EventHandler(rbFechaAltaOR_CheckedChanged);
			rbFechaAsignacionTecnico.CheckedChanged +=new EventHandler(rbFechaAsignacionTecnico_CheckedChanged);
			rbFechaFactura.CheckedChanged += new EventHandler(rbFechaFactura_CheckedChanged);
			rbFechaCierre.CheckedChanged +=new EventHandler(rbFechaCierre_CheckedChanged);
			rbFechaUltimaModifTecnico.CheckedChanged +=new EventHandler(rbFechaUltimaModifTecnico_CheckedChanged);
            KeyDownManager KeyDownMan = new KeyDownManager(this);	

		}	
	
		private void InitDataBindings()
		{
			uccFechaDesde.DataBindings.Add("Value", _uiController, "FechaDesde");
			uccFechaHasta.DataBindings.Add("Value", _uiController, "FechaHasta");

			rbFechaAltaOR.DataBindings.Add("Checked", _uiController, "PorFechaAltaOrdenReparacion");		
			rbFechaAsignacionTecnico.DataBindings.Add("Checked", _uiController, "PorFechaAsignacionATecnico");		
			rbFechaFactura.DataBindings.Add("Checked", _uiController, "PorFechaFactura");		
			rbFechaCierre.DataBindings.Add("Checked", _uiController, "PorFechaCierre");		
			rbFechaUltimaModifTecnico.DataBindings.Add("Checked", _uiController, "PorFechaCierreTecnico");		

			mzCmbEstadosOrdenReparacion.DataBindings.Add("Value", _uiController, "IdEstadoOrdenReparacion");

			gridResultado.SetDataBinding(null, null);
			gridResultado.SetDataBinding(_uiController.Result, null);

			if(gridResultado.RootTable.Columns[ "BackColorRojo" ] != null)
			{
				Janus.Windows.GridEX.GridEXFormatStyle fs2= new Janus.Windows.GridEX.GridEXFormatStyle((Janus.Windows.GridEX.GridEXFormatStyle) gridResultado.RowFormatStyle);
				fs2.BackColor = System.Drawing.Color.Red;
				Janus.Windows.GridEX.ConditionOperator condOp2 = Janus.Windows.GridEX.ConditionOperator.Equal;				
				Janus.Windows.GridEX.GridEXFormatCondition cnd2 = new Janus.Windows.GridEX.GridEXFormatCondition( gridResultado.RootTable.Columns[ "BackColorRojo" ], condOp2, Convert.ToInt32(1));
				cnd2.FormatStyle = fs2;
				gridResultado.RootTable.FormatConditions.Add( cnd2 );
			}
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
		}

		public void KeyDownNext()
		{
		}

		#endregion

		#region Metodos Privados
		private void RefreshData()
		{
			Util.MoveFocus(ultraExplorerBarContainerControl2);
			this.Cursor = Cursors.WaitCursor;
			gridResultado.Focus();
			string idTecnicosSeleccionados = string.Empty;
			foreach(businessrules.Tecnico tecnico in listBoxTecnicos.SelectedItems)
				idTecnicosSeleccionados = idTecnicosSeleccionados + tecnico.IdTecnico + ",";
			_uiController.IdTecnicosSelecionados = idTecnicosSeleccionados;
			_uiController.RefreshData();
			this.Cursor = Cursors.Default;
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

					this.Execute();

					break;
				case 4:					
					RefreshData();
					break;
				case 6:					
					this.Close();
					break;

			}				
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

			txtTotal.Text = _uiController.TotalTecnicoProvisorio.ToString();
			txtTotalCerrado.Text = _uiController.TotalCerrado.ToString();
			txtTotalPorCerrar.Text = _uiController.TotalPorCerrar.ToString();
		}

		private void rbFechaAltaOR_CheckedChanged(object sender, EventArgs e)
		{
			_uiController.PorFechaAltaOrdenReparacion = rbFechaAltaOR.Checked;
		}

		private void rbFechaAsignacionTecnico_CheckedChanged(object sender, EventArgs e)
		{
			_uiController.PorFechaAsignacionATecnico = rbFechaAsignacionTecnico.Checked;
		}

		private void rbFechaFactura_CheckedChanged(object sender, EventArgs e)
		{
			_uiController.PorFechaFactura = rbFechaFactura.Checked;
		}

		private void rbFechaCierre_CheckedChanged(object sender, EventArgs e)
		{
			_uiController.PorFechaCierre = rbFechaCierre.Checked;
		}

		private void rbFechaUltimaModifTecnico_CheckedChanged(object sender, EventArgs e)
		{
			_uiController.PorFechaCierreTecnico = rbFechaUltimaModifTecnico.Checked;
		}
	}
}

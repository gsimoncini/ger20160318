using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.forms.classes;
using mz.erp.ui.controllers;
using mz.erp.commontypes;
using mz.erp.ui.utility;

namespace mz.erp.ui.forms

{
	/// <summary>
	/// Descripción breve de FrmConsultarControlCajas.
	/// </summary>
	public class FrmConsultarControlCajas : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.ImageList imglStandar;
		protected System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.ToolBarButton toolBarButton8;
		private System.Windows.Forms.ToolBarButton toolBarButton9;
		protected System.Windows.Forms.ToolBarButton toolBarButton10;
		private System.Windows.Forms.ToolBarButton toolBarButton11;
		private System.Windows.Forms.ToolBarButton toolBarButton12;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton tbbReiniciarFiltros;
		private System.Windows.Forms.ToolBarButton tbbSeparadorCancelar;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private System.Windows.Forms.ToolBarButton tbbSeparadorGuardar;
		private System.Windows.Forms.ToolBarButton tbbGuardar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.GroupBox grupoAperturaCierre;
		private System.Windows.Forms.RadioButton radioBTodas;
		private System.Windows.Forms.RadioButton radioBSoloCerradas;
		private System.Windows.Forms.RadioButton radioBSoloAbiertas;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo dtFechaCierre;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo dtFechaApertura;
		private System.Windows.Forms.Label lHasta;
		private System.Windows.Forms.Label lDesde;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private Janus.Windows.GridEX.GridEX gridResultado;
		private mz.erp.ui.controls.mzGridConfigPanel mzGridConfigPanel1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.Label labelTarea;
		private Infragistics.Win.Misc.UltraButton bNingunoCaja;
		private Infragistics.Win.Misc.UltraButton bTodosCaja;
		private Janus.Windows.GridEX.GridEX gridCajas;
		private System.Windows.Forms.Label label2;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmConsultarControlCajas));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.bNingunoCaja = new Infragistics.Win.Misc.UltraButton();
			this.bTodosCaja = new Infragistics.Win.Misc.UltraButton();
			this.gridCajas = new Janus.Windows.GridEX.GridEX();
			this.label2 = new System.Windows.Forms.Label();
			this.grupoAperturaCierre = new System.Windows.Forms.GroupBox();
			this.radioBTodas = new System.Windows.Forms.RadioButton();
			this.radioBSoloCerradas = new System.Windows.Forms.RadioButton();
			this.radioBSoloAbiertas = new System.Windows.Forms.RadioButton();
			this.dtFechaCierre = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.dtFechaApertura = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.lHasta = new System.Windows.Forms.Label();
			this.lDesde = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.gridResultado = new Janus.Windows.GridEX.GridEX();
			this.mzGridConfigPanel1 = new mz.erp.ui.controls.mzGridConfigPanel();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton8 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton10 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton11 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton12 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.tbbReiniciarFiltros = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparadorGuardar = new System.Windows.Forms.ToolBarButton();
			this.tbbGuardar = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparadorCancelar = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridCajas)).BeginInit();
			this.grupoAperturaCierre.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtFechaCierre)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtFechaApertura)).BeginInit();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, -9);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(798, 25);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(798, 23);
			this.labelTarea.TabIndex = 1;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.bNingunoCaja);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.bTodosCaja);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridCajas);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.grupoAperturaCierre);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 44);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(894, 260);
			this.ultraExplorerBarContainerControl1.TabIndex = 1;
			// 
			// bNingunoCaja
			// 
			this.bNingunoCaja.AcceptsFocus = false;
			this.bNingunoCaja.Location = new System.Drawing.Point(160, 232);
			this.bNingunoCaja.Name = "bNingunoCaja";
			this.bNingunoCaja.Size = new System.Drawing.Size(64, 22);
			this.bNingunoCaja.TabIndex = 11;
			this.bNingunoCaja.TabStop = false;
			this.bNingunoCaja.Text = "&Ninguno";
			// 
			// bTodosCaja
			// 
			this.bTodosCaja.AcceptsFocus = false;
			this.bTodosCaja.Location = new System.Drawing.Point(96, 232);
			this.bTodosCaja.Name = "bTodosCaja";
			this.bTodosCaja.Size = new System.Drawing.Size(64, 22);
			this.bTodosCaja.TabIndex = 10;
			this.bTodosCaja.TabStop = false;
			this.bTodosCaja.Text = "&Todos";
			// 
			// gridCajas
			// 
			this.gridCajas.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridCajas.GroupByBoxVisible = false;
			this.gridCajas.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridCajas.Location = new System.Drawing.Point(8, 104);
			this.gridCajas.Name = "gridCajas";
			this.gridCajas.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridCajas.Size = new System.Drawing.Size(296, 128);
			this.gridCajas.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(8, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 14);
			this.label2.TabIndex = 12;
			this.label2.Text = "Cajas";
			// 
			// grupoAperturaCierre
			// 
			this.grupoAperturaCierre.BackColor = System.Drawing.Color.Transparent;
			this.grupoAperturaCierre.Controls.Add(this.radioBTodas);
			this.grupoAperturaCierre.Controls.Add(this.radioBSoloCerradas);
			this.grupoAperturaCierre.Controls.Add(this.radioBSoloAbiertas);
			this.grupoAperturaCierre.Controls.Add(this.dtFechaCierre);
			this.grupoAperturaCierre.Controls.Add(this.dtFechaApertura);
			this.grupoAperturaCierre.Controls.Add(this.lHasta);
			this.grupoAperturaCierre.Controls.Add(this.lDesde);
			this.grupoAperturaCierre.Location = new System.Drawing.Point(8, 8);
			this.grupoAperturaCierre.Name = "grupoAperturaCierre";
			this.grupoAperturaCierre.Size = new System.Drawing.Size(912, 72);
			this.grupoAperturaCierre.TabIndex = 0;
			this.grupoAperturaCierre.TabStop = false;
			this.grupoAperturaCierre.Text = "Estado";
			// 
			// radioBTodas
			// 
			this.radioBTodas.Location = new System.Drawing.Point(56, 46);
			this.radioBTodas.Name = "radioBTodas";
			this.radioBTodas.Size = new System.Drawing.Size(168, 16);
			this.radioBTodas.TabIndex = 2;
			this.radioBTodas.Text = "Todas (abiertas / cerradas)";
			// 
			// radioBSoloCerradas
			// 
			this.radioBSoloCerradas.Location = new System.Drawing.Point(56, 30);
			this.radioBSoloCerradas.Name = "radioBSoloCerradas";
			this.radioBSoloCerradas.Size = new System.Drawing.Size(168, 16);
			this.radioBSoloCerradas.TabIndex = 1;
			this.radioBSoloCerradas.Text = "Sólo cajas cerradas";
			// 
			// radioBSoloAbiertas
			// 
			this.radioBSoloAbiertas.Location = new System.Drawing.Point(56, 14);
			this.radioBSoloAbiertas.Name = "radioBSoloAbiertas";
			this.radioBSoloAbiertas.Size = new System.Drawing.Size(168, 16);
			this.radioBSoloAbiertas.TabIndex = 0;
			this.radioBSoloAbiertas.Text = "Sólo cajas abiertas";
			// 
			// dtFechaCierre
			// 
			dateButton1.Caption = "Today";
			this.dtFechaCierre.DateButtons.Add(dateButton1);
			this.dtFechaCierre.Location = new System.Drawing.Point(720, 30);
			this.dtFechaCierre.Name = "dtFechaCierre";
			this.dtFechaCierre.NonAutoSizeHeight = 23;
			this.dtFechaCierre.Size = new System.Drawing.Size(96, 21);
			this.dtFechaCierre.TabIndex = 4;
			this.dtFechaCierre.Visible = false;
			// 
			// dtFechaApertura
			// 
			dateButton2.Caption = "Today";
			this.dtFechaApertura.DateButtons.Add(dateButton2);
			this.dtFechaApertura.Location = new System.Drawing.Point(408, 30);
			this.dtFechaApertura.Name = "dtFechaApertura";
			this.dtFechaApertura.NonAutoSizeHeight = 23;
			this.dtFechaApertura.Size = new System.Drawing.Size(96, 21);
			this.dtFechaApertura.TabIndex = 3;
			this.dtFechaApertura.Visible = false;
			// 
			// lHasta
			// 
			this.lHasta.BackColor = System.Drawing.Color.Transparent;
			this.lHasta.Location = new System.Drawing.Point(664, 32);
			this.lHasta.Name = "lHasta";
			this.lHasta.Size = new System.Drawing.Size(56, 16);
			this.lHasta.TabIndex = 8;
			this.lHasta.Text = "Hasta";
			this.lHasta.Visible = false;
			// 
			// lDesde
			// 
			this.lDesde.BackColor = System.Drawing.Color.Transparent;
			this.lDesde.Location = new System.Drawing.Point(352, 32);
			this.lDesde.Name = "lDesde";
			this.lDesde.Size = new System.Drawing.Size(56, 16);
			this.lDesde.TabIndex = 7;
			this.lDesde.Text = "Desde";
			this.lDesde.Visible = false;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridManagerView1);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridResultado);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.mzGridConfigPanel1);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 363);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(894, 312);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.BackColor = System.Drawing.Color.Transparent;
			this.gridManagerView1.Location = new System.Drawing.Point(0, 0);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(960, 24);
			this.gridManagerView1.TabIndex = 3;
			// 
			// gridResultado
			// 
			this.gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridResultado.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gridResultado.HeaderFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Empty;
			this.gridResultado.HeaderFormatStyle.BackColor = System.Drawing.Color.Transparent;
			this.gridResultado.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridResultado.Location = new System.Drawing.Point(0, 32);
			this.gridResultado.Name = "gridResultado";
			this.gridResultado.ShowErrors = false;
			this.gridResultado.Size = new System.Drawing.Size(894, 280);
			this.gridResultado.TabIndex = 1;
			this.gridResultado.ThemedAreas = ((Janus.Windows.GridEX.ThemedArea)(((((Janus.Windows.GridEX.ThemedArea.ScrollBars | Janus.Windows.GridEX.ThemedArea.EditControls) 
				| Janus.Windows.GridEX.ThemedArea.Headers) 
				| Janus.Windows.GridEX.ThemedArea.TreeGliphs) 
				| Janus.Windows.GridEX.ThemedArea.ControlBorder)));
			// 
			// mzGridConfigPanel1
			// 
			this.mzGridConfigPanel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.mzGridConfigPanel1.GridSource = null;
			this.mzGridConfigPanel1.LayoutDefault = null;
			this.mzGridConfigPanel1.LoadFromFile = true;
			this.mzGridConfigPanel1.Location = new System.Drawing.Point(624, 40);
			this.mzGridConfigPanel1.Name = "mzGridConfigPanel1";
			this.mzGridConfigPanel1.ProcessName = null;
			this.mzGridConfigPanel1.Size = new System.Drawing.Size(304, 48);
			this.mzGridConfigPanel1.TabIndex = 2;
			this.mzGridConfigPanel1.TaskName = null;
			this.mzGridConfigPanel1.Visible = false;
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
																							  this.toolBarButton7,
																							  this.toolBarButton8,
																							  this.toolBarButton9,
																							  this.toolBarButton10,
																							  this.toolBarButton11,
																							  this.toolBarButton12,
																							  this.toolBarButton1,
																							  this.tbbReiniciarFiltros,
																							  this.tbbSeparadorGuardar,
																							  this.tbbGuardar,
																							  this.tbbSeparadorCancelar,
																							  this.tbbCancelar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(960, 28);
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
			// toolBarButton7
			// 
			this.toolBarButton7.ImageIndex = 0;
			this.toolBarButton7.Visible = false;
			// 
			// toolBarButton8
			// 
			this.toolBarButton8.ImageIndex = 1;
			this.toolBarButton8.Visible = false;
			// 
			// toolBarButton9
			// 
			this.toolBarButton9.ImageIndex = 2;
			this.toolBarButton9.Visible = false;
			// 
			// toolBarButton10
			// 
			this.toolBarButton10.ImageIndex = 3;
			this.toolBarButton10.Visible = false;
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
			// toolBarButton1
			// 
			this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbReiniciarFiltros
			// 
			this.tbbReiniciarFiltros.ImageIndex = 5;
			this.tbbReiniciarFiltros.Text = "Reiniciar Filtros de Busqueda";
			// 
			// tbbSeparadorGuardar
			// 
			this.tbbSeparadorGuardar.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbGuardar
			// 
			this.tbbGuardar.ImageIndex = 4;
			this.tbbGuardar.Text = "Guardar";
			// 
			// tbbSeparadorCancelar
			// 
			this.tbbSeparadorCancelar.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
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
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 25;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 260;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Filtros";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup3.Settings.ContainerHeight = 312;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Resultado";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(960, 536);
			this.ultraExplorerBar1.TabIndex = 22;
			// 
			// FrmConsultarControlCajas
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(960, 564);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmConsultarControlCajas";
			this.Text = "FrmConsultarControlCajas";
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridCajas)).EndInit();
			this.grupoAperturaCierre.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtFechaCierre)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtFechaApertura)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Constructores y Destructores
		
		public FrmConsultarControlCajas(ConsultarControlCajasController controller)
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

		#region Variables Privadas
		private ConsultarControlCajasController _uiController = null;
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

			radioBSoloCerradas.Enabled = _uiController.PermiteConsultarHistorico;
			radioBTodas.Enabled = _uiController.PermiteConsultarHistorico;

			gridCajas.LayoutData = _uiController.LayoutFiltroCajas;

			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), gridResultado, this.Text);

			tbbGuardar.Enabled = _uiController.HabilitaAuditadoSupervisor || _uiController.HabilitaAuditadoGerente;
			tbbSiguiente.Enabled = _uiController.HabilitaAuditadoSupervisor || _uiController.HabilitaAuditadoGerente;

		}

		private void InitializeData()
		{
		}

		private void InitEventHandlers()
		{
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			this.bTodosCaja.Click += new System.EventHandler(this.bTodosCaja_Click);
			this.bNingunoCaja.Click += new System.EventHandler(this.bNingunoCaja_Click);
			radioBSoloAbiertas.Click += new EventHandler(radioCheck_Click);
			radioBSoloCerradas.Click += new EventHandler(radioCheck_Click);
			radioBTodas.Click += new EventHandler(radioCheck_Click);
			gridResultado.EditingCell+=new Janus.Windows.GridEX.EditingCellEventHandler(gridResultado_EditingCell);
            //Cristian Tarea 0000050 20110310
            this.dtFechaApertura.ValueChanged += new EventHandler(FechaDesde_ValueChanged);
            //Fin Cristian
            //Cristian Tarea 0000146 20110725
            this.dtFechaCierre.ValueChanged += new EventHandler(dtFechaCierre_ValueChanged);
            //Fin Cristian

        }

        //Cristian Tarea 0000146 20110725
        void dtFechaCierre_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(dtFechaCierre.Value)), true);
            this.dtFechaApertura.Value = _uiController.FechaApertura;
        }
        //Fin Cristian Tarea 0000146
        //Cristian Tarea 0000050 20110310
        void FechaDesde_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(dtFechaApertura.Value)),false);
            this.dtFechaCierre.Value = _uiController.FechaCierre;

        }
        //Fin Cristian
	
		private void InitDataBindings()
		{
			gridCajas.DataBindings.Clear();
			radioBSoloAbiertas.DataBindings.Clear();
			radioBSoloCerradas.DataBindings.Clear();
			radioBTodas.DataBindings.Clear();

			gridCajas.SetDataBinding( _uiController.FiltroCajas , null );
			radioBSoloAbiertas.DataBindings.Add("Checked", _uiController , "CheckSoloAbiertas");
			radioBSoloCerradas.DataBindings.Add("Checked", _uiController , "CheckSoloCerradas");
			radioBTodas.DataBindings.Add("Checked", _uiController , "CheckTodas");

			BindingController.Bind( dtFechaApertura,"Value",_uiController,"FechaApertura");
			BindingController.Bind( dtFechaCierre,"Value",_uiController,"FechaCierre");
			dtFechaApertura.DataBindings.Add( "Enabled", _uiController, "AllowFechas");
			dtFechaCierre.DataBindings.Add( "Enabled", _uiController, "AllowFechas");

			gridResultado.SetDataBinding(null, null);
			gridResultado.SetDataBinding(_uiController.Result, null);

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
		
		private void ResetFilters()
		{
			radioBSoloAbiertas.Checked = true;
			radioBSoloCerradas.Checked = false;
			radioBTodas.Checked = false;
			_uiController.CheckSoloAbiertas = true;
			_uiController.CheckSoloCerradas = false;
			_uiController.CheckTodas = false;

			dtFechaApertura.Visible = false;
			dtFechaCierre.Visible = false;
			lDesde.Visible = false;
			lHasta.Visible = false;

			gridCajas.DataBindings.Clear();
			gridCajas.SetDataBinding( _uiController.FiltroCajas , null );

			gridResultado.SetDataBinding(null, null);
			gridResultado.Refresh();
		}
		
		private void ExecuteQuery()
		{
			this.Cursor = Cursors.WaitCursor;
			Util.MoveFocus(this.ultraExplorerBarContainerControl1);
			gridCajas.UpdateData();
			_uiController.RefreshData();
			gridResultado.SetDataBinding(null, null);
			gridResultado.SetDataBinding(_uiController.Result, null);
			if (gridManagerView1.AllowExportExcel || gridManagerView1.AllowSortByAgregateColumn)
				gridManagerView1.SetTable(_uiController.Result);
			this.Cursor = Cursors.Default;
		}

		private void SaveChanges()
		{	
			this.Cursor = Cursors.WaitCursor;
			Util.MoveFocus(this.ultraExplorerBarContainerControl1);
			_uiController.Execute();
			this.Cursor = Cursors.Default;
		}

		#endregion


		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					Previous();
					break;
				case 2: //Siguiente
					SaveChanges();
					break;
					/*Nueva Busqueda*/					
				case 10:
					ResetFilters();
					break;
				case 8: //Buscar
					ExecuteQuery();
					break;
				case 12: //Guardar
					SaveChanges();
					break;
				case 14: //Cancelar
					CloseForm();
					break;
			}				
		}

		private void bTodosCaja_Click(object sender, System.EventArgs e)
		{
			_uiController.TildarTodosCaja();
			gridCajas.DataBindings.Clear();
			gridCajas.SetDataBinding( _uiController.FiltroCajas , null );
		}

		private void bNingunoCaja_Click(object sender, System.EventArgs e)
		{
			_uiController.TildarNingunoCaja();
			gridCajas.DataBindings.Clear();
			gridCajas.SetDataBinding( _uiController.FiltroCajas , null );
		}

		private void radioCheck_Click(object sender, EventArgs e)
		{
			RadioButton radio = (RadioButton) sender;
			if (radio.Checked)
			{	
				_uiController.CheckSoloAbiertas = radio.Name.Equals("radioBSoloAbiertas");
				_uiController.CheckSoloCerradas = radio.Name.Equals("radioBSoloCerradas");
				bool _aux = _uiController.AllowFechas;
				dtFechaApertura.Visible = _aux;
				dtFechaCierre.Visible = _aux;
				lDesde.Visible= _aux;
				lHasta.Visible= _aux;
			}
		}

		private void gridResultado_EditingCell(object sender, Janus.Windows.GridEX.EditingCellEventArgs e)
		{
			if(e.Column.Key.Equals("AuditadoSupervisor") && !_uiController.HabilitaAuditadoSupervisor)
				e.Cancel = true;

			if(e.Column.Key.Equals("AuditadoGerente") && !_uiController.HabilitaAuditadoGerente)
				e.Cancel = true;
		}
	}
}

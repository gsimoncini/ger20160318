using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.forms.classes;
using mz.erp.ui.controllers;
using mz.erp.ui.utility;
using mz.erp.commontypes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmConsultarProductosConPreciosModificados.
	/// </summary>
	public class FrmConsultarProductosConPreciosModificados : System.Windows.Forms.Form, ITaskForm
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
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo uccFechaPcioCostoHasta;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo uccFechaPcioCostoDesde;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo uccFechaPcioVentaHasta;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo uccFechaPcioVentaDesde;
		private mz.erp.ui.controls.mzProductosControl mzProductosControl1;
		private System.Windows.Forms.Label label11;
		private mz.erp.ui.controls.HierarchicalSearchControl hierarchicalSearchControl1;
		private System.Windows.Forms.Label label4;
		private mz.erp.ui.controls.mzComboEditor mzComboListaDePrecios;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		protected Janus.Windows.GridEX.GridEX gridResultado;
		private System.Windows.Forms.CheckBox chckPorUltimaFechaModifPcioCosto;
		private System.Windows.Forms.CheckBox chckPorUltimaFechaModifPcioVta;
		private System.Windows.Forms.ToolBarButton tbbReiniciarFiltros;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
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
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton3 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton4 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmConsultarProductosConPreciosModificados));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.chckPorUltimaFechaModifPcioVta = new System.Windows.Forms.CheckBox();
			this.chckPorUltimaFechaModifPcioCosto = new System.Windows.Forms.CheckBox();
			this.mzComboListaDePrecios = new mz.erp.ui.controls.mzComboEditor();
			this.label4 = new System.Windows.Forms.Label();
			this.hierarchicalSearchControl1 = new mz.erp.ui.controls.HierarchicalSearchControl();
			this.mzProductosControl1 = new mz.erp.ui.controls.mzProductosControl();
			this.label11 = new System.Windows.Forms.Label();
			this.uccFechaPcioVentaDesde = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.uccFechaPcioVentaHasta = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.uccFechaPcioCostoHasta = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.uccFechaPcioCostoDesde = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.gridResultado = new Janus.Windows.GridEX.GridEX();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.tbbReiniciarFiltros = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzComboListaDePrecios)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uccFechaPcioVentaDesde)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uccFechaPcioVentaHasta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uccFechaPcioCostoHasta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uccFechaPcioCostoDesde)).BeginInit();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
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
			this.ultraExplorerBarContainerControl2.Controls.Add(this.chckPorUltimaFechaModifPcioVta);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.chckPorUltimaFechaModifPcioCosto);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.mzComboListaDePrecios);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label4);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.hierarchicalSearchControl1);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.mzProductosControl1);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label11);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.uccFechaPcioVentaDesde);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.uccFechaPcioVentaHasta);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label10);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label9);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label8);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label5);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label6);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label7);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.uccFechaPcioCostoHasta);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.uccFechaPcioCostoDesde);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 109);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(814, 140);
			this.ultraExplorerBarContainerControl2.TabIndex = 5;
			// 
			// chckPorUltimaFechaModifPcioVta
			// 
			this.chckPorUltimaFechaModifPcioVta.BackColor = System.Drawing.Color.Transparent;
			this.chckPorUltimaFechaModifPcioVta.Location = new System.Drawing.Point(432, 32);
			this.chckPorUltimaFechaModifPcioVta.Name = "chckPorUltimaFechaModifPcioVta";
			this.chckPorUltimaFechaModifPcioVta.Size = new System.Drawing.Size(16, 24);
			this.chckPorUltimaFechaModifPcioVta.TabIndex = 6;
			// 
			// chckPorUltimaFechaModifPcioCosto
			// 
			this.chckPorUltimaFechaModifPcioCosto.BackColor = System.Drawing.Color.Transparent;
			this.chckPorUltimaFechaModifPcioCosto.Location = new System.Drawing.Point(432, 8);
			this.chckPorUltimaFechaModifPcioCosto.Name = "chckPorUltimaFechaModifPcioCosto";
			this.chckPorUltimaFechaModifPcioCosto.Size = new System.Drawing.Size(16, 24);
			this.chckPorUltimaFechaModifPcioCosto.TabIndex = 2;
			// 
			// mzComboListaDePrecios
			// 
			this.mzComboListaDePrecios.AutoComplete = true;
			this.mzComboListaDePrecios.DataSource = null;
			this.mzComboListaDePrecios.DisplayMember = "";
			this.mzComboListaDePrecios.DisplayMemberCaption = "";
			this.mzComboListaDePrecios.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzComboListaDePrecios.Location = new System.Drawing.Point(552, 8);
			this.mzComboListaDePrecios.MaxItemsDisplay = 7;
			this.mzComboListaDePrecios.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzComboListaDePrecios.Name = "mzComboListaDePrecios";
			this.mzComboListaDePrecios.Size = new System.Drawing.Size(224, 21);
			this.mzComboListaDePrecios.SorterMember = "";
			this.mzComboListaDePrecios.TabIndex = 3;
			this.mzComboListaDePrecios.ValueMember = "";
			this.mzComboListaDePrecios.ValueMemberCaption = "";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(456, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 16);
			this.label4.TabIndex = 144;
			this.label4.Text = "Lista  de Precios";
			// 
			// hierarchicalSearchControl1
			// 
			this.hierarchicalSearchControl1.BackColor = System.Drawing.Color.Transparent;
			this.hierarchicalSearchControl1.Location = new System.Drawing.Point(8, 96);
			this.hierarchicalSearchControl1.Name = "hierarchicalSearchControl1";
			this.hierarchicalSearchControl1.Size = new System.Drawing.Size(784, 95);
			this.hierarchicalSearchControl1.TabIndex = 8;
			// 
			// mzProductosControl1
			// 
			this.mzProductosControl1.BackColor = System.Drawing.Color.Transparent;
			this.mzProductosControl1.EnabledCantidad = true;
			this.mzProductosControl1.EnabledListaDePrecio = true;
			this.mzProductosControl1.Location = new System.Drawing.Point(96, 56);
			this.mzProductosControl1.Name = "mzProductosControl1";
			this.mzProductosControl1.Size = new System.Drawing.Size(408, 32);
			this.mzProductosControl1.TabIndex = 7;
			this.mzProductosControl1.VisibleCantidad = true;
			this.mzProductosControl1.VisibleComboListaDePrecios = true;
			this.mzProductosControl1.VisibleComboTipoDePrecioDeCosto = false;
			this.mzProductosControl1.VisiblePrecios = true;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Location = new System.Drawing.Point(8, 64);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(69, 16);
			this.label11.TabIndex = 141;
			this.label11.Text = "Producto";
			// 
			// uccFechaPcioVentaDesde
			// 
			dateButton1.Caption = "Today";
			this.uccFechaPcioVentaDesde.DateButtons.Add(dateButton1);
			this.uccFechaPcioVentaDesde.Location = new System.Drawing.Point(160, 32);
			this.uccFechaPcioVentaDesde.Name = "uccFechaPcioVentaDesde";
			this.uccFechaPcioVentaDesde.NonAutoSizeHeight = 23;
			this.uccFechaPcioVentaDesde.Size = new System.Drawing.Size(96, 21);
			this.uccFechaPcioVentaDesde.TabIndex = 4;
			// 
			// uccFechaPcioVentaHasta
			// 
			dateButton2.Caption = "Today";
			this.uccFechaPcioVentaHasta.DateButtons.Add(dateButton2);
			this.uccFechaPcioVentaHasta.Location = new System.Drawing.Point(328, 32);
			this.uccFechaPcioVentaHasta.Name = "uccFechaPcioVentaHasta";
			this.uccFechaPcioVentaHasta.NonAutoSizeHeight = 23;
			this.uccFechaPcioVentaHasta.Size = new System.Drawing.Size(96, 21);
			this.uccFechaPcioVentaHasta.TabIndex = 5;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(104, 8);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(48, 16);
			this.label10.TabIndex = 138;
			this.label10.Text = "Desde";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(104, 32);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 16);
			this.label9.TabIndex = 137;
			this.label9.Text = "Desde";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(272, 8);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 16);
			this.label8.TabIndex = 136;
			this.label8.Text = "Hasta";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(272, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 16);
			this.label5.TabIndex = 135;
			this.label5.Text = "Hasta";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(8, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 16);
			this.label6.TabIndex = 128;
			this.label6.Text = "Precio de Venta";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(8, 8);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 16);
			this.label7.TabIndex = 129;
			this.label7.Text = "Precio de Costo";
			// 
			// uccFechaPcioCostoHasta
			// 
			dateButton3.Caption = "Today";
			this.uccFechaPcioCostoHasta.DateButtons.Add(dateButton3);
			this.uccFechaPcioCostoHasta.Location = new System.Drawing.Point(328, 8);
			this.uccFechaPcioCostoHasta.Name = "uccFechaPcioCostoHasta";
			this.uccFechaPcioCostoHasta.NonAutoSizeHeight = 23;
			this.uccFechaPcioCostoHasta.Size = new System.Drawing.Size(96, 21);
			this.uccFechaPcioCostoHasta.TabIndex = 1;
			// 
			// uccFechaPcioCostoDesde
			// 
			dateButton4.Caption = "Today";
			this.uccFechaPcioCostoDesde.DateButtons.Add(dateButton4);
			this.uccFechaPcioCostoDesde.Location = new System.Drawing.Point(160, 8);
			this.uccFechaPcioCostoDesde.Name = "uccFechaPcioCostoDesde";
			this.uccFechaPcioCostoDesde.NonAutoSizeHeight = 23;
			this.uccFechaPcioCostoDesde.Size = new System.Drawing.Size(96, 21);
			this.uccFechaPcioCostoDesde.TabIndex = 0;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridManagerView1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridResultado);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 308);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(814, 255);
			this.ultraExplorerBarContainerControl1.TabIndex = 6;
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
			this.gridManagerView1.Location = new System.Drawing.Point(8, 0);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(864, 24);
			this.gridManagerView1.TabIndex = 122;
			// 
			// gridResultado
			// 
			this.gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridResultado.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gridResultado.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.gridResultado.GroupByBoxVisible = false;
			this.gridResultado.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridResultado.Location = new System.Drawing.Point(0, 31);
			this.gridResultado.Name = "gridResultado";
			this.gridResultado.Size = new System.Drawing.Size(814, 224);
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
																							  this.toolBarButton1,
																							  this.toolBarButton2,
																							  this.toolBarButton5,
																							  this.tbbReiniciarFiltros,
																							  this.toolBarButton3,
																							  this.tbbCancelar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(880, 28);
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
			this.tbbSiguiente.Text = "Siguiente";
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.ImageIndex = 2;
			this.toolBarButton2.Text = "[F5] Buscar ahora";
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbReiniciarFiltros
			// 
			this.tbbReiniciarFiltros.ImageIndex = 5;
			this.tbbReiniciarFiltros.Text = "Reiniciar Filtros de Busqueda";
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
			ultraExplorerBarGroup2.Settings.ContainerHeight = 140;
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
			this.ultraExplorerBar1.TabIndex = 53;
			// 
			// FrmConsultarProductosConPreciosModificados
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(880, 492);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmConsultarProductosConPreciosModificados";
			this.Text = "FrmConsultarProductosConPreciosModificados";
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzComboListaDePrecios)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uccFechaPcioVentaDesde)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uccFechaPcioVentaHasta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uccFechaPcioCostoHasta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uccFechaPcioCostoDesde)).EndInit();
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Constructores y Destructores		

		public FrmConsultarProductosConPreciosModificados(ConsultarProductosConPreciosModificadosController uiController)
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
		private ConsultarProductosConPreciosModificadosController _uiController = null;
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

			mzProductosControl1.SetProcess(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), "");
			this.hierarchicalSearchControl1.Build_UI("PRODUCTOS",_uiController.AllowMultipleSelect);	
			mz.erp.ui.forms.classes.ContainerManager.UpdateSize(this.ultraExplorerBarContainerControl2, hierarchicalSearchControl1);

			KeyPreview = true;

		}

		private void InitializeData()
		{
			mzComboListaDePrecios.FillFromDataSource( _uiController.ListaDePrecios, _uiController.KeyValueListaDePrecios, _uiController.KeyListListaDePrecios, 100, _uiController.KeyListListaDePrecios);
			if(!_uiController.ListaDePreciosHabilitadas)
				mzComboListaDePrecios.Enabled = false;
			chckPorUltimaFechaModifPcioCosto.Checked = _uiController.PorUltimaFechaModifPcioCosto;
			chckPorUltimaFechaModifPcioVta.Checked = _uiController.PorUltimaFechaModifPcioVta;
            
		}

		private void InitEventHandlers()
		{
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			_uiController.DataChanged+=new EventHandler(RefreshData);
			hierarchicalSearchControl1.OnSelected+=new EventHandler(hierarchicalSearchControl1_OnSelected);
			chckPorUltimaFechaModifPcioCosto.CheckedChanged += new EventHandler(chckPorUltimaFechaModifPcioCosto_CheckedChanged);
			chckPorUltimaFechaModifPcioVta.CheckedChanged += new EventHandler(chckPorUltimaFechaModifPcioVta_CheckedChanged);
			this.KeyDown += new KeyEventHandler(KeyDownBehavior);
            KeyDownManager KeyDownMan = new KeyDownManager(this);           
            //Cristian Tarea 0000050 20110310
            this.uccFechaPcioCostoDesde.ValueChanged += new EventHandler(uccFechaPcioCostoDesde_ValueChanged);
            this.uccFechaPcioVentaDesde.ValueChanged += new EventHandler(uccFechaPcioVentaDesde_ValueChanged);
            //Fin Cristian
            //Cristian Tarea 0000146
            this.uccFechaPcioCostoHasta.ValueChanged += new EventHandler(uccFechaPcioCostoHasta_ValueChanged);
            this.uccFechaPcioVentaHasta.ValueChanged += new EventHandler(uccFechaPcioVentaHasta_ValueChanged);
            //Fin Cristian 


        }


        //Cristian Tarea 0000146 20110725
        void uccFechaPcioVentaHasta_ValueChanged(object sender, EventArgs e)
        {
            if (uccFechaPcioVentaHasta.Value != (System.DBNull.Value))
            {
                _uiController.updateFechas((Convert.ToDateTime(uccFechaPcioVentaHasta.Value)), "VENTA",true);
                this.uccFechaPcioVentaDesde.Value = _uiController.FechaUltimaModifPcioVtaDesde;
            }
        }

        void uccFechaPcioCostoHasta_ValueChanged(object sender, EventArgs e)
        {
            if (uccFechaPcioCostoHasta.Value != (System.DBNull.Value))
            {
                _uiController.updateFechas((Convert.ToDateTime(uccFechaPcioCostoHasta.Value)), "COSTO", true);
                this.uccFechaPcioCostoDesde.Value = _uiController.FechaUltimaModifPcioCostoDesde;
            }
        }
        //fin Cristian 20110725

        //Cristian Tarea 0000050 20110310
        void uccFechaPcioVentaDesde_ValueChanged(object sender, EventArgs e)
        {
            if (uccFechaPcioVentaDesde.Value != (System.DBNull.Value))
            {
                _uiController.updateFechas((Convert.ToDateTime(uccFechaPcioVentaDesde.Value)), "COSTO",false);
                this.uccFechaPcioVentaHasta.Value = _uiController.FechaUltimaModifPcioVtaHasta;
            }
        }

        void uccFechaPcioCostoDesde_ValueChanged(object sender, EventArgs e)
        {
            if (uccFechaPcioCostoDesde.Value != (System.DBNull.Value))
            {
                _uiController.updateFechas((Convert.ToDateTime(uccFechaPcioCostoDesde.Value)), "VENTA",false);
                this.uccFechaPcioCostoHasta.Value = _uiController.FechaUltimaModifPcioCostoHasta;
            }
        }
	    //Fin Cristian


		private void InitDataBindings()
		{
			mzProductosControl1.AddObjectListener( (IObserver)_uiController );
			mzComboListaDePrecios.DataBindings.Add("Value", _uiController, "IdListaDePrecios");
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
				this.chckPorUltimaFechaModifPcioCosto_CheckedChanged(this, new EventArgs());
				this.chckPorUltimaFechaModifPcioVta_CheckedChanged(this, new EventArgs());
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

		#region Metodos Privados
		private void RefreshData()
		{
			Util.MoveFocus(ultraExplorerBarContainerControl2);
			this.Cursor = Cursors.WaitCursor;
			gridResultado.Focus();
			if(_uiController.PorUltimaFechaModifPcioCosto)
			{
				_uiController.FechaUltimaModifPcioCostoDesde = (DateTime)uccFechaPcioCostoDesde.Value;
				_uiController.FechaUltimaModifPcioCostoHasta = (DateTime)uccFechaPcioCostoHasta.Value;
			}
			else
			{
				_uiController.FechaUltimaModifPcioCostoDesde = DateTime.MinValue;
				_uiController.FechaUltimaModifPcioCostoHasta = DateTime.MinValue;
			}

			if(_uiController.PorUltimaFechaModifPcioVta)
			{
				_uiController.FechaUltimaModifPcioVtaDesde = (DateTime)uccFechaPcioVentaDesde.Value;
				_uiController.FechaUltimaModifPcioVtaHasta = (DateTime)uccFechaPcioVentaHasta.Value;
			}
			else
			{
				_uiController.FechaUltimaModifPcioVtaDesde = DateTime.MinValue;
				_uiController.FechaUltimaModifPcioVtaHasta = DateTime.MinValue;
			}

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
					this.ResetFilters();
					break;
				case 8:					
					this.CloseForm();
					break;
			}				
		}

		
		private void KeyDownBehavior(object sender, KeyEventArgs e)
		{
			switch (e.KeyData )
			{
				case System.Windows.Forms.Keys.F5 :
					this.RefreshData();
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
		}

		private void ResetFilters()
		{
			chckPorUltimaFechaModifPcioCosto.Checked=false;
			chckPorUltimaFechaModifPcioVta.Checked=false;
			mzComboListaDePrecios.Value=string.Empty;
			mzProductosControl1.ClearControl();
			_uiController.Codigo=string.Empty;
			hierarchicalSearchControl1.ClearSelectedNodes();

			gridResultado.SetDataBinding(null, null);
			gridResultado.Refresh();
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

		private void chckPorUltimaFechaModifPcioCosto_CheckedChanged(object sender, EventArgs e)
		{
			_uiController.PorUltimaFechaModifPcioCosto = chckPorUltimaFechaModifPcioCosto.Checked;
			if(_uiController.FechaUltimaModifPcioCostoDesde.Equals(DateTime.MinValue))
                uccFechaPcioCostoDesde.Value = System.DBNull.Value;
			else
				uccFechaPcioCostoDesde.Value = _uiController.FechaUltimaModifPcioCostoDesde;

			if(_uiController.FechaUltimaModifPcioCostoHasta.Equals(DateTime.MinValue))
				uccFechaPcioCostoHasta.Value = System.DBNull.Value;
			else
				uccFechaPcioCostoHasta.Value = _uiController.FechaUltimaModifPcioCostoHasta;

			uccFechaPcioCostoDesde.Enabled = _uiController.PorUltimaFechaModifPcioCosto;
			uccFechaPcioCostoHasta.Enabled = _uiController.PorUltimaFechaModifPcioCosto;

		}

		private void chckPorUltimaFechaModifPcioVta_CheckedChanged(object sender, EventArgs e)
		{
			_uiController.PorUltimaFechaModifPcioVta = chckPorUltimaFechaModifPcioVta.Checked;
			if(_uiController.FechaUltimaModifPcioVtaDesde.Equals(DateTime.MinValue))
				uccFechaPcioVentaDesde.Value = System.DBNull.Value;
			else
				uccFechaPcioVentaDesde.Value = _uiController.FechaUltimaModifPcioVtaDesde;

			if(_uiController.FechaUltimaModifPcioVtaHasta.Equals(DateTime.MinValue))
				uccFechaPcioVentaHasta.Value = System.DBNull.Value;
			else
				uccFechaPcioVentaHasta.Value = _uiController.FechaUltimaModifPcioVtaHasta;

			uccFechaPcioVentaDesde.Enabled = _uiController.PorUltimaFechaModifPcioVta;
			uccFechaPcioVentaHasta.Enabled = _uiController.PorUltimaFechaModifPcioVta;

		}

	}
}

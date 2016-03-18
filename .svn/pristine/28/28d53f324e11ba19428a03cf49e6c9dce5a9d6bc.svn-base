using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using mz.erp.commontypes;
using mz.erp.ui.forms.classes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmAbmProductos.
	/// </summary>
	public class FrmAbmProductos : System.Windows.Forms.Form, ITaskForm
	{
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ImageList imglStandar;
		protected System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		protected System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		protected System.Windows.Forms.ToolBarButton tbbCancelar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.CheckBox chActivo;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor ueDescripcionLarga;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor ueDescripcionCorta;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor ueDescripcion;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor ueCodigoBarras;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor ueCodigo;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor ueObservaciones;
		private System.Windows.Forms.CheckBox chkObligaNumeroDeSerie;
		private System.Windows.Forms.CheckBox chkObligaCodigoBarras;
		private mz.erp.ui.controls.mzComboEditor cmbTipo;
		private System.Windows.Forms.Label labelTarea;
		private mz.erp.ui.controllers.AbmProductosController _uiController;
		public FrmAbmProductos(mz.erp.ui.controllers.AbmProductosController uiController)
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			_uiController = uiController;
			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
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
				BindingController.Clear( _uiController, "Codigo", ueCodigo, "Text" );
				BindingController.Clear( _uiController, "CodigoSecundario", ueCodigoBarras, "Text");
				BindingController.Clear( _uiController, "Descripcion", ueDescripcion, "Text");
				BindingController.Clear( _uiController, "DescripcionCorta", ueDescripcionCorta, "Text");
				BindingController.Clear( _uiController, "DescripcionLarga", ueDescripcionLarga, "Text");
				BindingController.Clear( _uiController, "Observaciones", ueObservaciones, "Text");
				BindingController.Clear( _uiController, "Activo", chActivo, "Checked");
				BindingController.Clear( _uiController, "ObligaCodigoBarras", chkObligaCodigoBarras, "Checked");
				BindingController.Clear( _uiController, "ObligaNumeroDeSerie", chkObligaNumeroDeSerie, "Checked" );
				BindingController.Clear( cmbTipo,"Value",_uiController,"IdTipoDeProducto");
			}
			base.Dispose( disposing );
		}

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmAbmProductos));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.cmbTipo = new mz.erp.ui.controls.mzComboEditor();
			this.chActivo = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.ueDescripcionLarga = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.ueDescripcionCorta = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.ueDescripcion = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.ueCodigoBarras = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.ueCodigo = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.ueObservaciones = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.label7 = new System.Windows.Forms.Label();
			this.chkObligaNumeroDeSerie = new System.Windows.Forms.CheckBox();
			this.chkObligaCodigoBarras = new System.Windows.Forms.CheckBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.panel2 = new System.Windows.Forms.Panel();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmbTipo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ueDescripcionLarga)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ueDescripcionCorta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ueDescripcion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ueCodigoBarras)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ueCodigo)).BeginInit();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ueObservaciones)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(718, 24);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(718, 24);
			this.labelTarea.TabIndex = 0;
			this.labelTarea.Text = "Información general de productos";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.cmbTipo);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chActivo);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label6);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ueDescripcionLarga);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ueDescripcionCorta);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ueDescripcion);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ueCodigoBarras);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ueCodigo);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label5);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label4);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 107);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(718, 167);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// cmbTipo
			// 
			this.cmbTipo.DataSource = null;
			this.cmbTipo.DisplayMember = "";
			this.cmbTipo.DisplayMemberCaption = "";
			this.cmbTipo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.cmbTipo.Location = new System.Drawing.Point(547, 8);
			this.cmbTipo.MaxItemsDisplay = 200;
			this.cmbTipo.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(157, 21);
			this.cmbTipo.SorterMember = "";
			this.cmbTipo.TabIndex = 13;
			this.cmbTipo.ValueMember = "";
			this.cmbTipo.ValueMemberCaption = "";
			// 
			// chActivo
			// 
			this.chActivo.BackColor = System.Drawing.Color.Transparent;
			this.chActivo.Location = new System.Drawing.Point(425, 34);
			this.chActivo.Name = "chActivo";
			this.chActivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chActivo.Size = new System.Drawing.Size(136, 16);
			this.chActivo.TabIndex = 12;
			this.chActivo.Text = "Activo";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(415, 13);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label6.Size = new System.Drawing.Size(128, 16);
			this.label6.TabIndex = 11;
			this.label6.Text = "Tipo de Producto";
			// 
			// ueDescripcionLarga
			// 
			this.ueDescripcionLarga.Location = new System.Drawing.Point(144, 105);
			this.ueDescripcionLarga.Multiline = true;
			this.ueDescripcionLarga.Name = "ueDescripcionLarga";
			this.ueDescripcionLarga.Scrollbars = System.Windows.Forms.ScrollBars.Vertical;
			this.ueDescripcionLarga.Size = new System.Drawing.Size(560, 48);
			this.ueDescripcionLarga.TabIndex = 9;
			this.ueDescripcionLarga.Text = "ultraTextEditor5";
			// 
			// ueDescripcionCorta
			// 
			this.ueDescripcionCorta.Location = new System.Drawing.Point(144, 81);
			this.ueDescripcionCorta.Name = "ueDescripcionCorta";
			this.ueDescripcionCorta.Size = new System.Drawing.Size(560, 21);
			this.ueDescripcionCorta.TabIndex = 8;
			this.ueDescripcionCorta.Text = "ultraTextEditor4";
			// 
			// ueDescripcion
			// 
			this.ueDescripcion.Location = new System.Drawing.Point(144, 57);
			this.ueDescripcion.Name = "ueDescripcion";
			this.ueDescripcion.Size = new System.Drawing.Size(560, 21);
			this.ueDescripcion.TabIndex = 7;
			this.ueDescripcion.Text = "ultraTextEditor3";
			// 
			// ueCodigoBarras
			// 
			this.ueCodigoBarras.Location = new System.Drawing.Point(144, 33);
			this.ueCodigoBarras.Name = "ueCodigoBarras";
			this.ueCodigoBarras.Size = new System.Drawing.Size(152, 21);
			this.ueCodigoBarras.TabIndex = 6;
			this.ueCodigoBarras.Text = "ultraTextEditor2";
			// 
			// ueCodigo
			// 
			this.ueCodigo.Location = new System.Drawing.Point(144, 9);
			this.ueCodigo.Name = "ueCodigo";
			this.ueCodigo.Size = new System.Drawing.Size(152, 21);
			this.ueCodigo.TabIndex = 5;
			this.ueCodigo.Text = "ultraTextEditor1";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(11, 109);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label5.Size = new System.Drawing.Size(128, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Descripción Larga";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(11, 85);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label4.Size = new System.Drawing.Size(128, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Descripción Corta";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(11, 61);
			this.label3.Name = "label3";
			this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label3.Size = new System.Drawing.Size(128, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Descripción";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(11, 36);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label2.Size = new System.Drawing.Size(128, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Codigo de Barras";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(11, 12);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label1.Size = new System.Drawing.Size(128, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Codigo";
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.ueObservaciones);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label7);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.chkObligaNumeroDeSerie);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.chkObligaCodigoBarras);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 333);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(718, 157);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// ueObservaciones
			// 
			this.ueObservaciones.Location = new System.Drawing.Point(146, 4);
			this.ueObservaciones.Multiline = true;
			this.ueObservaciones.Name = "ueObservaciones";
			this.ueObservaciones.Scrollbars = System.Windows.Forms.ScrollBars.Vertical;
			this.ueObservaciones.Size = new System.Drawing.Size(558, 92);
			this.ueObservaciones.TabIndex = 16;
			this.ueObservaciones.Text = "ultraTextEditor6";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(13, 4);
			this.label7.Name = "label7";
			this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label7.Size = new System.Drawing.Size(123, 16);
			this.label7.TabIndex = 15;
			this.label7.Text = "Observaciones";
			// 
			// chkObligaNumeroDeSerie
			// 
			this.chkObligaNumeroDeSerie.BackColor = System.Drawing.Color.Transparent;
			this.chkObligaNumeroDeSerie.Location = new System.Drawing.Point(8, 120);
			this.chkObligaNumeroDeSerie.Name = "chkObligaNumeroDeSerie";
			this.chkObligaNumeroDeSerie.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chkObligaNumeroDeSerie.Size = new System.Drawing.Size(152, 24);
			this.chkObligaNumeroDeSerie.TabIndex = 14;
			this.chkObligaNumeroDeSerie.Text = "Obliga Numero de Serie";
			// 
			// chkObligaCodigoBarras
			// 
			this.chkObligaCodigoBarras.BackColor = System.Drawing.Color.Transparent;
			this.chkObligaCodigoBarras.Location = new System.Drawing.Point(24, 104);
			this.chkObligaCodigoBarras.Name = "chkObligaCodigoBarras";
			this.chkObligaCodigoBarras.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chkObligaCodigoBarras.Size = new System.Drawing.Size(136, 16);
			this.chkObligaCodigoBarras.TabIndex = 13;
			this.chkObligaCodigoBarras.Text = "Obliga Codigo Barras";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.toolBarStandar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(784, 32);
			this.panel1.TabIndex = 0;
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
			this.toolBarStandar.Size = new System.Drawing.Size(784, 28);
			this.toolBarStandar.TabIndex = 18;
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
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.ultraExplorerBar1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 32);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(784, 494);
			this.panel2.TabIndex = 1;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 24;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 167;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Datos Generales";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup3.Settings.ContainerHeight = 157;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Datos Adicionales";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 0);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(784, 494);
			this.ultraExplorerBar1.TabIndex = 0;
			// 
			// FrmAbmProductos
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(784, 526);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FrmAbmProductos";
			this.Text = " ";
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmbTipo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ueDescripcionLarga)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ueDescripcionCorta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ueDescripcion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ueCodigoBarras)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ueCodigo)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ueObservaciones)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Miembros de ITaskForm

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


		public void Execute()
		{
			this._uiController.Execute();
		}

		public void Previous()
		{
			this._uiController.Previous();
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
			Previous();
		}

		public void KeyDownNext()
		{
			Execute();
		}

		private void Build_UI()
		{
			ConfigureInterface();
			InitEventHandlers();
			InitializeData();
			InitDataBindings();
			/*ConfigGrids();*/
		}
		private void ListenerControllerChanges( object sender, System.EventArgs e )
		{
			RefreshData();
		}
		private void InitEventHandlers()
		{
			_uiController.OnControllerHasChanged+=new System.EventHandler( this.ListenerControllerChanges );
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			KeyDownManager KeyDown = new KeyDownManager(this);
		}
		private void InitializeData()
		{
			RefreshData();
		}
		private void InitDataBindings()
		{
			BindingController.Bind( _uiController, "Codigo", ueCodigo, "Text" );
			BindingController.Bind( _uiController, "CodigoSecundario", ueCodigoBarras, "Text");
			BindingController.Bind( _uiController, "Descripcion", ueDescripcion, "Text");
			BindingController.Bind( _uiController, "DescripcionCorta", ueDescripcionCorta, "Text");
			BindingController.Bind( _uiController, "DescripcionLarga", ueDescripcionLarga, "Text");
			BindingController.Bind( _uiController, "Observaciones", ueObservaciones, "Text");
			BindingController.Bind( _uiController, "Activo", chActivo, "Checked");
			BindingController.Bind( _uiController, "ObligaCodigoBarras", chkObligaCodigoBarras, "Checked");
			BindingController.Bind( _uiController, "ObligaNumeroDeSerie", chkObligaNumeroDeSerie, "Checked" );
			BindingController.Bind( cmbTipo,"Value",_uiController,"IdTipoDeProducto");
		}
		private void RefreshData()
		{
			ueCodigo.Text = _uiController.Codigo;
			ueCodigoBarras.Text = _uiController.CodigoSecundario;
			ueDescripcion.Text = _uiController.Descripcion;
			ueDescripcionCorta.Text = _uiController.DescripcionCorta;
			ueDescripcionLarga.Text = _uiController.DescripcionLarga;
			ueObservaciones.Text = _uiController.Observaciones;
			chActivo.Checked = _uiController.Activo;
			chkObligaCodigoBarras.Checked = _uiController.ObligaCodigoBarras;
			chkObligaNumeroDeSerie.Checked = _uiController.ObligaNumeroDeSerie;
		}
		#endregion
		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf(e.Button) )
			{
				case 0:
					Previous();
					break;
				case 2:
					Execute();
					break;
				
			}		
		}
		private void ConfigureInterface()
		{
			cmbTipo.FillFromDataSource( _uiController.TiposDeProductos, _uiController.KeyValueTiposDeProductos, _uiController.KeyListTiposDeProductos, 8, _uiController.KeyListTiposDeProductos);
			ueCodigo.ReadOnly = _uiController.AllowEditCodigo;
            //Cristian Tarea 953
            ueObservaciones.MaxLength = 1000;
            //Fin Tarea 953
			ueCodigo.Visible = _uiController.AllowShowCodigo;
			ueDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			ueDescripcionCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			ueDescripcionLarga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			Text = _uiController.LeyendaFormulario;
			labelTarea.Text = _uiController.LeyendaFormulario;
			KeyPreview = true;
		}
	}
}

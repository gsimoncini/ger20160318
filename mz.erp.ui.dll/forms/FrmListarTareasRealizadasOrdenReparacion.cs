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
	/// Descripción breve de FrmListarTareasRealizadasOrdenReparacion.
	/// </summary>
	public class FrmListarTareasRealizadasOrdenReparacion : System.Windows.Forms.Form,  ITaskForm
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmListarTareasRealizadasOrdenReparacion));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup6 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.listBoxServicios = new System.Windows.Forms.ListBox();
			this.ultraMENumeroOrdenReparacion = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.txtTiempoDeEspera = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtNumeroRemito = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTotalTecnico = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gridResultado = new Janus.Windows.GridEX.GridEX();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.ultraExplorerBarContainerControl6 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridMotivosTareas = new Janus.Windows.GridEX.GridEX();
			this.chkMotivosTareasHijos = new System.Windows.Forms.CheckedListBox();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridMotivos = new Janus.Windows.GridEX.GridEX();
			this.chkMotivosHijos = new System.Windows.Forms.CheckedListBox();
			this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridObservaciones = new Janus.Windows.GridEX.GridEX();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.tbbGuardar = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
			this.ultraExplorerBarContainerControl6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridMotivosTareas)).BeginInit();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridMotivos)).BeginInit();
			this.ultraExplorerBarContainerControl4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridObservaciones)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, -37);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(814, 29);
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
			this.ultraExplorerBarContainerControl2.Controls.Add(this.listBoxServicios);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.ultraMENumeroOrdenReparacion);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label7);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, -126);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(814, 120);
			this.ultraExplorerBarContainerControl2.TabIndex = 5;
			// 
			// listBoxServicios
			// 
			this.listBoxServicios.Location = new System.Drawing.Point(136, 24);
			this.listBoxServicios.Name = "listBoxServicios";
			this.listBoxServicios.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.listBoxServicios.Size = new System.Drawing.Size(232, 82);
			this.listBoxServicios.TabIndex = 1;
			// 
			// ultraMENumeroOrdenReparacion
			// 
			this.ultraMENumeroOrdenReparacion.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
			this.ultraMENumeroOrdenReparacion.InputMask = "######";
			this.ultraMENumeroOrdenReparacion.Location = new System.Drawing.Point(136, 0);
			this.ultraMENumeroOrdenReparacion.Name = "ultraMENumeroOrdenReparacion";
			this.ultraMENumeroOrdenReparacion.TabIndex = 0;
			this.ultraMENumeroOrdenReparacion.Text = "--";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(8, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 114;
			this.label2.Text = "Servicios";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(8, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(112, 16);
			this.label7.TabIndex = 93;
			this.label7.Text = "N° Orden Reparacion";
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtTiempoDeEspera);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label5);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtNumeroRemito);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label4);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtTotalTecnico);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtTotal);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridResultado);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridManagerView1);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, -260);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(814, 255);
			this.ultraExplorerBarContainerControl1.TabIndex = 6;
			// 
			// txtTiempoDeEspera
			// 
			this.txtTiempoDeEspera.Location = new System.Drawing.Point(304, 0);
			this.txtTiempoDeEspera.Name = "txtTiempoDeEspera";
			this.txtTiempoDeEspera.TabIndex = 1;
			this.txtTiempoDeEspera.Text = "";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(192, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 16);
			this.label5.TabIndex = 121;
			this.label5.Text = "Tiempo de Espera";
			// 
			// txtNumeroRemito
			// 
			this.txtNumeroRemito.Location = new System.Drawing.Point(80, 0);
			this.txtNumeroRemito.Name = "txtNumeroRemito";
			this.txtNumeroRemito.TabIndex = 0;
			this.txtNumeroRemito.Text = "";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 16);
			this.label4.TabIndex = 119;
			this.label4.Text = "Nro. Remito";
			// 
			// txtTotalTecnico
			// 
			this.txtTotalTecnico.Enabled = false;
			this.txtTotalTecnico.Location = new System.Drawing.Point(704, 0);
			this.txtTotalTecnico.Name = "txtTotalTecnico";
			this.txtTotalTecnico.TabIndex = 3;
			this.txtTotalTecnico.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(624, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 16);
			this.label3.TabIndex = 117;
			this.label3.Text = "Total Técnico";
			// 
			// txtTotal
			// 
			this.txtTotal.Enabled = false;
			this.txtTotal.Location = new System.Drawing.Point(504, 0);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.TabIndex = 2;
			this.txtTotal.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(424, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 115;
			this.label1.Text = "Total Orden";
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
			this.gridResultado.TabIndex = 5;
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
			this.gridManagerView1.Location = new System.Drawing.Point(0, 24);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(831, 24);
			this.gridManagerView1.TabIndex = 4;
			// 
			// ultraExplorerBarContainerControl6
			// 
			this.ultraExplorerBarContainerControl6.Controls.Add(this.gridMotivosTareas);
			this.ultraExplorerBarContainerControl6.Controls.Add(this.chkMotivosTareasHijos);
			this.ultraExplorerBarContainerControl6.Location = new System.Drawing.Point(28, -295);
			this.ultraExplorerBarContainerControl6.Name = "ultraExplorerBarContainerControl6";
			this.ultraExplorerBarContainerControl6.Size = new System.Drawing.Size(814, 300);
			this.ultraExplorerBarContainerControl6.TabIndex = 9;
			// 
			// gridMotivosTareas
			// 
			this.gridMotivosTareas.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridMotivosTareas.GroupByBoxVisible = false;
			this.gridMotivosTareas.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridMotivosTareas.Location = new System.Drawing.Point(11, 10);
			this.gridMotivosTareas.Name = "gridMotivosTareas";
			this.gridMotivosTareas.Size = new System.Drawing.Size(400, 280);
			this.gridMotivosTareas.TabIndex = 0;
			// 
			// chkMotivosTareasHijos
			// 
			this.chkMotivosTareasHijos.Location = new System.Drawing.Point(451, 10);
			this.chkMotivosTareasHijos.Name = "chkMotivosTareasHijos";
			this.chkMotivosTareasHijos.Size = new System.Drawing.Size(352, 274);
			this.chkMotivosTareasHijos.TabIndex = 1;
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.gridMotivos);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.chkMotivosHijos);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, -120);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(814, 300);
			this.ultraExplorerBarContainerControl3.TabIndex = 7;
			// 
			// gridMotivos
			// 
			this.gridMotivos.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridMotivos.GroupByBoxVisible = false;
			this.gridMotivos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridMotivos.Location = new System.Drawing.Point(16, 8);
			this.gridMotivos.Name = "gridMotivos";
			this.gridMotivos.Size = new System.Drawing.Size(400, 280);
			this.gridMotivos.TabIndex = 0;
			// 
			// chkMotivosHijos
			// 
			this.chkMotivosHijos.Location = new System.Drawing.Point(456, 8);
			this.chkMotivosHijos.Name = "chkMotivosHijos";
			this.chkMotivosHijos.Size = new System.Drawing.Size(352, 274);
			this.chkMotivosHijos.TabIndex = 1;
			// 
			// ultraExplorerBarContainerControl4
			// 
			this.ultraExplorerBarContainerControl4.Controls.Add(this.gridObservaciones);
			this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, 239);
			this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
			this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(814, 200);
			this.ultraExplorerBarContainerControl4.TabIndex = 8;
			// 
			// gridObservaciones
			// 
			this.gridObservaciones.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridObservaciones.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridObservaciones.GroupByBoxVisible = false;
			this.gridObservaciones.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridObservaciones.Location = new System.Drawing.Point(0, 0);
			this.gridObservaciones.Name = "gridObservaciones";
			this.gridObservaciones.Size = new System.Drawing.Size(814, 200);
			this.gridObservaciones.TabIndex = 0;
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
																							  this.tbbGuardar,
																							  this.toolBarButton5,
																							  this.tbbCancelar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(880, 28);
			this.toolBarStandar.TabIndex = 48;
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
			// tbbGuardar
			// 
			this.tbbGuardar.ImageIndex = 4;
			this.tbbGuardar.Text = "Guardar";
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
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
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl6);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl5;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 29;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 120;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Filtros";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup3.Settings.ContainerHeight = 255;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Resultado";
			ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl6;
			ultraExplorerBarGroup4.Settings.ContainerHeight = 300;
			ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup4.Text = "Motivos Tareas";
			ultraExplorerBarGroup5.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup5.Settings.ContainerHeight = 300;
			ultraExplorerBarGroup5.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup5.Text = "Motivos";
			ultraExplorerBarGroup6.Container = this.ultraExplorerBarContainerControl4;
			ultraExplorerBarGroup6.Settings.ContainerHeight = 200;
			ultraExplorerBarGroup6.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup6.Text = "Observaciones";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3,
																														ultraExplorerBarGroup4,
																														ultraExplorerBarGroup5,
																														ultraExplorerBarGroup6});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(880, 464);
			this.ultraExplorerBar1.TabIndex = 51;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// FrmListarTareasRealizadasOrdenReparacion
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(880, 492);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmListarTareasRealizadasOrdenReparacion";
			this.Text = "FrmListarTareasRealizadasOrdenReparacion";
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
			this.ultraExplorerBarContainerControl6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridMotivosTareas)).EndInit();
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridMotivos)).EndInit();
			this.ultraExplorerBarContainerControl4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridObservaciones)).EndInit();
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
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private System.Windows.Forms.Label labelTarea;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Label label7;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private System.Windows.Forms.Label label2;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMENumeroOrdenReparacion;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		protected Janus.Windows.GridEX.GridEX gridResultado;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTotal;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.CheckedListBox chkMotivosHijos;
		protected Janus.Windows.GridEX.GridEX gridMotivos;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		protected Janus.Windows.GridEX.GridEX gridObservaciones;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTotalTecnico;
		private System.Windows.Forms.TextBox txtNumeroRemito;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ListBox listBoxServicios;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl6;
		protected Janus.Windows.GridEX.GridEX gridMotivosTareas;
		private System.Windows.Forms.CheckedListBox chkMotivosTareasHijos;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton tbbGuardar;
		private System.Windows.Forms.TextBox txtTiempoDeEspera;

		#region Construtores y Destructores

		public FrmListarTareasRealizadasOrdenReparacion(ListarTareasRealizadasOrdenReparacionController uiController)
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

			}
			base.Dispose( disposing );
		}
		#endregion

		#region Variables Privadas
		private ListarTareasRealizadasOrdenReparacionController _uiController = null;
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
			tbbSiguiente.Enabled = false;

			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), gridResultado, this.Text);

			this.gridMotivos.LayoutData = _uiController.GetLayout();
			gridMotivos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
			gridMotivos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
			gridMotivos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
			gridMotivos.AcceptsEscape = true;

			Janus.Windows.GridEX.GridEXColumnCollection col = gridMotivos.RootTable.Columns;
			col["Descripcion"].EditType= Janus.Windows.GridEX.EditType.NoEdit;

			this.gridObservaciones.LayoutData = _uiController.GetLayoutObservaciones();

			this.gridMotivosTareas.LayoutData = _uiController.GetLayout();
			gridMotivosTareas.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
			gridMotivosTareas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
			gridMotivosTareas.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
			gridMotivosTareas.AcceptsEscape = true;

			Janus.Windows.GridEX.GridEXColumnCollection col1 = gridMotivosTareas.RootTable.Columns;
			col1["Descripcion"].EditType= Janus.Windows.GridEX.EditType.NoEdit;
			
			listBoxServicios.Enabled = _uiController.ListaServiciosOrdenReparacionHabilitada;
			tbbGuardar.Enabled = _uiController.PermiteModificarOrdenReparacion;

		}

		private void InitializeData()
		{
			listBoxServicios.Items.Clear();
			listBoxServicios.Items.AddRange(_uiController.Servicios.ToArray());

		}

		private void InitEventHandlers()
		{
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			_uiController.DataChanged+=new EventHandler(RefreshData);
			gridMotivos.SelectionChanged+=new EventHandler(gridMotivos_SelectionChanged);
			gridMotivos.CellValueChanged +=new Janus.Windows.GridEX.ColumnActionEventHandler(gridMotivos_CellValueChanged);
			_uiController.MotivoPadreChanged+=new EventHandler(RefreshMotivosHijos);
			chkMotivosHijos.ItemCheck+=new ItemCheckEventHandler(chkMotivosHijos_ItemCheck);
			_uiController.IdServiciosSelecionadosChanged += new EventHandler(_uiController_IdServiciosSelecionadosChanged);
			ultraMENumeroOrdenReparacion.ValueChanged += new EventHandler(ultraMENumeroOrdenReparacion_ValueChanged);
			gridMotivosTareas.SelectionChanged+=new EventHandler(gridMotivosTareas_SelectionChanged);
			gridMotivosTareas.CellValueChanged +=new Janus.Windows.GridEX.ColumnActionEventHandler(gridMotivosTareas_CellValueChanged);
			_uiController.MotivoTareaPadreChanged+=new EventHandler(RefreshMotivosTareaHijos);
			chkMotivosTareasHijos.ItemCheck +=new ItemCheckEventHandler(chkMotivosTareasHijos_ItemCheck);
			gridResultado.SelectionChanged +=new EventHandler(gridResultado_SelectionChanged);
            
		}	
	
		private void InitDataBindings()
		{
			gridMotivos.SetDataBinding(null, null);
			gridMotivos.SetDataBinding(_uiController.MotivosPadres, null);

			chkMotivosHijos.Items.AddRange(_uiController.MotivosHijos.ToArray());
			int i = 0;
			foreach(businessrules.EstadisticaOrdenReparacionMotivoOrdenReparacion motivoH in _uiController.MotivosHijos)
			{
				if(motivoH.Estado.Equals("EXISTE"))
					chkMotivosHijos.SetItemChecked(i, true);
				i++;
			}


			gridMotivosTareas.SetDataBinding(null, null);
			gridMotivosTareas.SetDataBinding(_uiController.MotivosTareaPadres, null);

			chkMotivosTareasHijos.Items.Clear();
			chkMotivosTareasHijos.Items.AddRange(_uiController.MotivosTareaHijos.ToArray());
			int j = 0;
			foreach(businessrules.EstadisticaOrdenReparacionMotivoOrdenReparacion motivoTH in _uiController.MotivosTareaHijos)
			{
				if(motivoTH.Estado.Equals("EXISTE"))
					chkMotivosTareasHijos.SetItemChecked(j, true);
				j++;
			}
			
			gridObservaciones.SetDataBinding(null, null);
			gridObservaciones.SetDataBinding(_uiController.ObservacionesOrdenReparacion, null);

			gridResultado.SetDataBinding(null, null);
			gridResultado.SetDataBinding(_uiController.Result, null);
			gridResultado.RootTable.FormatConditions.Clear();
			if(gridResultado.RootTable.Columns[ "BackColorRojoForeColorVerde" ] != null)
			{				
				Janus.Windows.GridEX.GridEXFormatStyle fs= new Janus.Windows.GridEX.GridEXFormatStyle((Janus.Windows.GridEX.GridEXFormatStyle) gridResultado.RowFormatStyle);
				fs.BackColor = System.Drawing.Color.Red;
				fs.ForeColor = System.Drawing.Color.YellowGreen;
				Janus.Windows.GridEX.ConditionOperator condOp = Janus.Windows.GridEX.ConditionOperator.Equal;				
				Janus.Windows.GridEX.GridEXFormatCondition cnd = new Janus.Windows.GridEX.GridEXFormatCondition( gridResultado.RootTable.Columns[ "BackColorRojoForeColorVerde" ], condOp, Convert.ToInt32(1));
				cnd.FormatStyle = fs;
				gridResultado.RootTable.FormatConditions.Add( cnd );
			}

			if(gridResultado.RootTable.Columns[ "ForeColorVerde" ] != null)
			{
				Janus.Windows.GridEX.GridEXFormatStyle fs1= new Janus.Windows.GridEX.GridEXFormatStyle((Janus.Windows.GridEX.GridEXFormatStyle) gridResultado.RowFormatStyle);
				fs1.ForeColor = System.Drawing.Color.YellowGreen;
				Janus.Windows.GridEX.ConditionOperator condOp1 = Janus.Windows.GridEX.ConditionOperator.Equal;				
				Janus.Windows.GridEX.GridEXFormatCondition cnd1 = new Janus.Windows.GridEX.GridEXFormatCondition( gridResultado.RootTable.Columns[ "ForeColorVerde" ], condOp1, Convert.ToInt32(1));
				cnd1.FormatStyle = fs1;
				gridResultado.RootTable.FormatConditions.Add( cnd1 );
			}

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
			this.Cursor = Cursors.WaitCursor;
			Util.MoveFocus(this.ultraExplorerBarContainerControl2);
			_uiController.NumeroRemito = txtNumeroRemito.Text;
			if(!txtTiempoDeEspera.Text.Equals(string.Empty))
				_uiController.TiempoDeEspera = Convert.ToDecimal(txtTiempoDeEspera.Text);
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
			this.Execute();
		}

		#endregion

		#region Metodos Privados
		private void RefreshData()
		{
			Util.MoveFocus(ultraExplorerBarContainerControl2);
			this.Cursor = Cursors.WaitCursor;
			gridResultado.Focus();
			ArrayList idServiciosSeleccionados = new ArrayList();
			foreach(businessrules.Servicio serv in listBoxServicios.SelectedItems)
				idServiciosSeleccionados.Add(serv.IdFalla);
			_uiController.IdServiciosSelecionados = idServiciosSeleccionados;
			_uiController.RefreshData();
			this.Cursor = Cursors.Default;
		}

		private void SaveChanges()
		{	
			this.Cursor = Cursors.WaitCursor;
			if(_uiController.PermiteModificarOrdenReparacion)
			{
				Util.MoveFocus(this.ultraExplorerBarContainerControl2);
				_uiController.NumeroRemito = txtNumeroRemito.Text;
				if(!txtTiempoDeEspera.Text.Equals(string.Empty))
					_uiController.TiempoDeEspera = Convert.ToDecimal(txtTiempoDeEspera.Text);
				if(_uiController.ValidaCompletarDatosOrdenSTD && _uiController.NumeroRemito.Equals(string.Empty))
					MessageBox.Show("El campo Nro. de Remnito no puede estar vacío pues es una orden STD","Advertencia",System.Windows.Forms.MessageBoxButtons.OK);
				else if(_uiController.ValidaCompletarDatosOrdenSTD && _uiController.TiempoDeEspera.Equals(decimal.MinValue)) 
					MessageBox.Show("El campo Tiempo de Espera no puede estar vacío pues es una orden STD","Advertencia",System.Windows.Forms.MessageBoxButtons.OK);
				else
				{
					_uiController.SaveChanges();
					MessageBox.Show("Los datos han sido guardados correctamente.","Advertencia",System.Windows.Forms.MessageBoxButtons.OK);
					tbbGuardar.Enabled = _uiController.PermiteModificarOrdenReparacion;
				}
			}
			this.Cursor = Cursors.Default;
		}


		private businessrules.Servicio GetServicioByIdServicio(long IdServicio)
		{
			businessrules.Servicio servicio = null;
			bool existe = false;
			int i = 0;
			while(!existe && i<listBoxServicios.Items.Count)
			{
				servicio = (businessrules.Servicio)listBoxServicios.Items[i];
				existe = servicio.IdFalla.Equals(IdServicio);
				i++;
			}
			return servicio;
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
					this.SaveChanges();
					break;

				case 8:					
					this.CloseForm();
					break;
			}				
		}

		private void RefreshData(object sender, EventArgs e)
		{			

			gridResultado.SetDataBinding(null, null);
			gridResultado.SetDataBinding(_uiController.Result, null);

			gridMotivos.SetDataBinding(null, null);
			gridMotivos.SetDataBinding(_uiController.MotivosPadres, null);

			gridMotivosTareas.SetDataBinding(null, null);
			gridMotivosTareas.SetDataBinding(_uiController.MotivosTareaPadres, null);

			gridObservaciones.SetDataBinding(null, null);
			gridObservaciones.SetDataBinding(_uiController.ObservacionesOrdenReparacion, null);

			if (gridManagerView1.AllowGroupCollapse)
				this.gridResultado.CollapseGroups();
			else
				if (gridResultado.RootTable.Groups.Count > 0 )
				gridResultado.RootTable.Groups[0].Expand();
			if (gridManagerView1.AllowExportExcel || gridManagerView1.AllowSortByAgregateColumn)
				gridManagerView1.SetTable(_uiController.ResultAsTable);

			txtTotal.Text = _uiController.Total.ToString();
			txtTotalTecnico.Text = _uiController.TotalTecnico.ToString();
			txtNumeroRemito.Text = _uiController.NumeroRemito;
			if(_uiController.TiempoDeEspera.Equals(decimal.MinValue))
				txtTiempoDeEspera.Text = string.Empty;
			else
                txtTiempoDeEspera.Text = _uiController.TiempoDeEspera.ToString();

			tbbGuardar.Enabled = _uiController.PermiteModificarOrdenReparacion;
		}

		private void RefreshMotivosHijos(object sender, EventArgs e)
		{			
			chkMotivosHijos.Items.Clear();
			chkMotivosHijos.Items.AddRange(_uiController.MotivosHijos.ToArray());
			int i = 0;
			foreach(businessrules.EstadisticaOrdenReparacionMotivoOrdenReparacion motivoH in _uiController.MotivosHijos)
			{
				if(motivoH.Estado.Equals("EXISTE") || motivoH.Estado.Equals("NEW"))
					chkMotivosHijos.SetItemChecked(i, true);
				i++;
			}

		}

		private void gridMotivos_SelectionChanged(object sender, EventArgs e)
		{
			if(gridMotivos.SelectedItems.Count > 0)
			{
				businessrules.EstadisticaOrdenReparacionMotivoOrdenReparacion motivo = (businessrules.EstadisticaOrdenReparacionMotivoOrdenReparacion) gridMotivos.SelectedItems[0].GetRow().DataRow;	
				_uiController.EstadisticaOrdenReparacionMotivoOrdenReparacionSeleccionado = motivo;
			}

		}

		private void gridMotivos_CellValueChanged(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
		{
			gridMotivos.UpdateData();
			int index = gridMotivos.SelectedItems[0].Position;
			_uiController.ModifyMotivo(index);		
			this.RefreshMotivosHijos(this, new EventArgs());

		}

		private void chkMotivosHijos_ItemCheck(object sender, ItemCheckEventArgs e)
		{			
			int index = e.Index;
			bool seleccionado = e.NewValue.Equals(System.Windows.Forms.CheckState.Checked);
			_uiController.ModifyMotivoHijo(index, seleccionado);		
		}

		private void _uiController_IdServiciosSelecionadosChanged(object sender, EventArgs e)
		{
			
			for(int i = 0; i < listBoxServicios.SelectedItems.Count; i++)
				listBoxServicios.SetSelected(i, false);			
			foreach(long idServ in _uiController.IdServiciosSelecionados)
			{
				businessrules.Servicio serv = this.GetServicioByIdServicio(idServ);
				int index = listBoxServicios.Items.IndexOf(serv);
				listBoxServicios.SetSelected(index, true);		
			}
		}

		private void ultraMENumeroOrdenReparacion_ValueChanged(object sender, EventArgs e)
		{
			for(int i = 0; i < listBoxServicios.Items.Count; i++)
				listBoxServicios.SetSelected(i, false);		
			gridResultado.SetDataBinding(null, null);
			gridMotivos.SetDataBinding(null, null);
			gridMotivosTareas.SetDataBinding(null, null);
			gridObservaciones.SetDataBinding(null, null);
			txtTotal.Text = string.Empty;
			txtTotalTecnico.Text = string.Empty;
			txtNumeroRemito.Text = string.Empty;
			txtTiempoDeEspera.Text = string.Empty;
			chkMotivosHijos.Items.Clear();
			chkMotivosTareasHijos.Items.Clear();
			if(ultraMENumeroOrdenReparacion.Value != System.DBNull.Value)
                _uiController.IdOrdenReparacion = Convert.ToInt64(ultraMENumeroOrdenReparacion.Value);
		}

		private void gridMotivosTareas_SelectionChanged(object sender, EventArgs e)
		{
			if(gridMotivosTareas.SelectedItems.Count > 0)
			{
				businessrules.EstadisticaOrdenReparacionMotivoOrdenReparacion motivo = (businessrules.EstadisticaOrdenReparacionMotivoOrdenReparacion) gridMotivosTareas.SelectedItems[0].GetRow().DataRow;	
				_uiController.EstadisticaOrdenReparacionMotivoOrdenReparacionDetSeleccionado = motivo;
			}

		}

		private void gridMotivosTareas_CellValueChanged(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
		{
			gridMotivosTareas.UpdateData();
			int index = gridMotivosTareas.SelectedItems[0].Position;
			_uiController.ModifyMotivoTarea(index);		
			this.RefreshMotivosTareaHijos(this, new EventArgs());
		}

		private void chkMotivosTareasHijos_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			int index = e.Index;
			bool seleccionado = e.NewValue.Equals(System.Windows.Forms.CheckState.Checked);
			_uiController.ModifyMotivoTareaHijo(index, seleccionado);		
		}

		private void RefreshMotivosTareaHijos(object sender, EventArgs e)
		{			
			chkMotivosTareasHijos.Items.Clear();
			chkMotivosTareasHijos.Items.AddRange(_uiController.MotivosTareaHijos.ToArray());
			int i = 0;
			foreach(businessrules.EstadisticaOrdenReparacionMotivoOrdenReparacion motivoH in _uiController.MotivosTareaHijos)
			{
				if(motivoH.Estado.Equals("EXISTE")|| motivoH.Estado.Equals("NEW"))
					chkMotivosTareasHijos.SetItemChecked(i, true);
				i++;
			}

		}

		private void gridResultado_SelectionChanged(object sender, EventArgs e)
		{
			if(gridResultado.SelectedItems.Count > 0)
			{
				businessrules.EstadisticaOrdenReparacionDet tareaSeleccionada = (businessrules.EstadisticaOrdenReparacionDet)gridResultado.SelectedItems[0].GetRow().DataRow;
				_uiController.TareaSeleccionada = tareaSeleccionada;
				if(!businessrules.Security.IdPerfil.Equals(Convert.ToInt64(14))) //Si no es supervisor
				{
					if(businessrules.Security.IdPersona.Equals(tareaSeleccionada.IdPersona))
						ultraExplorerBarContainerControl6.Enabled = true;
					else
						ultraExplorerBarContainerControl6.Enabled = false;
				}

				gridMotivosTareas.SetDataBinding(null, null);
				gridMotivosTareas.SetDataBinding(_uiController.MotivosTareaPadres, null);

				chkMotivosTareasHijos.Items.Clear();
				chkMotivosTareasHijos.Items.AddRange(_uiController.MotivosTareaHijos.ToArray());
				int i = 0;
				foreach(businessrules.EstadisticaOrdenReparacionMotivoOrdenReparacion motivoH in _uiController.MotivosTareaHijos)
				{
					if(motivoH.Estado.Equals("EXISTE") || motivoH.Estado.Equals("NEW"))
						chkMotivosTareasHijos.SetItemChecked(i, true);
					i++;
				}

			}

		}
	}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controls;
using mz.erp.ui.controllers;
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.businessrules.comprobantes;
using mz.erp.ui.forms.classes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmEditarComprobanteDeVenta.
	/// </summary>
	public class FrmEditarComprobanteDeVenta : System.Windows.Forms.Form, ITaskForm, ISearchObjectListener
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private mz.erp.ui.controls.mzCuentasControl mzCmbCuenta;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private Infragistics.Win.Misc.UltraLabel ultraLabel6;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private mz.erp.ui.controls.mzComboEditor mzCECondicionesDeVenta;
		private Infragistics.Win.Misc.UltraLabel ultraLabel3;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo cldFechaComprobante;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtTipoDeComprobante;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit txtNumero;
		private mz.erp.ui.controls.mzComboEditor mzCEResponsableEmision;
		private Infragistics.Win.Misc.UltraLabel ultraLabel2;
		private Infragistics.Win.Misc.UltraLabel ultraLabel5;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private System.Windows.Forms.Label label9;
		private Janus.Windows.GridEX.GridEX gridVariablesUsuario;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private System.Windows.Forms.Label labelTarea;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl6;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtObservaciones;
		private System.ComponentModel.IContainer components;

		#region Constructores y Destructores
		
		public FrmEditarComprobanteDeVenta(EditarComprobanteDeVentaController UIController)
		{
			_uiController = UIController;
			InitializeComponent();
		}

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

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmEditarComprobanteDeVenta));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.mzCmbCuenta = new mz.erp.ui.controls.mzCuentasControl();
			this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
			this.mzCECondicionesDeVenta = new mz.erp.ui.controls.mzComboEditor();
			this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
			this.cldFechaComprobante = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.txtTipoDeComprobante = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.txtNumero = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
			this.mzCEResponsableEmision = new mz.erp.ui.controls.mzComboEditor();
			this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraExplorerBarContainerControl6 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.txtObservaciones = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.label9 = new System.Windows.Forms.Label();
			this.gridVariablesUsuario = new Janus.Windows.GridEX.GridEX();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl4.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCECondicionesDeVenta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cldFechaComprobante)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTipoDeComprobante)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEResponsableEmision)).BeginInit();
			this.ultraExplorerBarContainerControl6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtObservaciones)).BeginInit();
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridVariablesUsuario)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl4
			// 
			this.ultraExplorerBarContainerControl4.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, -23);
			this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
			this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(854, 26);
			this.ultraExplorerBarContainerControl4.TabIndex = 5;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(854, 23);
			this.labelTarea.TabIndex = 0;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbCuenta);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel4);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel6);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCECondicionesDeVenta);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.cldFechaComprobante);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtTipoDeComprobante);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtNumero);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEResponsableEmision);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel5);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, -87);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(854, 78);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// mzCmbCuenta
			// 
			this.mzCmbCuenta.AllowEditClientePaso = false;
			this.mzCmbCuenta.BackColor = System.Drawing.SystemColors.Control;
			this.mzCmbCuenta.DataValue = "";
			this.mzCmbCuenta.EnableCtaCte = false;
			this.mzCmbCuenta.FastSearch = false;
			this.mzCmbCuenta.Location = new System.Drawing.Point(120, 25);
			this.mzCmbCuenta.Name = "mzCmbCuenta";
			this.mzCmbCuenta.SearchObjectListener = null;
			this.mzCmbCuenta.Size = new System.Drawing.Size(440, 24);
			this.mzCmbCuenta.TabIndex = 1;
			// 
			// ultraLabel4
			// 
			appearance1.TextHAlign = Infragistics.Win.HAlign.Right;
			this.ultraLabel4.Appearance = appearance1;
			this.ultraLabel4.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel4.Location = new System.Drawing.Point(10, 54);
			this.ultraLabel4.Name = "ultraLabel4";
			this.ultraLabel4.Size = new System.Drawing.Size(104, 16);
			this.ultraLabel4.TabIndex = 36;
			this.ultraLabel4.Text = "Condición de venta";
			// 
			// ultraLabel6
			// 
			appearance2.TextHAlign = Infragistics.Win.HAlign.Right;
			this.ultraLabel6.Appearance = appearance2;
			this.ultraLabel6.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel6.Location = new System.Drawing.Point(-4, 6);
			this.ultraLabel6.Name = "ultraLabel6";
			this.ultraLabel6.Size = new System.Drawing.Size(120, 20);
			this.ultraLabel6.TabIndex = 35;
			this.ultraLabel6.Text = "Responsable emisión";
			// 
			// ultraLabel1
			// 
			appearance3.TextHAlign = Infragistics.Win.HAlign.Right;
			this.ultraLabel1.Appearance = appearance3;
			this.ultraLabel1.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel1.Location = new System.Drawing.Point(50, 30);
			this.ultraLabel1.Name = "ultraLabel1";
			this.ultraLabel1.Size = new System.Drawing.Size(62, 16);
			this.ultraLabel1.TabIndex = 34;
			this.ultraLabel1.Text = "Cuenta";
			// 
			// mzCECondicionesDeVenta
			// 
			this.mzCECondicionesDeVenta.AutoComplete = true;
			this.mzCECondicionesDeVenta.DataSource = null;
			this.mzCECondicionesDeVenta.DisplayMember = "";
			this.mzCECondicionesDeVenta.DisplayMemberCaption = "";
			this.mzCECondicionesDeVenta.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCECondicionesDeVenta.Location = new System.Drawing.Point(120, 50);
			this.mzCECondicionesDeVenta.MaxItemsDisplay = 8;
			this.mzCECondicionesDeVenta.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCECondicionesDeVenta.Name = "mzCECondicionesDeVenta";
			this.mzCECondicionesDeVenta.Size = new System.Drawing.Size(224, 21);
			this.mzCECondicionesDeVenta.SorterMember = "";
			this.mzCECondicionesDeVenta.TabIndex = 2;
			this.mzCECondicionesDeVenta.ValueMember = "";
			this.mzCECondicionesDeVenta.ValueMemberCaption = "";
			// 
			// ultraLabel3
			// 
			appearance4.TextHAlign = Infragistics.Win.HAlign.Right;
			this.ultraLabel3.Appearance = appearance4;
			this.ultraLabel3.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel3.Location = new System.Drawing.Point(605, 30);
			this.ultraLabel3.Name = "ultraLabel3";
			this.ultraLabel3.Size = new System.Drawing.Size(62, 11);
			this.ultraLabel3.TabIndex = 28;
			this.ultraLabel3.Text = "Fecha";
			// 
			// cldFechaComprobante
			// 
			dateButton1.Caption = "Today";
			this.cldFechaComprobante.DateButtons.Add(dateButton1);
			this.cldFechaComprobante.Location = new System.Drawing.Point(672, 26);
			this.cldFechaComprobante.Name = "cldFechaComprobante";
			this.cldFechaComprobante.NonAutoSizeHeight = 23;
			this.cldFechaComprobante.Size = new System.Drawing.Size(100, 21);
			this.cldFechaComprobante.TabIndex = 4;
			this.cldFechaComprobante.Value = new System.DateTime(2005, 8, 15, 0, 0, 0, 0);
			// 
			// txtTipoDeComprobante
			// 
			this.txtTipoDeComprobante.Location = new System.Drawing.Point(672, 2);
			this.txtTipoDeComprobante.Name = "txtTipoDeComprobante";
			this.txtTipoDeComprobante.Size = new System.Drawing.Size(159, 21);
			this.txtTipoDeComprobante.TabIndex = 3;
			this.txtTipoDeComprobante.Text = "txtTipoDeComprobante";
			// 
			// txtNumero
			// 
			this.txtNumero.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
			this.txtNumero.InputMask = "#-####-########";
			this.txtNumero.Location = new System.Drawing.Point(672, 50);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.TabIndex = 5;
			this.txtNumero.Text = "A--";
			// 
			// mzCEResponsableEmision
			// 
			this.mzCEResponsableEmision.AutoComplete = true;
			this.mzCEResponsableEmision.DataSource = null;
			this.mzCEResponsableEmision.DisplayMember = "";
			this.mzCEResponsableEmision.DisplayMemberCaption = "";
			this.mzCEResponsableEmision.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEResponsableEmision.Location = new System.Drawing.Point(120, 2);
			this.mzCEResponsableEmision.MaxItemsDisplay = 8;
			this.mzCEResponsableEmision.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEResponsableEmision.Name = "mzCEResponsableEmision";
			this.mzCEResponsableEmision.Size = new System.Drawing.Size(224, 21);
			this.mzCEResponsableEmision.SorterMember = "";
			this.mzCEResponsableEmision.TabIndex = 0;
			this.mzCEResponsableEmision.ValueMember = "";
			this.mzCEResponsableEmision.ValueMemberCaption = "";
			// 
			// ultraLabel2
			// 
			appearance5.TextHAlign = Infragistics.Win.HAlign.Right;
			this.ultraLabel2.Appearance = appearance5;
			this.ultraLabel2.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel2.Location = new System.Drawing.Point(552, 6);
			this.ultraLabel2.Name = "ultraLabel2";
			this.ultraLabel2.Size = new System.Drawing.Size(116, 16);
			this.ultraLabel2.TabIndex = 32;
			this.ultraLabel2.Text = "Tipo de comprobante";
			// 
			// ultraLabel5
			// 
			appearance6.TextHAlign = Infragistics.Win.HAlign.Right;
			this.ultraLabel5.Appearance = appearance6;
			this.ultraLabel5.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel5.Location = new System.Drawing.Point(605, 54);
			this.ultraLabel5.Name = "ultraLabel5";
			this.ultraLabel5.Size = new System.Drawing.Size(62, 11);
			this.ultraLabel5.TabIndex = 27;
			this.ultraLabel5.Text = "Número";
			// 
			// ultraExplorerBarContainerControl6
			// 
			this.ultraExplorerBarContainerControl6.Controls.Add(this.txtObservaciones);
			this.ultraExplorerBarContainerControl6.Location = new System.Drawing.Point(28, 50);
			this.ultraExplorerBarContainerControl6.Name = "ultraExplorerBarContainerControl6";
			this.ultraExplorerBarContainerControl6.Size = new System.Drawing.Size(854, 150);
			this.ultraExplorerBarContainerControl6.TabIndex = 6;
			// 
			// txtObservaciones
			// 
			this.txtObservaciones.AcceptsReturn = true;
			this.txtObservaciones.AcceptsTab = true;
			this.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtObservaciones.Location = new System.Drawing.Point(0, 0);
			this.txtObservaciones.Multiline = true;
			this.txtObservaciones.Name = "txtObservaciones";
			this.txtObservaciones.Size = new System.Drawing.Size(854, 150);
			this.txtObservaciones.TabIndex = 0;
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Controls.Add(this.label9);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.gridVariablesUsuario);
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 259);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(854, 150);
			this.ultraExplorerBarContainerControl5.TabIndex = 4;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(0, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 16);
			this.label9.TabIndex = 25;
			this.label9.Text = "Otros datos";
			// 
			// gridVariablesUsuario
			// 
			this.gridVariablesUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.gridVariablesUsuario.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell;
			this.gridVariablesUsuario.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridVariablesUsuario.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridVariablesUsuario.Location = new System.Drawing.Point(0, 16);
			this.gridVariablesUsuario.Name = "gridVariablesUsuario";
			this.gridVariablesUsuario.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridVariablesUsuario.Size = new System.Drawing.Size(848, 136);
			this.gridVariablesUsuario.TabIndex = 0;
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
			this.toolBarStandar.Size = new System.Drawing.Size(920, 28);
			this.toolBarStandar.TabIndex = 19;
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
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl6);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl4;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 26;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 78;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Datos de Cabecera";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl6;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Observaciones";
			ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl5;
			ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup4.Text = "Informacion Adicional";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3,
																														ultraExplorerBarGroup4});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(920, 434);
			this.ultraExplorerBar1.TabIndex = 20;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// FrmEditarComprobanteDeVenta
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(920, 462);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmEditarComprobanteDeVenta";
			this.Text = "FrmEditarComprobanteDeVenta";
			this.ultraExplorerBarContainerControl4.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCECondicionesDeVenta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cldFechaComprobante)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTipoDeComprobante)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEResponsableEmision)).EndInit();
			this.ultraExplorerBarContainerControl6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtObservaciones)).EndInit();
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridVariablesUsuario)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Variables Privadas

			private EditarComprobanteDeVentaController _uiController = null;

		#endregion

		#region Metodos Privados

		private void Build_UI()
		{
			ConfigureInterface();
			InitEventHandlers();
			InitializeData();
			FillControls();
			InitDataBindings();
		}

		private void ConfigureInterface()
		{	
			mzCmbCuenta.Init(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName());
			gridVariablesUsuario.GroupByBoxVisible = false;
			gridVariablesUsuario.LayoutData = _uiController.LayoutVariables;
			labelTarea.Text = _uiController.LeyendaFormulario;
			this.Text = _uiController.Caption;	
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;			

			
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			mzCmbCuenta.Enabled = _uiController.AllowEditCuenta;			
			mzCECondicionesDeVenta.Enabled = _uiController.AllowEditCondicionDeVenta;
			txtNumero.Enabled = _uiController.AllowEditNumeration;
			txtTipoDeComprobante.Enabled = _uiController.AllowEditTipoDeComprobante;
			cldFechaComprobante.Enabled = _uiController.AllowEditFecha;
			mzCEResponsableEmision.Enabled = _uiController.AllowEditResponsableEmision;
			gridVariablesUsuario.Enabled = _uiController.AllowEditVariablesAuxiliares;
			txtObservaciones.Enabled = _uiController.AllowEditObservaciones;
			gridVariablesUsuario.Enabled = _uiController.AllowEditVariablesAuxiliares;
			KeyPreview = true;
			
		}
			
		private void InitEventHandlers()
		{
			mzCmbCuenta.ValueChanged+= new System.EventHandler( this.Componentes_Changes );			
			mzCmbCuenta.AllowEditClientePaso = true;
			mzCmbCuenta.SearchObjectListener = this;
			mzCEResponsableEmision.FillFromDataSource(businessrules.data.UsuariosPersonas.GetList(), "IdPersona","Nombre",200,"ID","Nombre","Nombre");			
			mzCECondicionesDeVenta.FillFromDataSource(_uiController.TableCondicionesDeVenta, "IdCondicionDeVenta","Descripcion",200,"ID","Descripcion",_uiController.HabilitaOrden?"Orden":"Descripcion");			
			gridVariablesUsuario.DoubleClick +=new EventHandler(gridVariablesUsuario_DoubleClick);
			this.toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			this.Closed +=new EventHandler(FrmComprobantesDeVenta_Closed);
			KeyDownManager KeyDownMan = new KeyDownManager(this);	


		
		}

		private void DumpControls()
		{
			_uiController.Numero = txtNumero.Text;
			_uiController.Observaciones = txtObservaciones. Text;
			_uiController.FechaEmision = Convert.ToDateTime(cldFechaComprobante.Value);
			_uiController.IdCondicionDeVenta = Convert.ToString(mzCECondicionesDeVenta.Value);

		}
		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{

			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					_uiController.Previous();
					break;
				case 2:
					mz.erp.ui.utility.Util.MoveFocus(ultraExplorerBarContainerControl1);
					DumpControls();
					_uiController.Execute();
					break;
				case 4:
					CloseForm();
					break;
			}		
			

		}


		private void FillControls()
		{
			txtTipoDeComprobante.Text = _uiController.NombreDeComprobante;
			txtNumero.InputMask = _uiController.Mascara;
			txtNumero.Text = _uiController.Numero;
			txtObservaciones. Text = _uiController.Observaciones;
			cldFechaComprobante.Value = _uiController.FechaEmision;
			mzCECondicionesDeVenta.Value = _uiController.IdCondicionDeVenta;
		}

		private void InitDataBindings()
		{
			
			mzCEResponsableEmision.DataBindings.Add("Value", _uiController,"IdResponsable");
			gridVariablesUsuario.SetDataBinding(_uiController.VariablesDeUsuario, null);
			
		}

		private void Componentes_Changes( object sender, System.EventArgs e )
		{			
			_uiController.CodigoCuenta = Convert.ToString(mzCmbCuenta.DataValue);				
		}

		private void InitializeData()
		{	
			mzCmbCuenta.DataValue = _uiController.CodigoCuenta;
		}

		private void gridVariablesUsuario_DoubleClick(object sender, EventArgs e)
		{
			if(gridVariablesUsuario.SelectedItems.Count > 0 && gridVariablesUsuario.SelectedItems[0].GetRow().RowType.Equals(Janus.Windows.GridEX.RowType.Record))
			{
				VariableAuxiliar var = (VariableAuxiliar)gridVariablesUsuario.GetRow().DataRow;
				FrmInputType frmInputType = new FrmInputType(var.Descripcion,var,"Valor",var.DataType,typeof(mz.erp.businessrules.comprobantes.VariableAuxiliar));
				frmInputType.ShowDialog();
				gridVariablesUsuario.SetDataBinding(null, null);
				gridVariablesUsuario.SetDataBinding(_uiController.VariablesDeUsuario,null);
			}
		}

			
		private void FrmComprobantesDeVenta_Closed(object sender, EventArgs e)
		{
			ClearDataBindings();
			ClearEventHandlers();
		}

		private void ClearDataBindings()
		{

		}

		private void ClearEventHandlers()
		{

		}


		


		#endregion

		#region Miembros de ITaskForm

		public virtual void ShowForm()
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
			mz.erp.ui.utility.Util.MoveFocus(ultraExplorerBarContainerControl1);
			DumpControls();
			_uiController.Execute();
		}

		public void Execute()
		{
			this._uiController.Execute();
		}

		public void Previous()
		{
			this._uiController.Previous();
		}

		#endregion

		#region Miembros de ISearchObjectListener

		public void processEventChange(object sender, EventArgs e)
		{
			// TODO: agregar la implementación FrmEditarComprobanteDeVenta.processEventChange
		}

		#endregion

		
	}
}

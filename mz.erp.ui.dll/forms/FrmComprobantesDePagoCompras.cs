using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.forms.classes;
using mz.erp.businessrules.comprobantes;
using mz.erp.ui.controllers;
using mz.erp.commontypes;
using mz.erp.businessrules;
using Janus.Windows.GridEX;
using Infragistics.Win.UltraWinExplorerBar;
using mz.erp.ui.utility;


namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmComprobantesDePagoCompras.
	/// </summary>
	public class FrmComprobantesDePagoCompras : System.Windows.Forms.Form, ITaskForm, ISearchObjectListener
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMENumero;
		private mz.erp.ui.controls.mzComboEditor mzCEResponsableEmision;
		private mz.erp.ui.controls.mzComboEditor mzCEInstanciasCaja;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private Infragistics.Win.Misc.UltraLabel ultraLabel6;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel3;
		private Infragistics.Win.Misc.UltraLabel ultraLabel5;
		private mz.erp.ui.controls.mzComboEditor mzCmbTipoComprobante;
		private Infragistics.Win.Misc.UltraLabel ultraLabel2;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo cldFechaComprobante;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Janus.Windows.GridEX.GridEX gridCompAImputar;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalImputado;
		private System.Windows.Forms.Label label8;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl6;
		private Infragistics.Win.Misc.UltraButton ubBuscar;
		private Infragistics.Win.Misc.UltraButton ubEliminar;
		private Infragistics.Win.Misc.UltraButton ubAgregar;
		private System.Windows.Forms.Label label1;
		private Janus.Windows.GridEX.GridEX gridEXValores;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalValores;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Label labelTarea;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor uTEObservaciones;
		private System.ComponentModel.IContainer components;
		private Infragistics.Win.Misc.UltraButton utbCalcularRetenciones;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItemEditar;
		private System.Windows.Forms.MenuItem menuItemEliminar;
		private System.Windows.Forms.Label label2;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneSaldo;
		private mz.erp.ui.controls.mzProveedoresControl mzCmb;
        private CheckBox chckImputaAutomaticamente;

		
		#region Variables Privadas

			private mz.erp.ui.controllers.IngresarComprobanteDePagoComprasController _uiController;

		#endregion

		#region Constructores y Destructores
		
		public FrmComprobantesDePagoCompras(IngresarComprobanteDePagoComprasController uiController)
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
				_uiController.ComprobanteHasChanged -=new EventHandler(Refresh);
				BindingController.Clear(ultraMENumero,"Text", _uiController, "Numero" );
				BindingController.Clear(mzCEResponsableEmision,"Value", _uiController,"IdResponsable");
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
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComprobantesDePagoCompras));
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.labelTarea = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.mzCmb = new mz.erp.ui.controls.mzProveedoresControl();
            this.ultraMENumero = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.mzCEResponsableEmision = new mz.erp.ui.controls.mzComboEditor();
            this.mzCEInstanciasCaja = new mz.erp.ui.controls.mzComboEditor();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.mzCmbTipoComprobante = new mz.erp.ui.controls.mzComboEditor();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.cldFechaComprobante = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.ultraExplorerBarContainerControl6 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.chckImputaAutomaticamente = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uneSaldo = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.utbCalcularRetenciones = new Infragistics.Win.Misc.UltraButton();
            this.ubBuscar = new Infragistics.Win.Misc.UltraButton();
            this.ubEliminar = new Infragistics.Win.Misc.UltraButton();
            this.ubAgregar = new Infragistics.Win.Misc.UltraButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gridEXValores = new Janus.Windows.GridEX.GridEX();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItemEditar = new System.Windows.Forms.MenuItem();
            this.menuItemEliminar = new System.Windows.Forms.MenuItem();
            this.uneTotalValores = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.gridCompAImputar = new Janus.Windows.GridEX.GridEX();
            this.uneTotalImputado = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label8 = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.uTEObservaciones = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.imglStandar = new System.Windows.Forms.ImageList(this.components);
            this.toolBarStandar = new System.Windows.Forms.ToolBar();
            this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
            this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
            this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.ultraExplorerBarContainerControl2.SuspendLayout();
            this.ultraExplorerBarContainerControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEResponsableEmision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEInstanciasCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbTipoComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cldFechaComprobante)).BeginInit();
            this.ultraExplorerBarContainerControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneSaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXValores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalValores)).BeginInit();
            this.ultraExplorerBarContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompAImputar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalImputado)).BeginInit();
            this.ultraExplorerBarContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uTEObservaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
            this.ultraExplorerBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraExplorerBarContainerControl2
            // 
            this.ultraExplorerBarContainerControl2.Controls.Add(this.labelTarea);
            this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 24);
            this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
            this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(902, 24);
            this.ultraExplorerBarContainerControl2.TabIndex = 9;
            // 
            // labelTarea
            // 
            this.labelTarea.BackColor = System.Drawing.Color.Transparent;
            this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarea.Location = new System.Drawing.Point(0, 0);
            this.labelTarea.Name = "labelTarea";
            this.labelTarea.Size = new System.Drawing.Size(902, 23);
            this.labelTarea.TabIndex = 1;
            this.labelTarea.Text = "Tarea";
            this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ultraExplorerBarContainerControl5
            // 
            this.ultraExplorerBarContainerControl5.Controls.Add(this.mzCmb);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.ultraMENumero);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.mzCEResponsableEmision);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.mzCEInstanciasCaja);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.ultraLabel4);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.ultraLabel6);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.ultraLabel1);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.ultraLabel3);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.ultraLabel5);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.mzCmbTipoComprobante);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.ultraLabel2);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.cldFechaComprobante);
            this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 105);
            this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
            this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(902, 70);
            this.ultraExplorerBarContainerControl5.TabIndex = 6;
            // 
            // mzCmb
            // 
            this.mzCmb.BackColor = System.Drawing.SystemColors.Control;
            this.mzCmb.DataValue = "";
            this.mzCmb.EnableCtaCte = false;
            this.mzCmb.FastSearch = false;
            this.mzCmb.Location = new System.Drawing.Point(112, 24);
            this.mzCmb.Name = "mzCmb";
            this.mzCmb.SearchObjectListener = null;
            this.mzCmb.Size = new System.Drawing.Size(490, 22);
            this.mzCmb.TabIndex = 1;
            this.mzCmb.Tag = "ResponsableEmision";
            // 
            // ultraMENumero
            // 
            this.ultraMENumero.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.ultraMENumero.InputMask = "\\A-####-########";
            this.ultraMENumero.Location = new System.Drawing.Point(720, 44);
            this.ultraMENumero.Name = "ultraMENumero";
            this.ultraMENumero.Size = new System.Drawing.Size(152, 20);
            this.ultraMENumero.TabIndex = 5;
            this.ultraMENumero.Text = "A--";
            this.ultraMENumero.Leave += new System.EventHandler(this.ultraMENumero_Leave);
            // 
            // mzCEResponsableEmision
            // 
            this.mzCEResponsableEmision.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEResponsableEmision.DisplayMember = "";
            this.mzCEResponsableEmision.DisplayMemberCaption = "";
            this.mzCEResponsableEmision.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEResponsableEmision.Location = new System.Drawing.Point(112, 0);
            this.mzCEResponsableEmision.MaxItemsDisplay = 7;
            this.mzCEResponsableEmision.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEResponsableEmision.Name = "mzCEResponsableEmision";
            this.mzCEResponsableEmision.Size = new System.Drawing.Size(152, 21);
            this.mzCEResponsableEmision.SorterMember = "";
            this.mzCEResponsableEmision.TabIndex = 0;
            this.mzCEResponsableEmision.ValueMember = "";
            this.mzCEResponsableEmision.ValueMemberCaption = "";
            // 
            // mzCEInstanciasCaja
            // 
            this.mzCEInstanciasCaja.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEInstanciasCaja.DisplayMember = "";
            this.mzCEInstanciasCaja.DisplayMemberCaption = "";
            this.mzCEInstanciasCaja.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEInstanciasCaja.Location = new System.Drawing.Point(112, 48);
            this.mzCEInstanciasCaja.MaxItemsDisplay = 7;
            this.mzCEInstanciasCaja.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEInstanciasCaja.Name = "mzCEInstanciasCaja";
            this.mzCEInstanciasCaja.Size = new System.Drawing.Size(152, 21);
            this.mzCEInstanciasCaja.SorterMember = "";
            this.mzCEInstanciasCaja.TabIndex = 2;
            this.mzCEInstanciasCaja.ValueMember = "";
            this.mzCEInstanciasCaja.ValueMemberCaption = "";
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel4.Location = new System.Drawing.Point(0, 46);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(120, 16);
            this.ultraLabel4.TabIndex = 27;
            this.ultraLabel4.Text = "Instancia de Caja";
            // 
            // ultraLabel6
            // 
            this.ultraLabel6.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel6.Location = new System.Drawing.Point(0, 0);
            this.ultraLabel6.Name = "ultraLabel6";
            this.ultraLabel6.Size = new System.Drawing.Size(120, 16);
            this.ultraLabel6.TabIndex = 26;
            this.ultraLabel6.Text = "Responsable Emisión";
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel1.Location = new System.Drawing.Point(0, 23);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(120, 16);
            this.ultraLabel1.TabIndex = 25;
            this.ultraLabel1.Text = "Proveedor";
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel3.Location = new System.Drawing.Point(608, 24);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(96, 16);
            this.ultraLabel3.TabIndex = 24;
            this.ultraLabel3.Text = "Fecha";
            // 
            // ultraLabel5
            // 
            this.ultraLabel5.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel5.Location = new System.Drawing.Point(608, 47);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.Size = new System.Drawing.Size(120, 16);
            this.ultraLabel5.TabIndex = 23;
            this.ultraLabel5.Text = "Número";
            // 
            // mzCmbTipoComprobante
            // 
            this.mzCmbTipoComprobante.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbTipoComprobante.DisplayMember = "";
            this.mzCmbTipoComprobante.DisplayMemberCaption = "";
            this.mzCmbTipoComprobante.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbTipoComprobante.Location = new System.Drawing.Point(720, 0);
            this.mzCmbTipoComprobante.MaxItemsDisplay = 7;
            this.mzCmbTipoComprobante.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbTipoComprobante.Name = "mzCmbTipoComprobante";
            this.mzCmbTipoComprobante.Size = new System.Drawing.Size(152, 21);
            this.mzCmbTipoComprobante.SorterMember = "";
            this.mzCmbTipoComprobante.TabIndex = 3;
            this.mzCmbTipoComprobante.ValueMember = "";
            this.mzCmbTipoComprobante.ValueMemberCaption = "";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel2.Location = new System.Drawing.Point(608, 1);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(120, 16);
            this.ultraLabel2.TabIndex = 22;
            this.ultraLabel2.Text = "Tipo de Comprobante";
            // 
            // cldFechaComprobante
            // 
            this.cldFechaComprobante.BackColor = System.Drawing.SystemColors.Window;
            this.cldFechaComprobante.DateButtons.Add(dateButton1);
            this.cldFechaComprobante.Enabled = false;
            this.cldFechaComprobante.Location = new System.Drawing.Point(720, 21);
            this.cldFechaComprobante.Name = "cldFechaComprobante";
            this.cldFechaComprobante.NonAutoSizeHeight = 23;
            this.cldFechaComprobante.Size = new System.Drawing.Size(152, 21);
            this.cldFechaComprobante.TabIndex = 4;
            this.cldFechaComprobante.Value = new System.DateTime(2008, 5, 27, 0, 0, 0, 0);
            // 
            // ultraExplorerBarContainerControl6
            // 
            this.ultraExplorerBarContainerControl6.Controls.Add(this.chckImputaAutomaticamente);
            this.ultraExplorerBarContainerControl6.Controls.Add(this.label2);
            this.ultraExplorerBarContainerControl6.Controls.Add(this.uneSaldo);
            this.ultraExplorerBarContainerControl6.Controls.Add(this.utbCalcularRetenciones);
            this.ultraExplorerBarContainerControl6.Controls.Add(this.ubBuscar);
            this.ultraExplorerBarContainerControl6.Controls.Add(this.ubEliminar);
            this.ultraExplorerBarContainerControl6.Controls.Add(this.ubAgregar);
            this.ultraExplorerBarContainerControl6.Controls.Add(this.label1);
            this.ultraExplorerBarContainerControl6.Controls.Add(this.gridEXValores);
            this.ultraExplorerBarContainerControl6.Controls.Add(this.uneTotalValores);
            this.ultraExplorerBarContainerControl6.Location = new System.Drawing.Point(28, 232);
            this.ultraExplorerBarContainerControl6.Name = "ultraExplorerBarContainerControl6";
            this.ultraExplorerBarContainerControl6.Size = new System.Drawing.Size(902, 182);
            this.ultraExplorerBarContainerControl6.TabIndex = 8;
            // 
            // chckImputaAutomaticamente
            // 
            this.chckImputaAutomaticamente.BackColor = System.Drawing.Color.Transparent;
            this.chckImputaAutomaticamente.Location = new System.Drawing.Point(426, 0);
            this.chckImputaAutomaticamente.Name = "chckImputaAutomaticamente";
            this.chckImputaAutomaticamente.Size = new System.Drawing.Size(163, 21);
            this.chckImputaAutomaticamente.TabIndex = 4;
            this.chckImputaAutomaticamente.Text = "Imputar Automáticamente";
            this.chckImputaAutomaticamente.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(728, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 35;
            this.label2.Text = "Saldo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uneSaldo
            // 
            this.uneSaldo.Location = new System.Drawing.Point(776, 3);
            this.uneSaldo.Name = "uneSaldo";
            this.uneSaldo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneSaldo.Size = new System.Drawing.Size(96, 21);
            this.uneSaldo.TabIndex = 6;
            this.uneSaldo.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // utbCalcularRetenciones
            // 
            this.utbCalcularRetenciones.Location = new System.Drawing.Point(288, 0);
            this.utbCalcularRetenciones.Name = "utbCalcularRetenciones";
            this.utbCalcularRetenciones.Size = new System.Drawing.Size(128, 24);
            this.utbCalcularRetenciones.TabIndex = 3;
            this.utbCalcularRetenciones.Text = "&Calcular Retenciones";
            // 
            // ubBuscar
            // 
            this.ubBuscar.Location = new System.Drawing.Point(192, 0);
            this.ubBuscar.Name = "ubBuscar";
            this.ubBuscar.Size = new System.Drawing.Size(96, 24);
            this.ubBuscar.TabIndex = 2;
            this.ubBuscar.Text = "&Buscar";
            // 
            // ubEliminar
            // 
            this.ubEliminar.Location = new System.Drawing.Point(96, 0);
            this.ubEliminar.Name = "ubEliminar";
            this.ubEliminar.Size = new System.Drawing.Size(96, 24);
            this.ubEliminar.TabIndex = 1;
            this.ubEliminar.Text = "&Eliminar";
            // 
            // ubAgregar
            // 
            this.ubAgregar.Location = new System.Drawing.Point(0, 0);
            this.ubAgregar.Name = "ubAgregar";
            this.ubAgregar.Size = new System.Drawing.Size(96, 24);
            this.ubAgregar.TabIndex = 0;
            this.ubAgregar.Text = "&Agregar";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(576, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 31;
            this.label1.Text = "Total";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gridEXValores
            // 
            this.gridEXValores.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXValores.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridEXValores.ContextMenu = this.contextMenu1;
            this.gridEXValores.ContinuousScroll = false;
            this.gridEXValores.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridEXValores.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridEXValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridEXValores.GroupByBoxVisible = false;
            this.gridEXValores.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridEXValores.Location = new System.Drawing.Point(0, 24);
            this.gridEXValores.Name = "gridEXValores";
            this.gridEXValores.Size = new System.Drawing.Size(872, 160);
            this.gridEXValores.TabIndex = 7;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemEditar,
            this.menuItemEliminar});
            // 
            // menuItemEditar
            // 
            this.menuItemEditar.Index = 0;
            this.menuItemEditar.Text = "Editar";
            // 
            // menuItemEliminar
            // 
            this.menuItemEliminar.Index = 1;
            this.menuItemEliminar.Text = "Eliminar";
            // 
            // uneTotalValores
            // 
            this.uneTotalValores.Location = new System.Drawing.Point(624, 3);
            this.uneTotalValores.Name = "uneTotalValores";
            this.uneTotalValores.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneTotalValores.Size = new System.Drawing.Size(96, 21);
            this.uneTotalValores.TabIndex = 5;
            this.uneTotalValores.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraExplorerBarContainerControl1
            // 
            this.ultraExplorerBarContainerControl1.Controls.Add(this.gridCompAImputar);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.uneTotalImputado);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label8);
            this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 471);
            this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(902, 157);
            this.ultraExplorerBarContainerControl1.TabIndex = 7;
            // 
            // gridCompAImputar
            // 
            this.gridCompAImputar.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridCompAImputar.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridCompAImputar.GroupByBoxVisible = false;
            this.gridCompAImputar.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridCompAImputar.Location = new System.Drawing.Point(0, 22);
            this.gridCompAImputar.Name = "gridCompAImputar";
            this.gridCompAImputar.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridCompAImputar.Size = new System.Drawing.Size(792, 128);
            this.gridCompAImputar.TabIndex = 0;
            // 
            // uneTotalImputado
            // 
            this.uneTotalImputado.Location = new System.Drawing.Point(696, 0);
            this.uneTotalImputado.Name = "uneTotalImputado";
            this.uneTotalImputado.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneTotalImputado.Size = new System.Drawing.Size(96, 21);
            this.uneTotalImputado.TabIndex = 8;
            this.uneTotalImputado.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(568, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Total";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ultraExplorerBarContainerControl3
            // 
            this.ultraExplorerBarContainerControl3.Controls.Add(this.uTEObservaciones);
            this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
            this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(902, 150);
            this.ultraExplorerBarContainerControl3.TabIndex = 10;
            this.ultraExplorerBarContainerControl3.Visible = false;
            // 
            // uTEObservaciones
            // 
            this.uTEObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uTEObservaciones.Location = new System.Drawing.Point(0, 0);
            this.uTEObservaciones.Multiline = true;
            this.uTEObservaciones.Name = "uTEObservaciones";
            this.uTEObservaciones.Size = new System.Drawing.Size(902, 150);
            this.uTEObservaciones.TabIndex = 1;
            // 
            // imglStandar
            // 
            this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
            this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
           /*
            this.imglStandar.Images.SetKeyName(0, "");
            this.imglStandar.Images.SetKeyName(1, "");
            this.imglStandar.Images.SetKeyName(2, "");
            this.imglStandar.Images.SetKeyName(3, "");
            this.imglStandar.Images.SetKeyName(4, "");
            this.imglStandar.Images.SetKeyName(5, "");
            this.imglStandar.Images.SetKeyName(6, "");
            this.imglStandar.Images.SetKeyName(7, "");
            this.imglStandar.Images.SetKeyName(8, "");
            this.imglStandar.Images.SetKeyName(9, "");
            * */
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
            this.toolBarStandar.Size = new System.Drawing.Size(968, 28);
            this.toolBarStandar.TabIndex = 20;
            this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            // 
            // tbbAnterior
            // 
            this.tbbAnterior.ImageIndex = 9;
            this.tbbAnterior.Name = "tbbAnterior";
            this.tbbAnterior.Text = "&Anterior";
            // 
            // tbbSeparator
            // 
            this.tbbSeparator.Name = "tbbSeparator";
            this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbSiguiente
            // 
            this.tbbSiguiente.ImageIndex = 8;
            this.tbbSiguiente.Name = "tbbSiguiente";
            this.tbbSiguiente.Text = "&Siguiente";
            // 
            // tbbSeparator2
            // 
            this.tbbSeparator2.Name = "tbbSeparator2";
            this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbCancelar
            // 
            this.tbbCancelar.ImageIndex = 7;
            this.tbbCancelar.Name = "tbbCancelar";
            this.tbbCancelar.Text = "&Cancelar";
            // 
            // ultraExplorerBar1
            // 
            this.ultraExplorerBar1.AnimationEnabled = false;
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl6);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
            this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl2;
            ultraExplorerBarGroup1.Settings.ContainerHeight = 24;
            ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup1.Text = "Tarea";
            ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl5;
            ultraExplorerBarGroup2.Key = "Cabecera";
            ultraExplorerBarGroup2.Settings.ContainerHeight = 70;
            ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup2.Text = "Informacion General";
            ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl6;
            ultraExplorerBarGroup3.Key = "Valores";
            ultraExplorerBarGroup3.Settings.ContainerHeight = 182;
            ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup3.Text = "Valores";
            ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl1;
            ultraExplorerBarGroup4.Key = "ComprobantesAImputar";
            ultraExplorerBarGroup4.Settings.ContainerHeight = 157;
            ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup4.Text = "Comprobantes A Imputar";
            ultraExplorerBarGroup5.Container = this.ultraExplorerBarContainerControl3;
            ultraExplorerBarGroup5.Key = "Observaciones";
            ultraExplorerBarGroup5.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup5.Text = "Observaciones";
            this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2,
            ultraExplorerBarGroup3,
            ultraExplorerBarGroup4,
            ultraExplorerBarGroup5});
            this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
            this.ultraExplorerBar1.Name = "ultraExplorerBar1";
            this.ultraExplorerBar1.Size = new System.Drawing.Size(968, 442);
            this.ultraExplorerBar1.TabIndex = 21;
            this.ultraExplorerBar1.TabStop = false;
            // 
            // FrmComprobantesDePagoCompras
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(968, 470);
            this.Controls.Add(this.ultraExplorerBar1);
            this.Controls.Add(this.toolBarStandar);
            this.Name = "FrmComprobantesDePagoCompras";
            this.Text = "FrmComprobantesDePagoCompras";
            this.ultraExplorerBarContainerControl2.ResumeLayout(false);
            this.ultraExplorerBarContainerControl5.ResumeLayout(false);
            this.ultraExplorerBarContainerControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEResponsableEmision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEInstanciasCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbTipoComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cldFechaComprobante)).EndInit();
            this.ultraExplorerBarContainerControl6.ResumeLayout(false);
            this.ultraExplorerBarContainerControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneSaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXValores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalValores)).EndInit();
            this.ultraExplorerBarContainerControl1.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompAImputar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalImputado)).EndInit();
            this.ultraExplorerBarContainerControl3.ResumeLayout(false);
            this.ultraExplorerBarContainerControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uTEObservaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
            this.ultraExplorerBar1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
			Util.MoveFocus(this.ultraExplorerBarContainerControl5);		
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

		#region Inicializadores

		private void Build_UI()
		{
			ConfigureInterface();
			InitializeData();
			InitEventHandlers();
			InitDataBindings();
		}
	
		private void ConfigureInterface()
		{

            utility.Util.LoadImages(toolBarStandar,imglStandar);
            tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			uneTotalImputado.ReadOnly = true;
			uneTotalValores.ReadOnly = true;
			uneSaldo.ReadOnly = true;
			labelTarea.Text = _uiController.LeyendaFormulario;
			this.Text = _uiController.LeyendaFormulario;
			mzCmb.Enabled = _uiController.AllowEditProveedor;
			mzCEResponsableEmision.Enabled = _uiController.AllowEditResponsableEmision;
			mzCmbTipoComprobante.Enabled = _uiController.AllowEditTipoDeComprobante;
			mzCEInstanciasCaja.Enabled = _uiController.AllowEditInstanciaDeCaja;
			ubAgregar.Enabled = _uiController.AllowEditValores;
			ubEliminar.Enabled = _uiController.AllowEditValores;
			tbbAnterior.Text = _uiController.TextoBotonAnterior;			
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;
			ultraMENumero.ReadOnly = !_uiController.AllowEditNumeration;
			ultraMENumero.Enabled = _uiController.AllowEditNumeration;
			ubBuscar.Enabled = _uiController.AllowSearchValores;

			/*Configuracion de los layouts de las grillas*/
			gridEXValores.LayoutData = new mz.erp.ui.controllers.tfi_ValoresEx().GetLayoutValoresPagosCompras();
			gridEXValores.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			gridCompAImputar.LayoutData = new mz.erp.ui.controllers.tsa_CuentaCorriente().GetLayoutDetalleCuentaCorriente(new string [] {"IdComprobante", "Comprobante","Cuota", "FechaEmision","FechaVencimiento","Numero", "Saldo","SignoCtaCte","Importe","Pago"});

			/*Configura condiciones sobre la grilla*/
			Janus.Windows.GridEX.GridEXFormatCondition fc = new Janus.Windows.GridEX.GridEXFormatCondition(this.gridCompAImputar.RootTable.Columns["SignoCtaCte"],
				Janus.Windows.GridEX.ConditionOperator.LessThan,
				0);
			fc.FormatStyle.ForeColor=System.Drawing.Color.Red;
			fc.TargetColumn = this.gridCompAImputar.RootTable.Columns["Saldo"];
			this.gridCompAImputar.RootTable.FormatConditions.Add(fc);
			
			//Format Condition para el campo Importe
			Janus.Windows.GridEX.GridEXFormatCondition fc1 = new Janus.Windows.GridEX.GridEXFormatCondition(this.gridCompAImputar.RootTable.Columns["SignoCtaCte"],
				Janus.Windows.GridEX.ConditionOperator.LessThan,
				0);
			fc1.FormatStyle.ForeColor=System.Drawing.Color.Red;
			fc1.TargetColumn = this.gridCompAImputar.RootTable.Columns["Importe"];
			this.gridCompAImputar.RootTable.FormatConditions.Add(fc1);

            //Sabrina: Tarea 1120. 20110817
            chckImputaAutomaticamente.Enabled = _uiController.AllowEditImputaAutomaticamente;

            //Format Style para los comprobantes Imputados
            Janus.Windows.GridEX.GridEXFormatStyle fs = new Janus.Windows.GridEX.GridEXFormatStyle((Janus.Windows.GridEX.GridEXFormatStyle)gridCompAImputar.RowFormatStyle);
            fs.BackColor = System.Drawing.Color.Gray;
            Janus.Windows.GridEX.ConditionOperator condOp = Janus.Windows.GridEX.ConditionOperator.GreaterThan;
            Janus.Windows.GridEX.GridEXFormatCondition cnd = new Janus.Windows.GridEX.GridEXFormatCondition(gridCompAImputar.RootTable.Columns["Pago"], condOp, Convert.ToInt32(0));
            cnd.FormatStyle = fs;
            gridCompAImputar.RootTable.FormatConditions.Add(cnd);
            //Fin Sabrina: Tarea 1120. 20110817
            
            uneSaldo.FormatString = "$#,##0.00;$#,##0.00;$0.00";	
			uneTotalImputado.FormatString = "$#,##0.00;$#,##0.00;$0.00";	
			uneTotalValores.FormatString = "$#,##0.00;$#,##0.00;$0.00";	
			mzCmb.Init();
			mzCmb.SearchObjectListener = this;
			mzCmb.EnableCtaCte = _uiController.EnabledButtonCuentaCtaCte;

			KeyPreview = true;
			
			
		}
		

		private void InitEventHandlers()
		{
			mzCmb.ValueChanged+= new System.EventHandler( this.Componentes_Changes );
			ubAgregar.Click +=new EventHandler(ubAgregar_Click);
			ubEliminar.Click +=new EventHandler(ubEliminar_Click);
			ubBuscar.Click +=new EventHandler(ubBuscar_Click);
			toolBarStandar.ButtonClick += new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			gridEXValores.DoubleClick +=new EventHandler(gridEXValores_DoubleClick);
			gridEXValores.Error +=new ErrorEventHandler(gridEXValores_Error);									
			gridEXValores.RecordsDeleted+=new EventHandler(gridEXValores_RecordsDeleted);
			gridCompAImputar.DoubleClick +=new EventHandler(gridCompAImputar_DoubleClick);
			mzCEResponsableEmision.Leave +=new EventHandler(mzCEResponsableEmision_Leave);
			_uiController.ComprobanteHasChanged +=new EventHandler(Refresh);
			_uiController.SaldoChanged +=new EventHandler(_uiController_SaldoChanged);
			gridCompAImputar.Error +=new ErrorEventHandler(gridCompAImputar_Error);
			utbCalcularRetenciones.Click +=new EventHandler(utbCalcularRetenciones_Click);
			gridEXValores.DeletingRecords +=new CancelEventHandler(gridEXValores_DeletingRecords);
			this.menuItemEditar.Click += new System.EventHandler(this.menuItem1_Click);
			this.menuItemEliminar.Click += new System.EventHandler(this.menuItemEliminar_Click);
			
			KeyDownManager KeyDown = new KeyDownManager(this);
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			
			if(gridEXValores.SelectedItems.Count > 0)
			{
				Valor valor = (Valor)this.gridEXValores.SelectedItems[0].GetRow().DataRow;
				if(valor != null)
					if(_uiController.IsEditable(valor, string.Empty))
					{
						FrmValores form = new FrmValores(_uiController.GetValoresController(valor), _uiController);
						form.AddObjectListener(_uiController);
						form.ShowFormIObservable();
					}
						
				

			}
				
		}

		private void menuItemEliminar_Click(object sender, System.EventArgs e)
		{
			EliminarValor();
		}

		private void InitializeData()
		{
		
			mzCEResponsableEmision.FillFromDataSource(businessrules.data.UsuariosPersonas.GetList(), "IdPersona","Nombre",100,"ID","Nombre","Nombre");
			mzCEInstanciasCaja.FillFromDataSource(_uiController.InstanciasCajasAbiertas, "IdInstanciaCaja","Descripcion",100,"ID","Descripcion","Descripcion");
			mzCmbTipoComprobante.FillFromDataSource(_uiController.TiposDeComprobantesDePago, "IdTipoDeComprobante","Descripcion",100,"ID","Descripcion","Descripcion");
			mzCmb.DataValue = _uiController.CodigoProveedor;
		}

		private void InitDataBindings()
		{
			
			mzCEInstanciasCaja.DataBindings.Add("Value", _uiController,"IdInstanciaCaja");
			mzCmbTipoComprobante.DataBindings.Add("Value", _uiController, "TipoDeComprobante");
			uneTotalValores.DataBindings.Add("Value", _uiController , "Total");
			uneSaldo.DataBindings.Add("Value", _uiController , "Saldo");
			gridEXValores.SetDataBinding(_uiController.Valores, null);
			gridCompAImputar.SetDataBinding(_uiController.CuentaCorriente, null);
			uneTotalImputado.DataBindings.Add("Value", _uiController, "TotalImputado");
			ultraMENumero.DataBindings.Add( "InputMask",_uiController , "Mascara" );
			cldFechaComprobante.DataBindings.Add("Enabled", _uiController, "AllowEditFecha");
			cldFechaComprobante.DataBindings.Add("Value", _uiController, "FechaComprobante");
			BindingController.Bind(ultraMENumero,"Text", _uiController, "Numero" );
			BindingController.Bind(mzCEResponsableEmision,"Value", _uiController,"IdResponsable");
			
            /*
			ConfigGridForValores();
			ConfigGridForCompAImputar();
			*/

            //Sabrina: Tarea 1120. 20110817
            chckImputaAutomaticamente.DataBindings.Add("Checked", _uiController, "ImputaAutomaticamente");
            //Fin Sabrina: Tarea 1120. 20110817		
			
		}

		private void DumpControls()
		{
			_uiController.Observaciones = uTEObservaciones.Text;
		}


	#endregion

		#region Miembros de ISearchObjectListener

		public void processEventChange(object sender, EventArgs e)
		{
			
		}

		#endregion

		#region Manejadores de Eventos

		private void Refresh(object sender, EventArgs e)
		{
			gridEXValores.DataBindings.Clear();
			gridEXValores.SetDataBinding(_uiController.Valores, null);
			//ConfigGridForValores();
			gridCompAImputar.DataBindings.Clear();
			gridCompAImputar.SetDataBinding(_uiController.CuentaCorriente, null);

		}

		private void Componentes_Changes(object sender, System.EventArgs e)
		{
			if (Convert.ToString(mzCmb.DataValue) != "")
			{
				string codigo = Convert.ToString(mzCmb.DataValue);
				if(!codigo.Equals(_uiController.CodigoProveedor))
				{		
					
					_uiController.CodigoProveedor = codigo;
					uneTotalImputado.DataBindings.Clear();
					uneTotalImputado.DataBindings.Add("Text", _uiController, "TotalImputado");
					gridCompAImputar.SetDataBinding(_uiController.CuentaCorriente, null);		
						
				}
			}
			else
			{
				_uiController.CodigoProveedor = string.Empty;
				gridCompAImputar.SetDataBinding(null, null);
				
			}
		}

		private void ubAgregar_Click(object sender, EventArgs e)
		{
			FrmValores form = new FrmValores(_uiController.GetValoresController(), _uiController, _uiController.IdProveedor);
			form.AddObjectListener(_uiController);
			form.ShowFormIObservable("Valor en Pago de Cuenta Corriente de "+Convert.ToString(_uiController.NombreProveedor));
		}

		private void ubEliminar_Click(object sender, EventArgs e)
		{
			EliminarValor();
		}

		private void EliminarValor()
		{
			if(gridEXValores.SelectedItems.Count == 1 && gridEXValores.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
			{
				gridEXValores.Delete();				
			}
		}

		private void ubBuscar_Click(object sender, EventArgs e)
		{
			if(_uiController.IdInstanciaCaja != null && _uiController.IdInstanciaCaja != string.Empty)
			{
				FrmConsultaValores frmConsultaValores = new FrmConsultaValores("ProcesoConsultarValores", "ConsultarValores", _uiController.IdInstanciaCaja);
				frmConsultaValores.AddObjectListener(this._uiController);
				frmConsultaValores.Build_UI();
				frmConsultaValores.MdiParent = this.MdiParent;
				frmConsultaValores.Show();
			}
			else
				MessageBox.Show("No ha Seleccionado una Caja", "Debe seleccionar la Caja en la que se van a buscar los valores", 
					System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop);
		}

		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					_uiController.Previous();
					break;
				case 2:
					Util.MoveFocus(this.ultraExplorerBarContainerControl5);		
					DumpControls();
					_uiController.Execute();
					break;
				case 4:
					if ((MessageBox.Show(this,"Está a punto de cerrar el fomulario. Realmente desea realizar esta operación?","Atención!",System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Stop )== System.Windows.Forms.DialogResult.OK))
						Close();
					break;
			}
		}

		private void gridEXValores_DoubleClick(object sender, EventArgs e)
		{
			//gridEXValores.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
		}

		private void gridCompAImputar_DoubleClick(object sender, EventArgs e)
		{
			if (gridCompAImputar.SelectedItems.Count > 0 && gridCompAImputar.GetRow().RowType.Equals(Janus.Windows.GridEX.RowType.Record) )
			{
				if(_uiController.AllowEditImputacion)
				{
					_uiController.UpdatePago(gridCompAImputar.GetRow().DataRow);
					gridCompAImputar.Refetch();
				}
			}
		}

		private void gridEXValores_Error(object sender, ErrorEventArgs e)
		{
			e.DisplayErrorMessage = false;
		}

		private void mzCEResponsableEmision_Leave(object sender, EventArgs e)
		{
			if (_uiController.AskForPasswordResponsableEmision) 
			{
				ShowPassword();				
			}	
		}

		private void ShowPassword() 
		{			
			string IdPersona = Convert.ToString(mzCEResponsableEmision.Value);			
			if (IdPersona != _uiController.UltimoResponsableClaveCorrecta)
			{
				string password = InputBox.ShowInputBoxPassword("Ingrese la contraseña:","Cambio de responsable de emisión");								
				bool ClaveCorrecta = false;
				if (IdPersona != null && IdPersona != String.Empty)
				{
					ClaveCorrecta = businessrules.Security.LogInXPersona(IdPersona, password);					
					if (!ClaveCorrecta /*&& password != ""*/)
						MessageBox.Show("¡Clave incorrecta!", "Cambio de responsable de emisión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					else
						_uiController.UltimoResponsableClaveCorrecta = IdPersona;
				}
				
				if (!ClaveCorrecta)
					_uiController.ClearResponsableDeEmision();
			}
		}

		private void gridEXValores_RecordsDeleted(object sender, EventArgs e)
		{
			gridEXValores.Refresh();
			_uiController.Recalcular();
		}

		#endregion

		private void gridCompAImputar_Error(object sender, ErrorEventArgs e)
		{
			e.DisplayErrorMessage = false;
		}

		private void utbCalcularRetenciones_Click(object sender, EventArgs e)
		{
			_uiController.CalcularRetenciones();
			gridEXValores.SetDataBinding(null,null);
			gridEXValores.SetDataBinding(_uiController.Valores, null);
		}

		private void gridEXValores_DeletingRecords(object sender, CancelEventArgs e)
		{
			if(gridEXValores.SelectedItems.Count == 1 && gridEXValores.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
			{
				if(!(_uiController.IsRemovable(gridEXValores.SelectedItems[0].GetRow().DataRow)))
					e.Cancel = true;
			}
		}

		private void _uiController_SaldoChanged(object sender, EventArgs e)
		{
			if(_uiController.Saldo < 0)
				uneSaldo.Appearance.ForeColor = Color.Red;
		}

		private void ultraMENumero_Leave(object sender, System.EventArgs e)
		{
			this.ultraMENumero.Text = _uiController.FillNumberWithZeros(ultraMENumero.Text);
		}
	}
}

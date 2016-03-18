using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using mz.erp.ui.controls;
using mz.erp.ui.controllers;
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.businessrules.comprobantes;
using mz.erp.ui.forms.classes;
using Infragistics.Win.UltraWinExplorerBar;
using System.Runtime.InteropServices;


namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmComprobantesDeVenta.
	/// </summary>
	public class FrmComprobantesDeVenta : System.Windows.Forms.Form, ISearchObjectListener, ITaskForm 
	{
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.ToolBarButton tbGuardar;
		private System.Windows.Forms.ToolBarButton tbStep3;
		private System.Windows.Forms.ToolBarButton tbbImprimir;
		private System.Windows.Forms.ToolBarButton toolBarButton9;
		private System.Windows.Forms.ToolBarButton tbCerrar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.Panel panel1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtTipoDeComprobante;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit txtNumero;
		private mz.erp.ui.controls.mzComboEditor mzCEResponsableEmision;
		private Infragistics.Win.Misc.UltraLabel ultraLabel2;
		private Infragistics.Win.Misc.UltraLabel ultraLabel3;
		private Infragistics.Win.Misc.UltraLabel ultraLabel5;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo cldFechaComprobante;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Janus.Windows.GridEX.GridEX gridProductos;				
		private Infragistics.Win.Misc.UltraButton bDetallesProducto;
		private Infragistics.Win.Misc.UltraButton bAgregarProducto;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotal1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor ultraNumericEditor2;
		private System.Windows.Forms.Label label3;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor ultraNumericEditor1;
		private System.Windows.Forms.Label label2;
		private Janus.Windows.GridEX.GridEX gridResumenImpuestos;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneRecargosFinancieros;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalBruto;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotal;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalImpuestos;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalNeto;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private Janus.Windows.GridEX.GridEX gridDetalleCondicionDeVenta;
		private System.Windows.Forms.Label label9;
		private Janus.Windows.GridEX.GridEX gridVariablesUsuario;
		private System.Windows.Forms.Label label8;

		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalDescuentos;

		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private System.Windows.Forms.Label labelTarea;
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl6;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor uTEObservaciones;		
		private mz.erp.ui.controls.mzComboEditor mzCECondicionesDeVenta;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private Infragistics.Win.Misc.UltraLabel ultraLabel6;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private System.Windows.Forms.ImageList imageList1;
		private mz.erp.ui.controls.mzCuentasControl mzCmbCuenta;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private mz.erp.ui.controls.mzProductosControl mzProductosControl;
        private Label lSaldo;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneSaldo;
        /* Silvina 20111212 - Tarea 0000232 */
        private Infragistics.Win.Misc.UltraLabel lVencimientoReserva;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo cldVencimientoReserva;
        /* Fin Silvina 20111212 - Tarea 0000232 */

		private System.ComponentModel.IContainer components;

		[ DllImport( "user32.dll", CharSet=CharSet.Auto,
			  CallingConvention=CallingConvention.Winapi ) ] 
		internal static extern IntPtr GetFocus(); 



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
				BindingController.Clear(mzCEResponsableEmision,"Value", _uiController,"ResponsableDeEmision");
				//BindingController.Clear(txtNumero,"Text", _uiController, "NumeroComprobante" );
				BindingController.Clear(uTEObservaciones,"Text", _uiController, "Observaciones" );				
				BindingController.Clear(cldFechaComprobante, "Value", _uiController, "Fecha");
				BindingController.Clear(mzCECondicionesDeVenta,"Value", _uiController, "CondicionDeVenta");
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
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton2 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup6 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.labelTarea = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.lVencimientoReserva = new Infragistics.Win.Misc.UltraLabel();
            this.cldVencimientoReserva = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
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
            this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
            this.mzProductosControl = new mz.erp.ui.controls.mzProductosControl();
            this.gridProductos = new Janus.Windows.GridEX.GridEX();
            this.bDetallesProducto = new Infragistics.Win.Misc.UltraButton();
            this.bAgregarProducto = new Infragistics.Win.Misc.UltraButton();
            this.uneTotal1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.lSaldo = new System.Windows.Forms.Label();
            this.uneSaldo = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneTotalDescuentos = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraNumericEditor2 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label3 = new System.Windows.Forms.Label();
            this.ultraNumericEditor1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label2 = new System.Windows.Forms.Label();
            this.gridResumenImpuestos = new Janus.Windows.GridEX.GridEX();
            this.uneRecargosFinancieros = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneTotalBruto = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneTotal = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneTotalImpuestos = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneTotalNeto = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl6 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.uTEObservaciones = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.gridDetalleCondicionDeVenta = new Janus.Windows.GridEX.GridEX();
            this.label9 = new System.Windows.Forms.Label();
            this.gridVariablesUsuario = new Janus.Windows.GridEX.GridEX();
            this.label8 = new System.Windows.Forms.Label();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
            this.tbGuardar = new System.Windows.Forms.ToolBarButton();
            this.tbStep3 = new System.Windows.Forms.ToolBarButton();
            this.tbbImprimir = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
            this.tbCerrar = new System.Windows.Forms.ToolBarButton();
            this.toolBarStandar = new System.Windows.Forms.ToolBar();
            this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
            this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
            this.imglStandar = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ultraExplorerBarContainerControl4.SuspendLayout();
            this.ultraExplorerBarContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cldVencimientoReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCECondicionesDeVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cldFechaComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoDeComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEResponsableEmision)).BeginInit();
            this.ultraExplorerBarContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotal1)).BeginInit();
            this.ultraExplorerBarContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneSaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalDescuentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResumenImpuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneRecargosFinancieros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalBruto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalImpuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalNeto)).BeginInit();
            this.ultraExplorerBarContainerControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uTEObservaciones)).BeginInit();
            this.ultraExplorerBarContainerControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleCondicionDeVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVariablesUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
            this.ultraExplorerBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraExplorerBarContainerControl4
            // 
            this.ultraExplorerBarContainerControl4.Controls.Add(this.labelTarea);
            this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, 24);
            this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
            this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(854, 27);
            this.ultraExplorerBarContainerControl4.TabIndex = 5;
            // 
            // labelTarea
            // 
            this.labelTarea.BackColor = System.Drawing.Color.Transparent;
            this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarea.Location = new System.Drawing.Point(0, 0);
            this.labelTarea.Name = "labelTarea";
            this.labelTarea.Size = new System.Drawing.Size(854, 23);
            this.labelTarea.TabIndex = 0;
            this.labelTarea.Text = "Tarea";
            this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ultraExplorerBarContainerControl1
            // 
            this.ultraExplorerBarContainerControl1.Controls.Add(this.lVencimientoReserva);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.cldVencimientoReserva);
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
            this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 108);
            this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(854, 79);
            this.ultraExplorerBarContainerControl1.TabIndex = 0;
            // 
            // lVencimientoReserva
            // 
            appearance4.TextHAlignAsString = "Right";
            this.lVencimientoReserva.Appearance = appearance4;
            this.lVencimientoReserva.BackColorInternal = System.Drawing.Color.Transparent;
            this.lVencimientoReserva.Location = new System.Drawing.Point(358, 55);
            this.lVencimientoReserva.Name = "lVencimientoReserva";
            this.lVencimientoReserva.Size = new System.Drawing.Size(95, 14);
            this.lVencimientoReserva.TabIndex = 38;
            this.lVencimientoReserva.Text = "F. Venc. Reserva";
            this.lVencimientoReserva.Visible = false;
            // 
            // cldVencimientoReserva
            // 
            this.cldVencimientoReserva.BackColor = System.Drawing.SystemColors.Window;
            this.cldVencimientoReserva.DateButtons.Add(dateButton1);
            this.cldVencimientoReserva.Location = new System.Drawing.Point(460, 50);
            this.cldVencimientoReserva.Name = "cldVencimientoReserva";
            this.cldVencimientoReserva.NonAutoSizeHeight = 23;
            this.cldVencimientoReserva.Size = new System.Drawing.Size(100, 21);
            this.cldVencimientoReserva.TabIndex = 37;
            this.cldVencimientoReserva.Value = new System.DateTime(2005, 8, 15, 0, 0, 0, 0);
            this.cldVencimientoReserva.Visible = false;
            // 
            // mzCmbCuenta
            // 
            this.mzCmbCuenta.AllowEditClientePaso = false;
            this.mzCmbCuenta.BackColor = System.Drawing.SystemColors.Control;
            this.mzCmbCuenta.DataValue = "";
            this.mzCmbCuenta.EnableCtaCte = false;
            this.mzCmbCuenta.FastSearch = false;
            this.mzCmbCuenta.Location = new System.Drawing.Point(120, 24);
            this.mzCmbCuenta.Name = "mzCmbCuenta";
            this.mzCmbCuenta.ReseteaCodCta = false;
            this.mzCmbCuenta.SearchObjectListener = null;
            this.mzCmbCuenta.Size = new System.Drawing.Size(440, 24);
            this.mzCmbCuenta.TabIndex = 1;
            this.mzCmbCuenta.Load += new System.EventHandler(this.mzCmbCuenta_Load);
            // 
            // ultraLabel4
            // 
            appearance1.TextHAlignAsString = "Right";
            this.ultraLabel4.Appearance = appearance1;
            this.ultraLabel4.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel4.Location = new System.Drawing.Point(10, 54);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(104, 16);
            this.ultraLabel4.TabIndex = 36;
            this.ultraLabel4.Text = "Condición de venta";
            // 
            // ultraLabel6
            // 
            appearance2.TextHAlignAsString = "Right";
            this.ultraLabel6.Appearance = appearance2;
            this.ultraLabel6.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel6.Location = new System.Drawing.Point(-4, 6);
            this.ultraLabel6.Name = "ultraLabel6";
            this.ultraLabel6.Size = new System.Drawing.Size(120, 20);
            this.ultraLabel6.TabIndex = 35;
            this.ultraLabel6.Text = "Responsable emisión";
            // 
            // ultraLabel1
            // 
            appearance3.TextHAlignAsString = "Right";
            this.ultraLabel1.Appearance = appearance3;
            this.ultraLabel1.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel1.Location = new System.Drawing.Point(50, 30);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(62, 16);
            this.ultraLabel1.TabIndex = 34;
            this.ultraLabel1.Text = "Cuenta";
            // 
            // mzCECondicionesDeVenta
            // 
            this.mzCECondicionesDeVenta.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
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
            appearance8.TextHAlignAsString = "Right";
            this.ultraLabel3.Appearance = appearance8;
            this.ultraLabel3.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel3.Location = new System.Drawing.Point(605, 30);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(62, 11);
            this.ultraLabel3.TabIndex = 28;
            this.ultraLabel3.Text = "Fecha";
            // 
            // cldFechaComprobante
            // 
            this.cldFechaComprobante.BackColor = System.Drawing.SystemColors.Window;
            this.cldFechaComprobante.DateButtons.Add(dateButton2);
            this.cldFechaComprobante.Location = new System.Drawing.Point(672, 26);
            this.cldFechaComprobante.Name = "cldFechaComprobante";
            this.cldFechaComprobante.NonAutoSizeHeight = 23;
            this.cldFechaComprobante.Size = new System.Drawing.Size(100, 21);
            this.cldFechaComprobante.TabIndex = 4;
            this.cldFechaComprobante.Value = new System.DateTime(2005, 8, 15, 0, 0, 0, 0);
            this.cldFechaComprobante.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.cldFechaComprobante_BeforeDropDown);
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
            this.txtNumero.InputMask = "\\A-####-########";
            this.txtNumero.Location = new System.Drawing.Point(672, 50);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 5;
            this.txtNumero.Text = "A--";
            this.txtNumero.Leave += new System.EventHandler(this.txtNumero_Leave);
            // 
            // mzCEResponsableEmision
            // 
            this.mzCEResponsableEmision.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
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
            appearance5.TextHAlignAsString = "Right";
            this.ultraLabel2.Appearance = appearance5;
            this.ultraLabel2.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel2.Location = new System.Drawing.Point(552, 6);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(116, 16);
            this.ultraLabel2.TabIndex = 32;
            this.ultraLabel2.Text = "Tipo de comprobante";
            // 
            // ultraLabel5
            // 
            appearance6.TextHAlignAsString = "Right";
            this.ultraLabel5.Appearance = appearance6;
            this.ultraLabel5.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel5.Location = new System.Drawing.Point(605, 54);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.Size = new System.Drawing.Size(62, 11);
            this.ultraLabel5.TabIndex = 27;
            this.ultraLabel5.Text = "Número";
            // 
            // ultraExplorerBarContainerControl2
            // 
            this.ultraExplorerBarContainerControl2.Controls.Add(this.gridManagerView1);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.mzProductosControl);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.gridProductos);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.bDetallesProducto);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.bAgregarProducto);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.uneTotal1);
            this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 244);
            this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
            this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(854, 280);
            this.ultraExplorerBarContainerControl2.TabIndex = 0;
            // 
            // gridManagerView1
            // 
            this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
            this.gridManagerView1.Location = new System.Drawing.Point(208, 0);
            this.gridManagerView1.Name = "gridManagerView1";
            this.gridManagerView1.Size = new System.Drawing.Size(392, 24);
            this.gridManagerView1.TabIndex = 7;
            // 
            // mzProductosControl
            // 
            this.mzProductosControl.BackColor = System.Drawing.Color.Transparent;
            this.mzProductosControl.EnabledCantidad = false;
            this.mzProductosControl.EnabledListaDePrecio = true;
            this.mzProductosControl.Location = new System.Drawing.Point(4, 192);
            this.mzProductosControl.Name = "mzProductosControl";
            this.mzProductosControl.PermiteProductosCombo = false;
            this.mzProductosControl.Size = new System.Drawing.Size(776, 80);
            this.mzProductosControl.TabIndex = 8;
            this.mzProductosControl.VisibleCantidad = true;
            this.mzProductosControl.VisibleComboListaDePrecios = true;
            this.mzProductosControl.VisibleComboTipoDePrecioDeCosto = false;
            this.mzProductosControl.VisiblePrecios = true;
            // 
            // gridProductos
            // 
            this.gridProductos.AllowCardSizing = false;
            this.gridProductos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridProductos.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridProductos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gridProductos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridProductos.Location = new System.Drawing.Point(13, 29);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridProductos.Size = new System.Drawing.Size(835, 160);
            this.gridProductos.TabIndex = 1;
            this.gridProductos.TabStop = false;
            // 
            // bDetallesProducto
            // 
            this.bDetallesProducto.Enabled = false;
            this.bDetallesProducto.Location = new System.Drawing.Point(110, 0);
            this.bDetallesProducto.Name = "bDetallesProducto";
            this.bDetallesProducto.Size = new System.Drawing.Size(88, 23);
            this.bDetallesProducto.TabIndex = 2;
            this.bDetallesProducto.TabStop = false;
            this.bDetallesProducto.Text = "&Detalles";
            // 
            // bAgregarProducto
            // 
            this.bAgregarProducto.AcceptsFocus = false;
            this.bAgregarProducto.Location = new System.Drawing.Point(14, 0);
            this.bAgregarProducto.Name = "bAgregarProducto";
            this.bAgregarProducto.Size = new System.Drawing.Size(88, 23);
            this.bAgregarProducto.TabIndex = 1;
            this.bAgregarProducto.TabStop = false;
            this.bAgregarProducto.Text = "&Agregar";
            // 
            // uneTotal1
            // 
            appearance7.BackColor = System.Drawing.Color.Transparent;
            this.uneTotal1.Appearance = appearance7;
            this.uneTotal1.BackColor = System.Drawing.Color.Transparent;
            this.uneTotal1.BorderStyle = Infragistics.Win.UIElementBorderStyle.None;
            this.uneTotal1.Enabled = false;
            this.uneTotal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uneTotal1.Location = new System.Drawing.Point(780, 200);
            this.uneTotal1.Name = "uneTotal1";
            this.uneTotal1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneTotal1.PromptChar = ' ';
            this.uneTotal1.ReadOnly = true;
            this.uneTotal1.Size = new System.Drawing.Size(120, 27);
            this.uneTotal1.TabIndex = 6;
            this.uneTotal1.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            this.uneTotal1.TabStop = false;
            // 
            // ultraExplorerBarContainerControl3
            // 
            this.ultraExplorerBarContainerControl3.Controls.Add(this.lSaldo);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.uneSaldo);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.uneTotalDescuentos);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.ultraNumericEditor2);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.label3);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.ultraNumericEditor1);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.label2);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.gridResumenImpuestos);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.uneRecargosFinancieros);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.uneTotalBruto);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.uneTotal);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.uneTotalImpuestos);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.uneTotalNeto);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.label12);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.label13);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.label14);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.label15);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.label16);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.label17);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.label18);
            this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
            this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(854, 148);
            this.ultraExplorerBarContainerControl3.TabIndex = 2;
            this.ultraExplorerBarContainerControl3.Visible = false;
            // 
            // lSaldo
            // 
            this.lSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lSaldo.Location = new System.Drawing.Point(539, 95);
            this.lSaldo.Name = "lSaldo";
            this.lSaldo.Size = new System.Drawing.Size(75, 16);
            this.lSaldo.TabIndex = 67;
            this.lSaldo.Text = "Saldo";
            // 
            // uneSaldo
            // 
            this.uneSaldo.Location = new System.Drawing.Point(627, 92);
            this.uneSaldo.MaskInput = "-nnnnnnnnnnnn.nn";
            this.uneSaldo.Name = "uneSaldo";
            this.uneSaldo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneSaldo.PromptChar = ' ';
            this.uneSaldo.ReadOnly = true;
            this.uneSaldo.Size = new System.Drawing.Size(100, 21);
            this.uneSaldo.TabIndex = 66;
            // 
            // uneTotalDescuentos
            // 
            this.uneTotalDescuentos.Location = new System.Drawing.Point(411, 116);
            this.uneTotalDescuentos.Name = "uneTotalDescuentos";
            this.uneTotalDescuentos.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneTotalDescuentos.PromptChar = ' ';
            this.uneTotalDescuentos.ReadOnly = true;
            this.uneTotalDescuentos.Size = new System.Drawing.Size(100, 21);
            this.uneTotalDescuentos.TabIndex = 5;
            // 
            // ultraNumericEditor2
            // 
            this.ultraNumericEditor2.Location = new System.Drawing.Point(411, 91);
            this.ultraNumericEditor2.Name = "ultraNumericEditor2";
            this.ultraNumericEditor2.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.ultraNumericEditor2.PromptChar = ' ';
            this.ultraNumericEditor2.ReadOnly = true;
            this.ultraNumericEditor2.Size = new System.Drawing.Size(100, 21);
            this.ultraNumericEditor2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(299, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "Bon/Rec. Cuenta";
            // 
            // ultraNumericEditor1
            // 
            this.ultraNumericEditor1.Location = new System.Drawing.Point(411, 67);
            this.ultraNumericEditor1.Name = "ultraNumericEditor1";
            this.ultraNumericEditor1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.ultraNumericEditor1.PromptChar = ' ';
            this.ultraNumericEditor1.ReadOnly = true;
            this.ultraNumericEditor1.Size = new System.Drawing.Size(100, 21);
            this.ultraNumericEditor1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(299, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "Bon/Rec. Producto";
            // 
            // gridResumenImpuestos
            // 
            this.gridResumenImpuestos.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridResumenImpuestos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridResumenImpuestos.Location = new System.Drawing.Point(8, 19);
            this.gridResumenImpuestos.Name = "gridResumenImpuestos";
            this.gridResumenImpuestos.Size = new System.Drawing.Size(275, 120);
            this.gridResumenImpuestos.TabIndex = 0;
            // 
            // uneRecargosFinancieros
            // 
            this.uneRecargosFinancieros.Location = new System.Drawing.Point(411, 43);
            this.uneRecargosFinancieros.Name = "uneRecargosFinancieros";
            this.uneRecargosFinancieros.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneRecargosFinancieros.PromptChar = ' ';
            this.uneRecargosFinancieros.ReadOnly = true;
            this.uneRecargosFinancieros.Size = new System.Drawing.Size(100, 21);
            this.uneRecargosFinancieros.TabIndex = 2;
            // 
            // uneTotalBruto
            // 
            this.uneTotalBruto.Location = new System.Drawing.Point(411, 19);
            this.uneTotalBruto.Name = "uneTotalBruto";
            this.uneTotalBruto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneTotalBruto.PromptChar = ' ';
            this.uneTotalBruto.ReadOnly = true;
            this.uneTotalBruto.Size = new System.Drawing.Size(100, 21);
            this.uneTotalBruto.TabIndex = 1;
            // 
            // uneTotal
            // 
            this.uneTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uneTotal.Location = new System.Drawing.Point(627, 67);
            this.uneTotal.Name = "uneTotal";
            this.uneTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneTotal.PromptChar = ' ';
            this.uneTotal.ReadOnly = true;
            this.uneTotal.Size = new System.Drawing.Size(100, 24);
            this.uneTotal.TabIndex = 8;
            // 
            // uneTotalImpuestos
            // 
            this.uneTotalImpuestos.Location = new System.Drawing.Point(627, 43);
            this.uneTotalImpuestos.Name = "uneTotalImpuestos";
            this.uneTotalImpuestos.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneTotalImpuestos.PromptChar = ' ';
            this.uneTotalImpuestos.ReadOnly = true;
            this.uneTotalImpuestos.Size = new System.Drawing.Size(100, 21);
            this.uneTotalImpuestos.TabIndex = 7;
            // 
            // uneTotalNeto
            // 
            this.uneTotalNeto.Location = new System.Drawing.Point(627, 19);
            this.uneTotalNeto.Name = "uneTotalNeto";
            this.uneTotalNeto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneTotalNeto.PromptChar = ' ';
            this.uneTotalNeto.ReadOnly = true;
            this.uneTotalNeto.Size = new System.Drawing.Size(100, 21);
            this.uneTotalNeto.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(299, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 16);
            this.label12.TabIndex = 55;
            this.label12.Text = "Bon/Rec Financieros";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(299, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 16);
            this.label13.TabIndex = 54;
            this.label13.Text = "Total Bon./Rec.";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(299, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 16);
            this.label14.TabIndex = 53;
            this.label14.Text = "Subtotal";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(539, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 16);
            this.label15.TabIndex = 52;
            this.label15.Text = "Total";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(539, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 16);
            this.label16.TabIndex = 51;
            this.label16.Text = "Impuestos";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(539, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 16);
            this.label17.TabIndex = 50;
            this.label17.Text = "Subtotal Neto";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(8, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 16);
            this.label18.TabIndex = 49;
            this.label18.Text = "Impuestos";
            // 
            // ultraExplorerBarContainerControl6
            // 
            this.ultraExplorerBarContainerControl6.Controls.Add(this.uTEObservaciones);
            this.ultraExplorerBarContainerControl6.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl6.Name = "ultraExplorerBarContainerControl6";
            this.ultraExplorerBarContainerControl6.Size = new System.Drawing.Size(854, 150);
            this.ultraExplorerBarContainerControl6.TabIndex = 6;
            this.ultraExplorerBarContainerControl6.Visible = false;
            // 
            // uTEObservaciones
            // 
            this.uTEObservaciones.AcceptsReturn = true;
            this.uTEObservaciones.AcceptsTab = true;
            this.uTEObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uTEObservaciones.Location = new System.Drawing.Point(8, 8);
            this.uTEObservaciones.Multiline = true;
            this.uTEObservaciones.Name = "uTEObservaciones";
            this.uTEObservaciones.Size = new System.Drawing.Size(840, 128);
            this.uTEObservaciones.TabIndex = 0;
            // 
            // ultraExplorerBarContainerControl5
            // 
            this.ultraExplorerBarContainerControl5.Controls.Add(this.gridDetalleCondicionDeVenta);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.label9);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.gridVariablesUsuario);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.label8);
            this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
            this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(854, 150);
            this.ultraExplorerBarContainerControl5.TabIndex = 4;
            this.ultraExplorerBarContainerControl5.Visible = false;
            // 
            // gridDetalleCondicionDeVenta
            // 
            this.gridDetalleCondicionDeVenta.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridDetalleCondicionDeVenta.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridDetalleCondicionDeVenta.Location = new System.Drawing.Point(16, 16);
            this.gridDetalleCondicionDeVenta.Name = "gridDetalleCondicionDeVenta";
            this.gridDetalleCondicionDeVenta.Size = new System.Drawing.Size(256, 120);
            this.gridDetalleCondicionDeVenta.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(280, 0);
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
            this.gridVariablesUsuario.Location = new System.Drawing.Point(280, 16);
            this.gridVariablesUsuario.Name = "gridVariablesUsuario";
            this.gridVariablesUsuario.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridVariablesUsuario.Size = new System.Drawing.Size(568, 120);
            this.gridVariablesUsuario.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(16, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Vencimientos";
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.ImageIndex = 0;
            this.toolBarButton1.Name = "toolBarButton1";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.ImageIndex = 1;
            this.toolBarButton2.Name = "toolBarButton2";
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.ImageIndex = 2;
            this.toolBarButton3.Name = "toolBarButton3";
            // 
            // toolBarButton4
            // 
            this.toolBarButton4.ImageIndex = 3;
            this.toolBarButton4.Name = "toolBarButton4";
            // 
            // toolBarButton5
            // 
            this.toolBarButton5.Name = "toolBarButton5";
            this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // toolBarButton6
            // 
            this.toolBarButton6.ImageIndex = 5;
            this.toolBarButton6.Name = "toolBarButton6";
            // 
            // toolBarButton7
            // 
            this.toolBarButton7.Name = "toolBarButton7";
            this.toolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbGuardar
            // 
            this.tbGuardar.ImageIndex = 4;
            this.tbGuardar.Name = "tbGuardar";
            this.tbGuardar.Text = "&Guardar";
            // 
            // tbStep3
            // 
            this.tbStep3.Name = "tbStep3";
            this.tbStep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.tbStep3.Visible = false;
            // 
            // tbbImprimir
            // 
            this.tbbImprimir.ImageIndex = 8;
            this.tbbImprimir.Name = "tbbImprimir";
            this.tbbImprimir.Text = "Imprimir";
            this.tbbImprimir.Visible = false;
            // 
            // toolBarButton9
            // 
            this.toolBarButton9.Name = "toolBarButton9";
            this.toolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbCerrar
            // 
            this.tbCerrar.ImageIndex = 7;
            this.tbCerrar.Name = "tbCerrar";
            this.tbCerrar.Text = "Cerrar";
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
            this.toolBarStandar.TabIndex = 18;
            this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
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
            this.tbbCancelar.Text = "Cancelar";
            // 
            // imglStandar
            // 
            this.imglStandar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
            this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ultraExplorerBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 434);
            this.panel1.TabIndex = 19;
            // 
            // ultraExplorerBar1
            // 
            this.ultraExplorerBar1.AnimationEnabled = false;
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl6);
            this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl4;
            ultraExplorerBarGroup1.Key = "Tarea";
            ultraExplorerBarGroup1.Settings.ContainerHeight = 27;
            ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup1.Text = "Tarea";
            ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
            ultraExplorerBarGroup2.Key = "DatosCabecera";
            ultraExplorerBarGroup2.Settings.ContainerHeight = 79;
            ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup2.Text = "Datos de Cabecera";
            ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl2;
            ultraExplorerBarGroup3.Key = "Productos";
            ultraExplorerBarGroup3.Settings.ContainerHeight = 280;
            ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup3.Text = "Detalle de Productos";
            ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl3;
            ultraExplorerBarGroup4.Key = "Totales";
            ultraExplorerBarGroup4.Settings.ContainerHeight = 148;
            ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup4.Text = "Totales";
            ultraExplorerBarGroup5.Container = this.ultraExplorerBarContainerControl6;
            ultraExplorerBarGroup5.Key = "Observaciones";
            ultraExplorerBarGroup5.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup5.Text = "Observaciones";
            ultraExplorerBarGroup6.Container = this.ultraExplorerBarContainerControl5;
            ultraExplorerBarGroup6.Key = "InformacionAdicional";
            ultraExplorerBarGroup6.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup6.Text = "Informacion Adicional";
            this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2,
            ultraExplorerBarGroup3,
            ultraExplorerBarGroup4,
            ultraExplorerBarGroup5,
            ultraExplorerBarGroup6});
            this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 0);
            this.ultraExplorerBar1.Name = "ultraExplorerBar1";
            this.ultraExplorerBar1.Size = new System.Drawing.Size(920, 434);
            this.ultraExplorerBar1.TabIndex = 0;
            this.ultraExplorerBar1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            // 
            // FrmComprobantesDeVenta
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(920, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolBarStandar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmComprobantesDeVenta";
            this.Text = "FrmComprobantesDeVenta";
            this.Load += new System.EventHandler(this.FrmComprobantesDeVenta_Load);
            this.ultraExplorerBarContainerControl4.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cldVencimientoReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCECondicionesDeVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cldFechaComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoDeComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEResponsableEmision)).EndInit();
            this.ultraExplorerBarContainerControl2.ResumeLayout(false);
            this.ultraExplorerBarContainerControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotal1)).EndInit();
            this.ultraExplorerBarContainerControl3.ResumeLayout(false);
            this.ultraExplorerBarContainerControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneSaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalDescuentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResumenImpuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneRecargosFinancieros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalBruto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalImpuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalNeto)).EndInit();
            this.ultraExplorerBarContainerControl6.ResumeLayout(false);
            this.ultraExplorerBarContainerControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uTEObservaciones)).EndInit();
            this.ultraExplorerBarContainerControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleCondicionDeVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVariablesUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
            this.ultraExplorerBar1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion


		#region Custom Members
		
		private mz.erp.ui.controllers.ComprobantesDeVentaController _uiController;
				
		public FrmComprobantesDeVenta()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
			_uiController = new mz.erp.ui.controllers.ComprobantesDeVentaController();
		}
		public FrmComprobantesDeVenta( mz.erp.ui.controllers.ComprobantesDeVentaController uiController )
		{
			InitializeComponent();
			_uiController = uiController;
		}

		private void Build_UI()
		{
			ConfigureInterface();
			InitEventHandlers();
			InitializeData();
			InitDataBindings();
		}

		private void ConfigureInterface()
		{				
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			//gridProductos.LayoutData = _uiController.LayoutItems;	

			gridProductos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell;
			
			
			/*Janus.Windows.GridEX.GridEXColumn column = gridProductos.RootTable.Columns["Visible"];
			Janus.Windows.GridEX.ConditionOperator condicion = Janus.Windows.GridEX.ConditionOperator.Equal;
			Janus.Windows.GridEX.GridEXFilterCondition filtro =new Janus.Windows.GridEX.GridEXFilterCondition(column, condicion, true);
			gridProductos.RootTable.FilterCondition = filtro;*/			
			mzCmbCuenta.EnableCtaCte = _uiController.EnabledButtonCuentaCtaCte;
			mzCmbCuenta.Init(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName());
			mzCmbCuenta.Enabled = _uiController.AllowEditCuenta;			
			mzCECondicionesDeVenta.Enabled = _uiController.AllowEditCondicionDeVenta;
			

			//gridProductos.Enabled = _uiController.AllowEditItems;
			mzProductosControl.Enabled = _uiController.AllowAddItems;
			mzProductosControl.SetProcess(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), "V");
            //Sabrina: Tarea 1080. 20110326
            mzProductosControl.PermiteProductosCombo = true;
            //Fin Sabrina: Tarea 1080. 20110326
			bAgregarProducto.Enabled = _uiController.EnabledButtonAgregarProductos;
			

			mzProductosControl.EnabledCantidad = true;
			txtNumero.Enabled = _uiController.AllowEditNumeration;
			txtTipoDeComprobante.Enabled = _uiController.AllowEditTipoDeComprobante;
			cldFechaComprobante.Enabled = _uiController.AllowEditFecha;
	
			mzCEResponsableEmision.Enabled = _uiController.AllowEditResponsableEmision;

			//gridProductos.GroupByBoxVisible = false;
			gridResumenImpuestos.GroupByBoxVisible = false;
			gridResumenImpuestos.LayoutData = _uiController.LayoutImpuestos;
			gridResumenImpuestos.Enabled = false;

			gridVariablesUsuario.GroupByBoxVisible = false;
			gridVariablesUsuario.LayoutData = _uiController.LayoutVariables;
			gridVariablesUsuario.Enabled = _uiController.AllowEditVariablesAuxiliares;

			gridDetalleCondicionDeVenta.GroupByBoxVisible = false;
			gridDetalleCondicionDeVenta.LayoutData = _uiController.LayoutCondicionesDeVenta;
			gridDetalleCondicionDeVenta.Enabled = false;

			uneRecargosFinancieros.ReadOnly = true;
			uneTotal.ReadOnly = true;
			uneTotal1.ReadOnly = true;
			uneTotalBruto.ReadOnly = true;
			uneTotalDescuentos.ReadOnly = true;
			uneTotalImpuestos.ReadOnly = true;
			uneTotalNeto.ReadOnly = true;
			txtTipoDeComprobante.ReadOnly = true;
			labelTarea.Text = _uiController.LeyendaFormulario;
			
			if (_uiController.Editable) ConfigureInterfaceEditable();
			else ConfigureInterfaceNoEditable();
			this.Text = _uiController.Caption;	

			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;			

			if (_uiController.AskForPasswordResponsableEmision) 
			{
				this.mzCEResponsableEmision.Nullable = true;				
				this.mzCEResponsableEmision.NullText = "";
			}			
			//CallGridManager();
			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), this.Name, gridProductos, this.Text);
			ConfigureGrid();
			//mzProductosControl.Select();
			
			/*
			mzCEResponsableEmision.TabIndex = mzCEResponsableEmision.TabIndex + 1;
			txtTipoDeComprobante.TabIndex = txtTipoDeComprobante.TabIndex + 1;
			mzCmbCuenta.TabIndex = mzCmbCuenta.TabIndex + 1;
			txtNumero.TabIndex = txtNumero.TabIndex + 1;
			cldFechaComprobante.TabIndex = cldFechaComprobante.TabIndex + 1;
			mzCECondicionesDeVenta.TabIndex = mzCECondicionesDeVenta.TabIndex + 1;
			*/

			this.KeyPreview = true;
			
			
			/*
			this.ForeColor = System.Drawing.Color.Red;
			string path = string.Format(mz.erp.systemframework.Util.ResourcePath() + "\\resources\\Icons\\last16.bmp");
			this.Icon = new Icon(path);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			*/

            /* Silvina 20100707 - Tarea 791 */
            mz.erp.ui.forms.classes.ContainerManager.CollapseContainers(ultraExplorerBar1, _uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName());
            /* Fin Silvina */

			/* Silvina 20110316 - Tarea 0000039 */
            lSaldo.Visible = _uiController.VisualizaSaldo;
            uneSaldo.Visible = _uiController.VisualizaSaldo;
            uneSaldo.ReadOnly = _uiController.VisualizaSaldo;
            /* Fin Silvina */

            /* Silvina 20111212 - Tarea 0000232 */
            lVencimientoReserva.Visible = _uiController.VisualizaFechaReserva;
            cldVencimientoReserva.Visible = _uiController.VisualizaFechaReserva;
            utility.Util.LoadImages(toolBarStandar, imglStandar);
            /* Fin Silvina 20111212 - Tarea 0000232 */
			
		}

		private void ConfigureGrid()
		{
			Janus.Windows.GridEX.GridEXColumnCollection col = gridProductos.RootTable.Columns;
			col["IdListaDePrecios"].HasValueList =true;
			col["IdListaDePrecios"].EditType= Janus.Windows.GridEX.EditType.Combo;
			col["IdListaDePrecios"].ValueList.PopulateValueList(_uiController.ListaDePrecios, _uiController.KeyValueListaDePrecios, _uiController.KeyListListaDePrecios);
			gridProductos.RootTable.Columns["IdListaDePrecios"].DefaultValue = _uiController.IdListaDePreciosDefault;

			
		}

		/*private void CallGridManager()
		{			
			string proceso = _uiController.GetProcessManager().GetProcessName();
			string tarea = _uiController.GetTaskName();
			controllers.GridVariablesLoader loader = new controllers.GridVariablesLoader(proceso, tarea);
			GridManagerJanus manager = new GridManagerJanus(gridProductos);
			manager.ConfigureGrid(proceso, tarea, loader, "FrmComprobantesDeVenta");							
			gridManagerView1.Init(manager, proceso, tarea, loader);
			gridManagerView1.EnableMarkControl(loader.AllowMarkRow);
			gridManagerView1.EnableColumnsControl(loader.AllowDefineVisibleColumns);
			gridManagerView1.ConfigureMarkControl(loader.NameMarkRow);
			gridManagerView1.ConfigureColumnsControl(string.Empty);	
			gridManagerView1.EnableExportExcelControl(loader.AllowExportExcel);
			gridManagerView1.ConfigureExportExcelControl(string.Empty);
		
			_allowGroupCollapse = loader.AllowGroupCollapse;
		}*/

		private void ConfigureInterfaceNoEditable()
		{
			mzCEResponsableEmision.Enabled = false;
			//acaa
			//mzComboCuentaSearchEditor1.Enabled = false;
			//acaa
			mzCmbCuenta.Enabled = false;
			mzCECondicionesDeVenta.Enabled=false;
			cldFechaComprobante.Enabled = false;
			//falta deshabilitar la edicion de los items de la grilla. 
			//se deshabilita en el gridProductos_DoubleClick
			mzProductosControl.Visible = false;
		}
		
		private void ConfigureInterfaceEditable()
		{
		}



		private void InitEventHandlers()
		{
			this.Load +=new EventHandler(FrmComprobantesDeVenta_Load);
			if(_uiController.ProductosControlFocused)
				this.Activated +=new EventHandler(FrmComprobantesDeVenta_Activated);
			mzCmbCuenta.ValueChanged+= new System.EventHandler( this.Componentes_Changes );			
			mzCmbCuenta.AllowEditClientePaso = true;
			mzCmbCuenta.SearchObjectListener = this;
			mzCEResponsableEmision.FillFromDataSource(businessrules.data.UsuariosPersonas.GetList(), "IdPersona","Nombre",200,"ID","Nombre","Nombre");			
			mzCECondicionesDeVenta.FillFromDataSource(_uiController.TableCondicionesDeVenta, "IdCondicionDeVenta","Descripcion",200,"ID","Descripcion",_uiController.HabilitaOrden?"Orden":"Descripcion");			
			_uiController.DataItemsChanged+= new System.EventHandler( this.RefreshData );
			// ObjectListener
			mzProductosControl.AddObjectListener( (IObserver) _uiController );
			mzProductosControl.SendObservable( (IObservable) _uiController );
			mzCmbCuenta.AddObjectListener( (IObserver) _uiController );
			mzCmbCuenta.SendObservable( (IObservable) _uiController);			
			// ------
			gridProductos.DoubleClick += new EventHandler(gridProductos_DoubleClick);
			gridProductos.KeyDown +=new KeyEventHandler(gridProductos_KeyDown);
			gridProductos.UpdatingCell +=new Janus.Windows.GridEX.UpdatingCellEventHandler(gridProductos_UpdatingCell);
			gridProductos.CellEdited+=new Janus.Windows.GridEX.ColumnActionEventHandler(gridProductos_CellEdited);
			gridProductos.RecordAdded +=new EventHandler(gridProductos_RecordAdded);
			gridProductos.Error += new Janus.Windows.GridEX.ErrorEventHandler(this.gridProductos_Error);
			gridProductos.RecordsDeleted +=new EventHandler(gridProductos_RecordsDeleted);
			gridVariablesUsuario.DoubleClick +=new EventHandler(gridVariablesUsuario_DoubleClick);
			gridProductos.DeletingRecords +=new CancelEventHandler(gridProductos_DeletingRecords);
			bAgregarProducto.Click += new EventHandler(this.UI_ControlEventsListener);
			_uiController.ComprobanteHasChanged +=new EventHandler(_uiController_ComprobanteHasChanged);
			this.Closed +=new EventHandler(FrmComprobantesDeVenta_Closed);
			_uiController.TableCondicionesDeVentaChanged +=new EventHandler(_uiController_TableCondicionesDeVentaChanged);						
			_uiController.NumeroComprobanteChanged +=new EventHandler(_uiController_NumeroComprobanteChanged);
			this.mzCEResponsableEmision.Leave+=new EventHandler(mzCEResponsableEmision_Change);
			this.txtNumero.ValueChanged +=new EventHandler(txtNumero_ValueChanged);

			MouseHelper mouseControler = new MouseHelper();
			mouseControler.Control = ultraExplorerBar1;
			mouseControler.WheelBackward+=new MouseEventHandler(ScrollDown);
			mouseControler.WheelForward += new MouseEventHandler(ScrollUp);
			gridProductos.DropDown += new Janus.Windows.GridEX.ColumnActionEventHandler(gridProductos_DropDown);

			_uiController.AddItemsChanged +=new EventHandler(_uiController_AddItemsChanged);
            KeyDownManager KeyDown = new KeyDownManager(this);            //Cristian Tarea 00179 20110808
            //gridVariablesUsuario.Error += new Janus.Windows.GridEX.ErrorEventHandler(gridVariablesUsuario_Error);
            //gridVariablesUsuario.CellUpdated += new Janus.Windows.GridEX.ColumnActionEventHandler(gridVariablesUsuario_CellUpdated);
            gridVariablesUsuario.CellEdited += new Janus.Windows.GridEX.ColumnActionEventHandler(gridVariablesUsuario_CellEdited);
            gridVariablesUsuario.UpdatingCell += new UpdatingCellEventHandler(gridVariablesUsuario_UpdatingCell);
            //Fin Cristian 20110808

        }

        void gridVariablesUsuario_UpdatingCell(object sender, UpdatingCellEventArgs e)
        {
            if (e.Value.Equals("") || e.Value == System.DBNull.Value)
                e.Value = " ";
        }
        //Cristian Tarea 00179 20110808
        void gridVariablesUsuario_CellEdited(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            gridVariablesUsuario.UpdateData();
           
        }
       //Fin Cristian 20011

		private void InitDataBindings()
		{
			txtTipoDeComprobante.DataBindings.Add( "Text", _uiController, "NombreDeComprobante");
									
			
			uneTotal1.DataBindings.Add("Value",_uiController,"Total");
			uneTotal.DataBindings.Add( "Value", _uiController, "Total");
			uneTotalImpuestos.DataBindings.Add("Value", _uiController, "TotalImpuestos");
			uneTotalNeto.DataBindings.Add("Value",_uiController,"TotalNeto");
			uneTotalBruto.DataBindings.Add( "Value",_uiController, "TotalBruto");
			uneTotalDescuentos.DataBindings.Add("Value",_uiController,"TotalDescuentos");
			uneRecargosFinancieros.DataBindings.Add("Value",_uiController,"TotalRecargosFinancieros");
			
			//BindingController.Bind(mzCEResponsableEmision,"Value", _uiController,"ResponsableDeEmision");
			mzCEResponsableEmision.DataBindings.Add("Value", _uiController,"ResponsableDeEmision");
			//BindingController.Bind(mzCmbCondicionDeVenta,"DataValue",_uiController,"CondicionDeVenta");
			/*
			txtNumero.DataBindings.Add( "InputMask",_uiController , "Mascara" );
			BindingController.Bind(txtNumero,"Text", _uiController, "NumeroComprobante" );
			*/
			
			txtNumero.InputMask = _uiController.Mascara;
			txtNumero.Text = _uiController.NumeroComprobante;
			
			BindingController.Bind(uTEObservaciones,"Text", _uiController, "Observaciones" );			
			BindingController.Bind(cldFechaComprobante, "Value", _uiController, "Fecha");

            /* Silvina 20111212 - Tarea 0000232 */
            cldVencimientoReserva.DataBindings.Add("Value", _uiController, "FechaReserva");
            /* Fin Silvina 20111212 - Tarea 0000232 */

			BindingController.Bind(mzCECondicionesDeVenta,"Value", _uiController, "CondicionDeVenta");
			gridProductos.SetDataBinding( _uiController.DataItems, null);
			gridResumenImpuestos.SetDataBinding(_uiController.ResumenDeImpuestos, null);
			gridVariablesUsuario.SetDataBinding(_uiController.VariablesDeUsuario, null);
			gridDetalleCondicionDeVenta.SetDataBinding(_uiController.DetalleCondicionDeVenta, null);			
			//this.KeyDown+=new KeyEventHandler(FrmComprobantesDeVenta_KeyDown);
		}

		private void InitializeData()
		{	
			
			if(_uiController.RenombraClienteDePaso)
				mzCmbCuenta.SetNombreClienteDePaso(_uiController.NombreClientePaso);
			mzCmbCuenta.DataValue = _uiController.Cuenta;
			//_uiController.cl;
            /* Silvina 20110316 - Tarea 0000039 */
            uneSaldo.Value = _uiController.Comprobante.TotalNC - _uiController.Total;
            /* Fin Silvina */
		}

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
			_uiController.NumeroComprobante = txtNumero.Text;
			_uiController.Execute();
		}

		public void AddObjectListener( IObserver _object )			 
		{
			_uiController.AddObjectListener(_object);						
		}		

		private void Componentes_Changes( object sender, System.EventArgs e )
		{			
			/*if (_uiController.Cuenta.CompareTo( Convert.ToString(mzCmbCuenta.DataValue)) != 0
				|| )
			{
			*/
				_uiController.Cuenta = Convert.ToString(mzCmbCuenta.DataValue);				
			//}
		}

		private void UI_ControlEventsListener( object sender, System.EventArgs e)
		{
			string _componentName = ((Control)sender).Name;
			switch (_componentName)
			{
				case "bAgregarProducto":
					AgregarProducto();
					break;
				case "bElimiarProducto":
					break;
			}
		}

		private void AgregarProducto()
		{
			FrmComprobantesABMProductos form = new FrmComprobantesABMProductos();
			form.AddObjectListener( (ISearchObjectListener)_uiController );
			form.ShowForm( _uiController.Comprobante, "Nuevo", "Agregar Productos");
		}
		#region Implemetancion Interface ISearchObjectListener

		public void processEventChange(object sender , EventArgs e)
		{
			System.Data.DataSet data = (System.Data.DataSet)sender;
			System.Data.DataTable table = data.Tables["tsa_cuentas"];
			System.Data.DataRow row = table.Rows[0];
			//aca
			//mzComboCuentaSearchEditor1.DataValue = (string )row["Codigo"];
			//aca
			// = (string )row["Codigo"];
			//_uiController.DatosCuentaChanged = true;
			mzCmbCuenta.DataValue = Convert.ToString(row["Codigo"]);

			
		}
		private void RefreshData( object sender, System.EventArgs e)
		{
			_uiController.MustRecalcular = false;
			gridProductos.Refresh();
			gridProductos.Refetch();
			_uiController.MustRecalcular = true;

            /* Silvina 20110316 - Tarea 0000039 */
            uneSaldo.Value = _uiController.Comprobante.TotalNC - _uiController.Total;
            /* Fin Silvina */
		}
		#endregion

		private void ultraExplorerBar1_ItemClick(object sender, Infragistics.Win.UltraWinExplorerBar.ItemEventArgs e)
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
				case 2:
					mz.erp.ui.utility.Util.MoveFocus(ultraExplorerBarContainerControl1);
					mzCmbCuenta.ValueChanged-= new System.EventHandler( this.Componentes_Changes );	
					gridProductos.Select();
					_uiController.Cuenta = Convert.ToString(mzCmbCuenta.DataValue);	
					_uiController.NumeroComprobante = txtNumero.Text;
					_uiController.Execute();
					break;
				case 4:
					CloseForm();
					break;
			}		
		}
		private void gridProductos_Error(object sender, Janus.Windows.GridEX.ErrorEventArgs e)
		{
			e.DisplayErrorMessage = false;
		}

		private void gridProductos_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == System.Windows.Forms.Keys.D)
			{
				if(e.Modifiers == System.Windows.Forms.Keys.Alt)
				{
			

					
					ArrayList items = new ArrayList();
					foreach(Janus.Windows.GridEX.GridEXSelectedItem itemSelected in gridProductos.SelectedItems)
					{
						items.Add(_uiController.ConvertToItem(itemSelected.GetRow().DataRow));

					}
					FrmDetalleItem frmdi = new FrmDetalleItem(items, "");
					frmdi.ShowDialog();
			
				}
			}
			/*
			else
			{
				
				
				if(e.KeyCode == System.Windows.Forms.Keys.Enter)
				{
					if(gridProductos.SelectedItems.Count > 0 && gridProductos.Col != -1)
					{
						string column = gridProductos.RootTable.Columns[gridProductos.Col].Key;
						if(!_uiController.AllowEnterKey(column))
						{	
							gridProductos.UpdateData();
							gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
						}
					}
				}
			}
			*/
					
		}

		private void gridProductos_RecordAdded(object sender, EventArgs e)
		{
			gridProductos.MoveToNewRecord();
		}


		private void gridProductos_RecordsDeleted(object sender, EventArgs e)
		{
			_uiController.OnRecalcularItems();
		}

		private void gridProductos_DoubleClick(object sender, EventArgs e)
		{
			if(gridProductos.SelectedItems.Count > 0)
			{
				
				object selectedItem = 	gridProductos.SelectedItems[0].GetRow().DataRow;
				int col = gridProductos.Col;
				if (col != -1)
				{
					string column = gridProductos.RootTable.Columns[col].Key;
					if (_uiController.IsEditable(selectedItem, column)) 
					{
						if(_uiController.AllowEditInOtherWindow(column))
						{
							FrmInputType frmInputType = new FrmInputType(_uiController.GetDescription(column),selectedItem,column,_uiController.GetTypeOfColumn(selectedItem,column),typeof(mz.erp.businessrules.comprobantes.ItemComprobante));
							frmInputType.ShowDialog();
                            //German 20120524 - Tarea 0000342
                            //gridProductos.SetDataBinding(null, null);
                            gridProductos.DataBindings.Clear();
                            
                            //Fin German 20120524 - Tarea 0000342
							gridProductos.SetDataBinding(_uiController.DataItems, null);
						}
						else
						{
							gridProductos.RootTable.Columns[col].EditType = Janus.Windows.GridEX.EditType.TextBox;
							gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
							ConfigureGrid();
						}
					}
			
					else
					{
						if(gridProductos.AllowEdit.Equals(Janus.Windows.GridEX.InheritableBoolean.True))
							gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;		
					}
				}
				
			}
			
		}

		private void _uiController_ComprobanteHasChanged(object sender, EventArgs e)
		{
			gridProductos.DataBindings.Clear();
			gridProductos.SetDataBinding(_uiController.DataItems, null);
			ConfigureGrid();
			gridVariablesUsuario.DataBindings.Clear();
			gridVariablesUsuario.SetDataBinding(_uiController.VariablesDeUsuario, null );
			gridResumenImpuestos.DataBindings.Clear();
			gridResumenImpuestos.SetDataBinding( _uiController.ResumenDeImpuestos, null);
			gridDetalleCondicionDeVenta.DataBindings.Clear();
			gridDetalleCondicionDeVenta.SetDataBinding(_uiController.DetalleCondicionDeVenta, null);
			this.Text = _uiController.Caption;
			
		}

		private void gridVariablesUsuario_DoubleClick(object sender, EventArgs e)
		{
			VariableAuxiliar var = (VariableAuxiliar)gridVariablesUsuario.GetRow().DataRow;
			FrmInputType frmInputType = new FrmInputType(var.Descripcion,var,"Valor",var.DataType,typeof(mz.erp.businessrules.comprobantes.VariableAuxiliar));
			frmInputType.ShowDialog();
			gridVariablesUsuario.SetDataBinding(null, null);
			gridVariablesUsuario.SetDataBinding(_uiController.VariablesDeUsuario,null);
		}

		private void FrmComprobantesDeVenta_Closed(object sender, EventArgs e)
		{
			ClearDataBindings();
			ClearEventHandlers();
		}

		private void ClearDataBindings()
		{
			uneRecargosFinancieros.DataBindings.Clear();
			uneTotal.DataBindings.Clear();
			uneTotal1.DataBindings.Clear();
			uneTotalBruto.DataBindings.Clear();
			uneTotalDescuentos.DataBindings.Clear();
			uneTotalImpuestos.DataBindings.Clear();
			uneTotalNeto.DataBindings.Clear();
			cldFechaComprobante.DataBindings.Clear();
			ultraNumericEditor1.DataBindings.Clear();
			ultraNumericEditor2.DataBindings.Clear();
			mzCEResponsableEmision.DataBindings.Clear();
			//aca
			mzCmbCuenta.DataBindings.Clear();
			//mzComboCuentaSearchEditor1.DataBindings.Clear();
			//aca			
			//mzCmbCondicionDeVenta.DataBindings.Clear();

			BindingController.Clear(mzCECondicionesDeVenta,"Value", _uiController, "CondicionDeVenta");

			//BindingController.Clear(mzCEResponsableEmision,"Value", _uiController,"ResponsableDeEmision");
			
			//BindingController.Clear(txtNumero,"Text", _uiController, "NumeroComprobante" );
			BindingController.Clear(uTEObservaciones,"Text", _uiController, "Observaciones" );	
			BindingController.Clear(cldFechaComprobante, "Value", _uiController, "Fecha");
			mzCECondicionesDeVenta.DataBindings.Clear();			


		}

		private void ClearEventHandlers()
		{
			//aca
			//mzCmbCuenta.ValueChanged-= new System.EventHandler( this.Componentes_Changes );
			//mzComboCuentaSearchEditor1.ValueChanged-= new System.EventHandler( this.Componentes_Changes );
			_uiController.DataItemsChanged -= new System.EventHandler( this.RefreshData );
			gridProductos.DoubleClick -= new EventHandler(gridProductos_DoubleClick);
			gridProductos.KeyDown -=new KeyEventHandler(gridProductos_KeyDown);
			gridProductos.RecordAdded -=new EventHandler(gridProductos_RecordAdded);
			gridProductos.Error -= new Janus.Windows.GridEX.ErrorEventHandler(this.gridProductos_Error);
			gridProductos.RecordsDeleted -=new EventHandler(gridProductos_RecordsDeleted);
			gridVariablesUsuario.DoubleClick -=new EventHandler(gridVariablesUsuario_DoubleClick);
			bAgregarProducto.Click -= new EventHandler(this.UI_ControlEventsListener);
			_uiController.ComprobanteHasChanged -=new EventHandler(_uiController_ComprobanteHasChanged);			
			this.mzCEResponsableEmision.Leave-=new EventHandler(mzCEResponsableEmision_Change);
			this.Closed -=new EventHandler(FrmComprobantesDeVenta_Closed);			
			this.KeyDown-=new KeyEventHandler(FrmComprobantesDeVenta_KeyDown);
			_uiController.AddItemsChanged -=new EventHandler(_uiController_AddItemsChanged);
			
		}

		public void Execute()
		{
			this._uiController.Execute();
		}

		public void Previous()
		{
			this._uiController.Previous();
		}


		private void gridProductos_DeletingRecords(object sender, CancelEventArgs e)
		{
			if(gridProductos.SelectedItems.Count ==  1)
			{
				if (_uiController.AllowDeleteItems) 
				{
					object selectedItem = 	gridProductos.SelectedItems[0].GetRow().DataRow;
					if (_uiController.IsRemovable(selectedItem)) 
						e.Cancel = false;
					else e.Cancel = true;
				}
				else e.Cancel = true;
			}
			else e.Cancel = true;
		}

		private void FrmComprobantesDeVenta_Load(object sender, System.EventArgs e)
		{
			
		}

		private void cldFechaComprobante_BeforeDropDown(object sender, System.ComponentModel.CancelEventArgs e)
		{
			cldFechaComprobante.Text = Convert.ToString(System.DateTime.Today);
		}

		private void gridProductos_CellEdited(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
		{
			
			/*if(gridProductos.SelectedItems.Count > 0 && gridProductos.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
			{
				object value = gridProductos.SelectedItems[0].GetRow().Cells[e.Column].Value;
				if(value != null && value != System.DBNull.Value)
				{
					gridProductos.UpdateData();
					//gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
				}
				else
				{
					Ojo con esto - El default debe depender del tipo de datos o de la columna
					gridProductos.SelectedItems[0].GetRow().Cells[e.Column].Value = 0;
					gridProductos.UpdateData();
					//gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
				}
			}
			*/
			gridProductos.UpdateData();
			gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
		}

		private void _uiController_TableCondicionesDeVentaChanged(object sender, EventArgs e)
		{
			mzCECondicionesDeVenta.FillFromDataSource(_uiController.TableCondicionesDeVenta, "IdCondicionDeVenta","Descripcion",200,"ID","Descripcion","Descripcion");
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

		private void mzCEResponsableEmision_Change(object sender, EventArgs e)
		{
			if (_uiController.AskForPasswordResponsableEmision) 
			{
				ShowPassword();				
			}	
		}

		private void FrmComprobantesDeVenta_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.Modifiers == System.Windows.Forms.Keys.Alt)
			{
				if(e.KeyCode == System.Windows.Forms.Keys.S)
				{
					mz.erp.ui.utility.Util.MoveFocus(ultraExplorerBarContainerControl1);
					_uiController.NumeroComprobante = txtNumero.Text;
					_uiController.Execute();
				}
			}						
		}

		private void gridProductos_UpdatingCell(object sender, Janus.Windows.GridEX.UpdatingCellEventArgs e)
		{
			    if(e.Value == null || e.Value == System.DBNull.Value)
				e.Cancel = true;
		}

		private void _uiController_NumeroComprobanteChanged(object sender, EventArgs e)
		{
			//German 20090804
			/*
			txtNumero.InputMask = _uiController.Mascara;
			txtNumero.Text = _uiController.NumeroComprobante;
			*/
			this.txtNumero.ValueChanged -=new EventHandler(txtNumero_ValueChanged);
			txtNumero.InputMask = _uiController.Mascara;
			txtNumero.Text = _uiController.NumeroComprobante;
			this.txtNumero.ValueChanged +=new EventHandler(txtNumero_ValueChanged);
			//Fin German 20090804
		}

		private void txtNumero_ValueChanged(object sender, EventArgs e)
		{
			_uiController.NumeroComprobante = txtNumero.Text;
		}
		private void ScrollDown (object sender, MouseEventArgs e)
		{
			ultraExplorerBar1.PerformAction(UltraExplorerBarAction.ScrollPageDown);
		}

		private void ScrollUp (object sender, MouseEventArgs e)
		{
			ultraExplorerBar1.PerformAction(UltraExplorerBarAction.ScrollPageUp);
		}

		private void gridProductos_DropDown(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
		{			
			string key = e.Column.Key;
			switch(key)
			{
				case "IdListaDePrecios": 
				{				
					Janus.Windows.GridEX.GridEXColumnCollection col = gridProductos.RootTable.Columns;
					col["IdListaDePrecios"].ValueList.PopulateValueList(_uiController.ListaDePrecios, _uiController.KeyValueListaDePrecios, _uiController.KeyListListaDePrecios);
					break;
				}
				default:
					break;				
			}

		}


		private bool loaded = false;
		private void FrmComprobantesDeVenta_Activated(object sender, EventArgs e)
		{
			
			if(!loaded)
			{
				this.ActiveControl = this.ultraExplorerBarContainerControl2;
				mzProductosControl.SetFocus();
				loaded = true;
				
			}
			
		}

	
		protected Control GetFocusControl() 
		{ 
			Control focusControl = null; 
			IntPtr focusHandle = GetFocus(); 
			if ( focusHandle != IntPtr.Zero ) 
				// returns null if handle is not to a .NET control
				focusControl = Control.FromHandle( focusHandle );
			return focusControl; 
		}

		private void txtNumero_Leave(object sender, System.EventArgs e)
		{
			this.txtNumero.Text = _uiController.FillNumberWithZeros(txtNumero.Text);
		}

		private void _uiController_AddItemsChanged(object sender, EventArgs e)
		{
			if((_uiController.DataItems.Count > 0)&& (_uiController.SeleccionaUltimo))
				gridProductos.MoveLast();
		}

        private void mzCmbCuenta_Load(object sender, EventArgs e)
        {

        }
	}
}

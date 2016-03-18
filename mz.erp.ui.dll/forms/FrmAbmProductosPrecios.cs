using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using mz.erp.ui.forms.classes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmAbmProductosPrecios.
	/// </summary>
	public class FrmAbmProductosPrecios : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.ImageList imglStandar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.Label Productos;
		protected System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		protected System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		protected System.Windows.Forms.ToolBarButton tbbCancelar;
		private System.Windows.Forms.GroupBox groupBoxMonedaPrecioDeVenta;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneValorCotizacionPrecioDeVentaNeto;
		private mz.erp.ui.controls.mzComboEditor mzCmbMonedaMaximoDescuento;
		private System.Windows.Forms.Label label16;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneMaximoDescuentoAplicable;
		private System.Windows.Forms.Label label17;
		private mz.erp.ui.controls.mzComboEditor mzCmbMonedaPrecioDeVentaBruto1;
		private mz.erp.ui.controls.mzComboEditor mzCmbMonedaPrecioDeVentaBruto;
		private mz.erp.ui.controls.mzComboEditor mzCmbFuenteDeCambioPrecioDeVentaNeto;
		private mz.erp.ui.controls.mzComboEditor mzCmbMonedaPrecioDeVentaNeto;
		private System.Windows.Forms.Label label21;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor ultraNumericEditor7;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label18;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor ultraNumericEditor6;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label7;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePorcentajeMaximoDescuentoAplicable;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label10;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeVentaNeto;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBoxMonedaPrecioDeCosto;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneValorCotizacionPrecioDeCostoRef;
		private System.Windows.Forms.Label label5;
		private mz.erp.ui.controls.mzComboEditor mzCmbMonedaPrecioDeCostoRef1;
		private mz.erp.ui.controls.mzComboEditor mzCmbMonedaPrecioDeCostoRef;
		private mz.erp.ui.controls.mzComboEditor mzCmbFuenteDeCambioPrecioDeCostoRef;
		private System.Windows.Forms.Label label4;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeVentaNetoMonedaCostoRef;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label9;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneMAC;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeCostoRef;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components;

		
		#region Constructores y Destructores

		public FrmAbmProductosPrecios(AbmProductosPreciosController uiController)
		{
			InitializeComponent();
			_uiController = uiController;
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

		#region Variables Privadas
		
			private AbmProductosPreciosController _uiController;

		#endregion

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmAbmProductosPrecios));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.Productos = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.groupBoxMonedaPrecioDeCosto = new System.Windows.Forms.GroupBox();
			this.uneValorCotizacionPrecioDeCostoRef = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label5 = new System.Windows.Forms.Label();
			this.mzCmbMonedaPrecioDeCostoRef1 = new mz.erp.ui.controls.mzComboEditor();
			this.mzCmbMonedaPrecioDeCostoRef = new mz.erp.ui.controls.mzComboEditor();
			this.mzCmbFuenteDeCambioPrecioDeCostoRef = new mz.erp.ui.controls.mzComboEditor();
			this.label4 = new System.Windows.Forms.Label();
			this.unePrecioDeVentaNetoMonedaCostoRef = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label3 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.uneMAC = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.unePrecioDeCostoRef = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBoxMonedaPrecioDeVenta = new System.Windows.Forms.GroupBox();
			this.uneValorCotizacionPrecioDeVentaNeto = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.mzCmbMonedaMaximoDescuento = new mz.erp.ui.controls.mzComboEditor();
			this.label16 = new System.Windows.Forms.Label();
			this.uneMaximoDescuentoAplicable = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label17 = new System.Windows.Forms.Label();
			this.mzCmbMonedaPrecioDeVentaBruto1 = new mz.erp.ui.controls.mzComboEditor();
			this.mzCmbMonedaPrecioDeVentaBruto = new mz.erp.ui.controls.mzComboEditor();
			this.mzCmbFuenteDeCambioPrecioDeVentaNeto = new mz.erp.ui.controls.mzComboEditor();
			this.mzCmbMonedaPrecioDeVentaNeto = new mz.erp.ui.controls.mzComboEditor();
			this.label21 = new System.Windows.Forms.Label();
			this.ultraNumericEditor7 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label22 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.ultraNumericEditor6 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label14 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.unePorcentajeMaximoDescuentoAplicable = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label15 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.unePrecioDeVentaNeto = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label11 = new System.Windows.Forms.Label();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.groupBoxMonedaPrecioDeCosto.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uneValorCotizacionPrecioDeCostoRef)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbMonedaPrecioDeCostoRef1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbMonedaPrecioDeCostoRef)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbFuenteDeCambioPrecioDeCostoRef)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.unePrecioDeVentaNetoMonedaCostoRef)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneMAC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoRef)).BeginInit();
			this.groupBoxMonedaPrecioDeVenta.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uneValorCotizacionPrecioDeVentaNeto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbMonedaMaximoDescuento)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneMaximoDescuentoAplicable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbMonedaPrecioDeVentaBruto1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbMonedaPrecioDeVentaBruto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbFuenteDeCambioPrecioDeVentaNeto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbMonedaPrecioDeVentaNeto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.unePorcentajeMaximoDescuentoAplicable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.unePrecioDeVentaNeto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.Productos);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(791, 24);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// Productos
			// 
			this.Productos.BackColor = System.Drawing.Color.Transparent;
			this.Productos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Productos.Location = new System.Drawing.Point(0, 0);
			this.Productos.Name = "Productos";
			this.Productos.Size = new System.Drawing.Size(791, 24);
			this.Productos.TabIndex = 0;
			this.Productos.Text = "Precios, márgenes y monedas";
			this.Productos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.groupBoxMonedaPrecioDeCosto);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.groupBoxMonedaPrecioDeVenta);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 107);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(791, 277);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// groupBoxMonedaPrecioDeCosto
			// 
			this.groupBoxMonedaPrecioDeCosto.BackColor = System.Drawing.Color.Transparent;
			this.groupBoxMonedaPrecioDeCosto.Controls.Add(this.uneValorCotizacionPrecioDeCostoRef);
			this.groupBoxMonedaPrecioDeCosto.Controls.Add(this.label5);
			this.groupBoxMonedaPrecioDeCosto.Controls.Add(this.mzCmbMonedaPrecioDeCostoRef1);
			this.groupBoxMonedaPrecioDeCosto.Controls.Add(this.mzCmbMonedaPrecioDeCostoRef);
			this.groupBoxMonedaPrecioDeCosto.Controls.Add(this.mzCmbFuenteDeCambioPrecioDeCostoRef);
			this.groupBoxMonedaPrecioDeCosto.Controls.Add(this.label4);
			this.groupBoxMonedaPrecioDeCosto.Controls.Add(this.unePrecioDeVentaNetoMonedaCostoRef);
			this.groupBoxMonedaPrecioDeCosto.Controls.Add(this.label3);
			this.groupBoxMonedaPrecioDeCosto.Controls.Add(this.label9);
			this.groupBoxMonedaPrecioDeCosto.Controls.Add(this.uneMAC);
			this.groupBoxMonedaPrecioDeCosto.Controls.Add(this.unePrecioDeCostoRef);
			this.groupBoxMonedaPrecioDeCosto.Controls.Add(this.label8);
			this.groupBoxMonedaPrecioDeCosto.Controls.Add(this.label6);
			this.groupBoxMonedaPrecioDeCosto.Controls.Add(this.label2);
			this.groupBoxMonedaPrecioDeCosto.Controls.Add(this.label1);
			this.groupBoxMonedaPrecioDeCosto.Location = new System.Drawing.Point(0, 0);
			this.groupBoxMonedaPrecioDeCosto.Name = "groupBoxMonedaPrecioDeCosto";
			this.groupBoxMonedaPrecioDeCosto.Size = new System.Drawing.Size(792, 112);
			this.groupBoxMonedaPrecioDeCosto.TabIndex = 67;
			this.groupBoxMonedaPrecioDeCosto.TabStop = false;
			this.groupBoxMonedaPrecioDeCosto.Text = "Moneda Precio de Costo";
			// 
			// uneValorCotizacionPrecioDeCostoRef
			// 
			this.uneValorCotizacionPrecioDeCostoRef.Location = new System.Drawing.Point(632, 30);
			this.uneValorCotizacionPrecioDeCostoRef.Name = "uneValorCotizacionPrecioDeCostoRef";
			this.uneValorCotizacionPrecioDeCostoRef.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneValorCotizacionPrecioDeCostoRef.Size = new System.Drawing.Size(136, 21);
			this.uneValorCotizacionPrecioDeCostoRef.TabIndex = 79;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(312, 86);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label5.Size = new System.Drawing.Size(48, 16);
			this.label5.TabIndex = 78;
			this.label5.Text = "Moneda";
			// 
			// mzCmbMonedaPrecioDeCostoRef1
			// 
			this.mzCmbMonedaPrecioDeCostoRef1.AutoComplete = true;
			this.mzCmbMonedaPrecioDeCostoRef1.DataSource = null;
			this.mzCmbMonedaPrecioDeCostoRef1.DisplayMember = "";
			this.mzCmbMonedaPrecioDeCostoRef1.DisplayMemberCaption = "";
			this.mzCmbMonedaPrecioDeCostoRef1.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbMonedaPrecioDeCostoRef1.Location = new System.Drawing.Point(367, 83);
			this.mzCmbMonedaPrecioDeCostoRef1.MaxItemsDisplay = 200;
			this.mzCmbMonedaPrecioDeCostoRef1.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbMonedaPrecioDeCostoRef1.Name = "mzCmbMonedaPrecioDeCostoRef1";
			this.mzCmbMonedaPrecioDeCostoRef1.Size = new System.Drawing.Size(136, 21);
			this.mzCmbMonedaPrecioDeCostoRef1.SorterMember = "";
			this.mzCmbMonedaPrecioDeCostoRef1.TabIndex = 77;
			this.mzCmbMonedaPrecioDeCostoRef1.ValueMember = "";
			this.mzCmbMonedaPrecioDeCostoRef1.ValueMemberCaption = "";
			// 
			// mzCmbMonedaPrecioDeCostoRef
			// 
			this.mzCmbMonedaPrecioDeCostoRef.AutoComplete = true;
			this.mzCmbMonedaPrecioDeCostoRef.DataSource = null;
			this.mzCmbMonedaPrecioDeCostoRef.DisplayMember = "";
			this.mzCmbMonedaPrecioDeCostoRef.DisplayMemberCaption = "";
			this.mzCmbMonedaPrecioDeCostoRef.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbMonedaPrecioDeCostoRef.Location = new System.Drawing.Point(366, 7);
			this.mzCmbMonedaPrecioDeCostoRef.MaxItemsDisplay = 200;
			this.mzCmbMonedaPrecioDeCostoRef.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbMonedaPrecioDeCostoRef.Name = "mzCmbMonedaPrecioDeCostoRef";
			this.mzCmbMonedaPrecioDeCostoRef.Size = new System.Drawing.Size(136, 21);
			this.mzCmbMonedaPrecioDeCostoRef.SorterMember = "";
			this.mzCmbMonedaPrecioDeCostoRef.TabIndex = 76;
			this.mzCmbMonedaPrecioDeCostoRef.ValueMember = "";
			this.mzCmbMonedaPrecioDeCostoRef.ValueMemberCaption = "";
			// 
			// mzCmbFuenteDeCambioPrecioDeCostoRef
			// 
			this.mzCmbFuenteDeCambioPrecioDeCostoRef.AutoComplete = true;
			this.mzCmbFuenteDeCambioPrecioDeCostoRef.DataSource = null;
			this.mzCmbFuenteDeCambioPrecioDeCostoRef.DisplayMember = "";
			this.mzCmbFuenteDeCambioPrecioDeCostoRef.DisplayMemberCaption = "";
			this.mzCmbFuenteDeCambioPrecioDeCostoRef.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbFuenteDeCambioPrecioDeCostoRef.Location = new System.Drawing.Point(632, 7);
			this.mzCmbFuenteDeCambioPrecioDeCostoRef.MaxItemsDisplay = 200;
			this.mzCmbFuenteDeCambioPrecioDeCostoRef.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbFuenteDeCambioPrecioDeCostoRef.Name = "mzCmbFuenteDeCambioPrecioDeCostoRef";
			this.mzCmbFuenteDeCambioPrecioDeCostoRef.Size = new System.Drawing.Size(136, 21);
			this.mzCmbFuenteDeCambioPrecioDeCostoRef.SorterMember = "";
			this.mzCmbFuenteDeCambioPrecioDeCostoRef.TabIndex = 75;
			this.mzCmbFuenteDeCambioPrecioDeCostoRef.ValueMember = "";
			this.mzCmbFuenteDeCambioPrecioDeCostoRef.ValueMemberCaption = "";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(496, 36);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label4.Size = new System.Drawing.Size(128, 16);
			this.label4.TabIndex = 74;
			this.label4.Text = "Cotización de Cierre";
			// 
			// unePrecioDeVentaNetoMonedaCostoRef
			// 
			this.unePrecioDeVentaNetoMonedaCostoRef.Location = new System.Drawing.Point(208, 85);
			this.unePrecioDeVentaNetoMonedaCostoRef.Name = "unePrecioDeVentaNetoMonedaCostoRef";
			this.unePrecioDeVentaNetoMonedaCostoRef.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.unePrecioDeVentaNetoMonedaCostoRef.Size = new System.Drawing.Size(88, 21);
			this.unePrecioDeVentaNetoMonedaCostoRef.TabIndex = 73;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(24, 87);
			this.label3.Name = "label3";
			this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label3.Size = new System.Drawing.Size(176, 19);
			this.label3.TabIndex = 72;
			this.label3.Text = "Precio de Venta sin impuestos";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(303, 69);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(17, 16);
			this.label9.TabIndex = 71;
			this.label9.Text = "%";
			// 
			// uneMAC
			// 
			this.uneMAC.Location = new System.Drawing.Point(208, 61);
			this.uneMAC.Name = "uneMAC";
			this.uneMAC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneMAC.Size = new System.Drawing.Size(88, 21);
			this.uneMAC.TabIndex = 70;
			// 
			// unePrecioDeCostoRef
			// 
			this.unePrecioDeCostoRef.Location = new System.Drawing.Point(208, 7);
			this.unePrecioDeCostoRef.Name = "unePrecioDeCostoRef";
			this.unePrecioDeCostoRef.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.unePrecioDeCostoRef.Size = new System.Drawing.Size(88, 21);
			this.unePrecioDeCostoRef.TabIndex = 69;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(520, 10);
			this.label8.Name = "label8";
			this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label8.Size = new System.Drawing.Size(104, 16);
			this.label8.TabIndex = 68;
			this.label8.Text = "Tipo de Cambio";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(304, 10);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label6.Size = new System.Drawing.Size(58, 16);
			this.label6.TabIndex = 67;
			this.label6.Text = "Moneda";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(72, 63);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label2.Size = new System.Drawing.Size(128, 16);
			this.label2.TabIndex = 66;
			this.label2.Text = "Margen";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(27, 11);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label1.Size = new System.Drawing.Size(173, 16);
			this.label1.TabIndex = 65;
			this.label1.Text = "Precio de Costo";
			// 
			// groupBoxMonedaPrecioDeVenta
			// 
			this.groupBoxMonedaPrecioDeVenta.BackColor = System.Drawing.Color.Transparent;
			this.groupBoxMonedaPrecioDeVenta.Controls.Add(this.uneValorCotizacionPrecioDeVentaNeto);
			this.groupBoxMonedaPrecioDeVenta.Controls.Add(this.mzCmbMonedaMaximoDescuento);
			this.groupBoxMonedaPrecioDeVenta.Controls.Add(this.label16);
			this.groupBoxMonedaPrecioDeVenta.Controls.Add(this.uneMaximoDescuentoAplicable);
			this.groupBoxMonedaPrecioDeVenta.Controls.Add(this.label17);
			this.groupBoxMonedaPrecioDeVenta.Controls.Add(this.mzCmbMonedaPrecioDeVentaBruto1);
			this.groupBoxMonedaPrecioDeVenta.Controls.Add(this.mzCmbMonedaPrecioDeVentaBruto);
			this.groupBoxMonedaPrecioDeVenta.Controls.Add(this.mzCmbFuenteDeCambioPrecioDeVentaNeto);
			this.groupBoxMonedaPrecioDeVenta.Controls.Add(this.mzCmbMonedaPrecioDeVentaNeto);
			this.groupBoxMonedaPrecioDeVenta.Controls.Add(this.label21);
			this.groupBoxMonedaPrecioDeVenta.Controls.Add(this.ultraNumericEditor7);
			this.groupBoxMonedaPrecioDeVenta.Controls.Add(this.label22);
			this.groupBoxMonedaPrecioDeVenta.Controls.Add(this.label18);
			this.groupBoxMonedaPrecioDeVenta.Controls.Add(this.ultraNumericEditor6);
			this.groupBoxMonedaPrecioDeVenta.Controls.Add(this.label14);
			this.groupBoxMonedaPrecioDeVenta.Controls.Add(this.label7);
			this.groupBoxMonedaPrecioDeVenta.Controls.Add(this.unePorcentajeMaximoDescuentoAplicable);
			this.groupBoxMonedaPrecioDeVenta.Controls.Add(this.label15);
			this.groupBoxMonedaPrecioDeVenta.Controls.Add(this.label12);
			this.groupBoxMonedaPrecioDeVenta.Controls.Add(this.label13);
			this.groupBoxMonedaPrecioDeVenta.Controls.Add(this.label10);
			this.groupBoxMonedaPrecioDeVenta.Controls.Add(this.unePrecioDeVentaNeto);
			this.groupBoxMonedaPrecioDeVenta.Controls.Add(this.label11);
			this.groupBoxMonedaPrecioDeVenta.Location = new System.Drawing.Point(0, 112);
			this.groupBoxMonedaPrecioDeVenta.Name = "groupBoxMonedaPrecioDeVenta";
			this.groupBoxMonedaPrecioDeVenta.Size = new System.Drawing.Size(792, 160);
			this.groupBoxMonedaPrecioDeVenta.TabIndex = 66;
			this.groupBoxMonedaPrecioDeVenta.TabStop = false;
			this.groupBoxMonedaPrecioDeVenta.Text = "Moneda Precio De Venta";
			// 
			// uneValorCotizacionPrecioDeVentaNeto
			// 
			this.uneValorCotizacionPrecioDeVentaNeto.Location = new System.Drawing.Point(630, 48);
			this.uneValorCotizacionPrecioDeVentaNeto.Name = "uneValorCotizacionPrecioDeVentaNeto";
			this.uneValorCotizacionPrecioDeVentaNeto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneValorCotizacionPrecioDeVentaNeto.Size = new System.Drawing.Size(136, 21);
			this.uneValorCotizacionPrecioDeVentaNeto.TabIndex = 88;
			// 
			// mzCmbMonedaMaximoDescuento
			// 
			this.mzCmbMonedaMaximoDescuento.AutoComplete = true;
			this.mzCmbMonedaMaximoDescuento.DataSource = null;
			this.mzCmbMonedaMaximoDescuento.DisplayMember = "";
			this.mzCmbMonedaMaximoDescuento.DisplayMemberCaption = "";
			this.mzCmbMonedaMaximoDescuento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbMonedaMaximoDescuento.Location = new System.Drawing.Point(366, 72);
			this.mzCmbMonedaMaximoDescuento.MaxItemsDisplay = 200;
			this.mzCmbMonedaMaximoDescuento.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbMonedaMaximoDescuento.Name = "mzCmbMonedaMaximoDescuento";
			this.mzCmbMonedaMaximoDescuento.Size = new System.Drawing.Size(136, 21);
			this.mzCmbMonedaMaximoDescuento.SorterMember = "";
			this.mzCmbMonedaMaximoDescuento.TabIndex = 87;
			this.mzCmbMonedaMaximoDescuento.ValueMember = "";
			this.mzCmbMonedaMaximoDescuento.ValueMemberCaption = "";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Location = new System.Drawing.Point(310, 72);
			this.label16.Name = "label16";
			this.label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label16.Size = new System.Drawing.Size(48, 16);
			this.label16.TabIndex = 86;
			this.label16.Text = "Moneda";
			// 
			// uneMaximoDescuentoAplicable
			// 
			this.uneMaximoDescuentoAplicable.Location = new System.Drawing.Point(206, 72);
			this.uneMaximoDescuentoAplicable.Name = "uneMaximoDescuentoAplicable";
			this.uneMaximoDescuentoAplicable.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneMaximoDescuentoAplicable.Size = new System.Drawing.Size(88, 21);
			this.uneMaximoDescuentoAplicable.TabIndex = 85;
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Location = new System.Drawing.Point(28, 72);
			this.label17.Name = "label17";
			this.label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label17.Size = new System.Drawing.Size(173, 16);
			this.label17.TabIndex = 84;
			this.label17.Text = "Maximo descuento aplicable";
			// 
			// mzCmbMonedaPrecioDeVentaBruto1
			// 
			this.mzCmbMonedaPrecioDeVentaBruto1.AutoComplete = true;
			this.mzCmbMonedaPrecioDeVentaBruto1.DataSource = null;
			this.mzCmbMonedaPrecioDeVentaBruto1.DisplayMember = "";
			this.mzCmbMonedaPrecioDeVentaBruto1.DisplayMemberCaption = "";
			this.mzCmbMonedaPrecioDeVentaBruto1.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbMonedaPrecioDeVentaBruto1.Location = new System.Drawing.Point(366, 128);
			this.mzCmbMonedaPrecioDeVentaBruto1.MaxItemsDisplay = 200;
			this.mzCmbMonedaPrecioDeVentaBruto1.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbMonedaPrecioDeVentaBruto1.Name = "mzCmbMonedaPrecioDeVentaBruto1";
			this.mzCmbMonedaPrecioDeVentaBruto1.Size = new System.Drawing.Size(136, 21);
			this.mzCmbMonedaPrecioDeVentaBruto1.SorterMember = "";
			this.mzCmbMonedaPrecioDeVentaBruto1.TabIndex = 83;
			this.mzCmbMonedaPrecioDeVentaBruto1.ValueMember = "";
			this.mzCmbMonedaPrecioDeVentaBruto1.ValueMemberCaption = "";
			// 
			// mzCmbMonedaPrecioDeVentaBruto
			// 
			this.mzCmbMonedaPrecioDeVentaBruto.AutoComplete = true;
			this.mzCmbMonedaPrecioDeVentaBruto.DataSource = null;
			this.mzCmbMonedaPrecioDeVentaBruto.DisplayMember = "";
			this.mzCmbMonedaPrecioDeVentaBruto.DisplayMemberCaption = "";
			this.mzCmbMonedaPrecioDeVentaBruto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbMonedaPrecioDeVentaBruto.Location = new System.Drawing.Point(366, 96);
			this.mzCmbMonedaPrecioDeVentaBruto.MaxItemsDisplay = 200;
			this.mzCmbMonedaPrecioDeVentaBruto.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbMonedaPrecioDeVentaBruto.Name = "mzCmbMonedaPrecioDeVentaBruto";
			this.mzCmbMonedaPrecioDeVentaBruto.Size = new System.Drawing.Size(136, 21);
			this.mzCmbMonedaPrecioDeVentaBruto.SorterMember = "";
			this.mzCmbMonedaPrecioDeVentaBruto.TabIndex = 82;
			this.mzCmbMonedaPrecioDeVentaBruto.ValueMember = "";
			this.mzCmbMonedaPrecioDeVentaBruto.ValueMemberCaption = "";
			// 
			// mzCmbFuenteDeCambioPrecioDeVentaNeto
			// 
			this.mzCmbFuenteDeCambioPrecioDeVentaNeto.AutoComplete = true;
			this.mzCmbFuenteDeCambioPrecioDeVentaNeto.DataSource = null;
			this.mzCmbFuenteDeCambioPrecioDeVentaNeto.DisplayMember = "";
			this.mzCmbFuenteDeCambioPrecioDeVentaNeto.DisplayMemberCaption = "";
			this.mzCmbFuenteDeCambioPrecioDeVentaNeto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbFuenteDeCambioPrecioDeVentaNeto.Location = new System.Drawing.Point(630, 24);
			this.mzCmbFuenteDeCambioPrecioDeVentaNeto.MaxItemsDisplay = 200;
			this.mzCmbFuenteDeCambioPrecioDeVentaNeto.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbFuenteDeCambioPrecioDeVentaNeto.Name = "mzCmbFuenteDeCambioPrecioDeVentaNeto";
			this.mzCmbFuenteDeCambioPrecioDeVentaNeto.Size = new System.Drawing.Size(136, 21);
			this.mzCmbFuenteDeCambioPrecioDeVentaNeto.SorterMember = "";
			this.mzCmbFuenteDeCambioPrecioDeVentaNeto.TabIndex = 81;
			this.mzCmbFuenteDeCambioPrecioDeVentaNeto.ValueMember = "";
			this.mzCmbFuenteDeCambioPrecioDeVentaNeto.ValueMemberCaption = "";
			// 
			// mzCmbMonedaPrecioDeVentaNeto
			// 
			this.mzCmbMonedaPrecioDeVentaNeto.AutoComplete = true;
			this.mzCmbMonedaPrecioDeVentaNeto.DataSource = null;
			this.mzCmbMonedaPrecioDeVentaNeto.DisplayMember = "";
			this.mzCmbMonedaPrecioDeVentaNeto.DisplayMemberCaption = "";
			this.mzCmbMonedaPrecioDeVentaNeto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbMonedaPrecioDeVentaNeto.Location = new System.Drawing.Point(365, 24);
			this.mzCmbMonedaPrecioDeVentaNeto.MaxItemsDisplay = 200;
			this.mzCmbMonedaPrecioDeVentaNeto.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbMonedaPrecioDeVentaNeto.Name = "mzCmbMonedaPrecioDeVentaNeto";
			this.mzCmbMonedaPrecioDeVentaNeto.Size = new System.Drawing.Size(136, 21);
			this.mzCmbMonedaPrecioDeVentaNeto.SorterMember = "";
			this.mzCmbMonedaPrecioDeVentaNeto.TabIndex = 80;
			this.mzCmbMonedaPrecioDeVentaNeto.ValueMember = "";
			this.mzCmbMonedaPrecioDeVentaNeto.ValueMemberCaption = "";
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Location = new System.Drawing.Point(310, 128);
			this.label21.Name = "label21";
			this.label21.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label21.Size = new System.Drawing.Size(48, 16);
			this.label21.TabIndex = 79;
			this.label21.Text = "Moneda";
			// 
			// ultraNumericEditor7
			// 
			this.ultraNumericEditor7.Location = new System.Drawing.Point(207, 128);
			this.ultraNumericEditor7.Name = "ultraNumericEditor7";
			this.ultraNumericEditor7.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.ultraNumericEditor7.Size = new System.Drawing.Size(88, 21);
			this.ultraNumericEditor7.TabIndex = 78;
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.Transparent;
			this.label22.Location = new System.Drawing.Point(16, 128);
			this.label22.Name = "label22";
			this.label22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label22.Size = new System.Drawing.Size(184, 29);
			this.label22.TabIndex = 77;
			this.label22.Text = "Precio de Lista Impuestos Incluidos";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Location = new System.Drawing.Point(310, 96);
			this.label18.Name = "label18";
			this.label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label18.Size = new System.Drawing.Size(48, 16);
			this.label18.TabIndex = 76;
			this.label18.Text = "Moneda";
			// 
			// ultraNumericEditor6
			// 
			this.ultraNumericEditor6.Location = new System.Drawing.Point(206, 96);
			this.ultraNumericEditor6.Name = "ultraNumericEditor6";
			this.ultraNumericEditor6.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.ultraNumericEditor6.Size = new System.Drawing.Size(88, 21);
			this.ultraNumericEditor6.TabIndex = 75;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Location = new System.Drawing.Point(29, 96);
			this.label14.Name = "label14";
			this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label14.Size = new System.Drawing.Size(173, 16);
			this.label14.TabIndex = 74;
			this.label14.Text = "Precio de Lista sin impuestos";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(300, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(17, 16);
			this.label7.TabIndex = 73;
			this.label7.Text = "%";
			// 
			// unePorcentajeMaximoDescuentoAplicable
			// 
			this.unePorcentajeMaximoDescuentoAplicable.Location = new System.Drawing.Point(206, 48);
			this.unePorcentajeMaximoDescuentoAplicable.Name = "unePorcentajeMaximoDescuentoAplicable";
			this.unePorcentajeMaximoDescuentoAplicable.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.unePorcentajeMaximoDescuentoAplicable.Size = new System.Drawing.Size(88, 21);
			this.unePorcentajeMaximoDescuentoAplicable.TabIndex = 72;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Location = new System.Drawing.Point(28, 48);
			this.label15.Name = "label15";
			this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label15.Size = new System.Drawing.Size(173, 16);
			this.label15.TabIndex = 71;
			this.label15.Text = "Máximo descuento aplicable";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Location = new System.Drawing.Point(502, 48);
			this.label12.Name = "label12";
			this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label12.Size = new System.Drawing.Size(120, 16);
			this.label12.TabIndex = 70;
			this.label12.Text = "Cotización de Cierre";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Location = new System.Drawing.Point(510, 24);
			this.label13.Name = "label13";
			this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label13.Size = new System.Drawing.Size(112, 16);
			this.label13.TabIndex = 69;
			this.label13.Text = "Tipo de Cambio";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(311, 32);
			this.label10.Name = "label10";
			this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label10.Size = new System.Drawing.Size(48, 16);
			this.label10.TabIndex = 68;
			this.label10.Text = "Moneda";
			// 
			// unePrecioDeVentaNeto
			// 
			this.unePrecioDeVentaNeto.Location = new System.Drawing.Point(206, 24);
			this.unePrecioDeVentaNeto.Name = "unePrecioDeVentaNeto";
			this.unePrecioDeVentaNeto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.unePrecioDeVentaNeto.Size = new System.Drawing.Size(88, 21);
			this.unePrecioDeVentaNeto.TabIndex = 67;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Location = new System.Drawing.Point(26, 24);
			this.label11.Name = "label11";
			this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label11.Size = new System.Drawing.Size(173, 16);
			this.label11.TabIndex = 66;
			this.label11.Text = "Precio de Venta sin impuestos";
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 24;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 277;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Datos Generales";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(840, 530);
			this.ultraExplorerBar1.TabIndex = 19;
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
			this.toolBarStandar.Size = new System.Drawing.Size(840, 28);
			this.toolBarStandar.TabIndex = 20;
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
			// FrmAbmProductosPrecios
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(840, 558);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmAbmProductosPrecios";
			this.Text = "FrmAbmProductosPrecios";
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.groupBoxMonedaPrecioDeCosto.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uneValorCotizacionPrecioDeCostoRef)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbMonedaPrecioDeCostoRef1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbMonedaPrecioDeCostoRef)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbFuenteDeCambioPrecioDeCostoRef)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.unePrecioDeVentaNetoMonedaCostoRef)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneMAC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoRef)).EndInit();
			this.groupBoxMonedaPrecioDeVenta.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uneValorCotizacionPrecioDeVentaNeto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbMonedaMaximoDescuento)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneMaximoDescuentoAplicable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbMonedaPrecioDeVentaBruto1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbMonedaPrecioDeVentaBruto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbFuenteDeCambioPrecioDeVentaNeto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbMonedaPrecioDeVentaNeto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.unePorcentajeMaximoDescuentoAplicable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.unePrecioDeVentaNeto)).EndInit();
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
		
		#endregion

		#region Metodos Privados

		private void Build_UI()
		{
			ConfigureInterface();
			InitEventHandlers();
			InitializeData();
			InitDataBindings();
			
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

		private void ConfigureInterface()
		{
			mzCmbMonedaMaximoDescuento.FillFromDataSource(businessrules.tfi_Monedas.GetList().tfi_Monedas, "idMoneda", "Descripcion", 8, "1", "2", "Descripcion");
			mzCmbMonedaPrecioDeCostoRef.FillFromDataSource(businessrules.tfi_Monedas.GetList().tfi_Monedas, "idMoneda", "Descripcion", 8, "1", "2", "Descripcion");
			mzCmbMonedaPrecioDeCostoRef1.FillFromDataSource(businessrules.tfi_Monedas.GetList().tfi_Monedas, "idMoneda", "Descripcion", 8, "1", "2", "Descripcion");
			mzCmbMonedaPrecioDeVentaBruto.FillFromDataSource(businessrules.tfi_Monedas.GetList().tfi_Monedas, "idMoneda", "Descripcion", 8, "1", "2", "Descripcion");
			mzCmbMonedaPrecioDeVentaBruto1.FillFromDataSource(businessrules.tfi_Monedas.GetList().tfi_Monedas, "idMoneda", "Descripcion", 8, "1", "2", "Descripcion");
			mzCmbMonedaPrecioDeVentaNeto.FillFromDataSource(businessrules.tfi_Monedas.GetList().tfi_Monedas, "idMoneda", "Descripcion", 8, "1", "2", "Descripcion");
			mzCmbFuenteDeCambioPrecioDeCostoRef.FillFromDataSource( businessrules.tfi_FuentesDeCambio.GetList().tfi_FuentesDeCambio, "idFuenteDeCambio", "Descripcion", 8, "1", "2", "Descripcion");
			mzCmbFuenteDeCambioPrecioDeVentaNeto.FillFromDataSource( businessrules.tfi_FuentesDeCambio.GetList().tfi_FuentesDeCambio, "idFuenteDeCambio", "Descripcion", 8, "1", "2", "Descripcion");

			mzCmbMonedaMaximoDescuento.ReadOnly = true;
			mzCmbMonedaPrecioDeCostoRef1.ReadOnly = true;
			mzCmbMonedaPrecioDeVentaBruto1.ReadOnly  = true;
			mzCmbMonedaPrecioDeVentaBruto.ReadOnly = true; 
			KeyPreview = true;
		}


		private void InitDataBindings()
		{
			mzCmbFuenteDeCambioPrecioDeCostoRef.DataBindings.Clear();
			mzCmbFuenteDeCambioPrecioDeCostoRef.DataBindings.Add("Value", _uiController, "IdFuenteDeCambioPrecioDeCostoRef");
			mzCmbFuenteDeCambioPrecioDeVentaNeto.DataBindings.Clear();
			mzCmbFuenteDeCambioPrecioDeVentaNeto.DataBindings.Add("Value", _uiController, "IdFuenteDeCambioPrecioDeVentaNeto");
			mzCmbMonedaPrecioDeCostoRef.DataBindings.Clear();
			mzCmbMonedaPrecioDeCostoRef.DataBindings.Add("Value", _uiController, "IdMonedaCierrePrecioDeCostoRef");
			mzCmbMonedaPrecioDeCostoRef1.DataBindings.Clear();
			mzCmbMonedaPrecioDeCostoRef1.DataBindings.Add("Value", _uiController, "IdMonedaCierrePrecioDeCostoRef");
			mzCmbMonedaMaximoDescuento.DataBindings.Clear();
			mzCmbMonedaMaximoDescuento.DataBindings.Add("Value", _uiController, "IdMonedaCierreMaximoDescuento");
			mzCmbMonedaPrecioDeVentaNeto.DataBindings.Clear();
			mzCmbMonedaPrecioDeVentaNeto.DataBindings.Add("Value", _uiController, "IdMonedaCierrePrecioDeVentaNeto");
			mzCmbMonedaPrecioDeVentaBruto.DataBindings.Clear();
			mzCmbMonedaPrecioDeVentaBruto.DataBindings.Add("Value", _uiController, "IdMonedaCierrePrecioDeVentaBruto");
			mzCmbMonedaPrecioDeVentaBruto1.DataBindings.Clear();
			mzCmbMonedaPrecioDeVentaBruto1.DataBindings.Add("Value", _uiController, "IdMonedaCierrePrecioDeVentaBruto");
			uneValorCotizacionPrecioDeCostoRef.DataBindings.Clear();
			uneValorCotizacionPrecioDeCostoRef.DataBindings.Add("Value", _uiController, "ValorCotizacionPrecioDeCostoRef");
			uneValorCotizacionPrecioDeVentaNeto.DataBindings.Clear();
			uneValorCotizacionPrecioDeVentaNeto.DataBindings.Add("Value", _uiController, "ValorCotizacionPrecioDeVentaNeto");

			
		}
		private void RefreshData()
		{
			
		}

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
				case 4:
					CloseForm();
					break;
			}		
		}


		#endregion
	}
}

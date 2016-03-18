using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmABMProductosYJerarquias.
	/// </summary>
	public class FrmABMProductosYJerarquias : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList imglStandar;
		protected System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		protected System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		protected System.Windows.Forms.ToolBarButton tbbCancelar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private mz.erp.ui.controls.mzComboEditor cmbTipo;
		private System.Windows.Forms.CheckBox chActivo;
		private System.Windows.Forms.Label label6;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor ueDescripcion;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor ueCodigoBarras;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor ueCodigo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor ueObservaciones;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox chkObligaNumeroDeSerie;
		private System.Windows.Forms.CheckBox chkObligaCodigoBarras;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.Label labelTarea;
		private mz.erp.ui.controls.HierarchicalSearchControl hierarchicalSearchControl1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor ucePercibeIB;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private System.Windows.Forms.GroupBox groupBox2;
		private mz.erp.ui.controls.mzComboEditor mzCEFuenteDeCambioPrecioDeCosto;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private mz.erp.ui.controls.mzComboEditor mzCEMonedaPrecioDeCosto;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label9;
		private mz.erp.ui.controls.mzComboEditor mzCEMoneda;
		private System.Windows.Forms.Label labelSimboloMonedaPrecioDeListaConImpuestos;
		private System.Windows.Forms.Label label4;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeListaConImpuesto;
		private System.Windows.Forms.Label labelSimboloMonedaPrecioDeLista;
		private System.Windows.Forms.Label labelSimboloMonedaDescuentoMaximo;
		private System.Windows.Forms.Label labelSimboloMonedaPrecioDeVentaNeto;
		private System.Windows.Forms.Label labelSimboloMonedaPrecioDeCostoReferencia;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label13;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioVentaBruto;
		private System.Windows.Forms.Label label12;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneMaxDescuento;
		private System.Windows.Forms.Label label11;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneMaxDescuentoPorcentual;
		private System.Windows.Forms.Label label10;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeVentaNeto;
		private System.Windows.Forms.Label label8;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeCostoRef;
		private System.Windows.Forms.Label label5;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneMAC;
		private System.ComponentModel.IContainer components;

		public FrmABMProductosYJerarquias()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmABMProductosYJerarquias));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.hierarchicalSearchControl1 = new mz.erp.ui.controls.HierarchicalSearchControl();
			this.cmbTipo = new mz.erp.ui.controls.mzComboEditor();
			this.chActivo = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.ueDescripcion = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.ueCodigoBarras = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.ueCodigo = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelSimboloMonedaPrecioDeListaConImpuestos = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.unePrecioDeListaConImpuesto = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.labelSimboloMonedaPrecioDeLista = new System.Windows.Forms.Label();
			this.labelSimboloMonedaDescuentoMaximo = new System.Windows.Forms.Label();
			this.labelSimboloMonedaPrecioDeVentaNeto = new System.Windows.Forms.Label();
			this.labelSimboloMonedaPrecioDeCostoReferencia = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.unePrecioVentaBruto = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label12 = new System.Windows.Forms.Label();
			this.uneMaxDescuento = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label11 = new System.Windows.Forms.Label();
			this.uneMaxDescuentoPorcentual = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label10 = new System.Windows.Forms.Label();
			this.unePrecioDeVentaNeto = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label8 = new System.Windows.Forms.Label();
			this.unePrecioDeCostoRef = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label5 = new System.Windows.Forms.Label();
			this.uneMAC = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.mzCEFuenteDeCambioPrecioDeCosto = new mz.erp.ui.controls.mzComboEditor();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.mzCEMonedaPrecioDeCosto = new mz.erp.ui.controls.mzComboEditor();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.mzCEMoneda = new mz.erp.ui.controls.mzComboEditor();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.ucePercibeIB = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.ueObservaciones = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.label7 = new System.Windows.Forms.Label();
			this.chkObligaNumeroDeSerie = new System.Windows.Forms.CheckBox();
			this.chkObligaCodigoBarras = new System.Windows.Forms.CheckBox();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmbTipo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ueDescripcion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ueCodigoBarras)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ueCodigo)).BeginInit();
			this.ultraExplorerBarContainerControl4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.unePrecioDeListaConImpuesto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.unePrecioVentaBruto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuento)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuentoPorcentual)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.unePrecioDeVentaNeto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoRef)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneMAC)).BeginInit();
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCEFuenteDeCambioPrecioDeCosto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMonedaPrecioDeCosto)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMoneda)).BeginInit();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ueObservaciones)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(886, 24);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(886, 24);
			this.labelTarea.TabIndex = 0;
			this.labelTarea.Text = "Información general de productos";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.hierarchicalSearchControl1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.cmbTipo);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chActivo);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label6);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ueDescripcion);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ueCodigoBarras);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ueCodigo);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 107);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(886, 125);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// hierarchicalSearchControl1
			// 
			this.hierarchicalSearchControl1.BackColor = System.Drawing.Color.Transparent;
			this.hierarchicalSearchControl1.Location = new System.Drawing.Point(11, 80);
			this.hierarchicalSearchControl1.Name = "hierarchicalSearchControl1";
			this.hierarchicalSearchControl1.Size = new System.Drawing.Size(780, 44);
			this.hierarchicalSearchControl1.TabIndex = 14;
			// 
			// cmbTipo
			// 
			this.cmbTipo.AutoComplete = true;
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
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(11, 60);
			this.label3.Name = "label3";
			this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label3.Size = new System.Drawing.Size(128, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Descripción";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// ultraExplorerBarContainerControl4
			// 
			this.ultraExplorerBarContainerControl4.Controls.Add(this.labelSimboloMonedaPrecioDeListaConImpuestos);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.label4);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.unePrecioDeListaConImpuesto);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.labelSimboloMonedaPrecioDeLista);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.labelSimboloMonedaDescuentoMaximo);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.labelSimboloMonedaPrecioDeVentaNeto);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.labelSimboloMonedaPrecioDeCostoReferencia);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.label16);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.label15);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.label13);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.unePrecioVentaBruto);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.label12);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.uneMaxDescuento);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.label11);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.uneMaxDescuentoPorcentual);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.label10);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.unePrecioDeVentaNeto);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.label8);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.unePrecioDeCostoRef);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.label5);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.uneMAC);
			this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, 291);
			this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
			this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(886, 94);
			this.ultraExplorerBarContainerControl4.TabIndex = 3;
			// 
			// labelSimboloMonedaPrecioDeListaConImpuestos
			// 
			this.labelSimboloMonedaPrecioDeListaConImpuestos.BackColor = System.Drawing.Color.Transparent;
			this.labelSimboloMonedaPrecioDeListaConImpuestos.Location = new System.Drawing.Point(584, 64);
			this.labelSimboloMonedaPrecioDeListaConImpuestos.Name = "labelSimboloMonedaPrecioDeListaConImpuestos";
			this.labelSimboloMonedaPrecioDeListaConImpuestos.Size = new System.Drawing.Size(32, 16);
			this.labelSimboloMonedaPrecioDeListaConImpuestos.TabIndex = 107;
			this.labelSimboloMonedaPrecioDeListaConImpuestos.Text = "$";
			this.labelSimboloMonedaPrecioDeListaConImpuestos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(392, 68);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(223, 21);
			this.label4.TabIndex = 106;
			this.label4.Text = "Precio de Venta Bruto Con Impuestos";
			// 
			// unePrecioDeListaConImpuesto
			// 
			this.unePrecioDeListaConImpuesto.Location = new System.Drawing.Point(616, 68);
			this.unePrecioDeListaConImpuesto.MaskInput = "nnnnnnnnn.nn";
			this.unePrecioDeListaConImpuesto.Name = "unePrecioDeListaConImpuesto";
			this.unePrecioDeListaConImpuesto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.unePrecioDeListaConImpuesto.Size = new System.Drawing.Size(100, 21);
			this.unePrecioDeListaConImpuesto.TabIndex = 105;
			this.unePrecioDeListaConImpuesto.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// labelSimboloMonedaPrecioDeLista
			// 
			this.labelSimboloMonedaPrecioDeLista.BackColor = System.Drawing.Color.Transparent;
			this.labelSimboloMonedaPrecioDeLista.Location = new System.Drawing.Point(584, 48);
			this.labelSimboloMonedaPrecioDeLista.Name = "labelSimboloMonedaPrecioDeLista";
			this.labelSimboloMonedaPrecioDeLista.Size = new System.Drawing.Size(32, 16);
			this.labelSimboloMonedaPrecioDeLista.TabIndex = 104;
			this.labelSimboloMonedaPrecioDeLista.Text = "$";
			this.labelSimboloMonedaPrecioDeLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelSimboloMonedaDescuentoMaximo
			// 
			this.labelSimboloMonedaDescuentoMaximo.BackColor = System.Drawing.Color.Transparent;
			this.labelSimboloMonedaDescuentoMaximo.Location = new System.Drawing.Point(584, 24);
			this.labelSimboloMonedaDescuentoMaximo.Name = "labelSimboloMonedaDescuentoMaximo";
			this.labelSimboloMonedaDescuentoMaximo.Size = new System.Drawing.Size(32, 16);
			this.labelSimboloMonedaDescuentoMaximo.TabIndex = 103;
			this.labelSimboloMonedaDescuentoMaximo.Text = "$";
			this.labelSimboloMonedaDescuentoMaximo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelSimboloMonedaPrecioDeVentaNeto
			// 
			this.labelSimboloMonedaPrecioDeVentaNeto.BackColor = System.Drawing.Color.Transparent;
			this.labelSimboloMonedaPrecioDeVentaNeto.Location = new System.Drawing.Point(192, 48);
			this.labelSimboloMonedaPrecioDeVentaNeto.Name = "labelSimboloMonedaPrecioDeVentaNeto";
			this.labelSimboloMonedaPrecioDeVentaNeto.Size = new System.Drawing.Size(32, 16);
			this.labelSimboloMonedaPrecioDeVentaNeto.TabIndex = 102;
			this.labelSimboloMonedaPrecioDeVentaNeto.Text = "$";
			this.labelSimboloMonedaPrecioDeVentaNeto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelSimboloMonedaPrecioDeCostoReferencia
			// 
			this.labelSimboloMonedaPrecioDeCostoReferencia.BackColor = System.Drawing.Color.Transparent;
			this.labelSimboloMonedaPrecioDeCostoReferencia.Location = new System.Drawing.Point(192, 8);
			this.labelSimboloMonedaPrecioDeCostoReferencia.Name = "labelSimboloMonedaPrecioDeCostoReferencia";
			this.labelSimboloMonedaPrecioDeCostoReferencia.Size = new System.Drawing.Size(32, 16);
			this.labelSimboloMonedaPrecioDeCostoReferencia.TabIndex = 101;
			this.labelSimboloMonedaPrecioDeCostoReferencia.Text = "$";
			this.labelSimboloMonedaPrecioDeCostoReferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Location = new System.Drawing.Point(720, 16);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(32, 16);
			this.label16.TabIndex = 100;
			this.label16.Text = "%";
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Location = new System.Drawing.Point(328, 32);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(16, 16);
			this.label15.TabIndex = 99;
			this.label15.Text = "%";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Location = new System.Drawing.Point(392, 48);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(223, 21);
			this.label13.TabIndex = 98;
			this.label13.Text = "Precio de Venta Bruto (Precio de Lista)";
			// 
			// unePrecioVentaBruto
			// 
			this.unePrecioVentaBruto.Location = new System.Drawing.Point(616, 48);
			this.unePrecioVentaBruto.MaskInput = "nnnnnnnnn.nn";
			this.unePrecioVentaBruto.Name = "unePrecioVentaBruto";
			this.unePrecioVentaBruto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.unePrecioVentaBruto.Size = new System.Drawing.Size(100, 21);
			this.unePrecioVentaBruto.TabIndex = 92;
			this.unePrecioVentaBruto.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Location = new System.Drawing.Point(392, 29);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(223, 21);
			this.label12.TabIndex = 97;
			this.label12.Text = "Descuento Máximo s/Precio de Lista";
			// 
			// uneMaxDescuento
			// 
			this.uneMaxDescuento.Location = new System.Drawing.Point(616, 29);
			this.uneMaxDescuento.MaskInput = "nnnnnnnnn.nn";
			this.uneMaxDescuento.Name = "uneMaxDescuento";
			this.uneMaxDescuento.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneMaxDescuento.Size = new System.Drawing.Size(100, 21);
			this.uneMaxDescuento.TabIndex = 91;
			this.uneMaxDescuento.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Location = new System.Drawing.Point(392, 8);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(223, 21);
			this.label11.TabIndex = 96;
			this.label11.Text = "Descuento Porcentual s/Precio de Lista";
			// 
			// uneMaxDescuentoPorcentual
			// 
			this.uneMaxDescuentoPorcentual.Location = new System.Drawing.Point(616, 8);
			this.uneMaxDescuentoPorcentual.Name = "uneMaxDescuentoPorcentual";
			this.uneMaxDescuentoPorcentual.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneMaxDescuentoPorcentual.Size = new System.Drawing.Size(100, 21);
			this.uneMaxDescuentoPorcentual.TabIndex = 90;
			this.uneMaxDescuentoPorcentual.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(0, 48);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(223, 21);
			this.label10.TabIndex = 95;
			this.label10.Text = "Precio de Venta Neto";
			// 
			// unePrecioDeVentaNeto
			// 
			this.unePrecioDeVentaNeto.Location = new System.Drawing.Point(224, 48);
			this.unePrecioDeVentaNeto.MaskInput = "nnnnnnnnn.nn";
			this.unePrecioDeVentaNeto.Name = "unePrecioDeVentaNeto";
			this.unePrecioDeVentaNeto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.unePrecioDeVentaNeto.Size = new System.Drawing.Size(100, 21);
			this.unePrecioDeVentaNeto.TabIndex = 89;
			this.unePrecioDeVentaNeto.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(0, 8);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(223, 21);
			this.label8.TabIndex = 94;
			this.label8.Text = "Precio de Costo Referencia";
			// 
			// unePrecioDeCostoRef
			// 
			this.unePrecioDeCostoRef.Location = new System.Drawing.Point(224, 8);
			this.unePrecioDeCostoRef.MaskInput = "nnnnnnnnn.nn";
			this.unePrecioDeCostoRef.Name = "unePrecioDeCostoRef";
			this.unePrecioDeCostoRef.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.unePrecioDeCostoRef.Size = new System.Drawing.Size(100, 21);
			this.unePrecioDeCostoRef.TabIndex = 87;
			this.unePrecioDeCostoRef.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(0, 29);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(223, 21);
			this.label5.TabIndex = 93;
			this.label5.Text = "Margen/Precio Costo Neto";
			// 
			// uneMAC
			// 
			this.uneMAC.Location = new System.Drawing.Point(224, 29);
			this.uneMAC.Name = "uneMAC";
			this.uneMAC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneMAC.Size = new System.Drawing.Size(100, 21);
			this.uneMAC.TabIndex = 88;
			this.uneMAC.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Controls.Add(this.groupBox2);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.groupBox1);
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 187);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(886, 150);
			this.ultraExplorerBarContainerControl5.TabIndex = 4;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.mzCEFuenteDeCambioPrecioDeCosto);
			this.groupBox2.Controls.Add(this.label18);
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.mzCEMonedaPrecioDeCosto);
			this.groupBox2.Location = new System.Drawing.Point(0, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(176, 112);
			this.groupBox2.TabIndex = 37;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Precio de Costo";
			// 
			// mzCEFuenteDeCambioPrecioDeCosto
			// 
			this.mzCEFuenteDeCambioPrecioDeCosto.AutoComplete = true;
			this.mzCEFuenteDeCambioPrecioDeCosto.DataSource = null;
			this.mzCEFuenteDeCambioPrecioDeCosto.DisplayMember = "";
			this.mzCEFuenteDeCambioPrecioDeCosto.DisplayMemberCaption = "";
			this.mzCEFuenteDeCambioPrecioDeCosto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEFuenteDeCambioPrecioDeCosto.Location = new System.Drawing.Point(16, 80);
			this.mzCEFuenteDeCambioPrecioDeCosto.MaxItemsDisplay = 200;
			this.mzCEFuenteDeCambioPrecioDeCosto.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEFuenteDeCambioPrecioDeCosto.Name = "mzCEFuenteDeCambioPrecioDeCosto";
			this.mzCEFuenteDeCambioPrecioDeCosto.Size = new System.Drawing.Size(128, 21);
			this.mzCEFuenteDeCambioPrecioDeCosto.SorterMember = "";
			this.mzCEFuenteDeCambioPrecioDeCosto.TabIndex = 35;
			this.mzCEFuenteDeCambioPrecioDeCosto.ValueMember = "";
			this.mzCEFuenteDeCambioPrecioDeCosto.ValueMemberCaption = "";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Location = new System.Drawing.Point(16, 64);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(223, 16);
			this.label18.TabIndex = 34;
			this.label18.Text = "Fuente de Cambio";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Location = new System.Drawing.Point(16, 24);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(223, 16);
			this.label17.TabIndex = 33;
			this.label17.Text = "Moneda ";
			// 
			// mzCEMonedaPrecioDeCosto
			// 
			this.mzCEMonedaPrecioDeCosto.AutoComplete = true;
			this.mzCEMonedaPrecioDeCosto.DataSource = null;
			this.mzCEMonedaPrecioDeCosto.DisplayMember = "";
			this.mzCEMonedaPrecioDeCosto.DisplayMemberCaption = "";
			this.mzCEMonedaPrecioDeCosto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEMonedaPrecioDeCosto.Location = new System.Drawing.Point(16, 40);
			this.mzCEMonedaPrecioDeCosto.MaxItemsDisplay = 200;
			this.mzCEMonedaPrecioDeCosto.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEMonedaPrecioDeCosto.Name = "mzCEMonedaPrecioDeCosto";
			this.mzCEMonedaPrecioDeCosto.Size = new System.Drawing.Size(128, 21);
			this.mzCEMonedaPrecioDeCosto.SorterMember = "";
			this.mzCEMonedaPrecioDeCosto.TabIndex = 32;
			this.mzCEMonedaPrecioDeCosto.ValueMember = "";
			this.mzCEMonedaPrecioDeCosto.ValueMemberCaption = "";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.mzCEMoneda);
			this.groupBox1.Location = new System.Drawing.Point(176, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(160, 72);
			this.groupBox1.TabIndex = 36;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Precio De Venta";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(16, 24);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(223, 16);
			this.label9.TabIndex = 27;
			this.label9.Text = "Moneda";
			// 
			// mzCEMoneda
			// 
			this.mzCEMoneda.AutoComplete = true;
			this.mzCEMoneda.DataSource = null;
			this.mzCEMoneda.DisplayMember = "";
			this.mzCEMoneda.DisplayMemberCaption = "";
			this.mzCEMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEMoneda.Location = new System.Drawing.Point(16, 40);
			this.mzCEMoneda.MaxItemsDisplay = 200;
			this.mzCEMoneda.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEMoneda.Name = "mzCEMoneda";
			this.mzCEMoneda.Size = new System.Drawing.Size(128, 21);
			this.mzCEMoneda.SorterMember = "";
			this.mzCEMoneda.TabIndex = 26;
			this.mzCEMoneda.ValueMember = "";
			this.mzCEMoneda.ValueMemberCaption = "";
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.ucePercibeIB);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.ueObservaciones);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label7);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.chkObligaNumeroDeSerie);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.chkObligaCodigoBarras);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 193);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(886, 176);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// ucePercibeIB
			// 
			this.ucePercibeIB.BackColor = System.Drawing.Color.Transparent;
			this.ucePercibeIB.Enabled = false;
			this.ucePercibeIB.Location = new System.Drawing.Point(168, 104);
			this.ucePercibeIB.Name = "ucePercibeIB";
			this.ucePercibeIB.Size = new System.Drawing.Size(152, 20);
			this.ucePercibeIB.TabIndex = 77;
			this.ucePercibeIB.Text = "Percibe Ing. Brutos";
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
			this.toolBarStandar.Size = new System.Drawing.Size(952, 28);
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
			this.tbbCancelar.Text = "&Cancelar";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 24;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 125;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Datos Generales";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl4;
			ultraExplorerBarGroup3.Settings.ContainerHeight = 94;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Precios";
			ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl5;
			ultraExplorerBarGroup4.Expanded = false;
			ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup4.Text = "Monedas";
			ultraExplorerBarGroup5.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup5.Expanded = false;
			ultraExplorerBarGroup5.Settings.ContainerHeight = 176;
			ultraExplorerBarGroup5.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup5.Text = "Datos Adicionales";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3,
																														ultraExplorerBarGroup4,
																														ultraExplorerBarGroup5});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1";
			this.ultraExplorerBar1.Size = new System.Drawing.Size(952, 394);
			this.ultraExplorerBar1.TabIndex = 20;
			// 
			// FrmABMProductosYJerarquias
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(952, 422);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmABMProductosYJerarquias";
			this.Text = "FrmABMProductosYJerarquias";
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmbTipo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ueDescripcion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ueCodigoBarras)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ueCodigo)).EndInit();
			this.ultraExplorerBarContainerControl4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.unePrecioDeListaConImpuesto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.unePrecioVentaBruto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuento)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuentoPorcentual)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.unePrecioDeVentaNeto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoRef)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneMAC)).EndInit();
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCEFuenteDeCambioPrecioDeCosto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMonedaPrecioDeCosto)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCEMoneda)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ueObservaciones)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
	}
}

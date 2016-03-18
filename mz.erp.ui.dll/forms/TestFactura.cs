using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.businessrules.comprobantes;
using mz.erp.businessrules;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de TestFactura.
	/// </summary>
	public class TestFactura : System.Windows.Forms.Form
	{

		private ComprobanteDeVenta miComprobante;
//		private InterfaceFiscal fiscal;
//		private FrmEstados frmEst;		

		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.ToolBarButton toolBarButton8;
		private System.Windows.Forms.ToolBarButton tbStep3;
		private System.Windows.Forms.ToolBarButton tbDelete;
		private System.Windows.Forms.ImageList imglStandar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Infragistics.Win.Misc.UltraLabel ultraLabel2;
		private Infragistics.Win.Misc.UltraLabel ultraLabel5;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor ultraNumericEditor1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel3;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel6;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private Infragistics.Win.Misc.UltraButton ultraButton4;
		private Infragistics.Win.Misc.UltraButton ultraButton5;
		private Janus.Windows.GridEX.GridEX gridEX2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private mz.erp.ui.controls.mzComboEditor mzCmbTipoComprobante;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbResponsableEmision;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbCuenta;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbCondicionDeVenta;
		private Infragistics.Win.Misc.UltraButton bDetallesProducto;
		private Infragistics.Win.Misc.UltraButton bAgregarProducto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalNeto;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalImpuestos;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotal;
		private Janus.Windows.GridEX.GridEX gridProductos;
		private Janus.Windows.GridEX.GridEX gridResumenImpuestos;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalBruto;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalDescuentos;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneRecargosFinancieros;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private System.Windows.Forms.Label label8;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo cldFechaComprobante;
		private Janus.Windows.GridEX.GridEX gridVariablesUsuario;
		private System.Windows.Forms.Label label9;
		private Janus.Windows.GridEX.GridEX gridDetalleCondicionDeVenta;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor ultraNumericEditor2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private mz.erp.ui.controls.mzProductosControl mzProductosControl1;
		private mz.erp.ui.controls.mzCuentasControl mzCuentasControl1;
		private mz.erp.ui.controls.mzCuentasControl mzCuentasControl2;
		private System.ComponentModel.IContainer components;




		public TestFactura()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
			InitializeCustomComponents();
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
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TestFactura));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.mzCuentasControl2 = new mz.erp.ui.controls.mzCuentasControl();
			this.mzProductosControl1 = new mz.erp.ui.controls.mzProductosControl();
			this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
			this.mzCmbCondicionDeVenta = new mz.erp.ui.controls.mzComboSearchEditor();
			this.mzCmbResponsableEmision = new mz.erp.ui.controls.mzComboSearchEditor();
			this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraNumericEditor1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
			this.mzCmbTipoComprobante = new mz.erp.ui.controls.mzComboEditor();
			this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
			this.cldFechaComprobante = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.mzCmbCuenta = new mz.erp.ui.controls.mzComboSearchEditor();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.mzCuentasControl1 = new mz.erp.ui.controls.mzCuentasControl();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.ultraNumericEditor2 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label10 = new System.Windows.Forms.Label();
			this.gridProductos = new Janus.Windows.GridEX.GridEX();
			this.bDetallesProducto = new Infragistics.Win.Misc.UltraButton();
			this.bAgregarProducto = new Infragistics.Win.Misc.UltraButton();
			this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.uneRecargosFinancieros = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label7 = new System.Windows.Forms.Label();
			this.uneTotalDescuentos = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label6 = new System.Windows.Forms.Label();
			this.uneTotalBruto = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label5 = new System.Windows.Forms.Label();
			this.gridResumenImpuestos = new Janus.Windows.GridEX.GridEX();
			this.uneTotal = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.uneTotalImpuestos = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.uneTotalNeto = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridDetalleCondicionDeVenta = new Janus.Windows.GridEX.GridEX();
			this.label9 = new System.Windows.Forms.Label();
			this.gridVariablesUsuario = new Janus.Windows.GridEX.GridEX();
			this.label8 = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.ultraButton4 = new Infragistics.Win.Misc.UltraButton();
			this.ultraButton5 = new Infragistics.Win.Misc.UltraButton();
			this.gridEX2 = new Janus.Windows.GridEX.GridEX();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton8 = new System.Windows.Forms.ToolBarButton();
			this.tbStep3 = new System.Windows.Forms.ToolBarButton();
			this.tbDelete = new System.Windows.Forms.ToolBarButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTipoComprobante)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cldFechaComprobante)).BeginInit();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
			this.ultraExplorerBarContainerControl4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uneRecargosFinancieros)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalDescuentos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalBruto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridResumenImpuestos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalImpuestos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalNeto)).BeginInit();
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDetalleCondicionDeVenta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridVariablesUsuario)).BeginInit();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridEX2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCuentasControl2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzProductosControl1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel4);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbCondicionDeVenta);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbResponsableEmision);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel6);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraNumericEditor1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel5);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbTipoComprobante);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.cldFechaComprobante);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbCuenta);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, -115);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(846, 120);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// mzCuentasControl2
			// 
			this.mzCuentasControl2.AllowEditClientePaso = false;
			this.mzCuentasControl2.BackColor = System.Drawing.SystemColors.Control;
			this.mzCuentasControl2.DataValue = "";
			this.mzCuentasControl2.EnableCtaCte = false;
			this.mzCuentasControl2.FastSearch = false;
			this.mzCuentasControl2.Location = new System.Drawing.Point(616, 8);
			this.mzCuentasControl2.Name = "mzCuentasControl2";
			this.mzCuentasControl2.SearchObjectListener = null;
			this.mzCuentasControl2.Size = new System.Drawing.Size(168, 32);
			this.mzCuentasControl2.TabIndex = 20;
			// 
			// mzProductosControl1
			// 
			this.mzProductosControl1.BackColor = System.Drawing.Color.Transparent;
			this.mzProductosControl1.EnabledCantidad = false;
			this.mzProductosControl1.EnabledListaDePrecio = true;
			this.mzProductosControl1.Location = new System.Drawing.Point(616, 48);
			this.mzProductosControl1.Name = "mzProductosControl1";
			this.mzProductosControl1.Size = new System.Drawing.Size(200, 40);
			this.mzProductosControl1.TabIndex = 6;
			this.mzProductosControl1.VisibleCantidad = true;
			this.mzProductosControl1.VisibleComboListaDePrecios = true;
			this.mzProductosControl1.VisibleComboTipoDePrecioDeCosto = false;
			this.mzProductosControl1.VisiblePrecios = true;
			// 
			// ultraLabel4
			// 
			this.ultraLabel4.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel4.Location = new System.Drawing.Point(0, 95);
			this.ultraLabel4.Name = "ultraLabel4";
			this.ultraLabel4.Size = new System.Drawing.Size(104, 16);
			this.ultraLabel4.TabIndex = 18;
			this.ultraLabel4.Text = "Condición de Venta";
			// 
			// mzCmbCondicionDeVenta
			// 
			this.mzCmbCondicionDeVenta.DataValue = "";
			this.mzCmbCondicionDeVenta.EditObject = null;
			this.mzCmbCondicionDeVenta.FastSearch = false;
			this.mzCmbCondicionDeVenta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbCondicionDeVenta.HierarchicalSearch = false;
			this.mzCmbCondicionDeVenta.Location = new System.Drawing.Point(120, 92);
			this.mzCmbCondicionDeVenta.Name = "mzCmbCondicionDeVenta";
			this.mzCmbCondicionDeVenta.ReadOnly = false;
			this.mzCmbCondicionDeVenta.SearchObject = null;
			this.mzCmbCondicionDeVenta.SearchObjectListener = null;
			this.mzCmbCondicionDeVenta.Size = new System.Drawing.Size(456, 22);
			this.mzCmbCondicionDeVenta.TabIndex = 5;
			// 
			// mzCmbResponsableEmision
			// 
			this.mzCmbResponsableEmision.DataValue = "";
			this.mzCmbResponsableEmision.EditObject = null;
			this.mzCmbResponsableEmision.FastSearch = false;
			this.mzCmbResponsableEmision.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbResponsableEmision.HierarchicalSearch = false;
			this.mzCmbResponsableEmision.Location = new System.Drawing.Point(120, 44);
			this.mzCmbResponsableEmision.Name = "mzCmbResponsableEmision";
			this.mzCmbResponsableEmision.ReadOnly = false;
			this.mzCmbResponsableEmision.SearchObject = null;
			this.mzCmbResponsableEmision.SearchObjectListener = null;
			this.mzCmbResponsableEmision.Size = new System.Drawing.Size(456, 22);
			this.mzCmbResponsableEmision.TabIndex = 3;
			// 
			// ultraLabel6
			// 
			this.ultraLabel6.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel6.Location = new System.Drawing.Point(0, 48);
			this.ultraLabel6.Name = "ultraLabel6";
			this.ultraLabel6.Size = new System.Drawing.Size(120, 16);
			this.ultraLabel6.TabIndex = 15;
			this.ultraLabel6.Text = "Responsable Emisión";
			// 
			// ultraLabel1
			// 
			this.ultraLabel1.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel1.Location = new System.Drawing.Point(0, 70);
			this.ultraLabel1.Name = "ultraLabel1";
			this.ultraLabel1.Size = new System.Drawing.Size(62, 16);
			this.ultraLabel1.TabIndex = 13;
			this.ultraLabel1.Text = "Cuenta";
			// 
			// ultraLabel3
			// 
			this.ultraLabel3.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel3.Location = new System.Drawing.Point(0, 1);
			this.ultraLabel3.Name = "ultraLabel3";
			this.ultraLabel3.Size = new System.Drawing.Size(62, 16);
			this.ultraLabel3.TabIndex = 12;
			this.ultraLabel3.Text = "Fecha";
			// 
			// ultraNumericEditor1
			// 
			this.ultraNumericEditor1.Location = new System.Drawing.Point(120, 22);
			this.ultraNumericEditor1.Name = "ultraNumericEditor1";
			this.ultraNumericEditor1.Size = new System.Drawing.Size(100, 21);
			this.ultraNumericEditor1.TabIndex = 2;
			// 
			// ultraLabel5
			// 
			this.ultraLabel5.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel5.Location = new System.Drawing.Point(0, 24);
			this.ultraLabel5.Name = "ultraLabel5";
			this.ultraLabel5.Size = new System.Drawing.Size(62, 16);
			this.ultraLabel5.TabIndex = 10;
			this.ultraLabel5.Text = "Número";
			// 
			// mzCmbTipoComprobante
			// 
			this.mzCmbTipoComprobante.AutoComplete = true;
			this.mzCmbTipoComprobante.DataSource = null;
			this.mzCmbTipoComprobante.DisplayMember = "";
			this.mzCmbTipoComprobante.DisplayMemberCaption = "";
			this.mzCmbTipoComprobante.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbTipoComprobante.Location = new System.Drawing.Point(409, 0);
			this.mzCmbTipoComprobante.MaxItemsDisplay = 7;
			this.mzCmbTipoComprobante.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbTipoComprobante.Name = "mzCmbTipoComprobante";
			this.mzCmbTipoComprobante.Size = new System.Drawing.Size(167, 21);
			this.mzCmbTipoComprobante.SorterMember = "";
			this.mzCmbTipoComprobante.TabIndex = 1;
			this.mzCmbTipoComprobante.ValueMember = "";
			this.mzCmbTipoComprobante.ValueMemberCaption = "";
			this.mzCmbTipoComprobante.ValueChanged += new System.EventHandler(this.mzCmbTipoComprobante_ValueChanged);
			// 
			// ultraLabel2
			// 
			this.ultraLabel2.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel2.Location = new System.Drawing.Point(282, 2);
			this.ultraLabel2.Name = "ultraLabel2";
			this.ultraLabel2.Size = new System.Drawing.Size(120, 16);
			this.ultraLabel2.TabIndex = 8;
			this.ultraLabel2.Text = "Tipo de Comprobante";
			// 
			// cldFechaComprobante
			// 
			dateButton1.Caption = "Today";
			this.cldFechaComprobante.DateButtons.Add(dateButton1);
			this.cldFechaComprobante.Location = new System.Drawing.Point(120, 0);
			this.cldFechaComprobante.Name = "cldFechaComprobante";
			this.cldFechaComprobante.NonAutoSizeHeight = 23;
			this.cldFechaComprobante.Size = new System.Drawing.Size(109, 21);
			this.cldFechaComprobante.TabIndex = 0;
			this.cldFechaComprobante.Value = new System.DateTime(2005, 1, 28, 0, 0, 0, 0);
			// 
			// mzCmbCuenta
			// 
			this.mzCmbCuenta.DataValue = "";
			this.mzCmbCuenta.EditObject = null;
			this.mzCmbCuenta.FastSearch = false;
			this.mzCmbCuenta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbCuenta.HierarchicalSearch = false;
			this.mzCmbCuenta.Location = new System.Drawing.Point(120, 68);
			this.mzCmbCuenta.Name = "mzCmbCuenta";
			this.mzCmbCuenta.ReadOnly = false;
			this.mzCmbCuenta.SearchObject = null;
			this.mzCmbCuenta.SearchObjectListener = null;
			this.mzCmbCuenta.Size = new System.Drawing.Size(456, 22);
			this.mzCmbCuenta.TabIndex = 4;
			this.mzCmbCuenta.ValueChanged += new System.EventHandler(this.mzCmbCuenta_ValueChanged);
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.mzCuentasControl1);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.richTextBox1);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.ultraNumericEditor2);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label10);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridProductos);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.bDetallesProducto);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.bAgregarProducto);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, -188);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(846, 181);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// mzCuentasControl1
			// 
			this.mzCuentasControl1.AllowEditClientePaso = false;
			this.mzCuentasControl1.BackColor = System.Drawing.SystemColors.Control;
			this.mzCuentasControl1.DataValue = "";
			this.mzCuentasControl1.EnableCtaCte = false;
			this.mzCuentasControl1.FastSearch = false;
			this.mzCuentasControl1.Location = new System.Drawing.Point(592, 16);
			this.mzCuentasControl1.Name = "mzCuentasControl1";
			this.mzCuentasControl1.SearchObjectListener = null;
			this.mzCuentasControl1.Size = new System.Drawing.Size(208, 32);
			this.mzCuentasControl1.TabIndex = 2;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(632, 56);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(160, 72);
			this.richTextBox1.TabIndex = 4;
			this.richTextBox1.Text = "richTextBox1";
			// 
			// ultraNumericEditor2
			// 
			this.ultraNumericEditor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ultraNumericEditor2.Location = new System.Drawing.Point(478, 156);
			this.ultraNumericEditor2.Name = "ultraNumericEditor2";
			this.ultraNumericEditor2.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.ultraNumericEditor2.PromptChar = ' ';
			this.ultraNumericEditor2.ReadOnly = true;
			this.ultraNumericEditor2.Size = new System.Drawing.Size(100, 24);
			this.ultraNumericEditor2.TabIndex = 5;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(339, 159);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(128, 16);
			this.label10.TabIndex = 10;
			this.label10.Text = "Total";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// gridProductos
			// 
			this.gridProductos.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridProductos.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridProductos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gridProductos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridProductos.Location = new System.Drawing.Point(3, 30);
			this.gridProductos.Name = "gridProductos";
			this.gridProductos.Size = new System.Drawing.Size(573, 120);
			this.gridProductos.TabIndex = 3;
			// 
			// bDetallesProducto
			// 
			this.bDetallesProducto.Location = new System.Drawing.Point(92, 1);
			this.bDetallesProducto.Name = "bDetallesProducto";
			this.bDetallesProducto.Size = new System.Drawing.Size(88, 24);
			this.bDetallesProducto.TabIndex = 1;
			this.bDetallesProducto.Text = "Detalles";
			// 
			// bAgregarProducto
			// 
			this.bAgregarProducto.Location = new System.Drawing.Point(1, 1);
			this.bAgregarProducto.Name = "bAgregarProducto";
			this.bAgregarProducto.Size = new System.Drawing.Size(88, 24);
			this.bAgregarProducto.TabIndex = 0;
			this.bAgregarProducto.Text = "Agregar";
			this.bAgregarProducto.Click += new System.EventHandler(this.BotoneraProductos);
			// 
			// ultraExplorerBarContainerControl4
			// 
			this.ultraExplorerBarContainerControl4.Controls.Add(this.uneRecargosFinancieros);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.label7);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.uneTotalDescuentos);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.label6);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.uneTotalBruto);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.label5);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.gridResumenImpuestos);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.uneTotal);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.uneTotalImpuestos);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.uneTotalNeto);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.label4);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, -134);
			this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
			this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(846, 174);
			this.ultraExplorerBarContainerControl4.TabIndex = 3;
			// 
			// uneRecargosFinancieros
			// 
			this.uneRecargosFinancieros.Location = new System.Drawing.Point(478, 46);
			this.uneRecargosFinancieros.Name = "uneRecargosFinancieros";
			this.uneRecargosFinancieros.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneRecargosFinancieros.PromptChar = ' ';
			this.uneRecargosFinancieros.ReadOnly = true;
			this.uneRecargosFinancieros.Size = new System.Drawing.Size(100, 21);
			this.uneRecargosFinancieros.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(336, 49);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(144, 16);
			this.label7.TabIndex = 15;
			this.label7.Text = "Bonificaciones/Rec Financ.";
			// 
			// uneTotalDescuentos
			// 
			this.uneTotalDescuentos.Location = new System.Drawing.Point(478, 24);
			this.uneTotalDescuentos.Name = "uneTotalDescuentos";
			this.uneTotalDescuentos.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotalDescuentos.PromptChar = ' ';
			this.uneTotalDescuentos.ReadOnly = true;
			this.uneTotalDescuentos.Size = new System.Drawing.Size(100, 21);
			this.uneTotalDescuentos.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(336, 25);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(136, 16);
			this.label6.TabIndex = 13;
			this.label6.Text = "Descuentos Aplicados";
			// 
			// uneTotalBruto
			// 
			this.uneTotalBruto.Location = new System.Drawing.Point(478, 2);
			this.uneTotalBruto.Name = "uneTotalBruto";
			this.uneTotalBruto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotalBruto.PromptChar = ' ';
			this.uneTotalBruto.ReadOnly = true;
			this.uneTotalBruto.Size = new System.Drawing.Size(100, 21);
			this.uneTotalBruto.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(336, 6);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(136, 16);
			this.label5.TabIndex = 11;
			this.label5.Text = "Total Bruto";
			// 
			// gridResumenImpuestos
			// 
			this.gridResumenImpuestos.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridResumenImpuestos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridResumenImpuestos.Location = new System.Drawing.Point(2, 16);
			this.gridResumenImpuestos.Name = "gridResumenImpuestos";
			this.gridResumenImpuestos.Size = new System.Drawing.Size(326, 120);
			this.gridResumenImpuestos.TabIndex = 0;
			// 
			// uneTotal
			// 
			this.uneTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.uneTotal.Location = new System.Drawing.Point(478, 112);
			this.uneTotal.Name = "uneTotal";
			this.uneTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotal.PromptChar = ' ';
			this.uneTotal.ReadOnly = true;
			this.uneTotal.Size = new System.Drawing.Size(100, 24);
			this.uneTotal.TabIndex = 6;
			// 
			// uneTotalImpuestos
			// 
			this.uneTotalImpuestos.Location = new System.Drawing.Point(478, 90);
			this.uneTotalImpuestos.Name = "uneTotalImpuestos";
			this.uneTotalImpuestos.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotalImpuestos.PromptChar = ' ';
			this.uneTotalImpuestos.ReadOnly = true;
			this.uneTotalImpuestos.Size = new System.Drawing.Size(100, 21);
			this.uneTotalImpuestos.TabIndex = 5;
			// 
			// uneTotalNeto
			// 
			this.uneTotalNeto.Location = new System.Drawing.Point(478, 68);
			this.uneTotalNeto.Name = "uneTotalNeto";
			this.uneTotalNeto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotalNeto.PromptChar = ' ';
			this.uneTotalNeto.ReadOnly = true;
			this.uneTotalNeto.Size = new System.Drawing.Size(100, 21);
			this.uneTotalNeto.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(336, 116);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "Total";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(336, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Impuestos";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(336, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(136, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Total Neto";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Impuestos";
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Controls.Add(this.gridDetalleCondicionDeVenta);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.label9);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.gridVariablesUsuario);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.label8);
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 99);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(846, 144);
			this.ultraExplorerBarContainerControl5.TabIndex = 4;
			// 
			// gridDetalleCondicionDeVenta
			// 
			this.gridDetalleCondicionDeVenta.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridDetalleCondicionDeVenta.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridDetalleCondicionDeVenta.Location = new System.Drawing.Point(9, 24);
			this.gridDetalleCondicionDeVenta.Name = "gridDetalleCondicionDeVenta";
			this.gridDetalleCondicionDeVenta.Size = new System.Drawing.Size(208, 104);
			this.gridDetalleCondicionDeVenta.TabIndex = 0;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(232, 7);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 16);
			this.label9.TabIndex = 21;
			this.label9.Text = "Otros datos";
			// 
			// gridVariablesUsuario
			// 
			this.gridVariablesUsuario.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridVariablesUsuario.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridVariablesUsuario.Location = new System.Drawing.Point(234, 26);
			this.gridVariablesUsuario.Name = "gridVariablesUsuario";
			this.gridVariablesUsuario.Size = new System.Drawing.Size(416, 102);
			this.gridVariablesUsuario.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(10, 7);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 16);
			this.label8.TabIndex = 1;
			this.label8.Text = "Vencimientos";
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.ultraButton4);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.ultraButton5);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.gridEX2);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 302);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(846, 146);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// ultraButton4
			// 
			this.ultraButton4.Location = new System.Drawing.Point(112, 4);
			this.ultraButton4.Name = "ultraButton4";
			this.ultraButton4.Size = new System.Drawing.Size(88, 24);
			this.ultraButton4.TabIndex = 1;
			this.ultraButton4.Text = "Eliminar";
			// 
			// ultraButton5
			// 
			this.ultraButton5.Location = new System.Drawing.Point(16, 4);
			this.ultraButton5.Name = "ultraButton5";
			this.ultraButton5.Size = new System.Drawing.Size(88, 24);
			this.ultraButton5.TabIndex = 0;
			this.ultraButton5.Text = "Agregar";
			// 
			// gridEX2
			// 
			this.gridEX2.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEX2.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridEX2.Location = new System.Drawing.Point(16, 35);
			this.gridEX2.Name = "gridEX2";
			this.gridEX2.Size = new System.Drawing.Size(552, 104);
			this.gridEX2.TabIndex = 2;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.toolBarButton1,
																							  this.toolBarButton2,
																							  this.toolBarButton3,
																							  this.toolBarButton4,
																							  this.toolBarButton5,
																							  this.toolBarButton6,
																							  this.toolBarButton7,
																							  this.toolBarButton8,
																							  this.tbStep3,
																							  this.tbDelete});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(912, 28);
			this.toolBarStandar.TabIndex = 17;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.ImageIndex = 0;
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.ImageIndex = 1;
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.ImageIndex = 2;
			// 
			// toolBarButton4
			// 
			this.toolBarButton4.ImageIndex = 3;
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton6
			// 
			this.toolBarButton6.ImageIndex = 5;
			// 
			// toolBarButton7
			// 
			this.toolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton8
			// 
			this.toolBarButton8.ImageIndex = 4;
			this.toolBarButton8.Text = "Guardar";
			// 
			// tbStep3
			// 
			this.tbStep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbDelete
			// 
			this.tbDelete.ImageIndex = 7;
			this.tbDelete.Text = "Borrar";
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
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 120;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Datos de Cabecera";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 181;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Detalle de Productos";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl4;
			ultraExplorerBarGroup3.Settings.ContainerHeight = 174;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Totales";
			ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl5;
			ultraExplorerBarGroup4.Settings.ContainerHeight = 144;
			ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup4.Text = "Información Adicional";
			ultraExplorerBarGroup5.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup5.Settings.ContainerHeight = 146;
			ultraExplorerBarGroup5.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup5.Text = "Formas de Pago";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3,
																														ultraExplorerBarGroup4,
																														ultraExplorerBarGroup5});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(912, 473);
			this.ultraExplorerBar1.TabIndex = 18;
			// 
			// TestFactura
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(912, 501);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "TestFactura";
			this.Text = "TestFactura";
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTipoComprobante)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cldFechaComprobante)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
			this.ultraExplorerBarContainerControl4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uneRecargosFinancieros)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalDescuentos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalBruto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridResumenImpuestos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalImpuestos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalNeto)).EndInit();
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridDetalleCondicionDeVenta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridVariablesUsuario)).EndInit();
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridEX2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void InitializeCustomComponents()
		{			
			

			mzCmbTipoComprobante.ValueChanged+= new System.EventHandler( this.Componentes_Changes );
			mzCmbResponsableEmision.ValueChanged+= new System.EventHandler( this.Componentes_Changes );
			mzCmbCuenta.ValueChanged+= new System.EventHandler( this.Componentes_Changes );
			mzCmbCondicionDeVenta.ValueChanged+= new System.EventHandler( this.Componentes_Changes );

			mzCmbTipoComprobante.FillFromDataSource( businessrules.tsy_TiposDeComprobantes.GetList().tsy_TiposDeComprobantes, "IdTipoDeComprobante","Descripcion",8,"ID","Descripcion","Descripcion");
			mzCmbResponsableEmision.SearchObject = typeof( mz.erp.ui.forms.classes.tsh_Personas );
			mzCmbCuenta.SearchObject = typeof(  mz.erp.ui.forms.classes.tsa_Cuentas  );
			mzCmbCondicionDeVenta.SearchObject = typeof( mz.erp.ui.forms.classes.tsa_CondicionesDeVentas );
			mzCmbTipoComprobante.Value = "FAA";
			cldFechaComprobante.Value = mz.erp.businessrules.Sistema.DateTime.Now;
			cldFechaComprobante.ReadOnly = true;
			
			miComprobante = new mz.erp.businessrules.comprobantes.ComprobanteDeVenta((string)mzCmbTipoComprobante.Value, string.Empty, null);
			miComprobante.OnRecalcularComprobante+= new ComprobanteDeVenta.RecalcularComprobante( this.Recalcular );
			miComprobante.OnRefrescarComprobante+= new ComprobanteDeVenta.RefrescarComprobante( this.Refrescar );
			gridProductos.GroupByBoxVisible= false;
			gridProductos.LayoutData = mz.erp.ui.forms.classes.ComprobantesDeVenta.GetLayoutDetalleProductos( new string[] { "Codigo", "Cantidad","Descripcion","PrecioDeVentaBruto","BonificacionPorcentual","Precio","SubTotalNeto","SubTotalConImpuestos","PrecioConImpuestos"} );
			gridProductos.DataSource = miComprobante.Items;
			
			gridResumenImpuestos.GroupByBoxVisible = false;
			gridResumenImpuestos.LayoutData = mz.erp.ui.forms.classes.ComprobantesDeVenta.GetLayoutResumenImpuestos( new string[] { "Impuesto","Importe" } );
			gridResumenImpuestos.DataSource = miComprobante.ResumenDeImpuestos;
			gridResumenImpuestos.Enabled = false;

			gridVariablesUsuario.GroupByBoxVisible = false;
			gridVariablesUsuario.LayoutData = mz.erp.ui.forms.classes.ComprobantesDeVenta.GetLayoutVariables( );
			gridVariablesUsuario.DataSource = miComprobante.VariablesDeUsuario;
			

			gridDetalleCondicionDeVenta.GroupByBoxVisible = false;
			gridDetalleCondicionDeVenta.LayoutData = mz.erp.ui.forms.classes.ComprobantesDeVenta.GetLayoutDetalleCondicionDeVenta( new string[] {"IdCuota","FechaVencimiento","Monto"} );
			gridDetalleCondicionDeVenta.DataSource = miComprobante.CondicionDeVenta.DetalleCondicionDeVenta;
			gridDetalleCondicionDeVenta.Enabled = false;

			uneTotal.DataBindings.Add( "Value", miComprobante, "TotalConImpuestos");
			uneTotalImpuestos.DataBindings.Add("Value", miComprobante, "TotalImpuestos");
			uneTotalNeto.DataBindings.Add("Value",miComprobante,"TotalNeto");
			
			
		}

		/*private void OnChangeEstadoFiscal(object Sender, System.EventArgs e) 
		{														
			frmEst.CargarUltimoEstado(fiscal.Mensaje);			
			frmEst.Refresh();
		}*/

		private void Componentes_Changes(object sender, System.EventArgs e)
		{
			if (((Control)sender).Name == "mzCmbTipoComprobante")
			{
				if (mzCmbTipoComprobante.Value != null && miComprobante != null)	
				{
					miComprobante.TipoComprobanteDestino = (string)mzCmbTipoComprobante.Value;
				}
			}
			if (((Control)sender).Name == "mzCmbCuenta")
			{
				if (mzCmbCuenta.DataValue != null && miComprobante != null)
				{
					miComprobante.Cuenta.IdCuenta = mz.erp.businessrules.tsa_Cuentas.GetPkByUk((string)mzCmbCuenta.DataValue);
					System.Data.DataRow row = mzCmbCuenta.SelectedRow;
					miComprobante.Cuenta.Nombre = row["Nombre"].ToString();
					miComprobante.Cuenta.Domicilio = row["Domicilio"].ToString();
					miComprobante.Cuenta.TipoDocumento = row["idTipoDocumento"].ToString();
					miComprobante.Cuenta.Documento = row["Documento"].ToString();					
					miComprobante.Cuenta.CategoriaImpositiva = row["IdCategoriaIva"].ToString();
				}
			}
			if (((Control)sender).Name == "mzCmbCondicionDeVenta")
			{
				if (mzCmbCondicionDeVenta.DataValue != null && miComprobante != null)
				{
					miComprobante.CondicionDeVenta.IdCondicionDeVenta = (string)mzCmbCondicionDeVenta.DataValue;
				}
			}
			if (((Control)sender).Name == "mzCmbResponsableEmision")
			{
				if (mzCmbResponsableEmision.DataValue != null && miComprobante != null)
				{
					miComprobante.IdResponsable = (string)mzCmbResponsableEmision.DataValue;
					System.Data.DataRow row = mzCmbResponsableEmision.SelectedRow;
					miComprobante.Responsable = row["Nombre"].ToString();
				}
			}
		}
		private void BotoneraProductos( object sender, System.EventArgs e)
		{
			if (sender is Infragistics.Win.Misc.UltraButton)
			{
				string name=((Infragistics.Win.Misc.UltraButton)sender).Name;
				if (name == "bAgregarProducto")
				{
					AgregarProducto();
				}
				if (name == "bEliminarProducto")
				{
					EliminarProducto();
				}
			}
		}

		private void AgregarProducto()
		{
			mz.erp.ui.forms.FrmComprobantesABMProductos form = new FrmComprobantesABMProductos();
			form.ShowForm( miComprobante, "Nuevo", "Agregar Productos");
		}
		private void EliminarProducto()
		{
		}
		private void Refrescar( object sender, System.EventArgs e)
		{
			MessageBox.Show("La Factura Ha Cambiado");
		}
		private void Recalcular( object sender, System.EventArgs e )
		{
			gridProductos.Refetch();
			gridProductos.Refresh();
			gridResumenImpuestos.SetDataBinding(null,null);
			gridResumenImpuestos.SetDataBinding( miComprobante.ResumenDeImpuestos, null );
			gridDetalleCondicionDeVenta.SetDataBinding( null, null);
			gridDetalleCondicionDeVenta.SetDataBinding( miComprobante.CondicionDeVenta.DetalleCondicionDeVenta, null);
			gridDetalleCondicionDeVenta.Refresh();					
		}


		private void mzCmbTipoComprobante_ValueChanged(object sender, System.EventArgs e)
		{
			
		}

		private void mzCmbCuenta_ValueChanged(object sender, System.EventArgs e)
		{

		}

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			miComprobante.Commit();
			Evaluate();
		}
		protected void Evaluate()
		{			
			if (miComprobante.DatasetComprobante.HasErrors)
			{
				DatasetErrors Errores = new DatasetErrors( miComprobante.DatasetComprobante);
				/*20110328 - Tarea 0000057*/ FrmShowErrors _form = new /*20110328 - Tarea 0000057*/ FrmShowErrors( miComprobante.DatasetComprobante );
				_form.Show();
				miComprobante.DatasetComprobante = null;
			}
			else
			{
				/*ItemsComprobantes items = miComprobante.Items;

				foreach (ItemComprobante itemComp in items)
				{					
					MessageBox.Show("aca");
				}*/
			
				DialogResult result = MessageBox.Show("Impresión fiscal","Está seguro que desea imprimir el comprobante fiscal?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
				if (result == DialogResult.Yes) 
				{
					FrmFiscal frmFis = new FrmFiscal();						
					
					//frmFis.ImpresionFiscal(miComprobante, "FA");
					frmFis.ImpresionFiscal(miComprobante, Variables.GetValueString("Fiscal.Comprobante"));
					if (!frmFis.SoportaComprobante) 
					{
						MessageBox.Show("El comprobante no es soportado");
					}
					
					/*frmEst = new FrmEstados();					
					frmEst.Show();
					fiscal = new InterfaceFiscal(miComprobante, "FA");
					fiscal.OnChangeEstadoFiscal += new EventHandler(this.OnChangeEstadoFiscal);
					if (fiscal.ImpresionFiscal())
					{
						frmEst.Close();
					}					*/
				}
				MessageBox.Show("La acción se ha ejecutado con éxito");
			}
		}
	}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using ParaisoFiscal;
using mz.erp.businessrules;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de Form1.
	/// </summary>
	public class frmTestFiscal : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox txtBxCodImpFis;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox txtBxCodCli;
		private System.Windows.Forms.TextBox txtBxCodComp;
		private System.Windows.Forms.TextBox txtBxVelocidad;
		private System.Windows.Forms.TextBox txtBxPuerto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;

		private ParaisoFiscal.FiscalMZ Fiscal;

		private System.Windows.Forms.Button bttnCerrarImpFis;
		private System.Windows.Forms.Button bttnCancelarComp;
		private System.Windows.Forms.Button bttnImprimirItem;
		private System.Windows.Forms.Button bttnCerrarComp;
		private System.Windows.Forms.Button bttnReporte;
		private System.Windows.Forms.Button bttnAbrirImpFis;
		private System.Windows.Forms.Button bttnAbrirComp;
		private System.Windows.Forms.TextBox txtBxDireccion;
		private System.Windows.Forms.TextBox txtBxDocumento;
		private System.Windows.Forms.TextBox txtBxNombre;
		private System.Windows.Forms.TextBox txtBxTipoDocumento;
		private System.Windows.Forms.TextBox txtBxNroInterno;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Button bttnDesctoGeneral;
		private System.Windows.Forms.Button bttnPercepcion;
		private System.Windows.Forms.Button bttnPago;
		private System.Windows.Forms.TextBox txtBxTextoFiscal;
		private System.Windows.Forms.TextBox txtBxDescripcion;
		private System.Windows.Forms.TextBox txtBxPrecio;
		private System.Windows.Forms.TextBox txtBxCantidad;
		private System.Windows.Forms.TextBox txtBxImpInt;
		private System.Windows.Forms.TextBox txtBxIVA;
		private System.Windows.Forms.TextBox txtMontoDif;
		private System.Windows.Forms.TextBox txtBxDescripcionDif;
		private System.Windows.Forms.RadioButton rdbttnDescuento;
		private System.Windows.Forms.RadioButton rdbttnRecargo;
		private System.Windows.Forms.Button bttnSubtotales;
		private System.Windows.Forms.TextBox txtBxPercIva;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox txtBxPercMonto;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.RadioButton rdBttnReporteZ;
		private System.Windows.Forms.RadioButton rdBttnReporteX;
		private System.Windows.Forms.TextBox txtBxPago;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TextBox txtBxFormaPago;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.TextBox txtBxEncabezado4;
		private System.Windows.Forms.TextBox txtBxEncabezado3;
		private System.Windows.Forms.TextBox txtBxEncabezado2;
		private System.Windows.Forms.TextBox txtBxEncabezado1;
		private System.Windows.Forms.TextBox txtBxNumAsoc4;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.TextBox txtBxNumAsoc3;
		private System.Windows.Forms.TextBox txtBxNumAsoc2;
		private System.Windows.Forms.TextBox txtBxNumAsoc1;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.TextBox txtBxGralMonto;
		private System.Windows.Forms.TextBox txtBxGralDesc;
		private System.Windows.Forms.RadioButton rdbttnRecargoGral;
		private System.Windows.Forms.RadioButton rdbttnDescuentoGral;
		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.TextBox txtCopias;
		private System.Windows.Forms.Button butReimprimir;
		private System.Windows.Forms.Button butObservacionRecibo;
		private System.Windows.Forms.TextBox txtObservacionRecibo;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.ListBox listBox3;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.TextBox txtBxCodImpFis2;
		private System.Windows.Forms.TextBox txtCliente2;
		private System.Windows.Forms.TextBox txtDireccion2;
		private System.Windows.Forms.TextBox txtDocumento2;
		private System.Windows.Forms.ListBox listBoxTiposDeComprobante;
		private System.Windows.Forms.Button bttnAbrirImpFis2;
		private System.Windows.Forms.Button butImpresionRapida;
		private System.Windows.Forms.Button bttnCerrarImpFis2;
		//private AxEPSON_Impresora_Fiscal.AxPrinterFiscal axPrinterFiscal1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		byte IR_CodImpFis = 0;
		byte IR_CodCompTipo = 0;
		byte IR_CodCliTipo = 0;
		byte IR_TipoDocumento = 0;

		string IR_ClienteA = "M.Z. Informática S.A.";
		string IR_ClienteB = "CLIENTE DE PASO";
		string IR_Direccion = "Av. 7 Nro. 520";
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Button btnTest2;
		private System.Windows.Forms.TextBox txtDescripcionItem;
		private System.Windows.Forms.Button butDatosConf;
		private System.Windows.Forms.VScrollBar vScrollBar1;
		private System.Windows.Forms.TextBox txtCopiasFacturas;
		private System.Windows.Forms.CheckBox chkFijo;
		string IR_DocumentoA = "30707839011";



		enum Days { Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday };

		public frmTestFiscal()
		{
			InitializeComponent();
			Inicializar();			
		}

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rdBttnReporteZ = new System.Windows.Forms.RadioButton();
			this.rdBttnReporteX = new System.Windows.Forms.RadioButton();
			this.bttnReporte = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.bttnAbrirImpFis = new System.Windows.Forms.Button();
			this.txtBxVelocidad = new System.Windows.Forms.TextBox();
			this.txtBxPuerto = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtBxCodCli = new System.Windows.Forms.TextBox();
			this.txtBxCodComp = new System.Windows.Forms.TextBox();
			this.txtBxCodImpFis = new System.Windows.Forms.TextBox();
			this.btnTest = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.txtBxNumAsoc4 = new System.Windows.Forms.TextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.txtBxNumAsoc3 = new System.Windows.Forms.TextBox();
			this.txtBxNumAsoc2 = new System.Windows.Forms.TextBox();
			this.txtBxNumAsoc1 = new System.Windows.Forms.TextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.txtBxNroInterno = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtBxTipoDocumento = new System.Windows.Forms.TextBox();
			this.txtBxEncabezado4 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtBxEncabezado3 = new System.Windows.Forms.TextBox();
			this.txtBxEncabezado2 = new System.Windows.Forms.TextBox();
			this.txtBxEncabezado1 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtBxDireccion = new System.Windows.Forms.TextBox();
			this.txtBxDocumento = new System.Windows.Forms.TextBox();
			this.txtBxNombre = new System.Windows.Forms.TextBox();
			this.bttnAbrirComp = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.chkFijo = new System.Windows.Forms.CheckBox();
			this.rdbttnRecargo = new System.Windows.Forms.RadioButton();
			this.rdbttnDescuento = new System.Windows.Forms.RadioButton();
			this.txtMontoDif = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.txtBxDescripcionDif = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.txtBxImpInt = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.txtBxIVA = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.txtBxPrecio = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.txtBxCantidad = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txtBxDescripcion = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txtBxTextoFiscal = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.bttnImprimirItem = new System.Windows.Forms.Button();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.rdbttnRecargoGral = new System.Windows.Forms.RadioButton();
			this.rdbttnDescuentoGral = new System.Windows.Forms.RadioButton();
			this.txtBxGralMonto = new System.Windows.Forms.TextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.txtBxGralDesc = new System.Windows.Forms.TextBox();
			this.label31 = new System.Windows.Forms.Label();
			this.txtBxPago = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.txtBxFormaPago = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.txtBxPercIva = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.txtBxPercMonto = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.bttnPago = new System.Windows.Forms.Button();
			this.bttnPercepcion = new System.Windows.Forms.Button();
			this.bttnDesctoGeneral = new System.Windows.Forms.Button();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.butDatosConf = new System.Windows.Forms.Button();
			this.txtObservacionRecibo = new System.Windows.Forms.TextBox();
			this.butObservacionRecibo = new System.Windows.Forms.Button();
			this.butReimprimir = new System.Windows.Forms.Button();
			this.txtCopias = new System.Windows.Forms.TextBox();
			this.label32 = new System.Windows.Forms.Label();
			this.bttnCerrarComp = new System.Windows.Forms.Button();
			this.bttnCancelarComp = new System.Windows.Forms.Button();
			this.bttnCerrarImpFis = new System.Windows.Forms.Button();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.listBox3 = new System.Windows.Forms.ListBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.txtCopiasFacturas = new System.Windows.Forms.TextBox();
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			this.txtDescripcionItem = new System.Windows.Forms.TextBox();
			this.label33 = new System.Windows.Forms.Label();
			this.bttnCerrarImpFis2 = new System.Windows.Forms.Button();
			this.butImpresionRapida = new System.Windows.Forms.Button();
			this.label39 = new System.Windows.Forms.Label();
			this.listBoxTiposDeComprobante = new System.Windows.Forms.ListBox();
			this.txtDireccion2 = new System.Windows.Forms.TextBox();
			this.txtDocumento2 = new System.Windows.Forms.TextBox();
			this.label37 = new System.Windows.Forms.Label();
			this.label38 = new System.Windows.Forms.Label();
			this.txtCliente2 = new System.Windows.Forms.TextBox();
			this.label36 = new System.Windows.Forms.Label();
			this.txtBxCodImpFis2 = new System.Windows.Forms.TextBox();
			this.btnTest2 = new System.Windows.Forms.Button();
			this.label35 = new System.Windows.Forms.Label();
			this.bttnAbrirImpFis2 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.bttnSubtotales = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.tabPage6.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Location = new System.Drawing.Point(8, 8);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(600, 448);
			this.tabControl1.TabIndex = 3;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.listBox1);
			this.tabPage1.Controls.Add(this.groupBox3);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(592, 422);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Inicio";
			this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
			// 
			// listBox1
			// 
			this.listBox1.Location = new System.Drawing.Point(344, 24);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(232, 381);
			this.listBox1.TabIndex = 10;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.rdBttnReporteZ);
			this.groupBox3.Controls.Add(this.rdBttnReporteX);
			this.groupBox3.Controls.Add(this.bttnReporte);
			this.groupBox3.Location = new System.Drawing.Point(24, 304);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(304, 104);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Reportes";
			// 
			// rdBttnReporteZ
			// 
			this.rdBttnReporteZ.Location = new System.Drawing.Point(40, 40);
			this.rdBttnReporteZ.Name = "rdBttnReporteZ";
			this.rdBttnReporteZ.TabIndex = 8;
			this.rdBttnReporteZ.Text = "Reporte Z";
			// 
			// rdBttnReporteX
			// 
			this.rdBttnReporteX.Location = new System.Drawing.Point(40, 16);
			this.rdBttnReporteX.Name = "rdBttnReporteX";
			this.rdBttnReporteX.TabIndex = 7;
			this.rdBttnReporteX.Text = "Reporte X";
			// 
			// bttnReporte
			// 
			this.bttnReporte.Location = new System.Drawing.Point(40, 64);
			this.bttnReporte.Name = "bttnReporte";
			this.bttnReporte.Size = new System.Drawing.Size(224, 32);
			this.bttnReporte.TabIndex = 9;
			this.bttnReporte.Text = "Reporte";
			this.bttnReporte.Click += new System.EventHandler(this.bttnReporte_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.bttnAbrirImpFis);
			this.groupBox2.Controls.Add(this.txtBxVelocidad);
			this.groupBox2.Controls.Add(this.txtBxPuerto);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(24, 176);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(304, 120);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Apertura";
			// 
			// bttnAbrirImpFis
			// 
			this.bttnAbrirImpFis.Location = new System.Drawing.Point(40, 80);
			this.bttnAbrirImpFis.Name = "bttnAbrirImpFis";
			this.bttnAbrirImpFis.Size = new System.Drawing.Size(224, 32);
			this.bttnAbrirImpFis.TabIndex = 6;
			this.bttnAbrirImpFis.Text = "Abrir impresora";
			this.bttnAbrirImpFis.Click += new System.EventHandler(this.bttnAbrirImpFis_Click);
			// 
			// txtBxVelocidad
			// 
			this.txtBxVelocidad.Location = new System.Drawing.Point(162, 50);
			this.txtBxVelocidad.Name = "txtBxVelocidad";
			this.txtBxVelocidad.Size = new System.Drawing.Size(88, 20);
			this.txtBxVelocidad.TabIndex = 5;
			this.txtBxVelocidad.Text = "txtBxVelocidad";
			// 
			// txtBxPuerto
			// 
			this.txtBxPuerto.Location = new System.Drawing.Point(162, 26);
			this.txtBxPuerto.Name = "txtBxPuerto";
			this.txtBxPuerto.Size = new System.Drawing.Size(88, 20);
			this.txtBxPuerto.TabIndex = 4;
			this.txtBxPuerto.Text = "txtBxPuerto";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(54, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 16);
			this.label1.TabIndex = 19;
			this.label1.Text = "Velocidad";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(54, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 16);
			this.label2.TabIndex = 18;
			this.label2.Text = "Puerto";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtBxCodCli);
			this.groupBox1.Controls.Add(this.txtBxCodComp);
			this.groupBox1.Controls.Add(this.txtBxCodImpFis);
			this.groupBox1.Controls.Add(this.btnTest);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Location = new System.Drawing.Point(24, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(304, 152);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Inicialización";
			// 
			// txtBxCodCli
			// 
			this.txtBxCodCli.Location = new System.Drawing.Point(160, 72);
			this.txtBxCodCli.Name = "txtBxCodCli";
			this.txtBxCodCli.Size = new System.Drawing.Size(88, 20);
			this.txtBxCodCli.TabIndex = 2;
			this.txtBxCodCli.Text = "txtBxCodCli";
			// 
			// txtBxCodComp
			// 
			this.txtBxCodComp.Location = new System.Drawing.Point(160, 48);
			this.txtBxCodComp.Name = "txtBxCodComp";
			this.txtBxCodComp.Size = new System.Drawing.Size(88, 20);
			this.txtBxCodComp.TabIndex = 1;
			this.txtBxCodComp.Text = "txtBxCodComp";
			// 
			// txtBxCodImpFis
			// 
			this.txtBxCodImpFis.Location = new System.Drawing.Point(160, 24);
			this.txtBxCodImpFis.Name = "txtBxCodImpFis";
			this.txtBxCodImpFis.Size = new System.Drawing.Size(88, 20);
			this.txtBxCodImpFis.TabIndex = 0;
			this.txtBxCodImpFis.Text = "txtBxCodImpFis";
			// 
			// btnTest
			// 
			this.btnTest.Location = new System.Drawing.Point(40, 112);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(224, 32);
			this.btnTest.TabIndex = 3;
			this.btnTest.Text = "Test";
			this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(52, 74);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 16);
			this.label4.TabIndex = 13;
			this.label4.Text = "Cod. Cliente";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(52, 50);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 16);
			this.label5.TabIndex = 11;
			this.label5.Text = "Cod. Comprobante";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(52, 26);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(112, 16);
			this.label6.TabIndex = 9;
			this.label6.Text = "Cod. Imp. Fiscal";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox4);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(592, 422);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Cabecera";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.txtBxNumAsoc4);
			this.groupBox4.Controls.Add(this.label26);
			this.groupBox4.Controls.Add(this.txtBxNumAsoc3);
			this.groupBox4.Controls.Add(this.txtBxNumAsoc2);
			this.groupBox4.Controls.Add(this.txtBxNumAsoc1);
			this.groupBox4.Controls.Add(this.label27);
			this.groupBox4.Controls.Add(this.label28);
			this.groupBox4.Controls.Add(this.label29);
			this.groupBox4.Controls.Add(this.txtBxNroInterno);
			this.groupBox4.Controls.Add(this.label13);
			this.groupBox4.Controls.Add(this.txtBxTipoDocumento);
			this.groupBox4.Controls.Add(this.txtBxEncabezado4);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Controls.Add(this.txtBxEncabezado3);
			this.groupBox4.Controls.Add(this.txtBxEncabezado2);
			this.groupBox4.Controls.Add(this.txtBxEncabezado1);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Controls.Add(this.label11);
			this.groupBox4.Controls.Add(this.txtBxDireccion);
			this.groupBox4.Controls.Add(this.txtBxDocumento);
			this.groupBox4.Controls.Add(this.txtBxNombre);
			this.groupBox4.Controls.Add(this.bttnAbrirComp);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Location = new System.Drawing.Point(16, 32);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(512, 328);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Comprobante";
			// 
			// txtBxNumAsoc4
			// 
			this.txtBxNumAsoc4.Location = new System.Drawing.Point(392, 176);
			this.txtBxNumAsoc4.Name = "txtBxNumAsoc4";
			this.txtBxNumAsoc4.Size = new System.Drawing.Size(88, 20);
			this.txtBxNumAsoc4.TabIndex = 11;
			this.txtBxNumAsoc4.Text = "txtBxNumAsoc4";
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(280, 176);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(112, 16);
			this.label26.TabIndex = 36;
			this.label26.Text = "Num. Asoc.4";
			// 
			// txtBxNumAsoc3
			// 
			this.txtBxNumAsoc3.Location = new System.Drawing.Point(392, 152);
			this.txtBxNumAsoc3.Name = "txtBxNumAsoc3";
			this.txtBxNumAsoc3.Size = new System.Drawing.Size(88, 20);
			this.txtBxNumAsoc3.TabIndex = 9;
			this.txtBxNumAsoc3.Text = "txtBxNumAsoc3";
			// 
			// txtBxNumAsoc2
			// 
			this.txtBxNumAsoc2.Location = new System.Drawing.Point(392, 128);
			this.txtBxNumAsoc2.Name = "txtBxNumAsoc2";
			this.txtBxNumAsoc2.Size = new System.Drawing.Size(88, 20);
			this.txtBxNumAsoc2.TabIndex = 7;
			this.txtBxNumAsoc2.Text = "txtBxNumAsoc2";
			// 
			// txtBxNumAsoc1
			// 
			this.txtBxNumAsoc1.Location = new System.Drawing.Point(392, 104);
			this.txtBxNumAsoc1.Name = "txtBxNumAsoc1";
			this.txtBxNumAsoc1.Size = new System.Drawing.Size(88, 20);
			this.txtBxNumAsoc1.TabIndex = 5;
			this.txtBxNumAsoc1.Text = "txtBxNumAsoc1";
			// 
			// label27
			// 
			this.label27.Location = new System.Drawing.Point(280, 152);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(112, 16);
			this.label27.TabIndex = 32;
			this.label27.Text = "Num. Asoc.3";
			// 
			// label28
			// 
			this.label28.Location = new System.Drawing.Point(280, 130);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(112, 16);
			this.label28.TabIndex = 31;
			this.label28.Text = "Num. Asoc.2";
			// 
			// label29
			// 
			this.label29.Location = new System.Drawing.Point(280, 106);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(112, 16);
			this.label29.TabIndex = 30;
			this.label29.Text = "Num. Asoc.1";
			// 
			// txtBxNroInterno
			// 
			this.txtBxNroInterno.Location = new System.Drawing.Point(160, 240);
			this.txtBxNroInterno.Name = "txtBxNroInterno";
			this.txtBxNroInterno.Size = new System.Drawing.Size(88, 20);
			this.txtBxNroInterno.TabIndex = 12;
			this.txtBxNroInterno.Text = "0";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(48, 248);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(112, 16);
			this.label13.TabIndex = 28;
			this.label13.Text = "Nro. Interno";
			// 
			// txtBxTipoDocumento
			// 
			this.txtBxTipoDocumento.Location = new System.Drawing.Point(128, 48);
			this.txtBxTipoDocumento.Name = "txtBxTipoDocumento";
			this.txtBxTipoDocumento.Size = new System.Drawing.Size(24, 20);
			this.txtBxTipoDocumento.TabIndex = 1;
			this.txtBxTipoDocumento.Text = "txtBxTipoDocumento";
			// 
			// txtBxEncabezado4
			// 
			this.txtBxEncabezado4.Location = new System.Drawing.Point(160, 176);
			this.txtBxEncabezado4.Name = "txtBxEncabezado4";
			this.txtBxEncabezado4.Size = new System.Drawing.Size(88, 20);
			this.txtBxEncabezado4.TabIndex = 10;
			this.txtBxEncabezado4.Text = "txtBxEncabezado4";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(48, 176);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(112, 16);
			this.label12.TabIndex = 25;
			this.label12.Text = "Encabezado";
			// 
			// txtBxEncabezado3
			// 
			this.txtBxEncabezado3.Location = new System.Drawing.Point(160, 152);
			this.txtBxEncabezado3.Name = "txtBxEncabezado3";
			this.txtBxEncabezado3.Size = new System.Drawing.Size(88, 20);
			this.txtBxEncabezado3.TabIndex = 8;
			this.txtBxEncabezado3.Text = "txtBxEncabezado3";
			// 
			// txtBxEncabezado2
			// 
			this.txtBxEncabezado2.Location = new System.Drawing.Point(160, 128);
			this.txtBxEncabezado2.Name = "txtBxEncabezado2";
			this.txtBxEncabezado2.Size = new System.Drawing.Size(88, 20);
			this.txtBxEncabezado2.TabIndex = 6;
			this.txtBxEncabezado2.Text = "txtBxEncabezado2";
			// 
			// txtBxEncabezado1
			// 
			this.txtBxEncabezado1.Location = new System.Drawing.Point(160, 104);
			this.txtBxEncabezado1.Name = "txtBxEncabezado1";
			this.txtBxEncabezado1.Size = new System.Drawing.Size(88, 20);
			this.txtBxEncabezado1.TabIndex = 4;
			this.txtBxEncabezado1.Text = "txtBxEncabezado1";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(48, 152);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(112, 16);
			this.label9.TabIndex = 21;
			this.label9.Text = "Encabezado";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(48, 130);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(112, 16);
			this.label10.TabIndex = 20;
			this.label10.Text = "Encabezado";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(48, 106);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(112, 16);
			this.label11.TabIndex = 19;
			this.label11.Text = "Encabezado";
			// 
			// txtBxDireccion
			// 
			this.txtBxDireccion.Location = new System.Drawing.Point(160, 72);
			this.txtBxDireccion.Name = "txtBxDireccion";
			this.txtBxDireccion.Size = new System.Drawing.Size(88, 20);
			this.txtBxDireccion.TabIndex = 3;
			this.txtBxDireccion.Text = "txtBxDireccion";
			// 
			// txtBxDocumento
			// 
			this.txtBxDocumento.Location = new System.Drawing.Point(160, 48);
			this.txtBxDocumento.Name = "txtBxDocumento";
			this.txtBxDocumento.Size = new System.Drawing.Size(88, 20);
			this.txtBxDocumento.TabIndex = 2;
			this.txtBxDocumento.Text = "txtBxDocumento";
			// 
			// txtBxNombre
			// 
			this.txtBxNombre.Location = new System.Drawing.Point(160, 24);
			this.txtBxNombre.Name = "txtBxNombre";
			this.txtBxNombre.Size = new System.Drawing.Size(88, 20);
			this.txtBxNombre.TabIndex = 0;
			this.txtBxNombre.Text = "txtBxNombre";
			// 
			// bttnAbrirComp
			// 
			this.bttnAbrirComp.Location = new System.Drawing.Point(32, 272);
			this.bttnAbrirComp.Name = "bttnAbrirComp";
			this.bttnAbrirComp.Size = new System.Drawing.Size(224, 32);
			this.bttnAbrirComp.TabIndex = 13;
			this.bttnAbrirComp.Text = "Abrir comprobante";
			this.bttnAbrirComp.Click += new System.EventHandler(this.bttnAbrirComp_Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(52, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 16);
			this.label3.TabIndex = 13;
			this.label3.Text = "Dirección";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(52, 50);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(112, 16);
			this.label7.TabIndex = 11;
			this.label7.Text = "Documento";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(52, 26);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(112, 16);
			this.label8.TabIndex = 9;
			this.label8.Text = "Cliente";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.chkFijo);
			this.tabPage3.Controls.Add(this.rdbttnRecargo);
			this.tabPage3.Controls.Add(this.rdbttnDescuento);
			this.tabPage3.Controls.Add(this.txtMontoDif);
			this.tabPage3.Controls.Add(this.label20);
			this.tabPage3.Controls.Add(this.txtBxDescripcionDif);
			this.tabPage3.Controls.Add(this.label21);
			this.tabPage3.Controls.Add(this.txtBxImpInt);
			this.tabPage3.Controls.Add(this.label18);
			this.tabPage3.Controls.Add(this.txtBxIVA);
			this.tabPage3.Controls.Add(this.label19);
			this.tabPage3.Controls.Add(this.txtBxPrecio);
			this.tabPage3.Controls.Add(this.label16);
			this.tabPage3.Controls.Add(this.txtBxCantidad);
			this.tabPage3.Controls.Add(this.label17);
			this.tabPage3.Controls.Add(this.txtBxDescripcion);
			this.tabPage3.Controls.Add(this.label15);
			this.tabPage3.Controls.Add(this.txtBxTextoFiscal);
			this.tabPage3.Controls.Add(this.label14);
			this.tabPage3.Controls.Add(this.bttnImprimirItem);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(592, 422);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Items";
			// 
			// chkFijo
			// 
			this.chkFijo.Checked = true;
			this.chkFijo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkFijo.Location = new System.Drawing.Point(304, 200);
			this.chkFijo.Name = "chkFijo";
			this.chkFijo.TabIndex = 6;
			this.chkFijo.Text = "Fijo";
			// 
			// rdbttnRecargo
			// 
			this.rdbttnRecargo.Location = new System.Drawing.Point(168, 360);
			this.rdbttnRecargo.Name = "rdbttnRecargo";
			this.rdbttnRecargo.TabIndex = 10;
			this.rdbttnRecargo.Text = "Recargo";
			// 
			// rdbttnDescuento
			// 
			this.rdbttnDescuento.Location = new System.Drawing.Point(168, 336);
			this.rdbttnDescuento.Name = "rdbttnDescuento";
			this.rdbttnDescuento.TabIndex = 9;
			this.rdbttnDescuento.Text = "Descuento";
			// 
			// txtMontoDif
			// 
			this.txtMontoDif.Location = new System.Drawing.Point(164, 304);
			this.txtMontoDif.Name = "txtMontoDif";
			this.txtMontoDif.Size = new System.Drawing.Size(50, 20);
			this.txtMontoDif.TabIndex = 8;
			this.txtMontoDif.Text = "txtMontoDif";
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(52, 304);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(112, 16);
			this.label20.TabIndex = 34;
			this.label20.Text = "Monto";
			// 
			// txtBxDescripcionDif
			// 
			this.txtBxDescripcionDif.Location = new System.Drawing.Point(164, 272);
			this.txtBxDescripcionDif.Name = "txtBxDescripcionDif";
			this.txtBxDescripcionDif.Size = new System.Drawing.Size(376, 20);
			this.txtBxDescripcionDif.TabIndex = 7;
			this.txtBxDescripcionDif.Text = "txtBxDescripcionDif";
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(52, 272);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(112, 16);
			this.label21.TabIndex = 32;
			this.label21.Text = "Descripcion";
			// 
			// txtBxImpInt
			// 
			this.txtBxImpInt.Location = new System.Drawing.Point(192, 200);
			this.txtBxImpInt.Name = "txtBxImpInt";
			this.txtBxImpInt.Size = new System.Drawing.Size(88, 20);
			this.txtBxImpInt.TabIndex = 5;
			this.txtBxImpInt.Text = "txtBxImpInt";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(48, 200);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(120, 16);
			this.label18.TabIndex = 30;
			this.label18.Text = "Impuestos internos fijo";
			// 
			// txtBxIVA
			// 
			this.txtBxIVA.Location = new System.Drawing.Point(192, 168);
			this.txtBxIVA.Name = "txtBxIVA";
			this.txtBxIVA.Size = new System.Drawing.Size(50, 20);
			this.txtBxIVA.TabIndex = 4;
			this.txtBxIVA.Text = "txtBxIVA";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(48, 176);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(112, 16);
			this.label19.TabIndex = 28;
			this.label19.Text = "IVA";
			// 
			// txtBxPrecio
			// 
			this.txtBxPrecio.Location = new System.Drawing.Point(192, 136);
			this.txtBxPrecio.Name = "txtBxPrecio";
			this.txtBxPrecio.Size = new System.Drawing.Size(50, 20);
			this.txtBxPrecio.TabIndex = 3;
			this.txtBxPrecio.Text = "txtBxPrecio";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(48, 136);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(112, 16);
			this.label16.TabIndex = 26;
			this.label16.Text = "Precio U neto";
			// 
			// txtBxCantidad
			// 
			this.txtBxCantidad.Location = new System.Drawing.Point(192, 104);
			this.txtBxCantidad.Name = "txtBxCantidad";
			this.txtBxCantidad.Size = new System.Drawing.Size(50, 20);
			this.txtBxCantidad.TabIndex = 2;
			this.txtBxCantidad.Text = "txtBxCantidad";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(48, 104);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(112, 16);
			this.label17.TabIndex = 24;
			this.label17.Text = "Cantidad";
			// 
			// txtBxDescripcion
			// 
			this.txtBxDescripcion.Location = new System.Drawing.Point(192, 72);
			this.txtBxDescripcion.Name = "txtBxDescripcion";
			this.txtBxDescripcion.Size = new System.Drawing.Size(376, 20);
			this.txtBxDescripcion.TabIndex = 1;
			this.txtBxDescripcion.Text = "txtBxDescripcion";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(48, 72);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(112, 16);
			this.label15.TabIndex = 22;
			this.label15.Text = "Descripcion";
			// 
			// txtBxTextoFiscal
			// 
			this.txtBxTextoFiscal.Location = new System.Drawing.Point(192, 40);
			this.txtBxTextoFiscal.Name = "txtBxTextoFiscal";
			this.txtBxTextoFiscal.Size = new System.Drawing.Size(376, 20);
			this.txtBxTextoFiscal.TabIndex = 0;
			this.txtBxTextoFiscal.Text = "txtBxTextoFiscal";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(48, 42);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(112, 16);
			this.label14.TabIndex = 20;
			this.label14.Text = "Texto Fiscal";
			// 
			// bttnImprimirItem
			// 
			this.bttnImprimirItem.Location = new System.Drawing.Point(304, 360);
			this.bttnImprimirItem.Name = "bttnImprimirItem";
			this.bttnImprimirItem.Size = new System.Drawing.Size(224, 32);
			this.bttnImprimirItem.TabIndex = 11;
			this.bttnImprimirItem.Text = "Imprimir item";
			this.bttnImprimirItem.Click += new System.EventHandler(this.bttnImprimirItem_Click);
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.rdbttnRecargoGral);
			this.tabPage4.Controls.Add(this.rdbttnDescuentoGral);
			this.tabPage4.Controls.Add(this.txtBxGralMonto);
			this.tabPage4.Controls.Add(this.label30);
			this.tabPage4.Controls.Add(this.txtBxGralDesc);
			this.tabPage4.Controls.Add(this.label31);
			this.tabPage4.Controls.Add(this.txtBxPago);
			this.tabPage4.Controls.Add(this.label24);
			this.tabPage4.Controls.Add(this.txtBxFormaPago);
			this.tabPage4.Controls.Add(this.label25);
			this.tabPage4.Controls.Add(this.txtBxPercIva);
			this.tabPage4.Controls.Add(this.label22);
			this.tabPage4.Controls.Add(this.txtBxPercMonto);
			this.tabPage4.Controls.Add(this.label23);
			this.tabPage4.Controls.Add(this.bttnPago);
			this.tabPage4.Controls.Add(this.bttnPercepcion);
			this.tabPage4.Controls.Add(this.bttnDesctoGeneral);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(592, 422);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Pagos";
			// 
			// rdbttnRecargoGral
			// 
			this.rdbttnRecargoGral.Location = new System.Drawing.Point(88, 88);
			this.rdbttnRecargoGral.Name = "rdbttnRecargoGral";
			this.rdbttnRecargoGral.TabIndex = 3;
			this.rdbttnRecargoGral.Text = "Recargo";
			// 
			// rdbttnDescuentoGral
			// 
			this.rdbttnDescuentoGral.Location = new System.Drawing.Point(88, 64);
			this.rdbttnDescuentoGral.Name = "rdbttnDescuentoGral";
			this.rdbttnDescuentoGral.TabIndex = 2;
			this.rdbttnDescuentoGral.Text = "Descuento";
			// 
			// txtBxGralMonto
			// 
			this.txtBxGralMonto.Location = new System.Drawing.Point(200, 40);
			this.txtBxGralMonto.Name = "txtBxGralMonto";
			this.txtBxGralMonto.Size = new System.Drawing.Size(50, 20);
			this.txtBxGralMonto.TabIndex = 1;
			this.txtBxGralMonto.Text = "txtBxGralMonto";
			// 
			// label30
			// 
			this.label30.Location = new System.Drawing.Point(88, 40);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(112, 16);
			this.label30.TabIndex = 40;
			this.label30.Text = "Monto";
			// 
			// txtBxGralDesc
			// 
			this.txtBxGralDesc.Location = new System.Drawing.Point(200, 8);
			this.txtBxGralDesc.Name = "txtBxGralDesc";
			this.txtBxGralDesc.Size = new System.Drawing.Size(128, 20);
			this.txtBxGralDesc.TabIndex = 0;
			this.txtBxGralDesc.Text = "txtBxGralDesc";
			// 
			// label31
			// 
			this.label31.Location = new System.Drawing.Point(88, 8);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(112, 16);
			this.label31.TabIndex = 38;
			this.label31.Text = "Descripcion";
			// 
			// txtBxPago
			// 
			this.txtBxPago.Location = new System.Drawing.Point(208, 344);
			this.txtBxPago.Name = "txtBxPago";
			this.txtBxPago.Size = new System.Drawing.Size(104, 20);
			this.txtBxPago.TabIndex = 9;
			this.txtBxPago.Text = "txtBxPago";
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(96, 344);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(112, 16);
			this.label24.TabIndex = 36;
			this.label24.Text = "Pago";
			// 
			// txtBxFormaPago
			// 
			this.txtBxFormaPago.Location = new System.Drawing.Point(208, 312);
			this.txtBxFormaPago.Name = "txtBxFormaPago";
			this.txtBxFormaPago.Size = new System.Drawing.Size(104, 20);
			this.txtBxFormaPago.TabIndex = 8;
			this.txtBxFormaPago.Text = "txtBxFormaPago";
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(96, 320);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(112, 16);
			this.label25.TabIndex = 34;
			this.label25.Text = "Forma de pago";
			// 
			// txtBxPercIva
			// 
			this.txtBxPercIva.Location = new System.Drawing.Point(208, 224);
			this.txtBxPercIva.Name = "txtBxPercIva";
			this.txtBxPercIva.Size = new System.Drawing.Size(104, 20);
			this.txtBxPercIva.TabIndex = 6;
			this.txtBxPercIva.Text = "txtBxPercIva";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(96, 224);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(112, 16);
			this.label22.TabIndex = 32;
			this.label22.Text = "IVA";
			// 
			// txtBxPercMonto
			// 
			this.txtBxPercMonto.Location = new System.Drawing.Point(208, 192);
			this.txtBxPercMonto.Name = "txtBxPercMonto";
			this.txtBxPercMonto.Size = new System.Drawing.Size(104, 20);
			this.txtBxPercMonto.TabIndex = 5;
			this.txtBxPercMonto.Text = "txtBxPercMonto";
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(96, 192);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(112, 16);
			this.label23.TabIndex = 30;
			this.label23.Text = "Monto";
			// 
			// bttnPago
			// 
			this.bttnPago.Location = new System.Drawing.Point(96, 368);
			this.bttnPago.Name = "bttnPago";
			this.bttnPago.Size = new System.Drawing.Size(224, 32);
			this.bttnPago.TabIndex = 10;
			this.bttnPago.Text = "Pago";
			this.bttnPago.Click += new System.EventHandler(this.bttnPago_Click);
			// 
			// bttnPercepcion
			// 
			this.bttnPercepcion.Location = new System.Drawing.Point(96, 256);
			this.bttnPercepcion.Name = "bttnPercepcion";
			this.bttnPercepcion.Size = new System.Drawing.Size(224, 32);
			this.bttnPercepcion.TabIndex = 7;
			this.bttnPercepcion.Text = "Percepcion";
			this.bttnPercepcion.Click += new System.EventHandler(this.bttnPercepcion_Click);
			// 
			// bttnDesctoGeneral
			// 
			this.bttnDesctoGeneral.Location = new System.Drawing.Point(96, 128);
			this.bttnDesctoGeneral.Name = "bttnDesctoGeneral";
			this.bttnDesctoGeneral.Size = new System.Drawing.Size(224, 32);
			this.bttnDesctoGeneral.TabIndex = 4;
			this.bttnDesctoGeneral.Text = "Descto general";
			this.bttnDesctoGeneral.Click += new System.EventHandler(this.bttnDesctoGeneral_Click);
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.butDatosConf);
			this.tabPage5.Controls.Add(this.txtObservacionRecibo);
			this.tabPage5.Controls.Add(this.butObservacionRecibo);
			this.tabPage5.Controls.Add(this.butReimprimir);
			this.tabPage5.Controls.Add(this.txtCopias);
			this.tabPage5.Controls.Add(this.label32);
			this.tabPage5.Controls.Add(this.bttnCerrarComp);
			this.tabPage5.Controls.Add(this.bttnCancelarComp);
			this.tabPage5.Controls.Add(this.bttnCerrarImpFis);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(592, 422);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Cierre";
			// 
			// butDatosConf
			// 
			this.butDatosConf.Location = new System.Drawing.Point(464, 352);
			this.butDatosConf.Name = "butDatosConf";
			this.butDatosConf.Size = new System.Drawing.Size(112, 32);
			this.butDatosConf.TabIndex = 47;
			this.butDatosConf.Text = "Datos conf";
			this.butDatosConf.Click += new System.EventHandler(this.butDatosConf_Click);
			// 
			// txtObservacionRecibo
			// 
			this.txtObservacionRecibo.Location = new System.Drawing.Point(8, 320);
			this.txtObservacionRecibo.Name = "txtObservacionRecibo";
			this.txtObservacionRecibo.Size = new System.Drawing.Size(432, 20);
			this.txtObservacionRecibo.TabIndex = 1;
			this.txtObservacionRecibo.Text = "txtObservacionRecibo";
			// 
			// butObservacionRecibo
			// 
			this.butObservacionRecibo.Location = new System.Drawing.Point(464, 312);
			this.butObservacionRecibo.Name = "butObservacionRecibo";
			this.butObservacionRecibo.Size = new System.Drawing.Size(112, 32);
			this.butObservacionRecibo.TabIndex = 45;
			this.butObservacionRecibo.Text = "Observacion";
			this.butObservacionRecibo.Click += new System.EventHandler(this.butObservacionRecibo_Click);
			// 
			// butReimprimir
			// 
			this.butReimprimir.Location = new System.Drawing.Point(240, 192);
			this.butReimprimir.Name = "butReimprimir";
			this.butReimprimir.Size = new System.Drawing.Size(160, 56);
			this.butReimprimir.TabIndex = 44;
			this.butReimprimir.Text = "Reimprimir";
			this.butReimprimir.Click += new System.EventHandler(this.butReimprimir_Click);
			// 
			// txtCopias
			// 
			this.txtCopias.Location = new System.Drawing.Point(160, 208);
			this.txtCopias.Name = "txtCopias";
			this.txtCopias.Size = new System.Drawing.Size(50, 20);
			this.txtCopias.TabIndex = 43;
			this.txtCopias.Text = "0";
			// 
			// label32
			// 
			this.label32.Location = new System.Drawing.Point(48, 208);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(112, 16);
			this.label32.TabIndex = 42;
			this.label32.Text = "Copias";
			// 
			// bttnCerrarComp
			// 
			this.bttnCerrarComp.Location = new System.Drawing.Point(32, 16);
			this.bttnCerrarComp.Name = "bttnCerrarComp";
			this.bttnCerrarComp.Size = new System.Drawing.Size(224, 32);
			this.bttnCerrarComp.TabIndex = 18;
			this.bttnCerrarComp.Text = "Cerrar comp.";
			this.bttnCerrarComp.Click += new System.EventHandler(this.bttnCerrarComp_Click);
			// 
			// bttnCancelarComp
			// 
			this.bttnCancelarComp.Location = new System.Drawing.Point(288, 16);
			this.bttnCancelarComp.Name = "bttnCancelarComp";
			this.bttnCancelarComp.Size = new System.Drawing.Size(224, 32);
			this.bttnCancelarComp.TabIndex = 17;
			this.bttnCancelarComp.Text = "Cancelar comp.";
			this.bttnCancelarComp.Click += new System.EventHandler(this.bttnCancelarComp_Click);
			// 
			// bttnCerrarImpFis
			// 
			this.bttnCerrarImpFis.Location = new System.Drawing.Point(152, 64);
			this.bttnCerrarImpFis.Name = "bttnCerrarImpFis";
			this.bttnCerrarImpFis.Size = new System.Drawing.Size(224, 32);
			this.bttnCerrarImpFis.TabIndex = 16;
			this.bttnCerrarImpFis.Text = "Cerrar Imp.Fis.";
			this.bttnCerrarImpFis.Click += new System.EventHandler(this.bttnCerrarImpFis_Click);
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.Add(this.listBox3);
			this.tabPage6.Controls.Add(this.groupBox5);
			this.tabPage6.Location = new System.Drawing.Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Size = new System.Drawing.Size(592, 422);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "Impresión por bloqueo";
			// 
			// listBox3
			// 
			this.listBox3.Location = new System.Drawing.Point(336, 16);
			this.listBox3.Name = "listBox3";
			this.listBox3.Size = new System.Drawing.Size(232, 381);
			this.listBox3.TabIndex = 8;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.txtCopiasFacturas);
			this.groupBox5.Controls.Add(this.vScrollBar1);
			this.groupBox5.Controls.Add(this.txtDescripcionItem);
			this.groupBox5.Controls.Add(this.label33);
			this.groupBox5.Controls.Add(this.bttnCerrarImpFis2);
			this.groupBox5.Controls.Add(this.butImpresionRapida);
			this.groupBox5.Controls.Add(this.label39);
			this.groupBox5.Controls.Add(this.listBoxTiposDeComprobante);
			this.groupBox5.Controls.Add(this.txtDireccion2);
			this.groupBox5.Controls.Add(this.txtDocumento2);
			this.groupBox5.Controls.Add(this.label37);
			this.groupBox5.Controls.Add(this.label38);
			this.groupBox5.Controls.Add(this.txtCliente2);
			this.groupBox5.Controls.Add(this.label36);
			this.groupBox5.Controls.Add(this.txtBxCodImpFis2);
			this.groupBox5.Controls.Add(this.btnTest2);
			this.groupBox5.Controls.Add(this.label35);
			this.groupBox5.Controls.Add(this.bttnAbrirImpFis2);
			this.groupBox5.Location = new System.Drawing.Point(16, 8);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(304, 400);
			this.groupBox5.TabIndex = 2;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Inicialización";
			// 
			// txtCopiasFacturas
			// 
			this.txtCopiasFacturas.Location = new System.Drawing.Point(264, 288);
			this.txtCopiasFacturas.Name = "txtCopiasFacturas";
			this.txtCopiasFacturas.Size = new System.Drawing.Size(32, 20);
			this.txtCopiasFacturas.TabIndex = 6;
			this.txtCopiasFacturas.Text = "1";
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Location = new System.Drawing.Point(264, 312);
			this.vScrollBar1.Maximum = 1000;
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(32, 40);
			this.vScrollBar1.TabIndex = 7;
			this.vScrollBar1.Value = 1;
			this.vScrollBar1.ValueChanged += new System.EventHandler(this.vScrollBar1_ValueChanged);
			this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
			// 
			// txtDescripcionItem
			// 
			this.txtDescripcionItem.Location = new System.Drawing.Point(120, 216);
			this.txtDescripcionItem.Name = "txtDescripcionItem";
			this.txtDescripcionItem.Size = new System.Drawing.Size(176, 20);
			this.txtDescripcionItem.TabIndex = 5;
			this.txtDescripcionItem.Text = "txtDescripcionItem";
			// 
			// label33
			// 
			this.label33.Location = new System.Drawing.Point(16, 224);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(112, 16);
			this.label33.TabIndex = 37;
			this.label33.Text = "Descripcion del item";
			// 
			// bttnCerrarImpFis2
			// 
			this.bttnCerrarImpFis2.Location = new System.Drawing.Point(32, 360);
			this.bttnCerrarImpFis2.Name = "bttnCerrarImpFis2";
			this.bttnCerrarImpFis2.Size = new System.Drawing.Size(224, 32);
			this.bttnCerrarImpFis2.TabIndex = 36;
			this.bttnCerrarImpFis2.Text = "Cerrar Imp.Fis.";
			this.bttnCerrarImpFis2.Click += new System.EventHandler(this.bttnCerrarImpFis2_Click);
			// 
			// butImpresionRapida
			// 
			this.butImpresionRapida.Location = new System.Drawing.Point(32, 288);
			this.butImpresionRapida.Name = "butImpresionRapida";
			this.butImpresionRapida.Size = new System.Drawing.Size(224, 64);
			this.butImpresionRapida.TabIndex = 35;
			this.butImpresionRapida.Text = "Impresión";
			this.butImpresionRapida.Click += new System.EventHandler(this.butImpresionRapida_Click);
			// 
			// label39
			// 
			this.label39.Location = new System.Drawing.Point(16, 40);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(96, 32);
			this.label39.TabIndex = 34;
			this.label39.Text = "Cod. Comprobante";
			// 
			// listBoxTiposDeComprobante
			// 
			this.listBoxTiposDeComprobante.Items.AddRange(new object[] {
																		   "Factura A",
																		   "Factura B",
																		   "Nota de crédito A",
																		   "Nota de crédito B"});
			this.listBoxTiposDeComprobante.Location = new System.Drawing.Point(120, 40);
			this.listBoxTiposDeComprobante.Name = "listBoxTiposDeComprobante";
			this.listBoxTiposDeComprobante.Size = new System.Drawing.Size(136, 56);
			this.listBoxTiposDeComprobante.TabIndex = 1;
			this.listBoxTiposDeComprobante.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
			// 
			// txtDireccion2
			// 
			this.txtDireccion2.Location = new System.Drawing.Point(120, 192);
			this.txtDireccion2.Name = "txtDireccion2";
			this.txtDireccion2.Size = new System.Drawing.Size(176, 20);
			this.txtDireccion2.TabIndex = 4;
			this.txtDireccion2.Text = "txtDireccion2";
			// 
			// txtDocumento2
			// 
			this.txtDocumento2.Location = new System.Drawing.Point(120, 168);
			this.txtDocumento2.Name = "txtDocumento2";
			this.txtDocumento2.Size = new System.Drawing.Size(176, 20);
			this.txtDocumento2.TabIndex = 3;
			this.txtDocumento2.Text = "txtDocumento2";
			// 
			// label37
			// 
			this.label37.Location = new System.Drawing.Point(16, 192);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(112, 16);
			this.label37.TabIndex = 29;
			this.label37.Text = "Dirección";
			// 
			// label38
			// 
			this.label38.Location = new System.Drawing.Point(16, 168);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(112, 16);
			this.label38.TabIndex = 28;
			this.label38.Text = "Documento";
			// 
			// txtCliente2
			// 
			this.txtCliente2.Location = new System.Drawing.Point(120, 144);
			this.txtCliente2.Name = "txtCliente2";
			this.txtCliente2.Size = new System.Drawing.Size(176, 20);
			this.txtCliente2.TabIndex = 0;
			this.txtCliente2.Text = "txtCliente2";
			// 
			// label36
			// 
			this.label36.Location = new System.Drawing.Point(16, 144);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(112, 16);
			this.label36.TabIndex = 19;
			this.label36.Text = "Cliente";
			// 
			// txtBxCodImpFis2
			// 
			this.txtBxCodImpFis2.Location = new System.Drawing.Point(120, 16);
			this.txtBxCodImpFis2.Name = "txtBxCodImpFis2";
			this.txtBxCodImpFis2.Size = new System.Drawing.Size(88, 20);
			this.txtBxCodImpFis2.TabIndex = 0;
			this.txtBxCodImpFis2.Text = "txtBxCodImpFis2";
			// 
			// btnTest2
			// 
			this.btnTest2.Location = new System.Drawing.Point(32, 104);
			this.btnTest2.Name = "btnTest2";
			this.btnTest2.Size = new System.Drawing.Size(224, 32);
			this.btnTest2.TabIndex = 15;
			this.btnTest2.Text = "Inicializar controlador fiscal";
			this.btnTest2.Click += new System.EventHandler(this.btnTest2_Click);
			// 
			// label35
			// 
			this.label35.Location = new System.Drawing.Point(16, 16);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(112, 16);
			this.label35.TabIndex = 9;
			this.label35.Text = "Cod. Imp. Fiscal";
			// 
			// bttnAbrirImpFis2
			// 
			this.bttnAbrirImpFis2.Location = new System.Drawing.Point(32, 248);
			this.bttnAbrirImpFis2.Name = "bttnAbrirImpFis2";
			this.bttnAbrirImpFis2.Size = new System.Drawing.Size(224, 32);
			this.bttnAbrirImpFis2.TabIndex = 15;
			this.bttnAbrirImpFis2.Text = "Abrir impresora";
			this.bttnAbrirImpFis2.Click += new System.EventHandler(this.bttnAbrirImpFis2_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(32, 464);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(104, 32);
			this.button2.TabIndex = 4;
			this.button2.Text = "Salir";
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// listBox2
			// 
			this.listBox2.Location = new System.Drawing.Point(624, 8);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(288, 498);
			this.listBox2.TabIndex = 6;
			// 
			// bttnSubtotales
			// 
			this.bttnSubtotales.Location = new System.Drawing.Point(504, 464);
			this.bttnSubtotales.Name = "bttnSubtotales";
			this.bttnSubtotales.Size = new System.Drawing.Size(104, 32);
			this.bttnSubtotales.TabIndex = 7;
			this.bttnSubtotales.Text = "Subtotales";
			this.bttnSubtotales.Click += new System.EventHandler(this.bttnSubtotales_Click);
			// 
			// frmTestFiscal
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(920, 509);
			this.Controls.Add(this.bttnSubtotales);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.tabControl1);
			this.Name = "frmTestFiscal";
			this.Text = "Pantalla de prueba para impresoras fiscales";
			this.Load += new System.EventHandler(this.frmTestFiscal_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			this.tabPage6.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void Inicializar() 
		{
			listBox1.Items.Clear();
			listBox2.Items.Clear();
			txtBxCodImpFis.Text = "1";
			txtBxCodImpFis2.Text = "1";
			txtBxCodComp.Text = "1";
			txtBxCodCli.Text = "5";
			txtBxPuerto.Text = "1";
			txtBxVelocidad.Text = "0";
			txtBxNombre.Text = "M.Z. Informática S.A.";
			txtBxTipoDocumento.Text = "1";
			txtBxDocumento.Text = "99999999995";
			txtBxDireccion.Text = "Av.7 Nro.520";					

			txtBxNumAsoc1.Text = String.Empty;
			txtBxNumAsoc2.Text = String.Empty;
			txtBxNumAsoc3.Text = String.Empty;
			txtBxNumAsoc4.Text = String.Empty;

			txtBxEncabezado1.Text = String.Empty;
			txtBxEncabezado2.Text = String.Empty;
			txtBxEncabezado3.Text = String.Empty;
			txtBxEncabezado4.Text = String.Empty;

			txtBxNroInterno.Text = "0";
	
			txtBxTextoFiscal.Text = String.Empty;
			txtBxDescripcion.Text = "Item test fiscal";
			txtBxCantidad.Text = "1";
			txtBxPrecio.Text = "0";
			txtBxIVA.Text = "21";
			txtBxImpInt.Text = "0";
			txtBxDescripcionDif.Text = "Descuento/recargo";
			txtMontoDif.Text = "0";

			txtBxPercIva.Text = "0";
			txtBxPercMonto.Text = "0";
			
			txtBxFormaPago.Text = "Efectivo";			
			txtBxPago.Text = "0";
			
			txtBxGralDesc.Text = "Descuento /Recargo GRAL";
			txtBxGralMonto.Text = "0";

			txtDescripcionItem.Text = "IMPRESION DE ITEM POR BLOQUEO FISCAL";
		}

		/// <summary>
		/// Punto de entrada principal de la aplicación.
		/// </summary>
		
		private void button2_Click(object sender, System.EventArgs e)
		{
		}

		private void InformacionAdicional()
		{
			if (Variables.GetValueBool("Fiscal.InformacionAdicional")) 
			{
				listBox2.Items.Add(Fiscal.EstadoFiscal);
			}			
		}							

		private void button2_Click_1(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void bttnCerrarComp_Click(object sender, System.EventArgs e)
		{
			//txtCopias
			Fiscal.Copias = Convert.ToByte(txtCopias.Text);					
			Fiscal.CerrarComp();
			listBox2.Items.Add(Fiscal.Mensaje + ' ' + Fiscal.CompAbrev + ' ' + Fiscal.CompClase.ToString() + ' ' + Fiscal.CompNumeroD);
			InformacionAdicional();
		}

		private void bttnCerrarImpFis_Click(object sender, System.EventArgs e)
		{
			//German 20100618
			//Fiscal.CerrarImpFis();	
			Fiscal.CerrarImpFis(new ArrayList());	
			//Fin German 20100618
			listBox2.Items.Add(Fiscal.Mensaje);	
		}

		private void bttnCancelarComp_Click(object sender, System.EventArgs e)
		{
			Fiscal.CancelarComp();
			listBox2.Items.Add(Fiscal.Mensaje);	
		}

		private void bttnDesctoGeneral_Click(object sender, System.EventArgs e)
		{			
			char operacion = 'D';
			if (rdbttnDescuentoGral.Checked) {operacion = 'D';}
			if (rdbttnRecargoGral.Checked) {operacion = 'R';}			

			Fiscal.GrabarDesctoGral(txtBxGralDesc.Text, Decimal.Parse(txtBxGralMonto.Text), operacion);
			listBox2.Items.Add(Fiscal.Mensaje);	
		}

		private void bttnPago_Click(object sender, System.EventArgs e)
		{
			Fiscal.GrabarPago(txtBxFormaPago.Text, Decimal.Parse(txtBxPago.Text));
			listBox2.Items.Add(Fiscal.Mensaje);				
		}

		private void bttnSubtotales_Click(object sender, System.EventArgs e)
		{
			SubTotalFiscal st = new SubTotalFiscal();
			Fiscal.Subtotal(st);			

			listBox2.Items.Add("Cantidad: " + st.Cantidad.ToString());	
			listBox2.Items.Add("Neto: " + st.Neto.ToString());						
			listBox2.Items.Add("IVA: " + st.Iva.ToString());
			listBox2.Items.Add("Total: " + st.Total.ToString());	
			listBox2.Items.Add("Pagado: " + st.Pagado.ToString());	
			listBox2.Items.Add("Saldo: " + st.Saldo.ToString());
			listBox2.Items.Add(Fiscal.Mensaje);				
		}
		
		private void bttnPercepcion_Click(object sender, System.EventArgs e)
		{
			Fiscal.Percepcion("Percepcion", decimal.Parse(txtBxPercMonto.Text), decimal.Parse(txtBxPercIva.Text));
			listBox2.Items.Add(Fiscal.Mensaje);				
		}

		private void tabPage1_Click(object sender, System.EventArgs e)
		{		
		}

		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{		
		}

		private void button9_Click(object sender, System.EventArgs e)
		{		
		}

		private void button1_Click_1(object sender, System.EventArgs e)
		{					
		}		

		private void OnChangeEstado(object Sender, System.EventArgs e) 
		{					
			//System.Windows.Forms.MessageBox.Show(fiscal.Mensaje);			 
		}

		private void btnTest_Click(object sender, System.EventArgs e)
		{			
			Fiscal = new ParaisoFiscal.FiscalMZ();				
			listBox1.Items.Clear();			

			byte CodImpFis = byte.Parse(txtBxCodImpFis.Text);
			byte CodCompTipo = byte.Parse(txtBxCodComp.Text);
			byte CodCliTipo = byte.Parse(txtBxCodCli.Text);			
		
			if ( Fiscal.VerOpcImpFis(CodImpFis, CodCompTipo, CodCliTipo)) 
			{
				listBox1.Items.Add(Fiscal.Nombre);
				listBox1.Items.Add("Cantidad de pagos soportados: " + Fiscal.LinPagos.ToString());
				listBox1.Items.Add("Cantidad de caracteres para artículo: " + Fiscal.LinItemLong.ToString());
				listBox2.Items.Add(Fiscal.Nombre);
			}
			else
			{
				listBox1.Items.Add("Error de código de impresora fiscal");
				return;
			}			
			
			if (Fiscal.SoportaCompTipo)
			{
				listBox1.Items.Add("Soporta " + Fiscal.CompNombre);				
			}
			else
			{{listBox1.Items.Add("No soporta " + Fiscal.CompNombre);}}			
			
			if (Fiscal.SoportaCliente)
			{
				listBox1.Items.Add("Soporta " + Fiscal.CliTipo);				
			}
			else
			{{listBox1.Items.Add("No soporta " + Fiscal.CliTipo);}}
			InformacionAdicional();
		}

		private void bttnAbrirImpFis_Click(object sender, System.EventArgs e)
		{
			byte Puerto = byte.Parse(txtBxPuerto.Text);
			int Velocidad = int.Parse(txtBxVelocidad.Text);						
			Fiscal.AbrirImpFis(Puerto, Velocidad);			
			listBox2.Items.Add(Fiscal.Mensaje);			
			InformacionAdicional();
		}

		private void bttnReporte_Click(object sender, System.EventArgs e)
		{
			ReporteFiscal rf = new ReporteFiscal();			
			bool proceso = false;

			if (rdBttnReporteX.Checked)
			{
				if (Fiscal.Reporte('X',rf)) {proceso = true;}
			}
			if (rdBttnReporteZ.Checked) 
			{
				if (Fiscal.Reporte('Z',rf)) {proceso = true;};
			}

			listBox2.Items.Add(Fiscal.Mensaje);				
			if (proceso) 
			{
				listBox2.Items.Add("Nro. de reporte: " + rf.NroReporte);
				listBox2.Items.Add("Ult. comp. A: " + rf.UltA);
				listBox2.Items.Add("Ult. comp. B: " + rf.UltB);
				listBox2.Items.Add("Total ventas: " + rf.MontoVentas.ToString());
				listBox2.Items.Add("Total IVA: " + rf.MontoIVA.ToString());				
			}
		}

		private void bttnAbrirComp_Click(object sender, System.EventArgs e)
		{
			byte CodImpFis = byte.Parse(txtBxCodImpFis.Text);
			byte CodCompTipo = byte.Parse(txtBxCodComp.Text);			
			byte CodCliTipo = byte.Parse(txtBxCodCli.Text);

			ClienteFiscal clifis = new ClienteFiscal(CodImpFis);			
			//txtBxDocumento

			clifis.Nombre = txtBxNombre.Text;
			clifis.Direccion = txtBxDireccion.Text;
			clifis.CondIVA = CodCliTipo;
			clifis.DocNumero = txtBxDocumento.Text;
			clifis.DocTipo = byte.Parse(txtBxTipoDocumento.Text);						
			Fiscal.LinVar1 = txtBxEncabezado1.Text;
			Fiscal.LinVar2 = txtBxEncabezado2.Text;
			Fiscal.LinVar3 = txtBxEncabezado3.Text;
			Fiscal.LinVar4 = txtBxEncabezado4.Text;
			Fiscal.LinPie1 = "test fiscal pie 1";
			Fiscal.LinPie2 = "test fiscal pie 2";
			Fiscal.LinPie3 = "test fiscal pie 3";
			Fiscal.LinPie4 = "test fiscal pie 4";

			Fiscal.NumAsoc1 = txtBxNumAsoc1.Text;
			Fiscal.NumAsoc2 = txtBxNumAsoc2.Text;
			Fiscal.NumAsoc3 = txtBxNumAsoc3.Text;
			Fiscal.NumAsoc4 = txtBxNumAsoc4.Text;
			Fiscal.NroInterno = Convert.ToUInt64(txtBxNroInterno.Text);
				

			Fiscal.TipoLetra = Variables.GetValueString("Fiscal.TipoLetra");

			if (Fiscal.AbrirComp(CodCompTipo, 0, clifis))
			{
				listBox2.Items.Add(Fiscal.EstadoFiscal);
				listBox2.Items.Add("--------------------------------------------------");
				listBox2.Items.Add(Fiscal.Mensaje + ' ' + Fiscal.CompAbrev + ' ' + Fiscal.CompClase.ToString() + ' ' + Fiscal.CompNumeroD);
			}
			else 
			{
				listBox2.Items.Add(Fiscal.Mensaje);
			}
			InformacionAdicional();
		
		}

		private void bttnImprimirItem_Click(object sender, System.EventArgs e)
		{
			ItemFiscal item = new ItemFiscal();
			item.Descripcion = txtBxDescripcion.Text;
			item.Cantidad = Decimal.Parse(txtBxCantidad.Text);
			item.Monto = Decimal.Parse(txtBxPrecio.Text);
			item.IVA = Decimal.Parse(txtBxIVA.Text);
			if (chkFijo.Checked)
			{
				item.ImpuestosInternos = Decimal.Parse(txtBxImpInt.Text);
				item.TasaAjusteVariable = 0;
			}
			else
			{
				item.ImpuestosInternos = 0;
				item.TasaAjusteVariable = Decimal.Parse(txtBxImpInt.Text);
			}

			if (rdbttnDescuento.Checked) {item.Diferencia = 'D';}
			if (rdbttnRecargo.Checked) {item.Diferencia = 'R';}			
			
			item.MontoDif = Decimal.Parse(txtMontoDif.Text);
			item.DescripcionDif = txtBxDescripcionDif.Text;
			item.TextoFiscal = txtBxTextoFiscal.Text;
			Fiscal.GrabarItem(item);			
			listBox2.Items.Add(Fiscal.Mensaje);			
		}

		private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		private void butReimprimir_Click(object sender, System.EventArgs e)
		{
			/*byte Copias = byte.Parse(txtCopias.Text);
			Fiscal.Reimprimir(Copias);		*/
		}

		private void butObservacionRecibo_Click(object sender, System.EventArgs e)
		{
			Fiscal.GrabarObservacionPago(this.txtObservacionRecibo.Text);
		}

		private void listBox4_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		private void btnTest2_Click(object sender, System.EventArgs e)
		{
			IR_CodImpFis = byte.Parse(txtBxCodImpFis2.Text);
			IR_CodCompTipo = 0;
			IR_CodCliTipo = 0;
			IR_TipoDocumento = 0;

			IR_ClienteA = "M.Z. Informática S.A.";
			IR_ClienteB = "CLIENTE DE PASO";
			IR_Direccion = "Av. 7 Nro. 520";
			

			switch ( listBoxTiposDeComprobante.SelectedIndex )
			{						
				case 0:	 //FAA
					IR_CodCompTipo = 1;
					IR_CodCliTipo = 1;
					IR_TipoDocumento = 1;										
					txtCliente2.Text = IR_ClienteA;
					txtDocumento2.Text = IR_DocumentoA;
					break;
				case 1:	//FAB
					IR_CodCompTipo = 1;
					IR_CodCliTipo = 5;
					IR_TipoDocumento = 4;
					txtCliente2.Text = IR_ClienteB;
					txtDocumento2.Text = "0";
					break;
				case 2:	//NCA
					IR_CodCompTipo = 3;
					IR_CodCliTipo = 1;
					IR_TipoDocumento = 1;
					txtCliente2.Text = IR_ClienteA;
					txtDocumento2.Text = IR_DocumentoA;
					break;
				case 3:	//NCB
					IR_CodCompTipo = 3;
					IR_CodCliTipo = 5;
					IR_TipoDocumento = 4;
					txtCliente2.Text = IR_ClienteB;
					txtDocumento2.Text = "0";
					break;
			}

			txtDireccion2.Text = IR_Direccion;
			butImpresionRapida.Text = "Impresion de " + listBoxTiposDeComprobante.SelectedItem + " de 0.01";
		
			//TEST FISCAL
			listBox1.Items.Clear();

			Fiscal = new ParaisoFiscal.FiscalMZ();							
		
			if ( Fiscal.VerOpcImpFis(IR_CodImpFis, IR_CodCompTipo, IR_CodCliTipo)) 
			{
				listBox1.Items.Add(Fiscal.Nombre);			
			}
			else
			{
				listBox1.Items.Add("Error de código de impresora fiscal");
				return;
			}						
			InformacionAdicional();
			//FIN TEST FISCAL
		
		}

		private void bttnAbrirImpFis2_Click(object sender, System.EventArgs e)
		{
			byte Puerto = byte.Parse(txtBxPuerto.Text);
			int Velocidad = int.Parse(txtBxVelocidad.Text);						
			Fiscal.AbrirImpFis(Puerto, Velocidad);			
			listBox3.Items.Add(Fiscal.Mensaje);			
			InformacionAdicional();
			bttnCerrarImpFis2.Enabled = true;
			bttnAbrirImpFis2.Enabled = false;
			butImpresionRapida.Enabled = true;
		}

		private void butImpresionRapida_Click(object sender, System.EventArgs e)
		{			
			int copias = Convert.ToInt32(txtCopiasFacturas.Text);
			for (int i = 0; i < copias; i++)
			{
				ImpresionRapida();
			}			
		}

		private void bttnCerrarImpFis2_Click(object sender, System.EventArgs e)
		{
			//German 20100618
			//Fiscal.CerrarImpFis();	
			Fiscal.CerrarImpFis(new ArrayList());	
			//Fin German 20100618
			listBox3.Items.Add(Fiscal.Mensaje);	
			bttnAbrirImpFis2.Enabled = true;
			bttnCerrarImpFis2.Enabled = false;
			butImpresionRapida.Enabled = false;
		}

		private void butDatosConf_Click(object sender, System.EventArgs e)
		{
			ConfiguracionImpresora ci = new ConfiguracionImpresora();			
			ci.Cabecera1 = "linea1";
			ci.Cabecera2 = "linea2";
			Fiscal.CargarConfiguracion(ci);

			Fiscal.ObtenerConfiguracion(ci);
			string cabecera1 = ci.Cabecera1;
			string cabecera2 = ci.Cabecera1;
			string pavada = "";			
			
		}

		private void ImpresionRapida()
		{
			listBox2.Items.Clear();
			bttnAbrirImpFis2.Enabled = false;
			bttnCerrarImpFis2.Enabled = true;

			//APERTURA COMPROBANTE FISCAL
			ClienteFiscal clifis = new ClienteFiscal(IR_CodImpFis);					

			clifis.Nombre = txtCliente2.Text;
			clifis.Direccion = txtDireccion2.Text;
			clifis.CondIVA = IR_CodCliTipo;
			clifis.DocNumero = txtDocumento2.Text;
			clifis.DocTipo = IR_TipoDocumento;
			Fiscal.LinVar1 = "";
			Fiscal.LinVar2 = "";
			Fiscal.LinVar3 = "";
			Fiscal.LinVar4 = "";
			Fiscal.LinPie1 = "";
			Fiscal.LinPie2 = "";
			Fiscal.LinPie3 = "";
			Fiscal.LinPie4 = "";
			
			Fiscal.NumAsoc1 = "";
			Fiscal.NumAsoc2 = "";
			Fiscal.NumAsoc3 = "";
			Fiscal.NumAsoc4 = "";

			if (IR_CodCompTipo == 3)
				Fiscal.NumAsoc1 = "FA";

			if (Fiscal.AbrirComp(IR_CodCompTipo, 0, clifis))
			{
				listBox2.Items.Add(Fiscal.EstadoFiscal);
				listBox2.Items.Add("--------------------------------------------------");
				listBox2.Items.Add(Fiscal.Mensaje + ' ' + Fiscal.CompAbrev + ' ' + Fiscal.CompClase.ToString() + ' ' + Fiscal.CompNumeroD);
			}
			else 
			{
				listBox2.Items.Add(Fiscal.Mensaje);
			}
			InformacionAdicional();
			//FIN APERTURA COMPROBANTE FISCAL

			//IMPRESION DE ITEM FISCAL
			ItemFiscal item = new ItemFiscal();
			item.Descripcion = txtDescripcionItem.Text;			
			item.Cantidad = 1;
			item.Monto = Decimal.Parse("0.01");
			item.IVA = Decimal.Parse("21");
			item.ImpuestosInternos = 0;
			item.TasaAjusteVariable = 0;

			item.Diferencia = 'D';			
			
			item.MontoDif = 0;
			item.DescripcionDif = "";
			item.TextoFiscal = "";
			Fiscal.GrabarItem(item);			
			listBox2.Items.Add(Fiscal.Mensaje);	
			//FIN IMPRESION DE ITEM FISCAL

			//CIERRE DE COMPROBANTE
			Fiscal.Copias = Convert.ToByte(txtCopias.Text);					
			Fiscal.CerrarComp();
			listBox2.Items.Add(Fiscal.Mensaje + ' ' + Fiscal.CompAbrev + ' ' + Fiscal.CompClase.ToString() + ' ' + Fiscal.CompNumeroD);
			InformacionAdicional();
			//FIN CIERRE DE COMPROBANTE

		}

		private void frmTestFiscal_Load(object sender, System.EventArgs e)
		{
		
		}

		private void vScrollBar1_ValueChanged(object sender, System.EventArgs e)
		{		
			txtCopiasFacturas.Text = Convert.ToString(vScrollBar1.Value);				
		}

		private void vScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
		
		}
	}
}

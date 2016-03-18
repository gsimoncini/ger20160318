using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using System.Drawing;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.systemframework;
using mz.erp.businessrules;
using mz.erp.ui;
using mz.erp.ui.controls;
using mz.erp.ui.utility;
using mz.erp.ui.controllers;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// en la hash se busca con la descripcion del tdcomptesoreria
	/// al guardar la variable se guarda con el resultado del MAPStaticInfo.getFDP
	/// </summary>
	public class FrmABMFormasDePago : mz.erp.ui.forms.FrmAMB
	{

		#region variables de ventana
	
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.CheckBox chkAgrupado;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		string _descripcion;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckedListBox lista1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckedListBox lista2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckedListBox lista3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.CheckedListBox lista4;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private mz.erp.ui.controls.mzComboEditor mzCmbPerfiles;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label16;
		private mz.erp.ui.controls.mzComboEditor mzCmbProceso;
		private mz.erp.ui.controls.mzComboEditor mzCmbTarea;
		private Infragistics.Win.Misc.UltraButton bBuscar;
		private System.Windows.Forms.Label label4;
		private Infragistics.Win.Misc.UltraButton bCopiar;
		private mz.erp.ui.controls.mzComboEditor mzCmbTareaCopiar;
		private mz.erp.ui.controls.mzComboEditor mzCmbProcesoCopiar;
		private mz.erp.ui.controls.mzComboEditor mzCmbPerfilCopiar;
		private System.Windows.Forms.Label label18;
		private mz.erp.ui.controls.mzComboEditor mzCmbTDComp;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.CheckedListBox listaListaTDComp;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private Infragistics.Win.Misc.UltraButton bGuardarEnHash;
		private System.Windows.Forms.RadioButton rbCheque;
		private System.Windows.Forms.RadioButton rbNinguno;
		private System.Windows.Forms.RadioButton rbTarjeta;
		private System.Windows.Forms.RadioButton rbRetencion;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.CheckedListBox listaEntidades;
		private Infragistics.Win.Misc.UltraButton ubNingunoCondicionesDeVentas;
		private Infragistics.Win.Misc.UltraButton ubTodosCondicionesDeVentas;
		private mz.erp.ui.controls.ToolTipCheckedListBox chkListCondicionesDeVentas;
		private System.Windows.Forms.Label label24;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private mz.erp.ui.controls.mzCuentasControl mzCuentasControl1;
		private System.Windows.Forms.Label label25;
		private mz.erp.ui.controls.ToolTipCheckedListBox chkListTiposDeComprobantes;
		private Janus.Windows.GridEX.GridEX gridClientes;
		private Infragistics.Win.Misc.UltraButton bNingunoTiposDeComprobantes;
		private Infragistics.Win.Misc.UltraButton bTodosTiposDeComprobantes;
	
		private System.ComponentModel.Container components = null;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ubAgregarCuenta;
		private Infragistics.Win.Misc.UltraButton ultraButton1;
		private System.Windows.Forms.RadioButton rbMetodoComparacionPorI;
		private System.Windows.Forms.RadioButton rbMetodoComparacionPorE;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.RadioButton rbMetAsigTipCompPorI;
		private System.Windows.Forms.RadioButton rbMetAsigTipCompPorE;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton rbMetAsigCuentaPorI;
		private System.Windows.Forms.RadioButton rbMetAsigCuentaPorE;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneRecargo;
		private System.Windows.Forms.Label label31;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor numericEditorcuotas;
		private mz.erp.ui.controls.mzComboEditor mzCEFamiliaFormaDePago;
		private mz.erp.ui.controls.mzComboEditor mzCEComprobanteTesoreria;
		private System.Windows.Forms.TextBox txtClaveCorta;
		private System.Windows.Forms.TextBox txtClaveLarga;
		private System.Windows.Forms.CheckBox chkActivo;
		private System.Windows.Forms.Label labelClaveCorta;
		private System.Windows.Forms.Label labelClaveLarga;
		private System.Windows.Forms.Label labelActivo;
		private ABMFormasDePagoController _uiController = null;

		#endregion

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ubAgregarCuenta = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.label26 = new System.Windows.Forms.Label();
			this.rbMetodoComparacionPorI = new System.Windows.Forms.RadioButton();
			this.rbMetodoComparacionPorE = new System.Windows.Forms.RadioButton();
			this.label24 = new System.Windows.Forms.Label();
			this.ubNingunoCondicionesDeVentas = new Infragistics.Win.Misc.UltraButton();
			this.ubTodosCondicionesDeVentas = new Infragistics.Win.Misc.UltraButton();
			this.chkListCondicionesDeVentas = new mz.erp.ui.controls.ToolTipCheckedListBox();
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label28 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.rbMetAsigCuentaPorI = new System.Windows.Forms.RadioButton();
			this.rbMetAsigCuentaPorE = new System.Windows.Forms.RadioButton();
			this.label27 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbMetAsigTipCompPorI = new System.Windows.Forms.RadioButton();
			this.rbMetAsigTipCompPorE = new System.Windows.Forms.RadioButton();
			this.ultraButton1 = new Infragistics.Win.Misc.UltraButton();
			this.gridClientes = new Janus.Windows.GridEX.GridEX();
			this.mzCuentasControl1 = new mz.erp.ui.controls.mzCuentasControl();
			this.label25 = new System.Windows.Forms.Label();
			this.bNingunoTiposDeComprobantes = new Infragistics.Win.Misc.UltraButton();
			this.bTodosTiposDeComprobantes = new Infragistics.Win.Misc.UltraButton();
			this.chkListTiposDeComprobantes = new mz.erp.ui.controls.ToolTipCheckedListBox();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label19 = new System.Windows.Forms.Label();
			this.listaListaTDComp = new System.Windows.Forms.CheckedListBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.bGuardarEnHash = new Infragistics.Win.Misc.UltraButton();
			this.label4 = new System.Windows.Forms.Label();
			this.bCopiar = new Infragistics.Win.Misc.UltraButton();
			this.mzCmbTareaCopiar = new mz.erp.ui.controls.mzComboEditor();
			this.mzCmbProcesoCopiar = new mz.erp.ui.controls.mzComboEditor();
			this.mzCmbPerfilCopiar = new mz.erp.ui.controls.mzComboEditor();
			this.bBuscar = new Infragistics.Win.Misc.UltraButton();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.mzCmbTarea = new mz.erp.ui.controls.mzComboEditor();
			this.mzCmbProceso = new mz.erp.ui.controls.mzComboEditor();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.mzCmbPerfiles = new mz.erp.ui.controls.mzComboEditor();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lista4 = new System.Windows.Forms.CheckedListBox();
			this.lista3 = new System.Windows.Forms.CheckedListBox();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.lista2 = new System.Windows.Forms.CheckedListBox();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.lista1 = new System.Windows.Forms.CheckedListBox();
			this.label7 = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.listaEntidades = new System.Windows.Forms.CheckedListBox();
			this.label23 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.chkAgrupado = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.mzCmbTDComp = new mz.erp.ui.controls.mzComboEditor();
			this.rbCheque = new System.Windows.Forms.RadioButton();
			this.rbNinguno = new System.Windows.Forms.RadioButton();
			this.rbTarjeta = new System.Windows.Forms.RadioButton();
			this.rbRetencion = new System.Windows.Forms.RadioButton();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.uneRecargo = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.numericEditorcuotas = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label31 = new System.Windows.Forms.Label();
			this.mzCEFamiliaFormaDePago = new mz.erp.ui.controls.mzComboEditor();
			this.mzCEComprobanteTesoreria = new mz.erp.ui.controls.mzComboEditor();
			this.txtClaveCorta = new System.Windows.Forms.TextBox();
			this.txtClaveLarga = new System.Windows.Forms.TextBox();
			this.labelClaveCorta = new System.Windows.Forms.Label();
			this.labelClaveLarga = new System.Windows.Forms.Label();
			this.labelActivo = new System.Windows.Forms.Label();
			this.chkActivo = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.ubAgregarCuenta.SuspendLayout();
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTareaCopiar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbProcesoCopiar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbPerfilCopiar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTarea)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbProceso)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbPerfiles)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTDComp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneRecargo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericEditorcuotas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEFamiliaFormaDePago)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEComprobanteTesoreria)).BeginInit();
			this.SuspendLayout();
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Controls.Add(this.ubAgregarCuenta);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
			ultraExplorerBarGroup1.Container = this.ubAgregarCuenta;
			ultraExplorerBarGroup1.Expanded = false;
			ultraExplorerBarGroup1.Key = "CVAsociadas";
			ultraExplorerBarGroup1.Settings.ContainerHeight = 152;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Condiciones de Ventas Asociadas";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl5;
			ultraExplorerBarGroup2.Expanded = false;
			ultraExplorerBarGroup2.Key = "TCAsociados";
			ultraExplorerBarGroup2.Settings.ContainerHeight = 358;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Tipos de Comprobantes y Clientes Asociados";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup3.Key = "VAsociadas";
			ultraExplorerBarGroup3.Settings.ContainerHeight = 680;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Variables asociadas";
			ultraExplorerBarGroup3.ToolTipText = "Esta solapa lo guiará en la configuración de las variables de sistema.";
			ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup4.Key = "EAsociadas";
			ultraExplorerBarGroup4.Settings.ContainerHeight = 117;
			ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup4.Text = "Entidades asociadas a la Forma de Pago";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3,
																														ultraExplorerBarGroup4});
			this.ultraExplorerBar1.GroupSettings.ForceSerialization = true;
			this.ultraExplorerBar1.ItemSettings.ForceSerialization = true;
			this.ultraExplorerBar1.Margins.ForceSerialization = true;
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(976, 450);
			this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl5, 0);
			this.ultraExplorerBar1.Controls.SetChildIndex(this.ubAgregarCuenta, 0);
			this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl3, 0);
			this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl2, 0);
			this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl1, 0);
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.labelActivo);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkActivo);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.labelClaveLarga);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.labelClaveCorta);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtClaveLarga);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtClaveCorta);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEFamiliaFormaDePago);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEComprobanteTesoreria);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.numericEditorcuotas);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uneRecargo);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label30);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label29);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label22);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label21);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.rbRetencion);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.rbTarjeta);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.rbNinguno);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.rbCheque);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbTDComp);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label18);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkAgrupado);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtDescripcion);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label31);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(910, 159);
			this.ultraExplorerBarContainerControl1.TabStop = false;
			this.ultraExplorerBarContainerControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.ultraExplorerBarContainerControl1_Paint);
			// 
			// ubAgregarCuenta
			// 
			this.ubAgregarCuenta.Controls.Add(this.label26);
			this.ubAgregarCuenta.Controls.Add(this.rbMetodoComparacionPorI);
			this.ubAgregarCuenta.Controls.Add(this.rbMetodoComparacionPorE);
			this.ubAgregarCuenta.Controls.Add(this.label24);
			this.ubAgregarCuenta.Controls.Add(this.ubNingunoCondicionesDeVentas);
			this.ubAgregarCuenta.Controls.Add(this.ubTodosCondicionesDeVentas);
			this.ubAgregarCuenta.Controls.Add(this.chkListCondicionesDeVentas);
			this.ubAgregarCuenta.Location = new System.Drawing.Point(28, 267);
			this.ubAgregarCuenta.Name = "ubAgregarCuenta";
			this.ubAgregarCuenta.Size = new System.Drawing.Size(910, 152);
			this.ubAgregarCuenta.TabIndex = 3;
			// 
			// label26
			// 
			this.label26.BackColor = System.Drawing.Color.Transparent;
			this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label26.Location = new System.Drawing.Point(0, 0);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(152, 16);
			this.label26.TabIndex = 24;
			this.label26.Text = "Método de Comparación";
			// 
			// rbMetodoComparacionPorI
			// 
			this.rbMetodoComparacionPorI.AccessibleDescription = "";
			this.rbMetodoComparacionPorI.BackColor = System.Drawing.Color.Transparent;
			this.rbMetodoComparacionPorI.Location = new System.Drawing.Point(272, 0);
			this.rbMetodoComparacionPorI.Name = "rbMetodoComparacionPorI";
			this.rbMetodoComparacionPorI.Size = new System.Drawing.Size(104, 16);
			this.rbMetodoComparacionPorI.TabIndex = 23;
			this.rbMetodoComparacionPorI.Text = "Por Inclusión";
			// 
			// rbMetodoComparacionPorE
			// 
			this.rbMetodoComparacionPorE.BackColor = System.Drawing.Color.Transparent;
			this.rbMetodoComparacionPorE.Location = new System.Drawing.Point(160, 0);
			this.rbMetodoComparacionPorE.Name = "rbMetodoComparacionPorE";
			this.rbMetodoComparacionPorE.Size = new System.Drawing.Size(104, 16);
			this.rbMetodoComparacionPorE.TabIndex = 22;
			this.rbMetodoComparacionPorE.Text = "Por Exclusión";
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.Transparent;
			this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label24.Location = new System.Drawing.Point(592, 40);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(232, 88);
			this.label24.TabIndex = 14;
			this.label24.Text = "Seleccione la/s condicion/es de venta/s  a la/s cual/es se asocia la nueva forma " +
				"de pago";
			// 
			// ubNingunoCondicionesDeVentas
			// 
			this.ubNingunoCondicionesDeVentas.AcceptsFocus = false;
			this.ubNingunoCondicionesDeVentas.Location = new System.Drawing.Point(0, 88);
			this.ubNingunoCondicionesDeVentas.Name = "ubNingunoCondicionesDeVentas";
			this.ubNingunoCondicionesDeVentas.Size = new System.Drawing.Size(64, 22);
			this.ubNingunoCondicionesDeVentas.TabIndex = 13;
			this.ubNingunoCondicionesDeVentas.TabStop = false;
			this.ubNingunoCondicionesDeVentas.Text = "&Ninguno";
			// 
			// ubTodosCondicionesDeVentas
			// 
			this.ubTodosCondicionesDeVentas.AcceptsFocus = false;
			this.ubTodosCondicionesDeVentas.Location = new System.Drawing.Point(0, 64);
			this.ubTodosCondicionesDeVentas.Name = "ubTodosCondicionesDeVentas";
			this.ubTodosCondicionesDeVentas.Size = new System.Drawing.Size(64, 22);
			this.ubTodosCondicionesDeVentas.TabIndex = 12;
			this.ubTodosCondicionesDeVentas.TabStop = false;
			this.ubTodosCondicionesDeVentas.Text = "&Todos";
			// 
			// chkListCondicionesDeVentas
			// 
			this.chkListCondicionesDeVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chkListCondicionesDeVentas.Location = new System.Drawing.Point(64, 24);
			this.chkListCondicionesDeVentas.MultiColumn = true;
			this.chkListCondicionesDeVentas.Name = "chkListCondicionesDeVentas";
			this.chkListCondicionesDeVentas.Size = new System.Drawing.Size(520, 124);
			this.chkListCondicionesDeVentas.TabIndex = 11;
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Controls.Add(this.panel3);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.label28);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.panel2);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.label27);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.panel1);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.ultraButton1);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.mzCuentasControl1);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.label25);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.bNingunoTiposDeComprobantes);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.bTodosTiposDeComprobantes);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.chkListTiposDeComprobantes);
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 307);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(910, 358);
			this.ultraExplorerBarContainerControl5.TabIndex = 4;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Transparent;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Location = new System.Drawing.Point(0, 160);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(904, 1);
			this.panel3.TabIndex = 33;
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.Color.Transparent;
			this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label28.Location = new System.Drawing.Point(0, 179);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(128, 16);
			this.label28.TabIndex = 32;
			this.label28.Text = "Método de Asignación";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.Controls.Add(this.rbMetAsigCuentaPorI);
			this.panel2.Controls.Add(this.rbMetAsigCuentaPorE);
			this.panel2.Location = new System.Drawing.Point(136, 176);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(376, 24);
			this.panel2.TabIndex = 31;
			// 
			// rbMetAsigCuentaPorI
			// 
			this.rbMetAsigCuentaPorI.AccessibleDescription = "";
			this.rbMetAsigCuentaPorI.BackColor = System.Drawing.Color.Transparent;
			this.rbMetAsigCuentaPorI.Location = new System.Drawing.Point(144, 5);
			this.rbMetAsigCuentaPorI.Name = "rbMetAsigCuentaPorI";
			this.rbMetAsigCuentaPorI.Size = new System.Drawing.Size(104, 16);
			this.rbMetAsigCuentaPorI.TabIndex = 23;
			this.rbMetAsigCuentaPorI.Text = "Por Inclusión";
			// 
			// rbMetAsigCuentaPorE
			// 
			this.rbMetAsigCuentaPorE.BackColor = System.Drawing.Color.Transparent;
			this.rbMetAsigCuentaPorE.Location = new System.Drawing.Point(16, 5);
			this.rbMetAsigCuentaPorE.Name = "rbMetAsigCuentaPorE";
			this.rbMetAsigCuentaPorE.Size = new System.Drawing.Size(104, 16);
			this.rbMetAsigCuentaPorE.TabIndex = 22;
			this.rbMetAsigCuentaPorE.Text = "Por Exclusión";
			// 
			// label27
			// 
			this.label27.BackColor = System.Drawing.Color.Transparent;
			this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label27.Location = new System.Drawing.Point(0, 5);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(128, 16);
			this.label27.TabIndex = 30;
			this.label27.Text = "Método de Asignación";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.rbMetAsigTipCompPorI);
			this.panel1.Controls.Add(this.rbMetAsigTipCompPorE);
			this.panel1.Location = new System.Drawing.Point(136, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(376, 24);
			this.panel1.TabIndex = 29;
			// 
			// rbMetAsigTipCompPorI
			// 
			this.rbMetAsigTipCompPorI.AccessibleDescription = "";
			this.rbMetAsigTipCompPorI.BackColor = System.Drawing.Color.Transparent;
			this.rbMetAsigTipCompPorI.Location = new System.Drawing.Point(144, 5);
			this.rbMetAsigTipCompPorI.Name = "rbMetAsigTipCompPorI";
			this.rbMetAsigTipCompPorI.Size = new System.Drawing.Size(104, 16);
			this.rbMetAsigTipCompPorI.TabIndex = 23;
			this.rbMetAsigTipCompPorI.Text = "Por Inclusión";
			// 
			// rbMetAsigTipCompPorE
			// 
			this.rbMetAsigTipCompPorE.BackColor = System.Drawing.Color.Transparent;
			this.rbMetAsigTipCompPorE.Location = new System.Drawing.Point(16, 5);
			this.rbMetAsigTipCompPorE.Name = "rbMetAsigTipCompPorE";
			this.rbMetAsigTipCompPorE.Size = new System.Drawing.Size(104, 16);
			this.rbMetAsigTipCompPorE.TabIndex = 22;
			this.rbMetAsigTipCompPorE.Text = "Por Exclusión";
			// 
			// ultraButton1
			// 
			this.ultraButton1.AcceptsFocus = false;
			this.ultraButton1.Location = new System.Drawing.Point(528, 198);
			this.ultraButton1.Name = "ultraButton1";
			this.ultraButton1.Size = new System.Drawing.Size(112, 24);
			this.ultraButton1.TabIndex = 28;
			this.ultraButton1.TabStop = false;
			this.ultraButton1.Text = "Agregar Cliente";
			// 
			// gridClientes
			// 
			this.gridClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.gridClientes.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.gridClientes.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridClientes.Location = new System.Drawing.Point(64, 224);
			this.gridClientes.Name = "gridClientes";
			this.gridClientes.Size = new System.Drawing.Size(680, 128);
			this.gridClientes.TabIndex = 27;
			this.gridClientes.TabStop = false;
			// 
			// mzCuentasControl1
			// 
			this.mzCuentasControl1.AllowEditClientePaso = false;
			this.mzCuentasControl1.BackColor = System.Drawing.SystemColors.Control;
			this.mzCuentasControl1.DataValue = "";
			this.mzCuentasControl1.EnableCtaCte = false;
			this.mzCuentasControl1.FastSearch = false;
			this.mzCuentasControl1.Location = new System.Drawing.Point(64, 200);
			this.mzCuentasControl1.Name = "mzCuentasControl1";
			this.mzCuentasControl1.SearchObjectListener = null;
			this.mzCuentasControl1.Size = new System.Drawing.Size(440, 24);
			this.mzCuentasControl1.TabIndex = 26;
			// 
			// label25
			// 
			this.label25.BackColor = System.Drawing.Color.Transparent;
			this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label25.Location = new System.Drawing.Point(592, 48);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(232, 56);
			this.label25.TabIndex = 25;
			this.label25.Text = "Seleccione lo/s Tipo/s de Comprobante/s a lo/s cual/es se asocia la nueva forma d" +
				"e pago";
			// 
			// bNingunoTiposDeComprobantes
			// 
			this.bNingunoTiposDeComprobantes.AcceptsFocus = false;
			this.bNingunoTiposDeComprobantes.Location = new System.Drawing.Point(0, 84);
			this.bNingunoTiposDeComprobantes.Name = "bNingunoTiposDeComprobantes";
			this.bNingunoTiposDeComprobantes.Size = new System.Drawing.Size(64, 22);
			this.bNingunoTiposDeComprobantes.TabIndex = 24;
			this.bNingunoTiposDeComprobantes.TabStop = false;
			this.bNingunoTiposDeComprobantes.Text = "&Ninguno";
			// 
			// bTodosTiposDeComprobantes
			// 
			this.bTodosTiposDeComprobantes.AcceptsFocus = false;
			this.bTodosTiposDeComprobantes.Location = new System.Drawing.Point(0, 62);
			this.bTodosTiposDeComprobantes.Name = "bTodosTiposDeComprobantes";
			this.bTodosTiposDeComprobantes.Size = new System.Drawing.Size(64, 22);
			this.bTodosTiposDeComprobantes.TabIndex = 23;
			this.bTodosTiposDeComprobantes.TabStop = false;
			this.bTodosTiposDeComprobantes.Text = "&Todos";
			// 
			// chkListTiposDeComprobantes
			// 
			this.chkListTiposDeComprobantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chkListTiposDeComprobantes.Location = new System.Drawing.Point(64, 24);
			this.chkListTiposDeComprobantes.MultiColumn = true;
			this.chkListTiposDeComprobantes.Name = "chkListTiposDeComprobantes";
			this.chkListTiposDeComprobantes.Size = new System.Drawing.Size(520, 124);
			this.chkListTiposDeComprobantes.TabIndex = 22;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.groupBox4);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label13);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.groupBox3);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.groupBox2);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.groupBox1);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 347);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(910, 680);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Transparent;
			this.groupBox4.Controls.Add(this.label19);
			this.groupBox4.Controls.Add(this.listaListaTDComp);
			this.groupBox4.Controls.Add(this.label20);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(0, 208);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(808, 96);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Ventana de Valores";
			// 
			// label19
			// 
			this.label19.ForeColor = System.Drawing.Color.Brown;
			this.label19.Location = new System.Drawing.Point(512, 80);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(240, 16);
			this.label19.TabIndex = 6;
			this.label19.Text = "var terminadas en ListaDeTDCompTesoreria";
			this.label19.Visible = false;
			// 
			// listaListaTDComp
			// 
			this.listaListaTDComp.ColumnWidth = 480;
			this.listaListaTDComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listaListaTDComp.Items.AddRange(new object[] {
																  ""});
			this.listaListaTDComp.Location = new System.Drawing.Point(168, 16);
			this.listaListaTDComp.Name = "listaListaTDComp";
			this.listaListaTDComp.ScrollAlwaysVisible = true;
			this.listaListaTDComp.Size = new System.Drawing.Size(608, 79);
			this.listaListaTDComp.TabIndex = 6;
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label20.Location = new System.Drawing.Point(8, 21);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(152, 68);
			this.label20.TabIndex = 3;
			this.label20.Text = "Marque aquellos procesos en donde esta forma de pago debe estar disponible";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label13.Location = new System.Drawing.Point(816, 592);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(448, 64);
			this.label13.TabIndex = 11;
			this.label13.Text = @"Momentos.PagoACuenta.XXX.ObligaDatosValor (solo para retenciones)
Momentos.SeleccionarFormasDePagos.XXX.ObligaVarAuxiliares
Momentos.SeleccionarFormasDePagos.XXX.ObligaDatosValor
Momentos.MovimientoCaja.XXX.ObligaDatosValor
Momentos.MovimientoCaja.XXX.ObligaVarAuxiliares";
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.bGuardarEnHash);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.bCopiar);
			this.groupBox3.Controls.Add(this.mzCmbTareaCopiar);
			this.groupBox3.Controls.Add(this.mzCmbProcesoCopiar);
			this.groupBox3.Controls.Add(this.mzCmbPerfilCopiar);
			this.groupBox3.Controls.Add(this.bBuscar);
			this.groupBox3.Controls.Add(this.label16);
			this.groupBox3.Controls.Add(this.label17);
			this.groupBox3.Controls.Add(this.mzCmbTarea);
			this.groupBox3.Controls.Add(this.mzCmbProceso);
			this.groupBox3.Controls.Add(this.label15);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.mzCmbPerfiles);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.lista4);
			this.groupBox3.Controls.Add(this.lista3);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(0, 304);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(808, 368);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Ventana de Valores en:  Caja / Movimientos de caja /  Egreso e Ingreso ";
			// 
			// bGuardarEnHash
			// 
			this.bGuardarEnHash.AcceptsFocus = false;
			this.bGuardarEnHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bGuardarEnHash.Location = new System.Drawing.Point(712, 280);
			this.bGuardarEnHash.Name = "bGuardarEnHash";
			this.bGuardarEnHash.Size = new System.Drawing.Size(64, 22);
			this.bGuardarEnHash.TabIndex = 26;
			this.bGuardarEnHash.TabStop = false;
			this.bGuardarEnHash.Text = "&Guardar";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 304);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 54);
			this.label4.TabIndex = 25;
			this.label4.Text = "Seleccione el perfil , la tarea y el proceso al cual desea copiar la configuració" +
				"n anterior";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// bCopiar
			// 
			this.bCopiar.AcceptsFocus = false;
			this.bCopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bCopiar.Location = new System.Drawing.Point(616, 336);
			this.bCopiar.Name = "bCopiar";
			this.bCopiar.Size = new System.Drawing.Size(152, 22);
			this.bCopiar.TabIndex = 16;
			this.bCopiar.TabStop = false;
			this.bCopiar.Text = "&Copiar Configuración";
			this.bCopiar.Click += new System.EventHandler(this.bCopiar_Click_1);
			// 
			// mzCmbTareaCopiar
			// 
			this.mzCmbTareaCopiar.AutoComplete = true;
			this.mzCmbTareaCopiar.DataSource = null;
			this.mzCmbTareaCopiar.DisplayMember = "";
			this.mzCmbTareaCopiar.DisplayMemberCaption = "";
			this.mzCmbTareaCopiar.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbTareaCopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbTareaCopiar.Location = new System.Drawing.Point(168, 336);
			this.mzCmbTareaCopiar.MaxItemsDisplay = 200;
			this.mzCmbTareaCopiar.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbTareaCopiar.Name = "mzCmbTareaCopiar";
			this.mzCmbTareaCopiar.Size = new System.Drawing.Size(216, 21);
			this.mzCmbTareaCopiar.SorterMember = "";
			this.mzCmbTareaCopiar.TabIndex = 14;
			this.mzCmbTareaCopiar.ValueMember = "";
			this.mzCmbTareaCopiar.ValueMemberCaption = "";
			// 
			// mzCmbProcesoCopiar
			// 
			this.mzCmbProcesoCopiar.AutoComplete = true;
			this.mzCmbProcesoCopiar.DataSource = null;
			this.mzCmbProcesoCopiar.DisplayMember = "";
			this.mzCmbProcesoCopiar.DisplayMemberCaption = "";
			this.mzCmbProcesoCopiar.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbProcesoCopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbProcesoCopiar.Location = new System.Drawing.Point(392, 336);
			this.mzCmbProcesoCopiar.MaxItemsDisplay = 200;
			this.mzCmbProcesoCopiar.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbProcesoCopiar.Name = "mzCmbProcesoCopiar";
			this.mzCmbProcesoCopiar.Size = new System.Drawing.Size(216, 21);
			this.mzCmbProcesoCopiar.SorterMember = "";
			this.mzCmbProcesoCopiar.TabIndex = 15;
			this.mzCmbProcesoCopiar.ValueMember = "";
			this.mzCmbProcesoCopiar.ValueMemberCaption = "";
			// 
			// mzCmbPerfilCopiar
			// 
			this.mzCmbPerfilCopiar.AutoComplete = true;
			this.mzCmbPerfilCopiar.DataSource = null;
			this.mzCmbPerfilCopiar.DisplayMember = "";
			this.mzCmbPerfilCopiar.DisplayMemberCaption = "";
			this.mzCmbPerfilCopiar.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbPerfilCopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbPerfilCopiar.Location = new System.Drawing.Point(168, 304);
			this.mzCmbPerfilCopiar.MaxItemsDisplay = 200;
			this.mzCmbPerfilCopiar.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbPerfilCopiar.Name = "mzCmbPerfilCopiar";
			this.mzCmbPerfilCopiar.Size = new System.Drawing.Size(216, 21);
			this.mzCmbPerfilCopiar.SorterMember = "";
			this.mzCmbPerfilCopiar.TabIndex = 13;
			this.mzCmbPerfilCopiar.ValueMember = "";
			this.mzCmbPerfilCopiar.ValueMemberCaption = "";
			// 
			// bBuscar
			// 
			this.bBuscar.AcceptsFocus = false;
			this.bBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bBuscar.Location = new System.Drawing.Point(616, 80);
			this.bBuscar.Name = "bBuscar";
			this.bBuscar.Size = new System.Drawing.Size(152, 22);
			this.bBuscar.TabIndex = 10;
			this.bBuscar.TabStop = false;
			this.bBuscar.Text = "&Buscar variables asociadas";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label16.Location = new System.Drawing.Point(8, 77);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(144, 27);
			this.label16.TabIndex = 19;
			this.label16.Text = "Seleccione la tarea y el proceso";
			this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label17.Location = new System.Drawing.Point(168, 104);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(456, 16);
			this.label17.TabIndex = 18;
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mzCmbTarea
			// 
			this.mzCmbTarea.AutoComplete = true;
			this.mzCmbTarea.DataSource = null;
			this.mzCmbTarea.DisplayMember = "";
			this.mzCmbTarea.DisplayMemberCaption = "";
			this.mzCmbTarea.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbTarea.Location = new System.Drawing.Point(168, 80);
			this.mzCmbTarea.MaxItemsDisplay = 200;
			this.mzCmbTarea.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbTarea.Name = "mzCmbTarea";
			this.mzCmbTarea.Size = new System.Drawing.Size(216, 21);
			this.mzCmbTarea.SorterMember = "";
			this.mzCmbTarea.TabIndex = 8;
			this.mzCmbTarea.ValueMember = "";
			this.mzCmbTarea.ValueMemberCaption = "";
			// 
			// mzCmbProceso
			// 
			this.mzCmbProceso.AutoComplete = true;
			this.mzCmbProceso.DataSource = null;
			this.mzCmbProceso.DisplayMember = "";
			this.mzCmbProceso.DisplayMemberCaption = "";
			this.mzCmbProceso.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbProceso.Location = new System.Drawing.Point(392, 80);
			this.mzCmbProceso.MaxItemsDisplay = 200;
			this.mzCmbProceso.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbProceso.Name = "mzCmbProceso";
			this.mzCmbProceso.Size = new System.Drawing.Size(216, 21);
			this.mzCmbProceso.SorterMember = "";
			this.mzCmbProceso.TabIndex = 9;
			this.mzCmbProceso.ValueMember = "";
			this.mzCmbProceso.ValueMemberCaption = "";
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label15.Location = new System.Drawing.Point(464, 39);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(312, 22);
			this.label15.TabIndex = 13;
			this.label15.Text = "Nota: para configurar varios perfiles solo cambie de perfil y marque los campos e" +
				"n  las grillas inferiores";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label14.Location = new System.Drawing.Point(8, 29);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(144, 42);
			this.label14.TabIndex = 12;
			this.label14.Text = "Seleccione el perfil al cual se aplicará esta configuración";
			this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// mzCmbPerfiles
			// 
			this.mzCmbPerfiles.AutoComplete = true;
			this.mzCmbPerfiles.DataSource = null;
			this.mzCmbPerfiles.DisplayMember = "";
			this.mzCmbPerfiles.DisplayMemberCaption = "";
			this.mzCmbPerfiles.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbPerfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbPerfiles.Location = new System.Drawing.Point(168, 40);
			this.mzCmbPerfiles.MaxItemsDisplay = 200;
			this.mzCmbPerfiles.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbPerfiles.Name = "mzCmbPerfiles";
			this.mzCmbPerfiles.Size = new System.Drawing.Size(216, 21);
			this.mzCmbPerfiles.SorterMember = "";
			this.mzCmbPerfiles.TabIndex = 7;
			this.mzCmbPerfiles.ValueMember = "";
			this.mzCmbPerfiles.ValueMemberCaption = "";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.Location = new System.Drawing.Point(8, 210);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(144, 42);
			this.label12.TabIndex = 8;
			this.label12.Text = "Marque los campos auxiliares de la forma de pago que son obligatorios";
			this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label11
			// 
			this.label11.ForeColor = System.Drawing.Color.Brown;
			this.label11.Location = new System.Drawing.Point(552, 264);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(224, 16);
			this.label11.TabIndex = 6;
			this.label11.Text = "AAAAAAAA . XXX . ObligaVarAuxiliares";
			this.label11.Visible = false;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.Brown;
			this.label6.Location = new System.Drawing.Point(576, 160);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(200, 16);
			this.label6.TabIndex = 4;
			this.label6.Text = "AAAAAAA . XXX . ObligaDatosValor ";
			this.label6.Visible = false;
			// 
			// lista4
			// 
			this.lista4.ColumnWidth = 200;
			this.lista4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lista4.Items.AddRange(new object[] {
														"CODIGO_AUT_TC_TD_TCCUO_",
														"CUPON_TC_TD_TCCUO_",
														"FECHA_ACREDIT_TC_TCCUO_",
														"FECHA_AUT_TC_TD_TCCUO_",
														"LOTE_TC_TD_TCCUO_",
														"CANTIDAD_CUOTAS_TCCUO_",
														"CTA_BANCARIA_CHE_T_C_DT_D_",
														"LIBRADOR_CHE_T_DT_",
														"SUCURSAL_CHE_T_C_DT_D_",
														"FECHA_PAGO_CHE_T_DT_",
														"FECHA_RECEP_CHE_T_C_DT_D_",
														"TIPO_RETENCION_RET_",
														"FECHA_INGRESO_RET_",
														"FECHA_COMP_RET_",
														"NROBOLETA_CHE_T_C_DT_D_",
														"FECHAINGBANCO_CHE_T_C_DT_D_",
														"CODIGO10_TC_TD_TCCUO_"});
			this.lista4.Location = new System.Drawing.Point(168, 184);
			this.lista4.MultiColumn = true;
			this.lista4.Name = "lista4";
			this.lista4.Size = new System.Drawing.Size(608, 94);
			this.lista4.TabIndex = 12;
			// 
			// lista3
			// 
			this.lista3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lista3.Items.AddRange(new object[] {
														"Entidad",
														"Numero"});
			this.lista3.Location = new System.Drawing.Point(168, 128);
			this.lista3.MultiColumn = true;
			this.lista3.Name = "lista3";
			this.lista3.Size = new System.Drawing.Size(608, 49);
			this.lista3.TabIndex = 11;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(8, 131);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(144, 42);
			this.label10.TabIndex = 3;
			this.label10.Text = "Marque los campos principales de la forma de pago que son obligatorios ";
			this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.lista2);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(0, 112);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(808, 96);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Ventana de Valores";
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.Brown;
			this.label5.Location = new System.Drawing.Point(504, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(272, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Momentos.ValorDatoAuxiliar.XXX.CamposVisibles";
			this.label5.Visible = false;
			// 
			// lista2
			// 
			this.lista2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lista2.Items.AddRange(new object[] {
														"codigoAutorizacion",
														"cupon",
														"fechaAcreditacion",
														"fechaAutorizacion",
														"lote",
														"cantidadCuotas",
														"codigoDiez",
														"cuentaBancaria",
														"librador",
														"sucursal",
														"fechaPago",
														"fechaIngresoBanco",
														"fechaRecepcion",
														"NroBoleta"});
			this.lista2.Location = new System.Drawing.Point(168, 16);
			this.lista2.MultiColumn = true;
			this.lista2.Name = "lista2";
			this.lista2.Size = new System.Drawing.Size(608, 79);
			this.lista2.TabIndex = 5;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(8, 21);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(152, 68);
			this.label9.TabIndex = 3;
			this.label9.Text = "Marque los campos que se deben mostrar en la ventana de VALORES (en la sección de" +
				" datos auxiliares) para esta foma de pago";
			this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.lista1);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(808, 112);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Caja / Movimientos de caja / Modificar datos auxiliares";
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.Color.Brown;
			this.label8.Location = new System.Drawing.Point(384, 96);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(392, 16);
			this.label8.TabIndex = 4;
			this.label8.Text = "Momentos.DefinirValor.ProcesoModificarValor.XXX.CamposNoEditables";
			this.label8.Visible = false;
			// 
			// lista1
			// 
			this.lista1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lista1.Items.AddRange(new object[] {
														"entidad",
														"numero",
														"fechaEmision",
														"fechaVencimiento",
														"codigoAutorizacion",
														"cupon",
														"fechaAcreditacion",
														"fechaAutorizacion",
														"lote",
														"cantidadCuotas",
														"codigoDiez",
														"cuentaBancaria",
														"librador",
														"sucursal",
														"fechaPago",
														"fechaRecepcion",
														"nroBoleta",
														"fechaIngresoBanco",
														"fechaRetencion",
														"fechaIngresoRetencion",
														"tipoRetencion"});
			this.lista1.Location = new System.Drawing.Point(168, 16);
			this.lista1.MultiColumn = true;
			this.lista1.Name = "lista1";
			this.lista1.Size = new System.Drawing.Size(608, 94);
			this.lista1.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(8, 42);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(144, 42);
			this.label7.TabIndex = 3;
			this.label7.Text = "Marque los campos que se podrán modificar en esta opción de menú";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.listaEntidades);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.label23);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 451);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(910, 117);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// listaEntidades
			// 
			this.listaEntidades.ColumnWidth = 150;
			this.listaEntidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listaEntidades.Items.AddRange(new object[] {
																""});
			this.listaEntidades.Location = new System.Drawing.Point(168, 0);
			this.listaEntidades.Name = "listaEntidades";
			this.listaEntidades.ScrollAlwaysVisible = true;
			this.listaEntidades.Size = new System.Drawing.Size(608, 109);
			this.listaEntidades.TabIndex = 8;
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.Transparent;
			this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label23.Location = new System.Drawing.Point(8, 24);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(152, 68);
			this.label23.TabIndex = 7;
			this.label23.Text = "Seleccione todas aquellas entidades relacionadas con esta Forma de Pago";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(16, 0);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "Forma de Pago";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(120, 0);
			this.txtDescripcion.MaxLength = 50;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(192, 20);
			this.txtDescripcion.TabIndex = 1;
			this.txtDescripcion.Text = "";
			// 
			// chkAgrupado
			// 
			this.chkAgrupado.BackColor = System.Drawing.Color.Transparent;
			this.chkAgrupado.Location = new System.Drawing.Point(424, 0);
			this.chkAgrupado.Name = "chkAgrupado";
			this.chkAgrupado.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(349, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Agrupado?";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(456, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(416, 40);
			this.label3.TabIndex = 4;
			this.label3.Text = "Un forma de pago es agrupada cuando, para la transferencia entre cajas, los movim" +
				"ientos se muestran  totalizados (Ejemplo agrupado: \"Efectivo\", Ejemplo no agrupa" +
				"do: \"Cheque de terceros\" ).";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label18.Location = new System.Drawing.Point(16, 104);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(104, 14);
			this.label18.TabIndex = 5;
			this.label18.Text = "Se comporta como:";
			// 
			// mzCmbTDComp
			// 
			this.mzCmbTDComp.AutoComplete = true;
			this.mzCmbTDComp.DataSource = null;
			this.mzCmbTDComp.DisplayMember = "";
			this.mzCmbTDComp.DisplayMemberCaption = "";
			this.mzCmbTDComp.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbTDComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbTDComp.Location = new System.Drawing.Point(120, 104);
			this.mzCmbTDComp.MaxItemsDisplay = 200;
			this.mzCmbTDComp.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbTDComp.Name = "mzCmbTDComp";
			this.mzCmbTDComp.Size = new System.Drawing.Size(216, 21);
			this.mzCmbTDComp.SorterMember = "";
			this.mzCmbTDComp.TabIndex = 9;
			this.mzCmbTDComp.ValueMember = "";
			this.mzCmbTDComp.ValueMemberCaption = "";
			// 
			// rbCheque
			// 
			this.rbCheque.BackColor = System.Drawing.Color.Transparent;
			this.rbCheque.Enabled = false;
			this.rbCheque.Location = new System.Drawing.Point(120, 56);
			this.rbCheque.Name = "rbCheque";
			this.rbCheque.Size = new System.Drawing.Size(104, 16);
			this.rbCheque.TabIndex = 3;
			this.rbCheque.Text = "Cheque";
			// 
			// rbNinguno
			// 
			this.rbNinguno.BackColor = System.Drawing.Color.Transparent;
			this.rbNinguno.Enabled = false;
			this.rbNinguno.Location = new System.Drawing.Point(376, 56);
			this.rbNinguno.Name = "rbNinguno";
			this.rbNinguno.Size = new System.Drawing.Size(104, 16);
			this.rbNinguno.TabIndex = 5;
			this.rbNinguno.Text = "Efectivo";
			// 
			// rbTarjeta
			// 
			this.rbTarjeta.AccessibleDescription = "";
			this.rbTarjeta.BackColor = System.Drawing.Color.Transparent;
			this.rbTarjeta.Enabled = false;
			this.rbTarjeta.Location = new System.Drawing.Point(256, 56);
			this.rbTarjeta.Name = "rbTarjeta";
			this.rbTarjeta.Size = new System.Drawing.Size(104, 16);
			this.rbTarjeta.TabIndex = 4;
			this.rbTarjeta.Text = "Tarjeta";
			// 
			// rbRetencion
			// 
			this.rbRetencion.BackColor = System.Drawing.Color.Transparent;
			this.rbRetencion.Enabled = false;
			this.rbRetencion.Location = new System.Drawing.Point(480, 56);
			this.rbRetencion.Name = "rbRetencion";
			this.rbRetencion.Size = new System.Drawing.Size(104, 16);
			this.rbRetencion.TabIndex = 6;
			this.rbRetencion.Text = "Retención";
			this.rbRetencion.CheckedChanged += new System.EventHandler(this.rbRetencion_CheckedChanged_1);
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Location = new System.Drawing.Point(16, 72);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(100, 16);
			this.label21.TabIndex = 10;
			this.label21.Text = "Es del tipo";
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.Transparent;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label22.ForeColor = System.Drawing.Color.Brown;
			this.label22.Location = new System.Drawing.Point(592, 56);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(328, 24);
			this.label22.TabIndex = 11;
			this.label22.Text = "Permite que se muestren los paneles adecuados en VALORES";
			this.label22.Visible = false;
			// 
			// label29
			// 
			this.label29.BackColor = System.Drawing.Color.Transparent;
			this.label29.Location = new System.Drawing.Point(16, 136);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(100, 16);
			this.label29.TabIndex = 12;
			this.label29.Text = "Recargo";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label30
			// 
			this.label30.BackColor = System.Drawing.Color.Transparent;
			this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label30.Location = new System.Drawing.Point(224, 144);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(40, 16);
			this.label30.TabIndex = 14;
			this.label30.Text = "%";
			this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uneRecargo
			// 
			this.uneRecargo.Location = new System.Drawing.Point(120, 136);
			this.uneRecargo.MinValue = 0;
			this.uneRecargo.Name = "uneRecargo";
			this.uneRecargo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneRecargo.Size = new System.Drawing.Size(104, 21);
			this.uneRecargo.TabIndex = 12;
			// 
			// numericEditorcuotas
			// 
			this.numericEditorcuotas.Location = new System.Drawing.Point(440, 136);
			this.numericEditorcuotas.MaskInput = "nnnnnnnnn";
			this.numericEditorcuotas.MaxValue = 99;
			this.numericEditorcuotas.MinValue = 1;
			this.numericEditorcuotas.Name = "numericEditorcuotas";
			this.numericEditorcuotas.Size = new System.Drawing.Size(104, 21);
			this.numericEditorcuotas.TabIndex = 13;
			// 
			// label31
			// 
			this.label31.BackColor = System.Drawing.Color.Transparent;
			this.label31.Location = new System.Drawing.Point(344, 144);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(100, 16);
			this.label31.TabIndex = 17;
			this.label31.Text = "Nro Cuotas";
			this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mzCEFamiliaFormaDePago
			// 
			this.mzCEFamiliaFormaDePago.AutoComplete = true;
			this.mzCEFamiliaFormaDePago.DataSource = null;
			this.mzCEFamiliaFormaDePago.DisplayMember = "";
			this.mzCEFamiliaFormaDePago.DisplayMemberCaption = "";
			this.mzCEFamiliaFormaDePago.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEFamiliaFormaDePago.Location = new System.Drawing.Point(120, 72);
			this.mzCEFamiliaFormaDePago.MaxItemsDisplay = 7;
			this.mzCEFamiliaFormaDePago.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEFamiliaFormaDePago.Name = "mzCEFamiliaFormaDePago";
			this.mzCEFamiliaFormaDePago.Size = new System.Drawing.Size(197, 21);
			this.mzCEFamiliaFormaDePago.SorterMember = "";
			this.mzCEFamiliaFormaDePago.TabIndex = 7;
			this.mzCEFamiliaFormaDePago.ValueMember = "";
			this.mzCEFamiliaFormaDePago.ValueMemberCaption = "";
			// 
			// mzCEComprobanteTesoreria
			// 
			this.mzCEComprobanteTesoreria.AutoComplete = true;
			this.mzCEComprobanteTesoreria.DataSource = null;
			this.mzCEComprobanteTesoreria.DisplayMember = "";
			this.mzCEComprobanteTesoreria.DisplayMemberCaption = "";
			this.mzCEComprobanteTesoreria.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEComprobanteTesoreria.Location = new System.Drawing.Point(344, 72);
			this.mzCEComprobanteTesoreria.MaxItemsDisplay = 7;
			this.mzCEComprobanteTesoreria.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEComprobanteTesoreria.Name = "mzCEComprobanteTesoreria";
			this.mzCEComprobanteTesoreria.Size = new System.Drawing.Size(216, 21);
			this.mzCEComprobanteTesoreria.SorterMember = "";
			this.mzCEComprobanteTesoreria.TabIndex = 8;
			this.mzCEComprobanteTesoreria.ValueMember = "";
			this.mzCEComprobanteTesoreria.ValueMemberCaption = "";
			// 
			// txtClaveCorta
			// 
			this.txtClaveCorta.Location = new System.Drawing.Point(576, 136);
			this.txtClaveCorta.MaxLength = 50;
			this.txtClaveCorta.Name = "txtClaveCorta";
			this.txtClaveCorta.Size = new System.Drawing.Size(192, 20);
			this.txtClaveCorta.TabIndex = 14;
			this.txtClaveCorta.Text = "";
			// 
			// txtClaveLarga
			// 
			this.txtClaveLarga.Location = new System.Drawing.Point(576, 96);
			this.txtClaveLarga.MaxLength = 50;
			this.txtClaveLarga.Name = "txtClaveLarga";
			this.txtClaveLarga.Size = new System.Drawing.Size(192, 20);
			this.txtClaveLarga.TabIndex = 11;
			this.txtClaveLarga.Text = "";
			// 
			// labelClaveCorta
			// 
			this.labelClaveCorta.BackColor = System.Drawing.Color.Transparent;
			this.labelClaveCorta.Location = new System.Drawing.Point(576, 120);
			this.labelClaveCorta.Name = "labelClaveCorta";
			this.labelClaveCorta.Size = new System.Drawing.Size(100, 16);
			this.labelClaveCorta.TabIndex = 131;
			this.labelClaveCorta.Text = "Clave Corta";
			this.labelClaveCorta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelClaveLarga
			// 
			this.labelClaveLarga.BackColor = System.Drawing.Color.Transparent;
			this.labelClaveLarga.Location = new System.Drawing.Point(576, 72);
			this.labelClaveLarga.Name = "labelClaveLarga";
			this.labelClaveLarga.TabIndex = 132;
			this.labelClaveLarga.Text = "Clave Larga";
			this.labelClaveLarga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelActivo
			// 
			this.labelActivo.BackColor = System.Drawing.Color.Transparent;
			this.labelActivo.Location = new System.Drawing.Point(344, 104);
			this.labelActivo.Name = "labelActivo";
			this.labelActivo.Size = new System.Drawing.Size(64, 23);
			this.labelActivo.TabIndex = 134;
			this.labelActivo.Text = "Activo";
			this.labelActivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chkActivo
			// 
			this.chkActivo.BackColor = System.Drawing.Color.Transparent;
			this.chkActivo.Location = new System.Drawing.Point(440, 104);
			this.chkActivo.Name = "chkActivo";
			this.chkActivo.TabIndex = 10;
			// 
			// FrmABMFormasDePago
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(976, 478);
			this.Name = "FrmABMFormasDePago";
			this.Text = "FrmABMFormasDePago";
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.ubAgregarCuenta.ResumeLayout(false);
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTareaCopiar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbProcesoCopiar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbPerfilCopiar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTarea)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbProceso)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbPerfiles)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTDComp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneRecargo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericEditorcuotas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEFamiliaFormaDePago)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEComprobanteTesoreria)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region variables
		
		mz.erp.commontypes.data.sy_VariablesDataset _dataVariablesL = new sy_VariablesDataset();
		mz.erp.commontypes.data.sy_VariablesPerfilesDataset _dataVariablesPerfilesL = new sy_VariablesPerfilesDataset();
		mz.erp.commontypes.data.sy_VariablesDataset _dataVariablesABorrar = new sy_VariablesDataset();
		mz.erp.commontypes.data.sy_VariablesPerfilesDataset _dataVariablesPerfilesABorrar = new sy_VariablesPerfilesDataset();
		mz.erp.commontypes.data.tfi_TDCompTesoreria_EntidadesDataset _dataCompEntidades = new tfi_TDCompTesoreria_EntidadesDataset();
		
		Hashtable hash = new Hashtable();
		private string tipoRB = string.Empty;
		private bool _modificoDescripcion=false;
		private string _descripcionAnterior = string.Empty;
		private string _familia=string.Empty;
		private string _claveCorta=string.Empty;
		private string _jerarquiaActual=string.Empty;

		#endregion

		#region constructores y destructores
		public FrmABMFormasDePago()
		{
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
				BindingController.Clear(rbMetodoComparacionPorE,"Checked",_uiController, "MetodoComparacionXE");
				BindingController.Clear(rbMetodoComparacionPorI,"Checked",_uiController, "MetodoComparacionXI");
				BindingController.Clear(rbMetAsigCuentaPorE,"Checked",_uiController, "MetodoAsigCuentaXE");
				BindingController.Clear(rbMetAsigCuentaPorI,"Checked",_uiController, "MetodoAsigCuentaXI");
				BindingController.Clear(rbMetAsigTipCompPorE,"Checked",_uiController, "MetodoAsigTipoCompXE");
				BindingController.Clear(rbMetAsigTipCompPorI,"Checked",_uiController, "MetodoAsigTipoCompXI");
				BindingController.Clear(mzCEFamiliaFormaDePago, "Value", _uiController, "Jerarquia");
			}
			base.Dispose( disposing );
		}
		#endregion

		#region CustomMembers

		protected override void Init()
		{
			_businessRulesType = new mz.erp.businessrules.tfi_TDCompTesoreria().GetType();
			base.Init();
		}		

		protected override void InitializeMembers()
		{
			
			this._uiController = new ABMFormasDePagoController(this.State);
			this.mzCmbPerfiles.ValueChanged += new System.EventHandler(this.mzCmbPerfiles_ValueChanged);
			this.mzCmbTarea.ValueChanged += new EventHandler(mzCmbTarea_ValueChanged);
			this.mzCmbTareaCopiar.ValueChanged +=new EventHandler(mzCmbTareaCopiar_ValueChanged);
			this.mzCmbProceso.ValueChanged += new EventHandler(mzCmbProceso_ValueChanged);
			this.mzCmbTDComp.ValueChanged += new EventHandler(mzCmbTDComp_ValueChanged);
			
			this.bCopiar.Click += new EventHandler(bCopiar_Click);
			this.bBuscar.Click +=new EventHandler(bBuscar_Click);
			this.bGuardarEnHash.Click +=new EventHandler(bGuardarEnHash_Click);

			uneRecargo.Enter +=new EventHandler(uneRecargo_Enter);
			numericEditorcuotas.Enter +=new EventHandler(numericEditorcuotas_Enter);
			DeshabilitarListasPerfiles();
			txtDescripcion.MaxLength = 50;
			
			//mzCmbTDComp.FillFromDataSource( TDCompTesoreria() , "idTDCompTesoreria", "Descripcion", 30, "Descripcion");
			//mzCmbTDComp.Value = -1;
			mzCmbTDComp.Enabled=false;
			mzCmbPerfiles.FillFromDataSource( mz.erp.businessrules.sy_Perfiles.GetList().sy_Perfiles,"idPerfil","Descripcion",30,"Descripcion");
			mzCmbPerfilCopiar.FillFromDataSource( mz.erp.businessrules.sy_Perfiles.GetList().sy_Perfiles,"idPerfil","Descripcion",30,"Descripcion");
			mzCmbTarea.FillFromDataSource( mz.erp.businessrules.twf_Tareas.GetList().twf_Tareas,"idTarea","Descripcion",30,"Descripcion");
			mzCmbTareaCopiar.FillFromDataSource( mz.erp.businessrules.twf_Tareas.GetList().twf_Tareas,"idTarea","Descripcion",30,"Descripcion");
			mzCEFamiliaFormaDePago.FillFromDataSource( _uiController.GetTableFamiliasTDCompTesoreria(), "Jerarquia", "Descripcion", 100, "Descripcion");
			mzCEComprobanteTesoreria.Enabled=false;
			
			listaListaTDComp.Items.Remove(listaListaTDComp.Items[0]);
			foreach( sy_VariablesDataset.sy_VariablesRow row in  mz.erp.businessrules.sy_Variables.GetList("ListaDeTDComp").sy_Variables.Rows)
			{
				listaListaTDComp.Items.Add(row["idVariable"]);					
			}
			CargarCondicionesDeVentas(false);
			CargarTiposDeComprobantes(false);

			rbTarjeta.CheckedChanged +=new EventHandler(rbTarjeta_CheckedChanged);
			rbCheque.CheckedChanged +=new EventHandler(rbCheque_CheckedChanged);
			rbRetencion.CheckedChanged +=new EventHandler(rbRetencion_CheckedChanged);
			rbNinguno.CheckedChanged +=new EventHandler(rbNinguno_CheckedChanged);
			bTodosTiposDeComprobantes.Click +=new EventHandler(bTodosTiposDeComprobantes_Click);
			bNingunoTiposDeComprobantes.Click +=new EventHandler(bNingunoTiposDeComprobantes_Click);
			ubTodosCondicionesDeVentas.Click +=new EventHandler(ubTodosCondicionesDeVentas_Click);
			ubNingunoCondicionesDeVentas.Click +=new EventHandler(ubNingunoCondicionesDeVentas_Click);
			mzCuentasControl1.Init();
			mzCuentasControl1.AllowEditClientePaso = false;
			mzCuentasControl1.ValueChanged+= new System.EventHandler( this.Componentes_Changes );
			gridClientes.LayoutData = _uiController.GetLayoutCuentas();
			gridClientes.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			gridClientes.GroupByBoxVisible  = false;
			ultraButton1.Click +=new EventHandler(ubAgregarCuenta_Click);


			BindingController.Bind(rbMetodoComparacionPorE,"Checked",_uiController, "MetodoComparacionXE");
			BindingController.Bind(rbMetodoComparacionPorI,"Checked",_uiController, "MetodoComparacionXI");
			BindingController.Bind(rbMetAsigCuentaPorE,"Checked",_uiController, "MetodoAsigCuentaXE");
			BindingController.Bind(rbMetAsigCuentaPorI,"Checked",_uiController, "MetodoAsigCuentaXI");
			BindingController.Bind(rbMetAsigTipCompPorE,"Checked",_uiController, "MetodoAsigTipoCompXE");
			BindingController.Bind(rbMetAsigTipCompPorI,"Checked",_uiController, "MetodoAsigTipoCompXI");
			BindingController.Bind(mzCEFamiliaFormaDePago, "Value", _uiController, "Jerarquia");
			BindingController.Bind(mzCEComprobanteTesoreria, "Value", _uiController, "Jerarquia1");

			txtClaveCorta.ReadOnly = true;
			txtClaveLarga.ReadOnly = true;
			labelClaveCorta.Visible = false;
			labelClaveLarga.Visible = false;
			txtClaveLarga.Visible = false;
			txtClaveCorta.Visible = false;
			if(this.State.Equals("EDIT"))
			{	//Vivi
				//ultraExplorerBar1.Groups["CVAsociadas"].Visible = false;
				ultraExplorerBar1.Groups["CVAsociadas"].Visible = false;
				ultraExplorerBar1.Groups["TCAsociados"].Visible = false;
				ultraExplorerBar1.Groups["VAsociadas"].Visible = false;
				ultraExplorerBar1.Groups["EAsociadas"].Visible = false;
				if(Security.PerteneceAPerfilSuperior)
				{
					labelClaveCorta.Visible = true;
					labelClaveLarga.Visible = true;
					txtClaveLarga.Visible = true;
					txtClaveCorta.Visible = true;
				}
			
			}
			
			ultraExplorerBar1.Groups["CVAsociadas"].Visible = false;
			ultraExplorerBar1.Groups["TCAsociados"].Visible = false;
			ultraExplorerBar1.Groups["VAsociadas"].Visible = false;
			ultraExplorerBar1.Groups["EAsociadas"].Visible = false;

			_uiController.JerarquiaChanged+=new EventHandler(_uiController_JerarquiaChanged);	
			_uiController.Jerarquia1Changed+=new EventHandler(_uiController_Jerarquia1Changed);	
			//_uiController.seleccionarFamilia();
		}

		
		private void Componentes_Changes( object sender, System.EventArgs e )
		{			
			_uiController.CodigoCuenta = Convert.ToString(mzCuentasControl1.DataValue);
		}


		private void CargarTiposDeComprobantes(bool checkState)
		{
			chkListTiposDeComprobantes.Items.Clear();
			ArrayList aux = _uiController.ListaTiposDeComprobantes;
			foreach(object tc in aux)
			{	
				chkListTiposDeComprobantes.Items.Add(tc, checkState);
			}
		}

		private void CargarCondicionesDeVentas(bool checkState)
		{
			chkListCondicionesDeVentas.Items.Clear();
			ArrayList aux = _uiController.ListaCondicionesDeVentas;
			foreach(object tc in aux)
			{	
				chkListCondicionesDeVentas.Items.Add(tc, checkState);
			}
		}


		protected override void FillControls() //se ejecuta al levantar la ventana
		{
			
			#region EDIT
			if(this.State.Equals("EDIT"))
			{
				
				mzCEComprobanteTesoreria.Enabled=false;
				mzCEFamiliaFormaDePago.Enabled=false;
				mzCmbTDComp.Enabled = false;
				string idTDComp = ( string )_row["IdTDCompTesoreria"];
				_uiController.CargarJerarquiasYClaves(idTDComp);
				//Tengo q cargar el segundo combo y el tercero se carga con la info del segundo
				this.ChequearFamilia();
				if (_uiController.JerarquiaEdicion.Length>20)
				{
					mzCEComprobanteTesoreria.FillFromDataSource( _uiController.ListaSegundoNivel, "Jerarquia", "Descripcion", 100, "Descripcion");
					mzCEComprobanteTesoreria.Value=_uiController.JerarquiaEdicion;
					mzCEFamiliaFormaDePago.Value=_uiController.JerarquiaEdicion.Substring(0,20);
					mzCmbTDComp.FillFromDataSource( _uiController.TDCompTesoreriaPorNivelUno() , "idTDCompTesoreria", "Descripcion", 30, "Descripcion");
					mzCmbTDComp.Value = idTDComp;
					Hashtable keys=_uiController.ClavesCortas;
					this._claveCorta=Convert.ToString(keys[_uiController.Jerarquia1]);	
				
				}
				else{//Cargo solo el tercero
					mzCEComprobanteTesoreria.FillFromDataSource( _uiController.ListaSegundoNivel, "Jerarquia", "Descripcion", 100, "Descripcion");
					mzCEFamiliaFormaDePago.Value=_uiController.JerarquiaEdicion;
					mzCmbTDComp.FillFromDataSource( _uiController.TDCompTesoreriaPorNivelCero() , "idTDCompTesoreria", "Descripcion", 30, "Descripcion");
					mzCmbTDComp.Value = idTDComp;
				}
				
				uneRecargo.Value = _uiController.GetRecargo(idTDComp);
				LlenarHash (idTDComp, "ObligaDatosValor"); 
				LlenarHash (idTDComp, "ObligaVarAuxiliares"); 
				txtClaveCorta.Text = MAPStaticInfo.GetBDFDP(idTDComp);
				txtClaveLarga.Text = MAPStaticInfo.GetFDP(idTDComp);
			}
			#endregion
			#region NEW
			if(this.State.Equals("NEW"))
        	{
				CargarEntidades(MAPStaticInfo.GetIdEntidades(tipoRB));
				_uiController.seleccionarFamilia();
				this.chkAgrupado.Checked=_uiController.Agrupado;
			}
			#endregion
			if (_row != null)
			{
				txtDescripcion.Text = ( string )_row["Descripcion"];
				numericEditorcuotas.Value=Convert.ToUInt16(_row["Cuotas"]);
				chkAgrupado.Checked = ( bool )_row["Agrupado"];
				chkActivo.Checked = ( bool )_row["Activo"];
				string idTDComp = ( string )_row["IdTDCompTesoreria"];
				if (!txtDescripcion.Text.Equals(string.Empty))
				{
					string idFDP = MAPStaticInfo.GetFDP(txtDescripcion.Text);
					ChequearContrario(lista1, Variables.GetValueString("Momentos.DefinirValor.ProcesoModificarValor."+ idFDP +".CamposNoEditables"));
					Chequear(lista2, Variables.GetValueString("Momentos.ValorDatoAuxiliar."+ idFDP +".CamposVisibles"));
					ChequearVariables(listaListaTDComp, Convert.ToString(_row["IdTDCompTesoreria"]));				
					string aux = string.Empty;
					foreach (tfi_TDCompTesoreria_EntidadesDataset.tfi_TDCompTesoreria_EntidadesRow  rowEnti in mz.erp.businessrules.tfi_TDCompTesoreria_Entidades.GetList(Convert.ToString(_row["IdTDCompTesoreria"])).tfi_TDCompTesoreria_Entidades.Rows)
					{
						aux = aux +","+ tfi_Entidades.GetByPk(Convert.ToString(	rowEnti["idEntidad"])).Descripcion;
					}
					tipoRB = MAPStaticInfo.GetFamilia(idTDComp);
					CargarEntidades(MAPStaticInfo.GetIdEntidades(MAPStaticInfo.GetFamilia(idTDComp)));
					Chequear(listaEntidades, aux);
				}

			}
			else //para agregar
			{
				txtDescripcion.Text=_descripcion;
				chkActivo.Checked = true;
				//chkAgrupado.Checked = false;
			}
			this.chkAgrupado.Enabled=false;
		}
						
		protected override void DumpControls() //se ejecuta al intentar guardar
		{
			if(!Convert.ToString( _row["Descripcion"]).Equals( txtDescripcion.Text))
			{
				_modificoDescripcion=true;
				_descripcionAnterior = Convert.ToString(_row["Descripcion"]);
			}
			_row["Descripcion"] = txtDescripcion.Text;
			_row["Agrupado"] = chkAgrupado.Checked;
			_row["Cuotas"]=numericEditorcuotas.Value;
			_row["Activo"] = chkActivo.Checked;
			//_dataVariablesABorrar.Clear();
			//_dataVariablesPerfilesABorrar.Clear();
			_dataVariablesL.Clear();
			_dataVariablesPerfilesL.Clear();
			_dataCompEntidades.Clear();
			if(this.State.Equals("NEW"))
			{
				CargarDataVariables();
				CargarDataVariablesPerfiles();
				
			}
			CargarVariableCantidadCuotas();
			//BorrarVariables();
			CargarDataEntidades();
			string IdTDComp = null;
			if(this.State.Equals("EDIT")) 
			{
				IdTDComp = Convert.ToString(_row["IdTDCompTesoreria"]);
				
			}
			else //Es un alta => guarda la jerarquia para el nuevo comprobante
				mz.erp.businessrules.tfi_TDCompTesoreria.DataAgrupamientoTDCompTesoreria=MAPStaticInfo.Save(IdTDComp,_jerarquiaActual);
			mz.erp.businessrules.tfi_TDCompTesoreria.DataConfiguracionFDP = MAPStaticInfo.Save(IdTDComp,txtDescripcion.Text,_familia,_claveCorta, (string)mzCmbTDComp.Value);
			mz.erp.businessrules.tfi_TDCompTesoreria.DataVariables = _dataVariablesL;
			mz.erp.businessrules.tfi_TDCompTesoreria.DataVariablesPerfiles = _dataVariablesPerfilesL;
			mz.erp.businessrules.tfi_TDCompTesoreria.DataVariablesABorrar = _dataVariablesABorrar;
			mz.erp.businessrules.tfi_TDCompTesoreria.DataVariablesPerfilesABorrar = _dataVariablesPerfilesABorrar;
			mz.erp.businessrules.tfi_TDCompTesoreria.DataCompEntidades = _dataCompEntidades;
			mz.erp.businessrules.tfi_TDCompTesoreria.Tipo = tipoRB;
			if(this.State.Equals("NEW"))
			{
				ArrayList ListaCondicionesDeVentasSeleccionadas = new ArrayList();
				foreach(object obj in chkListCondicionesDeVentas.CheckedItems)
				{
					ListaCondicionesDeVentasSeleccionadas.Add(obj);
				}
				ArrayList ListaTiposDeComprobantesSeleccionados = new ArrayList();
				foreach(object obj in chkListTiposDeComprobantes.CheckedItems)
				{
					ListaTiposDeComprobantesSeleccionados.Add(obj);
				}
				_uiController.ListaCondicionesDeVentasSeleccionadas = ListaCondicionesDeVentasSeleccionadas;
				_uiController.ListaTiposDeComprobantesSeleccionados = ListaTiposDeComprobantesSeleccionados;
				_uiController.Recargo = Convert.ToDecimal(uneRecargo.Value);
				_uiController.Commit();
				mz.erp.businessrules.tfi_TDCompTesoreria.DataTDCompTesoreria_CondicionesDeVentas = _uiController.Data_TDCT_CV;
				mz.erp.businessrules.tfi_TDCompTesoreria.DataTDCompTesoreria_Monedas_Recargos = _uiController.DataTDCT_M_R;
				mz.erp.businessrules.tfi_TDCompTesoreria.DataCuentas_CondicionesDeVentas_TDCompTesoreria = _uiController.Data_C_CV_TDCT;
				mz.erp.businessrules.tfi_TDCompTesoreria.DataTiposDeComprobantes_CondicionesDeVentas_TDCompTesoreria = _uiController.Data_TC_CV_TDCT;
					
			}
			if(this.State.Equals("EDIT"))
			{
				_uiController.Recargo = Convert.ToDecimal(uneRecargo.Value);
				_uiController.Commit();
				mz.erp.businessrules.tfi_TDCompTesoreria.DataTDCompTesoreria_Monedas_Recargos = _uiController.DataTDCT_M_R;
					
			}
			mz.erp.businessrules.tfi_TDCompTesoreria.State = this.State;

			
		}


		#endregion					

		#region codigo auxiliar
		private void CargarEntidades(string listaID)
		{
			if(listaID != null && listaID != string.Empty)
			{
				string[] lista = listaID.Split(',');
				listaEntidades.Items.Clear();
				for( int i = 0 ; i < lista.Length ; i++)
				{
					listaEntidades.Items.Add(mz.erp.businessrules.tfi_Entidades.GetByPk(lista[i]).Descripcion, false);
				}
			}
		}
		/// <summary>
		/// retorna el la tabla que se muestra en el combo de TDCompTesoreria, con la fila 'Ninguno' agregada
		/// </summary>
		private System.Data.DataTable TDCompTesoreria()
		{
			System.Data.DataTable table = mz.erp.businessrules.tfi_TDCompTesoreria.GetList().Tables[0];
			//agrego fila para No seleccionar Procesos
			System.Data.DataRow row = table.NewRow();
			row["IdTDcompTesoreria"] = -1;
			row["Descripcion"] = "<Ninguno>";
			table.Rows.Add(row);
			return table;
		}

		/// <summary>
		/// Tilda en 'chequedList' todas aquellas opciones que se encuentran en la lista de 'valores'
		/// </summary>
		private void Chequear( System.Windows.Forms.CheckedListBox chequedList, string valores)
		{
			string[] listValores = valores.Split(',');
			//borro lo que puede estar de la consulta anterior
			for(int i=0; i< chequedList.Items.Count ; i++)
			{
				chequedList.SetItemChecked(i, false);
			}
			foreach(string val in listValores)
			{
				int pos = chequedList.Items.IndexOf(val);
				if (chequedList.Items.Contains(val))
				{
					chequedList.SetItemChecked(chequedList.Items.IndexOf(val), true);
				}
				else
				{
					if (pos > - 1)
						chequedList.SetItemChecked(chequedList.Items.IndexOf(val), false);
				}
			}
		}
		
		/// <summary>
		/// Tilda en 'chequedList' todas aquellas opciones que NO se encuentran en la lista de 'valores'
		/// </summary>	
		private void ChequearContrario( System.Windows.Forms.CheckedListBox chequedList, string valores)
		{
			string[] listValores = valores.Split(',');
			if (this.State!= "NEW")
			{
				for(int i=0; i< chequedList.Items.Count ; i++)
				{
					chequedList.SetItemChecked(i, true);
				}
			}
			foreach(string val in listValores)
			{
				int pos = chequedList.Items.IndexOf(val);
				if (pos > -1)
					if (!chequedList.Items.Contains(val))
					{
						chequedList.SetItemChecked(pos, true);
					}
					else 
					{
						chequedList.SetItemChecked(pos, false);
					}
			}
		}

		/// <summary>
		/// Tilda en 'chequedList' todas aquellas opciones (variables) que entre sus valores (valorDefault de Sy_variables) contienen el 'idTDCompTesoreria'
		/// </summary>	
		private void ChequearVariables (System.Windows.Forms.CheckedListBox chequedList, string idTDCompTesoreria)
		{
			for(int i = 0 ; i < chequedList.Items.Count; i++)
			{
				sy_VariablesDataset.sy_VariablesRow row = mz.erp.businessrules.sy_Variables.GetByPk(chequedList.Items[i]);
				ArrayList array = new ArrayList(Convert.ToString(row["ValorDefault"]).Split(','));
				if (array.Contains(idTDCompTesoreria))
					chequedList.SetItemChecked(i, true);
				else 
					chequedList.SetItemChecked(i, false);
			}
		}
	
		/// <summary>
		/// arma un string separado por comas con todas aquellas opciones que NO fueron tildadas en el chequedList
		/// </summary>
		private string ConstruirValorContrario(System.Windows.Forms.CheckedListBox chequedList)
		{
			string valor = string.Empty;
			for(int i=0; i< chequedList.Items.Count ; i++)
			{
				if (!chequedList.GetItemChecked(i))
					valor = valor + "," + chequedList.Items[i].ToString();
			} 
			if (!valor.Equals(string.Empty))
			{
				valor = valor.Substring(1); // saco la primer coma que esta de mas
			}
			return valor;
		}
	
		/// <summary>
		/// arma un string separado por comas con todas aquellas opciones que fueron tildadas en el chequedList
		/// </summary>
		
		private string ConstruirValor(System.Windows.Forms.CheckedListBox chequedList)
		{
			string valor = string.Empty;
			if (chequedList.CheckedItems.Count > 0 )
			{
				for(int i=0; i< chequedList.CheckedItems.Count ; i++)
				{
					valor = valor + "," + chequedList.CheckedItems[i].ToString();
				}	
			}
			if (!valor.Equals(string.Empty))
			{
				valor = valor.Substring(1); // saco la primer coma que esta de mas
			}
			return valor;
		}
		
		private void DeshabilitarListasPerfiles()
		{
			lista3.Enabled = false;
			lista4.Enabled = false;
		}
		/// <summary>
		/// determina si falta llenar el combo tarea o el combo de proceso o el combo de perfiles
		/// </summary>
		private bool FaltanDatos()
		{
			return ((mzCmbTarea.Value == null) || (mzCmbProceso.Value == null) || (mzCmbPerfiles.Value == null));
		}
		
		/// <summary>
		/// determina si falta llenar el combo tarea o el combo de proceso o el combo de perfiles que se utilizan para realizar la copia de una configuracion determinada
		/// </summary>
		
		private bool FaltanDatosCopiar()
		{
			return ((mzCmbTareaCopiar.Value == null) || (mzCmbProcesoCopiar.Value == null) || (mzCmbPerfilCopiar == null));
		}
			
		/// <summary>
		/// crea una row de sy_Variables que contiene todos los items tildados en el chequedList y la almacena en table,
		/// el parametro orden indica si se guarda "NORMAL" o "CONTRARIO"; no guarda la variable si no se tildo nada!
		/// variable es el nombre de la variable y descrip la descripcion que tendrá la misma; tener en cuenta que este metodo solo guarda variables cuyo valor es una lista de strings
		/// </summary>
		private void GuardarRowVariable(System.Windows.Forms.CheckedListBox chequedList, System.Data.DataTable table , string orden, string variable, string descrip)
		{
			string valorLista = string.Empty;
			if(orden == "CONTRARIO")
				valorLista = ConstruirValorContrario(chequedList);
			if(orden == "NORMAL")
				valorLista = ConstruirValor(chequedList);
			if (!valorLista.Equals(string.Empty)) //si no es vacio , tiene sentido guardar la variable
			{
				//German 20090415
				System.Data.DataRow rowAux = mz.erp.businessrules.sy_Variables.GetByPk(variable);
				if(rowAux == null)
				{
					System.Data.DataRow rowVariable = table.NewRow();
					rowVariable["IdVariable"] = variable; 
					rowVariable["ValorDefault"] = valorLista;
					rowVariable["Descripcion"] = descrip;
					rowVariable["IdTipoVariable"] = "System.string";
					table.Rows.Add(rowVariable);
				}
				//German 20090415
			}
		}

		/// <summary>
		/// crea una row de sy_Variables (variableDestino) que contiene todos los mismo items tildados varriableOrigen
		/// la variabel se almacena en table, si la variabel original no posee configuracion la variable destino NO se guarda!
		/// </summary>
		private void GuardarRowVariableCopiada( System.Data.DataTable table , string variableOrigen , string variableDestino)
		{
			sy_VariablesDataset.sy_VariablesRow	rowRecuperada =  mz.erp.businessrules.sy_Variables.GetByPk(variableOrigen);
			if (rowRecuperada != null)//la tengo q copiar y hacer una nueva
			{
				//German 20090415
				System.Data.DataRow rowAux = mz.erp.businessrules.sy_Variables.GetByPk(variableDestino);
				if(rowAux == null)
				{
					System.Data.DataRow rowVariable = table.NewRow();
					rowVariable["IdVariable"] = variableDestino;
					rowVariable["ValorDefault"] = rowRecuperada["ValorDefault"];
					rowVariable["Descripcion"] = rowRecuperada["Descripcion"];
					rowVariable["IdTipoVariable"] = rowRecuperada["IdTipoVariable"];
					table.Rows.Add(rowVariable);
				}
				//German 20090415
			}
		}
	
		/// <summary>
		/// crea una row de sy_VariablesPerfiles configara exactamente igual que para el tipo de comprobante seleccioando 
		/// en el combo y que tiene como terminacion de variables ColaVariable
		/// </summary>
		private void GuardarRowVariablePerfilCopiada( System.Data.DataTable table , string colaVariable)
		{
			sy_VariablesPerfilesDataset dataRecuperada = sy_VariablesPerfiles.GetList( MAPStaticInfo.GetFDP(Convert.ToString(mzCmbTDComp.Value))+"."+colaVariable);
			foreach (System.Data.DataRow row in dataRecuperada.Tables[0].Rows)
			{
				System.Data.DataRow rowNueva = table.NewRow();
				string[] clave = (Convert.ToString(row["idVariable"])).Split('.');
				if (clave.Length == 5) //tiene proceso
				{	
					rowNueva["IdVariable"] =clave[0]+"."+ clave[1] +"."+ clave[2] +"."+  systemframework.Util.RemoveSpaces(txtDescripcion.Text) + "." + colaVariable;							
				}
				if (clave.Length ==4) //no tiene proceso
				{
					rowNueva["IdVariable"] =clave[0]+"."+ clave[1] +"."+ systemframework.Util.RemoveSpaces(txtDescripcion.Text) + "." + colaVariable;							
				}
				rowNueva["IdPerfil"] = row["IdPerfil"];
				rowNueva["Valor"] = row["Valor"];
				//German 20090415
				System.Data.DataRow rowAux = mz.erp.businessrules.sy_VariablesPerfiles.GetByPk(rowNueva["IdVariable"],rowNueva["IdPerfil"] );
				if(rowAux == null)
					table.Rows.Add(rowNueva);
				//Fin German 20090415
			}
		}
		/// <summary>
		/// Agrega en la hash todas las rows (de sy_VariablesPerfiles) cuyo idVariable está fromado por
		/// el parametro idTDComp y cuya cola de variable es colaVar. Generando las Key de forma correcta 
		/// para que despues pueda ser leida para levantar los datos de la hash
		/// </summary>
		/// <remarks> anda solamente para variables de longitud 4 o 5 que comienzan como "Momentos"
		/// la logitud está dada por los substring entre comas </remarks>
		private void LlenarHash( string idTDComp, string colaVar ) 
		{
			
			string val = MAPStaticInfo.GetFDP(idTDComp);
            /* Silvina 20101021 - Tarea 902 */
			//System.Data.DataTable table = mz.erp.businessrules.sy_VariablesPerfiles.GetList(val + "."+ colaVar).sy_VariablesPerfiles;
            System.Data.DataTable table = mz.erp.businessrules.sy_VariablesPerfiles.GetListBy(val + "." + colaVar).sy_VariablesPerfiles;
            /* Fin Silvina */
			foreach (sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow rowPerf in  table.Rows)
			{
				long IdPerfil = Convert.ToInt64(rowPerf["IdPerfil"]);
				System.Data.DataRow row =  sy_Perfiles.GetByPk(IdPerfil);
				if(row != null)
				{
					string perfil =Convert.ToString(row["Descripcion"]);
					string key = CrearKeyParaHash(perfil, idTDComp,(Convert.ToString(rowPerf["idVariable"])).Split('.') );
					hash.Add(key, rowPerf);
				}
			}
		}
	

		#endregion

		#region llamadas a eventos 
		
		private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
		{
			if (rbTarjeta.Checked)
			{
				tipoRB = "Tarjeta";
				CargarEntidades(MAPStaticInfo.GetIdEntidades(tipoRB));
			}
		}

		private void rbCheque_CheckedChanged(object sender, EventArgs e)
		{
			if (rbCheque.Checked)
			{
				tipoRB = "Cheque";
				CargarEntidades(MAPStaticInfo.GetIdEntidades(tipoRB));
			}

		}

		private void rbRetencion_CheckedChanged(object sender, EventArgs e)
		{
			if (rbRetencion.Checked)
			{
				tipoRB = "Retención";
				CargarEntidades(MAPStaticInfo.GetIdEntidades(tipoRB));
			}
		}

		private void rbNinguno_CheckedChanged(object sender, EventArgs e)
		{
			if (rbRetencion.Checked)
			{
				tipoRB = "";
				CargarEntidades(MAPStaticInfo.GetIdEntidades(tipoRB));
			}
		}

		private void mzCmbTDComp_ValueChanged(object sender, EventArgs e)
		{
			if (Convert.ToString(mzCmbTDComp.Value) == "-1")
			{
				ultraExplorerBar1.Groups[3].Expanded = true;
				ultraExplorerBar1.Groups[3].Enabled = true;
				ultraExplorerBar1.Groups[4].Expanded=true;
				ultraExplorerBar1.Groups[4].Enabled=true;
			}
			else
			{
				ultraExplorerBar1.Groups[3].Expanded = false;
				ultraExplorerBar1.Groups[3].Enabled = false;
				ultraExplorerBar1.Groups[4].Expanded=false;
				ultraExplorerBar1.Groups[4].Enabled=false;

			}
		}
	
		
		private void mzCmbTarea_ValueChanged(object sender, EventArgs e)
		{
			DeshabilitarListasPerfiles();
			label17.Text = mz.erp.businessrules.twf_Tareas.GetByPk( mzCmbTarea.Value ).DescripcionParaUsuario;
			//filtro los elementos del combo de procesos , y dejo solamente los que pertenecen a la tabla de procesos tareas y tienen orden != -1
			System.Data.DataTable table = mz.erp.businessrules.twf_ProcesosTareas.GetList( long.MinValue , (long)mzCmbTarea.Value, int.MinValue, string.Empty).Tables[0];
			//agrego fila para No seleccionar Procesos
			System.Data.DataRow row = table.NewRow();
			row["IdProceso"] = -1;
			row["DescripcionProceso"] = "<Ninguno>";
			table.Rows.Add(row);
			mzCmbProceso.FillFromDataSource( table ,"idProceso","DescripcionProceso", 30, "DescripcionProceso");
		}

		private void mzCmbPerfiles_ValueChanged(object sender, System.EventArgs e)
		{
			DeshabilitarListasPerfiles();
		}

		private void mzCmbProceso_ValueChanged(object sender, EventArgs e)
		{
			DeshabilitarListasPerfiles();
		}


		private void mzCmbTareaCopiar_ValueChanged(object sender, EventArgs e)
		{
			System.Data.DataTable table = mz.erp.businessrules.twf_ProcesosTareas.GetList( long.MinValue , (long)mzCmbTarea.Value, int.MinValue, string.Empty).Tables[0];
			//agrego fila para No seleccionar Procesos
			System.Data.DataRow row = table.NewRow();
			row["IdProceso"] = -1;
			row["DescripcionProceso"] = "<Ninguno>";
			table.Rows.Add(row);
			mzCmbProcesoCopiar.FillFromDataSource( table ,"idProceso","DescripcionProceso", 30, "DescripcionProceso");
		}

		
		private void bCopiar_Click(object sender, EventArgs e)
		{
			//saco el foco, sino faltanDatos devuelve siempre true
			mz.erp.ui.utility.Util.MoveFocus(this.ultraExplorerBarContainerControl2);
			if ( !FaltanDatosCopiar())
			{
				
				//tomo los datos de la variable nueva (destino)
				string idPerfilCopiar = Convert.ToString(mzCmbPerfilCopiar.Value);
				string tareaCopiar = mzCmbTareaCopiar.Text;
				string procesoCopiar = mzCmbProcesoCopiar.Text;
				
				//busco en la hash la variable original (de la zona de arriba)			
				string clave = ObtenerKeyParaHashDesdeInterfaz(sy_Perfiles.GetByPk(Convert.ToInt64(mzCmbPerfiles.Value)).Descripcion, txtDescripcion.Text) + "ObligaDatosValor";
				System.Data.DataRow rowVarPerfil = (System.Data.DataRow)hash[clave];

				if(rowVarPerfil != null) //existe la original entonces creo y guardo las copias
				{
					#region busqueda y generacion de "ObligaDatosValor"
					string claveCopiar = sy_Perfiles.GetByPk(Convert.ToInt64(idPerfilCopiar)).Descripcion + tareaCopiar + procesoCopiar + txtDescripcion.Text +"ObligaDatosValor";
					
					System.Data.DataRow rowNueva = _dataVariablesPerfilesL.Tables[0].NewRow();
					if (procesoCopiar != "<Ninguno>") //se selecciono un proceso
						if (this.State.Equals("NEW"))
							rowNueva["idVariable"] = "Momentos." + tareaCopiar +"."+ procesoCopiar+"."+ systemframework.Util.RemoveSpaces(txtDescripcion.Text) +".ObligaDatosValor";
						else
							rowNueva["idVariable"] = "Momentos." + tareaCopiar +"."+ procesoCopiar+"."+ MAPStaticInfo.GetFDP(txtDescripcion.Text) +".ObligaDatosValor";
					else //no se selecciona un proceos
						if (this.State.Equals("NEW"))
						rowNueva["idVariable"] = "Momentos." + tareaCopiar +"." + systemframework.Util.RemoveSpaces(txtDescripcion.Text) +".ObligaDatosValor";
					else
						rowNueva["idVariable"] = "Momentos." + tareaCopiar +"." + MAPStaticInfo.GetFDP(txtDescripcion.Text) +".ObligaDatosValor";
					rowNueva["IdPerfil"] = idPerfilCopiar;
					rowNueva["Valor"] = rowVarPerfil["Valor"];
					if (!hash.ContainsKey(claveCopiar))//no existe el destino
						hash.Add(claveCopiar, rowNueva);	
					else //ya existe
						hash[claveCopiar] = rowNueva;	
					#endregion
				}

				clave = ObtenerKeyParaHashDesdeInterfaz(sy_Perfiles.GetByPk(Convert.ToInt64(mzCmbPerfiles.Value)).Descripcion, txtDescripcion.Text)+"ObligaVarAuxiliares";
				rowVarPerfil = (System.Data.DataRow)hash[clave];

				if(rowVarPerfil != null) //existe la original entonces creo y guardo las copias
				{
					#region busqueda y generacion de "ObligaVarAuxiliares"
					
					string claveCopiar = sy_Perfiles.GetByPk(Convert.ToInt64(idPerfilCopiar)).Descripcion + mzCmbTarea.Text + mzCmbProceso.Text + systemframework.Util.RemoveSpaces(txtDescripcion.Text) +"ObligaVarAuxiliares";
					System.Data.DataRow rowNueva = _dataVariablesPerfilesL.Tables[0].NewRow();
					if (procesoCopiar != "<Ninguno>") //se selecciono un proceso
						if (this.State.Equals("NEW"))
							rowNueva["idVariable"] = "Momentos." + tareaCopiar +"."+ procesoCopiar+"."+ systemframework.Util.RemoveSpaces(txtDescripcion.Text) +".ObligaVarAuxiliares";
						else 
							rowNueva["idVariable"] = "Momentos." + tareaCopiar +"."+ procesoCopiar+"."+ MAPStaticInfo.GetFDP(txtDescripcion.Text) +".ObligaVarAuxiliares";
					else //no se selecciona un proceos
						if (this.State.Equals("NEW"))
						rowNueva["idVariable"] = "Momentos." + tareaCopiar +"."+ systemframework.Util.RemoveSpaces(txtDescripcion.Text) +".ObligaVarAuxiliares";
					else
						rowNueva["idVariable"] = "Momentos." + tareaCopiar +"."+ MAPStaticInfo.GetFDP(txtDescripcion.Text) +".ObligaVarAuxiliares";
					rowNueva["IdPerfil"] = idPerfilCopiar;
					rowNueva["Valor"] = rowVarPerfil["Valor"];
					if (!hash.ContainsKey(claveCopiar))//no existe el destino
						hash.Add(claveCopiar, rowNueva);	
					else //ya existe
						hash[claveCopiar] = rowNueva;	
					#endregion
				}
			}
			else MessageBox.Show("No se ha completado la información necesaria sobre perfil, tarea  y proceso", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void bBuscar_Click(object sender, EventArgs e)
		{
			//saco el foco, sino faltanDatos devuelve siempre true
			mz.erp.ui.utility.Util.MoveFocus(this.ultraExplorerBarContainerControl2);
			if ( !FaltanDatos())
			{
				lista3.Enabled = true;
				lista4.Enabled = true;
				//chequeo segun los valores de la hash
				System.Data.DataRow rowHash = (System.Data.DataRow)hash[mzCmbPerfiles.Text + mzCmbTarea.Text + mzCmbProceso.Text + txtDescripcion.Text + "ObligaDatosValor"];
				if (rowHash != null)
					Chequear(lista3, Convert.ToString(rowHash["Valor"]));
				rowHash = (System.Data.DataRow)hash[mzCmbPerfiles.Text + mzCmbTarea.Text + mzCmbProceso.Text + txtDescripcion.Text + "ObligaVarAuxiliares"];
				if (rowHash != null)
					Chequear(lista4, Convert.ToString(rowHash["Valor"])); 
			}
			else MessageBox.Show("No se ha completado la información necesaria sobre perfil, tarea  y proceso", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void bGuardarEnHash_Click(object sender, EventArgs e)
		{
			//se agregan tantos lugares en la hash como variables (grillas) hay

			string key = ObtenerKeyParaHashDesdeInterfaz() +"ObligaDatosValor";
			
			#region lista 3 corresponde a ObligaDatosValor
			if( lista3.CheckedItems.Count != 0 ) //si hay items seleccionados
			{
				string valorLista3 = ConstruirValor(lista3);
				if( !valorLista3.Equals(string.Empty)) //si se tildo algo, sino no tiene sentido guardar la variable
				{
					if (hash.ContainsKey(key) )//ya existe la variable en la base
					{
						System.Data.DataRow rowAModificar = (System.Data.DataRow) hash[key];
						rowAModificar["Valor"] = valorLista3;
						hash[key] = rowAModificar;
					}
					else //es una variable nueva
					{
						System.Data.DataRow rowVariableLista3 = _dataVariablesPerfilesL.Tables[0].NewRow();
						if (Convert.ToString(mzCmbProceso.Value) == "-1") //no seleccionó un proceso
							rowVariableLista3["IdVariable"] = "Momentos." + mzCmbTarea.Text +"."+ systemframework.Util.RemoveSpaces(txtDescripcion.Text) +".ObligaDatosValor";
						else //se selecciono un proceso
							rowVariableLista3["IdVariable"] = "Momentos." + mzCmbTarea.Text +"."+ mzCmbProceso.Text +"."+systemframework.Util.RemoveSpaces(txtDescripcion.Text) +".ObligaDatosValor";
						rowVariableLista3["IdPerfil"] = Convert.ToString(mzCmbPerfiles.Value);
						rowVariableLista3["Valor"] = valorLista3;
						hash.Add( key , rowVariableLista3);
					}
				}
			}	
			#endregion
	
			key = ObtenerKeyParaHashDesdeInterfaz() +"ObligaVarAuxiliares";
			
			#region lista 4 corresponde a ObligaVarAuxiliares
			
			if( lista4.CheckedItems.Count != 0 ) //si hay items seleccionados
			{
				string valorLista4 = ConstruirValor(lista4);
				if( !valorLista4.Equals(string.Empty)) //si se tildo algo, sino no tiene sentido guardar la variable
				{
					if (hash.ContainsKey(key) )//ya existe la variable en la base
					{
						System.Data.DataRow rowAModificar = (System.Data.DataRow) hash[key];
						rowAModificar["Valor"] = valorLista4;
						hash[key] = rowAModificar;
					}
					else //es una variable nueva
					{
						System.Data.DataRow rowVariableLista4 = _dataVariablesPerfilesL.Tables[0].NewRow();
						if (Convert.ToString(mzCmbProceso.Value) == "-1") //no seleccionó un proceso
							rowVariableLista4["IdVariable"] = "Momentos." + mzCmbTarea.Text +"."+ systemframework.Util.RemoveSpaces(txtDescripcion.Text) +".ObligaVarAuxiliares";
						else //se selecciono un proceso
							rowVariableLista4["IdVariable"] = "Momentos." + mzCmbTarea.Text +"."+ mzCmbProceso.Text +"."+systemframework.Util.RemoveSpaces(txtDescripcion.Text) +".ObligaVarAuxiliares";
						rowVariableLista4["IdPerfil"] = Convert.ToString(mzCmbPerfiles.Value);
						rowVariableLista4["Valor"] = valorLista4;
						hash.Add( key , rowVariableLista4);
					}
				}
			}	
	
			#endregion
		}
		#endregion

	
		private void CargarDataVariables()
		{	
			System.Data.DataTable tableVariables = _dataVariablesL.Tables[0];
			string descripcionTDComp = txtDescripcion.Text;
			if (descripcionTDComp != null )
			{
				if (Convert.ToString(mzCmbTDComp.Value) == "-1") //NO se copia de otra variable
				{
						if (_modificoDescripcion)
					   GuardarRowVariable(lista1 , tableVariables , "CONTRARIO" , "Momentos.DefinirValor.ProcesoModificarValor."+ systemframework.Util.RemoveSpaces(descripcionTDComp) +".CamposNoEditables" , "Indica los campos que NO se permitiran editar para un comprobante determinado");
					GuardarRowVariable(lista2 , tableVariables , "NORMAL" , "Momentos.ValorDatoAuxiliar."+  systemframework.Util.RemoveSpaces(descripcionTDComp) +".CamposVisibles" , "Indica los campos q se mostraran en la pantalla de valores");	
					#region listaDeTDCompTesoreria
					//guardo las variables correspondientes a las listas que fueron tildadas
					for( int i=0; i < listaListaTDComp.Items.Count; i++)
					{
						if (listaListaTDComp.GetItemChecked(i) ) 
						{
							sy_VariablesDataset.sy_VariablesRow	rowRecuperada3 = mz.erp.businessrules.sy_Variables.GetByPk(listaListaTDComp.Items[i]);
							rowRecuperada3["ValorDefault"] = rowRecuperada3["ValorDefault"]+",";
							tableVariables.ImportRow(rowRecuperada3);
						}
					}
					#endregion
				}
				else 
					//SI se copia de otra variable (de mzCmbTDComp.Text)
				{
					GuardarRowVariableCopiada(tableVariables, "Momentos.DefinirValor.ProcesoModificarValor."+ MAPStaticInfo.GetFDP(Convert.ToString(mzCmbTDComp.Value)) +".CamposNoEditables", "Momentos.DefinirValor.ProcesoModificarValor."+ systemframework.Util.RemoveSpaces(descripcionTDComp) +".CamposNoEditables");
					GuardarRowVariableCopiada(tableVariables, "Momentos.ValorDatoAuxiliar."+ MAPStaticInfo.GetFDP(Convert.ToString(mzCmbTDComp.Value)) +".CamposVisibles", "Momentos.ValorDatoAuxiliar."+ systemframework.Util.RemoveSpaces(descripcionTDComp) +".CamposVisibles");
					GuardarRowVariableCopiada(tableVariables, "Momentos.SeleccionarFormasDePagos."+ MAPStaticInfo.GetFDP(Convert.ToString(mzCmbTDComp.Value)) +".AllowEditIncluyeRecargo", "Momentos.SeleccionarFormasDePagos."+ systemframework.Util.RemoveSpaces(descripcionTDComp) +".AllowEditIncluyeRecargo");
					#region listaDeTDCompTesoreria
					//guardo las variables correspondientes a las listas que fueron tildadas
					//obtengo todas las variables de TDCOmpTesoreriaa
					sy_VariablesDataset dataRecuperada = mz.erp.businessrules.sy_Variables.GetList("ListaDeTDComp");
					ArrayList valores = new ArrayList();
					foreach (sy_VariablesDataset.sy_VariablesRow row in dataRecuperada.Tables[0].Rows)
					{
						//me fijo cuales contienen entre sus default aquella que se selecciono en comportamiento
						valores.RemoveRange(0, valores.Count);
						valores.AddRange((Convert.ToString(row["ValorDefault"])).Split(','));
						if (valores.Contains(mzCmbTDComp.Value))
						{
							row["ValorDefault"] = row["ValorDefault"] + ",";
							tableVariables.ImportRow(row);
						}
					}
					#endregion
				}
			}
			else
				if(descripcionTDComp == null)
				MessageBox.Show("No se ha completado el nombre para la forma de pago", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void CargarVariableCantidadCuotas()
		{
			//German 20090415
			string variable = string.Empty;
			if(this.State.Equals("NEW"))
			{
				variable = "Valores." +  systemframework.Util.RemoveSpaces(txtDescripcion.Text.Trim()) + ".CantidadCuotas";
			}
			else
				variable = "Valores." + MAPStaticInfo.GetFDP(Convert.ToString(mzCmbTDComp.Value)) + ".CantidadCuotas";
			
			System.Data.DataRow rowAux = mz.erp.businessrules.sy_Variables.GetByPk(variable);
			if(rowAux == null)
			{
				System.Data.DataRow rowVariable = _dataVariablesL.sy_Variables.NewRow();
				rowVariable["IdVariable"] = variable; 
				rowVariable["ValorDefault"] = Convert.ToString(numericEditorcuotas.Value);
				rowVariable["Descripcion"] = "Determina la cant de cuotas que debe aparecer en la pantalla de valores";
				rowVariable["IdTipoVariable"] = "System.string";
				_dataVariablesL.sy_Variables.Rows.Add(rowVariable);
			}
			else
			{
				rowAux["ValorDefault"] = Convert.ToString(numericEditorcuotas.Value);
				_dataVariablesL.sy_Variables.ImportRow(rowAux);
			}
			//German 20090415
			
		}


		private void CargarDataVariablesPerfiles()
		{
			System.Data.DataTable tableVariables = _dataVariablesL.Tables[0];
			string descripcionTDComp = txtDescripcion.Text;
			if (descripcionTDComp != null)
			{
				#region NO SE COPIA
				if (Convert.ToString(mzCmbTDComp.Value) == "-1") //NO se copia de otra variable
				{	
					//recorro la hash y la paso a _dataVariablesPerfilesL
					foreach (System.Data.DataRow row in hash.Values)
					{
						sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow rowRecuperada = sy_VariablesPerfiles.GetByPk( Convert.ToString(row["IdVariable"]) , Convert.ToInt64(row["idPerfil"]));
						if (rowRecuperada != null ) //ya existia
							_dataVariablesPerfilesL.Tables[0].ImportRow(row);
						else //es una nueva row
							_dataVariablesPerfilesL.Tables[0].Rows.Add(row);
					}
				}
					#endregion
					#region SE COPIA
				else //SI se copia de otra variable (de mxCmbTDComp.text)
				{
					GuardarRowVariablePerfilCopiada(_dataVariablesPerfilesL.Tables[0],"ObligaDatosValor");
					GuardarRowVariablePerfilCopiada(_dataVariablesPerfilesL.Tables[0],"ObligaVarAuxiliares");
					
				}
				#endregion

			}
			else MessageBox.Show("No se ha completado el nombre para la forma de pago", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void BorrarVariables()
		{
			if(this.State.Equals("EDIT") && _modificoDescripcion)
			{
				string DescripcionActual = Convert.ToString(_row["Descripcion"]);

				foreach(System.Data.DataRow rowV in _dataVariablesL.sy_Variables.Rows)
				{
					string Variable = Convert.ToString(rowV["IdVariable"]);
					
					if(Variable.IndexOf(DescripcionActual) != -1)
					{
						string NuevaVariable = Variable.Replace(DescripcionActual, _descripcionAnterior);
				
						mz.erp.commontypes.data.sy_VariablesDataset.sy_VariablesRow rowVNueva = mz.erp.businessrules.sy_Variables.GetByPk(NuevaVariable);
						/*
						mz.erp.commontypes.data.sy_VariablesDataset.sy_VariablesRow rowVNueva = _dataVariablesABorrar.sy_Variables.Newsy_VariablesRow();
						rowVNueva["IdVariable"] = NuevaVariable; 
						rowVNueva["ValorDefault"] = rowV["ValorDefault"] ;
						rowVNueva["Descripcion"] = rowV["Descripcion"] ;
						rowVNueva["IdTipoVariable"] = "System.string";
						_dataVariablesABorrar.sy_Variables.Addsy_VariablesRow(rowVNueva);
						*/
						_dataVariablesABorrar.sy_Variables.ImportRow(rowVNueva);
					}
					/*
					System.Data.DataSet dataVP = mz.erp.businessrules.sy_VariablesPerfiles.GetList(NuevaVariable);
					foreach(System.Data.DataRow rowVPP in dataVP.Tables[0].Rows)
					{
						if(_dataVariablesPerfilesABorrar.sy_VariablesPerfiles.FindByIdVariableIdPerfil(NuevaVariable,Convert.ToInt64(rowVPP["IdPerfil"]) ) != null)
						{
							_dataVariablesPerfilesABorrar.sy_VariablesPerfiles.ImportRow(rowVPP);
						}
					}
					*/
				}

				ArrayList aux = new ArrayList();
				
				foreach(System.Data.DataRow rowVP in _dataVariablesPerfilesL.sy_VariablesPerfiles.Rows)
				{
					string Variable = Convert.ToString(rowVP["IdVariable"]);
					string NuevaVariable = Variable.Replace(DescripcionActual, _descripcionAnterior);

					/*
					mz.erp.commontypes.data.sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow rowVPNueva = _dataVariablesPerfilesABorrar.sy_VariablesPerfiles.Newsy_VariablesPerfilesRow();
					rowVPNueva["IdVariable"] = NuevaVariable; 
					rowVPNueva["IdPerfil"] = rowVP["IdPerfil"] ;	
					rowVPNueva["Valor"] = rowVP["Valor"] ;
					_dataVariablesPerfilesABorrar.sy_VariablesPerfiles.Addsy_VariablesPerfilesRow(rowVPNueva);
					*/
					if(!aux.Contains(NuevaVariable))
					{
						aux.Add(NuevaVariable);
						System.Data.DataSet dataVP = mz.erp.businessrules.sy_VariablesPerfiles.GetList(NuevaVariable);
						foreach(System.Data.DataRow rowVPP in dataVP.Tables[0].Rows)
						{
							if(_dataVariablesPerfilesABorrar.sy_VariablesPerfiles.FindByIdVariableIdPerfil(NuevaVariable,Convert.ToInt64(rowVPP["IdPerfil"]) ) == null)
							{
								_dataVariablesPerfilesABorrar.sy_VariablesPerfiles.ImportRow(rowVPP);
							}
						}
					}
				}
				
				foreach(System.Data.DataRow rowV in _dataVariablesABorrar.sy_Variables.Rows)
				{
					rowV.Delete();
				}	
				foreach(System.Data.DataRow rowVP in _dataVariablesPerfilesABorrar.sy_VariablesPerfiles.Rows)
				{
					rowVP.Delete();
				}	
			}
		}

	
		private void CargarDataEntidades()
		{
			System.Data.DataTable tableEntidades = _dataCompEntidades.Tables[0];
			string descripcionTDComp = txtDescripcion.Text;
			if (this.State.Equals("NEW"))
			{
				if (Convert.ToString(mzCmbTDComp.Value) == "-1") //NO se copia de otra variable
				{
					for( int i=0; i < listaEntidades.Items.Count; i++)
					{
						System.Data.DataRow rowCompEnt = tableEntidades.NewRow();
						
						if (listaEntidades.GetItemChecked(i) ) //si esta chequeado
						{
							System.Data.DataRow rowRecuperada = mz.erp.businessrules.tfi_Entidades.GetList(string.Empty,Convert.ToString(listaEntidades.Items[i])).Tables[0].Rows[0]; 	
							rowCompEnt["idEntidad"] = rowRecuperada["idEntidad"];
							rowCompEnt["TDCompTesoreria"] = "_";// despues se reemplaza por el nuevo id, cuando se agrega el comp.
							rowCompEnt["Activo"] = 1;
							tableEntidades.Rows.Add(rowCompEnt);
						}
					}
				}
				else //SI se copia de otra variable (de mzCmbTDComp.Text)
				{
					foreach(mz.erp.commontypes.data.tfi_TDCompTesoreria_EntidadesDataset.tfi_TDCompTesoreria_EntidadesRow rowRecu in 
						mz.erp.businessrules.tfi_TDCompTesoreria_Entidades.GetList(Convert.ToString(mzCmbTDComp.Value)).Tables[0].Rows)
					{
						System.Data.DataRow rowCompEnt = tableEntidades.NewRow();
						rowCompEnt["idEntidad"] = rowRecu["idEntidad"];
						rowCompEnt["TDCompTesoreria"] = "_";// despues se reemplaza por el nuevo id, cuando se agrega el comp.
						rowCompEnt["Activo"] = 1;
						tableEntidades.Rows.Add(rowCompEnt);
					}
				}
			}
			
		}
		
		
		#region keys
		private string ObtenerKeyParaHashDesdeInterfaz()
		{
			string perfil = mzCmbPerfiles.Text;
			string proceso = mzCmbProceso.Text;
			string tarea = mzCmbTarea.Text;
			string idTDComp = systemframework.Util.RemoveSpaces(txtDescripcion.Text);
			return perfil + tarea + proceso + idTDComp;
		}
		private string ObtenerKeyParaHashDesdeInterfaz(string idTDComp)
		{
			string perfil = mzCmbPerfiles.Text;
			string proceso = mzCmbProceso.Text;
			string tarea = mzCmbTarea.Text;
			return perfil + tarea + proceso + idTDComp;
		}

		private string ObtenerKeyParaHashDesdeInterfaz(string perfil, string idTDComp)
		{
			string proceso = mzCmbProceso.Text;
			string tarea = mzCmbTarea.Text;
			return perfil + tarea + proceso + idTDComp;
		}
		private string CrearKeyParaHash(string perfil, string idTDComp, string[] variable )
		{
			//string idTDComp = systemframework.Util.RemoveSpaces(txtDescripcion.Text);
			if (variable.Length == 5) //tiene proceso
			{	
				return perfil + variable[1] + variable[2] + idTDComp + variable[4];
			}
			else 
				if (variable.Length ==4) //no tiene proceso
			{
				return perfil + variable[1] + "<Ninguno>" + idTDComp + variable[3];
			}
			else return null;
			
		}
		#endregion

		private void rbRetencion_CheckedChanged_1(object sender, System.EventArgs e)
		{
		
		}

		private void bCopiar_Click_1(object sender, System.EventArgs e)
		{
		
		}

		private void bTodosTiposDeComprobantes_Click(object sender, EventArgs e)
		{
			CargarTiposDeComprobantes(true);
		}

		private void bNingunoTiposDeComprobantes_Click(object sender, EventArgs e)
		{
			CargarTiposDeComprobantes(false);
		}

		private void ubTodosCondicionesDeVentas_Click(object sender, EventArgs e)
		{
			CargarCondicionesDeVentas(true);
		}

		private void ubNingunoCondicionesDeVentas_Click(object sender, EventArgs e)
		{
			CargarCondicionesDeVentas(false);
		}

		private void ubAgregarCuenta_Click(object sender, EventArgs e)
		{
			if(_uiController.CodigoCuenta != null && _uiController.CodigoCuenta != string.Empty)
			{
				if(!_uiController.ClienteRepetido(_uiController.CodigoCuenta))
				{
					_uiController.UpdateCuentas(_uiController.CodigoCuenta);
					gridClientes.SetDataBinding(null, null);
					gridClientes.SetDataBinding(_uiController.ListaCuentas, null);
				}
				else
					MessageBox.Show("El Cliente ya ha sido agregado.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void _uiController_JerarquiaChanged(object sender, EventArgs e)
		{
			//Cambio el cheq chequeado, si es cheque, tarjeta o efectivo y cargar el segundo combo
			if (!_uiController.Jerarquia.Equals(string.Empty))
			{
				this.ChequearFamilia();
				if (_uiController.TieneHijos)
				{
					mzCEComprobanteTesoreria.Enabled=true;
					mzCmbTDComp.Enabled=false;
					mzCEComprobanteTesoreria.FillFromDataSource( _uiController.ListaSegundoNivel, "Jerarquia", "Descripcion", 100, "Descripcion");
					_uiController.seleccionarFamiliaDeNivel2();
				}
				else
				{//Cargo los hijos por nivel uno
					mzCEComprobanteTesoreria.Enabled=false;
					if(this.State.Equals("NEW"))
						mzCmbTDComp.Enabled=true;
					_uiController.ActualizarJerarquiaUno();
					mzCEComprobanteTesoreria.FillFromDataSource( _uiController.ListaSegundoNivel, "Jerarquia", "Descripcion", 100, "Descripcion");
					mzCmbTDComp.FillFromDataSource( _uiController.TDCompTesoreriaPorNivelCero() , "idTDCompTesoreria", "Descripcion", 30, "Descripcion");
					mzCmbTDComp.Value = _uiController.IdComprobanteDefault;
			
				}
				chkAgrupado.Checked=_uiController.Agrupado;
			}
		}
//Cargo la familia=Clave larga y la clave corta, y la jerarquia actual(aca es jerarquia))
		private void ChequearFamilia(){
		Hashtable flias=_uiController.FamiliasPorClaveLarga;
		this._familia=Convert.ToString(flias[_uiController.Jerarquia]);
		Hashtable keys=_uiController.ClavesCortas;
		this._claveCorta=Convert.ToString(keys[_uiController.Jerarquia]);
		_jerarquiaActual=_uiController.Jerarquia;
		if (_familia.Equals("Cheques"))
			rbCheque.Checked=true;
		if (_familia.Equals("Retenciones"))
			 rbRetencion.Checked=true;
		if (_familia.Equals("Tarjetas"))
			rbTarjeta.Checked=true;
		if (_familia.Equals("Efectivo"))
			rbNinguno.Checked=true;		 
 }
		//Cargo las claves cortas, son de primer nivel cheque terceros, etc y la jerarquia actual es la del seleccionado(jerarquia1)
		private void _uiController_Jerarquia1Changed(object sender, EventArgs e)
		{
			if (!_uiController.Jerarquia1.Equals(string.Empty))
			{
				if(this.State.Equals("NEW"))
					mzCmbTDComp.Enabled=true;
				mzCmbTDComp.FillFromDataSource( _uiController.TDCompTesoreriaPorNivelUno() , "idTDCompTesoreria", "Descripcion", 30, "Descripcion");
				mzCmbTDComp.Value = _uiController.IdComprobanteDefault;
				Hashtable keys=_uiController.ClavesCortas;
				this._claveCorta=Convert.ToString(keys[_uiController.Jerarquia1]);
				_jerarquiaActual=_uiController.Jerarquia1;
			}
		}

		private void ultraExplorerBarContainerControl1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void uneRecargo_Enter(object sender, EventArgs e)
		{
			uneRecargo.SelectAll();
		}

		private void numericEditorcuotas_Enter(object sender, EventArgs e)
		{
			numericEditorcuotas.SelectAll();
		}
	}
}

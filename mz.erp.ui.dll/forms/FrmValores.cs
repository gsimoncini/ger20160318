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

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmValores.
	/// </summary>
	public class FrmValores : System.Windows.Forms.Form, ITaskForm, ISearchObjectListener
	{ 
		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmValores));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.panelRetenciones = new System.Windows.Forms.Panel();
			this.fechaRetencion = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.fechaIngresoRetencion = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.numeroRetencion = new System.Windows.Forms.TextBox();
			this.mzCmbTipoRetenciones = new mz.erp.ui.controls.mzComboEditor();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.panelDatosPrincipales = new System.Windows.Forms.Panel();
			this.chkIncluyeRecargo = new System.Windows.Forms.CheckBox();
			this.labelIncluyeRecargo = new System.Windows.Forms.Label();
			this.txtValorDestino = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.mzCEMonedaDestino = new mz.erp.ui.controls.mzComboEditor();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtValorOrigen = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.mzCEComprobanteTesoreria = new mz.erp.ui.controls.mzComboEditor();
			this.label7 = new System.Windows.Forms.Label();
			this.mzCEMonedaOrigen = new mz.erp.ui.controls.mzComboEditor();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panelDatosSecundarios = new System.Windows.Forms.Panel();
			this.mzComboEditorEstado = new mz.erp.ui.controls.mzComboEditor();
			this.label28 = new System.Windows.Forms.Label();
			this.uneValorConRecargo = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label3 = new System.Windows.Forms.Label();
			this.txtFechaVencimiento = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.txtFecha = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.mzCEEntidad = new mz.erp.ui.controls.mzComboEditor();
			this.lFechaVencimiento = new System.Windows.Forms.Label();
			this.lFecha = new System.Windows.Forms.Label();
			this.lEntidad = new System.Windows.Forms.Label();
			this.lNumero = new System.Windows.Forms.Label();
			this.mzComboEditorBanco = new mz.erp.ui.controls.mzComboEditor();
			this.panelCheque = new System.Windows.Forms.Panel();
			this.label27 = new System.Windows.Forms.Label();
			this.checkNoOrden = new System.Windows.Forms.CheckBox();
			this.label26 = new System.Windows.Forms.Label();
			this.checkCruzado = new System.Windows.Forms.CheckBox();
			this.fechaPago = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.fechaIngresoBanco = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.NroBoleta = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.esCliente = new System.Windows.Forms.CheckBox();
			this.sucursal = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
			this.label14 = new System.Windows.Forms.Label();
			this.fechaRecepcion = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.label16 = new System.Windows.Forms.Label();
			this.cuentaBancaria = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.librador = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.mzCmbSearchLibrador = new mz.erp.ui.controls.mzCuentasControl();
			this.label24 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.labelDestinatario = new System.Windows.Forms.Label();
			this.mzCmbProveedor = new mz.erp.ui.controls.mzComboSearchEditor();
			this.mzComboEditorCuenta = new mz.erp.ui.controls.mzComboEditor();
			this.panelTarjeta = new System.Windows.Forms.Panel();
			this.codigoDiez = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.cantidadCuotas = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.lote = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.fechaAutorizacion = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.label10 = new System.Windows.Forms.Label();
			this.fechaAcreditacion = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.label9 = new System.Windows.Forms.Label();
			this.cupon = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.codigoAutorizacion = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbGuardar = new System.Windows.Forms.ToolBarButton();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.imageList2 = new System.Windows.Forms.ImageList(this.components);
			this.UltraExpBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.panelRetenciones.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fechaRetencion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fechaIngresoRetencion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTipoRetenciones)).BeginInit();
			this.panelDatosPrincipales.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtValorDestino)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMonedaDestino)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtValorOrigen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEComprobanteTesoreria)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMonedaOrigen)).BeginInit();
			this.panelDatosSecundarios.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzComboEditorEstado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneValorConRecargo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFechaVencimiento)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFecha)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEEntidad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboEditorBanco)).BeginInit();
			this.panelCheque.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fechaPago)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fechaIngresoBanco)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fechaRecepcion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboEditorCuenta)).BeginInit();
			this.panelTarjeta.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fechaAutorizacion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fechaAcreditacion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UltraExpBar1)).BeginInit();
			this.UltraExpBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.panelRetenciones);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.panelDatosPrincipales);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.panelDatosSecundarios);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.panelCheque);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.panelTarjeta);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 49);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(656, 311);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			this.ultraExplorerBarContainerControl1.TabStop = true;
			// 
			// panelRetenciones
			// 
			this.panelRetenciones.BackColor = System.Drawing.Color.Transparent;
			this.panelRetenciones.Controls.Add(this.fechaRetencion);
			this.panelRetenciones.Controls.Add(this.fechaIngresoRetencion);
			this.panelRetenciones.Controls.Add(this.numeroRetencion);
			this.panelRetenciones.Controls.Add(this.mzCmbTipoRetenciones);
			this.panelRetenciones.Controls.Add(this.label19);
			this.panelRetenciones.Controls.Add(this.label20);
			this.panelRetenciones.Controls.Add(this.label21);
			this.panelRetenciones.Controls.Add(this.label22);
			this.panelRetenciones.Location = new System.Drawing.Point(0, 72);
			this.panelRetenciones.Name = "panelRetenciones";
			this.panelRetenciones.Size = new System.Drawing.Size(632, 96);
			this.panelRetenciones.TabIndex = 101;
			// 
			// fechaRetencion
			// 
			this.fechaRetencion.Location = new System.Drawing.Point(152, 72);
			this.fechaRetencion.Name = "fechaRetencion";
			this.fechaRetencion.Size = new System.Drawing.Size(168, 21);
			this.fechaRetencion.TabIndex = 9;
			// 
			// fechaIngresoRetencion
			// 
			this.fechaIngresoRetencion.Location = new System.Drawing.Point(152, 48);
			this.fechaIngresoRetencion.Name = "fechaIngresoRetencion";
			this.fechaIngresoRetencion.Size = new System.Drawing.Size(168, 21);
			this.fechaIngresoRetencion.TabIndex = 8;
			// 
			// numeroRetencion
			// 
			this.numeroRetencion.BackColor = System.Drawing.SystemColors.Window;
			this.numeroRetencion.Location = new System.Drawing.Point(152, 24);
			this.numeroRetencion.Name = "numeroRetencion";
			this.numeroRetencion.Size = new System.Drawing.Size(168, 20);
			this.numeroRetencion.TabIndex = 7;
			this.numeroRetencion.Text = "";
			// 
			// mzCmbTipoRetenciones
			// 
			this.mzCmbTipoRetenciones.AutoComplete = true;
			this.mzCmbTipoRetenciones.DataSource = null;
			this.mzCmbTipoRetenciones.DisplayMember = "";
			this.mzCmbTipoRetenciones.DisplayMemberCaption = "";
			this.mzCmbTipoRetenciones.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbTipoRetenciones.Location = new System.Drawing.Point(152, 0);
			this.mzCmbTipoRetenciones.MaxItemsDisplay = 7;
			this.mzCmbTipoRetenciones.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbTipoRetenciones.Name = "mzCmbTipoRetenciones";
			this.mzCmbTipoRetenciones.Size = new System.Drawing.Size(168, 21);
			this.mzCmbTipoRetenciones.SorterMember = "";
			this.mzCmbTipoRetenciones.TabIndex = 6;
			this.mzCmbTipoRetenciones.ValueMember = "";
			this.mzCmbTipoRetenciones.ValueMemberCaption = "";
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Location = new System.Drawing.Point(8, 72);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(136, 21);
			this.label19.TabIndex = 91;
			this.label19.Text = "Fecha de la Retención";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Location = new System.Drawing.Point(8, 48);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(104, 21);
			this.label20.TabIndex = 90;
			this.label20.Text = "Fecha de Ingreso";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Location = new System.Drawing.Point(8, 1);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(100, 21);
			this.label21.TabIndex = 89;
			this.label21.Text = "Tipo de Retención";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.Transparent;
			this.label22.Location = new System.Drawing.Point(8, 24);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(136, 20);
			this.label22.TabIndex = 88;
			this.label22.Text = "Número de Comprobante";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelDatosPrincipales
			// 
			this.panelDatosPrincipales.BackColor = System.Drawing.Color.Transparent;
			this.panelDatosPrincipales.Controls.Add(this.chkIncluyeRecargo);
			this.panelDatosPrincipales.Controls.Add(this.labelIncluyeRecargo);
			this.panelDatosPrincipales.Controls.Add(this.txtValorDestino);
			this.panelDatosPrincipales.Controls.Add(this.mzCEMonedaDestino);
			this.panelDatosPrincipales.Controls.Add(this.label1);
			this.panelDatosPrincipales.Controls.Add(this.label2);
			this.panelDatosPrincipales.Controls.Add(this.txtValorOrigen);
			this.panelDatosPrincipales.Controls.Add(this.mzCEComprobanteTesoreria);
			this.panelDatosPrincipales.Controls.Add(this.label7);
			this.panelDatosPrincipales.Controls.Add(this.mzCEMonedaOrigen);
			this.panelDatosPrincipales.Controls.Add(this.label5);
			this.panelDatosPrincipales.Controls.Add(this.label6);
			this.panelDatosPrincipales.Location = new System.Drawing.Point(0, 0);
			this.panelDatosPrincipales.Name = "panelDatosPrincipales";
			this.panelDatosPrincipales.Size = new System.Drawing.Size(632, 72);
			this.panelDatosPrincipales.TabIndex = 95;
			// 
			// chkIncluyeRecargo
			// 
			this.chkIncluyeRecargo.Location = new System.Drawing.Point(440, 0);
			this.chkIncluyeRecargo.Name = "chkIncluyeRecargo";
			this.chkIncluyeRecargo.Size = new System.Drawing.Size(167, 16);
			this.chkIncluyeRecargo.TabIndex = 3;
			// 
			// labelIncluyeRecargo
			// 
			this.labelIncluyeRecargo.BackColor = System.Drawing.Color.Transparent;
			this.labelIncluyeRecargo.Location = new System.Drawing.Point(328, 0);
			this.labelIncluyeRecargo.Name = "labelIncluyeRecargo";
			this.labelIncluyeRecargo.Size = new System.Drawing.Size(120, 21);
			this.labelIncluyeRecargo.TabIndex = 105;
			this.labelIncluyeRecargo.Text = "Incluye Recargo";
			this.labelIncluyeRecargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtValorDestino
			// 
			this.txtValorDestino.Location = new System.Drawing.Point(152, 48);
			this.txtValorDestino.MinValue = 0;
			this.txtValorDestino.Name = "txtValorDestino";
			this.txtValorDestino.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.txtValorDestino.Size = new System.Drawing.Size(168, 21);
			this.txtValorDestino.TabIndex = 2;
			// 
			// mzCEMonedaDestino
			// 
			this.mzCEMonedaDestino.AutoComplete = true;
			this.mzCEMonedaDestino.DataSource = null;
			this.mzCEMonedaDestino.DisplayMember = "";
			this.mzCEMonedaDestino.DisplayMemberCaption = "";
			this.mzCEMonedaDestino.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEMonedaDestino.Location = new System.Drawing.Point(442, 48);
			this.mzCEMonedaDestino.MaxItemsDisplay = 7;
			this.mzCEMonedaDestino.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEMonedaDestino.Name = "mzCEMonedaDestino";
			this.mzCEMonedaDestino.Size = new System.Drawing.Size(168, 21);
			this.mzCEMonedaDestino.SorterMember = "";
			this.mzCEMonedaDestino.TabIndex = 5;
			this.mzCEMonedaDestino.ValueMember = "";
			this.mzCEMonedaDestino.ValueMemberCaption = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(328, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 104;
			this.label1.Text = "Moneda Destino";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(8, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 20);
			this.label2.TabIndex = 103;
			this.label2.Text = "Valor Moneda Destino";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtValorOrigen
			// 
			this.txtValorOrigen.Location = new System.Drawing.Point(152, 24);
			this.txtValorOrigen.MinValue = 0;
			this.txtValorOrigen.Name = "txtValorOrigen";
			this.txtValorOrigen.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.txtValorOrigen.Size = new System.Drawing.Size(168, 21);
			this.txtValorOrigen.TabIndex = 1;
			this.txtValorOrigen.Click += new System.EventHandler(this.txtValorOrigen_Click);
			// 
			// mzCEComprobanteTesoreria
			// 
			this.mzCEComprobanteTesoreria.AutoComplete = true;
			this.mzCEComprobanteTesoreria.DataSource = null;
			this.mzCEComprobanteTesoreria.DisplayMember = "";
			this.mzCEComprobanteTesoreria.DisplayMemberCaption = "";
			this.mzCEComprobanteTesoreria.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEComprobanteTesoreria.Location = new System.Drawing.Point(152, 0);
			this.mzCEComprobanteTesoreria.MaxItemsDisplay = 7;
			this.mzCEComprobanteTesoreria.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEComprobanteTesoreria.Name = "mzCEComprobanteTesoreria";
			this.mzCEComprobanteTesoreria.Size = new System.Drawing.Size(168, 21);
			this.mzCEComprobanteTesoreria.SorterMember = "";
			this.mzCEComprobanteTesoreria.TabIndex = 0;
			this.mzCEComprobanteTesoreria.ValueMember = "";
			this.mzCEComprobanteTesoreria.ValueMemberCaption = "";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(8, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(144, 21);
			this.label7.TabIndex = 100;
			this.label7.Text = "Forma de Pago";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mzCEMonedaOrigen
			// 
			this.mzCEMonedaOrigen.AutoComplete = true;
			this.mzCEMonedaOrigen.DataSource = null;
			this.mzCEMonedaOrigen.DisplayMember = "";
			this.mzCEMonedaOrigen.DisplayMemberCaption = "";
			this.mzCEMonedaOrigen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEMonedaOrigen.Location = new System.Drawing.Point(442, 24);
			this.mzCEMonedaOrigen.MaxItemsDisplay = 7;
			this.mzCEMonedaOrigen.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEMonedaOrigen.Name = "mzCEMonedaOrigen";
			this.mzCEMonedaOrigen.Size = new System.Drawing.Size(168, 21);
			this.mzCEMonedaOrigen.SorterMember = "";
			this.mzCEMonedaOrigen.TabIndex = 4;
			this.mzCEMonedaOrigen.ValueMember = "";
			this.mzCEMonedaOrigen.ValueMemberCaption = "";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(328, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 21);
			this.label5.TabIndex = 99;
			this.label5.Text = "Moneda Origen";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(8, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(128, 20);
			this.label6.TabIndex = 98;
			this.label6.Text = "Valor Moneda Origen";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelDatosSecundarios
			// 
			this.panelDatosSecundarios.BackColor = System.Drawing.Color.Transparent;
			this.panelDatosSecundarios.Controls.Add(this.mzComboEditorEstado);
			this.panelDatosSecundarios.Controls.Add(this.label28);
			this.panelDatosSecundarios.Controls.Add(this.uneValorConRecargo);
			this.panelDatosSecundarios.Controls.Add(this.label3);
			this.panelDatosSecundarios.Controls.Add(this.txtFechaVencimiento);
			this.panelDatosSecundarios.Controls.Add(this.txtFecha);
			this.panelDatosSecundarios.Controls.Add(this.txtNumero);
			this.panelDatosSecundarios.Controls.Add(this.mzCEEntidad);
			this.panelDatosSecundarios.Controls.Add(this.lFechaVencimiento);
			this.panelDatosSecundarios.Controls.Add(this.lFecha);
			this.panelDatosSecundarios.Controls.Add(this.lEntidad);
			this.panelDatosSecundarios.Controls.Add(this.lNumero);
			this.panelDatosSecundarios.Controls.Add(this.mzComboEditorBanco);
			this.panelDatosSecundarios.Location = new System.Drawing.Point(0, 72);
			this.panelDatosSecundarios.Name = "panelDatosSecundarios";
			this.panelDatosSecundarios.Size = new System.Drawing.Size(632, 96);
			this.panelDatosSecundarios.TabIndex = 14;
			// 
			// mzComboEditorEstado
			// 
			this.mzComboEditorEstado.AutoComplete = true;
			this.mzComboEditorEstado.DataSource = null;
			this.mzComboEditorEstado.DisplayMember = "";
			this.mzComboEditorEstado.DisplayMemberCaption = "";
			this.mzComboEditorEstado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzComboEditorEstado.Location = new System.Drawing.Point(442, 24);
			this.mzComboEditorEstado.MaxItemsDisplay = 7;
			this.mzComboEditorEstado.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzComboEditorEstado.Name = "mzComboEditorEstado";
			this.mzComboEditorEstado.Size = new System.Drawing.Size(168, 21);
			this.mzComboEditorEstado.SorterMember = "";
			this.mzComboEditorEstado.TabIndex = 106;
			this.mzComboEditorEstado.ValueMember = "";
			this.mzComboEditorEstado.ValueMemberCaption = "";
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.Color.Transparent;
			this.label28.Location = new System.Drawing.Point(330, 24);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(100, 21);
			this.label28.TabIndex = 107;
			this.label28.Text = "Estado";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uneValorConRecargo
			// 
			this.uneValorConRecargo.Location = new System.Drawing.Point(442, 0);
			this.uneValorConRecargo.MinValue = 0;
			this.uneValorConRecargo.Name = "uneValorConRecargo";
			this.uneValorConRecargo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneValorConRecargo.Size = new System.Drawing.Size(168, 21);
			this.uneValorConRecargo.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(328, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 20);
			this.label3.TabIndex = 105;
			this.label3.Text = "Valor con Rcgo";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtFechaVencimiento
			// 
			this.txtFechaVencimiento.Location = new System.Drawing.Point(152, 72);
			this.txtFechaVencimiento.Name = "txtFechaVencimiento";
			this.txtFechaVencimiento.Size = new System.Drawing.Size(168, 21);
			this.txtFechaVencimiento.TabIndex = 14;
			// 
			// txtFecha
			// 
			this.txtFecha.Location = new System.Drawing.Point(152, 48);
			this.txtFecha.Name = "txtFecha";
			this.txtFecha.Size = new System.Drawing.Size(168, 21);
			this.txtFecha.TabIndex = 13;
			// 
			// txtNumero
			// 
			this.txtNumero.BackColor = System.Drawing.SystemColors.Window;
			this.txtNumero.Location = new System.Drawing.Point(152, 24);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(168, 20);
			this.txtNumero.TabIndex = 12;
			this.txtNumero.Text = "";
			// 
			// mzCEEntidad
			// 
			this.mzCEEntidad.AutoComplete = true;
			this.mzCEEntidad.DataSource = null;
			this.mzCEEntidad.DisplayMember = "";
			this.mzCEEntidad.DisplayMemberCaption = "";
			this.mzCEEntidad.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEEntidad.Location = new System.Drawing.Point(153, 1);
			this.mzCEEntidad.MaxItemsDisplay = 7;
			this.mzCEEntidad.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEEntidad.Name = "mzCEEntidad";
			this.mzCEEntidad.Size = new System.Drawing.Size(168, 21);
			this.mzCEEntidad.SorterMember = "";
			this.mzCEEntidad.TabIndex = 10;
			this.mzCEEntidad.ValueMember = "";
			this.mzCEEntidad.ValueMemberCaption = "";
			// 
			// lFechaVencimiento
			// 
			this.lFechaVencimiento.BackColor = System.Drawing.Color.Transparent;
			this.lFechaVencimiento.Location = new System.Drawing.Point(8, 72);
			this.lFechaVencimiento.Name = "lFechaVencimiento";
			this.lFechaVencimiento.Size = new System.Drawing.Size(136, 21);
			this.lFechaVencimiento.TabIndex = 91;
			this.lFechaVencimiento.Text = "Fecha de Cobro";
			this.lFechaVencimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lFecha
			// 
			this.lFecha.BackColor = System.Drawing.Color.Transparent;
			this.lFecha.Location = new System.Drawing.Point(8, 48);
			this.lFecha.Name = "lFecha";
			this.lFecha.Size = new System.Drawing.Size(104, 21);
			this.lFecha.TabIndex = 90;
			this.lFecha.Text = "Fecha de Emisión";
			this.lFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lEntidad
			// 
			this.lEntidad.BackColor = System.Drawing.Color.Transparent;
			this.lEntidad.Location = new System.Drawing.Point(8, 1);
			this.lEntidad.Name = "lEntidad";
			this.lEntidad.Size = new System.Drawing.Size(100, 21);
			this.lEntidad.TabIndex = 89;
			this.lEntidad.Text = "Entidad";
			this.lEntidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lNumero
			// 
			this.lNumero.BackColor = System.Drawing.Color.Transparent;
			this.lNumero.Location = new System.Drawing.Point(8, 24);
			this.lNumero.Name = "lNumero";
			this.lNumero.Size = new System.Drawing.Size(136, 20);
			this.lNumero.TabIndex = 88;
			this.lNumero.Text = "Número de Comprobante";
			this.lNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mzComboEditorBanco
			// 
			this.mzComboEditorBanco.AutoComplete = true;
			this.mzComboEditorBanco.DataSource = null;
			this.mzComboEditorBanco.DisplayMember = "";
			this.mzComboEditorBanco.DisplayMemberCaption = "";
			this.mzComboEditorBanco.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzComboEditorBanco.Location = new System.Drawing.Point(152, 0);
			this.mzComboEditorBanco.MaxItemsDisplay = 50;
			this.mzComboEditorBanco.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzComboEditorBanco.Name = "mzComboEditorBanco";
			this.mzComboEditorBanco.Size = new System.Drawing.Size(168, 21);
			this.mzComboEditorBanco.SorterMember = "";
			this.mzComboEditorBanco.TabIndex = 108;
			this.mzComboEditorBanco.ValueMember = "";
			this.mzComboEditorBanco.ValueMemberCaption = "";
			// 
			// panelCheque
			// 
			this.panelCheque.BackColor = System.Drawing.Color.Transparent;
			this.panelCheque.Controls.Add(this.label27);
			this.panelCheque.Controls.Add(this.checkNoOrden);
			this.panelCheque.Controls.Add(this.label26);
			this.panelCheque.Controls.Add(this.checkCruzado);
			this.panelCheque.Controls.Add(this.fechaPago);
			this.panelCheque.Controls.Add(this.fechaIngresoBanco);
			this.panelCheque.Controls.Add(this.NroBoleta);
			this.panelCheque.Controls.Add(this.label23);
			this.panelCheque.Controls.Add(this.label13);
			this.panelCheque.Controls.Add(this.esCliente);
			this.panelCheque.Controls.Add(this.sucursal);
			this.panelCheque.Controls.Add(this.label14);
			this.panelCheque.Controls.Add(this.fechaRecepcion);
			this.panelCheque.Controls.Add(this.label16);
			this.panelCheque.Controls.Add(this.cuentaBancaria);
			this.panelCheque.Controls.Add(this.label17);
			this.panelCheque.Controls.Add(this.librador);
			this.panelCheque.Controls.Add(this.label18);
			this.panelCheque.Controls.Add(this.mzCmbSearchLibrador);
			this.panelCheque.Controls.Add(this.label24);
			this.panelCheque.Controls.Add(this.label15);
			this.panelCheque.Controls.Add(this.labelDestinatario);
			this.panelCheque.Controls.Add(this.mzCmbProveedor);
			this.panelCheque.Controls.Add(this.mzComboEditorCuenta);
			this.panelCheque.Location = new System.Drawing.Point(0, 168);
			this.panelCheque.Name = "panelCheque";
			this.panelCheque.Size = new System.Drawing.Size(632, 128);
			this.panelCheque.TabIndex = 98;
			this.panelCheque.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCheque_Paint);
			// 
			// label27
			// 
			this.label27.BackColor = System.Drawing.Color.Transparent;
			this.label27.Location = new System.Drawing.Point(328, 104);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(112, 20);
			this.label27.TabIndex = 119;
			this.label27.Text = "No a la orden";
			this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkNoOrden
			// 
			this.checkNoOrden.Location = new System.Drawing.Point(442, 104);
			this.checkNoOrden.Name = "checkNoOrden";
			this.checkNoOrden.Size = new System.Drawing.Size(16, 16);
			this.checkNoOrden.TabIndex = 118;
			// 
			// label26
			// 
			this.label26.BackColor = System.Drawing.Color.Transparent;
			this.label26.Location = new System.Drawing.Point(8, 104);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(136, 20);
			this.label26.TabIndex = 117;
			this.label26.Text = "Cheque cruzado";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkCruzado
			// 
			this.checkCruzado.Location = new System.Drawing.Point(152, 104);
			this.checkCruzado.Name = "checkCruzado";
			this.checkCruzado.Size = new System.Drawing.Size(16, 16);
			this.checkCruzado.TabIndex = 116;
			// 
			// fechaPago
			// 
			this.fechaPago.Location = new System.Drawing.Point(442, 77);
			this.fechaPago.Name = "fechaPago";
			this.fechaPago.Size = new System.Drawing.Size(168, 21);
			this.fechaPago.TabIndex = 29;
			// 
			// fechaIngresoBanco
			// 
			this.fechaIngresoBanco.Location = new System.Drawing.Point(442, 53);
			this.fechaIngresoBanco.Name = "fechaIngresoBanco";
			this.fechaIngresoBanco.Size = new System.Drawing.Size(168, 21);
			this.fechaIngresoBanco.TabIndex = 28;
			// 
			// NroBoleta
			// 
			this.NroBoleta.BackColor = System.Drawing.SystemColors.Window;
			this.NroBoleta.Location = new System.Drawing.Point(442, 29);
			this.NroBoleta.Name = "NroBoleta";
			this.NroBoleta.Size = new System.Drawing.Size(168, 20);
			this.NroBoleta.TabIndex = 27;
			this.NroBoleta.Text = "";
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.Transparent;
			this.label23.Location = new System.Drawing.Point(328, 29);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(96, 20);
			this.label23.TabIndex = 111;
			this.label23.Text = "Nro de boleta";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Location = new System.Drawing.Point(8, 8);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(136, 20);
			this.label13.TabIndex = 108;
			this.label13.Text = "El librador es cliente?";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// esCliente
			// 
			this.esCliente.Location = new System.Drawing.Point(152, 5);
			this.esCliente.Name = "esCliente";
			this.esCliente.Size = new System.Drawing.Size(16, 16);
			this.esCliente.TabIndex = 22;
			this.esCliente.CheckedChanged += new System.EventHandler(this.esCliente_CheckedChanged);
			// 
			// sucursal
			// 
			this.sucursal.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
			this.sucursal.InputMask = "999";
			this.sucursal.Location = new System.Drawing.Point(152, 53);
			this.sucursal.Name = "sucursal";
			this.sucursal.Size = new System.Drawing.Size(168, 20);
			this.sucursal.TabIndex = 25;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Location = new System.Drawing.Point(8, 53);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(136, 20);
			this.label14.TabIndex = 103;
			this.label14.Text = "Sucursal";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// fechaRecepcion
			// 
			this.fechaRecepcion.Location = new System.Drawing.Point(152, 77);
			this.fechaRecepcion.Name = "fechaRecepcion";
			this.fechaRecepcion.Size = new System.Drawing.Size(168, 21);
			this.fechaRecepcion.TabIndex = 26;
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Location = new System.Drawing.Point(8, 77);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(136, 20);
			this.label16.TabIndex = 98;
			this.label16.Text = "Fecha de recepción";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cuentaBancaria
			// 
			this.cuentaBancaria.BackColor = System.Drawing.SystemColors.Window;
			this.cuentaBancaria.Location = new System.Drawing.Point(152, 29);
			this.cuentaBancaria.Name = "cuentaBancaria";
			this.cuentaBancaria.Size = new System.Drawing.Size(168, 20);
			this.cuentaBancaria.TabIndex = 24;
			this.cuentaBancaria.Text = "";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Location = new System.Drawing.Point(8, 29);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(136, 20);
			this.label17.TabIndex = 96;
			this.label17.Text = "Cuenta bancaria";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// librador
			// 
			this.librador.BackColor = System.Drawing.SystemColors.Window;
			this.librador.Location = new System.Drawing.Point(258, 6);
			this.librador.Name = "librador";
			this.librador.Size = new System.Drawing.Size(352, 20);
			this.librador.TabIndex = 23;
			this.librador.Text = "";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Location = new System.Drawing.Point(200, 8);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(56, 20);
			this.label18.TabIndex = 94;
			this.label18.Text = "Librador";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mzCmbSearchLibrador
			// 
			this.mzCmbSearchLibrador.AllowEditClientePaso = false;
			this.mzCmbSearchLibrador.BackColor = System.Drawing.Color.Transparent;
			this.mzCmbSearchLibrador.DataValue = "";
			this.mzCmbSearchLibrador.EnableCtaCte = false;
			this.mzCmbSearchLibrador.FastSearch = false;
			this.mzCmbSearchLibrador.Location = new System.Drawing.Point(264, 6);
			this.mzCmbSearchLibrador.Name = "mzCmbSearchLibrador";
			this.mzCmbSearchLibrador.SearchObjectListener = null;
			this.mzCmbSearchLibrador.Size = new System.Drawing.Size(348, 20);
			this.mzCmbSearchLibrador.TabIndex = 23;
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.Transparent;
			this.label24.Location = new System.Drawing.Point(328, 53);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(112, 20);
			this.label24.TabIndex = 113;
			this.label24.Text = "Fecha ing. al banco";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Location = new System.Drawing.Point(328, 77);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(104, 20);
			this.label15.TabIndex = 100;
			this.label15.Text = "Fecha de pago";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelDestinatario
			// 
			this.labelDestinatario.BackColor = System.Drawing.Color.Transparent;
			this.labelDestinatario.Location = new System.Drawing.Point(8, 8);
			this.labelDestinatario.Name = "labelDestinatario";
			this.labelDestinatario.Size = new System.Drawing.Size(56, 20);
			this.labelDestinatario.TabIndex = 115;
			this.labelDestinatario.Text = "Proovedor";
			this.labelDestinatario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mzCmbProveedor
			// 
			this.mzCmbProveedor.DataValue = "";
			this.mzCmbProveedor.EditObject = null;
			this.mzCmbProveedor.FastSearch = false;
			this.mzCmbProveedor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbProveedor.HierarchicalSearch = false;
			this.mzCmbProveedor.Location = new System.Drawing.Point(152, 3);
			this.mzCmbProveedor.Name = "mzCmbProveedor";
			this.mzCmbProveedor.ReadOnly = false;
			this.mzCmbProveedor.SearchObject = null;
			this.mzCmbProveedor.SearchObjectListener = null;
			this.mzCmbProveedor.Size = new System.Drawing.Size(344, 22);
			this.mzCmbProveedor.TabIndex = 120;
			this.mzCmbProveedor.Visible = false;
			// 
			// mzComboEditorCuenta
			// 
			this.mzComboEditorCuenta.AutoComplete = true;
			this.mzComboEditorCuenta.DataSource = null;
			this.mzComboEditorCuenta.DisplayMember = "";
			this.mzComboEditorCuenta.DisplayMemberCaption = "";
			this.mzComboEditorCuenta.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzComboEditorCuenta.Location = new System.Drawing.Point(152, 30);
			this.mzComboEditorCuenta.MaxItemsDisplay = 50;
			this.mzComboEditorCuenta.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzComboEditorCuenta.Name = "mzComboEditorCuenta";
			this.mzComboEditorCuenta.Size = new System.Drawing.Size(168, 21);
			this.mzComboEditorCuenta.SorterMember = "";
			this.mzComboEditorCuenta.TabIndex = 121;
			this.mzComboEditorCuenta.ValueMember = "";
			this.mzComboEditorCuenta.ValueMemberCaption = "";
			// 
			// panelTarjeta
			// 
			this.panelTarjeta.BackColor = System.Drawing.Color.Transparent;
			this.panelTarjeta.Controls.Add(this.codigoDiez);
			this.panelTarjeta.Controls.Add(this.label25);
			this.panelTarjeta.Controls.Add(this.cantidadCuotas);
			this.panelTarjeta.Controls.Add(this.label12);
			this.panelTarjeta.Controls.Add(this.lote);
			this.panelTarjeta.Controls.Add(this.label11);
			this.panelTarjeta.Controls.Add(this.fechaAutorizacion);
			this.panelTarjeta.Controls.Add(this.label10);
			this.panelTarjeta.Controls.Add(this.fechaAcreditacion);
			this.panelTarjeta.Controls.Add(this.label9);
			this.panelTarjeta.Controls.Add(this.cupon);
			this.panelTarjeta.Controls.Add(this.label8);
			this.panelTarjeta.Controls.Add(this.codigoAutorizacion);
			this.panelTarjeta.Controls.Add(this.label4);
			this.panelTarjeta.Location = new System.Drawing.Point(0, 168);
			this.panelTarjeta.Name = "panelTarjeta";
			this.panelTarjeta.Size = new System.Drawing.Size(632, 104);
			this.panelTarjeta.TabIndex = 100;
			// 
			// codigoDiez
			// 
			this.codigoDiez.BackColor = System.Drawing.SystemColors.Window;
			this.codigoDiez.Location = new System.Drawing.Point(442, 3);
			this.codigoDiez.Name = "codigoDiez";
			this.codigoDiez.Size = new System.Drawing.Size(168, 20);
			this.codigoDiez.TabIndex = 16;
			this.codigoDiez.Text = "";
			// 
			// label25
			// 
			this.label25.BackColor = System.Drawing.Color.Transparent;
			this.label25.Location = new System.Drawing.Point(328, 3);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(104, 20);
			this.label25.TabIndex = 107;
			this.label25.Text = "Código 10";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cantidadCuotas
			// 
			this.cantidadCuotas.BackColor = System.Drawing.SystemColors.Window;
			this.cantidadCuotas.Location = new System.Drawing.Point(442, 75);
			this.cantidadCuotas.Name = "cantidadCuotas";
			this.cantidadCuotas.Size = new System.Drawing.Size(168, 20);
			this.cantidadCuotas.TabIndex = 21;
			this.cantidadCuotas.Text = "";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Location = new System.Drawing.Point(328, 75);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(104, 20);
			this.label12.TabIndex = 105;
			this.label12.Text = "Cantidad de cuotas";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lote
			// 
			this.lote.BackColor = System.Drawing.SystemColors.Window;
			this.lote.Location = new System.Drawing.Point(152, 75);
			this.lote.Name = "lote";
			this.lote.Size = new System.Drawing.Size(168, 20);
			this.lote.TabIndex = 20;
			this.lote.Text = "";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Location = new System.Drawing.Point(8, 75);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(136, 20);
			this.label11.TabIndex = 103;
			this.label11.Text = "Lote";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// fechaAutorizacion
			// 
			this.fechaAutorizacion.Location = new System.Drawing.Point(152, 51);
			this.fechaAutorizacion.Name = "fechaAutorizacion";
			this.fechaAutorizacion.Size = new System.Drawing.Size(168, 21);
			this.fechaAutorizacion.TabIndex = 18;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(8, 51);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(136, 20);
			this.label10.TabIndex = 100;
			this.label10.Text = "Fecha de autorización";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// fechaAcreditacion
			// 
			this.fechaAcreditacion.Location = new System.Drawing.Point(442, 51);
			this.fechaAcreditacion.Name = "fechaAcreditacion";
			this.fechaAcreditacion.Size = new System.Drawing.Size(168, 21);
			this.fechaAcreditacion.TabIndex = 19;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(328, 51);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(104, 20);
			this.label9.TabIndex = 98;
			this.label9.Text = "Fecha acreditación";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cupon
			// 
			this.cupon.BackColor = System.Drawing.SystemColors.Window;
			this.cupon.Location = new System.Drawing.Point(152, 27);
			this.cupon.Name = "cupon";
			this.cupon.Size = new System.Drawing.Size(168, 20);
			this.cupon.TabIndex = 17;
			this.cupon.Text = "";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(8, 27);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(136, 20);
			this.label8.TabIndex = 96;
			this.label8.Text = "Cupón / Voucher";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// codigoAutorizacion
			// 
			this.codigoAutorizacion.BackColor = System.Drawing.SystemColors.Window;
			this.codigoAutorizacion.Location = new System.Drawing.Point(152, 3);
			this.codigoAutorizacion.Name = "codigoAutorizacion";
			this.codigoAutorizacion.Size = new System.Drawing.Size(168, 20);
			this.codigoAutorizacion.TabIndex = 15;
			this.codigoAutorizacion.Text = "";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(8, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(136, 20);
			this.label4.TabIndex = 94;
			this.label4.Text = "Código de autorización";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.tbbGuardar,
																							  this.tbbAnterior,
																							  this.tbbSeparator,
																							  this.tbbCancelar,
																							  this.tbbSiguiente});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imageList2;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(722, 28);
			this.toolBarStandar.TabIndex = 17;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// tbbGuardar
			// 
			this.tbbGuardar.ImageIndex = 4;
			this.tbbGuardar.Text = "&Aceptar";
			// 
			// tbbAnterior
			// 
			this.tbbAnterior.ImageIndex = 8;
			this.tbbAnterior.Text = "Anterior";
			// 
			// tbbSeparator
			// 
			this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbCancelar
			// 
			this.tbbCancelar.ImageIndex = 7;
			this.tbbCancelar.Text = "&Cancelar";
			// 
			// tbbSiguiente
			// 
			this.tbbSiguiente.ImageIndex = 9;
			this.tbbSiguiente.Text = "Siguiente";
			// 
			// imageList2
			// 
			this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
			this.imageList2.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// UltraExpBar1
			// 
			this.UltraExpBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.UltraExpBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UltraExpBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 311;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Datos Generales";
			this.UltraExpBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																												   ultraExplorerBarGroup1});
			this.UltraExpBar1.Location = new System.Drawing.Point(0, 28);
            this.UltraExpBar1.Name = "ultraExprBar1"; this.UltraExpBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.UltraExpBar1.Size = new System.Drawing.Size(722, 380);
			this.UltraExpBar1.TabIndex = 18;
			this.UltraExpBar1.TabStop = false;
			// 
			// FrmValores
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(722, 408);
			this.ControlBox = false;
			this.Controls.Add(this.UltraExpBar1);
			this.Controls.Add(this.toolBarStandar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmValores";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Valores";
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.panelRetenciones.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fechaRetencion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fechaIngresoRetencion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTipoRetenciones)).EndInit();
			this.panelDatosPrincipales.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtValorDestino)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMonedaDestino)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtValorOrigen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEComprobanteTesoreria)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMonedaOrigen)).EndInit();
			this.panelDatosSecundarios.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzComboEditorEstado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneValorConRecargo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFechaVencimiento)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFecha)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEEntidad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboEditorBanco)).EndInit();
			this.panelCheque.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fechaPago)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fechaIngresoBanco)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fechaRecepcion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboEditorCuenta)).EndInit();
			this.panelTarjeta.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fechaAutorizacion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fechaAcreditacion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UltraExpBar1)).EndInit();
			this.UltraExpBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		
		#region Variables de interface

		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.ComponentModel.IContainer components;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor txtValorDestino;
		private mz.erp.ui.controls.mzComboEditor mzCEMonedaDestino;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor txtValorOrigen;
		private mz.erp.ui.controls.mzComboEditor mzCEComprobanteTesoreria;
		private System.Windows.Forms.Label label7;
		private mz.erp.ui.controls.mzComboEditor mzCEMonedaOrigen;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor txtFechaVencimiento;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor txtFecha;
		private System.Windows.Forms.TextBox txtNumero;
		private mz.erp.ui.controls.mzComboEditor mzCEEntidad;
		private System.Windows.Forms.Label lFechaVencimiento;
		private System.Windows.Forms.Label lFecha;
		private System.Windows.Forms.Label lEntidad;
		private System.Windows.Forms.Label lNumero;
		private System.Windows.Forms.Panel panelDatosSecundarios;
		private System.Windows.Forms.Panel panelDatosPrincipales;
		private System.Windows.Forms.ToolBarButton tbbGuardar;
		private System.Windows.Forms.Label label3;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneValorConRecargo;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private mz.erp.ui.controllers.ValoresController _uiController;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Panel panelCheque;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor fechaPago;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor fechaRecepcion;
		private System.Windows.Forms.TextBox cuentaBancaria;
		private System.Windows.Forms.TextBox librador;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.CheckBox chkIncluyeRecargo;
		private System.Windows.Forms.Panel panelTarjeta;
		private System.Windows.Forms.TextBox cantidadCuotas;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox lote;
		private System.Windows.Forms.Label label11;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor fechaAutorizacion;
		private System.Windows.Forms.Label label10;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor fechaAcreditacion;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox cupon;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox codigoAutorizacion;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panelRetenciones;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor fechaRetencion;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor fechaIngresoRetencion;
		private System.Windows.Forms.TextBox numeroRetencion;
		private mz.erp.ui.controls.mzComboEditor mzCmbTipoRetenciones;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit sucursal;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.CheckBox esCliente;
		private mz.erp.ui.controls.mzCuentasControl mzCmbSearchLibrador;
		private System.Windows.Forms.ImageList imageList2;
		private mz.erp.ui.controls.mzCuentasControl mzCuentasControl1;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TextBox NroBoleta;
		private System.Windows.Forms.Label label24;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor fechaIngresoBanco;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.TextBox codigoDiez;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar UltraExpBar1;
		private System.Windows.Forms.Label labelDestinatario;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.CheckBox checkCruzado;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.CheckBox checkNoOrden;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbProveedor;
		private mz.erp.ui.controls.mzComboEditor mzComboEditorEstado;
		private System.Windows.Forms.Label label28;
		private mz.erp.ui.controls.mzComboEditor mzComboEditorBanco;
		private mz.erp.ui.controls.mzComboEditor mzComboEditorCuenta;
		private System.Windows.Forms.Label labelIncluyeRecargo;

		private bool _showObservable = false;
		
		#endregion

		

		#region Constructores
		
		#region Workflow
		public FrmValores(ValoresController uiController)
		{
			InitializeComponent();
			_uiController = uiController;
			_uiController.ObjectHasChanged += new EventHandler(_uiController_ObjectHasChanged);
			Init();
		}

		#endregion


		#region Observer
		
		public FrmValores(ValoresController uiController, ITaskController taskController)
		{
			InitializeComponent();
			_uiController = uiController;
			_uiController.ObjectHasChanged += new EventHandler(_uiController_ObjectHasChanged);
			_uiController.AddTaskController(taskController);
			Init();
		}
		public FrmValores(ValoresController uiController, ITaskController taskController, string IdCuenta)
		{
			InitializeComponent();
			_uiController = uiController;
			_uiController.ObjectHasChanged += new EventHandler(_uiController_ObjectHasChanged);
			_uiController.AddTaskController(taskController);
			_uiController.IdCuenta = IdCuenta;
			Init();
		}

		public FrmValores(string IdComprobanteTesoreria, string IdMoneda,decimal ValorDefault,decimal porcentajeRecargo, bool Agrupado, string IdValor, ITaskController taskController, string IdCuenta)
		{
			InitializeComponent();
			_uiController = new ValoresController(IdComprobanteTesoreria, IdMoneda, Agrupado,ValorDefault, porcentajeRecargo, IdValor, taskController, IdCuenta);
			_uiController.ObjectHasChanged += new EventHandler(_uiController_ObjectHasChanged);
			Init();
		}
		
		#endregion
	
		private void Init()
		{
			//cuotas
			mzCmbSearchLibrador.Init();
			string cuotas = _uiController.CantidadCuotasDefault();
			if(!cuotas.Equals("NODEFAULT"))
			{
				_uiController.CantidadCuotas = Convert.ToInt16(cuotas);	
			}

			
			cantidadCuotas.ReadOnly = cuotas != "NODEFAULT";
			cantidadCuotas.Enabled = !cantidadCuotas.ReadOnly;
			mzCEMonedaDestino.Enabled = false;
		}

		public System.Windows.Forms.DialogResult ShowFormIObservable()
		{
			_showObservable = true;
			Build_UI();
			habilitarBotonesIObservable();
			return ShowDialog();
		}
		
	
		public System.Windows.Forms.DialogResult ShowFormIObservable(string _titulo)
		{
			_showObservable = true;
			Build_UI();
			habilitarBotonesIObservable();
			this.Text = _titulo;
			return ShowDialog();
		}

		private void Build_UI()
		{
			ConfigureInterface();
			InitEventHandlers();
			InitializeData();
			InitDataBindings();
			InitPaneles();
		}

		private void ConfigureInterface()
		{	//lleno los combos
			mzCmbTipoRetenciones.FillFromDataSource( businessrules.tsy_TiposDeRetenciones.GetList().tsy_TiposDeRetenciones, "idTipoDeRetencion", "Descripcion", 100, "Descripcion");
			mzCEMonedaOrigen.FillFromDataSource( businessrules.tfi_Monedas.GetList().tfi_Monedas, "idMoneda", "Descripcion", 8, "1", "2", "Descripcion");	
			mzCEComprobanteTesoreria.FillFromDataSource(_uiController.ListaTDCompTesoreria(), "idTDCompTesoreria", "Descripcion", 100, "1", "2", "Descripcion");	
			this.mzComboEditorEstado.FillFromDataSource(_uiController.EstadosCheques, "idEstadoCheque", "nombre", 100, "nombre");
			//Por defecto estado NO INDICA, variable de configuracion con el id del no indica
			this.mzComboEditorEstado.DataBindings.Clear();
			mzComboEditorEstado.DataBindings.Add("Value",_uiController, "IdEstado");
			_uiController.IdEstado=_uiController.NoIndica;

		
			
			this.mzComboEditorEstado.Enabled=false;
			mzCEMonedaDestino.FillFromDataSource( businessrules.tfi_Monedas.GetList().tfi_Monedas, "idMoneda", "Descripcion", 8, "1", "2", "Descripcion");	
			mzCEEntidad.FillFromDataSource(_uiController.ListaEntidades,"IdEntidad","Entidad",100,"Entidad");
			this.mzComboEditorBanco.FillFromDataSource(_uiController.Bancos, _uiController.KeyValueBanco, _uiController.KeyListBanco, 100, _uiController.KeyListBanco);
			mzComboEditorBanco.Value = _uiController.IdBanco;
			//configuro enabled y readonly
			mzCEComprobanteTesoreria.Enabled = _uiController.AllowEditTDCompTesoreria;
			mzCEComprobanteTesoreria.ReadOnly = _uiController.IdTDCompTesoreriaReadOnly;
			mzCEMonedaOrigen.Enabled = _uiController.AllowEditTDCompTesoreria;
			mzCEMonedaOrigen.ReadOnly = _uiController.IdTDCompTesoreriaReadOnly;
			mzCEMonedaDestino.Enabled = _uiController.AllowEditTDCompTesoreria;
			mzCEMonedaDestino.ReadOnly = _uiController.IdTDCompTesoreriaReadOnly;
			//inicializa los valores read only por default correspondientes a los importes
			bool read = !_uiController.AllowEditImporte(); 
			txtValorOrigen.ReadOnly = read;
			txtValorDestino.ReadOnly = read;
			uneValorConRecargo.ReadOnly = read;

			labelIncluyeRecargo.Visible = _uiController.AllowShowIncluyeRecargo;
			chkIncluyeRecargo.Visible = _uiController.AllowShowIncluyeRecargo;
            /* Silvina 20110901 - Tarea 0000206 */
            chkIncluyeRecargo.Enabled = false;// _uiController.AllowEditIncluyeRecargo();
            /* Fin Silvina 20110901 - Tarea 0000206 */
			mzCmbProveedor.Visible=false;

			this.mzComboEditorCuenta.FillFromDataSource(_uiController.CuentasBancarias, _uiController.KeyValueCuenta, _uiController.KeyListCuenta, 100, _uiController.KeyListCuenta);	
			KeyPreview = true;
		}


	
		private void InitEventHandlers()
		{
			_uiController.ModelChanged +=new EventHandler(Refresh);
			toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			txtValorOrigen.Enter +=new EventHandler(Editor_Enter);
			txtValorDestino.Enter +=new EventHandler(Editor_Enter);
			mzCmbSearchLibrador.ValueChanged +=new EventHandler(mzCmbSearchLibrador_ValueChanged);
			this.checkCruzado.CheckedChanged+=new EventHandler(checkCruzado_CheckedChanged);
			this.checkNoOrden.CheckedChanged+=new EventHandler(checkNoOrden_CheckedChanged);
			this.mzComboEditorBanco.ValueChanged+=new EventHandler(mzComboEditorBanco_ValueChanged);
			if(!_showObservable )
			{
				KeyDownManager KeyDownMan = new KeyDownManager(this);	
			}
			else
				this.KeyDown +=new KeyEventHandler(FrmValores_KeyDown);
		}

		private void InitializeData()
		{
			fechaIngresoBanco.Nullable = true;
			fechaIngresoBanco.NullText = "No definida";
			fechaPago.Nullable = true;
			fechaPago.NullText = "No definida";
			mzCmbProveedor.SearchObject = _uiController.ProveedoresSearchObject;
			checkCruzado.Checked = _uiController.Cruzado;
			checkNoOrden.Checked = _uiController.Sellado;
			//ChequearTipoDeCheque();
			//seteo el librador por default
			if (_uiController.DatoAuxiliar.IdCuenta != null && _uiController.DatoAuxiliar.IdCuenta != string.Empty)
			{
				System.Data.DataRow row = mz.erp.businessrules.tsa_Cuentas.GetByPk(_uiController.DatoAuxiliar.IdCuenta);
				if(row != null)
					mzCmbSearchLibrador.DataValue = Convert.ToString(row["Codigo"]);
			}

		}


		private void ChequearTipoDeCheque()
		{
			esCliente.Visible=true;
			label13.Visible=true;
			label18.Visible=true;
			this.labelDestinatario.Visible=false;
			mzCmbProveedor.Visible=false;
			mzCEEntidad.Visible=true;
			cuentaBancaria.Visible=true;
			string idLibrador=_uiController.DatoAuxiliar.IdCuenta;
				
			//si es cheque del cliente o diferido del cliente, no tiene q dejar cambiar el nombre del cliente
			//si es de terceros permitir cambiar el check
			
			//lo dejo chequeado si tiene un cliente y no es de terceros
			if (!_uiController.PerteneceATerceros(_uiController.IdTDCompTesoreria)){
				esCliente.Checked =  (idLibrador != null && idLibrador!= string.Empty );
				
			}
			
			else {
				esCliente.Checked = librador.Text != string.Empty;
				}
			
			//actualizo el "librador" visible
			if (esCliente.Checked)
			{
				mzCmbSearchLibrador.Visible= true;
				librador.Visible = false;
			}
			else
			{
				mzCmbSearchLibrador.Visible= false;
				librador.Visible = true;
			}
			if (_uiController.PerteneceAPropio((_uiController.IdTDCompTesoreria))){

				esCliente.Visible=false;
				label13.Visible=false;
				label18.Visible=false;
				mzCEEntidad.Visible=false;
				cuentaBancaria.Visible=false;
				mzComboEditorCuenta.Visible=true;
				mzComboEditorBanco.Visible=true;
				mzCmbSearchLibrador.Visible=false;
				librador.Visible=false;
				//Si es propio entonces el librador es la empresa
			
				//Tendria q tener por value el proveedor al q se le esta pagando
				this.labelDestinatario.Visible=true;
				mzCmbProveedor.Visible=true;
				//mzCmbProveedor.Enabled=false;
				
				
			}

			//lo deja disponible para modificar si pertenece a terceros 
			esCliente.Enabled = _uiController.PerteneceATerceros(_uiController.IdTDCompTesoreria) || (idLibrador == string.Empty);
			librador.Enabled = esCliente.Enabled;
			mzCmbSearchLibrador.Enabled = esCliente.Enabled;
			
		}

		private void InitDataBindings()
		{
			//datos principales
			BindingController.Bind(mzCmbProveedor,"DataValue",_uiController,"KeyValueProveedores");
			BindingController.Clear(mzCEComprobanteTesoreria, "Value", _uiController, "IdTDCompTesoreria");
			BindingController.Bind(mzCEComprobanteTesoreria, "Value", _uiController, "IdTDCompTesoreria");
					
			mzCEMonedaDestino.DataBindings.Clear();
			mzCEMonedaDestino.DataBindings.Add("Value",_uiController, "IdMonedaReferencia");
			mzCEMonedaOrigen.DataBindings.Clear();
			mzCEMonedaOrigen.DataBindings.Add("Value",_uiController, "IdMoneda");
			
			txtValorOrigen.DataBindings.Clear();
			txtValorOrigen.DataBindings.Add("Value", _uiController, "Monto");
			txtValorDestino.DataBindings.Clear();
			txtValorDestino.DataBindings.Add("Value", _uiController, "MontoCotizado");
		
			//datos secundarios
			mzCEEntidad.DataBindings.Clear();
			mzCEEntidad.DataBindings.Add("Value",_uiController, "IdEntidad");
			uneValorConRecargo.DataBindings.Clear();
			uneValorConRecargo.DataBindings.Add("Value", _uiController, "MontoCotizadoConRecargos");
			
			txtFecha.DataBindings.Clear();
			txtFecha.DataBindings.Add("Value", _uiController, "Fecha");
			txtFechaVencimiento.DataBindings.Clear();
			txtFechaVencimiento.DataBindings.Add("Value", _uiController, "FechaVencimiento");
			txtNumero.DataBindings.Clear();
			txtNumero.DataBindings.Add("Text",_uiController,"Numero");
			
			//datos de cheque
			fechaPago.DataBindings.Clear();
			fechaPago.DataBindings.Add( "Value", _uiController, "FechaDePago");
			
			librador.DataBindings.Clear();
			librador.DataBindings.Add( "Text", _uiController, "Librador");
			fechaRecepcion.DataBindings.Clear();
			fechaRecepcion.DataBindings.Add("Value", _uiController, "FechaDeRecepcion");
			sucursal.DataBindings.Clear();
			sucursal.DataBindings.Add( "Text", _uiController, "Sucursal");
			cuentaBancaria.DataBindings.Clear();
			cuentaBancaria.DataBindings.Add( "Text", _uiController, "CuentaBancaria");
			NroBoleta.DataBindings.Clear();
			NroBoleta.DataBindings.Add("Text", _uiController, "NroBoleta");
			fechaIngresoBanco.DataBindings.Clear();
			fechaIngresoBanco.DataBindings.Add("Value", _uiController, "FechaIngresoBanco");
			mzComboEditorCuenta.DataBindings.Clear();
			mzComboEditorCuenta.DataBindings.Add( "Value", _uiController, "CuentaBancaria");
			//datos de tarjeta
			codigoAutorizacion.DataBindings.Clear();
			codigoAutorizacion.DataBindings.Add( "Text", _uiController, "CodigoAutorizacion");
			cupon.DataBindings.Clear();
			cupon.DataBindings.Add( "Text", _uiController, "Cupon");
			fechaAutorizacion.DataBindings.Clear();
			fechaAutorizacion.DataBindings.Add( "Value", _uiController, "FechaDeAutorizacion");
			lote.DataBindings.Clear();
			lote.DataBindings.Add( "Text", _uiController, "lote");
			fechaAcreditacion.DataBindings.Clear();
			fechaAcreditacion.DataBindings.Add( "Value", _uiController, "FechaDeAcreditacion");
			cantidadCuotas.DataBindings.Clear();
			cantidadCuotas.DataBindings.Add( "Text", _uiController, "CantidadCuotas");
			codigoDiez.DataBindings.Clear();
			codigoDiez.DataBindings.Add("Text", _uiController, "CodigoDiez");
			//datos de retenciones
			mzCmbTipoRetenciones.DataBindings.Clear();
			mzCmbTipoRetenciones.DataBindings.Add("Value", _uiController, "IdTipoDeRetencion");
			fechaRetencion.DataBindings.Clear();
			fechaRetencion.DataBindings.Add("Value", _uiController, "FechaComprobanteRetencion");
			fechaIngresoRetencion.DataBindings.Clear();									
			fechaIngresoRetencion.DataBindings.Add("Value", _uiController, "FechaIngresoRetencion");	
			numeroRetencion.DataBindings.Clear();
			numeroRetencion.DataBindings.Add("Text",_uiController,"Numero");
			chkIncluyeRecargo.DataBindings.Clear();
			chkIncluyeRecargo.DataBindings.Add("Checked", _uiController, "IncluyeRecargo");
			
			SetCamposVisibles();
			SetCamposNoEditables();
			ChequearTipoDeCheque();
			

		}

		

		#endregion

		#region Destructores
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
				BindingController.Clear(mzCEComprobanteTesoreria,"Value", _uiController,"IdTDCompTesoreria");
			}
			base.Dispose( disposing );
		}

		#endregion
			
		private void Refresh(object sender, EventArgs e)
		{
			this.mzComboEditorEstado.DataBindings.Clear();
			mzComboEditorEstado.DataBindings.Add("Value",_uiController, "IdEstado");
			
			mzCEEntidad.FillFromDataSource(_uiController.ListaEntidades,"IdEntidad","Entidad",100,"Entidad");
			mzCEEntidad.DataBindings.Clear();
			mzCEEntidad.DataBindings.Add("Value",_uiController, "IdEntidad");
			mzCEMonedaDestino.DataBindings.Clear();
			mzCEMonedaDestino.DataBindings.Add("Value",_uiController, "IdMonedaReferencia");
			mzCEMonedaOrigen.DataBindings.Clear();
			mzCEMonedaOrigen.DataBindings.Add("Value",_uiController, "IdMoneda");
            /* Silvina 20110222 - Tarea 0000012 */
            _uiController.SetPorcentaje();
            /* Fin Silvina */
			txtValorOrigen.DataBindings.Clear();
			txtValorOrigen.DataBindings.Add("Value", _uiController, "Monto");
			txtValorDestino.DataBindings.Clear();
			txtValorDestino.DataBindings.Add("Value", _uiController, "MontoCotizado");
			uneValorConRecargo.DataBindings.Clear();
			uneValorConRecargo.DataBindings.Add("Value", _uiController, "MontoCotizadoConRecargos");
			txtFecha.DataBindings.Clear();
			txtFecha.DataBindings.Add("Value", _uiController, "Fecha");
			txtFechaVencimiento.DataBindings.Clear();
			txtFechaVencimiento.DataBindings.Add("Value", _uiController, "FechaVencimiento");
			txtNumero.DataBindings.Clear();
			txtNumero.DataBindings.Add("Text",_uiController,"Numero");
			cuentaBancaria.DataBindings.Clear();
			cuentaBancaria.DataBindings.Add( "Text", _uiController, "CuentaBancaria");
			//retenciones
			mzCmbTipoRetenciones.DataBindings.Clear();
			mzCmbTipoRetenciones.DataBindings.Add("Value", _uiController, "IdTipoDeRetencion");
			fechaRetencion.DataBindings.Clear();
			fechaRetencion.DataBindings.Add("Value", _uiController, "FechaComprobanteRetencion");
			fechaIngresoRetencion.DataBindings.Clear();									
			fechaIngresoRetencion.DataBindings.Add("Value", _uiController, "FechaIngresoRetencion");	
			numeroRetencion.DataBindings.Clear();
			numeroRetencion.DataBindings.Add("Text",_uiController,"Numero");
			NroBoleta.DataBindings.Clear();
			NroBoleta.DataBindings.Add("Text", _uiController, "NroBoleta");
			codigoDiez.DataBindings.Clear();
			codigoDiez.DataBindings.Add("Text", _uiController, "CodigoDiez");
			fechaIngresoBanco.DataBindings.Clear();
			fechaIngresoBanco.DataBindings.Add("Value", _uiController, "FechaIngresoBanco" );
			//seteos varios
			SetCamposVisibles();
			SetCamposNoEditables();
			ChequearTipoDeCheque();
		}


		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			//este metodo se utiliza para sacar el foco, debido a q de la otra forma, no se por q no anda!
			this.SelectNextControl(this.mzCEComprobanteTesoreria, true, true, true, true);
			switch ( toolBarStandar.Buttons.IndexOf(e.Button))
			{
				case 0: //Aceptar de IObserver
					if (!_uiController.HasErrors() )
					{
						Util.MoveFocus(ultraExplorerBarContainerControl1);
						_uiController.AcceptEdit();
						_uiController.ProcessObjectsObserver();
						this.DialogResult = System.Windows.Forms.DialogResult.OK;
					}
					else 
					{
						if(_uiController.GetErrors().Count > 0)
						{
							/*20110328 - Tarea 0000057*/ FrmShowErrors _form = new /*20110328 - Tarea 0000057*/ FrmShowErrors( _uiController.GetErrors() );
							_form.ShowDialog();
						}
					}
					break;
				case 1: //anterior del WF
					_uiController.Previous();
					break;
				
				case 3: // cancelar de IObserver
					_uiController.CancelEdit();
					this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
					break;
				case 4://siguiente del WF
					_uiController.Execute();
					break;
			}		
		}


		public void AddObjectListener(IObserver observer)
		{
			_uiController.AddObjectListener(observer);
		}

	
		private void Editor_Enter(object sender, EventArgs e)
		{
			Infragistics.Win.UltraWinEditors.UltraNumericEditor editor = (Infragistics.Win.UltraWinEditors.UltraNumericEditor)sender;
			editor.SelectAll();
		}

		
		private void txtValorOrigen_Click(object sender, System.EventArgs e)
		{	
			txtValorOrigen.SelectAll();		
		}

		
		private void mzCEComprobanteTesoreria_ValueChanged(object sender, System.EventArgs e)
		{
 			System.Data.DataTable table = businessrules.tfi_TDCompTesoreria_Entidades.GetList(Convert.ToString(mzCEComprobanteTesoreria.Value)).tfi_TDCompTesoreria_Entidades;
			if (table.Rows.Count > 0 )
			{
				mzCEEntidad.FillFromDataSource(table,"IdEntidad","Entidad",100,"Entidad");
				//mzCEEntidad.Value = _uiController.IdEntidad;
				mzCEEntidad.DataBindings.Clear();
				mzCEEntidad.DataBindings.Add("Value",_uiController, "IdEntidad");
			}
		}

	
		private void SetCamposNoEditables()
		{
			//pongo no editables los q estan configurados en la variable					
			string strCampos = _uiController.CamposNoEditables();
			string[] campos = strCampos.Split( ',' );
			ArrayList _arrayCampos= new ArrayList( campos );
			foreach(string componente in _arrayCampos)
			{
				switch ( componente )
				{
						#region datos secundarios
					case "entidad": 
						mzCEEntidad.ReadOnly = true;
						mzCEEntidad.Enabled = false;
						break;
					case "numero": 
						txtNumero.ReadOnly = true;
						txtNumero.Enabled = false;
						break;
					case "fechaEmision": 
						txtFecha.ReadOnly = true;
						txtFecha.Enabled = false;
						break;
					case "fechaVencimiento": 
						txtFechaVencimiento.ReadOnly = true;
						txtFechaVencimiento.Enabled = false;
						break;
						#endregion
						#region tarjetas
					case "codigoAutorizacion": 
						codigoAutorizacion.ReadOnly = true;
						codigoAutorizacion.Enabled = false;
						break;
					case "cupon": 
						cupon.ReadOnly = true;
						cupon.Enabled = false;
						break;
					case "fechaAcreditacion": 
						fechaAcreditacion.ReadOnly = true;
						fechaAcreditacion.Enabled = false;
						break;
					case "fechaAutorizacion": 
						fechaAutorizacion.ReadOnly = true;
						fechaAutorizacion.Enabled = false;
						break;
					case "lote": 
						lote.ReadOnly = true;
						lote.Enabled = false;
						break;
					case "cantidadCuotas": 
						cantidadCuotas.ReadOnly = true;
						cantidadCuotas.Enabled = false;
						break;
					case "codigoDiez":
						codigoDiez.ReadOnly = true;
						codigoDiez.Enabled = false;
						break;
						#endregion
						#region cheques
					case "cuentaBancaria": 
						cuentaBancaria.ReadOnly = true;
						cuentaBancaria.Enabled = false;
						break;
					case "librador": 
						librador.ReadOnly = true;
						librador.Enabled = false;
						break;
					case "sucursal": 
						sucursal.ReadOnly = true;
						sucursal.Enabled = false;
						break;
					case "fechaPago": 
						fechaPago.ReadOnly = true;
						fechaPago.Enabled = false;
						break;
					case "fechaRecepcion": 
						fechaRecepcion.ReadOnly = true;
						fechaRecepcion.Enabled = false;
						break;
					case "nroBoleta":
						NroBoleta.ReadOnly = true;
						NroBoleta.Enabled = false;
						break;
					case "fechaIngresoBanco":
						fechaIngresoBanco.ReadOnly = true;
						fechaIngresoBanco.Enabled=false;
						break;
						#endregion
						#region retenciones
					case "fechaRetencion": 
						fechaRetencion.ReadOnly = true;
						fechaRetencion.Enabled = false;
						break;
					case "fechaIngresoRetencion": 
						fechaIngresoRetencion.ReadOnly = true;
						fechaIngresoRetencion.Enabled = false;
						break;
					case "tipoRetencion":	
						mzCmbTipoRetenciones.ReadOnly = true;
						mzCmbTipoRetenciones.Enabled = false;
						break;
						#endregion
				}
			}
		}
		
		private void SetCamposVisibles()
		{			
			
			//poner todos invisibles
			codigoAutorizacion.Visible = false;
			cupon.Visible = false;
			fechaAcreditacion.Visible = false;
			fechaAutorizacion.Visible = false;
			lote.Visible = false;
			cantidadCuotas.Visible = false;
			codigoDiez.Visible = false;
			cuentaBancaria.Visible = false;
			librador.Visible = false;
			sucursal.Visible = false;
			fechaPago.Visible = false;
			fechaIngresoBanco.Visible = false;
			fechaRecepcion.Visible = false;
			NroBoleta.Visible = false;
			label4.Visible = false;
			label8.Visible = false;
			label9.Visible = false;
			label10.Visible = false;
			label11.Visible = false;
			label12.Visible = false;
			label17.Visible = false;
			label18.Visible = false;
			label14.Visible = false;
			label15.Visible = false;
			label16.Visible = false;
			label23.Visible = false;
			label24.Visible = false;
			label25.Visible = false;

			//seteo visibles solo los q corresponden a ese tipo de forma de pago
			string strCampos = _uiController.CamposVisibles();
			string[] campos = strCampos.Split( ',' );
			ArrayList _arrayCampos= new ArrayList( campos );
			foreach(string componente in _arrayCampos)
			{
				switch ( componente )
				{
					case "codigoAutorizacion":
						label4.Visible=true;
						codigoAutorizacion.Visible = true;
						break;
					case "cupon":
						label8.Visible= true;
						cupon.Visible = true;
						break;
					case "fechaAcreditacion":
						label9.Visible=true;
						fechaAcreditacion.Visible = true;
						break;
					case "fechaAutorizacion":
						label10.Visible=true;
						fechaAutorizacion.Visible = true;
						break;
					case "lote":
						label11.Visible=true;
						lote.Visible = true;
						break;
					case "cantidadCuotas":
						label12.Visible=true;
						cantidadCuotas.Visible = true;
						break;
					case "codigoDiez":
						label25.Visible = true;
						codigoDiez.Visible = true;
						break;
					case "cuentaBancaria":
						label17.Visible=true;
						cuentaBancaria.Visible = true;
						break;
					case "librador":
						label18.Visible=true;
						librador.Visible = true;
						mzCmbSearchLibrador.Visible = false;
						break;
					case "sucursal":
						label14.Visible=true;
						sucursal.Visible = true;
						break;
					case "fechaPago":
						label15.Visible=true;
						fechaPago.Visible = true;
						break;
					case "fechaRecepcion":
						label16.Visible=true;
						fechaRecepcion.Visible = true;
						fechaRecepcion.ReadOnly = _uiController.FechaDeRecepcionReadOnly;
						break;
					case "fechaIngresoBanco":
						label24.Visible = true;
						fechaIngresoBanco.Visible = true;
						break;
					case "nroBoleta":
						label23.Visible = true;
						NroBoleta.Visible = true;
						break;
				}
			}
		}

		
		private void InitPaneles()
		{
			//controlo el panel de datos visibles
			if (_uiController.VisiblePanelDatosSecundarios() && (!_uiController.PerteneceARetenciones(_uiController.IdTDCompTesoreria)))
				panelDatosSecundarios.Visible = true;
			else 	
				panelDatosSecundarios.Visible = false;
			//controlo los paneles de cheque, retenciones y tarjeta
			panelTarjeta.Visible = _uiController.PerteneceATarjeta(_uiController.IdTDCompTesoreria);
			panelCheque.Visible = _uiController.PerteneceACheque(_uiController.IdTDCompTesoreria);
			panelRetenciones.Visible = _uiController.PerteneceARetenciones(_uiController.IdTDCompTesoreria);
			//controlo los labels de numero de comprobante
			if (_uiController.PerteneceATarjeta(_uiController.IdTDCompTesoreria))
			{
				lNumero.Text="Número de Tarjeta";
				lFechaVencimiento.Text = "Fecha de Validez";
			}
			if (_uiController.PerteneceACheque(_uiController.IdTDCompTesoreria))
			{
				
				lNumero.Text="Número de Cheque";
				lFechaVencimiento.Text = "Fecha de Cobro";
				if(_uiController.PerteneceAPropio(_uiController.IdTDCompTesoreria))
					_uiController.IdEstado=_uiController.EnCarteraSinRetirar;
					
				else //Todos los cheques estaran en cartera salvo q sean propios
					_uiController.IdEstado=_uiController.EnCartera;
			
			}
					
		}

	
		private void _uiController_ObjectHasChanged(object sender, EventArgs e)
		{
			InitPaneles();
			Refresh(this, new EventArgs());
		}


		#region Miembros de ITaskForm
		
		public virtual void ShowForm()
		{
			_showObservable = false;
			Build_UI();
			habilitarBotonesWorkflow();
			if(this._uiController.AllowShow())
			{
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
			Close();
		}

		public void KeyDownPrevious()
		{
			_uiController.Previous();
		}

		public void KeyDownNext()
		{
			_uiController.Execute();
		}

		public void Execute()
		{
			_uiController.Execute();
		}

		public void Previous()
		{
			_uiController.Previous();
		}

		#endregion

		private void habilitarBotonesIObservable()
		{
			tbbGuardar.Visible = true;
			tbbCancelar.Visible = true;
			tbbAnterior.Visible = false;
			tbbSiguiente.Visible = false;
		}

		private void habilitarBotonesWorkflow()
		{
			tbbGuardar.Visible = false;
			tbbCancelar.Visible = false;
			tbbAnterior.Visible = true;
			tbbSiguiente.Visible = true;
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSiguiente.Enabled = _uiController.IsNextState();
		}		

		private void FrmValores_Activated(object sender, EventArgs e)
		{
			InitPaneles();
			this.Invalidate();
			this.Update();			
		}

		private void FrmValores_VisibleChanged(object sender, EventArgs e)
		{
			InitPaneles();

		}

		private void panelCheque_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

	
		private void esCliente_CheckedChanged(object sender, System.EventArgs e)
		{
			mzCmbSearchLibrador.Visible = esCliente.Checked;
			librador.Visible = !esCliente.Checked;
		}

		private void mzCmbSearchLibrador_ValueChanged(object sender, EventArgs e)
		{
			if (mzCmbSearchLibrador.DataValue != null && mzCmbSearchLibrador.DataValue != string.Empty)
			{	
				System.Data.DataRow  row = mz.erp.businessrules.tsa_Cuentas.GetByCodigo(mzCmbSearchLibrador.DataValue);
				if(row != null)
				{
					string nombre = Convert.ToString(row["Nombre"]);
					_uiController.Librador = nombre;
					_uiController.DatoAuxiliar.IdCuenta = mz.erp.businessrules.tsa_Cuentas.GetByCodigo(mzCmbSearchLibrador.DataValue).IdCuenta;
					this.Refresh(this, new EventArgs());
				}
			}	
		}
		
		#region Miembros de ISearchObjectListener

		public void processEventChange(object sender, EventArgs e)
		{
			// TODO: agregar la implementación FrmComprobantesDePago.processEventChange
		}

		#endregion

		private void checkCruzado_CheckedChanged(object sender, EventArgs e)
		{
			if (checkCruzado.Checked)
				_uiController.Cruzado=true;
			else
				_uiController.Cruzado=false;
		}

		private void checkNoOrden_CheckedChanged(object sender, EventArgs e)
		{
			if (checkNoOrden.Checked)
				_uiController.Sellado=true;
			else
				_uiController.Sellado=false;
		}

		private void mzComboEditorBanco_ValueChanged(object sender, EventArgs e)
		{
			if(mzComboEditorBanco.Value!=null)
			{
				_uiController.IdBanco = Convert.ToString(mzComboEditorBanco.Value);
				//_uiController.IdEntidad = Convert.ToString(mzComboEditorBanco.Value);
				_uiController.IdCuenta=string.Empty;
				this.mzComboEditorCuenta.Enabled=true;
				this.mzComboEditorCuenta.FillFromDataSource(_uiController.CuentasBancarias, _uiController.KeyValueCuenta, _uiController.KeyListCuenta, 100, _uiController.KeyListCuenta);	
			
			}

		}

		private void FrmValores_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == System.Windows.Forms.Keys.Enter)
			{
				if (!_uiController.HasErrors() )
				{
					Util.MoveFocus(ultraExplorerBarContainerControl1);
					_uiController.AcceptEdit();
					_uiController.ProcessObjectsObserver();
					this.DialogResult = System.Windows.Forms.DialogResult.OK;
				}
				else 
				{
					if(_uiController.GetErrors().Count > 0)
					{
						/*20110328 - Tarea 0000057*/ FrmShowErrors _form = new /*20110328 - Tarea 0000057*/ FrmShowErrors( _uiController.GetErrors() );
						_form.ShowDialog();
					}
				}
			}
			if(e.KeyCode == System.Windows.Forms.Keys.Escape)
			{
				_uiController.CancelEdit();
				this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			}
		}
	}
}

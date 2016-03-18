using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using mz.erp.commontypes;
using mz.erp.ui.controls;
using mz.erp.ui.forms.classes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmModificarPreciosMasivo.
	/// </summary>
	public class FrmModificarPreciosMasivo : System.Windows.Forms.Form,  ITaskForm
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl containerProductos;
		private mz.erp.ui.controls.mzProductosControl mzProductosControl;
		private Janus.Windows.GridEX.GridEX gridProductos;
		private System.Windows.Forms.Label label9;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl containerDatosVenta;
		private System.Windows.Forms.GroupBox groupNuevoCosto;
		private System.Windows.Forms.Label labelSimboloMonedaPrecioDeListaConImpuestos;
		private System.Windows.Forms.Label label2;
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
		private System.Windows.Forms.Label label7;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneMAC;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.CheckBox chkValorConstante;
		private System.Windows.Forms.CheckBox chkProcentaje;
		private System.Windows.Forms.CheckBox chkPrecioDeCosto;
		private System.Windows.Forms.CheckBox chkPrecioDeVentaBruto;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneValorConstante;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePorcentaje;
		private Infragistics.Win.Misc.UltraButton utbActualizarPrecios;
		private Infragistics.Win.Misc.UltraButton utbDeshacer;
		private mz.erp.ui.controls.mzComboEditor mzCEMonedas;
		private mz.erp.ui.controls.mzComboEditor mzCEFuentesDeCambio;
		private System.Windows.Forms.CheckBox chkMAC;
		private System.Windows.Forms.Label labelTarea;
		private System.Windows.Forms.CheckBox chkAplicaCostoAfectaPVP;
		private System.Windows.Forms.RadioButton rbAplicaCostoAfectaPVPTodosTrasladaIncremento;
		private System.Windows.Forms.RadioButton rbAplicaCostoAfectaPVPTodos;
		private System.Windows.Forms.RadioButton rbAplicaCostoAfectaPVPCondicional;
		private System.Windows.Forms.RadioButton rbAplicaCostoAfectaPVPCondicionalTrasladaIncremento;
		private System.Windows.Forms.RadioButton rbAplicaPVP;
		private System.Windows.Forms.RadioButton rbAplicaPVS;
		private System.Windows.Forms.RadioButton rbAplicaCostoAfectaPVPTodosIgualPVS;
		private System.Windows.Forms.RadioButton rbAplicaCostoAfectaPVPCondicionalIgualPVS;
		private System.Windows.Forms.CheckBox chkAplicaPVSAfectaPVP;
		private System.Windows.Forms.RadioButton rbAplicaPVSAfectaPVPCondicional;
		private System.Windows.Forms.RadioButton rbAplicaPVSAfectaPVPCondicionalTrasladaIncremento;
		private System.Windows.Forms.RadioButton rbAplicaPVSAfectaPVPCondicionalIgualPVS;
		private System.Windows.Forms.RadioButton rbAplicaPVSAfectaPVPTodos;
		private System.Windows.Forms.RadioButton rbAplicaPVSAfectaPVPTodosTrasladaIncremento;
		private System.Windows.Forms.RadioButton rbAplicaPVSAfectaPVPTodosIgualPVS;
		private System.Windows.Forms.CheckBox chkAplicaMACAfectaPVP;
		private System.Windows.Forms.RadioButton rbAplicaMACAfectaPVPCondicional;
		private System.Windows.Forms.RadioButton rbAplicaMACAfectaPVPCondicionalTrasladaIncremento;
		private System.Windows.Forms.RadioButton rbAplicaMACAfectaPVPCondicionalIgualPVS;
		private System.Windows.Forms.RadioButton rbAplicaMACAfectaPVPTodos;
		private System.Windows.Forms.RadioButton rbAplicaMACAfectaPVPTodosTrasladaIncremento;
		private System.Windows.Forms.RadioButton rbAplicaMACAfectaPVPTodosIgualPVS;
		private System.Windows.Forms.GroupBox gbAplicaCosto;
		private System.Windows.Forms.GroupBox gbAfectaCostoAfectaPVP;
		private System.Windows.Forms.GroupBox gbAplicaCostoAfectaPVPCondicional;
		private System.Windows.Forms.GroupBox gbAplicaCostoAfectaPVPTodos;
		private System.Windows.Forms.GroupBox gbAplicaPrecioDeVenta;
		private System.Windows.Forms.GroupBox gbAplicaPrecioVentaAfectaPVP;
		private System.Windows.Forms.GroupBox gbAplicaPVSAfectaPVPCondicional;
		private System.Windows.Forms.GroupBox gbAplicaPVSAfectaPVPTodos;
		private System.Windows.Forms.GroupBox gbAplicaMAC;
		private System.Windows.Forms.GroupBox gbAplicaMACAfectaPVP;
		private System.Windows.Forms.GroupBox gbAplicaMACAfectaPVPCondicional;
		private System.Windows.Forms.GroupBox gbAplicaMACAfectaPVPTodos;
		private System.ComponentModel.IContainer components;

		

		

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmModificarPreciosMasivo));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.chkPrecioDeVentaBruto = new System.Windows.Forms.CheckBox();
			this.chkMAC = new System.Windows.Forms.CheckBox();
			this.mzCEFuentesDeCambio = new mz.erp.ui.controls.mzComboEditor();
			this.chkPrecioDeCosto = new System.Windows.Forms.CheckBox();
			this.gbAplicaCosto = new System.Windows.Forms.GroupBox();
			this.chkAplicaCostoAfectaPVP = new System.Windows.Forms.CheckBox();
			this.gbAfectaCostoAfectaPVP = new System.Windows.Forms.GroupBox();
			this.rbAplicaCostoAfectaPVPCondicional = new System.Windows.Forms.RadioButton();
			this.gbAplicaCostoAfectaPVPCondicional = new System.Windows.Forms.GroupBox();
			this.rbAplicaCostoAfectaPVPCondicionalTrasladaIncremento = new System.Windows.Forms.RadioButton();
			this.rbAplicaCostoAfectaPVPCondicionalIgualPVS = new System.Windows.Forms.RadioButton();
			this.rbAplicaCostoAfectaPVPTodos = new System.Windows.Forms.RadioButton();
			this.gbAplicaCostoAfectaPVPTodos = new System.Windows.Forms.GroupBox();
			this.rbAplicaCostoAfectaPVPTodosTrasladaIncremento = new System.Windows.Forms.RadioButton();
			this.rbAplicaCostoAfectaPVPTodosIgualPVS = new System.Windows.Forms.RadioButton();
			this.mzCEMonedas = new mz.erp.ui.controls.mzComboEditor();
			this.utbDeshacer = new Infragistics.Win.Misc.UltraButton();
			this.utbActualizarPrecios = new Infragistics.Win.Misc.UltraButton();
			this.uneValorConstante = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.unePorcentaje = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.chkProcentaje = new System.Windows.Forms.CheckBox();
			this.chkValorConstante = new System.Windows.Forms.CheckBox();
			this.gbAplicaPrecioDeVenta = new System.Windows.Forms.GroupBox();
			this.chkAplicaPVSAfectaPVP = new System.Windows.Forms.CheckBox();
			this.gbAplicaPrecioVentaAfectaPVP = new System.Windows.Forms.GroupBox();
			this.rbAplicaPVSAfectaPVPCondicional = new System.Windows.Forms.RadioButton();
			this.gbAplicaPVSAfectaPVPCondicional = new System.Windows.Forms.GroupBox();
			this.rbAplicaPVSAfectaPVPCondicionalTrasladaIncremento = new System.Windows.Forms.RadioButton();
			this.rbAplicaPVSAfectaPVPCondicionalIgualPVS = new System.Windows.Forms.RadioButton();
			this.rbAplicaPVSAfectaPVPTodos = new System.Windows.Forms.RadioButton();
			this.gbAplicaPVSAfectaPVPTodos = new System.Windows.Forms.GroupBox();
			this.rbAplicaPVSAfectaPVPTodosTrasladaIncremento = new System.Windows.Forms.RadioButton();
			this.rbAplicaPVSAfectaPVPTodosIgualPVS = new System.Windows.Forms.RadioButton();
			this.rbAplicaPVP = new System.Windows.Forms.RadioButton();
			this.rbAplicaPVS = new System.Windows.Forms.RadioButton();
			this.gbAplicaMAC = new System.Windows.Forms.GroupBox();
			this.chkAplicaMACAfectaPVP = new System.Windows.Forms.CheckBox();
			this.gbAplicaMACAfectaPVP = new System.Windows.Forms.GroupBox();
			this.rbAplicaMACAfectaPVPCondicional = new System.Windows.Forms.RadioButton();
			this.gbAplicaMACAfectaPVPCondicional = new System.Windows.Forms.GroupBox();
			this.rbAplicaMACAfectaPVPCondicionalTrasladaIncremento = new System.Windows.Forms.RadioButton();
			this.rbAplicaMACAfectaPVPCondicionalIgualPVS = new System.Windows.Forms.RadioButton();
			this.rbAplicaMACAfectaPVPTodos = new System.Windows.Forms.RadioButton();
			this.gbAplicaMACAfectaPVPTodos = new System.Windows.Forms.GroupBox();
			this.rbAplicaMACAfectaPVPTodosTrasladaIncremento = new System.Windows.Forms.RadioButton();
			this.rbAplicaMACAfectaPVPTodosIgualPVS = new System.Windows.Forms.RadioButton();
			this.containerProductos = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.mzProductosControl = new mz.erp.ui.controls.mzProductosControl();
			this.gridProductos = new Janus.Windows.GridEX.GridEX();
			this.label9 = new System.Windows.Forms.Label();
			this.containerDatosVenta = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.groupNuevoCosto = new System.Windows.Forms.GroupBox();
			this.labelSimboloMonedaPrecioDeListaConImpuestos = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
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
			this.label7 = new System.Windows.Forms.Label();
			this.uneMAC = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCEFuentesDeCambio)).BeginInit();
			this.gbAplicaCosto.SuspendLayout();
			this.gbAfectaCostoAfectaPVP.SuspendLayout();
			this.gbAplicaCostoAfectaPVPCondicional.SuspendLayout();
			this.gbAplicaCostoAfectaPVPTodos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMonedas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneValorConstante)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.unePorcentaje)).BeginInit();
			this.gbAplicaPrecioDeVenta.SuspendLayout();
			this.gbAplicaPrecioVentaAfectaPVP.SuspendLayout();
			this.gbAplicaPVSAfectaPVPCondicional.SuspendLayout();
			this.gbAplicaPVSAfectaPVPTodos.SuspendLayout();
			this.gbAplicaMAC.SuspendLayout();
			this.gbAplicaMACAfectaPVP.SuspendLayout();
			this.gbAplicaMACAfectaPVPCondicional.SuspendLayout();
			this.gbAplicaMACAfectaPVPTodos.SuspendLayout();
			this.containerProductos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
			this.containerDatosVenta.SuspendLayout();
			this.groupNuevoCosto.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.unePrecioDeListaConImpuesto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.unePrecioVentaBruto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuento)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuentoPorcentual)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.unePrecioDeVentaNeto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoRef)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneMAC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar)).BeginInit();
			this.ultraExplorerBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(895, 28);
			this.ultraExplorerBarContainerControl2.TabIndex = 2;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(895, 23);
			this.labelTarea.TabIndex = 1;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkPrecioDeVentaBruto);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkMAC);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEFuentesDeCambio);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkPrecioDeCosto);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gbAplicaCosto);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEMonedas);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.utbDeshacer);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.utbActualizarPrecios);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uneValorConstante);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.unePorcentaje);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkProcentaje);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkValorConstante);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gbAplicaPrecioDeVenta);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gbAplicaMAC);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 111);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(878, 273);
			this.ultraExplorerBarContainerControl1.TabIndex = 5;
			// 
			// chkPrecioDeVentaBruto
			// 
			this.chkPrecioDeVentaBruto.BackColor = System.Drawing.Color.Transparent;
			this.chkPrecioDeVentaBruto.Location = new System.Drawing.Point(270, 0);
			this.chkPrecioDeVentaBruto.Name = "chkPrecioDeVentaBruto";
			this.chkPrecioDeVentaBruto.Size = new System.Drawing.Size(107, 24);
			this.chkPrecioDeVentaBruto.TabIndex = 5;
			this.chkPrecioDeVentaBruto.Text = "Precio de Venta";
			// 
			// chkMAC
			// 
			this.chkMAC.BackColor = System.Drawing.Color.Transparent;
			this.chkMAC.Location = new System.Drawing.Point(534, 0);
			this.chkMAC.Name = "chkMAC";
			this.chkMAC.Size = new System.Drawing.Size(107, 24);
			this.chkMAC.TabIndex = 74;
			this.chkMAC.Text = "MAC";
			// 
			// mzCEFuentesDeCambio
			// 
			this.mzCEFuentesDeCambio.AutoComplete = true;
			this.mzCEFuentesDeCambio.DataSource = null;
			this.mzCEFuentesDeCambio.DisplayMember = "";
			this.mzCEFuentesDeCambio.DisplayMemberCaption = "";
			this.mzCEFuentesDeCambio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEFuentesDeCambio.Location = new System.Drawing.Point(104, 248);
			this.mzCEFuentesDeCambio.MaxItemsDisplay = 8;
			this.mzCEFuentesDeCambio.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEFuentesDeCambio.Name = "mzCEFuentesDeCambio";
			this.mzCEFuentesDeCambio.Size = new System.Drawing.Size(100, 21);
			this.mzCEFuentesDeCambio.SorterMember = "";
			this.mzCEFuentesDeCambio.TabIndex = 72;
			this.mzCEFuentesDeCambio.TabStop = false;
			this.mzCEFuentesDeCambio.ValueMember = "";
			this.mzCEFuentesDeCambio.ValueMemberCaption = "";
			// 
			// chkPrecioDeCosto
			// 
			this.chkPrecioDeCosto.BackColor = System.Drawing.Color.Transparent;
			this.chkPrecioDeCosto.Location = new System.Drawing.Point(5, 1);
			this.chkPrecioDeCosto.Name = "chkPrecioDeCosto";
			this.chkPrecioDeCosto.Size = new System.Drawing.Size(107, 24);
			this.chkPrecioDeCosto.TabIndex = 2;
			this.chkPrecioDeCosto.Text = "P. De Costo";
			// 
			// gbAplicaCosto
			// 
			this.gbAplicaCosto.BackColor = System.Drawing.Color.Transparent;
			this.gbAplicaCosto.Controls.Add(this.chkAplicaCostoAfectaPVP);
			this.gbAplicaCosto.Controls.Add(this.gbAfectaCostoAfectaPVP);
			this.gbAplicaCosto.Location = new System.Drawing.Point(0, 6);
			this.gbAplicaCosto.Name = "gbAplicaCosto";
			this.gbAplicaCosto.Size = new System.Drawing.Size(264, 215);
			this.gbAplicaCosto.TabIndex = 70;
			this.gbAplicaCosto.TabStop = false;
			// 
			// chkAplicaCostoAfectaPVP
			// 
			this.chkAplicaCostoAfectaPVP.BackColor = System.Drawing.Color.Transparent;
			this.chkAplicaCostoAfectaPVP.Location = new System.Drawing.Point(14, 25);
			this.chkAplicaCostoAfectaPVP.Name = "chkAplicaCostoAfectaPVP";
			this.chkAplicaCostoAfectaPVP.Size = new System.Drawing.Size(128, 24);
			this.chkAplicaCostoAfectaPVP.TabIndex = 24;
			this.chkAplicaCostoAfectaPVP.Text = "Afecta PVP";
			// 
			// gbAfectaCostoAfectaPVP
			// 
			this.gbAfectaCostoAfectaPVP.Controls.Add(this.rbAplicaCostoAfectaPVPCondicional);
			this.gbAfectaCostoAfectaPVP.Controls.Add(this.gbAplicaCostoAfectaPVPCondicional);
			this.gbAfectaCostoAfectaPVP.Controls.Add(this.rbAplicaCostoAfectaPVPTodos);
			this.gbAfectaCostoAfectaPVP.Controls.Add(this.gbAplicaCostoAfectaPVPTodos);
			this.gbAfectaCostoAfectaPVP.Location = new System.Drawing.Point(8, 32);
			this.gbAfectaCostoAfectaPVP.Name = "gbAfectaCostoAfectaPVP";
			this.gbAfectaCostoAfectaPVP.Size = new System.Drawing.Size(208, 144);
			this.gbAfectaCostoAfectaPVP.TabIndex = 31;
			this.gbAfectaCostoAfectaPVP.TabStop = false;
			// 
			// rbAplicaCostoAfectaPVPCondicional
			// 
			this.rbAplicaCostoAfectaPVPCondicional.BackColor = System.Drawing.Color.Transparent;
			this.rbAplicaCostoAfectaPVPCondicional.Location = new System.Drawing.Point(20, 80);
			this.rbAplicaCostoAfectaPVPCondicional.Name = "rbAplicaCostoAfectaPVPCondicional";
			this.rbAplicaCostoAfectaPVPCondicional.Size = new System.Drawing.Size(168, 24);
			this.rbAplicaCostoAfectaPVPCondicional.TabIndex = 35;
			this.rbAplicaCostoAfectaPVPCondicional.Text = "Aplicar SI PVP < Nuevo PVS";
			// 
			// gbAplicaCostoAfectaPVPCondicional
			// 
			this.gbAplicaCostoAfectaPVPCondicional.Controls.Add(this.rbAplicaCostoAfectaPVPCondicionalTrasladaIncremento);
			this.gbAplicaCostoAfectaPVPCondicional.Controls.Add(this.rbAplicaCostoAfectaPVPCondicionalIgualPVS);
			this.gbAplicaCostoAfectaPVPCondicional.Location = new System.Drawing.Point(12, 85);
			this.gbAplicaCostoAfectaPVPCondicional.Name = "gbAplicaCostoAfectaPVPCondicional";
			this.gbAplicaCostoAfectaPVPCondicional.Size = new System.Drawing.Size(192, 56);
			this.gbAplicaCostoAfectaPVPCondicional.TabIndex = 34;
			this.gbAplicaCostoAfectaPVPCondicional.TabStop = false;
			// 
			// rbAplicaCostoAfectaPVPCondicionalTrasladaIncremento
			// 
			this.rbAplicaCostoAfectaPVPCondicionalTrasladaIncremento.BackColor = System.Drawing.Color.Transparent;
			this.rbAplicaCostoAfectaPVPCondicionalTrasladaIncremento.Location = new System.Drawing.Point(24, 15);
			this.rbAplicaCostoAfectaPVPCondicionalTrasladaIncremento.Name = "rbAplicaCostoAfectaPVPCondicionalTrasladaIncremento";
			this.rbAplicaCostoAfectaPVPCondicionalTrasladaIncremento.Size = new System.Drawing.Size(136, 24);
			this.rbAplicaCostoAfectaPVPCondicionalTrasladaIncremento.TabIndex = 27;
			this.rbAplicaCostoAfectaPVPCondicionalTrasladaIncremento.Text = "Traslada Incremento";
			// 
			// rbAplicaCostoAfectaPVPCondicionalIgualPVS
			// 
			this.rbAplicaCostoAfectaPVPCondicionalIgualPVS.BackColor = System.Drawing.Color.Transparent;
			this.rbAplicaCostoAfectaPVPCondicionalIgualPVS.Location = new System.Drawing.Point(24, 34);
			this.rbAplicaCostoAfectaPVPCondicionalIgualPVS.Name = "rbAplicaCostoAfectaPVPCondicionalIgualPVS";
			this.rbAplicaCostoAfectaPVPCondicionalIgualPVS.Size = new System.Drawing.Size(136, 24);
			this.rbAplicaCostoAfectaPVPCondicionalIgualPVS.TabIndex = 28;
			this.rbAplicaCostoAfectaPVPCondicionalIgualPVS.Text = "= Nuevo PVS";
			// 
			// rbAplicaCostoAfectaPVPTodos
			// 
			this.rbAplicaCostoAfectaPVPTodos.BackColor = System.Drawing.Color.Transparent;
			this.rbAplicaCostoAfectaPVPTodos.Location = new System.Drawing.Point(20, 11);
			this.rbAplicaCostoAfectaPVPTodos.Name = "rbAplicaCostoAfectaPVPTodos";
			this.rbAplicaCostoAfectaPVPTodos.Size = new System.Drawing.Size(103, 24);
			this.rbAplicaCostoAfectaPVPTodos.TabIndex = 33;
			this.rbAplicaCostoAfectaPVPTodos.Text = "Aplicar a Todos";
			// 
			// gbAplicaCostoAfectaPVPTodos
			// 
			this.gbAplicaCostoAfectaPVPTodos.Controls.Add(this.rbAplicaCostoAfectaPVPTodosTrasladaIncremento);
			this.gbAplicaCostoAfectaPVPTodos.Controls.Add(this.rbAplicaCostoAfectaPVPTodosIgualPVS);
			this.gbAplicaCostoAfectaPVPTodos.Location = new System.Drawing.Point(12, 16);
			this.gbAplicaCostoAfectaPVPTodos.Name = "gbAplicaCostoAfectaPVPTodos";
			this.gbAplicaCostoAfectaPVPTodos.Size = new System.Drawing.Size(192, 56);
			this.gbAplicaCostoAfectaPVPTodos.TabIndex = 31;
			this.gbAplicaCostoAfectaPVPTodos.TabStop = false;
			// 
			// rbAplicaCostoAfectaPVPTodosTrasladaIncremento
			// 
			this.rbAplicaCostoAfectaPVPTodosTrasladaIncremento.BackColor = System.Drawing.Color.Transparent;
			this.rbAplicaCostoAfectaPVPTodosTrasladaIncremento.Location = new System.Drawing.Point(24, 15);
			this.rbAplicaCostoAfectaPVPTodosTrasladaIncremento.Name = "rbAplicaCostoAfectaPVPTodosTrasladaIncremento";
			this.rbAplicaCostoAfectaPVPTodosTrasladaIncremento.Size = new System.Drawing.Size(136, 24);
			this.rbAplicaCostoAfectaPVPTodosTrasladaIncremento.TabIndex = 27;
			this.rbAplicaCostoAfectaPVPTodosTrasladaIncremento.Text = "Traslada Incremento";
			// 
			// rbAplicaCostoAfectaPVPTodosIgualPVS
			// 
			this.rbAplicaCostoAfectaPVPTodosIgualPVS.BackColor = System.Drawing.Color.Transparent;
			this.rbAplicaCostoAfectaPVPTodosIgualPVS.Location = new System.Drawing.Point(24, 34);
			this.rbAplicaCostoAfectaPVPTodosIgualPVS.Name = "rbAplicaCostoAfectaPVPTodosIgualPVS";
			this.rbAplicaCostoAfectaPVPTodosIgualPVS.Size = new System.Drawing.Size(136, 24);
			this.rbAplicaCostoAfectaPVPTodosIgualPVS.TabIndex = 28;
			this.rbAplicaCostoAfectaPVPTodosIgualPVS.Text = "= Nuevo PVS";
			// 
			// mzCEMonedas
			// 
			this.mzCEMonedas.AutoComplete = true;
			this.mzCEMonedas.DataSource = null;
			this.mzCEMonedas.DisplayMember = "";
			this.mzCEMonedas.DisplayMemberCaption = "";
			this.mzCEMonedas.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEMonedas.Location = new System.Drawing.Point(104, 224);
			this.mzCEMonedas.MaxItemsDisplay = 8;
			this.mzCEMonedas.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEMonedas.Name = "mzCEMonedas";
			this.mzCEMonedas.Size = new System.Drawing.Size(100, 21);
			this.mzCEMonedas.SorterMember = "";
			this.mzCEMonedas.TabIndex = 69;
			this.mzCEMonedas.TabStop = false;
			this.mzCEMonedas.ValueMember = "";
			this.mzCEMonedas.ValueMemberCaption = "";
			// 
			// utbDeshacer
			// 
			this.utbDeshacer.Location = new System.Drawing.Point(336, 248);
			this.utbDeshacer.Name = "utbDeshacer";
			this.utbDeshacer.Size = new System.Drawing.Size(104, 23);
			this.utbDeshacer.TabIndex = 17;
			this.utbDeshacer.Text = "Deshacer";
			// 
			// utbActualizarPrecios
			// 
			this.utbActualizarPrecios.Location = new System.Drawing.Point(336, 224);
			this.utbActualizarPrecios.Name = "utbActualizarPrecios";
			this.utbActualizarPrecios.Size = new System.Drawing.Size(104, 23);
			this.utbActualizarPrecios.TabIndex = 16;
			this.utbActualizarPrecios.Text = "Actualizar Precios";
			// 
			// uneValorConstante
			// 
			this.uneValorConstante.Enabled = false;
			this.uneValorConstante.Location = new System.Drawing.Point(0, 248);
			this.uneValorConstante.MaskInput = "-nnnnnnnnn.nn";
			this.uneValorConstante.Name = "uneValorConstante";
			this.uneValorConstante.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneValorConstante.Size = new System.Drawing.Size(100, 21);
			this.uneValorConstante.TabIndex = 14;
			this.uneValorConstante.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// unePorcentaje
			// 
			this.unePorcentaje.Enabled = false;
			this.unePorcentaje.Location = new System.Drawing.Point(216, 248);
			this.unePorcentaje.MaskInput = "-nnnnnnnn.nn";
			this.unePorcentaje.Name = "unePorcentaje";
			this.unePorcentaje.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.unePorcentaje.Size = new System.Drawing.Size(100, 21);
			this.unePorcentaje.TabIndex = 15;
			this.unePorcentaje.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// chkProcentaje
			// 
			this.chkProcentaje.BackColor = System.Drawing.Color.Transparent;
			this.chkProcentaje.Location = new System.Drawing.Point(216, 224);
			this.chkProcentaje.Name = "chkProcentaje";
			this.chkProcentaje.TabIndex = 1;
			this.chkProcentaje.Text = "Procentaje";
			// 
			// chkValorConstante
			// 
			this.chkValorConstante.BackColor = System.Drawing.Color.Transparent;
			this.chkValorConstante.Location = new System.Drawing.Point(0, 224);
			this.chkValorConstante.Name = "chkValorConstante";
			this.chkValorConstante.TabIndex = 0;
			this.chkValorConstante.Text = "Valor Constante";
			// 
			// gbAplicaPrecioDeVenta
			// 
			this.gbAplicaPrecioDeVenta.BackColor = System.Drawing.Color.Transparent;
			this.gbAplicaPrecioDeVenta.Controls.Add(this.chkAplicaPVSAfectaPVP);
			this.gbAplicaPrecioDeVenta.Controls.Add(this.gbAplicaPrecioVentaAfectaPVP);
			this.gbAplicaPrecioDeVenta.Controls.Add(this.rbAplicaPVP);
			this.gbAplicaPrecioDeVenta.Controls.Add(this.rbAplicaPVS);
			this.gbAplicaPrecioDeVenta.Location = new System.Drawing.Point(264, 6);
			this.gbAplicaPrecioDeVenta.Name = "gbAplicaPrecioDeVenta";
			this.gbAplicaPrecioDeVenta.Size = new System.Drawing.Size(264, 215);
			this.gbAplicaPrecioDeVenta.TabIndex = 71;
			this.gbAplicaPrecioDeVenta.TabStop = false;
			// 
			// chkAplicaPVSAfectaPVP
			// 
			this.chkAplicaPVSAfectaPVP.BackColor = System.Drawing.Color.Transparent;
			this.chkAplicaPVSAfectaPVP.Location = new System.Drawing.Point(40, 36);
			this.chkAplicaPVSAfectaPVP.Name = "chkAplicaPVSAfectaPVP";
			this.chkAplicaPVSAfectaPVP.Size = new System.Drawing.Size(128, 24);
			this.chkAplicaPVSAfectaPVP.TabIndex = 33;
			this.chkAplicaPVSAfectaPVP.Text = "Afecta PVP";
			// 
			// gbAplicaPrecioVentaAfectaPVP
			// 
			this.gbAplicaPrecioVentaAfectaPVP.Controls.Add(this.rbAplicaPVSAfectaPVPCondicional);
			this.gbAplicaPrecioVentaAfectaPVP.Controls.Add(this.gbAplicaPVSAfectaPVPCondicional);
			this.gbAplicaPrecioVentaAfectaPVP.Controls.Add(this.rbAplicaPVSAfectaPVPTodos);
			this.gbAplicaPrecioVentaAfectaPVP.Controls.Add(this.gbAplicaPVSAfectaPVPTodos);
			this.gbAplicaPrecioVentaAfectaPVP.Location = new System.Drawing.Point(32, 42);
			this.gbAplicaPrecioVentaAfectaPVP.Name = "gbAplicaPrecioVentaAfectaPVP";
			this.gbAplicaPrecioVentaAfectaPVP.Size = new System.Drawing.Size(208, 141);
			this.gbAplicaPrecioVentaAfectaPVP.TabIndex = 34;
			this.gbAplicaPrecioVentaAfectaPVP.TabStop = false;
			// 
			// rbAplicaPVSAfectaPVPCondicional
			// 
			this.rbAplicaPVSAfectaPVPCondicional.BackColor = System.Drawing.Color.Transparent;
			this.rbAplicaPVSAfectaPVPCondicional.Location = new System.Drawing.Point(20, 74);
			this.rbAplicaPVSAfectaPVPCondicional.Name = "rbAplicaPVSAfectaPVPCondicional";
			this.rbAplicaPVSAfectaPVPCondicional.Size = new System.Drawing.Size(168, 24);
			this.rbAplicaPVSAfectaPVPCondicional.TabIndex = 35;
			this.rbAplicaPVSAfectaPVPCondicional.Text = "Aplicar SI PVP < Nuevo PVS";
			// 
			// gbAplicaPVSAfectaPVPCondicional
			// 
			this.gbAplicaPVSAfectaPVPCondicional.Controls.Add(this.rbAplicaPVSAfectaPVPCondicionalTrasladaIncremento);
			this.gbAplicaPVSAfectaPVPCondicional.Controls.Add(this.rbAplicaPVSAfectaPVPCondicionalIgualPVS);
			this.gbAplicaPVSAfectaPVPCondicional.Location = new System.Drawing.Point(12, 79);
			this.gbAplicaPVSAfectaPVPCondicional.Name = "gbAplicaPVSAfectaPVPCondicional";
			this.gbAplicaPVSAfectaPVPCondicional.Size = new System.Drawing.Size(192, 56);
			this.gbAplicaPVSAfectaPVPCondicional.TabIndex = 34;
			this.gbAplicaPVSAfectaPVPCondicional.TabStop = false;
			// 
			// rbAplicaPVSAfectaPVPCondicionalTrasladaIncremento
			// 
			this.rbAplicaPVSAfectaPVPCondicionalTrasladaIncremento.BackColor = System.Drawing.Color.Transparent;
			this.rbAplicaPVSAfectaPVPCondicionalTrasladaIncremento.Location = new System.Drawing.Point(24, 15);
			this.rbAplicaPVSAfectaPVPCondicionalTrasladaIncremento.Name = "rbAplicaPVSAfectaPVPCondicionalTrasladaIncremento";
			this.rbAplicaPVSAfectaPVPCondicionalTrasladaIncremento.Size = new System.Drawing.Size(136, 24);
			this.rbAplicaPVSAfectaPVPCondicionalTrasladaIncremento.TabIndex = 27;
			this.rbAplicaPVSAfectaPVPCondicionalTrasladaIncremento.Text = "Traslada Incremento";
			// 
			// rbAplicaPVSAfectaPVPCondicionalIgualPVS
			// 
			this.rbAplicaPVSAfectaPVPCondicionalIgualPVS.BackColor = System.Drawing.Color.Transparent;
			this.rbAplicaPVSAfectaPVPCondicionalIgualPVS.Location = new System.Drawing.Point(24, 34);
			this.rbAplicaPVSAfectaPVPCondicionalIgualPVS.Name = "rbAplicaPVSAfectaPVPCondicionalIgualPVS";
			this.rbAplicaPVSAfectaPVPCondicionalIgualPVS.Size = new System.Drawing.Size(136, 24);
			this.rbAplicaPVSAfectaPVPCondicionalIgualPVS.TabIndex = 28;
			this.rbAplicaPVSAfectaPVPCondicionalIgualPVS.Text = "= Nuevo PVS";
			// 
			// rbAplicaPVSAfectaPVPTodos
			// 
			this.rbAplicaPVSAfectaPVPTodos.BackColor = System.Drawing.Color.Transparent;
			this.rbAplicaPVSAfectaPVPTodos.Location = new System.Drawing.Point(20, 12);
			this.rbAplicaPVSAfectaPVPTodos.Name = "rbAplicaPVSAfectaPVPTodos";
			this.rbAplicaPVSAfectaPVPTodos.Size = new System.Drawing.Size(103, 24);
			this.rbAplicaPVSAfectaPVPTodos.TabIndex = 33;
			this.rbAplicaPVSAfectaPVPTodos.Text = "Aplicar a Todos";
			// 
			// gbAplicaPVSAfectaPVPTodos
			// 
			this.gbAplicaPVSAfectaPVPTodos.Controls.Add(this.rbAplicaPVSAfectaPVPTodosTrasladaIncremento);
			this.gbAplicaPVSAfectaPVPTodos.Controls.Add(this.rbAplicaPVSAfectaPVPTodosIgualPVS);
			this.gbAplicaPVSAfectaPVPTodos.Location = new System.Drawing.Point(12, 17);
			this.gbAplicaPVSAfectaPVPTodos.Name = "gbAplicaPVSAfectaPVPTodos";
			this.gbAplicaPVSAfectaPVPTodos.Size = new System.Drawing.Size(192, 56);
			this.gbAplicaPVSAfectaPVPTodos.TabIndex = 31;
			this.gbAplicaPVSAfectaPVPTodos.TabStop = false;
			// 
			// rbAplicaPVSAfectaPVPTodosTrasladaIncremento
			// 
			this.rbAplicaPVSAfectaPVPTodosTrasladaIncremento.BackColor = System.Drawing.Color.Transparent;
			this.rbAplicaPVSAfectaPVPTodosTrasladaIncremento.Location = new System.Drawing.Point(24, 15);
			this.rbAplicaPVSAfectaPVPTodosTrasladaIncremento.Name = "rbAplicaPVSAfectaPVPTodosTrasladaIncremento";
			this.rbAplicaPVSAfectaPVPTodosTrasladaIncremento.Size = new System.Drawing.Size(136, 24);
			this.rbAplicaPVSAfectaPVPTodosTrasladaIncremento.TabIndex = 27;
			this.rbAplicaPVSAfectaPVPTodosTrasladaIncremento.Text = "Traslada Incremento";
			// 
			// rbAplicaPVSAfectaPVPTodosIgualPVS
			// 
			this.rbAplicaPVSAfectaPVPTodosIgualPVS.BackColor = System.Drawing.Color.Transparent;
			this.rbAplicaPVSAfectaPVPTodosIgualPVS.Location = new System.Drawing.Point(24, 34);
			this.rbAplicaPVSAfectaPVPTodosIgualPVS.Name = "rbAplicaPVSAfectaPVPTodosIgualPVS";
			this.rbAplicaPVSAfectaPVPTodosIgualPVS.Size = new System.Drawing.Size(136, 24);
			this.rbAplicaPVSAfectaPVPTodosIgualPVS.TabIndex = 28;
			this.rbAplicaPVSAfectaPVPTodosIgualPVS.Text = "= Nuevo PVS";
			// 
			// rbAplicaPVP
			// 
			this.rbAplicaPVP.BackColor = System.Drawing.Color.Transparent;
			this.rbAplicaPVP.Location = new System.Drawing.Point(16, 187);
			this.rbAplicaPVP.Name = "rbAplicaPVP";
			this.rbAplicaPVP.Size = new System.Drawing.Size(184, 24);
			this.rbAplicaPVP.TabIndex = 32;
			this.rbAplicaPVP.Text = "Aplica sobre P. de Lista";
			// 
			// rbAplicaPVS
			// 
			this.rbAplicaPVS.BackColor = System.Drawing.Color.Transparent;
			this.rbAplicaPVS.Location = new System.Drawing.Point(16, 16);
			this.rbAplicaPVS.Name = "rbAplicaPVS";
			this.rbAplicaPVS.Size = new System.Drawing.Size(192, 24);
			this.rbAplicaPVS.TabIndex = 31;
			this.rbAplicaPVS.Text = "Aplica sobre P. Venta Sugerido";
			// 
			// gbAplicaMAC
			// 
			this.gbAplicaMAC.BackColor = System.Drawing.Color.Transparent;
			this.gbAplicaMAC.Controls.Add(this.chkAplicaMACAfectaPVP);
			this.gbAplicaMAC.Controls.Add(this.gbAplicaMACAfectaPVP);
			this.gbAplicaMAC.Location = new System.Drawing.Point(528, 6);
			this.gbAplicaMAC.Name = "gbAplicaMAC";
			this.gbAplicaMAC.Size = new System.Drawing.Size(264, 215);
			this.gbAplicaMAC.TabIndex = 73;
			this.gbAplicaMAC.TabStop = false;
			// 
			// chkAplicaMACAfectaPVP
			// 
			this.chkAplicaMACAfectaPVP.BackColor = System.Drawing.Color.Transparent;
			this.chkAplicaMACAfectaPVP.Location = new System.Drawing.Point(17, 25);
			this.chkAplicaMACAfectaPVP.Name = "chkAplicaMACAfectaPVP";
			this.chkAplicaMACAfectaPVP.Size = new System.Drawing.Size(128, 24);
			this.chkAplicaMACAfectaPVP.TabIndex = 32;
			this.chkAplicaMACAfectaPVP.Text = "Afecta PVP";
			// 
			// gbAplicaMACAfectaPVP
			// 
			this.gbAplicaMACAfectaPVP.Controls.Add(this.rbAplicaMACAfectaPVPCondicional);
			this.gbAplicaMACAfectaPVP.Controls.Add(this.gbAplicaMACAfectaPVPCondicional);
			this.gbAplicaMACAfectaPVP.Controls.Add(this.rbAplicaMACAfectaPVPTodos);
			this.gbAplicaMACAfectaPVP.Controls.Add(this.gbAplicaMACAfectaPVPTodos);
			this.gbAplicaMACAfectaPVP.Location = new System.Drawing.Point(12, 32);
			this.gbAplicaMACAfectaPVP.Name = "gbAplicaMACAfectaPVP";
			this.gbAplicaMACAfectaPVP.Size = new System.Drawing.Size(208, 144);
			this.gbAplicaMACAfectaPVP.TabIndex = 33;
			this.gbAplicaMACAfectaPVP.TabStop = false;
			// 
			// rbAplicaMACAfectaPVPCondicional
			// 
			this.rbAplicaMACAfectaPVPCondicional.BackColor = System.Drawing.Color.Transparent;
			this.rbAplicaMACAfectaPVPCondicional.Location = new System.Drawing.Point(20, 80);
			this.rbAplicaMACAfectaPVPCondicional.Name = "rbAplicaMACAfectaPVPCondicional";
			this.rbAplicaMACAfectaPVPCondicional.Size = new System.Drawing.Size(168, 24);
			this.rbAplicaMACAfectaPVPCondicional.TabIndex = 35;
			this.rbAplicaMACAfectaPVPCondicional.Text = "Aplicar SI PVP < Nuevo PVS";
			// 
			// gbAplicaMACAfectaPVPCondicional
			// 
			this.gbAplicaMACAfectaPVPCondicional.Controls.Add(this.rbAplicaMACAfectaPVPCondicionalTrasladaIncremento);
			this.gbAplicaMACAfectaPVPCondicional.Controls.Add(this.rbAplicaMACAfectaPVPCondicionalIgualPVS);
			this.gbAplicaMACAfectaPVPCondicional.Location = new System.Drawing.Point(12, 85);
			this.gbAplicaMACAfectaPVPCondicional.Name = "gbAplicaMACAfectaPVPCondicional";
			this.gbAplicaMACAfectaPVPCondicional.Size = new System.Drawing.Size(192, 56);
			this.gbAplicaMACAfectaPVPCondicional.TabIndex = 34;
			this.gbAplicaMACAfectaPVPCondicional.TabStop = false;
			// 
			// rbAplicaMACAfectaPVPCondicionalTrasladaIncremento
			// 
			this.rbAplicaMACAfectaPVPCondicionalTrasladaIncremento.BackColor = System.Drawing.Color.Transparent;
			this.rbAplicaMACAfectaPVPCondicionalTrasladaIncremento.Location = new System.Drawing.Point(24, 15);
			this.rbAplicaMACAfectaPVPCondicionalTrasladaIncremento.Name = "rbAplicaMACAfectaPVPCondicionalTrasladaIncremento";
			this.rbAplicaMACAfectaPVPCondicionalTrasladaIncremento.Size = new System.Drawing.Size(136, 24);
			this.rbAplicaMACAfectaPVPCondicionalTrasladaIncremento.TabIndex = 27;
			this.rbAplicaMACAfectaPVPCondicionalTrasladaIncremento.Text = "Traslada Incremento";
			// 
			// rbAplicaMACAfectaPVPCondicionalIgualPVS
			// 
			this.rbAplicaMACAfectaPVPCondicionalIgualPVS.BackColor = System.Drawing.Color.Transparent;
			this.rbAplicaMACAfectaPVPCondicionalIgualPVS.Location = new System.Drawing.Point(24, 34);
			this.rbAplicaMACAfectaPVPCondicionalIgualPVS.Name = "rbAplicaMACAfectaPVPCondicionalIgualPVS";
			this.rbAplicaMACAfectaPVPCondicionalIgualPVS.Size = new System.Drawing.Size(136, 24);
			this.rbAplicaMACAfectaPVPCondicionalIgualPVS.TabIndex = 28;
			this.rbAplicaMACAfectaPVPCondicionalIgualPVS.Text = "= Nuevo PVS";
			// 
			// rbAplicaMACAfectaPVPTodos
			// 
			this.rbAplicaMACAfectaPVPTodos.BackColor = System.Drawing.Color.Transparent;
			this.rbAplicaMACAfectaPVPTodos.Location = new System.Drawing.Point(20, 11);
			this.rbAplicaMACAfectaPVPTodos.Name = "rbAplicaMACAfectaPVPTodos";
			this.rbAplicaMACAfectaPVPTodos.Size = new System.Drawing.Size(103, 24);
			this.rbAplicaMACAfectaPVPTodos.TabIndex = 33;
			this.rbAplicaMACAfectaPVPTodos.Text = "Aplicar a Todos";
			// 
			// gbAplicaMACAfectaPVPTodos
			// 
			this.gbAplicaMACAfectaPVPTodos.Controls.Add(this.rbAplicaMACAfectaPVPTodosTrasladaIncremento);
			this.gbAplicaMACAfectaPVPTodos.Controls.Add(this.rbAplicaMACAfectaPVPTodosIgualPVS);
			this.gbAplicaMACAfectaPVPTodos.Location = new System.Drawing.Point(12, 16);
			this.gbAplicaMACAfectaPVPTodos.Name = "gbAplicaMACAfectaPVPTodos";
			this.gbAplicaMACAfectaPVPTodos.Size = new System.Drawing.Size(192, 56);
			this.gbAplicaMACAfectaPVPTodos.TabIndex = 31;
			this.gbAplicaMACAfectaPVPTodos.TabStop = false;
			// 
			// rbAplicaMACAfectaPVPTodosTrasladaIncremento
			// 
			this.rbAplicaMACAfectaPVPTodosTrasladaIncremento.BackColor = System.Drawing.Color.Transparent;
			this.rbAplicaMACAfectaPVPTodosTrasladaIncremento.Location = new System.Drawing.Point(24, 15);
			this.rbAplicaMACAfectaPVPTodosTrasladaIncremento.Name = "rbAplicaMACAfectaPVPTodosTrasladaIncremento";
			this.rbAplicaMACAfectaPVPTodosTrasladaIncremento.Size = new System.Drawing.Size(136, 24);
			this.rbAplicaMACAfectaPVPTodosTrasladaIncremento.TabIndex = 27;
			this.rbAplicaMACAfectaPVPTodosTrasladaIncremento.Text = "Traslada Incremento";
			// 
			// rbAplicaMACAfectaPVPTodosIgualPVS
			// 
			this.rbAplicaMACAfectaPVPTodosIgualPVS.BackColor = System.Drawing.Color.Transparent;
			this.rbAplicaMACAfectaPVPTodosIgualPVS.Location = new System.Drawing.Point(24, 34);
			this.rbAplicaMACAfectaPVPTodosIgualPVS.Name = "rbAplicaMACAfectaPVPTodosIgualPVS";
			this.rbAplicaMACAfectaPVPTodosIgualPVS.Size = new System.Drawing.Size(136, 24);
			this.rbAplicaMACAfectaPVPTodosIgualPVS.TabIndex = 28;
			this.rbAplicaMACAfectaPVPTodosIgualPVS.Text = "= Nuevo PVS";
			// 
			// containerProductos
			// 
			this.containerProductos.Controls.Add(this.mzProductosControl);
			this.containerProductos.Controls.Add(this.gridProductos);
			this.containerProductos.Controls.Add(this.label9);
			this.containerProductos.Location = new System.Drawing.Point(28, 151);
			this.containerProductos.Name = "containerProductos";
			this.containerProductos.Size = new System.Drawing.Size(895, 169);
			this.containerProductos.TabIndex = 3;
			// 
			// mzProductosControl
			// 
			this.mzProductosControl.BackColor = System.Drawing.Color.Transparent;
			this.mzProductosControl.EnabledCantidad = false;
			this.mzProductosControl.Location = new System.Drawing.Point(80, 0);
			this.mzProductosControl.Name = "mzProductosControl";
			this.mzProductosControl.Size = new System.Drawing.Size(608, 48);
			this.mzProductosControl.TabIndex = 74;
			this.mzProductosControl.VisiblePrecios = true;
			// 
			// gridProductos
			// 
			this.gridProductos.AllowCardSizing = false;
			this.gridProductos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridProductos.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridProductos.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gridProductos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridProductos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.gridProductos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridProductos.Location = new System.Drawing.Point(0, 49);
			this.gridProductos.Name = "gridProductos";
			this.gridProductos.Size = new System.Drawing.Size(895, 120);
			this.gridProductos.TabIndex = 73;
			this.gridProductos.TabStop = false;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(11, 5);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(69, 16);
			this.label9.TabIndex = 49;
			this.label9.Text = "Producto";
			// 
			// containerDatosVenta
			// 
			this.containerDatosVenta.Controls.Add(this.groupNuevoCosto);
			this.containerDatosVenta.Location = new System.Drawing.Point(28, 265);
			this.containerDatosVenta.Name = "containerDatosVenta";
			this.containerDatosVenta.Size = new System.Drawing.Size(878, 104);
			this.containerDatosVenta.TabIndex = 4;
			// 
			// groupNuevoCosto
			// 
			this.groupNuevoCosto.BackColor = System.Drawing.Color.Transparent;
			this.groupNuevoCosto.Controls.Add(this.labelSimboloMonedaPrecioDeListaConImpuestos);
			this.groupNuevoCosto.Controls.Add(this.label2);
			this.groupNuevoCosto.Controls.Add(this.unePrecioDeListaConImpuesto);
			this.groupNuevoCosto.Controls.Add(this.labelSimboloMonedaPrecioDeLista);
			this.groupNuevoCosto.Controls.Add(this.labelSimboloMonedaDescuentoMaximo);
			this.groupNuevoCosto.Controls.Add(this.labelSimboloMonedaPrecioDeVentaNeto);
			this.groupNuevoCosto.Controls.Add(this.labelSimboloMonedaPrecioDeCostoReferencia);
			this.groupNuevoCosto.Controls.Add(this.label16);
			this.groupNuevoCosto.Controls.Add(this.label15);
			this.groupNuevoCosto.Controls.Add(this.label13);
			this.groupNuevoCosto.Controls.Add(this.unePrecioVentaBruto);
			this.groupNuevoCosto.Controls.Add(this.label12);
			this.groupNuevoCosto.Controls.Add(this.uneMaxDescuento);
			this.groupNuevoCosto.Controls.Add(this.label11);
			this.groupNuevoCosto.Controls.Add(this.uneMaxDescuentoPorcentual);
			this.groupNuevoCosto.Controls.Add(this.label10);
			this.groupNuevoCosto.Controls.Add(this.unePrecioDeVentaNeto);
			this.groupNuevoCosto.Controls.Add(this.label8);
			this.groupNuevoCosto.Controls.Add(this.unePrecioDeCostoRef);
			this.groupNuevoCosto.Controls.Add(this.label7);
			this.groupNuevoCosto.Controls.Add(this.uneMAC);
			this.groupNuevoCosto.Location = new System.Drawing.Point(0, 0);
			this.groupNuevoCosto.Name = "groupNuevoCosto";
			this.groupNuevoCosto.Size = new System.Drawing.Size(848, 104);
			this.groupNuevoCosto.TabIndex = 78;
			this.groupNuevoCosto.TabStop = false;
			this.groupNuevoCosto.Text = "Datos para la Venta";
			// 
			// labelSimboloMonedaPrecioDeListaConImpuestos
			// 
			this.labelSimboloMonedaPrecioDeListaConImpuestos.BackColor = System.Drawing.Color.Transparent;
			this.labelSimboloMonedaPrecioDeListaConImpuestos.Location = new System.Drawing.Point(640, 79);
			this.labelSimboloMonedaPrecioDeListaConImpuestos.Name = "labelSimboloMonedaPrecioDeListaConImpuestos";
			this.labelSimboloMonedaPrecioDeListaConImpuestos.Size = new System.Drawing.Size(32, 16);
			this.labelSimboloMonedaPrecioDeListaConImpuestos.TabIndex = 86;
			this.labelSimboloMonedaPrecioDeListaConImpuestos.Text = "$";
			this.labelSimboloMonedaPrecioDeListaConImpuestos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(448, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(223, 21);
			this.label2.TabIndex = 85;
			this.label2.Text = "Precio de Venta Bruto Con Impuestos";
			// 
			// unePrecioDeListaConImpuesto
			// 
			this.unePrecioDeListaConImpuesto.Location = new System.Drawing.Point(672, 76);
			this.unePrecioDeListaConImpuesto.MaskInput = "nnnnnnnnn.nn";
			this.unePrecioDeListaConImpuesto.Name = "unePrecioDeListaConImpuesto";
			this.unePrecioDeListaConImpuesto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.unePrecioDeListaConImpuesto.Size = new System.Drawing.Size(100, 21);
			this.unePrecioDeListaConImpuesto.TabIndex = 84;
			this.unePrecioDeListaConImpuesto.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// labelSimboloMonedaPrecioDeLista
			// 
			this.labelSimboloMonedaPrecioDeLista.BackColor = System.Drawing.Color.Transparent;
			this.labelSimboloMonedaPrecioDeLista.Location = new System.Drawing.Point(640, 59);
			this.labelSimboloMonedaPrecioDeLista.Name = "labelSimboloMonedaPrecioDeLista";
			this.labelSimboloMonedaPrecioDeLista.Size = new System.Drawing.Size(32, 16);
			this.labelSimboloMonedaPrecioDeLista.TabIndex = 83;
			this.labelSimboloMonedaPrecioDeLista.Text = "$";
			this.labelSimboloMonedaPrecioDeLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelSimboloMonedaDescuentoMaximo
			// 
			this.labelSimboloMonedaDescuentoMaximo.BackColor = System.Drawing.Color.Transparent;
			this.labelSimboloMonedaDescuentoMaximo.Location = new System.Drawing.Point(640, 39);
			this.labelSimboloMonedaDescuentoMaximo.Name = "labelSimboloMonedaDescuentoMaximo";
			this.labelSimboloMonedaDescuentoMaximo.Size = new System.Drawing.Size(32, 16);
			this.labelSimboloMonedaDescuentoMaximo.TabIndex = 82;
			this.labelSimboloMonedaDescuentoMaximo.Text = "$";
			this.labelSimboloMonedaDescuentoMaximo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelSimboloMonedaPrecioDeVentaNeto
			// 
			this.labelSimboloMonedaPrecioDeVentaNeto.BackColor = System.Drawing.Color.Transparent;
			this.labelSimboloMonedaPrecioDeVentaNeto.Location = new System.Drawing.Point(208, 59);
			this.labelSimboloMonedaPrecioDeVentaNeto.Name = "labelSimboloMonedaPrecioDeVentaNeto";
			this.labelSimboloMonedaPrecioDeVentaNeto.Size = new System.Drawing.Size(32, 16);
			this.labelSimboloMonedaPrecioDeVentaNeto.TabIndex = 81;
			this.labelSimboloMonedaPrecioDeVentaNeto.Text = "$";
			this.labelSimboloMonedaPrecioDeVentaNeto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelSimboloMonedaPrecioDeCostoReferencia
			// 
			this.labelSimboloMonedaPrecioDeCostoReferencia.BackColor = System.Drawing.Color.Transparent;
			this.labelSimboloMonedaPrecioDeCostoReferencia.Location = new System.Drawing.Point(208, 19);
			this.labelSimboloMonedaPrecioDeCostoReferencia.Name = "labelSimboloMonedaPrecioDeCostoReferencia";
			this.labelSimboloMonedaPrecioDeCostoReferencia.Size = new System.Drawing.Size(32, 16);
			this.labelSimboloMonedaPrecioDeCostoReferencia.TabIndex = 80;
			this.labelSimboloMonedaPrecioDeCostoReferencia.Text = "$";
			this.labelSimboloMonedaPrecioDeCostoReferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Location = new System.Drawing.Point(779, 19);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(32, 16);
			this.label16.TabIndex = 39;
			this.label16.Text = "%";
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Location = new System.Drawing.Point(344, 40);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(16, 16);
			this.label15.TabIndex = 38;
			this.label15.Text = "%";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Location = new System.Drawing.Point(448, 59);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(223, 21);
			this.label13.TabIndex = 37;
			this.label13.Text = "Precio de Venta Bruto (Precio de Lista)";
			// 
			// unePrecioVentaBruto
			// 
			this.unePrecioVentaBruto.Location = new System.Drawing.Point(672, 56);
			this.unePrecioVentaBruto.MaskInput = "nnnnnnnnn.nn";
			this.unePrecioVentaBruto.Name = "unePrecioVentaBruto";
			this.unePrecioVentaBruto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.unePrecioVentaBruto.Size = new System.Drawing.Size(100, 21);
			this.unePrecioVentaBruto.TabIndex = 17;
			this.unePrecioVentaBruto.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Location = new System.Drawing.Point(448, 39);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(223, 21);
			this.label12.TabIndex = 36;
			this.label12.Text = "Descuento Máximo s/Precio de Lista";
			// 
			// uneMaxDescuento
			// 
			this.uneMaxDescuento.Location = new System.Drawing.Point(672, 36);
			this.uneMaxDescuento.MaskInput = "nnnnnnnnn.nn";
			this.uneMaxDescuento.Name = "uneMaxDescuento";
			this.uneMaxDescuento.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneMaxDescuento.Size = new System.Drawing.Size(100, 21);
			this.uneMaxDescuento.TabIndex = 16;
			this.uneMaxDescuento.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Location = new System.Drawing.Point(448, 19);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(223, 21);
			this.label11.TabIndex = 35;
			this.label11.Text = "Descuento Porcentual s/Precio de Lista";
			// 
			// uneMaxDescuentoPorcentual
			// 
			this.uneMaxDescuentoPorcentual.Location = new System.Drawing.Point(672, 16);
			this.uneMaxDescuentoPorcentual.Name = "uneMaxDescuentoPorcentual";
			this.uneMaxDescuentoPorcentual.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneMaxDescuentoPorcentual.Size = new System.Drawing.Size(100, 21);
			this.uneMaxDescuentoPorcentual.TabIndex = 15;
			this.uneMaxDescuentoPorcentual.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(16, 56);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(223, 21);
			this.label10.TabIndex = 34;
			this.label10.Text = "Precio de Venta Neto";
			// 
			// unePrecioDeVentaNeto
			// 
			this.unePrecioDeVentaNeto.Location = new System.Drawing.Point(240, 56);
			this.unePrecioDeVentaNeto.MaskInput = "nnnnnnnnn.nn";
			this.unePrecioDeVentaNeto.Name = "unePrecioDeVentaNeto";
			this.unePrecioDeVentaNeto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.unePrecioDeVentaNeto.Size = new System.Drawing.Size(100, 21);
			this.unePrecioDeVentaNeto.TabIndex = 14;
			this.unePrecioDeVentaNeto.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(16, 19);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(223, 21);
			this.label8.TabIndex = 33;
			this.label8.Text = "Precio de Costo Referencia";
			// 
			// unePrecioDeCostoRef
			// 
			this.unePrecioDeCostoRef.Location = new System.Drawing.Point(240, 16);
			this.unePrecioDeCostoRef.MaskInput = "nnnnnnnnn.nn";
			this.unePrecioDeCostoRef.Name = "unePrecioDeCostoRef";
			this.unePrecioDeCostoRef.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.unePrecioDeCostoRef.Size = new System.Drawing.Size(100, 21);
			this.unePrecioDeCostoRef.TabIndex = 12;
			this.unePrecioDeCostoRef.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(16, 39);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(223, 21);
			this.label7.TabIndex = 32;
			this.label7.Text = "Margen/Precio Costo Neto";
			// 
			// uneMAC
			// 
			this.uneMAC.Location = new System.Drawing.Point(240, 36);
			this.uneMAC.Name = "uneMAC";
			this.uneMAC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneMAC.Size = new System.Drawing.Size(100, 21);
			this.uneMAC.TabIndex = 13;
			this.uneMAC.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
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
			this.toolBarStandar.Size = new System.Drawing.Size(944, 28);
			this.toolBarStandar.TabIndex = 24;
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
			// ultraExplorerBar
			// 
			this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar.Controls.Add(this.containerProductos);
			this.ultraExplorerBar.Controls.Add(this.containerDatosVenta);
			this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 28;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Expanded = false;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 273;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Coeficientes de Incremento de Precio";
			ultraExplorerBarGroup3.Container = this.containerProductos;
			ultraExplorerBarGroup3.Settings.ContainerHeight = 169;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Producto";
			ultraExplorerBarGroup4.Container = this.containerDatosVenta;
			ultraExplorerBarGroup4.Expanded = false;
			ultraExplorerBarGroup4.Settings.ContainerHeight = 104;
			ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup4.Text = "Datos para la Venta";
			this.ultraExplorerBar.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																													   ultraExplorerBarGroup1,
																													   ultraExplorerBarGroup2,
																													   ultraExplorerBarGroup3,
																													   ultraExplorerBarGroup4});
			this.ultraExplorerBar.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar.Name = "ultraExplorerBar";
			this.ultraExplorerBar.Size = new System.Drawing.Size(944, 394);
			this.ultraExplorerBar.TabIndex = 25;
			this.ultraExplorerBar.TabStop = false;
			// 
			// FrmModificarPreciosMasivo
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(944, 422);
			this.Controls.Add(this.ultraExplorerBar);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmModificarPreciosMasivo";
			this.Text = "FrmModificarPreciosMasivo";
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCEFuentesDeCambio)).EndInit();
			this.gbAplicaCosto.ResumeLayout(false);
			this.gbAfectaCostoAfectaPVP.ResumeLayout(false);
			this.gbAplicaCostoAfectaPVPCondicional.ResumeLayout(false);
			this.gbAplicaCostoAfectaPVPTodos.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCEMonedas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneValorConstante)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.unePorcentaje)).EndInit();
			this.gbAplicaPrecioDeVenta.ResumeLayout(false);
			this.gbAplicaPrecioVentaAfectaPVP.ResumeLayout(false);
			this.gbAplicaPVSAfectaPVPCondicional.ResumeLayout(false);
			this.gbAplicaPVSAfectaPVPTodos.ResumeLayout(false);
			this.gbAplicaMAC.ResumeLayout(false);
			this.gbAplicaMACAfectaPVP.ResumeLayout(false);
			this.gbAplicaMACAfectaPVPCondicional.ResumeLayout(false);
			this.gbAplicaMACAfectaPVPTodos.ResumeLayout(false);
			this.containerProductos.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
			this.containerDatosVenta.ResumeLayout(false);
			this.groupNuevoCosto.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.unePrecioDeListaConImpuesto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.unePrecioVentaBruto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuento)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuentoPorcentual)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.unePrecioDeVentaNeto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoRef)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneMAC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar)).EndInit();
			this.ultraExplorerBar.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Construtores

		public FrmModificarPreciosMasivo(ModificarPreciosMasivoController uiController)
		{
			InitializeComponent();
			_uiController = uiController;
		}


		#endregion

		#region Variables Privadas

		private ModificarPreciosMasivoController _uiController;
		private int _selectedIndex = 0;


		#endregion

		#region Metodos Privados

		protected void Build_UI()
		{
			ConfigureInterface();	
			InitializeData();
			InitEventHandlers();
			InitDataBindings();	
			if(gridProductos.RecordCount > 0)
			{
				gridProductos.Row = 0;
				gridProductos.Select();
				this.gridProductos_SelectionChanged(gridProductos, new EventArgs());
				

			}
			
		}

		
		private void ConfigureInterface()
		{
			
			this.Text = _uiController.LeyendaFormulario;
			labelTarea.Text = _uiController.LeyendaFormulario;
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			
			mzProductosControl.Enabled = _uiController.EnableBuscadorProducto;
			
			unePrecioDeVentaNeto.ReadOnly = true;
			uneMaxDescuento.ReadOnly = true;
			uneMaxDescuentoPorcentual.ReadOnly = true;
			gridProductos.LayoutData = _uiController.LayoutProductos;
			
			


			gridProductos.GroupByBoxVisible = false;
			gridProductos.SelectionMode = Janus.Windows.GridEX.SelectionMode.SingleSelection;
			uneMAC.FormatString = "n";
			uneMaxDescuento.FormatString = "n";
			uneMaxDescuentoPorcentual.FormatString = "n";

			labelSimboloMonedaDescuentoMaximo.Text = _uiController.SimboloMonedaDescuentoMaximo;
			labelSimboloMonedaPrecioDeCostoReferencia.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaPrecioDeLista.Text = _uiController.SimboloMonedaPrecioDeLista;
			labelSimboloMonedaPrecioDeVentaNeto.Text = _uiController.SimboloMonedaPrecioDeVentaNeto;
			labelSimboloMonedaPrecioDeListaConImpuestos.Text = _uiController.SimboloMonedaPrecioDeLista;

			unePrecioDeCostoRef.ReadOnly = true;
			uneMAC.ReadOnly = true;
			unePrecioDeVentaNeto.ReadOnly = true;
			uneMaxDescuento.ReadOnly = true;
			uneMaxDescuentoPorcentual.ReadOnly = true;
			unePrecioVentaBruto.ReadOnly = true;
			unePrecioDeListaConImpuesto.ReadOnly = true;

			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;

			containerProductos.Visible = true;
			ultraExplorerBar.Groups[2].Visible = _uiController.VisibleDatosCompra;
		
			
			ultraExplorerBar.Groups[3].Visible = _uiController.VisibleDatosVenta;

			this.mzProductosControl.EnabledCantidad = true;
			this.mzProductosControl.ReadOnlyCantidad = true;
			if(_uiController.AllowRemoveItems)
				gridProductos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			else gridProductos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
			uneValorConstante.Enabled = chkValorConstante.Checked;
			mzCEMonedas.Enabled =  chkValorConstante.Checked;
			unePorcentaje.Enabled = chkProcentaje.Checked;
			mzCEFuentesDeCambio.Enabled = chkValorConstante.Checked;
			
			/*Configura controles para el Precio de Costo*/
			chkAplicaCostoAfectaPVP.Enabled = chkPrecioDeCosto.Checked;
			rbAplicaCostoAfectaPVPCondicional.Enabled = chkAplicaCostoAfectaPVP.Checked;
			rbAplicaCostoAfectaPVPCondicionalIgualPVS.Enabled = chkAplicaCostoAfectaPVP.Checked;
			rbAplicaCostoAfectaPVPCondicionalTrasladaIncremento.Enabled = chkAplicaCostoAfectaPVP.Checked;
			rbAplicaCostoAfectaPVPTodos.Enabled = chkAplicaCostoAfectaPVP.Checked;
			rbAplicaCostoAfectaPVPTodosIgualPVS.Enabled = chkAplicaCostoAfectaPVP.Checked;
			rbAplicaCostoAfectaPVPTodosTrasladaIncremento.Enabled = chkAplicaCostoAfectaPVP.Checked;
			
			/*Configura controles para el Precio de Venta*/
			rbAplicaPVP.Enabled = chkPrecioDeVentaBruto.Checked;
			rbAplicaPVS.Enabled = chkPrecioDeVentaBruto.Checked;
			chkAplicaPVSAfectaPVP.Enabled = rbAplicaPVS.Checked;
			rbAplicaPVSAfectaPVPCondicional.Enabled = chkAplicaPVSAfectaPVP.Checked;
			rbAplicaPVSAfectaPVPCondicionalIgualPVS.Enabled = rbAplicaPVSAfectaPVPCondicional.Checked;
			rbAplicaPVSAfectaPVPCondicionalTrasladaIncremento.Enabled = rbAplicaPVSAfectaPVPCondicional.Checked;
			rbAplicaPVSAfectaPVPTodos.Enabled = chkAplicaPVSAfectaPVP.Checked;
			rbAplicaPVSAfectaPVPTodosIgualPVS.Enabled = rbAplicaPVSAfectaPVPTodos.Checked;
			rbAplicaPVSAfectaPVPTodosTrasladaIncremento.Enabled = rbAplicaPVSAfectaPVPTodos.Checked;

			/*Configura controles para el MAC*/
			chkAplicaMACAfectaPVP.Enabled = chkMAC.Checked;
			rbAplicaMACAfectaPVPCondicional.Enabled = chkAplicaMACAfectaPVP.Checked;
			rbAplicaMACAfectaPVPCondicionalIgualPVS.Enabled = chkAplicaMACAfectaPVP.Checked;
			rbAplicaMACAfectaPVPCondicionalTrasladaIncremento.Enabled = chkAplicaMACAfectaPVP.Checked;
			rbAplicaMACAfectaPVPTodos.Enabled = chkAplicaMACAfectaPVP.Checked;
			rbAplicaMACAfectaPVPTodosIgualPVS.Enabled = chkAplicaMACAfectaPVP.Checked;
			rbAplicaMACAfectaPVPTodosTrasladaIncremento.Enabled = chkAplicaMACAfectaPVP.Checked;

			utbDeshacer.Enabled = false;
						
			
			
		}

		private void InitializeData()
		{						
			
			mzProductosControl.AddObjectListener( (IObserver)_uiController );
			mzCEMonedas.FillFromDataSource( _uiController.TableMonedas, "idMoneda", "Descripcion", 8, "1", "2", "Descripcion");
			mzCEFuentesDeCambio.FillFromDataSource( _uiController.TableFuentesDeCambio, "idFuenteDeCambio", "Descripcion", 8, "1", "2", "Descripcion");



			
		}
		private void InitEventHandlers()
		{			
			uneMAC.Enter +=new EventHandler(SeleccionarTexto);
			uneMaxDescuento.Enter +=new EventHandler(SeleccionarTexto);
			uneMaxDescuentoPorcentual.Enter +=new EventHandler(SeleccionarTexto);
			unePrecioDeCostoRef.Enter +=new EventHandler( SeleccionarTexto);
			unePrecioDeVentaNeto.Enter +=new EventHandler(SeleccionarTexto);
			unePrecioVentaBruto.Enter +=new EventHandler(SeleccionarTexto);
			_uiController.ObjectHasChanged +=new EventHandler(RefreshControls);
			gridProductos.SelectionChanged +=new EventHandler(gridProductos_SelectionChanged);
			toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			_uiController.ProductosCollectionChanged +=	new EventHandler(Refresh);
			_uiController.ErrorOcurred +=new EventHandler(_uiController_ErrorOcurred);
			gridProductos.RecordsDeleted +=new EventHandler(gridProductos_RecordsDeleted);
			gridProductos.DeletingRecords +=new CancelEventHandler(gridProductos_DeletingRecords);
			chkProcentaje.CheckedChanged +=new EventHandler(chkProcentaje_CheckedChanged);
			chkValorConstante.CheckedChanged +=new EventHandler(chkValorConstante_CheckedChanged);
			utbActualizarPrecios.Click+=new EventHandler(utbActualizarPrecios_Click);
			utbDeshacer.Click +=new EventHandler(utbDeshacer_Click);
			chkPrecioDeCosto.CheckedChanged +=new EventHandler(chkPrecioDeCosto_CheckedChanged);
			chkAplicaCostoAfectaPVP.CheckedChanged +=new EventHandler(chkAplicaCostoAfectaPVP_CheckedChanged);
			chkPrecioDeVentaBruto.CheckedChanged +=new EventHandler(chkPrecioDeVentaBruto_CheckedChanged);
			rbAplicaPVS.CheckedChanged +=new EventHandler(rbAplicaPVS_CheckedChanged);
			chkAplicaPVSAfectaPVP.CheckedChanged +=new EventHandler(chkAplicaPVSAfectaPVP_CheckedChanged);
			chkMAC.CheckedChanged +=new EventHandler(chkMAC_CheckedChanged);
			chkAplicaMACAfectaPVP.CheckedChanged +=new EventHandler(chkAplicaMACAfectaPVP_CheckedChanged);
			rbAplicaCostoAfectaPVPCondicional.CheckedChanged +=new EventHandler(rbAplicaCostoAfectaPVPCondicional_CheckedChanged);
			rbAplicaCostoAfectaPVPTodos.CheckedChanged +=new EventHandler(rbAplicaCostoAfectaPVPTodos_CheckedChanged);
			rbAplicaMACAfectaPVPCondicional.CheckedChanged +=new EventHandler(rbAplicaMACAfectaPVPCondicional_CheckedChanged);
			rbAplicaMACAfectaPVPTodos.CheckedChanged +=new EventHandler(rbAplicaMACAfectaPVPTodos_CheckedChanged);
			rbAplicaPVSAfectaPVPCondicional.CheckedChanged +=new EventHandler(rbAplicaPVSAfectaPVPCondicional_CheckedChanged);
			rbAplicaPVSAfectaPVPTodos.CheckedChanged +=new EventHandler(rbAplicaPVSAfectaPVPTodos_CheckedChanged);
			

		}

		private void RefreshControls(object sender, EventArgs e)
		{
			labelSimboloMonedaDescuentoMaximo.Text = _uiController.SimboloMonedaDescuentoMaximo;
			labelSimboloMonedaPrecioDeCostoReferencia.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaPrecioDeLista.Text = _uiController.SimboloMonedaPrecioDeLista;
			labelSimboloMonedaPrecioDeVentaNeto.Text = _uiController.SimboloMonedaPrecioDeVentaNeto;
			labelSimboloMonedaPrecioDeListaConImpuestos.Text = _uiController.SimboloMonedaPrecioDeLista;
			if(decimal.Round(Convert.ToDecimal(unePrecioVentaBruto.Value),4) < decimal.Round(Convert.ToDecimal(unePrecioDeVentaNeto.Value),4))
				unePrecioVentaBruto.Appearance.ForeColor = Color.Red;
			else unePrecioVentaBruto.Appearance.ForeColor = Color.Black;
			/*
			gridProductos.SetDataBinding(null, null);
			gridProductos.SetDataBinding(_uiController.Items, null);
			*/
			gridProductos.SelectionChanged -=new EventHandler(gridProductos_SelectionChanged);
			gridProductos.DataSource = _uiController.Items;
			gridProductos.SelectionChanged +=new EventHandler(gridProductos_SelectionChanged);
			if(gridProductos.RowCount > 1 && (gridProductos.RowCount - 1 >= _selectedIndex))
			{
				gridProductos.Row = _selectedIndex;
				gridProductos.Select();
					
			}
			if(gridProductos.RecordCount == 1)
				this.gridProductos_SelectionChanged(gridProductos, new EventArgs());
		}
	
		private void Refresh(object sender, EventArgs e)
		{
			try
			{
				/*
				gridProductos.SetDataBinding(null, null);
				gridProductos.SetDataBinding(_uiController.Items, null);
				gridProductos.UpdateData();
				*/
				gridProductos.SelectionChanged -=new EventHandler(gridProductos_SelectionChanged);
				gridProductos.DataSource = _uiController.Items;
				gridProductos.SelectionChanged +=new EventHandler(gridProductos_SelectionChanged);

				if(gridProductos.RowCount > 1 && (gridProductos.RowCount - 1 >= _selectedIndex))
				{
					gridProductos.Row = _selectedIndex;
					gridProductos.Select();
					
				}
				if(gridProductos.RecordCount == 1)
					this.gridProductos_SelectionChanged(gridProductos, new EventArgs());
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	
		private void InitDataBindings()
		{				
			unePrecioDeVentaNeto.DataBindings.Clear();
			uneMAC.DataBindings.Clear();
			unePrecioVentaBruto.DataBindings.Clear();
			uneMaxDescuento.DataBindings.Clear();
			uneMaxDescuentoPorcentual.DataBindings.Clear();
			unePrecioDeCostoRef.DataBindings.Clear();
			gridProductos.SetDataBinding(null, null);
			unePrecioDeListaConImpuesto.DataBindings.Clear();
			gridProductos.SetDataBinding(_uiController.Items, null);
			mzCEMonedas.DataBindings.Clear();
			chkPrecioDeCosto.DataBindings.Clear();
			chkPrecioDeVentaBruto.DataBindings.Clear();
			chkProcentaje.DataBindings.Clear();
			chkValorConstante.DataBindings.Clear();
			unePorcentaje.DataBindings.Clear();
			uneValorConstante.DataBindings.Clear();
			mzCEFuentesDeCambio.DataBindings.Clear();
			
			mzCEFuentesDeCambio.DataBindings.Add("Value", _uiController, "IdFuenteDeCambioValorConstante");
			mzCEMonedas.DataBindings.Add("Value", _uiController, "IdMonedaValorConstante");
			uneMAC.DataBindings.Add("Value", _uiController, "MAC");
			unePrecioDeVentaNeto.DataBindings.Add("Value", _uiController, "PrecioDeVentaNeto");
			unePrecioVentaBruto.DataBindings.Add("Value", _uiController, "PrecioDeVentaBruto");
			uneMaxDescuento.DataBindings.Add("Value", _uiController, "MaximoDescuento");
			uneMaxDescuentoPorcentual.DataBindings.Add("Value", _uiController, "PorcentajeMaximoDescuento");
			unePrecioDeCostoRef.DataBindings.Add("Value", _uiController, "PrecioCostoRef");
			unePrecioDeListaConImpuesto.DataBindings.Add("Value", _uiController, "PrecioDeListaConImpuestos");
			//chkProcentaje.DataBindings.Add("Checked", _uiController, "AplicaPorcentaje");
			BindingController.Bind(chkProcentaje,"Checked", _uiController, "AplicaPorcentaje");
			//chkValorConstante.DataBindings.Add("Checked", _uiController, "AplicaValorConstante");
			BindingController.Bind(chkValorConstante,"Checked", _uiController, "AplicaValorConstante");
			unePorcentaje.DataBindings.Add("Value", _uiController, "Porcentaje");
			uneValorConstante.DataBindings.Add("Value", _uiController, "ValorConstante");


			/*Bindeos para el precio de Costo*/
			BindingController.Bind(chkPrecioDeCosto,"Checked", _uiController, "AplicaSobreCosto");
			BindingController.Bind(chkAplicaCostoAfectaPVP,"Checked", _uiController, "AplicaSobreCostoAfectaPVP");
			BindingController.Bind(rbAplicaCostoAfectaPVPCondicionalIgualPVS,"Checked", _uiController, "AplicaSobreCostoAfectaPVPCondicionalIgualPVS");
			BindingController.Bind(rbAplicaCostoAfectaPVPCondicionalTrasladaIncremento,"Checked", _uiController, "AplicaSobreCostoAfectaPVPCondicionalTrasladaIncremento");
			BindingController.Bind(rbAplicaCostoAfectaPVPTodosIgualPVS,"Checked", _uiController, "AplicaSobreCostoAfectaPVPTodosIgualPVS");
			BindingController.Bind(rbAplicaCostoAfectaPVPTodosTrasladaIncremento,"Checked", _uiController, "AplicaSobreCostoAfectaPVPTodosTrasladaIncremento");
			BindingController.Bind(rbAplicaCostoAfectaPVPTodos,"Checked", _uiController, "AplicaSobreCostoAfectaPVPTodos");
			BindingController.Bind(rbAplicaCostoAfectaPVPCondicional,"Checked", _uiController, "AplicaSobreCostoAfectaPVPCondicional");


			/*Bindeos sobre el precio de Venta*/
			BindingController.Bind(chkPrecioDeVentaBruto,"Checked", _uiController, "AplicaSobrePrecioDeVenta");
			BindingController.Bind(rbAplicaPVS,"Checked", _uiController, "AplicaSobrePrecioDeVentaNeto");
			BindingController.Bind(rbAplicaPVP,"Checked", _uiController, "AplicaSobrePrecioDeVentaBruto");
			BindingController.Bind(chkAplicaPVSAfectaPVP,"Checked", _uiController, "AplicaSobrePVSAfectaPVP");
			BindingController.Bind(rbAplicaPVSAfectaPVPTodos,"Checked", _uiController, "AplicaSobrePVSAfectaPVPTodos");
			BindingController.Bind(rbAplicaPVSAfectaPVPCondicional,"Checked", _uiController, "AplicaSobrePVSAfectaPVPCondicional");
			BindingController.Bind(rbAplicaPVSAfectaPVPCondicionalIgualPVS,"Checked", _uiController, "AplicaSobrePVSAfectaPVPCondicionalIgualPVS");
			BindingController.Bind(rbAplicaPVSAfectaPVPCondicionalTrasladaIncremento,"Checked", _uiController, "AplicaSobrePVSAfectaPVPCondicionalTrasladaIncremento");
			BindingController.Bind(rbAplicaPVSAfectaPVPTodosIgualPVS,"Checked", _uiController, "AplicaSobrePVSAfectaPVPTodosIgualPVS");
			BindingController.Bind(rbAplicaPVSAfectaPVPTodosTrasladaIncremento,"Checked", _uiController, "AplicaSobrePVSAfectaPVPTodosTrasladaIncremento");

			/*Bindeos sobre el MAC*/
			BindingController.Bind(chkMAC,"Checked", _uiController, "AplicaSobreMAC");
			BindingController.Bind(chkAplicaMACAfectaPVP,"Checked", _uiController, "AplicaSobreMACAfectaPVP");
			BindingController.Bind(rbAplicaMACAfectaPVPTodos,"Checked", _uiController, "AplicaSobreMACAfectaPVPTodos");
			BindingController.Bind(rbAplicaMACAfectaPVPTodos,"Checked", _uiController, "AplicaSobreMACAfectaPVPCondicional");
			BindingController.Bind(rbAplicaMACAfectaPVPCondicionalIgualPVS,"Checked", _uiController, "AplicaSobreMACAfectaPVPCondicionalIgualPVS");
			BindingController.Bind(rbAplicaMACAfectaPVPCondicionalTrasladaIncremento,"Checked", _uiController, "AplicaSobreMACAfectaPVPCondicionalTrasladaIncremento");
			BindingController.Bind(rbAplicaMACAfectaPVPTodosIgualPVS,"Checked", _uiController, "AplicaSobreMACAfectaPVPTodosIgualPVS");
			BindingController.Bind(rbAplicaMACAfectaPVPTodosTrasladaIncremento,"Checked", _uiController, "AplicaSobreMACAfectaPVPTodosTrasladaIncremento");

			
			




			
		}
		#endregion

		#region Miembros de ITaskForm

		public void Execute()
		{
			this._uiController.Execute();
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


		#endregion

		#region Windows Form

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
				_uiController.ObjectHasChanged -=new EventHandler(Refresh);
				gridProductos.SelectionChanged -=new EventHandler(gridProductos_SelectionChanged);
				unePrecioDeVentaNeto.DataBindings.Clear();
				uneMAC.DataBindings.Clear();
				unePrecioVentaBruto.DataBindings.Clear();
				uneMaxDescuento.DataBindings.Clear();
				uneMaxDescuentoPorcentual.DataBindings.Clear();
				unePrecioDeCostoRef.DataBindings.Clear();
				//chkProcentaje.DataBindings.Add("Checked", _uiController, "AplicaPorcentaje");
				BindingController.Clear(chkProcentaje,"Checked", _uiController, "AplicaPorcentaje");
				//chkValorConstante.DataBindings.Add("Checked", _uiController, "AplicaValorConstante");
				BindingController.Clear(chkValorConstante,"Checked", _uiController, "AplicaValorConstante");
				BindingController.Clear(chkPrecioDeCosto,"Checked", _uiController, "AplicaSobreCosto");
				BindingController.Clear(chkAplicaCostoAfectaPVP,"Checked", _uiController, "AplicaSobreCostoAfectaPVP");
				BindingController.Clear(rbAplicaCostoAfectaPVPCondicionalIgualPVS,"Checked", _uiController, "AplicaSobreCostoAfectaPVPCondicionalIgualPVS");
				BindingController.Clear(rbAplicaCostoAfectaPVPCondicionalTrasladaIncremento,"Checked", _uiController, "AplicaSobreCostoAfectaPVPCondicionalTrasladaIncremento");
				BindingController.Clear(rbAplicaCostoAfectaPVPTodosIgualPVS,"Checked", _uiController, "AplicaSobreCostoAfectaPVPTodosIgualPVS");
				BindingController.Clear(rbAplicaCostoAfectaPVPTodosTrasladaIncremento,"Checked", _uiController, "AplicaSobreCostoAfectaPVPTodosTrasladaIncremento");
				BindingController.Clear(rbAplicaCostoAfectaPVPTodos,"Checked", _uiController, "AplicaSobreCostoAfectaPVPTodos");
				BindingController.Clear(rbAplicaCostoAfectaPVPCondicional,"Checked", _uiController, "AplicaSobreCostoAfectaPVPCondicional");


				/*Bindeos sobre el precio de Venta*/
				BindingController.Clear(chkPrecioDeVentaBruto,"Checked", _uiController, "AplicaSobrePrecioDeVenta");
				BindingController.Clear(rbAplicaPVS,"Checked", _uiController, "AplicaSobrePrecioDeVentaNeto");
				BindingController.Clear(rbAplicaPVP,"Checked", _uiController, "AplicaSobrePrecioDeVentaBruto");
				BindingController.Clear(chkAplicaPVSAfectaPVP,"Checked", _uiController, "AplicaSobrePVSAfectaPVP");
				BindingController.Clear(rbAplicaPVSAfectaPVPTodos,"Checked", _uiController, "AplicaSobrePVSAfectaPVPTodos");
				BindingController.Clear(rbAplicaPVSAfectaPVPCondicional,"Checked", _uiController, "AplicaSobrePVSAfectaPVPCondicional");
				BindingController.Clear(rbAplicaPVSAfectaPVPCondicionalIgualPVS,"Checked", _uiController, "AplicaSobrePVSAfectaPVPCondicionalIgualPVS");
				BindingController.Clear(rbAplicaPVSAfectaPVPCondicionalTrasladaIncremento,"Checked", _uiController, "AplicaSobrePVSAfectaPVPCondicionalTrasladaIncremento");
				BindingController.Clear(rbAplicaPVSAfectaPVPTodosIgualPVS,"Checked", _uiController, "AplicaSobrePVSAfectaPVPTodosIgualPVS");
				BindingController.Clear(rbAplicaPVSAfectaPVPTodosTrasladaIncremento,"Checked", _uiController, "AplicaSobrePVSAfectaPVPTodosTrasladaIncremento");

				/*Bindeos sobre el MAC*/
				BindingController.Clear(chkMAC,"Checked", _uiController, "AplicaSobreMAC");
				BindingController.Clear(chkAplicaMACAfectaPVP,"Checked", _uiController, "AplicaSobreMACAfectaPVP");
				BindingController.Clear(rbAplicaMACAfectaPVPTodos,"Checked", _uiController, "AplicaSobreMACAfectaPVPTodos");
				BindingController.Clear(rbAplicaMACAfectaPVPTodos,"Checked", _uiController, "AplicaSobreMACAfectaPVPCondicional");
				BindingController.Clear(rbAplicaMACAfectaPVPCondicionalIgualPVS,"Checked", _uiController, "AplicaSobreMACAfectaPVPCondicionalIgualPVS");
				BindingController.Clear(rbAplicaMACAfectaPVPCondicionalTrasladaIncremento,"Checked", _uiController, "AplicaSobreMACAfectaPVPCondicionalTrasladaIncremento");
				BindingController.Clear(rbAplicaMACAfectaPVPTodosIgualPVS,"Checked", _uiController, "AplicaSobreMACAfectaPVPTodosIgualPVS");
				BindingController.Clear(rbAplicaMACAfectaPVPTodosTrasladaIncremento,"Checked", _uiController, "AplicaSobreMACAfectaPVPTodosTrasladaIncremento");

			
				
				
			}
			base.Dispose( disposing );
		}
		#endregion
		private void SeleccionarTexto(object sender, EventArgs e)
		{
			if(sender.GetType().Equals(typeof(Infragistics.Win.UltraWinEditors.UltraNumericEditor)))
				((Infragistics.Win.UltraWinEditors.UltraNumericEditor)sender).SelectAll();
		}

		private void mzCEProductos_Load(object sender, System.EventArgs e)
		{
		
		}

		public void AddObjectListener(IObserver observer)
		{
			_uiController.AddObjectListener(observer);
		}

		private void gridProductos_SelectionChanged(object sender, EventArgs e)
		{
			if(gridProductos.SelectedItems.Count > 0)
			{
				object selectedItem = gridProductos.SelectedItems[0].GetRow().DataRow;
				_selectedIndex = gridProductos.Row;
				_uiController.ObjectHasChanged -=new EventHandler(RefreshControls);
				_uiController.ProductosCollectionChanged -=	new EventHandler(Refresh);
				_uiController.SelectedItem = selectedItem;
				_uiController.ObjectHasChanged +=new EventHandler(RefreshControls);
				_uiController.ProductosCollectionChanged +=	new EventHandler(Refresh);
				unePrecioDeCostoRef.ReadOnly = !_uiController.AllowEditPrecioDeCostoRef;
				uneMAC.ReadOnly = false;
				unePrecioDeVentaNeto.ReadOnly = true;
				uneMaxDescuento.ReadOnly = true;
				uneMaxDescuentoPorcentual.ReadOnly = true;
				unePrecioVentaBruto.ReadOnly = false;
				unePrecioDeListaConImpuesto.ReadOnly  = false;
				

			}

		}

		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					_uiController.Previous();
					break;
				case 2://Guardar					
					_uiController.Execute();
					break;
			}						
		}

		private void ultraLabel11_Click(object sender, System.EventArgs e)
		{
		
		}

		private void groupMZ_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void gridProductos_RecordsDeleted(object sender, EventArgs e)
		{
			_uiController.DeleteSelectedItem();
			gridProductos.SelectionChanged +=new EventHandler(gridProductos_SelectionChanged);
			if(gridProductos.RecordCount > 0)
			{
				gridProductos.Row = 0;
				gridProductos.Select();
				this.gridProductos_SelectionChanged(gridProductos, new EventArgs());
				

			}
			else
			{
				unePrecioDeCostoRef.ReadOnly = true;
				uneMAC.ReadOnly = true;
				unePrecioDeVentaNeto.ReadOnly = true;
				uneMaxDescuento.ReadOnly = true;
				uneMaxDescuentoPorcentual.ReadOnly = true;
				unePrecioVentaBruto.ReadOnly = true;
				unePrecioDeListaConImpuesto.ReadOnly = true;
			}

		}

		private void gridProductos_DeletingRecords(object sender, CancelEventArgs e)
		{
			gridProductos.SelectionChanged -=new EventHandler(gridProductos_SelectionChanged);
		}

		private void chkProcentaje_CheckedChanged(object sender, EventArgs e)
		{
			unePorcentaje.Enabled = chkProcentaje.Checked;
		}

		private void chkValorConstante_CheckedChanged(object sender, EventArgs e)
		{
			uneValorConstante.Enabled = chkValorConstante.Checked;
			mzCEMonedas.Enabled =  chkValorConstante.Checked;
			mzCEMonedas.ReadOnly = !chkValorConstante.Checked;
			mzCEFuentesDeCambio.Enabled = chkValorConstante.Checked;
			mzCEFuentesDeCambio.ReadOnly = !chkValorConstante.Checked;
		}

		

		
		private void utbActualizarPrecios_Click(object sender, EventArgs e)
		{
			_uiController.ActualizarPrecios();
			if(_uiController.PermiteDeshacer)
				utbDeshacer.Enabled = true;
		}

		private void chkPrecioDeCosto_CheckedChanged(object sender, EventArgs e)
		{
			if(chkPrecioDeCosto.Checked)
			{
				chkPrecioDeVentaBruto.Checked = false;
				chkMAC.Checked = false;
				chkValorConstante.Enabled = true;
			}
			chkAplicaCostoAfectaPVP.Enabled = chkPrecioDeCosto.Checked ;
			rbAplicaCostoAfectaPVPCondicional.Enabled = chkPrecioDeCosto.Checked && chkAplicaCostoAfectaPVP.Checked;
			rbAplicaCostoAfectaPVPTodos.Enabled = chkPrecioDeCosto.Checked && chkAplicaCostoAfectaPVP.Checked;
			rbAplicaCostoAfectaPVPCondicionalIgualPVS.Enabled = chkPrecioDeCosto.Checked && chkAplicaCostoAfectaPVP.Checked && rbAplicaCostoAfectaPVPCondicional.Checked;
			rbAplicaCostoAfectaPVPCondicionalTrasladaIncremento.Enabled =  chkPrecioDeCosto.Checked && chkAplicaCostoAfectaPVP.Checked && rbAplicaCostoAfectaPVPCondicional.Checked;
			rbAplicaCostoAfectaPVPTodosIgualPVS.Enabled =  chkPrecioDeCosto.Checked && chkAplicaCostoAfectaPVP.Checked && rbAplicaCostoAfectaPVPTodos.Checked;
			rbAplicaCostoAfectaPVPTodosTrasladaIncremento.Enabled =  chkPrecioDeCosto.Checked && chkAplicaCostoAfectaPVP.Checked && rbAplicaCostoAfectaPVPTodos.Checked;
		}

		private void chkAplicaCostoAfectaPVP_CheckedChanged(object sender, EventArgs e)
		{
			rbAplicaCostoAfectaPVPCondicional.Enabled = chkAplicaCostoAfectaPVP.Checked && chkPrecioDeCosto.Checked;
			rbAplicaCostoAfectaPVPTodos.Enabled = chkAplicaCostoAfectaPVP.Checked && chkPrecioDeCosto.Checked;
			rbAplicaCostoAfectaPVPCondicionalIgualPVS.Enabled = rbAplicaCostoAfectaPVPCondicional.Checked && chkAplicaCostoAfectaPVP.Checked && chkPrecioDeCosto.Checked;
			rbAplicaCostoAfectaPVPCondicionalTrasladaIncremento.Enabled = rbAplicaCostoAfectaPVPCondicional.Checked && chkAplicaCostoAfectaPVP.Checked && chkPrecioDeCosto.Checked;
			rbAplicaCostoAfectaPVPTodosIgualPVS.Enabled = rbAplicaCostoAfectaPVPTodos.Checked && chkAplicaCostoAfectaPVP.Checked && chkPrecioDeCosto.Checked;
			rbAplicaCostoAfectaPVPTodosTrasladaIncremento.Enabled = rbAplicaCostoAfectaPVPTodos.Checked && chkAplicaCostoAfectaPVP.Checked && chkPrecioDeCosto.Checked;
		}

		private void chkPrecioDeVentaBruto_CheckedChanged(object sender, EventArgs e)
		{
			if(chkPrecioDeVentaBruto.Checked)
			{
				chkMAC.Checked = false;
				chkPrecioDeCosto.Checked = false;
				chkValorConstante.Enabled = true;
			}
			rbAplicaPVP.Enabled = chkPrecioDeVentaBruto.Checked;
			rbAplicaPVS.Enabled = chkPrecioDeVentaBruto.Checked;
			chkAplicaPVSAfectaPVP.Enabled = chkPrecioDeVentaBruto.Checked && rbAplicaPVS.Checked;
			rbAplicaPVSAfectaPVPCondicional.Enabled = chkPrecioDeVentaBruto.Checked && rbAplicaPVS.Checked && chkAplicaPVSAfectaPVP.Checked;
			rbAplicaPVSAfectaPVPTodos.Enabled = chkPrecioDeVentaBruto.Checked && rbAplicaPVS.Checked && chkAplicaPVSAfectaPVP.Checked;
			rbAplicaPVSAfectaPVPCondicionalIgualPVS.Enabled = chkPrecioDeVentaBruto.Checked && rbAplicaPVS.Checked && chkAplicaPVSAfectaPVP.Checked && rbAplicaPVSAfectaPVPCondicional.Checked;
			rbAplicaPVSAfectaPVPCondicionalTrasladaIncremento.Enabled = chkPrecioDeVentaBruto.Checked && rbAplicaPVS.Checked && chkAplicaPVSAfectaPVP.Checked && rbAplicaPVSAfectaPVPCondicional.Checked;
			rbAplicaPVSAfectaPVPTodosIgualPVS.Enabled = chkPrecioDeVentaBruto.Checked && rbAplicaPVS.Checked && chkAplicaPVSAfectaPVP.Checked && rbAplicaPVSAfectaPVPTodos.Checked;
			rbAplicaPVSAfectaPVPTodosTrasladaIncremento.Enabled = chkPrecioDeVentaBruto.Checked && rbAplicaPVS.Checked && chkAplicaPVSAfectaPVP.Checked && rbAplicaPVSAfectaPVPTodos.Checked;

		}

		private void rbAplicaPVS_CheckedChanged(object sender, EventArgs e)
		{
			chkAplicaPVSAfectaPVP.Enabled = rbAplicaPVS.Checked;
			rbAplicaPVSAfectaPVPCondicional.Enabled = chkAplicaPVSAfectaPVP.Checked && rbAplicaPVS.Checked;
			rbAplicaPVSAfectaPVPTodos.Enabled = chkAplicaPVSAfectaPVP.Checked && rbAplicaPVS.Checked;
			rbAplicaPVSAfectaPVPCondicionalIgualPVS.Enabled = rbAplicaPVSAfectaPVPCondicional.Checked  &&  chkAplicaPVSAfectaPVP.Checked && rbAplicaPVS.Checked;
			rbAplicaPVSAfectaPVPCondicionalTrasladaIncremento.Enabled = rbAplicaPVSAfectaPVPCondicional.Checked &&  chkAplicaPVSAfectaPVP.Checked && rbAplicaPVS.Checked;
			rbAplicaPVSAfectaPVPTodosIgualPVS.Enabled = rbAplicaPVSAfectaPVPTodos.Checked &&  chkAplicaPVSAfectaPVP.Checked && rbAplicaPVS.Checked;
			rbAplicaPVSAfectaPVPTodosTrasladaIncremento.Enabled = rbAplicaPVSAfectaPVPTodos.Checked &&  chkAplicaPVSAfectaPVP.Checked && rbAplicaPVS.Checked;
		}

		private void chkAplicaPVSAfectaPVP_CheckedChanged(object sender, EventArgs e)
		{
			rbAplicaPVSAfectaPVPCondicional.Enabled = chkAplicaPVSAfectaPVP.Checked && rbAplicaPVS.Checked;
			rbAplicaPVSAfectaPVPTodos.Enabled = chkAplicaPVSAfectaPVP.Checked && rbAplicaPVS.Checked;
			rbAplicaPVSAfectaPVPCondicionalIgualPVS.Enabled = rbAplicaPVSAfectaPVPCondicional.Checked  &&  chkAplicaPVSAfectaPVP.Checked && rbAplicaPVS.Checked;
			rbAplicaPVSAfectaPVPCondicionalTrasladaIncremento.Enabled = rbAplicaPVSAfectaPVPCondicional.Checked &&  chkAplicaPVSAfectaPVP.Checked && rbAplicaPVS.Checked;
			rbAplicaPVSAfectaPVPTodosIgualPVS.Enabled = rbAplicaPVSAfectaPVPTodos.Checked &&  chkAplicaPVSAfectaPVP.Checked && rbAplicaPVS.Checked;
			rbAplicaPVSAfectaPVPTodosTrasladaIncremento.Enabled = rbAplicaPVSAfectaPVPTodos.Checked &&  chkAplicaPVSAfectaPVP.Checked && rbAplicaPVS.Checked;
		}

		private void chkMAC_CheckedChanged(object sender, EventArgs e)
		{
			if(chkMAC.Checked)
			{
				chkPrecioDeVentaBruto.Checked = false;
				chkPrecioDeCosto.Checked = false;
				chkValorConstante.Checked = false;
				chkValorConstante.Enabled = false;
			}
			chkAplicaMACAfectaPVP.Enabled = chkMAC.Checked;
			rbAplicaMACAfectaPVPCondicional.Enabled = chkMAC.Checked && chkAplicaMACAfectaPVP.Checked;
			rbAplicaMACAfectaPVPTodos.Enabled = chkMAC.Checked && chkAplicaMACAfectaPVP.Checked ;
			rbAplicaMACAfectaPVPCondicionalIgualPVS.Enabled = chkMAC.Checked && chkAplicaMACAfectaPVP.Checked && rbAplicaMACAfectaPVPCondicional.Checked;
			rbAplicaMACAfectaPVPCondicionalTrasladaIncremento.Enabled = chkMAC.Checked && chkAplicaMACAfectaPVP.Checked && rbAplicaMACAfectaPVPCondicional.Checked;
			rbAplicaMACAfectaPVPTodosIgualPVS.Enabled = chkMAC.Checked && chkAplicaMACAfectaPVP.Checked && rbAplicaMACAfectaPVPTodos.Checked;
			rbAplicaMACAfectaPVPTodosTrasladaIncremento.Enabled = chkMAC.Checked && chkAplicaMACAfectaPVP.Checked && rbAplicaMACAfectaPVPTodos.Checked;
		}

		private void chkAplicaMACAfectaPVP_CheckedChanged(object sender, EventArgs e)
		{
			rbAplicaMACAfectaPVPCondicional.Enabled = chkAplicaMACAfectaPVP.Checked;
			rbAplicaMACAfectaPVPTodos.Enabled = chkAplicaMACAfectaPVP.Checked;
			rbAplicaMACAfectaPVPCondicionalIgualPVS.Enabled = rbAplicaMACAfectaPVPCondicional.Checked && chkAplicaMACAfectaPVP.Checked;
			rbAplicaMACAfectaPVPCondicionalTrasladaIncremento.Enabled = rbAplicaMACAfectaPVPCondicional.Checked && chkAplicaMACAfectaPVP.Checked;
			rbAplicaMACAfectaPVPTodosIgualPVS.Enabled = rbAplicaMACAfectaPVPTodos.Checked && chkAplicaMACAfectaPVP.Checked;
			rbAplicaMACAfectaPVPTodosTrasladaIncremento.Enabled = rbAplicaMACAfectaPVPTodos.Checked && chkAplicaMACAfectaPVP.Checked;
		}

		private void rbAplicaCostoAfectaPVPCondicional_CheckedChanged(object sender, EventArgs e)
		{
			rbAplicaCostoAfectaPVPCondicionalIgualPVS.Enabled = rbAplicaCostoAfectaPVPCondicional.Checked;
			rbAplicaCostoAfectaPVPCondicionalTrasladaIncremento.Enabled = rbAplicaCostoAfectaPVPCondicional.Checked;
		}

		private void rbAplicaCostoAfectaPVPTodos_CheckedChanged(object sender, EventArgs e)
		{
			rbAplicaCostoAfectaPVPTodosIgualPVS.Enabled = rbAplicaCostoAfectaPVPTodos.Checked;
			rbAplicaCostoAfectaPVPTodosTrasladaIncremento.Enabled = rbAplicaCostoAfectaPVPTodos.Checked;

		}

		private void rbAplicaMACAfectaPVPCondicional_CheckedChanged(object sender, EventArgs e)
		{
			rbAplicaMACAfectaPVPCondicionalIgualPVS.Enabled = rbAplicaMACAfectaPVPCondicional.Checked;
			rbAplicaMACAfectaPVPCondicionalTrasladaIncremento.Enabled = rbAplicaMACAfectaPVPCondicional.Checked;
		}

		private void rbAplicaMACAfectaPVPTodos_CheckedChanged(object sender, EventArgs e)
		{
			rbAplicaMACAfectaPVPTodosIgualPVS.Enabled = rbAplicaMACAfectaPVPTodos.Checked;
			rbAplicaMACAfectaPVPTodosTrasladaIncremento.Enabled = rbAplicaMACAfectaPVPTodos.Checked;
		}

		private void rbAplicaPVSAfectaPVPCondicional_CheckedChanged(object sender, EventArgs e)
		{
			rbAplicaPVSAfectaPVPCondicionalIgualPVS.Enabled = rbAplicaPVSAfectaPVPCondicional.Checked;
			rbAplicaPVSAfectaPVPCondicionalTrasladaIncremento.Enabled = rbAplicaPVSAfectaPVPCondicional.Checked;
		}

		private void rbAplicaPVSAfectaPVPTodos_CheckedChanged(object sender, EventArgs e)
		{
			rbAplicaPVSAfectaPVPTodosIgualPVS.Enabled = rbAplicaPVSAfectaPVPTodos.Checked;
			rbAplicaPVSAfectaPVPTodosTrasladaIncremento.Enabled = rbAplicaPVSAfectaPVPTodos.Checked;
		}

		private void utbDeshacer_Click(object sender, EventArgs e)
		{
			_uiController.DeshacerActualizacion();
			if(!_uiController.PermiteDeshacer)
				utbDeshacer.Enabled = false;
		}

		private void _uiController_ErrorOcurred(object sender, EventArgs e)
		{
			MessageBox.Show(_uiController.ErrorMessage, "Error",  System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
		}
	}
}

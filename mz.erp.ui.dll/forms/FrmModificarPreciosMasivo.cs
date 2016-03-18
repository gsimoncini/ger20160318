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
		private System.Windows.Forms.Label labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia;
		private System.Windows.Forms.Label label3;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeListaConImpuestoMonedaReferencia;
		private System.Windows.Forms.RadioButton rbAplicaPVPConImpuestos;
		private System.Windows.Forms.CheckBox chkMAC;
		private System.Windows.Forms.CheckBox chkMaximoDescuentoPorcentual;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferenciaLP;
		private System.Windows.Forms.Label labelSimboloMonedaPrecioDeListaConImpuestosLP;
		private System.Windows.Forms.Label labelSimboloMonedaPrecioDeListaLP;
		private System.Windows.Forms.Label labelSimboloMonedaDescuentoMaximoLP;
		private System.Windows.Forms.Label label30;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioFinalMonedaReferenciaLP;
		private System.Windows.Forms.Label label31;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeListaConImpuestoLP;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label33;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioVentaBrutoLP;
		private System.Windows.Forms.Label label34;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneMaxDescuentoLP;
		private System.Windows.Forms.Label label35;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneMaxDescuentoPorcentualLP;
		private System.Windows.Forms.Button btnRestablecerAGral;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficienteMonedaReferencia;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficiente;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label labelSimboloMonedaPrecioDeCostoReferenciaLP;
		private System.Windows.Forms.Label label25;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeCostoRefLP;
		private System.Windows.Forms.Label label23;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeVentaNetoLP;
		private System.Windows.Forms.Label labelSimboloMonedaPrecioDeVentaNetoLP;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label22;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneMACLP;
		private Janus.Windows.GridEX.GridEX gridListaDePrecios;
		private mz.erp.ui.controls.GridManagerView gridManagerView2;
		private System.Windows.Forms.RadioButton rbDescuentoAfectaPVP;
		private System.Windows.Forms.RadioButton rbDescuentoAfectaMac;
		private System.Windows.Forms.GroupBox groupRB;
		private System.Windows.Forms.RadioButton rbPorJerarquia;
		private System.Windows.Forms.RadioButton rbPorProducto;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupPorProducto;
		private Janus.Windows.GridEX.GridEX gridProductos;
		private mz.erp.ui.controls.mzProductosControl mzProductosControl;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupPorJerarquia;
		private mz.erp.ui.controls.HierarchicalSearchControl hierarchicalSearchControl1;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label5;
		private Infragistics.Win.Misc.UltraLabel ultraLabel7;
		private System.Windows.Forms.GroupBox gbAplicaCostoAfectaPCRTodos;
		private System.Windows.Forms.RadioButton rbAplicaCostoAfectaPCRTodos;
		private System.Windows.Forms.RadioButton rbAplicaCostoAfectaPCRTodosUsaPcioCtoReposicion;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private System.Windows.Forms.GroupBox groupMZ;
		private System.Windows.Forms.GroupBox panelCostosIndirectos;
		private System.Windows.Forms.CheckBox chkCoef10;
		private System.Windows.Forms.CheckBox chkCoef9;
		private System.Windows.Forms.CheckBox chkCoef8;
		private System.Windows.Forms.CheckBox chkCoef7;
		private System.Windows.Forms.CheckBox chkCoef6;
		private System.Windows.Forms.CheckBox chkCoef5;
		private System.Windows.Forms.CheckBox chkCoef4;
		private System.Windows.Forms.CheckBox chkCoef3;
		private System.Windows.Forms.CheckBox chkCoef2;
		private System.Windows.Forms.Label labelSimboloMonedaCoeficiente10;
		private System.Windows.Forms.Label labelSimboloMonedaCoeficiente9;
		private System.Windows.Forms.Label labelSimboloMonedaCoeficiente8;
		private System.Windows.Forms.Label labelPorc10;
		private System.Windows.Forms.Label labelPorc9;
		private System.Windows.Forms.Label labelPorc8;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficientePorc10;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficientePorc9;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficientePorc8;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficientePorc7;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficientePorc6;
		private Infragistics.Win.Misc.UltraLabel ultraCoeficiente10;
		private Infragistics.Win.Misc.UltraLabel ultraCoeficiente9;
		private Infragistics.Win.Misc.UltraLabel ultraCoeficiente8;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficiente10;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficiente9;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficiente8;
		private System.Windows.Forms.Label labelSimboloMonedaCoeficiente7;
		private System.Windows.Forms.Label labelSimboloMonedaCoeficiente6;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficiente7;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficiente6;
		private System.Windows.Forms.Label labelPorc6;
		private Infragistics.Win.Misc.UltraLabel ultraCoeficiente7;
		private Infragistics.Win.Misc.UltraLabel ultraCoeficiente6;
		private System.Windows.Forms.Label labelPorc7;
		private System.Windows.Forms.Label labelSimboloMonedaCoeficiente5;
		private System.Windows.Forms.Label labelSimboloMonedaCoeficiente4;
		private System.Windows.Forms.Label labelSimboloMonedaCoeficiente3;
		private System.Windows.Forms.Label labelPorc5;
		private System.Windows.Forms.Label labelPorc4;
		private System.Windows.Forms.Label labelPorc3;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficientePorc5;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficientePorc4;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficientePorc3;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficientePorc2;
		private Infragistics.Win.Misc.UltraLabel ultraCoeficiente5;
		private Infragistics.Win.Misc.UltraLabel ultraCoeficiente4;
		private Infragistics.Win.Misc.UltraLabel ultraCoeficiente3;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficiente5;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficiente4;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficiente3;
		private System.Windows.Forms.Label labelSimboloMonedaPrecioDeCosto6;
		private System.Windows.Forms.Label labelSimboloMonedaCoeficiente2;
		private System.Windows.Forms.Label labelSimboloMonedaCoeficiente1;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficienteTotal;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficiente2;
		private Infragistics.Win.Misc.UltraLabel ultraLabel9;
		private Infragistics.Win.Misc.UltraLabel ultraCoeficiente2;
		private Infragistics.Win.Misc.UltraLabel ultraCoeficiente1;
		private System.Windows.Forms.Label labelPorc2;
		private System.Windows.Forms.CheckBox chkCoef1;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficientePorc1;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficiente1;
		private System.Windows.Forms.Label labelPorc1;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePCostoPromedioPonderado1;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkUsaPrecioDeCostoReposicion1;
		private System.Windows.Forms.Label labelSimboloMonedaPrecioDeCostoReposicion1;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeCostoReposicion1;
		private System.Windows.Forms.Label labelSimboloMonedaPrecioDeCosto1;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkUsaPrecioDeCostoReposicion;
		private System.Windows.Forms.Label labelSimboloMonedaPrecioDeCostoReposicion;
		private System.Windows.Forms.Label label63;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeCostoReposicion;
		private Infragistics.Win.Misc.UltraLabel ultraLabel12;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePCostoPromedioPonderado;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label labelSimboloMonedaPrecioDeCosto;
		private System.Windows.Forms.GroupBox groupListasDePrecios;
		private Infragistics.Win.Misc.UltraButton btnTodos;
		private Infragistics.Win.Misc.UltraButton btnInvertir;
		private Infragistics.Win.Misc.UltraButton btnNinguno;
		private mz.erp.ui.controls.ToolTipCheckedListBox chkListasDePrecios;
		private Infragistics.Win.Misc.UltraButton btnVerSeleccionados;
		private Infragistics.Win.Misc.UltraButton btnVerTodas;
		private System.Windows.Forms.GroupBox gbReferencias;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private Infragistics.Win.Misc.UltraLabel ultraLabel3;
		private Infragistics.Win.Misc.UltraLabel ultraLabel2;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private System.Windows.Forms.GroupBox gbAplicaDescuento;
		private System.ComponentModel.IContainer components;

		

		

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarPreciosMasivo));
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup6 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.labelTarea = new System.Windows.Forms.Label();
            this.containerProductos = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbPorJerarquia = new System.Windows.Forms.RadioButton();
            this.rbPorProducto = new System.Windows.Forms.RadioButton();
            this.groupPorProducto = new System.Windows.Forms.GroupBox();
            this.gridProductos = new Janus.Windows.GridEX.GridEX();
            this.mzProductosControl = new mz.erp.ui.controls.mzProductosControl();
            this.label9 = new System.Windows.Forms.Label();
            this.groupPorJerarquia = new System.Windows.Forms.GroupBox();
            this.hierarchicalSearchControl1 = new mz.erp.ui.controls.HierarchicalSearchControl();
            this.groupRB = new System.Windows.Forms.GroupBox();
            this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.groupListasDePrecios = new System.Windows.Forms.GroupBox();
            this.btnTodos = new Infragistics.Win.Misc.UltraButton();
            this.btnInvertir = new Infragistics.Win.Misc.UltraButton();
            this.btnNinguno = new Infragistics.Win.Misc.UltraButton();
            this.chkListasDePrecios = new mz.erp.ui.controls.ToolTipCheckedListBox();
            this.btnVerSeleccionados = new Infragistics.Win.Misc.UltraButton();
            this.btnVerTodas = new Infragistics.Win.Misc.UltraButton();
            this.gbReferencias = new System.Windows.Forms.GroupBox();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.chkMaximoDescuentoPorcentual = new System.Windows.Forms.CheckBox();
            this.gbAplicaDescuento = new System.Windows.Forms.GroupBox();
            this.rbDescuentoAfectaPVP = new System.Windows.Forms.RadioButton();
            this.rbDescuentoAfectaMac = new System.Windows.Forms.RadioButton();
            this.chkPrecioDeVentaBruto = new System.Windows.Forms.CheckBox();
            this.chkMAC = new System.Windows.Forms.CheckBox();
            this.mzCEFuentesDeCambio = new mz.erp.ui.controls.mzComboEditor();
            this.chkPrecioDeCosto = new System.Windows.Forms.CheckBox();
            this.gbAplicaCosto = new System.Windows.Forms.GroupBox();
            this.gbAplicaCostoAfectaPCRTodos = new System.Windows.Forms.GroupBox();
            this.rbAplicaCostoAfectaPCRTodos = new System.Windows.Forms.RadioButton();
            this.rbAplicaCostoAfectaPCRTodosUsaPcioCtoReposicion = new System.Windows.Forms.RadioButton();
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
            this.rbAplicaPVPConImpuestos = new System.Windows.Forms.RadioButton();
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
            this.rbAplicaMACAfectaPVPTodos = new System.Windows.Forms.RadioButton();
            this.rbAplicaMACAfectaPVPCondicional = new System.Windows.Forms.RadioButton();
            this.gbAplicaMACAfectaPVPCondicional = new System.Windows.Forms.GroupBox();
            this.rbAplicaMACAfectaPVPCondicionalTrasladaIncremento = new System.Windows.Forms.RadioButton();
            this.rbAplicaMACAfectaPVPCondicionalIgualPVS = new System.Windows.Forms.RadioButton();
            this.gbAplicaMACAfectaPVPTodos = new System.Windows.Forms.GroupBox();
            this.rbAplicaMACAfectaPVPTodosTrasladaIncremento = new System.Windows.Forms.RadioButton();
            this.rbAplicaMACAfectaPVPTodosIgualPVS = new System.Windows.Forms.RadioButton();
            this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.groupMZ = new System.Windows.Forms.GroupBox();
            this.chkUsaPrecioDeCostoReposicion = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.labelSimboloMonedaPrecioDeCostoReposicion = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.unePrecioDeCostoReposicion = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraLabel12 = new Infragistics.Win.Misc.UltraLabel();
            this.labelSimboloMonedaPrecioDeCosto = new System.Windows.Forms.Label();
            this.unePCostoPromedioPonderado = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panelCostosIndirectos = new System.Windows.Forms.GroupBox();
            this.chkCoef10 = new System.Windows.Forms.CheckBox();
            this.chkCoef9 = new System.Windows.Forms.CheckBox();
            this.chkCoef8 = new System.Windows.Forms.CheckBox();
            this.chkCoef7 = new System.Windows.Forms.CheckBox();
            this.chkCoef6 = new System.Windows.Forms.CheckBox();
            this.chkCoef5 = new System.Windows.Forms.CheckBox();
            this.chkCoef4 = new System.Windows.Forms.CheckBox();
            this.chkCoef3 = new System.Windows.Forms.CheckBox();
            this.chkCoef2 = new System.Windows.Forms.CheckBox();
            this.labelSimboloMonedaCoeficiente10 = new System.Windows.Forms.Label();
            this.labelSimboloMonedaCoeficiente9 = new System.Windows.Forms.Label();
            this.labelSimboloMonedaCoeficiente8 = new System.Windows.Forms.Label();
            this.labelPorc10 = new System.Windows.Forms.Label();
            this.labelPorc9 = new System.Windows.Forms.Label();
            this.labelPorc8 = new System.Windows.Forms.Label();
            this.uneCoeficientePorc10 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneCoeficientePorc9 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneCoeficientePorc8 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneCoeficientePorc7 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneCoeficientePorc6 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraCoeficiente10 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraCoeficiente9 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraCoeficiente8 = new Infragistics.Win.Misc.UltraLabel();
            this.uneCoeficiente10 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneCoeficiente9 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneCoeficiente8 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.labelSimboloMonedaCoeficiente7 = new System.Windows.Forms.Label();
            this.labelSimboloMonedaCoeficiente6 = new System.Windows.Forms.Label();
            this.uneCoeficiente7 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneCoeficiente6 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.labelPorc6 = new System.Windows.Forms.Label();
            this.ultraCoeficiente7 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraCoeficiente6 = new Infragistics.Win.Misc.UltraLabel();
            this.labelPorc7 = new System.Windows.Forms.Label();
            this.labelSimboloMonedaCoeficiente5 = new System.Windows.Forms.Label();
            this.labelSimboloMonedaCoeficiente4 = new System.Windows.Forms.Label();
            this.labelSimboloMonedaCoeficiente3 = new System.Windows.Forms.Label();
            this.labelPorc5 = new System.Windows.Forms.Label();
            this.labelPorc4 = new System.Windows.Forms.Label();
            this.labelPorc3 = new System.Windows.Forms.Label();
            this.uneCoeficientePorc5 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneCoeficientePorc4 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneCoeficientePorc3 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneCoeficientePorc2 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraCoeficiente5 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraCoeficiente4 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraCoeficiente3 = new Infragistics.Win.Misc.UltraLabel();
            this.uneCoeficiente5 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneCoeficiente4 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneCoeficiente3 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.labelSimboloMonedaPrecioDeCosto6 = new System.Windows.Forms.Label();
            this.labelSimboloMonedaCoeficiente2 = new System.Windows.Forms.Label();
            this.labelSimboloMonedaCoeficiente1 = new System.Windows.Forms.Label();
            this.uneCoeficienteTotal = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneCoeficiente2 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraLabel9 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraCoeficiente2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraCoeficiente1 = new Infragistics.Win.Misc.UltraLabel();
            this.labelPorc2 = new System.Windows.Forms.Label();
            this.chkCoef1 = new System.Windows.Forms.CheckBox();
            this.uneCoeficientePorc1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneCoeficiente1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.labelPorc1 = new System.Windows.Forms.Label();
            this.containerDatosVenta = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.groupNuevoCosto = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkUsaPrecioDeCostoReposicion1 = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.labelSimboloMonedaPrecioDeCostoReposicion1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.unePrecioDeCostoReposicion1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
            this.labelSimboloMonedaPrecioDeCosto1 = new System.Windows.Forms.Label();
            this.unePCostoPromedioPonderado1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.unePrecioDeListaConImpuestoMonedaReferencia = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
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
            this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferenciaLP = new System.Windows.Forms.Label();
            this.labelSimboloMonedaPrecioDeListaConImpuestosLP = new System.Windows.Forms.Label();
            this.labelSimboloMonedaPrecioDeListaLP = new System.Windows.Forms.Label();
            this.labelSimboloMonedaDescuentoMaximoLP = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.unePrecioFinalMonedaReferenciaLP = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label31 = new System.Windows.Forms.Label();
            this.unePrecioDeListaConImpuestoLP = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.unePrecioVentaBrutoLP = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label34 = new System.Windows.Forms.Label();
            this.uneMaxDescuentoLP = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label35 = new System.Windows.Forms.Label();
            this.uneMaxDescuentoPorcentualLP = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.btnRestablecerAGral = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.uneCoeficienteMonedaReferencia = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneCoeficiente = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelSimboloMonedaPrecioDeCostoReferenciaLP = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.unePrecioDeCostoRefLP = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label23 = new System.Windows.Forms.Label();
            this.unePrecioDeVentaNetoLP = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.labelSimboloMonedaPrecioDeVentaNetoLP = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.uneMACLP = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.gridManagerView2 = new mz.erp.ui.controls.GridManagerView();
            this.gridListaDePrecios = new Janus.Windows.GridEX.GridEX();
            this.imglStandar = new System.Windows.Forms.ImageList(this.components);
            this.toolBarStandar = new System.Windows.Forms.ToolBar();
            this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
            this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
            this.ultraExplorerBar = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.ultraExplorerBarContainerControl2.SuspendLayout();
            this.containerProductos.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupPorProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.groupPorJerarquia.SuspendLayout();
            this.ultraExplorerBarContainerControl1.SuspendLayout();
            this.groupListasDePrecios.SuspendLayout();
            this.gbReferencias.SuspendLayout();
            this.gbAplicaDescuento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEFuentesDeCambio)).BeginInit();
            this.gbAplicaCosto.SuspendLayout();
            this.gbAplicaCostoAfectaPCRTodos.SuspendLayout();
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
            this.ultraExplorerBarContainerControl4.SuspendLayout();
            this.groupMZ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoReposicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePCostoPromedioPonderado)).BeginInit();
            this.panelCostosIndirectos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficiente10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficiente9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficiente8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficiente7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficiente6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficiente5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficiente4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficiente3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficienteTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficiente2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficiente1)).BeginInit();
            this.containerDatosVenta.SuspendLayout();
            this.groupNuevoCosto.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoReposicion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePCostoPromedioPonderado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeListaConImpuestoMonedaReferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeListaConImpuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioVentaBruto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuentoPorcentual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeVentaNeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoRef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMAC)).BeginInit();
            this.ultraExplorerBarContainerControl3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioFinalMonedaReferenciaLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeListaConImpuestoLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioVentaBrutoLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuentoLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuentoPorcentualLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficienteMonedaReferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficiente)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoRefLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeVentaNetoLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMACLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaDePrecios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar)).BeginInit();
            this.ultraExplorerBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraExplorerBarContainerControl2
            // 
            this.ultraExplorerBarContainerControl2.Controls.Add(this.labelTarea);
            this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 24);
            this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
            this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(954, 30);
            this.ultraExplorerBarContainerControl2.TabIndex = 2;
            // 
            // labelTarea
            // 
            this.labelTarea.BackColor = System.Drawing.Color.Transparent;
            this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarea.Location = new System.Drawing.Point(0, 0);
            this.labelTarea.Name = "labelTarea";
            this.labelTarea.Size = new System.Drawing.Size(954, 23);
            this.labelTarea.TabIndex = 1;
            this.labelTarea.Text = "Tarea";
            this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // containerProductos
            // 
            this.containerProductos.Controls.Add(this.groupBox4);
            this.containerProductos.Controls.Add(this.groupPorProducto);
            this.containerProductos.Controls.Add(this.groupPorJerarquia);
            this.containerProductos.Controls.Add(this.groupRB);
            this.containerProductos.Location = new System.Drawing.Point(28, 113);
            this.containerProductos.Name = "containerProductos";
            this.containerProductos.Size = new System.Drawing.Size(954, 235);
            this.containerProductos.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.rbPorJerarquia);
            this.groupBox4.Controls.Add(this.rbPorProducto);
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(952, 32);
            this.groupBox4.TabIndex = 83;
            this.groupBox4.TabStop = false;
            // 
            // rbPorJerarquia
            // 
            this.rbPorJerarquia.Location = new System.Drawing.Point(193, 10);
            this.rbPorJerarquia.Name = "rbPorJerarquia";
            this.rbPorJerarquia.Size = new System.Drawing.Size(176, 20);
            this.rbPorJerarquia.TabIndex = 1;
            this.rbPorJerarquia.Text = "Por Jerarquías";
            // 
            // rbPorProducto
            // 
            this.rbPorProducto.Location = new System.Drawing.Point(8, 10);
            this.rbPorProducto.Name = "rbPorProducto";
            this.rbPorProducto.Size = new System.Drawing.Size(176, 20);
            this.rbPorProducto.TabIndex = 0;
            this.rbPorProducto.Text = "Por Productos";
            // 
            // groupPorProducto
            // 
            this.groupPorProducto.BackColor = System.Drawing.Color.Transparent;
            this.groupPorProducto.Controls.Add(this.gridProductos);
            this.groupPorProducto.Controls.Add(this.mzProductosControl);
            this.groupPorProducto.Controls.Add(this.label9);
            this.groupPorProducto.Location = new System.Drawing.Point(0, 24);
            this.groupPorProducto.Name = "groupPorProducto";
            this.groupPorProducto.Size = new System.Drawing.Size(952, 216);
            this.groupPorProducto.TabIndex = 81;
            this.groupPorProducto.TabStop = false;
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
            this.gridProductos.Location = new System.Drawing.Point(3, 53);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(946, 160);
            this.gridProductos.TabIndex = 3;
            this.gridProductos.TabStop = false;
            // 
            // mzProductosControl
            // 
            this.mzProductosControl.BackColor = System.Drawing.Color.Transparent;
            this.mzProductosControl.EnabledCantidad = false;
            this.mzProductosControl.EnabledListaDePrecio = true;
            this.mzProductosControl.Location = new System.Drawing.Point(80, 1);
            this.mzProductosControl.Name = "mzProductosControl";
            this.mzProductosControl.PermiteProductosCombo = false;
            this.mzProductosControl.Size = new System.Drawing.Size(608, 48);
            this.mzProductosControl.TabIndex = 2;
            this.mzProductosControl.VisibleCantidad = true;
            this.mzProductosControl.VisibleComboListaDePrecios = true;
            this.mzProductosControl.VisibleComboTipoDePrecioDeCosto = false;
            this.mzProductosControl.VisiblePrecios = true;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(9, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 75;
            this.label9.Text = "Producto";
            // 
            // groupPorJerarquia
            // 
            this.groupPorJerarquia.BackColor = System.Drawing.Color.Transparent;
            this.groupPorJerarquia.Controls.Add(this.hierarchicalSearchControl1);
            this.groupPorJerarquia.Location = new System.Drawing.Point(0, 24);
            this.groupPorJerarquia.Name = "groupPorJerarquia";
            this.groupPorJerarquia.Size = new System.Drawing.Size(960, 208);
            this.groupPorJerarquia.TabIndex = 82;
            this.groupPorJerarquia.TabStop = false;
            // 
            // hierarchicalSearchControl1
            // 
            this.hierarchicalSearchControl1.BackColor = System.Drawing.Color.Transparent;
            this.hierarchicalSearchControl1.Location = new System.Drawing.Point(8, 8);
            this.hierarchicalSearchControl1.Name = "hierarchicalSearchControl1";
            this.hierarchicalSearchControl1.Size = new System.Drawing.Size(840, 144);
            this.hierarchicalSearchControl1.TabIndex = 55;
            // 
            // groupRB
            // 
            this.groupRB.BackColor = System.Drawing.Color.Transparent;
            this.groupRB.Location = new System.Drawing.Point(-17, -43);
            this.groupRB.Name = "groupRB";
            this.groupRB.Size = new System.Drawing.Size(920, 43);
            this.groupRB.TabIndex = 80;
            this.groupRB.TabStop = false;
            // 
            // ultraExplorerBarContainerControl1
            // 
            this.ultraExplorerBarContainerControl1.Controls.Add(this.groupListasDePrecios);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.gbReferencias);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.chkMaximoDescuentoPorcentual);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.gbAplicaDescuento);
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
            this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 407);
            this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(954, 301);
            this.ultraExplorerBarContainerControl1.TabIndex = 5;
            // 
            // groupListasDePrecios
            // 
            this.groupListasDePrecios.BackColor = System.Drawing.Color.Transparent;
            this.groupListasDePrecios.Controls.Add(this.btnTodos);
            this.groupListasDePrecios.Controls.Add(this.btnInvertir);
            this.groupListasDePrecios.Controls.Add(this.btnNinguno);
            this.groupListasDePrecios.Controls.Add(this.chkListasDePrecios);
            this.groupListasDePrecios.Controls.Add(this.btnVerSeleccionados);
            this.groupListasDePrecios.Controls.Add(this.btnVerTodas);
            this.groupListasDePrecios.Location = new System.Drawing.Point(720, 104);
            this.groupListasDePrecios.Name = "groupListasDePrecios";
            this.groupListasDePrecios.Size = new System.Drawing.Size(240, 144);
            this.groupListasDePrecios.TabIndex = 1822;
            this.groupListasDePrecios.TabStop = false;
            this.groupListasDePrecios.Text = "Listas de Precios";
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(8, 112);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(16, 24);
            this.btnTodos.TabIndex = 125;
            this.btnTodos.Text = "T";
            // 
            // btnInvertir
            // 
            this.btnInvertir.Location = new System.Drawing.Point(40, 112);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new System.Drawing.Size(16, 24);
            this.btnInvertir.TabIndex = 126;
            this.btnInvertir.Text = "I";
            // 
            // btnNinguno
            // 
            this.btnNinguno.Location = new System.Drawing.Point(24, 112);
            this.btnNinguno.Name = "btnNinguno";
            this.btnNinguno.Size = new System.Drawing.Size(16, 24);
            this.btnNinguno.TabIndex = 127;
            this.btnNinguno.Text = "N";
            // 
            // chkListasDePrecios
            // 
            this.chkListasDePrecios.Location = new System.Drawing.Point(8, 16);
            this.chkListasDePrecios.Name = "chkListasDePrecios";
            this.chkListasDePrecios.Size = new System.Drawing.Size(216, 94);
            this.chkListasDePrecios.TabIndex = 114;
            // 
            // btnVerSeleccionados
            // 
            this.btnVerSeleccionados.Location = new System.Drawing.Point(56, 112);
            this.btnVerSeleccionados.Name = "btnVerSeleccionados";
            this.btnVerSeleccionados.Size = new System.Drawing.Size(112, 24);
            this.btnVerSeleccionados.TabIndex = 128;
            this.btnVerSeleccionados.Text = "Ver Seleccionadas";
            // 
            // btnVerTodas
            // 
            this.btnVerTodas.Location = new System.Drawing.Point(168, 112);
            this.btnVerTodas.Name = "btnVerTodas";
            this.btnVerTodas.Size = new System.Drawing.Size(72, 24);
            this.btnVerTodas.TabIndex = 129;
            this.btnVerTodas.Text = "Ver Todas";
            // 
            // gbReferencias
            // 
            this.gbReferencias.BackColor = System.Drawing.Color.Transparent;
            this.gbReferencias.Controls.Add(this.ultraLabel4);
            this.gbReferencias.Controls.Add(this.ultraLabel3);
            this.gbReferencias.Controls.Add(this.ultraLabel2);
            this.gbReferencias.Controls.Add(this.ultraLabel1);
            this.gbReferencias.Location = new System.Drawing.Point(720, 8);
            this.gbReferencias.Name = "gbReferencias";
            this.gbReferencias.Size = new System.Drawing.Size(240, 96);
            this.gbReferencias.TabIndex = 1821;
            this.gbReferencias.TabStop = false;
            this.gbReferencias.Text = "Referencias";
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel4.Location = new System.Drawing.Point(8, 72);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(216, 15);
            this.ultraLabel4.TabIndex = 158;
            this.ultraLabel4.Text = "MAC = Margen / Pcio. de Costo Neto";
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel3.Location = new System.Drawing.Point(8, 56);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(216, 15);
            this.ultraLabel3.TabIndex = 157;
            this.ultraLabel3.Text = "PVB c/ Imp. = Pcio. de Vta. Bruto c/ Imp.";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel2.Location = new System.Drawing.Point(8, 40);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(216, 15);
            this.ultraLabel2.TabIndex = 156;
            this.ultraLabel2.Text = "PVN = Pcio. de Vta. Neto";
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel1.Location = new System.Drawing.Point(8, 24);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(216, 15);
            this.ultraLabel1.TabIndex = 155;
            this.ultraLabel1.Text = "PVB = Pcio. de Vta. Bruto (Pcio. de Lista)";
            // 
            // chkMaximoDescuentoPorcentual
            // 
            this.chkMaximoDescuentoPorcentual.BackColor = System.Drawing.Color.Transparent;
            this.chkMaximoDescuentoPorcentual.Location = new System.Drawing.Point(240, 176);
            this.chkMaximoDescuentoPorcentual.Name = "chkMaximoDescuentoPorcentual";
            this.chkMaximoDescuentoPorcentual.Size = new System.Drawing.Size(107, 24);
            this.chkMaximoDescuentoPorcentual.TabIndex = 29;
            this.chkMaximoDescuentoPorcentual.Text = "% Descuento";
            this.chkMaximoDescuentoPorcentual.UseVisualStyleBackColor = false;
            // 
            // gbAplicaDescuento
            // 
            this.gbAplicaDescuento.BackColor = System.Drawing.Color.Transparent;
            this.gbAplicaDescuento.Controls.Add(this.rbDescuentoAfectaPVP);
            this.gbAplicaDescuento.Controls.Add(this.rbDescuentoAfectaMac);
            this.gbAplicaDescuento.Location = new System.Drawing.Point(232, 176);
            this.gbAplicaDescuento.Name = "gbAplicaDescuento";
            this.gbAplicaDescuento.Size = new System.Drawing.Size(232, 64);
            this.gbAplicaDescuento.TabIndex = 76;
            this.gbAplicaDescuento.TabStop = false;
            // 
            // rbDescuentoAfectaPVP
            // 
            this.rbDescuentoAfectaPVP.BackColor = System.Drawing.Color.Transparent;
            this.rbDescuentoAfectaPVP.Location = new System.Drawing.Point(16, 40);
            this.rbDescuentoAfectaPVP.Name = "rbDescuentoAfectaPVP";
            this.rbDescuentoAfectaPVP.Size = new System.Drawing.Size(144, 24);
            this.rbDescuentoAfectaPVP.TabIndex = 31;
            this.rbDescuentoAfectaPVP.Text = "Aplica sobre PVN";
            this.rbDescuentoAfectaPVP.UseVisualStyleBackColor = false;
            // 
            // rbDescuentoAfectaMac
            // 
            this.rbDescuentoAfectaMac.BackColor = System.Drawing.Color.Transparent;
            this.rbDescuentoAfectaMac.Location = new System.Drawing.Point(16, 22);
            this.rbDescuentoAfectaMac.Name = "rbDescuentoAfectaMac";
            this.rbDescuentoAfectaMac.Size = new System.Drawing.Size(136, 24);
            this.rbDescuentoAfectaMac.TabIndex = 30;
            this.rbDescuentoAfectaMac.Text = "Aplica sobre MAC";
            this.rbDescuentoAfectaMac.UseVisualStyleBackColor = false;
            // 
            // chkPrecioDeVentaBruto
            // 
            this.chkPrecioDeVentaBruto.BackColor = System.Drawing.Color.Transparent;
            this.chkPrecioDeVentaBruto.Location = new System.Drawing.Point(480, 0);
            this.chkPrecioDeVentaBruto.Name = "chkPrecioDeVentaBruto";
            this.chkPrecioDeVentaBruto.Size = new System.Drawing.Size(107, 24);
            this.chkPrecioDeVentaBruto.TabIndex = 10;
            this.chkPrecioDeVentaBruto.Text = "Precio de Venta";
            this.chkPrecioDeVentaBruto.UseVisualStyleBackColor = false;
            // 
            // chkMAC
            // 
            this.chkMAC.BackColor = System.Drawing.Color.Transparent;
            this.chkMAC.Location = new System.Drawing.Point(240, 0);
            this.chkMAC.Name = "chkMAC";
            this.chkMAC.Size = new System.Drawing.Size(107, 24);
            this.chkMAC.TabIndex = 21;
            this.chkMAC.Text = "MAC";
            this.chkMAC.UseVisualStyleBackColor = false;
            // 
            // mzCEFuentesDeCambio
            // 
            this.mzCEFuentesDeCambio.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEFuentesDeCambio.DisplayMember = "";
            this.mzCEFuentesDeCambio.DisplayMemberCaption = "";
            this.mzCEFuentesDeCambio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEFuentesDeCambio.Location = new System.Drawing.Point(104, 272);
            this.mzCEFuentesDeCambio.MaxItemsDisplay = 8;
            this.mzCEFuentesDeCambio.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEFuentesDeCambio.Name = "mzCEFuentesDeCambio";
            this.mzCEFuentesDeCambio.Size = new System.Drawing.Size(100, 21);
            this.mzCEFuentesDeCambio.SorterMember = "";
            this.mzCEFuentesDeCambio.TabIndex = 35;
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
            this.chkPrecioDeCosto.TabIndex = 0;
            this.chkPrecioDeCosto.Text = "P. De Costo";
            this.chkPrecioDeCosto.UseVisualStyleBackColor = false;
            // 
            // gbAplicaCosto
            // 
            this.gbAplicaCosto.BackColor = System.Drawing.Color.Transparent;
            this.gbAplicaCosto.Controls.Add(this.gbAplicaCostoAfectaPCRTodos);
            this.gbAplicaCosto.Controls.Add(this.chkAplicaCostoAfectaPVP);
            this.gbAplicaCosto.Controls.Add(this.gbAfectaCostoAfectaPVP);
            this.gbAplicaCosto.Location = new System.Drawing.Point(0, 6);
            this.gbAplicaCosto.Name = "gbAplicaCosto";
            this.gbAplicaCosto.Size = new System.Drawing.Size(224, 234);
            this.gbAplicaCosto.TabIndex = 70;
            this.gbAplicaCosto.TabStop = false;
            // 
            // gbAplicaCostoAfectaPCRTodos
            // 
            this.gbAplicaCostoAfectaPCRTodos.Controls.Add(this.rbAplicaCostoAfectaPCRTodos);
            this.gbAplicaCostoAfectaPCRTodos.Controls.Add(this.rbAplicaCostoAfectaPCRTodosUsaPcioCtoReposicion);
            this.gbAplicaCostoAfectaPCRTodos.Location = new System.Drawing.Point(8, 16);
            this.gbAplicaCostoAfectaPCRTodos.Name = "gbAplicaCostoAfectaPCRTodos";
            this.gbAplicaCostoAfectaPCRTodos.Size = new System.Drawing.Size(192, 56);
            this.gbAplicaCostoAfectaPCRTodos.TabIndex = 32;
            this.gbAplicaCostoAfectaPCRTodos.TabStop = false;
            // 
            // rbAplicaCostoAfectaPCRTodos
            // 
            this.rbAplicaCostoAfectaPCRTodos.BackColor = System.Drawing.Color.Transparent;
            this.rbAplicaCostoAfectaPCRTodos.Location = new System.Drawing.Point(24, 15);
            this.rbAplicaCostoAfectaPCRTodos.Name = "rbAplicaCostoAfectaPCRTodos";
            this.rbAplicaCostoAfectaPCRTodos.Size = new System.Drawing.Size(136, 24);
            this.rbAplicaCostoAfectaPCRTodos.TabIndex = 1;
            this.rbAplicaCostoAfectaPCRTodos.Text = "Aplicar a Todos";
            this.rbAplicaCostoAfectaPCRTodos.UseVisualStyleBackColor = false;
            // 
            // rbAplicaCostoAfectaPCRTodosUsaPcioCtoReposicion
            // 
            this.rbAplicaCostoAfectaPCRTodosUsaPcioCtoReposicion.BackColor = System.Drawing.Color.Transparent;
            this.rbAplicaCostoAfectaPCRTodosUsaPcioCtoReposicion.Location = new System.Drawing.Point(24, 34);
            this.rbAplicaCostoAfectaPCRTodosUsaPcioCtoReposicion.Name = "rbAplicaCostoAfectaPCRTodosUsaPcioCtoReposicion";
            this.rbAplicaCostoAfectaPCRTodosUsaPcioCtoReposicion.Size = new System.Drawing.Size(144, 24);
            this.rbAplicaCostoAfectaPCRTodosUsaPcioCtoReposicion.TabIndex = 2;
            this.rbAplicaCostoAfectaPCRTodosUsaPcioCtoReposicion.Text = "Sólo c/ costo reposición";
            this.rbAplicaCostoAfectaPCRTodosUsaPcioCtoReposicion.UseVisualStyleBackColor = false;
            // 
            // chkAplicaCostoAfectaPVP
            // 
            this.chkAplicaCostoAfectaPVP.BackColor = System.Drawing.Color.Transparent;
            this.chkAplicaCostoAfectaPVP.Location = new System.Drawing.Point(14, 72);
            this.chkAplicaCostoAfectaPVP.Name = "chkAplicaCostoAfectaPVP";
            this.chkAplicaCostoAfectaPVP.Size = new System.Drawing.Size(128, 24);
            this.chkAplicaCostoAfectaPVP.TabIndex = 3;
            this.chkAplicaCostoAfectaPVP.Text = "Afecta PVB";
            this.chkAplicaCostoAfectaPVP.UseVisualStyleBackColor = false;
            // 
            // gbAfectaCostoAfectaPVP
            // 
            this.gbAfectaCostoAfectaPVP.Controls.Add(this.rbAplicaCostoAfectaPVPCondicional);
            this.gbAfectaCostoAfectaPVP.Controls.Add(this.gbAplicaCostoAfectaPVPCondicional);
            this.gbAfectaCostoAfectaPVP.Controls.Add(this.rbAplicaCostoAfectaPVPTodos);
            this.gbAfectaCostoAfectaPVP.Controls.Add(this.gbAplicaCostoAfectaPVPTodos);
            this.gbAfectaCostoAfectaPVP.Location = new System.Drawing.Point(8, 80);
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
            this.rbAplicaCostoAfectaPVPCondicional.TabIndex = 7;
            this.rbAplicaCostoAfectaPVPCondicional.Text = "Aplicar SI PVB < Nuevo PVN";
            this.rbAplicaCostoAfectaPVPCondicional.UseVisualStyleBackColor = false;
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
            this.rbAplicaCostoAfectaPVPCondicionalTrasladaIncremento.TabIndex = 8;
            this.rbAplicaCostoAfectaPVPCondicionalTrasladaIncremento.Text = "Traslada Incremento";
            this.rbAplicaCostoAfectaPVPCondicionalTrasladaIncremento.UseVisualStyleBackColor = false;
            // 
            // rbAplicaCostoAfectaPVPCondicionalIgualPVS
            // 
            this.rbAplicaCostoAfectaPVPCondicionalIgualPVS.BackColor = System.Drawing.Color.Transparent;
            this.rbAplicaCostoAfectaPVPCondicionalIgualPVS.Location = new System.Drawing.Point(24, 34);
            this.rbAplicaCostoAfectaPVPCondicionalIgualPVS.Name = "rbAplicaCostoAfectaPVPCondicionalIgualPVS";
            this.rbAplicaCostoAfectaPVPCondicionalIgualPVS.Size = new System.Drawing.Size(136, 24);
            this.rbAplicaCostoAfectaPVPCondicionalIgualPVS.TabIndex = 9;
            this.rbAplicaCostoAfectaPVPCondicionalIgualPVS.Text = "= Nuevo PVN";
            this.rbAplicaCostoAfectaPVPCondicionalIgualPVS.UseVisualStyleBackColor = false;
            // 
            // rbAplicaCostoAfectaPVPTodos
            // 
            this.rbAplicaCostoAfectaPVPTodos.BackColor = System.Drawing.Color.Transparent;
            this.rbAplicaCostoAfectaPVPTodos.Location = new System.Drawing.Point(20, 11);
            this.rbAplicaCostoAfectaPVPTodos.Name = "rbAplicaCostoAfectaPVPTodos";
            this.rbAplicaCostoAfectaPVPTodos.Size = new System.Drawing.Size(103, 24);
            this.rbAplicaCostoAfectaPVPTodos.TabIndex = 4;
            this.rbAplicaCostoAfectaPVPTodos.Text = "Aplicar a Todos";
            this.rbAplicaCostoAfectaPVPTodos.UseVisualStyleBackColor = false;
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
            this.rbAplicaCostoAfectaPVPTodosTrasladaIncremento.TabIndex = 5;
            this.rbAplicaCostoAfectaPVPTodosTrasladaIncremento.Text = "Traslada Incremento";
            this.rbAplicaCostoAfectaPVPTodosTrasladaIncremento.UseVisualStyleBackColor = false;
            // 
            // rbAplicaCostoAfectaPVPTodosIgualPVS
            // 
            this.rbAplicaCostoAfectaPVPTodosIgualPVS.BackColor = System.Drawing.Color.Transparent;
            this.rbAplicaCostoAfectaPVPTodosIgualPVS.Location = new System.Drawing.Point(24, 34);
            this.rbAplicaCostoAfectaPVPTodosIgualPVS.Name = "rbAplicaCostoAfectaPVPTodosIgualPVS";
            this.rbAplicaCostoAfectaPVPTodosIgualPVS.Size = new System.Drawing.Size(136, 24);
            this.rbAplicaCostoAfectaPVPTodosIgualPVS.TabIndex = 6;
            this.rbAplicaCostoAfectaPVPTodosIgualPVS.Text = "= Nuevo PVN";
            this.rbAplicaCostoAfectaPVPTodosIgualPVS.UseVisualStyleBackColor = false;
            // 
            // mzCEMonedas
            // 
            this.mzCEMonedas.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEMonedas.DisplayMember = "";
            this.mzCEMonedas.DisplayMemberCaption = "";
            this.mzCEMonedas.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEMonedas.Location = new System.Drawing.Point(104, 248);
            this.mzCEMonedas.MaxItemsDisplay = 8;
            this.mzCEMonedas.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEMonedas.Name = "mzCEMonedas";
            this.mzCEMonedas.Size = new System.Drawing.Size(100, 21);
            this.mzCEMonedas.SorterMember = "";
            this.mzCEMonedas.TabIndex = 34;
            this.mzCEMonedas.TabStop = false;
            this.mzCEMonedas.ValueMember = "";
            this.mzCEMonedas.ValueMemberCaption = "";
            // 
            // utbDeshacer
            // 
            this.utbDeshacer.Location = new System.Drawing.Point(336, 272);
            this.utbDeshacer.Name = "utbDeshacer";
            this.utbDeshacer.Size = new System.Drawing.Size(104, 23);
            this.utbDeshacer.TabIndex = 39;
            this.utbDeshacer.Text = "Deshacer";
            // 
            // utbActualizarPrecios
            // 
            this.utbActualizarPrecios.Location = new System.Drawing.Point(336, 248);
            this.utbActualizarPrecios.Name = "utbActualizarPrecios";
            this.utbActualizarPrecios.Size = new System.Drawing.Size(104, 23);
            this.utbActualizarPrecios.TabIndex = 38;
            this.utbActualizarPrecios.Text = "Actualizar Precios";
            // 
            // uneValorConstante
            // 
            this.uneValorConstante.Enabled = false;
            this.uneValorConstante.Location = new System.Drawing.Point(0, 272);
            this.uneValorConstante.MaskInput = "-nnnnnnnnn.nn";
            this.uneValorConstante.Name = "uneValorConstante";
            this.uneValorConstante.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneValorConstante.Size = new System.Drawing.Size(100, 21);
            this.uneValorConstante.TabIndex = 33;
            this.uneValorConstante.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // unePorcentaje
            // 
            this.unePorcentaje.Enabled = false;
            this.unePorcentaje.Location = new System.Drawing.Point(216, 272);
            this.unePorcentaje.MaskInput = "-nnnnnnnn.nn";
            this.unePorcentaje.Name = "unePorcentaje";
            this.unePorcentaje.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePorcentaje.Size = new System.Drawing.Size(100, 21);
            this.unePorcentaje.TabIndex = 37;
            this.unePorcentaje.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // chkProcentaje
            // 
            this.chkProcentaje.BackColor = System.Drawing.Color.Transparent;
            this.chkProcentaje.Location = new System.Drawing.Point(216, 248);
            this.chkProcentaje.Name = "chkProcentaje";
            this.chkProcentaje.Size = new System.Drawing.Size(104, 24);
            this.chkProcentaje.TabIndex = 36;
            this.chkProcentaje.Text = "Procentaje";
            this.chkProcentaje.UseVisualStyleBackColor = false;
            // 
            // chkValorConstante
            // 
            this.chkValorConstante.BackColor = System.Drawing.Color.Transparent;
            this.chkValorConstante.Location = new System.Drawing.Point(0, 248);
            this.chkValorConstante.Name = "chkValorConstante";
            this.chkValorConstante.Size = new System.Drawing.Size(104, 24);
            this.chkValorConstante.TabIndex = 32;
            this.chkValorConstante.Text = "Valor Constante";
            this.chkValorConstante.UseVisualStyleBackColor = false;
            // 
            // gbAplicaPrecioDeVenta
            // 
            this.gbAplicaPrecioDeVenta.BackColor = System.Drawing.Color.Transparent;
            this.gbAplicaPrecioDeVenta.Controls.Add(this.rbAplicaPVPConImpuestos);
            this.gbAplicaPrecioDeVenta.Controls.Add(this.chkAplicaPVSAfectaPVP);
            this.gbAplicaPrecioDeVenta.Controls.Add(this.gbAplicaPrecioVentaAfectaPVP);
            this.gbAplicaPrecioDeVenta.Controls.Add(this.rbAplicaPVP);
            this.gbAplicaPrecioDeVenta.Controls.Add(this.rbAplicaPVS);
            this.gbAplicaPrecioDeVenta.Location = new System.Drawing.Point(472, 6);
            this.gbAplicaPrecioDeVenta.Name = "gbAplicaPrecioDeVenta";
            this.gbAplicaPrecioDeVenta.Size = new System.Drawing.Size(240, 234);
            this.gbAplicaPrecioDeVenta.TabIndex = 71;
            this.gbAplicaPrecioDeVenta.TabStop = false;
            // 
            // rbAplicaPVPConImpuestos
            // 
            this.rbAplicaPVPConImpuestos.BackColor = System.Drawing.Color.Transparent;
            this.rbAplicaPVPConImpuestos.Location = new System.Drawing.Point(8, 210);
            this.rbAplicaPVPConImpuestos.Name = "rbAplicaPVPConImpuestos";
            this.rbAplicaPVPConImpuestos.Size = new System.Drawing.Size(208, 24);
            this.rbAplicaPVPConImpuestos.TabIndex = 20;
            this.rbAplicaPVPConImpuestos.Text = "Aplica sobre PVB c/  Imp.";
            this.rbAplicaPVPConImpuestos.UseVisualStyleBackColor = false;
            // 
            // chkAplicaPVSAfectaPVP
            // 
            this.chkAplicaPVSAfectaPVP.BackColor = System.Drawing.Color.Transparent;
            this.chkAplicaPVSAfectaPVP.Location = new System.Drawing.Point(32, 36);
            this.chkAplicaPVSAfectaPVP.Name = "chkAplicaPVSAfectaPVP";
            this.chkAplicaPVSAfectaPVP.Size = new System.Drawing.Size(128, 24);
            this.chkAplicaPVSAfectaPVP.TabIndex = 12;
            this.chkAplicaPVSAfectaPVP.Text = "Afecta PVB";
            this.chkAplicaPVSAfectaPVP.UseVisualStyleBackColor = false;
            // 
            // gbAplicaPrecioVentaAfectaPVP
            // 
            this.gbAplicaPrecioVentaAfectaPVP.Controls.Add(this.rbAplicaPVSAfectaPVPCondicional);
            this.gbAplicaPrecioVentaAfectaPVP.Controls.Add(this.gbAplicaPVSAfectaPVPCondicional);
            this.gbAplicaPrecioVentaAfectaPVP.Controls.Add(this.rbAplicaPVSAfectaPVPTodos);
            this.gbAplicaPrecioVentaAfectaPVP.Controls.Add(this.gbAplicaPVSAfectaPVPTodos);
            this.gbAplicaPrecioVentaAfectaPVP.Location = new System.Drawing.Point(24, 42);
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
            this.rbAplicaPVSAfectaPVPCondicional.TabIndex = 16;
            this.rbAplicaPVSAfectaPVPCondicional.Text = "Aplicar SI PVB < Nuevo PVN";
            this.rbAplicaPVSAfectaPVPCondicional.UseVisualStyleBackColor = false;
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
            this.rbAplicaPVSAfectaPVPCondicionalTrasladaIncremento.TabIndex = 17;
            this.rbAplicaPVSAfectaPVPCondicionalTrasladaIncremento.Text = "Traslada Incremento";
            this.rbAplicaPVSAfectaPVPCondicionalTrasladaIncremento.UseVisualStyleBackColor = false;
            // 
            // rbAplicaPVSAfectaPVPCondicionalIgualPVS
            // 
            this.rbAplicaPVSAfectaPVPCondicionalIgualPVS.BackColor = System.Drawing.Color.Transparent;
            this.rbAplicaPVSAfectaPVPCondicionalIgualPVS.Location = new System.Drawing.Point(24, 34);
            this.rbAplicaPVSAfectaPVPCondicionalIgualPVS.Name = "rbAplicaPVSAfectaPVPCondicionalIgualPVS";
            this.rbAplicaPVSAfectaPVPCondicionalIgualPVS.Size = new System.Drawing.Size(136, 24);
            this.rbAplicaPVSAfectaPVPCondicionalIgualPVS.TabIndex = 18;
            this.rbAplicaPVSAfectaPVPCondicionalIgualPVS.Text = "= Nuevo PVN";
            this.rbAplicaPVSAfectaPVPCondicionalIgualPVS.UseVisualStyleBackColor = false;
            // 
            // rbAplicaPVSAfectaPVPTodos
            // 
            this.rbAplicaPVSAfectaPVPTodos.BackColor = System.Drawing.Color.Transparent;
            this.rbAplicaPVSAfectaPVPTodos.Location = new System.Drawing.Point(20, 12);
            this.rbAplicaPVSAfectaPVPTodos.Name = "rbAplicaPVSAfectaPVPTodos";
            this.rbAplicaPVSAfectaPVPTodos.Size = new System.Drawing.Size(103, 24);
            this.rbAplicaPVSAfectaPVPTodos.TabIndex = 13;
            this.rbAplicaPVSAfectaPVPTodos.Text = "Aplicar a Todos";
            this.rbAplicaPVSAfectaPVPTodos.UseVisualStyleBackColor = false;
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
            this.rbAplicaPVSAfectaPVPTodosTrasladaIncremento.TabIndex = 14;
            this.rbAplicaPVSAfectaPVPTodosTrasladaIncremento.Text = "Traslada Incremento";
            this.rbAplicaPVSAfectaPVPTodosTrasladaIncremento.UseVisualStyleBackColor = false;
            // 
            // rbAplicaPVSAfectaPVPTodosIgualPVS
            // 
            this.rbAplicaPVSAfectaPVPTodosIgualPVS.BackColor = System.Drawing.Color.Transparent;
            this.rbAplicaPVSAfectaPVPTodosIgualPVS.Location = new System.Drawing.Point(24, 34);
            this.rbAplicaPVSAfectaPVPTodosIgualPVS.Name = "rbAplicaPVSAfectaPVPTodosIgualPVS";
            this.rbAplicaPVSAfectaPVPTodosIgualPVS.Size = new System.Drawing.Size(136, 24);
            this.rbAplicaPVSAfectaPVPTodosIgualPVS.TabIndex = 15;
            this.rbAplicaPVSAfectaPVPTodosIgualPVS.Text = "= Nuevo PVN";
            this.rbAplicaPVSAfectaPVPTodosIgualPVS.UseVisualStyleBackColor = false;
            // 
            // rbAplicaPVP
            // 
            this.rbAplicaPVP.BackColor = System.Drawing.Color.Transparent;
            this.rbAplicaPVP.Location = new System.Drawing.Point(8, 187);
            this.rbAplicaPVP.Name = "rbAplicaPVP";
            this.rbAplicaPVP.Size = new System.Drawing.Size(184, 24);
            this.rbAplicaPVP.TabIndex = 19;
            this.rbAplicaPVP.Text = "Aplica sobre PVB";
            this.rbAplicaPVP.UseVisualStyleBackColor = false;
            // 
            // rbAplicaPVS
            // 
            this.rbAplicaPVS.BackColor = System.Drawing.Color.Transparent;
            this.rbAplicaPVS.Location = new System.Drawing.Point(8, 16);
            this.rbAplicaPVS.Name = "rbAplicaPVS";
            this.rbAplicaPVS.Size = new System.Drawing.Size(192, 24);
            this.rbAplicaPVS.TabIndex = 11;
            this.rbAplicaPVS.Text = "Aplica sobre PVN";
            this.rbAplicaPVS.UseVisualStyleBackColor = false;
            // 
            // gbAplicaMAC
            // 
            this.gbAplicaMAC.BackColor = System.Drawing.Color.Transparent;
            this.gbAplicaMAC.Controls.Add(this.chkAplicaMACAfectaPVP);
            this.gbAplicaMAC.Controls.Add(this.gbAplicaMACAfectaPVP);
            this.gbAplicaMAC.Location = new System.Drawing.Point(232, 6);
            this.gbAplicaMAC.Name = "gbAplicaMAC";
            this.gbAplicaMAC.Size = new System.Drawing.Size(232, 234);
            this.gbAplicaMAC.TabIndex = 73;
            this.gbAplicaMAC.TabStop = false;
            // 
            // chkAplicaMACAfectaPVP
            // 
            this.chkAplicaMACAfectaPVP.BackColor = System.Drawing.Color.Transparent;
            this.chkAplicaMACAfectaPVP.Location = new System.Drawing.Point(17, 25);
            this.chkAplicaMACAfectaPVP.Name = "chkAplicaMACAfectaPVP";
            this.chkAplicaMACAfectaPVP.Size = new System.Drawing.Size(128, 24);
            this.chkAplicaMACAfectaPVP.TabIndex = 22;
            this.chkAplicaMACAfectaPVP.Text = "Afecta PVB";
            this.chkAplicaMACAfectaPVP.UseVisualStyleBackColor = false;
            // 
            // gbAplicaMACAfectaPVP
            // 
            this.gbAplicaMACAfectaPVP.Controls.Add(this.rbAplicaMACAfectaPVPTodos);
            this.gbAplicaMACAfectaPVP.Controls.Add(this.rbAplicaMACAfectaPVPCondicional);
            this.gbAplicaMACAfectaPVP.Controls.Add(this.gbAplicaMACAfectaPVPCondicional);
            this.gbAplicaMACAfectaPVP.Controls.Add(this.gbAplicaMACAfectaPVPTodos);
            this.gbAplicaMACAfectaPVP.Location = new System.Drawing.Point(12, 16);
            this.gbAplicaMACAfectaPVP.Name = "gbAplicaMACAfectaPVP";
            this.gbAplicaMACAfectaPVP.Size = new System.Drawing.Size(208, 152);
            this.gbAplicaMACAfectaPVP.TabIndex = 33;
            this.gbAplicaMACAfectaPVP.TabStop = false;
            // 
            // rbAplicaMACAfectaPVPTodos
            // 
            this.rbAplicaMACAfectaPVPTodos.BackColor = System.Drawing.Color.Transparent;
            this.rbAplicaMACAfectaPVPTodos.Location = new System.Drawing.Point(20, 30);
            this.rbAplicaMACAfectaPVPTodos.Name = "rbAplicaMACAfectaPVPTodos";
            this.rbAplicaMACAfectaPVPTodos.Size = new System.Drawing.Size(103, 24);
            this.rbAplicaMACAfectaPVPTodos.TabIndex = 23;
            this.rbAplicaMACAfectaPVPTodos.Text = "Aplicar a Todos";
            this.rbAplicaMACAfectaPVPTodos.UseVisualStyleBackColor = false;
            // 
            // rbAplicaMACAfectaPVPCondicional
            // 
            this.rbAplicaMACAfectaPVPCondicional.BackColor = System.Drawing.Color.Transparent;
            this.rbAplicaMACAfectaPVPCondicional.Location = new System.Drawing.Point(20, 90);
            this.rbAplicaMACAfectaPVPCondicional.Name = "rbAplicaMACAfectaPVPCondicional";
            this.rbAplicaMACAfectaPVPCondicional.Size = new System.Drawing.Size(168, 24);
            this.rbAplicaMACAfectaPVPCondicional.TabIndex = 26;
            this.rbAplicaMACAfectaPVPCondicional.Text = "Aplicar SI PVB < Nuevo PVN";
            this.rbAplicaMACAfectaPVPCondicional.UseVisualStyleBackColor = false;
            // 
            // gbAplicaMACAfectaPVPCondicional
            // 
            this.gbAplicaMACAfectaPVPCondicional.Controls.Add(this.rbAplicaMACAfectaPVPCondicionalTrasladaIncremento);
            this.gbAplicaMACAfectaPVPCondicional.Controls.Add(this.rbAplicaMACAfectaPVPCondicionalIgualPVS);
            this.gbAplicaMACAfectaPVPCondicional.Location = new System.Drawing.Point(12, 94);
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
            this.rbAplicaMACAfectaPVPCondicionalTrasladaIncremento.UseVisualStyleBackColor = false;
            // 
            // rbAplicaMACAfectaPVPCondicionalIgualPVS
            // 
            this.rbAplicaMACAfectaPVPCondicionalIgualPVS.BackColor = System.Drawing.Color.Transparent;
            this.rbAplicaMACAfectaPVPCondicionalIgualPVS.Location = new System.Drawing.Point(24, 34);
            this.rbAplicaMACAfectaPVPCondicionalIgualPVS.Name = "rbAplicaMACAfectaPVPCondicionalIgualPVS";
            this.rbAplicaMACAfectaPVPCondicionalIgualPVS.Size = new System.Drawing.Size(136, 24);
            this.rbAplicaMACAfectaPVPCondicionalIgualPVS.TabIndex = 28;
            this.rbAplicaMACAfectaPVPCondicionalIgualPVS.Text = "= Nuevo PVN";
            this.rbAplicaMACAfectaPVPCondicionalIgualPVS.UseVisualStyleBackColor = false;
            // 
            // gbAplicaMACAfectaPVPTodos
            // 
            this.gbAplicaMACAfectaPVPTodos.Controls.Add(this.rbAplicaMACAfectaPVPTodosTrasladaIncremento);
            this.gbAplicaMACAfectaPVPTodos.Controls.Add(this.rbAplicaMACAfectaPVPTodosIgualPVS);
            this.gbAplicaMACAfectaPVPTodos.Location = new System.Drawing.Point(12, 34);
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
            this.rbAplicaMACAfectaPVPTodosTrasladaIncremento.TabIndex = 24;
            this.rbAplicaMACAfectaPVPTodosTrasladaIncremento.Text = "Traslada Incremento";
            this.rbAplicaMACAfectaPVPTodosTrasladaIncremento.UseVisualStyleBackColor = false;
            // 
            // rbAplicaMACAfectaPVPTodosIgualPVS
            // 
            this.rbAplicaMACAfectaPVPTodosIgualPVS.BackColor = System.Drawing.Color.Transparent;
            this.rbAplicaMACAfectaPVPTodosIgualPVS.Location = new System.Drawing.Point(24, 34);
            this.rbAplicaMACAfectaPVPTodosIgualPVS.Name = "rbAplicaMACAfectaPVPTodosIgualPVS";
            this.rbAplicaMACAfectaPVPTodosIgualPVS.Size = new System.Drawing.Size(136, 24);
            this.rbAplicaMACAfectaPVPTodosIgualPVS.TabIndex = 25;
            this.rbAplicaMACAfectaPVPTodosIgualPVS.Text = "= Nuevo PVN";
            this.rbAplicaMACAfectaPVPTodosIgualPVS.UseVisualStyleBackColor = false;
            // 
            // ultraExplorerBarContainerControl4
            // 
            this.ultraExplorerBarContainerControl4.Controls.Add(this.groupMZ);
            this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
            this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(954, 182);
            this.ultraExplorerBarContainerControl4.TabIndex = 7;
            this.ultraExplorerBarContainerControl4.Visible = false;
            // 
            // groupMZ
            // 
            this.groupMZ.BackColor = System.Drawing.Color.Transparent;
            this.groupMZ.Controls.Add(this.chkUsaPrecioDeCostoReposicion);
            this.groupMZ.Controls.Add(this.labelSimboloMonedaPrecioDeCostoReposicion);
            this.groupMZ.Controls.Add(this.label63);
            this.groupMZ.Controls.Add(this.unePrecioDeCostoReposicion);
            this.groupMZ.Controls.Add(this.ultraLabel12);
            this.groupMZ.Controls.Add(this.labelSimboloMonedaPrecioDeCosto);
            this.groupMZ.Controls.Add(this.unePCostoPromedioPonderado);
            this.groupMZ.Controls.Add(this.groupBox6);
            this.groupMZ.Controls.Add(this.panelCostosIndirectos);
            this.groupMZ.Location = new System.Drawing.Point(0, 7);
            this.groupMZ.Name = "groupMZ";
            this.groupMZ.Size = new System.Drawing.Size(815, 166);
            this.groupMZ.TabIndex = 23;
            this.groupMZ.TabStop = false;
            this.groupMZ.Text = "Nuevo Costo";
            // 
            // chkUsaPrecioDeCostoReposicion
            // 
            this.chkUsaPrecioDeCostoReposicion.BackColor = System.Drawing.Color.Transparent;
            this.chkUsaPrecioDeCostoReposicion.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkUsaPrecioDeCostoReposicion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkUsaPrecioDeCostoReposicion.Location = new System.Drawing.Point(16, 80);
            this.chkUsaPrecioDeCostoReposicion.Name = "chkUsaPrecioDeCostoReposicion";
            this.chkUsaPrecioDeCostoReposicion.Size = new System.Drawing.Size(244, 20);
            this.chkUsaPrecioDeCostoReposicion.TabIndex = 2;
            this.chkUsaPrecioDeCostoReposicion.Text = "Usa Precio de Costo Reposición";
            // 
            // labelSimboloMonedaPrecioDeCostoReposicion
            // 
            this.labelSimboloMonedaPrecioDeCostoReposicion.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeCostoReposicion.Location = new System.Drawing.Point(208, 64);
            this.labelSimboloMonedaPrecioDeCostoReposicion.Name = "labelSimboloMonedaPrecioDeCostoReposicion";
            this.labelSimboloMonedaPrecioDeCostoReposicion.Size = new System.Drawing.Size(32, 16);
            this.labelSimboloMonedaPrecioDeCostoReposicion.TabIndex = 158;
            this.labelSimboloMonedaPrecioDeCostoReposicion.Text = "$";
            this.labelSimboloMonedaPrecioDeCostoReposicion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label63
            // 
            this.label63.BackColor = System.Drawing.Color.Transparent;
            this.label63.Location = new System.Drawing.Point(16, 64);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(184, 16);
            this.label63.TabIndex = 157;
            this.label63.Text = "Precio de Costo de Reposición";
            // 
            // unePrecioDeCostoReposicion
            // 
            this.unePrecioDeCostoReposicion.Location = new System.Drawing.Point(248, 56);
            this.unePrecioDeCostoReposicion.MaskInput = "nnnnnnnn.nn";
            this.unePrecioDeCostoReposicion.Name = "unePrecioDeCostoReposicion";
            this.unePrecioDeCostoReposicion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioDeCostoReposicion.Size = new System.Drawing.Size(100, 21);
            this.unePrecioDeCostoReposicion.TabIndex = 1;
            this.unePrecioDeCostoReposicion.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraLabel12
            // 
            this.ultraLabel12.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel12.Location = new System.Drawing.Point(16, 40);
            this.ultraLabel12.Name = "ultraLabel12";
            this.ultraLabel12.Size = new System.Drawing.Size(195, 15);
            this.ultraLabel12.TabIndex = 154;
            this.ultraLabel12.Text = "Precio de Costo Promedio Ponderado";
            // 
            // labelSimboloMonedaPrecioDeCosto
            // 
            this.labelSimboloMonedaPrecioDeCosto.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeCosto.Location = new System.Drawing.Point(208, 40);
            this.labelSimboloMonedaPrecioDeCosto.Name = "labelSimboloMonedaPrecioDeCosto";
            this.labelSimboloMonedaPrecioDeCosto.Size = new System.Drawing.Size(32, 17);
            this.labelSimboloMonedaPrecioDeCosto.TabIndex = 155;
            this.labelSimboloMonedaPrecioDeCosto.Text = "$";
            this.labelSimboloMonedaPrecioDeCosto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unePCostoPromedioPonderado
            // 
            this.unePCostoPromedioPonderado.Location = new System.Drawing.Point(248, 40);
            this.unePCostoPromedioPonderado.Name = "unePCostoPromedioPonderado";
            this.unePCostoPromedioPonderado.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePCostoPromedioPonderado.PromptChar = ' ';
            this.unePCostoPromedioPonderado.Size = new System.Drawing.Size(100, 21);
            this.unePCostoPromedioPonderado.TabIndex = 0;
            this.unePCostoPromedioPonderado.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(8, 24);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(345, 79);
            this.groupBox6.TabIndex = 160;
            this.groupBox6.TabStop = false;
            // 
            // panelCostosIndirectos
            // 
            this.panelCostosIndirectos.Controls.Add(this.chkCoef10);
            this.panelCostosIndirectos.Controls.Add(this.chkCoef9);
            this.panelCostosIndirectos.Controls.Add(this.chkCoef8);
            this.panelCostosIndirectos.Controls.Add(this.chkCoef7);
            this.panelCostosIndirectos.Controls.Add(this.chkCoef6);
            this.panelCostosIndirectos.Controls.Add(this.chkCoef5);
            this.panelCostosIndirectos.Controls.Add(this.chkCoef4);
            this.panelCostosIndirectos.Controls.Add(this.chkCoef3);
            this.panelCostosIndirectos.Controls.Add(this.chkCoef2);
            this.panelCostosIndirectos.Controls.Add(this.labelSimboloMonedaCoeficiente10);
            this.panelCostosIndirectos.Controls.Add(this.labelSimboloMonedaCoeficiente9);
            this.panelCostosIndirectos.Controls.Add(this.labelSimboloMonedaCoeficiente8);
            this.panelCostosIndirectos.Controls.Add(this.labelPorc10);
            this.panelCostosIndirectos.Controls.Add(this.labelPorc9);
            this.panelCostosIndirectos.Controls.Add(this.labelPorc8);
            this.panelCostosIndirectos.Controls.Add(this.uneCoeficientePorc10);
            this.panelCostosIndirectos.Controls.Add(this.uneCoeficientePorc9);
            this.panelCostosIndirectos.Controls.Add(this.uneCoeficientePorc8);
            this.panelCostosIndirectos.Controls.Add(this.uneCoeficientePorc7);
            this.panelCostosIndirectos.Controls.Add(this.uneCoeficientePorc6);
            this.panelCostosIndirectos.Controls.Add(this.ultraCoeficiente10);
            this.panelCostosIndirectos.Controls.Add(this.ultraCoeficiente9);
            this.panelCostosIndirectos.Controls.Add(this.ultraCoeficiente8);
            this.panelCostosIndirectos.Controls.Add(this.uneCoeficiente10);
            this.panelCostosIndirectos.Controls.Add(this.uneCoeficiente9);
            this.panelCostosIndirectos.Controls.Add(this.uneCoeficiente8);
            this.panelCostosIndirectos.Controls.Add(this.labelSimboloMonedaCoeficiente7);
            this.panelCostosIndirectos.Controls.Add(this.labelSimboloMonedaCoeficiente6);
            this.panelCostosIndirectos.Controls.Add(this.uneCoeficiente7);
            this.panelCostosIndirectos.Controls.Add(this.uneCoeficiente6);
            this.panelCostosIndirectos.Controls.Add(this.labelPorc6);
            this.panelCostosIndirectos.Controls.Add(this.ultraCoeficiente7);
            this.panelCostosIndirectos.Controls.Add(this.ultraCoeficiente6);
            this.panelCostosIndirectos.Controls.Add(this.labelPorc7);
            this.panelCostosIndirectos.Controls.Add(this.labelSimboloMonedaCoeficiente5);
            this.panelCostosIndirectos.Controls.Add(this.labelSimboloMonedaCoeficiente4);
            this.panelCostosIndirectos.Controls.Add(this.labelSimboloMonedaCoeficiente3);
            this.panelCostosIndirectos.Controls.Add(this.labelPorc5);
            this.panelCostosIndirectos.Controls.Add(this.labelPorc4);
            this.panelCostosIndirectos.Controls.Add(this.labelPorc3);
            this.panelCostosIndirectos.Controls.Add(this.uneCoeficientePorc5);
            this.panelCostosIndirectos.Controls.Add(this.uneCoeficientePorc4);
            this.panelCostosIndirectos.Controls.Add(this.uneCoeficientePorc3);
            this.panelCostosIndirectos.Controls.Add(this.uneCoeficientePorc2);
            this.panelCostosIndirectos.Controls.Add(this.ultraCoeficiente5);
            this.panelCostosIndirectos.Controls.Add(this.ultraCoeficiente4);
            this.panelCostosIndirectos.Controls.Add(this.ultraCoeficiente3);
            this.panelCostosIndirectos.Controls.Add(this.uneCoeficiente5);
            this.panelCostosIndirectos.Controls.Add(this.uneCoeficiente4);
            this.panelCostosIndirectos.Controls.Add(this.uneCoeficiente3);
            this.panelCostosIndirectos.Controls.Add(this.labelSimboloMonedaPrecioDeCosto6);
            this.panelCostosIndirectos.Controls.Add(this.labelSimboloMonedaCoeficiente2);
            this.panelCostosIndirectos.Controls.Add(this.labelSimboloMonedaCoeficiente1);
            this.panelCostosIndirectos.Controls.Add(this.uneCoeficienteTotal);
            this.panelCostosIndirectos.Controls.Add(this.uneCoeficiente2);
            this.panelCostosIndirectos.Controls.Add(this.ultraLabel9);
            this.panelCostosIndirectos.Controls.Add(this.ultraCoeficiente2);
            this.panelCostosIndirectos.Controls.Add(this.ultraCoeficiente1);
            this.panelCostosIndirectos.Controls.Add(this.labelPorc2);
            this.panelCostosIndirectos.Controls.Add(this.chkCoef1);
            this.panelCostosIndirectos.Controls.Add(this.uneCoeficientePorc1);
            this.panelCostosIndirectos.Controls.Add(this.uneCoeficiente1);
            this.panelCostosIndirectos.Controls.Add(this.labelPorc1);
            this.panelCostosIndirectos.Location = new System.Drawing.Point(368, 6);
            this.panelCostosIndirectos.Name = "panelCostosIndirectos";
            this.panelCostosIndirectos.Size = new System.Drawing.Size(439, 152);
            this.panelCostosIndirectos.TabIndex = 147;
            this.panelCostosIndirectos.TabStop = false;
            // 
            // chkCoef10
            // 
            this.chkCoef10.Location = new System.Drawing.Point(364, 288);
            this.chkCoef10.Name = "chkCoef10";
            this.chkCoef10.Size = new System.Drawing.Size(88, 21);
            this.chkCoef10.TabIndex = 243;
            this.chkCoef10.Text = "Activo";
            // 
            // chkCoef9
            // 
            this.chkCoef9.Location = new System.Drawing.Point(364, 264);
            this.chkCoef9.Name = "chkCoef9";
            this.chkCoef9.Size = new System.Drawing.Size(88, 21);
            this.chkCoef9.TabIndex = 240;
            this.chkCoef9.Text = "Activo";
            // 
            // chkCoef8
            // 
            this.chkCoef8.Location = new System.Drawing.Point(364, 248);
            this.chkCoef8.Name = "chkCoef8";
            this.chkCoef8.Size = new System.Drawing.Size(88, 21);
            this.chkCoef8.TabIndex = 237;
            this.chkCoef8.Text = "Activo";
            // 
            // chkCoef7
            // 
            this.chkCoef7.Location = new System.Drawing.Point(364, 224);
            this.chkCoef7.Name = "chkCoef7";
            this.chkCoef7.Size = new System.Drawing.Size(88, 21);
            this.chkCoef7.TabIndex = 234;
            this.chkCoef7.Text = "Activo";
            // 
            // chkCoef6
            // 
            this.chkCoef6.Location = new System.Drawing.Point(364, 200);
            this.chkCoef6.Name = "chkCoef6";
            this.chkCoef6.Size = new System.Drawing.Size(88, 21);
            this.chkCoef6.TabIndex = 231;
            this.chkCoef6.Text = "Activo";
            // 
            // chkCoef5
            // 
            this.chkCoef5.Location = new System.Drawing.Point(364, 90);
            this.chkCoef5.Name = "chkCoef5";
            this.chkCoef5.Size = new System.Drawing.Size(76, 21);
            this.chkCoef5.TabIndex = 17;
            this.chkCoef5.Text = "Activo";
            // 
            // chkCoef4
            // 
            this.chkCoef4.Location = new System.Drawing.Point(364, 68);
            this.chkCoef4.Name = "chkCoef4";
            this.chkCoef4.Size = new System.Drawing.Size(76, 21);
            this.chkCoef4.TabIndex = 14;
            this.chkCoef4.Text = "Activo";
            // 
            // chkCoef3
            // 
            this.chkCoef3.Location = new System.Drawing.Point(364, 49);
            this.chkCoef3.Name = "chkCoef3";
            this.chkCoef3.Size = new System.Drawing.Size(76, 21);
            this.chkCoef3.TabIndex = 11;
            this.chkCoef3.Text = "Activo";
            // 
            // chkCoef2
            // 
            this.chkCoef2.Location = new System.Drawing.Point(364, 28);
            this.chkCoef2.Name = "chkCoef2";
            this.chkCoef2.Size = new System.Drawing.Size(76, 21);
            this.chkCoef2.TabIndex = 8;
            this.chkCoef2.Text = "Activo";
            // 
            // labelSimboloMonedaCoeficiente10
            // 
            this.labelSimboloMonedaCoeficiente10.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaCoeficiente10.Location = new System.Drawing.Point(143, 288);
            this.labelSimboloMonedaCoeficiente10.Name = "labelSimboloMonedaCoeficiente10";
            this.labelSimboloMonedaCoeficiente10.Size = new System.Drawing.Size(24, 21);
            this.labelSimboloMonedaCoeficiente10.TabIndex = 261;
            this.labelSimboloMonedaCoeficiente10.Text = "$";
            this.labelSimboloMonedaCoeficiente10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaCoeficiente9
            // 
            this.labelSimboloMonedaCoeficiente9.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaCoeficiente9.Location = new System.Drawing.Point(143, 264);
            this.labelSimboloMonedaCoeficiente9.Name = "labelSimboloMonedaCoeficiente9";
            this.labelSimboloMonedaCoeficiente9.Size = new System.Drawing.Size(24, 21);
            this.labelSimboloMonedaCoeficiente9.TabIndex = 260;
            this.labelSimboloMonedaCoeficiente9.Text = "$";
            this.labelSimboloMonedaCoeficiente9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaCoeficiente8
            // 
            this.labelSimboloMonedaCoeficiente8.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaCoeficiente8.Location = new System.Drawing.Point(143, 248);
            this.labelSimboloMonedaCoeficiente8.Name = "labelSimboloMonedaCoeficiente8";
            this.labelSimboloMonedaCoeficiente8.Size = new System.Drawing.Size(24, 21);
            this.labelSimboloMonedaCoeficiente8.TabIndex = 259;
            this.labelSimboloMonedaCoeficiente8.Text = "$";
            this.labelSimboloMonedaCoeficiente8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPorc10
            // 
            this.labelPorc10.BackColor = System.Drawing.Color.Transparent;
            this.labelPorc10.Location = new System.Drawing.Point(260, 288);
            this.labelPorc10.Name = "labelPorc10";
            this.labelPorc10.Size = new System.Drawing.Size(16, 21);
            this.labelPorc10.TabIndex = 258;
            this.labelPorc10.Text = "%";
            // 
            // labelPorc9
            // 
            this.labelPorc9.BackColor = System.Drawing.Color.Transparent;
            this.labelPorc9.Location = new System.Drawing.Point(260, 272);
            this.labelPorc9.Name = "labelPorc9";
            this.labelPorc9.Size = new System.Drawing.Size(16, 21);
            this.labelPorc9.TabIndex = 257;
            this.labelPorc9.Text = "%";
            // 
            // labelPorc8
            // 
            this.labelPorc8.BackColor = System.Drawing.Color.Transparent;
            this.labelPorc8.Location = new System.Drawing.Point(260, 248);
            this.labelPorc8.Name = "labelPorc8";
            this.labelPorc8.Size = new System.Drawing.Size(16, 21);
            this.labelPorc8.TabIndex = 256;
            this.labelPorc8.Text = "%";
            // 
            // uneCoeficientePorc10
            // 
            this.uneCoeficientePorc10.Location = new System.Drawing.Point(276, 288);
            this.uneCoeficientePorc10.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc10.Name = "uneCoeficientePorc10";
            this.uneCoeficientePorc10.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc10.Size = new System.Drawing.Size(72, 21);
            this.uneCoeficientePorc10.TabIndex = 242;
            this.uneCoeficientePorc10.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficientePorc9
            // 
            this.uneCoeficientePorc9.Location = new System.Drawing.Point(276, 264);
            this.uneCoeficientePorc9.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc9.Name = "uneCoeficientePorc9";
            this.uneCoeficientePorc9.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc9.Size = new System.Drawing.Size(72, 21);
            this.uneCoeficientePorc9.TabIndex = 239;
            this.uneCoeficientePorc9.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficientePorc8
            // 
            this.uneCoeficientePorc8.Location = new System.Drawing.Point(276, 240);
            this.uneCoeficientePorc8.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc8.Name = "uneCoeficientePorc8";
            this.uneCoeficientePorc8.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc8.Size = new System.Drawing.Size(72, 21);
            this.uneCoeficientePorc8.TabIndex = 236;
            this.uneCoeficientePorc8.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficientePorc7
            // 
            this.uneCoeficientePorc7.Location = new System.Drawing.Point(276, 224);
            this.uneCoeficientePorc7.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc7.Name = "uneCoeficientePorc7";
            this.uneCoeficientePorc7.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc7.Size = new System.Drawing.Size(72, 21);
            this.uneCoeficientePorc7.TabIndex = 233;
            this.uneCoeficientePorc7.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficientePorc6
            // 
            this.uneCoeficientePorc6.Location = new System.Drawing.Point(276, 200);
            this.uneCoeficientePorc6.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc6.Name = "uneCoeficientePorc6";
            this.uneCoeficientePorc6.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc6.Size = new System.Drawing.Size(72, 21);
            this.uneCoeficientePorc6.TabIndex = 230;
            this.uneCoeficientePorc6.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraCoeficiente10
            // 
            this.ultraCoeficiente10.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraCoeficiente10.Location = new System.Drawing.Point(16, 288);
            this.ultraCoeficiente10.Name = "ultraCoeficiente10";
            this.ultraCoeficiente10.Size = new System.Drawing.Size(128, 21);
            this.ultraCoeficiente10.TabIndex = 255;
            this.ultraCoeficiente10.Text = "Coeficiente 10";
            // 
            // ultraCoeficiente9
            // 
            this.ultraCoeficiente9.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraCoeficiente9.Location = new System.Drawing.Point(16, 272);
            this.ultraCoeficiente9.Name = "ultraCoeficiente9";
            this.ultraCoeficiente9.Size = new System.Drawing.Size(128, 21);
            this.ultraCoeficiente9.TabIndex = 254;
            this.ultraCoeficiente9.Text = "Coeficiente 9";
            // 
            // ultraCoeficiente8
            // 
            this.ultraCoeficiente8.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraCoeficiente8.Location = new System.Drawing.Point(16, 248);
            this.ultraCoeficiente8.Name = "ultraCoeficiente8";
            this.ultraCoeficiente8.Size = new System.Drawing.Size(128, 21);
            this.ultraCoeficiente8.TabIndex = 253;
            this.ultraCoeficiente8.Text = "Coeficiente 8";
            // 
            // uneCoeficiente10
            // 
            this.uneCoeficiente10.Location = new System.Drawing.Point(172, 288);
            this.uneCoeficiente10.MaskInput = "nnnnnnn.nn";
            this.uneCoeficiente10.Name = "uneCoeficiente10";
            this.uneCoeficiente10.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficiente10.Size = new System.Drawing.Size(80, 21);
            this.uneCoeficiente10.TabIndex = 241;
            this.uneCoeficiente10.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficiente9
            // 
            this.uneCoeficiente9.Location = new System.Drawing.Point(172, 264);
            this.uneCoeficiente9.MaskInput = "nnnnnnn.nn";
            this.uneCoeficiente9.Name = "uneCoeficiente9";
            this.uneCoeficiente9.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficiente9.Size = new System.Drawing.Size(80, 21);
            this.uneCoeficiente9.TabIndex = 238;
            this.uneCoeficiente9.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficiente8
            // 
            this.uneCoeficiente8.Location = new System.Drawing.Point(172, 240);
            this.uneCoeficiente8.MaskInput = "nnnnnnn.nn";
            this.uneCoeficiente8.Name = "uneCoeficiente8";
            this.uneCoeficiente8.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficiente8.Size = new System.Drawing.Size(80, 21);
            this.uneCoeficiente8.TabIndex = 235;
            this.uneCoeficiente8.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // labelSimboloMonedaCoeficiente7
            // 
            this.labelSimboloMonedaCoeficiente7.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaCoeficiente7.Location = new System.Drawing.Point(143, 224);
            this.labelSimboloMonedaCoeficiente7.Name = "labelSimboloMonedaCoeficiente7";
            this.labelSimboloMonedaCoeficiente7.Size = new System.Drawing.Size(24, 21);
            this.labelSimboloMonedaCoeficiente7.TabIndex = 247;
            this.labelSimboloMonedaCoeficiente7.Text = "$";
            this.labelSimboloMonedaCoeficiente7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaCoeficiente6
            // 
            this.labelSimboloMonedaCoeficiente6.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaCoeficiente6.Location = new System.Drawing.Point(143, 200);
            this.labelSimboloMonedaCoeficiente6.Name = "labelSimboloMonedaCoeficiente6";
            this.labelSimboloMonedaCoeficiente6.Size = new System.Drawing.Size(24, 21);
            this.labelSimboloMonedaCoeficiente6.TabIndex = 245;
            this.labelSimboloMonedaCoeficiente6.Text = "$";
            this.labelSimboloMonedaCoeficiente6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uneCoeficiente7
            // 
            this.uneCoeficiente7.Location = new System.Drawing.Point(172, 224);
            this.uneCoeficiente7.MaskInput = "nnnnnnn.nn";
            this.uneCoeficiente7.Name = "uneCoeficiente7";
            this.uneCoeficiente7.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficiente7.Size = new System.Drawing.Size(80, 21);
            this.uneCoeficiente7.TabIndex = 232;
            this.uneCoeficiente7.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficiente6
            // 
            this.uneCoeficiente6.Location = new System.Drawing.Point(172, 200);
            this.uneCoeficiente6.MaskInput = "nnnnnnn.nn";
            this.uneCoeficiente6.Name = "uneCoeficiente6";
            this.uneCoeficiente6.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficiente6.Size = new System.Drawing.Size(80, 21);
            this.uneCoeficiente6.TabIndex = 229;
            this.uneCoeficiente6.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // labelPorc6
            // 
            this.labelPorc6.BackColor = System.Drawing.Color.Transparent;
            this.labelPorc6.Location = new System.Drawing.Point(260, 208);
            this.labelPorc6.Name = "labelPorc6";
            this.labelPorc6.Size = new System.Drawing.Size(16, 21);
            this.labelPorc6.TabIndex = 239;
            this.labelPorc6.Text = "%";
            // 
            // ultraCoeficiente7
            // 
            this.ultraCoeficiente7.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraCoeficiente7.Location = new System.Drawing.Point(16, 224);
            this.ultraCoeficiente7.Name = "ultraCoeficiente7";
            this.ultraCoeficiente7.Size = new System.Drawing.Size(128, 21);
            this.ultraCoeficiente7.TabIndex = 238;
            this.ultraCoeficiente7.Text = "Coeficiente 7";
            // 
            // ultraCoeficiente6
            // 
            this.ultraCoeficiente6.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraCoeficiente6.Location = new System.Drawing.Point(16, 208);
            this.ultraCoeficiente6.Name = "ultraCoeficiente6";
            this.ultraCoeficiente6.Size = new System.Drawing.Size(128, 21);
            this.ultraCoeficiente6.TabIndex = 237;
            this.ultraCoeficiente6.Text = "Coeficiente 6";
            // 
            // labelPorc7
            // 
            this.labelPorc7.BackColor = System.Drawing.Color.Transparent;
            this.labelPorc7.Location = new System.Drawing.Point(260, 224);
            this.labelPorc7.Name = "labelPorc7";
            this.labelPorc7.Size = new System.Drawing.Size(16, 21);
            this.labelPorc7.TabIndex = 240;
            this.labelPorc7.Text = "%";
            // 
            // labelSimboloMonedaCoeficiente5
            // 
            this.labelSimboloMonedaCoeficiente5.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaCoeficiente5.Location = new System.Drawing.Point(143, 90);
            this.labelSimboloMonedaCoeficiente5.Name = "labelSimboloMonedaCoeficiente5";
            this.labelSimboloMonedaCoeficiente5.Size = new System.Drawing.Size(24, 21);
            this.labelSimboloMonedaCoeficiente5.TabIndex = 236;
            this.labelSimboloMonedaCoeficiente5.Text = "$";
            this.labelSimboloMonedaCoeficiente5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaCoeficiente4
            // 
            this.labelSimboloMonedaCoeficiente4.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaCoeficiente4.Location = new System.Drawing.Point(143, 69);
            this.labelSimboloMonedaCoeficiente4.Name = "labelSimboloMonedaCoeficiente4";
            this.labelSimboloMonedaCoeficiente4.Size = new System.Drawing.Size(24, 21);
            this.labelSimboloMonedaCoeficiente4.TabIndex = 235;
            this.labelSimboloMonedaCoeficiente4.Text = "$";
            this.labelSimboloMonedaCoeficiente4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaCoeficiente3
            // 
            this.labelSimboloMonedaCoeficiente3.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaCoeficiente3.Location = new System.Drawing.Point(143, 48);
            this.labelSimboloMonedaCoeficiente3.Name = "labelSimboloMonedaCoeficiente3";
            this.labelSimboloMonedaCoeficiente3.Size = new System.Drawing.Size(24, 21);
            this.labelSimboloMonedaCoeficiente3.TabIndex = 234;
            this.labelSimboloMonedaCoeficiente3.Text = "$";
            this.labelSimboloMonedaCoeficiente3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPorc5
            // 
            this.labelPorc5.BackColor = System.Drawing.Color.Transparent;
            this.labelPorc5.Location = new System.Drawing.Point(260, 93);
            this.labelPorc5.Name = "labelPorc5";
            this.labelPorc5.Size = new System.Drawing.Size(16, 21);
            this.labelPorc5.TabIndex = 233;
            this.labelPorc5.Text = "%";
            // 
            // labelPorc4
            // 
            this.labelPorc4.BackColor = System.Drawing.Color.Transparent;
            this.labelPorc4.Location = new System.Drawing.Point(260, 72);
            this.labelPorc4.Name = "labelPorc4";
            this.labelPorc4.Size = new System.Drawing.Size(16, 21);
            this.labelPorc4.TabIndex = 232;
            this.labelPorc4.Text = "%";
            // 
            // labelPorc3
            // 
            this.labelPorc3.BackColor = System.Drawing.Color.Transparent;
            this.labelPorc3.Location = new System.Drawing.Point(260, 52);
            this.labelPorc3.Name = "labelPorc3";
            this.labelPorc3.Size = new System.Drawing.Size(16, 21);
            this.labelPorc3.TabIndex = 231;
            this.labelPorc3.Text = "%";
            // 
            // uneCoeficientePorc5
            // 
            this.uneCoeficientePorc5.Location = new System.Drawing.Point(276, 88);
            this.uneCoeficientePorc5.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc5.Name = "uneCoeficientePorc5";
            this.uneCoeficientePorc5.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc5.Size = new System.Drawing.Size(72, 21);
            this.uneCoeficientePorc5.TabIndex = 16;
            this.uneCoeficientePorc5.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficientePorc4
            // 
            this.uneCoeficientePorc4.Location = new System.Drawing.Point(276, 68);
            this.uneCoeficientePorc4.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc4.Name = "uneCoeficientePorc4";
            this.uneCoeficientePorc4.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc4.Size = new System.Drawing.Size(72, 21);
            this.uneCoeficientePorc4.TabIndex = 13;
            this.uneCoeficientePorc4.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficientePorc3
            // 
            this.uneCoeficientePorc3.Location = new System.Drawing.Point(276, 48);
            this.uneCoeficientePorc3.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc3.Name = "uneCoeficientePorc3";
            this.uneCoeficientePorc3.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc3.Size = new System.Drawing.Size(72, 21);
            this.uneCoeficientePorc3.TabIndex = 10;
            this.uneCoeficientePorc3.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficientePorc2
            // 
            this.uneCoeficientePorc2.Location = new System.Drawing.Point(276, 28);
            this.uneCoeficientePorc2.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc2.Name = "uneCoeficientePorc2";
            this.uneCoeficientePorc2.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc2.Size = new System.Drawing.Size(72, 21);
            this.uneCoeficientePorc2.TabIndex = 7;
            this.uneCoeficientePorc2.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraCoeficiente5
            // 
            this.ultraCoeficiente5.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraCoeficiente5.Location = new System.Drawing.Point(16, 93);
            this.ultraCoeficiente5.Name = "ultraCoeficiente5";
            this.ultraCoeficiente5.Size = new System.Drawing.Size(128, 11);
            this.ultraCoeficiente5.TabIndex = 230;
            this.ultraCoeficiente5.Text = "Coeficiente 5";
            // 
            // ultraCoeficiente4
            // 
            this.ultraCoeficiente4.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraCoeficiente4.Location = new System.Drawing.Point(16, 72);
            this.ultraCoeficiente4.Name = "ultraCoeficiente4";
            this.ultraCoeficiente4.Size = new System.Drawing.Size(128, 16);
            this.ultraCoeficiente4.TabIndex = 229;
            this.ultraCoeficiente4.Text = "Coeficiente 4";
            // 
            // ultraCoeficiente3
            // 
            this.ultraCoeficiente3.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraCoeficiente3.Location = new System.Drawing.Point(16, 52);
            this.ultraCoeficiente3.Name = "ultraCoeficiente3";
            this.ultraCoeficiente3.Size = new System.Drawing.Size(128, 12);
            this.ultraCoeficiente3.TabIndex = 227;
            this.ultraCoeficiente3.Text = "Coeficiente 3";
            // 
            // uneCoeficiente5
            // 
            this.uneCoeficiente5.Location = new System.Drawing.Point(172, 88);
            this.uneCoeficiente5.MaskInput = "nnnnnnn.nn";
            this.uneCoeficiente5.Name = "uneCoeficiente5";
            this.uneCoeficiente5.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficiente5.Size = new System.Drawing.Size(80, 21);
            this.uneCoeficiente5.TabIndex = 15;
            this.uneCoeficiente5.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficiente4
            // 
            this.uneCoeficiente4.Location = new System.Drawing.Point(172, 68);
            this.uneCoeficiente4.MaskInput = "nnnnnnn.nn";
            this.uneCoeficiente4.Name = "uneCoeficiente4";
            this.uneCoeficiente4.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficiente4.Size = new System.Drawing.Size(80, 21);
            this.uneCoeficiente4.TabIndex = 12;
            this.uneCoeficiente4.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficiente3
            // 
            this.uneCoeficiente3.Location = new System.Drawing.Point(172, 48);
            this.uneCoeficiente3.MaskInput = "nnnnnnn.nn";
            this.uneCoeficiente3.Name = "uneCoeficiente3";
            this.uneCoeficiente3.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficiente3.Size = new System.Drawing.Size(80, 21);
            this.uneCoeficiente3.TabIndex = 9;
            this.uneCoeficiente3.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // labelSimboloMonedaPrecioDeCosto6
            // 
            this.labelSimboloMonedaPrecioDeCosto6.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeCosto6.Location = new System.Drawing.Point(143, 124);
            this.labelSimboloMonedaPrecioDeCosto6.Name = "labelSimboloMonedaPrecioDeCosto6";
            this.labelSimboloMonedaPrecioDeCosto6.Size = new System.Drawing.Size(24, 16);
            this.labelSimboloMonedaPrecioDeCosto6.TabIndex = 222;
            this.labelSimboloMonedaPrecioDeCosto6.Text = "$";
            this.labelSimboloMonedaPrecioDeCosto6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaCoeficiente2
            // 
            this.labelSimboloMonedaCoeficiente2.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaCoeficiente2.Location = new System.Drawing.Point(143, 28);
            this.labelSimboloMonedaCoeficiente2.Name = "labelSimboloMonedaCoeficiente2";
            this.labelSimboloMonedaCoeficiente2.Size = new System.Drawing.Size(24, 21);
            this.labelSimboloMonedaCoeficiente2.TabIndex = 220;
            this.labelSimboloMonedaCoeficiente2.Text = "$";
            this.labelSimboloMonedaCoeficiente2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaCoeficiente1
            // 
            this.labelSimboloMonedaCoeficiente1.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaCoeficiente1.Location = new System.Drawing.Point(143, 8);
            this.labelSimboloMonedaCoeficiente1.Name = "labelSimboloMonedaCoeficiente1";
            this.labelSimboloMonedaCoeficiente1.Size = new System.Drawing.Size(24, 21);
            this.labelSimboloMonedaCoeficiente1.TabIndex = 217;
            this.labelSimboloMonedaCoeficiente1.Text = "$";
            this.labelSimboloMonedaCoeficiente1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uneCoeficienteTotal
            // 
            this.uneCoeficienteTotal.Location = new System.Drawing.Point(172, 123);
            this.uneCoeficienteTotal.MaskInput = "nnnnnnn.nn";
            this.uneCoeficienteTotal.Name = "uneCoeficienteTotal";
            this.uneCoeficienteTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficienteTotal.Size = new System.Drawing.Size(80, 21);
            this.uneCoeficienteTotal.TabIndex = 18;
            this.uneCoeficienteTotal.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficiente2
            // 
            this.uneCoeficiente2.Location = new System.Drawing.Point(172, 28);
            this.uneCoeficiente2.MaskInput = "nnnnnnn.nn";
            this.uneCoeficiente2.Name = "uneCoeficiente2";
            this.uneCoeficiente2.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficiente2.Size = new System.Drawing.Size(80, 21);
            this.uneCoeficiente2.TabIndex = 6;
            this.uneCoeficiente2.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraLabel9
            // 
            this.ultraLabel9.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel9.Location = new System.Drawing.Point(16, 125);
            this.ultraLabel9.Name = "ultraLabel9";
            this.ultraLabel9.Size = new System.Drawing.Size(120, 16);
            this.ultraLabel9.TabIndex = 211;
            this.ultraLabel9.Text = "Costos Indirectos";
            // 
            // ultraCoeficiente2
            // 
            this.ultraCoeficiente2.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraCoeficiente2.Location = new System.Drawing.Point(16, 31);
            this.ultraCoeficiente2.Name = "ultraCoeficiente2";
            this.ultraCoeficiente2.Size = new System.Drawing.Size(128, 17);
            this.ultraCoeficiente2.TabIndex = 210;
            this.ultraCoeficiente2.Text = "Coeficiente 2";
            // 
            // ultraCoeficiente1
            // 
            this.ultraCoeficiente1.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraCoeficiente1.Location = new System.Drawing.Point(16, 13);
            this.ultraCoeficiente1.Name = "ultraCoeficiente1";
            this.ultraCoeficiente1.Size = new System.Drawing.Size(128, 11);
            this.ultraCoeficiente1.TabIndex = 209;
            this.ultraCoeficiente1.Text = "Coeficiente 1";
            // 
            // labelPorc2
            // 
            this.labelPorc2.BackColor = System.Drawing.Color.Transparent;
            this.labelPorc2.Location = new System.Drawing.Point(260, 32);
            this.labelPorc2.Name = "labelPorc2";
            this.labelPorc2.Size = new System.Drawing.Size(16, 21);
            this.labelPorc2.TabIndex = 213;
            this.labelPorc2.Text = "%";
            // 
            // chkCoef1
            // 
            this.chkCoef1.Location = new System.Drawing.Point(364, 9);
            this.chkCoef1.Name = "chkCoef1";
            this.chkCoef1.Size = new System.Drawing.Size(76, 21);
            this.chkCoef1.TabIndex = 5;
            this.chkCoef1.Text = "Activo";
            // 
            // uneCoeficientePorc1
            // 
            this.uneCoeficientePorc1.Location = new System.Drawing.Point(276, 8);
            this.uneCoeficientePorc1.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc1.Name = "uneCoeficientePorc1";
            this.uneCoeficientePorc1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc1.Size = new System.Drawing.Size(72, 21);
            this.uneCoeficientePorc1.TabIndex = 4;
            this.uneCoeficientePorc1.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficiente1
            // 
            this.uneCoeficiente1.Location = new System.Drawing.Point(172, 8);
            this.uneCoeficiente1.MaskInput = "nnnnnnn.nn";
            this.uneCoeficiente1.Name = "uneCoeficiente1";
            this.uneCoeficiente1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficiente1.Size = new System.Drawing.Size(80, 21);
            this.uneCoeficiente1.TabIndex = 3;
            this.uneCoeficiente1.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // labelPorc1
            // 
            this.labelPorc1.BackColor = System.Drawing.Color.Transparent;
            this.labelPorc1.Location = new System.Drawing.Point(260, 12);
            this.labelPorc1.Name = "labelPorc1";
            this.labelPorc1.Size = new System.Drawing.Size(16, 21);
            this.labelPorc1.TabIndex = 212;
            this.labelPorc1.Text = "%";
            // 
            // containerDatosVenta
            // 
            this.containerDatosVenta.Controls.Add(this.groupNuevoCosto);
            this.containerDatosVenta.Location = new System.Drawing.Point(-10000, -10000);
            this.containerDatosVenta.Name = "containerDatosVenta";
            this.containerDatosVenta.Size = new System.Drawing.Size(954, 170);
            this.containerDatosVenta.TabIndex = 4;
            this.containerDatosVenta.Visible = false;
            // 
            // groupNuevoCosto
            // 
            this.groupNuevoCosto.BackColor = System.Drawing.Color.Transparent;
            this.groupNuevoCosto.Controls.Add(this.groupBox5);
            this.groupNuevoCosto.Controls.Add(this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia);
            this.groupNuevoCosto.Controls.Add(this.label3);
            this.groupNuevoCosto.Controls.Add(this.unePrecioDeListaConImpuestoMonedaReferencia);
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
            this.groupNuevoCosto.Size = new System.Drawing.Size(848, 168);
            this.groupNuevoCosto.TabIndex = 78;
            this.groupNuevoCosto.TabStop = false;
            this.groupNuevoCosto.Text = "Datos para la Venta";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkUsaPrecioDeCostoReposicion1);
            this.groupBox5.Controls.Add(this.labelSimboloMonedaPrecioDeCostoReposicion1);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.unePrecioDeCostoReposicion1);
            this.groupBox5.Controls.Add(this.ultraLabel7);
            this.groupBox5.Controls.Add(this.labelSimboloMonedaPrecioDeCosto1);
            this.groupBox5.Controls.Add(this.unePCostoPromedioPonderado1);
            this.groupBox5.Location = new System.Drawing.Point(8, 80);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(344, 79);
            this.groupBox5.TabIndex = 161;
            this.groupBox5.TabStop = false;
            // 
            // chkUsaPrecioDeCostoReposicion1
            // 
            this.chkUsaPrecioDeCostoReposicion1.BackColor = System.Drawing.Color.Transparent;
            this.chkUsaPrecioDeCostoReposicion1.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkUsaPrecioDeCostoReposicion1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkUsaPrecioDeCostoReposicion1.Location = new System.Drawing.Point(8, 50);
            this.chkUsaPrecioDeCostoReposicion1.Name = "chkUsaPrecioDeCostoReposicion1";
            this.chkUsaPrecioDeCostoReposicion1.Size = new System.Drawing.Size(240, 20);
            this.chkUsaPrecioDeCostoReposicion1.TabIndex = 5;
            this.chkUsaPrecioDeCostoReposicion1.Text = "Usa Precio de Costo Reposición";
            // 
            // labelSimboloMonedaPrecioDeCostoReposicion1
            // 
            this.labelSimboloMonedaPrecioDeCostoReposicion1.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeCostoReposicion1.Location = new System.Drawing.Point(200, 31);
            this.labelSimboloMonedaPrecioDeCostoReposicion1.Name = "labelSimboloMonedaPrecioDeCostoReposicion1";
            this.labelSimboloMonedaPrecioDeCostoReposicion1.Size = new System.Drawing.Size(32, 16);
            this.labelSimboloMonedaPrecioDeCostoReposicion1.TabIndex = 158;
            this.labelSimboloMonedaPrecioDeCostoReposicion1.Text = "$";
            this.labelSimboloMonedaPrecioDeCostoReposicion1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(8, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 16);
            this.label5.TabIndex = 157;
            this.label5.Text = "Precio de Costo de Reposición";
            // 
            // unePrecioDeCostoReposicion1
            // 
            this.unePrecioDeCostoReposicion1.Location = new System.Drawing.Point(232, 31);
            this.unePrecioDeCostoReposicion1.MaskInput = "nnnnnnnn.nn";
            this.unePrecioDeCostoReposicion1.Name = "unePrecioDeCostoReposicion1";
            this.unePrecioDeCostoReposicion1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioDeCostoReposicion1.Size = new System.Drawing.Size(100, 21);
            this.unePrecioDeCostoReposicion1.TabIndex = 4;
            this.unePrecioDeCostoReposicion1.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraLabel7
            // 
            this.ultraLabel7.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel7.Location = new System.Drawing.Point(8, 16);
            this.ultraLabel7.Name = "ultraLabel7";
            this.ultraLabel7.Size = new System.Drawing.Size(195, 15);
            this.ultraLabel7.TabIndex = 154;
            this.ultraLabel7.Text = "Precio de Costo Promedio Ponderado";
            // 
            // labelSimboloMonedaPrecioDeCosto1
            // 
            this.labelSimboloMonedaPrecioDeCosto1.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeCosto1.Location = new System.Drawing.Point(200, 15);
            this.labelSimboloMonedaPrecioDeCosto1.Name = "labelSimboloMonedaPrecioDeCosto1";
            this.labelSimboloMonedaPrecioDeCosto1.Size = new System.Drawing.Size(32, 17);
            this.labelSimboloMonedaPrecioDeCosto1.TabIndex = 155;
            this.labelSimboloMonedaPrecioDeCosto1.Text = "$";
            this.labelSimboloMonedaPrecioDeCosto1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unePCostoPromedioPonderado1
            // 
            this.unePCostoPromedioPonderado1.Location = new System.Drawing.Point(232, 10);
            this.unePCostoPromedioPonderado1.Name = "unePCostoPromedioPonderado1";
            this.unePCostoPromedioPonderado1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePCostoPromedioPonderado1.PromptChar = ' ';
            this.unePCostoPromedioPonderado1.Size = new System.Drawing.Size(100, 21);
            this.unePCostoPromedioPonderado1.TabIndex = 3;
            this.unePCostoPromedioPonderado1.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia
            // 
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia.Location = new System.Drawing.Point(640, 99);
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia.Name = "labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia";
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia.Size = new System.Drawing.Size(32, 16);
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia.TabIndex = 89;
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia.Text = "$";
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(448, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 21);
            this.label3.TabIndex = 88;
            this.label3.Text = "Pcio Vta Bruto C/Imp. Moneda Ref..";
            // 
            // unePrecioDeListaConImpuestoMonedaReferencia
            // 
            this.unePrecioDeListaConImpuestoMonedaReferencia.Location = new System.Drawing.Point(672, 96);
            this.unePrecioDeListaConImpuestoMonedaReferencia.MaskInput = "nnnnnnnnn.nn";
            this.unePrecioDeListaConImpuestoMonedaReferencia.Name = "unePrecioDeListaConImpuestoMonedaReferencia";
            this.unePrecioDeListaConImpuestoMonedaReferencia.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioDeListaConImpuestoMonedaReferencia.Size = new System.Drawing.Size(100, 21);
            this.unePrecioDeListaConImpuestoMonedaReferencia.TabIndex = 10;
            this.unePrecioDeListaConImpuestoMonedaReferencia.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
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
            this.unePrecioDeListaConImpuesto.TabIndex = 9;
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
            this.unePrecioVentaBruto.TabIndex = 8;
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
            this.uneMaxDescuento.TabIndex = 7;
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
            this.uneMaxDescuentoPorcentual.TabIndex = 6;
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
            this.unePrecioDeVentaNeto.TabIndex = 2;
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
            this.unePrecioDeCostoRef.TabIndex = 0;
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
            this.uneMAC.TabIndex = 1;
            this.uneMAC.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraExplorerBarContainerControl3
            // 
            this.ultraExplorerBarContainerControl3.Controls.Add(this.groupBox2);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.groupBox3);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.gridListaDePrecios);
            this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
            this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(954, 320);
            this.ultraExplorerBarContainerControl3.TabIndex = 6;
            this.ultraExplorerBarContainerControl3.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferenciaLP);
            this.groupBox2.Controls.Add(this.labelSimboloMonedaPrecioDeListaConImpuestosLP);
            this.groupBox2.Controls.Add(this.labelSimboloMonedaPrecioDeListaLP);
            this.groupBox2.Controls.Add(this.labelSimboloMonedaDescuentoMaximoLP);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.unePrecioFinalMonedaReferenciaLP);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.unePrecioDeListaConImpuestoLP);
            this.groupBox2.Controls.Add(this.label32);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Controls.Add(this.unePrecioVentaBrutoLP);
            this.groupBox2.Controls.Add(this.label34);
            this.groupBox2.Controls.Add(this.uneMaxDescuentoLP);
            this.groupBox2.Controls.Add(this.label35);
            this.groupBox2.Controls.Add(this.uneMaxDescuentoPorcentualLP);
            this.groupBox2.Controls.Add(this.btnRestablecerAGral);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.uneCoeficienteMonedaReferencia);
            this.groupBox2.Controls.Add(this.uneCoeficiente);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Location = new System.Drawing.Point(0, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(878, 120);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferenciaLP
            // 
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferenciaLP.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferenciaLP.Location = new System.Drawing.Point(616, 70);
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferenciaLP.Name = "labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferenciaLP";
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferenciaLP.Size = new System.Drawing.Size(32, 16);
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferenciaLP.TabIndex = 167;
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferenciaLP.Text = "$";
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferenciaLP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaPrecioDeListaConImpuestosLP
            // 
            this.labelSimboloMonedaPrecioDeListaConImpuestosLP.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeListaConImpuestosLP.Location = new System.Drawing.Point(616, 48);
            this.labelSimboloMonedaPrecioDeListaConImpuestosLP.Name = "labelSimboloMonedaPrecioDeListaConImpuestosLP";
            this.labelSimboloMonedaPrecioDeListaConImpuestosLP.Size = new System.Drawing.Size(32, 16);
            this.labelSimboloMonedaPrecioDeListaConImpuestosLP.TabIndex = 166;
            this.labelSimboloMonedaPrecioDeListaConImpuestosLP.Text = "$";
            this.labelSimboloMonedaPrecioDeListaConImpuestosLP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaPrecioDeListaLP
            // 
            this.labelSimboloMonedaPrecioDeListaLP.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeListaLP.Location = new System.Drawing.Point(200, 96);
            this.labelSimboloMonedaPrecioDeListaLP.Name = "labelSimboloMonedaPrecioDeListaLP";
            this.labelSimboloMonedaPrecioDeListaLP.Size = new System.Drawing.Size(32, 16);
            this.labelSimboloMonedaPrecioDeListaLP.TabIndex = 165;
            this.labelSimboloMonedaPrecioDeListaLP.Text = "$";
            this.labelSimboloMonedaPrecioDeListaLP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaDescuentoMaximoLP
            // 
            this.labelSimboloMonedaDescuentoMaximoLP.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaDescuentoMaximoLP.Location = new System.Drawing.Point(200, 72);
            this.labelSimboloMonedaDescuentoMaximoLP.Name = "labelSimboloMonedaDescuentoMaximoLP";
            this.labelSimboloMonedaDescuentoMaximoLP.Size = new System.Drawing.Size(32, 16);
            this.labelSimboloMonedaDescuentoMaximoLP.TabIndex = 164;
            this.labelSimboloMonedaDescuentoMaximoLP.Text = "$";
            this.labelSimboloMonedaDescuentoMaximoLP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Location = new System.Drawing.Point(424, 71);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(223, 21);
            this.label30.TabIndex = 163;
            this.label30.Text = "Pcio Vta Bruto C/ Imp Moneda Ref.";
            // 
            // unePrecioFinalMonedaReferenciaLP
            // 
            this.unePrecioFinalMonedaReferenciaLP.Location = new System.Drawing.Point(648, 69);
            this.unePrecioFinalMonedaReferenciaLP.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.unePrecioFinalMonedaReferenciaLP.MaskInput = "-nnnnnnnnn.nn";
            this.unePrecioFinalMonedaReferenciaLP.Name = "unePrecioFinalMonedaReferenciaLP";
            this.unePrecioFinalMonedaReferenciaLP.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioFinalMonedaReferenciaLP.Size = new System.Drawing.Size(100, 21);
            this.unePrecioFinalMonedaReferenciaLP.TabIndex = 10;
            this.unePrecioFinalMonedaReferenciaLP.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Location = new System.Drawing.Point(424, 48);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(223, 21);
            this.label31.TabIndex = 161;
            this.label31.Text = "Precio de Venta Bruto Con Impuestos";
            // 
            // unePrecioDeListaConImpuestoLP
            // 
            this.unePrecioDeListaConImpuestoLP.Location = new System.Drawing.Point(648, 48);
            this.unePrecioDeListaConImpuestoLP.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.unePrecioDeListaConImpuestoLP.MaskInput = "-nnnnnnnnn.nn";
            this.unePrecioDeListaConImpuestoLP.Name = "unePrecioDeListaConImpuestoLP";
            this.unePrecioDeListaConImpuestoLP.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioDeListaConImpuestoLP.Size = new System.Drawing.Size(100, 21);
            this.unePrecioDeListaConImpuestoLP.TabIndex = 9;
            this.unePrecioDeListaConImpuestoLP.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Location = new System.Drawing.Point(336, 56);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(32, 16);
            this.label32.TabIndex = 159;
            this.label32.Text = "%";
            // 
            // label33
            // 
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Location = new System.Drawing.Point(8, 94);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(223, 21);
            this.label33.TabIndex = 158;
            this.label33.Text = "Precio de Venta Bruto (Precio de Lista)";
            // 
            // unePrecioVentaBrutoLP
            // 
            this.unePrecioVentaBrutoLP.Location = new System.Drawing.Point(232, 88);
            this.unePrecioVentaBrutoLP.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.unePrecioVentaBrutoLP.MaskInput = "-nnnnnnnnn.nn";
            this.unePrecioVentaBrutoLP.Name = "unePrecioVentaBrutoLP";
            this.unePrecioVentaBrutoLP.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioVentaBrutoLP.Size = new System.Drawing.Size(100, 21);
            this.unePrecioVentaBrutoLP.TabIndex = 8;
            this.unePrecioVentaBrutoLP.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label34
            // 
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Location = new System.Drawing.Point(8, 71);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(192, 21);
            this.label34.TabIndex = 157;
            this.label34.Text = "Descuento Máximo s/Precio de Lista";
            // 
            // uneMaxDescuentoLP
            // 
            this.uneMaxDescuentoLP.Location = new System.Drawing.Point(232, 69);
            this.uneMaxDescuentoLP.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.uneMaxDescuentoLP.MaskInput = "-nnnnnnnnn.nn";
            this.uneMaxDescuentoLP.Name = "uneMaxDescuentoLP";
            this.uneMaxDescuentoLP.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneMaxDescuentoLP.Size = new System.Drawing.Size(100, 21);
            this.uneMaxDescuentoLP.TabIndex = 7;
            this.uneMaxDescuentoLP.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label35
            // 
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Location = new System.Drawing.Point(8, 48);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(223, 21);
            this.label35.TabIndex = 156;
            this.label35.Text = "Descuento Porcentual s/Precio de Lista";
            // 
            // uneMaxDescuentoPorcentualLP
            // 
            this.uneMaxDescuentoPorcentualLP.Location = new System.Drawing.Point(232, 48);
            this.uneMaxDescuentoPorcentualLP.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.uneMaxDescuentoPorcentualLP.MaskInput = "-nnnnnnnnn.nn";
            this.uneMaxDescuentoPorcentualLP.Name = "uneMaxDescuentoPorcentualLP";
            this.uneMaxDescuentoPorcentualLP.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneMaxDescuentoPorcentualLP.Size = new System.Drawing.Size(100, 21);
            this.uneMaxDescuentoPorcentualLP.TabIndex = 6;
            this.uneMaxDescuentoPorcentualLP.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // btnRestablecerAGral
            // 
            this.btnRestablecerAGral.BackColor = System.Drawing.SystemColors.Control;
            this.btnRestablecerAGral.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRestablecerAGral.Location = new System.Drawing.Point(464, 16);
            this.btnRestablecerAGral.Name = "btnRestablecerAGral";
            this.btnRestablecerAGral.Size = new System.Drawing.Size(136, 20);
            this.btnRestablecerAGral.TabIndex = 11;
            this.btnRestablecerAGral.Text = "Restablecer a General";
            this.btnRestablecerAGral.UseVisualStyleBackColor = false;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(208, 20);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(136, 16);
            this.label27.TabIndex = 151;
            this.label27.Text = "Coeficiente Moneda Ref.";
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(8, 21);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(80, 16);
            this.label28.TabIndex = 150;
            this.label28.Text = "Coeficiente";
            // 
            // uneCoeficienteMonedaReferencia
            // 
            this.uneCoeficienteMonedaReferencia.Location = new System.Drawing.Point(352, 16);
            this.uneCoeficienteMonedaReferencia.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.uneCoeficienteMonedaReferencia.MaskInput = "-nnnnnnnnn.nn";
            this.uneCoeficienteMonedaReferencia.Name = "uneCoeficienteMonedaReferencia";
            this.uneCoeficienteMonedaReferencia.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficienteMonedaReferencia.Size = new System.Drawing.Size(88, 21);
            this.uneCoeficienteMonedaReferencia.TabIndex = 5;
            this.uneCoeficienteMonedaReferencia.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficiente
            // 
            this.uneCoeficiente.Location = new System.Drawing.Point(88, 16);
            this.uneCoeficiente.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.uneCoeficiente.MaskInput = "-nnnnnnnnn.nn";
            this.uneCoeficiente.Name = "uneCoeficiente";
            this.uneCoeficiente.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficiente.Size = new System.Drawing.Size(88, 21);
            this.uneCoeficiente.TabIndex = 4;
            this.uneCoeficiente.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Location = new System.Drawing.Point(176, 22);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(16, 16);
            this.label29.TabIndex = 147;
            this.label29.Text = "%";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.labelSimboloMonedaPrecioDeCostoReferenciaLP);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.unePrecioDeCostoRefLP);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.unePrecioDeVentaNetoLP);
            this.groupBox3.Controls.Add(this.labelSimboloMonedaPrecioDeVentaNetoLP);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.uneMACLP);
            this.groupBox3.Controls.Add(this.gridManagerView2);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(878, 40);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            // 
            // labelSimboloMonedaPrecioDeCostoReferenciaLP
            // 
            this.labelSimboloMonedaPrecioDeCostoReferenciaLP.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeCostoReferenciaLP.Location = new System.Drawing.Point(144, 17);
            this.labelSimboloMonedaPrecioDeCostoReferenciaLP.Name = "labelSimboloMonedaPrecioDeCostoReferenciaLP";
            this.labelSimboloMonedaPrecioDeCostoReferenciaLP.Size = new System.Drawing.Size(32, 16);
            this.labelSimboloMonedaPrecioDeCostoReferenciaLP.TabIndex = 81;
            this.labelSimboloMonedaPrecioDeCostoReferenciaLP.Text = "$";
            this.labelSimboloMonedaPrecioDeCostoReferenciaLP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(8, 17);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(144, 15);
            this.label25.TabIndex = 29;
            this.label25.Text = "Precio de Costo Referencia";
            // 
            // unePrecioDeCostoRefLP
            // 
            this.unePrecioDeCostoRefLP.Location = new System.Drawing.Point(176, 12);
            this.unePrecioDeCostoRefLP.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.unePrecioDeCostoRefLP.MaskInput = "-nnnnnnnnn.nn";
            this.unePrecioDeCostoRefLP.Name = "unePrecioDeCostoRefLP";
            this.unePrecioDeCostoRefLP.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioDeCostoRefLP.Size = new System.Drawing.Size(100, 21);
            this.unePrecioDeCostoRefLP.TabIndex = 0;
            this.unePrecioDeCostoRefLP.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(562, 17);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(112, 15);
            this.label23.TabIndex = 30;
            this.label23.Text = "Precio de Venta Neto";
            // 
            // unePrecioDeVentaNetoLP
            // 
            this.unePrecioDeVentaNetoLP.Location = new System.Drawing.Point(704, 12);
            this.unePrecioDeVentaNetoLP.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.unePrecioDeVentaNetoLP.MaskInput = "-nnnnnnnnn.nn";
            this.unePrecioDeVentaNetoLP.Name = "unePrecioDeVentaNetoLP";
            this.unePrecioDeVentaNetoLP.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioDeVentaNetoLP.Size = new System.Drawing.Size(100, 21);
            this.unePrecioDeVentaNetoLP.TabIndex = 2;
            this.unePrecioDeVentaNetoLP.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // labelSimboloMonedaPrecioDeVentaNetoLP
            // 
            this.labelSimboloMonedaPrecioDeVentaNetoLP.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeVentaNetoLP.Location = new System.Drawing.Point(672, 17);
            this.labelSimboloMonedaPrecioDeVentaNetoLP.Name = "labelSimboloMonedaPrecioDeVentaNetoLP";
            this.labelSimboloMonedaPrecioDeVentaNetoLP.Size = new System.Drawing.Size(32, 16);
            this.labelSimboloMonedaPrecioDeVentaNetoLP.TabIndex = 82;
            this.labelSimboloMonedaPrecioDeVentaNetoLP.Text = "$";
            this.labelSimboloMonedaPrecioDeVentaNetoLP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Location = new System.Drawing.Point(278, 17);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(146, 15);
            this.label26.TabIndex = 28;
            this.label26.Text = "Margen/Precio Costo Neto";
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(528, 17);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(42, 16);
            this.label22.TabIndex = 31;
            this.label22.Text = "%";
            // 
            // uneMACLP
            // 
            this.uneMACLP.Location = new System.Drawing.Point(424, 12);
            this.uneMACLP.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.uneMACLP.MaskInput = "-nnnnnnnnn.nn";
            this.uneMACLP.Name = "uneMACLP";
            this.uneMACLP.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneMACLP.Size = new System.Drawing.Size(100, 21);
            this.uneMACLP.TabIndex = 1;
            this.uneMACLP.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // gridManagerView2
            // 
            this.gridManagerView2.BackColor = System.Drawing.SystemColors.Control;
            this.gridManagerView2.Location = new System.Drawing.Point(0, 8);
            this.gridManagerView2.Name = "gridManagerView2";
            this.gridManagerView2.Size = new System.Drawing.Size(814, 24);
            this.gridManagerView2.TabIndex = 79;
            this.gridManagerView2.Visible = false;
            // 
            // gridListaDePrecios
            // 
            this.gridListaDePrecios.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridListaDePrecios.AlternatingColors = true;
            this.gridListaDePrecios.AutomaticSort = false;
            this.gridListaDePrecios.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat;
            this.gridListaDePrecios.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridListaDePrecios.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridListaDePrecios.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridListaDePrecios.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridListaDePrecios.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
            this.gridListaDePrecios.GroupByBoxVisible = false;
            this.gridListaDePrecios.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridListaDePrecios.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridListaDePrecios.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
            this.gridListaDePrecios.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
            this.gridListaDePrecios.Location = new System.Drawing.Point(0, 48);
            this.gridListaDePrecios.Name = "gridListaDePrecios";
            this.gridListaDePrecios.RecordNavigatorText = "Registro:|de";
            this.gridListaDePrecios.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridListaDePrecios.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridListaDePrecios.ShowEmptyFields = false;
            this.gridListaDePrecios.Size = new System.Drawing.Size(878, 144);
            this.gridListaDePrecios.TabIndex = 3;
            this.gridListaDePrecios.TabStop = false;
            this.gridListaDePrecios.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            // 
            // imglStandar
            // 
            this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
            this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
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
            this.toolBarStandar.Size = new System.Drawing.Size(1020, 28);
            this.toolBarStandar.TabIndex = 24;
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
            this.tbbCancelar.Text = "Cancelar";
            // 
            // ultraExplorerBar
            // 
            this.ultraExplorerBar.AnimationEnabled = false;
            this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl2);
            this.ultraExplorerBar.Controls.Add(this.containerProductos);
            this.ultraExplorerBar.Controls.Add(this.containerDatosVenta);
            this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl1);
            this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl3);
            this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl4);
            this.ultraExplorerBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ultraExplorerBar.Dock = System.Windows.Forms.DockStyle.Fill;
            ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl2;
            ultraExplorerBarGroup1.Settings.ContainerHeight = 30;
            ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup1.Text = "Tarea";
            ultraExplorerBarGroup2.Container = this.containerProductos;
            ultraExplorerBarGroup2.Settings.ContainerHeight = 235;
            ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup2.Text = "Producto";
            ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl1;
            ultraExplorerBarGroup3.Settings.ContainerHeight = 301;
            ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup3.Text = "Coeficientes de Incremento de Precio";
            ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl4;
            ultraExplorerBarGroup4.Key = "DatosCompra";
            ultraExplorerBarGroup4.Settings.ContainerHeight = 182;
            ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup4.Text = "Datos de la Compra";
            ultraExplorerBarGroup5.Container = this.containerDatosVenta;
            ultraExplorerBarGroup5.Key = "DatosVenta";
            ultraExplorerBarGroup5.Settings.ContainerHeight = 170;
            ultraExplorerBarGroup5.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup5.Text = "Datos para la Venta";
            ultraExplorerBarGroup6.Container = this.ultraExplorerBarContainerControl3;
            ultraExplorerBarGroup6.Key = "ListaDePrecios";
            ultraExplorerBarGroup6.Settings.ContainerHeight = 320;
            ultraExplorerBarGroup6.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup6.Text = "Lista de Precios de Venta y Utilidades";
            this.ultraExplorerBar.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2,
            ultraExplorerBarGroup3,
            ultraExplorerBarGroup4,
            ultraExplorerBarGroup5,
            ultraExplorerBarGroup6});
            this.ultraExplorerBar.Location = new System.Drawing.Point(0, 28);
            this.ultraExplorerBar.Name = "ultraExplorerBar";
            this.ultraExplorerBar.Size = new System.Drawing.Size(1020, 394);
            this.ultraExplorerBar.TabIndex = 25;
            this.ultraExplorerBar.TabStop = false;
            // 
            // FrmModificarPreciosMasivo
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1020, 422);
            this.Controls.Add(this.ultraExplorerBar);
            this.Controls.Add(this.toolBarStandar);
            this.Name = "FrmModificarPreciosMasivo";
            this.Text = "FrmModificarPreciosMasivo";
            this.ultraExplorerBarContainerControl2.ResumeLayout(false);
            this.containerProductos.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupPorProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.groupPorJerarquia.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.PerformLayout();
            this.groupListasDePrecios.ResumeLayout(false);
            this.gbReferencias.ResumeLayout(false);
            this.gbAplicaDescuento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mzCEFuentesDeCambio)).EndInit();
            this.gbAplicaCosto.ResumeLayout(false);
            this.gbAplicaCostoAfectaPCRTodos.ResumeLayout(false);
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
            this.ultraExplorerBarContainerControl4.ResumeLayout(false);
            this.groupMZ.ResumeLayout(false);
            this.groupMZ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoReposicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePCostoPromedioPonderado)).EndInit();
            this.panelCostosIndirectos.ResumeLayout(false);
            this.panelCostosIndirectos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficiente10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficiente9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficiente8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficiente7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficiente6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficiente5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficiente4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficiente3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficienteTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficiente2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficiente1)).EndInit();
            this.containerDatosVenta.ResumeLayout(false);
            this.groupNuevoCosto.ResumeLayout(false);
            this.groupNuevoCosto.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoReposicion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePCostoPromedioPonderado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeListaConImpuestoMonedaReferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeListaConImpuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioVentaBruto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuentoPorcentual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeVentaNeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoRef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMAC)).EndInit();
            this.ultraExplorerBarContainerControl3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioFinalMonedaReferenciaLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeListaConImpuestoLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioVentaBrutoLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuentoLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuentoPorcentualLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficienteMonedaReferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficiente)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoRefLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeVentaNetoLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMACLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaDePrecios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar)).EndInit();
            this.ultraExplorerBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
			mzProductosControl.SetProcess(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), "V");
			
			unePrecioDeVentaNeto.ReadOnly = true;
			uneMaxDescuento.ReadOnly = true;
			uneMaxDescuentoPorcentual.ReadOnly = true;
			gridProductos.LayoutData = _uiController.LayoutProductos;
			
			


			gridProductos.GroupByBoxVisible = false;
			gridProductos.SelectionMode = Janus.Windows.GridEX.SelectionMode.SingleSelection;
			uneMAC.FormatString = "n";
			uneMaxDescuento.FormatString = "n";
			uneMaxDescuentoPorcentual.FormatString = "n";

			uneMACLP.FormatString = "n";
			uneMaxDescuentoLP.FormatString = "n";
			uneMaxDescuentoPorcentualLP.FormatString = "n";
			uneCoeficiente.FormatString = "n";
			uneCoeficienteMonedaReferencia.FormatString = "n";


			labelSimboloMonedaDescuentoMaximo.Text = _uiController.SimboloMonedaDescuentoMaximo;
			labelSimboloMonedaPrecioDeCostoReferencia.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaPrecioDeLista.Text = _uiController.SimboloMonedaPrecioDeLista;
			labelSimboloMonedaPrecioDeVentaNeto.Text = _uiController.SimboloMonedaPrecioDeVentaNeto;
			labelSimboloMonedaPrecioDeListaConImpuestos.Text = _uiController.SimboloMonedaPrecioDeLista;
			labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia.Text = _uiController.SimboloMonedaReferencia;
			unePrecioDeCostoRef.ReadOnly = true;
			uneMAC.ReadOnly = true;
			unePrecioDeVentaNeto.ReadOnly = true;
			uneMaxDescuento.ReadOnly = true;
			uneMaxDescuentoPorcentual.ReadOnly = true;
			unePrecioVentaBruto.ReadOnly = true;
			unePrecioDeListaConImpuesto.ReadOnly = true;
			unePrecioDeListaConImpuestoMonedaReferencia.ReadOnly = true;

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
			rbAplicaCostoAfectaPCRTodos.Enabled = chkPrecioDeCosto.Checked;
			rbAplicaCostoAfectaPCRTodosUsaPcioCtoReposicion.Enabled = chkPrecioDeCosto.Checked;

			
			/*Configura controles para el Precio de Venta*/
			rbAplicaPVP.Enabled = chkPrecioDeVentaBruto.Checked;
			rbAplicaPVS.Enabled = chkPrecioDeVentaBruto.Checked;
			rbAplicaPVPConImpuestos.Enabled = chkPrecioDeVentaBruto.Checked;
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

			mzProductosControl.EnabledListaDePrecio = false;

			gridManagerView2.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), gridListaDePrecios, this.Text);
			unePrecioDeCostoRefLP.ReadOnly = true;
			uneMACLP.ReadOnly = true;
			unePrecioDeVentaNetoLP.ReadOnly = true;
			uneMaxDescuentoLP.ReadOnly = true;
			uneMaxDescuentoPorcentualLP.ReadOnly = true;
			unePrecioVentaBrutoLP.ReadOnly = true;
			unePrecioDeListaConImpuestoLP.ReadOnly = true;
			unePrecioFinalMonedaReferenciaLP.ReadOnly = true;
			uneCoeficiente.ReadOnly = true;
			uneCoeficienteMonedaReferencia.ReadOnly = true;
			btnRestablecerAGral.Enabled = false;
			labelSimboloMonedaPrecioDeCostoReferenciaLP.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaPrecioDeVentaNetoLP.Text = _uiController.SimboloMonedaPrecioDeVentaNeto;
			labelSimboloMonedaDescuentoMaximoLP.Text = _uiController.SimboloMonedaDescuentoMaximo;
			labelSimboloMonedaPrecioDeListaLP.Text = _uiController.SimboloMonedaPrecioDeLista;
			labelSimboloMonedaPrecioDeListaConImpuestosLP.Text = _uiController.SimboloMonedaPrecioDeLista;
			labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferenciaLP.Text = _uiController.SimboloMonedaReferencia;

    		ultraExplorerBar.Groups["ListaDePrecios"].Visible = _uiController.HabilitaListasDePrecios;
			ultraExplorerBar.Groups["DatosVenta"].Visible = !_uiController.HabilitaListasDePrecios;

			rbDescuentoAfectaMac.Enabled = false;
			rbDescuentoAfectaPVP.Enabled = false;

			#region Codigo Nuevo

			rbPorProducto.Checked = true;
			groupPorProducto.Visible = true;
			groupPorJerarquia.Visible = false;
			this.hierarchicalSearchControl1.Build_UI("PRODUCTOS",true);	
			rbPorJerarquia.Enabled = !_uiController.HabilitaListasDePrecios;
			
			#endregion

			Janus.Windows.GridEX.GridEXFormatStyle fs= new Janus.Windows.GridEX.GridEXFormatStyle((Janus.Windows.GridEX.GridEXFormatStyle) gridProductos.RowFormatStyle);
			fs.BackColor = System.Drawing.Color.LightCyan;
			Janus.Windows.GridEX.ConditionOperator condOp = Janus.Windows.GridEX.ConditionOperator.Equal;				
			Janus.Windows.GridEX.GridEXFormatCondition cnd = new Janus.Windows.GridEX.GridEXFormatCondition( gridProductos.RootTable.Columns[ "UsaPrecioDeCostoReposicion" ], condOp, false);
			cnd.FormatStyle = fs;
			gridProductos.RootTable.FormatConditions.Add( cnd );

			uneCoeficienteTotal.ReadOnly = true;

			labelSimboloMonedaCoeficiente1.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaCoeficiente2.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaCoeficiente3.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaCoeficiente4.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaCoeficiente5.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaCoeficiente6.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaCoeficiente7.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaCoeficiente8.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaCoeficiente9.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaCoeficiente10.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;

			labelSimboloMonedaPrecioDeCosto.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaPrecioDeCosto1.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaPrecioDeCosto6.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;			
			labelSimboloMonedaPrecioDeCostoReposicion.Text =  _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaPrecioDeCostoReposicion1.Text =  _uiController.SimboloMonedaPrecioDeCostoReferencia;
			unePCostoPromedioPonderado.ReadOnly = !_uiController.PermiteModificarPrecioDeCostoPromedioPonderado;
			unePCostoPromedioPonderado1.ReadOnly = !_uiController.PermiteModificarPrecioDeCostoPromedioPonderado;
			unePrecioDeCostoReposicion.ReadOnly = !(_uiController.PermiteModificarPrecioDeCostoReposicion && !_uiController.UsaPrecioDeListaProveedor);
			unePrecioDeCostoReposicion1.ReadOnly = !(_uiController.PermiteModificarPrecioDeCostoReposicion && !_uiController.UsaPrecioDeListaProveedor);
			chkUsaPrecioDeCostoReposicion.Enabled = _uiController.PermiteModificarUsaPrecioDeCostoReposicion;
			chkUsaPrecioDeCostoReposicion1.Enabled = _uiController.PermiteModificarUsaPrecioDeCostoReposicion;

			CargarCostosIndirectosDescripcion();

			panelCostosIndirectos.Visible = false;

			if(_uiController.UsaCostosIndirectos)
			{
				this.ultraExplorerBar.Groups["DatosCompra"].Visible = true;
				groupBox5.Visible = false;
				this.groupNuevoCosto.Size = new System.Drawing.Size(848, 120);
				this.containerDatosVenta.Size = new System.Drawing.Size(1020, 128);
			}
			else
			{
				this.ultraExplorerBar.Groups["DatosCompra"].Visible = false;

				// Tarea 20 Silvina

				int x = 10;
				int y = 85;

				groupBox5.Location = new System.Drawing.Point(label8.Location.X, label8.Location.Y);
				label8.Location = new System.Drawing.Point(label8.Location.X + x,label8.Location.Y + y);
				labelSimboloMonedaPrecioDeCostoReferencia.Location = new System.Drawing.Point(labelSimboloMonedaPrecioDeCostoReferencia.Location.X + x,labelSimboloMonedaPrecioDeCostoReferencia.Location.Y + y);
				unePrecioDeCostoRef.Location = new System.Drawing.Point(unePrecioDeCostoRef.Location.X + x,unePrecioDeCostoRef.Location.Y + y);

				label7.Location = new System.Drawing.Point(label7.Location.X + x,label7.Location.Y + y);
				uneMAC.Location = new System.Drawing.Point(uneMAC.Location.X + x,uneMAC.Location.Y + y);
				label15.Location = new System.Drawing.Point(label15.Location.X + x,label15.Location.Y + y);

				label10.Location = new System.Drawing.Point(label10.Location.X + x,label10.Location.Y + y);
				labelSimboloMonedaPrecioDeVentaNeto.Location = new System.Drawing.Point(labelSimboloMonedaPrecioDeVentaNeto.Location.X + x,labelSimboloMonedaPrecioDeVentaNeto.Location.Y + y);
				unePrecioDeVentaNeto.Location = new System.Drawing.Point(unePrecioDeVentaNeto.Location.X + x,unePrecioDeVentaNeto.Location.Y + y);

			}
			chkPrecioDeCosto.Enabled = !_uiController.UsaPrecioDeListaProveedor;
			KeyPreview = true;

			//Sabrina: Tarea 863. 20101109
			groupListasDePrecios.Visible = _uiController.HabilitaListasDePrecios;
			groupListasDePrecios.Enabled = rbAplicaPVP.Checked || rbAplicaPVPConImpuestos.Checked;
			gbAplicaDescuento.Enabled = !_uiController.HabilitaListasDePrecios;
			chkMaximoDescuentoPorcentual.Enabled = !_uiController.HabilitaListasDePrecios;
			//Fin Sabrina: Tarea 863. 20101109
		}
		public void CargarCostosIndirectosDescripcion()
		{
			_uiController.CargarCostosIndirectosDescripcion();
		
			// Pone, en los 10 labels del Container Datos Compra, las descripciones de los costos indirectos asociadas al producto
			ultraCoeficiente1.Text = _uiController.CostosIndirectosDescrip1;
			ultraCoeficiente2.Text = _uiController.CostosIndirectosDescrip2;
			ultraCoeficiente3.Text = _uiController.CostosIndirectosDescrip3;
			ultraCoeficiente4.Text = _uiController.CostosIndirectosDescrip4;
			ultraCoeficiente5.Text = _uiController.CostosIndirectosDescrip5;
			ultraCoeficiente6.Text = _uiController.CostosIndirectosDescrip6;
			ultraCoeficiente7.Text = _uiController.CostosIndirectosDescrip7;
			ultraCoeficiente8.Text = _uiController.CostosIndirectosDescrip8;
			ultraCoeficiente9.Text = _uiController.CostosIndirectosDescrip9;
			ultraCoeficiente10.Text = _uiController.CostosIndirectosDescrip10;	
		}

		private void InitializeData()
		{						
			
			mzProductosControl.AddObjectListener( (IObserver)_uiController );
			mzCEMonedas.FillFromDataSource( _uiController.TableMonedas, "idMoneda", "Descripcion", 8, "1", "2", "Descripcion");
			mzCEFuentesDeCambio.FillFromDataSource( _uiController.TableFuentesDeCambio, "idFuenteDeCambio", "Descripcion", 8, "1", "2", "Descripcion");

			//Sabrina: Tarea 863. 20101109
			chkListasDePrecios.Items.AddRange(_uiController.ListasDePrecios.ToArray());
			//Fin Sabrina: Tarea 863. 20101109	
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
			_uiController.ProductosCollectionChanged +=	new EventHandler(Refresh);
			_uiController.ErrorOcurred +=new EventHandler(_uiController_ErrorOcurred);
			_uiController.ProductosCollectionBackChanged +=new EventHandler(_uiController_ProductosCollectionBackChanged);
			gridProductos.SelectionChanged +=new EventHandler(gridProductos_SelectionChanged);
			toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
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
			chkMaximoDescuentoPorcentual.CheckedChanged +=new EventHandler(chkMaximoDescuentoPorcentual_CheckedChanged);

			gridListaDePrecios.SelectionChanged += new EventHandler(gridListaDePrecios_SelectionChanged);
			
			unePrecioDeCostoRefLP.Enter +=new EventHandler(SeleccionarTexto);
			uneMACLP.Enter +=new EventHandler(SeleccionarTexto);
			unePrecioDeVentaNetoLP.Enter +=new EventHandler(SeleccionarTexto);
			uneMaxDescuentoLP.Enter +=new EventHandler(SeleccionarTexto);
			uneMaxDescuentoPorcentualLP.Enter +=new EventHandler(SeleccionarTexto);
			unePrecioVentaBrutoLP.Enter +=new EventHandler(SeleccionarTexto);
			unePrecioDeListaConImpuestoLP.Enter +=new EventHandler(SeleccionarTexto);
			unePrecioFinalMonedaReferenciaLP.Enter +=new EventHandler(SeleccionarTexto);
			uneCoeficiente.Enter +=new EventHandler(SeleccionarTexto);
			uneCoeficienteMonedaReferencia.Enter +=new EventHandler(SeleccionarTexto);
			
			btnRestablecerAGral.Click +=new EventHandler(btnRestablecerAGral_Click);
			unePCostoPromedioPonderado.Enter +=new EventHandler(SeleccionarTexto);
			unePCostoPromedioPonderado1.Enter +=new EventHandler(SeleccionarTexto);
			chkUsaPrecioDeCostoReposicion.CheckedChanged +=	new EventHandler(chkUsaPrecioDeCostoReposicion_CheckedChanged);
			chkUsaPrecioDeCostoReposicion1.CheckedChanged +=	new EventHandler(chkUsaPrecioDeCostoReposicion1_CheckedChanged);
			uneCoeficiente1.Enter +=new EventHandler(SeleccionarTexto);
			uneCoeficiente2.Enter +=new EventHandler(SeleccionarTexto);
			uneCoeficiente3.Enter +=new EventHandler(SeleccionarTexto);
			uneCoeficiente4.Enter +=new EventHandler(SeleccionarTexto);
			uneCoeficiente5.Enter +=new EventHandler(SeleccionarTexto);

			uneCoeficientePorc1.Enter +=new EventHandler(SeleccionarTexto);
			uneCoeficientePorc2.Enter +=new EventHandler(SeleccionarTexto);
			uneCoeficientePorc3.Enter +=new EventHandler(SeleccionarTexto);
			uneCoeficientePorc4.Enter +=new EventHandler(SeleccionarTexto);
			uneCoeficientePorc5.Enter +=new EventHandler(SeleccionarTexto);

			uneCoeficienteTotal.Enter +=new EventHandler(SeleccionarTexto);

			this.chkCoef1.CheckedChanged += new System.EventHandler(this.chkCoef1_CheckedChanged);
			this.chkCoef2.CheckedChanged += new System.EventHandler(this.chkCoef2_CheckedChanged);
			this.chkCoef3.CheckedChanged += new System.EventHandler(this.chkCoef3_CheckedChanged);
			this.chkCoef4.CheckedChanged += new System.EventHandler(this.chkCoef4_CheckedChanged);
			this.chkCoef5.CheckedChanged += new System.EventHandler(this.chkCoef5_CheckedChanged);
			this.chkCoef6.CheckedChanged += new System.EventHandler(this.chkCoef6_CheckedChanged);
			this.chkCoef7.CheckedChanged += new System.EventHandler(this.chkCoef7_CheckedChanged);
			this.chkCoef8.CheckedChanged += new System.EventHandler(this.chkCoef8_CheckedChanged);
			this.chkCoef9.CheckedChanged += new System.EventHandler(this.chkCoef9_CheckedChanged);
			this.chkCoef10.CheckedChanged += new System.EventHandler(this.chkCoef10_CheckedChanged);

			
			#region Codigo Nuevo

			rbPorProducto.CheckedChanged +=new EventHandler(rbPorProducto_CheckedChanged);
			rbPorJerarquia.CheckedChanged +=new EventHandler(rbPorJerarquia_CheckedChanged);
			hierarchicalSearchControl1.OnSelected +=new EventHandler(hierarchicalSearchControl1_OnSelected);
				

			#endregion

			unePrecioVentaBruto.DoubleClick +=new EventHandler(unePrecioVentaBruto_DoubleClick);

			//Sabrina: Tarea 863. 20101109
			btnTodos.Click+=new EventHandler(btnTodos_Click);
			btnNinguno.Click += new System.EventHandler(this.btnNinguno_Click);
			btnInvertir.Click+=new EventHandler(btnInvertir_Click);
			btnVerSeleccionados.Click+=new EventHandler(btnVerSeleccionados_Click);
			btnVerTodas.Click+=new EventHandler(btnVerTodas_Click);
			rbAplicaPVP.CheckedChanged+=new EventHandler(rbAplicaPVP_CheckedChanged);
			rbAplicaPVPConImpuestos.CheckedChanged+=new EventHandler(rbAplicaPVPConImpuestos_CheckedChanged);
			//Fin Sabrina: Tarea 863. 20101109

			KeyDownManager KeyDownMan = new KeyDownManager(this);	

		}

		private void RefreshControls(object sender, EventArgs e)
		{
			labelSimboloMonedaDescuentoMaximo.Text = _uiController.SimboloMonedaDescuentoMaximo;
			labelSimboloMonedaPrecioDeCostoReferencia.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaPrecioDeLista.Text = _uiController.SimboloMonedaPrecioDeLista;
			labelSimboloMonedaPrecioDeVentaNeto.Text = _uiController.SimboloMonedaPrecioDeVentaNeto;
			labelSimboloMonedaPrecioDeListaConImpuestos.Text = _uiController.SimboloMonedaPrecioDeLista;
			labelSimboloMonedaPrecioDeCosto.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaPrecioDeCosto1.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaPrecioDeCosto6.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;			
			labelSimboloMonedaPrecioDeCostoReposicion.Text =  _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaPrecioDeCostoReposicion1.Text =  _uiController.SimboloMonedaPrecioDeCostoReferencia;

			// Moneda de Precio de Costo referencia.
			if ( !ultraCoeficiente1.Text.Equals(string.Empty) )
				labelSimboloMonedaCoeficiente1.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			if ( !ultraCoeficiente2.Text.Equals(string.Empty) )
				labelSimboloMonedaCoeficiente2.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			if ( !ultraCoeficiente3.Text.Equals(string.Empty) )
				labelSimboloMonedaCoeficiente3.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			if ( !ultraCoeficiente4.Text.Equals(string.Empty) )
				labelSimboloMonedaCoeficiente4.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			if ( !ultraCoeficiente5.Text.Equals(string.Empty) )
				labelSimboloMonedaCoeficiente5.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			if ( !ultraCoeficiente6.Text.Equals(string.Empty) )
				labelSimboloMonedaCoeficiente6.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			if ( !ultraCoeficiente7.Text.Equals(string.Empty) )
				labelSimboloMonedaCoeficiente7.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			if ( !ultraCoeficiente8.Text.Equals(string.Empty) )
				labelSimboloMonedaCoeficiente8.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			if ( !ultraCoeficiente9.Text.Equals(string.Empty) )
				labelSimboloMonedaCoeficiente9.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			if ( !ultraCoeficiente10.Text.Equals(string.Empty) )
				labelSimboloMonedaCoeficiente10.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;

			if(decimal.Round(Convert.ToDecimal(unePrecioVentaBruto.Value),4) < decimal.Round(Convert.ToDecimal(unePrecioDeVentaNeto.Value),4))
				unePrecioVentaBruto.Appearance.ForeColor = Color.Red;
			else unePrecioVentaBruto.Appearance.ForeColor = Color.Black;
			/*
			gridProductos.SetDataBinding(null, null);
			gridProductos.SetDataBinding(_uiController.Items, null);
			*/
            //Sabrina: Tarea 834. 20101004
            /*gridProductos.SelectionChanged -=new EventHandler(gridProductos_SelectionChanged);
            _isDirty = false;
            _selectedIndex = gridProductos.Row;
            gridProductos.DataSource = _uiController.Items;
            gridProductos.Row = _selectedIndex;
            _isDirty = true;
            gridProductos.SelectionChanged +=new EventHandler(gridProductos_SelectionChanged);
            if(gridProductos.RowCount > 1 && (gridProductos.RowCount - 1 >= _selectedIndex))
            {
			
                gridProductos.Select();
					
            }
            if(gridProductos.RecordCount == 1)
                this.gridProductos_SelectionChanged(gridProductos, new EventArgs());
                */
            gridProductos.Refresh();
            //Fin Sabrina: Tarea 834. 20101004
			labelSimboloMonedaPrecioDeCostoReferenciaLP.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaPrecioDeVentaNetoLP.Text = _uiController.SimboloMonedaPrecioDeVentaNeto;
			labelSimboloMonedaDescuentoMaximoLP.Text = _uiController.SimboloMonedaDescuentoMaximo;
			labelSimboloMonedaPrecioDeListaLP.Text = _uiController.SimboloMonedaPrecioDeLista;
			labelSimboloMonedaPrecioDeListaConImpuestosLP.Text = _uiController.SimboloMonedaPrecioDeLista;

			if(decimal.Round(Convert.ToDecimal(uneCoeficiente.Value),4) < 0)
				uneCoeficiente.Appearance.ForeColor = Color.Red;
			else uneCoeficiente.Appearance.ForeColor = Color.Black;
			if(decimal.Round(Convert.ToDecimal(uneCoeficienteMonedaReferencia.Value),4) < 0)
				uneCoeficienteMonedaReferencia.Appearance.ForeColor = Color.Red;
			else uneCoeficienteMonedaReferencia.Appearance.ForeColor = Color.Black;
			if(decimal.Round(Convert.ToDecimal(uneMaxDescuentoLP.Value),4) < 0)
				uneMaxDescuentoLP.Appearance.ForeColor = Color.Red;
			else uneMaxDescuentoLP.Appearance.ForeColor = Color.Black;
			if(decimal.Round(Convert.ToDecimal(uneMaxDescuentoPorcentualLP.Value),4) < 0)
				uneMaxDescuentoPorcentualLP.Appearance.ForeColor = Color.Red;
			else uneMaxDescuentoPorcentualLP.Appearance.ForeColor = Color.Black;

			if(decimal.Round(Convert.ToDecimal(unePrecioVentaBrutoLP.Value),4) < decimal.Round(Convert.ToDecimal(unePrecioDeVentaNetoLP.Value),4))
				unePrecioVentaBrutoLP.Appearance.ForeColor = Color.Red;
			else unePrecioVentaBrutoLP.Appearance.ForeColor = Color.Black;

			gridListaDePrecios.Refresh();

			this.HabilitarCostosIndirectos();			


		}
	
		private void HabilitarCostosIndirectos()
		{
			this.panelCostosIndirectos.Visible = true;
			_uiController.DisconnectCostosIndirectosEvent();

			if ( _uiController.CoeficienteCreadoyActivo(1) )
			{
				chkCoef1.Enabled = true;
				if ( _uiController.CostoIndirectoActivo1 )
				{	// coefic activo
					uneCoeficiente1.Enabled = true;
					if ( _uiController.CostoIndirectoTipo1 ) // 0=Porc; 1=Moneda
					{	// coefic de tipo Moneda -->  desact el porcentaje
						uneCoeficientePorc1.Enabled = false;
					}
					else uneCoeficientePorc1.Enabled = true;
				}
				else // coefic no activo
				{
					uneCoeficiente1.Enabled = false;
					uneCoeficientePorc1.Enabled = false;
				}
			}
			else // coefic no definido
			{
				chkCoef1.Enabled = false;
				uneCoeficiente1.Enabled = false;
				uneCoeficientePorc1.Enabled = false;
			}

			if ( _uiController.CoeficienteCreadoyActivo(2) )
			{
				chkCoef2.Enabled = true;
				if ( _uiController.CostoIndirectoActivo2 )
				{	// coefic activo
					uneCoeficiente2.Enabled = true;
					if ( _uiController.CostoIndirectoTipo2 ) // 0=Porc; 1=Moneda
					{	// coefic de tipo Moneda -->  desact el porcentaje
						uneCoeficientePorc2.Enabled = false;
					}
					else uneCoeficientePorc2.Enabled = true;
				}
				else // coefic no activo
				{
					uneCoeficiente2.Enabled = false;
					uneCoeficientePorc2.Enabled = false;
				}
			}
			else // coefic no definido
			{
				chkCoef2.Enabled = false;
				uneCoeficiente2.Enabled = false;
				uneCoeficientePorc2.Enabled = false;
			}

			if ( _uiController.CoeficienteCreadoyActivo(3) )
			{
				chkCoef3.Enabled = true;
				if ( _uiController.CostoIndirectoActivo3 )
				{	// coefic activo
					uneCoeficiente3.Enabled = true;
					if ( _uiController.CostoIndirectoTipo3 ) // 0=Porc; 1=Moneda
					{	// coefic de tipo Moneda -->  desact el porcentaje
						uneCoeficientePorc3.Enabled = false;
					}
					else uneCoeficientePorc3.Enabled = true;
				}
				else // coefic no activo
				{
					uneCoeficiente3.Enabled = false;
					uneCoeficientePorc3.Enabled = false;
				}
			}
			else // coefic no definido
			{
				chkCoef3.Enabled = false;
				uneCoeficiente3.Enabled = false;
				uneCoeficientePorc3.Enabled = false;
			}

			if ( _uiController.CoeficienteCreadoyActivo(4) )
			{
				chkCoef4.Enabled = true;
				if ( _uiController.CostoIndirectoActivo4 )
				{	// coefic activo
					uneCoeficiente4.Enabled = true;
					if ( _uiController.CostoIndirectoTipo4 ) // 0=Porc; 1=Moneda
					{	// coefic de tipo Moneda -->  desact el porcentaje
						uneCoeficientePorc4.Enabled = false;
					}
					else uneCoeficientePorc4.Enabled = true;
				}
				else // coefic no activo
				{
					uneCoeficiente4.Enabled = false;
					uneCoeficientePorc4.Enabled = false;
				}
			}
			else // coefic no definido
			{
				chkCoef4.Enabled = false;
				uneCoeficiente4.Enabled = false;
				uneCoeficientePorc4.Enabled = false;
			}
			
			if ( _uiController.CoeficienteCreadoyActivo(5) )
			{
				chkCoef5.Enabled = true;
				if ( _uiController.CostoIndirectoActivo5 )
				{	// coefic activo
					uneCoeficiente5.Enabled = true;
					if ( _uiController.CostoIndirectoTipo5 ) // 0=Porc; 1=Moneda
					{	// coefic de tipo Moneda -->  desact el porcentaje
						uneCoeficientePorc5.Enabled = false;
					}
					else uneCoeficientePorc5.Enabled = true;
				}
				else // coefic no activo
				{
					uneCoeficiente5.Enabled = false;
					uneCoeficientePorc5.Enabled = false;
				}
			}
			else // coefic no definido
			{
				chkCoef5.Enabled = false;
				uneCoeficiente5.Enabled = false;
				uneCoeficientePorc5.Enabled = false;
			}

			_uiController.ConnectCostosIndirectosEvent();

			/* Para los restantes coeficientes (6..10) es analogo a 1..5*/
		}



		private bool _isDirty = true;
		private void Refresh(object sender, EventArgs e)
		{
			try
			{
				/*
				gridProductos.SetDataBinding(null, null);
				gridProductos.SetDataBinding(_uiController.Items, null);
				gridProductos.UpdateData();
				*/
                //Sabrina: Tarea 834. 20101004
                /*gridProductos.SelectionChanged -=new EventHandler(gridProductos_SelectionChanged);
				
                _selectedIndex = gridProductos.Row;
                _isDirty = false;
                gridProductos.DataSource = _uiController.Items;
                gridProductos.Row = _selectedIndex;
                _isDirty = true;
                gridProductos.SelectionChanged +=new EventHandler(gridProductos_SelectionChanged);

                if(gridProductos.RowCount > 1 && (gridProductos.RowCount - 1 >= _selectedIndex))
                {
                    gridProductos.Row = _selectedIndex;
                    gridProductos.Select();

                    // Para listas de precios
                    gridListaDePrecios.SetDataBinding(null, null);
                    ArrayList items = new ArrayList();
                    businessrules.ListaDePreciosItem item = _uiController.SelectedItem.ListaDePrecios.GetItem(_uiController.SelectedItem.IdProducto, _uiController.IdListaDePrecioSeleccionada);
                    items.Add(item);
                    gridListaDePrecios.SetDataBinding(items, null);
				
                }
                if(gridProductos.RecordCount == 1)
                    this.gridProductos_SelectionChanged(gridProductos, new EventArgs());
                    */

                int row = gridProductos.Row;
                gridProductos.SetDataBinding(null, null);
                gridProductos.SetDataBinding(_uiController.Items, null);
                gridProductos.UpdateData();
                if (row >= 0)
                    gridProductos.Row = row;
                if (_uiController.SelectedItem != null)
                {
                    gridListaDePrecios.SetDataBinding(null, null);
                    gridListaDePrecios.SetDataBinding(_uiController.SelectedItem.ListaDePrecios.Items, null);

                }
                //Fin Sabrina: Tarea 834. 20101004
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
			unePrecioDeListaConImpuestoMonedaReferencia.DataBindings.Clear();
			gridProductos.SetDataBinding(_uiController.Items, null);
			mzCEMonedas.DataBindings.Clear();
			chkPrecioDeCosto.DataBindings.Clear();
			chkPrecioDeVentaBruto.DataBindings.Clear();
			chkProcentaje.DataBindings.Clear();
			chkValorConstante.DataBindings.Clear();
			unePorcentaje.DataBindings.Clear();
			uneValorConstante.DataBindings.Clear();
			mzCEFuentesDeCambio.DataBindings.Clear();
			rbDescuentoAfectaMac.DataBindings.Clear();
			rbDescuentoAfectaPVP.DataBindings.Clear();
			unePCostoPromedioPonderado.DataBindings.Clear();
			unePCostoPromedioPonderado1.DataBindings.Clear();
			unePrecioDeCostoReposicion.DataBindings.Clear();
			unePrecioDeCostoReposicion1.DataBindings.Clear();
			chkUsaPrecioDeCostoReposicion.DataBindings.Clear();
			chkUsaPrecioDeCostoReposicion1.DataBindings.Clear();
			rbAplicaCostoAfectaPCRTodos.DataBindings.Clear();
			rbAplicaCostoAfectaPCRTodosUsaPcioCtoReposicion.DataBindings.Clear();


			mzCEFuentesDeCambio.DataBindings.Add("Value", _uiController, "IdFuenteDeCambioValorConstante");
			mzCEMonedas.DataBindings.Add("Value", _uiController, "IdMonedaValorConstante");
			uneMAC.DataBindings.Add("Value", _uiController, "MAC");
			unePrecioDeVentaNeto.DataBindings.Add("Value", _uiController, "PrecioDeVentaNeto");
			unePrecioVentaBruto.DataBindings.Add("Value", _uiController, "PrecioDeVentaBruto");
			uneMaxDescuento.DataBindings.Add("Value", _uiController, "MaximoDescuento");
			uneMaxDescuentoPorcentual.DataBindings.Add("Value", _uiController, "PorcentajeMaximoDescuento");
			unePrecioDeCostoRef.DataBindings.Add("Value", _uiController, "PrecioCostoRef");
			unePrecioDeListaConImpuesto.DataBindings.Add("Value", _uiController, "PrecioDeListaConImpuestos");
			unePrecioDeListaConImpuestoMonedaReferencia.DataBindings.Add("Value", _uiController, "PrecioDeListaConImpuestosMonedaReferencia");
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
			BindingController.Bind(rbAplicaCostoAfectaPCRTodos,"Checked", _uiController, "AplicaSobreCostoAfectaPCRTodos");
			BindingController.Bind(rbAplicaCostoAfectaPCRTodosUsaPcioCtoReposicion,"Checked", _uiController, "AplicaSobreCostoAfectaPCRTodosUsaPcioCtoReposicion");

			//rbAplicaCostoAfectaPCRTodos.DataBindings.Add("Checked", _uiController, "AplicaSobreCostoAfectaPCRTodos");
			//rbAplicaCostoAfectaPCRTodosUsaPcioCtoReposicion.DataBindings.Add("Checked", _uiController, "AplicaSobreCostoAfectaPCRTodosUsaPcioCtoReposicion");


			/*Bindeos sobre el precio de Venta*/
			BindingController.Bind(chkPrecioDeVentaBruto,"Checked", _uiController, "AplicaSobrePrecioDeVenta");
			BindingController.Bind(rbAplicaPVS,"Checked", _uiController, "AplicaSobrePrecioDeVentaNeto");
			BindingController.Bind(rbAplicaPVP,"Checked", _uiController, "AplicaSobrePrecioDeVentaBruto");
			BindingController.Bind(rbAplicaPVPConImpuestos,"Checked", _uiController, "AplicaSobrePrecioDeVentaBrutoConImpuestos");
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
			BindingController.Bind(rbAplicaMACAfectaPVPCondicional,"Checked", _uiController, "AplicaSobreMACAfectaPVPCondicional");
			BindingController.Bind(rbAplicaMACAfectaPVPCondicionalIgualPVS,"Checked", _uiController, "AplicaSobreMACAfectaPVPCondicionalIgualPVS");
			BindingController.Bind(rbAplicaMACAfectaPVPCondicionalTrasladaIncremento,"Checked", _uiController, "AplicaSobreMACAfectaPVPCondicionalTrasladaIncremento");
			BindingController.Bind(rbAplicaMACAfectaPVPTodosIgualPVS,"Checked", _uiController, "AplicaSobreMACAfectaPVPTodosIgualPVS");
			BindingController.Bind(rbAplicaMACAfectaPVPTodosTrasladaIncremento,"Checked", _uiController, "AplicaSobreMACAfectaPVPTodosTrasladaIncremento");


			BindingController.Bind(chkMaximoDescuentoPorcentual,"Checked", _uiController, "AplicaSobreMaximoDescuentoPorcentual");
			//rbDescuentoAfectaMac.DataBindings.Add("Checked",_uiController,"PrecioDeVentaAfectaMac");
			//rbDescuentoAfectaPVP.DataBindings.Add("Checked",_uiController,"PrecioDeVentaAfectaPVP");
			rbDescuentoAfectaMac.DataBindings.Add("Checked",_uiController,"AplicaSobreMaximoDescuentoPorcentualAfectaMAC");
			rbDescuentoAfectaPVP.DataBindings.Add("Checked",_uiController,"AplicaSobreMaximoDescuentoPorcentualAfectaPVP");

			/*Bindeos Lista de precios*/

			unePrecioDeCostoRefLP.DataBindings.Clear();
			uneMACLP.DataBindings.Clear();
			unePrecioDeVentaNetoLP.DataBindings.Clear();			
			uneCoeficiente.DataBindings.Clear();
			uneCoeficienteMonedaReferencia.DataBindings.Clear();
			uneMaxDescuentoPorcentualLP.DataBindings.Clear();
			uneMaxDescuentoLP.DataBindings.Clear();
			unePrecioVentaBrutoLP.DataBindings.Clear();
			unePrecioDeListaConImpuestoLP.DataBindings.Clear();
			unePrecioFinalMonedaReferenciaLP.DataBindings.Clear();

			unePrecioDeCostoRefLP.DataBindings.Add("Value", _uiController,"PrecioCostoRefLPItem");
			uneMACLP.DataBindings.Add("Value",_uiController,"MACLPItem");
			unePrecioDeVentaNetoLP.DataBindings.Add("Value",_uiController,"PrecioDeVentaNeto");
			uneCoeficiente.DataBindings.Add("Value",_uiController,"CoeficienteProductoLPItem");
			uneCoeficienteMonedaReferencia.DataBindings.Add("Value",_uiController,"CoeficienteProductoMonedaRefLPItem");
			uneMaxDescuentoPorcentualLP.DataBindings.Add("Value",_uiController,"MaxDescuentoPorcentualLPItem");
			uneMaxDescuentoLP.DataBindings.Add("Value",_uiController,"MaxDescuentoLPItem");
			unePrecioVentaBrutoLP.DataBindings.Add("Value",_uiController,"PrecioVentaBrutoLPItem");
			unePrecioDeListaConImpuestoLP.DataBindings.Add("Value",_uiController,"PrecioDeListaConImpuestoLPItem");
			unePrecioFinalMonedaReferenciaLP.DataBindings.Add("Value",_uiController,"PrecioFinalMonedaReferenciaLPItem");


			chkUsaPrecioDeCostoReposicion.DataBindings.Add("Checked", _uiController,"UsaPrecioDeCostoReposicion");
			chkUsaPrecioDeCostoReposicion1.DataBindings.Add("Checked", _uiController,"UsaPrecioDeCostoReposicion");
			unePrecioDeCostoReposicion.DataBindings.Add("Value", _uiController,"PrecioDeCostoReposicion");
			unePrecioDeCostoReposicion1.DataBindings.Add("Value", _uiController,"PrecioDeCostoReposicion");
			unePCostoPromedioPonderado.DataBindings.Add("Value", _uiController,"PrecioDeCostoPromedioPonderado");
			unePCostoPromedioPonderado1.DataBindings.Add("Value", _uiController,"PrecioDeCostoPromedioPonderado");

            InitDataBindingsCostosIndirectos();			
		}

		public void InitDataBindingsCostosIndirectos() // Matias - Tarea 26 - 2008
		{			
			// Limpio DataBindings
			uneCoeficiente1.DataBindings.Clear();
			uneCoeficiente2.DataBindings.Clear();
			uneCoeficiente3.DataBindings.Clear();
			uneCoeficiente4.DataBindings.Clear();
			uneCoeficiente5.DataBindings.Clear();
			uneCoeficiente6.DataBindings.Clear();
			uneCoeficiente7.DataBindings.Clear();
			uneCoeficiente8.DataBindings.Clear();
			uneCoeficiente9.DataBindings.Clear();
			uneCoeficiente10.DataBindings.Clear();
			uneCoeficientePorc1.DataBindings.Clear();
			uneCoeficientePorc2.DataBindings.Clear();
			uneCoeficientePorc3.DataBindings.Clear();
			uneCoeficientePorc4.DataBindings.Clear();
			uneCoeficientePorc5.DataBindings.Clear();
			uneCoeficientePorc6.DataBindings.Clear();
			uneCoeficientePorc7.DataBindings.Clear();
			uneCoeficientePorc8.DataBindings.Clear();
			uneCoeficientePorc9.DataBindings.Clear();
			uneCoeficientePorc10.DataBindings.Clear();
			chkCoef1.DataBindings.Clear();
			chkCoef2.DataBindings.Clear();
			chkCoef3.DataBindings.Clear();
			chkCoef4.DataBindings.Clear();
			chkCoef5.DataBindings.Clear();
			chkCoef6.DataBindings.Clear();
			chkCoef7.DataBindings.Clear();
			chkCoef8.DataBindings.Clear();
			chkCoef9.DataBindings.Clear();
			chkCoef10.DataBindings.Clear();
			uneCoeficienteTotal.DataBindings.Clear();

			// Costos Indirectos - coeficiente total
			//Sabrina: tarea 56
			uneCoeficienteTotal.DataBindings.Add("Value", _uiController, "PrecioDeCostoIndirecto");

			if ( _uiController.CoeficienteBinding(1) )
			{
				uneCoeficiente1.DataBindings.Add("Value", _uiController, "CostoIndirecto1");
				uneCoeficientePorc1.DataBindings.Add("Value", _uiController, "CostoIndirectoPorc1");
				chkCoef1.DataBindings.Add("Checked", _uiController, "CostoIndirectoActivo1");
			}
			if ( _uiController.CoeficienteBinding(2) )
			{
				uneCoeficiente2.DataBindings.Add("Value", _uiController, "CostoIndirecto2");
				uneCoeficientePorc2.DataBindings.Add("Value", _uiController, "CostoIndirectoPorc2");
				chkCoef2.DataBindings.Add("Checked", _uiController, "CostoIndirectoActivo2");
			}
			if ( _uiController.CoeficienteBinding(3) )
			{
				uneCoeficiente3.DataBindings.Add("Value", _uiController, "CostoIndirecto3");
				uneCoeficientePorc3.DataBindings.Add("Value", _uiController, "CostoIndirectoPorc3");
				chkCoef3.DataBindings.Add("Checked", _uiController, "CostoIndirectoActivo3");
			}
			if ( _uiController.CoeficienteBinding(4) )
			{
				uneCoeficiente4.DataBindings.Add("Value", _uiController, "CostoIndirecto4");
				uneCoeficientePorc4.DataBindings.Add("Value", _uiController, "CostoIndirectoPorc4");
				chkCoef4.DataBindings.Add("Checked", _uiController, "CostoIndirectoActivo4");
			}
			if ( _uiController.CoeficienteBinding(5) )
			{
				uneCoeficiente5.DataBindings.Add("Value", _uiController, "CostoIndirecto5");
				uneCoeficientePorc5.DataBindings.Add("Value", _uiController, "CostoIndirectoPorc5");
				chkCoef5.DataBindings.Add("Checked", _uiController, "CostoIndirectoActivo5");
			}
			if ( _uiController.CoeficienteBinding(6) )
			{
				uneCoeficiente6.DataBindings.Add("Value", _uiController, "CostoIndirecto6");
				uneCoeficientePorc6.DataBindings.Add("Value", _uiController, "CostoIndirectoPorc6");
				chkCoef6.DataBindings.Add("Checked", _uiController, "CostoIndirectoActivo6");
			}
			if ( _uiController.CoeficienteBinding(7) )
			{
				uneCoeficiente7.DataBindings.Add("Value", _uiController, "CostoIndirecto7");
				uneCoeficientePorc7.DataBindings.Add("Value", _uiController, "CostoIndirectoPorc7");
				chkCoef7.DataBindings.Add("Checked", _uiController, "CostoIndirectoActivo7");
			}
			if ( _uiController.CoeficienteBinding(8) )
			{
				uneCoeficiente8.DataBindings.Add("Value", _uiController, "CostoIndirecto8");
				uneCoeficientePorc8.DataBindings.Add("Value", _uiController, "CostoIndirectoPorc8");
				chkCoef8.DataBindings.Add("Checked", _uiController, "CostoIndirectoActivo8");
			}
			if ( _uiController.CoeficienteBinding(9) )
			{
				uneCoeficiente9.DataBindings.Add("Value", _uiController, "CostoIndirecto9");
				uneCoeficientePorc9.DataBindings.Add("Value", _uiController, "CostoIndirectoPorc9");
				chkCoef9.DataBindings.Add("Checked", _uiController, "CostoIndirectoActivo9");
			}
			if ( _uiController.CoeficienteBinding(10) )
			{
				uneCoeficiente10.DataBindings.Add("Value", _uiController, "CostoIndirecto10");
				uneCoeficientePorc10.DataBindings.Add("Value", _uiController, "CostoIndirectoPorc10");
				chkCoef10.DataBindings.Add("Checked", _uiController, "CostoIndirectoActivo10");
			}

		}


		#endregion

		#region Miembros de ITaskForm

		public void Execute()
		{
            //Sabrina: Tarea 1068. 20110317
            bool cambioCosto = _uiController.CambioCostoProductosCombo();
            bool cambioPcioVenta = _uiController.CambioPrecioVentaProductosCombo();
            if (cambioCosto && cambioPcioVenta)
            {
                if (MessageBox.Show("El Precio de Costo y Venta de este producto cambio. Desea actualizar los combos que lo referencian??", "Confirmar cambios", System.Windows.Forms.MessageBoxButtons.YesNo).Equals(System.Windows.Forms.DialogResult.Yes))
                    _uiController.ActualizaPreciosProductosCombo = true;
            }
            else if (cambioCosto)
            {
                if (MessageBox.Show("El Precio de Costo de este producto cambio. Desea actualizar los combos que lo referencian??", "Confirmar cambios", System.Windows.Forms.MessageBoxButtons.YesNo).Equals(System.Windows.Forms.DialogResult.Yes))
                    _uiController.ActualizaPreciosProductosCombo = true;
            }
            else if (cambioPcioVenta)
            {
                if (MessageBox.Show("El Precio de venta de este producto cambio. Desea actualizar los combos que lo referencian??", "Confirmar cambios", System.Windows.Forms.MessageBoxButtons.YesNo).Equals(System.Windows.Forms.DialogResult.Yes))
                    _uiController.ActualizaPreciosProductosCombo = true;
            }
            _uiController.Execute();
            //Fin Sabrina: Tarea 1068. 20110317
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

		public void KeyDownPrevious()
		{
			_uiController.Previous();
		}

		public void KeyDownNext()
		{
			_uiController.Execute();
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
				BindingController.Clear(rbAplicaPVPConImpuestos,"Checked", _uiController, "AplicaSobrePrecioDeVentaBrutoConImpuestos");
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

				BindingController.Clear(chkMaximoDescuentoPorcentual,"Checked", _uiController, "AplicaSobreMaximoDescuentoPorcentual");

				gridListaDePrecios.SelectionChanged -= new EventHandler(gridListaDePrecios_SelectionChanged);
			
				unePrecioDeCostoRefLP.Enter -=new EventHandler(SeleccionarTexto);
				uneMACLP.Enter -=new EventHandler(SeleccionarTexto);
				unePrecioDeVentaNetoLP.Enter -=new EventHandler(SeleccionarTexto);
				uneMaxDescuentoLP.Enter -=new EventHandler(SeleccionarTexto);
				uneMaxDescuentoPorcentualLP.Enter -=new EventHandler(SeleccionarTexto);
				unePrecioVentaBrutoLP.Enter -=new EventHandler(SeleccionarTexto);
				unePrecioDeListaConImpuestoLP.Enter -=new EventHandler(SeleccionarTexto);
				unePrecioFinalMonedaReferenciaLP.Enter -=new EventHandler(SeleccionarTexto);
				uneCoeficiente.Enter -=new EventHandler(SeleccionarTexto);
				uneCoeficienteMonedaReferencia.Enter -=new EventHandler(SeleccionarTexto);
			
				btnRestablecerAGral.Click -=new EventHandler(btnRestablecerAGral_Click);

				unePCostoPromedioPonderado.Enter -=new EventHandler(SeleccionarTexto);
				unePCostoPromedioPonderado.DataBindings.Clear();
				uneCoeficiente1.Enter -=new EventHandler(SeleccionarTexto);
				uneCoeficiente2.Enter -=new EventHandler(SeleccionarTexto);
				uneCoeficiente3.Enter -=new EventHandler(SeleccionarTexto);
				uneCoeficiente4.Enter -=new EventHandler(SeleccionarTexto);
				uneCoeficiente5.Enter -=new EventHandler(SeleccionarTexto);

				uneCoeficientePorc1.Enter -=new EventHandler(SeleccionarTexto);
				uneCoeficientePorc2.Enter -=new EventHandler(SeleccionarTexto);
				uneCoeficientePorc3.Enter -=new EventHandler(SeleccionarTexto);
				uneCoeficientePorc4.Enter -=new EventHandler(SeleccionarTexto);
				uneCoeficientePorc5.Enter -=new EventHandler(SeleccionarTexto);

				uneCoeficienteTotal.Enter -=new EventHandler(SeleccionarTexto);

			
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
			if(gridProductos.SelectedItems.Count > 0 && _isDirty)
			{
				object selectedItem = gridProductos.SelectedItems[0].GetRow().DataRow;
				_selectedIndex = gridProductos.Row;
				_uiController.ObjectHasChanged -=new EventHandler(RefreshControls);
				_uiController.ProductosCollectionChanged -=	new EventHandler(Refresh);
				_uiController.SelectedItem = (businessrules.Producto) selectedItem;
				_uiController.ObjectHasChanged +=new EventHandler(RefreshControls);
				_uiController.ProductosCollectionChanged +=	new EventHandler(Refresh);
				unePrecioDeCostoRef.ReadOnly = !_uiController.AllowEditPrecioDeCostoRef;
				uneMAC.ReadOnly = false;
				unePrecioDeVentaNeto.ReadOnly = true;
				uneMaxDescuento.ReadOnly = true;
				uneMaxDescuentoPorcentual.ReadOnly = true;
				unePrecioVentaBruto.ReadOnly = false;
				unePrecioDeListaConImpuesto.ReadOnly  = false;
				unePrecioDeListaConImpuestoMonedaReferencia.ReadOnly  = false;

				/*** Para Lista de precios ***/
				unePrecioDeCostoRefLP.ReadOnly = !_uiController.AllowEditPrecioDeCostoRef;
				uneMACLP.ReadOnly = false;
				unePrecioDeVentaNetoLP.ReadOnly = true;
				uneMaxDescuentoLP.ReadOnly = true;
				uneMaxDescuentoPorcentualLP.ReadOnly = true;
				unePrecioVentaBrutoLP.ReadOnly = false;
				unePrecioDeListaConImpuestoLP.ReadOnly  = false;
				unePrecioFinalMonedaReferenciaLP.ReadOnly  = false;
				uneCoeficiente.ReadOnly = false;
				uneCoeficienteMonedaReferencia.ReadOnly = false;
				btnRestablecerAGral.Enabled = true;
				gridListaDePrecios.SetDataBinding(null, null);
                //Sabrina: Tarea 834. 20101004
                /*ArrayList items = new ArrayList();
                businessrules.ListaDePreciosItem item = _uiController.SelectedItem.ListaDePrecios.GetItem(_uiController.SelectedItem.IdProducto, _uiController.IdListaDePrecioSeleccionada);
                items.Add(item);
                gridListaDePrecios.SetDataBinding(items, null);*/
                gridListaDePrecios.SetDataBinding(_uiController.SelectedItem.ListaDePrecios.Items, null);
                //Fin Sabrina: Tarea 834. 20101004


				

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
                    //Sabrina: Tarea 1068. 20110317
                    this.Execute();
                    //Fin Sabrina: Tarea 1068. 20110317
                    break;
				//Matias 20100602 - Tarea 10
				case 4:
					CloseForm();
					break;
				//Fin Matias 20100602 - Tarea 10

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
				_isDirty = true;
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
				unePrecioDeListaConImpuestoMonedaReferencia.ReadOnly = true;

				/*** Para Lista de precios ***/
				unePrecioDeCostoRefLP.ReadOnly = true;
				uneMACLP.ReadOnly = true;
				unePrecioDeVentaNetoLP.ReadOnly = true;
				uneMaxDescuentoLP.ReadOnly = true;
				uneMaxDescuentoPorcentualLP.ReadOnly = true;
				unePrecioVentaBrutoLP.ReadOnly = true;
				unePrecioDeListaConImpuestoLP.ReadOnly = true;
				unePrecioFinalMonedaReferenciaLP.ReadOnly  = true;
				uneCoeficiente.ReadOnly = true;
				uneCoeficienteMonedaReferencia.ReadOnly = true;
				btnRestablecerAGral.Enabled = false;
				gridListaDePrecios.SetDataBinding(null, null);

			}

		}

		private void gridProductos_DeletingRecords(object sender, CancelEventArgs e)
		{
			_isDirty = false;
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
			bool ok = true;
			string errorMessage = "Se deben seleccionar todas las opciones para aplicar una modificación al PVP o de lo contrario no seleccionar Afecta PVP";
			if(chkPrecioDeCosto.Checked && chkAplicaCostoAfectaPVP.Checked)
			{
				if(!(rbAplicaCostoAfectaPVPTodos.Checked || rbAplicaCostoAfectaPVPCondicional.Checked))
					ok = false;
				else 
				{
					if(rbAplicaCostoAfectaPVPTodos.Checked && !(rbAplicaCostoAfectaPVPTodosTrasladaIncremento.Checked || rbAplicaCostoAfectaPVPTodosIgualPVS.Checked))
						ok = false;
					else if(rbAplicaCostoAfectaPVPCondicional.Checked && !(rbAplicaCostoAfectaPVPCondicionalTrasladaIncremento.Checked ||rbAplicaCostoAfectaPVPCondicionalIgualPVS.Checked))
						ok = false;
				}
			}

			if(chkPrecioDeVentaBruto.Checked && rbAplicaPVS.Checked && chkAplicaPVSAfectaPVP.Checked)
			{
				if(!(rbAplicaPVSAfectaPVPTodos.Checked || rbAplicaPVSAfectaPVPCondicional.Checked))
					ok = false;
				else 
				{
					if(rbAplicaPVSAfectaPVPTodos.Checked && !(rbAplicaPVSAfectaPVPTodosTrasladaIncremento.Checked || rbAplicaPVSAfectaPVPTodosIgualPVS.Checked))
						ok = false;
					else if(rbAplicaPVSAfectaPVPCondicional.Checked && !(rbAplicaPVSAfectaPVPCondicionalTrasladaIncremento.Checked ||rbAplicaPVSAfectaPVPCondicionalIgualPVS.Checked))
						ok = false;
				}
			}

			if(chkMAC.Checked && chkAplicaMACAfectaPVP.Checked)
			{
				if(!(rbAplicaMACAfectaPVPTodos.Checked || rbAplicaMACAfectaPVPCondicional.Checked))
					ok = false;
				else 
				{
					if(rbAplicaMACAfectaPVPTodos.Checked && !(rbAplicaMACAfectaPVPTodosTrasladaIncremento.Checked || rbAplicaMACAfectaPVPTodosIgualPVS.Checked))
						ok = false;
					else if(rbAplicaMACAfectaPVPCondicional.Checked && !(rbAplicaMACAfectaPVPCondicionalTrasladaIncremento.Checked ||rbAplicaMACAfectaPVPCondicionalIgualPVS.Checked))
						ok = false;
				}
			}

			if(ok)
			{
				//Sabrina: Tarea 863. 20101109
				ArrayList selectedLP = new ArrayList();
				foreach(mz.erp.businessrules.ListaDePreciosView lp in chkListasDePrecios.CheckedItems)
					selectedLP.Add(lp);
				_uiController.ListasDePreciosSeleccionadas = selectedLP;
				//Fin Sabrina: Tarea 863. 20101109
				string advertencia = _uiController.ActualizarPrecios();
				if(!advertencia.Equals(string.Empty))
					MessageBox.Show(advertencia, "Advertencia",System.Windows.Forms.MessageBoxButtons.OK);
				if(_uiController.PermiteDeshacer)
					utbDeshacer.Enabled = true;
			}
			else
				MessageBox.Show(errorMessage, "Error",  System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

		}

		private void chkPrecioDeCosto_CheckedChanged(object sender, EventArgs e)
		{
			if(chkPrecioDeCosto.Checked)
			{
				chkPrecioDeVentaBruto.Checked = false;
				chkMAC.Checked = false;
				chkMaximoDescuentoPorcentual.Checked = false;
				chkValorConstante.Enabled = true;
				
			}
			chkAplicaCostoAfectaPVP.Enabled = chkPrecioDeCosto.Checked ;
			rbAplicaCostoAfectaPVPCondicional.Enabled = chkPrecioDeCosto.Checked && chkAplicaCostoAfectaPVP.Checked;
			rbAplicaCostoAfectaPVPTodos.Enabled = chkPrecioDeCosto.Checked && chkAplicaCostoAfectaPVP.Checked;
            //German 20101006 - Tarea 860
            rbAplicaCostoAfectaPVPCondicionalIgualPVS.Enabled = chkPrecioDeCosto.Checked && chkAplicaCostoAfectaPVP.Checked && rbAplicaCostoAfectaPVPCondicional.Checked && !_uiController.HabilitaListasDePrecios;
            //Fin German 20101006 - Tarea 860
			rbAplicaCostoAfectaPVPCondicionalTrasladaIncremento.Enabled =  chkPrecioDeCosto.Checked && chkAplicaCostoAfectaPVP.Checked && rbAplicaCostoAfectaPVPCondicional.Checked;
            // German 20101006 - Tarea 860
            rbAplicaCostoAfectaPVPTodosIgualPVS.Enabled = chkPrecioDeCosto.Checked && chkAplicaCostoAfectaPVP.Checked && rbAplicaCostoAfectaPVPTodos.Checked && !_uiController.HabilitaListasDePrecios;
            //Fin German 20101006 - Tarea 860
			rbAplicaCostoAfectaPVPTodosTrasladaIncremento.Enabled =  chkPrecioDeCosto.Checked && chkAplicaCostoAfectaPVP.Checked && rbAplicaCostoAfectaPVPTodos.Checked;
			rbAplicaCostoAfectaPCRTodos.Enabled = chkPrecioDeCosto.Checked;
			rbAplicaCostoAfectaPCRTodosUsaPcioCtoReposicion.Enabled = chkPrecioDeCosto.Checked;
		}

		private void chkAplicaCostoAfectaPVP_CheckedChanged(object sender, EventArgs e)
		{
			rbAplicaCostoAfectaPVPCondicional.Enabled = chkAplicaCostoAfectaPVP.Checked && chkPrecioDeCosto.Checked;
			rbAplicaCostoAfectaPVPTodos.Enabled = chkAplicaCostoAfectaPVP.Checked && chkPrecioDeCosto.Checked;
            //German 20101006 - Tarea 860
            rbAplicaCostoAfectaPVPCondicionalIgualPVS.Enabled = rbAplicaCostoAfectaPVPCondicional.Checked && chkAplicaCostoAfectaPVP.Checked && chkPrecioDeCosto.Checked && !_uiController.HabilitaListasDePrecios;
            //Fin German 20101006 - Tarea 860
			rbAplicaCostoAfectaPVPCondicionalTrasladaIncremento.Enabled = rbAplicaCostoAfectaPVPCondicional.Checked && chkAplicaCostoAfectaPVP.Checked && chkPrecioDeCosto.Checked;
            //German 20101006 - Tarea 860
            rbAplicaCostoAfectaPVPTodosIgualPVS.Enabled = rbAplicaCostoAfectaPVPTodos.Checked && chkAplicaCostoAfectaPVP.Checked && chkPrecioDeCosto.Checked && !_uiController.HabilitaListasDePrecios;
            //Fin German 20101006 - Tarea 860
			rbAplicaCostoAfectaPVPTodosTrasladaIncremento.Enabled = rbAplicaCostoAfectaPVPTodos.Checked && chkAplicaCostoAfectaPVP.Checked && chkPrecioDeCosto.Checked;
		}

		private void chkPrecioDeVentaBruto_CheckedChanged(object sender, EventArgs e)
		{
			if(chkPrecioDeVentaBruto.Checked)
			{
				chkMAC.Checked = false;
				chkPrecioDeCosto.Checked = false;
				chkMaximoDescuentoPorcentual.Checked = false;
				chkValorConstante.Enabled = true;
				//Sabrina: Tarea 863. 20101109
				groupListasDePrecios.Enabled = rbAplicaPVP.Checked || rbAplicaPVPConImpuestos.Checked;
				//Fin Sabrina: Tarea 863. 20101109
			}
			//Sabrina: Tarea 863. 20101109
			else
			{
				groupListasDePrecios.Enabled = false;
			}
			//Fin Sabrina: Tarea 863. 20101109

			rbAplicaPVP.Enabled = chkPrecioDeVentaBruto.Checked;
			rbAplicaPVPConImpuestos.Enabled = chkPrecioDeVentaBruto.Checked;
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
				chkMaximoDescuentoPorcentual.Checked = false;
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
            //Sabrina: Tarea 834. 20101004
            //rbAplicaCostoAfectaPVPCondicionalIgualPVS.Enabled = rbAplicaCostoAfectaPVPCondicional.Checked;
            rbAplicaCostoAfectaPVPCondicionalIgualPVS.Enabled = !_uiController.HabilitaListasDePrecios && rbAplicaCostoAfectaPVPCondicional.Checked;
            //Fin Sabrina: Tarea 834. 20101004		
            //German 20101006 - Tarea 860
            rbAplicaCostoAfectaPVPCondicionalTrasladaIncremento.Enabled = rbAplicaCostoAfectaPVPCondicional.Checked;
            //Fin German 20101006 - Tarea 860
		}

		private void rbAplicaCostoAfectaPVPTodos_CheckedChanged(object sender, EventArgs e)
		{
            //Sabrina: Tarea 834. 20101004
            //rbAplicaCostoAfectaPVPTodosIgualPVS.Enabled = rbAplicaCostoAfectaPVPTodos.Checked;
            rbAplicaCostoAfectaPVPTodosIgualPVS.Enabled = !_uiController.HabilitaListasDePrecios && rbAplicaCostoAfectaPVPTodos.Checked;
            //Fin Sabrina: Tarea 834. 20101004			
            //German 20101006 - Tarea 860
            rbAplicaCostoAfectaPVPTodosTrasladaIncremento.Enabled = rbAplicaCostoAfectaPVPTodos.Checked;
            //Fin German 20101006 - Tarea 860

		}

		private void rbAplicaMACAfectaPVPCondicional_CheckedChanged(object sender, EventArgs e)
		{
			//Sabrina: Tarea 863. 20101109
			//rbAplicaMACAfectaPVPCondicionalIgualPVS.Enabled = rbAplicaMACAfectaPVPCondicional.Checked;
			rbAplicaMACAfectaPVPCondicionalIgualPVS.Enabled = ! _uiController.HabilitaListasDePrecios && rbAplicaMACAfectaPVPCondicional.Checked;
			//Fin Sabrina: Tarea 863. 20101109
			rbAplicaMACAfectaPVPCondicionalTrasladaIncremento.Enabled = rbAplicaMACAfectaPVPCondicional.Checked;
		}

		private void rbAplicaMACAfectaPVPTodos_CheckedChanged(object sender, EventArgs e)
		{
			//Sabrina: Tarea 863. 20101109
			//rbAplicaMACAfectaPVPTodosIgualPVS.Enabled = rbAplicaMACAfectaPVPTodos.Checked;
			rbAplicaMACAfectaPVPTodosIgualPVS.Enabled = ! _uiController.HabilitaListasDePrecios && rbAplicaMACAfectaPVPTodos.Checked;
			//Fin Sabrina: Tarea 863. 20101109
			rbAplicaMACAfectaPVPTodosTrasladaIncremento.Enabled = rbAplicaMACAfectaPVPTodos.Checked;
		}

		private void rbAplicaPVSAfectaPVPCondicional_CheckedChanged(object sender, EventArgs e)
		{
			//Sabrina: Tarea 863. 20101109
			//rbAplicaPVSAfectaPVPCondicionalIgualPVS.Enabled = rbAplicaPVSAfectaPVPCondicional.Checked;
			rbAplicaPVSAfectaPVPCondicionalIgualPVS.Enabled = ! _uiController.HabilitaListasDePrecios && rbAplicaPVSAfectaPVPCondicional.Checked;
			//Fin Sabrina: Tarea 863. 20101109
			rbAplicaPVSAfectaPVPCondicionalTrasladaIncremento.Enabled = rbAplicaPVSAfectaPVPCondicional.Checked;
		}

		private void rbAplicaPVSAfectaPVPTodos_CheckedChanged(object sender, EventArgs e)
		{
			//Sabrina: Tarea 863. 20101109
			//rbAplicaPVSAfectaPVPTodosIgualPVS.Enabled = rbAplicaPVSAfectaPVPTodos.Checked;
			rbAplicaPVSAfectaPVPTodosIgualPVS.Enabled = ! _uiController.HabilitaListasDePrecios && rbAplicaPVSAfectaPVPTodos.Checked;
			//Fin Sabrina: Tarea 863. 20101109
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

		private void _uiController_ProductosCollectionBackChanged(object sender, EventArgs e)
		{
			gridProductos.SelectionChanged -=new EventHandler(gridProductos_SelectionChanged);
			_isDirty = false;
			gridProductos.DataSource = _uiController.Items;
			_isDirty = true;
			gridProductos.SelectionChanged +=new EventHandler(gridProductos_SelectionChanged);
			if(gridProductos.RecordCount > 0)
			{
				gridProductos.Row = 0;
				gridProductos.Select();
				this.gridProductos_SelectionChanged(gridProductos, new EventArgs());
			}
		}

		private void chkMaximoDescuentoPorcentual_CheckedChanged(object sender, EventArgs e)
		{
			if(chkMaximoDescuentoPorcentual.Checked)
			{
				chkPrecioDeVentaBruto.Checked = false;
				chkPrecioDeCosto.Checked = false;
				chkMAC.Checked = false;
				chkValorConstante.Checked = false;
				chkValorConstante.Enabled = false;
				
			}
			rbDescuentoAfectaMac.Enabled = chkMaximoDescuentoPorcentual.Checked;
			rbDescuentoAfectaPVP.Enabled = chkMaximoDescuentoPorcentual.Checked;

		}

		private void gridListaDePrecios_SelectionChanged(object sender, EventArgs e)
		{
			if(gridListaDePrecios.SelectedItems.Count > 0)
			{

				businessrules.ListaDePreciosItem item = (businessrules.ListaDePreciosItem)gridListaDePrecios.SelectedItems[0].GetRow().DataRow;
				_uiController.ListaDePreciosItemSeleccionado = item;

			}
		}

		private void btnRestablecerAGral_Click(object sender, System.EventArgs e)
		{
			if(_uiController.SelectedItem != null)
			{
				if(gridListaDePrecios.SelectedItems.Count > 0)
				{				
					businessrules.ListaDePreciosItem item = (businessrules.ListaDePreciosItem)gridListaDePrecios.SelectedItems[0].GetRow().DataRow;
					if(item.CoeficienteProducto != item.CoeficienteGral)
						_uiController.UpdateCoeficienteToGral();	
				}
			}
		}

		#region Codigo Nuevo

		private void rbPorProducto_CheckedChanged(object sender, EventArgs e)
		{
			groupPorProducto.Visible = true;
			groupPorJerarquia.Visible = false;
			_uiController.PorProducto = true;

		}

		private void rbPorJerarquia_CheckedChanged(object sender, EventArgs e)
		{
			groupPorProducto.Visible = false;
			groupPorJerarquia.Visible = true;
			_uiController.PorProducto = false;

		}
	
		private void hierarchicalSearchControl1_OnSelected(object sender, EventArgs e)
		{

			_uiController.ByJerarquia1 = hierarchicalSearchControl1.NodeChecked1;
			_uiController.Jerarquias1 = hierarchicalSearchControl1.ItemsJerarquia1;
			_uiController.ByJerarquia2 = hierarchicalSearchControl1.NodeChecked2;
			_uiController.Jerarquias2 = hierarchicalSearchControl1.ItemsJerarquia2;
			_uiController.ByJerarquia3 = hierarchicalSearchControl1.NodeChecked3;
			_uiController.Jerarquias3 = hierarchicalSearchControl1.ItemsJerarquia3;
			_uiController.ByJerarquia4 = hierarchicalSearchControl1.NodeChecked4;
			_uiController.Jerarquias4 = hierarchicalSearchControl1.ItemsJerarquia4;
			_uiController.ByJerarquia5 = hierarchicalSearchControl1.NodeChecked5;
			_uiController.Jerarquias5 = hierarchicalSearchControl1.ItemsJerarquia5;
			_uiController.ByJerarquia6 = hierarchicalSearchControl1.NodeChecked6;
			_uiController.Jerarquias6 = hierarchicalSearchControl1.ItemsJerarquia6;
			_uiController.ByJerarquia7 = hierarchicalSearchControl1.NodeChecked7;
			_uiController.Jerarquias7 = hierarchicalSearchControl1.ItemsJerarquia7;
			_uiController.ByJerarquia8 = hierarchicalSearchControl1.NodeChecked8;
			_uiController.Jerarquias8 = hierarchicalSearchControl1.ItemsJerarquia8;			

		}
			

		#endregion

		private void chkUsaPrecioDeCostoReposicion_CheckedChanged(object sender, EventArgs e)
		{
			_uiController.UsaPrecioDeCostoReposicion = chkUsaPrecioDeCostoReposicion.Checked;
		}

		private void chkUsaPrecioDeCostoReposicion1_CheckedChanged(object sender, EventArgs e)
		{
			_uiController.UsaPrecioDeCostoReposicion = chkUsaPrecioDeCostoReposicion1.Checked;
		}

		private void chkCoef1_CheckedChanged(object sender, System.EventArgs e)
		{
			// Activa/Desactiva Costo Indirecto 1
			if ( chkCoef1.Checked )
			{
				_uiController.ActivarCostoIndirecto(1, true); 
				uneCoeficiente1.Enabled = true;				
				if ( !_uiController.CostoIndirectoTipo1 )//CostoIndirecto de tipo Porcentaje
				{
					uneCoeficientePorc1.Enabled = true;
				}								
			}
			else
			{
				_uiController.ActivarCostoIndirecto(1, false);
				uneCoeficiente1.Enabled = false;
				uneCoeficientePorc1.Enabled = false;
			}
		}

		private void chkCoef2_CheckedChanged(object sender, System.EventArgs e)
		{
			if ( chkCoef2.Checked )
			{
				_uiController.ActivarCostoIndirecto(2, true); 
				uneCoeficiente2.Enabled = true;				
				if ( !_uiController.CostoIndirectoTipo2 )
				{
					uneCoeficientePorc2.Enabled = true;
				}								
			}
			else
			{
				_uiController.ActivarCostoIndirecto(2, false);
				uneCoeficiente2.Enabled = false;
				uneCoeficientePorc2.Enabled = false;
			}
		}

		private void chkCoef3_CheckedChanged(object sender, System.EventArgs e)
		{
			if ( chkCoef3.Checked )
			{
				_uiController.ActivarCostoIndirecto(3, true); 
				uneCoeficiente3.Enabled = true;				
				if ( !_uiController.CostoIndirectoTipo3 )
				{
					uneCoeficientePorc3.Enabled = true;
				}								
			}
			else
			{
				_uiController.ActivarCostoIndirecto(3, false);
				uneCoeficiente3.Enabled = false;
				uneCoeficientePorc3.Enabled = false;
			}
		}

		private void chkCoef4_CheckedChanged(object sender, System.EventArgs e)
		{
			if ( chkCoef4.Checked )
			{
				_uiController.ActivarCostoIndirecto(4, true); 
				uneCoeficiente4.Enabled = true;				
				if ( !_uiController.CostoIndirectoTipo4 )
				{
					uneCoeficientePorc4.Enabled = true;
				}								
			}
			else
			{
				_uiController.ActivarCostoIndirecto(4, false);
				uneCoeficiente4.Enabled = false;
				uneCoeficientePorc4.Enabled = false;
			}		
		}

		private void chkCoef5_CheckedChanged(object sender, System.EventArgs e)
		{
			if ( chkCoef5.Checked )
			{
				_uiController.ActivarCostoIndirecto(5, true); 
				uneCoeficiente5.Enabled = true;				
				if ( !_uiController.CostoIndirectoTipo5 )
				{
					uneCoeficientePorc5.Enabled = true;
				}								
			}
			else
			{
				_uiController.ActivarCostoIndirecto(5, false);
				uneCoeficiente5.Enabled = false;
				uneCoeficientePorc5.Enabled = false;
			}
		}

		private void chkCoef6_CheckedChanged(object sender, System.EventArgs e)
		{
			if ( chkCoef6.Checked )
			{
				_uiController.ActivarCostoIndirecto(6, true); 
				uneCoeficiente6.Enabled = true;				
				if ( !_uiController.CostoIndirectoTipo6 )
				{
					uneCoeficientePorc6.Enabled = true;
				}								
			}
			else
			{
				_uiController.ActivarCostoIndirecto(6, false);
				uneCoeficiente6.Enabled = false;
				uneCoeficientePorc6.Enabled = false;
			}		
		}
		private void chkCoef7_CheckedChanged(object sender, System.EventArgs e)
		{
			if ( chkCoef7.Checked )
			{
				_uiController.ActivarCostoIndirecto(7, true); 
				uneCoeficiente7.Enabled = true;				
				if ( !_uiController.CostoIndirectoTipo7 )
				{
					uneCoeficientePorc7.Enabled = true;
				}								
			}
			else
			{
				_uiController.ActivarCostoIndirecto(7, false);
				uneCoeficiente7.Enabled = false;
				uneCoeficientePorc7.Enabled = false;
			}
		}

		private void chkCoef8_CheckedChanged(object sender, System.EventArgs e)
		{
			if ( chkCoef8.Checked )
			{
				_uiController.ActivarCostoIndirecto(8, true); 
				uneCoeficiente8.Enabled = true;				
				if ( !_uiController.CostoIndirectoTipo8 )
				{
					uneCoeficientePorc8.Enabled = true;
				}								
			}
			else
			{
				_uiController.ActivarCostoIndirecto(8, false);
				uneCoeficiente8.Enabled = false;
				uneCoeficientePorc8.Enabled = false;
			}
		}
		private void chkCoef9_CheckedChanged(object sender, System.EventArgs e)
		{
			if ( chkCoef9.Checked )
			{
				_uiController.ActivarCostoIndirecto(9, true); 
				uneCoeficiente9.Enabled = true;				
				if ( !_uiController.CostoIndirectoTipo9 )
				{
					uneCoeficientePorc9.Enabled = true;
				}								
			}
			else
			{
				_uiController.ActivarCostoIndirecto(9, false);
				uneCoeficiente9.Enabled = false;
				uneCoeficientePorc9.Enabled = false;
			}
		}

		private void chkCoef10_CheckedChanged(object sender, System.EventArgs e)
		{
			if ( chkCoef10.Checked )
			{
				_uiController.ActivarCostoIndirecto(10, true); 
				uneCoeficiente10.Enabled = true;				
				if ( !_uiController.CostoIndirectoTipo10 )
				{
					uneCoeficientePorc10.Enabled = true;
				}								
			}
			else
			{
				_uiController.ActivarCostoIndirecto(10, false);
				uneCoeficiente10.Enabled = false;
				uneCoeficientePorc10.Enabled = false;
			}
		}

		private void unePrecioVentaBruto_DoubleClick(object sender, EventArgs e)
		{
			if(!_uiController.PrecioDeVentaAfectaMac)
			{
				_uiController.PrecioDeVentaBruto = (decimal)unePrecioDeVentaNeto.Value;		
				unePrecioVentaBruto.Value = unePrecioDeVentaNeto.Value;		
			}
		}

		//Sabrina: Tarea 863. 20101109
		private void btnTodos_Click(object sender, EventArgs e)
		{
			for(int i = 0; i<chkListasDePrecios.Items.Count; i++)
			{
				chkListasDePrecios.SetItemChecked(i, true);			
			}

		}
		private void btnNinguno_Click(object sender, System.EventArgs e)
		{
			for(int i = 0; i<chkListasDePrecios.Items.Count; i++)
			{
				chkListasDePrecios.SetItemChecked(i, false);			
			}		
		}

		private void btnInvertir_Click(object sender, System.EventArgs e)
		{
			for(int i = 0; i<chkListasDePrecios.Items.Count; i++)
			{
				chkListasDePrecios.SetItemChecked(i, !chkListasDePrecios.GetItemChecked(i));
			}
		}

		private void btnVerSeleccionados_Click(object sender, System.EventArgs e)
		{
			ArrayList selectedLP = new ArrayList();
			foreach(mz.erp.businessrules.ListaDePreciosView lp in chkListasDePrecios.CheckedItems)
				selectedLP.Add(lp);
			chkListasDePrecios.Items.Clear();
			chkListasDePrecios.Items.AddRange(selectedLP.ToArray());
			for(int i = 0; i<chkListasDePrecios.Items.Count; i++)
			{
				chkListasDePrecios.SetItemChecked(i, true);	
			}
		}

		private void btnVerTodas_Click(object sender, System.EventArgs e)
		{
			int i = 0;
			foreach(mz.erp.businessrules.ListaDePreciosView lp in _uiController.ListasDePrecios)
			{
				if(!chkListasDePrecios.Items.Contains(lp))
					chkListasDePrecios.Items.Insert(i, lp);	
				i++;
			}

		}

		private void rbAplicaPVP_CheckedChanged(object sender, EventArgs e)
		{
			groupListasDePrecios.Enabled = rbAplicaPVP.Checked;

		}

		private void rbAplicaPVPConImpuestos_CheckedChanged(object sender, EventArgs e)
		{
			groupListasDePrecios.Enabled = rbAplicaPVPConImpuestos.Checked;

		}
		//Fin Sabrina: Tarea 863. 20101109
	}
}

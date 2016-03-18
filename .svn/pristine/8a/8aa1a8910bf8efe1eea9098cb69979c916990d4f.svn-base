using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using mz.erp.businessrules;
using mz.erp.businessrules.data;
using Infragistics.Win.UltraWinExplorerBar;
using mz.erp.commontypes.data;
using mz.erp.businessrules.comprobantes;
using mz.erp.ui.forms.classes;
//Sabrina: Tarea 1067. 20110311
using mz.erp.commontypes;
//Fin Sabrina: Tarea 1067. 20110311
namespace mz.erp.ui.forms
{
    public class FrmAbmExProductos : mz.erp.ui.forms.FrmABMEx
    {
        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
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
        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkObligaNumeroSerie;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkObligaCodigoBarra;
        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
        private Janus.Windows.GridEX.GridEX gridSucursales;
        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
        private Janus.Windows.GridEX.GridEX gridEX1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private mz.erp.ui.controls.mzComboEditor mzCEBonificacion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.ComponentModel.IContainer components = null;
        private Janus.Windows.GridEX.GridEX gridImpuestos;
        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl6;
        private System.Windows.Forms.GroupBox groupBox2;
        private mz.erp.ui.controls.mzComboEditor mzCEFuenteDeCambioPrecioDeCosto;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private mz.erp.ui.controls.mzComboEditor mzCEMonedaPrecioDeCosto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private mz.erp.ui.controls.mzComboEditor mzCEMoneda;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor ucePercibeIB;
        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl7;
        private System.Windows.Forms.Label label19;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeListaConImpuesto;
        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl8;
        private Janus.Windows.GridEX.GridEX gridProductos;
        private System.Windows.Forms.ImageList imglStandar;
        private Infragistics.Win.Misc.UltraButton btnEliminar;
        private Infragistics.Win.Misc.UltraButton btnCobinar;
        private mz.erp.ui.controls.ToolTipCheckedListBox chkLista;
        private System.Windows.Forms.Button btnBajar;
        private System.Windows.Forms.Button btnSubir;
        private Infragistics.Win.Misc.UltraButton utbEliminarTodos;
        private Infragistics.Win.Misc.UltraButton ubtCopiarCodigoSecundario;
        private System.Windows.Forms.ToolTip toolTip;
        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl9;
        private mz.erp.ui.controls.mzComboEditor mzComboTipoProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCodigoSec;
        private System.Windows.Forms.Label label1;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkActivo;
        private System.Windows.Forms.TextBox txtDescripcionLarga;
        private System.Windows.Forms.TextBox txtDescripcionCorta;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigoSecundario;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label20;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioFinalMonedaReferencia;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneContador;
        private System.Windows.Forms.Label label21;
        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl10;
        private Infragistics.Win.Misc.UltraButton btnFileChooserImagen;
        private System.Windows.Forms.PictureBox pictureBoxThumb;
        private Infragistics.Win.Misc.UltraButton btnFileChooserThumb;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.CheckBox chkThumb;
        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl11;
        private System.Windows.Forms.Label labelCoeficiente5;
        private System.Windows.Forms.Label labelCoeficiente4;
        private System.Windows.Forms.Label labelCoeficiente3;
        private System.Windows.Forms.Label labelCoeficiente1;
        private System.Windows.Forms.Label labelCoeficiente2;
        private System.Windows.Forms.Label labelDefaultCoeficiente1;
        private System.Windows.Forms.Label labelDefaultCoeficiente2;
        private System.Windows.Forms.Label labelDefaultCoeficiente4;
        private System.Windows.Forms.Label labelDefaultCoeficiente3;
        private System.Windows.Forms.Label labelDefaultCoeficiente5;
        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl12;
        private System.Windows.Forms.Label lblEtiquetaCampoAuxiliar1;
        private System.Windows.Forms.Label lblEtiquetaCampoAuxiliar2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtCampoAuxiliar2;
        private System.Windows.Forms.TextBox txtCampoAuxiliar1;
        private System.Windows.Forms.TextBox txtObservaciones;
        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl13;
        private System.Windows.Forms.TextBox txtLink1;
        private System.Windows.Forms.TextBox txtLink5;
        private System.Windows.Forms.TextBox txtLink4;
        private System.Windows.Forms.TextBox txtLink3;
        private System.Windows.Forms.TextBox txtLink2;
        private System.Windows.Forms.Label lblEtiquetaCampoAuxiliar3;
        private System.Windows.Forms.Label lblEtiquetaCampoAuxiliar4;
        private System.Windows.Forms.TextBox txtCampoAuxiliar4;
        private System.Windows.Forms.TextBox txtCampoAuxiliar3;
        private System.Windows.Forms.CheckBox chkImagen1;
        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl14;
        private Janus.Windows.GridEX.GridEX gridListaDePrecios;
        private System.Windows.Forms.Label labelSimboloMonedaPrecioDeCostoReferencia;
        private System.Windows.Forms.Label labelSimboloMonedaPrecioDeVentaNeto;
        private System.Windows.Forms.Label labelSimboloMonedaDescuentoMaximo;
        private System.Windows.Forms.Label labelSimboloMonedaPrecioDeLista;
        private System.Windows.Forms.Label labelSimboloMonedaPrecioDeListaConImpuestos;
        private System.Windows.Forms.Label labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia;
        private System.Windows.Forms.Label labelSimboloMonedaPrecioDeVentaNetoLP;
        private System.Windows.Forms.Label labelSimboloMonedaPrecioDeCostoReferenciaLP;
        private System.Windows.Forms.Label label25;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeCostoRefLP;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label22;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneMACLP;
        private System.Windows.Forms.Label label23;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeVentaNetoLP;
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
        private System.Windows.Forms.Label label36;
        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl15;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox txtCodigoSecundario1;
        private System.Windows.Forms.TextBox txtCodigoSecundario2;
        private System.Windows.Forms.TextBox txtCodigoSecundario3;
        private System.Windows.Forms.TextBox txtCodigoSecundario4;
        private System.Windows.Forms.TextBox txtCodigoSecundario8;
        private System.Windows.Forms.TextBox txtCodigoSecundario7;
        private System.Windows.Forms.TextBox txtCodigoSecundario6;
        private System.Windows.Forms.TextBox txtCodigoSecundario5;
        private System.Windows.Forms.TextBox txtCodigoSecundario12;
        private System.Windows.Forms.TextBox txtCodigoSecundario11;
        private System.Windows.Forms.TextBox txtCodigoSecundario10;
        private System.Windows.Forms.TextBox txtCodigoSecundario9;
        private System.Windows.Forms.TextBox txtCodigoSecundario16;
        private System.Windows.Forms.TextBox txtCodigoSecundario15;
        private System.Windows.Forms.TextBox txtCodigoSecundario14;
        private System.Windows.Forms.TextBox txtCodigoSecundario13;
        private System.Windows.Forms.TextBox txtCodigoSecundario20;
        private System.Windows.Forms.TextBox txtCodigoSecundario19;
        private System.Windows.Forms.TextBox txtCodigoSecundario18;
        private System.Windows.Forms.TextBox txtCodigoSecundario17;
        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl16;
        private mz.erp.ui.controls.mzComboSearchEditor mzCEProveedorCodigo;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox txtCodigoProductoProveedor;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkCodigoSecundarioSegmentado;
        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl18;
        private System.Windows.Forms.GroupBox groupMZ;
        private System.Windows.Forms.Label label62;
        private Infragistics.Win.Misc.UltraLabel ultraLabel12;
        private System.Windows.Forms.Label labelSimboloMonedaPrecioDeCosto3;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePCostoPromedioPonderado;
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
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficiente1;
        private System.Windows.Forms.Label labelPorc1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkUsaPrecioDeCostoReposicion1;
        private System.Windows.Forms.Label labelSimboloMonedaPrecioDeCostoReposicion1;
        private System.Windows.Forms.Label label64;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeCostoReposicion1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel7;
        private System.Windows.Forms.Label labelSimboloMonedaPrecioDeCosto4;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePCostoPromedioPonderado1;
        private System.Windows.Forms.Label labelSimboloMonedaPrecioDeCostoReposicion;
        private mz.erp.ui.controls.HierarchicalSearchControl hierarchicalSearchControl1;
        private mz.erp.ui.controls.GridManagerView gridManagerView1;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeCostoReposicion;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkUsaPrecioDeCostoReposicion;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficientePorc51;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficientePorc41;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficientePorc31;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficientePorc21;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficientePorc11;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficientePorc5;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficientePorc4;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficientePorc3;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficientePorc2;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficientePorc1;
        private System.Windows.Forms.TextBox txtCampoAuxiliar5;
        private System.Windows.Forms.Label lblEtiquetaCampoAuxiliar6;
        private mz.erp.ui.controls.mzSearchTextBox mzSearchTextBox1;
        private System.Windows.Forms.Label lblEtiquetaCampoAuxiliar5;
        private mz.erp.ui.controls.mzProveedoresControl mzCmbProveedores;
        private System.Windows.Forms.CheckBox chckBonificacionesAcumulativas;
        private mz.erp.ui.controls.mzComboEditor mzCEResponsableIngreso;
        private System.Windows.Forms.Label label60;
        private Infragistics.Win.Misc.UltraButton ubVerificar;
        private Label label61;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor fecha;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkEsCombo;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor ultraCheckEditor1;
        private UltraExplorerBarContainerControl ultraExplorerBarContainerControl17;
        private controls.mzProductosControl mzProductosControl;
        private controls.mzComboEditor mzComboListaDePrecios;
        private controls.GridManagerView gridManagerView2;
        private Janus.Windows.GridEX.GridEX gridProductosCombo;
        private Janus.Windows.GridEX.GridEX gridListasDePreciosProductosCombo;
        private controls.GridManagerView gridManagerView3;
        private Janus.Windows.GridEX.GridEX gridEX2;
        private Janus.Windows.GridEX.GridEX gridEX3;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneDescuentoCombo;
        private Label label63;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneDescuentoComboPorcentual;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor une;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneDescuento;
        private Infragistics.Win.Misc.UltraButton btnAplicarDescuento;
        private Infragistics.Win.Misc.UltraButton bAgregarProducto;
        /* Silvina 20110630 - Tarea 0000136 */
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkPermiteCambio;
        private UltraExplorerBarContainerControl ultraExplorerBarContainerControl19;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private controls.mzProveedoresControl mzProveedoresControl;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.Misc.UltraButton btnAgregarProveedor;
        private controls.mzProveedoresControl mzCmb;
        private controls.GridManagerView gridManagerView4;
        private Janus.Windows.GridEX.GridEX gridCodigosProductosProveedores;
        private ToolBarButton tbCargarPrecio;
        private ToolBarButton tbSeparador;
        /* Fin Silvina 20110630 - Tarea 0000136 */

        private tsh_ProductosEx.ControladorProductos _uiController;
        public FrmAbmExProductos()
        {
            // Llamada necesaria para el Diseñador de Windows Forms.
            InitializeComponent();

            // TODO: agregar cualquier inicialización después de llamar a InitializeComponent

            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ultraExplorerBar1.PerformKeyAction(UltraExplorerBarAction.EditActiveGroup, false, false);
            UltraExplorerBarKeyActionMapping myKeyActionMapping =
            new UltraExplorerBarKeyActionMapping(Keys.F10,
            UltraExplorerBarAction.ScrollPageDown,
            UltraExplorerBarStates.ListbarMode,
            UltraExplorerBarStates.InEditMode,
            0,
            0);


            this.ultraExplorerBar1.KeyActionMappings.Add(myKeyActionMapping);
            /*
            MouseHelper mouseControler = new MouseHelper();
            mouseControler.Control = ultraExplorerBar1;
            mouseControler.WheelBackward+=new MouseEventHandler(ScrollDown);
            mouseControler.WheelForward += new MouseEventHandler(ScrollUp);
            */


            uneMAC.Enter += new EventHandler(On_Enter);
            uneMaxDescuento.Enter += new EventHandler(On_Enter);
            uneMaxDescuentoPorcentual.Enter += new EventHandler(On_Enter);
            unePrecioDeCostoRef.Enter += new EventHandler(On_Enter);
            unePrecioDeVentaNeto.Enter += new EventHandler(On_Enter);
            unePrecioVentaBruto.Enter += new EventHandler(On_Enter);
            unePrecioFinalMonedaReferencia.Enter += new EventHandler(On_Enter);
            unePrecioDeListaConImpuesto.Enter += new EventHandler(On_Enter);

            unePrecioDeCostoRefLP.Enter += new EventHandler(On_Enter);
            uneMACLP.Enter += new EventHandler(On_Enter);
            unePrecioDeVentaNetoLP.Enter += new EventHandler(On_Enter);
            uneMaxDescuentoLP.Enter += new EventHandler(On_Enter);
            uneMaxDescuentoPorcentualLP.Enter += new EventHandler(On_Enter);
            unePrecioVentaBrutoLP.Enter += new EventHandler(On_Enter);
            unePrecioDeListaConImpuestoLP.Enter += new EventHandler(On_Enter);
            unePrecioFinalMonedaReferenciaLP.Enter += new EventHandler(On_Enter);
            uneCoeficiente.Enter += new EventHandler(On_Enter);
            uneCoeficienteMonedaReferencia.Enter += new EventHandler(On_Enter);

            //Sabrina: tarea 56
            unePCostoPromedioPonderado.Enter += new EventHandler(On_Enter);
            unePCostoPromedioPonderado1.Enter += new EventHandler(On_Enter);
            unePrecioDeCostoReposicion.Enter += new EventHandler(On_Enter);
            unePrecioDeCostoReposicion1.Enter += new EventHandler(On_Enter);
            uneCoeficiente1.Enter += new EventHandler(On_Enter);
            uneCoeficiente2.Enter += new EventHandler(On_Enter);
            uneCoeficiente3.Enter += new EventHandler(On_Enter);
            uneCoeficiente4.Enter += new EventHandler(On_Enter);
            uneCoeficiente5.Enter += new EventHandler(On_Enter);
            uneCoeficientePorc1.Enter += new EventHandler(On_Enter);
            uneCoeficientePorc2.Enter += new EventHandler(On_Enter);
            uneCoeficientePorc3.Enter += new EventHandler(On_Enter);
            uneCoeficientePorc4.Enter += new EventHandler(On_Enter);
            uneCoeficientePorc5.Enter += new EventHandler(On_Enter);

            this.mzCEResponsableIngreso.Leave += new EventHandler(mzCEResponsableIngreso_Change);
            /* Silvina 20101115 - Tarea 930 */
            fecha.Enabled = false;
            /* Fin Silvina */
        }

        private void ScrollDown(object sender, MouseEventArgs e)
        {
            ultraExplorerBar1.PerformAction(UltraExplorerBarAction.ScrollPageDown);

        }

        private void ScrollUp(object sender, MouseEventArgs e)
        {
            ultraExplorerBar1.PerformAction(UltraExplorerBarAction.ScrollPageUp);
        }

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
                mz.erp.commontypes.BindingController.Clear(mzCEMoneda, "Value", _uiController, "IdMonedaCierrePrecioDeVentaBruto");
                mz.erp.commontypes.BindingController.Clear(mzCEMonedaPrecioDeCosto, "Value", _uiController, "IdMonedaCierrePrecioDeCostoRef");
                mz.erp.commontypes.BindingController.Clear(mzCEFuenteDeCambioPrecioDeCosto, "Value", _uiController, "IdFuenteDeCambioPrecioDeCostoRef");
                this.mzCEResponsableIngreso.Leave -= new EventHandler(mzCEResponsableIngreso_Change);


            }
            base.Dispose(disposing);
        }

        #region Código generado por el diseñador
        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup6 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup7 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup8 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup9 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup10 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup11 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup12 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup13 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup14 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup15 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup16 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup17 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup18 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            this.ultraExplorerBarContainerControl9 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.chkPermiteCambio = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.chkEsCombo = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.fecha = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.label61 = new System.Windows.Forms.Label();
            this.ubVerificar = new Infragistics.Win.Misc.UltraButton();
            this.mzCEResponsableIngreso = new mz.erp.ui.controls.mzComboEditor();
            this.label60 = new System.Windows.Forms.Label();
            this.chckBonificacionesAcumulativas = new System.Windows.Forms.CheckBox();
            this.mzCmbProveedores = new mz.erp.ui.controls.mzProveedoresControl();
            this.label36 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.mzComboTipoProducto = new mz.erp.ui.controls.mzComboEditor();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCodigoSec = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkActivo = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.txtDescripcionLarga = new System.Windows.Forms.TextBox();
            this.txtDescripcionCorta = new System.Windows.Forms.TextBox();
            this.txtCodigoSecundario = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.ultraExplorerBarContainerControl15 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.label53 = new System.Windows.Forms.Label();
            this.txtCodigoSecundario20 = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.txtCodigoSecundario19 = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.txtCodigoSecundario18 = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.txtCodigoSecundario17 = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.txtCodigoSecundario16 = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.txtCodigoSecundario15 = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.txtCodigoSecundario14 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.txtCodigoSecundario13 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.txtCodigoSecundario12 = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.txtCodigoSecundario11 = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.txtCodigoSecundario10 = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.txtCodigoSecundario9 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txtCodigoSecundario8 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.txtCodigoSecundario7 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.txtCodigoSecundario6 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txtCodigoSecundario5 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txtCodigoSecundario4 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txtCodigoSecundario3 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txtCodigoSecundario2 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.txtCodigoSecundario1 = new System.Windows.Forms.TextBox();
            this.ultraExplorerBarContainerControl19 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.gridCodigosProductosProveedores = new Janus.Windows.GridEX.GridEX();
            this.gridManagerView4 = new mz.erp.ui.controls.GridManagerView();
            this.btnAgregarProveedor = new Infragistics.Win.Misc.UltraButton();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.mzProveedoresControl = new mz.erp.ui.controls.mzProveedoresControl();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraExplorerBarContainerControl12 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.mzSearchTextBox1 = new mz.erp.ui.controls.mzSearchTextBox();
            this.lblEtiquetaCampoAuxiliar6 = new System.Windows.Forms.Label();
            this.lblEtiquetaCampoAuxiliar5 = new System.Windows.Forms.Label();
            this.txtCampoAuxiliar5 = new System.Windows.Forms.TextBox();
            this.lblEtiquetaCampoAuxiliar3 = new System.Windows.Forms.Label();
            this.lblEtiquetaCampoAuxiliar4 = new System.Windows.Forms.Label();
            this.txtCampoAuxiliar4 = new System.Windows.Forms.TextBox();
            this.txtCampoAuxiliar3 = new System.Windows.Forms.TextBox();
            this.lblEtiquetaCampoAuxiliar1 = new System.Windows.Forms.Label();
            this.lblEtiquetaCampoAuxiliar2 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtCampoAuxiliar2 = new System.Windows.Forms.TextBox();
            this.txtCampoAuxiliar1 = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.ultraExplorerBarContainerControl7 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.hierarchicalSearchControl1 = new mz.erp.ui.controls.HierarchicalSearchControl();
            this.ultraExplorerBarContainerControl8 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.ubtCopiarCodigoSecundario = new Infragistics.Win.Misc.UltraButton();
            this.utbEliminarTodos = new Infragistics.Win.Misc.UltraButton();
            this.btnSubir = new System.Windows.Forms.Button();
            this.imglStandar = new System.Windows.Forms.ImageList(this.components);
            this.btnBajar = new System.Windows.Forms.Button();
            this.chkLista = new mz.erp.ui.controls.ToolTipCheckedListBox();
            this.gridProductos = new Janus.Windows.GridEX.GridEX();
            this.btnEliminar = new Infragistics.Win.Misc.UltraButton();
            this.btnCobinar = new Infragistics.Win.Misc.UltraButton();
            this.ultraExplorerBarContainerControl18 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.groupMZ = new System.Windows.Forms.GroupBox();
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.unePCostoPromedioPonderado = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label62 = new System.Windows.Forms.Label();
            this.unePrecioDeCostoReposicion = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraLabel12 = new Infragistics.Win.Misc.UltraLabel();
            this.labelSimboloMonedaPrecioDeCostoReposicion = new System.Windows.Forms.Label();
            this.labelSimboloMonedaPrecioDeCosto3 = new System.Windows.Forms.Label();
            this.chkUsaPrecioDeCostoReposicion = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.ultraExplorerBarContainerControl17 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.btnAplicarDescuento = new Infragistics.Win.Misc.UltraButton();
            this.label63 = new System.Windows.Forms.Label();
            this.uneDescuentoCombo = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.gridListasDePreciosProductosCombo = new Janus.Windows.GridEX.GridEX();
            this.gridManagerView3 = new mz.erp.ui.controls.GridManagerView();
            this.gridManagerView2 = new mz.erp.ui.controls.GridManagerView();
            this.gridProductosCombo = new Janus.Windows.GridEX.GridEX();
            this.mzComboListaDePrecios = new mz.erp.ui.controls.mzComboEditor();
            this.mzProductosControl = new mz.erp.ui.controls.mzProductosControl();
            this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.unePrecioDeCostoRef = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneMAC = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.unePrecioDeVentaNeto = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.unePCostoPromedioPonderado1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.unePrecioDeCostoReposicion1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.chkUsaPrecioDeCostoReposicion1 = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.labelSimboloMonedaPrecioDeCostoReposicion1 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
            this.labelSimboloMonedaPrecioDeCosto4 = new System.Windows.Forms.Label();
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia = new System.Windows.Forms.Label();
            this.labelSimboloMonedaPrecioDeListaConImpuestos = new System.Windows.Forms.Label();
            this.labelSimboloMonedaPrecioDeLista = new System.Windows.Forms.Label();
            this.labelSimboloMonedaDescuentoMaximo = new System.Windows.Forms.Label();
            this.labelSimboloMonedaPrecioDeVentaNeto = new System.Windows.Forms.Label();
            this.labelSimboloMonedaPrecioDeCostoReferencia = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.unePrecioFinalMonedaReferencia = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label19 = new System.Windows.Forms.Label();
            this.unePrecioDeListaConImpuesto = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.unePrecioVentaBruto = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label12 = new System.Windows.Forms.Label();
            this.uneMaxDescuento = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label11 = new System.Windows.Forms.Label();
            this.uneMaxDescuentoPorcentual = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl14 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
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
            this.labelSimboloMonedaPrecioDeVentaNetoLP = new System.Windows.Forms.Label();
            this.labelSimboloMonedaPrecioDeCostoReferenciaLP = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.unePrecioDeCostoRefLP = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label26 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.uneMACLP = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label23 = new System.Windows.Forms.Label();
            this.unePrecioDeVentaNetoLP = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.gridListaDePrecios = new Janus.Windows.GridEX.GridEX();
            this.ultraExplorerBarContainerControl11 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.labelDefaultCoeficiente5 = new System.Windows.Forms.Label();
            this.labelDefaultCoeficiente4 = new System.Windows.Forms.Label();
            this.labelDefaultCoeficiente3 = new System.Windows.Forms.Label();
            this.labelDefaultCoeficiente2 = new System.Windows.Forms.Label();
            this.labelDefaultCoeficiente1 = new System.Windows.Forms.Label();
            this.labelCoeficiente5 = new System.Windows.Forms.Label();
            this.labelCoeficiente4 = new System.Windows.Forms.Label();
            this.labelCoeficiente3 = new System.Windows.Forms.Label();
            this.uneCoeficientePorc51 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneCoeficientePorc41 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneCoeficientePorc31 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneCoeficientePorc21 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneCoeficientePorc11 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.labelCoeficiente1 = new System.Windows.Forms.Label();
            this.labelCoeficiente2 = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.chkCodigoSecundarioSegmentado = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.label21 = new System.Windows.Forms.Label();
            this.uneContador = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ucePercibeIB = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.gridImpuestos = new Janus.Windows.GridEX.GridEX();
            this.chkObligaNumeroSerie = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.chkObligaCodigoBarra = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.ultraExplorerBarContainerControl6 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mzCEFuenteDeCambioPrecioDeCosto = new mz.erp.ui.controls.mzComboEditor();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.mzCEMonedaPrecioDeCosto = new mz.erp.ui.controls.mzComboEditor();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mzCEMoneda = new mz.erp.ui.controls.mzComboEditor();
            this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.gridSucursales = new Janus.Windows.GridEX.GridEX();
            this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.mzCEBonificacion = new mz.erp.ui.controls.mzComboEditor();
            this.ultraExplorerBarContainerControl13 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.txtLink5 = new System.Windows.Forms.TextBox();
            this.txtLink4 = new System.Windows.Forms.TextBox();
            this.txtLink3 = new System.Windows.Forms.TextBox();
            this.txtLink2 = new System.Windows.Forms.TextBox();
            this.txtLink1 = new System.Windows.Forms.TextBox();
            this.ultraExplorerBarContainerControl10 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.chkImagen1 = new System.Windows.Forms.CheckBox();
            this.chkThumb = new System.Windows.Forms.CheckBox();
            this.btnFileChooserThumb = new Infragistics.Win.Misc.UltraButton();
            this.pictureBoxThumb = new System.Windows.Forms.PictureBox();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.btnFileChooserImagen = new Infragistics.Win.Misc.UltraButton();
            this.ultraExplorerBarContainerControl16 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.label58 = new System.Windows.Forms.Label();
            this.txtCodigoProductoProveedor = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.ultraCheckEditor1 = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.gridEX2 = new Janus.Windows.GridEX.GridEX();
            this.gridEX3 = new Janus.Windows.GridEX.GridEX();
            this.uneDescuentoComboPorcentual = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.une = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneDescuento = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.bAgregarProducto = new Infragistics.Win.Misc.UltraButton();
            this.mzCmb = new mz.erp.ui.controls.mzProveedoresControl();
            this.tbCargarPrecio = new System.Windows.Forms.ToolBarButton();
            this.tbSeparador = new System.Windows.Forms.ToolBarButton();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
            this.ultraExplorerBar1.SuspendLayout();
            this.ultraExplorerBarContainerControl9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEResponsableIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzComboTipoProducto)).BeginInit();
            this.ultraExplorerBarContainerControl15.SuspendLayout();
            this.ultraExplorerBarContainerControl19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCodigosProductosProveedores)).BeginInit();
            this.ultraExplorerBarContainerControl12.SuspendLayout();
            this.ultraExplorerBarContainerControl7.SuspendLayout();
            this.ultraExplorerBarContainerControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.ultraExplorerBarContainerControl18.SuspendLayout();
            this.groupMZ.SuspendLayout();
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
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unePCostoPromedioPonderado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoReposicion)).BeginInit();
            this.ultraExplorerBarContainerControl17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneDescuentoCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListasDePreciosProductosCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductosCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzComboListaDePrecios)).BeginInit();
            this.ultraExplorerBarContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoRef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMAC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeVentaNeto)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unePCostoPromedioPonderado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoReposicion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioFinalMonedaReferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeListaConImpuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioVentaBruto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuentoPorcentual)).BeginInit();
            this.ultraExplorerBarContainerControl14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioFinalMonedaReferenciaLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeListaConImpuestoLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioVentaBrutoLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuentoLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuentoPorcentualLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficienteMonedaReferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoRefLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMACLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeVentaNetoLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaDePrecios)).BeginInit();
            this.ultraExplorerBarContainerControl11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc11)).BeginInit();
            this.ultraExplorerBarContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneContador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridImpuestos)).BeginInit();
            this.ultraExplorerBarContainerControl6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEFuenteDeCambioPrecioDeCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEMonedaPrecioDeCosto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEMoneda)).BeginInit();
            this.ultraExplorerBarContainerControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSucursales)).BeginInit();
            this.ultraExplorerBarContainerControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEBonificacion)).BeginInit();
            this.ultraExplorerBarContainerControl13.SuspendLayout();
            this.ultraExplorerBarContainerControl10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThumb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.ultraExplorerBarContainerControl16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneDescuentoComboPorcentual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.une)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneDescuento)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBarStandar
            // 
            this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbSeparador,
            this.tbCargarPrecio});
            this.toolBarStandar.Size = new System.Drawing.Size(968, 28);
            this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
            // 
            // ultraExplorerBar1
            // 
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl6);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl7);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl8);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl9);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl10);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl11);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl12);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl13);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl14);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl15);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl16);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl18);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl17);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl19);
            ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl9;
            ultraExplorerBarGroup1.Key = "DatosGenerales";
            ultraExplorerBarGroup1.Settings.ContainerHeight = 209;
            ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup1.Text = "Datos Generales";
            ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl15;
            ultraExplorerBarGroup2.Key = "CodigosSecundarios";
            ultraExplorerBarGroup2.Settings.ContainerHeight = 182;
            ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup2.Text = "Códigos Secundarios";
            ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl19;
            ultraExplorerBarGroup3.Key = "Proveedores";
            ultraExplorerBarGroup3.Settings.ContainerHeight = 190;
            ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup3.Text = "Proveedores";
            ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl12;
            ultraExplorerBarGroup4.Key = "Informacion";
            ultraExplorerBarGroup4.Settings.ContainerHeight = 204;
            ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup4.Text = "Información adicional";
            ultraExplorerBarGroup5.Container = this.ultraExplorerBarContainerControl7;
            ultraExplorerBarGroup5.Key = "Jerarquias";
            ultraExplorerBarGroup5.Settings.ContainerHeight = 141;
            ultraExplorerBarGroup5.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup5.Text = "Jerarquias";
            ultraExplorerBarGroup6.Container = this.ultraExplorerBarContainerControl8;
            ultraExplorerBarGroup6.Key = "GeneracionMasiva";
            ultraExplorerBarGroup6.Settings.ContainerHeight = 208;
            ultraExplorerBarGroup6.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup6.Text = "Generación Masiva";
            ultraExplorerBarGroup7.Container = this.ultraExplorerBarContainerControl18;
            ultraExplorerBarGroup7.Key = "DatosCompra";
            ultraExplorerBarGroup7.Settings.ContainerHeight = 207;
            ultraExplorerBarGroup7.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup7.Text = "Costos";
            ultraExplorerBarGroup8.Container = this.ultraExplorerBarContainerControl17;
            ultraExplorerBarGroup8.Key = "ProductosCombo";
            ultraExplorerBarGroup8.Settings.ContainerHeight = 496;
            ultraExplorerBarGroup8.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup8.Text = "Productos Combo";
            ultraExplorerBarGroup9.Container = this.ultraExplorerBarContainerControl2;
            ultraExplorerBarGroup9.Key = "Precios";
            ultraExplorerBarGroup9.Settings.ContainerHeight = 196;
            ultraExplorerBarGroup9.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup9.Text = "Precios de Venta y Utilidad";
            ultraExplorerBarGroup10.Container = this.ultraExplorerBarContainerControl14;
            ultraExplorerBarGroup10.Key = "ListaDePrecios";
            ultraExplorerBarGroup10.Settings.ContainerHeight = 346;
            ultraExplorerBarGroup10.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup10.Text = "Lista de Precios de Venta y Utilidades";
            ultraExplorerBarGroup11.Container = this.ultraExplorerBarContainerControl11;
            ultraExplorerBarGroup11.Key = "CoeficientesPrecioDeCosto";
            ultraExplorerBarGroup11.Settings.ContainerHeight = 122;
            ultraExplorerBarGroup11.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup11.Text = "Coeficientes Precio de Costo";
            ultraExplorerBarGroup12.Container = this.ultraExplorerBarContainerControl3;
            ultraExplorerBarGroup12.Key = "Avanzadas";
            ultraExplorerBarGroup12.Settings.ContainerHeight = 135;
            ultraExplorerBarGroup12.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup12.Text = "Avanzadas";
            ultraExplorerBarGroup13.Container = this.ultraExplorerBarContainerControl6;
            ultraExplorerBarGroup13.Key = "Monedas";
            ultraExplorerBarGroup13.Settings.ContainerHeight = 150;
            ultraExplorerBarGroup13.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup13.Text = "Monedas";
            ultraExplorerBarGroup14.Container = this.ultraExplorerBarContainerControl4;
            ultraExplorerBarGroup14.Key = "Sucursales";
            ultraExplorerBarGroup14.Settings.ContainerHeight = 193;
            ultraExplorerBarGroup14.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup14.Text = "Productos por Sucursal";
            ultraExplorerBarGroup15.Container = this.ultraExplorerBarContainerControl5;
            ultraExplorerBarGroup15.Key = "Bonificaciones";
            ultraExplorerBarGroup15.Settings.ContainerHeight = 155;
            ultraExplorerBarGroup15.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup15.Text = "Bonificacion";
            ultraExplorerBarGroup16.Container = this.ultraExplorerBarContainerControl13;
            ultraExplorerBarGroup16.Key = "Links";
            ultraExplorerBarGroup16.Settings.ContainerHeight = 135;
            ultraExplorerBarGroup16.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup16.Text = "Links";
            ultraExplorerBarGroup17.Container = this.ultraExplorerBarContainerControl10;
            ultraExplorerBarGroup17.Key = "Imagenes";
            ultraExplorerBarGroup17.Settings.ContainerHeight = 320;
            ultraExplorerBarGroup17.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup17.Text = "Imagenes";
            ultraExplorerBarGroup18.Container = this.ultraExplorerBarContainerControl16;
            ultraExplorerBarGroup18.Key = "CodigoPorProveedor";
            ultraExplorerBarGroup18.Settings.ContainerHeight = 221;
            ultraExplorerBarGroup18.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup18.Text = "Codigos Por Proveedor";
            this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2,
            ultraExplorerBarGroup3,
            ultraExplorerBarGroup4,
            ultraExplorerBarGroup5,
            ultraExplorerBarGroup6,
            ultraExplorerBarGroup7,
            ultraExplorerBarGroup8,
            ultraExplorerBarGroup9,
            ultraExplorerBarGroup10,
            ultraExplorerBarGroup11,
            ultraExplorerBarGroup12,
            ultraExplorerBarGroup13,
            ultraExplorerBarGroup14,
            ultraExplorerBarGroup15,
            ultraExplorerBarGroup16,
            ultraExplorerBarGroup17,
            ultraExplorerBarGroup18});
            this.ultraExplorerBar1.GroupSettings.ForceSerialization = true;
            this.ultraExplorerBar1.ItemSettings.ForceSerialization = true;
            this.ultraExplorerBar1.Margins.ForceSerialization = true;
            this.ultraExplorerBar1.Size = new System.Drawing.Size(968, 488);
            this.ultraExplorerBar1.ItemClick += new Infragistics.Win.UltraWinExplorerBar.ItemClickEventHandler(this.ultraExplorerBar1_ItemClick);
            this.ultraExplorerBar1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ultraExplorerBar1_KeyDown);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl19, 0);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl17, 0);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl18, 0);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl16, 0);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl15, 0);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl14, 0);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl13, 0);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl12, 0);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl11, 0);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl10, 0);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl9, 0);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl8, 0);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl7, 0);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl6, 0);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl5, 0);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl4, 0);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl3, 0);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl2, 0);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl1, 0);
            // 
            // ultraExplorerBarContainerControl1
            // 
            this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 50);
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(898, 180);
            // 
            // ultraExplorerBarContainerControl9
            // 
            this.ultraExplorerBarContainerControl9.Controls.Add(this.chkPermiteCambio);
            this.ultraExplorerBarContainerControl9.Controls.Add(this.chkEsCombo);
            this.ultraExplorerBarContainerControl9.Controls.Add(this.fecha);
            this.ultraExplorerBarContainerControl9.Controls.Add(this.label61);
            this.ultraExplorerBarContainerControl9.Controls.Add(this.ubVerificar);
            this.ultraExplorerBarContainerControl9.Controls.Add(this.mzCEResponsableIngreso);
            this.ultraExplorerBarContainerControl9.Controls.Add(this.label60);
            this.ultraExplorerBarContainerControl9.Controls.Add(this.chckBonificacionesAcumulativas);
            this.ultraExplorerBarContainerControl9.Controls.Add(this.mzCmbProveedores);
            this.ultraExplorerBarContainerControl9.Controls.Add(this.label36);
            this.ultraExplorerBarContainerControl9.Controls.Add(this.txtDescripcion);
            this.ultraExplorerBarContainerControl9.Controls.Add(this.mzComboTipoProducto);
            this.ultraExplorerBarContainerControl9.Controls.Add(this.label9);
            this.ultraExplorerBarContainerControl9.Controls.Add(this.label5);
            this.ultraExplorerBarContainerControl9.Controls.Add(this.label4);
            this.ultraExplorerBarContainerControl9.Controls.Add(this.label3);
            this.ultraExplorerBarContainerControl9.Controls.Add(this.labelCodigoSec);
            this.ultraExplorerBarContainerControl9.Controls.Add(this.label1);
            this.ultraExplorerBarContainerControl9.Controls.Add(this.chkActivo);
            this.ultraExplorerBarContainerControl9.Controls.Add(this.txtDescripcionLarga);
            this.ultraExplorerBarContainerControl9.Controls.Add(this.txtDescripcionCorta);
            this.ultraExplorerBarContainerControl9.Controls.Add(this.txtCodigoSecundario);
            this.ultraExplorerBarContainerControl9.Controls.Add(this.txtCodigo);
            this.ultraExplorerBarContainerControl9.Location = new System.Drawing.Point(28, 290);
            this.ultraExplorerBarContainerControl9.Name = "ultraExplorerBarContainerControl9";
            this.ultraExplorerBarContainerControl9.Size = new System.Drawing.Size(898, 209);
            this.ultraExplorerBarContainerControl9.TabIndex = 0;
            // 
            // chkPermiteCambio
            // 
            this.chkPermiteCambio.BackColor = System.Drawing.Color.Transparent;
            this.chkPermiteCambio.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkPermiteCambio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPermiteCambio.Checked = true;
            this.chkPermiteCambio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPermiteCambio.Location = new System.Drawing.Point(143, 186);
            this.chkPermiteCambio.Name = "chkPermiteCambio";
            this.chkPermiteCambio.Size = new System.Drawing.Size(125, 23);
            this.chkPermiteCambio.TabIndex = 166;
            this.chkPermiteCambio.Text = "Permite Cambio";
            // 
            // chkEsCombo
            // 
            this.chkEsCombo.BackColor = System.Drawing.Color.Transparent;
            this.chkEsCombo.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkEsCombo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkEsCombo.Location = new System.Drawing.Point(4, 186);
            this.chkEsCombo.Name = "chkEsCombo";
            this.chkEsCombo.Size = new System.Drawing.Size(124, 23);
            this.chkEsCombo.TabIndex = 165;
            this.chkEsCombo.Text = "Es Combo";
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(842, -1);
            this.fecha.Name = "fecha";
            this.fecha.NullText = "none";
            this.fecha.Size = new System.Drawing.Size(173, 24);
            this.fecha.TabIndex = 164;
            this.fecha.Value = null;
            // 
            // label61
            // 
            this.label61.BackColor = System.Drawing.Color.Transparent;
            this.label61.Location = new System.Drawing.Point(708, -1);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(144, 16);
            this.label61.TabIndex = 94;
            this.label61.Text = "Fecha de alta";
            // 
            // ubVerificar
            // 
            this.ubVerificar.AcceptsFocus = false;
            this.ubVerificar.Location = new System.Drawing.Point(320, -1);
            this.ubVerificar.Name = "ubVerificar";
            this.ubVerificar.Size = new System.Drawing.Size(64, 28);
            this.ubVerificar.TabIndex = 1;
            this.ubVerificar.TabStop = false;
            this.ubVerificar.Text = "Verificar";
            // 
            // mzCEResponsableIngreso
            // 
            this.mzCEResponsableIngreso.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEResponsableIngreso.DisplayMember = "";
            this.mzCEResponsableIngreso.DisplayMemberCaption = "";
            this.mzCEResponsableIngreso.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEResponsableIngreso.Location = new System.Drawing.Point(842, 20);
            this.mzCEResponsableIngreso.MaxItemsDisplay = 8;
            this.mzCEResponsableIngreso.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEResponsableIngreso.Name = "mzCEResponsableIngreso";
            this.mzCEResponsableIngreso.Size = new System.Drawing.Size(173, 24);
            this.mzCEResponsableIngreso.SorterMember = "";
            this.mzCEResponsableIngreso.TabIndex = 5;
            this.mzCEResponsableIngreso.ValueMember = "";
            this.mzCEResponsableIngreso.ValueMemberCaption = "";
            // 
            // label60
            // 
            this.label60.BackColor = System.Drawing.Color.Transparent;
            this.label60.Location = new System.Drawing.Point(708, 23);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(144, 16);
            this.label60.TabIndex = 93;
            this.label60.Text = "Responsable de alta";
            // 
            // chckBonificacionesAcumulativas
            // 
            this.chckBonificacionesAcumulativas.BackColor = System.Drawing.Color.Transparent;
            this.chckBonificacionesAcumulativas.Location = new System.Drawing.Point(727, 162);
            this.chckBonificacionesAcumulativas.Name = "chckBonificacionesAcumulativas";
            this.chckBonificacionesAcumulativas.Size = new System.Drawing.Size(221, 24);
            this.chckBonificacionesAcumulativas.TabIndex = 11;
            this.chckBonificacionesAcumulativas.Text = "Bonificaciones acumulativas";
            this.chckBonificacionesAcumulativas.UseVisualStyleBackColor = false;
            // 
            // mzCmbProveedores
            // 
            this.mzCmbProveedores.BackColor = System.Drawing.SystemColors.Control;
            this.mzCmbProveedores.DataValue = "";
            this.mzCmbProveedores.EnableCtaCte = false;
            this.mzCmbProveedores.FastSearch = false;
            this.mzCmbProveedores.Location = new System.Drawing.Point(125, 160);
            this.mzCmbProveedores.Name = "mzCmbProveedores";
            this.mzCmbProveedores.SearchObjectListener = null;
            this.mzCmbProveedores.Size = new System.Drawing.Size(595, 26);
            this.mzCmbProveedores.TabIndex = 9;
            this.mzCmbProveedores.Tag = "ResponsableEmision";
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Location = new System.Drawing.Point(0, 162);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(120, 23);
            this.label36.TabIndex = 39;
            this.label36.Text = "Proveedor Default";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(125, 45);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(893, 38);
            this.txtDescripcion.TabIndex = 6;
            this.txtDescripcion.Text = "TEXTBOX3";
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // mzComboTipoProducto
            // 
            this.mzComboTipoProducto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzComboTipoProducto.DisplayMember = "";
            this.mzComboTipoProducto.DisplayMemberCaption = "";
            this.mzComboTipoProducto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzComboTipoProducto.Location = new System.Drawing.Point(498, 18);
            this.mzComboTipoProducto.MaxItemsDisplay = 7;
            this.mzComboTipoProducto.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzComboTipoProducto.Name = "mzComboTipoProducto";
            this.mzComboTipoProducto.Size = new System.Drawing.Size(173, 24);
            this.mzComboTipoProducto.SorterMember = "";
            this.mzComboTipoProducto.TabIndex = 4;
            this.mzComboTipoProducto.ValueMember = "";
            this.mzComboTipoProducto.ValueMemberCaption = "";
            this.mzComboTipoProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(364, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 19);
            this.label9.TabIndex = 38;
            this.label9.Text = "Tipo de Producto";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(0, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "Descripción Corta";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(0, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 36;
            this.label4.Text = "Descripción Larga";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(0, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "Descripción";
            // 
            // labelCodigoSec
            // 
            this.labelCodigoSec.BackColor = System.Drawing.Color.Transparent;
            this.labelCodigoSec.Location = new System.Drawing.Point(0, 23);
            this.labelCodigoSec.Name = "labelCodigoSec";
            this.labelCodigoSec.Size = new System.Drawing.Size(125, 23);
            this.labelCodigoSec.TabIndex = 34;
            this.labelCodigoSec.Text = "Código Secundario";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Código";
            // 
            // chkActivo
            // 
            this.chkActivo.BackColor = System.Drawing.Color.Transparent;
            this.chkActivo.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkActivo.Location = new System.Drawing.Point(499, 0);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(150, 23);
            this.chkActivo.TabIndex = 2;
            this.chkActivo.Text = "Activo";
            // 
            // txtDescripcionLarga
            // 
            this.txtDescripcionLarga.Location = new System.Drawing.Point(125, 121);
            this.txtDescripcionLarga.Multiline = true;
            this.txtDescripcionLarga.Name = "txtDescripcionLarga";
            this.txtDescripcionLarga.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcionLarga.Size = new System.Drawing.Size(893, 38);
            this.txtDescripcionLarga.TabIndex = 8;
            this.txtDescripcionLarga.Text = "TEXTBOX5";
            this.txtDescripcionLarga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // txtDescripcionCorta
            // 
            this.txtDescripcionCorta.Location = new System.Drawing.Point(125, 83);
            this.txtDescripcionCorta.Multiline = true;
            this.txtDescripcionCorta.Name = "txtDescripcionCorta";
            this.txtDescripcionCorta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcionCorta.Size = new System.Drawing.Size(893, 38);
            this.txtDescripcionCorta.TabIndex = 7;
            this.txtDescripcionCorta.Text = "TEXTBOX4";
            this.txtDescripcionCorta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // txtCodigoSecundario
            // 
            this.txtCodigoSecundario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoSecundario.Location = new System.Drawing.Point(125, 22);
            this.txtCodigoSecundario.Name = "txtCodigoSecundario";
            this.txtCodigoSecundario.Size = new System.Drawing.Size(192, 22);
            this.txtCodigoSecundario.TabIndex = 3;
            this.txtCodigoSecundario.Text = "TEXTBOX2";
            this.txtCodigoSecundario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Location = new System.Drawing.Point(125, -1);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(192, 22);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "TEXTBOX1";
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // ultraExplorerBarContainerControl15
            // 
            this.ultraExplorerBarContainerControl15.Controls.Add(this.label53);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.txtCodigoSecundario20);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.label54);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.txtCodigoSecundario19);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.label55);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.txtCodigoSecundario18);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.label56);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.txtCodigoSecundario17);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.label49);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.txtCodigoSecundario16);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.label50);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.txtCodigoSecundario15);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.label51);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.txtCodigoSecundario14);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.label52);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.txtCodigoSecundario13);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.label45);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.txtCodigoSecundario12);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.label46);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.txtCodigoSecundario11);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.label47);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.txtCodigoSecundario10);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.label48);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.txtCodigoSecundario9);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.label41);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.txtCodigoSecundario8);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.label42);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.txtCodigoSecundario7);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.label43);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.txtCodigoSecundario6);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.label44);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.txtCodigoSecundario5);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.label40);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.txtCodigoSecundario4);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.label39);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.txtCodigoSecundario3);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.label38);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.txtCodigoSecundario2);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.label37);
            this.ultraExplorerBarContainerControl15.Controls.Add(this.txtCodigoSecundario1);
            this.ultraExplorerBarContainerControl15.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl15.Name = "ultraExplorerBarContainerControl15";
            this.ultraExplorerBarContainerControl15.Size = new System.Drawing.Size(1082, 182);
            this.ultraExplorerBarContainerControl15.TabIndex = 0;
            this.ultraExplorerBarContainerControl15.Visible = false;
            // 
            // label53
            // 
            this.label53.BackColor = System.Drawing.Color.Transparent;
            this.label53.Location = new System.Drawing.Point(806, 148);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(77, 23);
            this.label53.TabIndex = 74;
            this.label53.Text = "Cód Sec20";
            // 
            // txtCodigoSecundario20
            // 
            this.txtCodigoSecundario20.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoSecundario20.Location = new System.Drawing.Point(884, 148);
            this.txtCodigoSecundario20.Name = "txtCodigoSecundario20";
            this.txtCodigoSecundario20.Size = new System.Drawing.Size(192, 22);
            this.txtCodigoSecundario20.TabIndex = 20;
            this.txtCodigoSecundario20.Text = "TEXTBOX2";
            // 
            // label54
            // 
            this.label54.BackColor = System.Drawing.Color.Transparent;
            this.label54.Location = new System.Drawing.Point(538, 148);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(76, 23);
            this.label54.TabIndex = 72;
            this.label54.Text = "Cód Sec19";
            // 
            // txtCodigoSecundario19
            // 
            this.txtCodigoSecundario19.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoSecundario19.Location = new System.Drawing.Point(614, 148);
            this.txtCodigoSecundario19.Name = "txtCodigoSecundario19";
            this.txtCodigoSecundario19.Size = new System.Drawing.Size(192, 22);
            this.txtCodigoSecundario19.TabIndex = 19;
            this.txtCodigoSecundario19.Text = "TEXTBOX2";
            // 
            // label55
            // 
            this.label55.BackColor = System.Drawing.Color.Transparent;
            this.label55.Location = new System.Drawing.Point(269, 148);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(77, 23);
            this.label55.TabIndex = 70;
            this.label55.Text = "Cód Sec18";
            // 
            // txtCodigoSecundario18
            // 
            this.txtCodigoSecundario18.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoSecundario18.Location = new System.Drawing.Point(346, 148);
            this.txtCodigoSecundario18.Name = "txtCodigoSecundario18";
            this.txtCodigoSecundario18.Size = new System.Drawing.Size(192, 22);
            this.txtCodigoSecundario18.TabIndex = 18;
            this.txtCodigoSecundario18.Text = "TEXTBOX2";
            // 
            // label56
            // 
            this.label56.BackColor = System.Drawing.Color.Transparent;
            this.label56.Location = new System.Drawing.Point(0, 148);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(77, 23);
            this.label56.TabIndex = 68;
            this.label56.Text = "Cód Sec17";
            // 
            // txtCodigoSecundario17
            // 
            this.txtCodigoSecundario17.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoSecundario17.Location = new System.Drawing.Point(76, 148);
            this.txtCodigoSecundario17.Name = "txtCodigoSecundario17";
            this.txtCodigoSecundario17.Size = new System.Drawing.Size(192, 22);
            this.txtCodigoSecundario17.TabIndex = 17;
            this.txtCodigoSecundario17.Text = "TEXTBOX2";
            // 
            // label49
            // 
            this.label49.BackColor = System.Drawing.Color.Transparent;
            this.label49.Location = new System.Drawing.Point(806, 111);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(77, 23);
            this.label49.TabIndex = 66;
            this.label49.Text = "Cód Sec16";
            // 
            // txtCodigoSecundario16
            // 
            this.txtCodigoSecundario16.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoSecundario16.Location = new System.Drawing.Point(884, 111);
            this.txtCodigoSecundario16.Name = "txtCodigoSecundario16";
            this.txtCodigoSecundario16.Size = new System.Drawing.Size(192, 22);
            this.txtCodigoSecundario16.TabIndex = 16;
            this.txtCodigoSecundario16.Text = "TEXTBOX2";
            // 
            // label50
            // 
            this.label50.BackColor = System.Drawing.Color.Transparent;
            this.label50.Location = new System.Drawing.Point(538, 111);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(76, 23);
            this.label50.TabIndex = 64;
            this.label50.Text = "Cód Sec15";
            // 
            // txtCodigoSecundario15
            // 
            this.txtCodigoSecundario15.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoSecundario15.Location = new System.Drawing.Point(614, 111);
            this.txtCodigoSecundario15.Name = "txtCodigoSecundario15";
            this.txtCodigoSecundario15.Size = new System.Drawing.Size(192, 22);
            this.txtCodigoSecundario15.TabIndex = 15;
            this.txtCodigoSecundario15.Text = "TEXTBOX2";
            // 
            // label51
            // 
            this.label51.BackColor = System.Drawing.Color.Transparent;
            this.label51.Location = new System.Drawing.Point(269, 111);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(77, 23);
            this.label51.TabIndex = 62;
            this.label51.Text = "Cód Sec14";
            // 
            // txtCodigoSecundario14
            // 
            this.txtCodigoSecundario14.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoSecundario14.Location = new System.Drawing.Point(346, 111);
            this.txtCodigoSecundario14.Name = "txtCodigoSecundario14";
            this.txtCodigoSecundario14.Size = new System.Drawing.Size(192, 22);
            this.txtCodigoSecundario14.TabIndex = 14;
            this.txtCodigoSecundario14.Text = "TEXTBOX2";
            // 
            // label52
            // 
            this.label52.BackColor = System.Drawing.Color.Transparent;
            this.label52.Location = new System.Drawing.Point(0, 111);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(77, 23);
            this.label52.TabIndex = 60;
            this.label52.Text = "Cód Sec13";
            // 
            // txtCodigoSecundario13
            // 
            this.txtCodigoSecundario13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoSecundario13.Location = new System.Drawing.Point(76, 111);
            this.txtCodigoSecundario13.Name = "txtCodigoSecundario13";
            this.txtCodigoSecundario13.Size = new System.Drawing.Size(192, 22);
            this.txtCodigoSecundario13.TabIndex = 13;
            this.txtCodigoSecundario13.Text = "TEXTBOX2";
            // 
            // label45
            // 
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Location = new System.Drawing.Point(806, 78);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(77, 24);
            this.label45.TabIndex = 58;
            this.label45.Text = "Cód Sec12";
            // 
            // txtCodigoSecundario12
            // 
            this.txtCodigoSecundario12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoSecundario12.Location = new System.Drawing.Point(884, 73);
            this.txtCodigoSecundario12.Name = "txtCodigoSecundario12";
            this.txtCodigoSecundario12.Size = new System.Drawing.Size(192, 22);
            this.txtCodigoSecundario12.TabIndex = 12;
            this.txtCodigoSecundario12.Text = "TEXTBOX2";
            // 
            // label46
            // 
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Location = new System.Drawing.Point(538, 78);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(76, 24);
            this.label46.TabIndex = 56;
            this.label46.Text = "Cód Sec11";
            // 
            // txtCodigoSecundario11
            // 
            this.txtCodigoSecundario11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoSecundario11.Location = new System.Drawing.Point(614, 73);
            this.txtCodigoSecundario11.Name = "txtCodigoSecundario11";
            this.txtCodigoSecundario11.Size = new System.Drawing.Size(192, 22);
            this.txtCodigoSecundario11.TabIndex = 11;
            this.txtCodigoSecundario11.Text = "TEXTBOX2";
            // 
            // label47
            // 
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Location = new System.Drawing.Point(269, 78);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(77, 24);
            this.label47.TabIndex = 54;
            this.label47.Text = "Cód Sec10";
            // 
            // txtCodigoSecundario10
            // 
            this.txtCodigoSecundario10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoSecundario10.Location = new System.Drawing.Point(346, 73);
            this.txtCodigoSecundario10.Name = "txtCodigoSecundario10";
            this.txtCodigoSecundario10.Size = new System.Drawing.Size(192, 22);
            this.txtCodigoSecundario10.TabIndex = 10;
            this.txtCodigoSecundario10.Text = "TEXTBOX2";
            this.txtCodigoSecundario10.TextChanged += new System.EventHandler(this.txtCodigoSecundario10_TextChanged);
            // 
            // label48
            // 
            this.label48.BackColor = System.Drawing.Color.Transparent;
            this.label48.Location = new System.Drawing.Point(0, 78);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(77, 24);
            this.label48.TabIndex = 52;
            this.label48.Text = "Cód Sec9";
            // 
            // txtCodigoSecundario9
            // 
            this.txtCodigoSecundario9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoSecundario9.Location = new System.Drawing.Point(76, 73);
            this.txtCodigoSecundario9.Name = "txtCodigoSecundario9";
            this.txtCodigoSecundario9.Size = new System.Drawing.Size(192, 22);
            this.txtCodigoSecundario9.TabIndex = 9;
            this.txtCodigoSecundario9.Text = "TEXTBOX2";
            // 
            // label41
            // 
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Location = new System.Drawing.Point(806, 37);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(77, 23);
            this.label41.TabIndex = 50;
            this.label41.Text = "Cód Sec8";
            // 
            // txtCodigoSecundario8
            // 
            this.txtCodigoSecundario8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoSecundario8.Location = new System.Drawing.Point(884, 37);
            this.txtCodigoSecundario8.Name = "txtCodigoSecundario8";
            this.txtCodigoSecundario8.Size = new System.Drawing.Size(192, 22);
            this.txtCodigoSecundario8.TabIndex = 8;
            this.txtCodigoSecundario8.Text = "TEXTBOX2";
            // 
            // label42
            // 
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Location = new System.Drawing.Point(538, 37);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(76, 23);
            this.label42.TabIndex = 48;
            this.label42.Text = "Cód Sec7";
            // 
            // txtCodigoSecundario7
            // 
            this.txtCodigoSecundario7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoSecundario7.Location = new System.Drawing.Point(614, 37);
            this.txtCodigoSecundario7.Name = "txtCodigoSecundario7";
            this.txtCodigoSecundario7.Size = new System.Drawing.Size(192, 22);
            this.txtCodigoSecundario7.TabIndex = 7;
            this.txtCodigoSecundario7.Text = "TEXTBOX2";
            // 
            // label43
            // 
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Location = new System.Drawing.Point(269, 37);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(77, 23);
            this.label43.TabIndex = 46;
            this.label43.Text = "Cód Sec6";
            // 
            // txtCodigoSecundario6
            // 
            this.txtCodigoSecundario6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoSecundario6.Location = new System.Drawing.Point(346, 37);
            this.txtCodigoSecundario6.Name = "txtCodigoSecundario6";
            this.txtCodigoSecundario6.Size = new System.Drawing.Size(192, 22);
            this.txtCodigoSecundario6.TabIndex = 6;
            this.txtCodigoSecundario6.Text = "TEXTBOX2";
            // 
            // label44
            // 
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Location = new System.Drawing.Point(0, 37);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(77, 23);
            this.label44.TabIndex = 44;
            this.label44.Text = "Cód Sec5";
            // 
            // txtCodigoSecundario5
            // 
            this.txtCodigoSecundario5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoSecundario5.Location = new System.Drawing.Point(76, 37);
            this.txtCodigoSecundario5.Name = "txtCodigoSecundario5";
            this.txtCodigoSecundario5.Size = new System.Drawing.Size(192, 22);
            this.txtCodigoSecundario5.TabIndex = 5;
            this.txtCodigoSecundario5.Text = "TXTCODIGOSECUNDARIO2";
            // 
            // label40
            // 
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Location = new System.Drawing.Point(806, 6);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(77, 23);
            this.label40.TabIndex = 42;
            this.label40.Text = "Cód Sec4";
            // 
            // txtCodigoSecundario4
            // 
            this.txtCodigoSecundario4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoSecundario4.Location = new System.Drawing.Point(884, 0);
            this.txtCodigoSecundario4.Name = "txtCodigoSecundario4";
            this.txtCodigoSecundario4.Size = new System.Drawing.Size(192, 22);
            this.txtCodigoSecundario4.TabIndex = 4;
            this.txtCodigoSecundario4.Text = "TEXTBOX2";
            // 
            // label39
            // 
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Location = new System.Drawing.Point(538, 6);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(76, 23);
            this.label39.TabIndex = 40;
            this.label39.Text = "Cód Sec3";
            // 
            // txtCodigoSecundario3
            // 
            this.txtCodigoSecundario3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoSecundario3.Location = new System.Drawing.Point(614, 0);
            this.txtCodigoSecundario3.Name = "txtCodigoSecundario3";
            this.txtCodigoSecundario3.Size = new System.Drawing.Size(192, 22);
            this.txtCodigoSecundario3.TabIndex = 3;
            this.txtCodigoSecundario3.Text = "TEXTBOX2";
            // 
            // label38
            // 
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Location = new System.Drawing.Point(269, 6);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(77, 23);
            this.label38.TabIndex = 38;
            this.label38.Text = "Cód Sec2";
            // 
            // txtCodigoSecundario2
            // 
            this.txtCodigoSecundario2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoSecundario2.Location = new System.Drawing.Point(346, 0);
            this.txtCodigoSecundario2.Name = "txtCodigoSecundario2";
            this.txtCodigoSecundario2.Size = new System.Drawing.Size(192, 22);
            this.txtCodigoSecundario2.TabIndex = 2;
            this.txtCodigoSecundario2.Text = "TEXTBOX2";
            // 
            // label37
            // 
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Location = new System.Drawing.Point(0, 6);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(77, 23);
            this.label37.TabIndex = 36;
            this.label37.Text = "Cód Sec1";
            // 
            // txtCodigoSecundario1
            // 
            this.txtCodigoSecundario1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoSecundario1.Location = new System.Drawing.Point(76, 0);
            this.txtCodigoSecundario1.Name = "txtCodigoSecundario1";
            this.txtCodigoSecundario1.Size = new System.Drawing.Size(192, 22);
            this.txtCodigoSecundario1.TabIndex = 1;
            this.txtCodigoSecundario1.Text = "TXTCODIGOSECUNDARIO1";
            // 
            // ultraExplorerBarContainerControl19
            // 
            this.ultraExplorerBarContainerControl19.Controls.Add(this.gridCodigosProductosProveedores);
            this.ultraExplorerBarContainerControl19.Controls.Add(this.gridManagerView4);
            this.ultraExplorerBarContainerControl19.Controls.Add(this.btnAgregarProveedor);
            this.ultraExplorerBarContainerControl19.Controls.Add(this.ultraLabel2);
            this.ultraExplorerBarContainerControl19.Controls.Add(this.mzProveedoresControl);
            this.ultraExplorerBarContainerControl19.Controls.Add(this.ultraLabel1);
            this.ultraExplorerBarContainerControl19.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl19.Name = "ultraExplorerBarContainerControl19";
            this.ultraExplorerBarContainerControl19.Size = new System.Drawing.Size(1082, 190);
            this.ultraExplorerBarContainerControl19.TabIndex = 17;
            this.ultraExplorerBarContainerControl19.Visible = false;
            // 
            // gridCodigosProductosProveedores
            // 
            this.gridCodigosProductosProveedores.AllowCardSizing = false;
            this.gridCodigosProductosProveedores.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridCodigosProductosProveedores.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridCodigosProductosProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCodigosProductosProveedores.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridCodigosProductosProveedores.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridCodigosProductosProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gridCodigosProductosProveedores.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridCodigosProductosProveedores.Location = new System.Drawing.Point(1, 55);
            this.gridCodigosProductosProveedores.Name = "gridCodigosProductosProveedores";
            this.gridCodigosProductosProveedores.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridCodigosProductosProveedores.Size = new System.Drawing.Size(1002, 128);
            this.gridCodigosProductosProveedores.TabIndex = 1819;
            this.gridCodigosProductosProveedores.TabStop = false;
            // 
            // gridManagerView4
            // 
            this.gridManagerView4.BackColor = System.Drawing.SystemColors.Control;
            this.gridManagerView4.Location = new System.Drawing.Point(0, 60);
            this.gridManagerView4.Name = "gridManagerView4";
            this.gridManagerView4.Size = new System.Drawing.Size(470, 28);
            this.gridManagerView4.TabIndex = 1818;
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.AcceptsFocus = false;
            this.btnAgregarProveedor.Location = new System.Drawing.Point(643, 20);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(145, 27);
            this.btnAgregarProveedor.TabIndex = 4;
            this.btnAgregarProveedor.TabStop = false;
            this.btnAgregarProveedor.Text = "Agregar Proveedor";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel2.Location = new System.Drawing.Point(0, 0);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(294, 18);
            this.ultraLabel2.TabIndex = 1;
            this.ultraLabel2.Text = "Asociación de Cod.  Prod. x Prov.";
            // 
            // mzProveedoresControl
            // 
            this.mzProveedoresControl.BackColor = System.Drawing.SystemColors.Control;
            this.mzProveedoresControl.DataValue = "";
            this.mzProveedoresControl.EnableCtaCte = false;
            this.mzProveedoresControl.FastSearch = false;
            this.mzProveedoresControl.Location = new System.Drawing.Point(144, 22);
            this.mzProveedoresControl.Name = "mzProveedoresControl";
            this.mzProveedoresControl.SearchObjectListener = null;
            this.mzProveedoresControl.Size = new System.Drawing.Size(490, 25);
            this.mzProveedoresControl.TabIndex = 3;
            this.mzProveedoresControl.Tag = "Proveedor";
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel1.Location = new System.Drawing.Point(0, 27);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(74, 18);
            this.ultraLabel1.TabIndex = 2;
            this.ultraLabel1.Text = "Proveedor";
            // 
            // ultraExplorerBarContainerControl12
            // 
            this.ultraExplorerBarContainerControl12.Controls.Add(this.mzSearchTextBox1);
            this.ultraExplorerBarContainerControl12.Controls.Add(this.lblEtiquetaCampoAuxiliar6);
            this.ultraExplorerBarContainerControl12.Controls.Add(this.lblEtiquetaCampoAuxiliar5);
            this.ultraExplorerBarContainerControl12.Controls.Add(this.txtCampoAuxiliar5);
            this.ultraExplorerBarContainerControl12.Controls.Add(this.lblEtiquetaCampoAuxiliar3);
            this.ultraExplorerBarContainerControl12.Controls.Add(this.lblEtiquetaCampoAuxiliar4);
            this.ultraExplorerBarContainerControl12.Controls.Add(this.txtCampoAuxiliar4);
            this.ultraExplorerBarContainerControl12.Controls.Add(this.txtCampoAuxiliar3);
            this.ultraExplorerBarContainerControl12.Controls.Add(this.lblEtiquetaCampoAuxiliar1);
            this.ultraExplorerBarContainerControl12.Controls.Add(this.lblEtiquetaCampoAuxiliar2);
            this.ultraExplorerBarContainerControl12.Controls.Add(this.label24);
            this.ultraExplorerBarContainerControl12.Controls.Add(this.txtCampoAuxiliar2);
            this.ultraExplorerBarContainerControl12.Controls.Add(this.txtCampoAuxiliar1);
            this.ultraExplorerBarContainerControl12.Controls.Add(this.txtObservaciones);
            this.ultraExplorerBarContainerControl12.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl12.Name = "ultraExplorerBarContainerControl12";
            this.ultraExplorerBarContainerControl12.Size = new System.Drawing.Size(1082, 204);
            this.ultraExplorerBarContainerControl12.TabIndex = 10;
            this.ultraExplorerBarContainerControl12.Visible = false;
            // 
            // mzSearchTextBox1
            // 
            this.mzSearchTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.mzSearchTextBox1.Location = new System.Drawing.Point(643, 175);
            this.mzSearchTextBox1.Name = "mzSearchTextBox1";
            this.mzSearchTextBox1.Size = new System.Drawing.Size(375, 28);
            this.mzSearchTextBox1.TabIndex = 6;
            // 
            // lblEtiquetaCampoAuxiliar6
            // 
            this.lblEtiquetaCampoAuxiliar6.BackColor = System.Drawing.Color.Transparent;
            this.lblEtiquetaCampoAuxiliar6.Location = new System.Drawing.Point(518, 177);
            this.lblEtiquetaCampoAuxiliar6.Name = "lblEtiquetaCampoAuxiliar6";
            this.lblEtiquetaCampoAuxiliar6.Size = new System.Drawing.Size(120, 20);
            this.lblEtiquetaCampoAuxiliar6.TabIndex = 56;
            this.lblEtiquetaCampoAuxiliar6.Text = "Campo Auxiliar6";
            // 
            // lblEtiquetaCampoAuxiliar5
            // 
            this.lblEtiquetaCampoAuxiliar5.BackColor = System.Drawing.Color.Transparent;
            this.lblEtiquetaCampoAuxiliar5.Location = new System.Drawing.Point(4, 179);
            this.lblEtiquetaCampoAuxiliar5.Name = "lblEtiquetaCampoAuxiliar5";
            this.lblEtiquetaCampoAuxiliar5.Size = new System.Drawing.Size(120, 21);
            this.lblEtiquetaCampoAuxiliar5.TabIndex = 55;
            this.lblEtiquetaCampoAuxiliar5.Text = "Campo Auxiliar5";
            // 
            // txtCampoAuxiliar5
            // 
            this.txtCampoAuxiliar5.Location = new System.Drawing.Point(128, 175);
            this.txtCampoAuxiliar5.MaxLength = 256;
            this.txtCampoAuxiliar5.Name = "txtCampoAuxiliar5";
            this.txtCampoAuxiliar5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCampoAuxiliar5.Size = new System.Drawing.Size(375, 22);
            this.txtCampoAuxiliar5.TabIndex = 3;
            this.txtCampoAuxiliar5.WordWrap = false;
            // 
            // lblEtiquetaCampoAuxiliar3
            // 
            this.lblEtiquetaCampoAuxiliar3.BackColor = System.Drawing.Color.Transparent;
            this.lblEtiquetaCampoAuxiliar3.Location = new System.Drawing.Point(518, 125);
            this.lblEtiquetaCampoAuxiliar3.Name = "lblEtiquetaCampoAuxiliar3";
            this.lblEtiquetaCampoAuxiliar3.Size = new System.Drawing.Size(120, 20);
            this.lblEtiquetaCampoAuxiliar3.TabIndex = 53;
            this.lblEtiquetaCampoAuxiliar3.Text = "Campo Auxiliar3";
            // 
            // lblEtiquetaCampoAuxiliar4
            // 
            this.lblEtiquetaCampoAuxiliar4.BackColor = System.Drawing.Color.Transparent;
            this.lblEtiquetaCampoAuxiliar4.Location = new System.Drawing.Point(518, 152);
            this.lblEtiquetaCampoAuxiliar4.Name = "lblEtiquetaCampoAuxiliar4";
            this.lblEtiquetaCampoAuxiliar4.Size = new System.Drawing.Size(120, 21);
            this.lblEtiquetaCampoAuxiliar4.TabIndex = 52;
            this.lblEtiquetaCampoAuxiliar4.Text = "Campo Auxiliar4";
            // 
            // txtCampoAuxiliar4
            // 
            this.txtCampoAuxiliar4.Location = new System.Drawing.Point(643, 148);
            this.txtCampoAuxiliar4.MaxLength = 256;
            this.txtCampoAuxiliar4.Name = "txtCampoAuxiliar4";
            this.txtCampoAuxiliar4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCampoAuxiliar4.Size = new System.Drawing.Size(375, 22);
            this.txtCampoAuxiliar4.TabIndex = 6;
            this.txtCampoAuxiliar4.WordWrap = false;
            // 
            // txtCampoAuxiliar3
            // 
            this.txtCampoAuxiliar3.Location = new System.Drawing.Point(643, 120);
            this.txtCampoAuxiliar3.MaxLength = 256;
            this.txtCampoAuxiliar3.Name = "txtCampoAuxiliar3";
            this.txtCampoAuxiliar3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCampoAuxiliar3.Size = new System.Drawing.Size(375, 22);
            this.txtCampoAuxiliar3.TabIndex = 4;
            this.txtCampoAuxiliar3.WordWrap = false;
            // 
            // lblEtiquetaCampoAuxiliar1
            // 
            this.lblEtiquetaCampoAuxiliar1.BackColor = System.Drawing.Color.Transparent;
            this.lblEtiquetaCampoAuxiliar1.Location = new System.Drawing.Point(4, 125);
            this.lblEtiquetaCampoAuxiliar1.Name = "lblEtiquetaCampoAuxiliar1";
            this.lblEtiquetaCampoAuxiliar1.Size = new System.Drawing.Size(120, 20);
            this.lblEtiquetaCampoAuxiliar1.TabIndex = 49;
            this.lblEtiquetaCampoAuxiliar1.Text = "Campo Auxiliar1";
            // 
            // lblEtiquetaCampoAuxiliar2
            // 
            this.lblEtiquetaCampoAuxiliar2.BackColor = System.Drawing.Color.Transparent;
            this.lblEtiquetaCampoAuxiliar2.Location = new System.Drawing.Point(4, 152);
            this.lblEtiquetaCampoAuxiliar2.Name = "lblEtiquetaCampoAuxiliar2";
            this.lblEtiquetaCampoAuxiliar2.Size = new System.Drawing.Size(120, 21);
            this.lblEtiquetaCampoAuxiliar2.TabIndex = 48;
            this.lblEtiquetaCampoAuxiliar2.Text = "Campo Auxiliar2";
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(4, 43);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(120, 23);
            this.label24.TabIndex = 47;
            this.label24.Text = "Observaciones";
            // 
            // txtCampoAuxiliar2
            // 
            this.txtCampoAuxiliar2.Location = new System.Drawing.Point(128, 148);
            this.txtCampoAuxiliar2.MaxLength = 256;
            this.txtCampoAuxiliar2.Name = "txtCampoAuxiliar2";
            this.txtCampoAuxiliar2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCampoAuxiliar2.Size = new System.Drawing.Size(375, 22);
            this.txtCampoAuxiliar2.TabIndex = 2;
            this.txtCampoAuxiliar2.WordWrap = false;
            this.txtCampoAuxiliar2.TextChanged += new System.EventHandler(this.txtCampoAuxiliar2_TextChanged);
            // 
            // txtCampoAuxiliar1
            // 
            this.txtCampoAuxiliar1.Location = new System.Drawing.Point(128, 120);
            this.txtCampoAuxiliar1.MaxLength = 256;
            this.txtCampoAuxiliar1.Name = "txtCampoAuxiliar1";
            this.txtCampoAuxiliar1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCampoAuxiliar1.Size = new System.Drawing.Size(375, 22);
            this.txtCampoAuxiliar1.TabIndex = 1;
            this.txtCampoAuxiliar1.WordWrap = false;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(128, 6);
            this.txtObservaciones.MaxLength = 255;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(893, 101);
            this.txtObservaciones.TabIndex = 0;
            // 
            // ultraExplorerBarContainerControl7
            // 
            this.ultraExplorerBarContainerControl7.Controls.Add(this.hierarchicalSearchControl1);
            this.ultraExplorerBarContainerControl7.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl7.Name = "ultraExplorerBarContainerControl7";
            this.ultraExplorerBarContainerControl7.Size = new System.Drawing.Size(1082, 141);
            this.ultraExplorerBarContainerControl7.TabIndex = 6;
            this.ultraExplorerBarContainerControl7.Visible = false;
            // 
            // hierarchicalSearchControl1
            // 
            this.hierarchicalSearchControl1.BackColor = System.Drawing.Color.Transparent;
            this.hierarchicalSearchControl1.Location = new System.Drawing.Point(58, 9);
            this.hierarchicalSearchControl1.Name = "hierarchicalSearchControl1";
            this.hierarchicalSearchControl1.Size = new System.Drawing.Size(940, 110);
            this.hierarchicalSearchControl1.TabIndex = 0;
            // 
            // ultraExplorerBarContainerControl8
            // 
            this.ultraExplorerBarContainerControl8.Controls.Add(this.ubtCopiarCodigoSecundario);
            this.ultraExplorerBarContainerControl8.Controls.Add(this.utbEliminarTodos);
            this.ultraExplorerBarContainerControl8.Controls.Add(this.btnSubir);
            this.ultraExplorerBarContainerControl8.Controls.Add(this.btnBajar);
            this.ultraExplorerBarContainerControl8.Controls.Add(this.chkLista);
            this.ultraExplorerBarContainerControl8.Controls.Add(this.gridProductos);
            this.ultraExplorerBarContainerControl8.Controls.Add(this.btnEliminar);
            this.ultraExplorerBarContainerControl8.Controls.Add(this.btnCobinar);
            this.ultraExplorerBarContainerControl8.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl8.Name = "ultraExplorerBarContainerControl8";
            this.ultraExplorerBarContainerControl8.Size = new System.Drawing.Size(1082, 208);
            this.ultraExplorerBarContainerControl8.TabIndex = 7;
            this.ultraExplorerBarContainerControl8.Visible = false;
            // 
            // ubtCopiarCodigoSecundario
            // 
            this.ubtCopiarCodigoSecundario.Enabled = false;
            this.ubtCopiarCodigoSecundario.Location = new System.Drawing.Point(732, 0);
            this.ubtCopiarCodigoSecundario.Name = "ubtCopiarCodigoSecundario";
            this.ubtCopiarCodigoSecundario.Size = new System.Drawing.Size(163, 28);
            this.ubtCopiarCodigoSecundario.TabIndex = 6;
            this.ubtCopiarCodigoSecundario.TabStop = false;
            this.ubtCopiarCodigoSecundario.Text = "Copiar Cod. Secundario";
            // 
            // utbEliminarTodos
            // 
            this.utbEliminarTodos.Enabled = false;
            this.utbEliminarTodos.Location = new System.Drawing.Point(461, 0);
            this.utbEliminarTodos.Name = "utbEliminarTodos";
            this.utbEliminarTodos.Size = new System.Drawing.Size(105, 28);
            this.utbEliminarTodos.TabIndex = 5;
            this.utbEliminarTodos.TabStop = false;
            this.utbEliminarTodos.Text = "Eliminar Todos";
            // 
            // btnSubir
            // 
            this.btnSubir.ImageList = this.imglStandar;
            this.btnSubir.Location = new System.Drawing.Point(211, 67);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(29, 37);
            this.btnSubir.TabIndex = 1;
            // 
            // imglStandar
            // 
            this.imglStandar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
            this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
            // 
            // btnBajar
            // 
            this.btnBajar.ImageList = this.imglStandar;
            this.btnBajar.Location = new System.Drawing.Point(211, 104);
            this.btnBajar.Name = "btnBajar";
            this.btnBajar.Size = new System.Drawing.Size(29, 37);
            this.btnBajar.TabIndex = 2;
            // 
            // chkLista
            // 
            this.chkLista.Location = new System.Drawing.Point(0, 28);
            this.chkLista.Name = "chkLista";
            this.chkLista.Size = new System.Drawing.Size(211, 140);
            this.chkLista.TabIndex = 0;
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
            this.gridProductos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gridProductos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridProductos.Location = new System.Drawing.Point(250, 28);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridProductos.Size = new System.Drawing.Size(825, 166);
            this.gridProductos.TabIndex = 7;
            this.gridProductos.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(355, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 28);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Text = "Eliminar";
            // 
            // btnCobinar
            // 
            this.btnCobinar.AcceptsFocus = false;
            this.btnCobinar.Location = new System.Drawing.Point(250, 0);
            this.btnCobinar.Name = "btnCobinar";
            this.btnCobinar.Size = new System.Drawing.Size(105, 28);
            this.btnCobinar.TabIndex = 3;
            this.btnCobinar.TabStop = false;
            this.btnCobinar.Text = "Combinar";
            // 
            // ultraExplorerBarContainerControl18
            // 
            this.ultraExplorerBarContainerControl18.Controls.Add(this.groupMZ);
            this.ultraExplorerBarContainerControl18.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl18.Name = "ultraExplorerBarContainerControl18";
            this.ultraExplorerBarContainerControl18.Size = new System.Drawing.Size(1082, 207);
            this.ultraExplorerBarContainerControl18.TabIndex = 15;
            this.ultraExplorerBarContainerControl18.Visible = false;
            // 
            // groupMZ
            // 
            this.groupMZ.BackColor = System.Drawing.Color.Transparent;
            this.groupMZ.Controls.Add(this.panelCostosIndirectos);
            this.groupMZ.Controls.Add(this.groupBox5);
            this.groupMZ.Location = new System.Drawing.Point(0, 9);
            this.groupMZ.Name = "groupMZ";
            this.groupMZ.Size = new System.Drawing.Size(978, 192);
            this.groupMZ.TabIndex = 23;
            this.groupMZ.TabStop = false;
            this.groupMZ.Text = "Nuevo Costo";
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
            this.panelCostosIndirectos.Location = new System.Drawing.Point(442, 7);
            this.panelCostosIndirectos.Name = "panelCostosIndirectos";
            this.panelCostosIndirectos.Size = new System.Drawing.Size(526, 175);
            this.panelCostosIndirectos.TabIndex = 147;
            this.panelCostosIndirectos.TabStop = false;
            // 
            // chkCoef10
            // 
            this.chkCoef10.Location = new System.Drawing.Point(437, 332);
            this.chkCoef10.Name = "chkCoef10";
            this.chkCoef10.Size = new System.Drawing.Size(105, 25);
            this.chkCoef10.TabIndex = 243;
            this.chkCoef10.Text = "Activo";
            // 
            // chkCoef9
            // 
            this.chkCoef9.Location = new System.Drawing.Point(437, 305);
            this.chkCoef9.Name = "chkCoef9";
            this.chkCoef9.Size = new System.Drawing.Size(105, 24);
            this.chkCoef9.TabIndex = 240;
            this.chkCoef9.Text = "Activo";
            // 
            // chkCoef8
            // 
            this.chkCoef8.Location = new System.Drawing.Point(437, 286);
            this.chkCoef8.Name = "chkCoef8";
            this.chkCoef8.Size = new System.Drawing.Size(105, 24);
            this.chkCoef8.TabIndex = 237;
            this.chkCoef8.Text = "Activo";
            // 
            // chkCoef7
            // 
            this.chkCoef7.Location = new System.Drawing.Point(437, 258);
            this.chkCoef7.Name = "chkCoef7";
            this.chkCoef7.Size = new System.Drawing.Size(105, 25);
            this.chkCoef7.TabIndex = 234;
            this.chkCoef7.Text = "Activo";
            // 
            // chkCoef6
            // 
            this.chkCoef6.Location = new System.Drawing.Point(437, 231);
            this.chkCoef6.Name = "chkCoef6";
            this.chkCoef6.Size = new System.Drawing.Size(105, 24);
            this.chkCoef6.TabIndex = 231;
            this.chkCoef6.Text = "Activo";
            // 
            // chkCoef5
            // 
            this.chkCoef5.Location = new System.Drawing.Point(437, 104);
            this.chkCoef5.Name = "chkCoef5";
            this.chkCoef5.Size = new System.Drawing.Size(91, 24);
            this.chkCoef5.TabIndex = 17;
            this.chkCoef5.Text = "Activo";
            // 
            // chkCoef4
            // 
            this.chkCoef4.Location = new System.Drawing.Point(437, 78);
            this.chkCoef4.Name = "chkCoef4";
            this.chkCoef4.Size = new System.Drawing.Size(91, 25);
            this.chkCoef4.TabIndex = 14;
            this.chkCoef4.Text = "Activo";
            // 
            // chkCoef3
            // 
            this.chkCoef3.Location = new System.Drawing.Point(437, 57);
            this.chkCoef3.Name = "chkCoef3";
            this.chkCoef3.Size = new System.Drawing.Size(91, 24);
            this.chkCoef3.TabIndex = 11;
            this.chkCoef3.Text = "Activo";
            // 
            // chkCoef2
            // 
            this.chkCoef2.Location = new System.Drawing.Point(437, 32);
            this.chkCoef2.Name = "chkCoef2";
            this.chkCoef2.Size = new System.Drawing.Size(91, 25);
            this.chkCoef2.TabIndex = 8;
            this.chkCoef2.Text = "Activo";
            // 
            // labelSimboloMonedaCoeficiente10
            // 
            this.labelSimboloMonedaCoeficiente10.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaCoeficiente10.Location = new System.Drawing.Point(172, 332);
            this.labelSimboloMonedaCoeficiente10.Name = "labelSimboloMonedaCoeficiente10";
            this.labelSimboloMonedaCoeficiente10.Size = new System.Drawing.Size(28, 25);
            this.labelSimboloMonedaCoeficiente10.TabIndex = 261;
            this.labelSimboloMonedaCoeficiente10.Text = "$";
            this.labelSimboloMonedaCoeficiente10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaCoeficiente9
            // 
            this.labelSimboloMonedaCoeficiente9.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaCoeficiente9.Location = new System.Drawing.Point(172, 305);
            this.labelSimboloMonedaCoeficiente9.Name = "labelSimboloMonedaCoeficiente9";
            this.labelSimboloMonedaCoeficiente9.Size = new System.Drawing.Size(28, 24);
            this.labelSimboloMonedaCoeficiente9.TabIndex = 260;
            this.labelSimboloMonedaCoeficiente9.Text = "$";
            this.labelSimboloMonedaCoeficiente9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaCoeficiente8
            // 
            this.labelSimboloMonedaCoeficiente8.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaCoeficiente8.Location = new System.Drawing.Point(172, 286);
            this.labelSimboloMonedaCoeficiente8.Name = "labelSimboloMonedaCoeficiente8";
            this.labelSimboloMonedaCoeficiente8.Size = new System.Drawing.Size(28, 24);
            this.labelSimboloMonedaCoeficiente8.TabIndex = 259;
            this.labelSimboloMonedaCoeficiente8.Text = "$";
            this.labelSimboloMonedaCoeficiente8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPorc10
            // 
            this.labelPorc10.BackColor = System.Drawing.Color.Transparent;
            this.labelPorc10.Location = new System.Drawing.Point(312, 332);
            this.labelPorc10.Name = "labelPorc10";
            this.labelPorc10.Size = new System.Drawing.Size(19, 25);
            this.labelPorc10.TabIndex = 258;
            this.labelPorc10.Text = "%";
            // 
            // labelPorc9
            // 
            this.labelPorc9.BackColor = System.Drawing.Color.Transparent;
            this.labelPorc9.Location = new System.Drawing.Point(312, 314);
            this.labelPorc9.Name = "labelPorc9";
            this.labelPorc9.Size = new System.Drawing.Size(19, 24);
            this.labelPorc9.TabIndex = 257;
            this.labelPorc9.Text = "%";
            // 
            // labelPorc8
            // 
            this.labelPorc8.BackColor = System.Drawing.Color.Transparent;
            this.labelPorc8.Location = new System.Drawing.Point(312, 286);
            this.labelPorc8.Name = "labelPorc8";
            this.labelPorc8.Size = new System.Drawing.Size(19, 24);
            this.labelPorc8.TabIndex = 256;
            this.labelPorc8.Text = "%";
            // 
            // uneCoeficientePorc10
            // 
            this.uneCoeficientePorc10.Location = new System.Drawing.Point(331, 332);
            this.uneCoeficientePorc10.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc10.Name = "uneCoeficientePorc10";
            this.uneCoeficientePorc10.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc10.Size = new System.Drawing.Size(87, 24);
            this.uneCoeficientePorc10.TabIndex = 242;
            this.uneCoeficientePorc10.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficientePorc9
            // 
            this.uneCoeficientePorc9.Location = new System.Drawing.Point(331, 305);
            this.uneCoeficientePorc9.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc9.Name = "uneCoeficientePorc9";
            this.uneCoeficientePorc9.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc9.Size = new System.Drawing.Size(87, 24);
            this.uneCoeficientePorc9.TabIndex = 239;
            this.uneCoeficientePorc9.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficientePorc8
            // 
            this.uneCoeficientePorc8.Location = new System.Drawing.Point(331, 277);
            this.uneCoeficientePorc8.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc8.Name = "uneCoeficientePorc8";
            this.uneCoeficientePorc8.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc8.Size = new System.Drawing.Size(87, 24);
            this.uneCoeficientePorc8.TabIndex = 236;
            this.uneCoeficientePorc8.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficientePorc7
            // 
            this.uneCoeficientePorc7.Location = new System.Drawing.Point(331, 258);
            this.uneCoeficientePorc7.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc7.Name = "uneCoeficientePorc7";
            this.uneCoeficientePorc7.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc7.Size = new System.Drawing.Size(87, 24);
            this.uneCoeficientePorc7.TabIndex = 233;
            this.uneCoeficientePorc7.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficientePorc6
            // 
            this.uneCoeficientePorc6.Location = new System.Drawing.Point(331, 231);
            this.uneCoeficientePorc6.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc6.Name = "uneCoeficientePorc6";
            this.uneCoeficientePorc6.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc6.Size = new System.Drawing.Size(87, 24);
            this.uneCoeficientePorc6.TabIndex = 230;
            this.uneCoeficientePorc6.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraCoeficiente10
            // 
            this.ultraCoeficiente10.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraCoeficiente10.Location = new System.Drawing.Point(19, 332);
            this.ultraCoeficiente10.Name = "ultraCoeficiente10";
            this.ultraCoeficiente10.Size = new System.Drawing.Size(154, 25);
            this.ultraCoeficiente10.TabIndex = 255;
            this.ultraCoeficiente10.Text = "Coeficiente 10";
            // 
            // ultraCoeficiente9
            // 
            this.ultraCoeficiente9.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraCoeficiente9.Location = new System.Drawing.Point(19, 314);
            this.ultraCoeficiente9.Name = "ultraCoeficiente9";
            this.ultraCoeficiente9.Size = new System.Drawing.Size(154, 24);
            this.ultraCoeficiente9.TabIndex = 254;
            this.ultraCoeficiente9.Text = "Coeficiente 9";
            // 
            // ultraCoeficiente8
            // 
            this.ultraCoeficiente8.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraCoeficiente8.Location = new System.Drawing.Point(19, 286);
            this.ultraCoeficiente8.Name = "ultraCoeficiente8";
            this.ultraCoeficiente8.Size = new System.Drawing.Size(154, 24);
            this.ultraCoeficiente8.TabIndex = 253;
            this.ultraCoeficiente8.Text = "Coeficiente 8";
            // 
            // uneCoeficiente10
            // 
            this.uneCoeficiente10.Location = new System.Drawing.Point(206, 332);
            this.uneCoeficiente10.MaskInput = "nnnnnnn.nn";
            this.uneCoeficiente10.Name = "uneCoeficiente10";
            this.uneCoeficiente10.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficiente10.Size = new System.Drawing.Size(96, 24);
            this.uneCoeficiente10.TabIndex = 241;
            this.uneCoeficiente10.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficiente9
            // 
            this.uneCoeficiente9.Location = new System.Drawing.Point(206, 305);
            this.uneCoeficiente9.MaskInput = "nnnnnnn.nn";
            this.uneCoeficiente9.Name = "uneCoeficiente9";
            this.uneCoeficiente9.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficiente9.Size = new System.Drawing.Size(96, 24);
            this.uneCoeficiente9.TabIndex = 238;
            this.uneCoeficiente9.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficiente8
            // 
            this.uneCoeficiente8.Location = new System.Drawing.Point(206, 277);
            this.uneCoeficiente8.MaskInput = "nnnnnnn.nn";
            this.uneCoeficiente8.Name = "uneCoeficiente8";
            this.uneCoeficiente8.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficiente8.Size = new System.Drawing.Size(96, 24);
            this.uneCoeficiente8.TabIndex = 235;
            this.uneCoeficiente8.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // labelSimboloMonedaCoeficiente7
            // 
            this.labelSimboloMonedaCoeficiente7.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaCoeficiente7.Location = new System.Drawing.Point(172, 258);
            this.labelSimboloMonedaCoeficiente7.Name = "labelSimboloMonedaCoeficiente7";
            this.labelSimboloMonedaCoeficiente7.Size = new System.Drawing.Size(28, 25);
            this.labelSimboloMonedaCoeficiente7.TabIndex = 247;
            this.labelSimboloMonedaCoeficiente7.Text = "$";
            this.labelSimboloMonedaCoeficiente7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaCoeficiente6
            // 
            this.labelSimboloMonedaCoeficiente6.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaCoeficiente6.Location = new System.Drawing.Point(172, 231);
            this.labelSimboloMonedaCoeficiente6.Name = "labelSimboloMonedaCoeficiente6";
            this.labelSimboloMonedaCoeficiente6.Size = new System.Drawing.Size(28, 24);
            this.labelSimboloMonedaCoeficiente6.TabIndex = 245;
            this.labelSimboloMonedaCoeficiente6.Text = "$";
            this.labelSimboloMonedaCoeficiente6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uneCoeficiente7
            // 
            this.uneCoeficiente7.Location = new System.Drawing.Point(206, 258);
            this.uneCoeficiente7.MaskInput = "nnnnnnn.nn";
            this.uneCoeficiente7.Name = "uneCoeficiente7";
            this.uneCoeficiente7.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficiente7.Size = new System.Drawing.Size(96, 24);
            this.uneCoeficiente7.TabIndex = 232;
            this.uneCoeficiente7.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficiente6
            // 
            this.uneCoeficiente6.Location = new System.Drawing.Point(206, 231);
            this.uneCoeficiente6.MaskInput = "nnnnnnn.nn";
            this.uneCoeficiente6.Name = "uneCoeficiente6";
            this.uneCoeficiente6.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficiente6.Size = new System.Drawing.Size(96, 24);
            this.uneCoeficiente6.TabIndex = 229;
            this.uneCoeficiente6.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // labelPorc6
            // 
            this.labelPorc6.BackColor = System.Drawing.Color.Transparent;
            this.labelPorc6.Location = new System.Drawing.Point(312, 240);
            this.labelPorc6.Name = "labelPorc6";
            this.labelPorc6.Size = new System.Drawing.Size(19, 24);
            this.labelPorc6.TabIndex = 239;
            this.labelPorc6.Text = "%";
            // 
            // ultraCoeficiente7
            // 
            this.ultraCoeficiente7.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraCoeficiente7.Location = new System.Drawing.Point(19, 258);
            this.ultraCoeficiente7.Name = "ultraCoeficiente7";
            this.ultraCoeficiente7.Size = new System.Drawing.Size(154, 25);
            this.ultraCoeficiente7.TabIndex = 238;
            this.ultraCoeficiente7.Text = "Coeficiente 7";
            // 
            // ultraCoeficiente6
            // 
            this.ultraCoeficiente6.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraCoeficiente6.Location = new System.Drawing.Point(19, 240);
            this.ultraCoeficiente6.Name = "ultraCoeficiente6";
            this.ultraCoeficiente6.Size = new System.Drawing.Size(154, 24);
            this.ultraCoeficiente6.TabIndex = 237;
            this.ultraCoeficiente6.Text = "Coeficiente 6";
            // 
            // labelPorc7
            // 
            this.labelPorc7.BackColor = System.Drawing.Color.Transparent;
            this.labelPorc7.Location = new System.Drawing.Point(312, 258);
            this.labelPorc7.Name = "labelPorc7";
            this.labelPorc7.Size = new System.Drawing.Size(19, 25);
            this.labelPorc7.TabIndex = 240;
            this.labelPorc7.Text = "%";
            // 
            // labelSimboloMonedaCoeficiente5
            // 
            this.labelSimboloMonedaCoeficiente5.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaCoeficiente5.Location = new System.Drawing.Point(172, 104);
            this.labelSimboloMonedaCoeficiente5.Name = "labelSimboloMonedaCoeficiente5";
            this.labelSimboloMonedaCoeficiente5.Size = new System.Drawing.Size(28, 24);
            this.labelSimboloMonedaCoeficiente5.TabIndex = 236;
            this.labelSimboloMonedaCoeficiente5.Text = "$";
            this.labelSimboloMonedaCoeficiente5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaCoeficiente4
            // 
            this.labelSimboloMonedaCoeficiente4.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaCoeficiente4.Location = new System.Drawing.Point(172, 80);
            this.labelSimboloMonedaCoeficiente4.Name = "labelSimboloMonedaCoeficiente4";
            this.labelSimboloMonedaCoeficiente4.Size = new System.Drawing.Size(28, 24);
            this.labelSimboloMonedaCoeficiente4.TabIndex = 235;
            this.labelSimboloMonedaCoeficiente4.Text = "$";
            this.labelSimboloMonedaCoeficiente4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaCoeficiente3
            // 
            this.labelSimboloMonedaCoeficiente3.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaCoeficiente3.Location = new System.Drawing.Point(172, 55);
            this.labelSimboloMonedaCoeficiente3.Name = "labelSimboloMonedaCoeficiente3";
            this.labelSimboloMonedaCoeficiente3.Size = new System.Drawing.Size(28, 25);
            this.labelSimboloMonedaCoeficiente3.TabIndex = 234;
            this.labelSimboloMonedaCoeficiente3.Text = "$";
            this.labelSimboloMonedaCoeficiente3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPorc5
            // 
            this.labelPorc5.BackColor = System.Drawing.Color.Transparent;
            this.labelPorc5.Location = new System.Drawing.Point(312, 107);
            this.labelPorc5.Name = "labelPorc5";
            this.labelPorc5.Size = new System.Drawing.Size(19, 25);
            this.labelPorc5.TabIndex = 233;
            this.labelPorc5.Text = "%";
            // 
            // labelPorc4
            // 
            this.labelPorc4.BackColor = System.Drawing.Color.Transparent;
            this.labelPorc4.Location = new System.Drawing.Point(312, 83);
            this.labelPorc4.Name = "labelPorc4";
            this.labelPorc4.Size = new System.Drawing.Size(19, 24);
            this.labelPorc4.TabIndex = 232;
            this.labelPorc4.Text = "%";
            // 
            // labelPorc3
            // 
            this.labelPorc3.BackColor = System.Drawing.Color.Transparent;
            this.labelPorc3.Location = new System.Drawing.Point(312, 60);
            this.labelPorc3.Name = "labelPorc3";
            this.labelPorc3.Size = new System.Drawing.Size(19, 24);
            this.labelPorc3.TabIndex = 231;
            this.labelPorc3.Text = "%";
            // 
            // uneCoeficientePorc5
            // 
            this.uneCoeficientePorc5.Location = new System.Drawing.Point(331, 102);
            this.uneCoeficientePorc5.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc5.Name = "uneCoeficientePorc5";
            this.uneCoeficientePorc5.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc5.Size = new System.Drawing.Size(87, 24);
            this.uneCoeficientePorc5.TabIndex = 16;
            this.uneCoeficientePorc5.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficientePorc4
            // 
            this.uneCoeficientePorc4.Location = new System.Drawing.Point(331, 78);
            this.uneCoeficientePorc4.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc4.Name = "uneCoeficientePorc4";
            this.uneCoeficientePorc4.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc4.Size = new System.Drawing.Size(87, 24);
            this.uneCoeficientePorc4.TabIndex = 13;
            this.uneCoeficientePorc4.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficientePorc3
            // 
            this.uneCoeficientePorc3.Location = new System.Drawing.Point(331, 55);
            this.uneCoeficientePorc3.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc3.Name = "uneCoeficientePorc3";
            this.uneCoeficientePorc3.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc3.Size = new System.Drawing.Size(87, 24);
            this.uneCoeficientePorc3.TabIndex = 10;
            this.uneCoeficientePorc3.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficientePorc2
            // 
            this.uneCoeficientePorc2.Location = new System.Drawing.Point(331, 32);
            this.uneCoeficientePorc2.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc2.Name = "uneCoeficientePorc2";
            this.uneCoeficientePorc2.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc2.Size = new System.Drawing.Size(87, 24);
            this.uneCoeficientePorc2.TabIndex = 7;
            this.uneCoeficientePorc2.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraCoeficiente5
            // 
            this.ultraCoeficiente5.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraCoeficiente5.Location = new System.Drawing.Point(19, 107);
            this.ultraCoeficiente5.Name = "ultraCoeficiente5";
            this.ultraCoeficiente5.Size = new System.Drawing.Size(154, 25);
            this.ultraCoeficiente5.TabIndex = 230;
            this.ultraCoeficiente5.Text = "Coeficiente 5";
            // 
            // ultraCoeficiente4
            // 
            this.ultraCoeficiente4.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraCoeficiente4.Location = new System.Drawing.Point(19, 83);
            this.ultraCoeficiente4.Name = "ultraCoeficiente4";
            this.ultraCoeficiente4.Size = new System.Drawing.Size(154, 24);
            this.ultraCoeficiente4.TabIndex = 229;
            this.ultraCoeficiente4.Text = "Coeficiente 4";
            // 
            // ultraCoeficiente3
            // 
            this.ultraCoeficiente3.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraCoeficiente3.Location = new System.Drawing.Point(19, 60);
            this.ultraCoeficiente3.Name = "ultraCoeficiente3";
            this.ultraCoeficiente3.Size = new System.Drawing.Size(154, 24);
            this.ultraCoeficiente3.TabIndex = 227;
            this.ultraCoeficiente3.Text = "Coeficiente 3";
            // 
            // uneCoeficiente5
            // 
            this.uneCoeficiente5.Location = new System.Drawing.Point(206, 102);
            this.uneCoeficiente5.MaskInput = "nnnnnnn.nn";
            this.uneCoeficiente5.Name = "uneCoeficiente5";
            this.uneCoeficiente5.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficiente5.Size = new System.Drawing.Size(96, 24);
            this.uneCoeficiente5.TabIndex = 15;
            this.uneCoeficiente5.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficiente4
            // 
            this.uneCoeficiente4.Location = new System.Drawing.Point(206, 78);
            this.uneCoeficiente4.MaskInput = "nnnnnnn.nn";
            this.uneCoeficiente4.Name = "uneCoeficiente4";
            this.uneCoeficiente4.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficiente4.Size = new System.Drawing.Size(96, 24);
            this.uneCoeficiente4.TabIndex = 12;
            this.uneCoeficiente4.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficiente3
            // 
            this.uneCoeficiente3.Location = new System.Drawing.Point(206, 55);
            this.uneCoeficiente3.MaskInput = "nnnnnnn.nn";
            this.uneCoeficiente3.Name = "uneCoeficiente3";
            this.uneCoeficiente3.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficiente3.Size = new System.Drawing.Size(96, 24);
            this.uneCoeficiente3.TabIndex = 9;
            this.uneCoeficiente3.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // labelSimboloMonedaPrecioDeCosto6
            // 
            this.labelSimboloMonedaPrecioDeCosto6.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeCosto6.Location = new System.Drawing.Point(172, 143);
            this.labelSimboloMonedaPrecioDeCosto6.Name = "labelSimboloMonedaPrecioDeCosto6";
            this.labelSimboloMonedaPrecioDeCosto6.Size = new System.Drawing.Size(28, 19);
            this.labelSimboloMonedaPrecioDeCosto6.TabIndex = 222;
            this.labelSimboloMonedaPrecioDeCosto6.Text = "$";
            this.labelSimboloMonedaPrecioDeCosto6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaCoeficiente2
            // 
            this.labelSimboloMonedaCoeficiente2.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaCoeficiente2.Location = new System.Drawing.Point(172, 32);
            this.labelSimboloMonedaCoeficiente2.Name = "labelSimboloMonedaCoeficiente2";
            this.labelSimboloMonedaCoeficiente2.Size = new System.Drawing.Size(28, 25);
            this.labelSimboloMonedaCoeficiente2.TabIndex = 220;
            this.labelSimboloMonedaCoeficiente2.Text = "$";
            this.labelSimboloMonedaCoeficiente2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaCoeficiente1
            // 
            this.labelSimboloMonedaCoeficiente1.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaCoeficiente1.Location = new System.Drawing.Point(172, 9);
            this.labelSimboloMonedaCoeficiente1.Name = "labelSimboloMonedaCoeficiente1";
            this.labelSimboloMonedaCoeficiente1.Size = new System.Drawing.Size(28, 24);
            this.labelSimboloMonedaCoeficiente1.TabIndex = 217;
            this.labelSimboloMonedaCoeficiente1.Text = "$";
            this.labelSimboloMonedaCoeficiente1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uneCoeficienteTotal
            // 
            this.uneCoeficienteTotal.Location = new System.Drawing.Point(206, 142);
            this.uneCoeficienteTotal.MaskInput = "nnnnnnn.nn";
            this.uneCoeficienteTotal.Name = "uneCoeficienteTotal";
            this.uneCoeficienteTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficienteTotal.Size = new System.Drawing.Size(96, 24);
            this.uneCoeficienteTotal.TabIndex = 18;
            this.uneCoeficienteTotal.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficiente2
            // 
            this.uneCoeficiente2.Location = new System.Drawing.Point(206, 32);
            this.uneCoeficiente2.MaskInput = "nnnnnnn.nn";
            this.uneCoeficiente2.Name = "uneCoeficiente2";
            this.uneCoeficiente2.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficiente2.Size = new System.Drawing.Size(96, 24);
            this.uneCoeficiente2.TabIndex = 6;
            this.uneCoeficiente2.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraLabel9
            // 
            this.ultraLabel9.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel9.Location = new System.Drawing.Point(19, 144);
            this.ultraLabel9.Name = "ultraLabel9";
            this.ultraLabel9.Size = new System.Drawing.Size(144, 19);
            this.ultraLabel9.TabIndex = 211;
            this.ultraLabel9.Text = "Costos Indirectos";
            // 
            // ultraCoeficiente2
            // 
            this.ultraCoeficiente2.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraCoeficiente2.Location = new System.Drawing.Point(19, 36);
            this.ultraCoeficiente2.Name = "ultraCoeficiente2";
            this.ultraCoeficiente2.Size = new System.Drawing.Size(154, 24);
            this.ultraCoeficiente2.TabIndex = 210;
            this.ultraCoeficiente2.Text = "Coeficiente 2";
            // 
            // ultraCoeficiente1
            // 
            this.ultraCoeficiente1.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraCoeficiente1.Location = new System.Drawing.Point(19, 15);
            this.ultraCoeficiente1.Name = "ultraCoeficiente1";
            this.ultraCoeficiente1.Size = new System.Drawing.Size(154, 24);
            this.ultraCoeficiente1.TabIndex = 209;
            this.ultraCoeficiente1.Text = "Coeficiente 1";
            // 
            // labelPorc2
            // 
            this.labelPorc2.BackColor = System.Drawing.Color.Transparent;
            this.labelPorc2.Location = new System.Drawing.Point(312, 37);
            this.labelPorc2.Name = "labelPorc2";
            this.labelPorc2.Size = new System.Drawing.Size(19, 24);
            this.labelPorc2.TabIndex = 213;
            this.labelPorc2.Text = "%";
            // 
            // chkCoef1
            // 
            this.chkCoef1.Location = new System.Drawing.Point(437, 10);
            this.chkCoef1.Name = "chkCoef1";
            this.chkCoef1.Size = new System.Drawing.Size(91, 25);
            this.chkCoef1.TabIndex = 5;
            this.chkCoef1.Text = "Activo";
            // 
            // uneCoeficientePorc1
            // 
            this.uneCoeficientePorc1.Location = new System.Drawing.Point(331, 9);
            this.uneCoeficientePorc1.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc1.Name = "uneCoeficientePorc1";
            this.uneCoeficientePorc1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc1.Size = new System.Drawing.Size(87, 24);
            this.uneCoeficientePorc1.TabIndex = 4;
            this.uneCoeficientePorc1.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficiente1
            // 
            this.uneCoeficiente1.Location = new System.Drawing.Point(206, 9);
            this.uneCoeficiente1.MaskInput = "nnnnnnn.nn";
            this.uneCoeficiente1.Name = "uneCoeficiente1";
            this.uneCoeficiente1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficiente1.Size = new System.Drawing.Size(96, 24);
            this.uneCoeficiente1.TabIndex = 3;
            this.uneCoeficiente1.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // labelPorc1
            // 
            this.labelPorc1.BackColor = System.Drawing.Color.Transparent;
            this.labelPorc1.Location = new System.Drawing.Point(312, 14);
            this.labelPorc1.Name = "labelPorc1";
            this.labelPorc1.Size = new System.Drawing.Size(19, 24);
            this.labelPorc1.TabIndex = 212;
            this.labelPorc1.Text = "%";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.unePCostoPromedioPonderado);
            this.groupBox5.Controls.Add(this.label62);
            this.groupBox5.Controls.Add(this.unePrecioDeCostoReposicion);
            this.groupBox5.Controls.Add(this.ultraLabel12);
            this.groupBox5.Controls.Add(this.labelSimboloMonedaPrecioDeCostoReposicion);
            this.groupBox5.Controls.Add(this.labelSimboloMonedaPrecioDeCosto3);
            this.groupBox5.Controls.Add(this.chkUsaPrecioDeCostoReposicion);
            this.groupBox5.Location = new System.Drawing.Point(11, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(414, 92);
            this.groupBox5.TabIndex = 152;
            this.groupBox5.TabStop = false;
            // 
            // unePCostoPromedioPonderado
            // 
            this.unePCostoPromedioPonderado.Location = new System.Drawing.Point(278, 9);
            this.unePCostoPromedioPonderado.Name = "unePCostoPromedioPonderado";
            this.unePCostoPromedioPonderado.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePCostoPromedioPonderado.PromptChar = ' ';
            this.unePCostoPromedioPonderado.Size = new System.Drawing.Size(120, 24);
            this.unePCostoPromedioPonderado.TabIndex = 0;
            this.unePCostoPromedioPonderado.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label62
            // 
            this.label62.BackColor = System.Drawing.Color.Transparent;
            this.label62.Location = new System.Drawing.Point(10, 37);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(220, 18);
            this.label62.TabIndex = 149;
            this.label62.Text = "Precio de Costo de Reposición";
            // 
            // unePrecioDeCostoReposicion
            // 
            this.unePrecioDeCostoReposicion.Location = new System.Drawing.Point(278, 37);
            this.unePrecioDeCostoReposicion.MaskInput = "nnnnnnnn.nnnn";
            this.unePrecioDeCostoReposicion.Name = "unePrecioDeCostoReposicion";
            this.unePrecioDeCostoReposicion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioDeCostoReposicion.Size = new System.Drawing.Size(120, 24);
            this.unePrecioDeCostoReposicion.TabIndex = 1;
            this.unePrecioDeCostoReposicion.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraLabel12
            // 
            this.ultraLabel12.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel12.Location = new System.Drawing.Point(10, 18);
            this.ultraLabel12.Name = "ultraLabel12";
            this.ultraLabel12.Size = new System.Drawing.Size(234, 18);
            this.ultraLabel12.TabIndex = 76;
            this.ultraLabel12.Text = "Precio de Costo Promedio Ponderado";
            // 
            // labelSimboloMonedaPrecioDeCostoReposicion
            // 
            this.labelSimboloMonedaPrecioDeCostoReposicion.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeCostoReposicion.Location = new System.Drawing.Point(230, 37);
            this.labelSimboloMonedaPrecioDeCostoReposicion.Name = "labelSimboloMonedaPrecioDeCostoReposicion";
            this.labelSimboloMonedaPrecioDeCostoReposicion.Size = new System.Drawing.Size(39, 18);
            this.labelSimboloMonedaPrecioDeCostoReposicion.TabIndex = 150;
            this.labelSimboloMonedaPrecioDeCostoReposicion.Text = "$";
            this.labelSimboloMonedaPrecioDeCostoReposicion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaPrecioDeCosto3
            // 
            this.labelSimboloMonedaPrecioDeCosto3.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeCosto3.Location = new System.Drawing.Point(230, 18);
            this.labelSimboloMonedaPrecioDeCosto3.Name = "labelSimboloMonedaPrecioDeCosto3";
            this.labelSimboloMonedaPrecioDeCosto3.Size = new System.Drawing.Size(39, 20);
            this.labelSimboloMonedaPrecioDeCosto3.TabIndex = 80;
            this.labelSimboloMonedaPrecioDeCosto3.Text = "$";
            this.labelSimboloMonedaPrecioDeCosto3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkUsaPrecioDeCostoReposicion
            // 
            this.chkUsaPrecioDeCostoReposicion.BackColor = System.Drawing.Color.Transparent;
            this.chkUsaPrecioDeCostoReposicion.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkUsaPrecioDeCostoReposicion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkUsaPrecioDeCostoReposicion.Location = new System.Drawing.Point(10, 55);
            this.chkUsaPrecioDeCostoReposicion.Name = "chkUsaPrecioDeCostoReposicion";
            this.chkUsaPrecioDeCostoReposicion.Size = new System.Drawing.Size(220, 23);
            this.chkUsaPrecioDeCostoReposicion.TabIndex = 2;
            this.chkUsaPrecioDeCostoReposicion.Text = "Usa Precio de Costo Reposición";
            // 
            // ultraExplorerBarContainerControl17
            // 
            this.ultraExplorerBarContainerControl17.Controls.Add(this.btnAplicarDescuento);
            this.ultraExplorerBarContainerControl17.Controls.Add(this.label63);
            this.ultraExplorerBarContainerControl17.Controls.Add(this.uneDescuentoCombo);
            this.ultraExplorerBarContainerControl17.Controls.Add(this.gridListasDePreciosProductosCombo);
            this.ultraExplorerBarContainerControl17.Controls.Add(this.gridManagerView3);
            this.ultraExplorerBarContainerControl17.Controls.Add(this.gridManagerView2);
            this.ultraExplorerBarContainerControl17.Controls.Add(this.gridProductosCombo);
            this.ultraExplorerBarContainerControl17.Controls.Add(this.mzComboListaDePrecios);
            this.ultraExplorerBarContainerControl17.Controls.Add(this.mzProductosControl);
            this.ultraExplorerBarContainerControl17.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl17.Name = "ultraExplorerBarContainerControl17";
            this.ultraExplorerBarContainerControl17.Size = new System.Drawing.Size(1082, 496);
            this.ultraExplorerBarContainerControl17.TabIndex = 16;
            this.ultraExplorerBarContainerControl17.Visible = false;
            // 
            // btnAplicarDescuento
            // 
            this.btnAplicarDescuento.AcceptsFocus = false;
            this.btnAplicarDescuento.Location = new System.Drawing.Point(904, 88);
            this.btnAplicarDescuento.Name = "btnAplicarDescuento";
            this.btnAplicarDescuento.Size = new System.Drawing.Size(105, 26);
            this.btnAplicarDescuento.TabIndex = 1821;
            this.btnAplicarDescuento.TabStop = false;
            this.btnAplicarDescuento.Text = "Aplicar";
            // 
            // label63
            // 
            this.label63.BackColor = System.Drawing.Color.Transparent;
            this.label63.Location = new System.Drawing.Point(686, 89);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(87, 28);
            this.label63.TabIndex = 1820;
            this.label63.Text = "% Descuento";
            // 
            // uneDescuentoCombo
            // 
            this.uneDescuentoCombo.Location = new System.Drawing.Point(778, 90);
            this.uneDescuentoCombo.Name = "uneDescuentoCombo";
            this.uneDescuentoCombo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneDescuentoCombo.PromptChar = ' ';
            this.uneDescuentoCombo.Size = new System.Drawing.Size(120, 24);
            this.uneDescuentoCombo.TabIndex = 1819;
            // 
            // gridListasDePreciosProductosCombo
            // 
            this.gridListasDePreciosProductosCombo.AllowCardSizing = false;
            this.gridListasDePreciosProductosCombo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridListasDePreciosProductosCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridListasDePreciosProductosCombo.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridListasDePreciosProductosCombo.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridListasDePreciosProductosCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gridListasDePreciosProductosCombo.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridListasDePreciosProductosCombo.Location = new System.Drawing.Point(7, 308);
            this.gridListasDePreciosProductosCombo.Name = "gridListasDePreciosProductosCombo";
            this.gridListasDePreciosProductosCombo.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridListasDePreciosProductosCombo.Size = new System.Drawing.Size(1002, 185);
            this.gridListasDePreciosProductosCombo.TabIndex = 1818;
            this.gridListasDePreciosProductosCombo.TabStop = false;
            // 
            // gridManagerView3
            // 
            this.gridManagerView3.BackColor = System.Drawing.SystemColors.Control;
            this.gridManagerView3.Location = new System.Drawing.Point(7, 307);
            this.gridManagerView3.Name = "gridManagerView3";
            this.gridManagerView3.Size = new System.Drawing.Size(471, 28);
            this.gridManagerView3.TabIndex = 1817;
            // 
            // gridManagerView2
            // 
            this.gridManagerView2.BackColor = System.Drawing.SystemColors.Control;
            this.gridManagerView2.Location = new System.Drawing.Point(0, 83);
            this.gridManagerView2.Name = "gridManagerView2";
            this.gridManagerView2.Size = new System.Drawing.Size(470, 28);
            this.gridManagerView2.TabIndex = 1816;
            // 
            // gridProductosCombo
            // 
            this.gridProductosCombo.AllowCardSizing = false;
            this.gridProductosCombo.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridProductosCombo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridProductosCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridProductosCombo.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridProductosCombo.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridProductosCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gridProductosCombo.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridProductosCombo.Location = new System.Drawing.Point(5, 118);
            this.gridProductosCombo.Name = "gridProductosCombo";
            this.gridProductosCombo.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridProductosCombo.Size = new System.Drawing.Size(1002, 184);
            this.gridProductosCombo.TabIndex = 1815;
            this.gridProductosCombo.TabStop = false;
            // 
            // mzComboListaDePrecios
            // 
            this.mzComboListaDePrecios.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzComboListaDePrecios.DisplayMember = "";
            this.mzComboListaDePrecios.DisplayMemberCaption = "";
            this.mzComboListaDePrecios.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzComboListaDePrecios.Location = new System.Drawing.Point(469, 87);
            this.mzComboListaDePrecios.MaxItemsDisplay = 7;
            this.mzComboListaDePrecios.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzComboListaDePrecios.Name = "mzComboListaDePrecios";
            this.mzComboListaDePrecios.Size = new System.Drawing.Size(202, 24);
            this.mzComboListaDePrecios.SorterMember = "";
            this.mzComboListaDePrecios.TabIndex = 1814;
            this.mzComboListaDePrecios.ValueMember = "";
            this.mzComboListaDePrecios.ValueMemberCaption = "";
            // 
            // mzProductosControl
            // 
            this.mzProductosControl.BackColor = System.Drawing.Color.Transparent;
            this.mzProductosControl.EnabledCantidad = false;
            this.mzProductosControl.EnabledListaDePrecio = true;
            this.mzProductosControl.Location = new System.Drawing.Point(-10, -7);
            this.mzProductosControl.Name = "mzProductosControl";
            this.mzProductosControl.PermiteProductosCombo = false;
            this.mzProductosControl.Size = new System.Drawing.Size(939, 92);
            this.mzProductosControl.TabIndex = 9;
            this.mzProductosControl.VisibleCantidad = true;
            this.mzProductosControl.VisibleComboListaDePrecios = true;
            this.mzProductosControl.VisibleComboTipoDePrecioDeCosto = false;
            this.mzProductosControl.VisiblePrecios = true;
            // 
            // ultraExplorerBarContainerControl2
            // 
            this.ultraExplorerBarContainerControl2.Controls.Add(this.unePrecioDeCostoRef);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.uneMAC);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.unePrecioDeVentaNeto);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.groupBox6);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.labelSimboloMonedaPrecioDeListaConImpuestos);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.labelSimboloMonedaPrecioDeLista);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.labelSimboloMonedaDescuentoMaximo);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.labelSimboloMonedaPrecioDeVentaNeto);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.labelSimboloMonedaPrecioDeCostoReferencia);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.label20);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.unePrecioFinalMonedaReferencia);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.label19);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.unePrecioDeListaConImpuesto);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.label16);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.label15);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.label13);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.unePrecioVentaBruto);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.label12);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.uneMaxDescuento);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.label11);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.uneMaxDescuentoPorcentual);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.label10);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.label8);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.label7);
            this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
            this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(1082, 196);
            this.ultraExplorerBarContainerControl2.TabIndex = 1;
            this.ultraExplorerBarContainerControl2.Visible = false;
            // 
            // unePrecioDeCostoRef
            // 
            this.unePrecioDeCostoRef.Location = new System.Drawing.Point(269, 0);
            this.unePrecioDeCostoRef.MaskInput = "nnnnnnnn.nnnn";
            this.unePrecioDeCostoRef.Name = "unePrecioDeCostoRef";
            this.unePrecioDeCostoRef.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioDeCostoRef.Size = new System.Drawing.Size(120, 24);
            this.unePrecioDeCostoRef.TabIndex = 0;
            this.unePrecioDeCostoRef.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            this.unePrecioDeCostoRef.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // uneMAC
            // 
            this.uneMAC.Location = new System.Drawing.Point(269, 20);
            this.uneMAC.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.uneMAC.MaskInput = "-nnnnnn.nn";
            this.uneMAC.Name = "uneMAC";
            this.uneMAC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneMAC.Size = new System.Drawing.Size(120, 24);
            this.uneMAC.TabIndex = 1;
            this.uneMAC.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            this.uneMAC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // unePrecioDeVentaNeto
            // 
            this.unePrecioDeVentaNeto.Location = new System.Drawing.Point(269, 42);
            this.unePrecioDeVentaNeto.MaskInput = "nnnnnnnn.nnnn";
            this.unePrecioDeVentaNeto.Name = "unePrecioDeVentaNeto";
            this.unePrecioDeVentaNeto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioDeVentaNeto.ReadOnly = true;
            this.unePrecioDeVentaNeto.Size = new System.Drawing.Size(120, 24);
            this.unePrecioDeVentaNeto.TabIndex = 2;
            this.unePrecioDeVentaNeto.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            this.unePrecioDeVentaNeto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.unePCostoPromedioPonderado1);
            this.groupBox6.Controls.Add(this.unePrecioDeCostoReposicion1);
            this.groupBox6.Controls.Add(this.chkUsaPrecioDeCostoReposicion1);
            this.groupBox6.Controls.Add(this.labelSimboloMonedaPrecioDeCostoReposicion1);
            this.groupBox6.Controls.Add(this.label64);
            this.groupBox6.Controls.Add(this.ultraLabel7);
            this.groupBox6.Controls.Add(this.labelSimboloMonedaPrecioDeCosto4);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox6.Location = new System.Drawing.Point(0, 83);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(403, 91);
            this.groupBox6.TabIndex = 161;
            this.groupBox6.TabStop = false;
            // 
            // unePCostoPromedioPonderado1
            // 
            this.unePCostoPromedioPonderado1.Location = new System.Drawing.Point(269, 17);
            this.unePCostoPromedioPonderado1.Name = "unePCostoPromedioPonderado1";
            this.unePCostoPromedioPonderado1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePCostoPromedioPonderado1.PromptChar = ' ';
            this.unePCostoPromedioPonderado1.Size = new System.Drawing.Size(120, 24);
            this.unePCostoPromedioPonderado1.TabIndex = 8;
            this.unePCostoPromedioPonderado1.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // unePrecioDeCostoReposicion1
            // 
            this.unePrecioDeCostoReposicion1.Location = new System.Drawing.Point(269, 37);
            this.unePrecioDeCostoReposicion1.MaskInput = "nnnnnnnn.nn";
            this.unePrecioDeCostoReposicion1.Name = "unePrecioDeCostoReposicion1";
            this.unePrecioDeCostoReposicion1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioDeCostoReposicion1.Size = new System.Drawing.Size(120, 24);
            this.unePrecioDeCostoReposicion1.TabIndex = 9;
            this.unePrecioDeCostoReposicion1.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // chkUsaPrecioDeCostoReposicion1
            // 
            this.chkUsaPrecioDeCostoReposicion1.BackColor = System.Drawing.Color.Transparent;
            this.chkUsaPrecioDeCostoReposicion1.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkUsaPrecioDeCostoReposicion1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkUsaPrecioDeCostoReposicion1.Location = new System.Drawing.Point(10, 55);
            this.chkUsaPrecioDeCostoReposicion1.Name = "chkUsaPrecioDeCostoReposicion1";
            this.chkUsaPrecioDeCostoReposicion1.Size = new System.Drawing.Size(278, 23);
            this.chkUsaPrecioDeCostoReposicion1.TabIndex = 10;
            this.chkUsaPrecioDeCostoReposicion1.Text = "Usa Precio de Costo Reposición";
            // 
            // labelSimboloMonedaPrecioDeCostoReposicion1
            // 
            this.labelSimboloMonedaPrecioDeCostoReposicion1.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeCostoReposicion1.Location = new System.Drawing.Point(230, 37);
            this.labelSimboloMonedaPrecioDeCostoReposicion1.Name = "labelSimboloMonedaPrecioDeCostoReposicion1";
            this.labelSimboloMonedaPrecioDeCostoReposicion1.Size = new System.Drawing.Size(39, 18);
            this.labelSimboloMonedaPrecioDeCostoReposicion1.TabIndex = 158;
            this.labelSimboloMonedaPrecioDeCostoReposicion1.Text = "$";
            this.labelSimboloMonedaPrecioDeCostoReposicion1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label64
            // 
            this.label64.BackColor = System.Drawing.Color.Transparent;
            this.label64.Location = new System.Drawing.Point(10, 37);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(220, 18);
            this.label64.TabIndex = 157;
            this.label64.Text = "Precio de Costo de Reposición";
            // 
            // ultraLabel7
            // 
            this.ultraLabel7.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel7.Location = new System.Drawing.Point(10, 18);
            this.ultraLabel7.Name = "ultraLabel7";
            this.ultraLabel7.Size = new System.Drawing.Size(234, 18);
            this.ultraLabel7.TabIndex = 154;
            this.ultraLabel7.Text = "Precio de Costo Promedio Ponderado";
            // 
            // labelSimboloMonedaPrecioDeCosto4
            // 
            this.labelSimboloMonedaPrecioDeCosto4.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeCosto4.Location = new System.Drawing.Point(230, 18);
            this.labelSimboloMonedaPrecioDeCosto4.Name = "labelSimboloMonedaPrecioDeCosto4";
            this.labelSimboloMonedaPrecioDeCosto4.Size = new System.Drawing.Size(39, 20);
            this.labelSimboloMonedaPrecioDeCosto4.TabIndex = 155;
            this.labelSimboloMonedaPrecioDeCosto4.Text = "$";
            this.labelSimboloMonedaPrecioDeCosto4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia
            // 
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia.Location = new System.Drawing.Point(682, 84);
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia.Name = "labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia";
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia.Size = new System.Drawing.Size(38, 19);
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia.TabIndex = 95;
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia.Text = "$";
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaPrecioDeListaConImpuestos
            // 
            this.labelSimboloMonedaPrecioDeListaConImpuestos.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeListaConImpuestos.Location = new System.Drawing.Point(682, 61);
            this.labelSimboloMonedaPrecioDeListaConImpuestos.Name = "labelSimboloMonedaPrecioDeListaConImpuestos";
            this.labelSimboloMonedaPrecioDeListaConImpuestos.Size = new System.Drawing.Size(38, 19);
            this.labelSimboloMonedaPrecioDeListaConImpuestos.TabIndex = 94;
            this.labelSimboloMonedaPrecioDeListaConImpuestos.Text = "$";
            this.labelSimboloMonedaPrecioDeListaConImpuestos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaPrecioDeLista
            // 
            this.labelSimboloMonedaPrecioDeLista.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeLista.Location = new System.Drawing.Point(682, 40);
            this.labelSimboloMonedaPrecioDeLista.Name = "labelSimboloMonedaPrecioDeLista";
            this.labelSimboloMonedaPrecioDeLista.Size = new System.Drawing.Size(38, 19);
            this.labelSimboloMonedaPrecioDeLista.TabIndex = 93;
            this.labelSimboloMonedaPrecioDeLista.Text = "$";
            this.labelSimboloMonedaPrecioDeLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaDescuentoMaximo
            // 
            this.labelSimboloMonedaDescuentoMaximo.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaDescuentoMaximo.Location = new System.Drawing.Point(682, 22);
            this.labelSimboloMonedaDescuentoMaximo.Name = "labelSimboloMonedaDescuentoMaximo";
            this.labelSimboloMonedaDescuentoMaximo.Size = new System.Drawing.Size(38, 18);
            this.labelSimboloMonedaDescuentoMaximo.TabIndex = 92;
            this.labelSimboloMonedaDescuentoMaximo.Text = "$";
            this.labelSimboloMonedaDescuentoMaximo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaPrecioDeVentaNeto
            // 
            this.labelSimboloMonedaPrecioDeVentaNeto.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeVentaNeto.Location = new System.Drawing.Point(230, 43);
            this.labelSimboloMonedaPrecioDeVentaNeto.Name = "labelSimboloMonedaPrecioDeVentaNeto";
            this.labelSimboloMonedaPrecioDeVentaNeto.Size = new System.Drawing.Size(39, 18);
            this.labelSimboloMonedaPrecioDeVentaNeto.TabIndex = 91;
            this.labelSimboloMonedaPrecioDeVentaNeto.Text = "$";
            this.labelSimboloMonedaPrecioDeVentaNeto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaPrecioDeCostoReferencia
            // 
            this.labelSimboloMonedaPrecioDeCostoReferencia.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeCostoReferencia.Location = new System.Drawing.Point(230, 5);
            this.labelSimboloMonedaPrecioDeCostoReferencia.Name = "labelSimboloMonedaPrecioDeCostoReferencia";
            this.labelSimboloMonedaPrecioDeCostoReferencia.Size = new System.Drawing.Size(39, 18);
            this.labelSimboloMonedaPrecioDeCostoReferencia.TabIndex = 90;
            this.labelSimboloMonedaPrecioDeCostoReferencia.Text = "$";
            this.labelSimboloMonedaPrecioDeCostoReferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(451, 89);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(221, 24);
            this.label20.TabIndex = 89;
            this.label20.Text = "Pcio Vta Bruto C/ Imp Moneda Ref.";
            // 
            // unePrecioFinalMonedaReferencia
            // 
            this.unePrecioFinalMonedaReferencia.Location = new System.Drawing.Point(720, 81);
            this.unePrecioFinalMonedaReferencia.MaskInput = "nnnnnnnn.nnnn";
            this.unePrecioFinalMonedaReferencia.Name = "unePrecioFinalMonedaReferencia";
            this.unePrecioFinalMonedaReferencia.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioFinalMonedaReferencia.Size = new System.Drawing.Size(120, 24);
            this.unePrecioFinalMonedaReferencia.TabIndex = 7;
            this.unePrecioFinalMonedaReferencia.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(451, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(240, 24);
            this.label19.TabIndex = 87;
            this.label19.Text = "Precio de Venta Bruto Con Impuestos";
            // 
            // unePrecioDeListaConImpuesto
            // 
            this.unePrecioDeListaConImpuesto.Location = new System.Drawing.Point(720, 58);
            this.unePrecioDeListaConImpuesto.MaskInput = "nnnnnnnn.nnnn";
            this.unePrecioDeListaConImpuesto.Name = "unePrecioDeListaConImpuesto";
            this.unePrecioDeListaConImpuesto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioDeListaConImpuesto.Size = new System.Drawing.Size(120, 24);
            this.unePrecioDeListaConImpuesto.TabIndex = 6;
            this.unePrecioDeListaConImpuesto.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(845, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 19);
            this.label16.TabIndex = 25;
            this.label16.Text = "%";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(394, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 18);
            this.label15.TabIndex = 24;
            this.label15.Text = "%";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(451, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(240, 24);
            this.label13.TabIndex = 23;
            this.label13.Text = "Precio de Venta Bruto (Precio de Lista)";
            // 
            // unePrecioVentaBruto
            // 
            this.unePrecioVentaBruto.Location = new System.Drawing.Point(720, 37);
            this.unePrecioVentaBruto.MaskInput = "nnnnnnnn.nnnn";
            this.unePrecioVentaBruto.Name = "unePrecioVentaBruto";
            this.unePrecioVentaBruto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioVentaBruto.Size = new System.Drawing.Size(120, 24);
            this.unePrecioVentaBruto.TabIndex = 5;
            this.unePrecioVentaBruto.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            this.unePrecioVentaBruto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(451, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(231, 24);
            this.label12.TabIndex = 21;
            this.label12.Text = "Descuento Máximo s/Precio de Lista";
            // 
            // uneMaxDescuento
            // 
            this.uneMaxDescuento.Location = new System.Drawing.Point(720, 18);
            this.uneMaxDescuento.MaskInput = "-nnnnnnnn.nnnn";
            this.uneMaxDescuento.Name = "uneMaxDescuento";
            this.uneMaxDescuento.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneMaxDescuento.ReadOnly = true;
            this.uneMaxDescuento.Size = new System.Drawing.Size(120, 24);
            this.uneMaxDescuento.TabIndex = 4;
            this.uneMaxDescuento.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            this.uneMaxDescuento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(451, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(250, 24);
            this.label11.TabIndex = 19;
            this.label11.Text = "Descuento Porcentual s/Precio de Lista";
            // 
            // uneMaxDescuentoPorcentual
            // 
            this.uneMaxDescuentoPorcentual.Location = new System.Drawing.Point(720, 0);
            this.uneMaxDescuentoPorcentual.MaskInput = "-nnnnnn.nn";
            this.uneMaxDescuentoPorcentual.Name = "uneMaxDescuentoPorcentual";
            this.uneMaxDescuentoPorcentual.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneMaxDescuentoPorcentual.ReadOnly = true;
            this.uneMaxDescuentoPorcentual.Size = new System.Drawing.Size(120, 24);
            this.uneMaxDescuentoPorcentual.TabIndex = 3;
            this.uneMaxDescuentoPorcentual.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            this.uneMaxDescuentoPorcentual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(0, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "Precio de Venta Neto";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(0, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Precio de Costo Referencia";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(0, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Margen/Precio Costo Neto";
            // 
            // ultraExplorerBarContainerControl14
            // 
            this.ultraExplorerBarContainerControl14.Controls.Add(this.gridManagerView1);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferenciaLP);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.labelSimboloMonedaPrecioDeListaConImpuestosLP);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.labelSimboloMonedaPrecioDeListaLP);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.labelSimboloMonedaDescuentoMaximoLP);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.label30);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.unePrecioFinalMonedaReferenciaLP);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.label31);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.unePrecioDeListaConImpuestoLP);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.label32);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.label33);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.unePrecioVentaBrutoLP);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.label34);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.uneMaxDescuentoLP);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.label35);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.uneMaxDescuentoPorcentualLP);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.btnRestablecerAGral);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.label27);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.label28);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.uneCoeficienteMonedaReferencia);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.uneCoeficiente);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.label29);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.labelSimboloMonedaPrecioDeVentaNetoLP);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.labelSimboloMonedaPrecioDeCostoReferenciaLP);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.label25);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.unePrecioDeCostoRefLP);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.label26);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.label22);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.uneMACLP);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.label23);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.unePrecioDeVentaNetoLP);
            this.ultraExplorerBarContainerControl14.Controls.Add(this.gridListaDePrecios);
            this.ultraExplorerBarContainerControl14.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl14.Name = "ultraExplorerBarContainerControl14";
            this.ultraExplorerBarContainerControl14.Size = new System.Drawing.Size(1082, 346);
            this.ultraExplorerBarContainerControl14.TabIndex = 12;
            this.ultraExplorerBarContainerControl14.Visible = false;
            // 
            // gridManagerView1
            // 
            this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
            this.gridManagerView1.Location = new System.Drawing.Point(0, 46);
            this.gridManagerView1.Name = "gridManagerView1";
            this.gridManagerView1.Size = new System.Drawing.Size(1037, 28);
            this.gridManagerView1.TabIndex = 169;
            this.gridManagerView1.Visible = false;
            // 
            // labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferenciaLP
            // 
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferenciaLP.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferenciaLP.Location = new System.Drawing.Point(691, 292);
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferenciaLP.Name = "labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferenciaLP";
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferenciaLP.Size = new System.Drawing.Size(39, 18);
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferenciaLP.TabIndex = 168;
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferenciaLP.Text = "$";
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferenciaLP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaPrecioDeListaConImpuestosLP
            // 
            this.labelSimboloMonedaPrecioDeListaConImpuestosLP.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeListaConImpuestosLP.Location = new System.Drawing.Point(691, 271);
            this.labelSimboloMonedaPrecioDeListaConImpuestosLP.Name = "labelSimboloMonedaPrecioDeListaConImpuestosLP";
            this.labelSimboloMonedaPrecioDeListaConImpuestosLP.Size = new System.Drawing.Size(39, 19);
            this.labelSimboloMonedaPrecioDeListaConImpuestosLP.TabIndex = 167;
            this.labelSimboloMonedaPrecioDeListaConImpuestosLP.Text = "$";
            this.labelSimboloMonedaPrecioDeListaConImpuestosLP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaPrecioDeListaLP
            // 
            this.labelSimboloMonedaPrecioDeListaLP.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeListaLP.Location = new System.Drawing.Point(240, 323);
            this.labelSimboloMonedaPrecioDeListaLP.Name = "labelSimboloMonedaPrecioDeListaLP";
            this.labelSimboloMonedaPrecioDeListaLP.Size = new System.Drawing.Size(38, 19);
            this.labelSimboloMonedaPrecioDeListaLP.TabIndex = 166;
            this.labelSimboloMonedaPrecioDeListaLP.Text = "$";
            this.labelSimboloMonedaPrecioDeListaLP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaDescuentoMaximoLP
            // 
            this.labelSimboloMonedaDescuentoMaximoLP.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaDescuentoMaximoLP.Location = new System.Drawing.Point(240, 295);
            this.labelSimboloMonedaDescuentoMaximoLP.Name = "labelSimboloMonedaDescuentoMaximoLP";
            this.labelSimboloMonedaDescuentoMaximoLP.Size = new System.Drawing.Size(38, 19);
            this.labelSimboloMonedaDescuentoMaximoLP.TabIndex = 165;
            this.labelSimboloMonedaDescuentoMaximoLP.Text = "$";
            this.labelSimboloMonedaDescuentoMaximoLP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Location = new System.Drawing.Point(461, 294);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(221, 24);
            this.label30.TabIndex = 164;
            this.label30.Text = "Pcio Vta Bruto C/ Imp Moneda Ref.";
            // 
            // unePrecioFinalMonedaReferenciaLP
            // 
            this.unePrecioFinalMonedaReferenciaLP.Location = new System.Drawing.Point(730, 288);
            this.unePrecioFinalMonedaReferenciaLP.MaskInput = "nnnnnnnn.nnnn";
            this.unePrecioFinalMonedaReferenciaLP.Name = "unePrecioFinalMonedaReferenciaLP";
            this.unePrecioFinalMonedaReferenciaLP.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioFinalMonedaReferenciaLP.Size = new System.Drawing.Size(120, 24);
            this.unePrecioFinalMonedaReferenciaLP.TabIndex = 11;
            this.unePrecioFinalMonedaReferenciaLP.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Location = new System.Drawing.Point(461, 269);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(240, 24);
            this.label31.TabIndex = 162;
            this.label31.Text = "Precio de Venta Bruto Con Impuestos";
            // 
            // unePrecioDeListaConImpuestoLP
            // 
            this.unePrecioDeListaConImpuestoLP.Location = new System.Drawing.Point(730, 264);
            this.unePrecioDeListaConImpuestoLP.MaskInput = "nnnnnnnn.nnnn";
            this.unePrecioDeListaConImpuestoLP.Name = "unePrecioDeListaConImpuestoLP";
            this.unePrecioDeListaConImpuestoLP.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioDeListaConImpuestoLP.Size = new System.Drawing.Size(120, 24);
            this.unePrecioDeListaConImpuestoLP.TabIndex = 10;
            this.unePrecioDeListaConImpuestoLP.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Location = new System.Drawing.Point(403, 268);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(39, 18);
            this.label32.TabIndex = 160;
            this.label32.Text = "%";
            // 
            // label33
            // 
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Location = new System.Drawing.Point(10, 314);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(240, 24);
            this.label33.TabIndex = 159;
            this.label33.Text = "Precio de Venta Bruto (Precio de Lista)";
            // 
            // unePrecioVentaBrutoLP
            // 
            this.unePrecioVentaBrutoLP.Location = new System.Drawing.Point(278, 314);
            this.unePrecioVentaBrutoLP.MaskInput = "nnnnnnnn.nnnn";
            this.unePrecioVentaBrutoLP.Name = "unePrecioVentaBrutoLP";
            this.unePrecioVentaBrutoLP.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioVentaBrutoLP.Size = new System.Drawing.Size(120, 24);
            this.unePrecioVentaBrutoLP.TabIndex = 9;
            this.unePrecioVentaBrutoLP.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label34
            // 
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Location = new System.Drawing.Point(10, 291);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(230, 24);
            this.label34.TabIndex = 158;
            this.label34.Text = "Descuento Máximo s/Precio de Lista";
            // 
            // uneMaxDescuentoLP
            // 
            this.uneMaxDescuentoLP.Location = new System.Drawing.Point(278, 291);
            this.uneMaxDescuentoLP.MaskInput = "nnnnnnnn.nnnn";
            this.uneMaxDescuentoLP.Name = "uneMaxDescuentoLP";
            this.uneMaxDescuentoLP.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneMaxDescuentoLP.ReadOnly = true;
            this.uneMaxDescuentoLP.Size = new System.Drawing.Size(120, 24);
            this.uneMaxDescuentoLP.TabIndex = 8;
            this.uneMaxDescuentoLP.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label35
            // 
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Location = new System.Drawing.Point(10, 268);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(249, 24);
            this.label35.TabIndex = 157;
            this.label35.Text = "Descuento Porcentual s/Precio de Lista";
            // 
            // uneMaxDescuentoPorcentualLP
            // 
            this.uneMaxDescuentoPorcentualLP.Location = new System.Drawing.Point(278, 268);
            this.uneMaxDescuentoPorcentualLP.Name = "uneMaxDescuentoPorcentualLP";
            this.uneMaxDescuentoPorcentualLP.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneMaxDescuentoPorcentualLP.ReadOnly = true;
            this.uneMaxDescuentoPorcentualLP.Size = new System.Drawing.Size(120, 24);
            this.uneMaxDescuentoPorcentualLP.TabIndex = 7;
            this.uneMaxDescuentoPorcentualLP.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // btnRestablecerAGral
            // 
            this.btnRestablecerAGral.BackColor = System.Drawing.SystemColors.Control;
            this.btnRestablecerAGral.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRestablecerAGral.Location = new System.Drawing.Point(557, 231);
            this.btnRestablecerAGral.Name = "btnRestablecerAGral";
            this.btnRestablecerAGral.Size = new System.Drawing.Size(163, 23);
            this.btnRestablecerAGral.TabIndex = 6;
            this.btnRestablecerAGral.Text = "Restablecer a General";
            this.btnRestablecerAGral.UseVisualStyleBackColor = false;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(250, 235);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(163, 19);
            this.label27.TabIndex = 152;
            this.label27.Text = "Coeficiente Moneda Ref.";
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(10, 237);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(96, 18);
            this.label28.TabIndex = 151;
            this.label28.Text = "Coeficiente";
            // 
            // uneCoeficienteMonedaReferencia
            // 
            this.uneCoeficienteMonedaReferencia.Location = new System.Drawing.Point(422, 231);
            this.uneCoeficienteMonedaReferencia.MaskInput = "nnnnnnnn.nnnn";
            this.uneCoeficienteMonedaReferencia.Name = "uneCoeficienteMonedaReferencia";
            this.uneCoeficienteMonedaReferencia.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficienteMonedaReferencia.Size = new System.Drawing.Size(106, 24);
            this.uneCoeficienteMonedaReferencia.TabIndex = 5;
            this.uneCoeficienteMonedaReferencia.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficiente
            // 
            this.uneCoeficiente.Location = new System.Drawing.Point(106, 231);
            this.uneCoeficiente.Name = "uneCoeficiente";
            this.uneCoeficiente.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficiente.Size = new System.Drawing.Size(105, 24);
            this.uneCoeficiente.TabIndex = 4;
            this.uneCoeficiente.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Location = new System.Drawing.Point(211, 234);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(19, 19);
            this.label29.TabIndex = 148;
            this.label29.Text = "%";
            // 
            // labelSimboloMonedaPrecioDeVentaNetoLP
            // 
            this.labelSimboloMonedaPrecioDeVentaNetoLP.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeVentaNetoLP.Location = new System.Drawing.Point(845, 9);
            this.labelSimboloMonedaPrecioDeVentaNetoLP.Name = "labelSimboloMonedaPrecioDeVentaNetoLP";
            this.labelSimboloMonedaPrecioDeVentaNetoLP.Size = new System.Drawing.Size(38, 19);
            this.labelSimboloMonedaPrecioDeVentaNetoLP.TabIndex = 92;
            this.labelSimboloMonedaPrecioDeVentaNetoLP.Text = "$";
            this.labelSimboloMonedaPrecioDeVentaNetoLP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaPrecioDeCostoReferenciaLP
            // 
            this.labelSimboloMonedaPrecioDeCostoReferenciaLP.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeCostoReferenciaLP.Location = new System.Drawing.Point(182, 9);
            this.labelSimboloMonedaPrecioDeCostoReferenciaLP.Name = "labelSimboloMonedaPrecioDeCostoReferenciaLP";
            this.labelSimboloMonedaPrecioDeCostoReferenciaLP.Size = new System.Drawing.Size(39, 19);
            this.labelSimboloMonedaPrecioDeCostoReferenciaLP.TabIndex = 91;
            this.labelSimboloMonedaPrecioDeCostoReferenciaLP.Text = "$";
            this.labelSimboloMonedaPrecioDeCostoReferenciaLP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(19, 9);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(173, 24);
            this.label25.TabIndex = 88;
            this.label25.Text = "Precio de Costo Referencia";
            // 
            // unePrecioDeCostoRefLP
            // 
            this.unePrecioDeCostoRefLP.Location = new System.Drawing.Point(221, 3);
            this.unePrecioDeCostoRefLP.MaskInput = "nnnnnnnn.nnnn";
            this.unePrecioDeCostoRefLP.Name = "unePrecioDeCostoRefLP";
            this.unePrecioDeCostoRefLP.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioDeCostoRefLP.Size = new System.Drawing.Size(120, 24);
            this.unePrecioDeCostoRefLP.TabIndex = 0;
            this.unePrecioDeCostoRefLP.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Location = new System.Drawing.Point(355, 9);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(173, 24);
            this.label26.TabIndex = 87;
            this.label26.Text = "Margen/Precio Costo Neto";
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(653, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 19);
            this.label22.TabIndex = 90;
            this.label22.Text = "%";
            // 
            // uneMACLP
            // 
            this.uneMACLP.Location = new System.Drawing.Point(528, 3);
            this.uneMACLP.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.uneMACLP.MaskInput = "-nnnnnn.nn";
            this.uneMACLP.Name = "uneMACLP";
            this.uneMACLP.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneMACLP.Size = new System.Drawing.Size(120, 24);
            this.uneMACLP.TabIndex = 1;
            this.uneMACLP.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(701, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(134, 24);
            this.label23.TabIndex = 89;
            this.label23.Text = "Precio de Venta Neto";
            // 
            // unePrecioDeVentaNetoLP
            // 
            this.unePrecioDeVentaNetoLP.Location = new System.Drawing.Point(883, 3);
            this.unePrecioDeVentaNetoLP.MaskInput = "nnnnnnnn.nnnn";
            this.unePrecioDeVentaNetoLP.Name = "unePrecioDeVentaNetoLP";
            this.unePrecioDeVentaNetoLP.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioDeVentaNetoLP.ReadOnly = true;
            this.unePrecioDeVentaNetoLP.Size = new System.Drawing.Size(120, 24);
            this.unePrecioDeVentaNetoLP.TabIndex = 2;
            this.unePrecioDeVentaNetoLP.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
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
            this.gridListaDePrecios.Location = new System.Drawing.Point(0, 37);
            this.gridListaDePrecios.Name = "gridListaDePrecios";
            this.gridListaDePrecios.RecordNavigatorText = "Registro:|de";
            this.gridListaDePrecios.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridListaDePrecios.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridListaDePrecios.ShowEmptyFields = false;
            this.gridListaDePrecios.Size = new System.Drawing.Size(1075, 189);
            this.gridListaDePrecios.TabIndex = 3;
            this.gridListaDePrecios.TabStop = false;
            this.gridListaDePrecios.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            // 
            // ultraExplorerBarContainerControl11
            // 
            this.ultraExplorerBarContainerControl11.Controls.Add(this.labelDefaultCoeficiente5);
            this.ultraExplorerBarContainerControl11.Controls.Add(this.labelDefaultCoeficiente4);
            this.ultraExplorerBarContainerControl11.Controls.Add(this.labelDefaultCoeficiente3);
            this.ultraExplorerBarContainerControl11.Controls.Add(this.labelDefaultCoeficiente2);
            this.ultraExplorerBarContainerControl11.Controls.Add(this.labelDefaultCoeficiente1);
            this.ultraExplorerBarContainerControl11.Controls.Add(this.labelCoeficiente5);
            this.ultraExplorerBarContainerControl11.Controls.Add(this.labelCoeficiente4);
            this.ultraExplorerBarContainerControl11.Controls.Add(this.labelCoeficiente3);
            this.ultraExplorerBarContainerControl11.Controls.Add(this.uneCoeficientePorc51);
            this.ultraExplorerBarContainerControl11.Controls.Add(this.uneCoeficientePorc41);
            this.ultraExplorerBarContainerControl11.Controls.Add(this.uneCoeficientePorc31);
            this.ultraExplorerBarContainerControl11.Controls.Add(this.uneCoeficientePorc21);
            this.ultraExplorerBarContainerControl11.Controls.Add(this.uneCoeficientePorc11);
            this.ultraExplorerBarContainerControl11.Controls.Add(this.labelCoeficiente1);
            this.ultraExplorerBarContainerControl11.Controls.Add(this.labelCoeficiente2);
            this.ultraExplorerBarContainerControl11.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl11.Name = "ultraExplorerBarContainerControl11";
            this.ultraExplorerBarContainerControl11.Size = new System.Drawing.Size(1082, 122);
            this.ultraExplorerBarContainerControl11.TabIndex = 9;
            this.ultraExplorerBarContainerControl11.Visible = false;
            // 
            // labelDefaultCoeficiente5
            // 
            this.labelDefaultCoeficiente5.BackColor = System.Drawing.Color.Transparent;
            this.labelDefaultCoeficiente5.Location = new System.Drawing.Point(0, 103);
            this.labelDefaultCoeficiente5.Name = "labelDefaultCoeficiente5";
            this.labelDefaultCoeficiente5.Size = new System.Drawing.Size(96, 18);
            this.labelDefaultCoeficiente5.TabIndex = 127;
            this.labelDefaultCoeficiente5.Text = "Coeficiente 5";
            // 
            // labelDefaultCoeficiente4
            // 
            this.labelDefaultCoeficiente4.BackColor = System.Drawing.Color.Transparent;
            this.labelDefaultCoeficiente4.Location = new System.Drawing.Point(0, 78);
            this.labelDefaultCoeficiente4.Name = "labelDefaultCoeficiente4";
            this.labelDefaultCoeficiente4.Size = new System.Drawing.Size(96, 19);
            this.labelDefaultCoeficiente4.TabIndex = 126;
            this.labelDefaultCoeficiente4.Text = "Coeficiente 4";
            // 
            // labelDefaultCoeficiente3
            // 
            this.labelDefaultCoeficiente3.BackColor = System.Drawing.Color.Transparent;
            this.labelDefaultCoeficiente3.Location = new System.Drawing.Point(0, 55);
            this.labelDefaultCoeficiente3.Name = "labelDefaultCoeficiente3";
            this.labelDefaultCoeficiente3.Size = new System.Drawing.Size(96, 19);
            this.labelDefaultCoeficiente3.TabIndex = 125;
            this.labelDefaultCoeficiente3.Text = "Coeficiente 3";
            // 
            // labelDefaultCoeficiente2
            // 
            this.labelDefaultCoeficiente2.BackColor = System.Drawing.Color.Transparent;
            this.labelDefaultCoeficiente2.Location = new System.Drawing.Point(0, 32);
            this.labelDefaultCoeficiente2.Name = "labelDefaultCoeficiente2";
            this.labelDefaultCoeficiente2.Size = new System.Drawing.Size(96, 19);
            this.labelDefaultCoeficiente2.TabIndex = 124;
            this.labelDefaultCoeficiente2.Text = "Coeficiente 2";
            // 
            // labelDefaultCoeficiente1
            // 
            this.labelDefaultCoeficiente1.BackColor = System.Drawing.Color.Transparent;
            this.labelDefaultCoeficiente1.Location = new System.Drawing.Point(0, 9);
            this.labelDefaultCoeficiente1.Name = "labelDefaultCoeficiente1";
            this.labelDefaultCoeficiente1.Size = new System.Drawing.Size(96, 19);
            this.labelDefaultCoeficiente1.TabIndex = 123;
            this.labelDefaultCoeficiente1.Text = "Coeficiente 1";
            // 
            // labelCoeficiente5
            // 
            this.labelCoeficiente5.BackColor = System.Drawing.Color.Transparent;
            this.labelCoeficiente5.Location = new System.Drawing.Point(202, 102);
            this.labelCoeficiente5.Name = "labelCoeficiente5";
            this.labelCoeficiente5.Size = new System.Drawing.Size(19, 18);
            this.labelCoeficiente5.TabIndex = 117;
            this.labelCoeficiente5.Text = "%";
            // 
            // labelCoeficiente4
            // 
            this.labelCoeficiente4.BackColor = System.Drawing.Color.Transparent;
            this.labelCoeficiente4.Location = new System.Drawing.Point(202, 81);
            this.labelCoeficiente4.Name = "labelCoeficiente4";
            this.labelCoeficiente4.Size = new System.Drawing.Size(19, 18);
            this.labelCoeficiente4.TabIndex = 116;
            this.labelCoeficiente4.Text = "%";
            // 
            // labelCoeficiente3
            // 
            this.labelCoeficiente3.BackColor = System.Drawing.Color.Transparent;
            this.labelCoeficiente3.Location = new System.Drawing.Point(202, 57);
            this.labelCoeficiente3.Name = "labelCoeficiente3";
            this.labelCoeficiente3.Size = new System.Drawing.Size(19, 18);
            this.labelCoeficiente3.TabIndex = 115;
            this.labelCoeficiente3.Text = "%";
            // 
            // uneCoeficientePorc51
            // 
            this.uneCoeficientePorc51.Location = new System.Drawing.Point(96, 97);
            this.uneCoeficientePorc51.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc51.Name = "uneCoeficientePorc51";
            this.uneCoeficientePorc51.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc51.Size = new System.Drawing.Size(106, 24);
            this.uneCoeficientePorc51.TabIndex = 114;
            this.uneCoeficientePorc51.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficientePorc41
            // 
            this.uneCoeficientePorc41.Location = new System.Drawing.Point(96, 74);
            this.uneCoeficientePorc41.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc41.Name = "uneCoeficientePorc41";
            this.uneCoeficientePorc41.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc41.Size = new System.Drawing.Size(106, 24);
            this.uneCoeficientePorc41.TabIndex = 113;
            this.uneCoeficientePorc41.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficientePorc31
            // 
            this.uneCoeficientePorc31.Location = new System.Drawing.Point(96, 51);
            this.uneCoeficientePorc31.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc31.Name = "uneCoeficientePorc31";
            this.uneCoeficientePorc31.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc31.Size = new System.Drawing.Size(106, 24);
            this.uneCoeficientePorc31.TabIndex = 112;
            this.uneCoeficientePorc31.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficientePorc21
            // 
            this.uneCoeficientePorc21.Location = new System.Drawing.Point(96, 28);
            this.uneCoeficientePorc21.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc21.Name = "uneCoeficientePorc21";
            this.uneCoeficientePorc21.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc21.Size = new System.Drawing.Size(106, 24);
            this.uneCoeficientePorc21.TabIndex = 111;
            this.uneCoeficientePorc21.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficientePorc11
            // 
            this.uneCoeficientePorc11.Location = new System.Drawing.Point(96, 5);
            this.uneCoeficientePorc11.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc11.Name = "uneCoeficientePorc11";
            this.uneCoeficientePorc11.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc11.Size = new System.Drawing.Size(106, 24);
            this.uneCoeficientePorc11.TabIndex = 110;
            this.uneCoeficientePorc11.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // labelCoeficiente1
            // 
            this.labelCoeficiente1.BackColor = System.Drawing.Color.Transparent;
            this.labelCoeficiente1.Location = new System.Drawing.Point(202, 9);
            this.labelCoeficiente1.Name = "labelCoeficiente1";
            this.labelCoeficiente1.Size = new System.Drawing.Size(19, 19);
            this.labelCoeficiente1.TabIndex = 108;
            this.labelCoeficiente1.Text = "%";
            // 
            // labelCoeficiente2
            // 
            this.labelCoeficiente2.BackColor = System.Drawing.Color.Transparent;
            this.labelCoeficiente2.Location = new System.Drawing.Point(202, 35);
            this.labelCoeficiente2.Name = "labelCoeficiente2";
            this.labelCoeficiente2.Size = new System.Drawing.Size(19, 18);
            this.labelCoeficiente2.TabIndex = 109;
            this.labelCoeficiente2.Text = "%";
            // 
            // ultraExplorerBarContainerControl3
            // 
            this.ultraExplorerBarContainerControl3.Controls.Add(this.chkCodigoSecundarioSegmentado);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.label21);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.uneContador);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.ucePercibeIB);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.gridImpuestos);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.chkObligaNumeroSerie);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.chkObligaCodigoBarra);
            this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
            this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(1082, 135);
            this.ultraExplorerBarContainerControl3.TabIndex = 2;
            this.ultraExplorerBarContainerControl3.Visible = false;
            // 
            // chkCodigoSecundarioSegmentado
            // 
            this.chkCodigoSecundarioSegmentado.BackColor = System.Drawing.Color.Transparent;
            this.chkCodigoSecundarioSegmentado.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkCodigoSecundarioSegmentado.Location = new System.Drawing.Point(19, 83);
            this.chkCodigoSecundarioSegmentado.Name = "chkCodigoSecundarioSegmentado";
            this.chkCodigoSecundarioSegmentado.Size = new System.Drawing.Size(183, 23);
            this.chkCodigoSecundarioSegmentado.TabIndex = 3;
            this.chkCodigoSecundarioSegmentado.Text = "Cod. Barras Segmentado";
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(19, 111);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 18);
            this.label21.TabIndex = 78;
            this.label21.Text = "Contador";
            // 
            // uneContador
            // 
            this.uneContador.Location = new System.Drawing.Point(115, 108);
            this.uneContador.MaxValue = 999999;
            this.uneContador.MinValue = 0;
            this.uneContador.Name = "uneContador";
            this.uneContador.Size = new System.Drawing.Size(87, 24);
            this.uneContador.TabIndex = 4;
            this.uneContador.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ucePercibeIB
            // 
            this.ucePercibeIB.BackColor = System.Drawing.Color.Transparent;
            this.ucePercibeIB.BackColorInternal = System.Drawing.Color.Transparent;
            this.ucePercibeIB.Enabled = false;
            this.ucePercibeIB.Location = new System.Drawing.Point(19, 58);
            this.ucePercibeIB.Name = "ucePercibeIB";
            this.ucePercibeIB.Size = new System.Drawing.Size(183, 23);
            this.ucePercibeIB.TabIndex = 2;
            this.ucePercibeIB.Text = "Percibe Ing. Brutos";
            // 
            // gridImpuestos
            // 
            this.gridImpuestos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridImpuestos.AlternatingColors = true;
            this.gridImpuestos.AutomaticSort = false;
            this.gridImpuestos.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridImpuestos.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridImpuestos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridImpuestos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridImpuestos.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridImpuestos.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
            this.gridImpuestos.GroupByBoxVisible = false;
            this.gridImpuestos.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridImpuestos.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridImpuestos.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
            this.gridImpuestos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
            this.gridImpuestos.Location = new System.Drawing.Point(250, 9);
            this.gridImpuestos.Name = "gridImpuestos";
            this.gridImpuestos.RecordNavigator = true;
            this.gridImpuestos.RecordNavigatorText = "Registro:|de";
            this.gridImpuestos.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridImpuestos.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridImpuestos.ShowEmptyFields = false;
            this.gridImpuestos.Size = new System.Drawing.Size(748, 133);
            this.gridImpuestos.TabIndex = 5;
            this.gridImpuestos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            // 
            // chkObligaNumeroSerie
            // 
            this.chkObligaNumeroSerie.BackColor = System.Drawing.Color.Transparent;
            this.chkObligaNumeroSerie.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkObligaNumeroSerie.Enabled = false;
            this.chkObligaNumeroSerie.Location = new System.Drawing.Point(19, 33);
            this.chkObligaNumeroSerie.Name = "chkObligaNumeroSerie";
            this.chkObligaNumeroSerie.Size = new System.Drawing.Size(183, 24);
            this.chkObligaNumeroSerie.TabIndex = 1;
            this.chkObligaNumeroSerie.Text = "Obliga Numero de Serie";
            // 
            // chkObligaCodigoBarra
            // 
            this.chkObligaCodigoBarra.BackColor = System.Drawing.Color.Transparent;
            this.chkObligaCodigoBarra.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkObligaCodigoBarra.Enabled = false;
            this.chkObligaCodigoBarra.Location = new System.Drawing.Point(19, 6);
            this.chkObligaCodigoBarra.Name = "chkObligaCodigoBarra";
            this.chkObligaCodigoBarra.Size = new System.Drawing.Size(183, 23);
            this.chkObligaCodigoBarra.TabIndex = 0;
            this.chkObligaCodigoBarra.Text = "Obliga Codigo Barras";
            // 
            // ultraExplorerBarContainerControl6
            // 
            this.ultraExplorerBarContainerControl6.Controls.Add(this.groupBox2);
            this.ultraExplorerBarContainerControl6.Controls.Add(this.groupBox1);
            this.ultraExplorerBarContainerControl6.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl6.Name = "ultraExplorerBarContainerControl6";
            this.ultraExplorerBarContainerControl6.Size = new System.Drawing.Size(1082, 150);
            this.ultraExplorerBarContainerControl6.TabIndex = 5;
            this.ultraExplorerBarContainerControl6.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.mzCEFuenteDeCambioPrecioDeCosto);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.mzCEMonedaPrecioDeCosto);
            this.groupBox2.Location = new System.Drawing.Point(0, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 129);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Precio de Costo";
            // 
            // mzCEFuenteDeCambioPrecioDeCosto
            // 
            this.mzCEFuenteDeCambioPrecioDeCosto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEFuenteDeCambioPrecioDeCosto.DisplayMember = "";
            this.mzCEFuenteDeCambioPrecioDeCosto.DisplayMemberCaption = "";
            this.mzCEFuenteDeCambioPrecioDeCosto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEFuenteDeCambioPrecioDeCosto.Location = new System.Drawing.Point(19, 92);
            this.mzCEFuenteDeCambioPrecioDeCosto.MaxItemsDisplay = 200;
            this.mzCEFuenteDeCambioPrecioDeCosto.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEFuenteDeCambioPrecioDeCosto.Name = "mzCEFuenteDeCambioPrecioDeCosto";
            this.mzCEFuenteDeCambioPrecioDeCosto.Size = new System.Drawing.Size(154, 24);
            this.mzCEFuenteDeCambioPrecioDeCosto.SorterMember = "";
            this.mzCEFuenteDeCambioPrecioDeCosto.TabIndex = 1;
            this.mzCEFuenteDeCambioPrecioDeCosto.ValueMember = "";
            this.mzCEFuenteDeCambioPrecioDeCosto.ValueMemberCaption = "";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(19, 74);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(268, 18);
            this.label18.TabIndex = 34;
            this.label18.Text = "Fuente de Cambio";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(19, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(268, 18);
            this.label17.TabIndex = 33;
            this.label17.Text = "Moneda ";
            // 
            // mzCEMonedaPrecioDeCosto
            // 
            this.mzCEMonedaPrecioDeCosto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEMonedaPrecioDeCosto.DisplayMember = "";
            this.mzCEMonedaPrecioDeCosto.DisplayMemberCaption = "";
            this.mzCEMonedaPrecioDeCosto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEMonedaPrecioDeCosto.Location = new System.Drawing.Point(19, 46);
            this.mzCEMonedaPrecioDeCosto.MaxItemsDisplay = 200;
            this.mzCEMonedaPrecioDeCosto.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEMonedaPrecioDeCosto.Name = "mzCEMonedaPrecioDeCosto";
            this.mzCEMonedaPrecioDeCosto.Size = new System.Drawing.Size(154, 24);
            this.mzCEMonedaPrecioDeCosto.SorterMember = "";
            this.mzCEMonedaPrecioDeCosto.TabIndex = 0;
            this.mzCEMonedaPrecioDeCosto.ValueMember = "";
            this.mzCEMonedaPrecioDeCosto.ValueMemberCaption = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mzCEMoneda);
            this.groupBox1.Location = new System.Drawing.Point(211, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 83);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precio De Venta";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(19, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Moneda";
            // 
            // mzCEMoneda
            // 
            this.mzCEMoneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEMoneda.DisplayMember = "";
            this.mzCEMoneda.DisplayMemberCaption = "";
            this.mzCEMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEMoneda.Location = new System.Drawing.Point(19, 46);
            this.mzCEMoneda.MaxItemsDisplay = 200;
            this.mzCEMoneda.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEMoneda.Name = "mzCEMoneda";
            this.mzCEMoneda.Size = new System.Drawing.Size(154, 24);
            this.mzCEMoneda.SorterMember = "";
            this.mzCEMoneda.TabIndex = 2;
            this.mzCEMoneda.ValueMember = "";
            this.mzCEMoneda.ValueMemberCaption = "";
            // 
            // ultraExplorerBarContainerControl4
            // 
            this.ultraExplorerBarContainerControl4.Controls.Add(this.gridSucursales);
            this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
            this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(1082, 193);
            this.ultraExplorerBarContainerControl4.TabIndex = 3;
            this.ultraExplorerBarContainerControl4.Visible = false;
            // 
            // gridSucursales
            // 
            this.gridSucursales.CausesValidation = false;
            this.gridSucursales.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridSucursales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSucursales.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridSucursales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridSucursales.GroupByBoxVisible = false;
            this.gridSucursales.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridSucursales.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
            this.gridSucursales.Location = new System.Drawing.Point(0, 0);
            this.gridSucursales.Name = "gridSucursales";
            this.gridSucursales.Size = new System.Drawing.Size(1082, 193);
            this.gridSucursales.TabIndex = 0;
            this.gridSucursales.UpdateOnLeave = false;
            this.gridSucursales.CurrentCellChanged += new System.EventHandler(this.gridSucursales_CurrentCellChanged);
            this.gridSucursales.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // ultraExplorerBarContainerControl5
            // 
            this.ultraExplorerBarContainerControl5.Controls.Add(this.gridEX1);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.label6);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.label14);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.mzCEBonificacion);
            this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
            this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(1082, 155);
            this.ultraExplorerBarContainerControl5.TabIndex = 4;
            this.ultraExplorerBarContainerControl5.Visible = false;
            // 
            // gridEX1
            // 
            this.gridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridEX1.AlternatingColors = true;
            this.gridEX1.AutomaticSort = false;
            this.gridEX1.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridEX1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridEX1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridEX1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridEX1.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
            this.gridEX1.GroupByBoxVisible = false;
            this.gridEX1.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridEX1.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridEX1.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
            this.gridEX1.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
            this.gridEX1.Location = new System.Drawing.Point(202, 28);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.RecordNavigator = true;
            this.gridEX1.RecordNavigatorText = "Registro:|de";
            this.gridEX1.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEX1.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridEX1.ShowEmptyFields = false;
            this.gridEX1.Size = new System.Drawing.Size(615, 120);
            this.gridEX1.TabIndex = 74;
            this.gridEX1.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            this.gridEX1.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.gridEX1_FormattingRow);
            this.gridEX1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(0, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 18);
            this.label6.TabIndex = 73;
            this.label6.Text = "Detalle de Bonificacion";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 27);
            this.label14.TabIndex = 72;
            this.label14.Text = "Bonificacion";
            // 
            // mzCEBonificacion
            // 
            this.mzCEBonificacion.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEBonificacion.DisplayMember = "";
            this.mzCEBonificacion.DisplayMemberCaption = "";
            this.mzCEBonificacion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEBonificacion.ImageTransparentColor = System.Drawing.Color.Violet;
            this.mzCEBonificacion.Location = new System.Drawing.Point(202, 0);
            this.mzCEBonificacion.MaxItemsDisplay = 7;
            this.mzCEBonificacion.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEBonificacion.Name = "mzCEBonificacion";
            this.mzCEBonificacion.Size = new System.Drawing.Size(278, 24);
            this.mzCEBonificacion.SorterMember = "";
            this.mzCEBonificacion.TabIndex = 71;
            this.mzCEBonificacion.ValueMember = "";
            this.mzCEBonificacion.ValueMemberCaption = "";
            this.mzCEBonificacion.ValueChanged += new System.EventHandler(this.mzCEBonificacion_ValueChanged);
            this.mzCEBonificacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // ultraExplorerBarContainerControl13
            // 
            this.ultraExplorerBarContainerControl13.Controls.Add(this.txtLink5);
            this.ultraExplorerBarContainerControl13.Controls.Add(this.txtLink4);
            this.ultraExplorerBarContainerControl13.Controls.Add(this.txtLink3);
            this.ultraExplorerBarContainerControl13.Controls.Add(this.txtLink2);
            this.ultraExplorerBarContainerControl13.Controls.Add(this.txtLink1);
            this.ultraExplorerBarContainerControl13.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl13.Name = "ultraExplorerBarContainerControl13";
            this.ultraExplorerBarContainerControl13.Size = new System.Drawing.Size(1082, 135);
            this.ultraExplorerBarContainerControl13.TabIndex = 11;
            this.ultraExplorerBarContainerControl13.Visible = false;
            // 
            // txtLink5
            // 
            this.txtLink5.Location = new System.Drawing.Point(10, 111);
            this.txtLink5.MaxLength = 256;
            this.txtLink5.Name = "txtLink5";
            this.txtLink5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLink5.Size = new System.Drawing.Size(998, 22);
            this.txtLink5.TabIndex = 4;
            this.txtLink5.WordWrap = false;
            // 
            // txtLink4
            // 
            this.txtLink4.Location = new System.Drawing.Point(10, 83);
            this.txtLink4.MaxLength = 256;
            this.txtLink4.Name = "txtLink4";
            this.txtLink4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLink4.Size = new System.Drawing.Size(998, 22);
            this.txtLink4.TabIndex = 3;
            this.txtLink4.WordWrap = false;
            // 
            // txtLink3
            // 
            this.txtLink3.Location = new System.Drawing.Point(10, 55);
            this.txtLink3.MaxLength = 256;
            this.txtLink3.Name = "txtLink3";
            this.txtLink3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLink3.Size = new System.Drawing.Size(998, 22);
            this.txtLink3.TabIndex = 2;
            this.txtLink3.WordWrap = false;
            // 
            // txtLink2
            // 
            this.txtLink2.Location = new System.Drawing.Point(10, 28);
            this.txtLink2.MaxLength = 256;
            this.txtLink2.Name = "txtLink2";
            this.txtLink2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLink2.Size = new System.Drawing.Size(998, 22);
            this.txtLink2.TabIndex = 1;
            this.txtLink2.WordWrap = false;
            // 
            // txtLink1
            // 
            this.txtLink1.Location = new System.Drawing.Point(10, 0);
            this.txtLink1.MaxLength = 256;
            this.txtLink1.Name = "txtLink1";
            this.txtLink1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLink1.Size = new System.Drawing.Size(998, 22);
            this.txtLink1.TabIndex = 0;
            this.txtLink1.WordWrap = false;
            // 
            // ultraExplorerBarContainerControl10
            // 
            this.ultraExplorerBarContainerControl10.Controls.Add(this.chkImagen1);
            this.ultraExplorerBarContainerControl10.Controls.Add(this.chkThumb);
            this.ultraExplorerBarContainerControl10.Controls.Add(this.btnFileChooserThumb);
            this.ultraExplorerBarContainerControl10.Controls.Add(this.pictureBoxThumb);
            this.ultraExplorerBarContainerControl10.Controls.Add(this.pictureBoxImagen);
            this.ultraExplorerBarContainerControl10.Controls.Add(this.btnFileChooserImagen);
            this.ultraExplorerBarContainerControl10.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl10.Name = "ultraExplorerBarContainerControl10";
            this.ultraExplorerBarContainerControl10.Size = new System.Drawing.Size(1082, 320);
            this.ultraExplorerBarContainerControl10.TabIndex = 8;
            this.ultraExplorerBarContainerControl10.Visible = false;
            // 
            // chkImagen1
            // 
            this.chkImagen1.BackColor = System.Drawing.Color.Transparent;
            this.chkImagen1.Checked = true;
            this.chkImagen1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkImagen1.Location = new System.Drawing.Point(259, 9);
            this.chkImagen1.Name = "chkImagen1";
            this.chkImagen1.Size = new System.Drawing.Size(19, 28);
            this.chkImagen1.TabIndex = 2;
            this.chkImagen1.UseVisualStyleBackColor = false;
            // 
            // chkThumb
            // 
            this.chkThumb.BackColor = System.Drawing.Color.Transparent;
            this.chkThumb.Checked = true;
            this.chkThumb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkThumb.Location = new System.Drawing.Point(19, 9);
            this.chkThumb.Name = "chkThumb";
            this.chkThumb.Size = new System.Drawing.Size(19, 28);
            this.chkThumb.TabIndex = 0;
            this.chkThumb.UseVisualStyleBackColor = false;
            // 
            // btnFileChooserThumb
            // 
            this.btnFileChooserThumb.Location = new System.Drawing.Point(38, 9);
            this.btnFileChooserThumb.Name = "btnFileChooserThumb";
            this.btnFileChooserThumb.Size = new System.Drawing.Size(39, 27);
            this.btnFileChooserThumb.TabIndex = 1;
            this.btnFileChooserThumb.Text = "...";
            this.btnFileChooserThumb.Click += new System.EventHandler(this.btnFileChooserThumb_Click);
            // 
            // pictureBoxThumb
            // 
            this.pictureBoxThumb.Location = new System.Drawing.Point(86, 9);
            this.pictureBoxThumb.Name = "pictureBoxThumb";
            this.pictureBoxThumb.Size = new System.Drawing.Size(144, 102);
            this.pictureBoxThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxThumb.TabIndex = 13;
            this.pictureBoxThumb.TabStop = false;
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Location = new System.Drawing.Point(326, 9);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(423, 305);
            this.pictureBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagen.TabIndex = 12;
            this.pictureBoxImagen.TabStop = false;
            // 
            // btnFileChooserImagen
            // 
            this.btnFileChooserImagen.Location = new System.Drawing.Point(278, 9);
            this.btnFileChooserImagen.Name = "btnFileChooserImagen";
            this.btnFileChooserImagen.Size = new System.Drawing.Size(39, 27);
            this.btnFileChooserImagen.TabIndex = 2;
            this.btnFileChooserImagen.Text = "...";
            this.btnFileChooserImagen.Click += new System.EventHandler(this.btnFileChooserImagen_Click);
            // 
            // ultraExplorerBarContainerControl16
            // 
            this.ultraExplorerBarContainerControl16.Controls.Add(this.label58);
            this.ultraExplorerBarContainerControl16.Controls.Add(this.txtCodigoProductoProveedor);
            this.ultraExplorerBarContainerControl16.Controls.Add(this.label57);
            this.ultraExplorerBarContainerControl16.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl16.Name = "ultraExplorerBarContainerControl16";
            this.ultraExplorerBarContainerControl16.Size = new System.Drawing.Size(1082, 221);
            this.ultraExplorerBarContainerControl16.TabIndex = 13;
            this.ultraExplorerBarContainerControl16.Visible = false;
            // 
            // label58
            // 
            this.label58.BackColor = System.Drawing.Color.Transparent;
            this.label58.Location = new System.Drawing.Point(595, 5);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(120, 18);
            this.label58.TabIndex = 59;
            this.label58.Text = "Código";
            // 
            // txtCodigoProductoProveedor
            // 
            this.txtCodigoProductoProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoProductoProveedor.Location = new System.Drawing.Point(720, 2);
            this.txtCodigoProductoProveedor.Name = "txtCodigoProductoProveedor";
            this.txtCodigoProductoProveedor.Size = new System.Drawing.Size(192, 22);
            this.txtCodigoProductoProveedor.TabIndex = 58;
            this.txtCodigoProductoProveedor.Text = "TEXTBOX1";
            // 
            // label57
            // 
            this.label57.BackColor = System.Drawing.Color.Transparent;
            this.label57.Location = new System.Drawing.Point(0, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(67, 23);
            this.label57.TabIndex = 56;
            this.label57.Text = "Proveedor";
            // 
            // ultraCheckEditor1
            // 
            this.ultraCheckEditor1.BackColor = System.Drawing.Color.Transparent;
            this.ultraCheckEditor1.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraCheckEditor1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ultraCheckEditor1.Location = new System.Drawing.Point(674, 144);
            this.ultraCheckEditor1.Name = "ultraCheckEditor1";
            this.ultraCheckEditor1.Size = new System.Drawing.Size(88, 20);
            this.ultraCheckEditor1.TabIndex = 165;
            this.ultraCheckEditor1.Text = "Es Combo";
            // 
            // gridEX2
            // 
            this.gridEX2.AllowCardSizing = false;
            this.gridEX2.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEX2.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridEX2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEX2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridEX2.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridEX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gridEX2.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridEX2.Location = new System.Drawing.Point(4, 112);
            this.gridEX2.Name = "gridEX2";
            this.gridEX2.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridEX2.Size = new System.Drawing.Size(835, 160);
            this.gridEX2.TabIndex = 1815;
            this.gridEX2.TabStop = false;
            // 
            // gridEX3
            // 
            this.gridEX3.AllowCardSizing = false;
            this.gridEX3.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEX3.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridEX3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEX3.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridEX3.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridEX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gridEX3.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridEX3.Location = new System.Drawing.Point(6, 291);
            this.gridEX3.Name = "gridEX3";
            this.gridEX3.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridEX3.Size = new System.Drawing.Size(835, 160);
            this.gridEX3.TabIndex = 1818;
            this.gridEX3.TabStop = false;
            // 
            // uneDescuentoComboPorcentual
            // 
            this.uneDescuentoComboPorcentual.Location = new System.Drawing.Point(739, 89);
            this.uneDescuentoComboPorcentual.Name = "uneDescuentoComboPorcentual";
            this.uneDescuentoComboPorcentual.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneDescuentoComboPorcentual.PromptChar = ' ';
            this.uneDescuentoComboPorcentual.ReadOnly = true;
            this.uneDescuentoComboPorcentual.Size = new System.Drawing.Size(100, 24);
            this.uneDescuentoComboPorcentual.TabIndex = 1819;
            // 
            // une
            // 
            this.une.Location = new System.Drawing.Point(739, 89);
            this.une.Name = "une";
            this.une.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.une.PromptChar = ' ';
            this.une.ReadOnly = true;
            this.une.Size = new System.Drawing.Size(100, 24);
            this.une.TabIndex = 1819;
            // 
            // uneDescuento
            // 
            this.uneDescuento.Location = new System.Drawing.Point(739, 89);
            this.uneDescuento.Name = "uneDescuento";
            this.uneDescuento.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneDescuento.PromptChar = ' ';
            this.uneDescuento.ReadOnly = true;
            this.uneDescuento.Size = new System.Drawing.Size(100, 24);
            this.uneDescuento.TabIndex = 1819;
            // 
            // bAgregarProducto
            // 
            this.bAgregarProducto.AcceptsFocus = false;
            this.bAgregarProducto.Location = new System.Drawing.Point(753, 86);
            this.bAgregarProducto.Name = "bAgregarProducto";
            this.bAgregarProducto.Size = new System.Drawing.Size(88, 23);
            this.bAgregarProducto.TabIndex = 1821;
            this.bAgregarProducto.TabStop = false;
            this.bAgregarProducto.Text = "Aplicar";
            // 
            // mzCmb
            // 
            this.mzCmb.BackColor = System.Drawing.SystemColors.Control;
            this.mzCmb.DataValue = "";
            this.mzCmb.EnableCtaCte = false;
            this.mzCmb.FastSearch = false;
            this.mzCmb.Location = new System.Drawing.Point(120, 15);
            this.mzCmb.Name = "mzCmb";
            this.mzCmb.SearchObjectListener = null;
            this.mzCmb.Size = new System.Drawing.Size(408, 22);
            this.mzCmb.TabIndex = 14;
            this.mzCmb.Tag = "ResponsableEmision";
            // 
            // tbCargarPrecio
            // 
            this.tbCargarPrecio.ImageIndex = 12;
            this.tbCargarPrecio.Name = "tbCargarPrecio";
            this.tbCargarPrecio.Text = "Guardar y cargar precio";
            // 
            // tbSeparador
            // 
            this.tbSeparador.Name = "tbSeparador";
            this.tbSeparador.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // FrmAbmExProductos
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(968, 516);
            this.Name = "FrmAbmExProductos";
            this.Load += new System.EventHandler(this.FrmAbmExProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
            this.ultraExplorerBar1.ResumeLayout(false);
            this.ultraExplorerBarContainerControl9.ResumeLayout(false);
            this.ultraExplorerBarContainerControl9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEResponsableIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzComboTipoProducto)).EndInit();
            this.ultraExplorerBarContainerControl15.ResumeLayout(false);
            this.ultraExplorerBarContainerControl15.PerformLayout();
            this.ultraExplorerBarContainerControl19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCodigosProductosProveedores)).EndInit();
            this.ultraExplorerBarContainerControl12.ResumeLayout(false);
            this.ultraExplorerBarContainerControl12.PerformLayout();
            this.ultraExplorerBarContainerControl7.ResumeLayout(false);
            this.ultraExplorerBarContainerControl8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ultraExplorerBarContainerControl18.ResumeLayout(false);
            this.groupMZ.ResumeLayout(false);
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unePCostoPromedioPonderado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoReposicion)).EndInit();
            this.ultraExplorerBarContainerControl17.ResumeLayout(false);
            this.ultraExplorerBarContainerControl17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneDescuentoCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListasDePreciosProductosCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductosCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzComboListaDePrecios)).EndInit();
            this.ultraExplorerBarContainerControl2.ResumeLayout(false);
            this.ultraExplorerBarContainerControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoRef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMAC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeVentaNeto)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unePCostoPromedioPonderado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoReposicion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioFinalMonedaReferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeListaConImpuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioVentaBruto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuentoPorcentual)).EndInit();
            this.ultraExplorerBarContainerControl14.ResumeLayout(false);
            this.ultraExplorerBarContainerControl14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioFinalMonedaReferenciaLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeListaConImpuestoLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioVentaBrutoLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuentoLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuentoPorcentualLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficienteMonedaReferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoRefLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMACLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeVentaNetoLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaDePrecios)).EndInit();
            this.ultraExplorerBarContainerControl11.ResumeLayout(false);
            this.ultraExplorerBarContainerControl11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePorc11)).EndInit();
            this.ultraExplorerBarContainerControl3.ResumeLayout(false);
            this.ultraExplorerBarContainerControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneContador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridImpuestos)).EndInit();
            this.ultraExplorerBarContainerControl6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEFuenteDeCambioPrecioDeCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEMonedaPrecioDeCosto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEMoneda)).EndInit();
            this.ultraExplorerBarContainerControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSucursales)).EndInit();
            this.ultraExplorerBarContainerControl5.ResumeLayout(false);
            this.ultraExplorerBarContainerControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEBonificacion)).EndInit();
            this.ultraExplorerBarContainerControl13.ResumeLayout(false);
            this.ultraExplorerBarContainerControl13.PerformLayout();
            this.ultraExplorerBarContainerControl10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThumb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.ultraExplorerBarContainerControl16.ResumeLayout(false);
            this.ultraExplorerBarContainerControl16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneDescuentoComboPorcentual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.une)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneDescuento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        protected override void Init()
        {
            _businessRulesType = new mz.erp.businessrules.tsh_ProductosEx().GetType();
            labelCodigoSec.Text = Variables.GetValueString("Productos.CodigoSecundario.Etiqueta");
            base.Init();
        }

        protected override void InitializeMembers()
        {
            //Cristian Configuracion ImageList 20110718
            utility.Util.LoadImages(this.toolBarStandar,this.imglStandar);
            //Fin Cristian


            mzComboTipoProducto.FillFromDataSource(businessrules.tsy_TipoProducto.GetListByActivo(true).tsy_TipoProducto, "IdTipoProducto", "Descripcion", 100, "ID", "Descripcion", "Descripcion");
            txtCodigo.MaxLength = 20;
            txtCodigoSecundario.MaxLength = 30;
            txtDescripcion.MaxLength = 256;
            txtDescripcionCorta.MaxLength = 256;
            txtDescripcionLarga.MaxLength = 256;

            //gridSucursales.DataSource = _data.Tables["tsh_ProductosSucursales"];
            mzCEBonificacion.KeyDown += new KeyEventHandler(mzCEBonificacion_KeyDown);
            //German 20120208 - Tarea 0000276
            mzCEBonificacion.FillFromDataSource(businessrules.tsa_Bonificaciones.GetList(null, null, Constantes.TipoBonificacionProducto).tsa_Bonificaciones, "IdBonificacion", "Codigo", 100, "1", "2", "Codigo");
            //Fin German 20120208 - Tarea 0000276
            mzCEBonificacion.Nullable = true;
            mzCEMoneda.FillFromDataSource(businessrules.tfi_Monedas.GetList(null, null).tfi_Monedas, "IdMoneda", "Descripcion", 8, "Descripcion");
            mzCEMonedaPrecioDeCosto.FillFromDataSource(businessrules.tfi_Monedas.GetList(null, null).tfi_Monedas, "IdMoneda", "Descripcion", 8, "Descripcion");
            mzCEFuenteDeCambioPrecioDeCosto.FillFromDataSource(businessrules.tfi_FuentesDeCambio.GetList().tfi_FuentesDeCambio, "IdFuenteDeCambio", "Descripcion", 8, "Descripcion");
            gridEX1.LayoutData = new mz.erp.ui.forms.classes.tsa_BonificacionesDet().GetLayout();
            gridProductos.LayoutData = new mz.erp.ui.forms.classes.tsh_Productos().GetLayoutProductos();
            _uiController = new mz.erp.businessrules.tsh_ProductosEx.ControladorProductos((tsh_ProductosExDataset)this._data, this._state);
            _uiController.PrecioNetoChanged += new EventHandler(On_PrecioNetoChanged);
            _uiController.SimboloMonedaPrecioDeCostoReferenciaChanged += new EventHandler(On_SimboloMonedaPrecioDeCostoReferenciaChanged);
            _uiController.SimboloMonedaPrecioDeListaChanged += new EventHandler(On_SimboloMonedaPrecioDeListaChanged);
            uneMaxDescuentoPorcentual.ReadOnly = !_uiController.PrecioDeVentaAfectaMac;
            uneMaxDescuento.DataBindings.Add("Value", _uiController, "DescuentoMax");

            unePrecioVentaBruto.DoubleClick += new EventHandler(unePrecioVentaBruto_DoubleClick);


            unePrecioDeCostoRef.DataBindings.Add("Value", _uiController, "PrecioCosto");

            unePrecioDeVentaNeto.DataBindings.Add("Value", _uiController, "PrecioNeto");
            unePrecioVentaBruto.DataBindings.Add("Value", _uiController, "PrecioLista");
            uneContador.DataBindings.Add("Value", _uiController, "Contador");
            uneMAC.DataBindings.Add("Value", _uiController, "Margen");
            unePrecioDeListaConImpuesto.DataBindings.Add("Value", _uiController, "PrecioFinal");
            unePrecioFinalMonedaReferencia.DataBindings.Add("Value", _uiController, "PrecioFinalMonedaReferencia");
            uneMaxDescuentoPorcentual.DataBindings.Add("Value", _uiController, "DescuentoPorcentual");

            /*txtCampoAuxiliar1.DataBindings.Add("Text", _uiController, "CampoAuxiliar1");
            txtCampoAuxiliar2.DataBindings.Add("Text", _uiController, "CampoAuxiliar2");*/

            mz.erp.commontypes.BindingController.Bind(mzCEMoneda, "Value", _uiController, "IdMonedaCierrePrecioDeVentaBruto");
            mz.erp.commontypes.BindingController.Bind(mzCEMonedaPrecioDeCosto, "Value", _uiController, "IdMonedaCierrePrecioDeCostoRef");
            mz.erp.commontypes.BindingController.Bind(mzCEFuenteDeCambioPrecioDeCosto, "Value", _uiController, "IdFuenteDeCambioPrecioDeCostoRef");
            this.AutoScroll = true;
            //German 20100426
            txtCodigo.Enabled = !ComprobantesRules.Producto_CodigoAutomatico &&
                (_state.ToUpper().Equals("NEW") || (_state.ToUpper().Equals("EDIT") && ComprobantesRules.Producto_PermiteModificarCodigoManual));
            //Fin German 20100426
            gridSucursales.LayoutData = new mz.erp.ui.forms.classes.tsh_ProductosSucursales().GetLayoutSucursales();
            //gridSucursales.AllowEdit= Janus.Windows.GridEX.InheritableBoolean.True;
            //gridSucursales.UpdateOnLeave = true;
            //gridSucursales.CausesValidation = false;
            //gridSucursales.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;

            //gridImpuestos.LayoutData = mz.erp.ui.ComprobanteDeCompra.GetLayoutRelacionOrigenDestino( new string[] {"IdTipoDeComprobante", "Numero", "OrdinalOrigen", "CantidadOrigen","CantidadDestino","Descripcion", "PrecioDeCosto"});
            gridImpuestos.LayoutData = mz.erp.ui.forms.classes.tsy_ImpuestosEx.GetLayoutAbmExProductos();
            gridImpuestos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            //gridImpuestos.DataSource = _uiController.Impuestos;
            //gridImpuestos.DataBindings.Add(
            chkObligaCodigoBarra.Enabled = true;
            chkObligaNumeroSerie.Enabled = true;
            if (_uiController.EtiquetaCampoAuxiliar1 == "")
            {
                txtCampoAuxiliar1.Enabled = false;
            }
            else
            {
                lblEtiquetaCampoAuxiliar1.Text = _uiController.EtiquetaCampoAuxiliar1;
                txtCampoAuxiliar1.Enabled = Variables.GetValueBool("ProcesoABMProductos", "ABMProductos", "Editar.CampoAuxiliar1");
            }
            if (_uiController.EtiquetaCampoAuxiliar2 == "")
            {
                txtCampoAuxiliar2.Enabled = false;
            }
            else
            {
                lblEtiquetaCampoAuxiliar2.Text = _uiController.EtiquetaCampoAuxiliar2;
                txtCampoAuxiliar2.Enabled = Variables.GetValueBool("ProcesoABMProductos", "ABMProductos", "Editar.CampoAuxiliar2");
            }

            if (_uiController.EtiquetaCampoAuxiliar3 == "")
            {
                txtCampoAuxiliar3.Enabled = false;
            }
            else
            {
                lblEtiquetaCampoAuxiliar3.Text = _uiController.EtiquetaCampoAuxiliar3;
                txtCampoAuxiliar3.Enabled = Variables.GetValueBool("ProcesoABMProductos", "ABMProductos", "Editar.CampoAuxiliar3");
            }

            if (_uiController.EtiquetaCampoAuxiliar4 == "")
            {
                txtCampoAuxiliar4.Enabled = false;
            }
            else
            {
                lblEtiquetaCampoAuxiliar4.Text = _uiController.EtiquetaCampoAuxiliar4;
                txtCampoAuxiliar4.Enabled = Variables.GetValueBool("ProcesoABMProductos", "ABMProductos", "Editar.CampoAuxiliar4");
            }

            if (_uiController.EtiquetaCampoAuxiliar5 == "")
            {
                txtCampoAuxiliar5.Enabled = false;
            }
            else
            {
                this.lblEtiquetaCampoAuxiliar5.Text = _uiController.EtiquetaCampoAuxiliar5;
                txtCampoAuxiliar5.Enabled = Variables.GetValueBool("ProcesoABMProductos", "ABMProductos", "Editar.CampoAuxiliar5");
            }
            if (_uiController.EtiquetaCampoAuxiliar6 == "")
            {
                mzSearchTextBox1.Enabled = false;
            }
            else
            {
                this.lblEtiquetaCampoAuxiliar6.Text = _uiController.EtiquetaCampoAuxiliar6;
                mzSearchTextBox1.Enabled = Variables.GetValueBool("ProcesoABMProductos", "ABMProductos", "Editar.CampoAuxiliar6");
            }

            //Cristian 20101018 Tarea 874
            if (_uiController.PermiteCoeficienteNegativo)
            {
                uneCoeficiente.MaskInput = "-nnn.nnnn";
            }
            //Fin Cristian

            foreach (Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup group in this.ultraExplorerBar1.Groups)
            {
                group.Visible = false;
                if (group.Container != null)
                    group.Container.Enabled = false;
            }
            //ultraExplorerBarContainerControl9.Enabled = false;


            //Cristian tAREA 00243 20111230
            tbCargarPrecio.Enabled = _uiController.UsaListaDePreciosProveedores;
            //Fin Cristian
            if (!_uiController.ContenedoresVisibles.Equals(string.Empty))
            {
                ArrayList cont = mz.erp.systemframework.Util.Parse(_uiController.ContenedoresVisibles, ",");
                foreach (string grupo in cont)
                {

                    switch (grupo)
                    {
                        case "Precios":
                            if (_uiController.ListaDePreciosHabilitadas == false)
                            {
                                this.ultraExplorerBar1.Groups["Precios"].Visible = true;
                            }
                            break;
                        case "ListaDePrecios":
                            if (_uiController.ListaDePreciosHabilitadas == true)
                            {
                                this.ultraExplorerBar1.Groups["ListaDePrecios"].Visible = true;
                            }
                            break;
                        default:
                            this.ultraExplorerBar1.Groups[grupo].Visible = true;
                            break;
                    }
                }
            }

            if (!_uiController.ContenedoresHabilitados.Equals(string.Empty))
            {
                ArrayList cont = mz.erp.systemframework.Util.Parse(_uiController.ContenedoresHabilitados, ",");
                foreach (string grupo in cont)
                {
                    switch (grupo)
                    {
                        case "Precios":
                            if (_uiController.ListaDePreciosHabilitadas == false)
                            {
                                if (this.ultraExplorerBar1.Groups["Precios"].Container != null)
                                    this.ultraExplorerBar1.Groups["Precios"].Container.Enabled = true;
                            }
                            break;
                        case "ListaDePrecios":
                            if (_uiController.ListaDePreciosHabilitadas == true)
                            {
                                if (this.ultraExplorerBar1.Groups["ListaDePrecios"].Container != null)
                                    this.ultraExplorerBar1.Groups["ListaDePrecios"].Container.Enabled = true;
                            }
                            break;
                        default:
                            if (this.ultraExplorerBar1.Groups[grupo].Container != null)
                                this.ultraExplorerBar1.Groups[grupo].Container.Enabled = true;
                            break;
                    }
                }
            }

            /*if(_uiController.ListaDePreciosHabilitadas)
            {
                this.ultraExplorerBar1.Groups["ListaDePrecios"].Visible = true;
                if (this.ultraExplorerBar1.Groups["ListaDePrecios"].Container != null)
                    this.ultraExplorerBar1.Groups["ListaDePrecios"].Container.Enabled = true;
                this.ultraExplorerBar1.Groups["Precios"].Visible = false;
                if (this.ultraExplorerBar1.Groups["Precios"].Container != null)
                    this.ultraExplorerBar1.Groups["Precios"].Container.Enabled = false;
            }
            else
            {
                this.ultraExplorerBar1.Groups["ListaDePrecios"].Visible = false;
                if (this.ultraExplorerBar1.Groups["ListaDePrecios"].Container != null)
                    this.ultraExplorerBar1.Groups["ListaDePrecios"].Container.Enabled = false;
                this.ultraExplorerBar1.Groups["Precios"].Visible = true;
                if (this.ultraExplorerBar1.Groups["Precios"].Container != null)
                    this.ultraExplorerBar1.Groups["Precios"].Container.Enabled = true;
            }*/

            if (_uiController.ConfiguracionBasica)
            {
            }
            else
            {
                //this.ultraExplorerBar1.Groups["Precios"].Visible = false;
            }
            if (_uiController.GeneracionDeProductosMasivos && this._state.Equals("NEW"))
            {
                hierarchicalSearchControl1.Build_UI("PRODUCTOS", true);
                btnBajar.Click += new EventHandler(btnBajar_Click);
                btnSubir.Click += new EventHandler(btnSubir_Click);
                btnCobinar.Click += new EventHandler(btnCobinar_Click);
                utbEliminarTodos.Click += new EventHandler(utbEliminarTodos_Click);
                btnEliminar.Click += new EventHandler(btnEliminar_Click);
                ubtCopiarCodigoSecundario.Click += new EventHandler(ubtCopiarCodigoSecundario_Click);
                gridProductos.GroupByBoxVisible = false;
                chkLista.Items.Add("Descripción", true);
                btnEliminar.Enabled = true;
                utbEliminarTodos.Enabled = true;
                btnCobinar.Enabled = true;
                gridProductos.ScrollBars = Janus.Windows.GridEX.ScrollBars.Automatic;
                chkLista.CheckOnClick = false;
                //chkLista.ItemCheck +=new ItemCheckEventHandler(chkLista_ItemCheck);
                ubtCopiarCodigoSecundario.Enabled = true;
                gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
                gridProductos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextRow;
            }
            else
            {
                hierarchicalSearchControl1.Build_UI("PRODUCTOS", false);
            }
            mzSearchTextBox1.Init(true);
            hierarchicalSearchControl1.OnSelected += new EventHandler(hierarchicalSearchControl1_OnSelected);
            if (this._state.Equals("EDIT"))
            {
                this.ultraExplorerBar1.Groups["GeneracionMasiva"].Visible = false;
                hierarchicalSearchControl1.SetSelectionKey(_uiController.Jerarquias);
                if (_uiController.EtiquetaCampoAuxiliar6 != "")
                {
                    mzSearchTextBox1.SetJerarquias(_uiController.JerarquiasCampoAuxiliar6);
                }
            }
            mz.erp.ui.forms.classes.ContainerManager.UpdateSize(this.ultraExplorerBarContainerControl7, hierarchicalSearchControl1);


            #region Deshabilta por Perfil

            chkActivo.Enabled = Variables.GetValueBool("ProcesoABMProductos", "ABMProductos", "Editar.Activo", true);
            txtDescripcionLarga.Enabled = Variables.GetValueBool("ProcesoABMProductos", "ABMProductos", "Editar.DescripcionLarga", true);
            txtDescripcionCorta.Enabled = Variables.GetValueBool("ProcesoABMProductos", "ABMProductos", "Editar.DescripcionCorta", true);
            txtDescripcion.Enabled = Variables.GetValueBool("ProcesoABMProductos", "ABMProductos", "Editar.Descripcion");
            txtCodigoSecundario.Enabled = Variables.GetValueBool("ProcesoABMProductos", "ABMProductos", "Editar.CodigoSecundario");
            chkObligaCodigoBarra.Enabled = Variables.GetValueBool("ProcesoABMProductos", "ABMProductos", "Editar.ObligaCodigoBarra");
            chkObligaNumeroSerie.Enabled = Variables.GetValueBool("ProcesoABMProductos", "ABMProductos", "Editar.ObligaNumeroSerie");
            ucePercibeIB.Enabled = Variables.GetValueBool("ProcesoABMProductos", "ABMProductos", "Editar.PercibeIB");
            gridImpuestos.Enabled = Variables.GetValueBool("ProcesoABMProductos", "ABMProductos", "Editar.Impuestos");
            mzCEBonificacion.Enabled = Variables.GetValueBool("ProcesoABMProductos", "ABMProductos", "Editar.Bonificaciones");
            mzCEFuenteDeCambioPrecioDeCosto.Enabled = Variables.GetValueBool("ProcesoABMProductos", "ABMProductos", "Editar.FuenteDeCambioPrecioDeCosto");
            mzCEMoneda.Enabled = Variables.GetValueBool("ProcesoABMProductos", "ABMProductos", "Editar.MonedaPrecioDeVenta");
            mzCEMonedaPrecioDeCosto.Enabled = Variables.GetValueBool("ProcesoABMProductos", "ABMProductos", "Editar.MonedaPrecioDeCosto");
            mzComboTipoProducto.Enabled = Variables.GetValueBool("ProcesoABMProductos", "ABMProductos", "Editar.TipoDeProducto");
            gridSucursales.Enabled = Variables.GetValueBool("ProcesoABMProductos", "ABMProductos", "Editar.Sucursales");
            //Cristian Tarea 953 20101210
            txtObservaciones.MaxLength = 1000;
            //Fin Tarea 953
            /* Silvina 20101116 - Tarea 920 */
            txtObservaciones.Enabled = _uiController.PermiteModificarObservaciones || _uiController.PermiteAgregarObservaciones;
            /* Fin Silvina */
            #endregion

            gridProductos.Error += new Janus.Windows.GridEX.ErrorEventHandler(gridProductos_Error);
            /*uneCoeficientePorc1.ReadOnly = _uiController.CoeficientesPorVariable;
            uneCoeficientePorc2.ReadOnly = _uiController.CoeficientesPorVariable;
            uneCoeficientePorc3.ReadOnly = _uiController.CoeficientesPorVariable;
            uneCoeficientePorc4.ReadOnly = _uiController.CoeficientesPorVariable;
            uneCoeficientePorc5.ReadOnly = _uiController.CoeficientesPorVariable;*/

            if (_uiController.DescripcionSoloMayusculas)
            {
                this.txtDescripcionLarga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
                this.txtDescripcionCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
                this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            }
            else
            {
                this.txtDescripcionLarga.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
                this.txtDescripcionCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
                this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            }
            gridManagerView1.Configure("", "", this.Name, gridListaDePrecios, this.Text);
            gridListaDePrecios.SelectionChanged += new EventHandler(gridListaDePrecios_SelectionChanged);
            uneCoeficiente.ValueChanged += new EventHandler(uneCoeficiente_ValueChanged);
            uneCoeficienteMonedaReferencia.ValueChanged += new EventHandler(uneCoeficienteMonedaReferencia_ValueChanged);


            //German 20101025 - Tarea 880
            //unePrecioVentaBrutoLP.ValueChanged += new EventHandler(unePrecioVentaBrutoLP_ValueChanged);
            unePrecioVentaBrutoLP.Leave += new EventHandler(unePrecioVentaBrutoLP_Leave);
            //unePrecioDeListaConImpuestoLP.ValueChanged += new EventHandler(unePrecioDeListaConImpuestoLP_ValueChanged);
            //unePrecioDeListaConImpuestoLP.Leave += new EventHandler(uneCoeficiente_Leave);
            unePrecioDeListaConImpuestoLP.Leave += new EventHandler(unePrecioDeListaConImpuestoLP_Leave);
            //unePrecioFinalMonedaReferenciaLP.ValueChanged += new EventHandler(unePrecioFinalMonedaReferenciaLP_ValueChanged);
            //unePrecioFinalMonedaReferenciaLP.Leave += new EventHandler(uneCoeficiente_Leave);
            unePrecioFinalMonedaReferenciaLP.Leave += new EventHandler(unePrecioFinalMonedaReferenciaLP_Leave);
            //Fin German 20101025 - Tarea 880

            unePrecioDeCostoRefLP.DataBindings.Add("Value", _uiController, "PrecioCosto");

            uneMACLP.DataBindings.Add("Value", _uiController, "Margen");
            unePrecioDeVentaNetoLP.DataBindings.Add("Value", _uiController, "PrecioNeto");

            labelSimboloMonedaPrecioDeCostoReferencia.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
            labelSimboloMonedaPrecioDeVentaNeto.Text = _uiController.SimboloMonedaPrecioDeVentaNeto;
            labelSimboloMonedaDescuentoMaximo.Text = _uiController.SimboloMonedaDescuentoMaximo;
            labelSimboloMonedaPrecioDeLista.Text = _uiController.SimboloMonedaPrecioDeLista;
            labelSimboloMonedaPrecioDeListaConImpuestos.Text = _uiController.SimboloMonedaPrecioDeLista;
            labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia.Text = _uiController.SimboloMonedaReferencia;

            labelSimboloMonedaPrecioDeCostoReferenciaLP.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
            labelSimboloMonedaPrecioDeVentaNetoLP.Text = _uiController.SimboloMonedaPrecioDeVentaNeto;
            labelSimboloMonedaDescuentoMaximoLP.Text = _uiController.SimboloMonedaDescuentoMaximo;
            labelSimboloMonedaPrecioDeListaLP.Text = _uiController.SimboloMonedaPrecioDeLista;
            labelSimboloMonedaPrecioDeListaConImpuestosLP.Text = _uiController.SimboloMonedaPrecioDeLista;
            labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferenciaLP.Text = _uiController.SimboloMonedaReferencia;

            btnRestablecerAGral.Click += new EventHandler(btnRestablecerAGral_Click);
            mzCmbProveedores.DataValue = _uiController.CodigoProveedorDefault;
            chckBonificacionesAcumulativas.Checked = _uiController.BonificacionesAcumulativas;

            // Matias - para evitar el error al eliminar el ultimo reg de la grilla.
            gridProductos.DeletingRecords += new CancelEventHandler(gridProductos_DeletingRecords);
            gridProductos.RecordsDeleted += new EventHandler(gridProductos_RecordsDeleted);

            //Sabrina: tarea 56
            if (_uiController.UsaCostosIndirectos)
            {
                this.ultraExplorerBar1.Groups["DatosCompra"].Visible = true;
                this.ultraExplorerBar1.Groups["DatosCompra"].Container.Enabled = true;
                groupBox6.Visible = false;
                this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(902, 128);
            }
            else
            {
                this.ultraExplorerBar1.Groups["DatosCompra"].Visible = false;

                // Tarea 20 Silvina

                int x = 10;
                int y = 85;

                groupBox6.Location = new System.Drawing.Point(0, 0);

                label8.Location = new System.Drawing.Point(label8.Location.X + x, label8.Location.Y + y);
                labelSimboloMonedaPrecioDeCostoReferencia.Location = new System.Drawing.Point(labelSimboloMonedaPrecioDeCostoReferencia.Location.X, labelSimboloMonedaPrecioDeCostoReferencia.Location.Y + y);

                unePrecioDeCostoRef.Location = new System.Drawing.Point(unePrecioDeCostoRef.Location.X, unePrecioDeCostoRef.Location.Y + y);

                label7.Location = new System.Drawing.Point(label7.Location.X + x, label7.Location.Y + y);
                uneMAC.Location = new System.Drawing.Point(uneMAC.Location.X, uneMAC.Location.Y + y);
                label15.Location = new System.Drawing.Point(label15.Location.X, label15.Location.Y + y);

                label10.Location = new System.Drawing.Point(label10.Location.X + x, label10.Location.Y + y);
                labelSimboloMonedaPrecioDeVentaNeto.Location = new System.Drawing.Point(labelSimboloMonedaPrecioDeVentaNeto.Location.X, labelSimboloMonedaPrecioDeVentaNeto.Location.Y + y);
                unePrecioDeVentaNeto.Location = new System.Drawing.Point(unePrecioDeVentaNeto.Location.X, unePrecioDeVentaNeto.Location.Y + y);

            }
            labelSimboloMonedaPrecioDeCosto3.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
            labelSimboloMonedaPrecioDeCosto4.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
            labelSimboloMonedaPrecioDeCosto6.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
            labelSimboloMonedaPrecioDeCostoReposicion.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
            labelSimboloMonedaPrecioDeCostoReposicion1.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
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

            CargarCostosIndirectosDescripcion();

            //unePrecioDeCostoReposicion.Enabled = false;
            //unePrecioDeCostoReposicion1.Enabled = false;
            unePrecioDeCostoReposicion.ReadOnly = !(_uiController.PermiteModificarPrecioDeCostoReposicion && !_uiController.UsaListaDePreciosProveedores);
            unePrecioDeCostoReposicion1.ReadOnly = !(_uiController.PermiteModificarPrecioDeCostoReposicion && !_uiController.UsaListaDePreciosProveedores);
            unePCostoPromedioPonderado.Enabled = _uiController.PermiteModificarPrecioDeCostoPromedioPonderado;
            unePCostoPromedioPonderado1.Enabled = _uiController.PermiteModificarPrecioDeCostoPromedioPonderado;
            if (this._state.Equals("NEW"))
            {
                unePCostoPromedioPonderado.Enabled = true;
                unePCostoPromedioPonderado1.Enabled = true;
                /*if(!_uiController.UsaListaDePreciosProveedores)
                {
                    unePrecioDeCostoReposicion.Enabled = true;
                    unePrecioDeCostoReposicion1.Enabled = true;
                }*/
            }
            else if (this._state.Equals("EDIT"))
            {
                /*if(!_uiController.UsaListaDePreciosProveedores)
                {
                    unePrecioDeCostoReposicion.Enabled = true;
                    unePrecioDeCostoReposicion1.Enabled = true;
                }*/
            }
            uneCoeficienteTotal.ReadOnly = true;
            chkUsaPrecioDeCostoReposicion.Enabled = _uiController.PermiteModificarUsaPrecioDeCostoReposicion;
            chkUsaPrecioDeCostoReposicion1.Enabled = _uiController.PermiteModificarUsaPrecioDeCostoReposicion;

            chkUsaPrecioDeCostoReposicion.CheckedChanged += new EventHandler(chkUsaPrecioDeCostoReposicion_CheckedChanged);
            chkUsaPrecioDeCostoReposicion1.CheckedChanged += new EventHandler(chkUsaPrecioDeCostoReposicion1_CheckedChanged);
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

            unePCostoPromedioPonderado.DataBindings.Clear();
            unePCostoPromedioPonderado1.DataBindings.Clear();
            unePrecioDeCostoReposicion.DataBindings.Clear();
            unePrecioDeCostoReposicion1.DataBindings.Clear();
            chkUsaPrecioDeCostoReposicion.DataBindings.Clear();
            chkUsaPrecioDeCostoReposicion1.DataBindings.Clear();
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

            uneCoeficienteTotal.DataBindings.Add("Value", _uiController, "PrecioDeCostoIndirecto");

            if (_uiController.CoeficienteBinding(1))
            {
                uneCoeficiente1.DataBindings.Add("Value", _uiController, "CostoIndirecto1");
                uneCoeficientePorc1.DataBindings.Add("Value", _uiController, "CostoIndirectoPorc1");
                //Deprecated
                //chkCoef1.DataBindings.Add("Checked", _uiController, "CostoIndirectoActivo1");
                chkCoef1.DataBindings.Add("CheckState", _uiController, "CostoIndirectoActivo1", true, DataSourceUpdateMode.OnPropertyChanged);

            }
            if (_uiController.CoeficienteBinding(2))
            {
                uneCoeficiente2.DataBindings.Add("Value", _uiController, "CostoIndirecto2");
                uneCoeficientePorc2.DataBindings.Add("Value", _uiController, "CostoIndirectoPorc2");
                //Deprecated
                //chkCoef2.DataBindings.Add("Checked", _uiController, "CostoIndirectoActivo2");
                chkCoef2.DataBindings.Add("CheckState", _uiController, "CostoIndirectoActivo2", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            if (_uiController.CoeficienteBinding(3))
            {
                uneCoeficiente3.DataBindings.Add("Value", _uiController, "CostoIndirecto3");
                uneCoeficientePorc3.DataBindings.Add("Value", _uiController, "CostoIndirectoPorc3");
                //Deprecated
                //chkCoef3.DataBindings.Add("Checked", _uiController, "CostoIndirectoActivo3");
                chkCoef3.DataBindings.Add("CheckState", _uiController, "CostoIndirectoActivo3", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            if (_uiController.CoeficienteBinding(4))
            {
                uneCoeficiente4.DataBindings.Add("Value", _uiController, "CostoIndirecto4");
                uneCoeficientePorc4.DataBindings.Add("Value", _uiController, "CostoIndirectoPorc4");
                //Deprecated
                //chkCoef4.DataBindings.Add("Checked", _uiController, "CostoIndirectoActivo4");
                chkCoef4.DataBindings.Add("CheckState", _uiController, "CostoIndirectoActivo4", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            if (_uiController.CoeficienteBinding(5))
            {
                uneCoeficiente5.DataBindings.Add("Value", _uiController, "CostoIndirecto5");
                uneCoeficientePorc5.DataBindings.Add("Value", _uiController, "CostoIndirectoPorc5");
                //Deprecated
                //chkCoef5.DataBindings.Add("Checked", _uiController, "CostoIndirectoActivo5");
                chkCoef5.DataBindings.Add("CheckState", _uiController, "CostoIndirectoActivo5", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            if (_uiController.CoeficienteBinding(6))
            {
                uneCoeficiente6.DataBindings.Add("Value", _uiController, "CostoIndirecto6");
                uneCoeficientePorc6.DataBindings.Add("Value", _uiController, "CostoIndirectoPorc6");
                //Deprecated
                //chkCoef6.DataBindings.Add("Checked", _uiController, "CostoIndirectoActivo6");
                chkCoef6.DataBindings.Add("CheckState", _uiController, "CostoIndirectoActivo6", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            if (_uiController.CoeficienteBinding(7))
            {
                uneCoeficiente7.DataBindings.Add("Value", _uiController, "CostoIndirecto7");
                uneCoeficientePorc7.DataBindings.Add("Value", _uiController, "CostoIndirectoPorc7");
                //Deprecated
                //chkCoef7.DataBindings.Add("Checked", _uiController, "CostoIndirectoActivo7");
                chkCoef7.DataBindings.Add("CheckState", _uiController, "CostoIndirectoActivo7", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            if (_uiController.CoeficienteBinding(8))
            {
                uneCoeficiente8.DataBindings.Add("Value", _uiController, "CostoIndirecto8");
                uneCoeficientePorc8.DataBindings.Add("Value", _uiController, "CostoIndirectoPorc8");
                //Deprecated
                //chkCoef8.DataBindings.Add("Checked", _uiController, "CostoIndirectoActivo8");
                chkCoef8.DataBindings.Add("CheckState", _uiController, "CostoIndirectoActivo8", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            if (_uiController.CoeficienteBinding(9))
            {
                uneCoeficiente9.DataBindings.Add("Value", _uiController, "CostoIndirecto9");
                uneCoeficientePorc9.DataBindings.Add("Value", _uiController, "CostoIndirectoPorc9");
                //Deprecated
                //chkCoef9.DataBindings.Add("Checked", _uiController, "CostoIndirectoActivo9");
                chkCoef9.DataBindings.Add("CheckState", _uiController, "CostoIndirectoActivo9", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            if (_uiController.CoeficienteBinding(10))
            {
                uneCoeficiente10.DataBindings.Add("Value", _uiController, "CostoIndirecto10");
                uneCoeficientePorc10.DataBindings.Add("Value", _uiController, "CostoIndirectoPorc10");
                //Deprecated
                //chkCoef10.DataBindings.Add("Checked", _uiController, "CostoIndirectoActivo10");
                chkCoef10.DataBindings.Add("CheckState", _uiController, "CostoIndirectoActivo10", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            chkUsaPrecioDeCostoReposicion.DataBindings.Add("Checked", _uiController, "UsaPrecioDeCostoReposicion");
            chkUsaPrecioDeCostoReposicion1.DataBindings.Add("Checked", _uiController, "UsaPrecioDeCostoReposicion");
            unePrecioDeCostoReposicion.DataBindings.Add("Value", _uiController, "PrecioDeCostoReposicion");
            unePrecioDeCostoReposicion1.DataBindings.Add("Value", _uiController, "PrecioDeCostoReposicion");
            unePCostoPromedioPonderado.DataBindings.Add("Value", _uiController, "PrecioDeCostoPromedioPonderado");
            unePCostoPromedioPonderado1.DataBindings.Add("Value", _uiController, "PrecioDeCostoPromedioPonderado");

            unePrecioDeCostoRef.ReadOnly = true;
            unePrecioDeCostoRefLP.ReadOnly = true;

            mzCmbProveedores.Enabled = true;
            mzCmbProveedores.Init();
            mzCmbProveedores.EnableCtaCte = false; //_uiController.EnabledButtonCuentaCtaCte;

            // ---- Matias - Custom 7 - Tarea 276
            mz.erp.ui.forms.classes.ContainerManager.CollapseContainers(ultraExplorerBar1, "Momentos.ABMProductos.ContenedoresColapsados");
            // ---- Fin Matias

            // ---- Matias - Custom 8 - Tarea 279 - 20090716
            mzCEResponsableIngreso.Enabled = _uiController.AllowEditResponsableIngreso;
            if (_uiController.AskForPasswordResponsableIngreso)
            {
                this.mzCEResponsableIngreso.Nullable = true;
                this.mzCEResponsableIngreso.NullText = string.Empty;
            }
            //German 20120412 - Tarea 0000274
            //mzCEResponsableIngreso.FillFromDataSource(businessrules.data.UsuariosPersonas.GetList(), "IdPersona", "Nombre", 200, "ID", "Nombre", "Nombre");
            mzCEResponsableIngreso.FillFromDataSource(businessrules.data.UsuariosPersonas.GetList(false), "IdPersona", "Nombre", 200, "ID", "Nombre", "Nombre");
            //Fin German 20120412 - Tarea 0000274
            this.mzCEResponsableIngreso.Value = _uiController.IdResponsableCreacion;
            // ---- Fin Matias

            //German 20100426
            //ubVerificar.Enabled = this._state.Equals("NEW") && !ComprobantesRules.Producto_CodigoAutomatico;
            ubVerificar.Enabled = !ComprobantesRules.Producto_CodigoAutomatico &&
                (_state.ToUpper().Equals("NEW") || (_state.ToUpper().Equals("EDIT") && ComprobantesRules.Producto_PermiteModificarCodigoManual));
            //Fin German 20100426

            ubVerificar.Click += new EventHandler(ubVerificar_Click);

            //German 20101025 - Tarea 880
            _uiController.ListaDePreciosPrecioFinalChanged += new EventHandler(_uiController_ListaDePreciosPrecioFinalChanged);
            //Fin German 20101025 - Tarea 880

            //Sabrina: Tarea 1067. 20110311
            _visibleGenerasionMasiva = this.ultraExplorerBar1.Groups["GeneracionMasiva"].Visible;
            chkEsCombo.CheckedChanged += new EventHandler(chkEsCombo_CheckedChanged);
            this.ultraExplorerBar1.Groups["ProductosCombo"].Container.Enabled = true;
            mzComboListaDePrecios.FillFromDataSource(_uiController.ListaDePreciosTable, _uiController.KeyValueListaDePrecios, _uiController.KeyListListaDePrecios, 100, _uiController.KeyListListaDePrecios);
            mzComboListaDePrecios.Value = _uiController.IdListaDePreciosDefault;
            this.mzComboListaDePrecios.Enabled = _uiController.ListaDePreciosHabilitadas;
            mzComboListaDePrecios.ValueChanged += new EventHandler(mzComboListaDePrecios_ValueChanged);
            mzProductosControl.SetProcess("ProcesoABMProductos", "ABMProductos", "V");
            mzProductosControl.AddObjectListener((IObserver)_uiController);
            mzProductosControl.EnabledCantidad = true;
            gridManagerView2.Configure("", "", this.Name, gridProductosCombo, this.Text);
            _uiController.ProductosComboChanged += new EventHandler(_uiController_ProductosComboChanged);
            gridManagerView3.Configure("", "", this.Name, gridListasDePreciosProductosCombo, this.Text);
            gridProductosCombo.SelectionChanged += new EventHandler(gridProductosCombo_SelectionChanged);
            gridProductosCombo.RecordsDeleted += new EventHandler(gridProductosCombo_RecordsDeleted);
            gridProductosCombo.DoubleClick += new EventHandler(gridProductosCombo_DoubleClick);
            gridProductosCombo.CellEdited += new Janus.Windows.GridEX.ColumnActionEventHandler(gridProductosCombo_CellEdited);
            btnAplicarDescuento.Click += new EventHandler(btnAplicarDescuento_Click);
            gridProductosCombo.DeletingRecords += new CancelEventHandler(gridProductosCombo_DeletingRecords);
            if (_uiController.ListaDePreciosHabilitadas == false)
            {
                gridListasDePreciosProductosCombo.Visible = false;
                gridManagerView3.Visible = false;
                int height = this.ultraExplorerBarContainerControl17.Height - gridListasDePreciosProductosCombo.Height;
                this.ultraExplorerBarContainerControl17.Size = new System.Drawing.Size(this.ultraExplorerBarContainerControl17.Width, height);

            }
            //Fin Sabrina: Tarea 1067. 20110311
            /* Silvina 20110630 - Tarea 0000136 */
            chkPermiteCambio.CheckedChanged += new EventHandler(chkPermiteCambio_CheckedChanged);
            /* Fin Silvina 20110630 - Tarea 0000136 */

            //Sabrina: Tarea 1110. 20110804
            btnAgregarProveedor.Enabled = false;
            mzProveedoresControl.Init();
            mzProveedoresControl.EnableCtaCte = false;
            mzProveedoresControl.ValueChanged += new EventHandler(mzProveedoresControl_ValueChanged);
            gridManagerView4.Configure("", "", this.Name, gridCodigosProductosProveedores, this.Text);
            gridCodigosProductosProveedores.DoubleClick += new EventHandler(gridCodigosProductosProveedores_DoubleClick);
            btnAgregarProveedor.Click += new EventHandler(btnAgregarProveedor_Click);
            mzCmbProveedores.ValueChanged += new EventHandler(mzCmbProveedores_ValueChanged);
            //Fin Sabrina: Tarea 1110. 20110804

        }

        //Sabrina: Tarea 1110. 20110804
        private void mzProveedoresControl_ValueChanged(object sender, EventArgs e)
        {
            btnAgregarProveedor.Enabled = !string.Empty.Equals(((string)mzProveedoresControl.DataValue));
        }

        private void gridCodigosProductosProveedores_DoubleClick(object sender, EventArgs e)
        {
            if (gridCodigosProductosProveedores.SelectedItems.Count > 0)
            {

                object selectedItem = gridCodigosProductosProveedores.SelectedItems[0].GetRow().DataRow;
                int col = gridCodigosProductosProveedores.Col;
                if (col != -1)
                {
                    string column = gridCodigosProductosProveedores.RootTable.Columns[col].Key;
                    if (column.Equals("CodigoProductoProveedor"))
                    {
                        gridCodigosProductosProveedores.RootTable.Columns[col].EditType = Janus.Windows.GridEX.EditType.TextBox;
                        gridCodigosProductosProveedores.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
                    }
                    else
                        if (gridCodigosProductosProveedores.AllowEdit.Equals(Janus.Windows.GridEX.InheritableBoolean.True))
                            gridCodigosProductosProveedores.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                }
            }
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            _uiController.AddListaDePreciosProveedores((string)mzProveedoresControl.DataValue);
            gridCodigosProductosProveedores.SetDataBinding(_uiController.ListaDePreciosProveedores.Items, null);
        }

        private void mzCmbProveedores_ValueChanged(object sender, EventArgs e)
        {
            _uiController.AddListaDePreciosProveedores((string)mzCmbProveedores.DataValue);
            gridCodigosProductosProveedores.SetDataBinding(_uiController.ListaDePreciosProveedores.Items, null);
        }
        //Fin Sabrina: Tarea 1110. 20110804

        /* Silvina 20110630 - Tarea 0000136 */
        void chkPermiteCambio_CheckedChanged(object sender, EventArgs e)
        {
            _uiController.PermiteCambio = chkPermiteCambio.Checked;
        }
        /* Fin Silvina 20110630 - Tarea 0000136 */

        //Sabrina: Tarea 1067. 20110311
        private string _idTipoProductoAnterior = string.Empty;
        private bool _visibleGenerasionMasiva = false;
        void chkEsCombo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEsCombo.Checked)
                this.ultraExplorerBar1.Groups["GeneracionMasiva"].Visible = false;
            else
                this.ultraExplorerBar1.Groups["GeneracionMasiva"].Visible = _visibleGenerasionMasiva;
            this.ultraExplorerBar1.Groups["ProductosCombo"].Visible = chkEsCombo.Checked;
            chkObligaNumeroSerie.Enabled = !chkEsCombo.Checked;
            this.ultraExplorerBar1.Groups["DatosCompra"].Container.Enabled = !chkEsCombo.Checked;
            groupBox6.Enabled = !chkEsCombo.Checked;
            unePrecioDeCostoRef.Enabled = !chkEsCombo.Checked;
            unePrecioDeCostoRefLP.Enabled = !chkEsCombo.Checked;
            _uiController.EsCombo = chkEsCombo.Checked;
            mzComboTipoProducto.Enabled = !chkEsCombo.Checked;
            if (chkEsCombo.Checked)
            {
                _idTipoProductoAnterior = Convert.ToString(mzComboTipoProducto.Value);
                _uiController.SetearCostosACero();
                mzComboTipoProducto.Value = "C";
                chkObligaNumeroSerie.Checked = false;
            }
            else
                mzComboTipoProducto.Value = _idTipoProductoAnterior;
        }

        private void _uiController_ProductosComboChanged(object sender, EventArgs e)
        {
            gridProductosCombo.SetDataBinding(null, null);
            gridProductosCombo.SetDataBinding(_uiController.ProductosCombo, null);

        }

        private void mzComboListaDePrecios_ValueChanged(object sender, EventArgs e)
        {
            _uiController.IdListaDePreciosProductosCombo = Convert.ToString(mzComboListaDePrecios.Value);
            if (gridListaDePrecios.SelectedItems.Count > 0)
            {
                ListaDePreciosItem item = (ListaDePreciosItem)gridListaDePrecios.SelectedItems[0].GetRow().DataRow;
                if (mzComboListaDePrecios.Value != item.IdListaDePrecios)
                {
                    ListaDePreciosItem newItem = _uiController.ListaDePrecios.GetItem(_uiController.Idproducto, _uiController.IdListaDePreciosProductosCombo);
                    gridListaDePrecios.Row = _uiController.ListaDePrecios.Items.IndexOf(newItem);
                }
            }
            else
            {
                ListaDePreciosItem newItem = _uiController.ListaDePrecios.GetItem(_uiController.Idproducto, _uiController.IdListaDePreciosProductosCombo);
                gridListaDePrecios.Row = _uiController.ListaDePrecios.Items.IndexOf(newItem);

            }

        }

        private void gridProductosCombo_SelectionChanged(object sender, EventArgs e)
        {
            if (gridProductosCombo.SelectedItems.Count > 0)
            {
                mz.erp.businessrules.modelo.Combo.ComboDet comboDet = (mz.erp.businessrules.modelo.Combo.ComboDet)gridProductosCombo.SelectedItems[0].GetRow().DataRow;
                gridListasDePreciosProductosCombo.SetDataBinding(null, null);
                gridListasDePreciosProductosCombo.SetDataBinding(comboDet.ListaDePreciosComboDet.Items, null);
            }
            else
            {
                gridListasDePreciosProductosCombo.SetDataBinding(null, null);
            }
        }

        private void gridProductosCombo_DeletingRecords(object sender, CancelEventArgs e)
        {
            if (gridProductosCombo.SelectedItems.Count > 0)
            {
                ArrayList aux = new ArrayList();
                foreach (Janus.Windows.GridEX.GridEXSelectedItem item in gridProductosCombo.SelectedItems)
                {
                    aux.Add(item.GetRow().DataRow);
                }
                _uiController.ListaDeProductosComboSeleccionadoABorrar(aux);
            }

        }

        private void gridProductosCombo_RecordsDeleted(object sender, EventArgs e)
        {
            _uiController.BorrarProductosCombo();
        }

        private void gridProductosCombo_DoubleClick(object sender, EventArgs e)
        {
            if (gridProductosCombo.SelectedItems.Count > 0)
            {

                object selectedItem = gridProductosCombo.SelectedItems[0].GetRow().DataRow;
                int col = gridProductosCombo.Col;
                if (col != -1)
                {
                    string column = gridProductosCombo.RootTable.Columns[col].Key;
                    if (column.Equals("Cantidad") || column.Equals("DescuentoComboProcentual"))
                    {
                        gridProductosCombo.RootTable.Columns[col].EditType = Janus.Windows.GridEX.EditType.TextBox;
                        gridProductosCombo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
                    }
                    else
                        if (gridProductosCombo.AllowEdit.Equals(Janus.Windows.GridEX.InheritableBoolean.True))
                            gridProductosCombo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                }
            }
        }

        private void gridProductosCombo_CellEdited(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            gridProductosCombo.UpdateData();
            gridProductosCombo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            _uiController.RecalcularPreciosCombo();
        }

        private void btnAplicarDescuento_Click(object sender, EventArgs e)
        {
            decimal descuento = Convert.ToDecimal(uneDescuentoCombo.Value);
            _uiController.AplicarDescuentoCombo(descuento);
        }
        //Fin Sabrina: Tarea 1067. 20110311

        /* Silvina 20101116 - Tarea 920 */
        private string _obs = string.Empty;
        private int _size = 0;
        void txtObservaciones_TextChanged(object sender, EventArgs e)
        {
            int pos = txtObservaciones.SelectionStart;
            if (!_uiController.PermiteModificarObservaciones)
            {
                txtObservaciones.TextChanged -= new EventHandler(txtObservaciones_TextChanged);
                if ((pos < _size) || (!_uiController.PermiteAgregarObservaciones))
                    txtObservaciones.Text = _obs;
                else
                    _obs = txtObservaciones.Text;
                txtObservaciones.SelectionStart = pos;
                txtObservaciones.TextChanged += new EventHandler(txtObservaciones_TextChanged);
            }
            else
                _obs = txtObservaciones.Text;
        }
        /* Fin Silvina */

        //German 20101025 - Tarea 880

        void _uiController_ListaDePreciosPrecioFinalChanged(object sender, EventArgs e)
        {
            if (_uiController.ListaDePrecios != null)
            {
                int index = gridListaDePrecios.SelectedItems[0].Position;
                gridListaDePrecios.SetDataBinding(null, null);
                gridListaDePrecios.SetDataBinding(_uiController.ListaDePrecios.Items, null);
                gridListaDePrecios.Row = index;
                this.RefreshControls();
            }
        }
        //Fin German 20101025 - Tarea 880

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

        private void HabilitarCostosIndirectosPorDefault()
        {
            this.panelCostosIndirectos.Visible = true;

            this.chkCoef1.Checked = _uiController.CostoIndirecto1HabilitadoPorDefault;
            this.chkCoef2.Checked = _uiController.CostoIndirecto2HabilitadoPorDefault;
            this.chkCoef3.Checked = _uiController.CostoIndirecto3HabilitadoPorDefault;
            this.chkCoef4.Checked = _uiController.CostoIndirecto4HabilitadoPorDefault;
            this.chkCoef5.Checked = _uiController.CostoIndirecto5HabilitadoPorDefault;
            this.chkCoef6.Checked = _uiController.CostoIndirecto6HabilitadoPorDefault;
            this.chkCoef7.Checked = _uiController.CostoIndirecto7HabilitadoPorDefault;
            this.chkCoef8.Checked = _uiController.CostoIndirecto8HabilitadoPorDefault;
            this.chkCoef9.Checked = _uiController.CostoIndirecto9HabilitadoPorDefault;
            this.chkCoef10.Checked = _uiController.CostoIndirecto10HabilitadoPorDefault;

            this.chkCoef1_CheckedChanged(this, System.EventArgs.Empty);
            this.chkCoef2_CheckedChanged(this, System.EventArgs.Empty);
            this.chkCoef3_CheckedChanged(this, System.EventArgs.Empty);
            this.chkCoef4_CheckedChanged(this, System.EventArgs.Empty);
            this.chkCoef5_CheckedChanged(this, System.EventArgs.Empty);
            this.chkCoef6_CheckedChanged(this, System.EventArgs.Empty);
            this.chkCoef7_CheckedChanged(this, System.EventArgs.Empty);
            this.chkCoef8_CheckedChanged(this, System.EventArgs.Empty);
            this.chkCoef9_CheckedChanged(this, System.EventArgs.Empty);
            this.chkCoef10_CheckedChanged(this, System.EventArgs.Empty);
        }

        private void HabilitarCostosIndirectos()
        {
            this.panelCostosIndirectos.Visible = true;

            //_uiController.DisconnectCostosIndirectosEvent();

            if (_uiController.CoeficienteCreadoyActivo(1))
            {
                if (_uiController.CostoIndirectoActivo1)
                {	// coefic activo
                    if (_uiController.CostoIndirectoTipo1) // 0=Porc; 1=Moneda
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

            if (_uiController.CoeficienteCreadoyActivo(2))
            {
                if (_uiController.CostoIndirectoActivo2)
                {
                    if (_uiController.CostoIndirectoTipo2)
                    {
                        uneCoeficientePorc2.Enabled = false;
                    }
                }
                else
                {
                    uneCoeficiente2.Enabled = false;
                    uneCoeficientePorc2.Enabled = false;
                }
            }
            else
            {
                chkCoef2.Enabled = false;
                uneCoeficiente2.Enabled = false;
                uneCoeficientePorc2.Enabled = false;
            }

            if (_uiController.CoeficienteCreadoyActivo(3))
            {
                if (_uiController.CostoIndirectoActivo3)
                {
                    if (_uiController.CostoIndirectoTipo3)
                    {
                        uneCoeficientePorc3.Enabled = false;
                    }
                }
                else
                {
                    uneCoeficiente3.Enabled = false;
                    uneCoeficientePorc3.Enabled = false;
                }
            }
            else
            {
                chkCoef3.Enabled = false;
                uneCoeficiente3.Enabled = false;
                uneCoeficientePorc3.Enabled = false;
            }

            if (_uiController.CoeficienteCreadoyActivo(4))
            {
                if (_uiController.CostoIndirectoActivo4)
                {
                    if (_uiController.CostoIndirectoTipo4)
                    {
                        uneCoeficientePorc4.Enabled = false;
                    }
                }
                else
                {
                    uneCoeficiente4.Enabled = false;
                    uneCoeficientePorc4.Enabled = false;
                }
            }
            else
            {
                chkCoef4.Enabled = false;
                uneCoeficiente4.Enabled = false;
                uneCoeficientePorc4.Enabled = false;
            }

            if (_uiController.CoeficienteCreadoyActivo(5))
            {
                if (_uiController.CostoIndirectoActivo5)
                {
                    if (_uiController.CostoIndirectoTipo5)
                    {
                        uneCoeficientePorc5.Enabled = false;
                    }
                }
                else
                {
                    uneCoeficiente5.Enabled = false;
                    uneCoeficientePorc5.Enabled = false;
                }
            }
            else
            {
                chkCoef5.Enabled = false;
                uneCoeficiente5.Enabled = false;
                uneCoeficientePorc5.Enabled = false;
            }

            //_uiController.ConnectCostosIndirectosEvent();
        }




        protected override void FillControls()
        {
            System.Data.DataRow _row = mz.erp.businessrules.tsh_ProductosEx.GetDataRowProductos(_data);
            if (_row != null)
            {
                _uiController.Idproducto = Convert.ToString(_row["IdProducto"]);
                /*
                if(_row["IdProveedorDefault"] != null && !_row["IdProveedorDefault"].ToString().Equals(string.Empty))
                    mzCmbProveedor.DataValue = (string)_row["IdProveedorDefault"];
                */
                mzComboTipoProducto.Value = (string)_row["IdTipoProducto"];

                txtCodigo.Text = (string)_row["Codigo"];
                txtCodigoSecundario.Text = (string)_row["CodigoSecundario"];
                txtDescripcion.Text = (string)_row["Descripcion"];
                txtDescripcionCorta.Text = (string)_row["DescripcionCorta"];
                txtDescripcionLarga.Text = (string)_row["DescripcionLarga"];
                chkObligaCodigoBarra.Checked = (bool)_row["ObligaCodigoBarra"];
                chkObligaNumeroSerie.Checked = (bool)_row["ObligaNumeroSerie"];

                if (!(_row["IdMonedaCierrePrecioDeVentaBruto"] == System.DBNull.Value))
                    mzCEMoneda.Value = Convert.ToString(_row["IdMonedaCierrePrecioDeVentaBruto"]);
                else mzCEMoneda.Value = Variables.GetValueString("Contabilidad.MonedaReferencia");
                if (!(_row["IdMonedaCierrePrecioDeCostoRef"] == System.DBNull.Value))
                    mzCEMonedaPrecioDeCosto.Value = Convert.ToString(_row["IdMonedaCierrePrecioDeCostoRef"]);
                else mzCEMonedaPrecioDeCosto.Value = Variables.GetValueString("Contabilidad.MonedaReferencia");
                if (!(_row["IdCotizacionCierrePrecioDeCostoRef"] == System.DBNull.Value))
                {
                    string IdCotizacionPrecioDeCosto = Convert.ToString(_row["IdCotizacionCierrePrecioDeCostoRef"]);
                    Cotizacion cotizacion = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCotizacion(IdCotizacionPrecioDeCosto);
                    _uiController.IdCotizacionCierrePrecioDeCostoRef = IdCotizacionPrecioDeCosto;
                    mzCEFuenteDeCambioPrecioDeCosto.Value = cotizacion.IdFuenteDeCambio;
                }
                else
                {
                    mzCEFuenteDeCambioPrecioDeCosto.Value = Variables.GetValueString("Contabilidad.FuenteDeCambioReferencia");
                    _uiController.IdCotizacionCierrePrecioDeCostoRef = Variables.GetValueString("Contabilidad.CotizacionReferencia");

                }
                if (!(_row["IdCotizacionCierrePrecioDeVentaBruto"] == System.DBNull.Value))
                {
                    _uiController.IdCotizacionCierrePrecioDeVentaBruto = Convert.ToString(_row["IdCotizacionCierrePrecioDeVentaBruto"]);
                }
                else _uiController.IdCotizacionCierrePrecioDeVentaBruto = Variables.GetValueString("Contabilidad.CotizacionReferencia");
                _uiController.IdMonedaCierrePrecioDeCostoRef = Convert.ToString(mzCEMonedaPrecioDeCosto.Value);
                _uiController.IdMonedaCierrePrecioDeVentaBruto = Convert.ToString(mzCEMoneda.Value);
                _uiController.IdFuenteDeCambioPrecioDeCostoRef = Convert.ToString(mzCEFuenteDeCambioPrecioDeCosto.Value);
                _uiController.IdFuenteDeCambioPrecioDeVentaBruto = Variables.GetValueString("Contabilidad.FuenteDeCambioReferencia");

                /* Silvina 20101116 - Tarea 820 */
                txtObservaciones.TextChanged -= new EventHandler(txtObservaciones_TextChanged);
                _obs = (string)_row["Observaciones"];
                txtObservaciones.Text = _obs;
                _size = _obs.Length;
                txtObservaciones.TextChanged += new EventHandler(txtObservaciones_TextChanged);
                /* Fin Silvina */
                txtCampoAuxiliar1.Text = (string)_row["CampoAuxiliar1"];
                txtCampoAuxiliar2.Text = (string)_row["CampoAuxiliar2"];
                txtCampoAuxiliar3.Text = (string)_row["CampoAuxiliar3"];
                txtCampoAuxiliar4.Text = (string)_row["CampoAuxiliar4"];
                txtCampoAuxiliar5.Text = (string)_row["CampoAuxiliar5"];
                //txtCampoAuxiliar6.Text = (string ) _row["CampoAuxiliar6"];



                //Sabrina: tarea 56
                _uiController.CargarCoeficientesIndirectos();

                //Sabrina: Tarea 1067. 20110311                
                _uiController.CambioDescuentoCombo = true;
                _idTipoProductoAnterior = Convert.ToString(mzComboTipoProducto.Value);
                bool esCombo = (bool)_row["EsCombo"];
                chkEsCombo.Checked = esCombo;
                _uiController.EsCombo = esCombo;
                if (esCombo)
                {
                    _uiController.InitProductosCombo();
                    gridProductosCombo.SetDataBinding(_uiController.ProductosCombo, null);
                    if (this._state.Equals("EDIT"))
                        chkEsCombo.Enabled = false;

                }
                _uiController.IdListaDePreciosProductosCombo = _uiController.IdListaDePreciosDefault;
                //Fin Sabrina: Tarea 1067. 20110311

                _uiController.UsaPrecioDeCostoReposicion = (bool)_row["UsaPrecioDeCostoReposicion"];
                _uiController.PrecioDeCostoReposicion = (decimal)_row["PrecioDeCostoReposicion"];
                _uiController.PrecioDeCostoPromedioPonderado = (decimal)_row["PrecioDeCostoPromedioPonderado"];

                if (_uiController.State.Equals("EDIT"))
                    //Edita un Producto
                    HabilitarCostosIndirectos();
                else
                    //Nuevo Producto
                    HabilitarCostosIndirectosPorDefault();


                _uiController.Margen = (decimal)_row["MAC"];

                _uiController.PrecioNeto = (decimal)_row["PrecioDeVentaNeto"];
                _uiController.DescuentoPorcentual = (decimal)_row["MaxDescuentoPorcentual"];
                _uiController.DescuentoMax = (decimal)_row["MaxDescuento"];
                _uiController.PrecioLista = (decimal)_row["PrecioDeVentaBruto"];
                chkActivo.Checked = (bool)_row["Activo"];
                mzCEBonificacion.Value = (string)_row["IdBonificacion"];
                ucePercibeIB.Checked = Convert.ToBoolean(_row["PercibeIB"]);

                gridSucursales.SetDataBinding(_uiController.Sucursales, null);
                gridImpuestos.SetDataBinding(_uiController.Impuestos, null);
                if (_state == "NEW")
                {
                    _uiController.SetImpuestosDefault();
                }

                //Sabrina: Tarea 1068. 20110317
                if (_uiController.State.Equals("EDIT"))
                {
                    _uiController.PrecioDeCostoRefBD = (decimal)_row["PrecioDeCostoRef"];
                    _uiController.PrecioDeVentaBrutoBD = (decimal)_row["PrecioDeVentaBruto"];
                }
                //Fin Sabrina: Tarea 1068. 20110317
                System.Data.DataRow _rowPA = mz.erp.businessrules.tsh_ProductosEx.GetDataRowProductosAuxiliares(_data);
                if (_rowPA != null)
                {
                    _uiController.Contador = Convert.ToInt64(_rowPA["Contador"]);
                    uneContador.Value = Convert.ToString(_rowPA["Contador"]);
                    if (_rowPA["Thumb"] != null)
                    {
                        pictureBoxThumb.Image = systemframework.Util.BytesToImage((byte[])_rowPA["Thumb"]);
                        chkThumb.Checked = true;
                    }
                    else
                        chkThumb.Checked = false;

                    if (_rowPA["Imagen"] != null)
                        pictureBoxImagen.Image = systemframework.Util.BytesToImage((byte[])_rowPA["Imagen"]);
                    /*uneCoeficientePorc1.Value = Convert.ToDecimal(_rowPA["Coeficiente1"]);
                    uneCoeficientePorc2.Value = Convert.ToDecimal(_rowPA["Coeficiente2"]);
                    uneCoeficientePorc3.Value = Convert.ToDecimal(_rowPA["Coeficiente3"]);
                    uneCoeficientePorc4.Value = Convert.ToDecimal(_rowPA["Coeficiente4"]);
                    uneCoeficientePorc5.Value = Convert.ToDecimal(_rowPA["Coeficiente5"]);
                    */

                    txtLink1.Text = Convert.ToString(_rowPA["Link1"]);
                    txtLink2.Text = Convert.ToString(_rowPA["Link2"]);
                    txtLink3.Text = Convert.ToString(_rowPA["Link3"]);
                    txtLink4.Text = Convert.ToString(_rowPA["Link4"]);
                    txtLink5.Text = Convert.ToString(_rowPA["Link5"]);


                }
                else
                {
                    chkThumb.Checked = false;

                }

                txtCodigoSecundario1.Text = _uiController.CodigoSecundario1;
                txtCodigoSecundario2.Text = _uiController.CodigoSecundario2;
                txtCodigoSecundario3.Text = _uiController.CodigoSecundario3;
                txtCodigoSecundario4.Text = _uiController.CodigoSecundario4;
                txtCodigoSecundario5.Text = _uiController.CodigoSecundario5;
                txtCodigoSecundario6.Text = _uiController.CodigoSecundario6;
                txtCodigoSecundario7.Text = _uiController.CodigoSecundario7;
                txtCodigoSecundario8.Text = _uiController.CodigoSecundario8;
                txtCodigoSecundario9.Text = _uiController.CodigoSecundario9;
                txtCodigoSecundario10.Text = _uiController.CodigoSecundario10;
                txtCodigoSecundario11.Text = _uiController.CodigoSecundario11;
                txtCodigoSecundario12.Text = _uiController.CodigoSecundario12;
                txtCodigoSecundario13.Text = _uiController.CodigoSecundario13;
                txtCodigoSecundario14.Text = _uiController.CodigoSecundario14;
                txtCodigoSecundario15.Text = _uiController.CodigoSecundario15;
                txtCodigoSecundario16.Text = _uiController.CodigoSecundario16;
                txtCodigoSecundario17.Text = _uiController.CodigoSecundario17;
                txtCodigoSecundario18.Text = _uiController.CodigoSecundario18;
                txtCodigoSecundario19.Text = _uiController.CodigoSecundario19;
                txtCodigoSecundario20.Text = _uiController.CodigoSecundario20;
                //Sabrina: Tarea 1110. 20110805
                //txtCodigoProductoSegunProveedor.Text = _uiController.CodigoProductoSegunProveedor;
                //Fin Sabrina: Tarea 1110. 20110805
                chkCodigoSecundarioSegmentado.Checked = _uiController.TieneCodigoSecundarioSegmentado;
                _uiController.InitListaDePrecios();
                gridListaDePrecios.SetDataBinding(_uiController.ListaDePrecios.Items, null);

                // ---- Matias - Custom 8 - Tarea 279 - 20090716
                if (!_state.Equals("NEW"))
                {
                    this.mzCEResponsableIngreso.Value = Convert.ToString(_row["IdResponsableCreacion"]);
                }
                // ---- Fin Matias

                /* Silvina 20101115 - Tarea 930 */
                if (_uiController.FechaAlta.Equals(Convert.ToDateTime("01/01/1753").Date))
                    fecha.Value = null;
                else
                    fecha.Value = _uiController.FechaAlta;
                /* Fin Silvina */
                //Sabrina: Tarea 1067. 20110311
                _uiController.CambioDescuentoCombo = false;
                //Fin Sabrina: Tarea 1067. 20110311
                /* Silvina 20110630 - Tarea 0000136 */
                chkPermiteCambio.Checked = _uiController.PermiteCambio;
                /* Fin Silvina 20110630 - Tarea 0000136 */

                //Sabrina: Tarea 1110. 20110805
                _uiController.InitListaDePreciosProveedores();
                gridCodigosProductosProveedores.SetDataBinding(_uiController.ListaDePreciosProveedores.Items, null);
                //Fin Sabrina: Tarea 1110. 20110805

                this.RefreshControls();
            }
        }

        protected override void DumpControls()
        {
            utility.Util.MoveFocus(this.ultraExplorerBarContainerControl9);
            System.Data.DataRow _row = mz.erp.businessrules.tsh_ProductosEx.GetDataRowProductos(_data);
            if (_row != null)
            {
                string codigo = Convert.ToString(mzCmbProveedores.DataValue);
                _uiController.CodigoProveedorDefault = codigo;
                _uiController.BonificacionesAcumulativas = chckBonificacionesAcumulativas.Checked;
                _uiController.Codigo = txtCodigo.Text;
                _uiController.CodigoSecundario = txtCodigoSecundario.Text;
                _uiController.Descripcion = txtDescripcion.Text;
                _uiController.DescripcionCorta = txtDescripcionCorta.Text;
                _uiController.DescripcionLarga = txtDescripcionLarga.Text;
                _uiController.ObligaCodigoBarra = chkObligaCodigoBarra.Checked;
                _uiController.ObligaNumeroSerie = chkObligaNumeroSerie.Checked;
                _uiController.Activo = chkActivo.Checked;
                _uiController.PercibeIBBD = ucePercibeIB.Checked;
                _uiController.MAC = Convert.ToDecimal(uneMAC.Value);
                _uiController.PrecioDeCostoRef = Convert.ToDecimal(unePrecioDeCostoRef.Value);
                _uiController.PrecioDeVentaNeto = Convert.ToDecimal(unePrecioDeVentaNeto.Value);
                _uiController.MaxDescuentoPorcentual = Convert.ToDecimal(uneMaxDescuentoPorcentual.Value);
                _uiController.MaxDescuento = Convert.ToDecimal(uneMaxDescuento.Value);
                _uiController.PrecioDeVentaBruto = Convert.ToDecimal(unePrecioVentaBruto.Value);

                /*if(!_uiController.CoeficientesPorVariable)
                {
                    _uiController.Coeficiente1 = Convert.ToDecimal(uneCoeficientePorc1.Value);
                    _uiController.Coeficiente2 = Convert.ToDecimal(uneCoeficientePorc2.Value);
                    _uiController.Coeficiente3 = Convert.ToDecimal(uneCoeficientePorc3.Value);
                    _uiController.Coeficiente4 = Convert.ToDecimal(uneCoeficientePorc4.Value);
                    _uiController.Coeficiente5 = Convert.ToDecimal(uneCoeficientePorc5.Value);
                }

                */
                //Sabrina: tarea 56
                /*if((_uiController.Coeficiente1 +  _uiController.Coeficiente2 + _uiController.Coeficiente3 + _uiController.Coeficiente4 + _uiController.Coeficiente5 )> 0)
                {
                    decimal costoDirecto = Convert.ToDecimal(unePrecioDeCostoRef.Value) / (1 + ((_uiController.Coeficiente1 +  _uiController.Coeficiente2 + _uiController.Coeficiente3 + _uiController.Coeficiente4 + _uiController.Coeficiente5)/100));
                    _uiController.PrecioDeCostoDirecto = costoDirecto;
                    _uiController.PrecioDeCostoIndirecto = Convert.ToDecimal(unePrecioDeCostoRef.Value) - costoDirecto;
                }
                else
                {
                    _uiController.PrecioDeCostoDirecto = Convert.ToDecimal(unePrecioDeCostoRef.Value);
                    _uiController.PrecioDeCostoIndirecto  = 0;
                }
                */


                _uiController.Contador = Convert.ToInt64(uneContador.Value);
                if (chkThumb.Checked)
                    _uiController.Thumb = pictureBoxThumb.Image;
                _uiController.Imagen = pictureBoxImagen.Image;
                _uiController.IdBonificacion = Convert.ToString(mzCEBonificacion.Value);
                _uiController.IdTiposProducto = Convert.ToString(mzComboTipoProducto.Value);
                _uiController.IdMonedaCierrePrecioDeVentaBrutoBD = Convert.ToString(mzCEMoneda.Value);
                _uiController.IdMonedaCierrePrecioDeVentaNetoBD = Convert.ToString(mzCEMoneda.Value);
                _uiController.IdMonedaCierreMaxDescuentoBD = Convert.ToString(mzCEMoneda.Value);
                _uiController.IdMonedaCierrePrecioDeCostoRefBD = Convert.ToString(mzCEMonedaPrecioDeCosto.Value);
                Cotizacion cotizacionPrecioDeCosto = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCoeficienteCotizacion(Convert.ToString(mzCEMonedaPrecioDeCosto.Value), Variables.GetValueString("Contabilidad.MonedaReferencia"), Convert.ToString(mzCEFuenteDeCambioPrecioDeCosto.Value));
                _uiController.IdCotizacionCierrePrecioDeCostoRefBD = _uiController.IdCotizacionCierrePrecioDeCostoRef;//cotizacionPrecioDeCosto.IdCotizacion;
                Cotizacion cotizacionPrecioDeVenta = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCoeficienteCotizacion(Convert.ToString(mzCEMoneda.Value), Variables.GetValueString("Contabilidad.MonedaReferencia"), Variables.GetValueString("Contabilidad.FuenteDeCambioReferencia"));
                _uiController.IdCotizacionCierrePrecioDeVentaBrutoBD = _uiController.IdCotizacionCierrePrecioDeVentaBruto;//cotizacionPrecioDeVenta.IdCotizacion;
                _uiController.IdCotizacionCierrePrecioDeVentaNetoBD = _uiController.IdCotizacionCierrePrecioDeVentaBruto; ;
                _uiController.IdCotizacionCierreMaxDescuentoBD = _uiController.IdCotizacionCierrePrecioDeVentaBruto; ;
                /*_uiController.Coeficiente1 = Convert.ToDecimal(uneCoeficientePorc1.Value);
                _uiController.Coeficiente2 = Convert.ToDecimal(uneCoeficientePorc2.Value);
                _uiController.Coeficiente3 = Convert.ToDecimal(uneCoeficientePorc3.Value);
                _uiController.Coeficiente4 = Convert.ToDecimal(uneCoeficientePorc4.Value);
                _uiController.Coeficiente5 = Convert.ToDecimal(uneCoeficientePorc5.Value);
                 */
                _uiController.CodigoSecundario1 = txtCodigoSecundario1.Text;
                _uiController.CodigoSecundario2 = txtCodigoSecundario2.Text;
                _uiController.CodigoSecundario3 = txtCodigoSecundario3.Text;
                _uiController.CodigoSecundario4 = txtCodigoSecundario4.Text;
                _uiController.CodigoSecundario5 = txtCodigoSecundario5.Text;
                _uiController.CodigoSecundario6 = txtCodigoSecundario6.Text;
                _uiController.CodigoSecundario7 = txtCodigoSecundario7.Text;
                _uiController.CodigoSecundario8 = txtCodigoSecundario8.Text;
                _uiController.CodigoSecundario9 = txtCodigoSecundario9.Text;
                _uiController.CodigoSecundario10 = txtCodigoSecundario10.Text;
                _uiController.CodigoSecundario11 = txtCodigoSecundario11.Text;
                _uiController.CodigoSecundario12 = txtCodigoSecundario12.Text;
                _uiController.CodigoSecundario13 = txtCodigoSecundario13.Text;
                _uiController.CodigoSecundario14 = txtCodigoSecundario14.Text;
                _uiController.CodigoSecundario15 = txtCodigoSecundario15.Text;
                _uiController.CodigoSecundario16 = txtCodigoSecundario16.Text;
                _uiController.CodigoSecundario17 = txtCodigoSecundario17.Text;
                _uiController.CodigoSecundario18 = txtCodigoSecundario18.Text;
                _uiController.CodigoSecundario19 = txtCodigoSecundario19.Text;
                _uiController.CodigoSecundario20 = txtCodigoSecundario20.Text;
                _uiController.TieneCodigoSecundarioSegmentado = chkCodigoSecundarioSegmentado.Checked;

                //Sabrina: Tarea 1110. 20110805
                //_uiController.CodigoProductoSegunProveedor = txtCodigoProductoSegunProveedor.Text;
                //Fin Sabrina: Tarea 1110. 20110805

                _uiController.CampoAuxiliar1 = txtCampoAuxiliar1.Text;
                _uiController.CampoAuxiliar2 = txtCampoAuxiliar2.Text;
                _uiController.CampoAuxiliar3 = txtCampoAuxiliar3.Text;
                _uiController.CampoAuxiliar4 = txtCampoAuxiliar4.Text;
                _uiController.CampoAuxiliar5 = txtCampoAuxiliar5.Text;
                _uiController.CampoAuxiliar6 = mzSearchTextBox1.NodeDescription;
                _uiController.Observaciones = txtObservaciones.Text;
                _uiController.Link1 = txtLink1.Text;
                _uiController.Link2 = txtLink2.Text;
                _uiController.Link3 = txtLink3.Text;
                _uiController.Link4 = txtLink4.Text;
                _uiController.Link5 = txtLink5.Text;

                /*
                 * 
                 * _row["Codigo"] = txtCodigo.Text;
                _row["CodigoSecundario"] = txtCodigoSecundario.Text;
                _row["Descripcion"] = txtDescripcion.Text;
                _row["DescripcionCorta"] = txtDescripcionCorta.Text;
                _row["DescripcionLarga"] = txtDescripcionLarga.Text;
                _row["ObligaCodigoBarra"] = chkObligaCodigoBarra.Checked;
                _row["ObligaNumeroSerie"] = chkObligaNumeroSerie.Checked;
                _row["Activo"] = chkActivo.Checked;
                _row["PercibeIB"] = ucePercibeIB.Checked;
                _row["MAC"] = uneMAC.Value;
                _row["PrecioDeCostoRef"] = unePrecioDeCostoRef.Value;
                _row["PrecioDeVentaNeto"] = unePrecioDeVentaNeto.Value;
                _row["MaxDescuentoPorcentual"] = uneMaxDescuentoPorcentual.Value;
                _row["MaxDescuento"] = uneMaxDescuento.Value;
                _row["PrecioDeVentaBruto"] = unePrecioVentaBruto.Value;
                if(_uiController.ConfiguracionBasica)
                {
                    if((coeficiente1 + coeficiente2 )> 0)
                    {
                        decimal costoDirecto = Convert.ToDecimal(unePrecioDeCostoRef.Value) / (1 + ((coeficiente1 + coeficiente2 )/100));
                        _row["PrecioDeCostoDirecto"] = costoDirecto;
                        _row["PrecioDeCostoIndirecto"] = Convert.ToDecimal(unePrecioDeCostoRef.Value) - costoDirecto;
                    }
                    else
                    {
                        _row["PrecioDeCostoDirecto"] = unePrecioDeCostoRef.Value;
                        _row["PrecioDeCostoIndirecto"] = 0;
                    }
                }
                _row["IdBonificacion"] = mzCEBonificacion.Value;
                _row["IdTipoProducto"] =mzComboTipoProducto.Value;
                _row["IdMonedaCierrePrecioDeVentaBruto"]=mzCEMoneda.Value;
                _row["IdMonedaCierrePrecioDeVentaNeto"]=mzCEMoneda.Value;
                _row["IdMonedaCierreMaxDescuento"]=mzCEMoneda.Value;
                _row["IdMonedaCierrePrecioDeCostoRef"] = mzCEMonedaPrecioDeCosto.Value;
                Cotizacion cotizacionPrecioDeCosto = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCoeficienteCotizacion(Convert.ToString(mzCEMonedaPrecioDeCosto.Value), Variables.GetValueString("Contabilidad.MonedaReferencia"),Convert.ToString(mzCEFuenteDeCambioPrecioDeCosto.Value));
                _row["IdCotizacionCierrePrecioDeCostoRef"] = _uiController.IdCotizacionCierrePrecioDeCostoRef;//cotizacionPrecioDeCosto.IdCotizacion;
                Cotizacion cotizacionPrecioDeVenta = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCoeficienteCotizacion(Convert.ToString(mzCEMoneda.Value), Variables.GetValueString("Contabilidad.MonedaReferencia"), Variables.GetValueString("Contabilidad.FuenteDeCambioReferencia"));
                _row["IdCotizacionCierrePrecioDeVentaBruto"] =_uiController.IdCotizacionCierrePrecioDeVentaBruto;//cotizacionPrecioDeVenta.IdCotizacion;
                _row["IdCotizacionCierrePrecioDeVentaNeto"] =_uiController.IdCotizacionCierrePrecioDeVentaBruto;;
                _row["IdCotizacionCierreMaxDescuento"] =_uiController.IdCotizacionCierrePrecioDeVentaBruto;;
                 * */
                gridSucursales.UpdateData();
                gridImpuestos.UpdateData();
                gridProductos.UpdateData();

                _uiController.IdMonedaCierrePrecioDeVentaBruto = Convert.ToString(mzCEMoneda.Value);

                _uiController.IdResponsableCreacion = Convert.ToString(mzCEResponsableIngreso.Value);

                //Sabrina: Tarea 1067. 20110311
                _uiController.EsCombo = chkEsCombo.Checked;
                //Fin Sabrina: Tarea 1067. 20110311
                _data = _uiController.Commit(ucePercibeIB.Checked);
                //Sabrina: Tarea 1068. 20110317
                _data = _uiController.ActualizarPreciosProductosCombo();
                //Fin Sabrina: Tarea 1068. 20110317
            }
        }



        private void ultraExplorerBarContainerControl1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }



        private void bAgregar_Click(object sender, System.EventArgs e)
        {

            mz.erp.ui.forms.mzSearchForm form = new mz.erp.ui.forms.mzSearchForm(typeof(mz.erp.ui.forms.classes.sy_Sucursales));
            form.ShowDialog();
            if (form.SelectedValue != null && (Convert.ToString(form.SelectedValue) != string.Empty))
            {
                mz.erp.businessrules.tsh_ProductosEx.AddNewRowSucursales(_data, (long)form.SelectedValue);
            }
            gridSucursales.Refetch();
        }

        private void gridEX1_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

        }

        private void mzCEBonificacion_ValueChanged(object sender, System.EventArgs e)
        {
            string IdBonificacion = (string)mzCEBonificacion.Value;
            if (IdBonificacion != null)
                gridEX1.DataSource = mz.erp.businessrules.tsa_BonificacionesDet.GetList(IdBonificacion, decimal.MinValue).tsa_BonificacionesDet;
        }

        private void ultraExplorerBar1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PageDown)
                this.ultraExplorerBar1.PerformAction(UltraExplorerBarAction.ScrollPageDown);
        }

        private void txtCodigo_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PageDown)
                this.ultraExplorerBar1.PerformAction(UltraExplorerBarAction.ScrollPageDown);
            else if (e.KeyCode == Keys.PageUp) this.ultraExplorerBar1.PerformAction(UltraExplorerBarAction.ScrollPageUp);
        }

        private void gridSucursales_CurrentCellChanged(object sender, System.EventArgs e)
        {
            gridEX1.UpdateData();
        }

        private void txtDescripcion_TextChanged(object sender, System.EventArgs e)
        {
            txtDescripcionCorta.Text = txtDescripcion.Text;
            txtDescripcionLarga.Text = txtDescripcion.Text;
        }

        private void mzCEBonificacion_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                //German 20120208 - Tarea 0000276
                mzCEBonificacion.FillFromDataSource(businessrules.tsa_Bonificaciones.GetList(null, null, Constantes.TipoBonificacionProducto).tsa_Bonificaciones, "IdBonificacion", "Codigo", 100, "1", "2", "Codigo");
                //German 20120208 - Tarea 0000276
                gridEX1.DataSource = null;
            }

        }

        private void On_Enter(object sender, EventArgs e)
        {
            //TO DO asignar descuento porcentual lista de precio
            ((Infragistics.Win.UltraWinEditors.UltraNumericEditor)sender).SelectAll();
        }

        private void FrmAbmExProductos_Load(object sender, System.EventArgs e)
        {

        }

        private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
        {

        }

        private string _desc1 = string.Empty;
        private string _desc2 = string.Empty;
        private string _desc3 = string.Empty;
        private string _desc4 = string.Empty;
        private string _desc5 = string.Empty;
        private string _desc6 = string.Empty;
        private string _desc7 = string.Empty;
        private string _desc8 = string.Empty;

        private void hierarchicalSearchControl1_OnSelected(object sender, EventArgs e)
        {
            _uiController.ByJerarquia1 = hierarchicalSearchControl1.NodeChecked1;
            _uiController.Jerarquia1 = hierarchicalSearchControl1.ItemsJerarquia1;
            _uiController.ByJerarquia2 = hierarchicalSearchControl1.NodeChecked2;
            _uiController.Jerarquia2 = hierarchicalSearchControl1.ItemsJerarquia2;
            _uiController.ByJerarquia3 = hierarchicalSearchControl1.NodeChecked3;
            _uiController.Jerarquia3 = hierarchicalSearchControl1.ItemsJerarquia3;
            _uiController.ByJerarquia4 = hierarchicalSearchControl1.NodeChecked4;
            _uiController.Jerarquia4 = hierarchicalSearchControl1.ItemsJerarquia4;
            _uiController.ByJerarquia5 = hierarchicalSearchControl1.NodeChecked5;
            _uiController.Jerarquia5 = hierarchicalSearchControl1.ItemsJerarquia5;
            _uiController.ByJerarquia6 = hierarchicalSearchControl1.NodeChecked6;
            _uiController.Jerarquia6 = hierarchicalSearchControl1.ItemsJerarquia6;
            _uiController.ByJerarquia7 = hierarchicalSearchControl1.NodeChecked7;
            _uiController.Jerarquia7 = hierarchicalSearchControl1.ItemsJerarquia7;
            _uiController.ByJerarquia8 = hierarchicalSearchControl1.NodeChecked8;
            _uiController.Jerarquia8 = hierarchicalSearchControl1.ItemsJerarquia8;


            if (_uiController.ByJerarquia1 && !hierarchicalSearchControl1.NodeDescripcion1.Equals(string.Empty) && !chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion1))
            {
                if (chkLista.Items.Contains(_desc1))
                    chkLista.Items.Remove(_desc1);
                chkLista.Items.Add(hierarchicalSearchControl1.NodeDescripcion1, true);
                _desc1 = hierarchicalSearchControl1.NodeDescripcion1;
            }
            else if (!_uiController.ByJerarquia1 && chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion1))
                chkLista.Items.Remove(hierarchicalSearchControl1.NodeDescripcion1);
            if (_uiController.ByJerarquia2 && !hierarchicalSearchControl1.NodeDescripcion2.Equals(string.Empty) && !chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion2))
            {
                if (chkLista.Items.Contains(_desc2))
                    chkLista.Items.Remove(_desc2);
                chkLista.Items.Add(hierarchicalSearchControl1.NodeDescripcion2, true);
                _desc2 = hierarchicalSearchControl1.NodeDescripcion2;
            }
            else if (!_uiController.ByJerarquia2 && chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion2))
                chkLista.Items.Remove(hierarchicalSearchControl1.NodeDescripcion2);
            if (_uiController.ByJerarquia3 && !hierarchicalSearchControl1.NodeDescripcion3.Equals(string.Empty) && !chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion3))
            {
                if (chkLista.Items.Contains(_desc3))
                    chkLista.Items.Remove(_desc3);
                chkLista.Items.Add(hierarchicalSearchControl1.NodeDescripcion3, true);
                _desc3 = hierarchicalSearchControl1.NodeDescripcion3;
            }
            else if (!_uiController.ByJerarquia3 && chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion3))
                chkLista.Items.Remove(hierarchicalSearchControl1.NodeDescripcion3);
            if (_uiController.ByJerarquia4 && !hierarchicalSearchControl1.NodeDescripcion4.Equals(string.Empty) && !chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion4))
            {
                if (chkLista.Items.Contains(_desc4))
                    chkLista.Items.Remove(_desc4);
                chkLista.Items.Add(hierarchicalSearchControl1.NodeDescripcion4, true);
                _desc4 = hierarchicalSearchControl1.NodeDescripcion4;
            }
            else if (!_uiController.ByJerarquia4 && chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion4))
                chkLista.Items.Remove(hierarchicalSearchControl1.NodeDescripcion4);
            if (_uiController.ByJerarquia5 && !hierarchicalSearchControl1.NodeDescripcion5.Equals(string.Empty) && !chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion5))
            {
                if (chkLista.Items.Contains(_desc5))
                    chkLista.Items.Remove(_desc5);
                chkLista.Items.Add(hierarchicalSearchControl1.NodeDescripcion5, true);
                _desc5 = hierarchicalSearchControl1.NodeDescripcion5;
            }
            else if (!_uiController.ByJerarquia5 && chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion5))
                chkLista.Items.Remove(hierarchicalSearchControl1.NodeDescripcion5);

            if (_uiController.ByJerarquia6 && !hierarchicalSearchControl1.NodeDescripcion6.Equals(string.Empty) && !chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion6))
            {
                if (chkLista.Items.Contains(_desc6))
                    chkLista.Items.Remove(_desc6);
                chkLista.Items.Add(hierarchicalSearchControl1.NodeDescripcion6, true);
                _desc6 = hierarchicalSearchControl1.NodeDescripcion6;
            }
            else if (!_uiController.ByJerarquia6 && chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion6))
                chkLista.Items.Remove(hierarchicalSearchControl1.NodeDescripcion6);



            if (_uiController.ByJerarquia7 && !hierarchicalSearchControl1.NodeDescripcion7.Equals(string.Empty) && !chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion7))
            {
                if (chkLista.Items.Contains(_desc7))
                    chkLista.Items.Remove(_desc7);
                chkLista.Items.Add(hierarchicalSearchControl1.NodeDescripcion7, true);
                _desc7 = hierarchicalSearchControl1.NodeDescripcion7;
            }
            else if (!_uiController.ByJerarquia7 && chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion7))
                chkLista.Items.Remove(hierarchicalSearchControl1.NodeDescripcion7);


            if (_uiController.ByJerarquia8 && !hierarchicalSearchControl1.NodeDescripcion8.Equals(string.Empty) && !chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion8))
            {
                if (chkLista.Items.Contains(_desc8))
                    chkLista.Items.Remove(_desc8);
                chkLista.Items.Add(hierarchicalSearchControl1.NodeDescripcion8, true);
                _desc8 = hierarchicalSearchControl1.NodeDescripcion8;
            }
            else if (!_uiController.ByJerarquia8 && chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion8))
                chkLista.Items.Remove(hierarchicalSearchControl1.NodeDescripcion8);





        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int index = chkLista.SelectedIndex;
            if (index != -1)
            {
                if (index < chkLista.Items.Count - 1)
                {
                    object aux = chkLista.Items[index];
                    chkLista.Items[index] = chkLista.Items[index + 1];
                    chkLista.Items[index + 1] = aux;
                    chkLista.SelectedIndex = index + 1;
                }
            }


        }

        private void btnSubir_Click(object sender, EventArgs e)
        {

            int index = chkLista.SelectedIndex;
            if (index != -1)
            {
                if (index > 0)
                {

                    object aux = chkLista.Items[index];
                    chkLista.Items[index] = chkLista.Items[index - 1];
                    chkLista.Items[index - 1] = aux;
                    chkLista.SelectedIndex = index - 1;
                }
            }
        }

        private void btnCobinar_Click(object sender, EventArgs e)
        {
            bool DescripcionChecked = false;

            int indexDescripcion = -1;
            ArrayList ckeckedList = new ArrayList();
            foreach (object chk in chkLista.CheckedItems)
            {
                if (chk.Equals("Descripción"))
                {
                    ckeckedList.Add(Constantes.CampoDescripcionProductoKey);
                }
                else
                {
                    ckeckedList.Add(hierarchicalSearchControl1.GetKeyPathList(Convert.ToString(chk)));
                }

            }
            _uiController.CombinarDescripciones(txtDescripcion.Text, ckeckedList);
            gridProductos.SetDataBinding(null, null);
            gridProductos.SetDataBinding(_uiController.Productos, null);
        }

        private void utbEliminarTodos_Click(object sender, EventArgs e)
        {
            _uiController.ClearProductos();
            gridProductos.SetDataBinding(null, null);
            gridProductos.SetDataBinding(_uiController.Productos, null);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            gridProductos.Delete();
            /*
            if(gridProductos.SelectedItems.Count > 0)
            {
                ArrayList aux = new ArrayList();
                foreach(Janus.Windows.GridEX.GridEXSelectedItem item in gridProductos.SelectedItems)
                {
                    aux.Add(item.GetRow().DataRow);
                }
                _uiController.RemoveProductos(aux);

                gridProductos.SetDataBinding( null,null);
                gridProductos.SetDataBinding( _uiController.Productos,null);
            }
            */
        }

        private void ubtCopiarCodigoSecundario_Click(object sender, EventArgs e)
        {
            if (txtCodigoSecundario.Text != string.Empty)
            {
                _uiController.CopiarCodigoSecundario(txtCodigoSecundario.Text);
                gridProductos.SetDataBinding(null, null);
                gridProductos.SetDataBinding(_uiController.Productos, null);
            }
        }

        private void chkLista_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue.Equals(System.Windows.Forms.CheckState.Checked))
                hierarchicalSearchControl1.SetCheckedKey(Convert.ToString(chkLista.Items[e.Index]), true);
            if (e.NewValue.Equals(System.Windows.Forms.CheckState.Unchecked))
                hierarchicalSearchControl1.SetCheckedKey(Convert.ToString(chkLista.Items[e.Index]), false);

        }

        private void gridProductos_Error(object sender, Janus.Windows.GridEX.ErrorEventArgs e)
        {
            e.DisplayErrorMessage = false;
        }

        string FileDialogFilter = "Todos los archivos de imagen (*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.ico; *.emf; *.wmf)|*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.ico; *.emf; *.wmf";
        private void btnFileChooserThumb_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = FileDialogFilter;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxThumb.Image = Image.FromFile(openFileDialog1.FileName);
                chkThumb.Checked = true;
            }
        }

        private void btnFileChooserImagen_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = FileDialogFilter;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImagen.Image = Image.FromFile(openFileDialog1.FileName);
                chkImagen1.Checked = true;
            }
        }

        private void txtCampoAuxiliar2_TextChanged(object sender, System.EventArgs e)
        {

        }


        private void On_PrecioNetoChanged(object sender, EventArgs e)
        {
            tsh_ProductosEx.ControladorProductos producto = (tsh_ProductosEx.ControladorProductos)sender;
            if (_uiController.ListaDePrecios != null)
            {
                int index = gridListaDePrecios.SelectedItems[0].Position;
                _uiController.ListaDePrecios.UpdatePrecios(producto.PrecioCosto, producto.Margen, producto.PrecioNeto);
                gridListaDePrecios.SetDataBinding(null, null);
                gridListaDePrecios.SetDataBinding(_uiController.ListaDePrecios.Items, null);
                gridListaDePrecios.Row = index;
                this.RefreshControls();
            }
        }

        private void gridListaDePrecios_SelectionChanged(object sender, EventArgs e)
        {
            if (gridListaDePrecios.SelectedItems.Count > 0)
            {

                ListaDePreciosItem item = (ListaDePreciosItem)gridListaDePrecios.SelectedItems[0].GetRow().DataRow;
                uneCoeficiente.Value = item.CoeficienteProducto;
                uneCoeficienteMonedaReferencia.Value = item.CoeficienteProductoMonedaReferencia;
                uneMaxDescuentoPorcentualLP.Value = item.PorcentajeMaximoDescuento;
                uneMaxDescuentoLP.Value = item.MaxDescuento;
                unePrecioVentaBrutoLP.Value = item.PrecioDeVentaBruto;
                unePrecioDeListaConImpuestoLP.Value = item.PrecioDeVentaBrutoConImpuestos;
                unePrecioFinalMonedaReferenciaLP.Value = item.PrecioDeVentaBrutoConImpuestosMonedaReferencia;
                //Sabrina: Tarea 1067. 20110311
                if (mzComboListaDePrecios.Value != item.IdListaDePrecios)
                    mzComboListaDePrecios.Value = item.IdListaDePrecios;
                //Fin Sabrina: Tarea 1067. 20110311
                this.RefreshControls();
            }
        }

        private void uneCoeficiente_Leave(object sender, EventArgs e)
        {
            if (!_uiController.isValid())
                MessageBox.Show("El precio de Lista del producto es inferior a su precio de venta neto.", "Advertencia", System.Windows.Forms.MessageBoxButtons.OK);
        }

        //German 20101025 - Tarea 880
        private void unePrecioDeListaConImpuestoLP_Leave(object sender, EventArgs e)
        {

            if (gridListaDePrecios.SelectedItems.Count > 0)
            {
                decimal PrecioVentaBrutoConImpuestoNew = Convert.ToDecimal(unePrecioDeListaConImpuestoLP.Value);
                ListaDePreciosItem item = (ListaDePreciosItem)gridListaDePrecios.SelectedItems[0].GetRow().DataRow;
                if (item.PrecioDeVentaBrutoConImpuestos != PrecioVentaBrutoConImpuestoNew)
                {
                    item.PrecioDeVentaBrutoConImpuestos = PrecioVentaBrutoConImpuestoNew;
                    decimal coeficienteNew = item.GetCoeficienteFromPrecioVentaBrutoConImp(PrecioVentaBrutoConImpuestoNew);
                    uneCoeficiente.Value = coeficienteNew;
                    //Sabrina: Tarea 1067. 20110311
                    _uiController.RecalcularDescuentosCombo(item.IdListaDePrecios, item.PrecioDeVentaBruto);
                    //Fin Sabrina: Tarea 1067. 20110311
                    if (!_uiController.isValid())
                        MessageBox.Show("El precio de Lista del producto es inferior a su precio de venta neto.", "Advertencia", System.Windows.Forms.MessageBoxButtons.OK);
                }
            }

        }

        private void unePrecioFinalMonedaReferenciaLP_Leave(object sender, EventArgs e)
        {

            if (gridListaDePrecios.SelectedItems.Count > 0)
            {
                decimal PrecioFinalMonedaReferenciaNew = Convert.ToDecimal(unePrecioFinalMonedaReferenciaLP.Value);
                ListaDePreciosItem item = (ListaDePreciosItem)gridListaDePrecios.SelectedItems[0].GetRow().DataRow;
                if (item.PrecioDeVentaBrutoConImpuestosMonedaReferencia != PrecioFinalMonedaReferenciaNew)
                {
                    item.PrecioDeVentaBrutoConImpuestosMonedaReferencia = PrecioFinalMonedaReferenciaNew;
                    decimal coeficienteNew = item.GetCoeficienteFromPrecioVentaBrutoConImpMonedaRef(PrecioFinalMonedaReferenciaNew);
                    uneCoeficiente.Value = coeficienteNew;
                    //Sabrina: Tarea 1067. 20110311
                    _uiController.RecalcularDescuentosCombo(item.IdListaDePrecios, item.PrecioDeVentaBruto);
                    //Fin Sabrina: Tarea 1067. 20110311
                    if (!_uiController.isValid())
                        MessageBox.Show("El precio de Lista del producto es inferior a su precio de venta neto.", "Advertencia", System.Windows.Forms.MessageBoxButtons.OK);
                }
            }

        }

        private void unePrecioVentaBrutoLP_Leave(object sender, EventArgs e)
        {
            if (gridListaDePrecios.SelectedItems.Count > 0)
            {
                decimal PrecioVentaBrutoNew = Convert.ToDecimal(unePrecioVentaBrutoLP.Value);
                ListaDePreciosItem item = (ListaDePreciosItem)gridListaDePrecios.SelectedItems[0].GetRow().DataRow;
                if (item.PrecioDeVentaBruto != PrecioVentaBrutoNew)
                {
                    item.PrecioDeVentaBruto = PrecioVentaBrutoNew;
                    decimal coeficienteNew = item.GetCoeficienteFromPrecioVentaBruto(PrecioVentaBrutoNew);
                    uneCoeficiente.Value = coeficienteNew;
                    //Sabrina: Tarea 1067. 20110311
                    _uiController.RecalcularDescuentosCombo(item.IdListaDePrecios, item.PrecioDeVentaBruto);
                    //Fin Sabrina: Tarea 1067. 20110311
                    if (!_uiController.isValid())
                        MessageBox.Show("El precio de Lista del producto es inferior a su precio de venta neto.", "Advertencia", System.Windows.Forms.MessageBoxButtons.OK);

                }
            }

        }

        //Fin German 20101025 - Tarea 880



        private void uneCoeficiente_ValueChanged(object sender, EventArgs e)
        {
            if (gridListaDePrecios.SelectedItems.Count > 0)
            {
                decimal coeficienteNew = Convert.ToDecimal(uneCoeficiente.Value);
                ListaDePreciosItem item = (ListaDePreciosItem)gridListaDePrecios.SelectedItems[0].GetRow().DataRow;
                if (item.CoeficienteProducto != coeficienteNew)
                {
                    int index = gridListaDePrecios.SelectedItems[0].Position;
                    _uiController.ListaDePrecios.UpdateCoeficiente(item, coeficienteNew);
                    gridListaDePrecios.SetDataBinding(null, null);
                    gridListaDePrecios.SetDataBinding(_uiController.ListaDePrecios.Items, null);
                    gridListaDePrecios.Row = index;
                    uneCoeficienteMonedaReferencia.Value = ((ListaDePreciosItem)_uiController.ListaDePrecios.Items[index]).CoeficienteProductoMonedaReferencia;
                    this.RefreshControls();
                    if (item.IsDefault)
                        _uiController.PrecioLista = item.PrecioDeVentaBruto;
                    //Sabrina: Tarea 1067. 20110311
                    _uiController.RecalcularDescuentosCombo(item.IdListaDePrecios, item.PrecioDeVentaBruto);
                    //Fin Sabrina: Tarea 1067. 20110311

                }
            }

        }


        private void uneCoeficienteMonedaReferencia_ValueChanged(object sender, EventArgs e)
        {
            if (gridListaDePrecios.SelectedItems.Count > 0)
            {
                decimal coeficienteMRNew = Convert.ToDecimal(uneCoeficienteMonedaReferencia.Value);
                ListaDePreciosItem item = (ListaDePreciosItem)gridListaDePrecios.SelectedItems[0].GetRow().DataRow;
                if (item.CoeficienteProductoMonedaReferencia != coeficienteMRNew)
                {
                    decimal coeficienteNew = item.GetCoeficienteFromCoeficienteMonedaRef(coeficienteMRNew);
                    uneCoeficiente.Value = coeficienteNew;
                    //Sabrina: Tarea 1067. 20110311
                    _uiController.RecalcularDescuentosCombo(item.IdListaDePrecios, item.PrecioDeVentaBruto);
                    //Fin Sabrina: Tarea 1067. 20110311
                }
            }

        }

        private void btnRestablecerAGral_Click(object sender, System.EventArgs e)
        {
            if (gridListaDePrecios.SelectedItems.Count > 0)
            {
                ListaDePreciosItem item = (ListaDePreciosItem)gridListaDePrecios.SelectedItems[0].GetRow().DataRow;
                if (item.CoeficienteProducto != item.CoeficienteGral)
                {
                    int index = gridListaDePrecios.SelectedItems[0].Position;
                    _uiController.ListaDePrecios.UpdateCoeficienteToGral(item);
                    gridListaDePrecios.SetDataBinding(null, null);
                    gridListaDePrecios.SetDataBinding(_uiController.ListaDePrecios.Items, null);
                    gridListaDePrecios.Row = index;
                    this.RefreshControls();
                    if (item.IsDefault)
                        _uiController.PrecioLista = item.PrecioDeVentaBruto;
                    //Sabrina: Tarea 1067. 20110311
                    _uiController.RecalcularDescuentosCombo(item.IdListaDePrecios, item.PrecioDeVentaBruto);
                    //Fin Sabrina: Tarea 1067. 20110311
                }
            }
        }

        private void On_SimboloMonedaPrecioDeCostoReferenciaChanged(object sender, EventArgs e)
        {
            labelSimboloMonedaPrecioDeCostoReferencia.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
            labelSimboloMonedaPrecioDeCostoReferenciaLP.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
            labelSimboloMonedaPrecioDeCosto3.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
            labelSimboloMonedaPrecioDeCosto4.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
            labelSimboloMonedaPrecioDeCosto6.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
            labelSimboloMonedaPrecioDeCostoReposicion.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
            labelSimboloMonedaPrecioDeCostoReposicion1.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;

            // Moneda de Precio de Costo referencia.
            if (!ultraCoeficiente1.Text.Equals(string.Empty))
                labelSimboloMonedaCoeficiente1.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
            if (!ultraCoeficiente2.Text.Equals(string.Empty))
                labelSimboloMonedaCoeficiente2.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
            if (!ultraCoeficiente3.Text.Equals(string.Empty))
                labelSimboloMonedaCoeficiente3.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
            if (!ultraCoeficiente4.Text.Equals(string.Empty))
                labelSimboloMonedaCoeficiente4.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
            if (!ultraCoeficiente5.Text.Equals(string.Empty))
                labelSimboloMonedaCoeficiente5.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
            if (!ultraCoeficiente6.Text.Equals(string.Empty))
                labelSimboloMonedaCoeficiente6.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
            if (!ultraCoeficiente7.Text.Equals(string.Empty))
                labelSimboloMonedaCoeficiente7.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
            if (!ultraCoeficiente8.Text.Equals(string.Empty))
                labelSimboloMonedaCoeficiente8.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
            if (!ultraCoeficiente9.Text.Equals(string.Empty))
                labelSimboloMonedaCoeficiente9.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
            if (!ultraCoeficiente10.Text.Equals(string.Empty))
                labelSimboloMonedaCoeficiente10.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;


        }

        private void On_SimboloMonedaPrecioDeListaChanged(object sender, EventArgs e)
        {
            if (_uiController.ListaDePrecios != null)
            {
                decimal ValorCotizacionPrecioDeVentaNew = (decimal)sender;
                _uiController.ListaDePrecios.UpdateValorCotizacionPrecioDeVenta(ValorCotizacionPrecioDeVentaNew);
            }
            labelSimboloMonedaPrecioDeVentaNeto.Text = _uiController.SimboloMonedaPrecioDeVentaNeto;
            labelSimboloMonedaDescuentoMaximo.Text = _uiController.SimboloMonedaDescuentoMaximo;
            labelSimboloMonedaPrecioDeLista.Text = _uiController.SimboloMonedaPrecioDeLista;
            labelSimboloMonedaPrecioDeListaConImpuestos.Text = _uiController.SimboloMonedaPrecioDeLista;

            labelSimboloMonedaPrecioDeVentaNetoLP.Text = _uiController.SimboloMonedaPrecioDeVentaNeto;
            labelSimboloMonedaDescuentoMaximoLP.Text = _uiController.SimboloMonedaDescuentoMaximo;
            labelSimboloMonedaPrecioDeListaLP.Text = _uiController.SimboloMonedaPrecioDeLista;
            labelSimboloMonedaPrecioDeListaConImpuestosLP.Text = _uiController.SimboloMonedaPrecioDeLista;
        }

        private void unePrecioVentaBrutoLP_ValueChanged(object sender, EventArgs e)
        {
            if (gridListaDePrecios.SelectedItems.Count > 0)
            {
                decimal PrecioVentaBrutoNew = Convert.ToDecimal(unePrecioVentaBrutoLP.Value);
                ListaDePreciosItem item = (ListaDePreciosItem)gridListaDePrecios.SelectedItems[0].GetRow().DataRow;
                if (item.PrecioDeVentaBruto != PrecioVentaBrutoNew)
                {
                    decimal coeficienteNew = item.GetCoeficienteFromPrecioVentaBruto(PrecioVentaBrutoNew);
                    uneCoeficiente.Value = coeficienteNew;
                }
            }

        }

        private void unePrecioDeListaConImpuestoLP_ValueChanged(object sender, EventArgs e)
        {
            if (gridListaDePrecios.SelectedItems.Count > 0)
            {
                decimal PrecioVentaBrutoConImpuestoNew = Convert.ToDecimal(unePrecioDeListaConImpuestoLP.Value);
                ListaDePreciosItem item = (ListaDePreciosItem)gridListaDePrecios.SelectedItems[0].GetRow().DataRow;
                if (item.PrecioDeVentaBrutoConImpuestos != PrecioVentaBrutoConImpuestoNew)
                {
                    decimal coeficienteNew = item.GetCoeficienteFromPrecioVentaBrutoConImp(PrecioVentaBrutoConImpuestoNew);
                    uneCoeficiente.Value = coeficienteNew;
                }
            }
        }

        private void unePrecioFinalMonedaReferenciaLP_ValueChanged(object sender, EventArgs e)
        {
            if (gridListaDePrecios.SelectedItems.Count > 0)
            {
                decimal PrecioFinalMonedaReferenciaNew = Convert.ToDecimal(unePrecioFinalMonedaReferenciaLP.Value);
                ListaDePreciosItem item = (ListaDePreciosItem)gridListaDePrecios.SelectedItems[0].GetRow().DataRow;
                if (item.PrecioDeVentaBrutoConImpuestosMonedaReferencia != PrecioFinalMonedaReferenciaNew)
                {
                    decimal coeficienteNew = item.GetCoeficienteFromPrecioVentaBrutoConImpMonedaRef(PrecioFinalMonedaReferenciaNew);
                    uneCoeficiente.Value = coeficienteNew;
                }
            }
        }

        private void RefreshControls()
        {
            if (decimal.Round(Convert.ToDecimal(uneCoeficiente.Value), 4) < 0)
                uneCoeficiente.Appearance.ForeColor = Color.Red;
            else uneCoeficiente.Appearance.ForeColor = Color.Black;
            if (decimal.Round(Convert.ToDecimal(uneCoeficienteMonedaReferencia.Value), 4) < 0)
                uneCoeficienteMonedaReferencia.Appearance.ForeColor = Color.Red;
            else uneCoeficienteMonedaReferencia.Appearance.ForeColor = Color.Black;
            if (decimal.Round(Convert.ToDecimal(uneMaxDescuentoLP.Value), 4) < 0)
                uneMaxDescuentoLP.Appearance.ForeColor = Color.Red;
            else uneMaxDescuentoLP.Appearance.ForeColor = Color.Black;
            if (decimal.Round(Convert.ToDecimal(uneMaxDescuentoPorcentualLP.Value), 4) < 0)
                uneMaxDescuentoPorcentualLP.Appearance.ForeColor = Color.Red;
            else uneMaxDescuentoPorcentualLP.Appearance.ForeColor = Color.Black;

            if (decimal.Round(Convert.ToDecimal(unePrecioVentaBrutoLP.Value), 4) < decimal.Round(Convert.ToDecimal(unePrecioDeVentaNetoLP.Value), 4))
                unePrecioVentaBrutoLP.Appearance.ForeColor = Color.Red;
            else unePrecioVentaBrutoLP.Appearance.ForeColor = Color.Black;

        }

        protected override void SaveChanges()
        {
            //German 20100428 - Tarea 742
            /*
            if(!_uiController.ValidarMacNegativoError && _uiController.ValidarMacNegativoAdvertencia && ((decimal)uneMAC.Value) < 0)
            {
                if(MessageBox.Show("El Margen/Precio Costo Neto es inferior a 0. Desea Continuar de todas formas??", "Confirmar cambios",System.Windows.Forms.MessageBoxButtons.OKCancel).Equals(System.Windows.Forms.DialogResult.OK))
                    base.SaveChanges();
					
            }else
                base.SaveChanges();
            */
            bool AdvierteMacNegativo = !_uiController.ValidarMacNegativoError && _uiController.ValidarMacNegativoAdvertencia && ((decimal)uneMAC.Value) < 0;
            bool AdviertePPPMenorIgualACero = !_uiController.ValidarPPPMenorIgualACeroError && _uiController.ValidarPPPMenorIgualACeroAdvertencia && (_uiController.PrecioDeCostoPromedioPonderado) <= 0 && _state.ToUpper().Equals("NEW");
            bool Save = true;
            if (AdvierteMacNegativo)
                if (MessageBox.Show("El Margen/Precio Costo Neto es inferior a 0. Desea Continuar de todas formas??", "Confirmar cambios", System.Windows.Forms.MessageBoxButtons.OKCancel).Equals(System.Windows.Forms.DialogResult.Cancel))
                    Save = false;
            if (AdviertePPPMenorIgualACero && Save)
                if (MessageBox.Show("El Precio de Costo Promedio Ponderado debe ser mayor a 0. Desea Continuar de todas formas??", "Confirmar cambios", System.Windows.Forms.MessageBoxButtons.OKCancel).Equals(System.Windows.Forms.DialogResult.Cancel))
                    Save = false;
            //Sabrina: Tarea 1068. 20110317
            if (Save)
            {
                if (_uiController.State.Equals("EDIT"))
                {
                    bool cambioCosto = _uiController.CambioCostoProductosCombo();
                    bool cambioPcioVenta = _uiController.CambioPrecioVentaProductosCombo();
                    bool cambioMoneda = _uiController.CambioMonedaProductosCombo();
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
                    else if (cambioMoneda)
                    {
                        if (MessageBox.Show("La moneda de este producto cambio. Desea actualizar los combos que lo referencian??", "Confirmar cambios", System.Windows.Forms.MessageBoxButtons.YesNo).Equals(System.Windows.Forms.DialogResult.Yes))
                            _uiController.ActualizaPreciosProductosCombo = true;
                    }
                }
                base.SaveChanges();
            }
            //Fin Sabrina: Tarea 1068. 20110317
            //Fin German 20100428 - Tarea 742

        }

        //Cristian Tarea 0000243 20111230
        protected override void LoadPrecios()
        {
            String codigoNuevo = String.Empty;
            String idNuevo = String.Empty;
            this.SaveChanges();
            if (! this.HasErrors)
            {
                Hashtable parameters = new Hashtable();
                 parameters.Add("Estado", "NEW");
                 parameters.Add("cadigoSeacundario", _uiController.CodigoSecundario);

                 if(State.Equals("NEW")){
                   // String p1 = (String) _data.Tables[0].Rows["IdProducto"].ToString();
                     mz.erp.commontypes.data.tsh_ProductosExDataset data = (mz.erp.commontypes.data.tsh_ProductosExDataset)_data;
                     System.Data.DataTable tableProductos = data.Tables["tsh_Productos"];
                     System.Data.DataRow _row = tableProductos.Rows[0];
                     idNuevo = _row["IdProducto"].ToString();
                     parameters.Add("Producto", _uiController.Codigo);
                     parameters.Add("IdProducto", idNuevo);

                 }else{
                     
                       parameters.Add("Producto", _uiController.Codigo);
                       parameters.Add("IdProducto", _uiController.Idproducto);
                }
                ProcessLoader.CallProcess("ProcesoModificarPrecioProducto", parameters);
            }
        }
        //Firn Cristian Tarea 0000243

        private void txtCodigoSecundario10_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void ultraExplorerBar1_ItemClick(object sender, Infragistics.Win.UltraWinExplorerBar.ItemEventArgs e)
        {

        }

        // Matias - 20081006 - Tarea 28
        private void gridProductos_DeletingRecords(object sender, CancelEventArgs e)
        {
            //gridProductos.SelectionChanged -=new EventHandler(gridProductos_SelectionChanged);
            if (gridProductos.SelectedItems.Count > 0)
            {
                ArrayList aux = new ArrayList();
                foreach (Janus.Windows.GridEX.GridEXSelectedItem item in gridProductos.SelectedItems)
                {
                    aux.Add(item.GetRow().DataRow);
                }
                _uiController.ListaDeProductosSeleccionadoABorrar(aux);
            }
        }

        private void gridProductos_RecordsDeleted(object sender, EventArgs e)
        {
            _uiController.EliminarListaDeProductosSeleccionado();
            if (gridProductos.RecordCount > 0)
            {
                gridProductos.SetDataBinding(null, null);
                gridProductos.SetDataBinding(_uiController.Productos, null);
            }
        }


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
            if (chkCoef1.Checked)
            {
                _uiController.ActivarCostoIndirecto(1, true);
                uneCoeficiente1.Enabled = true;
                if (!_uiController.CostoIndirectoTipo1)//CostoIndirecto de tipo Porcentaje
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
            if (chkCoef2.Checked)
            {
                _uiController.ActivarCostoIndirecto(2, true);
                uneCoeficiente2.Enabled = true;
                if (!_uiController.CostoIndirectoTipo2)
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
            if (chkCoef3.Checked)
            {
                _uiController.ActivarCostoIndirecto(3, true);
                uneCoeficiente3.Enabled = true;
                if (!_uiController.CostoIndirectoTipo3)
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
            if (chkCoef4.Checked)
            {
                _uiController.ActivarCostoIndirecto(4, true);
                uneCoeficiente4.Enabled = true;
                if (!_uiController.CostoIndirectoTipo4)
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
            if (chkCoef5.Checked)
            {
                _uiController.ActivarCostoIndirecto(5, true);
                uneCoeficiente5.Enabled = true;
                if (!_uiController.CostoIndirectoTipo5)
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
            if (chkCoef6.Checked)
            {
                _uiController.ActivarCostoIndirecto(6, true);
                uneCoeficiente6.Enabled = true;
                if (!_uiController.CostoIndirectoTipo6)
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
            if (chkCoef7.Checked)
            {
                _uiController.ActivarCostoIndirecto(7, true);
                uneCoeficiente7.Enabled = true;
                if (!_uiController.CostoIndirectoTipo7)
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
            if (chkCoef8.Checked)
            {
                _uiController.ActivarCostoIndirecto(8, true);
                uneCoeficiente8.Enabled = true;
                if (!_uiController.CostoIndirectoTipo8)
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
            if (chkCoef9.Checked)
            {
                _uiController.ActivarCostoIndirecto(9, true);
                uneCoeficiente9.Enabled = true;
                if (!_uiController.CostoIndirectoTipo9)
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
            if (chkCoef10.Checked)
            {
                _uiController.ActivarCostoIndirecto(10, true);
                uneCoeficiente10.Enabled = true;
                if (!_uiController.CostoIndirectoTipo10)
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
            if (!_uiController.PrecioDeVentaAfectaMac)
            {
                _uiController.PrecioDeVentaBruto = (decimal)unePrecioDeVentaNeto.Value;
                unePrecioVentaBruto.Value = unePrecioDeVentaNeto.Value;
            }
        }

        private void mzCEResponsableIngreso_Change(object sender, EventArgs e)
        {
            if (_uiController.AskForPasswordResponsableIngreso)
            {
                ShowPassword();
            }
        }

        private void ShowPassword()
        {
            string IdPersona = Convert.ToString(mzCEResponsableIngreso.Value);
            if (IdPersona != _uiController.UltimoResponsableClaveCorrecta)
            {
                string password = InputBox.ShowInputBoxPassword("Ingrese la contraseña:", "Cambio de responsable asociado al nuevo ingreso");
                bool ClaveCorrecta = false;
                if (IdPersona != null && !IdPersona.Equals(string.Empty))
                {
                    ClaveCorrecta = businessrules.Security.LogInXPersona(IdPersona, password);
                    if (!ClaveCorrecta)
                        MessageBox.Show("¡Clave incorrecta!", "Cambio de responsable de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        _uiController.UltimoResponsableClaveCorrecta = IdPersona;
                }
                if (!ClaveCorrecta)
                {
                    this.mzCEResponsableIngreso.Value = string.Empty;
                    _uiController.ResponsableIngreso = string.Empty;
                }
            }
        }

        private void ubVerificar_Click(object sender, EventArgs e)
        {
            //German 20100426
            if (_state.ToUpper().Equals("NEW") || (_state.ToUpper().Equals("EDIT") && ComprobantesRules.Producto_PermiteModificarCodigoManual))
            //Fin German 20100426
            {
                if (!_uiController.ValidarCodigo(txtCodigo.Text))
                {
                    MessageBox.Show("El Código ingresado ya existe", "Código Existente", System.Windows.Forms.MessageBoxButtons.OK);
                    txtCodigo.Text = string.Empty;
                }
                else
                    if (txtCodigo.Text != null && txtCodigo.Text != string.Empty)
                        MessageBox.Show("El Código es Válido", "Código", System.Windows.Forms.MessageBoxButtons.OK);
            }
        }
    }
}





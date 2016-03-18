
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
	/// Descripción breve de FrmIngresarPrecioProducto.
	/// </summary>
	public class FrmIngresarPrecioProducto : System.Windows.Forms.Form, ITaskForm, ISearchObjectListener
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar;
		private Infragistics.Win.Misc.UltraLabel ultraLabel2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Label labelTarea;
		private mz.erp.ui.controls.mzComboEditor mzCEMonedaProveedor;
		private System.Windows.Forms.GroupBox groupDatosProveedor;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeCostoMonedaProveedor;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel3;
		private mz.erp.ui.controls.mzComboEditor mzCEFuenteDeCambioProveedor;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneValorCotizacionProveedor;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private Infragistics.Win.Misc.UltraLabel ultraLabel5;
		private System.Windows.Forms.GroupBox groupMZ;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor ultraNumericEditor2;
		private Infragistics.Win.Misc.UltraLabel ultraLabel11;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneStock;
		private Infragistics.Win.Misc.UltraLabel ultraLabel10;
		private Infragistics.Win.Misc.UltraLabel ultraLabel12;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePCostoPromedioPonderado;
		private System.Windows.Forms.Label label9;
		private mz.erp.ui.controls.mzComboEditor mzCEMonedaReferencia;
		private System.Windows.Forms.Label labelSimboloMonedaProveedor;
		private System.Windows.Forms.Label labelSimboloMonedaReferencia;
		private System.Windows.Forms.Label labelSimboloMonedaOrigen;
		private Infragistics.Win.Misc.UltraLabel ultraLabel14;
		private Janus.Windows.GridEX.GridEX gridProductos;
		private mz.erp.ui.controls.mzComboEditor mzCEFuenteDeCambioProducto;
		private Infragistics.Win.Misc.UltraLabel ultraLabel6;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeCostoMonedaProducto;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeCostoAnteriorMonedaProducto;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioCostoMonedaReferencia;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioPPCostoAnteriorMonedaProducto;
		private System.Windows.Forms.Label labeSimbololMonedaPrecioDeCosto;
		private System.Windows.Forms.Label labelSimboloMonedaPrecioDeCosto3;
		private System.Windows.Forms.Label labelSimboloMonedaPrecioDeCosto1;
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
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl containerProductos;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl containerDatosCompra;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl containerDatosVenta;
		//private mzProductosControl mzProductosControl;
		private System.Windows.Forms.Label labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia;
		private System.Windows.Forms.Label label3;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeListaConImpuestoMonedaReferencia;
		private mz.erp.ui.controls.mzProductosControl mzProductosControl;
		private Infragistics.Win.Misc.UltraButton bNingunoCaja;
		private Infragistics.Win.Misc.UltraButton bTodosCaja;
		private System.Windows.Forms.RadioButton rbSeleccionMultiple;
		private System.Windows.Forms.RadioButton rbSeleccionSimple;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private mz.erp.ui.controls.GridManagerView gridManagerView2;
		
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.Label label25;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeCostoRefLP;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label22;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneMACLP;
		private System.Windows.Forms.Label label23;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeVentaNetoLP;
		
		private Janus.Windows.GridEX.GridEX gridListaDePrecios;
		private System.Windows.Forms.Label labelSimboloMonedaPrecioDeCostoReferenciaLP;
		private System.Windows.Forms.Label labelSimboloMonedaPrecioDeVentaNetoLP;
		private System.Windows.Forms.GroupBox groupBox1;
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
		private System.Windows.Forms.GroupBox panel1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private Infragistics.Win.Misc.UltraLabel ultraLabel17;
		private Infragistics.Win.Misc.UltraLabel ultraLabel18;
		private Infragistics.Win.Misc.UltraLabel ultraLabel19;
		private Infragistics.Win.Misc.UltraLabel ultraLabel20;
		private Infragistics.Win.Misc.UltraLabel ultraLabel21;
		private System.Windows.Forms.Label lbSimbololMonedaPrecioDeCostoProveedor;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeCostoProveedor;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCotizacionPrecioDeCostoProveedor;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label17;
		private Infragistics.Win.Misc.UltraLabel ultraLabel22;
		private Infragistics.Win.Misc.UltraLabel ultraLabel23;
		private Infragistics.Win.Misc.UltraLabel ultraLabel24;
		private System.Windows.Forms.Label label20;
		private Infragistics.Win.Misc.UltraLabel ultraLabel25;
		private Infragistics.Win.Misc.UltraLabel ultraLabel26;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label lblSimboloMonedaBonificacion5;
		private System.Windows.Forms.Label lblSimboloMonedaBonificacion4;
		private System.Windows.Forms.Label lblSimboloMonedaBonificacion3;
		private System.Windows.Forms.Label lblSimboloMonedaBonificacion2;
		private System.Windows.Forms.Label lblSimboloMonedaBonificacion1;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneBonificacion5;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneBonificacion4;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneBonificacion3;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneBonificacion2;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneBonificacion1;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePorcBonificacion5;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePorcBonificacion4;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePorcBonificacion3;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePorcBonificacion2;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePorcBonificacion1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel27;
		private System.Windows.Forms.Label lbSimbololMonedaPrecioDeCostoFinalProveedor;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeCostoFinalProveedor;
		private mz.erp.ui.controls.mzComboEditor mzCEMonedaPrecioDeCostoProv;
		private mz.erp.ui.controls.mzComboEditor mzCEFuenteDeCambioPrecioDeCostoProv;
		private Infragistics.Win.Misc.UltraButton utbTrasladarPrecioDeCostoFinal;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private mz.erp.ui.controls.GridManagerView gridManagerView3;
		private Janus.Windows.GridEX.GridEX gridListaDePreciosProveedores;
		private Infragistics.Win.Misc.UltraButton btnEliminarListaDePreciosProv;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficientePrecioCostoListaProveedor;
		private Infragistics.Win.Misc.UltraButton utbAolicaCoeficienteSobrePrecioCostoListaProveedor;
		private System.Windows.Forms.Label label1;
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
		private System.Windows.Forms.CheckBox chkCoef1;
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
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficientePorc1;
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
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCoeficiente1;
		private System.Windows.Forms.Label labelPorc1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel9;
		private Infragistics.Win.Misc.UltraLabel ultraCoeficiente2;
		private Infragistics.Win.Misc.UltraLabel ultraCoeficiente1;
		private System.Windows.Forms.Label labelPorc2;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkUsaPrecioDeCostoReposicion;
		private System.Windows.Forms.Label labelSimboloMonedaPrecioDeCostoReposicion;
		private System.Windows.Forms.Label label63;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeCostoReposicion;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label5;
		private Infragistics.Win.Misc.UltraLabel ultraLabel7;
		private System.Windows.Forms.GroupBox groupBox6;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkUsaPrecioDeCostoReposicion1;
		private System.Windows.Forms.Label labelSimboloMonedaPrecioDeCostoReposicion1;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeCostoReposicion1;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePCostoPromedioPonderado1;
		private System.Windows.Forms.Label labelSimboloMonedaPrecioDeCosto4;
		private System.Windows.Forms.CheckBox chckBonificacionesAcumulativas;
		private System.Windows.Forms.CheckBox chckActualizaPcioCostoReposicion;
		private mz.erp.ui.controls.mzProveedoresControl mzCmbProveedor;
        private ToolBarButton tbbSeparator3;
        private ToolBarButton tbbEliminarListaDePrecio;
        private TextBox txtCodigoProductoProveedor;
        private Infragistics.Win.Misc.UltraLabel ultraLabel8;
		private System.ComponentModel.IContainer components;

		
		#region Construtores

		/*
		public FrmIngresarPrecioProducto( string codigoProducto)
		{
			
			InitializeComponent();
			_uiController = new IngresarPrecioProductoController(codigoProducto);
			Build_UI();

		}
		*/

		public FrmIngresarPrecioProducto(IngresarPrecioProductoController uiController)
		{
			InitializeComponent();
			_uiController = uiController;
		}


		#endregion

		#region Variables Privadas

			private IngresarPrecioProductoController _uiController;
			private int _selectedIndex = 0;
		    private bool _cambiarProvDefaultEnGrilla = true;
		    private bool _consultarSiModificaElPCReposicion = true;


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

            //German 20110309 -  Tarea 0000058
			//if(_uiController.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia") || _uiController.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior"))
            if (_uiController.EsProcesoDeConfirmacionDePrecios(_uiController.ProcessName))
            //Fin German 20110309 -  Tarea 0000058
            //German 20101215 - Tarea 992
            {
                _uiController_PrecioDeCostoMonedaProveedorChanged(this, EventArgs.Empty);
                _uiController.PrecioDeCostoMonedaProveedorChanged += new EventHandler(_uiController_PrecioDeCostoMonedaProveedorChanged);
            }
            //Fin German 20101215 - Tarea 992

			
		}

		
		private void ConfigureInterface()
		{
			
			this.Text = _uiController.LeyendaFormulario;
			labelTarea.Text = _uiController.LeyendaFormulario;
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			mzCEMonedaReferencia.ReadOnly = true;
			uneValorCotizacionProveedor.ReadOnly = true;
			mzCEMonedaProveedor.ReadOnly = true;
			mzCEFuenteDeCambioProveedor.ReadOnly = true;
			uneStock.ReadOnly = true;
			
			mzProductosControl.Enabled = _uiController.EnableBuscadorProducto;
			mzProductosControl.SetProcess(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), "V");
			this.mzProductosControl.EnabledCantidad = !_uiController.AllowCantidadAutomatica;
			this.mzProductosControl.ReadOnlyCantidad = _uiController.AllowCantidadAutomatica;
			
			unePrecioCostoMonedaReferencia.ReadOnly = true;
			unePrecioPPCostoAnteriorMonedaProducto.ReadOnly = true;
			//Sabrina: tarea 56
			unePCostoPromedioPonderado.ReadOnly = true;
			unePCostoPromedioPonderado1.ReadOnly = true;
			unePrecioDeVentaNeto.ReadOnly = true;
			uneMaxDescuento.ReadOnly = true;
			uneMaxDescuentoPorcentual.ReadOnly = true;
			//Aca se carga el layout esto ahora lo tendria q hacer el grid Vivi
			//gridProductos.LayoutData = _uiController.LayoutProductos;
			
			//Esto es lo nuevo Vivi
			// ---- Matias - 20090616
			gridProductos.GroupByBoxVisible = false;
			gridProductos.SelectionMode = Janus.Windows.GridEX.SelectionMode.SingleSelection;
			gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), gridProductos, this.Text, true);
			gridManagerView1.Visible = true;
			// ---- Fin Matias.
			//Sabrina: tarea 56
			unePCostoPromedioPonderado.ReadOnly = true;
			unePCostoPromedioPonderado1.ReadOnly = true;
			uneStock.FormatString = "n";
			uneMAC.FormatString = "n";
			uneMaxDescuento.FormatString = "n";
			uneMaxDescuentoPorcentual.FormatString = "n";

			uneMACLP.FormatString = "n";
			uneMaxDescuentoLP.FormatString = "n";
			uneMaxDescuentoPorcentualLP.FormatString = "n";
			uneCoeficiente.FormatString = "n";
			uneCoeficienteMonedaReferencia.FormatString = "n";


			labeSimbololMonedaPrecioDeCosto.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaPrecioDeCosto1.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaPrecioDeCosto3.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaPrecioDeCosto4.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaPrecioDeCosto6.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;			
			
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

			//labelCoeficiente1.Text = Convert.ToString(_uiController.Coeficiente1) + "%";
			//labelCoeficiente2.Text = Convert.ToString(_uiController.Coeficiente2) + "%";

			
			labelSimboloMonedaProveedor.Text = _uiController.SimboloMonedaProveedor;
			labelSimboloMonedaReferencia.Text  = _uiController.SimboloMonedaReferencia;
			labelSimboloMonedaOrigen.Text = _uiController.SimboloMonedaOrigen;
			labelSimboloMonedaDescuentoMaximo.Text = _uiController.SimboloMonedaDescuentoMaximo;
			labelSimboloMonedaPrecioDeCostoReferencia.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaPrecioDeLista.Text = _uiController.SimboloMonedaPrecioDeLista;
			labelSimboloMonedaPrecioDeVentaNeto.Text = _uiController.SimboloMonedaPrecioDeVentaNeto;
			labelSimboloMonedaPrecioDeListaConImpuestos.Text = _uiController.SimboloMonedaPrecioDeLista;
			labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia.Text = _uiController.SimboloMonedaReferencia;


			unePrecioDeCostoAnteriorMonedaProducto.ReadOnly = true;
			mzCEFuenteDeCambioProducto.ReadOnly = true;
			/**************************/
			unePrecioDeCostoMonedaProducto.Enabled = !_uiController.ReadOnlyPrecioDeCostoMonedaProducto && _uiController.PermiteModificarPrecioDeCostoPromedioPonderado;
			/**************************/
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
		
			uneCoeficienteTotal.ReadOnly = true;

			containerProductos.Visible = true;
			//ultraExplorerBar.Groups[2].Visible = _uiController.VisibleDatosCompra;
			//groupDatosProveedor.Visible = _uiController.VisibleDatosProveedor;
			if(!_uiController.VisibleDatosProveedor)
			{
				groupMZ.Dock = System.Windows.Forms.DockStyle.None;
				groupDatosProveedor.Dock = System.Windows.Forms.DockStyle.None;
				groupMZ.SetBounds(groupDatosProveedor.Location.X, groupDatosProveedor.Location.Y, groupMZ.Size.Width, groupMZ.Size.Height);
				//containerDatosCompra.SetBounds(containerDatosCompra.Location.X, containerDatosCompra.Location.Y, containerDatosCompra.Size.Width, containerDatosCompra.Size.Height - groupMZ.Size.Height + 15);
				//containerDatosCompra.SetBounds(containerDatosCompra.Location.X, containerDatosCompra.Location.Y, containerDatosCompra.Size.Width, containerDatosCompra.Size.Height - groupDatosProveedor.Size.Height + 15);
				containerDatosCompra.SetBounds(containerDatosCompra.Location.X, containerDatosCompra.Location.Y, containerDatosCompra.Size.Width, containerDatosCompra.Size.Height - groupDatosProveedor.Size.Height);
			}
			//ultraExplorerBar.Groups[3].Visible = _uiController.VisibleDatosVenta;
			/*if(_uiController.ListaDePreciosHabilitadas)
			{
				this.ultraExplorerBar.Groups["ListaDePrecios"].Visible = _uiController.VisibleDatosVenta;
				if (this.ultraExplorerBar.Groups["ListaDePrecios"].Container != null)
					this.ultraExplorerBar.Groups["ListaDePrecios"].Container.Enabled = _uiController.VisibleDatosVenta;
				this.ultraExplorerBar.Groups["Precios"].Visible = false;
				if (this.ultraExplorerBar.Groups["Precios"].Container != null)
					this.ultraExplorerBar.Groups["Precios"].Container.Enabled = false;
			}
			else
			{
				this.ultraExplorerBar.Groups["ListaDePrecios"].Visible = false;
				if (this.ultraExplorerBar.Groups["ListaDePrecios"].Container != null)
					this.ultraExplorerBar.Groups["ListaDePrecios"].Container.Enabled = false;
				this.ultraExplorerBar.Groups["Precios"].Visible = _uiController.VisibleDatosVenta;
				if (this.ultraExplorerBar.Groups["Precios"].Container != null)
					this.ultraExplorerBar.Groups["Precios"].Container.Enabled = _uiController.VisibleDatosVenta;
			}
            */

			
			if(_uiController.AllowRemoveItems)
				gridProductos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			else gridProductos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;

			rbSeleccionSimple.Checked = !_uiController.SeleccionMultiple;
			rbSeleccionMultiple.Checked = _uiController.SeleccionMultiple;
			bTodosCaja.Enabled = _uiController.SeleccionMultiple;
			bNingunoCaja.Enabled = _uiController.SeleccionMultiple;
			if(_uiController.AllowSeleccionMultiple)
			{
				if(!_uiController.SeleccionMultiple)
				{
					gridProductos.RootTable.Columns["Selected"].Visible = false;
				}
			}
			else
				gridProductos.RootTable.Columns["Selected"].Visible = false;
			
			panel1.Enabled = _uiController.AllowSeleccionMultiple;

			gridProductos.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			
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
			mzProductosControl.EnabledListaDePrecio = false;

			mzCEMonedaPrecioDeCostoProv.Enabled = false;
			mzCEFuenteDeCambioPrecioDeCostoProv.Enabled = false;
			uneCotizacionPrecioDeCostoProveedor.Enabled = false;
			unePrecioDeCostoFinalProveedor.Enabled = false;

			
			//this.ultraExplorerBar.Groups["ListaPrecioProveedor"].Enabled = _uiController.HabilitaContenedorPrecioListaProveedor;
			this.ultraExplorerBarContainerControl3.Enabled = _uiController.HabilitaContenedorPrecioListaProveedor;
			this.ultraExplorerBar.Groups["ListaPrecioProveedor"].Expanded = _uiController.HabilitaContenedorPrecioListaProveedor;

			utbTrasladarPrecioDeCostoFinal.Enabled = _uiController.HabilitaTrasladarPrecioDeListaFinal;
			gridManagerView3.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), gridListaDePreciosProveedores, this.Text);

			foreach( Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup group in this.ultraExplorerBar.Groups)
			{				
				group.Visible = false;
                group.Expanded = true;
				if (group.Container != null)
					group.Container.Enabled = false;
			}

			if(!_uiController.ContenedoresVisibles.Equals(string.Empty))
			{
				ArrayList cont = mz.erp.systemframework.Util.Parse(_uiController.ContenedoresVisibles, ",");
				foreach(string grupo in cont)
				{
					if(grupo.Equals("ListaPrecioProveedor") && !_uiController.UsaPrecioDeListaProveedor)
						this.ultraExplorerBar.Groups[grupo].Visible = false;
					else
						if(grupo.Equals("ListaDePrecios") && !_uiController.ListaDePreciosHabilitadas)
							this.ultraExplorerBar.Groups[grupo].Visible = false;
						else
							this.ultraExplorerBar.Groups[grupo].Visible = true;
				}
			}

			if(!_uiController.ContenedoresHabilitados.Equals(string.Empty))
			{								
				ArrayList cont = mz.erp.systemframework.Util.Parse(_uiController.ContenedoresHabilitados, ",");
				foreach(string grupo in cont)
				{
					if (this.ultraExplorerBar.Groups[grupo].Container != null)
						this.ultraExplorerBar.Groups[grupo].Container.Enabled = true;
				}
			}

			if(!_uiController.ContenedoresColapsados.Equals(string.Empty))
			{								
				ArrayList cont = mz.erp.systemframework.Util.Parse(_uiController.ContenedoresColapsados, ",");
				foreach(string grupo in cont)
				{
					if (this.ultraExplorerBar.Groups[grupo].Container != null)
						this.ultraExplorerBar.Groups[grupo].Expanded = false;
				}
			}

			unePrecioDeCostoMonedaProveedor.ReadOnly = !_uiController.AllowEditPrecioDeCostoMonedaProveedor;

			CargarCostosIndirectosDescripcion();
			
			if ( _uiController.HayProductoSeleccionado )
			{
                this.HabilitarCostosIndirectos();
			}
			else
				panelCostosIndirectos.Visible = false;

			//Sabrina: tarea 56
			labelSimboloMonedaPrecioDeCostoReposicion.Text =  _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaPrecioDeCostoReposicion1.Text =  _uiController.SimboloMonedaPrecioDeCostoReferencia;
			unePCostoPromedioPonderado.ReadOnly = !_uiController.PermiteModificarPrecioDeCostoPromedioPonderado;
			unePCostoPromedioPonderado1.ReadOnly = !_uiController.PermiteModificarPrecioDeCostoPromedioPonderado;
			unePrecioDeCostoReposicion.ReadOnly = !(_uiController.PermiteModificarPrecioDeCostoReposicion && !_uiController.UsaPrecioDeListaProveedor);
			unePrecioDeCostoReposicion1.ReadOnly = !(_uiController.PermiteModificarPrecioDeCostoReposicion && !_uiController.UsaPrecioDeListaProveedor);
			chkUsaPrecioDeCostoReposicion.Enabled = _uiController.PermiteModificarUsaPrecioDeCostoReposicion;
			chkUsaPrecioDeCostoReposicion1.Enabled = _uiController.PermiteModificarUsaPrecioDeCostoReposicion;
            //German 20110309 - Tarea 0000038
			//if(_uiController.UsaCostosIndirectos || (_uiController.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia") || _uiController.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior")))
            if (_uiController.UsaCostosIndirectos || _uiController.EsProcesoDeConfirmacionDePrecios(_uiController.ProcessName))
            //Fin German 20110309 - Tarea 0000038
			{
				this.ultraExplorerBar.Groups["DatosCompra"].Visible = true;
				groupBox6.Visible = false;
				this.groupNuevoCosto.Size = new System.Drawing.Size(784, 120);
				this.containerDatosVenta.Size = new System.Drawing.Size(814, 128);
			}
			else
			{
				this.ultraExplorerBar.Groups["DatosCompra"].Visible = false;

				// Tarea 20 Silvina

				int x = 10;
				int y = 85;

				groupBox6.Location = new System.Drawing.Point(label8.Location.X, label8.Location.Y);
				label8.Location = new System.Drawing.Point(label8.Location.X + x,label8.Location.Y + y);
				labelSimboloMonedaPrecioDeCostoReferencia.Location = new System.Drawing.Point(labelSimboloMonedaPrecioDeCostoReferencia.Location.X + x,labelSimboloMonedaPrecioDeCostoReferencia.Location.Y + y);
				unePrecioDeCostoRef.Location = new System.Drawing.Point(unePrecioDeCostoRef.Location.X + x,unePrecioDeCostoRef.Location.Y + y);
				label7.Location = new System.Drawing.Point(label7.Location.X + x,label7.Location.Y + y);
				uneMAC.Location = new System.Drawing.Point(uneMAC.Location.X + x,uneMAC.Location.Y + y);
				label15.Location = new System.Drawing.Point(label15.Location.X + x,label15.Location.Y + y);

				label10.Location = new System.Drawing.Point(label10.Location.X + x,label10.Location.Y + y);
				labelSimboloMonedaPrecioDeVentaNeto.Location = new System.Drawing.Point(labelSimboloMonedaPrecioDeVentaNeto.Location.X + x,labelSimboloMonedaPrecioDeVentaNeto.Location.Y + y);
				unePrecioDeVentaNeto.Location = new System.Drawing.Point(unePrecioDeVentaNeto.Location.X + x,unePrecioDeVentaNeto.Location.Y + y);

				KeyPreview = true;
			}

			mz.erp.ui.forms.classes.ContainerManager.CollapseContainers(ultraExplorerBar, _uiController.GetProcessName(), _uiController.GetTaskName());




			//German 20090714
			if(!_uiController.UsaPrecioDeListaProveedor)
			{

				this.chckActualizaPcioCostoReposicion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
				this.chckActualizaPcioCostoReposicion.Location = new System.Drawing.Point(307, 40);
				this.chckActualizaPcioCostoReposicion.Name = "chckActualizaPcioCostoReposicion";
				this.chckActualizaPcioCostoReposicion.Size = new System.Drawing.Size(208, 21);
				this.chckActualizaPcioCostoReposicion.TabIndex = 218;
				this.chckActualizaPcioCostoReposicion.Text = "Actualiza precio de costo reposición ";
				this.chckActualizaPcioCostoReposicion.Visible = false;
				this.groupDatosProveedor.Controls.Add(this.chckActualizaPcioCostoReposicion);
			}
			//Fin German 20090714

			//Matias 20100612 - Tarea 22
			mzCmbProveedor.Init();
			mzCmbProveedor.SearchObjectListener = this;
			mzCmbProveedor.EnableCtaCte = _uiController.EnabledButtonCuentaCtaCte;
			//Fin Matias 20100612 - Tarea 22
            //German 20140125 - Tarea 1 - SP 22
            tbbEliminarListaDePrecio.Visible = !_uiController.EsProcesoDeConfirmacionDePrecios(_uiController.ProcessName);
            //Fin German 20140125 - Tarea 1 - SP 22
		}

		private void InitializeData()
		{						
			
			mzCEMonedaReferencia.FillFromDataSource( businessrules.tfi_Monedas.GetList().tfi_Monedas, "idMoneda", "Descripcion", 8, "1", "2", "Descripcion");
			mzCEMonedaProveedor.FillFromDataSource( businessrules.tfi_Monedas.GetList().tfi_Monedas, "idMoneda", "Descripcion", 8, "1", "2", "Descripcion");
			mzCEFuenteDeCambioProveedor.FillFromDataSource( businessrules.tfi_FuentesDeCambio.GetList().tfi_FuentesDeCambio, "idFuenteDeCambio", "Descripcion", 8, "1", "2", "Descripcion");
			//gridProductos.DataSource = _uiController.Items;
			mzCEFuenteDeCambioProducto.FillFromDataSource( businessrules.tfi_FuentesDeCambio.GetList().tfi_FuentesDeCambio, "idFuenteDeCambio", "Descripcion", 8, "1", "2", "Descripcion");
			mzProductosControl.AddObjectListener( (IObserver)_uiController );
			//mzCmbProveedorViejo.SearchObject = _uiController.ProveedoresSearchObject; Matias 20100612 - Tarea 22
		    mzCEMonedaPrecioDeCostoProv.FillFromDataSource( businessrules.tfi_Monedas.GetList().tfi_Monedas, "idMoneda", "Descripcion", 8, "1", "2", "Descripcion");
     		mzCEFuenteDeCambioPrecioDeCostoProv.FillFromDataSource( businessrules.tfi_FuentesDeCambio.GetList().tfi_FuentesDeCambio, "idFuenteDeCambio", "Descripcion", 8, "1", "2", "Descripcion");
			//mzCmbProveedorViejo.DataValue = _uiController.IdProveedor; Matias 20100612 - Tarea 22
			unePrecioDeCostoMonedaProveedor.Value = _uiController.PrecioDeCostoMonedaProveedor;

		}
		private void InitEventHandlers()
		{			
			ultraNumericEditor2.Enter +=new EventHandler(SeleccionarTexto);
			uneMAC.Enter +=new EventHandler(SeleccionarTexto);
			uneMaxDescuento.Enter +=new EventHandler(SeleccionarTexto);
			uneMaxDescuentoPorcentual.Enter +=new EventHandler(SeleccionarTexto);
			unePCostoPromedioPonderado.Enter +=new EventHandler(SeleccionarTexto);
			unePCostoPromedioPonderado1.Enter +=new EventHandler(SeleccionarTexto);
			unePrecioPPCostoAnteriorMonedaProducto.Enter +=new EventHandler(SeleccionarTexto);
			unePrecioCostoMonedaReferencia.Enter +=new EventHandler(SeleccionarTexto);
			unePrecioDeCostoMonedaProveedor.Enter +=new EventHandler( SeleccionarTexto);
			groupDatosProveedor.Enter +=new EventHandler(SeleccionarTexto);
			unePrecioDeCostoRef.Enter +=new EventHandler( SeleccionarTexto);
			unePrecioDeVentaNeto.Enter +=new EventHandler(SeleccionarTexto);
			unePrecioVentaBruto.Enter +=new EventHandler(SeleccionarTexto);
			uneStock.Enter +=new EventHandler(SeleccionarTexto);
			uneCoeficiente1.Enter +=new EventHandler(SeleccionarTexto);
			uneCoeficiente2.Enter +=new EventHandler(SeleccionarTexto);
			uneCoeficiente3.Enter +=new EventHandler(SeleccionarTexto);
			uneCoeficiente4.Enter +=new EventHandler(SeleccionarTexto);
			uneCoeficiente5.Enter +=new EventHandler(SeleccionarTexto);
			unePrecioDeListaConImpuesto.Enter +=new EventHandler(SeleccionarTexto);
			unePrecioDeListaConImpuestoMonedaReferencia.Enter +=new EventHandler(SeleccionarTexto);
			uneCoeficienteTotal.Enter +=new EventHandler(SeleccionarTexto);
			uneValorCotizacionProveedor.Enter += new EventHandler(SeleccionarTexto);
			
			gridProductos.SelectionChanged +=new EventHandler(gridProductos_SelectionChanged);
			toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			_uiController.SeleccionMultiplePrecioDeCostoError +=new EventHandler(_uiController_SeleccionMultiplePrecioDeCostoError);
			_uiController.SeleccionMultiplePrecioDeVentaError +=new EventHandler(_uiController_SeleccionMultiplePrecioDeVentaError);
			_uiController.SeleccionMultipleChanged +=new EventHandler(RefreshControls);
			_uiController.ObjectHasChanged +=new EventHandler(RefreshControls);
			_uiController.ProductosCollectionChanged +=	new EventHandler(Refresh);
			_uiController.ListaDePreciosProveedoresHasChanged +=new EventHandler(_uiController_ListaDePreciosProveedoresHasChanged);
			gridProductos.RecordsDeleted +=new EventHandler(gridProductos_RecordsDeleted);
			gridProductos.DeletingRecords +=new CancelEventHandler(gridProductos_DeletingRecords);

			rbSeleccionSimple.CheckedChanged +=new EventHandler(rbSeleccionMultiple_CheckedChanged);
			rbSeleccionMultiple.CheckedChanged +=new EventHandler(rbSeleccionMultiple_CheckedChanged);
			bTodosCaja.Click +=new EventHandler(bTodosCaja_Click);
			bNingunoCaja.Click +=new EventHandler(bNingunoCaja_Click);
			
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

			//Matias 20100612 - Tarea 22
			//mzCmbProveedorViejo.ValueChanged +=new EventHandler(mzCmbProveedor_ValueChanged);
			mzCmbProveedor.ValueChanged+= new System.EventHandler( this.Componentes_Changes );
			//Fin Matias 20100612 - Tarea 22
			
			//Sabrina 20100616 - Tarea 744
			//mzCEMonedaPrecioDeCostoProv.ValueChanged += new EventHandler(mzCEMonedaPrecioDeCostoProv_ValueChanged);
			//mzCEFuenteDeCambioPrecioDeCostoProv.ValueChanged += new EventHandler(mzCEFuenteDeCambioPrecioDeCostoProv_ValueChanged);
			//Fin Sabrina 20100616 - Tarea 744

			utbTrasladarPrecioDeCostoFinal.Click +=new EventHandler(utbTrasladarPrecioDeCostoFinal_Click);
			//utbTrasladarPrecioUnitario.Click +=new EventHandler(utbTrasladarPrecioUnitario_Click);

			uneBonificacion1.Enter +=new EventHandler(SeleccionarTexto);
			uneBonificacion2.Enter +=new EventHandler(SeleccionarTexto);
			uneBonificacion3.Enter +=new EventHandler(SeleccionarTexto);
			uneBonificacion4.Enter +=new EventHandler(SeleccionarTexto);
			uneBonificacion5.Enter +=new EventHandler(SeleccionarTexto);
			uneCoeficientePorc1.Enter +=new EventHandler(SeleccionarTexto);
			uneCoeficientePorc2.Enter +=new EventHandler(SeleccionarTexto);
			uneCoeficientePorc3.Enter +=new EventHandler(SeleccionarTexto);
			uneCoeficientePorc4.Enter +=new EventHandler(SeleccionarTexto);
			uneCoeficientePorc5.Enter +=new EventHandler(SeleccionarTexto);
			unePrecioDeCostoFinalProveedor.Enter +=new EventHandler(SeleccionarTexto);
			gridListaDePreciosProveedores.SelectionChanged += new EventHandler(gridListaDePreciosProveedores_SelectionChanged);
            /* Silvina 20110817 - Tarea 0000191 */
            gridListaDePreciosProveedores.CellValueChanged += new Janus.Windows.GridEX.ColumnActionEventHandler(gridListaDePreciosProveedores_CellValueChanged);
            /* Fin Silvina 20110817 - Tarea 0000191 */
            gridListaDePreciosProveedores.CellEdited += new Janus.Windows.GridEX.ColumnActionEventHandler(gridListaDePreciosProveedores_CellEdited);
			gridListaDePreciosProveedores.Click += new EventHandler(gridListaDePreciosProveedores_Click);
			gridListaDePreciosProveedores.DeletingRecords +=new CancelEventHandler(gridListaDePreciosProveedores_DeletingRecords);
			gridListaDePreciosProveedores.RecordsDeleted +=new EventHandler(gridListaDePreciosProveedores_RecordsDeleted);

			utbAolicaCoeficienteSobrePrecioCostoListaProveedor.Click +=new EventHandler(utbAolicaCoeficienteSobrePrecioCostoListaProveedor_Click);

			//this.unePrecioDeVentaNeto.Leave += new System.EventHandler(this.unePrecioDeVentaNeto_Leave);
			this.unePrecioVentaBruto.DoubleClick +=new EventHandler(unePrecioVentaBruto_DoubleClick);

			//Sabrina: tarea 56
			chkUsaPrecioDeCostoReposicion.CheckedChanged +=	new EventHandler(chkUsaPrecioDeCostoReposicion_CheckedChanged);
			chkUsaPrecioDeCostoReposicion1.CheckedChanged +=	new EventHandler(chkUsaPrecioDeCostoReposicion1_CheckedChanged);

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


			chckActualizaPcioCostoReposicion.CheckedChanged+=new EventHandler(chckActualizaPcioCostoReposicion_CheckedChanged);
			chckBonificacionesAcumulativas.CheckedChanged+=new EventHandler(chckBonificacionesAcumulativas_CheckedChanged);
			KeyDownManager KeyDownMan = new KeyDownManager(this);	


		}

		private void RefreshControls(object sender, EventArgs e)
		{
			labeSimbololMonedaPrecioDeCosto.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaPrecioDeCosto1.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaPrecioDeCosto3.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaPrecioDeCosto4.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaPrecioDeCosto6.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;			

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


			labelSimboloMonedaProveedor.Text = _uiController.SimboloMonedaProveedor;
			labelSimboloMonedaReferencia.Text  = _uiController.SimboloMonedaReferencia;
			labelSimboloMonedaOrigen.Text = _uiController.SimboloMonedaOrigen;
			labelSimboloMonedaDescuentoMaximo.Text = _uiController.SimboloMonedaDescuentoMaximo;
			labelSimboloMonedaPrecioDeCostoReferencia.Text = _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaPrecioDeLista.Text = _uiController.SimboloMonedaPrecioDeLista;
			labelSimboloMonedaPrecioDeVentaNeto.Text = _uiController.SimboloMonedaPrecioDeVentaNeto;
			labelSimboloMonedaPrecioDeListaConImpuestos.Text = _uiController.SimboloMonedaPrecioDeLista;

			//labelCoeficiente1.Text = Convert.ToString(_uiController.Coeficiente1) + "%";
			/* Matias
			uneCoeficientePorc1.Value = _uiController.Coeficiente1;
			uneCoeficientePorc2.Value = _uiController.Coeficiente2;
			uneCoeficientePorc3.Value = _uiController.Coeficiente3;
			uneCoeficientePorc4.Value = _uiController.Coeficiente4;
			uneCoeficientePorc5.Value = _uiController.Coeficiente5;
			uneCoeficiente1.Value = _uiController.CostoIndirecto1;
			uneCoeficiente2.Value = _uiController.CostoIndirecto2;
			uneCoeficiente3.Value = _uiController.CostoIndirecto3;
			uneCoeficiente4.Value = _uiController.CostoIndirecto4;
			uneCoeficiente5.Value = _uiController.CostoIndirecto5;
			*/
			//labelCoeficiente2.Text = Convert.ToString(_uiController.Coeficiente2) + "%";
			if(decimal.Round(Convert.ToDecimal(unePrecioVentaBruto.Value),4) < decimal.Round(Convert.ToDecimal(unePrecioDeVentaNeto.Value),4))
				unePrecioVentaBruto.Appearance.ForeColor = Color.Red;
			else unePrecioVentaBruto.Appearance.ForeColor = Color.Black;
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

            lbSimbololMonedaPrecioDeCostoProveedor.Text = _uiController.SimbololMonedaPrecioDeCostoProveedor;
			lblSimboloMonedaBonificacion1.Text = _uiController.SimbololMonedaPrecioDeCostoProveedor;
			lblSimboloMonedaBonificacion2.Text = _uiController.SimbololMonedaPrecioDeCostoProveedor;
			lblSimboloMonedaBonificacion3.Text = _uiController.SimbololMonedaPrecioDeCostoProveedor;
			lblSimboloMonedaBonificacion4.Text = _uiController.SimbololMonedaPrecioDeCostoProveedor;
			lblSimboloMonedaBonificacion5.Text = _uiController.SimbololMonedaPrecioDeCostoProveedor;
			lbSimbololMonedaPrecioDeCostoFinalProveedor.Text = _uiController.SimbololMonedaPrecioDeCostoProveedor;

			//Sabrina: tarea 56
			labelSimboloMonedaPrecioDeCostoReposicion.Text =  _uiController.SimboloMonedaPrecioDeCostoReferencia;
			labelSimboloMonedaPrecioDeCostoReposicion1.Text =  _uiController.SimboloMonedaPrecioDeCostoReferencia;


			/*
			if(!_uiController.ExisteProveedorProducto)
			{
				mzCEMonedaPrecioDeCostoProv.Enabled = true;
				mzCEFuenteDeCambioPrecioDeCostoProv.Enabled = true;

			}
			else
			{
				mzCEMonedaPrecioDeCostoProv.Enabled = false;
				mzCEFuenteDeCambioPrecioDeCostoProv.Enabled = false;
			}
			*/

			mzCEMonedaPrecioDeCostoProv.Enabled = true;
			mzCEFuenteDeCambioPrecioDeCostoProv.Enabled = true;
			uneCotizacionPrecioDeCostoProveedor.Enabled = true;

			unePrecioDeCostoMonedaProducto.Value = _uiController.PrecioDeCostoMonedaProducto;
			unePrecioDeCostoMonedaProveedor.Value = _uiController.PrecioDeCostoMonedaProveedor;

			//Matias 20100612 - Tarea 22
			//mzCmbProveedorViejo.DataValue = _uiController.IdProveedor;
			mzCmbProveedor.DataValue = _uiController.CodigoProveedor;
			//Fin Matias 20100612 - Tarea 22

			/*
			    unePrecioVentaBruto.DataBindings.Clear();
				unePrecioVentaBruto.DataBindings.Add("Value", _uiController, "PrecioDeVentaBruto");
			*/
			gridListaDePreciosProveedores.Refresh();
			
			this.HabilitarCostosIndirectos();			
		}
	
		private void Refresh(object sender, EventArgs e)
		{
			try
			{			
				int row = gridProductos.Row;
				gridProductos.SetDataBinding(null, null);
				gridProductos.SetDataBinding(_uiController.Items, null);
				gridProductos.UpdateData();	
				if(row >= 0)
					gridProductos.Row = row;
					//gridProductos.Row = gridProductos.RowCount - 1; 

				if (gridManagerView1.AllowGroupCollapse)
					this.gridProductos.CollapseGroups();
				else
					if (gridProductos.RootTable.Groups.Count > 0 )
					gridProductos.RootTable.Groups[0].Expand();
				if(_uiController.SelectedItem != null)
				{
					gridListaDePrecios.SetDataBinding(null, null);
					gridListaDePrecios.SetDataBinding(_uiController.SelectedItem.ListaDePrecios.Items, null);
					gridListaDePreciosProveedores.SetDataBinding(null, null);
					gridListaDePreciosProveedores.SetDataBinding(_uiController.SelectedItem.ListaDePreciosProveedores.Items, null);


				}
				//this.HabilitarCostosIndirectos(); 
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
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

		private void InitDataBindings()
		{				
			
			mzCEMonedaReferencia.DataBindings.Clear();
			mzCEMonedaProveedor.DataBindings.Clear();
			uneValorCotizacionProveedor.DataBindings.Clear();
			mzCEFuenteDeCambioProveedor.DataBindings.Clear();
			unePrecioPPCostoAnteriorMonedaProducto.DataBindings.Clear();
			uneStock.DataBindings.Clear();
			
			unePrecioCostoMonedaReferencia.DataBindings.Clear();
			unePrecioDeCostoMonedaProveedor.DataBindings.Clear();
			unePrecioDeVentaNeto.DataBindings.Clear();
			unePCostoPromedioPonderado.DataBindings.Clear();
			unePCostoPromedioPonderado1.DataBindings.Clear();
			
			uneMAC.DataBindings.Clear();
			unePrecioVentaBruto.DataBindings.Clear();
			uneMaxDescuento.DataBindings.Clear();
			uneMaxDescuentoPorcentual.DataBindings.Clear();
			unePrecioDeCostoRef.DataBindings.Clear();
			mzCEFuenteDeCambioProducto.DataBindings.Clear();
			unePrecioDeCostoAnteriorMonedaProducto.DataBindings.Clear();
			unePrecioDeCostoMonedaProducto.DataBindings.Clear();
			gridProductos.SetDataBinding(null, null);
			unePrecioDeListaConImpuesto.DataBindings.Clear();
			unePrecioDeListaConImpuestoMonedaReferencia.DataBindings.Clear();

			gridProductos.SetDataBinding(_uiController.Items, null);
			mzCEMonedaReferencia.DataBindings.Add("Value", _uiController, "IdMonedaReferencia");
			mzCEMonedaProveedor.DataBindings.Add("Value", _uiController, "IdMonedaProveedor");
			uneValorCotizacionProveedor.DataBindings.Add("Value",_uiController, "ValorCotizacionFuenteDeCambioProveedor");
			mzCEFuenteDeCambioProveedor.DataBindings.Add("Value", _uiController, "IdFuenteDeCambioProveedor");
			unePrecioPPCostoAnteriorMonedaProducto.DataBindings.Add("Value", _uiController, "PrecioDeCostoPromedioPonderadoAnterior");
			uneStock.DataBindings.Add("Value", _uiController, "StockDisponible");
			
			unePrecioCostoMonedaReferencia.DataBindings.Add("Value",_uiController, "PrecioCostoMonedaReferencia");
			unePrecioDeCostoMonedaProveedor.DataBindings.Add("Value", _uiController, "PrecioDeCostoMonedaProveedor");
			
			//Sabrina: tarea 56
			//unePCostoPromedioPonderado.DataBindings.Add("Value", _uiController, "PrecioDeCosto");
			chkUsaPrecioDeCostoReposicion.DataBindings.Clear();
			chkUsaPrecioDeCostoReposicion1.DataBindings.Clear();
			unePCostoPromedioPonderado.DataBindings.Clear();
			unePCostoPromedioPonderado1.DataBindings.Clear();
			chkUsaPrecioDeCostoReposicion.DataBindings.Add("Checked", _uiController,"UsaPrecioDeCostoReposicion");
			chkUsaPrecioDeCostoReposicion1.DataBindings.Add("Checked", _uiController,"UsaPrecioDeCostoReposicion");
			unePrecioDeCostoReposicion.DataBindings.Add("Value", _uiController,"PrecioDeCostoReposicion");
			unePrecioDeCostoReposicion1.DataBindings.Add("Value", _uiController,"PrecioDeCostoReposicion");
			unePCostoPromedioPonderado.DataBindings.Add("Value", _uiController,"PrecioDeCostoPromedioPonderado");
			unePCostoPromedioPonderado1.DataBindings.Add("Value", _uiController,"PrecioDeCostoPromedioPonderado");

			
			
			uneMAC.DataBindings.Add("Value", _uiController, "MAC");
			unePrecioDeVentaNeto.DataBindings.Add("Value", _uiController, "PrecioDeVentaNeto");
			unePrecioVentaBruto.DataBindings.Add("Value", _uiController, "PrecioDeVentaBruto");
			uneMaxDescuento.DataBindings.Add("Value", _uiController, "MaximoDescuento");
			uneMaxDescuentoPorcentual.DataBindings.Add("Value", _uiController, "PorcentajeMaximoDescuento");
			unePrecioDeCostoRef.DataBindings.Add("Value", _uiController, "PrecioCostoRef");
			unePrecioDeCostoAnteriorMonedaProducto.DataBindings.Add("Value", _uiController, "PrecioDeCostoAnteriorMonedaProducto");
			mzCEFuenteDeCambioProducto.DataBindings.Add("Value", _uiController, "IdFuenteDeCambioProductoPrecioDeCosto");
			unePrecioDeCostoMonedaProducto.DataBindings.Add("Value", _uiController, "PrecioDeCostoMonedaProducto");
			unePrecioDeListaConImpuesto.DataBindings.Add("Value", _uiController, "PrecioDeListaConImpuestos");
			unePrecioDeListaConImpuestoMonedaReferencia.DataBindings.Add("Value", _uiController, "PrecioDeListaConImpuestosMonedaReferencia");

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
			//mzCmbProveedorViejo.DataBindings.Clear();
			unePrecioDeCostoProveedor.DataBindings.Clear();
			mzCEMonedaPrecioDeCostoProv.DataBindings.Clear();
			mzCEFuenteDeCambioPrecioDeCostoProv.DataBindings.Clear();
			uneCotizacionPrecioDeCostoProveedor.DataBindings.Clear();
			uneBonificacion1.DataBindings.Clear();
			uneBonificacion2.DataBindings.Clear();
			uneBonificacion3.DataBindings.Clear();
			uneBonificacion4.DataBindings.Clear();
			uneBonificacion5.DataBindings.Clear();
			unePorcBonificacion1.DataBindings.Clear();
			unePorcBonificacion2.DataBindings.Clear();
			unePorcBonificacion3.DataBindings.Clear();
			unePorcBonificacion4.DataBindings.Clear();
			unePorcBonificacion5.DataBindings.Clear();
			unePrecioDeCostoFinalProveedor.DataBindings.Clear();
			chckBonificacionesAcumulativas.DataBindings.Clear();
			chckActualizaPcioCostoReposicion.DataBindings.Clear();

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
			//mzCmbProveedorViejo.DataBindings.Add("DataValue",_uiController,"IdProveedor");
			unePrecioDeCostoProveedor.DataBindings.Add("Value", _uiController, "PrecioDeCostoProdProv");
			mzCEMonedaPrecioDeCostoProv.DataBindings.Add("Value", _uiController, "IdMonedaPrecioDeCostoProveedor");
			mzCEFuenteDeCambioPrecioDeCostoProv.DataBindings.Add("Value", _uiController, "IdFuenteDeCambioListaProveedor");
			uneCotizacionPrecioDeCostoProveedor.DataBindings.Add("Value", _uiController, "ValorCotizacionPrecioDeCostoProveedor");

			chckActualizaPcioCostoReposicion.DataBindings.Add("Checked", _uiController, "ActualizaPrecioDeCostoReposicion");
			
			chckBonificacionesAcumulativas.DataBindings.Add("Checked", _uiController, "BonificacionAcumulativa");
			uneBonificacion1.DataBindings.Add("Value", _uiController, "Bonificacion1");
			uneBonificacion2.DataBindings.Add("Value", _uiController, "Bonificacion2");
			uneBonificacion3.DataBindings.Add("Value", _uiController, "Bonificacion3");
			uneBonificacion4.DataBindings.Add("Value", _uiController, "Bonificacion4");
			uneBonificacion5.DataBindings.Add("Value", _uiController, "Bonificacion5");
			unePorcBonificacion1.DataBindings.Add("Value", _uiController, "PorcentajeBonificacion1");
			unePorcBonificacion2.DataBindings.Add("Value", _uiController, "PorcentajeBonificacion2");
			unePorcBonificacion3.DataBindings.Add("Value", _uiController, "PorcentajeBonificacion3");
			unePorcBonificacion4.DataBindings.Add("Value", _uiController, "PorcentajeBonificacion4");
			unePorcBonificacion5.DataBindings.Add("Value", _uiController, "PorcentajeBonificacion5");
			unePrecioDeCostoFinalProveedor.DataBindings.Add("Value", _uiController, "PrecioDeCostoFinalProveedor");
			lbSimbololMonedaPrecioDeCostoProveedor.DataBindings.Add("Text", _uiController, "SimbololMonedaPrecioDeCostoProveedor");
			lblSimboloMonedaBonificacion1.DataBindings.Add("Text", _uiController, "SimbololMonedaPrecioDeCostoProveedor");
			lblSimboloMonedaBonificacion2.DataBindings.Add("Text", _uiController, "SimbololMonedaPrecioDeCostoProveedor");
			lblSimboloMonedaBonificacion3.DataBindings.Add("Text", _uiController, "SimbololMonedaPrecioDeCostoProveedor");
			lblSimboloMonedaBonificacion4.DataBindings.Add("Text", _uiController, "SimbololMonedaPrecioDeCostoProveedor");
			lblSimboloMonedaBonificacion5.DataBindings.Add("Text", _uiController, "SimbololMonedaPrecioDeCostoProveedor");
			lbSimbololMonedaPrecioDeCostoFinalProveedor.DataBindings.Add("Text", _uiController, "SimbololMonedaPrecioDeCostoProveedor");
	
			InitDataBindingsCostosIndirectos();
            //German 20140125 - Tarea 1 - SP 22
            txtCodigoProductoProveedor.DataBindings.Add("Text", _uiController, "CodigoProductoProveedor");
            //German 20140125 - Tarea 1 - SP 22
			
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
			mz.erp.ui.utility.Util.MoveFocus(containerProductos);
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
			
				_uiController.ObjectHasChanged -=new EventHandler(Refresh);
                //German 20110122 - Tarea 0000020
                _uiController.ObjectHasChanged -= new EventHandler(RefreshControls);
                //Fin German 20110122 - Tarea 0000020
				_uiController.SeleccionMultiplePrecioDeCostoError -=new EventHandler(_uiController_SeleccionMultiplePrecioDeCostoError);
				_uiController.SeleccionMultiplePrecioDeVentaError -=new EventHandler(_uiController_SeleccionMultiplePrecioDeVentaError);
				_uiController.SeleccionMultipleChanged -=new EventHandler(RefreshControls);
				_uiController.ProductosCollectionChanged -=	new EventHandler(Refresh);
				_uiController.ListaDePreciosProveedoresHasChanged -=new EventHandler(_uiController_ListaDePreciosProveedoresHasChanged);
                //German 20110309 - Tarea 0000038
				//if(_uiController.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia") || _uiController.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior"))
                if (_uiController.EsProcesoDeConfirmacionDePrecios(_uiController.ProcessName))
                //Fin German 20110309 - Tarea 0000038
					_uiController.PrecioDeCostoMonedaProveedorChanged -=new EventHandler(_uiController_PrecioDeCostoMonedaProveedorChanged);


				_uiController = null;

				if(components != null)
				{
					components.Dispose();
				}
				

				gridProductos.SelectionChanged -=new EventHandler(gridProductos_SelectionChanged);
				ultraNumericEditor2.Enter -=new EventHandler(SeleccionarTexto);
				uneMAC.Enter -=new EventHandler(SeleccionarTexto);
				uneMaxDescuento.Enter -=new EventHandler(SeleccionarTexto);
				uneMaxDescuentoPorcentual.Enter -=new EventHandler(SeleccionarTexto);
				unePCostoPromedioPonderado.Enter -=new EventHandler(SeleccionarTexto);
				unePCostoPromedioPonderado1.Enter -=new EventHandler(SeleccionarTexto);
				unePrecioPPCostoAnteriorMonedaProducto.Enter -=new EventHandler(SeleccionarTexto);
				unePrecioCostoMonedaReferencia.Enter -=new EventHandler(SeleccionarTexto);
				unePrecioDeCostoMonedaProveedor.Enter -=new EventHandler( SeleccionarTexto);
				groupDatosProveedor.Enter -=new EventHandler(SeleccionarTexto);
				unePrecioDeCostoRef.Enter -=new EventHandler( SeleccionarTexto);
				unePrecioDeVentaNeto.Enter -=new EventHandler(SeleccionarTexto);
				unePrecioVentaBruto.Enter -=new EventHandler(SeleccionarTexto);
				uneStock.Enter -=new EventHandler(SeleccionarTexto);
				uneCoeficiente1.Enter -=new EventHandler(SeleccionarTexto);
				uneCoeficiente2.Enter -=new EventHandler(SeleccionarTexto);
				uneCoeficiente3.Enter -=new EventHandler(SeleccionarTexto);
				uneCoeficiente4.Enter -=new EventHandler(SeleccionarTexto);
				uneCoeficiente5.Enter -=new EventHandler(SeleccionarTexto);
				unePrecioDeListaConImpuesto.Enter -=new EventHandler(SeleccionarTexto);
				unePrecioDeListaConImpuestoMonedaReferencia.Enter -=new EventHandler(SeleccionarTexto);
				uneCoeficienteTotal.Enter -=new EventHandler(SeleccionarTexto);
				uneValorCotizacionProveedor.Enter -= new EventHandler(SeleccionarTexto);
			
				gridProductos.SelectionChanged -=new EventHandler(gridProductos_SelectionChanged);
				toolBarStandar.ButtonClick -=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
				/*
				_uiController.SeleccionMultiplePrecioDeCostoError -=new EventHandler(_uiController_SeleccionMultiplePrecioDeCostoError);
				_uiController.SeleccionMultiplePrecioDeVentaError -=new EventHandler(_uiController_SeleccionMultiplePrecioDeVentaError);
				_uiController.SeleccionMultipleChanged -=new EventHandler(RefreshControls);
				_uiController.ObjectHasChanged -=new EventHandler(RefreshControls);
				_uiController.ProductosCollectionChanged -=	new EventHandler(Refresh);
				_uiController.ListaDePreciosProveedoresHasChanged -=new EventHandler(_uiController_ListaDePreciosProveedoresHasChanged);
				*/
				gridProductos.RecordsDeleted -=new EventHandler(gridProductos_RecordsDeleted);
				gridProductos.DeletingRecords -=new CancelEventHandler(gridProductos_DeletingRecords);

				rbSeleccionSimple.CheckedChanged -=new EventHandler(rbSeleccionMultiple_CheckedChanged);
				rbSeleccionMultiple.CheckedChanged -=new EventHandler(rbSeleccionMultiple_CheckedChanged);
				bTodosCaja.Click -=new EventHandler(bTodosCaja_Click);
				bNingunoCaja.Click -=new EventHandler(bNingunoCaja_Click);
			
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

				//Matias 20100612 - Tarea 22
				//mzCmbProveedorViejo.ValueChanged -=new EventHandler(mzCmbProveedor_ValueChanged);
				mzCmbProveedor.ValueChanged -=new EventHandler(this.Componentes_Changes);
				//Fin Matias 20100612 - Tarea 22
			
				//Sabrina 20100616 - Tarea 744
				//mzCEMonedaPrecioDeCostoProv.ValueChanged -= new EventHandler(mzCEMonedaPrecioDeCostoProv_ValueChanged);
				//mzCEFuenteDeCambioPrecioDeCostoProv.ValueChanged -= new EventHandler(mzCEFuenteDeCambioPrecioDeCostoProv_ValueChanged);
				//Fin Sabrina 20100616 - Tarea 744

				utbTrasladarPrecioDeCostoFinal.Click -=new EventHandler(utbTrasladarPrecioDeCostoFinal_Click);
				//utbTrasladarPrecioUnitario.Click +=new EventHandler(utbTrasladarPrecioUnitario_Click);

				uneBonificacion1.Enter -=new EventHandler(SeleccionarTexto);
				uneBonificacion2.Enter -=new EventHandler(SeleccionarTexto);
				uneBonificacion3.Enter -=new EventHandler(SeleccionarTexto);
				uneBonificacion4.Enter -=new EventHandler(SeleccionarTexto);
				uneBonificacion5.Enter -=new EventHandler(SeleccionarTexto);
				uneCoeficientePorc1.Enter -=new EventHandler(SeleccionarTexto);
				uneCoeficientePorc2.Enter -=new EventHandler(SeleccionarTexto);
				uneCoeficientePorc3.Enter -=new EventHandler(SeleccionarTexto);
				uneCoeficientePorc4.Enter -=new EventHandler(SeleccionarTexto);
				uneCoeficientePorc5.Enter -=new EventHandler(SeleccionarTexto);
				unePrecioDeCostoFinalProveedor.Enter -=new EventHandler(SeleccionarTexto);
				gridListaDePreciosProveedores.SelectionChanged -= new EventHandler(gridListaDePreciosProveedores_SelectionChanged);
			
				gridListaDePreciosProveedores.DeletingRecords -=new CancelEventHandler(gridListaDePreciosProveedores_DeletingRecords);
				gridListaDePreciosProveedores.RecordsDeleted -=new EventHandler(gridListaDePreciosProveedores_RecordsDeleted);
				utbAolicaCoeficienteSobrePrecioCostoListaProveedor.Click -=new EventHandler(utbAolicaCoeficienteSobrePrecioCostoListaProveedor_Click);

			
				uneCoeficiente.DataBindings.Clear();
				mzCEMonedaReferencia.DataBindings.Clear();
				mzCEMonedaProveedor.DataBindings.Clear();
				uneValorCotizacionProveedor.DataBindings.Clear();
				mzCEFuenteDeCambioProveedor.DataBindings.Clear();
				unePrecioPPCostoAnteriorMonedaProducto.DataBindings.Clear();
				uneStock.DataBindings.Clear();
				
				unePrecioCostoMonedaReferencia.DataBindings.Clear();
				unePrecioDeCostoMonedaProveedor.DataBindings.Clear();
				unePrecioDeVentaNeto.DataBindings.Clear();
				unePCostoPromedioPonderado.DataBindings.Clear();
				unePCostoPromedioPonderado1.DataBindings.Clear();
				
				uneMAC.DataBindings.Clear();
				unePrecioVentaBruto.DataBindings.Clear();
				uneMaxDescuento.DataBindings.Clear();
				uneMaxDescuentoPorcentual.DataBindings.Clear();
				unePrecioDeCostoRef.DataBindings.Clear();
				mzCEFuenteDeCambioProducto.DataBindings.Clear();
				unePrecioDeCostoAnteriorMonedaProducto.DataBindings.Clear();
				unePrecioDeCostoMonedaProducto.DataBindings.Clear();

				unePrecioDeCostoRefLP.DataBindings.Clear();
				uneMACLP.DataBindings.Clear();
				unePrecioDeVentaNetoLP.DataBindings.Clear();

			
				// Limpio DataBindings de Costos Indirectos.
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

				this.unePrecioVentaBruto.DoubleClick -=new EventHandler(unePrecioVentaBruto_DoubleClick);
				chkUsaPrecioDeCostoReposicion.CheckedChanged -=	new EventHandler(chkUsaPrecioDeCostoReposicion_CheckedChanged);
				chkUsaPrecioDeCostoReposicion1.CheckedChanged -=	new EventHandler(chkUsaPrecioDeCostoReposicion1_CheckedChanged);

				this.chkCoef1.CheckedChanged -= new System.EventHandler(this.chkCoef1_CheckedChanged);
				this.chkCoef2.CheckedChanged -= new System.EventHandler(this.chkCoef2_CheckedChanged);
				this.chkCoef3.CheckedChanged -= new System.EventHandler(this.chkCoef3_CheckedChanged);
				this.chkCoef4.CheckedChanged -= new System.EventHandler(this.chkCoef4_CheckedChanged);
				this.chkCoef5.CheckedChanged -= new System.EventHandler(this.chkCoef5_CheckedChanged);
				this.chkCoef6.CheckedChanged -= new System.EventHandler(this.chkCoef6_CheckedChanged);
				this.chkCoef7.CheckedChanged -= new System.EventHandler(this.chkCoef7_CheckedChanged);
				this.chkCoef8.CheckedChanged -= new System.EventHandler(this.chkCoef8_CheckedChanged);
				this.chkCoef9.CheckedChanged -= new System.EventHandler(this.chkCoef9_CheckedChanged);
				this.chkCoef10.CheckedChanged -= new System.EventHandler(this.chkCoef10_CheckedChanged);
				
				this.btnEliminarListaDePreciosProv.Click -= new System.EventHandler(this.btnEliminarListaDePreciosProv_Click);

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
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup6 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.labelTarea = new System.Windows.Forms.Label();
            this.containerProductos = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
            this.panel1 = new System.Windows.Forms.GroupBox();
            this.bNingunoCaja = new Infragistics.Win.Misc.UltraButton();
            this.bTodosCaja = new Infragistics.Win.Misc.UltraButton();
            this.rbSeleccionMultiple = new System.Windows.Forms.RadioButton();
            this.rbSeleccionSimple = new System.Windows.Forms.RadioButton();
            this.mzProductosControl = new mz.erp.ui.controls.mzProductosControl();
            this.gridProductos = new Janus.Windows.GridEX.GridEX();
            this.label9 = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.gridListaDePreciosProveedores = new Janus.Windows.GridEX.GridEX();
            this.gridManagerView3 = new mz.erp.ui.controls.GridManagerView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chckActualizaPcioCostoReposicion = new System.Windows.Forms.CheckBox();
            this.chckBonificacionesAcumulativas = new System.Windows.Forms.CheckBox();
            this.uneCoeficientePrecioCostoListaProveedor = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.utbAolicaCoeficienteSobrePrecioCostoListaProveedor = new Infragistics.Win.Misc.UltraButton();
            this.label1 = new System.Windows.Forms.Label();
            this.uneBonificacion2 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneBonificacion1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label20 = new System.Windows.Forms.Label();
            this.ultraLabel25 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel26 = new Infragistics.Win.Misc.UltraLabel();
            this.label21 = new System.Windows.Forms.Label();
            this.uneCotizacionPrecioDeCostoProveedor = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraLabel19 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel20 = new Infragistics.Win.Misc.UltraLabel();
            this.label17 = new System.Windows.Forms.Label();
            this.lbSimbololMonedaPrecioDeCostoProveedor = new System.Windows.Forms.Label();
            this.unePrecioDeCostoProveedor = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label14 = new System.Windows.Forms.Label();
            this.unePorcBonificacion2 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.unePorcBonificacion3 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.unePorcBonificacion4 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.unePorcBonificacion5 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.utbTrasladarPrecioDeCostoFinal = new Infragistics.Win.Misc.UltraButton();
            this.ultraLabel21 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel18 = new Infragistics.Win.Misc.UltraLabel();
            this.unePorcBonificacion1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.mzCEFuenteDeCambioPrecioDeCostoProv = new mz.erp.ui.controls.mzComboEditor();
            this.mzCEMonedaPrecioDeCostoProv = new mz.erp.ui.controls.mzComboEditor();
            this.lbSimbololMonedaPrecioDeCostoFinalProveedor = new System.Windows.Forms.Label();
            this.unePrecioDeCostoFinalProveedor = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraLabel27 = new Infragistics.Win.Misc.UltraLabel();
            this.lblSimboloMonedaBonificacion5 = new System.Windows.Forms.Label();
            this.lblSimboloMonedaBonificacion4 = new System.Windows.Forms.Label();
            this.lblSimboloMonedaBonificacion3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ultraLabel22 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel23 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel24 = new Infragistics.Win.Misc.UltraLabel();
            this.uneBonificacion5 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneBonificacion4 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneBonificacion3 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.lblSimboloMonedaBonificacion2 = new System.Windows.Forms.Label();
            this.lblSimboloMonedaBonificacion1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mzCmbProveedor = new mz.erp.ui.controls.mzProveedoresControl();
            this.btnEliminarListaDePreciosProv = new Infragistics.Win.Misc.UltraButton();
            this.ultraLabel17 = new Infragistics.Win.Misc.UltraLabel();
            this.containerDatosCompra = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.groupMZ = new System.Windows.Forms.GroupBox();
            this.labelSimboloMonedaPrecioDeCostoReposicion = new System.Windows.Forms.Label();
            this.labelSimboloMonedaPrecioDeCosto3 = new System.Windows.Forms.Label();
            this.labelSimboloMonedaPrecioDeCosto1 = new System.Windows.Forms.Label();
            this.labeSimbololMonedaPrecioDeCosto = new System.Windows.Forms.Label();
            this.chkUsaPrecioDeCostoReposicion = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.label63 = new System.Windows.Forms.Label();
            this.unePrecioDeCostoReposicion = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.unePrecioPPCostoAnteriorMonedaProducto = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneStock = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.unePrecioDeCostoMonedaProducto = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel12 = new Infragistics.Win.Misc.UltraLabel();
            this.unePCostoPromedioPonderado = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraLabel11 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel10 = new Infragistics.Win.Misc.UltraLabel();
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
            this.groupDatosProveedor = new System.Windows.Forms.GroupBox();
            this.mzCEFuenteDeCambioProducto = new mz.erp.ui.controls.mzComboEditor();
            this.labelSimboloMonedaOrigen = new System.Windows.Forms.Label();
            this.unePrecioDeCostoAnteriorMonedaProducto = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraLabel14 = new Infragistics.Win.Misc.UltraLabel();
            this.labelSimboloMonedaReferencia = new System.Windows.Forms.Label();
            this.labelSimboloMonedaProveedor = new System.Windows.Forms.Label();
            this.mzCEMonedaReferencia = new mz.erp.ui.controls.mzComboEditor();
            this.unePrecioCostoMonedaReferencia = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.uneValorCotizacionProveedor = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.mzCEFuenteDeCambioProveedor = new mz.erp.ui.controls.mzComboEditor();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.unePrecioDeCostoMonedaProveedor = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.mzCEMonedaProveedor = new mz.erp.ui.controls.mzComboEditor();
            this.containerDatosVenta = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.groupNuevoCosto = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.unePrecioDeCostoReposicion1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.chkUsaPrecioDeCostoReposicion1 = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.labelSimboloMonedaPrecioDeCostoReposicion1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
            this.labelSimboloMonedaPrecioDeCosto4 = new System.Windows.Forms.Label();
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
            this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSimboloMonedaPrecioDeCostoReferenciaLP = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.unePrecioDeCostoRefLP = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label23 = new System.Windows.Forms.Label();
            this.unePrecioDeVentaNetoLP = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.labelSimboloMonedaPrecioDeVentaNetoLP = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.uneMACLP = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.gridListaDePrecios = new Janus.Windows.GridEX.GridEX();
            this.gridManagerView2 = new mz.erp.ui.controls.GridManagerView();
            this.imglStandar = new System.Windows.Forms.ImageList(this.components);
            this.toolBarStandar = new System.Windows.Forms.ToolBar();
            this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
            this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator3 = new System.Windows.Forms.ToolBarButton();
            this.tbbEliminarListaDePrecio = new System.Windows.Forms.ToolBarButton();
            this.ultraExplorerBar = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.ultraNumericEditor2 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.txtCodigoProductoProveedor = new System.Windows.Forms.TextBox();
            this.ultraLabel8 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraExplorerBarContainerControl2.SuspendLayout();
            this.containerProductos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.ultraExplorerBarContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaDePreciosProveedores)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePrecioCostoListaProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneBonificacion2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneBonificacion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCotizacionPrecioDeCostoProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePorcBonificacion2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePorcBonificacion3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePorcBonificacion4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePorcBonificacion5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePorcBonificacion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEFuenteDeCambioPrecioDeCostoProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEMonedaPrecioDeCostoProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoFinalProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneBonificacion5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneBonificacion4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneBonificacion3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.containerDatosCompra.SuspendLayout();
            this.groupMZ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoReposicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioPPCostoAnteriorMonedaProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoMonedaProducto)).BeginInit();
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
            this.groupDatosProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEFuenteDeCambioProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoAnteriorMonedaProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEMonedaReferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioCostoMonedaReferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneValorCotizacionProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEFuenteDeCambioProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoMonedaProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEMonedaProveedor)).BeginInit();
            this.containerDatosVenta.SuspendLayout();
            this.groupNuevoCosto.SuspendLayout();
            this.groupBox6.SuspendLayout();
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
            this.ultraExplorerBarContainerControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioFinalMonedaReferenciaLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeListaConImpuestoLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioVentaBrutoLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuentoLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuentoPorcentualLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficienteMonedaReferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficiente)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoRefLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeVentaNetoLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMACLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaDePrecios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar)).BeginInit();
            this.ultraExplorerBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor2)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraExplorerBarContainerControl2
            // 
            this.ultraExplorerBarContainerControl2.Controls.Add(this.labelTarea);
            this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
            this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(918, 42);
            this.ultraExplorerBarContainerControl2.TabIndex = 2;
            this.ultraExplorerBarContainerControl2.Visible = false;
            // 
            // labelTarea
            // 
            this.labelTarea.BackColor = System.Drawing.Color.Transparent;
            this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarea.Location = new System.Drawing.Point(0, 0);
            this.labelTarea.Name = "labelTarea";
            this.labelTarea.Size = new System.Drawing.Size(918, 23);
            this.labelTarea.TabIndex = 1;
            this.labelTarea.Text = "Tarea";
            this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // containerProductos
            // 
            this.containerProductos.Controls.Add(this.gridManagerView1);
            this.containerProductos.Controls.Add(this.panel1);
            this.containerProductos.Controls.Add(this.mzProductosControl);
            this.containerProductos.Controls.Add(this.gridProductos);
            this.containerProductos.Controls.Add(this.label9);
            this.containerProductos.Location = new System.Drawing.Point(28, -258);
            this.containerProductos.Name = "containerProductos";
            this.containerProductos.Size = new System.Drawing.Size(918, 252);
            this.containerProductos.TabIndex = 3;
            // 
            // gridManagerView1
            // 
            this.gridManagerView1.BackColor = System.Drawing.Color.Transparent;
            this.gridManagerView1.Location = new System.Drawing.Point(8, 48);
            this.gridManagerView1.Name = "gridManagerView1";
            this.gridManagerView1.Size = new System.Drawing.Size(872, 24);
            this.gridManagerView1.TabIndex = 1;
            this.gridManagerView1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.bNingunoCaja);
            this.panel1.Controls.Add(this.bTodosCaja);
            this.panel1.Controls.Add(this.rbSeleccionMultiple);
            this.panel1.Controls.Add(this.rbSeleccionSimple);
            this.panel1.Location = new System.Drawing.Point(8, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 32);
            this.panel1.TabIndex = 78;
            this.panel1.TabStop = false;
            // 
            // bNingunoCaja
            // 
            this.bNingunoCaja.AcceptsFocus = false;
            this.bNingunoCaja.Location = new System.Drawing.Point(400, 8);
            this.bNingunoCaja.Name = "bNingunoCaja";
            this.bNingunoCaja.Size = new System.Drawing.Size(64, 22);
            this.bNingunoCaja.TabIndex = 5;
            this.bNingunoCaja.TabStop = false;
            this.bNingunoCaja.Text = "&Ninguno";
            // 
            // bTodosCaja
            // 
            this.bTodosCaja.AcceptsFocus = false;
            this.bTodosCaja.Location = new System.Drawing.Point(336, 8);
            this.bTodosCaja.Name = "bTodosCaja";
            this.bTodosCaja.Size = new System.Drawing.Size(64, 22);
            this.bTodosCaja.TabIndex = 4;
            this.bTodosCaja.TabStop = false;
            this.bTodosCaja.Text = "&Todos";
            // 
            // rbSeleccionMultiple
            // 
            this.rbSeleccionMultiple.Location = new System.Drawing.Point(184, 11);
            this.rbSeleccionMultiple.Name = "rbSeleccionMultiple";
            this.rbSeleccionMultiple.Size = new System.Drawing.Size(152, 13);
            this.rbSeleccionMultiple.TabIndex = 3;
            this.rbSeleccionMultiple.Text = "Selección Múltiple";
            // 
            // rbSeleccionSimple
            // 
            this.rbSeleccionSimple.Location = new System.Drawing.Point(16, 11);
            this.rbSeleccionSimple.Name = "rbSeleccionSimple";
            this.rbSeleccionSimple.Size = new System.Drawing.Size(168, 13);
            this.rbSeleccionSimple.TabIndex = 2;
            this.rbSeleccionSimple.Text = "Selección Individual";
            // 
            // mzProductosControl
            // 
            this.mzProductosControl.BackColor = System.Drawing.Color.Transparent;
            this.mzProductosControl.EnabledCantidad = false;
            this.mzProductosControl.EnabledListaDePrecio = true;
            this.mzProductosControl.Location = new System.Drawing.Point(48, -6);
            this.mzProductosControl.Name = "mzProductosControl";
            this.mzProductosControl.PermiteProductosCombo = false;
            this.mzProductosControl.Size = new System.Drawing.Size(624, 48);
            this.mzProductosControl.TabIndex = 0;
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
            this.gridProductos.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridProductos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridProductos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gridProductos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridProductos.Location = new System.Drawing.Point(8, 104);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridProductos.Size = new System.Drawing.Size(904, 152);
            this.gridProductos.TabIndex = 6;
            this.gridProductos.TabStop = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(0, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 49;
            this.label9.Text = "Producto";
            // 
            // ultraExplorerBarContainerControl3
            // 
            this.ultraExplorerBarContainerControl3.Controls.Add(this.txtCodigoProductoProveedor);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.ultraLabel8);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.gridListaDePreciosProveedores);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.gridManagerView3);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.groupBox4);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.groupBox3);
            this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 51);
            this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
            this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(918, 361);
            this.ultraExplorerBarContainerControl3.TabIndex = 6;
            // 
            // gridListaDePreciosProveedores
            // 
            this.gridListaDePreciosProveedores.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridListaDePreciosProveedores.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridListaDePreciosProveedores.AlternatingColors = true;
            this.gridListaDePreciosProveedores.AutomaticSort = false;
            this.gridListaDePreciosProveedores.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat;
            this.gridListaDePreciosProveedores.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridListaDePreciosProveedores.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridListaDePreciosProveedores.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridListaDePreciosProveedores.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridListaDePreciosProveedores.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
            this.gridListaDePreciosProveedores.GroupByBoxVisible = false;
            this.gridListaDePreciosProveedores.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridListaDePreciosProveedores.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridListaDePreciosProveedores.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
            this.gridListaDePreciosProveedores.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
            this.gridListaDePreciosProveedores.Location = new System.Drawing.Point(-1, 32);
            this.gridListaDePreciosProveedores.Name = "gridListaDePreciosProveedores";
            this.gridListaDePreciosProveedores.RecordNavigatorText = "Registro:|de";
            this.gridListaDePreciosProveedores.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridListaDePreciosProveedores.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridListaDePreciosProveedores.ShowEmptyFields = false;
            this.gridListaDePreciosProveedores.Size = new System.Drawing.Size(913, 109);
            this.gridListaDePreciosProveedores.TabIndex = 2;
            this.gridListaDePreciosProveedores.TabStop = false;
            this.gridListaDePreciosProveedores.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            // 
            // gridManagerView3
            // 
            this.gridManagerView3.BackColor = System.Drawing.SystemColors.Control;
            this.gridManagerView3.Location = new System.Drawing.Point(0, 32);
            this.gridManagerView3.Name = "gridManagerView3";
            this.gridManagerView3.Size = new System.Drawing.Size(814, 24);
            this.gridManagerView3.TabIndex = 145;
            this.gridManagerView3.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.chckActualizaPcioCostoReposicion);
            this.groupBox4.Controls.Add(this.chckBonificacionesAcumulativas);
            this.groupBox4.Controls.Add(this.uneCoeficientePrecioCostoListaProveedor);
            this.groupBox4.Controls.Add(this.utbAolicaCoeficienteSobrePrecioCostoListaProveedor);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.uneBonificacion2);
            this.groupBox4.Controls.Add(this.uneBonificacion1);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.ultraLabel25);
            this.groupBox4.Controls.Add(this.ultraLabel26);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.uneCotizacionPrecioDeCostoProveedor);
            this.groupBox4.Controls.Add(this.ultraLabel19);
            this.groupBox4.Controls.Add(this.ultraLabel20);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.lbSimbololMonedaPrecioDeCostoProveedor);
            this.groupBox4.Controls.Add(this.unePrecioDeCostoProveedor);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.unePorcBonificacion2);
            this.groupBox4.Controls.Add(this.unePorcBonificacion3);
            this.groupBox4.Controls.Add(this.unePorcBonificacion4);
            this.groupBox4.Controls.Add(this.unePorcBonificacion5);
            this.groupBox4.Controls.Add(this.utbTrasladarPrecioDeCostoFinal);
            this.groupBox4.Controls.Add(this.ultraLabel21);
            this.groupBox4.Controls.Add(this.ultraLabel18);
            this.groupBox4.Controls.Add(this.unePorcBonificacion1);
            this.groupBox4.Controls.Add(this.mzCEFuenteDeCambioPrecioDeCostoProv);
            this.groupBox4.Controls.Add(this.mzCEMonedaPrecioDeCostoProv);
            this.groupBox4.Controls.Add(this.lbSimbololMonedaPrecioDeCostoFinalProveedor);
            this.groupBox4.Controls.Add(this.unePrecioDeCostoFinalProveedor);
            this.groupBox4.Controls.Add(this.ultraLabel27);
            this.groupBox4.Controls.Add(this.lblSimboloMonedaBonificacion5);
            this.groupBox4.Controls.Add(this.lblSimboloMonedaBonificacion4);
            this.groupBox4.Controls.Add(this.lblSimboloMonedaBonificacion3);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.ultraLabel22);
            this.groupBox4.Controls.Add(this.ultraLabel23);
            this.groupBox4.Controls.Add(this.ultraLabel24);
            this.groupBox4.Controls.Add(this.uneBonificacion5);
            this.groupBox4.Controls.Add(this.uneBonificacion4);
            this.groupBox4.Controls.Add(this.uneBonificacion3);
            this.groupBox4.Controls.Add(this.lblSimboloMonedaBonificacion2);
            this.groupBox4.Controls.Add(this.lblSimboloMonedaBonificacion1);
            this.groupBox4.Location = new System.Drawing.Point(0, 166);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(912, 186);
            this.groupBox4.TabIndex = 144;
            this.groupBox4.TabStop = false;
            // 
            // chckActualizaPcioCostoReposicion
            // 
            this.chckActualizaPcioCostoReposicion.Location = new System.Drawing.Point(8, 136);
            this.chckActualizaPcioCostoReposicion.Name = "chckActualizaPcioCostoReposicion";
            this.chckActualizaPcioCostoReposicion.Size = new System.Drawing.Size(208, 21);
            this.chckActualizaPcioCostoReposicion.TabIndex = 218;
            this.chckActualizaPcioCostoReposicion.Text = "Actualiza precio de costo reposición ";
            this.chckActualizaPcioCostoReposicion.Visible = false;
            // 
            // chckBonificacionesAcumulativas
            // 
            this.chckBonificacionesAcumulativas.Location = new System.Drawing.Point(8, 112);
            this.chckBonificacionesAcumulativas.Name = "chckBonificacionesAcumulativas";
            this.chckBonificacionesAcumulativas.Size = new System.Drawing.Size(184, 21);
            this.chckBonificacionesAcumulativas.TabIndex = 217;
            this.chckBonificacionesAcumulativas.Text = "Bonificaciones acumulativas";
            // 
            // uneCoeficientePrecioCostoListaProveedor
            // 
            this.uneCoeficientePrecioCostoListaProveedor.Location = new System.Drawing.Point(240, 16);
            this.uneCoeficientePrecioCostoListaProveedor.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.uneCoeficientePrecioCostoListaProveedor.MaskInput = "-nnn.nn";
            this.uneCoeficientePrecioCostoListaProveedor.Name = "uneCoeficientePrecioCostoListaProveedor";
            this.uneCoeficientePrecioCostoListaProveedor.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePrecioCostoListaProveedor.Size = new System.Drawing.Size(64, 21);
            this.uneCoeficientePrecioCostoListaProveedor.TabIndex = 148;
            this.uneCoeficientePrecioCostoListaProveedor.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // utbAolicaCoeficienteSobrePrecioCostoListaProveedor
            // 
            this.utbAolicaCoeficienteSobrePrecioCostoListaProveedor.AcceptsFocus = false;
            this.utbAolicaCoeficienteSobrePrecioCostoListaProveedor.Location = new System.Drawing.Point(320, 16);
            this.utbAolicaCoeficienteSobrePrecioCostoListaProveedor.Name = "utbAolicaCoeficienteSobrePrecioCostoListaProveedor";
            this.utbAolicaCoeficienteSobrePrecioCostoListaProveedor.Size = new System.Drawing.Size(24, 23);
            this.utbAolicaCoeficienteSobrePrecioCostoListaProveedor.TabIndex = 147;
            this.utbAolicaCoeficienteSobrePrecioCostoListaProveedor.TabStop = false;
            this.utbAolicaCoeficienteSobrePrecioCostoListaProveedor.Text = "->";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(304, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 146;
            this.label1.Text = "%";
            // 
            // uneBonificacion2
            // 
            this.uneBonificacion2.Location = new System.Drawing.Point(456, 40);
            this.uneBonificacion2.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.uneBonificacion2.MaskInput = "-nnnnnnnnn.nn";
            this.uneBonificacion2.Name = "uneBonificacion2";
            this.uneBonificacion2.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneBonificacion2.Size = new System.Drawing.Size(80, 21);
            this.uneBonificacion2.TabIndex = 117;
            this.uneBonificacion2.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneBonificacion1
            // 
            this.uneBonificacion1.Location = new System.Drawing.Point(456, 16);
            this.uneBonificacion1.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.uneBonificacion1.MaskInput = "-nnnnnnnnn.nn";
            this.uneBonificacion1.Name = "uneBonificacion1";
            this.uneBonificacion1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneBonificacion1.Size = new System.Drawing.Size(80, 21);
            this.uneBonificacion1.TabIndex = 115;
            this.uneBonificacion1.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(544, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 16);
            this.label20.TabIndex = 113;
            this.label20.Text = "%";
            // 
            // ultraLabel25
            // 
            this.ultraLabel25.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel25.Location = new System.Drawing.Point(344, 48);
            this.ultraLabel25.Name = "ultraLabel25";
            this.ultraLabel25.Size = new System.Drawing.Size(81, 16);
            this.ultraLabel25.TabIndex = 112;
            this.ultraLabel25.Text = "Bonificación 2";
            // 
            // ultraLabel26
            // 
            this.ultraLabel26.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel26.Location = new System.Drawing.Point(344, 24);
            this.ultraLabel26.Name = "ultraLabel26";
            this.ultraLabel26.Size = new System.Drawing.Size(81, 16);
            this.ultraLabel26.TabIndex = 111;
            this.ultraLabel26.Text = "Bonificación 1";
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(544, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(16, 16);
            this.label21.TabIndex = 114;
            this.label21.Text = "%";
            // 
            // uneCotizacionPrecioDeCostoProveedor
            // 
            this.uneCotizacionPrecioDeCostoProveedor.Location = new System.Drawing.Point(136, 88);
            this.uneCotizacionPrecioDeCostoProveedor.Name = "uneCotizacionPrecioDeCostoProveedor";
            this.uneCotizacionPrecioDeCostoProveedor.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCotizacionPrecioDeCostoProveedor.PromptChar = ' ';
            this.uneCotizacionPrecioDeCostoProveedor.Size = new System.Drawing.Size(100, 21);
            this.uneCotizacionPrecioDeCostoProveedor.TabIndex = 91;
            this.uneCotizacionPrecioDeCostoProveedor.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraLabel19
            // 
            this.ultraLabel19.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel19.Location = new System.Drawing.Point(8, 96);
            this.ultraLabel19.Name = "ultraLabel19";
            this.ultraLabel19.Size = new System.Drawing.Size(104, 16);
            this.ultraLabel19.TabIndex = 89;
            this.ultraLabel19.Text = "Valor Conversion";
            // 
            // ultraLabel20
            // 
            this.ultraLabel20.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel20.Location = new System.Drawing.Point(8, 72);
            this.ultraLabel20.Name = "ultraLabel20";
            this.ultraLabel20.Size = new System.Drawing.Size(120, 16);
            this.ultraLabel20.TabIndex = 88;
            this.ultraLabel20.Text = "Fuente de Cambio";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(544, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 16);
            this.label17.TabIndex = 130;
            this.label17.Text = "%";
            // 
            // lbSimbololMonedaPrecioDeCostoProveedor
            // 
            this.lbSimbololMonedaPrecioDeCostoProveedor.BackColor = System.Drawing.Color.Transparent;
            this.lbSimbololMonedaPrecioDeCostoProveedor.Location = new System.Drawing.Point(96, 24);
            this.lbSimbololMonedaPrecioDeCostoProveedor.Name = "lbSimbololMonedaPrecioDeCostoProveedor";
            this.lbSimbololMonedaPrecioDeCostoProveedor.Size = new System.Drawing.Size(32, 16);
            this.lbSimbololMonedaPrecioDeCostoProveedor.TabIndex = 86;
            this.lbSimbololMonedaPrecioDeCostoProveedor.Text = "$";
            this.lbSimbololMonedaPrecioDeCostoProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unePrecioDeCostoProveedor
            // 
            this.unePrecioDeCostoProveedor.Location = new System.Drawing.Point(136, 16);
            this.unePrecioDeCostoProveedor.Name = "unePrecioDeCostoProveedor";
            this.unePrecioDeCostoProveedor.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioDeCostoProveedor.PromptChar = ' ';
            this.unePrecioDeCostoProveedor.Size = new System.Drawing.Size(100, 21);
            this.unePrecioDeCostoProveedor.TabIndex = 84;
            this.unePrecioDeCostoProveedor.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(544, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 16);
            this.label14.TabIndex = 131;
            this.label14.Text = "%";
            // 
            // unePorcBonificacion2
            // 
            this.unePorcBonificacion2.Location = new System.Drawing.Point(560, 40);
            this.unePorcBonificacion2.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.unePorcBonificacion2.MaskInput = "-nnn.nnnn";
            this.unePorcBonificacion2.Name = "unePorcBonificacion2";
            this.unePorcBonificacion2.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePorcBonificacion2.Size = new System.Drawing.Size(72, 21);
            this.unePorcBonificacion2.TabIndex = 118;
            this.unePorcBonificacion2.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // unePorcBonificacion3
            // 
            this.unePorcBonificacion3.Location = new System.Drawing.Point(560, 64);
            this.unePorcBonificacion3.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.unePorcBonificacion3.MaskInput = "-nnn.nnnn";
            this.unePorcBonificacion3.Name = "unePorcBonificacion3";
            this.unePorcBonificacion3.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePorcBonificacion3.Size = new System.Drawing.Size(72, 21);
            this.unePorcBonificacion3.TabIndex = 122;
            this.unePorcBonificacion3.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // unePorcBonificacion4
            // 
            this.unePorcBonificacion4.Location = new System.Drawing.Point(560, 88);
            this.unePorcBonificacion4.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.unePorcBonificacion4.MaskInput = "-nnn.nnnn";
            this.unePorcBonificacion4.Name = "unePorcBonificacion4";
            this.unePorcBonificacion4.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePorcBonificacion4.Size = new System.Drawing.Size(72, 21);
            this.unePorcBonificacion4.TabIndex = 124;
            this.unePorcBonificacion4.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // unePorcBonificacion5
            // 
            this.unePorcBonificacion5.Location = new System.Drawing.Point(560, 112);
            this.unePorcBonificacion5.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.unePorcBonificacion5.MaskInput = "-nnn.nnnn";
            this.unePorcBonificacion5.Name = "unePorcBonificacion5";
            this.unePorcBonificacion5.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePorcBonificacion5.Size = new System.Drawing.Size(72, 21);
            this.unePorcBonificacion5.TabIndex = 126;
            this.unePorcBonificacion5.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // utbTrasladarPrecioDeCostoFinal
            // 
            this.utbTrasladarPrecioDeCostoFinal.AcceptsFocus = false;
            this.utbTrasladarPrecioDeCostoFinal.Location = new System.Drawing.Point(640, 152);
            this.utbTrasladarPrecioDeCostoFinal.Name = "utbTrasladarPrecioDeCostoFinal";
            this.utbTrasladarPrecioDeCostoFinal.Size = new System.Drawing.Size(24, 23);
            this.utbTrasladarPrecioDeCostoFinal.TabIndex = 141;
            this.utbTrasladarPrecioDeCostoFinal.TabStop = false;
            this.utbTrasladarPrecioDeCostoFinal.Text = "->";
            // 
            // ultraLabel21
            // 
            this.ultraLabel21.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel21.Location = new System.Drawing.Point(8, 48);
            this.ultraLabel21.Name = "ultraLabel21";
            this.ultraLabel21.Size = new System.Drawing.Size(72, 16);
            this.ultraLabel21.TabIndex = 87;
            this.ultraLabel21.Text = "Moneda";
            // 
            // ultraLabel18
            // 
            this.ultraLabel18.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel18.Location = new System.Drawing.Point(8, 24);
            this.ultraLabel18.Name = "ultraLabel18";
            this.ultraLabel18.Size = new System.Drawing.Size(88, 16);
            this.ultraLabel18.TabIndex = 85;
            this.ultraLabel18.Text = "Precio de Costo";
            // 
            // unePorcBonificacion1
            // 
            this.unePorcBonificacion1.Location = new System.Drawing.Point(560, 16);
            this.unePorcBonificacion1.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.unePorcBonificacion1.MaskInput = "-nnn.nnnn";
            this.unePorcBonificacion1.Name = "unePorcBonificacion1";
            this.unePorcBonificacion1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePorcBonificacion1.Size = new System.Drawing.Size(72, 21);
            this.unePorcBonificacion1.TabIndex = 116;
            this.unePorcBonificacion1.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // mzCEFuenteDeCambioPrecioDeCostoProv
            // 
            this.mzCEFuenteDeCambioPrecioDeCostoProv.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEFuenteDeCambioPrecioDeCostoProv.DisplayMember = "";
            this.mzCEFuenteDeCambioPrecioDeCostoProv.DisplayMemberCaption = "";
            this.mzCEFuenteDeCambioPrecioDeCostoProv.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEFuenteDeCambioPrecioDeCostoProv.Location = new System.Drawing.Point(136, 64);
            this.mzCEFuenteDeCambioPrecioDeCostoProv.MaxItemsDisplay = 8;
            this.mzCEFuenteDeCambioPrecioDeCostoProv.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEFuenteDeCambioPrecioDeCostoProv.Name = "mzCEFuenteDeCambioPrecioDeCostoProv";
            this.mzCEFuenteDeCambioPrecioDeCostoProv.Size = new System.Drawing.Size(167, 21);
            this.mzCEFuenteDeCambioPrecioDeCostoProv.SorterMember = "";
            this.mzCEFuenteDeCambioPrecioDeCostoProv.TabIndex = 140;
            this.mzCEFuenteDeCambioPrecioDeCostoProv.ValueMember = "";
            this.mzCEFuenteDeCambioPrecioDeCostoProv.ValueMemberCaption = "";
            // 
            // mzCEMonedaPrecioDeCostoProv
            // 
            this.mzCEMonedaPrecioDeCostoProv.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEMonedaPrecioDeCostoProv.DisplayMember = "";
            this.mzCEMonedaPrecioDeCostoProv.DisplayMemberCaption = "";
            this.mzCEMonedaPrecioDeCostoProv.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEMonedaPrecioDeCostoProv.Location = new System.Drawing.Point(136, 40);
            this.mzCEMonedaPrecioDeCostoProv.MaxItemsDisplay = 8;
            this.mzCEMonedaPrecioDeCostoProv.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEMonedaPrecioDeCostoProv.Name = "mzCEMonedaPrecioDeCostoProv";
            this.mzCEMonedaPrecioDeCostoProv.Size = new System.Drawing.Size(167, 21);
            this.mzCEMonedaPrecioDeCostoProv.SorterMember = "";
            this.mzCEMonedaPrecioDeCostoProv.TabIndex = 139;
            this.mzCEMonedaPrecioDeCostoProv.ValueMember = "";
            this.mzCEMonedaPrecioDeCostoProv.ValueMemberCaption = "";
            // 
            // lbSimbololMonedaPrecioDeCostoFinalProveedor
            // 
            this.lbSimbololMonedaPrecioDeCostoFinalProveedor.BackColor = System.Drawing.Color.Transparent;
            this.lbSimbololMonedaPrecioDeCostoFinalProveedor.Location = new System.Drawing.Point(496, 160);
            this.lbSimbololMonedaPrecioDeCostoFinalProveedor.Name = "lbSimbololMonedaPrecioDeCostoFinalProveedor";
            this.lbSimbololMonedaPrecioDeCostoFinalProveedor.Size = new System.Drawing.Size(32, 16);
            this.lbSimbololMonedaPrecioDeCostoFinalProveedor.TabIndex = 138;
            this.lbSimbololMonedaPrecioDeCostoFinalProveedor.Text = "$";
            this.lbSimbololMonedaPrecioDeCostoFinalProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unePrecioDeCostoFinalProveedor
            // 
            this.unePrecioDeCostoFinalProveedor.Location = new System.Drawing.Point(536, 152);
            this.unePrecioDeCostoFinalProveedor.Name = "unePrecioDeCostoFinalProveedor";
            this.unePrecioDeCostoFinalProveedor.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioDeCostoFinalProveedor.PromptChar = ' ';
            this.unePrecioDeCostoFinalProveedor.Size = new System.Drawing.Size(100, 21);
            this.unePrecioDeCostoFinalProveedor.TabIndex = 137;
            this.unePrecioDeCostoFinalProveedor.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraLabel27
            // 
            this.ultraLabel27.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel27.Location = new System.Drawing.Point(384, 160);
            this.ultraLabel27.Name = "ultraLabel27";
            this.ultraLabel27.Size = new System.Drawing.Size(120, 16);
            this.ultraLabel27.TabIndex = 136;
            this.ultraLabel27.Text = "Precio de Costo Final";
            // 
            // lblSimboloMonedaBonificacion5
            // 
            this.lblSimboloMonedaBonificacion5.BackColor = System.Drawing.Color.Transparent;
            this.lblSimboloMonedaBonificacion5.Location = new System.Drawing.Point(432, 120);
            this.lblSimboloMonedaBonificacion5.Name = "lblSimboloMonedaBonificacion5";
            this.lblSimboloMonedaBonificacion5.Size = new System.Drawing.Size(24, 16);
            this.lblSimboloMonedaBonificacion5.TabIndex = 135;
            this.lblSimboloMonedaBonificacion5.Text = "$";
            this.lblSimboloMonedaBonificacion5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSimboloMonedaBonificacion4
            // 
            this.lblSimboloMonedaBonificacion4.BackColor = System.Drawing.Color.Transparent;
            this.lblSimboloMonedaBonificacion4.Location = new System.Drawing.Point(432, 96);
            this.lblSimboloMonedaBonificacion4.Name = "lblSimboloMonedaBonificacion4";
            this.lblSimboloMonedaBonificacion4.Size = new System.Drawing.Size(24, 16);
            this.lblSimboloMonedaBonificacion4.TabIndex = 134;
            this.lblSimboloMonedaBonificacion4.Text = "$";
            this.lblSimboloMonedaBonificacion4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSimboloMonedaBonificacion3
            // 
            this.lblSimboloMonedaBonificacion3.BackColor = System.Drawing.Color.Transparent;
            this.lblSimboloMonedaBonificacion3.Location = new System.Drawing.Point(432, 72);
            this.lblSimboloMonedaBonificacion3.Name = "lblSimboloMonedaBonificacion3";
            this.lblSimboloMonedaBonificacion3.Size = new System.Drawing.Size(24, 16);
            this.lblSimboloMonedaBonificacion3.TabIndex = 133;
            this.lblSimboloMonedaBonificacion3.Text = "$";
            this.lblSimboloMonedaBonificacion3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(544, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 132;
            this.label6.Text = "%";
            // 
            // ultraLabel22
            // 
            this.ultraLabel22.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel22.Location = new System.Drawing.Point(344, 120);
            this.ultraLabel22.Name = "ultraLabel22";
            this.ultraLabel22.Size = new System.Drawing.Size(81, 16);
            this.ultraLabel22.TabIndex = 129;
            this.ultraLabel22.Text = "Bonificación 5";
            // 
            // ultraLabel23
            // 
            this.ultraLabel23.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel23.Location = new System.Drawing.Point(344, 96);
            this.ultraLabel23.Name = "ultraLabel23";
            this.ultraLabel23.Size = new System.Drawing.Size(81, 16);
            this.ultraLabel23.TabIndex = 128;
            this.ultraLabel23.Text = "Bonificación 4";
            // 
            // ultraLabel24
            // 
            this.ultraLabel24.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel24.Location = new System.Drawing.Point(344, 72);
            this.ultraLabel24.Name = "ultraLabel24";
            this.ultraLabel24.Size = new System.Drawing.Size(81, 16);
            this.ultraLabel24.TabIndex = 127;
            this.ultraLabel24.Text = "Bonificación 3";
            // 
            // uneBonificacion5
            // 
            this.uneBonificacion5.Location = new System.Drawing.Point(456, 112);
            this.uneBonificacion5.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.uneBonificacion5.MaskInput = "-nnnnnnnnn.nn";
            this.uneBonificacion5.Name = "uneBonificacion5";
            this.uneBonificacion5.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneBonificacion5.Size = new System.Drawing.Size(80, 21);
            this.uneBonificacion5.TabIndex = 125;
            this.uneBonificacion5.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneBonificacion4
            // 
            this.uneBonificacion4.Location = new System.Drawing.Point(456, 88);
            this.uneBonificacion4.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.uneBonificacion4.MaskInput = "-nnnnnnnnn.nn";
            this.uneBonificacion4.Name = "uneBonificacion4";
            this.uneBonificacion4.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneBonificacion4.Size = new System.Drawing.Size(80, 21);
            this.uneBonificacion4.TabIndex = 123;
            this.uneBonificacion4.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneBonificacion3
            // 
            this.uneBonificacion3.Location = new System.Drawing.Point(456, 64);
            this.uneBonificacion3.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.uneBonificacion3.MaskInput = "-nnnnnnnnn.nn";
            this.uneBonificacion3.Name = "uneBonificacion3";
            this.uneBonificacion3.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneBonificacion3.Size = new System.Drawing.Size(80, 21);
            this.uneBonificacion3.TabIndex = 120;
            this.uneBonificacion3.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // lblSimboloMonedaBonificacion2
            // 
            this.lblSimboloMonedaBonificacion2.BackColor = System.Drawing.Color.Transparent;
            this.lblSimboloMonedaBonificacion2.Location = new System.Drawing.Point(432, 48);
            this.lblSimboloMonedaBonificacion2.Name = "lblSimboloMonedaBonificacion2";
            this.lblSimboloMonedaBonificacion2.Size = new System.Drawing.Size(24, 16);
            this.lblSimboloMonedaBonificacion2.TabIndex = 121;
            this.lblSimboloMonedaBonificacion2.Text = "$";
            this.lblSimboloMonedaBonificacion2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSimboloMonedaBonificacion1
            // 
            this.lblSimboloMonedaBonificacion1.BackColor = System.Drawing.Color.Transparent;
            this.lblSimboloMonedaBonificacion1.Location = new System.Drawing.Point(432, 24);
            this.lblSimboloMonedaBonificacion1.Name = "lblSimboloMonedaBonificacion1";
            this.lblSimboloMonedaBonificacion1.Size = new System.Drawing.Size(24, 16);
            this.lblSimboloMonedaBonificacion1.TabIndex = 119;
            this.lblSimboloMonedaBonificacion1.Text = "$";
            this.lblSimboloMonedaBonificacion1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.mzCmbProveedor);
            this.groupBox3.Controls.Add(this.btnEliminarListaDePreciosProv);
            this.groupBox3.Controls.Add(this.ultraLabel17);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(912, 32);
            this.groupBox3.TabIndex = 142;
            this.groupBox3.TabStop = false;
            // 
            // mzCmbProveedor
            // 
            this.mzCmbProveedor.BackColor = System.Drawing.SystemColors.Control;
            this.mzCmbProveedor.DataValue = "";
            this.mzCmbProveedor.EnableCtaCte = false;
            this.mzCmbProveedor.FastSearch = false;
            this.mzCmbProveedor.Location = new System.Drawing.Point(88, 7);
            this.mzCmbProveedor.Name = "mzCmbProveedor";
            this.mzCmbProveedor.SearchObjectListener = null;
            this.mzCmbProveedor.Size = new System.Drawing.Size(490, 31);
            this.mzCmbProveedor.TabIndex = 0;
            this.mzCmbProveedor.Tag = "Proveedor";
            // 
            // btnEliminarListaDePreciosProv
            // 
            this.btnEliminarListaDePreciosProv.AcceptsFocus = false;
            this.btnEliminarListaDePreciosProv.Location = new System.Drawing.Point(584, 8);
            this.btnEliminarListaDePreciosProv.Name = "btnEliminarListaDePreciosProv";
            this.btnEliminarListaDePreciosProv.Size = new System.Drawing.Size(64, 22);
            this.btnEliminarListaDePreciosProv.TabIndex = 1;
            this.btnEliminarListaDePreciosProv.TabStop = false;
            this.btnEliminarListaDePreciosProv.Text = "Eliminar";
            this.btnEliminarListaDePreciosProv.Click += new System.EventHandler(this.btnEliminarListaDePreciosProv_Click);
            // 
            // ultraLabel17
            // 
            this.ultraLabel17.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel17.Location = new System.Drawing.Point(16, 12);
            this.ultraLabel17.Name = "ultraLabel17";
            this.ultraLabel17.Size = new System.Drawing.Size(62, 16);
            this.ultraLabel17.TabIndex = 15;
            this.ultraLabel17.Text = "Proveedor";
            // 
            // containerDatosCompra
            // 
            this.containerDatosCompra.Controls.Add(this.groupMZ);
            this.containerDatosCompra.Controls.Add(this.groupDatosProveedor);
            this.containerDatosCompra.Location = new System.Drawing.Point(28, 469);
            this.containerDatosCompra.Name = "containerDatosCompra";
            this.containerDatosCompra.Size = new System.Drawing.Size(918, 259);
            this.containerDatosCompra.TabIndex = 0;
            // 
            // groupMZ
            // 
            this.groupMZ.BackColor = System.Drawing.Color.Transparent;
            this.groupMZ.Controls.Add(this.labelSimboloMonedaPrecioDeCostoReposicion);
            this.groupMZ.Controls.Add(this.labelSimboloMonedaPrecioDeCosto3);
            this.groupMZ.Controls.Add(this.labelSimboloMonedaPrecioDeCosto1);
            this.groupMZ.Controls.Add(this.labeSimbololMonedaPrecioDeCosto);
            this.groupMZ.Controls.Add(this.chkUsaPrecioDeCostoReposicion);
            this.groupMZ.Controls.Add(this.label63);
            this.groupMZ.Controls.Add(this.unePrecioDeCostoReposicion);
            this.groupMZ.Controls.Add(this.unePrecioPPCostoAnteriorMonedaProducto);
            this.groupMZ.Controls.Add(this.uneStock);
            this.groupMZ.Controls.Add(this.unePrecioDeCostoMonedaProducto);
            this.groupMZ.Controls.Add(this.ultraLabel6);
            this.groupMZ.Controls.Add(this.ultraLabel12);
            this.groupMZ.Controls.Add(this.unePCostoPromedioPonderado);
            this.groupMZ.Controls.Add(this.ultraLabel11);
            this.groupMZ.Controls.Add(this.ultraLabel10);
            this.groupMZ.Controls.Add(this.panelCostosIndirectos);
            this.groupMZ.Controls.Add(this.groupBox5);
            this.groupMZ.Location = new System.Drawing.Point(0, 88);
            this.groupMZ.Name = "groupMZ";
            this.groupMZ.Size = new System.Drawing.Size(918, 166);
            this.groupMZ.TabIndex = 22;
            this.groupMZ.TabStop = false;
            this.groupMZ.Text = "Nuevo Costo";
            // 
            // labelSimboloMonedaPrecioDeCostoReposicion
            // 
            this.labelSimboloMonedaPrecioDeCostoReposicion.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeCostoReposicion.Location = new System.Drawing.Point(206, 113);
            this.labelSimboloMonedaPrecioDeCostoReposicion.Name = "labelSimboloMonedaPrecioDeCostoReposicion";
            this.labelSimboloMonedaPrecioDeCostoReposicion.Size = new System.Drawing.Size(32, 16);
            this.labelSimboloMonedaPrecioDeCostoReposicion.TabIndex = 150;
            this.labelSimboloMonedaPrecioDeCostoReposicion.Text = "$";
            this.labelSimboloMonedaPrecioDeCostoReposicion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaPrecioDeCosto3
            // 
            this.labelSimboloMonedaPrecioDeCosto3.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeCosto3.Location = new System.Drawing.Point(206, 91);
            this.labelSimboloMonedaPrecioDeCosto3.Name = "labelSimboloMonedaPrecioDeCosto3";
            this.labelSimboloMonedaPrecioDeCosto3.Size = new System.Drawing.Size(32, 17);
            this.labelSimboloMonedaPrecioDeCosto3.TabIndex = 80;
            this.labelSimboloMonedaPrecioDeCosto3.Text = "$";
            this.labelSimboloMonedaPrecioDeCosto3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaPrecioDeCosto1
            // 
            this.labelSimboloMonedaPrecioDeCosto1.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeCosto1.Location = new System.Drawing.Point(206, 54);
            this.labelSimboloMonedaPrecioDeCosto1.Name = "labelSimboloMonedaPrecioDeCosto1";
            this.labelSimboloMonedaPrecioDeCosto1.Size = new System.Drawing.Size(32, 19);
            this.labelSimboloMonedaPrecioDeCosto1.TabIndex = 79;
            this.labelSimboloMonedaPrecioDeCosto1.Text = "$";
            this.labelSimboloMonedaPrecioDeCosto1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labeSimbololMonedaPrecioDeCosto
            // 
            this.labeSimbololMonedaPrecioDeCosto.BackColor = System.Drawing.Color.Transparent;
            this.labeSimbololMonedaPrecioDeCosto.Location = new System.Drawing.Point(206, 17);
            this.labeSimbololMonedaPrecioDeCosto.Name = "labeSimbololMonedaPrecioDeCosto";
            this.labeSimbololMonedaPrecioDeCosto.Size = new System.Drawing.Size(32, 16);
            this.labeSimbololMonedaPrecioDeCosto.TabIndex = 83;
            this.labeSimbololMonedaPrecioDeCosto.Text = "$";
            this.labeSimbololMonedaPrecioDeCosto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkUsaPrecioDeCostoReposicion
            // 
            this.chkUsaPrecioDeCostoReposicion.BackColor = System.Drawing.Color.Transparent;
            this.chkUsaPrecioDeCostoReposicion.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkUsaPrecioDeCostoReposicion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkUsaPrecioDeCostoReposicion.Location = new System.Drawing.Point(13, 130);
            this.chkUsaPrecioDeCostoReposicion.Name = "chkUsaPrecioDeCostoReposicion";
            this.chkUsaPrecioDeCostoReposicion.Size = new System.Drawing.Size(244, 20);
            this.chkUsaPrecioDeCostoReposicion.TabIndex = 151;
            this.chkUsaPrecioDeCostoReposicion.Text = "Usa Precio de Costo Reposición";
            // 
            // label63
            // 
            this.label63.BackColor = System.Drawing.Color.Transparent;
            this.label63.Location = new System.Drawing.Point(13, 113);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(184, 16);
            this.label63.TabIndex = 149;
            this.label63.Text = "Precio de Costo de Reposición";
            // 
            // unePrecioDeCostoReposicion
            // 
            this.unePrecioDeCostoReposicion.Location = new System.Drawing.Point(246, 109);
            this.unePrecioDeCostoReposicion.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.unePrecioDeCostoReposicion.MaskInput = "-nnnnnnnnn.nn";
            this.unePrecioDeCostoReposicion.Name = "unePrecioDeCostoReposicion";
            this.unePrecioDeCostoReposicion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioDeCostoReposicion.Size = new System.Drawing.Size(100, 21);
            this.unePrecioDeCostoReposicion.TabIndex = 148;
            this.unePrecioDeCostoReposicion.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // unePrecioPPCostoAnteriorMonedaProducto
            // 
            this.unePrecioPPCostoAnteriorMonedaProducto.Location = new System.Drawing.Point(246, 53);
            this.unePrecioPPCostoAnteriorMonedaProducto.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.unePrecioPPCostoAnteriorMonedaProducto.MaskInput = "-nnnnnnnnn.nn";
            this.unePrecioPPCostoAnteriorMonedaProducto.Name = "unePrecioPPCostoAnteriorMonedaProducto";
            this.unePrecioPPCostoAnteriorMonedaProducto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioPPCostoAnteriorMonedaProducto.PromptChar = ' ';
            this.unePrecioPPCostoAnteriorMonedaProducto.Size = new System.Drawing.Size(100, 21);
            this.unePrecioPPCostoAnteriorMonedaProducto.TabIndex = 10;
            this.unePrecioPPCostoAnteriorMonedaProducto.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneStock
            // 
            this.uneStock.FormatString = "";
            this.uneStock.Location = new System.Drawing.Point(246, 33);
            this.uneStock.Name = "uneStock";
            this.uneStock.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneStock.PromptChar = ' ';
            this.uneStock.Size = new System.Drawing.Size(100, 21);
            this.uneStock.TabIndex = 9;
            this.uneStock.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // unePrecioDeCostoMonedaProducto
            // 
            this.unePrecioDeCostoMonedaProducto.Location = new System.Drawing.Point(246, 13);
            this.unePrecioDeCostoMonedaProducto.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.unePrecioDeCostoMonedaProducto.MaskInput = "-nnnnnnnnn.nn";
            this.unePrecioDeCostoMonedaProducto.Name = "unePrecioDeCostoMonedaProducto";
            this.unePrecioDeCostoMonedaProducto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioDeCostoMonedaProducto.PromptChar = ' ';
            this.unePrecioDeCostoMonedaProducto.Size = new System.Drawing.Size(100, 21);
            this.unePrecioDeCostoMonedaProducto.TabIndex = 81;
            this.unePrecioDeCostoMonedaProducto.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraLabel6
            // 
            this.ultraLabel6.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel6.Location = new System.Drawing.Point(13, 18);
            this.ultraLabel6.Name = "ultraLabel6";
            this.ultraLabel6.Size = new System.Drawing.Size(92, 16);
            this.ultraLabel6.TabIndex = 82;
            this.ultraLabel6.Text = "Precio de Costo";
            // 
            // ultraLabel12
            // 
            this.ultraLabel12.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel12.Location = new System.Drawing.Point(13, 93);
            this.ultraLabel12.Name = "ultraLabel12";
            this.ultraLabel12.Size = new System.Drawing.Size(195, 15);
            this.ultraLabel12.TabIndex = 76;
            this.ultraLabel12.Text = "Precio de Costo Promedio Ponderado";
            // 
            // unePCostoPromedioPonderado
            // 
            this.unePCostoPromedioPonderado.Location = new System.Drawing.Point(246, 89);
            this.unePCostoPromedioPonderado.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.unePCostoPromedioPonderado.MaskInput = "-nnnnnnnnn.nn";
            this.unePCostoPromedioPonderado.Name = "unePCostoPromedioPonderado";
            this.unePCostoPromedioPonderado.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePCostoPromedioPonderado.PromptChar = ' ';
            this.unePCostoPromedioPonderado.Size = new System.Drawing.Size(100, 21);
            this.unePCostoPromedioPonderado.TabIndex = 11;
            this.unePCostoPromedioPonderado.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraLabel11
            // 
            this.ultraLabel11.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel11.Location = new System.Drawing.Point(13, 56);
            this.ultraLabel11.Name = "ultraLabel11";
            this.ultraLabel11.Size = new System.Drawing.Size(187, 13);
            this.ultraLabel11.TabIndex = 72;
            this.ultraLabel11.Text = "Costo Promedio Ponderado Anterior";
            // 
            // ultraLabel10
            // 
            this.ultraLabel10.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel10.Location = new System.Drawing.Point(13, 36);
            this.ultraLabel10.Name = "ultraLabel10";
            this.ultraLabel10.Size = new System.Drawing.Size(107, 19);
            this.ultraLabel10.TabIndex = 70;
            this.ultraLabel10.Text = "Stock Disponible";
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
            this.chkCoef5.TabIndex = 228;
            this.chkCoef5.Text = "Activo";
            // 
            // chkCoef4
            // 
            this.chkCoef4.Location = new System.Drawing.Point(364, 68);
            this.chkCoef4.Name = "chkCoef4";
            this.chkCoef4.Size = new System.Drawing.Size(76, 21);
            this.chkCoef4.TabIndex = 225;
            this.chkCoef4.Text = "Activo";
            // 
            // chkCoef3
            // 
            this.chkCoef3.Location = new System.Drawing.Point(364, 49);
            this.chkCoef3.Name = "chkCoef3";
            this.chkCoef3.Size = new System.Drawing.Size(76, 21);
            this.chkCoef3.TabIndex = 222;
            this.chkCoef3.Text = "Activo";
            // 
            // chkCoef2
            // 
            this.chkCoef2.Location = new System.Drawing.Point(364, 28);
            this.chkCoef2.Name = "chkCoef2";
            this.chkCoef2.Size = new System.Drawing.Size(76, 21);
            this.chkCoef2.TabIndex = 219;
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
            this.uneCoeficientePorc5.TabIndex = 227;
            this.uneCoeficientePorc5.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficientePorc4
            // 
            this.uneCoeficientePorc4.Location = new System.Drawing.Point(276, 68);
            this.uneCoeficientePorc4.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc4.Name = "uneCoeficientePorc4";
            this.uneCoeficientePorc4.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc4.Size = new System.Drawing.Size(72, 21);
            this.uneCoeficientePorc4.TabIndex = 224;
            this.uneCoeficientePorc4.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficientePorc3
            // 
            this.uneCoeficientePorc3.Location = new System.Drawing.Point(276, 48);
            this.uneCoeficientePorc3.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc3.Name = "uneCoeficientePorc3";
            this.uneCoeficientePorc3.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc3.Size = new System.Drawing.Size(72, 21);
            this.uneCoeficientePorc3.TabIndex = 221;
            this.uneCoeficientePorc3.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficientePorc2
            // 
            this.uneCoeficientePorc2.Location = new System.Drawing.Point(276, 28);
            this.uneCoeficientePorc2.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc2.Name = "uneCoeficientePorc2";
            this.uneCoeficientePorc2.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc2.Size = new System.Drawing.Size(72, 21);
            this.uneCoeficientePorc2.TabIndex = 218;
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
            this.uneCoeficiente5.TabIndex = 226;
            this.uneCoeficiente5.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficiente4
            // 
            this.uneCoeficiente4.Location = new System.Drawing.Point(172, 68);
            this.uneCoeficiente4.MaskInput = "nnnnnnn.nn";
            this.uneCoeficiente4.Name = "uneCoeficiente4";
            this.uneCoeficiente4.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficiente4.Size = new System.Drawing.Size(80, 21);
            this.uneCoeficiente4.TabIndex = 223;
            this.uneCoeficiente4.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficiente3
            // 
            this.uneCoeficiente3.Location = new System.Drawing.Point(172, 48);
            this.uneCoeficiente3.MaskInput = "nnnnnnn.nn";
            this.uneCoeficiente3.Name = "uneCoeficiente3";
            this.uneCoeficiente3.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficiente3.Size = new System.Drawing.Size(80, 21);
            this.uneCoeficiente3.TabIndex = 220;
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
            this.uneCoeficienteTotal.TabIndex = 245;
            this.uneCoeficienteTotal.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficiente2
            // 
            this.uneCoeficiente2.Location = new System.Drawing.Point(172, 28);
            this.uneCoeficiente2.MaskInput = "nnnnnnn.nn";
            this.uneCoeficiente2.Name = "uneCoeficiente2";
            this.uneCoeficiente2.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficiente2.Size = new System.Drawing.Size(80, 21);
            this.uneCoeficiente2.TabIndex = 217;
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
            this.chkCoef1.TabIndex = 216;
            this.chkCoef1.Text = "Activo";
            // 
            // uneCoeficientePorc1
            // 
            this.uneCoeficientePorc1.Location = new System.Drawing.Point(276, 8);
            this.uneCoeficientePorc1.MaskInput = "nnn.nnnn";
            this.uneCoeficientePorc1.Name = "uneCoeficientePorc1";
            this.uneCoeficientePorc1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficientePorc1.Size = new System.Drawing.Size(72, 21);
            this.uneCoeficientePorc1.TabIndex = 215;
            this.uneCoeficientePorc1.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneCoeficiente1
            // 
            this.uneCoeficiente1.Location = new System.Drawing.Point(172, 8);
            this.uneCoeficiente1.MaskInput = "nnnnnnn.nn";
            this.uneCoeficiente1.Name = "uneCoeficiente1";
            this.uneCoeficiente1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCoeficiente1.Size = new System.Drawing.Size(80, 21);
            this.uneCoeficiente1.TabIndex = 214;
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
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(9, 79);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(345, 79);
            this.groupBox5.TabIndex = 152;
            this.groupBox5.TabStop = false;
            // 
            // groupDatosProveedor
            // 
            this.groupDatosProveedor.BackColor = System.Drawing.Color.Transparent;
            this.groupDatosProveedor.Controls.Add(this.mzCEFuenteDeCambioProducto);
            this.groupDatosProveedor.Controls.Add(this.labelSimboloMonedaOrigen);
            this.groupDatosProveedor.Controls.Add(this.unePrecioDeCostoAnteriorMonedaProducto);
            this.groupDatosProveedor.Controls.Add(this.ultraLabel14);
            this.groupDatosProveedor.Controls.Add(this.labelSimboloMonedaReferencia);
            this.groupDatosProveedor.Controls.Add(this.labelSimboloMonedaProveedor);
            this.groupDatosProveedor.Controls.Add(this.mzCEMonedaReferencia);
            this.groupDatosProveedor.Controls.Add(this.unePrecioCostoMonedaReferencia);
            this.groupDatosProveedor.Controls.Add(this.ultraLabel5);
            this.groupDatosProveedor.Controls.Add(this.uneValorCotizacionProveedor);
            this.groupDatosProveedor.Controls.Add(this.ultraLabel4);
            this.groupDatosProveedor.Controls.Add(this.ultraLabel3);
            this.groupDatosProveedor.Controls.Add(this.mzCEFuenteDeCambioProveedor);
            this.groupDatosProveedor.Controls.Add(this.ultraLabel1);
            this.groupDatosProveedor.Controls.Add(this.unePrecioDeCostoMonedaProveedor);
            this.groupDatosProveedor.Controls.Add(this.ultraLabel2);
            this.groupDatosProveedor.Controls.Add(this.mzCEMonedaProveedor);
            this.groupDatosProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupDatosProveedor.Location = new System.Drawing.Point(0, 0);
            this.groupDatosProveedor.Name = "groupDatosProveedor";
            this.groupDatosProveedor.Size = new System.Drawing.Size(918, 88);
            this.groupDatosProveedor.TabIndex = 21;
            this.groupDatosProveedor.TabStop = false;
            this.groupDatosProveedor.Text = "Datos del Proveedor";
            // 
            // mzCEFuenteDeCambioProducto
            // 
            this.mzCEFuenteDeCambioProducto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEFuenteDeCambioProducto.DisplayMember = "";
            this.mzCEFuenteDeCambioProducto.DisplayMemberCaption = "";
            this.mzCEFuenteDeCambioProducto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEFuenteDeCambioProducto.Location = new System.Drawing.Point(712, 48);
            this.mzCEFuenteDeCambioProducto.MaxItemsDisplay = 8;
            this.mzCEFuenteDeCambioProducto.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEFuenteDeCambioProducto.Name = "mzCEFuenteDeCambioProducto";
            this.mzCEFuenteDeCambioProducto.Size = new System.Drawing.Size(96, 21);
            this.mzCEFuenteDeCambioProducto.SorterMember = "";
            this.mzCEFuenteDeCambioProducto.TabIndex = 74;
            this.mzCEFuenteDeCambioProducto.ValueMember = "";
            this.mzCEFuenteDeCambioProducto.ValueMemberCaption = "";
            // 
            // labelSimboloMonedaOrigen
            // 
            this.labelSimboloMonedaOrigen.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaOrigen.Location = new System.Drawing.Point(600, 48);
            this.labelSimboloMonedaOrigen.Name = "labelSimboloMonedaOrigen";
            this.labelSimboloMonedaOrigen.Size = new System.Drawing.Size(32, 16);
            this.labelSimboloMonedaOrigen.TabIndex = 73;
            this.labelSimboloMonedaOrigen.Text = "$";
            this.labelSimboloMonedaOrigen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unePrecioDeCostoAnteriorMonedaProducto
            // 
            this.unePrecioDeCostoAnteriorMonedaProducto.Location = new System.Drawing.Point(632, 48);
            this.unePrecioDeCostoAnteriorMonedaProducto.Name = "unePrecioDeCostoAnteriorMonedaProducto";
            this.unePrecioDeCostoAnteriorMonedaProducto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioDeCostoAnteriorMonedaProducto.PromptChar = ' ';
            this.unePrecioDeCostoAnteriorMonedaProducto.Size = new System.Drawing.Size(80, 21);
            this.unePrecioDeCostoAnteriorMonedaProducto.TabIndex = 71;
            this.unePrecioDeCostoAnteriorMonedaProducto.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraLabel14
            // 
            this.ultraLabel14.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel14.Location = new System.Drawing.Point(520, 49);
            this.ultraLabel14.Name = "ultraLabel14";
            this.ultraLabel14.Size = new System.Drawing.Size(104, 31);
            this.ultraLabel14.TabIndex = 72;
            this.ultraLabel14.Text = "Precio de Costo Moneda Origen";
            // 
            // labelSimboloMonedaReferencia
            // 
            this.labelSimboloMonedaReferencia.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaReferencia.Location = new System.Drawing.Point(608, 19);
            this.labelSimboloMonedaReferencia.Name = "labelSimboloMonedaReferencia";
            this.labelSimboloMonedaReferencia.Size = new System.Drawing.Size(24, 16);
            this.labelSimboloMonedaReferencia.TabIndex = 70;
            this.labelSimboloMonedaReferencia.Text = "$";
            this.labelSimboloMonedaReferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaProveedor
            // 
            this.labelSimboloMonedaProveedor.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaProveedor.Location = new System.Drawing.Point(392, 21);
            this.labelSimboloMonedaProveedor.Name = "labelSimboloMonedaProveedor";
            this.labelSimboloMonedaProveedor.Size = new System.Drawing.Size(32, 16);
            this.labelSimboloMonedaProveedor.TabIndex = 69;
            this.labelSimboloMonedaProveedor.Text = "$";
            this.labelSimboloMonedaProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mzCEMonedaReferencia
            // 
            this.mzCEMonedaReferencia.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEMonedaReferencia.DisplayMember = "";
            this.mzCEMonedaReferencia.DisplayMemberCaption = "";
            this.mzCEMonedaReferencia.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEMonedaReferencia.Location = new System.Drawing.Point(712, 16);
            this.mzCEMonedaReferencia.MaxItemsDisplay = 8;
            this.mzCEMonedaReferencia.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEMonedaReferencia.Name = "mzCEMonedaReferencia";
            this.mzCEMonedaReferencia.Size = new System.Drawing.Size(96, 21);
            this.mzCEMonedaReferencia.SorterMember = "";
            this.mzCEMonedaReferencia.TabIndex = 68;
            this.mzCEMonedaReferencia.TabStop = false;
            this.mzCEMonedaReferencia.ValueMember = "";
            this.mzCEMonedaReferencia.ValueMemberCaption = "";
            // 
            // unePrecioCostoMonedaReferencia
            // 
            this.unePrecioCostoMonedaReferencia.Location = new System.Drawing.Point(632, 16);
            this.unePrecioCostoMonedaReferencia.Name = "unePrecioCostoMonedaReferencia";
            this.unePrecioCostoMonedaReferencia.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioCostoMonedaReferencia.PromptChar = ' ';
            this.unePrecioCostoMonedaReferencia.Size = new System.Drawing.Size(80, 21);
            this.unePrecioCostoMonedaReferencia.TabIndex = 4;
            this.unePrecioCostoMonedaReferencia.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraLabel5
            // 
            this.ultraLabel5.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel5.Location = new System.Drawing.Point(520, 20);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.Size = new System.Drawing.Size(88, 36);
            this.ultraLabel5.TabIndex = 66;
            this.ultraLabel5.Text = "Precio de Costo Convertido";
            // 
            // uneValorCotizacionProveedor
            // 
            this.uneValorCotizacionProveedor.Location = new System.Drawing.Point(136, 57);
            this.uneValorCotizacionProveedor.Name = "uneValorCotizacionProveedor";
            this.uneValorCotizacionProveedor.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneValorCotizacionProveedor.PromptChar = ' ';
            this.uneValorCotizacionProveedor.Size = new System.Drawing.Size(100, 21);
            this.uneValorCotizacionProveedor.TabIndex = 2;
            this.uneValorCotizacionProveedor.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel4.Location = new System.Drawing.Point(8, 58);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(104, 16);
            this.ultraLabel4.TabIndex = 64;
            this.ultraLabel4.Text = "Valor Conversion";
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel3.Location = new System.Drawing.Point(8, 38);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(120, 16);
            this.ultraLabel3.TabIndex = 63;
            this.ultraLabel3.Text = "Fuente de Cambio";
            // 
            // mzCEFuenteDeCambioProveedor
            // 
            this.mzCEFuenteDeCambioProveedor.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEFuenteDeCambioProveedor.DisplayMember = "";
            this.mzCEFuenteDeCambioProveedor.DisplayMemberCaption = "";
            this.mzCEFuenteDeCambioProveedor.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEFuenteDeCambioProveedor.Location = new System.Drawing.Point(136, 37);
            this.mzCEFuenteDeCambioProveedor.MaxItemsDisplay = 8;
            this.mzCEFuenteDeCambioProveedor.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEFuenteDeCambioProveedor.Name = "mzCEFuenteDeCambioProveedor";
            this.mzCEFuenteDeCambioProveedor.Size = new System.Drawing.Size(167, 21);
            this.mzCEFuenteDeCambioProveedor.SorterMember = "";
            this.mzCEFuenteDeCambioProveedor.TabIndex = 1;
            this.mzCEFuenteDeCambioProveedor.ValueMember = "";
            this.mzCEFuenteDeCambioProveedor.ValueMemberCaption = "";
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel1.Location = new System.Drawing.Point(8, 18);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(72, 16);
            this.ultraLabel1.TabIndex = 61;
            this.ultraLabel1.Text = "Moneda";
            // 
            // unePrecioDeCostoMonedaProveedor
            // 
            this.unePrecioDeCostoMonedaProveedor.Location = new System.Drawing.Point(424, 17);
            this.unePrecioDeCostoMonedaProveedor.Name = "unePrecioDeCostoMonedaProveedor";
            this.unePrecioDeCostoMonedaProveedor.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioDeCostoMonedaProveedor.PromptChar = ' ';
            this.unePrecioDeCostoMonedaProveedor.Size = new System.Drawing.Size(96, 21);
            this.unePrecioDeCostoMonedaProveedor.TabIndex = 3;
            this.unePrecioDeCostoMonedaProveedor.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel2.Location = new System.Drawing.Point(304, 24);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(104, 16);
            this.ultraLabel2.TabIndex = 20;
            this.ultraLabel2.Text = "Precio unitario";
            // 
            // mzCEMonedaProveedor
            // 
            this.mzCEMonedaProveedor.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEMonedaProveedor.DisplayMember = "";
            this.mzCEMonedaProveedor.DisplayMemberCaption = "";
            this.mzCEMonedaProveedor.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEMonedaProveedor.Location = new System.Drawing.Point(136, 18);
            this.mzCEMonedaProveedor.MaxItemsDisplay = 8;
            this.mzCEMonedaProveedor.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEMonedaProveedor.Name = "mzCEMonedaProveedor";
            this.mzCEMonedaProveedor.Size = new System.Drawing.Size(167, 21);
            this.mzCEMonedaProveedor.SorterMember = "";
            this.mzCEMonedaProveedor.TabIndex = 0;
            this.mzCEMonedaProveedor.ValueMember = "";
            this.mzCEMonedaProveedor.ValueMemberCaption = "";
            // 
            // containerDatosVenta
            // 
            this.containerDatosVenta.Controls.Add(this.groupNuevoCosto);
            this.containerDatosVenta.Location = new System.Drawing.Point(-10000, -10000);
            this.containerDatosVenta.Name = "containerDatosVenta";
            this.containerDatosVenta.Size = new System.Drawing.Size(918, 168);
            this.containerDatosVenta.TabIndex = 4;
            this.containerDatosVenta.Visible = false;
            // 
            // groupNuevoCosto
            // 
            this.groupNuevoCosto.BackColor = System.Drawing.Color.Transparent;
            this.groupNuevoCosto.Controls.Add(this.groupBox6);
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
            this.groupNuevoCosto.Size = new System.Drawing.Size(912, 168);
            this.groupNuevoCosto.TabIndex = 78;
            this.groupNuevoCosto.TabStop = false;
            this.groupNuevoCosto.Text = "Datos para la Venta";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.unePrecioDeCostoReposicion1);
            this.groupBox6.Controls.Add(this.chkUsaPrecioDeCostoReposicion1);
            this.groupBox6.Controls.Add(this.labelSimboloMonedaPrecioDeCostoReposicion1);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.ultraLabel7);
            this.groupBox6.Controls.Add(this.labelSimboloMonedaPrecioDeCosto4);
            this.groupBox6.Controls.Add(this.unePCostoPromedioPonderado1);
            this.groupBox6.Location = new System.Drawing.Point(8, 80);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(345, 79);
            this.groupBox6.TabIndex = 160;
            this.groupBox6.TabStop = false;
            // 
            // unePrecioDeCostoReposicion1
            // 
            this.unePrecioDeCostoReposicion1.Location = new System.Drawing.Point(232, 29);
            this.unePrecioDeCostoReposicion1.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.unePrecioDeCostoReposicion1.MaskInput = "-nnnnnnnnn.nn";
            this.unePrecioDeCostoReposicion1.Name = "unePrecioDeCostoReposicion1";
            this.unePrecioDeCostoReposicion1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioDeCostoReposicion1.Size = new System.Drawing.Size(100, 21);
            this.unePrecioDeCostoReposicion1.TabIndex = 156;
            this.unePrecioDeCostoReposicion1.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // chkUsaPrecioDeCostoReposicion1
            // 
            this.chkUsaPrecioDeCostoReposicion1.BackColor = System.Drawing.Color.Transparent;
            this.chkUsaPrecioDeCostoReposicion1.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkUsaPrecioDeCostoReposicion1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkUsaPrecioDeCostoReposicion1.Location = new System.Drawing.Point(8, 48);
            this.chkUsaPrecioDeCostoReposicion1.Name = "chkUsaPrecioDeCostoReposicion1";
            this.chkUsaPrecioDeCostoReposicion1.Size = new System.Drawing.Size(240, 20);
            this.chkUsaPrecioDeCostoReposicion1.TabIndex = 159;
            this.chkUsaPrecioDeCostoReposicion1.Text = "Usa Precio de Costo Reposición";
            // 
            // labelSimboloMonedaPrecioDeCostoReposicion1
            // 
            this.labelSimboloMonedaPrecioDeCostoReposicion1.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeCostoReposicion1.Location = new System.Drawing.Point(200, 32);
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
            // ultraLabel7
            // 
            this.ultraLabel7.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel7.Location = new System.Drawing.Point(8, 16);
            this.ultraLabel7.Name = "ultraLabel7";
            this.ultraLabel7.Size = new System.Drawing.Size(195, 15);
            this.ultraLabel7.TabIndex = 154;
            this.ultraLabel7.Text = "Precio de Costo Promedio Ponderado";
            // 
            // labelSimboloMonedaPrecioDeCosto4
            // 
            this.labelSimboloMonedaPrecioDeCosto4.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeCosto4.Location = new System.Drawing.Point(200, 16);
            this.labelSimboloMonedaPrecioDeCosto4.Name = "labelSimboloMonedaPrecioDeCosto4";
            this.labelSimboloMonedaPrecioDeCosto4.Size = new System.Drawing.Size(32, 17);
            this.labelSimboloMonedaPrecioDeCosto4.TabIndex = 155;
            this.labelSimboloMonedaPrecioDeCosto4.Text = "$";
            this.labelSimboloMonedaPrecioDeCosto4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unePCostoPromedioPonderado1
            // 
            this.unePCostoPromedioPonderado1.Location = new System.Drawing.Point(232, 9);
            this.unePCostoPromedioPonderado1.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.unePCostoPromedioPonderado1.MaskInput = "-nnnnnnnnn.nn";
            this.unePCostoPromedioPonderado1.Name = "unePCostoPromedioPonderado1";
            this.unePCostoPromedioPonderado1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePCostoPromedioPonderado1.PromptChar = ' ';
            this.unePCostoPromedioPonderado1.Size = new System.Drawing.Size(100, 21);
            this.unePCostoPromedioPonderado1.TabIndex = 153;
            this.unePCostoPromedioPonderado1.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia
            // 
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia.Location = new System.Drawing.Point(600, 100);
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia.Name = "labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia";
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia.Size = new System.Drawing.Size(32, 16);
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia.TabIndex = 89;
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia.Text = "$";
            this.labelSimboloMonedaPrecioDeListaConImpuestosMonedaReferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(408, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 21);
            this.label3.TabIndex = 88;
            this.label3.Text = "Pcio  Vta Bruto C/Imp. Moneda Ref.";
            // 
            // unePrecioDeListaConImpuestoMonedaReferencia
            // 
            this.unePrecioDeListaConImpuestoMonedaReferencia.Location = new System.Drawing.Point(632, 96);
            this.unePrecioDeListaConImpuestoMonedaReferencia.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.unePrecioDeListaConImpuestoMonedaReferencia.MaskInput = "-nnnnnnnnn.nn";
            this.unePrecioDeListaConImpuestoMonedaReferencia.Name = "unePrecioDeListaConImpuestoMonedaReferencia";
            this.unePrecioDeListaConImpuestoMonedaReferencia.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioDeListaConImpuestoMonedaReferencia.Size = new System.Drawing.Size(100, 21);
            this.unePrecioDeListaConImpuestoMonedaReferencia.TabIndex = 87;
            this.unePrecioDeListaConImpuestoMonedaReferencia.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // labelSimboloMonedaPrecioDeListaConImpuestos
            // 
            this.labelSimboloMonedaPrecioDeListaConImpuestos.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeListaConImpuestos.Location = new System.Drawing.Point(600, 79);
            this.labelSimboloMonedaPrecioDeListaConImpuestos.Name = "labelSimboloMonedaPrecioDeListaConImpuestos";
            this.labelSimboloMonedaPrecioDeListaConImpuestos.Size = new System.Drawing.Size(32, 16);
            this.labelSimboloMonedaPrecioDeListaConImpuestos.TabIndex = 86;
            this.labelSimboloMonedaPrecioDeListaConImpuestos.Text = "$";
            this.labelSimboloMonedaPrecioDeListaConImpuestos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(408, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 21);
            this.label2.TabIndex = 85;
            this.label2.Text = "Precio de Venta Bruto Con Impuestos";
            // 
            // unePrecioDeListaConImpuesto
            // 
            this.unePrecioDeListaConImpuesto.Location = new System.Drawing.Point(632, 76);
            this.unePrecioDeListaConImpuesto.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.unePrecioDeListaConImpuesto.MaskInput = "-nnnnnnnnn.nn";
            this.unePrecioDeListaConImpuesto.Name = "unePrecioDeListaConImpuesto";
            this.unePrecioDeListaConImpuesto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioDeListaConImpuesto.Size = new System.Drawing.Size(100, 21);
            this.unePrecioDeListaConImpuesto.TabIndex = 84;
            this.unePrecioDeListaConImpuesto.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // labelSimboloMonedaPrecioDeLista
            // 
            this.labelSimboloMonedaPrecioDeLista.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaPrecioDeLista.Location = new System.Drawing.Point(600, 59);
            this.labelSimboloMonedaPrecioDeLista.Name = "labelSimboloMonedaPrecioDeLista";
            this.labelSimboloMonedaPrecioDeLista.Size = new System.Drawing.Size(32, 16);
            this.labelSimboloMonedaPrecioDeLista.TabIndex = 83;
            this.labelSimboloMonedaPrecioDeLista.Text = "$";
            this.labelSimboloMonedaPrecioDeLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaDescuentoMaximo
            // 
            this.labelSimboloMonedaDescuentoMaximo.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaDescuentoMaximo.Location = new System.Drawing.Point(600, 39);
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
            this.label16.Location = new System.Drawing.Point(736, 24);
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
            this.label13.Location = new System.Drawing.Point(408, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(223, 21);
            this.label13.TabIndex = 37;
            this.label13.Text = "Precio de Venta Bruto (Precio de Lista)";
            // 
            // unePrecioVentaBruto
            // 
            this.unePrecioVentaBruto.Location = new System.Drawing.Point(632, 56);
            this.unePrecioVentaBruto.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.unePrecioVentaBruto.MaskInput = "-nnnnnnnnn.nn";
            this.unePrecioVentaBruto.Name = "unePrecioVentaBruto";
            this.unePrecioVentaBruto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioVentaBruto.Size = new System.Drawing.Size(100, 21);
            this.unePrecioVentaBruto.TabIndex = 17;
            this.unePrecioVentaBruto.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(408, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(223, 21);
            this.label12.TabIndex = 36;
            this.label12.Text = "Descuento Máximo s/Precio de Lista";
            // 
            // uneMaxDescuento
            // 
            this.uneMaxDescuento.Location = new System.Drawing.Point(632, 36);
            this.uneMaxDescuento.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.uneMaxDescuento.MaskInput = "-nnnnnnnnn.nn";
            this.uneMaxDescuento.Name = "uneMaxDescuento";
            this.uneMaxDescuento.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneMaxDescuento.Size = new System.Drawing.Size(100, 21);
            this.uneMaxDescuento.TabIndex = 16;
            this.uneMaxDescuento.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(408, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(223, 21);
            this.label11.TabIndex = 35;
            this.label11.Text = "Descuento Porcentual s/Precio de Lista";
            // 
            // uneMaxDescuentoPorcentual
            // 
            this.uneMaxDescuentoPorcentual.Location = new System.Drawing.Point(632, 16);
            this.uneMaxDescuentoPorcentual.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.uneMaxDescuentoPorcentual.MaskInput = "-nnnnnnnnn.nn";
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
            this.label10.Size = new System.Drawing.Size(128, 21);
            this.label10.TabIndex = 34;
            this.label10.Text = "Precio de Venta Neto";
            // 
            // unePrecioDeVentaNeto
            // 
            this.unePrecioDeVentaNeto.Location = new System.Drawing.Point(240, 56);
            this.unePrecioDeVentaNeto.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.unePrecioDeVentaNeto.MaskInput = "-nnnnnnnnn.nn";
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
            this.label8.Size = new System.Drawing.Size(144, 21);
            this.label8.TabIndex = 33;
            this.label8.Text = "Precio de Costo Referencia";
            // 
            // unePrecioDeCostoRef
            // 
            this.unePrecioDeCostoRef.Location = new System.Drawing.Point(240, 16);
            this.unePrecioDeCostoRef.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.unePrecioDeCostoRef.MaskInput = "-nnnnnnnnn.nn";
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
            this.label7.Size = new System.Drawing.Size(144, 21);
            this.label7.TabIndex = 32;
            this.label7.Text = "Margen/Precio Costo Neto";
            // 
            // uneMAC
            // 
            this.uneMAC.Location = new System.Drawing.Point(240, 36);
            this.uneMAC.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.uneMAC.MaskInput = "-nnnnnnnnn.nn";
            this.uneMAC.Name = "uneMAC";
            this.uneMAC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneMAC.Size = new System.Drawing.Size(100, 21);
            this.uneMAC.TabIndex = 13;
            this.uneMAC.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraExplorerBarContainerControl1
            // 
            this.ultraExplorerBarContainerControl1.Controls.Add(this.groupBox2);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.groupBox1);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.gridListaDePrecios);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.gridManagerView2);
            this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(918, 320);
            this.ultraExplorerBarContainerControl1.TabIndex = 5;
            this.ultraExplorerBarContainerControl1.Visible = false;
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
            this.groupBox2.Size = new System.Drawing.Size(912, 120);
            this.groupBox2.TabIndex = 41;
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
            this.unePrecioFinalMonedaReferenciaLP.TabIndex = 162;
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
            this.unePrecioDeListaConImpuestoLP.TabIndex = 160;
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
            this.unePrecioVentaBrutoLP.TabIndex = 155;
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
            this.uneMaxDescuentoLP.TabIndex = 154;
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
            this.uneMaxDescuentoPorcentualLP.TabIndex = 153;
            this.uneMaxDescuentoPorcentualLP.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // btnRestablecerAGral
            // 
            this.btnRestablecerAGral.BackColor = System.Drawing.SystemColors.Control;
            this.btnRestablecerAGral.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRestablecerAGral.Location = new System.Drawing.Point(464, 16);
            this.btnRestablecerAGral.Name = "btnRestablecerAGral";
            this.btnRestablecerAGral.Size = new System.Drawing.Size(136, 20);
            this.btnRestablecerAGral.TabIndex = 152;
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
            this.uneCoeficienteMonedaReferencia.TabIndex = 149;
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
            this.uneCoeficiente.TabIndex = 148;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.labelSimboloMonedaPrecioDeCostoReferenciaLP);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.unePrecioDeCostoRefLP);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.unePrecioDeVentaNetoLP);
            this.groupBox1.Controls.Add(this.labelSimboloMonedaPrecioDeVentaNetoLP);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.uneMACLP);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 40);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
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
            this.unePrecioDeCostoRefLP.TabIndex = 25;
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
            this.unePrecioDeVentaNetoLP.TabIndex = 27;
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
            this.uneMACLP.TabIndex = 26;
            this.uneMACLP.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
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
            this.gridListaDePrecios.Location = new System.Drawing.Point(0, 40);
            this.gridListaDePrecios.Name = "gridListaDePrecios";
            this.gridListaDePrecios.RecordNavigatorText = "Registro:|de";
            this.gridListaDePrecios.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridListaDePrecios.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridListaDePrecios.ShowEmptyFields = false;
            this.gridListaDePrecios.Size = new System.Drawing.Size(912, 160);
            this.gridListaDePrecios.TabIndex = 38;
            this.gridListaDePrecios.TabStop = false;
            this.gridListaDePrecios.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            // 
            // gridManagerView2
            // 
            this.gridManagerView2.BackColor = System.Drawing.SystemColors.Control;
            this.gridManagerView2.Location = new System.Drawing.Point(0, 0);
            this.gridManagerView2.Name = "gridManagerView2";
            this.gridManagerView2.Size = new System.Drawing.Size(814, 24);
            this.gridManagerView2.TabIndex = 78;
            this.gridManagerView2.Visible = false;
            // 
            // imglStandar
            // 
            this.imglStandar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
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
            this.tbbCancelar,
            this.tbbSeparator3,
            this.tbbEliminarListaDePrecio});
            this.toolBarStandar.DropDownArrows = true;
            this.toolBarStandar.ImageList = this.imglStandar;
            this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
            this.toolBarStandar.Name = "toolBarStandar";
            this.toolBarStandar.ShowToolTips = true;
            this.toolBarStandar.Size = new System.Drawing.Size(984, 28);
            this.toolBarStandar.TabIndex = 23;
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
            // tbbSeparator3
            // 
            this.tbbSeparator3.Name = "tbbSeparator3";
            this.tbbSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbEliminarListaDePrecio
            // 
            this.tbbEliminarListaDePrecio.Name = "tbbEliminarListaDePrecio";
            this.tbbEliminarListaDePrecio.Text = "Eliminar Lista de Precio";
            // 
            // ultraExplorerBar
            // 
            this.ultraExplorerBar.AnimationEnabled = false;
            this.ultraExplorerBar.Controls.Add(this.containerDatosCompra);
            this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl2);
            this.ultraExplorerBar.Controls.Add(this.containerProductos);
            this.ultraExplorerBar.Controls.Add(this.containerDatosVenta);
            this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl1);
            this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl3);
            this.ultraExplorerBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ultraExplorerBar.Dock = System.Windows.Forms.DockStyle.Fill;
            ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl2;
            ultraExplorerBarGroup1.Enabled = false;
            ultraExplorerBarGroup1.Key = "Tarea";
            ultraExplorerBarGroup1.Settings.ContainerHeight = 42;
            ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup1.Text = "Tarea";
            ultraExplorerBarGroup2.Container = this.containerProductos;
            ultraExplorerBarGroup2.Key = "Productos";
            ultraExplorerBarGroup2.Settings.ContainerHeight = 252;
            ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup2.Text = "Producto";
            ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl3;
            ultraExplorerBarGroup3.Key = "ListaPrecioProveedor";
            ultraExplorerBarGroup3.Settings.ContainerHeight = 361;
            ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup3.Text = "Lista de Precios Proveedor";
            ultraExplorerBarGroup4.Container = this.containerDatosCompra;
            ultraExplorerBarGroup4.Key = "DatosCompra";
            ultraExplorerBarGroup4.Settings.ContainerHeight = 259;
            ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup4.Text = "Datos de la Compra";
            ultraExplorerBarGroup5.Container = this.containerDatosVenta;
            ultraExplorerBarGroup5.Key = "Precios";
            ultraExplorerBarGroup5.Settings.ContainerHeight = 168;
            ultraExplorerBarGroup5.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup5.Text = "Datos para la Venta";
            ultraExplorerBarGroup6.Container = this.ultraExplorerBarContainerControl1;
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
            this.ultraExplorerBar.Size = new System.Drawing.Size(984, 490);
            this.ultraExplorerBar.TabIndex = 24;
            this.ultraExplorerBar.TabStop = false;
            // 
            // ultraNumericEditor2
            // 
            appearance1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ultraNumericEditor2.Appearance = appearance1;
            this.ultraNumericEditor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ultraNumericEditor2.Location = new System.Drawing.Point(144, 40);
            this.ultraNumericEditor2.Name = "ultraNumericEditor2";
            this.ultraNumericEditor2.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.ultraNumericEditor2.PromptChar = ' ';
            this.ultraNumericEditor2.Size = new System.Drawing.Size(100, 21);
            this.ultraNumericEditor2.TabIndex = 69;
            // 
            // txtCodigoProductoProveedor
            // 
            this.txtCodigoProductoProveedor.Location = new System.Drawing.Point(91, 143);
            this.txtCodigoProductoProveedor.Name = "txtCodigoProductoProveedor";
            this.txtCodigoProductoProveedor.Size = new System.Drawing.Size(205, 20);
            this.txtCodigoProductoProveedor.TabIndex = 83;
            // 
            // ultraLabel8
            // 
            this.ultraLabel8.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel8.Location = new System.Drawing.Point(0, 147);
            this.ultraLabel8.Name = "ultraLabel8";
            this.ultraLabel8.Size = new System.Drawing.Size(112, 17);
            this.ultraLabel8.TabIndex = 221;
            this.ultraLabel8.Text = "Cod. Prod. Prov.";
            // 
            // FrmIngresarPrecioProducto
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(984, 518);
            this.Controls.Add(this.ultraExplorerBar);
            this.Controls.Add(this.toolBarStandar);
            this.Name = "FrmIngresarPrecioProducto";
            this.Text = "FrmIngresarPrecioProducto";
            this.ultraExplorerBarContainerControl2.ResumeLayout(false);
            this.containerProductos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ultraExplorerBarContainerControl3.ResumeLayout(false);
            this.ultraExplorerBarContainerControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaDePreciosProveedores)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficientePrecioCostoListaProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneBonificacion2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneBonificacion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCotizacionPrecioDeCostoProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePorcBonificacion2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePorcBonificacion3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePorcBonificacion4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePorcBonificacion5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePorcBonificacion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEFuenteDeCambioPrecioDeCostoProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEMonedaPrecioDeCostoProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoFinalProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneBonificacion5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneBonificacion4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneBonificacion3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.containerDatosCompra.ResumeLayout(false);
            this.groupMZ.ResumeLayout(false);
            this.groupMZ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoReposicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioPPCostoAnteriorMonedaProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoMonedaProducto)).EndInit();
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
            this.groupDatosProveedor.ResumeLayout(false);
            this.groupDatosProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEFuenteDeCambioProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoAnteriorMonedaProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEMonedaReferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioCostoMonedaReferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneValorCotizacionProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEFuenteDeCambioProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoMonedaProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEMonedaProveedor)).EndInit();
            this.containerDatosVenta.ResumeLayout(false);
            this.groupNuevoCosto.ResumeLayout(false);
            this.groupNuevoCosto.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
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
            this.ultraExplorerBarContainerControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioFinalMonedaReferenciaLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeListaConImpuestoLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioVentaBrutoLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuentoLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMaxDescuentoPorcentualLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficienteMonedaReferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCoeficiente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeCostoRefLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioDeVentaNetoLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneMACLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaDePrecios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar)).EndInit();
            this.ultraExplorerBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

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
			
			if(!_uiController.SeleccionMultiple)
			{
				if(gridProductos.SelectedItems.Count > 0)
				{
					_uiController.DisconnectCostosIndirectosEvent();
					object selectedItem = gridProductos.SelectedItems[0].GetRow().DataRow;
					_selectedIndex = gridProductos.Row;
					_uiController.SelectedItem = (businessrules.Producto)selectedItem;
					unePrecioDeCostoRef.ReadOnly = !_uiController.AllowEditPrecioDeCostoRef;
					uneMAC.ReadOnly = false;
					unePrecioDeVentaNeto.ReadOnly = true;
					uneMaxDescuento.ReadOnly = true;
					uneMaxDescuentoPorcentual.ReadOnly = !_uiController.PrecioDeVentaAfectaMac;
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

					

					/*Quitar el evento Objectchanged del Controller respecto a BR*/
					_uiController.DisconnectObjectHasChangedEvent();					
				    gridListaDePrecios.SetDataBinding(null, null);
					gridListaDePrecios.SetDataBinding(_uiController.SelectedItem.ListaDePrecios.Items, null);
					gridListaDePreciosProveedores.SetDataBinding(null, null);
					gridListaDePreciosProveedores.SetDataBinding(_uiController.SelectedItem.ListaDePreciosProveedores.Items, null);
					_uiController.ConnectObjectHasChangedEvent();	
				
					_uiController.ConnectCostosIndirectosEvent();
				}
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
					mz.erp.ui.utility.Util.MoveFocus(containerProductos);
                    //Sabrina: Tarea 1068. 20110317
					this.Execute();
                    //Fin Sabrina: Tarea 1068. 20110317
					break;
				//Matias 20100602 - Tarea 10
				case 4:
					CloseForm();
					break;
				//Fin Matias 20100602 - Tarea 10
                //German 20140125 - Tarea 1 - SP 22
                case 6://Guardar modificacion es codigo producto proveedor				
                    this.saveRemoveListaDePrecioProveedorSeleccionada();
                    break;
                //Fin German 20140125 - Tarea 1 - SP 22
			}						
		}

        //German 20140125 - Tarea 1 - SP 22
        private void saveRemoveListaDePrecioProveedorSeleccionada()
        {
            if (gridListaDePreciosProveedores.SelectedItems.Count > 0)
            {
                businessrules.ListaDePreciosProveedoresItem item = (businessrules.ListaDePreciosProveedoresItem)gridListaDePreciosProveedores.SelectedItems[0].GetRow().DataRow;
                if (!item.EsProveedorPorDefault)
                {
                    System.Windows.Forms.DialogResult result = MessageBox.Show("¿Desea eliminar la lista de precio de proveedor seleccionada?", "Confirmación", System.Windows.Forms.MessageBoxButtons.YesNo);
                    if (result.Equals(System.Windows.Forms.DialogResult.Yes))
                    {
                        _uiController.removeListaDePrecioProveedor(item);
                        CloseForm();
                    }
                }
                else
                {
                    MessageBox.Show("No se puede eliminar la lista de precio de proveedor default", "Lista de Precio Proveedor", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);		
                }
            }
        }
        //Fin German 20140125 - Tarea 1 - SP 22

	
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
				unePrecioDeCostoMonedaProducto.Enabled = !_uiController.ReadOnlyPrecioDeCostoMonedaProducto && _uiController.PermiteModificarPrecioDeCostoPromedioPonderado;
				unePrecioDeCostoRef.ReadOnly = true;
				uneMAC.ReadOnly = true;
				unePrecioDeVentaNeto.ReadOnly = true;
				uneMaxDescuento.ReadOnly = true;
				uneMaxDescuentoPorcentual.ReadOnly = true;
				unePrecioVentaBruto.ReadOnly = true;
				unePrecioDeListaConImpuesto.ReadOnly = true;
				unePrecioDeListaConImpuestoMonedaReferencia.ReadOnly  = true;

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
			gridProductos.SelectionChanged -=new EventHandler(gridProductos_SelectionChanged);
			if(gridProductos.SelectedItems.Count > 0)
			{
				object itemDeleting = gridProductos.SelectedItems[0].GetRow().DataRow;					
				_uiController.SetItemABorrar(itemDeleting);
			}
		}

		private void unePrecioDeVentaNeto_Leave(object sender, System.EventArgs e)
		{
			if(!_uiController.PrecioDeVentaAfectaMac)
			{
				_uiController.PrecioDeVentaBruto = (decimal)unePrecioDeVentaNeto.Value;		
				unePrecioVentaBruto.Value = unePrecioDeVentaNeto.Value;		
			}
		}

		private void rbSeleccionMultiple_CheckedChanged(object sender, EventArgs e)
		{
			
			bTodosCaja.Enabled = rbSeleccionMultiple.Checked;
			bNingunoCaja.Enabled = rbSeleccionMultiple.Checked;
			_uiController.SeleccionMultiple = rbSeleccionMultiple.Checked;
			if(rbSeleccionSimple.Checked)
				this.gridProductos_SelectionChanged(gridProductos, new EventArgs());
			else
			{
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



			}
			if(_uiController.AllowSeleccionMultiple)
			{
				gridProductos.RootTable.Columns["Selected"].Visible = rbSeleccionMultiple.Checked;
			}
			//Matias 20100612 - Tarea 22
			//mzCmbProveedorViejo.DataValue = string.Empty;
			mzCmbProveedor.DataValue = string.Empty;
			//Fin Matias 20100612 - Tarea 22

            //German 20120125 - Tarea 0000257 -- Simplemente para forzar que se actualice en BR el proveedor seleccionado
            if (rbSeleccionMultiple.Checked)
                gridListaDePreciosProveedores_SelectionChanged(gridListaDePreciosProveedores, EventArgs.Empty);
            //Fin German 20120125 - Tarea 0000257
		}

		private void bTodosCaja_Click(object sender, EventArgs e)
		{
			_uiController.Seleccionar(true);
		}

		private void bNingunoCaja_Click(object sender, EventArgs e)
		{
			_uiController.Seleccionar(false);
		}

		private void _uiController_SeleccionMultiplePrecioDeCostoError(object sender, EventArgs e)
		{
			MessageBox.Show("Los Productos Seleccionados tienen diferente cotización para el Precio de Costo","Productos", System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Stop);		
		}

		private void _uiController_SeleccionMultiplePrecioDeVentaError(object sender, EventArgs e)
		{
			MessageBox.Show("Los Productos Seleccionados tienen diferente cotización para el Precio de Venta","Productos", System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Stop);		
		}

		private void gridListaDePrecios_SelectionChanged(object sender, EventArgs e)
		{
			if(gridListaDePrecios.SelectedItems.Count > 0)
			{

				businessrules.ListaDePreciosItem item = (businessrules.ListaDePreciosItem)gridListaDePrecios.SelectedItems[0].GetRow().DataRow;
				_uiController.ListaDePreciosItemSeleccionado = item;

			}
		}

		private void gridListaDePreciosProveedores_SelectionChanged(object sender, EventArgs e)
		{
			if(gridListaDePreciosProveedores.SelectedItems.Count > 0)
			{

				businessrules.ListaDePreciosProveedoresItem item = (businessrules.ListaDePreciosProveedoresItem)gridListaDePreciosProveedores.SelectedItems[0].GetRow().DataRow;
				_uiController.ListaDePreciosProveedoresItemSeleccionado = item;
				if(item.Estado.Equals("NEW"))
					btnEliminarListaDePreciosProv.Enabled = true;
				else
					btnEliminarListaDePreciosProv.Enabled = false;
				//Matias 20100612 - Tarea 22
				//mzCmbProveedorViejo.DataValue = _uiController.IdProveedor;
				mzCmbProveedor.DataValue = _uiController.CodigoProveedor;
				//Fin Matias 20100612 - Tarea 22
				string ponervisibleElcheckbox;
				_cambiarProvDefaultEnGrilla = false;
                //German 20110309 - Tarea 0000038
                //if(_uiController.ProcessName.Equals("ProcesoConfirmarIngresoMercaderia") || _uiController.ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior"))
                if (_uiController.EsProcesoDeConfirmacionDePrecios(_uiController.ProcessName))
                //Fin German 20110309 - Tarea 0000038
				{
					//German 20090914
					if(_uiController.UsaPrecioDeListaProveedor)
					{
						if(_uiController.SelectedItem.IdProveedorDefaultAnterior.Equals("null"))
						{
							if(_uiController.SelectedItem.IdProveedorDefault.Equals(item.IdProveedor)) //Si es el proveedor default en la bd
							{
								chckActualizaPcioCostoReposicion.Visible = true;
								chckActualizaPcioCostoReposicion.Enabled = false;
								chckActualizaPcioCostoReposicion.Checked = true;
							}
							else
							{
								chckActualizaPcioCostoReposicion.Visible = true;
								chckActualizaPcioCostoReposicion.Enabled = true;
								chckActualizaPcioCostoReposicion.Checked = false;
							}
						}
						else
						{
							chckActualizaPcioCostoReposicion.Visible = true;
							chckActualizaPcioCostoReposicion.Enabled = true;
						}
					}
					else
					{
						chckActualizaPcioCostoReposicion.Visible = true;
						if(_uiController.SelectedItem.IdProveedorDefault.Equals(item.IdProveedor)) //Si es el proveedor default en la bd
						{
							chckActualizaPcioCostoReposicion.Enabled = false;
							chckActualizaPcioCostoReposicion.Checked = true;
						}
						else
							chckActualizaPcioCostoReposicion.Enabled = true;
					}
					//German 20090914
				}
				_cambiarProvDefaultEnGrilla = true;

			}
			//Sabrina: tarea 56
			else
				//Matias 20100612 - Tarea 22
				//mzCmbProveedorViejo.DataValue = string.Empty;
				mzCmbProveedor.DataValue = string.Empty;
				//Fin Matias 20100612 - Tarea 22

		}
		
		private void gridListaDePreciosProveedores_CellEdited(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
		{
			if ((gridListaDePreciosProveedores.SelectedItems.Count > 0) && (gridListaDePreciosProveedores.CurrentColumn.Caption.Equals("Proveedor Default")))
			{
				bool esProvPorDefault = (bool)gridListaDePreciosProveedores.SelectedItems[0].GetRow().Cells[e.Column].Value;
				_uiController.CellEdited(esProvPorDefault);
				_cambiarProvDefaultEnGrilla = false;
				//German 20090826
				//chckActualizaPcioCostoReposicion.Checked = esProvPorDefault;
				//German 20090826
				_cambiarProvDefaultEnGrilla = true;
			}
			gridListaDePreciosProveedores.Update();		
		}

        /* Silvina 20110817 - Tarea 0000191 */
        void gridListaDePreciosProveedores_CellValueChanged(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            gridListaDePreciosProveedores.UpdateData();	
        }
        /* Fin Silvina 20110817 - Tarea 0000191 */

		private void gridListaDePreciosProveedores_Click(object sender, System.EventArgs e)
		{
			gridListaDePreciosProveedores.Update();			
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


		//Matias 20100612 - Tarea 22
//		private void mzCmbProveedor_ValueChanged(object sender, System.EventArgs e)
//		{
//			string idProv = mzCmbProveedorViejo.DataValue.ToString();
//			_uiController.IdProveedor = idProv;
//            		
//		}
		private void Componentes_Changes(object sender, System.EventArgs e)
		{
			if (!Convert.ToString(mzCmbProveedor.DataValue).Equals(string.Empty))
			{
				string codigo = Convert.ToString(mzCmbProveedor.DataValue);
				_uiController.CodigoProveedor = codigo;
			}
			else
				_uiController.CodigoProveedor = string.Empty;
		}
		//Fin Matias 20100612 - Tarea 22

		//Sabrina 20100616 - Tarea 744
		/*private void mzCEMonedaPrecioDeCostoProv_ValueChanged(object sender, System.EventArgs e)
		{
			string idMoneda = mzCEMonedaPrecioDeCostoProv.Value.ToString();
			_uiController.IdMonedaPrecioDeCostoProveedor = idMoneda;
            		
		}

		private void mzCEFuenteDeCambioPrecioDeCostoProv_ValueChanged(object sender, System.EventArgs e)
		{
			string idFuenteDeCambio = mzCEFuenteDeCambioPrecioDeCostoProv.Value.ToString();
			_uiController.IdFuenteDeCambioListaProveedor = idFuenteDeCambio;
            		
		}*/
		//Fin Sabrina 20100616 - Tarea 744

		
		private void utbTrasladarPrecioDeCostoFinal_Click(object sender, EventArgs e)
		{
			_uiController.TrasladarPrecioDeListaFinal();
			//RefreshControls(this, EventArgs.Empty);
		}

/*		private void utbTrasladarPrecioUnitario_Click(object sender, EventArgs e)
		{
			_uiController.TrasladarPrecioUnitario();
		}
*/		

		private void _uiController_ListaDePreciosProveedoresHasChanged(object sender, System.EventArgs e)
		{
			if(_uiController.ListaDePreciosProveedoresItemSeleccionado != null && _uiController.ListaDePreciosProveedoresItemSeleccionado.isNew())
			{
				gridListaDePreciosProveedores.SelectionChanged -=new EventHandler(gridListaDePreciosProveedores_SelectionChanged);
				gridListaDePreciosProveedores.SetDataBinding(null, null);
				gridListaDePreciosProveedores.SetDataBinding(_uiController.SelectedItem.ListaDePreciosProveedores.Items, null);
				gridListaDePreciosProveedores.SelectionChanged +=new EventHandler(gridListaDePreciosProveedores_SelectionChanged);
				if(_uiController.SelectedItem.ListaDePreciosProveedores.Items.Count > 0)
					gridListaDePreciosProveedores.Row = _uiController.SelectedItem.ListaDePreciosProveedores.Items.Count - 1;
					
			}
            		
		}
		
		private void gridListaDePreciosProveedores_RecordsDeleted(object sender, EventArgs e)
		{
			_uiController.EliminarListaDePreciosProveedorSeleccionado();
			gridListaDePreciosProveedores.SelectionChanged +=new EventHandler(gridListaDePreciosProveedores_SelectionChanged);
			if(gridListaDePreciosProveedores.RecordCount > 0)
			{
				gridListaDePreciosProveedores.Row = 0;
				gridListaDePreciosProveedores.Select();
				this.gridListaDePreciosProveedores_SelectionChanged(gridListaDePreciosProveedores, new EventArgs());		

			}
		}

		private void gridListaDePreciosProveedores_DeletingRecords(object sender, CancelEventArgs e)
		{
			gridListaDePreciosProveedores.SelectionChanged -=new EventHandler(gridListaDePreciosProveedores_SelectionChanged);
			if(gridListaDePreciosProveedores.SelectedItems.Count > 0)
			{
				businessrules.ListaDePreciosProveedoresItem itemDeleting = (businessrules.ListaDePreciosProveedoresItem)gridListaDePreciosProveedores.SelectedItems[0].GetRow().DataRow;					
				if(itemDeleting.Estado.Equals("NEW"))
				{
					_uiController.SetListaDePreciosProveedoresItemABorrar(itemDeleting);
				}
				else e.Cancel = true;
			}			
		}

		private void btnEliminarListaDePreciosProv_Click(object sender, System.EventArgs e)
		{
			gridListaDePreciosProveedores.Delete();
		}

		private void utbAolicaCoeficienteSobrePrecioCostoListaProveedor_Click(object sender, EventArgs e)
		{
			decimal coef = Convert.ToDecimal(uneCoeficientePrecioCostoListaProveedor.Value);
			_uiController.AplicarCoeficienteSobrePrecioCostoListaProveedor(coef);
		}

		private void unePrecioVentaBruto_DoubleClick(object sender, EventArgs e)
		{
			if(!_uiController.PrecioDeVentaAfectaMac)
			{
				_uiController.PrecioDeVentaBruto = (decimal)unePrecioDeVentaNeto.Value;		
				unePrecioVentaBruto.Value = unePrecioDeVentaNeto.Value;		
			}
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

		private void chkUsaPrecioDeCostoReposicion_CheckedChanged(object sender, EventArgs e)
		{
			_uiController.UsaPrecioDeCostoReposicion = chkUsaPrecioDeCostoReposicion.Checked;
		}

		private void chkUsaPrecioDeCostoReposicion1_CheckedChanged(object sender, EventArgs e)
		{
			_uiController.UsaPrecioDeCostoReposicion = chkUsaPrecioDeCostoReposicion1.Checked;
		}


		private void _uiController_PrecioDeCostoMonedaProveedorChanged(object sender, EventArgs e)
		{
			
		
			if(_uiController.UsaPrecioDeListaProveedor)
			{

                //German 20120522 - Tarea 0000333
                if (_uiController.NoTrasladaSiempreCambioPrecioDeCompraAPrecioDeCostoReposicion)//Variable para ver si pregunta si se debe trasladar el cambio en el precio de la factura al precio de costo reposicion
                {
                    if (_uiController.PreguntaTrasladaCambioPrecioDeCompraAPrecioDeCostoReposicion)
                    {
                        System.Windows.Forms.DialogResult result = MessageBox.Show("¿Desea que el nuevo precio unitario pase a ser el precio de costo reposición?", "Confirmación", System.Windows.Forms.MessageBoxButtons.YesNo);
                        if (result.Equals(System.Windows.Forms.DialogResult.Yes))
                        {
                            _uiController.ActualizarPrecioDeCostoReposicionConPrecioDeCostoMonedaProveedor();

                        }
                    }
                }
                else
                {
                    if (_uiController.ActualizaPrecioDeCostoReposicion)
                        //German 20091223
                        //_uiController.ActualizarPrecioDeCostoReposicionConPrecioDeCostoMonedaProveedor();
                        _uiController.ActualizarPrecioDeCostoReposicionConPrecioDeCostoMonedaProveedor();
                    //Fin German 20091223
                    else
                    {
                        if (_consultarSiModificaElPCReposicion)
                        {
                            System.Windows.Forms.DialogResult result = MessageBox.Show("¿Desea que el nuevo precio unitario pase a ser el precio de costo reposición?", "Confirmación", System.Windows.Forms.MessageBoxButtons.YesNo);
                            if (result.Equals(System.Windows.Forms.DialogResult.Yes))
                            {
                                _uiController.ActualizarPrecioDeCostoReposicionConPrecioDeCostoMonedaProveedor();
                                chckActualizaPcioCostoReposicion.Visible = true;
                                chckActualizaPcioCostoReposicion.Enabled = true;
                                chckActualizaPcioCostoReposicion.Checked = true;

                            }
                            _consultarSiModificaElPCReposicion = false;
                        }
                    }
                }
                //Fin German 20120522 - Tarea 0000333
				
			}
			
			//German 20090914
			/*
			else 
				_uiController.ActualizarPrecioDeCostoReposicionConPrecioDeCostoMonedaProveedor();
			*/
			//German 20091223
			if(!_uiController.UsaPrecioDeListaProveedor)
			{
			//Fin German 20091223
			
				if(_uiController.ActualizaPrecioDeCostoReposicion)
					_uiController.ActualizarPrecioDeCostoReposicionConPrecioDeCostoMonedaProveedor();
				else
				{
					if(_consultarSiModificaElPCReposicion)
					{
						System.Windows.Forms.DialogResult result = MessageBox.Show("¿Desea que el nuevo precio unitario pase a ser el precio de costo reposición?", "Confirmación",System.Windows.Forms.MessageBoxButtons.YesNo);
						if(result.Equals(System.Windows.Forms.DialogResult.Yes))
						{
							_uiController.ActualizarPrecioDeCostoReposicionConPrecioDeCostoMonedaProveedor();
							chckActualizaPcioCostoReposicion.Visible = true;
							chckActualizaPcioCostoReposicion.Enabled = true;
							chckActualizaPcioCostoReposicion.Checked = true;

						}
						_consultarSiModificaElPCReposicion = false;
					}
				}
				//Fin German 20090914
			//German 20091223
			}
			//Fin German 20091223
		}

		private void chckActualizaPcioCostoReposicion_CheckedChanged(object sender, EventArgs e)
		{
			_uiController.ActualizaPrecioDeCostoReposicion = chckActualizaPcioCostoReposicion.Checked;
			//German 20090914
			if(_uiController.UsaPrecioDeListaProveedor)
			{
				if(!chckActualizaPcioCostoReposicion.Checked && !_uiController.SelectedItem.IdProveedorDefaultAnterior.Equals("null"))
				{
					_uiController.DeshacerActualizarPrecioDeCostoReposicionConPrecioDeCostoMonedaProveedor();

				}
			
				if(_cambiarProvDefaultEnGrilla)
				{
					_uiController.CellEdited(_uiController.ActualizaPrecioDeCostoReposicion);
					gridListaDePreciosProveedores.Update();		
				}
			}
			else
				if(_uiController.ActualizaPrecioDeCostoReposicion)
					_uiController.ActualizarPrecioDeCostoReposicionConPrecioDeCostoMonedaProveedor();
			//German 20090914

		}

		private void chckBonificacionesAcumulativas_CheckedChanged(object sender, EventArgs e)
		{
			_uiController.BonificacionAcumulativa = chckBonificacionesAcumulativas.Checked;
		}

		//Matias 20100612 - Tarea 22
		#region Miembros de ISearchObjectListener
		public void processEventChange(object sender, EventArgs e)
		{
			
		}
		#endregion
		//Fin Matias 20100612 - Tarea 22
	}
}

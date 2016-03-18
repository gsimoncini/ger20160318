using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.commontypes;
using mz.erp.ui.forms.classes;
using mz.erp.ui.utility;


namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmConsultaValores.
	/// </summary>
	public class FrmConsultaValores : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbBuscar;
		private System.Windows.Forms.ToolBarButton tbbSeparador1;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbNuevo;
		private System.Windows.Forms.ToolBarButton tbbSeparator3;
		private System.Windows.Forms.ToolBarButton tbbEditar;
		private System.Windows.Forms.ToolBarButton tbbSeparator4;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator5;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeprardor6;
		private System.Windows.Forms.ToolBarButton tbbAceptar;
		private System.Windows.Forms.ToolBarButton tbbSeparator7;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Infragistics.Win.UltraWinTabControl.UltraTabControl utcDetalles;
		private Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage ultraTabSharedControlsPage1;
		private Janus.Windows.GridEX.GridEX gridResultado;
		private Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage ultraTabSharedControlsPage2;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl utpFiltroPrincipal;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl utpFiltroSecundario;
		private Infragistics.Win.UltraWinTabControl.UltraTabControl utcFiltros;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkActivo;
		private System.Windows.Forms.TextBox txtCampoAux3;
		private System.Windows.Forms.Label labelCampoAux3;
		private System.Windows.Forms.TextBox txtCampoAux2;
		private System.Windows.Forms.Label labelCampoAux2;
		private System.Windows.Forms.TextBox txtCampoAux1;
		private System.Windows.Forms.Label labelCampoAux1;
		private System.Windows.Forms.TextBox txtEmail;
		private mz.erp.ui.controls.mzComboEditor mzCETipoDoc;
		private mz.erp.ui.controls.mzComboEditor mzCEComprobanteTesoreria;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lFechaVencimiento;
		private System.Windows.Forms.Label lFecha;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udtFechaVencimientoDesde;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udtFechaEmisionDesde;
		private System.Windows.Forms.CheckBox chkHabilitaFechaEmision;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udtFechaEmisionHasta;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udtFechaVencimientoHasta;
		private System.Windows.Forms.CheckBox chkHabilitaFechaVencimiento;
		private System.Windows.Forms.TextBox txtNumero;
		private mz.erp.ui.controls.mzComboEditor mzCEEntidad;
		private System.Windows.Forms.Label lEntidad;
		private System.Windows.Forms.Label lNumero;
		private System.Windows.Forms.Label label2;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneImporteDesde;
		private mz.erp.ui.controls.mzComboEditor mzCEMonedaOrigen;
		private System.Windows.Forms.CheckBox chkHabilitaImporteDesde;
		private System.Windows.Forms.CheckBox chkHabilitaImporteHasta;
		private mz.erp.ui.controls.mzComboEditor mzCEMonedaOrigen1;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneImporteHasta;
		private System.Windows.Forms.Panel panelTarjeta;
		private System.Windows.Forms.TextBox codigoDiez;
		private System.Windows.Forms.Label label25;
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
		private System.Windows.Forms.CheckBox chkHabilitaFechaAutorizacion;
		private System.Windows.Forms.CheckBox chkHabilitaFechaAcreditacion;
		private System.Windows.Forms.Panel panelCheque;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor fechaPago;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor fechaIngresoBanco;
		private System.Windows.Forms.TextBox NroBoleta;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.CheckBox esCliente;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit sucursal;
		private System.Windows.Forms.Label label14;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor fechaRecepcion;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox cuentaBancaria;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox librador;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.CheckBox chkHabilitaFechaRecepcion;
		private System.Windows.Forms.CheckBox chkHabilitaFechaPago;
		private System.Windows.Forms.CheckBox chkHabilitaFechaIngresoBanco;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCantidadCuotas;
		private System.Windows.Forms.CheckBox chkHabilitaCantidadCuotas;
		//private mz.erp.ui.controls.GridManagerView gridManagerView1;
		//private mz.erp.ui.controls.mzCuentasControl mzCmbSearchLibrador;
		private System.Windows.Forms.CheckBox chkHabilitaEntidad;
		private System.Windows.Forms.Panel panelRetenciones;
		private System.Windows.Forms.CheckBox chkHabilitaFechaComprobanteRetencion;
		private System.Windows.Forms.CheckBox chkHabilitaFechaIngresoRetencion;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udtFechaIngresoRetencion;
		private System.Windows.Forms.Label label19;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udtFechaComprobanteRetencion;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label22;
		private mz.erp.ui.controls.mzComboEditor mzCmbTipoRetenciones;
		private System.Windows.Forms.CheckBox chkHabilitaTipoRetencion;
		private mz.erp.ui.controls.mzComboEditor mzCEFamiliaFormaDePago;
		private Janus.Windows.GridEX.GridEX gridCajas;
		private Janus.Windows.GridEX.GridEX gridEX1;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItemTodos;
		private System.Windows.Forms.MenuItem menuItemNinguno;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private mz.erp.ui.controls.mzCuentasControl mzCmbSearchLibrador;
		private System.Windows.Forms.ToolBarButton tbbReiniciarFiltros;
		private System.ComponentModel.IContainer components;

		public FrmConsultaValores( mz.erp.ui.controllers.ConsultaValoresController UIController)
		{
			InitializeComponent();
			_uiController = UIController;
		}

		public FrmConsultaValores(string ProcessName, string TaskName, string IdInstanciaCaja)
		{
			InitializeComponent();
			_uiController = new mz.erp.ui.controllers.ConsultaValoresController(ProcessName, TaskName, IdInstanciaCaja);
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
				_uiController.IdTDCompTesoreriaChanged -=new EventHandler(_uiController_IdTDCompTesoreriaChanged);
				_uiController.KeyFamiliaChanged -=new EventHandler(_uiController_KeyFamiliaChanged);
				_uiController.ModelChanged -=new EventHandler(_uiController_ModelChanged);
				BindingController.Clear(mzCEComprobanteTesoreria, "Value", _uiController, "IdTDCompTesoreria");
				BindingController.Clear(mzCEFamiliaFormaDePago, "Value", _uiController, "Jerarquia");
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
			Infragistics.Win.UltraWinTabControl.UltraTab ultraTab1 = new Infragistics.Win.UltraWinTabControl.UltraTab();
			Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
			Infragistics.Win.UltraWinTabControl.UltraTab ultraTab2 = new Infragistics.Win.UltraWinTabControl.UltraTab();
			Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmConsultaValores));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.utpFiltroPrincipal = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
			this.gridEX1 = new Janus.Windows.GridEX.GridEX();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItemTodos = new System.Windows.Forms.MenuItem();
			this.menuItemNinguno = new System.Windows.Forms.MenuItem();
			this.mzCEFamiliaFormaDePago = new mz.erp.ui.controls.mzComboEditor();
			this.chkHabilitaEntidad = new System.Windows.Forms.CheckBox();
			this.chkHabilitaImporteHasta = new System.Windows.Forms.CheckBox();
			this.mzCEMonedaOrigen1 = new mz.erp.ui.controls.mzComboEditor();
			this.uneImporteHasta = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.chkHabilitaImporteDesde = new System.Windows.Forms.CheckBox();
			this.mzCEMonedaOrigen = new mz.erp.ui.controls.mzComboEditor();
			this.uneImporteDesde = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.mzCEEntidad = new mz.erp.ui.controls.mzComboEditor();
			this.lEntidad = new System.Windows.Forms.Label();
			this.lNumero = new System.Windows.Forms.Label();
			this.chkHabilitaFechaVencimiento = new System.Windows.Forms.CheckBox();
			this.udtFechaVencimientoHasta = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.udtFechaEmisionHasta = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.chkHabilitaFechaEmision = new System.Windows.Forms.CheckBox();
			this.udtFechaVencimientoDesde = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.udtFechaEmisionDesde = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.lFechaVencimiento = new System.Windows.Forms.Label();
			this.lFecha = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.mzCEComprobanteTesoreria = new mz.erp.ui.controls.mzComboEditor();
			this.label7 = new System.Windows.Forms.Label();
			this.utpFiltroSecundario = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
			this.panelRetenciones = new System.Windows.Forms.Panel();
			this.chkHabilitaTipoRetencion = new System.Windows.Forms.CheckBox();
			this.mzCmbTipoRetenciones = new mz.erp.ui.controls.mzComboEditor();
			this.chkHabilitaFechaComprobanteRetencion = new System.Windows.Forms.CheckBox();
			this.chkHabilitaFechaIngresoRetencion = new System.Windows.Forms.CheckBox();
			this.udtFechaIngresoRetencion = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.label19 = new System.Windows.Forms.Label();
			this.udtFechaComprobanteRetencion = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.label20 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.panelCheque = new System.Windows.Forms.Panel();
			this.librador = new System.Windows.Forms.TextBox();
			this.chkHabilitaFechaPago = new System.Windows.Forms.CheckBox();
			this.chkHabilitaFechaIngresoBanco = new System.Windows.Forms.CheckBox();
			this.chkHabilitaFechaRecepcion = new System.Windows.Forms.CheckBox();
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
			this.label18 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.mzCmbSearchLibrador = new mz.erp.ui.controls.mzCuentasControl();
			this.panelTarjeta = new System.Windows.Forms.Panel();
			this.chkHabilitaCantidadCuotas = new System.Windows.Forms.CheckBox();
			this.uneCantidadCuotas = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.chkHabilitaFechaAcreditacion = new System.Windows.Forms.CheckBox();
			this.chkHabilitaFechaAutorizacion = new System.Windows.Forms.CheckBox();
			this.codigoDiez = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
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
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.utcFiltros = new Infragistics.Win.UltraWinTabControl.UltraTabControl();
			this.ultraTabSharedControlsPage2 = new Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.utcDetalles = new Infragistics.Win.UltraWinTabControl.UltraTabControl();
			this.ultraTabSharedControlsPage1 = new Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage();
			this.gridResultado = new Janus.Windows.GridEX.GridEX();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbBuscar = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparador1 = new System.Windows.Forms.ToolBarButton();
			this.tbbReiniciarFiltros = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbNuevo = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator3 = new System.Windows.Forms.ToolBarButton();
			this.tbbEditar = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator4 = new System.Windows.Forms.ToolBarButton();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator5 = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeprardor6 = new System.Windows.Forms.ToolBarButton();
			this.tbbAceptar = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator7 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.chkActivo = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.txtCampoAux3 = new System.Windows.Forms.TextBox();
			this.labelCampoAux3 = new System.Windows.Forms.Label();
			this.txtCampoAux2 = new System.Windows.Forms.TextBox();
			this.labelCampoAux2 = new System.Windows.Forms.Label();
			this.txtCampoAux1 = new System.Windows.Forms.TextBox();
			this.labelCampoAux1 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.mzCETipoDoc = new mz.erp.ui.controls.mzComboEditor();
			this.gridCajas = new Janus.Windows.GridEX.GridEX();
			this.utpFiltroPrincipal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEFamiliaFormaDePago)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMonedaOrigen1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneImporteHasta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMonedaOrigen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneImporteDesde)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEEntidad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udtFechaVencimientoHasta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udtFechaEmisionHasta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udtFechaVencimientoDesde)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udtFechaEmisionDesde)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEComprobanteTesoreria)).BeginInit();
			this.utpFiltroSecundario.SuspendLayout();
			this.panelRetenciones.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTipoRetenciones)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udtFechaIngresoRetencion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udtFechaComprobanteRetencion)).BeginInit();
			this.panelCheque.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fechaPago)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fechaIngresoBanco)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fechaRecepcion)).BeginInit();
			this.panelTarjeta.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uneCantidadCuotas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fechaAutorizacion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fechaAcreditacion)).BeginInit();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.utcFiltros)).BeginInit();
			this.utcFiltros.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.utcDetalles)).BeginInit();
			this.utcDetalles.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCETipoDoc)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridCajas)).BeginInit();
			this.SuspendLayout();
			// 
			// utpFiltroPrincipal
			// 
			this.utpFiltroPrincipal.Controls.Add(this.gridEX1);
			this.utpFiltroPrincipal.Controls.Add(this.mzCEFamiliaFormaDePago);
			this.utpFiltroPrincipal.Controls.Add(this.chkHabilitaEntidad);
			this.utpFiltroPrincipal.Controls.Add(this.chkHabilitaImporteHasta);
			this.utpFiltroPrincipal.Controls.Add(this.mzCEMonedaOrigen1);
			this.utpFiltroPrincipal.Controls.Add(this.uneImporteHasta);
			this.utpFiltroPrincipal.Controls.Add(this.chkHabilitaImporteDesde);
			this.utpFiltroPrincipal.Controls.Add(this.mzCEMonedaOrigen);
			this.utpFiltroPrincipal.Controls.Add(this.uneImporteDesde);
			this.utpFiltroPrincipal.Controls.Add(this.label2);
			this.utpFiltroPrincipal.Controls.Add(this.txtNumero);
			this.utpFiltroPrincipal.Controls.Add(this.mzCEEntidad);
			this.utpFiltroPrincipal.Controls.Add(this.lEntidad);
			this.utpFiltroPrincipal.Controls.Add(this.lNumero);
			this.utpFiltroPrincipal.Controls.Add(this.chkHabilitaFechaVencimiento);
			this.utpFiltroPrincipal.Controls.Add(this.udtFechaVencimientoHasta);
			this.utpFiltroPrincipal.Controls.Add(this.udtFechaEmisionHasta);
			this.utpFiltroPrincipal.Controls.Add(this.chkHabilitaFechaEmision);
			this.utpFiltroPrincipal.Controls.Add(this.udtFechaVencimientoDesde);
			this.utpFiltroPrincipal.Controls.Add(this.udtFechaEmisionDesde);
			this.utpFiltroPrincipal.Controls.Add(this.lFechaVencimiento);
			this.utpFiltroPrincipal.Controls.Add(this.lFecha);
			this.utpFiltroPrincipal.Controls.Add(this.label1);
			this.utpFiltroPrincipal.Controls.Add(this.mzCEComprobanteTesoreria);
			this.utpFiltroPrincipal.Controls.Add(this.label7);
			this.utpFiltroPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
			this.utpFiltroPrincipal.Location = new System.Drawing.Point(1, 23);
			this.utpFiltroPrincipal.Name = "utpFiltroPrincipal";
			this.utpFiltroPrincipal.Size = new System.Drawing.Size(850, 104);
			// 
			// gridEX1
			// 
			this.gridEX1.ContextMenu = this.contextMenu1;
			this.gridEX1.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEX1.GroupByBoxVisible = false;
			this.gridEX1.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridEX1.Location = new System.Drawing.Point(584, 4);
			this.gridEX1.Name = "gridEX1";
			this.gridEX1.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridEX1.Size = new System.Drawing.Size(240, 94);
			this.gridEX1.TabIndex = 17;
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItemTodos,
																					  this.menuItemNinguno});
			this.menuItem1.Text = "Seleccionar";
			// 
			// menuItemTodos
			// 
			this.menuItemTodos.Index = 0;
			this.menuItemTodos.Text = "Todas";
			// 
			// menuItemNinguno
			// 
			this.menuItemNinguno.Index = 1;
			this.menuItemNinguno.Text = "Ninguna";
			// 
			// mzCEFamiliaFormaDePago
			// 
			this.mzCEFamiliaFormaDePago.AutoComplete = true;
			this.mzCEFamiliaFormaDePago.DataSource = null;
			this.mzCEFamiliaFormaDePago.DisplayMember = "";
			this.mzCEFamiliaFormaDePago.DisplayMemberCaption = "";
			this.mzCEFamiliaFormaDePago.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEFamiliaFormaDePago.Location = new System.Drawing.Point(99, 4);
			this.mzCEFamiliaFormaDePago.MaxItemsDisplay = 7;
			this.mzCEFamiliaFormaDePago.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEFamiliaFormaDePago.Name = "mzCEFamiliaFormaDePago";
			this.mzCEFamiliaFormaDePago.Size = new System.Drawing.Size(197, 21);
			this.mzCEFamiliaFormaDePago.SorterMember = "";
			this.mzCEFamiliaFormaDePago.TabIndex = 0;
			this.mzCEFamiliaFormaDePago.ValueMember = "";
			this.mzCEFamiliaFormaDePago.ValueMemberCaption = "";
			// 
			// chkHabilitaEntidad
			// 
			this.chkHabilitaEntidad.Location = new System.Drawing.Point(546, 27);
			this.chkHabilitaEntidad.Name = "chkHabilitaEntidad";
			this.chkHabilitaEntidad.Size = new System.Drawing.Size(16, 24);
			this.chkHabilitaEntidad.TabIndex = 15;
			// 
			// chkHabilitaImporteHasta
			// 
			this.chkHabilitaImporteHasta.Location = new System.Drawing.Point(546, 75);
			this.chkHabilitaImporteHasta.Name = "chkHabilitaImporteHasta";
			this.chkHabilitaImporteHasta.Size = new System.Drawing.Size(16, 24);
			this.chkHabilitaImporteHasta.TabIndex = 16;
			// 
			// mzCEMonedaOrigen1
			// 
			this.mzCEMonedaOrigen1.AutoComplete = true;
			this.mzCEMonedaOrigen1.DataSource = null;
			this.mzCEMonedaOrigen1.DisplayMember = "";
			this.mzCEMonedaOrigen1.DisplayMemberCaption = "";
			this.mzCEMonedaOrigen1.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEMonedaOrigen1.Location = new System.Drawing.Point(427, 76);
			this.mzCEMonedaOrigen1.MaxItemsDisplay = 7;
			this.mzCEMonedaOrigen1.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEMonedaOrigen1.Name = "mzCEMonedaOrigen1";
			this.mzCEMonedaOrigen1.Size = new System.Drawing.Size(112, 21);
			this.mzCEMonedaOrigen1.SorterMember = "";
			this.mzCEMonedaOrigen1.TabIndex = 14;
			this.mzCEMonedaOrigen1.ValueMember = "";
			this.mzCEMonedaOrigen1.ValueMemberCaption = "";
			// 
			// uneImporteHasta
			// 
			this.uneImporteHasta.Location = new System.Drawing.Point(324, 76);
			this.uneImporteHasta.MinValue = 0;
			this.uneImporteHasta.Name = "uneImporteHasta";
			this.uneImporteHasta.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneImporteHasta.Size = new System.Drawing.Size(96, 21);
			this.uneImporteHasta.TabIndex = 13;
			// 
			// chkHabilitaImporteDesde
			// 
			this.chkHabilitaImporteDesde.Location = new System.Drawing.Point(300, 75);
			this.chkHabilitaImporteDesde.Name = "chkHabilitaImporteDesde";
			this.chkHabilitaImporteDesde.Size = new System.Drawing.Size(16, 24);
			this.chkHabilitaImporteDesde.TabIndex = 9;
			// 
			// mzCEMonedaOrigen
			// 
			this.mzCEMonedaOrigen.AutoComplete = true;
			this.mzCEMonedaOrigen.DataSource = null;
			this.mzCEMonedaOrigen.DisplayMember = "";
			this.mzCEMonedaOrigen.DisplayMemberCaption = "";
			this.mzCEMonedaOrigen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEMonedaOrigen.Location = new System.Drawing.Point(200, 76);
			this.mzCEMonedaOrigen.MaxItemsDisplay = 7;
			this.mzCEMonedaOrigen.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEMonedaOrigen.Name = "mzCEMonedaOrigen";
			this.mzCEMonedaOrigen.Size = new System.Drawing.Size(96, 21);
			this.mzCEMonedaOrigen.SorterMember = "";
			this.mzCEMonedaOrigen.TabIndex = 6;
			this.mzCEMonedaOrigen.ValueMember = "";
			this.mzCEMonedaOrigen.ValueMemberCaption = "";
			// 
			// uneImporteDesde
			// 
			this.uneImporteDesde.Location = new System.Drawing.Point(99, 76);
			this.uneImporteDesde.MinValue = 0;
			this.uneImporteDesde.Name = "uneImporteDesde";
			this.uneImporteDesde.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneImporteDesde.Size = new System.Drawing.Size(96, 21);
			this.uneImporteDesde.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(11, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 21);
			this.label2.TabIndex = 117;
			this.label2.Text = "Importe";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtNumero
			// 
			this.txtNumero.BackColor = System.Drawing.SystemColors.Window;
			this.txtNumero.Location = new System.Drawing.Point(371, 51);
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
			this.mzCEEntidad.Location = new System.Drawing.Point(371, 28);
			this.mzCEEntidad.MaxItemsDisplay = 7;
			this.mzCEEntidad.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEEntidad.Name = "mzCEEntidad";
			this.mzCEEntidad.Size = new System.Drawing.Size(168, 21);
			this.mzCEEntidad.SorterMember = "";
			this.mzCEEntidad.TabIndex = 11;
			this.mzCEEntidad.ValueMember = "";
			this.mzCEEntidad.ValueMemberCaption = "";
			// 
			// lEntidad
			// 
			this.lEntidad.BackColor = System.Drawing.Color.Transparent;
			this.lEntidad.Location = new System.Drawing.Point(323, 28);
			this.lEntidad.Name = "lEntidad";
			this.lEntidad.Size = new System.Drawing.Size(44, 21);
			this.lEntidad.TabIndex = 116;
			this.lEntidad.Text = "Entidad";
			this.lEntidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lNumero
			// 
			this.lNumero.BackColor = System.Drawing.Color.Transparent;
			this.lNumero.Location = new System.Drawing.Point(323, 51);
			this.lNumero.Name = "lNumero";
			this.lNumero.Size = new System.Drawing.Size(44, 20);
			this.lNumero.TabIndex = 115;
			this.lNumero.Text = "Número";
			this.lNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chkHabilitaFechaVencimiento
			// 
			this.chkHabilitaFechaVencimiento.Location = new System.Drawing.Point(300, 51);
			this.chkHabilitaFechaVencimiento.Name = "chkHabilitaFechaVencimiento";
			this.chkHabilitaFechaVencimiento.Size = new System.Drawing.Size(16, 24);
			this.chkHabilitaFechaVencimiento.TabIndex = 8;
			// 
			// udtFechaVencimientoHasta
			// 
			this.udtFechaVencimientoHasta.Location = new System.Drawing.Point(200, 51);
			this.udtFechaVencimientoHasta.Name = "udtFechaVencimientoHasta";
			this.udtFechaVencimientoHasta.Size = new System.Drawing.Size(96, 21);
			this.udtFechaVencimientoHasta.TabIndex = 5;
			// 
			// udtFechaEmisionHasta
			// 
			this.udtFechaEmisionHasta.Location = new System.Drawing.Point(200, 28);
			this.udtFechaEmisionHasta.Name = "udtFechaEmisionHasta";
			this.udtFechaEmisionHasta.Size = new System.Drawing.Size(96, 21);
			this.udtFechaEmisionHasta.TabIndex = 4;
			// 
			// chkHabilitaFechaEmision
			// 
			this.chkHabilitaFechaEmision.Location = new System.Drawing.Point(300, 28);
			this.chkHabilitaFechaEmision.Name = "chkHabilitaFechaEmision";
			this.chkHabilitaFechaEmision.Size = new System.Drawing.Size(16, 24);
			this.chkHabilitaFechaEmision.TabIndex = 7;
			// 
			// udtFechaVencimientoDesde
			// 
			this.udtFechaVencimientoDesde.Location = new System.Drawing.Point(99, 51);
			this.udtFechaVencimientoDesde.Name = "udtFechaVencimientoDesde";
			this.udtFechaVencimientoDesde.Size = new System.Drawing.Size(96, 21);
			this.udtFechaVencimientoDesde.TabIndex = 2;
			// 
			// udtFechaEmisionDesde
			// 
			this.udtFechaEmisionDesde.Location = new System.Drawing.Point(99, 28);
			this.udtFechaEmisionDesde.Name = "udtFechaEmisionDesde";
			this.udtFechaEmisionDesde.Size = new System.Drawing.Size(96, 21);
			this.udtFechaEmisionDesde.TabIndex = 1;
			// 
			// lFechaVencimiento
			// 
			this.lFechaVencimiento.BackColor = System.Drawing.Color.Transparent;
			this.lFechaVencimiento.Location = new System.Drawing.Point(11, 51);
			this.lFechaVencimiento.Name = "lFechaVencimiento";
			this.lFechaVencimiento.Size = new System.Drawing.Size(104, 21);
			this.lFechaVencimiento.TabIndex = 108;
			this.lFechaVencimiento.Text = "Fecha de Venc.";
			this.lFechaVencimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lFecha
			// 
			this.lFecha.BackColor = System.Drawing.Color.Transparent;
			this.lFecha.Location = new System.Drawing.Point(11, 28);
			this.lFecha.Name = "lFecha";
			this.lFecha.Size = new System.Drawing.Size(104, 21);
			this.lFecha.TabIndex = 107;
			this.lFecha.Text = "Fecha de Emisión";
			this.lFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(555, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 21);
			this.label1.TabIndex = 104;
			this.label1.Text = "Caja";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mzCEComprobanteTesoreria
			// 
			this.mzCEComprobanteTesoreria.AutoComplete = true;
			this.mzCEComprobanteTesoreria.DataSource = null;
			this.mzCEComprobanteTesoreria.DisplayMember = "";
			this.mzCEComprobanteTesoreria.DisplayMemberCaption = "";
			this.mzCEComprobanteTesoreria.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEComprobanteTesoreria.Location = new System.Drawing.Point(323, 4);
			this.mzCEComprobanteTesoreria.MaxItemsDisplay = 7;
			this.mzCEComprobanteTesoreria.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEComprobanteTesoreria.Name = "mzCEComprobanteTesoreria";
			this.mzCEComprobanteTesoreria.Size = new System.Drawing.Size(216, 21);
			this.mzCEComprobanteTesoreria.SorterMember = "";
			this.mzCEComprobanteTesoreria.TabIndex = 10;
			this.mzCEComprobanteTesoreria.ValueMember = "";
			this.mzCEComprobanteTesoreria.ValueMemberCaption = "";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(11, 5);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(104, 21);
			this.label7.TabIndex = 102;
			this.label7.Text = "Forma de Pago";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// utpFiltroSecundario
			// 
			this.utpFiltroSecundario.Controls.Add(this.panelRetenciones);
			this.utpFiltroSecundario.Controls.Add(this.panelCheque);
			this.utpFiltroSecundario.Controls.Add(this.panelTarjeta);
			this.utpFiltroSecundario.Cursor = System.Windows.Forms.Cursors.Hand;
			this.utpFiltroSecundario.Location = new System.Drawing.Point(-10000, -10000);
			this.utpFiltroSecundario.Name = "utpFiltroSecundario";
			this.utpFiltroSecundario.Size = new System.Drawing.Size(850, 104);
			// 
			// panelRetenciones
			// 
			this.panelRetenciones.BackColor = System.Drawing.Color.Transparent;
			this.panelRetenciones.Controls.Add(this.chkHabilitaTipoRetencion);
			this.panelRetenciones.Controls.Add(this.mzCmbTipoRetenciones);
			this.panelRetenciones.Controls.Add(this.chkHabilitaFechaComprobanteRetencion);
			this.panelRetenciones.Controls.Add(this.chkHabilitaFechaIngresoRetencion);
			this.panelRetenciones.Controls.Add(this.udtFechaIngresoRetencion);
			this.panelRetenciones.Controls.Add(this.label19);
			this.panelRetenciones.Controls.Add(this.udtFechaComprobanteRetencion);
			this.panelRetenciones.Controls.Add(this.label20);
			this.panelRetenciones.Controls.Add(this.label22);
			this.panelRetenciones.Location = new System.Drawing.Point(0, 0);
			this.panelRetenciones.Name = "panelRetenciones";
			this.panelRetenciones.Size = new System.Drawing.Size(816, 104);
			this.panelRetenciones.TabIndex = 103;
			// 
			// chkHabilitaTipoRetencion
			// 
			this.chkHabilitaTipoRetencion.Location = new System.Drawing.Point(328, 8);
			this.chkHabilitaTipoRetencion.Name = "chkHabilitaTipoRetencion";
			this.chkHabilitaTipoRetencion.Size = new System.Drawing.Size(16, 24);
			this.chkHabilitaTipoRetencion.TabIndex = 3;
			// 
			// mzCmbTipoRetenciones
			// 
			this.mzCmbTipoRetenciones.AutoComplete = true;
			this.mzCmbTipoRetenciones.DataSource = null;
			this.mzCmbTipoRetenciones.DisplayMember = "";
			this.mzCmbTipoRetenciones.DisplayMemberCaption = "";
			this.mzCmbTipoRetenciones.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbTipoRetenciones.Location = new System.Drawing.Point(152, 8);
			this.mzCmbTipoRetenciones.MaxItemsDisplay = 7;
			this.mzCmbTipoRetenciones.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbTipoRetenciones.Name = "mzCmbTipoRetenciones";
			this.mzCmbTipoRetenciones.NullText = "Ninguno";
			this.mzCmbTipoRetenciones.Size = new System.Drawing.Size(168, 21);
			this.mzCmbTipoRetenciones.SorterMember = "";
			this.mzCmbTipoRetenciones.TabIndex = 0;
			this.mzCmbTipoRetenciones.ValueMember = "";
			this.mzCmbTipoRetenciones.ValueMemberCaption = "";
			this.mzCmbTipoRetenciones.Visible = false;
			// 
			// chkHabilitaFechaComprobanteRetencion
			// 
			this.chkHabilitaFechaComprobanteRetencion.Location = new System.Drawing.Point(328, 56);
			this.chkHabilitaFechaComprobanteRetencion.Name = "chkHabilitaFechaComprobanteRetencion";
			this.chkHabilitaFechaComprobanteRetencion.Size = new System.Drawing.Size(16, 24);
			this.chkHabilitaFechaComprobanteRetencion.TabIndex = 5;
			// 
			// chkHabilitaFechaIngresoRetencion
			// 
			this.chkHabilitaFechaIngresoRetencion.Location = new System.Drawing.Point(328, 32);
			this.chkHabilitaFechaIngresoRetencion.Name = "chkHabilitaFechaIngresoRetencion";
			this.chkHabilitaFechaIngresoRetencion.Size = new System.Drawing.Size(16, 24);
			this.chkHabilitaFechaIngresoRetencion.TabIndex = 4;
			// 
			// udtFechaIngresoRetencion
			// 
			this.udtFechaIngresoRetencion.Location = new System.Drawing.Point(152, 32);
			this.udtFechaIngresoRetencion.Name = "udtFechaIngresoRetencion";
			this.udtFechaIngresoRetencion.Size = new System.Drawing.Size(168, 21);
			this.udtFechaIngresoRetencion.TabIndex = 1;
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Location = new System.Drawing.Point(8, 32);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(136, 20);
			this.label19.TabIndex = 100;
			this.label19.Text = "Fecha Ing. Retención";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// udtFechaComprobanteRetencion
			// 
			this.udtFechaComprobanteRetencion.Location = new System.Drawing.Point(152, 56);
			this.udtFechaComprobanteRetencion.Name = "udtFechaComprobanteRetencion";
			this.udtFechaComprobanteRetencion.Size = new System.Drawing.Size(168, 21);
			this.udtFechaComprobanteRetencion.TabIndex = 2;
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Location = new System.Drawing.Point(8, 56);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(136, 20);
			this.label20.TabIndex = 98;
			this.label20.Text = "Fecha Comp. Retención";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.Transparent;
			this.label22.Location = new System.Drawing.Point(8, 8);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(136, 20);
			this.label22.TabIndex = 94;
			this.label22.Text = "Tipo Retención";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelCheque
			// 
			this.panelCheque.BackColor = System.Drawing.Color.Transparent;
			this.panelCheque.Controls.Add(this.librador);
			this.panelCheque.Controls.Add(this.chkHabilitaFechaPago);
			this.panelCheque.Controls.Add(this.chkHabilitaFechaIngresoBanco);
			this.panelCheque.Controls.Add(this.chkHabilitaFechaRecepcion);
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
			this.panelCheque.Controls.Add(this.label18);
			this.panelCheque.Controls.Add(this.label24);
			this.panelCheque.Controls.Add(this.label15);
			this.panelCheque.Controls.Add(this.mzCmbSearchLibrador);
			this.panelCheque.Location = new System.Drawing.Point(0, 0);
			this.panelCheque.Name = "panelCheque";
			this.panelCheque.Size = new System.Drawing.Size(824, 104);
			this.panelCheque.TabIndex = 102;
			// 
			// librador
			// 
			this.librador.BackColor = System.Drawing.SystemColors.Window;
			this.librador.Location = new System.Drawing.Point(256, 8);
			this.librador.Name = "librador";
			this.librador.Size = new System.Drawing.Size(352, 20);
			this.librador.TabIndex = 23;
			this.librador.Text = "";
			// 
			// chkHabilitaFechaPago
			// 
			this.chkHabilitaFechaPago.Location = new System.Drawing.Point(761, 74);
			this.chkHabilitaFechaPago.Name = "chkHabilitaFechaPago";
			this.chkHabilitaFechaPago.Size = new System.Drawing.Size(16, 24);
			this.chkHabilitaFechaPago.TabIndex = 123;
			// 
			// chkHabilitaFechaIngresoBanco
			// 
			this.chkHabilitaFechaIngresoBanco.Location = new System.Drawing.Point(760, 50);
			this.chkHabilitaFechaIngresoBanco.Name = "chkHabilitaFechaIngresoBanco";
			this.chkHabilitaFechaIngresoBanco.Size = new System.Drawing.Size(16, 24);
			this.chkHabilitaFechaIngresoBanco.TabIndex = 122;
			// 
			// chkHabilitaFechaRecepcion
			// 
			this.chkHabilitaFechaRecepcion.Location = new System.Drawing.Point(331, 76);
			this.chkHabilitaFechaRecepcion.Name = "chkHabilitaFechaRecepcion";
			this.chkHabilitaFechaRecepcion.Size = new System.Drawing.Size(16, 24);
			this.chkHabilitaFechaRecepcion.TabIndex = 121;
			// 
			// fechaPago
			// 
			this.fechaPago.Location = new System.Drawing.Point(584, 77);
			this.fechaPago.Name = "fechaPago";
			this.fechaPago.Size = new System.Drawing.Size(168, 21);
			this.fechaPago.TabIndex = 29;
			// 
			// fechaIngresoBanco
			// 
			this.fechaIngresoBanco.Location = new System.Drawing.Point(584, 53);
			this.fechaIngresoBanco.Name = "fechaIngresoBanco";
			this.fechaIngresoBanco.Size = new System.Drawing.Size(168, 21);
			this.fechaIngresoBanco.TabIndex = 28;
			// 
			// NroBoleta
			// 
			this.NroBoleta.BackColor = System.Drawing.SystemColors.Window;
			this.NroBoleta.Location = new System.Drawing.Point(584, 29);
			this.NroBoleta.Name = "NroBoleta";
			this.NroBoleta.Size = new System.Drawing.Size(168, 20);
			this.NroBoleta.TabIndex = 27;
			this.NroBoleta.Text = "";
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.Transparent;
			this.label23.Location = new System.Drawing.Point(472, 29);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(96, 20);
			this.label23.TabIndex = 111;
			this.label23.Text = "Nro de boleta";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Location = new System.Drawing.Point(8, 5);
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
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Location = new System.Drawing.Point(208, 5);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(56, 20);
			this.label18.TabIndex = 94;
			this.label18.Text = "Librador";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.Transparent;
			this.label24.Location = new System.Drawing.Point(472, 53);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(112, 20);
			this.label24.TabIndex = 113;
			this.label24.Text = "Fecha ing. al banco";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Location = new System.Drawing.Point(472, 77);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(104, 20);
			this.label15.TabIndex = 100;
			this.label15.Text = "Fecha de pago";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mzCmbSearchLibrador
			// 
			this.mzCmbSearchLibrador.AllowEditClientePaso = false;
			this.mzCmbSearchLibrador.BackColor = System.Drawing.Color.Transparent;
			this.mzCmbSearchLibrador.DataValue = "";
			this.mzCmbSearchLibrador.EnableCtaCte = false;
			this.mzCmbSearchLibrador.FastSearch = false;
			this.mzCmbSearchLibrador.Location = new System.Drawing.Point(256, 8);
			this.mzCmbSearchLibrador.Name = "mzCmbSearchLibrador";
			this.mzCmbSearchLibrador.SearchObjectListener = null;
			this.mzCmbSearchLibrador.Size = new System.Drawing.Size(352, 20);
			this.mzCmbSearchLibrador.TabIndex = 124;
			// 
			// panelTarjeta
			// 
			this.panelTarjeta.BackColor = System.Drawing.Color.Transparent;
			this.panelTarjeta.Controls.Add(this.chkHabilitaCantidadCuotas);
			this.panelTarjeta.Controls.Add(this.uneCantidadCuotas);
			this.panelTarjeta.Controls.Add(this.chkHabilitaFechaAcreditacion);
			this.panelTarjeta.Controls.Add(this.chkHabilitaFechaAutorizacion);
			this.panelTarjeta.Controls.Add(this.codigoDiez);
			this.panelTarjeta.Controls.Add(this.label25);
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
			this.panelTarjeta.Location = new System.Drawing.Point(8, 0);
			this.panelTarjeta.Name = "panelTarjeta";
			this.panelTarjeta.Size = new System.Drawing.Size(816, 104);
			this.panelTarjeta.TabIndex = 101;
			// 
			// chkHabilitaCantidadCuotas
			// 
			this.chkHabilitaCantidadCuotas.Location = new System.Drawing.Point(712, 55);
			this.chkHabilitaCantidadCuotas.Name = "chkHabilitaCantidadCuotas";
			this.chkHabilitaCantidadCuotas.Size = new System.Drawing.Size(16, 24);
			this.chkHabilitaCantidadCuotas.TabIndex = 120;
			// 
			// uneCantidadCuotas
			// 
			this.uneCantidadCuotas.Location = new System.Drawing.Point(536, 55);
			this.uneCantidadCuotas.MaxValue = 12;
			this.uneCantidadCuotas.MinValue = 1;
			this.uneCantidadCuotas.Name = "uneCantidadCuotas";
			this.uneCantidadCuotas.Size = new System.Drawing.Size(168, 21);
			this.uneCantidadCuotas.TabIndex = 119;
			// 
			// chkHabilitaFechaAcreditacion
			// 
			this.chkHabilitaFechaAcreditacion.Location = new System.Drawing.Point(712, 27);
			this.chkHabilitaFechaAcreditacion.Name = "chkHabilitaFechaAcreditacion";
			this.chkHabilitaFechaAcreditacion.Size = new System.Drawing.Size(16, 24);
			this.chkHabilitaFechaAcreditacion.TabIndex = 111;
			// 
			// chkHabilitaFechaAutorizacion
			// 
			this.chkHabilitaFechaAutorizacion.Location = new System.Drawing.Point(328, 49);
			this.chkHabilitaFechaAutorizacion.Name = "chkHabilitaFechaAutorizacion";
			this.chkHabilitaFechaAutorizacion.Size = new System.Drawing.Size(16, 24);
			this.chkHabilitaFechaAutorizacion.TabIndex = 110;
			// 
			// codigoDiez
			// 
			this.codigoDiez.BackColor = System.Drawing.SystemColors.Window;
			this.codigoDiez.Location = new System.Drawing.Point(536, 3);
			this.codigoDiez.Name = "codigoDiez";
			this.codigoDiez.Size = new System.Drawing.Size(168, 20);
			this.codigoDiez.TabIndex = 16;
			this.codigoDiez.Text = "";
			// 
			// label25
			// 
			this.label25.BackColor = System.Drawing.Color.Transparent;
			this.label25.Location = new System.Drawing.Point(424, 3);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(104, 20);
			this.label25.TabIndex = 107;
			this.label25.Text = "Código 10";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Location = new System.Drawing.Point(424, 54);
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
			this.fechaAcreditacion.Location = new System.Drawing.Point(536, 29);
			this.fechaAcreditacion.Name = "fechaAcreditacion";
			this.fechaAcreditacion.Size = new System.Drawing.Size(168, 21);
			this.fechaAcreditacion.TabIndex = 19;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(424, 29);
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
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.utcFiltros);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 49);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(854, 130);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// utcFiltros
			// 
			this.utcFiltros.BackColor = System.Drawing.Color.Transparent;
			this.utcFiltros.Controls.Add(this.ultraTabSharedControlsPage2);
			this.utcFiltros.Controls.Add(this.utpFiltroPrincipal);
			this.utcFiltros.Controls.Add(this.utpFiltroSecundario);
			this.utcFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
			this.utcFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
			this.utcFiltros.Location = new System.Drawing.Point(0, 0);
			this.utcFiltros.Name = "utcFiltros";
			this.utcFiltros.SharedControlsPage = this.ultraTabSharedControlsPage2;
			this.utcFiltros.Size = new System.Drawing.Size(854, 130);
			this.utcFiltros.TabIndex = 0;
			appearance1.BackColor = System.Drawing.Color.Transparent;
			ultraTab1.ActiveAppearance = appearance1;
			appearance2.BackColor = System.Drawing.Color.Transparent;
			ultraTab1.Appearance = appearance2;
			appearance3.BackColor = System.Drawing.Color.Transparent;
			ultraTab1.ClientAreaAppearance = appearance3;
			ultraTab1.Key = "FiltroPrincipal";
			ultraTab1.TabPage = this.utpFiltroPrincipal;
			ultraTab1.Text = "Filtro Principal";
			appearance4.BackColor = System.Drawing.Color.Transparent;
			ultraTab2.ActiveAppearance = appearance4;
			appearance5.BackColor = System.Drawing.Color.Transparent;
			ultraTab2.Appearance = appearance5;
			appearance6.BackColor = System.Drawing.Color.Transparent;
			ultraTab2.ClientAreaAppearance = appearance6;
			ultraTab2.Key = "FiltroSecundario";
			ultraTab2.TabPage = this.utpFiltroSecundario;
			ultraTab2.Text = "Filtro Secundario";
			this.utcFiltros.Tabs.AddRange(new Infragistics.Win.UltraWinTabControl.UltraTab[] {
																								 ultraTab1,
																								 ultraTab2});
			this.utcFiltros.TabStop = false;
			// 
			// ultraTabSharedControlsPage2
			// 
			this.ultraTabSharedControlsPage2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraTabSharedControlsPage2.Location = new System.Drawing.Point(-10000, -10000);
			this.ultraTabSharedControlsPage2.Name = "ultraTabSharedControlsPage2";
			this.ultraTabSharedControlsPage2.Size = new System.Drawing.Size(850, 104);
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.AutoScroll = true;
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridManagerView1);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.utcDetalles);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridResultado);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 238);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(854, 218);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
			this.gridManagerView1.Dock = System.Windows.Forms.DockStyle.Top;
			this.gridManagerView1.Location = new System.Drawing.Point(0, 0);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(896, 24);
			this.gridManagerView1.TabIndex = 0;
			// 
			// utcDetalles
			// 
			this.utcDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.utcDetalles.BackColor = System.Drawing.Color.Transparent;
			this.utcDetalles.Controls.Add(this.ultraTabSharedControlsPage1);
			this.utcDetalles.Location = new System.Drawing.Point(0, 160);
			this.utcDetalles.Name = "utcDetalles";
			this.utcDetalles.SharedControlsPage = this.ultraTabSharedControlsPage1;
			this.utcDetalles.Size = new System.Drawing.Size(762, 200);
			this.utcDetalles.TabIndex = 16;
			this.utcDetalles.Visible = false;
			// 
			// ultraTabSharedControlsPage1
			// 
			this.ultraTabSharedControlsPage1.Location = new System.Drawing.Point(1, 20);
			this.ultraTabSharedControlsPage1.Name = "ultraTabSharedControlsPage1";
			this.ultraTabSharedControlsPage1.Size = new System.Drawing.Size(758, 177);
			// 
			// gridResultado
			// 
			this.gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridResultado.AlternatingColors = true;
			this.gridResultado.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridResultado.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridResultado.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridResultado.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridResultado.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gridResultado.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gridResultado.GroupByBoxVisible = false;
			this.gridResultado.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridResultado.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridResultado.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gridResultado.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
			this.gridResultado.Location = new System.Drawing.Point(0, 32);
			this.gridResultado.Name = "gridResultado";
			this.gridResultado.RecordNavigatorText = "Registro:|de";
			this.gridResultado.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridResultado.ShowEmptyFields = false;
			this.gridResultado.Size = new System.Drawing.Size(896, 248);
			this.gridResultado.TabIndex = 1;
			this.gridResultado.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
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
																							  this.tbbBuscar,
																							  this.tbbSeparador1,
																							  this.tbbReiniciarFiltros,
																							  this.tbbSeparator2,
																							  this.tbbNuevo,
																							  this.tbbSeparator3,
																							  this.tbbEditar,
																							  this.tbbSeparator4,
																							  this.tbbAnterior,
																							  this.tbbSeparator5,
																							  this.tbbSiguiente,
																							  this.tbbSeprardor6,
																							  this.tbbAceptar,
																							  this.tbbSeparator7,
																							  this.tbbCancelar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(920, 28);
			this.toolBarStandar.TabIndex = 49;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// tbbBuscar
			// 
			this.tbbBuscar.ImageIndex = 2;
			this.tbbBuscar.Text = "[F2] Buscar ahora";
			// 
			// tbbSeparador1
			// 
			this.tbbSeparador1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbReiniciarFiltros
			// 
			this.tbbReiniciarFiltros.ImageIndex = 5;
			this.tbbReiniciarFiltros.Text = "Reiniciar Filtros de Busqueda";
			// 
			// tbbSeparator2
			// 
			this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.tbbSeparator2.Visible = false;
			// 
			// tbbNuevo
			// 
			this.tbbNuevo.ImageIndex = 11;
			this.tbbNuevo.Text = "Nuevo";
			this.tbbNuevo.Visible = false;
			// 
			// tbbSeparator3
			// 
			this.tbbSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.tbbSeparator3.Visible = false;
			// 
			// tbbEditar
			// 
			this.tbbEditar.ImageIndex = 6;
			this.tbbEditar.Text = "Editar";
			this.tbbEditar.Visible = false;
			// 
			// tbbSeparator4
			// 
			this.tbbSeparator4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.tbbSeparator4.Visible = false;
			// 
			// tbbAnterior
			// 
			this.tbbAnterior.ImageIndex = 9;
			this.tbbAnterior.Text = "&Anterior";
			this.tbbAnterior.Visible = false;
			// 
			// tbbSeparator5
			// 
			this.tbbSeparator5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.tbbSeparator5.Visible = false;
			// 
			// tbbSiguiente
			// 
			this.tbbSiguiente.ImageIndex = 8;
			this.tbbSiguiente.Text = "Siguiente";
			this.tbbSiguiente.Visible = false;
			// 
			// tbbSeprardor6
			// 
			this.tbbSeprardor6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.tbbSeprardor6.Visible = false;
			// 
			// tbbAceptar
			// 
			this.tbbAceptar.ImageIndex = 12;
			this.tbbAceptar.Text = "Aceptar";
			this.tbbAceptar.Visible = false;
			// 
			// tbbSeparator7
			// 
			this.tbbSeparator7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbCancelar
			// 
			this.tbbCancelar.ImageIndex = 7;
			this.tbbCancelar.Text = "Cancelar";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 130;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Filtros";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 218;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Detalle";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Scrollbars = Infragistics.Win.UltraWinExplorerBar.ScrollbarStyle.Always;
			this.ultraExplorerBar1.Size = new System.Drawing.Size(920, 490);
			this.ultraExplorerBar1.TabIndex = 81;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// chkActivo
			// 
			this.chkActivo.BackColor = System.Drawing.Color.Transparent;
			this.chkActivo.Checked = true;
			this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkActivo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkActivo.Location = new System.Drawing.Point(392, 27);
			this.chkActivo.Name = "chkActivo";
			this.chkActivo.Size = new System.Drawing.Size(56, 24);
			this.chkActivo.TabIndex = 6;
			this.chkActivo.Text = "Activo";
			// 
			// txtCampoAux3
			// 
			this.txtCampoAux3.Location = new System.Drawing.Point(488, 4);
			this.txtCampoAux3.Name = "txtCampoAux3";
			this.txtCampoAux3.Size = new System.Drawing.Size(272, 20);
			this.txtCampoAux3.TabIndex = 5;
			this.txtCampoAux3.Text = "";
			// 
			// labelCampoAux3
			// 
			this.labelCampoAux3.AutoSize = true;
			this.labelCampoAux3.BackColor = System.Drawing.Color.Transparent;
			this.labelCampoAux3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.labelCampoAux3.Location = new System.Drawing.Point(384, 8);
			this.labelCampoAux3.Name = "labelCampoAux3";
			this.labelCampoAux3.Size = new System.Drawing.Size(67, 16);
			this.labelCampoAux3.TabIndex = 17;
			this.labelCampoAux3.Text = "CampoAux3";
			// 
			// txtCampoAux2
			// 
			this.txtCampoAux2.Location = new System.Drawing.Point(104, 72);
			this.txtCampoAux2.Name = "txtCampoAux2";
			this.txtCampoAux2.Size = new System.Drawing.Size(272, 20);
			this.txtCampoAux2.TabIndex = 4;
			this.txtCampoAux2.Text = "";
			// 
			// labelCampoAux2
			// 
			this.labelCampoAux2.AutoSize = true;
			this.labelCampoAux2.BackColor = System.Drawing.Color.Transparent;
			this.labelCampoAux2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.labelCampoAux2.Location = new System.Drawing.Point(8, 76);
			this.labelCampoAux2.Name = "labelCampoAux2";
			this.labelCampoAux2.Size = new System.Drawing.Size(67, 16);
			this.labelCampoAux2.TabIndex = 15;
			this.labelCampoAux2.Text = "CampoAux2";
			// 
			// txtCampoAux1
			// 
			this.txtCampoAux1.Location = new System.Drawing.Point(104, 50);
			this.txtCampoAux1.Name = "txtCampoAux1";
			this.txtCampoAux1.Size = new System.Drawing.Size(272, 20);
			this.txtCampoAux1.TabIndex = 3;
			this.txtCampoAux1.Text = "";
			// 
			// labelCampoAux1
			// 
			this.labelCampoAux1.AutoSize = true;
			this.labelCampoAux1.BackColor = System.Drawing.Color.Transparent;
			this.labelCampoAux1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.labelCampoAux1.Location = new System.Drawing.Point(8, 54);
			this.labelCampoAux1.Name = "labelCampoAux1";
			this.labelCampoAux1.Size = new System.Drawing.Size(67, 16);
			this.labelCampoAux1.TabIndex = 13;
			this.labelCampoAux1.Text = "CampoAux1";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(104, 29);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(272, 20);
			this.txtEmail.TabIndex = 2;
			this.txtEmail.Text = "";
			// 
			// mzCETipoDoc
			// 
			this.mzCETipoDoc.AutoComplete = true;
			this.mzCETipoDoc.DataSource = null;
			this.mzCETipoDoc.DisplayMember = "";
			this.mzCETipoDoc.DisplayMemberCaption = "";
			this.mzCETipoDoc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCETipoDoc.ImageTransparentColor = System.Drawing.Color.Violet;
			this.mzCETipoDoc.Location = new System.Drawing.Point(104, 4);
			this.mzCETipoDoc.MaxItemsDisplay = 7;
			this.mzCETipoDoc.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCETipoDoc.Name = "mzCETipoDoc";
			this.mzCETipoDoc.Size = new System.Drawing.Size(145, 21);
			this.mzCETipoDoc.SorterMember = "";
			this.mzCETipoDoc.TabIndex = 0;
			this.mzCETipoDoc.ValueMember = "";
			this.mzCETipoDoc.ValueMemberCaption = "";
			// 
			// gridCajas
			// 
			this.gridCajas.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridCajas.GroupByBoxVisible = false;
			this.gridCajas.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridCajas.Location = new System.Drawing.Point(616, 112);
			this.gridCajas.Name = "gridCajas";
			this.gridCajas.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridCajas.Size = new System.Drawing.Size(232, 88);
			this.gridCajas.TabIndex = 129;
			// 
			// FrmConsultaValores
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(920, 518);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Controls.Add(this.gridCajas);
			this.Name = "FrmConsultaValores";
			this.Text = "FrmConsultaValores";
			this.utpFiltroPrincipal.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEFamiliaFormaDePago)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMonedaOrigen1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneImporteHasta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMonedaOrigen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneImporteDesde)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEEntidad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udtFechaVencimientoHasta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udtFechaEmisionHasta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udtFechaVencimientoDesde)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udtFechaEmisionDesde)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEComprobanteTesoreria)).EndInit();
			this.utpFiltroSecundario.ResumeLayout(false);
			this.panelRetenciones.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTipoRetenciones)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udtFechaIngresoRetencion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udtFechaComprobanteRetencion)).EndInit();
			this.panelCheque.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fechaPago)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fechaIngresoBanco)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fechaRecepcion)).EndInit();
			this.panelTarjeta.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uneCantidadCuotas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fechaAutorizacion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fechaAcreditacion)).EndInit();
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.utcFiltros)).EndInit();
			this.utcFiltros.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.utcDetalles)).EndInit();
			this.utcDetalles.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCETipoDoc)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridCajas)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region Variables Privadas

		private mz.erp.ui.controllers.ConsultaValoresController _uiController = null;

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
				this.Show();
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
			_uiController.Previous();
		}

		public void KeyDownNext()
		{
			gridResultado.UpdateData();
			_uiController.Execute();
		}

		#endregion

		#region Inicializadores y Carga
		public void Build_UI()
		{
			ConfigureInterface();	
			InitializeData();
			FillControls();
			InitDataBindings();
			InitEventHandlers();
			
			
		}
		private void ConfigureInterface()
		{	
			this.Text = "Consulta de Valores";
			this.KeyPreview = true;
			ConfigurePanels();
			gridManagerView1.Configure(_uiController.GetProcessName(), _uiController.GetTaskName(),this.Name, gridResultado, this.Text);
            FilterColumns();
			gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
			udtFechaEmisionDesde.Enabled = false;
			udtFechaEmisionHasta.Enabled = false;
			udtFechaVencimientoDesde.Enabled = false;
			udtFechaVencimientoHasta.Enabled = false;
			fechaAcreditacion.Enabled = false;
			fechaAutorizacion.Enabled = false;
			fechaIngresoBanco.Enabled = false;
			fechaPago.Enabled = false;
			fechaRecepcion.Enabled = false;
			uneImporteDesde.Enabled = false;
			uneImporteHasta.Enabled = false;
			mzCEMonedaOrigen.Enabled = false;
			mzCEMonedaOrigen1.Enabled = false;
			mzCEEntidad.Enabled = false;
			uneCantidadCuotas.Enabled = false;
			mzCmbTipoRetenciones.Enabled = false;
			udtFechaIngresoRetencion.Enabled = false;
			udtFechaComprobanteRetencion.Enabled = false;
			gridEX1.Enabled= _uiController.PermiteSeleccionarIdInstanciaCaja;
			//mzCECajas.Enabled = _uiController.PermiteSeleccionarIdInstanciaCaja;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			ConfigureToolBarButtons();
			mzCmbTipoRetenciones.Visible = true;
			gridEX1.LayoutData = _uiController.LayoutFiltroCajas;
			
		}
		private void ConfigureToolBarButtons()
		{
			tbbAceptar.Visible = !_uiController.IsWorkflow();
			tbbSeprardor6.Visible = !_uiController.IsWorkflow();
			tbbCancelar.Visible = !_uiController.IsWorkflow();
			tbbSeparator7.Visible = !_uiController.IsWorkflow();
			tbbSiguiente.Visible = _uiController.IsWorkflow();
			tbbSeparator4.Visible = _uiController.IsWorkflow();
			tbbAnterior.Visible = _uiController.IsWorkflow();
			tbbSeparator5.Visible = _uiController.IsWorkflow();
		}

		private void ConfigurePanels()
		{
			panelTarjeta.Visible = _uiController.PerteneceATarjeta();
			panelCheque.Visible = _uiController.PerteneceACheque();
			panelRetenciones.Visible = _uiController.PerteneceARetenciones();
			if (_uiController.PerteneceATarjeta())
			{
				lNumero.Text="Número de Tarjeta";
				lFechaVencimiento.Text = "Fecha de Validez";
			}
			if (_uiController.PerteneceACheque())
			{
				lNumero.Text="Número de Cheque";
				lFechaVencimiento.Text = "Fecha de Vencimiento";
			}
			//Es retencion :)
			if (_uiController.PerteneceARetenciones())
			{
				lNumero.Text="Número de Retención";
				lFecha.Text = "Fecha Ing. Retención";
				lFechaVencimiento.Text = "Fecha Retención";
				//lEntidad.Text = "Tipo de Retención";
				//mzCEEntidad.Visible = false;
				//mzCmbTipoRetenciones.Visible = true;
			}
			/*else
			{
				lEntidad.Text = "Entidad";
				mzCEEntidad.Visible = true;
				mzCmbTipoRetenciones.Visible = false;
			}*/
			
		}



		private void ConfigureTiposComprobantes()
		{
			//tarea=ConsultarValores
			//ProcesoDepositarCuentaCorriente
		}

		private void InitializeData()
		{
			mzCEEntidad.FillFromDataSource(_uiController.ListaEntidades,"IdEntidad","Entidad",100,"Entidad");
			mzCEMonedaOrigen.FillFromDataSource( businessrules.tfi_Monedas.GetList().tfi_Monedas, "idMoneda", "Descripcion", 8, "1", "2", "Descripcion");	
			mzCEMonedaOrigen1.FillFromDataSource( businessrules.tfi_Monedas.GetList().tfi_Monedas, "idMoneda", "Descripcion", 8, "1", "2", "Descripcion");	
			mzCmbTipoRetenciones.FillFromDataSource( businessrules.tsy_TiposDeRetenciones.GetList().tsy_TiposDeRetenciones, "idTipoDeRetencion", "Descripcion", 100, "Descripcion");
			mzCEFamiliaFormaDePago.FillFromDataSource( _uiController.GetTableFamiliasTDCompTesoreria(), "Jerarquia", "Description", 100, "Description");
			
			//NO CAMBIAR ORDEN DE LAS 2 INSTRUCCIONES SIGUIENTES
			//_uiController.SeleccionarFamilia();
			//mzCEComprobanteTesoreria.FillFromDataSource(_uiController.ListaComprobantesTesoreria, "idTDCompTesoreria", "Descripcion", 100, "1", "2", "Descripcion");	

		}

		private void FillControls()
		{
			mzCEMonedaOrigen.Value = _uiController.IdMonedaReferencia;
			mzCEMonedaOrigen1.Value = _uiController.IdMonedaReferencia;
			//gridEX1.SetValue()=_uiController.IdInstanciaCaja;
			//mzCECajas.Value = _uiController.IdInstanciaCaja;
		}

		private void InitEventHandlers()
		{			
			_uiController.IdTDCompTesoreriaChanged +=new EventHandler(_uiController_IdTDCompTesoreriaChanged);
			_uiController.KeyFamiliaChanged +=new EventHandler(_uiController_KeyFamiliaChanged);
			_uiController.JerarquiaChanged+=new EventHandler(_uiController_JerarquiaChanged);
			chkHabilitaFechaAcreditacion.CheckedChanged +=new EventHandler(chkHabilitaFechaAcreditacion_CheckedChanged);
			chkHabilitaFechaAutorizacion.CheckedChanged +=new EventHandler(chkHabilitaFechaAutorizacion_CheckedChanged);
			chkHabilitaFechaEmision.CheckedChanged +=new EventHandler(chkHabilitaFechaEmision_CheckedChanged);
			chkHabilitaFechaRecepcion.CheckedChanged +=new EventHandler(chkHabilitaFechaRecepcion_CheckedChanged);
			chkHabilitaFechaVencimiento.CheckedChanged +=new EventHandler(chkHabilitaFechaVencimiento_CheckedChanged);
			chkHabilitaImporteDesde.CheckedChanged +=new EventHandler(chkHabilitaImporteDesde_CheckedChanged);
			chkHabilitaImporteHasta.CheckedChanged +=new EventHandler(chkHabilitaImporteHasta_CheckedChanged);
			chkHabilitaFechaIngresoBanco.CheckedChanged +=new EventHandler(chkHabilitaFechaIngresoBanco_CheckedChanged);
			chkHabilitaFechaPago.CheckedChanged +=new EventHandler(chkHabilitaFechaPago_CheckedChanged);
			chkHabilitaCantidadCuotas.CheckedChanged +=new EventHandler(chkHabilitaCantidadCuotas_CheckedChanged);
			chkHabilitaEntidad.CheckedChanged +=new EventHandler(chkHabilitaEntidad_CheckedChanged);
			chkHabilitaFechaIngresoRetencion.CheckedChanged +=new EventHandler(chkHabilitaFechaIngresoRetencion_CheckedChanged);
			chkHabilitaFechaComprobanteRetencion.CheckedChanged +=new EventHandler(chkHabilitaFechaComprobanteRetencion_CheckedChanged);
			chkHabilitaTipoRetencion.CheckedChanged +=new EventHandler(chkHabilitaTipoRetencion_CheckedChanged);
			mzCEMonedaOrigen1.ValueChanged +=new EventHandler(mzCEMonedaOrigen1_ValueChanged);
			mzCEMonedaOrigen.ValueChanged +=new EventHandler(mzCEMonedaOrigen_ValueChanged);
			toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			this.KeyDown +=new KeyEventHandler(FrmConsultaValores_KeyDown);
			_uiController.ModelChanged +=new EventHandler(_uiController_ModelChanged);
			//this.menu.Click +=new EventHandler(menuItemVerCtaCte_Click);
			this.menuItemNinguno.Click+=new EventHandler(menuItemNinguno_Click);
			this.menuItemTodos.Click+=new EventHandler(menuItemTodos_Click);
			KeyDownManager KeyDownMan = new KeyDownManager(this);
            //Cristian Tarea 0000050 20110310
            this.udtFechaEmisionDesde.ValueChanged += new EventHandler(udtFechaEmisionDesde_ValueChanged);
            this.udtFechaVencimientoDesde.ValueChanged += new EventHandler(udtFechaVencimientoDesde_ValueChanged);
            //Fin Cristian
            //Cristian Tarea 0000146 20110725
            this.udtFechaEmisionHasta.ValueChanged += new EventHandler(udtFechaEmisionHasta_ValueChanged);
            this.udtFechaVencimientoHasta.ValueChanged += new EventHandler(udtFechaVencimientoHasta_ValueChanged);
            //Fin Cristian tarea 0000146

        }

        //Cristian Tarea 0000146 20110725
        void udtFechaVencimientoHasta_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(udtFechaVencimientoHasta.Value)), "VENCIMIENTO", true);
            this.udtFechaVencimientoDesde.Value = _uiController.FechaVencimientoDesde;
        }
        
        void udtFechaEmisionHasta_ValueChanged(object sender, EventArgs e)
        {
            //German 20120727 - Tarea 363
            _uiController.updateFechas((Convert.ToDateTime(udtFechaEmisionHasta.Value)), "EMISION", true);
            this.udtFechaEmisionDesde.Value = _uiController.FechaEmsionDesde;
            //Fin German 20120727 - Tarea 363
        }
        //Fin Cristian tarea 0000146
        //Cristian Tarea 0000050 20110310
        void udtFechaVencimientoDesde_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(udtFechaVencimientoDesde.Value)),"VENCIMIENTO",false);
            this.udtFechaVencimientoHasta.Value = _uiController.FechaVencimientoHasta;
        }

        void udtFechaEmisionDesde_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(udtFechaEmisionDesde.Value)),"EMISION",false);
            this.udtFechaEmisionHasta.Value = _uiController.FechaEmsionHasta;
        }

        //Fin Cristian	
		private void InitDataBindings()
		{				
			BindingController.Bind(mzCEComprobanteTesoreria, "Value", _uiController, "IdTDCompTesoreria");
			//BindingController.Bind(mzCEFamiliaFormaDePago, "Value", _uiController, "KeyFamilia");
			BindingController.Bind(mzCEFamiliaFormaDePago, "Value", _uiController, "Jerarquia");
			gridEX1.DataBindings.Clear();
			gridEX1.SetDataBinding( _uiController.FiltroCajas , null );
		}

		private void FilterColumns()
		{
			if(gridResultado.RootTable != null)
			{
				foreach(Janus.Windows.GridEX.GridEXColumn col in gridResultado.RootTable.Columns)
				{
					string columnCaption = col.Key;
					
					if(!_uiController.PerteneceDatosPrincipales(columnCaption))
					{
						if(_uiController.VisualizaColumna(columnCaption))
						{
							col.Visible = true;
						}
						else
						{
							col.Visible = false;
						}
					}

				}
			}
		}

		private void Search()
		{
			DumpControls();
			if(_uiController.IsValid())
			{
				System.Data.DataView view = _uiController.Search(); 
				gridResultado.DataSource = view;
				if (gridManagerView1.AllowExportExcel || gridManagerView1.AllowSortByAgregateColumn)
					gridManagerView1.SetTable(view.Table);
			}
			else
				MessageBox.Show(_uiController.ErrorMessage, "Faltan Filtros", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop);
		}
		
		#endregion

		#region Manejadores de Eventos

		private void _uiController_ModelChanged(object sender, EventArgs e)
		{
			mzCEComprobanteTesoreria.FillFromDataSource(_uiController.ListaComprobantesTesoreria, "idTDCompTesoreria", "Descripcion", 100, "1", "2", "Descripcion");	
		}

		private void _uiController_KeyFamiliaChanged(object sender, EventArgs e)
		{
			ConfigurePanels();
			FilterColumns();
			mzCEEntidad.FillFromDataSource(_uiController.ListaEntidades,"IdEntidad","Entidad",100,"Entidad");
		}

		private void _uiController_IdTDCompTesoreriaChanged(object sender, EventArgs e)
		{
			ConfigurePanels();
			FilterColumns();
			mzCEEntidad.FillFromDataSource(_uiController.ListaEntidades,"IdEntidad","Entidad",100,"Entidad");
		}

		private void chkHabilitaFechaAcreditacion_CheckedChanged(object sender, EventArgs e)
		{
			fechaAcreditacion.Enabled = chkHabilitaFechaAcreditacion.Checked;
		}

		private void chkHabilitaFechaAutorizacion_CheckedChanged(object sender, EventArgs e)
		{
			fechaAutorizacion.Enabled = chkHabilitaFechaAutorizacion.Checked;
		}

		private void chkHabilitaFechaEmision_CheckedChanged(object sender, EventArgs e)
		{
			udtFechaEmisionDesde.Enabled = chkHabilitaFechaEmision.Checked;
			udtFechaEmisionHasta.Enabled = chkHabilitaFechaEmision.Checked;
		}

		private void chkHabilitaFechaRecepcion_CheckedChanged(object sender, EventArgs e)
		{
			fechaRecepcion.Enabled = chkHabilitaFechaRecepcion.Checked;
		}

		private void chkHabilitaFechaVencimiento_CheckedChanged(object sender, EventArgs e)
		{
			udtFechaVencimientoDesde.Enabled = chkHabilitaFechaVencimiento.Checked;
			udtFechaVencimientoHasta.Enabled = chkHabilitaFechaVencimiento.Checked;
		}

		private void chkHabilitaImporteDesde_CheckedChanged(object sender, EventArgs e)
		{
			uneImporteDesde.Enabled = chkHabilitaImporteDesde.Checked;
			mzCEMonedaOrigen.Enabled = chkHabilitaImporteDesde.Checked;
		}

		private void chkHabilitaImporteHasta_CheckedChanged(object sender, EventArgs e)
		{
			uneImporteHasta.Enabled = chkHabilitaImporteHasta.Checked;
			mzCEMonedaOrigen1.Enabled = chkHabilitaImporteHasta.Checked;
		}

		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				/*Buscar*/
				case 0: 
				{
					Search();
				}
				break;
				/*Nueva Busqueda*/					
				case 2:
					ResetFilters();
					break;
				/*Nuevo*/
				case 4: 
					break;
				/*Editar*/
				case 6:
					break;
				
				case 8: 
				/*Anterior*/
				_uiController.Previous();
				break;
				case 10:
				/*Siguiente*/
				{
					gridResultado.UpdateData();
					_uiController.Execute();
				}
				break;
				/*Aceptar*/
				case 12: 
				{
					this.gridResultado.UpdateData();
					_uiController.ProcessObjectsObserver();
					this.Close();
				}
					break;
				/*Cancelar*/
				case 14:
				{
					this.CloseForm();
				}
					break;
				
						
			}		

		}

		private void ResetFilters()
		{
			//mzCECajas.Value = string.Empty;
			//gridEX1.SetValue()=string.Empty;
			mzCEComprobanteTesoreria.Value = string.Empty;
			mzCEFamiliaFormaDePago.Value = string.Empty;
			chkHabilitaCantidadCuotas.Checked = false;
			chkHabilitaEntidad.Checked = false;
			chkHabilitaFechaAcreditacion.Checked = false;
			chkHabilitaFechaAutorizacion.Checked = false;
			chkHabilitaFechaComprobanteRetencion.Checked = false;
			chkHabilitaFechaEmision.Checked = false;
			chkHabilitaFechaIngresoBanco.Checked = false;
			chkHabilitaFechaIngresoRetencion.Checked = false;
			chkHabilitaFechaPago.Checked = false;
			chkHabilitaFechaRecepcion.Checked = false;
			chkHabilitaFechaVencimiento.Checked = false;
			chkHabilitaImporteDesde.Checked = false;
			chkHabilitaImporteHasta.Checked = false;
			chkHabilitaTipoRetencion.Checked = false;
			esCliente.Checked = false;
			uneCantidadCuotas.Value = uneCantidadCuotas.MinValue;
			uneImporteDesde.Value = 0;
			uneImporteHasta.Value = 0;
			udtFechaComprobanteRetencion.Value = DateTime.Now;
			udtFechaEmisionDesde.Value = DateTime.Now;
			udtFechaEmisionHasta.Value = DateTime.Now;
			udtFechaIngresoRetencion.Value = DateTime.Now;
			udtFechaVencimientoDesde.Value = DateTime.Now;
			udtFechaVencimientoHasta.Value = DateTime.Now;
			fechaAcreditacion.Value = DateTime.Now;
			fechaAutorizacion.Value = DateTime.Now;
			fechaIngresoBanco.Value = DateTime.Now;
			fechaPago.Value = DateTime.Now;
			fechaRecepcion.Value = DateTime.Now;
			codigoAutorizacion.Text = string.Empty;
			codigoDiez.Text = string.Empty;
			cuentaBancaria.Text = string.Empty;
			cupon.Text = string.Empty;
			sucursal.Text = string.Empty;
			librador.Text = string.Empty;
			NroBoleta.Text = string.Empty;
			txtNumero.Text = string.Empty;
			mzCEEntidad.Value = string.Empty;
			_uiController.Reset();
			gridResultado.SetDataBinding(null, null);
			gridResultado.Refresh();
			//Deselecciona todos
			_uiController.TildarNingunoCaja();
			gridEX1.DataBindings.Clear();
			gridEX1.SetDataBinding( _uiController.FiltroCajas , null );
		}

		private void chkHabilitaCantidadCuotas_CheckedChanged(object sender, EventArgs e)
		{
			uneCantidadCuotas.Enabled = chkHabilitaCantidadCuotas.Checked;
		}

		private void chkHabilitaFechaIngresoBanco_CheckedChanged(object sender, EventArgs e)
		{
			fechaIngresoBanco.Enabled = chkHabilitaFechaIngresoBanco.Checked;
		}

		private void chkHabilitaFechaPago_CheckedChanged(object sender, EventArgs e)
		{
			fechaPago.Enabled = chkHabilitaFechaPago.Checked;
		}

		private void mzCEMonedaOrigen_ValueChanged(object sender, EventArgs e)
		{
			if(mzCEMonedaOrigen1.Value != mzCEMonedaOrigen.Value)
				mzCEMonedaOrigen1.Value = mzCEMonedaOrigen.Value;
		}

		private void mzCEMonedaOrigen1_ValueChanged(object sender, EventArgs e)
		{
			if(mzCEMonedaOrigen1.Value != mzCEMonedaOrigen.Value)
				mzCEMonedaOrigen.Value = mzCEMonedaOrigen1.Value;
		}

		private void chkHabilitaEntidad_CheckedChanged(object sender, EventArgs e)
		{
			mzCEEntidad.Enabled = chkHabilitaEntidad.Checked;
			
		}

		private void FrmConsultaValores_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == System.Windows.Forms.Keys.F2)
				this.Search();
			if(e.KeyCode == System.Windows.Forms.Keys.PageDown)
				gridResultado.Focus();
					
		}

		private void chkHabilitaFechaIngresoRetencion_CheckedChanged(object sender, EventArgs e)
		{
			udtFechaIngresoRetencion.Enabled = chkHabilitaFechaIngresoRetencion.Checked;
		}

		private void chkHabilitaFechaComprobanteRetencion_CheckedChanged(object sender, EventArgs e)
		{
			udtFechaComprobanteRetencion.Enabled = chkHabilitaFechaComprobanteRetencion.Checked;
		}

		private void chkHabilitaTipoRetencion_CheckedChanged(object sender, EventArgs e)
		{
			mzCmbTipoRetenciones.Enabled = chkHabilitaTipoRetencion.Checked;
		}

		#endregion

		#region Metodos Privados



		private void DumpControls()
		{
			/*Datos Principales*/
			_uiController.HabilitaBusquedaFechaEmision = chkHabilitaFechaEmision.Checked;
			_uiController.FechaEmsionDesde = Convert.ToDateTime(udtFechaEmisionDesde.Value);
			_uiController.FechaEmsionHasta = Convert.ToDateTime(udtFechaEmisionHasta.Value);
			_uiController.HabilitaBusquedaFechaVencimiento = chkHabilitaFechaVencimiento.Checked;
			_uiController.FechaVencimientoDesde = Convert.ToDateTime(udtFechaVencimientoDesde.Value);
			_uiController.FechaVencimientoHasta = Convert.ToDateTime(udtFechaVencimientoHasta.Value);
			_uiController.HabilitaBusquedaEntidad = chkHabilitaEntidad.Checked;
			_uiController.IdEntidad = Convert.ToString(mzCEEntidad.Value);
			//_uiController.IdInstanciaCaja = Convert.ToString(mzCECajas.Value);
			//_uiController.IdInstanciaCaja = Convert.ToString(gridEX1.GetValue());
			//Actualiza IdInstancia de Caja con lo seleccionado en la grilla de cajas
			gridEX1.UpdateData();
			_uiController.Refresh();

			_uiController.IdMoneda = Convert.ToString(mzCEMonedaOrigen.Value);
			_uiController.Numero = Convert.ToString(txtNumero.Text);
			_uiController.HabilitaBusquedaMontoDesde = chkHabilitaImporteDesde.Checked;
			_uiController.MontoDesde = Convert.ToDecimal(uneImporteDesde.Value);
			_uiController.HabilitaBusquedaMontoHasta = chkHabilitaImporteHasta.Checked;
			_uiController.Montohasta = Convert.ToDecimal(uneImporteHasta.Value);
			

			/*Datos Auxiliares Tarjetas*/
            
			_uiController.HabilitaBusquedaCantidadCuotas = chkHabilitaCantidadCuotas.Checked;
			_uiController.CantidadCuotas = Convert.ToInt16(uneCantidadCuotas.Value);
			_uiController.HabilitaBusquedaFechaAcreditacion = chkHabilitaFechaAcreditacion.Checked;
			_uiController.FechaDeAcreditacion = Convert.ToDateTime(fechaAcreditacion.Value);
			_uiController.HabilitaBusquedaFechaAutorizacion = chkHabilitaFechaAutorizacion.Checked;
			_uiController.FechaDeAutorizacion = Convert.ToDateTime(fechaAutorizacion.Value);
			_uiController.CodigoAutorizacion = codigoAutorizacion.Text;
			_uiController.CodigoDiez = codigoDiez.Text;
			_uiController.Cupon = cupon.Text;
			_uiController.Lote = lote.Text;

			/*Datos Auxiliares Cheques*/

			_uiController.HabilitaBusquedaFechaIngresoBanco = chkHabilitaFechaIngresoBanco.Checked;
			_uiController.FechaIngresoBanco = Convert.ToDateTime(fechaIngresoBanco.Value);
			_uiController.HabilitaBusquedaFechaPago = chkHabilitaFechaPago.Checked;
			_uiController.FechaDePago = Convert.ToDateTime(fechaPago.Value);
			_uiController.HabilitaBusquedaFechaRecepcion = chkHabilitaFechaRecepcion.Checked;
			_uiController.FechaDeRecepcion = Convert.ToDateTime(fechaRecepcion.Value);
			_uiController.CuentaBancaria = cuentaBancaria.Text;
			_uiController.IdCuenta = mzCmbSearchLibrador.DataValue;
			_uiController.Librador = librador.Text;
			_uiController.NroBoleta = NroBoleta.Text;
			_uiController.Sucursal = sucursal.Text;

			/*Datos Retenciones*/

			_uiController.HabilitaBusquedaTipoRetencion = chkHabilitaTipoRetencion.Checked;;
			_uiController.IdTipoDeRetencion = Convert.ToString(mzCmbTipoRetenciones.Value);
			_uiController.HabilitaBusquedaFechaIngresoRetencion = chkHabilitaFechaIngresoRetencion.Checked;
			_uiController.FechaIngresoRetencion = Convert.ToDateTime(udtFechaIngresoRetencion.Value);
			_uiController.HabilitaBusquedaFechaComprobanteRetencion = chkHabilitaFechaComprobanteRetencion.Checked;
			_uiController.FechaComprobanteRetencion = Convert.ToDateTime(udtFechaComprobanteRetencion.Value);
			
			
			

		}

		#endregion

		#region Metodos Publicos

		public void AddObjectListener(IObserver observer)
		{
			_uiController.AddObjectListener(observer);
		}


		#endregion

//Vivi, seria para boton derecho todos o ninguno
	

		private void menuItemNinguno_Click(object sender, EventArgs e)
		{	_uiController.TildarNingunoCaja();
			gridEX1.DataBindings.Clear();
			gridEX1.SetDataBinding( _uiController.FiltroCajas , null );
		}

		private void menuItemTodos_Click(object sender, EventArgs e)
		{
			_uiController.TildarTodosCaja();
			gridEX1.DataBindings.Clear();
			gridEX1.SetDataBinding( _uiController.FiltroCajas , null );
		}

		private void _uiController_JerarquiaChanged(object sender, EventArgs e)
		{

		}
	}
}
